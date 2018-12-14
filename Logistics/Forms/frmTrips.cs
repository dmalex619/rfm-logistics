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
	public partial class frmTrips : RFMFormChild
    {
        #region ���������� ����������
        private Trip oTripList; //������ ������
		private Trip oTripCur; //������� ����
		private Trip oOtherList; //������ ������ - ��� ���������
		private Trip oOtherCur; //������� ���� - ��� ���������

		private Act oActInTrip;
		private Act oActInOther;
		private TripReturn oTripReturn;
		private Partner oPartner;

		private Host oHost;
		private int? nUserHostID = null;

		// ��� ��������
		public string _SelectedIDList;
		public string _SelectedText;

		public int? _SelectedID = null;
        #endregion ���������� ����������

        #region ��������� ���������
        const string TRIP_NOT_BEG = "���� ��� �� �����...";
		const string TRIP_NOT_END = "���� ��� �� �������...";
        #endregion ��������� ���������

        public frmTrips()
		{
			oTripList = new Trip();
			oTripCur = new Trip();
			if (oTripList.ErrorNumber != 0 ||
				oTripCur.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oOtherList = new Trip();
				oOtherCur = new Trip();
				if (oOtherList.ErrorNumber != 0 ||
					oOtherCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oActInTrip = new Act();
				oActInOther = new Act();
				if (oActInTrip.ErrorNumber != 0 ||
					oActInOther.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oTripReturn = new TripReturn();
				if (oTripReturn.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oPartner = new Partner();
				if (oPartner.ErrorNumber != 0)
				{
					IsValid = false;
				}
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

		private void frmTrips_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			nUserHostID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.HostID;
			
			lblHosts.Visible =
			ucSelectRecordID_Hosts.Visible =
			ucSelectRecordID_Hosts.Enabled =
				(oHost.Count() > 1 && !nUserHostID.HasValue);


			// ���������� ������������ �� �������
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}
			grcTrips_OutputsDocuments_DeliveryPrice.AgrType =
			grcTrips_OutputsDocuments_VeterinaryPrice.AgrType =
			grcOthers_OutputsDocuments_VeterinaryPrice.AgrType = 
				EnumAgregate.Sum;

			grdTrips.IsStatusShow =
			grdTrips_Puts.IsStatusShow =
			grdTrips_Inputs.IsStatusShow =
			grdTrips_OutputsDocuments.IsStatusShow =
			grdTrips_Outputs.IsStatusShow =
			grdTrips_InputsDocuments.IsStatusShow =
			grdTrips_Acts.IsStatusShow =
			grdTrips_TripsReturns.IsStatusShow =
				true;
			grdOthers.IsStatusShow = 
			grdOthers_Puts.IsStatusShow =
			grdOthers_Inputs.IsStatusShow =
			grdOthers_OutputsDocuments.IsStatusShow =
			grdOthers_Outputs.IsStatusShow =
			grdOthers_InputsDocuments.IsStatusShow =
			grdOthers_Acts.IsStatusShow =
				true;

			btnClearTerms_Click(null, null);

			tcList.Init();

			dtrDates.dtpBegDate.Select();

			RFMCursorWait.Set(false);
		}

	#region tabPages

		private bool tabTerms_Restore()
		{
			btnAdd.Enabled =
			btnAddByDate.Enabled =
			btnEdit.Enabled =
			btnDelete.Enabled =
			btnSetDateTime.Enabled = 
			btnBring.Enabled =
			btnTripReturnAutoCreate.Enabled = 
			btnConfirm.Enabled =
			btnConfirmOther.Enabled =
			btnPrint.Enabled = 
			btnService.Enabled =
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			btnConfirm.Visible = true;
			btnConfirmOther.Visible = false;

			dtrDates.dtpBegDate.Select();
			
			return (true);
		}

		private bool tabTrips_Restore()
		{
			grdTrips_Restore();
			btnAdd.Enabled =
			btnAddByDate.Enabled =
				true;
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;
			if (grdTrips.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnSetDateTime.Enabled =
				btnBring.Enabled =
				btnTripReturnAutoCreate.Enabled =
				btnConfirm.Enabled = 
				btnPrint.Enabled = 
				btnService.Enabled = 
					true;
				grdTrips.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnSetDateTime.Enabled =
				btnBring.Enabled =
				btnTripReturnAutoCreate.Enabled =
				btnConfirm.Enabled =  
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}

			btnConfirm.Visible = true;
		
			btnConfirmOther.Enabled =
			btnConfirmOther.Visible =
				false;

			ttToolTip.SetToolTip(btnTripReturnAutoCreate, "������� �������-������� � ���");

			return (true);
		}

		private bool tabOthers_Restore()
		{
			grdOthers_Restore();
			btnAdd.Enabled = true;
			btnAddByDate.Enabled = false;
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;
			if (grdOthers.Rows.Count > 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnSetDateTime.Enabled =
				btnBring.Enabled =
				btnTripReturnAutoCreate.Enabled =
				btnConfirmOther.Enabled = 
				btnPrint.Enabled =
				btnService.Enabled =
					true;
				grdOthers.Select();
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnSetDateTime.Enabled =
				btnBring.Enabled =
				btnTripReturnAutoCreate.Enabled =
				btnConfirmOther.Enabled =
				btnPrint.Enabled =
				btnService.Enabled =
					false;
			}

			btnConfirm.Enabled =
			btnConfirm.Visible =
				false;
			
			btnConfirmOther.Visible = true;

			ttToolTip.SetToolTip(btnTripReturnAutoCreate, "������� ���");

			return (true);
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sPageName = tcList.SelectedTab.Name.ToUpper();

			if (sPageName.Contains("TERMS"))
			{
				btnAdd.Enabled =
				btnAddByDate.Enabled =
				btnEdit.Enabled =
				btnDelete.Enabled =
				btnSetDateTime.Enabled =
				btnBring.Enabled =
				btnTripReturnAutoCreate.Enabled =
				btnConfirm.Enabled =  
				btnPrint.Enabled =
				btnService.Enabled =
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;

				btnConfirm.Visible = true;
				
				btnConfirmOther.Visible =
				btnConfirmOther.Enabled =
					false;
			}

			if (sPageName.Contains("TRIPS"))
			{
				btnPrint.ShortCutSet(mnuTripsPrint);
				btnService.ShortCutSet(mnuTripsService);

				btnAdd.Enabled =
				btnAddByDate.Enabled =
					true;

				btnConfirm.Visible = true;
					
				btnConfirmOther.Visible =
				btnConfirmOther.Enabled = 
					false;

				ttToolTip.SetToolTip(btnTripReturnAutoCreate, "������� �������-������� � ���");

				grdTrips.Select();

				if (grdTrips.Rows.Count > 0 && grdTrips.CurrentRow != null)
				{
					btnPrint.Enabled =
					btnService.Enabled =
						true;

					if (!tabTrips.IsNeedRestore)
					{
						if (!grdTrips.IsStatusRow(grdTrips.CurrentRow.Index))
						{
							grdTrips_CurrentRowChanged(null);
						}
					}
				}
			}

			if (sPageName.Contains("OTHERS"))
			{
				btnPrint.ShortCutSet(mnuTripsPrint);
				btnService.ShortCutSet(mnuTripsService);

				btnAdd.Enabled = true;
				btnAddByDate.Enabled = false;

				btnConfirm.Visible =
				btnConfirm.Enabled = 
					false;

				btnConfirmOther.Visible = true;

				ttToolTip.SetToolTip(btnTripReturnAutoCreate, "������� ���");

				grdOthers.Select();

				if (grdOthers.Rows.Count > 0 && grdOthers.CurrentRow != null)
				{
					btnPrint.Enabled =
					btnService.Enabled =
						true;

					if (!tabOthers.IsNeedRestore)
					{
						if (!grdOthers.IsStatusRow(grdOthers.CurrentRow.Index))
						{
							grdOthers_CurrentRowChanged(null);
						}
					}
				}
			}
		}

		#region Trips_Pages

		private bool tabTrips_Puts_Restore()
		{
			return (grdTrips_Puts_Restore());
		}

		private bool tabTrips_Outputs_Restore()
		{
			return (grdTrips_Outputs_Restore());
		}

		private bool tabTrips_OutputsDocuments_Restore()
		{
			return (grdTrips_OutputsDocuments_Restore());
		}

		private bool tabTrips_Inputs_Restore()
		{
			return (grdTrips_Inputs_Restore());
		}

		private bool tabTrips_InputsDocuments_Restore()
		{
			return (grdTrips_InputsDocuments_Restore());
		}

		private bool tabTrips_Acts_Restore()
		{
			return (grdTrips_Acts_Restore());
		}

		private bool tabTrips_TripsReturns_Restore()
		{
			return (grdTrips_TripsReturns_Restore());
		}

		private bool tabTrips_Partners_Restore()
		{
			return (grdTrips_Partners_Restore());
		}

		#endregion Trips_Pages

		#region Others_Pages

		private bool tabOthers_Puts_Restore()
		{
			return (grdOthers_Puts_Restore());
		}

		private bool tabOthers_Outputs_Restore()
		{
			return (grdOthers_Outputs_Restore());
		}

		private bool tabOthers_OutputsDocuments_Restore()
		{
			return (grdOthers_OutputsDocuments_Restore());
		}

		private bool tabOthers_Inputs_Restore()
		{
			return (grdOthers_Inputs_Restore());
		}

		private bool tabOthers_InputsDocuments_Restore()
		{
			return (grdOthers_InputsDocuments_Restore());
		}

		private bool tabOthers_Acts_Restore()
		{
			return (grdOthers_Acts_Restore());
		}

		#endregion Others_Pages
		
	#endregion TabPages

	#region PrepareIDList

		public void TripPrepareIDList(Trip oTrip, bool bMultiSelect)
		{
			TripPrepareIDList(oTrip, bMultiSelect, grdTrips);
		}

		public void TripPrepareIDList(Trip oTrip, bool bMultiSelect, RFMDataGridView grd)
		{
			oTrip.ID = null;
			oTrip.IDList = null;
			int? nTripID = 0;

			if (bMultiSelect && grd.IsCheckerShow)
			{
				// �� ��������
				oTrip.IDList = "";

				DataView dMarked;
				if (grd.Name.ToUpper().Contains("TRIPS"))
				{
					dMarked = new DataView(oTripList.MainTable);
					dMarked.Sort = grdTrips.GridSource.Sort;
					dMarked.RowFilter = "IsMarked = true";
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r["ID"]))
						{
							oTrip.IDList += r["ID"].ToString() + ",";
						}
					}
				}
				if (grd.Name.ToUpper().Contains("OTHERS"))
				{
					dMarked = new DataView(oOtherList.MainTable);
					dMarked.Sort = grdOthers.GridSource.Sort;
					dMarked.RowFilter = "IsMarked = true";
					foreach (DataRowView r in dMarked)
					{
						if (!Convert.IsDBNull(r["ID"]))
						{
							oTrip.IDList += r["ID"].ToString() + ",";
						}
					}
				}
			}
			else
			{
				// �� ������� ������
				if (grd.Name.ToUpper().Contains("TRIPS"))
				{
					nTripID = (int?)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;
				}
				if (grd.Name.ToUpper().Contains("OTHERS"))
				{
					nTripID = (int?)grdOthers.CurrentRow.Cells["grcOthers_ID"].Value;
				}

				if (nTripID.HasValue)
				{
					oTrip.ID = nTripID;
				}
			}
		}

	#endregion PrepareIDList

	#region RowEnter, CellFormatting

		private void grdTrips_CurrentRowChanged(object sender)
		{
			if (grdTrips.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdOthers_CurrentRowChanged(object sender)
		{
			if (grdOthers.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			int rowIndex = 0; 

			string sPageName = tcList.SelectedTab.Name.ToUpper();
			
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null)
				   return;
				
				rowIndex = grdTrips.CurrentRow.Index;

				btnPrint.Enabled =
				btnService.Enabled = 
					true;
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;

				if (grdTrips.IsStatusRow(rowIndex))
				{
					oTripCur.ClearOne();
					btnEdit.Enabled =
					btnDelete.Enabled = 
					btnBring.Enabled =
					btnTripReturnAutoCreate.Enabled =
					btnConfirm.Enabled =
						false;
				}
				else
				{
					// ���������� ������� �� ������� ������ 
					DataRow r = ((DataRowView)((DataGridViewRow)grdTrips.Rows[rowIndex]).DataBoundItem).Row;
					oTripCur.FillOne(r);
					btnEdit.Enabled = !oTripCur.IsConfirmed;
							/*
							!oTripCur.DateEnd.HasValue && 
							(oTripCur.ReadyForTripEnd == null || !oTripCur.ReadyForTripEnd);
							*/ 
					btnDelete.Enabled = !oTripCur.IsConfirmed && 
							!oTripCur.DateBeg.HasValue && !oTripCur.DateEnd.HasValue && 
							(!oTripCur.ReadyForTripBeg.HasValue || !(bool)oTripCur.ReadyForTripBeg) &&
							(!oTripCur.ReadyForTripEnd.HasValue || !(bool)oTripCur.ReadyForTripEnd);
					btnBring.Enabled = !oTripCur.IsConfirmed; // ???
					btnTripReturnAutoCreate.Enabled = !oTripCur.IsConfirmed;
                    //&& !oTripCur.IsTripReturnAutoAttached;
					btnConfirm.Enabled = !oTripCur.IsConfirmed && 
							(oTripCur.ReadyForTripEnd.HasValue && (bool)oTripCur.ReadyForTripEnd);

					mniTripsPrintDocuments.Enabled =
					mniTripsPrintDocumentsAll.Enabled =
					mniTripsPrintDocumentsOne.Enabled =
						true;
					mniTripsPrintDocuments_OneOutputDocument.Enabled =
					mniTripsPrintDocuments_OneInput.Enabled =
						false;

					mniTripsPrintBill.Enabled =
					mniTripsPrintBillShort.Enabled =
						true; // oTripCur.ReadyForTripBeg; // �������

					mniTripsPrintQualities.Enabled =
					mniTripsPrintVeterinaryBlankData.Enabled =
					mniTripsPrintTTNData.Enabled =
					mniTripsPrintOutputTTNData.Enabled = 
					mniTripsPrintGoodsGroupsList.Enabled =  
					mniTripsPrintInputsBill.Enabled =
						true;

					mniTripsPrintReportTripsList.Enabled =
					mniTripsPrintReportTripsListNotes.Enabled =
					mniTripsPrintReportTripBalance.Enabled =
					mniTripsPrintReportTripsPutsBalances.Enabled =  
						true;

					mniTripsServiceSetDateTime.Enabled =
					mniTripsServiceSetDateTimeBeg.Enabled =
					mniTripsServiceSetDateTimeEnd.Enabled =
					mniTripsServiceClearDateTime.Enabled =
					mniTripsServiceClearDateTimeBeg.Enabled =
					mniTripsServiceClearDateTimeEnd.Enabled =
						true; // �������

					mniTripsServiceSetReadyForWMS.Enabled =
					mniTripsServiceClearReadyForWMS.Enabled =
						true; // �������

					mniTripsServiceCreateAct.Enabled = true;

					mniTripsServiceCreatePass.Enabled = !oTripCur.CarID.HasValue;

					mniTripsServiceLogistic.Enabled =
					mniTripsServiceByOrder.Enabled =
						true;

					mniTripsServiceUnConfirm.Enabled = 	oTripCur.IsConfirmed;

					mniTripsServiceZeroConfirm.Enabled = !oTripCur.IsConfirmed;

					mniTripsServiceOutputCarryUnDo.Enabled = !oTripCur.IsConfirmed;
					mniTripsServiceOutputCarryCopyUnDo.Enabled =
					mniTripsServiceOutputDocumentCarryCopyUnDo.Enabled =
						true;

					mniTripsServiceOutputsDocumentsFactTime.Enabled = true;
				}
				tcTripsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null)
					return;

				rowIndex = grdOthers.CurrentRow.Index;

				btnPrint.Enabled =
				btnService.Enabled =
					true;
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;

				if (grdOthers.IsStatusRow(rowIndex))
				{
					oOtherCur.ClearOne();
					btnEdit.Enabled =
					btnDelete.Enabled =
					btnBring.Enabled =
					btnTripReturnAutoCreate.Enabled =
					btnConfirmOther.Enabled =
						false;
				}
				else
				{
					// ���������� ������� �� ������� ������ 
					DataRow r = ((DataRowView)((DataGridViewRow)grdOthers.Rows[rowIndex]).DataBoundItem).Row;
					oOtherCur.FillOne(r);
					btnEdit.Enabled = !oOtherCur.IsConfirmed;
							/*
							!oOtherCur.DateEnd.HasValue &&
							(oOtherCur.ReadyForTripEnd == null || !oOtherCur.ReadyForTripEnd); 
							*/ 
					btnDelete.Enabled = !oOtherCur.IsConfirmed &&
							!oOtherCur.DateBeg.HasValue && !oOtherCur.DateEnd.HasValue &&
							(!oOtherCur.ReadyForTripBeg.HasValue || (bool)!oOtherCur.ReadyForTripBeg) &&
							(!oOtherCur.ReadyForTripEnd.HasValue || (bool)!oOtherCur.ReadyForTripEnd);
					btnBring.Enabled = !oOtherCur.IsConfirmed; // ???
					btnTripReturnAutoCreate.Enabled = !oOtherCur.IsConfirmed;
					btnConfirmOther.Enabled = !oOtherCur.IsConfirmed && (oOtherCur.ReadyForTripEnd.HasValue && (bool)oOtherCur.ReadyForTripEnd);

					mniTripsPrintDocuments.Enabled =
					mniTripsPrintDocumentsAll.Enabled =
					mniTripsPrintDocumentsOne.Enabled =
						true;
					mniTripsPrintDocuments_OneOutputDocument.Enabled =
					mniTripsPrintDocuments_OneInput.Enabled =
						false;

					mniTripsPrintBill.Enabled =
					mniTripsPrintBillShort.Enabled =
						false; 

					mniTripsPrintQualities.Enabled =
					mniTripsPrintVeterinaryBlankData.Enabled =
					mniTripsPrintTTNData.Enabled = 
					mniTripsPrintOutputTTNData.Enabled = 
					mniTripsPrintGoodsGroupsList.Enabled = 
					mniTripsPrintInputsBill.Enabled =
						true;

					mniTripsPrintReportTripsList.Enabled =
					mniTripsPrintReportTripsListNotes.Enabled = 
					mniTripsPrintReportTripBalance.Enabled =
					mniTripsPrintReportTripsPutsBalances.Enabled = 
						true;

					mniTripsServiceSetDateTime.Enabled =
					mniTripsServiceSetDateTimeBeg.Enabled =
					mniTripsServiceSetDateTimeEnd.Enabled =
					mniTripsServiceClearDateTime.Enabled =
					mniTripsServiceClearDateTimeBeg.Enabled =
					mniTripsServiceClearDateTimeEnd.Enabled =
						true; // �������

					mniTripsServiceSetReadyForWMS.Enabled =
					mniTripsServiceClearReadyForWMS.Enabled =
						true; // �������

					mniTripsServiceCreateAct.Enabled = true;

					mniTripsServiceCreatePass.Enabled = true;

					mniTripsServiceLogistic.Enabled =
					mniTripsServiceByOrder.Enabled =
						true;

					mniTripsServiceUnConfirm.Enabled = oOtherCur.IsConfirmed;

					mniTripsServiceZeroConfirm.Enabled = !oOtherCur.IsConfirmed;

					mniTripsServiceOutputCarryUnDo.Enabled = !oOtherCur.IsConfirmed;
					mniTripsServiceOutputCarryCopyUnDo.Enabled =
					mniTripsServiceOutputDocumentCarryCopyUnDo.Enabled =
						true;

					mniTripsServiceOutputsDocumentsFactTime.Enabled = false;
				}
				tcOthersGoods.SetAllNeedRestore(true);
			}
		}

		private void grdTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null || grd.Rows.Count == 0)
				return;

			string sColumnName = grd.Columns[e.ColumnIndex].Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			if (sColumnName.Contains("ReadyForTripBegImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["ReadyForTripBeg"]))
				{
					if ((bool)r["ReadyForTripBeg"])
					{
						e.Value = Properties.Resources.DotGreen;
					}
					else
					{
						e.Value = Properties.Resources.DotRed;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("ReadyForTripEndImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["ReadyForTripEnd"]))
				{
					if ((bool)r["ReadyForTripEnd"])
					{
						e.Value = Properties.Resources.DotGreen;
					}
					else
					{
						e.Value = Properties.Resources.DotRed;
					}
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

            if (sColumnName.Contains("ReadyForCostImage".ToUpper()))
            {
                if (!Convert.IsDBNull(r["ReadyForCost"]))
                {
                    if ((bool)r["ReadyForCost"])
                    {
                        e.Value = Properties.Resources.Edit_coin;
                    }
                    else
                    {
                        e.Value = Properties.Resources.Edit_coin_gray;
                    }
                }
                else
                {
                    e.Value = Properties.Resources.Empty;
                }
            }

            if (sColumnName.Contains("TripReadyImage".ToUpper()))
			{
				if (Convert.IsDBNull(r["ReadyForTripBeg"]))
				{
					e.Value = Properties.Resources.Empty;
				}
				else
				{
					if ((bool)r["ReadyForTripBeg"])
					{
						e.Value = Properties.Resources.Plain_G;
					}
					else
					{
						if ((bool)r["ReadyForPrint"])
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

			if (sColumnName.Contains("TripStatusImage".ToUpper()))
			{
				if (!Convert.IsDBNull(r["TripStatus"]))
				{
					// 0 �� �����, 1 � ����, 2 ������
					switch ((int)r["TripStatus"])
					{
						case 0:
							e.Value = Properties.Resources.DotRed; 
							break;
						case 1:
							e.Value = Properties.Resources.DotYellow;
							break;
						case 2:
							e.Value = Properties.Resources.DotGreen;
							break;
						default:
							e.Value = Properties.Resources.Empty;
							break;
					}
				}
			}

			if (sColumnName.Contains("IsPrintedImage".ToUpper())) 
			{
				if ((bool)r["IsPrinted"])
				{
					e.Value = Properties.Resources.Print;
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			if (sColumnName.Contains("_IsConfirmedImage".ToUpper()))
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

			if ((sColumnName.Contains("TTO") ||
				sColumnName.Contains("POINTS") || 
				sColumnName.Contains("PALLETS") ||
				sColumnName.Contains("DISTANCE") ||
				sColumnName.Contains("QNT")) &&
				grd.Columns[e.ColumnIndex].DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void grdPutsDocuments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// ������������ ��� OutputsDocuments � InputsDocuments

			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null || grd.Rows.Count == 0)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			// ������������� �������� � �������� �������
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

			// ������ ����������
			if (sColumnName.Contains("IsPrintedImage".ToUpper()))
			{
				if ((bool)r["IsPrinted"])
				{
					e.Value = Properties.Resources.Print;
				}
				else
				{
					e.Value = Properties.Resources.Empty;
				}
			}

			// �����-������
			if ((sColumnName.Contains("TTO") || sColumnName.Contains("QNT")) && 
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			// �������
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
			// �����������
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}

			// �������� � ������� �����
			if (chkShowCarried.Checked)
			{
				if (sGridName.Contains("TRIPS"))
				{
					if (Convert.IsDBNull(r["TripID"]) || 
						oTripCur.ID.HasValue && Convert.ToInt32(r["TripID"]) != (int)oTripCur.ID)
					{
						e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
						e.CellStyle.BackColor = Color.LightPink;
					}
				}

				if (sGridName.Contains("OTHERS"))
				{
					if (Convert.IsDBNull(r["TripID"]) ||
						oOtherCur.ID.HasValue && Convert.ToInt32(r["TripID"]) != (int)oOtherCur.ID)
					{
						e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
						e.CellStyle.BackColor = Color.LightPink;
					}
				}
			}
		}

		private void grdPuts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// ������������ ��� Puts, Inputs � Outputs 

			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			// ������������� �������� / ������ �� ������
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

			// ��� �������
			if (sColumnName.Contains("TypeImage".ToUpper()))
			{
				switch (r["Type"].ToString())
				{
					case "I":
						e.Value = Properties.Resources.Plus;
						break;
					case "O":
						e.Value = Properties.Resources.Minus;
						break;
					case "A":
						e.Value = Properties.Resources.Exclamation;
						break;
					case "R":
						e.Value = Properties.Resources.UnDo;
						break;
                    case "$":
                        e.Value = Properties.Resources.Car_Red;
                        break;
                    default:
						e.Value = Properties.Resources.Empty;
						break;
				}
			}

			// �������� � WMS
			if (sColumnName.Contains("ReadyForWMSImage".ToUpper()))
			{
				if ((bool)r["IsConfirmed"])
				{
					e.Value = Properties.Resources.Plain_GD;
				}
				else
				{
                    if (r["Type"].ToString() == "O" && r["DatePick"].ToString().Length > 0)
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

			// �����-������
			if ((sColumnName.Contains("TTO") || sColumnName.Contains("QNT")) &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			// �������
			if (sGridName.Contains("Outputs".ToUpper()))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromOutputID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if (sGridName.Contains("Inputs".ToUpper()))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromInputID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}
			if (sGridName.Contains("_PUTS"))
			{
				if ((bool)r["IsCarried"] || !Convert.IsDBNull(r["CopiedFromPutID"]))
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
				}
			}

			// �����������
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}

			// �������� � ������� �����
			if (chkShowCarried.Checked)
			{
				if (sGridName.Contains("TRIPS"))
				{
					if (Convert.IsDBNull(r["TripID"]) ||
						oTripCur.ID.HasValue && Convert.ToInt32(r["TripID"]) != (int)oTripCur.ID)
					{
						e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
						e.CellStyle.BackColor = Color.LightPink;
					}
				}

				if (sGridName.Contains("OTHERS"))
				{
					if (Convert.IsDBNull(r["TripID"]) ||
						oOtherCur.ID.HasValue && Convert.ToInt32(r["TripID"]) != (int)oOtherCur.ID)
					{
						e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
						e.CellStyle.BackColor = Color.LightPink;
					}
				}
			}
		}

		private void grdTrips_Acts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			// ������������� �������� / ������ �� ������
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

			// �������� � WMS
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

			// �����-������
			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void grdTrips_TripsReturns_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			if (grd.DataSource == null)
				return;

			string sGridName = grd.Name.ToUpper();
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			// ��������� ������
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// ������ ������
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			// ������������� �������� / ������ �� ������
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

			// �������� � WMS
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

			// �����-������
			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		#region Trips BottomGrids CurrentRowChanged - ��� ��������

		private void grdTrips_Outputs_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;

			if (grdTrips_Outputs.IsLockRowChanged)
				return;
			if (grdTrips_Outputs.CurrentRow == null)
				return;
			if (grdTrips_Outputs.IsStatusRow(grdTrips_Outputs.CurrentRow.Index))
				return;
 
			if (oTripCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ro = ((DataRowView)((DataGridViewRow)grdTrips_Outputs.Rows[grdTrips_Outputs.CurrentRow.Index]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ro["IsCarried"];
			bool bIsCopied = (bool)ro["IsCopied"];
			btnOutputCarry.Enabled = 
			btnOutputCopy.Enabled = 
				!bIsCopied;
		}

		private void grdTrips_OutputsDocuments_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;

			if (grdTrips_OutputsDocuments.IsLockRowChanged)
				return;
			if (grdTrips_OutputsDocuments.CurrentRow == null)
				return;
			if (grdTrips_OutputsDocuments.IsStatusRow(grdTrips_OutputsDocuments.CurrentRow.Index))
				return;

            mniTripsPrintDocuments_OneOutputDocument.Enabled = true;
            if (oTripCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ro = ((DataRowView)((DataGridViewRow)grdTrips_OutputsDocuments.Rows[grdTrips_OutputsDocuments.CurrentRow.Index]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ro["IsCarried"];
			bool bIsCopied = (bool)ro["IsCopied"];
			btnOutputCopy.Enabled = !bIsCopied;

			//mniTripsPrintDocuments_OneOutputDocument.Enabled = true;
		}

		private void grdTrips_Inputs_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;

			if (grdTrips_Inputs.IsLockRowChanged)
				return;
			if (grdTrips_Inputs.CurrentRow == null)
				return;
			if (grdTrips_Inputs.IsStatusRow(grdTrips_Inputs.CurrentRow.Index))
				return;

            mniTripsPrintDocuments_OneInput.Enabled = true;
            if (oTripCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ri = ((DataRowView)((DataGridViewRow)grdTrips_Inputs.Rows[grdTrips_Inputs.CurrentRow.Index]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ri["IsCarried"];
			bool bIsCopied = (bool)ri["IsCopied"];
			btnOutputCarry.Enabled = !bIsCopied;

			//mniTripsPrintDocuments_OneInput.Enabled = true;
		}

		private void grdTrips_InputsDocuments_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;

			// ������ �� �������� �� �����������
			/*
			if (grdInputsDocuments.IsLockRowChanged)
				return;
			if (grdInputsDocuments.CurrentRow == null)
				return;
			if (grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index))
				return;

			if (oTripCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ro = ((DataRowView)((DataGridViewRow)grdInputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ro["IsCarried"];
			bool bIsCopied = (bool)ro["IsCopied"];
			btnOutputCopy.Enabled = !bIsCopied;
			*/
		}

		private void grdTrips_Acts_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;
		}

		private void grdTrips_TripsReturns_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;
		}

		#endregion Trips BottomGrids CurrentRowChanged - ��� ��������

		#region Others BottomGrids CurrentRowChanged - ��� �������� // ???

		private void grdOthers_Outputs_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = 
			mniTripsPrintDocuments_OneInput.Enabled = 
				false;

			if (grdOthers_Outputs.IsLockRowChanged)
				return;
			if (grdOthers_Outputs.CurrentRow == null)
				return;
			if (grdOthers_Outputs.IsStatusRow(grdOthers_Outputs.CurrentRow.Index))
				return;

			if (oOtherCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ro = ((DataRowView)((DataGridViewRow)grdOthers_Outputs.Rows[grdOthers_Outputs.CurrentRow.Index]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ro["IsCarried"];
			bool bIsCopied = (bool)ro["IsCopied"];
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled = 
				!bIsCopied;
		}

		private void grdOthers_OutputsDocuments_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;

			if (grdOthers_OutputsDocuments.IsLockRowChanged)
				return;
			if (grdOthers_OutputsDocuments.CurrentRow == null)
				return;
			if (grdOthers_OutputsDocuments.IsStatusRow(grdOthers_OutputsDocuments.CurrentRow.Index))
				return;

			if (oOtherCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ro = ((DataRowView)((DataGridViewRow)grdOthers_OutputsDocuments.Rows[grdOthers_OutputsDocuments.CurrentRow.Index]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ro["IsCarried"];
			bool bIsCopied = (bool)ro["IsCopied"];
			btnOutputCopy.Enabled = !bIsCopied;

			mniTripsPrintDocuments_OneOutputDocument.Enabled = true;
		}

		private void grdOthers_Inputs_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;

			if (grdOthers_Inputs.IsLockRowChanged)
				return;
			if (grdOthers_Inputs.CurrentRow == null)
				return;
			if (grdOthers_Inputs.IsStatusRow(grdOthers_Inputs.CurrentRow.Index))
				return;

			if (oOtherCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ri = ((DataRowView)((DataGridViewRow)grdOthers_Inputs.Rows[grdOthers_Inputs.CurrentRow.Index]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ri["IsCarried"];
			bool bIsCopied = (bool)ri["IsCopied"];
			btnOutputCarry.Enabled = !bIsCopied;

			mniTripsPrintDocuments_OneInput.Enabled = true;
		}

		private void grdOthers_InputsDocuments_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;

			// ������ �� �������� �� �����������
			/*
			if (grdInputsDocuments.IsLockRowChanged)
				return;
			if (grdInputsDocuments.CurrentRow == null)
				return;
			if (grdInputsDocuments.IsStatusRow(grdInputsDocuments.CurrentRow.Index))
				return;

			if (oOtherCur.IsConfirmed)
				return;

			// ���������� ������� �� ������� ������ 
			DataRow ro = ((DataRowView)((DataGridViewRow)grdInputsDocuments.Rows[rowIndex]).DataBoundItem).Row;
			//bool bIsCarried = (bool)ro["IsCarried"];
			bool bIsCopied = (bool)ro["IsCopied"];
			btnOutputCopy.Enabled = !bIsCopied;
			*/
		}

		private void grdOthers_Acts_CurrentRowChanged(object sender)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		#endregion Others BottomGrids CurrentRowChanged - ��� ��������

		#region Trips BottomGrids Enter - ��� ��������

		private void grdTrips_Enter(object sender, EventArgs e)
		{
			//grdTrips_CurrentRowChanged(null);
			btnOutputCopy.Enabled =
			btnOutputCarry.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		private void grdTrips_Puts_Enter(object sender, EventArgs e)
		{
			btnOutputCopy.Enabled =
			btnOutputCarry.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		private void grdTrips_Outputs_Enter(object sender, EventArgs e)
		{
			grdTrips_Outputs_CurrentRowChanged(null);
		}

		private void grdTrips_OutputsDocuments_Enter(object sender, EventArgs e)
		{
			grdTrips_OutputsDocuments_CurrentRowChanged(null);
		}

		private void grdTrips_Inputs_Enter(object sender, EventArgs e)
		{
			grdTrips_Inputs_CurrentRowChanged(null);
		}

		private void grdTrips_InputsDocuments_Enter(object sender, EventArgs e)
		{
			grdTrips_InputsDocuments_CurrentRowChanged(null);
		}

		private void grdTrips_Acts_Enter(object sender, EventArgs e)
		{
			grdTrips_Acts_CurrentRowChanged(null);
		}

		private void grdTrips_TripsReturns_Enter(object sender, EventArgs e)
		{
			grdTrips_TripsReturns_CurrentRowChanged(null);
		}

		private void tcTripsGoods_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;
			/*
			if (tcTripsGoods.SelectedTab.Name == "tabTrips_Puts")
			{
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;
			}

			if (tcTripsGoods.SelectedTab.Name == "tabTrips_InputsDocuments")
			{
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;
			}
			*/

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		#endregion Trips BottomGrids Enter - ��� ��������

		#region Others BottomGrids Enter - ��� ��������

		private void grdOthers_Enter(object sender, EventArgs e)
		{
			//grdOthers_CurrentRowChanged(null);
			btnOutputCopy.Enabled =
			btnOutputCarry.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		private void grdOthers_Puts_Enter(object sender, EventArgs e)
		{
			btnOutputCopy.Enabled =
			btnOutputCarry.Enabled =
				false;

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		private void grdOthers_Outputs_Enter(object sender, EventArgs e)
		{
			grdOthers_Outputs_CurrentRowChanged(null);
		}

		private void grdOthers_OutputsDocuments_Enter(object sender, EventArgs e)
		{
			grdOthers_OutputsDocuments_CurrentRowChanged(null);
		}

		private void grdOthers_Inputs_Enter(object sender, EventArgs e)
		{
			grdOthers_Inputs_CurrentRowChanged(null);
		}

		private void grdOthers_InputsDocuments_Enter(object sender, EventArgs e)
		{
			grdOthers_InputsDocuments_CurrentRowChanged(null);
		}

		private void grdOthers_Acts_Enter(object sender, EventArgs e)
		{
			grdOthers_Acts_CurrentRowChanged(null);
		}

		private void tcOthersGoods_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnOutputCarry.Enabled =
			btnOutputCopy.Enabled =
				false;
			/*
			if (tcOthersGoods.SelectedTab.Name == "tabOthers_Puts")
			{
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;
			}

			if (tcOthersGoods.SelectedTab.Name == "tabOthers_InputsDocuments")
			{
				btnOutputCarry.Enabled =
				btnOutputCopy.Enabled =
					false;
			}
			*/

			mniTripsPrintDocuments_OneOutputDocument.Enabled =
			mniTripsPrintDocuments_OneInput.Enabled =
				false;
		}

		#endregion Others BottomGrids Enter - ��� ��������

	#endregion

	#region Restore

		#region Trips Restore
	
		private bool grdTrips_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oTripCur.ClearOne();

			oTripList.ClearError();
			oTripList.ClearFilters();
			oTripList.ID = null;
			oTripList.IDList = null;

			// �������� �������

			// ����
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oTripList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oTripList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			if (txtAliasContext.Text.Trim().Length > 0)
			{
				oTripList.FilterAliasContext = txtAliasContext.Text.Trim();
			}

			// ������ ���.
			oTripList.FilterSelfDelivery = false;
			if (optCarDefined.Checked)
			{
				oTripList.FilterIsRentCar = false;
			}
			if (optCarOtherDefined.Checked)
			{
				oTripList.FilterIsRentCar = true;
			}

			// ������, ����, ��������
			if (ucSelectRecordID_CarsTypes.IsSelectedExist)
			{
                oTripList.FilterCarsTypesList = ucSelectRecordID_CarsTypes.GetIdString();
			}

            if (optPostern.Checked || optPosternNot.Checked)
            {
                string sCarsList = "";
                Car oCarFilter = new Car();
                if (optPostern.Checked)
                {
                    oCarFilter.FilterIsPostern = true;
                }
                if (optPosternNot.Checked)
                {
                    oCarFilter.FilterIsPostern = false;
                }
                if (ucSelectRecordID_Cars.IsSelectedExist)
                {
                    oCarFilter.IDList = ucSelectRecordID_Cars.GetIdString();
                }
                oCarFilter.FillData();
                if (oCarFilter.ErrorNumber == 0 && oCarFilter.MainTable != null)
                {
                    foreach (DataRow c in oCarFilter.MainTable.Rows)
                    {
                        sCarsList += c["ID"].ToString() + ",";
                    }
                }
                oTripList.FilterCarsList = sCarsList; 
            }
            else
            {
                if (ucSelectRecordID_Cars.IsSelectedExist)
                {
                    oTripList.FilterCarsList = ucSelectRecordID_Cars.GetIdString();
                }
            }
			if (ucSelectRecordID_Drivers.IsSelectedExist)
			{
                oTripList.FilterDriversEmployeesList = ucSelectRecordID_Drivers.GetIdString();
			}
			
			// ������ �� ����� ���������� ������
			if (optTripsStatusesNotOut.Checked)
			{
				oTripList.FilterTripStatus = 0;
			}
			if (optTripsStatusesOutNotIn.Checked)
			{
				oTripList.FilterTripStatus = 1;
			}
			if (optTripsStatusesOutIn.Checked)
			{
				oTripList.FilterTripStatus = 2;
			}

			// ������
			if (optOutputsDocumentsAttached.Checked)
			{
				oTripList.FilterIsOutputsDocumentsAttached = true;
				if (optOutputsDocumentsBrought.Checked)
					oTripList.FilterIsOutputsDocumentsBrought = true;
				if (optOutputsDocumentsBroughtNot.Checked)
					oTripList.FilterIsOutputsDocumentsBrought = false;
			}
			if (optOutputsDocumentsAttachedNot.Checked)
			{
				oTripList.FilterIsOutputsDocumentsAttached = false;
			}
			if (optInputsDocumentsAttached.Checked)
			{
				oTripList.FilterIsInputsDocumentsAttached = true;
			}
			if (optInputsDocumentsAttachedNot.Checked)
			{
				oTripList.FilterIsInputsDocumentsAttached = false;
			}

			// ������� �� ������/������?
			if (optInputsAttached.Checked)
			{
				oTripList.FilterIsInputsAttached = true;
				if (optInputsConfirmed.Checked)
					oTripList.FilterIsInputsConfirmed = true;
				if (optInputsConfirmedNot.Checked)
					oTripList.FilterIsInputsConfirmed = false;
			}
			if (optInputsAttachedNot.Checked)
			{
				oTripList.FilterIsInputsAttached = false;
			}
			if (optOutputsAttached.Checked)
			{
				oTripList.FilterIsOutputsAttached = true;
				if (optOutputsConfirmed.Checked)
					oTripList.FilterIsOutputsConfirmed = true;
				if (optOutputsConfirmedNot.Checked)
					oTripList.FilterIsOutputsConfirmed = false;
			}
			if (optOutputsAttachedNot.Checked)
			{
				oTripList.FilterIsOutputsAttached = false;
			}

			// �������
			if (txtPartnerNameContext.Text.Trim().Length > 0 ||
                ucSelectRecordID_Partners.IsSelectedExist)
			{
				string sPartnersIDList = "";
				string sTripsAddIDList = "";
				// ������� 
				Partner oPartner = new Partner();
                if (ucSelectRecordID_Partners.IsSelectedExist)
				{
                    oPartner.IDList = ucSelectRecordID_Partners.GetIdString();
                    oPartner.FillData();
					foreach (DataRow rc in oPartner.MainTable.Rows)
						sPartnersIDList += rc["ID"].ToString() + ",";
					oPartner.ClearFilters();
					oPartner.ClearData();
				}
				// ��������
				if (txtPartnerNameContext.Text.Trim().Length > 0)
				{
					oPartner.FilterNameContext = txtPartnerNameContext.Text.Trim();
					oPartner.FillData();
					foreach (DataRow rc in oPartner.MainTable.Rows)
						sPartnersIDList += rc["ID"].ToString() + ",";
					oPartner.ClearFilters();
					oPartner.ClearData();
				}
				if (sPartnersIDList.Length > 0)
				{
					OutputDocument oOutputDocument = new OutputDocument();
					oOutputDocument.FilterTripExists = true;
					if (!dtrDates.dtpBegDate.IsEmpty)
						oOutputDocument.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
					if (!dtrDates.dtpEndDate.IsEmpty)
						oOutputDocument.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
					oOutputDocument.FilterPartnersTargetList = sPartnersIDList;
					oOutputDocument.FillData();
					if (oOutputDocument.MainTable.Rows.Count > 0)
					{
						foreach (DataRow ro in oOutputDocument.MainTable.Rows)
						{
							oTripList.FilterOutputsDocumentsList += ro["ID"].ToString() + ",";
						
							// � ��� ������������ ����
							if (chkCarriedInclude.Checked)
							{
								oOutputDocument.FillTableOutputsDocumentsCarries((int)ro["ID"]);
								if (oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsCarries") &&
									oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"] != null &&
									oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"].Rows.Count > 0)
								{
									foreach (DataRow rodAdd in oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"].Rows)
									{
										if (!Convert.IsDBNull(rodAdd["TripID"]))
											sTripsAddIDList += rodAdd["TripID"].ToString() + ",";
									}
								}
							}
						}
					}

					InputDocument oInputDocument = new InputDocument();
					oInputDocument.FilterTripExists = true;
					oInputDocument.FilterPartnersSourceList = sPartnersIDList;
					oInputDocument.FillData();
					if (oInputDocument.MainTable.Rows.Count > 0)
					{
						foreach (DataRow rs in oInputDocument.MainTable.Rows)
						{
							oTripList.FilterInputsDocumentsList += rs["ID"].ToString() + ",";

							// � ��� ������������ ����
							if (chkCarriedInclude.Checked)
							{
								oInputDocument.FillTableInputsDocumentsCarries((int)rs["ID"]);
								if (oInputDocument.DS.Tables.Contains("TableInputsDocumentsCarries") &&
									oInputDocument.DS.Tables["TableInputsDocumentsCarries"] != null &&
									oInputDocument.DS.Tables["TableInputsDocumentsCarries"].Rows.Count > 0)
								{
									foreach (DataRow ridAdd in oInputDocument.DS.Tables["TableInputsDocumentsCarries"].Rows)
									{
										if (!Convert.IsDBNull(ridAdd["TripID"]))
											sTripsAddIDList += ridAdd["TripID"].ToString() + ",";
									}
								}
							}
						}
					}
				}

				if (sTripsAddIDList.Length > 0)
				{
					oTripList.IDList += sTripsAddIDList;
				}
				//oTripList.IDList += sTripsAddIDList;
			}

			// ����� � ����.����������
			if (txtOutputsDocumentsDepartmentNameContext.Text.Trim().Length > 0)
			{
				OutputDocument oOutputDocument = new OutputDocument();
				oOutputDocument.FilterTripExists = true;
				if (!dtrDates.dtpBegDate.IsEmpty)
					oOutputDocument.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
				if (!dtrDates.dtpEndDate.IsEmpty)
					oOutputDocument.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
				oOutputDocument.FilterDepartmentNameContext = txtOutputsDocumentsDepartmentNameContext.Text.Trim().ToUpper();
				oOutputDocument.FillData();
				if (oOutputDocument.MainTable.Rows.Count > 0)
				{
					foreach (DataRow ro in oOutputDocument.MainTable.Rows)
					{
						oTripList.FilterOutputsDocumentsList += ro["ID"].ToString() + ",";
					}
				}
			}

			// ������
			if (optReadyForPrint.Checked)
			{
				oTripList.FilterReadyForPrint = true;
			}
			if (optReadyForPrintNot.Checked)
			{
				oTripList.FilterReadyForPrint = false;
			}

			if (optIsPrinted.Checked)
			{
				oTripList.FilterIsPrinted = true;
			}
			if (optIsPrintedNot.Checked)
			{
				oTripList.FilterIsPrinted = false;
			}

			// ����� � �����������?
			if (optReadyForTripBeg.Checked)
			{
				oTripList.FilterReadyForTripBeg = true;
			}
			if (optReadyForTripBegNot.Checked)
			{
				oTripList.FilterReadyForTripBeg = false;
			}

			// �������������
			if (optIsConfirmed.Checked)
			{
				oTripList.FilterIsConfirmed = true;
			}
			if (optIsConfirmedNot.Checked)
			{
				oTripList.FilterIsConfirmed = false;
			}

			// ATT TripStatuses !!!

			// �� ���� �����
			if (numTripID.Value > 0)
			{
				oTripList.IDList += Convert.ToInt32(numTripID.Value).ToString();
			}

			// Hosts
			if (nUserHostID.HasValue)
			{
				oTripList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oTripList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdTrips_Puts.DataSource = null;
			grdTrips_Outputs.DataSource = null;
			grdTrips_OutputsDocuments.DataSource = null;
			grdTrips_Inputs.DataSource = null;
			grdTrips_InputsDocuments.DataSource = null;
			grdTrips_Acts.DataSource = null;
			grdTrips_TripsReturns.DataSource = null;
			grdTrips_Partners.DataSource = null; 

			grdTrips.GetGridState();

			oTripList.FillData();
			grdTrips.IsLockRowChanged = true;
			grdTrips.Restore(oTripList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oTripList.ErrorNumber == 0);
		}

		private bool grdTrips_Puts_Restore()
		{
			grdTrips_Puts.GetGridState();
			grdTrips_Puts.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oTripCur.FillTablePutsInTripAll((int)oTripCur.ID, chkShowCarried.Checked);
			DataTable dt = oTripCur.TablePutsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oTripCur.TablePutsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "TypeByOrder, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oTripCur.TablePutsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "TypeByOrder, ID");
			}
			grdTrips_Puts.Restore(dt);

			return (oTripCur.ErrorNumber == 0);
		}

		private bool grdTrips_Outputs_Restore()
		{
			grdTrips_Outputs.GetGridState();
			grdTrips_Outputs.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oTripCur.FillTableOutputsInTrip(chkShowCarried.Checked);
			DataTable dt = oTripCur.TableOutputsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oTripCur.TableOutputsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateOutput, PartnerName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oTripCur.TableOutputsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateOutput, PartnerName, ID");
			}
			grdTrips_Outputs.Restore(dt);

			return (oTripCur.ErrorNumber == 0);
		}

		private bool grdTrips_OutputsDocuments_Restore()
		{
			grdTrips_OutputsDocuments.GetGridState();
			grdTrips_OutputsDocuments.DataSource = null;
			if (grdTrips.Rows.Count == 0 || 
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oTripCur.FillTableOutputsDocumentsInTrip(chkShowCarried.Checked);
			DataTable dt = oTripCur.TableOutputsDocumentsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oTripCur.TableOutputsDocumentsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateOutput, PartnerSourceName, PartnerTargetName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oTripCur.TableOutputsDocumentsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateOutput, PartnerSourceName, PartnerTargetName, ID");
			}
			grdTrips_OutputsDocuments.Restore(dt);

			return (oTripCur.ErrorNumber == 0);
		}

		private bool grdTrips_Inputs_Restore()
		{
			grdTrips_Inputs.GetGridState();
			grdTrips_Inputs.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oTripCur.FillTableInputsInTrip(chkShowCarried.Checked);
			DataTable dt = oTripCur.TableInputsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oTripCur.TableInputsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateInput, PartnerName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oTripCur.TableInputsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateInput, PartnerName, ID");
			}
			grdTrips_Inputs.Restore(dt);

			return (oTripCur.ErrorNumber == 0);
		}

		private bool grdTrips_InputsDocuments_Restore()
		{
			grdTrips_InputsDocuments.GetGridState();
			grdTrips_InputsDocuments.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oTripCur.FillTableInputsDocumentsInTrip(chkShowCarried.Checked);
			DataTable dt = oTripCur.TableInputsDocumentsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oTripCur.TableInputsDocumentsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateInput, PartnerSourceName, PartnerTargetName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oTripCur.TableInputsDocumentsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateInput, PartnerSourceName, PartnerTargetName, ID");
			}
			grdTrips_InputsDocuments.Restore(dt);

			return (oTripCur.ErrorNumber == 0);
		}

		private bool grdTrips_Acts_Restore()
		{
			grdTrips_Acts.GetGridState();
			grdTrips_Acts.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oActInTrip.FilterTripsList = oTripCur.ID.ToString();
			if (nUserHostID.HasValue)
				oActInTrip.FilterHostsList = nUserHostID.ToString();
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oActInTrip.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}
			oActInTrip.FillData();
			grdTrips_Acts.Restore(oActInTrip.MainTable);

			return (oActInTrip.ErrorNumber == 0);
		}

		private bool grdTrips_TripsReturns_Restore()
		{
			grdTrips_TripsReturns.GetGridState();
			grdTrips_TripsReturns.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

			oTripReturn.FilterTripsList = oTripCur.ID.ToString();
			if (nUserHostID.HasValue)
				oTripReturn.FilterHostsList = nUserHostID.ToString();
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oTripReturn.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}
			oTripReturn.FillData();
			grdTrips_TripsReturns.Restore(oTripReturn.MainTable);

			return (oTripReturn.ErrorNumber == 0);
		}

		private bool grdTrips_Partners_Restore()
		{
			oPartner.ClearFilters();
 
			grdTrips_Partners.GetGridState();
			grdTrips_Partners.DataSource = null;
			if (grdTrips.Rows.Count == 0 ||
				!oTripCur.ID.HasValue ||
				(grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
				return (true);

            string sPartnersList = "";

            // �������� ������ ��������� �� ��������� ����������
            OutputDocument oOutputDocumentForTrip = new OutputDocument();
			oOutputDocumentForTrip.FilterTripsList = oTripCur.ID.ToString();
			oOutputDocumentForTrip.FillData();
			foreach (DataRow r in oOutputDocumentForTrip.MainTable.Rows)
				sPartnersList += r["PartnerTargetID"].ToString().Trim() + ",";

            // �������� ������ ��������� �� ��������� ����������
            InputDocument oInputDocumentForTrip = new InputDocument();
            oInputDocumentForTrip.FilterTripsList = oTripCur.ID.ToString();
            oInputDocumentForTrip.FillData();
            foreach (DataRow r in oInputDocumentForTrip.MainTable.Rows)
                sPartnersList += r["PartnerTargetID"].ToString().Trim() + ",";

            // �������� ������ �������� � ������������
            CarTask oCarTaskForTrip = new CarTask();
            oCarTaskForTrip.FilterTripsList = oTripCur.ID.ToString();
            oCarTaskForTrip.FillData();
            foreach (DataRow r in oCarTaskForTrip.MainTable.Rows)
                sPartnersList += r["PartnerID"].ToString().Trim() + ",";

            oPartner.IDList = sPartnersList;
			if (nUserHostID.HasValue)
				oPartner.FilterHostsList = nUserHostID.ToString();
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oPartner.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}
			oPartner.FillData();
			grdTrips_Partners.Restore(oPartner.MainTable);

			return (oPartner.ErrorNumber == 0);
		}

		#endregion Trips Restore

		#region Others Restore

		private bool grdOthers_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOtherCur.ClearOne();

			oOtherList.ClearError();
			oOtherList.ClearFilters();
			oOtherList.ID = null;
			oOtherList.IDList = null;

			// �������� �������

			// ����
			if (!dtrDates.dtpBegDate.IsEmpty)
			{
				oOtherList.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
			}
			if (!dtrDates.dtpEndDate.IsEmpty)
			{
				oOtherList.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
			}

			if (txtAliasContext.Text.Trim().Length > 0)
			{
				oOtherList.FilterAliasContext = txtAliasContext.Text.Trim();
			}

			// ������ ���.
			oOtherList.FilterSelfDelivery = true;

			// ������ �� ����� ���������� ������
			if (optTripsStatusesNotOut.Checked)
			{
				oOtherList.FilterTripStatus = 0;
			}
			if (optTripsStatusesOutNotIn.Checked)
			{
				oOtherList.FilterTripStatus = 1;
			}
			if (optTripsStatusesOutIn.Checked)
			{
				oOtherList.FilterTripStatus = 2;
			}

			// ������
			if (optOutputsDocumentsAttached.Checked)
			{
				oOtherList.FilterIsOutputsDocumentsAttached = true;
				if (optOutputsDocumentsBrought.Checked)
					oOtherList.FilterIsOutputsDocumentsBrought = true;
				if (optOutputsDocumentsBroughtNot.Checked)
					oOtherList.FilterIsOutputsDocumentsBrought = false;
			}
			if (optOutputsDocumentsAttachedNot.Checked)
			{
				oOtherList.FilterIsOutputsDocumentsAttached = false;
			}
			if (optInputsDocumentsAttached.Checked)
			{
				oOtherList.FilterIsInputsDocumentsAttached = true;
			}
			if (optInputsDocumentsAttachedNot.Checked)
			{
				oOtherList.FilterIsInputsDocumentsAttached = false;
			}

			// ������� �� ������/������?
			if (optInputsAttached.Checked)
			{
				oOtherList.FilterIsInputsAttached = true;
				if (optInputsConfirmed.Checked)
					oOtherList.FilterIsInputsConfirmed = true;
				if (optInputsConfirmedNot.Checked)
					oOtherList.FilterIsInputsConfirmed = false;
			}
			if (optInputsAttachedNot.Checked)
			{
				oOtherList.FilterIsInputsAttached = false;
			}
			if (optOutputsAttached.Checked)
			{
				oOtherList.FilterIsOutputsAttached = true;
				if (optOutputsConfirmed.Checked)
					oOtherList.FilterIsOutputsConfirmed = true;
				if (optOutputsConfirmedNot.Checked)
					oOtherList.FilterIsOutputsConfirmed = false;
			}
			if (optOutputsAttachedNot.Checked)
			{
				oOtherList.FilterIsOutputsAttached = false;
			}

			// �������
			if (txtPartnerNameContext.Text.Trim().Length > 0 ||
                ucSelectRecordID_Partners.IsSelectedExist)
			{
				string sPartnersIDList = "";
				string sTripsAddIDList = "";
				// ������� 
				Partner oPartner = new Partner();
                if (ucSelectRecordID_Partners.IsSelectedExist)
				{
                    oPartner.IDList = ucSelectRecordID_Partners.GetIdString();
					oPartner.FillData();
					foreach (DataRow rc in oPartner.MainTable.Rows)
						sPartnersIDList += rc["ID"].ToString() + ",";
					oPartner.ClearFilters();
					oPartner.ClearData();
				}
				// ��������
				if (txtPartnerNameContext.Text.Trim().Length > 0)
				{
					oPartner.FilterNameContext = txtPartnerNameContext.Text.Trim();
					oPartner.FillData();
					foreach (DataRow rc in oPartner.MainTable.Rows)
						sPartnersIDList += rc["ID"].ToString() + ",";
					oPartner.ClearFilters();
					oPartner.ClearData();
				}
				if (sPartnersIDList.Length > 0)
				{
					OutputDocument oOutputDocument = new OutputDocument();
					oOutputDocument.FilterPartnersTargetList = sPartnersIDList;
					oOutputDocument.FillData();
					if (oOutputDocument.MainTable.Rows.Count > 0)
					{
						foreach (DataRow ro in oOutputDocument.MainTable.Rows)
						{
							oOtherList.FilterOutputsDocumentsList += ro["ID"].ToString() + ",";

							// � ��� ������������ ����
							if (chkCarriedInclude.Checked)
							{
								oOutputDocument.FillTableOutputsDocumentsCarries((int)ro["ID"]);
								if (oOutputDocument.DS.Tables.Contains("TableOutputsDocumentsCarries") &&
									oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"] != null &&
									oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"].Rows.Count > 0)
								{
									foreach (DataRow rodAdd in oOutputDocument.DS.Tables["TableOutputsDocumentsCarries"].Rows)
									{
										if (!Convert.IsDBNull(rodAdd["TripID"]))
											sTripsAddIDList += rodAdd["TripID"].ToString() + ",";
									}
								}
							}

						}
					}

					InputDocument oInputDocument = new InputDocument();
					oInputDocument.FilterPartnersSourceList = sPartnersIDList;
					oInputDocument.FillData();
					if (oInputDocument.MainTable.Rows.Count > 0)
					{
						foreach (DataRow rs in oInputDocument.MainTable.Rows)
						{
							oOtherList.FilterInputsDocumentsList += rs["ID"].ToString() + ",";

							// � ��� ������������ ����
							if (chkCarriedInclude.Checked)
							{
								oInputDocument.FillTableInputsDocumentsCarries((int)rs["ID"]);
								if (oInputDocument.DS.Tables.Contains("TableInputsDocumentsCarries") &&
									oInputDocument.DS.Tables["TableInputsDocumentsCarries"] != null &&
									oInputDocument.DS.Tables["TableInputsDocumentsCarries"].Rows.Count > 0)
								{
									foreach (DataRow ridAdd in oInputDocument.DS.Tables["TableInputsDocumentsCarries"].Rows)
									{
										if (!Convert.IsDBNull(ridAdd["TripID"]))
											sTripsAddIDList += ridAdd["TripID"].ToString() + ",";
									}
								}
							}
						}
					}
				}
				if (sTripsAddIDList.Length > 0)
				{
					oOtherList.IDList += sTripsAddIDList;
				}
			}

			// ����� � ����.����������
			if (txtOutputsDocumentsDepartmentNameContext.Text.Trim().Length > 0)
			{
				OutputDocument oOutputDocument = new OutputDocument();
				oOutputDocument.FilterTripExists = true;
				if (!dtrDates.dtpBegDate.IsEmpty)
					oOutputDocument.FilterDateBeg = dtrDates.dtpBegDate.Value.Date;
				if (!dtrDates.dtpEndDate.IsEmpty)
					oOutputDocument.FilterDateEnd = dtrDates.dtpEndDate.Value.Date;
				oOutputDocument.FilterDepartmentNameContext = txtOutputsDocumentsDepartmentNameContext.Text.Trim().ToUpper();
				oOutputDocument.FillData();
				if (oOutputDocument.MainTable.Rows.Count > 0)
				{
					foreach (DataRow ro in oOutputDocument.MainTable.Rows)
					{
						oOtherList.FilterOutputsDocumentsList += ro["ID"].ToString() + ",";
					}
				}
			}

			// ������
			if (optReadyForPrint.Checked)
			{
				oOtherList.FilterReadyForPrint = true;
			}
			if (optReadyForPrintNot.Checked)
			{
				oOtherList.FilterReadyForPrint = false;
			}

			if (optIsPrinted.Checked)
			{
				oOtherList.FilterIsPrinted = true;
			}
			if (optIsPrintedNot.Checked)
			{
				oOtherList.FilterIsPrinted = false;
			}

			// ����� � �����������?
			if (optReadyForTripBeg.Checked)
			{
				oOtherList.FilterReadyForTripBeg = true;
			}
			if (optReadyForTripBegNot.Checked)
			{
				oOtherList.FilterReadyForTripBeg = false;
			}

			// �������������
			if (optIsConfirmed.Checked)
			{
				oOtherList.FilterIsConfirmed = true;
			}
			if (optIsConfirmedNot.Checked)
			{
				oOtherList.FilterIsConfirmed = false;
			}

			// ATT OtherStatuses !!!

			// �� ���� �����
			if (numTripID.Value > 0)
			{
				oOtherList.IDList = Convert.ToInt32(numTripID.Value).ToString();
			}

			// Hosts
			if (nUserHostID.HasValue)
			{
				oOtherList.FilterHostsList = nUserHostID.ToString();
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
				{
					oOtherList.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
				}
			}
			//

			grdOthers_Puts.DataSource = null;
			grdOthers_Outputs.DataSource = null;
			grdOthers_OutputsDocuments.DataSource = null;
			grdOthers_Inputs.DataSource = null;
			grdOthers_InputsDocuments.DataSource = null;

			grdOthers.GetGridState();

			oOtherList.FillData();
			grdOthers.IsLockRowChanged = true;
			grdOthers.Restore(oOtherList.MainTable);
			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oOtherList.ErrorNumber == 0);
		}

		private bool grdOthers_Puts_Restore()
		{
			grdOthers_Puts.GetGridState();
			grdOthers_Puts.DataSource = null;
			if (grdOthers.Rows.Count == 0 ||
				!oOtherCur.ID.HasValue ||
				(grdOthers.CurrentRow != null && grdOthers.IsStatusRow(grdOthers.CurrentRow.Index)))
				return (true);

			oOtherCur.FillTablePutsInTripAll((int)oOtherCur.ID, chkShowCarried.Checked);
			DataTable dt = oOtherCur.TablePutsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oOtherCur.TablePutsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "TypeByOrder, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oOtherCur.TablePutsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "TypeByOrder, ID");
			}
			grdOthers_Puts.Restore(dt);

			return (oOtherCur.ErrorNumber == 0);
		}

		private bool grdOthers_Outputs_Restore()
		{
			grdOthers_Outputs.GetGridState();
			grdOthers_Outputs.DataSource = null;
			if (grdOthers.Rows.Count == 0 ||
				!oOtherCur.ID.HasValue ||
				(grdOthers.CurrentRow != null && grdOthers.IsStatusRow(grdOthers.CurrentRow.Index)))
				return (true);

			oOtherCur.FillTableOutputsInTrip(chkShowCarried.Checked);
			DataTable dt = oOtherCur.TableOutputsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oOtherCur.TableOutputsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateOutput, PartnerName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oOtherCur.TableOutputsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateOutput, PartnerName, ID");
			}
			grdOthers_Outputs.Restore(dt);

			return (oOtherCur.ErrorNumber == 0);
		}

		private bool grdOthers_OutputsDocuments_Restore()
		{
			grdOthers_OutputsDocuments.GetGridState();
			grdOthers_OutputsDocuments.DataSource = null;
			if (grdOthers.Rows.Count == 0 ||
				!oOtherCur.ID.HasValue ||
				(grdOthers.CurrentRow != null && grdOthers.IsStatusRow(grdOthers.CurrentRow.Index)))
				return (true);

			oOtherCur.FillTableOutputsDocumentsInTrip(chkShowCarried.Checked);
			DataTable dt = oOtherCur.TableOutputsDocumentsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oOtherCur.TableOutputsDocumentsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateOutput, PartnerSourceName, PartnerTargetName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oOtherCur.TableOutputsDocumentsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateOutput, PartnerSourceName, PartnerTargetName, ID");
			}
			grdOthers_OutputsDocuments.Restore(dt);

			return (oOtherCur.ErrorNumber == 0);
		}

		private bool grdOthers_Inputs_Restore()
		{
			grdOthers_Inputs.GetGridState();
			grdOthers_Inputs.DataSource = null;
			if (grdOthers.Rows.Count == 0 ||
				!oOtherCur.ID.HasValue ||
				(grdOthers.CurrentRow != null && grdOthers.IsStatusRow(grdOthers.CurrentRow.Index)))
				return (true);

			oOtherCur.FillTableInputsInTrip(chkShowCarried.Checked);
			DataTable dt = oOtherCur.TableInputsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oOtherCur.TableInputsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateInput, PartnerName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oOtherCur.TableInputsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateInput, PartnerName, ID");
			}
			grdOthers_Inputs.Restore(dt);

			return (oOtherCur.ErrorNumber == 0);
		}

		private bool grdOthers_InputsDocuments_Restore()
		{
			grdOthers_InputsDocuments.GetGridState();
			grdOthers_InputsDocuments.DataSource = null;
			if (grdOthers.Rows.Count == 0 ||
				!oOtherCur.ID.HasValue ||
				(grdOthers.CurrentRow != null && grdOthers.IsStatusRow(grdOthers.CurrentRow.Index)))
				return (true);

			oOtherCur.FillTableInputsDocumentsInTrip(chkShowCarried.Checked);
			DataTable dt = oOtherCur.TableInputsDocumentsInTrip;
			if (nUserHostID.HasValue)
			{
				dt = CopyTable(oOtherCur.TableInputsDocumentsInTrip, "dt", "HostID = " + nUserHostID.ToString(), "DateInput, PartnerSourceName, PartnerTargetName, ID");
			}
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					dt = CopyTable(oOtherCur.TableInputsDocumentsInTrip, "dt", "HostID in (" + RFMUtilities.NormalizeList(ucSelectRecordID_Hosts.GetIdString()) + ")", "DateInput, PartnerSourceName, PartnerTargetName, ID");
			}
			grdOthers_InputsDocuments.Restore(dt);

			return (oOtherCur.ErrorNumber == 0);
		}

		private bool grdOthers_Acts_Restore()
		{
			grdOthers_Acts.GetGridState();
			grdOthers_Acts.DataSource = null;
			if (grdOthers.Rows.Count == 0 ||
				!oOtherCur.ID.HasValue ||
				(grdOthers.CurrentRow != null && grdOthers.IsStatusRow(grdOthers.CurrentRow.Index)))
				return (true);

			oActInOther.FilterTripsList = oOtherCur.ID.ToString();
			oActInOther.FillData();
			if (nUserHostID.HasValue)
				oActInOther.FilterHostsList = nUserHostID.ToString();
			else
			{
				if (ucSelectRecordID_Hosts.IsSelectedExist)
					oActInOther.FilterHostsList = ucSelectRecordID_Hosts.GetIdString();
			}
			grdOthers_Acts.Restore(oActInOther.MainTable);

			return (oActInOther.ErrorNumber == 0);
		}

		#endregion Others Restore

	#endregion

	#region Buttons

		#region Add by date

		private void btnAddByDate_Click(object sender, EventArgs e)
		{
			if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				return; 

			mnuAddByDate.Show(btnAddByDate, new Point());
		}

		private void mnuAddByDate_Trips_Click(object sender, EventArgs e)
		{
			AddTrips();
		}

		private void mnuAddByDate_TripsOthers_Click(object sender, EventArgs e)
		{
			AddTripsOthers();
		}

		private void AddTrips()
		{
			if (StartForm(new frmTripsByDate()) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

		private void AddTripsOthers()
		{
			if (StartForm(new frmTripsOthersByDate()) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

		#endregion Add by date

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			if (sPageName.Contains("TRIPS"))
			{
				if (StartForm(new frmTripsEdit(null)) == DialogResult.Yes)
				{
					if (GotParam.GetValue(0) != null)
						{
						int nTripID = (int)GotParam.GetValue(0);
						grdTrips_Restore();
						if (nTripID > 0)
						{
							grdTrips.GridSource.Position = grdTrips.GridSource.Find(oTripList.ColumnID, nTripID);
						}
					}
				}
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (StartForm(new frmTripsEdit(null, true)) == DialogResult.Yes)
				{
					if (GotParam.GetValue(0) != null)
					{
						int nOtherTripID = (int)GotParam.GetValue(0);
						grdOthers_Restore();
						if (nOtherTripID > 0)
						{
							grdOthers.GridSource.Position = grdOthers.GridSource.Find(oOtherList.ColumnID, nOtherTripID);
						}
					}
				}
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			bool bSelfDelivery = false;
			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
				bSelfDelivery = true;
			}

			Trip oTripEdit = new Trip();
			oTripEdit.ReFillOne((int)nTripID);

			// ��������
			if (oTripEdit.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������...");
				return;
			}

			// 

			Refresh();

			if (StartForm(new frmTripsEdit(nTripID, bSelfDelivery)) == DialogResult.Yes)
			{
				if (sPageName.Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (sPageName.Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		private void btnBring_Click(object sender, EventArgs e)
		{
			// ������ �� ���������� ����� � �������

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripBring = new Trip();
			oTripBring.ReFillOne(nTripID);

			// ��������
			if (!oTripBring.CarID.HasValue &&
				(oTripBring.CarNumber == null || oTripBring.CarNumber.Length == 0))
			{
				RFMMessage.MessageBoxError("������ �� ����������...");
				return;
			}
			if (oTripBring.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������...");
				return;
			}

			if (!oTripBring.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxInfo("��������!\n..." + TRIP_NOT_BEG);
                return;
			}
			/*if (!oTripBring.DateEnd.HasValue)
			{
				RFMMessage.MessageBoxInfo("��������!\n..." + TRIP_NOT_END);
			}*/

			// ��� �� ������� �� ������ ������������?
			if (!oTripBring.IsOutputsConfirmed)
			{
				RFMMessage.MessageBoxError("�� ��� ������� �� ������ ������������...");
				return;
			}
				
			// ��� �� ��������� ��������� ������������? 
			if (oTripBring.FillTableOutputsDocumentsInTrip() && oTripBring.ErrorNumber == 0)
			{
				foreach (DataRow r in oTripBring.TableOutputsDocumentsInTrip.Rows)
				{
					if (!Convert.ToBoolean(r["IsConfirmed"]))
					{
						RFMMessage.MessageBoxError("����� ��������� ����������, ����������� � �����, ���� ���������,\n" + 
							"��� ������� �� ���������������� �������� �� ������...");
						return;
					}
				}
			}
			else
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ��������� ���������� � �����...");
				return;
			}
			//
			 
			Refresh();

			//if (StartForm(new frmTripsBring(nTripID)) == DialogResult.Yes)
			if (StartForm(new frmTripsBringEasy(nTripID)) == DialogResult.Yes)
			{
				if (sPageName.Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (sPageName.Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		private void btnTripRetrunAutoCreate_Click(object sender, EventArgs e)
		{
			// ������������ ������� �� �������. ������ ��� ����� �����!
			if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS") && 
				!tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
				return;

			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				//if (LogService.TripReturn_AutoCreate((int)oTripCur.ID, this))
				if (LogService.Trip_ReturnActCreate((int)oTripCur.ID, this))
				{
					grdTrips_Restore();
				}
			}
			else
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (LogService.Trip_ActCreate((int)oOtherCur.ID, this))
				{
					grdOthers_Restore();
				}
			}
		}

		private void btnConfirm_Click(object sender, EventArgs e)
		{
			// ������������� ������������� �����

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripConfirm = new Trip();
			oTripConfirm.ReFillOne(nTripID);

			// ��������
			if (oTripConfirm.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������...");
				return;
			}
			if ((!oTripConfirm.ReadyForTripBeg.HasValue || !(bool)oTripConfirm.ReadyForTripBeg) || 
				(!oTripConfirm.ReadyForTripEnd.HasValue || !(bool)oTripConfirm.ReadyForTripEnd))
			{
				RFMMessage.MessageBoxError("���� �� ����� � ������/���������...");
				return;
			}
			if (!oTripConfirm.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("���� ��� �� �����...");
				return;
			}
			/*
            if (!oTripConfirm.DateEnd.HasValue)
            {
                RFMMessage.MessageBoxError("���� ��� �� �������...");
                return;
            }
			*/ 
            if (oTripConfirm.CarID.HasValue)
			{
				// ���� ������
				if (!oTripConfirm.DriverEmployeeID.HasValue)
				{
					RFMMessage.MessageBoxError("�������� �� ���������...");
					return;
				}
			}
			else
			{
				// �� ���� ������ 
				if (oTripConfirm.CarNumber == null || oTripConfirm.CarNumber.Length == 0)
				{
					RFMMessage.MessageBoxError("������ �� ����������...");
					return;
				}
				if (oTripConfirm.DriverName == null || oTripConfirm.DriverName.Length == 0)
				{
					RFMMessage.MessageBoxError("�������� �� ���������...");
					return;
				}
				if (oTripConfirm.IsRentCar)
				{
					if (!oTripConfirm.PartnerCarrierID.HasValue)
					{
						RFMMessage.MessageBoxError("�� ���������� �����-���������������...");
						return;
					}
				}
			}

			// ��� ������� ���������������� � ����� "��������� ���������������" ������� ������ ���� ��������� ��������� ���������
			// (����� ������ ��� � ������� "���� ����� � ���������")
			if (oTripConfirm.IsInputsAttached)
			{
				oTripConfirm.FillTableInputsInTrip();
				if (oTripConfirm.ErrorNumber != 0 || oTripConfirm.TableInputsInTrip == null)
					return;
				if (oTripConfirm.TableInputsInTrip.Rows.Count > 0)
				{
					foreach (DataRow i in oTripConfirm.TableInputsInTrip.Rows)
					{
						if ((bool)i["SuccessConfirmed"] && !(bool)i["InputsDocumentsExists"])
						{
							RFMMessage.MessageBoxError("����� �������������� � ����� ������� �� ������ ���� �����, ��� ������� �� ��������� ��������� ���������...");
							return;
						}
					}
				}
			}
			//


            // �������� ������� ��������
            if (!oTripConfirm.SelfDelivery && oTripConfirm.IsOutputsAttached && !oTripConfirm.IsTripReturnAutoAttached)
            {
				/*
                if (RFMMessage.MessageBoxYesNo("� ����� �� �������� ������������� ������������ �������.\r\n" + 
						"�� ����� ����������� ����?") == DialogResult.No) 
					return;
				 */
				// ��������� ���������� ������� 
				// ����� �� �� ���?
				if (oTripConfirm.Report_TripOutputsBalance(nTripID) && oTripConfirm.ErrorNumber == 0 &&
					oTripConfirm.DS.Tables.Contains("TableOutputsBalance"))
				{ 
					if (oTripConfirm.DS.Tables["TableOutputsBalance"].Rows.Count > 0)
					{
						RFMMessage.MessageBoxError("��� ����� �� ��������� �������-�������,\n" + 
							"��� ���� ������ �� �������� �� ��������.\n\n" + 
							"��������� ������ ��������-��������!");
						return;
					}
				}
            }

            // ��� �� ����������� ������������
            if (oTripConfirm.FillTableCarsTasksInTrip() && oTripConfirm.ErrorNumber == 0)
            {
                foreach (DataRow r in oTripConfirm.TableCarsTasksInTrip.Rows)
                {
                    if (!Convert.ToBoolean(r["IsConfirmed"]))
                    {
                        RFMMessage.MessageBoxError("����� �����������, ����������� � �����, ���� ����������������...");
                        return;
                    }
                }
            }

            // ������������� ���� ������� � ���������� ����� �� ��������� - ��� ������� ReadyForTripEnd
			Refresh();

			bool bConfirm = false;

			LogService.TripsPutsBalances_Print(oTripConfirm, this, false);

			bool bOutputsProblem = (oTripConfirm.DS.Tables.Contains("TableOutputsBalance") && oTripConfirm.DS.Tables["TableOutputsBalance"].Rows.Count > 0);
			bool bInputsProblem = (oTripConfirm.DS.Tables.Contains("TableInputsBalance") && oTripConfirm.DS.Tables["TableInputsBalance"].Rows.Count > 0);
			if (bOutputsProblem || bInputsProblem)
			{
				string sText = "��� ����� �� ��������� ������ �� ";
				if (bOutputsProblem && bInputsProblem)
				{
					sText += "�������� � ��������";
				}
				else
				{
					if (bOutputsProblem)
						sText += "��������";
					else
						sText += "��������";
				}
				if (RFMMessage.MessageBoxYesNo(sText + ".\n" +
						"���-���� ����������� ����?", false) == DialogResult.Yes)
				{
					bConfirm = true;
				}
			}
			else
			{
				if (RFMMessage.MessageBoxYesNo("����������� ����?") == DialogResult.Yes)
				{
					bConfirm = true;
				}
			}

			if (bConfirm)
			{
				if (!oTripConfirm.DateEnd.HasValue)
				{
					oTripConfirm.SetDateTime(nTripID, "END", "FACT", DateTime.Now, null);
				}
					
				if (oTripConfirm.Confirm(((RFMFormMain)Application.OpenForms[0]).UserID))
				{
					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripDelete = new Trip();
			oTripDelete.ReFillOne(nTripID);

			// ��������
			if (oTripDelete.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������...");
				return;
			}
			if (oTripDelete.DateEnd.HasValue)
			{
				RFMMessage.MessageBoxError("���� ��� �������...");
				return;
			}
			if (oTripDelete.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("���� ��� �����...");
				return;
			}
			if (oTripDelete.ReadyForTripEnd.HasValue && (bool)oTripDelete.ReadyForTripEnd)
			{
				RFMMessage.MessageBoxError("���� ����� � ���������...");
				return;
			}
			if (oTripDelete.ReadyForTripBeg.HasValue && (bool)oTripDelete.ReadyForTripBeg)
			{
				RFMMessage.MessageBoxError("���� ����� � ������...");
				return;
			}

			// ���� �� ������� / ���������?
			if (oTripDelete.IsOutputsAttached)
			{
				RFMMessage.MessageBoxError("� ����� ��������� ������� �� ������...");
				return;
			}
			if (oTripDelete.IsOutputsDocumentsAttached)
			{
				RFMMessage.MessageBoxError("� ����� ��������� ��������� ���������...");
				return;
			}
			if (oTripDelete.IsInputsAttached)
			{
				RFMMessage.MessageBoxError("� ����� ��������� ������� �� ������...");
				return;
			}
			if (oTripDelete.IsInputsDocumentsAttached)
			{
				RFMMessage.MessageBoxError("� ����� ��������� ��������� ���������...");
				return;
			}
			if (oTripDelete.IsTripsReturnsAttached)
			{
				RFMMessage.MessageBoxError("� ����� ��������� ��������...");
				return;
			}
            if (oTripDelete.FillTableCarsTasksInTrip() && oTripDelete.ErrorNumber == 0 && oTripDelete.TableCarsTasksInTrip.Rows.Count > 0)
            {
                RFMMessage.MessageBoxError("� ����� ��������� �����������...");
                return;
            }

			Pass oPassTemp = new Pass();
			oPassTemp.FilterTripsList = oTripCur.ID.ToString();
			oPassTemp.FillData();
			if (oPassTemp.ErrorNumber != 0 || oPassTemp.MainTable == null)
				return;
			if (oPassTemp.MainTable.Rows.Count > 0)
			{
				RFMMessage.MessageBoxError("��� ����� ��� �������� �������...");
				return;
			}

			// ����� "������ ����" ��� ������� ��������

			if (RFMMessage.MessageBoxYesNo("������� ����?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oTripDelete.DeleteOne(nTripID);
				WaitOff(this);
				if (bResult && oTripDelete.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("���� ������.");

					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		private void btnSetDateTime_Click(object sender, EventArgs e)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID; 
			}

			Trip oTripSet = new Trip();
			oTripSet.ReFillOne(nTripID);

			// ��������
			if (oTripSet.IsConfirmed)
			{
				RFMMessage.MessageBoxInfo("���� ��� �����������...");
				return; 
			}
			//

			if (StartForm(new frmTripsTimes(nTripID)) == DialogResult.Yes)
			{
				if (sPageName.Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (sPageName.Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
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

	#region Carry

		private void btnOutputCarry_Click(object sender, EventArgs e)
		{
			// ������� ������� ������ � �������� 

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			string sMode = "";
			RFMDataGridView grd = null;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
					return; 

				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
				{
					sMode = "OUTPUTS";
					grd = grdTrips_Outputs;
				}
				else
				{
					if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("INPUTS"))
					{
						sMode = "INPUTS";
						grd = grdTrips_Inputs;
					}
					else
					{
						RFMMessage.MessageBoxInfo("��� �������� ���������� ������� ������ � ����������� ������� ������� � ������ ������� �������.");
						return;
					}
				}
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
					return;
				
				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
				{
					sMode = "OUTPUTS";
					grd = grdOthers_Outputs;
				}
				else
				{
					if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("INPUTS"))
					{
						sMode = "INPUTS";
						grd = grdOthers_Inputs;
					}
					else
					{
						RFMMessage.MessageBoxInfo("��� �������� ���������� ������� ������ � ����������� ������� ������� � ������ ������� �������.");
						return;
					}
				}
				nTripID = (int)oOtherCur.ID;
			}
			
			if (grd.Rows.Count == 0)
				return; 
			if (grd.CurrentRow == null)
				return;
			if (grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			Trip oTripCarry = new Trip();
			oTripCarry.ReFillOne(nTripID);

			if (oTripCarry.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������.\n������� ������� � ���������� �� �����������.");
				return; 
			}
			if (!oTripCarry.DepartureTime.HasValue)
			{
				RFMMessage.MessageBoxAttention("��������!\n\n������ ��� �� �����!");
			}
			if (!oTripCarry.ArrivalTime.HasValue)
			{
				RFMMessage.MessageBoxAttention("��������!\n\n������ ��� �� ���������!");
			}
			// � ������ ��� ���������, ����� ����������

			DataRow r = ((DataRowView)grd.CurrentRow.DataBoundItem).Row;

			if (sMode == "OUTPUTS")
			{
				// �������
				Output oOutputCarry = new Output();
				oOutputCarry.ReFillOne((int)r["ID"]);

				if (!oOutputCarry.TripID.HasValue ||
					(int)oOutputCarry.TripID != nTripID)
				{
					RFMMessage.MessageBoxError("������� �� ������ ��� ���������� � �� ��������� � ������� �����.");
					return;
				}

				string sText = "";
				string sPartnersList = ""; // ������ ��������� 

				OutputDocument oOutputDocumentCarry = new OutputDocument();
				oOutputDocumentCarry.FilterOutputsList = r["ID"].ToString();
				oOutputDocumentCarry.FillData();
				int nOutputsDocumentsQnt = oOutputDocumentCarry.MainTable.Rows.Count; // r["OutputsDocumentsQnt"]
				OutputDocument oOutputDocumentCarryOne = new OutputDocument();
				foreach (DataRow ro in oOutputDocumentCarry.MainTable.Rows)
				{
					oOutputDocumentCarryOne.FillOne(ro);
					if (oOutputDocumentCarryOne.IsBrought)
					{
						sText = (nOutputsDocumentsQnt > 1)
							? "����� ��������� ����������, �������� � ������ �������, ���� ���������, �� ������� ��� ���������������� �������� ����������."
							: "�� ���������� ���������, ��������� � ������ �������, ��� ���������������� �������� ����������.";
						RFMMessage.MessageBoxError(sText + "\n������� ������� �� ������������.");
						return;
					}
					sPartnersList += oOutputDocumentCarryOne.PartnerTargetID.ToString().Trim() + ","; 
				}

				bool bAsked = false; 

				if (nOutputsDocumentsQnt > 1)
				{ 
					sText = "������ ������� �������� ��������� ���������� (" + nOutputsDocumentsQnt.ToString().Trim() + ") ��� " + 
						((oOutputCarry.PointsQnt > 1) ? "������ �����������" : "������ ����������") + ".\n" + 
						"��� �������� ������� ����� ���������� ��� ��������� ���������, �������� � �������.";  
					if (RFMMessage.MessageBoxYesNo(sText +  
							"\n\n��������� ������� ������� � ���� ��������� ����������?") != DialogResult.Yes)
						return;

					bAsked = true;
				}

				// �������
				// -- ��� ������� � �����
				int nInputsCnt = 0;
				string sInputsList = "";
				Input oInputCarry = new Input();
				oInputCarry.FilterTripsList = nTripID.ToString();
				oInputCarry.FilterIsConfirmed = false;
				oInputCarry.FilterPartnersList = sPartnersList;
				oInputCarry.FillData();
				if (oInputCarry.ErrorNumber != 0 || oInputCarry.MainTable == null)
				{
					RFMMessage.MessageBoxError("������ ��� ��������� ������ � �������� � �����...");
					return;
				}
				if (oInputCarry.MainTable.Rows.Count > 0)
				{
					// �������� ������� ���������� � ��������
					int nInputsDocumentsCnt = 0; 
					foreach (DataRow ic in oInputCarry.MainTable.Rows)
					{
						if ((bool)ic["InputsDocumentsExists"])
						{
							nInputsDocumentsCnt++;
						}
						else
						{
							// ���� ������ ����� ���������� 
							nInputsCnt++;
							sInputsList += ic["ID"].ToString().Trim() + ",";
						}
					}

					if (nInputsDocumentsCnt > 0)
					{
						sText = "��������!\n\n" +						
								"����� ������� �� ������ " +
								((oOutputCarry.PointsQnt > 1) ? "��� �� ��������" : "���� �� �������") + ", �������������� � ���� �� �����,\n" +
								"���� ������� (" + nInputsDocumentsCnt.ToString().Trim() + "), ��� ������� ��������� ��������� ���������,\n" +
								"��� ������������ ��������� ��������� ����� ��������\n" +
								"(����� ������� �� ����� ���� ����������).\n\n" +
								"�� �������, ��� ������� ���������� ���������� �������� ��������?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
							return;
					}

					if (nInputsCnt > 0)
					{
						sText = "� ����� �����������" +
							((nInputsCnt > 1) ? "�" : "") + " ��� " +
							RFMUtilities.Declen(nInputsCnt, "������", "�������", "��������") + " ��� " +
							((oOutputCarry.PointsQnt > 1) ? "��� �� ��������" : "���� �� �������") + "." +
							"\n\n��������� ����� ������� " + ((nInputsCnt > 1) ? "���� ������� �� ������" : "������� �� ������") +
							"?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						{
							nInputsCnt = 0;
							sInputsList = "";
						}
					}

					bAsked = false;
				}

				if (!bAsked)
				{
					sText = "��������� ������� �� ������ � �������� � ���� ��������� ��������� (" + nOutputsDocumentsQnt.ToString().Trim() + ")";
					if (nInputsCnt > 0)
						sText += ", � ����� ������� (" + nInputsCnt.ToString().Trim() + "),";
					sText += " �� ������ ����?";
					if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						return; 
				}

				// ����� ����
				DateTime dNewDate = DateTime.Now.Date.AddDays(1);
				if (dNewDate.DayOfWeek == DayOfWeek.Sunday)
				{
					dNewDate = dNewDate.AddDays(1);
				}
				if (StartForm(new frmInputBoxDate("����� ���� ��������:", dNewDate)) == DialogResult.Yes)
				{
					if (GotParam[0] != null)
					{
						dNewDate = Convert.ToDateTime(GotParam[0]);
					}
					if (oOutputCarry.DateOutput.Date.CompareTo(dNewDate) == 0)
					{
						if (RFMMessage.MessageBoxYesNo("��� �������� ������� �� �� ����.\n\n" +
								"���-���� ��������� ����������� ������� �� ������ � ��������� ���������� �� �����?") != DialogResult.Yes)
							return;
					}
				}
				else return;

				// ������� ����������
				_SelectedID = null;
				oOutputDocumentCarry.FillTableOutputsDocumentsFailsReasons();
				if (StartForm(new frmSelectID(this, oOutputDocumentCarry.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "������� ���������� ����������, ��������")) == DialogResult.Yes)
				{
					if (!_SelectedID.HasValue)
					{
						RFMMessage.MessageBoxError("�� ������� ������� ���������� ������ ����������.");
						return;
					}
					int nOutputDocumentFailReasonID = (int)_SelectedID;
					if (RFMMessage.MessageBoxYesNo("��������!\n\n" +
						"������� �� ������ � " + RFMUtilities.Declen(nOutputsDocumentsQnt, "��������� ��������", "��������� ���������", "��������� ����������") + " ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
						" � ���������� �� �������� �����.\n\n" +
						"����������?") != DialogResult.Yes)
						return;

					WaitOn(this);
					bool bResult = oOutputCarry.Carry((int)oOutputCarry.ID, dNewDate, nOutputDocumentFailReasonID, ((RFMFormMain)Application.OpenForms[0]).UserID);
					WaitOff(this);
					if (bResult && oOutputCarry.ErrorNumber == 0)
					{
						//RFMMessage.MessageBoxInfo("��������������� ������� ������� �� ������ � ��������� ���������� �� ������ ����.");
						LogService.OutputBill_Print(oOutputCarry, this);

						// ������� �������� 
						if (nInputsCnt > 0)
						{
							sText = "��������!\n\n";
							if (nInputsCnt == 1)
								sText = "1 ������� �� ������ ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
										" � ���������� �� �������� �����.";
							else
								sText = RFMUtilities.Declen(nInputsCnt, "������� �� ������", "������� �� ������", "������� �� ������") + " ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
										" � ���������� �� �������� �����.";
							if (RFMMessage.MessageBoxYesNo(sText + "\n\n����������?") == DialogResult.Yes)
							{
								oInputCarry.IDList = sInputsList;
								oInputCarry.FillData();
								if (oInputCarry.ErrorNumber != 0 || oInputCarry.MainTable == null)
								{
									RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������...");
								}
								else
								{
									if (oInputCarry.MainTable.Rows.Count > 0)
									{
										Input oInputCarryOne = new Input();
										foreach (DataRow i in oInputCarry.MainTable.Rows)
										{
											oInputCarryOne.ReFillOne((int)i["ID"]);
											if (!oInputCarryOne.IsConfirmed && !oInputCarryOne.InputsDocumentsExists)
											{
												oInputCarryOne.Carry((int)oInputCarryOne.ID, dNewDate, null, ((RFMFormMain)Application.OpenForms[0]).UserID);
											}
										}
									}
								}
							}
						}

						if (sPageName.Contains("TRIPS"))
						{
							grdTrips_Restore();
						}
						if (sPageName.Contains("OTHERS"))
						{
							grdOthers_Restore();
						}
					}
				}
			}
			else
			{
				// �������
				Input oInputCarry = new Input();
				oInputCarry.ReFillOne((int)r["ID"]);

				if (!oInputCarry.TripID.HasValue ||
					(int)oInputCarry.TripID != nTripID)
				{
					RFMMessage.MessageBoxError("������� �� ������ ��� ���������� � �� ��������� � �������� �����.");
					return;
				}
				if (oInputCarry.IsConfirmed)
				{
					RFMMessage.MessageBoxError("������� �� ������ ��� ������������.\n\n" + 
						"������� ������� �� �����������.");
					return;
				}
				if (oInputCarry.InputsDocumentsExists)
				{
					RFMMessage.MessageBoxError("��� ������� �� ������ ��� ��������� ��������� ���������.\n\n" +
						"������� ������� �� �����������.");
					return;
				}

				if (RFMMessage.MessageBoxYesNo("��������� ������� �� ������ �� ������ ����?") == DialogResult.Yes)
				{
					// ����� ����
					DateTime dNewDate = DateTime.Now.Date.AddDays(1);
					if (dNewDate.DayOfWeek == DayOfWeek.Sunday)
					{
						dNewDate = dNewDate.AddDays(1);
					}
					if (StartForm(new frmInputBoxDate("����� ���� ��������:", dNewDate)) == DialogResult.Yes)
					{
						if (GotParam[0] != null)
						{
							dNewDate = Convert.ToDateTime(GotParam[0]);
						}
						if (oInputCarry.DateInput.Date.CompareTo(dNewDate) == 0)
						{
							if (RFMMessage.MessageBoxYesNo("��� �������� ������� �� �� ����.\n\n" +
									"���-���� ��������� ����������� ������� �� ������ �� �����?") != DialogResult.Yes)
								return;
						}
					}
					else return;

					// ������� ������������
					_SelectedID = null;
					InputDocument oInputDocumentTemp = new InputDocument();
					oInputDocumentTemp.FillTableInputsDocumentsFailsReasons();
					if (StartForm(new frmSelectID(this, oInputDocumentTemp.TableInputsDocumentsFailsReasons, "Name", "������� ���������� �� ����������")) == DialogResult.Yes)
					{
						if (!_SelectedID.HasValue)
						{
							RFMMessage.MessageBoxError("�� ������� ������� ���������� ������ �� ����������.");
							return;
						}

						int nInputDocumentFailReasonID = (int)_SelectedID;

						if (RFMMessage.MessageBoxYesNo("��������!\n\n" +
							"������� �� ������ ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
							" � ���������� �� �������� �����.\n\n" +
							"����������?") != DialogResult.Yes)
							return;

						WaitOn(this);
						bool bResult = oInputCarry.Carry((int)oInputCarry.ID, dNewDate, nInputDocumentFailReasonID, ((RFMFormMain)Application.OpenForms[0]).UserID);
						WaitOff(this);
						if (bResult && oInputCarry.ErrorNumber == 0)
						{
							//RFMMessage.MessageBoxInfo("��������������� ������� ������� �� ������ � ��������� ���������� �� ������ ����.");

							if (sPageName.Contains("TRIPS"))
							{
								grdTrips_Restore();
							}
							if (sPageName.Contains("OTHERS"))
							{
								grdOthers_Restore();
							}
						}
					}
				}
			}
		}

		private void btnOutputCopy_Click(object sender, EventArgs e)
		{
			// ������� ������ � ����� �������

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			string sMode = "";
			RFMDataGridView grd = null;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS".ToUpper()))
				{
					if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OutputsDocuments".ToUpper()))
					{
						sMode = "OUTPUTSDOCUMENTS";
						grd = grdTrips_OutputsDocuments;
					}
					else
					{
						if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("InputsDocuments".ToUpper()))
						{
							sMode = "INPUTSDOCUMENTS";
							grd = grdTrips_InputsDocuments;
						}
						else
						{
							RFMMessage.MessageBoxInfo("��� ����������� ���������� ������� ��� ��������� ������� ������� � ������ ������� ������� ��� ����������.");
							return;
						}
					}
				}
				else
				{
					if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
					{
						sMode = "OUTPUTS";
						grd = grdTrips_Outputs;
					}
				}
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS".ToUpper()))
				{
					if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OutputsDocuments".ToUpper()))
					{
						sMode = "OUTPUTSDOCUMENTS";
						grd = grdOthers_OutputsDocuments;
					}
					else
					{
						if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("InputsDocuments".ToUpper()))
						{
							sMode = "INPUTSDOCUMENTS";
							grd = grdOthers_InputsDocuments;
						}
						else
						{
							RFMMessage.MessageBoxInfo("��� ����������� ���������� ������� ��� ��������� ������� ������� � ������ ������� ������� ��� ����������.");
							return;
						}
					}
				}
				else
				{
					if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
					{
						sMode = "OUTPUTS";
						grd = grdTrips_Outputs;
					}
				}
				nTripID = (int)oOtherCur.ID;
			}
			
			if (grd.Rows.Count == 0)
				return; 
			if (grd.CurrentRow == null)
				return;
			if (grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			Trip oTripCarry = new Trip();
			oTripCarry.ReFillOne(nTripID);

			if (oTripCarry.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������.\n����������� (�������) ������� � ���������� �� �����������.");
				return; 
			}
			if (!oTripCarry.DepartureTime.HasValue)
			{
				RFMMessage.MessageBoxAttention("��������!\n\n������ ��� �� �����!");
			}
			if (!oTripCarry.ArrivalTime.HasValue)
			{
				RFMMessage.MessageBoxAttention("��������!\n\n������ ��� �� ���������!");
			}
			// � ������ ��� ���������, ����� ����������

			DataRow r = ((DataRowView)grd.CurrentRow.DataBoundItem).Row;

			bool bAsked = false;
			string sText = "";

			#region ������ + ������
			if (sMode == "Outputs".ToUpper())
			{
				// �������
				Output oOutputCarryCopy = new Output();
				oOutputCarryCopy.ReFillOne((int)r["ID"]);

				if (!oOutputCarryCopy.TripID.HasValue ||
					(int)oOutputCarryCopy.TripID != nTripID)
				{
					RFMMessage.MessageBoxError("������� �� ������ ��� ���������� � �� ��������� � ������� �����.");
					return; 
				}

				string sPartnersList = ""; // ������ ��������� 

				OutputDocument oOutputDocumentCarry = new OutputDocument();
				oOutputDocumentCarry.FilterOutputsList = r["ID"].ToString();
				oOutputDocumentCarry.FillData();
				int nOutputsDocumentsQnt = oOutputDocumentCarry.MainTable.Rows.Count; // r["OutputsDocumentsQnt"]
				OutputDocument oOutputDocumentCarryOne = new OutputDocument();
				foreach (DataRow ro in oOutputDocumentCarry.MainTable.Rows)
				{
					oOutputDocumentCarryOne.FillOne(ro);
					if (oOutputDocumentCarryOne.IsBrought)
					{
						sText = (nOutputsDocumentsQnt > 1)
							? "����� ��������� ����������, �������� � ������ �������, ���� ���������, �� ������� ��� ���������������� �������� ����������."
							: "�� ���������� ���������, ��������� � ������ �������, ��� ���������������� �������� ����������.";
						RFMMessage.MessageBoxError(sText + "\n����������� (�������) ������� �� ������������.");
						return;
					}
					sPartnersList += oOutputDocumentCarryOne.PartnerTargetID.ToString().Trim() + ","; 
				}

				if (nOutputsDocumentsQnt > 1)
				{
					sText = "������ ������� �������� ��������� ���������� (" + nOutputsDocumentsQnt.ToString().Trim() + ") ��� " +
						((oOutputCarryCopy.PointsQnt > 1) ? "������ �����������" : "������ ����������") + ".\n" +
						"��� ����������� (��������) ������� ����� ����������� (����������) ��� ��������� ���������, �������� � �������.";
					if (RFMMessage.MessageBoxYesNo(sText +
							"\n\n��������� ����������� (�������) ������� � ���� ��������� ����������?") != DialogResult.Yes)
						return;
					bAsked = true;
				}

				// �������
				// -- ��� ������� � ����� �� ��� �� ��������
				int nInputsCnt = 0;
				string sInputsList = "";
				Input oInputCarry = new Input();
				oInputCarry.FilterTripsList = nTripID.ToString();
				oInputCarry.FilterIsConfirmed = false;
				oInputCarry.FilterPartnersList = sPartnersList;
				oInputCarry.FillData();
				if (oInputCarry.ErrorNumber != 0 || oInputCarry.MainTable == null)
				{
					RFMMessage.MessageBoxError("������ ��� ��������� ������ � �������� � �����...");
					return;
				}
				if (oInputCarry.MainTable.Rows.Count > 0)
				{
					// �������� ������� ���������� � ��������
					int nInputsDocumentsCnt = 0;
					foreach (DataRow ic in oInputCarry.MainTable.Rows)
					{
						if ((bool)ic["InputsDocumentsExists"])
						{
							nInputsDocumentsCnt++;
						}
						else
						{
							// ���� ������ ����� ���������� 
							nInputsCnt++;
							sInputsList += ic["ID"].ToString().Trim() + ",";
						}
					}

					if (nInputsDocumentsCnt > 0)
					{
						sText = "��������!\n\n" +
								"����� ������� �� ������ " +
								((oOutputCarryCopy.PointsQnt > 1) ? "��� �� ��������" : "���� �� �������") + ", �������������� � ���� �� �����,\n" +
								"���� ������� (" + nInputsDocumentsCnt.ToString().Trim() + "), ��� ������� ��������� ��������� ���������,\n" +
								"��� ������������ ��������� ��������� ����� ��������\n" +
								"(����� ������� �� ����� ���� ����������).\n\n" +
								"�� �������, ��� ������� ���������� ���������� �������� ����������� (��������)?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
							return;
					}

					if (nInputsCnt > 0)
					{
						sText = "� ����� �����������" +
							((nInputsCnt > 1) ? "�" : "") + " ��� " +
							RFMUtilities.Declen(nInputsCnt, "������", "�������", "��������") + " ��� " +
							((oOutputCarryCopy.PointsQnt > 1) ? "��� �� ��������" : "���� �� �������") + "." +
							"\n\n��������� ����� ������� " + ((nInputsCnt > 1) ? "���� ������� �� ������" : "������� �� ������") +
							"?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						{
							nInputsCnt = 0;
							sInputsList = "";
						}
					}

					bAsked = false;
				}

				if (!bAsked)
				{
					sText = "����������� (���������) ������� �� ������ � �������� � ���� ��������� ��������� (" + nOutputsDocumentsQnt.ToString().Trim() + ")";
					if (nInputsCnt > 0)
						sText += ", � ����� ��������� ������� (" + nInputsCnt.ToString().Trim() + ")";
					sText += " �� ������ ����?";
					if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						return;
				}

				// ����� ����
				DateTime dNewDate = DateTime.Now.Date.AddDays(1);
				if (dNewDate.DayOfWeek == DayOfWeek.Sunday)
				{
					dNewDate = dNewDate.AddDays(1);
				}
				if (StartForm(new frmInputBoxDate("����� ���� ��������:", dNewDate)) == DialogResult.Yes)
				{
					if (GotParam[0] != null)
					{
						dNewDate = Convert.ToDateTime(GotParam[0]);
					}
					if (oOutputCarryCopy.DateOutput.Date.CompareTo(dNewDate) == 0)
					{
						if (RFMMessage.MessageBoxYesNo("��� ����������� (��������) ������� �� �� ����.\n\n" +
								"���-���� ����������� ������� � ��������� ���������?") != DialogResult.Yes)
							return;
					}
				}
				else return;

				// ������� ����������
				_SelectedID = null;
				oOutputDocumentCarry.FillTableOutputsDocumentsFailsReasons();
				if (StartForm(new frmSelectID(this, oOutputDocumentCarry.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "������� ���������� ����������, ��������")) == DialogResult.Yes)
				{
					if (!_SelectedID.HasValue)
					{
						RFMMessage.MessageBoxError("�� ������� ������� ���������� ������ ����������.");
						return;
					}
					int nOutputDocumentFailReasonID = (int)_SelectedID;
					if (RFMMessage.MessageBoxYesNo("��������!\n\n" +
						"������� �� ������ � " + RFMUtilities.Declen(nOutputsDocumentsQnt, "��������� ��������", "��������� ���������", "��������� ����������") + " ����� ����������� (����������) �� " + dNewDate.ToString("dd.MM.yyyy") + "\n" +
						"(������� ������� � ��� �������� � ���� ��������� ��������� ��������� ������������ � �������� �����).\n\n" +
						"����������?") != DialogResult.Yes)
						return;

					WaitOn(this);
					int? nNewOutputID = null;
					bool bResult = oOutputCarryCopy.CarryCopy((int)oOutputCarryCopy.ID, dNewDate, nOutputDocumentFailReasonID,  
						 ((RFMFormMain)Application.OpenForms[0]).UserID, ref nNewOutputID);
					WaitOff(this);

					if (nInputsCnt > 0)
					{
						sText = "��������!\n\n";
						if (nInputsCnt == 1)
							sText = "1 ������� �� ������ ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
									" � ���������� �� �������� �����.";
						else
							sText = RFMUtilities.Declen(nInputsCnt, "������� �� ������", "������� �� ������", "������� �� ������") + " ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
									" � ���������� �� �������� �����.";
						if (RFMMessage.MessageBoxYesNo(sText + "\n\n����������?") == DialogResult.Yes)
						{
							oInputCarry.IDList = sInputsList;
							oInputCarry.FillData();
							if (oInputCarry.ErrorNumber != 0 || oInputCarry.MainTable == null)
							{
								RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������...");
							}
							else
							{
								if (oInputCarry.MainTable.Rows.Count > 0)
								{
									Input oInputCarryOne = new Input();
									foreach (DataRow i in oInputCarry.MainTable.Rows)
									{
										oInputCarryOne.ReFillOne((int)i["ID"]);
										if (!oInputCarryOne.IsConfirmed && !oInputCarryOne.InputsDocumentsExists)
										{
											oInputCarryOne.Carry((int)oInputCarryOne.ID, dNewDate, null, ((RFMFormMain)Application.OpenForms[0]).UserID);
										}
									}
								}
							}
						}
					}

					if (bResult)
					{
						if (sPageName.Contains("TRIPS"))
						{
							grdTrips_Restore();
						}
						if (sPageName.Contains("OTHERS"))
						{
							grdOthers_Restore();
						}
					}
				}
			}
			#endregion ������ + ������
		
			#region ����� 
			if (sMode == "OutputsDocuments".ToUpper())
			{
				// ����� ���������� (��������, ������ � ������� ��� ���� �� ����������) � ��� ���� ��������� ����� �������

				OutputDocument oOutputDocumentCarry = new OutputDocument();
				oOutputDocumentCarry.ReFillOne((int)r["ID"]);

				if (!oOutputDocumentCarry.TripID.HasValue || 
					(int)oOutputDocumentCarry.TripID != nTripID)
				{
					RFMMessage.MessageBoxError("��������� �������� ��� ��������� � �� �������� � ������� �����.");
					return;
				}

				if (oOutputDocumentCarry.IsBrought)
				{ 
					RFMMessage.MessageBoxError("�� ���������� ��������� ��� ���������������� �������� �������.\n" + 
						"����������� (�������) ��������� �� �����������.");
					return;
				}

				if (oOutputDocumentCarry.OutputID.HasValue)
				{ 
					// �������
					Output oOutputCarry = new Output();
					oOutputCarry.ReFillOne((int)oOutputDocumentCarry.OutputID);
					int nPointsQnt = oOutputCarry.PointsQnt;
					int nOutputsDocumentsQnt = oOutputCarry.OutputsDocumentsQnt; 
					if (nPointsQnt == 1)
					{
						/*
						string sText = (nOutputsDocumentsQnt > 1)
							? "������� �� ������, � ������� ������ ������ ��������, �������� ��� " + RFMUtilities.Declen(nOutputsDocumentsQnt - 1, "��������", "���������", "����������") + " ���� �� �������.\n" +
								"������� ������� ��������� ����������� ������ ����� �������� ������� ������ �� ����� ��������� � ���� �����������."
							: "������� �� ������ �������� ������ ������ ��������.\n������� ������� ��������� ����������� ������ ����� �������� ������� �������.";
						RFMMessage.MessageBoxError(sText + "\n������� ���������� ��������� �� ������������.");
						return;
						*/ 
					}
				}

				// ��� �� ��� ������� ��� ���� �� ����������, ���������� ��� �����������
				string sOutputsDocumentsNearList = "";
				int nNearCount = 0;
				OutputDocument oOutputDocumentNear = new OutputDocument();
				if (!oOutputDocumentCarry.NotForJoin)
				{
					oOutputDocumentNear.FilterOutputsList = oOutputDocumentCarry.OutputID.ToString();
					oOutputDocumentNear.FilterPartnersDetailsBayersList = oOutputDocumentCarry.PartnerDetailBayerID.ToString();
					//oOutputDocumentNear.FilterPartnersDetailsSalersList = oOutputDocumentCarry.PartnerDetailSalerID.ToString();
					oOutputDocumentNear.FilterIsBrought = false;
					oOutputDocumentNear.FillData();
					if (oOutputDocumentNear.MainTable != null && oOutputDocumentNear.MainTable.Rows.Count > 1)
					{
						foreach (DataRow ron in oOutputDocumentNear.MainTable.Rows)
						{ 
							if ((int)ron["ID"] != (int)oOutputDocumentCarry.ID)
							{
								if (!(bool)ron["NotForJoin"])
								{
									sOutputsDocumentsNearList += ron["ID"].ToString() + ",";
									nNearCount++;
								}
							}
						}
						if (nNearCount > 0)
						{
							if (RFMMessage.MessageBoxYesNo("� ��������� ������� ������� ��� " + RFMUtilities.Declen(nNearCount, "��������� ��������", "��������� ���������", "��������� ����������") +
								" ��� ���� �� ����������.\n" +
								"����������� ��� ��� ���������\n" +
								"(�� - ���������� ��� ��������� ��� ������� ����������, ��� - ���������� ������ ������� ��������)?") == DialogResult.Yes)
							{
								// �������� ������
							}
							else
							{ 
								// �������� ����
								sOutputsDocumentsNearList = "";
								nNearCount = 0;
							}
						}
					}
				}

				// �������
				int nInputsCnt = 0;
				string sInputsList = "";
				Input oInputCarry = new Input();
				oInputCarry.FilterTripsList = nTripID.ToString();
				oInputCarry.FilterIsConfirmed = false;
				oInputCarry.FilterPartnersList = oOutputDocumentCarry.PartnerTargetID.ToString();
				oInputCarry.FillData();
				if (oInputCarry.ErrorNumber != 0 || oInputCarry.MainTable == null)
				{
					RFMMessage.MessageBoxError("������ ��� ��������� ������ � �������� � ����������� � �����...");
					return;
				}
				if (oInputCarry.MainTable.Rows.Count > 0)
				{
					// �������� ������� ���������� � ��������
					int nInputsDocumentsCnt = 0;
					foreach (DataRow ic in oInputCarry.MainTable.Rows)
					{
						if ((bool)ic["InputsDocumentsExists"])
						{
							nInputsDocumentsCnt++;
						}
						else
						{
							// ���� ������ ����� ���������� 
							nInputsCnt++;
							sInputsList += ic["ID"].ToString().Trim() + ",";
						}
					}

					if (nInputsDocumentsCnt > 0)
					{
						sText = "��������!\n\n" +
								"����� ������� �� ������ ���� �� �������, �������������� � ���� �� �����,\n" +
								"���� ������� (" + nInputsDocumentsCnt.ToString().Trim() + "), ��� ������� ��������� ��������� ���������,\n" +
								"��� ������������ ��������� ��������� ����� ��������\n" +
								"(����� ������� �� ����� ���� ����������).\n\n" +
								"�� �������, ��� ������� ���������� ���������� �������� ����������� (��������)?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
							return;
					}

					if (nInputsCnt > 0)
					{
						sText = "� ����� �����������" +
							((nInputsCnt > 1) ? "�" : "") + " ��� " +
							RFMUtilities.Declen(nInputsCnt, "������", "�������", "��������") + " ��� ���� �� �������." +
							"\n\n��������� ����� ������� " + ((nInputsCnt > 1) ? "���� ������� �� ������" : "������� �� ������") +
							"?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
						{
							nInputsCnt = 0;
							sInputsList = "";
						}
					}

					bAsked = false;
				}

				sText = (nNearCount > 0) 
					? "����������� (���������) " + RFMUtilities.Declen(nNearCount + 1, "��������� ��������", "��������� ���������", "��������� ����������") + 
						" �� ������ ���� � ��������� ��� ��� ����� ������� �� ������"
					: "����������� (���������) ��������� �������� �� ������ ���� � ��������� ��� ���� ����� ������� �� ������";
				if (nInputsCnt > 0)
					sText += ",\n" + 
						"� ����� ��������� ������� (" + nInputsCnt.ToString().Trim() + ") ��� ���� �� ������� �� ������ ����";
				if (RFMMessage.MessageBoxYesNo(sText + "?") == DialogResult.Yes)
				{
					// ����� ����
					DateTime dNewDate = DateTime.Now.Date.AddDays(1);
					if (dNewDate.DayOfWeek == DayOfWeek.Sunday)
					{
						dNewDate = dNewDate.AddDays(1);
					}
					if (StartForm(new frmInputBoxDate("����� ���� ��������:", dNewDate)) == DialogResult.Yes)
					{
						if (GotParam[0] != null)
						{
							dNewDate = Convert.ToDateTime(GotParam[0]);
						}
						if (oOutputDocumentCarry.DateOutput.ToString("dd.MM.yyyy") == dNewDate.ToString("dd.MM.yyyy"))
						{
							if (RFMMessage.MessageBoxYesNo("��� �������� ������� �� �� ����.\n\n" +
								"���-���� ��������� ����������� (�������) " + ((nNearCount > 0) ? "��������� ����������" : "���������� ���������") + 
								" � ������������ ����� ������� �� ������?") != DialogResult.Yes)
								return;
						}
					}
					else return;

					// ������� ����������
					_SelectedID = null;
					oOutputDocumentCarry.FillTableOutputsDocumentsFailsReasons();
					if (StartForm(new frmSelectID(this, oOutputDocumentCarry.TableOutputsDocumentsFailsReasons, "Name, GuiltyName", "������� ���������� ����������, ��������")) == DialogResult.Yes)
					{
						if (!_SelectedID.HasValue)
						{
							RFMMessage.MessageBoxError("�� ������� ������� ���������� ������ ����������.");
							return;
						}

						int nOutputDocumentFailReasonID = (int)_SelectedID;

						sText = (nNearCount > 0) 
							? RFMUtilities.Declen(nNearCount + 1, 
								"��������� �������� ����� ���������� (���������)", 
								"��������� ��������� ����� ����������� (����������)", 
								"��������� ���������� ����� ����������� (����������)") + 
							" �� " + dNewDate.ToString("dd.MM.yyyy") + ", " + 
							"��� ��� ����� ������������ ����� ������� �� ������\n" +
							"(������� ��������� ��������� � ������� �� ������, � ������� ��� ������, ��������� ������������ � �������� �����)." 
							: "��������� �������� ����� ���������� (���������)" + 
							" �� " + dNewDate.ToString("dd.MM.yyyy") + ", " + 
							"��� ���� ����� ������������ ����� ������� �� ������\n" +
							"(������� ��������� �������� � ������� �� ������, � ������� �� ������, ��������� ������������ � �������� �����).";
						if (RFMMessage.MessageBoxYesNo("��������!\n\n" + sText + "\n\n����������?") != DialogResult.Yes)
							return;

						int? nNewOutputDocumentID = null;
						WaitOn(this);
						bool bResult = oOutputDocumentCarry.CarryCopy((int)oOutputDocumentCarry.ID, dNewDate, nOutputDocumentFailReasonID, ((RFMFormMain)Application.OpenForms[0]).UserID, ref nNewOutputDocumentID, false);
						WaitOff(this);
						if (bResult && oOutputDocumentCarry.ErrorNumber == 0)
						{
							// � ���������, ���� ����
							if (nNearCount > 0)
							{
								WaitOn(this);
								oOutputDocumentNear.IDList = sOutputsDocumentsNearList;
								oOutputDocumentNear.FillData();
								foreach (DataRow ron in oOutputDocumentNear.MainTable.Rows)
								{
									nNewOutputDocumentID = null;
									bResult = oOutputDocumentCarry.CarryCopy((int)ron["ID"], dNewDate, nOutputDocumentFailReasonID, ((RFMFormMain)Application.OpenForms[0]).UserID, ref nNewOutputDocumentID, true);
								}
								WaitOff(this);
							}

							//RFMMessage.MessageBoxInfo("��������������� ������� ���������� ��������� �� ������ ����." + 
							//	((nNewOutputDocumentID.HasValue) ? "\n����������� ����� ��������� ��������." : ""));

							// ������� �������� 
							if (nInputsCnt > 0)
							{
								sText = "��������!\n\n";
								if (nInputsCnt == 1)
									sText = "1 ������� �� ������ ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
											" � ���������� �� �������� �����.";
								else
									sText = RFMUtilities.Declen(nInputsCnt, "������� �� ������", "������� �� ������", "������� �� ������") + " ����� ���������� �� " + dNewDate.ToString("dd.MM.yyyy") +
											" � ���������� �� �������� �����.";
								if (RFMMessage.MessageBoxYesNo(sText + "\n\n����������?") == DialogResult.Yes)
								{
									oInputCarry.IDList = sInputsList;
									oInputCarry.FillData();
									if (oInputCarry.ErrorNumber != 0 || oInputCarry.MainTable == null)
									{
										RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������...");
									}
									else
									{
										if (oInputCarry.MainTable.Rows.Count > 0)
										{
											Input oInputCarryOne = new Input();
											foreach (DataRow i in oInputCarry.MainTable.Rows)
											{
												oInputCarryOne.ReFillOne((int)i["ID"]);
												if (!oInputCarryOne.IsConfirmed && !oInputCarryOne.InputsDocumentsExists)
												{
													oInputCarryOne.Carry((int)oInputCarryOne.ID, dNewDate, null, ((RFMFormMain)Application.OpenForms[0]).UserID);
												}
											}
										}
									}
								}
							}

							if (sPageName.Contains("TRIPS"))
							{
								grdTrips_Restore();
							}
							if (sPageName.Contains("OTHERS"))
							{
								grdOthers_Restore();
							}
						}
					}
				}
			}
			#endregion ����� 

			// ������ �� �������� - �� ������������. 
			// ������ ������ � ��������
		}

	#endregion Carry

	#region MenusTrip

		#region trips print 

		private void mniTripsPrintDocumentsOne_Click(object sender, EventArgs e)
		{
			TripPrintDocuments(false);
		}

		private void mniTripsPrintDocumentsAll_Click(object sender, EventArgs e)
		{
			TripPrintDocuments(true);
		}

		private void mniTripsPrintDocuments_OneOutputDocument_Click(object sender, EventArgs e)
		{
			TripPrintDocuments_OneOutputDocument();
		}

		private void mniTripsPrintDocuments_OneInput_Click(object sender, EventArgs e)
		{
			TripPrintDocuments_OneInput();
		}

		private void mniTripsPrintBill_Click(object sender, EventArgs e)
		{
			TripBill(false, "TripBill");
		}

		private void mniTripsPrintBillShort_Click(object sender, EventArgs e)
		{
			TripBill(false, "TripBillShort");
		}

		private void mniTripsPrintWayBill_Click(object sender, EventArgs e)
		{
			TripWayBill(false, "TripWayBillStd");
		}

		private void mniTripsPrintQualities_Click(object sender, EventArgs e)
		{
			Trip_Qualities();
		}

		private void mniTripsPrintInputsBill_Click(object sender, EventArgs e)
		{
			Trip_InputsBill();
		}

		private void mniTripsPrintVeterinaryBlankData_Click(object sender, EventArgs e)
		{
			VeterinaryBlankData();
		}

		private void mniTripsPrintTTNData_Click(object sender, EventArgs e)
		{
			Trip_TTNData(); 
		}

		private void mniTripsPrintOutputTTNData_Click(object sender, EventArgs e)
		{
			Trip_OutputTTNData(); 
		}

		private void mniTripsPrintReportTripsPutsBalances_Click(object sender, EventArgs e)
		{
			Trip_PutsBalances();
		}

		private void mniTripsPrintGoodsGroupsList_Click(object sender, EventArgs e)
		{
			Trip_GoodsGroupsList();
		}

		private void mniTripsPrintReportTripsList_Click(object sender, EventArgs e)
		{
			Trip_TripsList();
		}

		private void mniTripsPrintReportTripsListNotes_Click(object sender, EventArgs e)
		{
			Trip_TripsListNotes();
		}

		private void mniTripsPrintReportTripBalance_Click(object sender, EventArgs e)
		{
			Trip_TripBalance();
		}

        private void mniTripsPrintReportTripsListUnDelivery_Click(object sender, EventArgs e)
        {
            Trip_TripsListUnDelivery();
        }

        private void mniReportTripsListAllReturns_Click(object sender, EventArgs e)
        {
            Trip_TripsListAllReturns();
        }

		private void mniReportCarsDayList_Click(object sender, EventArgs e)
		{
			Trip_CarsDayList();
		}

        private void mniReportShowTripOne_Click(object sender, EventArgs e)
        {
            Trip_ShowTripOnMap(true);
        }

        private void mniReportTripsAllCosts_Click(object sender, EventArgs e)
        {
            Trip_ReportTripsAllCosts();
        }

        private void mniReportShowTripAll_Click(object sender, EventArgs e)
        {
            Trip_ShowTripOnMap(false);
        }

        #endregion trips print 

		#region trips service

		private void mniTripsServiceSetReadyForWMS_Click(object sender, EventArgs e)
		{
			TripsSetReadyForWMS(true);
		}

		private void mniTripsServiceClearReadyForWMS_Click(object sender, EventArgs e)
		{
			TripsSetReadyForWMS(false);
		}

		private void mniTripsServiceByOrder_Click(object sender, EventArgs e)
		{
			TripsByOrder();
		}

		private void mniTripsServiceSetDateTimeBeg_Click(object sender, EventArgs e)
		{
			TripsSetDateTime("Beg", "Fact");
		}

		private void mniTripsServiceSetDateTimeEnd_Click(object sender, EventArgs e)
		{
			TripsSetDateTime("End", "Fact");
		}

		private void mniTripsServiceClearDateTimeBeg_Click(object sender, EventArgs e)
		{
			TripsClearDateTime("Beg", "Fact");
		}

		private void mniTripsServiceClearDateTimeEnd_Click(object sender, EventArgs e)
		{
			TripsClearDateTime("End", "Fact");
		}

		private void mniTripsServiceZeroConfirm_Click(object sender, EventArgs e)
		{
			TripsZeroConfirm();
		}

		private void mniTripsServiceUnConfirm_Click(object sender, EventArgs e)
		{
			TripsUnConfirm();
		}

		private void mniTripsServiceCreatePass_Click(object sender, EventArgs e)
		{
			CreatePass();
		}

		private void mniTripsServiceCreateAct_Click(object sender, EventArgs e)
		{
			CreateAct();
		}

		private void mniTripsServiceOutputCarryUnDo_Click(object sender, EventArgs e)
		{
			OutputCarryUnDo();
		}

		private void mniTripsServiceOutputCarryCopyUnDo_Click(object sender, EventArgs e)
		{
			OutputCarryCopyUnDo();
		}

		private void mniTripsServiceOutputDocumentCarryCopyUnDo_Click(object sender, EventArgs e)
		{
			OutputDocumentCarryCopyUnDo();
		}

		private void mniTripsServiceOutputsDocumentsFactTime_Click(object sender, EventArgs e)
		{
			Trips_OutputsDocumentsFactTime();
		}

		private void mniTripsCostEdit_Click(object sender, EventArgs e)
		{
			TripsCostEdit();
		}

        private void mniTripsCostAmountEdit_Click(object sender, EventArgs e)
        {
            TripsCostAmountEdit();
        }

        private void mniTripsFarthestZoneEdit_Click(object sender, EventArgs e)
        {
            TripsFarthestZoneEdit();
        }
        
        private void mniTripsServiceLogistic_Click(object sender, EventArgs e)
		{
			TripsLogistics();
		}

        private void mniTripsServiceGuiltyEmployees_Click(object sender, EventArgs e)
        {
            SetGuiltyEmployees();
        }

        #endregion trips service

	#endregion MenuStrip

	#region Menu Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}
				
			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index) )
				return;

			//CreateShortCut(btnPrint, "TripsPrint");
			//btnPrint.ContextMenuStrip.Show(btnPrint, new Point(btnPrint.Width / 2, btnPrint.Height / 2), ToolStripDropDownDirection.Default);
			btnPrint.ShortCutShow();
		}

		private void TripBill(bool bAll, string sMode)
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			Trip oTripPrint = new Trip();
			TripPrepareIDList(oTripPrint, bAll, grd);

			ActiveReport3 rep = new ActiveReport3();
			if (sMode.ToUpper().Contains("SHORT"))
				rep = new TripBillShort();
			else
				rep = new TripBill();

			LogService.TripBill_Print(oTripPrint, rep, this);
		}

		private void TripWayBill(bool bAll, string sMode)
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			Trip oTripPrint = new Trip();
			TripPrepareIDList(oTripPrint, bAll, grd);

			string sTemplate = "TripWayBillStd";

			ActiveReport3 rep = new ActiveReport3();
			PrintForm oPrintForm = new PrintForm();
			oPrintForm.FilterPF_Name = sTemplate;
			oPrintForm.FillData();
			if (oPrintForm.ErrorNumber != 0)
				return;
			if (oPrintForm.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("�� ������ ������ �������� ����� \"" + sTemplate + "\"...");
				return;
			}

			string sFilter = oPrintForm.MainTable.Rows[0]["Note"].ToString().Trim();
			string sXMLTemplateText = oPrintForm.MainTable.Rows[0]["PF_XMLTemplateText"].ToString().Trim();

			if (LogService.XMLTemplateTextToFile(sXMLTemplateText, sTemplate, rep))
			{
				//rep = new TripWayListStd(); 
				LogService.TripWayBill_Print(oTripPrint, rep, sFilter, this);
			}
		}

		private void TripPrintDocuments(bool bAll)
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			Trip oTripPrint = new Trip();
			TripPrepareIDList(oTripPrint, bAll, grd);
			if (bAll && (oTripPrint.IDList == null || oTripPrint.IDList.Length == 0))
			{
				RFMMessage.MessageBoxError("�� �������� �����...");
				return; 
			}

			RFMCursorWait.Set(false);

			if (StartForm(new frmTripsPrintDocuments(oTripPrint)) == DialogResult.Yes)
			{
				if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		private void TripPrintDocuments_OneOutputDocument()
		{
			RFMDataGridView grd = null;
			RFMDataGridView grdOne = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTSDOCUMENTS"))
				{
					grdOne = grdTrips_OutputsDocuments;
				}
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTSDOCUMENTS"))
				{
					grdOne = grdOthers_OutputsDocuments;
				}
			}

			if (grd == null || grdOne == null)
				return;

			if (grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			if (grdOne.DataSource == null ||
				grdOne.Rows.Count == 0 ||
				grdOne.CurrentRow == null ||
				grdOne.IsStatusRow(grdOne.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			DataRow rTrip = ((DataRowView)((DataGridViewRow)grd.CurrentRow).DataBoundItem).Row; 
			Trip oTripPrint = new Trip();
			oTripPrint.ReFillOne((int)rTrip["ID"]);

			DataRow rOutputDocument = ((DataRowView)((DataGridViewRow)grdOne.CurrentRow).DataBoundItem).Row;
			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.ReFillOne((int)rOutputDocument["ID"]);

			RFMCursorWait.Set(false);

			if (StartForm(new frmTripsPrintDocuments(oTripPrint, oOutputDocumentPrint )) == DialogResult.Yes)
			{
				if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		private void TripPrintDocuments_OneInput()
		{
			RFMDataGridView grd = null;
			RFMDataGridView grdOne = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("INPUTS") &&
					!tcTripsGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
				{
					grdOne = grdTrips_Inputs;
				}
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("INPUTS") &&
					!tcOthersGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
				{
					grdOne = grdOthers_Inputs;
				}
			}

			if (grd == null || grdOne == null)
				return;

			if (grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			if (grdOne.DataSource == null ||
				grdOne.Rows.Count == 0 ||
				grdOne.CurrentRow == null ||
				grdOne.IsStatusRow(grdOne.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			DataRow rTrip = ((DataRowView)((DataGridViewRow)grd.CurrentRow).DataBoundItem).Row;
			Trip oTripPrint = new Trip();
			oTripPrint.ReFillOne((int)rTrip["ID"]);

			DataRow rInput = ((DataRowView)((DataGridViewRow)grdOne.CurrentRow).DataBoundItem).Row;
			Input oInputPrint = new Input();
			oInputPrint.ReFillOne((int)rInput["ID"]);

			RFMCursorWait.Set(false);

			if (StartForm(new frmTripsPrintDocuments(oTripPrint, oInputPrint)) == DialogResult.Yes)
			{
				if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		private void Trip_OutputsDocumentsVeterinaryBlank(bool bGroupByPartner)
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			int nTripID = 0;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				nTripID = (int)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				nTripID = (int)grdOthers.CurrentRow.Cells["grcOthers_ID"].Value;
			}

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.FilterTripsList = nTripID.ToString();
			oOutputDocumentPrint.FillData();
			if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ ��������� ���������� � �����...");
				return;
			}
			if (oOutputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ��������� ���������� � �����...");
				return;
			}

			string sIDList = "";
			foreach(DataRow r in oOutputDocumentPrint.MainTable.Rows)
			{
				sIDList += r["ID"].ToString() + ","; 
			}
			oOutputDocumentPrint.IDList = sIDList;

			LogService.OutputDocumentVeterinaryBlank_Print(oOutputDocumentPrint, bGroupByPartner, this);
		}

		private void Trip_InputsBill()
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			int nTripID = 0;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				nTripID = (int)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				nTripID = (int)grdOthers.CurrentRow.Cells["grcOthers_ID"].Value;
			}

			RFMCursorWait.Set(true);

			Input oInputPrint = new Input();
			oInputPrint.FilterTripsList = nTripID.ToString();
			oInputPrint.FillData();
			if (oInputPrint.ErrorNumber != 0 || oInputPrint.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("������ ��� ��������� ������ ������� �� ������ � �����...");
				return;
			}
			if (oInputPrint.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("��� ������� �� ������ � �����...");
				return;
			}

			string sIDList = "";
			foreach (DataRow r in oInputPrint.MainTable.Rows)
			{
				sIDList += r["ID"].ToString() + ",";
			}

			oInputPrint.IDList = sIDList;

			RFMCursorWait.Set(false);

			//LogService.InputBill_Print(oInputPrint, this);
			LogService.InputBillWithAct_Print(oInputPrint, this);
		}

		private void Trip_Qualities()
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			int nTripID = 0;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				nTripID = (int)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				nTripID = (int)grdOthers.CurrentRow.Cells["grcOthers_ID"].Value;
			}

			RFMCursorWait.Set(true);

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.FilterTripsList = nTripID.ToString();
			oOutputDocumentPrint.FillData();
			if (oOutputDocumentPrint.ErrorNumber != 0 || oOutputDocumentPrint.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("������ ��� ��������� ������ ��������� ���������� � �����...");
				return;
			}
			if (oOutputDocumentPrint.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("��� ��������� ���������� � �����...");
				return;
			}

			string sIDList = "";
			foreach (DataRow r in oOutputDocumentPrint.MainTable.Rows)
			{
				sIDList += r["ID"].ToString() + ",";
			}

			oOutputDocumentPrint.IDList = sIDList;

			RFMCursorWait.Set(false);

			LogService.OutputDocumentQuality_Print(oOutputDocumentPrint, this);
		}

        #region Print VeterinaryBlankData NEW

		private void VeterinaryBlankData()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			/*
			OutputDocument oOutputDocumentVeterinaryBlank = new OutputDocument();
			oOutputDocumentVeterinaryBlank.FilterTripsList = nTripID.ToString();
			oOutputDocumentVeterinaryBlank.FillData();
			if (oOutputDocumentVeterinaryBlank.ErrorNumber != 0 ||
				oOutputDocumentVeterinaryBlank.MainTable == null)
				return;
			if (oOutputDocumentVeterinaryBlank.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ��������� ���������� � �����...");
				return;
			}
			string sOutputsDocumentsList = "";
			foreach (DataRow dr in oOutputDocumentVeterinaryBlank.MainTable.Rows)
			{
				if ((bool)dr["VeterinaryLicenceNeed"])
				{
					sOutputsDocumentsList += dr["ID"].ToString().Trim() + ",";
				}
			}
			*/

			Trip oTripPrint = new Trip();
			oTripPrint.ID = nTripID;
			oTripPrint.FillTableOutputsDocumentsInTrip();
			if (oTripPrint.ErrorNumber != 0 || oTripPrint.TableOutputsDocumentsInTrip == null)
				return;
			if (oTripPrint.TableOutputsDocumentsInTrip.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("��� ������ � ��������� ���������� � �����...");
				return;
			}

			string sOutputsDocumentsList = "";
			foreach (DataRow dr in oTripPrint.TableOutputsDocumentsInTrip.Rows)
			{
				if ((bool)dr["VeterinaryLicenceNeed"])
				{
					sOutputsDocumentsList += dr["ID"].ToString().Trim() + ",";
				}
			}
			if (sOutputsDocumentsList == null || sOutputsDocumentsList.Length == 0)
			{
				RFMMessage.MessageBoxInfo("��� ������ � ��������� ����������, ��������� ���������� ������������ ������������...");
				return;
			}

			if (StartForm(new frmOutputsDocumentsVeterinaryBlankData(sOutputsDocumentsList)) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

		#endregion Print VeterinaryBlankData NEW

		#region Print TTNData

		private void Trip_TTNData()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripPrint = new Trip();
			oTripPrint.ID = nTripID;
			oTripPrint.FillTableOutputsDocumentsInTrip();
			if (oTripPrint.ErrorNumber != 0 || oTripPrint.TableOutputsDocumentsInTrip == null)
				return;
			if (oTripPrint.TableOutputsDocumentsInTrip.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("��� ������ � ��������� ���������� � �����...");
				return;
			}

			string sOutputsDocumentsList = "";
			foreach (DataRow dr in oTripPrint.TableOutputsDocumentsInTrip.Rows)
			{
				sOutputsDocumentsList += dr["ID"].ToString().Trim() + ",";
			}
			if (sOutputsDocumentsList == null || sOutputsDocumentsList.Length == 0)
				return;

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			oOutputDocumentPrint.IDList = sOutputsDocumentsList;

			StartForm(new frmOutputsDocumentsTTNData(oOutputDocumentPrint));
		}

		private void Trip_OutputTTNData()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripPrint = new Trip();
			oTripPrint.ID = nTripID;
			oTripPrint.FillTableOutputsInTrip();
			if (oTripPrint.ErrorNumber != 0 || oTripPrint.TableOutputsInTrip == null)
				return;
			if (oTripPrint.TableOutputsInTrip.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("��� ������ � �������� � �����...");
				return;
			}

			// ������ � ����������, ��������� � ��� ����������
			Output oOutputTemp = new Output(); 
			OutputDocument oOutputDocumentTemp = new OutputDocument();
			string sOutputsList = "";
			foreach (DataRow o in oTripPrint.TableOutputsInTrip.Rows)
			{
				oOutputTemp.ReFillOne((int)o["ID"]);
				if (oOutputTemp.OwnerID.HasValue && oOutputTemp.PartnerID.HasValue)
				{
					oOutputDocumentTemp.FilterOutputsList = o["ID"].ToString();
					oOutputDocumentTemp.FillData();
					if (oOutputDocumentTemp.ErrorNumber != 0 || oOutputDocumentTemp.MainTable == null)
					{
						RFMMessage.MessageBoxError("������ ��� �������� ������� ��������� ���������� ��� ��������...");
						return;
					}
					if (oOutputDocumentTemp.MainTable.Rows.Count == 0)
					{
						sOutputsList += o["ID"].ToString().Trim() + ",";
					}
				}
			}
			if (sOutputsList == null || sOutputsList.Length == 0)
			{
				RFMMessage.MessageBoxError("� ����� ��� ��������, �� ������� ����������...");
				return;
			}

			Output oOutputPrint = new Output();
			oOutputPrint.IDList = sOutputsList;

			StartForm(new frmOutputsDocumentsTTNData(oOutputPrint));
		}

		#endregion Print TTNData

		#region Print GoodsGroupsListData

		private void Trip_GoodsGroupsList()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			int nOutputDocumentID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				if (LastGrid.Name.ToUpper().Contains("OUTPUTSDOCUMENTS") &&
						grdTrips_OutputsDocuments.Rows.Count > 0 && 
						grdTrips_OutputsDocuments.CurrentRow != null &&
						!grdTrips_OutputsDocuments.IsStatusRow(grdTrips_OutputsDocuments.CurrentRow.Index) )
					nOutputDocumentID = Convert.ToInt32(grdTrips_OutputsDocuments.CurrentRow.Cells["grcTrips_OutputsDocuments_ID"].Value);
				else
					nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (LastGrid.Name.ToUpper().Contains("OUTPUTSDOCUMENTS") &&
						grdOthers_OutputsDocuments.Rows.Count > 0 &&
						grdOthers_OutputsDocuments.CurrentRow != null &&
						!grdOthers_OutputsDocuments.IsStatusRow(grdOthers_OutputsDocuments.CurrentRow.Index))
					nOutputDocumentID = Convert.ToInt32(grdOthers_OutputsDocuments.CurrentRow.Cells["grcOthers_OutputsDocuments_ID"].Value);
				else
					nTripID = (int)oOtherCur.ID;
			}

			OutputDocument oOutputDocumentPrint = new OutputDocument();
			if (nTripID > 0)
			{
				Trip oTripPrint = new Trip();
				oTripPrint.ID = nTripID;
				oTripPrint.FillTableOutputsDocumentsInTrip();
				if (oTripPrint.ErrorNumber != 0 || oTripPrint.TableOutputsDocumentsInTrip == null)
					return;
				if (oTripPrint.TableOutputsDocumentsInTrip.Rows.Count == 0)
				{
					RFMMessage.MessageBoxInfo("��� ������ � ��������� ���������� � �����...");
					return;
				}

				string sOutputsDocumentsList = "";
				foreach (DataRow dr in oTripPrint.TableOutputsDocumentsInTrip.Rows)
				{
					sOutputsDocumentsList += dr["ID"].ToString().Trim() + ",";
				}
				if (sOutputsDocumentsList == null || sOutputsDocumentsList.Length == 0)
					return;

				oOutputDocumentPrint.IDList = sOutputsDocumentsList;
			}
			else
			{
				if (nOutputDocumentID > 0)
				{
					oOutputDocumentPrint.ID = nOutputDocumentID;
				}
			}

			LogService.OutputDocumentGoodsGroupsList_Print(oOutputDocumentPrint, this);
		}

		#endregion Print GoodsGroupsListData

		private void Trip_PutsBalances()
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			RFMCursorWait.Set(true);

			int nTripID = 0;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				nTripID = (int)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				nTripID = (int)grdOthers.CurrentRow.Cells["grcOthers_ID"].Value;
			}

			Trip oTripPrint = new Trip();
			oTripPrint.ReFillOne(nTripID);
			RFMCursorWait.Set(true);

			if (!oTripPrint.ReadyForTripEnd.HasValue || !(bool)oTripPrint.ReadyForTripEnd)
			{
				RFMMessage.MessageBoxAttention("���� �� ����� � ���������...");
			}
			LogService.TripsPutsBalances_Print(oTripPrint, this, true);
		}

		private void Trip_TripsList()
        {
            RFMDataGridView grd = null;
            if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
            {
                grd = grdTrips;
            }
            if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
            {
                grd = grdOthers;
            }

            if (grd == null ||
                grd.DataSource == null ||
                grd.Rows.Count == 0)
                return;

            RFMCursorWait.Set(true);

            string sTripsList = "";
            foreach(DataGridViewRow t in grd.Rows)
            {
                if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
                {
                    sTripsList += t.Cells["grcTrips_ID"].Value.ToString() + ",";
                }
                if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
                {
                    sTripsList += t.Cells["grcOthers_ID"].Value.ToString() + ",";
                }
            }
            sTripsList = sTripsList.Replace(",,", ",");

            Trip oTripPrint = new Trip();
            oTripPrint.IDList = sTripsList;

            LogService.TripsList_Print(oTripPrint, this);
        }

		private void Trip_TripsListNotes()
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0)
				return;

			RFMCursorWait.Set(true);

			string sTripsList = "";
			foreach (DataGridViewRow t in grd.Rows)
			{
				if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				{
					sTripsList += t.Cells["grcTrips_ID"].Value.ToString() + ",";
				}
				if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
				{
					sTripsList += t.Cells["grcOthers_ID"].Value.ToString() + ",";
				}
			}
			sTripsList = sTripsList.Replace(",,", ",");

			Trip oTripPrint = new Trip();
			oTripPrint.IDList = sTripsList;

			LogService.TripsListNotes_Print(oTripPrint, this);
		}

		private void Trip_TripBalance()
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0)
				return;

			RFMCursorWait.Set(true);

			string sTripsList = "";
			int nTripID = 0;
			Trip oTripTemp = new Trip();
			foreach (DataGridViewRow t in grd.Rows)
			{
				nTripID = 0; 
				if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				{
					if (!Convert.IsDBNull(t.Cells["grcTrips_ID"].Value) && t.Cells["grcTrips_ID"].Value != null)
					{
						nTripID = Convert.ToInt32(t.Cells["grcTrips_ID"].Value);
					}
				}
				if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
				{
					if (!Convert.IsDBNull(t.Cells["grcOthers_ID"].Value) && t.Cells["grcOthers_ID"].Value != null)
					{
						nTripID = Convert.ToInt32(t.Cells["grcOthers_ID"].Value);
					}
				}
				if (nTripID != 0)
				{
					oTripTemp.ReFillOne(nTripID);
					if (oTripTemp.ReadyForTripEnd.HasValue && (bool)oTripTemp.ReadyForTripEnd)
					{
						sTripsList += nTripID.ToString() + ",";
					}
				}
			}
			if (sTripsList.Length == 0)
			{
				RFMMessage.MessageBoxInfo("��� �������������� ��� ������� � ��������� ������...");
				return; 
			}

			Report oReport = new Report();
			oReport.Report_TripBalance(sTripsList);
			if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
			{
				if (oReport.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxInfo("��� ������...");
				}
				else
				{
					StartForm(new frmActiveReport(oReport.MainTable, new TripBalance()));
				}
			}
		}

        private void Trip_TripsListUnDelivery()
        {
            RFMDataGridView grd = null;
            if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
            {
                grd = grdTrips;
            }

            if (grd == null ||
                grd.DataSource == null ||
                grd.Rows.Count == 0)
                return;

            RFMCursorWait.Set(true);

            string sTripsList = "";
            foreach (DataGridViewRow t in grd.Rows)
            {
                sTripsList += t.Cells["grcTrips_ID"].Value.ToString() + ",";
            }
            sTripsList = sTripsList.Replace(",,", ",");

            Report oReport = new Report();
            oReport.Report_TripsListUnDelivery(sTripsList, null);
            if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
            {
                if (oReport.MainTable.Rows.Count == 0)
                {
                    RFMMessage.MessageBoxInfo("��� ������...");
                }
                else
                {
                    StartForm(new frmActiveReport(oReport.MainTable, new TripsListUnDelivery()));
                }
            }
        }

        private void Trip_TripsListAllReturns()
        {
            RFMDataGridView grd = null;
            if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
            {
                grd = grdTrips;
            }

            if (grd == null ||
                grd.DataSource == null ||
                grd.Rows.Count == 0)
                return;

            RFMCursorWait.Set(true);

            string sTripsList = "";
            foreach (DataGridViewRow t in grd.Rows)
            {
                sTripsList += t.Cells["grcTrips_ID"].Value.ToString() + ",";
            }
            sTripsList = sTripsList.Replace(",,", ",");

            Report oReport = new Report();
            oReport.Report_TripsListAllReturns(sTripsList, null);
            if (oReport.ErrorNumber == 0 && oReport.MainTable != null)
            {
                if (oReport.MainTable.Rows.Count == 0)
                {
                    RFMMessage.MessageBoxInfo("��� ������...");
                }
                else
                {
                    StartForm(new frmActiveReport(oReport.MainTable, new TripsListAllReturns()));
                }
            }
        }

		private void Trip_CarsDayList()
        {
			DateTime dDate = DateTime.Now.Date;
			if (StartForm(new frmInputBoxDate("����:", dDate)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
				{
					dDate = Convert.ToDateTime(GotParam[0]);
				}
			}
			else
				return;

			Refresh();

			RFMCursorWait.Set(true);

			Trip oTripTemp = new Trip();
			oTripTemp.FilterDateBeg =
			oTripTemp.FilterDateEnd =
				dDate;
			oTripTemp.FilterIsRentCar = false;
			oTripTemp.FillData();
			if (oTripTemp.ErrorNumber != 0 || oTripTemp.MainTable == null)
				return;
			if (oTripTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ �� ����...");
				return;
			}

			DataTable dt = CopyTable(oTripTemp.MainTable, "dt", "", "IsPostern, CarName");
			dt.Columns.Add("IsPosternText");
			foreach (DataRow r in dt.Rows)
			{
				r["IsPosternText"] = ((bool)r["IsPostern"]) ? "��" : "���";
			}
			DataTable dtCars = new DataView(dt, "", "IsPostern, CarName", DataViewRowState.CurrentRows).
				ToTable("dtCars", true, "DateTrip", "CarName", "CarNumber", "Tonnage", "IsPosternText");
				//ToTable("dtCars", true, "DateTrip", "Alias", "CarID", "CarName", "CarNumber", "Tonnage", "IsPosternText", "DriverName");

			RFMCursorWait.Set(false);

			StartForm(new frmActiveReport(dtCars, new CarsDayList()));
        }

        private void Trip_ShowTripOnMap(bool IsOneRoute)
        {
            if (grdTrips.Rows.Count == 0 ||
                !oTripCur.ID.HasValue ||
                (grdTrips.CurrentRow != null && grdTrips.IsStatusRow(grdTrips.CurrentRow.Index)))
                return;

            // ������������ ������ ������
            string sTripsList = "";
            if (IsOneRoute)
            {
                sTripsList = oTripCur.ID.ToString();
            }
            else
            {
                foreach (DataGridViewRow t in grdTrips.Rows)
                {
                    sTripsList += t.Cells["grcTrips_ID"].Value.ToString() + ",";
                }
                sTripsList = sTripsList.Replace(",,", ",");
            }

            // ��������� ���������
            if (!oTripCur.FillTableGeoData(sTripsList)) return;

            frmShowMap frmShowMap = new frmShowMap(oTripCur.TableGeoData, IsOneRoute);
            if (frmShowMap != null) StartForm(frmShowMap);
        }

        private void Trip_ReportTripsAllCosts()
        {
            if ((dtrDates.dtpBegDate.IsEmpty) || (dtrDates.dtpEndDate.IsEmpty)) {
                RFMMessage.MessageBoxAttention("�� ����� �������� ���!");
                return;
            }

            if (oTripList.FillTableTripsAllCosts(dtrDates.dtpBegDate.Value.Date, dtrDates.dtpEndDate.Value.Date))
            {
                StartForm(new frmSelectID(this, oTripList.TableTripsAllCosts,
                    "OwnerName,DateTrip,DocNumbers,PartnerName,ZoneName," +
                        "DriverName,CarNumber,Brutto," +
                        "UnitsQnt,UnitAlias,Price,TaskAmount," +
                        "CarrierName,TaskInnerCost,TaskOuterCost," +
                        "Note,PalletsQnt,TripID,JobID,JobType," + 
                        "Netto,DateConfirm,IsCash,OurCar",
                    "��������,���� �����,�� ����������,������,����," +
                        "��������,� �/�,������," +
                        "UnitsQnt,UnitAlias,Price,TaskAmount," +
                        "����������,TaskInnerCost,TaskOuterCost," +
                        "����������,���-�� ������,� �����,� �������,��� �������," + 
                        "�����,���� �����.,IsCash,����",
                    "����������� ������ �� ���� �������� � ������"));
            }
        }

        #endregion

        #region Menu Service

        private void btnService_Click(object sender, EventArgs e)
		{
			RFMDataGridView grd = null;
			if (tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
			{
				grd = grdTrips;
			}
			if (tcList.CurrentPage.Name.ToUpper().Contains("OTHERS"))
			{
				grd = grdOthers;
			}

			if (grd == null ||
				grd.DataSource == null ||
				grd.Rows.Count == 0 ||
				grd.CurrentRow == null ||
				grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			//CreateShortCut(btnService, "TripsService");
			//btnService.ContextMenuStrip.Show(btnService, new Point(btnService.Width / 2, btnService.Height / 2), ToolStripDropDownDirection.Default);
			btnService.ShortCutShow();
		}

		#region Zero Confirm

		private void TripsZeroConfirm()
		{
			// ������������� "�������" ����� (�� �������� ���������� ��� ������)

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripConfirm = new Trip();
			oTripConfirm.ReFillOne(nTripID);

			// ��������
			if (oTripConfirm.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������...");
				return;
			}

			if (oTripConfirm.IsInputsAttached || oTripConfirm.IsOutputsAttached)
			{
				RFMMessage.MessageBoxError("� ����� ��������� ��������� �������...\n" + 
					"������������� ����� ����������� ����������� �������...");
				return;
			}

			if (oTripConfirm.IsTripsReturnsAttached && !oTripConfirm.IsTripsReturnsConfirmed)
			{
				RFMMessage.MessageBoxError("��� ����� ���������� ���������������� �������-�������...");
				return;
			}

			if (oTripConfirm.IsActsAttached && !oTripConfirm.IsActsConfirmed)
			{
				RFMMessage.MessageBoxError("��� ����� ���������� ���������������� ���...");
				return;
			}

			if (!oTripConfirm.DepartureTime.HasValue)
			{
				if (RFMMessage.MessageBoxYesNo("�� �������� ����� ������ ������...\n\n" + 
					"���-���� ����������� ����?") != DialogResult.Yes)
					return;
			}
			if (!oTripConfirm.ArrivalTime.HasValue)
			{
				if (RFMMessage.MessageBoxYesNo("�� �������� ����� ����������� ������...\n\n" +
					"���-���� ����������� ����?") != DialogResult.Yes)
					return;
			}
			/*
            if (!oTripConfirm.DateBeg.HasValue)
            {
                RFMMessage.MessageBoxError("���� ��� �� �����...");
                return;
            }
            if (!oTripConfirm.DateEnd.HasValue)
            {
                RFMMessage.MessageBoxError("���� ��� �� �������...");
                return;
            }
			*/

			if (RFMMessage.MessageBoxYesNo("����������� ���� (������� �� ������ � �� ������ �����������)?") == DialogResult.Yes)
			{
				if (oTripConfirm.Confirm(true, ((RFMFormMain)Application.OpenForms[0]).UserID))
				{
					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		#endregion Zero Confirm


		#region UnConfirm

		private void TripsUnConfirm()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripUnConfirm = new Trip();
			oTripUnConfirm.ReFillOne(nTripID);

			// ��������
			if (!oTripUnConfirm.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� �� �����������...");
				return;
			}
			// 

			if (RFMMessage.MessageBoxYesNo("����� ������� � ������������� �����?") == DialogResult.Yes)
			{
				Refresh();
				WaitOn(this);
				bool bResult = oTripUnConfirm.UnConfirmOne((int)((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oTripUnConfirm.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("������� � ������������� ����� �����.");
				}

				if (sPageName.Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (sPageName.Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		#endregion UnConfirm

		#region Service Set/Clear Dates, Sets

		#region DateTime...

		private void TripsSetDateTime(string sMode, string sPlanFact)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			sMode = sMode.ToUpper();
			sPlanFact = sPlanFact.ToUpper();
			if (!sMode.Contains("BEG") && !sMode.Contains("END"))
				return;
			if (!sPlanFact.Contains("PLAN") && !sPlanFact.Contains("FACT"))
				return;

			DateTime dtDateTime = DateTime.Now;
			string sText = "���� � ����� ";

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripSet = new Trip();
			oTripSet.ReFillOne(nTripID);

			// ������ (�����) 
			if (sMode.Contains("BEG"))
			{
				if (oTripSet.DateEnd.HasValue)
				{
					if (RFMMessage.MessageBoxYesNo("���� ��� �������...\n" +
						"���-���� �������� ����� ������ �����?") != DialogResult.Yes)
						return;
				}
				sText += "������";
			}

			// ��������
			if (sMode.Contains("END"))
			{
				if (!oTripSet.DateBeg.HasValue)
				{
					if (RFMMessage.MessageBoxYesNo(TRIP_NOT_BEG + "...\n" +
						"���-���� �������� ����� ��������� �����?") != DialogResult.Yes)
						return;
				}
				sText += "���������";
			}

			sText += " �����:";

			if (StartForm(new frmInputBoxDateTime(sText, dtDateTime)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
				{
					dtDateTime = Convert.ToDateTime(GotParam[0]);

					bool lResult = oTripSet.SetDateTime(nTripID, sMode, sPlanFact, dtDateTime, null);
					if (lResult && oTripSet.ErrorNumber == 0)
					{
						if (sPageName.Contains("TRIPS"))
						{
							grdTrips_Restore();
						}
						if (sPageName.Contains("OTHERS"))
						{
							grdOthers_Restore();
						}
					}
				}
			}
		}

		private void TripsClearDateTime(string sMode, string sPlanFact)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			sMode = sMode.ToUpper();
			sPlanFact = sPlanFact.ToUpper();
			if (!sMode.Contains("BEG") && !sMode.Contains("END"))
				return;
			if (!sPlanFact.Contains("PLAN") && !sPlanFact.Contains("FACT"))
				return;

			string sText = "�������� ����� ";

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			Trip oTripClear = new Trip();
			oTripClear.ReFillOne(nTripID);

			// ������
			if (sMode.Contains("BEG"))
			{
				if (oTripClear.DateEnd.HasValue)
				{
					if (RFMMessage.MessageBoxYesNo("���� ��� �������...\n" +
						"���-���� �������� ����� ������ �����?") != DialogResult.Yes)
						return;
				}
				sText += "������";
			}

			// ��������� (��������)
			if (sMode.Contains("END"))
			{
				if (oTripClear.DateBeg.HasValue)
				{
					/*
					if (RFMMessage.MessageBoxYesNo("��� �� ������������� ����� ������ �����...\n" +
						"���-���� �������� ����� �������� ������?") != DialogResult.Yes)
						return;
					*/ 
				}
				sText += "���������";
			}

			sText += " �����:";

			if (RFMMessage.MessageBoxYesNo(sText) == DialogResult.Yes)
			{
				bool lResult = oTripClear.SetDateTime(nTripID, sMode, sPlanFact, null, ((RFMFormMain)Application.OpenForms[0]).UserID);
				if (lResult && oTripClear.ErrorNumber == 0)
				{
					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		#endregion DateTime...

		#region ReadyForWMS

		private void TripsSetReadyForWMS(bool bSet)
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			RFMCursorWait.Set(true);

			bool bAll = false;
			Trip oTripSet = new Trip();
			if (sPageName.Contains("TRIPS"))
			{
				bAll = (grdTrips.IsCheckerInclude && grdTrips.IsCheckerShow && grdTrips.MarkedCount > 0);
				TripPrepareIDList(oTripSet, bAll, grdTrips);
			}
			if (sPageName.Contains("OTHERS"))
			{
				bAll = (grdOthers.IsCheckerInclude && grdOthers.IsCheckerShow && grdOthers.MarkedCount > 0);
				TripPrepareIDList(oTripSet, bAll, grdOthers);
			}

			RFMCursorWait.Set(false);

			if (bAll && (oTripSet.IDList == null || oTripSet.IDList.Length == 0))
			{
				RFMMessage.MessageBoxError("�� �������� �����...");
				return;
			}
			oTripSet.FillData();
			if (oTripSet.ErrorNumber != 0 || oTripSet.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ ������...");
				return;
			}
			if (oTripSet.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("�� ������� �����...");
				return;
			}

			if (oTripSet.MainTable.Rows.Count > 1)
			{
				string sText = "";
				if (bSet)
					sText = "���������� ������� \"����� � ��������� �� ������\" ��� ���������� ������ (" + oTripSet.MainTable.Rows.Count.ToString() + "),\n" +
						"��� ���� ������ ������� ����� ���������� ��� ���� ������� � �����?";
				else
					sText = "����� ������� \"����� � ��������� �� ������\" ��� ���������� ������ (" + oTripSet.MainTable.Rows.Count.ToString() + "),\n" +
						"��� ���� ������ ������� ����� ���� ��� ���� �������������� ������� � �����?";
				if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
					return;
			}

			RFMCursorWait.Set(true);

			bool bOK = false;
			int nTripID = 0;
			foreach (DataRow r in oTripSet.MainTable.Rows)
			{
				nTripID = (int)r["ID"];
				oTripSet.FillOne(r);
				if (bSet)
				{
					// ������ ������� 
					if (!oTripSet.ReadyForWMS)
					{
						if ((bool)r["IsConfirmed"])
						{
							RFMCursorWait.Set(false);
							RFMMessage.MessageBoxError("���� � ����� " + nTripID.ToString() +
								((r["Alias"].ToString().Length > 0) ? (" (" + r["Alias"].ToString() + ")") : "") +
								" ��� �����������...");
							RFMCursorWait.Set(true);
							continue;
						}

						// ����� ������� �������
						oTripSet.SetReadyForWMS(nTripID);
						bOK = true;
					}
				}
				else
				{
					// ������� �������
					if (oTripSet.ReadyForWMS)
					{
						oTripSet.SetReadyForWMS(nTripID, true, null);
						bOK = true;
					}
				}
			}

			RFMCursorWait.Set(false);

			if (bOK)
			{
				if (sPageName.Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (sPageName.Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
		}

		#endregion Set ReadyForWMS

		#endregion Service SetDateTime

		#region Service ByOrder

		private void TripsByOrder()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			bool bSelfDelivery = !sPageName.Contains("TRIPS");
			if (StartForm(new frmTripsTimesReorder(bSelfDelivery)) == DialogResult.Yes)
			{
				if (sPageName.Contains("TRIPS"))
					grdTrips_Restore();
				if (sPageName.Contains("OTHERS"))
					grdOthers_Restore();
			}

			/*
			DateTime dDate = DateTime.Now.Date;
			if (StartForm(new frmInputBoxDate("���� �����:", dDate)) == DialogResult.Yes)
			{
				if (GotParam[0] != null)
					dDate = Convert.ToDateTime(GotParam[0]);
			}

			// ���� ������ ����+������������, ���� ������ ���������� ������
			Trip oTripTemp = new Trip();
			oTripTemp.FilterDateBeg =
			oTripTemp.FilterDateEnd =
				dDate;
			oTripTemp.FilterSelfDelivery = !sPageName.Contains("TRIPS");
			oTripTemp.FillData();
			if (oTripTemp.ErrorNumber != 0 || oTripTemp.MainTable == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ ������ �� ����...");
				return;
			}
			if (oTripTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ �� ����...");
				return;
			}

			DataTable dt = CopyTable(oTripTemp.MainTable, "dt", "", "ByOrder");
			foreach (DataRow drt in dt.Rows)
			{
				if (Convert.IsDBNull(drt["ByOrder"]))
				{
					drt["ByOrder"] = 0;
				}
			}

			if (StartForm(new frmByOrder(dt, "ID,ByOrder,Alias,Note", "ID,� �/�,��������,����������", "ID", false)) == DialogResult.Yes)
			{
				string strInput = GotParam[0].ToString();
				if (strInput != null && strInput.Length > 0)
				{
					// ��������� ������
					int nTripTempID = 0;
					int nByOrder = 0;
					string sNumber = "-", sMiddleNumber = "-";
					string sDelimiter = ";", sMiddleDelimiter = ",";
					sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
					while (sNumber.Length > 0)
					{
						nByOrder++;
						if (sNumber.Contains(sMiddleDelimiter))
						{
							sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
							while (sMiddleNumber.Length > 0)
							{
								try
								{
									nTripTempID = Convert.ToInt32(sMiddleNumber);
								}
								catch
								{
									nTripTempID = 0;
								}
								if (nTripTempID > 0)
								{
									oTripTemp.SaveByOrder(nTripTempID, nByOrder);
								}
								sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
							}
						}
						else
						{
							try
							{
								nTripTempID = Convert.ToInt32(sNumber);
							}
							catch
							{
								nTripTempID = 0;
							}
							if (nTripTempID > 0)
							{
								oTripTemp.SaveByOrder(nTripTempID, nByOrder);
							}
						}
						sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
					}
				}

				if (sPageName.Contains("TRIPS"))
				{
					grdTrips_Restore();
				}
				if (sPageName.Contains("OTHERS"))
				{
					grdOthers_Restore();
				}
			}
			*/
		}

		#endregion Service ByOrder

		#region Service CreatePass

		private void CreatePass()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;
				nTripID = (int)oTripCur.ID;
			}
			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;
				nTripID = (int)oOtherCur.ID;
			}

			LogService.PassCreateForTrip(nTripID);
		}

		#endregion Service CreatePass

		#region Service TripsReturns

		private void CreateNotAutoTripReturn()
		{
			int nActID = 0;

			int? nOutputID = null, nInputID = null;

			if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
			{
				if (grdTrips_Outputs.DataSource == null ||
					grdTrips_Outputs.Rows.Count == 0 ||
					grdTrips_Outputs.CurrentRow == null)
					return;
				nOutputID = (int)grdTrips_Outputs.CurrentRow.Cells["grcTrips_Outputs_ID"].Value;
			}
			if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("INPUTS"))
			{
				if (grdTrips_Inputs.DataSource == null ||
					grdTrips_Inputs.Rows.Count == 0 ||
					grdTrips_Inputs.CurrentRow == null)
					return;
				nInputID = (int)grdTrips_Inputs.CurrentRow.Cells["grcTrips_Inputs_ID"].Value;
			}
			if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("_PUTS"))
			{
				if (grdTrips_Puts.DataSource == null ||
					grdTrips_Puts.Rows.Count == 0 ||
					grdTrips_Puts.CurrentRow == null)
					return;
				if (grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_TypeImage"].Value.ToString() == "I")
				{
					nInputID = (int)grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_ID"].Value;
				}
				else
				{
					if (grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_TypeImage"].Value.ToString() == "O")
					{
						nOutputID = (int)grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_ID"].Value;
					}
				}
			}

			if (!nInputID.HasValue && !nOutputID.HasValue)
				return;

			if (nOutputID.HasValue)
			{
				Output oOutputAct = new Output();
				oOutputAct.ReFillOne((int)nOutputID);
				if (!oOutputAct.IsConfirmed)
				{
					RFMMessage.MessageBoxAttention("��������� ������� �� ������ �� ������������.\r\n���� ���� ����������...");
					return;
				}
				if (oOutputAct.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("��� ���������� ������� ��� ���������� ���.\n������� ��� ���� ���?") != DialogResult.Yes)
						return;
				}
			}
			if (nInputID.HasValue)
			{
				Input oInputAct = new Input();
				oInputAct.ReFillOne((int)nInputID);
				if (!oInputAct.IsConfirmed)
				{
					RFMMessage.MessageBoxAttention("��������� ������� �� ������ �� ������������.\r\n���� ���� ����������...");
					return;
				}
				if (oInputAct.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("��� ���������� ������� ��� ���������� ���.\n������� ��� ���� ���?") != DialogResult.Yes)
						return;
				}
			}

			if (StartForm(new frmActsEdit(nActID, nInputID, nOutputID)) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

		#endregion Service TripsReturns

		#region Service Acts

		private void CreateAct()
		{
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			int nTripID = 0;
			int nActID = 0;
			int? nOutputID = null, nInputID = null;
			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				nTripID = (int)oTripCur.ID;

				oTripCur.ReFillOne(nTripID);
				if (oTripCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("���� ��� �����������.");
					return;
				}

				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
				{
					if (grdTrips_Outputs.DataSource == null ||
						grdTrips_Outputs.Rows.Count == 0 ||
						grdTrips_Outputs.CurrentRow == null)
						return;
					nOutputID = (int)grdTrips_Outputs.CurrentRow.Cells["grcTrips_Outputs_ID"].Value;
				}
				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("INPUTS"))
				{
					if (grdTrips_Inputs.DataSource == null ||
						grdTrips_Inputs.Rows.Count == 0 ||
						grdTrips_Inputs.CurrentRow == null)
						return;
					nInputID = (int)grdTrips_Inputs.CurrentRow.Cells["grcTrips_Inputs_ID"].Value;
				}
				if (tcTripsGoods.CurrentPage.Name.ToUpper().Contains("_PUTS"))
				{
					if (grdTrips_Puts.DataSource == null ||
						grdTrips_Puts.Rows.Count == 0 ||
						grdTrips_Puts.CurrentRow == null)
						return;
					if (grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_TypeImage"].Value.ToString() == "I")
					{
						nInputID = (int)grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_ID"].Value;
					}
					else
					{
						if (grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_TypeImage"].Value.ToString() == "O")
						{
							nOutputID = (int)grdTrips_Puts.CurrentRow.Cells["grcTrips_Puts_ID"].Value;
						}
					}
				}
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				nTripID = (int)oOtherCur.ID;

				oOtherCur.ReFillOne(nTripID);
				if (oOtherCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("���� ��� �����������.");
					return;
				}

				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS"))
				{
					if (grdOthers_Outputs.DataSource == null ||
						grdOthers_Outputs.Rows.Count == 0 ||
						grdOthers_Outputs.CurrentRow == null)
						return;
					nOutputID = (int)grdOthers_Outputs.CurrentRow.Cells["grcOthers_Outputs_ID"].Value;
				}
				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("INPUTS"))
				{
					if (grdOthers_Inputs.DataSource == null ||
						grdOthers_Inputs.Rows.Count == 0 ||
						grdOthers_Inputs.CurrentRow == null)
						return;
					nInputID = (int)grdOthers_Inputs.CurrentRow.Cells["grcOthers_Inputs_ID"].Value;
				}
				if (tcOthersGoods.CurrentPage.Name.ToUpper().Contains("_PUTS"))
				{
					if (grdOthers_Puts.DataSource == null ||
						grdOthers_Puts.Rows.Count == 0 ||
						grdOthers_Puts.CurrentRow == null)
						return;
					if (grdOthers_Puts.CurrentRow.Cells["grcOthers_Puts_TypeImage"].Value.ToString() == "I")
					{
						nInputID = (int)grdOthers_Puts.CurrentRow.Cells["grcOthers_Puts_ID"].Value;
					}
					else
					{
						if (grdOthers_Puts.CurrentRow.Cells["grcOthers_Puts_TypeImage"].Value.ToString() == "O")
						{
							nOutputID = (int)grdOthers_Puts.CurrentRow.Cells["grcOthers_Puts_ID"].Value;
						}
					}
				}
			}

			if (!nInputID.HasValue && !nOutputID.HasValue)
				return;

			if (nOutputID.HasValue)
			{
				Output oOutputAct = new Output();
				oOutputAct.ReFillOne((int)nOutputID);
				if (!oOutputAct.IsConfirmed)
				{
					RFMMessage.MessageBoxAttention("��������� ������� �� ������ �� ������������.\r\n���� ���� ����������...");
					return;
				}
				if (oOutputAct.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("��� ���������� ������� ��� ���������� ���.\n������� ��� ���� ���?") != DialogResult.Yes)
						return;
				}
			}
			if (nInputID.HasValue)
			{
				Input oInputAct = new Input();
				oInputAct.ReFillOne((int)nInputID);
				if (!oInputAct.IsConfirmed)
				{
					RFMMessage.MessageBoxAttention("��������� ������� �� ������ �� ������������.\r\n���� ���� ����������...");
					return;
				}
				if (oInputAct.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("��� ���������� ������� ��� ���������� ���.\n������� ��� ���� ���?") != DialogResult.Yes)
						return;
				}
			}

			if (StartForm(new frmActsEdit(nActID, nInputID, nOutputID)) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

		#endregion Service Acts

		#region Service Carry/Copy UnDo

		private void OutputCarryUnDo()
		{
			// ������� ������������� ������� ������ � �������� ������� � ���� 

			// ������ � ������, ����� �������� ����������� ������������ �������/�������
			if (!chkShowCarried.Checked)
				return; 

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			RFMDataGridView grd = null;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				if (!tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS") ||
					tcTripsGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
				{
					RFMMessage.MessageBoxInfo("��� ������ �������� ������� ������� ������� �� ������������ ������� � ������ ������� \"�������\"\n" +
						"(����� ����������� ������������ ������� � ���������� ������ ���� �������).");
					return;
				}

				grd = grdTrips_Outputs;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (!tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS") ||
					tcOthersGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
					return; 

				grd = grdOthers_Outputs;
				nTripID = (int)oOtherCur.ID;
			}

			if (grd.Rows.Count == 0)
				return;
			if (grd.CurrentRow == null)
				return;
			if (grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			Trip oTripCarry = new Trip();
			oTripCarry.ReFillOne(nTripID);

			if (oTripCarry.IsConfirmed)
			{
				RFMMessage.MessageBoxError("���� ��� �����������.\n" + 
					"������ �������� ������� �� ������������.");
				return;
			}

			DataRow r = ((DataRowView)grd.CurrentRow.DataBoundItem).Row;

			Output oOutputCarry = new Output(); 
			oOutputCarry.ReFillOne((int)r["ID"]);

			if (oOutputCarry.TripID.HasValue)
			{
				RFMMessage.MessageBoxError("������� �� ������ ��������� � " + (((int)oOutputCarry.TripID == nTripID) ? "��������" : "�������") + " �����.");
				return;
			}

			/*
			// ??? ��������� �� �������� ������� �� ��������� ���������� ??
			OutputDocument oOutputDocumentCarry = new OutputDocument();
			oOutputDocumentCarry.FilterOutputsList = r["ID"].ToString();
			oOutputDocumentCarry.FillData();
			int nOutputsDocumentsQnt = oOutputDocumentCarry.MainTable.Rows.Count; // r["OutputsDocumentsQnt"]
			OutputDocument oOutputDocumentCarryOne = new OutputDocument();
			foreach (DataRow ro in oOutputDocumentCarry.MainTable.Rows)
			{
				oOutputDocumentCarryOne.FillOne(ro);
				if (oOutputDocumentCarryOne.IsBrought)
				{
					string sText = (nOutputsDocumentsQnt > 1)
						? "����� ��������� ����������, �������� � ������ �������, ���� ���������, �� ������� ��� ���������������� �������� ����������."
						: "�� ���������� ���������, ��������� � ������ �������, ��� ���������������� �������� ����������.";
					RFMMessage.MessageBoxError(sText + "\n������ �������� ������� �� ������������.");
					return;
				}
			}
			*/

			if (RFMMessage.MessageBoxYesNo("�������� ������� ������� �� ������ � ���� �������� � ���� ��������� ���������� (" + oOutputCarry.OutputsDocumentsQnt.ToString().Trim() + ") � ��������� �� � �������� �����?") == DialogResult.Yes)
			{
				WaitOn(this);
				bool bResult = oOutputCarry.CarryUnDo((int)oOutputCarry.ID, (int)oTripCarry.ID, ((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oOutputCarry.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("������� ������� �� ������ � ��������� ���������� �������;\n" + 
					//	"������� � ��������� ��������� ����� ��������� � �����.");
					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		private void OutputCarryCopyUnDo()
		{
			// ������ (��������) �������������� ������� ������ � �������� �������

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			RFMDataGridView grd = null;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				if (!tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS") ||
					tcTripsGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
				{
					RFMMessage.MessageBoxInfo("��� ������ ����������� ������� ������� ������� �� �������� �������,\n� �������� ����������� �����������, � ������ ������� \"�������\".");
					return;
				}

				grd = grdTrips_Outputs;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (!tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTS") ||
					tcOthersGoods.CurrentPage.Name.ToUpper().Contains("DOCUMENTS"))
				{
					RFMMessage.MessageBoxInfo("��� ������ ����������� ������� ������� ������� �� �������� �������,\n� �������� ����������� �����������, � ������ ������� \"�������\".");
					return;
				}

				grd = grdOthers_Outputs;
				nTripID = (int)oOtherCur.ID;
			}

			if (grd.Rows.Count == 0)
				return;
			if (grd.CurrentRow == null)
				return;
			if (grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			// ���� �������
			DataRow r = ((DataRowView)grd.CurrentRow.DataBoundItem).Row;
			Output oOutputCarry = new Output();
			oOutputCarry.ReFillOne((int)r["ID"]);
			if (!oOutputCarry.IsCopied)
			{
				RFMMessage.MessageBoxError("������� �� ������ �� ���� �����������.");
				return;
			}

			// ���� ��� ��� �����
			oOutputCarry.FillTableOutputsCarries((int)oOutputCarry.ID);
			if (oOutputCarry.ErrorNumber != 0 ||
				!oOutputCarry.DS.Tables.Contains("TableOutputsCarries") ||
				oOutputCarry.DS.Tables["TableOutputsCarries"] == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������� � ������ �������...");
				return;
			}

			DataTable dtCopies = oOutputCarry.DS.Tables["TableOutputsCarries"];
			if (dtCopies.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ � ��������� � ������ �������...");
				return;
			}

			string sOutputsNewList = "";
			Output oOutputNew = new Output();
			OutputDocument oOutputDocumentNew = new OutputDocument();
			foreach (DataRow oCC in dtCopies.Rows)
			{ 
				// ����������� �� ���?
				if (Convert.ToInt32(oCC["TripID"]) == nTripID && 
					!Convert.IsDBNull(oCC["NewOutputID"]) &&
					Convert.ToInt32(oCC["NewOutputID"]) != Convert.ToInt32(oCC["OutputID"])) 
				{
					oOutputNew.ReFillOne((int)oCC["NewOutputID"]);
					if (oOutputNew.TripExists)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� ������������ � �����...");
						return;
					}
					if (oOutputNew.IsConfirmed)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� ������������...");
						return;
					}
					if (oOutputNew.SentToWMS)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� �������� � ��������� �������...");
						return;
					}
					if (oOutputNew.ReadyForWMS)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� ������ ��� �������� � ��������� �������...");
						return;
					}
					if (oOutputNew.IsCopied)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ����� ���� �����������...");
						return;
					}
					if (oOutputNew.IsCarried) // ???
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ���� ����������...");
						return;
					}

					// ? ��������� ERPCode - ������� �������� � host-�������

					oOutputDocumentNew.FilterOutputsList = oCC["NewOutputID"].ToString();
					oOutputDocumentNew.FillData();
					foreach (DataRow od in oOutputDocumentNew.MainTable.Rows)
					{
						if ((bool)od["IsBrought"])
						{
							RFMMessage.MessageBoxError("��� ���������� ���������, ���������� ��� �����������, ��� ���������������� �������� �������...");
							return;
						}
						// ? ��������� ERPCode - �������� ������� � host-�������
					}

					// ����� ������� - �� ������������ �� � ������ �����, ��� ��������� �� ���������� �������� 
					// ��� ����� �������
					sOutputsNewList += oCC["NewOutputID"].ToString() + ",";  
				}
			}

			if (sOutputsNewList.Length == 0)
			{
				RFMMessage.MessageBoxError("��� ������ � ������ �������...");
				return;
			}

			// ��� ����, � �������� ��������� �������� �������
			Trip oTripCarry = new Trip();
			oTripCarry.ReFillOne(nTripID);
			if (oTripCarry.IsConfirmed)
			{
				if (RFMMessage.MessageBoxYesNo("��������!\n\n����, � �������� ��������� �������� �������, ��� �����������.\n" +
					"���-���� ��������� ������ ����������� ������� � ��������� ����������?") != DialogResult.Yes) 
					return;
			}

			if (RFMMessage.MessageBoxYesNo("�������� ����������� ������� �� ������ � ���� �������� � ���� ��������� ����������\n" + 
				"(��������� ��� ����������� ������� � ��������� ��������� ����� �������,\n" + 
				"�������� ������� �� ����������,\n" +
				"��������� � ��� � host-������� ����� ���������� � �������� ���������)?") == DialogResult.Yes)
			{
				WaitOn(this);
				bool bResult = oOutputCarry.CarryCopyUnDo((int)oOutputCarry.ID, (int)oTripCarry.ID, ((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oOutputCarry.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("����������� ������� �� ������ � ��������� ���������� ��������;\n" + 
					//	"��������� ��� ����������� ������� � ��������� ��������� ������� .");
					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		private void OutputDocumentCarryCopyUnDo()
		{
			// ������ (��������) �������������� ��������� � ����� ������� 
			// (�������� ��� �� �������, ���� �� ��� �� ����)

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (!sPageName.Contains("TRIPS") && !sPageName.Contains("OTHERS"))
				return;

			RFMDataGridView grd = null;

			int nTripID = 0;

			if (sPageName.Contains("TRIPS"))
			{
				if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null ||
					!oTripCur.ID.HasValue)
					return;

				if (!tcTripsGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTSDOCUMENTS"))
				{
					RFMMessage.MessageBoxInfo("��� ������ ����������� ���������� ��������� ������� ������� �� �������� ��������,\n� �������� ����������� �����������, � ������ ������� \"����.���������\".");
					return;
				}

				grd = grdTrips_OutputsDocuments;
				nTripID = (int)oTripCur.ID;
			}

			if (sPageName.Contains("OTHERS"))
			{
				if (grdOthers.Rows.Count == 0 || grdOthers.CurrentRow == null ||
					!oOtherCur.ID.HasValue)
					return;

				if (!tcOthersGoods.CurrentPage.Name.ToUpper().Contains("OUTPUTSDOCUMENTS"))
				{
					RFMMessage.MessageBoxInfo("��� ������ ����������� ���������� ��������� ������� ������� �� �������� ��������,\n� �������� ����������� �����������, � ������ ������� \"����.���������\".");
					return;
				}

				grd = grdOthers_OutputsDocuments;
				nTripID = (int)oOtherCur.ID;
			}

			if (grd.Rows.Count == 0)
				return;
			if (grd.CurrentRow == null)
				return;
			if (grd.IsStatusRow(grd.CurrentRow.Index))
				return;

			// ��� �����
			DataRow r = ((DataRowView)grd.CurrentRow.DataBoundItem).Row;
			OutputDocument oOutputDocumentCarry = new OutputDocument();
			oOutputDocumentCarry.ReFillOne((int)r["ID"]);
			if (!oOutputDocumentCarry.IsCopied)
			{
				RFMMessage.MessageBoxError("��������� �������� �� ��� ����������.");
				return;
			}

			// ���� ��� ��� �����
			oOutputDocumentCarry.FillTableOutputsDocumentsCarries((int)oOutputDocumentCarry.ID);
			if (oOutputDocumentCarry.ErrorNumber != 0 ||
				!oOutputDocumentCarry.DS.Tables.Contains("TableOutputsDocumentsCarries") ||
				oOutputDocumentCarry.DS.Tables["TableOutputsDocumentsCarries"] == null)
			{
				RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������� � ������ ���������� ���������...");
				return;
			}

			DataTable dtCopies = oOutputDocumentCarry.DS.Tables["TableOutputsDocumentsCarries"];
			if (dtCopies.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("��� ������ � ��������� � ������ ���������� ���������...");
				return;
			}

			bool bSingle = true; 

			OutputDocument oOutputDocumentNew = new OutputDocument();
			OutputDocument oOutputDocumentOthers = new OutputDocument();
			Output oOutputNew = new Output();
			foreach (DataRow oCC in dtCopies.Rows)
			{
				// ��-�������� ��� ������ ���� ���� ������, �� �� ������ ������ - ��� ������� �����

				// ����������� �� ���?
				if (Convert.ToInt32(oCC["TripID"]) == nTripID &&
					!Convert.IsDBNull(oCC["NewOutputDocumentID"]) &&
					Convert.ToInt32(oCC["NewOutputDocumentID"]) != Convert.ToInt32(oCC["OutputDocumentID"]))
				{
					oOutputDocumentNew.ReFillOne((int)oCC["NewOutputDocumentID"]);
					if (oOutputDocumentNew.TripExists)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� �������� ��� ����������� � �����...");
						return;
					}
					if (oOutputDocumentNew.IsBrought)
					{
						RFMMessage.MessageBoxError("��� ���������� ��� ����������� ���������� ��������� ��� ���������������� �������� ������ �������...");
						return;
					}
					if (oOutputDocumentNew.IsConfirmed)
					{
						RFMMessage.MessageBoxError("��� ���������� ��� ����������� ���������� ��������� ��� ���������������� ������ ������ �� ������...");
						return;
					}
					if (oOutputDocumentNew.IsCopied)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� �������� ����� ��� ����������...");
						return;
					}
					if (oOutputDocumentNew.IsCarried) // ???
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� �������� ��� ���������...");
						return;
					}

					// ��������� �������
					oOutputNew.ReFillOne((int)oOutputDocumentNew.OutputID);
					if (oOutputNew.TripExists)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� ������������ � �����...");
						return;
					}
					if (oOutputNew.IsConfirmed)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� ������������...");
						return;
					}
					if (oOutputNew.SentToWMS)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� �������� � ��������� �������...");
						return;
					}
					if (oOutputNew.ReadyForWMS)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ��� ������ ��� �������� � ��������� �������...");
						return;
					}
					if (oOutputNew.IsCopied)
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ����� ���� �����������...");
						return;
					}
					if (oOutputNew.IsCarried) // ???
					{
						RFMMessage.MessageBoxError("��������� ��� ����������� ��������� ������� �� ������ ���� ����������...");
						return;
					}

					// ��������� ���������, ������� ������ � ��� �������
					oOutputDocumentOthers.FilterOutputsList = oOutputNew.ID.ToString();
					oOutputDocumentOthers.FillData();
					if (oOutputDocumentOthers.MainTable.Rows.Count == 1)
					{
						// ��� ������������ �������� � �������
						// ����� ��������
					}
					else
					{
						// ������� �������� � ���� ��� ��������� �������
						// � ����� �� ��������� ������ ����� � �.�., - 
						// �� �� ������� �� ��� - �� ������ ���������� ���� ����� �� �������
						// � ���� ���� ����� - ����� ������� ��������� � �������� ����������� ��� ����

						bSingle = false;

						int nOthersCnt = 0;
						int nOthersSamePartnerCnt = 0;
						foreach (DataRow od in oOutputDocumentOthers.MainTable.Rows)
						{
							if ((int)od["ID"] != (int)oOutputDocumentNew.ID)
							{
								nOthersCnt++;
								if ((int)od["PartnerDetailBayerID"] == (int)oOutputDocumentCarry.PartnerDetailBayerID)
									nOthersSamePartnerCnt++;
							}
						}
						string sText = "������� �� ������, � ������� ������ ��������� ��� ����������� �����,\n" +
								"�������� ��� ";
						if (nOthersCnt == nOthersSamePartnerCnt)
						{
							// ��� ��������� ������ - ���� �� ��������
							// (������-�� �� ����� �� � �������� ������... �� ���� �������� ������ ����)
							sText += RFMUtilities.Declen(nOthersCnt, "��������� ��������", "��������� ���������", "��������� ����������") + " ��� ���� �� �������.\n";
						}
						else
						{
							sText += RFMPublic.RFMUtilities.Declen(nOthersCnt, "��������� ��������", "��������� ���������", "��������� ����������") + ",\n" +
								"� ��� ����� " + RFMPublic.RFMUtilities.Declen(nOthersSamePartnerCnt, "��������� ��������", "��������� ���������", "��������� ����������") + " ��� ���� �� �������.\n";
						}
						sText += "��� ������ ����������� ������ ���� ��������� ��� ����������� ��������� �������� ����� ����� �� ���������������� ���������� ������� � ������.\n" +
							"���-���� ����������?";
						if (RFMMessage.MessageBoxYesNo(sText) != DialogResult.Yes)
							return;

					}
				}
			}

			// ���������. ����� ��������. 

			// ��� ����, � �������� ��������� �������� �������
			Trip oTripCarry = new Trip();
			oTripCarry.ReFillOne(nTripID);
			if (oTripCarry.IsConfirmed)
			{
				if (RFMMessage.MessageBoxYesNo("��������!\n\n����, � �������� �������� �������� ��������� ��������, ��� �����������.\n" +
					"���-���� ��������� ������ ����������� ���������� ���������?") != DialogResult.Yes)
					return;
			}

			string sTextAll = "�������� ����������� ���������� ��������� � ";
			if (bSingle)
			{
				sTextAll += "���������� �������\n" +
					"(��������� ��� ����������� ��������� �������� � ��������� ������� ����� �������,\n";
			}
			else
			{
				sTextAll += "����� ���������� �������\n" +
					"(��������� ��� ����������� ��������� �������� ����� �������� �� ���������� ���������� ������� � ������,\n"; 
			}
			sTextAll += "�������� ������� �� ����������,\n" +
				"��������� � ��� � host-������� ����� ���������� � �������� ��������)?";
			if (RFMMessage.MessageBoxYesNo(sTextAll) == DialogResult.Yes)
			{
				WaitOn(this);
				bool bResult = oOutputDocumentCarry.CarryCopyUnDo((int)oOutputDocumentCarry.ID, (int)oTripCarry.ID, ((RFMFormMain)Application.OpenForms[0]).UserID);
				WaitOff(this);
				if (bResult && oOutputDocumentCarry.ErrorNumber == 0)
				{
					//RFMMessage.MessageBoxInfo("����������� ���������� ��������� ��������\n");
					if (sPageName.Contains("TRIPS"))
					{
						grdTrips_Restore();
					}
					if (sPageName.Contains("OTHERS"))
					{
						grdOthers_Restore();
					}
				}
			}
		}

		#endregion Carry/Copy UnDo

	#region Trips_OutputsDocumentsFactTime

		private void Trips_OutputsDocumentsFactTime()
		{
			if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				return;
			int nTripID = (int)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;

			if (StartForm(new frmOutputsDocumentsFactTime(nTripID)) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

	#endregion Trips_OutputsDocumentsFactTime

	#region TripsCostEdit

		private void TripsCostEdit()
		{
			if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				return;

            DataTable dt = CopyTable(oTripList.MainTable, "dt", "IsRentCar", "DateTrip, Alias");
			if (dt == null || dt.Rows.Count == 0)
			{
				RFMMessage.MessageBoxInfo("� ������ ��� ������ ������������ �����...");
				return;
			}

			StartForm(new frmTripsCostEdit(dt));
			grdTrips_Restore();
		}

        private void TripsCostAmountEdit()
        {
            if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
                return;

            int nTripID = 0;
            if (grdTrips.Rows.Count == 0 || grdTrips.CurrentRow == null || !oTripCur.ID.HasValue)
                return;
            nTripID = (int)oTripCur.ID;

            Trip oCurTrip = new Trip();
            if (!oCurTrip.FillTablePutsInTripAll(nTripID, chkShowCarried.Checked))
                return;

            DataTable dt = CopyTable(oCurTrip.TablePutsInTrip, "dt", "Type = 'O' or Type = 'I' or Type = '$'", "Type", 
                new string[] { "ID", "Type", "InputID", "OutputID", "CarTaskID", 
                    "PartnerName", "ZoneName", "Netto", "Brutto", "PalletsQnt", 
                    "DeliveryAddress", "Note", 
                    "TaskInnerCost", "TaskOuterCost", 
                    "CarTaskUnitID", "UnitsQnt", "Price", "TaskAmount" });
            if (dt == null || dt.Rows.Count == 0)
            {
                RFMMessage.MessageBoxInfo("� ������ ��� ������� �� ����������...");
                return;
            }

            StartForm(new frmTripsCostAmountEdit(nTripID, dt));
            grdTrips_Restore();
        }

	#endregion TripsCostEdit

    #region TripsFarthestZoneEdit

        private void TripsFarthestZoneEdit()
        {
            if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
                return;

            int nTripID = (int)grdTrips.CurrentRow.Cells["grcTrips_ID"].Value;

            string sDateConfirm = grdTrips.CurrentRow.Cells["grcTrips_DateConfirm"].Value.ToString();
            if (sDateConfirm.Length == 0)
            {
                RFMMessage.MessageBoxInfo("���� ��� �� �����������...");
                return;
            }

            string sFarthestZoneName = grdTrips.CurrentRow.Cells["grcTrips_FarthestZoneName"].Value.ToString();
            if (sFarthestZoneName.Length > 0 && 
                RFMMessage.MessageBoxYesNo("����� ������� ���� ��� ����� ����� ��� �������.\r\n������ �������� ��?") != DialogResult.Yes)
            {
                return;
            }

            // ������ ��������, �������� ����
            Zone oZone = new Zone();
            oZone.FillData();
            DataTable dt = CopyTable(oZone.MainTable, "FilteredZones", "Tariff > 0", "Name");
            
            if (StartForm(new frmSelectID(this, dt, "Name,Tariff", "����,�����", false)) == DialogResult.Yes)
            {
                if (_SelectedID == null)
                    return;

                Trip oTrip = new Trip();
                oTrip.SetFarthestZone(nTripID, (int)_SelectedID);
                grdTrips_Restore();
            }

            _SelectedID = null;
        }

    #endregion TripsFarthestZoneEdit

        #region Logistics

        private void TripsLogistics()
		{
			if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
				return;
			
			if (StartForm(new frmLogistics()) == DialogResult.Yes)
			{
				grdTrips_Restore();
			}
		}

		#endregion Logistics 

        #region SetGuiltyEmployees

        private void SetGuiltyEmployees()
        {
            bool bRestore = false;

            if (!tcList.CurrentPage.Name.ToUpper().Contains("TRIPS"))
            {
                RFMMessage.MessageBoxError("��������� �� ������� \"����� � ���������\".");
                return;
            }

            if (grdTrips_OutputsDocuments.CurrentRow == null ||
                grdTrips_OutputsDocuments.IsStatusRow(grdTrips_OutputsDocuments.CurrentRow.Index))
            {
                RFMMessage.MessageBoxError("��������� � ������� \"��������� ���������\".");
                return;
            }

            // ��������� ������ � ������� ���������
            DataRow r = ((DataRowView)((DataGridViewRow)grdTrips_OutputsDocuments.Rows[grdTrips_OutputsDocuments.CurrentRow.Index]).DataBoundItem).Row;
            int nOutputDocumentID = Convert.ToInt32(r["OutputDocumentID"]);
            OutputDocument OutputDocumentCurrent = new OutputDocument();
            OutputDocumentCurrent.ReFillOne(nOutputDocumentID);

            if (OutputDocumentCurrent.OutputDocumentFailReasonID != null)
            {
                // ������ ������ � ��� ��������
                if (!OutputDocumentCurrent.IsConfirmed)
                {
                    RFMMessage.MessageBoxError("����� ��� �� ����� �� ������.\n���� ������ � ���������� � �������� ������� �� ������������.");
                    return;
                }
                if (!OutputDocumentCurrent.IsBrought)
                {
                    RFMMessage.MessageBoxError("����� ��� �� ��������� ����������.\n���� ������ � ���������� � �������� ������� �� ������������.");
                    return;
                }

                if (StartForm(new frmOutputsDocumentsGuiltyEmployees(nOutputDocumentID)) == DialogResult.Yes)
                {
                    bRestore = true;
                }
            }
            else
            {
                // ���� ������ � ��������� � ������� ���������,
                // � ���� ������� - ����������� ���
                OutputDocumentCurrent.FillTableOutputsDocumentsCarries(nOutputDocumentID);
                if (OutputDocumentCurrent.ErrorNumber != 0 ||
                    OutputDocumentCurrent.DS.Tables.Contains("TableOutputsDocumentsCarries") == false ||
                    OutputDocumentCurrent.DS.Tables["TableOutputsDocumentsCarries"] == null ||
                    OutputDocumentCurrent.DS.Tables["TableOutputsDocumentsCarries"].Rows.Count == 0)
                {
                    RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������� � ������ ���������� ���������...");
                    return;
                }

                // ����� ��������� ������� � ������� ��������� ������� ���������
                // ������ ������������ ��������������� �� ���� � ID
                int? nCarryID = null;
                DataTable dtCarries = OutputDocumentCurrent.DS.Tables["TableOutputsDocumentsCarries"];

                DataRow roc = dtCarries.Rows[dtCarries.Rows.Count - 1];
                nCarryID = (int)roc["ID"];
                if (!nCarryID.HasValue)
                {
                    RFMMessage.MessageBoxError("������ ��� ��������� ������ � ��������/����� ���������� ���������...");
                    return;
                }

                if (StartForm(new frmOutputsDocumentsGuiltyEmployees((int)nCarryID, true)) == DialogResult.Yes)
                {
                    bRestore = true;
                }
            }

            if (bRestore)
                grdTrips_OutputsDocuments_Restore();
        }

        #endregion SetGuiltyEmployees

        #endregion

        #region Filters Choose

        #region Drivers

        private void ucSelectRecordID_Drivers_Restore()
        {
            if (ucSelectRecordID_Drivers.sourceData == null)
            {
                Driver oDriver = new Driver();
				if (Utilities.FillData_Drivers(oDriver))
				{
					ucSelectRecordID_Drivers.Restore(oDriver.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_Drivers.Restore();
            }
        }

        #endregion Drivers

        #region Cars

        private void ucSelectRecordID_Cars_Restore()
        {
            if (ucSelectRecordID_Cars.sourceData == null)
            {
                Car oCar = new Car();
                oCar.FilterForGoodsOnly = true;
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

        #region CarsTypes

        private void ucSelectRecordID_CarsTypes_Restore()
        {
            if (ucSelectRecordID_CarsTypes.sourceData == null)
            {
                CarType oCarType = new CarType();
				if (Utilities.FillData_CarsTypes(oCarType))
				{
					ucSelectRecordID_CarsTypes.Restore(oCarType.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_CarsTypes.Restore();
            }
        }

		#endregion CarsTypes

        #region Partners

        private void ucSelectRecordID_Partners_Restore()
        {
            if (ucSelectRecordID_Partners.sourceData == null)
            {
                Partner oPartner = new Partner();
				if (Utilities.FillData_Partners(oPartner))
				{
					ucSelectRecordID_Partners.Restore(oPartner.MainTable);
				}
            }
            else
            {
                ucSelectRecordID_Partners.Restore();
            }
        }

        #endregion Partners

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

        private void optInputsAttachedAll_CheckedChanged(object sender, EventArgs e)
		{
			pnlInputsConfirmed.Enabled = optInputsAttached.Checked;
		}

		private void optOutputsAttachedAll_CheckedChanged(object sender, EventArgs e)
		{
			pnlOutputsConfirmed.Enabled = optOutputsAttached.Checked;
		}

		private void optOutputsDocumentsAttachedAll_CheckedChanged(object sender, EventArgs e)
		{
			pnlOutputsDocumentsBrought.Enabled = optOutputsDocumentsAttached.Checked;
		}

		private void chkCarriedInclude_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCarriedInclude.Checked)
				chkShowCarried.Checked = true;
		}

	#endregion

	#region Terms clear

		private void btnClearTerms_Click(object sender, EventArgs e)
		{
            /*dtrDates.dtpBegDate.Value = DateTime.Now.AddDays(-1).Date;
            dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(7).Date;*/
            dtrDates.dtpBegDate.Value = DateTime.Now;
            dtrDates.dtpEndDate.Value = dtrDates.dtpBegDate.Value.Date.AddDays(1).Date;

			txtAliasContext.Text = "";

            ucSelectRecordID_Drivers.ClearData();
            ucSelectRecordID_Cars.ClearData();
            ucSelectRecordID_CarsTypes.ClearData();

			txtOutputsDocumentsDepartmentNameContext.Text = "";

			txtPartnerNameContext.Text = "";
            ucSelectRecordID_Partners.ClearData();

			optCarDefinedAll.Checked = true; 
			
			optOutputsAttachedAll.Checked = true;
			optOutputsConfirmedAll.Checked = true;
			optOutputsAttachedAll_CheckedChanged(null, null);

			optOutputsDocumentsAttachedAll.Checked = true;
			optOutputsDocumentsBroughtAll.Checked = true;
			optOutputsDocumentsAttachedAll_CheckedChanged(null, null); 

			optInputsAttachedAll.Checked = true;
			optInputsConfirmedAll.Checked = true;
			optInputsAttachedAll_CheckedChanged(null, null);

			optInputsDocumentsAttachedAll.Checked = true;

			optTripsStatusesAll.Checked = true;
			optReadyForPrintAll.Checked = true;
			optIsPrintedAll.Checked = true;
			optReadyForTripBegAll.Checked = true;
			optIsConfirmedNot.Checked = true;

			numTripID.Value = 0;

			ucSelectRecordID_Hosts.ClearData();

			if (Control.ModifierKeys == Keys.Shift)
			{
				dtrDates.dtpBegDate.HideControl(false);
				dtrDates.dtpEndDate.HideControl(false);
				optIsConfirmedAll.Checked = true;
			}

			tabTrips.IsNeedRestore = true;
		}

	#endregion

	#region Counter a la Calculator

	private void btnCounter_Click(object sender, EventArgs e)
		{
			if ((new frmCounter()).ShowDialog() == DialogResult.Yes)
			{
				if (StartProgram.ParamStore.GetValue(0) != null)
				{
					// ������ ��������� ��������
					//MessageBox.Show(StartProgram.ParamStore.GetValue(0).ToString());
				}
				if (StartProgram.ParamStore.GetValue(1) != null)
				{
					// ���� ��������
					//MessageBox.Show(Convert.ToDecimal(StartProgram.ParamStore.GetValue(1)).ToString());
					Clipboard.SetText(StartProgram.ParamStore.GetValue(1).ToString());
				}
			}
		}

        #endregion Counter a la Calculator
    }
}