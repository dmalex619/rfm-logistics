using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class OutputBill : DataDynamics.ActiveReports.ActiveReport3
	{
		private int nOutputID;
		private bool bIsOutputCarried = false;

		public OutputBill()
		{
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
			nOutputID = Convert.ToInt32(Fields["OutputID"].Value);
		}

		private void pageFooter_Format(object sender, EventArgs e)
		{
			txtOutputIDFooter.Text = nOutputID.ToString();
		}

		private void groupOutputID_Format(object sender, EventArgs e)
		{
			if (bIsOutputCarried)
			{
				txtCarry.Text = "оепемня";
			}
			else
			{
				txtCarry.Text = "";
			}
		}

		private void OutputBill_FetchData(object sender, FetchEventArgs eArgs)
		{
			bIsOutputCarried = !Convert.IsDBNull(Fields["IsCarried"].Value) && Convert.ToBoolean(Fields["IsCarried"].Value) ||
									!Convert.IsDBNull(Fields["CopiedFromOutputID"].Value); 
		}
	}
}
