using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class facture : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nOutputDocumentID = 0;
		string _sFactureNumber = "";
		bool _bFactoring = false;
        string sDateBring = "";
        string sHostShortCode = "";

		string sPayeeINN = "";
		string sPayerINN = "";
		decimal nSum = 0; 
		DateTime dDate = DateTime.Now.Date;
		string sIsoCode = "";

		public facture()
		{
			InitializeComponent();
		}

		private void facture_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nOutputDocumentID = (int)Fields["OutputDocumentID"].Value;
			_sFactureNumber = Fields["FactureNumber"].Value.ToString();

			_bFactoring = (bool)Fields["Factoring"].Value;

            sDateBring = Fields["DateBring"].Value.ToString();

            // ВНИМАНИЕ, ВРЕМЕННАЯ ЗАГЛУШКА!
            // Изменяем признак факторинга в зависимости от хоста
            // Оставляем этот признак только для Инко-Жуковский
            sHostShortCode = Fields["HostShortCode"].Value.ToString();
            if (sHostShortCode.Length < 2 || !sHostShortCode.StartsWith("02")) _bFactoring = false;

			sPayeeINN = Fields["PayeeINN"].Value.ToString();
			sPayerINN = Fields["PayerINN"].Value.ToString();
			nSum = (decimal)Fields["Amount"].Value;
			dDate = (DateTime)Fields["DateOutput"].Value;
			sIsoCode = Fields["CurrencyISODigitalCode"].Value.ToString();

			if ((bool)Fields["Weighting"].Value || 
				Convert.ToDecimal(Fields["InBox"].Value) != Convert.ToInt32(Fields["InBox"].Value))
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
				barcode1.Text = Utilities.GetCRCBarCode_128A(Utilities.GetAlfaBankBarCode_128A42(sPayeeINN, sPayerINN, nSum, dDate));
				barcode2.Text = Utilities.GetCRCBarCode_128A(Utilities.GetAlfaBankBarCode_128A40(_sFactureNumber, sIsoCode));
			}
			else
			{
				barcode1.Visible =
				barcode2.Visible =
				false;
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

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooterFactureNumber.Text = _sFactureNumber;
			//GroupHeader1.Height = lineTop1.Top + (float)0.1;
		}
	}
}
