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
	public partial class TransportAct : DataDynamics.ActiveReports.ActiveReport3
	{
		DateTime dDate = DateTime.Now.Date;

		int _nCurrencyID = 0;
		string _sCurrencyAlias = "";
		string _sRubID = "";

		decimal _nDeliveryPrice = 0;
		decimal _nDeliveryVatSum = 0;

		public TransportAct()
		{
			InitializeComponent();

			LogBizObjects.Setting oRub = new LogBizObjects.Setting();
			_sRubID = oRub.FillVariable("gnCurrencyBaseID");
		}

		private void TransportAct_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nCurrencyID = (int)Fields["DeliveryCurrencyID"].Value;
			_sCurrencyAlias = Fields["DeliveryCurrencyAlias"].Value.ToString();

			_nDeliveryPrice = (decimal)Fields["DeliveryPrice"].Value;
			_nDeliveryVatSum = (decimal)Fields["DeliveryVatSum"].Value;
		}

		private void Detail_Format(object sender, EventArgs e)
		{
            /*if (DateTime.Compare(dDate.Date, (Convert.ToDateTime(Fields["DateOutput"].Value)).Date) <= 0)
                dDate = Convert.ToDateTime(Fields["DateOutput"].Value);*/
            dDate = Convert.ToDateTime(Fields["DateOutput"].Value);

			txtDateOutput.Text = RFMUtilities.DateToTxt(dDate);

			if (_nCurrencyID.ToString() == _sRubID)
			{
				txtDeliveryPrice.Text = ValToRubNum(_nDeliveryPrice); // RFMUtilities.ValToRub
				txtDeliveryVatSum.Text = ValToRubNum(_nDeliveryVatSum);
			}
			else
			{
				txtDeliveryPrice.Text = ValToCurrencyNum(_nDeliveryPrice, _sCurrencyAlias);
				txtDeliveryVatSum.Text = ValToCurrencyNum(_nDeliveryVatSum, _sCurrencyAlias);
			}
		}

		private string ValToRubNum(decimal nSum)
		{
			return(nSum.ToString("### ### ##0.00").Trim().Replace(".", " руб. ") + " коп.");
		}

		private string ValToCurrencyNum(decimal nSum, string sCurrencyAlias)
		{
			return (nSum.ToString("### ### ##0.00").Trim().Replace(".", " " + sCurrencyAlias + " ") + " 1/100" + sCurrencyAlias);
		}

	}
}
