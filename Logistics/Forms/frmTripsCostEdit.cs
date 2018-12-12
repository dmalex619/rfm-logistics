using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using LogBizObjects;
using RFMPublic;

namespace Logistics 
{
	public partial class frmTripsCostEdit : RFMFormChild
	{
		private DataTable dtSource;
		private Trip oTrip; 

		public frmTripsCostEdit(DataTable dt)
		{
			dtSource = dt;
			if (dtSource == null || dtSource.Rows.Count == 0)
				IsValid = false;

			if (isValid)
			{
				oTrip = new Trip();
				if (oTrip.ErrorNumber != 0)
				{
					IsValid =  false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}
	
		private void frmTripsCostEdit_Load(object sender, EventArgs e)
		{
			if (!dgvTrips_Restore())
			{
				Dispose();
				return;
			}

			if (dgvTrips.Rows.Count > 0)
			{
				dgvTrips.CurrentCell = dgvTrips.Rows[0].Cells["dgvcCost"];
			}
		}

	#region Restore

		private bool dgvTrips_Restore()
		{
			dgvTrips.Restore(dtSource);
			dgvTrips.GridSource.Filter = "IsRentCar";
			return true;
		}	

	#endregion

	#region Cells

		private void dgvTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null || grd.Rows.Count == 0)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			if (sColumnName.Contains("Image".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
					e.Value = Properties.Resources.Check;
				else
					e.Value = Properties.Resources.Empty;
			}

			// себестоимость
			if (sColumnName.Contains("Cost".ToUpper()))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

	#endregion Cells
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			dgvTrips.GridSource.Filter = "";
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			bool bFind = false;
			DataRow dr;
			for (int i = 0; i < dtSource.Rows.Count; i++)
			{
				dr = dtSource.Rows[i];
				if (dr["Cost"] != DBNull.Value && dr["Cost"] != null && 
					(decimal)dr["Cost"] >= 0)
				{
					bFind = true;
					break;
				}
			}
			if (!bFind)
			{
				RFMMessage.MessageBoxAttention("Нечего сохранять...");
				return;
			}

			for (int i = 0; i < dtSource.Rows.Count; i++)
			{
				dr = dtSource.Rows[i];
				if (dr["Cost"] != DBNull.Value && dr["Cost"] != null && 
					(decimal)dr["Cost"] >= 0 &&
					dr["TripID"] != DBNull.Value && dr["TripID"] != null)
				{
					oTrip.TripCostSave((int)dr["TripID"], (decimal)dr["Cost"]);
					if (oTrip.ErrorNumber != 0)
						break;
				}
			}
			if (oTrip.ErrorNumber == 0)
			{
				dgvTrips.GridSource.Filter = "";
				Dispose();
			}
		}
	}
}
