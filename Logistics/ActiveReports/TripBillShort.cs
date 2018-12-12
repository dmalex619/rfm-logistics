using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripBillShort : DataDynamics.ActiveReports.ActiveReport3
	{
		bool bSuccessConfirmed = false;
		string sUnSuccessConfirmedText = "";
		Font fntDefaultDetail;

		public TripBillShort()
		{
			InitializeComponent();

			sUnSuccessConfirmedText = txtUnSuccessConfirmed.Tag.ToString();

			fntDefaultDetail = txtPartnerTargetName.Font;
		}

		private void TripBillShort_FetchData(object sender, FetchEventArgs eArgs)
		{
            //bSuccessConfirmed = (bool)Fields["SuccessConfirmed"].Value;
            try { bSuccessConfirmed = (bool)Fields["SuccessConfirmed"].Value; }
            catch { bSuccessConfirmed = false; }
        }

		private void Detail_Format(object sender, EventArgs e)
		{
			if ((bool)Fields["IsCarried"].Value ||
				!Convert.IsDBNull(Fields["CopiedFromOutputDocumentID"].Value))
			{
				txtCarried.Text = "V";
			}

			if (bSuccessConfirmed)
			{
				txtPartnerTargetName.Font = fntDefaultDetail;
				txtUnSuccessConfirmed.Text = "";
			}
			else
			{
				txtPartnerTargetName.Font = new Font(fntDefaultDetail.Name, fntDefaultDetail.Size, FontStyle.Strikeout);
				txtUnSuccessConfirmed.Text = sUnSuccessConfirmedText;
			}
		}
	}
}
