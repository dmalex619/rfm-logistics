using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class PassBill : DataDynamics.ActiveReports.ActiveReport3
	{
		public PassBill()
		{
			InitializeComponent();
		}

		private void Detail_Format(object sender, EventArgs e)
		{
			txtDetail02.Text = RFMPublic.RFMUtilities.DateToTxt(Convert.ToDateTime(Fields["DatePass"].Value));
			string sCarTypeName = Fields["CarTypeName"].Value.ToString();
			txtDetail02.Text = (sCarTypeName.Length == 0 || sCarTypeName.Substring(0, 1) == "_") ? "" : sCarTypeName;
		}
	}
}
