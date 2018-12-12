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
	public partial class frmOutputsDocumentsDeliveryPrices: RFMFormChild
	{
		private OutputDocument oOutputDocument;
		DataTable dt; 

		public frmOutputsDocumentsDeliveryPrices()
		{
			oOutputDocument = new OutputDocument();
			if (oOutputDocument.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsDeliveryPrices_Load (object sender, EventArgs e)
		{
			//grdOutputsDocuments.IsCheckerInclude = true;
			//grdOutputsDocuments.IsCheckerShow = true;

			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}
			grcOutputsDocuments_DeliveryPrice.AgrType = EnumAgregate.Sum;

			dtrDates.dtpEndDate.Value = DateTime.Now.AddDays(-DateTime.Now.Day).Date;
			dtrDates.dtpBegDate.Value = dtrDates.dtpEndDate.Value.AddDays(-dtrDates.dtpEndDate.Value.Day).AddDays(1).Date;

			lblSumDeliveryPrice.Text = ""; 

			btnGo_Click(null, null);

			ShowTotal();
		}
		
		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnGo_Click(object sender, EventArgs e)
		{
			grdOutputsDocuments_Restore(); 
		}

		private void btnPrintFacture_Click(object sender, EventArgs e)
		{
		}

		#region Restore 

		private bool grdOutputsDocuments_Restore()
		{
			WaitOn(this);
			grdOutputsDocuments.DataSource = null;
			oOutputDocument.FilterDateBeg = dtrDates.dtpBegDate.Value;
			oOutputDocument.FilterDateEnd = dtrDates.dtpEndDate.Value;
			oOutputDocument.FilterDeliveryNeed = true;
			oOutputDocument.FillDataAsync();
			if (oOutputDocument.ErrorNumber == 0 && oOutputDocument.MainTable != null)
			{
				if (oOutputDocument.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxInfo("Нет данных...");
				}
				else
				{
					string sFilter = "DeliveryPrice > 0";
					if (chkFactureNeedOnly.Checked)
					{
						sFilter += " and PF_FactureNeed = true"; 
					}
					dt = CopyTable(oOutputDocument.MainTable, "dt", sFilter, "DateOutput, FactureNumber, TripAlias, PartnerTargetName, ID");
					if (dt != null)
						grdOutputsDocuments.Restore(dt);
				}
			}
			ShowTotal();
			WaitOff(this);
			return (oOutputDocument.ErrorNumber == 0);
		}

		#endregion Restore

		#region Grid

		private void grdOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (grdOutputsDocuments.DataSource == null)
				return;

			DataGridViewColumn c = grdOutputsDocuments.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (grdOutputsDocuments.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)grdOutputsDocuments.Rows[e.RowIndex].DataBoundItem).Row;

			// подтверждение отгрузки и доставки клиенту
			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					if ((bool)r["SuccessConfirmed"])
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

			if (sColumnName.Contains("IsBroughtImage".ToUpper()))
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

			// перенос
			if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOutputDocumentID"]))
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}
			return;
		}

		#endregion Grid

		#region Total

		private void ShowTotal()
		{
			decimal nSum = 0;
			if (dt != null)
			{
				bool bIsStatusShow = dt.Columns.Contains("IsNormal");
				foreach (DataRow r in dt.Rows)
				{
					if (!bIsStatusShow || (bool)r["IsNormal"]) 
						nSum += Convert.ToDecimal(r["DeliveryPrice"]);
				}
			}

			lblSumDeliveryPrice.Text = nSum.ToString("### ### ##0.00").Trim();
		}

		#endregion

		private void btnPrint_Click(object sender, EventArgs e)
		{
			grdOutputsDocuments.ExportData();
		}

	}
}
