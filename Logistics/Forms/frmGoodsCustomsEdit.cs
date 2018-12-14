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
	public partial class frmGoodCustomsEdit : RFMFormChild
	{
        private string sCustomNumber;
        private DateTime? dDateBeg;
        private Good oGood;

		DataTable tGoodsCustoms = null;

		public string _SelectedPackingsIDList = null, _SelectedIDList = null;

		public int? _SelectedID = null;


		public frmGoodCustomsEdit(string _sCustomNumber, DateTime? _dDateBeg)
		{
		    sCustomNumber =_sCustomNumber;
			dDateBeg = _dDateBeg;
			oGood = new Good();
			if (oGood.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmGoodsCustomsEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			if (sCustomNumber != null && sCustomNumber.Trim().Length > 0)
			{
				oGood.FillTableGoodsCustoms(sCustomNumber, null, null, false);
				if (oGood.ErrorNumber != 0 || oGood.TableGoodsCustoms == null)
				{
					RFMMessage.MessageBoxError("������ ��� ��������� ������ � ������� � ���...");
					bResult = false;
				}

				if (bResult)
				{
					tGoodsCustoms = oGood.TableGoodsCustoms;

                    txtCustomNumber.Text = sCustomNumber;
					if (!Convert.IsDBNull(dDateBeg))
						dtpDateBeg.Value = (DateTime)dDateBeg;
                    else
                        dtpDateBeg.HideControl(false);
				}
			}
			else
			{
                oGood.FillTableGoodsCustoms("", null, null, false);
				tGoodsCustoms = oGood.TableGoodsCustoms;
				dtpDateBeg.Value = DateTime.Now.Date;
				// ������ ������� ������������� ����
			}
	
			if (bResult)
			{
				dgvData_Restore();
			}
			
			if (!bResult)
			{
				Dispose();
			}
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private bool dgvData_Restore()
		{
			dgvData.Restore(tGoodsCustoms);
			btnDeleteGood.Enabled = (dgvData.Rows.Count > 0);
			return (true);
		}

		private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvData.DataSource == null)
				return;

			// ������������ - ��������
			if (!(bool)dgvData.Rows[e.RowIndex].Cells["dgvcGoodActual"].Value)
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			string sCustomNumber = txtCustomNumber.Text.Trim();
			DateTime? dDateBeg;
			// �������� 
			if (sCustomNumber.Length == 0)
			{
				RFMMessage.MessageBoxError("�� ������ � ���...");
				txtCustomNumber.Select();
				return;
			}
			if (dtpDateBeg.IsEmpty)
			{
				RFMMessage.MessageBoxError("�� ������� ���� ������ �������� ���...");
				txtCustomNumber.Select();
				return;
			}
			else
			{
				dDateBeg = dtpDateBeg.Value.Date;
			}

			if (dgvData.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("�� ������� �� ������ ������...");
				return;
			}
			RFMCursorWait.Set(true);
			oGood.ClearError();
			oGood.SaveGoodCustom(sCustomNumber, dDateBeg, tGoodsCustoms);
			RFMCursorWait.Set(false);
			if (oGood.ErrorNumber == 0)
			{
				MotherForm.GotParam = new object[] { sCustomNumber };
				DialogResult = DialogResult.Yes;
				Dispose();
			}
        }

		#region ������ �������

		private void btnAddGood_Click(object sender, EventArgs e)
		{
            _SelectedPackingsIDList = 
			_SelectedIDList = 
				null;
            int nGoodID = 0;
            bool nFound = false;
            Good oGoodTemp = new Good();
			if (StartForm(new frmSelectOnePacking(this, true)) != DialogResult.Yes)
			{
				_SelectedPackingsIDList = null;
				return;
			}
			else
			{
				if (_SelectedPackingsIDList == null || !_SelectedPackingsIDList.Contains(","))
					return;
				oGoodTemp.PackingsIDList = "," + _SelectedPackingsIDList;
				oGoodTemp.FillDataAsync();
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null || oGoodTemp.MainTable.Rows.Count == 0)
					return;
			}
			RFMCursorWait.Set(true);
			foreach (DataRow rg in oGoodTemp.MainTable.Rows)
			{
				// ��� �� ��� ������ ������?
				nGoodID = Convert.ToInt32(rg["GoodID"]);
				nFound = false;

				foreach (DataRow drTemp in tGoodsCustoms.Rows)
				{
					if (Convert.ToInt32(drTemp["GoodID"]) == nGoodID)
					{
						nFound = true;
						if (oGoodTemp.MainTable.Rows.Count == 1)
						{
							RFMCursorWait.Set(false);
							RFMMessage.MessageBoxError("����� ����� ��� � ������...");
							RFMCursorWait.Set(true);
						}
						break;
					}
				}
				if (!nFound)
				{
					// ��������� ����� ������ ��� ���������� ������
					DataTable dtTemp = tGoodsCustoms.Clone();
					dtTemp.Columns["GoodID"].AllowDBNull = true;
					DataRow dr = dtTemp.Rows.Add();
					dr["GoodID"] = nGoodID;
					dr["GoodName"] = rg["GoodName"];
					dr["GoodAlias"] = rg["GoodAlias"];
					dr["GoodBarCode"] = rg["GoodBarCode"];
					dr["Articul"] = rg["Articul"];
					dr["GoodGroupName"] = rg["GoodGroupName"];
					dr["GoodBrandName"] = rg["GoodBrandName"];
					dr["CountryName"] = rg["CountryName"];
					dr["Weighting"] = rg["Weighting"];
					dr["GoodActual"] = rg["GoodActual"];
					dr["Netto"] = rg["Netto"];
					dr["Brutto"] = rg["Brutto"];
					dr["Retention"] = rg["Retention"];
					dr["GoodERPCode"] = rg["GoodERPCode"];

					tGoodsCustoms.ImportRow(dr);
				}
			}
			// ������ �� ��������� ����������� ������ 
			if (nGoodID != 0)
			{
				dgvData.GridSource.Position = dgvData.GridSource.Find("GoodID", nGoodID);
				if (dgvData.GridSource.Position < 0)
				{
					dgvData.GridSource.MoveFirst();
				}
			}
			RFMCursorWait.Set(false);
			btnDeleteGood.Enabled = (dgvData.Rows.Count > 0);
		}

		private void btnDeleteGood_Click(object sender, EventArgs e)
		{
            if (dgvData.CurrentRow.Cells["dgvcGoodERPCode"].Value != DBNull.Value && dgvData.CurrentRow.Cells["dgvcGoodERPCode"].Value != null)
            {
                RFMMessage.MessageBoxAttention("������ �������� �� ����-�������.\n �������� ���������� ...");
                return;
            }
            if (RFMMessage.MessageBoxYesNo("������� ������� �����?") != DialogResult.Yes)
                return; 
			if (dgvData.Rows.Count == 0)
				return;
			if (dgvData.CurrentRow == null)
				return;
            if (dgvData.IsStatusRow(dgvData.CurrentRow.Index))
                return;
            DataRow dr = ((DataRowView)((DataGridViewRow)dgvData.Rows[dgvData.CurrentRow.Index]).DataBoundItem).Row;
       		tGoodsCustoms.Rows.Remove(dr);
			btnDeleteGood.Enabled = (dgvData.Rows.Count > 0);
		}

		#endregion ������ �������

		#region ����� ��������� ��������

		private void btnCustomNumberSelect_Click(object sender, EventArgs e)
		{
			// ����� �������� �������� 
			Good oGoodTemp = new Good();
			oGoodTemp.FillTableGoodsCustoms(null, null, null, true);
			if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsCustoms == null)
				return;
			if (oGoodTemp.TableGoodsCustoms.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ � ���...");
				return;
			}

            DataTable td�ustoms = CopyTable(oGoodTemp.TableGoodsCustoms, "td�ustoms", "1 = 2", "CustomNumber");
			td�ustoms.Columns.Add("ID", System.Type.GetType("System.Int32"));
			td�ustoms.Columns["ID"].AutoIncrement = true;
			DataTable tdCustomsX = CopyTable(oGoodTemp.TableGoodsCustoms, "td�ustomsX", "", "CustomNumber");
			td�ustoms.Merge(tdCustomsX);

            if (StartForm(new frmSelectID(this, td�ustoms, "CustomNumber, DateBeg", "� ���, ���� ������", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				int nGoodCustomID_Old = (int)_SelectedID;
                td�ustoms.PrimaryKey = new DataColumn[] { td�ustoms.Columns["ID"] };
                DataRow r = td�ustoms.Rows.Find(nGoodCustomID_Old);
				if (r != null)
				{
					txtCustomNumber.Text = r["CustomNumber"].ToString();
				}
			}
			_SelectedID = null;

			return;
		}

		#endregion ����� ��������� ��������
	}
}
