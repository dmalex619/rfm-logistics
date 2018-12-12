using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmReportTripsCosts: RFMFormChild
	{
		private Report oReport;

		private Partner oOwner;
		private Partner oPartner;
		private OutputDocument oOutputDocument;
		DataTable TableManagerNames = new DataTable();
		DataTable TableDepartmentNames = new DataTable();

		string sNamesListDeliliter = "#";


		public frmReportTripsCosts()
		{
			oReport = new Report();
			if (oReport.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmReportTripsCosts_Load (object sender, EventArgs e)
		{
			// назначение суммирования на колонки
			//grcTrips_Distance.AgrType =
			grcTrips_Netto.AgrType =
			grcTrips_TripAmount.AgrType =
				EnumAgregate.Sum; 

			dtrDates.dtpEndDate.Value = DateTime.Now.AddDays(-DateTime.Now.Day).Date;
			dtrDates.dtpBegDate.Value = dtrDates.dtpEndDate.Value.AddDays(-dtrDates.dtpEndDate.Value.Day).AddDays(1).Date;

			//btnGo_Click(null, null);
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			grdTrips_Restore(); 
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			grdTrips.ExportData();
		}

		#region Restore

		private bool grdTrips_Restore()
		{
			WaitOn(this);
			grdTrips.DataSource = null;

			DateTime? dDateBeg = null;
			if (!dtrDates.dtpBegDate.IsEmpty)
				dDateBeg = dtrDates.dtpBegDate.Value.Date;
			DateTime? dDateEnd = null;
			if (!dtrDates.dtpEndDate.IsEmpty)
				dDateEnd = dtrDates.dtpEndDate.Value.Date;
			
			string sSelectedOwnersIDList = ucSelectRecordID_Owners.GetIdString();
			string sSelectedPartnersIDList = ucSelectRecordID_Partners.GetIdString();
			string sSelectedDepartmentNamesList = null;
			string sSelectedDepartmentNamesIDList = ucSelectRecordID_DepartmentNames.GetIdString(); 
			if (sSelectedDepartmentNamesIDList != null)
			{
				sSelectedDepartmentNamesIDList = "," + sSelectedDepartmentNamesIDList + ",";
				if (TableDepartmentNames != null && TableDepartmentNames.Rows.Count > 0)
				{
					sSelectedDepartmentNamesList = sNamesListDeliliter;
					foreach (DataRow mn in TableDepartmentNames.Rows)
					{
						if (sSelectedDepartmentNamesIDList.Contains("," + mn["ID"].ToString().Trim() + ","))
							sSelectedDepartmentNamesList += mn["DepartmentName"].ToString() + sNamesListDeliliter;
					}
				}
			}
			string sSelectedManagerNamesList = null;
			string sSelectedManagerNamesIDList = ucSelectRecordID_ManagerNames.GetIdString();
			if (sSelectedManagerNamesIDList != null)
			{
				if (TableManagerNames != null && TableManagerNames.Rows.Count > 0)
				{
					sSelectedManagerNamesList = sNamesListDeliliter;
					sSelectedManagerNamesIDList = "," + sSelectedManagerNamesIDList + ",";
					foreach (DataRow mn in TableManagerNames.Rows)
					{
						if (sSelectedManagerNamesIDList.Contains("," + mn["ID"].ToString().Trim() + ","))
							sSelectedManagerNamesList += mn["ManagerName"].ToString() + sNamesListDeliliter;
					}
				}
			}
			
			string sMode = "";
			if (optGroupByD.Checked) sMode = "D";
			if (optGroupByM.Checked) sMode = "M";
			if (optGroupByO.Checked) sMode = "O";
			if (optGroupByP.Checked) sMode = "P";
  			oReport.Report_TripsCosts(dDateBeg, dDateEnd, 
				sSelectedOwnersIDList, sSelectedPartnersIDList, sSelectedDepartmentNamesList, sSelectedManagerNamesList, 
				sMode);
			if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
			{
				if (oReport.MainTable.Rows.Count == 0)
				{
					WaitOff(this);
					RFMMessage.MessageBoxInfo("Нет данных...");
				}
				grdTrips.Restore(oReport.MainTable);
			}

			grcTrips_BillNumber.Visible =
			grcTrips_DateOutput.Visible =
				(sMode == "O"); 
			grcTrips_DepartmentName.Visible = (sMode == "O" || sMode == "D");
			grcTrips_ManagerName.Visible = (sMode == "O" || sMode == "M");
			grcTrips_PartnerName.Visible = (sMode == "O" || sMode == "P");

			WaitOff(this);
			return (oReport.ErrorNumber == 0);
		}

		#endregion Restore

		#region Terms 

		#region SelectID

		private void ucSelectRecordID_Owners_Restore()
		{
			oOwner = new Partner();
			if (Utilities.FillData_Owners(oOwner))
			{
				ucSelectRecordID_Owners.Restore(oOwner.MainTable);
			}
		}

		private void ucSelectRecordID_Partners_Restore()
		{
			oPartner = new Partner();
			if (Utilities.FillData_Partners(oPartner, false, false, true))
			{
				ucSelectRecordID_Partners.Restore(oPartner.MainTable);
			}
		}

		private void ucSelectRecordID_DepartmentNames_Restore()
		{
			if (dtrDates.dtpBegDate.IsChanged || dtrDates.dtpEndDate.IsChanged)
			{
				TableDepartmentNames = null;
				dtrDates.dtpBegDate.IsChanged =
				dtrDates.dtpEndDate.IsChanged =
					false;
			}

			if (TableDepartmentNames == null || TableDepartmentNames.Rows.Count == 0)
			{
				ucSelectRecordID_DepartmentNames.sourceData = null;
				oOutputDocument = new OutputDocument();
				DateTime dDateBeg, dDateEnd;
				if (dtrDates.dtpBegDate.IsEmpty)
					dDateBeg = DateTime.Now;
				else
					dDateBeg = dtrDates.dtpBegDate.Value;
				if (dtrDates.dtpEndDate.IsEmpty)
					dDateEnd = DateTime.Now;
				else
					dDateEnd = dtrDates.dtpEndDate.Value;
				if (Utilities.FillData_DepartmentNames(oOutputDocument, dDateBeg, dDateEnd))
				{
					DataColumn c = oOutputDocument.TableDepartmentNames.Columns.Add("ID", Type.GetType("System.Int32"));
					int i = 0;
					foreach (DataRow dn in oOutputDocument.TableDepartmentNames.Rows)
					{
						dn["ID"] = i;
						i++;
					}
					TableDepartmentNames = CopyTable(oOutputDocument.TableDepartmentNames, "TableDepartmentNames", "", "DepartmentName");
				}
			}
			if (TableDepartmentNames != null)
			{
				ucSelectRecordID_DepartmentNames.Restore(TableDepartmentNames);
			}
		}

		private void ucSelectRecordID_ManagerNames_Restore()
		{
			if (dtrDates.dtpBegDate.IsChanged || dtrDates.dtpEndDate.IsChanged)
			{
				TableManagerNames = null;
				dtrDates.dtpBegDate.IsChanged =
				dtrDates.dtpEndDate.IsChanged =
					false;
			}

			if (TableManagerNames == null || TableManagerNames.Rows.Count == 0)
			{
				ucSelectRecordID_ManagerNames.sourceData = null;
				oOutputDocument = new OutputDocument();
				DateTime dDateBeg, dDateEnd;
				if (dtrDates.dtpBegDate.IsEmpty)
					dDateBeg = DateTime.Now;
				else
					dDateBeg = dtrDates.dtpBegDate.Value;
				if (dtrDates.dtpEndDate.IsEmpty)
					dDateEnd = DateTime.Now;
				else
					dDateEnd = dtrDates.dtpEndDate.Value;
				if (Utilities.FillData_ManagerNames(oOutputDocument, dDateBeg, dDateEnd))
				{
					DataColumn c = oOutputDocument.TableManagerNames.Columns.Add("ID", Type.GetType("System.Int32"));
					int i = 0;
					foreach (DataRow mn in oOutputDocument.TableManagerNames.Rows)
					{
						mn["ID"] = i;
						i++;
					}
					TableManagerNames = CopyTable(oOutputDocument.TableManagerNames, "TableManagerNames", "", "ManagerName");
				}
			}
			if (TableManagerNames != null)
			{
				ucSelectRecordID_ManagerNames.Restore(TableManagerNames);
			}
		}

		#endregion SelectID

		#endregion Terms

	}
}
