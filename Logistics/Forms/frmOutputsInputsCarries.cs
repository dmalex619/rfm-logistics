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
	public partial class frmOutputsInputsCarries : RFMFormChild
	{
		private Output oOutputCur; //текущий расход
		private OutputDocument oOutputDocumentInOutput;

		private OutputDocument oOutputDocumentCur;

		private Input oInputCur; //текущий приход
		private InputDocument oInputDocumentInInput;

		private Report oReportOutput;
		private Report oReportOutputDocument;
		private Report oReportInput;

		private Trip oTrip;

		// для фильтров
		public string _SelectedIDList;
		public string _SelectedText;

		private string sSelectedCarsIDList = null;
		private string sSelectedDriversIDList = null;
		private string sSelectedOwnersIDList = null;
		private string sSelectedPartnersIDList = null;

		public string _SelectedPackingsIDList;
		public string _SelectedPackingsAliasText;
		private string sSelectedPackingsIDList = null;


		public frmOutputsInputsCarries()
		{
			oOutputCur = new Output();
			if (oOutputCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oInputCur = new Input();
			if (oInputCur.ErrorNumber != 0)
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
			}

			if (IsValid)
			{
				oInputDocumentInInput = new InputDocument();
				if (oInputDocumentInInput.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			oOutputDocumentCur = new OutputDocument();
			if (oOutputDocumentCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oReportOutput = new Report();
			oReportOutputDocument = new Report();
			oReportInput = new Report();
			if (oReportOutput.ErrorNumber != 0 ||
				oReportOutputDocument.ErrorNumber != 0 ||
				oReportInput.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}


		private void frmOutputsInputsCarries_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			// назначение суммирования на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}
			grdOutputs.IsStatusShow =
			grdOutputsGoods.IsStatusShow =
			grdOutputsDocumentsInOutputs.IsStatusShow =
			grdOutputsDocuments.IsStatusShow =
			grdOutputsDocumentsGoods.IsStatusShow =
			grdInputs.IsStatusShow =
			grdInputsGoods.IsStatusShow =
			grdInputsDocuments.IsStatusShow =
				true;

			btnClearTerms_Click(null, null);

			tcList.Init();

			tcOutputsGoods.Init();
			tcOutputsDocumentsGoods.Init();
			tcInputsGoods.Init();

			btnPrint.ShortCutSet(mnuPrint);
			//btnService.ShortCutSet(mnuService);

			RFMCursorWait.Set(false);
		}

		#region Tab Restore

		#region Top Tabs

		private bool tabTerms_Restore()
		{
			btnPrint.Enabled =
			btnService.Enabled =
				false;
			return true;
		}

		private bool tabOutputs_Restore()
		{
			grdOutputs_Restore();
			btnPrint.Enabled =
			btnService.Enabled = 
				true;
			grdOutputs.Select();
			return (true);
		}

		private bool tabOutputsDocuments_Restore()
		{
			grdOutputsDocuments_Restore();
			btnPrint.Enabled =
			btnService.Enabled =
				true;
			grdOutputsDocuments.Select();
			return (true);
		}

		private bool tabInputs_Restore()
		{
			grdInputs_Restore();
			btnPrint.Enabled =
			btnService.Enabled =
				true;
			grdInputs.Select();
			return (true);
		}

		#endregion Top Tabs

		#region Bottom Tabs

		private bool tabOutputsDocumentsInOutputs_Restore()
		{
			return grdOutputsDocumentsInOutputs_Restore();
		}

		private bool tabOutputsGoods_Restore()
		{
			return grdOutputsGoods_Restore();
		}

		private bool tabOutputsDocumentsGoods_Restore()
		{
			return grdOutputsDocumentsGoods_Restore();
		}

		private bool tabInputsGoods_Restore()
		{
			return grdInputsGoods_Restore();
		}

		private bool tabInputsDocuments_Restore()
		{
			return grdInputsDocuments_Restore();
		}

		#endregion Bottom Tabs

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			btnService.ShortCutSet(null);

			if (tcList.SelectedTab.Name.ToUpper().Contains("TERMS"))
			{
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}

			if (sPageName.Contains("OUTPUTS") && !sPageName.Contains("DOCUMENTS"))
			{
				if (grdOutputs.DataSource == null ||
					grdOutputs.Rows.Count == 0)
					return;

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				grdOutputs.Select();
			}

			if (sPageName.Contains("OUTPUTS") && sPageName.Contains("DOCUMENTS"))
			{
				if (grdOutputsDocuments.DataSource == null ||
					grdOutputsDocuments.Rows.Count == 0)
					return;

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				btnService.ShortCutSet(mnuOutputsDocumentsService);

				grdOutputsDocuments.Select();
			}

			if (sPageName.Contains("INPUT"))
			{
				if (grdInputs.DataSource == null ||
					grdInputs.Rows.Count == 0)
					return;

				btnPrint.Enabled =
				btnService.Enabled =
					true;

				grdInputs.Select();
			}
		}

	#endregion Tab restore

	#region RowEnter, CellFormatting

		private void grdOutputs_CurrentRowChanged(object sender)
		{
			if (grdOutputs.IsLockRowChanged || 
				grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index))
				return;
			tmrRestore.Enabled = true;
		}

		private void grdOutputsDocuments_CurrentRowChanged(object sender)
		{
			if (grdOutputsDocuments.IsLockRowChanged ||
				grdOutputsDocuments.IsStatusRow(grdOutputsDocuments.CurrentRow.Index))
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

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView grd = new RFMDataGridView();

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS") && !sPageName.Contains("DOCUMENTS"))
			{
				grd = grdOutputs;
			}
			if (sPageName.Contains("OUTPUTS") && sPageName.Contains("DOCUMENTS"))
			{
				grd = grdOutputsDocuments;
			}
			if (sPageName.Contains("INPUTS"))
			{
				grd = grdInputs;
			}

			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;

			if (sPageName.Contains("OUTPUTS") && !sPageName.Contains("DOCUMENTS"))
			{
				if (grd.IsStatusRow(rowIndex))
				{
					oOutputCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oOutputCur.FillOne(r);
				}
				tcOutputsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("OUTPUTS") && sPageName.Contains("DOCUMENTS"))
			{
				if (grd.IsStatusRow(rowIndex))
				{
					oOutputDocumentCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oOutputDocumentCur.FillOne(r);
				}
				tcOutputsDocumentsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (grd.IsStatusRow(rowIndex))
				{
					oInputCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oInputCur.FillOne(r);
				}
				tcInputsGoods.SetAllNeedRestore(true);
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

			if (sColumnName.Contains("CarryImage".ToUpper()))
			{
				if ((bool)r["IsCopy"])
				{
					e.Value = Properties.Resources.Copy;
				}
				else
				{
					e.Value = Properties.Resources.ReDo;
				}
			}

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
			if (sGridName.Contains("OUTPUT"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOutputID"]))
				{
					//e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if (sGridName.Contains("INPUT"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputID"]))
				{
					//e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			// копирование
			if ((bool)r["IsCopied"])
			{
				//e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}
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
                    if (sColumnName.Contains("OUTPUT"))
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

			if (sColumnName.Contains("CarryImage".ToUpper()))
			{
				if ((bool)r["IsCopy"])
				{
					e.Value = Properties.Resources.Copy;
				}
				else
				{
					e.Value = Properties.Resources.ReDo;
				}
			}

			// подтверждение отгрузки и доставки клиенту
			if (sColumnName.Contains("IsConfirmedImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					if (sGridName.Contains("OUTPUT"))
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
				if (sGridName.Contains("OUTPUT"))
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

			/*
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
			*/

			if (sGridName.Contains("InOutput".ToUpper()))
			{
				DataRow o = ((DataRowView)grdOutputs.Rows[grdOutputs.CurrentRow.Index].DataBoundItem).Row;
				if ((bool)o["IsCopy"])
				{
					//if (("," + o["OutputsDocumentsCarriesList"].ToString() + ",").Contains("," + r["ID"] + ","))
					if ((int)r["ID"] != (int)o["OldOutputDocumentID"])
					{
						e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Italic);
						e.CellStyle.ForeColor = Color.Silver;
					}
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

	#endregion Cells...

	#region Restore

		#region Outputs

		private bool grdOutputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputCur.ClearOne();

			oReportOutput.ClearError();

			grdOutputsGoods.DataSource = null;
			grdOutputsDocumentsInOutputs.DataSource = null;

			grdOutputs.GetGridState();

			// собираем условия
			bool? bIsConfirmed = null;
			if (optIsConfirmedNot.Checked) bIsConfirmed = false;
			if (optIsConfirmed.Checked) bIsConfirmed = true;
			oReportOutput.Report_TripsCarries(GetTripsList(), 1, 
				sSelectedOwnersIDList, GetPartnersList(), sSelectedPackingsIDList, bIsConfirmed) ;

			grdOutputs.IsLockRowChanged = true;

			grdOutputs.Restore(oReportOutput.MainTable);
			
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oReportOutput.ErrorNumber == 0);
		}

		private bool grdOutputsGoods_Restore()
		{
			grdOutputsGoods.GetGridState();
			grdOutputsGoods.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oOutputCur.FillTableOutputsGoods((int)oOutputCur.ID);
			grdOutputsGoods.Restore(oOutputCur.TableOutputsGoods);
			return (oOutputCur.ErrorNumber == 0);
		}

		private bool grdOutputsDocumentsInOutputs_Restore()
		{
			grdOutputsDocumentsInOutputs.GetGridState();
			grdOutputsDocumentsInOutputs.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			DataRow o = ((DataRowView)grdOutputs.Rows[grdOutputs.CurrentRow.Index].DataBoundItem).Row;
			oOutputDocumentInOutput.FilterOutputsList = o["OldOutputID"].ToString();//oOutputCur.ID.ToString();
			oOutputDocumentInOutput.FillData();
			grdOutputsDocumentsInOutputs.Restore(oOutputDocumentInOutput.MainTable);
			return (oOutputDocumentInOutput.ErrorNumber == 0);
		}

		#endregion Outputs

		#region Inputs

		private bool grdInputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputCur.ClearOne();

			oReportInput.ClearError();

			grdInputsGoods.DataSource = null;
			grdInputsDocuments.DataSource = null;

			grdInputs.GetGridState();

			// собираем условия
			bool? bIsConfirmed = null;
			if (optIsConfirmedNot.Checked) bIsConfirmed = false;
			if (optIsConfirmed.Checked) bIsConfirmed = true;
			oReportInput.Report_TripsCarries(GetTripsList(), 3,
				sSelectedOwnersIDList, GetPartnersList(), sSelectedPackingsIDList, bIsConfirmed);

			grdInputs.IsLockRowChanged = true;

			grdInputs.Restore(oReportInput.MainTable);

			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oReportInput.ErrorNumber == 0);
		}

		private bool grdInputsGoods_Restore()
		{
			grdInputsGoods.GetGridState();
			grdInputsGoods.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
				return (true);

			oInputCur.FillTableInputsGoods((int)oInputCur.ID);
			grdInputsGoods.Restore(oInputCur.TableInputsGoods);
			return (oInputCur.ErrorNumber == 0);
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
			oInputDocumentInInput.FillData();
			grdInputsDocuments.Restore(oInputDocumentInInput.MainTable);
			return (oInputDocumentInInput.ErrorNumber == 0);
		}

		#endregion Inputs 

		#region OutputsDocuments

		private bool grdOutputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputDocumentCur.ClearOne();

			oReportOutputDocument.ClearError();

			grdOutputsDocumentsGoods.DataSource = null;

			grdOutputsDocuments.GetGridState();

			// собираем условия
			bool? bIsConfirmed = null;
			if (optIsConfirmedNot.Checked) bIsConfirmed = false;
			if (optIsConfirmed.Checked) bIsConfirmed = true;

			oReportOutputDocument.Report_TripsCarries(GetTripsList(), 2,
				sSelectedOwnersIDList, GetPartnersList(), sSelectedPackingsIDList, bIsConfirmed);

			grdOutputsDocuments.IsLockRowChanged = true;

			grdOutputsDocuments.Restore(oReportOutputDocument.MainTable);

			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oReportOutputDocument.ErrorNumber == 0);
		}

		private bool grdOutputsDocumentsGoods_Restore()
		{
			grdOutputsDocumentsGoods.GetGridState();
			grdOutputsDocumentsGoods.DataSource = null;
			if (grdOutputsDocuments.Rows.Count == 0 ||
				oOutputDocumentCur.ID == null ||
				(grdOutputsDocuments.CurrentRow != null && grdOutputsDocuments.IsStatusRow(grdOutputsDocuments.CurrentRow.Index)))
				return (true);

			oOutputDocumentCur.FillTableOutputsDocumentsGoods((int)oOutputDocumentCur.ID);

			grdOutputsDocumentsGoods.Restore(oOutputDocumentCur.TableOutputsDocumentsGoods);
			return (oOutputDocumentCur.ErrorNumber == 0);
		}

	#endregion OutputsDocuments

	#endregion Restore

	#region Buttons

		private void btnHelp_Click(object sender, EventArgs e)
		{
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

	#endregion

	#region Menus 

		private void btnPrint_Click(object sender, EventArgs e)
		{
			btnPrint.ShortCutShow();
		}

		private void mniPrintReport_Click(object sender, EventArgs e)
		{

		}

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}

		private void mniOutputsDocumentsService_GuiltyEmployees_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.CurrentRow == null || 
				grdOutputsDocuments.IsStatusRow(grdOutputsDocuments.CurrentRow.Index)) 
				return;

			DataRow r  = ((DataRowView)((DataGridViewRow)grdOutputsDocuments.Rows[grdOutputsDocuments.CurrentRow.Index]).DataBoundItem).Row;
			if (Convert.IsDBNull(r["OldOutputDocumentID"]))
				return;

			int nOldOutputDocumentID = (int)r["OldOutputDocumentID"];
			int nNewOutputDocumentID = (int)r["NewOutputDocumentID"];
			DateTime dDateCarry = Convert.ToDateTime(r["DateCarry"]);

			OutputDocument oOutputDocumentCarry = new OutputDocument();
			oOutputDocumentCarry.ReFillOne(nOldOutputDocumentID);
			oOutputDocumentCarry.FillTableOutputsDocumentsCarries(nOldOutputDocumentID);
			if (oOutputDocumentCarry.ErrorNumber != 0 || 
				!oOutputDocumentCarry.DS.Tables.Contains("TableOutputsDocumentsCarries") ||
				oOutputDocumentCarry.DS.Tables["TableOutputsDocumentsCarries"] == null ||
				oOutputDocumentCarry.DS.Tables["TableOutputsDocumentsCarries"].Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о переносах и копиях расходного документа...");
				return; 
			}

			int? nCarryID = null;
			DataTable dtCarries = oOutputDocumentCarry.DS.Tables["TableOutputsDocumentsCarries"];
			foreach(DataRow roc in dtCarries.Rows)
			{
				int nX_OldOutputDocumentID = (int)roc["OutputDocumentID"];
				int nX_NewOutputDocumentID = nX_OldOutputDocumentID;
				if (!Convert.IsDBNull(roc["NewOutputDocumentID"]))
					nX_NewOutputDocumentID = (int)roc["NewOutputDocumentID"];
				if (nOldOutputDocumentID != nX_OldOutputDocumentID ||
					nNewOutputDocumentID != nX_NewOutputDocumentID ||
					DateTime.Compare(dDateCarry, Convert.ToDateTime(roc["DateCarry"])) != 0)
					continue;

				nCarryID = (int)roc["ID"];
				break;
			}
			if (!nCarryID.HasValue) 
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных о переносе/копии расходного документа...");
				return; 
			}

			if (StartForm(new frmOutputsDocumentsGuiltyEmployees((int)nCarryID, true)) == DialogResult.Yes)
			{
				grdOutputsDocuments_Restore();
			}
		}

	#endregion

	#region Filters Choose

		#region Cars

		private void btnCarsChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Car oCar = new Car();
			oCar.FillData();
			if (oCar.ErrorNumber != 0 || oCar.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных...");
				return;
			}
			if (oCar.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			if (StartForm(new frmSelectID(this, oCar.MainTable, "Name,Actual", "Машина,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnCarsClear_Click(null, null);
					return;
				}

				sSelectedCarsIDList = "," + _SelectedIDList;
				txtCarsChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtCarsChoosen, txtCarsChoosen.Text);

				tabOutputs.IsNeedRestore =
				tabInputs.IsNeedRestore =
				tabOutputsDocuments.IsNeedRestore =
					true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnCarsClear_Click(object sender, EventArgs e)
		{
			tabOutputs.IsNeedRestore = 
			tabInputs.IsNeedRestore = 
			tabOutputsDocuments.IsNeedRestore = 
				true;

			ttToolTip.SetToolTip(txtCarsChoosen, "не выбраны");
			sSelectedCarsIDList = null;
			txtCarsChoosen.Text = "";
		}

		#endregion Cars

		#region Drivers

		private void btnDriversChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Driver oDriver = new Driver();
			oDriver.FillData();
			oDriver.FilterActual = true;
			if (oDriver.ErrorNumber != 0 || oDriver.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных...");
				return;
			}
			if (oDriver.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			if (StartForm(new frmSelectID(this, oDriver.MainTable, "Name,Actual", "Клиент,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnDriversClear_Click(null, null);
					return;
				}

				sSelectedDriversIDList = "," + _SelectedIDList;
				txtDriversChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtDriversChoosen, txtDriversChoosen.Text);

				tabOutputs.IsNeedRestore =
				tabInputs.IsNeedRestore =
				tabOutputsDocuments.IsNeedRestore =
					true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnDriversClear_Click(object sender, EventArgs e)
		{
			tabOutputs.IsNeedRestore =
			tabInputs.IsNeedRestore =
			tabOutputsDocuments.IsNeedRestore =
				true;

			ttToolTip.SetToolTip(txtDriversChoosen, "не выбраны");
			sSelectedDriversIDList = null;
			txtDriversChoosen.Text = "";
		}

		#endregion Drivers

		#region Owners

		private void btnOwnersChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oOwner = new Partner();
			oOwner.FilterActual = true;
			oOwner.FilterIsOwner = true;
			oOwner.FillData();
			if (oOwner.ErrorNumber != 0 || oOwner.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных...");
				return;
			}
			if (oOwner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			if (StartForm(new frmSelectID(this, oOwner.MainTable, "Name,Actual", "Владелец,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnOwnersClear_Click(null, null);
					return;
				}

				sSelectedOwnersIDList = "," + _SelectedIDList;
				txtOwnersChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtOwnersChoosen, txtOwnersChoosen.Text);

				tabOutputs.IsNeedRestore =
				tabInputs.IsNeedRestore =
				tabOutputsDocuments.IsNeedRestore =
					true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnOwnersClear_Click(object sender, EventArgs e)
		{
			tabOutputs.IsNeedRestore =
			tabInputs.IsNeedRestore =
			tabOutputsDocuments.IsNeedRestore =
				true;

			ttToolTip.SetToolTip(txtOwnersChoosen, "не выбраны");
			sSelectedOwnersIDList = null;
			txtOwnersChoosen.Text = "";
		}

		#endregion Owners

		#region Partners

		private void btnPartnersChoose_Click(object sender, EventArgs e)
		{
			_SelectedIDList = null;
			_SelectedText = "";

			Partner oPartner = new Partner();
			oPartner.IsCustomer = true;
			oPartner.FilterActual = true;
			oPartner.FillData();
			if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
			{
				RFMMessage.MessageBoxError("Ошибка при получении данных...");
				return;
			}
			if (oPartner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			if (StartForm(new frmSelectID(this, oPartner.MainTable, "Name,Actual", "Клиент,Акт.", true)) == DialogResult.Yes)
			{
				if (_SelectedIDList == null || !_SelectedIDList.Contains(","))
				{
					btnPartnersClear_Click(null, null);
					return;
				}

				sSelectedPartnersIDList = "," + _SelectedIDList;
				txtPartnersChoosen.Text = _SelectedText;
				ttToolTip.SetToolTip(txtPartnersChoosen, txtPartnersChoosen.Text);

				tabOutputs.IsNeedRestore =
				tabInputs.IsNeedRestore =
				tabOutputsDocuments.IsNeedRestore =
					true;
			}

			_SelectedIDList = null;
			_SelectedText = "";
		}

		private void btnPartnersClear_Click(object sender, EventArgs e)
		{
			tabOutputs.IsNeedRestore =
			tabInputs.IsNeedRestore =
			tabOutputsDocuments.IsNeedRestore =
				true;

			ttToolTip.SetToolTip(txtPartnersChoosen, "не выбраны");
			sSelectedPartnersIDList = null;
			txtPartnersChoosen.Text = "";
			txtPartnerNameContext.Text = "";
		}

		#endregion Partners

		#region Packings

		private void btnPackingsChoose_Click(object sender, EventArgs e)
		{
			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";

			if (StartForm(new frmSelectOnePacking(this, true)) == DialogResult.Yes)
			{
				if (_SelectedPackingsIDList == null || !_SelectedPackingsIDList.Contains(","))
				{
					btnPackingsClear_Click(null, null);
					return;
				}

				sSelectedPackingsIDList = "," + _SelectedPackingsIDList;
				txtPackingsChoosen.Text = _SelectedPackingsAliasText;
				ttToolTip.SetToolTip(txtPackingsChoosen, txtPackingsChoosen.Text);
				
				tabOutputs.IsNeedRestore = 
				tabInputs.IsNeedRestore = 
				tabOutputsDocuments.IsNeedRestore = 
					true;
			}

			_SelectedPackingsIDList = null;
			_SelectedPackingsAliasText = "";
		}

		private void btnPackingsClear_Click(object sender, EventArgs e)
		{
			tabOutputs.IsNeedRestore =
			tabInputs.IsNeedRestore =
			tabOutputsDocuments.IsNeedRestore =
				true;

			ttToolTip.SetToolTip(txtPackingsChoosen, "не выбраны");
			sSelectedPackingsIDList = null;
			txtPackingsChoosen.Text = "";
		}

		#endregion

		private string GetTripsList()
		{
			string sList = "";

			oTrip.ClearError();
			oTrip.ClearFilters(); 
			// даты
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oTrip.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oTrip.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}
			// номер, контекст рейса; машина, водитель
			if (txtTripAliasContext.Text.Trim().Length > 0)
			{
				oTrip.FilterAliasContext = txtTripAliasContext.Text.Trim();
			}
			if (sSelectedCarsIDList != null && sSelectedCarsIDList.Length > 0)
			{
				oTrip.FilterCarsList = sSelectedCarsIDList;
			}
			if (sSelectedDriversIDList != null && sSelectedDriversIDList.Length > 0)
			{
				oTrip.FilterDriversEmployeesList = sSelectedDriversIDList;
			}
			if (numTripID.Value > 0)
			{
				oTrip.IDList = numTripID.Value.ToString();
			}
			oTrip.FillData();
			if (oTrip.ErrorNumber == 0 && oTrip.MainTable != null)
			{
				foreach (DataRow tr in oTrip.MainTable.Rows)
				{
					sList += tr["ID"].ToString().Trim() + ",";
				}
			}
			return (sList);
		}

		private string GetPartnersList()
		{
			string sPartnersList = null;
			if (txtPartnerNameContext.Text.Trim().Length > 0)
			{
				Partner oPartnerTemp = new Partner();
				oPartnerTemp.FilterActual = true;
				oPartnerTemp.FilterNameContext = txtPartnerNameContext.Text.Trim();
				oPartnerTemp.FillData();
				sPartnersList = "";
				foreach (DataRow r in oPartnerTemp.MainTable.Rows)
				{
					sPartnersList += r["ID"] + ",";
				}
				if (sSelectedPartnersIDList != null)
					sPartnersList += sSelectedPartnersIDList;
			}
			else
			{
				if (sSelectedPartnersIDList != null)
					sPartnersList = sSelectedPartnersIDList;
			}
			return (sPartnersList);
		}

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
			dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(-1).Date;
			dtrDates.dtpEndDate.Value = DateTime.Now.Date; ;

			numTripID.Value = 0;
			txtTripAliasContext.Text = "";
			btnCarsClear_Click(null, null);
			btnDriversClear_Click(null, null);

			btnPartnersClear_Click(null, null);
			btnOwnersClear_Click(null, null);

			btnPackingsClear_Click(null, null);

			optIsConfirmedAll.Checked = true;

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
			}

			tabOutputs.IsNeedRestore = 
			tabInputs.IsNeedRestore = 
			tabOutputsDocuments.IsNeedRestore = 
				true;
		}

	#endregion Terms clear

	}
}