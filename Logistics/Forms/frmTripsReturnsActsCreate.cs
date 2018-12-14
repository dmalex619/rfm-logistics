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
	public partial class frmTripsReturnsActsCreate : RFMFormChild
	{
		private int nTripID;
		private int nGoodStateID = 0;
		private int nOwnerID = 0;

		private int? nHostID = null;

		private Trip oTrip;

		private TripReturn oTripReturn;
		private Act oAct;

        private Partner oOwner;
        private GoodState oGoodState;
		private Good oGood;

		DataTable dt; 

		public int? _SelectedPackingID = null;


        public frmTripsReturnsActsCreate(int _nTripID, DataTable _dt)
		{
			nTripID = _nTripID;
			dt = _dt;

			if (dt == null) return;

			if (dt.Rows.Count > 0)
			{
				nGoodStateID = (int)dt.Rows[0]["GoodStateID"];
				nOwnerID = (int)dt.Rows[0]["OwnerID"];
			}

			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oTripReturn = new TripReturn();
				if (oTripReturn.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oAct = new Act();
				if (oAct.ErrorNumber != 0)
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
				oGood = new Good();
				if (oGood.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmTripsReturnsActsCreate_Load(object sender, EventArgs e)
		{
			if (nOwnerID > 0)
			{
				oOwner.ReFillOne(nOwnerID);
				if (oOwner.HostID.HasValue && oOwner.HostID > 0)
				{
					nHostID = oOwner.HostID;
				}
			}

			bool bResult = cboOwner_Restore() && cboGoodsState_Restore();
			if (!bResult)
			{
				RFMMessage.MessageBoxError("ќшибка при заполнении классификаторов...");
			}
			else
			{
				bResult = oTrip.ReFillOne(nTripID) && oTrip.ErrorNumber == 0;
				if (!bResult)
				{
					RFMMessage.MessageBoxError("ќшибка при получении данных о рейсе...");
				}
				else
				{
					if (nGoodStateID > 0)
					{
						cboGoodsState.SelectedValue = nGoodStateID;
						cboGoodsState.Enabled = false;
					}
					if (nOwnerID > 0)
					{
						cboOwner.SelectedValue = nOwnerID;
						cboOwner.Enabled = false;
					}

                    chkReturnReadyForWMS.Checked = chkActReadyForWMS.Checked = true;
                    

					dgvGoods_Restore();

					// встать на первую строку, в €чейку " оробок"
					if (dgvGoods.RowCount > 0)
					{
						dgvGoods.CurrentCell = dgvGoods.Rows[0].Cells["dgvcReturnBox"];
						dgvGoods.Select();
					}
				}
			}
	    	
			if (!bResult)
			{
				DialogResult = DialogResult.No;
				Dispose();
				return;
			}

			if (nHostID.HasValue && nHostID > 0)
			{
				Host oHost = new Host();
				if (oHost.Count() > 1)
				{
					oHost.ReFillOne((int)nHostID);
					Text += " [" + oHost.Name + "]";
				}
			}
		}

		#region Restore

		#region Grid

		private bool dgvGoods_Restore()
		{
			dgvGoods.Restore(dt);
			CalcTotal();
			return (true);
		}

		#endregion Grid

		#region Combobox

		private bool cboOwner_Restore()
        {
            oOwner.ClearError();
			oOwner.FilterActual = true;
			oOwner.FilterIsOwner = true;

			if (nOwnerID > 0)
			{
				oOwner.IDList = nOwnerID.ToString(); // только полученное значение
			}
			else
			{
				if (nHostID.HasValue && nHostID > 0)
				{
					oOwner.FilterHostsList = nHostID.ToString();
				}
			}

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

			if (nGoodStateID > 0)
			{
				oGoodState.IDList = nGoodStateID.ToString(); // только полученное значение
			}

            if (oGoodState.FillData())
            {
                cboGoodsState.ValueMember = oGoodState.ColumnID;
                cboGoodsState.DisplayMember = oGoodState.ColumnName;
				cboGoodsState.Restore(oGoodState.MainTable);
            }
            return (oGoodState.ErrorNumber == 0);
		}

		#endregion Combobox

		#endregion Restore

		#region GridCells

		private void dgvGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvGoods.DataSource == null || dgvGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			switch (dgvGoods.Columns[e.ColumnIndex].Name)
			{
				case "dgvcInBox":
				case "dgvcReturnQnt":
				case "dgvcActQnt":
					if (!Convert.IsDBNull(droRow["Weighting"]) &&
						Convert.ToBoolean(droRow["Weighting"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
						e.CellStyle.Format = "### ##0.000";
					else
						e.CellStyle.Format = "### ###";
					break;
			}
		}

		private void dgvGoods_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvGoods.Columns[e.ColumnIndex].Name.ToUpper().Contains("BOX"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvGoods.CurrentRow).DataBoundItem).Row;
				((RFMDataGridViewTextBoxNumericColumn)dgvGoods.Columns[e.ColumnIndex]).ReadOnly = ((bool)dr["Weighting"]);
			}
		}

		private void dgvGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvGoods.Columns[e.ColumnIndex].Name.ToUpper().Contains("QNT"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvGoods.CurrentRow).DataBoundItem).Row;
				decimal nInBox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInBox != (int)nInBox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (dt.Rows.Count == 0)
				return;

			DataRow dr = ((DataRowView)((DataGridViewRow)dgvGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (dr == null)
				return;

			decimal nInBox = (decimal)dr["InBox"];

			string sColumnName = dgvGoods.Columns[e.ColumnIndex].Name.ToUpper();
			if (sColumnName.Contains("QNT"))
			{
				if (sColumnName.Contains("RETURN"))
				{
					dr["ReturnBox"] = (decimal)dgvGoods.Rows[e.RowIndex].Cells["dgvcReturnQnt"].Value / nInBox;
				}
				if (sColumnName.Contains("ACT"))
				{
					dr["ActBox"] = (decimal)dgvGoods.Rows[e.RowIndex].Cells["dgvcActQnt"].Value / nInBox;
				}
				dgvGoods.Refresh();
				CalcTotal();
			}
			if (sColumnName.Contains("BOX"))
			{
				if (sColumnName.Contains("RETURN"))
				{
					if ((bool)dr["Weighting"] || nInBox != (int)nInBox)
						dr["ReturnQnt"] = (decimal)dgvGoods.Rows[e.RowIndex].Cells["dgvcReturnBox"].Value * nInBox;
					else
						dr["ReturnQnt"] = (decimal.Ceiling)((decimal)dgvGoods.Rows[e.RowIndex].Cells["dgvcReturnBox"].Value * nInBox);
				}
				if (sColumnName.Contains("ACT"))
				{
					if ((bool)dr["Weighting"] || nInBox != (int)nInBox)
						dr["ActQnt"] = (decimal)dgvGoods.Rows[e.RowIndex].Cells["dgvcActBox"].Value * nInBox;
					else
						dr["ActQnt"] = (decimal.Ceiling)((decimal)dgvGoods.Rows[e.RowIndex].Cells["dgvcActBox"].Value * nInBox);
				}
				dgvGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow dgr = dgvGoods.Rows[e.RowIndex];
			string sColumnName = dgvGoods.Columns[e.ColumnIndex].Name.ToUpper();
			if ((sColumnName.Contains("QNT") || sColumnName.Contains("BOX")) &&
				sColumnName.Contains("RETURN") || sColumnName.Contains("ACT"))
			{
				if (dgr.Cells[sColumnName].Value == null || dgr.Cells[sColumnName].Value == DBNull.Value)
				{
					dgr.Cells[sColumnName].Value = 0;
					dgvGoods.Refresh();
					return; 
				}
			}
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
			if (cboOwner.SelectedIndex < 0 || cboOwner.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Ќе указан владелец товара...");
				cboOwner.Select();
				return;
			}
			if (cboGoodsState.SelectedIndex < 0 || cboGoodsState.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Ќе указано состо€ние товара...");
				cboGoodsState.Select();
				return;
			}

			bool bActFound = false, bReturnFound = false;
			foreach (DataRow dr in dt.Rows)
			{
				if ((decimal)dr["ActQnt"] != 0) 
					bActFound = true;
				if ((decimal)dr["ReturnQnt"] > 0)
					bReturnFound = true;
				if (bActFound && bReturnFound)
					break; 
			}
			if (!bActFound && !bReturnFound)
			{
                RFMMessage.MessageBoxError("Ќи дл€ одного товара не введено количество ни дл€ актировани€, ни дл€ возврата...");
				return;
			}

			// ¬ќ«¬–ј“
			if (bReturnFound)
			{
				if (RFMMessage.MessageBoxYesNo("—охранить возврат дл€ рейса?") == DialogResult.Yes)
				{
					// заполним таблицу товаров в возврате
					oTripReturn.FillTableTripsReturnsGoods(0);
					if (oTripReturn.ErrorNumber == 0 && oTripReturn.TableTripsReturnsGoods != null)
					{
						oTripReturn.TableTripsReturnsGoods.PrimaryKey = null;
						oTripReturn.TableTripsReturnsGoods.Columns["ID"].AllowDBNull = true;
						oTripReturn.TableTripsReturnsGoods.Columns["ID"].Unique = false;

						oTripReturn.TableTripsReturnsGoods.PrimaryKey = new DataColumn[] { oTripReturn.TableTripsReturnsGoods.Columns["PackingID"] };
						oTripReturn.TableTripsReturnsGoods.Columns["PackingID"].DefaultValue = 0;

						foreach (DataRow r in dt.Rows)
						{
							if ((decimal)r["ReturnQnt"] > 0)
							{
								DataRow rg = oTripReturn.TableTripsReturnsGoods.Rows.Find((int)r["PackingID"]);
								if (rg == null)
								{
									rg = oTripReturn.TableTripsReturnsGoods.Rows.Add();
									rg["PackingID"] = (int)r["PackingID"];
									rg["QntWished"] = (decimal)r["ReturnQnt"];
								}
								else
								{
									rg["QntWished"] = (decimal)rg["QntWished"] + (decimal)r["ReturnQnt"];
								}
							}
						}
					}
					oTripReturn.ClearError();
					// остальные параметры возврата
					oTripReturn.ID = null;
					oTripReturn.DateReturn = dtpDate.Value.Date;
					oTripReturn.GoodStateID = (int)cboGoodsState.SelectedValue;
					oTripReturn.OwnerID = (int)cboOwner.SelectedValue;
					oTripReturn.Note = txtReturnNote.Text.Trim();
					oTripReturn.AutoCreated = true; 
					oTripReturn.TripID = nTripID;
					oTripReturn.HostID = nHostID;
					// сохран€ем возврат
					WaitOn(this);
					oTripReturn.ClearError();
					bool bResult = oTripReturn.Save(((RFMFormMain)Application.OpenForms[0]).UserID);
					WaitOff(this);
					if (bResult && oTripReturn.ErrorNumber == 0 && oTripReturn.ID.HasValue)
					{
						// готов к передаче в WMS
						if (chkReturnReadyForWMS.Checked)
						{
							oTripReturn.SetReadyForWMS((int)oTripReturn.ID);
							if (oTripReturn.ErrorNumber == 0)
							{
								// печать
								LogService.TripReturnBill_Print(oTripReturn, this);
							}
						}
					}
				}
			}

			// ј “(џ)
			if (bActFound)
			{
				// посчитать, сколько получаетс€ актов дл€ разных заданий на расход 
				DataView dv = new DataView(dt, "ActQnt <> 0", "", DataViewRowState.CurrentRows);
				// таблица кодов заданий на расход, к которым можно приделать акт
				DataTable dtOutput = dv.ToTable(true, "OutputID");

                // Ќе задаем никаких вопросов
                if (1 == 1)
				//if (RFMMessage.MessageBoxYesNo("—охранить " + RFMUtilities.Declen(dtOutput.Rows.Count, "акт", "акта", "актов") + " дл€ заданий на расход, прикрепленных к рейсу?") == DialogResult.Yes)
				{
					// идем по каждому расходу
					foreach (DataRow o in dtOutput.Rows)
					{ 
						// расход, к которому будет прив€зан акт
						int nOutputID = 0;
						if (!Convert.IsDBNull(o["OutputID"]) && o["OutputID"] != null && 
							(int)o["OutputID"] > 0)
						{
							nOutputID = (int)o["OutputID"];
						}
						else
						{
							// выберем первый попавшийс€ из расходов
							oTrip.FillTableOutputsInTrip();
							if (oTrip.ErrorNumber == 0 && oTrip.TableOutputsInTrip != null &&
								oTrip.TableOutputsInTrip.Rows.Count > 0)
							{
								nOutputID = (int)oTrip.TableOutputsInTrip.Rows[0]["ID"];
							}
						}
						// заполним таблицу товаров в акте - именно дл€ этого расхода
						oAct.FillTableActsGoods(0);
						if (oAct.ErrorNumber == 0 && oAct.TableActsGoods != null)
						{
							oAct.TableActsGoods.PrimaryKey = null;
							oAct.TableActsGoods.Columns["ID"].AllowDBNull = true;
							oAct.TableActsGoods.Columns["ID"].Unique = false;
							
							foreach (DataRow r in dt.Rows)
							{
                                // »зменение от 15.05.2017 јлександров
                                // ”брана излишн€€ проверка, 
                                // не давала создавать акты при откате оператором ранее подтвержденного расходного документа
								/*if ((nOutputID == 0 && (Convert.IsDBNull(r["OutputID"]) || r["OutputID"] == null || (int)r["OutputID"] <= 0)) 
									||
									(nOutputID != 0 && (!Convert.IsDBNull(r["OutputID"]) && r["OutputID"] != null) && (int)r["OutputID"] == nOutputID))
								{*/
									if ((decimal)r["ActQnt"] != 0)
									{
										DataRow ag = oAct.TableActsGoods.Rows.Add();
										ag["PackingID"] = (int)r["PackingID"];
										ag["QntConfirmed"] = (decimal)r["ActQnt"];
									}
								/*}*/
							}
						}
						oAct.ClearError();
						// остальные параметры акта 
						oAct.ID = null;
						oAct.DateAct = dtpDate.Value.Date;
						oAct.GoodStateID = (int)cboGoodsState.SelectedValue;
						oAct.OwnerID = (int)cboOwner.SelectedValue;
						oAct.Note = txtActNote.Text.Trim();
						oAct.TripID = nTripID;
						if (nOutputID > 0)
							oAct.OutputID = nOutputID;
						else
							oAct.OutputID = null;
						oAct.InputID = null;
						oAct.HostID = nHostID;

						// сохран€ем акт
						WaitOn(this);
						oAct.ClearError();
						bool bResult = oAct.Save(((RFMFormMain)Application.OpenForms[0]).UserID);
						WaitOff(this);
						if (bResult && oAct.ErrorNumber == 0 && oAct.ID.HasValue)
						{
							// готов к передаче в WMS
							if (chkActReadyForWMS.Checked) 
							{
								//oAct.SetReadyForWMS((int)oAct.ID); // он уже Confirmed
							}
						}
					}
				}
			}

			DialogResult = DialogResult.Yes;
			Dispose();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_SelectedPackingID = null;
			if (StartForm(new frmSelectOnePacking(this, false, null, nHostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingID != null)
				{
					// проверить, нет ли уже такой строки
					foreach (DataRow r in dt.Rows)
					{
						if (Convert.ToInt32(r["PackingID"]) == _SelectedPackingID)
						{
							dgvGoods.GridSource.Position = dgvGoods.GridSource.Find("PackingID", _SelectedPackingID);
							if (dgvGoods.GridSource.Position < 0)
							{
								dgvGoods.GridSource.MoveFirst();
							}
							return;
						}
					}
		
					oGood.PackingID = _SelectedPackingID;
					oGood.FillData();
					// выбранный товар
					DataRow rg = oGood.MainTable.Rows[0];
					// добавл€ем новую строку дл€ выбранного товара
					DataRow dr = dt.Rows.Add(-1, -1);
					dr["PackingID"] = _SelectedPackingID;
					dr["GoodID"] = rg["GoodID"];
					dr["ReturnQnt"] =
					dr["ReturnBox"] =
					dr["ActQnt"] =
					dr["ActBox"] =
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
					dr["Weighting"] = rg["Weighting"];

					dr["OutputID"] = 0;

					// и встаем на эту строку
					dgvGoods.GridSource.Position = dgvGoods.GridSource.Find("PackingID", _SelectedPackingID);
					if (dgvGoods.GridSource.Position < 0)
					{
						dgvGoods.GridSource.MoveFirst();
					}
					// встать на найденную строку, в €чейку " оробок заказ"
					dgvGoods.CurrentCell = dgvGoods.Rows[dgvGoods.GridSource.Position].Cells["dgvcReturnBox"];
					dgvGoods.Select();
				}
				_SelectedPackingID = null;
			}
		}

		private void CalcTotal()
		{
			decimal nReturnQnt = 0, nReturnBox = 0,
					nActQnt = 0, nActBox = 0;
			foreach (DataRow r in dt.Rows)
			{
				nReturnQnt += (decimal)r["ReturnQnt"];
				nReturnBox += (decimal)r["ReturnBox"];
				nActQnt += (decimal)r["ActQnt"];
				nActBox += (decimal)r["ActBox"];
			}
			lblReturnTotalQnt.Text = nReturnQnt.ToString("### ### ##0").Trim();
			lblReturnTotalBox.Text = nReturnBox.ToString("# ### ##0.0").Trim();
			lblActTotalQnt.Text = nActQnt.ToString("### ### ##0").Trim();
			lblActTotalBox.Text = nActBox.ToString("# ### ##0.0").Trim();
		}

		private void frmTripsReturnsActsCreate_KeyDown(object sender, KeyEventArgs e)
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
