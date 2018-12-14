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
	public partial class frmFacturesNumbers : RFMFormChild
	{
		private FactureNumber oFactureList; //список счетов-фактур
		private FactureNumber oFactureCur; //текущий счет-фактура

		// для фильтров
		public string _SelectedIDList;
		public string _SelectedText;

		private string sSelectedPartnersSourceIDList = "";
		private string sSelectedPartnersTargetIDList = "";

		public frmFacturesNumbers()
		{
			oFactureList = new FactureNumber();
			oFactureCur = new FactureNumber();
			if (oFactureList.ErrorNumber != 0 ||
				oFactureCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmFacturesNumbers_Load(object sender, EventArgs e)
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
							oFactureCur.ID = Convert.ToInt32(r["ID"]);
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
				oFactureCur.ClearOne();
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			else
			{
				DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
				oFactureCur.FillOne(r);
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
			// здесь - не исп. 
			/*
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}
			*/

			// строка данных
			// здесь - не исп.
			/*
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
			*/ 
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

			oFactureCur.ClearOne();

			oFactureList.ClearError();
			oFactureList.ClearFilters();
			oFactureList.ID = null;
			oFactureList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oFactureList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oFactureList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// номер контекст
			if (txtFactureNumberContext.Text.Trim().Length > 0)
			{
				oFactureList.FilterNumberContext = txtFactureNumberContext.Text.Trim();
			}

			// партнеры
			if (sSelectedPartnersSourceIDList.Length > 0)
			{
				oFactureList.FilterPartnersSourceList = sSelectedPartnersSourceIDList;
			}
			if (sSelectedPartnersTargetIDList.Length > 0)
			{
				oFactureList.FilterPartnersTargetList = sSelectedPartnersTargetIDList;
			}

			// коды заказов на отгрузку

			//

			grdData.GetGridState();

			oFactureList.FillData();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oFactureList.MainTable);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oFactureList.ErrorNumber == 0);
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
				if (!oFactureCur.ID.HasValue)
					return;

				// перечитать
				oFactureCur.ReFillOne((int)oFactureCur.ID);

				// проверки
				if (oFactureCur.OutputDocumentID.HasValue)
				{
					OutputDocument oOutputDocumentTemp = new OutputDocument();
					oOutputDocumentTemp.ID = oFactureCur.OutputDocumentID;
					oOutputDocumentTemp.ReFillOne((int)oOutputDocumentTemp.ID);
					if (oOutputDocumentTemp.DateBring != null)
					{
						RFMMessage.MessageBoxError("Заказ уже доставлен клиенту...\nУдаление не выполняется.");
						return;
					}
				}

				if (RFMMessage.MessageBoxYesNo("Удалить счет-фактуру?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oFactureCur.Delete((int)oFactureCur.ID);
					WaitOff(this);
					if (bResult && oFactureCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("Счет-фактура удален.");
					}
					else
					{
						RFMMessage.MessageBoxError("Ошибка при удалении счета-фактуры...");
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
		private void FacturesAnalysis()
		{
			// тестирование счетов-фактур за период
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
					dDateEnd = Convert.ToDateTime("31.12.2059");
			}

			FactureNumber oFactureAnalysis = new FactureNumber();
			oFactureAnalysis.FilterDateBeg = dDateBeg;
			oFactureAnalysis.FilterDateEnd = dDateEnd;
			oFactureAnalysis.FillData();
			if (oFactureAnalysis.ErrorNumber != 0 || oFactureAnalysis.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при анализе списка счетов-фактур...");
				return;
			}
			if (oFactureAnalysis.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных о счетах-фактурах за период...");
				return;
			}

			WaitOn(this);

			string sEol = Environment.NewLine;

			OutputDocument oOutputDocument = new OutputDocument();

			DataTable dtFacture = CopyTable(oFactureAnalysis.MainTable, "dtFacture", "", "PartnerSourceID, NumberInt, Number, DateIssue");

			string sText = "Анализ журнала выдачи счетов-фактур за период " + dDateBeg.ToString("dd.MM.yyyy") + " - " + dDateEnd.ToString("dd.MM.yyyy") + 
				sEol;

			int nPartnerSourceID = -1;
			int nNumberInt = -1;
			int nNumberIntOld = -1;
			string sNumber = "";
			bool bOK = true; 
			foreach(DataRow rW in dtFacture.Rows)
			{
				oFactureAnalysis.FillOne(rW);

				// новый партнер
				if (nPartnerSourceID != oFactureAnalysis.PartnerSourceID)
				{
					sText += sEol + 
						"Cчета-фактуры выданы фирмой: " + oFactureAnalysis.PartnerSourceName +
						sEol;
					nPartnerSourceID = oFactureAnalysis.PartnerSourceID;

					nNumberInt = -1;
					nNumberIntOld = -1;
					sNumber = "";
					bOK = true; 
				}

				nNumberInt = oFactureAnalysis.NumberInt; 
				sNumber = oFactureAnalysis.Number; 

				// нумерация
				if (nNumberIntOld != -1)
				{
					if (nNumberInt == nNumberIntOld)
					{
						sText += sNumber + "(" + nNumberInt.ToString().Trim() + "): счета-фактуры с одинаковым порядковым номером" + 
							sEol;
						bOK = false;
					}
					if (nNumberInt != nNumberIntOld + 1)
					{
						sText += sNumber + " (" + nNumberIntOld.ToString() + " - " + nNumberInt.ToString().Trim() + "): пропуск в порядковых номерах счетов-фактур" +
							sEol ;
						bOK = false;
					}
				}

				// заказы

				// заказ на отгрузку 
				if (oFactureAnalysis.OutputDocumentID.HasValue)
				{
					oOutputDocument.ID = (int)oFactureAnalysis.OutputDocumentID;
					oOutputDocument.FillData();
					if (oOutputDocument.MainTable.Rows.Count == 0)
					{
						sText += sNumber + ": не найден расходный документ с кодом " + oFactureAnalysis.OutputDocumentID + 
							sEol;
						bOK = false;
					}
					else
					{
						oOutputDocument.FillOne();
						// номера
						if (oOutputDocument.FactureNumber != sNumber)
						{
							sText += sNumber + ": не совпадают номера счетов-фактур в журнале и в расходном документе (" + oOutputDocument.FactureNumber.ToString().Trim() + ")" + 
								sEol;
							bOK = false;
						}
					}
				}

				// проверки законечены, переходим к следующей счета-фактуры в списке

				nNumberIntOld = (int)rW["NumberInt"];
			}
			if (bOK)
			{
				sText += "OK" + sEol;
			}

			// анализ таблицы заказов на отгрузку 
			bOK = true;
			oOutputDocument.FilterDateBeg = dDateBeg;
			oOutputDocument.FilterDateEnd = dDateEnd;
			oOutputDocument.FillData();
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
						sNumber = oOutputDocument.FactureNumber;
						if (sNumber == null) sNumber = ""; 

						// наличие счета-фактуры 
						if (oOutputDocument.IsConfirmed)
						{
							if (oOutputDocument.PF_FactureNeed && sNumber.Length == 0)
							{
								sText += sOutputDocument + ": не определен номер счета-фактуры для заказа, где требуется счет-фактура" + 
									sEol;
								bOK = false;
							}
						}
						if (!oOutputDocument.PF_FactureNeed && sNumber.Length > 0)
						{
							sText += sOutputDocument + ": определен номер счета-фактуры (" + sNumber + ") для заказа, где не требуется счет-фактура" +
								sEol;
							bOK = false;
						}

						if (oOutputDocument.PF_FactureNeed && sNumber.Length > 0)
						{
							oFactureAnalysis.FilterOutputsDocumentsList = sOutputDocument;
							oFactureAnalysis.FillData();
							if (oFactureAnalysis.MainTable.Rows.Count == 0)
							{
								sText += sOutputDocument + ": в журнале не найден счет-фактура (" + sNumber + ") для заказа" + 
									sEol;
								bOK = false;
							}
							if (oFactureAnalysis.MainTable.Rows.Count > 1)
							{
								sText += sOutputDocument + ": в журнале найдено несколько счетов-фактур для заказа (" + sNumber + ")" + 
									sEol;
								bOK = false;
							}

							oFactureAnalysis.FilterNumberContext = sNumber;
							oFactureAnalysis.FilterPartnersSourceList = oOutputDocument.PartnerSourceID.ToString();
							oFactureAnalysis.FilterDateBeg = oOutputDocument.DateOutput.AddDays(-10);
							oFactureAnalysis.FilterDateEnd = oOutputDocument.DateOutput.AddDays(10);
							oFactureAnalysis.FillData();
							if (oFactureAnalysis.MainTable.Rows.Count == 0)
							{
								sText += sOutputDocument + ": в журнале не найден счет-фактура по номеру (" + sNumber + "), указанному в заказе" + 
									sEol;
								bOK = false;
							}
							if (oFactureAnalysis.MainTable.Rows.Count > 1)
							{
								sText += sOutputDocument + ": в журнале найдено несколько счетов-фактур по номеру (" + sNumber + "), указанному в заказе" + 
									sEol;
								bOK = false;
							}

							oFactureAnalysis.FillOne();
							if (oFactureAnalysis.OutputDocumentID != oOutputDocument.ID)
							{
								sText += sOutputDocument + ": в журнале найден счет-фактура по номеру (" + sNumber + "), но в нем указан другой заказ" + 
									sEol;
								bOK = false;
							}
							if (oFactureAnalysis.PartnerSourceID != oOutputDocument.PartnerSourceID ||
								oFactureAnalysis.PartnerTargetID != oOutputDocument.PartnerTargetID)
							{
								sText += sOutputDocument + ": в журнале найден счет-фактура по номеру (" + sNumber + "), но в нем указан другой клиент" + 
									sEol;
								bOK = false;
							}
						}

						if (!oOutputDocument.PF_FactureNeed)
						{
							oFactureAnalysis.FilterOutputsDocumentsList = sOutputDocument;
							if (oFactureAnalysis.MainTable.Rows.Count > 0)
							{
								sText += sOutputDocument + ": в журнале найден счет-фактура (" + oFactureAnalysis.MainTable.Rows[0]["Number"].ToString() + ") для заказа, для которого он не требуется" + 
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

			// здесь должны быть аналогичные проверки для заказов на поставку 
			bOK = true;

			// выводим отчет
			WaitOff(this);
			StartForm(new frmSysTextReport(sText));
		}

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}

	#endregion

	#region Filters Choose

		#region Partners Source

		private void btnPartnersSourceChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oPartner = new Partner();
			oPartner.FillData();
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
			oPartner.FillData();
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

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date.AddDays(-7); 
			dtrDates.dtpEndDate.Value = DateTime.Now.Date.AddDays(1);

			btnPartnersSourceClear_Click(null, null);
			btnPartnersTargetClear_Click(null, null);

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabData.IsNeedRestore = true;
		}

	#endregion Terms clear

		private void mniFacturesAnalysis_Click(object sender, EventArgs e)
		{
			FacturesAnalysis();
		}

	}
}