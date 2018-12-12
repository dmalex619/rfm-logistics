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
	public partial class frmOutputsDocumentsGoodsPriceEdit : RFMFormChild
	{
		private OutputDocument oOutputDocument;

		public frmOutputsDocumentsGoodsPriceEdit(int _nOutputDocumentID)
		{
			oOutputDocument = new OutputDocument();
			if (oOutputDocument.ErrorNumber != 0)
				IsValid = false;


			if (IsValid)
			{
				oOutputDocument.ID = _nOutputDocumentID;
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsGoodsPriceEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			if (!dgvOutputsDocumentsGoods_Restore())
			{
				bResult = false;
			}
			if (!bResult)
			{
				Dispose();
			}

			string cColumnName = "";
			dgvOutputsDocumentsGoods.ReadOnly = false;
			foreach (DataGridViewColumn c in dgvOutputsDocumentsGoods.Columns)
			{
				cColumnName = c.Name.ToUpper();
				
				c.ReadOnly = !(cColumnName.Contains("PRICE")); 
			}
			if (dgvOutputsDocumentsGoods.Rows.Count > 0)
			{
				dgvOutputsDocumentsGoods.BeginEdit(true);
//				dgvOutputsDocumentsGoods.CurrentCell = dgvOutputsDocumentsGoods.Rows[0].Cells["dgvcPrice"];
				dgvOutputsDocumentsGoods.Rows[0].Cells["dgvcPrice"].Selected = true;

			}

		}

	#region Restore

		private bool dgvOutputsDocumentsGoods_Restore()
		{
			dgvOutputsDocumentsGoods.GetGridState();
			dgvOutputsDocumentsGoods.DataSource = null;

			oOutputDocument.FillTableOutputsDocumentsGoods((int)oOutputDocument.ID);
			dgvOutputsDocumentsGoods.Restore(oOutputDocument.TableOutputsDocumentsGoods);
			return (oOutputDocument.ErrorNumber == 0);
		}


	#endregion Restore

	#region Cells

		private void dgvOutputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусна€ строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных 
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;
			if (sColumnName.Contains("RESULT"))
			{
				if (sColumnName.Contains("CONFIRMED"))
				{
					if ((decimal)r["QntConfirmed"] == 0)
					{
						e.Value = Properties.Resources.DotRed;
					}
					else
					{
						if ((decimal)r["QntWished"] == (decimal)r["QntConfirmed"])
						{
							e.Value = Properties.Resources.DotGreen;
						}
						else
						{
							if ((decimal)r["QntWished"] < (decimal)r["QntConfirmed"])
							{
								e.Value = Properties.Resources.DotBlue;
							}
							else
							{
								e.Value = Properties.Resources.DotYellow;
							}
						}
					}
				}
				if (sColumnName.Contains("BROUGHT"))
				{
					if ((decimal)r["QntBrought"] == 0)
					{
						e.Value = Properties.Resources.Plain_R;
					}
					else
					{
						if ((decimal)r["QntWished"] == (decimal)r["QntBrought"])
						{
							e.Value = Properties.Resources.Plain_G;
						}
						else
						{
							if ((decimal)r["QntWished"] < (decimal)r["QntBrought"])
							{
								e.Value = Properties.Resources.Plain_B;
							}
							else
							{
								e.Value = Properties.Resources.Plain_Y;
							}
						}
					}
				}
			}
			if (sColumnName.Contains("QNT") ||
				sColumnName.Contains("INBOX"))
			{
				if ((!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"]) ||
					(!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value)))
				{
					e.CellStyle.Format = "### ##0.000";
				}
				else
				{
					e.CellStyle.Format = "### ###";
				}
			}

			if ((sColumnName.Contains("QNT") || sColumnName.Contains("BOX") || sColumnName.Contains("PAL")) &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void dgvOutputsDocumentsGoods_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvOutputsDocumentsGoods.IsRestoring || dgvOutputsDocumentsGoods.IsStatusRow(e.RowIndex))
				return;

			DataRowView drvO = (DataRowView)dgvOutputsDocumentsGoods.CurrentRow.DataBoundItem;

			if (oOutputDocument.IsBrought)
				drvO["PriceSum"] = (decimal)drvO["QntBrought"] * (decimal)drvO["Price"];
			else
			{
				if  (oOutputDocument.IsConfirmed)
					drvO["PriceSum"] = (decimal)drvO["QntConfirmed"] * (decimal)drvO["Price"];
				else
					drvO["PriceSum"] = (decimal)drvO["QntWished"] * (decimal)drvO["Price"];
			}
			if (dgvOutputsDocumentsGoods.IsStatusShow)
				dgvOutputsDocumentsGoods.IncludeGridStatus(true);
		}
	#endregion Cells
		
	#region Buttons
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
			DataGridViewRow dgvr;
			int nEmptyPrice = -1;
			for (int i = 0; i < dgvOutputsDocumentsGoods.Rows.Count; i++)
			{
				dgvr = dgvOutputsDocumentsGoods.Rows[i];
				
				if ((decimal)dgvr.Cells["dgvcPrice"].Value == 0)
				{
					nEmptyPrice = i;
					break;
				}
			}
			if (nEmptyPrice >= 0)
			{
				RFMMessage.MessageBoxError("”кажите цену...");
				dgvOutputsDocumentsGoods.Rows[nEmptyPrice].Cells["dgvcPrice"].Selected = true;
				dgvOutputsDocumentsGoods.BeginEdit(true);
				return;
			}
			if (RFMMessage.MessageBoxYesNo("—охранить текущие цены?") == DialogResult.No)
				return; 

			for (int i = 0; i < dgvOutputsDocumentsGoods.Rows.Count; i++)
			{
				dgvr = dgvOutputsDocumentsGoods.Rows[i];
				oOutputDocument.GoodPriceEdit((int)dgvr.Cells["dgvcID"].Value, (decimal)dgvr.Cells["dgvcPrice"].Value);
				if (oOutputDocument.ErrorNumber != 0)
					break;
			}

			if (oOutputDocument.ErrorNumber == 0)
			{
				Dispose();
			}

		}
	#endregion Buttons

	}
}
