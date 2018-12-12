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
	public partial class frmActsEdit : RFMFormChild
	{
		private int nActID;
        private int? nInputID, nOutputID;

		private Act oAct;
		private Good oGood;
		private Partner oPartner;
        private GoodState oGoodState;

		private int? nUserHostID = null;

        protected int? nNewPackingID = null;
		protected bool bWeighting = false;
		public int? _SelectedPackingID = null;
		public string _SelectedPackingAliasText = null;

		public int? _SelectedID = null;

		DataTable dt = null; 

		public frmActsEdit(int _ActID, int? _nInputID, int? _OutputID)
		{
            nActID = _ActID;
            nInputID = _nInputID;
            nOutputID = _OutputID;

            oAct = new Act();

			if (oAct.ErrorNumber != 0)
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
                oPartner = new Partner();
                if (oPartner.ErrorNumber != 0)
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

			if (nActID > 0 || nInputID.HasValue || nOutputID.HasValue || nUserHostID.HasValue)
				PreFormName = "";
		}

		public frmActsEdit(int _ActID, int? _nInputID, int? _OutputID, DataTable _dt)
			: this(_ActID, _nInputID, _OutputID)
		{
			dt = _dt;
		}

		private void frmActsEdit_Load(object sender, EventArgs e)
		{
			if (!(nActID > 0 || nInputID.HasValue || nOutputID.HasValue))
			{
				if (!nUserHostID.HasValue)
				{
					oAct.HostID = (int)GetParamStore().GetValue(0);
					if (oAct.HostID == 0)
					{
						Close();
						return;
					}
				}
				else
					oAct.HostID = nUserHostID;
			}

			bool bResult = cboGoodsState_Restore();
			if (!bResult)
			{
				DialogResult = DialogResult.No;
				return;
			}

			dgvcQntConfirmed.Minimum =
			dgvcBoxConfirmed.Minimum =
				-999999999;

			if (nActID != 0)
			{
				oAct.ReFillOne((int)nActID);

				if (nUserHostID.HasValue && (int)nUserHostID != oAct.HostID)
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
					Text += " (" + nActID.ToString() + ")";

					dtpDateAct.Value = oAct.DateAct;
					/*
					if (nOutputID == null && nInputID == null)
					{
						cboOwner.Visible = cboGoodsState.Visible = true;
						cboGoodsState.SelectedValue = oAct.GoodStateID;
						cboOwner.SelectedValue = oAct.OwnerID;
					}
					else
					{
						txtOwnerName.Text = oAct.OwnerName.Trim();
						txtGoodStateName.Text = oAct.GoodStateName.Trim();
					}
					*/
					cboGoodsState.SelectedValue = oAct.GoodStateID;
					cboOwner.SelectedValue = oAct.OwnerID;

					if (oAct.InputID != null)
					{
						txtInputID.Text = oAct.InputID.ToString();
						chkInput.Checked = true;
					}
					else
					{
						txtInputID.Text = "";
						chkInput.Checked = false;
					}

					if (oAct.OutputID != null)
					{
						txtOutputID.Text = oAct.OutputID.ToString();
						chkOutput.Checked = true;
					}
					else
					{
						txtOutputID.Text = oAct.OutputID.ToString();
						chkOutput.Checked = false;
					}

					if (oAct.ReadyForWMS)
					{
						chkReadyForWMS.Checked = true;
						chkReadyForWMS.Enabled = false;
					}

					txtNote.Text = oAct.Note;
				}
			}
			else
			{
				// новый акт
				if (bResult)
				{
					if (nOutputID == null && nInputID == null)
					{
						bResult = cboOwner_Restore();

						if (bResult)
						{
							cboOwner.SelectedIndex =
							cboGoodsState.SelectedIndex =
								-1;
						}
					}
					else
					{
						if (nInputID != null)
						{
							chkInput.Checked = true;
							txtInputID.Text = nInputID.ToString();
							Input oInput = new Input();
							oInput.ReFillOne((int)nInputID);
							//txtGoodStateName.Text = oInput.MainTable.Rows[0]["GoodStateName"].ToString();
							//txtOwnerName.Text = oInput.MainTable.Rows[0]["OwnerName"].ToString();
							cboGoodsState.SelectedValue = oInput.GoodStateID;
							if (nUserHostID.HasValue && (int)nUserHostID != (int)oInput.HostID)
							{
								RFMMessage.MessageBoxError("Несовпадение прав доступа к данным хоста...");
								Close();
								return;
							}
							oAct.HostID = oInput.HostID;

							bResult = cboOwner_Restore();
							if (bResult)
							{
								cboOwner.SelectedValue = oInput.OwnerID;
							}
						}
						else
						{
							chkOutput.Checked = true;
							txtOutputID.Text = nOutputID.ToString();
							Output oOutput = new Output();
							oOutput.ReFillOne((int)nOutputID);
							//txtGoodStateName.Text = oOutput.MainTable.Rows[0]["GoodStateName"].ToString();
							//txtOwnerName.Text = oOutput.MainTable.Rows[0]["OwnerName"].ToString();
							cboGoodsState.SelectedValue = oOutput.GoodStateID;
							if (nUserHostID.HasValue && (int)nUserHostID != (int)oOutput.HostID)
							{
								RFMMessage.MessageBoxError("Несовпадение прав доступа к данным хоста...");
								Close();
								return;
							}
							oAct.HostID = oOutput.HostID;

							bResult = cboOwner_Restore();
							if (bResult)
							{
								cboOwner.SelectedValue = oOutput.OwnerID;
							}
						}
					}
				}

				dgvActGoods_Restore(); 
			}
			
			if (!bResult)
			{
				Dispose();
			}

			Host oHost = new Host();
			if (oHost.Count() > 1)
			{
				oHost.ReFillOne((int)oAct.HostID);
				Text += " [" + oHost.Name + "]";
			}

	    	// встать на первую строку, в ячейку "Коробок"
			if (dgvActGoods.RowCount > 0)
			{
				dgvActGoods.CurrentCell = dgvActGoods.Rows[0].Cells["dgvcBoxConfirmed"];
			}
		}

		#region Restore

		#region Grid restore

		private bool dgvActGoods_Restore()
		{
			oAct.ClearError();
            oAct.ID = nActID;
			oAct.FillDataAsync();
			if (oAct.ErrorNumber == 0)
			{
                if (nActID != 0)
                {
                    oAct.FillTableActsGoods();
                    if (oAct.ErrorNumber == 0)
                    {
                        oAct.TableActsGoods.PrimaryKey = null;
                        oAct.TableActsGoods.Columns["ID"].Unique = false;
                        oAct.TableActsGoods.Columns["ID"].AllowDBNull = true;
                        oAct.TableActsGoods.Columns["ActGoodID"].Unique = false;
                        oAct.TableActsGoods.Columns["ActGoodID"].AllowDBNull = true;

                    }
                }
                else
                {
					oAct.FillTableActsGoodsFromPut(nInputID, nOutputID);
					if (oAct.ErrorNumber == 0)
					{
						oAct.TableActsGoods.PrimaryKey = null;
						oAct.TableActsGoods.Columns["ID"].Unique = false;
						oAct.TableActsGoods.Columns["ID"].AllowDBNull = true;
						oAct.TableActsGoods.Columns["ActGoodID"].Unique = false;
						oAct.TableActsGoods.Columns["ActGoodID"].AllowDBNull = true;
					}

					if (dt != null)
					{
						oAct.TableActsGoods.Clear();
						oAct.TableActsGoods.Merge(dt);
					}
                }
                decimal nQnt = 0;
                decimal nBox = 0;
                foreach (DataRow droRow in oAct.TableActsGoods.Rows)
                {
                    nQnt += (decimal)droRow["QntConfirmed"];
                    nBox += (decimal)droRow["BoxConfirmed"];
                }
                dgvActGoods.GetGridState();
                dgvActGoods.Restore(oAct.TableActsGoods);
                lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
                lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
			}
			return (oAct.ErrorNumber == 0);
		}

		#endregion Grid restore 

		#region cbo restore

		private bool cboOwner_Restore()
        {
            oPartner.ClearError();
			oPartner.FilterActual = true;
            oPartner.FilterIsOwner = true;
			if (oAct != null && oAct.HostID.HasValue)
				oPartner.FilterHostsList = oAct.HostID.ToString();
            if (oPartner.FillDataAsync())
            {
                cboOwner.DataSource = new DataView(oPartner.MainTable);
                cboOwner.ValueMember = oPartner.ColumnID;
                cboOwner.DisplayMember = "Name";
                cboOwner.Restore();
            }
            return (oPartner.ErrorNumber == 0);
        }

        private bool cboGoodsState_Restore()
        {
            oGoodState.ClearError();
            if (oGoodState.FillDataAsync())
            {
                cboGoodsState.DataSource = new DataView(oGoodState.MainTable);
                cboGoodsState.ValueMember = oGoodState.ColumnID;
                cboGoodsState.DisplayMember = "Name";
                cboGoodsState.Restore();
            }
            return (oPartner.ErrorNumber == 0);
		}

		#endregion cbo restore
		
		#endregion Restore

		#region GridCells

		private void dgvActGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvActGoods.DataSource == null || dgvActGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvActGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			switch (dgvActGoods.Columns[e.ColumnIndex].Name)
			{
				case "dgvcInBox":
				case "dgvcQntConfirmed":
					if (!Convert.IsDBNull(droRow["Weighting"]) && Convert.ToBoolean(droRow["Weighting"]) ||
						!Convert.IsDBNull(droRow["InBox"]) && Convert.ToInt32(droRow["InBox"]) != Convert.ToDecimal(droRow["InBox"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
						e.CellStyle.Format = "### ###.000";
					else
						e.CellStyle.Format = "### ###";
					break;
			}
		}

		private void dgvActGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvActGoods.Columns[e.ColumnIndex].Name.Contains("Qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvActGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvActGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvActGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oAct.TableActsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvActGoods.Columns[e.ColumnIndex].Name.ToLower();
			if (sColumnName == "dgvcqntconfirmed" ||sColumnName == "dgvcboxconfirmed")
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvActGoods.Rows[e.RowIndex]).DataBoundItem).Row;
				if (dr == null)
					return;

				decimal nInbox = (decimal)dr["InBox"];
				if (sColumnName == "dgvcqntconfirmed")
				{
					// меняем штуки -> пересчитываем коробки
					dr["BoxConfirmed"] = (decimal)dgvActGoods.Rows[e.RowIndex].Cells["dgvcQntConfirmed"].Value / nInbox;
				}
				if (sColumnName == "dgvcboxconfirmed")
				{
					// меняем коробки -> пересчитываем штуки
					if ((bool)dr["Weighting"] || nInbox != (int)nInbox)
						dr["QntConfirmed"] = (decimal)dgvActGoods.Rows[e.RowIndex].Cells["dgvcBoxConfirmed"].Value * nInbox;
					else
                        dr["QntConfirmed"] = (decimal.Ceiling)(decimal.Round((decimal)dgvActGoods.Rows[e.RowIndex].Cells["dgvcBoxConfirmed"].Value * nInbox, 1));
				}

				dgvActGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvActGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow dgr = dgvActGoods.Rows[e.RowIndex];
			if (dgvActGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgvcqntconfirmed")
			{
				//bIsEditQnt = true;
				if (dgr.Cells["dgvcQntConfirmed"].Value == null || dgr.Cells["dgvcQntConfirmed"].Value == DBNull.Value)
				{
					dgr.Cells["dgvcQntConfirmed"].Value = 0;
					return; 
				}
				//bIsEditQnt = false;
			}

			if (dgvActGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgvcboxconfirmed")
			{
				//bIsEditBox = false;
				if (dgr.Cells["dgvcBoxConfirmed"].Value == null || dgr.Cells["dgvcBoxConfirmed"].Value == DBNull.Value)
				{
					dgr.Cells["dgvcBoxConfirmed"].Value = 0;
					return;
				}
				//bIsEditBox = false;
			}

			dgvActGoods.Refresh();
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
			foreach (DataRow dr in oAct.TableActsGoods.Rows)
			{
				if ((decimal)dr["QntConfirmed"] != 0)  
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
				return;
			}
			oAct.OwnerID = (int)cboOwner.SelectedValue;
			if (cboGoodsState.SelectedValue == null || cboGoodsState.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указано состояние товара...");
				return;
			}
			oAct.GoodStateID = (int)cboGoodsState.SelectedValue;

            DataTable dtTemp;
            if (nInputID == null && nOutputID == null)
            {
              //oAct.OwnerID = (int)cboOwner.SelectedValue;
              //oAct.GoodStateID = (int)cboGoodsState.SelectedValue;
              dtTemp = new DataTable();
            }
            else
            {
                if (nInputID != null)
                {
                    Input oInput = new Input();
                    oInput.ReFillOne(Convert.ToInt32(nInputID));
                    oAct.InputID = nInputID;
                    oAct.OutputID = null;
                    //oAct.OwnerID = oInput.OwnerID;
                    //oAct.GoodStateID = oInput.GoodStateID;
                    oInput.FillTableInputsGoodsWithActs();
                    dtTemp = oInput.TableInputsGoods;
                }
                else
                {
                    Output oOutput = new Output();
                    oOutput.ID = nOutputID;
                    oOutput.ReFillOne(Convert.ToInt32(nOutputID));
                    //oAct.OwnerID = oOutput.OwnerID;
                    //oAct.GoodStateID = oOutput.GoodStateID;
                    oAct.OutputID = nOutputID;
                    oAct.InputID = null;
                    oOutput.FillTableOutputsGoodsWithActs();
                    dtTemp = oOutput.TableOutputsGoods;
                }
            }
            StringBuilder sbWrongGoodQnt = new StringBuilder("");
            bool bNewPackingID;
            foreach (DataRow dr in oAct.TableActsGoods.Rows)
            {
                if ((decimal)dr["QntConfirmed"] < 0)
                {
                    bNewPackingID = true;
                    foreach( DataRow drT in dtTemp.Rows)
                    {
                        // Ищем товар по упаковке и состоянию
                        // По состоянию пока не получается!
                        //if ((int)drT["PackingID"] == (int)dr["PackingID"] && (int)drT["GoodStateID"] == (int)dr["GoodStateID"])
                        if ((int)drT["PackingID"] == (int)dr["PackingID"] &&
							(int)drT["GoodStateID"] == (int)oAct.GoodStateID)
                            {
                             bNewPackingID = false;
                            if ((decimal)drT["QntConfirmed"] + (decimal)dr["QntConfirmed"] < 0)
                            {
                                sbWrongGoodQnt = sbWrongGoodQnt.Append(dr["GoodAlias"].ToString() + "\r\n");
                                break;
                            }
                        }
                    }

                    // Не обнаружили товар - ввод отрицательного количества для нового товара запрещен
                    if (bNewPackingID)
                        sbWrongGoodQnt = sbWrongGoodQnt.Append(dr["GoodAlias"].ToString() + "\r\n");
                }
            }
            if (sbWrongGoodQnt.Length > 0)
            {
                RFMMessage.MessageBoxError("Для следующих товаров указано неверное количество:\r\n" +
                    sbWrongGoodQnt +
                    "Сохранение акта невозможно...");
                return;
                        
            }
			if (RFMMessage.MessageBoxYesNo("Сохранить акт?") == DialogResult.Yes)
			{
				oAct.ID = nActID;
                oAct.DateAct = dtpDateAct.Value.Date;
				oAct.Note = txtNote.Text.Trim();
                oAct.ReadyForWMS = chkReadyForWMS.Checked;
				Refresh();
				WaitOn(this);
				oAct.ClearError();
                bool bResult = oAct.Save(((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oAct.ErrorNumber == 0)
				{
					/*
					// сейчас не используем, т.к. создаваемый акт сразу IsConfirmed, ReadyForWMS
                    if (chkReadyForWMS.Checked) 
                        oAct.SetReadyForWMS((int)oAct.ID);
					*/ 
                    if (oAct.ErrorNumber == 0)
                    {
                        //RFMMessage.MessageBoxInfo("Акт сохранен.");
                        MotherForm.GotParam = new object[] { (int)oAct.ID };
                        DialogResult = DialogResult.Yes;
                        Dispose();
                    }
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_SelectedPackingID = null;
			nNewPackingID = null;
			if (StartForm(new frmSelectOnePacking(this, false, null, oAct.HostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingID != null)
				{
					// проверить, нет ли уже такой строки
					foreach (DataRow r in oAct.TableActsGoods.Rows)
					{
						if (Convert.ToInt32(r["PackingID"]) == _SelectedPackingID)
						{
							dgvActGoods.GridSource.Position = dgvActGoods.GridSource.Find("PackingID", _SelectedPackingID);
							if (dgvActGoods.GridSource.Position < 0)
							{
								dgvActGoods.GridSource.MoveFirst();
							}
							return;
						}
					}
		
					oGood.PackingID = _SelectedPackingID;
					oGood.FillDataAsync();
					// выбранный товар
					DataRow rg = oGood.MainTable.Rows[0];
					// добавляем новую строку для выбранного товара
					DataRow dr = oAct.TableActsGoods.Rows.Add(-1, -1);
					dr["PackingID"] = _SelectedPackingID;
					dr["GoodID"] = rg["GoodID"];
					dr["QntConfirmed"] = 
                    dr["BoxConfirmed"] = 
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
					dgvActGoods.GridSource.Position = dgvActGoods.GridSource.Find("PackingID", _SelectedPackingID);
					if (dgvActGoods.GridSource.Position < 0)
					{
						dgvActGoods.GridSource.MoveFirst();
					}
					// встать на найденную строку, в ячейку "Коробок заказ"
					dgvActGoods.CurrentCell = dgvActGoods.Rows[dgvActGoods.GridSource.Position].Cells["dgvcBoxConfirmed"];
				}
				_SelectedPackingID = null;
				_SelectedPackingAliasText = null;
			}
		}

		private void CalcTotal()
		{
			decimal nQnt = 0;
			decimal nBox = 0;
			foreach (DataRow r in oAct.TableActsGoods.Rows)
			{
				nQnt += (decimal)r["QntConfirmed"];
				nBox += (decimal)r["BoxConfirmed"];
			}
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
		}

		private void frmActsEdit_KeyDown(object sender, KeyEventArgs e)
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

	}
}
