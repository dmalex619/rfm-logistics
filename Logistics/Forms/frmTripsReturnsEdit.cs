using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using LogBizObjects;
using RFMPublic;

namespace Logistics 
{
	public partial class frmTripsReturnsEdit : RFMFormChild
	{
		private int nTripReturnID;
		private int nTripID;

		private TripReturn oTripReturn;
        private Partner oOwner;
		private Good oGood;
        private GoodState oGoodState;

		private int? nUserHostID = null;

		public int? _SelectedPackingID = null;


		public frmTripsReturnsEdit(int _TripReturnID, int _nTripID)
		{
            nTripReturnID = _TripReturnID;
			nTripID = _nTripID;

            oTripReturn = new TripReturn();

			if (oTripReturn.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oGood = new Good();
				if (oGood.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}
            if (IsValid)
            {
                oOwner = new Partner();
                if (oOwner.ErrorNumber != 0)
                {
                    IsValid = false;
                }
            }
            if (IsValid)
            {
                oGoodState = new GoodState();
                if (oGoodState.ErrorNumber != 0)
                {
                    IsValid = false;
                }
            }

			if (IsValid)
			{
				InitializeComponent();
			}

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			if (nTripReturnID > 0 || nUserHostID.HasValue)
				PreFormName = "";
		}


		private void frmTripsReturnsEdit_Load(object sender, EventArgs e)
		{
			if (nTripReturnID == 0)
			{
				if (!nUserHostID.HasValue)
				{
					object oHostID = null;
					try
					{
						oHostID = GetParamStore().GetValue(0);
					}
					catch { }
					if (oHostID == null)
					{
						Close();
						return;
					}
					else
					{
						oTripReturn.HostID = (int?)oHostID;
						if (!oTripReturn.HostID.HasValue || oTripReturn.HostID == 0)
						{
							Close();
							return;
						}
					}
				}
				else
					oTripReturn.HostID = nUserHostID;
			}

            bool bResult = cboGoodsState_Restore();
			if (bResult)
			{
				if (nTripReturnID != 0)
				{
                    oTripReturn.ReFillOne((int)nTripReturnID);
					if (oTripReturn.ErrorNumber != 0 || oTripReturn.MainTable.Rows.Count == 0)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о возврате...");
                        DialogResult = DialogResult.No;
                        return;
					}

					if (nUserHostID.HasValue && (int)nUserHostID != (int)oTripReturn.HostID)
					{
						RFMMessage.MessageBoxError("Несовпадение прав доступа к данным хоста...");
						bResult = false;
					}

					if (bResult)
					{
						bResult = cboOwner_Restore();
					}

					if (bResult)
					{
						Text += " (" + nTripReturnID.ToString() + ")";

						dtpDateTripReturn.Value = oTripReturn.DateReturn;
						cboGoodsState.SelectedValue = oTripReturn.GoodStateID;
						cboOwner.SelectedValue = oTripReturn.OwnerID;
						chkAutocreate.Checked = oTripReturn.AutoCreated;
						txtNote.Text = oTripReturn.Note;
						if (chkAutocreate.Checked)
							cboGoodsState.Enabled = cboOwner.Enabled = false;

						//chkReadyForWMS.Checked = oTripReturn.ReadyForWMS;
						if (oTripReturn.AutoCreated)
							chkReadyForWMS.Checked = true;
						else
							chkReadyForWMS.Checked = oTripReturn.ReadyForWMS;
					}
				}
				else
				{
					// новый возврат
					bResult = cboOwner_Restore();

					if (bResult)
					{
						chkAutocreate.Checked = false;
					}
    			}

				if (bResult)
				{
					dgvTripRetunGoods_Restore();
				}
			}
			
			if (!bResult)
			{
				DialogResult = DialogResult.No;
				Dispose();
				return;
			}

			Host oHost = new Host();
			if (oHost.Count() > 1)
			{
				oHost.ReFillOne((int)oTripReturn.HostID);
				Text += " [" + oHost.Name + "]";
			}

	    	// встать на первую строку, в ячейку "Коробок"
			if (dgvTripReturnGoods.RowCount > 0)
			{
				dgvTripReturnGoods.CurrentCell = dgvTripReturnGoods.Rows[0].Cells["dgvcBoxWished"];
				dgvTripReturnGoods.Select();
			}
		}

		#region Restore

		#region Grid

		private bool dgvTripRetunGoods_Restore()
		{
			oTripReturn.ClearError();
            oTripReturn.ID = nTripReturnID;
			oTripReturn.FillData();
			if (oTripReturn.ErrorNumber == 0)
			{
                oTripReturn.FillTableTripsReturnsGoods();
                if (oTripReturn.ErrorNumber == 0)
                {
                    oTripReturn.TableTripsReturnsGoods.PrimaryKey = null;
                    oTripReturn.TableTripsReturnsGoods.Columns["ID"].Unique = false;
                    oTripReturn.TableTripsReturnsGoods.Columns["ID"].AllowDBNull = true;
                    oTripReturn.TableTripsReturnsGoods.Columns["TripReturnGoodID"].Unique = false;
                    oTripReturn.TableTripsReturnsGoods.Columns["TripReturnGoodID"].AllowDBNull = true;

                }
                decimal nQnt = 0;
                decimal nBox = 0;
				if (oTripReturn.TableTripsReturnsGoods.Rows.Count > 0)
				{
					foreach (DataRow droRow in oTripReturn.TableTripsReturnsGoods.Rows)
					{
						nQnt += (decimal)droRow["QntWished"];
						nBox += (decimal)droRow["BoxWished"];
					}
				}
                dgvTripReturnGoods.GetGridState();
                dgvTripReturnGoods.Restore(oTripReturn.TableTripsReturnsGoods);
                lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
                lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
			}
			return (oTripReturn.ErrorNumber == 0);
		}

		#endregion Grid

        private bool cboOwner_Restore()
        {
            oOwner.ClearError();
			oOwner.FilterActual = true;
            oOwner.FilterIsOwner = true;
			if (oTripReturn != null && oTripReturn.HostID.HasValue)
				oOwner.FilterHostsList = oTripReturn.HostID.ToString();

            if (oOwner.FillData())
            {
                cboOwner.ValueMember = oOwner.ColumnID;
                cboOwner.DisplayMember = oOwner.ColumnName;
				cboOwner.Restore(oOwner.MainTable);
            }
            return (oOwner.ErrorNumber == 0);
        }

        private bool cboGoodsState_Restore()
        {
            oGoodState.ClearError();
            if (oGoodState.FillData())
            {
                cboGoodsState.ValueMember = oGoodState.ColumnID;
				cboGoodsState.DisplayMember = oGoodState.ColumnName;
				cboGoodsState.Restore(oGoodState.MainTable);
            }
            return (oGoodState.ErrorNumber == 0);
        }

		#endregion

		#region GridCells

		private void dgvTripRetunGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvTripReturnGoods.DataSource == null || dgvTripReturnGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvTripReturnGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			switch (dgvTripReturnGoods.Columns[e.ColumnIndex].Name)
			{
				case "dgvcInBox":
				case "dgvcQntWished":
					if (!Convert.IsDBNull(droRow["Weighting"]) &&
						Convert.ToBoolean(droRow["Weighting"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
						e.CellStyle.Format = "### ###.000";
					else
						e.CellStyle.Format = "### ###";
					break;
			}
		}

		private void dgvTripRetunGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oTripReturn.TableTripsReturnsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvTripReturnGoods.Columns[e.ColumnIndex].Name.ToLower();
			if (sColumnName == "dgvcqntwished" ||sColumnName == "dgvcboxwished")
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvTripReturnGoods.Rows[e.RowIndex]).DataBoundItem).Row;
				if (dr == null)
					return;

				decimal nInbox = (decimal)dr["InBox"];
				if (sColumnName == "dgvcqntwished")
				{
					// меняем штуки
					dr["BoxWished"] = (decimal)dgvTripReturnGoods.Rows[e.RowIndex].Cells["dgvcQntWished"].Value / nInbox;
				}
				if (sColumnName == "dgvcboxwished")
				{
					// меняем коробки
					if (nInbox != (int)nInbox || (bool)dr["Weighting"])
                        dr["QntWished"] = (decimal)dgvTripReturnGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox;
                    else
						dr["QntWished"] = (decimal.Ceiling)((decimal)dgvTripReturnGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox);
				}

				dgvTripReturnGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvTripRetunGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow dgr = dgvTripReturnGoods.Rows[e.RowIndex];
			if (dgvTripReturnGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgvcqntwished")
			{
				//bIsEditQnt = true;
				if (dgr.Cells["dgvcQntWished"].Value == null || dgr.Cells["dgvcQntWished"].Value == DBNull.Value)
				{
					dgr.Cells["dgvcQntWished"].Value = 0;
					return; 
				}
				//bIsEditQnt = false;
			}

			if (dgvTripReturnGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgvcboxwished")
			{
				//bIsEditBox = false;
				if (dgr.Cells["dgvcBoxWished"].Value == null || dgr.Cells["dgvcBoxWished"].Value == DBNull.Value)
				{
					dgr.Cells["dgvcBoxWished"].Value = 0;
					return;
				}
				//bIsEditBox = false;
			}

			dgvTripReturnGoods.Refresh();
		}

		#endregion

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
        	bool bFound = false;
			foreach (DataRow dr in oTripReturn.TableTripsReturnsGoods.Rows)
			{
				if ((decimal)dr["QntWished"] > 0)  
				{
					bFound = true;
					break;
				}
			}
			if (!bFound)
			{
                RFMMessage.MessageBoxError("Ни для одного товара не введено количество...");
				return;
			}

			if (cboOwner.SelectedValue == null || cboOwner.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указан владелец...");
				cboOwner.Select();
				return;
			}
			if (cboGoodsState.SelectedValue == null || cboGoodsState.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указано состояние товара...");
				cboGoodsState.Select();
				return;
			}
			
			if (RFMMessage.MessageBoxYesNo("Сохранить возврат?") == DialogResult.Yes)
			{
                oTripReturn.DateReturn = dtpDateTripReturn.Value.Date;
				oTripReturn.OwnerID = (int)cboOwner.SelectedValue;
				oTripReturn.GoodStateID = (int)cboGoodsState.SelectedValue;
				oTripReturn.Note = txtNote.Text.Trim();
                oTripReturn.AutoCreated = chkAutocreate.Checked;
				oTripReturn.TripID = nTripID; 
				Refresh();
				WaitOn(this);
				oTripReturn.ClearError();
				bool bResult = oTripReturn.Save(((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oTripReturn.ErrorNumber == 0)
				{
                    if (chkReadyForWMS.Checked)
                        oTripReturn.SetReadyForWMS((int)oTripReturn.ID);
                    if (oTripReturn.ErrorNumber == 0)
                    {
                        //RFMMessage.MessageBoxInfo("Возврат сохранен.");

						// печать
						if (chkReadyForWMS.Checked)
						{
							LogService.TripReturnBill_Print(oTripReturn, this);
						}

                        MotherForm.GotParam = new object[] { (int)oTripReturn.ID };
                        DialogResult = DialogResult.Yes;
                        Dispose();
                    }
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_SelectedPackingID = null;
			if (StartForm(new frmSelectOnePacking(this, false, null, oTripReturn.HostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingID != null)
				{
					// проверить, нет ли уже такой строки
					foreach (DataRow r in oTripReturn.TableTripsReturnsGoods.Rows)
					{
						if (Convert.ToInt32(r["PackingID"]) == _SelectedPackingID)
						{
							dgvTripReturnGoods.GridSource.Position = dgvTripReturnGoods.GridSource.Find("PackingID", _SelectedPackingID);
							if (dgvTripReturnGoods.GridSource.Position < 0)
							{
								dgvTripReturnGoods.GridSource.MoveFirst();
							}
							return;
						}
					}
		
					oGood.PackingID = _SelectedPackingID;
					oGood.FillData();
					// выбранный товар
					DataRow rg = oGood.MainTable.Rows[0];
					// добавляем новую строку для выбранного товара
					DataRow dr = oTripReturn.TableTripsReturnsGoods.Rows.Add(-1, -1);
					dr["PackingID"] = _SelectedPackingID;
					dr["GoodID"] = rg["GoodID"];
					dr["QntWished"] = 
                    dr["BoxWished"] = 
						0;
					dr["GoodName"] = rg["GoodName"];
					dr["GoodAlias"] = rg["GoodAlias"];
					dr["PackingAlias"] = rg["PackingAlias"];
					dr["GoodBarCode"] = rg["GoodBarCode"];
					dr["Articul"] = rg["Articul"];
					dr["GoodGroupName"] = rg["GoodGroupName"];
					dr["GoodBrandName"] = rg["GoodBrandName"];
					dr["CountryName"] = rg["CountryName"];
					dr["InBox"] = rg["InBox"];
					dr["BoxInPal"] = rg["BoxInPal"];
					dr["Weighting"] = rg["Weighting"];

					// и встаем на эту строку
					dgvTripReturnGoods.GridSource.Position = dgvTripReturnGoods.GridSource.Find("PackingID", _SelectedPackingID);
					if (dgvTripReturnGoods.GridSource.Position < 0)
					{
						dgvTripReturnGoods.GridSource.MoveFirst();
					}
					// встать на найденную строку, в ячейку "Коробок заказ"
					dgvTripReturnGoods.CurrentCell = dgvTripReturnGoods.Rows[dgvTripReturnGoods.GridSource.Position].Cells["dgvcBoxWished"];
					dgvTripReturnGoods.Select();
				}
				_SelectedPackingID = null;
			}
		}

		private void CalcTotal()
		{
			decimal nQnt = 0;
			decimal nBox = 0;
			foreach (DataRow r in oTripReturn.TableTripsReturnsGoods.Rows)
			{
				nQnt += (decimal)r["QntWished"];
				nBox += (decimal)r["BoxWished"];
			}
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
		}

		private void frmTripsReturmsEdit_KeyDown(object sender, KeyEventArgs e)
		{
			if (btnAdd.Enabled && 
				e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
			{
				btnAdd_Click(null, null);
				return;
			}

			if (btnSave.Enabled &&
				(e.KeyCode == Keys.W || e.KeyCode == Keys.S) && e.Modifiers == Keys.Control)
			{
				btnSave_Click(null, null);
				return;
			}
		}

		private void dgvTripRetunGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvTripReturnGoods.Columns[e.ColumnIndex].Name.Contains("Qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvTripReturnGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvTripReturnGoods.Columns[e.ColumnIndex]).DecimalPlaces = 
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvTripReturnGoods_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvTripReturnGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgvcboxwished")
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvTripReturnGoods.CurrentRow).DataBoundItem).Row;
				((RFMDataGridViewTextBoxNumericColumn)dgvTripReturnGoods.Columns[e.ColumnIndex]).ReadOnly = ((bool)dr["Weighting"]);
			}
		}
	}
}
