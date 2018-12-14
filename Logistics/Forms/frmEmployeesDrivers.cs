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
	public partial class frmEmployeesDrivers : RFMFormChild
	{
		private Employee oEmployeeList;
		private Employee oEmployeeCur;
		private Employee oEmployeeForJobTitles; 

		public frmEmployeesDrivers()
		{
			oEmployeeList = new Employee();
			oEmployeeCur = new Employee();
			oEmployeeForJobTitles = new Employee();
			if (oEmployeeList.ErrorNumber != 0 ||
				oEmployeeCur.ErrorNumber != 0 ||
				oEmployeeForJobTitles.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmEmployees_Load(object sender, EventArgs e)
		{
			// назначение суммирования и шрифта на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			tcData.Init();

			btnClear_Click(null, null);
			
			grdEmployees_Restore();
			grdEmployees.Select();
		}

	#region TabPages

		#region TabPages Restore

		private bool tabEmployees_Restore()
		{
			grdEmployees_Restore();
            btnAdd.Enabled = false; // true;

            if (grdEmployees.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
					true;

				grdEmployees.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
					false;
			}
			return (true);
		}

		private bool tabJobTitles_Restore()
		{
			grdJobTitles_Restore();
			btnAdd.Enabled = false; // true;

			if (grdJobTitles.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
					false; // true;

				grdJobTitles.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
					false;
			}
			return (true);
		}

		#endregion TabPages Restore

		private void tcData_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcData.CurrentPage.Name.ToUpper().Contains("EMPL"))
			{
                btnAdd.Enabled = false; // true;

				if (grdEmployees.Rows.Count > 0)
				{
					btnEdit.Enabled =
					btnDelete.Enabled =
					btnPrint.Enabled =
						true;

					grdEmployees.Select();
				}
			}

			if (tcData.CurrentPage.Name.ToUpper().Contains("JOB"))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
					false;

				grdJobTitles.Select();
			}
		}

	#endregion TabPages


	#region Buttons

		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			switch (tcData.CurrentPage.Name)
			{
				case "tabEmployees":
					if (StartForm(new frmEmployeesDriversEdit(null)) == DialogResult.Yes)
					{
						int nEmployeeID = (int)GotParam.GetValue(0);
						grdEmployees_Restore();
						if (nEmployeeID > 0)
						{
							grdEmployees.GridSource.Position = grdEmployees.GridSource.Find(oEmployeeList.ColumnID, nEmployeeID);
							if (grdEmployees.GridSource.Position < 0)
							{
								grdEmployees.GridSource.MoveFirst();
							}
						}
					}
					break;
				case "tabJobTitles":
					break;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcData.CurrentPage.Name)
			{
				case "tabEmployees":
					if (grdEmployees.CurrentRow == null || 
						grdEmployees.IsStatusRow(grdEmployees.CurrentRow.Index))
						return;

					int nEmployeeID = (int)grdEmployees.CurrentRow.Cells["grcID"].Value;
					if (StartForm(new frmEmployeesDriversEdit(nEmployeeID)) == DialogResult.Yes)
					{
						grdEmployees_Restore();
					}
					break;
				case "tabJobTitles":
					break;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcData.CurrentPage.Name)
			{
				case "tabEmployees":
					if (grdEmployees.CurrentRow == null || 
						grdEmployees.IsStatusRow(grdEmployees.CurrentRow.Index))
						return;

					int nEmployeeID = (int)grdEmployees.CurrentRow.Cells["grcID"].Value;

					if (RFMMessage.MessageBoxYesNo("Удалить данные о сотруднике с кодом " + nEmployeeID.ToString() + "?") == DialogResult.Yes)
					{
						oEmployeeList.ClearError();
						if (oEmployeeList.DeleteData(nEmployeeID) && 
							oEmployeeList.ErrorNumber == 0)
						{
							grdEmployees_Restore();
						}
					}
					break;
				case "tabJobTitles":
					break;
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			RFMCursorWait.Set(false);
		}

	#endregion Buttons

	#region Restore

		private bool grdEmployees_Restore()
		{
			int? _oldValue = null;
			if (grdEmployees.CurrentRow != null)
				_oldValue = (int?)grdEmployees.CurrentRow.Cells["grcID"].Value;

			oEmployeeCur.ClearOne();

			oEmployeeList.ClearError();
			oEmployeeList.ClearFilters();
			oEmployeeList.ID = null;

			oEmployeeList.DriverInfo = true; 

			if (txtNameContext.Text.Trim().Length > 0)
			{
				oEmployeeList.FilterNameContext = txtNameContext.Text.Trim().ToUpper();
			}
			if (chkDriversOnly.Checked)
			{
				oEmployeeList.FilterIsDriver = true;
			}
			if (optActual.Checked)
			{
				oEmployeeList.FilterActual = true;
			}
			if (optActualNot.Checked)
			{
				oEmployeeList.FilterActual = false;
			}
			if (txtJobTitleContext.Text.Trim().Length > 0)
			{
				oEmployeeList.FilterJobTitleContext = txtJobTitleContext.Text.Trim().ToUpper();
			}

			grdEmployees.DataSource = null;
			oEmployeeList.FillData();
			
			grdEmployees.Restore(oEmployeeList.MainTable);

			if (_oldValue.HasValue)
			{
				grdEmployees.GridSource.Position = grdEmployees.GridSource.Find(oEmployeeList.ColumnID, _oldValue);
				if (grdEmployees.GridSource.Position < 0)
				{
					grdEmployees.GridSource.MoveFirst();
				}
			}
			else
			{
				grdEmployees.GridSource.MoveFirst();
			}

			grdEmployees.Select();

			return (oEmployeeList.ErrorNumber == 0);
		}

		private bool grdJobTitles_Restore()
		{
			int? _oldValue = null;
			if (grdJobTitles.CurrentRow != null)
				_oldValue = (int?)grdJobTitles.CurrentRow.Cells["grcJobTitles_ID"].Value;

			oEmployeeForJobTitles.ClearError();
			oEmployeeForJobTitles.ClearFilters();

			grdJobTitles.DataSource = null;
			oEmployeeForJobTitles.FillTableJobTitles();

			DataTable dtJobTitles;
			if (txtJobTitleContext.Text.Trim().Length > 0)
			{
				dtJobTitles = CopyTable(oEmployeeForJobTitles.TableJobTitles, "dtJobTitles", "Name like '*" + txtJobTitleContext.Text.Trim().ToUpper() + "*'", "Name");
			}
			else
			{
				dtJobTitles = oEmployeeForJobTitles.TableJobTitles;
			}

			grdJobTitles.Restore(dtJobTitles);

			if (_oldValue.HasValue)
			{
				grdJobTitles.GridSource.Position = grdJobTitles.GridSource.Find(oEmployeeForJobTitles.ColumnID, _oldValue);
				if (grdJobTitles.GridSource.Position < 0)
				{
					grdJobTitles.GridSource.MoveFirst();
				}
			}
			else
			{
				grdJobTitles.GridSource.MoveFirst();
			}

			grdJobTitles.Select();

			return (oEmployeeForJobTitles.ErrorNumber == 0);
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			switch (tcData.CurrentPage.Name)
			{
				case "tabEmployees":
					tabEmployees_Restore();
					break;
				case "tabJobTitles":
					tabJobTitles_Restore();
					break;
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtNameContext.Text = "";
			chkDriversOnly.Checked = false;
			optActual.Checked = true;
			txtJobTitleContext.Text = "";
			
			tabEmployees.IsNeedRestore = 
			tabJobTitles.IsNeedRestore = 
				true;
		}

	#endregion Restore

	}
}
