using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class WayBillShort : DataDynamics.ActiveReports.ActiveReport3
	{
		public WayBillShort()
		{
			InitializeComponent();
		}

		private void Detail_Format(object sender, EventArgs e)
		{
			tbDate.Text = RFMPublic.RFMUtilities.DateToTxt(Convert.ToDateTime(Fields["DateWayBeg"].Value));
            tbFuelDataBeg.Text = Convert.ToInt32(Fields["FuelDataBeg"].Value).ToString();
		}
	}
}
