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
	public partial class frmCarsTasks : RFMFormChild
	{
		private CarTask oCarTaskList; //список актов
        private CarTask oCarTaskCur; //текущий акт

        private CarTask oCarTaskTemp;

        private int nUserID;

		public frmCarsTasks()
		{
            oCarTaskList = new CarTask();
            oCarTaskCur = new CarTask();
			if (oCarTaskList.ErrorNumber != 0 || oCarTaskCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

            oCarTaskTemp = new CarTask();
            if (oCarTaskTemp.ErrorNumber != 0)
            {
                IsValid = false;
            }

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmCarsTasks_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

            nUserID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID;

			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			btnClearTerms_Click(null, null);

			tcList.Init();

			dtrDates.dtpBegDate.Select();

			RFMCursorWait.Set(false);
		}

        private void tcList_SelectedIndexChanged(object sender, EventArgs e)
        {
			string sPageName = tcList.SelectedTab.Name.ToUpper();

			if (sPageName.Contains("TERMS"))
            {
                tabTerms_Restore();
            }
            if (sPageName.Contains("DATA") && tabData.IsNeedRestore)
            {
                tabData_Restore();
            }
        }

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
            btnCopy.Enabled =
            btnDelete.Enabled = 
            btnConfirm.Enabled = 
            btnPrint.Enabled = false;

			dtrDates.dtpBegDate.Select();
			
			return (true);
		}

		private bool tabData_Restore()
		{
			dgvCarsTasks_Restore();

			btnAdd.Enabled = true;
			if (dgvCarsTasks.Rows.Count > 0)
			{
                btnEdit.Enabled =
                btnCopy.Enabled =
                btnDelete.Enabled =
                btnConfirm.Enabled =
                btnPrint.Enabled = true;

				dgvCarsTasks.Select();
			}
			else
			{
				btnEdit.Enabled =
                btnCopy.Enabled =
                btnDelete.Enabled =
                btnConfirm.Enabled =
                btnPrint.Enabled = false;
			}
			return (true);
		}

	#region RowEnter, CellFormatting 
	
		private void dgvCarsTasks_CurrentRowChanged(object sender)
		{
			if (dgvCarsTasks.IsLockRowChanged)
				return;
            tmrRestore.Enabled = true;
        }

		private void dgvCarsTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvCarsTasks.DataSource == null)
				return;

			// статусная строка
			if (dgvCarsTasks.IsStatusRow(e.RowIndex))
			{
				if (dgvCarsTasks.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)dgvCarsTasks.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = dgvCarsTasks.Columns[e.ColumnIndex];
			oCarTaskTemp.FillOne(r);
			//
            switch (c.Name)
            {
                case "dgvcConfirmedImage":
                    if (oCarTaskTemp.DateConfirm.HasValue)
                    {
                        e.Value = Properties.Resources.Check;
                    }
                    else
                    {
                        e.Value = Properties.Resources.Empty;
                    }
                    break;
                case "dgvcTaskAmount":
                    if (oCarTaskTemp.TaskAmount < oCarTaskTemp.TaskInnerCost + oCarTaskTemp.TaskOuterCost)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    break;
            }
		}

	#endregion 

	#region Restore

		private bool dgvCarsTasks_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oCarTaskCur.ClearOne();

			oCarTaskList.ClearError();
			oCarTaskList.ClearFilters();
			oCarTaskList.ID = null;
			oCarTaskList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oCarTaskList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oCarTaskList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// владельцы
			oCarTaskList.FilterPartnersList = ucSelectRecordID_Owners.GetIdString();
	          
            // акт привязан к рейсу
            if (optTripExistsNot.Checked)
            {
                oCarTaskList.FilterTripExists = false;
            }
            if (optTripExists.Checked)
            {
                oCarTaskList.FilterTripExists = true;
            }

            // состояние задания: подтверждение 
            if (optIsConfirmedNot.Checked)
            {
                oCarTaskList.FilterIsConfirmed = false;
                
            }
            if (optIsConfirmed.Checked)
            {
                oCarTaskList.FilterIsConfirmed = true;
            }
			// 

			dgvCarsTasks.GetGridState();
			oCarTaskList.FillData();
			dgvCarsTasks.IsLockRowChanged = true;
			dgvCarsTasks.Restore(oCarTaskList.MainTable);

            tmrRestore.Enabled = true;
            RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oCarTaskList.ErrorNumber == 0);
		}

	#endregion 
		
	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (StartForm(new frmCarsTasksEdit(0)) == DialogResult.Yes)
			{
				int nCarTaskID = (int)GotParam.GetValue(0);
				dgvCarsTasks_Restore();
				if (nCarTaskID > 0)
				{
                    dgvCarsTasks.GridSource.Position = dgvCarsTasks.GridSource.Find(oCarTaskList.ColumnID, nCarTaskID);
				}
			}
		}

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (dgvCarsTasks.CurrentRow == null)
                return;
            if (!oCarTaskCur.ID.HasValue)
                return;

            if (StartForm(new frmCarsTasksEdit((int)oCarTaskCur.ID, true)) == DialogResult.Yes)
            {
                dgvCarsTasks_Restore();
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvCarsTasks.CurrentRow == null)
				return;
            if (!oCarTaskCur.ID.HasValue)
				return;
            
            if (oCarTaskCur.DateConfirm.HasValue)
            {
                RFMMessage.MessageBoxAttention("Задание уже подтверждено.\n" + "Редактирование невозможно!");
                return;
            }

            if (StartForm(new frmCarsTasksEdit((int)oCarTaskCur.ID)) == DialogResult.Yes)
			{
				dgvCarsTasks_Restore();
			}
        }

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvCarsTasks.CurrentRow == null)
				return;
            if (!oCarTaskCur.ID.HasValue)
                return;

            // перечитать
            oCarTaskCur.ReFillOne((int)oCarTaskCur.ID);

            // проверки
            if (oCarTaskCur.DateConfirm != null)
            {
                RFMMessage.MessageBoxError("Задание уже подтверждено...\n" + "Удаление невозможно.");
                return;
            }
			if (RFMMessage.MessageBoxYesNo("Удалить задание?", false) == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oCarTaskCur.DeleteOne((int)oCarTaskCur.ID);
				WaitOff(this);
				if (bResult && oCarTaskCur.ErrorNumber == 0)
				{
					dgvCarsTasks_Restore();
				}
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvCarsTasks.CurrentRow == null)
                return;
            if (!oCarTaskCur.ID.HasValue)
                return;

            // перечитать
            oCarTaskCur.ReFillOne((int)oCarTaskCur.ID);

            // проверки
            // Изменение от 02.12.2018, Александров
            // По просьбе Головкина добавлена возможность сброса подтверждения задания
            bool bDropConfirm;
            string sMessage;
            if (oCarTaskCur.DateConfirm != null)
            {
                //RFMMessage.MessageBoxError("Задание уже подтверждено...");
                //return;
                bDropConfirm = true;
                sMessage = "Задание уже подтверждено. Вы уверены, что хотите сбросить подтверждение?";
            }
            else
            {
                bDropConfirm = false;
                sMessage = "Подтвердить задание?";
            }

            if (RFMMessage.MessageBoxYesNo(sMessage, false) == DialogResult.Yes)
            {
                Refresh();
                WaitOn(this);
                bool bResult = oCarTaskCur.Confirm((int)nUserID, bDropConfirm);
                WaitOff(this);
                if (bResult && oCarTaskCur.ErrorNumber == 0)
                {
                    dgvCarsTasks_Restore();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    #endregion

	#region SelectID

		private void ucSelectRecordID_Owners_Restore()
		{
			if (ucSelectRecordID_Owners.sourceData == null)
			{
				RFMCursorWait.Set(true);
				Partner oPartner = new Partner();
				oPartner.FilterIsOwner = true;
				oPartner.FillData();
				RFMCursorWait.Set(false);
				if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных (владельцы)...");
					return;
				}
				if (oPartner.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных (владельцы)...");
					return;
				}

				ucSelectRecordID_Owners.Restore(oPartner.MainTable);
			}
			else
			{
				ucSelectRecordID_Owners.Restore();
			}
		}

	#endregion SelectID

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date.AddDays(-1);
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(2).Date;
            optIsConfirmedAll.Checked = optTripExistsAll.Checked = true;
			ucSelectRecordID_Owners.ClearData(); 

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabData.IsNeedRestore = true;
		}

	#endregion

        private void tmrRestore_Tick(object sender, EventArgs e)
        {
            tmrRestore.Enabled = false;

            if (dgvCarsTasks.Rows.Count == 0 || dgvCarsTasks.CurrentRow == null)
                return;

            int rowIndex = dgvCarsTasks.CurrentRow.Index;
            if (dgvCarsTasks.IsStatusRow(rowIndex))
            {
                oCarTaskCur.ClearOne();
                btnEdit.Enabled =
                btnCopy.Enabled =
                btnDelete.Enabled =
                btnConfirm.Enabled =
                btnPrint.Enabled =
                    false;
                return;
            }

            DataRow r = ((DataRowView)((DataGridViewRow)dgvCarsTasks.Rows[rowIndex]).DataBoundItem).Row;
            oCarTaskCur.FillOne(r);
            btnEdit.Enabled = btnDelete.Enabled = !oCarTaskCur.IsConfirmed;
        }
	}
}