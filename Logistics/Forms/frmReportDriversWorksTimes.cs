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
	public partial class frmReportDriversWorksTimes: RFMFormChild
	{
		private Report oReport;

		public frmReportDriversWorksTimes()
		{
			oReport = new Report();
			if (oReport.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmReportDriversWorksTimes_Load (object sender, EventArgs e)
		{
			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			dtrDates.dtpEndDate.Value = DateTime.Now.AddDays(-DateTime.Now.Day).Date;
			dtrDates.dtpBegDate.Value = dtrDates.dtpEndDate.Value.AddDays(-dtrDates.dtpEndDate.Value.Day).AddDays(1).Date;

			grcTrips_DurationPartsWay_.AgrType = EnumAgregate.Sum;
 
			//btnGo_Click(null, null);
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			grdTrips_Restore(); 
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			grdTrips.ExportData();
		}

		#region Restore

		private bool grdTrips_Restore()
		{
			WaitOn(this);
			grdTrips.DataSource = null;

			DateTime? dDateBeg = null;
			if (!dtrDates.dtpBegDate.IsEmpty)
				dDateBeg = dtrDates.dtpBegDate.Value.Date;
			DateTime? dDateEnd = null;
			if (!dtrDates.dtpEndDate.IsEmpty)
				dDateEnd = dtrDates.dtpEndDate.Value.Date;
			string sSelectedDriversIDList = ucSelectRecordID_Drivers.GetIdString();

  			oReport.Report_DriversWorksTimes(dDateBeg, dDateEnd, sSelectedDriversIDList, 
				((chkTotal.Checked) ? 2 : 1));
			if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
			{
				if (oReport.MainTable.Rows.Count == 0)
				{
					WaitOff(this);
					RFMMessage.MessageBoxInfo("Нет данных...");
				}
				grdTrips.Restore(oReport.MainTable);
			}

			foreach (DataGridViewColumn c in grdTrips.Columns)
			{
				if (c.Name.Substring(c.Name.Length - 1, 1) != "_")
					c.Visible = !chkTotal.Checked; 
			}


			WaitOff(this);
			return (oReport.ErrorNumber == 0);
		}

		#endregion Restore

		#region Terms 

		#region SelectID

		private void ucSelectRecordID_Drivers_Restore()
		{
			Driver oDriver = new Driver();
			if (Utilities.FillData_Drivers(oDriver))
			{
				ucSelectRecordID_Drivers.Restore(oDriver.MainTable);
			}
		}

		#endregion SelectID

		#endregion Terms

	}
}
