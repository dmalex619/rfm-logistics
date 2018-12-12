using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripsListNotes : DataDynamics.ActiveReports.ActiveReport3
	{
		public TripsListNotes()
		{
			InitializeComponent();
		}

		private void Detail_Format(object sender, EventArgs e)
		{
			if (!Convert.IsDBNull(Fields["ID"].Value) && 
				((bool)Fields["IsCarried"].Value ||
				!Convert.IsDBNull(Fields["CopiedFromOutputDocumentID"].Value)))
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
