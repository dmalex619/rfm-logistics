using System;
using RFMBaseClasses;

namespace Logistics
{
	public partial class frmMain : RFMFormMain
	{
		public frmMain() : base()
		{
			InitializeComponent();
		}

		private void mniTrips_Click(object sender, EventArgs e)
		{
			StartForm(new frmTrips());
		}

		private void mniLogistics_Click(object sender, EventArgs e)
		{
			StartForm(new frmLogistics());
		}

		private void mniOutputsInputs_Click(object sender, EventArgs e)
		{
			StartForm(new frmOutputsInputs());
		}

		private void mniOutputsInputsDocuments_Click(object sender, EventArgs e)
		{
			StartForm(new frmOutputsInputsDocuments());
		}

		private void mniActs_Click(object sender, EventArgs e)
		{
			StartForm(new frmActs());
		}

        private void mniCarsTasks_Click(object sender, EventArgs e)
        {
            StartForm(new frmCarsTasks());
        }

		private void mniFreeOperations_Click(object sender, EventArgs e)
		{
			StartForm(new frmFreeOperations());
		}

		private void mniWayBills_Click(object sender, EventArgs e)
		{
			StartForm(new frmWayBills());
		}

		private void mniPasses_Click(object sender, EventArgs e)
		{
			StartForm(new frmPasses());
		}

		private void mniGatesHistory_Click(object sender, EventArgs e)
		{
			StartForm(new frmGatesHistory());
		}

		private void mniWarrantsNumbers_Click(object sender, EventArgs e)
		{
			StartForm(new frmWarrantsNumbers());
		}

		private void mniFacturesNumbers_Click(object sender, EventArgs e)
		{
			StartForm(new frmFacturesNumbers());
		}

		private void mniOutputsInputsCarries_Click(object sender, EventArgs e)
		{
			StartForm(new frmOutputsInputsCarries());
		}

        private void mniExchangeLog_Click(object sender, EventArgs e)
        {
            StartForm(new frmExchangeLog());
        }

		private void mniCars_Click(object sender, EventArgs e)
		{
			StartForm(new frmCars());
		}

		private void mniEmployeesDrivers_Click(object sender, EventArgs e)
		{
			StartForm(new frmEmployeesDrivers());
		}

		private void mniPartners_Click(object sender, EventArgs e)
		{
			StartForm(new frmPartners());
		}

		private void mniGoods_Click(object sender, EventArgs e)
		{
			StartForm(new frmGoods());
		}

		private void mniReportGoods_Click(object sender, EventArgs e)
		{
			RFMFormBase frmNull = null;
			StartForm(new frmSelectOnePacking(frmNull, true));
		}

		private void mniReportPartners_Click(object sender, EventArgs e)
		{
			StartForm(new frmSelectOnePartner(null, "D", false, false));
		}

		private void mniReportTripsDriversReport_Click(object sender, EventArgs e)
		{
			StartForm(new frmTripsDriversReport());
		}

		private void mniReportDriversWorksReport_Click(object sender, EventArgs e)
		{
			StartForm(new frmReportDriversWorksTimes());
		}

		private void mniReportTripsCosts_Click(object sender, EventArgs e)
		{
			StartForm(new frmReportTripsCosts());
		}

		private void mniReportForSalary_Click(object sender, EventArgs e)
		{
			StartForm(new frmReportForSalary());
		}

        private void mniReportForSalaryWithPenalty_Click(object sender, EventArgs e)
        {
            StartForm(new frmReportForSalaryWithPenalty());
        }

		private void mniSalaryExtraWorks_Click(object sender, EventArgs e)
		{
			StartForm(new frmSalaryExtraWorks());
		}

		private void mniSalaryTariffs_Click(object sender, EventArgs e)
		{
			StartForm(new frmSalaryTariffs());
		}

		private void mniTables_Click(object sender, EventArgs e)
		{
			StartForm(new frmSysLook());
		}

		private void mniUsers_Click(object sender, EventArgs e)
		{
			StartForm(new frmUsers());
		}

		private void mniExchange_Click(object sender, EventArgs e)
		{
			StartForm(new frmExchangeData()); 
		}

		#region Access

		private void mniAccessMainMenu_Click(object sender, EventArgs e)
		{
			StartForm(new frmAccessMainMenu());
		}

		private void mniAccessFormsMenus_Click(object sender, EventArgs e)
		{
			StartForm(new frmAccessFormsMenus());
		}

		private void mniAccessFormsControls_Click(object sender, EventArgs e)
		{
			StartForm(new frmAccessControls());
		}

		#endregion Access

		private void mniAccessConvertation_Click(object sender, EventArgs e)
		{
			StartForm(new frmAccessConversion());
		}

		private void mniAccessClearing_Click(object sender, EventArgs e)
		{
			StartForm(new frmAccessConversion(true));
		}

	}
}