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
	public partial class billPerversion : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nOutputDocumentID = 0;
		string _sBillNumber = "";

		int _nCnt = 0;
		decimal _nOutputDocumentQnt = 0;
		decimal _nOutputDocumentBox = 0;
		decimal _nOutputDocumentBrutto = 0;
		decimal _nOutputDocumentNetto = 0;
		decimal _nAmount = 0;
		int _nCurrencyID = 0;
		string _sCurrencyAlias = "";
		string _sRubID = "";

		public billPerversion()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");
		}

		private void billPerversion_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nOutputDocumentID = (int)Fields["OutputDocumentID"].Value;
			_sBillNumber = Fields["BillNumber"].Value.ToString();

			_nCnt = (int)Fields["Cnt"].Value;
			_nOutputDocumentQnt = (decimal)Fields["OutputDocumentQnt"].Value;
			_nOutputDocumentBox = (decimal)Fields["OutputDocumentBox"].Value;
			_nOutputDocumentBrutto = (decimal)Fields["OutputDocumentBrutto"].Value;
			_nOutputDocumentNetto = (decimal)Fields["OutputDocumentNetto"].Value;
			_nAmount = (decimal)Fields["Amount"].Value;
			_nCurrencyID = (int)Fields["CurrencyID"].Value;
			_sCurrencyAlias = Fields["CurrencyAlias"].Value.ToString();

			if ((bool)Fields["Weighting"].Value)
			{
				txtDetailInBox.OutputFormat = "# ### ##0.000"; // InBox
				txtDetailQnt.OutputFormat = "# ### ##0.000"; // Qnt
			}
			else
			{
				txtDetailInBox.OutputFormat = "# ### ##0"; // InBox
				txtDetailQnt.OutputFormat = "# ### ##0"; // Qnt
			}
		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooterBillNumber.Text = _sBillNumber.ToString(); 
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			// сумма без НДС - расчетная
			txtGroupFooterNoVatSum.Value = (decimal)(Convert.ToDecimal(txtGroupFooterSum.Value) - Convert.ToDecimal(txtGroupFooterVatSum.Value));  

			txtGroupFooterAdd.Text = txtGroupFooterAdd.Tag + " " + RFMPublic.RFMUtilities.Declen(_nCnt, "номер", "номера", "номеров") + " записей.";
			if ((int)Math.Round(_nOutputDocumentBox, 0) != 0)
				txtGroupFooterBoxes.Text = txtGroupFooterBoxes.Tag + RFMPublic.RFMUtilities.ValToTxt((int)Math.Round(_nOutputDocumentBox, 0));
			else
				txtGroupFooterBoxes.Text = "";

			txtGroupFooterNetto.Text = txtGroupFooterNetto.Tag + _nOutputDocumentNetto.ToString("# ### ##0.000");
			txtGroupFooterNettoText.Text = txtGroupFooterNettoText.Tag + "(" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " кг " + 
				((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " г)";
			txtGroupFooterBrutto.Text = txtGroupFooterBrutto.Tag + _nOutputDocumentBrutto.ToString("# ### ##0.000");
			txtGroupFooterBruttoText.Text = txtGroupFooterBruttoText.Tag + "(" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " кг " +
				((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " г)";

			if (_nCurrencyID.ToString() == _sRubID)
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount);
			else
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias); 

			txtGroupFooterFromDeposit.Text = "";
		}
	}
}
