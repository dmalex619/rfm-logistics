using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripsList : DataDynamics.ActiveReports.ActiveReport3
	{
		public TripsList()
		{
			InitializeComponent();
		}

		private void Detail_Format(object sender, EventArgs e)
		{
			if (!Convert.IsDBNull(Fields["ID"].Value) && 
				((bool)Fields["IsCarried"].Value ||
				!Convert.IsDBNull(Fields["CopiedFromOutputID"].Value)))
			{
				txtPartnerName.Visible = false;
				txtPartnerNameBold.Visible = true;
			}
			else
			{
				txtPartnerName.Visible = true;
				txtPartnerNameBold.Visible = false;
			}
		}
	}
}
