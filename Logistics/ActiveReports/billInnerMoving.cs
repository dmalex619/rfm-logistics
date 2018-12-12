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
	public partial class billInnerMoving : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nOutputDocumentID = 0;
		string _cBillNumber = "";

		int _nCnt = 0;
		decimal _nOutputDocumentQnt = 0;
		decimal _nOutputDocumentBox = 0;
		decimal _nOutputDocumentBrutto = 0;
		decimal _nOutputDocumentNetto = 0;
		decimal _nAmount = 0;
		int _nCurrencyID = 0;
		string _sCurrencyAlias = "";
		string _sRubID = "";

		Font fntDefaultDetail;

        public billInnerMoving()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");

			fntDefaultDetail = txtDetailInBox.Font;
		}

        private void billInnerMoving_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nOutputDocumentID = (int)Fields["OutputDocumentID"].Value;
			_cBillNumber = Fields["BillNumber"].Value.ToString();

			_nCnt = (int)Fields["Cnt"].Value;
			_nOutputDocumentQnt = (decimal)Fields["OutputDocumentQnt"].Value;
			_nOutputDocumentBox = (decimal)Fields["OutputDocumentBox"].Value;
			_nOutputDocumentBrutto = (decimal)Fields["OutputDocumentBrutto"].Value;
			_nOutputDocumentNetto = (decimal)Fields["OutputDocumentNetto"].Value;
			_nAmount = (decimal)Fields["Amount"].Value;
			_nCurrencyID = (int)Fields["CurrencyID"].Value;
			_sCurrencyAlias = Fields["CurrencyAlias"].Value.ToString();

			if ((bool)Fields["Weighting"].Value ||
				(decimal)Fields["InBox"].Value != (int)(decimal)Fields["InBox"].Value)
			{
				txtDetailInBox.OutputFormat = "######0.000"; // InBox
				txtDetailQnt.OutputFormat = "######0.000"; // Qnt
			}
			else
			{
				txtDetailInBox.OutputFormat = "######0"; // InBox
				txtDetailQnt.OutputFormat = "######0"; // Qnt
			}

			if ((bool)Fields["Weighting"].Value)
			{
				txtDetailBox.Font = new Font(fntDefaultDetail, FontStyle.Italic);
			}
			else
			{
				txtDetailBox.Font = fntDefaultDetail;
			}
		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooterBillNumber.Text = _cBillNumber.ToString(); 
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			if (_nCurrencyID.ToString() == _sRubID)
			{
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount);
			}
			else
			{
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias); 
			}
		}
	}
}
