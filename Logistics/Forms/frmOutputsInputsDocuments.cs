using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DataDynamics.ActiveReports;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics 
{
	public partial class frmOutputsInputsDocuments : RFMFormChild
	{
		// расходные документы (заказы на отгрузку клиентам) OutputsDocuments: сначала подтверждается отгрузка со склада Confirm, потом доставка клиенту Bring
		// приходные документы (заказы на поставку) InputsDocuments: сначала вводятся данные по документам поставщика Bring, потом подтверждается получение на складе Confirm

		private OutputDocument oOutputDocumentList; //список заказов на отгрузку 
		private OutputDocument oOutputDocumentCur; //текущий заказ на отгрузку 
		private InputDocument oInputDocumentList; //список заказов на поставку 
		private InputDocument oInputDocumentCur; //текущий заказ на поставку 

		private Host oHost;
		private int? nUserHostID = null;

		private decimal nVatVeterinaryPayment = 18;

		// для фильтров
		public string _SelectedIDList;
		public string _SelectedText;
		public int? _SelectedID = null;


		public frmOutputsInputsDocuments()
		{
			oOutputDocumentList = new OutputDocument();
			oOutputDocumentCur = new OutputDocument();
			if (oOutputDocumentList.ErrorNumber != 0 ||
				oOutputDocumentCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oInputDocumentList = new InputDocument();
			oInputDocumentCur = new InputDocument();
			if (oInputDocumentList.ErrorNumber != 0 ||
				oInputDocumentCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oHost = new Host();
			if (oHost.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmOutputsInputsDocuments_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;

			lblHosts.Visible = 
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled = 
				(oHost.Count() > 1 && !nUserHostID.HasValue);

			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}
			grcOutputsDocuments_DeliveryPrice.AgrType =
			grcOutputsDocuments_VeterinaryPrice.AgrType =
			grcInputsDocumentsGoods_PriceSum.AgrType = 
			grcOutputsDocumentsGoods_PriceSum.AgrType =
				EnumAgregate.Sum;

			grdOutputsDocuments.IsStatusShow =
			grdOutputsDocumentsGoods.IsStatusShow =
			grdInputsDocuments.IsStatusShow =
			grdInputsDocumentsGoods.IsStatusShow =
				true;

			tcList.Init();
			tcOutputsDocumentsGoods.Init();
			tcInputsDocumentsGoods.Init();

			btnClearTerms_Click(null, null);
			dtrDates.dtpBegDate.Select();

            /*
            mniOutputsDocumentsPrintFactures.Visible =
            mniOutputsDocumentsPrintFactures.Enabled =
            mniOutputsDocumentsPrintFacturePerversion.Visible =
            mniOutputsDocumentsPrintBillPerversion.Visible =
                ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserIsAdmin;
            */
            mniOutputsDocumentsPrintFacturePerversion.Visible =
            mniOutputsDocumentsPrintBillPerversion.Visible =
                ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserIsAdmin;

			RFMCursorWait.Set(false);
		}

	#region Tab Restore

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnConfirm.Enabled =
			btnBring.Enabled =
			btnPrint.Enabled = 
			btnService.Enabled = 
				false;
			
			dtrDates.dtpBegDate.Select();
			
			return (true);
		}

		private bool tabOutputsDocuments_Restore()
		{
			grdOutputsDocuments_Restore();
			btnAdd.Enabled =
			btnEdit.Enabled = 
				false;
			if (grdOutputsDocuments.Rows.Count > 0)
			{
				btnConfirm.Enabled =
				btnBring.Enabled =
				btnDelete.Enabled = 
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				ttToolTip.SetToolTip(btnAdd, "");
				ttToolTip.SetToolTip(btnEdit, "");
				ttToolTip.SetToolTip(btnConfirm, "Отметить отгрузку со склада");
				ttToolTip.SetToolTip(btnBring, "Отметить доставку получателю");

				grdOutputsDocuments.Select();
			}
			else
			{
				btnConfirm.Enabled =
				btnBring.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			
			return (true);
		}

		private bool tabOutputsDocumentsGoods_Restore()
		{
			return (grdOutputsDocumentsGoods_Restore());
		}

		private bool tabInputsDocuments_Restore()
		{
			grdInputsDocuments_Restore();
			btnAdd.Enabled =
			btnBring.Enabled =
				false;
			if (grdInputsDocuments.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnConfirm.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				ttToolTip.SetToolTip(btnAdd, "");
				ttToolTip.SetToolTip(btnEdit, "Ввести данные по документам поставщика");
				ttToolTip.SetToolTip(btnBring, "");
				ttToolTip.SetToolTip(btnConfirm, "Подтвердить документ");

				grdInputsDocuments.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnConfirm.Enabled =
				btnBring.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}

			return (true);
		}

		private bool tabInputsDocumentsGoods_Restore()
		{
			return (grdInputsDocumentsGoods_Restore());
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled =
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnConfirm.Enabled =
				btnBring.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("OutputsDocuments".ToUpper()))
			{
				btnAdd.Enabled = 
				btnEdit.Enabled =
					false;
				btnDelete.Enabled =
				btnConfirm.Enabled =
				btnBring.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					(grdOutputsDocuments.Rows.Count > 0);
				btnService.ShortCutSet(mnuOutputsDocumentsService);
				btnPrint.ShortCutSet(mnuOutputsDocumentsPrint);
				grdOutputsDocuments.Select();
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("InputsDocuments".ToUpper()))
			{
				btnAdd.Enabled =
				btnBring.Enabled =
					false; 
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnConfirm.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					(grdInputsDocuments.Rows.Count > 0);
				btnService.ShortCutSet(mnuInputsDocumentsService);
				btnPrint.ShortCutSet(mnuInputsDocumentsPrint);
				grdInputsDocuments.Select();
			}
		}

	#endregion Tab Resore

	#region PrepareIDList

		public void OutputsDocumentsPrepareIDList(OutputDocument oOutputDocument, bool bMultiSelect)
		{
			oOutputDocument.ID = null;
			oOutputDocument.IDList = null;
			int? nOutputDocumentID = 0;
			if (bMultiSelect && grdOutputsDocuments.IsCheckerShow)
			{
				oOutputDocument.IDList = "";

				DataView dMarked = new DataView(oOutputDocumentList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdOutputsDocuments.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nOutputDocumentID = (int)r["ID"];
						oOutputDocument.IDList = oOutputDocument.IDList + nOutputDocumentID.ToString() + ",";
					}
				}
			}
			else
			{
				nOutputDocumentID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;
				if (nOutputDocumentID.HasValue)
				{
					oOutputDocument.ID = nOutputDocumentID;
				}
			}
		}

	#endregion PrepareIDList

	#region RowEnter, CellFormatting

		private void grdOutputsDocuments_CurrentRowChanged(object sender)
		{
			if (grdOutputsDocuments.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdInputsDocuments_CurrentRowChanged(object sender)
		{
			if (grdInputsDocuments.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;
			
			RFMDataGridView grd;
			bool bIsOutputsDocuments = false;

			if (tcList.CurrentPage.Name.ToUpper().Contains("OutputsDocuments".ToUpper()))
			{
				grd = grdOutputsDocuments;
				bIsOutputsDocuments = true;
			}
			else
			{
				grd = grdInputsDocuments;
			}

			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;

			btnPrint.Enabled =
			btnService.Enabled =
				true;

			if (bIsOutputsDocuments)
			{
				// заказы на отгрузку 
				btnEdit.Enabled = false; 
				if (grd.IsStatusRow(rowIndex))
				{
					oOutputDocumentCur.ClearOne();
					btnConfirm.Enabled =
					btnBring.Enabled =
					btnDelete.Enabled =
						false;
				}
				else
				{
					// заполнение объекта по текущей строке 
					DataRow r = ((DataRowView)((DataGridViewRow)grdOutputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
					oOutputDocumentCur.FillOne(r);
					btnConfirm.Enabled = !oOutputDocumentCur.IsConfirmed;
					btnBring.Enabled = oOutputDocumentCur.IsConfirmed && !oOutputDocumentCur.IsBrought;
					btnDelete.Enabled = !oOutputDocumentCur.IsConfirmed;

					mniOutputsDocumentsPrintBills.Enabled =   
					mniOutputsDocumentsPrintBillAll.Enabled =  
					mniOutputsDocumentsPrintBillOne.Enabled =
					mniOutputsDocumentsPrintFactures.Enabled =
					mniOutputsDocumentsPrintFactureAll.Enabled =
					mniOutputsDocumentsPrintFactureOne.Enabled =
					mniOutputsDocumentsPrintInnerMovingBill.Enabled =
					mniOutputsDocumentsPrintBillAdd.Enabled =  
						oOutputDocumentCur.IsConfirmed;

					mniOutputsDocumentPrintPayBill.Enabled = true;
					mniOutputsDocumentsPrintTTN.Enabled = true;

					mniOutputsDocumentsPrintWarrant.Enabled = true; // oOutputDocumentCur.PF_WarrantNeed 

					mniOutputsDocumentsPrintQuality.Enabled =
					mniOutputsDocumentsPrintVeterinary.Enabled =
					mniOutputsDocumentsPrintVeterinaryBlankData.Enabled =
						true;

					mniOutputsDocumentsPrintTransport.Enabled = ((decimal)r["DeliveryPrice"] > 0);
					mniOutputsDocumentsPrintVeterinaryPayment.Enabled = ((decimal)r["VeterinaryPrice"] > 0);

					mniOutputsDocumentsPrintMX3.Enabled = true;
					mniOutputsDocumentsPrintMX1.Enabled = true; 

					mniOutputsDocumentsPrintDeliveryPrices.Enabled = true;
					
					//mniOutputsDocumentsServiceUnConfirm.Enabled = oOutputDocumentCur.IsConfirmed; // !WMS
					mniOutputsDocumentsServiceUnConfirm.Enabled = false;

					mniOutputsDocumentsServiceUnBring.Enabled = oOutputDocumentCur.IsBrought;
					mniOutputsDocumentsServiceBringZero.Enabled = oOutputDocumentCur.IsConfirmed && !oOutputDocumentCur.IsBrought && !oOutputDocumentCur.TripExists;
					mniOutputsDocumentsServiceConfirmZero.Enabled = !oOutputDocumentCur.IsConfirmed && !oOutputDocumentCur.IsBrought && !oOutputDocumentCur.TripExists;
					
					mniOutputsDocumentsServiceFailReasonChange.Enabled = oOutputDocumentCur.IsBrought && oOutputDocumentCur.OutputDocumentFailReasonID.HasValue;
					mniOutputsDocumentsServiceGoodReturnReasonChange.Enabled = oOutputDocumentCur.IsBrought;
					mniOutputsDocumentsServiceGuiltyEmployees.Enabled = oOutputDocumentCur.IsConfirmed;// && oOutputDocumentCur.IsBrought;
					
					mniOutputsDocumentsServiceVeterinaryLicenceNeedSet.Enabled = !oOutputDocumentCur.VeterinaryLicenceNeed;
					mniOutputsDocumentsServiceVeterinaryLicenceNeedClear.Enabled = oOutputDocumentCur.VeterinaryLicenceNeed;
					
					mniOutputsDocumentsServiceAdditionalSet.Enabled =
					mniOutputsDocumentsServiceAdditionalClear.Enabled = 
						((RFMFormMain)Application.OpenForms[0]).UserInfo.UserIsAdmin;
					mniOutputsDocumentsServiceVeterinaryClear.Enabled = true;
				}
				tcOutputsDocumentsGoods.SetAllNeedRestore(true);
			}
			else
			{
				// заказы на поставку 
				btnBring.Enabled = false;
				if (grd.IsStatusRow(rowIndex))
				{
					oInputDocumentCur.ClearOne();
					btnEdit.Enabled =
					btnConfirm.Enabled =
					btnDelete.Enabled =
						false;
				}
				else
				{
					// заполнение объекта по текущей строке 
					DataRow r = ((DataRowView)((DataGridViewRow)grdInputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
					oInputDocumentCur.FillOne(r);
					btnEdit.Enabled = !oInputDocumentCur.IsConfirmed;
					btnConfirm.Enabled = !oInputDocumentCur.IsConfirmed;
					btnDelete.Enabled = !oInputDocumentCur.IsConfirmed;

					mniInputsDocumentsPrintBill.Enabled =
					mniInputsDocumentsPrintReverseBill.Enabled =
					mniInputsDocumentsPrintReverseFacture.Enabled =
						true;

					mniInputsDocumentsPrintWarrant.Enabled = true; // oInputDocumentCur.PF_WarrantNeed;

					mniInputsDocumentsServiceQualityData.Enabled =
					mniInputsDocumentsServiceVeterinaryData.Enabled =
					mniInputsDocumentsServiceCustomsNumbersSave.Enabled =
						true; 
 				}
				tcInputsDocumentsGoods.SetAllNeedRestore(true);
			}
		}

		private void grdOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
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

			// подтверждение отгрузки и доставки клиенту
			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{ 
				if ((bool)r["IsConfirmed"])
				{
					if (sGridName.Contains("OUTPUTS"))
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
						e.Value = Properties.Resources.Check;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("IsBroughtImage".ToUpper()))
			{
				if (sGridName.Contains("OUTPUTS"))
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
			if (sGridName.Contains("OutputsDocuments".ToUpper()))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOutputDocumentID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if (sGridName.Contains("InputsDocuments".ToUpper()))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputDocumentID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			// копирование
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}

			if (sColumnName.Contains("DateOutput".ToUpper()))
			{
				int nDaysDiff = (int)r["DaysDiff"];
				if (nDaysDiff <= 0)
					e.CellStyle.BackColor = e.CellStyle.BackColor;
				else
				{
					if (nDaysDiff > 10)
						e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, 0, 0);
					else
						e.CellStyle.BackColor = System.Drawing.Color.FromArgb(255, (10 - nDaysDiff) * 25, (10 - nDaysDiff) * 25);
				}
			}
		}

		private void grdOutputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
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

	#endregion 

	#region Restore

		private bool grdOutputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputDocumentCur.ClearOne();

			oOutputDocumentList.ClearError();
			oOutputDocumentList.ClearFilters();
			oOutputDocumentList.ID = null;
			oOutputDocumentList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oOutputDocumentList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oOutputDocumentList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oOutputDocumentList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oOutputDocumentList.FilterDeliveryNeed = false;
			}

			// клиенты-поставщики
			if (txtPartnerSourceNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerSource = new Partner();
				oPartnerSource.FilterNameContext = txtPartnerSourceNameContext.Text.Trim();
				oPartnerSource.FillDataAsync();
				oOutputDocumentList.FilterPartnersSourceList = "";
				foreach (DataRow rcs in oPartnerSource.MainTable.Rows)
					oOutputDocumentList.FilterPartnersSourceList += rcs["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersSource.IsSelectedExist)
			{
				oOutputDocumentList.FilterPartnersSourceList += ucSelectRecordID_PartnersSource.GetIdString();
			}

			// клиенты-получатели 
			if (txtPartnerTargetNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerTarget = new Partner();
				oPartnerTarget.FilterNameContext = txtPartnerTargetNameContext.Text.Trim();
				oPartnerTarget.FillDataAsync();
				oOutputDocumentList.FilterPartnersTargetList = "";
				foreach (DataRow rct in oPartnerTarget.MainTable.Rows)
					oOutputDocumentList.FilterPartnersTargetList += rct["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersTarget.IsSelectedExist)
			{
				oOutputDocumentList.FilterPartnersTargetList += ucSelectRecordID_PartnersTarget.GetIdString();
			}

			// рейс?
			if (optTripExists.Checked)
			{
				oOutputDocumentList.FilterTripExists = true;
			}
			if (optTripExistsNot.Checked)
			{
				oOutputDocumentList.FilterTripExists = false;
			}

			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oOutputDocumentList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oOutputDocumentList.FilterPackingsList = ucSelectRecordIDForm_Packings.GetIdString();
			}

			// подтверждение отгрузки
			if (optOutputsDocumentsIsConfirmedNot.Checked)
			{
				oOutputDocumentList.FilterIsConfirmed = false;
			}
			if (optOutputsDocumentsIsConfirmed.Checked)
			{
				oOutputDocumentList.FilterIsConfirmed = true;
			}

			// подтверждение доставки 
			if (optOutputsDocumentsIsBroughtNot.Checked)
			{
				oOutputDocumentList.FilterIsBrought = false;
			}
			if (optOutputsDocumentsIsBroughtYes.Checked)
			{
				oOutputDocumentList.FilterIsBrought = true;
			}

            // признак полной доставки
            if (optOutputsDocumentsIsBroughtFullNot.Checked)
            {
                oOutputDocumentList.FilterIsBroughtFull = false;
            }
            if (optOutputsDocumentsIsBroughtFullYes.Checked)
            {
                oOutputDocumentList.FilterIsBroughtFull = true;
            }

			// контекст № накладной
			if (txtBillNumberContext.Text.Trim().Length > 0)
			{
				oOutputDocumentList.FilterBillNumberContext = txtBillNumberContext.Text.Trim().ToUpper();
			}
			// контекст названия отдела
			if (txtDepartmentNameContext.Text.Trim().Length > 0)
			{
				oOutputDocumentList.FilterDepartmentNameContext = txtDepartmentNameContext.Text.Trim().ToUpper();
			}

			// по рейсу
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0)
			{
				Trip oTripFilter = new Trip();
				if (txtTripAliasContext.Text.Trim().Length > 0)
				{
					oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				}
				oTripFilter.FillDataAsync();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ",";
				}
				oOutputDocumentList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oOutputDocumentList.FilterTripsList == null)
					oOutputDocumentList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oOutputDocumentList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			if (nUserHostID.HasValue)
			{
				oOutputDocumentList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oOutputDocumentList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdOutputsDocumentsGoods.DataSource = null;

			grdOutputsDocuments.GetGridState();

			oOutputDocumentList.FillDataAsync();
			grdOutputsDocuments.IsLockRowChanged = true;

			// ERP-код
			if (txtERPCodeContext.Text.Trim().Length > 0)
			{
				// доп.выборка - оставить только подходящие записи
				DataTable dtTemp = CopyTable(oOutputDocumentList.MainTable, "dtTemp", "ERPCode like '*" + txtERPCodeContext.Text.Trim().ToUpper() + "*'", "");
				oOutputDocumentList.MainTable.Clear();
				oOutputDocumentList.MainTable.Merge(dtTemp);
			}

			grdOutputsDocuments.Restore(oOutputDocumentList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oOutputDocumentList.ErrorNumber == 0);
		}

		private bool grdOutputsDocumentsGoods_Restore()
		{
			grdOutputsDocumentsGoods.GetGridState();
			grdOutputsDocumentsGoods.DataSource = null;
			if (grdOutputsDocuments.Rows.Count == 0 || oOutputDocumentCur.ID == null)
				return (true);

			oOutputDocumentList.FillTableOutputsDocumentsGoods((int)oOutputDocumentCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{ 
				DataTable dt = CopyTable(oOutputDocumentList.TableOutputsDocumentsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")", 
					"ByOrder, GoodGroupName, GoodAlias, ID");
				oOutputDocumentList.TableOutputsDocumentsGoods.Clear();
				oOutputDocumentList.TableOutputsDocumentsGoods.Merge(dt);
			}

			grdOutputsDocumentsGoods.Restore(oOutputDocumentList.TableOutputsDocumentsGoods);
			return (oOutputDocumentList.ErrorNumber == 0);
		}

		private bool grdInputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputDocumentCur.ClearOne();

			oInputDocumentList.ClearError();
			oInputDocumentList.ClearFilters();
			oInputDocumentList.ID = null;
			oInputDocumentList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oInputDocumentList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oInputDocumentList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oInputDocumentList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oInputDocumentList.FilterDeliveryNeed = false;
			}

			// клиенты-поставщики
			if (txtPartnerSourceNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerSource = new Partner();
				oPartnerSource.FilterNameContext = txtPartnerSourceNameContext.Text.Trim();
				oPartnerSource.FillDataAsync();
				oInputDocumentList.FilterPartnersSourceList = "";
				foreach (DataRow rcs in oPartnerSource.MainTable.Rows)
					oInputDocumentList.FilterPartnersSourceList += rcs["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersSource.IsSelectedExist)
			{
				oInputDocumentList.FilterPartnersSourceList += ucSelectRecordID_PartnersSource.GetIdString();
			}

			// клиенты-получатели 
			if (txtPartnerTargetNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerTarget = new Partner();
				oPartnerTarget.FilterNameContext = txtPartnerTargetNameContext.Text.Trim();
				oPartnerTarget.FillDataAsync();
				oInputDocumentList.FilterPartnersTargetList = "";
				foreach (DataRow rct in oPartnerTarget.MainTable.Rows)
					oInputDocumentList.FilterPartnersTargetList += rct["ID"].ToString() + ",";
			}
			if (ucSelectRecordID_PartnersTarget.IsSelectedExist)
			{
				oInputDocumentList.FilterPartnersTargetList += ucSelectRecordID_PartnersTarget.GetIdString();
			}

			// рейс?
			if (optTripExists.Checked)
			{
				oInputDocumentList.FilterTripExists = true;
			}
			if (optTripExistsNot.Checked)
			{
				oInputDocumentList.FilterTripExists = false;
			}

			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oInputDocumentList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oInputDocumentList.FilterPackingsList = ucSelectRecordIDForm_Packings.GetIdString();
			}

			// подтверждение 
			if (optInputsDocumentsIsConfirmedNot.Checked)
			{
				oInputDocumentList.FilterIsConfirmed = false;
			}
			if (optInputsDocumentsIsConfirmed.Checked)
			{
				oInputDocumentList.FilterIsConfirmed = true;
			}

			// контекст № накладной
			if (txtBillNumberContext.Text.Trim().Length > 0)
			{
				oInputDocumentList.FilterBillNumberContext = txtBillNumberContext.Text.Trim().ToUpper();
			}


			// по рейсу
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0)
			{
				Trip oTripFilter = new Trip();
				if (txtTripAliasContext.Text.Trim().Length > 0)
				{
					oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				}
				oTripFilter.FillDataAsync();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ",";
				}
				oInputDocumentList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oInputDocumentList.FilterTripsList == null)
					oInputDocumentList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oInputDocumentList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			if (nUserHostID.HasValue)
			{
				oInputDocumentList.FilterHostsList = nUserHostID.ToString() ;
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oInputDocumentList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdInputsDocumentsGoods.DataSource = null;

			grdInputsDocuments.GetGridState();

			oInputDocumentList.FillDataAsync();
			grdInputsDocuments.IsLockRowChanged = true;

			// ERP-код
			if (txtERPCodeContext.Text.Trim().Length > 0)
			{
				DataTable dtTemp = CopyTable(oInputDocumentList.MainTable, "dtTemp", "ERPCode like '*" + txtERPCodeContext.Text.Trim().ToUpper() + "*'", "");
				oInputDocumentList.MainTable.Clear();
				oInputDocumentList.MainTable.Merge(dtTemp);
			}

			grdInputsDocuments.Restore(oInputDocumentList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oInputDocumentList.ErrorNumber == 0);
		}

		private bool grdInputsDocumentsGoods_Restore()
		{
			grdInputsDocumentsGoods.GetGridState();
			grdInputsDocumentsGoods.DataSource = null;
			if (grdInputsDocuments.Rows.Count == 0 || oInputDocumentCur.ID == null)
				return (true);

			oInputDocumentList.FillTableInputsDocumentsGoods((int)oInputDocumentCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oInputDocumentList.TableInputsDocumentsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"ByOrder, GoodGroupName, GoodAlias, ID");
				oInputDocumentList.TableInputsDocumentsGoods.Clear();
				oInputDocumentList.TableInputsDocumentsGoods.Merge(dt);
			}

			grdInputsDocumentsGoods.Restore(oInputDocumentList.TableInputsDocumentsGoods);
			return (oInputDocumentList.ErrorNumber == 0);
		}

	#endregion 
		
	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":
					/*
					if (false)// (StartForm(new frmOutputsDocumentsEdit(null)) == DialogResult.Yes)
					{
						int nOutputDocumentID = (int)GotParam.GetValue(0);
						grdOutputsDocuments_Restore();
						if (nOutputDocumentID > 0)
						{
							grdOutputsDocuments.GridSource.Position = grdOutputsDocuments.GridSource.Find(oOutputDocumentList.ColumnID, nOutputDocumentID);
						}
					}
					*/
					break;

				case "tabInputsDocuments":
					if (grdInputsDocuments.CurrentRow == null)
						return;
					if (!oInputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

					bool bAsked = false;

					// проверки
					if (oInputDocumentCur.IsConfirmed)
					{
						if (RFMMessage.MessageBoxYesNo("Для приходного документа уже зарегистрировано получение на складе...\n" + 
							"Все-таки создать новый приходный документ на основе текущего?") != DialogResult.Yes)
							return;
						bAsked = true;
					}

					if (!bAsked &&
						RFMMessage.MessageBoxYesNo("Создать новый приходный документ на основе текущего?") != DialogResult.Yes)
						return;

					bool bCopyGoods = false;
					if (RFMMessage.MessageBoxYesNo("Скопировать товары из текущего приходного документа в новый документ?") == DialogResult.Yes)
					{
						bCopyGoods = true;
					}

					WaitOn(this);
					int nNewInputDocumentID = 0;
					if (oInputDocumentCur.Copy(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID, ref nNewInputDocumentID, bCopyGoods))
					{
						grdInputsDocuments_Restore();
						if (nNewInputDocumentID > 0)
						{
							grdInputsDocuments.GridSource.Position = grdInputsDocuments.GridSource.Find(oInputDocumentList.ColumnID, nNewInputDocumentID);
						}
					}
					WaitOff(this);
					break;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":

					if (grdOutputsDocuments.CurrentRow == null)
						return;

					if (!oOutputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

					// проверки
					if (oOutputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxAttention("Для расходного документа уже зарегистрирована отгрузка со склада...");
						//return;
					}

					/*
					if (false) //(StartForm(new frmOutputsDocumentsEdit((int)oOutputDocumentCur.ID)) == DialogResult.Yes)
					{
						//grdOutputsDocuments_Restore();
					}
					*/

					break;

				case "tabInputsDocuments":

					if (grdInputsDocuments.CurrentRow == null)
						return;

					if (!oInputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

					// проверки
					if (oInputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxAttention("Для приходного документа уже зарегистрировано получение на складе...");
						return;
					}

					if (StartForm(new frmInputsDocumentsEdit((int)oInputDocumentCur.ID)) == DialogResult.Yes)
					{
						grdInputsDocuments_Restore();
					}

					break;
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":

					if (grdOutputsDocuments.CurrentRow == null)
						return;

					if (!oOutputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

					// проверки
					if (oOutputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована отгрузка со склада...");
						return;
					}

					RFMMessage.MessageBoxAttention("Отметка отгрузки со склада для расходного документа регистрируется автоматически,\n" +
						"при подтверждении отгрузки со склада для соответствующего складского задания на расход!\n\n" +
						"Здесь режим находится только для отладки!");

					if (RFMMessage.MessageBoxYesNo("Отметить отгрузку со склада для расходного документа?") == DialogResult.Yes)
					{
						Refresh();
						oOutputDocumentCur.ClearError();

						WaitOn(this);
						if (oOutputDocumentCur.FillTableOutputsDocumentsGoods() && oOutputDocumentCur.TableOutputsDocumentsGoods != null && oOutputDocumentCur.ErrorNumber == 0)
						{
							// для отладки - заполним QntConfirmed = QntWished
							foreach (DataRow r in oOutputDocumentCur.TableOutputsDocumentsGoods.Rows)
							{
								r["QntConfirmed"] = r["QntWished"];
							}
							// 
							if (oOutputDocumentCur.Confirm(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID) && 
									oOutputDocumentCur.ErrorNumber == 0)
							{
								WaitOff(this);
								//RFMMessage.MessageBoxInfo("Отгрузка со склада для расходного документа зарегистрирована.");
								grdOutputsDocuments_Restore();
							}
							else
							{
								WaitOff(this);
								RFMMessage.MessageBoxError("Ошибка при отметке отгрузки со склада для расходного документа...");
							}
						}
						else
						{
							WaitOff(this);
							RFMMessage.MessageBoxError("Ошибка при получении списка товаров в расходном документе...");
						}
					}

					break;

				case "tabInputsDocuments":

					if (grdInputsDocuments.CurrentRow == null)
						return;

					if (!oInputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

					// проверки
					if (oInputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Приходный документ уже подтвержден...");
						return;
					}
					if (!oInputDocumentCur.DateBring.HasValue)
					{
						RFMMessage.MessageBoxError("Данные по документам поставщика еще не введены...");
						return;
					}

					if (RFMMessage.MessageBoxYesNo("Подтвердить приходный документ\n" +
							"(после этого изменение данных по документам поставщика будет невозможно)?") == DialogResult.Yes)
					{
						Refresh();
						oInputDocumentCur.ClearError();

						WaitOn(this);
						if (oInputDocumentCur.FillTableInputsDocumentsGoods() && oInputDocumentCur.TableInputsDocumentsGoods != null && oInputDocumentCur.ErrorNumber == 0)
						{
							if (oInputDocumentCur.Confirm(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID) &&
									oInputDocumentCur.ErrorNumber == 0)
							{
								WaitOff(this);
								//RFMMessage.MessageBoxInfo("Приходный документ подтвержден.");
								grdInputsDocuments_Restore();
							}
							else
							{
								WaitOff(this);
								RFMMessage.MessageBoxError("Ошибка при подтверждении приходного документа...");
							}
						}
						else
						{
							WaitOff(this);
							RFMMessage.MessageBoxError("Ошибка при получении списка товаров в приходном документе...");
						}
					}

					break;
			}
		}

		private void btnBring_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":

					if (grdOutputsDocuments.CurrentRow == null)
						return;

					if (!oOutputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

					// проверки
					if (!oOutputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Для расходного документа еще не зарегистрирована отгрузка со склада...");
						return;
					}
					if (oOutputDocumentCur.IsBrought)
					{
						RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована доставка получателю...");
						return;
					}

					if (RFMMessage.MessageBoxYesNo("Подтвердить факт доставки получателю для расходного документа?") == DialogResult.Yes)
					{
						if (StartForm(new frmOutputsDocumentsBring((int)oOutputDocumentCur.ID)) == DialogResult.Yes)
						{
							grdOutputsDocuments_Restore();
						}
					}

					break;

				case "tabInputsDocuments":
					break;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":

					if (grdOutputsDocuments.CurrentRow == null)
						return;

					if (!oOutputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

					// проверки
					if (oOutputDocumentCur.ERPCode != null)
					{
						RFMMessage.MessageBoxError("Расходный документ получен из host-системы...\n" +
							"Удаление невозможно.");
						return;
					}
					if (oOutputDocumentCur.IsBrought)
					{
						RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована доставка товара получателю..." +
							"Удаление невозможно.");
						return;
					}
					if (oOutputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована отгрузка со склада...\n" + 
							"Удаление невозможно.");
						return;
					}
					if (oOutputDocumentCur.IsOutputExists)
					{
						RFMMessage.MessageBoxError("Для расходного документа существует складкое задание на расход...\n" + 
							"Удаление невозможно.");
						return;
					}
					if (oOutputDocumentCur.TripExists)
					{
						RFMMessage.MessageBoxError("Расходный документ уже привязан к рейсу...\n" +
							"Удаление невозможно.");
						return;
					}

					if (RFMMessage.MessageBoxYesNo("Удалить расходный документ?") == DialogResult.Yes)
					{
						Refresh();
						WaitOn(this);
						bool bResult = (false); // oOutputDocumentCur.DeleteOne((int)oOutputDocumentCur.ID);
						WaitOff(this);
						if (bResult && oOutputDocumentCur.ErrorNumber == 0)
						{
							//RFMMessage.MessageBoxInfo("Расходный документ удален.");
							grdOutputsDocuments_Restore();
						}
						else
						{
							RFMMessage.MessageBoxError("Ошибка при удалении расходного документа...");
						}
					}

					break;

				case "tabInputsDocuments":

					if (grdInputsDocuments.CurrentRow == null)
						return;

					if (!oInputDocumentCur.ID.HasValue)
						return;

					// перечитать
					oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

					// проверки
					if (oInputDocumentCur.ERPCode != null)
					{
						RFMMessage.MessageBoxError("Приходный документ получен из host-системы...\n" +
							"Удаление невозможно.");
						return;
					}
					if (oInputDocumentCur.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Приходный документ уже подтвержден...\n" + 
							"Удаление невозможно.");
						return;
					}
					if (oInputDocumentCur.IsInputExists)
					{
						RFMMessage.MessageBoxError("Для приходного документа существует складское задание на приход...\n" + 
							"Удаление невозможно.");
						return;
					}
					if (oInputDocumentCur.TripExists)
					{
						RFMMessage.MessageBoxError("Приходный документ уже привязан к рейсу...\n" +
							"Удаление невозможно.");
						return;
					}

					if (RFMMessage.MessageBoxYesNo("Удалить приходный документ?") == DialogResult.Yes)
					{
						Refresh();
						WaitOn(this);
						bool bResult = oInputDocumentCur.Delete((int)oInputDocumentCur.ID);
						WaitOff(this);
						if (bResult && oInputDocumentCur.ErrorNumber == 0)
						{
							//RFMMessage.MessageBoxInfo("Приходный документ удален.");
							grdInputsDocuments_Restore();
						}
						else
						{
							RFMMessage.MessageBoxError("Ошибка при удалении приходного документа...");
						}
					}

					break;
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Dispose();
		}

	#endregion
		
	#region MenuStrip

		#region outputsdocuments

		#region outputsdocuments print

		private void mniOutputsDocumentsPrintBillOne_Click(object sender, EventArgs e)
		{
			OutputDocumentBill(false, "bill");
		}

		private void mniOutputsDocumentsPrintBillAll_Click(object sender, EventArgs e)
		{
			OutputDocumentBill(true, "bill");
		}

		private void mniOutputsDocumentsPrintFactureOne_Click(object sender, EventArgs e)
		{
			OutputDocumentBill(false, "facture");
		}

		private void mniOutputsDocumentsPrintFactureAll_Click(object sender, EventArgs e)
		{
			OutputDocumentBill(true, "facture");
		}

		private void mniOutputsDocumentsPrintBillAdd_Click(object sender, EventArgs e)
		{
			OutputDocumentBillAdd();
		}

		private void mniOutputsDocumentsPrintQuality_Click(object sender, EventArgs e)
		{
			OutputDocumentQuality(false);
		}

		private void mniOutputsDocumentsPrintVeterinary_Click(object sender, EventArgs e)
		{
			OutputDocumentVeterinary(false);
		}

		private void mniOutputsDocumentsPrintWarrant_Click(object sender, EventArgs e)
		{
			OutputDocumentWarrant(false);
		}

		private void mniOutputsDocumentsPrintVeterinaryBlankData_Click(object sender, EventArgs e)
		{
			OutputDocumentVeterinaryBlankData();
		}

		private void mniOutputsDocumentsPrintTTN_Click(object sender, EventArgs e)
		{
			OutputDocumentTtn();
		}

		private void mniOutputsDocumentPrintPayBill_Click(object sender, EventArgs e)
		{
			OutputDocumentPayBill();
		}

		private void mniOutputsDocumentsPrintInnerMovingBill_Click(object sender, EventArgs e)
		{
			OutputDocumentInnerMovingBill();
		}

		private void mniOutputsDocumentsPrintDeliveryPrices_Click(object sender, EventArgs e)
		{
			StartForm(new frmOutputsDocumentsDeliveryPrices());
		}

		private void mniOutputsDocumentsPrintMX3_All_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null ||
				oOutputDocumentCur.ID == null)
				return;

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, true);
            LogService.OutputDocumentMX3_Print(oOutputDocumentPrint, false, this); 
		}

        private void mniOutputsDocumentsPrintMX3_AllByBillNumber_Click(object sender, EventArgs e)
        {
            if (grdOutputsDocuments.Rows.Count == 0 ||
                grdOutputsDocuments.CurrentRow == null ||
                oOutputDocumentCur.ID == null)
                return;

            OutputDocument oOutputDocumentPrint = new OutputDocument();
            OutputsDocumentsPrepareIDList(oOutputDocumentPrint, true);
            LogService.OutputDocumentMX3_Print(oOutputDocumentPrint, true, this);
        }

        private void mniOutputsDocumentsPrintMX3_One_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null ||
				oOutputDocumentCur.ID == null)
				return;

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = oOutputDocumentCur.ID;
			LogService.OutputDocumentMX3_Print(oOutputDocumentPrint, false, this); 
		}

		private void mniOutputsDocumentsPrintMX1_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null ||
				oOutputDocumentCur.ID == null)
				return;

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ReFillOne((int)oOutputDocumentCur.ID);

			// проверки...

			// таблица товаров 
			oOutputDocumentPrint.FillBillTableOutputsDocumentsGoods((int)oOutputDocumentPrint.ID);
			DataTable dt = oOutputDocumentPrint.TableOutputsDocumentsGoods;

			// добавляем поля шапки в таблицу товаров 
			oOutputDocumentPrint.DS.Relations.Add("r1", oOutputDocumentPrint.MainTable.Columns["OutputDocumentID"],
				dt.Columns["OutputDocumentID"]);
			dt.Columns.Add("InputID");
			dt.Columns["InputID"].Expression = "Parent([r1]).OutputDocumentID";
			dt.Columns.Add("DateInput");
			dt.Columns["DateInput"].Expression = "Parent([r1]).DateOutput";

			dt.Columns.Add("DateInputText");
			dt.Columns.Add("DateConfirmText");
			foreach (DataRow rr in dt.Rows)
			{
				rr["DateInputText"] = rr["DateInput"].ToString().Substring(0, 10);
				rr["DateConfirmText"] = (Convert.IsDBNull(rr["DateConfirm"])) ? "Не вып." : "Вып. " + rr["DateConfirm"].ToString().Substring(0, 16);
			}

			StartForm(new frmActiveReport(dt, new billMX1()));
		}

		private void mniOutputsDocumentsPrintTransport_Click(object sender, EventArgs e)
		{
			OutputDocumentTransport();
		}

		private void mniOutputsDocumentsPrintVeterinaryPayment_Click(object sender, EventArgs e)
		{
			OutputDocumentVeterinaryPayment(); 
		}

		#endregion outputsdocuments print

		#region outputsdocuments service

		private void mniOutputsDocumentsServiceUnConfirm_Click(object sender, EventArgs e)
		{
			OutputsDocumentsUnConfirm();
		}

		private void mniOutputsDocumentsServiceBringZero_Click(object sender, EventArgs e)
		{
			OutputsDocumentsBringZero();
		}

		private void mniOutputsDocumentsServiceConfirmZero_Click(object sender, EventArgs e)
		{
			OutputsDocumentsConfirmZero();
		}

		private void mniOutputsDocumentsServiceUnBring_Click(object sender, EventArgs e)
		{
			OutputsDocumentsUnBring();
		}

		private void mniOutputsDocumentsServiceAdditionalSet_Click(object sender, EventArgs e)
		{
			OutputsDocumentsAdditionalSet();
		}
		
		private void mniOutputsDocumentsServiceAdditionalClear_Click(object sender, EventArgs e)
		{
			OutputsDocumentsAdditionalClear();
		}

		private void mniOutputsDocumentsServiceVeterinaryClear_Click(object sender, EventArgs e)
		{
			OutputsDocumentsVeterinaryClear();
		}

		private void mniOutputsDocumentsServiceFailReasonChange_Click(object sender, EventArgs e)
		{
			// Visible = false;
			OutputsDocumentsFailReasonChange();
		}

		private void mniOutputsDocumentsServiceGoodReturnReasonChange_Click(object sender, EventArgs e)
		{
			// Visible = false;
			OutputsDocumentsGoodReturnReasonChange();
		}

		private void mniOutputsDocumentsServiceGuiltyEmployees_Click(object sender, EventArgs e)
		{
			OutputsDocumentsGuiltyEmployees();
		}

		private void mniOutputsDocumentsServiceVeterinaryLicenceNeedSet_Click(object sender, EventArgs e)
		{
			OutputsDocumentsVeterinaryLicenceNeed(true);
		}

		private void mniOutputsDocumentsServiceVeterinaryLicenceNeedClear_Click(object sender, EventArgs e)
		{
			OutputsDocumentsVeterinaryLicenceNeed(false);
		}

		private void mniOutputsDocumentsGoodsPriceEdit_Click(object sender, EventArgs e)
		{
			if (StartForm(new frmOutputsDocumentsGoodsPriceEdit((int)oOutputDocumentCur.ID)) == DialogResult.Yes)
			{
//				oOutputDocumentCur.ID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;
				grdOutputsDocumentsGoods_Restore();
			}

		}

		#endregion outputsdocuments service
		
		#endregion outputsdocuments

		#region inputsdocuments

		#region inputsdocuments print

		private void mniInputsDocumentsPrintBill_Click(object sender, EventArgs e)
		{
			InputDocumentBill();
		}

		private void mniInputsDocumentsPrintWarrant_Click(object sender, EventArgs e)
		{
			InputDocumentWarrant();
		}

		private void mniInputsDocumentsPrintMX1_Click(object sender, EventArgs e)
		{
			InputDocumentMX1();
		}

		private void mniInputsDocumentsPrintReverseBill_Click(object sender, EventArgs e)
		{
			InputDocumentReverseBill("bill");
		}

		private void mniInputsDocumentsPrintReverseFacture_Click(object sender, EventArgs e)
		{
			InputDocumentReverseBill("facture");
		}

		#endregion inputsdocuments print

		#region inputsdocuments service

		private void mniInputsDocumentsServiceQualityData_Click(object sender, EventArgs e)
		{
			InputsDocumentsQualityData();
		}

		private void mniInputsDocumentsServiceVeterinaryData_Click(object sender, EventArgs e)
		{
			InputsDocumentsVeterinaryData();
		}

		private void mniInputsDocumentsServiceCustomsNumbersSave_Click(object sender, EventArgs e)
		{
			InputsDocumentsCustomsNumbersSave();
		}

		#endregion inputsdocuments service

		#endregion inputsdocuments

	#endregion MenuStrip

	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
			btnPrint.ShortCutShow();
			/*
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":

					if (grdOutputsDocuments.CurrentRow == null)
						return;

					if (!oOutputDocumentCur.ID.HasValue)
						return;

					CreateShortCut(btnPrint, "OutputsDocumentsPrint");

					break;

				case "tabInputsDocuments":

					if (grdInputsDocuments.CurrentRow == null)
						return;

					if (!oInputDocumentCur.ID.HasValue)
						return;

					CreateShortCut(btnPrint, "InputsDocumentsPrint");

					break;
			}
			*/ 
		}
		
		#region OutputsDocumentsPrint

		private void OutputDocumentBill(bool bAll, string sMode)
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

            // ВРЕМЕННО!
            // ПЕЧАТЬ С ЗАПРОСОМ О ПЕРЕСЧЕТЕ НДС!
			LogService.OutputDocumentBill_Print(oOutputDocumentPrint, sMode.ToUpper(), this, false, (1 == 1));
		}

		private void OutputDocumentBillAdd()
		{
			if (grdOutputsDocuments.CurrentRow == null || 
				oOutputDocumentCur == null || !oOutputDocumentCur.ID.HasValue)
				return;

			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);
			if (!oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Товар по расходному документу еще не выдан...");
				return;
			}
			oOutputDocumentCur.FillBillTableOutputsDocumentsGoods();
			if (oOutputDocumentCur.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных по товарам в расходном документе...");
				return;
			}

			DataSet ds = new DataSet();
			ds.Tables.Add(oOutputDocumentCur.TableOutputsDocumentsGoods.Copy());
			ds.Tables.Add(oOutputDocumentCur.MainTable.Copy());

            StartForm(new frmActiveReport(ds, new billAdditionWithGoodsBarCodes()));
		}

		private void OutputDocumentVeterinary(bool bAll)
		{
			// список
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentVeterinary_Print(oOutputDocumentPrint, true, this);
		}

		private void OutputDocumentQuality(bool bAll)
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentQuality_Print(oOutputDocumentPrint, this);
		}

		private void OutputDocumentWarrant(bool bAll)
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentWarrant_Print(oOutputDocumentPrint, this, false);
		}

		private void OutputDocumentVeterinaryBlank(bool bAll, bool bGroupByPartner)
		{
			// бланки
			// печать на бланк без ввода данных. Не используется.
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentVeterinaryBlank_Print(oOutputDocumentPrint, bGroupByPartner, this);
		}

		private void OutputDocumentVeterinaryBlankData()
		{
			// бланки
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.VeterinaryLicenceNeed)
			{
				RFMMessage.MessageBoxError("Ветеринарные свидетельства не требуются...");
				return;
			}

			StartForm(new frmOutputsDocumentsVeterinaryBlankData(oOutputDocumentCur.ID.ToString()));
		}

		private void OutputDocumentTtn()
		{
			if (grdOutputsDocuments.Rows.Count == 0 || 
				grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;

			LogService.OutputDocumentTtn_Print(oOutputDocumentPrint, this);
		}

		private void OutputDocumentPayBill()
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;

			LogService.OutputDocumentBill_Print(oOutputDocumentPrint, "INVOICE", this, false, (0 == 1));
		}

		private void OutputDocumentInnerMovingBill()
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;

            LogService.OutputDocumentBill_Print(oOutputDocumentPrint, "InnerMovingBill", this, false, (0 == 1));
		}

		private void OutputDocumentTransport()
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;

			oOutputDocumentPrint.ReFillOne((int)oOutputDocumentPrint.ID);
			if (oOutputDocumentPrint.DeliveryPrice == 0)
			{
				RFMMessage.MessageBoxInfo("Не указана стоимость транспортных услуг...");
				return;
			}

			LogService.OutputDocumentTransportAct_Print(oOutputDocumentPrint, 18, this);

			if (oOutputDocumentPrint.PF_FactureNeed)
			{
				LogService.OutputDocumentTransportFacture_Print(oOutputDocumentPrint, 18, this);
			}
		}

		private void OutputDocumentVeterinaryPayment()
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)grdOutputsDocuments.CurrentRow.Cells["grcOutputsDocuments_ID"].Value;

			oOutputDocumentPrint.ReFillOne((int)oOutputDocumentPrint.ID);
			if (oOutputDocumentPrint.VeterinaryPrice == 0)
			{
				RFMMessage.MessageBoxInfo("Не указана стоимость оформления ветеринарных свидетельств...");
				return;
			}

			/*
			if (!oOutputDocumentPrint.PF_BillNeed && !oOutputDocumentPrint.PF_FactureNeed)
			{
				RFMMessage.MessageBoxInfo("Оформление документов (накладной и счета-фактуры) не требуется...");
				return;
			} 
			if (oOutputDocumentPrint.PF_BillNeed)
			{
				LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, "BILL", 18, this);
			}
			if (oOutputDocumentPrint.PF_FactureNeed)
			{
				LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, "FACTURE", 18, this);
			}
			*/ 
			LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, "BILL", nVatVeterinaryPayment, this);
			LogService.OutputDocumentVeterinaryPayment_Print(oOutputDocumentPrint, "FACTURE", nVatVeterinaryPayment, this);

		}

		private void mniOutputsDocumentsPrintFacturePerversion_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
				return;

			LogService.OutputDocumentBill_Print_Report(oOutputDocumentCur, new facturePerversion(), this);
		}

		private void mniOutputsDocumentsPrintBillPerversion_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 ||
				grdOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
				return;

			LogService.OutputDocumentBill_Print_Report(oOutputDocumentCur, new billPerversion(), this);
		}

		#endregion OutputsDocumentsPrint

		#region InputsDocumentsPrint

		#region InputDocumentBill

		private void InputDocumentBill()
		{
			if (grdInputsDocuments.CurrentRow == null ||
				grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index) )
				return;

			RFMCursorWait.Set(true);

			InputDocument oInputDocumentPrint = new InputDocument();
			oInputDocumentPrint.ID = (int)grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value;

			LogService.InputDocumentBill_Print(oInputDocumentPrint, this);
		}

		#endregion InputDocumentBill

		#region InputDocumentReverseBill

		private void InputDocumentReverseBill(string sMode)
		{
			if (grdInputsDocuments.CurrentRow == null ||
				grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index))
				return;

			InputDocument oInputDocumentPrint = new InputDocument();
			oInputDocumentPrint.ID = (int)grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value;

			LogService.InputDocumentReverseBill_Print(oInputDocumentPrint, sMode.ToUpper(), this);
		}

		#endregion InputDocumentReverseBill

		#region InputDocumentWarrant

		private void InputDocumentWarrant()
		{
			if (grdInputsDocuments.CurrentRow == null ||
				grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index))
				return;

			InputDocument oInputDocumentPrint = new InputDocument();
			oInputDocumentPrint.ID = (int)grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value;

			LogService.InputDocumentWarrant_Print(oInputDocumentPrint, this, false);
		}

		#endregion InputDocumentWarrant
		
		#region InputDocumentMX1

		private void InputDocumentMX1()
		{
			if (grdInputsDocuments.CurrentRow == null ||
				grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index) || 
				!oInputDocumentCur.ID.HasValue)
				return;

			InputDocument oInputDocumentPrint = new InputDocument();
			oInputDocumentPrint.ID = oInputDocumentCur.ID;

			LogService.InputDocumentMX1_Print(oInputDocumentPrint, this);
		}

		#endregion InputDocumentMX1

		#endregion InputsDocumentsPrint

		#endregion

		#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
			/*
			switch (tcList.CurrentPage.Name)
			{
				case "tabOutputsDocuments":

					if (grdOutputsDocuments.CurrentRow == null)
						return;

					if (!oOutputDocumentCur.ID.HasValue)
						return;

					CreateShortCut(btnService, "OutputsDocumentsService");

					break;

				case "tabInputsDocuments":

					if (grdInputsDocuments.CurrentRow == null)
						return;

					if (!oInputDocumentCur.ID.HasValue)
						return;

					CreateShortCut(btnService, "InputsDocumentsService");

					break;
			}
			*/ 
		}

		#region OutputsDocumentsService

		private void OutputsDocumentsUnConfirm()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			// проверки
			if (!oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Для расходного документа еще не зарегистрирована отгрузка со склада ...");
				return;
			}
			if (oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована доставка получателю...");
				return;
			}
			// 
			
			if (RFMMessage.MessageBoxYesNo("Снять отметку об отгрузке со склада для расходного документа?") == DialogResult.Yes)
			{
				Refresh();

				RFMMessage.MessageBoxAttention("Снятие отметки об отгрузке со склада для расходного документа выполняется автоматически,\n" +
					"при снятии подтверждения отгрузки со склада для соответствующего складского задания на расход!\n\n" +
					"Здесь режим находится только для отладки!");

				WaitOn(this);
				bool bResult = oOutputDocumentCur.UnConfirm((int)((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oOutputDocumentCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка об отгрузке со склада для расходного документа снята.");
					grdOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsBringZero()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			// проверки
			if (!oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Для расходного документа еще не зарегистрирована отгрузка со склада...");
				return;
			}
			if (oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована доставка получателю...");
				return;
			}
			if (oOutputDocumentCur.TripExists)
			{
				RFMMessage.MessageBoxError("Расходный документ привязан к рейсу.\n" + 
					"Обработка расходного документа выполняется в режиме \"Рейсы\"...");
				return;
			}

			// товар д.б. полностью не выдан со склада! - для этого режима
			oOutputDocumentCur.FillTableOutputsDocumentsGoods();
			if (oOutputDocumentCur.ErrorNumber != 0 || oOutputDocumentCur.TableOutputsDocumentsGoods == null)  
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о товарах в документе...");
				return;
			}
			foreach (DataRow odg in oOutputDocumentCur.TableOutputsDocumentsGoods.Rows)
			{ 
				if ((decimal)odg["QntConfirmed"] != 0)
				{
					RFMMessage.MessageBoxError("Товары, входящие в расходный документ, выданы со склада.\n\n" + 
						"В данном режиме регистрация полной недоставки товара выполняется только для расходных документов,\n" + 
						"по которым товар не выдан со склада...");
					return;
				}
			}
			// 

			if (RFMMessage.MessageBoxYesNo("Внимание!\n\n" +
				"При регистрации полной недоставки товара по документу количество доставленного товара равно нулю.\n\n" +
				"Все-таки зарегистрировать полную недоставку товара по документу?") == DialogResult.Yes)
			{
				oOutputDocumentCur.FillTableOutputsDocumentsFailsReasons();
				_SelectedID = null;
				if (StartForm(new frmSelectID(this, oOutputDocumentCur.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "Причина недоставки получателю, Виновник")) == DialogResult.Yes)
				{
					if (!_SelectedID.HasValue)
					{
						RFMMessage.MessageBoxError("Не указана причина недоставки товара получателю.");
						return;
					}
					
					int nOutputDocumentFailReasonID = (int)_SelectedID;

					oOutputDocumentCur.BringZero(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID, nOutputDocumentFailReasonID);
				}
				_SelectedID = null;

				grdOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsUnBring()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			// проверки
			if (!oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Для расходного документа еще не зарегистрирована доставка получателю...");
				return;
			}

			bool? bTripIsConfirmed = LogService.TripIsConfirmed(oOutputDocumentCur);
			if (bTripIsConfirmed.HasValue && (bool)bTripIsConfirmed)
			{
				RFMMessage.MessageBoxError("Рейс, к которому привязан расходный документ, уже подтвержден.");
				return;
			}
			// 

			if (RFMMessage.MessageBoxYesNo("Снять отметку о доставке получателю для расходного документа?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oOutputDocumentCur.UnBring((int)((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oOutputDocumentCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка о доставке получателю для расходного документа снята.");
					grdOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsConfirmZero()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			// проверки
			if (oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована доставка товара получателю...");
				return;
			}
			if (oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована отгрузка товара со склада...");
				return;
			}
			if (oOutputDocumentCur.TripExists)
			{
				RFMMessage.MessageBoxError("Расходный документ привязан к рейсу...");
				return;
			}
			if (!oOutputDocumentCur.IsOutputExists)
			{
				RFMMessage.MessageBoxError("Для расходного документа не создано задание на расход...");
				return;
			}

			// задание - не подтверждено, не послано в WMS
			Output oOutputCur = new Output();
			oOutputCur.ReFillOne((int)oOutputDocumentCur.OutputID);
			if (oOutputCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Задание на расход, в которое входит расходный документ, уже подтверждено на складе...");
				return;
			}
			if (oOutputCur.SentToWMS)
			{
				RFMMessage.MessageBoxError("Задание на расход, в которое входит расходный документ, уже передано на склад...");
				return;
			}
			if (oOutputCur.ReadyForWMS)
			{
				RFMMessage.MessageBoxError("Задание на расход, в которое входит расходный документ, уже готово для передачи на склад...");
				return;
			}
			if (oOutputCur.TripExists)
			{
				RFMMessage.MessageBoxError("Задание на расход, в которое входит расходный документ, привязано к рейсу...");
				return;
			}

			string sText = "";
			// другие заказы в задании
			OutputDocument oOutputDocumentOthers = new OutputDocument();
			oOutputDocumentOthers.FilterOutputsList = oOutputCur.ID.ToString();
			oOutputDocumentOthers.FillDataAsync();
			if (oOutputDocumentOthers.ErrorNumber != 0 ||
				oOutputDocumentOthers.MainTable == null || 
				oOutputDocumentOthers.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о расходных документах в складском задании...");
				return;
			}
			if (oOutputDocumentOthers.MainTable.Rows.Count == 1)
			{
				// в задание входит этот единственный заказ
				// мы подтвердим этот заказ и задание целиком 

				if (RFMMessage.MessageBoxYesNo("Зафиксировать отказ от обработки на складе и доставки получателю для текущего расходного документа и соответствующего ему складского задания?") != DialogResult.Yes)
					return;
			}
			else
			{
				// задание включает в себя еще несколько заказов
				// мы просто выковыряем этот заказ из задания, создадим для него новое задание
				// подтвердим этот заказ и созданное для него задание

				int nOthersCnt = 0;
				int nOthersSamePartnerCnt = 0;
				foreach (DataRow od in oOutputDocumentOthers.MainTable.Rows)
				{
					if ((int)od["ID"] != (int)oOutputDocumentCur.ID)
					{
						nOthersCnt++;
						if ((int)od["PartnerDetailBayerID"] == (int)oOutputDocumentCur.PartnerDetailBayerID)
							nOthersSamePartnerCnt++;
					}
				}
				sText = "Задание на расход, в которое входит расходный документ,\n" +
						"содержит еще ";
				if (nOthersCnt == nOthersSamePartnerCnt)
				{
					// все остальные заказы - того же партнера
					sText += RFMUtilities.Declen(nOthersCnt, "документ", "документа", "документов") + " для того же получателя.\n";
				}
				else
				{
					sText += RFMUtilities.Declen(nOthersCnt, "документ", "документа", "документов");
					if (nOthersSamePartnerCnt > 0)
					{
						sText += ",\n" +
							"в том числе " + RFMPublic.RFMUtilities.Declen(nOthersSamePartnerCnt, "документ", "документа", "документов") + " для того же получателя.\n";
					}
					else
					{
						sText += ".\n";
					}
				}
				sText += "Отказ от обработки на складе и доставки получателю будет зафиксирован только для текущего расходного документа и соответствующей ему части складского задания.\n" +
					"Остальные расходные документы и соответствующая им часть складского задания останутся неизменными.\n\n" + 
					"Все-таки продолжить?";
				if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
					return;
			}

			// другие расходы для того же получателя
			OutputDocument oOutputDocumentAlso = new OutputDocument();
			oOutputDocumentAlso.FilterDateBeg =
			oOutputDocumentAlso.FilterDateEnd =
				oOutputDocumentCur.DateOutput;
			oOutputDocumentAlso.FilterPartnersDetailsBayersList = oOutputDocumentCur.PartnerDetailBayerID.ToString();
			oOutputDocumentAlso.FilterIsConfirmed = false;
			oOutputDocumentAlso.FilterIsBrought = false;
			oOutputDocumentAlso.FillDataAsync();
			if (oOutputDocumentAlso.MainTable.Rows.Count > 0)
			{
				int nAlsoCnt = 0;
				foreach (DataRow oda in oOutputDocumentAlso.MainTable.Rows)
				{
					if ((int)oda["ID"] != (int)oOutputDocumentCur.ID)
					{
						if ((int)oda["OutputID"] != (int)oOutputDocumentCur.OutputID)
							nAlsoCnt++;
					}
				}
				if (nAlsoCnt > 0)
				{
					sText = "Существует еще " + RFMUtilities.Declen(nAlsoCnt, "расходный документ", "расходных документа", "расходных документов") + " " + 
						"для клиента на ту же дату, входящих в другие складские задания.\n\n" +
						"Все-таки продолжить?";
					if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						return;
				}
			}

			// другие приходы от того же получателя
			Input oInputAlso = new Input();
			oInputAlso.FilterDateBeg = 
			oInputAlso.FilterDateEnd = 
				oOutputDocumentCur.DateOutput;
			oInputAlso.FilterPartnersList = oOutputDocumentCur.PartnerTargetID.ToString();
			oInputAlso.FilterIsConfirmed = false;
			oInputAlso.FillDataAsync();
			if (oInputAlso.MainTable.Rows.Count > 0)
			{
				sText = "Существует еще " + RFMUtilities.Declen(oInputAlso.MainTable.Rows.Count, "задание", "задания", "заданий") + " на приход (возврат) " +
					"от того же клиента на ту же дату.\n\n" +
					"Все-таки продолжить?";
				if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
					return;
			}

			oOutputDocumentCur.FillTableOutputsDocumentsFailsReasons();
			_SelectedID = null;
			if (StartForm(new frmSelectID(this, oOutputDocumentCur.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "Причина недоставки получателю, Виновник")) == DialogResult.Yes)
			{
				if (!_SelectedID.HasValue)
				{
					RFMMessage.MessageBoxError("Не указана причина недоставки товара получателю.");
					return;
				}
				int nOutputDocumentFailReasonID = (int)_SelectedID;

				// примечание
				string sNoteExecute = "";
				if (StartForm(new frmInputBoxString("Примечание к выполнению:", "")) == DialogResult.Yes)
				{
					sNoteExecute = GotParam[0].ToString();
				}

				oOutputDocumentCur.ConfirmZero(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID, nOutputDocumentFailReasonID, sNoteExecute);
			}
			_SelectedID = null;

			grdOutputsDocuments_Restore();
		}
		
		private void OutputsDocumentsWarrantClear()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			// проверки
			if (oOutputDocumentCur.WarrantNumber == null || oOutputDocumentCur.WarrantNumber.Length == 0)
			{
				if (!oOutputDocumentCur.PF_WarrantNeed)
				{
					RFMMessage.MessageBoxError("Доверенность на получение денег не требуется...");
					return;
				}
				RFMMessage.MessageBoxError("Выдача доверенности на получение денег не зарегистрирована...");
				return;
			}
			if (oOutputDocumentCur.IsWarrantReturned)
			{
				RFMMessage.MessageBoxError("Зарегистрировано возвращение доверенности...");
				return;
			}
			// 

			if (RFMMessage.MessageBoxYesNo("Очистить номер доверенности на получение денег и запись в журнале доверенностей?") == DialogResult.Yes)
			{
				WaitOn(this);
				bool bResult = oOutputDocumentCur.WarrantClear((int)oOutputDocumentCur.ID);
				WaitOff(this);
				if (bResult && oOutputDocumentCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка выдачи доверенности на получение денег снята.");
					grdOutputsDocuments_Restore();
				}
			}
        }

        #region Additional - коды связанных записей (декларации соответствия, ветеринарные свидетельства, ...)

        private void OutputsDocumentsAdditionalSet()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			bool bAsked = false;

			// проверки
			if (oOutputDocumentCur.IsBrought)
			{
				if (RFMMessage.MessageBoxYesNo("Для расходного документа уже зарегистрирована доставка получателю.\n\n" +
					"Все-таки заполнить дополнительные сведения о товарах:\n" +
                    "декларации соответствия, ветеринарные свидетельства?") != DialogResult.Yes)
					return;
				bAsked = true;
			}
			if (oOutputDocumentCur.IsConfirmed)
			{
				if (RFMMessage.MessageBoxYesNo("Для расходного документа уже зарегистрирована отгрузка со склада.\n\n" + 
					"Все-таки заполнить дополнительные сведения о товарах:\n" +
                    "декларации соответствия, ветеринарные свидетельства?") != DialogResult.Yes)
					return;
				bAsked = true;
			}

			if (!bAsked)
			{
				if (RFMMessage.MessageBoxYesNo("Заполнить дополнительные сведения о товарах:\n" +
                    "декларации соответствия, ветеринарные свидетельства?") != DialogResult.Yes)
					return;
			}

			bool lResult = LogService.OutputDocumentQuality_Set((int)oOutputDocumentCur.ID, true) &&
							LogService.OutputDocumentVeterinary_Set((int)oOutputDocumentCur.ID, true);
							//LogService.OutputDocumentCustomNumber_Set((int)oOutputDocumentCur.ID, true);
							//LogService.OutputDocumentVat_Set((int)oOutputDocumentCur.ID);
			if (lResult)
			{
				//RFMMessage.MessageBoxInfo("Дополнительные сведения о товарах в расходном документе получены.");
				grdOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsFailReasonChange()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			if (!oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Товар еще не доставлен получателю.\nПричина полной недоставки товара получателю не регистрируется.");
				return;
			}
			if (!oOutputDocumentCur.OutputDocumentFailReasonID.HasValue)
			{
				RFMMessage.MessageBoxError("Для расходного документа не указана причина полной недоставки товара получателю.");
				return;
			}

			oOutputDocumentCur.FillTableOutputsDocumentsFailsReasons();
			_SelectedID = null;
			if (StartForm(new frmSelectID(this, oOutputDocumentCur.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "Причина полной недоставки товара, Виновник")) == DialogResult.Yes)
			{
				if (!_SelectedID.HasValue)
				{
					RFMMessage.MessageBoxError("Не выбрана причина полной недоставки товара получателю.");
					return;
				}

				int nOutputDocumentFailReasonID = (int)_SelectedID;

				oOutputDocumentCur.ChangeOutputDocumentFailReason((int)oOutputDocumentCur.ID, nOutputDocumentFailReasonID);
				if (oOutputDocumentCur.ErrorNumber == 0)
				{
					grdOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsGoodReturnReasonChange()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;
			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			if (!oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Товар еще не доставлен получателю.\nПричина возврата товара в заказе не регистрируется.");
				return;
			}

			RFMDataGridView grd = grdOutputsDocumentsGoods; 
			if (grd.Rows.Count == 0 ||
				grd.DataSource == null ||
				grd.CurrentRow == null)
				return;

			if (!LastGrid.Name.ToUpper().Contains(grd.Name.ToUpper()) || 
				grd.IsStatusRow(grd.CurrentRow.Index))
			{
				RFMMessage.MessageBoxAttention("Для регистрации причины возврата следует перейти в таблицу товаров в расходном документе и выбрать товар.");
				return;
			}

			DataRow r = ((DataRowView)((DataGridViewRow)grdOutputsDocumentsGoods.Rows[grdOutputsDocumentsGoods.CurrentRow.Index]).DataBoundItem).Row;
			if (/*!(bool)r["Weighting"] && */(decimal)r["QntBrought"] >= (decimal)r["QntConfirmed"])
			{
				RFMMessage.MessageBoxError("Весь товар доставлен получателю.\nПричина возврата товара в заказе не регистрируется.");
				return;
			}

			int nOutputDocumentGoodID = Convert.ToInt32(r["ID"]);

			oOutputDocumentCur.FillTableReturnsReasons();
			_SelectedID = null;
			if (StartForm(new frmSelectID(this, oOutputDocumentCur.TableReturnsReasons, "Name, GuiltyName", "Причина возврата товара, Виновник")) == DialogResult.Yes)
			{
				if (!_SelectedID.HasValue)
				{
					RFMMessage.MessageBoxError("Не выбрана причина возврата товара в заказе.");
					return;
				}

				int nReturnReasonID = (int)_SelectedID;

				oOutputDocumentCur.ChangeOutputDocumentGoodReturnReason(nOutputDocumentGoodID, nReturnReasonID);
				if (oOutputDocumentCur.ErrorNumber == 0)
				{
					grdOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsGuiltyEmployees()
		{
			if (grdOutputsDocuments.CurrentRow == null ||
                grdOutputsDocuments.IsStatusRow(grdOutputsDocuments.CurrentRow.Index))
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			if (!oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Товар еще не выдан со склада.\nВвод данных о виновниках и причинах проблем не производится.");
				return;
			}
			if (!oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxError("Товар еще не доставлен получателю.\nВвод данных о виновниках и причинах проблем не производится.");
				return;
			}

			OutputDocument oOutputDocumentGuilty = new OutputDocument();
			oOutputDocumentGuilty.ReFillOne((int)oOutputDocumentCur.ID);
			oOutputDocumentGuilty.FillTableOutputsDocumentsGoods();
			if (oOutputDocumentCur.ErrorNumber != 0 || oOutputDocumentGuilty.TableOutputsDocumentsGoods == null ||
				oOutputDocumentGuilty.TableOutputsDocumentsGoods.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о товарах в расходном документе...");
				return; 
			}
			// только товары с проблемами
			string sFilter = "QntWished <> QntConfirmed";
			if (oOutputDocumentGuilty.IsBrought) 
				sFilter += " or QntWished <> QntBrought or QntConfirmed <> QntBrought";
			DataTable dt = CopyTable(oOutputDocumentGuilty.TableOutputsDocumentsGoods, "dt", sFilter, "ByOrder, GoodGroupName, GoodAlias");
			if (dt == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о проблемных товарах в расходном документе...");
				return; 
			}
			if (dt.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("В расходном документе нет проблемных товаров...\nВвод данных о виновниках проблем не производится.");
				return; 
			}

			if (StartForm(new frmOutputsDocumentsGuiltyEmployees((int)oOutputDocumentGuilty.ID)) == DialogResult.Yes)
			{
				grdOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsAdditionalClear()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			bool bAsked = false; 

			// проверки
			if (oOutputDocumentCur.IsBrought)
			{
				if (RFMMessage.MessageBoxYesNo("Для расходного документа уже зарегистрирована доставка получателю.\n\n" +
					"Все-таки очистить дополнительные сведения о товарах:\n" +
                    "декларации соответствия, ветеринарные свидетельства?") != DialogResult.Yes)
					return;
				bAsked = true; 
			}
			if (oOutputDocumentCur.IsConfirmed)
			{
				if (RFMMessage.MessageBoxYesNo("Для расходного документа уже зарегистрирована отгрузка со склада.\n\n" + 
					"Все-таки очистить дополнительные сведения о товарах:\n" +
                    "декларации соответствия, ветеринарные свидетельства?") != DialogResult.Yes)
					return;
				bAsked = true;
			}

			if (!bAsked)
			{
				if (RFMMessage.MessageBoxYesNo("Очистить дополнительные сведения о товарах:\n" +
                    "декларации соответствия, ветеринарные свидетельства?") != DialogResult.Yes)
					return;
			}

			bool lResult = LogService.OutputDocumentQuality_Clear((int)oOutputDocumentCur.ID) &&
							LogService.OutputDocumentVeterinary_Clear((int)oOutputDocumentCur.ID); 
							//LogService.OutputDocumentCustomNumber_Clear((int)oOutputDocumentCur.ID); 
							//LogService.OutputDocumentVat_Clear((int)oOutputDocumentCur.ID);
			if (lResult)
			{
				//RFMMessage.MessageBoxInfo("Дополнительные сведения о товарах в расходном документе очищены.");
				grdOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsVeterinaryClear()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			bool bAsked = false;

			// проверки
			if (oOutputDocumentCur.IsBrought)
			{
				if (RFMMessage.MessageBoxYesNo("Для расходного документа уже зарегистрирована доставка получателю.\n\n" +
					"Все-таки очистить сведения о ветеринарных свидетельствах для товаров?") != DialogResult.Yes)
					return;
				bAsked = true;
			}
			if (oOutputDocumentCur.IsConfirmed)
			{
				if (RFMMessage.MessageBoxYesNo("Для расходного документа уже зарегистрирована отгрузка со склада.\n\n" +
					"Все-таки очистить сведения о ветеринарных свидетельствах для товаров?") != DialogResult.Yes)
					return;
				bAsked = true;
			}

			if (!bAsked)
			{
				if (RFMMessage.MessageBoxYesNo("Очистить сведения о ветеринарных свидетельствах для товаров?") != DialogResult.Yes)
					return;
			}

			bool lResult = LogService.OutputDocumentVeterinary_Clear((int)oOutputDocumentCur.ID);
			if (lResult)
			{
				//RFMMessage.MessageBoxInfo("Сведения о ветеринарных свидетельствах для товаров очищены.");
				grdOutputsDocuments_Restore();
			}
		}

		#region Service VeterinaryBlankData NEW

		private void VeterinaryBlankData()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			bool bAll = (grdOutputsDocuments.IsCheckerInclude && grdOutputsDocuments.IsCheckerShow && grdOutputsDocuments.MarkedCount > 0); 
			OutputDocument oOutputDocumentVeterinaryBlank = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentVeterinaryBlank, bAll);
			oOutputDocumentVeterinaryBlank.FillDataAsync();
			if (oOutputDocumentVeterinaryBlank.ErrorNumber != 0 ||
				oOutputDocumentVeterinaryBlank.MainTable == null)
				return;
			if (oOutputDocumentVeterinaryBlank.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			string sOutputsDocumentsList = (oOutputDocumentVeterinaryBlank.IDList.Length > 0) ? oOutputDocumentVeterinaryBlank.IDList : oOutputDocumentVeterinaryBlank.ID.ToString();
			if (sOutputsDocumentsList == null || sOutputsDocumentsList.Length == 0)
				return;

			if (StartForm(new frmOutputsDocumentsVeterinaryBlankData(sOutputsDocumentsList)) == DialogResult.Yes)
			{
				grdOutputsDocuments_Restore();
			}
		}

		#endregion Service VeterinaryBlankData NEW

		private void OutputsDocumentsVeterinaryLicenceNeed(bool bSet)
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			if (oOutputDocumentCur.IsBrought)
			{
				if (RFMMessage.MessageBoxYesNo("Товар уже доставлен покупателю.\n" + 
						"Все-таки изменить признак \"Требуется ветеринарное свидетельство\" для расходного документа?") != DialogResult.Yes)
					return;
			}

			LogService.OutputDocumentVeterinaryLicenceNeed_Set((int)oOutputDocumentCur.ID, bSet);
			grdOutputsDocuments_Restore();
		}

		#endregion Additional

		#endregion OutputsDocumentsService

		#region InputsDocumentsService

		private void InputsDocumentsUnConfirm()
		{
			if (grdInputsDocuments.CurrentRow == null)
				return;

			if (!oInputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

			// проверки
			if (!oInputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Для приходного документа еще не зарегистрировано получение на складе...");
				return;
			}
			// 

			if (RFMMessage.MessageBoxYesNo("Снять отметку о получении на складе для приходного документа?") == DialogResult.Yes)
			{
				Refresh();

				RFMMessage.MessageBoxAttention("Снятие отметки о получении на складе для приходного документа выполняется автоматически,\n" +
					"при снятии подтверждения получения на складе для соответствующего складского задания на приход!\n\n" +
					"Здесь режим находится только для отладки!");

				WaitOn(this);
				bool bResult = oInputDocumentCur.UnConfirm((int)((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oInputDocumentCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка о получении на складе для приходного документа снята.");
					grdInputsDocuments_Restore();
				}
			}
		}

		private void InputsDocumentsWarrantClear()
		{
			if (grdInputsDocuments.CurrentRow == null)
				return;

			if (!oInputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

			// проверки
			if (oInputDocumentCur.WarrantNumber == null || oInputDocumentCur.WarrantNumber.Length == 0)
			{
				if (!oInputDocumentCur.PF_WarrantNeed)
				{
					RFMMessage.MessageBoxError("Доверенность на получение товара не требуется...");
					return;
				}
				RFMMessage.MessageBoxError("Выдача доверенности на получение товара не зарегистрирована...");
				return;
			}
			/*
			if (oInputDocumentCur.IsWarrantReturned)
			{
				RFMMessage.MessageBoxError("Зарегистрировано возвращение доверенности...");
				return;
			}
			*/ 
			// 

			if (RFMMessage.MessageBoxYesNo("Очистить номер доверенности на получение товара и запись в журнале доверенностей?") == DialogResult.Yes)
			{
				WaitOn(this);
				bool bResult = oInputDocumentCur.WarrantClear((int)oInputDocumentCur.ID);
				WaitOff(this);
				if (bResult && oInputDocumentCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка выдачи доверенности на получение товара снята.");
					grdInputsDocuments_Restore();
				}
			}
		}

		#region Additional Save

		private void InputsDocumentsCustomsNumbersSave()
		{
			if (grdInputsDocuments.CurrentRow == null)
				return;

			if (!oInputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oInputDocumentCur.ReFillOne((int)oInputDocumentCur.ID);

			if (RFMMessage.MessageBoxYesNo("Сохранить данные о ГТД для товаров в приходном документе?") == DialogResult.Yes)
			{
				WaitOn(this);
				bool bResult = oInputDocumentCur.GoodsCustomsSave((int)oInputDocumentCur.ID);
				WaitOff(this);
				if (bResult && oInputDocumentCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Данные о ГТД сохранены.");
					grdInputsDocuments_Restore();
				}
			}
		}

		#endregion Additional Save

		#region Quality, Veterinary

		#region InputsDocumentsQualityData

		private void InputsDocumentsQualityData()
		{
			if (grdInputsDocuments.DataSource == null ||
				grdInputsDocuments.Rows.Count == 0 ||
				grdInputsDocuments.CurrentRow == null ||
				!oInputDocumentCur.ID.HasValue)
				return;

			if (StartForm(new frmGoodsQualitiesEdit(null, null, (int)oInputDocumentCur.ID)) == DialogResult.Yes)
			{
				grdInputsDocuments_Restore();
			}
		}

		#endregion InputsDocumentsQualityData

		#region InputsDocumentsVeterinaryData

		private void InputsDocumentsVeterinaryData()
		{
			if (grdInputsDocuments.DataSource == null ||
				grdInputsDocuments.Rows.Count == 0 ||
				grdInputsDocuments.CurrentRow == null ||
				!oInputDocumentCur.ID.HasValue)
				return;

			if (StartForm(new frmGoodsVeterinariesEdit(null, null, (int)oInputDocumentCur.ID)) == DialogResult.Yes)
			{
				grdInputsDocuments_Restore();
			}
		}

		#endregion InputsDocumentsVeterinaryData

		#endregion Quality, Veterinary

		#endregion InputsDocumentsService

		#region OutputsCreateFromOutputsDocuments

		private void OutputsCreateFromOutputsDocuments()
		{
			if (grdOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			// перечитать
			oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

			// уже есть такое задание
			if (oOutputDocumentCur.OutputID.HasValue)
			{
				Output oOutputTemp = new Output();
				oOutputTemp.ID = oOutputDocumentCur.OutputID;
				oOutputTemp.FillDataAsync();
				if (oOutputTemp.ErrorNumber != 0 || oOutputTemp.MainTable == null)
				{
					RFMMessage.MessageBoxError("Ошибка при анализе существующих заданий на расход...");
					return;
				}
				if (oOutputTemp.MainTable.Rows.Count > 0)
				{
					RFMMessage.MessageBoxError("Уже есть задание на расход для данного расходного документа...");
					return;
				}
			}

			// проверки
			if (oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Для расходного документа уже зарегистрирована отгрузка со склада...\n" + 
					"Задание на расход не создается.");
			}

			WaitOn(this);
			int? nOutputNewID = null;
			bool bIsOutputJoined = false;
			bool bResult = oOutputDocumentCur.OutputsCreateJoinFromOutputsDocuments((int)oOutputDocumentCur.ID, ref nOutputNewID, ref bIsOutputJoined);
			WaitOff(this);
			if (bResult && oOutputDocumentCur.ErrorNumber == 0)
			{
				//RFMMessage.MessageBoxInfo("Создано задание на расход с кодом " + nOutputNewID.ToString());
				grdOutputsDocuments_Restore();
			}
		}

		#endregion OutputsCreateFromOutputsDocuments

	#endregion

	#region Filters Choose

        #region Partners

        private void ucSelectRecordID_PartnersSource_Restore()
        {
            if (ucSelectRecordID_PartnersSource.sourceData == null)
            {
                Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, true, false))
				{
					ucSelectRecordID_PartnersSource.Restore(oPartner.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_PartnersSource.Restore();
            }
        }

        private void ucSelectRecordID_PartnersTarget_Restore()
        {
            if (ucSelectRecordID_PartnersTarget.sourceData == null)
            {
                Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, false, true))
				{
					ucSelectRecordID_PartnersTarget.Restore(oPartner.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_PartnersTarget.Restore();
            }
        }

        #endregion Partners

		#region Owners

        private void ucSelectRecordID_Owners_Restore()
        {
            if (ucSelectRecordID_Owners.sourceData == null)
            {
                Partner oOwner = new Partner();
				if (Utilities.FillData_Owners(oOwner))
				{
					ucSelectRecordID_Owners.Restore(oOwner.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_Owners.Restore();
            }
        }

		#endregion Owners

		#region Hosts

		private void ucSelectRecordID_Hosts_Restore()
		{
			if (ucSelectRecordID_Hosts.sourceData == null)
			{
				if (Utilities.FillData_Hosts(oHost))
				{
					ucSelectRecordID_Hosts.Restore(oHost.MainTable);
				}
			}
			else
			{
				ucSelectRecordID_Hosts.Restore();
			}
		}

		#endregion Hosts

		#region Packings

		private void ucSelectRecordIDForm_Packings_Restore()
		{
			ucSelectRecordIDForm_Packings.SendParams = new object[] { ucSelectRecordIDForm_Packings, true };
			ucSelectRecordIDForm_Packings.Restore();
		}

		private void ucSelectRecordIDForm_Packings_TxtData_TextChanged(object sender, EventArgs e)
		{
			if (ucSelectRecordIDForm_Packings.TxtData.Text.Trim().Length > 0)
			{
				chkShowSelectedGoodsOnly.Enabled = true;
			}
			else
			{
				chkShowSelectedGoodsOnly.Checked =
				chkShowSelectedGoodsOnly.Enabled =
					false;
			}
		}

		#endregion Packings

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			RFMCursorWait.LockWindowUpdate(Handle);

			dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(-1).Date;
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(2).Date ;

			optDeliveryNeedAll.Checked = true;

			txtPartnerSourceNameContext.Text = "";
            ucSelectRecordID_PartnersSource.ClearData();

			txtPartnerTargetNameContext.Text = "";
            ucSelectRecordID_PartnersTarget.ClearData();

            ucSelectRecordID_Owners.ClearData();

			optOutputsDocumentsIsConfirmedAll.Checked = true;
			optOutputsDocumentsIsBroughtAll.Checked = true;
			optInputsDocumentsIsConfirmedAll.Checked = true;

			optTripExistsAll.Checked = true;
			numTripID.Value = 0;
			txtTripAliasContext.Text = "";

			txtBillNumberContext.Text = "";
			txtDepartmentNameContext.Text = "";

			txtERPCodeContext.Text = "";

			ucSelectRecordID_Hosts.ClearData();

			ucSelectRecordIDForm_Packings.ClearData();
			chkShowSelectedGoodsOnly.Checked =
			chkShowSelectedGoodsOnly.Enabled =
				false;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);

			tabOutputsDocuments.IsNeedRestore = 
			tabInputsDocuments.IsNeedRestore = 
				true;
		}

	#endregion

	}
}