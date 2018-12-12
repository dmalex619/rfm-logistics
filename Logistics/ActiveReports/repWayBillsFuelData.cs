using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class repWayBillsFuelData : DataDynamics.ActiveReports.ActiveReport3
	{
		string sTitle = "";

		int nCarID = 0;

		int nWayBillsCount = 0;
		int nDistance = 0;
		decimal nFuelExpenseAll = 0;
		decimal nNormExpenseAll = 0;

		public repWayBillsFuelData()
		{
			InitializeComponent();
		}

		public repWayBillsFuelData(string _sTitle)
		{
			InitializeComponent();

			if (_sTitle != null)
				sTitle = _sTitle;
		}

		private void repWayBillsFuelData_FetchData(object sender, FetchEventArgs eArgs)
		{
			if (!Convert.IsDBNull(Fields["CarID"].Value))
			{
				if (Convert.ToInt32(Fields["CarID"].Value) != nCarID)
				{
					nCarID = Convert.ToInt32(Fields["CarID"].Value);
					if (nCarID > 0)
					{
						nWayBillsCount += Convert.ToInt32(Fields["WayBillsCount"].Value);
						nDistance += Convert.ToInt32(Fields["Distance"].Value);
						nFuelExpenseAll += Convert.ToDecimal(Fields["FuelExpenseAll"].Value);
						nNormExpenseAll += Convert.ToDecimal(Fields["NormExpenseAll"].Value);
					}
				}
			}
		}

		private void pageHeader_Format(object sender, EventArgs e)
		{
			if (sTitle != null && sTitle.Trim().Length > 0)
				textTitle.Text = sTitle;
		}

		private void groupIsTotal_Format(object sender, EventArgs e)
		{
			if (nCarID < 0)
			{
				groupIsTotal.Visible = false;
				groupIsTotalFooter.Visible = false;
			}
		}

		private void groupCarID_Format(object sender, EventArgs e)
		{
			if (nCarID < 0)
			{
				groupCarID.Visible = false;
			}
		}

		private void groupIsTotalFooter_Format(object sender, EventArgs e)
		{
			textWayBillsCount.Value = nWayBillsCount;
			textDistance.Value = nDistance;
			textFuelExpenseAll.Value = nFuelExpenseAll;
			textNormExpenseAll.Value = nNormExpenseAll;
		}
	}
}
