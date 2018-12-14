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
	public partial class frmOutputsDocumentsFactTime : RFMFormChild
	{
		private int nTripID;
		private Trip oTrip; 
		private OutputDocument oOutputDocument;
		private DataTable dt;
		
		public frmOutputsDocumentsFactTime(int _nTripID)
		{
			nTripID = _nTripID;
			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (isValid)
			{
				oOutputDocument = new OutputDocument();
				if (oOutputDocument.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsFactTime_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			oTrip.ReFillOne(nTripID);

            if (oTrip.DepartureTime.HasValue && oTrip.ArrivalTime.HasValue)
            {
                lblOutInTime.Text = lblOutInTime.Text +
                    ((DateTime)oTrip.DepartureTime).ToShortDateString() + " " + ((DateTime)oTrip.DepartureTime).ToShortTimeString() +
                    " - " +
                    ((DateTime)oTrip.ArrivalTime).ToShortDateString() + " " + ((DateTime)oTrip.ArrivalTime).ToShortTimeString();
            }

			numDistance.Value = oTrip.Distance;

			if (!dgvOutputsDocuments_Restore())
			{
				bResult = false;
			}
			if (!bResult)
			{
				Dispose();
				Close();
			}

			string cColumnName = "";
			dgvOutputsDocuments.ReadOnly = false;
			foreach (DataGridViewColumn c in dgvOutputsDocuments.Columns)
			{
				cColumnName = c.Name.ToUpper();
				c.ReadOnly = !(cColumnName.Contains("TIME")); 
			}
			if (dgvOutputsDocuments.Rows.Count > 0)
			{
				dgvOutputsDocuments.CurrentCell = dgvOutputsDocuments.Rows[0].Cells["dgvcTimeBeg"];
			}
		}

	#region Restore

		private bool dgvOutputsDocuments_Restore()
		{
			oOutputDocument.ClearError();
			oOutputDocument.FilterTripsList = nTripID.ToString();
			oOutputDocument.FillData();
			if (oOutputDocument.ErrorNumber == 0)
			{
				dt = oOutputDocument.MainTable;
				dt.Columns.Add("TimeBeg", Type.GetType("System.String"));
				dt.Columns.Add("TimeEnd", Type.GetType("System.String"));
				DataColumn dc = dt.Columns.Add("IsUnique", Type.GetType("System.Boolean"));
				dc.DefaultValue = false;

				DataRow dr;
				string sDate;
				for (int nI = 0; nI < dt.Rows.Count; nI++)
				{
					dr = dt.Rows[nI];
					
					if (dr["DateBegFact"] == DBNull.Value)
						sDate = "ddMMyyyy00:00";
					else
						sDate = (Convert.ToDateTime(dr["DateBegFact"])).ToString("ddMMyyyyHH:mm");
					
					if (sDate.Length > 0)
					{
						dr["TimeBeg"] = sDate.Substring(8, 5);
					}
					
					if (dr["DateEndFact"] == DBNull.Value)
						sDate = "ddMMyyyy00:00";
					else
						sDate = (Convert.ToDateTime(dr["DateEndFact"])).ToString("ddMMyyyyHH:mm");
	
					if (sDate.Length > 0)
					{
						dr["TimeEnd"] = sDate.Substring(8, 5);
					}
				}

				int idMask = -1, idValue;
				DataRowView drv;
				dt.DefaultView.Sort = "PartnerTargetID";
				for (int i = 0; i < dt.DefaultView.Count; i++)
				{
					drv = dt.DefaultView[i];
					idValue = (int)drv["PartnerTargetID"];
					if (idMask != idValue)
					{
						drv["IsUnique"] = true;
						idMask = idValue;
					}
				}
				dgvOutputsDocuments.Restore(dt);
				dgvOutputsDocuments.GridSource.Filter = "IsUnique";
				dgvOutputsDocuments.GridSource.Sort = "ByOrder" + (oTrip.IsPostern ? " desc" : "") + ", PartnerTargetName";
			}
			return (oOutputDocument.ErrorNumber == 0);
		}

	#endregion

	#region Cells
		private void dgvOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// используется для OutputsDocuments и InputsDocuments

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
				if ((bool)r["IsBrought"])
				{
					if ((bool)r["SuccessBrought"])
					{
						e.Value = Properties.Resources.Check;
					}
					else
					{
						e.Value = Properties.Resources.CheckRed;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			// нетто-брутто
			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
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
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int nDistance = (int)numDistance.Value;
			int nDistanceOld = oTrip.Distance;

			dgvOutputsDocuments.GridSource.Filter = "";
	
			int nNegative = -1;
			DataRow dr;
			DataGridViewRow dgvr;
			for (int i = 0; i < dgvOutputsDocuments.Rows.Count; i++)
			{
				dgvr = dgvOutputsDocuments.Rows[i];
				
				if (dgvr.Cells["dgvcDurationMinutesFact"].Value != DBNull.Value
					 && (int)dgvr.Cells["dgvcDurationMinutesFact"].Value < 0)
				{
					nNegative = i;
					break;
				}
			}
			if (nNegative >= 0)
			{
				dgvOutputsDocuments.GridSource.Filter = "IsUnique";
				RFMMessage.MessageBoxError("Укажите правильное время пребывания у клиента...");
				dgvOutputsDocuments.Rows[nNegative].Cells["dgvcTimeEnd"].Selected = true;
				dgvOutputsDocuments.BeginEdit(true);
				return;
			}

			bool bFind = (nDistance != nDistanceOld);
			if (!bFind)
			{
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					dr = dt.Rows[i];
					if (dr["DurationMinutesFact"] != DBNull.Value && (int)dr["DurationMinutesFact"] > 0)
					{
						bFind = true;
						break;
					}
				}
			}
			if (!bFind)
			{
				dgvOutputsDocuments.GridSource.Filter = "IsUnique";
				RFMMessage.MessageBoxAttention("Нечего сохранять...");
				return;
			}

			int idMask = -1, idValue, nDuration = 0;
			DataRowView drv;
			DateTime? dDateBeg = DateTime.Now, dDateEnd = DateTime.Now;
			dt.DefaultView.Sort = "PartnerTargetID";
			for (int i = 0; i < dt.DefaultView.Count; i++)
			{
				drv = dt.DefaultView[i];
				idValue = (int)drv["PartnerTargetID"];
				if (idMask == idValue)
				{
					if (dDateBeg == null)
						drv["DateBegFact"] = DBNull.Value;
					else
						drv["DateBegFact"] = dDateBeg;
					if (dDateEnd == null)
						drv["DateEndFact"] = DBNull.Value;
					else
						drv["DateEndFact"] = dDateEnd;
					drv ["DurationMinutesFact"] = nDuration;
				}
				else
				{
					idMask = idValue;

					if (drv["DateBegFact"] == DBNull.Value)
						dDateBeg = null;
					else
						dDateBeg = (DateTime)drv["DateBegFact"];
					
					if (drv["DateEndFact"] == DBNull.Value)
						dDateEnd = null;
					else
						dDateEnd = (DateTime)drv["DateEndFact"];

					if (drv["DurationMinutesFact"] == DBNull.Value)
						nDuration = 0;
					else
						nDuration = (int)drv["DurationMinutesFact"];
				}
			}
			for (int i = 0; i < dt.Rows.Count; i++)
			{
				dr = dt.Rows[i];
				if (dr["DurationMinutesFact"] != DBNull.Value && (int)dr["DurationMinutesFact"] > 0)
				{
					oOutputDocument.SetDateFact((int)dr["ID"], (DateTime?)dr["DateBegFact"], (DateTime?)dr["DateEndFact"]);
					if (oOutputDocument.ErrorNumber != 0)
						break;
				}
			}
			if (oOutputDocument.ErrorNumber == 0)
			{
				if (nDistance != nDistanceOld)
				{
					oTrip.TripDistanceSave(nTripID, nDistance); 
				}

				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		private void dgvOutputsDocuments_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvOutputsDocuments.IsRestoring)
				return;
		
			DataRowView drvO = (DataRowView)dgvOutputsDocuments.CurrentRow.DataBoundItem;
			string sDate = drvO["DateOutput"].ToString().Trim();
			TimeSpan dsTemp;
			switch (dgvOutputsDocuments.Columns[e.ColumnIndex].Name.ToLower())
			{
				case "dgvctimebeg":
					if (drvO["TimeBeg"].ToString().Trim().Length > 0)
					{
						drvO["DateBegFact"] = Convert.ToDateTime(sDate.Substring(0, 10) + " " + drvO["TimeBeg"].ToString().Trim());
						if (drvO["DurationMinutesFact"].ToString().Trim().Length > 0 && drvO["TimeBeg"].ToString().Trim().Length == 0)
							drvO["DateEndFact"] = ((DateTime)drvO["DateBegFact"]).AddMinutes((int)drvO["DurationMinutesFact"]);
						else
						{
							if (drvO["DateEndFact"] != DBNull.Value)
							{
								dsTemp = (DateTime)drvO["DateEndFact"] - (DateTime)drvO["DateBegFact"];
								drvO["DurationMinutesFact"] = (int)(dsTemp.Hours * 60 + dsTemp.Minutes);
							}
						}
					}
					else
					{
						if (drvO["DurationMinutesFact"].ToString().Trim().Length > 0 && drvO["TimeEnd"].ToString().Trim().Length > 0)
						{
							drvO["DateBegFact"] = ((DateTime)drvO["DateEndFact"]).AddMinutes(-(int)drvO["DurationMinutesFact"]);
							drvO["TimeBeg"] = (Convert.ToDateTime(drvO["DateBegFact"])).ToString("ddMMyyyyHH:mm").Substring(8, 5);
						}
					}
					break;
				case "dgvctimeend":
					if (drvO["TimeEnd"].ToString().Trim().Length > 0)
					{
						drvO["DateEndFact"] = Convert.ToDateTime(sDate.Substring(0, 10) + " " + drvO["TimeEnd"].ToString().Trim());
						if (drvO["DurationMinutesFact"].ToString().Trim().Length > 0 && drvO["TimeEnd"].ToString().Trim().Length == 0)
							drvO["DateBegFact"] = ((DateTime)drvO["DateEndFact"]).AddMinutes(-(int)drvO["DurationMinutesFact"]);
						else
						{
							if (drvO["DateBegFact"] != DBNull.Value)
							{
								dsTemp = (DateTime)drvO["DateEndFact"] - (DateTime)drvO["DateBegFact"];
								drvO["DurationMinutesFact"] = (int)(dsTemp.Hours * 60 + dsTemp.Minutes);
							}
						}
					}
					else
					{
						if (drvO["DurationMinutesFact"].ToString().Trim().Length > 0 && drvO["TimeBeg"].ToString().Trim().Length > 0)
						{
							drvO["DateEndFact"] = ((DateTime)drvO["DateBegFact"]).AddMinutes((int)drvO["DurationMinutesFact"]);
							drvO["TimeEnd"] = (Convert.ToDateTime(drvO["DateEndFact"])).ToString("ddMMyyyyHH:mm").Substring(8, 5);
						}
					}
					break;
			}
		}
	}
}
