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
	public partial class billReturn : DataDynamics.ActiveReports.ActiveReport3
	{
		int _nInputID = 0;

		int _nCnt = 0;
		decimal _nBox = 0;

		Font fntDefaultDetail;

		public billReturn()
		{
			InitializeComponent();

			fntDefaultDetail = txtDetail05.Font;
		}

		private void billReturn_FetchData(object sender, FetchEventArgs eArgs)
		{
			_nInputID = (int)Fields["InputID"].Value;

			if ((bool)Fields["Weighting"].Value)
			{
				txtDetail04.Font = new Font(fntDefaultDetail.Name, fntDefaultDetail.Size - 1, FontStyle.Regular);
				txtDetail04.OutputFormat = "# ### ##0.000"; // InBox
				txtDetail06.OutputFormat = "# ### ##0.000"; // Qnt
			}
			else
			{
				//txtDetail04.Font = fntDefaultDetail;
				txtDetail04.OutputFormat = "# ### ##0"; // InBox
				txtDetail06.OutputFormat = "# ### ##0"; // Qnt
			}
		}

		private void PageFooter_Format(object sender, EventArgs e)
		{
			txtPageFooter01.Text = _nInputID.ToString(); 
		}

		private void GroupFooter1_Format(object sender, EventArgs e)
		{
			txtGroupFooter108.Text = txtGroupFooter108.Tag.ToString().Trim() + " " + RFMPublic.RFMUtilities.Declen(_nCnt, "номер", "номера", "номеров") + " записей.";
			if ((int)Math.Round(_nBox, 0) != 0)
			{
				txtGroupFooter109.Text = RFMPublic.RFMUtilities.ValToTxt((int)Math.Round(_nBox, 0));
			}
			else
			{
				txtGroupFooter109.Text = "";
			}
		}

		private void billReturn_DataInitialize(object sender, EventArgs e)
		{
			foreach (DataRow r in ((DataTable)DataSource).Rows)
			{
				_nCnt++;
				_nBox += (decimal)r["Box"];
			}
		}
	}
}
