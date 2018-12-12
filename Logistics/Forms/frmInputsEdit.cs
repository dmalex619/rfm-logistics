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
	public partial class frmInputsEdit : RFMFormChild
	{
		private int nInputID;
		private Input oInput;

		private GoodState oGoodState;
		private Partner oOwner;

		protected Good oGood;
		protected int? nNewPackingID = null;
		protected bool bWeighting = false;
		public int? _SelectedPackingID = null;

		private int? nUserHostID = null;

		public string _SelectedPackingAliasText = null;
		public string _SelectedPackingsIDList = null;

		public int? _SelectedID = null;

		//private bool bIsEditQnt = false;
		//private bool bIsEditBox = false;


		public frmInputsEdit(int _nInputID)
		{
			nInputID = _nInputID;

			oInput = new Input();
			if (oInput.ErrorNumber != 0)
			{
				IsValid = false;
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
				oOwner = new Partner();
				if (oOwner.ErrorNumber != 0)
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

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			if (nInputID > 0 || nUserHostID.HasValue)
				PreFormName = "";
		}


		private void frmInputsEdit_Load(object sender, EventArgs e)
		{
			if (nInputID == 0)
			{
				if (!nUserHostID.HasValue)
				{
					oInput.HostID = (int)GetParamStore().GetValue(0);
					if (oInput.HostID == 0)
					{
						Close();
						return;
					}
				}
				else
					oInput.HostID = nUserHostID;
			}

			bool bResult = cboInputType_Restore() && cboGoodState_Restore() && cboCurrency_Restore();
			if (bResult)
			{
				if (nInputID != 0)
				{
					oInput.ReFillOne(nInputID);
					if (oInput.ErrorNumber != 0 || oInput.MainTable.Rows.Count == 0)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о задании на приход...");
						bResult = false;
					}

					if (nUserHostID.HasValue && (int)nUserHostID != (int)oInput.HostID)
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
						Text += " (" + nInputID.ToString() + ")";

						dtpDateInput.Value = oInput.DateInput;
						chkDeliveryNeed.Checked = oInput.DeliveryNeed;
						cboInputType.SelectedValue = oInput.InputTypeID;
						cboGoodState.SelectedValue = oInput.GoodStateID;
						cboOwner.SelectedValue = oInput.OwnerID;
						cboCurrency.SelectedValue = oInput.CurrencyID;
						ucSelectRecordIDForm_Partners.txtData.Text = oInput.PartnerName;	
						txtNote.Text = oInput.Note;

						if (!dgvInputGoods_Restore())
						{
							RFMMessage.MessageBoxError("Ошибка получения о товарах в задании на приход...");
							Dispose();
						}
					}
				}
				else
				{ 
					// новое задание
					bResult = cboOwner_Restore();

					if (bResult)
					{
						cboInputType.SelectedIndex = -1;
						cboCurrency.SelectedIndex = 0;
						cboGoodState.SelectedIndex = 0;
						cboOwner.SelectedIndex = -1;

						dgvInputGoods_Restore();
					}
				}
			}
			
			if (!bResult)
			{
				Dispose();
			}

			Host oHost = new Host();
			if (oHost.Count() > 1)
			{
				oHost.ReFillOne((int)oInput.HostID);
				Text += " [" + oHost.Name + "]";
			}

			string cColumnName = "";
			dgvInputGoods.ReadOnly = false;
			foreach (DataGridViewColumn c in dgvInputGoods.Columns)
			{
				cColumnName = c.Name.ToUpper();
				c.ReadOnly = !(cColumnName.Contains("CHECK") ||
					cColumnName.Contains("WISHED") ||
					cColumnName.Contains("PRICE"));
			}
			if (dgvInputGoods.Rows.Count > 0)
			{
				// встать на первую строку, в ячейку "Коробок заказ"
				dgvInputGoods.CurrentCell = dgvInputGoods.Rows[0].Cells["dgvcBoxWished"];
			}

		}

		#region Restore

		#region ComboBox

		private bool cboCurrency_Restore()
		{
			cboCurrency.DataSource = null;
			Currency oCurrency = new Currency();
			if (oCurrency.FillData())
			{
				cboCurrency.ValueMember = oCurrency.ColumnID;
				cboCurrency.DisplayMember = oCurrency.ColumnName;
				cboCurrency.Restore(oCurrency.MainTable);
			}
			return (oCurrency.ErrorNumber == 0);
		}

		private bool cboInputType_Restore()
		{
			cboInputType.DataSource = null;
			oInput.ClearError();
			if (oInput.FillTableInputsTypes())
			{
				cboInputType.ValueMember = "ID";
				cboInputType.DisplayMember = "Name";
				cboInputType.Restore(oInput.TableInputsTypes);
			}
			return (oInput.ErrorNumber == 0);
		}

		private bool cboGoodState_Restore()
		{
			cboGoodState.DataSource = null;
			oGoodState.ClearError();
			if (oGoodState.FillData())
			{
				cboGoodState.ValueMember = oGoodState.ColumnID;
				cboGoodState.DisplayMember = oGoodState.ColumnName;
				cboGoodState.Restore(oGoodState.MainTable);
			}
			return (oGoodState.ErrorNumber == 0);
		}

		private bool cboOwner_Restore()
		{
			cboOwner.DataSource = null;
			oOwner.ClearError();
			oOwner.FilterActual = true;
			oOwner.FilterIsOwner = true;
			if (oInput != null && oInput.HostID.HasValue)
				oOwner.FilterHostsList = oInput.HostID.ToString();
			if (oOwner.FillData())
			{
				cboOwner.ValueMember = oOwner.ColumnID;
				cboOwner.DisplayMember = oOwner.ColumnName;
				cboOwner.Restore(oOwner.MainTable);
			}
			return (oOwner.ErrorNumber == 0);
		}

		#endregion ComboBox

		#region Grid

		private bool dgvInputGoods_Restore()
		{
			oInput.ClearError();
			if (oInput.ErrorNumber == 0)
			{
				oInput.FillTableInputsGoods(nInputID);
				if (oInput.ErrorNumber == 0)
				{
					oInput.TableInputsGoods.PrimaryKey = null;
					oInput.TableInputsGoods.Columns["ID"].Unique = false;
					oInput.TableInputsGoods.Columns["ID"].AllowDBNull = true;
					oInput.TableInputsGoods.Columns["InputGoodID"].Unique = false;
					oInput.TableInputsGoods.Columns["InputGoodID"].AllowDBNull = true;
					//oInput.TableInputsGoods.Columns["InputGoodID"].DefaultValue = -1;

					decimal nQnt = 0;
					decimal nBox = 0;
					foreach (DataRow droRow in oInput.TableInputsGoods.Rows)
					{
						nQnt += (decimal)droRow["QntWished"];
						nBox += (decimal)droRow["BoxWished"];
					}
					dgvInputGoods.Restore(oInput.TableInputsGoods);
					lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
					lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
				}
			}
			return (oInput.ErrorNumber == 0);
		}

		#endregion Grid

		#region ucSelectRecordIDForm

		private void ucSelectRecordIDForm_Partners_Restore()
		{
			ucSelectRecordIDForm_Partners.SendParams = new object[] { ucSelectRecordIDForm_Partners, "", false, false, (int)oInput.HostID };
			ucSelectRecordIDForm_Partners.Restore();
		}

		#endregion ucSelectRecordIDForm
		
		#endregion

		#region GridCells

		private void dgvInputGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvInputGoods.DataSource == null || dgvInputGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvInputGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			switch (dgvInputGoods.Columns[e.ColumnIndex].Name)
			{
				case "dgvcInBox":
				case "dgvcQntWished":
					if (!Convert.IsDBNull(droRow["Weighting"]) && Convert.ToBoolean(droRow["Weighting"]) ||
						!Convert.IsDBNull(droRow["InBox"]) && Convert.ToInt32(droRow["InBox"]) != Convert.ToDecimal(droRow["InBox"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
						e.CellStyle.Format = "### ###.000";
					else
						e.CellStyle.Format = "### ###";
					break;
			}
		}

		private void dgvInputGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvInputGoods.Columns[e.ColumnIndex].Name.Contains("Qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvInputGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvInputGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvInputGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oInput.TableInputsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvInputGoods.Columns[e.ColumnIndex].Name;
			if (sColumnName == "dgvcQntWished" ||sColumnName == "dgvcBoxWished")
			{
				DataRow droRow = ((DataRowView)((DataGridViewRow)dgvInputGoods.Rows[e.RowIndex]).DataBoundItem).Row;
				if (droRow == null)
					return;

				if (sColumnName == "dgvcQntWished" || sColumnName == "dgvcBoxWished")
				{
					decimal nInbox = (decimal)droRow["InBox"];
					if (sColumnName == "dgvcQntWished")
					{
						// меняем штуки -> пересчитываем коробки
						droRow["BoxWished"] = (decimal)dgvInputGoods.Rows[e.RowIndex].Cells["dgvcQntWished"].Value / nInbox;
					}
					if (sColumnName == "dgvcBoxWished")
					{
						// меняем коробки -> пересчитываем штуки
						if ((bool)droRow["Weighting"] || (nInbox != (int)nInbox))
							droRow["QntWished"] = (decimal)dgvInputGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox;
						else
							droRow["QntWished"] = (decimal.Ceiling)(decimal.Round((decimal)dgvInputGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox, 1));
					}
				}

				dgvInputGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvInputGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow r = dgvInputGoods.Rows[e.RowIndex];
			if (dgvInputGoods.Columns[e.ColumnIndex].Name == "dgvcQntWished")
			{
				//bIsEditQnt = true;
				if (r.Cells["dgvcQntWished"].Value == null || r.Cells["dgvcQntWished"].Value == DBNull.Value)
				{
					r.Cells["dgvcQntWished"].Value = 0;
					return; 
				}
				//bIsEditQnt = false;
			}

			if (dgvInputGoods.Columns[e.ColumnIndex].Name == "dgvcBoxWished")
			{
				//bIsEditBox = false;
				if (r.Cells["dgvcBoxWished"].Value == null || r.Cells["dgvcBoxWished"].Value == DBNull.Value)
				{
					r.Cells["dgvcBoxWished"].Value = 0;
					return;
				}
				//bIsEditBox = false;
			}

			dgvInputGoods.Refresh();
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
			if (cboInputType.SelectedIndex < 0 || cboInputType.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите тип прихода!");
				cboInputType.Select();
				return;
			}

			if (cboOwner.SelectedIndex < 0 || cboOwner.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите владельца товара!");
				cboOwner.Select();
				return;
			}

			if (cboGoodState.SelectedIndex < 0 || cboGoodState.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите состояние товара!");
				cboGoodState.Select();
				return;
			}

			if (ucSelectRecordIDForm_Partners.TxtData.Text.Length == 0)
			{
				RFMMessage.MessageBoxError("Выберите поставщика товара!");
				ucSelectRecordIDForm_Partners.Select();
				return;
			}

			if (cboCurrency.SelectedIndex < 0 || cboCurrency.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите валюту!");
				cboCurrency.Select();
				return;
			}

			// хоть один товар
			bool bFound = false;
			if (oInput.TableInputsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxAttention("Не введено ни одного товара...");
				return;
			}
			else
			{				
				// хоть что-то введено
				foreach (DataRow r in oInput.TableInputsGoods.Rows)
				{
					if ((decimal)r["QntWished"] > 0 || (decimal)r["BoxWished"] > 0)
					{
						bFound = true;
						break;
					}
				}
				if (!bFound)
				{
					RFMMessage.MessageBoxAttention("Ни для одного товара не введено количество...");
					return;
				}
			}	
			if (RFMMessage.MessageBoxYesNo("Сохранить задание на приход?") == DialogResult.Yes)
			{
				// oInput.HostID присвоено на старте
				oInput.DateInput = dtpDateInput.Value.Date;
				oInput.InputTypeID = (int)cboInputType.SelectedValue;
				oInput.GoodStateID = (int)cboGoodState.SelectedValue;
				oInput.OwnerID = (int)cboOwner.SelectedValue;
				oInput.CurrencyID = (int)cboCurrency.SelectedValue;
				oInput.DeliveryNeed = chkDeliveryNeed.Checked; 
				oInput.Note = txtNote.Text.Trim();
				if (ucSelectRecordIDForm_Partners.txtData.Text != oInput.PartnerName)	
					oInput.PartnerID = Convert.ToInt16(ucSelectRecordIDForm_Partners.GetIdString());

				// добрались. сохраняем.
				Refresh();
				WaitOn(this);
				oInput.ClearError();
				bool bResult = oInput.Save();
				WaitOff(this);
				if (bResult && oInput.ErrorNumber == 0)
				{
					RFMMessage.MessageBoxInfo("Задание на приход сохранено.");
					MotherForm.GotParam = new object[] { (int)oInput.ID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_SelectedPackingsIDList = null;
			int? nNewFirstPackingID = null;
			int? nNewPackingID = null;
			
			if (StartForm(new frmSelectOnePacking(this, true, null, oInput.HostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingsIDList != null)
				{
					// идем по каждому выбранному товару
					Good oGoodNew = new Good();
					oGoodNew.PackingsIDList = _SelectedPackingsIDList;
					oGoodNew.FillData();
					if (oGoodNew.ErrorNumber == 0 && oGoodNew.MainTable != null &&
						oGoodNew.MainTable.Rows.Count > 0)
					{
						foreach (DataRow rGNew in oGoodNew.MainTable.Rows)
						{
							nNewPackingID = Convert.ToInt32(rGNew["PackingID"]);
							bool bFound = false;
							// проверить, нет ли уже такой строки
							foreach (DataRow r in oInput.TableInputsGoods.Rows)
							{
								if (Convert.ToInt32(r["PackingID"]) == nNewPackingID)
								{
									bFound = true;
									break;
								}
							}
							if (bFound)
							{
								// такой товар уже есть - переходим к след.отмеченному товару
								continue;
							}

							// добавляем новую строку для выбранного товара
							DataRow dr = oInput.TableInputsGoods.Rows.Add(-1, -1);
							dr["InputID"] = nInputID;
							dr["PackingID"] = nNewPackingID;
							dr["GoodID"] = rGNew["GoodID"];
							dr["QntWished"] =
							dr["BoxWished"] =
							dr["Price"] =
								0;
							dr["GoodName"] = rGNew["GoodName"];
							dr["GoodAlias"] = rGNew["GoodAlias"];
							dr["PackingAlias"] = rGNew["PackingAlias"];
							dr["GoodBarCode"] = rGNew["GoodBarCode"];
							dr["GoodGroupName"] = rGNew["GoodGroupName"];
							dr["GoodBrandName"] = rGNew["GoodBrandName"];
							dr["InBox"] = rGNew["InBox"];
							dr["BoxInPal"] = rGNew["BoxInPal"];
							dr["Weighting"] = rGNew["Weighting"];

							if (!nNewFirstPackingID.HasValue)
								nNewFirstPackingID = nNewPackingID;
						}

						// встать на последнюю найденную строку, в ячейку "Коробок зак."
						if (nNewFirstPackingID.HasValue)
						{
							dgvInputGoods.GridSource.Position = dgvInputGoods.GridSource.Find("PackingID", nNewFirstPackingID);
							if (dgvInputGoods.GridSource.Position < 0)
							{
								dgvInputGoods.GridSource.MoveFirst();
							}
							// встать на найденную строку, в ячейку "Коробок зак."
							dgvInputGoods.CurrentCell = dgvInputGoods.Rows[dgvInputGoods.GridSource.Position].Cells["dgvcBoxWished"];
							dgvInputGoods.Select();
							dgvInputGoods.Rows[dgvInputGoods.GridSource.Position].Cells["dgvcBoxWished"].Selected = true;
						}
					}
				}
				_SelectedPackingsIDList = null;
				_SelectedPackingAliasText = null;
			}
		}

		private void CalcTotal()
		{
			decimal nQnt = 0;
			decimal nBox = 0;
			foreach (DataRow r in oInput.TableInputsGoods.Rows)
			{
				nQnt += (decimal)r["QntWished"];
				nBox += (decimal)r["BoxWished"];
			}
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
		}

		private void frmInputsEdit_KeyDown(object sender, KeyEventArgs e)
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
