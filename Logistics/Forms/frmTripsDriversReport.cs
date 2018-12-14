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
	public partial class frmTripsDriversReport: RFMFormChild
	{
		public string _SelectedIDList;
		public string _SelectedText;

		private string sSelectedDriversIDList = null;
		private string sSelectedOwnersIDList = null;

		private Report oReport;

		public frmTripsDriversReport()
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

		private void frmTripsDriversReport_Load (object sender, EventArgs e)
		{
			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			dtrDates.dtpEndDate.Value = DateTime.Now.AddDays(-DateTime.Now.Day).Date;
			dtrDates.dtpBegDate.Value = dtrDates.dtpEndDate.Value.AddDays(-dtrDates.dtpEndDate.Value.Day).AddDays(1).Date;

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
			grdData_Restore(); 
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			grdData.ExportData();
		}

		#region Restore 

		private bool grdData_Restore()
		{
			WaitOn(this);
			grdData.DataSource = null;

			DateTime? dDateBeg = null;
			if (!dtrDates.dtpBegDate.IsEmpty)
				dDateBeg = dtrDates.dtpBegDate.Value.Date;
			DateTime? dDateEnd = null;
			if (!dtrDates.dtpEndDate.IsEmpty)
				dDateEnd = dtrDates.dtpEndDate.Value.Date;
            int nMode = (radByAddress.Checked ? 1 : 2);

            oReport.Report_TripsPointsCalc(dDateBeg, dDateEnd, sSelectedDriversIDList, sSelectedOwnersIDList, nMode);
			if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
			{
				if (oReport.MainTable.Rows.Count == 0)
				{
					WaitOff(this);
					RFMMessage.MessageBoxInfo("Нет данных...");
				}
				grdData.Restore(oReport.MainTable);
			}
			WaitOff(this);
			return (oReport.ErrorNumber == 0);
		}

		#endregion Restore

		#region Terms 

		private void btnDriversChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";
			sSelectedDriversIDList = null;

			Driver oDriver = new Driver();
			oDriver.FillData();
			oDriver.FilterActual = true;
			if (oDriver.ErrorNumber != 0 || oDriver.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных...");
				return;
			}
			if (oDriver.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			if (StartForm(new frmSelectID(this, oDriver.MainTable, "Name,Actual", "Клиент,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnDriversClear_Click(null, null);
					return;
				}

				sSelectedDriversIDList = "," + _SelectedIDList;
				txtDriversChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtDriversChoosen, txtDriversChoosen.Text);
			}
			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnDriversClear_Click(object sender, EventArgs e)
		{
			ttToolTip.SetToolTip(txtDriversChoosen, "не выбраны");
			sSelectedDriversIDList = null;
			txtDriversChoosen.Text = "";
		}

		private void btnOwnersChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";
			sSelectedOwnersIDList = null;

			Partner oOwner = new Partner();
			oOwner.FilterIsOwner = true;
			oOwner.FilterActual = true;
			oOwner.FillData();
			if (oOwner.ErrorNumber != 0 || oOwner.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных...");
				return;
			}
			if (oOwner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			if (StartForm(new frmSelectID(this, oOwner.MainTable, "Name,Actual", "Владелец,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnOwnersClear_Click(null, null);
					return;
				}

				sSelectedOwnersIDList = "," + _SelectedIDList;
				txtOwnersChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtOwnersChoosen, txtOwnersChoosen.Text);
			}
			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnOwnersClear_Click(object sender, EventArgs e)
		{
			ttToolTip.SetToolTip(txtOwnersChoosen, "не выбраны");
			sSelectedOwnersIDList = null;
			txtOwnersChoosen.Text = "";
		}

		#endregion Terms

	}
}
