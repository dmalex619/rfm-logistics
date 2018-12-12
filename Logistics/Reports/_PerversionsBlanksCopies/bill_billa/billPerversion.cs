using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

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

		decimal _nVatAllSum = 0, _nNoVatAllSum = 0,
				_nVat1Rate = 0, _nVat1Sum = 0, _nNoVat1Sum = 0,
				_nVat2Rate = 0, _nVat2Sum = 0, _nNoVat2Sum = 0;

		Font fntDefaultDetail;

		public billPerversion()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");

			fntDefaultDetail = txtDetailInBox.Font;
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

			_nVatAllSum = (decimal)Fields["VatAllSum"].Value;
			_nNoVatAllSum = (decimal)Fields["NoVatAllSum"].Value;
			_nVat1Rate = (decimal)Fields["Vat1Rate"].Value;
			_nVat1Sum = (decimal)Fields["Vat1Sum"].Value;
			_nNoVat1Sum = (decimal)Fields["NoVat1Sum"].Value;
			_nVat2Rate = (decimal)Fields["Vat2Rate"].Value;
			_nVat2Sum = (decimal)Fields["Vat2Sum"].Value;
			_nNoVat2Sum = (decimal)Fields["NoVat2Sum"].Value;

			if ((bool)Fields["Weighting"].Value ||
				(decimal)Fields["InBox"].Value != (int)(decimal)Fields["InBox"].Value)
			{
				//txtDetailInBox.Font = new Font(fntDefaultDetail.Name, fntDefaultDetail.Size - 2, FontStyle.Regular);
				txtDetailInBox.OutputFormat = "######0.000"; // InBox
				//txtDetailBox.OutputFormat = "#######"; // Box
				txtDetailQnt.OutputFormat = "######0.000"; // Qnt
			}
			else
			{
				//txtDetailInBox.Font = fntDefaultDetail;
				txtDetailInBox.OutputFormat = "######0"; // InBox
				//txtDetailBox.OutputFormat = "######0.0"; // Box
				txtDetailQnt.OutputFormat = "######0"; // Qnt
			}

			/*
			if ((bool)Fields["Weighting"].Value)
			{
				txtDetailBox.Font = new Font(fntDefaultDetail, FontStyle.Italic);
			}
			else
			{
				txtDetailBox.Font = fntDefaultDetail;
			}
			*/
		}

		private void GroupHeader1_Format(object sender, EventArgs e)
		{
			if (Fields["ContractNumber"].Value.ToString().Length > 0)
			{
				txtGroupHeader1006.Text = Fields["PayerFullName"].Value.ToString() + "  Договор " + Fields["ContractNumber"].Value.ToString();
			}
			else
			{
				txtGroupHeader1006.Text = Fields["PayerFullName"].Value.ToString(); 
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
			txtGroupFooterNettoText.Text = _nOutputDocumentNetto.ToString("# ### ##0.000") + 
				" (" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " кг " +
				((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " г)";
			txtGroupFooterBruttoText.Text = _nOutputDocumentBrutto.ToString("# ### ##0.000") + 
				" (" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " кг " +
				((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " г)";
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
 		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooterBillNumber.Text = _sBillNumber.ToString(); 
		}

#region Code
/*
private void Code()
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

decimal _nVatAllSum = 0, _nNoVatAllSum = 0,
		_nVat1Rate = 0, _nVat1Sum = 0, _nNoVat1Sum = 0,
		_nVat2Rate = 0, _nVat2Sum = 0, _nNoVat2Sum = 0;

public void ActiveReport_ReportStart()
{
	LogBizObjects.Setting oRub = new LogBizObjects.Setting();
	_sRubID = oRub.FillVariable("gnCurrencyBaseID");
}

public bool ActiveReport_FetchData(bool eof)
{
	_nOutputDocumentID = (int)rpt.Fields["OutputDocumentID"].Value;
	_sBillNumber =rpt.Fields["BillNumber"].Value.ToString();
			
	_nCnt = (int)rpt.Fields["Cnt"].Value;
	_nOutputDocumentQnt = (decimal)rpt.Fields["OutputDocumentQnt"].Value;
	_nOutputDocumentBox = (decimal)rpt.Fields["OutputDocumentBox"].Value;
	_nOutputDocumentBrutto = (decimal)rpt.Fields["OutputDocumentBrutto"].Value;
	_nOutputDocumentNetto = (decimal)rpt.Fields["OutputDocumentNetto"].Value;
	_nAmount = (decimal)rpt.Fields["Amount"].Value;
	_nCurrencyID = (int)rpt.Fields["CurrencyID"].Value;
	_sCurrencyAlias = rpt.Fields["CurrencyAlias"].Value.ToString();
	
	_nVatAllSum = (decimal)rpt.Fields["VatAllSum"].Value;
	_nNoVatAllSum = (decimal)rpt.Fields["NoVatAllSum"].Value;
	_nVat1Rate = (decimal)rpt.Fields["Vat1Rate"].Value;
	_nVat1Sum = (decimal)rpt.Fields["Vat1Sum"].Value;
	_nNoVat1Sum = (decimal)rpt.Fields["NoVat1Sum"].Value;
	_nVat2Rate = (decimal)rpt.Fields["Vat2Rate"].Value;
	_nVat2Sum = (decimal)rpt.Fields["Vat2Sum"].Value;
	_nNoVat2Sum = (decimal)rpt.Fields["NoVat2Sum"].Value;

	if ((bool)rpt.Fields["Weighting"].Value)
	{
		((TextBox)rpt.Sections["Detail"].Controls["txtDetailInBox"]).OutputFormat = "# ### ##0.000";
		((TextBox)rpt.Sections["Detail"].Controls["txtDetailQnt"]).OutputFormat = "# ### ##0.000";
	}
	else
	{
		((TextBox)rpt.Sections["Detail"].Controls["txtDetailInBox"]).OutputFormat = "# ### ##0";
		((TextBox)rpt.Sections["Detail"].Controls["txtDetailQnt"]).OutputFormat = "# ### ##0";
	}
	return eof;
}

private void GroupHeader1_Format()
{
	if (rpt.Fields["ContractNumber"].Value.ToString().Length > 0)
	{
		((TextBox)rpt.Sections["GroupHeader1"].Controls["txtGroupHeader1006"]).Text = rpt.Fields["PayerFullName"].Value.ToString() + "  Договор " + rpt.Fields["ContractNumber"].Value.ToString();
	}
	else
	{
		((TextBox)rpt.Sections["GroupHeader1"].Controls["txtGroupHeader1006"]).Text = rpt.Fields["PayerFullName"].Value.ToString(); 
	}
}

public void GroupFooter1_Format()
{
	((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterAdd"]).Text = ((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterAdd"]).Tag.ToString().Replace("#", RFMPublic.RFMUtilities.Declen(_nCnt, "номер", "номера", "номеров") + " записей");
	if ((int)Math.Round(_nOutputDocumentBox, 0) != 0)
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterBoxes"]).Text = ((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterBoxes"]).Tag + 
			RFMPublic.RFMUtilities.ValToTxt((int)Math.Round(_nOutputDocumentBox, 0));
	}
	else
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterBoxes"]).Text = "";
	}
	((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterNettoText"]).Text = _nOutputDocumentNetto.ToString("# ### ##0.000") + 
		" (" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " кг " +
		((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " г)";
	((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterBruttoText"]).Text = _nOutputDocumentBrutto.ToString("# ### ##0.000") + 
		" (" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " кг " +
		((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " г)";
	if (_nCurrencyID.ToString() == _sRubID)
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterAmount"]).Text = RFMPublic.RFMUtilities.ValToRub(_nAmount);
	}
	else
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterAmount"]).Text = RFMPublic.RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias);
	}

	((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterVatSum"]).Text = _nVatAllSum.ToString("### ### ###0.00");
	((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterNoVatSum"]).Text = _nNoVatAllSum.ToString("### ### ###0.00");

	if (_nVat1Rate > 0)
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelVat1Sum"]).Text = ((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelVat1Sum"]).Tag.ToString().Replace("#", _nVat1Rate.ToString("######").Trim());
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelNoVat1Sum"]).Text = ((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelNoVat1Sum"]).Tag.ToString().Replace("#", _nVat1Rate.ToString("######").Trim());
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterVat1Sum"]).Text = _nVat1Sum.ToString("### ### ###0.00");
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterNoVat1Sum"]).Text = _nNoVat1Sum.ToString("### ### ###0.00");
	}
	else
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelVat1Sum"]).Text = 
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelNoVat1Sum"]).Text = 
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterVat1Sum"]).Text = 
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterNoVat1Sum"]).Text = 
			""; 
	}

	if (_nVat2Rate > 0)
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelVat2Sum"]).Text = ((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelVat2Sum"]).Tag.ToString().Replace("#", _nVat2Rate.ToString("######").Trim());
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelNoVat2Sum"]).Text = ((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelNoVat2Sum"]).Tag.ToString().Replace("#", _nVat2Rate.ToString("######").Trim());
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterVat2Sum"]).Text = _nVat2Sum.ToString("### ### ###0.00");
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterNoVat2Sum"]).Text = _nNoVat2Sum.ToString("### ### ###0.00");
	}
	else
	{
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelVat2Sum"]).Text =
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterLabelNoVat2Sum"]).Text =
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterVat2Sum"]).Text =
		((TextBox)rpt.Sections["GroupFooter1"].Controls["txtGroupFooterNoVat2Sum"]).Text =
			""; 
	}
}

public  void PageFooter_Format()
{
	((TextBox)rpt.Sections["PageFooter"].Controls["txtPageFooterBillNumber"]).Text = _sBillNumber	;
}
*/
#endregion Code
	}
}
