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
	public partial class frmInputsDocumentsEdit : RFMFormChild
	{
		private int nInputDocumentID;
        private int? nInputID = null;
        private bool bAskedDelete = false;
		private InputDocument oInputDocument;
        private Input oInput;
		private LogBizObjects.Currency oCurrency;

		private int? nOwnerID = null;

		//public int? _SelectedPackingID = null;
		public string _SelectedPackingsIDList = null;
		public string _SelectedPackingAliasText = null;

		public int? _SelectedID = null;

		private bool bIsEditQnt = false;
		private bool bIsEditBox = false;

		int nHostID = 0;
		private int? nUserHostID = null;


		public frmInputsDocumentsEdit(int _nInputDocumentID)
		{
			nInputDocumentID = _nInputDocumentID;

			oInputDocument = new InputDocument();
			if (oInputDocument.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oCurrency = new Currency();
				if (oCurrency.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;
		}

        public frmInputsDocumentsEdit(int _nInputID, int _nInputDocumentID)
        {
            nInputDocumentID = _nInputDocumentID;
            nInputID = _nInputID;

            oInputDocument = new InputDocument();
            if (oInputDocument.ErrorNumber != 0)
            {
                IsValid = false;
            }

            if (IsValid)
            {
                oCurrency = new Currency();
                if (oCurrency.ErrorNumber != 0)
                {
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                oInput = new Input();
                if (oInput.ErrorNumber != 0)
                {
                    IsValid = false;
                }
            }

            if (IsValid)
            {
                InitializeComponent();
            }
        }

		private void frmInputsDocumentsEdit_Load(object sender, EventArgs e)
		{
			bool bResult = cboCurrency_Restore();
			if (bResult)
			{
                if (nInputDocumentID != 0)
                {
				    oInputDocument.ReFillOne(nInputDocumentID);
				    if (oInputDocument.ErrorNumber != 0 || oInputDocument.MainTable.Rows.Count == 0)
				    {
					    RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������� ���������...");
					    bResult = false;
				    }

					if (nUserHostID.HasValue && (int)nUserHostID != (int)oInputDocument.HostID)
					{
						RFMMessage.MessageBoxError("������������ ���� ������� � ������ �����...");
						Dispose();
					}

                    if (bResult)
                    {
                        Text += " (" + nInputDocumentID.ToString() + ")";

						nHostID = (int)oInputDocument.HostID;

                        txtPartnerSourceName.Text = oInputDocument.PartnerSourceName;
                        txtManagerName.Text = oInputDocument.ManagerName + " " + oInputDocument.ManagerPhone;
                        txtNote.Text = oInputDocument.Note;
						txtOwnerName.Text = oInputDocument.OwnerName;

                        if (oInputDocument.DateBill.HasValue)
                        {
                            dtpDateBill.Value = Convert.ToDateTime(oInputDocument.DateBill);
                        }
                        txtBillNumber.Text = oInputDocument.BillNumber;
                        txtFactureNumber.Text = oInputDocument.FactureNumber;

                        numAmountBill.Value = oInputDocument.AmountBill;
                        if (oInputDocument.CurrencyID != 0)
                            cboCurrency.SelectedValue = oInputDocument.CurrencyID;
                        else
                            cboCurrency.SelectedIndex = 0;
                        numVatAmountBill.Value = oInputDocument.VatAmountBill;

						nOwnerID = oInputDocument.OwnerID;
                    }
                }
                else
                {
                    Text += " (��������) ";

                    oInput.ReFillOne((int)nInputID);

					if (nUserHostID.HasValue && (int)nUserHostID != (int)oInput.HostID)
					{
						RFMMessage.MessageBoxError("������������ ���� ������� � ������ �����...");
						Dispose(); 
					}

					nHostID = (int)oInput.HostID;
					oInputDocument.HostID = oInput.HostID;

					oInputDocument.DateInput = oInput.DateInput;

                    txtPartnerSourceName.Text = oInput.PartnerName;
                    txtManagerName.Text = "";
                    txtNote.Text = "����.�� ������� " + nInputID.ToString().Trim();
					txtOwnerName.Text = oInput.OwnerName;

                    if (!Convert.IsDBNull(oInput.DateInput))
                    {
                        dtpDateBill.Value = Convert.ToDateTime(oInput.DateInput);
                    }
                    txtBillNumber.Text = "";
                    txtFactureNumber.Text = "";

                    numAmountBill.Value = oInput.Amount;

                    cboCurrency.SelectedIndex = 0;

                    numVatAmountBill.Value = 0;

					nOwnerID = oInput.OwnerID;
                }
				if (!dgvInputDocumentGoods_Restore())
				{
					RFMMessage.MessageBoxError("������ ��������� ������ � ������� � ��������� ���������...");
					Dispose();
				}

				string cColumnName = ""; 
				dgvInputDocumentGoods.ReadOnly = false;
				foreach (DataGridViewColumn c in dgvInputDocumentGoods.Columns)
				{
					cColumnName = c.Name.ToUpper();
					c.ReadOnly = !(cColumnName.Contains("CHECK") || 
						cColumnName.Contains("BROUGHT") || 
						cColumnName.Contains("PRICE") ||
						cColumnName.Contains("VAT") ||
						cColumnName.Contains("CUSTOM") ||
                        cColumnName.Contains("BYORDER"));
				}
				if (dgvInputDocumentGoods.Rows.Count > 0)
				{
					// ������ �� ������ ������, � ������ "������� ���."
					dgvInputDocumentGoods.CurrentCell = dgvInputDocumentGoods.Rows[0].Cells["dgrcBoxBrought"];
				}
			}
			
			if (!bResult)
			{
				Dispose();
			}

			Host oHost = new Host();
			if (oHost.Count() > 1)
			{
				oHost.ReFillOne((int)oInputDocument.HostID);
				Text += " [" + oHost.Name + "]";
			}
		}

		#region Restore

		#region ComboBox

		private bool cboCurrency_Restore()
		{
			cboCurrency.DataSource = null;
			oCurrency.ClearError();
			if (oCurrency.FillData())
			{
				cboCurrency.DataSource = new DataView(oCurrency.MainTable);
				cboCurrency.ValueMember = oCurrency.ColumnID;
				cboCurrency.DisplayMember = "Alias";
				cboCurrency.Restore();
			}
			return (oCurrency.ErrorNumber == 0);
		}

		#endregion ComboBox

		#region Grid

		private bool dgvInputDocumentGoods_Restore()
		{
    	    oInputDocument.ClearError();
		    oInputDocument.FillData();
	        if (oInputDocument.ErrorNumber == 0)
            {
                if (nInputDocumentID != 0)
                    oInputDocument.FillTableInputsDocumentsGoods();
                else
                    oInputDocument.FillTableInputsDocumentsGoodsFromInput((int)nInputID);
                if (oInputDocument.ErrorNumber == 0)
                {
                    oInputDocument.TableInputsDocumentsGoods.PrimaryKey = null; 
					oInputDocument.TableInputsDocumentsGoods.Columns["ID"].Unique = false;
					oInputDocument.TableInputsDocumentsGoods.Columns["ID"].AllowDBNull = true;
					oInputDocument.TableInputsDocumentsGoods.Columns["InputDocumentGoodID"].Unique = false;
					oInputDocument.TableInputsDocumentsGoods.Columns["InputDocumentGoodID"].AllowDBNull = true;
					//oInputDocument.TableInputsDocumentsGoods.Columns["InputDocumentGoodID"].DefaultValue = -1;
					//oInputDocument.TableInputsDocumentsGoods.PrimaryKey = new DataColumn[] { oInputDocument.TableInputsDocumentsGoods.Columns["InputDocumentGoodID"] };

					// ������� ��� �����������
					if (oInputDocument.TableInputsDocumentsGoods.Columns["QntWished"] == null)
					{
						oInputDocument.TableInputsDocumentsGoods.Columns.Add("QntWished", System.Type.GetType("System.Decimal"));
					}
					if (oInputDocument.TableInputsDocumentsGoods.Columns["QntBrought"] == null)
					{
						oInputDocument.TableInputsDocumentsGoods.Columns.Add("QntBrought", System.Type.GetType("System.Decimal"));
					}
					if (oInputDocument.TableInputsDocumentsGoods.Columns["BoxWished"] == null)
					{
						oInputDocument.TableInputsDocumentsGoods.Columns.Add("BoxWished", System.Type.GetType("System.Decimal"));
					}
					if (oInputDocument.TableInputsDocumentsGoods.Columns["BoxBrought"] == null)
					{
						oInputDocument.TableInputsDocumentsGoods.Columns.Add("BoxBrought", System.Type.GetType("System.Decimal"));
					}
					// ������� ��� �����
					if (oInputDocument.TableInputsDocumentsGoods.Columns["PriceSum"] == null)
					{
						oInputDocument.TableInputsDocumentsGoods.Columns.Add("PriceSum", System.Type.GetType("System.Decimal"));
					}

					// ��������� ��������� �������� 
					decimal nAmount = 0;
					decimal nQnt = 0;
					decimal nBox = 0;
					foreach (DataRow droRow in oInputDocument.TableInputsDocumentsGoods.Rows)
					{
						droRow["BoxBrought"] = 
						droRow["BoxWished"] = 
							droRow["Box"];
						droRow["QntBrought"] = 
						droRow["QntWished"] =
							droRow["Qnt"]; 
						droRow["PriceSum"] = (decimal)droRow["QntBrought"] * (decimal)droRow["Price"];
						nQnt += (decimal)droRow["QntBrought"];
						nBox += (decimal)droRow["BoxBrought"];
						nAmount += (decimal)droRow["PriceSum"];

						// ���
						if (Convert.IsDBNull(droRow["Vat"]) || droRow["Vat"] == null)
						{
							droRow["Vat"] = 0;
						}
						/*
						if (Convert.IsDBNull(droRow["Vat"]) || droRow["Vat"] == null || (decimal)droRow["Vat"] == 0)
						{
							droRow["Vat"] = oGood.Vat((int)droRow["PackingID"], oInputDocument.DateInput);
						}
						*/ 
					}
					dgvInputDocumentGoods.Restore(oInputDocument.TableInputsDocumentsGoods);
					lblTotalAmount.Text = nAmount.ToString("### ### ##0.00").Trim();
					lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
					lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
				}
			}
			return (oInputDocument.ErrorNumber == 0);
		}

		#endregion Grid

		#endregion

		#region GridCells

		private void dgvInputDocumentGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvInputDocumentGoods.DataSource == null || dgvInputDocumentGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvInputDocumentGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			if ((decimal)droRow["QntBrought"] < (decimal)droRow["QntWished"])
			{
				if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcQntBrought" ||
					dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcBoxBrought")
				{
					if ((decimal)droRow["QntBrought"] == 0)
						e.CellStyle.BackColor = Color.FromArgb(250, 200, 200);
					else
						e.CellStyle.BackColor = Color.FromArgb(255, 255, 128);
				}
			}
			if ((decimal)droRow["QntBrought"] > (decimal)droRow["QntWished"])
			{
				if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcQntBrought" ||
					dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcBoxBrought")
				{
					e.CellStyle.BackColor = Color.FromArgb(128, 255, 255);
				}
			}

			switch (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name)
			{
				case "dgrcInBox":
				case "dgrcQntWished":
				case "dgrcQntBrought":
					if (!Convert.IsDBNull(droRow["Weighting"]) && Convert.ToBoolean(droRow["Weighting"]) ||
						!Convert.IsDBNull(droRow["InBox"]) && Convert.ToInt32(droRow["InBox"]) != Convert.ToDecimal(droRow["InBox"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
						e.CellStyle.Format = "### ###.000";
					else
						e.CellStyle.Format = "### ###";
					break;
			}
		}

		private void dgvInputDocumentGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name.ToLower().Contains("qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvInputDocumentGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvInputDocumentGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvInputDocumentGoods_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgrcboxbrought")
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvInputDocumentGoods.CurrentRow).DataBoundItem).Row;
				((RFMDataGridViewTextBoxNumericColumn)dgvInputDocumentGoods.Columns[e.ColumnIndex]).ReadOnly = ((bool)dr["Weighting"]);
			}
		}

		private void dgvInputDocumentGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oInputDocument.TableInputsDocumentsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvInputDocumentGoods.Columns[e.ColumnIndex].Name;
			if (sColumnName == "dgrcQntBrought" ||sColumnName == "dgrcBoxBrought" ||
				sColumnName == "dgrcPrice" || sColumnName == "dgrcPriceSum")
			{
				DataRow droRow = ((DataRowView)((DataGridViewRow)dgvInputDocumentGoods.Rows[e.RowIndex]).DataBoundItem).Row;
				if (droRow == null)
					return;

				// !!!
				if (dgvInputDocumentGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null ||
					dgvInputDocumentGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
					dgvInputDocumentGoods.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
				// !!!

				if (sColumnName == "dgrcQntBrought" || sColumnName == "dgrcBoxBrought")
				{
					decimal nInbox = (decimal)droRow["InBox"];
					if (sColumnName == "dgrcQntBrought")
					{
						// ������ �����
						droRow["BoxBrought"] = (decimal)dgvInputDocumentGoods.Rows[e.RowIndex].Cells["dgrcQntBrought"].Value / nInbox;
					}
					if (sColumnName == "dgrcBoxBrought")
					{
						// ������ �������
						if (nInbox != (int)nInbox || (bool) droRow["Weighting"] )
							droRow["QntBrought"] = (decimal)dgvInputDocumentGoods.Rows[e.RowIndex].Cells["dgrcBoxBrought"].Value * nInbox;
						else	
							droRow["QntBrought"] = (decimal.Ceiling)(decimal.Round((decimal)dgvInputDocumentGoods.Rows[e.RowIndex].Cells["dgrcBoxBrought"].Value * nInbox, 1));
					}
					droRow["PriceSum"] = (decimal)droRow["QntBrought"] * (decimal)droRow["Price"];
				}

				if (sColumnName == "dgrcPrice" || sColumnName == "dgrcPriceSum")
				{
					if (sColumnName == "dgrcPrice")
					{
						// ������ �����
						droRow["PriceSum"] = (decimal)droRow["QntBrought"] * (decimal)dgvInputDocumentGoods.Rows[e.RowIndex].Cells["dgrcPrice"].Value;
					}
					if (sColumnName == "dgrcPriceSum")
					{
						// ������ ����
						if ((decimal)droRow["QntBrought"] != 0)
						{
							droRow["Price"] = (decimal)dgvInputDocumentGoods.Rows[e.RowIndex].Cells["dgrcPriceSum"].Value / (decimal)droRow["QntBrought"];
						}
					}
				}
				dgvInputDocumentGoods.Refresh();
				CalcTotal();
			}
		}

		private void dgvInputDocumentGoods_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow r = dgvInputDocumentGoods.Rows[e.RowIndex];

			if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcQntBrought")
			{
				bIsEditQnt = true;
				if (r.Cells["dgrcQntBrought"].Value == null || r.Cells["dgrcQntBrought"].Value == DBNull.Value)
				{
					r.Cells["dgrcQntBrought"].Value = 0;
					return; 
					//if ((decimal)r.Cells["dgrcQntWished"].Value > 0)
					//{
						//RFMMessage.MessageBoxAttention("�� ������� ���������� ������������ ������ [��.]!");
						//dgvInputDocumentGoods.Refresh();
						//return;
					//}
				}

				if (!(bool)r.Cells["dgrcWeighting"].Value)
				{
					if (!bIsEditBox)
					{
						// ���� ���������� �������� � ��� �� ����� ������ - �������
						if ((decimal)r.Cells["dgrcQntBrought"].Value > (decimal)r.Cells["dgrcQntWished"].Value)
						{
							//RFMMessage.MessageBoxAttention("���������� ������������ ������ [��.] ������ �����������!");
						}
						else
						{
							if ((decimal)r.Cells["dgrcQntBrought"].Value == 0)
							{
								//RFMMessage.MessageBoxAttention("�� ������� ���������� ������������ ������ [��.]!");
							}
							else
							{
								if ((decimal)r.Cells["dgrcQntBrought"].Value < (decimal)r.Cells["dgrcQntWished"].Value)
								{
									//RFMMessage.MessageBoxAttention("���������� ������������ ������ [��.] ������ �����������!");
								}
							}
						}
					}
				}
				bIsEditQnt = false;
			}

			if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcBoxBrought")
			{
				bIsEditBox = false;
				if (r.Cells["dgrcBoxBrought"].Value == null || r.Cells["dgrcBoxBrought"].Value == DBNull.Value)
				{
					r.Cells["dgrcBoxBrought"].Value = 0;
					return;
					//if ((decimal)r.Cells["dgrcQntWished"].Value > 0)
					//{
					//	RFMMessage.MessageBoxAttention("�� ������� ���������� ������������ ������ [���.]!");
					//	dgvInputDocumentGoods.Refresh();
					//	return;
					//}
				}

				// ���� ���������� �������� � ��� �� ����� ������ - �������
				if (!bIsEditQnt)
				{
					if ((decimal)r.Cells["dgrcBoxBrought"].Value > (decimal)r.Cells["dgrcBoxWished"].Value)
					{
						//RFMMessage.MessageBoxAttention("���������� ������������ ������ [���.] ������ �����������!");
					}
					else
					{
						if ((decimal)r.Cells["dgrcBoxBrought"].Value == 0)
						{
							//RFMMessage.MessageBoxAttention("�� ������� ���������� ������������ ������ [���.]!");
						}
						else
						{
							if ((decimal)r.Cells["dgrcBoxBrought"].Value < (decimal)r.Cells["dgrcBoxWished"].Value)
							{
								//RFMMessage.MessageBoxAttention("���������� ������������ ������ [���.] ������ �����������!");
							}
						}
					}
				}
				bIsEditBox = false;
			}

			if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcVat")
			{
				if (r.Cells["dgrcVat"].Value == null || r.Cells["dgrcVat"].Value == DBNull.Value)
				{
					r.Cells["dgrcVat"].Value = 0;
				}

				// �������� ������ ���
				decimal nVat = (decimal)r.Cells["dgrcVat"].Value;
				if (nVat == 0)
				{
					RFMMessage.MessageBoxAttention("�� ������� ������ ���...");
				}
				else
				{
					decimal? nVat1 = null, nVat2 = null;
					Setting oSet = new Setting();
					string sVatTemp = null;
					sVatTemp = oSet.FillVariable("gnVat1");
					if (sVatTemp != null && sVatTemp != "")
						nVat1 = Convert.ToDecimal(sVatTemp);
					sVatTemp = oSet.FillVariable("gnVat2");
					if (sVatTemp != null && sVatTemp != "")
						nVat2 = Convert.ToDecimal(sVatTemp);
					if (nVat1.HasValue && nVat != nVat1 && nVat2.HasValue && nVat != nVat2 ||
						!nVat1.HasValue && nVat2.HasValue && nVat != nVat2 ||
						nVat1.HasValue && nVat != nVat1 && !nVat2.HasValue)
					{
						RFMMessage.MessageBoxError("������� �������� ������ ���...");
						r.Cells["dgrcVat"].Value = 0;
					}
				}
			}

			dgvInputDocumentGoods.Refresh();
		}

		private void dgvInputDocumentGoods_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow r = dgvInputDocumentGoods.Rows[e.RowIndex];
/*
			// ������ ���
			if (dgvInputDocumentGoods.Columns[e.ColumnIndex].Name == "dgrcVat")
			{
				if (r.Cells["dgrcVat"].Value == null || r.Cells["dgrcVat"].Value == DBNull.Value)
				{
					r.Cells["dgrcVat"].Value = 0;
				}

				// �������� ������ ���
				decimal nVat = (decimal)r.Cells["dgrcVat"].Value;
				if (nVat == 0)
				{
					RFMMessage.MessageBoxAttention("�� ������� ������ ���...");
				}
				else
				{
					decimal? nVat1 = null, nVat2 = null;
					Setting oSet = new Setting();
					string sVatTemp = null;
					sVatTemp = oSet.FillVariable("gnVat1");
					if (sVatTemp != null && sVatTemp != "")
						nVat1 = Convert.ToDecimal(sVatTemp);
					sVatTemp = oSet.FillVariable("gnVat2");
					if (sVatTemp != null && sVatTemp != "")
						nVat2 = Convert.ToDecimal(sVatTemp);
					if (nVat1.HasValue && nVat != nVat1 && nVat2.HasValue && nVat != nVat2 ||
						!nVat1.HasValue && nVat2.HasValue && nVat != nVat2 ||
						nVat1.HasValue && nVat != nVat1 && !nVat2.HasValue)
					{
						RFMMessage.MessageBoxError("������� �������� ������ ���...");
						r.Cells["dgrcVat"].Value = 0;
					}
				}
			}
*/
			//dgvInputDocumentGoods.Refresh();
		}

		#endregion

		private void btnExit_Click(object sender, EventArgs e)
		{
			bool bNotNull = false;
            for (int _i = 0; _i < oInputDocument.TableInputsDocumentsGoods.Rows.Count; _i++)
            {
                if ((decimal)oInputDocument.TableInputsDocumentsGoods.Rows[_i]["QntBrought"] > 0)
                {
                    bNotNull = true;
                    break;
                }
            }
            if (!bNotNull && bAskedDelete)
            {
                if (oInputDocument.Delete((int)oInputDocument.ID))
                    RFMMessage.MessageBoxInfo("�� ������� �� ������ ������.\n �������� ������.");
            }
            Dispose();
		}

        private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// ���� ���-�� �������
			bool bFoundBrought = false;
			foreach (DataRow r in oInputDocument.TableInputsDocumentsGoods.Rows)
			{
				if ((decimal)r["QntBrought"] > 0 || (decimal)r["BoxBrought"] > 0)
				{
					bFoundBrought = true;
					break;
				}
			}
			if (!bFoundBrought)
			{
				/*
				if (RFMMessage.MessageBoxYesNo("�� ��� ������ ������ �� ������� ���������� �� ����������.\n\n" +
					"���-���� ��������� ��� ������ � ���������� �������?") == DialogResult.No)
					return;
				*/
				RFMMessage.MessageBoxError("�� ��� ������ ������ �� ������� ���������� �� ����������.\n\n" +
					"�������� �� ����� ���� ��������.");
				return;
			}

            if (cboCurrency.SelectedIndex < 0 || cboCurrency.SelectedValue == null)
			{
				RFMMessage.MessageBoxError("�������� ������!");
				cboCurrency.Select();
				return;
			}

			if (txtBillNumber.Text.Trim() == "")
			{
				if (RFMMessage.MessageBoxYesNo("�� ������ ����� ��������� ����������.\n\n" +
					"��������� ��� �������� ������ ���������?") == DialogResult.No)
					return;
			}
			if (numAmountBill.Value == 0)
			{
				if (RFMMessage.MessageBoxYesNo("�� ������� ����� ��������� ����������.\n\n" +
					"��������� ��� �������� �����?") == DialogResult.No)
					return;
			}
			if (true) // (RFMMessage.MessageBoxYesNo("��������� ������ �� ���������� ����������?") == DialogResult.Yes)
			{
                oInputDocument.ID = nInputDocumentID;
                oInputDocument.Note = txtNote.Text.Trim();
				oInputDocument.DateBill = dtpDateBill.Value.Date;
				oInputDocument.BillNumber = txtBillNumber.Text.Trim();
				oInputDocument.FactureNumber = txtFactureNumber.Text.Trim();
				oInputDocument.AmountBill = numAmountBill.Value;
				oInputDocument.VatAmountBill = numVatAmountBill.Value;
				oInputDocument.CurrencyID = (int)cboCurrency.SelectedValue;
                oInputDocument.InputID = nInputID;

				// ������������� ��������� ���������� � ������� Qnt
				foreach (DataRow droRow in oInputDocument.TableInputsDocumentsGoods.Rows)
				{
					droRow["Qnt"] = droRow["QntBrought"];
				}

				// ���������. ���������.
				Refresh();
				WaitOn(this);
				oInputDocument.ClearError();
				bool bResult = oInputDocument.Save(((RFMFormMain)Application.OpenForms[0]).UserID);
				if (bResult && chkSaveCustomsNumbers.Checked)
				{
					bResult = oInputDocument.GoodsCustomsSave(oInputDocument.TableInputsDocumentsGoods);
				}
				WaitOff(this);
				if (bResult && oInputDocument.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("������ �� ���������� ���������� ���������.");

					if (oInputDocument.ID.HasValue)
					{
						nInputDocumentID = (int)oInputDocument.ID;
						if (chkRegister.Checked)
						{
							if (RFMMessage.MessageBoxYesNo("����������� ��������� ��������\n" +
								"(����� ����� ��������� ������ �� ���������� ���������� ����� ����������)?") == DialogResult.Yes)
							{
								bResult = oInputDocument.Confirm(nInputDocumentID);
							}
						}
					}
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

			if (StartForm(new frmSelectOnePacking(this, true, null, nHostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingsIDList != null)
				{
					// ���� �� ������� ���������� ������
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
							// ���������, ��� �� ��� ����� ������
							foreach (DataRow r in oInputDocument.TableInputsDocumentsGoods.Rows)
							{
								if (Convert.ToInt32(r["PackingID"]) == nNewPackingID)
								{
									bFound = true;
									break; 
								}
							}
							if (bFound)
							{
								// ����� ����� ��� ���� - ��������� � ����.����������� ������
								continue;
							}

							// ��������� ����� ������ ��� ���������� ������
							DataRow dr = oInputDocument.TableInputsDocumentsGoods.Rows.Add(-1, -1);
							dr["PackingID"] = nNewPackingID;
							dr["GoodID"] = rGNew["GoodID"];
							dr["QntWished"] =
							dr["BoxWished"] =
							dr["QntBrought"] =
							dr["BoxBrought"] =
							dr["Price"] =
							dr["PriceSum"] =
								0;
							dr["GoodName"] = rGNew["GoodName"];
							dr["GoodAlias"] = rGNew["GoodAlias"];
							dr["PackingAlias"] = rGNew["PackingAlias"];
							dr["GoodBarCode"] = rGNew["GoodBarCode"];
							dr["Articul"] = rGNew["Articul"];
							dr["GoodGroupName"] = rGNew["GoodGroupName"];
							dr["GoodBrandName"] = rGNew["GoodBrandName"];
							dr["CountryName"] = rGNew["CountryName"];
							dr["InBox"] = rGNew["InBox"];
							dr["BoxInPal"] = rGNew["BoxInPal"];
							dr["Weighting"] = rGNew["Weighting"];

							dr["VAT"] = 0;
							dr["CustomNumber"] = "";

							if (!nNewFirstPackingID.HasValue)
								nNewFirstPackingID = nNewPackingID;
						}

						// ������ �� ��������� ��������� ������, � ������ "������� ���."
						if (nNewFirstPackingID.HasValue)
						{
							dgvInputDocumentGoods.GridSource.Position = dgvInputDocumentGoods.GridSource.Find("PackingID", nNewFirstPackingID);
							if (dgvInputDocumentGoods.GridSource.Position < 0)
							{
								dgvInputDocumentGoods.GridSource.MoveFirst();
							}
							// ������ �� ��������� ������, � ������ "������� ���."
							dgvInputDocumentGoods.CurrentCell = dgvInputDocumentGoods.Rows[dgvInputDocumentGoods.GridSource.Position].Cells["dgrcBoxBrought"];
							dgvInputDocumentGoods.Select(); 
							dgvInputDocumentGoods.Rows[dgvInputDocumentGoods.GridSource.Position].Cells["dgrcBoxBrought"].Selected = true;
						}
					}
				}
				_SelectedPackingsIDList = null;
				_SelectedPackingAliasText = null;
			}
		}

		private void CalcTotal()
		{
			decimal nAmount = 0;
			decimal nQnt = 0;
			decimal nBox = 0;
			foreach (DataRow r in oInputDocument.TableInputsDocumentsGoods.Rows)
			{
				nQnt += (decimal)r["QntBrought"];
				nBox += (decimal)r["BoxBrought"];
				nAmount += (decimal)r["PriceSum"];
			}
			lblTotalAmount.Text = nAmount.ToString("### ### ##0.00").Trim();
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
		}

		private void frmInputsDocumentsEdit_KeyDown(object sender, KeyEventArgs e)
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

		private void btnBillAmount_Click(object sender, EventArgs e)
        {
            try
            {
                numAmountBill.Value = Convert.ToDecimal(lblTotalAmount.Text.Trim().Replace(" ", ""));
            }
            catch { }
        }
	}
}
