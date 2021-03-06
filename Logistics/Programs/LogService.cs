using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Collections;

using DataDynamics.ActiveReports;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public static class LogService
	{

		#region OutputDocument

		#region OutputDocument Print

		#region OutputDocumentBill_Print_Report - по конкретному шаблону (bill, facture)

		public static void OutputDocumentBill_Print_Report(OutputDocument oOutputDocumentPrint, 
				ActiveReport3 rep, 
				RFMFormChild thisForm)
		{
			
			// используется для накладных и счетоф-фактур клиентов со спец.признаком

			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			DataTable dt;

			// таблицы для товаров по всем заказам
			if (oOutputDocumentPrint.ID.HasValue)
			{
				// один заказ
				oOutputDocumentPrint.FillBillTableOutputsDocumentsGoods((int)oOutputDocumentPrint.ID);
				if (oOutputDocumentPrint.ErrorNumber != 0)
					return;
				dt = oOutputDocumentPrint.TableOutputsDocumentsGoods;
			}
			else
			{
				oOutputDocumentPrint.FillData();
				if (oOutputDocumentPrint.ErrorNumber != 0)
					return;

				// пустая структура
				oOutputDocumentPrint.FillBillTableOutputsDocumentsGoods(-1);
				dt = thisForm.CopyTable(oOutputDocumentPrint.TableOutputsDocumentsGoods, "dt", "", "");
				dt.PrimaryKey = null;

				// товары каждого заказа
				foreach (DataRow or in oOutputDocumentPrint.MainTable.Rows)
				{
					oOutputDocumentPrint.FillBillTableOutputsDocumentsGoods((int)or["ID"]);
					dt.Merge(oOutputDocumentPrint.TableOutputsDocumentsGoods);
				}
			}

			thisForm.StartForm(new frmActiveReport(oOutputDocumentPrint.TableOutputsDocumentsGoods, rep));
		}

		#endregion OutputDocumentBill_Print_Report

		public static void OutputDocumentBill_Print(OutputDocument oOutputDocumentPrint,
			string sMode,
			RFMFormChild thisForm, 
			bool bNoAsk, 
            Boolean B_ASK_ABOUT_VAT_TEMPORARY)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentBill_Print(oOutputDocumentPrint, sMode, thisForm, bNoAsk, 
                B_ASK_ABOUT_VAT_TEMPORARY, 
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentBill_Print(OutputDocument oOutputDocumentPrint,
			string sMode,
			RFMFormChild thisForm,
			bool bNoAsk,
            Boolean B_ASK_ABOUT_VAT_TEMPORARY,
            bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentBill_Print(oOutputDocumentPrint, sMode, thisForm, bNoAsk,
                B_ASK_ABOUT_VAT_TEMPORARY,
                bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void OutputDocumentBill_Print(OutputDocument oOutputDocumentPrint,
			string sMode,
			RFMFormChild thisForm,
			bool bNoAsk,
            Boolean B_ASK_ABOUT_VAT_TEMPORARY,
            bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
			int nCopiesCnt)
		{
			OutputDocumentBill_Print(oOutputDocumentPrint, sMode, thisForm, bNoAsk,
                B_ASK_ABOUT_VAT_TEMPORARY,
                bToArrayList, ref _aDataTables, ref _aReps, ref _aCopiesCnt,
				1, false);
		}

		public static void OutputDocumentBill_Print(OutputDocument oOutputDocumentPrint,
			string sMode, 
			RFMFormChild thisForm, 
			bool bNoAsk, 
            Boolean B_ASK_ABOUT_VAT_TEMPORARY, 
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt, 
			int nCopiesCnt, 
			bool bUsePerversionCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

            /*
            Boolean B_RECALC_VAT = false;
            if (B_ASK_ABOUT_VAT_TEMPORARY &&
                MessageBox.Show("¿Recontar I.V.A?\r\n\r\n" + 
                    "Если Вы не поняли вопрос, скажите НЕТ!",
                    "¡Atención!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                B_RECALC_VAT = true;
            }
            */

            sMode = sMode.ToUpper();

			oOutputDocumentPrint.FillData();
			if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка расходных документов...");
				return;
			}
			if (oOutputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных о расходных документах...");
				return;
			}

			OutputDocument oOutputDocumentPrintOne = new OutputDocument(); 
			Partner oPartner = new Partner();

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oOutputDocumentPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной заказ
				oOutputDocumentPrintOne.FillOne(r);

				if (!oOutputDocumentPrintOne.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Для раcходного документа с кодом " + oOutputDocumentPrintOne.ID.ToString() + " " +
						"(" + oOutputDocumentPrintOne.PartnerTargetName + ")" +
						" еще не подтверждена отгрузка со склада.\n" +
						"Документы не печатаются.");
					continue;
				}

				/*
				// получить номера счетов-фактур
				if (sMode.Contains("FACTURE"))
				{
					if (!oOutputDocumentPrintOne.FactureNeed)
						continue;

					if (oOutputDocumentPrintOne.FactureNumber == null || oOutputDocumentPrintOne.FactureNumber.Length == 0) 
					{
						// получаем очередной номер с-ф
						oOutputDocumentPrintOne.FactureSet((int)oOutputDocumentPrintOne.ID, null);
						// перечитываем и заполняем его в текущей таблице
						if (oOutputDocumentPrintOne.ErrorNumber == 0)
						{
							r["FactureNumber"] = oOutputDocumentPrintOne.FactureNumber;
						}
						else
						{
							oOutputDocumentPrintOne.ClearError();
						}
					}
				}
				*/

				// таблица товаров для документа
				oOutputDocumentPrintOne.FillBillTableOutputsDocumentsGoods();
				if (oOutputDocumentPrintOne.TableOutputsDocumentsGoods.Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxError("Нет данных по товарам в расходном документе с кодом " + oOutputDocumentPrintOne.ID.ToString() + " " +
						"(" + oOutputDocumentPrintOne.PartnerTargetName + ")...");
					}
					continue;
				}
				dt = oOutputDocumentPrintOne.TableOutputsDocumentsGoods;
                //dt.WriteXml("C:\\123.xml");

				#region Renum - not used
				/*
				// перенумеровать
				bool bRenum = false;
				foreach (DataRow odg in dt.Rows)
				{
					if (Convert.IsDBNull(odg["PrintPageNumber"]) || 
						odg["PrintPageNumber"] == null ||
						Convert.ToInt32(odg["PrintPageNumber"]) == 0)
					{
						bRenum = true;
						break;
					}
				}
				if (bRenum)
				{
					int nLinesInPage = 0;
					Setting oSet = new Setting();
					string sVatTemp = null;
					sVatTemp = oSet.FillVariable("gnLinesInPage");
					if (sVatTemp != null && sVatTemp != "")
						nLinesInPage = Convert.ToInt32(sVatTemp);
					if (nLinesInPage == 0)
						nLinesInPage = 30;

					int nPageNumber = 1;
					int nNumberInPage = 1;
					foreach (DataRow odg in dt.Rows)
					{
						odg["PrintPageNumber"] = nPageNumber;
						odg["PrintNumberInPage"] = nNumberInPage;
						nNumberInPage++;
						if (nNumberInPage > nLinesInPage)
						{
							nNumberInPage = 1;
							nPageNumber++; 
						}
					}
				}
				*/
				#endregion Renum

                #region ВРЕМЕННО! Пересчет данных по НДС с обратного метода на прямой
                /*
                if (B_RECALC_VAT)
                {
                    decimal dQnt, dPriceNoVAT, dVAT, dPriceFull;
                    decimal sumNoVAT = 0, sumVAT = 0;
                    decimal sumNoVAT1 = 0, sumVAT1 = 0;
                    decimal sumNoVAT2 = 0, sumVAT2 = 0;
                    bool bVAT18 = false;

                    foreach (DataRow dtr in dt.Rows)
                    {
                        dQnt = Convert.ToDecimal(dtr["Qnt"]);
                        dVAT = Convert.ToDecimal(dtr["VAT"]);

                        dPriceNoVAT = Math.Round(Convert.ToDecimal(dtr["PriceNoVAT"]), 2, MidpointRounding.AwayFromZero);
                        dPriceFull = Math.Round(dPriceNoVAT * (1 + dVAT / 100), 2, MidpointRounding.AwayFromZero);

                        sumNoVAT = Math.Round(dQnt * dPriceNoVAT, 2, MidpointRounding.AwayFromZero);
                        sumVAT = Math.Round(dQnt * dPriceNoVAT * (dVAT / 100), 2, MidpointRounding.AwayFromZero);

                        switch ((int)dVAT)
                        {
                            case 10:
                                sumNoVAT1 += sumNoVAT;
                                sumVAT1 += sumVAT;
                                break;
                            case 18:
                                sumNoVAT2 += sumNoVAT;
                                sumVAT2 += sumVAT;
                                bVAT18 = true;
                                break;
                        }

                        dtr["Price"] = dPriceFull;

                        dtr["PriceNoVATSum"] = sumNoVAT;
                        dtr["VATSum"] = sumVAT;
                        dtr["PriceSum"] = sumNoVAT + sumVAT;
                    }

                    // Проверка на наличие только одной ставки НДС
                    if (sumNoVAT1 == 0)
                    {
                        sumNoVAT1 = sumNoVAT2;
                        sumVAT1 = sumVAT2;

                        sumNoVAT2 = sumVAT2 = 0;
                    }

                    // Замена суммовых данных
                    foreach (DataRow dtr in dt.Rows)
                    {
                        dtr["NoVATAllSum"] = sumNoVAT1 + sumNoVAT2;
                        dtr["VATAllSum"] = sumVAT1 + sumVAT2;
                        dtr["Amount"] = sumNoVAT1 + sumNoVAT2 + sumVAT1 + sumVAT2;

                        if (sumNoVAT2 > 0)
                        {
                            dtr["VAT1Rate"] = 10;
                            dtr["VAT1Sum"] = sumVAT1;
                            dtr["NoVAT1Sum"] = sumNoVAT1;
                            dtr["VATText1"] = "НДС 10%: товар - " + sumNoVAT1.ToString() + ", налог - " + sumVAT1.ToString();

                            dtr["VAT2Rate"] = 18;
                            dtr["VAT2Sum"] = sumVAT2;
                            dtr["NoVAT2Sum"] = sumNoVAT2;
                            dtr["VATText2"] = "НДС 18%: товар - " + sumNoVAT2.ToString() + ", налог - " + sumVAT2.ToString();
                        }
                        else
                        {
                            dtr["VAT1Rate"] = (bVAT18 ? 18 : 10);
                            dtr["VAT1Sum"] = sumVAT1;
                            dtr["NoVAT1Sum"] = sumNoVAT1;
                            dtr["VATText1"] = "НДС " + (bVAT18 ? "18" : "10") + "%: товар - " + sumNoVAT1.ToString() + ", налог - " + sumVAT1.ToString();

                            dtr["VAT2Rate"] = 0;
                            dtr["VAT2Sum"] = 0;
                            dtr["NoVAT2Sum"] = 0;
                            dtr["VATText2"] = "";
                        }
                    }
                }
                */
                #endregion
                
                // шаблон для клиента
				oPartner.ID = oOutputDocumentPrintOne.PartnerTargetID;
				oPartner.ReFillOne((int)oPartner.ID);

				string sPF_Type = "";
				string sPF_Name = "";
				string sXMLTemplateText = "";

				int? nLinesInPage = LinesInPage_GetSetting();

				#region Bill

				if (sMode == "BILL")
                {
					if (!oOutputDocumentPrintOne.PF_BillNeed)
					{
						if (bNoAsk)
							continue;
						if (RFMMessage.MessageBoxYesNo("Расходный документ не требует формирования накладной.\n\n" +
							"Все-таки сформировать накладную?") != DialogResult.Yes)
							continue;
						if ((oOutputDocumentPrintOne.BillNumber == null || oOutputDocumentPrintOne.BillNumber.Trim().Length == 0) &&
							RFMMessage.MessageBoxYesNo("Для расходного документа не определен номер накладной.\n\n" +
							"Все-таки сформировать накладную?") != DialogResult.Yes)
							continue;						
					}

					sPF_Type = "PF_Bill";

					if (bUsePerversionCopiesCnt && oPartner.PF_BillCopiesCount != 0)
						nCopiesCnt = oPartner.PF_BillCopiesCount;

					if (oPartner.PF_BillName == null || oPartner.PF_BillName.Trim() == "")
					{
						// общий шаблон

						// режим печати 
						if (oOutputDocumentPrintOne.PrintMode == null || oOutputDocumentPrintOne.PrintMode.Trim().Length == 0)
						{
							// стандартная форма (портрет)
                            rep = new billLandscape();
						}
						else
						{
							switch (oOutputDocumentPrintOne.PrintMode)
							{ 
								case "P":
                                    rep = new billPortrait();
                                    break;
                                default:
                                    // альбом.
                                    rep = new billLandscape();
                                    // для альбомных печатных форм - используем длину в два раза меньше
                                    // 2009-12-16 не уменьшаем число строк на стр.
                                    //ReNumberLineInPageLanscape(nLinesInPage, dt);
                                    break;
							}
						}

						a_rep.Add(rep);
						a_dt.Add(dt);
						a_cnt.Add(nCopiesCnt);
					}
					else
					{
						// свой собственный шаблон
						sXMLTemplateText = oPartner.XMLTemplateTextGet((int)oPartner.ID, sPF_Type, ref sPF_Name, ref nLinesInPage);
						if (sXMLTemplateText != null && sXMLTemplateText.Length > 0)
						{
							// записать шаблон во врем.файл и загрузить его в документ
							rep = new ActiveReport3(); 
							if (XMLTemplateTextToFile(sXMLTemplateText, sPF_Name, rep))
							{ 
								ReNumberLineInPage(nLinesInPage, dt);

								a_rep.Add(rep);
								a_dt.Add(dt);
								a_cnt.Add(nCopiesCnt);
							}
						}
						else
						{
							// режим печати 
							if (oOutputDocumentPrintOne.PrintMode == null || oOutputDocumentPrintOne.PrintMode.Trim().Length == 0)
							{
								// стандартная форма (портрет)
                                rep = new billLandscape();
							}
							else
							{
								switch (oOutputDocumentPrintOne.PrintMode)
								{
									case "P":
                                        rep = new billPortrait();
                                        break;
                                    default:
                                        // альбом.
                                        rep = new billLandscape();
                                        // 2009-12-16 не уменьшаем число строк на стр.
                                        //ReNumberLineInPageLanscape(nLinesInPage, dt); 
                                        break;
								}
							}

							a_rep.Add(rep);
							a_dt.Add(dt);
							a_cnt.Add(nCopiesCnt);
						}
					}
				}

				#endregion Bill

				#region Facture

				if (sMode == "FACTURE")
				{
					if (!oOutputDocumentPrintOne.PF_FactureNeed)
					{
						if (bNoAsk)
							continue;
						if (RFMMessage.MessageBoxYesNo("Расходный документ не требует формирования счета-фактуры.\n\n" +
							"Все-таки сформировать счет-фактуру?") != DialogResult.Yes)
							continue;
						if ((oOutputDocumentPrintOne.FactureNumber == null || oOutputDocumentPrintOne.FactureNumber.Trim().Length == 0) &&
							RFMMessage.MessageBoxYesNo("Для расходного документа не определен номер счета-фактуры.\n\n" +
							"Все-таки сформировать счет-фактуру?") != DialogResult.Yes)
							continue;
					}

					sPF_Type = "PF_Facture";

					if (bUsePerversionCopiesCnt && oPartner.PF_FactureCopiesCount != 0)
						nCopiesCnt = (int)oPartner.PF_FactureCopiesCount;

					if (oPartner.PF_FactureName == null || oPartner.PF_FactureName.Trim() == "") 
					{
						// общий шаблон
						rep = new facture();

						a_rep.Add(rep);
						a_dt.Add(dt);
						a_cnt.Add(nCopiesCnt);
					}
					else
					{
						// свой собственный шаблон счета-фактуры
						sXMLTemplateText = oPartner.XMLTemplateTextGet((int)oPartner.ID, sPF_Type, ref sPF_Name, ref nLinesInPage);
						if (sXMLTemplateText != null && sXMLTemplateText.Length > 0)
						{
							rep = new ActiveReport3();
							if (XMLTemplateTextToFile(sXMLTemplateText, sPF_Name, rep))
							{
								ReNumberLineInPage(nLinesInPage, dt); 
									
								a_rep.Add(rep);
								a_dt.Add(dt);
								a_cnt.Add(nCopiesCnt);
							}
						}
						else
						{
							rep = new facture();

							a_rep.Add(rep);
							a_dt.Add(dt);
							a_cnt.Add(nCopiesCnt);
						}
					}
				}

				#endregion Facture 

				#region Invoice, PayBill
				
				/*
				if (sMode == "INVOICE")
				{
					rep = new PayBill();

					a_rep.Add(rep);
					a_dt.Add(dt);
					a_cnt.Add(nCopiesCnt);
				}
				*/

				if (sMode == "INVOICE" || sMode == "PAYBILL")
				{
					if (!oOutputDocumentPrintOne.PF_PayBillNeed)
					{
						if (bNoAsk)
							continue;
						if (RFMMessage.MessageBoxYesNo("Расходный документ не требует формирования счета.\n\n" +
							"Все-таки сформировать счет?") != DialogResult.Yes)
							continue;
					}

					sPF_Type = "PF_PayBill";

					if (bUsePerversionCopiesCnt && oPartner.PF_PayBillCopiesCount != 0)
						nCopiesCnt = (int)oPartner.PF_PayBillCopiesCount;

					if (oPartner.PF_PayBillName == null || oPartner.PF_PayBillName.Trim() == "")
					{
						// общий шаблон
						rep = new PayBill(); 

						a_rep.Add(rep);
						a_dt.Add(dt);
						a_cnt.Add(nCopiesCnt);
					}
					else
					{
						// свой собственный шаблон счета на оплату
						sXMLTemplateText = oPartner.XMLTemplateTextGet((int)oPartner.ID, sPF_Type, ref sPF_Name, ref nLinesInPage);
						if (sXMLTemplateText != null && sXMLTemplateText.Length > 0)
						{
							rep = new ActiveReport3();
							if (XMLTemplateTextToFile(sXMLTemplateText, sPF_Name, rep))
							{
								ReNumberLineInPage(nLinesInPage, dt);

								a_rep.Add(rep);
								a_dt.Add(dt);
								a_cnt.Add(nCopiesCnt);
							}
						}
						else
						{
							rep = new PayBill(); 

							a_rep.Add(rep);
							a_dt.Add(dt);
							a_cnt.Add(nCopiesCnt);
						}
					}
				}

				#endregion Invoice, PayBill

				if (sMode == "INNERMOVINGBILL")
                {
                    rep = new billInnerMoving();

                    a_rep.Add(rep);
                    a_dt.Add(dt);
                    a_cnt.Add(nCopiesCnt);
                }
            }

			if (a_dt.Count == 0)
			{
				if (!bToArrayList)
				{
					RFMMessage.MessageBoxInfo("Нет данных...");
				}
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach(DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach(ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				//thisForm.StartForm(new frmActiveReport(aDt[0], aRep[0]));
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}

			#region пример LoadLayout
			/*
			if (rep.GetType().Name.Contains("facture"))
			{
				ActiveReport3 rep1 = new ActiveReport3();
				rep1.LoadLayout(@"d:\Logistics\1\billIskra.rpx");

				rep1.AddScriptReference("RFMPublic.dll");
				rep1.AddScriptReference("LogBizObjects.dll");

				thisForm.StartForm(new frmActiveReport(oOutputDocumentPrint.TableOutputsDocumentsGoods, rep1));
			}
			else
			{
				thisForm.StartForm(new frmActiveReport(oOutputDocumentPrint.TableOutputsDocumentsGoods, rep));
			}
			*/
			#endregion 
		}

		#region Veterinary 

		public static void OutputDocumentVeterinary_Print(OutputDocument oOutputDocumentPrint, bool bGroupByPartner,
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentVeterinary_Print(oOutputDocumentPrint, bGroupByPartner, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentVeterinary_Print(OutputDocument oOutputDocumentPrint, bool bGroupByPartner,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentVeterinary_Print(oOutputDocumentPrint, bGroupByPartner, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentVeterinary_Print(OutputDocument oOutputDocumentPrint, bool bGroupByPartner, 
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			string sOutputsDocumentsList = "";

			int nOutputDocumentID = 0;
			bool bVeterinaryUpdate = false;

			// таблицы для товаров по всем заказам
			if (oOutputDocumentPrint.ID.HasValue)
			{
				// один заказ
				nOutputDocumentID = (int)oOutputDocumentPrint.ID;

				// если еще не заполнены сведения по вет.св-вам - заполнить
				oOutputDocumentPrint.FillTableOutputsDocumentsGoods(nOutputDocumentID);
				if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
					return;
				foreach (DataRow odg in oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows)
				{
					if (Convert.IsDBNull(odg["GoodVeterinaryID"]))
					{
						bVeterinaryUpdate = true;
						break;
					}
				}
				if (bVeterinaryUpdate)
				{
					oOutputDocumentPrint.SetGoodVeterinaryID(nOutputDocumentID, true);
				}

				sOutputsDocumentsList = oOutputDocumentPrint.ID.ToString();
			}
			else
			{
				oOutputDocumentPrint.FillData();
				if (oOutputDocumentPrint.ErrorNumber != 0)
					return;

				// товары каждого заказа
				foreach (DataRow or in oOutputDocumentPrint.MainTable.Rows)
				{
					nOutputDocumentID = (int)or["ID"];
					bVeterinaryUpdate = false;

					// если еще не заполнены сведения по вет.св-вам - заполнить
					oOutputDocumentPrint.FillTableOutputsDocumentsGoods(nOutputDocumentID);
					if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
						continue;
					foreach (DataRow odg in oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows)
					{
						if (Convert.IsDBNull(odg["GoodVeterinaryID"]))
						{
							bVeterinaryUpdate = true;
							break;
						}
					}
					if (bVeterinaryUpdate)
					{
						oOutputDocumentPrint.SetGoodVeterinaryID(nOutputDocumentID, true);
					}

					sOutputsDocumentsList = oOutputDocumentPrint.IDList;
				}
			}

			// таблицы для списков вет.св-в товаров по всем заказам
			oOutputDocumentPrint.FillVeterinaryTableOutputsDocumentsGoods(sOutputsDocumentsList, bGroupByPartner);
			if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
				return;
			if (oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				if (!bToArrayList)
				{
					RFMMessage.MessageBoxInfo("Нет данных по ветеринарным свидетельствам...");
				}
				return;
			}

			ActiveReport3 rep = new VeterinaryList();

			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(oOutputDocumentPrint.TableOutputsDocumentsGoods);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt); 
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(oOutputDocumentPrint.TableOutputsDocumentsGoods, rep));
			}
		}

		public static void OutputDocumentVeterinaryBlank_Print(OutputDocument oOutputDocumentPrint, bool bGroupByPartner,
			RFMFormChild thisForm)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			string sOutputsDocumentsList = ""; 

			int nOutputDocumentID = 0;
			bool bVeterinaryUpdate = false;

			// таблицы для товаров по всем заказам
			if (oOutputDocumentPrint.ID.HasValue)
			{
				// один заказ
				nOutputDocumentID = (int)oOutputDocumentPrint.ID;

				// если еще не заполнены сведения по вет.св-вам - заполнить
				oOutputDocumentPrint.FillTableOutputsDocumentsGoods(nOutputDocumentID);
				if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
					return; 
				foreach (DataRow odg in oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows)
				{
					if (Convert.IsDBNull(odg["GoodVeterinaryID"]))
					{
						bVeterinaryUpdate = true;
						break;
					}
				}
				if (bVeterinaryUpdate)
				{
					oOutputDocumentPrint.SetGoodVeterinaryID(nOutputDocumentID, true);
				}

				sOutputsDocumentsList = oOutputDocumentPrint.ID.ToString();
			}
			else
			{
				oOutputDocumentPrint.FillData();
				if (oOutputDocumentPrint.ErrorNumber != 0)
					return;

				// товары каждого заказа
				foreach (DataRow or in oOutputDocumentPrint.MainTable.Rows)
				{
					nOutputDocumentID = (int)or["ID"];
					bVeterinaryUpdate = false;

					// если еще не заполнены сведения по вет.св-вам - заполнить
					oOutputDocumentPrint.FillTableOutputsDocumentsGoods(nOutputDocumentID);
					if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
						continue;
					foreach (DataRow odg in oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows)
					{
						if (Convert.IsDBNull(odg["GoodVeterinaryID"]))
						{
							bVeterinaryUpdate = true;
							break;
						}
					}
					if (bVeterinaryUpdate)
					{
						oOutputDocumentPrint.SetGoodVeterinaryID(nOutputDocumentID, true);
					}

					sOutputsDocumentsList = oOutputDocumentPrint.IDList;
				}
			}

			// таблицы для бланков вет.св-в товаров по всем заказам
			oOutputDocumentPrint.FillVeterinaryBlankTableOutputsDocumentsGoods(sOutputsDocumentsList, bGroupByPartner);
			if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
				return;
			if (oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных для бланков ветеринарных свидетельств...");
				return;
			}

			ActiveReport3 rep = new VeterinaryBlank();
			thisForm.StartForm(new frmActiveReport(oOutputDocumentPrint.TableOutputsDocumentsGoods, rep));
		}

		#endregion Veterinary

		#region Quality

		public static void OutputDocumentQuality_Print(OutputDocument oOutputDocumentPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentQuality_Print(oOutputDocumentPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentQuality_Print(OutputDocument oOutputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentQuality_Print(oOutputDocumentPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentQuality_Print(OutputDocument oOutputDocumentPrint, 
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

            // таблицы для деклараций соответствия по всем заказам
			/* 
			string sOutputsDocumentsList = (oOutputDocumentPrint.ID.HasValue) ? oOutputDocumentPrint.ID.ToString() : oOutputDocumentPrint.IDList;
			oOutputDocumentPrint.FillQualityTableOutputsDocumentsGoods(sOutputsDocumentsList, bGroupByPartner);
			if (oOutputDocumentPrint.ErrorNumber != 0)
				return;
			if (oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по ветеринарным свидетельствам...");
				return;
			}
			*/

			DataTable dt;
			int nOutputDocumentID = 0;
			bool bQualityUpdate = false;

			// таблицы для товаров по всем заказам
			if (oOutputDocumentPrint.ID.HasValue)
			{
				// один заказ
				nOutputDocumentID = (int)oOutputDocumentPrint.ID;

                // если еще не заполнены сведения по декларациям соответствия - заполнить
				oOutputDocumentPrint.FillTableOutputsDocumentsGoods(nOutputDocumentID);
				if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
					return;
				foreach (DataRow odg in oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows)
				{
					if (Convert.IsDBNull(odg["GoodQualityID"]))
					{
						bQualityUpdate = true;
						break; 
					}
				}
				if (bQualityUpdate)
				{
					oOutputDocumentPrint.SetGoodQualityID(nOutputDocumentID, true); 
				}
				// 

				oOutputDocumentPrint.FillQualityTableOutputsDocumentsGoods(nOutputDocumentID);
				if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
					return;
				if (oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows.Count == 0)
				{
					if (!bToArrayList)
					{
                        RFMMessage.MessageBoxInfo("Нет данных по декларациям соответствия...");
					}
					return;
				}
				
				dt = oOutputDocumentPrint.TableOutputsDocumentsGoods;
			}
			else
			{
				oOutputDocumentPrint.FillData();
				if (oOutputDocumentPrint.ErrorNumber != 0)
					return;

				DataTable dtOD;
				if (oOutputDocumentPrint.FilterTripsList != null)
					dtOD = thisForm.CopyTable(oOutputDocumentPrint.MainTable, "dtDT", "", "ByOrder, DateOutput, PartnerSourceName, PartnerTargetName");
				else
					dtOD = oOutputDocumentPrint.MainTable;

				// пустая структура
				oOutputDocumentPrint.FillQualityTableOutputsDocumentsGoods(-1);
				dt = thisForm.CopyTable(oOutputDocumentPrint.TableOutputsDocumentsGoods, "dt", "", "");
				dt.PrimaryKey = null;

				// товары каждого заказа
				foreach (DataRow or in dtOD.Rows)
				{
					nOutputDocumentID = (int)or["ID"];
					bQualityUpdate = false;

                    // если еще не заполнены сведения по декларациям соответствия - заполнить
					oOutputDocumentPrint.FillTableOutputsDocumentsGoods(nOutputDocumentID);
					if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.TableOutputsDocumentsGoods == null)
						continue;

					foreach (DataRow odg in oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows)
					{
						if (Convert.IsDBNull(odg["GoodQualityID"]))
						{
							bQualityUpdate = true;
							break;
						}
					}
					if (bQualityUpdate)
					{
						oOutputDocumentPrint.SetGoodQualityID(nOutputDocumentID, true);
					}
					// 

					oOutputDocumentPrint.FillQualityTableOutputsDocumentsGoods(nOutputDocumentID);
					dt.Merge(oOutputDocumentPrint.TableOutputsDocumentsGoods);
				}
				if (dt.Rows.Count == 0)
				{
					if (!bToArrayList)
					{
                        RFMMessage.MessageBoxInfo("Нет данных по декларациям соответствия...");
					}
					return;
				}
			}

			ActiveReport3 rep = new QualityList();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
		}
		
		#endregion Quality

		#region Warrant

		public static void OutputDocumentWarrant_Print(OutputDocument oOutputDocumentPrint, 
			RFMFormChild thisForm, 
			bool bNoAsk)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentWarrant_Print(oOutputDocumentPrint, thisForm, bNoAsk, 
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentWarrant_Print(OutputDocument oOutputDocumentPrint,
			RFMFormChild thisForm,
			bool bNoAsk, 	
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentWarrant_Print(oOutputDocumentPrint, thisForm, bNoAsk, 
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentWarrant_Print(OutputDocument oOutputDocumentPrint, 
			RFMFormChild thisForm,
			bool bNoAsk, 
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
			int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			DataTable dt;

			// таблица по всем заказам
			if (oOutputDocumentPrint.ID.HasValue)
			{
				// один заказ
				oOutputDocumentPrint.ReFillOne((int)oOutputDocumentPrint.ID);

				if (!oOutputDocumentPrint.PF_WarrantNeed)
				{
					/*
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Доверенность не требуется...");
						return;
					}
					*/

					if (bNoAsk)
						return;

					if (RFMMessage.MessageBoxYesNo("Расходный документ не требует формирования доверенности на получение денег.\n\n" +
						"Все-таки сформировать доверенность на получение денег?") != DialogResult.Yes)
						return;
				}

				if (oOutputDocumentPrint.PF_WarrantNeed)
				{
					if (oOutputDocumentPrint.WarrantNumber == null || oOutputDocumentPrint.WarrantNumber.Length == 0)
					{
						// получаем очередной номер доверенности и записываем его в журнал
						oOutputDocumentPrint.WarrantSet((int)oOutputDocumentPrint.ID, null);
					}
					else
					{
						// заменяем данные о водителе, если они изменились
						WarrantNumber oWarrant = new WarrantNumber();
						oWarrant.Update((int)oOutputDocumentPrint.ID, null, null);
					}
				}

				oOutputDocumentPrint.FillWarrantTableOutputsDocuments(oOutputDocumentPrint.ID.ToString());
				if (oOutputDocumentPrint.ErrorNumber != 0 || 
					!oOutputDocumentPrint.DS.Tables.Contains("TableWarrantOutputsDocuments") ||
					oOutputDocumentPrint.DS.Tables["TableWarrantOutputsDocuments"] == null)
					return;
				if (oOutputDocumentPrint.DS.Tables["TableWarrantOutputsDocuments"].Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Нет данных по доверенности...");
					}
					return;
				}
				dt = oOutputDocumentPrint.DS.Tables["TableWarrantOutputsDocuments"];
			}
			else
			{
				oOutputDocumentPrint.FillData();
				if (oOutputDocumentPrint.ErrorNumber != 0)
					return;

				string sOutputsDocumentsList = oOutputDocumentPrint.IDList;
				if (sOutputsDocumentsList == null)
				{
					foreach (DataRow r in oOutputDocumentPrint.MainTable.Rows)
					{
						if ((bool)r["PF_WarrantNeed"])
						{
							sOutputsDocumentsList += r["ID"].ToString().Trim() + ",";
						}
					}
				}

				// проставить номера доверенностей
				WarrantNumber oWarrant = new WarrantNumber();
				OutputDocument oOutputDocumentPrintOne = new OutputDocument();
				foreach (DataRow r in oOutputDocumentPrint.MainTable.Rows)
				{
					oOutputDocumentPrintOne.FillOne(r);
					if (oOutputDocumentPrintOne.PF_WarrantNeed)
					{
						if (oOutputDocumentPrintOne.WarrantNumber == null || oOutputDocumentPrintOne.WarrantNumber.Length == 0)
						{
							// получаем очередной номер доверенности и записываем его в журнал
							oOutputDocumentPrintOne.WarrantSet((int)oOutputDocumentPrintOne.ID, null);
						}
						else
						{
							// заменяем данные о водителе, если они изменились
							oWarrant.Update((int)oOutputDocumentPrintOne.ID, null, null);
						}
					}
				}

				oOutputDocumentPrint.FillWarrantTableOutputsDocuments(sOutputsDocumentsList);
				dt = thisForm.CopyTable(oOutputDocumentPrint.DS.Tables["TableWarrantOutputsDocuments"], "dt", "", "");
				dt.PrimaryKey = null;
				if (dt.Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Нет данных по доверенностям...");
					}
					return;
				}
			}

			// сумма словами
			Setting oRub = new Setting();
			int nRubID = Convert.ToInt32(oRub.FillVariable("gnCurrencyBaseID"));
			foreach (DataRow r in dt.Rows)
			{ 
				if (Convert.ToDecimal(r["GetMoney"]) != 0)
				{
					decimal nGetMoney = Convert.ToDecimal(r["GetMoney"]);
					if (!Convert.IsDBNull(r["GetCurrencyID"]) && Convert.ToInt32(r["GetCurrencyID"]) == nRubID)
					{
						r["GetMoneyWords"] = RFMUtilities.ValToRub(nGetMoney);
					}
					else
					{
						r["GetMoneyWords"] = RFMUtilities.ValToRub(nGetMoney, r["GetCurrencyAlias"].ToString());
					}
				}
			}

			ActiveReport3 rep = new warrant();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
		}

		#endregion Warrant

		#region Ttn

		public static void OutputDocumentTtn_Print(OutputDocument oOutputDocumentPrint,
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentTtn_Print(oOutputDocumentPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentTtn_Print(OutputDocument oOutputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentTtn_Print(oOutputDocumentPrint, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentTtn_Print(OutputDocument oOutputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue)
				return;

			oOutputDocumentPrint.ReFillOne((int)oOutputDocumentPrint.ID);

			// есть ли еще документы того же клиента в том же рейсе или без рейса
			DateTime dDateOutput = oOutputDocumentPrint.DateOutput; 
			int nPartnerShipperID = oOutputDocumentPrint.PartnerShipperID;
			int nPartnerTargetID = oOutputDocumentPrint.PartnerTargetID; 
			int? nTripID = oOutputDocumentPrint.TripID;

			OutputDocument oOutputDocumentTemp = new OutputDocument();
			oOutputDocumentTemp.FilterDateBeg = dDateOutput;
			oOutputDocumentTemp.FilterDateEnd = dDateOutput;
			oOutputDocumentTemp.FilterPartnersTargetList = nPartnerTargetID.ToString();
			oOutputDocumentTemp.FilterPartnersSourceList = nPartnerShipperID.ToString();
			if (nTripID.HasValue)
			{
				oOutputDocumentTemp.FilterTripsList = nTripID.ToString();
			}
			else
			{
				oOutputDocumentTemp.FilterTripExists = false;
			}
			oOutputDocumentTemp.FillData();
			if (oOutputDocumentTemp.MainTable == null || 
				oOutputDocumentTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении списка аналогичных расходных документов...");
				return;
			}

			string sList = "";
			if (oOutputDocumentTemp.MainTable.Rows.Count > 1)
			{
				string sText = "Существует еще " + RFMUtilities.Declen(oOutputDocumentTemp.MainTable.Rows.Count - 1, "расходный документ", "расходных документа", "расходных документов") + 
					" для того же поставщика и получателя, " + 
					((nTripID.HasValue) ? "включенных в тот же рейс" : "не включенных в рейс") + ".\n" + 
					"Включить данные этих расходных документов в ТТН?";
				if (RFMMessage.MessageBoxYesNo(sText) == DialogResult.Yes)
				{
					foreach (DataRow r in oOutputDocumentTemp.MainTable.Rows)
					{
						sList += r["ID"].ToString() + ",";
					}
				}
			}
			if (sList.Length == 0)
			{
				sList = oOutputDocumentPrint.ID.ToString();
			}

			oOutputDocumentPrint.FillTTNTableOutputsDocuments(sList);
			if (oOutputDocumentPrint.ErrorNumber != 0 ||
				!oOutputDocumentPrint.DS.Tables.Contains("TableOutputsDocumentsTTN") ||
				oOutputDocumentPrint.DS.Tables["TableOutputsDocumentsTTN"] == null) 
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о товарах в расходном документе для формирования ТТН...");
				return;
			}
			
			thisForm.StartForm(new frmOutputsDocumentsTTNData(oOutputDocumentPrint.DS.Tables["TableOutputsDocumentsTTN"]));

			/*
			DataTable dt = oOutputDocumentPrint.DS.Tables["TableOutputsDocumentsTTN"];
			ActiveReport3 rep = new TtnOneLine();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
			*/ 
		}

		#endregion Ttn

		#region Transport

		public static void OutputDocumentTransportAct_Print(OutputDocument oOutputDocumentPrint,
				decimal nVat, 
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentTransportAct_Print(oOutputDocumentPrint, nVat, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentTransportAct_Print(OutputDocument oOutputDocumentPrint,
				decimal nVat,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentTransportAct_Print(oOutputDocumentPrint, nVat, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentTransportAct_Print(OutputDocument oOutputDocumentPrint,
				decimal nVat, 
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue)
				return;

			int nOutputDocumentID = (int)oOutputDocumentPrint.ID;

			oOutputDocumentPrint.ReFillOne(nOutputDocumentID);
			if (oOutputDocumentPrint.DeliveryPrice == 0)
			{
				if (!bToArrayList)
				{
					RFMMessage.MessageBoxInfo("Не указана стоимость транспортных услуг...");
					return;
				}
			}

			DataTable dt; 
			oOutputDocumentPrint.FillTransportTableOutputsDocuments(nOutputDocumentID, nVat);
			if (oOutputDocumentPrint.DS.Tables.Contains("TableTransport"))
			{
				dt = oOutputDocumentPrint.DS.Tables["TableTransport"];

				// акт
				ActiveReport3 rep = new TransportAct();
				if (bToArrayList)
				{
					// только сохраняем в массивы
					_aDataTables.Add(dt);
					_aReps.Add(rep);
					_aCopiesCnt.Add(nCopiesCnt);
				}
				else
				{
					// выводим и печатаем
					thisForm.StartForm(new frmActiveReport(dt, rep));
				}
			}
		}


		public static void OutputDocumentTransportFacture_Print(OutputDocument oOutputDocumentPrint,
				decimal nVat, 
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentTransportFacture_Print(oOutputDocumentPrint, nVat, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentTransportFacture_Print(OutputDocument oOutputDocumentPrint,
				decimal nVat,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentTransportFacture_Print(oOutputDocumentPrint, nVat, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentTransportFacture_Print(OutputDocument oOutputDocumentPrint,
				decimal nVat, 
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue)
				return;

			int nOutputDocumentID = (int)oOutputDocumentPrint.ID;

			oOutputDocumentPrint.ReFillOne(nOutputDocumentID);
			if (oOutputDocumentPrint.DeliveryPrice == 0)
			{
				if (!bToArrayList)
					RFMMessage.MessageBoxInfo("Не указана стоимость транспортных услуг...");
				return;
			}

			if (!oOutputDocumentPrint.PF_FactureNeed)
			{
				if (!bToArrayList)
					RFMMessage.MessageBoxInfo("Оформление счета-фактуры для транспортных услуг не требуется...");
				return;
			}

			// стандартный с-ф, но с одной записью "транспортные услуги"
			oOutputDocumentPrint.FillBillTableOutputsDocumentsGoods(nOutputDocumentID);
			if (oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows.Count > 0)
			{
				int nIDTemp = (int)oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows[0]["ID"];
				DataTable dt = thisForm.CopyTable(oOutputDocumentPrint.TableOutputsDocumentsGoods, "dtFacture", "ID = " + nIDTemp.ToString(), "");
				DataRow r = dt.Rows[0];
				decimal nSum = oOutputDocumentPrint.DeliveryPrice;
				decimal nVatSum = nSum * nVat / (100 + nVat);
				decimal nNoVatSum = nSum - nVatSum;

                // Изменение от 16.12.2011
                // По распоряжению бухгалтерии вместо Грузоотправителя и Грузополучателя печатаем прочерки
                r["ShipperNameAddress"] = "----------------";
                r["PayerFactNameAddress"] = "----------------";

                r["FactureNumber"] = r["FactureNumber"].ToString() + "/T";
				r["GoodAlias"] =
				r["GoodName"] =
				r["PackingAlias"] = "Транспортные услуги";
				r["Qnt"] = 1;
				r["Vat"] = nVat;
				r["Price"] =
				r["PriceSum"] = nSum;
				r["VATSum"] = 
				r["VATAllSum"] = nVatSum;
				r["PriceNoVat"] =
				r["PriceNoVATSum"] = 
				r["NoVATAllSum"] = nNoVatSum;
				r["InBox"] = 1;
				r["CustomNumber"] = "----------";
				r["CountryName"] = "Россия";
				r["GoodBarCode"] =
				r["Articul"] =
				r["OriginalGoodCode"] =
				r["GoodCode"] =
				r["SupplierGoodCode"] =
				r["Pack"] =
				r["GoodOKPCode"] =
				r["ERPCode"] =

                r["WeightCode"] = "796";
                r["WeightText"] = "шт";
                r["CountryCode"] = "";
                r["CountryName"] = "";

				r["Netto"] =
				r["Brutto"] = 
				r["NettoSum"] =
				r["BruttoSum"] = 
					0;

				r["Weighting"] = false;

				r["PrintPageNumber"] =
				r["PrintNumberInPage"] =
				r["ByOrder"] = 1;
				
				r["Cnt"] = 
				r["OutputDocumentQnt"] = 
				r["OutputDocumentBox"] = 1;

				r["VAT1Rate"] = nVat;
				r["VAT1Sum"] = nVatSum;
				r["NoVAT1Sum"] = nNoVatSum;
				r["VATText1"] = "НДС " + nVat.ToString() + "%: товар - " + nNoVatSum.ToString("########0.00") + ", налог - " + nVatSum.ToString("########0.00");
				r["VAT2Rate"] = 
				r["VAT2Sum"] = 
				r["NoVAT2Sum"] = 0;
				r["VATText2"] = "";

				ActiveReport3 rep = new facture();
				if (bToArrayList)
				{
					// только сохраняем в массивы
					_aDataTables.Add(dt);
					_aReps.Add(rep);
					_aCopiesCnt.Add(nCopiesCnt);
				}
				else
				{
					// выводим и печатаем
					thisForm.StartForm(new frmActiveReport(dt, rep));
				}
			}
		}

		#endregion Transport

		#region VeterinaryPayment

		public static void OutputDocumentVeterinaryPayment_Print(OutputDocument oOutputDocumentPrint,
				string sMode,  
				decimal nVat, 
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, sMode, nVat, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentVeterinaryPayment_Print(OutputDocument oOutputDocumentPrint,
				string sMode,  
				decimal nVat,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, sMode, nVat, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentVeterinaryPayment_Print(OutputDocument oOutputDocumentPrint,
				string sMode,  
				decimal nVat, 
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, sMode, nVat, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref _aCopiesCnt, nCopiesCnt, false);
		}

		public static void OutputDocumentVeterinaryPayment_Print(OutputDocument oOutputDocumentPrint,
				string sMode,  
				decimal nVat, 
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt, 
				bool bUsePerversionCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue)
				return;

			int nOutputDocumentID = (int)oOutputDocumentPrint.ID;

			oOutputDocumentPrint.ReFillOne(nOutputDocumentID);
			if (oOutputDocumentPrint.VeterinaryPrice == 0)
			{
				if (!bToArrayList)
				{
					RFMMessage.MessageBoxInfo("Не указана стоимость оформления ветеринарных свидетельств...");
					return;
				}
			}

			oOutputDocumentPrint.FillBillTableOutputsDocumentsGoods(nOutputDocumentID);
			if (oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных о товарах в расходном документе...");
				return;
			}

			// стандартный документ (накладная или счет-фактура), но с одной записью "транспортные услуги"
			int nIDTemp = (int)oOutputDocumentPrint.TableOutputsDocumentsGoods.Rows[0]["ID"];
			DataTable dt = thisForm.CopyTable(oOutputDocumentPrint.TableOutputsDocumentsGoods, "dtFacture", "ID = " + nIDTemp.ToString(), "");
			DataRow r = dt.Rows[0];
			decimal nSum = oOutputDocumentPrint.VeterinaryPrice;
			decimal nVatSum = Math.Round(nSum * nVat / (100 + nVat), 2);
			decimal nNoVatSum = nSum - nVatSum;
			r["BillNumber"] = r["BillNumber"].ToString() + "/В";
			r["FactureNumber"] = r["FactureNumber"].ToString() + "/В";

			r["Cnt"] = 
			r["OutputDocumentQnt"] =
			r["OutputDocumentBox"] = 1;
			r["OutputDocumentBrutto"] = 
			r["OutputDocumentNetto"] = 0;
			r["CurrencyID"] = oOutputDocumentPrint.VeterinaryCurrencyID; 
			r["CurrencyAlias"] = oOutputDocumentPrint.VeterinaryCurrencyName; 
			r["CurrencyAlias"] = 
			r["CurrencyISODigitalCode"] = "";

			r["PackingID"] = 
			r["GoodID"] = 0;
			r["GoodAlias"] =
			r["GoodName"] =
            //r["PackingAlias"] = "Вет.свидетельство ФОРМА-2 а/м";
            // Изменено по требованию МБК 19.01.2011
            r["PackingAlias"] = "Вет.свидетельство ФОРМА-2";
            r["Qnt"] =
			r["Box"] =
			r["Pal"] =
			r["InBox"] = 1;
			r["Vat"] = nVat;
			r["Amount"] = 
			r["Price"] =
			r["PriceSum"] = nSum;
			r["VATSum"] =
			r["VATAllSum"] = nVatSum;
			r["PriceNoVat"] =
			r["PriceNoVATSum"] =
			r["NoVATAllSum"] = nNoVatSum;
			r["Netto"] =
			r["NettoSum"] =
			r["Brutto"] =
			r["BruttoSum"] = 0;
			r["CustomNumber"] = "----------";
			r["CountryName"] = "Россия";

			r["GoodBarCode"] =
			r["Articul"] =
			r["OriginalGoodCode"] =
			r["GoodCode"] =
			r["SupplierGoodCode"] =
			r["Pack"] =
			r["GoodOKPCode"] =
			r["ERPCode"] =
			r["GoodGroupName"] =
			r["GoodBrandName"] =
			r["CountryName"] =
			r["ExtraData"] =
			r["WeightText"] = "";

			r["Weighting"] = false;

			r["PrintPageNumber"] =
			r["PrintNumberInPage"] =
			r["ByOrder"] = 1;

			r["Cnt"] =
			r["OutputDocumentQnt"] =
			r["OutputDocumentBox"] = 1;

			r["VAT1Rate"] = nVat;
			r["VAT1Sum"] = nVatSum;
			r["NoVAT1Sum"] = nNoVatSum;
			r["VATText1"] = "НДС " + nVat.ToString() + "%: товар - " + nNoVatSum.ToString("########0.00") + ", налог - " + nVatSum.ToString("########0.00");
			r["VAT2Rate"] =
			r["VAT2Sum"] =
			r["NoVAT2Sum"] = 0;
			r["VATText2"] = "";

			//
			sMode = sMode.ToUpper();

			string sPF_Type = "";
			string sPF_Name = ""; 
			string sXMLTemplateText = "";

			int? nLinesInPage = LinesInPage_GetSetting();

			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			Partner oPartner = new Partner();
			oPartner.ReFillOne(oOutputDocumentPrint.PartnerTargetID);  

			#region Bill

			if (sMode == "BILL")
            {
				if (!oOutputDocumentPrint.PF_BillNeed)
				{
					if (bToArrayList)
						return;
					if (RFMMessage.MessageBoxYesNo("Расходный документ не требует формирования накладной.\n\n" +
						"Все-таки сформировать накладную на оплату ветеринарных свидетельств?") != DialogResult.Yes)
						return;
					if ((oOutputDocumentPrint.BillNumber == null || oOutputDocumentPrint.BillNumber.Trim().Length == 0) &&
						RFMMessage.MessageBoxYesNo("Для расходного документа не определен номер накладной.\n\n" +
						"Все-таки сформировать накладную на оплату ветеринарных свидетельств?") != DialogResult.Yes)
						return;						
				}

				sPF_Type = "PF_Bill";

				if (bUsePerversionCopiesCnt && oPartner.PF_BillCopiesCount != 0)
					nCopiesCnt = oPartner.PF_BillCopiesCount;

				if (oPartner.PF_BillName == null || oPartner.PF_BillName.Trim() == "")
				{
					// общий шаблон:

					// режим печати 
					if (oOutputDocumentPrint.PrintMode == null || oOutputDocumentPrint.PrintMode.Trim().Length == 0)
					{
						// стандартная форма
                        rep = new billLandscape();
					}
					else
					{
						switch (oOutputDocumentPrint.PrintMode)
						{ 
							case "P":
                                rep = new billPortrait();
                                break;
                            default:
                                rep = new billLandscape();
                                break;
						}
					}

					a_rep.Add(rep);
					a_dt.Add(dt);
					a_cnt.Add(nCopiesCnt);
				}
				else
				{
					// свой собственный шаблон:
					sXMLTemplateText = oPartner.XMLTemplateTextGet((int)oPartner.ID, sPF_Type, ref sPF_Name, ref nLinesInPage);
					if (sXMLTemplateText != null && sXMLTemplateText.Length > 0)
					{
						// записать шаблон во врем.файл и загрузить его в документ
						rep = new ActiveReport3(); 
						if (XMLTemplateTextToFile(sXMLTemplateText, sPF_Name, rep))
						{ 
							a_rep.Add(rep);
							a_dt.Add(dt);
							a_cnt.Add(nCopiesCnt);
						}
					}
					else
					{
						// режим печати 
						if (oOutputDocumentPrint.PrintMode == null || oOutputDocumentPrint.PrintMode.Trim().Length == 0)
						{
							// стандартная форма
                            rep = new billLandscape();
						}
						else
						{
							switch (oOutputDocumentPrint.PrintMode)
							{
								case "P":
                                    rep = new billPortrait();
                                    break;
                                default:
                                    rep = new billLandscape();
                                    break;
							}
						}

						a_rep.Add(rep);
						a_dt.Add(dt);
						a_cnt.Add(nCopiesCnt);
					}
				}
			}

			#endregion Bill

			#region Facture

			if (sMode == "FACTURE")
			{
				if (!oOutputDocumentPrint.PF_FactureNeed)
				{
					if (bToArrayList)
						return;
					if (RFMMessage.MessageBoxYesNo("Расходный документ не требует формирования счета-фактуры.\n\n" +
						"Все-таки сформировать счет-фактуру на оплату ветеринарных свидетельств?") != DialogResult.Yes)
						return;
					if ((oOutputDocumentPrint.FactureNumber == null || oOutputDocumentPrint.FactureNumber.Trim().Length == 0) &&
						RFMMessage.MessageBoxYesNo("Для расходного документа не определен номер счета-фактуры.\n\n" +
						"Все-таки сформировать счет-фактуру на оплату ветеринарных свидетельств?") != DialogResult.Yes)
						return;
				}

				sPF_Type = "PF_Facture";

				if (bUsePerversionCopiesCnt && oPartner.PF_FactureCopiesCount != 0)
					nCopiesCnt = (int)oPartner.PF_FactureCopiesCount;

				if (oPartner.PF_FactureName == null || oPartner.PF_FactureName.Trim() == "") 
				{
					// общий шаблон
					rep = new facture();

					a_rep.Add(rep);
					a_dt.Add(dt);
					a_cnt.Add(nCopiesCnt);
				}
				else
				{
					// свой собственный шаблон счета-фактуры
					sXMLTemplateText = oPartner.XMLTemplateTextGet((int)oPartner.ID, sPF_Type, ref sPF_Name, ref nLinesInPage);
					if (sXMLTemplateText != null && sXMLTemplateText.Length > 0)
					{
						rep = new ActiveReport3();
						if (XMLTemplateTextToFile(sXMLTemplateText, sPF_Name, rep))
						{
							a_rep.Add(rep);
							a_dt.Add(dt);
							a_cnt.Add(nCopiesCnt);
						}
					}
					else
					{
						rep = new facture();

						a_rep.Add(rep);
						a_dt.Add(dt);
						a_cnt.Add(nCopiesCnt);
					}
				}
			}

			#endregion Facture 


			if (a_dt.Count == 0)
			{
				if (!bToArrayList)
				{
					RFMMessage.MessageBoxInfo("Нет данных...");
				}
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach(DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach(ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion VeterinaryPayment

		#region GoodsGroupsList

		public static void OutputDocumentGoodsGroupsList_Print(OutputDocument oOutputDocumentPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentGoodsGroupsList_Print(oOutputDocumentPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputDocumentGoodsGroupsList_Print(OutputDocument oOutputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputDocumentGoodsGroupsList_Print(oOutputDocumentPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputDocumentGoodsGroupsList_Print(OutputDocument oOutputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			DataTable dt;
			int nOutputDocumentID = 0;
			
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			oOutputDocumentPrint.FillData();
			if (oOutputDocumentPrint.MainTable.Rows.Count == 0)
				return;

			oOutputDocumentPrint.FillGoodsGroupsListTable(-1);
			dt = thisForm.CopyTable(oOutputDocumentPrint.DS.Tables["TableGoodsGroupsList"], "dt", "", "");

			foreach(DataRow r in oOutputDocumentPrint.MainTable.Rows)
			{
				nOutputDocumentID = (int)r["ID"];
				oOutputDocumentPrint.FillGoodsGroupsListTable(nOutputDocumentID);
				dt.Merge(oOutputDocumentPrint.DS.Tables["TableGoodsGroupsList"]);
			}

			ActiveReport3 rep = new GoodsGroupsList();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
		}

		#endregion GoodsGroupsList

		#region MX3 - выдача с хранения

		public static void OutputDocumentMX3_Print(OutputDocument oOutputDocumentPrint, bool bGroupByBillNumber, 
			RFMFormChild thisForm)
		{
			if (!oOutputDocumentPrint.ID.HasValue && oOutputDocumentPrint.IDList == null)
				return;

			bool bOne = !string.IsNullOrEmpty(oOutputDocumentPrint.ID.ToString())  && string.IsNullOrEmpty(oOutputDocumentPrint.IDList);

			oOutputDocumentPrint.FillData();
			if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.MainTable == null ||
				oOutputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по " + (bOne ? "расходному документу" : "расходным документам") + "...");
				return;
			}

			// неподтвержденные документы
			DataView dv = new DataView(oOutputDocumentPrint.MainTable, "DateConfirm is null", "ID", DataViewRowState.CurrentRows);
			if (dv.Count > 0)
			{
				RFMMessage.MessageBoxInfo("Товар по " + (bOne ? "расходному документу" : "расходным документам") + " еще не выдан...");
				return;
			}

			if (oOutputDocumentPrint.MainTable.Rows.Count > 1)
			{
				dv = new DataView(oOutputDocumentPrint.MainTable, "", "ID", DataViewRowState.CurrentRows);
				// один поставщик?
				DataTable dt = dv.ToTable(true, "PartnerSourceID");
				if (dt.Rows.Count > 1)
				{
					RFMMessage.MessageBoxInfo("Расходные документы от разных поставщиков...");
					return;
				}
				// один владелец товара
				dt = dv.ToTable(true, "OwnerID");
				if (dt.Rows.Count > 1)
				{
					RFMMessage.MessageBoxInfo("Расходные документы от разных владельцев товара...");
					return;
				}
				// одна дата отгрузки
				DataColumn c = oOutputDocumentPrint.MainTable.Columns.Add("DateOutputString");
				foreach (DataRow r in oOutputDocumentPrint.MainTable.Rows)
					r["DateOutputString"] = Convert.ToDateTime(r["DateOutput"]).ToString("YYYYMMDD");
				dt = new DataView(oOutputDocumentPrint.MainTable, "", "DateOutputString", DataViewRowState.CurrentRows).ToTable(true, "DateOutputString");
				if (dt.Rows.Count > 1 &&
					RFMMessage.MessageBoxYesNo("Расходные документы имеют разные даты отгрузки.\n" +
						"Продолжить?") != DialogResult.Yes)
					return;
			}
			//

            Report oReport = new Report();
            oReport.Report_OutputsDocumentsMX3((bOne ? oOutputDocumentPrint.ID.ToString() : oOutputDocumentPrint.IDList), bGroupByBillNumber);
			if (oReport.ErrorNumber != 0)
				return;
			if (oReport.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

            // Изменение от 19.12.2011
            // Даем возможность замены полных имен хранителя и поклажедателя
            // Предлагаем на выбор два поля из oInputPrintOne.TableInputsGoods,
            // а также полученную из установок системы (таблица _Settings) строку
            // с юр. названием компании и адресом склада
            string sPayer = "", sPayee = "", sWe = "";
            sPayer = oReport.MainTable.Rows[0]["WarehouseOwner"].ToString();
            sPayee = oReport.MainTable.Rows[0]["GoodsOwner"].ToString();
            sWe = oReport.Report_GetWeNameStorageAddress();

            // Если все три названия совпадают, оставляем значения по умолчанию
            if (sPayer != sPayee || sPayer != sWe || sPayee != sWe)
            {
                DataTable dtCompanies = new DataTable("Companies");
                dtCompanies.Columns.Add("Name", typeof(string));
                dtCompanies.Columns.Add("IsPayer", typeof(bool));
                dtCompanies.Columns.Add("IsPayee", typeof(bool));

                // Payer
                dtCompanies.Rows.Add();
                DataRow dr0 = dtCompanies.Rows[0];
                dr0[0] = sPayer;
                dr0[1] = false;
                dr0[2] = false;

                // Payee
                if (sPayer != sPayee)
                {
                    dtCompanies.Rows.Add();
                    DataRow dr1 = dtCompanies.Rows[dtCompanies.Rows.Count - 1];
                    dr1[0] = sPayee;
                    dr1[1] = false;
                    dr1[2] = false;
                }

                // We
                if (sWe != sPayer && sWe != sPayee)
                {
                    dtCompanies.Rows.Add();
                    DataRow dr2 = dtCompanies.Rows[dtCompanies.Rows.Count - 1];
                    dr2[0] = sWe;
                    dr2[1] = false;
                    dr2[2] = false;
                }

                // Выбор значений шапки
                if (thisForm.StartForm(new frmGetMXNames(dtCompanies)) != DialogResult.Yes)
                    return;

                // Получение и замена значений
                sPayer = sPayee = "";
                foreach (DataRow dr in dtCompanies.Rows)
                {
                    if ((bool)dr[1] == true)
                        sPayer = dr[0].ToString();
                    if ((bool)dr[2] == true)
                        sPayee = dr[0].ToString();
                }
                foreach (DataRow dr in oReport.MainTable.Rows)
                {
                    dr["WarehouseOwner"] = sPayer;
                    dr["GoodsOwner"] = sPayee;
                }
            }
            // Изменение от 19.12.2011 (конец)

            thisForm.StartForm(new frmActiveReport(oReport.MainTable, new billMX3()));
		}

		#endregion MX3 - выдача с хранения

		#endregion OutputDocument Print

		#region Additional ID (Set / Clear)

		public static bool OutputDocumentQuality_Set(int nOutputDocumentID, bool bUpdate)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
				return (false);
			}

			bool bResult = oOutputDocument.SetGoodQualityID(nOutputDocumentID, bUpdate);
			if (!bResult || oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при заполнении данных о сертификатах качества для товаров в расходном документе...");
			}
			return (bResult);
		}

		public static bool OutputDocumentVeterinary_Set(int nOutputDocumentID, bool bUpdate)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
				return (false);
			}

			bool bResult = oOutputDocument.SetGoodVeterinaryID(nOutputDocumentID, bUpdate);
			if (!bResult || oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при заполнении данных о ветеринарных свидетельствах для товаров в расходном документе...");
			}

			return (bResult);
		}

		public static bool OutputDocumentCustomNumber_Set(int nOutputDocumentID, bool bUpdate)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
				return (false);
			}

			bool bResult = oOutputDocument.SetGoodCustomNumber(nOutputDocumentID, bUpdate);
			if (!bResult || oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при заполнении данных о номерах ГТД для товаров в расходном документе...");
			}

			return (bResult);
		}

		// 

		public static bool OutputDocumentQuality_Clear(int nOutputDocumentID)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
				return (false);
			}

			bool bResult = oOutputDocument.ClearGoodQualityID(nOutputDocumentID);
			if (!bResult || oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при очистке данных о сертификатах качества для товаров в расходном документе...");
			}
			return (bResult);
		}

		public static bool OutputDocumentVeterinary_Clear(int nOutputDocumentID)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
				return (false);
			}

			bool bResult = oOutputDocument.ClearGoodVeterinaryID(nOutputDocumentID);
			if (!bResult || oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при очистке данных о ветеринарных свидетельствах для товаров в расходном документе...");
			}
			return (bResult);
		}

		public static bool OutputDocumentCustomNumber_Clear(int nOutputDocumentID)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
				return (false);
			}

			bool bResult = oOutputDocument.ClearGoodCustomNumber(nOutputDocumentID);
			if (!bResult || oOutputDocument.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при очистке номеров ГТД для товаров в расходном документе...");
			}
			return (bResult);
		}

		#endregion Additional ID 

		#region Veterinary Licence Need Set / Clear

		public static bool OutputDocumentVeterinaryLicenceNeed_Set(int nOutputDocumentID, bool bSet)
		{
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.ReFillOne(nOutputDocumentID);

			if (bSet)
			{
				if (oOutputDocument.VeterinaryLicenceNeed)
				{
					RFMMessage.MessageBoxInfo("Для расходного документа требуется ветеринарное свидетельство.");
					return (false);
				}

				if (RFMMessage.MessageBoxYesNo("Установить признак \"Требуется ветеринарное свидетельство\" для расходного документа?") != DialogResult.Yes)
					return (false);
			}
			else
			{
				if (!oOutputDocument.VeterinaryLicenceNeed)
				{
					RFMMessage.MessageBoxInfo("Для расходного документа не требуется ветеринарное свидетельство.");
					return (false);
				}

				if (RFMMessage.MessageBoxYesNo("Снять признак \"Требуется ветеринарное свидетельство\" для расходного документа?") != DialogResult.Yes)
					return (false);
			}

			bool bResult = oOutputDocument.VeterinaryLicenceNeedSet(nOutputDocumentID, bSet);

			return (bResult);
		}

		#endregion Veterinary Licence Need Set / Clear

		#endregion OutputDocument

		#region InputDocument

		#region Bill

		public static void InputDocumentBill_Print(InputDocument oInputDocumentPrint,
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputDocumentBill_Print(oInputDocumentPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputDocumentBill_Print(InputDocument oInputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputDocumentBill_Print(oInputDocumentPrint, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void InputDocumentBill_Print(InputDocument oInputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputDocumentPrint.ID.HasValue && oInputDocumentPrint.IDList == null)
				return;

			oInputDocumentPrint.FillData();
			if (oInputDocumentPrint.ErrorNumber != 0 || oInputDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка приходных документов...");
				return;
			}
			if (oInputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в приходных документах...");
				return;
			}

			InputDocument oInputDocumentPrintOne = new InputDocument();

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oInputDocumentPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной заказ
				oInputDocumentPrintOne.FillOne(r);

				// таблица товаров для документа
				oInputDocumentPrintOne.FillBillTableInputsDocumentsGoods((int)r["ID"]);
				dt = oInputDocumentPrintOne.TableInputsDocumentsGoods;

				rep = new InputDocumentBill();
				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion Bill

		#region ReverseBill

		public static void InputDocumentReverseBill_Print(InputDocument oInputDocumentPrint,
			string sMode,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputDocumentReverseBill_Print(oInputDocumentPrint, sMode, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputDocumentReverseBill_Print(InputDocument oInputDocumentPrint,
				string sMode,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputDocumentReverseBill_Print(oInputDocumentPrint, sMode, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void InputDocumentReverseBill_Print(InputDocument oInputDocumentPrint,
				string sMode,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputDocumentPrint.ID.HasValue && oInputDocumentPrint.IDList == null)
				return;

			oInputDocumentPrint.FillData();
			if (oInputDocumentPrint.ErrorNumber != 0 || oInputDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка приходных документов...");
				return;
			}
			if (oInputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в приходных документах...");
				return;
			}

			InputDocument oInputDocumentPrintOne = new InputDocument();

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oInputDocumentPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной заказ
				oInputDocumentPrintOne.FillOne(r);

				// таблица товаров для документа
				oInputDocumentPrintOne.FillReverseBillTableInputsDocumentsGoods((int)r["ID"]);
				dt = oInputDocumentPrintOne.TableInputsDocumentsGoods;

				if (sMode.Contains("BILL"))
				{
					rep = new billPortrait();
					a_rep.Add(rep);
					a_dt.Add(dt);
					a_cnt.Add(nCopiesCnt);
				}

				if (sMode.Contains("FACTURE"))
				{
					rep = new facture();
					a_rep.Add(rep);
					a_dt.Add(dt);
					a_cnt.Add(nCopiesCnt);
				}
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion ReverseBill

		#region Warrant

		public static void InputDocumentWarrant_Print(InputDocument oInputDocumentPrint,
			RFMFormChild thisForm, 
			bool bNoAsk)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputDocumentWarrant_Print(oInputDocumentPrint, thisForm, bNoAsk, 
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputDocumentWarrant_Print(InputDocument oInputDocumentPrint,
			RFMFormChild thisForm,
			bool bNoAsk, 	
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputDocumentWarrant_Print(oInputDocumentPrint, thisForm, bNoAsk, 
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void InputDocumentWarrant_Print(InputDocument oInputDocumentPrint,
			RFMFormChild thisForm,
			bool bNoAsk,  
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
			int nCopiesCnt)
		{
			if (!oInputDocumentPrint.ID.HasValue && oInputDocumentPrint.IDList == null)
				return;

			DataTable dt;

			// таблица по всем заказам
			if (oInputDocumentPrint.ID.HasValue)
			{
				// один заказ
				oInputDocumentPrint.ReFillOne((int)oInputDocumentPrint.ID);
				if (!oInputDocumentPrint.PF_WarrantNeed)
				{
					/*
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Доверенность не требуется...");
						return;
					}
					*/ 

					if (bNoAsk)
						return;

					if (RFMMessage.MessageBoxYesNo("Приходный документ не требует формирования доверенности на получение товара.\n\n" +
						"Все-таки сформировать доверенность на получение товара?") != DialogResult.Yes)
						return;
				}

				if (oInputDocumentPrint.PF_WarrantNeed)
				{
					if (oInputDocumentPrint.WarrantNumber == null || oInputDocumentPrint.WarrantNumber.Length == 0)
					{
						// получаем очередной номер доверенности и записываем его в журнал
						oInputDocumentPrint.WarrantSet((int)oInputDocumentPrint.ID, null);
					}
					else
					{
						WarrantNumber oWarrant = new WarrantNumber();  
						oWarrant.Update(null, (int)oInputDocumentPrint.ID, null);
					}
				}

				oInputDocumentPrint.FillWarrantTableInputsDocuments(oInputDocumentPrint.ID.ToString());
				if (oInputDocumentPrint.ErrorNumber != 0 ||
					!oInputDocumentPrint.DS.Tables.Contains("TableWarrantInputsDocuments") ||
					oInputDocumentPrint.DS.Tables["TableWarrantInputsDocuments"] == null)
					return;
				if (oInputDocumentPrint.DS.Tables["TableWarrantInputsDocuments"].Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Нет данных по доверенности...");
					}
					return;
				}
				dt = oInputDocumentPrint.DS.Tables["TableWarrantInputsDocuments"];
			}
			else
			{
				oInputDocumentPrint.FillData();
				if (oInputDocumentPrint.ErrorNumber != 0)
					return;

				string sInputsDocumentsList = oInputDocumentPrint.IDList;
				if (sInputsDocumentsList == null)
				{
					foreach (DataRow r in oInputDocumentPrint.MainTable.Rows)
					{
						if ((bool)r["PF_WarrantNeed"])
						{
							sInputsDocumentsList += r["ID"].ToString().Trim() + ",";
						}
					}
				}

				// проставить номера доверенностей
				InputDocument oInputDocumentPrintOne = new InputDocument();
				foreach (DataRow r in oInputDocumentPrint.MainTable.Rows)
				{
					oInputDocumentPrintOne.FillOne(r);
					if (oInputDocumentPrintOne.PF_WarrantNeed)
					{
						if (oInputDocumentPrintOne.WarrantNumber == null || oInputDocumentPrintOne.WarrantNumber.Length == 0)
						{
							// получаем очередной номер доверенности
							oInputDocumentPrintOne.WarrantSet((int)oInputDocumentPrintOne.ID, null);
						}
						else
						{
							WarrantNumber oWarrant = new WarrantNumber();
							oWarrant.Update(null, (int)oInputDocumentPrintOne.ID, null);
						}
					}
				}

				oInputDocumentPrint.FillWarrantTableInputsDocuments(sInputsDocumentsList);
				dt = thisForm.CopyTable(oInputDocumentPrint.DS.Tables["TableWarrantInputsDocuments"], "dt", "", "");
				dt.PrimaryKey = null;
				if (dt.Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Нет данных по доверенностям...");
					}
					return;
				}
			}

			ActiveReport3 rep = new warrant();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
		}

		#endregion Warrant

		#region InputDocumentMX1
		
		public static void InputDocumentMX1_Print(InputDocument oInputDocumentPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputDocumentMX1_Print(oInputDocumentPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputDocumentMX1_Print(InputDocument oInputDocumentPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputDocumentMX1_Print(oInputDocumentPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void InputDocumentMX1_Print(InputDocument oInputDocumentPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputDocumentPrint.ID.HasValue && oInputDocumentPrint.IDList == null)
				return;

			oInputDocumentPrint.FillData();
			if (oInputDocumentPrint.ErrorNumber != 0 || oInputDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка приходных документов...");
				return;
			}
			if (oInputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в приходных документах...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oInputDocumentPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной приход 
				InputDocument oInputDocumentPrintOne = new InputDocument();

				oInputDocumentPrintOne.ID = (int)r["ID"];
				oInputDocumentPrintOne.FillData();
				if (oInputDocumentPrintOne.MainTable == null || oInputDocumentPrintOne.MainTable.Rows.Count == 0)
					continue;
				oInputDocumentPrintOne.FillOne(oInputDocumentPrintOne.MainTable.Rows[0]);

				// таблица товаров 
				oInputDocumentPrintOne.FillBillTableInputsDocumentsGoods((int)oInputDocumentPrintOne.ID);

				// добавляем поля шапки в таблицу товаров 
				oInputDocumentPrintOne.DS.Relations.Add("r1", oInputDocumentPrintOne.MainTable.Columns["InputDocumentID"],
					oInputDocumentPrintOne.TableInputsDocumentsGoods.Columns["InputDocumentID"]);

				oInputDocumentPrintOne.TableInputsDocumentsGoods.Columns.Add("InputID");
				oInputDocumentPrintOne.TableInputsDocumentsGoods.Columns["InputID"].Expression = "Parent([r1]).InputDocumentID";

				oInputDocumentPrintOne.TableInputsDocumentsGoods.Columns.Add("DateInputText");
				oInputDocumentPrintOne.TableInputsDocumentsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oInputDocumentPrintOne.TableInputsDocumentsGoods.Rows)
				{
					rr["DateInputText"] = rr["DateInput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
				}

				dt = oInputDocumentPrintOne.TableInputsDocumentsGoods;
				rep = new billMX1();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion InputDocumentMX1

		#endregion InputDocument

		#region Input

		#region InputBill

		public static void InputBill_Print(Input oInputPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputBill_Print(oInputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputBill_Print(Input oInputPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputBill_Print(oInputPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void InputBill_Print(Input oInputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputPrint.ID.HasValue && oInputPrint.IDList == null)
				return;

			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на приход...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на приход...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oInputPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной приход 
				Input oInputPrintOne = new Input();

				oInputPrintOne.ID = (int)r["ID"];
				oInputPrintOne.FillData();
				if (oInputPrintOne.MainTable == null || oInputPrintOne.MainTable.Rows.Count == 0)
					continue;
				oInputPrintOne.FillOne(oInputPrintOne.MainTable.Rows[0]);

				// таблица товаров для задания 
				oInputPrintOne.FillTableInputsGoods();

				// добавляем поля шапки в таблицу товаров 
				oInputPrintOne.DS.Relations.Add("r1", oInputPrintOne.MainTable.Columns["InputID"],
					oInputPrintOne.TableInputsGoods.Columns["InputID"]);

				oInputPrintOne.TableInputsGoods.Columns.Add("InputTypeName");
				oInputPrintOne.TableInputsGoods.Columns["InputTypeName"].Expression = "Parent([r1]).InputTypeName";
				oInputPrintOne.TableInputsGoods.Columns.Add("InputGoodStateName");
				oInputPrintOne.TableInputsGoods.Columns["InputGoodStateName"].Expression = "Parent([r1]).GoodStateName";
				oInputPrintOne.TableInputsGoods.Columns.Add("PartnerName");
				oInputPrintOne.TableInputsGoods.Columns["PartnerName"].Expression = "Parent([r1]).PartnerName";
				oInputPrintOne.TableInputsGoods.Columns.Add("OwnerName");
				oInputPrintOne.TableInputsGoods.Columns["OwnerName"].Expression = "Parent([r1]).OwnerName";
				oInputPrintOne.TableInputsGoods.Columns.Add("TripAlias");
				oInputPrintOne.TableInputsGoods.Columns["TripAlias"].Expression = "Parent([r1]).TripAlias";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateInput");
				oInputPrintOne.TableInputsGoods.Columns["DateInput"].Expression = "Parent([r1]).DateInput";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirm");
				oInputPrintOne.TableInputsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oInputPrintOne.TableInputsGoods.Columns.Add("PartnersNames");
				oInputPrintOne.TableInputsGoods.Columns["PartnersNames"].Expression = "Parent([r1]).PartnersNames";
				oInputPrintOne.TableInputsGoods.Columns.Add("InputsDocumentsNotes");
				oInputPrintOne.TableInputsGoods.Columns["InputsDocumentsNotes"].Expression = "Parent([r1]).InputsDocumentsNotes";
				oInputPrintOne.TableInputsGoods.Columns.Add("Note");
				oInputPrintOne.TableInputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

				oInputPrintOne.TableInputsGoods.Columns.Add("DateInputText");
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oInputPrintOne.TableInputsGoods.Rows)
				{
					rr["DateInputText"] = rr["DateInput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
				}

				dt = oInputPrintOne.TableInputsGoods;
				rep = new InputBill();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion InputBill

		#region InputBillWithAct

		public static void InputBillWithAct_Print(Input oInputPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputBillWithAct_Print(oInputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputBillWithAct_Print(Input oInputPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputBillWithAct_Print(oInputPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void InputBillWithAct_Print(Input oInputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputPrint.ID.HasValue && oInputPrint.IDList == null)
				return;

			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на приход...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на приход...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oInputPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной приход 
				Input oInputPrintOne = new Input();

				oInputPrintOne.ID = (int)r["ID"];
				oInputPrintOne.FillData();
				if (oInputPrintOne.MainTable == null || oInputPrintOne.MainTable.Rows.Count == 0)
					continue;
				oInputPrintOne.FillOne(oInputPrintOne.MainTable.Rows[0]);

				if (oInputPrintOne.ActsExists)
				{
					Act oActTemp = new Act();
					oActTemp.FilterInputsList = oInputPrintOne.ID.ToString();
					oActTemp.FillData();
					if (oActTemp.ErrorNumber == 0 && oActTemp.MainTable != null && oActTemp.MainTable.Rows.Count > 0)
					{
						string sActsText = "";
						foreach (DataRow a in oActTemp.MainTable.Rows)
						{
							sActsText += ", № " + a["ID"].ToString() + " от " + ((DateTime)a["DateAct"]).ToString("dd.MM.yyyy");
						}
						if (sActsText.Substring(0, 1) == ",")
						{
							sActsText = sActsText.Substring(1); 
						}
						sActsText = ((oActTemp.MainTable.Rows.Count > 1) ? "АКТЫ " : "АКТ ") + sActsText.Trim();
						string sNote = oInputPrintOne.MainTable.Rows[0]["Note"].ToString(); 
						oInputPrintOne.MainTable.Rows[0]["Note"] = sActsText + ((sNote.Length > 0) ? "; " : "") + sNote; 
					}
				}

				// таблица товаров для задания 
				oInputPrintOne.FillTableInputsGoodsWithActs();

				// добавляем поля шапки в таблицу товаров 
				oInputPrintOne.DS.Relations.Add("r1", oInputPrintOne.MainTable.Columns["InputID"],
					oInputPrintOne.TableInputsGoods.Columns["InputID"]);

				oInputPrintOne.TableInputsGoods.Columns.Add("InputTypeName");
				oInputPrintOne.TableInputsGoods.Columns["InputTypeName"].Expression = "Parent([r1]).InputTypeName";
				oInputPrintOne.TableInputsGoods.Columns.Add("InputGoodStateName");
				oInputPrintOne.TableInputsGoods.Columns["InputGoodStateName"].Expression = "Parent([r1]).GoodStateName";
				oInputPrintOne.TableInputsGoods.Columns.Add("PartnerName");
				oInputPrintOne.TableInputsGoods.Columns["PartnerName"].Expression = "Parent([r1]).PartnerName";
				oInputPrintOne.TableInputsGoods.Columns.Add("OwnerName");
				oInputPrintOne.TableInputsGoods.Columns["OwnerName"].Expression = "Parent([r1]).OwnerName";
				oInputPrintOne.TableInputsGoods.Columns.Add("TripAlias");
				oInputPrintOne.TableInputsGoods.Columns["TripAlias"].Expression = "Parent([r1]).TripAlias";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateInput");
				oInputPrintOne.TableInputsGoods.Columns["DateInput"].Expression = "Parent([r1]).DateInput";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirm");
				oInputPrintOne.TableInputsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oInputPrintOne.TableInputsGoods.Columns.Add("PartnersNames");
				oInputPrintOne.TableInputsGoods.Columns["PartnersNames"].Expression = "Parent([r1]).PartnersNames";
				oInputPrintOne.TableInputsGoods.Columns.Add("InputsDocumentsNotes");
				oInputPrintOne.TableInputsGoods.Columns["InputsDocumentsNotes"].Expression = "Parent([r1]).InputsDocumentsNotes";
				oInputPrintOne.TableInputsGoods.Columns.Add("Note");
				oInputPrintOne.TableInputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

				oInputPrintOne.TableInputsGoods.Columns.Add("DateInputText");
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oInputPrintOne.TableInputsGoods.Rows)
				{
					rr["DateInputText"] = rr["DateInput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
				}

				dt = oInputPrintOne.TableInputsGoods;
				rep = new InputBill();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion InputBillWithAct

		#region InputBillMX1

		public static void InputBillMX1_Print(Input oInputPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputBillMX1_Print(oInputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputBillMX1_Print(Input oInputPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputBillMX1_Print(oInputPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void InputBillMX1_Print(Input oInputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputPrint.ID.HasValue && oInputPrint.IDList == null)
				return;

			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на приход...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на приход...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

            // Признак вызова формы выбора Хранителя и Поклажедателя
            bool isFormGetNames = false;
            string sPayer = "", sPayee = "", sWe = "";

			foreach (DataRow r in oInputPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной приход 
				Input oInputPrintOne = new Input();

				oInputPrintOne.ID = (int)r["ID"];
				oInputPrintOne.FillData();
				if (oInputPrintOne.MainTable == null || oInputPrintOne.MainTable.Rows.Count == 0)
					continue;
				oInputPrintOne.FillOne(oInputPrintOne.MainTable.Rows[0]);

				// таблица товаров для задания 
				oInputPrintOne.FillBillTableInputsGoods((int)oInputPrintOne.ID);
                if (oInputPrintOne.TableInputsGoods.Rows.Count == 0) continue;

                // Изменение от 19.12.2011
                // Даем возможность замены полных имен хранителя и поклажедателя
                // Предлагаем на выбор два поля из oInputPrintOne.TableInputsGoods,
                // а также полученную из установок системы (таблица _Settings) строку
                // с юр. названием компании и адресом склада
                Report oReport = new Report();

                // Однократный для всех приходов выбор Хранителя и Поклажедателя
                if (!isFormGetNames)
                {
                    sPayer = oInputPrintOne.TableInputsGoods.Rows[0]["PayerNameAddress"].ToString();
                    sPayee = oInputPrintOne.TableInputsGoods.Rows[0]["PayeeNameAddress"].ToString();
                    sWe = oReport.Report_GetWeNameStorageAddress();

                    // Если все три названия совпадают, оставляем значения по умолчанию
                    if (sPayer != sPayee || sPayer != sWe || sPayee != sWe)
                    {
                        DataTable dtCompanies = new DataTable("Companies");
                        dtCompanies.Columns.Add("Name", typeof(string));
                        dtCompanies.Columns.Add("IsPayer", typeof(bool));
                        dtCompanies.Columns.Add("IsPayee", typeof(bool));

                        // Payer
                        dtCompanies.Rows.Add();
                        DataRow dr0 = dtCompanies.Rows[0];
                        dr0[0] = sPayer;
                        dr0[1] = false;
                        dr0[2] = false;

                        // Payee
                        if (sPayer != sPayee)
                        {
                            dtCompanies.Rows.Add();
                            DataRow dr1 = dtCompanies.Rows[dtCompanies.Rows.Count - 1];
                            dr1[0] = sPayee;
                            dr1[1] = false;
                            dr1[2] = false;
                        }

                        // We
                        if (sWe != sPayer && sWe != sPayee)
                        {
                            dtCompanies.Rows.Add();
                            DataRow dr2 = dtCompanies.Rows[dtCompanies.Rows.Count - 1];
                            dr2[0] = sWe;
                            dr2[1] = false;
                            dr2[2] = false;
                        }

                        // Выбор значений шапки
                        isFormGetNames = true;
                        if (thisForm.StartForm(new frmGetMXNames(dtCompanies)) != DialogResult.Yes)
                            return;

                        // Получение и замена значений
                        sPayer = sPayee = "";
                        foreach (DataRow dr in dtCompanies.Rows)
                        {
                            if ((bool)dr[1] == true)
                                sPayer = dr[0].ToString();
                            if ((bool)dr[2] == true)
                                sPayee = dr[0].ToString();
                        }
                    }
                }

                foreach (DataRow dr in oInputPrintOne.TableInputsGoods.Rows)
                {
                    dr["PayerNameAddress"] = sPayer;
                    dr["PayeeNameAddress"] = sPayee;
                }
                // Изменение от 19.12.2011 (конец)

                // добавляем поля шапки в таблицу товаров 
				oInputPrintOne.DS.Relations.Add("r1", oInputPrintOne.MainTable.Columns["InputID"],
					oInputPrintOne.TableInputsGoods.Columns["InputID"]);

				oInputPrintOne.TableInputsGoods.Columns.Add("DateInput");
				oInputPrintOne.TableInputsGoods.Columns["DateInput"].Expression = "Parent([r1]).DateInput";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirm");
				oInputPrintOne.TableInputsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oInputPrintOne.TableInputsGoods.Columns.Add("Note");
				oInputPrintOne.TableInputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

				oInputPrintOne.TableInputsGoods.Columns.Add("DateInputText");
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oInputPrintOne.TableInputsGoods.Rows)
				{
					rr["DateInputText"] = rr["DateInput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
				}

				dt = oInputPrintOne.TableInputsGoods;
				rep = new billMX1();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion InputBillMX1

        #region InputReturnBill

        public static void InputReturnBill_Print(Input oInputPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputReturnBill_Print(oInputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputReturnBill_Print(Input oInputPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputReturnBill_Print(oInputPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void InputReturnBill_Print(Input oInputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oInputPrint.ID.HasValue && oInputPrint.IDList == null)
				return;

			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на приход...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на приход...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oInputPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной приход 
				Input oInputPrintOne = new Input();

				oInputPrintOne.ID = (int)r["ID"];
				oInputPrintOne.FillData();
				if (oInputPrintOne.MainTable == null || oInputPrintOne.MainTable.Rows.Count == 0)
					continue;
				oInputPrintOne.FillOne(oInputPrintOne.MainTable.Rows[0]);

				// таблица товаров для задания 
				oInputPrintOne.FillBillTableInputsGoods((int)oInputPrintOne.ID);

				// добавляем поля шапки в таблицу товаров 
				oInputPrintOne.DS.Relations.Add("r1", oInputPrintOne.MainTable.Columns["InputID"],
					oInputPrintOne.TableInputsGoods.Columns["InputID"]);

				oInputPrintOne.TableInputsGoods.Columns.Add("InputTypeName");
				oInputPrintOne.TableInputsGoods.Columns["InputTypeName"].Expression = "Parent([r1]).InputTypeName";
				oInputPrintOne.TableInputsGoods.Columns.Add("InputGoodStateName");
				oInputPrintOne.TableInputsGoods.Columns["InputGoodStateName"].Expression = "Parent([r1]).GoodStateName";
				oInputPrintOne.TableInputsGoods.Columns.Add("PartnerName");
				oInputPrintOne.TableInputsGoods.Columns["PartnerName"].Expression = "Parent([r1]).PartnerName";
				oInputPrintOne.TableInputsGoods.Columns.Add("OwnerName");
				oInputPrintOne.TableInputsGoods.Columns["OwnerName"].Expression = "Parent([r1]).OwnerName";
				oInputPrintOne.TableInputsGoods.Columns.Add("TripAlias");
				oInputPrintOne.TableInputsGoods.Columns["TripAlias"].Expression = "Parent([r1]).TripAlias";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateInput");
				oInputPrintOne.TableInputsGoods.Columns["DateInput"].Expression = "Parent([r1]).DateInput";
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirm");
				oInputPrintOne.TableInputsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oInputPrintOne.TableInputsGoods.Columns.Add("PartnersNames");
				oInputPrintOne.TableInputsGoods.Columns["PartnersNames"].Expression = "Parent([r1]).PartnersNames";
				oInputPrintOne.TableInputsGoods.Columns.Add("InputsDocumentsNotes");
				oInputPrintOne.TableInputsGoods.Columns["InputsDocumentsNotes"].Expression = "Parent([r1]).InputsDocumentsNotes";
				oInputPrintOne.TableInputsGoods.Columns.Add("Note");
				oInputPrintOne.TableInputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

				oInputPrintOne.TableInputsGoods.Columns.Add("DateInputText");
				oInputPrintOne.TableInputsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oInputPrintOne.TableInputsGoods.Rows)
				{
					rr["DateInputText"] = rr["DateInput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
				}

				dt = oInputPrintOne.TableInputsGoods;
				rep = new billReturn();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion InputReverceBill

		#region InputWarrant

		public static void InputWarrant_Print(Input oInputPrint,
			RFMFormChild thisForm, 
			bool bNoAsk)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			InputWarrant_Print(oInputPrint, thisForm, bNoAsk, 
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void InputWarrant_Print(Input oInputPrint,
			RFMFormChild thisForm,
			bool bNoAsk, 
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			InputWarrant_Print(oInputPrint, thisForm, bNoAsk,  
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void InputWarrant_Print(Input oInputPrint,
			RFMFormChild thisForm,
			bool bNoAsk, 
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
			int nCopiesCnt)
		{
			if (!oInputPrint.ID.HasValue && oInputPrint.IDList == null)
				return;

			DataTable dt;

			// таблица по всем заданиям
			if (oInputPrint.ID.HasValue)
			{
				// одно задание
				oInputPrint.ReFillOne((int)oInputPrint.ID);
				if (!oInputPrint.PF_WarrantNeed)
				{
					/*
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Доверенность не требуется...");
						return;
					}
					*/

					if (bNoAsk)
						return;

					if (RFMMessage.MessageBoxYesNo("Задание на приход не требует формирования доверенности на получение товара.\n\n" +
						"Все-таки сформировать доверенность на получение товара?") != DialogResult.Yes)
						return;
				}

				if (oInputPrint.PF_WarrantNeed)
				{
					if (oInputPrint.WarrantNumber == null || oInputPrint.WarrantNumber.Length == 0)
					{
						// получаем очередной номер доверенности и записываем его в журнал
						oInputPrint.WarrantSet((int)oInputPrint.ID, null);
					}
					else
					{
						WarrantNumber oWarrant = new WarrantNumber();
						oWarrant.Update(null, null, (int)oInputPrint.ID);
					}
				}

				oInputPrint.FillWarrantTableInputs(oInputPrint.ID.ToString());
				if (oInputPrint.ErrorNumber != 0 ||
					!oInputPrint.DS.Tables.Contains("TableWarrantInputs") ||
					oInputPrint.DS.Tables["TableWarrantInputs"] == null)
					return;
				if (oInputPrint.DS.Tables["TableWarrantInputs"].Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Нет данных по доверенности...");
					}
					return;
				}
				dt = oInputPrint.DS.Tables["TableWarrantInputs"];
			}
			else
			{
				oInputPrint.FillData();
				if (oInputPrint.ErrorNumber != 0)
					return;

				string sInputsList = oInputPrint.IDList;
				if (sInputsList == null)
				{
					foreach (DataRow r in oInputPrint.MainTable.Rows)
					{
						if ((bool)r["PF_WarrantNeed"])
						{
							sInputsList += r["ID"].ToString().Trim() + ",";
						}
					}
				}

				// проставить номера доверенностей
				Input oInputPrintOne = new Input();
				foreach (DataRow r in oInputPrint.MainTable.Rows)
				{
					oInputPrintOne.FillOne(r);
					if (oInputPrintOne.PF_WarrantNeed)
					{
						if (oInputPrintOne.WarrantNumber == null || oInputPrintOne.WarrantNumber.Length == 0)
						{
							// получаем очередной номер доверенности
							oInputPrintOne.WarrantSet((int)oInputPrintOne.ID, null);
						}
						else
						{
							WarrantNumber oWarrant = new WarrantNumber();
							oWarrant.Update(null, null, (int)oInputPrintOne.ID);
						}
					}
				}

				oInputPrint.FillWarrantTableInputs(sInputsList);
				dt = thisForm.CopyTable(oInputPrint.DS.Tables["TableWarrantInputs"], "dt", "", "");
				dt.PrimaryKey = null;
				if (dt.Rows.Count == 0)
				{
					if (!bToArrayList)
					{
						RFMMessage.MessageBoxInfo("Нет данных по доверенностям...");
					}
					return;
				}
			}

			ActiveReport3 rep = new warrant();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
		}

		#endregion InputWarrant

		#endregion Input

		#region Output

		#region OutputBill

		public static void OutputBill_Print(Output oOutputPrint,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputBill_Print(oOutputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputBill_Print(Output oOutputPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputBill_Print(oOutputPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void OutputBill_Print(Output oOutputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputPrint.ID.HasValue && oOutputPrint.IDList == null)
				return;

			oOutputPrint.FillData();
			if (oOutputPrint.ErrorNumber != 0 || oOutputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на расход...");
				return;
			}
			if (oOutputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на расход...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oOutputPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной расход 
				Output oOutputPrintOne = new Output();

				oOutputPrintOne.ID = (int)r["ID"];
				oOutputPrintOne.FillData();
				if (oOutputPrintOne.MainTable == null || oOutputPrintOne.MainTable.Rows.Count == 0)
					continue;
				oOutputPrintOne.FillOne(oOutputPrintOne.MainTable.Rows[0]);

				// таблица товаров для задания 
				oOutputPrintOne.FillTableOutputsGoods();

				// Внимание! в документе печатаем только одну цифру - либо Wished, либо Confirmed в зависимости от состояния задания
				if (oOutputPrintOne.IsConfirmed)
				{
					foreach (DataRow rr in oOutputPrintOne.TableOutputsGoods.Rows)
					{
						rr["QntWished"] = rr["QntConfirmed"];
						rr["BoxWished"] = rr["BoxConfirmed"];
						rr["PalWished"] = rr["PalConfirmed"];
					}
				}

				// добавляем поля шапки в таблицу товаров 
				oOutputPrintOne.DS.Relations.Add("r1", oOutputPrintOne.MainTable.Columns["OutputID"],
					oOutputPrintOne.TableOutputsGoods.Columns["OutputID"]);

				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputBarCode");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputBarCode"].Expression = "Parent([r1]).BarCode";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputTypeName");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputTypeName"].Expression = "Parent([r1]).OutputTypeName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputGoodStateName");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputGoodStateName"].Expression = "Parent([r1]).GoodStateName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("PartnerName");
				oOutputPrintOne.TableOutputsGoods.Columns["PartnerName"].Expression = "Parent([r1]).PartnerName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OwnerName");
				oOutputPrintOne.TableOutputsGoods.Columns["OwnerName"].Expression = "Parent([r1]).OwnerName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("TripAlias");
				oOutputPrintOne.TableOutputsGoods.Columns["TripAlias"].Expression = "Parent([r1]).TripAlias";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateOutput");
				oOutputPrintOne.TableOutputsGoods.Columns["DateOutput"].Expression = "Parent([r1]).DateOutput";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateConfirm");
				oOutputPrintOne.TableOutputsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("PartnersNames");
				oOutputPrintOne.TableOutputsGoods.Columns["PartnersNames"].Expression = "Parent([r1]).PartnersNames";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputsDocumentsNotes");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputsDocumentsNotes"].Expression = "Parent([r1]).OutputsDocumentsNotes";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("Note");
				oOutputPrintOne.TableOutputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("IsCarried");
				oOutputPrintOne.TableOutputsGoods.Columns["IsCarried"].Expression = "Parent([r1]).IsCarried";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("CopiedFromOutputID");
				oOutputPrintOne.TableOutputsGoods.Columns["CopiedFromOutputID"].Expression = "Parent([r1]).CopiedFromOutputID";

				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateOutputText");
				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oOutputPrintOne.TableOutputsGoods.Rows)
				{
					rr["DateOutputText"] = rr["DateOutput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + ((DateTime)r["DateConfirm"]).ToString("dd.MM.yyyy HH:mm");
				}

				dt = oOutputPrintOne.TableOutputsGoods;
				rep = new OutputBill();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion OutputBill

		#region OutputBillWithAct

		public static void OutputBillWithAct_Print(Output oOutputPrint,
		RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputBillWithAct_Print(oOutputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputBillWithAct_Print(Output oOutputPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputBillWithAct_Print(oOutputPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void OutputBillWithAct_Print(Output oOutputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputPrint.ID.HasValue && oOutputPrint.IDList == null)
				return;

			oOutputPrint.FillData();
			if (oOutputPrint.ErrorNumber != 0 || oOutputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на расход...");
				return;
			}
			if (oOutputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на расход...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oOutputPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной расход 
				Output oOutputPrintOne = new Output();

				oOutputPrintOne.ID = (int)r["ID"];
				oOutputPrintOne.FillData();
				if (oOutputPrintOne.MainTable == null || oOutputPrintOne.MainTable.Rows.Count == 0)
					continue;
				oOutputPrintOne.FillOne(oOutputPrintOne.MainTable.Rows[0]);

				if (oOutputPrintOne.ActsExists)
				{
					oOutputPrintOne.MainTable.Rows[0]["Note"] = "АКТ; " + oOutputPrintOne.MainTable.Rows[0]["Note"]; 
				}

				// таблица товаров для задания 
				oOutputPrintOne.FillTableOutputsGoodsWithActs();

				// Внимание! в документе печатаем только одну цифру - либо Wished, либо Confirmed в зависимости от состояния задания
				if (oOutputPrintOne.IsConfirmed)
				{
					foreach (DataRow rr in oOutputPrintOne.TableOutputsGoods.Rows)
					{
						rr["QntWished"] = rr["QntConfirmed"];
						rr["BoxWished"] = rr["BoxConfirmed"];
						rr["PalWished"] = rr["PalConfirmed"];
					}
				}

				// добавляем поля шапки в таблицу товаров 
				oOutputPrintOne.DS.Relations.Add("r1", oOutputPrintOne.MainTable.Columns["OutputID"],
					oOutputPrintOne.TableOutputsGoods.Columns["OutputID"]);

				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputTypeName");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputTypeName"].Expression = "Parent([r1]).OutputTypeName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputGoodStateName");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputGoodStateName"].Expression = "Parent([r1]).GoodStateName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("PartnerName");
				oOutputPrintOne.TableOutputsGoods.Columns["PartnerName"].Expression = "Parent([r1]).PartnerName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OwnerName");
				oOutputPrintOne.TableOutputsGoods.Columns["OwnerName"].Expression = "Parent([r1]).OwnerName";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("TripAlias");
				oOutputPrintOne.TableOutputsGoods.Columns["TripAlias"].Expression = "Parent([r1]).TripAlias";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateOutput");
				oOutputPrintOne.TableOutputsGoods.Columns["DateOutput"].Expression = "Parent([r1]).DateOutput";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateConfirm");
				oOutputPrintOne.TableOutputsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("PartnersNames");
				oOutputPrintOne.TableOutputsGoods.Columns["PartnersNames"].Expression = "Parent([r1]).PartnersNames";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("OutputsDocumentsNotes");
				oOutputPrintOne.TableOutputsGoods.Columns["OutputsDocumentsNotes"].Expression = "Parent([r1]).OutputsDocumentsNotes";
				oOutputPrintOne.TableOutputsGoods.Columns.Add("Note");
				oOutputPrintOne.TableOutputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateOutputText");
				oOutputPrintOne.TableOutputsGoods.Columns.Add("DateConfirmText");
				foreach (DataRow rr in oOutputPrintOne.TableOutputsGoods.Rows)
				{
					rr["DateOutputText"] = rr["DateOutput"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
				}

				dt = oOutputPrintOne.TableOutputsGoods;
				rep = new OutputBill();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion OutputBillWithAct

		#region Ttn

		public static void OutputTtn_Print(Output oOutputPrint,
				RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			OutputTtn_Print(oOutputPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void OutputTtn_Print(Output oOutputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			OutputTtn_Print(oOutputPrint, thisForm,
				true, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void OutputTtn_Print(Output oOutputPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oOutputPrint.ID.HasValue)
				return;

			oOutputPrint.ReFillOne((int)oOutputPrint.ID);

			if (!oOutputPrint.OwnerID.HasValue)
			{
				RFMMessage.MessageBoxError("Для расхода не определен владелец товара...");
				return;
			}
			if (!oOutputPrint.PartnerID.HasValue)
			{
				RFMMessage.MessageBoxError("Для расхода не определен получатель...");
				return;
			}

			// для расхода нет документов?
			OutputDocument oOutputDocumentTemp = new OutputDocument(); 
			oOutputDocumentTemp.FilterOutputsList = oOutputPrint.ID.ToString();
			oOutputDocumentTemp.FillData();
			if (oOutputDocumentTemp.ErrorNumber != 0 || oOutputDocumentTemp.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при проверке наличия расходных документов для расхода...");
				return;
			}
			if (oOutputDocumentTemp.MainTable.Rows.Count > 0)
			{
				RFMMessage.MessageBoxError("Для расхода существуют расходные документы.\n" + 
					"ТТН для расхода не формируется.");
				return;
			}

			// есть ли еще расходы того же поставщика и получателя в том же рейсе или без рейса
			DateTime dDateOutput = oOutputPrint.DateOutput;
			int nOwnerID = (int)oOutputPrint.OwnerID;
			int nPartnerID = (int)oOutputPrint.PartnerID;
			int? nTripID = oOutputPrint.TripID;

			Output oOutputTemp = new Output();
			oOutputTemp.FilterDateBeg = dDateOutput;
			oOutputTemp.FilterDateEnd = dDateOutput;
			oOutputTemp.FilterOwnersList = nOwnerID.ToString();
			oOutputTemp.FilterPartnersList = nPartnerID.ToString();
			if (nTripID.HasValue)
			{
				oOutputTemp.FilterTripsList = nTripID.ToString();
			}
			else
			{
				oOutputTemp.FilterTripExists = false;
			}
			oOutputTemp.FillData();
			if (oOutputTemp.ErrorNumber != 0 || oOutputTemp.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при проверке наличия расходных документов для расхода...");
				return;
			}
			string sList = "";
			if (oOutputTemp.MainTable.Rows.Count > 1)
			{
				// только те, что без документов
				foreach (DataRow o in oOutputTemp.MainTable.Rows)
				{
					if ((int)o["ID"] != (int)oOutputPrint.ID)
					{
						oOutputDocumentTemp.FilterOutputsList = o["ID"].ToString();
						oOutputDocumentTemp.FillData();
						if (oOutputDocumentTemp.ErrorNumber != 0 || oOutputDocumentTemp.MainTable == null)
						{
							RFMMessage.MessageBoxError("Ошибка при проверке наличия расходных документов для аналогичных расходов...");
							return;
						}
						if (oOutputDocumentTemp.MainTable.Rows.Count == 0)
						{
							sList += o["ID"].ToString() + ",";
						}
					}
				}
				if (sList.Length > 0)
				{
					oOutputTemp.IDList = sList;
					oOutputTemp.FillData();
					if (oOutputTemp.ErrorNumber != 0 || oOutputPrint.MainTable == null)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных для аналогичных расходов...");
						return;
					}
					if (oOutputTemp.MainTable.Rows.Count > 0)
					{
						string sText = "Существует еще " + RFMUtilities.Declen(oOutputTemp.MainTable.Rows.Count, "расход", "расхода", "расходов") +
							" для того же владельца и получателя, " +
							((nTripID.HasValue) ? "включенных в тот же рейс" : "не включенных в рейс") + ".\n" +
							"Включить данные этих расходов в ТТН?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						{
							sList = ""; 
						}
					}
				}
			}
			sList += oOutputPrint.ID.ToString();

			// данные для ТТН 
			oOutputPrint.FillTTNTableOutputs(sList);
			if (oOutputPrint.ErrorNumber != 0 || 
				!oOutputPrint.DS.Tables.Contains("TableOutputsTTN") || 
				oOutputPrint.DS.Tables["TableOutputsTTN"] == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о товарах в расходе для построения ТТН...");
				return;
			}

			thisForm.StartForm(new frmOutputsDocumentsTTNData(oOutputPrint.DS.Tables["TableOutputsTTN"]));
			/*
			ActiveReport3 rep = new TtnOneLine();
			if (bToArrayList)
			{
				// только сохраняем в массивы
				_aDataTables.Add(dt);
				_aReps.Add(rep);
				_aCopiesCnt.Add(nCopiesCnt);
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(dt, rep));
			}
			*/ 
		}

		#endregion Ttn

        #region OutputBillM15

        public static void OutputBillM15_Print(Output oOutputPrint,
            RFMFormChild thisForm)
        {
            ArrayList aTemp1 = new ArrayList();
            ArrayList aTemp2 = new ArrayList();
            ArrayList aTemp3 = new ArrayList();
            OutputBillM15_Print(oOutputPrint, thisForm,
                false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
        }

        public static void OutputBillM15_Print(Output oOutputPrint,
            RFMFormChild thisForm,
            bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
        {
            ArrayList aTemp3 = new ArrayList();
            OutputBillM15_Print(oOutputPrint, thisForm,
                bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
                1);
        }

        public static void OutputBillM15_Print(Output oOutputPrint,
                RFMFormChild thisForm,
                bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
                int nCopiesCnt)
        {
            if (!oOutputPrint.ID.HasValue && oOutputPrint.IDList == null)
                return;

            oOutputPrint.FillData();
            if (oOutputPrint.ErrorNumber != 0 || oOutputPrint.MainTable == null)
            {
                RFMMessage.MessageBoxInfo("Ошибка при получении списка заданий на расход...");
                return;
            }
            if (oOutputPrint.MainTable.Rows.Count == 0)
            {
                RFMMessage.MessageBoxInfo("Нет данных по товарам в заданиях на расход...");
                return;
            }

            DataTable dt;
            ActiveReport3 rep;

            ArrayList a_dt = new ArrayList();
            ArrayList a_rep = new ArrayList();
            ArrayList a_cnt = new ArrayList();

            foreach (DataRow r in oOutputPrint.MainTable.Rows)
            {
                rep = null;
                dt = null;

                // очередной расход 
                Output oOutputPrintOne = new Output();

                oOutputPrintOne.ID = (int)r["ID"];
                oOutputPrintOne.FillData();
                if (oOutputPrintOne.MainTable == null || oOutputPrintOne.MainTable.Rows.Count == 0)
                    continue;
                oOutputPrintOne.FillOne(oOutputPrintOne.MainTable.Rows[0]);

                // таблица товаров для задания 
                oOutputPrintOne.FillTableOutputsGoods();

                // Внимание! в документе печатаем только одну цифру - либо Wished, либо Confirmed в зависимости от состояния задания
                if (oOutputPrintOne.IsConfirmed)
                {
                    foreach (DataRow rr in oOutputPrintOne.TableOutputsGoods.Rows)
                    {
                        rr["QntWished"] = rr["QntConfirmed"];
                        rr["BoxWished"] = rr["BoxConfirmed"];
                        rr["PalWished"] = rr["PalConfirmed"];
                    }
                }

                // добавляем поля шапки в таблицу товаров 
                oOutputPrintOne.DS.Relations.Add("r1", oOutputPrintOne.MainTable.Columns["OutputID"],
                    oOutputPrintOne.TableOutputsGoods.Columns["OutputID"]);

                oOutputPrintOne.TableOutputsGoods.Columns.Add("DateOutput");
                oOutputPrintOne.TableOutputsGoods.Columns["DateOutput"].Expression = "Parent([r1]).DateOutput";
                oOutputPrintOne.TableOutputsGoods.Columns.Add("PartnerName");
                oOutputPrintOne.TableOutputsGoods.Columns["PartnerName"].Expression = "Parent([r1]).DefaultPartnerLegalName";
                oOutputPrintOne.TableOutputsGoods.Columns.Add("OwnerName");
                oOutputPrintOne.TableOutputsGoods.Columns["OwnerName"].Expression = "Parent([r1]).DefaultOwnerLegalName";
                oOutputPrintOne.TableOutputsGoods.Columns.Add("Note");
                oOutputPrintOne.TableOutputsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

                oOutputPrintOne.TableOutputsGoods.Columns.Add("DateOutputText");
                foreach (DataRow rr in oOutputPrintOne.TableOutputsGoods.Rows)
                {
                    rr["DateOutputText"] = rr["DateOutput"].ToString().Substring(0, 10);
                }

                dt = oOutputPrintOne.TableOutputsGoods;
                rep = new billM15();

                a_rep.Add(rep);
                a_dt.Add(dt);
                a_cnt.Add(nCopiesCnt);
            }

            if (a_dt.Count == 0)
            {
                RFMMessage.MessageBoxInfo("Нет данных...");
                return;
            }

            DataTable[] aDt = new DataTable[a_dt.Count];
            a_dt.CopyTo(aDt);

            ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
            a_rep.CopyTo(aRep);

            int[] aCnt = new int[a_dt.Count];
            a_cnt.CopyTo(aCnt);

            if (bToArrayList)
            {
                // только сохраняем в массивы, не печатаем!
                foreach (DataTable xDt in aDt)
                {
                    _aDataTables.Add(xDt);
                }
                foreach (ActiveReport3 xRep in aRep)
                {
                    _aReps.Add(xRep);
                }
                foreach (int xCnt in aCnt)
                {
                    _aCopiesCnt.Add(xCnt);
                }
            }
            else
            {
                // выводим и печатаем
                thisForm.StartForm(new frmActiveReport(aDt, aRep));
            }
        }

        #endregion OutputBillM15

		#endregion Output

		#region MovingDocument

		#region MovingDocumentBill

		public static void MovingDocumentBill_Print(MovingDocument oMovingDocumentPrint,
			RFMFormChild thisForm)
		{
			if (!oMovingDocumentPrint.ID.HasValue)
				return;

			oMovingDocumentPrint.FillData();
			if (oMovingDocumentPrint.ErrorNumber != 0 || 
				oMovingDocumentPrint.MainTable == null ||
				oMovingDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении документарного перемещения...");
				return;
			}
			oMovingDocumentPrint.FillTableMovingsDocumentsGoods();

			DataSet ds = new DataSet();
			ds.Tables.Add(oMovingDocumentPrint.TableMovingsDocumentsGoods.Copy());
			ds.Tables.Add(oMovingDocumentPrint.MainTable.Copy());
				
			thisForm.StartForm(new frmActiveReport(ds, new MovingDocumentBill()));
		}

		#endregion MovingDocumentBill

		#region MovingDocumentBillMX1

		public static void MovingDocumentBillMX1_Print(MovingDocument oMovingDocumentPrint,
			RFMFormChild thisForm)
		{
			if (!oMovingDocumentPrint.ID.HasValue && oMovingDocumentPrint.IDList == null)
				return;

			oMovingDocumentPrint.FillData();
			if (oMovingDocumentPrint.ErrorNumber != 0 || oMovingDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка документарных перемещений...");
				return;
			}
			if (oMovingDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных о документарных перемещениях...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oMovingDocumentPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной приход 
				MovingDocument oMovingDocumentPrintOne = new MovingDocument();

				oMovingDocumentPrintOne.ID = (int)r["ID"];
				oMovingDocumentPrintOne.FillData();
				if (oMovingDocumentPrintOne.MainTable == null || oMovingDocumentPrintOne.MainTable.Rows.Count == 0)
					continue;
				oMovingDocumentPrintOne.FillOne(oMovingDocumentPrintOne.MainTable.Rows[0]);

				// таблица товаров для задания 
				oMovingDocumentPrintOne.FillBillTableMovingsDocumentsGoods(oMovingDocumentPrintOne.ID.ToString());
				dt = oMovingDocumentPrintOne.TableMovingsDocumentsGoods;

				// добавляем поля шапки в таблицу товаров 
				oMovingDocumentPrintOne.DS.Relations.Add("r1", oMovingDocumentPrintOne.MainTable.Columns["MovingDocumentID"],
					oMovingDocumentPrintOne.TableMovingsDocumentsGoods.Columns["MovingDocumentID"]);

				dt.Columns.Add("InputID");
				dt.Columns["InputID"].Expression = "Parent([r1]).MovingDocumentID";
				dt.Columns.Add("DateInput");
				dt.Columns["DateInput"].Expression = "Parent([r1]).DateMoving";
				dt.Columns.Add("DateConfirm");
				dt.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				dt.Columns.Add("Note");
				dt.Columns["Note"].Expression = "Parent([r1]).Note";

				rep = new billMX1();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(1);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			thisForm.StartForm(new frmActiveReport(aDt, aRep));
		}

		#endregion MovingDocumentBillMX

		#region MovingDocumentBillMX3

		public static void MovingDocumentBillMX3_Print(MovingDocument oMovingDocumentPrint,
			RFMFormChild thisForm)
		{
			if (!oMovingDocumentPrint.ID.HasValue && oMovingDocumentPrint.IDList == null)
				return;

			oMovingDocumentPrint.FillData();
			if (oMovingDocumentPrint.ErrorNumber != 0 || oMovingDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка документарных перемещений...");
				return;
			}
			if (oMovingDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных о документарных перемещениях...");
				return;
			}

			// таблица товаров для задания (заданий)
			if (oMovingDocumentPrint.ID.HasValue) 
				oMovingDocumentPrint.FillBillTableMovingsDocumentsGoods(oMovingDocumentPrint.ID.ToString());
			else
				oMovingDocumentPrint.FillBillTableMovingsDocumentsGoods(oMovingDocumentPrint.IDList);

			DataTable dt = oMovingDocumentPrint.TableMovingsDocumentsGoods;

			// добавляем поля шапки в таблицу товаров 
			oMovingDocumentPrint.DS.Relations.Add("r1", oMovingDocumentPrint.MainTable.Columns["MovingDocumentID"],
				oMovingDocumentPrint.TableMovingsDocumentsGoods.Columns["MovingDocumentID"]);

			dt.Columns.Add("OutputID");
			dt.Columns["OutputID"].Expression = "Parent([r1]).MovingDocumentID";
			dt.Columns.Add("DateOutput");
			dt.Columns["DateOutput"].Expression = "Parent([r1]).DateMoving";
			dt.Columns.Add("DateConfirm");
			dt.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
			dt.Columns.Add("Note");
			dt.Columns["Note"].Expression = "Parent([r1]).Note";

			thisForm.StartForm(new frmActiveReport(dt, new billMX3()));
		}

		#endregion MovingDocumentBillMX3

		#endregion MovingDocument

		#region TripReturn

		#region TripReturn Print

		public static void TripReturnBill_Print(TripReturn oTripReturnPrint,
		RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			TripReturnBill_Print(oTripReturnPrint, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void TripReturnBill_Print(TripReturn oTripReturnPrint,
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			TripReturnBill_Print(oTripReturnPrint, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3,
				1);
		}

		public static void TripReturnBill_Print(TripReturn oTripReturnPrint,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
				int nCopiesCnt)
		{
			if (!oTripReturnPrint.ID.HasValue && oTripReturnPrint.IDList == null)
				return;

			oTripReturnPrint.FillData();
			if (oTripReturnPrint.ErrorNumber != 0 || oTripReturnPrint.MainTable == null)
			{
				RFMMessage.MessageBoxInfo("Ошибка при получении списка возвратов...");
				return;
			}
			if (oTripReturnPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных по товарам в возвратах...");
				return;
			}

			DataTable dt;
			ActiveReport3 rep;

			ArrayList a_dt = new ArrayList();
			ArrayList a_rep = new ArrayList();
			ArrayList a_cnt = new ArrayList();

			foreach (DataRow r in oTripReturnPrint.MainTable.Rows)
			{
				rep = null;
				dt = null;

				// очередной возврат
				TripReturn oTripReturnPrintOne = new TripReturn();

				oTripReturnPrintOne.ID = (int)r["ID"];
				oTripReturnPrintOne.FillData();

				// таблица товаров для документа
				oTripReturnPrintOne.FillTableTripsReturnsGoods();

				// Внимание! в документе печатаем только одну цифру - либо Wished, либо Confirmed в зависимости от состояния задания
				if (oTripReturnPrintOne.IsConfirmed)
				{
					foreach (DataRow rr in oTripReturnPrintOne.TableTripsReturnsGoods.Rows)
					{
						rr["QntWished"] = rr["QntConfirmed"];
						rr["BoxWished"] = rr["BoxConfirmed"];
						rr["PalWished"] = rr["PalConfirmed"];
					}
				}

				// добавляем поля шапки в таблицу товаров 
				oTripReturnPrintOne.DS.Relations.Add("r1", oTripReturnPrintOne.MainTable.Columns["TripReturnID"],
					oTripReturnPrintOne.TableTripsReturnsGoods.Columns["TripReturnID"]);

				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("TripReturnBarCode");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["TripReturnBarCode"].Expression = "Parent([r1]).BarCode";
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("TripReturnGoodStateName");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["TripReturnGoodStateName"].Expression = "Parent([r1]).GoodStateName";
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("OwnerName");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["OwnerName"].Expression = "Parent([r1]).OwnerName";
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("TripAlias");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["TripAlias"].Expression = "Parent([r1]).TripAlias";
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("DateReturn");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["DateReturn"].Expression = "Parent([r1]).DateReturn";
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("DateConfirm");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["DateConfirm"].Expression = "Parent([r1]).DateConfirm";
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("Note");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns["Note"].Expression = "Parent([r1]).Note";

				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("DateReturnText");
				oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("DateConfirmText");
                oTripReturnPrintOne.TableTripsReturnsGoods.Columns.Add("DateTripText");
                foreach (DataRow rr in oTripReturnPrintOne.TableTripsReturnsGoods.Rows)
				{
					rr["DateReturnText"] = rr["DateReturn"].ToString().Substring(0, 10);
					rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + r["DateConfirm"].ToString().Substring(0, 16);
                    rr["DateTripText"] = r["DateTrip"].ToString().Substring(0, 10);
                }

				dt = oTripReturnPrintOne.TableTripsReturnsGoods;
				rep = new TripReturnBill();

				a_rep.Add(rep);
				a_dt.Add(dt);
				a_cnt.Add(nCopiesCnt);
			}

			if (a_dt.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Нет данных...");
				return;
			}

			DataTable[] aDt = new DataTable[a_dt.Count];
			a_dt.CopyTo(aDt);

			ActiveReport3[] aRep = new ActiveReport3[a_dt.Count];
			a_rep.CopyTo(aRep);

			int[] aCnt = new int[a_dt.Count];
			a_cnt.CopyTo(aCnt);

			if (bToArrayList)
			{
				// только сохраняем в массивы, не печатаем!
				foreach (DataTable xDt in aDt)
				{
					_aDataTables.Add(xDt);
				}
				foreach (ActiveReport3 xRep in aRep)
				{
					_aReps.Add(xRep);
				}
				foreach (int xCnt in aCnt)
				{
					_aCopiesCnt.Add(xCnt);
				}
			}
			else
			{
				// выводим и печатаем
				thisForm.StartForm(new frmActiveReport(aDt, aRep));
			}
		}

		#endregion TripReturn Print

		#region TripReturn AutoCreate 

		public static bool TripReturn_AutoCreate(int nTripID,
			RFMFormChild thisForm)
		{
			Trip oTrip = new Trip();
			oTrip.ReFillOne(nTripID);

			// проверки
			if (oTrip.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Рейс уже подтвержден...");
				return (false);
			}
			if (!oTrip.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("Рейс еще не начат...");
				return (false);
			}
			if (!oTrip.ReadyForTripBeg.HasValue || !(bool)oTrip.ReadyForTripBeg)
			{
				RFMMessage.MessageBoxError("Рейс не готов к началу...");
				return (false);
			}

			if (oTrip.SelfDelivery)
			{
				RFMMessage.MessageBoxError("Для машины клиента возврат-недовоз не оформляется...");
				return (false);
			}

			if (!oTrip.CarID.HasValue &&
				(oTrip.CarNumber == null || oTrip.CarNumber.Length == 0))
			{
				RFMMessage.MessageBoxError("Машина не определена...");
				return (false);
			}

			if (oTrip.DateEnd.HasValue)
			{
				if (RFMMessage.MessageBoxYesNo("Рейс уже окончен...\nВсе-таки рассчитать возврат-недовоз?") != DialogResult.Yes) 
					return (false);
			}


			// ищем, м.б.уже есть авто-возврат
			TripReturn oTripReturn = new TripReturn();
			oTripReturn.FilterTripsList = nTripID.ToString();
			oTripReturn.FilterAutoCreated = true;
			oTripReturn.FillData();
			if (oTripReturn.ErrorNumber != 0 || oTripReturn.MainTable == null)
				return (false);

            bool bAsked = false;
 
			if (oTripReturn.MainTable.Rows.Count == 0)
			{
				// расход: для добавления авто-возврата д.б. все задания выполнены, все документы доставлены
				Output oOutputTR = new Output();
				oOutputTR.FilterTripsList = nTripID.ToString();
				oOutputTR.FillData();
				if (oOutputTR.ErrorNumber != 0 || oOutputTR.MainTable == null)
					return (false);

				if (oOutputTR.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет заданий на расход,\n" +
						"возврат-недовоз не может быть рассчитан автоматически.");
					return (false);
				}

				oOutputTR.FilterIsConfirmed = false;
				oOutputTR.FillData();
				if (oOutputTR.ErrorNumber != 0 || oOutputTR.MainTable == null)
					return (false);

				if (oOutputTR.MainTable.Rows.Count > 0)
				{
					RFMMessage.MessageBoxError("Не все задания на расход выполнены,\n" +
						"возврат-недовоз не может быть рассчитан автоматически.");
					return (false);
				}

				OutputDocument oOutputDocumentTR = new OutputDocument();
				oOutputDocumentTR.FilterTripsList = nTripID.ToString();
				oOutputDocumentTR.FilterIsBrought = false;
				oOutputDocumentTR.FillData();
				if (oOutputDocumentTR.ErrorNumber != 0 || oOutputDocumentTR.MainTable == null)
					return (false);

				if (oOutputDocumentTR.MainTable.Rows.Count > 0)
				{
					RFMMessage.MessageBoxError("Не все расходные документы доставлены получателю,\n" +
						"возврат-недовоз не может быть рассчитан автоматически.");
					return (false);
				}
			}
			else
			{
                for (int i = 0; i < oTripReturn.MainTable.Rows.Count; i++)
                {
                    DataRow dr = oTripReturn.MainTable.Rows[i];
                    if ((bool)dr["AutoCreated"] && dr["DateConfirm"] != DBNull.Value)
                    {
                        RFMMessage.MessageBoxAttention("Возврат-недовоз уже подтвержден,\n" +
                            "возврат-недовоз не может быть рассчитан автоматически.");
                        return (false);
                    }
                
                }
				if (RFMMessage.MessageBoxYesNo("Возврат-недовоз уже рассчитан.\n" + 
                    "Все-таки рассчитать заново?") != DialogResult.Yes) 
				    return (false);
                bAsked = true;
			}

			// нет автоматически созданных возвратов; можно создать
			if (bAsked || RFMMessage.MessageBoxYesNo("Рассчитать возврат-недовоз автоматически?") == DialogResult.Yes)
			{
				oTripReturn.ClearFilters();
				if (oTripReturn.AutoCreate(nTripID) && oTripReturn.ErrorNumber == 0)
				{
					oTrip.ReFillOne(nTripID);

					if (oTrip.IsTripReturnAutoAttached)
					{
						oTripReturn.ClearFilters();
						oTripReturn.FilterTripsList = nTripID.ToString();
						oTripReturn.FilterAutoCreated = true;
						oTripReturn.FillData();
						if (oTripReturn.ErrorNumber == 0 && oTripReturn.MainTable != null)
						{
							if (oTripReturn.MainTable.Rows.Count == 0)
							{
								RFMMessage.MessageBoxError("Не найден автоматически рассчитанный возврат-недовоз...");
								return (false); 
							}
							for (int i = 0; i < oTripReturn.MainTable.Rows.Count; i++)
							{
								int nTripReturnID = (int)oTripReturn.MainTable.Rows[i]["ID"];

								if (!Convert.ToBoolean(oTripReturn.MainTable.Rows[i]["IsConfirmed"]))
								{
									thisForm.StartForm(new frmTripsReturnsEdit(nTripReturnID, nTripID));
								}
								else
								{
									RFMMessage.MessageBoxInfo("Автоматически рассчитанный возврат-недовоз уже подтвержден.");
									return (false);
								}
							}
						}
					}
					else
					{
						RFMMessage.MessageBoxInfo("Нет данных для автоматического расчета возврата-недовоза\n(нечего возвращать).");
						//oTrip.ReFillOne(nTripID);
						return (false);
					}

					// проставить время окончания рейса
					/*
					if (!oTrip.DateEnd.HasValue &&
						oTrip.ReadyForTripEnd.HasValue && (bool)oTrip.ReadyForTripEnd)
					{
						oTrip.SetDateTime(nTripID, "END", "FACT", DateTime.Now, null);
					}
					*/
				}
			}
			else
			{
				return (false);
			}
			return (true);
		}

		#endregion TripReturn AutoCreate 

		#endregion TripReturn

		#region Pass

		#region Pass Create

		public static void PassCreateForTrip(int nTripID)
		{
			Trip oTrip = new Trip();
			oTrip.ReFillOne(nTripID);
			if (oTrip.ErrorNumber != 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о рейсе [создание пропуска]...");
				return;
			}

			// проверки 
			if (oTrip.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Рейс уже подтвержден...");
				return;
			}
			if (oTrip.CarID.HasValue)
			{
				RFMMessage.MessageBoxError("Для своих машин оформление пропуска не требуется...");
				return;
			}
			if (oTrip.CarNumber.Length == 0 || oTrip.DriverName.Length == 0)
			{
				RFMMessage.MessageBoxError("Не указана машина/водитель...");
				return;
			}
			if (oTrip.DateEnd.HasValue)
			{
				RFMMessage.MessageBoxError("Рейс уже окончен...");
				return;
			}
			if (oTrip.ReadyForTripEnd.HasValue && (bool)oTrip.ReadyForTripEnd)
			{
				RFMMessage.MessageBoxError("Рейс уже готов к окончанию...");
				return;
			}
			//

			if (oTrip.PassID.HasValue)
			{
				if (RFMMessage.MessageBoxYesNo("Пропуск уже оформлен...\nРедактировать?") == DialogResult.Yes)
				{
					((RFMFormMain)Application.OpenForms[0]).StartForm(new frmPassesEdit((int)oTrip.PassID));
				}
				return;
			}

			// создаем новый пропуск
			Pass oPass = new Pass();
			oPass.DatePass = oTrip.DateTrip.Date;
			oPass.CarName = oTrip.CarName;
			oPass.CarTypeName = oTrip.CarTypeName;
			oPass.CarNumber = oTrip.CarNumber;
			oPass.TrailerNumber = oTrip.TrailerNumber;
			oPass.DriverName = oTrip.DriverName;
			oPass.DriverDocument = "";

			if (oPass.CarNumber == null || oPass.DriverName == "")
			{
				RFMMessage.MessageBoxError("Недостаточно данных для оформления пропуска...");
				return;
			}

			oPass.Reason = "";
			if (oTrip.SelfDelivery)
			{
				if (oTrip.IsOutputsDocumentsAttached)
				{
					oPass.Reason += ((oPass.Reason.Length > 0) ? " - " : "") + "самовывоз";
				}
				if (oTrip.IsInputsDocumentsAttached)
				{
					oPass.Reason += ((oPass.Reason.Length > 0) ? " - " : "") + "самопривоз";
				}
			}
			
			oPass.SaveOne(((RFMFormMain)Application.OpenForms[0]).UserID);
			if (oPass.ErrorNumber == 0)
			{
				if (oPass.ID.HasValue)
				{
					oTrip.ToPass((int)oPass.ID);
					if (oTrip.ErrorNumber == 0)
					{
						((RFMFormMain)Application.OpenForms[0]).StartForm(new frmPassesEdit((int)oPass.ID));
					}
				}
			}
		}

		#endregion Pass Create 

		#region Pass Print

		public static void Pass_Print(Pass oPassPrint,
				ActiveReport3 rep,
				RFMFormChild thisForm)
		{
			if (!oPassPrint.ID.HasValue && oPassPrint.IDList == null)
				return;

			oPassPrint.FillData();
			if (oPassPrint.ErrorNumber != 0)
				return;

			thisForm.StartForm(new frmActiveReport(oPassPrint.MainTable, rep));
		}

		#endregion Pass Print

		#endregion Pass

		#region Trip

		#region Trip Print

		public static void TripBill_Print(Trip oTripPrint,
			ActiveReport3 rep,
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			TripBill_Print(oTripPrint, rep, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void TripBill_Print(Trip oTripPrint,
				ActiveReport3 rep,
				RFMFormChild thisForm,
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			TripBill_Print(oTripPrint, rep, thisForm, 
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void TripBill_Print(Trip oTripPrint,
				ActiveReport3 rep,
				RFMFormChild thisForm, 
				bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt, 
				int nCopiesCnt)
		{
			if (!oTripPrint.ID.HasValue && oTripPrint.IDList == null)
				return;

			DataTable dt;

			// таблицы для товаров по всем заказам
			if (oTripPrint.ID.HasValue)
			{
				// один рейс
				oTripPrint.ReFillOne((int)oTripPrint.ID);

				if (oTripPrint.SelfDelivery)
				{
					//RFMMessage.MessageBoxError("Рейс \"" + oTripPrint.Alias + "\" оформлен на машину клиента.\n" +
					//	"Маршрутный лист не печатается.");
					return;
				}
				if (!oTripPrint.DriverEmployeeID.HasValue && oTripPrint.DriverName.Length == 0)
				{
					RFMMessage.MessageBoxError("Для рейса \"" + oTripPrint.Alias + "\" не определен водитель.\n" +
						"Маршрутный лист не печатается.");
					return;
				}
				if (!oTripPrint.DateBeg.HasValue)
				{
					// Автоматическое начало рейса при печати маршрутного листа
					int nTripID = (int)oTripPrint.ID;
					oTripPrint.SetDateTime(nTripID, "BEG", "FACT", DateTime.Now, null);
					/*RFMMessage.MessageBoxError("Рейс \"" + oTripPrint.Alias + "\" еще не начат.\n" +
						"Маршрутный лист не печатается.");
					return; */
				}

				// присвоить номера доверенностей
				Trip_WarrantsSet(oTripPrint);

				// заказы одного рейса 
				oTripPrint.FillBillTableOutputsDocumentsInTrip((int)oTripPrint.ID);
				if (oTripPrint.ErrorNumber != 0)
					return;
				if (oTripPrint.IsPostern)
				{
					// ЗД - порядок печати обратный порядку загрузки
					dt = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "_TableOutputsDocumentsInTrip", "", "ByOrder desc, PartnerTargetName");
				}
				else 
				{
					dt = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "_TableOutputsDocumentsInTrip", "", "ByOrder, PartnerTargetName");
				}

                // добавить задания на "доставку" товара без заказов
                oTripPrint.FillBillTableOutputsInTrip((int)oTripPrint.ID);
                if (oTripPrint.DS.Tables.Contains("TableOutputsInTripBill") &&
                    oTripPrint.DS.Tables["TableOutputsInTripBill"] != null &&
                    oTripPrint.DS.Tables["TableOutputsInTripBill"].Rows.Count > 0)
                {
                    dt.Merge(oTripPrint.DS.Tables["TableOutputsInTripBill"]);
                }

				// добавить задания на "забор" товара  
				oTripPrint.FillBillTableInputsInTrip((int)oTripPrint.ID);
				if (oTripPrint.DS.Tables.Contains("TableInputsInTripBill") &&
					oTripPrint.DS.Tables["TableInputsInTripBill"] != null &&
					oTripPrint.DS.Tables["TableInputsInTripBill"].Rows.Count > 0)
				{
					dt.Merge(oTripPrint.DS.Tables["TableInputsInTripBill"]);
				}
            }
			else
			{
				oTripPrint.FillData();
				if (oTripPrint.ErrorNumber != 0)
					return;

				// пустая структура
				oTripPrint.FillBillTableOutputsDocumentsInTrip(-1);
				dt = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "dt", "", "");
				dt.PrimaryKey = null;

				// много рейсов
				Trip oTripPrintOne = new Trip();
				foreach (DataRow tr in oTripPrint.MainTable.Rows)
				{
					oTripPrintOne.FillOne(tr);
					
					if (oTripPrintOne.SelfDelivery)
					{
						RFMMessage.MessageBoxError("Рейс \"" + oTripPrintOne.Alias + "\" оформлен на машину клиента.\n" +
							"Маршрутный лист не печатается.");
						continue;
					}
					if (!oTripPrintOne.DriverEmployeeID.HasValue && oTripPrint.DriverName.Length == 0)
					{
						RFMMessage.MessageBoxError("Для рейса \"" + oTripPrintOne.Alias + "\" не определен водитель.\n" +
							"Маршрутный лист не печатается.");
						return;
					}

					if (!oTripPrintOne.DateBeg.HasValue)
					{
                        // Автоматическое начало рейса при печати маршрутного листа
                        if (oTripPrintOne.ID.HasValue)
                        {
                            int nTripID = (int)oTripPrintOne.ID;
                            oTripPrint.SetDateTime(nTripID, "BEG", "FACT", DateTime.Now, null);
                        }
                        else
                        {
                            /*RFMMessage.MessageBoxError("Рейс \"" + oTripPrintOne.Alias + "\" еще не начат.\n" +
                                "Маршрутный лист не печатается.");*/
                            continue;
                        }
					}

					// заказы каждого рейса
					DataTable dtTemp;
					oTripPrint.FillBillTableOutputsDocumentsInTrip((int)tr["ID"]);
					if (oTripPrintOne.IsPostern)
					{
						// ЗД - порядок печати обратный порядку загрузки
						dtTemp = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "_dtTemp", "", "ByOrder desc, PartnerTargetName");
					}
					else
					{
						dtTemp = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "_dtTemp", "", "ByOrder, PartnerTargetName");
					}
					dt.Merge(dtTemp);

                    // добавить задания на "доставку" товара без заказов
                    oTripPrint.FillBillTableOutputsInTrip((int)tr["ID"]);
                    if (oTripPrint.DS.Tables.Contains("TableOutputsInTripBill") &&
                        oTripPrint.DS.Tables["TableOutputsInTripBill"] != null &&
                        oTripPrint.DS.Tables["TableOutputsInTripBill"].Rows.Count > 0)
                    {
                        dt.Merge(oTripPrint.DS.Tables["TableOutputsInTripBill"]);
                    }

					// добавить задания на "забор" товара  
					oTripPrint.FillBillTableInputsInTrip((int)tr["ID"]);
					if (oTripPrint.DS.Tables.Contains("TableInputsInTripBill") &&
						oTripPrint.DS.Tables["TableInputsInTripBill"] != null &&
						oTripPrint.DS.Tables["TableInputsInTripBill"].Rows.Count > 0)
					{
						dt.Merge(oTripPrint.DS.Tables["TableInputsInTripBill"]);
					}
				}
			}

			if (bToArrayList)
			{
				if (dt != null && dt.Rows.Count > 0)
				{
					// только сохраняем в массивы
					_aDataTables.Add(dt); //oTripPrint.TableOutputsDocumentsInTrip
					_aReps.Add(rep);
					_aCopiesCnt.Add(1);
				}
			}
			else
			{
				if (dt != null && dt.Rows.Count > 0)
				{
					thisForm.StartForm(new frmActiveReport(dt, rep)); //oTripPrint.TableOutputsDocumentsInTrip
				}
				else
				{
					RFMMessage.MessageBoxInfo("Нет данных о расходных документах и приходах в рейсе...");
				}
			}
		}

		#endregion Trip Print

		#region Trip Warrants Set

		public static void Trip_WarrantsSet(Trip oTrip)
		{
			if (!oTrip.ID.HasValue)
				return; 

			if (!oTrip.SelfDelivery && !oTrip.IsRentCar)
			{
				// получить номера доверенностей для расходных документов, если нужно
				// только для наших машин! (не самовывоз, не аренда) 
				OutputDocument oOutputDocument = new OutputDocument();
				oOutputDocument.FilterTripsList = oTrip.ID.ToString();
				oOutputDocument.FillData();
				if (oOutputDocument.ErrorNumber == 0 && oOutputDocument.MainTable != null && oOutputDocument.MainTable.Rows.Count > 0)
				{
					foreach (DataRow od in oOutputDocument.MainTable.Rows)
					{
						oOutputDocument.FillOne(od);
						if (oOutputDocument.PF_WarrantNeed)
						{
							if (oOutputDocument.WarrantNumber == null || oOutputDocument.WarrantNumber.Length == 0)
							{
								// получаем очередной номер доверенности и записываем его в журнал
								oOutputDocument.WarrantSet((int)oOutputDocument.ID, null);
							}
							else
							{
								WarrantNumber oWarrant = new WarrantNumber();
								oWarrant.Update((int)oOutputDocument.ID, null, null);
							}
						}
					}
				}
			}

			if (!oTrip.SelfDelivery)
			{
				// получить номера доверенностей для приходов (не возвратов), если нужно
				// для любых машин с логистикой (не самовывоз)
				Input oInput = new Input();
				oInput.FilterTripsList = oTrip.ID.ToString();
				oInput.FillData();
				if (oInput.ErrorNumber == 0 && oInput.MainTable != null && oInput.MainTable.Rows.Count > 0)
				{
					foreach (DataRow od in oInput.MainTable.Rows)
					{
						oInput.FillOne(od);

						// для арендованных машин - не формируем доверенности на возврат
						if (oTrip.IsRentCar && oInput.IsReturn)
							continue;

						if (oInput.PF_WarrantNeed)
						{
							if (oInput.WarrantNumber == null || oInput.WarrantNumber.Length == 0)
							{
								// получаем очередной номер доверенности и записываем его в журнал
								oInput.WarrantSet((int)oInput.ID, null);
							}
							else
							{
								WarrantNumber oWarrant = new WarrantNumber();
								oWarrant.Update(null, null, (int)oInput.ID);
							}
						}
					}
				}
			}
		}

		#endregion Trip Warrants Set

        #region TripsList

		#region TripsList Outputs

		public static void TripsList_Print(Trip oTripPrint,
				RFMFormChild thisForm)
		{
			TripsList_Print(oTripPrint,
                thisForm,
				new TripsList());
		}

        public static void TripsList_Print(Trip oTripPrint,
                RFMFormChild thisForm, 
				ActiveReport3 rep)
        {
            if (!oTripPrint.ID.HasValue && oTripPrint.IDList == null)
                return;

            oTripPrint.FillData();
            if (oTripPrint.ErrorNumber == 0 && oTripPrint.MainTable != null)
            {
                if (oTripPrint.MainTable.Rows.Count == 0)
                {
                    RFMMessage.MessageBoxError("Нет данных о рейсах...");
                    return;
                }
            }
            else
                return;

			#region not used
			/*
			thisForm.WaitOn(thisForm);

			string sText = "";
            string sEOL = Environment.NewLine;
            int nLen = 85;
            int nLenPartner = 42;
            decimal nBrutto = 0;
            decimal nPallets = 0; 
            DataTable dtTrips = thisForm.CopyTable(oTripPrint.MainTable, "dtTrips", "", "ByOrder");
            DateTime dDate = Convert.ToDateTime(dtTrips.Rows[0]["DateTrip"]);

            sText = "Дата, время печати: " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + 
                sEOL + 
                "Порядок загрузки машин на " + dDate.ToString("dd.MM.yyyy") + 
                sEOL + 
                "".PadRight(nLen, '=') + 
                sEOL +
                "ПЗ".PadLeft(4) + "  " + 
                "Скл.зад.".PadRight(18) +
                "Покупатель".PadRight(nLenPartner) + 
                "Брутто".PadLeft(9) + 
                "Паллет".PadLeft(9) + 
                sEOL + 
                "".PadRight(nLen, '=') + 
                sEOL; 

            foreach (DataRow t in dtTrips.Rows)
            {
                sText += t["ByOrder"].ToString().PadLeft(3) + "  " + 
                    ((Convert.ToDateTime(t["DateTrip"]).CompareTo(dDate) != 0) ? (Convert.ToDateTime(t["DateTrip"])).ToString("dd.MM.yyyy") + " " : "") +  
                    t["Alias"].ToString() + 
                    sEOL;

                oTripPrint.ClearError();
                oTripPrint.ID = (int)t["ID"];
                oTripPrint.FillTableOutputsInTrip();
                if (oTripPrint.ErrorNumber == 0 && oTripPrint.TableOutputsInTrip != null)
                {
                    DataTable tOutputs = thisForm.CopyTable(oTripPrint.TableOutputsInTrip, "tOutputs", "", "ByOrder, PartnerName, ID"); 
                    foreach(DataRow o in tOutputs.Rows)
                    {
                        sText += o["ByOrder"].ToString().Trim().PadLeft(4) + "  " + 
                            o["BarCode"].ToString().PadRight(18) +
                            o["PartnerName"].ToString().PadRight(nLenPartner).Substring(0, nLenPartner) +
                            (Convert.ToDecimal(o["Brutto"])).ToString("# ### ##0").Trim().PadLeft(9) +
                            (Convert.ToDecimal(o["PalletsQnt"])).ToString("### ##0.0").Trim().PadLeft(9) + 
                            sEOL; 
                        nBrutto += (decimal)o["Brutto"];
                        nPallets += (decimal)o["PalletsQnt"];
                    }
                }

                oTripPrint.ClearError();
                oTripPrint.FillTableInputsInTrip();
                if (oTripPrint.ErrorNumber == 0 && oTripPrint.TableInputsInTrip != null)
                {
                    if (oTripPrint.TableInputsInTrip.Rows.Count > 0)
                    {
                        sText += "".PadRight(nLen, '.') + 
                            sEOL + 
                            "Забор товара:" + 
                            sEOL;

                        DataTable tInputs = thisForm.CopyTable(oTripPrint.TableInputsInTrip, "tInputs", "", "ByOrder, PartnerName, ID"); 

                        foreach (DataRow i in tInputs.Rows)
                        {
                            sText += i["ByOrder"].ToString().Trim().PadLeft(4) + "  " + 
                                i["BarCode"].ToString().PadRight(18) +
                                i["PartnerName"].ToString().PadRight(nLenPartner).Substring(0, nLenPartner) +
                                (Convert.ToDecimal(i["Brutto"])).ToString("# ### ##0").Trim().PadLeft(9) +
                                (Convert.ToDecimal(i["PalletsQnt"])).ToString("### ##0.0").Trim().PadLeft(9) +
                                sEOL;
                        }
                    }
                }
                sText += "".PadRight(nLen, '-') + sEOL;
            }
            sText += "".PadRight(nLen, '-') + sEOL;
            sText += "".ToString().PadLeft(4) + "  " + 
                "".PadRight(18) +
                "ИТОГО: ".PadLeft(nLenPartner - 2) +
                nBrutto.ToString("### ### ##0").Trim().PadLeft(11) +
                sEOL;
            sText += "".ToString().PadLeft(4) + "  " + 
                "".PadRight(18) +
                "".PadRight(nLenPartner) +
                "".PadLeft(9) +
                nPallets.ToString("### ##0.0").Trim().PadLeft(9) +
                sEOL;

			thisForm.WaitOff(thisForm);
            thisForm.StartForm(new frmSysTextReport(sText));
			*/
			#endregion not used

			DateTime dDate = (DateTime)oTripPrint.MainTable.Rows[0]["DateTrip"]; 
			// пустая структура 
			oTripPrint.ID = -1;
			oTripPrint.FillTableOutputsInTrip();
			DataTable dtOutputs = thisForm.CopyTable(oTripPrint.TableOutputsInTrip, "dtOutput", "", "");
			dtOutputs.Columns["ID"].AllowDBNull = true;
			dtOutputs.Columns["ID"].Unique = false;
            //dtOutputs.Columns.Add("TripByOrder");
            dtOutputs.Columns.Add("TripByOrder", System.Type.GetType("System.Int32"));
            dtOutputs.Columns.Add("TripInfo");
			dtOutputs.Columns.Add("DateTrip", System.Type.GetType("System.DateTime"));
			string sTripInfo = "";
			//string sTripByOrder = "";
            int nTripByOrder = 0;
            string sDateBegPlan = "";
			bool bAdded = false;

			DataTable dtTrips = thisForm.CopyTable(oTripPrint.MainTable, "dtTrips", "", "DateTrip, ByOrder");
			foreach (DataRow t in dtTrips.Rows)
			{
				sTripInfo = ((((DateTime)t["DateTrip"]).Date.CompareTo(dDate.Date) == 0) ? "" : (((DateTime)t["DateTrip"]).ToString("dd.MM.yyyy") + " ")) +
					t["Alias"];
                //sTripByOrder = (Convert.IsDBNull(t["ByOrder"]) || (int)t["ByOrder"] == 0) ? "" : t["ByOrder"].ToString();
                nTripByOrder = (Convert.IsDBNull(t["ByOrder"]) || (int)t["ByOrder"] == 0) ? 0 : Convert.ToInt32(t["ByOrder"]);
                sDateBegPlan = (t["DateBegPlan"].ToString().Length == 0 ? "" : Convert.ToDateTime(t["DateBegPlan"]).ToShortTimeString());

				bAdded = false;

				oTripPrint.ClearError();
				oTripPrint.ID = (int)t["ID"];

                // получение расходов
				oTripPrint.FillTableOutputsInTrip();
				if (oTripPrint.ErrorNumber == 0 && oTripPrint.TableOutputsInTrip != null)
				{
					DataTable tOutputs = thisForm.CopyTable(oTripPrint.TableOutputsInTrip, "tOutputs", "", "ByOrder, PartnerName, ID");
					//tOutputs.Columns.Add("TripByOrder");
                    tOutputs.Columns.Add("TripByOrder", System.Type.GetType("System.Int32"));
                    tOutputs.Columns.Add("TripInfo");
					tOutputs.Columns.Add("DateTrip", System.Type.GetType("System.DateTime"));
                    tOutputs.Columns.Add("DateBegPlan");
					foreach (DataRow o in tOutputs.Rows)
					{
                        //o["TripByOrder"] = sTripByOrder;
                        o["TripByOrder"] = nTripByOrder;
                        o["TripInfo"] = sTripInfo;
						o["DateTrip"] = t["DateTrip"];
                        o["DateBegPlan"] = sDateBegPlan;
					}
					dtOutputs.Merge(tOutputs);

					if (tOutputs.Rows.Count > 0)
						bAdded = true;
				}

                // получение спецзаданий
                oTripPrint.FillTableCarsTasksInTrip();
                if (oTripPrint.ErrorNumber == 0 && oTripPrint.TableCarsTasksInTrip != null)
                {
                    DataTable tCarsTasks = thisForm.CopyTable(oTripPrint.TableCarsTasksInTrip, "tCarsTasks", "", "ByOrder, PartnerName, ID");
                    //tCarsTasks.Columns.Add("TripByOrder");
                    tCarsTasks.Columns.Add("TripByOrder", System.Type.GetType("System.Int32"));
                    tCarsTasks.Columns.Add("TripInfo");
                    tCarsTasks.Columns.Add("DateTrip", System.Type.GetType("System.DateTime"));
                    tCarsTasks.Columns.Add("DateBegPlan");

                    tCarsTasks.Columns.Add("IsCarried", System.Type.GetType("System.Boolean"));
                    tCarsTasks.Columns.Add("CopiedFromOutputID", System.Type.GetType("System.Int32"));
                    foreach (DataRow o in tCarsTasks.Rows)
                    {
                        //o["TripByOrder"] = sTripByOrder;
                        o["TripByOrder"] = nTripByOrder;
                        o["TripInfo"] = sTripInfo;
                        o["DateTrip"] = t["DateTrip"];
                        o["DateBegPlan"] = sDateBegPlan;

                        o["IsCarried"] = false;
                        o["CopiedFromOutputID"] = DBNull.Value;

                        // Добавление адреса к имени партнера
                        o["PartnerName"] = o["PartnerName"].ToString() + " (" + o["DeliveryAddress"].ToString() + ")";
                    }
                    dtOutputs.Merge(tCarsTasks);

                    if (tCarsTasks.Rows.Count > 0)
                        bAdded = true;
                }

				/*
				// приходы в рейсе
				oTripPrint.ClearError();
				oTripPrint.FillTableInputsInTrip();
				if (oTripPrint.ErrorNumber == 0 && oTripPrint.TableInputsInTrip != null)
				{
					if (oTripPrint.TableInputsInTrip.Rows.Count > 0)
					{
						DataTable tInputs = thisForm.CopyTable(oTripPrint.TableInputsInTrip, "tInputs", "", "ByOrder, PartnerName, ID");
						tInputs.Columns.Add("TripByOrder");
						tInputs.Columns.Add("TripInfo");
						tInputs.Columns.Add("DateTrip", System.Type.GetType("System.DateTime"));
						foreach (DataRow i in tInputs.Rows)
						{
							i["TripByOrder"] = sTripByOrder;
							i["TripInfo"] = sTripInfo;
							i["DateTrip"] = t["DateTrip"];
						}
						dtOutputs.Merge(tInputs);
						bAdded = true;
					}
				}
				*/

				if (!bAdded)
				{
					dtOutputs.Rows.Add();
					DataRow tx = dtOutputs.Rows[dtOutputs.Rows.Count - 1];
					tx["TripID"] = t["ID"];
                    //tx["TripByOrder"] = sTripByOrder;
                    tx["TripByOrder"] = nTripByOrder;
                    tx["TripInfo"] = sTripInfo;
					tx["DateTrip"] = t["DateTrip"];
                    tx["DateBegPlan"] = "";
                }
			}

			// Удаляем пустые рейсы (не содержат заданий)
			for (int iCount = dtOutputs.Rows.Count - 1; iCount >= 0; iCount--)
				if (dtOutputs.Rows[iCount]["ID"].ToString() == "") dtOutputs.Rows.RemoveAt(iCount);
			if (dtOutputs.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("Отобранные рейсы не содержат расходных документов...");
				return;
			}

            // Сортируем таблицу
            dtOutputs.DefaultView.Sort = "DateTrip, TripByOrder, ByOrder";

			/*
			ActiveReport3 repTripsList = new TripsList();
 			thisForm.StartForm(new frmActiveReport(dtOutputs, repTripsList));
			*/
            thisForm.StartForm(new frmActiveReport(dtOutputs.DefaultView.ToTable(), rep));
		}

		#endregion TripsList Outputs

		#region TripsList OutputsDocuments

		public static void TripsListNotes_Print(Trip oTripPrint,
				RFMFormChild thisForm)
		{
			TripsListNotes_Print(oTripPrint,
				thisForm,
				new TripsListNotes());
		}

		public static void TripsListNotes_Print(Trip oTripPrint,
				RFMFormChild thisForm,
				ActiveReport3 rep)
		{
			if (!oTripPrint.ID.HasValue && oTripPrint.IDList == null)
				return;

			oTripPrint.FillData();
			if (oTripPrint.ErrorNumber == 0 && oTripPrint.MainTable != null)
			{
				if (oTripPrint.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных о рейсах...");
					return;
				}
			}
			else
				return;

			DateTime dDate = (DateTime)oTripPrint.MainTable.Rows[0]["DateTrip"];
			
			// пустая структура 
			oTripPrint.ID = -1;
			oTripPrint.FillTableOutputsDocumentsInTrip();
			DataTable dt = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "dt", "", "");
			dt.Columns["ID"].AllowDBNull = true;
			dt.Columns["ID"].Unique = false;
			dt.Columns.Add("DateTrip", System.Type.GetType("System.DateTime"));
			dt.Columns.Add("TripInfo");
			dt.Columns.Add("TripByOrder", System.Type.GetType("System.Int32"));
			string sTripInfo = "";

			DataTable dtTrips = thisForm.CopyTable(oTripPrint.MainTable, "dtTrips", "", "DateTrip, Alias"); //ByOrder
			foreach (DataRow t in dtTrips.Rows)
			{
				oTripPrint.ClearError();
				oTripPrint.ID = (int)t["ID"];
				oTripPrint.FillTableOutputsDocumentsInTrip();
				if (oTripPrint.ErrorNumber == 0 && oTripPrint.TableOutputsDocumentsInTrip != null)
				{
					if (oTripPrint.TableOutputsDocumentsInTrip.Rows.Count > 0)
					{
						sTripInfo = ((((DateTime)t["DateTrip"]).Date.CompareTo(dDate.Date) == 0) ? "" : (((DateTime)t["DateTrip"]).ToString("dd.MM.yyyy") + " ")) +
							t["Alias"];

						DataTable tTemp = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "tTemp", "", "PartnerName, ByOrder, ID");
						tTemp.Columns.Add("DateTrip", System.Type.GetType("System.DateTime"));
						tTemp.Columns.Add("TripInfo");
						tTemp.Columns.Add("TripByOrder", System.Type.GetType("System.Int32"));
						foreach (DataRow od in tTemp.Rows)
						{
							od["DateTrip"] = t["DateTrip"];
							od["TripInfo"] = sTripInfo;
							od["TripByOrder"] = t["ByOrder"];
						}
						dt.Merge(tTemp);
					}
				}
			}

			thisForm.StartForm(new frmActiveReport(dt, rep));
		}

		#endregion TripsList OutputsDocuments

		#endregion TripsList

		#region TripsBalances

		public static void TripsPutsBalances_Print(Trip oTripPrint,
				RFMFormChild thisForm, 
				bool bMessage)
		{
			if (!oTripPrint.ID.HasValue)
				return;

			oTripPrint.ReFillOne((int)oTripPrint.ID);

			DataTable dt;

			// баланс по расходам 
			if (oTripPrint.IsOutputsAttached)
			{
				if (!oTripPrint.IsOutputsConfirmed)
				{
					RFMMessage.MessageBoxAttention("Внимание!\n\n" +
						"Не все задания на расход для рейса подтверждены!");
				}

				if (oTripPrint.IsTripsReturnsAttached)
				{
					if (!oTripPrint.IsTripsReturnsConfirmed)
					{
						RFMMessage.MessageBoxAttention("Внимание!\n\n" +
							"Не все возвраты для рейса подтверждены!");
					}
				}

				if (oTripPrint.Report_TripOutputsBalance((int)oTripPrint.ID) && 
					oTripPrint.ErrorNumber == 0 && 
					oTripPrint.DS.Tables.Contains("TableOutputsBalance"))
				{ 
					dt = oTripPrint.DS.Tables["TableOutputsBalance"];
					if (dt.Rows.Count == 0)
					{
						if (bMessage)
							RFMMessage.MessageBoxInfo("Расхождений по расходам для рейса не обнаружено...");
					}
					else
					{
						ActiveReport3 repTripOutputsBalance = new TripOutputsBalance();
						thisForm.StartForm(new frmActiveReport(dt, repTripOutputsBalance));
					}
				}
 			}

			// баланс по приходам
			if (oTripPrint.IsInputsAttached)
			{
				if (!oTripPrint.IsInputsConfirmed)
				{
					RFMMessage.MessageBoxAttention("Внимание!\n\n" +
						"Не все задания на приход для рейса подтверждены!");
				}

				if (oTripPrint.Report_TripInputsBalance((int)oTripPrint.ID) &&
					oTripPrint.ErrorNumber == 0 &&
					oTripPrint.DS.Tables.Contains("TableInputsBalance"))
				{
					dt = oTripPrint.DS.Tables["TableInputsBalance"];
					if (dt.Rows.Count == 0)
					{
						if (bMessage)
							RFMMessage.MessageBoxInfo("Расхождений по приходам для рейса не обнаружено...");
					}
					else
					{
						ActiveReport3 repTripInputsBalance = new TripInputsBalance();
						thisForm.StartForm(new frmActiveReport(dt, repTripInputsBalance));
					}
				}
			}
		}

		#endregion TripsBalances

		#region Trip TripReturn&Act Create
        
		public static bool Trip_ReturnActCreate(int nTripID,
			RFMFormChild thisForm)
		{
			Trip oTrip = new Trip();
			oTrip.ReFillOne(nTripID);

			// проверки
			if (oTrip.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Рейс уже подтвержден...");
				return (false);
			}
			if (!oTrip.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("Рейс еще не начат...");
				return (false);
			}
			if (!oTrip.ReadyForTripBeg.HasValue || !(bool)oTrip.ReadyForTripBeg)
			{
				RFMMessage.MessageBoxError("Рейс не готов к началу...");
				return (false);
			}

			if (oTrip.SelfDelivery)
			{
				RFMMessage.MessageBoxError("Для машины клиента возврат не оформляется...");
				return (false);
			}

			if (!oTrip.CarID.HasValue &&
				(oTrip.CarNumber == null || oTrip.CarNumber.Length == 0))
			{
				RFMMessage.MessageBoxError("Машина не определена...");
				return (false);
			}

			if (oTrip.DateEnd.HasValue)
			{
				if (RFMMessage.MessageBoxYesNo("Рейс уже окончен...\nВсе-таки сформировать возврат/акт?") != DialogResult.Yes)
					return (false);
			}

			// расход: все задания д.б. выполнены
			Output oOutput = new Output();
			oOutput.FilterTripsList = nTripID.ToString();
			oOutput.FillData();
			if (oOutput.ErrorNumber != 0 || oOutput.MainTable == null)
				return (false);

			if (oOutput.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет заданий на расход,\n" +
					"формирование возврата/акта не выполняется.");
				return (false);
			}

			oOutput.FilterIsConfirmed = false;
			oOutput.FillData();
			if (oOutput.ErrorNumber != 0 || oOutput.MainTable == null)
				return (false);

			if (oOutput.MainTable.Rows.Count > 0)
			{
				RFMMessage.MessageBoxError("Не все задания на расход выполнены,\n" +
					"формирование возврата/акта не выполняется.");
				return (false);
			}

			// расходные документы: все документы д.б. доставлены
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.FilterTripsList = nTripID.ToString();
			oOutputDocument.FilterIsBrought = false;
			oOutputDocument.FillData();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
				return (false);

			if (oOutputDocument.MainTable.Rows.Count > 0)
			{
				RFMMessage.MessageBoxError("Не все расходные документы доставлены получателю,\n" +
					"формирование возврата/акта не выполняется.");
				return (false);
			}

			bool bAsked = false;

			// если уже есть авто-возврат
			TripReturn oTripReturn = new TripReturn();
			oTripReturn.FilterTripsList = nTripID.ToString();
			oTripReturn.FilterAutoCreated = true;
			oTripReturn.FillData();
			if (oTripReturn.ErrorNumber != 0 || oTripReturn.MainTable == null)
				return (false);

			if (oTripReturn.MainTable.Rows.Count > 0)
			{
				if (RFMMessage.MessageBoxYesNo("Для рейса уже существует автоматически рассчитанный возврат.\n" +
						"Все-таки сформировать возврат/акт?") != DialogResult.Yes)
					return (false);
				bAsked = true;
			}

			// начинаем
			if (bAsked || 
				RFMMessage.MessageBoxYesNo("Сформировать возврат/акт?") == DialogResult.Yes)
			{
				if (oTrip.CreateReturnAct(nTripID) && oTrip.ErrorNumber == 0)
				{
					// список расхождений +/-
					if (oTrip.DS.Tables.Contains("TripReturnActGoods") && oTrip.DS.Tables["TripReturnActGoods"] != null &&
						oTrip.DS.Tables["TripReturnActGoods"].Rows.Count > 0)
					{
						DataTable dt = oTrip.DS.Tables["TripReturnActGoods"];
						//DataView dv = new DataView(dt, "", "GoodStateName, OwnerName", DataViewRowState.CurrentRows);
						DataView dv = new DataView(dt);
						DataTable dtOGS = dv.ToTable(true, "GoodStateID", "OwnerID", "GoodStateName", "OwnerName");
						dtOGS.DefaultView.Sort = "GoodStateName, OwnerName";
						foreach (DataRow rOGS in dtOGS.Rows)
						{
							DataTable dtGoods = thisForm.CopyTable(dt, "dtGoods",
								"GoodStateID = " + rOGS["GoodStateID"].ToString() + " and OwnerID = " + rOGS["OwnerID"].ToString(), "");
							if (dtGoods != null && dtGoods.Rows.Count > 0)
							{
								thisForm.StartForm(new frmTripsReturnsActsCreate(nTripID, dtGoods));
							}
						}
					}
					else
					{
						RFMMessage.MessageBoxInfo("Расхождений не обнаружено,\n" +
							"автоматическое формирование возврата/акта не выполняется.");
						return (false);
					}
				}
			}
			return (true);
		}
        
		#endregion Trip Return&Act Create 

		#region Trip Act Create 

		public static bool Trip_ActCreate(int nTripID,
			RFMFormChild thisForm)
		{
			Trip oTrip = new Trip();
			oTrip.ReFillOne(nTripID);

			// проверки
			if (oTrip.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Рейс уже подтвержден...");
				return (false);
			}
			if (!oTrip.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("Рейс еще не начат...");
				return (false);
			}
			if (!oTrip.ReadyForTripBeg.HasValue || !(bool)oTrip.ReadyForTripBeg)
			{
				RFMMessage.MessageBoxError("Рейс не готов к началу...");
				return (false);
			}

			/*
			if (oTrip.SelfDelivery)
			{
				RFMMessage.MessageBoxError("Для машины клиента возврат не оформляется...");
				return (false);
			}
			*/

			if (!oTrip.CarID.HasValue &&
				(oTrip.CarNumber == null || oTrip.CarNumber.Length == 0))
			{
				RFMMessage.MessageBoxError("Машина не определена...");
				return (false);
			}

			/*
			if (oTrip.DateEnd.HasValue)
			{
				if (RFMMessage.MessageBoxYesNo("Рейс уже окончен...\nВсе-таки сформировать возврат/акт?") != DialogResult.Yes)
					return (false);
			}
			*/

			// расход: все задания д.б. выполнены
			Output oOutput = new Output();
			oOutput.FilterTripsList = nTripID.ToString();
			oOutput.FillData();
			if (oOutput.ErrorNumber != 0 || oOutput.MainTable == null)
				return (false);

			if (oOutput.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет заданий на расход,\n" +
					"формирование акта не выполняется.");
				return (false);
			}

			oOutput.FilterIsConfirmed = false;
			oOutput.FillData();
			if (oOutput.ErrorNumber != 0 || oOutput.MainTable == null)
				return (false);

			if (oOutput.MainTable.Rows.Count > 0)
			{
				RFMMessage.MessageBoxError("Не все задания на расход выполнены,\n" +
					"формирование акта не выполняется.");
				return (false);
			}

			// расходные документы: все документы д.б. доставлены
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.FilterTripsList = nTripID.ToString();
			oOutputDocument.FilterIsBrought = false;
			oOutputDocument.FillData();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
				return (false);

			if (oOutputDocument.MainTable.Rows.Count > 0)
			{
				RFMMessage.MessageBoxError("Не все расходные документы доставлены получателю,\n" +
					"формирование акта не выполняется.");
				return (false);
			}

			if (RFMMessage.MessageBoxYesNo("Сформировать акт на основании несоответствий отгруженного и доставленного количества?") == DialogResult.Yes)
			{
				if (oTrip.CreateReturnAct(nTripID) && oTrip.ErrorNumber == 0)
				{
					// список расхождений +/-
					if (oTrip.DS.Tables.Contains("TripReturnActGoods") && oTrip.DS.Tables["TripReturnActGoods"] != null &&
						oTrip.DS.Tables["TripReturnActGoods"].Rows.Count > 0)
					{
						DataTable dt = oTrip.DS.Tables["TripReturnActGoods"];
						dt.Columns.Add("QntConfirmed", System.Type.GetType("System.Decimal"));
						dt.Columns.Add("BoxConfirmed", System.Type.GetType("System.Decimal"));
						foreach (DataRow r in dt.Rows)
						{
							r["QntConfirmed"] = (decimal)r["ActQnt"] - (decimal)r["ReturnQnt"];
							r["BoxConfirmed"] = (decimal)r["QntConfirmed"] / (decimal)r["InBox"];
						}

						DataView dv = new DataView(dt);
						dv.RowFilter = "QntConfirmed <> 0";
						DataTable dtO = dv.ToTable(true, "OutputID");
						int nActsQnt = dtO.Rows.Count;
						if (nActsQnt == 0)
						{
							RFMMessage.MessageBoxInfo("Расхождений не обнаружено.");
							return (false);
						}

						string sText = "Обнаружены расхождения по " + RFMUtilities.Declen(nActsQnt, "складскому заданию", "складским заданиям", "складским заданиям") + " на расход.\n" + 
							"Создать " + RFMUtilities.Declen(nActsQnt, "акт", "акта", "актов") + "?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes) 
							return (false);

						foreach (DataRow rO in dtO.Rows)
						{
							// для каждого задания на расход
							int nOutputID = (int)rO["OutputID"];
							DataTable dtGoods = thisForm.CopyTable(dt, "dtGoods", "QntConfirmed <> 0 and OutputID = " + nOutputID.ToString(), "");
							if (dtGoods != null && dtGoods.Rows.Count > 0)
							{
								thisForm.StartForm(new frmActsEdit(0, null, nOutputID, dtGoods));
							}
						}
					}
					else
					{
						RFMMessage.MessageBoxInfo("Расхождений не обнаружено.");
						return (false);
					}
				}
			}
			return (true);
		}
        
		#endregion Trip Act Create 

		#region Trip WayBill Print

		public static void TripWayBill_Print(Trip oTripPrint,
			ActiveReport3 rep,
			string sFilter, 
			RFMFormChild thisForm)
		{
			ArrayList aTemp1 = new ArrayList();
			ArrayList aTemp2 = new ArrayList();
			ArrayList aTemp3 = new ArrayList();
			TripWayBill_Print(oTripPrint, rep, sFilter, thisForm,
				false, ref aTemp1, ref aTemp2, ref aTemp3, 1);
		}

		public static void TripWayBill_Print(Trip oTripPrint,
			ActiveReport3 rep,
			string sFilter, 
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps)
		{
			ArrayList aTemp3 = new ArrayList();
			TripWayBill_Print(oTripPrint, rep, sFilter, thisForm,
				bToArrayList, ref _aDataTables, ref _aReps, ref aTemp3, 1);
		}

		public static void TripWayBill_Print(Trip oTripPrint,
			ActiveReport3 rep,
			string sFilter, 
			RFMFormChild thisForm,
			bool bToArrayList, ref ArrayList _aDataTables, ref ArrayList _aReps, ref ArrayList _aCopiesCnt,
			int nCopiesCnt)
		{
			if (!oTripPrint.ID.HasValue && oTripPrint.IDList == null)
				return;

			DataTable dt; 

			oTripPrint.FillData();
			
			if (oTripPrint.ErrorNumber != 0 || 
				oTripPrint.MainTable.Rows.Count == 0)
				return;

			if (!oTripPrint.MainTable.Columns.Contains("WeName"))
				oTripPrint.MainTable.Columns.Add("WeName");
			if (!oTripPrint.MainTable.Columns.Contains("BillsList"))
				oTripPrint.MainTable.Columns.Add("BillsList");
			if (!oTripPrint.MainTable.Columns.Contains("WayText"))
				oTripPrint.MainTable.Columns.Add("WayText");
			if (!oTripPrint.MainTable.Columns.Contains("DriverLicenceNumber"))
				oTripPrint.MainTable.Columns.Add("DriverLicenceNumber");
			if (!oTripPrint.MainTable.Columns.Contains("DriverCategory"))
				oTripPrint.MainTable.Columns.Add("DriverCategory");
			if (!oTripPrint.MainTable.Columns.Contains("Cnt"))
				oTripPrint.MainTable.Columns.Add("Cnt", System.Type.GetType("System.Int32")); 

			Driver oDriver = new Driver();

			Partner oPartner = new Partner(); 

			Setting oSet = new Setting();
			string sWeName = oSet.FillVariable("WeName");

			foreach(DataRow tR in oTripPrint.MainTable.Rows)
			{
				// один рейс
				oTripPrint.FillOne(tR);

				if (oTripPrint.SelfDelivery)
				{
					//RFMMessage.MessageBoxError("Рейс \"" + oTripPrint.Alias + "\" оформлен на машину клиента.\n" +
					//	"Маршрутный лист не печатается.");
					return;
				}
				if (!oTripPrint.DriverEmployeeID.HasValue && oTripPrint.DriverName.Length == 0)
				{
					RFMMessage.MessageBoxError("Для рейса \"" + oTripPrint.Alias + "\" не определен водитель.\n" +
						"Путевой лист не печатается.");
					return;
				}

				// заполнить список накладных и соотв. список маршрутов
				oTripPrint.FillBillTableOutputsDocumentsInTrip((int)oTripPrint.ID);
				if (oTripPrint.ErrorNumber != 0)
					continue;

				DataTable dtOD;
				// фильтр по заказам!
				if (sFilter == null) sFilter = ""; 
				if (oTripPrint.IsPostern)
				{
					// ЗД - порядок печати обратный порядку загрузки
					dtOD = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "_TableOutputsDocumentsInTrip", sFilter, "ByOrder desc, PartnerTargetName");
				}
				else
				{
					dtOD = thisForm.CopyTable(oTripPrint.TableOutputsDocumentsInTrip, "_TableOutputsDocumentsInTrip", sFilter, "ByOrder, PartnerTargetName");
				}

				string sBillsList = "", sWayText = "";
				if (dtOD != null && dtOD.Rows.Count > 0)
				{
					if (!dtOD.Columns.Contains("DeliveryStreet"))
						dtOD.Columns.Add("DeliveryStreet"); 

					foreach (DataRow rOD in dtOD.Rows)
					{
						if (rOD["BillNumber"].ToString().Trim().Length > 0)
							sBillsList += ", " + rOD["BillNumber"].ToString().Trim();

						rOD["DeliveryStreet"] = oPartner.GetDeliveryStreet((int)rOD["PartnerTargetID"]);
						if (rOD["DeliveryStreet"].ToString().Trim().Length > 0 &&
							!sWayText.Contains(", " + rOD["DeliveryStreet"].ToString().Trim()))
							sWayText += ", " + rOD["DeliveryStreet"].ToString().Trim();
						/*
						if (rOD["DeliveryAddress"].ToString().Trim().Length > 0 &&
							!sWayText.Contains(", " + rOD["DeliveryAddress"].ToString().Trim())) 
							sWayText += ", " + rOD["DeliveryAddress"].ToString().Trim();
						// ZoneName, ZoneAlias, DeliveryAddress, DeliveryPassage 
						*/ 
					}

					if (sBillsList.Length > 0 && sBillsList.Substring(0, 1) == ",")
						sBillsList = sBillsList.Substring(1).Trim();
					if (sWayText.Length >0 && sWayText.Substring(0, 1) == ",")
						sWayText = sWayText.Substring(1).Trim();
				}

				tR["WeName"] = sWeName; 
				tR["BillsList"] = sBillsList; 
				tR["WayText"] = sWayText;
				tR["Cnt"] = RFMUtilities.Occurs(sBillsList, ",") + 1;

				if (oTripPrint.DriverEmployeeID.HasValue)
				{
					oDriver.ReFillOne((int)oTripPrint.DriverEmployeeID);
					tR["DriverLicenceNumber"] = oDriver.DriverLicenceNumber;
					tR["DriverCategory"] = oDriver.DriverCategory;
				}
				else
				{
					tR["DriverLicenceNumber"] =
					tR["DriverCategory"] =
						"";
				}
			}

			dt = oTripPrint.MainTable;
			if (bToArrayList)
			{
				if (dt != null && dt.Rows.Count > 0)
				{
					// только сохраняем в массивы
					_aDataTables.Add(dt); //oTripPrint.TableOutputsDocumentsInTrip
					_aReps.Add(rep);
					_aCopiesCnt.Add(1);
				}
			}
			else
			{
				if (dt != null && dt.Rows.Count > 0)
				{
					thisForm.StartForm(new frmActiveReport(dt, rep)); //oTripPrint.TableOutputsDocumentsInTrip
				}
				else
				{
					RFMMessage.MessageBoxInfo("Нет данных о расходных документах и приходах в рейсе...");
				}
			}
		}

		#endregion Trip WayBill Print

		#region Test Trip IsConfirmed

		public static bool? TripIsConfirmed(OutputDocument oOutputDocument)
		{
			if (!oOutputDocument.ID.HasValue) 
				return (null);

			oOutputDocument.ReFillOne((int)oOutputDocument.ID);
			if (oOutputDocument.ErrorNumber != 0)
				return (null);

			if (!oOutputDocument.TripID.HasValue)
				return (null);

			return(TripIsConfirmed((int)oOutputDocument.TripID));
		}

		public static bool? TripIsConfirmed(int nTripID)
		{
			Trip oTrip = new Trip();
			oTrip.ReFillOne(nTripID);
			if (oTrip.ErrorNumber != 0)
				return (null);

			return (oTrip.IsConfirmed);
		}

		#endregion Test Trip IsConfirmed

		#endregion Trip

		#region WayBill

		#region WayBill Print

		public static void WayBill_Print(WayBill oWayBillPrint,
				ActiveReport3 rep,
				RFMFormChild thisForm)
		{
			if (!oWayBillPrint.ID.HasValue && oWayBillPrint.IDList == null)
				return;

			oWayBillPrint.FillData();
			if (oWayBillPrint.ErrorNumber != 0)
				return;
			
			thisForm.StartForm(new frmActiveReport(oWayBillPrint.MainTable, rep));
		}

		#endregion WayBill Print

		#endregion WayBill

		#region OutputsDocuments: Bill, Facture, PayBill - additional

		public static bool XMLTemplateTextToFile(string sXMLTemplateText, string sPF_Name, ActiveReport3 rep)
		{ 
			bool bResult = false;

			string sFileName = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserLocPath + sPF_Name + ".rpx";
			try
			{
				StreamWriter s = new StreamWriter(sFileName);
				s.Write(sXMLTemplateText);
				s.Close();
				bResult = true;
			}
			finally { }

			// зачитать этот файл как шаблон
			if (bResult)
			{
				bResult = false;
				try
				{
					rep.LoadLayout(sFileName);
					rep.AddScriptReference("Logistics.exe");
					rep.AddScriptReference("RFMPublic.dll");
					rep.AddScriptReference("RFMBaseClasses.dll");
					rep.AddScriptReference("LogBizObjects.dll");
					bResult = true;
				} 
				finally { }
			}
			return (bResult); 
		}

		private static void ReNumberLineInPage(int? nLinesInPage, DataTable dt)
		{
			// перенумеровать строки
			if (nLinesInPage.HasValue && nLinesInPage > 0)
			{
				int nPageNumber = 1;
				int nNumberInPage = 1;
				foreach (DataRow rr in dt.Rows)
				{
					try
					{
						rr["PrintPageNumber"] = nPageNumber;
						rr["PrintNumberInPage"] = nNumberInPage;
					}
					finally { }
					nNumberInPage++;
					if (nNumberInPage > nLinesInPage)
					{
						nNumberInPage = 1;
						nPageNumber++;
					}
				}
			}
		}

		private static void ReNumberLineInPageLanscape(int? nLinesInPage, DataTable dt)
		{
			// перенумеровать строки в альбомной форме
			if (nLinesInPage.HasValue && nLinesInPage > 0)
			{
				nLinesInPage = Convert.ToInt32(nLinesInPage / 2);
				foreach (DataRow rr in dt.Rows)
				{
					if (Convert.ToInt32(rr["PrintNumberInPage"]) > nLinesInPage)
					{
						rr["PrintPageNumber"] = -Convert.ToInt32(rr["PrintPageNumber"]);
					}
				}
			}
		}

		private static int LinesInPage_GetSetting()
		{
			int nLinesInPage = 0;

			Setting oSet = new Setting();
			string sLinesInPageTemp = null;
			sLinesInPageTemp = oSet.FillVariable("gnLinesInPage");
			if (sLinesInPageTemp != null && sLinesInPageTemp != "")
			{
				try
				{
					nLinesInPage = Convert.ToInt32(sLinesInPageTemp);
				}
				finally { }
			}
			if (nLinesInPage == 0)
				nLinesInPage = 30;

			return (nLinesInPage);
		}

		#endregion OutputsDocuments: Bill, Facture, PayBill - additional

	}
}

