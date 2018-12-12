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
					RFMMessage.MessageBoxError("Ошибка при получении данных о товарах в ГТД...");
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
				// список товаров первоначально пуст
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

			// неактуальные - курсивом
			if (!(bool)dgvData.Rows[e.RowIndex].Cells["dgvcGoodActual"].Value)
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
			string sCustomNumber = txtCustomNumber.Text.Trim();
			DateTime? dDateBeg;
			// проверки 
			if (sCustomNumber.Length == 0)
			{
				RFMMessage.MessageBoxError("Не указан № ГТД...");
				txtCustomNumber.Select();
				return;
			}
			if (dtpDateBeg.IsEmpty)
			{
				RFMMessage.MessageBoxError("Не указана дата начала действия ГТД...");
				txtCustomNumber.Select();
				return;
			}
			else
			{
				dDateBeg = dtpDateBeg.Value.Date;
			}

			if (dgvData.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Не выбрано ни одного товара...");
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

		#region Список товаров

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
				// нет ли уже такого товара?
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
							RFMMessage.MessageBoxError("Такой товар уже в списке...");
							RFMCursorWait.Set(true);
						}
						break;
					}
				}
				if (!nFound)
				{
					// добавляем новую строку для выбранного товара
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
			// встать на последнюю добавленную строку 
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
                RFMMessage.MessageBoxAttention("запись получена из хост-системы.\n Удаление невозможно ...");
                return;
            }
            if (RFMMessage.MessageBoxYesNo("Удалить текущий товар?") != DialogResult.Yes)
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

		#endregion Список товаров

		#region ранее введенные значения

		private void btnCustomNumberSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значения 
			Good oGoodTemp = new Good();
			oGoodTemp.FillTableGoodsCustoms(null, null, null, true);
			if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsCustoms == null)
				return;
			if (oGoodTemp.TableGoodsCustoms.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных о ГТД...");
				return;
			}

            DataTable tdСustoms = CopyTable(oGoodTemp.TableGoodsCustoms, "tdСustoms", "1 = 2", "CustomNumber");
			tdСustoms.Columns.Add("ID", System.Type.GetType("System.Int32"));
			tdСustoms.Columns["ID"].AutoIncrement = true;
			DataTable tdCustomsX = CopyTable(oGoodTemp.TableGoodsCustoms, "tdСustomsX", "", "CustomNumber");
			tdСustoms.Merge(tdCustomsX);

            if (StartForm(new frmSelectID(this, tdСustoms, "CustomNumber, DateBeg", "№ ГТД, Дата начала", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				int nGoodCustomID_Old = (int)_SelectedID;
                tdСustoms.PrimaryKey = new DataColumn[] { tdСustoms.Columns["ID"] };
                DataRow r = tdСustoms.Rows.Find(nGoodCustomID_Old);
				if (r != null)
				{
					txtCustomNumber.Text = r["CustomNumber"].ToString();
				}
			}
			_SelectedID = null;

			return;
		}

		#endregion ранее введенные значения
	}
}
