using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class TripsListAllReturns : DataDynamics.ActiveReports.ActiveReport3
	{
		bool bGoodAliasEmpty = false;
		public TripsListAllReturns()
		{
			InitializeComponent();
		}

		private void TripsListAllReturns_FetchData(object sender, FetchEventArgs eArgs)
		{
			bGoodAliasEmpty = (Fields["GoodAlias"].Value.ToString().Length == 0);
		}

		private void groupOutputDocumentID_Format(object sender, EventArgs e)
		{
			if (bGoodAliasEmpty)
			{
				txtAmount.Visible =
				txtNetto.Visible =
				txtReasonDescription.Visible =
				txtGuiltyDescription.Visible = 
					true;
				groupOutputDocumentIDFooter.Visible = false;
			}
			else
			{
				txtAmount.Visible =
				txtNetto.Visible =
				txtReasonDescription.Visible =
				txtGuiltyDescription.Visible = 
					false;
				groupOutputDocumentIDFooter.Visible = true;
			}
		}

		private void detail_Format(object sender, EventArgs e)
		{
			if (bGoodAliasEmpty)
			{
				detail.Visible = false;
			}
			else
			{
				detail.Visible = true;
			}
		}
	}
}
