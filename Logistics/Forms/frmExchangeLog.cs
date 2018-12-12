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
	public partial class frmExchangeLog : RFMFormChild
	{
		private Report oExchangeLog;
        private Host oHost;

        // фильтры
        private int nHours = 3;
        private bool bErrorOnly = false;
        private string cMode = "D";
        private string cHostsList = "";

		public frmExchangeLog()
		{
            oExchangeLog = new Report();
            if (oExchangeLog.ErrorNumber != 0)
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
			}
		}

		private void frmExchangeLog_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

            lblHosts.Visible =
            ucSelectRecordID_Hosts.Visible =
            ucSelectRecordID_Hosts.Enabled =
                (oHost.Count() > 1);

            btnClearTerms_Click(null, null);

			tcList.Init();

			RFMCursorWait.Set(false);
		}

	#region Tab Restore

		private bool tabTerms_Restore()
		{
			btnPrint.Enabled =
			btnService.Enabled =
				false;
			return true;
		}

		private bool tabData_Restore()
		{
			grdData_Restore();
			if (grdData.Rows.Count > 0)
			{
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				grdData.Select();
			}
			else
			{
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
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("DATA"))
			{
				grdData.Select();

				if (grdData.Rows.Count > 0 && grdData.CurrentRow != null)
				{
					btnPrint.Enabled =
					btnService.Enabled =
						true;
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
				btnPrint.Enabled =
				btnService.Enabled =
					false;
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
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
            if (Convert.ToBoolean(r["ErrorHappened"]))
            {
                e.CellStyle.BackColor = Color.LightPink;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
		}

	#endregion Cells...

	#region Restore

		private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			// собираем условия

            nHours = Convert.ToInt32(spnHours.Value);
            bErrorOnly = chkErrorOnly.Checked;
            
            cMode = "";
            if (optModeC.Checked) cMode = "C";
            if (optModeD.Checked) cMode = "D";

            if (ucSelectRecordID_Hosts.IsSelectedExist)
            {
                cHostsList = ucSelectRecordID_Hosts.GetIdString();
            }

            grdData.GetGridState();

            oExchangeLog.Report_GetExchangeLog(nHours, cHostsList, cMode, bErrorOnly);

			grdData.IsLockRowChanged = true;
            grdData.Restore(oExchangeLog.MainTable);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

            return (oExchangeLog.ErrorNumber == 0);
		}

	#endregion Restore

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

    #region Buttons

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

	#endregion

	#region Terms clear

	private void btnClearTerms_Click(object sender, EventArgs e)
		{
            spnHours.Value = 3;
            chkErrorOnly.Checked = false;
            optModeD.Checked = true;

            ucSelectRecordID_Hosts.ClearData();

            tabData.IsNeedRestore = true;
		}

	#endregion Terms clear

	}
}