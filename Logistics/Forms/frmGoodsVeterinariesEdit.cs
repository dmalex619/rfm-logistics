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
	public partial class frmGoodsVeterinariesEdit : RFMFormChild
	{
		private int? nGoodVeterinaryID = null;
		private Good oGood;

		DataTable tGoodsVeterinaries = null;

		public string _SelectedPackingsIDList = null, _SelectedIDList = null, sExportXML = "";
		//public string _SelectedPackingsAliasText = null;

		public int? _SelectedID = null;

		public int? _SelectedInputDocumentID = null, _SelectedInputID = null;


		public frmGoodsVeterinariesEdit(int ? _nGoodVeterinaryID)
		{
			if (_nGoodVeterinaryID.HasValue)
			{
				nGoodVeterinaryID = (int)_nGoodVeterinaryID;
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

		public frmGoodsVeterinariesEdit(int? _nGoodVeterinaryID, int? _InputID, int? _InputDocumentID)
		{
			if (_nGoodVeterinaryID.HasValue)
			{
				nGoodVeterinaryID = (int)_nGoodVeterinaryID;
			}

			_SelectedInputDocumentID = _InputDocumentID;

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

		private void frmGoodsVeterinariesEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			if (nGoodVeterinaryID.HasValue)
			{
				oGood.FillTableGoodsVeterinariesMapping(nGoodVeterinaryID, null, null);
				if (oGood.ErrorNumber != 0 || oGood.TableGoodsVeterinariesMapping == null || oGood.TableGoodsVeterinariesMapping.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о ветеринарном свидетельстве...");
					bResult = false;
				}
				if (bResult)
				{
					tGoodsVeterinaries = oGood.TableGoodsVeterinariesMapping;

					DataRow r = tGoodsVeterinaries.Rows[0];
					txtVeterinaryLicence.Text = r["VeterinaryLicence"].ToString();
					txtVeterinaryProducer.Text = r["VeterinaryProducer"].ToString();
					txtVeterinaryName.Text = r["VeterinaryName"].ToString();
					txtVeterinaryNote.Text = r["VeterinaryNote"].ToString();
					txtVeterinaryMark.Text = r["VeterinaryMark"].ToString();
					txtVeterinaryLaboratory.Text = r["VeterinaryLaboratory"].ToString();
                    txtVeterinaryDateOfProducing.Text = r["VeterinaryDateOfProducing"].ToString();
                    sExportXML = r["VeterinaryExportXML"].ToString();

					if (!Convert.IsDBNull(r["VeterinaryDateBeg"]))
						dtpVeterinaryDateBeg.Value = (DateTime)r["VeterinaryDateBeg"];
					else
						dtpVeterinaryDateBeg.HideControl(false);
				}
			}
			else
			{
				oGood.FillTableGoodsVeterinariesMapping(-1, -1, null);
				tGoodsVeterinaries = oGood.TableGoodsVeterinariesMapping;

				dtpVeterinaryDateBeg.Value = DateTime.Now.Date;
				// список товаров пуст
			}

			try
			{
				tGoodsVeterinaries.PrimaryKey = new DataColumn[] { tGoodsVeterinaries.Columns["GoodID"] };
			}
			catch
			{
				tGoodsVeterinaries.PrimaryKey = null;
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
			grdData.Restore(tGoodsVeterinaries);
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
			string sVeterinaryLicence = txtVeterinaryLicence.Text.Trim();
            string sVeterinaryName = txtVeterinaryName.Text.Trim();

			// проверки 
			if (sVeterinaryLicence.Length == 0)
			{
				RFMMessage.MessageBoxError("Не указан номер свидетельства...");
				txtVeterinaryLicence.Select();
				return;
			}

			if (dtpVeterinaryDateBeg.IsEmpty)
			{
				RFMMessage.MessageBoxError("Не указана дата начала действия свидетельства...");
				txtVeterinaryProducer.Select();
				return;
			}

            /*if (sExportXML.Length == 0)
            {
                if (RFMMessage.MessageBoxYesNo("Не заполнены данные для экспорта...\n" +
                    "Все-таки сохранить?") != DialogResult.Yes)
                    return;
            }*/

            if (grdData.Rows.Count == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не выбрано ни одного товара...\n" + 
					"Все-таки сохранить?") != DialogResult.Yes)
					return;
			}

			// уникальность номера
			RFMCursorWait.Set(true);

			Good oGoodTemp = new Good();
			oGoodTemp.FillTableGoodsVeterinaries(null, null);
			foreach(DataRow dr in oGoodTemp.TableGoodsVeterinaries.Rows)
			{
				if (dr["VeterinaryLicence"].ToString().Trim().ToUpper() == sVeterinaryLicence.ToUpper() &&
                    dr["VeterinaryName"].ToString().Trim().ToUpper() == sVeterinaryName.ToUpper() && 
					(!nGoodVeterinaryID.HasValue || (int)nGoodVeterinaryID != (int)dr["ID"]) ) 
				{
					RFMCursorWait.Set(false);
					RFMMessage.MessageBoxError("Такой номер свидетельства с таким же наименованием товара уже есть...");
					txtVeterinaryLicence.Select();
					return;
				}
			}
			RFMCursorWait.Set(false);

			// собственно сохранение 
			oGood.ClearError();
			oGood.SaveGoodVeterinary(ref nGoodVeterinaryID, sVeterinaryLicence, txtVeterinaryProducer.Text.Trim(),  
				txtVeterinaryName.Text.Trim(), txtVeterinaryNote.Text.Trim(), 
				txtVeterinaryMark.Text.Trim(), txtVeterinaryLaboratory.Text.Trim(), 
                txtVeterinaryDateOfProducing.Text.Trim(), 
				dtpVeterinaryDateBeg.Value.Date, sExportXML, 
				tGoodsVeterinaries);
			if (oGood.ErrorNumber == 0)
			{
				// код добавленной записи 
				if (nGoodVeterinaryID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int)nGoodVeterinaryID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

        private void btnForExport_Click(object sender, EventArgs e)
        {
            if (StartForm(new frmVeterinaryExportXmlEdit(sExportXML)) == DialogResult.OK)
            {
                if (GotParam[0] != null)
                {
                    sExportXML = GotParam[0].ToString();
                }
            }
        }

        #region Список товаров

		private void btnAddGood_Click(object sender, EventArgs e)
		{
			_SelectedPackingsIDList = null;
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
				if (StartForm(new frmSelectOnePacking(this, true)) == DialogResult.Yes)
				{
					if (_SelectedPackingsIDList == null || !_SelectedPackingsIDList.Contains(","))
						return;

					RFMCursorWait.Set(true);
					oGoodTemp.PackingsIDList = "," + _SelectedPackingsIDList;
					oGoodTemp.FillData();
					if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null || oGoodTemp.MainTable.Rows.Count == 0)
					{
						RFMCursorWait.Set(false);
						return;
					}

				}
			}
			foreach (DataRow rg in oGoodTemp.MainTable.Rows)
			{
				// нет ли уже такого товара?
				nGoodID = Convert.ToInt32(rg["GoodID"]);
				nFound = false;

				foreach (DataRow drTemp in tGoodsVeterinaries.Rows)
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
					DataTable dtTemp = tGoodsVeterinaries.Clone();
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

					tGoodsVeterinaries.ImportRow(dr);
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
			}
			_SelectedPackingsIDList = null;

			btnDeleteGood.Enabled = (grdData.Rows.Count > 0);
		}

		private void btnDeleteGood_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0)
				return;
			if (grdData.CurrentRow == null)
				return;

			int nGoodID = Convert.ToInt32(grdData.CurrentRow.Cells["grcGoodID"].Value); 
			DataRow rDel = tGoodsVeterinaries.Rows.Find(nGoodID);
			if (rDel != null)
			{
				//rDel["GoodID"] = 0;
				tGoodsVeterinaries.Rows.Remove(rDel);
			}

			btnDeleteGood.Enabled = (grdData.Rows.Count > 0);
		}

		#endregion Список товаров

		#region ранее введенные значения

		private void btnVeterinaryLicenceSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значения 
			Good oGoodTemp = new Good();
			if (chkInList.Checked && tGoodsVeterinaries.Rows.Count > 0)
			{
				// только по списку
				string sGoodsList = "";
				foreach (DataRow g in tGoodsVeterinaries.Rows)
				{
					sGoodsList += g["GoodID"].ToString() + ",";
				}
				oGoodTemp.FillTableGoodsVeterinariesMapping(null, null, sGoodsList);
			}
			else
			{
				oGoodTemp.FillTableGoodsVeterinariesMapping(null, null, null);
			}
			if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsVeterinariesMapping == null)
				return;
			if (oGoodTemp.TableGoodsVeterinariesMapping.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных о свидетельствах...");
				return;
			}

			// уникальные значения
			DataView vGoodsVeterinariesMapping = new DataView(oGoodTemp.TableGoodsVeterinariesMapping);
            DataTable tTable1 = vGoodsVeterinariesMapping.ToTable(true, 
                "VeterinaryLicence", "VeterinaryProducer", "VeterinaryName", "VeterinaryNote", 
                "VeterinaryMark", "VeterinaryLaboratory", "VeterinaryDateOfProducing");
			DataTable tTable2 = CopyTable(tTable1, "tTable2", "1 = 2", "");
			tTable2.Columns.Add("ID", System.Type.GetType("System.Int32"));
			tTable2.Columns["ID"].AutoIncrement = true;
			tTable2.Merge(tTable1);

			DataTable tdLicence = CopyTable(tTable2, "tdLicence", "", "VeterinaryLicence");
			if (StartForm(new frmSelectID(this, tdLicence,
                    "VeterinaryLicence, VeterinaryProducer, VeterinaryName, VeterinaryNote, " + 
                    "VeterinaryMark, VeterinaryLaboratory, VeterinaryDateOfProducing, VeterinaryDateBeg", 
					"Сертификат №, Производитель, Наименование, Разрешение, " + 
                    "Маркировка, Лаборатория, Дата выработки, Дата нач.", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				int nGoodVeterinaryID_Old = (int)_SelectedID;
				tdLicence.PrimaryKey = new DataColumn[] { tdLicence.Columns["ID"] };
				DataRow r = tdLicence.Rows.Find(nGoodVeterinaryID_Old);
				if (r != null)
				{
					txtVeterinaryLicence.Text = r["VeterinaryLicence"].ToString();
					txtVeterinaryProducer.Text = r["VeterinaryProducer"].ToString();
					txtVeterinaryName.Text = r["VeterinaryName"].ToString();
					txtVeterinaryNote.Text = r["VeterinaryNote"].ToString();
					txtVeterinaryMark.Text = r["VeterinaryMark"].ToString();
					txtVeterinaryLaboratory.Text = r["VeterinaryLaboratory"].ToString();
                    txtVeterinaryDateOfProducing.Text = r["VeterinaryDateOfProducing"].ToString();
				}
			}
			_SelectedID = null;

			return;
		}

		#endregion ранее введенные значения

		#region фильтр по заданию/документам на приход

		private void btnInputDocumentSelect_Click(object sender, EventArgs e)
		{
			InputDocument oInputDocument = new InputDocument();
			oInputDocument.FilterDateBeg = DateTime.Today.AddMonths(-1);
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

		#endregion фильтр по заданию/документам на приход

	}
}
