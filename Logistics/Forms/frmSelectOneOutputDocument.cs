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
	// ����� ��� ������ ����� ��� ���������� ������� � ������� �� ��������
	// ���������� � ������������ �����:
	// � ��������:  string _SelectedOutputsDocumentsIDList (������ ����� ���������� �������, ����� �������, ����: 1,2,23,) 
	// ��� �������: int _SelectedOutputDocumentID (��� ������� ������)
	// string _SelectedOutputsDocumentsText (������ ���� + ������ ��� ������ 3-� ���������� �������)

	public partial class frmSelectOneOutputDocument : RFMFormChild
	{
		private Form parentForm;
		private bool useCheck;

		private OutputDocument oOutputDocument; // ����� � ���������� ���������

		private OutputDocument oOutputDocumentList; //������ ������� �� �������� 
		private OutputDocument oOutputDocumentCur; //������� ����� �� �������� 

		private Host oHost;
		private int? nUserHostID = null;

		// ��� ��������
		public string _SelectedPackingsIDList;
		public string _SelectedPackingsAliasText;
		private string sSelectedPackingsIDList = "";

		int nFirstCntRecords = 3; // ���������� ������ ������� ��� ��������� ���������� ��������


		public frmSelectOneOutputDocument(Form _parentForm, bool _useCheck, OutputDocument _oOutputDocument)
		{
			oOutputDocumentList = new OutputDocument();
			oOutputDocumentCur = new OutputDocument();
			if (oOutputDocumentList.ErrorNumber != 0 ||
				oOutputDocumentCur.ErrorNumber != 0)
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
				oOutputDocument = _oOutputDocument;
			}
		}

		private void frmSelectOneOutputDocument_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			lblHosts.Visible =
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled =
				(oHost.Count() > 1 && !nUserHostID.HasValue);

			// ���������� ������������ �� �������
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			btnClearTerms_Click(null, null);

			tcList.Init();

			grdOutputsDocuments.IsCheckerInclude = useCheck;
			grdOutputsDocuments.IsCheckerShow = useCheck;

			if (useCheck)
				Text = "�������� ��������� ��������� ����������";
			else
				Text = "�������� ��������� ��������";

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

		private bool tabOutputsDocuments_Restore()
		{
			grdOutputsDocuments_Restore();
			if (grdOutputsDocuments.Rows.Count > 0)
			{
				grdOutputsDocuments.Select();
				btnGo.Enabled = true;
			}
			else
			{
				btnGo.Enabled = false;
			}
			
			return (true);
		}

		private bool tabOutputsDocumentsGoods_Restore()
		{
			return (grdOutputsDocumentsGoods_Restore());
		}

	#endregion Tab Resore

	#region TimerTick, CellFormatting

		private void grdOutputsDocuments_CurrentRowChanged(object sender)
		{
			if (grdOutputsDocuments.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;
			
			if (grdOutputsDocuments.CurrentRow == null)
			   return;
			
			int rowIndex = grdOutputsDocuments.CurrentRow.Index;

			// ������ �� �������� 
			if (grdOutputsDocuments.IsStatusRow(rowIndex))
			{
			}
			else
			{
				// ���������� ������� �� ������� ������ 
				DataRow r = ((DataRowView)((DataGridViewRow)grdOutputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
				oOutputDocumentCur.FillOne(r);
			}
			tcOutputsDocumentsGoods.SetAllNeedRestore(true);
		}

		private void grdOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			string sGridName = grd.Name.ToUpper();
			
			if (grd.DataSource == null)
				return;

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("RESULT") ||
					grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();
			
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

			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void grdOutputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������ 
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
			if (sColumnName.Contains("RESULT"))
			{
				if (sColumnName.Contains("CONFIRMED"))
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
				if (sColumnName.Contains("BROUGHT"))
				{
					if ((decimal)r["QntBrought"] == 0)
					{
						e.Value = Properties.Resources.Plain_R;
					}
					else
					{
						if ((decimal)r["QntWished"] == (decimal)r["QntBrought"])
						{
							e.Value = Properties.Resources.Plain_G;
						}
						else
						{
							if ((decimal)r["QntWished"] < (decimal)r["QntBrought"])
							{
								e.Value = Properties.Resources.Plain_B;
							}
							else
							{
								e.Value = Properties.Resources.Plain_Y;
							}
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

	#endregion 

	#region Restore

		private bool grdOutputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputDocumentCur.ClearOne();

			oOutputDocumentList.ClearError();
			oOutputDocumentList.ClearFilters();
			oOutputDocumentList.ID = null;
			oOutputDocumentList.IDList = null;

			// �������� �������

			// ����
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oOutputDocumentList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oOutputDocumentList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// ��������?
			if (optDeliveryNeed.Checked)
			{
				oOutputDocumentList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oOutputDocumentList.FilterDeliveryNeed = false;
			}

			// �������-����������
			if (txtPartnerSourceNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerSource = new Partner();
				oPartnerSource.FilterNameContext = txtPartnerSourceNameContext.Text.Trim();
				oPartnerSource.FillData();
				oOutputDocumentList.FilterPartnersSourceList = "";
				foreach (DataRow rcs in oPartnerSource.MainTable.Rows)
					oOutputDocumentList.FilterPartnersSourceList += rcs["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersSource.IsSelectedExist)
			{
				oOutputDocumentList.FilterPartnersSourceList += ucSelectRecordID_PartnersSource.GetIdString();
			}

			// �������-���������� 
			if (txtPartnerTargetNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerTarget = new Partner();
				oPartnerTarget.FilterNameContext = txtPartnerTargetNameContext.Text.Trim();
				oPartnerTarget.FillData();
				oOutputDocumentList.FilterPartnersTargetList = "";
				foreach (DataRow rct in oPartnerTarget.MainTable.Rows)
					oOutputDocumentList.FilterPartnersTargetList += rct["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersTarget.IsSelectedExist)
			{
				oOutputDocumentList.FilterPartnersTargetList += ucSelectRecordID_PartnersTarget.GetIdString();
			}

			// ���������
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oOutputDocumentList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// ����?
			if (optTripExists.Checked)
			{
				oOutputDocumentList.FilterTripExists = true;
			}
			if (optTripExistsNot.Checked)
			{
				oOutputDocumentList.FilterTripExists = false;
			}
			// ������� �� ������?
			if (optOutputExists.Checked)
			{
				oOutputDocumentList.FilterIsOutputExists = true;
			}
			if (optOutputExistsNot.Checked)
			{
				oOutputDocumentList.FilterIsOutputExists = false;
			}

			// ��������� ������
			if (sSelectedPackingsIDList.Length > 0)
			{
				oOutputDocumentList.FilterPackingsList = sSelectedPackingsIDList;
			}

			// ������������� ��������
			if (optOutputsDocumentsIsConfirmedNot.Checked)
			{
				oOutputDocumentList.FilterIsConfirmed = false;
			}
			if (optOutputsDocumentsIsConfirmed.Checked)
			{
				oOutputDocumentList.FilterIsConfirmed = true;
			}

			// ������������� �������� 
			if (optOutputsDocumentsIsBroughtNot.Checked)
			{
				oOutputDocumentList.FilterIsBrought = false;
			}
			if (optOutputsDocumentsIsBrought.Checked)
			{
				oOutputDocumentList.FilterIsBrought = true;
			}

			// �� �����
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
				oOutputDocumentList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oOutputDocumentList.FilterTripsList == null)
					oOutputDocumentList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oOutputDocumentList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			// �����
			if (nUserHostID.HasValue)
			{
				oOutputDocumentList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oOutputDocumentList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			// ��������� ������� 
			if (oOutputDocument != null)
			{
				if (oOutputDocument.FilterOwnersList != null)
					oOutputDocumentList.FilterOwnersList = oOutputDocument.FilterOwnersList;
				if (oOutputDocument.FilterPartnersSourceList != null)
					oOutputDocumentList.FilterPartnersSourceList = oOutputDocument.FilterPartnersSourceList;
				if (oOutputDocument.FilterPartnersTargetList != null)
					oOutputDocumentList.FilterPartnersTargetList = oOutputDocument.FilterPartnersTargetList;
				if (oOutputDocument.FilterHostsList != null)
				{
					if (!nUserHostID.HasValue)
						oOutputDocumentList.FilterHostsList = oOutputDocument.FilterHostsList;
					else
					{
						if (!((string)("," + oOutputDocument.FilterHostsList + ",")).Contains("," + nUserHostID.ToString().Trim() + ","))
							oOutputDocumentList.FilterHostsList = "-1";
					}
				}
			}

			grdOutputsDocumentsGoods.DataSource = null;

			grdOutputsDocuments.GetGridState();

			oOutputDocumentList.FillData();

			grdOutputsDocuments.IsLockRowChanged = true;
			grdOutputsDocuments.Restore(oOutputDocumentList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oOutputDocumentList.ErrorNumber == 0);
		}

		private bool grdOutputsDocumentsGoods_Restore()
		{
			grdOutputsDocumentsGoods.GetGridState();
			grdOutputsDocumentsGoods.DataSource = null;
			if (grdOutputsDocuments.Rows.Count == 0 || 
				oOutputDocumentCur.ID == null ||
				(grdOutputsDocuments.CurrentRow != null && grdOutputsDocuments.IsStatusRow(grdOutputsDocuments.CurrentRow.Index)))
				return (true);

			oOutputDocumentList.FillTableOutputsDocumentsGoods((int)oOutputDocumentCur.ID);
			grdOutputsDocumentsGoods.Restore(oOutputDocumentList.TableOutputsDocumentsGoods);
			return (oOutputDocumentList.ErrorNumber == 0);
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
			// ���������� ���/������ ����� ������� � ������������ �����

			string _SelectedOutputsDocumentsIDList = null;
			int? _SelectedOutputDocumentID = null;
			string _SelectedOutputsDocumentsText = "";

			if (grdOutputsDocuments.Rows.Count > 0)
			{
				if (useCheck && grdOutputsDocuments.IsCheckerShow)
				{
					// ������ ID 
					_SelectedOutputsDocumentsIDList = "";
					_SelectedOutputsDocumentsText = "";

					DataView dMarked = new DataView(oOutputDocumentList.MainTable);
					dMarked.RowFilter = "IsMarked = true";
					dMarked.Sort = grdOutputsDocuments.GridSource.Sort;
					int i = 0;
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r["ID"]))
						{
							_SelectedOutputsDocumentsIDList += r["ID"].ToString() + ",";

							if (i < nFirstCntRecords)
							{
								_SelectedOutputsDocumentsText += Convert.ToDateTime(r["DateOutput"]).ToString("dd.MM.yyyy") + " " + r["PartnerTargetName"].ToString() + ", ";
							}
							else
							{
								if (i == nFirstCntRecords)
								{
									_SelectedOutputsDocumentsText += "...";
								}
							}
							i++;
						}
					}
					if (_SelectedOutputsDocumentsIDList.Length == 0)
					{
						// ��� ������� - ����� ������� ������
						if (grdOutputsDocuments.CurrentRow != null)
						{
							_SelectedOutputsDocumentsIDList = grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value.ToString() + ",";
							_SelectedOutputsDocumentsText = grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_DateOutput"].Value.ToString().Substring(0, 10) + " " +
								grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_PartnerTargetName"].Value.ToString().Trim();
						}
					}

					// �������� �������� ��������� ���� � ����: (5) ���, ���, ���, ...
					if (_SelectedOutputsDocumentsIDList.Length == 0)
					{
						_SelectedOutputsDocumentsIDList = null;
						_SelectedOutputsDocumentsText = "";
					}
					else
					{
						_SelectedOutputsDocumentsText = _SelectedOutputsDocumentsText.Trim();
						if (_SelectedOutputsDocumentsText.Substring(_SelectedOutputsDocumentsText.Length - 1, 1) == ",")
						{
							_SelectedOutputsDocumentsText = _SelectedOutputsDocumentsText.Substring(0, _SelectedOutputsDocumentsText.Length - 1);
						}
						_SelectedOutputsDocumentsText = "(" + RFMUtilities.Occurs(_SelectedOutputsDocumentsIDList, ",").ToString() + "): " +
							_SelectedOutputsDocumentsText;
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedOutputsDocumentsIDList", _SelectedOutputsDocumentsIDList);
					RFMUtilities.SetFormField(parentForm, "_SelectedOutputsDocumentsText", _SelectedOutputsDocumentsText);
				}
				else
				{
					// ID ������� ������
					if (grdOutputsDocuments.CurrentRow != null)
					{
						_SelectedOutputDocumentID = Convert.ToInt32(grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value);
						_SelectedOutputsDocumentsText = grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_DateOutput"].Value.ToString().Substring(0, 10) + " " +
							grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_PartnerTargetName"].Value.ToString().Trim();
					}

					RFMUtilities.SetFormField(parentForm, "_SelectedOutputDocumentID", _SelectedOutputDocumentID);
					RFMUtilities.SetFormField(parentForm, "_SelectedOutputsDocumentsText", _SelectedOutputsDocumentsText);
				}
			}
			else
			{
				RFMMessage.MessageBoxInfo("�� ������� �� ������ ���������� ���������...");
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

				tabOutputsDocuments.IsNeedRestore = true;
			}

			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";
		}

		private void btnPackingsClear_Click(object sender, EventArgs e)
		{
			tabOutputsDocuments.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPackingsChoosen, "�� �������");
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

			optOutputExistsAll.Checked = true;

			optOutputsDocumentsIsConfirmedAll.Checked = true;
			optOutputsDocumentsIsBroughtAll.Checked = true;

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

			tabOutputsDocuments.IsNeedRestore = true;
		}

		private void SetStartTerms()
		{
			// ��������� �������
			if (oOutputDocument != null)
			{
				// ���� ��������� ����� ������
				if (oOutputDocument.FilterDateBeg != null)
				{
					dtrDates.dtpBegDate.Value = Convert.ToDateTime(oOutputDocument.FilterDateBeg);
				}
				if (oOutputDocument.FilterDateEnd != null)
				{
					dtrDates.dtpEndDate.Value = Convert.ToDateTime(oOutputDocument.FilterDateEnd);
				}

				// ������ ������� ������ ������
				if (oOutputDocument.FilterDateOutput != null)
				{
					dtrDates.dtpBegDate.Value =
					dtrDates.dtpEndDate.Value =
						Convert.ToDateTime(oOutputDocument.FilterDateOutput);
					dtrDates.Enabled = false;
				}

				if (oOutputDocument.FilterDeliveryNeed != null)
				{
					if ((bool)oOutputDocument.FilterDeliveryNeed)
						optDeliveryNeed.Checked = true;
					else
						optDeliveryNeedNot.Checked = true;
					pnlDeliveryNeed.Enabled = false;
				}

				if (oOutputDocument.FilterOwnersList != null)
				{
					ucSelectRecordID_Owners.LstMarked = oOutputDocument.FilterOwnersList.ToString();
					ucSelectRecordID_Owners.Enabled = false;
				}
				if (oOutputDocument.FilterPartnersSourceList != null)
				{
					ucSelectRecordID_PartnersSource.LstMarked = oOutputDocument.FilterPartnersSourceList.ToString();
					ucSelectRecordID_PartnersSource.Enabled = false;
				}
				if (oOutputDocument.FilterPartnersTargetList != null)
				{
					ucSelectRecordID_PartnersTarget.LstMarked = oOutputDocument.FilterPartnersTargetList.ToString();
					ucSelectRecordID_PartnersTarget.Enabled = false;
				}

				if (oOutputDocument.FilterIsBrought != null)
				{
					if ((bool)oOutputDocument.FilterIsBrought)
						optOutputsDocumentsIsBrought.Checked = true;
					else
						optOutputsDocumentsIsBroughtNot.Checked = true;
					pnlOutputsDocumentsIsBrought.Enabled = false;
				}
				if (oOutputDocument.FilterIsConfirmed != null)
				{
					if ((bool)oOutputDocument.FilterIsConfirmed)
						optOutputsDocumentsIsConfirmed.Checked = true;
					else
						optOutputsDocumentsIsConfirmedNot.Checked = true;
					pnlOutputsDocumentsIsConfirmed.Enabled = false;
				}
				if (oOutputDocument.FilterIsOutputExists != null)
				{
					if ((bool)oOutputDocument.FilterIsOutputExists)
						optOutputExists.Checked = true;
					else
						optOutputExistsNot.Checked = true;
					pnlOutputExists.Enabled = false;
				}

				if (oOutputDocument.FilterTripExists != null)
				{
					if ((bool)oOutputDocument.FilterTripExists)
						optTripExists.Checked = true;
					else
						optTripExistsNot.Checked = true;
					pnlTripExists.Enabled = false;
				}

				if (oOutputDocument.FilterTripsList != null)
				{
					if (RFMUtilities.Occurs(RFMUtilities.NormalizeList(oOutputDocument.FilterTripsList), ",") == 0 &&
						oOutputDocument.FilterTripsList != "")
					{
						try
						{
							numTripID.Value = Convert.ToInt32(RFMUtilities.NormalizeList(oOutputDocument.FilterTripsList));
						}
						finally { }
					}
					numTripID.Enabled =
					lblAliasContext.Enabled =
						false;
				}

				if (oOutputDocument.FilterPackingsList != null)
				{
					sSelectedPackingsIDList = oOutputDocument.FilterPackingsList.ToString();
					pnlPackings.Enabled = false;
				}

				if (oOutputDocument.FilterHostsList != null)
				{
					ucSelectRecordID_Hosts.LstMarked = oOutputDocument.FilterHostsList.ToString();
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