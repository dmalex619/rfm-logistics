using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Threading;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics
{
	public partial class frmReportForSalaryWithPenalty : RFMFormChild
	{
		protected DateTime? dDateBeg, dDateEnd;
		protected string sDriversEmployeesList = null;

        private Salary oReportForSalaryDetail;
		private Salary oReportForSalaryTotal;

        public frmReportForSalaryWithPenalty()
		{
            oReportForSalaryDetail = new Salary();
			oReportForSalaryTotal = new Salary();
            if (oReportForSalaryDetail.ErrorNumber != 0 ||
				oReportForSalaryTotal.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmReportForSalaryWithPenalty_Load(object sender, EventArgs e) 
		{
			btnClearTerms_Click(null, null);
			tcList.Init();

            grdDetail.IsStatusShow =
            grdTotal.IsStatusShow =
				true;

			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			// неденежные данные - Italic
			Font fntDefault = grdDetail.DefaultCellStyle.Font;
			foreach (DataGridViewColumn  c in grdDetail.Columns)
			{
				if (c.DefaultCellStyle.Format.Contains("N") && !c.DataPropertyName.Contains("Amount"))
				{
					//e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
					((RFMDataGridViewTextBoxColumn)c).DefaultCellStyle.Font = new Font(fntDefault, FontStyle.Italic);
				}
			}
			foreach (DataGridViewColumn c in grdTotal.Columns)
			{
				if (c.DefaultCellStyle.Format.Contains("N") && !c.DataPropertyName.Contains("Amount"))
				{
					((RFMDataGridViewTextBoxColumn)c).DefaultCellStyle.Font = new Font(fntDefault, FontStyle.Italic);
				}
			}
		}

		private bool tabTerms_Restore()
		{
			btnPrint.Enabled = false;
			return (true);
		}

        private bool tabDetail_Restore()
        {
            grdDetail_Restore();
			if (grdDetail.Rows.Count > 0)
	            btnPrint.Enabled = true;
            return (true);
        }

        private bool tabTotal_Restore()
		{
			grdTotal_Restore();
			if (grdTotal.Rows.Count > 0)
				btnPrint.Enabled = true;
			return (true);
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnPrint.Enabled = false;
			}
            if (tcList.SelectedTab.Name == tabDetail.Name)
            {
                grdDetail.Select();
				if (grdDetail.Rows.Count > 0)
					btnPrint.Enabled = true;
            }
            if (tcList.SelectedTab.Name == tabTotal.Name)
            {
                grdTotal.Select();
				if (grdTotal.Rows.Count > 0)
					btnPrint.Enabled = true;
			}
		}

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

	#region RowEnter, CellFormatting

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;

			if (grd.DataSource == null)
				return;

			if (grd.Rows[e.RowIndex] == null)
				return;

			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			if (grd.Name.ToUpper().Contains("GRD"))
			{
				if (grd.Columns[e.ColumnIndex].DefaultCellStyle.Format.Contains("N"))
				{
					if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
					{
						e.Value = "";
					}
				}
			}
		}

	#endregion

	#region Restore

        private bool grdDetail_Restore()
        {
			WaitOn(this);

			TermsSelect();
			grdDetail.DataSource = null;
            bool bPartner = chkAddPartner.Checked;
            oReportForSalaryDetail.ReportForSalaryWithPenalty(dDateBeg, dDateEnd, "DETAIL", sDriversEmployeesList, bPartner);
			grdDetail.Restore(oReportForSalaryDetail.DS.Tables["ReportForSalary"]);

			WaitOff(this);

            return (oReportForSalaryDetail.ErrorNumber == 0);
        }

        private bool grdTotal_Restore()
		{
			WaitOn(this);

			TermsSelect();
			grdTotal.DataSource = null;
            bool bPartner = chkAddPartner.Checked;
            oReportForSalaryTotal.ReportForSalaryWithPenalty(dDateBeg, dDateEnd, "TOTAL", sDriversEmployeesList, bPartner);
			grdTotal.Restore(oReportForSalaryTotal.DS.Tables["ReportForSalary"]);

			WaitOff(this);

			return (oReportForSalaryTotal.ErrorNumber == 0);
		}

		private void TermsSelect()
		{
			dDateBeg = dDateEnd = null;
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				dDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				dDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			if (ucSelectRecordID_DriversEmployees.IsSelectedExist)
			{
				sDriversEmployeesList = ucSelectRecordID_DriversEmployees.GetIdString();
			}
			else
			{
				sDriversEmployeesList = null;
			}
		}

	#endregion

	#region Filters Choose

		#region DriversEmployees

		private void ucSelectRecordID_DriversEmployees_Restore()
		{
			if (ucSelectRecordID_DriversEmployees.sourceData == null)
			{
				Employee oEmployee = new Employee();
				oEmployee.FilterIsDriver = true;
				if (Utilities.FillData_Employees(oEmployee))
				{
					ucSelectRecordID_DriversEmployees.Restore(oEmployee.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_DriversEmployees.Restore();
			}
		}

		#endregion DriversEmployees

	#endregion
		
	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
			//mnuPrint.Show(btnPrint, new Point());

			string sText = "";
			if (dDateBeg.HasValue)
			{
				sText += ((DateTime)dDateBeg).ToString("dd.MM.yyyy");
				if (dDateEnd.HasValue)
					sText += " - ";
			}
			if (dDateEnd.HasValue)
				sText += ((DateTime)dDateEnd).ToString("dd.MM.yyyy");

			switch (tcList.SelectedTab.Name)
			{
				case "tabDetail":
					if (oReportForSalaryDetail.DS.Tables["ReportForSalary"].Rows.Count == 0 || grdDetail.Rows.Count == 0) 
						return;

					DataTable dtDetail = CopyTable(oReportForSalaryDetail.DS.Tables["ReportForSalary"], "dtDetail", "IsNormal = true", "DriverName, TripDateBeg");
					repForSalary repDetail = new repForSalary(sText, "DETAIL");
					StartForm(new frmActiveReport(dtDetail, repDetail));
					break;

				case "tabTotal":
					if (oReportForSalaryTotal.DS.Tables["ReportForSalary"].Rows.Count == 0 || grdTotal.Rows.Count == 0)
						return;

					DataTable dtTotal = CopyTable(oReportForSalaryTotal.DS.Tables["ReportForSalary"], "dtTotal", "IsNormal = true", "DriverName");
					repForSalary repTotal = new repForSalary(sText, "TOTAL");
					StartForm(new frmActiveReport(dtTotal, repTotal));
					break;

				default:
					break;
			}
		}

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date.AddDays(-7);
			dtrDates.dtpEndDate.Value = DateTime.Now.Date;

			ucSelectRecordID_DriversEmployees.ClearData();

			tabDetail.IsNeedRestore =
			tabTotal.IsNeedRestore =
				true;
		}
		
	#endregion

	}
}