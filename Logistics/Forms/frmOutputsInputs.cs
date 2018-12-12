using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DataDynamics.ActiveReports;

using RFMBaseClasses;
using LogBizObjects;
using RFMPublic;

namespace Logistics
{
	public partial class frmOutputsInputs : RFMFormChild
	{
		private Output oOutputList; //список расходов
		private Output oOutputCur; //текущий расход

		private OutputDocument oOutputDocumentInOutput;
		private Act oActForOutput;

		private Input oInputList; //список приходов
		private Input oInputCur; //текущий приход

		private InputDocument oInputDocumentInInput;
		private Act oActForInput;

		private TripReturn oTripReturnList; //список возвратов
		private TripReturn oTripReturnCur; //текущий возврат

		private Host oHost;
		private int? nUserHostID = null;


		public frmOutputsInputs()
		{
			oOutputList = new Output();
			oOutputCur = new Output();
			if (oOutputList.ErrorNumber != 0 ||
				oOutputCur.ErrorNumber != 0)
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
				oOutputDocumentInOutput = new OutputDocument();
				if (oOutputDocumentInOutput.ErrorNumber != 0)
				{
					IsValid = false;
				}

				if (IsValid)
				{
					oActForOutput = new Act();
					if (oActForOutput.ErrorNumber != 0)
					{
						IsValid = false;
					}
				}
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

			oTripReturnList = new TripReturn();
			oTripReturnCur = new TripReturn();
			if (oTripReturnList.ErrorNumber != 0 ||
				oTripReturnCur.ErrorNumber != 0)
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


		private void frmOutputsInputs_Load(object sender, EventArgs e)
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
			grdOutputs.IsStatusShow =
			grdOutputsGoods.IsStatusShow =
			grdOutputsDocuments.IsStatusShow =
			grdOutputsActs.IsStatusShow =
			grdInputs.IsStatusShow =
			grdInputsGoods.IsStatusShow =
			grdInputsDocuments.IsStatusShow =
			grdInputsActs.IsStatusShow =
			grdTripsReturns.IsStatusShow =
			grdTripsReturnsGoods.IsStatusShow =
				true;

			btnClearTerms_Click(null, null);

			tcList.Init();
			tcInputsGoods.Init();
			tcOutputsGoods.Init();
			tcTripsReturnsGoods.Init();

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

		private bool tabOutputs_Restore()
		{
			grdOutputs_Restore();
			btnAdd.Enabled =
			btnEdit.Enabled = 
			btnDelete.Enabled = 
				false;
			if (grdOutputs.Rows.Count > 0)
			{
				// WMS
				btnConfirm.Enabled = false;
				// end WMS

				btnPrint.Enabled =
				btnService.Enabled = 
					true;

				grdOutputs.Select();
			}
			else
			{
				// WMS
				btnConfirm.Enabled = false;
				// end WMS

				btnPrint.Enabled =
				btnService.Enabled = 
					false;
			}
			return (true);
		}

		private bool tabInputs_Restore()
		{
			grdInputs_Restore();
			btnAdd.Enabled = false;
			if (grdInputs.Rows.Count > 0)
			{
				btnEdit.Enabled = 
				btnDelete.Enabled =
					true;
				// WMS
                btnConfirm.Enabled = false;
				// end WMS

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				grdInputs.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				// WMS
				btnConfirm.Enabled = false;
				// end WMS

				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		private bool tabTripsReturns_Restore()
		{
			grdTripsReturns_Restore();
			btnAdd.Enabled = true;
			if (grdTripsReturns.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					true;
				// WMS
                btnConfirm.Enabled = false;
				// end WMS

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				grdTripsReturns.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
				// WMS
				btnConfirm.Enabled = false;
				// end WMS

				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}
			return (true);
		}

		#endregion Top Tabs

		#region Bottom Tabs

		private bool tabOutputsGoods_Restore()
		{
			return grdOutputsGoods_Restore();
		}

		private bool tabOutputsDocuments_Restore()
		{
			return grdOutputsDocuments_Restore();
		}

		private bool tabOutputsActs_Restore()
		{
			return grdOutputsActs_Restore();
		}

		private bool tabInputsGoods_Restore()
		{
			return grdInputsGoods_Restore();
		}

		private bool tabInputsDocuments_Restore()
		{
			return grdInputsDocuments_Restore();
		}

		private bool tabInputsActs_Restore()
		{
			return grdInputsActs_Restore();
		}

		private bool tabTripsReturnsGoods_Restore()
		{
			return grdTripsReturnsGoods_Restore();
		}

		#endregion Bottom Tabs

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnAdd.Enabled =
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnConfirm.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.DataSource == null ||
					grdOutputs.Rows.Count == 0)
					return;

				btnService.ShortCutSet(mnuOutputsService);
				btnPrint.ShortCutSet(mnuOutputsPrint);

				btnAdd.Enabled = false;
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					(grdOutputs.Rows.Count > 0);
				btnConfirm.Enabled = false;

				grdOutputs.Select();
			}

			if (sPageName.Contains("INPUT"))
			{
				if (grdInputs.DataSource == null ||
					grdInputs.Rows.Count == 0)
					return;

				btnService.ShortCutSet(mnuInputsService);
				btnPrint.ShortCutSet(mnuInputsPrint);

				btnAdd.Enabled = false;
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					(grdInputs.Rows.Count > 0);
				btnConfirm.Enabled = false;

				grdInputs.Select();
			}

			if (sPageName.Contains("RETURNS"))
			{
				if (grdTripsReturns.DataSource == null ||
					grdTripsReturns.Rows.Count == 0)
					return;

				btnService.ShortCutSet(mnuTripsReturnsService);
				btnPrint.ShortCutSet(mnuTripsReturnsPrint);

				btnAdd.Enabled = false;
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					(grdTripsReturns.Rows.Count > 0);
				btnConfirm.Enabled = false;

				grdTripsReturns.Select();
			}
		}

	#endregion Tab restore

	#region PrepareIDList

		public void OutputPrepareIDList(Output oOutput, bool bMultiSelect)
		{
			oOutput.ID = null;
			oOutput.IDList = null;
			int? nOutputID = 0;
			if (bMultiSelect && grdOutputs.IsCheckerShow)
			{
				oOutput.IDList = "";

				DataView dMarked = new DataView(oOutputList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdOutputs.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nOutputID = (int)r["ID"];
						oOutput.IDList = oOutput.IDList + nOutputID.ToString() + ",";
					}
				}
			}
			else
			{
				nOutputID = (int?)grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value;
				if (nOutputID.HasValue)
				{
					oOutput.ID = nOutputID;
				}
			}
		}

		public void InputPrepareIDList(Input oInput, bool bMultiSelect)
		{
			oInput.ID = null;
			oInput.IDList = null;
			int? nInputID = 0;
			if (bMultiSelect && grdInputs.IsCheckerShow)
			{
				oInput.IDList = "";

				DataView dMarked = new DataView(oInputList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdInputs.GridSource.Sort; 
				foreach (DataRowView r in dMarked)
				{
				    if (!Convert.IsDBNull(r["ID"]))
				    {
						nInputID = (int)r["ID"];
						oInput.IDList = oInput.IDList + nInputID.ToString() + ",";
					}
				}
			}
			else
			{
				nInputID = (int?)grdInputs.CurrentRow.Cells["grcInputs_ID"].Value;
				if (nInputID.HasValue)
				{
					oInput.ID = nInputID;
				}
			}
		}

		public void TripReturnPrepareIDList(TripReturn oTripReturn, bool bMultiSelect)
		{
			oTripReturn.ID = null;
			oTripReturn.IDList = null;
			int? nTripReturnID = 0;
			if (bMultiSelect && grdTripsReturns.IsCheckerShow)
			{
				oTripReturn.IDList = "";

				DataView dMarked = new DataView(oTripReturnList.MainTable);
				dMarked.RowFilter = "IsMarked = true";
				dMarked.Sort = grdTripsReturns.GridSource.Sort;
				foreach (DataRowView r in dMarked)
				{
					if (!Convert.IsDBNull(r["ID"]))
					{
						nTripReturnID = (int)r["ID"];
						oTripReturn.IDList = oTripReturn.IDList + nTripReturnID.ToString() + ",";
					}
				}
			}
			else
			{
				nTripReturnID = (int?)grdTripsReturns.CurrentRow.Cells["grcTripsReturns_ID"].Value;
				if (nTripReturnID.HasValue)
				{
					oTripReturn.ID = nTripReturnID;
				}
			}
		}


	#endregion PrepareIDList

	#region RowEnter, CellFormatting

		private void grdOutputs_CurrentRowChanged(object sender)
		{
			if (grdOutputs.IsLockRowChanged || 
				grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index))
				return;
			tmrRestore.Enabled = true;
		}

		private void grdInputs_CurrentRowChanged(object sender)
		{
			if (grdInputs.IsLockRowChanged ||
				grdInputs.IsStatusRow(grdInputs.CurrentRow.Index))
				return;
			tmrRestore.Enabled = true;
		}

		private void grdTripsReturns_CurrentRowChanged(object sender)
		{
			if (grdTripsReturns.IsLockRowChanged ||
				grdTripsReturns.IsStatusRow(grdTripsReturns.CurrentRow.Index))
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView grd = new RFMDataGridView();

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				grd = grdOutputs;
			}
			if (sPageName.Contains("INPUTS"))
			{
				grd = grdInputs;
			}
			if (sPageName.Contains("RETURNS"))
			{
				grd = grdTripsReturns;
			}

			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;

			if (sPageName.Contains("OUTPUTS"))
			{
				btnAdd.Enabled =
				btnEdit.Enabled = 
				btnDelete.Enabled = 
					false;
				if (grd.IsStatusRow(rowIndex))
				{
					oOutputCur.ClearOne();
					btnPrint.Enabled =
					btnService.Enabled =
						false;
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oOutputCur.FillOne(r);

					//btnConfirm.Enabled = !oOutputCur.IsConfirmed; // WMS!
                    btnConfirm.Enabled = false;

					btnPrint.Enabled =
					btnService.Enabled =
						true;
					
					mniOutputsPrintBill.Enabled = true;

					mniOutputsServiceChangeDate.Enabled = true;

					mniOutputsServiceSetReadyForWMS.Enabled = true; //!oOutputCur.ReadyForWMS; // массовая операция
					mniOutputsServiceClearReadyForWMS.Enabled = true; // oOutputCur.ReadyForWMS; // массовая операция

					mniOutputsServiceSetDeliveryNeed.Enabled = !oOutputCur.DeliveryNeed && !oOutputCur.TripExists;
					mniOutputsServiceClearDeliveryNeed.Enabled = oOutputCur.DeliveryNeed && !oOutputCur.TripExists;
					
					mniOutputsServiceCreateAct.Enabled = oOutputCur.IsConfirmed;

					//mniOutputsServiceUnConfirm.Enabled = oOutputCur.IsConfirmed; // WMS!
					mniOutputsServiceUnConfirm.Enabled = false; 
				}
				tcOutputsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("INPUTS"))
			{
				btnAdd.Enabled = 
				btnDelete.Enabled =
					false;
				if (grd.IsStatusRow(rowIndex))
				{
					oInputCur.ClearOne();
					btnPrint.Enabled =
					btnService.Enabled =
						false;
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oInputCur.FillOne(r);
					btnEdit.Enabled = !oInputCur.IsConfirmed && !oOutputCur.ReadyForWMS;
					
                    //btnConfirm.Enabled = !oInputCur.IsConfirmed; // WMS!
                    btnConfirm.Enabled = false;

                    btnPrint.Enabled =
					btnService.Enabled =
						true;

					mniInputsPrintBillWithAct.Enabled = true;
					mniInputsPrintBillMX1.Enabled = true;

					mniInputsServiceChangeDate.Enabled =
					mniInputsServiceInputsDocumentsCreateFromInputs.Enabled =
					mniInputsServiceUpdateFromInputsDocuments.Enabled =
					mniInputsServiceQualityData.Enabled =
					mniInputsServiceVeterinaryData.Enabled =
						true;

					mniInputsServiceSetReadyForWMS.Enabled = true; // !oInputCur.ReadyForWMS; // массовая операция
					mniInputsServiceClearReadyForWMS.Enabled = true; // oInputCur.ReadyForWMS; // массовая операция
 
					mniInputsServiceSetDeliveryNeed.Enabled = !oInputCur.DeliveryNeed && !oInputCur.TripExists;
					mniInputsServiceClearDeliveryNeed.Enabled = oInputCur.DeliveryNeed && !oInputCur.TripExists;
 
					mniInputsServiceCreateAct.Enabled = oInputCur.IsConfirmed;

					//mniInputsServiceUnConfirm.Enabled = oInputCur.IsConfirmed; // WMS!
					mniInputsServiceUnConfirm.Enabled = false;
				}
				tcInputsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("RETURNS"))
			{
				btnAdd.Enabled = false;
				if (grd.IsStatusRow(rowIndex))
				{
					oTripReturnCur.ClearOne();
					btnPrint.Enabled =
					btnService.Enabled =
						false;
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oTripReturnCur.FillOne(r);
					btnEdit.Enabled = !oTripReturnCur.IsConfirmed && !oTripReturnCur.ReadyForWMS;
					btnDelete.Enabled = !oTripReturnCur.IsConfirmed && !oTripReturnCur.ReadyForWMS;
					
                    //btnConfirm.Enabled = !oTripReturnCur.IsConfirmed; // WMS!
                    btnConfirm.Enabled = false;

                    btnPrint.Enabled =
					btnService.Enabled =
						true;

					mniTripsReturnsPrintBill.Enabled = true;

					mniTripsReturnsServiceSetReadyForWMS.Enabled = true; // !oTripReturnCur.ReadyForWMS; // массовая операция
					mniTripsReturnsServiceClearReadyForWMS.Enabled = true; // oTripReturnCur.ReadyForWMS; // массовая операция
					
					// mniTripsReturnsServiceUnConfirm.Enabled = oTripReturnCur.IsConfirmed; // WMS!
					mniTripsReturnsServiceUnConfirm.Enabled = false;
				}
				tcTripsReturnsGoods.SetAllNeedRestore(true);
			}
		}

		private void grdOutputs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)grd.Rows[e.RowIndex].DataBoundItem).Row;

			// подтверждение отгрузки / приема на складе
			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					if (sGridName.Contains("PUT"))
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

			// передача в WMS
			if (sColumnName.Contains("ReadyForWMSImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Plain_GD;
				}
				else
				{
                    if (sGridName.Contains("OUTPUT") && r["DatePick"].ToString().Length > 0)
                    {
                        e.Value = Properties.Resources.Plain_G;
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
			}

			// нетто-брутто
			if ((sColumnName.Contains("TTO") || sColumnName.Contains("QNT")) &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			// перенос
			if (sGridName.Contains("OUTPUT"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOutputID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if (sGridName.Contains("INPUTS"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			// копирование
			if (sGridName.Contains("PUT"))
			{
				if ((bool)r["IsCopied"])
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
				}
			}

			// перенесенные на другой рейс
			// ...
		}

		private void grdOutputsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
				if ((decimal)r["QntConfirmed"] == 0)
				{
					e.Value = Properties.Resources.DotRed;
				}
				else
				{
                    if (sColumnName.Contains("OUTPUT") || sColumnName.Contains("RETURN"))
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
                    if (sColumnName.Contains("INPUT"))
                    {
                        if ((decimal)r["QntDocuments"] == (decimal)r["QntConfirmed"])
                        {
                            e.Value = Properties.Resources.DotGreen;
                        }
                        else
                        {
                            if ((decimal)r["QntDocuments"] < (decimal)r["QntConfirmed"])
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
			}

			if (sColumnName.Contains("QNT") ||
				sColumnName.Contains("INBOX"))
			{
				if ((!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"]) ||
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

			// только для расходных документов
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
			if ((sColumnName.Contains("TTO") || sColumnName.Contains("AMOUNT")) &&
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

			// скопированные из задания
			// ...
		}

		private void grdOutputsActs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

			if (sColumnName.Contains("QNT") ||
				sColumnName.Contains("INBOX"))
			{
				if ((!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"]) || 
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

	#endregion Cells...

	#region Restore

		#region Outputs

		private bool grdOutputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputCur.ClearOne();

			oOutputList.ClearError();
			oOutputList.ClearFilters();
			oOutputList.ID = null;
			oOutputList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oOutputList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oOutputList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oOutputList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oOutputList.FilterDeliveryNeed = false;
			}

			// типы расходов
			if (ucSelectRecordID_OutputsTypes.IsSelectedExist)
			{
				oOutputList.FilterOutputsTypesList = ucSelectRecordID_OutputsTypes.GetIdString();
			}

			// получатели
			if (ucSelectRecordID_OutputsPartners.IsSelectedExist)
			{
				oOutputList.FilterPartnersList = ucSelectRecordID_OutputsPartners.GetIdString();
			}

			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oOutputList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oOutputList.FilterPackingsList = ucSelectRecordIDForm_Packings.GetIdString();
			}

			// расход привязан к рейсу
			if (optTripExistsNot.Checked)
			{
				oOutputList.FilterTripExists = false;
			}
			if (optTripExists.Checked)
			{
				oOutputList.FilterTripExists = true;
			}

			// расход готов к обработке на складе
			if (optReadyForWMSNot.Checked)
			{
				oOutputList.FilterReadyForWMS = false;
			}
			if (optReadyForWMS.Checked)
			{
				oOutputList.FilterReadyForWMS = true;
			}

			// состояние расхода: подтверждение 
			if (optIsConfirmedNot.Checked)
			{
				oOutputList.FilterIsConfirmed = false;
			}
			if (optIsConfirmed.Checked)
			{
				oOutputList.FilterIsConfirmed = true;
			}

			// по рейсу / машине
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0 ||
				ucSelectRecordID_Cars.IsSelectedExist)
			{
				Trip oTripFilter = new Trip();
				if (txtTripAliasContext.Text.Trim().Length > 0)
				{
					oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				}
				if (ucSelectRecordID_Cars.IsSelectedExist)
				{
					oTripFilter.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
				}
				oTripFilter.FillDataAsync();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ","; 
				}
				oOutputList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oOutputList.FilterTripsList == null)
					oOutputList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oOutputList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			if (nUserHostID.HasValue)
			{
				oOutputList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oOutputList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdOutputsGoods.DataSource = null;
			grdOutputsDocuments.DataSource = null;
			grdOutputsActs.DataSource = null;

			grdOutputs.GetGridState();

			oOutputList.FillDataAsync();
			grdOutputs.IsLockRowChanged = true;

			// ERPCode
			if (txtERPCodeContext.Text.Trim().Length > 0)
			{
				// доп.выборка - оставить только подходящие записи
				DataTable dtTemp = CopyTable(oOutputList.MainTable, "dtTemp", "ERPCode like '*" + txtERPCodeContext.Text.Trim().ToUpper() + "*'", "");
				oOutputList.MainTable.Clear();
				oOutputList.MainTable.Merge(dtTemp);
			}

			grdOutputs.Restore(oOutputList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oOutputList.ErrorNumber == 0);
		}

		private bool grdOutputsGoods_Restore()
		{
			grdOutputsGoods.GetGridState();
			grdOutputsGoods.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oOutputList.FillTableOutputsGoods((int)oOutputCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oOutputList.TableOutputsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"GoodAlias, ID");
				oOutputList.TableOutputsGoods.Clear();
				oOutputList.TableOutputsGoods.Merge(dt);
			}
			
			grdOutputsGoods.Restore(oOutputList.TableOutputsGoods);
			return (oOutputList.ErrorNumber == 0);
		}

		private bool grdOutputsDocuments_Restore()
		{
			grdOutputsDocuments.GetGridState();
			grdOutputsDocuments.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oOutputDocumentInOutput.FilterOutputsList = oOutputCur.ID.ToString();
			oOutputDocumentInOutput.FillDataAsync();
			grdOutputsDocuments.Restore(oOutputDocumentInOutput.MainTable);
			return (oOutputDocumentInOutput.ErrorNumber == 0);
		}

		private bool grdOutputsActs_Restore()
		{
			grdOutputsActs.GetGridState();
			grdOutputsActs.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oActForOutput.FilterOutputsList = oOutputCur.ID.ToString();
			oActForOutput.FillDataAsync();
			grdOutputsActs.Restore(oActForOutput.MainTable);
			return (oActForOutput.ErrorNumber == 0);
		}

		#endregion Outputs

		#region Inputs

		private bool grdInputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputCur.ClearOne();

			oInputList.ClearError();
			oInputList.ClearFilters();
			oInputList.ID = null;
			oInputList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oInputList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oInputList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// доставка?
			if (optDeliveryNeed.Checked)
			{
				oInputList.FilterDeliveryNeed = true;
			}
			if (optDeliveryNeedNot.Checked)
			{
				oInputList.FilterDeliveryNeed = false;
			}

			// типы приходов
			if (ucSelectRecordID_InputsTypes.IsSelectedExist)
			{
				oInputList.FilterInputsTypesList = ucSelectRecordID_InputsTypes.GetIdString();
			}

			// поставщики
			if (ucSelectRecordID_InputsPartners.IsSelectedExist)
			{
				oInputList.FilterPartnersList = ucSelectRecordID_InputsPartners.GetIdString();
			}

			// владельцы
			if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oInputList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oInputList.FilterPackingsList = ucSelectRecordIDForm_Packings.GetIdString();
			}

			// приход привязан к рейсу
			if (optTripExistsNot.Checked)
			{
				oInputList.FilterTripExists = false;
			}
			if (optTripExists.Checked)
			{
				oInputList.FilterTripExists = true;
			}

			// приход готов к обработке на складе
			if (optReadyForWMSNot.Checked)
			{
				oInputList.FilterReadyForWMS = false;
			}
			if (optReadyForWMS.Checked)
			{
				oInputList.FilterReadyForWMS = true;
			}

			// состояние прихода: подтверждение 
			if (optIsConfirmedNot.Checked)
			{
				oInputList.FilterIsConfirmed = false;
			}
			if (optIsConfirmed.Checked)
			{
				oInputList.FilterIsConfirmed = true;
			}

			// по рейсу / машине
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0 ||
				ucSelectRecordID_Cars.IsSelectedExist)
			{
				Trip oTripFilter = new Trip();
				if (txtTripAliasContext.Text.Trim().Length > 0)
				{
					oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				}
				if (ucSelectRecordID_Cars.IsSelectedExist)
				{
					oTripFilter.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
				}
				oTripFilter.FillDataAsync();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ",";
				}
				oInputList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oInputList.FilterTripsList == null)
					oInputList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oInputList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			if (nUserHostID.HasValue)
			{
				oInputList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oInputList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdInputsGoods.DataSource = null;
			grdInputsDocuments.DataSource = null;
			grdInputsActs.DataSource = null;

			grdInputs.GetGridState();

			oInputList.FillDataAsync();
			grdInputs.IsLockRowChanged = true;

			// ERPCode
			if (txtERPCodeContext.Text.Trim().Length > 0)
			{
				DataTable dtTemp = CopyTable(oInputList.MainTable, "dtTemp", "ERPCode like '*" + txtERPCodeContext.Text.Trim().ToUpper() + "*'", "");
				oInputList.MainTable.Clear();
				oInputList.MainTable.Merge(dtTemp);
			}

			grdInputs.Restore(oInputList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oInputList.ErrorNumber == 0);
		}

		private bool grdInputsGoods_Restore()
		{
			grdInputsGoods.GetGridState();
			grdInputsGoods.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
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

			grdInputsGoods.Restore(oInputList.TableInputsGoods);
			return (oInputList.ErrorNumber == 0);
		}

		private bool grdInputsDocuments_Restore()
		{
			grdInputsDocuments.GetGridState();
			grdInputsDocuments.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
				return (true);

			oInputDocumentInInput.FilterInputsList = oInputCur.ID.ToString();
			oInputDocumentInInput.FillDataAsync();
			grdInputsDocuments.Restore(oInputDocumentInInput.MainTable);
			return (oInputDocumentInInput.ErrorNumber == 0);
		}

		private bool grdInputsActs_Restore()
		{
			grdInputsActs.GetGridState();
			grdInputsActs.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
				return (true);

			oActForInput.FilterInputsList = oInputCur.ID.ToString();
			oActForInput.FillDataAsync();
			grdInputsActs.Restore(oActForInput.MainTable);
			return (oActForInput.ErrorNumber == 0);
		}

		#endregion Inputs 

		#region TripsReturns

		private bool grdTripsReturns_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oTripReturnCur.ClearOne();

			oTripReturnList.ClearError();
			oTripReturnList.ClearFilters();
			oTripReturnList.ID = null;
			oTripReturnList.IDList = null;

			// собираем условия

			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oTripReturnList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oTripReturnList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			// владельцы
            if (ucSelectRecordID_Owners.IsSelectedExist)
			{
				oTripReturnList.FilterOwnersList = ucSelectRecordID_Owners.GetIdString();
			}

			// выбранные товары
			if (ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				oTripReturnList.FilterPackingsList = ucSelectRecordIDForm_Packings.GetIdString();
			}

			// готов к обработке на складе
			if (optReadyForWMSNot.Checked)
			{
				oTripReturnList.FilterReadyForWMS = false;
			}
			if (optReadyForWMS.Checked)
			{
				oTripReturnList.FilterReadyForWMS = true;
			}

			// состояние: подтверждение 
			if (optIsConfirmedNot.Checked)
			{
				oTripReturnList.FilterIsConfirmed = false;
			}
			if (optIsConfirmed.Checked)
			{
				oTripReturnList.FilterIsConfirmed = true;
			}

			// по рейсу и машине
			string sTripsList = "";
			if (txtTripAliasContext.Text.Trim().Length > 0 ||
				ucSelectRecordID_Cars.IsSelectedExist)
			{
				Trip oTripFilter = new Trip();
				if (txtTripAliasContext.Text.Trim().Length > 0)
				{
					oTripFilter.FilterAliasContext = txtTripAliasContext.Text.Trim();
				}
				if (ucSelectRecordID_Cars.IsSelectedExist)
				{
					oTripFilter.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
				}
				oTripFilter.FillDataAsync();
				if (oTripFilter.ErrorNumber == 0 && oTripFilter.MainTable != null)
				{
					foreach (DataRow tr in oTripFilter.MainTable.Rows)
						sTripsList += tr["ID"].ToString() + ",";
				}
				oTripReturnList.FilterTripsList = sTripsList;
			}
			if (numTripID.Value > 0)
			{
				if (oTripReturnList.FilterTripsList == null)
					oTripReturnList.FilterTripsList = Convert.ToInt32(numTripID.Value).ToString();
				else
					oTripReturnList.FilterTripsList += Convert.ToInt32(numTripID.Value).ToString();
			}

			if (nUserHostID.HasValue)
			{
				oTripReturnList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oTripReturnList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdTripsReturnsGoods.DataSource = null;

			grdTripsReturns.GetGridState();

			oTripReturnList.FillDataAsync();
			grdTripsReturns.IsLockRowChanged = true;

			// ERPCode
			if (txtERPCodeContext.Text.Trim().Length > 0)
			{
				DataTable dtTemp = CopyTable(oTripReturnList.MainTable, "dtTemp", "ERPCode like '*" + txtERPCodeContext.Text.Trim().ToUpper() + "*'", "");
				oTripReturnList.MainTable.Clear();
				oTripReturnList.MainTable.Merge(dtTemp);
			}

			grdTripsReturns.Restore(oTripReturnList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oTripReturnList.ErrorNumber == 0);
		}

		private bool grdTripsReturnsGoods_Restore()
		{
			grdTripsReturnsGoods.GetGridState();
			grdTripsReturnsGoods.DataSource = null;
			if (grdTripsReturns.Rows.Count == 0 ||
				oTripReturnCur.ID == null ||
				(grdTripsReturns.CurrentRow != null && grdTripsReturns.IsStatusRow(grdTripsReturns.CurrentRow.Index)))
				return (true);

			oTripReturnList.FillTableTripsReturnsGoods((int)oTripReturnCur.ID);

			if (chkShowSelectedGoodsOnly.Enabled && chkShowSelectedGoodsOnly.Checked &&
				ucSelectRecordIDForm_Packings.IsSelectedExist)
			{
				DataTable dt = CopyTable(oTripReturnList.TableTripsReturnsGoods, "dt",
					"PackingID in (" + RFMPublic.RFMUtilities.NormalizeList(ucSelectRecordIDForm_Packings.GetIdString()) + ")",
					"GoodGroupName, GoodAlias, ID");
				oTripReturnList.TableTripsReturnsGoods.Clear();
				oTripReturnList.TableTripsReturnsGoods.Merge(dt);
			}
	
			grdTripsReturnsGoods.Restore(oTripReturnList.TableTripsReturnsGoods);
			return (oTripReturnList.ErrorNumber == 0);
		}

		#endregion TripsReturns

	#endregion Restore

	#region Buttons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
				return;

			if (sPageName.Contains("INPUTS"))
				return;

			if (sPageName.Contains("RETURNS"))
				return;
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
				return;

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.Rows.Count == 0 || 
					grdInputs.CurrentRow == null ||
					grdInputs.IsStatusRow(grdInputs.CurrentRow.Index) ||
					!oInputCur.ID.HasValue)
					return;

				int nInputID = (int)oInputCur.ID; // Convert.ToInt32(grdInputs.CurrentRow.Cells["grcInputs_ID"].Value);
				oInputCur.ReFillOne(nInputID);
				if (oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено.");
					return;
				}
				if (oInputCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему.");
					return;
				}

				if (StartForm(new frmInputsEdit(nInputID)) == DialogResult.Yes)
				{
					grdInputs_Restore();
					grdInputs.GridSource.Position = grdInputs.GridSource.Find("ID", nInputID);
				}
			}

			if (sPageName.Contains("RETURNS"))
			{
				if (grdTripsReturns.Rows.Count == 0 ||
					grdTripsReturns.CurrentRow == null ||
					grdTripsReturns.IsStatusRow(grdTripsReturns.CurrentRow.Index) ||
					!oTripReturnCur.ID.HasValue)
					return;

				int nTripReturnID = (int)oTripReturnCur.ID; // Convert.ToInt32(grdTripsReturns.CurrentRow.Cells["grcTripsReturns_ID"].Value);
				oTripReturnCur.ReFillOne(nTripReturnID);
				if (oTripReturnCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Возврат уже подтвержден.");
					return;
				}
				if (oTripReturnCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Возврат уже передан в складскую систему.");
					return;
				}

				if (StartForm(new frmTripsReturnsEdit((int)nTripReturnID, (int)oTripReturnCur.TripID)) == DialogResult.Yes)
				{
					grdTripsReturns_Restore();
					grdTripsReturns.GridSource.Position = grdTripsReturns.GridSource.Find("ID", nTripReturnID);
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.DataSource == null ||
					grdOutputs.Rows.Count == 0 ||
					grdOutputs.CurrentRow == null ||
					!oOutputCur.ID.HasValue)
					return;

				oOutputCur.ReFillOne((int)oOutputCur.ID);

				// проверки
				if (oOutputCur.ERPCode != null)
				{
					RFMMessage.MessageBoxError("Задание на расход получено из host-системы...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oOutputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на расход уже подтверждено...\n" + 
						"Удаление невозможно.");
					return;
				}
				if (oOutputCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на расход передано в складскую систему...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oOutputCur.ReadyForWMS)
				{
					RFMMessage.MessageBoxError("Задание на расход готово для передачи в складскую систему...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oOutputCur.TripExists)
				{
					RFMMessage.MessageBoxError("Задание на расход уже привязано к рейсу...\n" +
						"Удаление невозможно.");
					return;
				}

				OutputDocument oOutputDocumentTemp = new OutputDocument();
				oOutputDocumentTemp.FilterOutputsList = oOutputCur.ID.ToString();
				oOutputDocumentTemp.FillDataAsync();
				if (oOutputDocumentTemp.MainTable != null && oOutputDocumentTemp.MainTable.Rows.Count > 0)
				{
					RFMMessage.MessageBoxError("Для задания на расход существует расходный документ...\n" +
						"Удаление невозможно.");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Удалить задание на расход?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oOutputCur.Delete((int)oOutputCur.ID);
					WaitOff(this);
					if (bResult && oOutputCur.ErrorNumber == 0)
					{
						//RFMMessage.MessageBoxInfo("Задание на расход удалено.");
						grdOutputs_Restore();
					}
				}
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.DataSource == null ||
					grdInputs.Rows.Count == 0 ||
					grdInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				oInputCur.ReFillOne((int)oInputCur.ID);

				// проверки
				if (oInputCur.ERPCode != null)
				{
					RFMMessage.MessageBoxError("Задание на приход получено из host-системы...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oInputCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход передано в складскую систему...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oInputCur.ReadyForWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход готово для передачи в складскую систему...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oInputCur.TripExists)
				{
					RFMMessage.MessageBoxError("Задание на приход уже привязано к рейсу...\n" +
						"Удаление невозможно.");
					return;
				}
				InputDocument oInputDocumentTemp = new InputDocument();
				oInputDocumentTemp.FilterInputsList = oInputCur.ID.ToString();
				oInputDocumentTemp.FillDataAsync();
				if (oInputDocumentTemp.MainTable != null && oInputDocumentTemp.MainTable.Rows.Count > 0)
				{
					RFMMessage.MessageBoxError("Для задания на приход существует приходный документ...\n" +
						"Удаление невозможно.");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("Удалить задание на приход?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oInputCur.Delete((int)oInputCur.ID);
					WaitOff(this);
					if (bResult && oInputCur.ErrorNumber == 0)
					{
						//RFMMessage.MessageBoxInfo("Задание на приход удалено.");
						grdInputs_Restore();
					}
				}
			}

			if (sPageName.Contains("RETURNS"))
			{
				if (grdTripsReturns.DataSource == null ||
					grdTripsReturns.Rows.Count == 0 ||
					grdTripsReturns.CurrentRow == null ||
					!oTripReturnCur.ID.HasValue)
					return;

				oTripReturnCur.ReFillOne((int)oTripReturnCur.ID);

				// проверки
				if (oTripReturnCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Возврта уже подтвержден...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oTripReturnCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Возврат уже передан в складскую систему...\n" +
						"Удаление невозможно.");
					return;
				}
				if (oTripReturnCur.ReadyForWMS)
				{
					RFMMessage.MessageBoxError("Возврат готов для передачи в складскую систему...\n" +
						"Удаление невозможно.");
					return;
				}

				Trip oTripForTripReturn = new Trip();
				oTripForTripReturn.ReFillOne((int)oTripReturnCur.TripID);
				if (oTripForTripReturn.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Рейс, для которого оформлен возврат, уже подтвержден...\n" +
						"Удаление возврата невозможно.");
					return;
				}
				//

				if (RFMMessage.MessageBoxYesNo("Удалить возврат?") == DialogResult.Yes)
				{
					Refresh();
					WaitOn(this);
					bool bResult = oTripReturnCur.Delete((int)oTripReturnCur.ID);
					WaitOff(this);
					if (bResult && oTripReturnCur.ErrorNumber == 0)
					{
						//RFMMessage.MessageBoxInfo("Возврат удален.");
						grdTripsReturns_Restore();
					}
				}
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.DataSource == null ||
					grdOutputs.Rows.Count == 0 ||
					grdOutputs.CurrentRow == null ||
					!oOutputCur.ID.HasValue)
					return;

				oOutputCur.ReFillOne((int)oOutputCur.ID);

				// проверки
				if (oOutputCur.DateConfirm != null)
				{
					RFMMessage.MessageBoxError("Задание на расход уже подтверждено...");
					return;
				}

				RFMMessage.MessageBoxAttention("ВНИМАНИЕ!\n\n" +
					"Подтверждение задания на расход выполняется только в складской системе (WMS)!\n\n" +
					"Сейчас режим вызывается только для тестирования!");

				if (RFMMessage.MessageBoxYesNo("Подтвердить выполнение задания на расход?") == DialogResult.Yes)
				{
					Refresh();
					oOutputCur.ClearError();

					WaitOn(this);
					if (oOutputCur.FillTableOutputsGoods() && oOutputCur.TableOutputsGoods != null && oOutputCur.ErrorNumber == 0)
					{
						if (oOutputCur.Confirm() && oOutputCur.ErrorNumber == 0)
						{
							WaitOff(this);
							//RFMMessage.MessageBoxInfo("Задание на расход подтверждено.");
							grdOutputs_Restore();
						}
						else
						{
							WaitOff(this);
							//RFMMessage.MessageBoxError("Ошибка при подтверждении задания на расход...");
						}
					}
					else
					{
						WaitOff(this);
						RFMMessage.MessageBoxError("Ошибка при получении списка товаров в расходе...");
					}
				}
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.DataSource == null ||
					grdInputs.Rows.Count == 0 ||
					grdInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				oInputCur.ReFillOne((int)oInputCur.ID);

				// проверки
				if (oInputCur.DateConfirm != null)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено...");
					return;
				}

				RFMMessage.MessageBoxAttention("ВНИМАНИЕ!\n\n" +
					"Подтверждение задания на приход выполняется только в складской системе (WMS)!\n\n" +
					"Сейчас режим вызывается только для тестирования!");

				if (RFMMessage.MessageBoxYesNo("Подтвердить выполнение задания на приход?") == DialogResult.Yes)
				{
					Refresh();
					oInputCur.ClearError();

					WaitOn(this);
					if (oInputCur.FillTableInputsGoods() && oInputCur.TableInputsGoods != null && oInputCur.ErrorNumber == 0)
					{
						if (oInputCur.Confirm() && oInputCur.ErrorNumber == 0)
						{
							WaitOff(this);
							//RFMMessage.MessageBoxInfo("Задание на приход подтверждено.");
							grdInputs_Restore();
						}
						else
						{
							WaitOff(this);
							//RFMMessage.MessageBoxError("Ошибка при подтверждении задания на приход...");
						}
					}
					else
					{
						WaitOff(this);
						RFMMessage.MessageBoxError("Ошибка при получении списка товаров в заднии на приход...");
					}
				}
			}

			if (sPageName.Contains("RETURNS"))
			{
				if (grdTripsReturns.DataSource == null ||
					grdTripsReturns.Rows.Count == 0 ||
					grdTripsReturns.CurrentRow == null ||
					!oTripReturnCur.ID.HasValue)
					return;

				oTripReturnCur.ReFillOne((int)oTripReturnCur.ID);

				// проверки
				if (oTripReturnCur.DateConfirm != null)
				{
					RFMMessage.MessageBoxError("Возврат уже подтвержден...");
					return;
				}

				RFMMessage.MessageBoxAttention("ВНИМАНИЕ!\n\n" +
					"Подтверждение получения возврата выполняется только в складской системе (WMS)!\n\n" +
					"Сейчас режим вызывается только для тестирования!");

				if (RFMMessage.MessageBoxYesNo("Подтвердить получение возврата?") == DialogResult.Yes)
				{
					Refresh();
					oTripReturnCur.ClearError();

					WaitOn(this);
					if (oTripReturnCur.FillTableTripsReturnsGoods() && oTripReturnCur.TableTripsReturnsGoods != null && oTripReturnCur.ErrorNumber == 0)
					{
						if (oTripReturnCur.Confirm() && oTripReturnCur.ErrorNumber == 0)
						{
							WaitOff(this);
							//RFMMessage.MessageBoxInfo("Возврат подтвержден.");
							grdTripsReturns_Restore();
						}
						else
						{
							WaitOff(this);
							//RFMMessage.MessageBoxError("Ошибка при подтверждении возврата...");
						}
					}
					else
					{
						WaitOff(this);
						RFMMessage.MessageBoxError("Ошибка при получении списка товаров в заднии на приход...");
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

	#region MenuStrip

		#region outputs

		#region outputs service

		private void mniOutputsServiceSetReadyForWMS_Click(object sender, EventArgs e)
		{
			OutputsSetReadyForWMS(true);
		}

		private void mniOutputsServiceClearReadyForWMS_Click(object sender, EventArgs e)
		{
			OutputsSetReadyForWMS(false);
		}

		private void mniOutputsServiceSetDeliveryNeed_Click(object sender, EventArgs e)
		{
			OutputsSetDeliveryNeed(true);
		}

		private void mniOutputsServiceClearDeliveryNeed_Click(object sender, EventArgs e)
		{
			OutputsSetDeliveryNeed(false);
		}

		private void mniOutputsServiceChangeDate_Click(object sender, EventArgs e)
		{
			OutputsChangeDate();
		}

		private void mniOutputsServiceUnConfirm_Click(object sender, EventArgs e)
		{
			OutputsUnConfirm();
		}

		private void mniOutputsServiceCreateAct_Click(object sender, EventArgs e)
		{
			CreateAct();
		}

		#endregion outputs service

		#region outputs print

		private void mniOutputsPrintBill_Click(object sender, EventArgs e)
		{
			PrintOutputBill();
		}

        private void mniOutputsPrintBillM15_Click(object sender, EventArgs e)
        {
            PrintOutputBillM15();
        }

		private void mniOutputsPrintTTN_Click(object sender, EventArgs e)
		{
			PrintOutputTtn();
		}

		#endregion outputs print

		#endregion outputs 

		#region inputs

		#region inputs service

		private void mniInputsServiceSetReadyForWMS_Click(object sender, EventArgs e)
		{
			InputsSetReadyForWMS(true);
		}

		private void mniInputsServiceClearReadyForWMS_Click(object sender, EventArgs e)
		{
			InputsSetReadyForWMS(false);
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
		private void mniInputsServiceUnConfirm_Click(object sender, EventArgs e)
		{
			InputsUnConfirm();
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
			InputsQualityData();
		}

		private void mniInputsServiceVeterinaryData_Click(object sender, EventArgs e)
		{
			InputsVeterinaryData();
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

        private void mniInputsPrintOualitiesList_Click(object sender, EventArgs e)
        {
            PrintInputsQualitiesList();
        }

		#endregion inputs print

		#endregion inputs

		#region tripsreturns

		#region tripsreturns service

		private void mniTripsReturnsServiceSetReadyForWMS_Click(object sender, EventArgs e)
		{
			TripsReturnsSetReadyForWMS(true);
		}

		private void mniTripsReturnsServiceClearReadyForWMS_Click(object sender, EventArgs e)
		{
			TripsReturnsSetReadyForWMS(false);
		}

		private void mniTripsReturnsServiceUnConfirm_Click(object sender, EventArgs e)
		{
			TripsReturnsUnConfirm();
		}

		#endregion tripsreturns service

		#region tripsreturns print

		private void mniTripsReturnsPrintBill_Click(object sender, EventArgs e)
		{
			PrintTripReturnBill();
		}

		#endregion tripsreturns print
		
		#endregion tripsreturn

	#endregion MenuStrip
	
	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
			btnPrint.ShortCutShow();

			/*
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.CurrentRow == null)
					return;

				if (!oOutputCur.ID.HasValue)
					return;

				CreateShortCut(btnPrint, "OutputsPrint");
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.CurrentRow == null)
					return;

				if (!oInputCur.ID.HasValue)
					return;

				CreateShortCut(btnPrint, "InputsPrint");
			}

			if (sPageName.Contains("RETURNS"))
			{
				if (grdTripsReturns.CurrentRow == null)
					return;

				if (!oTripReturnCur.ID.HasValue)
					return;

				CreateShortCut(btnPrint, "TripsReturnsPrint");
			}
			*/ 
		}

		#region InputBill

		private void PrintInputBill()
		{
			if (grdInputs.CurrentRow == null ||
				grdInputs.IsStatusRow(grdInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			oInputPrint.ID = Convert.ToInt32(grdInputs.CurrentRow.Cells["grcInputs_ID"].Value);
			oInputPrint.FillDataAsync();
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
			if (grdInputs.CurrentRow == null ||
				grdInputs.IsStatusRow(grdInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			oInputPrint.ID = Convert.ToInt32(grdInputs.CurrentRow.Cells["grcInputs_ID"].Value);
			oInputPrint.FillDataAsync();
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
			if (grdInputs.CurrentRow == null ||
				grdInputs.IsStatusRow(grdInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			//oInputPrint.ReFillOne((int)oInputCur.ID);
            InputPrepareIDList(oInputPrint, true);

			// проверки...

			LogService.InputBillMX1_Print(oInputPrint, this);
		}

        private void PrintInputReturnBill()
		{
			if (grdInputs.CurrentRow == null ||
				grdInputs.IsStatusRow(grdInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			int nInputID = Convert.ToInt32(grdInputs.CurrentRow.Cells["grcInputs_ID"].Value);
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
			if (grdInputs.CurrentRow == null ||
				grdInputs.IsStatusRow(grdInputs.CurrentRow.Index) ||
				!oInputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			int nInputID = Convert.ToInt32(grdInputs.CurrentRow.Cells["grcInputs_ID"].Value);
			oInputPrint.ReFillOne(nInputID);
			/*
			if (!oInputCur.PF_WarrantNeed)
			{
				RFMMessage.MessageBoxError("Доверенность не требуется.");
				return;
			}
			*/ 

			LogService.InputWarrant_Print(oInputPrint, this, false);
		}

        private void PrintInputsQualitiesList()
        {
            // Получить список приходов
            string inputsIDList = "";
            foreach (DataRow r in oInputList.MainTable.Rows)
                if (r["ID"].ToString().Length > 0)
                    inputsIDList += r["ID"].ToString() + ",";

            if (inputsIDList.Length == 0)
            {
                RFMMessage.MessageBoxError("Нет данных о приходах.");
                return;
            }

            // Получить список принятых товаров в приходах
            DataTable dT = new DataTable();
            DataColumn dc = new DataColumn();
            dc.DataType = System.Type.GetType("System.Int32");
            dc.ColumnName = "GoodID";
            dT.Columns.Add(dc);
            Input oInput = new Input();
            if (!oInput.FillDistinctGoodsInInputs(inputsIDList, out dT) || dT == null || dT.Rows.Count == 0)
            {
                RFMMessage.MessageBoxError("Нет данных о принятых товарах.");
                return;
            }

            // Сформировать отчет
            ActiveReport3 rep = new QualityList();
            Good oGood = new Good();
            oGood.FillTableGoodsQualititiesList(false, dT);

            RFMCursorWait.Set(false);

            if (oGood.TableGoodsQualitiesList.Rows.Count > 0)
                this.StartForm(new frmActiveReport(oGood.TableGoodsQualitiesList, rep));
            else
                RFMMessage.MessageBoxInfo("Нет данных...");
        }

		#endregion InputBill

		#region OutputBill

		private void PrintOutputBill()
		{
			if (grdOutputs.CurrentRow == null ||
				grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index) ||
				!oOutputCur.ID.HasValue)
				return;

			Output oOutputPrint = new Output();
			oOutputPrint.ID = Convert.ToInt32(grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value);
			oOutputPrint.FillDataAsync();
			if (oOutputPrint.ErrorNumber != 0 || oOutputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных по заданию на расход...");
				return;
			}
			if (oOutputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных по заданию на расход...");
				return;
			}

			LogService.OutputBill_Print(oOutputPrint, this);
		}

        private void PrintOutputBillM15()
        {
            if (grdOutputs.CurrentRow == null ||
                grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index) ||
                !oOutputCur.ID.HasValue)
                return;

            Output oOutputPrint = new Output();
            oOutputPrint.ID = Convert.ToInt32(grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value);
            oOutputPrint.FillDataAsync();
            if (oOutputPrint.ErrorNumber != 0 || oOutputPrint.MainTable == null)
            {
                RFMMessage.MessageBoxError("Ошибка при получении данных по заданию на расход...");
                return;
            }
            if (oOutputPrint.MainTable.Rows.Count == 0)
            {
                RFMMessage.MessageBoxError("Нет данных по заданию на расход...");
                return;
            }

            LogService.OutputBillM15_Print(oOutputPrint, this);
        }

        private void PrintOutputBillWithAct()
		{
			if (grdOutputs.CurrentRow == null ||
				grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index) ||
				!oOutputCur.ID.HasValue)
				return;

			Output oOutputPrint = new Output();
			oOutputPrint.ID = Convert.ToInt32(grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value);
			oOutputPrint.FillDataAsync();
			if (oOutputPrint.ErrorNumber != 0 || oOutputPrint.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных по заданию на расход с учетом актов...");
				return;
			}
			if (oOutputPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных по заданию на расход с учетом актов...");
				return;
			}

			LogService.OutputBillWithAct_Print(oOutputPrint, this);
		}

		private void PrintOutputTtn()
		{
			if (grdOutputs.Rows.Count == 0 ||
				grdOutputs.CurrentRow == null ||
				!oOutputCur.ID.HasValue)
				return;

			RFMCursorWait.Set(true);

			Output oOutputPrint = new Output();
			oOutputPrint.ID = (int?)grdOutputs.CurrentRow.Cells["grcOutputs_ID"].Value;

			LogService.OutputTtn_Print(oOutputPrint, this);
		}

		#endregion OutputBill

		#region TripReturnBill

		private void PrintTripReturnBill()
		{
			if (grdTripsReturns.CurrentRow == null || 
				grdTripsReturns.IsStatusRow(grdTripsReturns.CurrentRow.Index) ||
				grdTripsReturns.IsStatusRow(grdTripsReturns.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			TripReturn oTripReturnPrint = new TripReturn();
			oTripReturnPrint.ID = Convert.ToInt32(grdTripsReturns.CurrentRow.Cells["grcTripsReturns_ID"].Value);
			oTripReturnPrint.FillDataAsync();
			if (oTripReturnPrint.ErrorNumber != 0 || oTripReturnPrint.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных по возврату...");
				return;
			}
			if (oTripReturnPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных по возврату...");
				return;
			}

			LogService.TripReturnBill_Print(oTripReturnPrint, this);
		}

		#endregion TripReturnBill

	#endregion

	#region Menu Service

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
			/*
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.DataSource == null ||
					grdOutputs.Rows.Count == 0)
					return; 

				CreateShortCut(btnService, "OutputsService");
			}

			if (sPageName.Contains("INPUT"))
			{
				if (grdInputs.DataSource == null ||
					grdInputs.Rows.Count == 0)
					return; 

				CreateShortCut(btnService, "InputsService");
			}

			if (sPageName.Contains("RETURNS"))
			{
				if (grdTripsReturns.DataSource == null ||
					grdTripsReturns.Rows.Count == 0)
					return; 

				CreateShortCut(btnService, "TripsReturnsService");
			}
			*/ 
		}

		#region UnConfirm

		private void OutputsUnConfirm()
		{
			if (grdOutputs.DataSource == null ||
				grdOutputs.Rows.Count == 0 ||
				grdOutputs.CurrentRow == null ||
				!oOutputCur.ID.HasValue)
				return;

			oOutputCur.ReFillOne((int)oOutputCur.ID);

			// проверки
			if (oOutputCur.DateConfirm == null)
			{
				RFMMessage.MessageBoxError("Задание на расход не был подтверждено...");
				return;
			}
			// 

			RFMMessage.MessageBoxAttention("ВНИМАНИЕ!\n\n" +
				"Снятие подтверждения задания на расход выполняется только в складской системе (WMS)!\n\n" +
				"Сейчас режим вызывается только для тестирования!");

			if (RFMMessage.MessageBoxYesNo("Снять отметку о подтверждении задания на расход?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oOutputCur.UnConfirm();
				WaitOff(this);
				if (bResult && oOutputCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка о подтверждении задания на расход снята.");
					grdOutputs_Restore();
				}
			}
		}

		private void InputsUnConfirm()
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			oInputCur.ReFillOne((int)oInputCur.ID);

			// проверки
			if (oInputCur.DateConfirm == null)
			{
				RFMMessage.MessageBoxError("Задание на приход не было подтверждено...");
				return;
			}
			// 

			RFMMessage.MessageBoxAttention("ВНИМАНИЕ!\n\n" +
				"Снятие подтверждения для задания на приход выполняется только в складской системе (WMS)!\n\n" +
				"Сейчас режим вызывается только для тестирования!");

			if (RFMMessage.MessageBoxYesNo("Снять отметку о подтверждении задания на приход?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oInputCur.UnConfirm();
				WaitOff(this);
				if (bResult && oInputCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка о подтверждении задания на приход снята.");
					grdInputs_Restore();
				}
			}
		}

		private void TripsReturnsUnConfirm()
		{
			if (grdTripsReturns.DataSource == null ||
				grdTripsReturns.Rows.Count == 0 ||
				grdTripsReturns.CurrentRow == null ||
				!oTripReturnCur.ID.HasValue)
				return;

			oTripReturnCur.ReFillOne((int)oTripReturnCur.ID);

			// проверки
			if (oTripReturnCur.DateConfirm == null)
			{
				RFMMessage.MessageBoxError("Возврат не был подтвержден...");
				return;
			}
			// 

			RFMMessage.MessageBoxAttention("ВНИМАНИЕ!\n\n" +
				"Снятие подтверждения для возврата выполняется только в складской системе (WMS)!\n\n" +
				"Сейчас режим вызывается только для тестирования!");

			if (RFMMessage.MessageBoxYesNo("Снять отметку о подтверждении возврата?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oTripReturnCur.UnConfirm();
				WaitOff(this);
				if (bResult && oTripReturnCur.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("Отметка о подтверждении возврата снята.");
					grdTripsReturns_Restore();
				}
			}
		}

		#endregion UnConfirm

		#region ChangeDate

		private void OutputsChangeDate()
		{
			if (grdOutputs.DataSource == null ||
				grdOutputs.Rows.Count == 0 ||
				grdOutputs.CurrentRow == null ||
				!oOutputCur.ID.HasValue)
				return;

			oOutputCur.ReFillOne((int)oOutputCur.ID);

			if (oOutputCur.TripExists)
			{
				RFMMessage.MessageBoxError("Задание на расход привязано к рейсу.\n" +
						"Смена даты не выполняется.");
				return; 
			}

			bool bAsked = false;

			string sText = "";
			string sPartnersList = ""; // список партнеров 
			OutputDocument oOutputDocument = new OutputDocument();
			oOutputDocument.FilterOutputsList = oOutputCur.ID.ToString();
			oOutputDocument.FillDataAsync();
			int nOutputsDocumentsQnt = oOutputDocument.MainTable.Rows.Count;
			OutputDocument oOutputDocumentOne = new OutputDocument();
			foreach (DataRow od in oOutputDocument.MainTable.Rows)
			{
				oOutputDocumentOne.FillOne(od);
				if (oOutputDocumentOne.IsBrought)
				{
					sText = (nOutputsDocumentsQnt > 1)
						? "Среди расходных документов, входящих в данное задание, есть документы, по которым уже зарегистрирована доставка получателю."
						: "По расходному документу, входящему в данное задание, уже зарегистрирована доставка получателю.";
					RFMMessage.MessageBoxError(sText + "\nСмена даты не выполняется.");
					return;
				}
				sPartnersList += oOutputDocumentOne.PartnerTargetID.ToString().Trim() + ",";
			}

			// приходы на ту же дату, без рейса
			int nInputsCnt = 0;
			string sInputsList = "";
			Input oInput = new Input();
			oInput.FilterDateBeg =
			oInput.FilterDateEnd =
				oOutputCur.DateOutput;
			oInput.FilterTripExists = false; 
			oInput.FilterIsConfirmed = false;
			oInput.FilterPartnersList = sPartnersList;
			oInput.FillDataAsync();
			if (oInput.ErrorNumber != 0 || oInput.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о приходах...");
				return;
			}
			if (oInput.MainTable.Rows.Count > 0)
			{
				// проверим наличие документов у приходов
				int nInputsDocumentsCnt = 0;
				foreach (DataRow ic in oInput.MainTable.Rows)
				{
					if ((bool)ic["InputsDocumentsExists"])
					{
						nInputsDocumentsCnt++;
					}
					else
					{
						// этот приход можно переносить 
						nInputsCnt++;
						sInputsList += ic["ID"].ToString().Trim() + ",";
					}
				}

				if (nInputsDocumentsCnt > 0)
				{
					sText = "Внимание!\n\n" +
						"Среди заданий на приход " +
						((oOutputCur.PointsQnt > 1) ? "тех же клиентов" : "того же клиента") + " на ту же дату, неприсоединенных к рейсу,\n" +
						"есть задания (" + nInputsDocumentsCnt.ToString().Trim() + "), для которых оформлены приходные документы\n" +
						"(такие приходы не могут быть перенесены).\n\n" +
						"Вы уверены, что следует продолжать выполнение операции смены даты?";
					if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						return;
				}

				if (nInputsCnt > 0)
				{
					sText = "На ту же дату существует еще ";
					if (nInputsCnt == 1)
						sText += "1 приход для " +
							((oOutputCur.PointsQnt > 1) ? "тех же клиентов" : "того же клиента") + ", неприсоединенный к рейсу." +
							"\n\nВыполнить также смену даты для задания на приход";
					else
						sText += RFMUtilities.Declen(nInputsCnt, "приход", "прихода", "приходов") + " для " +
							((oOutputCur.PointsQnt > 1) ? "тех же клиентов" : "того же клиента") +
							", неприсоединенны" + RFMUtilities.Declen(nInputsCnt, "й", "е", "х", true, false, false) + " к рейсу." +
							"\n\nВыполнить также смену даты для этих заданий на приход";
					if (RFMMessage.MessageBoxYesNo(sText + "?") != DialogResult.Yes)
					{
						nInputsCnt = 0;
						sInputsList = "";
					}
				}

				bAsked = false;
			}

			if (!bAsked)
			{
				sText = "Изменить дату задания на расход и входящих в него расходных документов (" + nOutputsDocumentsQnt.ToString().Trim() + ")";
				if (nInputsCnt > 0)
					sText += ", а также приходов (" + nInputsCnt.ToString().Trim() + ")";
				if (RFMMessage.MessageBoxYesNo(sText + "?") != DialogResult.Yes)
					return;
			}

			// новая дата
			DateTime dNewDate = oOutputCur.DateOutput;
			if (StartForm(new frmInputBoxDate("Новая дата расхода:", dNewDate)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
				{
					dNewDate = Convert.ToDateTime(GotParam[0]);
				}
				if (dNewDate.CompareTo(oOutputCur.DateOutput) == 0)
				{
					RFMMessage.MessageBoxError("Указана та же дата...");
					return;
				}
				if (dNewDate.CompareTo(DateTime.Now.Date) < 0)
				{
					RFMMessage.MessageBoxError("Указана прошедшая дата...");
					return;
				}

				if (oOutputCur.ChangeDate((int)oOutputCur.ID, dNewDate) && oOutputCur.ErrorNumber == 0)
				{ 
					//RFMMessage.MessageBoxInfo("Задание на расход перенесено на другую дату.");

					// перенос приходов 
					if (nInputsCnt > 0)
					{
						sText = "ВНИМАНИЕ!\n\n";
						if (nInputsCnt == 1)
							sText = "Для задания на приход дата будет изменена на " + dNewDate.ToString("dd.MM.yyyy");
						else
							sText = "Для " + RFMUtilities.Declen(nInputsCnt, "задания", "заданий", "заданий") + " на приход дата будет изменена на " + dNewDate.ToString("dd.MM.yyyy");
						if (RFMMessage.MessageBoxYesNo(sText + ".\n\nПродолжить?") == DialogResult.Yes)
						{
							oInput.IDList = sInputsList;
							oInput.FillDataAsync();
							if (oInput.ErrorNumber != 0 || oInput.MainTable == null)
							{
								RFMMessage.MessageBoxError("Ошибка при получении данных о приходах...");
							}
							else
							{
								if (oInput.MainTable.Rows.Count > 0)
								{
									Input oInputOne = new Input();
									foreach (DataRow i in oInput.MainTable.Rows)
									{
										oInputOne.ReFillOne((int)i["ID"]);
										if (!oInputOne.TripExists || !oInputOne.IsConfirmed && !oInputOne.InputsDocumentsExists)
										{
											oInputOne.ChangeDate((int)oInputOne.ID, dNewDate);
										}
									}
								}
							}
						}
					}

					grdOutputs_Restore();
				}
			}
		}

		private void InputsChangeDate()
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
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
						grdInputs_Restore();
					}
				}
			}
		}

		#endregion ChangeDate

		#region Set ReadyForWMS

		private void OutputsSetReadyForWMS(bool bSet)
		{
			if (grdOutputs.DataSource == null ||
				grdOutputs.Rows.Count == 0)
				return;

			RFMCursorWait.Set(true);

			bool bAll = (grdOutputs.IsCheckerInclude && grdOutputs.IsCheckerShow && grdOutputs.MarkedCount > 0);

			Output oOutputTemp = new Output();
			OutputPrepareIDList(oOutputTemp, bAll);
			if (bAll && (oOutputTemp.IDList == null || oOutputTemp.IDList.Length == 0))
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Не отмечены задания на расход...");
				return;
			}
			oOutputTemp.FillDataAsync();
			if (oOutputTemp.ErrorNumber != 0 || oOutputTemp.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении списка заданий на расход...");
				return;
			}
			if (oOutputTemp.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Не выбраны задания на расход...");
				return;
			}

			if (oOutputTemp.MainTable.Rows.Count > 1)
			{
				RFMCursorWait.Set(false);
				if (RFMMessage.MessageBoxYesNo(((bSet) ? "Установить" : "Снять") + " признак \"Готово к передаче в складскую систему\" для отмеченных заданий на расход (" + oOutputTemp.MainTable.Rows.Count.ToString() + ")?") != DialogResult.Yes)
					return;
				else
					RFMCursorWait.Set(true);
			}

			bool bOK = false;
			int nOutputID = 0;
			foreach (DataRow r in oOutputTemp.MainTable.Rows)
			{
				nOutputID = (int)r["ID"];
				oOutputTemp.FillOne(r);
				if (bSet)
				{
					// ставим признак 
					if (!oOutputTemp.ReadyForWMS)
					{
						if (oOutputTemp.IsConfirmed)
						{
							RFMCursorWait.Set(false);
							RFMMessage.MessageBoxError("Задание на расход с кодом " + nOutputID.ToString() + 
								((oOutputTemp.PartnerName.ToString().Length > 0)? (" (" + oOutputTemp.PartnerName.ToString() + ")") : "") + 
								" уже подтверждено...");
							RFMCursorWait.Set(true);
							continue;
						}

						// можно ставить признак
						oOutputTemp.SetReadyForWMS(nOutputID);
						bOK = true;
					}
				}
				else
				{
					// снимаем признак
					if (oOutputTemp.ReadyForWMS)
					{
						oOutputTemp.SetReadyForWMS(nOutputID, true, null);
						bOK = true;
					}
				}
			}

			RFMCursorWait.Set(false);

			if (bOK)
			{
				grdOutputs_Restore();
			}
		}

		private void InputsSetReadyForWMS(bool bSet)
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0)
				return;

			RFMCursorWait.Set(true);

			bool bAll = (grdInputs.IsCheckerInclude && grdInputs.IsCheckerShow && grdInputs.MarkedCount > 0);

			Input oInputTemp = new Input();
			InputPrepareIDList(oInputTemp, bAll);
			if (bAll && (oInputTemp.IDList == null || oInputTemp.IDList.Length == 0))
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Не отмечены задания на приход...");
				return;
			}
			oInputTemp.FillDataAsync();
			if (oInputTemp.ErrorNumber != 0 || oInputTemp.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении списка заданий на приход...");
				return;
			}
			if (oInputTemp.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Не выбраны задания на приход...");
				return;
			}

			if (oInputTemp.MainTable.Rows.Count > 1)
			{
				RFMCursorWait.Set(false);
				if (RFMMessage.MessageBoxYesNo(((bSet) ? "Установить" : "Снять") + " признак \"Готово к передаче в складскую систему\" для отмеченных заданий на приход (" + oInputTemp.MainTable.Rows.Count.ToString() + ")?") != DialogResult.Yes)
					return;
				else
					RFMCursorWait.Set(true);
			}

			bool bOK = false;
			int nInputID = 0;
			foreach (DataRow r in oInputTemp.MainTable.Rows)
			{
				nInputID = (int)r["ID"];
				oInputTemp.FillOne(r);
				if (bSet)
				{
					// ставим признак 
					if (!oInputTemp.ReadyForWMS)
					{
						if (oInputTemp.IsConfirmed)
						{
							RFMCursorWait.Set(false);
							RFMMessage.MessageBoxError("Задание на приход с кодом " + nInputID.ToString() +
								((oInputTemp.PartnerName.ToString().Length > 0) ? (" (" + oInputTemp.PartnerName.ToString() + ")") : "") +
								" уже подтверждено...");
							RFMCursorWait.Set(true);
							continue;
						}
						if (!oInputTemp.InputsDocumentsExists)
						{
							RFMCursorWait.Set(false);
							RFMMessage.MessageBoxError("Для задания на приход с кодом " + nInputID.ToString() +
								((oInputTemp.PartnerName.ToString().Length > 0) ? (" (" + oInputTemp.PartnerName.ToString() + ")") : "") +
								" не оформлены приходные документы...");
							RFMCursorWait.Set(true);
							continue;
						}

						// можно ставить признак
						oInputTemp.SetReadyForWMS(nInputID);
						bOK = true;
					}
				}
				else
				{
					// снимаем признак
					if (oInputTemp.ReadyForWMS)
					{
						oInputTemp.SetReadyForWMS(nInputID, true, null);
						bOK = true;
					}
				}
			}

			RFMCursorWait.Set(false);

			if (bOK)
			{
				grdInputs_Restore();
			}
		}

		private void TripsReturnsSetReadyForWMS(bool bSet)
		{
			if (grdTripsReturns.DataSource == null ||
				grdTripsReturns.Rows.Count == 0)
				return;

			RFMCursorWait.Set(true);

			bool bAll = (grdTripsReturns.IsCheckerInclude && grdTripsReturns.IsCheckerShow && grdTripsReturns.MarkedCount > 0);

			TripReturn oTripReturnTemp = new TripReturn();
			TripReturnPrepareIDList(oTripReturnTemp, bAll);
			if (bAll && (oTripReturnTemp.IDList == null || oTripReturnTemp.IDList.Length == 0))
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Не отмечены возвраты...");
				return;
			}
			oTripReturnTemp.FillDataAsync();
			if (oTripReturnTemp.ErrorNumber != 0 || oTripReturnTemp.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении списка возвратов...");
				return;
			}
			if (oTripReturnTemp.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Не выбраны возвраты...");
				return;
			}

			if (oTripReturnTemp.MainTable.Rows.Count > 1)
			{
				RFMCursorWait.Set(false);
				if (RFMMessage.MessageBoxYesNo(((bSet) ? "Установить" : "Снять") + " признак \"Готов к передаче в складскую систему\" для отмеченных возвратов (" + oTripReturnTemp.MainTable.Rows.Count.ToString() + ")?") != DialogResult.Yes)
					return;
				else
					RFMCursorWait.Set(true);
			}

			bool bOK = false;
			int nTripReturnID = 0;
			foreach (DataRow r in oTripReturnTemp.MainTable.Rows)
			{
				nTripReturnID = (int)r["ID"];
				oTripReturnTemp.FillOne(r);
				if (bSet)
				{
					// ставим признак 
					if (!oTripReturnTemp.ReadyForWMS)
					{
						if (oTripReturnTemp.IsConfirmed)
						{
							RFMCursorWait.Set(false);
							RFMMessage.MessageBoxError("Возврат с кодом " + nTripReturnID.ToString() + " уже подтвержден...");
							RFMCursorWait.Set(true);
							continue;
						}

						// можно ставить признак
						oTripReturnTemp.SetReadyForWMS(nTripReturnID);
						bOK = true;
					}
				}
				else
				{
					// снимаем признак
					if (oTripReturnTemp.ReadyForWMS)
					{
						oTripReturnTemp.SetReadyForWMS(nTripReturnID, true, null);
						bOK = true;
					}
				}
			}

			RFMCursorWait.Set(false);

			if (bOK)
			{
				grdTripsReturns_Restore();
			}
		}

		#endregion Set ReadyForWMS

		#region Set DeliveryNeed

		private void OutputsSetDeliveryNeed(bool bSet)
		{
			if (grdOutputs.DataSource == null ||
				grdOutputs.Rows.Count == 0 ||
				grdOutputs.CurrentRow == null ||
				!oOutputCur.ID.HasValue)
				return;

			int nOutputID = (int)oOutputCur.ID; 
			Output oOutputTemp = new Output();
			oOutputTemp.ReFillOne((int)oOutputCur.ID);
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
				if (oOutputCur.DeliveryNeed)
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
				if (!oOutputCur.DeliveryNeed)
				{
					RFMMessage.MessageBoxError("Задание на расход не требует доставки...");
					return;
				}

				// снимаем признак
				RFMCursorWait.Set(true);
				oOutputTemp.SetDeliveryNeed(nOutputID, true, null);
			}
			RFMCursorWait.Set(false);

			grdOutputs_Restore();
		}

		private void InputsSetDeliveryNeed(bool bSet)
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
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

			grdInputs_Restore();
		}

		#endregion Set DeliveryNeed
		
		#region InputsDocumentsCreateFromInputs

		private void InputsDocumentsCreateFromInputs()
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
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
			oInputDocument.FillDataAsync();
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
						grdInputs_Restore();
					}
				}
				*/
				if (StartForm(new frmInputsDocumentsEdit((int)oInputCur.ID, 0)) == DialogResult.Yes)
				{
					grdInputs_Restore();
				}
			}
		}

		#endregion InputsDocumentsCreateFromInputs

		#region InputsUpdateFromInputsDocuments

		private void InputsUpdateFromInputsDocuments()
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			oInputCur.ReFillOne((int)oInputCur.ID);

			if (!oInputCur.InputsDocumentsExists)
			{
				RFMMessage.MessageBoxError("Задание на приход не имеет приходных документов...");
				return;
			}

			oInputCur.UpdateFromInputsDocuments((int)oInputCur.ID); 
			grdInputs_Restore();
		}

		#endregion InputsUpdateFromInputsDocuments

		#region Quality, Veterinary 

		#region InputsQualityData

		private void InputsQualityData()
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			if (StartForm(new frmGoodsQualitiesEdit(null, (int)oInputCur.ID, null)) == DialogResult.Yes)
			{
				grdInputs_Restore();
			}
		}

		#endregion InputsQualityData

		#region InputsVeterinaryData

		private void InputsVeterinaryData()
		{
			if (grdInputs.DataSource == null ||
				grdInputs.Rows.Count == 0 ||
				grdInputs.CurrentRow == null ||
				!oInputCur.ID.HasValue)
				return;

			if (StartForm(new frmGoodsVeterinariesEdit(null, (int)oInputCur.ID, null)) == DialogResult.Yes)
			{
				grdInputs_Restore();
			}
		}

		#endregion InputsVeterinaryData

		#endregion Quality, Veterinary

		#region Acts

		private void CreateAct()
		{
			int nActID = 0;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.DataSource == null ||
					grdOutputs.Rows.Count == 0 ||
					grdOutputs.CurrentRow == null ||
					!oOutputCur.ID.HasValue)
					return;

				oOutputCur.ReFillOne((int)oOutputCur.ID);

				if (!oOutputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на расход не подтверждено.\nВвод акта невозможен.");
					return;
				}
				if (oOutputCur.TripExists)
				{
					Trip oTripOutputAct = new Trip();
					oTripOutputAct.ReFillOne((int)oOutputCur.TripID);
					if (oTripOutputAct.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Рейс, в который включено задание на расход, уже подтвержден.\nВвод акта невозможен.");
						return;
					}
				}

				if (oOutputCur.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("Для складского задания уже существует акт.\nСоздать еще один акт?") != DialogResult.Yes)
						return;
				}

				if (StartForm(new frmActsEdit(nActID, null, (int)oOutputCur.ID)) == DialogResult.Yes)
				{
					grdOutputs_Restore();
				}
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.DataSource == null ||
					grdInputs.Rows.Count == 0 ||
					grdInputs.CurrentRow == null ||
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
					grdInputs_Restore();
				}
			}

			if (sPageName.Contains("RETURNS"))
				return;
		}

		#endregion Acts

	#endregion

	#region Filters Choose

        #region OutputsPartners

        private void ucSelectRecordID_OutputsPartners_Restore()
        {
            if (ucSelectRecordID_OutputsPartners.sourceData == null)
            {
                Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, false, true))
				{
					ucSelectRecordID_OutputsPartners.Restore(oPartner.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_OutputsPartners.Restore();
            }
        }

		#endregion

		#region OutputsTypes

        private void ucSelectRecordID_OutputsTypes_Restore()
        {
            if (ucSelectRecordID_OutputsTypes.sourceData == null)
            {
				if (Utilities.FillData_OutputsTypes(oOutputList))
				{
					ucSelectRecordID_OutputsTypes.Restore(oOutputList.TableOutputsTypes);
				}
            }
            else
            {
                ucSelectRecordID_OutputsTypes.Restore();
            }
        }

		#endregion

        #region InputsPartners

        private void ucSelectRecordID_InputsPartners_Restore()
        {
            if (ucSelectRecordID_InputsPartners.sourceData == null)
            {
                Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner, false, true, false))
				{
					ucSelectRecordID_InputsPartners.Restore(oPartner.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_InputsPartners.Restore();
            }
        }

		#endregion

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

		#endregion

		#region Cars

        private void ucSelectRecordID_Cars_Restore()
        {
            if (ucSelectRecordID_Cars.sourceData == null)
            {
                Car oCar = new Car();
				if (Utilities.FillData_Cars(oCar))
				{
					ucSelectRecordID_Cars.Restore(oCar.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_Cars.Restore();
            }
        }

		#endregion Cars

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

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			RFMCursorWait.LockWindowUpdate(Handle); 
			
			dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(-1).Date;
			dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(2).Date;

			optDeliveryNeedAll.Checked = true;

            ucSelectRecordID_Owners.ClearData();

            ucSelectRecordID_OutputsTypes.ClearData();
            ucSelectRecordID_OutputsPartners.ClearData();

            ucSelectRecordID_InputsTypes.ClearData();
            ucSelectRecordID_InputsPartners.ClearData();

			optReadyForWMSAll.Checked = true;
			optIsConfirmedNot.Checked = true;

			optTripExistsAll.Checked = true;
			numTripID.Value = 0;
			txtTripAliasContext.Text = "";

			ucSelectRecordID_Cars.ClearData();

			txtERPCodeContext.Text = "";

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

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);

			tabOutputs.IsNeedRestore = 
			tabInputs.IsNeedRestore = 
			tabTripsReturns.IsNeedRestore = 
				true;
		}

	#endregion Terms clear

    }
}