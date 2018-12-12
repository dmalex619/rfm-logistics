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
	public partial class billM15 : DataDynamics.ActiveReports.ActiveReport3
	{
		Font fntDefaultDetail;

		public billM15()
		{
			InitializeComponent();

			fntDefaultDetail = txtQnt.Font;
		}

		private void billM15_FetchData(object sender, FetchEventArgs eArgs)
		{
			if ((bool)Fields["Weighting"].Value)
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

        private void reportFooter1_Format(object sender, EventArgs e)
        {
            txtPosCountText.Text = RFMPublic.RFMUtilities.ValToTxt(((DataTable)this.DataSource).Rows.Count).ToLower();
        }
	}
}
