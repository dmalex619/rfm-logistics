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
	public partial class frmTripsEdit : RFMFormChild
	{
		private int? nTripID;
		private Trip oTrip;

		private bool bSelfDelivery = false;

		// для combobox
		private Car oCar, oCarSelected;
		private Driver oDriver, oDriverSelected; 
		private PermitLevel oPermitLevel;
		private Partner oPartnerCarrier; 
		int nPermitLevelNeedValue = -1;

		int nCarPointsQnt = 0;
		decimal nCarTonnage = 0, nCarVolume = 0, nCarPalletsQnt = 0;

		int nOutputsQnt = 0, nOutputsOutputsDocumentsQnt = 0, nOutputsPointsQnt = 0;
		decimal nOutputsNetto = 0, nOutputsBrutto = 0, nOutputsVolume = 0, nOutputsPalletsQnt = 0;
		int nOutputsDocumentsQnt = 0, nOutputsDocumentsPartnersQnt = 0, nOutputsDocumentsPointsQnt = 0;
		decimal nOutputsDocumentsNetto = 0, nOutputsDocumentsBrutto = 0, nOutputsDocumentsVolume = 0, nOutputsDocumentsPalletsQnt = 0;
		int nInputsQnt = 0, nInputsInputsDocumentsQnt = 0, nInputsPointsQnt = 0;
		decimal nInputsNetto = 0, nInputsBrutto = 0, nInputsVolume = 0, nInputsPalletsQnt = 0;
		int nInputsDocumentsQnt = 0, nInputsDocumentsPartnersQnt = 0, nInputsDocumentsPointsQnt = 0;
		decimal nInputsDocumentsNetto = 0, nInputsDocumentsBrutto = 0, nInputsDocumentsVolume = 0, nInputsDocumentsPalletsQnt = 0;
		
		//public string _SelectedIDList = null;
		public int? _SelectedID = null;
		public string _SelectedText = "";

		private Output oOutputList; //список расходов
		private Output oOutputCur; //текущий расход

		private Input oInputList; //список приходов
		private Input oInputCur; //текущий приход
		
		public string _SelectedOutputsIDList = null;
		public string _SelectedInputsIDList = null;

		private Act oActForOutput;
		private Act oActForInput;

		private TripReturn oTripReturnList; //список возвратов
		private TripReturn oTripReturnCur; //текущий возврат

		/*
		private bool bIsOurCar = false;
		private bool bIsRentCar = false;
		*/ 

		private bool bLoaded = false;
		private bool bDispose = true;
		private bool bSavedOK = false;


		public frmTripsEdit(int? _nTripID, bool _bSelfDelivery)
		{
			bSelfDelivery = _bSelfDelivery;
			if (_nTripID.HasValue)
			{
				nTripID = (int)_nTripID;
			}

			oTrip = new Trip();
			if (oTrip.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oCar = new Car();
				oCarSelected = new Car();
				oDriver = new Driver();
				oDriverSelected = new Driver();
				oPermitLevel = new PermitLevel();
				if (oCar.ErrorNumber != 0 ||
					oCarSelected.ErrorNumber != 0 ||
					oDriver.ErrorNumber != 0 ||
					oDriverSelected.ErrorNumber != 0 ||
					oPermitLevel.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oPartnerCarrier = new Partner();
				if (oPartnerCarrier.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oOutputList = new Output();
				oOutputCur = new Output();
				if (oOutputList.ErrorNumber != 0 ||
					oOutputCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}
			if (IsValid)
			{
				oInputList = new Input();
				oInputCur = new Input();
				if (oInputList.ErrorNumber != 0 ||
					oInputCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oActForOutput = new Act();
				oActForInput = new Act();
				if (oActForOutput.ErrorNumber != 0 ||
					oActForInput.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oTripReturnList = new TripReturn();
				oTripReturnCur = new TripReturn();
				if (oTripReturnList.ErrorNumber != 0 ||
					oTripReturnCur.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}

			bLoaded = true;
		}

		public frmTripsEdit(int? _nTripID):
			this(_nTripID, false)
		{
		}

		private void frmTripsEdit_Load (object sender, EventArgs e)
		{
			bool bResult = cboCar_Restore() &&
							cboDriverEmployee_Restore() &&
							cboPermitLevel_Restore();
			if (bResult)
			{
				optOurCar.Checked = true;
				optCar_CheckedChanged(null, null);
				optRentCar.Checked = false;
				optSelfDelivery.Checked = false;  

				cboCar.SelectedIndex = -1;
				cboCar_SelectedIndexChanged(null, null);
				cboDriverEmployee.SelectedIndex = -1;
				cboDriverEmployee_SelectedIndexChanged(null, null);
				cboPermitLevel.SelectedIndex = -1;
				lblZoneName.Text = "";
				ClearTotalInfo();
				ClearNeedInfo();

				oTrip.ID = nTripID;

				if (nTripID.HasValue)
				{
					// существующий рейс
					bResult = oTrip.ReFillOne((int)nTripID) && (oTrip.ErrorNumber == 0);
					if (bResult)
					{
						Text += " (" + nTripID.ToString() + ")";
						
						dtpDateTrip.Value = oTrip.DateTrip;
						if (oTrip.IsConfirmed || 
							oTrip.DateEnd.HasValue || 
							(oTrip.ReadyForTripEnd.HasValue && (bool)oTrip.ReadyForTripEnd))
							dtpDateTrip.Enabled = false;

						numTripNumber.Value = (oTrip.TripNumber == 0) ? 1 : oTrip.TripNumber;

                        // Изменение от 08.10.2013
                        if (oTrip.PartnerCarrierID.HasValue)
                            cboPartnerCarrier.SelectedValue = oTrip.PartnerCarrierID;
                        numCost.Value = oTrip.Cost;

                        if (oTrip.CarID.HasValue)
						{
							/* так уже и стоит 
							optOurCar.Checked = true;
							optRentCar.Checked = false;
							optSelfDelivery.Cheked = false;  
							*/
							optOurCar.Enabled =
							optRentCar.Enabled =
								true;
							optSelfDelivery.Enabled = false;

							cboCar.SelectedValue = (int)oTrip.CarID;
							cboCar_SelectedIndexChanged(null, null);
							if (oTrip.DriverEmployeeID.HasValue)
							{
								cboDriverEmployee.SelectedValue = oTrip.DriverEmployeeID;
								cboDriverEmployee_SelectedIndexChanged(null, null);
							}
							txtAlias.Enabled = false;
						}
						else
						{
							if (oTrip.SelfDelivery)
							{
								// самовывоз-самопривоз
								optOurCar.Enabled =
								optRentCar.Enabled =
									false;
								optSelfDelivery.Enabled = true;

								optOurCar.Checked = false;
								optRentCar.Checked = false;
								optSelfDelivery.Checked = true;
							}
							else
							{
								// аренда
								optOurCar.Enabled =
								optRentCar.Enabled =
									true;
								optSelfDelivery.Enabled = false;

								optOurCar.Checked = false;
								optRentCar.Checked = true;
								optSelfDelivery.Checked = false;
							}
							optCar_CheckedChanged(null, null);
						}

						txtAlias.Text = oTrip.Alias;

						txtCarName.Text = oTrip.CarName;
						txtCarTypeName.Text = oTrip.CarTypeName;
						txtCarNumber.Text = oTrip.CarNumber;
						txtTrailerNumber.Text = oTrip.TrailerNumber;
						txtDriverName.Text = oTrip.DriverName;
						txtDriverPhone.Text = oTrip.DriverPhone;

						txtNote.Text = oTrip.Note;

						// нужно
						numTonnage.Value = oTrip.Tonnage;
						chkIsPassengerCar.Checked = oTrip.IsPassengerCar;
						chkIsPostern.Checked = oTrip.IsPostern;
						chkIsLoadLift.Checked = oTrip.IsLoadLift;
						if (oTrip.PermitLevelID > 0)
							cboPermitLevel.SelectedValue = oTrip.PermitLevelID;
					}
				}
				else
				{ 
					// новый рейс
					numTripNumber.Value = 1;

					if (bSelfDelivery)
					{
						optOurCar.Checked = false;
						optRentCar.Checked = false;
						optSelfDelivery.Checked = true;
						optCar_CheckedChanged(null, null);

						optOurCar.Enabled =
						optRentCar.Enabled =
							false;
					}
					else
					{
						optSelfDelivery.Enabled = false;  
					}
				}
			}

			pnlCarNeed.Enabled = !bSelfDelivery; 
  
			tabTripsReturnsData.Enabled = !bSelfDelivery;

			btnOutputsAdd.Visible =
			btnOutputsDelete.Visible =
				bSelfDelivery;
			btnInputsAdd.Visible =
			btnInputsDelete.Visible =
				true;

			// списки заданий и заказов
			if (bResult)
			{
				bResult = grdOutputs_Restore() &&
							grdInputs_Restore() &&
							grdTripsReturns_Restore();  
			}

			if (!bResult)
			{
				Dispose();
			}

			tcList.Init();
		}

		#region Tab Restore

		private bool tabTrip_Restore()
		{
			return true;
		}

		private bool tabInputsData_Restore()
		{
			grdInputs_Restore();
			grdInputs.Select(); 
			grdInputs_CurrentRowChanged(grdInputs);
			return (true);
		}

		private bool tabOutputsData_Restore()
		{
			grdOutputs_Restore();
			grdOutputs.Select(); 
			grdOutputs_CurrentRowChanged(grdOutputs);
			return (true);
		}

		private bool tabTripsReturnsData_Restore()
		{
			grdTripsReturns_Restore();
			grdTripsReturns.Select();
			grdTripsReturns_CurrentRowChanged(grdTripsReturns);
			return (true);
		}

		private bool tabOutputsGoods_Restore()
		{
			return grdOutputsGoods_Restore();
		}

		private bool tabOutputsDocuments_Restore()
		{
			return grdOutputsDocuments_Restore();
		}

		private bool tabOutputs_Acts_Restore()
		{
			return grdOutputs_Acts_Restore();
		}

		private bool tabInputsGoods_Restore()
		{
			return grdInputsGoods_Restore();
		}

		private bool tabInputsDocuments_Restore()
		{
			return grdInputsDocuments_Restore();
		}

		private bool tabInputs_Acts_Restore()
		{
			return grdInputs_Acts_Restore();
		}

		private bool tabTripsReturnsGoods_Restore()
		{
			return grdTripsReturnsGoods_Restore();
		}

		private void tcList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (tcList.CurrentPage == null)
				return;
			
			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("TRIP"))
			{
			}

			if (sPageName.Contains("DATA"))
			{
				if (sPageName.Contains("OUTPUTS"))
				{
					grdOutputs_Enter(grdOutputs, null);
					ShowTotalInfo("OUTPUTS");
				}

				if (sPageName.Contains("INPUTS"))
				{
					grdInputs_Enter(grdInputs, null);
					ShowTotalInfo("INPUTS");
				}
			}

			if (sPageName.Contains("RETURNS"))
			{
				grdTripsReturns_Enter(grdTripsReturns, null);
			}

			tmrRestore_Tick(null, null);
		}

		private void tcOutputsGoods_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sPageName = tcOutputsGoods.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("GOODS"))
			{
				grdOutputsGoods_Enter(grdOutputsGoods, null);
			}
			if (sPageName.Contains("DOCUMENTS"))
			{
				grdOutputsDocuments_Enter(grdOutputsDocuments, null);
			}
			if (sPageName.Contains("ACTS"))
			{
				grdOutputs_Acts_Enter(grdOutputs_Acts, null);
			}
		}

		private void tcInputsGoods_SelectedIndexChanged(object sender, EventArgs e)
		{
			string sPageName = tcInputsGoods.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("GOODS"))
			{
				grdInputsGoods_Enter(grdInputsGoods, null);
			}
			if (sPageName.Contains("DOCUMENTS"))
			{
				grdInputsDocuments_Enter(grdInputsDocuments, null);
			}
			if (sPageName.Contains("ACTS"))
			{
				grdInputs_Acts_Enter(grdInputs_Acts, null);
			}
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
			bSavedOK = false;

			if (dtpDateTrip.IsEmpty)
			{
				RFMMessage.MessageBoxError("Укажите дату рейса!");
				dtpDateTrip.Select();
				return;
			}
			/*
			if (dtpDateTrip.Value.Date.CompareTo(DateTime.Now.Date) < 0)
			{
				RFMMessage.MessageBoxError("Указана прошедшая дата рейса...");
				return;
			}
			*/ 
			oTrip.DateTrip = dtpDateTrip.Value.Date;
			oTrip.TripNumber = Convert.ToInt32(numTripNumber.Value);
			oTrip.CarID = 
			oTrip.DriverEmployeeID = 
				null;
			if (optOurCar.Checked)
			{
				if (cboCar.SelectedValue == null || cboCar.SelectedIndex < 0)
				{
					RFMMessage.MessageBoxError("Укажите нашу машину!");
					cboCar.Select();
					return;
				}
				else
				{
					oTrip.CarID = (int)cboCar.SelectedValue;
					oTrip.IsRentCar = false;
					oTrip.SelfDelivery = false;

					if (cboDriverEmployee.SelectedValue != null && cboDriverEmployee.SelectedIndex >= 0)
					{
						oTrip.DriverEmployeeID = (int)cboDriverEmployee.SelectedValue;
					}
				}
			}

			if (optRentCar.Checked)
			{
				if (txtCarNumber.Text.Trim() == "")
				{
					RFMMessage.MessageBoxError("Укажите данные по машине!");
					txtCarNumber.Select();
					return;
				}
				else
				{
					oTrip.CarID = null;
					oTrip.IsRentCar = true;
					oTrip.SelfDelivery = false;
				}
			}

			if (optSelfDelivery.Checked)
			{
				if (txtCarNumber.Text.Trim() == "" || txtDriverName.Text.Trim() == "")
				{
					RFMMessage.MessageBoxError("Укажите данные по машине клиента!");
					if (txtCarNumber.Text.Trim() == "")
						txtCarNumber.Select();
					else
						txtDriverName.Select();
					return;
				}
				else
				{
					oTrip.CarID = null;
					oTrip.IsRentCar = false;
					oTrip.SelfDelivery = true;
				}
			}

			// проверка наличия приходных документов для заданий на приход - для начатого рейса
            /*
			if (oTrip.DateBeg.HasValue)
			{
				int nInputID = 0;
				Input oInputSave = new Input();
				InputDocument oInputDocumentSave = new InputDocument();
				if (oTrip.TableInputsInTrip.Rows.Count > 0)
				{
					foreach (DataRow i in oTrip.TableInputsInTrip.Rows)
					{
						nInputID = (int)i["ID"];
						oInputSave.ReFillOne(nInputID);
						if (!oInputSave.InputsDocumentsExists)
						{
							if (RFMMessage.MessageBoxYesNo("Для задания на приход с кодом " + oInputSave.ID.ToString() + " нет приходных документов.\n" +
								"Все-таки сохранить рейс?") != DialogResult.Yes)
								return;
						}
						// количество "по документам" для задания на приход пересчитывается всегда при сохранении документа
					}
				}
			}
			*/ 

			int nUserID = (int)((RFMFormMain)Application.OpenForms[0]).UserID;
			// настройка предупреждений
			bool? bWeightWarning = null;
			bool? bVolumeWarning = null;
			bool? bMaxPalletsQntWarning = null;
			bool? bPassCarWarning = null;
			bool? bPosternWarning = null;
			bool? bLiftWarning = null;
			bool? bPermitLevelControlWarning = null;
			bool? bMaxPointsQntWarning = null;
			bool? bMaxDurationWarning = null;
			Logistic oLogistic = new Logistic();
			if (oLogistic.FillTableLogisticsSettings(nUserID) && oLogistic.TableLogisticsSettings.Rows.Count > 0)
			{
				// пользовательские настройки
				DataRow dr = oLogistic.TableLogisticsSettings.Rows[0];
				if (dr["WeightControl"] != DBNull.Value)
					bWeightWarning = (bool)dr["WeightControl"];
				if (dr["VolumeControl"] != DBNull.Value)
					bVolumeWarning = (bool)dr["VolumeControl"];
				if (dr["PalletsControl"] != DBNull.Value)
					bMaxPalletsQntWarning = (bool)dr["PalletsControl"];
				if (dr["PassengerCarControl"] != DBNull.Value)
					bPassCarWarning = (bool)dr["PassengerCarControl"];
				if (dr["PosternControl"] != DBNull.Value)
					bPosternWarning = (bool)dr["PosternControl"];
				if (dr["LoadLiftControl"] != DBNull.Value)
					bLiftWarning = (bool)dr["LoadLiftControl"];
				if (dr["PermitLevelControl"] != DBNull.Value)
					bPermitLevelControlWarning = (bool)dr["PermitLevelControl"];
				if (dr["MaxPointsQntControl"] != DBNull.Value)
					bMaxPointsQntWarning = (bool)dr["MaxPointsQntControl"];
				if (dr["MaxDurationControl"] != DBNull.Value)
					bMaxDurationWarning = (bool)dr["MaxDurationControl"];
			}

			// проверка соответствия параметров машины и рейса, 
			// а также проверка превышения допустимых параметров машины и набранных заданий
			// только для нашей или арендованной машины 
			if (oTrip.CarID.HasValue || oTrip.IsRentCar)
			{
				if (oTrip.CarID.HasValue &&
					(cboPermitLevel.SelectedValue == null || cboPermitLevel.SelectedIndex < 0))
				{
					RFMMessage.MessageBoxError("Укажите разрешение на проезд!");
					cboPermitLevel.Select();
					return;
				}

				string sText = "";
				int nTonnage = 0, nMaxPointsQnt = 0;
				decimal nVolume = 0, nMaxPalletsQnt = 0;
				bool bIsPassengerCar, bIsPostern, bIsLoadLift;
				int nPermitLevelValue = 0;
				int nMaxDurationMinutes = 0;
				if (oCarSelected.ID.HasValue)
				{
					// по выбранной машине 
					Car oCarTemp = new Car();
					oCarTemp = oCarSelected;

					nTonnage = oCarTemp.Tonnage;
					nVolume = oCarTemp.Volume;
					nMaxPointsQnt = oCarTemp.MaxPointsQnt;
					nMaxPalletsQnt = oCarTemp.MaxPalletsQnt;
					bIsPassengerCar = oCarTemp.IsPassengerCar;
					bIsPostern = oCarTemp.IsPostern;
					bIsLoadLift = oCarTemp.IsLoadLift;
					nPermitLevelValue = (int)oCarTemp.PermitLevelValue;
					nMaxDurationMinutes = oCarTemp.MaxDurationMinutes;

					// соответствие: параметры рейса - выбранная машина
					if ((bWeightWarning == null || (bool) bWeightWarning) &&
						numTonnage.Value > 0 && numTonnage.Value > nTonnage)
					{
						sText += "- грузоподъемность машины (" + oCarTemp.Tonnage.ToString() + ") меньше требуемой (" + numTonnage.Value.ToString() + ")\n";
					}
					if ((bPassCarWarning == null || (bool)bPassCarWarning) && 
						chkIsPassengerCar.Checked != bIsPassengerCar)
					{
						sText += "- легковая машина\n";
					}
					if ((bPosternWarning == null || (bool)bPosternWarning) && 
						chkIsPostern.Checked != bIsPostern)
					{
						sText += "- задняя дверь\n";
					}
					if ((bLiftWarning == null || (bool)bLiftWarning) && 
						chkIsLoadLift.Checked != bIsLoadLift)
					{
						sText += "- подъемник\n";
					}
					if ((bPermitLevelControlWarning == null || (bool)bPermitLevelControlWarning) && 
						nPermitLevelNeedValue >= 0 && nPermitLevelValue < nPermitLevelNeedValue)
					{
						sText += "- разрешение на проезд для машины (" + txtPermitLevel_Car.Text + ") не соответствует требуемому (" + cboPermitLevel.Text + ")\n";
					}
					if (sText != "" && RFMMessage.MessageBoxYesNo("Обнаружены несоответствия требований рейса выбранной машине:\n" + sText + "\n" +
						"Все-таки сохранить рейс?") != DialogResult.Yes)
					{
						return;
					}
				}
				else
				{
					// по рейсу
					nTonnage = (int)numTonnage.Value;
					nVolume = 0;
					nMaxPalletsQnt = 0;
					nMaxPointsQnt = 0;
					bIsPassengerCar = chkIsPassengerCar.Checked;
					bIsPostern = chkIsPostern.Checked;
					bIsLoadLift = chkIsLoadLift.Checked;
					if (cboPermitLevel.SelectedValue != null && cboPermitLevel.SelectedIndex >= 0)
						nPermitLevelValue = (int)cboPermitLevel.SelectedValue;
					else
						nPermitLevelValue = 0;
					nMaxDurationMinutes = 0; 
				}

				// набор заданий (по сумме, отдельно приходы, отдельно расходы) - выбранная машина
				// задания на расход
				sText = "";
				if ((bWeightWarning == null || (bool)bWeightWarning) && 
					nTonnage > 0 && nOutputsBrutto > nTonnage)
				{
					sText += "превышен допустимый вес: " + nOutputsBrutto.ToString("#####0.0").Trim() + " (" + nTonnage.ToString("#####0.0").Trim() + ")" + "\n";
				}
				if ((bPassCarWarning == null || (bool)bPassCarWarning) &&
					nVolume > 0 && nOutputsVolume > nVolume)
				{
					sText += "превышен допустимый объем: " + nOutputsVolume.ToString("#####0.0").Trim() + " (" + nVolume.ToString("#####0.0").Trim() + ")" + "\n";
				}
				if ((bMaxPointsQntWarning == null || (bool)bMaxPointsQntWarning) &&
					nMaxPointsQnt > 0 && nOutputsPointsQnt > nMaxPointsQnt)
				{
					sText += "превышено допустимое количество точек доставки: " + nOutputsPointsQnt.ToString().Trim() + " (" + nMaxPointsQnt.ToString().Trim() + ")" + "\n";
				}
				if ((bMaxPalletsQntWarning == null || (bool)bMaxPalletsQntWarning) &&
					nMaxPalletsQnt > 0 && nOutputsPalletsQnt > nMaxPalletsQnt)
				{
					sText += "превышено допустимое количество паллет: " + nOutputsPalletsQnt.ToString("#####0.0").Trim() + " (" + nMaxPalletsQnt.ToString("#####0.0").Trim() + ")" + "\n";
				}
				if (sText != "" &&
					RFMMessage.MessageBoxYesNo("Обнаружены несоответствия заданий на расход выбранной машине:\n" + sText + "\n" +
						"Все-таки сохранить рейс?") != DialogResult.Yes)
				{
					return;
				}

				// задания на приход 
				sText = "";
				if ((bWeightWarning == null || (bool)bWeightWarning) && (bWeightWarning == null || (bool)bWeightWarning) && 
					nTonnage > 0 && nInputsBrutto > nTonnage)
				{
					sText += "превышен допустимый вес: " + nInputsBrutto.ToString("#####0.0").Trim() + " (" + nTonnage.ToString("#####0.0").Trim() + ")" + "\n";
				}
				if ((bVolumeWarning == null || (bool)bVolumeWarning) &&
					nVolume > 0 && nInputsVolume > nVolume)
				{
					sText += "превышен допустимый объем: " + nInputsVolume.ToString("#####0.0").Trim() + " (" + nVolume.ToString("#####0.0").Trim() + ")" + "\n";
				}
				if ((bMaxPointsQntWarning == null || (bool)bMaxPointsQntWarning) &&
					nMaxPointsQnt > 0 && nInputsPointsQnt > nMaxPointsQnt)
				{
					sText += "превышено допустимое количество точек доставки: " + nInputsPointsQnt.ToString().Trim() + " (" + nMaxPointsQnt.ToString().Trim() + ")" + "\n";
				}
				if ((bMaxPalletsQntWarning == null || (bool)bMaxPalletsQntWarning) &&
					nMaxPalletsQnt > 0 && nInputsPalletsQnt > nMaxPalletsQnt)
				{
					sText += "превышено допустимое количество паллет: " + nInputsPalletsQnt.ToString("#####0.0").Trim() + " (" + nMaxPalletsQnt.ToString("#####0.0").Trim() + ")" + "\n";
				}
				if (sText != "" &&
					RFMMessage.MessageBoxYesNo("Обнаружены несоответствия заданий на приход выбранной машине:\n" + sText + "\n" +
						"Все-таки сохранить рейс?") != DialogResult.Yes)
				{
					return;
				}

				// проверка соблюдения требуемых параметров по каждому заданию  
				sText = "";
				// по заданиям на расход
				if ((bWeightWarning == null || (bool)bWeightWarning) && 
					nTonnage > 0 && nOutputsBrutto > nTonnage)
				{
					sText += "Превышен вес заданий на расход: " + nOutputsBrutto.ToString("#####0.0").Trim() + " (" + nTonnage.ToString("#####0").Trim() + ")" + "\n";
				}
				if (grdOutputsDocuments.Rows.Count > 0)
				{
					foreach (DataRow dr in oTrip.TableOutputsDocumentsInTrip.Rows)
					{
						if ((bPassCarWarning == null || (bool)bPassCarWarning) &&
							dr["PassengerCarOnly"] != DBNull.Value && (bool)dr["PassengerCarOnly"] != bIsPassengerCar)
						{
							sText += "Расход: " + dr["ID"].ToString() + ": легковая машина\n";
						}
						if ((bPosternWarning == null || (bool)bPosternWarning) && 
							dr["PosternOnly"] != DBNull.Value && (bool)dr["PosternOnly"] != bIsPostern)
						{
							sText += "Расход: " + dr["ID"].ToString() + ": задняя дверь\n";
						}
						if ((bLiftWarning == null || (bool)bLiftWarning) && 
							dr["LoadLiftOnly"] != DBNull.Value && (bool)dr["LoadLiftOnly"] != bIsLoadLift)
						{
							sText += "Расход: " + dr["ID"].ToString() + ": подъемник\n";
						}
						if ((bPermitLevelControlWarning == null || (bool)bPermitLevelControlWarning) && 
							dr["PermitLevelValue"] != DBNull.Value && (int)dr["PermitLevelValue"] < nPermitLevelValue)
						{
							sText += "Расход: " + dr["ID"].ToString() + ": разрешение на проезд\n";
						}
					}
				}
				if (sText != "" &&
						RFMMessage.MessageBoxYesNo("Обнаружены несоответствия заданий на расход параметрам рейса/машины: \n" + sText + "\n" +
							"Все-таки сохранить рейс?") != DialogResult.Yes)
				{
					return;
				}

				// по заданиям на приход 
				sText = "";
				if ((bWeightWarning == null || (bool)bWeightWarning) && 
					nTonnage > 0 && nInputsBrutto > nTonnage)
				{
					sText += "Превышен вес заданий на приход: " + nInputsBrutto.ToString("#####0.0").Trim() + " (" + nTonnage.ToString("#####0").Trim() + ")" + "\n";
				}
				if (grdInputsDocuments.Rows.Count > 0)
				{
					foreach (DataRow dr in oTrip.TableInputsDocumentsInTrip.Rows)
					{
						if ((bPassCarWarning == null || (bool)bPassCarWarning) &&
							dr["PassengerCarOnly"] != DBNull.Value && (bool)dr["PassengerCarOnly"] != bIsPassengerCar)
						{
							sText += "приход: " + dr["ID"].ToString() + ": легковая машина\n";
						}
						if ((bPosternWarning == null || (bool)bPosternWarning) &&
							dr["PosternOnly"] != DBNull.Value && (bool)dr["PosternOnly"] != bIsPostern)
						{
							sText += "приход: " + dr["ID"].ToString() + ": задняя дверь\n";
						}
						if ((bLiftWarning == null || (bool)bLiftWarning) &&
							dr["LoadLiftOnly"] != DBNull.Value && (bool)dr["LoadLiftOnly"] != bIsLoadLift)
						{
							sText += "приход: " + dr["ID"].ToString() + ": подъемник\n";
						}
						if ((bPermitLevelControlWarning == null || (bool)bPermitLevelControlWarning) &&
							dr["PermitLevelValue"] != DBNull.Value && (int)dr["PermitLevelValue"] < nPermitLevelValue)
						{
							sText += "приход: " + dr["ID"].ToString() + ": разрешение на проезд\n";
						}
					}
				}
				if (sText != "" &&
						RFMMessage.MessageBoxYesNo("Обнаружены несоответствия заданий на приход параметрам рейса/машины: \n" + sText + "\n" +
							"Все-таки сохранить рейс?") != DialogResult.Yes)
				{
					return;
				}
			}

			// сравнить дату рейса и даты заданий/заказов 
			// расходы
			if (oTrip.ID.HasValue)
			{
				oTrip.FillTableOutputsInTrip();
				if (oTrip.ErrorNumber == 0 && 
					oTrip.TableOutputsInTrip != null &&
					oTrip.TableOutputsInTrip.Rows.Count > 0)
				{
					Output oOutputChangeDate = new Output();
					foreach (DataRow o in oTrip.TableOutputsInTrip.Rows)
					{
						oOutputChangeDate.FillOne(o);
						if (oOutputChangeDate.DateOutput.Date.CompareTo(oTrip.DateTrip) != 0)
						{
							if (RFMMessage.MessageBoxYesNo("Для задания на расход с кодом " + oOutputChangeDate.ID.ToString() + " дата (" + oOutputChangeDate.DateOutput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
								"Изменить дату задания на расход и входящих в него расходных документов в соответствии с датой рейса?") == DialogResult.Yes)
							{
								oOutputChangeDate.ChangeDate((int)oOutputChangeDate.ID, oTrip.DateTrip);
							}
						}
					}
				}

				oTrip.FillTableOutputsDocumentsInTrip();
				if (oTrip.ErrorNumber == 0 && 
					oTrip.TableOutputsDocumentsInTrip != null &&
					oTrip.TableOutputsDocumentsInTrip.Rows.Count > 0)
				{
					OutputDocument oOutputDocumentChangeDate = new OutputDocument();
					foreach (DataRow od in oOutputDocumentChangeDate.MainTable.Rows)
					{
						oOutputDocumentChangeDate.FillOne(od);
						if (oOutputDocumentChangeDate.IsBrought)
							continue; 
						if (oOutputDocumentChangeDate.DateOutput.Date.CompareTo(oTrip.DateTrip) != 0)
						{
							if (RFMMessage.MessageBoxYesNo("Для расходного документа с кодом " + oOutputDocumentChangeDate.ID.ToString() + " (" + oOutputDocumentChangeDate.PartnerTargetName + ") " +
								"дата (" + oOutputDocumentChangeDate.DateOutput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
								"Изменить дату расходного документа в соответствии с датой рейса?") == DialogResult.Yes)
							{
								oOutputDocumentChangeDate.ChangeDate((int)oOutputDocumentChangeDate.ID, oTrip.DateTrip);
							}
						}
					}
				}

				// приходы
				oTrip.FillTableInputsInTrip();
				if (oTrip.ErrorNumber == 0 &&
					oTrip.TableInputsInTrip != null &&
					oTrip.TableInputsInTrip.Rows.Count > 0)
				{
					Input oInputChangeDate = new Input();
					foreach (DataRow o in oTrip.TableInputsInTrip.Rows)
					{
						oInputChangeDate.FillOne(o);
						if (oInputChangeDate.DateInput.Date.CompareTo(oTrip.DateTrip) != 0)
						{
							if (RFMMessage.MessageBoxYesNo("Для задания на приход с кодом " + oInputChangeDate.ID.ToString() + " дата (" + oInputChangeDate.DateInput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
								"Изменить дату задания на приход" + 
								((oInputChangeDate.InputsDocumentsExists) ? " и входящих в него приходных документов" : "") + " в соответствии с датой рейса?") == DialogResult.Yes)
							{
								oInputChangeDate.ChangeDate((int)oInputChangeDate.ID, oTrip.DateTrip);
							}
						}
					}
				}

				oTrip.FillTableInputsDocumentsInTrip();
				if (oTrip.ErrorNumber == 0 &&
					oTrip.TableInputsDocumentsInTrip != null &&
					oTrip.TableInputsDocumentsInTrip.Rows.Count > 0)
				{
					InputDocument oInputDocumentChangeDate = new InputDocument();
					foreach (DataRow od in oInputDocumentChangeDate.MainTable.Rows)
					{
						oInputDocumentChangeDate.FillOne(od);
						if (oInputDocumentChangeDate.DateInput.Date.CompareTo(oTrip.DateTrip) != 0)
						{
							if (RFMMessage.MessageBoxYesNo("Для приходного документа с кодом " + oInputDocumentChangeDate.ID.ToString() + " (" + oInputDocumentChangeDate.PartnerSourceName + ") " +
								"дата (" + oInputDocumentChangeDate.DateInput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
								"Изменить дату приходного документа в соответствии с датой рейса?") == DialogResult.Yes)
							{
								oInputDocumentChangeDate.ChangeDate((int)oInputDocumentChangeDate.ID, oTrip.DateTrip);
							}
						}
					}
				}

                // спецзадания
                oTrip.FillTableCarsTasksInTrip();
                if (oTrip.ErrorNumber == 0 &&
                    oTrip.TableCarsTasksInTrip != null &&
                    oTrip.TableCarsTasksInTrip.Rows.Count > 0)
                {
                    CarTask oCarTaskChangeDate = new CarTask();
                    foreach (DataRow o in oTrip.TableCarsTasksInTrip.Rows)
                    {
                        oCarTaskChangeDate.FillOne(o);
                        if (oCarTaskChangeDate.DateTask.Date.CompareTo(oTrip.DateTrip) != 0)
                        {
                            if (RFMMessage.MessageBoxYesNo("Для спецзадания с кодом " + oCarTaskChangeDate.ID.ToString() + " дата (" + oCarTaskChangeDate.DateTask.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
                                "Изменить дату спецзадания в соответствии с датой рейса?") == DialogResult.Yes)
                            {
                                oCarTaskChangeDate.ChangeDate((int)oCarTaskChangeDate.ID, oTrip.DateTrip);
                            }
                        }
                    }
                }

            }

			// добрались. сохраняем.
			oTrip.Tonnage = Convert.ToInt32(numTonnage.Value);
			oTrip.IsPassengerCar = chkIsPassengerCar.Checked;
			oTrip.IsPostern = chkIsPostern.Checked;
			oTrip.IsLoadLift = chkIsLoadLift.Checked;
			if (cboPermitLevel.SelectedIndex < 0 || cboPermitLevel.SelectedValue == null)
			{
				oTrip.PermitLevelID = 0;
			}
			else
			{
				oTrip.PermitLevelID = (int)cboPermitLevel.SelectedValue;
			}

			oTrip.CarName = txtCarName.Text.Trim();
			oTrip.CarTypeName = txtCarTypeName.Text.Trim();
			oTrip.CarNumber = txtCarNumber.Text.Trim();
			oTrip.TrailerNumber = txtTrailerNumber.Text.Trim();
			oTrip.DriverName = txtDriverName.Text.Trim();
			oTrip.DriverPhone = txtDriverPhone.Text.Trim();

			oTrip.PartnerCarrierID = null;
			if (cboPartnerCarrier.Enabled) // oTrip.IsRentCar 
			{
				if (cboPartnerCarrier.SelectedValue != null && cboPartnerCarrier.SelectedIndex >= 0)
					oTrip.PartnerCarrierID = (int)cboPartnerCarrier.SelectedValue;
			}
			oTrip.Cost = numCost.Value; 

			oTrip.Alias = txtAlias.Text.Trim();
			oTrip.Note = txtNote.Text.Trim();

			oTrip.ClearError();
			oTrip.SaveOne();

			if (oTrip.ErrorNumber == 0)
			{
				// код добавленного рейса
				if (!nTripID.HasValue && oTrip.ID.HasValue && oTrip.ID != 0)
				{
					nTripID = (int)oTrip.ID;
				}

				bSavedOK = true;

				if (bDispose)
				{
					MotherForm.GotParam = new object[] { (int)oTrip.ID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}

				oTrip.ReFillOne((int)nTripID);
			}
		}

		#region Comboboxes

		#region Combobox PermitLevel 

		private void cboPermitLevel_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboPermitLevel.DisplayMember.Length == 0 || cboPermitLevel.ValueMember.Length == 0)
				return;

			if (cboPermitLevel.SelectedIndex >= 0 && cboPermitLevel.SelectedValue != null)
			{
				DataRow r = oPermitLevel.MainTable.Rows.Find((int)cboPermitLevel.SelectedValue);
				if (r != null)
				{
					nPermitLevelNeedValue = Convert.ToInt32(r["PermitLevelValue"]);
				}
			}
			else
			{
				nPermitLevelNeedValue = -1;
			}
		}

		#endregion Combobox PermitLevel
		
		#region Combobox & OptionGroup Car

		private void cboCar_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCar.SelectedValue != null && cboCar.SelectedIndex >= 0 && 
				cboCar.ValueMember != "")
			{
				oCarSelected.ReFillOne((int)cboCar.SelectedValue);

				txtCarName.Text = oCarSelected.Name;
				txtCarTypeName.Text = oCarSelected.CarTypeName;
				txtCarNumber.Text = oCarSelected.CarNumber;
				txtTrailerNumber.Text = oCarSelected.TrailerNumber;
				if (oCarSelected.DriverEmployeeID.HasValue)
				{
					if (cboDriverEmployee.SelectedIndex < 0 && cboDriverEmployee.SelectedValue == null)
					{
						cboDriverEmployee.SelectedValue = oCarSelected.DriverEmployeeID;
						cboDriverEmployee_SelectedIndexChanged(null, null);
						//txtDriverName.Text = oCarSelected.DriverName;
					}
				}

				bool bChangeTripParameters = false;
				// записать параметры машины как параметры рейса 
				if (!oTrip.ID.HasValue ||
					grdOutputs.Rows.Count == 0 && grdInputs.Rows.Count == 0)
				{
					// для режима ввода - однозначно
					// для режима редактирования - если нет заказов
					bChangeTripParameters = true;
				}
				else
				{ 
					// для режима редактирования (если есть заказы) - по запросу
					if (numTonnage.Value == oCarSelected.Tonnage &&
						chkIsPassengerCar.Checked == oCarSelected.IsPassengerCar &&
						chkIsPostern.Checked == oCarSelected.IsPostern &&
						chkIsLoadLift.Checked == oCarSelected.IsLoadLift &&
						(oCarSelected.PermitLevelID == 0 && cboPermitLevel.SelectedValue == null ||
						 oCarSelected.PermitLevelID == (int)cboPermitLevel.SelectedValue)
						 )
					{
						bChangeTripParameters = true;
					}
					else
					{
						bChangeTripParameters = true;
						/*
						string sText = "Выбранная машина имеет другие параметры:\n" +  
							oCarSelected.Tonnage.ToString("######") + " кг\n" + 
							((oCarSelected.IsPassengerCar) ? "легковая\n" : "") + 
							((oCarSelected.IsPostern) ? "ЗД\n" : "бок\n") + 
							((oCarSelected.IsLoadLift) ? "подъемник\n" : "") + 
							((oCarSelected.PermitLevelID != 0) ? "разрешение на проезд: " + oCarSelected.PermitLevelName : "") + 
							"\n" + 
							"Изменить параметры рейса?";
						if (bLoaded && RFMMessage.MessageBoxYesNo(sText) == DialogResult.Yes)
						{
							bChangeTripParameters = true;
						}
						*/ 
 					}
				}
				if (bChangeTripParameters)
				{
					numTonnage.Value = oCarSelected.Tonnage;
					chkIsPassengerCar.Checked = oCarSelected.IsPassengerCar;
					chkIsPostern.Checked = oCarSelected.IsPostern;
					chkIsLoadLift.Checked = oCarSelected.IsLoadLift;
					if (oCarSelected.PermitLevelID > 0)
					{
						cboPermitLevel.SelectedValue = (int)oCarSelected.PermitLevelID;
					}
					else
					{
						cboPermitLevel.SelectedIndex = -1;
					}
				}
			}
			else
			{
				ClearCarInfo();
				oCarSelected.ID = null;
				txtCarName.Text =
				txtCarTypeName.Text =
				txtCarNumber.Text =
				txtTrailerNumber.Text =
					"";
			}
			ShowTotalInfo();
		}

		private void optCar_CheckedChanged(object sender, EventArgs e)
		{
            // Изменение от 08.10.2013
            // Допускается ввод фирмы-перевозчика одновременно с нашей машиной
            // Наша машина везет на пункт сбора, а дальше нанятая компания доставляет до клиента
            if (optOurCar.Checked || optRentCar.Checked)
            {
                cboPartnerCarrier.Enabled = true;
                numCost.Enabled = true;

                if (oPartnerCarrier.MainTable == null || oPartnerCarrier.MainTable.Rows.Count == 0)
                {
                    cboPartnerCarrier_Restore();
                    cboPartnerCarrier.SelectedIndex = -1;
                }
            }

			if (optOurCar.Checked)
			{
				optRentCar.Checked =
				optSelfDelivery.Checked = 
					false;

				/*
				bIsOurCar = true;
				bIsRentCar = false;
				bSelfDelivery = false;
				*/ 

				cboCar.Enabled = 
				cboDriverEmployee.Enabled = 
					true;
				cboCar.SelectedIndex =
				cboDriverEmployee.SelectedIndex =
					-1;
				cboCar_SelectedIndexChanged(null, null);
				cboDriverEmployee_SelectedIndexChanged(null, null);

				btnRentCarSelect.Enabled =
				btnPartnerCarSelect.Enabled =
					false;

				pnlCarInfo.Enabled = false;

				txtCarName.Text = 
				txtCarTypeName.Text = 
				txtCarNumber.Text =
				txtTrailerNumber.Text = 
				txtDriverName.Text = 
				txtDriverPhone.Text =  
					"";

				txtAlias.Text = "";
				txtAlias.Enabled = false;
			}

			if (optRentCar.Checked)
			{
				optOurCar.Checked =
				optSelfDelivery.Checked =
					false;

				/*
				bIsOurCar = false;
				bIsRentCar = true;
				bSelfDelivery = false;
				*/

				cboCar.Enabled = 
				cboDriverEmployee.Enabled = 
					false;
				cboCar.SelectedIndex =
				cboDriverEmployee.SelectedIndex = 
					-1;

				btnRentCarSelect.Enabled = true;
				btnPartnerCarSelect.Enabled = false;

				pnlCarInfo.Enabled = true;

				txtAlias.Text = ""; 
				txtAlias.Enabled = true;
			}

			if (optSelfDelivery.Checked)
			{
				optOurCar.Checked =
				optRentCar.Checked =
					false;
				
				/*
				bIsOurCar = false;
				bIsRentCar = false;
				bSelfDelivery = true;
				*/ 

				cboCar.Enabled =
				cboDriverEmployee.Enabled =
					false;
				cboCar.SelectedIndex =
				cboDriverEmployee.SelectedIndex =
					-1;

				cboPartnerCarrier.SelectedIndex = -1;
				cboPartnerCarrier.Enabled = false;
				numCost.Value = 0;
				numCost.Enabled = false;

				btnRentCarSelect.Enabled = false;
				btnPartnerCarSelect.Enabled = true;

				pnlCarInfo.Enabled = true;

				txtAlias.Text = ""; 
				txtAlias.Enabled = true;
			}

			ShowTotalInfo();
		}

		#endregion Combobox & OptionGroup Car

		#region Combobox Driver

		private void cboDriverEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboDriverEmployee.SelectedValue != null && cboDriverEmployee.SelectedIndex >= 0)
			{
				if (bLoaded && cboDriverEmployee.ValueMember != "")
				{
					oDriverSelected.ReFillOne((int)cboDriverEmployee.SelectedValue);
					lblZoneName.Text = oDriverSelected.ZoneAlias;

					txtDriverName.Text = oDriverSelected.Name;
					txtDriverPhone.Text = oDriverSelected.MobPhone;
				}
			}
			else
			{
				oDriverSelected.ID = null;
				txtDriverName.Text =
				txtDriverPhone.Text = 
					"";
				lblZoneName.Text = ""; 
			}
		}

		#endregion Combobox Driver 

		#endregion Comboboxes


		#region ShowTotal

		#region TotalInfo

		private void ShowTotalInfo()
		{
			if (tcList.CurrentPage == null)
				return;
			string sPageName = tcList.CurrentPage.Name.ToUpper();
			if (sPageName.Contains("OUTPUTS"))
			{
				ShowTotalInfo("OUTPUTS");
			}
			if (sPageName.Contains("INPUTS"))
			{
				ShowTotalInfo("INPUTS");
			}
		}

		private void ShowTotalInfo(string sMode)
		{
			ClearCarInfo();
			ClearTotalInfo(); 
			if (optOurCar.Checked && oCarSelected.ID.HasValue)
			{
				CarInfo(oCarSelected);
				CarOutputsInputsDocumentsInfo(oCarSelected, false);
			}
			else
			{
				if (sMode == "Outputs".ToUpper())
				{
					txtOutputsDocumentsQnt.Text = nOutputsOutputsDocumentsQnt.ToString();
					txtOutputsPointsQnt.Text = nOutputsPointsQnt.ToString();
					txtOutputsNetto.Text = nOutputsNetto.ToString();
					txtOutputsBrutto.Text = nOutputsBrutto.ToString("#####0.0");
					txtOutputsVolume.Text = nOutputsVolume.ToString("#####0.0");
					txtOutputsPalletsQnt.Text = nOutputsPalletsQnt.ToString("#####0.0");
				}
				if (sMode == "OutputsDocuments".ToUpper())
				{
					txtOutputsDocumentsQnt.Text = nOutputsDocumentsQnt.ToString();
					txtOutputsPointsQnt.Text = nOutputsDocumentsPointsQnt.ToString();
					txtOutputsNetto.Text = nOutputsDocumentsNetto.ToString();
					txtOutputsBrutto.Text = nOutputsDocumentsBrutto.ToString("#####0.0");
					txtOutputsVolume.Text = nOutputsDocumentsVolume.ToString("#####0.0");
					txtOutputsPalletsQnt.Text = nOutputsDocumentsPalletsQnt.ToString("#####0.0");
				}
				if (sMode == "Inputs".ToUpper())
				{
					txtInputsDocumentsQnt.Text = nInputsInputsDocumentsQnt.ToString();
					txtInputsPointsQnt.Text = nInputsPointsQnt.ToString();
					txtInputsNetto.Text = nInputsNetto.ToString();
					txtInputsBrutto.Text = nInputsBrutto.ToString("#####0.0");
					txtInputsVolume.Text = nInputsVolume.ToString("#####0.0");
					txtInputsPalletsQnt.Text = nInputsPalletsQnt.ToString("#####0.0");
				}
				if (sMode == "InputsDocuments".ToUpper())
				{
					txtInputsDocumentsQnt.Text = nInputsDocumentsQnt.ToString();
					txtInputsPointsQnt.Text = nInputsDocumentsPointsQnt.ToString();
					txtInputsNetto.Text = nInputsDocumentsNetto.ToString();
					txtInputsBrutto.Text = nInputsDocumentsBrutto.ToString("#####0.0");
					txtInputsVolume.Text = nInputsDocumentsVolume.ToString("#####0.0");
					txtInputsPalletsQnt.Text = nInputsDocumentsPalletsQnt.ToString("#####0.0");
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

			txtInputsBruttoPercent.DisabledBackColor =
			txtInputsVolumePercent.DisabledBackColor =
			txtInputsPalletsQntPercent.DisabledBackColor =
			txtInputsBruttoPercent.BackColor =
			txtInputsVolumePercent.BackColor =
			txtInputsPalletsQntPercent.BackColor =
			txtInputsVolume.BackColor;

			txtInputsPointsQnt.Text =
			txtInputsNetto.Text =
			txtInputsBrutto.Text =
			txtInputsVolume.Text =
			txtInputsPalletsQnt.Text =
			txtInputsBruttoPercent.Text =
			txtInputsVolumePercent.Text =
			txtInputsPalletsQntPercent.Text =
				"";
		}

		#endregion TotalInfo

		#region CarInfo

		private void CarInfo(Car oCarTemp)
		{
			ClearCarInfo();

			txtTonnageDeclared_Car.Text = oCarTemp.Tonnage.ToString();
			chkIsPassengerCar_Car.Checked = oCarTemp.IsPassengerCar;
			chkIsPostern_Car.Checked = oCarTemp.IsPostern;
			chkIsLoadLift_Car.Checked = oCarTemp.IsLoadLift;
			txtPermitLevel_Car.Text = oCarTemp.PermitLevelName;

			nCarPointsQnt = oCarTemp.MaxPointsQnt;
			nCarTonnage = oCarTemp.Tonnage;
			nCarVolume = oCarTemp.Volume;
			nCarPalletsQnt = oCarTemp.MaxPalletsQnt;
		}

		private void ClearCarInfo()
		{
			txtTonnageDeclared_Car.Text = "";
			chkIsPassengerCar_Car.Checked =
			chkIsPostern_Car.Checked =
			chkIsLoadLift_Car.Checked =
				false;
			txtPermitLevel_Car.Text = "";

			nCarPointsQnt = 0;
			nCarTonnage = 0;
			nCarVolume = 0;
			nCarPalletsQnt = 0;
		}

		private void ClearNeedInfo()
		{
			numTonnage.Value = 0;
			chkIsPassengerCar.Checked =  
			chkIsPostern.Checked =
			chkIsLoadLift.Checked =
				false;
			cboPermitLevel.SelectedIndex = -1;
		}

		#endregion CarInfo

		#region OutputsInputsDocumentsInfo

		private void CarOutputsInputsDocumentsInfo(Car oCarTemp, bool bDocuments)
		{
			CarInfo(oCarTemp);

			string sPageName = tcList.CurrentPage.Name.ToUpper();
			
			if (sPageName.Contains("OUTPUTS"))
			{
				if (bDocuments)
				{
					if (tcOutputsGoods.CurrentPage.Name.ToUpper().Contains("OutputsDocuments".ToUpper()))
					{
						lblOutputs.Text = "Расходные документы:";

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
				}
				else
				{
					lblOutputs.Text = "Задания на расход:";

					txtOutputsDocumentsQnt.Text = nOutputsOutputsDocumentsQnt.ToString();
					txtOutputsPointsQnt.Text = nOutputsPointsQnt.ToString() + "/" + oCarTemp.MaxPointsQnt.ToString();
					txtOutputsNetto.Text = nOutputsNetto.ToString();
					txtOutputsBrutto.Text = nOutputsBrutto.ToString("#####0.0") + "/" + oCarTemp.Tonnage.ToString("#####0.0");
					txtOutputsVolume.Text = nOutputsVolume.ToString("#####0.0") + "/" + oCarTemp.Volume.ToString("#####0.0");
					txtOutputsPalletsQnt.Text = nOutputsPalletsQnt.ToString("#####0.0") + "/" + oCarTemp.MaxPalletsQnt.ToString("#####0.0");

					if (oCarTemp.Tonnage != 0)
					{
						txtOutputsBruttoPercent.Text = ((decimal)(nOutputsBrutto * 100 / oCarTemp.Tonnage)).ToString("###");
					}
					if (oCarTemp.Volume != 0)
					{
						txtOutputsVolumePercent.Text = ((decimal)(nOutputsVolume * 100 / oCarTemp.Volume)).ToString("###");
					}
					if (oCarTemp.MaxPalletsQnt != 0)
					{
						txtOutputsPalletsQntPercent.Text = ((decimal)(nOutputsPalletsQnt * 100 / oCarTemp.MaxPalletsQnt)).ToString("###");
					}

					if (nOutputsBrutto > oCarTemp.Tonnage && oCarTemp.Tonnage > 0)
					{
						txtOutputsBruttoPercent.BackColor = Color.LightSalmon;
					}
					if (nOutputsVolume > oCarTemp.Volume && oCarTemp.Volume > 0)
					{
						txtOutputsVolumePercent.BackColor = Color.LightSalmon;
					}
					if (nOutputsPalletsQnt > oCarTemp.MaxPalletsQnt && oCarTemp.MaxPalletsQnt > 0)
					{
						txtOutputsPalletsQntPercent.BackColor = Color.LightSalmon;
					}
					return;
				}
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (bDocuments)
				{
					if (tcInputsGoods.CurrentPage.Name.ToUpper().Contains("InputsDocuments".ToUpper()))
					{
						lblInputs.Text = "Приходные документы:";

						txtInputsDocumentsQnt.Text = nInputsDocumentsQnt.ToString();
						txtInputsPointsQnt.Text = nInputsDocumentsPointsQnt.ToString() + "/" + oCarTemp.MaxPointsQnt.ToString();
						txtInputsNetto.Text = nInputsDocumentsNetto.ToString();
						txtInputsBrutto.Text = nInputsDocumentsBrutto.ToString("#####0.0") + "/" + oCarTemp.Tonnage.ToString("#####0.0");
						txtInputsVolume.Text = nInputsDocumentsVolume.ToString("#####0.0") + "/" + oCarTemp.Volume.ToString("#####0.0");
						txtInputsPalletsQnt.Text = nInputsDocumentsPalletsQnt.ToString("#####0.0") + "/" + oCarTemp.MaxPalletsQnt.ToString("#####0.0");

						if (oCarTemp.Tonnage != 0)
						{
							txtInputsBruttoPercent.Text = ((decimal)(nInputsDocumentsBrutto * 100 / oCarTemp.Tonnage)).ToString("###");
						}
						if (oCarTemp.Volume != 0)
						{
							txtInputsVolumePercent.Text = ((decimal)(nInputsDocumentsVolume * 100 / oCarTemp.Volume)).ToString("###");
						}
						if (oCarTemp.MaxPalletsQnt != 0)
						{
							txtInputsPalletsQntPercent.Text = ((decimal)(nInputsDocumentsPalletsQnt * 100 / oCarTemp.MaxPalletsQnt)).ToString("###");
						}

						if (nInputsDocumentsBrutto > oCarTemp.Tonnage && oCarTemp.Tonnage > 0)
						{
							txtInputsBruttoPercent.BackColor = Color.LightSalmon;
						}
						if (nInputsDocumentsVolume > oCarTemp.Volume && oCarTemp.Volume > 0)
						{
							txtInputsVolumePercent.BackColor = Color.LightSalmon;
						}
						if (nInputsDocumentsPalletsQnt > oCarTemp.MaxPalletsQnt && oCarTemp.MaxPalletsQnt > 0)
						{
							txtInputsPalletsQntPercent.BackColor = Color.LightSalmon;
						}
						return;
					}
				}
				else
				{
					lblInputs.Text = "Задания на приход:";

					txtInputsDocumentsQnt.Text = nInputsInputsDocumentsQnt.ToString();
					txtInputsPointsQnt.Text = nInputsPointsQnt.ToString() + "/" + oCarTemp.MaxPointsQnt.ToString();
					txtInputsNetto.Text = nInputsNetto.ToString();
					txtInputsBrutto.Text = nInputsBrutto.ToString("#####0.0") + "/" + oCarTemp.Tonnage.ToString("#####0.0");
					txtInputsVolume.Text = nInputsVolume.ToString("#####0.0") + "/" + oCarTemp.Volume.ToString("#####0.0");
					txtInputsPalletsQnt.Text = nInputsPalletsQnt.ToString("#####0.0") + "/" + oCarTemp.MaxPalletsQnt.ToString("#####0.0");

					if (oCarTemp.Tonnage != 0)
					{
						txtInputsBruttoPercent.Text = ((decimal)(nInputsBrutto * 100 / oCarTemp.Tonnage)).ToString("###");
					}
					if (oCarTemp.Volume != 0)
					{
						txtInputsVolumePercent.Text = ((decimal)(nInputsVolume * 100 / oCarTemp.Volume)).ToString("###");
					}
					if (oCarTemp.MaxPalletsQnt != 0)
					{
						txtInputsPalletsQntPercent.Text = ((decimal)(nInputsPalletsQnt * 100 / oCarTemp.MaxPalletsQnt)).ToString("###");
					}

					if (nInputsBrutto > oCarTemp.Tonnage && oCarTemp.Tonnage > 0)
					{
						txtInputsBruttoPercent.BackColor = Color.LightSalmon;
					}
					if (nInputsVolume > oCarTemp.Volume && oCarTemp.Volume > 0)
					{
						txtInputsVolumePercent.BackColor = Color.LightSalmon;
					}
					if (nInputsPalletsQnt > oCarTemp.MaxPalletsQnt && oCarTemp.MaxPalletsQnt > 0)
					{
						txtInputsPalletsQntPercent.BackColor = Color.LightSalmon;
					}
					return;
				}
			}
		}

		#endregion OutputsInputsDocumentsInfo

		#endregion ShowTotal

		#region RowEnter, CellFormatting

		private void grdOutputs_CurrentRowChanged(object sender)
		{
			if (grdOutputs.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdInputs_CurrentRowChanged(object sender)
		{
			if (grdInputs.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void grdTripsReturns_CurrentRowChanged(object sender)
		{
			if (grdTripsReturns.IsLockRowChanged)
				return;
			tmrRestore.Enabled = true;
		}

		private void tmrRestore_Tick(object sender, EventArgs e)
		{
			tmrRestore.Enabled = false;

			RFMDataGridView grd = new RFMDataGridView();
			int rowIndex = -1;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				grd = grdOutputs;

				btnOutputsAdd.Enabled = bSelfDelivery;
				btnOutputsDelete.Enabled =
				btnOutputsCreateAct.Enabled =
					false;
				btnOutputsByOrder.Enabled = (grd.Rows.Count > 0);

				if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
					return;

				rowIndex = grd.CurrentRow.Index;

				if (grd.IsStatusRow(rowIndex))
				{
					oOutputCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oOutputCur.FillOne(r);
					btnOutputsDelete.Enabled = bSelfDelivery;
					btnOutputsCreateAct.Enabled = oOutputCur.IsConfirmed;
				}
				tcOutputsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("INPUTS"))
			{
				grd = grdInputs;

				btnInputsAdd.Enabled = bSelfDelivery;
				btnInputsDelete.Enabled =
				btnInputsEdit.Enabled =
				btnInputsCreateAct.Enabled =
				btnInputsConfirmZero.Enabled =
				btnInputsCreateInputsDocuments.Enabled =
				btnInputsRecalc.Enabled =
				btnInputsConfirmZero.Enabled =  
					false;
				btnInputsByOrder.Enabled = (grd.Rows.Count > 0);
				
				if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
					return;

				rowIndex = grd.CurrentRow.Index;

				if (grd.IsStatusRow(rowIndex))
				{
					oInputCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oInputCur.FillOne(r);
					btnInputsDelete.Enabled = bSelfDelivery;
					btnInputsCreateAct.Enabled = oInputCur.IsConfirmed;
					btnInputsConfirmZero.Enabled = !oInputCur.IsConfirmed && !oInputCur.SentToWMS && !oInputCur.ReadyForWMS;
					btnInputsCreateInputsDocuments.Enabled =
					btnInputsRecalc.Enabled =
						true;
					// !oInputCur.IsConfirmed; 
					// !oInputCur.InputsDocumentsAttached 
					// !oInputCur.SentToWMS && !oInputCur.ReadyForWMS 
				}
				tcInputsGoods.SetAllNeedRestore(true);
			}

			if (sPageName.Contains("RETURNS"))
			{
				grd = grdTripsReturns;

				btnTripsReturnsAdd.Enabled = true;
				btnTripsReturnsDelete.Enabled =
				btnTripsReturnsEdit.Enabled =
					false;
				
				if (grd.CurrentRow == null || grd.CurrentRow.Index < 0)
					return;

				rowIndex = grd.CurrentRow.Index;

				if (grd.IsStatusRow(rowIndex))
				{
					oTripReturnCur.ClearOne();
				}
				else
				{
					DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[rowIndex]).DataBoundItem).Row;
					oTripReturnCur.FillOne(r);
					btnTripsReturnsDelete.Enabled = !oTripReturnCur.IsConfirmed && !oTripReturnCur.SentToWMS;
					btnTripsReturnsEdit.Enabled = !oTripReturnCur.IsConfirmed && !oTripReturnCur.SentToWMS;
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
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
			}

			// привязка с старому рейсу
			if (chkOutputsShowCarried.Checked)
			{
				if (Convert.IsDBNull(r["TripID"]) ||
					nTripID.HasValue && Convert.ToInt32(r["TripID"]) != (int)nTripID)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
					e.CellStyle.BackColor = Color.LightPink;
				}
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

			if (sColumnName.Contains("QNT") ||
				sColumnName.Contains("INBOX"))
			{
				if (!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"] &&
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
			if ((sColumnName.Contains("TTO") || sColumnName.Contains("AMOUNT")) &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}

			// копирование
			if ((bool)r["IsCopied"])
			{
				e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
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

			if (chkOutputsShowCarried.Checked)
			{
				if (Convert.IsDBNull(r["TripID"]) ||
					nTripID.HasValue && Convert.ToInt32(r["TripID"]) != (int)nTripID)
				{
					e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Strikeout);
					e.CellStyle.BackColor = Color.LightPink;
				}
			}
		}

		private void grdOutputs_Acts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;

			// подтверждение отгрузки / приема на складе
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
		}

		#region TripsReturns

		private void grdTripsReturns_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
					e.Value = Properties.Resources.Check;
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
		}

		private void grdTripsReturnsGoods_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

			if (sColumnName.Contains("QNT") ||
				sColumnName.Contains("INBOX"))
			{
				if (!Convert.IsDBNull(r["Weighting"]) && (bool)r["Weighting"] &&
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

		#endregion TripsReturns

		#region Inputs Grids Enter 

		private void grdInputs_Enter(object sender, EventArgs e)
		{
			grdInputs.IsLockRowChanged = false; 
			grdInputs_CurrentRowChanged(grdInputs);
			ttToolTip.SetToolTip(btnInputsAdd, "Прикрепить задание на приход");
			ttToolTip.SetToolTip(btnInputsDelete, "Открепить задание на приход");
		}

		private void grdInputsGoods_Enter(object sender, EventArgs e)
		{
			btnInputsAdd.Enabled =
			btnInputsEdit.Enabled =
			btnInputsDelete.Enabled =
			btnInputsByOrder.Enabled =
			btnInputsCreateAct.Enabled =
			btnInputsConfirmZero.Enabled =
			btnInputsCreateInputsDocuments.Enabled =
			btnInputsRecalc.Enabled =
				false;
		}

		private void grdInputsDocuments_Enter(object sender, EventArgs e)
		{
			btnInputsAdd.Enabled =
				(grdInputs.Rows.Count > 0); ;
			btnInputsEdit.Enabled =
			btnInputsDelete.Enabled =
				(grdInputsDocuments.Rows.Count > 0);
			ttToolTip.SetToolTip(btnInputsAdd, "Добавить приходный документ");
			ttToolTip.SetToolTip(btnInputsDelete, "Удалить приходный документ");
			btnInputsByOrder.Enabled =
			btnInputsCreateAct.Enabled =
			btnInputsConfirmZero.Enabled =
			btnInputsCreateInputsDocuments.Enabled =
			btnInputsRecalc.Enabled =
				false;
		}

		private void grdInputs_Acts_Enter(object sender, EventArgs e)
		{
			btnInputsAdd.Enabled =
			btnInputsEdit.Enabled =
			btnInputsDelete.Enabled =
			btnInputsByOrder.Enabled =
			btnInputsCreateAct.Enabled =
			btnInputsConfirmZero.Enabled =
			btnInputsCreateInputsDocuments.Enabled =
			btnInputsRecalc.Enabled =
				false;
		}

		#endregion Inputs Grids Enter

		#region Outputs Grids Enter

		private void grdOutputs_Enter(object sender, EventArgs e)
		{
			grdOutputs.IsLockRowChanged = false;
			grdOutputs_CurrentRowChanged(grdOutputs);
		}

		private void grdOutputsGoods_Enter(object sender, EventArgs e)
		{
			btnOutputsAdd.Enabled =
			btnOutputsDelete.Enabled =
			btnOutputsByOrder.Enabled =
				false;
		}

		private void grdOutputsDocuments_Enter(object sender, EventArgs e)
		{
			btnOutputsAdd.Enabled =
			btnOutputsDelete.Enabled =
			btnOutputsByOrder.Enabled =
				false;
		}

		private void grdOutputs_Acts_Enter(object sender, EventArgs e)
		{
			btnOutputsAdd.Enabled =
			btnOutputsDelete.Enabled =
			btnOutputsByOrder.Enabled =
				false;
		}

		#endregion Outputs Grids Enter

		#region TripsReturns Grids Enter

		private void grdTripsReturns_Enter(object sender, EventArgs e)
		{
			grdTripsReturns.IsLockRowChanged = false;
			grdTripsReturns_CurrentRowChanged(grdTripsReturns);
		}

		private void grdTripsReturnsGoods_Enter(object sender, EventArgs e)
		{
			btnTripsReturnsAdd.Enabled =
			btnTripsReturnsEdit.Enabled =
			btnTripsReturnsDelete.Enabled =
				false;
		}

		#endregion TripsReturns Grids Enter

		#endregion Cells...

		#region Restore

		#region ComboBox

		private bool cboCar_Restore()
		{
			cboCar.DataSource = null;
			oCar.ClearError();
			oCar.FilterActual = true;
			if (oCar.FillData())
			{
				cboCar.DataSource = new DataView(oCar.MainTable);
				cboCar.ValueMember = oCar.ColumnID;
				cboCar.DisplayMember = oCar.ColumnName;
				cboCar.Restore();
			}
			return (oCar.ErrorNumber == 0);
		}

		private bool cboDriverEmployee_Restore()
		{
			cboDriverEmployee.DataSource = null;
			oDriver.ClearError();
            oDriver.FilterForGoodsOnly = true;
			if (oDriver.FillData())
			{
				cboDriverEmployee.DataSource = new DataView(oDriver.MainTable);
				cboDriverEmployee.ValueMember = oDriver.ColumnID;
				cboDriverEmployee.DisplayMember = oDriver.ColumnName;
				cboDriverEmployee.Restore();
			}
			return (oDriver.ErrorNumber == 0);
		}

		private bool cboPermitLevel_Restore()
		{
			cboPermitLevel.DataSource = null;
			oPermitLevel.ClearError();
			if (oPermitLevel.FillData())
			{
				cboPermitLevel.DataSource = new DataView(oPermitLevel.MainTable);
				cboPermitLevel.ValueMember = oPermitLevel.ColumnID;
				cboPermitLevel.DisplayMember = oPermitLevel.ColumnName;
				cboPermitLevel.Restore();
			}
			return (oPermitLevel.ErrorNumber == 0);
		}

		private bool cboPartnerCarrier_Restore()
		{
			cboPartnerCarrier.DataSource = null;
			oPartnerCarrier.ClearError();
			oPartnerCarrier.FilterIsTransport = true;
			if (!nTripID.HasValue)
			{
				oPartnerCarrier.FilterActual = true;
				// для нового рейса - только актуальные 
			}
			if (oPartnerCarrier.FillData())
			{
				cboPartnerCarrier.DataSource = new DataView(oPartnerCarrier.MainTable);
				cboPartnerCarrier.ValueMember = oPartnerCarrier.ColumnID;
				cboPartnerCarrier.DisplayMember = oPartnerCarrier.ColumnName;
				cboPartnerCarrier.Restore();
			}
			return (oPartnerCarrier.ErrorNumber == 0);
		}

		#endregion ComboBox

		#region Grid

		private bool grdOutputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oOutputCur.ClearOne();

			oOutputList.ClearError();
			oOutputList.ClearFilters();
			oOutputList.ID = null;
			oOutputList.IDList = null;

			grdOutputs.GetGridState();

			grdOutputs.DataSource = null;
			grdOutputsDocuments.DataSource = null;
			grdOutputsGoods.DataSource = null;
			grdOutputs_Acts.DataSource = null; 

			// задания на расход, присоединенные к этому рейсу
			oTrip.FillTableOutputsInTrip(chkOutputsShowCarried.Checked);
			grdOutputs.IsLockRowChanged = true;
			grdOutputs.Restore(oTrip.TableOutputsInTrip);

			tmrRestore.Enabled = true;

			RecalcSumOutputs();
			ShowTotalInfo();

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oTrip.ErrorNumber == 0);
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

			oTrip.FillTableOutputsDocumentsInTrip((int)oOutputCur.ID, chkOutputsShowCarried.Checked);
			grdOutputsDocuments.Restore(oTrip.TableOutputsDocumentsInTrip);

			RecalcSumOutputsDocuments();
			ShowTotalInfo();

			return (oTrip.ErrorNumber == 0);
		}

		private bool grdOutputs_Acts_Restore()
		{
			grdOutputs_Acts.GetGridState();
			grdOutputs_Acts.DataSource = null;
			if (grdOutputs.Rows.Count == 0 ||
				oOutputCur.ID == null ||
				(grdOutputs.CurrentRow != null && grdOutputs.IsStatusRow(grdOutputs.CurrentRow.Index)))
				return (true);

			oActForOutput.FilterOutputsList = oOutputCur.ID.ToString();
			oActForOutput.FillData();
			grdOutputs_Acts.Restore(oActForOutput.MainTable);
			return (oActForOutput.ErrorNumber == 0);
		}


		private bool grdInputs_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oInputCur.ClearOne();

			oInputList.ClearError();
			oInputList.ClearFilters();
			oInputList.ID = null;
			oInputList.IDList = null;

			grdInputs.GetGridState();

			grdInputs.DataSource = null;
			grdInputsDocuments.DataSource = null;
			grdInputsGoods.DataSource = null;
			grdInputs_Acts.DataSource = null; 

			// задания на расход, присоединенные к этому рейсу
			oTrip.FillTableInputsInTrip(chkOutputsShowCarried.Checked);
			grdInputs.IsLockRowChanged = true;
			grdInputs.Restore(oTrip.TableInputsInTrip);

			tmrRestore.Enabled = true;

			RecalcSumInputs();
			ShowTotalInfo();

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oTrip.ErrorNumber == 0);
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

			oTrip.FillTableInputsDocumentsInTrip((int)oInputCur.ID, chkOutputsShowCarried.Checked);
			grdInputsDocuments.Restore(oTrip.TableInputsDocumentsInTrip);

			RecalcSumInputsDocuments();
			ShowTotalInfo();

			return (oTrip.ErrorNumber == 0);
		}

		private bool grdInputs_Acts_Restore()
		{
			grdInputs_Acts.GetGridState();
			grdInputs_Acts.DataSource = null;
			if (grdInputs.Rows.Count == 0 ||
				oInputCur.ID == null ||
				(grdInputs.CurrentRow != null && grdInputs.IsStatusRow(grdInputs.CurrentRow.Index)))
				return (true);

			oActForInput.FilterInputsList = oInputCur.ID.ToString();
			oActForInput.FillData();
			grdInputs_Acts.Restore(oActForInput.MainTable);
			return (oActForInput.ErrorNumber == 0);
		}

		private bool grdTripsReturns_Restore()
		{
			RFMCursorWait.Set(true);
			RFMCursorWait.LockWindowUpdate(FindForm().Handle);

			oTripReturnCur.ClearOne();

			oTripReturnList.ClearError();
			oTripReturnList.ClearFilters();
			oTripReturnList.ID = null;
			oTripReturnList.IDList = null;

			grdTripsReturns.GetGridState();

			grdTripsReturns.DataSource = null;
			grdTripsReturnsGoods.DataSource = null;

			// задания на расход, присоединенные к этому рейсу
            if (nTripID.HasValue)
			    oTripReturnList.FilterTripsList = nTripID.ToString();
			oTripReturnList.FillData();
			grdTripsReturns.IsLockRowChanged = true;
			grdTripsReturns.Restore(oTripReturnList.MainTable);

			tmrRestore.Enabled = true;

			RFMCursorWait.LockWindowUpdate(IntPtr.Zero);
			RFMCursorWait.Set(false);

			return (oTrip.ErrorNumber == 0);
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
			grdTripsReturnsGoods.Restore(oTripReturnList.TableTripsReturnsGoods);
			return (oTripReturnList.ErrorNumber == 0);
		}

		#endregion Grid

		private void chkShowCarried_CheckedChanged(object sender, EventArgs e)
		{
			RFMCursorWait.Set(true);
			grdOutputs_Restore();
			grdInputs_Restore();
			RFMCursorWait.Set(false);
		}

		#endregion Restore

		#region ReCalc

		private void RecalcSumOutputs()
		{
			int nOutputsDocumentsQnt = 0, nPointsQnt = 0;
			decimal nNetto = 0, nBrutto = 0, nVolume = 0, nPalletsQnt = 0;
			nOutputsQnt = oTrip.TableOutputsInTrip.Rows.Count;
			string sOutputsList = "";
			foreach (DataRow r in oTrip.TableOutputsInTrip.Rows)
			{
				sOutputsList += r["ID"].ToString() + ",";
			}
			Output oOutputCalc = new Output();
			oOutputCalc.CalcSum(sOutputsList,
				ref nOutputsQnt, ref nOutputsDocumentsQnt, ref nPointsQnt,
				ref nNetto, ref nBrutto, ref nVolume, ref nPalletsQnt);

			nOutputsOutputsDocumentsQnt = nOutputsDocumentsQnt;
			nOutputsPointsQnt = nPointsQnt;
			nOutputsNetto = nNetto;
			nOutputsBrutto = nBrutto;
			nOutputsVolume = nVolume;
			nOutputsPalletsQnt = nPalletsQnt;

			return;
		}

		private void RecalcSumInputs()
		{
			int nInputsDocumentsQnt = 0, nPointsQnt = 0;
			decimal nNetto = 0, nBrutto = 0, nVolume = 0, nPalletsQnt = 0;
			nInputsQnt = oTrip.TableInputsInTrip.Rows.Count;
			string sInputsList = "";
			foreach (DataRow r in oTrip.TableInputsInTrip.Rows)
			{
				sInputsList += r["ID"].ToString() + ",";
			}
			Input oInputCalc = new Input();
			oInputCalc.CalcSum(sInputsList,
				ref nInputsQnt, ref nInputsDocumentsQnt, ref nPointsQnt,
				ref nNetto, ref nBrutto, ref nVolume, ref nPalletsQnt);

			nInputsInputsDocumentsQnt = nInputsDocumentsQnt;
			nInputsPointsQnt = nPointsQnt;
			nInputsNetto = nNetto;
			nInputsBrutto = nBrutto;
			nInputsVolume = nVolume;
			nInputsPalletsQnt = nPalletsQnt;

			return;
		}

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

		private void RecalcSumInputsDocuments()
		{
			int nPartnersQnt = 0, nPointsQnt = 0;
			decimal nNetto = 0, nBrutto = 0, nVolume = 0, nPalletsQnt = 0;
			nInputsDocumentsQnt = oTrip.TableInputsDocumentsInTrip.Rows.Count;
			string sInputsDocumentsList = "";
			foreach (DataRow r in oTrip.TableInputsDocumentsInTrip.Rows)
			{
				sInputsDocumentsList += r["ID"].ToString() + ",";
			}
			InputDocument oInputDocumentCalc = new InputDocument();
			oInputDocumentCalc.CalcSum(sInputsDocumentsList,
				ref nInputsDocumentsQnt, ref nPartnersQnt, ref nPointsQnt,
				ref nNetto, ref nBrutto, ref nVolume, ref nPalletsQnt);

			nInputsDocumentsPartnersQnt = nPartnersQnt; 
			nInputsDocumentsPointsQnt = nPointsQnt;
			nInputsDocumentsNetto = nNetto;
			nInputsDocumentsBrutto = nBrutto;
			nInputsDocumentsVolume = nVolume;
			nInputsDocumentsPalletsQnt = nPalletsQnt;

			return;
		}

		#endregion ReCalc

		#region Other/Partner Car Select

		private void btnOtherOrPartnerCarSelect_Click(object sender, EventArgs e)
		{
			_SelectedID = null;
			_SelectedText = "";

			// ранее введеные значения 
			Trip oTripTemp = new Trip();
			if (((RFMButton)sender).Name.Contains("Other"))
			{
				// аренда
				oTripTemp.FilterIsRentCar = true;
				oTripTemp.FilterSelfDelivery = false;
			}
			else
			{
				// самовывоз/самопривоз
				oTripTemp.FilterSelfDelivery = true;
			}
			oTripTemp.FillData();
			if (oTripTemp.ErrorNumber != 0 || oTripTemp.MainTable == null)
				return;
			if (oTripTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			DataTable tdCar = CopyTable(oTripTemp.MainTable, "tdCar", "", "Alias");
			if (StartForm(new frmSelectID(this, tdCar, "Alias", "Описание", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				oTripTemp.ClearData();
				oTripTemp.ReFillOne((int)_SelectedID);
				txtCarName.Text = oTripTemp.CarName;
				txtCarTypeName.Text = oTripTemp.CarTypeName;
				txtCarNumber.Text = oTripTemp.CarNumber;
				txtTrailerNumber.Text = oTripTemp.TrailerNumber;
			}
			_SelectedID = null;
			_SelectedText = "";
		}

		#endregion Other/Partner Car Select


		#region Service

		private void btnService_Click(object sender, EventArgs e)
		{
			btnService.ShortCutShow();
		}

		private void mniCreatePass_Click(object sender, EventArgs e)
		{
			CreatePass();
		}

		private void CreatePass()
		{
			// создать новый пропуск
			if (true) //(!nTripID.HasValue)
			{
				// сохранить рейс, не закрывая форму
				bDispose = false;
				btnSave_Click(null, null);
				bDispose = true;
				if (!bSavedOK)
				{
					return;
				}
			}

			LogService.PassCreateForTrip((int)nTripID);
		}

		#endregion Service

		#region Print

		private void btnPrint_Click(object sender, EventArgs e)
		{
		}

		#endregion Print

		#region ByOrder

		private void btnByOrder_Click(object sender, EventArgs e)
		{
			int nByOrder = 0;
			string sNumber = "-", sMiddleNumber = "-";
			string sDelimiter = ";", sMiddleDelimiter = ",";

			string sPageName = tcList.CurrentPage.Name.ToUpper(); 

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.Rows.Count == 0)
					return;

				gotParam = null;
				if (StartForm(new frmByOrder(oTrip.TableOutputsInTrip, "ByOrder, PartnerName, Brutto#3, Note", "ПЗ, Клиент, Брутто, Примечание", "ID")) != DialogResult.Yes)
					return;
				string strInput = GotParam[0].ToString();
				if (strInput != null && strInput.Length > 0)
				{
					Output oOutput = new Output();

					// разбираем строку
					int nOutputTempID = 0;
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
									nOutputTempID = Convert.ToInt32(sMiddleNumber);
								}
								catch
								{
									nOutputTempID = 0;
								}
								if (nOutputTempID > 0)
								{
									oOutput.SaveByOrder(nOutputTempID, nByOrder);
								}
								sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
							}
						}
						else
						{
							try
							{
								nOutputTempID = Convert.ToInt32(sNumber);
							}
							catch
							{
								nOutputTempID = 0;
							}
							if (nOutputTempID > 0)
							{
								oOutput.SaveByOrder(nOutputTempID, nByOrder);
							}
						}
						sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
					}
				}
				grdOutputs.Refresh();
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.Rows.Count == 0)
					return;

				gotParam = null;
				if (StartForm(new frmByOrder(oTrip.TableInputsInTrip, "ByOrder, PartnerName, Brutto#3, Note", "ПЗ, Клиент, Брутто, Примечание", "ID")) != DialogResult.Yes)
					return;
				string strInput = GotParam[0].ToString();
				if (strInput != null && strInput.Length > 0)
				{
					Input oInput = new Input();

					// разбираем строку
					int nInputTempID = 0;
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
									nInputTempID = Convert.ToInt32(sMiddleNumber);
								}
								catch
								{
									nInputTempID = 0;
								}
								if (nInputTempID > 0)
								{
									oInput.SaveByOrder(nInputTempID, nByOrder);
								}
								sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
							}
						}
						else
						{
							try
							{
								nInputTempID = Convert.ToInt32(sNumber);
							}
							catch
							{
								nInputTempID = 0;
							}
							if (nInputTempID > 0)
							{
								oInput.SaveByOrder(nInputTempID, nByOrder);
							}
						}
						sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
					}
				}
				grdInputs.Refresh();
			}
		}

		#endregion ByOrder

		#region Grid Buttons 

		#region Inputs, Outputs 

		private void btnAdd_Click(object sender, EventArgs e)
		{
			// сохранить рейс
			if (!nTripID.HasValue || nTripID == 0)
			{
				bDispose = false;
				btnSave_Click(null, null);
				bDispose = true;
				if (!bSavedOK)
					return;
			}

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			// выбор и привязка
			if (sPageName.Contains("OUTPUTS"))
			{
				if (oTrip.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Рейс уже подтвержден.");
					return;
				}
				if (oTrip.DateEnd.HasValue)
				{
					RFMMessage.MessageBoxError("Рейс уже окончен.");
					return;
				}
				if (oTrip.ReadyForTripEnd != null && (bool)oTrip.ReadyForTripEnd)
				{
					RFMMessage.MessageBoxError("Рейс уже готов к окончанию.");
					return;
				}
				/*
				if (oTrip.DateBeg.HasValue)
				{
					RFMMessage.MessageBoxError("Рейс уже начат.");
					return;
				}
				*/

				Output oOutputAdd = new Output();
				oOutputAdd.FilterDateBeg =
				oOutputAdd.FilterDateEnd =
					oTrip.DateTrip;
				oOutputAdd.FilterDeliveryNeed = (!bSelfDelivery);
				oOutputAdd.FilterTripExists = false;

				_SelectedOutputsIDList = null;
				if (StartForm(new frmSelectOneOutput(this, true, oOutputAdd)) == DialogResult.Yes)
				{
					if (_SelectedOutputsIDList == null || !_SelectedOutputsIDList.Contains(","))
						return;

					oOutputAdd.ClearFilters();
					oOutputAdd.IDList = "," + _SelectedOutputsIDList;
					oOutputAdd.FillData();
					if (oOutputAdd.MainTable == null || oOutputAdd.MainTable.Rows.Count == 0)
						return;
					else
					{
						foreach (DataRow o in oOutputAdd.MainTable.Rows)
						{
							oOutputAdd.ClearError();
							oOutputAdd.FillOne(o);

							// проверка состояния расхода - по расх.документам
							OutputDocument oOutputDocumentTemp = new OutputDocument();
							oOutputDocumentTemp.FilterOutputsList = o["ID"].ToString();
							foreach (DataRow od in oOutputDocumentTemp.MainTable.Rows)
							{
								if ((bool)od["IsBrought"])
								{
									RFMMessage.MessageBoxError("Для складского задания на расход с кодом " + o["ID"].ToString() + " есть расходные документы, которые уже доставлены клиенту...");
									return;
								}
							}

							// если задание с другой датой
							DateTime dDateOld = oOutputAdd.DateOutput;
							if (oOutputAdd.DateOutput.Date.CompareTo(oTrip.DateTrip) != 0)
							{
								if (RFMMessage.MessageBoxYesNo("Для задания на расход с кодом " + oOutputAdd.ID.ToString() + " дата (" + oOutputAdd.DateOutput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n\n" +
									"Изменить дату задания на расход и входящих в него расходных документов в соответствии с датой рейса?") == DialogResult.Yes)
								{
									oOutputAdd.ChangeDate((int)oOutputAdd.ID, oTrip.DateTrip);
								}
							}

							// собственно привязка
							oOutputAdd.ToTrip((int)oOutputAdd.ID, (int)nTripID);

							// поискать задания на ту же дату тому же партнеру,
							// которые могла бы взять эта же машина
							if (oOutputAdd.PartnerID.HasValue)
							{
								if (dDateOld.CompareTo(oTrip.DateTrip) != 0)
								{
									// была смена даты. на ту же - старую - дату
									FindOtherPuts(oOutputAdd, null, dDateOld, _SelectedOutputsIDList, null); 
								}

								// на дату рейса
								FindOtherPuts(oOutputAdd, null, oTrip.DateTrip, _SelectedOutputsIDList, null); 
							}
						}
						grdOutputs_Restore();

						int nOutputLastID = (int)oOutputAdd.MainTable.Rows[oOutputAdd.MainTable.Rows.Count - 1]["ID"];
						grdOutputs.GridSource.Position = grdOutputs.GridSource.Find("ID", nOutputLastID);
					}
				}
				_SelectedOutputsIDList = null;
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (LastGrid.Name.ToUpper().Contains("DOCUMENTS"))
				{
					if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
						!oInputCur.ID.HasValue)
						return;

					btnInputsCreateInputsDocuments_Click(null, null);
				}
				else
				{
					if (oTrip.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Рейс уже подтвержден.");
						return;
					}
					if (oTrip.DateEnd.HasValue)
					{
						RFMMessage.MessageBoxError("Рейс уже окончен.");
						return;
					}
					if (oTrip.ReadyForTripEnd != null && (bool)oTrip.ReadyForTripEnd)
					{
						RFMMessage.MessageBoxError("Рейс уже готов к окончанию.");
						return;
					}
					/*
					if (oTrip.DateBeg.HasValue)
					{
						RFMMessage.MessageBoxError("Рейс уже начат.");
						return;
					}
					*/ 

					Input oInputAdd = new Input();
					oInputAdd.FilterDateBeg =
					oInputAdd.FilterDateEnd =
						oTrip.DateTrip;
					oInputAdd.FilterDeliveryNeed = (!bSelfDelivery);
					oInputAdd.FilterTripExists = false;

					_SelectedInputsIDList = null;
					if (StartForm(new frmSelectOneInput(this, true, oInputAdd)) == DialogResult.Yes)
					{
						if (_SelectedInputsIDList == null || !_SelectedInputsIDList.Contains(","))
							return;

						oInputAdd.ClearFilters();
						oInputAdd.IDList = "," + _SelectedInputsIDList;
						oInputAdd.FillData();
						if (oInputAdd.MainTable == null || oInputAdd.MainTable.Rows.Count == 0)
							return;
						else
						{
							foreach (DataRow i in oInputAdd.MainTable.Rows)
							{
								oInputAdd.ClearError();
								oInputAdd.FillOne(i);
								// если задание с другой датой 
								DateTime dDateOld = oInputAdd.DateInput;
								if (oInputAdd.DateInput.Date.CompareTo(oTrip.DateTrip) != 0)
								{
									/*
									if (RFMMessage.MessageBoxYesNo("Для задания на приход с кодом " + oInputAdd.ID.ToString() + " дата (" + oInputAdd.DateInput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
										"Изменить дату задания на приход" +
										((oInputAdd.InputsDocumentsExists) ? " и входящих в него приходных документов" : "") + " в соответствии с датой рейса?") == DialogResult.Yes)
									{
										oInputAdd.ChangeDate((int)oInputAdd.ID, oTrip.DateTrip);
									}
									*/
									RFMMessage.MessageBoxAttention("Для задания на приход с кодом " + oInputAdd.ID.ToString() + " дата (" + oInputAdd.DateInput.ToString("dd.MM.yyyy") + ") не совпадает с датой рейса.\n" +
										"Дата задания на приход" +
										((oInputAdd.InputsDocumentsExists) ? " и входящих в него приходных документов" : "") +
										" будет изменена в соответствии с датой рейса.");
									oInputAdd.ChangeDate((int)oInputAdd.ID, oTrip.DateTrip);
								}
								// собственно привязка
								oInputAdd.ToTrip((int)oInputAdd.ID, (int)nTripID);

								// поискать задания на ту же дату тому же партнеру / от того же партнера,
								// которые могла бы взять эта же машина
								if (oInputAdd.PartnerID.HasValue)
								{
									if (dDateOld.CompareTo(oTrip.DateTrip) != 0)
									{
										// была смена даты. на ту же - старую - дату
										FindOtherPuts(null, oInputAdd, dDateOld, null, _SelectedInputsIDList);
									}

									// на дату рейса
									FindOtherPuts(null, oInputAdd, oTrip.DateTrip, null, _SelectedInputsIDList);
								}
							}
							grdInputs_Restore();

							int nInputLastID = (int)oInputAdd.MainTable.Rows[oInputAdd.MainTable.Rows.Count - 1]["ID"];
							grdInputs.GridSource.Position = grdInputs.GridSource.Find("ID", nInputLastID);
						}
					}
					_SelectedInputsIDList = null;
				}
			}
		}

		private void FindOtherPuts(Output oOutputAdd, Input oInputAdd, 
			DateTime dDate, 
			string sListOutputsAdded, string sListInputsAdded)
		{
			int nPartnerID = 0;
			string sPartnerName = "";
			if (oOutputAdd != null)
			{
				if (oOutputAdd.PartnerID.HasValue) 
					nPartnerID = (int)oOutputAdd.PartnerID;
				sPartnerName = oOutputAdd.PartnerName;
			}
			else
			{
				if (oInputAdd != null)
				{
					if (oInputAdd.PartnerID.HasValue)
						nPartnerID = (int)oInputAdd.PartnerID;
					sPartnerName = oInputAdd.PartnerName;
				}
			}

			// расходы на ту же дату
			Output oOutputAddTemp = new Output();
			oOutputAddTemp.FilterDeliveryNeed = (!bSelfDelivery);
			oOutputAddTemp.FilterTripExists = false;
			oOutputAddTemp.FilterPartnersList = nPartnerID.ToString();
			oOutputAddTemp.FilterDateBeg =
			oOutputAddTemp.FilterDateEnd =
				dDate;
			oOutputAddTemp.FillData();
			if (oOutputAddTemp.ErrorNumber == 0 &&
				oOutputAddTemp.MainTable != null && oOutputAddTemp.MainTable.Rows.Count > 0)
			{
				// только те, которых нет среди выбранных
				string sFilter = (sListOutputsAdded == null) ? "" : "not (ID in (" + RFMUtilities.NormalizeList(sListOutputsAdded) + "))";
				DataTable dtOutputAddTemp = CopyTable(oOutputAddTemp.MainTable, "dtOutputAddTemp", sFilter, "ID");
				if (dtOutputAddTemp != null && dtOutputAddTemp.Rows.Count > 0)
				{
					object oSum = dtOutputAddTemp.Compute("Sum(Brutto)", "");
					string sText = "ВНИМАНИЕ!\n\n" +
						"На " + dDate.ToString("dd.MM.yyyy") + " имеется еще " + RFMUtilities.Declen(dtOutputAddTemp.Rows.Count, "задание", "задания", "заданий") +
						" на РАСХОД для партнера \"" + sPartnerName + "\"";
					sText += (oSum != null)
						? ",\n" +
						"общим весом " + Convert.ToDecimal(oSum) + " кг.\n\n"
						: ".\n\n";
					sText += (dDate.CompareTo(oTrip.DateTrip) != 0) 
						? "Перенести " + ((dtOutputAddTemp.Rows.Count > 1) ? "эти задания" : "это задание") + " на " + oTrip.DateTrip.ToString("dd.MM.yyyy") + 
							" и прикрепить к рейсу?"
						: "Прикрепить " + ((dtOutputAddTemp.Rows.Count > 1) ? "эти задания" : "это задание") + " к рейсу?";
					if (RFMMessage.MessageBoxYesNo(sText) == DialogResult.Yes)
					{
						foreach (DataRow rOATemp in dtOutputAddTemp.Rows)
						{
							if (dDate.CompareTo(oTrip.DateTrip) != 0)
							{
								oOutputAddTemp.ChangeDate((int)rOATemp["ID"], oTrip.DateTrip);
							}

							oOutputAddTemp.ToTrip((int)rOATemp["ID"], (int)nTripID);
						}
						if (oOutputAdd == null)
						{
							grdOutputs_Restore();
						}
					}
				}
			}

			// приходы на ту же дату 
			Input oInputAddTemp = new Input();
			oInputAddTemp.ClearFilters();
			oInputAddTemp.FilterDeliveryNeed = (!bSelfDelivery);
			oInputAddTemp.FilterTripExists = false;
			oInputAddTemp.FilterPartnersList = nPartnerID.ToString();
			oInputAddTemp.FilterDateBeg =
			oInputAddTemp.FilterDateEnd =
				dDate;
			oInputAddTemp.FillData();
			if (oInputAddTemp.ErrorNumber == 0 &&
				oInputAddTemp.MainTable != null && oInputAddTemp.MainTable.Rows.Count > 0)
			{
				string sFilter = (sListInputsAdded == null) ? "" : "not (ID in (" + RFMUtilities.NormalizeList(sListInputsAdded) + "))";
				DataTable dtInputAddTemp = CopyTable(oInputAddTemp.MainTable, "dtInputAddTemp", sFilter, "ID");
				if (dtInputAddTemp != null && dtInputAddTemp.Rows.Count > 0)
				{
					string sText = "ВНИМАНИЕ!\n\n" +
					"На " + dDate.ToString("dd.MM.yyyy") + " имеется еще " + RFMUtilities.Declen(dtInputAddTemp.Rows.Count, "задание", "задания", "заданий") +
					" на ПРИХОД от партнера \"" + sPartnerName + "\".\n\n";
					sText += (dDate.CompareTo(oTrip.DateTrip) != 0)
						? "Перенести " + ((dtInputAddTemp.Rows.Count > 1) ? "эти задания" : "это задание") + " и соответствующие приходные документы на " + oTrip.DateTrip.ToString("dd.MM.yyyy") + 
							" и прикрепить к рейсу?"
						: "Прикрепить " + ((dtInputAddTemp.Rows.Count > 1) ? "эти задания" : "это задание") + " к рейсу?";
					if (RFMMessage.MessageBoxYesNo(sText) == DialogResult.Yes)
					{
						foreach (DataRow rIATemp in dtInputAddTemp.Rows)
						{
							if (dDate.CompareTo(oTrip.DateTrip) != 0)
							{
								oInputAddTemp.ChangeDate((int)rIATemp["ID"], oTrip.DateTrip);
							}

							oInputAddTemp.ToTrip((int)rIATemp["ID"], (int)nTripID);
						}
						if (oInputAdd == null)
						{
							grdInputs_Restore();
						}
					}
				}
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0 )
				return;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.Rows.Count == 0 || grdOutputs.CurrentRow == null ||
					!oOutputCur.ID.HasValue)
					return;

				// проверка состояния рейса
				oTrip.ReFillOne((int)nTripID);
				if (oTrip.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Рейс уже подтвержден.");
					return;
				}
				if (oTrip.DateEnd.HasValue)
				{
					RFMMessage.MessageBoxError("Рейс уже окончен.");
					return;
				}

				// проверка состояния расхода - по расх.документам
				OutputDocument oOutputDocumentTemp = new OutputDocument();
				oOutputDocumentTemp.FilterOutputsList = oOutputCur.ID.ToString();
				foreach (DataRow od in oOutputDocumentTemp.MainTable.Rows)
				{
					if ((bool)od["IsBrought"])
					{
						RFMMessage.MessageBoxError("Для складского задания на расход есть расходные документы, которые уже доставлены клиенту...");
						return;
					}
				}
				// 

				bool bAsked = false;
				if (oOutputCur.IsConfirmed)
				{
					if (RFMMessage.MessageBoxYesNo("Задание на расход уже подтверждено на складе.\n" +
						"Все-таки открепить задание от рейса?") != DialogResult.Yes)
						return;
					bAsked = true;
				}
				if (!bAsked)
				{
					if (RFMMessage.MessageBoxYesNo("Открепить задание на расход от рейса?") != DialogResult.Yes)
						return;
				}

				int nOutputID = (int)oOutputCur.ID;
				oOutputCur.ClearError();
				oOutputCur.UnToTrip();
				grdOutputs_Restore();
			}

			if (sPageName.Contains("INPUTS"))
			{
				if (LastGrid.Name.ToUpper().Contains("DOCUMENTS"))
				{
					// удаляем документ
					if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
						!oInputCur.ID.HasValue ||
						grdInputsDocuments.Rows.Count == 0 || grdInputsDocuments.CurrentRow == null)
						return;

					int nInputDocumentID = Convert.ToInt32(grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value);
					InputDocument oInputDocument = new InputDocument();
					oInputDocument.ReFillOne(nInputDocumentID);
					/*
					if (oInputDocument.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Приходный документ уже подтвержден.");
						return;
					}
					*/ 

					if (RFMMessage.MessageBoxYesNo("Удалить приходный документ?") == DialogResult.Yes)
					{ 
						oInputDocument.Delete((int)oInputDocument.ID);
						grdInputs_Restore();
					}
				}
				else
				{
					// удаляем задание
					if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
						!oInputCur.ID.HasValue)
						return;

					// проверка состояния рейса
					oTrip.ReFillOne((int)nTripID);
					if (oTrip.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Рейс уже подтвержден.");
						return;
					}
					if (oTrip.DateEnd.HasValue)
					{
						RFMMessage.MessageBoxError("Рейс уже окончен.");
						return;
					}
					// 

					bool bAsked = false;
					if (oInputCur.IsConfirmed)
					{
						if (RFMMessage.MessageBoxYesNo("Задание на приход уже подтверждено на складе.\n" +
							"Все-таки открепить задание от рейса?") != DialogResult.Yes)
							return;
						bAsked = true;
					}
					if (!bAsked)
					{
						if (RFMMessage.MessageBoxYesNo("Открепить задание на приход от рейса?") != DialogResult.Yes)
							return;
					}

					int nInputID = (int)oInputCur.ID;
					oInputCur.ClearError();
					oInputCur.UnToTrip();
					grdInputs_Restore();
				}
			}
		}

		private void btnCreateAct_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("OUTPUTS"))
			{
				if (grdOutputs.Rows.Count == 0 || grdOutputs.CurrentRow == null ||
					!oOutputCur.ID.HasValue)
					return;

				if (!oOutputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на расход еще не подтверждено на складе.");
					return;
				}
				if (oOutputCur.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("Для складского задания на расход уже существует акт.\nСоздать еще один акт?") != DialogResult.Yes)
						return;
				}

				if (StartForm(new frmActsEdit(0, null, (int)oOutputCur.ID)) == DialogResult.Yes)
				{
					grdOutputs_Restore();
				}
			}
			
			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				if (!oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход еще не подтверждено на складе.");
					return;
				}
				if (oInputCur.ActsExists)
				{
					if (RFMMessage.MessageBoxYesNo("Для складского задания на приход уже существует акт.\nСоздать еще один акт?") != DialogResult.Yes)
						return;
				}

				if (StartForm(new frmActsEdit(0, (int)oInputCur.ID, null)) == DialogResult.Yes)
				{
					grdInputs_Restore();
				}
			}
		}

		private void btnInputsEdit_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			// редактируем или задание или заказ, в зависимости от того, в каком гриде стоим

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("INPUTS"))
			{
				if (LastGrid.Name.ToUpper().Contains("DOCUMENTS"))
				{
					// редактируем документ
					if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
						!oInputCur.ID.HasValue ||
						grdInputsDocuments.Rows.Count == 0 || grdInputsDocuments.CurrentRow == null)
						return;
					
					int nInputDocumentID = Convert.ToInt32(grdInputsDocuments.CurrentRow.Cells["grcInputsDocuments_ID"].Value);
					InputDocument oInputDocument = new InputDocument();
					oInputDocument.ReFillOne(nInputDocumentID);
					if (oInputDocument.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Приходный документ уже подтвержден.");
						return;
					}

					if (StartForm(new frmInputsDocumentsEdit(nInputDocumentID)) == DialogResult.Yes)
					{
						// не нужно ли чего сделать с соотв.приходом? пока нет
						grdInputs_Restore();
					}
				}
				else
				{
					// редактируем задание
					/*
					if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
						!oInputCur.ID.HasValue)
						return;

					if (oInputCur.IsConfirmed)
					{
						RFMMessage.MessageBoxError("Задание на приход уже подтверждено на складе.");
						return;
					}
					if (oInputCur.SentToWMS)
					{
						RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему.");
						return;
					}
					if (oInputCur.ReadyForWMS)
					{
						RFMMessage.MessageBoxError("Задание на приход уже подготовлено для передачи в складскую систему.");
						return;
					}

					if (StartForm(new frmInputsEdit((int)oInputCur.ID)) == DialogResult.Yes)
					{
						grdInputs_Restore();
					}
					*/ 
				}
			}
		}

		private void btnInputsCreateInputsDocuments_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			if (!oTrip.DateBeg.HasValue)
			{
				RFMMessage.MessageBoxError("Рейс еще не начат...");
				return; 
			}

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				InputDocument oInputDocument = new InputDocument();
				oInputDocument.FilterInputsList = oInputCur.ID.ToString();
				oInputDocument.FillData();
				if (oInputDocument.MainTable == null)
					return;

				bool bAdd = false;
//				int? nNewInputDocumentID = null;
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
//					oInputCur.InputsDocumentsCreateFromInputs((int)oInputCur.ID, ref nNewInputDocumentID); 
//					if (nNewInputDocumentID.HasValue)
//					{
                    if (StartForm(new frmInputsDocumentsEdit((int)oInputCur.ID, 0)) == DialogResult.Yes)
							grdInputs_Restore();
//					}
				}
			}
		}

		private void btnInputsRecalc_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				/*
				if (oInputCur.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено на складе.");
					return;
				}
				if (oInputCur.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему.");
					return;
				}
				*/ 
				if (!oInputCur.InputsDocumentsExists)
				{
					RFMMessage.MessageBoxError("Задание на приход не имеет документов.");
					return;
				}

				InputDocument oInputDocument = new InputDocument();
				oInputDocument.FilterInputsList = oInputCur.ID.ToString();
				oInputDocument.FillData();
				if (oInputDocument.MainTable == null || oInputDocument.MainTable.Rows.Count == 0)
				{
					RFMMessage.MessageBoxError("Нет данных о документах для задания на приход...");
					return;
				}

				// можно пересчитывать
				if (RFMMessage.MessageBoxYesNo("Обновить количество товара по документам в задании на приход (документов: " + oInputDocument.MainTable.Rows.Count.ToString() + ")?") == DialogResult.Yes)
				{
					oInputCur.UpdateFromInputsDocuments((int)oInputCur.ID);
					grdInputs_Restore();
				}
			}
		}

		private void btnInputsConfirmZero_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			string sPageName = tcList.CurrentPage.Name.ToUpper();

			if (sPageName.Contains("INPUTS"))
			{
				if (grdInputs.Rows.Count == 0 || grdInputs.CurrentRow == null ||
					!oInputCur.ID.HasValue)
					return;

				int nInputID = (int)oInputCur.ID;

				Input oInputConfirmZero = new Input();
				oInputConfirmZero.ReFillOne(nInputID);

				if (oInputConfirmZero.IsConfirmed)
				{
					RFMMessage.MessageBoxError("Задание на приход уже подтверждено на складе.");
					return;
				}
				if (oInputConfirmZero.SentToWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже передано в складскую систему.");
					return;
				}
				if (oInputConfirmZero.ReadyForWMS)
				{
					RFMMessage.MessageBoxError("Задание на приход уже готово для передачи в складскую систему.");
					return;
				}

				// проверить, что в приходе все количества по документам = 0 
				oInputConfirmZero.FillTableInputsGoods((int)oInputConfirmZero.ID);
				if (oInputConfirmZero.ErrorNumber != 0 || oInputConfirmZero.TableInputsGoods == null)
					return;
				if (oInputConfirmZero.TableInputsGoods.Rows.Count > 0)
				{
					foreach (DataRow ig in oInputConfirmZero.TableInputsGoods.Rows)
					{
						if (Convert.ToDecimal(ig["QntDocuments"]) > 0)
						{
							RFMMessage.MessageBoxError("Для задания на приход уже определено количество по документам...");
							return;
						}
					}
				}

				string sConfirmText = "Для задания на приход не оформлены расходные документы.";
				if (oInputConfirmZero.InputsDocumentsExists)
				{
					// проверить, что все документы имеют количество = 0 
					bool bEdited = false;
					InputDocument oInputDocumentTemp = new InputDocument();
					oInputDocumentTemp.FilterInputsList = nInputID.ToString();
					oInputDocumentTemp.FillData();
					if (oInputDocumentTemp.ErrorNumber != 0 || oInputDocumentTemp.MainTable == null)
						return;
					if (oInputDocumentTemp.MainTable.Rows.Count > 0)
					{
						foreach (DataRow id in oInputDocumentTemp.MainTable.Rows)
						{
							oInputDocumentTemp.FillTableInputsDocumentsGoods((int)id["ID"]);
							foreach (DataRow idg in oInputDocumentTemp.TableInputsDocumentsGoods.Rows)
							{
								if (Convert.ToDecimal(idg["Qnt"]) > 0)
								{
									bEdited = true;
									break;
								}
							}
						}
						if (bEdited)
						{
							RFMMessage.MessageBoxError("Для задания на приход уже оформлены приходные документы и\n" +
								"определено количество по документам...");
							return;
						}
						sConfirmText = "Для задания на приход оформлены расходные документы (" + oInputDocumentTemp.MainTable.Rows.Count.ToString().Trim() + "),\n" +
							"но не определено количество товара по документам.";
					}
				}
				
				// можно подтверждать
				if (RFMMessage.MessageBoxYesNo(sConfirmText + "\n\n" + 
					"Вы действительно хотите зарегистрировать полную непоставку товара\n" + 
					"(задание на приход будет подтверждено, количество полученного товара равно 0)?") == DialogResult.Yes)
				{
					if (RFMMessage.MessageBoxYesNo("Внимание!\n\n" +
						"Операция подтвержения полной непоставки товара по приходу является необратимой!\n\n" +
						"Все-таки выполнить подтверждение прихода?", false) == DialogResult.Yes)
					{
						oInputConfirmZero.Confirm();
						grdInputs_Restore();
					}
				}
			}
		}

		#endregion Inputs, Outputs

		#region TripsReturns

		private void btnTripsReturnsAdd_Click(object sender, EventArgs e)
		{
			// сохранить рейс
			if (!nTripID.HasValue || nTripID == 0)
			{
				bDispose = false;
				btnSave_Click(null, null);
				bDispose = true;
				if (!bSavedOK)
					return;
			}

			if (LogService.TripReturn_AutoCreate((int)nTripID, this))
			{
				grdTripsReturns_Restore();
			}
			else
			{
				if (RFMMessage.MessageBoxYesNo("Добавить возврат для ручного ввода?") == DialogResult.Yes)
				{
					if (StartForm(new frmTripsReturnsEdit(0, (int)nTripID)) == DialogResult.Yes)
					{
						grdTripsReturns_Restore();
					}
				}
			}
		}

		private void btnTripsReturnsEdit_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			if (grdTripsReturns.Rows.Count == 0 || grdTripsReturns.CurrentRow == null ||
				!oTripReturnCur.ID.HasValue)
				return;
					
			int nTripReturnID = Convert.ToInt32(grdTripsReturns.CurrentRow.Cells["grcTrips_TripsReturns_ID"].Value);
			TripReturn oTripReturn = new TripReturn();
			oTripReturn.ReFillOne(nTripReturnID);
			if (oTripReturn.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Возврат уже подтвержден.\n" + 
					"Редактирование невозможно.");
				return;
			}

			if (StartForm(new frmTripsReturnsEdit(nTripReturnID, (int)nTripID)) == DialogResult.Yes)
			{
				grdTripsReturns_Restore();
			}
		}

		private void btnTripsReturnsDelete_Click(object sender, EventArgs e)
		{
			if (!nTripID.HasValue || nTripID == 0)
				return;

			if (grdTripsReturns.Rows.Count == 0 || grdTripsReturns.CurrentRow == null ||
				!oTripReturnCur.ID.HasValue)
				return;
					
			int nTripReturnID = Convert.ToInt32(grdTripsReturns.CurrentRow.Cells["grcTrips_TripsReturns_ID"].Value);
			TripReturn oTripReturn = new TripReturn();
			oTripReturn.ReFillOne(nTripReturnID);
			if (oTripReturn.IsConfirmed)
			{
				RFMMessage.MessageBoxError("Возврат уже подтвержден.\n" + 
					"Удаление невозможно.");
				return;
			}

			if (RFMMessage.MessageBoxYesNo("Удалить возврат?") == DialogResult.Yes)
			{
				oTripReturn.Delete(nTripReturnID);
				grdTripsReturns_Restore();
			}
		}
		
		#endregion TripsReturns

		#endregion Grid Buttons

	}
}
