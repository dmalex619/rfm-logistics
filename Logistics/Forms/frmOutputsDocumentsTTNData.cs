using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using DataDynamics.ActiveReports;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;

namespace Logistics
{
	public partial class frmOutputsDocumentsTTNData : RFMFormChild
	{
		DataTable dt;
		private OutputDocument oOutputDocument;
		private Output oOutput;

		public frmOutputsDocumentsTTNData(DataTable _dt)
		{
			if (_dt == null)
			{
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				dt = _dt;
				InitializeComponent();
			}
		}

		public frmOutputsDocumentsTTNData(OutputDocument _oOutputDocument)
		{
			if (_oOutputDocument == null || 
				(!_oOutputDocument.ID.HasValue && _oOutputDocument.IDList == null))
			{
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				oOutputDocument = _oOutputDocument;
				InitializeComponent();
			}
		}

		public frmOutputsDocumentsTTNData(Output _oOutput)
		{
			if (_oOutput == null ||
				(!_oOutput.ID.HasValue && _oOutput.IDList == null))
			{
				DialogResult = DialogResult.No;
				IsValid = false;
			}

			if (IsValid)
			{
				oOutput = _oOutput;
				InitializeComponent();
			}
		}

		private void frmOutputsDocumentsTTNData_Load(object sender, EventArgs e)
		{
			bool bOK = true;

			if (dt == null)
			{
				if (oOutputDocument != null)
				{
					if (FillOutputsDocuments_dt())
					{
						if (dt == null || dt.Rows.Count == 0)
						{
							RFMMessage.MessageBoxInfo("Нет расходных документов...");
							bOK = false;
						}
					}
				}

				if (oOutput != null)
				{
					if (FillOutputs_dt())
					{
						if (dt == null || dt.Rows.Count == 0)
						{
							RFMMessage.MessageBoxInfo("Нет расходов...");
							bOK = false;
						}
					}
				}
			}

			if (bOK)
			{
				grdData.IsCheckerShow = true; 
				grdData_Restore();
			}
			else
			{
				Dispose();
				return;
			}
		}

		private bool FillOutputsDocuments_dt()
		{
			bool bOK = true;

			dt = null;

			oOutputDocument.FillData();
			if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
				bOK = false;

			if (bOK)
			{
				oOutputDocument.FillTTNTableOutputsDocuments("-1");
				if (oOutputDocument.ErrorNumber != 0 || !oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsTTN"))
					bOK = false;
			}
			if (bOK)
			{
				dt = CopyTable(oOutputDocument.DS.Tables["TableOutputsDocumentsTTN"], "dt", "", "");

				DataTable dtOutputsDocuments = CopyTable(oOutputDocument.MainTable, "dtOutputsDocuments", "",
					"PartnerDetailBayerID, PartnerDetailShipperID, BillNumber");
				int nPartnerDetailBayerID = 0;
				int nPartnerDetailShipperID = 0;
				string sOutputsDocumentsIDTempList = "";
				foreach (DataRow r in dtOutputsDocuments.Rows)
				{
					if (((int)r["PartnerDetailBayerID"] != nPartnerDetailBayerID ||
						 (int)r["PartnerDetailShipperID"] != nPartnerDetailShipperID) &&
						sOutputsDocumentsIDTempList.Length > 0)
					{
						oOutputDocument.FillTTNTableOutputsDocuments(sOutputsDocumentsIDTempList);
						if (oOutputDocument.ErrorNumber != 0 || !oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsTTN"))
						{
							bOK = false;
							break;
						}

						dt.Merge(oOutputDocument.DS.Tables["TableOutputsDocumentsTTN"]);
						sOutputsDocumentsIDTempList = "";
					}

					sOutputsDocumentsIDTempList += r["ID"].ToString() + ",";
					nPartnerDetailBayerID = (int)r["PartnerDetailBayerID"];
					nPartnerDetailShipperID = (int)r["PartnerDetailShipperID"];
				}
				if (sOutputsDocumentsIDTempList.Length > 0)
				{
					oOutputDocument.FillTTNTableOutputsDocuments(sOutputsDocumentsIDTempList);
					if (oOutputDocument.ErrorNumber != 0 || !oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsTTN"))
						bOK = false;
					else
						dt.Merge(oOutputDocument.DS.Tables["TableOutputsDocumentsTTN"]);
				}
			}
			return (bOK);
		}

		private bool FillOutputs_dt()
		{
			bool bOK = true;

			dt = null;

			oOutput.FillData();
			if (oOutput.ErrorNumber != 0 || oOutput.MainTable == null)
				bOK = false;

			if (bOK)
			{
				oOutput.FillTTNTableOutputs("-1");
				if (oOutput.ErrorNumber != 0 || !oOutput.DS.Tables.Contains("TableOutputsTTN"))
					bOK = false;
			}
			if (bOK)
			{
				dt = CopyTable(oOutput.DS.Tables["TableOutputsTTN"], "dt", "", "");

				DataTable dtOutputs = CopyTable(oOutput.MainTable, "dtOutputs", "",
					"PartnerID, OwnerID, ID");
				int nPartnerID = 0;
				int nOwnerID = 0;
				string sOutputsIDTempList = "";
				foreach (DataRow r in dtOutputs.Rows)
				{
					if (((int)r["PartnerID"] != nPartnerID ||
						 (int)r["OwnerID"] != nOwnerID) &&
						sOutputsIDTempList.Length > 0)
					{
						oOutput.FillTTNTableOutputs(sOutputsIDTempList);
						if (oOutput.ErrorNumber != 0 || !oOutput.DS.Tables.Contains("TableOutputsTTN"))
						{
							bOK = false;
							break;
						}

						dt.Merge(oOutput.DS.Tables["TableOutputsTTN"]);
						sOutputsIDTempList = "";
					}

					sOutputsIDTempList += r["ID"].ToString() + ",";
					nPartnerID = (int)r["PartnerID"];
					nOwnerID = (int)r["OwnerID"];
				}
				if (sOutputsIDTempList.Length > 0)
				{
					oOutput.FillTTNTableOutputs(sOutputsIDTempList);
					if (oOutput.ErrorNumber != 0 || !oOutput.DS.Tables.Contains("TableOutputsTTN"))
						bOK = false;
					else
						dt.Merge(oOutput.DS.Tables["TableOutputsTTN"]);
				}
			}
			return (bOK);
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Dispose();
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private bool grdData_Restore()
		{
			if (dt.Rows.Count > 0)
			{
				DataRow r = dt.Rows[0];
				txtShipperInfo.Text = r["ShipperInfo"].ToString();
				txtPointCharge.Text = r["PointCharge"].ToString();
			}

			grdData.Restore(dt);

			return (true);
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			if (grdData.Rows.Count == 0 || grdData.CurrentRow == null)
				return; 

			DataTable dtRep = CopyTable(dt, "dtRep", "IsMarked = true", "");
			if (dtRep.Rows.Count == 0)
			{
				// текущая запись
				DataRow dr = ((DataRowView)((DataGridViewRow)grdData.Rows[grdData.CurrentRow.Index]).DataBoundItem).Row;
				DataTable dtRepTemp = CopyTable(dt, "dtRep", "IDList = '" + dr["IDList"].ToString() + "'", "");
				dtRep.Merge(dtRepTemp);
			}

			foreach (DataRow r in dtRep.Rows)
			{
				//r["ShipperInfo"] = txtShipperInfo.Text;
				r["PointCharge"] = txtPointCharge.Text;
			}

            if (optPrintTTNOnly.Checked || optPrintTTNandTransportBill.Checked)
            {
                ActiveReport3 repTTN = new TtnOneLine();
                StartForm(new frmActiveReport(dtRep, repTTN, (int)numCopies.Value));
            }
            if (optPrintTransportBillOnly.Checked || optPrintTTNandTransportBill.Checked)
            {
                ActiveReport3 repTransportBill = new TransportBill();
                StartForm(new frmActiveReport(dtRep, repTransportBill, (int)numCopies.Value));
            }
        }
	}
}
