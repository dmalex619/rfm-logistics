using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using RFMPublic;
using LogBizObjects;


namespace Logistics
{
	public partial class frmLogistics : RFMFormChild
	{
		private Trip oTrip, oTripsList;
		private Partner oPartner;
		private Logistic oLogistic;
		private DataTable dtDepartmentNames = new DataTable();
		private decimal nCarBrutto, nCarVolume, nCarPallets;
		private decimal nOutputsBrutto, nOutputsPallets, nOutputsVolume;
		private decimal nInputsBrutto, nInputsPallets, nInputsVolume;
		private int? nPartnerID;
		private int nCheckedPutsCount = 0;
		private String cSystemIDList = "";
			
		private DataView dvTripPuts;

		public string _SelectedIDList;
		public string _SelectedText;

		public frmLogistics()
		{
			oTrip = new Trip();
			oTripsList = new Trip();
			oPartner = new Partner();
			oLogistic = new Logistic();
			if (
				oTrip.ErrorNumber != 0 ||
				oPartner.ErrorNumber != 0 ||
				oLogistic.ErrorNumber != 0 ||
				oTripsList.ErrorNumber !=0
				)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
				#region пользовательские настройки логистики

				int nUserID = (int)((RFMFormMain)Application.OpenForms[0]).UserID;
				if (oLogistic.FillTableLogisticsSettings(nUserID) && oLogistic.TableLogisticsSettings.Rows.Count > 0)
				{
					DataRow dr = oLogistic.TableLogisticsSettings.Rows[0];

					if (chkJoinDocumentsInStorage.Enabled)
						chkJoinDocumentsInStorage.Checked = (bool)dr["AutoJoinDocumentsInStorage"];

					chkJoinDocumentsInCar.Checked = (bool)dr["AutoJoinDocumentsInCar"];

					if (dr["WeightControl"] == DBNull.Value)
						radWeightWarning.Checked = true;
					else
					{
						if ((bool)dr["WeightControl"])
							radWeightBan.Checked = true;
						else
							radWeightSkip.Checked = true;
					}
					if (dr["VolumeControl"] == DBNull.Value)
						radVolumeWarning.Checked = true;
					else
					{
						if ((bool)dr["VolumeControl"])
							radVolumeBan.Checked = true;
						else
							radVolumeSkip.Checked = true;
					}

					if (dr["PalletsControl"] == DBNull.Value)
						radPalletsWarning.Checked = true;
					else
					{
						if ((bool)dr["PalletsControl"])
							radPalletsBan.Checked = true;
						else
							radPalletsSkip.Checked = true;
					}

					if (dr["PassengerCarControl"] == DBNull.Value)
						radPassCarWarning.Checked = true;
					else
					{
						if ((bool)dr["PassengerCarControl"])
							radPassCarBan.Checked = true;
						else
							radPassCarSkip.Checked = true;
					}

					if (dr["PosternControl"] == DBNull.Value)
						radPosternWarning.Checked = true;
					else
					{
						if ((bool)dr["PosternControl"])
							radPosternBan.Checked = true;
						else
							radPosternSkip.Checked = true;
					}

					if (dr["LoadLiftControl"] == DBNull.Value)
						radLiftWarnings.Checked = true;
					else
					{
						if ((bool)dr["LoadLiftControl"])
							radLiftBan.Checked = true;
						else
							radLiftSkip.Checked = true;
					}

					if (dr["PermitLevelControl"] == DBNull.Value)
						radPermitLevelControlWarnings.Checked = true;
					else
					{
						if ((bool)dr["PermitLevelControl"])
							radPermitLevelControlBan.Checked = true;
						else
							radPermitLevelControlSkip.Checked = true;
					}
					if (dr["MaxPointsQntControl"] == DBNull.Value)
						radMaxPointsQntWarnings.Checked = true;
					else
					{
						if ((bool)dr["MaxPointsQntControl"])
							radMaxPointsQntBan.Checked = true;
						else
							radMaxPointsQntSkip.Checked = true;
					}
					if (dr["MaxDurationControl"] == DBNull.Value)
						radMaxDurationWarning.Checked = true;
					else
					{
						if ((bool)dr["MaxDurationControl"])
							radMaxDurationBan.Checked = true;
						else
							radMaxDurationSkip.Checked = true;
					}
					radUserSettings.Checked = true;
				}
				#endregion пользовательские настройки логистики
			}
		}

		private void frmLogistics_Load(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);

			// назначение суммирования и шрифта на колонки
			foreach (Control ctrl in Controls)
			{
				Utilities.ctrl_AgrTypeSet(ctrl);
			}

			tmrRestore.Enabled = false;
			tcList.Init();
			tcList_SelectedIndexChanged(null, null);
			RFMCursorWait.Set(false);
		}

		#region Buttons

		private void btnHelp_Click(object sender, EventArgs e)
		{
			MessageBox.Show(dgvPuts.MarkedCount.ToString());
			RFMHelpUtilities.HelpShow(this, hpHelp);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}
	
		private void ChangeByOrder (string sMode)
		{
            // НЕ ПРИМЕНЯЕТСЯ!!!
			/*Input  oInputs = new Input();
			Output oOutputs = new Output();

			if (sMode.ToLower().Trim() == "output")
				dvTripPuts.RowFilter = "Isnull(InputID,0) = 0";
			else
				dvTripPuts.RowFilter = "Isnull(OutputID,0) = 0";
			DataTable dtTempTable = dvTripPuts.ToTable();
			if (dtTempTable.Rows.Count == 0)
					return;
			GotParam = null;
            DialogResult dr = StartForm(new frmByOrder(dtTempTable, "ByOrder, PartnerName, Brutto#2", "ПЗ, Клиент, Брутто", "ID"));
			if (dr != DialogResult.Yes)
				return;
			string strPuts = GotParam[0].ToString();
			if (strPuts != null && strPuts.Length > 0)
			{
				int nBY_PutID = 0;
				string sBY_PutsList = "";
				int nBY_ByOrder = 0;
				string sDelimiter = ";";
				string sDelimiterOfList = ",";

				if (strPuts.Substring(strPuts.Length - 1) != sDelimiter)
					strPuts += sDelimiter;

				int nAtDelimiter = strPuts.IndexOf(sDelimiter);
				while (nAtDelimiter > 0)
				{
					nBY_ByOrder++;

					sBY_PutsList = strPuts.Substring(0, nAtDelimiter);
					strPuts = strPuts.Substring(nAtDelimiter + 1);

					if (sBY_PutsList.Contains(sDelimiterOfList))
					{
						sBY_PutsList += sDelimiterOfList;

						int nAtDelimiterOfList = sBY_PutsList.IndexOf(sDelimiterOfList);
						while (nAtDelimiterOfList > 0)
						{
							nBY_PutID = Convert.ToInt32(sBY_PutsList.Substring(0, nAtDelimiterOfList));
							sBY_PutsList = sBY_PutsList.Substring(nAtDelimiterOfList + 1);
							
							if (sMode.ToLower().Trim() == "output")
								oOutputs.SaveByOrder(nBY_PutID, nBY_ByOrder);
							else
								oInputs.SaveByOrder(nBY_PutID, nBY_ByOrder);

							nAtDelimiterOfList = sBY_PutsList.IndexOf(sDelimiterOfList);
						}
					}
					else
					{
						nBY_PutID = Convert.ToInt32(sBY_PutsList);
						if (sMode.ToLower().Trim() == "output")
							oOutputs.SaveByOrder(nBY_PutID, nBY_ByOrder);
						else
							oInputs.SaveByOrder(nBY_PutID, nBY_ByOrder);

					}
					nAtDelimiter = strPuts.IndexOf(sDelimiter);
				}
				dgvTripPuts_Restore();
			}*/
		}

        private void btnApplayTrips_Click(object sender, EventArgs e)
        {
            if (cboTrips.Items.Count == 0)
            {
                RFMMessage.MessageBoxAttention("Нет ни одного рейса. Нечего сохранять...");
                return;
            }

            if (RFMMessage.MessageBoxYesNo("Отметить все рейсы как готовые к обработке на складе?") == DialogResult.Yes)
            {
                WaitOn(this);
                bool bResult = true;
                for (int _i = 0; _i < oTrip.MainTable.Rows.Count; _i++)
                {
                    oTrip.SetReadyForWMS((int)oTrip.MainTable.Rows[_i]["TripID"]);
                    if (oTrip.ErrorNumber != 0 && bResult)
                        bResult = false;
                }
                WaitOff(this);
                if (bResult)
                {
                    cboTrips_Restore();
                    cboTrips.SelectedIndex = -1;
                    ShowEmptyTrip();
                    tabCars.IsNeedRestore = tabTrips.IsNeedRestore = true;
                    dgvTripPuts_Restore();
                }
                else
                    RFMMessage.MessageBoxInfo("Ошибка обработки рейсов... ");
		    }
        }

	    private void btnApplyOneTrip_Click(object sender, EventArgs e)
		{
			if (cboTrips.SelectedValue == null)
			{
				RFMMessage.MessageBoxAttention("Не выбран рейс ...");
				return;
			}

		    WaitOn(this);
		    bool bResult =  oTrip.SetReadyForWMS((int)cboTrips.SelectedValue);
		    WaitOff(this);
		    if (bResult)
            {
			    cboTrips_Restore();
			    cboTrips.SelectedIndex = -1;
			    ShowEmptyTrip();
			    tabCars.IsNeedRestore = tabTrips.IsNeedRestore = true;		
			    dgvTripPuts_Restore();
		    }
		    else
			    RFMMessage.MessageBoxInfo("Ошибка обработки рейса... ");
		}

		private void btnSettingsSave_Click(object sender, EventArgs e)
		{
			if (RFMMessage.MessageBoxYesNo("Сохранить текущие настройки?") != DialogResult.Yes)
				return;

			bool bAutoJoinDocumentsInCar = chkJoinDocumentsInCar.Checked;
			bool bAutoJoinDocumentsInStorage = chkJoinDocumentsInStorage.Checked;
			bool? bWeightControl, bVolumeControl, bPalletsControl;
			bool? bPassengerCarControl, bPosternControl, bLoadLiftControl, bPermitLevelControl;
			bool? bMaxPointsQntControl, bMaxDurationControl;

			bWeightControl = (radWeightWarning.Checked) ? (bool?)(null) : ((radWeightBan.Checked) ? (true) : (false));
			bVolumeControl = (radVolumeWarning.Checked) ? (bool?)(null) : ((radVolumeBan.Checked) ? (true) : (false));
			bPalletsControl = (radPalletsWarning.Checked) ? (bool?)(null) : ((radPalletsBan.Checked) ? (true) : (false));
			bPassengerCarControl = (radPassCarWarning.Checked) ? (bool?)(null) : ((radPassCarBan.Checked) ? (true) : (false));
			bPosternControl = (radPosternWarning.Checked) ? (bool?)(null) : ((radPosternBan.Checked) ? (true) : (false));
			bPermitLevelControl = (radPermitLevelControlWarnings.Checked) ? (bool?)(null) : ((radPermitLevelControlBan.Checked) ? (true) : (false));
			bLoadLiftControl = (radLiftWarnings.Checked) ? (bool?)(null) : ((radMaxDurationBan.Checked) ? (true) : (false));
			bMaxPointsQntControl = (radMaxPointsQntWarnings.Checked) ? (bool?)(null) : ((radMaxPointsQntBan.Checked) ? (true) : (false));
			bMaxDurationControl = (radMaxDurationWarning.Checked) ? (bool?)(null) : ((radMaxPointsQntBan.Checked) ? (true) : (false));
			int nUserID = (int)((RFMFormMain)Application.OpenForms[0]).UserID;
			oLogistic.Save(nUserID, bAutoJoinDocumentsInCar, bAutoJoinDocumentsInStorage, bWeightControl, bVolumeControl, bPalletsControl, bPassengerCarControl,
				bPosternControl, bLoadLiftControl, bPermitLevelControl, bMaxPointsQntControl, bMaxDurationControl);
		}

        private void btnShowTrip_Click(object sender, EventArgs e)
        {
            if (cboTrips.SelectedValue == null)
            {
                RFMMessage.MessageBoxAttention("Не выбран рейс ...");
                return;
            }

            // Получение геоданных
            int nTripID = (int)cboTrips.SelectedValue;
            if (!oTrip.FillTableGeoData(nTripID.ToString())) return;

            frmShowMap frmShowMap = new frmShowMap(oTrip.TableGeoData, true);
            if (frmShowMap != null) StartForm(frmShowMap);
        }

        private void btnCalcTrip_Click(object sender, EventArgs e)
        {
            if (cboTrips.SelectedValue == null)
            {
                RFMMessage.MessageBoxAttention("Не выбран рейс ...");
                return;
            }

            // Получение данных для расчета
            RFMCursorWait.Set(true);
            int nTripID = (int)cboTrips.SelectedValue;
            if (!oTrip.FillTableEfficiency(nTripID))
            {
                RFMCursorWait.Set(false);
                return;
            }

            frmTripEfficiency frmTripEfficiency = new frmTripEfficiency(oTrip.TableEfficiency);
            if (frmTripEfficiency != null) StartForm(frmTripEfficiency);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            RFMCursorWait.Set(true);
            dgvTripPuts.IsRestoring = true;
            MoveGroup(true);
            dgvTripPuts.IsRestoring = false;
            RFMCursorWait.Set(false);
        }

        private void btnMoveDn_Click(object sender, EventArgs e)
        {
            RFMCursorWait.Set(true);
            dgvTripPuts.IsRestoring = true;
            MoveGroup(false);
            dgvTripPuts.IsRestoring = false;
            RFMCursorWait.Set(false);
        }

        private void btnCheckedPutsToTrip_Click(object sender, EventArgs e)
        {
            RFMCursorWait.LockWindowUpdate(FindForm().Handle);
            Input oInput = new Input();
            Output oOutput = new Output();
            bool bSuccess = true;
            int nTripID = (int)cboTrips.SelectedValue;
            DataRow drT = oTrip.MainTable.Rows.Find(nTripID);
            int nRowIndex = dgvPuts.CurrentRow.Index;
            int nColumnIndex = dgvPuts.CurrentCell.ColumnIndex;
            if (nCheckedPutsCount > 0)
            {
                foreach (DataRow dr in oTripsList.TablePutsInTrip.Rows)
                {
                    bSuccess = true;
                    if ((bool)dr["IsChecked"] && dr["TripID"] == DBNull.Value)
                    {
                        nPartnerID = (dr["PartnerID"] == DBNull.Value) ? null : (int?)dr["PartnerID"];

                        if (dr["InputID"] == DBNull.Value)
                        {
                            if (oOutput.ToTrip((int)dr["OutputID"], nTripID))
                            {
                                if ((bool)drT["IsPostern"])
                                    oOutput.SaveByOrder((int)dr["ID"], CalcByOrder(nPartnerID, "Output"));
                                else
                                    oOutput.SaveByOrder((int)dr["ID"], 1);
                            }
                            else
                                bSuccess = false;
                        }
                        else
                        {
                            if (oInput.ToTrip((int)dr["InputID"], nTripID))
                            {
                                if ((bool)drT["IsPostern"])
                                    oInput.SaveByOrder((int)dr["ID"], CalcByOrder(nPartnerID, "Input"));
                                else
                                    oInput.SaveByOrder((int)dr["ID"], 1);
                            }
                            else
                                bSuccess = false;
                        }
                        if (bSuccess)
                        {
                            dr["TripID"] = nTripID;
                            dr["SentToWMS"] = false;
                            dr["IsChecked"] = false;
                        }
                    }
                }
            }
            dgvPuts.CommitChanges();
            dgvTripPuts_Restore();
            ShowRestTotal();
            ShowTripTotal(nTripID);
            gridPutsRowChange(null, dgvPuts);
            if (dgvPuts.Rows.Count > 0)
            {
                if (dgvPuts.Rows.Count > nRowIndex)
                    dgvPuts.CurrentCell = dgvPuts.Rows[nRowIndex].Cells[nColumnIndex];
                else
                    dgvPuts.CurrentCell = dgvPuts.Rows[dgvPuts.Rows.Count - 1].Cells[nColumnIndex];
            }
            tabList.IsNeedRestore = true;
            btnUnCheckAllPuts.Visible = btnUnCheckAllPuts.Enabled =
                btnCheckedPutsToTrip.Visible = btnCheckedPutsToTrip.Enabled = false;
            cboTrips.Enabled = true;
            RFMCursorWait.LockWindowUpdate(IntPtr.Zero);

        }

        private void btnUnCheckAllPuts_Click(object sender, EventArgs e)
        {
            RFMCursorWait.LockWindowUpdate(FindForm().Handle);
            RFMBindingSource bs = dgvPuts.GridSource;
            dgvPuts.IsRestoring = true;
            int nbsPosition = bs.Position;
            string cbsFilter = bs.Filter;
            bs.Filter = " IsChecked";
            bs.MoveFirst();
            int nbsCount = bs.Count;
            for (int i = 0; i < nbsCount; i++)
            {
                DataRowView drvP = ((DataRowView)bs.Current);
                drvP["IsChecked"] = false;
                bs.MoveNext();
            }
            bs.Filter = cbsFilter;
            bs.Position = nbsPosition;
            nCheckedPutsCount = 0;
            btnCheckedPutsToTrip.Visible = btnCheckedPutsToTrip.Enabled = false;
            dgvPuts.IsRestoring = false;
            cboTrips.Enabled = true;
            btnUnCheckAllPuts.Visible = btnUnCheckAllPuts.Enabled =
                btnCheckedPutsToTrip.Visible = btnCheckedPutsToTrip.Enabled = false;
            RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
        }

		#endregion Buttons

		#region Buttons-1_стр

        private void ucSelectRecordID_CarsTypes_Restore()
        {
            if (ucSelectRecordID_CarsTypes.sourceData == null)
            {
                RFMCursorWait.Set(true);
                CarType oCarType = new CarType();
                oCarType.FillData();
                RFMCursorWait.Set(false);
                if (oCarType.ErrorNumber != 0 || oCarType.MainTable == null)
                {
                    RFMMessage.MessageBoxError("Ошибка при получении данных (типы машин)...");
                    return;
                }
                if (oCarType.MainTable.Rows.Count == 0)
                {
                    RFMMessage.MessageBoxError("Нет данных (типы машин)...");
                    return;
                }

                ucSelectRecordID_CarsTypes.Restore(oCarType.MainTable);
            }
            else
            {
                ucSelectRecordID_CarsTypes.Restore();
            }
        }

        private void ucSelectRecordID_Zones_Restore()
        {
            if (ucSelectRecordID_Zones.sourceData == null)
            {
                Zone oZone = new Zone();
                oZone.FillDataTree(true);
                if (oZone.ErrorNumber != 0 || oZone.DS.Tables["TableDataTree"] == null)
                {
                    RFMMessage.MessageBoxError("Ошибка при получении данных (зоны)...");
                    return;
                }
                if (oZone.DS.Tables["TableDataTree"].Rows.Count == 0)
                {
                    RFMMessage.MessageBoxError("Нет данных (зоны)...");
                    return;
                }

                ucSelectRecordID_Zones.Restore(oZone.DS.Tables["TableDataTree"]);
            }
            else
            {
                ucSelectRecordID_Zones.Restore();
            }
        }

        private void ucSelectRecordID_Partners_Restore()
        {
            if (ucSelectRecordID_Partners.sourceData == null)
            {
                RFMCursorWait.Set(true);
                Partner oPartner = new Partner();
                oPartner.FillData();
                RFMCursorWait.Set(false);
                if (oPartner.ErrorNumber != 0 || oPartner.MainTable == null)
                {
                    RFMMessage.MessageBoxError("Ошибка при получении данных (клиенты)...");
                    return;
                }
                if (oPartner.MainTable.Rows.Count == 0)
                {
                    RFMMessage.MessageBoxError("Нет данных (клиенты)...");
                    return;
                }

                ucSelectRecordID_Partners.Restore(oPartner.MainTable);
            }
            else
            {
                ucSelectRecordID_Partners.Restore();
            }
        }

		#endregion Buttons-1_стр

		#region Restore

		private bool tabTrips_Restore()
		{
			cboTrips_Restore();
			//cboTrips.SelectedValue = 0;
			cboTrips.SelectedIndex = -1;
			ShowEmptyTrip();
			dgvTripPuts_Restore();
			return(dgvPuts_Restore());
		}

		private bool tabList_Restore()
		{
			if (tcReports.SelectedTab.Name.ToUpper() == "tabZones".ToUpper())
			{
				tabZones_Restore();
				tabCars.IsNeedRestore = true;
			}
			else
			{
				tabCars_Restore();
				tabZones.IsNeedRestore = true;
			}
			return true;
		}

		private bool tabCars_Restore()
		{
			dgvTrips_Restore();
			dgvTrips.Select();
			return true;
		}

		private bool tabZones_Restore()
		{
			dgvZones_Restore();
			dgvZones.Select();
			return true;
		}

		private bool dgvTripPuts_Restore()
		{
			dgvTripPuts.GetGridState();
			
			int nTripID;
			if (cboTrips.SelectedValue == null)
				nTripID = 0;
			else
				nTripID = (int)cboTrips.SelectedValue;

			oTrip.FillTablePutsInTrip(nTripID);
			if (oTrip.ErrorNumber == 0)
			{
				oTrip.TablePutsInTrip.Columns.Add("Picked", Type.GetType("System.Boolean"));
				oTrip.TablePutsInTrip.Columns.Add("DurationMinutes", Type.GetType("System.Int32"));
				for (int i = 0; i < oTrip.TablePutsInTrip.Rows.Count; i++)
				{
					oTrip.TablePutsInTrip.Rows[i]["Picked"] = false;
					oTrip.TablePutsInTrip.Rows[i]["DurationMinutes"] = 0;
					
				}
				dvTripPuts = new DataView(oTrip.TablePutsInTrip);
				dvTripPuts.Sort = "ByOrder";
				dgvTripPuts.Restore(dvTripPuts);
			}
			return (oTrip.ErrorNumber == 0);
		}

		private bool dgvPuts_Restore()
		{
			bool? bPassengerCarOnly, bPosternOnly,  bReadyForWMS, bCarriedOnly, bInputs;
			bPassengerCarOnly = bPosternOnly =  bCarriedOnly = bReadyForWMS = bInputs = null;
			if (radPutsOnlyPasCars.Checked)
				bPassengerCarOnly = true;
			if (radPutsUnPasCars.Checked)
				bPassengerCarOnly = false;
			if (radPutsOnlyPosternCars.Checked)
				bPosternOnly = true;
			if (radPutsUnPosternCars.Checked)
				bPosternOnly = false;
			if (!radAllPuts.Checked)
			{
				if (radOutputs.Checked)
					bInputs = false;
				else
					bInputs = true;
			}

			if (!radPutsWMS.Checked)
			{
				if (radPutsReadyForWMS.Checked)
					bReadyForWMS = true;
				else
					bReadyForWMS = false;
			}
			
			if (chkOnlyCarried.Checked)
				bCarriedOnly = true;

			dgvPuts.GetGridState();
			oTripsList.FillTablePutsInTrip(null, null, true, bInputs, null, dtpDateTrip.Value.Date, null, null,
				 null, null, bReadyForWMS, null, bCarriedOnly, 
                 (ucSelectRecordID_Partners.IsSelectedExist ? ucSelectRecordID_Partners.GetIdString() : null), 
                 bPassengerCarOnly, bPosternOnly, 
                 null, null, 
                 (ucSelectRecordID_Zones.IsSelectedExist ? ucSelectRecordID_Zones.GetIdString() : null));
			if (oTripsList.ErrorNumber == 0)
			{

				DataColumn dc = new DataColumn();
				dc.ColumnName = "IsChecked";
				dc.DataType = Type.GetType("System.Boolean");
				dc.AllowDBNull = true;
				dc.DefaultValue = false;
				dc.ReadOnly = false;
				oTripsList.TablePutsInTrip.Columns.Add(dc);
				dgvPuts.Restore(oTripsList.TablePutsInTrip);
				string sSelectedDepartmentNamesIDList = ucSelectRecordID_DepartmentNames.GetIdString();
				string sDepartmentNameFilter = "";
				if (sSelectedDepartmentNamesIDList != null)
				{
					sSelectedDepartmentNamesIDList = "," + sSelectedDepartmentNamesIDList + ",";
					if (dtDepartmentNames != null && dtDepartmentNames.Rows.Count > 0)
					{
						sDepartmentNameFilter = "( DepartmentName like "; 
						DataRow dr;
						int j = 0;
						for (int i = 0; i < dtDepartmentNames.Rows.Count; i++)
						{
							dr = dtDepartmentNames.Rows[i];
							if (sSelectedDepartmentNamesIDList.Contains("," + dr["ID"].ToString().Trim() + ","))
							{
								if (j > 0)
									sDepartmentNameFilter += " or DepartmentName like ";
								sDepartmentNameFilter +=  "'*" + dr["DepartmentName"].ToString()  + "*'";
								j++;
							}
						}
					}
				}
				if (sDepartmentNameFilter.Length > 0)
					dgvPuts.GridSource.Filter = "isnull(TripID,0) = 0 and "   + sDepartmentNameFilter  + ")";  
				else
					dgvPuts.GridSource.Filter = "isnull(TripID,0) = 0"; 
			}
			ShowRestTotal();

			return (oTripsList.ErrorNumber == 0);
		}

		private bool dgvTrips_Restore()
		{
			if (oTrip.CalcTripsInfoByDate(dtpDateTrip.Value.Date))
			{
				dgvTrips.Restore(oTrip.DS.Tables["TripsInfoByDate"]);
				return true;
			}
			else
				return false;
		}

		private void ucSelectRecordID_DepartmentNames_Restore()
		{
			if (dtDepartmentNames == null || dtDepartmentNames.Rows.Count == 0)
			{

				OutputDocument oOutputDocument = new OutputDocument();
				oOutputDocument.FillTableDepartmentNames(dtpDateTrip.Value.Date, dtpDateTrip.Value.Date);
				if (oOutputDocument.ErrorNumber != 0 || oOutputDocument.MainTable == null)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных (отделы)...");
					return;
				}
				if (oOutputDocument.TableDepartmentNames.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных (отделы)...");
					return;
				}
				DataColumn c = oOutputDocument.TableDepartmentNames.Columns.Add("ID", Type.GetType("System.Int32"));
				int i = 0;
				foreach (DataRow dn in oOutputDocument.TableDepartmentNames.Rows)
				{
					dn["ID"] = i;
					i++;
				}

				dtDepartmentNames = CopyTable(oOutputDocument.TableDepartmentNames, "dtDepartmentNames", "", "DepartmentName");
			}

			ucSelectRecordID_DepartmentNames.Restore(dtDepartmentNames);
		}

		private bool cboTrips_Restore()
		{
			oTrip.ClearFilters();

			if (!radAllCars_Pass.Checked)
				oTrip.FilterIsPassengerCar = radPassengerCars.Checked;
			else
				oTrip.FilterIsPassengerCar = null;

			if (!radAllCars_Post.Checked)
				oTrip.FilterIsPostern = radPosternCars.Checked;
			else
				oTrip.FilterIsPostern = null;

			if (!radAllCars_Own.Checked)
				oTrip.FilterIsRentCar = radRent.Checked;
			else
				oTrip.FilterIsRentCar = null;

			if (chkWMSReadyTrips.Checked)
				oTrip.FilterReadyForWMS = false;

			if (chkOnlyUnStartedTrips.Checked)
				oTrip.FilterTripStatus = 0;
			
			if (ucSelectRecordID_CarsTypes.IsSelectedExist)
				oTrip.FilterCarsTypesList = ucSelectRecordID_CarsTypes.GetIdString();
			else
				oTrip.FilterCarsTypesList = null;

			oTrip.FilterDateBeg = dtpDateTrip.Value.Date;
			oTrip.FilterDateEnd = oTrip.FilterDateBeg;
			oTrip.FilterSelfDelivery = false;

			if (oTrip.FillData())
			{
				oTrip.MainTable.PrimaryKey = new DataColumn[] { oTrip.MainTable.Columns["ID"] };
				cboTrips.ValueMember = oTrip.MainTable.Columns[0].ColumnName;
				cboTrips.DisplayMember = oTrip.MainTable.Columns[("Alias")].ToString();
				cboTrips.DataSource = new DataView(oTrip.MainTable);
			}
			ShowTripTotal((int?)cboTrips.SelectedValue);
			dgvTripPuts_Restore();
			ShowRestTotal();

			return (oTrip.ErrorNumber != 0);
		}

		private bool dgvInCar_Restore(int? nTripID)
		{
			OutputDocument oCarOutputDocuments = new OutputDocument();
			InputDocument oCarInputDocuments = new InputDocument();
			oCarOutputDocuments.FilterTripsList = nTripID.ToString();
			oCarOutputDocuments.FillData();
			oCarInputDocuments.FilterTripsList = nTripID.ToString();
			oCarInputDocuments.FillData();
			DataRow dro;
			for (int i = 0; i < oCarInputDocuments.MainTable.Rows.Count; i++)
			{
				dro = oCarInputDocuments.MainTable.Rows[i];
                dro["PartnerTargetName"] = dro["PartnerSourceName"];
			}
			oCarInputDocuments.MainTable.Merge(oCarOutputDocuments.MainTable);
			dgvInCar.Restore(oCarInputDocuments.MainTable);
			return true;
		}

		private bool dgvZones_Restore()
		{
			Zone oZoneList = new Zone();
			if (oZoneList.CalcZonesLogisticInfoByDate(dtpDateTrip.Value.Date))
				dgvZones.Restore(oZoneList.DS.Tables["ZonesLogisticInfo"]);
			return (oZoneList.ErrorNumber == 0);
		}

		private bool dgvZoneTrips_Restore(int ZoneID)
		{
			Zone oZone = new Zone();
			if (oZone.ZonesTripsInfoByDate(dtpDateTrip.Value.Date, ZoneID))
			{
				dgvZoneTrips.Restore(oZone.DS.Tables["ZonesTripsInfo"]);
				return true;
			}
			else
				return false;
		}

		#endregion Restore

		#region Procedures

		private void CarInfo(int nTripID)
		{
			DataRow droTrips = oTrip.MainTable.Rows.Find(nTripID);
			if (droTrips != null)
			{
				chkPassengerCar.Checked = (bool)droTrips["IsPassengerCar"];
				chkPostern.Checked = (bool)droTrips["IsPostern"];
				chkLoadLift.Checked = (bool)droTrips["IsLoadLift"];
				txtPermitLevelName.Text = droTrips["PermitLevelName"].ToString();
				nCarBrutto = Convert.ToDecimal(droTrips["Tonnage"]);
				nCarPallets = (decimal)droTrips["MaxPalletsQnt"];
				nCarVolume = (decimal)droTrips["Volume"];
				chkRentCar.Checked = (bool)droTrips["IsRentCar"];
			}
		}

        private void DriverInfo(int DriverEmployeeID)
        {
            Driver oDriver = new Driver();
            string sDriverStatistics = oDriver.GetDriverZonesStatistics(DriverEmployeeID);
            lblDriverInfo.Text = sDriverStatistics;
            //MessageBox.Show(sDriverStatistics);
        }

		private void ShowEmptyTrip()
		{
			chkPassengerCar.Checked =
			chkPostern.Checked =
			chkLoadLift.Checked =
			chkRentCar.Checked =
				false;

			txtPermitLevelName.Text =
			txtOutputsBrutto.Text =
			txtOutputsBruttoPercent.Text =
			txtOutputsPallets.Text =
			txtOutputsPalletsPercent.Text =
			txtOutputsVolume.Text =
			txtOutputsVolumePercent.Text =
			txtOutputsDuration.Text =
			txtOutputsPointsQnt.Text =
				"";

			txtOutputsDuration.BackColor =
			txtOutputsBruttoPercent.BackColor =
			txtOutputsPalletsPercent.BackColor =
			txtOutputsVolumePercent.BackColor =
				SystemColors.Control;
		}

		private void ShowTripTotal(int? nTripID)
		{
			if (!nTripID.HasValue || oTrip.TablePutsInTrip == null)
				return;

			decimal nTripBrutto, nTripPallets, nTripVolume, nDischargeMinutes;
			double nTemp;
			int nPointQnt = 0;
			nTripBrutto = nTripPallets = nTripVolume = nDischargeMinutes = 0;
			nOutputsBrutto = nOutputsPallets = nOutputsVolume = 0;
			DataRow dr;
			for (int nI = 0; nI < oTrip.TablePutsInTrip.Rows.Count; nI++)
			{
				dr = oTrip.TablePutsInTrip.Rows[nI];
				if ((int?)dr["TripID"] == nTripID && dr["InPutID"] == DBNull.Value)
				{
					nOutputsBrutto += (decimal)dr["Brutto"];
					nOutputsPallets += (decimal)dr["PalletsQnt"];
					nOutputsVolume += (decimal)dr["Volume"];
				}
			}

			// число точек
			nPointQnt = 0;
			OutputDocument oOutputDocumentTemp = new OutputDocument();
			oOutputDocumentTemp.FilterTripsList = nTripID.ToString();
			oOutputDocumentTemp.FillData();
			if (oOutputDocumentTemp.ErrorNumber == 0 && oOutputDocumentTemp.MainTable != null && oOutputDocumentTemp.MainTable.Rows.Count > 0)
			{
				DataView dv = new DataView(oOutputDocumentTemp.MainTable);
				DataTable dt = dv.ToTable(true, "PartnerTargetID", "DeliveryAddress");
				nPointQnt = dt.Rows.Count;
				Partner oPartner = new Partner();
				for (int i = 0; i < dt.Rows.Count; i++)
				{
					dr = dt.Rows[i];
                    // Старый метод получения длительности рейса
					//nDischargeMinutes += oPartner.CalcDischargeDuration((int?)dr["PartnerTargetID"]); 
				}
			}

            // Новый метод получения длительности рейса
            nDischargeMinutes = oTrip.CalcTripDuration(nTripID);

			nTripBrutto = nOutputsBrutto;
			nTripPallets = nOutputsPallets;
			nTripVolume = nOutputsVolume;
			txtOutputsBrutto.Text = nTripBrutto.ToString("## ###").Trim() + '/' + nCarBrutto.ToString("## ###").Trim();
			if (nCarBrutto != 0)
				nTemp = (double)nTripBrutto / (double)nCarBrutto * 100;
			else
				nTemp = 0;

			txtOutputsBruttoPercent.Text = nTemp.ToString("###").Trim();
			if (nTemp < 95)
			{
				if (nTemp == 0)
					txtOutputsBruttoPercent.BackColor = SystemColors.Control;
				else
					txtOutputsBruttoPercent.BackColor = Color.FromArgb(200, 250, 200);
			}
			else
			{
				if (nTemp >= 95 && nTemp <= 105)
					txtOutputsBruttoPercent.BackColor = Color.FromArgb(255, 255, 128);
				else
					txtOutputsBruttoPercent.BackColor = Color.FromArgb(250, 200, 200);
			}

			txtOutputsPallets.Text = nTripPallets.ToString("##.#") + '/' + nCarPallets.ToString("##.#");
			if (nCarPallets != 0)
				nTemp = (double)nTripPallets / (double)nCarPallets * 100;
			else
				nTemp = 0;
			if (nTemp < 95)
			{
				if (nTemp == 0)
					txtOutputsPalletsPercent.BackColor = SystemColors.Control;
				else
					txtOutputsPalletsPercent.BackColor = Color.FromArgb(200, 250, 200);
			}
			else
			{
				if (nTemp >= 95 && nTemp <= 105)
					txtOutputsPalletsPercent.BackColor = Color.FromArgb(255, 255, 128);
				else
					txtOutputsPalletsPercent.BackColor = Color.FromArgb(250, 200, 200);
			}
			txtOutputsPalletsPercent.Text = nTemp.ToString("###");

			txtOutputsVolume.Text = nTripVolume.ToString("##.#") + '/' + nCarVolume.ToString("###.#");
			if (nCarVolume != 0)
				nTemp = (double)nTripVolume / (double)nCarVolume * 100;
			else
				nTemp = 0;
			if (nTemp < 95)
			{
				if (nTemp == 0)
					txtOutputsVolumePercent.BackColor = SystemColors.Control;
				else
					txtOutputsVolumePercent.BackColor = Color.FromArgb(200, 250, 200);
			}
			else
			{
				if (nTemp >= 95 && nTemp <= 105)
					txtOutputsVolumePercent.BackColor = Color.FromArgb(255, 255, 128);
				else
					txtOutputsVolumePercent.BackColor = Color.FromArgb(250, 200, 200);
			}
			txtOutputsVolumePercent.Text = nTemp.ToString("###");
			
			//   Duration   - вместе для прихода и расхода
			decimal nHour = Math.Floor(nDischargeMinutes / 60);
			if (nHour == 0 && (nHour * 60 == nDischargeMinutes))
			{
				txtOutputsDuration.Text = "";
				txtOutputsDuration.BackColor = SystemColors.Control;
			}
			else
			{
				txtOutputsDuration.Text = nHour.ToString() + "ч " + (nDischargeMinutes - nHour * 60).ToString("00") + "мин";
				DataRow drT = oTrip.MainTable.Rows.Find(nTripID);
				if ((drT["MaxDurationMinutes"] != DBNull.Value) && ((int)drT["MaxDurationMinutes"] > 0))
				{
					if ((int)drT["MaxDurationMinutes"] < nDischargeMinutes)
						txtOutputsDuration.BackColor = Color.FromArgb(250, 200, 200);
					else
						txtOutputsDuration.BackColor = Color.FromArgb(200, 250, 200);
				} 
			}
			txtOutputsPointsQnt.Text = nPointQnt.ToString();
			txtOutputsDurationMinutes.Text = nDischargeMinutes.ToString();

/// приход
/// 
			nTripBrutto = nTripPallets = nTripVolume = nDischargeMinutes = nPointQnt = 0;
			nInputsBrutto = nInputsPallets = nInputsVolume = 0;

			for (int nI = 0; nI < oTrip.TablePutsInTrip.Rows.Count; nI++)
			{
				dr = oTrip.TablePutsInTrip.Rows[nI];
				if ((int?)dr["TripID"] == nTripID && dr["OutputID"] == DBNull.Value)
				{
					nInputsBrutto += (decimal)dr["Brutto"];
					nInputsPallets += (decimal)dr["PalletsQnt"];
					nInputsVolume += (decimal)dr["Volume"];
					//nPointQnt += (int)dr["PointsQnt"];
				}
			}
			// число точек: кол-во партнеров в заданиях 
			DataView dvI = new DataView(oTrip.TablePutsInTrip);
			dvI.RowFilter = "Isnull(OutputID,0) = 0";
			DataTable dtI = dvI.ToTable(true, "PartnerID");
			nPointQnt = dtI.Rows.Count;
			for (int i = 0; i < dtI.Rows.Count; i++)
			{
				dr = dtI.Rows[i];
//				nDischargeMinutes += oPartner.CalcDischargeDuration((int?)dr["PartnerID"]);
			}


			nTripBrutto = nInputsBrutto;
			nTripPallets = nInputsPallets;
			nTripVolume = nInputsVolume;
			txtInputsBrutto.Text = nTripBrutto.ToString("## ###").Trim() + '/' + nCarBrutto.ToString("## ###").Trim();
			if (nCarBrutto != 0)
				nTemp = (double)nTripBrutto / (double)nCarBrutto * 100;
			else
				nTemp = 0;

			txtInputsBruttoPercent.Text = nTemp.ToString("###").Trim();
			if (nTemp < 95)
			{
				if (nTemp == 0)
					txtInputsBruttoPercent.BackColor = SystemColors.Control;
				else
					txtInputsBruttoPercent.BackColor = Color.FromArgb(200, 250, 200);
			}
			else
			{
				if (nTemp >= 95 && nTemp <= 105)
					txtInputsBruttoPercent.BackColor = Color.FromArgb(255, 255, 128);
				else
					txtInputsBruttoPercent.BackColor = Color.FromArgb(250, 200, 200);
			}

			txtInputsPallets.Text = nTripPallets.ToString("##.#") + '/' + nCarPallets.ToString("##.#");
			if (nCarPallets != 0)
				nTemp = (double)nTripPallets / (double)nCarPallets * 100;
			else
				nTemp = 0;
			if (nTemp < 95)
			{
				if (nTemp == 0)
					txtInputsPalletsPercent.BackColor = SystemColors.Control;
				else
					txtInputsPalletsPercent.BackColor = Color.FromArgb(200, 250, 200);
			}
			else
			{
				if (nTemp >= 95 && nTemp <= 105)
					txtInputsPalletsPercent.BackColor = Color.FromArgb(255, 255, 128);
				else
					txtInputsPalletsPercent.BackColor = Color.FromArgb(250, 200, 200);
			}
			txtInputsPalletsPercent.Text = nTemp.ToString("###");

			txtInputsVolume.Text = nTripVolume.ToString("##.#") + '/' + nCarVolume.ToString("###.#");
			if (nCarVolume != 0)
				nTemp = (double)nTripVolume / (double)nCarVolume * 100;
			else
				nTemp = 0;
			if (nTemp < 95)
			{
				if (nTemp == 0)
					txtInputsVolumePercent.BackColor = SystemColors.Control;
				else
					txtInputsVolumePercent.BackColor = Color.FromArgb(200, 250, 200);
			}
			else
			{
				if (nTemp >= 95 && nTemp <= 105)
					txtInputsVolumePercent.BackColor = Color.FromArgb(255, 255, 128);
				else
					txtInputsVolumePercent.BackColor = Color.FromArgb(250, 200, 200);
			}
			txtInputsVolumePercent.Text = nTemp.ToString("###");
			//   Duration   - вместе для прихода и расхода
			nHour = Math.Floor(nDischargeMinutes / 60);
			if (nHour == 0 && (nHour * 60 == nDischargeMinutes))
			{
				txtInputsDuration.Text = "";
				txtInputsDuration.BackColor = SystemColors.Control;
			}
			else
			{
				txtInputsDuration.Text = nHour.ToString() + "ч " + (nDischargeMinutes - nHour * 60).ToString("00") + "мин";
				DataRow drT = oTrip.MainTable.Rows.Find(nTripID);
				if ((drT["MaxDurationMinutes"] != DBNull.Value) && ((int)drT["MaxDurationMinutes"] > 0))
				{
					if ((int)drT["MaxDurationMinutes"] < nDischargeMinutes)
						txtOutputsDuration.BackColor = Color.FromArgb(250, 200, 200);
					else
						txtOutputsDuration.BackColor = Color.FromArgb(200, 250, 200);
				} 
			}
			txtInputsPointsQnt.Text = nPointQnt.ToString();
			txtInputsDurationMinutes.Text = nDischargeMinutes.ToString();
			////
			if (nOutputsBrutto == 0)
				tabTripOutputsInfo.Enabled = false;
			else
				tabTripOutputsInfo.Enabled = true;

			if (nInputsBrutto == 0)
				tabTripInputsInfo.Enabled = false;
			else
				tabTripInputsInfo.Enabled = true;
		}

		private void ShowRestTotal()
		{
			decimal nBrutto = 0;
			decimal nPalletsQnt = 0;
			decimal nAmount = 0;
			int nPoints = 0;

			if (oTripsList.TablePutsInTrip != null && oTripsList.TablePutsInTrip.Rows.Count > 0)
			{
				string sOutputsList = "";
				DataRow dr;
				for (int nI = 0; nI < oTripsList.TablePutsInTrip.Rows.Count; nI++)
				{
					dr = oTripsList.TablePutsInTrip.Rows[nI];
					if ((dr["TripID"] == null || dr["TripID"] == DBNull.Value) &&
						(dr["InputID"] == null || dr["InputID"] == DBNull.Value))
					{
						nBrutto += (decimal)dr["Brutto"];
						nPalletsQnt += (decimal)dr["PalletsQnt"];
						nAmount += (decimal)dr["Amount"];
						sOutputsList += dr["ID"].ToString() + ","; 
					}
				}
				if (sOutputsList.Length > 0)
				{
					// число точек
					OutputDocument oOutputDocumentTemp = new OutputDocument();
					oOutputDocumentTemp.FilterOutputsList = sOutputsList;
					oOutputDocumentTemp.FillData();
					if (oOutputDocumentTemp.ErrorNumber == 0 && oOutputDocumentTemp.MainTable != null && oOutputDocumentTemp.MainTable.Rows.Count > 0)
					{
						DataView dv = new DataView(oOutputDocumentTemp.MainTable);
						DataTable dt = dv.ToTable(true, "PartnerTargetID", "DeliveryAddress");
						nPoints = dt.Rows.Count;
					}
				}
			}
			if (nBrutto != 0)
				txtRestBrutto.Text = nBrutto.ToString("### ### ###").Trim();
			else
				txtRestBrutto.Text = "";
			if (nPalletsQnt != 0)
				txtRestPalletsQnt.Text = nPalletsQnt.ToString("### ###.#").Trim();
			else
				txtRestPalletsQnt.Text = "";
			if (nAmount != 0)
				txtRestAmount.Text = nAmount.ToString("### ### ###").Trim();
			else
				txtRestAmount.Text = "";
			if (nPoints != 0)
				txtRestPoints.Text = nPoints.ToString("####").Trim();
			else
				txtRestPoints.Text = "";
		}

		private int CalcByOrder(int? nPartnerID, string cMode)
		{
			int nByOrder = 0;
			Output oOutput = new Output();
			Input oInput = new Input();
			dgvTripPuts.IsRestoring = true;
			DataRowView drvP = (DataRowView)dgvPuts.CurrentRow.DataBoundItem;
			RFMBindingSource bs = dgvTripPuts.GridSource;
			string cSort = bs.Sort;
			bs.Sort = "ByOrder asc";
			if (bs.Count > 0 )
			{
				bs.MoveLast();
				nByOrder = (int)((DataRowView)bs.Current)["ByOrder"];
				int nCount = 0;
				if (nPartnerID != null)
				{
					bs.Filter = "PartnerID =" + nPartnerID.ToString();
					nCount = 0;
					nCount = bs.Count;
					if (bs.Count > 0)
					{
						bs.MoveLast();
						nByOrder = (int)((DataRowView)bs.Current)["ByOrder"];
					}
					bs.RemoveFilter();
				}
				if ( (((DataRowView)bs.Current)["PartnerID"] == DBNull.Value) || (!chkJoinDocumentsInStorage.Checked) ||
				(chkJoinDocumentsInStorage.Checked && ((DataRowView)bs.Current)["PartnerID"]!= DBNull.Value) && (nCount == 0))
				{
					nByOrder = nByOrder + 1;
					if (nCount > 0 && (cMode.ToLower() == "output"))
					{
						int bsPosition = bs.Find("ByOrder", nByOrder);
						if (bsPosition > 0)
						{
							DataRowView drv;
							int nCurByOrder = nByOrder;
							bs.Position = bsPosition;
							for (int i = bsPosition; i < bs.Count; i++)
							{
								drv = (DataRowView)bs.Current;
								if ((drv["PartnerID"] != DBNull.Value) && ((int)drv["PartnerID"] != nPartnerID))
								{
									nCurByOrder++;
									drv["ByOrder"] = nCurByOrder;
									if (drv["InputID"] == DBNull.Value)
										oOutput.SaveByOrder((int)drv["ID"], (int)drv["ByOrder"]);
									else
										oInput.SaveByOrder((int)drv["ID"], (int)drv["ByOrder"]);
								}
								bs.MoveNext();	
							}
						}
					}
				}
			}
			else
				nByOrder = 1;
			if (chkJoinDocumentsInCar.Checked)
			{
				DataTable dt = (DataTable)bs.DataSource;
				DataRow dr = dt.NewRow();
				dr["ByOrder"] = nByOrder;
				if (nPartnerID != null)
					dr["PartnerID"] = nPartnerID;
				else
					dr["PartnerID"] = DBNull.Value;
				dr["Note"] = "";
				dr["PartnerName"] = "";
				dt.Rows.Add(dr);
			}
			dgvTripPuts.IsRestoring = false;
			bs.Sort = cSort;
			return (nByOrder);
		}

		#endregion Procedures

		#region InterFace

		private void cboTrips_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (cboTrips.SelectedValue != null)
			{
				DataRow droTrips = oTrip.MainTable.Rows.Find((int)cboTrips.SelectedValue);
				if (droTrips == null)
					return;

				if (droTrips["DateEnd"] != DBNull.Value || droTrips["DateBeg"] != DBNull.Value)
					pnlTrip.BackColor = Color.FromArgb(250, 200, 200);
				else
					pnlTrip.BackColor = Color.Transparent;
				dgvTripPuts_Restore();

                // Статистика водителя
                int driverEmployeeID = 0;
                if (Int32.TryParse(droTrips["DriverEmployeeID"].ToString(), out driverEmployeeID))
                {
                    DriverInfo(driverEmployeeID);
                }

				CarInfo((int)cboTrips.SelectedValue);
				ShowTripTotal((int)cboTrips.SelectedValue);

				gridPutsRowChange(null, dgvPuts);
			}
		}

		private void gridPutsRowChange(object sender, RFMDataGridView dg)
		{
			txtCustomInfo.Text = "";
			txtPartnerInfo.Text = "";
			lblPartnerInfo.Text = "Клиент";
			if (dg.Rows.Count > 0 && !(dg.IsStatusRow(dg.CurrentRow.Index)))
			{
				DataRowView drv = (DataRowView)dg.CurrentRow.DataBoundItem;
				if ((drv["PartnerID"] != DBNull.Value) && oPartner.ReFillOne((int)drv["PartnerID"]))
				{
					txtCustomInfo.Text = (string)drv["Note"];
					lblPartnerInfo.Text = "Клиент: " + (string)drv["PartnerName"];
					txtPartnerInfo.Text = oPartner.DeliveryAddress.Trim() + "\r\nПроезд: " + 
                        oPartner.DeliveryPassage.Trim() + 
						"\r\nПрием товаров: " + oPartner.TimeReceipt.Trim() + 
						"\r\nВремя работы: " + oPartner.TimeWork.Trim() + 
                        (oPartner.Gravity.Length > 0 ? "\r\nВажность: " + oPartner.Gravity : "");
                }
			}
		}


		private void tcReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcReports.CurrentPage.Name.ToLower() == "tabCars".ToUpper() && tabCars.IsNeedRestore)
			{
				tabCars_Restore();
				tabCars.IsNeedRestore = false;
			}
			if (tcReports.CurrentPage.Name.ToLower() == "tabZones".ToUpper() && tabZones.IsNeedRestore)
			{
				tabZones_Restore();
				tabZones.IsNeedRestore = false;
			}
		}

		private void dgvZones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvZones.DataSource == null)
				return;

			DataGridViewColumn dgvcColumn = dgvZones.Columns[e.ColumnIndex];
			string sColumnName = dgvcColumn.Name.ToUpper();

			// статусная строка
			if (dgvZones.IsStatusRow(e.RowIndex))
			{
				if (sColumnName.Contains("COLOR"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvZones.Rows[e.RowIndex]).DataBoundItem).Row;
			if (sColumnName.Contains("Color".ToUpper()))
			{
				if ((int)droRow["OutputsDocumentsCount"] == (int)droRow["OutputsDocumentsTripsCount"])
					e.Value = Properties.Resources.DotGreen;
				else
				{
					if ((int)droRow["OutputsDocumentsTripsCount"] > 0)
						e.Value = Properties.Resources.DotYellow;
					else
						e.Value = Properties.Resources.DotRed;
				}
			}

            // Удаление нулей
            if (sColumnName.Contains("Output".ToUpper()) || sColumnName.Contains("Input".ToUpper()))
            {
                decimal columnValue = -1;
                try { columnValue = Convert.ToDecimal(droRow[dgvcColumn.DataPropertyName]); }
                catch {}
                if (columnValue == (decimal)0.0) e.Value = "";
            }
		}

		private void tmrZonesTrips_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			if (LastGrid.CurrentRow == null ||
				LastGrid.IsStatusRow(LastGrid.CurrentRow.Index))
				return;

			if (LastGrid == dgvZones)
			{
				if (dgvZones.CurrentRow == null)
					return;
				int nZoneID = (int)dgvZones.Rows[dgvZones.CurrentRow.Index].Cells["dgvcZoneID"].Value;
				dgvZoneTrips_Restore(nZoneID);
			}
			else
			{
				if (dgvTrips.CurrentRow == null)
					return;
				int nTripID = (int)dgvTrips.CurrentRow.Cells["dgvcTripId"].Value;
				dgvInCar_Restore(nTripID);
			}
		}


		private void dgvTripPuts_CurrentRowChanged(object sender)
		{
			gridPutsRowChange(sender, dgvTripPuts);
			if (dgvTripPuts.RowCount < 2 || !chkPostern.Checked)
				btnMoveUp.Enabled = btnMoveDn.Enabled = false;
			else
				btnMoveUp.Enabled = btnMoveDn.Enabled = true;
			if (dgvTripPuts.CurrentRow.Index == dgvTripPuts.GridSource.Count - 1)
				btnMoveDn.Enabled = false;
			if (dgvTripPuts.CurrentRow.Index == 0)
				btnMoveUp.Enabled = false;
		}

		private void dgvPuts_CurrentRowChanged(object sender)
		{
			gridPutsRowChange(sender, dgvPuts);
		}

		private void dgvZones_CurrentRowChanged(object sender)
		{
			if (LastGrid == dgvZones)
			{
				if (dgvZones.IsLockRowChanged)
					return;
			}
			if (LastGrid == dgvInCar)
			{
				if (dgvInCar.IsLockRowChanged)
					return;
			}
			tmrRestore.Enabled = true;
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetButtonStatus();
			if (tcList.SelectedTab == tabTrips)
			{
				if (cboTrips.SelectedIndex == -1 && dgvPuts.RowCount == 0)
				{
					txtCustomInfo.Text = txtPartnerInfo.Text = "";
					lblPartnerInfo.Text = "Клиент";
				}

				pnlRest.Visible = true;
			}
			else
			{
				pnlRest.Visible = false; 
			}
		}

		private void SetButtonStatus()
		{
			switch (tcList.CurrentPage.Name.ToLower())
			{
				case "tabtrips":
					btnShowTrip.Enabled = btnCalcTrip.Enabled = btnApplyTrips.Enabled = btnApplyOneTrip.Enabled = true;
					btnMoveDn.Enabled = btnMoveUp.Enabled = false;
					btnMoveDn.Visible = btnMoveUp.Visible = true;
					break;
				default:
                    btnShowTrip.Enabled = btnCalcTrip.Enabled = btnApplyTrips.Enabled = btnApplyOneTrip.Enabled = false;
					btnMoveDn.Visible = btnMoveUp.Visible = false;
					break;
			}
		}

		private bool CheckPutToTrip()
		{
			if (dgvPuts.CurrentRow.Index < 0 || dgvPuts.CurrentRow == null)
				return (false);

			if (cboTrips.SelectedValue == null)
			{
				RFMMessage.MessageBoxInfo("Не выбран рейс!");
				return (false);
			}

			DataRowView drvP = (DataRowView)dgvPuts.CurrentRow.DataBoundItem;


			if (oTrip.IsPutInTrip(
                (Convert.IsDBNull(drvP["OutputID"])) ? null : (int?)drvP["OutputID"], 
                (Convert.IsDBNull(drvP["InputID"])) ? null : (int?)drvP["InputID"],
                (Convert.IsDBNull(drvP["CarTaskID"])) ? null : (int?)drvP["CarTaskID"])
                )
			{
				RFMMessage.MessageBoxError("Задание уже прикреплено к рейсу!");
				if (RFMMessage.MessageBoxYesNo("Перестроить список заданий?") == DialogResult.Yes)
					dgvPuts_Restore();
				return (false);
			}

			DataRow drT = oTrip.MainTable.Rows.Find((int)cboTrips.SelectedValue);

			if (drvP["InputID"] == DBNull.Value && (bool)drT["IsRentCar"])
			{
				OutputDocument oOutputDocument = new OutputDocument();
				oOutputDocument.FilterOutputsList = drvP["OutputID"].ToString();
				oOutputDocument.FillData();
				DataRow drOD;
				bool bWarrantNeed = false;
				for (int i = 0; i < oOutputDocument.MainTable.Rows.Count; i++)
				{
					drOD = oOutputDocument.MainTable.Rows[i];
					bWarrantNeed = (bool)drOD["PF_WarrantNeed"];
					if (bWarrantNeed)
						break;
				}
				if (bWarrantNeed &&
					RFMMessage.MessageBoxYesNo("Задание включает в себя заказ, требующий доверенность на получение денег. \n"
						+ "Для арендованных машин такая операция запрещена.\n"
						+ "ДОВЕРЕННОСТЬ ВЫПИСАНА НЕ БУДЕТ, ДЕНЕГ НЕ ПОЛУЧИМ!\n"
						+ "Все-таки распределить задание на арендованную машину?") == DialogResult.No)
					return (false);
			}

			if (drT == null)
				return (false);

			if (drT["DateEnd"] != DBNull.Value || drT["DateBeg"] != DBNull.Value)
			{
				RFMMessage.MessageBoxError("Машина уже уехала!");
				if (chkOnlyUnStartedTrips.Checked)
					cboTrips_Restore();
				return (false);
			}
			if (!Convert.IsDBNull(drT["ReadyForTripEnd"]) && (bool)drT["ReadyForTripEnd"])
			{
				RFMMessage.MessageBoxError("Рейс готов к окончанию!");
				return (false);
			}

			int nID, nTripID;
			cSystemIDList = "";
			decimal nThisBruttoI, nThisPalletsI, nThisVolumeI;
			decimal nThisBruttoO, nThisPalletsO, nThisVolumeO;
			nTripID = (int)cboTrips.SelectedValue;
			bool lClickInput, lClickOutput;
			lClickInput = lClickOutput = false;

			nID = (int)drvP["ID"];
			int? nPartnerID = (drvP["PartnerID"] == DBNull.Value) ? null : (int?)drvP["PartnerID"];

			nThisBruttoO = nThisPalletsO = nThisVolumeO = 0;
			nThisBruttoI = nThisPalletsI = nThisVolumeI = 0;

			if (drvP["PartnerID"] != DBNull.Value && (chkJoinDocumentsInCar.Checked))
			{
				foreach (DataRow dr in oTripsList.TablePutsInTrip.Rows)
				{
					if (dr["PartnerID"] != DBNull.Value && (int)dr["PartnerID"] == nPartnerID && dr["TripID"] == DBNull.Value)
					{
						if (dr["InputID"] == DBNull.Value)
						{
							nThisBruttoO = nThisBruttoO + (decimal)dr["Brutto"];
							nThisPalletsO = nThisPalletsO + (decimal)dr["PalletsQnt"];
							nThisVolumeO = nThisVolumeO + (decimal)dr["Volume"];
							lClickOutput = true;
						}
						else
						{
							nThisBruttoI = nThisBruttoI + (decimal)dr["Brutto"];
							nThisPalletsI = nThisPalletsI + (decimal)dr["PalletsQnt"];
							nThisVolumeI = nThisVolumeI + (decimal)dr["Volume"];
							lClickInput = true;
						}
					}
				}
			}
			else
			{
				if (drvP["InputID"] == DBNull.Value)
				{
					nThisBruttoO = (decimal)drvP["Brutto"];
					nThisPalletsO = (decimal)drvP["PalletsQnt"];
					nThisVolumeO = (decimal)drvP["Volume"];
					lClickOutput = true;
				}
				else
				{
					nThisBruttoI = (decimal)drvP["Brutto"];
					nThisPalletsI = (decimal)drvP["PalletsQnt"];
					nThisVolumeI = (decimal)drvP["Volume"];
					lClickInput = true;
				}
			}

			//		проверки начались
			if (!radMaxPointsQntSkip.Checked && drvP["PartnerID"] != DBNull.Value)
			{
				if (txtOutputsPointsQnt.Text.Length == 0)
					txtOutputsPointsQnt.Text = "0";
				int nPointsQnt = Convert.ToInt32(txtOutputsPointsQnt.Text) + 1;
				if ((nPointsQnt > (int)drT["MaxPointsQnt"]) && lClickOutput)
				{
					if (radMaxPointsQntBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: cлишком много адресов доставки для выбранной машины.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Отгрузка: cлишком много адресов доставки для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
				nPointsQnt = Convert.ToInt32(txtInputsPointsQnt.Text) + 1;
				if ((nPointsQnt > (int)drT["MaxPointsQnt"]) && lClickInput)
				{
					if (radMaxPointsQntBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: cлишком много адресов доставки для выбранной машины.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Поставка: cлишком много адресов доставки для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
			}

			// Максимальная продолжительность
			if (!radMaxDurationSkip.Checked && drvP["PartnerID"] != DBNull.Value
					&& drT["MaxDurationMinutes"] != DBNull.Value && (int)drT["MaxDurationMinutes"] > 0)
			{
				if (((Convert.ToInt32(txtOutputsDurationMinutes.Text) +
						oPartner.CalcDischargeDuration(nPartnerID)) > (int)drT["MaxDurationMinutes"]) && lClickOutput)
				{

					if (radMaxDurationBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышена максимальная продолжительность маршрута для выбранной машины.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Отгрузка: превышена максимальная продолжительность маршрута для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
				if (((Convert.ToInt32(txtInputsDurationMinutes.Text) +
					oPartner.CalcDischargeDuration(nPartnerID)) > (int)drT["MaxDurationMinutes"]) && lClickInput)
				{

					if (radMaxDurationBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышена максимальная продолжительность маршрута для выбранной машины.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Поставка: превышена максимальная продолжительность маршрута для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
			}

			//		разрешение на проезд
			if (!radPermitLevelControlSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["PermitLevelValue"] != DBNull.Value)
			{
				if ((int)drT["PermitLevelValue"] > (int)drvP["PermitLevelValue"])
				{
					if (radPermitLevelControlBan.Checked)
					{
						RFMMessage.MessageBoxError("Разрешения на проезд рейса недостаточно для данного заказа.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Разрешения на проезд рейса недостаточно для данного заказа.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
			}

			// - легковая машина
			if (!radPassCarSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["PassengerCarOnly"] != DBNull.Value)
			{
				if ((bool)drvP["PassengerCarOnly"] && !(bool)drT["IsPassengerCar"])
				{
					if (radPassCarBan.Checked)
					{
						RFMMessage.MessageBoxError("Заказ предполагает легковую машину.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Заказ предполагает легковую машину.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
			}

			//			- наличие задней двери
			if (!radPosternSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["PosternOnly"] != DBNull.Value)
			{
				if ((bool)drvP["PosternOnly"] && !(bool)drT["IsPostern"])
				{
					if (radPosternBan.Checked)
					{
						RFMMessage.MessageBoxError("Заказ предполагает машину c задней дверью.");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Заказ предполагает машину с задней дверью.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
			}

			//			- наличие подъемника/лопаты
			if (!radLiftSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["LoadLiftOnly"] != DBNull.Value)
			{
				if ((bool)drvP["LoadLiftOnly"] && !(bool)drT["IsLoadLift"])
				{
					if (radLiftBan.Checked)
					{
						RFMMessage.MessageBoxError("Заказ предполагает машину с подъемником(лопатой).");
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Заказ предполагает машину с подъемником(лопатой).\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return (false);
					}
				}
			}

			//			- контроль по весу
			string sWarningsText;
			if (!radWeightSkip.Checked)
			{
				if ((nOutputsBrutto + nThisBruttoO > nCarBrutto) && lClickOutput)
				{
					if (radWeightBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышена грузоподъемность машины.");
						return (false);
					}
					else
					{
						sWarningsText = "Отгрузка: Допустимый вес превышен" +
							((Math.Round(nOutputsBrutto + nThisBruttoO - nCarBrutto, 0) != 0)
								? " на " + (nOutputsBrutto + nThisBruttoO - nCarBrutto).ToString("###0") + " кг"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return (false);
					}
				}
				if ((nInputsBrutto + nThisBruttoI > nCarBrutto) && lClickInput)
				{
					if (radWeightBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышена грузоподъемность машины.");
						return (false);
					}
					else
					{
						sWarningsText = "Поставка: Допустимый вес превышен" +
							((Math.Round(nInputsBrutto + nThisBruttoI - nCarBrutto, 0) != 0)
								? " на " + (nInputsBrutto + nThisBruttoI - nCarBrutto).ToString("###0") + " кг"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return (false);
					}
				}
			}

			//			- контроль п объему
			if (!radVolumeSkip.Checked)
			{
				if ((nOutputsVolume + nThisVolumeO > nCarVolume) && lClickOutput)
				{
					if (radVolumeBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышен объем машины.");
						return (false);
					}
					else
					{
						sWarningsText = "Отгрузка: допустимый объем превышен" +
							((Math.Round(nOutputsVolume + nThisVolumeO - nCarVolume, 1) != 0)
								? " на " + (nOutputsVolume + nThisVolumeO - nCarVolume).ToString("###0.0") + " м3"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return (false);
					}
				}
				if ((nInputsVolume + nThisVolumeI > nCarVolume) && lClickInput)
				{
					if (radVolumeBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышен объем машины.");
						return (false);
					}
					else
					{
						sWarningsText = "Поставка: допустимый объем превышен" +
							((Math.Round(nInputsVolume + nThisVolumeI - nCarVolume, 1) != 0)
								? " на " + (nInputsVolume + nThisVolumeI - nCarVolume).ToString("###0.0") + " м3"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return (false);
					}
				}
			}

			//			- контроль по паллетности
			if (!radPalletsSkip.Checked)
			{
				if ((nOutputsPallets + nThisPalletsO > nCarPallets) && lClickOutput)
				{
					if (radPalletsBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышена допустимая паллетность машины.");
						return (false);
					}
					else
					{
						sWarningsText = "Отгрузка: допустимое количество паллет превышено" +
								((Math.Round(nOutputsPallets + nThisPalletsO - nCarPallets, 1) != 0)
									? " на " + (nOutputsPallets + nThisPalletsO - nCarPallets).ToString("###0.0")
									: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return (false);
					}
				}
				if ((nInputsPallets + nThisPalletsI > nCarPallets) && lClickInput)
				{
					if (radPalletsBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышена допустимая паллетность машины.");
						return (false);
					}
					else
					{
						sWarningsText = "Поставка: допустимое количество паллет превышено" +
								((Math.Round(nInputsPallets + nThisPalletsI - nCarPallets, 1) != 0)
									? " на " + (nInputsPallets + nThisPalletsI - nCarPallets).ToString("###0.0")
									: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return (false);
					}
				}
			}
			return (true);
		}
	
		#endregion InterFace

		#region DoubleClick

		private void dgvPuts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (dgvPuts.CurrentRow == null)
				return;

			if (cboTrips.SelectedValue == null)
			{
				RFMMessage.MessageBoxInfo("Не выбран рейс!");
				return;
			}

			DataRowView drvP = (DataRowView)dgvPuts.CurrentRow.DataBoundItem;

			if (oTrip.IsPutInTrip( 
                (Convert.IsDBNull(drvP["OutputID"])) ? null : (int?)drvP["OutputID"], 
                (Convert.IsDBNull(drvP["InputID"])) ? null : (int?)drvP["InputID"],
                (Convert.IsDBNull(drvP["CarTaskID"])) ? null : (int?)drvP["CarTaskID"])
                )
			{
				RFMMessage.MessageBoxError("Задание уже прикреплено к рейсу!");
				if (RFMMessage.MessageBoxYesNo("Перестроить список заданий?") == DialogResult.Yes)
					dgvPuts_Restore();
				return;
			}

			DataRow drT = oTrip.MainTable.Rows.Find((int)cboTrips.SelectedValue);
			
			if ( drvP["OutputID"] != DBNull.Value && (bool)drT["IsRentCar"])
			{
				OutputDocument oOutputDocument = new OutputDocument();
				oOutputDocument.FilterOutputsList = drvP["OutputID"].ToString();
				oOutputDocument.FillData();
				DataRow drOD;
				bool bWarrantNeed = false;
				for (int i = 0; i < oOutputDocument.MainTable.Rows.Count; i++)
				{
					drOD = oOutputDocument.MainTable.Rows[i];
					bWarrantNeed = (bool)drOD["PF_WarrantNeed"];
					if (bWarrantNeed) 
						break;
				}
				if (bWarrantNeed &&
					RFMMessage.MessageBoxYesNo("Задание включает в себя заказ, требующий доверенность на получение денег. \n" 
						+ "Для арендованных машин такая операция запрещена.\n" 
						+ "ДОВЕРЕННОСТЬ ВЫПИСАНА НЕ БУДЕТ, ДЕНЕГ НЕ ПОЛУЧИМ!\n"
						+ "Все-таки распределить задание на арендованную машину?") == DialogResult.No)
						return;
			}

			if (drT == null)
				return;

			if (drT["DateEnd"] != DBNull.Value || drT["DateBeg"] != DBNull.Value)
			{
				RFMMessage.MessageBoxError("Машина уже уехала!");
				if (chkOnlyUnStartedTrips.Checked)
					cboTrips_Restore();
				return;
			}
            if (!Convert.IsDBNull(drT["ReadyForTripEnd"]) && (bool)drT["ReadyForTripEnd"])
            {
   				RFMMessage.MessageBoxError("Рейс готов к окончанию!");
				return;
            }

			int nID, nTripID;
			cSystemIDList = "";
			decimal nThisBruttoI, nThisPalletsI, nThisVolumeI;
			decimal nThisBruttoO, nThisPalletsO, nThisVolumeO;
			nTripID = (int)cboTrips.SelectedValue;
			bool lClickInput, lClickOutput;
			lClickInput = lClickOutput = false;

			nID = (int)drvP["ID"];
			int? nPartnerID = (drvP["PartnerID"] == DBNull.Value) ? null : (int?)drvP["PartnerID"];

			nThisBruttoO = nThisPalletsO = nThisVolumeO = 0;
			nThisBruttoI = nThisPalletsI = nThisVolumeI = 0;

			if (drvP["PartnerID"] != DBNull.Value && (chkJoinDocumentsInCar.Checked))
			{
				foreach (DataRow dr in oTripsList.TablePutsInTrip.Rows)
				{
					if (dr["PartnerID"]!= DBNull.Value && (int)dr["PartnerID"] == nPartnerID && dr["TripID"] == DBNull.Value)
					{
						cSystemIDList = cSystemIDList + dr["SystemID"].ToString() + ",";
						if (drvP["InputID"] == DBNull.Value)
						{
							nThisBruttoO = nThisBruttoO + (decimal)dr["Brutto"];
							nThisPalletsO = nThisPalletsO + (decimal)dr["PalletsQnt"];
							nThisVolumeO = nThisVolumeO + (decimal)dr["Volume"];
							lClickOutput = true;
						}
						else
						{
							nThisBruttoI = nThisBruttoI + (decimal)dr["Brutto"];
							nThisPalletsI = nThisPalletsI + (decimal)dr["PalletsQnt"];
							nThisVolumeI = nThisVolumeI + (decimal)dr["Volume"];
							lClickInput = true;
						}
					}
				}
			}
			else
			{
				cSystemIDList = "";
				if (drvP["OutputID"] != DBNull.Value)
				{
					nThisBruttoO = (decimal)drvP["Brutto"];
					nThisPalletsO = (decimal)drvP["PalletsQnt"];
					nThisVolumeO = (decimal)drvP["Volume"];
					lClickOutput = true;
				}
                if (drvP["InputID"] != DBNull.Value)
                {
					nThisBruttoI = (decimal)drvP["Brutto"];
					nThisPalletsI = (decimal)drvP["PalletsQnt"];
					nThisVolumeI = (decimal)drvP["Volume"];
					lClickInput = true;
				}
			}

			// проверки начались
            if (!radMaxPointsQntSkip.Checked && drvP["PartnerID"] != DBNull.Value)
			{
				if (txtOutputsPointsQnt.Text.Length == 0)
					txtOutputsPointsQnt.Text = "0";
				int nPointsQnt = Convert.ToInt32(txtOutputsPointsQnt.Text) + 1;
				if ((nPointsQnt > (int)drT["MaxPointsQnt"]) && lClickOutput)
				{
					if (radMaxPointsQntBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: cлишком много адресов доставки для выбранной машины.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Отгрузка: cлишком много адресов доставки для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
				nPointsQnt = Convert.ToInt32(txtInputsPointsQnt.Text) + 1;
				if ((nPointsQnt > (int)drT["MaxPointsQnt"]) && lClickInput)
				{
					if (radMaxPointsQntBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: cлишком много адресов доставки для выбранной машины.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Поставка: cлишком много адресов доставки для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
			}

			// Максимальная продолжительность
			if (!radMaxDurationSkip.Checked && drvP["PartnerID"] != DBNull.Value
					&& drT["MaxDurationMinutes"] != DBNull.Value && (int)drT["MaxDurationMinutes"] > 0 )
			{
				if (((Convert.ToInt32(txtOutputsDurationMinutes.Text) + 
						oPartner.CalcDischargeDuration(nPartnerID)) > (int)drT["MaxDurationMinutes"]) && lClickOutput)
				{

					if (radMaxDurationBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышена максимальная продолжительность маршрута для выбранной машины.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Отгрузка: превышена максимальная продолжительность маршрута для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
				if (((Convert.ToInt32(txtInputsDurationMinutes.Text) + 
					oPartner.CalcDischargeDuration(nPartnerID)) > (int)drT["MaxDurationMinutes"]) && lClickInput)
				{

					if (radMaxDurationBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышена максимальная продолжительность маршрута для выбранной машины.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Поставка: превышена максимальная продолжительность маршрута для выбранной машины.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
			}

			//		разрешение на проезд
			if (!radPermitLevelControlSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["PermitLevelValue"] != DBNull.Value)
			{
				if ((int)drT["PermitLevelValue"] > (int)drvP["PermitLevelValue"])
				{
					if (radPermitLevelControlBan.Checked)
					{
						RFMMessage.MessageBoxError("Разрешения на проезд рейса недостаточно для данного заказа.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Разрешения на проезд рейса недостаточно для данного заказа.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
			}

			// - легковая машина
            if (!radPassCarSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["PassengerCarOnly"] != DBNull.Value)
			{
				if ((bool)drvP["PassengerCarOnly"] && !(bool)drT["IsPassengerCar"])
				{
					if (radPassCarBan.Checked)
					{
						RFMMessage.MessageBoxError("Заказ предполагает легковую машину.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Заказ предполагает легковую машину.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
			}

			// - наличие задней двери
            if (!radPosternSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["PosternOnly"] != DBNull.Value)
			{
				if ((bool)drvP["PosternOnly"] && !(bool)drT["IsPostern"])
				{
					if (radPosternBan.Checked)
					{
						RFMMessage.MessageBoxError("Заказ предполагает машину c задней дверью.");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Заказ предполагает машину с задней дверью.\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
			}

			// - наличие подъемника/лопаты
            if (!radLiftSkip.Checked && drvP["PartnerID"] != DBNull.Value && drvP["LoadLiftOnly"] != DBNull.Value)
			{
				if ((bool)drvP["LoadLiftOnly"] && !(bool)drT["IsLoadLift"])
				{
					if (radLiftBan.Checked)
					{
						RFMMessage.MessageBoxError("Заказ предполагает машину с подъемником(лопатой).");
						return;
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Заказ предполагает машину с подъемником(лопатой).\n" +
							"Все-таки продолжить?") != DialogResult.Yes)
							return;
					}
				}
			}

			// - контроль по весу
			string sWarningsText;
			if (!radWeightSkip.Checked)
			{
				if ((nOutputsBrutto + nThisBruttoO > nCarBrutto) && lClickOutput)
				{
					if (radWeightBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышена грузоподъемность машины.");
						return;
					}
					else
					{
						sWarningsText = "Отгрузка: Допустимый вес превышен" +
							((Math.Round(nOutputsBrutto + nThisBruttoO - nCarBrutto, 0) != 0)
								? " на " + (nOutputsBrutto + nThisBruttoO - nCarBrutto).ToString("###0") + " кг"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return;
					}
				}
				if ((nInputsBrutto + nThisBruttoI > nCarBrutto) && lClickInput)
				{
					if (radWeightBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышена грузоподъемность машины.");
						return;
					}
					else
					{
						sWarningsText = "Поставка: Допустимый вес превышен" +
							((Math.Round(nInputsBrutto + nThisBruttoI - nCarBrutto, 0) != 0)
								? " на " + (nInputsBrutto + nThisBruttoI - nCarBrutto).ToString("###0") + " кг"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return;
					}
				}
			}

			// - контроль по объему
			if (!radVolumeSkip.Checked)
			{
				if ((nOutputsVolume + nThisVolumeO > nCarVolume) && lClickOutput)
				{
					if (radVolumeBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышен объем машины.");
						return;
					}
					else
					{
						sWarningsText = "Отгрузка: допустимый объем превышен" +
							((Math.Round(nOutputsVolume + nThisVolumeO - nCarVolume, 1) != 0)
								? " на " + (nOutputsVolume + nThisVolumeO - nCarVolume).ToString("###0.0") + " м3"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return;
					}
				}
				if ((nInputsVolume + nThisVolumeI > nCarVolume) && lClickInput)
				{
					if (radVolumeBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышен объем машины.");
						return;
					}
					else
					{
						sWarningsText = "Поставка: допустимый объем превышен" +
							((Math.Round(nInputsVolume + nThisVolumeI - nCarVolume, 1) != 0)
								? " на " + (nInputsVolume + nThisVolumeI - nCarVolume).ToString("###0.0") + " м3"
								: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return;
					}
				}
			}

			// - контроль по паллетности
			if (!radPalletsSkip.Checked)
			{
				if ((nOutputsPallets + nThisPalletsO > nCarPallets) && lClickOutput)
				{
					if (radPalletsBan.Checked)
					{
						RFMMessage.MessageBoxError("Отгрузка: превышена допустимая паллетность машины.");
						return;
					}
					else
					{
						sWarningsText = "Отгрузка: допустимое количество паллет превышено" +
								((Math.Round(nOutputsPallets + nThisPalletsO - nCarPallets, 1) != 0)
									? " на " + (nOutputsPallets + nThisPalletsO - nCarPallets).ToString("###0.0")
									: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return;
					}
				}
				if ((nInputsPallets + nThisPalletsI > nCarPallets) && lClickInput)
				{
					if (radPalletsBan.Checked)
					{
						RFMMessage.MessageBoxError("Поставка: превышена допустимая паллетность машины.");
						return;
					}
					else
					{
						sWarningsText = "Поставка: допустимое количество паллет превышено" +
								((Math.Round(nInputsPallets + nThisPalletsI - nCarPallets, 1) != 0)
									? " на " + (nInputsPallets + nThisPalletsI - nCarPallets).ToString("###0.0")
									: "") + ".\n" +
							"Все-таки продолжить?";
						if (RFMMessage.MessageBoxYesNo(sWarningsText) != DialogResult.Yes)
							return;
					}
				}
			}
			//   проверки закончились
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);
			Input oInput = new Input();
			Output oOutput = new Output();
            CarTask oCarTask = new CarTask();

			bool bSuccess = true;
			if (cSystemIDList.Split(',').Length > 1)  
			{
				foreach (DataRow dr in oTripsList.TablePutsInTrip.Rows)
				{
					bSuccess = true;
					if (dr["PartnerID"] != DBNull.Value && (int)dr["PartnerID"] == nPartnerID && dr["TripID"] == DBNull.Value)
					{
                        if (dr["CarTaskID"] != DBNull.Value)
                        {
                            if (oCarTask.ToTrip((int)dr["CarTaskID"], nTripID))
                            {
                            }
                            else
                                bSuccess = false;
                        }
                        else if (dr["OutputID"] != DBNull.Value)
						{
							if (oOutput.ToTrip((int)dr["OutputID"], nTripID))
							{
								if ((bool)drT["IsPostern"])
									oOutput.SaveByOrder((int)dr["ID"], CalcByOrder(nPartnerID, "Output"));
								else
									oOutput.SaveByOrder((int)dr["ID"], 1);
							}
							else
								bSuccess = false;
						}
						else
						{
							if (oInput.ToTrip((int)dr["InputID"], nTripID))
							{
								if ((bool)drT["IsPostern"])
									oInput.SaveByOrder((int)dr["ID"], CalcByOrder(nPartnerID, "Input"));
								else
									oInput.SaveByOrder((int)dr["ID"], 1);
							}
							else
								bSuccess = false;
						}
						if (bSuccess)
						{
							dr["TripID"] = nTripID;
							dr["SentToWMS"] = false;
						}
					}
				}
			}
			else
			{
                if (drvP["CarTaskID"] != DBNull.Value)
                {
                    if (oCarTask.ToTrip((int)drvP["CarTaskID"], nTripID))
                    {
                    }
                    else
                        bSuccess = false;
                }
                else if (drvP["OutputID"] != DBNull.Value)
				{
					if (oOutput.ToTrip((int)drvP["OutputID"], nTripID))
						oOutput.SaveByOrder((int)drvP["ID"], CalcByOrder(nPartnerID, "Output"));
					else
						bSuccess = false;
				}
				else
				{
					if (oInput.ToTrip((int)drvP["InputID"], nTripID))
						oInput.SaveByOrder((int)drvP["ID"], CalcByOrder(nPartnerID, "Input"));
					else
						bSuccess = false;
				}
				if (bSuccess)	
				{
					((DataRowView)dgvPuts.CurrentRow.DataBoundItem)["TripID"] = nTripID;
					((DataRowView)dgvPuts.CurrentRow.DataBoundItem)["SentToWMS"] = false;
				}
			}
			dgvPuts.CommitChanges();
			dgvTripPuts_Restore();
			ShowRestTotal();
			ShowTripTotal(nTripID);
			gridPutsRowChange(null, dgvPuts);
			if (dgvPuts.Rows.Count > 0)
			{
				if (dgvPuts.Rows.Count > e.RowIndex)
					dgvPuts.CurrentCell = dgvPuts.Rows[e.RowIndex].Cells[e.ColumnIndex];
				else
					dgvPuts.CurrentCell = dgvPuts.Rows[dgvPuts.Rows.Count - 1].Cells[e.ColumnIndex];
			}
			tabList.IsNeedRestore = true;
			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
 
 		}

		private void dgvTripPuts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex < 0 || dgvTripPuts.IsStatusRow(e.RowIndex))
				return;
			
			if (cboTrips.SelectedValue == null)
				return;

			int nTripID = (int)cboTrips.SelectedValue;

			DataRow drT = oTrip.MainTable.Rows.Find((int)cboTrips.SelectedValue);
			if (drT == null)
				return;

            if ((bool)drT["IsConfirmed"])
            {
                RFMMessage.MessageBoxError("Рейс подтвержден!");
                return;
            }

			if (drT["DateEnd"] != DBNull.Value || drT["DateBeg"] != DBNull.Value)
			{
				RFMMessage.MessageBoxError("Машина уже уехала!");
				return;
			}

			bool bIsPostern = (bool)drT["IsPostern"];

			DataRowView drvTP = (DataRowView)dgvTripPuts.CurrentRow.DataBoundItem;

            //if (!bIsPostern && drvTP["PartnerID"] == DBNull.Value)
			//{
			//   RFMMessage.MessageBoxError("Невозможно...");
			//   return;
			//}
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);
			int nID = (int)drvTP["ID"];
			//bool bOutput = (drvTP["InputID"] == DBNull.Value);
            String sMode = (drvTP["CarTaskID"] != DBNull.Value ? "$" : (drvTP["InputID"] != DBNull.Value ? "I" : "O"));
			Output oOutput = new Output();
			Input  oInput  = new Input();
            CarTask oCarTask = new CarTask();

			bool bSucces = true;
			if (!chkJoinDocumentsInCar.Checked || drvTP["PartnerID"] == DBNull.Value)
			{
				if (drvTP["CarTaskID"] != DBNull.Value)
				{
					if (!oCarTask.UnToTrip(nID))
						bSucces = false;
				}
				else if (drvTP["OutputID"] != DBNull.Value)
				{
					if (!oOutput.UnToTrip(nID))
						bSucces = false;
				}
				else
				{
					if (!oInput.UnToTrip(nID))
						bSucces = false;
				}
				if (bSucces)
				{
					foreach (DataRow dr in oTripsList.TablePutsInTrip.Rows)
					{
						/*if ((bOutput && (dr["InputID"] == DBNull.Value) && ((int)dr["ID"] == nID)) || 
							(!bOutput && (dr["OutputID"] == DBNull.Value) && ((int)dr["ID"] == nID)))*/
						if ((sMode.Equals("$") && (dr["CarTaskID"] != DBNull.Value) && ((int)dr["ID"] == nID)) || 
							(sMode.Equals("O") && (dr["OutputID"] != DBNull.Value) && ((int)dr["ID"] == nID)) ||
							(sMode.Equals("I") && (dr["InputID"] != DBNull.Value) && ((int)dr["ID"] == nID))
                            )
						{	
							dr["TripID"] = DBNull.Value;
							dr["ByOrder"] = 0;
							break;
						}
					}
				}
			}
			else
			{
				int nPartnerID = (int)drvTP["PartnerID"];		
				foreach (DataRow dr in oTrip.TablePutsInTrip.Rows)
    		    {
					if (dr["PartnerID"] != DBNull.Value && (int)dr["PartnerID"] == nPartnerID && dr["TripID"] != DBNull.Value)
					{
						bSucces = true;
                        if (dr["TripID"] != DBNull.Value)
                        {
                            if (dr["CarTaskID"] != DBNull.Value)
                            {
                                if (!oCarTask.UnToTrip((int)dr["ID"]))
									bSucces = false;
                            }
                            else if (dr["OutputID"] != DBNull.Value)
                            {
                                if (!oOutput.UnToTrip((int)dr["ID"]))
									bSucces = false;
                            }
                            else
                            {
                                if (!oInput.UnToTrip((int)dr["ID"]))
									bSucces = false;
                            }
                        }
						if (bSucces)
						{
							foreach (DataRow drA in oTripsList.TablePutsInTrip.Rows)
							{
								if (drA["ID"] != DBNull.Value)
								{
									/*if ((drA["InputID"] == DBNull.Value && (int)drA["OutputID"] == (int)dr["ID"]) ||
										(drA["OutputID"] == DBNull.Value && (int)drA["InputID"] == (int)dr["ID"])
                                        )*/
									if ((drA["CarTaskID"] != DBNull.Value && (int)drA["CarTaskID"] == (int)dr["ID"]) ||
										(drA["OutputID"] != DBNull.Value && (int)drA["OutputID"] == (int)dr["ID"] ||
										(drA["InputID"] != DBNull.Value && (int)drA["InputID"] == (int)dr["ID"]))
                                        )
									{
										drA["TripID"] = DBNull.Value;
										drA["ByOrder"] = 0;
										break;
									}
								}
							}
						}
                    }
			    }
			}
			dgvPuts.CommitChanges();
			dgvTripPuts_Restore();
			//  пересчет ByOrder
            //	переполучили источник нижнего грида
			if (bIsPostern)
			{
				int nByOrder = 0;
				if (chkJoinDocumentsInStorage.Checked)
				{
					DataRowView drv;
					DataRow dr;
					int nForIndex = -1;
					oTrip.TablePutsInTrip.Columns.Add("ForIndex", Type.GetType("System.Int32"));
					for (int i = 0; i < oTrip.TablePutsInTrip.Rows.Count; i++)
					{
						dr = oTrip.TablePutsInTrip.Rows[i];
						dr["ForIndex"] = (int)dr["ByOrder"];
					}
					string cSort = oTrip.TablePutsInTrip.DefaultView.Sort;
					oTrip.TablePutsInTrip.DefaultView.Sort = "ForIndex";
					for (int i = 0; i < oTrip.TablePutsInTrip.DefaultView.Count; i++)
					{
						drv = oTrip.TablePutsInTrip.DefaultView[i];
						if ((int)drv["ForIndex"] == nForIndex)
						{
							if (drv["OutputID"] != DBNull.Value)
								oOutput.SaveByOrder((int)drv["ID"], nByOrder);
							else if (drv["InputID"] != DBNull.Value)
								oInput.SaveByOrder((int)drv["ID"], nByOrder);
						}
						else
						{
							nByOrder++;
							nForIndex = (int)drv["ForIndex"];
							if (drv["OutputID"] != DBNull.Value)
								oOutput.SaveByOrder((int)drv["ID"], nByOrder);
							else if (drv["InputID"] != DBNull.Value)
								oInput.SaveByOrder((int)drv["ID"], nByOrder);
						}
					}
					oTrip.TablePutsInTrip.DefaultView.Sort = cSort;
					oTrip.TablePutsInTrip.Columns.Remove("ForIndex");
				}
				else
				{
					DataRow dr;
					for (int _i = 0; _i < dvTripPuts.Count; _i++)
					{
						dr = dvTripPuts[_i].Row;
						nByOrder++;
						if (dr["OutputID"] != DBNull.Value)
							oOutput.SaveByOrder((int)dr["ID"], nByOrder);
						else if (dr["InputID"] != DBNull.Value)
							oInput.SaveByOrder((int)dr["ID"], nByOrder);
					}
				}
			}
			ShowRestTotal();
			ShowTripTotal((int)cboTrips.SelectedValue);
			dgvTripPuts_Restore();
			if (dgvTripPuts.Rows.Count > 0)
			{
				if (dgvTripPuts.Rows.Count > e.RowIndex)
					dgvTripPuts.CurrentCell = dgvTripPuts.Rows[e.RowIndex].Cells[e.ColumnIndex];
				else
					dgvTripPuts.CurrentCell = dgvTripPuts.Rows[dgvTripPuts.Rows.Count - 1].Cells[e.ColumnIndex];
			}
			tabList.IsNeedRestore = true;
			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
		}

		#endregion DoubleClick

		#region CellFormatting

		private void dgvPuts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			// используется для Puts, Inputs и Outputs 

			RFMDataGridView dgv = (RFMDataGridView)sender;

			if (dgv.DataSource == null)
				return;

			// статусная строка
			if (dgv.IsStatusRow(e.RowIndex))
			{
				if (dgv.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)dgv.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = dgv.Columns[e.ColumnIndex];
			if ( r["ID"] == DBNull.Value)
				return;

			string sColumnName = c.Name.ToUpper();

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

			if (sColumnName.Contains("TypeImage".ToUpper()))
			{
                if (r["Type"].ToString() == "$")
				{
					e.Value = Properties.Resources.Car_Red;
				}
                else if (r["Type"].ToString() == "I")
				{
					e.Value = Properties.Resources.Plus;
				}
				else
				{
					e.Value = Properties.Resources.Minus;
				}
			}

			if (sColumnName.Contains("ReadyForWMSImage".ToUpper()))
			{
				if ((bool)r["ReadyForWMS"])
				{
					if ((bool)r["IsConfirmed"])
					{
						e.Value = Properties.Resources.Plain_GD;
					}
                    else
                    {
                        if (r["Type"].ToString() == "$")
                        {
                            e.Value = Properties.Resources.Empty;
                        }
                        else if (r["Type"].ToString() == "O" && r["DatePick"].ToString().Length > 0)
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
                                e.Value = Properties.Resources.Plain_Y;
                            }
                        }
                    }
				}
				else
				{
					e.Value = Properties.Resources.Plain_R;
				}
			}

			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			if ( (r["IsCarried"] != DBNull.Value  && (bool)r["IsCarried"]) || !Convert.IsDBNull(r["CopiedFromPutID"]))
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
			}
		}

		private void dgvZoneTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvZoneTrips.DataSource == null || dgvZoneTrips.IsStatusRow(e.RowIndex))
				return;

			DataGridViewColumn dgvColumn = dgvZoneTrips.Columns[e.ColumnIndex];
			string sColumnName = dgvColumn.Name.ToUpper();
			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvZoneTrips.Rows[e.RowIndex]).DataBoundItem).Row;
			if (sColumnName.Contains("Image".ToUpper()) && droRow["TripType"] != DBNull.Value)
			{
				if ((string)droRow["TripType"] == "O")
					e.Value = Properties.Resources.Minus;
				else
					e.Value = Properties.Resources.Plus;
				return;
			}
		}

		private void dgvInCar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvInCar.DataSource == null || dgvInCar.IsStatusRow(e.RowIndex))
				return;

			DataGridViewColumn dgvColumn = dgvInCar.Columns[e.ColumnIndex];
			string sColumnName = dgvColumn.Name.ToUpper();
			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvInCar.Rows[e.RowIndex]).DataBoundItem).Row;
			if (sColumnName.Contains("Image".ToUpper()))
			{
				if (droRow["InputDocumentID"] == DBNull.Value)
					e.Value = Properties.Resources.Minus;
				else
					e.Value = Properties.Resources.Plus;
				return;
			}
		}

		private void dgvTrips_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgvTrips.DataSource == null || dgvTrips.IsStatusRow(e.RowIndex))
				return;
			DataRow droRow = ((DataRowView)((DataGridViewRow)dgvTrips.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn dgvcColumn = dgvTrips.Columns[e.ColumnIndex];
			string sColumnName = dgvcColumn.Name.ToUpper();
			if (sColumnName.Contains("TripStatus".ToUpper()))
			{
				if (droRow["DateBeg"] == DBNull.Value)
					e.Value = Properties.Resources.DotRed;
				else
				{
					if (droRow["DateEnd"] == DBNull.Value)
						e.Value = Properties.Resources.DotYellow;
					else
						e.Value = Properties.Resources.DotGreen;
				}
			}
		}

		#endregion CellFormatting

		private void dgvPuts_Enter(object sender, EventArgs e)
		{
			btnMoveDn.Enabled = btnMoveUp.Enabled = false;
			gridPutsRowChange(null, dgvPuts);
		}

		private void dgvTripPuts_Enter(object sender, EventArgs e)
		{
			if (dgvTripPuts.GridSource.Count == 0)
				return; 

			gridPutsRowChange(null, dgvTripPuts);
			if (dgvTripPuts.RowCount < 2 || !chkPostern.Checked) 
				btnMoveUp.Enabled = btnMoveDn.Enabled = false;
			else
				btnMoveUp.Enabled = btnMoveDn.Enabled = true;
			if (dgvTripPuts.CurrentRow.Index == dgvTripPuts.GridSource.Count - 1)
				btnMoveDn.Enabled = false;
			if (dgvTripPuts.CurrentRow.Index == 0)
				btnMoveUp.Enabled = false;
		}

		private void chkPostern_CheckedChanged(object sender, EventArgs e)
		{
			if (lastGrid == dgvTripPuts)
				dgvTripPuts_Enter(null, null);
			else
				dgvPuts_Enter(null, null);
		}

		private void MoveGroup(bool IsMoveUp)
		{
			int nCurCell = dgvTripPuts.CurrentCell.ColumnIndex;
			int nCurID = (int)((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["ID"],
				nCurByOrder = (int)((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["ByOrder"];

            // Alex - сортировка рейсов через SQL
            int nTripID;
            if (cboTrips.SelectedValue == null) return;
            nTripID = (int)cboTrips.SelectedValue;

            int? nOutputID = null, nInputID = null, nCarTaskID = null;
            if (((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["InputID"] == DBNull.Value) 
                nInputID = null;
            else 
                nInputID = Convert.ToInt32(((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["InputID"]);
            if (((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["OutputID"] == DBNull.Value) 
                nOutputID = null;
            else 
                nOutputID = Convert.ToInt32(((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["OutputID"]);
            if (((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["CarTaskID"] == DBNull.Value) 
                nCarTaskID = null;
            else 
                nCarTaskID = Convert.ToInt32(((DataRowView)dgvTripPuts.CurrentRow.DataBoundItem)["CarTaskID"]);

            oTrip.ChangeItemsByOrder(nTripID, nInputID, nOutputID, nCarTaskID, IsMoveUp, chkJoinDocumentsInStorage.Checked);
            // Alex end

			dgvTripPuts_Restore();
		}

		private void dtpDateTrip_ValueChanged(object sender, EventArgs e)
		{
			ucSelectRecordID_DepartmentNames.ClearDataSource();
			dtDepartmentNames = null;
		}

		private void chkCheckPutToTrip_CheckedChanged(object sender, EventArgs e)
		{
			if (chkCheckPutToTrip.Checked)
			{
				dgvPuts.IsRestoring = true;
				DataTable dt = (DataTable)dgvPuts.GridSource.DataSource;
				if (dgvPuts.Columns["dgvcIsChecked"] == null)
				{
					RFMDataGridViewCheckBoxColumn dgvColumn = new RFMDataGridViewCheckBoxColumn();

					dgvColumn.Name = "dgvcIsChecked";
					dgvColumn.HeaderText = "";
					dgvColumn.DataPropertyName = "IsChecked";
					dgvColumn.SortMode = DataGridViewColumnSortMode.Programmatic;
					dgvColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
					dgvColumn.CellTemplate = new RFMDataGridViewCheckBoxCell();
					dgvColumn.DisplayIndex = 0;
					dgvColumn.ReadOnly = false;
					dgvColumn.Resizable = DataGridViewTriState.False;

					if (dgvPuts.ReadOnly)
					{
						dgvPuts.ReadOnly = false;
						dgvPuts.Columns.Add(dgvColumn);
						for (int i = 0; i < dgvPuts.Columns.Count - 1; i++)
							dgvPuts.Columns[i].ReadOnly = true;
					}
					else
						dgvPuts.Columns.Add(dgvColumn);
				}
			}
			else
			{
				dgvPuts.Columns["dgvcIsChecked"].DataPropertyName = null;
				dgvPuts.Columns.Remove("dgvcIsChecked");
				btnUnCheckAllPuts_Click(null, null);
			}
			dgvPuts.IsRestoring = false;
		}

		private void dgvPuts_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			if (dgvPuts.IsRestoring)
				return;

			if (!chkCheckPutToTrip.Checked)
				return;

			if (dgvPuts.CurrentRow == null)
				return;

			if (!dgvPuts.CurrentCell.OwningColumn.Name.ToLower().Contains("ischecked"))
				return;


			RFMCursorWait.LockWindowUpdate(FindForm().Handle);
			DataRowView drvP = (DataRowView)dgvPuts.CurrentRow.DataBoundItem;
			nPartnerID = (drvP["PartnerID"] == DBNull.Value) ? null : (int?)drvP["PartnerID"];
			int nbsPosition;
			RFMBindingSource bs = dgvPuts.GridSource;
			if (!(bool)drvP["IsChecked"] && CheckPutToTrip())
			{
				if (chkJoinDocumentsInCar.Checked)
				{
					dgvPuts.IsRestoring = true;
					nbsPosition = bs.Position;
					bs.MoveFirst();
					for (int i = 0; i < bs.Count; i++)
					{
						drvP = ((DataRowView)bs.Current);
						if ((drvP["PartnerID"] != DBNull.Value) && ((int)drvP["PartnerID"] == @nPartnerID))
						{
							nCheckedPutsCount++;
							drvP["IsChecked"] = true;
						}
						bs.MoveNext();
					}
					bs.Position = nbsPosition;
					dgvPuts.IsRestoring = false;
				}
				else
				{
					drvP["IsChecked"] = true;
					nCheckedPutsCount++;
				}
			}
			else
			{
				if ((bool)drvP["IsChecked"] && chkJoinDocumentsInCar.Checked)
				{
					dgvPuts.IsRestoring = true;
					nbsPosition = bs.Position;
					bs.MoveFirst();
					for (int i = 0; i < bs.Count; i++)
					{
						drvP = ((DataRowView)bs.Current);
						if ((drvP["PartnerID"] != DBNull.Value) && ((int)drvP["PartnerID"] == @nPartnerID) && (bool)drvP["IsChecked"])
						{
							nCheckedPutsCount--;
							drvP["IsChecked"] = false;
						}
						bs.MoveNext();
					}
					bs.Position = nbsPosition;
					dgvPuts.IsRestoring = false;
				}
				else
				{
					drvP["IsChecked"] = false;
					nCheckedPutsCount--;
				}
			}
			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			btnUnCheckAllPuts.Visible = btnUnCheckAllPuts.Enabled =
				btnCheckedPutsToTrip.Visible = btnCheckedPutsToTrip.Enabled = (nCheckedPutsCount > 0);
			cboTrips.Enabled = !(nCheckedPutsCount > 0);				
		}

		private void dgvPuts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvPuts.IsRestoring)
				return;

			if (!chkCheckPutToTrip.Checked)
				return;

			if (dgvPuts.CurrentRow == null)
				return;

			if (!dgvPuts.CurrentCell.OwningColumn.Name.ToLower().Contains("ischecked"))
				return;

			dgvPuts_CellBeginEdit(null, null);
		}
	}
}