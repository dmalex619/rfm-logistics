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
	public partial class frmOutputsDocumentsBring : RFMFormChild
	{
		private int nOutputDocumentID;
		private OutputDocument oOutputDocument;

		public int? _SelectedPackingID = null;
		public string _SelectedPackingAliasText = null;

		public int? _SelectedID = null;
		public string _SelectedText = "";


		public frmOutputsDocumentsBring(int _nOutputDocumentID)
		{
			nOutputDocumentID = _nOutputDocumentID;

			oOutputDocument = new OutputDocument();
			if (oOutputDocument.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsBring_Load(object sender, EventArgs e)
		{
			oOutputDocument.ReFillOne(nOutputDocumentID);
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ � ������...");
				Dispose();
			}

			Text += " (" + nOutputDocumentID.ToString() + ")";

			txtDateOutput.Text = oOutputDocument.DateOutput.ToString("dd.MM.yyyy");
			txtPartnerTargetName.Text = oOutputDocument.PartnerTargetName;
			txtManagerName.Text = oOutputDocument.ManagerName + " " + oOutputDocument.ManagerPhone;
			txtOwnerName.Text = oOutputDocument.OwnerName;
			txtNote.Text = oOutputDocument.Note;
			txtNoteExecute.Text = oOutputDocument.NoteExecute;

			if (oOutputDocument.DeliveryPrice != 0)
			{
				lblTransportActText.Text = lblTransportActText.Text.Replace("#", oOutputDocument.DeliveryPrice.ToString("########0.00"));
				lblTransportActText.Visible = true;
			}
			else
			{
				lblTransportActText.Visible = false;
			}

			chkDocumentsOK.Checked = true; 
 
			numGetMoneyConfirmed.Value = oOutputDocument.GetMoneyConfirmed;
			/*
			numGetPalletsQntConfirmed.Value = oOutputDocument.GetPalletsQntConfirmed;
			// ������������
			if (oOutputDocument.WarrantNeed)
			{
				chkIsWarrantReturned.Text = "������������ ";
				if (oOutputDocument.WarrantNumber.Trim().Length > 0)
				{
					chkIsWarrantReturned.Text += " � " + oOutputDocument.WarrantNumber.Trim();
				}
				chkIsWarrantReturned.Text += " ����������";
				chkIsWarrantReturned.Enabled = true;
				chkIsWarrantReturned.Checked = oOutputDocument.IsWarrantReturned;
			}
			else
			{
				chkIsWarrantReturned.Text = "������������ �� ���������";
				chkIsWarrantReturned.Enabled = false;
			}
			*/

			if (!dgvOuputsGoods_Restore())
			{
				RFMMessage.MessageBoxError("������ ��������� � ������� � ������ �� ��������...");
				Dispose();
			}

			dgvOutputsDocumentsGoods.ReadOnly = false;
			foreach (DataGridViewColumn c in dgvOutputsDocumentsGoods.Columns)
			{
				c.ReadOnly = !(c.Name.Contains("Check") || 
					c.Name.Contains("Brought") ||
					c.Name.Contains("GoodPrice") || 
					c.Name.Contains("Vat"));
			}
			if (dgvOutputsDocumentsGoods.Rows.Count > 0)
			{
				// ������ �� ������ ������, � ������ "������� ����."
				dgvOutputsDocumentsGoods.CurrentCell = dgvOutputsDocumentsGoods.Rows[0].Cells["dgrcBoxBrought"];
				btnSave.Enabled = true;
			}

			Host oHost = new Host();
			if (oHost.Count() > 1)
			{
				oHost.ReFillOne((int)oOutputDocument.HostID);
				Text += " [" + oHost.Name + "]";
			}

			//bLoaded = true;
		}

		#region Restore

		private bool dgvOuputsGoods_Restore()
		{
			oOutputDocument.ClearError();
			oOutputDocument.FillTableOutputsDocumentsGoods();

			oOutputDocument.TableOutputsDocumentsGoods.PrimaryKey = null;
			oOutputDocument.TableOutputsDocumentsGoods.Columns["ID"].Unique = false;
			oOutputDocument.TableOutputsDocumentsGoods.Columns["ID"].AllowDBNull = true;
			//oOutputDocument.TableOutputsDocumentsGoods.PrimaryKey = new DataColumn[] { oOutputDocument.TableOutputsDocumentsGoods.Columns["OutputDocumentGoodID"] };

			oOutputDocument.TableOutputsDocumentsGoods.Columns.Add("NNumber", System.Type.GetType("System.Int16"));

			int i = 0;
			decimal nAmount = 0;
			decimal nQnt = 0;
			decimal nBox = 0;
			foreach (DataRow droRow in oOutputDocument.TableOutputsDocumentsGoods.Rows)
			{
				droRow["BoxBrought"] = droRow["BoxConfirmed"];
				droRow["QntBrought"] = droRow["QntConfirmed"];
				nQnt += (decimal)droRow["QntBrought"];
				nBox += (decimal)droRow["BoxBrought"];
				nAmount += (decimal)droRow["QntBrought"] * (decimal)droRow["Price"];

				if (Convert.IsDBNull(droRow["Vat"]) || droRow["Vat"] == null)
					droRow["Vat"] = 0;

				i++;
				droRow["NNumber"] = i;
			}

			dgvOutputsDocumentsGoods.Restore(oOutputDocument.TableOutputsDocumentsGoods);
			lblTotalAmount.Text = nAmount.ToString("### ### ##0.00").Trim();
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
			lblTotalStrikesCnt.Text = "";
			return (oOutputDocument.ErrorNumber == 0);
		}

		#endregion

		#region GridCells

		private void dgvOutputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvOutputsDocumentsGoods.DataSource == null || dgvOutputsDocumentsGoods.CurrentRow == null)
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvOutputsDocumentsGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			if (dgvOutputsDocumentsGoods.IsStatusRow(e.RowIndex))
				return;

			if ((decimal)droRow["QntBrought"] < (decimal)droRow["QntConfirmed"])
			{
				if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcQntBrought" ||
					dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcBoxBrought")
				{
					if ((decimal)droRow["QntBrought"] == 0)
						e.CellStyle.BackColor = Color.FromArgb(250, 200, 200);
					else
						e.CellStyle.BackColor = Color.FromArgb(255, 255, 128);
				}
			}

			if ((bool)droRow["Changed"])
			{
				e.CellStyle.BackColor = Color.LightBlue;
			}

			switch (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name)
			{
				case "dgrcInBox":
				case "dgrcQntConfirmed":
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

		private void dgvOutputsDocumentsGoods_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name.ToLower() == "dgrcboxbrought")
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvOutputsDocumentsGoods.CurrentRow).DataBoundItem).Row;
				((RFMDataGridViewTextBoxNumericColumn)dgvOutputsDocumentsGoods.Columns[e.ColumnIndex]).ReadOnly = ((bool)dr["Weighting"]);
			}
		}

		private void dgvOutputsDocumentsGoods_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name.Contains("Qnt"))
			{
				DataRow dr = ((DataRowView)((DataGridViewRow)dgvOutputsDocumentsGoods.CurrentRow).DataBoundItem).Row;
				decimal nInbox = (decimal)dr["InBox"];
				((RFMDataGridViewTextBoxNumericColumn)dgvOutputsDocumentsGoods.Columns[e.ColumnIndex]).DecimalPlaces =
					(nInbox != (int)nInbox || (bool)dr["Weighting"]) ? 3 : 0;
			}
		}

		private void dgvOutputsDocumentsGoods_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if (oOutputDocument.TableOutputsDocumentsGoods.Rows.Count == 0)
				return;

			string sColumnName = dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name.ToUpper(); 
			if (!(sColumnName.Contains("Brought".ToUpper()) || 
				sColumnName.Contains("GoodPrice".ToUpper()) ) ) 
				return;

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvOutputsDocumentsGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			if (droRow == null)
				return;

			if (sColumnName.Contains("QntBrought".ToUpper()) || 
				sColumnName.Contains("BoxBrought".ToUpper()) ) 
			{
				decimal nInbox = (decimal)droRow["InBox"];
				if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcQntBrought")
				{
					// ������ ����� -> ������������� �������
					droRow["BoxBrought"] = (decimal)dgvOutputsDocumentsGoods.Rows[e.RowIndex].Cells["dgrcQntBrought"].Value / nInbox; 
				}
				if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcBoxBrought")
				{
					// ������ ������� -> ������������� �����
					if ((bool)droRow["Weighting"] || nInbox != (int)nInbox)
						droRow["QntBrought"] = (decimal)dgvOutputsDocumentsGoods.Rows[e.RowIndex].Cells["dgrcBoxBrought"].Value * nInbox;
					else
						droRow["QntBrought"] = (decimal.Ceiling)(decimal.Round((decimal)dgvOutputsDocumentsGoods.Rows[e.RowIndex].Cells["dgrcBoxBrought"].Value * nInbox, 1));
				}
			}

			droRow["PriceSum"] = (decimal)droRow["QntBrought"] * (decimal)droRow["Price"];
			dgvOutputsDocumentsGoods.Refresh();

			CalcTotal();
		}

		private void dgvOutputsDocumentsGoods_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow r = dgvOutputsDocumentsGoods.Rows[e.RowIndex];
			if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcQntBrought" &&
					!(bool)r.Cells["dgrcWeighting"].Value  && 
					( r.Cells["dgrcQntBrought"].Value == null || r.Cells["dgrcQntBrought"].Value == DBNull.Value ||
					((decimal)r.Cells["dgrcQntBrought"].Value > (decimal)r.Cells["dgrcQntConfirmed"].Value))
					)
			{
				if (r.Cells["dgrcQntBrought"].Value == null || r.Cells["dgrcQntBrought"].Value == DBNull.Value)
				{
					r.Cells["dgrcQntBrought"].Value = 0;
				}
				else
				{
					if (!(bool)r.Cells["dgrcChanged"].Value)
					{
						if (RFMMessage.MessageBoxYesNo("���������� ������������� ������ ������ ���������� ������������ ������!\n���-���� ���������?") != DialogResult.Yes)
						{
							r.Cells["dgrcQntBrought"].Value = r.Cells["dgrcQntConfirmed"].Value;
						}
					}
				}
			}

			if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcBoxBrought" &&
					!(bool)r.Cells["dgrcWeighting"].Value &&
					(r.Cells["dgrcBoxBrought"].Value == null || r.Cells["dgrcBoxBrought"].Value == DBNull.Value ||
					((decimal)r.Cells["dgrcBoxBrought"].Value > (decimal)r.Cells["dgrcBoxConfirmed"].Value))
					)
			{
				if (r.Cells["dgrcBoxBrought"].Value == null || r.Cells["dgrcBoxBrought"].Value == DBNull.Value)
				{
					r.Cells["dgrcBoxBrought"].Value = 0;
				}
				else
				{
					//RFMMessage.MessageBoxError("������� ����� ������ �����������!");
					//r.Cells["dgrcBoxBrought"].Value = r.Cells["dgrcBoxConfirmed"].Value;
					if (!(bool)r.Cells["dgrcChanged"].Value)
					{
						if (RFMMessage.MessageBoxYesNo("����� ������������ ������� ������ ����� ����������� �������!\n���-���� ���������?") != DialogResult.Yes)
						{
							r.Cells["dgrcQntBrought"].Value = r.Cells["dgrcQntConfirmed"].Value;
						}
					}
				}
			}

			if (dgvOutputsDocumentsGoods.Columns[e.ColumnIndex].Name == "dgrcVat")
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

			dgvOutputsDocumentsGoods.Refresh();
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
			if (!chkDocumentsOK.Checked)
			{
				if (txtNoteExecute.Text.Trim().Length == 0)
				{
					RFMMessage.MessageBoxError("�� ���������� ������� \"��������� � �������\".\n" +
						"������� ���������� � ����������!");
					txtNoteExecute.Select();
					return; 
				}
			}

			StringBuilder sbZero = new StringBuilder("");
			int nZero = 0, nZeroSaid = 0;
			StringBuilder sbDiff = new StringBuilder("");
			int nDiff = 0, nDiffSaid = 0;
			StringBuilder sbReturnZero = new StringBuilder("");
			int nReturnZero = 0, nReturnZeroSaid = 0;
			StringBuilder sbReturnDiff = new StringBuilder("");
			int nReturnDiff = 0, nReturnDiffSaid = 0;
			int nReturnFirstID = -1;
			int nLimit = 10; // max ����� ������� ��� ������ �������
			foreach (DataRow droOutGoods in oOutputDocument.TableOutputsDocumentsGoods.Rows)
			{
				if ((decimal)droOutGoods["QntBrought"] == 0)
				{
					if ((decimal)droOutGoods["QntConfirmed"] > 0)
					{
						if (nZero < nLimit)
						{
							sbZero = sbZero.Append(droOutGoods["GoodAlias"].ToString() + "\n");
							nZeroSaid++;
						}
						nZero++;

						if (droOutGoods["ReturnReasonID"] == null || droOutGoods["ReturnReasonID"] == DBNull.Value)
						{
							if (nReturnZero < nLimit)
							{
								sbReturnZero = sbReturnZero.Append(droOutGoods["GoodAlias"].ToString() + "\n");
								nReturnZeroSaid++;
							}
							nReturnZero++;

							if (nReturnFirstID < 0)
								nReturnFirstID = (int)droOutGoods["ID"];
						}
					}
				}
				else
				{
					if ((decimal)droOutGoods["QntBrought"] != (decimal)droOutGoods["QntConfirmed"])
					{
						if (nDiff < nLimit)
						{
							sbDiff = sbDiff.Append(droOutGoods["GoodAlias"].ToString() + "\n");
							nDiffSaid++;
						}
						nDiff++;

						if (droOutGoods["ReturnReasonID"] == null || droOutGoods["ReturnReasonID"] == DBNull.Value)
						{
							if (nReturnDiff < nLimit)
							{
								sbReturnDiff = sbReturnDiff.Append(droOutGoods["GoodAlias"].ToString() + "\n");
								nReturnDiffSaid++;
							}
							nReturnDiff++;

							if (nReturnFirstID < 0)
								nReturnFirstID = (int)droOutGoods["ID"];
						}
					}
				}
			}

			if (nZero > 0)
			{
				if (nZero == oOutputDocument.TableOutputsDocumentsGoods.Rows.Count)
				{
					if (RFMMessage.MessageBoxYesNo("�� ���� ����� �� ��������� ����������.\n\n" +
						"���-���� ����������� �������� ������?") == DialogResult.No)
						return;
				}
				else
				{
					if (nZero - nZeroSaid > 0)
					{
						sbZero = sbZero.Append("� ��� " + RFMUtilities.Declen(nZero - nZeroSaid, "�����", "������", "�������") + "\n");
					}
					if (RFMMessage.MessageBoxYesNo("��������� ������:\n" + sbZero + "�� ���������� ����������.\n\n" +
						"���-���� ����������� �������� ������?") == DialogResult.No)
						return;
				}
			}

			if (nDiff > 0)
			{
				if (nDiff - nDiffSaid > 0)
				{
					sbDiff = sbDiff.Append("� ��� " + RFMUtilities.Declen(nDiff - nDiffSaid, "������", "�������", "�������") + "\n");
				}
				if (RFMMessage.MessageBoxYesNo("��� ��������� �������:\n" + sbDiff + "������������ ���������� �� ����� ������������.\n\n" +
					"���-���� ����������� �������� ������?") == DialogResult.No)
					return;
			}

			// ������� �������� 
			if (nReturnZero > 0)
			{
				if (nReturnZero == oOutputDocument.TableOutputsDocumentsGoods.Rows.Count)
				{
					/*
					if (RFMMessage.MessageBoxYesNo("�� ���� ����� �� ��������� ����������,\n" + 
						"�� ��� ������ ������ �� ������� ������� ��������.\n\n" +
						"������� ������ �� ��� ��������!\n\n" + 
						"���-���� ����������� �������� ������?") == DialogResult.No)
						return;
					 */
					RFMMessage.MessageBoxError("�� ���� ����� �� ��������� ����������,\n" +
						"�� ��� ������ ������ �� ������� ������� ��������.\n\n" +
						"������� ������ �� ��� ��������!\n\n" +
						"������������� �������� ������ �� �����������!");
					return;
				}
				else
				{
					if (nReturnZero - nReturnZeroSaid > 0)
					{
						sbReturnZero = sbReturnZero.Append("� ��� " + RFMUtilities.Declen(nReturnZero - nReturnZeroSaid, "�����", "������", "�������") + "\n");
					}
					/*
					if (RFMMessage.MessageBoxYesNo("��������� ������:\n" + sbReturnZero + "�� ���������� ���������� �\n" +
						"��� ��� �� ������� ������� ��������.\n\n" +
						"���-���� ����������� �������� ������?") == DialogResult.No)
						return;
					*/
					RFMMessage.MessageBoxError("��������� ������:\n" + sbReturnZero + "�� ���������� ���������� �\n" +
						"��� ��� �� ������� ������� ��������.\n\n" +
						"������������� �������� ������ �� �����������!");

					if (nReturnFirstID >= 0)
					{
						int nGridPosition = ((RFMBindingSource)dgvOutputsDocumentsGoods.GridSource).Find("ID", nReturnFirstID);
						if (nGridPosition >= 0)
							dgvOutputsDocumentsGoods.GridSource.Position = nGridPosition;
					}
					return;
				}
			}

			if (nReturnDiff > 0)
			{
				if (nReturnDiff - nReturnDiffSaid > 0)
				{
					sbReturnDiff = sbReturnDiff.Append("� ��� " + RFMUtilities.Declen(nReturnDiff - nReturnDiffSaid, "������", "�������", "�������") + "\n");
				}
				/*
				if (RFMMessage.MessageBoxYesNo("��� ��������� �������:\n" + sbReturnDiff + "������������ ���������� �� ����� ������������ �\n" + 
					"� �� ������� ������� ��������.\n\n" +
					"���-���� ����������� �������� ������?") == DialogResult.No)
					return;
				*/ 
				RFMMessage.MessageBoxError("��� ��������� �������:\n" + sbReturnDiff + "������������ ���������� �� ����� ������������ �\n" +
					"� �� ������� ������� �������������� ������������ � ������������� ����������.\n\n" + 
					"������������� �������� ������ �� �����������!");

				if (nReturnFirstID >= 0)
				{
					int nGridPosition = ((RFMBindingSource)dgvOutputsDocumentsGoods.GridSource).Find("ID", nReturnFirstID);
					if (nGridPosition >= 0)
						dgvOutputsDocumentsGoods.GridSource.Position = nGridPosition;
				}
				return;
			}

			/*
			// �� ���-�� �����
			if (numGetMoneyWished.Value != numGetMoneyConfirmed.Value)
			{
				if (RFMMessage.MessageBoxYesNo("�� ��������� �����:\n" +
					"��������� (" + numGetMoneyWished.Value.ToString("### ### ##0.00").Trim() + ") � ���������� (" + numGetMoneyConfirmed.Value.ToString("### ### ##0.00").Trim() + ").\n\n" +
					"���-���� ����������� �������� ������?") == DialogResult.No)
					return;
			}
			if (numGetMoneyWished.Value != 0 && numGetMoneyConfirmed.Value == 0 &&
				!chkIsWarrantReturned.Checked)
			{
				if (RFMMessage.MessageBoxYesNo("�� ������� ���������� �����,\n" +
					"�� ������� �����, ��� ������������ ����������.\n\n" + 
					"���-���� �����������?") == DialogResult.No)
					return;
			}
			if (numGetMoneyConfirmed.Value != 0 &&
				chkIsWarrantReturned.Checked)
			{
				if (RFMMessage.MessageBoxYesNo("������� ���������� �����,\n" +
					"������� �����, ��� ������������ ����������.\n\n" +
					"���-���� �����������?") == DialogResult.No)
					return;
			}
			*/
 
			// �� ��������
			if (numGetPalletsQntWished.Value != numGetPalletsQntConfirmed.Value)
			{
				if (RFMMessage.MessageBoxYesNo("�� ��������� ���������� ������:\n" +
					"��������� (" + numGetPalletsQntWished.Value.ToString("#####0").Trim() + ") � ���������� (" + numGetPalletsQntConfirmed.Value.ToString("#####0").Trim() + ").\n\n" +
					"���-���� ����������� �������� ������?") == DialogResult.No)
					return;
			}

			// ���������. ��� ���������

			if (true) // (RFMMessage.MessageBoxYesNo("����������� �������� ������ ����������?") == DialogResult.Yes)
			{
				oOutputDocument.NoteExecute = txtNoteExecute.Text.Trim();
				oOutputDocument.DocumentsOK = chkDocumentsOK.Checked; 
				/*
				oOutputDocument.GetMoneyConfirmed = numGetMoneyConfirmed.Value;
				oOutputDocument.IsWarrantReturned = chkIsWarrantReturned.Checked;
				*/
				oOutputDocument.GetPalletsQntConfirmed = (int)numGetPalletsQntConfirmed.Value;

				// ���������. ���������.
				Refresh();
				WaitOn(this);
				oOutputDocument.ClearError();
				bool bResult = oOutputDocument.Bring(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID);
				WaitOff(this);
				if (bResult && oOutputDocument.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("���������������� �������� ������ ����������.");
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		private void CalcTotal()
		{
			decimal nAmount = 0;
			decimal nQnt = 0;
			decimal nBox = 0;
			int nStrikesCnt = 0;
			foreach (DataRow r in oOutputDocument.TableOutputsDocumentsGoods.Rows)
			{
				if (r["QntBrought"] == null || r["QntBrought"] == DBNull.Value)
					r["QntBrought"] = 0;
				if (r["BoxBrought"] == null || r["BoxBrought"] == DBNull.Value)
					r["BoxBrought"] = 0;

				nQnt += (decimal)r["QntBrought"];
				nBox += (decimal)r["BoxBrought"];
				nAmount += (decimal)r["QntBrought"] * (decimal)r["Price"];
				if ((decimal)r["QntBrought"] < (decimal)r["QntConfirmed"])
				{
					nStrikesCnt++;
				}
			}
			lblTotalAmount.Text = nAmount.ToString("### ### ##0.00").Trim();
			lblTotalQnt.Text = nQnt.ToString("### ### ##0").Trim();
			lblTotalBox.Text = nBox.ToString("# ### ##0.0").Trim();
			lblTotalStrikesCnt.Text = nStrikesCnt.ToString("###0").Trim();
		}

		private void chkIsWarrantReturned_CheckedChanged(object sender, EventArgs e)
		{
			numGetMoneyConfirmed.Enabled = !chkIsWarrantReturned.Checked;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_SelectedPackingID = null;

			//if (StartForm(new frmSelectOnePacking(this, false, nOwnerID)) == DialogResult.Yes)
			if (StartForm(new frmSelectOnePacking(this, false, null, oOutputDocument.HostID)) == DialogResult.Yes)
			{
				if (_SelectedPackingID != null)
				{
					// ���������, ��� �� ��� ����� ������
					foreach (DataRow r in oOutputDocument.TableOutputsDocumentsGoods.Rows)
					{
						if (Convert.ToInt32(r["PackingID"]) == _SelectedPackingID)
						{
							dgvOutputsDocumentsGoods.GridSource.Position = dgvOutputsDocumentsGoods.GridSource.Find("PackingID", _SelectedPackingID);
							if (dgvOutputsDocumentsGoods.GridSource.Position < 0)
							{
								dgvOutputsDocumentsGoods.GridSource.MoveFirst();
							}
							return;
						}
					}

					Good oGood = new Good(); 
					oGood.PackingID = _SelectedPackingID;
					oGood.FillDataAsync();
					// ��������� �����
					DataRow rg = oGood.MainTable.Rows[0];
					// ��������� ����� ������ ��� ���������� ������
					DataRow dr = oOutputDocument.TableOutputsDocumentsGoods.Rows.Add(-1, -1);
					dr["Changed"] = true;
					dr["PackingID"] = _SelectedPackingID;
					dr["GoodID"] = rg["GoodID"];
					dr["QntWished"] =
					dr["BoxWished"] =
					dr["QntConfirmed"] =
					dr["BoxConfirmed"] =
					dr["QntBrought"] =
					dr["BoxBrought"] =
					dr["Price"] =
					dr["Vat"] =
					dr["PriceNoVat"] =
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

					RFMMessage.MessageBoxAttention("�� �������� ������ ���� � ��� ��� ������������ ������!");

					// � ������ �� ��� ������
					dgvOutputsDocumentsGoods.GridSource.Position = dgvOutputsDocumentsGoods.GridSource.Find("PackingID", _SelectedPackingID);
					if (dgvOutputsDocumentsGoods.GridSource.Position < 0)
					{
						dgvOutputsDocumentsGoods.GridSource.MoveFirst();
					}
					// ������ �� ��������� ������, � ������ "������� ����."
					dgvOutputsDocumentsGoods.CurrentCell = dgvOutputsDocumentsGoods.Rows[dgvOutputsDocumentsGoods.GridSource.Position].Cells["dgrcBoxBrought"];
				}

				_SelectedPackingID = null;
				_SelectedPackingAliasText = null;
			}
		}

		private void btnReturnReason_Click(object sender, EventArgs e)
		{
			if (dgvOutputsDocumentsGoods.CurrentRow == null)
				return;

			DataRow rGoodCurrent = ((DataRowView)dgvOutputsDocumentsGoods.CurrentRow.DataBoundItem).Row;
			if (rGoodCurrent == null)
				return;

			bool bMarked = dgvOutputsDocumentsGoods.IsCheckerShow && dgvOutputsDocumentsGoods.MarkedCount > 0;
			int nMarkedReturned = 0;
			if (bMarked)
			{
				foreach (DataRow rGood in oOutputDocument.TableOutputsDocumentsGoods.Rows)
				{
					if ((bool)rGood["IsMarked"])
					{
						/*
						if (!(bool)rGood["Weighting"] && (decimal)rGood["QntConfirmed"] > (decimal)rGood["QntBrought"] ||
							(bool)rGood["Weighting"] && (decimal)rGood["QntConfirmed"] - (decimal)rGood["QntBrought"] > 1)
						*/
						if ((decimal)rGood["QntConfirmed"] != (decimal)rGood["QntBrought"])
						{
							nMarkedReturned++;
						}
					}
				}
				if (nMarkedReturned == 0)
				{
					RFMMessage.MessageBoxError("�������������� � ����������� � ������������ ���������� ��� ���������� ������� �� �������������...");
					return;
				}
			}
			else
			{
				if ((decimal)rGoodCurrent["QntBrought"] == (decimal)rGoodCurrent["QntConfirmed"])
				{
					RFMMessage.MessageBoxError("�������������� � ����������� � ������������ ���������� ������ �� �������������...");
					return;
				}
			}

			// ������� ������� �������� ������
			if (oOutputDocument.TableReturnsReasons == null)
			{
				oOutputDocument.FillTableReturnsReasons();
				if (oOutputDocument.ErrorNumber != 0)
				{
					RFMMessage.MessageBoxError("������ ��� ��������� ��������� ������ �������������� ������������ � ������������� ���������� ������...");
					oOutputDocument.ClearError();
					return;
				}
			}

			if (StartForm(new frmSelectID(this, oOutputDocument.TableReturnsReasons, "Name,GuiltyName", "������� �������������� ����������,��������", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
					return;

				int nReturnReasonID = (int)_SelectedID;

				DataRow rReturnReason = oOutputDocument.TableReturnsReasons.Rows.Find(nReturnReasonID);
				if (rReturnReason != null)
				{
					if (!bMarked)
					{
						rGoodCurrent["ReturnReasonID"] = nReturnReasonID;
						rGoodCurrent["ReturnReasonName"] = _SelectedText;
						rGoodCurrent["GuiltyID"] = rReturnReason["GuiltyID"];
						rGoodCurrent["GuiltyName"] = rReturnReason["GuiltyName"];
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("���������� ������� �������������� ������������ � ������������� ���������� ��� ���� ���������� ������� � ���������������� (" + nMarkedReturned.ToString().Trim() + ")?") != DialogResult.Yes)
							return;

						foreach (DataRow rGood in oOutputDocument.TableOutputsDocumentsGoods.Rows)
						{
							if ((bool)rGood["IsMarked"])
							{
								/*
								if (!(bool)rGood["Weighting"] && (decimal)rGood["QntConfirmed"] > (decimal)rGood["QntBrought"] ||
									(bool)rGood["Weighting"] && (decimal)rGood["QntConfirmed"] - (decimal)rGood["QntBrought"] > 1)
								*/
								if ((decimal)rGood["QntConfirmed"] != (decimal)rGood["QntBrought"])
								{
									rGood["ReturnReasonID"] = nReturnReasonID;
									rGood["ReturnReasonName"] = _SelectedText;
									rGood["GuiltyID"] = rReturnReason["GuiltyID"];
									rGood["GuiltyName"] = rReturnReason["GuiltyName"];
								}
							}
						}
					}
				}
			}
			_SelectedID = null;
			_SelectedText = "";
		}

		private void frmOutputsDocumentsBring_KeyDown(object sender, KeyEventArgs e)
		{
			if (btnAdd.Enabled &&
				e.KeyCode == Keys.N && e.Modifiers == Keys.Control)
			{
				btnAdd_Click(null, null);
				return;
			}

			if (btnReturnReason.Enabled &&
				e.KeyCode == Keys.R && e.Modifiers == Keys.Control)
			{
				btnReturnReason_Click(null, null);
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
