using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;

using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

using RFMPublic;

namespace Logistics
{
	public partial class billAdditionWithGoodsBarCodes : DataDynamics.ActiveReports.ActiveReport3
	{
		private DataSet ds;

		int _nOutputDocumentID = 0;
		string _cBillNumber = "";
		DateTime _dDateOutput = DateTime.Now.Date;

        public billAdditionWithGoodsBarCodes()
		{
			InitializeComponent();
		}

		private void billAdd_ReportStart(object sender, EventArgs e)
		{
			ds = ((DataTable)DataSource).DataSet;

			DataRow r = ds.Tables[1].Rows[0];
			_nOutputDocumentID = Convert.ToInt32(r["ID"]);
			_cBillNumber = r["BillNumber"].ToString();
			_dDateOutput = (Convert.ToDateTime(r["DateOutput"])).Date;
		}

		private void detail_Format(object sender, EventArgs e)
		{
			if (Convert.ToBoolean(Fields["Weighting"].Value) ||
				Convert.ToDecimal(Fields["InBox"].Value) != Convert.ToInt32(Fields["InBox"].Value))
				txtInBox.OutputFormat = 
				txtQnt.OutputFormat = 
					"### ###.000";
		}

		private void billAdd_FetchData(object sender, FetchEventArgs eArgs)
		{
			if ((bool)Fields["Weighting"].Value ||
				Convert.ToDecimal(Fields["InBox"].Value) != Convert.ToInt32(Fields["InBox"].Value))
				txtInBox.OutputFormat = 
				txtQnt.OutputFormat = 
					"# ### ##0.000";
			else
				txtInBox.OutputFormat = 
				txtQnt.OutputFormat = 
					"# ### ##0";
		}

		private void pageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooterBillNumber.Text = _cBillNumber.ToString(); 
		}

		private void groupOutputDocumentID_Format(object sender, EventArgs e)
		{
			/*
			txtBillNumber.Text = RFMUtilities.GetValue(ds, 1, "ID", nOutputDocumentID, "BillNumber");
			txtDateOutput.Text = RFMUtilities.GetValue(ds, 1, "ID", nOutputDocumentID, "DateOutput").Substring(0, 10);
			txtPayerName.Text = RFMUtilities.GetValue(ds, 1, "ID", nOutputDocumentID, "PayerName");
			txtPayerFullAddress.Text = RFMUtilities.GetValue(ds, 1, "ID", nOutputDocumentID, "PayerFullAddress");
			*/
			DataRow r = ds.Tables[1].Rows[0];
			txtBillNumber.Text = _cBillNumber;
			txtDateOutput.Value = _dDateOutput;
		}
	}
}
