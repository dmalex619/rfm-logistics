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
	public partial class frmPassesEdit : RFMFormChild
	{
		private int? nPassID;
		private Pass oPass;

		private Partner oPartner;
		private Partner oCarrierPartner;

		public int? _SelectedID = null;
		public string _SelectedText = "";


		public frmPassesEdit(int? _nPassID)
		{
			if (_nPassID.HasValue)
			{
				nPassID = (int)_nPassID;
			}

			oPass = new Pass();
			if (oPass.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oPartner = new Partner();
				oCarrierPartner = new Partner();
				if (oPartner.ErrorNumber != 0 || 
					oCarrierPartner.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmPassesEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true;

			// классификаторы
			if (!cboPartner_Restore() ||  
				!cboCarrierPartner_Restore())
			{
				bResult = false;
			}

			if (bResult)
			{
				oPass.ID = nPassID;
				oPass.FillDataAsync();
				if (oPass.ErrorNumber != 0 || oPass.MainTable == null)
				{
					bResult = false;
				}

				if (bResult)
				{
					if (nPassID.HasValue && oPass.MainTable.Rows.Count != 1)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о пропуске...");
						bResult = false;
					}
				}
			}

			if (bResult)
			{
				cboPartner.SelectedIndex = 
				cboCarrierPartner.SelectedIndex =  
					-1;
				txtPartnerName.Text =
				txtCarrierPartnerName.Text =
					"";

				if (nPassID.HasValue)
				{
					// существующий пропуск
					oPass.FillOne();

					dtpDatePass.Value = oPass.DatePass;
					txtReason.Text = oPass.Reason;

					txtCarNаme.Text = oPass.CarName;
					txtCarTypeName.Text = oPass.CarTypeName;
					txtCarNumber.Text = oPass.CarNumber;
					txtTrailerNumber.Text = oPass.TrailerNumber;
					txtDriverName.Text = oPass.DriverName;
					txtDriverDocument.Text = oPass.DriverDocument;
					txtDriverPhone.Text = oPass.DriverPhone;

					numBrutto.Value = oPass.Brutto;
					numPalletsQnt.Value = oPass.PalletsQnt;

					if (oPass.PartnerID.HasValue)
					{
						cboPartner.SelectedValue = (int)oPass.PartnerID;
					}
					txtPartnerName.Text = oPass.PartnerName;
					if (oPass.CarrierPartnerID.HasValue)
					{
						cboCarrierPartner.SelectedValue = (int)oPass.CarrierPartnerID;
					}
					txtCarrierPartnerName.Text = oPass.CarrierPartnerName;

					if (oPass.DateBegPlan.HasValue)
					{
						chkArrivalPlan.Checked = true;
						chkArrivalPlan_CheckedChanged(null, null);
						dtpArrivalPlan.Value = (DateTime)oPass.DateBegPlan;
					}
					else
					{
						dtpArrivalPlan.HideControl(false);
					}
					if (oPass.DateEndPlan.HasValue)
					{
						chkDeparturePlan.Checked = true;
						chkDeparturePlan_CheckedChanged(null, null);
						dtpDeparturePlan.Value = (DateTime)oPass.DateEndPlan;
					}
					else
					{
						dtpDeparturePlan.HideControl(false);
					}
					if (oPass.DateBeg.HasValue)
					{
						chkArrivalFact.Checked = true;
						chkArrivalFact_CheckedChanged(null, null);
						dtpArrivalFact.Value = (DateTime)oPass.DateBeg;
					}
					else
					{
						dtpArrivalFact.HideControl(false);
					}
					if (oPass.DateEnd.HasValue)
					{
						chkDepartureFact.Checked = true;
						chkDepartureFact_CheckedChanged(null, null);
						dtpDepartureFact.Value = (DateTime)oPass.DateEnd;
					}
					else
					{
						dtpDepartureFact.HideControl(false);
					}

					txtNote.Text = oPass.Note;
				}
				else
				{
					dtpDatePass.Value = DateTime.Now;

					dtpArrivalPlan.HideControl(false);
					dtpDeparturePlan.HideControl(false);
					dtpArrivalFact.HideControl(false);
					dtpDepartureFact.HideControl(false);
				}
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

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (txtReason.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("Не указано назначение...");
				txtReason.Select();
				return; 
			}

			if (txtCarNаme.Text.Trim().Length == 0 && txtCarNumber.Text.Trim().Length == 0)
			{
				RFMMessage.MessageBoxError("Не указана машина...");
				txtCarNаme.Select();
				return;
			}

			oPass.DatePass = dtpDatePass.Value.Date;
			oPass.Reason = txtReason.Text.Trim();

			oPass.CarName = txtCarNаme.Text.Trim();
			oPass.CarNumber = txtCarNumber.Text.Trim();
			oPass.CarTypeName = txtCarTypeName.Text.Trim();
			oPass.TrailerNumber = txtTrailerNumber.Text.Trim();
			oPass.DriverName = txtDriverName.Text.Trim();
			oPass.DriverDocument = txtDriverDocument.Text.Trim();
			oPass.DriverPhone = txtDriverPhone.Text.Trim();

			oPass.Brutto = numBrutto.Value;
			oPass.PalletsQnt = numPalletsQnt.Value;

			if (cboPartner.SelectedIndex >= 0 && cboPartner.SelectedValue != null)
			{
				oPass.PartnerID = (int)cboPartner.SelectedValue ;
			}
			oPass.PartnerName = txtPartnerName.Text.Trim();
			if (cboCarrierPartner.SelectedIndex >= 0 && cboCarrierPartner.SelectedValue != null)
			{
				oPass.CarrierPartnerID = (int)cboCarrierPartner.SelectedValue ;
			}
			oPass.CarrierPartnerName = txtCarrierPartnerName.Text.Trim();
			
			oPass.Note = txtNote.Text.Trim();

			DateTime dTemp = DateTime.Now;
			if (chkArrivalPlan.Checked && !dtpArrivalPlan.IsEmpty)
			{
				dTemp = dtpArrivalPlan.Value;
				oPass.DateBegPlan = dTemp.AddSeconds(-dTemp.Second);
			}
			else
			{
				oPass.DateBegPlan = null; 
			}
			if (chkDeparturePlan.Checked && !dtpDeparturePlan.IsEmpty)
			{
				dTemp = dtpDeparturePlan.Value;
				oPass.DateEndPlan = dTemp.AddSeconds(-dTemp.Second);
			}
			else
			{
				oPass.DateEndPlan = null;
			}
			if (chkArrivalFact.Checked && !dtpArrivalFact.IsEmpty)
			{
				dTemp = dtpArrivalFact.Value;
				oPass.DateBeg = dTemp.AddSeconds(-dTemp.Second); ;
			}
			else
			{
				oPass.DateBeg = null;
			}
			if (chkDepartureFact.Checked && !dtpDepartureFact.IsEmpty)
			{
				dTemp = dtpDepartureFact.Value;
				oPass.DateEnd = dTemp.AddSeconds(-dTemp.Second);
			}
			else
			{
				oPass.DateEnd = null;
			}

			oPass.ClearError();
			oPass.SaveOne(((RFMFormMain)Application.OpenForms[0]).UserID);

			if (oPass.ErrorNumber == 0)
			{
				// код добавленной записи 
				if (!nPassID.HasValue && oPass.ID.HasValue)
				{
					nPassID = (int)oPass.ID;
				}

				if (oPass.ErrorNumber == 0 && nPassID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int?)nPassID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		#region Restore

		private bool cboPartner_Restore()
		{
			cboPartner.DataSource = null;
			oPartner.ClearError();
			oPartner.FilterActual = true;
			if (oPartner.FillDataAsync())
			{
				cboPartner.DataSource = new DataView(oPartner.MainTable);
				cboPartner.ValueMember = oPartner.ColumnID;
				cboPartner.DisplayMember = oPartner.ColumnName;
				cboPartner.Restore();
			}
			return (oPartner.ErrorNumber == 0);
		}

		private bool cboCarrierPartner_Restore()
		{
			cboCarrierPartner.DataSource = null;
			oCarrierPartner.ClearError();
			oCarrierPartner.FilterActual = true; 
			oCarrierPartner.FilterIsTransport = true;
			if (oCarrierPartner.FillDataAsync())
			{
				cboCarrierPartner.DataSource = new DataView(oCarrierPartner.MainTable);
				cboCarrierPartner.ValueMember = oCarrierPartner.ColumnID;
				cboCarrierPartner.DisplayMember = oCarrierPartner.ColumnName;
				cboCarrierPartner.Restore();
			}
			return (oCarrierPartner.ErrorNumber == 0);
		}

		#endregion Restore

		#region Reason

		private void btnReasonSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значения 
			Pass oPassTemp = new Pass();
			oPassTemp.FilterDateEnd = DateTime.Now.Date.AddMonths(-1);
			oPassTemp.FilterDateEnd = DateTime.Now.Date;
			oPassTemp.FillDataAsync();
			if (oPassTemp.ErrorNumber != 0 || oPassTemp.MainTable == null)
				return;
			if (oPassTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			DataTable dtReasonDistinct = new DataTable();
			dtReasonDistinct.Columns.Add("Reason");
			System.Collections.Hashtable hash = new System.Collections.Hashtable();
			foreach (DataRow row in oPassTemp.MainTable.Rows)
				hash[row["Reason"]] = row["Reason"];
			foreach (object name in hash.Values)
				dtReasonDistinct.Rows.Add(name);
			DataTable tdReason = CopyTable(dtReasonDistinct, "tdReason", "Reason > ''", "Reason");
			if (StartForm(new frmSelectID(this, tdReason, "Reason", "Назначение", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				txtReason.Text = _SelectedText;
			}
			_SelectedID = null;
			_SelectedText = "";

			return;
		}

		#endregion Reason

        #region Partners

        private void cboPartner_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboPartner.SelectedIndex >= 0 && cboPartner.SelectedValue != null)
			{
				txtPartnerName.Text = cboPartner.Text;
			}
		}

		private void cboCarrierPartner_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCarrierPartner.SelectedIndex >= 0 && cboCarrierPartner.SelectedValue != null)
			{
				txtCarrierPartnerName.Text = cboCarrierPartner.Text;
			}
        }

        #endregion Partners

        #region Dates

        private void chkArrivalFact_CheckedChanged(object sender, EventArgs e)
		{
			if (chkArrivalFact.Checked)
			{
				dtpArrivalFact.HideControl(true);
			}
			else
			{
				dtpArrivalFact.HideControl(false);
			}
		}

		private void chkDepartureFact_CheckedChanged(object sender, EventArgs e)
		{
			if (chkDepartureFact.Checked)
			{
				dtpDepartureFact.HideControl(true);
			}
			else
			{
				dtpDepartureFact.HideControl(false);
			}
		}

		private void chkArrivalPlan_CheckedChanged(object sender, EventArgs e)
		{
			if (chkArrivalPlan.Checked)
			{
				dtpArrivalPlan.HideControl(true);
			}
			else
			{
				dtpArrivalPlan.HideControl(false);
			}
		}

		private void chkDeparturePlan_CheckedChanged(object sender, EventArgs e)
		{
			if (chkDeparturePlan.Checked)
			{
				dtpDeparturePlan.HideControl(true);
			}
			else
			{
				dtpDeparturePlan.HideControl(false);
			}
		}

		#endregion Dates

		private void btnCarSelect_Click(object sender, EventArgs e)
		{
			_SelectedID = null;
			_SelectedText = "";

			// ранее введеные значения 
			Pass oPassTemp = new Pass();
			oPass.FilterDateBeg = dtpDatePass.Value.Date.AddMonths(-12);
			oPassTemp.FillDataAsync();
			if (oPassTemp.ErrorNumber != 0 || oPassTemp.MainTable == null)
				return;
			if (oPassTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			DataTable tdCars = CopyTable(oPassTemp.MainTable, "tdCars", "", "CarName");
			if (StartForm(new frmSelectID(this, tdCars, "DatePass, CarName, CarNumber, DriverName, Reason", "Дата, Машина, Гос.номер, Водитель, Назначение", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				oPassTemp.ClearData();
				oPassTemp.ReFillOne((int)_SelectedID);
				txtCarNаme.Text = oPassTemp.CarName;
				txtCarTypeName.Text = oPassTemp.CarTypeName;
				txtCarNumber.Text = oPassTemp.CarNumber;
				txtTrailerNumber.Text = oPassTemp.TrailerNumber;
				txtDriverName.Text = oPassTemp.DriverName;
				txtDriverDocument.Text = oPassTemp.DriverDocument;
				txtDriverPhone.Text = oPassTemp.DriverPhone;
				txtReason.Text = oPassTemp.Reason;
			}
			_SelectedID = null;
			_SelectedText = "";
		}

	}
}
