using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics 
{
	public partial class frmTripsTimesReorder : RFMFormChild
	{
		private Trip oTrip = new Trip();
		bool bSelfDelivery = false;
		DataTable dt;  

		public frmTripsTimesReorder(bool _bSelfDelivery) : base()
		{
			bSelfDelivery = _bSelfDelivery;
			InitializeComponent();
		}

		private void frmTripsTimesReorder_Load(object sender, EventArgs e)
		{
			nudDelta.Value = 1;

			foreach (DataGridViewColumn c in grdTrips.Columns)
				c.ReadOnly = !(c.DataPropertyName.ToUpper() == "BYORDER" || c.DataPropertyName.ToUpper().Contains("TIME"));

			DateTime dtDate = DateTime.Now;
			if (dtDate.Hour >= 18)
				dtDate = dtDate.AddDays(1);
			dtpDateTrip.Value = dtDate;
			btnGo_Click(null, null);

			SetButtonStatus();
		}
		
		private bool grdTrips_Restore()
		{
			RFMCursorWait.Set(true);

			oTrip.ClearFilters();
			oTrip.IDList = null;
			oTrip.FilterDateBeg =
			oTrip.FilterDateEnd =
				dtpDateTrip.Value;
			oTrip.FilterSelfDelivery = bSelfDelivery;
			oTrip.FillData();

			string sDate;
			dt = CopyTable(oTrip.MainTable, "dt", "", "ByOrder, Alias");
			dt.Columns.Add("PreByOrder", Type.GetType("System.Int32"));
			dt.Columns.Add("TimeBeg", Type.GetType("System.String"));
			dt.Columns.Add("IsPickOn", Type.GetType("System.Boolean"));

			foreach (DataRow r in dt.Rows)
			{
				r["PreByOrder"] = r["ByOrder"];

				if (r["DateBegPlan"] == DBNull.Value)
					sDate = "ddMMyyyy00:00";
				else
					sDate = (Convert.ToDateTime(r["DateBegPlan"])).ToString("ddMMyyyyHH:mm");
				if (sDate.Length > 0)
					r["TimeBeg"] = sDate.Substring(8, 5);

				r["IsPickOn"] = false;
			}

			grdTrips.Restore(dt);
			grdTrips.GridSource.Sort = "ByOrder, Alias";

			SetButtonStatus();

			RFMCursorWait.Set(false);

			return (true);
		}

		#region Cells

		private void grdTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdTrips.DataSource == null)
				return;

			if (e.RowIndex > grdTrips.Rows.Count) // возможно в период действия фильтра
				return;

			string sColumnName = grdTrips.Columns[e.ColumnIndex].Name.ToUpper();

			if (grdTrips.IsStatusRow(e.RowIndex))
			{
				e.CellStyle.BackColor = Color.Silver;
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);

				if (sColumnName.Contains("IMAGE"))
					e.Value = Properties.Resources.Empty;
				return;
			}

			DataRow r = ((DataRowView)((DataGridViewRow)grdTrips.Rows[e.RowIndex]).DataBoundItem).Row;

			if (sColumnName.Contains("ReadyForTripBegImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["ReadyForTripBeg"]))
				{
					if ((bool)r["ReadyForTripBeg"])
					{
						e.Value = Properties.Resources.DotGreen;
					}
					else
					{
						e.Value = Properties.Resources.DotRed;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("ReadyForTripEndImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["ReadyForTripEnd"]))
				{
					if ((bool)r["ReadyForTripEnd"])
					{
						e.Value = Properties.Resources.DotGreen;
					}
					else
					{
						e.Value = Properties.Resources.DotRed;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("TripReadyImage".ToUpper()))
			{
				if (Convert.IsDBNull(r["ReadyForTripBeg"]))
				{
					e.Value = Properties.Resources.Empty;
				}
				else
				{
					if ((bool)r["ReadyForTripBeg"])
					{
						e.Value = Properties.Resources.Plain_G;
					}
					else
					{
						if ((bool)r["ReadyForPrint"])
						{
							e.Value = Properties.Resources.Plain_B;
						}
						else
						{
							if ((bool)r["ReadyForWMS"])
							{
								e.Value = Properties.Resources.Plain_Y;
							}
							else
							{
								e.Value = Properties.Resources.Plain_R;
							}
						}
					}
				}
			}

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
			}

			if (sColumnName.Contains("IsPrintedImage".ToUpper()))
			{
				if ((bool)r["IsPrinted"])
				{
					e.Value = Properties.Resources.Print;
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}
		}

		private void grdTrips_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (grdTrips.IsCurrentCellDirty)
				grdTrips.Invalidate();
		}

		private void grdTrips_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (grdTrips.IsRestoring)
				return;

			DataRowView drvO = (DataRowView)grdTrips.CurrentRow.DataBoundItem;
			string sDate = drvO["DateTrip"].ToString().Trim();
			if (grdTrips.Columns[e.ColumnIndex].Name.ToUpper().Contains("TIME"))
			{
				if (drvO["TimeBeg"].ToString().Trim().Length > 1)
				{
					drvO["DateBegPlan"] = Convert.ToDateTime(sDate.Substring(0, 10) + " " + drvO["TimeBeg"].ToString().Trim());
				}
				else
				{
					drvO["DateBegPlan"] = Convert.ToDateTime(sDate.Substring(0, 10) + " 00:00");
				}
			}
		}

		private void grdTrips_CurrentRowChanged(object sender)
		{
			if (grdTrips.IsLockRowChanged)
				return;
			if (grdTrips.CurrentRow == null)
				return;

			SetButtonStatus();
		}

		#endregion Cells

		#region Change ByOrder

		private void btnMin_Click(object sender, EventArgs e)
		{
			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"],
				currIndex = grdTrips.CurrentRow.Index;
			int nextIndex = 0;

			int curIndex = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ByOrder"];
			if (curIndex > currIndex)
				currIndex = curIndex; 

			int stepsQnt = currIndex - nextIndex;
			if (stepsQnt > 0)
			{
				nudDelta.Value = stepsQnt;
				RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

				MoveGroup(true);

				grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByORder"];
				grdTrips.FirstDisplayedScrollingRowIndex = grdTrips.CurrentRow.Index;

				SetButtonStatus(); 

				RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			}
		}

		private void btnMax_Click(object sender, EventArgs e)
		{
			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"],
				dispCount = grdTrips.DisplayedRowCount(false),
				currIndex = grdTrips.CurrentRow.Index;

			int nextIndex = grdTrips.Rows.Count;
			int maxIndex = (int)((DataTable)grdTrips.GridSource.DataSource).Compute("Max(ByOrder)", String.Empty) + 1;
			if (maxIndex > nextIndex)
				nextIndex = maxIndex; 

			int stepsQnt = nextIndex - currIndex;
			if (stepsQnt > 0)
			{
				nudDelta.Value = stepsQnt;
				RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

				MoveGroup(false);

				grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByOrder"];
				int nIndex = grdTrips.CurrentRow.Index - dispCount + 1;
				if (nIndex >= 0)
					grdTrips.FirstDisplayedScrollingRowIndex = nIndex;

				SetButtonStatus(); 

				RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			}
		}

		private void btnPlus_Click(object sender, EventArgs e)
		{
			RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"],
				dispCount = grdTrips.DisplayedRowCount(false),
				firstIndex = grdTrips.FirstDisplayedScrollingRowIndex;
				nudDelta.Value = 1;

			MoveGroup(false);

			grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByOrder"];
			if (grdTrips.CurrentRow.Index > firstIndex + dispCount - 1)
				grdTrips.FirstDisplayedScrollingRowIndex = grdTrips.CurrentRow.Index - dispCount + 1;
			else
				grdTrips.FirstDisplayedScrollingRowIndex = firstIndex;

			SetButtonStatus(); 

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
		}

		private void btnMinus_Click(object sender, EventArgs e)
		{
			RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"],
				firstIndex = grdTrips.FirstDisplayedScrollingRowIndex;
				nudDelta.Value = 1;

			MoveGroup(true);

			grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByOrder"];
			if (grdTrips.CurrentRow.Index < firstIndex)
				grdTrips.FirstDisplayedScrollingRowIndex = grdTrips.CurrentRow.Index;
			else
				grdTrips.FirstDisplayedScrollingRowIndex = firstIndex;

			SetButtonStatus(); 

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
		}

		private void btnPgUp_Click(object sender, EventArgs e)
		{
			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"],
				dispCount = grdTrips.DisplayedRowCount(false),
				currIndex = grdTrips.CurrentRow.Index;
			int nextIndex;
			if (currIndex == grdTrips.FirstDisplayedScrollingRowIndex)
				nextIndex = currIndex - dispCount + 1;
			else
				nextIndex = grdTrips.FirstDisplayedScrollingRowIndex;

			int minIndex = (int)grdTrips.Rows[grdTrips.FirstDisplayedScrollingRowIndex].Cells["grcByOrder"].Value;
			if (minIndex < nextIndex)
				nextIndex = minIndex;

			if (nextIndex < 1)
				nextIndex = 0;
			int stepsQnt = currIndex - nextIndex;
			if (stepsQnt > 0)
			{
				nudDelta.Value = stepsQnt;
				RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

				MoveGroup(true);

				grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByOrder"];
				grdTrips.FirstDisplayedScrollingRowIndex = grdTrips.CurrentRow.Index;

				SetButtonStatus(); 

				RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			}
		}

		private void btnPgDown_Click(object sender, EventArgs e)
		{
			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"],
				dispCount = grdTrips.DisplayedRowCount(false),
				currIndex = grdTrips.CurrentRow.Index;
			
			int nextIndex;
			if (currIndex == grdTrips.FirstDisplayedScrollingRowIndex + dispCount - 1)
				nextIndex = currIndex + dispCount;
			else
				nextIndex = grdTrips.FirstDisplayedScrollingRowIndex + dispCount - 1;
			if (nextIndex > grdTrips.Rows.Count)
				nextIndex = grdTrips.Rows.Count;

			int maxIndex = (int)grdTrips.Rows[grdTrips.FirstDisplayedScrollingRowIndex + dispCount - 1].Cells["grcByOrder"].Value;
			if (maxIndex > nextIndex)
				nextIndex = maxIndex;

			int stepsQnt = nextIndex - currIndex;
			if (stepsQnt > 0)
			{
				nudDelta.Value = stepsQnt;
				RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

				MoveGroup(false);

				grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByOrder"];
				int nIndex = grdTrips.CurrentRow.Index - dispCount + 1;
				if (nIndex >= 0)
					grdTrips.FirstDisplayedScrollingRowIndex = nIndex;

				SetButtonStatus(); 

				RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			}
		}

		private void MoveGroup(bool IsMoveUp)
		{
			RFMBindingSource bs = grdTrips.GridSource;
			int oldIndex = (int)grdTrips.CurrentRow.Cells["grcByOrder"].Value;

			DataRowView drv;
			int newIndex;
			if (IsMoveUp)
			{
				newIndex = oldIndex - (int)nudDelta.Value;
				int minIndex = (int)((DataTable)bs.DataSource).Compute("Min(ByOrder)", String.Empty);
				if (newIndex < minIndex)
					newIndex = minIndex;
			}
			else
			{
				newIndex = oldIndex + (int)nudDelta.Value;
				int maxIndex = (int)((DataTable)bs.DataSource).Compute("Max(ByOrder)", String.Empty);
				if (newIndex > maxIndex)
					newIndex = maxIndex;
			}

			bs.Filter = "ByOrder = " + oldIndex.ToString();
			bs.MoveFirst();
			for (int i = 0; i < bs.Count; i++)
			{
				((DataRowView)bs.Current)["IsPickOn"] = true;
				bs.MoveNext();
			}

			if (IsMoveUp)
				bs.Filter = "ByOrder >= " + newIndex.ToString() + " AND ByOrder <= " + oldIndex.ToString();
			else
				bs.Filter = "ByOrder <= " + newIndex.ToString() + " AND ByOrder >= " + oldIndex.ToString();

			bs.Sort = "ID";
			bs.MoveFirst();
			for (int i = 0; i < bs.Count; i++)
			{
				drv = (DataRowView)bs.Current;
				if ((bool)drv["IsPickOn"])
				{
					drv["ByOrder"] = newIndex;
					drv["IsPickOn"] = false;
				}
				else
					drv["ByOrder"] = (int)drv["ByOrder"] + (IsMoveUp ? 1 : -1);
				bs.MoveNext();
			}
			bs.Sort = "ByOrder, Alias";
			bs.RemoveFilter();

			grdTrips.CommitChanges();
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			if (grdTrips.Rows.Count == 0)
				return;

			ReOrderAll();
			
			SetButtonStatus(); 
		}

		private void ReOrderAll()
		{
			RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

			int currId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"];

			RFMBindingSource bs = grdTrips.GridSource;
			int curId = (int)((DataRowView)grdTrips.CurrentRow.DataBoundItem)["ID"];
			UpdateGroupIndex(ref bs, "", 1);
			grdTrips.CurrentCell = grdTrips.Rows[bs.Find("ID", curId)].Cells["grcByOrder"];
			grdTrips.Refresh();

			grdTrips.CurrentCell = grdTrips.Rows[grdTrips.GridSource.Find("ID", currId)].Cells["grcByOrder"];

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
		}

		private void UpdateGroupIndex(ref RFMBindingSource bs, string strFilter, int startIndex)
		{
			startIndex--;
			bs.Filter = strFilter;

			if (bs.Sort.Contains("ByOrder"))
			{
				DataTable dt = (DataTable)bs.DataSource;
				if (!dt.Columns.Contains("ByOrderSort"))
					dt.Columns.Add("ByOrderSort", Type.GetType("System.Int32"));

				bs.MoveFirst();
				for (int i = 0; i < bs.Count; i++)
				{
					((DataRowView)bs.Current)["ByOrderSort"] = i;
					bs.MoveNext();
				}
				bs.Sort = "ByOrderSort";
			}

			bs.MoveFirst();
			if (bs.Count > 0)
			{
				for (int i = 0; i < bs.Count; i++)
				{
					startIndex++;
					((DataRowView)bs.Current)["ByOrder"] = startIndex;
					bs.MoveNext();
				}
			}

			bs.Sort = "ByOrder, ID";

			grdTrips.CommitChanges();
		}

		private void btnByTime_Click(object sender, EventArgs e)
		{
			// расставить по времени выезда
			if (RFMMessage.MessageBoxYesNo("Изменить порядок выхода машин в соответствии с указанным планируемым временем выхода?") != DialogResult.Yes)
				return;

			RFMCursorWait.LockWindowUpdate(grdTrips.Handle);

			RFMBindingSource bs = grdTrips.GridSource;
			bs.Sort = "TimeBeg, Alias";

			int nByOrder = 0;
			string sTime = "00:00";
			DataRowView drv;

			bs.MoveFirst();
			for (int i = 0; i < bs.Count; i++)
			{
				drv = (DataRowView)bs.Current;
				/*if (drv["TimeBeg"].ToString().Trim().Length <= 1 || drv["TimeBeg"].ToString() == "00:00")
					nByOrder = 0;
				else
				{
					//if (sTime != drv["TimeBeg"].ToString().Trim())
					nByOrder++;
				}*/
				nByOrder++;
				drv["ByOrder"] = nByOrder;

				sTime = drv["TimeBeg"].ToString().Trim();
				bs.MoveNext();
			}

			grdTrips.Invalidate();

			bs.Sort = "ByOrder";

			SetButtonStatus();

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
		}

		#endregion Change ByOrder

		private void btnSave_Click(object sender, EventArgs e)
		{
			int nTripID = 0;
			int nByOrder = 0;
			DateTime? dtDate = null;
			int nUserID = ((RFMFormMain)Application.OpenForms[0]).UserID;

			RFMBindingSource bs = grdTrips.GridSource;
			DataRowView drv;
			bs.MoveFirst();
			for (int i = 0; i < bs.Count; i++)
			{
				drv = (DataRowView)bs.Current;

				nTripID = (int)drv["ID"];
				dtDate = null;

				oTrip.ClearError();
				// можно проверить, что рейс не начат, машина не выехала, машина не приехала, рейс не подтвержден и т.д.
				// ...

				// время выхода
				if (!Convert.IsDBNull(drv["DateBegPlan"]))
				{
					dtDate = Convert.ToDateTime(drv["DateBegPlan"]);
					/*if (((DateTime)dtDate).Hour == 0 && ((DateTime)dtDate).Minute == 0)
						dtDate = null;*/
				}
				oTrip.SetDateTime(nTripID, "BEG", "PLAN", null, nUserID);
				oTrip.SetDateTime(nTripID, "BEG", "PLAN", dtDate, nUserID);

				// ByOrder
				nByOrder = (int)drv["ByOrder"]; 
				/*if (!dtDate.HasValue) 
					nByOrder = 0;*/
				if ((int)drv["PreByOrder"] != nByOrder)
					oTrip.SaveByOrder(nTripID, (int)drv["ByOrder"]);

				bs.MoveNext();
			}
			if (oTrip.ErrorNumber == 0)
			{
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			grdTrips_Restore();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SetButtonStatus(bool isEnabled)
		{
			btnMinus.Enabled =
			btnPlus.Enabled =
			btnPgUp.Enabled =
			btnPgDown.Enabled =
			btnMin.Enabled =
			btnMax.Enabled =
			btnSave.Enabled =
			btnSort.Enabled = 
			btnByTime.Enabled =  
				isEnabled;
		}

		private void SetButtonStatus()
		{
			if (grdTrips.Rows.Count == 0)
			{
				SetButtonStatus(false); 
				return;
			}
			if (grdTrips.CurrentRow == null)
				return;

			SetButtonStatus(true); 
			int rowIndex = grdTrips.CurrentRow.Index;
			if (rowIndex == 0)
			{ 
				// верхняя запись
				btnMinus.Enabled =
				btnPgUp.Enabled =
				btnMin.Enabled =
					false;
			}
			if (rowIndex == grdTrips.GridSource.Count - 1)
			{
				// нижняя запись
				btnPlus.Enabled =
				btnPgDown.Enabled =
				btnMax.Enabled =
					false;
			}
		}

		private void frmTripsTimesReorder_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F5:
					btnGo_Click(null, null);
					break;
				case Keys.F1:
					btnHelp_Click(null, null);
					break;
				case Keys.W:
				case Keys.S:
					if (e.Modifiers == Keys.Control)
					{
						btnSave_Click(null, null);
					}
					break;
				case Keys.Escape:
					btnExit_Click(null, null);
					break;
			}
		}

	}
}