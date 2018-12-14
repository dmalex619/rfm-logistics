using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

using DataDynamics.ActiveReports; 

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics
{
	public partial class frmTripsPrintDocuments : RFMFormChild
	{
		private Trip oTrip;

		private OutputDocument oOutputDocumentForPrint = null;
		private Input oInputForPrint = null;

		private decimal nVatTransport = 18;
		private decimal nVatVeterinaryPayment = 18;

		public frmTripsPrintDocuments(Trip _oTrip)
		{
			oTrip = _oTrip;
			InitializeComponent();
		}

		public frmTripsPrintDocuments(Trip _oTrip, OutputDocument _oOutputDocumentForPrint)
		{
			oTrip = _oTrip;
			oOutputDocumentForPrint = _oOutputDocumentForPrint;
			InitializeComponent();
		}

		public frmTripsPrintDocuments(Trip _oTrip, Input _oInputForPrint)
		{
			oTrip = _oTrip;
			oInputForPrint = _oInputForPrint;
			InitializeComponent();
		}


		private void frmTripsPrintDocuments_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			oTrip.FillData();
			if (oTrip.ErrorNumber != 0 || oTrip.MainTable == null || oTrip.MainTable.Rows.Count == 0)
			{
				bResult = false;
			}
			else
			{
				if (oTrip.MainTable.Rows.Count == 1)
				{
					oTrip.FillOne(oTrip.MainTable.Rows[0]);
					lblTripAlias.Text = oTrip.Alias;

					// если рейс на самовывоз - запретить печать маршрутного листа и доверенностей
					if (oTrip.SelfDelivery)
					{
						chkTripBill.Enabled =
						chkTripBillShort.Enabled =
                        chkDrivingScheme.Enabled = 
						chkWarrant.Enabled =
							false; 
					}
				}
				else
				{
					lblTripAlias.Text = RFMUtilities.Declen(oTrip.MainTable.Rows.Count, "рейс", "рейса", "рейсов") + ":"; 
				}

				btnClearAll_Click(null, null);
				chkBill.Checked =
				chkFacture.Checked =
                chkPayBill.Checked = 
                chkQuality.Checked = 
				chkInputBillReturn.Checked = 
				chkInputWarrant.Checked = 
					true;

                // Условная отметка
                if (chkTripBill.Enabled || chkTripBillShort.Enabled)
                    chkTripBill.Checked = chkTripBillShort.Checked = chkDrivingScheme.Checked = true;
                if (chkWarrant.Enabled)
                    chkWarrant.Checked = true;

				chkBill_CheckedChanged(null, null);
			}

			if (oOutputDocumentForPrint != null || oInputForPrint != null)
			{
				chkTripBill.Checked =
				chkTripBillShort.Checked =
				chkTripBill.Enabled =
				chkTripBillShort.Enabled =
					false;
				pnlTotalSort.Enabled =
					false;
				if (oOutputDocumentForPrint != null)
				{
					// печать для одного расх.документа
					chkInputBillReturn.Checked =
					chkInputWarrant.Checked =
					chkInputBillReturn.Enabled =
					chkInputWarrant.Enabled =
						false;
					Text += ": расходный документ";
					lblOutputs.Text += " " + oOutputDocumentForPrint.PartnerBayerFactName;
				}
				if (oInputForPrint != null)
				{
					// печать для одного прихода
					chkBill.Checked =
					chkFacture.Checked=
					chkPayBill.Checked =
					chkWarrant.Checked =
					chkQuality.Checked =
					chkVeterinary.Checked =
					chkBill.Enabled =
					numBillCopies.Enabled =
					chkFacture.Enabled =
					chkPayBill.Enabled =
					chkWarrant.Enabled =
					chkQuality.Enabled =
					chkVeterinary.Enabled =
						false;
					Text += ": приход";
					lblInputs.Text += ": " + oInputForPrint.PartnerName;
				}
			}

			if (!bResult)
			{
				Dispose();
			}
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (!chkTripBill.Checked &&
				!chkTripBillShort.Checked &&
                !chkDrivingScheme.Checked && 
				!chkBill.Checked &&
				!chkFacture.Checked &&
				!chkPayBill.Checked &&
				!chkVeterinary.Checked &&
				!chkQuality.Checked &&
				!chkWarrant.Checked && 
				!chkInputBillReturn.Checked &&  
				!chkInputWarrant.Checked )
			{
				RFMMessage.MessageBoxError("Не выбраны документы для печати...");
				return;
			}

			bool bReady = false;

			if (oOutputDocumentForPrint == null && oInputForPrint == null)
			{
				bReady = Trip_Print();
			}
			else
			{
				if (oOutputDocumentForPrint != null)
				{
					bReady = OutputDocument_Print();
				}
				else
				{
					bReady = Input_Print();
				}
			}

			// если документы показаны/напечатаны, закрываем форму 
			if (bReady)
			{
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

	#region Print

	#region Trips

		private bool Trip_Print()
		{
			bool bTripPrint = 
				chkTripBill.Checked || 
				chkTripBillShort.Checked ||
                chkDrivingScheme.Checked;
			bool bOutputDocumentPrint = 
				chkBill.Checked || 
				chkFacture.Checked || 
				chkPayBill.Checked ||
				chkVeterinary.Checked || 
				chkQuality.Checked || 
				chkWarrant.Checked;
			bool bInputDocumentPrint = 
				chkInputBillReturn.Checked || 
				chkInputWarrant.Checked;

			Trip oTripTemp = new Trip();
			OutputDocument oOutputDocumentTemp = new OutputDocument();
			Input oInputTemp = new Input();

			ArrayList a_Dt = new ArrayList();
			ArrayList a_Rep = new ArrayList();
			ArrayList a_Cnt = new ArrayList();

			// список обработанных заказов
			DataTable tOutputsDocuments = new DataTable();
			tOutputsDocuments.Columns.Add("ID", Type.GetType("System.Int32"));
			tOutputsDocuments.PrimaryKey = new DataColumn[] { tOutputsDocuments.Columns["ID"] };
			string sOutputsDocumentsList = "";

			DataTable tInputs = new DataTable();
			tInputs.Columns.Add("ID", Type.GetType("System.Int32"));
			tInputs.PrimaryKey = new DataColumn[] { tInputs.Columns["ID"] };
			string sInputsList = "";

			DataTable tOutputsDocumentsInTrip = null;

			// идем по списку рейсов 
			foreach (DataRow rTrip in oTrip.MainTable.Rows)
			{
				oTripTemp.FillOne(rTrip);

				#region документы по машине

				// маршрутный лист (полный, краткий)
				if (chkTripBill.Checked || chkTripBillShort.Checked)
				{
					bool bPrint = true;
					if (oTripTemp.SelfDelivery)
					{
						//RFMMessage.MessageBoxError("Рейс \"" + oTripTemp.Alias + "\" оформлен на машину клиента.\n" +
						//	"Маршрутный лист не печатается.");
						bPrint = false; 
					}
					else
					{
						if (!oTripTemp.DriverEmployeeID.HasValue && oTripTemp.DriverName.Length == 0)
						{
							RFMMessage.MessageBoxError("Для рейса \"" + oTripTemp.Alias + "\" не определен водитель.\n" +
								"Маршрутный лист не печатается.");
							bPrint = false;
						}

						if (bPrint)
						{
							if (!oTripTemp.DateBeg.HasValue)
							{
								// Автоматическое начало рейса при печати маршрутного листа
								if (oTripTemp.ID.HasValue)
								{
									int nTripID = (int)oTripTemp.ID;
									oTripTemp.SetDateTime(nTripID, "BEG", "FACT", DateTime.Now, null);
								}
								else
								{
									/*RFMMessage.MessageBoxError("Рейс \"" + oTripTemp.Alias + "\" еще не начат.\n" +
										"Маршрутный лист не печатается.");
									bPrint = false;*/
								}
							}
						}
					}
					if (bPrint)
					{
						// маршрутный лист полный
						if (chkTripBill.Checked)
						{
							LogService.TripBill_Print(oTripTemp, new TripBill(), this, true,
								ref a_Dt, ref a_Rep, ref a_Cnt, 1);
						}
						// маршрутный лист краткий 
						if (chkTripBillShort.Checked)
						{
							LogService.TripBill_Print(oTripTemp, new TripBillShort(), this, true,
									ref a_Dt, ref a_Rep, ref a_Cnt, 1);
						}
					}
				}

                // Печать схем проезда
                if (chkDrivingScheme.Checked && 
                    oTripTemp.FillTableDrivingSchemes(oTripTemp.ID.ToString()) &&
                    oTripTemp.TableDrivingSchemes.Rows.Count > 0)
                {
                    // только сохраняем в массивы
                    a_Dt.Add(oTripTemp.TableDrivingSchemes);
                    a_Rep.Add(new DrivingScheme());
                    a_Cnt.Add(1);
                    //this.StartForm(new frmActiveReport(oTripTemp.TableDrivingSchemes, new DrivingScheme()));
                }

				#endregion документы по машине

				#region документы по расходным документам

				tOutputsDocumentsInTrip = null;

				if (bOutputDocumentPrint)
				{
					// получаем список заказов
					oTripTemp.FillTableOutputsDocumentsInTrip();

					if (oTripTemp.TableOutputsDocumentsInTrip.Rows.Count > 0)
					{
						bool bTripAllOutputsDocumentsConfirmed = true;

						// все ли готово, стоит ли печатать 
						foreach (DataRow rOutputDocument in oTripTemp.TableOutputsDocumentsInTrip.Rows)
						{
							oOutputDocumentTemp.FillOne(rOutputDocument);
							// хотя бы один расходный документ еще не подтвержден
							if (!oOutputDocumentTemp.IsConfirmed)
							{
								RFMMessage.MessageBoxError("Рейс: " + oTripTemp.Alias + ":\n" +
									"для раcходного документа \"" + oOutputDocumentTemp.PartnerTargetName + "\" (код " + oOutputDocumentTemp.ID.ToString() + ") " +
									"еще не подтверждена отгрузка со склада.\n" +
									"Документы по рейсу не печатаются.");
								bTripAllOutputsDocumentsConfirmed = false;
								break;
							}
						}

						if (bTripAllOutputsDocumentsConfirmed)
						{
							if (oTripTemp.IsPostern)
							{
								// ЗД - порядок печати обратный порядку загрузки
								tOutputsDocumentsInTrip = CopyTable(oTripTemp.TableOutputsDocumentsInTrip, "tOutputsDocumentsInTrip", "", "ByOrder desc, PartnerTargetName");
							}
							else
							{
								tOutputsDocumentsInTrip = CopyTable(oTripTemp.TableOutputsDocumentsInTrip, "tOutputsDocumentsInTrip", "", "ByOrder, PartnerTargetName");
							}
						
							#region по заказам

							if (optTotalSortByOrders.Checked)
							{
								// в порядке заказов
								foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
								{
									oOutputDocumentTemp.FillOne(rOutputDocument);

									// документы уже напечатаны?
									if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
										continue;

									// накладная
									if (chkBill.Checked && (int)numBillCopies.Value != 0)
									{
										LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "BILL", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);

										// акт на трансп.услуги
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportAct_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value);
										}

										// накладная на оформление вет.св-в
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "BILL", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);
										}
									}

									// счет-фактура
									if (chkFacture.Checked && oOutputDocumentTemp.PF_FactureNeed)
									{
                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "FACTURE", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);

										// счет-фактура на трансп.услуги
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportFacture_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1); 
										}

										// счет-фактура на оформление вет.св-в
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "FACTURE", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);
										}
									}

									// счет
									if (chkPayBill.Checked && oOutputDocumentTemp.PF_PayBillNeed)
									{
                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "INVOICE", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

									// вет.св-ва
									if (chkVeterinary.Checked)
									{
										LogService.OutputDocumentVeterinary_Print(oOutputDocumentTemp, true, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

                                    // списки деклараций
									if (chkQuality.Checked)
									{
										LogService.OutputDocumentQuality_Print(oOutputDocumentTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

									// доверенность
                                    // не печатается для рейсов самовывоза, арендованных машин и доставке нашими машинами до перевозчика
									/*if (chkWarrant.Checked && oOutputDocumentTemp.PF_WarrantNeed && 
										!oTripTemp.SelfDelivery && !oTripTemp.IsRentCar && !oTrip.PartnerCarrierID.HasValue)*/
                                    // Изменение от 06.08.2018
                                    // В связи с тем, что хозяин товара может быть и перевозчиком, последнее условие заблокировано
                                    if (chkWarrant.Checked && 
                                        oOutputDocumentTemp.PF_WarrantNeed && 
                                        !oTripTemp.SelfDelivery && !oTripTemp.IsRentCar)
                                    {
                                            LogService.OutputDocumentWarrant_Print(oOutputDocumentTemp, this, true, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

									// записали, что обработали заказ
									tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
									sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
								}
							}

							#endregion по заказам

							#region по типам документов

							if (optTotalSortByTypes.Checked)
							{
								// накладная
								if (chkBill.Checked && (int)numBillCopies.Value > 0)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// уже напечатан?
										if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
											continue;

                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "BILL", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);

										// акт на трансп.услуги
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportAct_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value);
										}

										// накладная на оформление вет.св-в
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "BILL", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);
										}

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											// записали, что обработали заказ
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}

								// счет-фактура
								if (chkFacture.Checked)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// уже напечатан?
										if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
											continue;
										// не нужен
										if (!oOutputDocumentTemp.PF_FactureNeed)
											continue;

										// еще не подтвержден
										if (!oOutputDocumentTemp.IsConfirmed)
										{
											RFMMessage.MessageBoxError("Рейс: " + oTripTemp.Alias + ":\n" +
												"для раcходного документа \"" + oOutputDocumentTemp.PartnerTargetName + "\" (код " + oOutputDocumentTemp.ID.ToString() + ") " +
												"еще не подтверждена отгрузка со склада.\n" +
												"Документы по рейсу не печатаются.");
											continue;
										}

                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "FACTURE", this, true, (0 == 1), true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);

										// счет-фактура на трансп.услуги
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportFacture_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1);
										}

										// счет-фактура на оформление вет.св-в
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "FACTURE", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);
										}

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}

								// счет
								if (chkPayBill.Checked)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// не нужен
										if (!oOutputDocumentTemp.PF_PayBillNeed)
											continue;

                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "INVOICE", this, true, (0 == 1), true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}

								// вет.св-ва
								if (chkVeterinary.Checked)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										LogService.OutputDocumentVeterinary_Print(oOutputDocumentTemp, true, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}

                                // списки деклараций
								if (chkQuality.Checked)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										LogService.OutputDocumentQuality_Print(oOutputDocumentTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}

								// доверенность
								if (chkWarrant.Checked && 
									!oTripTemp.SelfDelivery && !oTripTemp.IsRentCar)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// документы уже напечатаны?
										if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
											continue;
										// не нужна?
										if (!oOutputDocumentTemp.PF_WarrantNeed)
											continue;

										LogService.OutputDocumentWarrant_Print(oOutputDocumentTemp, this, true, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}
							}

							#endregion по типам документов
						}
					}
				}
				
				#endregion документы по расходным документам

				#region документы по приходам
				
				if (bInputDocumentPrint)
				{
					// получаем список приходов
					oTripTemp.FillTableInputsInTrip();

					if (oTripTemp.TableInputsInTrip.Rows.Count > 0)
					{
						#region по заказам

						if (optTotalSortByOrders.Checked)
						{
							// в порядке заказов
							foreach (DataRow rInput in oTripTemp.TableInputsInTrip.Rows)
							{
								oInputTemp.FillOne(rInput);

								/*
								// документы уже напечатаны?
								if (oInputTemp.IsPrinted && !chkRepeat.Checked)
									continue;
								*/

								// возвратная накладная
								if (chkInputBillReturn.Checked && oInputTemp.IsReturn)
								{
									LogService.InputReturnBill_Print(oInputTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
								}

								// доверенность 
								if (chkInputWarrant.Checked && oInputTemp.PF_WarrantNeed && 
									!oTripTemp.SelfDelivery && 
									(!oTripTemp.IsRentCar || !oInputTemp.IsReturn) )
								{
									LogService.InputWarrant_Print(oInputTemp, this, true, true,
										ref a_Dt, ref a_Rep, ref a_Cnt, 1);
								}

								// записали, что обработали заказ
								tInputs.Rows.Add(oInputTemp.ID);
								sInputsList += oInputTemp.ID.ToString() + ",";
							}
						}
	
						#endregion по заказам

						#region по типам документов

						if (optTotalSortByTypes.Checked)
						{
							// вовзратная накладная 
							if (chkInputBillReturn.Checked)
							{
								foreach (DataRow rInput in oTripTemp.TableInputsInTrip.Rows)
								{
									oInputTemp.FillOne(rInput);
									
									/*
									// уже напечатан?
									if (oInputTemp.IsPrinted && !chkRepeat.Checked)
										continue;
									*/
									
									if (!oInputTemp.IsReturn)
										continue;
										
									LogService.InputReturnBill_Print(oInputTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									
									if (tInputs.Rows.Find((int)oInputTemp.ID) == null)
									{
										// записали, что обработали приход
										tInputs.Rows.Add(oInputTemp.ID);
										sInputsList += oInputTemp.ID.ToString() + ",";
									}
								}
							}

							// доверенность
							if (chkInputWarrant.Checked && 
								!oTripTemp.SelfDelivery)
							{
								foreach (DataRow rInput in oTripTemp.TableInputsInTrip.Rows)
								{
									oInputTemp.FillOne(rInput);

									/*
									// документы уже напечатаны?
									if (oInputTemp.IsPrinted && !chkRepeat.Checked)
										continue;
									*/

									// не нужна?
									if (!oInputTemp.PF_WarrantNeed)
										continue;
									// аренда - только на товар (не возврат)
									if (oTripTemp.IsRentCar && oInputTemp.IsReturn)
										continue;

									LogService.InputWarrant_Print(oInputTemp, this, true, true,
										ref a_Dt, ref a_Rep, ref a_Cnt, 1);

									if (tInputs.Rows.Find((int)oInputTemp.ID) == null)
									{
										tInputs.Rows.Add(oInputTemp.ID);
										sInputsList += oInputTemp.ID.ToString() + ",";
									}
								}
							}

							#endregion по типам документов
						}
					}
				}

				#endregion документы по приходам
			}

			if (a_Dt.Count > 0)
			{
				DataTable[] aDt = new DataTable[a_Dt.Count];
				a_Dt.CopyTo(aDt);

				ActiveReport3[] aRep = new ActiveReport3[a_Dt.Count];
				a_Rep.CopyTo(aRep);

				int[] aCnt = new int[a_Dt.Count];
				a_Cnt.CopyTo(aCnt);

				// собственно печать 
				if (chkDirectToPrinter.Checked)
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt, true));
				}
				else
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt));
				}

				// отметка печати
                if (bOutputDocumentPrint && (chkBill.Checked || chkFacture.Checked))
				{
					int nUserID = ((RFMFormMain)Application.OpenForms[0]).UserID;
					// машина
					foreach (DataRow rTrip in oTrip.MainTable.Rows)
					{
						oTripTemp.SetDatePrint((int)rTrip["ID"], false, nUserID);
					}
					// заказы
					foreach (DataRow rOutputDocument in tOutputsDocuments.Rows)
					{
						oOutputDocumentTemp.SetDatePrint((int)rOutputDocument["ID"], false, nUserID);
					}
				}
			}
			else
			{
				RFMMessage.MessageBoxError("Нет данных для печати...");
				return (false);
			}

			return (true);
		}

	#endregion Trips

	#region OutputDocument

		private bool OutputDocument_Print()
		{
			if (!(chkBill.Checked ||
				chkFacture.Checked ||
				chkPayBill.Checked ||
				chkVeterinary.Checked ||
				chkQuality.Checked ||
				chkWarrant.Checked))
			{
				RFMMessage.MessageBoxError("Не выбраны документы для печати (расходный документ)...");
				return (false);
			}

			OutputDocument oOutputDocumentTemp = new OutputDocument();
			oOutputDocumentTemp.ReFillOne((int)oOutputDocumentForPrint.ID);

			// проверки для расходного документа 
			if (!oOutputDocumentTemp.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Для раcходного документа \"" + oOutputDocumentTemp.PartnerTargetName + "\" (код " + oOutputDocumentTemp.ID.ToString() + ") " +
					"еще не подтверждена отгрузка со склада.\n" +
					"Документы не печатаются.");
				return (false);
			}

			if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
			{
				RFMMessage.MessageBoxError("Для раcходного документа \"" + oOutputDocumentTemp.PartnerTargetName + "\" (код " + oOutputDocumentTemp.ID.ToString() + ") " +
					"документы уже напечатаны.");
				return (false);
			}

			Trip oTripTemp = new Trip();
			oTripTemp.ReFillOne((int)oOutputDocumentTemp.TripID);

			ArrayList a_Dt = new ArrayList();
			ArrayList a_Rep = new ArrayList();
			ArrayList a_Cnt = new ArrayList();
			
			// накладная
			if (chkBill.Checked && (int)numBillCopies.Value != 0)
			{
                LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "BILL", this, true, (0 == 1), true,
					ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);

				// акт на трансп.услуги
				if (oOutputDocumentTemp.DeliveryPrice != 0)
				{
					LogService.OutputDocumentTransportAct_Print(oOutputDocumentTemp, nVatTransport, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value);
				}

				// накладная на оформление вет.св-в
				if (oOutputDocumentTemp.VeterinaryPrice != 0)
				{
					LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "BILL", nVatVeterinaryPayment, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);
				}
			}

			// счет-фактура
			if (chkFacture.Checked && oOutputDocumentTemp.PF_FactureNeed)
			{
                LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "FACTURE", this, true, (0 == 1), true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);

				// счет-фактура на трансп.услуги
				if (oOutputDocumentTemp.DeliveryPrice != 0)
				{
					LogService.OutputDocumentTransportFacture_Print(oOutputDocumentTemp, nVatTransport, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1);
				}

				// счет-фактура на оформление вет.св-в
				if (oOutputDocumentTemp.VeterinaryPrice != 0)
				{
					LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "FACTURE", nVatVeterinaryPayment, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);
				}
			}

			// счет
			if (chkPayBill.Checked && oOutputDocumentTemp.PF_PayBillNeed)
			{
                LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "INVOICE", this, true, (0 == 1), true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			// вет.св-ва
			if (chkVeterinary.Checked)
			{
				LogService.OutputDocumentVeterinary_Print(oOutputDocumentTemp, true, this, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

            // списки деклараций
			if (chkQuality.Checked)
			{
				LogService.OutputDocumentQuality_Print(oOutputDocumentTemp, this, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			// доверенность 
			if (chkWarrant.Checked && oOutputDocumentTemp.PF_WarrantNeed &&
				!oTripTemp.SelfDelivery && !oTripTemp.IsRentCar)
			{
				LogService.OutputDocumentWarrant_Print(oOutputDocumentTemp, this, true, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			if (a_Dt.Count > 0)
			{
				DataTable[] aDt = new DataTable[a_Dt.Count];
				a_Dt.CopyTo(aDt);

				ActiveReport3[] aRep = new ActiveReport3[a_Dt.Count];
				a_Rep.CopyTo(aRep);

				int[] aCnt = new int[a_Dt.Count];
				a_Cnt.CopyTo(aCnt);

				// собственно печать 
				if (chkDirectToPrinter.Checked)
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt, true));
				}
				else
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt));
				}

				// отметка печати
				if (chkBill.Checked || chkFacture.Checked)
				{
					int nUserID = ((RFMFormMain)Application.OpenForms[0]).UserID;
					oOutputDocumentTemp.SetDatePrint((int)oOutputDocumentTemp.ID, false, nUserID);
				}
			}
			else
			{
				RFMMessage.MessageBoxError("Нет данных для печати (расходный документ)...");
				return (false);
			}
			
			return (true);
		}
	
	#endregion OutputDocument

	#region Input

		private bool Input_Print()
		{
			if (!(chkInputBillReturn.Checked ||
				chkInputWarrant.Checked))
			{
				RFMMessage.MessageBoxError("Не выбраны документы для печати (приход)...");
				return (false);
			}

			Input oInputTemp = new Input();
			oInputTemp.ReFillOne((int)oInputForPrint.ID);

			// проверки для прихода - не требуются

			Trip oTripTemp = new Trip();
			oTripTemp.ReFillOne((int)oInputTemp.TripID);

			ArrayList a_Dt = new ArrayList();
			ArrayList a_Rep = new ArrayList();
			ArrayList a_Cnt = new ArrayList();

			// возвратная накладная
			if (chkInputBillReturn.Checked && oInputTemp.IsReturn)
			{
				LogService.InputReturnBill_Print(oInputTemp, this, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			// доверенность 
			if (chkInputWarrant.Checked && oInputTemp.PF_WarrantNeed &&
				!oTripTemp.SelfDelivery &&
				(!oTripTemp.IsRentCar || !oInputTemp.IsReturn))
			{
				LogService.InputWarrant_Print(oInputTemp, this, true, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}
			
			if (a_Dt.Count > 0)
			{
				DataTable[] aDt = new DataTable[a_Dt.Count];
				a_Dt.CopyTo(aDt);

				ActiveReport3[] aRep = new ActiveReport3[a_Dt.Count];
				a_Rep.CopyTo(aRep);

				int[] aCnt = new int[a_Dt.Count];
				a_Cnt.CopyTo(aCnt);

				// собственно печать 
				if (chkDirectToPrinter.Checked)
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt, true));
				}
				else
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt));
				}

				// отметка печати - не требуется
			}
			else
			{
				RFMMessage.MessageBoxError("Нет данных для печати (приход)...");
				return (false);
			}

			return (true);
		}

	#endregion Input

	#endregion Print

		private void btnClearAll_Click(object sender, EventArgs e)
		{
			chkTripBill.Checked =
			chkTripBillShort.Checked =
            chkDrivingScheme.Checked = 
			chkBill.Checked =
			chkFacture.Checked =
			chkPayBill.Checked = 
			chkVeterinary.Checked =
			chkQuality.Checked =
			chkWarrant.Checked = 
			chkInputBillReturn.Checked = 
			chkInputWarrant.Checked = 
			chkDirectToPrinter.Checked =
				false;
			numBillCopies.Value = 2;
			optTotalSortByOrders.Checked = true;
		}

		private void chkBill_CheckedChanged(object sender, EventArgs e)
		{
			numBillCopies.Enabled = chkBill.Checked;
		}
	}
}
