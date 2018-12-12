using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics 
{
	// форма для выбора одной или нескольких записей о заказах на поставку
	// возвращает в родительскую форму:
	// с пометкой:  string _SelectedInputsDocumentsIDList (список кодов отмеченных записей, через запятую, вида: 1,2,23,) 
	// без пометки: int _SelectedInputDocumentID (код текущей записи)
	// string _SelectedInputsDocumentsText (список дата + клиент для первых 3-х отмеченных заказов)

	public partial class frmSelectOneInputDocument : RFMFormChild
	{
		private Form parentForm;
		private bool useCheck;

		private InputDocument oInputDocument; // заказ с начальными условиями

		private InputDocument oInputDocumentList; //список заказов на поставку
		private InputDocument oInputDocumentCur; //текущий заказ на поставку

		private Host oHost;
		private int? nUserHostID = null;

		// для фильтров
		public string _SelectedPackingsIDList;
		public string _SelectedPackingsAliasText;
		private string sSelectedPackingsIDList = "";

		int nFirstCntRecords = 3; // количество первых записей для наборного текстового значения


		public frmSelectOneInputDocument(Form _parentForm, bool _useCheck, InputDocument _oInputDocument)
		{
			oInputDocumentList = new InputDocument();
			oInputDocumentCur = new InputDocument();
			if (oInputDocumentList.ErrorNumber != 0 ||
				oInputDocumentCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oHost = new Host();
			if (oHost.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();

				parentForm = _parentForm;
				useCheck = _useCheck;
				oInputDocument = _oInputDocument;
			}
		}

		private void frmSelectOneInputDocument_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			lblHosts.Visible =
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled =
				(oHost.Count() > 1 && !nUserHostID.HasValue);

			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			btnClearTerms_Click(null, null);

			tcList.Init();

			grdInputsDocuments.IsCheckerInclude = useCheck;
			grdInputsDocuments.IsCheckerShow = useCheck;

			if (useCheck)
				Text = "Выберите несколько приходных документов";
			else
				Text = "Выберите приходный документ";

			dtrDates.dtpBegDate.Select();

			RFMCursorWait.Set(false);
		}

	#region Tab Restore

		private bool tabTerms_Restore()
		{
			btnGo.Enabled = false;
			
			dtrDates.dtpBegDate.Select();
			
			return (true);
		}

		private bool tabInputsDocuments_Restore()
		{
			grdInputsDocuments_Restore();
			if (grdInputsDocuments.Rows.Count > 0)
			{
				grdInputsDocuments.Select();
				btnGo.Enabled = true;
			}
			else
			{
				btnGo.Enabled = false;
			}
			
			return (true);
		}

		private bool tabInputsDocumentsGoods_Restore()
		{
			return (grdInputsDocumentsGoods_Restore());
		}

	#endregion Tab Resore

	#region TimerTick, CellFormatting

		private void grdInputsDocuments_CurrentRowChanged(object sender)
		{
			if (grdInputsDocuments.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;
			
			if (grdInputsDocuments.CurrentRow == null)
			   return;
			
			int rowIndex = grdInputsDocuments.CurrentRow.Index;

 			// заказы на поставку
			if (grdInputsDocuments.IsStatusRow(rowIndex))
			{
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow r = ((DataRowView)((DataGridViewRow)grdInputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
				oInputDocumentCur.FillOne(r);
			}
			tcInputsDocumentsGoods.SetAllNeedRestore(true);
		}

		private void grdInputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			string sGridName = grd.Name.ToUpper();
			
			if (grd.DataSource == null)
				return;

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("RESULT") ||
					grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();
			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{ 
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Check;
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void grdInputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных 
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;

			if (sColumnName.Contains("QNT") ||
				sColumnName.Contains("INBOX"))
			{
				if (!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"] &&
					!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
				{
					e.CellStyle.Format = "### ###.000";
				}
				else
				{
					e.CellStyle.Format = "### ###";
				}
			}

			if ((sColumnName.Contains("QNT") || sColumnName.Contains("BOX") || sColumnName.Contains("PAL")) &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

	#endregion 

	#region Restore

		private bool grdInputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputDocumentCur.ClearOne();

			oInputDocumentList.ClearError();
			oInputDocumentList.ClearFilters();
			oInputDocumentList.ID = null;
			oInputDocumentList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oInputDocumentList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oInputDocumentList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oInputDocumentList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oInputDocumentList.FilterDeliveryNeed = false;
			}

			// клиенты-поставщики
			if (txtPartnerSourceNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerSource = new Partner();
				oPartnerSource.FilterNameContext = txtPartnerSourceNameContext.Text.Trim();
				oPartnerSource.FillDataAsync();
				oInputDocumentList.FilterPartnersSourceList = "";
				foreach (DataRow rcs in oPartnerSource.MainTable.Rows)
					oInputDocumentList.FilterPartnersSourceList += rcs["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersSource.IsSelectedExist)
			{
				oInputDocumentList.FilterPartnersSourceList += ucSelectRecordID_PartnersSource.GetIdString();
			}

			// клиенты-получатели 
			if (txtPartnerTargetNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerTarget = new Partner();
				oPartnerTarget.FilterNameContext = txtPartnerTargetNameContext.Text.Trim();
				oPartnerTarget.FillDataAsync();
				oInputDocumentList.FilterPartnersTargetList = "";
				foreach (DataRow rct in oPartnerTarget.MainTable.Rows)
					oInputDocumentList.FilterPartnersTargetList += rct["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersTarget.IsSelectedExist)
			{
				oInputDocumentList.FilterPartnersTargetList += ucSelectRecordID_PartnersTarget.GetIdString();
			}

			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oInputDocumentList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// рейс?
			if (optTripExists.Checked)
			{
				oInputDocumentList.FilterTripExists = true;
			}
			if (optTripExistsNot.Checked)
			{
				oInputDocumentList.FilterTripExists = false;
			}

			// выбранные товары
			if (sSelectedPackingsIDList.Length > 0)
			{
				oInputDocumentList.FilterPackingsList = sSelectedPackingsIDList;
			}

			// подтверждение
			if (optInputsDocumentsIsConfirmedNot.Checked)
			{
				oInputDocumentList.FilterIsConfirmed = false;
			}
			if (optInputsDocumentsIsConfirmed.Checked)
			{
				oInputDocumentList.FilterIsConfirmed = true;
			}

			// по рейсу
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0)
			{
				Trip oTripFilter = new Trip();
				oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				oTripFilter.FillDataAsync();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ",";
				}
				oInputDocumentList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oInputDocumentList.FilterTripsList == null)
					oInputDocumentList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oInputDocumentList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			// хосты
			if (nUserHostID.HasValue)
			{
				oInputDocumentList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oInputDocumentList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}

			// начальные условия 
			if (oInputDocument != null)
			{
				if (oInputDocument.FilterOwnersList != null)
					oInputDocumentList.FilterOwnersList = oInputDocument.FilterOwnersList;
				if (oInputDocument.FilterPartnersSourceList != null)
					oInputDocumentList.FilterPartnersSourceList = oInputDocument.FilterPartnersSourceList;
				if (oInputDocument.FilterPartnersTargetList != null)
					oInputDocumentList.FilterPartnersTargetList = oInputDocument.FilterPartnersTargetList;
				if (oInputDocument.FilterHostsList != null)
				{
					if (!nUserHostID.HasValue)
						oInputDocumentList.FilterHostsList = oInputDocument.FilterHostsList;
					else
					{ 
						if (!((string)("," + oInputDocument.FilterHostsList + ",")).Contains("," + nUserHostID.ToString().Trim() + ","))
							oInputDocumentList.FilterHostsList = "-1";
					}
				}
			}
			//

			grdInputsDocumentsGoods.DataSource = null;

			grdInputsDocuments.GetGridState();

			oInputDocumentList.FillDataAsync();
			grdInputsDocuments.IsLockRowChanged = true;
			grdInputsDocuments.Restore(oInputDocumentList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oInputDocumentList.ErrorNumber == 0);
		}

		private bool grdInputsDocumentsGoods_Restore()
		{
			grdInputsDocumentsGoods.GetGridState();
			grdInputsDocumentsGoods.DataSource = null;
			if (grdInputsDocuments.Rows.Count == 0 || 
				oInputDocumentCur.ID == null ||
				(grdInputsDocuments.CurrentRow != null && grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index)))
				return (true);

			oInputDocumentList.FillTableInputsDocumentsGoods((int)oInputDocumentCur.ID);
			grdInputsDocumentsGoods.Restore(oInputDocumentList.TableInputsDocumentsGoods);
			return (oInputDocumentList.ErrorNumber == 0);
		}

	#endregion 
		
	#region Buttons

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			// возвращаем код/список кодов заказов в родительскую форму

			string _SelectedInputsDocumentsIDList = null;
			int? _SelectedInputDocumentID = null;
			string _SelectedInputsDocumentsText = "";

			if (grdInputsDocuments.Rows.Count > 0)
			{
				if (useCheck && grdInputsDocuments.IsCheckerShow)
				{
					// список ID 
					_SelectedInputsDocumentsIDList = "";
					_SelectedInputsDocumentsText = "";

					DataView dMarked = new DataView(oInputDocumentList.MainTable);
					dMarked.RowFilter = "IsMarked = true";
					dMarked.Sort = grdInputsDocuments.GridSource.Sort;
					int i = 0;
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r["ID"]))
						{
							_SelectedInputsDocumentsIDList += r["ID"].ToString() + ",";

							if (i < nFirstCntRecords)
							{
								_SelectedInputsDocumentsText += Convert.ToDateTime(r["DateInput"]).ToString("dd.MM.yyyy") + " " + r["PartnerTargetName"].ToString() + ", ";
							}
							else
							{
								if (i == nFirstCntRecords)
								{
									_SelectedInputsDocumentsText += "...";
								}
							}
							i++;
						}
					}
					if (_SelectedInputsDocumentsIDList.Length == 0)
					{
						// нет отметок - берем текущую запись
						if (grdInputsDocuments.CurrentRow != null)
						{
							_SelectedInputsDocumentsIDList = grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value.ToString() + ",";
							_SelectedInputsDocumentsText = grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_DateInput"].Value.ToString().Substring(0, 10) + " " +
								grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_PartnerTargetName"].Value.ToString().Trim();
						}
					}

					// приводим наборное текстовое поле к виду: (5) раз, два, три, ...
					if (_SelectedInputsDocumentsIDList.Length == 0)
					{
						_SelectedInputsDocumentsIDList = null;
						_SelectedInputsDocumentsText = "";
					}
					else
					{
						_SelectedInputsDocumentsText = _SelectedInputsDocumentsText.Trim();
						if (_SelectedInputsDocumentsText.Substring(_SelectedInputsDocumentsText.Length - 1, 1) == ",")
						{
							_SelectedInputsDocumentsText = _SelectedInputsDocumentsText.Substring(0, _SelectedInputsDocumentsText.Length - 1);
						}
						_SelectedInputsDocumentsText = "(" + RFMUtilities.Occurs(_SelectedInputsDocumentsIDList, ",").ToString() + "): " +
							_SelectedInputsDocumentsText;
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedInputsDocumentsIDList", _SelectedInputsDocumentsIDList);
					RFMUtilities.SetFormField(parentForm, "_SelectedInputsDocumentsText", _SelectedInputsDocumentsText);
				}
				else
				{
					// ID текущей строки
					if (grdInputsDocuments.CurrentRow != null)
					{
						_SelectedInputDocumentID = Convert.ToInt32(grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value);
						_SelectedInputsDocumentsText = grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_DateInput"].Value.ToString().Substring(0, 10) + " " +
							grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_PartnerTargetName"].Value.ToString().Trim();
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedInputDocumentID", _SelectedInputDocumentID);
					RFMUtilities.SetFormField(parentForm, "_SelectedInputsDocumentsText", _SelectedInputsDocumentsText);
				}
			}
			else
			{
				RFMMessage.MessageBoxInfo("Не выбрано ни одного приходного документа...");
			}

			DialogResult = DialogResult.Yes;
			Dispose();
		}

	#endregion
		
	#region Filters Choose

		#region Partners

		private void ucSelectRecordID_PartnersSource_Restore()
		{
			if (ucSelectRecordID_PartnersSource.sourceData == null)
			{
				Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, true, false))
				{
					ucSelectRecordID_PartnersSource.Restore(oPartner.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_PartnersSource.Restore();
			}
		}

		private void ucSelectRecordID_PartnersTarget_Restore()
		{
			if (ucSelectRecordID_PartnersTarget.sourceData == null)
			{
				Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, false, true))
				{
					ucSelectRecordID_PartnersTarget.Restore(oPartner.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_PartnersTarget.Restore();
			}
		}

		#endregion Partners

		#region Owners

		private void ucSelectRecordID_Owners_Restore()
		{
			if (ucSelectRecordID_Owners.sourceData == null)
			{
				Partner oOwner = new Partner();
				if (Utilities.FillData_Owners(oOwner))
				{
					ucSelectRecordID_Owners.Restore(oOwner.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Owners.Restore();
			}
		}

		#endregion Owners

		#region Hosts

		private void ucSelectRecordID_Hosts_Restore()
		{
			if (ucSelectRecordID_Hosts.sourceData == null)
			{
				if (Utilities.FillData_Hosts(oHost))
				{
					ucSelectRecordID_Hosts.Restore(oHost.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Hosts.Restore();
			}
		}

		#endregion Hosts

        #region Packings

        private void btnPackingsChoose_Click(object sender, EventArgs e)
		{
			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";

			if (StartForm(new frmSelectOnePacking(this, true)) == DialogResult.Yes)
			{
				if (_SelectedPackingsIDList == null || !_SelectedPackingsIDList.Contains(","))
				{
					btnPackingsClear_Click(null, null);
					return;
				}

				sSelectedPackingsIDList = "," + _SelectedPackingsIDList;
				txtPackingsChoosen.Text = _SelectedPackingsAliasText;
				ttToolTip.SetToolTip(txtPackingsChoosen, txtPackingsChoosen.Text);

				tabInputsDocuments.IsNeedRestore = true;
			}

			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";
		}

		private void btnPackingsClear_Click(object sender, EventArgs e)
		{
			tabInputsDocuments.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPackingsChoosen, "не выбраны");
			sSelectedPackingsIDList = "";
			txtPackingsChoosen.Text = "";
		}

		#endregion Packings

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			RFMCursorWait.LockWindowUpdate(Handle);

			dtrDates.dtpBegDate.Value = DateTime.Now.Date;
			dtrDates.dtpEndDate.Value = DateTime.Now.Date;

			optDeliveryNeed.Checked = true;

			txtPartnerSourceNameContext.Text = "";
			ucSelectRecordID_PartnersSource.ClearData();

			txtPartnerTargetNameContext.Text = "";
			ucSelectRecordID_PartnersTarget.ClearData();

			ucSelectRecordID_Owners.ClearData();

			optInputsDocumentsIsConfirmedAll.Checked = true;

			optTripExistsAll.Checked = true;
			numTripID.Value = 0;
			txtTripAliasContext.Text = "";

			ucSelectRecordID_Hosts.ClearData();

			btnPackingsClear_Click(null, null);

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			SetStartTerms();

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);

			tabInputsDocuments.IsNeedRestore = true;
		}

		private void SetStartTerms()
		{
			// начальные условия
			if (oInputDocument != null)
			{
				// даты диапазона можно менять
				if (oInputDocument.FilterDateBeg != null)
				{
					dtrDates.dtpBegDate.Value = Convert.ToDateTime(oInputDocument.FilterDateBeg);
				}
				if (oInputDocument.FilterDateEnd != null)
				{
					dtrDates.dtpEndDate.Value = Convert.ToDateTime(oInputDocument.FilterDateEnd);
				}

				// другие условия менять нельзя
				/*
				if (oInputDocument.FilterDateInput != null)
				{
					dtrDates.dtpBegDate.Value =
					dtrDates.dtpEndDate.Value =
						Convert.ToDateTime(oInputDocument.FilterDateInput);
					dtrDates.Enabled = false;
				}
				*/

				if (oInputDocument.FilterDeliveryNeed != null)
				{
					if ((bool)oInputDocument.FilterDeliveryNeed)
						optDeliveryNeed.Checked = true;
					else
						optDeliveryNeedNot.Checked = true;
					pnlDeliveryNeed.Enabled = false;
				}

				if (oInputDocument.FilterOwnersList != null)
				{
					ucSelectRecordID_Owners.LstMarked = oInputDocument.FilterOwnersList.ToString();
					ucSelectRecordID_Owners.Enabled = false;
				}
				if (oInputDocument.FilterPartnersSourceList != null)
				{
					ucSelectRecordID_PartnersSource.LstMarked = oInputDocument.FilterPartnersSourceList.ToString();
					ucSelectRecordID_PartnersSource.Enabled = false;
				}
				if (oInputDocument.FilterPartnersTargetList != null)
				{
					ucSelectRecordID_PartnersTarget.LstMarked = oInputDocument.FilterPartnersTargetList.ToString();
					ucSelectRecordID_PartnersTarget.Enabled = false;
				}

				if (oInputDocument.FilterIsConfirmed != null)
				{
					if ((bool)oInputDocument.FilterIsConfirmed)
						optInputsDocumentsIsConfirmed.Checked = true;
					else
						optInputsDocumentsIsConfirmedNot.Checked = true;
					pnlInputsDocumentsIsConfirmed.Enabled = false;
				}

				if (oInputDocument.FilterTripExists != null)
				{
					if ((bool)oInputDocument.FilterTripExists)
						optTripExists.Checked = true;
					else
						optTripExistsNot.Checked = true;
					pnlTripExists.Enabled = false;
				}

				if (oInputDocument.FilterTripsList != null)
				{
					if (RFMUtilities.Occurs(RFMUtilities.NormalizeList(oInputDocument.FilterTripsList), ",") == 0 &&
						oInputDocument.FilterTripsList != "")
					{
						try
						{
							numTripID.Value = Convert.ToInt32(RFMUtilities.NormalizeList(oInputDocument.FilterTripsList));
						}
						finally { }
					}
					numTripID.Enabled =
					lblAliasContext.Enabled =
						false;
				}

				if (oInputDocument.FilterPackingsList != null)
				{
					sSelectedPackingsIDList = oInputDocument.FilterPackingsList.ToString();
					pnlPackings.Enabled = false;
				}

				if (oInputDocument.FilterHostsList != null)
				{
					ucSelectRecordID_Hosts.LstMarked = oInputDocument.FilterHostsList.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				}
				if (nUserHostID.HasValue)
				{
					ucSelectRecordID_Hosts.LstMarked = nUserHostID.ToString();
				}
			}
		}

	#endregion

	}
}