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

// для печати бланка 
using System.Diagnostics;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace Logistics
{
	public partial class frmWayBills : RFMFormChild
	{
		private WayBill oWayBillList; // список пут.листов
		private WayBill oWayBillCur;  // текущий пут.лист
		private Filling oFillingList; // список заправок
		private Filling oFillingCur;  // текущая заправка

		private Trip oTripInWayBillList; // рейсы по пут.листу
		private Filling oFillingInWayBillList; // заправки по пут.листу

		private WayBill oWayBillTemp;
		private Trip oTripTemp;


		public frmWayBills()
		{
			// для основных таблиц
			oWayBillList = new WayBill();
			oWayBillCur = new WayBill();
			oFillingList = new Filling();
			oFillingCur = new Filling();
			if (oWayBillList.ErrorNumber != 0 ||
				oWayBillCur.ErrorNumber != 0 ||
				oFillingList.ErrorNumber != 0 ||
				oFillingCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			// для связанных таблиц 
			if (IsValid)
			{
				oTripInWayBillList = new Trip();
				oFillingInWayBillList = new Filling();
				if (oTripInWayBillList.ErrorNumber != 0 ||
					oFillingInWayBillList.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			// для отображения таблиц 
			if (IsValid)
			{
				oWayBillTemp = new WayBill();
				oTripTemp = new Trip();
				if (oWayBillTemp.ErrorNumber != 0 ||
					oTripTemp.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmWayBills_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			btnClearTerms_Click(null, null);

			tcList.Init();

			dtrDates.dtpBegDate.Select();

			RFMCursorWait.Set(false);
		}

		#region TabPages Restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnPrint.Enabled =
			btnService.Enabled = false;

			dtrDates.DtpBegDate.Select();

			return (true);
		}

		private bool tabWayBills_Restore()
		{
			grdWayBills_Restore();
			btnAdd.Enabled = true;
			if (grdWayBills.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = true;

				grdWayBills.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = false;
			}
			return (true);
		}

		private bool tabFillings_Restore()
		{
			grdFillings_Restore();
			btnAdd.Enabled = false;
			btnEdit.Enabled = false;
			if (grdFillings.Rows.Count > 0)
			{
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = true;

				grdFillings.Select();
			}
			else
			{
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = false;
			}
			return (true);
		}

		#region TabPages bottom Restore

		private bool tabWayBills_Trips_Restore()
		{
			return (grdWayBills_Trips_Restore());
		}

		private bool tabWayBills_Fillings_Restore()
		{
			return (grdWayBills_Fillings_Restore());
		}

		#endregion TabPages bottom Restore

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled = // не исп.
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = false;
			}
			
			if (tcList.SelectedTab.Name.ToUpper().Contains("WAYBILL"))
			{
				btnAdd.Enabled = true;
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdWayBills.Select();
				btnPrint.ShortCutSet(mnuWayBillsPrint);
				btnService.ShortCutSet(mnuWayBillsService);
				if (grdWayBills.Rows.Count > 0 && grdWayBills.CurrentRow != null)
				{
					if (!tabWayBills.IsNeedRestore)
					{
						if (!grdWayBills.IsStatusRow(grdWayBills.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdWayBills.CurrentRow.DataBoundItem).Row;
							oWayBillCur.ID = Convert.ToInt32(r["ID"]);
							grdWayBills_CurrentRowChanged(null);
						}
					}
				}
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("FILLING"))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
				grdFillings.Select();
				btnPrint.ShortCutSet(null);
				btnService.ShortCutSet(null);
				if (grdFillings.Rows.Count > 0 && grdFillings.CurrentRow != null)
				{
					if (!tabFillings.IsNeedRestore)
					{
						if (!grdFillings.IsStatusRow(grdFillings.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdFillings.CurrentRow.DataBoundItem).Row;
							oFillingCur.ID = Convert.ToInt32(r["ID"]);
						}
					}
				}
			}
		}

		#endregion TabPages Restore

		#region Prepare IDList

		public void WayBillPrepareIDList(WayBill oWayBill, bool bMultiSelect)
		{
			oWayBill.ID = null;
			oWayBill.IDList = null;
			int? nWayBillID = 0;
			if (bMultiSelect && grdWayBills.IsCheckerShow)
			{
				oWayBill.IDList = "";

				DataView dMarked = new DataView(oWayBillList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdWayBills.GridSource.Sort;
				foreach (DataRowView r in dMarked)
				{
					if (!Convert.IsDBNull(r["ID"]))
					{
						nWayBillID = (int)r["ID"];
						oWayBill.IDList = oWayBill.IDList + nWayBillID.ToString() + ",";
					}
				}
			}
			else
			{
				nWayBillID = (int?)grdWayBills.CurrentRow.Cells["grcWayBills_ID"].Value;
				if (nWayBillID.HasValue)
				{
					oWayBill.ID = nWayBillID;
				}
			}
		}

		#endregion Prepare IDList

		#region RowEnter, CellFormatting

		private void grdWayBills_CurrentRowChanged(object sender)
		{
			if (grdWayBills.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;
			
			if (grdWayBills.CurrentRow == null)
			   return;
			
			int rowIndex = grdWayBills.CurrentRow.Index;

			btnPrint.Enabled =
			btnService.Enabled =
				true;

			if (grdWayBills.IsStatusRow(rowIndex))
			{
				oWayBillCur.ClearOne();
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow r = ((DataRowView)((DataGridViewRow)grdWayBills.Rows[rowIndex]).DataBoundItem).Row;
				oWayBillCur.FillOne(r);
				btnEdit.Enabled = (!oWayBillCur.IsConfirmed);
				btnDelete.Enabled = (!oWayBillCur.IsConfirmed);

				mniWayBillConfirm.Enabled = !oWayBillCur.IsConfirmed;
				mniWayBillUnConfirm.Enabled = oWayBillCur.IsConfirmed; 
			}
			tcWayBills.SetAllNeedRestore(true);
		}

		private void grdWayBills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdWayBills.DataSource == null)
				return;

			// статусная строка
			if (grdWayBills.IsStatusRow(e.RowIndex))
			{
				if (grdWayBills.Columns[e.ColumnIndex].Name.Contains("Image"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grdWayBills.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grdWayBills.Columns[e.ColumnIndex];
			oWayBillTemp.FillOne(r);
			switch (c.Name)
			{
				case "grcWayBills_Image":
					if (oWayBillTemp.IsConfirmed) // (Convert.ToBoolean(r["IsConfirmed"]))
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						e.Value = Properties.Resources.Empty;
					}
					break;
			}

			if (c.Name.Contains("tto") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void grdWayBills_Trips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdWayBills_Trips.DataSource == null)
				return;

			RFMDataGridView grd = grdWayBills_Trips;

			// статусная строка
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
			oTripTemp.FillOne(r);
			switch (c.Name)
			{
				case "grcWayBill_Trip_TripConfirmImage":
                    if ((bool)r["IsConfirmed"])
                    {
                        e.Value = Properties.Resources.Check;
                    }
                    else
                    {
                        e.Value = Properties.Resources.Empty;
                    }
					break;
			}

			if (c.Name.Contains("tto") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void grdWayBills_Fillings_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdWayBills_Fillings.DataSource == null)
				return;

			// нечего обрабатывать: нет картинок или спец.данных
		}

		#endregion

		#region Restore

		private bool grdWayBills_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oWayBillCur.ClearOne();

			oWayBillList.ClearError();
			oWayBillList.ClearFilters();
			oWayBillList.ID = null;
			oWayBillList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oWayBillList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oWayBillList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// закрыт?
			if (optIsConfirmed.Checked)
			{
				oWayBillList.FilterIsConfirmed = true;
			}
			if (optIsConfirmedNot.Checked)
			{
				oWayBillList.FilterIsConfirmed = false;
			}

			// типы машин, машины, водители
			oWayBillList.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
			oWayBillList.FilterCarsTypesList = ucSelectRecordID_CarsTypes.GetIdString();
			oWayBillList.FilterDriversEmployeesList = ucSelectRecordID_Drivers.GetIdString();
			//

			grdWayBills_Trips.DataSource = null;
			grdWayBills_Fillings.DataSource = null;
			
			grdWayBills.GetGridState();
			oWayBillList.FillDataAsync();
			grdWayBills.IsLockRowChanged = true;
			grdWayBills.Restore(oWayBillList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oWayBillList.ErrorNumber == 0);
		}

		private bool grdWayBills_Trips_Restore()
		{
			grdWayBills_Trips.GetGridState();
			grdWayBills_Trips.DataSource = null;
			if (grdWayBills.Rows.Count == 0 ||
				oWayBillCur.ID == null ||
				(grdWayBills.CurrentRow != null && grdWayBills.IsStatusRow(grdWayBills.CurrentRow.Index)))
				return (true);

			oTripInWayBillList.FilterWayBillsList = oWayBillCur.ID.ToString();
			oTripInWayBillList.FillDataAsync();
			grdWayBills_Trips.Restore(oTripInWayBillList.MainTable);

			return (oTripInWayBillList.ErrorNumber == 0);
		}

		private bool grdWayBills_Fillings_Restore()
		{
			grdWayBills_Fillings.GetGridState();
			grdWayBills_Fillings.DataSource = null;
			if (grdWayBills.Rows.Count == 0 ||
				oWayBillCur.ID == null ||
				(grdWayBills.CurrentRow != null && grdWayBills.IsStatusRow(grdWayBills.CurrentRow.Index)))
				return (true);

			oFillingInWayBillList.FilterWayBillsList = oWayBillCur.ID.ToString();
			oFillingInWayBillList.FillDataAsync();
			grdWayBills_Fillings.Restore(oFillingInWayBillList.MainTable);

			return (oFillingInWayBillList.ErrorNumber == 0);
		}


		private bool grdFillings_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oFillingCur.ClearOne();

			oFillingList.ClearError();
			oFillingList.ClearFilters();
			oFillingList.ID = null;
			oFillingList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oFillingList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oFillingList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// машины, типы, водители
			oFillingList.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
			oFillingList.FilterCarsTypesList = ucSelectRecordID_CarsTypes.GetIdString();
			oFillingList.FilterDriversEmployeesList = ucSelectRecordID_Drivers.GetIdString();
			// типы заправок, типы топлива
			oFillingList.FilterFillingsTypesList = ucSelectRecordID_FillingsTypes.GetIdString();
			oFillingList.FilterFuelTypesList = ucSelectRecordID_FuelTypes.GetIdString();
			// 

			grdFillings.GetGridState();
			oFillingList.FillDataAsync();
			grdFillings.IsLockRowChanged = true;
			grdFillings.Restore(oFillingList.MainTable);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oFillingList.ErrorNumber == 0);
		}

		#endregion

		#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabWayBills":
                    DialogResult result = StartForm(new frmWayBillsEdit(null));
                    grdWayBills_Restore();

                    if (result == DialogResult.Yes)
					{
						int nWayBillID = (int)GotParam.GetValue(0);
						if (nWayBillID > 0)
						{
							grdWayBills.GridSource.Position = grdWayBills.GridSource.Find(oWayBillList.ColumnID, nWayBillID);
						}
					}
                    break;
				case "tabFillings":
					// не используется
					break;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabWayBills":
					if (grdWayBills.CurrentRow == null)
						return;
					if (!oWayBillCur.ID.HasValue)
						return;
					// перечитать, после этого выполнить проверки 
					if (oWayBillCur.ReFillOne((int)oWayBillCur.ID))
					{
						if (oWayBillCur.IsConfirmed)
						{
							RFMMessage.MessageBoxError("Путевой лист уже закрыт.\nРедактирование невозможно.");
							return;
						}

						if (StartForm(new frmWayBillsEdit((int)oWayBillCur.ID), false) == DialogResult.Yes)
						{
							grdWayBills_Restore();
						}
					}
					break;
				case "tabFillings":
					// не используется
					break;
			}
		}

		private void btnArrange_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Не используется...");
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Не используется...");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabWayBills":
					if (grdWayBills.CurrentRow == null)
						return;
					if (!oWayBillCur.ID.HasValue)
						return;
					// перечитать, после этого выполнить проверки 
					if (oWayBillCur.ReFillOne((int)oWayBillCur.ID))
					{
						if (oWayBillCur.IsConfirmed)
						{
							RFMMessage.MessageBoxError("Путевой лист уже закрыт.\nУдаление невозможно.");
							return;
						}

						if (RFMMessage.MessageBoxYesNo("Удалить данные о путевом листе?") == DialogResult.Yes)
						{
							Refresh();
							WaitOn(this);
							if (oWayBillCur.DeleteOne((int)oWayBillCur.ID))
							{
								WaitOff(this);
								if (oWayBillCur.ErrorNumber == 0)
								{
									//RFMMessage.MessageBoxInfo("Данные о путевом листе удалены.");
									grdWayBills_Restore();
								}
								else
								{
									RFMMessage.MessageBoxError("Ошибка при удалении данных о путевом листе...");
								}
							}
							WaitOff(this);
						}
					}
					break;
				case "tabFillings":
					// не исп.
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
			if (tcList.CurrentPage.Name.ToUpper().Contains("WAYBILL"))
			{
				btnPrint.ShortCutShow();
			}
		}

		private void mniWayBillPrint_Click(object sender, EventArgs e)
		{
			WayBillPrint(false);
		}

		private void mniWayBillPrint_ReportFuel_Click(object sender, EventArgs e)
		{
			ReportFuel();
		}

		private void WayBillPrint(bool bAll)
		{
			if (grdWayBills.CurrentRow == null) return;

			RFMCursorWait.Set(true);

			WayBill oWayBillPrint = new WayBill();
			WayBillPrepareIDList(oWayBillPrint, bAll);

			DataDynamics.ActiveReports.ActiveReport3 rep = new DataDynamics.ActiveReports.ActiveReport3();
			rep = new WayBillShort();

			LogService.WayBill_Print(oWayBillPrint, rep, this);
		}

		#region ExcelRepotr example

		private void PrintWayBillBlank(string _sXlsTemplate)
		{
			//RFMMenuUtilities.MenuClear((ToolStripMenuItem)sender);

			if (grdWayBills.CurrentRow == null)
				return;
			if (!oWayBillCur.ID.HasValue)
				return;

			if (!File.Exists(_sXlsTemplate))
			{
				RFMMessage.MessageBoxError("Не найден шаблон " + _sXlsTemplate + "...");
				return;
			}

			WaitOn(this);

			// перечитать, после этого выполнить проверки 
			if (oWayBillCur.ReFillOne((int)oWayBillCur.ID))
			{
				if (oWayBillCur.IsConfirmed)
				{
					WaitOff(this);
					RFMMessage.MessageBoxError("Путевой лист уже закрыт.\nПечать невозможна.");
					return;
				}

				int nWayBillID = (int)oWayBillCur.ID;
				oWayBillCur.ReFillOne(nWayBillID);
				Car oCarX = new Car();
				oCarX.ReFillOne((int)oWayBillCur.CarID);
				Driver oDriverX = new Driver();
				oDriverX.ReFillOne((int)oWayBillCur.DriverEmployeeID);

				// excel
				string sXlsTemplate = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserLocPath;
				if (!Directory.Exists(sXlsTemplate))
				{
					sXlsTemplate = Path.GetTempPath();
				}
				sXlsTemplate += "_WayBillBlank.xls";
				try
				{
					File.Copy(_sXlsTemplate, sXlsTemplate, true);
				}
				catch (Exception ex)
				{
					WaitOff(this);
					RFMMessage.MessageBoxError("Ошибка при копировании шаблона...\n" + ex.Message);
					return;
				}

				Process[] excelProcess;
				excelProcess = Process.GetProcessesByName("Excel");
				for (int i = 0; i < excelProcess.Length; i++)
					if (String.IsNullOrEmpty(excelProcess[i].MainWindowTitle))
						excelProcess[i].Kill();
				GC.GetTotalMemory(true);
				GC.Collect();

				Excel.Application excel;
				try
				{
					excel = new Excel.ApplicationClass();
				}
				catch
				{
					WaitOff(this);
					RFMMessage.MessageBoxError("Ошибка при создании документа...");
					return;
				}

				excel.ScreenUpdating = false;
				//excel.DisplayAlerts = false;

				Excel.Workbook wb = excel.Workbooks.Open(sXlsTemplate, 0, false, 5, "", "", false, Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
				Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];
				//Excel.Range rg = ws.get_Range(ws.Cells[1, 1], ws.Cells[2, 1]);

				string sCellValue = "";
				for (int row = 1; row < 60; row++)
				{
					for (int col = 1; col < 200; col++)
					{
						if (((Excel.Range)ws.Cells[row, col]).Value2 != null)
						{
							sCellValue = ((Excel.Range)ws.Cells[row, col]).Value2.ToString();
							while (sCellValue.Contains("#"))
							{
								string sField = _GetField(sCellValue);
								if (sField.Length > 0)
								{
									switch (sField)
									{
										case ("ID"):
											sCellValue = _SetField(sCellValue, sField, oWayBillCur.ID.ToString());
											break;
										/*case ("DAY"):
											sCellValue = _SetField(sCellValue, sField, oWayBillCur.DateWayBill.Day.ToString("00"));
											break;
										case ("MONTH"):
											sCellValue = _SetField(sCellValue, sField, oWayBillCur.DateWayBill.Month.ToString("00"));
											// словами!
											break;
										case ("YEAR"):
											sCellValue = _SetField(sCellValue, sField, oWayBillCur.DateWayBill.Year.ToString("0000"));
											break;*/
										case ("CARNAME"):
											sCellValue = _SetField(sCellValue, sField, oCarX.Name);
											break;
										case ("CARNUMBER"):
											sCellValue = _SetField(sCellValue, sField, oCarX.CarNumber);
											break;
										case ("TRAILERNUMBER"):
											sCellValue = _SetField(sCellValue, sField, oCarX.TrailerNumber);
											break;
										case ("DRIVEREMPLOYEENAME"):
											sCellValue = _SetField(sCellValue, sField, oDriverX.Name);
											break;
										case ("DRIVERCATEGORY"):
											sCellValue = _SetField(sCellValue, sField, oDriverX.DriverCategory);
											break;
										case ("DRIVERLICENCENUMBER"):
											sCellValue = _SetField(sCellValue, sField, oDriverX.DriverLicenceNumber);
											break;
										case ("DRIVEROTHER"):
											sCellValue = _SetField(sCellValue, sField, oWayBillCur.DriverOther);
											break;
										case ("USERCREATENAME"):
											sCellValue = _SetField(sCellValue, sField, oWayBillCur.UserCreateName);
											break;
										default:
											sCellValue = "";
											break;
									}
									((Excel.Range)ws.Cells[row, col]).Value2 = sCellValue;
								}
							}
						}
					}
				}
				WaitOff(this);
				excel.Visible = true;
			}
		}

		private string _GetField(string _s)
		{
			string s = "";
			if (_s.Contains("#"))
			{
				s = _s.Substring(_s.IndexOf("#") + 1);
			}
			if (s.Contains("#"))
			{
				s = s.Substring(0, s.IndexOf("#")).ToUpper();
			}
			else
			{
				s = "";
			}
			return (s);
		}

		private string _SetField(string _s, string _field, string _value)
		{
			if (!_s.Contains("#" + _field.ToUpper() + "#"))
			{
				int nAt1 = _s.ToUpper().IndexOf("#" + _field.ToUpper() + "#");
				_s = _s.Substring(0, nAt1) + "#" + _field.ToUpper() + "#" + _s.Substring(nAt1 + _field.Length + 2);
			}
			return (_s.Replace("#" + _field.ToUpper() + "#", _value));
		}

		#endregion ExcelRepotr example
		
		private void ReportFuel()
		{
			DateTime? dDateBeg = null;
			DateTime? dDateEnd = null;
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				dDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				dDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

            // список путевых листов
            if (grdWayBills.CurrentRow == null) return;

            string sWayBillsList = String.Empty;
            DataView dvList = new DataView(oWayBillList.MainTable);
            foreach (DataRowView r in dvList)
            {
                if (!Convert.IsDBNull(r["ID"]))
                    sWayBillsList += r["ID"].ToString() + ",";
            }

			// закрыт?
			bool? bIsConfirmed = null;
			if (optIsConfirmed.Checked)
			{
				bIsConfirmed = true;
			}
			if (optIsConfirmedNot.Checked)
			{
				bIsConfirmed = false;
			}

			Report oReport = new Report();
            oReport.Report_WayBillsFuelData(dDateBeg, dDateEnd, sWayBillsList, bIsConfirmed);
			if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
			{
				if (oReport.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxInfo("Нет данных...");
					return;
				}

				string sTitle = "Отчет по расходу топлива и пробегам: ";
				if (dDateBeg.HasValue)
					sTitle += " c " + ((DateTime)dDateBeg).ToString("dd.MM.yyyy");
				if (dDateEnd.HasValue)
					sTitle += " по " + ((DateTime)dDateEnd).ToString("dd.MM.yyyy");

				repWayBillsFuelData rep = new repWayBillsFuelData(sTitle);
				StartForm(new frmActiveReport(oReport.MainTable, rep));

				/*
				dveReportFuelData.FormCaption = "Отчет по расходу топлива:";
				if (dDateBeg.HasValue)
					dveReportFuelData.FormCaption += " c " + ((DateTime)dDateBeg).ToString("dd.MM.yyyy");
				if (dDateEnd.HasValue)
					dveReportFuelData.FormCaption += " по " + ((DateTime)dDateEnd).ToString("dd.MM.yyyy");

				dveReportFuelData.IsStatusInclude = true;
				dveReportFuelData.IsStatusShow = true;

				dveReportFuelData.RunDataViewer(this, oReport.MainTable);
				*/ 
			}
		}

		#endregion

		#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
			if (tcList.CurrentPage.Name.ToUpper().Contains("WAYBILL"))
			{
				btnService.ShortCutShow();
			}
		}

		private void mniWayBillConfirm_Click(object sender, EventArgs e)
		{
			WayBillConfirm(true);
		}

		private void mniWayBillUnConfirm_Click(object sender, EventArgs e)
		{
			WayBillConfirm(false);
		}

		private bool WayBillConfirm(bool bConfirm)
		{
			if (grdWayBills.CurrentRow == null)
				return (false);

			if (grdWayBills.IsStatusRow(grdWayBills.CurrentRow.Index))
				return (false);

			oWayBillCur.ReFillOne((int)oWayBillCur.ID);

			if (bConfirm)
			{
				// закрыть 
				if (oWayBillCur.IsConfirmed)
				{
					RFMMessage.MessageBoxInfo("Путевой лист уже закрыт.");
					return (false);
				}
				// проверки 
				if (oWayBillCur.DateWayEnd >= DateTime.Now.Date)
				{
					if (RFMMessage.MessageBoxYesNo("Срок действия путевого листа еще не истек.\n" +
							"Все-таки закрыть путевой лист?", false) != DialogResult.Yes)
					{
						return (false);
					}
				}

				if (!oWayBillCur.SpeedometerDataEnd.HasValue || (int)oWayBillCur.SpeedometerDataEnd == 0)
				{
					RFMMessage.MessageBoxError("Не указаны конечные показания спидометра...");
					return (false);
				}

				if (!oWayBillCur.FuelDataEnd.HasValue || (int)oWayBillCur.FuelDataEnd == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не указан конечный остаток топлива...\n\n" +
						"Все-таки закрыть путевой лист с нулевым остатком топлива?") != DialogResult.Yes)
					{
						return (false);
					}
				}

				Car oCarTemp = new Car();
				oCarTemp.ID = (int)oWayBillCur.CarID;
				oCarTemp.FillDataAsync();
				if (oCarTemp.ErrorNumber != 0 || oCarTemp.MainTable.Rows.Count != 1)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о машине в путевом листе...");
					return (false);
				}
				if (oCarTemp.FreezerTank != 0)
				{
					if (!oWayBillCur.FuelFreezerDataEnd.HasValue || oWayBillCur.FuelFreezerDataEnd == 0)
					{
						if (RFMMessage.MessageBoxYesNo("Не указан конечный остаток топлива в баке для холодильной установки...\n\n" +
							"Все-таки закрыть путевой лист с нулевым остатком топлива?") != DialogResult.Yes)
						{
							return (false);
						}
					}
				}
			}
			else //	if (!bConfirm)
			{
				if (!oWayBillCur.IsConfirmed)
				{
					RFMMessage.MessageBoxInfo("Путевой лист не был закрыт.");
					return (false);
				}
				if (oWayBillCur.DateWayEnd < DateTime.Now.Date)
				{
					if (RFMMessage.MessageBoxYesNo("Срок действия путевого листа уже истек.\n" +
							"Все-таки снять отметку о закрытии путевого листа?", false) != DialogResult.Yes)
					{
						return (false);
					}
				}
			}

			oWayBillCur.Confirm(oWayBillCur.ID, bConfirm, ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID);
			if (oWayBillCur.ErrorNumber == 0)
			{
				if (bConfirm)
				{
					//RFMMessage.MessageBoxInfo("Путевой лист закрыт.");
				}
				else
				{
					//RFMMessage.MessageBoxInfo("С путевого листа снята отметка о закрытии.");
				}
			}
			grdWayBills_Restore();
			return (oWayBillCur.ErrorNumber == 0);
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

		#region Drivers

		private void ucSelectRecordID_Drivers_Restore()
		{
			if (ucSelectRecordID_Drivers.sourceData == null)
			{
				Driver oDriver = new Driver();
				if (Utilities.FillData_Drivers(oDriver))
				{
					ucSelectRecordID_Drivers.Restore(oDriver.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Drivers.Restore();
			}
		}

		#endregion Drivers

		#region FillingsTypes

		private void ucSelectRecordID_FillingsTypes_Restore()
		{
			if (ucSelectRecordID_FillingsTypes.sourceData == null)
			{
				Filling oFilling = new Filling();
				if (Utilities.FillData_FillingsTypes(oFilling))
				{
					ucSelectRecordID_FillingsTypes.Restore(oFilling.TableFillingsTypes);
				}
			}
			else
			{
				ucSelectRecordID_FillingsTypes.Restore();
			}
		}

		#endregion FillingsTypes

		#region FuelTypes

		private void ucSelectRecordID_FuelTypes_Restore()
		{
			if (ucSelectRecordID_FuelTypes.sourceData == null)
			{
				Filling oFilling = new Filling();
				if (Utilities.FillData_FuelTypes(oFilling))
				{
					ucSelectRecordID_FuelTypes.Restore(oFilling.TableFuelTypes);
				}
			}
			else
			{
				ucSelectRecordID_FuelTypes.Restore();
			}
		}

		#endregion FuelTypes

		#endregion

		#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(0).Date;
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(7).Date;

			ucSelectRecordID_CarsTypes.ClearData();
			ucSelectRecordID_Cars.ClearData();
			ucSelectRecordID_Drivers.ClearData();

			optIsConfirmedAll.Checked = true;

			ucSelectRecordID_FillingsTypes.ClearData();
			ucSelectRecordID_FuelTypes.ClearData();

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabWayBills.IsNeedRestore =
			tabFillings.IsNeedRestore =
				true;
		}

		#endregion

	}
}