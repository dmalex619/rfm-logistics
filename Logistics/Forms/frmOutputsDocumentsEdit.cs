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
	public partial class frmOutputsDocumentsEdit : RFMFormChild
	{
		private int nOutputDocumentID;
		private OutputDocument oOutputDocument;

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

		public frmOutputsDocumentsEdit(int _nOutputDocumentID)
		{
			nOutputDocumentID = _nOutputDocumentID;

			oOutputDocument = new OutputDocument();
			if (oOutputDocument.ErrorNumber != 0)
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

			if (nOutputDocumentID > 0 || nUserHostID.HasValue)
				PreFormName = "";
		}


		private void frmOutputsDocumentsEdit_Load(object sender, EventArgs e)
		{
			if (nOutputDocumentID == 0)
			{
				if (!nUserHostID.HasValue)
				{
					oOutputDocument.HostID = (int)GetParamStore().GetValue(0);
					if (oOutputDocument.HostID == 0)
					{
						Close();
						return;
					}
				}
				else
					oOutputDocument.HostID = nUserHostID; 
			}

			lblTotalQnt.Text =
			lblTotalBox.Text =
				"";

			bool bResult = cboOutputDocumentType_Restore() && cboGoodState_Restore() && cboCurrency_Restore(); 
			if (bResult)
			{
				if (nOutputDocumentID != 0)
				{
					oOutputDocument.ReFillOne(nOutputDocumentID);
					if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable.Rows.Count == 0)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о расходном документе...");
						bResult = false;
					}

					if (nUserHostID.HasValue && (int)nUserHostID != (int)oOutputDocument.HostID)
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
						Text += " (" + nOutputDocumentID.ToString() + ")";

						dtpDateOutputDocument.Value = oOutputDocument.DateOutput;
						txtBillNumber.Text = oOutputDocument.BillNumber.Trim();
						cboOutputDocumentType.SelectedValue = oOutputDocument.OutputDocumentTypeID;
						cboGoodState.SelectedValue = oOutputDocument.GoodStateID;
						cboOwner.SelectedValue = oOutputDocument.OwnerID;
						cboCurrency.SelectedValue = oOutputDocument.CurrencyID;
						ucSelectRecordIDForm_Salers.TxtData.Text = oOutputDocument.PartnerSalerFactName;
						ucSelectRecordIDForm_Shippers.TxtData.Text = oOutputDocument.PartnerShipperFactName;
						ucSelectRecordIDForm_Buyers.TxtData.Text = oOutputDocument.PartnerBayerFactName;
						txtNote.Text = oOutputDocument.Note;
						chkDeliveryNeed.Checked = oOutputDocument.DeliveryNeed;
						chkBillNeed.Checked = oOutputDocument.PF_BillNeed;
						txtBillNumber.Text = oOutputDocument.BillNumber.Trim();
						txtBillNumber.Enabled = chkBillNeed.Checked;  
						chkFactureNeed.Checked = oOutputDocument.PF_FactureNeed;
						txtFactureNumber.Text = oOutputDocument.FactureNumber.Trim();
						txtFactureNumber.Enabled = chkFactureNeed.Checked;
						chkPayBillNeed.Checked = oOutputDocument.PF_PayBillNeed;
						chkWarrantNeed.Checked = oOutputDocument.PF_WarrantNeed;
						chkTPL.Checked = oOutputDocument.TPL;

						if (!dgvOutputDocumentGoods_Restore())
						{
							RFMMessage.MessageBoxError("Ошибка получения о товарах в расходном документе...");
							Dispose();
						}
					}
				}
				else
				{ 
					// новый заказ
					bResult = cboOwner_Restore();

					if (bResult)
					{
						cboOutputDocumentType.SelectedIndex = -1;
						cboCurrency.SelectedIndex = 0;
						cboGoodState.SelectedIndex = 0;
						cboOwner.SelectedIndex = -1;

						dgvOutputDocumentGoods_Restore();
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
				oHost.ReFillOne((int)oOutputDocument.HostID);
				Text += " [" + oHost.Name + "]";
			}

			string cColumnName = "";
			dgvOutputDocumentGoods.ReadOnly = false;
			foreach (DataGridViewColumn c in dgvOutputDocumentGoods.Columns)
			{
				cColumnName = c.Name.ToUpper();
				c.ReadOnly = !(cColumnName.Contains("CHECK") ||
								cColumnName.Contains("WISHED") ||
								cColumnName.Contains("PRICE"));
			}
			if (dgvOutputDocumentGoods.Rows.Count > 0)
			{
				// встать на первую строку, в ячейку "Коробок заказ"
				dgvOutputDocumentGoods.CurrentCell = dgvOutputDocumentGoods.Rows[0].Cells["dgvcBoxWished"];
			}
		}

		#region Restore

		#region ComboBox

		private bool cboCurrency_Restore()
		{
			cboCurrency.DataSource = null;
			Currency oCurrency;
			oCurrency = new Currency();
			if (oCurrency.FillDataAsync())
			{
				cboCurrency.ValueMember = oCurrency.ColumnID;
				cboCurrency.DisplayMember = oCurrency.ColumnName;
				cboCurrency.Restore(oCurrency.MainTable);
			}
			return (oCurrency.ErrorNumber == 0);
		}

		private bool cboOutputDocumentType_Restore()
		{
			cboOutputDocumentType.DataSource = null;
			oOutputDocument.ClearError();
			if (oOutputDocument.FillTableOutputsDocumentsTypes())
			{
				cboOutputDocumentType.ValueMember = "ID";
				cboOutputDocumentType.DisplayMember = "Name";
				cboOutputDocumentType.Restore(oOutputDocument.TableOutputsDocumentsTypes);
			}
			return (oOutputDocument.ErrorNumber == 0);
		}

		private bool cboGoodState_Restore()
		{
			cboGoodState.DataSource = null;
			oGoodState.ClearError();
			if (oGoodState.FillDataAsync())
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
			if (oOutputDocument != null && oOutputDocument.HostID.HasValue)
				oOwner.FilterHostsList = oOutputDocument.HostID.ToString();
			if (oOwner.FillDataAsync())
			{
				cboOwner.ValueMember = oOwner.ColumnID;
				cboOwner.DisplayMember = oOwner.ColumnName;
				cboOwner.Restore(oOwner.MainTable);
			}
			return (oOwner.ErrorNumber == 0);
		}

		#endregion ComboBox

		#region Grid

		private bool dgvOutputDocumentGoods_Restore()
		{
			oOutputDocument.ClearError();
			if (oOutputDocument.ErrorNumber == 0)
			{
				oOutputDocument.FillTableOutputsDocumentsGoods(nOutputDocumentID);
				if (oOutputDocument.ErrorNumber == 0)
				{
					oOutputDocument.TableOutputsDocumentsGoods.PrimaryKey = null;
					oOutputDocument.TableOutputsDocumentsGoods.Columns["ID"].Unique = false;
					oOutputDocument.TableOutputsDocumentsGoods.Columns["ID"].AllowDBNull = true;
					oOutputDocument.TableOutputsDocumentsGoods.Columns["OutputDocumentGoodID"].Unique = false;
					oOutputDocument.TableOutputsDocumentsGoods.Columns["OutputDocumentGoodID"].AllowDBNull = true;

					decimal nQnt = 0;
					decimal nBox = 0;
					foreach (DataRow droRow in oOutputDocument.TableOutputsDocumentsGoods.Rows)
					{
						nQnt += (decimal)droRow["QntWished"];
						nBox += (decimal)droRow["BoxWished"];
					}
					dgvOutputDocumentGoods.Restore(oOutputDocument.TableOutputsDocumentsGoods);
					lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
					lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
				}
			}
			return (oOutputDocument.ErrorNumber == 0);
		}

		#endregion Grid

		#region ucSelectRecordIDForm

		private void ucSelectRecordIDForm_Salers_Restore()
		{
			ucSelectRecordIDForm_Salers.SendParams = new object[] { ucSelectRecordIDForm_Salers, "D", false, false, (int)oOutputDocument.HostID };
			ucSelectRecordIDForm_Salers.Restore();
		}

		private void ucSelectRecordIDForm_Shippers_Restore()
		{
			ucSelectRecordIDForm_Shippers.SendParams = new object[] { ucSelectRecordIDForm_Shippers, "D", false, false, (int)oOutputDocument.HostID };
			ucSelectRecordIDForm_Shippers.Restore();
		}

		private void ucSelectRecordIDForm_Buyers_Restore()
		{
			ucSelectRecordIDForm_Buyers.SendParams = new object[] { ucSelectRecordIDForm_Buyers, "D", false, false, (int)oOutputDocument.HostID };
			ucSelectRecordIDForm_Buyers.Restore();
		}

		#endregion ucSelectRecordIDForm
		
		#endregion

		#region GridCells

		private void dgvOutputDocumentGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvOutputDocumentGoods.DataSource == null || dgvOutputDocumentGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvOutputDocumentGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			switch (dgvOutputDocumentGoods.Columns[e.ColumnIndex].Name)
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

		private void dgvOutputDocumentGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvOutputDocumentGoods.Columns[e.ColumnIndex].Name.Contains("Qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvOutputDocumentGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvOutputDocumentGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvOutputDocumentGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oOutputDocument.TableOutputsDocumentsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvOutputDocumentGoods.Columns[e.ColumnIndex].Name;
			if (sColumnName == "dgvcQntWished" ||sColumnName == "dgvcBoxWished")
			{
				DataRow droRow = ((DataRowView)((DataGridViewRow)dgvOutputDocumentGoods.Rows[e.RowIndex]).DataBoundItem).Row;
				if (droRow == null)
					return;

				if (sColumnName == "dgvcQntWished" || sColumnName == "dgvcBoxWished")
				{
					decimal nInbox = (decimal)droRow["InBox"];
					if (sColumnName == "dgvcQntWished")
					{
						// меняем штуки -> пересчитываем коробки
						droRow["BoxWished"] = (decimal)dgvOutputDocumentGoods.Rows[e.RowIndex].Cells["dgvcQntWished"].Value / nInbox;
					}
					if (sColumnName == "dgvcBoxWished")
					{
						// меняем коробки -> пересчитываем штуки
						if ((bool)droRow["Weighting"] || (nInbox != (int)nInbox))
							droRow["QntWished"] = (decimal)dgvOutputDocumentGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox;
						else
							droRow["QntWished"] = (decimal.Ceiling)(decimal.Round((decimal)dgvOutputDocumentGoods.Rows[e.RowIndex].Cells["dgvcBoxWished"].Value * nInbox, 1));
					}
				}

				dgvOutputDocumentGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvOutputDocumentGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow r = dgvOutputDocumentGoods.Rows[e.RowIndex];
			if (dgvOutputDocumentGoods.Columns[e.ColumnIndex].Name == "dgvcQntWished")
			{
				//bIsEditQnt = true;
				if (r.Cells["dgvcQntWished"].Value == null || r.Cells["dgvcQntWished"].Value == DBNull.Value)
				{
					r.Cells["dgvcQntWished"].Value = 0;
					return; 
				}
				//bIsEditQnt = false;
			}

			if (dgvOutputDocumentGoods.Columns[e.ColumnIndex].Name == "dgvcBoxWished")
			{
				//bIsEditBox = false;
				if (r.Cells["dgvcBoxWished"].Value == null || r.Cells["dgvcBoxWished"].Value == DBNull.Value)
				{
					r.Cells["dgvcBoxWished"].Value = 0;
					return;
				}
				//bIsEditBox = false;
			}

			dgvOutputDocumentGoods.Refresh();
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
			if (cboOutputDocumentType.SelectedIndex < 0 || cboOutputDocumentType.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите тип расходного документа!");
				tcOutputDocument.SelectedTab = tabMain;
				cboOutputDocumentType.Select();
				return;
			}

			if (cboOwner.SelectedIndex < 0 || cboOwner.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите владельца товара!");
				tcOutputDocument.SelectedTab = tabMain;
				cboOwner.Select();
				return;
			}

			if (cboGoodState.SelectedIndex < 0 || cboGoodState.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите состояние товара!");
				tcOutputDocument.SelectedTab = tabMain;
				cboGoodState.Select();
				return;
			}

			if (ucSelectRecordIDForm_Salers.TxtData.Text.Length == 0)
			{
				RFMMessage.MessageBoxError("Выберите реквизиты продавца товара!");
				tcOutputDocument.SelectedTab = tabMain;
				ucSelectRecordIDForm_Salers.Select();
				return;
			}

			if (ucSelectRecordIDForm_Shippers.TxtData.Text.Length == 0)
			{
				RFMMessage.MessageBoxError("Выберите реквизиты грузоотправителя товара!");
				tcOutputDocument.SelectedTab = tabMain;
				ucSelectRecordIDForm_Shippers.Select();
				return;
			}

			if (ucSelectRecordIDForm_Buyers.TxtData.Text.Length == 0)
			{
				RFMMessage.MessageBoxError("Выберите реквизиты покупателя товара!");
				tcOutputDocument.SelectedTab = tabMain;
				ucSelectRecordIDForm_Buyers.Select();
				return;
			}

			if (cboCurrency.SelectedIndex < 0 || cboCurrency.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("Выберите валюту!");
				tcOutputDocument.SelectedTab = tabMain;
				cboCurrency.Select();
				return;
			}

			if (chkBillNeed.Checked &&
				txtBillNumber.Text.Length == 0 &&
				RFMMessage.MessageBoxYesNo("Не указан номер накладной.\nВсе равно сохранить?") == DialogResult.No)
			{
				tcOutputDocument.SelectedTab = tabOther;
				txtBillNumber.Select();
				return;
			}

			if (chkFactureNeed.Checked &&
				txtFactureNumber.Text.Length == 0 &&
				RFMMessage.MessageBoxYesNo("Не указан номер счета-фактуры.\nВсе равно сохранить?") == DialogResult.No)
			{
				tcOutputDocument.SelectedTab = tabOther;
				txtFactureNumber.Select();
				return;
			}


			// хоть один товар
			if (oOutputDocument.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxAttention("Не введено ни одного товара...");
				return;
			}
			else
			{	
				// хоть что-то введено
				bool bFound = false;
				foreach (DataRow r in oOutputDocument.TableOutputsDocumentsGoods.Rows)
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
			if (RFMMessage.MessageBoxYesNo("Сохранить расходный документ (заказ)?") == DialogResult.Yes)
			{
				oOutputDocument.DateOutput = dtpDateOutputDocument.Value.Date;
				oOutputDocument.OutputDocumentTypeID = (int)cboOutputDocumentType.SelectedValue;
				oOutputDocument.GoodStateID = (int)cboGoodState.SelectedValue;
				oOutputDocument.OwnerID = (int)cboOwner.SelectedValue;
                oOutputDocument.CurrencyID = (int)cboCurrency.SelectedValue;

                oOutputDocument.DeliveryPrice = oOutputDocument.VeterinaryPrice = 0;
                oOutputDocument.DeliveryCurrencyID = oOutputDocument.VeterinaryCurrencyID = Convert.ToInt32(oOutputDocument.CurrencyID);

				oOutputDocument.DeliveryNeed = chkDeliveryNeed.Checked; 
				oOutputDocument.Note = txtNote.Text.Trim();
				if (ucSelectRecordIDForm_Salers.txtData.Text != oOutputDocument.PartnerSalerFactName)
					oOutputDocument.PartnerDetailSalerID = Convert.ToInt16(ucSelectRecordIDForm_Salers.GetIdString());
				if (ucSelectRecordIDForm_Shippers.txtData.Text != oOutputDocument.PartnerShipperFactName)
					oOutputDocument.PartnerDetailShipperID = Convert.ToInt16(ucSelectRecordIDForm_Shippers.GetIdString());
				if (ucSelectRecordIDForm_Buyers.txtData.Text != oOutputDocument.PartnerBayerFactName)
					oOutputDocument.PartnerDetailBayerID = Convert.ToInt16(ucSelectRecordIDForm_Buyers.GetIdString());
				oOutputDocument.PF_BillNeed = chkBillNeed.Checked;
				oOutputDocument.BillNumber = txtBillNumber.Text.Trim();
				oOutputDocument.PF_FactureNeed = chkFactureNeed.Checked;
				oOutputDocument.FactureNumber = txtFactureNumber.Text.Trim();
				oOutputDocument.PF_PayBillNeed = chkPayBillNeed.Checked;
				oOutputDocument.PF_WarrantNeed = chkWarrantNeed.Checked;
				oOutputDocument.TPL = chkTPL.Checked;
				oOutputDocument.NotForJoin = chkNotForJoin.Checked;

				// добрались. сохраняем.
				Refresh();
				WaitOn(this);
				oOutputDocument.ClearError();
				bool bResult = oOutputDocument.Save();
				WaitOff(this);
				if (bResult && oOutputDocument.ErrorNumber == 0)
				{
					RFMMessage.MessageBoxInfo("Расходный документ (заказ) сохранен.");
					MotherForm.GotParam = new object[] { (int)oOutputDocument.ID };
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
			
			if (StartForm(new frmSelectOnePacking(this, true, null, oOutputDocument.HostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingsIDList != null)
				{
					// идем по каждому выбранному товару
					Good oGoodNew = new Good();
					oGoodNew.PackingsIDList = _SelectedPackingsIDList;
					oGoodNew.FillDataAsync();
					if (oGoodNew.ErrorNumber == 0 && oGoodNew.MainTable != null &&
						oGoodNew.MainTable.Rows.Count > 0)
					{
						foreach (DataRow rGNew in oGoodNew.MainTable.Rows)
						{
							nNewPackingID = Convert.ToInt32(rGNew["PackingID"]);
							bool bFound = false;
							// проверить, нет ли уже такой строки
							foreach (DataRow r in oOutputDocument.TableOutputsDocumentsGoods.Rows)
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
							DataRow dr = oOutputDocument.TableOutputsDocumentsGoods.Rows.Add(-1, -1);
							if (nOutputDocumentID !=0)
								dr["OutputDocumentID"] = (int)oOutputDocument.ID;
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
							dgvOutputDocumentGoods.GridSource.Position = dgvOutputDocumentGoods.GridSource.Find("PackingID", nNewFirstPackingID);
							if (dgvOutputDocumentGoods.GridSource.Position < 0)
							{
								dgvOutputDocumentGoods.GridSource.MoveFirst();
							}
							// встать на найденную строку, в ячейку "Коробок зак."
							dgvOutputDocumentGoods.CurrentCell = dgvOutputDocumentGoods.Rows[dgvOutputDocumentGoods.GridSource.Position].Cells["dgvcBoxWished"];
							dgvOutputDocumentGoods.Select();
							dgvOutputDocumentGoods.Rows[dgvOutputDocumentGoods.GridSource.Position].Cells["dgvcBoxWished"].Selected = true;
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
			foreach (DataRow r in oOutputDocument.TableOutputsDocumentsGoods.Rows)
			{
				nQnt += (decimal)r["QntWished"];
				nBox += (decimal)r["BoxWished"];
			}
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
		}

		private void frmOutputDocumentsEdit_KeyDown(object sender, KeyEventArgs e)
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

		private void ucSelectRecordIDForm_Salers_TxtData_TextChanged(object sender, EventArgs e)
		{
			if (ucSelectRecordIDForm_Shippers.TxtData.Text.Length == 0)
			{
				ucSelectRecordIDForm_Shippers.TxtData.Text = ucSelectRecordIDForm_Salers.TxtData.Text;
				if (ucSelectRecordIDForm_Salers.selectData != null)
					ucSelectRecordIDForm_Shippers.selectData = ucSelectRecordIDForm_Salers.selectData.Copy();
			}
		}

		private void ucSelectRecordIDForm_Shippers_TxtData_TextChanged(object sender, EventArgs e)
		{
			if (ucSelectRecordIDForm_Salers.TxtData.Text.Length == 0)
			{
				ucSelectRecordIDForm_Salers.TxtData.Text = ucSelectRecordIDForm_Shippers.TxtData.Text;
				if (ucSelectRecordIDForm_Shippers.selectData != null)
					ucSelectRecordIDForm_Salers.selectData = ucSelectRecordIDForm_Shippers.selectData.Copy();
			}
		}

		private void chkFactureNeed_CheckedChanged(object sender, EventArgs e)
		{
			txtFactureNumber.Enabled = chkFactureNeed.Checked;
			if (!chkFactureNeed.Checked)
				txtFactureNumber.Text = "";
		}

		private void chkBillNeed_CheckedChanged(object sender, EventArgs e)
		{
			txtBillNumber.Enabled = chkBillNeed.Checked;
			if (!chkBillNeed.Checked)
				txtBillNumber.Text = "";
		}
	}
}
