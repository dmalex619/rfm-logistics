using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using LogBizObjects;
using RFMPublic;

namespace Logistics
{
	// форма для выбора одной или нескольких записей о заданиях на приход
	// возвращает в родительскую форму:
	// с пометкой:  string _SelectedInputsIDList (список кодов отмеченных записей, через запятую, вида: 1,2,23,) 
	// без пометки: int _SelectedInputDocumentID (код текущей записи)
	// string _SelectedInputsDocumentsText (список дата + клиент для первых 3-х отмеченных заказов)

	public partial class frmSelectOneInput : RFMFormChild
	{
		private Form parentForm;
		private bool useCheck;
		private Input oInput;
 
		private Input oInputList; //список приходов
		private Input oInputCur; //текущий приход
		private InputDocument oInputDocumentInInput;

		private Host oHost;
		private int? nUserHostID = null;

		// для фильтров
		public string _SelectedPackingsIDList;
		public string _SelectedPackingsAliasText;
		private string sSelectedPackingsIDList = "";

		int nFirstCntRecords = 3; 


		public frmSelectOneInput(Form _parentForm, bool _useCheck, Input _oInput)
		{
			oInputList = new Input();
			oInputCur = new Input();
			oInputDocumentInInput = new InputDocument();
			if (oInputList.ErrorNumber != 0 ||
				oInputCur.ErrorNumber != 0 ||
				oInputDocumentInInput.ErrorNumber != 0)
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
				oInput = _oInput;
			}
		}


		private void frmSelectOneInput_Load(object sender, EventArgs e)
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
			tcInputsGoods.Init();

			grdInputs.IsStatusShow =
			grdInputsGoods.IsStatusShow =
			grdInputsDocuments.IsStatusShow =
				true;

			grdInputs.IsCheckerInclude = useCheck;
			grdInputs.IsCheckerShow = useCheck;

			if (useCheck)
				Text = "Выберите несколько заданий";
			else
				Text = "Выберите задание";

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

		private bool tabInputs_Restore()
		{
			grdInputs_Restore();
			if (grdInputs.Rows.Count > 0)
			{
				btnGo.Enabled = true;
				grdInputs.Select();
			}
			else
			{
				btnGo.Enabled = false;
			}
			return (true);
		}

		private bool tabInputsGoods_Restore()
		{
			return grdInputsGoods_Restore();
		}

		private bool tabInputsDocuments_Restore()
		{
			return grdInputsDocuments_Restore();
		}

	#endregion Tab restore

		private void grdInputs_CurrentRowChanged(object sender)
		{
			if (grdInputs.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

	#region CellFormatting

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView grd;

			grd = grdInputs;

			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;
		
			if (grd.IsStatusRow(rowIndex))
				oInputCur.ClearOne();
			else
			{
				DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
				oInputCur.FillOne(r);
				btnGo.Enabled = true;
			}
			tcInputsGoods.SetAllNeedRestore(true);
		}

		private void grdInputs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;

			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;

			// подтверждение отгрузки / приема на складе
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

			// передача в WMS
			if (sColumnName.Contains("ReadyForWMSImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Plain_G;
				}
				else
				{
					if ((bool)r["SentToWMS"])
					{
						e.Value = Properties.Resources.Plain_B;
					}
					else
					{
						if ((bool)r["ReadyForWMS"])
						{
							e.Value = Properties.Resources.Plain_Y;
						}
						else
						{
							e.Value = Properties.Resources.Plain_R;
						}
					}
				}
			}

			// нетто-брутто
			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			// перенос
			if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputID"]))
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

			// перенесенные на другой рейс
			// ...
		}

		private void grdInputsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

			if (sColumnName.Contains("RESULT"))
			{
				if ((decimal)r["QntConfirmed"] == 0)
				{
					e.Value = Properties.Resources.DotRed;
				}
				else
				{
					if ((decimal)r["QntWished"] == (decimal)r["QntConfirmed"])
					{
						e.Value = Properties.Resources.DotGreen;
					}
					else
					{
						if ((decimal)r["QntWished"] < (decimal)r["QntConfirmed"])
						{
							e.Value = Properties.Resources.DotBlue;
						}
						else
						{
							e.Value = Properties.Resources.DotYellow;
						}
					}
				}
			}

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

		private void grdInputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
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

			// подтверждение отгрузки и доставки клиенту
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

			// нетто-брутто
			if ((sColumnName.Contains("TTO") || sColumnName.Contains("AMOUNT")) &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			// перенос
			if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputDocumentID"]))
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			// скопированные из задания
			// ...
		}

	#endregion Cells...

	#region Restore

		#region Inputs

		private bool grdInputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputCur.ClearOne();

			oInputList.ClearError();
			oInputList.ClearFilters();
			oInputList.ID = null;
			oInputList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oInputList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oInputList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oInputList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oInputList.FilterDeliveryNeed = false;
			}

			// типы приходов
			if (ucSelectRecordID_InputsTypes.IsSelectedExist)
			{
				oInputList.FilterInputsTypesList = ucSelectRecordID_InputsTypes.GetIdString();
			}
			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oInputList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}
			// поставщики
			if (ucSelectRecordID_InputsPartners.IsSelectedExist)
			{
				oInputList.FilterPartnersList = ucSelectRecordID_InputsPartners.GetIdString();
			}

			// выбранные товары
			if (sSelectedPackingsIDList.Length > 0)
			{
				oInputList.FilterPackingsList = sSelectedPackingsIDList;
			}

			// приход привязан к рейсу
			if (optTripExistsNot.Checked)
			{
				oInputList.FilterTripExists = false;
			}
			if (optTripExists.Checked)
			{
				oInputList.FilterTripExists = true;
			}

			// приход готов к обработке на складе
			if (optReadyForWMSNot.Checked)
			{
				oInputList.FilterReadyForWMS = false;
			}
			if (optReadyForWMS.Checked)
			{
				oInputList.FilterReadyForWMS = true;
			}

			// состояние прихода: подтверждение 
			if (optIsConfirmedNot.Checked)
			{
				oInputList.FilterIsConfirmed = false;
			}
			if (optIsConfirmed.Checked)
			{
				oInputList.FilterIsConfirmed = true;
			}

			// по рейсу
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0)
			{
				Trip oTripFilter = new Trip();
				oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				oTripFilter.FillData();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ",";
				}
				oInputList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oInputList.FilterTripsList == null)
					oInputList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oInputList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			// хосты
			if (nUserHostID.HasValue)
			{
				oInputList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oInputList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}

			// начальные условия
			if (oInput != null)
			{
				if (oInput.FilterOwnersList != null)
					oInputList.FilterOwnersList = oInput.FilterOwnersList;
				if (oInput.FilterInputsTypesList != null)
					oInputList.FilterInputsTypesList = oInput.FilterInputsTypesList;
				if (oInput.FilterPartnersList != null)
					oInputList.FilterPartnersList = oInput.FilterPartnersList;
				if (oInput.FilterHostsList != null)
				{
					if (!nUserHostID.HasValue)
						oInputList.FilterHostsList = oInput.FilterHostsList;
					else
					{ 
						if (!((string)("," + oInput.FilterHostsList + ",")).Contains("," + nUserHostID.ToString().Trim() + ","))
							oInputList.FilterHostsList = "-1";
					}
				}
			}
			//

			grdInputsGoods.DataSource = null;
			grdInputsDocuments.DataSource = null;

			grdInputs.GetGridState();

			oInputList.FillData();
			grdInputs.IsLockRowChanged = true;
			grdInputs.Restore(oInputList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oInputList.ErrorNumber == 0);
		}

		private bool grdInputsGoods_Restore()
		{
			grdInputsGoods.GetGridState();
			grdInputsGoods.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
				return (true);

			oInputList.FillTableInputsGoods((int)oInputCur.ID);
			grdInputsGoods.Restore(oInputList.TableInputsGoods);
			return (oInputList.ErrorNumber == 0);
		}

		private bool grdInputsDocuments_Restore()
		{
			grdInputsDocuments.GetGridState();
			grdInputsDocuments.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
				return (true);

			oInputDocumentInInput.FilterInputsList = oInputCur.ID.ToString();
			oInputDocumentInInput.FillData();
			grdInputsDocuments.Restore(oInputDocumentInInput.MainTable);
			return (oInputDocumentInInput.ErrorNumber == 0);
		}

		#endregion Inputs 

	#endregion Restore

	#region Buttons

		private void btnGo_Click(object sender, EventArgs e)
		{
			// возвращаем код/список кодов заказов в родительскую форму

			string _SelectedInputsIDList = null;
			int? _SelectedInputID = null;
			string _SelectedInputsText = "";

			if (grdInputs.Rows.Count > 0)
			{
				if (useCheck && grdInputs.IsCheckerShow)
				{
					// список ID 
					_SelectedInputsIDList = "";
					_SelectedInputsText = "";

					DataView dMarked = new DataView(oInputList.MainTable);
					dMarked.RowFilter = "IsMarked = true";
					dMarked.Sort = grdInputs.GridSource.Sort;
					int i = 0;
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r["ID"]))
						{
							_SelectedInputsIDList += r["ID"].ToString() + ",";

							if (i < nFirstCntRecords)
							{
								_SelectedInputsText += Convert.ToDateTime(r["DateInput"]).ToString("dd.MM.yyyy") + " " + r["PartnerName"].ToString() + ", ";
							}
							else
							{
								if (i == nFirstCntRecords)
								{
									_SelectedInputsText += "...";
								}
							}
							i++;
						}
					}
					if (_SelectedInputsIDList.Length == 0)
					{
						// нет отметок - берем текущую запись
						if (grdInputs.CurrentRow != null)
						{
							_SelectedInputsIDList = grdInputs.CurrentRow.Cells["grcInputs_ID"].Value.ToString() + ",";
							_SelectedInputsText = grdInputs.CurrentRow.Cells["grcInputs_DateInput"].Value.ToString().Substring(0, 10) + " " +
								grdInputs.CurrentRow.Cells["grcInputs_PartnerName"].Value.ToString().Trim();
						}
					}

					// приводим наборное текстовое поле к виду: (5) раз, два, три, ...
					if (_SelectedInputsIDList.Length == 0)
					{
						_SelectedInputsIDList = null;
						_SelectedInputsText = "";
					}
					else
					{
						_SelectedInputsText = _SelectedInputsText.Trim();
						if (_SelectedInputsText.Substring(_SelectedInputsText.Length - 1, 1) == ",")
						{
							_SelectedInputsText = _SelectedInputsText.Substring(0, _SelectedInputsText.Length - 1);
						}
						_SelectedInputsText = "(" + RFMUtilities.Occurs(_SelectedInputsIDList, ",").ToString() + "): " +
							_SelectedInputsText;
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedInputsIDList", _SelectedInputsIDList);
					RFMUtilities.SetFormField(parentForm, "_SelectedInputsText", _SelectedInputsText);
				}
				else
				{
					// ID текущей строки
					if (grdInputs.CurrentRow != null)
					{
						_SelectedInputID = Convert.ToInt32(grdInputs.CurrentRow.Cells["grcInputs_ID"].Value);
						_SelectedInputsText = grdInputs.CurrentRow.Cells["grcInputs_DateInput"].Value.ToString().Substring(0, 10) + " " +
							grdInputs.CurrentRow.Cells["grcInputs_PartnerName"].Value.ToString().Trim();
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedInputID", _SelectedInputID);
					RFMUtilities.SetFormField(parentForm, "_SelectedInputsText", _SelectedInputsText);
				}
			}
			else
			{
				RFMMessage.MessageBoxInfo("Не выбрано ни одного задания...");
			}

			DialogResult = DialogResult.Yes;
			Dispose();
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

	#region Filters Choose

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

		#region InputsPartners

		private void ucSelectRecordID_InputsPartners_Restore()
		{
			if (ucSelectRecordID_InputsPartners.sourceData == null)
			{
				Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, true, false))
				{
					ucSelectRecordID_InputsPartners.Restore(oPartner.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_InputsPartners.Restore();
			}
		}

		#endregion

		#region InputsTypes

		private void ucSelectRecordID_InputsTypes_Restore()
		{
			if (ucSelectRecordID_InputsTypes.sourceData == null)
			{
				if (Utilities.FillData_InputsTypes(oInputList))
				{
					ucSelectRecordID_InputsTypes.Restore(oInputList.TableInputsTypes);
				}
			}
			else
			{
				ucSelectRecordID_InputsTypes.Restore();
			}
		}

		#endregion

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
			}

			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";
		}

		private void btnPackingsClear_Click(object sender, EventArgs e)
		{
			tabInputs.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPackingsChoosen, "не выбраны");
			sSelectedPackingsIDList = "";
			txtPackingsChoosen.Text = "";
		}

		#endregion

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			RFMCursorWait.LockWindowUpdate(Handle);

			dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(-1).Date;
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(7).Date;

			optDeliveryNeedAll.Checked = true;

			ucSelectRecordID_Owners.ClearData();
			ucSelectRecordID_InputsTypes.ClearData();
			ucSelectRecordID_InputsPartners.ClearData();

			optReadyForWMSAll.Checked = true;
			optIsConfirmedAll.Checked = true;

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

			tabInputs.IsNeedRestore = true;
		}

		private void SetStartTerms()
		{
			// начальные условия
			if (oInput != null)
			{
				// даты можно менять
				if (oInput.FilterDateBeg != null)
				{
					dtrDates.dtpBegDate.Value = Convert.ToDateTime(oInput.FilterDateBeg);
				}
				if (oInput.FilterDateEnd != null)
				{
					dtrDates.dtpEndDate.Value = Convert.ToDateTime(oInput.FilterDateEnd);
				}

				// остальные условия менять нельзя
				if (oInput.FilterDeliveryNeed != null)
				{
					if ((bool)oInput.FilterDeliveryNeed)
						optDeliveryNeed.Checked = true;
					else
						optDeliveryNeedNot.Checked = true;
					pnlDeliveryNeed.Enabled = false;
				}

				if (oInput.FilterOwnersList != null)
				{
					ucSelectRecordID_Owners.LstMarked = oInput.FilterOwnersList.ToString();
					ucSelectRecordID_Owners.Enabled = false;
				}
				if (oInput.FilterInputsTypesList != null)
				{
					ucSelectRecordID_InputsTypes.LstMarked = oInput.FilterInputsTypesList.ToString();
					ucSelectRecordID_InputsTypes.Enabled = false;
				}
				if (oInput.FilterPartnersList != null)
				{
					ucSelectRecordID_InputsPartners.LstMarked = oInput.FilterPartnersList.ToString();
					ucSelectRecordID_InputsPartners.Enabled = false;
				}

				if (oInput.FilterIsConfirmed != null)
				{
					if ((bool)oInput.FilterIsConfirmed)
						optIsConfirmed.Checked = true;
					else
						optIsConfirmedNot.Checked = true;
					pnlIsConfirmed.Enabled = false;
				}
				if (oInput.FilterReadyForWMS != null)
				{
					if ((bool)oInput.FilterReadyForWMS)
						optReadyForWMS.Checked = true;
					else
						optReadyForWMSNot.Checked = true;
					pnlReadyForWMS.Enabled = false;
				}

				if (oInput.FilterTripExists != null)
				{
					if ((bool)oInput.FilterTripExists)
						optTripExists.Checked = true;
					else
						optTripExistsNot.Checked = true;
					pnlTripExists.Enabled = false;
				}

				if (oInput.FilterTripsList != null)
				{
					if (RFMUtilities.Occurs(RFMUtilities.NormalizeList(oInput.FilterTripsList), ",") == 0 &&
					oInput.FilterTripsList != "")
					{
						try
						{
							numTripID.Value = Convert.ToInt32(RFMUtilities.NormalizeList(oInput.FilterTripsList));
						}
						finally { }
					}
					numTripID.Enabled =
					lblAliasContext.Enabled =
						false;
				}

				if (oInput.FilterPackingsList != null)
				{
					sSelectedPackingsIDList = oInput.FilterPackingsList.ToString();
					pnlPackings.Enabled = false;
				}

				if (oInput.FilterHostsList != null)
				{
					ucSelectRecordID_Hosts.LstMarked = oInput.FilterHostsList.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				} 
				if (nUserHostID.HasValue)
				{
					ucSelectRecordID_Hosts.LstMarked = nUserHostID.ToString();
				}

			}
		}

	#endregion Terms clear

	}
}