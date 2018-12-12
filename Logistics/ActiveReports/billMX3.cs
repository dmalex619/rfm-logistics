using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data;

using RFMPublic;
using LogBizObjects; 

namespace Logistics
{
	public partial class billMX3 : DataDynamics.ActiveReports.ActiveReport3
	{
		Font fntDefaultDetail;

		public billMX3()
		{
			InitializeComponent();

			fntDefaultDetail = txtQnt.Font;
		}

		private void billMX3_FetchData(object sender, FetchEventArgs eArgs)
		{
			if (Fields["Measure"].Value.ToString().ToLower().Contains("êã"))
			{
				txtQnt.Font = new Font(fntDefaultDetail.Name, fntDefaultDetail.Size - 1, FontStyle.Regular);
				txtQnt.OutputFormat = "######0.000"; 
			}
			else
			{
				txtQnt.Font = fntDefaultDetail;
				txtQnt.OutputFormat = "######0"; 
			}
            txtNettoSum.OutputFormat = "######0.0";
		}

		private void groupFooter1_Format(object sender, EventArgs e)
		{
			try
			{
				if (((DataTable)DataSource).Rows.Count > 0 && Convert.IsDBNull(((DataTable)DataSource).Rows[0]["Price"]))
				{
					txtGroupAmount.Visible = false;
				}
			}
			finally {}
		}

		private void reportFooter1_Format(object sender, EventArgs e)
		{
			lineInPageFooter.Visible = false;
		}
	}
}
