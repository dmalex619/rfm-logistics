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
	public partial class frmSalaryExtraWorksEdit : RFMFormChild
	{
		private int? nSalaryExtraWorkID = null;
		private Salary oSalaryExtraWork;

		// для combobox
		private Employee oEmployee;

		public int? _SelectedID;
		public string _SelectedText;

		public frmSalaryExtraWorksEdit(int? _nSalaryExtraWorkID)
		{
			if (_nSalaryExtraWorkID.HasValue)
				nSalaryExtraWorkID = (int)_nSalaryExtraWorkID;

			oSalaryExtraWork = new Salary();
			if (oSalaryExtraWork.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oEmployee = new Employee();
			if (oEmployee.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}
	
		private void frmSalaryExtraWorksEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true; 
			
			bResult = cboEmployees_Restore();
			if (bResult)
			{
				if (nSalaryExtraWorkID.HasValue)
				{
					oSalaryExtraWork.nSalaryExtraWorkID = nSalaryExtraWorkID;
					oSalaryExtraWork.FillTableSalaryExtraWorks();
					if (oSalaryExtraWork.ErrorNumber != 0 || oSalaryExtraWork.TableSalaryExtraWorks.Rows.Count != 1)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о дополнительных работах...");
						bResult = false;
					}

					if (bResult)
					{
						DataRow r = oSalaryExtraWork.TableSalaryExtraWorks.Rows[0];
						dtpDateWork.Value = (DateTime)r["DateWork"];
						cboEmployees.SelectedValue = (int)r["DriverEmployeeID"];
						txtWorkName.Text = r["WorkName"].ToString().Trim();		
						numQnt.Value = (decimal)r["Qnt"];
						numTarif.Value = (decimal)r["Price"];
						numAmount.Value = Math.Round((decimal)numQnt.Value * (decimal)numTarif.Value, 2);
						txtNote.Text = r["Note"].ToString().Trim();
					}
				}
				else
				{
					// новый факт выполнения дополнительных работ
				}
			}

			if (!bResult)
			{
				Dispose();
				Close();
			}

			dtpDateWork.Select();
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (dtpDateWork.IsEmpty)
			{
				RFMMessage.MessageBoxError("Укажите дату выполнения дополнительной работы!");
				dtpDateWork.Select();
				return;
			}
			if (cboEmployees.SelectedValue == null || cboEmployees.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Укажите исполнителя (водителя)!");
				cboEmployees.Select();
				return;
			}
			if (txtWorkName.Text.Trim() == null ||txtWorkName.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("Укажите название дополнительной работы!");
				txtWorkName.Select();
				return;
			}

			if ((decimal)numQnt.Value == 0)
			{
				RFMMessage.MessageBoxError("Укажите объем (количество единиц) дополнительной работы!");
				numQnt.Select();
				return;
			}

			if ((decimal)numTarif.Value == 0)
			{
				RFMMessage.MessageBoxError("Укажите тариф для дополнительной работы!");
				numTarif.Select();
				return;
			}
	
			oSalaryExtraWork.ClearError();
			oSalaryExtraWork.SaveSalaryExtraWorks(ref nSalaryExtraWorkID, 
				(DateTime)dtpDateWork.Value, txtWorkName.Text.Trim(), (int)cboEmployees.SelectedValue, 
				(decimal)numQnt.Value, (decimal)numTarif.Value, txtNote.Text.Trim()); 
			if (oSalaryExtraWork.ErrorNumber == 0 &&
				nSalaryExtraWorkID.HasValue && nSalaryExtraWorkID > 0)
			{
				MotherForm.GotParam = new object[] { (int)nSalaryExtraWorkID };
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		private void txtTabNumber_TextChanged(object sender, EventArgs e)
		{
			if (txtTabNumber.Text.Trim().Length == 3)
			{
				string sTabNumber = txtTabNumber.Text.Trim();
				bool bFound = false;
				foreach (DataRow dr in oEmployee.MainTable.Rows)
				{
					string sBarCode = dr["BarCode"].ToString();
					if (sBarCode.Substring(sBarCode.Length - 3, 3) == sTabNumber)
					{
						cboEmployees.SelectedValue = Convert.ToInt32(dr["ID"]);
						bFound = true;
						break;
					}
				}
				if (!bFound)
				{
					cboEmployees.SelectedIndex = -1;
				}
			}
		}
		
		private void numTarif_Validating(object sender, CancelEventArgs e)
		{
			numAmount.Value = Math.Round((decimal)numQnt.Value * (decimal)numTarif.Value, 2);
		}

		private bool cboEmployees_Restore()
		{
			oEmployee.FilterIsDriver = true;
			oEmployee.FillData();
			cboEmployees.ValueMember = oEmployee.ColumnID;
			cboEmployees.DisplayMember = oEmployee.ColumnName;
			cboEmployees.DataSource = oEmployee.MainTable;
			cboEmployees.SelectedIndex = -1;
			return (oEmployee.ErrorNumber == 0);
		}

		private void btnWorkNameSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значения 

			Salary oSalaryExtraWorkTemp = new Salary();
			oSalaryExtraWorkTemp.FilterDateBeg = DateTime.Now.Date.AddYears(-1);
			oSalaryExtraWorkTemp.FilterDateEnd = DateTime.Now.Date;
			oSalaryExtraWorkTemp.FillTableSalaryExtraWorks();
			if (oSalaryExtraWorkTemp.ErrorNumber != 0 || oSalaryExtraWorkTemp.TableSalaryExtraWorks == null)
				return;
			if (oSalaryExtraWorkTemp.TableSalaryExtraWorks.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			DataTable tdWorkNames = new DataView(oSalaryExtraWorkTemp.TableSalaryExtraWorks, "", "WorkName", DataViewRowState.CurrentRows).ToTable(true, "WorkName");
			/*
			DataTable dtWorkNamesDistinct = new DataTable();
			dtWorkNamesDistinct.Columns.Add("WorkName");
			System.Collections.Hashtable hash = new System.Collections.Hashtable();
			foreach (DataRow row in oSalaryExtraWorkTemp.TableSalaryExtraWorks.Rows)
				hash[row["WorkName"]] = row["WorkName"];
			foreach (object name in hash.Values)
				dtWorkNamesDistinct.Rows.Add(name);
			DataTable tdWorkNames = CopyTable(dtWorkNamesDistinct, "tdWorkNames", "WorkName > ''", "WorkName");
			*/ 
			if (StartForm(new frmSelectID(this, tdWorkNames, "WorkName", "Дополнительная работа", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
					return;
				txtWorkName.Text = _SelectedText;
			}
			_SelectedID = null;
			_SelectedText = "";

			return;
		}

		private void numQnt_Validated(object sender, EventArgs e)
		{
			numAmount.Value = Math.Round((decimal)numQnt.Value * (decimal)numTarif.Value, 2);
		}

	}
}
