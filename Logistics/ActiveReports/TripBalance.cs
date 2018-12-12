using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripBalance : DataDynamics.ActiveReports.ActiveReport3
	{
		bool bWeighting = false; 
		public TripBalance()
		{
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
		}

		private void TripBalance_FetchData(object sender, FetchEventArgs eArgs)
		{
			bWeighting = (bool)Fields["Weighting"].Value ||
				Convert.ToInt32(Fields["InBox"].Value) != Convert.ToDecimal(Fields["InBox"].Value);

			if (bWeighting)
			{
				txtInBox.OutputFormat =
				txtQntShipped.OutputFormat =
				txtQntActed.OutputFormat =
				txtQntDelivered.OutputFormat =
				txtQntReturned.OutputFormat =
				txtQntTripBalance.OutputFormat =
					"### ### ##0.000";
			}
			else
			{
				txtInBox.OutputFormat =
				txtQntShipped.OutputFormat =
				txtQntActed.OutputFormat =
				txtQntDelivered.OutputFormat =
				txtQntReturned.OutputFormat =
				txtQntTripBalance.OutputFormat =
					"### ### ###";
			}
		}
	}
}
