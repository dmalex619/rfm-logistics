using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

namespace Logistics
{
	public partial class repForSalary : DataDynamics.ActiveReports.ActiveReport3
	{
		string sMode = "";

		public repForSalary(string _sTitle, string _sMode)
		{
			InitializeComponent();

			txtTitle.Text = txtTitle.Text + " " + _sTitle;
			sMode = _sMode.ToUpper();

			if (sMode == "TOTAL")
			{
				txtExtraWorksName.DataField = ""; 
				txtTripDateBeg.Visible =
				txtTripDateEnd.Visible =
				txtExtraWorksName.Visible =
				lblTripDateBeg.Visible =
				lblTripDateEnd.Visible = 
				lblExtraWorksName.Visible = 
					false;
				txtDriverName.Width = txtDriverName.Width * 2;
				lineDetailH1.Y1 =
				lineDetailH1.Y2 = 
					lineDetailH1.Y1 - txtExtraWorksName.Height;
				detail.Height = detail.Height - txtExtraWorksName.Height;
				groupDriverIDFooter.Height = 0;
			}
		}
	}
}
