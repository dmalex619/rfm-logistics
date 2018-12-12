using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class InputDocumentBill : DataDynamics.ActiveReports.ActiveReport3
	{
		private int nInputDocumentID;

		public InputDocumentBill()
		{
			InitializeComponent();
		}

		private void detail_Format(object sender, EventArgs e)
		{
			nInputDocumentID = Convert.ToInt32(Fields["InputDocumentID"].Value);
		}

		private void pageFooter_Format(object sender, EventArgs e)
		{
			txtInputDocumentIDFooter.Text = nInputDocumentID.ToString();
		}
	}
}
