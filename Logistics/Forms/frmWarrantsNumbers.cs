using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics
{
	public partial class frmWarrantsNumbers : RFMFormChild
	{
		private WarrantNumber oWarrantList; //������ �������������
		private WarrantNumber oWarrantCur; //������� ������������

		// ��� ��������
		public string _SelectedIDList;
		public string _SelectedText;

		private string sSelectedPartnersSourceIDList = "";
		private string sSelectedPartnersTargetIDList = "";
		private string sSelectedEmployeesIDList = "";

		public frmWarrantsNumbers()
		{
			oWarrantList = new WarrantNumber();
			oWarrantCur = new WarrantNumber();
			if (oWarrantList.ErrorNumber != 0 ||
				oWarrantCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmWarrantsNumbers_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			btnClearTerms_Click(null, null);

			tcList.Init();

			RFMCursorWait.Set(false);
		}

	#region Tab Restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled = 
			btnEdit.Enabled =
			btnDelete.Enabled = 
			btnConfirm.Enabled =
			btnPrint.Enabled =
			btnService.Enabled =
				false;
			return true;
		}

		private bool tabData_Restore()
		{
			grdData_Restore();
			btnAdd.Enabled = false; // �� ���.
			if (grdData.Rows.Count > 0)
			{
				btnEdit.Enabled = false; // �� ���.
				btnConfirm.Enabled = false; // �� ���.
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				grdData.Select();
			}
			else
			{
				btnEdit.Enabled = 
				btnConfirm.Enabled = 
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			return (true);
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled = 
				btnDelete.Enabled =
				btnConfirm.Enabled = 
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("DATA"))
			{
				grdData.Select();

				btnAdd.Enabled = false; // �� ���. 
				if (grdData.Rows.Count > 0 && grdData.CurrentRow != null)
				{
					btnPrint.Enabled =
					btnService.Enabled =
						true;

					if (!tabData.IsNeedRestore)
					{
						if (!grdData.IsStatusRow(grdData.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdData.CurrentRow.DataBoundItem).Row;
							oWarrantCur.ID = Convert.ToInt32(r["ID"]);
							SetButtonStatus(r);
						}
					}
				}
			}
		}

	#endregion Tab restore

	#region RowEnter, CellFormatting

		private void grdData_CurrentRowChanged(object sender)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;
			if (grd.IsStatusRow(rowIndex))
			{
				oWarrantCur.ClearOne();
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			else
			{
				DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
				oWarrantCur.FillOne(r);
				SetButtonStatus(r);
			}
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			string sGridName = grd.Name.ToUpper();

			if (grd.DataSource == null)
				return;

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();
			if (sColumnName.Contains("IsMoney".ToUpper()))
			{
				if ((bool)r["IsMoney"])
				{
					e.Value = Properties.Resources.Edit_coin;
				}
				else
				{
					e.Value = Properties.Resources.Box_full;
				}
			}
			if (c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

	#endregion Cells...

	#region SetButtonStatus

		private void SetButtonStatus(DataRow r)
		{
			if (r == null)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnConfirm.Enabled = 
					false;
				return;
			}

			// �� ��������� �� ������ r ����� ���������� ����������� ������
			btnEdit.Enabled = // �� ���.
			btnConfirm.Enabled = // �� ���.
				false; 
			btnDelete.Enabled =  
			btnPrint.Enabled =
			btnService.Enabled =
				true;
			return;
		}

	#endregion SetButtonStatus

	#region Restore

		private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oWarrantCur.ClearOne();

			oWarrantList.ClearError();
			oWarrantList.ClearFilters();
			oWarrantList.ID = null;
			oWarrantList.IDList = null;

			// �������� �������

			// ����
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oWarrantList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oWarrantList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// ����� ��������
			if (txtWarrantNumberContext.Text.Trim().Length > 0)
			{
				oWarrantList.FilterNumberContext = txtWarrantNumberContext.Text.Trim();
			}

			// ������ /�����
			if (optIsMoney.Checked)
			{
				oWarrantList.FilterIsMoney = true;
			}
			if (optIsMoneyNot.Checked)
			{
				oWarrantList.FilterIsMoney = false;
			}

			// �������
			if (sSelectedPartnersSourceIDList.Length > 0)
			{
				oWarrantList.FilterPartnersSourceList = sSelectedPartnersSourceIDList;
			}
			if (sSelectedPartnersTargetIDList.Length > 0)
			{
				oWarrantList.FilterPartnersTargetList = sSelectedPartnersTargetIDList;
			}

			// ����������
			if (sSelectedEmployeesIDList.Length > 0)
			{
				oWarrantList.FilterEmployeesList = sSelectedEmployeesIDList;
			}
			if (txtDeputyName.Text.Trim().Length > 0)
			{
				oWarrantList.FilterDeputyNameContext = txtDeputyName.Text.Trim();
			}

			// �������
			if (optIsReturned.Checked)
			{
				oWarrantList.FilterIsReturned = true;
			}
			if (optIsReturnedNot.Checked)
			{
				oWarrantList.FilterIsReturned = false;
			}

			// ���� ������� �� ��������/��������

			//

			grdData.GetGridState();

			oWarrantList.FillDataAsync();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oWarrantList.MainTable);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oWarrantList.ErrorNumber == 0);
		}

	#endregion Restore

	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// �� ���.
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			// �� ���.
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			// �� ���.
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (tcList.CurrentPage.Name.ToUpper().Contains("DATA"))
			{
				if (grdData.CurrentRow == null)
					return;
				if (!oWarrantCur.ID.HasValue)
					return;

				// ����������
				oWarrantCur.ReFillOne((int)oWarrantCur.ID);

				// ��������
				if (oWarrantCur.DateReturn != null)
				{
					RFMMessage.MessageBoxError("��������������� ������� ������������...\n�������� �� �����������.");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("������� ������������?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oWarrantCur.Delete((int)oWarrantCur.ID);
					WaitOff(this);
					if (bResult && oWarrantCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("������������ �������.");
					}
					else
					{
						RFMMessage.MessageBoxError("������ ��� �������� ������������...");
					}
					grdData_Restore();
				}
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

	#endregion
		
	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

	#endregion Menu Print

	#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}

		private void mniWarrantsAnalysis_Click(object sender, EventArgs e)
		{
			WarrantsAnalysis();
		}

		private void mniWarrantsReturn_Click(object sender, EventArgs e)
		{
			WarrantsReturn(true);
		}

		private void mniWarrantsUnReturn_Click(object sender, EventArgs e)
		{
			WarrantsReturn(false);
		}


		private void WarrantsAnalysis()
		{
			// ������������ ������������� �� ������
			DateTime dDateBeg = DateTime.Now.Date;
			DateTime dDateEnd = DateTime.Now.Date.AddMonths(-1);
			if (StartForm(new frmDateRange(dDateBeg, dDateEnd)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
					dDateBeg = (DateTime)GotParam[0];
				else
					dDateBeg = Convert.ToDateTime("01.01.1900");

				if (GotParam[1] != null)
					dDateEnd = (DateTime)GotParam[1];
				else
					dDateEnd = Convert.ToDateTime("31.12.2099");
			}

			WarrantNumber oWarrantAnalysis = new WarrantNumber();
			oWarrantAnalysis.FilterDateBeg = dDateBeg;
			oWarrantAnalysis.FilterDateEnd = dDateEnd;
			oWarrantAnalysis.FillDataAsync();
			if (oWarrantAnalysis.ErrorNumber != 0 || oWarrantAnalysis.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ������� ������ �������������...");
				return;
			}
			if (oWarrantAnalysis.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ � ������������� �� ������...");
				return;
			}

			WaitOn(this);

			string sEol = Environment.NewLine;

			OutputDocument oOutputDocument = new OutputDocument();
			InputDocument oInputDocument = new InputDocument();

			DataTable dtWarrant = CopyTable(oWarrantAnalysis.MainTable, "dtWarrant", "", "PartnerSourceID, NumberInt, Number, DateIssue");

			string sText = "������ ������� ������ ������������� �� ������ " + dDateBeg.ToString("dd.MM.yyyy") + " - " + dDateEnd.ToString("dd.MM.yyyy") + 
				sEol;

			int nPartnerSourceID = -1;
			int nNumberInt = -1;
			int nNumberIntOld = -1;
			string sNumber = "";
			bool bOK = true; 
			foreach(DataRow rW in dtWarrant.Rows)
			{
				oWarrantAnalysis.FillOne(rW);

				// ����� �������
				if (nPartnerSourceID != oWarrantAnalysis.PartnerSourceID)
				{
					sText += sEol + 
						"������������ ������ ������: " + oWarrantAnalysis.PartnerSourceName +
						sEol;
					nPartnerSourceID = oWarrantAnalysis.PartnerSourceID;

					nNumberInt = -1;
					nNumberIntOld = -1;
					sNumber = "";
					bOK = true; 
				}

				nNumberInt = oWarrantAnalysis.NumberInt; 
				sNumber = oWarrantAnalysis.Number; 

				// ���������
				if (nNumberIntOld != -1)
				{
					if (nNumberInt == nNumberIntOld)
					{
						sText += sNumber + "(" + nNumberInt.ToString().Trim() + "): ������������ � ���������� ���������� �������" + 
							sEol;
						bOK = false;
					}
					if (nNumberInt != nNumberIntOld + 1)
					{
						sText += sNumber + " (" + nNumberIntOld.ToString() + " - " + nNumberInt.ToString().Trim() + "): ������� � ���������� ������� �������������" +
							sEol;
						bOK = false;
					}
				}

				// ������

				// ����� �� �������� 
				if (oWarrantAnalysis.OutputDocumentID.HasValue)
				{
					oOutputDocument.ID = (int)oWarrantAnalysis.OutputDocumentID;
					oOutputDocument.FillDataAsync();
					if (oOutputDocument.MainTable.Rows.Count == 0)
					{
						sText += sNumber + ": �� ������ ����� �� �������� � ����� " + oWarrantAnalysis.OutputDocumentID + 
							sEol;
						bOK = false;
					}
					else
					{
						oOutputDocument.FillOne();
						// ������
						if (oOutputDocument.WarrantNumber != sNumber)
						{
							sText += sNumber + ": �� ��������� ������ ������������� � ������� � � ������ �� �������� (" + oOutputDocument.WarrantNumber.ToString().Trim() + ")" + 
								sEol;
							bOK = false;
						}
						// 
						if (oOutputDocument.IsWarrantReturned && !oWarrantAnalysis.IsReturned)
						{
							sText += sNumber + ": � ������ �� �������� ������������ ����������, � ������� ���" + 
								sEol;
							bOK = false;
						}
						if (!oOutputDocument.IsWarrantReturned && oWarrantAnalysis.IsReturned)
						{
							sText += sNumber + ": � ������� ������������ ����������, � ������ �� �������� ���" +
								sEol;
							bOK = false;
						}
						if (oWarrantAnalysis != null && oWarrantAnalysis.CurrencyID != null &&
							(oOutputDocument.GetMoneyConfirmed != oWarrantAnalysis.Amount ||
							 oOutputDocument.GetCurrencyID != oWarrantAnalysis.CurrencyID))
						{
							sText += sNumber + ": �����/������ � ������� (" + ((decimal)oWarrantAnalysis.Amount).ToString("#####0.00") + oWarrantAnalysis.CurrencyName +
								") � � ������ �� �������� (" + oOutputDocument.GetMoneyConfirmed.ToString("#####0.00") + oOutputDocument.GetCurrencyName + ") �� ���������" + 
								sEol;
							bOK = false;
						}
					}
				}

				// ����� �� �������� 
				if (oWarrantAnalysis.InputDocumentID.HasValue)
				{
					oInputDocument.ID = (int)oWarrantAnalysis.InputDocumentID;
					oInputDocument.FillDataAsync();
					if (oInputDocument.MainTable.Rows.Count != 1)
					{
						sText += sNumber + ": �� ������ ����� �� �������� � ����� " + oWarrantAnalysis.InputDocumentID + 
							sEol;
						bOK = false;
					}
					else
					{
						oInputDocument.FillOne();
						// ������
						if (oInputDocument.WarrantNumber != sNumber)
						{
							sText += sNumber + ": �� ��������� ������ ������������� � ������� � � ������ �� �������� (" + oInputDocument.WarrantNumber.ToString().Trim() + ")" + 
								sEol;
							bOK = false;
						}
					}
				}
				// �������� ����������, ��������� � ��������� ������������ � ������

				nNumberIntOld = (int)rW["NumberInt"];
			}
			if (bOK)
			{
				sText += "OK" + sEol;
			}

			// ������ ������ ������� 

			// ������ �� �������� 
			bOK = true;
			oOutputDocument.FilterDateBeg = dDateBeg;
			oOutputDocument.FilterDateEnd = dDateEnd;
			oOutputDocument.FillDataAsync();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ������� ������ ������� �� ��������...");
			}
			else
			{
				if (oOutputDocument.MainTable.Rows.Count > 0)
				{
					sText += sEol + 
						"������ ������ ������� �� ��������: " + 
						sEol;

					string sOutputDocument = ""; 
					foreach (DataRow rO in oOutputDocument.MainTable.Rows)
					{ 
						oOutputDocument.FillOne();
						sOutputDocument = oOutputDocument.ID.ToString().Trim();
						sNumber = oOutputDocument.WarrantNumber;
						if (sNumber == null) sNumber = ""; 

						// ������� ������������ 
						if (oOutputDocument.IsConfirmed)
						{
							if (oOutputDocument.PF_WarrantNeed && sNumber.Length == 0)
							{
								sText += sOutputDocument + ": �� ��������� ����� ������������ ��� ������, ��� ��������� ������������" + 
									sEol;
								bOK = false;
							}
						}
						if (!oOutputDocument.PF_WarrantNeed && sNumber.Length > 0)
						{
							sText += sOutputDocument + ": ��������� ����� ������������ (" + sNumber + ") ��� ������, ��� �� ��������� ������������" +
								sEol;
							bOK = false;
						}

						if (oOutputDocument.PF_WarrantNeed && sNumber.Length > 0)
						{
							oWarrantAnalysis.FilterOutputsDocumentsList = sOutputDocument;
							oWarrantAnalysis.FillDataAsync();
							if (oWarrantAnalysis.MainTable.Rows.Count == 0)
							{
								sText += sOutputDocument + ": � ������� �� ������� ������������ (" + sNumber + ") ��� ������" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.MainTable.Rows.Count > 1)
							{
								sText += sOutputDocument + ": � ������� ������� ��������� ������������� ��� ������ (" + sNumber + ")" + 
									sEol;
								bOK = false;
							}

							oWarrantAnalysis.FilterNumberContext = sNumber;
							oWarrantAnalysis.FilterPartnersSourceList = oOutputDocument.PartnerSourceID.ToString();
							oWarrantAnalysis.FilterDateBeg = oOutputDocument.DateOutput.AddDays(-10);
							oWarrantAnalysis.FilterDateEnd = oOutputDocument.DateOutput.AddDays(10);
							oWarrantAnalysis.FillDataAsync();
							if (oWarrantAnalysis.MainTable.Rows.Count == 0)
							{
								sText += sOutputDocument + ": � ������� �� ������� ������������ �� ������ (" + sNumber + "), ���������� � ������" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.MainTable.Rows.Count > 1)
							{
								sText += sOutputDocument + ": � ������� ������� ��������� ������������� �� ������ (" + sNumber + "), ���������� � ������" + 
									sEol;
								bOK = false;
							}

							oWarrantAnalysis.FillOne();
							if (oWarrantAnalysis.OutputDocumentID != oOutputDocument.ID)
							{
								sText += sOutputDocument + ": � ������� ������� ������������ �� ������ (" + sNumber + "), �� � ��� ������ ������ �����" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.PartnerSourceID != oOutputDocument.PartnerSourceID ||
								oWarrantAnalysis.PartnerTargetID != oOutputDocument.PartnerTargetID)
							{
								sText += sOutputDocument + ": � ������� ������� ������������ �� ������ (" + sNumber + "), �� � ��� ������ ������ ������" + 
									sEol;
								bOK = false;
							}
							if (oWarrantAnalysis.Amount != null && oWarrantAnalysis.CurrencyID != null &&
								((decimal)oWarrantAnalysis.Amount != oOutputDocument.GetMoneyConfirmed ||
								 (int)oWarrantAnalysis.CurrencyID != oOutputDocument.GetCurrencyID) )
							{
								sText += sOutputDocument + ": � ������� ������� ������������ �� ������ (" + sNumber + "), �� � ��� ������� ������ �����" + 
									sEol;
								bOK = false;
							}
						}

						if (!oOutputDocument.PF_WarrantNeed)
						{
							oWarrantAnalysis.FilterOutputsDocumentsList = sOutputDocument;
							if (oWarrantAnalysis.MainTable.Rows.Count > 0)
							{
								sText += sOutputDocument + ": � ������� ������� ������������ (" + oWarrantAnalysis.MainTable.Rows[0]["Number"].ToString() + ") ��� ������, ��� �������� ��� �� ���������" + 
									sEol;
								bOK = false;
							}
						}

						// ��������� � ����.������
					}
					if (bOK)
					{
						sText += "OK";
					}
				}
			}

			// ����� ������ ���� ����������� �������� ��� ������� �� �������� InputsDocuments
			bOK = true; 

			// ������� �����
			WaitOff(this);
			StartForm(new frmSysTextReport(sText));

			/*
			string sFileName = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserLocPath + "WarrantsAnalysis.txt";
			File.AppendAllText(sFileName, sText, Encoding.Default);
			StartForm(new frmSysTextReport(true, sFileName)); 
			*/
		}

		private void WarrantsReturn(bool bReturn)
		{
			if (grdData.CurrentRow == null)
				return;
			if (!oWarrantCur.ID.HasValue)
				return;

			// ����������
			oWarrantCur.ReFillOne((int)oWarrantCur.ID);

			if (bReturn)
			{
				// ��������
				if (oWarrantCur.DateReturn != null)
				{
					RFMMessage.MessageBoxError("������������ ��� ����������...");
					return;
				}
				// 

				if (RFMMessage.MessageBoxYesNo("�������� ������� ������������?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oWarrantCur.Return((int)oWarrantCur.ID);
					WaitOff(this);
					if (bResult && oWarrantCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("������������ ������� ������������.");
					}
					grdData_Restore();
				}
			}
			else
			{
				// ��������
				if (oWarrantCur.DateReturn == null)
				{
					RFMMessage.MessageBoxError("������������ �� ���� ����������...");
					return;
				}
				// 

				if (RFMMessage.MessageBoxYesNo("����� ������� �������� ������������?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oWarrantCur.UnReturn((int)oWarrantCur.ID);
					WaitOff(this);
					if (bResult && oWarrantCur.ErrorNumber == 0)
					{
						RFMMessage.MessageBoxInfo("������� �������� ������������ �����.");
					}
					grdData_Restore();
				}
			}
		}

	#endregion

	#region Filters Choose

		#region Partners Source

		private void btnPartnersSourceChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oPartner = new Partner();
			oPartner.FillDataAsync();
			if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ (��������)...");
				return;
			}
			if (oPartner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ (��������)...");
				return;
			}

			if (StartForm(new frmSelectID(this, oPartner.MainTable, "Name,Actual", "�����,���.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnPartnersSourceClear_Click(null, null);
					return;
				}

				sSelectedPartnersSourceIDList = "," + _SelectedIDList;

				txtPartnersSourceChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtPartnersSourceChoosen, txtPartnersSourceChoosen.Text);

				tabData.IsNeedRestore = true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnPartnersSourceClear_Click(object sender, EventArgs e)
		{
			tabData.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPartnersSourceChoosen, "�� �������");
			sSelectedPartnersSourceIDList = "";
			txtPartnersSourceChoosen.Text = "";
		}

		#endregion Partners Source

		#region Partners Target

		private void btnPartnersTargetChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oPartner = new Partner();
			oPartner.FillDataAsync();
			if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ (�����������/����������)...");
				return;
			}
			if (oPartner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ (�����������/����������)...");
				return;
			}

			if (StartForm(new frmSelectID(this, oPartner.MainTable, "Name,ZoneName,Actual", "����������/���������,����,���.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnPartnersTargetClear_Click(null, null);
					return;
				}

				sSelectedPartnersTargetIDList = "," + _SelectedIDList;

				txtPartnersTargetChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtPartnersTargetChoosen, txtPartnersTargetChoosen.Text);

				tabData.IsNeedRestore = true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnPartnersTargetClear_Click(object sender, EventArgs e)
		{
			tabData.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtPartnersTargetChoosen, "�� �������");
			sSelectedPartnersTargetIDList = "";
			txtPartnersTargetChoosen.Text = "";
		}

		#endregion Partner Target

		#region Employees

		private void btnEmployeesChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Employee oEmployee = new Employee();
			oEmployee.FillDataAsync();
			if (oEmployee.ErrorNumber != 0 || oEmployee.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ (����������)...");
				return;
			}
			if (oEmployee.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ (����������)...");
				return;
			}

			if (StartForm(new frmSelectID(this, oEmployee.MainTable, "Name,JobName,IsDriver", "���������,���������,���.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnEmployeesClear_Click(null, null);
					return;
				}

				sSelectedEmployeesIDList = "," + _SelectedIDList;
				txtEmployeesChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtEmployeesChoosen, txtEmployeesChoosen.Text);

				tabData.IsNeedRestore = true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnEmployeesClear_Click(object sender, EventArgs e)
		{
			tabData.IsNeedRestore = true;

			ttToolTip.SetToolTip(txtEmployeesChoosen, "�� �������");
			sSelectedEmployeesIDList = "";
			txtEmployeesChoosen.Text = "";
		}

		#endregion Employees

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date.AddDays(-7); 
			dtrDates.dtpEndDate.Value = DateTime.Now.Date.AddDays(1);

			btnPartnersSourceClear_Click(null, null);
			btnPartnersTargetClear_Click(null, null);
			btnEmployeesClear_Click(null, null);

			optIsMoneyAny.Checked = true;
			optIsReturnedAny.Checked = true;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabData.IsNeedRestore = true;
		}

	#endregion Terms clear


    }
}