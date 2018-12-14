using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmGetHost : RFMGetOneCode
	{
		private Host oHost;

		public frmGetHost()	: base()
		{
			InitializeComponent();
		}

		public override bool cboData_Restore()
		{
			oHost = new Host();
			oHost.FilterActual = true;
			oHost.FillData();

			/*
			if (oHost.Count() == 0)
			{ 
				// нет хостов
			}
			*/
			cboData.Restore(oHost.MainTable, "Name", "ID");

			return (cboData.Items.Count > 0);
		}
	}
}