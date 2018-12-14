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
	public partial class frmSelectOneOutput : RFMFormChild
	{
		// форма для выбора одной или нескольких записей о заданиях на отгрузку
		// возвращает в родительскую форму:
		// с пометкой:  string _SelectedOutputsIDList (список кодов отмеченных записей, через запятую, вида: 1,2,23,) 
		// без пометки: int _SelectedOutputID (код текущей записи)
		// string _SelectedOutputsText (список дата + клиент для первых 3-х отмеченных заказов)

		private Form parentForm;
		private bool useCheck;
		private Output oOutput;

		private Output oOutputList; //список расходов
		private Output oOutputCur; //текущий расход

		private OutputDocument oOutputDocumentInOutput;

		private Host oHost;
		private int? nUserHostID = null;

		// для фильтров
		public string _SelectedPackingsIDList;
		public string _SelectedPackingsAliasText;
		private string sSelectedPackingsIDList = "";
		
		int nFirstCntRecords = 3; // количество первых записей для наборного текстового значения


		public frmSelectOneOutput(Form _parentForm, bool _useCheck, Output _oOutput)
		{
			oOutputList = new Output();
			oOutputCur = new Output();
			if (oOutputList.ErrorNumber != 0 ||
				oOutputCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oOutputDocumentInOutput = new OutputDocument();
				if (oOutputDocumentInOutput.ErrorNumber != 0)
				{
					IsValid = false;
				}
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
				oOutput = _oOutput;

			}
		}

		private void frmSelectOneOutput_Load(object sender, EventArgs e)
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
			tcOutputsGoods.Init();

			grdOutputs.IsStatusShow =
			grdOutputsGoods.IsStatusShow =
			grdOutputsDocuments.IsStatusShow =
				true;

			grdOutputs.IsCheckerInclude = useCheck;
			grdOutputs.IsCheckerShow = useCheck;

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

		private bool tabOutputs_Restore()
		{
			grdOutputs_Restore();
			if (grdOutputs.Rows.Count > 0)
			{
				btnGo.Enabled = true;
				grdOutputs.Select();
			}
			else
			{
				btnGo.Enabled = false;
			}
			return (true);
		}

		private bool tabOutputsGoods_Restore()
		{
			return grdOutputsGoods_Restore();
		}

		private bool tabOutputsDocuments_Restore()
		{
			return grdOutputsDocuments_Restore();
		}


	#endregion Tab restore

	#region  CellFormatting

		private void grdOutputs_CurrentRowChanged(object sender)
		{
			if (grdOutputs.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}


		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			if (grdOutputs.CurrentRow == null || grdOutputs.CurrentRow.Index < 0)
				return;

			int rowIndex = grdOutputs.CurrentRow.Index;

			if (grdOutputs.IsStatusRow(rowIndex))
				oOutputCur.ClearOne();
			else
			{
				DataRow r = ((DataRowView)((DataGridViewRow)grdOutputs.Rows[rowIndex]).DataBoundItem).Row;
				oOutputCur.FillOne(r);
			}
			tcOutputsGoods.SetAllNeedRestore(true);
		}

		private void grdOutputs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
			if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOutputID"]))
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}

			// перенесенные на другой рейс
			// ...
		}

		private void grdOutputsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

		private void grdOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
					if ((bool)r["SuccessConfirmed"])
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						e.Value = Properties.Resources.CheckRed;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("IsBroughtImage".ToUpper()))
			{
				if ((bool)r["IsBrought"])
				{
					if ((bool)r["SuccessBrought"])
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						e.Value = Properties.Resources.CheckRed;
					}
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
			if (sGridName.Contains("OutputsDocuments"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOrderID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if (sGridName.Contains("SUPPLIES"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromSupplyID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}

			// скопированные из задания
			// ...
		}

	#endregion Cells...

	#region Restore

		#region Outputs

		private bool grdOutputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputCur.ClearOne();

			oOutputList.ClearError();
			oOutputList.ClearFilters();
			oOutputList.ID = null;
			oOutputList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oOutputList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oOutputList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oOutputList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oOutputList.FilterDeliveryNeed = false;
			}

			// типы расходов
			if (ucSelectRecordID_OutputsTypes.IsSelectedExist)
			{
				oOutputList.FilterOutputsTypesList = ucSelectRecordID_OutputsTypes.GetIdString();
			}
			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oOutputList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}
			// получатели
			if (ucSelectRecordID_OutputsPartners.IsSelectedExist)
			{
				oOutputList.FilterPartnersList = ucSelectRecordID_OutputsPartners.GetIdString();
			}

			// выбранные товары
			if (sSelectedPackingsIDList.Length > 0)
			{
				oOutputList.FilterPackingsList = sSelectedPackingsIDList;
			}

			// расход привязан к рейсу
			if (optTripExistsNot.Checked)
			{
				oOutputList.FilterTripExists = false;
			}
			if (optTripExists.Checked)
			{
				oOutputList.FilterTripExists = true;
			}

			// расход готов к обработке на складе
			if (optReadyForWMSNot.Checked)
			{
				oOutputList.FilterReadyForWMS = false;
			}
			if (optReadyForWMS.Checked)
			{
				oOutputList.FilterReadyForWMS = true;
			}

			// состояние расхода: подтверждение 
			if (optIsConfirmedNot.Checked)
			{
				oOutputList.FilterIsConfirmed = false;
			}
			if (optIsConfirmed.Checked)
			{
				oOutputList.FilterIsConfirmed = true;
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
				oOutputList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oOutputList.FilterTripsList == null)
					oOutputList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oOutputList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			// хосты
			if (nUserHostID.HasValue)
			{
				oOutputList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oOutputList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}

			// начальные условия
			if (oOutput != null)
			{
				if (oOutput.FilterOwnersList != null)
					oOutputList.FilterOwnersList = oOutput.FilterOwnersList;
				if (oOutput.FilterOutputsTypesList != null)
					oOutputList.FilterOutputsTypesList = oOutput.FilterOutputsTypesList;
				if (oOutput.FilterPartnersList != null)
					oOutputList.FilterPartnersList = oOutput.FilterPartnersList;
				if (oOutput.FilterHostsList != null)
				{
					if (!nUserHostID.HasValue)
						oOutputList.FilterHostsList = oOutput.FilterHostsList;
					else
					{
						if (!((string)("," + oOutput.FilterHostsList + ",")).Contains("," + nUserHostID.ToString().Trim() + ","))
							oOutputList.FilterHostsList = "-1";
					}
				}
			}
			//

			grdOutputsGoods.DataSource = null;
			grdOutputsDocuments.DataSource = null;

			grdOutputs.GetGridState();

			oOutputList.FillData();
			grdOutputs.IsLockRowChanged = true;
			grdOutputs.Restore(oOutputList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oOutputList.ErrorNumber == 0);
		}

		private bool grdOutputsGoods_Restore()
		{
			grdOutputsGoods.GetGridState();
			grdOutputsGoods.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oOutputList.FillTableOutputsGoods((int)oOutputCur.ID);
			grdOutputsGoods.Restore(oOutputList.TableOutputsGoods);
			return (oOutputList.ErrorNumber == 0);
		}

		private bool grdOutputsDocuments_Restore()
		{
			grdOutputsDocuments.GetGridState();
			grdOutputsDocuments.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oOutputDocumentInOutput.FilterOutputsList = oOutputCur.ID.ToString();
			oOutputDocumentInOutput.FillData();
			grdOutputsDocuments.Restore(oOutputDocumentInOutput.MainTable);
			return (oOutputDocumentInOutput.ErrorNumber == 0);
		}

		#endregion Outputs

	#endregion Restore

	#region Buttons

		private void btnGo_Click(object sender, EventArgs e)
		{
			// возвращаем код/список кодов заказов в родительскую форму

			string _SelectedOutputsIDList = null;
			int? _SelectedOutputID = null;
			string _SelectedOutputsText = "";

			if (grdOutputs.Rows.Count > 0)
			{
				if (useCheck && grdOutputs.IsCheckerShow)
				{
					// список ID 
					_SelectedOutputsIDList = "";
					_SelectedOutputsText = "";

					DataView dMarked = new DataView(oOutputList.MainTable);
					dMarked.RowFilter = "IsMarked = true";
					dMarked.Sort = grdOutputs.GridSource.Sort;
					int i = 0;
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r["ID"]))
						{
							_SelectedOutputsIDList += r["ID"].ToString() + ",";

							if (i < nFirstCntRecords)
							{
                                _SelectedOutputsText += Convert.ToDateTime(r["DateOutput"]).ToString("dd.MM.yyyy") + " " + r["PartnerName"].ToString() + ", ";
							}
							else
							{
								if (i == nFirstCntRecords)
								{
									_SelectedOutputsText += "...";
								}
							}
							i++;
						}
					}
					if (_SelectedOutputsIDList.Length == 0)
					{
						// нет отметок - берем текущую запись
						if (grdOutputs.CurrentRow != null)
						{
							_SelectedOutputsIDList = grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value.ToString() + ",";
							_SelectedOutputsText = grdOutputs.CurrentRow.Cells["grcOutputs_DateOutput"].Value.ToString().Substring(0, 10) + " " +
                                grdOutputs.CurrentRow.Cells["grcOutputs_PartnerName"].Value.ToString().Trim();
						}
					}

					// приводим наборное текстовое поле к виду: (5) раз, два, три, ...
					if (_SelectedOutputsIDList.Length == 0)
					{
						_SelectedOutputsIDList = null;
						_SelectedOutputsText = "";
					}
					else
					{
						_SelectedOutputsText = _SelectedOutputsText.Trim();
						if (_SelectedOutputsText.Substring(_SelectedOutputsText.Length - 1, 1) == ",")
						{
							_SelectedOutputsText = _SelectedOutputsText.Substring(0, _SelectedOutputsText.Length - 1);
						}
						_SelectedOutputsText = "(" + RFMUtilities.Occurs(_SelectedOutputsIDList, ",").ToString() + "): " +
							_SelectedOutputsText;
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedOutputsIDList", _SelectedOutputsIDList);
					RFMUtilities.SetFormField(parentForm, "_SelectedOutputsText", _SelectedOutputsText);
				}
				else
				{
					// ID текущей строки
					if (grdOutputs.CurrentRow != null)
					{
						_SelectedOutputID = Convert.ToInt32(grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value);
						_SelectedOutputsText = grdOutputs.CurrentRow.Cells["grcOutputs_DateOutput"].Value.ToString().Substring(0, 10) + " " +
                            grdOutputs.CurrentRow.Cells["grcOutputs_PartnerName"].Value.ToString().Trim();
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedOutputID", _SelectedOutputID);
					RFMUtilities.SetFormField(parentForm, "_SelectedOutputsText", _SelectedOutputsText);
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

		#region OutputsPartners

		private void ucSelectRecordID_OutputsPartners_Restore()
		{
			if (ucSelectRecordID_OutputsPartners.sourceData == null)
			{
				Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, false, true))
				{
					ucSelectRecordID_OutputsPartners.Restore(oPartner.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_OutputsPartners.Restore();
			}
		}

		#endregion

		#region OutputsTypes

		private void ucSelectRecordID_OutputsTypes_Restore()
		{
			if (ucSelectRecordID_OutputsTypes.sourceData == null)
			{
				if (Utilities.FillData_OutputsTypes(oOutputList))
				{
					ucSelectRecordID_OutputsTypes.Restore(oOutputList.TableOutputsTypes);
				}
			}
			else
			{
				ucSelectRecordID_OutputsTypes.Restore();
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

				tabOutputs.IsNeedRestore = true;
			}

			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";
		}

		private void btnPackingsClear_Click(object sender, EventArgs e)
		{
			tabOutputs.IsNeedRestore = true;

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
			ucSelectRecordID_OutputsTypes.ClearData();
			ucSelectRecordID_OutputsPartners.ClearData();

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

			tabOutputs.IsNeedRestore = true;
		}

		private void SetStartTerms()
		{
			// начальные условия
			if (oOutput != null)
			{
				// даты можно менять
				if (oOutput.FilterDateBeg != null)
				{
					dtrDates.dtpBegDate.Value = Convert.ToDateTime(oOutput.FilterDateBeg);
				}
				if (oOutput.FilterDateEnd != null)
				{
					dtrDates.dtpEndDate.Value = Convert.ToDateTime(oOutput.FilterDateEnd);
				}

				// остальные условия менять нельзя
				if (oOutput.FilterDeliveryNeed != null)
				{
					if ((bool)oOutput.FilterDeliveryNeed)
						optDeliveryNeed.Checked = true;
					else
						optDeliveryNeedNot.Checked = true;
					pnlDeliveryNeed.Enabled = false;
				}

				if (oOutput.FilterOwnersList != null)
				{
					ucSelectRecordID_Owners.LstMarked = oOutput.FilterOwnersList.ToString();
					ucSelectRecordID_Owners.Enabled = false;
				}
				if (oOutput.FilterOutputsTypesList != null)
				{
					ucSelectRecordID_OutputsTypes.LstMarked = oOutput.FilterOutputsTypesList.ToString();
					ucSelectRecordID_OutputsTypes.Enabled = false;
				}
				if (oOutput.FilterPartnersList != null)
				{
					ucSelectRecordID_OutputsPartners.LstMarked = oOutput.FilterPartnersList.ToString();
					ucSelectRecordID_OutputsPartners.Enabled = false;
				}

				if (oOutput.FilterIsConfirmed != null)
				{
					if ((bool)oOutput.FilterIsConfirmed)
						optIsConfirmed.Checked = true;
					else
						optIsConfirmedNot.Checked = true;
					pnlIsConfirmed.Enabled = false;
				}
				if (oOutput.FilterReadyForWMS != null)
				{
					if ((bool)oOutput.FilterReadyForWMS)
						optReadyForWMS.Checked = true;
					else
						optReadyForWMSNot.Checked = true;
					pnlReadyForWMS.Enabled = false;
				}

				if (oOutput.FilterTripExists != null)
				{
					if ((bool)oOutput.FilterTripExists)
						optTripExists.Checked = true;
					else
						optTripExistsNot.Checked = true;
					pnlTripExists.Enabled = false;
				}

				if (oOutput.FilterTripsList != null)
				{
					if (RFMUtilities.Occurs(RFMUtilities.NormalizeList(oOutput.FilterTripsList), ",") == 0 &&
						oOutput.FilterTripsList != "")
					{
						try
						{
							numTripID.Value = Convert.ToInt32(RFMUtilities.NormalizeList(oOutput.FilterTripsList));
						}
						finally { }
					}
					numTripID.Enabled =
					lblAliasContext.Enabled =
						false;
				}

				if (oOutput.FilterPackingsList != null)
				{
					sSelectedPackingsIDList = oOutput.FilterPackingsList.ToString();
					pnlPackings.Enabled = false;
				}

				if (oOutput.FilterHostsList != null)
				{
					ucSelectRecordID_Hosts.LstMarked = oOutput.FilterHostsList.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				} if (nUserHostID.HasValue)
				{
					ucSelectRecordID_Hosts.LstMarked = nUserHostID.ToString();
				}

			}
		}

	#endregion Terms clear

	}
}