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
	public partial class billMX1 : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nInputID = 0;

		Font fntDefaultDetail;

		public billMX1()
		{
			InitializeComponent();

			fntDefaultDetail = txtQnt.Font;
		}

		private void billMX1_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nInputID = Convert.ToInt32(Fields["InputID"].Value);

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

		private void reportHeader1_BeforePrint(object sender, EventArgs e)
		{
			if (Fields.Contains("BillNumber"))
				txtBillNumber.DataField = "BillNumber";
			else
				txtBillNumber.DataField = "InputID";
		}

		private void reportFooter1_Format(object sender, EventArgs e)
		{
			lineInPageFooter.Visible = false;
		}
	}
}
