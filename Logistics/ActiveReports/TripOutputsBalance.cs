using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripOutputsBalance : DataDynamics.ActiveReports.ActiveReport3
	{
		bool bWeighting = false; 
		public TripOutputsBalance()
		{
			InitializeComponent();
		}

		private void TripOutputsBalance_FetchData(object sender, FetchEventArgs eArgs)
		{
			bWeighting = (bool)Fields["Weighting"].Value ||
				Convert.ToInt32(Fields["InBox"].Value) != Convert.ToDecimal(Fields["InBox"].Value);

			if (bWeighting)
			{
				txtInBox.OutputFormat =
				txtQntConfirmed.OutputFormat =
				txtQntActed.OutputFormat =
				txtQntBrought.OutputFormat =
				txtQntReturned.OutputFormat =
				txtQntDiff.OutputFormat =
					"### ### ##0.000";
			}
			else
			{
				txtInBox.OutputFormat =
				txtQntConfirmed.OutputFormat =
				txtQntActed.OutputFormat =
				txtQntBrought.OutputFormat =
				txtQntReturned.OutputFormat =
				txtQntDiff.OutputFormat =
					"### ### ###";
			}
		}

		private void detail_Format(object sender, EventArgs e)
		{
		}

		private void detail_BeforePrint(object sender, EventArgs e)
		{
		}

	}
}
