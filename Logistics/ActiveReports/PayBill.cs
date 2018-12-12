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
	public partial class PayBill : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nOutputDocumentID = 0;
		string _cBillNumber = "";

		int _nCnt = 0;
		decimal _nAmount = 0;
		int _nCurrencyID = 0;
		string _sCurrencyAlias = "";
		string _sRubID = "";

		public PayBill()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");
		}

		private void PayBill_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nOutputDocumentID = (int)Fields["OutputDocumentID"].Value;
			_cBillNumber = Fields["BillNumber"].Value.ToString();

			_nCnt = (int)Fields["Cnt"].Value;
			_nAmount = (decimal)Fields["Amount"].Value;
			_nCurrencyID = (int)Fields["CurrencyID"].Value;
			_sCurrencyAlias = Fields["CurrencyAlias"].Value.ToString();

			if ((bool)Fields["Weighting"].Value)
			{
				//txtDetail04.OutputFormat = "# ### ##0.000"; // InBox
				txtDetail06.OutputFormat = "# ### ##0.000"; // Qnt
			}
			else
			{
				//txtDetail04.OutputFormat = "# ### ##0"; // InBox
				txtDetail06.OutputFormat = "# ### ##0"; // Qnt
			}
		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooter01.Text = _cBillNumber.ToString(); 
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			txtGroupFooter108.Text = txtGroupFooter108.Tag.ToString().Replace("#", _nCnt.ToString("######").Trim()) + " " + _nAmount.ToString("### ### ##0.00#").Trim() + " " + _sCurrencyAlias;
			if (_nCurrencyID.ToString() == _sRubID)
			{
				txtGroupFooter109.Text = RFMUtilities.ValToRub(_nAmount);
			}
			else
			{
				txtGroupFooter109.Text = RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias); 
			}
		}

		private void GroupHeader1_Format(object sender, EventArgs e)
		{
			txtDateInvoice.Text = RFMUtilities.DateToTxt(DateTime.Now.Date);
		}
	}
}
