using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics 
{
	public partial class frmCars : RFMFormChild
	{
		private Car oCarList; //список машин
		private Car oCarCur;  //текуща€ машина
		private CarType oCarTypeList; //список типов  машин
		private CarType oCarTypeCur;  //текущий тип машины

		private Trip oTripList;
		private Filling oFillingList;
		private Car oCarInTypeList;

		// дл€ фильтров
		public string _SelectedIDList;
		public string _SelectedText;

		public frmCars()
		{
			oCarList = new Car();
			oCarCur = new Car();
			oCarTypeList = new CarType();
			oCarTypeCur = new CarType();
			oTripList = new Trip();
			oFillingList = new Filling();
			oCarInTypeList = new Car();
			if (oCarList.ErrorNumber != 0 ||
				oCarCur.ErrorNumber != 0 ||
				oCarTypeList.ErrorNumber != 0||
				oCarTypeCur.ErrorNumber != 0 || 
				oTripList.ErrorNumber != 0 ||
				oFillingList.ErrorNumber != 0 ||
				oCarInTypeList.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmCars_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			// назначение суммировани€ и шрифта на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			btnClearTerms_Click(null, null);

			tcList.Init();
			tcCars.Init();
			tcCarsTypes.Init(); 

			RFMCursorWait.Set(false);
		}

	#region TabPages Restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnArrange.Enabled =
			btnConfirm.Enabled =
			btnPrint.Enabled =
			btnService.Enabled = false;

			txtCarNameContext.Select();

			return (true);
		}

		private bool tabCars_Restore()
		{
			grdCars_Restore();

			btnAdd.Enabled = true;
            
            btnArrange.Enabled =
            btnConfirm.Enabled =
            btnDelete.Enabled = false;

            if (grdCars.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = true;

                grdCars.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = false;
			}
			return (true);
		}

		private bool tabCarsTypes_Restore()
		{
			grdCarsTypes_Restore();

			btnAdd.Enabled = true;

            btnArrange.Enabled =
            btnConfirm.Enabled =
            btnDelete.Enabled = false;

            if (grdCarsTypes.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = true;

				grdCarsTypes.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = false;
			}
			return (true);
		}

		#region TabPages bottom Restore

		private bool tabCars_Trips_Restore()
		{
			return (grdCars_Trips_Restore());
		}

		private bool tabCars_Fillings_Restore()
		{
			return (grdCars_Fillings_Restore());
		}

		private bool tabCarsTypes_Cars_Restore()
		{
			return (grdCarsTypes_Cars_Restore());
		}

		#endregion TabPages bottom Restore

	#endregion TabPages Restore

	#region Prepare IDList

		public void CarPrepareIDList(Car oCar, bool bMultiSelect)
		{
			oCar.ID = null;
			oCar.IDList = null;
			int? nCarID = 0;
			if (bMultiSelect && grdCars.IsCheckerShow)
			{
				oCar.IDList = "";

				DataView dMarked = new DataView(oCarList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdCars.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nCarID = (int)r["ID"];
						oCar.IDList = oCar.IDList + nCarID.ToString() + ",";
					}
				}
			}
			else
			{
				nCarID = (int?)grdCars.CurrentRow.Cells["grcID"].Value;
				if (nCarID.HasValue)
				{
					oCar.ID = nCarID;
				}
			}
		}

	#endregion Prepare IDList

	#region RowEnter, CellFormatting

		private void grdCars_CurrentRowChanged(object sender)
		{
			if (grdCars.IsLockRowChanged)
				return;

			tmrRestore.Enabled = true;
		}

		private void grdCarsTypes_CurrentRowChanged(object sender)
		{
			if (grdCarsTypes.IsLockRowChanged)
				return;

			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView grd;

			if (tcList.CurrentPage.Name.ToUpper().Contains("TYPES"))
			{
				grd = grdCarsTypes;
			}
			else
			{
				grd = grdCars;
			}

			if (grd.CurrentRow == null)
				return;

			int rowIndex = grd.CurrentRow.Index;

			string sGrdName = grd.Name;

			if (grd.IsStatusRow(rowIndex))
			{
				switch (sGrdName)
				{
					case "grdCars":
						oCarCur.ClearOne();
						break;
					case "grdCarsTypes":
						oCarTypeCur.ClearOne();
						break;
				}

				btnEdit.Enabled =
				btnArrange.Enabled =
				btnConfirm.Enabled = 
				btnDelete.Enabled =
				btnPrint.Enabled = 
				btnService.Enabled = false;
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
				switch (sGrdName)
				{
					case "grdCars":
						oCarCur.FillOne(r);
						tcCars.SetAllNeedRestore(true);
						break;
					case "grdCarsTypes":
						oCarTypeCur.FillOne(r);
						tcCarsTypes.SetAllNeedRestore(true);
						break;
				}
				// можно проверить какой-нибудь статус и в зависимости от него включить/выключить кнопки 
                btnArrange.Enabled =
                btnConfirm.Enabled =
                btnDelete.Enabled = false;

                btnEdit.Enabled = 
				btnPrint.Enabled = 
				btnService.Enabled = true;
			}
		}

		private void grdGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (((RFMDataGridView)sender).DataSource == null)
				return;

			RFMDataGridView grd = (RFMDataGridView)sender;
			string sGrdName = grd.Name;

			// статусна€ строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.Contains("Image"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			if (sColumnName.Contains("TripStatusImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["TripStatus"]))
				{
					// 0 не вышла, 1 в пути, 2 пришла
					switch ((int)r["TripStatus"])
					{
						case 0:
							e.Value = Properties.Resources.DotRed;
							break;
						case 1:
							e.Value = Properties.Resources.DotYellow;
							break;
						case 2:
							e.Value = Properties.Resources.DotGreen;
							break;
						default:
							e.Value = Properties.Resources.Empty;
							break;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("_IsConfirmedImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Check;
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			// Netto, Brutto
			if (c.Name.Contains("tto") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

	#endregion 

	#region Restore

		#region Grids top Restore 

		private bool grdCars_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oCarCur.ClearOne();

			oCarList.ClearError();
			oCarList.ClearFilters();
			oCarList.ID = null;
			oCarList.IDList = null; 

			// собираем услови€

			// контекст названи€ и номера
			if (txtCarNameContext.Text.Trim().Length > 0)
			{
				oCarList.FilterCarNameContext = txtCarNameContext.Text.Trim().ToUpper();
			}
			if (txtCarNumberContext.Text.Trim().Length > 0)
			{
				oCarList.FilterCarNumberContext = txtCarNumberContext.Text.Trim().ToUpper();
			}
			// выбор из списков
			if (ucSelectRecordID_Cars.IsSelectedExist)
			{
				oCarList.IDList = ucSelectRecordID_Cars.GetIdString();
			}
			if (ucSelectRecordID_CarsTypes.IsSelectedExist)
			{
				oCarList.FilterCarsTypesList = ucSelectRecordID_CarsTypes.GetIdString();
			}
			if (ucSelectRecordID_CarsClasses.IsSelectedExist)
			{
                oCarList.FilterCarsClassesList = ucSelectRecordID_CarsClasses.GetIdString();
			}

			// актуальность 
			if (optActual.Checked)
			{
				oCarList.FilterActual = true;
			}
			if (optActualNot.Checked)
			{
				oCarList.FilterActual = false;
			}

			// работает
			if (optOperable.Checked)
			{
				oCarList.FilterOperable = true;
			}
			if (optOperableNot.Checked)
			{
				oCarList.FilterOperable = false;
			}

			// дл€ товара?
			if (optForGoodsOnly.Checked)
			{
				oCarList.FilterForGoodsOnly = true;
			}
			if (optForGoodsOnlyNot.Checked)
			{
				oCarList.FilterForGoodsOnly = false;
			}

			grdCars_Trips.DataSource = null;
			grdCars_Fillings.DataSource = null;

			grdCars.GetGridState();

			oCarList.FillData();
			grdCars.IsLockRowChanged = true;
			grdCars.Restore(oCarList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oCarList.ErrorNumber == 0);
		}

		private bool grdCarsTypes_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oCarTypeCur.ClearOne();

			oCarTypeList.ClearError();
			oCarTypeList.ClearFilters();
			oCarTypeList.ID = null;
			oCarTypeList.IDList = null;

			// собираем услови€
			// выбор из списков
			if (ucSelectRecordID_CarsTypes.IsSelectedExist)
			{
				oCarTypeList.IDList = ucSelectRecordID_CarsTypes.GetIdString();
			}

			// актуальность 
			if (optActual.Checked)
			{
				oCarTypeList.FilterActual = true;
			}
			if (optActualNot.Checked)
			{
				oCarTypeList.FilterActual = false;
			}

			grdCarsTypes_Cars.DataSource = null;

			grdCarsTypes.GetGridState();

			oCarTypeList.FillData();
			grdCarsTypes.IsLockRowChanged = true;
			grdCarsTypes.Restore(oCarTypeList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oCarTypeList.ErrorNumber == 0);
		}

		#endregion Grids top Restore

		#region Grids bottom Restore

		private bool grdCars_Trips_Restore()
		{
			grdCars_Trips.GetGridState();
			grdCars_Trips.DataSource = null;
			if (grdCars.Rows.Count == 0 || 
				oCarCur.ID == null ||
				(grdCars.CurrentRow != null && grdCars.IsStatusRow(grdCars.CurrentRow.Index)))
				return (true);

			oTripList.ClearFilters();
			oTripList.FilterCarsList = oCarCur.ID.ToString();
			if (!dtrDatesHistory.dtpBegDate.IsEmpty)
				oTripList.FilterDateBeg = dtrDatesHistory.dtpBegDate.Value;
			if (!dtrDatesHistory.dtpEndDate.IsEmpty)
				oTripList.FilterDateEnd = dtrDatesHistory.dtpEndDate.Value;
			oTripList.FillData();
			grdCars_Trips.Restore(oTripList.MainTable);

			return (oTripList.ErrorNumber == 0);
		}

		private bool grdCars_Fillings_Restore()
		{
			grdCars_Fillings.GetGridState(); 
			grdCars_Fillings.DataSource = null;
			if (grdCars.Rows.Count == 0 ||
				oCarCur.ID == null ||
				(grdCars.CurrentRow != null && grdCars.IsStatusRow(grdCars.CurrentRow.Index)))
				return (true);

			oFillingList.ClearFilters();
			oFillingList.FilterCarsList = oCarCur.ID.ToString();
			if (!dtrDatesHistory.dtpBegDate.IsEmpty)
				oFillingList.FilterDateBeg = dtrDatesHistory.dtpBegDate.Value;
			if (!dtrDatesHistory.dtpEndDate.IsEmpty)
				oFillingList.FilterDateEnd = dtrDatesHistory.dtpEndDate.Value;
			oFillingList.FillData();
			grdCars_Fillings.Restore(oFillingList.MainTable);

			return (oFillingList.ErrorNumber == 0);
		}

		private bool grdCarsTypes_Cars_Restore()
		{
			grdCarsTypes_Cars.GetGridState(); 
			grdCarsTypes_Cars.DataSource = null;
			if (grdCarsTypes.Rows.Count == 0 ||
				oCarTypeCur.ID == null ||
				(grdCarsTypes.CurrentRow != null && grdCarsTypes.IsStatusRow(grdCarsTypes.CurrentRow.Index)))
				return (true);

			oCarInTypeList.FilterCarsTypesList = oCarTypeCur.ID.ToString();
			oCarInTypeList.FillData();
			grdCarsTypes_Cars.Restore(oCarInTypeList.MainTable);

			return (oCarList.ErrorNumber == 0);
		}

		#endregion Grids bottom Restore
		
	#endregion

	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabCars":
					if (StartForm(new frmCarsEdit(null, false)) == DialogResult.Yes)
					{
						int nCarID = (int)GotParam.GetValue(0);
						grdCars_Restore();
						if (nCarID > 0)
						{
							grdCars.GridSource.Position = grdCars.GridSource.Find(oCarList.ColumnID, nCarID);
						}
					}
					break;
				case "tabCarsTypes":
					if (StartForm(new frmCarsTypesEdit(null)) == DialogResult.Yes)
					{
						int nCarTypeID = (int)GotParam.GetValue(0);
						grdCarsTypes_Restore();
						if (nCarTypeID > 0)
						{
							grdCarsTypes.GridSource.Position = grdCarsTypes.GridSource.Find(oCarTypeList.ColumnID, nCarTypeID);
						}
					}
					break;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabCars":
					if (grdCars.CurrentRow == null)
						return;
					if (!oCarCur.ID.HasValue)
						return;
					// перечитать, можно после этого выполнить какие-нибудь проверки 
					if (oCarCur.ReFillOne((int)oCarCur.ID))
					{
						if (StartForm(new frmCarsEdit((int)oCarCur.ID, false)) == DialogResult.Yes)
						{
							grdCars_Restore();
						}
					}
					break;
				case "tabCarsTypes":
					if (grdCarsTypes.CurrentRow == null)
						return;
					if (!oCarTypeCur.ID.HasValue)
						return;
					// перечитать
					if (oCarTypeCur.ReFillOne((int)oCarTypeCur.ID))
					{
						if (StartForm(new frmCarsTypesEdit((int)oCarTypeCur.ID)) == DialogResult.Yes)
						{
							grdCarsTypes_Restore();
						}
					}
					break;
			}
		}

		private void btnArrange_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ќе используетс€...");
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Ќе используетс€...");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabCars":
					if (grdCars.CurrentRow == null)
						return;
					if (!oCarCur.ID.HasValue)
						return;
					// перечитать, можно после этого выполнить какие-нибудь проверки 
					if (oCarCur.ReFillOne((int)oCarCur.ID))
					{
						if (RFMMessage.MessageBoxYesNo("”далить данные о машине?") == DialogResult.Yes)
						{
							Refresh();
							WaitOn(this);
							if (oCarCur.DeleteOne((int)oCarCur.ID))
							{
								WaitOff(this);
								if (oCarCur.ErrorNumber == 0)
								{
									//RFMMessage.MessageBoxInfo("ƒанные о машине удалены.");
									grdCars_Restore();
								}
								else
								{
									RFMMessage.MessageBoxError("ќшибка при удалении данных о машине...");
								}
							}
							WaitOff(this);
						}
					}
					break;
				case "tabCarsTypes":
					if (grdCarsTypes.CurrentRow == null)
						return;
					if (!oCarTypeCur.ID.HasValue)
						return;
					// перечитать
					if (oCarTypeCur.ReFillOne((int)oCarTypeCur.ID))
					{
						if (RFMMessage.MessageBoxYesNo("”далить данные о типе машины\n(возможно, только если нет машин такого типа)?") == DialogResult.Yes)
						{
							Refresh();
							WaitOn(this);
							if (oCarTypeCur.DeleteOne((int)oCarTypeCur.ID))
							{
								WaitOff(this);
								if (oCarTypeCur.ErrorNumber == 0)
								{
									//RFMMessage.MessageBoxInfo("ƒанные о типе машин удалены.");
									grdCarsTypes_Restore();
								}
								else
								{
									RFMMessage.MessageBoxError("ќшибка при удалении типа машин...");
								}
							}
							WaitOff(this);
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
		}

	#endregion 

	#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
		}

	#endregion

	#region Filters Choose

		#region CarsTypes

        private void ucSelectRecordID_CarsTypes_Restore()
        {
            if (ucSelectRecordID_CarsTypes.sourceData == null)
            {
                CarType oCarType = new CarType();
                if (Utilities.FillData_CarsTypes(oCarType))
                {
					ucSelectRecordID_CarsTypes.Restore(oCarType.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_CarsTypes.Restore();
            }
        }

		#endregion CarsTypes

		#region CarsClasses

        private void ucSelectRecordID_CarsClasses_Restore()
        {
            if (ucSelectRecordID_CarsClasses.sourceData == null)
            {
                Car oCarForClasses = new Car();
				if (Utilities.FillData_CarsClasses(oCarForClasses))
				{
					ucSelectRecordID_CarsClasses.Restore(oCarForClasses.TableCarsClasses);
				}
            }
            else
            {
                ucSelectRecordID_CarsClasses.Restore();
            }
        }

		#endregion CarsClasses

		#region Cars

        private void ucSelectRecordID_Cars_Restore()
        {
            if (ucSelectRecordID_Cars.sourceData == null)
            {
                Car oCar = new Car();
                if (Utilities.FillData_Cars(oCar))
				{
	                ucSelectRecordID_Cars.Restore(oCar.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_Cars.Restore();
            }
        }

		#endregion Cars

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			txtCarNameContext.Text = "";
			txtCarNumberContext.Text = "";

            ucSelectRecordID_Cars.ClearData();
            ucSelectRecordID_CarsClasses.ClearData();
            ucSelectRecordID_CarsTypes.ClearData();

			optActual.Checked = true;
			optOperable.Checked = true;
			optForGoodsOnly.Checked = true;

			tabCars.IsNeedRestore =
			tabCarsTypes.IsNeedRestore = 
				true;

			dtrDatesHistory.dtpBegDate.Value = DateTime.Now.Date.AddMonths(-1).AddDays(1);
			dtrDatesHistory.dtpEndDate.Value = DateTime.Now.Date;
		}

	#endregion

	}
}