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
	public partial class TransportBill : DataDynamics.ActiveReports.ActiveReport3
	{
        DateTime dNow = DateTime.Now.Date;

		public TransportBill()
		{
			InitializeComponent();
		}

		private void Detail_Format(object sender, EventArgs e)
		{
            string sGoodName = Fields["GoodName"].Value.ToString();
            txtGoodName.Text = sGoodName.Substring(0, 1).ToUpper() + sGoodName.Substring(1, sGoodName.Length - 1);

            int nBoxes = Convert.ToInt32(Fields["SBoxes"].Value);
            txtBoxesWords.Text = RFMPublic.RFMUtilities.ValToTxt(nBoxes) + " кор.";

            txtNettoBrutto.Text = "Вес нетто - " + Convert.ToDecimal(Fields["SNetto"].Value).ToString("N3") +
                " кг, вес брутто - " + Convert.ToDecimal(Fields["SBrutto"].Value).ToString("N3") + " кг";

            txtChargeData.Text = txtBoxesWords.Text + ", " + txtNettoBrutto.Text.ToLower() + " на месте погрузки";
            txtDischargeData.Text = txtBoxesWords.Text + ", " + txtNettoBrutto.Text.ToLower() + " на месте выгрузки";

            txtDocuments.Text = 
                (Fields["OrderNumbersList"].Value.ToString().Length > 0 ? "Зак. № " + Fields["OrderNumbersList"].Value.ToString() + ", " : "") +
                (Fields["FactureNumbersList"].Value.ToString().Length > 0 ? "УПД/С-Ф № " + Fields["FactureNumbersList"].Value.ToString() + ", " : "") +
                (Fields["BillNumbersList"].Value.ToString().Length > 0 ? "Накл. № " + Fields["BillNumbersList"].Value.ToString() + ", " : "") +
                (Fields["BillNumbersList"].Value.ToString().Length > 0 ? "декларации соответствия, удостоверения качества" : "");

            txtDriverName.Text = Fields["DriverName"].Value.ToString() + 
                (Fields["DriverPhone"].Value.ToString().Length > 0 ? ", моб.тел. " + Fields["DriverPhone"].Value.ToString().ToString() : "");
            txtCarInfo.Text = 
                (Fields["CarTypeName"].Value.ToString().Length > 0 ? Fields["CarTypeName"].Value.ToString() + ", " : "") +
                Fields["CarNumber"].Value.ToString() +
                (Fields["TrailerNumber"].Value.ToString().Length > 0 ? ", прицеп " + Fields["TrailerNumber"].Value.ToString() : "");

            /*txtCurrentUserName1.Text = txtCurrentUserName2.Text = 
                ((RFMBaseClasses.RFMFormMain)System.Windows.Forms.Application.OpenForms[0]).UserInfo.UserAlias;*/
        }
	}
}
