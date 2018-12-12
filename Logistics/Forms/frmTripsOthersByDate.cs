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
	public partial class frmTripsOthersByDate: RFMFormChild
	{
		private Trip oTrip;
		private DataTable tCars;

		public frmTripsOthersByDate()
		{
			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();

				grdTrips.IsCheckerInclude = true;
				grdTrips.IsCheckerShow = true;
			}
		}

		public frmTripsOthersByDate(bool _bSelfDelivery): this()
		{
			if (_bSelfDelivery)
			{
				optSelfDelivery.Checked = true;
			}
			else
			{
				optIsRentCar.Checked = true;  
			}
			pnlOtherSelfDelivery.Enabled = false;
		}

		private void frmTripsOthersByDate_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			dtpDate.Value = DateTime.Now.Date;
			
			lblTotalCnt.Text =
			lblTotalPalletsQnt.Text =
			lblTotalTonnage.Text =
			lblTotalVolume.Text =
				""; 

			//btnCreateTrips_Click(null, null);
			ShowTotal();

			if (bResult)
			{
				// оставляем для редактирования только нужные колонки
				// здесь: все 
				/*
				foreach (DataGridViewColumn dc in grdTrips.Columns)
				{
					if (dc.Name.ToUpper().Contains("MARK") || dc.Name.ToUpper().Contains("ALIAS"))
					{
						dc.ReadOnly = false;
					}
					else
					{
						dc.ReadOnly = true;
					}
				}
				*/ 
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

		private void btnCreateTrips_Click(object sender, EventArgs e)
		{
			// проверить, были ли уже изменения
			grdTrips_Restore(); 
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			DateTime dDate = dtpDate.Value.Date;

			int nCnt = 0;
			if (grdTrips.Columns["dgvcIsMarked"] != null)
			{
				int nColIndex = grdTrips.Columns["dgvcIsMarked"].Index;
				foreach (DataGridViewRow gr in grdTrips.Rows)
				{
					if (Convert.ToBoolean(gr.Cells[nColIndex].Value))
					{
						nCnt++;
					}
				}
			}
			if (nCnt == 0)
			{
				RFMMessage.MessageBoxError("Не отмечено ни одного рейса...");
				return;
			}
			if (RFMMessage.MessageBoxYesNo("Создать " + RFMUtilities.Declen(nCnt, "рейс", "рейса", "рейсов") +
				" для " + ((optSelfDelivery.Checked)
							? RFMUtilities.Declen(nCnt, "машины клиента", "машин клиентов", "машин клиентов")
							: RFMUtilities.Declen(nCnt, "арендованной машины", "арендованных машин", "арендованных машин")) + 
				"\nна " + dDate.ToString("dd.MM.yyyy") + "?") != DialogResult.Yes)
				return;

			oTrip.ClearError();
			oTrip.SaveOthersByDate(tCars, dDate, optSelfDelivery.Checked);
			if (oTrip.ErrorNumber == 0)
			{
				RFMMessage.MessageBoxInfo("Рейсы созданы.");
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		private void chkShowReady_CheckedChanged(object sender, EventArgs e)
		{
			btnCreateTrips_Click(null, null);
		}

		#region Restore 

		private bool grdTrips_Restore()
		{
			WaitOn(this);
			grdTrips.DataSource = null;
			oTrip.CreateOthersByDate(dtpDate.Value.Date, (int)numCnt.Value);
			if (oTrip.ErrorNumber == 0 && oTrip.DS.Tables["CarsByDate"] != null)
			{
				tCars = CopyTable(oTrip.DS.Tables["CarsByDate"], "tCars", "Ready = false", "");
				grdTrips.Restore(tCars);
			}

			grdTrips.MarkAllRows(true);

			WaitOff(this);
			return (oTrip.ErrorNumber == 0);
		}

		#endregion Restore

		#region Grid

		private void grdTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdTrips.DataSource == null || grdTrips.CurrentRow == null || e.RowIndex < 0)
				return;

			DataRow r = ((DataRowView)grdTrips.Rows[e.RowIndex].DataBoundItem).Row ;
			if (r == null)
				return;

			if ((bool)r["Ready"])
				e.CellStyle.BackColor = Color.FromArgb(250, 200, 200);

			return;
		}

		private void grdTrips_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
			if (grdTrips.DataSource == null || grdTrips.CurrentRow == null || e.RowIndex < 0)
				return;

			DataRow r = ((DataRowView)grdTrips.Rows[e.RowIndex].DataBoundItem).Row;
			if (r == null)
				return;

			if ((bool)r["Ready"] &&
				grdTrips.Columns["dgvcIsMarked"].Index == e.ColumnIndex)
			{
				using (
						Brush gridBrush = new SolidBrush(this.grdTrips.GridColor),
						backColorBrush = new SolidBrush(e.CellStyle.BackColor))
				{
					using (Pen gridLinePen = new Pen(gridBrush))
					{
						e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

						e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
							e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
							e.CellBounds.Bottom - 1);

						e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
							 e.CellBounds.Top, e.CellBounds.Right - 1,
							e.CellBounds.Bottom);
						e.Handled = true;
					}
				}
			}
		}

		#endregion Grid

		#region Total

		private void ShowTotal()
		{
			int nCnt = 0;
			int nTonnage = 0;
			decimal nVolume = 0;
			decimal nPalletsQnt = 0;
			if (grdTrips.Columns["dgvcIsMarked"] != null)
			{
				int nColIndex = grdTrips.Columns["dgvcIsMarked"].Index;
				foreach (DataGridViewRow gr in grdTrips.Rows)
				{
					if (Convert.ToBoolean(gr.Cells[nColIndex].Value))
					{
						DataRow dr = ((DataRowView)gr.DataBoundItem).Row;
						nCnt++;
						nTonnage += Convert.ToInt32(dr["Tonnage"]);
						nVolume += Convert.ToDecimal(dr["Volume"]);
						nPalletsQnt += Convert.ToDecimal(dr["MaxPalletsQnt"]);
					}
				}
			}

			lblTotalCnt.Text = nCnt.ToString("### ### ##0").Trim();
			lblTotalTonnage.Text = nTonnage.ToString("### ### ##0").Trim();
			lblTotalVolume.Text = nVolume.ToString("### ### ##0.0").Trim();
			lblTotalPalletsQnt.Text = nPalletsQnt.ToString("### ### ##0.0").Trim();
		}

		#endregion

		/*
		private void grdTrips_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (grdTrips.Columns[grdTrips.CurrentCell.ColumnIndex].Name.Contains("Marked") ||
				grdTrips.Columns[grdTrips.CurrentCell.ColumnIndex].DefaultCellStyle.Format.Contains("N"))
			{
				ShowTotal();
			}
		}

		private void grdTrips_KeyPress(object sender, KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			if (e.KeyChar == 32)
			{
				if (grdTrips.Columns[grdTrips.CurrentCell.ColumnIndex].ReadOnly)
				{
					ShowTotal();
				}
			}
		}

		private void grdTrips_KeyUp(object sender, KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (e.KeyCode == Keys.Space)
			{
				if (grdTrips.Columns[grdTrips.CurrentCell.ColumnIndex].ReadOnly)
				{
					ShowTotal();
				}
			}
		}
		*/ 

		private void grdTrips_MarkedAllEvent(object sender, bool isMarkOn)
		{
			ShowTotal();
		}

		private void grdTrips_MarkedOneEvent(object sender, bool isMarkOn)
		{
			ShowTotal();
		}

		private void grdTrips_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (grdTrips.Columns[e.ColumnIndex].DefaultCellStyle.Format.Contains("N"))
			{
				ShowTotal();
			}
		}
	}
}
