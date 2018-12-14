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
	public partial class frmMovingsDocumentsEdit : RFMFormChild
	{
		private int nMovingDocumentID;
		private MovingDocument oMovingDocument;

		private GoodState oGoodStateSource, oGoodStateTarget;
		private Partner oOwnerSource, oOwnerTarget;

		protected Good oGood;
		protected int? nNewPackingID = null;
		protected bool bWeighting = false;
		public int? _SelectedPackingID = null;

		private int? nUserHostID = null;

		public string _SelectedPackingAliasText = null;
		public string _SelectedPackingsIDList = null;

		public int? _SelectedID = null;


		public frmMovingsDocumentsEdit(int _nMovingDocumentID)
		{
			nMovingDocumentID = _nMovingDocumentID;

			oMovingDocument = new MovingDocument();
			if (oMovingDocument.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oGoodStateSource = new GoodState();
				oGoodStateTarget = new GoodState();
				if (oGoodStateSource.ErrorNumber != 0 ||
					oGoodStateTarget.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oOwnerSource = new Partner();
				oOwnerTarget = new Partner();
				if (oOwnerSource.ErrorNumber != 0 || 
					oOwnerTarget.ErrorNumber != 0) 
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

			if (nMovingDocumentID > 0 || nUserHostID.HasValue)
				PreFormName = "";
		}


		private void frmMovingsDocumentsEdit_Load(object sender, EventArgs e)
		{
			if (nMovingDocumentID == 0)
			{
				if (!nUserHostID.HasValue)
				{
					oMovingDocument.HostID = (int)GetParamStore().GetValue(0);
					if (oMovingDocument.HostID == 0)
					{
						Close();
						return;
					}
				}
				else 
					oMovingDocument.HostID = nUserHostID;  
			}

			bool bResult = cboGoodStateSource_Restore() && cboGoodStateTarget_Restore() && cboCurrency_Restore();

			if (nMovingDocumentID != 0)
			{
				oMovingDocument.ReFillOne(nMovingDocumentID);
				if (oMovingDocument.ErrorNumber != 0 || oMovingDocument.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о документарном перемещении...");
					bResult = false;
				}

				if (nUserHostID.HasValue && (int)nUserHostID != (int)oMovingDocument.HostID)
				{
					RFMMessage.MessageBoxError("Несовпадение прав доступа к данным хоста...");
					bResult = false;
				}

				if (bResult)
				{
					bResult = cboOwnerSource_Restore() && cboOwnerTarget_Restore();
				}

				if (bResult)
				{
					Text += " (" + nMovingDocumentID.ToString() + ")";

					dtpDateMovingDocument.Value = oMovingDocument.DateMoving;
					txtBillNumber.Text = oMovingDocument.BillNumber.Trim();
					cboGoodStateSource.SelectedValue = oMovingDocument.GoodStateSourceID;
					cboGoodStateTarget.SelectedValue = oMovingDocument.GoodStateTargetID;
					cboOwnerSource.SelectedValue = oMovingDocument.OwnerSourceID;
					cboOwnerTarget.SelectedValue = oMovingDocument.OwnerTargetID;
					// cboOwner*.SelectedValueChange
					cboPartnerDetailSource.SelectedValue = oMovingDocument.PartnerDetailSourceID;
					cboPartnerDetailTarget.SelectedValue = oMovingDocument.PartnerDetailTargetID;
					cboCurrency.SelectedValue = oMovingDocument.CurrencyID;
					txtNote.Text = oMovingDocument.Note;

					if (oMovingDocument.GoodStateSourceID != oMovingDocument.GoodStateTargetID)
					{
						radGoodStates.Checked = true;
					}
					else
					{
						radOwners.Checked = true;
					}

					if (!dgvMovingDocumentGoods_Restore())
					{
						RFMMessage.MessageBoxError("Ошибка получения о товарах в документарном перемещении...");
						Dispose();
					}
				}
			}
			else
			{ 
				// новый документ
				bResult = cboOwnerSource_Restore() && cboOwnerTarget_Restore();

				if (bResult)
				{
					cboCurrency.SelectedIndex = 0;
					cboGoodStateSource.SelectedIndex =
					cboGoodStateTarget.SelectedIndex = 0;
					cboOwnerSource.SelectedIndex =
					cboOwnerTarget.SelectedIndex =
					cboPartnerDetailSource.SelectedIndex =
					cboPartnerDetailTarget.SelectedIndex =
						-1;
					radOwners.Checked = true;
					radGoodStates.Checked = false;
					dgvMovingDocumentGoods_Restore();
				}
			}
			
			if (!bResult)
			{
				Dispose();
			}

			Host oHost = new Host();
			if (oHost.Count() > 1)
			{
				oHost.ReFillOne((int)oMovingDocument.HostID);
				Text += " [" + oHost.Name + "]";
			}

			string cColumnName = "";
			dgvMovingDocumentGoods.ReadOnly = false;
			foreach (DataGridViewColumn c in dgvMovingDocumentGoods.Columns)
			{
				cColumnName = c.Name.ToUpper();
				c.ReadOnly = !(cColumnName.Contains("CHECK") ||
					cColumnName.Contains("WISHED") ||
					cColumnName.Contains("PRICE"));
			}
			if (dgvMovingDocumentGoods.Rows.Count > 0)
			{
				// встать на первую строку, в ячейку "Коробок заказ"
				dgvMovingDocumentGoods.CurrentCell = dgvMovingDocumentGoods.Rows[0].Cells["dgvcBoxWished"];
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

		private bool cboGoodStateSource_Restore()
		{
			cboGoodStateSource.DataSource = null;
			if (Utilities.FillData_GoodsStates(oGoodStateSource))
			{
				cboGoodStateSource.ValueMember = oGoodStateSource.ColumnID;
				cboGoodStateSource.DisplayMember = oGoodStateSource.ColumnName;
				cboGoodStateSource.Restore(oGoodStateSource.MainTable);
			}
			return (oGoodStateSource.ErrorNumber == 0);
		}

		private bool cboGoodStateTarget_Restore()
		{
			cboGoodStateTarget.DataSource = null;
			if (Utilities.FillData_GoodsStates(oGoodStateTarget))
			{
				cboGoodStateTarget.ValueMember = oGoodStateTarget.ColumnID;
				cboGoodStateTarget.DisplayMember = oGoodStateTarget.ColumnName;
				cboGoodStateTarget.Restore(oGoodStateTarget.MainTable);
			}
			return (oGoodStateTarget.ErrorNumber == 0);
		}

		private bool cboOwnerSource_Restore()
		{
			cboOwnerSource.DataSource = null;
			oOwnerSource.FilterActual = true;
			oOwnerSource.FilterIsOwner = true;
			if (oMovingDocument != null && oMovingDocument.HostID.HasValue) 
				oOwnerSource.FilterHostsList = oMovingDocument.HostID.ToString();
			if (Utilities.FillData_Owners(oOwnerSource))
			{
				cboOwnerSource.ValueMember = oOwnerSource.ColumnID;
				cboOwnerSource.DisplayMember = oOwnerSource.ColumnName;
				cboOwnerSource.Restore(oOwnerSource.MainTable);
			}
			return (oOwnerSource.ErrorNumber == 0);
		}

		private bool cboOwnerTarget_Restore()
		{
			cboOwnerTarget.DataSource = null;
			oOwnerTarget.FilterActual = true;
			oOwnerTarget.FilterIsOwner = true;
			if (oMovingDocument != null && oMovingDocument.HostID.HasValue)
				oOwnerTarget.FilterHostsList = oMovingDocument.HostID.ToString();
			if (Utilities.FillData_Owners(oOwnerTarget))
			{
				cboOwnerTarget.ValueMember = oOwnerTarget.ColumnID;
				cboOwnerTarget.DisplayMember = oOwnerTarget.ColumnName;
				cboOwnerTarget.Restore(oOwnerTarget.MainTable);
			}
			return (oOwnerTarget.ErrorNumber == 0);
		}

		private void cboOwnerSource_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboPartnerDetailSource_Restore();
		}

		private void cboOwnerTarget_SelectedIndexChanged(object sender, EventArgs e)
		{
			cboPartnerDetailTarget_Restore();
		}

		private bool cboPartnerDetailSource_Restore()
		{
			cboPartnerDetailSource.DataSource = null;
			if ((cboOwnerSource.SelectedValue != null && cboOwnerSource.SelectedIndex >= 0) &&
				Utilities.FillData_PartnersDetails(oOwnerSource, (int)cboOwnerSource.SelectedValue))
			{
				cboPartnerDetailSource.ValueMember = "ID";
				cboPartnerDetailSource.DisplayMember = "FactName";
				cboPartnerDetailSource.Restore(oOwnerSource.TablePartnersDetails);
			}
			return (oOwnerSource.ErrorNumber == 0);
		}

		private bool cboPartnerDetailTarget_Restore()
		{
			cboPartnerDetailTarget.DataSource = null;
			if ((cboOwnerTarget.SelectedValue != null && cboOwnerTarget.SelectedIndex >= 0) &&
				Utilities.FillData_PartnersDetails(oOwnerTarget, (int)cboOwnerTarget.SelectedValue))
			{
				cboPartnerDetailTarget.ValueMember = "ID";
				cboPartnerDetailTarget.DisplayMember = "FactName";
				cboPartnerDetailTarget.Restore(oOwnerTarget.TablePartnersDetails);
			}
			return (oOwnerTarget.ErrorNumber == 0);
		}

		#endregion ComboBox

		#region Grid

		private bool dgvMovingDocumentGoods_Restore()
		{
			oMovingDocument.ClearError();
			if (oMovingDocument.ErrorNumber == 0)
			{
				oMovingDocument.FillTableMovingsDocumentsGoods(nMovingDocumentID);
				if (oMovingDocument.ErrorNumber == 0)
				{
					oMovingDocument.TableMovingsDocumentsGoods.PrimaryKey = null;
					oMovingDocument.TableMovingsDocumentsGoods.Columns["ID"].Unique = false;
					oMovingDocument.TableMovingsDocumentsGoods.Columns["ID"].AllowDBNull = true;
					oMovingDocument.TableMovingsDocumentsGoods.Columns["MovingDocumentGoodID"].Unique = false;
					oMovingDocument.TableMovingsDocumentsGoods.Columns["MovingDocumentGoodID"].AllowDBNull = true;

					decimal nQnt = 0;
					decimal nBox = 0;
					foreach (DataRow droRow in oMovingDocument.TableMovingsDocumentsGoods.Rows)
					{
						nQnt += (decimal)droRow["QntWished"];
						nBox += (decimal)droRow["BoxWished"];
					}
					dgvMovingDocumentGoods.Restore(oMovingDocument.TableMovingsDocumentsGoods);
					lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
					lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
				}
			}
			return (oMovingDocument.ErrorNumber == 0);
		}

		#endregion Grid

		#endregion

		#region GridCells

		private void dgvMovingDocumentGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvMovingDocumentGoods.DataSource == null || dgvMovingDocumentGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvMovingDocumentGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			switch (dgvMovingDocumentGoods.Columns[e.ColumnIndex].Name)
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

		private void dgvMovingDocumentGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvMovingDocumentGoods.Columns[e.ColumnIndex].Name.Contains("Qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvMovingDocumentGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvMovingDocumentGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvMovingDocumentGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oMovingDocument.TableMovingsDocumentsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvMovingDocumentGoods.Columns[e.ColumnIndex].Name;
			if (sColumnName == "dgvcQntWished" ||sColumnName == "dgvcBoxWished")
			{
				DataRow droRow = ((DataRowView)((DataGridViewRow)dgvMovingDocumentGoods.Rows[e.RowIndex]).DataBoundItem).Row;
				if (droRow == null)
					return;

				if (sColumnName == "dgvcQntWished" || sColumnName == "dgvcBoxWished")
				{
					decimal nInbox = (decimal)droRow["InBox"];
					if (sColumnName == "dgvcQntWished")
					{
						// меняем штуки -> пересчитываем коробки
						droRow["BoxWished"] = (decimal)dgvMovingDocumentGoods.Rows[e.RowIndex].Cells["dgvcQntWished"].Value / nInbox;
					}
					if (sColumnName == "dgvcBoxWished")
					{
						// меняем коробки -> пересчитываем штуки
						if ((bool)droRow["Weighting"] || (nInbox != (int)nInbox))
							droRow["QntWished"] = (decimal)dgvMovingDocumentGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox;
						else
							droRow["QntWished"] = (decimal.Ceiling)(decimal.Round((decimal)dgvMovingDocumentGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox, 1));
					}
				}

				dgvMovingDocumentGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvMovingDocumentGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow r = dgvMovingDocumentGoods.Rows[e.RowIndex];
			if (dgvMovingDocumentGoods.Columns[e.ColumnIndex].Name == "dgvcQntWished")
			{
				//bIsEditQnt = true;
				if (r.Cells["dgvcQntWished"].Value == null || r.Cells["dgvcQntWished"].Value == DBNull.Value)
				{
					r.Cells["dgvcQntWished"].Value = 0;
					return; 
				}
				//bIsEditQnt = false;
			}

			if (dgvMovingDocumentGoods.Columns[e.ColumnIndex].Name == "dgvcBoxWished")
			{
				//bIsEditBox = false;
				if (r.Cells["dgvcBoxWished"].Value == null || r.Cells["dgvcBoxWished"].Value == DBNull.Value)
				{
					r.Cells["dgvcBoxWished"].Value = 0;
					return;
				}
				//bIsEditBox = false;
			}

			dgvMovingDocumentGoods.Refresh();
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
			if (cboOwnerSource.SelectedIndex < 0 || cboOwnerSource.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите исходного владельца товара!");
				cboOwnerSource.Select();
				return;
			}
			if (cboOwnerTarget.SelectedIndex < 0 || cboOwnerTarget.SelectedValue == null)
			{
				if (cboOwnerTarget.Enabled)
				{
					RFMMessage.MessageBoxError("Выберите конечного владельца товара!");
					cboOwnerSource.Select();
					return;
				}
				else
				{
					cboOwnerTarget.SelectedValue = cboOwnerSource.SelectedValue;
				}
			}
			if (cboPartnerDetailSource.SelectedValue == null || cboPartnerDetailSource.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Выберите реквизиты исходного владельца товара!");
				cboPartnerDetailSource.Select();
				return;
			}
			if (cboPartnerDetailSource.SelectedValue == null || cboPartnerDetailSource.SelectedIndex < 0)
			{
				if (cboOwnerTarget.Enabled)
				{
					RFMMessage.MessageBoxError("Выберите реквизиты конечного владельца товара!");
					cboPartnerDetailTarget.Select();
					return;
				}
				else
					cboPartnerDetailTarget.SelectedValue = cboPartnerDetailSource.SelectedValue;
			}

			if (radOwners.Checked && ((int)cboPartnerDetailSource.SelectedValue == (int)cboPartnerDetailTarget.SelectedValue))	
			{
				RFMMessage.MessageBoxError("Выберите несовпадающих владельцев/реквизиты!");
				cboPartnerDetailTarget.Select();
				return;
			}	

			if (cboGoodStateSource.SelectedIndex < 0 || cboGoodStateSource.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите исходное состояние товара!");
				cboGoodStateSource.Select();
				return;
			}
			if (cboGoodStateTarget.SelectedIndex < 0 || cboGoodStateTarget.SelectedValue == null)
			{
				if (cboGoodStateTarget.Enabled)
				{
					RFMMessage.MessageBoxError("Выберите конечное состояние товара!");
					cboGoodStateTarget.Select();
					return;
				}
				else
				{
					cboGoodStateTarget.SelectedValue = cboGoodStateSource.SelectedValue; 
				}
			}
			if (radGoodStates.Checked && ((int)cboGoodStateSource.SelectedValue == (int)cboGoodStateTarget.SelectedValue))
			{
				RFMMessage.MessageBoxError("Выберите несовпадающие состояния товара!");
				cboGoodStateTarget.Select();
				return;
			}

			if (cboCurrency.SelectedIndex < 0 || cboCurrency.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите валюту!");
				cboCurrency.Select();
				return;
			}

			if (txtBillNumber.Text.Length == 0 &&
				RFMMessage.MessageBoxYesNo("Не указан номер документа.\nВсе равно сохранить?") == DialogResult.No)
			{
				txtBillNumber.Select();
				return;
			}

			// хоть один товар
			if (oMovingDocument.TableMovingsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxAttention("Не введено ни одного товара...");
				return;
			}
			else
			{	
				// хоть что-то введено
				bool bFound = false;
				foreach (DataRow r in oMovingDocument.TableMovingsDocumentsGoods.Rows)
				{
					if ((decimal)r["QntWished"] > 0 || (decimal)r["BoxWished"] > 0)
					{
						bFound = true;
						break;
					}
				}
				if (!bFound)
				{
					RFMMessage.MessageBoxYesNo("Ни для одного товара не введено количество...");
					return;
				}
			}
			if (RFMMessage.MessageBoxYesNo("Сохранить документарное перемещение?") == DialogResult.Yes)
			{
				oMovingDocument.DateMoving = dtpDateMovingDocument.Value.Date;
				oMovingDocument.GoodStateSourceID = (int)cboGoodStateSource.SelectedValue;
				oMovingDocument.GoodStateTargetID = (int)cboGoodStateTarget.SelectedValue;
				oMovingDocument.OwnerSourceID = (int)cboOwnerSource.SelectedValue;
				oMovingDocument.OwnerTargetID = (int)cboOwnerTarget.SelectedValue;
				oMovingDocument.CurrencyID = (int)cboCurrency.SelectedValue;
				oMovingDocument.PartnerDetailSourceID = (int)cboPartnerDetailSource.SelectedValue;
				oMovingDocument.PartnerDetailTargetID = (int)cboPartnerDetailTarget.SelectedValue;
				oMovingDocument.Note = txtNote.Text.Trim();
				oMovingDocument.BillNumber = txtBillNumber.Text.Trim();

				// добрались. сохраняем.
				Refresh();
				WaitOn(this);
				oMovingDocument.ClearError();
				bool bResult = oMovingDocument.Save();
				WaitOff(this);
				if (bResult && oMovingDocument.ErrorNumber == 0)
				{
					RFMMessage.MessageBoxInfo("Документарное перемещение сохранено.");
					MotherForm.GotParam = new object[] { (int)oMovingDocument.ID };
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
			
			if (StartForm(new frmSelectOnePacking(this, true, null, oMovingDocument.HostID)) == DialogResult.Yes)
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
							foreach (DataRow r in oMovingDocument.TableMovingsDocumentsGoods.Rows)
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
							DataRow dr = oMovingDocument.TableMovingsDocumentsGoods.Rows.Add(-1, -1);
							if (nMovingDocumentID !=0)
								dr["MovingDocumentID"] = (int)oMovingDocument.ID;
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
							dgvMovingDocumentGoods.GridSource.Position = dgvMovingDocumentGoods.GridSource.Find("PackingID", nNewFirstPackingID);
							if (dgvMovingDocumentGoods.GridSource.Position < 0)
							{
								dgvMovingDocumentGoods.GridSource.MoveFirst();
							}
							// встать на найденную строку, в ячейку "Коробок зак."
							dgvMovingDocumentGoods.CurrentCell = dgvMovingDocumentGoods.Rows[dgvMovingDocumentGoods.GridSource.Position].Cells["dgvcBoxWished"];
							dgvMovingDocumentGoods.Select();
							dgvMovingDocumentGoods.Rows[dgvMovingDocumentGoods.GridSource.Position].Cells["dgvcBoxWished"].Selected = true;
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
			foreach (DataRow r in oMovingDocument.TableMovingsDocumentsGoods.Rows)
			{
				nQnt += (decimal)r["QntWished"];
				nBox += (decimal)r["BoxWished"];
			}
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
		}

		private void frmMovingsDocumentsEdit_KeyDown(object sender, KeyEventArgs e)
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

		#region Radio buttons

		private void radOwners_CheckedChanged(object sender, EventArgs e)
		{
//			radGoodStates.Checked = !radOwners.Checked;
			if (radOwners.Checked)
			{
				cboGoodStateTarget.SelectedValue = cboGoodStateSource.SelectedValue;
				cboGoodStateTarget.Enabled = false;
				cboOwnerTarget.Enabled = cboPartnerDetailTarget.Enabled = true;
			}

		}

		private void radGoodStates_CheckedChanged(object sender, EventArgs e)
		{
//			radOwners.Checked = !radGoodStates.Checked;
			if (radGoodStates.Checked)
			{
				if (cboOwnerSource.SelectedValue != null)
					cboOwnerTarget.SelectedValue = cboOwnerSource.SelectedValue;
				cboPartnerDetailTarget.SelectedValue = cboPartnerDetailSource.SelectedValue;
				cboGoodStateTarget.Enabled = true;
				cboOwnerTarget.Enabled = cboPartnerDetailTarget.Enabled = false;
			}	
		}

		#endregion Radio buttons

	
	}
}
