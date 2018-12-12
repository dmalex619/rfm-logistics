using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TtnOneLine : DataDynamics.ActiveReports.ActiveReport3
	{
		DateTime dNow = DateTime.Now.Date;

		public TtnOneLine()
		{
			InitializeComponent();
		}

		private void Detail_Format(object sender, EventArgs e)
		{
			//txtDateNow.Text = RFMPublic.RFMUtilities.DateToTxt(dNow); //dNow.ToString("dd.MM.yyyy");
			//txtDateNow1.Text = RFMPublic.RFMUtilities.DateToTxt(dNow);

            txtDateNow.Text = txtDateNow1.Text = txtDateOutputWords.Text = RFMPublic.RFMUtilities.DateToTxt(Convert.ToDateTime(Fields["DateOutput"].Value));

			txtBoxesWords.Text = RFMPublic.RFMUtilities.ValToTxt(Convert.ToInt32(Fields["SBoxes"].Value));
		}
	}
}
