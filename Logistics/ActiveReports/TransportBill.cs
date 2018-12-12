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
            txtBoxesWords.Text = RFMPublic.RFMUtilities.ValToTxt(nBoxes) + " ���.";

            txtNettoBrutto.Text = "��� ����� - " + Convert.ToInt32(Fields["SNetto"].Value).ToString() +
                " ��, ��� ������ - " + Convert.ToInt32(Fields["SBrutto"].Value).ToString() + " ��";

            txtChargeData.Text = txtBoxesWords.Text + ", " + txtNettoBrutto.Text.ToLower() + " �� ����� ��������";
            txtDischargeData.Text = txtBoxesWords.Text + ", " + txtNettoBrutto.Text.ToLower() + " �� ����� ��������";

            txtDriverName.Text = Fields["DriverName"].Value.ToString() + 
                (Fields["DriverPhone"].Value.ToString().Length > 0 ? ", ���.���. " + Fields["DriverPhone"].Value.ToString().ToString() : "");
            txtCarInfo.Text = Fields["CarTypeName"].Value.ToString() + ", " +
                Fields["CarNumber"].Value.ToString() +
                (Fields["TrailerNumber"].Value.ToString().Length > 0 ? ", ������ " + Fields["TrailerNumber"].Value.ToString() : "");

            txtCurrentUserName1.Text = txtCurrentUserName2.Text = 
                ((RFMBaseClasses.RFMFormMain)System.Windows.Forms.Application.OpenForms[0]).UserInfo.UserAlias;
        }
	}
}
