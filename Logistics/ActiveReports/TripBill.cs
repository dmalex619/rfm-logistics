using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics 
{
	public partial class TripBill : DataDynamics.ActiveReports.ActiveReport3
	{
		bool bSuccessConfirmed = false;
		string sUnSuccessConfirmedText = "";
		Font fntDefaultDetail;

		public TripBill()
		{
			InitializeComponent();

			sUnSuccessConfirmedText = txtUnSuccessConfirmed.Tag.ToString();

			fntDefaultDetail = txtDetail05.Font;
		}

		private void TripBill_FetchData(object sender, FetchEventArgs eArgs)
		{
			//bSuccessConfirmed = (bool)Fields["SuccessConfirmed"].Value;
            try { bSuccessConfirmed = (bool)Fields["SuccessConfirmed"].Value; }
            catch { bSuccessConfirmed = false; }
        }

		private void Detail_Format(object sender, EventArgs e)
		{
			if (bSuccessConfirmed)
			{
				txtDetail07.Font = fntDefaultDetail;
				txtUnSuccessConfirmed.Text = "";
				groupFooter4.Visible = false;
			}
			else
			{
				txtDetail07.Font = new Font(fntDefaultDetail.Name, fntDefaultDetail.Size, FontStyle.Strikeout);
				txtUnSuccessConfirmed.Text = sUnSuccessConfirmedText;
				groupFooter4.Visible = true;
			}
		}

		private void groupHeader3_Format(object sender, EventArgs e)
		{
			lblWarrantNumber.Visible = !Convert.IsDBNull(Fields["WarrantNumber"].Value) && 
				Fields["WarrantNumber"].Value != null && 
				Fields["WarrantNumber"].Value.ToString().Length > 0; 
		}

		private void GroupHeader1_Format(object sender, EventArgs e)
		{

		}
	}
}
