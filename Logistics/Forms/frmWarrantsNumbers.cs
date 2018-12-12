using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics
{
	public partial class frmWarrantsNumbers : RFMFormChild
	{
		private WarrantNumber oWarrantList; //список доверенностей
		private WarrantNumber oWarrantCur; //текущая доверенность

		// для фильтров
		public string _SelectedIDList;
		public string _SelectedText;

		private string sSelectedPartnersSourceIDList = "";
		private string sSelectedPartnersTargetIDList = "";
		private string sSelectedEmployeesIDList = "";

		public frmWarrantsNumbers()
		{
			oWarrantList = new WarrantNumber();
			oWarrantCur = new WarrantNumber();
			if (oWarrantList.ErrorNumber != 0 ||
				oWarrantCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmWarrantsNumbers_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			btnClearTerms_Click(null, null);

			tcList.Init();

			RFMCursorWait.Set(false);
		}

	#region Tab Restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled = 
			btnEdit.Enabled =
			btnDelete.Enabled = 
			btnConfirm.Enabled =
			btnPrint.Enabled =
			btnService.Enabled =
				false;
			return true;
		}

		private bool tabData_Restore()
		{
			grdData_Restore();
			btnAdd.Enabled = false; // не исп.
			if (grdData.Rows.Count > 0)
			{
				btnEdit.Enabled = false; // не исп.
				btnConfirm.Enabled = false; // не исп.
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				grdData.Select();
			}
			else
			{
				btnEdit.Enabled = 
				btnConfirm.Enabled = 
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			return (true);
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled = 
				btnDelete.Enabled =
				btnConfirm.Enabled = 
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("DATA"))
			{
				grdData.Select();

				btnAdd.Enabled = false; // не исп. 
				if (grdData.Rows.Count > 0 && grdData.CurrentRow != null)
				{
					btnPrint.Enabled =
					btnService.Enabled =
						true;

					if (!tabData.IsNeedRestore)
					{
						if (!grdData.IsStatusRow(grdData.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdData.CurrentRow.DataBoundItem).Row;
							oWarrantCur.ID = Convert.ToInt32(r["ID"]);
							SetButtonStatus(r);
						}
					}
				}
			}
		}

	#endregion Tab restore

	#region RowEnter, CellFormatting

		private void grdData_CurrentRowChanged(object sender)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;
			if (grd.IsStatusRow(rowIndex))
			{
				oWarrantCur.ClearOne();
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			else
			{
				DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
				oWarrantCur.FillOne(r);
				SetButtonStatus(r);
			}
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			string sGridName = grd.Name.ToUpper();

			if (grd.DataSource == null)
				return;

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();
			if (sColumnName.Contains("IsMoney".ToUpper()))
			{
				if ((bool)r["IsMoney"])
				{
					e.Value = Properties.Resources.Edit_coin;
				}
				else
				{
					e.Value = Properties.Resources.Box_full;
				}
			}
			if (c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

	#endregion Cells...

	#region SetButtonStatus

		private void SetButtonStatus(DataRow r)
		{
			if (r == null)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnConfirm.Enabled = 
					false;
				return;
			}

			// по значениям из строки r можно установить доступность кнопок
			btnEdit.Enabled = // не исп.
			btnConfirm.Enabled = // не исп.
				false; 
			btnDelete.Enabled =  
			btnPrint.Enabled =
			btnService.Enabled =
				true;
			return;
		}

	#endregion SetButtonStatus

	#region Restore

		private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oWarrantCur.ClearOne();

			oWarrantList.ClearError();
			oWarrantList.ClearFilters();
			oWarrantList.ID = null;
			oWarrantList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oWarrantList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oWarrantList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// номер контекст
			if (txtWarrantNumberContext.Text.Trim().Length > 0)
			{
				oWarrantList.FilterNumberContext = txtWarrantNumberContext.Text.Trim();
			}

			// деньги /товар
			if (optIsMoney.Checked)
			{
				oWarrantList.FilterIsMoney = true;
			}
			if (optIsMoneyNot.Checked)
			{
				oWarrantList.FilterIsMoney = false;
			}

			// клиенты
			if (sSelectedPartnersSourceIDList.Length > 0)
			{
				oWarrantList.FilterPartnersSourceList = sSelectedPartnersSourceIDList;
			}
			if (sSelectedPartnersTargetIDList.Length > 0)
			{
				oWarrantList.FilterPartnersTargetList = sSelectedPartnersTargetIDList;
			}

			// сотрудники
			if (sSelectedEmployeesIDList.Length > 0)
			{
				oWarrantList.FilterEmployeesList = sSelectedEmployeesIDList;
			}
			if (txtDeputyName.Text.Trim().Length > 0)
			{
				oWarrantList.FilterDeputyNameContext = txtDeputyName.Text.Trim();
			}

			// возврат
			if (optIsReturned.Checked)
			{
				oWarrantList.FilterIsReturned = true;
			}
			if (optIsReturnedNot.Checked)
			{
				oWarrantList.FilterIsReturned = false;
			}

			// коды заказов на поставку/отгрузку

			//

			grdData.GetGridState();

			oWarrantList.FillDataAsync();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oWarrantList.MainTable);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oWarrantList.ErrorNumber == 0);
		}

	#endregion Restore

	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// не исп.
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			// не исп.
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			// не исп.
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (tcList.CurrentPage.Name.ToUpper().Contains("DATA"))
			{
				if (grdData.CurrentRow == null)
					return;
				if (!oWarrantCur.ID.HasValue)
					return;

				// перечитать
				oWarrantCur.ReFillOne((int)oWarrantCur.ID);

				// проверки
				if (oWarrantCur.DateReturn != null)
				{
					RFMMessage.MessageBoxError("Зарегистрирован возврат доверенности...\nУдаление не выполняется.");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Удалить доверенность?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oWarrantCur.Delete((int)oWarrantCur.ID);
					WaitOff(this);
					if (bResult && oWarrantCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("Доверенность удалена.");
					}
					else
					{
						RFMMessage.MessageBoxError("Ошибка при удалении доверенности...");
					}
					grdData_Restore();
				}
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

	#endregion
		
	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

	#endregion Menu Print

	#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}

		private void mniWarrantsAnalysis_Click(object sender, EventArgs e)
		{
			WarrantsAnalysis();
		}

		private void mniWarrantsReturn_Click(object sender, EventArgs e)
		{
			WarrantsReturn(true);
		}

		private void mniWarrantsUnReturn_Click(object sender, EventArgs e)
		{
			WarrantsReturn(false);
		}


		private void WarrantsAnalysis()
		{
			// тестирование доверенностей за период
			DateTime dDateBeg = DateTime.Now.Date;
			DateTime dDateEnd = DateTime.Now.Date.AddMonths(-1);
			if (StartForm(new frmDateRange(dDateBeg, dDateEnd)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
					dDateBeg = (DateTime)GotParam[0];
				else
					dDateBeg = Convert.ToDateTime("01.01.1900");

				if (GotParam[1] != null)
					dDateEnd = (DateTime)GotParam[1];
				else
					dDateEnd = Convert.ToDateTime("31.12.2099");
			}

			WarrantNumber oWarrantAnalysis = new WarrantNumber();
			oWarrantAnalysis.FilterDateBeg = dDateBeg;
			oWarrantAnalysis.FilterDateEnd = dDateEnd;
			oWarrantAnalysis.FillDataAsync();
			if (oWarrantAnalysis.ErrorNumber != 0 || oWarrantAnalysis.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при анализе списка доверенностей...");
				return;
			}
			if (oWarrantAnalysis.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных о доверенностях за период...");
				return;
			}

			WaitOn(this);

			string sEol = Environment.NewLine;

			OutputDocument oOutputDocument = new OutputDocument();
			InputDocument oInputDocument = new InputDocument();

			DataTable dtWarrant = CopyTable(oWarrantAnalysis.MainTable, "dtWarrant", "", "PartnerSourceID, NumberInt, Number, DateIssue");

			string sText = "Анализ журнала выдачи доверенностей за период " + dDateBeg.ToString("dd.MM.yyyy") + " - " + dDateEnd.ToString("dd.MM.yyyy") + 
				sEol;

			int nPartnerSourceID = -1;
			int nNumberInt = -1;
			int nNumberIntOld = -1;
			string sNumber = "";
			bool bOK = true; 
			foreach(DataRow rW in dtWarrant.Rows)
			{
				oWarrantAnalysis.FillOne(rW);

				// новый партнер
				if (nPartnerSourceID != oWarrantAnalysis.PartnerSourceID)
				{
					sText += sEol + 
						"Доверенности выданы фирмой: " + oWarrantAnalysis.PartnerSourceName +
						sEol;
					nPartnerSourceID = oWarrantAnalysis.PartnerSourceID;

					nNumberInt = -1;
					nNumberIntOld = -1;
					sNumber = "";
					bOK = true; 
				}

				nNumberInt = oWarrantAnalysis.NumberInt; 
				sNumber = oWarrantAnalysis.Number; 

				// нумерация
				if (nNumberIntOld != -1)
				{
					if (nNumberInt == nNumberIntOld)
					{
						sText += sNumber + "(" + nNumberInt.ToString().Trim() + "): доверенности с одинаковым порядковым номером" + 
							sEol;
						bOK = false;
					}
					if (nNumberInt != nNumberIntOld + 1)
					{
						sText += sNumber + " (" + nNumberIntOld.ToString() + " - " + nNumberInt.ToString().Trim() + "): пропуск в порядковых номерах доверенностей" +
							sEol;
						bOK = false;
					}
				}

				// заказы

				// заказ на отгрузку 
				if (oWarrantAnalysis.OutputDocumentID.HasValue)
				{
					oOutputDocument.ID = (int)oWarrantAnalysis.OutputDocumentID;
					oOutputDocument.FillDataAsync();
					if (oOutputDocument.MainTable.Rows.Count == 0)
					{
						sText += sNumber + ": не найден заказ на отгрузку с кодом " + oWarrantAnalysis.OutputDocumentID + 
							sEol;
						bOK = false;
					}
					else
					{
						oOutputDocument.FillOne();
						// номера
						if (oOutputDocument.WarrantNumber != sNumber)
						{
							sText += sNumber + ": не совпадают номера доверенностей в журнале и в заказе на отгрузку (" + oOutputDocument.WarrantNumber.ToString().Trim() + ")" + 
								sEol;
							bOK = false;
						}
						// 
						if (oOutputDocument.IsWarrantReturned && !oWarrantAnalysis.IsReturned)
						{
							sText += sNumber + ": в заказе на отгрузку доверенность возвращена, в журнале нет" + 
								sEol;
							bOK = false;
						}
						if (!oOutputDocument.IsWarrantReturned && oWarrantAnalysis.IsReturned)
						{
							sText += sNumber + ": в журнале доверенность возвращена, в заказе на отгрузку нет" +
								sEol;
							bOK = false;
						}
						if (oWarrantAnalysis != null && oWarrantAnalysis.CurrencyID != null &&
							(oOutputDocument.GetMoneyConfirmed != oWarrantAnalysis.Amount ||
							 oOutputDocument.GetCurrencyID != oWarrantAnalysis.CurrencyID))
						{
							sText += sNumber + ": сумма/валюта в журнале (" + ((decimal)oWarrantAnalysis.Amount).ToString("#####0.00") + oWarrantAnalysis.CurrencyName +
								") и в заказе на отгрузку (" + oOutputDocument.GetMoneyConfirmed.ToString("#####0.00") + oOutputDocument.GetCurrencyName + ") не совпадают" + 
								sEol;
							bOK = false;
						}
					}
				}

				// заказ на поставку 
				if (oWarrantAnalysis.InputDocumentID.HasValue)
				{
					oInputDocument.ID = (int)oWarrantAnalysis.InputDocumentID;
					oInputDocument.FillDataAsync();
					if (oInputDocument.MainTable.Rows.Count != 1)
					{
						sText += sNumber + ": не найден заказ на поставку с кодом " + oWarrantAnalysis.InputDocumentID + 
							sEol;
						bOK = false;
					}
					else
					{
						oInputDocument.FillOne();
						// номера
						if (oInputDocument.WarrantNumber != sNumber)
						{
							sText += sNumber + ": не совпадают номера доверенностей в журнале и в заказе на поставку (" + oInputDocument.WarrantNumber.ToString().Trim() + ")" + 
								sEol;
							bOK = false;
						}
					}
				}
				// проверки законечены, переходим к следующей доверенности в списке

				nNumberIntOld = (int)rW["NumberInt"];
			}
			if (bOK)
			{
				sText += "OK" + sEol;
			}

			// анализ таблиц заказов 

			// заказы на отгрузку 
			bOK = true;
			oOutputDocument.FilterDateBeg = dDateBeg;
			oOutputDocument.FilterDateEnd = dDateEnd;
			oOutputDocument.FillDataAsync();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при анализе списка заказов на отгрузку...");
			}
			else
			{
				if (oOutputDocument.MainTable.Rows.Count > 0)
				{
					sText += sEol + 
						"Анализ списка заказов на отгрузку: " + 
						sEol;

					string sOutputDocument = ""; 
					foreach (DataRow rO in oOutputDocument.MainTable.Rows)
					{ 
						oOutputDocument.FillOne();
						sOutputDocument = oOutputDocument.ID.ToString().Trim();
						sNumber = oOutputDocument.WarrantNumber;
						if (sNumber == null) sNumber = ""; 

						// наличие доверенности 
						if (oOutputDocument.IsConfirmed)
						{
							if (oOutputDocument.PF_WarrantNeed && sNumber.Length == 0)
							{
								sText += sOutputDocument + ": не определен номер доверенности для заказа, где требуется доверенность" + 
									sEol;
								bOK = false;
							}
						}
						if (!oOutputDocument.PF_WarrantNeed && sNumber.Length > 0)
						{
							sText += sOutputDocument + ": определен номер доверенности (" + sNumber + ") для заказа, где не требуется доверенность" +
								sEol;
							bOK = false;
						}

						if (oOutputDocument.PF_WarrantNeed && sNumber.Length > 0)
						{
							oWarrantAnalysis.FilterOutputsDocumentsList = sOutputDocument;
							oWarrantAnalysis.FillDataAsync();
							if (oWarrantAnalysis.MainTable.Rows.Count == 0)
							{
								sText += sOutputDocument + ": в журнале не найдена доверенность (" + sNumber + ") для заказа" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.MainTable.Rows.Count > 1)
							{
								sText += sOutputDocument + ": в журнале найдено несколько доверенностей для заказа (" + sNumber + ")" + 
									sEol;
								bOK = false;
							}

							oWarrantAnalysis.FilterNumberContext = sNumber;
							oWarrantAnalysis.FilterPartnersSourceList = oOutputDocument.PartnerSourceID.ToString();
							oWarrantAnalysis.FilterDateBeg = oOutputDocument.DateOutput.AddDays(-10);
							oWarrantAnalysis.FilterDateEnd = oOutputDocument.DateOutput.AddDays(10);
							oWarrantAnalysis.FillDataAsync();
							if (oWarrantAnalysis.MainTable.Rows.Count == 0)
							{
								sText += sOutputDocument + ": в журнале не найдена доверенность по номеру (" + sNumber + "), указанному в заказе" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.MainTable.Rows.Count > 1)
							{
								sText += sOutputDocument + ": в журнале найдено несколько доверенностей по номеру (" + sNumber + "), указанному в заказе" + 
									sEol;
								bOK = false;
							}

							oWarrantAnalysis.FillOne();
							if (oWarrantAnalysis.OutputDocumentID != oOutputDocument.ID)
							{
								sText += sOutputDocument + ": в журнале найдена доверенность по номеру (" + sNumber + "), но в ней указан другой заказ" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.PartnerSourceID != oOutputDocument.PartnerSourceID ||
								oWarrantAnalysis.PartnerTargetID != oOutputDocument.PartnerTargetID)
							{
								sText += sOutputDocument + ": в журнале найдена доверенность по номеру (" + sNumber + "), но в ней указан другой клиент" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.Amount != null && oWarrantAnalysis.CurrencyID != null &&
								((decimal)oWarrantAnalysis.Amount != oOutputDocument.GetMoneyConfirmed ||
								 (int)oWarrantAnalysis.CurrencyID != oOutputDocument.GetCurrencyID) )
							{
								sText += sOutputDocument + ": в журнале найдена доверенность по номеру (" + sNumber + "), но в ней указана другая сумма" + 
									sEol;
								bOK = false;
							}
						}

						if (!oOutputDocument.PF_WarrantNeed)
						{
							oWarrantAnalysis.FilterOutputsDocumentsList = sOutputDocument;
							if (oWarrantAnalysis.MainTable.Rows.Count > 0)
							{
								sText += sOutputDocument + ": в журнале найдена доверенность (" + oWarrantAnalysis.MainTable.Rows[0]["Number"].ToString() + ") для заказа, для которого она не требуется" + 
									sEol;
								bOK = false;
							}
						}

						// переходим к след.заказу
					}
					if (bOK)
					{
						sText += "OK";
					}
				}
			}

			// здесь должны быть аналогичные проверки для заказов на поставку InputsDocuments
			bOK = true; 

			// выводим отчет
			WaitOff(this);
			StartForm(new frmSysTextReport(sText));

			/*
			string sFileName = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserLocPath + "WarrantsAnalysis.txt";
			File.AppendAllText(sFileName, sText, Encoding.Default);
			StartForm(new frmSysTextReport(true, sFileName)); 
			*/
		}

		private void WarrantsReturn(bool bReturn)
		{
			if (grdData.CurrentRow == null)
				return;
			if (!oWarrantCur.ID.HasValue)
				return;

			// перечитать
			oWarrantCur.ReFillOne((int)oWarrantCur.ID);

			if (bReturn)
			{
				// проверки
				if (oWarrantCur.DateReturn != null)
				{
					RFMMessage.MessageBoxError("Доверенность уже возвращена...");
					return;
				}
				// 

				if (RFMMessage.MessageBoxYesNo("Отметить возврат доверенности?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oWarrantCur.Return((int)oWarrantCur.ID);
					WaitOff(this);
					if (bResult && oWarrantCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("Зафиксирован возврат доверенности.");
					}
					grdData_Restore();
				}
			}
			else
			{
				// проверки
				if (oWarrantCur.DateReturn == null)
				{
					RFMMessage.MessageBoxError("Доверенность не была возвращена...");
					return;
				}
				// 

				if (RFMMessage.MessageBoxYesNo("Снять отметку возврата доверенности?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oWarrantCur.UnReturn((int)oWarrantCur.ID);
					WaitOff(this);
					if (bResult && oWarrantCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("Отметка возврата доверенности снята.");
					}
					grdData_Restore();
				}
			}
		}

	#endregion

	#region Filters Choose

		#region Partners Source

		private void btnPartnersSourceChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oPartner = new Partner();
			oPartner.FillDataAsync();
			if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных (партнеры)...");
				return;
			}
			if (oPartner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (партнеры)...");
				return;
			}

			if (StartForm(new frmSelectID(this, oPartner.MainTable, "Name,Actual", "Фирмы,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnPartnersSourceClear_Click(null, null);
					return;
				}

				sSelectedPartnersSourceIDList = "," + _SelectedIDList;

				txtPartnersSourceChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtPartnersSourceChoosen, txtPartnersSourceChoosen.Text);

				tabData.IsNeedRestore = true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnPartnersSourceClear_Click(object sender, EventArgs e)
		{
			tabData.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPartnersSourceChoosen, "не выбраны");
			sSelectedPartnersSourceIDList = "";
			txtPartnersSourceChoosen.Text = "";
		}

		#endregion Partners Source

		#region Partners Target

		private void btnPartnersTargetChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oPartner = new Partner();
			oPartner.FillDataAsync();
			if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных (плательщики/поставщики)...");
				return;
			}
			if (oPartner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (плательщики/поставщики)...");
				return;
			}

			if (StartForm(new frmSelectID(this, oPartner.MainTable, "Name,ZoneName,Actual", "Плательщик/Поставщик,Зона,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnPartnersTargetClear_Click(null, null);
					return;
				}

				sSelectedPartnersTargetIDList = "," + _SelectedIDList;

				txtPartnersTargetChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtPartnersTargetChoosen, txtPartnersTargetChoosen.Text);

				tabData.IsNeedRestore = true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnPartnersTargetClear_Click(object sender, EventArgs e)
		{
			tabData.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPartnersTargetChoosen, "не выбраны");
			sSelectedPartnersTargetIDList = "";
			txtPartnersTargetChoosen.Text = "";
		}

		#endregion Partner Target

		#region Employees

		private void btnEmployeesChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Employee oEmployee = new Employee();
			oEmployee.FillDataAsync();
			if (oEmployee.ErrorNumber != 0 || oEmployee.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных (получатели)...");
				return;
			}
			if (oEmployee.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (получатели)...");
				return;
			}

			if (StartForm(new frmSelectID(this, oEmployee.MainTable, "Name,JobName,IsDriver", "Сотрудник,Должность,Вод.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnEmployeesClear_Click(null, null);
					return;
				}

				sSelectedEmployeesIDList = "," + _SelectedIDList;
				txtEmployeesChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtEmployeesChoosen, txtEmployeesChoosen.Text);

				tabData.IsNeedRestore = true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnEmployeesClear_Click(object sender, EventArgs e)
		{
			tabData.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtEmployeesChoosen, "не выбраны");
			sSelectedEmployeesIDList = "";
			txtEmployeesChoosen.Text = "";
		}

		#endregion Employees

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date.AddDays(-7); 
			dtrDates.dtpEndDate.Value = DateTime.Now.Date.AddDays(1);

			btnPartnersSourceClear_Click(null, null);
			btnPartnersTargetClear_Click(null, null);
			btnEmployeesClear_Click(null, null);

			optIsMoneyAny.Checked = true;
			optIsReturnedAny.Checked = true;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabData.IsNeedRestore = true;
		}

	#endregion Terms clear


    }
}