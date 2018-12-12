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
	public partial class frmGatesHistoryEdit : RFMFormChild
	{
		private int? nGateHistoryID = null;
		private GateHistory oGateHistory;
		
		private int? nTransportPermissionID = null; 
		private int? nWayBillID = null;
		private int? nPassID = null;

		private bool bLoaded = false;


		public frmGatesHistoryEdit(int? _nGateHistoryID)
		{
			if (_nGateHistoryID.HasValue)
			{
				nGateHistoryID = (int)_nGateHistoryID;
			}

			oGateHistory = new GateHistory();
			if (oGateHistory.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmGatesHistoryEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true;

			if (nGateHistoryID.HasValue)
			{
				// редактирование
				bResult = oGateHistory.ReFillOne((int)nGateHistoryID);

				if (bResult)
				{
					dtpDateCross.Value = oGateHistory.DateCross;
					optDeparture.Checked = oGateHistory.IsDeparture;

					if (oGateHistory.TransportPermissionID.HasValue && oGateHistory.TransportPermissionID > 0)
					{
						// по нашему путевому листу либо по пропуску
						nTransportPermissionID = (int)oGateHistory.TransportPermissionID;
					}
					nWayBillID = oGateHistory.WayBillID;
					nPassID = oGateHistory.PassID;

					grdData_Restore();
				}
				else
				{
					chkFact.Checked = true;

					txtCarNаme.Text = oGateHistory.CarName;
					txtCarTypeName.Text = oGateHistory.CarTypeName;
					txtCarNumber.Text = oGateHistory.CarNumber;
					txtTrailerNumber.Text = oGateHistory.TrailerNumber;
					txtDriverName.Text = oGateHistory.DriverName;
				}

				txtReason.Text = oGateHistory.OtherReason;
				if (oGateHistory.CarWeight.HasValue)
					numCarWeight.Value = (int)oGateHistory.CarWeight;
				txtNote.Text = oGateHistory.Note;

				// запретить редактировать все, кроме примечания
				pnlIsDeparture.Enabled =
				pnlCars.Enabled =
				pnlOther.Enabled =
					false;
			}
			else
			{
				// новый факт пересечения ворот
				dtpDateCross.Value = DateTime.Now;
				optDeparture.Checked = true;

				grdData_Restore(); 
			}

			if (!bResult)
			{
				Dispose();
				return;
			}

			tcCars.Init();
			chkFact_CheckedChanged(null, null);

			bLoaded = true;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		#region Restore

		private void grdData_Restore()
		{
			bool? bArrival = null;
			if (!chkArrivalDeparture.Checked)
				bArrival = optArrival.Checked;

			bool? bFinishedAlso = null;
			if (chkRepeat.Checked)
				bFinishedAlso = true;

			if (nGateHistoryID.HasValue)
			{
				oGateHistory.FillSourceData(nGateHistoryID, null, null, null, null);
			}
			else
			{
				oGateHistory.FillSourceData(null, null, dtpDateCross.Value.Date, bArrival, bFinishedAlso);
			}

			if (oGateHistory.ErrorNumber == 0)
			{
				grdData.Restore(oGateHistory.TableSourceData);
			}

			txtCarNameContext.Select();

			return;
		}

		#endregion Restore

		private void btnSave_Click(object sender, EventArgs e)
		{
			oGateHistory.TransportPermissionID = null;
			oGateHistory.WayBillID = null;
			oGateHistory.PassID = null;

			if (chkFact.Checked)
			{
				// по факту
				if (txtCarNаme.Text.Trim().Length == 0 && txtCarNumber.Text.Trim().Length == 0)
				{
					RFMMessage.MessageBoxError("Укажите машину!");
					txtCarNаme.Select();
					return;
				}
				if (txtReason.Text.Trim().Length == 0)
				{
					RFMMessage.MessageBoxError("Укажите назначение!");
					txtReason.Select();
					return;
				}

				oGateHistory.CarName = txtCarNаme.Text.Trim();
				oGateHistory.CarTypeName = txtCarTypeName.Text.Trim();
				oGateHistory.CarNumber = txtCarNumber.Text.Trim();
				oGateHistory.TrailerNumber = txtTrailerNumber.Text.Trim();
				oGateHistory.DriverName = txtDriverName.Text.Trim();
			}
			else
			{
				// по путевому листу / пропуску 
				if (grdData.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет исходных данных для регистрации пересечения ворот!");
					return;
				}
				if (grdData.CurrentRow == null)
				{
					RFMMessage.MessageBoxError("Не выбрана машина!");
					return;
				}

				/*
				DataRow r = null;
				if (grdData.CurrentRow.DataBoundItem is DataRow) 
					r = (DataRow)grdData.CurrentRow.DataBoundItem;
				else
					r = ((DataRowView)grdData.CurrentRow.DataBoundItem).Row;
				*/
				DataRow r = ((DataRowView)grdData.CurrentRow.DataBoundItem).Row;

				if (!Convert.IsDBNull(r["TransportPermissionID"]))
					oGateHistory.TransportPermissionID = Convert.ToInt32(r["TransportPermissionID"]);

				if (!Convert.IsDBNull(r["WayBillID"]))
					oGateHistory.WayBillID = Convert.ToInt32(r["WayBillID"]);

				if (!Convert.IsDBNull(r["PassID"]))
					oGateHistory.PassID = Convert.ToInt32(r["PassID"]);

				if (!Convert.IsDBNull(r["CarID"]))
					oGateHistory.CarID = Convert.ToInt32(r["CarID"]);
				oGateHistory.CarName = r["CarName"].ToString();
				oGateHistory.CarTypeName = r["CarTypeName"].ToString();
				oGateHistory.CarNumber = r["CarNumber"].ToString();
				oGateHistory.TrailerNumber = r["TrailerNumber"].ToString();
				oGateHistory.DriverName = r["DriverName"].ToString();
			}

			oGateHistory.DateCross = dtpDateCross.Value;
			oGateHistory.IsDeparture = optDeparture.Checked;

			oGateHistory.OtherReason = txtReason.Text.Trim();
			oGateHistory.CarWeight = Convert.ToInt32(numCarWeight.Value);
			oGateHistory.Note = txtNote.Text.Trim();

			oGateHistory.ClearError();
			oGateHistory.Save(((RFMFormMain)Application.OpenForms[0]).UserID);

			if (oGateHistory.ErrorNumber == 0)
			{
				// код добавленной записи 
				if (!nGateHistoryID.HasValue && oGateHistory.ID.HasValue && oGateHistory.ID != 0)
				{
					nGateHistoryID = (int)oGateHistory.ID;
				}

				if (oGateHistory.ErrorNumber == 0 && nGateHistoryID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int?)nGateHistoryID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		private void ClearFactInfo()
		{
			txtCarNаme.Text =
			txtCarNumber.Text =
			txtCarTypeName.Text = 
			txtTrailerNumber.Text =
			txtDriverName.Text =
				"";
		}

		private void dtpDateCross_ValueChanged(object sender, EventArgs e)
		{
			if (!bLoaded)
				return;

			grdData_Restore();
		}

		private void optArrival_CheckedChanged(object sender, EventArgs e)
		{
			if (!bLoaded)
				return;

			grdData_Restore();
		}

		private void chkArrivalDeparture_CheckedChanged(object sender, EventArgs e)
		{
			if (!bLoaded)
				return;

			grdData_Restore();
		}

		private void chkRepeat_CheckedChanged(object sender, EventArgs e)
		{
			if (!bLoaded)
				return;

			grdData_Restore();
		}

		private void chkFact_CheckedChanged(object sender, EventArgs e)
		{
			if (chkFact.Checked)
			{
				tabFact.Enabled = true;
				tcCars.SelectedTab = tabFact;
			}
			else
			{
				tabFact.Enabled = false;
				tcCars.SelectedTab = tabCars;
			}
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
			DataRow r = null;
			if (grdData.Rows[e.RowIndex].DataBoundItem is DataRow)
				r = (DataRow)grdData.Rows[e.RowIndex].DataBoundItem;
			else
				r = ((DataRowView)grdData.Rows[e.RowIndex].DataBoundItem).Row;

			DataGridViewColumn c = grdData.Columns[e.ColumnIndex];
			switch (c.Name)
			{
				case "grcConfirmedImage":
					if (Convert.ToBoolean(r["IsConfirmed"]))
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						e.Value = Properties.Resources.Empty;
					}
					break;
			}

			if (Convert.ToBoolean(r["IsOtherCar"]))
			{
				e.CellStyle.BackColor = Color.LightYellow;
			}
			else
			{
				e.CellStyle.BackColor = grdData.DefaultCellStyle.BackColor;
			}

		}

		private void txtCarNameContext_Validating(object sender, CancelEventArgs e)
		{
			if (grdData.Rows.Count == 0 ||
				txtCarNameContext.Text.Trim().Length == 0)
				return;

			foreach (DataGridViewRow r in grdData.Rows)
			{
				if (r.Cells["grcCarName"].Value.ToString().ToUpper().Contains(txtCarNameContext.Text.Trim().ToUpper()))
				{
					grdData.Rows[r.Index].Cells["grcCarName"].Selected = true;
					btnSave.Select();
					break;
				}
			}
		}

		private void frmGatesHistoryEdit_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				txtCarNameContext_Validating(null, null);
		}

	}
}
