using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DataDynamics.ActiveReports;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmOutputsDocumentsVeterinaryBlankData : RFMFormChild
	{
		string sOutputsDocumentsList = "";
		int nOutputDocumentID = 0;
		DataTable dt;

		private OutputDocument oOutputDocument;

		public frmOutputsDocumentsVeterinaryBlankData(string _sOutputsDocumentsList)
		{
			if (_sOutputsDocumentsList == null || _sOutputsDocumentsList.Length == 0)
			{
				RFMMessage.MessageBoxError("�������� �����");
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				sOutputsDocumentsList = _sOutputsDocumentsList;

				oOutputDocument = new OutputDocument();
				if (oOutputDocument.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmOutputsDocumentsVeterinaryBlankData_Load(object sender, EventArgs e)
		{
			oOutputDocument.IDList = sOutputsDocumentsList;
			oOutputDocument.FillData();

			// ������ ������� ������
			bool bVeterinaryUpdate = false;
			foreach (DataRow or in oOutputDocument.MainTable.Rows)
			{
				nOutputDocumentID = (int)or["ID"];
				bVeterinaryUpdate = false;

				// ���� ��� �� ��������� �������� �� ���.��-��� - ���������
				oOutputDocument.FillTableOutputsDocumentsGoods(nOutputDocumentID);
				if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.TableOutputsDocumentsGoods == null)
					continue;
				foreach (DataRow odg in oOutputDocument.TableOutputsDocumentsGoods.Rows)
				{
					if (Convert.IsDBNull(odg["GoodVeterinaryID"]))
					{
						bVeterinaryUpdate = true;
						break;
					}
				}
				if (bVeterinaryUpdate)
				{
					oOutputDocument.SetGoodVeterinaryID(nOutputDocumentID, true);
				}
			}

			btnGo_Click(null, null);

			// ��� ����������
			string sVeterinarFio = "";
			if (dt != null && dt.Rows.Count > 0)
			{
				sVeterinarFio = dt.Rows[0]["VeterinarFIO"].ToString();
				if (sVeterinarFio == null || sVeterinarFio.Length == 0)
				{
					User oUser = new User();
					oUser.ReFillOne(((RFMFormMain)Application.OpenForms[0]).UserID);
					Employee oEmployeeVeterinar = new Employee();
					if (oUser.EmployeeID.HasValue)
					{
						oEmployeeVeterinar.ReFillOne((int)oUser.EmployeeID);
						sVeterinarFio = oEmployeeVeterinar.Name;
					}
				}
			}
			txtVeterinarFio.Text = sVeterinarFio;
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			grdData_Restore();
		}

		private bool grdData_Restore()
		{
			oOutputDocument.FillVeterinaryBlankTableOutputsDocumentsGoods(sOutputsDocumentsList, optPartnerGroup.Checked);
			dt = oOutputDocument.TableOutputsDocumentsGoods;
 
			grdData.Restore(dt);
			return (true);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string sOutputsDocumentsList = "";
			int nOutputDocumentID = 0;

			// ���������, ��� ����� ����� � ������ ��� ������������� 
			foreach (DataGridViewRow dr in grdData.Rows)
			{
				if (Convert.ToBoolean(dr.Cells["grcIsPrinted"].Value) &&
					(dr.Cells["grcVeterinaryBlankSeries"].Value.ToString().Length == 0 ||
					 dr.Cells["grcVeterinaryBlankNumber"].Value.ToString().Length == 0))
				{
					if (RFMMessage.MessageBoxYesNo("��� �������� \"" + dr.Cells["gr�PartnerTargetName"].Value.ToString() + "\" �� ������� �����/����� ������!\n\n" + 
						"����������?") != DialogResult.Yes)
						return;
				}
			}

			RFMCursorWait.Set(true);
			foreach (DataRow dr in dt.Rows)
			{
				// nOutputDocumentID = (int)dr["OutputDocumentID"];
				sOutputsDocumentsList = dr["OutputsDocumentsListID"].ToString();
				string[] sOutputsDocumentsIDSplit = sOutputsDocumentsList.Split(new char[] { ',' });
				foreach (string s in sOutputsDocumentsIDSplit)
				{
					if (s.Length == 0)
						continue;
					nOutputDocumentID = Convert.ToInt32(s);
					oOutputDocument.SaveVeterinaryBlankData(nOutputDocumentID,
						dr["VeterinaryBlankSeries"].ToString(),
						dr["VeterinaryBlankNumber"].ToString(), 
                        "", 
                        ((RFMFormMain)Application.OpenForms[0]).UserID);
				}
			}
			RFMCursorWait.Set(false);

			// 
			DialogResult = DialogResult.Yes;
			Dispose();
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0 ||
				grdData.CurrentRow == null)
				return;

			DataRow dr = ((DataRowView)((DataGridViewRow)grdData.Rows[grdData.CurrentRow.Index]).DataBoundItem).Row;
			//int nOutputDocumentID = (int)dr["OutputDocumentID"];
			int nPartnerTargetID = (int)dr["PartnerTargetID"];
			string sVeterinaryBlankSeries = dr["VeterinaryBlankSeries"].ToString();
			string sVeterinaryBlankNumber = dr["VeterinaryBlankNumber"].ToString();

			foreach (DataRow o in dt.Rows)
			{
				if (nPartnerTargetID == (int)o["PartnerTargetID"])
				{
					o["VeterinaryBlankSeries"] = sVeterinaryBlankSeries;
					o["VeterinaryBlankNumber"] = sVeterinaryBlankNumber;
				}
			}
			// position
		}

		private void btnVeterinaryBlankSeriesBlankLast_Click(object sender, EventArgs e)
		{
			string sVeterinaryBlankSeries = oOutputDocument.GetVeterinaryBlankSeries();
			if (sVeterinaryBlankSeries.Length > 0)
			{
				foreach (DataRow o in dt.Rows)
				{
					if (o["VeterinaryBlankSeries"].ToString().Length == 0)
					{
						o["VeterinaryBlankSeries"] = sVeterinaryBlankSeries;
					}
				}
			}
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0 || grdData.CurrentRow == null)
				return;

			// ���������� - ����� ������ 
			//DataRow dr = ((DataRowView)((DataGridViewRow)grdData.Rows[grdData.CurrentRow.Index]).DataBoundItem).Row;
			//DataTable dtRep = CopyTable(dt, "dtRep", "OutputsDocumentsListID = '" + dr["OutputsDocumentsListID"].ToString() + "'", "");
			foreach (DataRow dr in dt.Rows)
			{
				// ���������� ����� � ������, ���� �������
				if (dr["VeterinaryBlankSeries"] != null && !Convert.IsDBNull(dr["VeterinaryBlankSeries"]) && dr["VeterinaryBlankSeries"].ToString().Trim().Length > 0 ||
					dr["VeterinaryBlankNumber"] != null && !Convert.IsDBNull(dr["VeterinaryBlankNumber"]) && dr["VeterinaryBlankNumber"].ToString().Trim().Length > 0)
				{
					string sVeterinaryBlankSeries = "";
					if (dr["VeterinaryBlankSeries"] != null && !Convert.IsDBNull(dr["VeterinaryBlankSeries"]) && dr["VeterinaryBlankSeries"].ToString().Length > 0)
						sVeterinaryBlankSeries = dr["VeterinaryBlankSeries"].ToString().Trim();
					string sVeterinaryBlankNumber = "";
					if (dr["VeterinaryBlankNumber"] != null && !Convert.IsDBNull(dr["VeterinaryBlankNumber"]) && dr["VeterinaryBlankNumber"].ToString().Length > 0)
						sVeterinaryBlankNumber = dr["VeterinaryBlankNumber"].ToString().Trim();
                    string sVeterinaryBlankType = (optLocalBlank.Checked ? "4" : "2");

					string sOutputsDocumentsList = dr["OutputsDocumentsListID"].ToString();
					string[] sOutputsDocumentsIDSplit = sOutputsDocumentsList.Split(new char[] { ',' });
					foreach (string s in sOutputsDocumentsIDSplit)
					{
						if (s.Length == 0)
							continue;
						try
						{
							int nOutputDocumentID = Convert.ToInt32(s);
							oOutputDocument.SaveVeterinaryBlankData(nOutputDocumentID, 
                                sVeterinaryBlankSeries, sVeterinaryBlankNumber,
                                sVeterinaryBlankType, ((RFMFormMain)Application.OpenForms[0]).UserID);
						}
						catch { }
					}
				}
				dr["VeterinarFIO"] = txtVeterinarFio.Text;
			}

			// ��������� ���������� ������� ��� ������ ������� ������
			DataTable dtMarked = CopyTable(dt, "dtMarked", "IsMarked = true", "");
			if (dtMarked.Rows.Count == 0)
			{
				// ������� ������
				DataRow drMarked = ((DataRowView)((DataGridViewRow)grdData.Rows[grdData.CurrentRow.Index]).DataBoundItem).Row;
				DataTable dtMarkedTemp = CopyTable(dt, "dtMarkedTemp", "OutputsDocumentsListID = '" + drMarked["OutputsDocumentsListID"].ToString() + "'", "");
				dtMarked.Merge(dtMarkedTemp);
			}
			if (dtMarked.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("��� ������...");
				return;
			}

            // ������ 2-�� (��������) ��������
            foreach (DataRow drp in dtMarked.Rows)
            {
                drp["IsPrintSecondPage"] = chkSecondPage.Checked;
            }

			if (chkVeterinaryListAdd.Checked)
			{
				string sMarkedOutputsDocumentsList = "";
				// ���� ���������� ���������� - ������ ���� ��������� ����� � �����
				foreach (DataRow drp in dtMarked.Rows)
				{
					if (drp["VeterinaryBlankSeries"] == null || Convert.IsDBNull(drp["VeterinaryBlankSeries"]) || drp["VeterinaryBlankSeries"].ToString().Trim().Length == 0 ||
						drp["VeterinaryBlankNumber"] == null || Convert.IsDBNull(drp["VeterinaryBlankNumber"]) || drp["VeterinaryBlankNumber"].ToString().Trim().Length == 0 )
					{
						RFMMessage.MessageBoxInfo("�� ������� ������ � ����� � ������ ������ ������������� �������������\n" + 
							"(������ � ������������)...");
						return;
					}

					drp["VeterinaryMarks"] =
					drp["VeterinaryLaboratories"] =
						"��. ���������� 1";

					sMarkedOutputsDocumentsList += drp["OutputsDocumentsListID"].ToString() + ",";
				}

				ActiveReport3 rep = new DataDynamics.ActiveReports.ActiveReport3();
				if (optLocalBlank.Checked)
				{
					rep = new VeterinaryBlank();
				}
				else
				{
					rep = new VeterinaryBlankSingle();
				}

				StartForm(new frmActiveReport(dtMarked, rep));

				if (RFMMessage.MessageBoxYesNo("��������!\n\n" +
					"��������� ������ �� ������� ������������ ������������.\n" + 
					"������ ����� ����������� ������ ����������.\n\n" + 
					"����������?") != DialogResult.Yes)
					return;
                
				// ������ ��� ����������
				OutputDocument oOutputDocumentAdd = new OutputDocument();
				oOutputDocumentAdd.FillVeterinaryAddTableOutputsDocumentsGoods(sMarkedOutputsDocumentsList, optPartnerGroup.Checked);
				if (oOutputDocumentAdd.ErrorNumber == 0 && oOutputDocumentAdd.TableOutputsDocumentsGoods != null)
				{
					if (oOutputDocumentAdd.TableOutputsDocumentsGoods.Rows.Count == 0)
					{
						RFMMessage.MessageBoxInfo("��� ������ ��� ������ ���������� � ������������ ��������������...");
						return;
					}

					RFMMessage.MessageBoxAttention("����������� ������ ���������� � ������������ ��������������...");
					rep = new VeterinaryListAdd();
					StartForm(new frmActiveReport(oOutputDocumentAdd.TableOutputsDocumentsGoods, rep));
				}
			}
			else
			{
				ActiveReport3 rep = new DataDynamics.ActiveReports.ActiveReport3();
				if (optLocalBlank.Checked)
				{
					rep = new VeterinaryBlank();
				}
				else
				{
					rep = new VeterinaryBlankSingle();
				}

				StartForm(new frmActiveReport(dtMarked, rep));
			}

			// ������� ������
			bool bOK = false;
			foreach (DataRow dr in dt.Rows)
			{
				if ((bool)dr["IsMarked"])
				{
					dr["IsPrinted"] = true;
					bOK = true;
				}
			}
			if (!bOK)
			{
				// ������ ��� ������� 
				DataRow drMarked = ((DataRowView)((DataGridViewRow)grdData.Rows[grdData.CurrentRow.Index]).DataBoundItem).Row;
				drMarked["IsPrinted"] = true;
			}
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null || grd.Rows.Count == 0)
				return;

			string sColumnName = grd.Columns[e.ColumnIndex].Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			if (sColumnName.Contains("IsPrintedImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["IsPrinted"]))
				{
					if ((bool)r["IsPrinted"])
					{
						e.Value = Properties.Resources.Print;
					}
					else
					{
						e.Value = Properties.Resources.Empty;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}
		}

	}
}
