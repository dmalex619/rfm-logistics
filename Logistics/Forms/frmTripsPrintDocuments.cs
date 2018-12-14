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

					// ���� ���� �� ��������� - ��������� ������ ����������� ����� � �������������
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
					lblTripAlias.Text = RFMUtilities.Declen(oTrip.MainTable.Rows.Count, "����", "�����", "������") + ":"; 
				}

				btnClearAll_Click(null, null);
				chkBill.Checked =
				chkFacture.Checked =
                chkPayBill.Checked = 
                chkQuality.Checked = 
				chkInputBillReturn.Checked = 
				chkInputWarrant.Checked = 
					true;

                // �������� �������
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
					// ������ ��� ������ ����.���������
					chkInputBillReturn.Checked =
					chkInputWarrant.Checked =
					chkInputBillReturn.Enabled =
					chkInputWarrant.Enabled =
						false;
					Text += ": ��������� ��������";
					lblOutputs.Text += " " + oOutputDocumentForPrint.PartnerBayerFactName;
				}
				if (oInputForPrint != null)
				{
					// ������ ��� ������ �������
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
					Text += ": ������";
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
				RFMMessage.MessageBoxError("�� ������� ��������� ��� ������...");
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

			// ���� ��������� ��������/����������, ��������� ����� 
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

			// ������ ������������ �������
			DataTable tOutputsDocuments = new DataTable();
			tOutputsDocuments.Columns.Add("ID", Type.GetType("System.Int32"));
			tOutputsDocuments.PrimaryKey = new DataColumn[] { tOutputsDocuments.Columns["ID"] };
			string sOutputsDocumentsList = "";

			DataTable tInputs = new DataTable();
			tInputs.Columns.Add("ID", Type.GetType("System.Int32"));
			tInputs.PrimaryKey = new DataColumn[] { tInputs.Columns["ID"] };
			string sInputsList = "";

			DataTable tOutputsDocumentsInTrip = null;

			// ���� �� ������ ������ 
			foreach (DataRow rTrip in oTrip.MainTable.Rows)
			{
				oTripTemp.FillOne(rTrip);

				#region ��������� �� ������

				// ���������� ���� (������, �������)
				if (chkTripBill.Checked || chkTripBillShort.Checked)
				{
					bool bPrint = true;
					if (oTripTemp.SelfDelivery)
					{
						//RFMMessage.MessageBoxError("���� \"" + oTripTemp.Alias + "\" �������� �� ������ �������.\n" +
						//	"���������� ���� �� ����������.");
						bPrint = false; 
					}
					else
					{
						if (!oTripTemp.DriverEmployeeID.HasValue && oTripTemp.DriverName.Length == 0)
						{
							RFMMessage.MessageBoxError("��� ����� \"" + oTripTemp.Alias + "\" �� ��������� ��������.\n" +
								"���������� ���� �� ����������.");
							bPrint = false;
						}

						if (bPrint)
						{
							if (!oTripTemp.DateBeg.HasValue)
							{
								// �������������� ������ ����� ��� ������ ����������� �����
								if (oTripTemp.ID.HasValue)
								{
									int nTripID = (int)oTripTemp.ID;
									oTripTemp.SetDateTime(nTripID, "BEG", "FACT", DateTime.Now, null);
								}
								else
								{
									/*RFMMessage.MessageBoxError("���� \"" + oTripTemp.Alias + "\" ��� �� �����.\n" +
										"���������� ���� �� ����������.");
									bPrint = false;*/
								}
							}
						}
					}
					if (bPrint)
					{
						// ���������� ���� ������
						if (chkTripBill.Checked)
						{
							LogService.TripBill_Print(oTripTemp, new TripBill(), this, true,
								ref a_Dt, ref a_Rep, ref a_Cnt, 1);
						}
						// ���������� ���� ������� 
						if (chkTripBillShort.Checked)
						{
							LogService.TripBill_Print(oTripTemp, new TripBillShort(), this, true,
									ref a_Dt, ref a_Rep, ref a_Cnt, 1);
						}
					}
				}

                // ������ ���� �������
                if (chkDrivingScheme.Checked && 
                    oTripTemp.FillTableDrivingSchemes(oTripTemp.ID.ToString()) &&
                    oTripTemp.TableDrivingSchemes.Rows.Count > 0)
                {
                    // ������ ��������� � �������
                    a_Dt.Add(oTripTemp.TableDrivingSchemes);
                    a_Rep.Add(new DrivingScheme());
                    a_Cnt.Add(1);
                    //this.StartForm(new frmActiveReport(oTripTemp.TableDrivingSchemes, new DrivingScheme()));
                }

				#endregion ��������� �� ������

				#region ��������� �� ��������� ����������

				tOutputsDocumentsInTrip = null;

				if (bOutputDocumentPrint)
				{
					// �������� ������ �������
					oTripTemp.FillTableOutputsDocumentsInTrip();

					if (oTripTemp.TableOutputsDocumentsInTrip.Rows.Count > 0)
					{
						bool bTripAllOutputsDocumentsConfirmed = true;

						// ��� �� ������, ����� �� �������� 
						foreach (DataRow rOutputDocument in oTripTemp.TableOutputsDocumentsInTrip.Rows)
						{
							oOutputDocumentTemp.FillOne(rOutputDocument);
							// ���� �� ���� ��������� �������� ��� �� �����������
							if (!oOutputDocumentTemp.IsConfirmed)
							{
								RFMMessage.MessageBoxError("����: " + oTripTemp.Alias + ":\n" +
									"��� ��c������� ��������� \"" + oOutputDocumentTemp.PartnerTargetName + "\" (��� " + oOutputDocumentTemp.ID.ToString() + ") " +
									"��� �� ������������ �������� �� ������.\n" +
									"��������� �� ����� �� ����������.");
								bTripAllOutputsDocumentsConfirmed = false;
								break;
							}
						}

						if (bTripAllOutputsDocumentsConfirmed)
						{
							if (oTripTemp.IsPostern)
							{
								// �� - ������� ������ �������� ������� ��������
								tOutputsDocumentsInTrip = CopyTable(oTripTemp.TableOutputsDocumentsInTrip, "tOutputsDocumentsInTrip", "", "ByOrder desc, PartnerTargetName");
							}
							else
							{
								tOutputsDocumentsInTrip = CopyTable(oTripTemp.TableOutputsDocumentsInTrip, "tOutputsDocumentsInTrip", "", "ByOrder, PartnerTargetName");
							}
						
							#region �� �������

							if (optTotalSortByOrders.Checked)
							{
								// � ������� �������
								foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
								{
									oOutputDocumentTemp.FillOne(rOutputDocument);

									// ��������� ��� ����������?
									if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
										continue;

									// ���������
									if (chkBill.Checked && (int)numBillCopies.Value != 0)
									{
										LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "BILL", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);

										// ��� �� ������.������
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportAct_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value);
										}

										// ��������� �� ���������� ���.��-�
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "BILL", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);
										}
									}

									// ����-�������
									if (chkFacture.Checked && oOutputDocumentTemp.PF_FactureNeed)
									{
                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "FACTURE", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);

										// ����-������� �� ������.������
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportFacture_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1); 
										}

										// ����-������� �� ���������� ���.��-�
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "FACTURE", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);
										}
									}

									// ����
									if (chkPayBill.Checked && oOutputDocumentTemp.PF_PayBillNeed)
									{
                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "INVOICE", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

									// ���.��-��
									if (chkVeterinary.Checked)
									{
										LogService.OutputDocumentVeterinary_Print(oOutputDocumentTemp, true, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

                                    // ������ ����������
									if (chkQuality.Checked)
									{
										LogService.OutputDocumentQuality_Print(oOutputDocumentTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

									// ������������
                                    // �� ���������� ��� ������ ����������, ������������ ����� � �������� ������ �������� �� �����������
									/*if (chkWarrant.Checked && oOutputDocumentTemp.PF_WarrantNeed && 
										!oTripTemp.SelfDelivery && !oTripTemp.IsRentCar && !oTrip.PartnerCarrierID.HasValue)*/
                                    // ��������� �� 06.08.2018
                                    // � ����� � ���, ��� ������ ������ ����� ���� � ������������, ��������� ������� �������������
                                    if (chkWarrant.Checked && 
                                        oOutputDocumentTemp.PF_WarrantNeed && 
                                        !oTripTemp.SelfDelivery && !oTripTemp.IsRentCar)
                                    {
                                            LogService.OutputDocumentWarrant_Print(oOutputDocumentTemp, this, true, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									}

									// ��������, ��� ���������� �����
									tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
									sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
								}
							}

							#endregion �� �������

							#region �� ����� ����������

							if (optTotalSortByTypes.Checked)
							{
								// ���������
								if (chkBill.Checked && (int)numBillCopies.Value > 0)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// ��� ���������?
										if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
											continue;

                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "BILL", this, true, (0 == 1), true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);

										// ��� �� ������.������
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportAct_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value);
										}

										// ��������� �� ���������� ���.��-�
										if (oOutputDocumentTemp.VeterinaryPrice != 0)
										{
											LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "BILL", nVatVeterinaryPayment, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);
										}

										if (tOutputsDocuments.Rows.Find((int)oOutputDocumentTemp.ID) == null)
										{
											// ��������, ��� ���������� �����
											tOutputsDocuments.Rows.Add(oOutputDocumentTemp.ID);
											sOutputsDocumentsList += oOutputDocumentTemp.ID.ToString() + ",";
										}
									}
								}

								// ����-�������
								if (chkFacture.Checked)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// ��� ���������?
										if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
											continue;
										// �� �����
										if (!oOutputDocumentTemp.PF_FactureNeed)
											continue;

										// ��� �� �����������
										if (!oOutputDocumentTemp.IsConfirmed)
										{
											RFMMessage.MessageBoxError("����: " + oTripTemp.Alias + ":\n" +
												"��� ��c������� ��������� \"" + oOutputDocumentTemp.PartnerTargetName + "\" (��� " + oOutputDocumentTemp.ID.ToString() + ") " +
												"��� �� ������������ �������� �� ������.\n" +
												"��������� �� ����� �� ����������.");
											continue;
										}

                                        LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "FACTURE", this, true, (0 == 1), true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);

										// ����-������� �� ������.������
										if (oOutputDocumentTemp.DeliveryPrice != 0)
										{
											LogService.OutputDocumentTransportFacture_Print(oOutputDocumentTemp, nVatTransport, this, true,
												ref a_Dt, ref a_Rep, ref a_Cnt, 1);
										}

										// ����-������� �� ���������� ���.��-�
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

								// ����
								if (chkPayBill.Checked)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// �� �����
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

								// ���.��-��
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

                                // ������ ����������
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

								// ������������
								if (chkWarrant.Checked && 
									!oTripTemp.SelfDelivery && !oTripTemp.IsRentCar)
								{
									foreach (DataRow rOutputDocument in tOutputsDocumentsInTrip.Rows)
									{
										oOutputDocumentTemp.FillOne(rOutputDocument);

										// ��������� ��� ����������?
										if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
											continue;
										// �� �����?
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

							#endregion �� ����� ����������
						}
					}
				}
				
				#endregion ��������� �� ��������� ����������

				#region ��������� �� ��������
				
				if (bInputDocumentPrint)
				{
					// �������� ������ ��������
					oTripTemp.FillTableInputsInTrip();

					if (oTripTemp.TableInputsInTrip.Rows.Count > 0)
					{
						#region �� �������

						if (optTotalSortByOrders.Checked)
						{
							// � ������� �������
							foreach (DataRow rInput in oTripTemp.TableInputsInTrip.Rows)
							{
								oInputTemp.FillOne(rInput);

								/*
								// ��������� ��� ����������?
								if (oInputTemp.IsPrinted && !chkRepeat.Checked)
									continue;
								*/

								// ���������� ���������
								if (chkInputBillReturn.Checked && oInputTemp.IsReturn)
								{
									LogService.InputReturnBill_Print(oInputTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
								}

								// ������������ 
								if (chkInputWarrant.Checked && oInputTemp.PF_WarrantNeed && 
									!oTripTemp.SelfDelivery && 
									(!oTripTemp.IsRentCar || !oInputTemp.IsReturn) )
								{
									LogService.InputWarrant_Print(oInputTemp, this, true, true,
										ref a_Dt, ref a_Rep, ref a_Cnt, 1);
								}

								// ��������, ��� ���������� �����
								tInputs.Rows.Add(oInputTemp.ID);
								sInputsList += oInputTemp.ID.ToString() + ",";
							}
						}
	
						#endregion �� �������

						#region �� ����� ����������

						if (optTotalSortByTypes.Checked)
						{
							// ���������� ��������� 
							if (chkInputBillReturn.Checked)
							{
								foreach (DataRow rInput in oTripTemp.TableInputsInTrip.Rows)
								{
									oInputTemp.FillOne(rInput);
									
									/*
									// ��� ���������?
									if (oInputTemp.IsPrinted && !chkRepeat.Checked)
										continue;
									*/
									
									if (!oInputTemp.IsReturn)
										continue;
										
									LogService.InputReturnBill_Print(oInputTemp, this, true,
											ref a_Dt, ref a_Rep, ref a_Cnt, 1);
									
									if (tInputs.Rows.Find((int)oInputTemp.ID) == null)
									{
										// ��������, ��� ���������� ������
										tInputs.Rows.Add(oInputTemp.ID);
										sInputsList += oInputTemp.ID.ToString() + ",";
									}
								}
							}

							// ������������
							if (chkInputWarrant.Checked && 
								!oTripTemp.SelfDelivery)
							{
								foreach (DataRow rInput in oTripTemp.TableInputsInTrip.Rows)
								{
									oInputTemp.FillOne(rInput);

									/*
									// ��������� ��� ����������?
									if (oInputTemp.IsPrinted && !chkRepeat.Checked)
										continue;
									*/

									// �� �����?
									if (!oInputTemp.PF_WarrantNeed)
										continue;
									// ������ - ������ �� ����� (�� �������)
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

							#endregion �� ����� ����������
						}
					}
				}

				#endregion ��������� �� ��������
			}

			if (a_Dt.Count > 0)
			{
				DataTable[] aDt = new DataTable[a_Dt.Count];
				a_Dt.CopyTo(aDt);

				ActiveReport3[] aRep = new ActiveReport3[a_Dt.Count];
				a_Rep.CopyTo(aRep);

				int[] aCnt = new int[a_Dt.Count];
				a_Cnt.CopyTo(aCnt);

				// ���������� ������ 
				if (chkDirectToPrinter.Checked)
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt, true));
				}
				else
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt));
				}

				// ������� ������
                if (bOutputDocumentPrint && (chkBill.Checked || chkFacture.Checked))
				{
					int nUserID = ((RFMFormMain)Application.OpenForms[0]).UserID;
					// ������
					foreach (DataRow rTrip in oTrip.MainTable.Rows)
					{
						oTripTemp.SetDatePrint((int)rTrip["ID"], false, nUserID);
					}
					// ������
					foreach (DataRow rOutputDocument in tOutputsDocuments.Rows)
					{
						oOutputDocumentTemp.SetDatePrint((int)rOutputDocument["ID"], false, nUserID);
					}
				}
			}
			else
			{
				RFMMessage.MessageBoxError("��� ������ ��� ������...");
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
				RFMMessage.MessageBoxError("�� ������� ��������� ��� ������ (��������� ��������)...");
				return (false);
			}

			OutputDocument oOutputDocumentTemp = new OutputDocument();
			oOutputDocumentTemp.ReFillOne((int)oOutputDocumentForPrint.ID);

			// �������� ��� ���������� ��������� 
			if (!oOutputDocumentTemp.IsConfirmed)
			{
				RFMMessage.MessageBoxError("��� ��c������� ��������� \"" + oOutputDocumentTemp.PartnerTargetName + "\" (��� " + oOutputDocumentTemp.ID.ToString() + ") " +
					"��� �� ������������ �������� �� ������.\n" +
					"��������� �� ����������.");
				return (false);
			}

			if (oOutputDocumentTemp.IsPrinted && !chkRepeat.Checked)
			{
				RFMMessage.MessageBoxError("��� ��c������� ��������� \"" + oOutputDocumentTemp.PartnerTargetName + "\" (��� " + oOutputDocumentTemp.ID.ToString() + ") " +
					"��������� ��� ����������.");
				return (false);
			}

			Trip oTripTemp = new Trip();
			oTripTemp.ReFillOne((int)oOutputDocumentTemp.TripID);

			ArrayList a_Dt = new ArrayList();
			ArrayList a_Rep = new ArrayList();
			ArrayList a_Cnt = new ArrayList();
			
			// ���������
			if (chkBill.Checked && (int)numBillCopies.Value != 0)
			{
                LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "BILL", this, true, (0 == 1), true,
					ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);

				// ��� �� ������.������
				if (oOutputDocumentTemp.DeliveryPrice != 0)
				{
					LogService.OutputDocumentTransportAct_Print(oOutputDocumentTemp, nVatTransport, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value);
				}

				// ��������� �� ���������� ���.��-�
				if (oOutputDocumentTemp.VeterinaryPrice != 0)
				{
					LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "BILL", nVatVeterinaryPayment, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, (int)numBillCopies.Value, chkUsePerversionCopiesCnt.Checked);
				}
			}

			// ����-�������
			if (chkFacture.Checked && oOutputDocumentTemp.PF_FactureNeed)
			{
                LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "FACTURE", this, true, (0 == 1), true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);

				// ����-������� �� ������.������
				if (oOutputDocumentTemp.DeliveryPrice != 0)
				{
					LogService.OutputDocumentTransportFacture_Print(oOutputDocumentTemp, nVatTransport, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1);
				}

				// ����-������� �� ���������� ���.��-�
				if (oOutputDocumentTemp.VeterinaryPrice != 0)
				{
					LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentTemp, "FACTURE", nVatVeterinaryPayment, this, true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1, chkUsePerversionCopiesCnt.Checked);
				}
			}

			// ����
			if (chkPayBill.Checked && oOutputDocumentTemp.PF_PayBillNeed)
			{
                LogService.OutputDocumentBill_Print(oOutputDocumentTemp, "INVOICE", this, true, (0 == 1), true,
						ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			// ���.��-��
			if (chkVeterinary.Checked)
			{
				LogService.OutputDocumentVeterinary_Print(oOutputDocumentTemp, true, this, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

            // ������ ����������
			if (chkQuality.Checked)
			{
				LogService.OutputDocumentQuality_Print(oOutputDocumentTemp, this, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			// ������������ 
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

				// ���������� ������ 
				if (chkDirectToPrinter.Checked)
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt, true));
				}
				else
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt));
				}

				// ������� ������
				if (chkBill.Checked || chkFacture.Checked)
				{
					int nUserID = ((RFMFormMain)Application.OpenForms[0]).UserID;
					oOutputDocumentTemp.SetDatePrint((int)oOutputDocumentTemp.ID, false, nUserID);
				}
			}
			else
			{
				RFMMessage.MessageBoxError("��� ������ ��� ������ (��������� ��������)...");
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
				RFMMessage.MessageBoxError("�� ������� ��������� ��� ������ (������)...");
				return (false);
			}

			Input oInputTemp = new Input();
			oInputTemp.ReFillOne((int)oInputForPrint.ID);

			// �������� ��� ������� - �� ���������

			Trip oTripTemp = new Trip();
			oTripTemp.ReFillOne((int)oInputTemp.TripID);

			ArrayList a_Dt = new ArrayList();
			ArrayList a_Rep = new ArrayList();
			ArrayList a_Cnt = new ArrayList();

			// ���������� ���������
			if (chkInputBillReturn.Checked && oInputTemp.IsReturn)
			{
				LogService.InputReturnBill_Print(oInputTemp, this, true,
					ref a_Dt, ref a_Rep, ref a_Cnt, 1);
			}

			// ������������ 
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

				// ���������� ������ 
				if (chkDirectToPrinter.Checked)
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt, true));
				}
				else
				{
					StartForm(new frmActiveReport(aDt, aRep, aCnt));
				}

				// ������� ������ - �� ���������
			}
			else
			{
				RFMMessage.MessageBoxError("��� ������ ��� ������ (������)...");
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
