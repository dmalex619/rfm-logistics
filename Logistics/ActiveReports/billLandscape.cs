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
	public partial class billLandscape : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nOutputDocumentID = 0;
		string _cBillNumber = "";
		string sDateBring = "";

		int _nCnt = 0;
		decimal _nOutputDocumentQnt = 0;
		decimal _nOutputDocumentBox = 0;
		decimal _nOutputDocumentBrutto = 0;
		decimal _nOutputDocumentNetto = 0;
		decimal _nAmount = 0;
		int _nCurrencyID = 0;
		string _sCurrencyAlias = "";
		string _sRubID = "";
		string _sContractNumberDate = "";

		Font fntDefaultDetail;

		public billLandscape()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");

			fntDefaultDetail = txtDetailInBox.Font;
		}

		private void billLandscape_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nOutputDocumentID = (int)Fields["OutputDocumentID"].Value;
			_cBillNumber = Fields["BillNumber"].Value.ToString();

			sDateBring = Fields["DateBring"].Value.ToString();

			_nCnt = (int)Fields["Cnt"].Value;
			_nOutputDocumentQnt = (decimal)Fields["OutputDocumentQnt"].Value;
			_nOutputDocumentBox = (decimal)Fields["OutputDocumentBox"].Value;
			_nOutputDocumentBrutto = (decimal)Fields["OutputDocumentBrutto"].Value;
			_nOutputDocumentNetto = (decimal)Fields["OutputDocumentNetto"].Value;
			//_nAmount = (decimal)Fields["Amount"].Value;
			_nAmount = (decimal)Fields["PriceAllSum"].Value;
			_nCurrencyID = (int)Fields["CurrencyID"].Value;
			_sCurrencyAlias = Fields["CurrencyAlias"].Value.ToString();

			// № и дата договора
			if (Fields["ContractNumber"].Value != null && Fields["ContractNumber"].Value.ToString().Length > 0)
				_sContractNumberDate += "дог. № " + Fields["ContractNumber"].Value.ToString();
			if (_sContractNumberDate.Length > 0 && Fields["ContractDate"].Value != null && Fields["ContractDate"].Value != DBNull.Value)
				_sContractNumberDate += " от " + Convert.ToDateTime(Fields["ContractDate"].Value).ToString("dd.MM.yyyy");
			txtContractNumberDate.Text = _sContractNumberDate;

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

			// Для возможности печати чистовых документов менеджерами 
			// (после подтверждения доставки клиенту)
			// сбрасываем алиас пользователя
			if (sDateBring.Length == 0)
			{
				txtCurrentUserName.Text =
				txtCurrentUserName1.Text =
					((RFMBaseClasses.RFMFormMain)System.Windows.Forms.Application.OpenForms[0]).UserInfo.UserAlias;
			}
			else
			{
				txtCurrentUserName.Text = txtCurrentUserName1.Text = "";
			}
		}
	}
}
