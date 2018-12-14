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
	// форма для выбора одной или нескольких записей о партнерах, либо о реквизитах партнеров

	public partial class frmSelectOnePartner : RFMFormChild
	{
		private RFMSelectRecordIDForm ucSelect = null;
		private bool bUseCheck = false;
		private bool bOnlyOwners = false;
		private bool bOnlySeparatePicking = false; 
		private string cMode = null; // "P" ("", " ", null) - выбор партнера, "D" - выбор реквизитов (только без пометки)
		private Partner oPartnerCur;

		private Host oHost = new Host();
		private int? nHostID = null;
		private int? nUserHostID = null;

		public frmSelectOnePartner(RFMSelectRecordIDForm uc)
		{
			InitializeComponent();

			ucSelect = uc;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, bool isUseCheck)
		{
			InitializeComponent();

			ucSelect = uc;
			bUseCheck = isUseCheck;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, bool isUseCheck, bool onlyOwners)
		{
			InitializeComponent();

			ucSelect = uc;
			bUseCheck = isUseCheck;
			bOnlyOwners = onlyOwners;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, bool isUseCheck, bool onlyOwners, bool onlySeparatePicking)
		{
			InitializeComponent();

			ucSelect = uc;
			bUseCheck = isUseCheck;
			bOnlyOwners = onlyOwners;
			bOnlySeparatePicking = onlySeparatePicking;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, string sMode)
		{
			InitializeComponent();

			ucSelect = uc;
			cMode = sMode;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, string sMode, bool onlyOwners)
		{
			InitializeComponent();

			ucSelect = uc;
			cMode = sMode;
			bOnlyOwners = onlyOwners;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, string sMode, bool onlyOwners, bool onlySeparatePicking)
		{
			InitializeComponent();

			ucSelect = uc;
			cMode = sMode;
			bOnlyOwners = onlyOwners;
			bOnlySeparatePicking = onlySeparatePicking;
		}

		public frmSelectOnePartner(RFMSelectRecordIDForm uc, string sMode, bool onlyOwners, bool onlySeparatePicking, int _nHostID)
		{
			InitializeComponent();

			ucSelect = uc;
			cMode = sMode;
			bOnlyOwners = onlyOwners;
			bOnlySeparatePicking = onlySeparatePicking;
			nHostID = _nHostID; 
		}


		private void frmSelectOnePartner_Load(object sender, EventArgs e)
		{
			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			dgvData.IsCheckerInclude = bUseCheck;
			dgvData.IsCheckerShow = bUseCheck;
			chkOwner.Checked = bOnlyOwners;
			if (chkOwner.Checked)
				chkSeparatePicking.Checked = bOnlySeparatePicking;
			chkActual.Checked = true;  

			if (bUseCheck)
				Text = "Выберите несколько партнеров";
			else
			{
				if (cMode == "D")
					Text = "Выберите реквизиты партнера";
				else
					Text = "Выберите партнера";
			}

			oPartnerCur = new Partner();

			oHost.FillData();
			if (nHostID.HasValue)
			{
				DataRow rh = oHost.MainTable.Rows.Find(nHostID);
				if (rh != null)
				{
					ucSelectRecordID_Hosts.txtData.Text = rh["Name"].ToString();
					ucSelectRecordID_Hosts.LstMarked = nHostID.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				}
			}
			if (nUserHostID.HasValue)
			{
				DataRow rh = oHost.MainTable.Rows.Find(nUserHostID);
				if (rh != null)
				{
					ucSelectRecordID_Hosts.txtData.Text = rh["Name"].ToString();
					ucSelectRecordID_Hosts.LstMarked = nUserHostID.ToString();
					ucSelectRecordID_Hosts.Enabled = false;
				}
			}

			if (oHost.Count() <= 1 || nUserHostID.HasValue)
			{
				lblHosts.Visible =
				ucSelectRecordID_Hosts.Visible =
				ucSelectRecordID_Hosts.Enabled =
					false;
			}

			// нажать кнопку 
			if (chkOwner.Checked)
				btnFilter_Click(null, null);

			txtNameContext.Select();
		}

		private void chkOwner_CheckedChanged(object sender, EventArgs e)
		{
			if (chkOwner.Checked)
				chkSeparatePicking.Enabled = true;
			else
			{
				chkSeparatePicking.Checked = false;
				chkSeparatePicking.Enabled = false;
			}
		}

		#region Restore
		
		private bool dgvData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			Partner oPartnerList = new Partner();

			oPartnerList.ClearError();
			oPartnerList.ClearFilters();
			oPartnerList.ID = null;
			oPartnerList.IDList = null;

			// собираем условия

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oPartnerList.FilterNameContext = txtNameContext.Text.Trim().ToUpper();
			}
			if (txtInnContext.Text.Trim().Length > 0)
			{
				oPartnerList.FilterInnContext = txtInnContext.Text.Trim().ToUpper();
			}

			// выбор 
			oPartnerList.FilterPartnersRootsList = ucSelectRecordID_PartnersRoots.GetIdString();
			oPartnerList.FilterZonesList = ucSelectRecordID_Zones.GetIdString();

			// checks
			if (chkActual.Checked)
				oPartnerList.FilterActual = true;

			if (chkCustomer.Checked)
				oPartnerList.FilterIsCustomer = true;
			if (chkSupplier.Checked)
				oPartnerList.FilterIsSupplier = true;
			if (chkTransport.Checked)
				oPartnerList.FilterIsTransport = true;
			if (chkOwner.Checked)
				oPartnerList.FilterIsOwner = true;

			if (chkSeparatePicking.Checked)
				oPartnerList.FilterSeparatePicking = true;

			if (chkPerversion.Checked)
				oPartnerList.FilterPartnersGoodsExists = true;

			if (nHostID.HasValue || nUserHostID.HasValue)
			{
				if (nHostID.HasValue) 
					oPartnerList.FilterHostsList = nHostID.ToString();
				if (nUserHostID.HasValue)
					oPartnerList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oPartnerList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}

			dgvData.GetGridState();

			oPartnerList.FillData();
			dgvData.Restore(oPartnerList.MainTable);
			tmrRestore.Enabled = true;
			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oPartnerList.ErrorNumber == 0);
		}

		private bool dgvPartnersDetails_Restore()
		{
			dgvPartnersDetails.GetGridState();
			dgvPartnersDetails.DataSource = null;
			if (dgvData.Rows.Count == 0 ||
				!oPartnerCur.ID.HasValue ||
				(dgvData.CurrentRow != null && dgvData.IsStatusRow(dgvData.CurrentRow.Index)))
			{
				dgvPartnersDetails.ShowEmptyGrid();
				return (true);
			}	
			// таблица реквизитов
			oPartnerCur.FillTablePartnersDetails(null, (int)oPartnerCur.ID);
			dgvPartnersDetails.Restore(oPartnerCur.TablePartnersDetails);

			return (oPartnerCur.ErrorNumber == 0);
		}

		#region PartnersRoots

		private void ucSelectRecordID_PartnersRoots_Restore()
		{
			if (ucSelectRecordID_PartnersRoots.sourceData == null)
			{
				Partner oPartner = new Partner();
				if (Utilities.FillData_PartnersRoots(oPartner))
				{
					ucSelectRecordID_PartnersRoots.Restore(oPartner.TablePartnersRoots);
				}
			}
			else
			{
				ucSelectRecordID_PartnersRoots.Restore();
			}
		}

		#endregion PartnersRoots

		#region Zones

		private void ucSelectRecordID_Zones_Restore()
		{
			if (ucSelectRecordID_Zones.sourceData == null)
			{
				Zone oZone = new Zone();
				if (Utilities.FillData_Zones(oZone))
				{
					ucSelectRecordID_Zones.Restore(oZone.DS.Tables["TableDataTree"]);
				}
			}
			else
			{
				ucSelectRecordID_Zones.Restore();
			}
		}

		#endregion Zones

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

		#endregion Restore
		
		#region Buttons
		
		private void btnFilter_Click(object sender, EventArgs e)
		{
			dgvData_Restore();
			if (ucSelect != null)
			{
				if (ucSelect.IsSaveMark)
					ucSelect.RestoreMarks(dgvData);
			}
			dgvData.Select();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtInnContext.Text = "";
			txtNameContext.Text = "";
			ucSelectRecordID_PartnersRoots.ClearData();
			ucSelectRecordID_Zones.ClearData();
			chkCustomer.Checked =
			chkSupplier.Checked =
			chkTransport.Checked = 
			chkOwner.Checked =
			chkSeparatePicking.Checked =
				false;
			if (ucSelectRecordID_Hosts.Visible && ucSelectRecordID_Hosts.Enabled)
				ucSelectRecordID_Hosts.ClearData();
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			if (cMode == "D")
			{
				if (dgvData.CurrentRow == null)
				{
					RFMMessage.MessageBoxAttention("Выберите партнера!");
					dgvPartnersDetails.Select();
					return;
					
				}	
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvData.CurrentRow).DataBoundItem).Row;
				if (dgvPartnersDetails.Rows.Count > 0)
				{
					DataRow drd = ((DataRowView)((DataGridViewRow)dgvPartnersDetails.CurrentRow).DataBoundItem).Row;
					if (drd["FactName"].ToString().Trim().Length == 0)
					{
						RFMMessage.MessageBoxAttention("В выбранных реквизитах для партнера\n" +
							"\"" + ((string)dr["Name"]).Trim() + "\"\n" + 
							"не заполнено фактическое название...");
						dgvPartnersDetails.Select();
						return;
					}
					else
						ucSelect.SaveData(dgvPartnersDetails, "FactName", false);
				}
				else
				{
					RFMMessage.MessageBoxAttention("Не заполнены реквизиты для партнера\n" +
						"\"" + ((string)dr["Name"]).Trim() + "\"...");
					dgvData.Select();
					return;
				}
			}
			else
			{
				if (dgvData.Rows.Count > 0)
					ucSelect.SaveData(dgvData, "Name", bUseCheck);
			}

			btnGo.DialogResult = DialogResult.Yes; 	
			Close();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		#endregion Buttons

		#region Grid_CellFormat, Timer, RowChanged

		private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvData.DataSource == null)
				return;

			// статусная строка
			if (dgvData.IsStatusRow(e.RowIndex))
			{
				if (dgvData.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)dgvData.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = dgvData.Columns[e.ColumnIndex];

			if (!Convert.ToBoolean(r["Actual"]))
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);

			switch (c.Name)
			{
				case "dgvcDistance":
					if (Convert.IsDBNull(r["Distance"]) || Convert.ToInt32(r["Distance"]) == 0)
						e.Value = "";
					break;
			}
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			if (dgvData.CurrentRow != null)
			{
				int rowIndex = dgvData.CurrentRow.Index;
				DataRow r = ((DataRowView)((DataGridViewRow)dgvData.Rows[rowIndex]).DataBoundItem).Row;
				oPartnerCur.FillOne(r);
			}
			dgvPartnersDetails_Restore();
		}

		private void dgvData_CurrentRowChanged(object sender)
		{
			if (dgvData.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		#endregion Grid_CellFormat, Timer, RowChange

		#region Form keys
		
		private void frmSelectOnePartner_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F5:
					btnFilter_Click(null, null);
					break;
				case Keys.F1:
					btnHelp_Click(null, null);
					break;
				case Keys.W:
				case Keys.S:
					if (e.Modifiers == Keys.Control)
					{
						btnGo_Click(null, null);
					}
					break;
				case Keys.Escape:
					btnExit_Click(null, null);
					break;
			}
		}

		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btnGo_Click(null, null);
		}

		#endregion

	}
}
