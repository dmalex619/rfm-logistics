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
	public partial class frmGoodsQualitiesEdit : RFMFormChild
	{
		private int? nGoodQualityID = null;
		private Good oGood;

		DataTable tGoodsQualities = null;

		public string _SelectedPackingsIDList = null, _SelectedIDList = null;

		public int? _SelectedID = null ;

		public int? _SelectedInputDocumentID = null, _SelectedInputID = null;

		public frmGoodsQualitiesEdit(int? _nGoodQualityID)
		{
			if (_nGoodQualityID.HasValue)
			{
				nGoodQualityID = (int)_nGoodQualityID;
			}

			_SelectedInputDocumentID = _SelectedInputID = null;

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

		public frmGoodsQualitiesEdit(int? _nGoodQualityID, int? _InputID, int? _InputDocumentID)
		{
			if (_nGoodQualityID.HasValue)
			{
				nGoodQualityID = (int)_nGoodQualityID;
			}

			_SelectedInputDocumentID =_InputDocumentID;

			_SelectedInputID = _InputID;

			if (_SelectedInputDocumentID.HasValue && _SelectedInputID.HasValue)
			{
				RFMMessage.MessageBoxError("Неверный вызов");
				DialogResult = DialogResult.No;
				IsValid = false;	
			}


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

		private void frmGoodsQualitiesEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			if (nGoodQualityID.HasValue)
			{
				oGood.FillTableGoodsQualitiesMapping(nGoodQualityID, null, null);
				if (oGood.ErrorNumber != 0 || oGood.TableGoodsQualitiesMapping == null || oGood.TableGoodsQualitiesMapping.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о декларации соответствия...");
					bResult = false;
				}
				if (bResult)
				{
					tGoodsQualities = oGood.TableGoodsQualitiesMapping;

					DataRow r = tGoodsQualities.Rows[0];
					txtQualityLicence.Text = r["QualityLicence"].ToString();
                    txtQualityIssuer.Text = r["QualityIssuer"].ToString();
                    txtQualityHolder.Text = r["QualityHolder"].ToString();
                    if (!Convert.IsDBNull(r["QualityDateBeg"]))
						dtrDates.dtpBegDate.Value = (DateTime)r["QualityDateBeg"];
					else
						dtrDates.dtpBegDate.HideControl(false);
					if (!Convert.IsDBNull(r["QualityDateEnd"]))
						dtrDates.dtpEndDate.Value = (DateTime)r["QualityDateEnd"];
					else
						dtrDates.dtpEndDate.HideControl(false);
				}
			}
			else
			{
				oGood.FillTableGoodsQualitiesMapping(-1, -1, null);
				tGoodsQualities = oGood.TableGoodsQualitiesMapping;

				dtrDates.dtpBegDate.Value = DateTime.Now.Date;
				dtrDates.dtpEndDate.Value = DateTime.Now.Date;
				// список товаров пуст
			}

			try
			{
				tGoodsQualities.PrimaryKey = new DataColumn[] { tGoodsQualities.Columns["GoodID"] };
			}
			catch
			{
				tGoodsQualities.PrimaryKey = null;
			}

			if (_SelectedInputDocumentID.HasValue)
			{
				InputDocument oInputDocument = new InputDocument();
				if (oInputDocument.ErrorNumber != 0)
					bResult = false;
				else
				{
					oInputDocument.ReFillOne((int)_SelectedInputDocumentID);
					txtInputDocument.Text = oInputDocument.MainTable.Rows[0]["ID"].ToString() + " [" +
							((DateTime)oInputDocument.MainTable.Rows[0]["DateInput"]).ToShortDateString() + "] " +
                            oInputDocument.MainTable.Rows[0]["PartnerSourceName"].ToString();
					btnInputSelect.Enabled = btnInputClear.Enabled = false;

				}

			}

			if (_SelectedInputID.HasValue)
			{
				Input oInput = new Input();
				if (oInput.ErrorNumber != 0)
					bResult = false;
				else
				{
					oInput.ReFillOne((int)_SelectedInputID);
					txtInput.Text = oInput.MainTable.Rows[0]["ID"].ToString() + " [" +
						((DateTime)oInput.MainTable.Rows[0]["DateInput"]).ToShortDateString() + "] " +
                        oInput.MainTable.Rows[0]["PartnerName"].ToString();
					btnInputDocumentSelect.Enabled = btnInputDocumentClear.Enabled = false;

				}
			}

			
			if (bResult)
			{
				grdData_Restore();
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
			grdData.Restore(tGoodsQualities);
			btnDeleteGood.Enabled = (grdData.Rows.Count > 0);
			return (true);
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdData.DataSource == null)
				return;

			// неактуальные - курсором 
			if (!(bool)grdData.Rows[e.RowIndex].Cells["grcGoodActual"].Value)
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string sQualityLicence = txtQualityLicence.Text.Trim();
            string sQualityIssuer = txtQualityIssuer.Text.Trim();
            string sQualityHolder = txtQualityHolder.Text.Trim();

			// проверки 
            if (sQualityLicence.Length == 0)
			{
                RFMMessage.MessageBoxError("Не указан номер декларации...");
				txtQualityLicence.Select();
				return;
			}
			if (sQualityIssuer.Length == 0)
			{
                RFMMessage.MessageBoxError("Не указано, кем выдана декларация...");
				txtQualityIssuer.Select();
				return;
			}
            if (sQualityHolder.Length == 0)
            {
                RFMMessage.MessageBoxError("Не указано лицо, принявшее декларацию...");
                txtQualityHolder.Select();
                return;
            }
            if (grdData.Rows.Count == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не выбрано ни одного товара...\n" + 
					"Все-таки сохранить?") != DialogResult.Yes)
					return;
			}

			// уникальность номера
			RFMCursorWait.Set(true);

			Good oGoodTemp = new Good();
			oGoodTemp.FillTableGoodsQualities(null, null);
			foreach(DataRow dr in oGoodTemp.TableGoodsQualities.Rows)
			{
				if (dr["QualityLicence"].ToString().Trim().ToUpper() == sQualityLicence.ToUpper() && 
					(!nGoodQualityID.HasValue || (int)nGoodQualityID != (int)dr["ID"]) ) 
				{
					RFMCursorWait.Set(false);
					RFMMessage.MessageBoxError("Такая декларация уже есть...");
					txtQualityLicence.Select();
					return;
				}
			}
			RFMCursorWait.Set(false);

			DateTime? dDateBeg = null, dDateEnd = null;
			if (!dtrDates.dtpBegDate.IsEmpty)
				dDateBeg = dtrDates.dtpBegDate.Value;
			if (!dtrDates.dtpEndDate.IsEmpty)
				dDateEnd = dtrDates.dtpEndDate.Value;

			// собственно сохранение 
			oGood.ClearError();
            oGood.SaveGoodQuality(ref nGoodQualityID, sQualityLicence, sQualityIssuer, sQualityHolder, dDateBeg, dDateEnd, tGoodsQualities);
			if (oGood.ErrorNumber == 0)
			{
				// код добавленной записи 
				if (nGoodQualityID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int)nGoodQualityID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		#region Список товаров

		private void btnAddGood_Click(object sender, EventArgs e)
		{
			_SelectedPackingsIDList = _SelectedIDList = null;
			int nGoodID = 0;
			bool nFound = false;
			DataTable dtSource;
			Good oGoodTemp = new Good();
			if (_SelectedInputDocumentID != null || _SelectedInputID != null)
			{
				if (_SelectedInputDocumentID != null)
				{
					InputDocument oInputDocument = new InputDocument();
					oInputDocument.ID = _SelectedInputDocumentID;
					oInputDocument.FillTableInputsDocumentsGoods();
					if (oInputDocument.TableInputsDocumentsGoods.Rows.Count == 0)
					{
						RFMMessage.MessageBoxAttention("В выбранном приходном документе нет товаров...");
						return;
					}
					dtSource = oInputDocument.TableInputsDocumentsGoods.Copy();
				}
				else
				{
					Input oInput = new Input();
					oInput.ID = _SelectedInputID;
					oInput.FillTableInputsGoods();
					if (oInput.TableInputsGoods.Rows.Count == 0)
					{
						RFMMessage.MessageBoxAttention("В выбранном задании на приход нет товаров...");
						return;
					}
					dtSource = oInput.TableInputsGoods.Copy();
				}
				if (StartForm(new frmSelectID(this, dtSource,
					"GoodAlias, GoodBarcode, Articul, GoodGroupName, GoodBrandName, Retention, Weighting, GoodActual, CountryName, ERPCode",
					"Товар, Штрих-Код, Артикул, Группа, Бренд, Срок годн., Вес., Акт., Страна, ERP-код", true)) != DialogResult.Yes)
				{
					_SelectedIDList = null;
					return;
				}
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
					return;
				string[] cIDList = _SelectedIDList.Split(',');
				StringBuilder sb = new StringBuilder();
				DataRow dr;
				for (int i = 0; i < cIDList.Length; i++)
				{
					for (int j = 0; j < dtSource.Rows.Count; j++)
					{
						dr = dtSource.Rows[j];
						if (cIDList[i] == dr["ID"].ToString())
							sb.Append(dr["PackingID"].ToString() + ",");
					}
				}
				oGoodTemp.PackingsIDList = "," + sb;
				oGoodTemp.FillData();
			}
			else
			{
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
					oGoodTemp.FillData();
					if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null || oGoodTemp.MainTable.Rows.Count == 0)
						return;
				}
			}
			RFMCursorWait.Set(true);
			foreach (DataRow rg in oGoodTemp.MainTable.Rows)
			{
				// нет ли уже такого товара?
				nGoodID = Convert.ToInt32(rg["GoodID"]);
				nFound = false;

				foreach (DataRow drTemp in tGoodsQualities.Rows)
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
					DataTable dtTemp = tGoodsQualities.Clone();
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

					tGoodsQualities.ImportRow(dr);
				}
			}
			// встать на последнюю добавленную строку 
			if (nGoodID != 0)
			{
				grdData.GridSource.Position = grdData.GridSource.Find("GoodID", nGoodID);
				if (grdData.GridSource.Position < 0)
				{
					grdData.GridSource.MoveFirst();
				}
			}
			RFMCursorWait.Set(false);
			btnDeleteGood.Enabled = (grdData.Rows.Count > 0);
		}

		private void btnDeleteGood_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0)
				return;
			if (grdData.CurrentRow == null)
				return;

			int nGoodID = Convert.ToInt32(grdData.CurrentRow.Cells["grcGoodID"].Value); 
			DataRow rDel = tGoodsQualities.Rows.Find(nGoodID);
			if (rDel != null)
			{
				//rDel["GoodID"] = 0;
				tGoodsQualities.Rows.Remove(rDel);
			}

			btnDeleteGood.Enabled = (grdData.Rows.Count > 0);
		}

		#endregion Список товаров

		#region ранее введенные значения

		private void btnQualityLicenceSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значения
			Good oGoodTemp = new Good();
			oGoodTemp.FillTableGoodsQualities(null, null);
			if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsQualities == null)
				return;
			if (oGoodTemp.TableGoodsQualities.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных о декларациях...");
				return;
			}

			DataTable tdLicence = CopyTable(oGoodTemp.TableGoodsQualities, "tdLicence", "", "QualityLicence");

            if (StartForm(new frmSelectID(this, tdLicence, "QualityLicence, QualityIssuer, QualityHolder, QualityDateBeg, QualityDateEnd", "Декларация №,Выдан,Держатель,Дата нач.,Дата кон.", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				int nGoodQualityID_Old = (int)_SelectedID;
				tdLicence.PrimaryKey = new DataColumn[] { tdLicence.Columns["ID"] };
				DataRow r = tdLicence.Rows.Find(nGoodQualityID_Old);
				if (r != null)
				{
					txtQualityLicence.Text = r["QualityLicence"].ToString();
					txtQualityIssuer.Text = r["QualityIssuer"].ToString();
                    txtQualityHolder.Text = r["QualityHolder"].ToString();
                }
			}
			_SelectedID = null;

			return;
		}

        private void btnQualityLicenceSelectIssuer_Click(object sender, EventArgs e)
        {
            // ранее введеные значения
            Good oGoodTemp = new Good();
            oGoodTemp.FillTableGoodsQualitiesForSelect("Issuer");
            if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsQualitiesForSelect == null)
                return;
            if (oGoodTemp.TableGoodsQualitiesForSelect.Rows.Count == 0)
            {
                RFMMessage.MessageBoxError("Нет данных об органах декларирования...");
                return;
            }

            DataTable tdLicence = CopyTable(oGoodTemp.TableGoodsQualitiesForSelect, "tdLicence", "", "Value");

            if (StartForm(new frmSelectID(this, tdLicence, "Value", "Декларант", false)) == DialogResult.Yes)
            {
                if (_SelectedID == null)
                    return;
                int nGoodQualityID_Old = (int)_SelectedID;
                tdLicence.PrimaryKey = new DataColumn[] { tdLicence.Columns["ID"] };
                DataRow r = tdLicence.Rows.Find(nGoodQualityID_Old);
                if (r != null)
                    txtQualityIssuer.Text = r["Value"].ToString();
            }
            _SelectedID = null;

            return;
        }

        private void btnQualityLicenceSelectHolder_Click(object sender, EventArgs e)
        {
            // ранее введеные значения
            Good oGoodTemp = new Good();
            oGoodTemp.FillTableGoodsQualitiesForSelect("Holder");
            if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsQualitiesForSelect == null)
                return;
            if (oGoodTemp.TableGoodsQualitiesForSelect.Rows.Count == 0)
            {
                RFMMessage.MessageBoxError("Нет данных о держателях декларираций...");
                return;
            }

            DataTable tdLicence = CopyTable(oGoodTemp.TableGoodsQualitiesForSelect, "tdLicence", "", "Value");

            if (StartForm(new frmSelectID(this, tdLicence, "Value", "Держатель", false)) == DialogResult.Yes)
            {
                if (_SelectedID == null)
                    return;
                int nGoodQualityID_Old = (int)_SelectedID;
                tdLicence.PrimaryKey = new DataColumn[] { tdLicence.Columns["ID"] };
                DataRow r = tdLicence.Rows.Find(nGoodQualityID_Old);
                if (r != null)
                    txtQualityHolder.Text = r["Value"].ToString();
            }
            _SelectedID = null;

            return;
        }

        #endregion ранее введенные значения

		private void btnInputDocumentSelect_Click(object sender, EventArgs e)
		{
			InputDocument oInputDocument = new InputDocument();
			oInputDocument.FilterDateBeg =DateTime.Today.AddMonths(-1);
			oInputDocument.FilterDateEnd = DateTime.Today;
			if (StartForm(new frmSelectOneInputDocument(this, false, oInputDocument)) == DialogResult.Yes)
			{
				oInputDocument.ID = _SelectedInputDocumentID;
				oInputDocument.FillData();
				if ((_SelectedInputDocumentID != null) && (oInputDocument.MainTable.Rows.Count > 0))
				{
					txtInputDocument.Text = oInputDocument.MainTable.Rows[0]["ID"].ToString() + " [" +
							((DateTime)oInputDocument.MainTable.Rows[0]["DateInput"]).ToShortDateString() + "] " +
                            oInputDocument.MainTable.Rows[0]["PartnerSourceName"].ToString();
					btnInputSelect.Enabled = btnInputClear.Enabled = false;
				}
			}
		}

		private void btnInputDocumentClear_Click(object sender, EventArgs e)
		{
			_SelectedInputDocumentID = null;
			txtInputDocument.Text = "";
			btnInputSelect.Enabled = btnInputClear.Enabled = true;
		}

		private void btnInputSelect_Click(object sender, EventArgs e)
		{
			Input oInput = new Input();
			oInput.FilterDateBeg = DateTime.Today.AddMonths(-1);
			oInput.FilterDateEnd = DateTime.Today;
			if (StartForm(new frmSelectOneInput(this, false, oInput)) == DialogResult.Yes)
			{
				oInput.ID = _SelectedInputID;
				oInput.FillData();
				if ((_SelectedInputID != null) && (oInput.MainTable.Rows.Count > 0))
				{
					txtInput.Text = oInput.MainTable.Rows[0]["ID"].ToString() + " [" +
							((DateTime)oInput.MainTable.Rows[0]["DateInput"]).ToShortDateString() + "] " +
                            oInput.MainTable.Rows[0]["PartnerName"].ToString();
					btnInputDocumentSelect.Enabled = btnInputDocumentClear.Enabled = false;
				}
			}
		}

		private void btnInputClear_Click(object sender, EventArgs e)
		{
			_SelectedInputID = null;
			txtInput.Text = "";
			btnInputDocumentSelect.Enabled = btnInputDocumentClear.Enabled = true;
		}

	}
}
