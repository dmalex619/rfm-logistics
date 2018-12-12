using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics
{
	public partial class frmSalaryExtraWorks : RFMFormChild
	{
		private Salary oSalaryExtraWorkList; // список 

		public int? _SelectedID;
		public string _SelectedText;

		public frmSalaryExtraWorks()
		{
			oSalaryExtraWorkList = new Salary();
			if (oSalaryExtraWorkList.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmSalaryExtraWorks_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			btnClearTerms_Click(null, null);

			tcList.Init();

			dtrDates.dtpBegDate.Select();

			RFMCursorWait.Set(false);
		}

		#region TabPages Restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnPrint.Enabled =
			btnService.Enabled = 
				false;

			dtrDates.DtpBegDate.Select();

			return (true);
		}

		private bool tabSalaryExtraWorks_Restore()
		{
			dgvExtraWorks_Restore();
			btnAdd.Enabled = true;
			if (dgvExtraWorks.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				dgvExtraWorks.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			return (true);
		}

		#endregion TabPages Restore

		#region Restore

		private bool dgvExtraWorks_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oSalaryExtraWorkList.ClearError();
			oSalaryExtraWorkList.ClearFilters();
			oSalaryExtraWorkList.ID = null;

			// собираем услови€

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oSalaryExtraWorkList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oSalaryExtraWorkList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			if (ucSelectRecordID_DriversEmployees.IsSelectedExist)
			{
				oSalaryExtraWorkList.FilterDriversEmployeesList = ucSelectRecordID_DriversEmployees.GetIdString();
			}

			if (txtWorkName.Text.Trim().Length > 0)
			{
				oSalaryExtraWorkList.FilterWorkNameContext = txtWorkName.Text.Trim();
			}
					
			dgvExtraWorks.GetGridState();
			oSalaryExtraWorkList.FillTableSalaryExtraWorks();
			dgvExtraWorks.IsLockRowChanged = true;
			dgvExtraWorks.Restore(oSalaryExtraWorkList.TableSalaryExtraWorks);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oSalaryExtraWorkList.ErrorNumber == 0);
		}

		#endregion

		#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (StartForm(new frmSalaryExtraWorksEdit(null)) == DialogResult.Yes)
			{
				int nSalaryExtraWorkID = (int)GotParam.GetValue(0);
				dgvExtraWorks_Restore();
				if (nSalaryExtraWorkID > 0)
				{
					dgvExtraWorks.GridSource.Position = dgvExtraWorks.GridSource.Find("ID", nSalaryExtraWorkID);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvExtraWorks.Rows.Count == 0 || dgvExtraWorks.CurrentRow == null)
				return;

			if (StartForm(new frmSalaryExtraWorksEdit((int)dgvExtraWorks.CurrentRow.Cells["dgvcID"].Value)) == DialogResult.Yes)
			{
				dgvExtraWorks_Restore();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvExtraWorks.Rows.Count == 0 || dgvExtraWorks.CurrentRow == null)
				return;

			if (RFMMessage.MessageBoxYesNo("”далить запись о факте дополнительной выполненной работы?") == DialogResult.Yes)
			{
				WaitOn(this);
				if (oSalaryExtraWorkList.DeleteSalaryExtraWorks((int)(int)dgvExtraWorks.CurrentRow.Cells["dgvcID"].Value))
				{
					WaitOff(this);
					if (oSalaryExtraWorkList.ErrorNumber == 0)
						dgvExtraWorks_Restore();
					else
						RFMMessage.MessageBoxError("ќшибка при удалении записи о факте дополнительной выполненной работы...");
				}	
				WaitOff(this);
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		#endregion

		#region Filters Choose

		#region DriversEmployees

		private void ucSelectRecordID_DriversEmployees_Restore()
		{
			if (ucSelectRecordID_DriversEmployees.sourceData == null)
			{
				Employee oEmployee = new Employee();
				oEmployee.FilterIsDriver = true;
				if (Utilities.FillData_Employees(oEmployee))
				{
					ucSelectRecordID_DriversEmployees.Restore(oEmployee.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_DriversEmployees.Restore();
			}
		}

		private void chkDriversOnly_CheckedChanged(object sender, EventArgs e)
		{
			ucSelectRecordID_DriversEmployees.sourceData = null;
		}

		#endregion DriversEmployees

		private void btnWorkSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значени€ 
			
			Salary oSalaryExtraWorkTemp = new Salary();
			oSalaryExtraWorkTemp.FilterDateBeg = DateTime.Now.Date.AddYears(-1);
			oSalaryExtraWorkTemp.FilterDateEnd = DateTime.Now.Date;
			oSalaryExtraWorkTemp.FillTableSalaryExtraWorks();
			if (oSalaryExtraWorkTemp.ErrorNumber != 0 || oSalaryExtraWorkTemp.TableSalaryExtraWorks == null)
				return;
			if (oSalaryExtraWorkTemp.TableSalaryExtraWorks.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Ќет данных...");
				return;
			}
			/*
			DataTable dtWorkNamesDistinct = new DataTable();
			dtWorkNamesDistinct.Columns.Add("WorkName");
			System.Collections.Hashtable hash = new System.Collections.Hashtable();
			foreach (DataRow row in oSalaryExtraWorkTemp.MainTable.Rows)
				hash[row["WorkName"]] = row["WorkName"];
			foreach (object name in hash.Values)
				dtWorkNamesDistinct.Rows.Add(name);
			DataTable tdWorkNames = CopyTable(dtWorkNamesDistinct, "tdWorkNames", "WorkName > ''", "WorkName");
			*/
			DataTable tdWorkNames = new DataView(oSalaryExtraWorkTemp.TableSalaryExtraWorks, "", "WorkName", DataViewRowState.CurrentRows).ToTable(true, "WorkName");
			if (StartForm(new frmSelectID(this, tdWorkNames, "WorkName", "ƒополнительна€ работа", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				txtWorkName.Text = _SelectedText;
			}
			_SelectedID = null;
			_SelectedText = "";

			tabSalaryExtraWorks.IsNeedRestore = true;
 
			return;
		}

		#endregion

		#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			ucSelectRecordID_DriversEmployees.ClearData();
			txtWorkName.Text = "";

			dtrDates.dtpBegDate.Value = DateTime.Now.Date.AddDays(-7);
			dtrDates.dtpEndDate.Value = DateTime.Now.Date;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}
			
			tabSalaryExtraWorks.IsNeedRestore = true;
		}

		#endregion

	}
}