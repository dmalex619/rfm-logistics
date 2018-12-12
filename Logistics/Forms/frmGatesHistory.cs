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
	public partial class frmGatesHistory : RFMFormChild
	{
		private GateHistory oGateHistoryList; //список рейсов
		private GateHistory oGateHistoryCur; //текущий рейс

		public frmGatesHistory()
		{
			oGateHistoryList = new GateHistory();
			oGateHistoryCur = new GateHistory();
			if (oGateHistoryList.ErrorNumber != 0 ||
				oGateHistoryCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmGatesHistory_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			// назначение суммировани€ на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			btnClearTerms_Click(null, null);

			tcList.Init();

			dtrDates.dtpBegDate.Select();

			RFMCursorWait.Set(false);
		}

		#region TabRestore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnPrint.Enabled = 
			btnService.Enabled = 
				false;

			dtrDates.dtpBegDate.Select();
			
			return (true);
		}

		private bool tabData_Restore()
		{
			grdData_Restore();
			btnAdd.Enabled = true;
			if (grdData.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled = 
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				grdData.Select();
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
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("DATA"))
			{
				btnAdd.Enabled = true;
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				grdData.Select();
				if (grdData.Rows.Count > 0 && grdData.CurrentRow != null)
				{
					if (!tabData.IsNeedRestore)
					{
						if (!grdData.IsStatusRow(grdData.CurrentRow.Index))
						{
							DataRow r = ((DataRowView)grdData.CurrentRow.DataBoundItem).Row;
							oGateHistoryCur.ID = Convert.ToInt32(r["ID"]);
						}
					}
				}
			}
		}

		#endregion TabRestore

		public void GateHistoryPrepareIDList(GateHistory oGateHistory, bool bMultiSelect)
		{
			oGateHistory.ID = null;
			oGateHistory.IDList = null;
			int? nGateHistoryID = 0;
			if (bMultiSelect && grdData.IsCheckerShow)
			{
				oGateHistory.IDList = "";

				DataView dMarked = new DataView(oGateHistoryList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdData.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nGateHistoryID = (int)r["ID"];
						oGateHistory.IDList = oGateHistory.IDList + nGateHistoryID.ToString() + ",";
					}
				}
			}
			else
			{
				nGateHistoryID = (int?)grdData.CurrentRow.Cells["grcID"].Value;
				if (nGateHistoryID.HasValue)
				{
					oGateHistory.ID = nGateHistoryID;
				}
			}
		}

	#region RowEnter, CellFormatting 

		private void grdData_CurrentRowChanged(object sender)
		{
			if (grdData.IsLockRowChanged)
				return;
			
			if (grdData.CurrentRow == null)
				return;

			int rowIndex = grdData.CurrentRow.Index;

			btnPrint.Enabled =
			btnService.Enabled =
				true;

			if (grdData.IsStatusRow(rowIndex))
			{
				oGateHistoryCur.ClearOne();
				btnEdit.Enabled =
				btnDelete.Enabled = 
					false;
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow r = ((DataRowView)((DataGridViewRow)grdData.Rows[rowIndex]).DataBoundItem).Row;
				oGateHistoryCur.FillOne(r);
				btnEdit.Enabled = 
				btnDelete.Enabled =
					true;
			}
		}

		private void grdData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdData.DataSource == null)
				return;

			// статусна€ строка
			if (grdData.IsStatusRow(e.RowIndex))
			{
				if (grdData.Columns[e.ColumnIndex].Name.Contains("Image"))
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
				case "grcGatesHistoryImage":
					if (!Convert.IsDBNull(r["DateDepartureFact"]) && !Convert.IsDBNull(r["DateArrivalFact"]))
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						if (Convert.IsDBNull(r["DateDepartureFact"]) || Convert.IsDBNull(r["DateArrivalFact"]))
						{
							e.Value = Properties.Resources.CheckRed;
						}
						else
						{
							e.Value = Properties.Resources.Empty;
						}
					}
					break;
			}
		}

	#endregion 

	#region Restore

		private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oGateHistoryCur.ClearOne();

			oGateHistoryList.ClearError();
			oGateHistoryList.ClearFilters();
			oGateHistoryList.ID = null;
			oGateHistoryList.IDList = null;

			// собираем услови€

			// даты и врем€ 
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oGateHistoryList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oGateHistoryList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}
			if (!tmrTimes.txtBegTime.IsEmpty)
			{
				oGateHistoryList.FilterTimeBeg = tmrTimes.txtBegTime.Text.Trim();
			}
			if (!tmrTimes.txtEndTime.IsEmpty)
			{
				oGateHistoryList.FilterTimeEnd = tmrTimes.txtEndTime.Text.Trim();
			}

			// направление
			if (optDirectionArrival.Checked)
			{
				oGateHistoryList.FilterIsDeparture = false;
			}
			if (optDirectionDeparture.Checked)
			{
				oGateHistoryList.FilterIsDeparture = true;
			}

			// машины, типы, водители
			if (optIsOtherCar.Checked)
			{
				oGateHistoryList.FilterIsOtherCar = true;
			}
			if (optIsOtherCarNot.Checked)
			{
				oGateHistoryList.FilterIsOtherCar = false;
			}

			oGateHistoryList.FilterCarsTypesList = ucSelectRecordID_CarsTypes.GetIdString();
			if (txtCarTypeNameContext.Text.Trim().Length > 0)
			{
				oGateHistoryList.FilterCarTypeNameContext = txtCarTypeNameContext.Text.Trim().ToUpper();
			}

			oGateHistoryList.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
			if (txtCarNameContext.Text.Trim().Length > 0)
			{
				oGateHistoryList.FilterCarNameContext = txtCarNameContext.Text.Trim().ToUpper();
			}
			if (txtCarNumberContext.Text.Trim().Length > 0)
			{
				oGateHistoryList.FilterCarNumberContext = txtCarNumberContext.Text.Trim().ToUpper();
			}

			oGateHistoryList.FilterDriversEmployeesList = ucSelectRecordID_Drivers.GetIdString();
			if (txtDriverNameContext.Text.Trim().Length > 0)
			{
				oGateHistoryList.FilterDriverNameContext = txtDriverNameContext.Text.Trim().ToUpper();
			}

			// состо€ние машин наших 
			if (optCarsStatusDeparture.Checked)
			{
				oGateHistoryList.FilterDateDepartureFactFull = true;
				oGateHistoryList.FilterDateArrivalFactFull = false;
			}
			if (optCarsStatusDepartureArrival.Checked)
			{
				oGateHistoryList.FilterDateDepartureFactFull = true;
				oGateHistoryList.FilterDateArrivalFactFull = true;
			}
			// состо€ние машин прочих 
			if (optCarsOthersStatusArrival.Checked)
			{
				oGateHistoryList.FilterDateArrivalFactFull = true;
				oGateHistoryList.FilterDateDepartureFactFull = false;
			}
			if (optCarsOthersStatusArrivalDeparture.Checked)
			{
				oGateHistoryList.FilterDateArrivalFactFull = true;
				oGateHistoryList.FilterDateDepartureFactFull = true;
			}
			
			//

			grdData.GetGridState();
			oGateHistoryList.FillData();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oGateHistoryList.MainTable);

			grdData_CurrentRowChanged(null);

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oGateHistoryList.ErrorNumber == 0);
		}

	#endregion 
		
	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (StartForm(new frmGatesHistoryEdit(null)) == DialogResult.Yes)
			{
				int nGateHistoryID = (int)GotParam.GetValue(0);
				grdData_Restore();
				if (nGateHistoryID > 0)
				{
					grdData.GridSource.Position = grdData.GridSource.Find(oGateHistoryList.ColumnID, nGateHistoryID);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0 || grdData.CurrentRow == null || 
				!oGateHistoryCur.ID.HasValue)
				return;

			// перечитать
			oGateHistoryCur.ReFillOne((int)oGateHistoryCur.ID);

			// проверки
			// ...
			//

			if (StartForm(new frmGatesHistoryEdit((int)oGateHistoryCur.ID)) == DialogResult.Yes)
			{
				grdData_Restore();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0 || grdData.CurrentRow == null ||
				!oGateHistoryCur.ID.HasValue)
				return;

			// перечитать
			int nGateHistoryID = (int)oGateHistoryCur.ID;
			oGateHistoryCur.ReFillOne(nGateHistoryID);
			
			// проверки:
			GateHistory oGateHistoryTemp = new GateHistory();
			// дл€ нашей машины: нельз€ удалить выезд, если уже есть въезд
			if (oGateHistoryCur.WayBillID.HasValue && oGateHistoryCur.IsDeparture)
			{
				oGateHistoryTemp.FilterWayBillsList = oGateHistoryCur.WayBillID.ToString();
				oGateHistoryTemp.FillData();
				if (oGateHistoryTemp.ErrorNumber == 0 && oGateHistoryTemp.MainTable != null &&
					oGateHistoryTemp.MainTable.Rows.Count > 1)
				{
					foreach (DataRow gh in oGateHistoryTemp.MainTable.Rows)
					{ 
						if ((int)gh["ID"] != nGateHistoryID) 
						{
							if (!Convert.ToBoolean(gh["IsDeparture"]) && Convert.ToInt32(gh["ID"]) > nGateHistoryID) // вЏезд
							{
								RFMMessage.MessageBoxError("ƒл€ данного факта выезда машины \"" + gh["CarNumber"].ToString() + "\" зарегистрирован факт въезда (по тому же путевому листу)...\n" +
									"”даление невозможно.");
								return;
							}
						}
					}
				}
			}
			// дл€ ненашей машины: нельз€ удалить въезд, если уже есть выезд
			if (oGateHistoryCur.PassID.HasValue && !oGateHistoryCur.IsDeparture)
			{
				oGateHistoryTemp.FilterPassesList = oGateHistoryCur.PassID.ToString();
				oGateHistoryTemp.FillData();
				if (oGateHistoryTemp.ErrorNumber == 0 && oGateHistoryTemp.MainTable != null &&
					oGateHistoryTemp.MainTable.Rows.Count > 1)
				{
					foreach (DataRow gh in oGateHistoryTemp.MainTable.Rows)
					{
						if ((int)gh["ID"] != nGateHistoryID)
						{
							if (Convert.ToBoolean(gh["IsDeparture"]) && Convert.ToInt32(gh["ID"]) > nGateHistoryID) // вџезд
							{
								RFMMessage.MessageBoxError("ƒл€ данного факта въезда машины \"" + gh["CarNumber"].ToString() + "\" зарегистрирован факт выезда (по тому же пропуску)...\n" +
									"”даление невозможно.");
								return;
							}
						}
					}
				}
			}

			if (RFMMessage.MessageBoxYesNo("”далить запись о пересечении ворот машиной " + oGateHistoryCur.CarNumber +  " " + oGateHistoryCur.DateCross.ToString("dd.MM.yyyy HH.mm") + "?") == DialogResult.Yes)
			{
				if (oGateHistoryCur.Delete(nGateHistoryID))
				{
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

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date;
			dtrDates.dtpEndDate.Value = DateTime.Now.Date;

			tmrTimes.txtBegTime.Clear();
			tmrTimes.txtEndTime.Clear();
			tmrTimes.txtBegTime.HideControl(false);
			tmrTimes.txtEndTime.HideControl(false);

			optDirectionAll.Checked = true;
			ucSelectRecordID_CarsTypes.ClearData();
			ucSelectRecordID_Cars.ClearData();
			ucSelectRecordID_Drivers.ClearData(); 
 
			txtCarNameContext.Text = "";
			txtCarNumberContext.Text = "";
			txtDriverNameContext.Text = "";

			optCarsStatusAll.Checked = true;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabData.IsNeedRestore = true;
		}

	#endregion

	}
}