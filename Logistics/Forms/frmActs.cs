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
	public partial class frmActs : RFMFormChild
	{
		private Act  oActList; //список актов
		private Act oActCur; //текущий акт

        private Act oActTemp;

		private Host oHost;
		private int? nUserHostID = null;


		public frmActs()
		{
            oActList = new Act();
			oActCur = new Act();
			if (oActList.ErrorNumber != 0 ||
				oActCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

            oActTemp = new Act();
            if (oActTemp.ErrorNumber != 0)
            {
                IsValid = false;
            }

			oHost = new Host();
			if (oHost.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmActs_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			lblHosts.Visible =
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled =
				(oHost.Count() > 1 && !nUserHostID.HasValue);

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

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled = false;

			dtrDates.dtpBegDate.Select();
			
			return (true);
		}

		private bool tabData_Restore()
		{
			dgvActs_Restore();
			btnAdd.Enabled = true;
			if (dgvActs.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled = true;

				dgvActs.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled = false;
                dgvActsGoods_Restore();
			}
			return (true);
		}

		private bool tabActsGoods_Restore()
		{
			return (dgvActsGoods_Restore());
		}

	#region RowEnter, CellFormatting 
	
		private void dgvActs_CurrentRowChanged(object sender)
		{
			if (dgvActs.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;
			
			if (dgvActs.CurrentRow == null)
			   return;
			
			int rowIndex = dgvActs.CurrentRow.Index;

			if (dgvActs.IsStatusRow(rowIndex))
			{
				oActCur.ClearOne();
				btnEdit.Enabled =
				btnDelete.Enabled = 
					false;
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvActs.Rows[rowIndex]).DataBoundItem).Row;
				oActCur.FillOne(dr);
				btnEdit.Enabled = (!oActCur.DateConfirm.HasValue && !oActCur.ReadyForWMS);
                btnDelete.Enabled = (!oActCur.DateConfirm.HasValue && !oActCur.ReadyForWMS);
			}
			tcActsDetails.SetAllNeedRestore(true);
		}

		private void dgvActs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvActs.DataSource == null)
				return;

			// статусная строка
			if (dgvActs.IsStatusRow(e.RowIndex))
			{
				if (dgvActs.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)dgvActs.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = dgvActs.Columns[e.ColumnIndex];
			oActTemp.FillOne(r);
			//
            switch (c.Name)
            {

                case "dgvcConfirmedImage":
                    if (oActTemp.DateConfirm.HasValue)
                    {
                        e.Value = Properties.Resources.Check;
                    }
                    else
                    {
                        e.Value = Properties.Resources.Empty;
                    }
                    break;
            }
		}

		private void dgvActsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView dgv = dgvActsGoods;
			if (dgv.DataSource == null)
				return;
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE")) 
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			DataRow r = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

			if (sColumnName.Contains("QNT") || sColumnName.Contains("INBOX"))
			{
				if ((!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"]) ||
					(!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value)))
				{
					e.CellStyle.Format = "### ###.000";
				}
				else
				{
					e.CellStyle.Format = "### ###";
				}
			}
		}

	#endregion 

	#region Restore

		private bool dgvActs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oActCur.ClearOne();

			oActList.ClearError();
			oActList.ClearFilters();
			oActList.ID = null;
			oActList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oActList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oActList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// владельцы
			oActList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
	          
            // выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oActList.FilterPackingsList = ucSelectRecordIDForm_Packings.GetIdString();
			}

            // акт привязан к рейсу
            if (optTripExistsNot.Checked)
            {
                oActList.FilterTripExists = false;
            }
            if (optTripExists.Checked)
            {
                oActList.FilterTripExists = true;
            }

            // приход готов к обработке на складе
            if (optReadyForWMSNot.Checked)
            {
                oActList.FilterReadyForWMS = false;
            }
            if (optReadyForWMS.Checked)
            {
                oActList.FilterReadyForWMS = true;
            }

            // состояние прихода: подтверждение 
            if (optIsConfirmedNot.Checked)
            {
                oActList.FilterIsConfirmed = false;
                
            }
            if (optIsConfirmed.Checked)
            {
                oActList.FilterIsConfirmed = true;
            }

            if (optPutExistsNot.Checked)
                oActList.FilterPutExists = false;
            
            if (optPutExists.Checked)
            {
                oActList.FilterPutExists = true;
                if (chkInput.Checked)
                    oActList.FilterInputExists = true;
                if (chkOutput.Checked)
                    oActList.FilterOutputExists = true;
            }

			if (nUserHostID.HasValue)
			{
				oActList.FilterHostsList = nUserHostID.ToString();
			}
			else 
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oActList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			// 

			dgvActs.GetGridState();
			oActList.FillData();
			dgvActs.IsLockRowChanged = true;
			dgvActs.Restore(oActList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oActList.ErrorNumber == 0);
		}

		private bool dgvActsGoods_Restore()
		{
			dgvActsGoods.GetGridState();
			dgvActsGoods.DataSource = null;
			if (dgvActs.Rows.Count == 0 || 
				!oActCur.ID.HasValue ||
				(dgvActs.CurrentRow != null && dgvActs.IsStatusRow(dgvActs.CurrentRow.Index)))
				return (true);
            oActList.FillTableActsGoods((int)oActCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oActList.TableActsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"GoodAlias, ID");
				oActList.TableActsGoods.Clear();
				oActList.TableActsGoods.Merge(dt);
			}
			
			dgvActsGoods.Restore(oActList.TableActsGoods);
			return (oActList.ErrorNumber == 0);
		}

	#endregion 
		
	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (StartForm(new frmActsEdit(0, null, null)) == DialogResult.Yes)
			{
				int nActID = (int)GotParam.GetValue(0);
				dgvActs_Restore();
				if (nActID > 0)
				{
					dgvActs.GridSource.Position = dgvActs.GridSource.Find(oActList.ColumnID, nActID);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (dgvActs.CurrentRow == null)
				return;

            if (!oActCur.ID.HasValue)
				return;

            
            if (oActCur.DateConfirm.HasValue)
            {
                RFMMessage.MessageBoxAttention("Акт уже подтвержден.\n" + 
					"Редактирование невозможно!");
                return;
            }


            if (StartForm(new frmActsEdit((int)oActCur.ID, (int?)oActCur.InputID, (int?)oActCur.OutputID)) == DialogResult.Yes)
			{
				dgvActs_Restore();
			}
 
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvActs.CurrentRow == null)
				return;


            if (!oActCur.ID.HasValue)
                return;

            // перечитать
            oActCur.ReFillOne((int)oActCur.ID);

            // проверки
            if (oActCur.ERPCode != null)
            {
                RFMMessage.MessageBoxError("Акт получен из host-системы...\n" +
                    "Удаление невозможно.");
                return;
            }
            if (oActCur.DateConfirm != null)
            {
                RFMMessage.MessageBoxError("Акт уже подтвержден...\n" +
                    "Удаление невозможно.");
                return;
            }
            if (oActCur.SentToWMS)
            {
                RFMMessage.MessageBoxError("Акт передан в складскую систему...\n" +
                    "Удаление невозможно.");
                return;
            }
            if (oActCur.ReadyForWMS)
            {
                RFMMessage.MessageBoxError("Акт готов для передачи в складскую систему...\n" +
                    "Удаление невозможно.");
                return;
            }

			if (RFMMessage.MessageBoxYesNo("Удалить акт?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oActCur.Delete((int)oActCur.ID);
				WaitOff(this);
				if (bResult && oActCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Акт удален.");
					dgvActs_Restore();
				}
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

		#region Packings

		private void ucSelectRecordIDForm_Packings_Restore()
		{
			ucSelectRecordIDForm_Packings.SendParams = new object[] 
				{ ucSelectRecordIDForm_Packings, true };
			ucSelectRecordIDForm_Packings.Restore();
		}

		private void ucSelectRecordIDForm_Packings_TxtData_TextChanged(object sender, EventArgs e)
		{
			if (ucSelectRecordIDForm_Packings.TxtData.Text.Trim().Length > 0)
			{
				chkShowSelectedGoodsOnly.Enabled = true;
			}
			else
			{
				chkShowSelectedGoodsOnly.Checked =
				chkShowSelectedGoodsOnly.Enabled =
					false;
			}
		} 

		#endregion Packings

		#region Hosts

		private void ucSelectRecordID_Hosts_Restore()
		{
			if (ucSelectRecordID_Hosts.sourceData == null)
			{
				if (Utilities.FillData_Hosts(oHost))
				{
					ucSelectRecordID_Hosts.Restore(oHost.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Hosts.Restore();
			}
		}

		#endregion Hosts

		private void optPutExists_CheckedChanged(object sender, EventArgs e)
		{
			chkInput.Enabled = chkOutput.Enabled = optPutExists.Checked;
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
            optIsConfirmedAll.Checked = optPutExistsAll.Checked =
            optReadyForWMSAll.Checked = optTripExistsAll.Checked = true;
			ucSelectRecordID_Owners.ClearData(); 
            chkInput.Checked = 
			chkOutput.Checked = 
				false;

			ucSelectRecordID_Hosts.ClearData();
			
			ucSelectRecordIDForm_Packings.ClearData();
			chkShowSelectedGoodsOnly.Checked = 
			chkShowSelectedGoodsOnly.Enabled = 
				false;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabData.IsNeedRestore = true;
		}

	#endregion

	}
}