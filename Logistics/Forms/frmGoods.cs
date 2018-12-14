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
	public partial class frmGoods : RFMFormChild
	{
		private Good oGoodList; //список товаров
		private Good oGoodCur; //текущий товар

		private Good oGoodQualityList; //список товаров
		private Good oGoodQualityCur; //текущий товар

		private Good oGoodVeterinaryList; //список товаров
		private Good oGoodVeterinaryCur; //текущий товар

		private Good oGoodCustomList; //список товаров
		private Good oGoodCustomCur; //текущий товар

		private Host oHost;
		private int? nUserHostID = null;

		// для фильтров
		public string _SelectedIDList;
		public string _SelectedText;

		private string _sGoodsIDList = null;


		public frmGoods()
		{
			oGoodList = new Good();
			oGoodCur = new Good();
			if (oGoodList.ErrorNumber != 0 ||
				oGoodCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{ 
				oGoodQualityList = new Good(); 
				oGoodQualityCur = new Good(); 
				if (oGoodQualityList.ErrorNumber != 0 ||
					oGoodQualityCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{ 
				oGoodVeterinaryList = new Good(); 
				oGoodVeterinaryCur = new Good(); 
				if (oGoodVeterinaryList.ErrorNumber != 0 ||
					oGoodVeterinaryCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oGoodCustomList = new Good();
				oGoodCustomCur = new Good();
				if (oGoodCustomList.ErrorNumber != 0 ||
					oGoodCustomCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			oHost = new Host();
			if (oHost.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmGoods_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			lblHosts.Visible =
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled =
				(oHost.Count() > 1 && !nUserHostID.HasValue);

			tcList.Init();

			btnClearTerms_Click(null, null);
			txtNameContext.Select();

			RFMCursorWait.Set(false);
		}

	#region Tab restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnPrint.Enabled = 
			btnService.Enabled = 
				false;

			txtNameContext.Select();
			
			return (true);
		}

		#region tabData (Goods)

		private bool tabData_Restore()
		{
			grdData_Restore();
			btnAdd.Enabled = 
			btnEdit.Enabled =
			btnDelete.Enabled =
				false; 
			if (grdData.Rows.Count > 0)
			{
				btnPrint.Enabled =
				btnService.Enabled = 
					true;
				grdData.Select();
			}
			else
			{
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			return (true);
		}

		private bool tabQualitiesGoods_Restore()
		{
			return (grdQualitiesGoods_Restore());
		}

		private bool tabVeterinariesGoods_Restore()
		{
			return (grdVeterinariesGoods_Restore());
		}

		private bool tabCustomsGoods_Restore()
		{
			return (grdCustomsGoods_Restore());
		}

		#endregion tabData (Goods)

		#region tabQualities

		private bool tabQualities_Restore()
		{
			grdQualities_Restore();
			btnAdd.Enabled = true;
			if (grdQualities.Rows.Count > 0)
			{
				btnEdit.Enabled = 
				btnDelete.Enabled = 
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdQualities.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		private bool tabGoodsQualities_Restore()
		{
			return (grdGoodsQualities_Restore());
		}

		#endregion tabQualities

		#region tabVeterinaries

		private bool tabVeterinaries_Restore()
		{
			grdVeterinaries_Restore();
			btnAdd.Enabled = true;
			if (grdVeterinaries.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdVeterinaries.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		private bool tabGoodsVeterinaries_Restore()
		{
			return (grdGoodsVeterinaries_Restore());
		}

		#endregion tabVeterinaries 

		#region tabCustoms

		private bool tabCustoms_Restore()
		{
			grdCustoms_Restore();
			btnAdd.Enabled = true;
			if (grdCustoms.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdCustoms.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		private bool tabGoodsCustoms_Restore()
		{
			return (grdGoodsCustoms_Restore());
		}

		#endregion tabCustoms 
		

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
				btnPrint.ShortCutSet(null);
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("DATA"))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled =
				btnDelete.Enabled = 
					false;
				btnPrint.Enabled =
				btnService.Enabled = 
					true;
				btnPrint.ShortCutSet(null);
				grdData.Select();
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("QUALIT"))
			{
				btnAdd.Enabled = true;
				btnEdit.Enabled =
				btnDelete.Enabled =
					(grdQualities.Rows.Count > 0 &&
					!grdQualities.IsStatusRow(grdQualities.CurrentRow.Index));
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				btnPrint.ShortCutSet(mnuGoodsQualitiesPrint); 
				grdQualities.Select();
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("VETER"))
			{
				btnAdd.Enabled = true;
				btnEdit.Enabled =
				btnDelete.Enabled =
					(grdVeterinaries.Rows.Count > 0 &&
					!grdVeterinaries.IsStatusRow(grdVeterinaries.CurrentRow.Index));
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				btnPrint.ShortCutSet(null);
				grdVeterinaries.Select();
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("CUSTOM"))
			{
	            btnAdd.Enabled = true;
				btnEdit.Enabled =
				btnDelete.Enabled =
					(grdCustoms.GridSource.Count > 0 &&
					!grdCustoms.IsStatusRow(grdCustoms.CurrentRow.Index));
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				btnPrint.ShortCutSet(null);
				grdCustoms.Select();
			}
		}

	#endregion Tab restore

	#region RowEnter, CellFormatting

		#region Top Grids 

		#region grdData (Goods)

		private void grdData_CurrentRowChanged(object sender)
		{
			if (grdData.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdData.DataSource == null)
				return;

			// статусная строка
			if (grdData.IsStatusRow(e.RowIndex))
			{
				if (grdData.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdData.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdData.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcGoodImage":
					if ((bool)r["IsGoodXXX"])
						e.Value = Properties.Resources.Flag;
					else
						e.Value = Properties.Resources.Empty;
					break;

				case "grcInBox":
					// весовые товары или товары с нецелым вложением в коробоку
					if (!Convert.IsDBNull(r["Weighting"]) &&
						Convert.ToBoolean(r["Weighting"]) ||
						!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
					{
						e.CellStyle.Format = "### ###.000";
					}
					else
					{
						e.CellStyle.Format = "### ###";
					}
					break;
			}

			// неактуальные - курсором 
			if (!(bool)r["GoodActual"] || !(bool)r["PackingActual"])
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);

		}

		#endregion grdData (Goods)

		#region grdQualities

		private void grdQualities_CurrentRowChanged(object sender)
		{
			if (grdQualities.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdQualities_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdQualities.DataSource == null)
				return;

			// статусная строка
			if (grdQualities.IsStatusRow(e.RowIndex))
			{
				if (grdQualities.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdQualities.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdQualities.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcQualities_InUseImage":
					if ((bool)r["InUse"])
						e.Value = Properties.Resources.Check;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
		}

		#endregion grdQualities

		#region grdVeterinaries

		private void grdVeterinaries_CurrentRowChanged(object sender)
		{
			if (grdVeterinaries.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdVeterinaries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdVeterinaries.DataSource == null)
				return;

			// статусная строка
			if (grdVeterinaries.IsStatusRow(e.RowIndex))
			{
				if (grdVeterinaries.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdVeterinaries.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdVeterinaries.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcVeterinaries_InUseImage":
					if ((bool)r["InUse"])
						e.Value = Properties.Resources.Check;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
		}

		#endregion grdVeterinaries

		#region grdCustoms

		private void grdCustoms_CurrentRowChanged(object sender)
		{
			if (grdCustoms.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdCustoms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdCustoms.DataSource == null)
				return;

			// статусная строка
			if (grdCustoms.IsStatusRow(e.RowIndex))
			{
				if (grdCustoms.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdCustoms.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdCustoms.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcCustoms_InUseImage":
					if ((bool)r["InUse"])
						e.Value = Properties.Resources.Check;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
		}

		#endregion grdCustoms

		#endregion Top Grids

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			if (tcList.CurrentPage.Name.ToUpper().Contains("DATA"))
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				btnPrint.Enabled =
				btnService.Enabled =
					true;

				if (grdData.CurrentRow == null)
					return;

				int rowIndex = grdData.CurrentRow.Index;

				if (grdData.IsStatusRow(rowIndex))
				{
					oGoodCur.ClearOne();
				}
				else
				{
					// заполнение объекта по текущей строке 
					DataRow r = ((DataRowView)((DataGridViewRow)grdData.Rows[rowIndex]).DataBoundItem).Row;
					oGoodCur.FillOne(r);
					// кнопки не включаем
				}
				tcGoods.SetAllNeedRestore(true);
			}

			if (tcList.CurrentPage.Name.ToUpper().Contains("QUALIT"))
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				
				if (grdQualities.CurrentRow == null)
					return;

				int rowIndex = grdQualities.CurrentRow.Index;

				if (!grdQualities.IsStatusRow(rowIndex))
				{
					btnEdit.Enabled =
					btnDelete.Enabled =
						true;
				}
				tcQualities.SetAllNeedRestore(true);
			}

			if (tcList.CurrentPage.Name.ToUpper().Contains("VETER"))
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				btnPrint.Enabled =
				btnService.Enabled =
					true;

				if (grdVeterinaries.CurrentRow == null)
					return;

				int rowIndex = grdVeterinaries.CurrentRow.Index;

				if (!grdVeterinaries.IsStatusRow(rowIndex))
				{
					btnEdit.Enabled =
					btnDelete.Enabled =
						true;
				}
				tcVeterinaries.SetAllNeedRestore(true);
			}

			if (tcList.CurrentPage.Name.ToUpper().Contains("CUSTOM"))
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				btnPrint.Enabled =
				btnService.Enabled =
					true;

				if (grdCustoms.CurrentRow == null)
					return;

				int rowIndex = grdCustoms.CurrentRow.Index;

				if (!grdCustoms.IsStatusRow(rowIndex))
				{
					btnEdit.Enabled =
					btnDelete.Enabled =
						true;
				}
				tcCustoms.SetAllNeedRestore(true);
			}
		}

		#region Bottom grids

		private void grdGoodsQualities_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdGoodsQualities.DataSource == null || grdData.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdData.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdGoodsQualities.IsStatusRow(e.RowIndex))
			{
				if (grdGoodsQualities.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdGoodsQualities.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdGoodsQualities.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcGoodsQualities_InUseImage":
					if ((bool)r["InUse"])
						e.Value = Properties.Resources.Check;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
		}

		private void grdGoodsVeterinaries_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdGoodsVeterinaries.DataSource == null || grdData.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdData.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdGoodsVeterinaries.IsStatusRow(e.RowIndex))
			{
				if (grdGoodsVeterinaries.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdGoodsVeterinaries.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdGoodsVeterinaries.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcGoodsVeterinaries_InUseImage":
					// нет такой колонки
					if ((bool)r["InUse"])
						e.Value = Properties.Resources.Check;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
		}

		private void grdGoodsCustoms_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdGoodsCustoms.DataSource == null || grdData.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdData.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdGoodsCustoms.IsStatusRow(e.RowIndex))
			{
				if (grdGoodsCustoms.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdGoodsCustoms.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdGoodsCustoms.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcGoodsCustoms_InUseImage":
					// нет такой колонки
					if ((bool)r["InUse"])
						e.Value = Properties.Resources.Check;
					else
						e.Value = Properties.Resources.Empty;
					break;
			}
		}


		private void grdQualitiesGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdQualitiesGoods.DataSource == null || grdQualities.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdQualities.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdQualities.IsStatusRow(grdQualities.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdQualitiesGoods.IsStatusRow(e.RowIndex))
			{
				if (grdQualitiesGoods.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdQualitiesGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdQualitiesGoods.Columns[e.ColumnIndex];

			// неактуальные - курсором 
			if (!(bool)r["GoodActual"])
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}


		private void grdVeterinariesGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdVeterinariesGoods.DataSource == null || grdVeterinaries.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdVeterinaries.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdVeterinaries.IsStatusRow(grdVeterinaries.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdVeterinaries.IsStatusRow(e.RowIndex))
			{
				if (grdVeterinaries.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdVeterinariesGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdVeterinariesGoods.Columns[e.ColumnIndex];

			// неактуальные - курсором 
			if (!(bool)r["GoodActual"])
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}


		private void grdCustomsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdCustomsGoods.DataSource == null || grdCustoms.DataSource == null)
				return;

			// нет активной строки в верхнем grid-е
			if (grdCustoms.CurrentRow == null)
				return;

			// статусная строка верхнего grid-а
			if (grdCustoms.IsStatusRow(grdCustoms.CurrentRow.Index))
				return;

			// статусная строка текущего grid-а
			if (grdCustoms.IsStatusRow(e.RowIndex))
			{
				if (grdCustoms.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdCustomsGoods.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdCustomsGoods.Columns[e.ColumnIndex];

			// неактуальные - курсором 
			if (!(bool)r["GoodActual"])
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
		}

		#endregion Bottom grids

		#endregion

	#region Restore

		#region Data (Goods)

		private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oGoodCur.ClearOne();

			oGoodList.ClearError();
			oGoodList.ClearFilters();
			oGoodList.GoodID = null;
			oGoodList.PackingID = null;

			// собираем условия
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oGoodList.PackingsIDList = ucSelectRecordIDForm_Packings.GetIdString();
			}

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oGoodList.FilterGoodNameContext = txtNameContext.Text.Trim().ToUpper();
			}
			if (txtGoodBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodList.FilterGoodBarCode = txtGoodBarCodeContext.Text.Trim().ToUpper();
			}
			if (txtPackingBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodList.FilterPackingBarCode = txtPackingBarCodeContext.Text.Trim().ToUpper();
			}

			// выбор 
			if (ucSelectRecordID_GoodsGroups.IsSelectedExist)
			{
				oGoodList.FilterGoodsGroupsList = ucSelectRecordID_GoodsGroups.GetIdString();
			}
			if (ucSelectRecordID_GoodsBrands.IsSelectedExist)
			{
				oGoodList.FilterGoodsBrandsList = ucSelectRecordID_GoodsBrands.GetIdString();
			}
            if (ucSelectRecordID_Countries.IsSelectedExist)
            {
                oGoodList.FilterCountriesList = ucSelectRecordID_Countries.GetIdString();
            }

			// checks
			if (optGoodActual.Checked)
			{
				oGoodList.FilterGoodsActual = true;
			}
			if (optGoodActualNot.Checked)
			{
				oGoodList.FilterGoodsActual = false;
			}
			if (optPackingActual.Checked)
			{
				oGoodList.FilterPackingsActual = true;
			}
			if (optPackingActualNot.Checked)
			{
				oGoodList.FilterPackingsActual = false;
			}
            if (optQualitiesExistsYes.Checked)
            {
                oGoodList.FilterQualitiesExists = true;
            }
            if (optQualitiesExistsNo.Checked)
            {
                oGoodList.FilterQualitiesExists = false;
            }
            if (optVeterinariesExistsYes.Checked)
            {
                oGoodList.FilterVeterinariesExists = true;
            }
            if (optVeterinariesExistsNo.Checked)
            {
                oGoodList.FilterVeterinariesExists = false;
            }

			// host
			if (nUserHostID.HasValue)
			{
				oGoodList.FilterHostsList = nUserHostID.ToString();
			}
			else 
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oGoodList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
            // 

			grdGoodsQualities.DataSource = null;
			grdGoodsVeterinaries.DataSource = null;
			grdGoodsCustoms.DataSource = null;

			grdData.GetGridState();

			oGoodList.FillData();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oGoodList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oGoodList.ErrorNumber == 0);
		}

		private bool grdGoodsQualities_Restore()
		{
			grdGoodsQualities.GetGridState();
			grdGoodsQualities.DataSource = null;
			if (grdData.Rows.Count == 0 ||
				!oGoodCur.GoodID.HasValue ||
				(grdData.CurrentRow != null && grdData.IsStatusRow(grdData.CurrentRow.Index)))
				return (true);

			oGoodCur.FillTableGoodsQualitiesMapping(null, (int)oGoodCur.GoodID, null);
			grdGoodsQualities.Restore(oGoodCur.TableGoodsQualitiesMapping);

			return (oGoodCur.ErrorNumber == 0);
		}

		private bool grdGoodsVeterinaries_Restore()
		{
			grdGoodsVeterinaries.GetGridState();
			grdGoodsVeterinaries.DataSource = null;
			if (grdData.Rows.Count == 0 ||
				!oGoodCur.GoodID.HasValue ||
				(grdData.CurrentRow != null && grdData.IsStatusRow(grdData.CurrentRow.Index)))
				return (true);

			oGoodCur.FillTableGoodsVeterinariesMapping(null, (int)oGoodCur.GoodID, null);
			grdGoodsVeterinaries.Restore(oGoodCur.TableGoodsVeterinariesMapping);

			return (oGoodCur.ErrorNumber == 0);
		}

		private bool grdGoodsCustoms_Restore()
		{
			grdGoodsCustoms.GetGridState();
			grdGoodsCustoms.DataSource = null;
			if (grdData.Rows.Count == 0 ||
				!oGoodCur.GoodID.HasValue ||
				(grdData.CurrentRow != null && grdData.IsStatusRow(grdData.CurrentRow.Index)))
				return (true);

			oGoodCur.FillTableGoodsCustoms(null, null, oGoodCur.GoodID.ToString(), false);
			grdGoodsCustoms.Restore(oGoodCur.TableGoodsCustoms);
			
			return (oGoodCur.ErrorNumber == 0);
		}

		#endregion Data (Goods)

		#region Qualities

		private bool grdQualities_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oGoodQualityList.ClearError();
			oGoodQualityList.ClearFilters();

			// собираем условия - сначала для списка товаров
			Good oGoodTemp = new Good();
			bool bFilter = false;

			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oGoodTemp.PackingsIDList = ucSelectRecordIDForm_Packings.GetIdString();
				bFilter = true;
			}

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterGoodNameContext = txtNameContext.Text.Trim().ToUpper();
				bFilter = true;
			}
			if (txtGoodBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterGoodBarCode = txtGoodBarCodeContext.Text.Trim().ToUpper();
				bFilter = true;
			}
			if (txtPackingBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterPackingBarCode = txtPackingBarCodeContext.Text.Trim().ToUpper();
				bFilter = true;
			}

			// выбор 
			if (ucSelectRecordID_GoodsGroups.IsSelectedExist)
			{
				oGoodTemp.FilterGoodsGroupsList = ucSelectRecordID_GoodsGroups.GetIdString();
				bFilter = true;
			}
            if (ucSelectRecordID_GoodsBrands.IsSelectedExist)
            {
				oGoodTemp.FilterGoodsBrandsList = ucSelectRecordID_GoodsBrands.GetIdString();
				bFilter = true;
			}
            if (ucSelectRecordID_Countries.IsSelectedExist)
            {
                oGoodTemp.FilterCountriesList = ucSelectRecordID_Countries.GetIdString();
                bFilter = true;
            }

			// checks
			if (optGoodActual.Checked)
			{
				oGoodTemp.FilterGoodsActual = true; bFilter = true;
			}
			if (optGoodActualNot.Checked)
			{
				oGoodTemp.FilterGoodsActual = false; bFilter = true;
			}
			if (optPackingActual.Checked)
			{
				oGoodTemp.FilterPackingsActual = true; bFilter = true;
			}
			if (optPackingActualNot.Checked)
			{
				oGoodTemp.FilterPackingsActual = false; bFilter = true;
			}
            if (optQualitiesExistsYes.Checked)
            {
                oGoodTemp.FilterQualitiesExists = true; bFilter = true;
            }
            if (optQualitiesExistsNo.Checked)
            {
                oGoodTemp.FilterQualitiesExists = false; bFilter = true;
            }
            if (optVeterinariesExistsYes.Checked)
            {
                oGoodTemp.FilterVeterinariesExists = true; bFilter = true;
            }
            if (optVeterinariesExistsNo.Checked)
            {
                oGoodTemp.FilterVeterinariesExists = false; bFilter = true;
            }
            // 

			string sGoodsQualitiesIDList = null;
			if (bFilter)
			{
				oGoodTemp.FillData();
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null)
					return (false);

				string sGoodsIDList = "";
				foreach (DataRow r in oGoodTemp.MainTable.Rows)
					sGoodsIDList += r["GoodID"].ToString().Trim() + ",";

				oGoodTemp.FillTableGoodsQualitiesMapping(null, null, sGoodsIDList);
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsQualitiesMapping == null)
					return (false);

				sGoodsQualitiesIDList = "";
				foreach (DataRow r in oGoodTemp.TableGoodsQualitiesMapping.Rows)
					sGoodsQualitiesIDList += r["GoodQualityID"].ToString().Trim() + ",";
			}

			grdQualitiesGoods.DataSource = null;

			grdQualities.GetGridState();

			oGoodQualityList.FillTableGoodsQualities(null, sGoodsQualitiesIDList);
			grdQualities.IsLockRowChanged = true;
			grdQualities.Restore(oGoodQualityList.TableGoodsQualities);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oGoodQualityList.ErrorNumber == 0);
		}

		private bool grdQualitiesGoods_Restore()
		{
			grdQualitiesGoods.GetGridState();
			grdQualitiesGoods.DataSource = null;
			if (grdQualities.Rows.Count == 0 ||
				(grdQualities.CurrentRow != null && grdQualities.IsStatusRow(grdQualities.CurrentRow.Index)))
				return (true);

			if (grdQualities.CurrentRow.Cells["grcQualities_ID"].Value == null)
				return (true);

			int nGoodQualityID = Convert.ToInt32(grdQualities.CurrentRow.Cells["grcQualities_ID"].Value);
			 
			oGoodQualityCur.FillTableGoodsQualitiesMapping(nGoodQualityID, null, null);
			DataTable dt;
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				if (_sGoodsIDList == null)
					_sGoodsIDList = GetGoodsIDList(ucSelectRecordIDForm_Packings.GetIdString());
				dt = CopyTable(oGoodQualityCur.TableGoodsQualitiesMapping, "dt",
					"GoodID in (" + RFMPublic.RFMUtilities.NormalizeList(_sGoodsIDList) + ")" +
					(nUserHostID.HasValue ? " and HostID = " + nUserHostID.ToString() : ""),
					"GoodAlias, QualityDateEnd desc");
			}
			else
			{
				if (nUserHostID.HasValue)
					dt = CopyTable(oGoodQualityCur.TableGoodsQualitiesMapping, "dt",
						"HostID = " + nUserHostID.ToString(), 
						"GoodAlias, QualityDateEnd desc");
				else
					dt = oGoodQualityCur.TableGoodsQualitiesMapping;
			}

			grdQualitiesGoods.Restore(dt);

			return (oGoodQualityCur.ErrorNumber == 0);
		}

		#endregion Qualities

		#region Veterinaries

		private bool grdVeterinaries_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oGoodVeterinaryList.ClearError();
			oGoodVeterinaryList.ClearFilters();

			// собираем условия - сначала для списка товаров
			Good oGoodTemp = new Good();
			bool bFilter = false;

			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oGoodTemp.PackingsIDList = ucSelectRecordIDForm_Packings.GetIdString();
				bFilter = true;
			}

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterGoodNameContext = txtNameContext.Text.Trim().ToUpper();
				bFilter = true;
			}
			if (txtGoodBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterGoodBarCode = txtGoodBarCodeContext.Text.Trim().ToUpper();
				bFilter = true;
			}
			if (txtPackingBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterPackingBarCode = txtPackingBarCodeContext.Text.Trim().ToUpper();
				bFilter = true;
			}

			// выбор 
			if (ucSelectRecordID_GoodsGroups.IsSelectedExist)
			{
				oGoodTemp.FilterGoodsGroupsList = ucSelectRecordID_GoodsGroups.GetIdString();
				bFilter = true;
			}
			if (ucSelectRecordID_GoodsBrands.IsSelectedExist)
			{
				oGoodTemp.FilterGoodsBrandsList = ucSelectRecordID_GoodsBrands.GetIdString();
				bFilter = true;
			}
            if (ucSelectRecordID_Countries.IsSelectedExist)
            {
                oGoodTemp.FilterCountriesList = ucSelectRecordID_Countries.GetIdString();
                bFilter = true;
            }

			// checks
			if (optGoodActual.Checked)
			{
				oGoodTemp.FilterGoodsActual = true; bFilter = true;
			}
			if (optGoodActualNot.Checked)
			{
				oGoodTemp.FilterGoodsActual = false; bFilter = true;
			}
			if (optPackingActual.Checked)
			{
				oGoodTemp.FilterPackingsActual = true; bFilter = true;
			}
			if (optPackingActualNot.Checked)
			{
				oGoodTemp.FilterPackingsActual = false; bFilter = true;
			}
            if (optQualitiesExistsYes.Checked)
            {
                oGoodTemp.FilterQualitiesExists = true; bFilter = true;
            }
            if (optQualitiesExistsNo.Checked)
            {
                oGoodTemp.FilterQualitiesExists = false; bFilter = true;
            }
            if (optVeterinariesExistsYes.Checked)
            {
                oGoodTemp.FilterVeterinariesExists = true; bFilter = true;
            }
            if (optVeterinariesExistsNo.Checked)
            {
                oGoodTemp.FilterVeterinariesExists = false; bFilter = true;
            }
            // 

			string sGoodsVeterinariesIDList = null;
			if (bFilter)
			{
				oGoodTemp.FillData();
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null)
					return (false);

				string sGoodsIDList = "";
				foreach (DataRow r in oGoodTemp.MainTable.Rows)
					sGoodsIDList += r["GoodID"].ToString().Trim() + ",";

				oGoodTemp.FillTableGoodsVeterinariesMapping(null, null, sGoodsIDList);
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.TableGoodsVeterinariesMapping == null)
					return (false);

				sGoodsVeterinariesIDList = "";
				foreach (DataRow r in oGoodTemp.TableGoodsVeterinariesMapping.Rows)
					sGoodsVeterinariesIDList += r["GoodVeterinaryID"].ToString().Trim() + ",";
			}

			grdVeterinariesGoods.DataSource = null;

			grdVeterinaries.GetGridState();

			oGoodVeterinaryList.FillTableGoodsVeterinaries(null, sGoodsVeterinariesIDList);
			grdVeterinaries.IsLockRowChanged = true;
			grdVeterinaries.Restore(oGoodVeterinaryList.TableGoodsVeterinaries);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oGoodVeterinaryList.ErrorNumber == 0);
		}

		private bool grdVeterinariesGoods_Restore()
		{
			grdVeterinariesGoods.GetGridState();
			grdVeterinariesGoods.DataSource = null;
			if (grdVeterinaries.Rows.Count == 0 ||
				(grdVeterinaries.CurrentRow != null && grdVeterinaries.IsStatusRow(grdVeterinaries.CurrentRow.Index)))
				return (true);

			if (grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ID"].Value == null)
				return (true);

			int nGoodVeterinaryID = Convert.ToInt32(grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ID"].Value);

			oGoodVeterinaryCur.FillTableGoodsVeterinariesMapping(nGoodVeterinaryID, null, null);

			DataTable dt;
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				if (_sGoodsIDList == null)
					_sGoodsIDList = GetGoodsIDList(ucSelectRecordIDForm_Packings.GetIdString());
				dt = CopyTable(oGoodVeterinaryCur.TableGoodsVeterinariesMapping, "dt",
					"GoodID in (" + RFMPublic.RFMUtilities.NormalizeList(_sGoodsIDList) + ")" +
					(nUserHostID.HasValue ? " and HostID = " + nUserHostID.ToString() : ""),
					"GoodAlias, VeterinaryName, VeterinaryProducer");
			}
			else
			{
				if (nUserHostID.HasValue)
					dt = CopyTable(oGoodVeterinaryCur.TableGoodsVeterinariesMapping, "dt",
						"HostID = " + nUserHostID.ToString(),
						"GoodAlias, VeterinaryName, VeterinaryProducer");
				else
					dt = oGoodVeterinaryCur.TableGoodsVeterinariesMapping;
			}

			grdVeterinariesGoods.Restore(dt);

			return (oGoodVeterinaryCur.ErrorNumber == 0);
		}

		#endregion Veterinaries 

		#region Customs

		private bool grdCustoms_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oGoodCustomList.ClearError();
			oGoodCustomList.ClearFilters();

			// собираем условия - сначала для списка товаров
			Good oGoodTemp = new Good();
			bool bFilter = false;

			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oGoodTemp.PackingsIDList = ucSelectRecordIDForm_Packings.GetIdString();
				bFilter = true;
			}

			// контексты
			if (txtNameContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterGoodNameContext = txtNameContext.Text.Trim().ToUpper();
				bFilter = true;
			}
			if (txtGoodBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterGoodBarCode = txtGoodBarCodeContext.Text.Trim().ToUpper();
				bFilter = true;
			}
			if (txtPackingBarCodeContext.Text.Trim().Length > 0)
			{
				oGoodTemp.FilterPackingBarCode = txtPackingBarCodeContext.Text.Trim().ToUpper();
				bFilter = true;
			}

			// выбор 
			if (ucSelectRecordID_GoodsGroups.IsSelectedExist)
			{
				oGoodTemp.FilterGoodsGroupsList = ucSelectRecordID_GoodsGroups.GetIdString();
				bFilter = true;
			}
			if (ucSelectRecordID_GoodsBrands.IsSelectedExist)
			{
				oGoodTemp.FilterGoodsBrandsList = ucSelectRecordID_GoodsBrands.GetIdString();
				bFilter = true;
			}
            if (ucSelectRecordID_Countries.IsSelectedExist)
            {
                oGoodTemp.FilterCountriesList = ucSelectRecordID_Countries.GetIdString();
                bFilter = true;
            }

			// checks
			if (optGoodActual.Checked)
			{
				oGoodTemp.FilterGoodsActual = true; bFilter = true;
			}
			if (optGoodActualNot.Checked)
			{
				oGoodTemp.FilterGoodsActual = false; bFilter = true;
			}
			if (optPackingActual.Checked)
			{
				oGoodTemp.FilterPackingsActual = true; bFilter = true;
			}
			if (optPackingActualNot.Checked)
			{
				oGoodTemp.FilterPackingsActual = false; bFilter = true;
			}
            if (optQualitiesExistsYes.Checked)
            {
                oGoodTemp.FilterQualitiesExists = true; bFilter = true;
            }
            if (optQualitiesExistsNo.Checked)
            {
                oGoodTemp.FilterQualitiesExists = false; bFilter = true;
            }
            if (optVeterinariesExistsYes.Checked)
            {
                oGoodTemp.FilterVeterinariesExists = true; bFilter = true;
            }
            if (optVeterinariesExistsNo.Checked)
            {
                oGoodTemp.FilterVeterinariesExists = false; bFilter = true;
            }
            //

			string sGoodsIDList = null;
			if (bFilter)
			{
				oGoodTemp.FillData();
				if (oGoodTemp.ErrorNumber != 0 || oGoodTemp.MainTable == null)
					return (false);

				sGoodsIDList = "";
				foreach (DataRow r in oGoodTemp.MainTable.Rows)
					sGoodsIDList += r["GoodID"].ToString().Trim() + ",";
			}

			grdCustomsGoods.DataSource = null;

			grdCustoms.GetGridState();

            oGoodCustomList.FillTableGoodsCustoms(null, null, sGoodsIDList, true);
			grdCustoms.IsLockRowChanged = true;
			grdCustoms.Restore(oGoodCustomList.TableGoodsCustoms);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oGoodCustomList.ErrorNumber == 0);
		}

		private bool grdCustomsGoods_Restore()
		{
			grdCustomsGoods.GetGridState();
			grdCustomsGoods.DataSource = null;
			if (grdCustoms.Rows.Count == 0 ||
				(grdCustoms.CurrentRow != null && grdCustoms.IsStatusRow(grdCustoms.CurrentRow.Index)))
				return (true);

			if (grdCustoms.CurrentRow.Cells["grcCustoms_CustomNumber"].Value == null)
				return (true);

			string sCustomNumber = grdCustoms.CurrentRow.Cells["grcCustoms_CustomNumber"].Value.ToString();
			DateTime dCustomDateBeg = (DateTime)grdCustoms.CurrentRow.Cells["grcCustoms_CustomDateBeg"].Value;

//			oGoodCustomCur.FillTableGoodsCustomsInInputsDocuments(sCustomNumber, dDateBeg, null);
//			grdCustomsGoods.Restore(oGoodCustomCur.TableGoodsCustomsInInputsDocuments);
			oGoodCustomCur.FillTableGoodsCustoms(sCustomNumber, dCustomDateBeg, null, false);

			DataTable dt;
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				if (_sGoodsIDList == null)
					_sGoodsIDList = GetGoodsIDList(ucSelectRecordIDForm_Packings.GetIdString());

				dt = CopyTable(oGoodCustomCur.TableGoodsCustoms, "dt",
					"GoodID in (" + RFMPublic.RFMUtilities.NormalizeList(_sGoodsIDList) + ")" +
					(nUserHostID.HasValue ? " and HostID = " + nUserHostID.ToString() : ""),
					"CustomNumber, CustomDateBeg, GoodAlias");
			}
			else
			{
				if (nUserHostID.HasValue)
					dt = CopyTable(oGoodCustomCur.TableGoodsCustoms, "dt",
						"HostID = " + nUserHostID.ToString(),
						"CustomNumber, CustomDateBeg, GoodAlias");
				else
					dt = oGoodCustomCur.TableGoodsCustoms;
			}
			
            grdCustomsGoods.Restore(dt);

			return (oGoodCustomCur.ErrorNumber == 0);
		}

		#endregion Customs 

	#endregion

	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabData":
					break;

				case "tabQualities":
					int? nGoodQualityID = null;
                    if (StartForm(new frmGoodsQualitiesEdit(nGoodQualityID)) == DialogResult.Yes)
					{
						nGoodQualityID = (int)GotParam.GetValue(0);
						grdQualities_Restore();
						if (nGoodQualityID.HasValue)
						{
							grdQualities.GridSource.Position = grdQualities.GridSource.Find("ID", nGoodQualityID);
						}
					}
					break;

				case "tabVeterinaries":
					int? nGoodVeterinaryID = null;
					if (StartForm(new frmGoodsVeterinariesEdit(nGoodVeterinaryID)) == DialogResult.Yes)
					{
						nGoodVeterinaryID = (int)GotParam.GetValue(0);
						grdVeterinaries_Restore();
						if (nGoodVeterinaryID.HasValue)
						{
							grdVeterinaries.GridSource.Position = grdVeterinaries.GridSource.Find("ID", nGoodVeterinaryID);
						}
					}
					break;

				case "tabCustoms":
                    string sCustomNumber = null;
					DateTime? dCustomDateBeg = null;
					if (StartForm(new frmGoodCustomsEdit(sCustomNumber, dCustomDateBeg)) == DialogResult.Yes)
                    {
						sCustomNumber = GotParam.GetValue(0).ToString();
						grdCustoms_Restore();
						if (sCustomNumber != null)
						{
							grdCustoms.GridSource.Position = grdCustoms.GridSource.Find("CustomNumber", sCustomNumber);
						}
					}
            		break;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabData":
					// только на просмотр
					if (grdData.CurrentRow == null)
						return;

					if (grdData.CurrentRow.Cells["grcGoodID"].Value == null)
						return;

					int nGoodID = (int)grdData.CurrentRow.Cells["grcGoodID"].Value;
					StartForm(new frmSysEdit("Goods", nGoodID, this, true));
					break;

				case "tabQualities":
					if (grdQualities.CurrentRow == null)
						return;

					if (grdQualities.CurrentRow.Cells["grcQualities_ID"].Value == null)
						return;

					int nGoodQualityID = (int)grdQualities.CurrentRow.Cells["grcQualities_ID"].Value;
					if (StartForm(new frmGoodsQualitiesEdit(nGoodQualityID)) == DialogResult.Yes)
					{
						grdQualities_Restore();
					}
					break;

				case "tabVeterinaries":
					if (grdVeterinaries.CurrentRow == null)
						return;

					if (grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ID"].Value == null)
						return;

					int nGoodVeterinaryID = (int)grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ID"].Value;
					if (StartForm(new frmGoodsVeterinariesEdit(nGoodVeterinaryID)) == DialogResult.Yes)
					{
						grdVeterinaries_Restore();
					}
					break;

				case "tabCustoms":
					if (grdCustoms.CurrentRow == null)
						return;

                    string sCustomNumber = ((string)grdCustoms.CurrentRow.Cells["grcCustoms_CustomNumber"].Value).Trim();
					DateTime dCustomDateBeg = (DateTime)grdCustoms.CurrentRow.Cells["grcCustoms_CustomDateBeg"].Value;
					if (StartForm(new frmGoodCustomsEdit(sCustomNumber, dCustomDateBeg)) == DialogResult.Yes)
                    {
                        grdCustoms_Restore();
                    }
                    break;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabData":
					break;

				case "tabQualities":
					if (grdQualities.CurrentRow == null)
						return;

					if (grdQualities.CurrentRow.Cells["grcQualities_ID"].Value == null)
						return;

					/*if (!Convert.IsDBNull(grdQualities.CurrentRow.Cells["grcQualities_ERPCode"].Value) &&
						grdQualities.CurrentRow.Cells["grcQualities_ERPCode"].Value != null)
					{
						RFMMessage.MessageBoxError("Запись о сертификате качества получена из host-системы...\n" + 
							"Удаление не производится.");
						return;
					}*/

					int nGoodQualityID = (int)grdQualities.CurrentRow.Cells["grcQualities_ID"].Value;
                    if (RFMMessage.MessageBoxYesNo("Удалить запись о декларации соответствия?") == DialogResult.Yes)
					{
						oGoodCur.ClearError();
						if (oGoodCur.DeleteGoodQuality(nGoodQualityID))
						{ 
							if (oGoodCur.ErrorNumber == 0)
							{
								grdQualities_Restore();
							}
						}
					}
					break;

				case "tabVeterinaries":
					if (grdVeterinaries.CurrentRow == null)
						return;

					if (grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ID"].Value == null)
						return;

					/*if (!Convert.IsDBNull(grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ERPCode"].Value) &&
						grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ERPCode"].Value != null)
					{
						RFMMessage.MessageBoxError("Запись о ветеринарном свидетельстве получена из host-системы...\n" +
							"Удаление не производится.");
						return;
					}*/

					int nGoodVeterinaryID = (int)grdVeterinaries.CurrentRow.Cells["grcVeterinaries_ID"].Value;
                    if (RFMMessage.MessageBoxYesNo("Удалить запись о ветеринарном свидетельстве?") == DialogResult.Yes)
					{
						oGoodCur.ClearError();
						if (oGoodCur.DeleteGoodVeterinary(nGoodVeterinaryID))
						{
							if (oGoodCur.ErrorNumber == 0)
							{
								grdVeterinaries_Restore();
							}
						}
					}
					break;

				case "tabCustoms":
					if (grdCustoms.CurrentRow == null)
						return;

                    if (grdCustoms.IsStatusRow(grdCustoms.CurrentRow.Index))
                        return;

                    /*if (!Convert.IsDBNull(grdCustomsGoods.CurrentRow.Cells["grcCustomsGoods_GoodERPCode"].Value) &&
                        grdCustomsGoods.CurrentRow.Cells["grcCustomsGoods_GoodERPCode"].Value != null)
                    {
                        RFMMessage.MessageBoxError("Запись о ГТД получена из host-системы...\n" +
                            "Удаление не производится.");
                        return;
                    }*/

                    string sCustomNumber = (string)grdCustoms.CurrentRow.Cells["grcCustoms_CustomNumber"].Value;

                    if (RFMMessage.MessageBoxYesNo("Удалить запись о ГТД " + sCustomNumber + "?") == DialogResult.Yes)
                    {
                        oGoodCur.ClearError();
                        if (oGoodCur.DeleteGoodCustom(sCustomNumber))
                        {
                            if (oGoodCur.ErrorNumber == 0)
                            {
                                grdCustoms_Restore();
                            }
                        }
                    }
                    break;
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

	#endregion
		
	#region Menu Print

	private void btnPrint_Click(object sender, EventArgs e)
	{
		btnPrint.ShortCutShow();
	}

    private void mniGoodsQualitiesValid_Click(object sender, EventArgs e)
    {
        GoodsQualitiesList(true);
    }

    private void mniGoodsQualitiesInvalid_Click(object sender, EventArgs e)
	{
		GoodsQualitiesList(false);
	}

	private void GoodsQualitiesList(bool bValid)
	{
		RFMDataGridView dgv = null;
		if (tcList.CurrentPage.Name.ToUpper().Contains("QUALITIES"))
			dgv = grdQualities;

		if (dgv == null ||
			dgv.DataSource == null ||
			dgv.Rows.Count == 0 ||
			dgv.CurrentRow == null)
			return;

		RFMCursorWait.Set(true);

		ActiveReport3 rep = new QualityList();
		Good oGood = new Good();
		DataTable dT = new DataTable();
		DataColumn dc = new DataColumn();
		dc.DataType = System.Type.GetType("System.Int32");
		dc.ColumnName = "GoodID";
		dT.Columns.Add(dc);

		if (tabData.IsNeedRestore)
		{
			grdData_Restore();
			tabData.IsNeedRestore = false;
		}

		grdData.IsRestoring = true;
		RFMBindingSource bs = grdData.GridSource;
		bs.MoveFirst();
		for (int i = 0; i < bs.Count; i++)
		{
			dT.Rows.Add((int)((DataRowView)bs.Current)["GoodID"]);
			bs.MoveNext();
		}
		grdData.IsRestoring = false;
		oGood.FillTableGoodsQualititiesList(bValid, dT);

		RFMCursorWait.Set(false);

		if (oGood.TableGoodsQualitiesList.Rows.Count > 0)
			this.StartForm(new frmActiveReport(oGood.TableGoodsQualitiesList, rep));
		else
			RFMMessage.MessageBoxInfo("Нет данных...");	
	}
		
	#endregion 

	#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
		}

	#endregion Service

	#region Filters

		#region Packings

		private void ucSelectRecordIDForm_Packings_Restore()
		{
			_sGoodsIDList = null;

			ucSelectRecordIDForm_Packings.SendParams = new object[] { ucSelectRecordIDForm_Packings, true };
			ucSelectRecordIDForm_Packings.Restore();
		}

		private void ucSelectRecordIDForm_Packings_TxtData_TextChanged(object sender, EventArgs e)
		{
			_sGoodsIDList = null;
		}

		private string GetGoodsIDList(string sPackingsIDList)
		{
			_sGoodsIDList = null;
			string sGoodsIDList = "";
			if (sPackingsIDList.Length > 0)
			{
				Good oGoodTemp = new Good();
				oGoodTemp.PackingsIDList = sPackingsIDList;
				oGoodTemp.FillData();
				if (oGoodTemp.ErrorNumber == 0 && oGoodTemp.MainTable != null && oGoodTemp.MainTable.Rows.Count > 0)
				{
					foreach (DataRow dg in oGoodTemp.MainTable.Rows)
					{
						sGoodsIDList += dg["GoodID"].ToString().Trim() + ",";
					}
				}
				if (sGoodsIDList == null)
				{
					sGoodsIDList = "-1";
				}
			}
			_sGoodsIDList = sGoodsIDList;
			return (sGoodsIDList);
		}

		#endregion Packings

		#region GoodsGroups

        private void ucSelectRecordID_GoodsGroups_Restore()
        {
            if (ucSelectRecordID_GoodsGroups.sourceData == null)
            {
                Good oGoodForGroups = new Good();
				if (Utilities.FillData_GoodsGroups(oGoodForGroups))
				{
					ucSelectRecordID_GoodsGroups.Restore(oGoodForGroups.TableGoodsGroups);
				}
            }
            else
            {
                ucSelectRecordID_GoodsGroups.Restore();
            }
        }

		#endregion GoodsGroups

		#region GoodsBrands

        private void ucSelectRecordID_GoodsBrands_Restore()
        {
            if (ucSelectRecordID_GoodsBrands.sourceData == null)
            {
                Good oGoodForBrands = new Good();
				if (Utilities.FillData_GoodsBrands(oGoodForBrands))
				{
	                ucSelectRecordID_GoodsBrands.Restore(oGoodForBrands.TableGoodsBrands);
				}
            }
            else
            {
                ucSelectRecordID_GoodsBrands.Restore();
            }
        }

		#endregion GoodsBrands

        #region Countries

        private void ucSelectRecordID_Countries_Restore()
        {
            if (ucSelectRecordID_Countries.sourceData == null)
            {
                Good oGoodCountries = new Good();
				if (Utilities.FillData_GoodsCountries(oGoodCountries))
				{
					ucSelectRecordID_Countries.Restore(oGoodCountries.TableCountries);
				}
            }
            else
            {
                ucSelectRecordID_Countries.Restore();
            }
        }

        #endregion

		#region Hosts

		private void ucSelectRecordID_Hosts_Restore()
		{
			if (ucSelectRecordID_Hosts.sourceData == null)
			{
				if (Utilities.FillData_Hosts(oHost))
				{
					ucSelectRecordID_Hosts.Restore(oHost.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Hosts.Restore();
			}
		}

		#endregion Hosts

	#endregion Filters

	#region Terms clear

        private void btnClearTerms_Click(object sender, EventArgs e)
		{
			ucSelectRecordIDForm_Packings.ClearData();
			_sGoodsIDList = null;

			txtNameContext.Text = "";
			txtGoodBarCodeContext.Text = "";
			txtPackingBarCodeContext.Text = "";

            ucSelectRecordID_GoodsGroups.ClearData();
            ucSelectRecordID_GoodsBrands.ClearData();
            ucSelectRecordID_Countries.ClearData();

			optGoodActual.Checked = 
    		optPackingActual.Checked = 
            optQualitiesExistsAll.Checked = 
            optVeterinariesExistsAll.Checked = 
                true;

			tabData.IsNeedRestore =
			tabQualities.IsNeedRestore =
			tabVeterinaries.IsNeedRestore =
			tabCustoms.IsNeedRestore =
				true;

			ucSelectRecordID_Hosts.ClearData();
		}

	#endregion

        private void grdQualities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

	}
}