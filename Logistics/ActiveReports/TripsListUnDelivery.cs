using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripsListUnDelivery : DataDynamics.ActiveReports.ActiveReport3
	{
		bool bWeighting = false; 
		public TripsListUnDelivery()
		{
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
		}

		private void TripsListUnDelivery_FetchData(object sender, FetchEventArgs eArgs)
		{
			bWeighting = (bool)Fields["Weighting"].Value;
		}

		private void detail_BeforePrint(object sender, EventArgs e)
		{
			if (bWeighting)
			{
				txtInBox.OutputFormat =
				txtQntShipped.OutputFormat =
				txtQntActed.OutputFormat =
				txtQntDelivered.OutputFormat =
					"### ### ##0.000";
			}
			else
			{
				txtInBox.OutputFormat =
				txtQntShipped.OutputFormat =
				txtQntActed.OutputFormat =
				txtQntDelivered.OutputFormat =
					"### ### ###";
			}
		}
	}
}
