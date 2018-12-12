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
	public partial class frmFreeOperations : RFMFormChild
	{
		private OutputDocument oOutputDocumentsList; //список расходов
		private OutputDocument oOutputDocumentCur; //текущий расход

		private Input oInputList; //список приходов
		private Input oInputCur; //текущий приход

		private InputDocument oInputDocumentInInput;
		private Act oActForInput;
		
		private MovingDocument oMovingDocumentsList;
		private MovingDocument oMovingDocumentCur;

		private Host oHost;
		private int? nUserHostID = null;

		private decimal nVatVeterinaryPayment = 18;

		// для фильтров
		public string _SelectedIDList;
		public int? _SelectedID = null; 
		public string _SelectedText;


		public frmFreeOperations()
		{
			oOutputDocumentsList = new OutputDocument();
			oOutputDocumentCur = new OutputDocument();
			if (oOutputDocumentsList.ErrorNumber != 0 ||
				oOutputDocumentCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oInputList = new Input();
			oInputCur = new Input();
			if (oInputList.ErrorNumber != 0 ||
				oInputCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oInputDocumentInInput = new InputDocument();
				if (oInputDocumentInInput.ErrorNumber != 0)
				{
					IsValid = false;
				}

				if (IsValid)
				{
					oActForInput = new Act();
					if (oActForInput.ErrorNumber != 0)
					{
						IsValid = false;
					}
				}
			}

			if (IsValid)
			{
				oMovingDocumentsList = new MovingDocument();
				oMovingDocumentCur = new MovingDocument();
				if (oMovingDocumentsList.ErrorNumber != 0 ||
					oMovingDocumentCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}
			// ? акты 

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


		private void frmFreeOperations_Load(object sender, EventArgs e)
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
			dgvcMovingsDocumentsGoods_PriceSum.AgrType =
			dgvcOutputsDocumentsGoods_PriceSum.AgrType =
			dgvcOutputsDocuments_DeliveryPrice.AgrType =
			dgvcOutputsDocuments_VeterinaryPrice.AgrType =
				EnumAgregate.Sum; 

			dgvOutputsDocuments.IsStatusShow =
			dgvOutputsDocumentsGoods.IsStatusShow =
			dgvInputs.IsStatusShow =
			dgvInputsGoods.IsStatusShow =
			dgvInputsDocuments.IsStatusShow =
			dgvInputsActs.IsStatusShow =
			dgvMovingsDocumentsGoods.IsStatusShow = 
				true;

			mniOutputsDocumentsPrintFacturePerversion.Visible =
			mniOutputsDocumentsPrintBillPerversion.Visible =
				((RFMFormMain)Application.OpenForms[0]).UserInfo.UserIsAdmin;

			btnClearTerms_Click(null, null);

			tcList.Init();
			tcInputsGoods.Init();

			RFMCursorWait.Set(false);
		}

	#region Tab Restore

		#region Top Tabs

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled = 
			btnDelete.Enabled =
			btnEdit.Enabled =
			btnConfirm.Enabled =
			btnPrint.Enabled =
			btnService.Enabled =
				false;
			return true;
		}

		private bool tabOutputsDocuments_Restore()
		{
			dgvOutputsDocuments_Restore();
			dgvOutputsDocuments.Select();
			return (true);
		}

		private bool tabInputs_Restore()
		{
			dgvInputs_Restore();
			dgvInputs.Select();
			return (true);
		}

		private bool tabMovingsDocuments_Restore()
		{
			dgvMovingsDocuments_Restore();
			dgvMovingsDocuments.Select();
			return (true);
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!((RFMTabPage)tcList.SelectedTab).IsFilterPage)
				tmrRestore_Tick(null, null);

			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled =
				btnDelete.Enabled =
				btnEdit.Enabled =
				btnConfirm.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}

			if (tcList.SelectedTab.Name.ToUpper().Contains("OUTPUTSDOCUMENTS"))
			{
				btnService.ShortCutSet(mnuOutputsDocumentsService);
				btnPrint.ShortCutSet(mnuOutputsDocumentsPrint);
				ttToolTip.SetToolTip(btnConfirm, "Создание задания на расход для расходного документа");
			}
			if (tcList.SelectedTab.Name.ToUpper().Contains("INPUTS"))
			{
				btnService.ShortCutSet(mnuInputsService);
				btnPrint.ShortCutSet(mnuInputsPrint);
				ttToolTip.SetToolTip(btnConfirm, "");
			}
			if (tcList.SelectedTab.Name.ToUpper().Contains("MOVINGSDOCUMENTS"))
			{
				btnService.ShortCutSet(mnuMovingsDocumentsService);
				btnPrint.ShortCutSet(mnuMovingsDocumentsPrint);
				ttToolTip.SetToolTip(btnConfirm, "Подтверждение");
			}
		}

		#endregion Top Tabs

		#region Bottom Tabs

		private bool tabInputsGoods_Restore()
		{
			return dgvInputsGoods_Restore();
		}

		private bool tabInputsDocuments_Restore()
		{
			return dgvInputsDocuments_Restore();
		}

		private bool tabInputsActs_Restore()
		{
			return dgvInputsActs_Restore();
		}

		#endregion Bottom Tabs

	#endregion Tab restore

	#region RowEnter, CellFormatting

		private void dgv_CurrentRowChanged(object sender)
		{
			RFMDataGridView dgv = (RFMDataGridView)sender;
			if (dgv.IsLockRowChanged /*|| dgv.IsStatusRow(dgv.CurrentRow.Index)*/)
				return;

			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView dgv = new RFMDataGridView();

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTSDOCUMENTS"))
				dgv = dgvOutputsDocuments;
			if (sPageName.Contains("INPUTS"))
				dgv = dgvInputs;
			if (sPageName.Contains("MOVINGSDOCUMENTS"))
				dgv = dgvMovingsDocuments;

			int rowIndex;
			if (dgv.CurrentRow == null || dgv.CurrentRow.Index < 0)
				rowIndex = -1;
			else
				rowIndex = dgv.CurrentRow.Index;

			btnAdd.Enabled = true;
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnConfirm.Enabled =
			btnPrint.Enabled =
			btnService.Enabled =
				false;

			if (sPageName.Contains("OUTPUTSDOCUMENTS"))
			{
				if (rowIndex < 0 || dgv.IsStatusRow(rowIndex) || dgv.RowCount == 0)
				{
					oOutputDocumentCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)dgv.Rows[rowIndex]).DataBoundItem).Row;
					oOutputDocumentCur.FillOne(r);

                    btnConfirm.Enabled = 
						!oOutputDocumentCur.IsOutputExists && !oOutputDocumentCur.IsConfirmed ; 
					btnEdit.Enabled =
					btnDelete.Enabled = 
						!oOutputDocumentCur.IsOutputExists && !oOutputDocumentCur.IsConfirmed && !oOutputDocumentCur.TripExists;
					btnPrint.Enabled =
					btnService.Enabled =
						true;

					mniOutputsDocumentsPrintBills.Enabled =   
					mniOutputsDocumentsPrintBillAll.Enabled =  
					mniOutputsDocumentsPrintBillOne.Enabled =
					mniOutputsDocumentsPrintFactures.Enabled =
					mniOutputsDocumentsPrintFactureAll.Enabled =
					mniOutputsDocumentsPrintFactureOne.Enabled =
					mniOutputsDocumentsPrintInnerMovingBill.Enabled =
						oOutputDocumentCur.IsConfirmed;

					mniOutputsDocumentPrintPayBill.Enabled = true;
					mniOutputsDocumentsPrintTTN.Enabled = true;

					mniOutputsDocumentsPrintWarrant.Enabled = true; 

					mniOutputsDocumentsPrintQuality.Enabled =
					mniOutputsDocumentsPrintVeterinary.Enabled =
					mniOutputsDocumentsPrintVeterinaryBlankData.Enabled =
						true;

					mniOutputsDocumentsPrintTransport.Enabled = ((decimal)r["DeliveryPrice"] > 0);
					mniOutputsDocumentsPrintVeterinaryPayment.Enabled = ((decimal)r["VeterinaryPrice"] > 0);

					mniOutputsDocumentsPrintMX3.Enabled = true; 

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
				dgvOutputsDocumnetsGoods_Restore();
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (rowIndex < 0 || dgv.IsStatusRow(rowIndex) || dgv.RowCount == 0)
				{
					oInputCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)dgv.Rows[rowIndex]).DataBoundItem).Row;
					oInputCur.FillOne(r);

					btnEdit.Enabled =
					btnDelete.Enabled =
						!oInputCur.IsConfirmed && !oInputCur.ReadyForWMS && !oInputCur.TripExists;
                    btnPrint.Enabled =
					btnService.Enabled =
						true;

					mniInputsPrintBillWithAct.Enabled = true;
					mniInputsPrintBillMX1.Enabled = true;

					mniInputsServiceChangeDate.Enabled =
					mniInputsServiceInputsDocumentsCreateFromInputs.Enabled =
					mniInputsServiceUpdateFromInputsDocuments.Enabled =
						true;

					mniInputsServiceSetReadyForWMS.Enabled = true; // !oInputCur.ReadyForWMS; // массовая операция
					mniInputsServiceClearReadyForWMS.Enabled = true; // oInputCur.ReadyForWMS; // массовая операция

					mniInputsServiceSetDeliveryNeed.Enabled = !oInputCur.DeliveryNeed && !oInputCur.TripExists;
					mniInputsServiceClearDeliveryNeed.Enabled = oInputCur.DeliveryNeed && !oInputCur.TripExists;

					mniInputsServiceCreateAct.Enabled = oInputCur.IsConfirmed;
				}
				tcInputsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("MOVINGSDOCUMENTS"))
			{
				if (rowIndex < 0 || dgv.IsStatusRow(rowIndex) || dgv.RowCount == 0)
				{
					oMovingDocumentCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)dgv.Rows[rowIndex]).DataBoundItem).Row;
					oMovingDocumentCur.FillOne(r);

					btnEdit.Enabled =
					btnDelete.Enabled =
					btnConfirm.Enabled =
						!oMovingDocumentCur.IsConfirmed;
					btnPrint.Enabled =
					btnService.Enabled =
						true;
				}
				dgvMovingsDocumnetsGoods_Restore();
			}
		}

		private void dgvOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView dgv = (RFMDataGridView)sender;
			if (dgv.DataSource == null)
				return;

			string sGridName = dgv.Name.ToUpper();
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

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
			// копирование
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}
		}

		private void dgvOutputsDocumentsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView dgv = (RFMDataGridView)sender;
			if (dgv.DataSource == null)
				return;
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных 
			DataRow r = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;
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
					(!Convert.IsDBNull(r["InBox"]) && Convert.ToInt32(r["Weighting"]) != Convert.ToDecimal(r["Weighting"])) ||
					(!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value)))
				{
					e.CellStyle.Format = "### ###.000";
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

		private void dgvInputs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView dgv = (RFMDataGridView)sender;
			if (dgv.DataSource == null)
				return;

			string sGridName = dgv.Name.ToUpper();
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

			// подтверждение отгрузки / приема на складе
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

			// передача в WMS
			if (sColumnName.Contains("ReadyForWMSImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Plain_GD;
				}
				else
				{
					if ((bool)r["SentToWMS"])
					{
						e.Value = Properties.Resources.Plain_B;
					}
					else
					{
						if ((bool)r["ReadyForWMS"])
						{
							e.Value = Properties.Resources.Plain_Y;
						}
						else
						{
							e.Value = Properties.Resources.Plain_R;
						}
					}
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
			if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputID"]))
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}
			// копирование
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}
		}

		private void dgvInputsActs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView dgv = (RFMDataGridView)sender;
			if (dgv.DataSource == null)
				return;
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных 
			DataRow r = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Check;
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}
		}

		private void dgvMovingsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView dgv = (RFMDataGridView)sender;
			if (dgv.DataSource == null)
				return;

			string sGridName = dgv.Name.ToUpper();
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("RESULT") ||
					sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)dgv.Rows[e.RowIndex].DataBoundItem).Row;

			// подтверждение 
			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Check;
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

	#endregion Cells...

	#region Restore

		#region OutputsDocuments

		private bool dgvOutputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputDocumentCur.ClearOne();

			oOutputDocumentsList.ClearError();
			oOutputDocumentsList.ClearFilters();
			oOutputDocumentsList.ID = null;
			oOutputDocumentsList.IDList = null;

			// собираем условия
			oOutputDocumentsList.FilterIsFree = true;

			GetCommonFilters();

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oOutputDocumentsList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oOutputDocumentsList.FilterDeliveryNeed = false;
			}

			// получатели
			if (ucSelectRecordIDForm_OutputsDocumentsPartners.IsSelectedExist)
			{
				oOutputDocumentsList.FilterPartnersTargetList = ucSelectRecordIDForm_OutputsDocumentsPartners.GetIdString();
			}
			//

			dgvOutputsDocumentsGoods.DataSource = null;

			dgvOutputsDocuments.GetGridState();

			oOutputDocumentsList.FillData();
			dgvOutputsDocuments.IsLockRowChanged = true;

			dgvOutputsDocuments.Restore(oOutputDocumentsList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oOutputDocumentsList.ErrorNumber == 0);
		}

		private bool dgvOutputsDocumnetsGoods_Restore()
		{
			dgvOutputsDocumentsGoods.GetGridState();
			dgvOutputsDocumentsGoods.DataSource = null;
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				oOutputDocumentCur.ID == null ||
				(dgvOutputsDocuments.CurrentRow != null && dgvOutputsDocuments.IsStatusRow(dgvOutputsDocuments.CurrentRow.Index)))
				return (true);

			oOutputDocumentsList.FillTableOutputsDocumentsGoods((int)oOutputDocumentCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oOutputDocumentsList.TableOutputsDocumentsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"GoodAlias, ID");
				oOutputDocumentsList.TableOutputsDocumentsGoods.Clear();
				oOutputDocumentsList.TableOutputsDocumentsGoods.Merge(dt);
			}

			dgvOutputsDocumentsGoods.Restore(oOutputDocumentsList.TableOutputsDocumentsGoods);
			return (oOutputDocumentsList.ErrorNumber == 0);
		}

		#endregion OutputsDocuments

		#region Inputs

		private bool dgvInputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputCur.ClearOne();

			oInputList.ClearError();
			oInputList.ClearFilters();
			oInputList.ID = null;
			oInputList.IDList = null;

			// собираем условия

			oInputList.FilterIsFree = true;
			GetCommonFilters();

			// типы приходов
			if (ucSelectRecordID_InputsTypes.IsSelectedExist)
			{
				oInputList.FilterInputsTypesList = ucSelectRecordID_InputsTypes.GetIdString();
			}

			// поставщики
			if (ucSelectRecordIDForm_InputsPartners.IsSelectedExist)
			{
				oInputList.FilterPartnersList = ucSelectRecordIDForm_InputsPartners.GetIdString();
			}
			//

			dgvInputsGoods.DataSource = null;
			dgvInputsDocuments.DataSource = null;
			dgvInputsActs.DataSource = null;

			dgvInputs.GetGridState();

			oInputList.FillData();
			dgvInputs.IsLockRowChanged = true;

			dgvInputs.Restore(oInputList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oInputList.ErrorNumber == 0);
		}

		private bool dgvInputsGoods_Restore()
		{
			dgvInputsGoods.GetGridState();
			dgvInputsGoods.DataSource = null;
			if (dgvInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(dgvInputs.CurrentRow != null && dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index)))
				return (true);

			oInputList.FillTableInputsGoods((int)oInputCur.ID);
			
			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oInputList.TableInputsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"GoodAlias, ID");
				oInputList.TableInputsGoods.Clear();
				oInputList.TableInputsGoods.Merge(dt);
			}

			dgvInputsGoods.Restore(oInputList.TableInputsGoods);
			return (oInputList.ErrorNumber == 0);
		}

		private bool dgvInputsDocuments_Restore()
		{
			dgvInputsDocuments.GetGridState();
			dgvInputsDocuments.DataSource = null;
			if (dgvInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(dgvInputs.CurrentRow != null && dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index)))
				return (true);

			oInputDocumentInInput.FilterInputsList = oInputCur.ID.ToString();
			oInputDocumentInInput.FillData();
			dgvInputsDocuments.Restore(oInputDocumentInInput.MainTable);
			return (oInputDocumentInInput.ErrorNumber == 0);
		}

		private bool dgvInputsActs_Restore()
		{
			dgvInputsActs.GetGridState();
			dgvInputsActs.DataSource = null;
			if (dgvInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(dgvInputs.CurrentRow != null && dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index)))
				return (true);

			oActForInput.FilterInputsList = oInputCur.ID.ToString();
			oActForInput.FillData();
			dgvInputsActs.Restore(oActForInput.MainTable);
			return (oActForInput.ErrorNumber == 0);
		}

		#endregion Inputs 

		#region MovingsDocuments

		private bool dgvMovingsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oMovingDocumentCur.ClearOne();

			oMovingDocumentsList.ClearError();
			oMovingDocumentsList.ClearFilters();
			oMovingDocumentsList.ID = null;
			oMovingDocumentsList.IDList = null;

			// собираем условия
			GetCommonFilters();

			// поставщики
			if (ucSelectRecordIDForm_MovingsOwnerSource.IsSelectedExist)
				oMovingDocumentsList.FilterOwnersSourceList = ucSelectRecordIDForm_MovingsOwnerSource.GetIdString();

			// получатели
			if (ucSelectRecordIDForm_MovingsOwnerTarget.IsSelectedExist)
				oMovingDocumentsList.FilterOwnersTargetList = ucSelectRecordIDForm_MovingsOwnerTarget.GetIdString();
			//

			dgvMovingsDocumentsGoods.DataSource = null;

			dgvMovingsDocuments.GetGridState();

			oMovingDocumentsList.FillData();
			dgvMovingsDocuments.IsLockRowChanged = true;

			dgvMovingsDocuments.Restore(oMovingDocumentsList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oMovingDocumentsList.ErrorNumber == 0);
		}

		private bool dgvMovingsDocumnetsGoods_Restore()
		{
			dgvMovingsDocumentsGoods.GetGridState();
			dgvMovingsDocumentsGoods.DataSource = null;
			if (dgvMovingsDocuments.Rows.Count == 0 ||
				oMovingDocumentCur.ID == null ||
				(dgvMovingsDocuments.CurrentRow != null && dgvMovingsDocuments.IsStatusRow(dgvMovingsDocuments.CurrentRow.Index)))
				return (true);

			oMovingDocumentsList.FillTableMovingsDocumentsGoods((int)oMovingDocumentCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oMovingDocumentsList.TableMovingsDocumentsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"GoodAlias, ID");
				oMovingDocumentsList.TableMovingsDocumentsGoods.Clear();
				oMovingDocumentsList.TableMovingsDocumentsGoods.Merge(dt);
			}

			dgvMovingsDocumentsGoods.Restore(oMovingDocumentsList.TableMovingsDocumentsGoods);
			return (oMovingDocumentsList.ErrorNumber == 0);
		}

		#endregion MovingsDocuments

	#endregion Restore

	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTSDOCUMENTS"))
			{
				if (StartForm(new frmOutputsDocumentsEdit(0)) == DialogResult.Yes)
				{
					int nOutputDocumentID = (int)GotParam.GetValue(0);
					dgvOutputsDocuments_Restore();
					dgvOutputsDocuments.GridSource.Position = dgvOutputsDocuments.GridSource.Find("ID", nOutputDocumentID);
					tmrRestore_Tick(null, null);
				}
				return;
			}	
			if (sPageName.Contains("INPUTS"))
			{
				if (StartForm(new frmInputsEdit(0)) == DialogResult.Yes)
				{
					int nInputID = (int)GotParam.GetValue(0);
					tabInputs_Restore();	
					dgvInputs.GridSource.Position = dgvInputs.GridSource.Find("ID", nInputID);
					tmrRestore_Tick(null, null);
				}
				return;
			}
			if (sPageName.Contains("MOVINGSDOCUMENTS"))
			{
				if (StartForm(new frmMovingsDocumentsEdit(0)) == DialogResult.Yes)
				{
					int nMovingDocumentID = (int)GotParam.GetValue(0);
					dgvMovingsDocuments_Restore();
					dgvMovingsDocuments.GridSource.Position = dgvMovingsDocuments.GridSource.Find("ID", nMovingDocumentID);
					tmrRestore_Tick(null, null);
				}
				return;
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTSDOCUMENTS"))
			{
				if (dgvOutputsDocuments.CurrentRow == null ||
					dgvOutputsDocuments.IsStatusRow(dgvOutputsDocuments.CurrentRow.Index) ||
					!oOutputDocumentCur.ID.HasValue)
					return;

				int nOutputDocumentID = (int)oOutputDocumentCur.ID;
				oOutputDocumentCur.ReFillOne(nOutputDocumentID);

				if (oOutputDocumentCur.ERPCode != null)
				{
					RFMMessage.MessageBoxError("Расходный документ получен из host-системы...");
					return;
				}

				if (oOutputDocumentCur.IsOutputExists)
				{
					RFMMessage.MessageBoxError("Для расходного документа уже создано задание на расход...");
					return;
				}

				if (oOutputDocumentCur.IsBrought)
				{
					RFMMessage.MessageBoxError("Товар по расходному документу уже доставлен получателю...");
					return;
				}

				if (oOutputDocumentCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Для расходного документа уже подтверждена отгрузка товара со склада...");
					return;
				}

				if (oOutputDocumentCur.TripExists)
				{
					RFMMessage.MessageBoxError("Расходный документ уже привязан к рейсу...");
					return;
				}

				if (StartForm(new frmOutputsDocumentsEdit(nOutputDocumentID)) == DialogResult.Yes)
				{
					dgvOutputsDocuments_Restore();
					dgvOutputsDocuments.GridSource.Position = dgvOutputsDocuments.GridSource.Find("ID", nOutputDocumentID);
					tmrRestore_Tick(null, null);
				}
			}
			
			if (sPageName.Contains("INPUTS"))
			{
				if (dgvInputs.CurrentRow == null ||
					dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index) ||
					!oInputCur.ID.HasValue)
					return;

				int nInputID = (int)oInputCur.ID;
				oInputCur.ReFillOne(nInputID);

				if (oInputCur.ERPCode != null)
				{
					RFMMessage.MessageBoxError("Задание на приход получено из host-системы...");
					return;
				}

				if (oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено...");
					return;
				}
				
				if (oInputCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему...");
					return;
				}

				if (oInputCur.ReadyForWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже готово к передаче в складскую систему...");
					return;
				}

				if (oInputCur.TripExists)
				{
					RFMMessage.MessageBoxError("Задание на приход уже привязано к рейсу...");
					return;
				}

				if (StartForm(new frmInputsEdit(nInputID)) == DialogResult.Yes)
				{
					dgvInputs_Restore();
					dgvInputs.GridSource.Position = dgvInputs.GridSource.Find("ID", nInputID);
					tmrRestore_Tick(null, null);
				}
			}

			if (sPageName.Contains("MOVINGSDOCUMENTS"))
			{
				if (dgvMovingsDocuments.CurrentRow == null ||
					dgvMovingsDocuments.IsStatusRow(dgvMovingsDocuments.CurrentRow.Index) ||
					!oMovingDocumentCur.ID.HasValue)
					return;

				int nMovingDocumentID = (int)oMovingDocumentCur.ID;
				oMovingDocumentCur.ReFillOne(nMovingDocumentID);

				if (oMovingDocumentCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Документарное перемещение уже подтверждено...");
					return;
				}

				if (StartForm(new frmMovingsDocumentsEdit(nMovingDocumentID)) == DialogResult.Yes)
				{
					tabMovingsDocuments_Restore();
					dgvMovingsDocuments.GridSource.Position = dgvMovingsDocuments.GridSource.Find("ID", nMovingDocumentID);
					tmrRestore_Tick(null, null);
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTSDOCUMENTS"))
			{
				if (dgvOutputsDocuments.DataSource == null ||
					dgvOutputsDocuments.Rows.Count == 0 ||
					dgvOutputsDocuments.CurrentRow == null ||
					!oOutputDocumentCur.ID.HasValue)
					return;

				int nOutputDocumentID = (int)oOutputDocumentCur.ID;
				oOutputDocumentCur.ReFillOne(nOutputDocumentID);

				if (oOutputDocumentCur.ERPCode != null)
				{
					RFMMessage.MessageBoxError("Расходный документ получен из host-системы...");
					return;
				}

				if (oOutputDocumentCur.IsOutputExists)
				{
					RFMMessage.MessageBoxError("Для расходного документа уже создано задание на расход...");
					return;
				}

				if (oOutputDocumentCur.IsBrought)
				{
					RFMMessage.MessageBoxError("Товар по расходному документу уже доставлен получателю...");
					return;
				}

				if (oOutputDocumentCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Для расходного документа уже подтверждена отгрузка товара со склада...");
					return;
				}

				if (oOutputDocumentCur.TripExists)
				{
					RFMMessage.MessageBoxError("Расходный документ уже привязан к рейсу...");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Удалить расходный документ?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult;
					bResult = oOutputDocumentCur.Delete(nOutputDocumentID);
					WaitOff(this);
					if (bResult && oOutputDocumentCur.ErrorNumber == 0)
					{
						dgvOutputsDocuments_Restore();
						tmrRestore_Tick(null, null);
					}
				}
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (dgvInputs.DataSource == null ||
					dgvInputs.Rows.Count == 0 ||
					dgvInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				int nInputID = (int)oInputCur.ID;
				oInputCur.ReFillOne(nInputID);

				if (oInputCur.ERPCode != null)
				{
					RFMMessage.MessageBoxError("Задание на приход получено из host-системы...");
					return;
				}

				if (oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено...");
					return;
				}

				if (oInputCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему...");
					return;
				}

				if (oInputCur.ReadyForWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже готово к передаче в складскую систему...");
					return;
				}

				if (oInputCur.TripExists)
				{
					RFMMessage.MessageBoxError("Задание на приход уже привязано к рейсу...");
					return;
				}

				if (oInputCur.InputsDocumentsExists)
				{
					RFMMessage.MessageBoxError("Для задания на приход уже оформлены приходные документы...");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Удалить задание на приход?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oInputCur.Delete(nInputID);
					WaitOff(this);
					if (bResult && oInputCur.ErrorNumber == 0)
					{
						dgvInputs_Restore();
						tmrRestore_Tick(null, null);
					}
				}
			}

			if (sPageName.Contains("MOVINGSDOCUMENTS"))
			{
				if (dgvMovingsDocuments.DataSource == null ||
					dgvMovingsDocuments.Rows.Count == 0 ||
					dgvMovingsDocuments.CurrentRow == null ||
					!oMovingDocumentCur.ID.HasValue)
					return;

				int nMovingDocumentID = (int)oMovingDocumentCur.ID;
				oMovingDocumentCur.ReFillOne(nMovingDocumentID);

				if (oMovingDocumentCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Документарное перемещение уже подтверждено...");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Удалить документарное перемещение?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oMovingDocumentCur.Delete(nMovingDocumentID);
					WaitOff(this);
					if (bResult && oMovingDocumentCur.ErrorNumber == 0)
					{
						dgvMovingsDocuments_Restore();
						tmrRestore_Tick(null, null);
					}
				}
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (dgvOutputsDocuments.DataSource == null ||
					dgvOutputsDocuments.Rows.Count == 0 ||
					dgvOutputsDocuments.CurrentRow == null ||
					!oOutputDocumentCur.ID.HasValue)
					return;

				oOutputDocumentCur.ReFillOne((int)oOutputDocumentCur.ID);

				if (oOutputDocumentCur.IsOutputExists)
				{
					RFMMessage.MessageBoxError("Для расходного документа уже существует задание на расход...");
					return;
				}

				if (oOutputDocumentCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Для расходного документа уже подтверждена отгузка товара со склада...");
					return;
				}

				if (oOutputDocumentCur.TripExists)
				{
					RFMMessage.MessageBoxError("Расходный документ уже привязан к рейсу...");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Создать для расходного документа новое складское задание на расход?") == DialogResult.Yes)
				{
					Refresh();
					oOutputDocumentCur.ClearError();

					WaitOn(this);
					int? nOutputNewID = oOutputDocumentCur.OutputID;
					if (oOutputDocumentCur.OutputsCreateFromOutputsDocuments((int)oOutputDocumentCur.ID, ref nOutputNewID) &&
						oOutputDocumentCur.ErrorNumber == 0 &&
						nOutputNewID.HasValue && (int)nOutputNewID > 0)
					{
						WaitOff(this);
						Output oOutputNew = new Output();
						oOutputNew.ReFillOne((int)nOutputNewID);
						if (RFMMessage.MessageBoxYesNo("Создан расход с кодом " + nOutputNewID.ToString() + ", тип \"" + oOutputNew.OutputTypeName + "\".\n\n" +
							"Изменить тип созданного расхода?") == DialogResult.Yes)
						{
							// выбрать тип расхода
							int? nOutputTypeID = null;
							if (Utilities.FillData_OutputsTypes(oOutputNew))
							{
								if (StartForm(new frmSelectID(this, oOutputNew.TableOutputsTypes, "Name", "Тип расхода", false)) == DialogResult.Yes)
								{
									if (_SelectedID != null)
										nOutputTypeID = _SelectedID;
								}
								_SelectedID = null;
								_SelectedText = "";
							}
							if (nOutputTypeID.HasValue)
							{
								oOutputNew.ChangeOutputType((int)nOutputNewID, (int)nOutputTypeID);
							}
						}

						dgvOutputsDocuments_Restore();
					}
					else
						WaitOff(this);
				}
			}

			if (sPageName.Contains("MOVINGS"))
			{
				if (dgvMovingsDocuments.DataSource == null ||
					dgvMovingsDocuments.Rows.Count == 0 ||
					dgvMovingsDocuments.CurrentRow == null ||
					!oMovingDocumentCur.ID.HasValue)
					return;

				oMovingDocumentCur.ReFillOne((int)oMovingDocumentCur.ID);

				// проверки
				if (oMovingDocumentCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Документарное перемещение уже подтверждено...");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Подтвердить документарное перемещение?") == DialogResult.Yes)
				{
					Refresh();
					oMovingDocumentCur.ClearError();

					WaitOn(this);
					if (oMovingDocumentCur.FillTableMovingsDocumentsGoods() && oMovingDocumentCur.TableMovingsDocumentsGoods != null && oMovingDocumentCur.ErrorNumber == 0)
					{
						if (oMovingDocumentCur.Confirm(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID) && oMovingDocumentCur.ErrorNumber == 0)
						{
							WaitOff(this);
							dgvMovingsDocuments_Restore();
						}
						else
						{
							WaitOff(this);
						}
					}
					else
					{
						WaitOff(this);
						RFMMessage.MessageBoxError("Ошибка при получении списка товаров в Документарном перемещении...");
					}
				}
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

	#endregion

	#region PrepareIDList

		public void OutputsDocumentsPrepareIDList(OutputDocument oOutputDocument, bool bMultiSelect)
		{
			oOutputDocument.ID = null;
			oOutputDocument.IDList = null;
			int? nOutputDocumentID = 0;
			if (bMultiSelect && dgvOutputsDocuments.IsCheckerShow)
			{
				oOutputDocument.IDList = "";

				DataView dMarked = new DataView(oOutputDocumentsList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = dgvOutputsDocuments.GridSource.Sort;
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
				nOutputDocumentID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;
				if (nOutputDocumentID.HasValue)
				{
					oOutputDocument.ID = nOutputDocumentID;
				}
			}
		}

	#endregion PrepareIDList

	#region MenuStrip

		#region inputs

		#region inputs service

		private void mniInputsServiceSetReadyForWMS_Click(object sender, EventArgs e)
		{
//			InputsSetReadyForWMS(true);
		}

		private void mniInputsServiceClearReadyForWMS_Click(object sender, EventArgs e)
		{
//			InputsSetReadyForWMS(false);
		}

		private void mniInputsServiceSetDeliveryNeed_Click(object sender, EventArgs e)
		{
			InputsSetDeliveryNeed(true);
		}

		private void mniInputsServiceClearDeliveryNeed_Click(object sender, EventArgs e)
		{
			InputsSetDeliveryNeed(false);
		}

		private void mniInputsServiceChangeDate_Click(object sender, EventArgs e)
		{
			InputsChangeDate();
		}

		private void mniInputsServiceInputsDocumentsCreateFromInputs_Click(object sender, EventArgs e)
		{
			InputsDocumentsCreateFromInputs();
		}

		private void mniInputsServiceUpdateFromInputsDocuments_Click(object sender, EventArgs e)
		{
			InputsUpdateFromInputsDocuments();
		}

		private void mniInputsServiceCreateAct_Click(object sender, EventArgs e)
		{
			CreateAct();
		}

		private void mniInputsServiceQualityData_Click(object sender, EventArgs e)
		{
//			InputsQualityData();
		}

		private void mniInputsServiceVeterinaryData_Click(object sender, EventArgs e)
		{
//			InputsVeterinaryData();
		}

		#endregion inputs service

		#region inputs print

		private void mniInputsPrintBillWithAct_Click(object sender, EventArgs e)
		{
			PrintInputBillWithAct();
		}

		private void mniInputsPrintBillMX1_Click(object sender, EventArgs e)
		{
			PrintInputBillMX1();
		}

		private void mniInputsPrintReturnBill_Click(object sender, EventArgs e)
		{
			PrintInputReturnBill();
		}

		private void mniInputsPrintWarrant_Click(object sender, EventArgs e)
		{
			PrintInputWarrant();
		}

		#endregion inputs print

		#endregion inputs

	#endregion MenuStrip
	
	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
			btnPrint.ShortCutShow();
		}

		#region InputsPrint

		private void PrintInputBill()
		{
			if (dgvInputs.CurrentRow == null ||
				dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			oInputPrint.ID = Convert.ToInt32(dgvInputs.CurrentRow.Cells["dgvcInputs_ID"].Value);
			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных по заданию на приход...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных по заданию на приход...");
				return;
			}

			LogService.InputBill_Print(oInputPrint, this);
		}

		private void PrintInputBillWithAct()
		{
			if (dgvInputs.CurrentRow == null ||
				dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			oInputPrint.ID = Convert.ToInt32(dgvInputs.CurrentRow.Cells["dgvcInputs_ID"].Value);
			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных по заданию на приход с учетом актов...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных по заданию на приход с учетом актов...");
				return;
			}

			LogService.InputBillWithAct_Print(oInputPrint, this);
		}

		private void PrintInputBillMX1()
		{
			if (dgvInputs.CurrentRow == null ||
				dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			oInputPrint.ReFillOne((int)oInputCur.ID);

			// проверки...

			LogService.InputBillMX1_Print(oInputPrint, this);
		}

        private void PrintInputReturnBill()
		{
			if (dgvInputs.CurrentRow == null ||
				dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			int nInputID = Convert.ToInt32(dgvInputs.CurrentRow.Cells["dgvcInputs_ID"].Value);
			oInputPrint.ReFillOne(nInputID);
			if (!oInputCur.IsReturn)
			{
				RFMMessage.MessageBoxError("Приход не является возвратом...\n" + 
					"Возвратная накладная от имени поставщика не строится.");
				return;
			}
			if (!oInputCur.TripExists)
			{
				RFMMessage.MessageBoxError("Приход не привязан к рейсу...\n" +
					"Возвратная накладная от имени поставщика не строится.");
				return;
			}

			LogService.InputReturnBill_Print(oInputPrint, this);
		}

		private void PrintInputWarrant()
		{
			if (dgvInputs.CurrentRow == null ||
				dgvInputs.IsStatusRow(dgvInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			int nInputID = Convert.ToInt32(dgvInputs.CurrentRow.Cells["dgvcInputs_ID"].Value);
			oInputPrint.ReFillOne(nInputID);
			if (!oInputCur.PF_WarrantNeed)
			{
				RFMMessage.MessageBoxError("Доверенность не требуется.");
				return;
			}

//			LogService.InputWarrant_Print(oInputPrint, this);
		}

		#endregion InputsPrint

		#region OutputsDocumentsPrint

		private void OutputDocumentBill(bool bAll, string sMode)
		{
			if (dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

            LogService.OutputDocumentBill_Print(oOutputDocumentPrint, sMode.ToUpper(), this, false, (0 == 1));
		}

		private void OutputDocumentVeterinary(bool bAll)
		{
			// список
			if (dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentVeterinary_Print(oOutputDocumentPrint, true, this);
		}

		private void OutputDocumentQuality(bool bAll)
		{
			if (dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentQuality_Print(oOutputDocumentPrint, this);
		}

		private void OutputDocumentWarrant(bool bAll)
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
			if (dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, bAll);

			LogService.OutputDocumentVeterinaryBlank_Print(oOutputDocumentPrint, bGroupByPartner, this);
		}

		private void OutputDocumentVeterinaryBlankData()
		{
			// бланки
			if (dgvOutputsDocuments.CurrentRow == null)
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
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;

			LogService.OutputDocumentTtn_Print(oOutputDocumentPrint, this);
		}

		private void OutputDocumentPayBill()
		{
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;

            LogService.OutputDocumentBill_Print(oOutputDocumentPrint, "INVOICE", this, false, (0 == 1));
		}

		private void OutputDocumentInnerMovingBill()
		{
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;

            LogService.OutputDocumentBill_Print(oOutputDocumentPrint, "InnerMovingBill", this, false, (0 == 1));
		}

		private void OutputDocumentTransport()
		{
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;

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
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null)
				return;

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;

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
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
				return;

			LogService.OutputDocumentBill_Print_Report(oOutputDocumentCur, new facturePerversion(), this);
		}

		private void mniOutputsDocumentsPrintBillPerversion_Click(object sender, EventArgs e)
		{
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
				return;

			LogService.OutputDocumentBill_Print_Report(oOutputDocumentCur, new billPerversion(), this);
		}

		private void mniOutputsDocumentsPrintMX3_All_Click(object sender, EventArgs e)
		{
			if (dgvOutputsDocuments.Rows.Count == 0)
				return;

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentPrint, true);

			LogService.OutputDocumentMX3_Print(oOutputDocumentPrint, false, this);
		}

		private void mniOutputsDocumentsPrintMX3_One_Click(object sender, EventArgs e)
		{
			if (dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null ||
				oOutputDocumentCur.ID == null)
				return;

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ID = oOutputDocumentCur.ID;

			LogService.OutputDocumentMX3_Print(oOutputDocumentPrint, false, this);
		}

		#endregion OutputsDocumentsPrint

		#region OutputsDocumentPrintMenu_Click

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

		private void mniOutputsDocumentsPrintTransport_Click(object sender, EventArgs e)
		{
			OutputDocumentTransport();
		}

		private void mniOutputsDocumentsPrintVeterinaryPayment_Click(object sender, EventArgs e)
		{
			OutputDocumentVeterinaryPayment();
		}

	#endregion OutputsDocumentPrintMenu_Click

	#region MovingDocument

		private void mniMovingDocumentsPrint_Bill_Click(object sender, EventArgs e)
		{
			MovingDocumentBill();
		}

		private void MovingDocumentBill()
		{
			if (dgvMovingsDocuments.CurrentRow == null ||
				!oMovingDocumentCur.ID.HasValue)
				return;

			MovingDocument oMovingDocumentPrint = new MovingDocument();
			oMovingDocumentPrint.ReFillOne((int)oMovingDocumentCur.ID);
			LogService.MovingDocumentBill_Print(oMovingDocumentPrint, this);
		}

		private void mniMovingDocumentsPrint_MX1_Click(object sender, EventArgs e)
		{
			if (dgvMovingsDocuments.CurrentRow == null ||
				dgvMovingsDocuments.IsStatusRow(dgvMovingsDocuments.CurrentRow.Index) ||
				!oMovingDocumentCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			MovingDocument oMovingDocumentPrint = new MovingDocument();
			oMovingDocumentPrint.ReFillOne((int)oMovingDocumentCur.ID);

			// можно проверить, что это - прием на хранение (~Input)

			LogService.MovingDocumentBillMX1_Print(oMovingDocumentPrint, this);
		}

		private void mniMovingDocumentsPrint_MX3_Click(object sender, EventArgs e)
		{
			if (dgvMovingsDocuments.Rows.Count == 0)
				return;

			RFMCursorWait.Set(true);

			MovingDocument oMovingDocumentPrint = new MovingDocument();

			if (dgvMovingsDocuments.IsCheckerShow && dgvMovingsDocuments.MarkedCount > 0)
			{
				oMovingDocumentPrint.IDList = "";

				DataView dMarked = new DataView(oMovingDocumentsList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = dgvMovingsDocuments.GridSource.Sort;
				int nOwnerTargetID = Convert.ToInt32(dMarked[0]["OwnerTargetID"]);
				bool bDiffOwners = false;
				foreach (DataRowView r in dMarked)
				{
					if (!Convert.IsDBNull(r["ID"]))
					{
						oMovingDocumentPrint.IDList = oMovingDocumentPrint.IDList + r["ID"].ToString() + ",";
						if (Convert.ToInt32(r["OwnerTargetID"]) != nOwnerTargetID) 
							bDiffOwners	= true;
					}
				}

				if (RFMMessage.MessageBoxYesNo("Отмечены документарные перемещения: " + dMarked.Count.ToString().Trim() + ".\n\n" +
					(bDiffOwners ? "ВНИМАНИЕ! В перемещениях разные получатели!\n\n" : "") + 
					"Формировать единый документ для отмеченных перемещений?") == DialogResult.No)
					return;
			}
			else
			{
				oMovingDocumentPrint.ID = oMovingDocumentCur.ID;
			}

			LogService.MovingDocumentBillMX3_Print(oMovingDocumentPrint, this);
		}

		#endregion MovingDocument

	#endregion Menu Print

	#region Menu Service

		#region Inputs

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}
		
		#region ChangeDate

		private void InputsChangeDate()
		{
			if (dgvInputs.DataSource == null ||
				dgvInputs.Rows.Count == 0 ||
				dgvInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			oInputCur.ReFillOne((int)oInputCur.ID);

			if (oInputCur.TripExists)
			{
				RFMMessage.MessageBoxError("Задание на приход привязано к рейсу.\n" +
						"Смена даты не выполняется.");
				return; 
			}
			if (oInputCur.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Задание на приход уже подтверждено.\n" +
						"Смена даты не выполняется.");
				return;
			}
			if (oInputCur.InputsDocumentsExists)
			{
				RFMMessage.MessageBoxError("Для задания на приход уже оформлены приходные документы.\n" +
						"Смена даты не выполняется.");
				return;
			}
			
			if (RFMMessage.MessageBoxYesNo("Сменить дату задания на приход?") == DialogResult.Yes)
			{
				// новая дата
				DateTime dNewDate = oInputCur.DateInput;
				if (StartForm(new frmInputBoxDate("Новая дата прихода:", dNewDate)) == DialogResult.Yes)
				{
					if (GotParam[0] != null)
					{
						dNewDate = Convert.ToDateTime(GotParam[0]);
					}
					if (dNewDate.CompareTo(oInputCur.DateInput) == 0)
					{
						RFMMessage.MessageBoxError("Указана та же дата...");
						return;
					}
					if (dNewDate.CompareTo(DateTime.Now.Date) < 0)
					{
						RFMMessage.MessageBoxError("Указана прошедшая дата...");
						return;
					}

					if (oInputCur.ChangeDate((int)oInputCur.ID, dNewDate) && oInputCur.ErrorNumber == 0)
					{ 
						//RFMMessage.MessageBoxInfo("Задание на приход перенесено на другую дату.");
						dgvInputs_Restore();
					}
				}
			}
		}

		#endregion ChangeDate
	
		#region Set DeliveryNeed

		private void OutputsSetDeliveryNeed(bool bSet)
		{
			if (dgvOutputsDocuments.DataSource == null ||
				dgvOutputsDocuments.Rows.Count == 0 ||
				dgvOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
				return;

			int nOutputID = (int)oOutputDocumentCur.ID; 
			Output oOutputTemp = new Output();
			oOutputTemp.ReFillOne((int)oOutputDocumentCur.ID);
			/*
			if (oOutputTemp.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Задание на расход уже подтверждено...");
				return;
			}
			*/ 
			if (oOutputTemp.TripID.HasValue)
			{
				RFMMessage.MessageBoxError("Задание на расход уже прикреплено к рейсу...");
				return;
			}
			/*
			if (oOutputTemp.ReadyForWMS)
			{
				RFMMessage.MessageBoxError("Задание на расход уже готово для передачи в складскую систему...");
				return;
			}
			if (oOutputTemp.SentToWMS)
			{
				RFMMessage.MessageBoxError("Задание на расход уже передано в складскую систему...");
				return;
			}
			*/ 

			if (bSet)
			{
				if (oOutputDocumentCur.DeliveryNeed)
				{
					RFMMessage.MessageBoxError("Задание на расход требует доставки...");
					return;
				}

				// ставим признак
				RFMCursorWait.Set(true);
				oOutputTemp.SetDeliveryNeed(nOutputID);
			}
			else
			{
				if (!oOutputDocumentCur.DeliveryNeed)
				{
					RFMMessage.MessageBoxError("Задание на расход не требует доставки...");
					return;
				}

				// снимаем признак
				RFMCursorWait.Set(true);
				oOutputTemp.SetDeliveryNeed(nOutputID, true, null);
			}
			RFMCursorWait.Set(false);

			dgvOutputsDocuments_Restore();
		}

		private void InputsSetDeliveryNeed(bool bSet)
		{
			if (dgvInputs.DataSource == null ||
				dgvInputs.Rows.Count == 0 ||
				dgvInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			int nInputID = (int)oInputCur.ID; 
			Input oInputTemp = new Input();
			oInputTemp.ReFillOne(nInputID);
			/*
			if (oInputTemp.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Задание на приход уже подтверждено...");
				return;
			}
			*/ 
			if (oInputTemp.TripID.HasValue)
			{
				RFMMessage.MessageBoxError("Задание на приход уже прикреплено к рейсу...");
				return;
			}
			/*
			if (oInputTemp.ReadyForWMS)
			{
				RFMMessage.MessageBoxError("Задание на приход уже готово для передачи в складскую систему...");
				return;
			}
			if (oInputTemp.SentToWMS)
			{
				RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему...");
				return;
			}
			*/

			if (bSet)
			{
				if (oInputCur.DeliveryNeed)
				{
					RFMMessage.MessageBoxError("Задание на приход требует доставки...");
					return;
				}

				// ставим признак
				RFMCursorWait.Set(true);
				oInputTemp.SetDeliveryNeed(nInputID);
			}
			else
			{
				if (!oInputCur.DeliveryNeed)
				{
					RFMMessage.MessageBoxError("Задание на приход не требует доставки...");
					return;
				}

				// снимаем признак
				RFMCursorWait.Set(true);
				oInputTemp.SetDeliveryNeed(nInputID, true, null);
			}
			RFMCursorWait.Set(false);

			dgvInputs_Restore();
		}

		#endregion Set DeliveryNeed
		
		#region InputsDocumentsCreateFromInputs

		private void InputsDocumentsCreateFromInputs()
		{
			if (dgvInputs.DataSource == null ||
				dgvInputs.Rows.Count == 0 ||
				dgvInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			oInputCur.ReFillOne((int)oInputCur.ID);

			if (oInputCur.TripExists)
			{
				Trip oTripForInputDocument = new Trip();
				oTripForInputDocument.ReFillOne((int)oInputCur.TripID);
				if (!oTripForInputDocument.DateBeg.HasValue)
				{
					RFMMessage.MessageBoxError("Рейс, к которому привязано задание на приход, еще не начат...");
					return; 
				}
			}

			InputDocument oInputDocument = new InputDocument();
			oInputDocument.FilterInputsList = oInputCur.ID.ToString();
			oInputDocument.FillData();
			if (oInputDocument.MainTable == null)
				return;

			bool bAdd = false;
			if (oInputDocument.MainTable.Rows.Count == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Создать приходный документ на основе задания на приход?") == DialogResult.Yes)
				{
					bAdd = true;
				}
			}
			else
			{
				if (RFMMessage.MessageBoxYesNo("Для задания на приход уже существуют приходные документы (" + oInputDocument.MainTable.Rows.Count.ToString() + ").\n" +
					"Все-таки добавить еще один документ?") == DialogResult.Yes)
				{
					bAdd = true;
				}
			}

			if (bAdd)
			{
				/*
				oInputCur.InputsDocumentsCreateFromInputs((int)oInputCur.ID, ref nNewInputDocumentID);
				if (nNewInputDocumentID.HasValue)
				{
					if (StartForm(new frmInputsDocumentsEdit((int)nNewInputDocumentID)) == DialogResult.Yes)
					{
						dgvInputs_Restore();
					}
				}
				*/
				if (StartForm(new frmInputsDocumentsEdit((int)oInputCur.ID, 0)) == DialogResult.Yes)
				{
					dgvInputs_Restore();
				}
			}
		}

		#endregion InputsDocumentsCreateFromInputs

		#region InputsUpdateFromInputsDocuments

		private void InputsUpdateFromInputsDocuments()
		{
			if (dgvInputs.DataSource == null ||
				dgvInputs.Rows.Count == 0 ||
				dgvInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			oInputCur.ReFillOne((int)oInputCur.ID);

			if (!oInputCur.InputsDocumentsExists)
			{
				RFMMessage.MessageBoxError("Задание на приход не имеет приходных документов...");
				return;
			}

			oInputCur.UpdateFromInputsDocuments((int)oInputCur.ID); 
			dgvInputs_Restore();
		}

		#endregion InputsUpdateFromInputsDocuments

		#region Acts

		private void CreateAct()
		{
			int nActID = 0;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("INPUTS"))
			{
				if (dgvInputs.DataSource == null ||
					dgvInputs.Rows.Count == 0 ||
					dgvInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				oInputCur.ReFillOne((int)oInputCur.ID);
				if (!oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход не подтверждено.\nВвод акта невозможен.");
					return;
				}
				if (oInputCur.TripExists)
				{
					Trip oTripInputAct = new Trip();
					oTripInputAct.ReFillOne((int)oInputCur.TripID);
					if (oTripInputAct.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Рейс, в который включено задание на приход, уже подтвержден.\r\nВвод акта невозможен.");
						return;
					}
				}
				if (oInputCur.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("Для складского задания уже существует акт.\nСоздать еще один акт?") != DialogResult.Yes)
						return;
				}

				if (StartForm(new frmActsEdit(nActID, (int)oInputCur.ID, null)) == DialogResult.Yes)
				{
					dgvInputs_Restore();
				}
			}
		}

		#endregion Acts
		
		#endregion Inputs

		#region OutputsDocumentsService

		private void OutputsDocumentsUnConfirm()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
					dgvOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsBringZero()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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

				dgvOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsUnBring()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
					dgvOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsConfirmZero()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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

			// задание - не подтверждено, не послано в WMS
			if (!oOutputDocumentCur.IsOutputExists)
			{
				RFMMessage.MessageBoxError("Для данного расходного документа еще не создано задание на расход...");
				return;
			}
 
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
			oOutputDocumentOthers.FillData();
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
			oOutputDocumentAlso.FillData();
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
			oInputAlso.FillData();
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

			dgvOutputsDocuments_Restore();
		}

		private void OutputsDocumentsWarrantClear()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
					dgvOutputsDocuments_Restore();
				}
			}
        }

        #region Additional - коды связанных записей (декларации соответствия, ветеринарные свидетельства, ...)

        private void OutputsDocumentsAdditionalSet()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
				dgvOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsFailReasonChange()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
					dgvOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsGoodReturnReasonChange()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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

			RFMDataGridView dgv = dgvOutputsDocumentsGoods;
			if (dgv.Rows.Count == 0 ||
				dgv.DataSource == null ||
				dgv.CurrentRow == null)
				return;

			if (!LastGrid.Name.ToUpper().Contains(dgv.Name.ToUpper()) ||
				dgv.IsStatusRow(dgv.CurrentRow.Index))
			{
				RFMMessage.MessageBoxAttention("Для регистрации причины возврата следует перейти в таблицу товаров в расходном документе и выбрать товар.");
				return;
			}

			DataRow r = ((DataRowView)((DataGridViewRow)dgvOutputsDocumentsGoods.Rows[dgvOutputsDocumentsGoods.CurrentRow.Index]).DataBoundItem).Row;
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
					dgvOutputsDocuments_Restore();
				}
			}
		}

		private void OutputsDocumentsGuiltyEmployees()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
				dgvOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsAdditionalClear()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
				dgvOutputsDocuments_Restore();
			}
		}

		private void OutputsDocumentsVeterinaryClear()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
				dgvOutputsDocuments_Restore();
			}
		}

		#region Service VeterinaryBlankData NEW

		private void VeterinaryBlankData()
		{
			if (dgvOutputsDocuments.CurrentRow == null)
				return;

			if (!oOutputDocumentCur.ID.HasValue)
				return;

			bool bAll = (dgvOutputsDocuments.IsCheckerInclude && dgvOutputsDocuments.IsCheckerShow && dgvOutputsDocuments.MarkedCount > 0);
			OutputDocument oOutputDocumentVeterinaryBlank = new OutputDocument();
			OutputsDocumentsPrepareIDList(oOutputDocumentVeterinaryBlank, bAll);
			oOutputDocumentVeterinaryBlank.FillData();
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
				dgvOutputsDocuments_Restore();
			}
		}

		#endregion Service VeterinaryBlankData NEW

		private void OutputsDocumentsVeterinaryLicenceNeed(bool bSet)
		{
			if (dgvOutputsDocuments.CurrentRow == null)
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
			dgvOutputsDocuments_Restore();
		}

		#endregion Additional



		#endregion OutputsDocumentsService

		#region OutputsDocumentsService_Click

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
				//	oOutputDocumentCur.ID = (int?)dgvOutputsDocuments.CurrentRow.Cells["dgvcOutputsDocuments_ID"].Value;
				dgvOutputsDocumnetsGoods_Restore();
			}
		}

		#endregion OutputsDocumentsService_Click

	#endregion Menu Service

	#region Filters Choose

	#region Common Filters
		
		private void GetCommonFilters()
		{
			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oOutputDocumentsList.FilterDateBeg = 
				oInputList.FilterDateBeg = 
				oMovingDocumentsList.FilterDateBeg = 
					dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oOutputDocumentsList.FilterDateEnd = 
				oInputList.FilterDateEnd = 
				oMovingDocumentsList.FilterDateEnd = 
					dtrDates.dtpEndDate.Value.Date;
			}

			// владельцы
			if (ucSelectRecordIDForm_Owners.IsSelectedExist)
			{
				oOutputDocumentsList.FilterOwnersList = 
				oInputList.FilterOwnersList = 
					ucSelectRecordIDForm_Owners.GetIdString();
			}

			//  хосты
			if (nUserHostID.HasValue)
			{
				oOutputDocumentsList.FilterHostsList =
				oInputList.FilterHostsList =
				oMovingDocumentsList.FilterHostsList =
					nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oOutputDocumentsList.FilterHostsList =
					oInputList.FilterHostsList =
					oMovingDocumentsList.FilterHostsList =
						ucSelectRecordID_Hosts.GetIdString();
				}
			}

			//  подтверждение 
			if (optIsConfirmedNot.Checked)
			{
				oOutputDocumentsList.FilterIsConfirmed = 
				oInputList.FilterIsConfirmed = 
				oMovingDocumentsList.FilterIsConfirmed = 
					false;
			}
			if (optIsConfirmed.Checked)
			{
				oOutputDocumentsList.FilterIsConfirmed = 
				oInputList.FilterIsConfirmed = 
				oMovingDocumentsList.FilterIsConfirmed = 
					true;
			}

			// выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oOutputDocumentsList.FilterPackingsList = 
				oInputList.FilterPackingsList = 
				oMovingDocumentsList.FilterPackingsList =
					ucSelectRecordIDForm_Packings.GetIdString();
			}
		}

	#endregion Common Filters

	#region InputsTypes

        private void ucSelectRecordID_InputsTypes_Restore()
        {
            if (ucSelectRecordID_InputsTypes.sourceData == null)
            {
				if (Utilities.FillData_InputsTypes(oInputList))
				{
					ucSelectRecordID_InputsTypes.Restore(oInputList.TableInputsTypes);
				}
            }
            else
            {
                ucSelectRecordID_InputsTypes.Restore();
            }
		}

	#endregion InputsTypes

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

	#region uc_Forms

		private void ucSelectRecordIDForm_OutputsDocumentsPartners_Restore()
		{
			ucSelectRecordIDForm_OutputsDocumentsPartners.SendParams = new object[] { ucSelectRecordIDForm_OutputsDocumentsPartners, true };
			ucSelectRecordIDForm_OutputsDocumentsPartners.Restore();
		}

		private void ucSelectRecordIDForm_Owners_Restore()
		{
			ucSelectRecordIDForm_Owners.SendParams = new object[] { ucSelectRecordIDForm_Owners, true, true };
			ucSelectRecordIDForm_Owners.Restore();
		}

		private void ucSelectRecordIDForm_InputsPartners_Restore()
		{
			ucSelectRecordIDForm_InputsPartners.SendParams = new object[] { ucSelectRecordIDForm_InputsPartners, true };
			ucSelectRecordIDForm_InputsPartners.Restore();
		}

		private void ucSelectRecordIDForm_MovingsOwnerSource_Restore()
		{
			ucSelectRecordIDForm_MovingsOwnerSource.SendParams = new object[] { ucSelectRecordIDForm_MovingsOwnerSource, true };
			ucSelectRecordIDForm_MovingsOwnerSource.Restore();
		}

		private void ucSelectRecordIDForm_MovingsOwnerTarget_Restore()
		{
			ucSelectRecordIDForm_MovingsOwnerTarget.SendParams = new object[] { ucSelectRecordIDForm_MovingsOwnerTarget, true };
			ucSelectRecordIDForm_MovingsOwnerTarget.Restore();
		}

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

	#endregion uc_Forms

	#endregion Filters Choose

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(-1).Date;
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(2).Date;

			optIsConfirmedAll.Checked = true;

            ucSelectRecordIDForm_Owners.ClearData();

			optDeliveryNeedAll.Checked = true;
			ucSelectRecordIDForm_OutputsDocumentsPartners.ClearData();

            ucSelectRecordID_InputsTypes.ClearData();
            ucSelectRecordIDForm_InputsPartners.ClearData();

			ucSelectRecordIDForm_MovingsOwnerSource.ClearData();
			ucSelectRecordIDForm_MovingsOwnerTarget.ClearData();

			ucSelectRecordIDForm_Packings.ClearData();
			chkShowSelectedGoodsOnly.Checked =
			chkShowSelectedGoodsOnly.Enabled =
				false;

			ucSelectRecordID_Hosts.ClearData();

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
				optIsConfirmedAll.Checked = true;
			}

			tabOutputsDocuments.IsNeedRestore = 
			tabInputs.IsNeedRestore = 
			tabMovingsDocuments.IsNeedRestore =	
				true;
		}

	#endregion Terms clear

    }
}