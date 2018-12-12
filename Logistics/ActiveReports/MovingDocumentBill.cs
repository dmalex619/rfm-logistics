using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Data;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;

using RFMPublic;

namespace Logistics
{
	public partial class MovingDocumentBill : DataDynamics.ActiveReports.ActiveReport3
	{
		private DataSet ds;

		private int nMovingDocumentID;

		public MovingDocumentBill()
		{
			InitializeComponent();
		}

		private void MovingDocumentBill_ReportStart(object sender, EventArgs e)
		{
			ds = ((DataTable)DataSource).DataSet;
		}

		private void groupMovingDocumentID_Format(object sender, EventArgs e)
		{
			txtBillNumber.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "BillNumber");
			txtDateMoving.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "DateMoving").Substring(0, 10);
			txtGoodStateSourceName.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "GoodStateSourceName");
			txtGoodStateTargetName.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "GoodStateTargetName");
			txtOwnerSourceName.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "OwnerSourceName");
			txtOwnerTargetName.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "OwnerTargetName");
			txtNote.Text = RFMUtilities.GetValue(ds, 1, "ID", nMovingDocumentID, "Note");

			object dDateConfirm = RFMUtilities.GetValueObject(ds, 1, "ID", nMovingDocumentID, "DateConfirm");
			if (dDateConfirm != null && !Convert.IsDBNull(dDateConfirm))
			{
				txtDateConfirm.Text = "Вып." + ((DateTime)dDateConfirm).ToString("dd.MM.yyyy HH:mm");
			}
			else
			{
				txtDateConfirm.Text = "Не вып.";
			}
			
		}

		private void detail_Format(object sender, EventArgs e)
		{
			nMovingDocumentID = Convert.ToInt32(Fields["MovingDocumentID"].Value);
		}

		private void pageFooter_Format(object sender, EventArgs e)
		{
			txtMovingDocumentIDFooter.Text = nMovingDocumentID.ToString();
		}

	}
}
