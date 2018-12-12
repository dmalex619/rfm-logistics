using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class InputBill : DataDynamics.ActiveReports.ActiveReport3
	{
		private int nInputID;

		public InputBill()
		{
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
			nInputID = Convert.ToInt32(Fields["InputID"].Value);

			detail.BackColor = Color.Transparent;
			if ((decimal)Fields["QntCalcDiff"].Value > 0)
			{
				detail.BackColor = Color.LightGreen;
			}
			if ((decimal)Fields["QntCalcDiff"].Value < 0)
			{
				detail.BackColor = Color.LightPink;
			}

		}

		private void pageFooter_Format(object sender, EventArgs e)
		{
			txtInputIDFooter.Text = nInputID.ToString();
		}
	}
}
