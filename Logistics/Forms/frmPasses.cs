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
	public partial class frmPasses : RFMFormChild
	{
		private Pass oPassList; //список рейсов
		private Pass oPassCur; //текущий рейс

		private Trip oTripList;

		private Pass oPassTemp;
		private Trip oTripTemp;

		// для фильтров
		public string _SelectedIDList;
		public string _SelectedText;


		public frmPasses()
		{
			oPassList = new Pass();
			oPassCur = new Pass();
			if (oPassList.ErrorNumber != 0 ||
				oPassCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oTripList = new Trip();
				if (oTripList.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oPassTemp = new Pass();
				oTripTemp = new Trip();
				if (oPassTemp.ErrorNumber != 0 ||
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

		private void frmPasses_Load(object sender, EventArgs e)
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

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnPrint.Enabled = 
			btnService.Enabled = false;

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
				btnService.Enabled = true;

				grdData.Select();
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

		private bool tabPasses_Trips_Restore()
		{
			return (grdTrips_Restore());
		}

		public void PassPrepareIDList(Pass oPass, bool bMultiSelect)
		{
			oPass.ID = null;
			oPass.IDList = null;
			int? nPassID = 0;
			if (bMultiSelect && grdData.IsCheckerShow)
			{
				oPass.IDList = "";

				DataView dMarked = new DataView(oPassList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdData.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nPassID = (int)r["ID"];
						oPass.IDList = oPass.IDList + nPassID.ToString() + ",";
					}
				}
			}
			else
			{
				nPassID = (int?)grdData.CurrentRow.Cells["grcID"].Value;
				if (nPassID.HasValue)
				{
					oPass.ID = nPassID;
				}
			}
		}

	#region RowEnter, CellFormatting 
	
		private void grdData_CurrentRowChanged(object sender)
		{
			if (grdData.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;
			
			if (grdData.CurrentRow == null)
			   return;
			
			int rowIndex = grdData.CurrentRow.Index;

			btnPrint.Enabled =
			btnService.Enabled = 
				true;

			if (grdData.IsStatusRow(rowIndex))
			{
				oPassCur.ClearOne();
				btnEdit.Enabled =
				btnDelete.Enabled = 
					false;
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow r = ((DataRowView)((DataGridViewRow)grdData.Rows[rowIndex]).DataBoundItem).Row;
				oPassCur.FillOne(r);
				btnEdit.Enabled = (!oPassCur.DateConfirm.HasValue && !oPassCur.DateBeg.HasValue);
				btnDelete.Enabled = (!oPassCur.DateConfirm.HasValue && !oPassCur.DateBeg.HasValue);

				mniPassSetDateEntry.Enabled = !oPassCur.DateBeg.HasValue;
				mniPassClearDateEntry.Enabled = oPassCur.DateBeg.HasValue;
				mniPassSetDateExit.Enabled = !oPassCur.DateEnd.HasValue;
				mniPassClearDateExit.Enabled = oPassCur.DateEnd.HasValue;
			
				mniPassConfirm.Enabled = !oPassCur.IsClosed && !oPassCur.IsConfirmed;
				mniPassUnConfirm.Enabled = !oPassCur.IsClosed && oPassCur.IsConfirmed;
				mniPassPermit.Enabled = !oPassCur.IsClosed && !oPassCur.IsPermitted;
				mniPassUnPermit.Enabled = !oPassCur.IsClosed && oPassCur.IsPermitted;
				mniPassPrint.Enabled = !oPassCur.IsClosed && oPassCur.IsPermitted;
			}
			tcPasses.SetAllNeedRestore(true);
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
			oPassTemp.FillOne(r);
			//
			switch (c.Name)
			{
				case "grcPassStatusImage":
					if (oPassTemp.DateEnd.HasValue)
					{
						e.Value = Properties.Resources.DotRed;
					}
					else
					{
						if (oPassTemp.DateBeg.HasValue)
						{
							e.Value = Properties.Resources.DotYellow;
						}
						else
						{
							if (oPassTemp.IsConfirmed)
								e.Value = Properties.Resources.DotGreen;
							else
								e.Value = Properties.Resources.Empty;
						}
					}
					break;

				case "grcConfirmedImage":
					if (oPassTemp.DateConfirm.HasValue)
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						e.Value = Properties.Resources.Empty;
					}
					break;

				case "grcIsPermittedImage":
					if (oPassTemp.IsPermitted)
					{
						e.Value = Properties.Resources.CheckGreen;
					}
					else
					{
						e.Value = Properties.Resources.Empty;
					}
					break;
			}
		}

		private void grdTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdTrips.DataSource == null)
				return;

			RFMDataGridView grd = grdTrips;

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE")) 
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
				case "grcTrip_TripStatusImage":
					switch ((int)r["TripStatus"])
					{
						case 0:
							e.Value = Properties.Resources.DotGreen;
							break;
						case 1:
							e.Value = Properties.Resources.DotYellow;
							break;
						case 2:
							e.Value = Properties.Resources.DotRed;
							break;
						default:
							e.Value = Properties.Resources.Empty;
							break;
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

	#endregion 

	#region Restore

		private bool grdData_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oPassCur.ClearOne();

			oPassList.ClearError();
			oPassList.ClearFilters();
			oPassList.ID = null;
			oPassList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oPassList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oPassList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// машины, типы, водители
			// контексты
			if (txtCarTypeNameContext.Text.Trim().Length > 0)
			{
				oPassList.FilterCarTypeNameContext = txtCarTypeNameContext.Text.Trim().ToUpper();
			}
			if (txtCarNameContext.Text.Trim().Length > 0)
			{
				oPassList.FilterCarNameContext = txtCarNameContext.Text.Trim().ToUpper();
			}
			if (txtCarNumberContext.Text.Trim().Length > 0)
			{
				oPassList.FilterCarNumberContext = txtCarNumberContext.Text.Trim().ToUpper();
			}
			if (txtDriverNameContext.Text.Trim().Length > 0)
			{
				oPassList.FilterDriverNameContext = txtDriverNameContext.Text.Trim().ToUpper();
			}
			if (txtReasonContext.Text.Trim().Length > 0)
			{
				oPassList.FilterReasonContext = txtReasonContext.Text.Trim().ToUpper();
			}

			// состояние машины 
			if (optPassesStatusNotInNotOut.Checked)
			{
				oPassList.FilterDateBegFull = false;
				oPassList.FilterDateEndFull = false;
			}
			if (optPassesStatusInNotOut.Checked)
			{
				oPassList.FilterDateBegFull = true;
				oPassList.FilterDateEndFull = false;
			}
			if (optPassesStatusInOut.Checked)
			{
				oPassList.FilterDateBegFull = true;
				oPassList.FilterDateEndFull = true;
			}

			// подтверждение
			if (optIsConfirmed.Checked)
			{
				oPassList.FilterIsConfirmed = true;
			}
			if (optIsConfirmedNot.Checked)
			{
				oPassList.FilterIsConfirmed = false;
			}

			// разрешение
			if (optIsPermitted.Checked)
			{
				oPassList.FilterIsPermitted = true;
			}
			if (optIsPermittedNot.Checked)
			{
				oPassList.FilterIsPermitted = false;
			}

			//

			grdTrips.DataSource = null;

			grdData.GetGridState();

			oPassList.FillDataAsync();
			grdData.IsLockRowChanged = true;
			grdData.Restore(oPassList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oPassList.ErrorNumber == 0);
		}

		private bool grdTrips_Restore()
		{
			grdTrips.GetGridState();
			grdTrips.DataSource = null;
			if (grdData.Rows.Count == 0 || 
				!oPassCur.ID.HasValue ||
				(grdData.CurrentRow != null && grdData.IsStatusRow(grdData.CurrentRow.Index)))
				return (true);

			oTripList.FilterPassesList = oPassCur.ID.ToString();
			oTripList.FillDataAsync();
			grdTrips.Restore(oTripList.MainTable);

			return (oTripList.ErrorNumber == 0);
		}

	#endregion 
		
	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (StartForm(new frmPassesEdit(null)) == DialogResult.Yes)
			{
				int nPassID = (int)GotParam.GetValue(0);
				grdData_Restore();
				if (nPassID > 0)
				{
					grdData.GridSource.Position = grdData.GridSource.Find(oPassList.ColumnID, nPassID);
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			if (grdData.CurrentRow == null)
				return;

			if (!oPassCur.ID.HasValue)
				return;

			// перечитать
			oPassCur.ReFillOne((int)oPassCur.ID);

			// проверки
			if (oPassCur.DateConfirm.HasValue)
			{
				RFMMessage.MessageBoxError("Пропуск уже утвержден...");
				return;
			}
			if (oPassCur.DateEnd.HasValue)
			{
				RFMMessage.MessageBoxAttention("Машина уже выехала...");
				//return;
			}
			if (oPassCur.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxAttention("Машина уже въехала...");
				//return;
			}
			Refresh();

			if (StartForm(new frmPassesEdit((int)oPassCur.ID)) == DialogResult.Yes)
			{
				grdData_Restore();
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (grdData.CurrentRow == null)
				return;

			if (!oPassCur.ID.HasValue)
				return;

			// перечитать
			oPassCur.ReFillOne((int)oPassCur.ID);

			// проверки
			if (oPassCur.DateConfirm.HasValue)
			{
				RFMMessage.MessageBoxError("Пропуск уже утвержден...");
				return;
			}
			if (oPassCur.DateEnd.HasValue)
			{
				RFMMessage.MessageBoxError("Машина уже выехала...");
				return;
			}
			if (oPassCur.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("Машина уже въехала...");
				return;
			}
			Refresh();

			if (RFMMessage.MessageBoxYesNo("Удалить пропуск?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oPassCur.DeleteOne((int)oPassCur.ID);
				WaitOff(this);
				if (bResult && oPassCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Пропуск удален.");
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
			btnPrint.ShortCutShow();
		}

		private void mniPassPrint_Click(object sender, EventArgs e)
		{
			PassPrint(false);
		}

		private void PassPrint(bool bAll)
		{
			if (grdData.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			Pass oPassPrint = new Pass();
			PassPrepareIDList(oPassPrint, bAll);

			DataDynamics.ActiveReports.ActiveReport3 rep = new DataDynamics.ActiveReports.ActiveReport3();
			rep = new PassBill();

			LogService.Pass_Print(oPassPrint, rep, this);
		}

	#endregion 

	#region Menu Service

		private void mniPassConfirm_Click(object sender, EventArgs e)
		{
			PassConfirm(true);
		}

		private void mniPassUnConfirm_Click(object sender, EventArgs e)
		{
			PassConfirm(false);
		}

		private void mniPassPermit_Click(object sender, EventArgs e)
		{
			PassPermit(true);
		}

		private void mniPassUnPermit_Click(object sender, EventArgs e)
		{
			PassPermit(false);
		}

		private void mniPassSetDateEntry_Click(object sender, EventArgs e)
		{
			PassSetDateFact(false, false);
		}

		private void mniPassSetDateExit_Click(object sender, EventArgs e)
		{
			PassSetDateFact(false, true);
		}

		private void mniPassClearDateEntry_Click(object sender, EventArgs e)
		{
			PassSetDateFact(true, false);
		}

		private void mniPassClearDateExit_Click(object sender, EventArgs e)
		{
			PassSetDateFact(true, true);
		}

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}

		#region Confirm

		// утверждение пропуска
		private bool PassConfirm(bool bConfirm)
		{
			if (grdData.CurrentRow == null)
				return (false);

			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return (false);

			oPassCur.ReFillOne((int)oPassCur.ID);

			if (bConfirm)
			{
				// закрыть 
				if (oPassCur.DateConfirm.HasValue)
				{
					RFMMessage.MessageBoxError("Пропуск уже утвержден.");
					return (false);
				}
				// проверки 
				if (oPassCur.DatePass.Date.AddDays(1) < DateTime.Now.Date)
				{
					RFMMessage.MessageBoxError("Срок действия пропуска уже истек.");
					return (false);
				}
			}
			else //	if (!bConfirm)
			{
				if (!oPassCur.DateConfirm.HasValue)
				{
					RFMMessage.MessageBoxError("Пропуск не был утвержден.");
					return (false);
				}
				// проверки 
				if (oPassCur.DatePass.Date.AddDays(1) <= DateTime.Now.Date)
				{
					RFMMessage.MessageBoxError("Срок действия пропуска уже истек.");
					return (false);
				}
			}

			oPassCur.Confirm(oPassCur.ID, bConfirm, ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID);
			if (oPassCur.ErrorNumber == 0)
			{
				if (bConfirm)
				{
					//RFMMessage.MessageBoxInfo("Пропуск утвержден.");
				}
				else
				{
					//RFMMessage.MessageBoxInfo("С пропуска снята отметка об утверждении.");
				}
			}
			grdData_Restore();
			return (oPassCur.ErrorNumber == 0);
		}

		#endregion Confirm

		#region Permit

		// разрешение очередного пересечения ворот
		private bool PassPermit(bool bPermit)
		{
			if (grdData.CurrentRow == null)
				return (false);

			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return (false);

			oPassCur.ReFillOne((int)oPassCur.ID);

			if (bPermit)
			{
				if (oPassCur.IsPermitted)
				{
					RFMMessage.MessageBoxInfo("Очередное пересечение ворот разрешено.");
					return (false);
				}
				// проверки 
				if (oPassCur.DatePass.Date.AddDays(1) < DateTime.Now.Date)
				{
					RFMMessage.MessageBoxError("Срок действия пропуска уже истек.");
					return (false);
				}
			}
			else //	if (!bPermit)
			{
				if (!oPassCur.IsPermitted)
				{
					RFMMessage.MessageBoxInfo("Очередное пересечение ворот запрещено.");
					return (false);
				}
				// проверки 
				if (oPassCur.DatePass.Date.AddDays(1) <= DateTime.Now.Date)
				{
					RFMMessage.MessageBoxError("Срок действия пропуска уже истек.");
					return (false);
				}
			}

			oPassCur.Permit(oPassCur.ID, bPermit, ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID);
			if (oPassCur.ErrorNumber == 0)
			{
				//RFMMessage.MessageBoxInfo("Очередное пересечение ворот " + ((bPermit) ? "разрешено" : "запрещено") + ".");
				grdData_Restore();
			}
			return (oPassCur.ErrorNumber == 0);
		}

		#endregion Permit

		private bool PassSetDateFact(bool bClear, bool bIsDeparture)
		{
			if (grdData.CurrentRow == null)
				return (false);

			if (grdData.IsStatusRow(grdData.CurrentRow.Index))
				return (false);

			oPassCur.ReFillOne((int)oPassCur.ID);

			if (bClear)
			{
				// очистить дату-время
				if (bIsDeparture)
				{
					if (!oPassCur.DateEnd.HasValue)
					{
						RFMMessage.MessageBoxInfo("Время выезда машины еще не зафиксировано.");
						return (false);
					}
				}
				else
				{
					if (!oPassCur.DateBeg.HasValue)
					{
						RFMMessage.MessageBoxInfo("Время въезда машины еще не зафиксировано.");
						return (false);
					}
					if (oPassCur.DateEnd.HasValue)
					{
						if (RFMMessage.MessageBoxYesNo("Время выезда машины уже зафиксировано.\n" +
								"Все-таки очистить время въезда?") != DialogResult.Yes)
							return (false);
					}
				}
			}
			else //	if (!bClear)
			{
				// поставить дату-время
				if (bIsDeparture)
				{
					if (oPassCur.DateEnd.HasValue)
					{
						RFMMessage.MessageBoxInfo("Время выезда машины уже зафиксировано.");
						return (false);
					}
					if (!oPassCur.DateBeg.HasValue)
					{
						if (RFMMessage.MessageBoxYesNo("Время въезда машины еще не зафиксировано.\n" + 
								"Все-таки зафиксировать время выезда?") != DialogResult.Yes) 
							return (false);
					}

				}
				else
				{
					if (oPassCur.DateBeg.HasValue)
					{
						RFMMessage.MessageBoxInfo("Время въезда машины уже зафиксировано.");
						return (false);
					}
				}
			}

			oPassCur.SetDateFact(oPassCur.ID, bClear, bIsDeparture, ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID);
			if (oPassCur.ErrorNumber == 0)
			{
				if (bClear)
				{
					if (bIsDeparture)
					{
						//RFMMessage.MessageBoxInfo("Время выезда очищено.");
					}
					else
					{
						//RFMMessage.MessageBoxInfo("Время въезда очищено.");
					}
				}
				else
				{
					if (bIsDeparture)
					{
						//RFMMessage.MessageBoxInfo("Время выезда зафиксировано.");
					}
					else
					{
						//RFMMessage.MessageBoxInfo("Время въезда зафиксировано.");
					}
				}
			}
			grdData_Restore();
			return (oPassCur.ErrorNumber == 0);
		}

	#endregion Service

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.Date;
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(7).Date;

			txtCarNameContext.Text = 
			txtCarNumberContext.Text = 
			txtCarTypeNameContext.Text = 
			txtDriverNameContext.Text = 
			txtReasonContext.Text = 
				"";

			optPassesStatusAll.Checked = true;
			optIsConfirmedAll.Checked = true;
			optIsPermittedAll.Checked = true; 

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