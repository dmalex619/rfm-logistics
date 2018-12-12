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
	public partial class billPortrait : DataDynamics.ActiveReports.ActiveReport3
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

		public billPortrait()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");

			fntDefaultDetail = txtDetail05.Font;
		}

		private void billPortrait_FetchData(object sender, FetchEventArgs eArgs)
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
				Convert.ToDecimal(Fields["InBox"].Value) != Convert.ToInt32(Fields["InBox"].Value))
			{
				txtDetail04.Font = new Font(fntDefaultDetail.Name, fntDefaultDetail.Size - 2, FontStyle.Regular);
				txtDetail04.OutputFormat = "# ### ##0.000"; // InBox
				//txtDetail05.OutputFormat = "# ### ###"; // Box
				txtDetail06.OutputFormat = "# ### ##0.000"; // Qnt
			}
			else
			{
				txtDetail04.Font = fntDefaultDetail;
				txtDetail04.OutputFormat = "# ### ##0"; // InBox
				//txtDetail05.OutputFormat = "# ### ##0.0"; // Box
				txtDetail06.OutputFormat = "# ### ##0"; // Qnt
			}
		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooter01.Text = _cBillNumber.ToString(); 
		}

        private void GroupHeader1_Format(object sender, EventArgs e)
        {
            lineNoFacture.Visible = lineNoFacture2.Visible = 
                (Convert.ToString(Fields["FactureNumber"].Value).Length > 0 ? false : true);
        }

        private void GroupFooter1_Format(object sender, EventArgs e)
		{
            // сумма без НДС - расчетная
			txtGroupFooter107.Value = (decimal)(Convert.ToDecimal(txtGroupFooter106.Value) - Convert.ToDecimal(txtGroupFooter105.Value));  

			txtGroupFooter108.Text = txtGroupFooter108.Tag + " " + RFMPublic.RFMUtilities.Declen(_nCnt, "номер", "номера", "номеров") + " записей.";
			if ((int)Math.Round(_nOutputDocumentBox, 0) != 0)
			{
				txtGroupFooter109.Text = txtGroupFooter109.Tag + RFMPublic.RFMUtilities.ValToTxt((int)Math.Round(_nOutputDocumentBox, 0));
			}
			else
			{
				txtGroupFooter109.Text = "";
			}
			txtGroupFooter110.Text = txtGroupFooter110.Tag + _nOutputDocumentNetto.ToString("# ### ##0.000");
			txtGroupFooter111.Text = txtGroupFooter111.Tag + "(" + ((int)Math.Floor(_nOutputDocumentNetto)).ToString("# ### ##0").Trim() + " кг " + 
				((int)((_nOutputDocumentNetto - Math.Floor(_nOutputDocumentNetto)) * 1000)).ToString("000") + " г)";
			txtGroupFooter112.Text = txtGroupFooter112.Tag + _nOutputDocumentBrutto.ToString("# ### ##0.000");
			txtGroupFooter113.Text = txtGroupFooter113.Tag + "(" + ((int)Math.Floor(_nOutputDocumentBrutto)).ToString("# ### ##0").Trim() + " кг " +
				((int)((_nOutputDocumentBrutto - Math.Floor(_nOutputDocumentBrutto)) * 1000)).ToString("000") + " г)";
			if (_nCurrencyID.ToString() == _sRubID)
			{
				txtGroupFooter114.Text = RFMUtilities.ValToRub(_nAmount);
			}
			else
			{
				txtGroupFooter114.Text = RFMUtilities.ValToRub(_nAmount, _sCurrencyAlias); 
			}
			txtGroupFooter115.Text = "";
		}
	}
}
