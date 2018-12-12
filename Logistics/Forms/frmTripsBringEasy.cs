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
	public partial class frmTripsBringEasy : RFMFormChild
	{
		private int nTripID;
		private Trip oTrip;

		int nCarPointsQnt = 0;
		decimal nCarTonnage = 0, nCarVolume = 0, nCarPalletsQnt = 0;

		int nOutputsDocumentsQnt = 0, nOutputsDocumentsPartnersQnt = 0, nOutputsDocumentsPointsQnt = 0;
		decimal nOutputsDocumentsNetto = 0, nOutputsDocumentsBrutto = 0, nOutputsDocumentsVolume = 0, nOutputsDocumentsPalletsQnt = 0;

		private OutputDocument oOutputDocumentCur;
		private OutputDocument oOutputDocumentList;

		DateTime dEmptyDate = new DateTime(1900, 1, 1, 0, 0, 0);

		public int? _SelectedID = null;


		public frmTripsBringEasy(int _nTripID)
		{
			nTripID = _nTripID;

			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oOutputDocumentCur = new OutputDocument();
				oOutputDocumentList = new OutputDocument();
				if (oOutputDocumentCur.ErrorNumber != 0 ||
					oOutputDocumentList.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmTripsBringEasy_Load (object sender, EventArgs e)
		{
			bool bResult = true;

			oTrip.ID = nTripID;
			oTrip.FillDataAsync();
			if (oTrip.ErrorNumber != 0 || oTrip.MainTable.Rows.Count != 1)
			{
				RFMMessage.MessageBoxError("ќшибка при получении данных о рейсе...");
				bResult = false;
			}

			if (bResult)
			{
				oTrip.FillOne();
				
				dtpDateTrip.Value = oTrip.DateTrip;
				numTripNumber.Value = oTrip.TripNumber;
				txtAlias.Text = oTrip.Alias;

				if (oTrip.CarID.HasValue)
				{
					optOurCar.Checked = true;
				}
				else
				{
					if (oTrip.SelfDelivery)
					{
						optSelfDelivery.Checked = true;
					}
					else
					{
						optRentCar.Checked = true;
					}
				}

				txtNote.Text = oTrip.Note;
				txtNoteExecute.Text = oTrip.NoteExecute;
			}
	
			if (bResult)
			{
				bResult = grdOutputsDocuments_Restore();  
			}

			if (!bResult)
			{
				Dispose();
			}

			tcOutputsDocumentsGoods.Init();
			txtNoteExecute.Select(); 
		}

		#region Tab Restore

		private bool tabOutputsDocumentsData_Restore()
		{
			grdOutputsDocuments_Restore();
			grdOutputsDocuments.Select();
			grdOutputsDocuments_CurrentRowChanged(grdOutputsDocuments);
			return (true);
		}

		private bool tabOutputsDocumentsGoods_Restore()
		{
			return grdOutputsDocumentsGoods_Restore();
		}

		#endregion Tab restore


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
			string sText = "";
			if (grdOutputsDocuments.Rows.Count > 0)
			{
				foreach (DataRow dr in oTrip.TableOutputsDocumentsInTrip.Rows)
				{
					if (Convert.IsDBNull(dr["DateBring"]) || dr["DateBring"] == null)
					{
						sText += dr["PartnerTargetName"].ToString() + " (код " + dr["ID"].ToString() + ")" + "\n";
					}
				}
			}
			if (sText != "")
			{
				if (RFMMessage.MessageBoxYesNo("ќбнаружены расходные документы, по которым не зарегистрирован факт доставки товара получателю: \n" + sText +
					"¬се-таки сохранить?") != DialogResult.Yes)
					return;
			}

			oTrip.NoteExecute = txtNoteExecute.Text.Trim();

			// добрались. сохран€ем.
			oTrip.ClearError();
			oTrip.PreConfirm();
			if (oTrip.ErrorNumber == 0)
			{
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}

		#region ShowTotal

		#region TotalInfo

		private void ShowTotalInfo(string sMode)
		{
			ClearCarInfo();
			ClearTotalInfo(); 
			if (oTrip.CarID.HasValue)
			{
				Car oCarSelected = new Car();
				oCarSelected.ReFillOne((int)oTrip.CarID);
				CarInfo(oCarSelected);
				CarOutputsInputsDocumentsInfo(oCarSelected, false);
			}
			else
			{
				if (sMode == "OutputsDocuments".ToUpper())
				{
					txtOutputsDocumentsQnt.Text = nOutputsDocumentsQnt.ToString();
					txtOutputsPointsQnt.Text = nOutputsDocumentsPointsQnt.ToString();
					txtOutputsNetto.Text = nOutputsDocumentsNetto.ToString();
					txtOutputsBrutto.Text = nOutputsDocumentsBrutto.ToString("#####0.0");
					txtOutputsVolume.Text = nOutputsDocumentsVolume.ToString("#####0.0");
					txtOutputsPalletsQnt.Text = nOutputsDocumentsPalletsQnt.ToString("#####0.0");
				}
			}
		}

		private void ClearTotalInfo()
		{
			ClearCarInfo();

			txtOutputsBruttoPercent.DisabledBackColor =
			txtOutputsVolumePercent.DisabledBackColor =
			txtOutputsPalletsQntPercent.DisabledBackColor =
			txtOutputsBruttoPercent.BackColor =
			txtOutputsVolumePercent.BackColor =
			txtOutputsPalletsQntPercent.BackColor =
			txtOutputsVolume.BackColor;

			txtOutputsPointsQnt.Text = 
			txtOutputsNetto.Text = 
			txtOutputsBrutto.Text = 
			txtOutputsVolume.Text = 
			txtOutputsPalletsQnt.Text = 
			txtOutputsBruttoPercent.Text =
			txtOutputsVolumePercent.Text =
			txtOutputsPalletsQntPercent.Text =
				"";

		}

		#endregion TotalInfo

		#region CarInfo

		private void CarInfo(Car oCarTemp)
		{
			ClearCarInfo();

			nCarPointsQnt = oCarTemp.MaxPointsQnt;
			nCarTonnage = oCarTemp.Tonnage;
			nCarVolume = oCarTemp.Volume;
			nCarPalletsQnt = oCarTemp.MaxPalletsQnt;
		}

		private void ClearCarInfo()
		{
			nCarPointsQnt = 0;
			nCarTonnage = 0;
			nCarVolume = 0;
			nCarPalletsQnt = 0;
		}

		#endregion CarInfo

		#region OutputsInputsDocumentsInfo

		private void CarOutputsInputsDocumentsInfo(Car oCarTemp, bool bDocuments)
		{
			CarInfo(oCarTemp);

			txtOutputsDocumentsQnt.Text = nOutputsDocumentsQnt.ToString();
			txtOutputsPointsQnt.Text = nOutputsDocumentsPointsQnt.ToString() + "/" + oCarTemp.MaxPointsQnt.ToString();
			txtOutputsNetto.Text = nOutputsDocumentsNetto.ToString();
			txtOutputsBrutto.Text = nOutputsDocumentsBrutto.ToString("#####0.0") + "/" + oCarTemp.Tonnage.ToString("#####0.0");
			txtOutputsVolume.Text = nOutputsDocumentsVolume.ToString("#####0.0") + "/" + oCarTemp.Volume.ToString("#####0.0");
			txtOutputsPalletsQnt.Text = nOutputsDocumentsPalletsQnt.ToString("#####0.0") + "/" + oCarTemp.MaxPalletsQnt.ToString("#####0.0");

			if (oCarTemp.Tonnage != 0)
			{
				txtOutputsBruttoPercent.Text = ((decimal)(nOutputsDocumentsBrutto * 100 / oCarTemp.Tonnage)).ToString("###");
			}
			if (oCarTemp.Volume != 0)
			{
				txtOutputsVolumePercent.Text = ((decimal)(nOutputsDocumentsVolume * 100 / oCarTemp.Volume)).ToString("###");
			}
			if (oCarTemp.MaxPalletsQnt != 0)
			{
				txtOutputsPalletsQntPercent.Text = ((decimal)(nOutputsDocumentsPalletsQnt * 100 / oCarTemp.MaxPalletsQnt)).ToString("###");
			}

			if (nOutputsDocumentsBrutto > oCarTemp.Tonnage && oCarTemp.Tonnage > 0)
			{
				txtOutputsBruttoPercent.BackColor = Color.LightSalmon;
			}
			if (nOutputsDocumentsVolume > oCarTemp.Volume && oCarTemp.Volume > 0)
			{
				txtOutputsVolumePercent.BackColor = Color.LightSalmon;
			}
			if (nOutputsDocumentsPalletsQnt > oCarTemp.MaxPalletsQnt && oCarTemp.MaxPalletsQnt > 0)
			{
				txtOutputsPalletsQntPercent.BackColor = Color.LightSalmon;
			}
			return;
		}

		#endregion OutputsInputsDocumentsInfo

		#endregion ShowTotal

		#region RowEnter, CellFormatting

		private void grdOutputsDocuments_CurrentRowChanged(object sender)
		{
			if (grdOutputsDocuments.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView grd = grdOutputsDocuments;
			if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
				return;

			int rowIndex = grd.CurrentRow.Index;

			btnOutputsDocumentBring.Enabled =
			btnOutputsDocumentBringZero.Enabled =
				false;

			if (grd.IsStatusRow(rowIndex))
			{
				oOutputDocumentCur.ClearOne();
			}
			else
			{
				// заполнение объекта по текущей строке 
				DataRow r = ((DataRowView)((DataGridViewRow)grdOutputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
				oOutputDocumentCur.FillOne(r);
				btnOutputsDocumentBring.Enabled = 
				btnOutputsDocumentBringZero.Enabled = 
					oOutputDocumentCur.IsConfirmed && !oOutputDocumentCur.IsBrought;
			}
			tcOutputsDocumentsGoods.SetAllNeedRestore(true);
		}

		private void grdOutputsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
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

			// прив€зка с старому рейсу
			if (chkOutputsShowCarried.Checked)
			{
				if (Convert.IsDBNull(r["TripID"]) ||
					Convert.ToInt32(r["TripID"]) != nTripID)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
					e.CellStyle.BackColor = Color.LightPink;
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
				if (!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"] ||
					!Convert.IsDBNull(e.Value) && Convert.ToDecimal(e.Value) != Convert.ToInt32(e.Value))
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

		#endregion 

		#region Restore

		#region Grid

		private bool grdOutputsDocuments_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputDocumentCur.ClearOne(); 

			oOutputDocumentList.ClearError();
			oOutputDocumentList.ClearFilters();
			oOutputDocumentList.ID = null;
			oOutputDocumentList.IDList = null;

			grdOutputsDocuments.GetGridState();

			grdOutputsDocumentsGoods.DataSource = null;

			oTrip.FillTableOutputsDocumentsInTrip(chkOutputsShowCarried.Checked);
			grdOutputsDocuments.IsLockRowChanged = true;
			grdOutputsDocuments.Restore(oTrip.TableOutputsDocumentsInTrip);

			tmrRestore.Enabled = true;

			RecalcSumOutputsDocuments();
			ShowTotalInfo("OUTPUTSDOCUMENTS");

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oTrip.ErrorNumber == 0);
		}

		private bool grdOutputsDocumentsGoods_Restore()
		{
			grdOutputsDocumentsGoods.GetGridState();
			grdOutputsDocumentsGoods.DataSource = null;
			if (grdOutputsDocuments.Rows.Count == 0 ||
				oOutputDocumentCur.ID == null ||
				(grdOutputsDocuments.CurrentRow != null && grdOutputsDocuments.IsStatusRow(grdOutputsDocuments.CurrentRow.Index)))
				return (true);

			oOutputDocumentList.FillTableOutputsDocumentsGoods((int)oOutputDocumentCur.ID);
			grdOutputsDocumentsGoods.Restore(oOutputDocumentList.TableOutputsDocumentsGoods);
			return (oOutputDocumentList.ErrorNumber == 0);
		}

		#endregion Grid

		private void chkShowCarried_CheckedChanged(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);
			grdOutputsDocuments_Restore();
			RFMCursorWait.Set(false);
		}

		#endregion Restore

		#region ReCalc
		
		private void RecalcSumOutputsDocuments()
		{
			int nPartnersQnt = 0, nPointsQnt = 0;
			decimal nNetto = 0, nBrutto = 0, nVolume = 0, nPalletsQnt = 0;
			nOutputsDocumentsQnt = oTrip.TableOutputsDocumentsInTrip.Rows.Count;
			string sOutputsDocumentsList = "";
			foreach (DataRow r in oTrip.TableOutputsDocumentsInTrip.Rows)
			{
				sOutputsDocumentsList += r["ID"].ToString() + ",";
			}
			OutputDocument oOutputDocumentCalc = new OutputDocument();
			oOutputDocumentCalc.CalcSum(sOutputsDocumentsList, 
				ref nOutputsDocumentsQnt, ref nPartnersQnt, ref nPointsQnt, 
				ref nNetto, ref nBrutto, ref nVolume, ref nPalletsQnt);

			nOutputsDocumentsPartnersQnt = nPartnersQnt;
			nOutputsDocumentsPointsQnt = nPointsQnt;
			nOutputsDocumentsNetto = nNetto;
			nOutputsDocumentsBrutto = nBrutto;
			nOutputsDocumentsVolume = nVolume;
			nOutputsDocumentsPalletsQnt = nPalletsQnt;

			return;
		}

		#endregion ReCalc

		#region Service

		private void btnService_Click(object sender, EventArgs e)
		{
		}

		#endregion Service

		#region Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		#endregion Print

		#region Grid Buttons 

		private void btnOutputsDocumentBring_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 || grdOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
			return;

			int nOutputDocumentID = (int)oOutputDocumentCur.ID;
			oOutputDocumentCur.ReFillOne(nOutputDocumentID);

			if (!oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxInfo("≈ще не зарегистрирована отгрузка товара со склада.");
				return;
			}
			if (oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxInfo("”же подтверждена доставка товара получателю.");
				return;
			}
			if (!oOutputDocumentCur.TripID.HasValue ||
				(int)oOutputDocumentCur.TripID != nTripID)
			{
				RFMMessage.MessageBoxError("–асходный документ перенесен.");
				return;
			}

			if (StartForm(new frmOutputsDocumentsBring(nOutputDocumentID)) == DialogResult.Yes)
			{
				grdOutputsDocuments_Restore();
			}
		}

		private void btnOutputsDocumentZeroBring_Click(object sender, EventArgs e)
		{
			if (grdOutputsDocuments.Rows.Count == 0 || grdOutputsDocuments.CurrentRow == null ||
				!oOutputDocumentCur.ID.HasValue)
				return;

			int nOutputDocumentID = (int)oOutputDocumentCur.ID;
			oOutputDocumentCur.ReFillOne(nOutputDocumentID);

			if (!oOutputDocumentCur.IsConfirmed)
			{
				RFMMessage.MessageBoxInfo("≈ще не зарегистрирована отгрузка товара со склада.");
				return;
			}
			if (oOutputDocumentCur.IsBrought)
			{
				RFMMessage.MessageBoxInfo("”же подтверждена доставка товара получателю.");
				return;
			}
			if (!oOutputDocumentCur.TripID.HasValue ||
				(int)oOutputDocumentCur.TripID != nTripID)
			{
				RFMMessage.MessageBoxError("–асходный документ перенесен.");
				return;
			}

			if (RFMMessage.MessageBoxYesNo("¬нимание!\n\n" +
				"ѕри регистрации недоставки всего товара по документу количество доставленного товара равно нулю;\n" +
				"изменение доставленного количества стандартными средствами невозможно!\n\n" +
				"¬се-таки зарегистрировать недоставку всего товара по документу?") == DialogResult.Yes)
			{
				oOutputDocumentCur.FillTableOutputsDocumentsFailsReasons();
				_SelectedID = null;
				if (StartForm(new frmSelectID(this, oOutputDocumentCur.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "ѕричина недоставки получателю, ¬иновник")) == DialogResult.Yes)
				{
					if (!_SelectedID.HasValue)
					{
						RFMMessage.MessageBoxError("Ќе указана причина недоставки товара получателю.");
						return;
					}
					
					int nOutputDocumentFailReasonID = (int)_SelectedID;
					
					oOutputDocumentCur.BringZero(((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID, nOutputDocumentFailReasonID);
				}
				_SelectedID = null;

				grdOutputsDocuments_Restore();
			}
		}

		#endregion Grid Buttons

	}
}
