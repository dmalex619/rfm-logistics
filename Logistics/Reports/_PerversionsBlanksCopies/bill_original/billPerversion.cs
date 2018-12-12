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
/*
		decimal _nVatAllSum = 0, _nNoVatAllSum = 0,
				_nVat1Rate = 0, _nVat1Sum = 0, _nNoVat1Sum = 0,
				_nVat2Rate = 0, _nVat2Sum = 0, _nNoVat2Sum = 0;
*/
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
/*
			_nVatAllSum = (decimal)Fields["VatAllSum"].Value;
			_nNoVatAllSum = (decimal)Fields["NoVatAllSum"].Value;
			_nVat1Rate = (decimal)Fields["Vat1Rate"].Value;
			_nVat1Sum = (decimal)Fields["Vat1Sum"].Value;
			_nNoVat1Sum = (decimal)Fields["NoVat1Sum"].Value;
			_nVat2Rate = (decimal)Fields["Vat2Rate"].Value;
			_nVat2Sum = (decimal)Fields["Vat2Sum"].Value;
			_nNoVat2Sum = (decimal)Fields["NoVat2Sum"].Value;
*/
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
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			txtGroupFooterAdd.Text = txtGroupFooterAdd.Tag.ToString().Replace("#", RFMPublic.RFMUtilities.Declen(_nCnt, "номер", "номера", "номеров") + " записей");
			if ((int)Math.Round(_nOutputDocumentBox, 0) != 0)
			{
				txtGroupFooterBoxes.Text = txtGroupFooterBoxes.Tag + RFMPublic.RFMUtilities.ValToTxt((int)Math.Round(_nOutputDocumentBox, 0));
			}
			else
			{
				txtGroupFooterBoxes.Text = "";
			}
			txtGroupFooterNetto.Text = txtGroupFooterNetto.Tag + _nOutputDocumentNetto.ToString("# ### ##0.000");
			txtGroupFooterNettoText.Text = txtGroupFooterNettoText.Tag + "(" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " кг " + 
				((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " г)";
			txtGroupFooterBrutto.Text = txtGroupFooterBrutto.Tag + _nOutputDocumentBrutto.ToString("# ### ##0.000");
			txtGroupFooterBruttoText.Text = txtGroupFooterBruttoText.Tag + "(" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " кг " +
				((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " г)";
			if (_nCurrencyID.ToString() == _sRubID)
			{
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount);
			}
			else
			{
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias); 
			}
			/*
			txtGroupFooterVatSum.Text = _nVatAllSum.ToString("### ### ###0.00");
			txtGroupFooterNoVatSum.Text = _nNoVatAllSum.ToString("### ### ###0.00");

			if (_nVat1Rate > 0)
			{
				txtGroupFooterLabelVat1Sum.Text = txtGroupFooterLabelVat1Sum.Tag.ToString().Replace("#", _nVat1Rate.ToString("######").Trim());
				txtGroupFooterLabelNoVat1Sum.Text = txtGroupFooterLabelNoVat1Sum.Tag.ToString().Replace("#", _nVat1Rate.ToString("######").Trim());
				txtGroupFooterVat1Sum.Text = _nVat1Sum.ToString("### ### ###0.00");
				txtGroupFooterNoVat1Sum.Text = _nNoVat1Sum.ToString("### ### ###0.00");
			}
			else
			{
				txtGroupFooterLabelVat1Sum.Text =
				txtGroupFooterLabelNoVat1Sum.Text =
				txtGroupFooterVat1Sum.Text =
				txtGroupFooterNoVat1Sum.Text =
					"";
			}

			if (_nVat2Rate > 0)
			{
				txtGroupFooterLabelVat2Sum.Text = txtGroupFooterLabelVat2Sum.Tag.ToString().Replace("#", _nVat2Rate.ToString("######").Trim());
				txtGroupFooterLabelNoVat2Sum.Text = txtGroupFooterLabelNoVat2Sum.Tag.ToString().Replace("#", _nVat2Rate.ToString("######").Trim());
				txtGroupFooterVat2Sum.Text = _nVat2Sum.ToString("### ### ###0.00");
				txtGroupFooterNoVat2Sum.Text = _nNoVat2Sum.ToString("### ### ###0.00");
			}
			else
			{
				txtGroupFooterLabelVat2Sum.Text =
				txtGroupFooterLabelNoVat2Sum.Text =
				txtGroupFooterVat2Sum.Text =
				txtGroupFooterNoVat2Sum.Text =
					"";
			}
			*/ 
		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooterBillNumber.Text = _sBillNumber.ToString();
		}
	}
}
