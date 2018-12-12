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
	public partial class frmUsers : RFMFormChild
	{
		private User oUserList;  

		public frmUsers()
		{
			oUserList = new User();
			if (oUserList.ErrorNumber != 0) 
				IsValid = false;
			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmUsers_Load(object sender, EventArgs e)
		{
			grcID.DefaultCellStyle.Font = 
			grcID.HeaderCell.Style.Font = 
				new Font(Font, FontStyle.Bold);

			grdData_Restore();
			grdData.Select();
		}

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
			if (StartForm(new frmUsersEdit(0)) == DialogResult.Yes)
			{
				int nUserID = (int)GotParam.GetValue(0);
				grdData_Restore();
				if (nUserID > 0)
				{
					grdData.GridSource.Position = grdData.GridSource.Find(oUserList.ColumnID, nUserID);
					if (grdData.GridSource.Position < 0)
					{
						grdData.GridSource.MoveFirst();
					}
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (grdData.CurrentRow == null || grdData.IsStatusRow(grdData.CurrentRow.Index))
				return;

			int nUserID = (int)grdData.CurrentRow.Cells["grcID"].Value;
				
			if (StartForm(new frmUsersEdit(nUserID)) == DialogResult.Yes)
			{
				grdData_Restore();
			}
			
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (grdData.CurrentRow == null || grdData.IsStatusRow(grdData.CurrentRow.Index))
				return;

			int nUserID = (int)grdData.CurrentRow.Cells["grcID"].Value;

			if (RFMMessage.MessageBoxYesNo("Удалить данные о пользователе с кодом " + nUserID.ToString() + "?") == DialogResult.Yes)
			{
				oUserList.ClearError();
				if (oUserList.DeleteData(nUserID) && oUserList.ErrorNumber == 0)
				{
					grdData_Restore();
				}
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			User oUserPrint = new User();
			int? nUserID;
			if (grdData.IsCheckerShow)
			{
				// отмеченные записи
				DataView dMarked = new DataView(oUserList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				if (dMarked.Count > 0)
				{
					dMarked.Sort = grdData.GridSource.Sort;
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r[oUserPrint.ColumnID]))
						{
							nUserID = Convert.ToInt32(r[oUserPrint.ColumnID]);
							oUserPrint.IDList += nUserID.ToString() + ",";
						}
					}
					oUserPrint.FillDataAsync();
				}
			}
			if (oUserPrint.MainTable.Rows.Count == 0)
			{
				// нет отмеченных. текущая
				if (grdData.CurrentRow == null)
					return;

				oUserPrint.ID = null;
				oUserPrint.IDList = null; 
				nUserID = Convert.ToInt32(grdData.CurrentRow.Cells["grcID"].Value);
				if (nUserID.HasValue)
				{
					oUserPrint.ID = nUserID;
					oUserPrint.FillDataAsync();
				}
			}

			if (oUserPrint.ErrorNumber != 0)
			{
				RFMCursorWait.Set(false);
				return;
			}
			if (oUserPrint.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false); 
				RFMMessage.MessageBoxError("Нет записей...");
				return;
			}
			RFMCursorWait.Set(false);

			repUsersBadges rep = new repUsersBadges();
			StartForm(new frmActiveReport(oUserPrint.MainTable, rep));
		}

		#endregion

		#region Restore

		private bool grdData_Restore()
		{
			int? _oldValue = null;
			if (grdData.CurrentRow != null)
				_oldValue = (int?)grdData.CurrentRow.Cells["grcID"].Value;

			grdData.DataSource = null;

			oUserList.ClearError();
			oUserList.FillDataAsync();

            // Затирание пароля для НЕ-администраторов
            if (((RFMFormBase)Application.OpenForms[0]).UserInfo.UserIsAdmin == false)
            {
                foreach (DataRow _row in oUserList.MainTable.Rows)
                    _row["Password"] = "";
				grcPassword.Visible = false;
            }

			grdData.Restore(oUserList.MainTable);

			if (_oldValue.HasValue)
			{
				grdData.GridSource.Position = grdData.GridSource.Find(oUserList.ColumnID, _oldValue);
				if (grdData.GridSource.Position < 0)
				{
					grdData.GridSource.MoveFirst();
				}
			}
			else
			{
				grdData.GridSource.MoveFirst();
			}

			grdData.Select();

			return (oUserList.ErrorNumber == 0);
		}

		#endregion
	}
}
