using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

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
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			if (_bFactoring)
			{
				barcode1.Visible =
				barcode2.Visible =
					true;
				barcode1.Text = 
					Utilities.GetCRCBarCode_128A(Utilities.GetAlfaBankBarCode_128A42(sPayeeINN, sPayerINN, nSum, dDate));
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
				" (" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " �� " +
				((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " �)";

			txtGroupFooterBruttoText.Text = _nOutputDocumentBrutto.ToString("# ### ##0.000") + 
				" (" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " �� " +
				((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " �)";

			 
			if (_nCurrencyID.ToString() == _sRubID)
			{
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount);
			}
			else
			{
				txtGroupFooterAmount.Text = RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias);
			}

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
			txtPageFooterFactureNumber.Text = _sFactureNumber;
		}
	}
}
