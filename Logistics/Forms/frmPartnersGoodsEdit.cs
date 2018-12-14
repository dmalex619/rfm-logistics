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
	public partial class frmPartnersGoodsEdit : RFMFormChild
	{
		private int nPartnerID;

		private Partner oPartner;
		private Good oGood;
		DataTable tGoods = null;

		public string _SelectedPackingsIDList = null;

		public int? _SelectedID = null; 

		public frmPartnersGoodsEdit(int _nPartnerID)
		{
			nPartnerID = _nPartnerID;

			oPartner = new Partner();
			if (oPartner.ErrorNumber != 0)
			{
				IsValid = false;
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

		private void frmPartnersGoodsEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			oPartner.ReFillOne(nPartnerID);

			oPartner.FillTablePartnersGoods(nPartnerID);
			if (oPartner.ErrorNumber != 0 || oPartner.TablePartnersGoods == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о товарах для клиента...");
				bResult = false;
			}

			if (bResult)
			{
				tGoods = CopyTable(oPartner.TablePartnersGoods, "tGoods", "", "ByOrder, GoodAlias");
			}

			try
			{
				tGoods.PrimaryKey = new DataColumn[] { tGoods.Columns["PackingID"] };
			}
			catch
			{
				tGoods.PrimaryKey = null;
			}
			tGoods.Columns["ID"].AllowDBNull = true;
			
			if (bResult)
			{
				// доступны только колонки для ввода извратных данных
				foreach (DataGridViewColumn c in grdData.Columns)
				{
					if (c.Name.ToUpper().Contains("SP_"))
					{
						c.ReadOnly = false;
						c.DefaultCellStyle.BackColor = Color.LightYellow;
					}
					else
					{
						c.ReadOnly = true;
					}
				}

				grdData_Restore();

				chkSP_Vat_CheckedChanged(null, null);
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

		private bool grdData_Restore()
		{
			grdData.Restore(tGoods);
			if (grdData.Rows.Count == 0) 
			{
				btnDeleteGood.Enabled =
				btnEdit.Enabled =
				btnByOrder.Enabled =
					false;
			}
			return (true);
		}

		#region Grid

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdData.DataSource == null)
				return;

			// неактуальные - курсором 
			if (!(bool)grdData.Rows[e.RowIndex].Cells["grcGoodActual"].Value)
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}

		private void grdData_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			DataGridViewRow r = grdData.Rows[e.RowIndex];

			// ставка НДС
			if (grdData.Columns[e.ColumnIndex].Name.ToUpper().Contains("VAT"))
			{
				int nColumnIndexVat = e.ColumnIndex;
				if (r.Cells[nColumnIndexVat].Value == null || r.Cells[nColumnIndexVat].Value == DBNull.Value)
				{
					r.Cells[nColumnIndexVat].Value = 0;
				}

				// проверка ставок НДС
				decimal nVat = (decimal)r.Cells[nColumnIndexVat].Value;
				if (nVat == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не указана ставка НДС...\nВсе-таки сохранить?") != DialogResult.Yes)
					{
						return; 
					}
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
						if (RFMMessage.MessageBoxYesNo("Указана нестандартная ставка НДС...\nВсе-таки сохранить?") != DialogResult.Yes)
						{
							r.Cells[nColumnIndexVat].Value = 0;
							return;  
						}
					}
				}
			}
		}

		#endregion Grid

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не введено ни одного товара...\n" +
					"Очистить все специальные данные о товарах для клиента?") != DialogResult.Yes)
					return;
			}

			// собственно сохранение 
			oPartner.ClearError();
			oPartner.SavePartnersGoods(nPartnerID, tGoods);
			if (oPartner.ErrorNumber == 0)
			{
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		#region Список товаров

		private void btnAddGood_Click(object sender, EventArgs e)
		{
			_SelectedPackingsIDList = null;

			if (StartForm(new frmSelectOnePacking(this, true)) == DialogResult.Yes)
			{
				if (_SelectedPackingsIDList == null || !_SelectedPackingsIDList.Contains(","))
					return;

				RFMCursorWait.Set(true);

				Good oGoodTemp = new Good();
				oGoodTemp.PackingsIDList = "," + _SelectedPackingsIDList;
				oGoodTemp.FillData();
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null || oGoodTemp.MainTable.Rows.Count == 0)
				{
					RFMCursorWait.Set(false);
					return;
				}

				int nGoodID = 0;
				int nPackingID = 0; 
				bool nFound = false;
				foreach (DataRow rg in oGoodTemp.MainTable.Rows)
				{ 
					// нет ли уже такого товара?
					nPackingID = Convert.ToInt32(rg["PackingID"]);
					nGoodID = Convert.ToInt32(rg["GoodID"]);
					nFound = false;
					
					foreach(DataRow drTemp in tGoods.Rows)
					{
						if (Convert.ToInt32(drTemp["PackingID"]) == nPackingID)
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
						DataTable dtTemp = tGoods.Clone();
						dtTemp.Columns["GoodID"].AllowDBNull = true;
						dtTemp.Columns["PackingID"].AllowDBNull = true;
						DataRow dr = dtTemp.Rows.Add();
						dr["PackingID"] = nPackingID;
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

						tGoods.ImportRow(dr);
					}
				}
				// встать на последнюю добавленную строку 
				if (nPackingID != 0)
				{
					grdData.GridSource.Position = grdData.GridSource.Find("PackingID", nPackingID);
					if (grdData.GridSource.Position < 0)
					{
						grdData.GridSource.MoveFirst();
					}
				}
				RFMCursorWait.Set(false);
			}
			_SelectedPackingsIDList = null;

			btnDeleteGood.Enabled =
			btnEdit.Enabled =
			btnByOrder.Enabled =
				(grdData.Rows.Count > 0);
		}

		private void btnDeleteGood_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0)
				return;
			if (grdData.CurrentRow == null)
				return;

			int nPackingID = Convert.ToInt32(grdData.CurrentRow.Cells["grcPackingID"].Value); 
			DataRow rDel = tGoods.Rows.Find(nPackingID);
			if (rDel != null)
			{
				//rDel["GoodID"] = 0;
				tGoods.Rows.Remove(rDel);
			}

			btnDeleteGood.Enabled =
			btnEdit.Enabled =
			btnByOrder.Enabled =
				(grdData.Rows.Count > 0);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			mnuEdit.Show(btnEdit, new Point());
		}

		#region Edit 

		private void mniGoodNameFull_Click(object sender, EventArgs e)
		{
			if (RFMMessage.MessageBoxYesNo("Заполнить специальные названия товаров в соответствии с учетными названиями\n(только для пустых специальных названий)?") != DialogResult.Yes)
				return;

			foreach (DataRow r in tGoods.Rows)
			{
				if (Convert.IsDBNull(r["SP_GoodName"]) ||
					r["SP_GoodName"] == null ||
					r["SP_GoodName"].ToString() == "")
				{
					r["SP_GoodName"] = r["GoodName"];
				}
			}
		}

		private void mniGoodNameClear_Click(object sender, EventArgs e)
		{
			if (RFMMessage.MessageBoxYesNo("Очистить специальные названия товаров?") != DialogResult.Yes)
				return;

			foreach (DataRow r in tGoods.Rows)
			{
				r["SP_GoodName"] = "";
			}
		}

		private void mniGoodVatFull_Click(object sender, EventArgs e)
		{
			if (RFMMessage.MessageBoxYesNo("Заполнить специальные ставки НДС\n(только для пустых значений специальных НДС)?") != DialogResult.Yes)
				return;

			decimal nVat = 0;
			if (StartForm(new frmInputBoxNumeric("Введите ставку НДС (%)", nVat)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
				{
					nVat = Convert.ToDecimal(GotParam[0]);
					foreach (DataRow r in tGoods.Rows)
					{
						if (Convert.IsDBNull(r["SP_Vat"]) ||
							r["SP_Vat"] == null ||
							Convert.ToDecimal(r["SP_Vat"]) == 0)
						{
							r["SP_Vat"] = nVat;
						}
					}
				}
			}
		}

		private void mniGoodVatClear_Click(object sender, EventArgs e)
		{
			if (RFMMessage.MessageBoxYesNo("Очистить специальные ставки НДС?") != DialogResult.Yes)
				return;

			foreach (DataRow r in tGoods.Rows)
			{
				r["SP_Vat"] = 0;
			}
		}

		#endregion Edit

		#endregion Список товаров

		#region Move

		private void btnMoveUp_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Здесь будет изменение порядка товаров...");
		}

		private void btnMoveDn_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Здесь будет изменение порядка товаров...");
		}

		#endregion Move

		private void btnByOrder_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0)
				return;

			DataTable dt = CopyTable(tGoods, "dt", "", "ByOrder");
			foreach (DataRow drt in dt.Rows)
			{
				if (Convert.IsDBNull(drt["ByOrder"]))
				{
					drt["ByOrder"] = 0;
				}
			}

			if (StartForm(new frmByOrder(dt, "ByOrder, GoodName, Articul, InBox, GoodGroupName, GoodBrandName", "№ п/п, Товар, Артикул, В кор., Товарная группа, Бренд", "PackingID")) == DialogResult.Yes)
			{
				string strInput = GotParam[0].ToString();
				if (strInput != null && strInput.Length > 0)
				{
					// разбираем строку
					int nPackingID = 0;
					int nByOrder = 0;
					string sNumber = "-", sMiddleNumber = "-";
					string sDelimiter = ";", sMiddleDelimiter = ",";
					sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
					while (sNumber.Length > 0)
					{
						nByOrder++;
						if (sNumber.Contains(sMiddleDelimiter))
						{
							sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
							while (sMiddleNumber.Length > 0)
							{
								try
								{
									nPackingID = Convert.ToInt32(sMiddleNumber);
								}
								catch
								{
									nPackingID = 0;
								}
								if (nPackingID > 0)
								{
									DataRow rr = tGoods.Rows.Find(nPackingID);
									if (rr != null)
										rr["ByOrder"] = rr["SP_ByOrder"] = nByOrder;
								}
								sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
							}
						}
						else
						{
							try
							{
								nPackingID = Convert.ToInt32(sNumber);
							}
							catch
							{
								nPackingID = 0;
							}
							if (nPackingID > 0)
							{
								DataRow rr = tGoods.Rows.Find(nPackingID);
								if (rr != null)
								{
									rr["ByOrder"] = rr["SP_ByOrder"] = nByOrder;
								}
							}
						}
						sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
					}
				}
				grdData_Restore();
			}
		}

		private void chkSP_Vat_CheckedChanged(object sender, EventArgs e)
		{
			if (chkSP_Vat.Checked)
			{
				grcSP_Vat.Visible = true;
				grcSP_Vat.ReadOnly = false;
			}
			else
			{
				grcSP_Vat.Visible = false;
				grcSP_Vat.ReadOnly = true;
			}
			grdData.Refresh();
		}

	}
}
