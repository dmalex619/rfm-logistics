using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripReturnBill : DataDynamics.ActiveReports.ActiveReport3
	{
		private int nTripReturnID;
		decimal nSQntRestWishedNoWeight = 0;
		decimal nSQntRestWishedWeight = 0;
		bool bWeighting = false;

		Font fntDefaultDetail;

		public TripReturnBill()
		{
			InitializeComponent();

			fntDefaultDetail = txtInBox.Font;
		}

		private void detail_Format(object sender, EventArgs e)
		{
			if (bWeighting)
			{
				nSQntRestWishedWeight = nSQntRestWishedWeight + (decimal)Fields["QntRestWished"].Value;
			}
			else
			{
				nSQntRestWishedNoWeight = nSQntRestWishedNoWeight + (decimal)Fields["QntRestWished"].Value;
			}
		}

		private void pageFooter_Format(object sender, EventArgs e)
		{
			txtTripReturnIDFooter.Text = nTripReturnID.ToString();
		}

		private void TripReturnBill_FetchData(object sender, FetchEventArgs eArgs)
		{
			nTripReturnID = (int)Fields["TripReturnID"].Value;

			bWeighting = (bool)Fields["Weighting"].Value;

			if (bWeighting)
			{
				txtInBox.OutputFormat = "#####0.000";
				txtQntRestWished.OutputFormat = "#####0.000";
				txtGoodAlias.Font =
				txtArticul.Font =
				txtInBox.Font =
				txtQntRestWished.Font =
					new Font(fntDefaultDetail, FontStyle.Italic);
			}
			else
			{
				txtInBox.OutputFormat = "######";
				txtQntRestWished.OutputFormat = "######";
				txtGoodAlias.Font =
				txtArticul.Font =
				txtInBox.Font =
				txtQntRestWished.Font =
					fntDefaultDetail;
			}
		}

		private void groupTripReturnIDFooter_Format(object sender, EventArgs e)
		{
			txtSQntRestWishedNoWeight.Value = nSQntRestWishedNoWeight;
			if (nSQntRestWishedWeight > 0)
				txtSQntRestWishedWeight.Value = nSQntRestWishedWeight;
			else
			{
				txtSQntRestWishedWeight.Text = "";
				lblSQntRestWishedWeight.Text = "";
			}
		}
	}
}
