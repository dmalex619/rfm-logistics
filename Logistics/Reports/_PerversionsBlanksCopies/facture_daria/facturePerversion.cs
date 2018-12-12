using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

using RFMPublic;

namespace Logistics
{
	public partial class facturePerversion : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nOutputDocumentID = 0;
		string _sFactureNumber = "";
		bool _bFactoring = false;

		string _sPartnerOrderNumber = "";

		string sPayeeINN = "";
		string sPayerINN = "";
		decimal nSum = 0; 
		DateTime dDate = DateTime.Now.Date;
		string sIsoCode = "";

		decimal _nAmount = 0;
		int _nCurrencyID = 0;
		string _sCurrencyAlias = "";
		string _sRubID = "";
/*
		decimal _nVatAllSum = 0, _nNoVatAllSum = 0,
			_nVat1Rate = 0, _nVat1Sum = 0, _nNoVat1Sum = 0,
			_nVat2Rate = 0, _nVat2Sum = 0, _nNoVat2Sum = 0;
*/
		public facturePerversion()
		{
			InitializeComponent();
		}

		private void facturePerversion_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nOutputDocumentID = (int)Fields["OutputDocumentID"].Value;
			_sFactureNumber = Fields["FactureNumber"].Value.ToString();
			_bFactoring = (bool)Fields["Factoring"].Value;

			_sPartnerOrderNumber = Fields["PartnerOrderNumber"].Value.ToString();

			sPayeeINN = Fields["PayeeINN"].Value.ToString();
			sPayerINN = Fields["PayerINN"].Value.ToString();
			nSum = (decimal)Fields["Amount"].Value;
			dDate = (DateTime)Fields["DateOutput"].Value;
			sIsoCode = Fields["CurrencyISODigitalCode"].Value.ToString();

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
			if ((bool)Fields["Weighting"].Value)
            {
                txtDetailQnt.OutputFormat = "# ### ##0.000"; // Qnt
            }
            else
            {
                txtDetailQnt.OutputFormat = "# ### ##0"; // Qnt
            }
        }

		private void GroupHeader1_Format(object sender, EventArgs e)
		{
			lblFactoring1.Visible = 
			lblFactoring2.Visible = 
				_bFactoring;

			if (_sPartnerOrderNumber != null && _sPartnerOrderNumber.Length > 0 &&
					_sPartnerOrderNumber.Contains("/"))
				txtGroupHeaderFactureNumber.Value = _sPartnerOrderNumber.Substring(_sPartnerOrderNumber.IndexOf("/") + 1);
			else
				txtGroupHeaderFactureNumber.Value = _sFactureNumber;
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			if (_bFactoring)
			{
				barcode1.Visible =
				barcode2.Visible =
					true;
				barcode1.Text = Utilities.GetCRCBarCode_128A(Utilities.GetAlfaBankBarCode_128A42(sPayeeINN, sPayerINN, nSum, dDate));
				barcode2.Text = Utilities.GetCRCBarCode_128A(Utilities.GetAlfaBankBarCode_128A40(_sFactureNumber, sIsoCode));
			}
			else
			{
				barcode1.Visible =
				barcode2.Visible =
				false;
			}

			/*
			txtGroupFooterAdd.Text = txtGroupFooterAdd.Tag.ToString().Replace("#", _nCnt.ToString().Trim() + " (" + RFMPublic.RFMUtilities.ValToTxt(_nCnt) + ")");
			
			txtGroupFooterContractNumber.Text = _sContractNumberText;

			if ((int)Math.Round(_nOutputDocumentBox, 0) != 0)
			{
				txtGroupFooterBoxes.Text = txtGroupFooterBoxes.Tag + RFMPublic.RFMUtilities.ValToTxt((int)Math.Round(_nOutputDocumentBox, 0));
			}
			else
			{
				txtGroupFooterBoxes.Text = "";
			}

			txtGroupFooterNettoText.Text = _nOutputDocumentNetto.ToString("# ### ##0.000") +
				" (" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " êã " +
				((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " ã)";

			txtGroupFooterBruttoText.Text = _nOutputDocumentBrutto.ToString("# ### ##0.000") + 
				" (" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " êã " +
				((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " ã)";
			*/
			 
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
			if (_sPartnerOrderNumber != null && _sPartnerOrderNumber.Length > 0 &&
					_sPartnerOrderNumber.Contains("/"))
				txtPageFooterFactureNumber.Value = _sPartnerOrderNumber.Substring(_sPartnerOrderNumber.IndexOf("/") + 1);
			else
				txtPageFooterFactureNumber.Value = _sFactureNumber;
		}
	}
}
