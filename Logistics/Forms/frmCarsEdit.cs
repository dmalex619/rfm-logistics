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
	public partial class frmCarsEdit : RFMFormChild
	{
		private int? nCarID = null;
		private Car oCar;

		private Driver oDriver;
		private Filling oFilling;
		private PermitLevel oPermitLevel;

		private bool bNoEdit;

		private DateTime dEmptyDate = new DateTime(1900, 1, 1, 0, 0, 0);

		public frmCarsEdit(int? _nCarID)
		{
			if (_nCarID.HasValue)
			{
				nCarID = (int)_nCarID;
			}

			oCar = new Car();
			if (oCar.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oDriver = new Driver();
				oFilling = new Filling();
				oPermitLevel = new PermitLevel();
				if (oDriver.ErrorNumber != 0 ||
					oFilling.ErrorNumber != 0 ||
					oPermitLevel.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		public frmCarsEdit(int? _nCarID, bool _bNoEdit)
			:this(_nCarID)
		{
			bNoEdit = _bNoEdit;
		}

		private void frmCarsEdit_Load(object sender, EventArgs e)
		{
			bool bResult = true;

			lblZoneName.Text = "";

			oCar.ID = nCarID;

			// классификаторы
			bResult = cboCarType_Restore() && 
						cboCarClass_Restore() &&
						cboPermitLevel_Restore() &&
						cboDriver_Restore() &&
						cboFuelType_Restore();

			if (bResult)
			{
				if (nCarID.HasValue && (int)nCarID != 0)
				{
					// существующая машина
					bResult = oCar.ReFillOne((int)nCarID) && (oCar.ErrorNumber == 0);
					if (bResult)
					{
						Text += " (" + nCarID.ToString() + ")";

						txtCarNаme.Text = oCar.Name;
						txtCarNumber.Text = oCar.CarNumber;
						txtTrailerNumber.Text = oCar.TrailerNumber;
                        txtCarModel.Text = oCar.CarModel;

						cboCarType.SelectedValue = oCar.CarTypeID;
						cboCarClass.SelectedValue = oCar.CarClassID;

						chkActual.Checked = oCar.Actual;
						chkForGoodsOnly.Checked = oCar.ForGoodsOnly;
						chkOperable.Checked = oCar.Operable;
						chkIsPassengerCar.Checked = oCar.IsPassengerCar;
						chkIsPostern.Checked = oCar.IsPostern;
						chkIsLoadLift.Checked = oCar.IsLoadLift;
						cboPermitLevel.SelectedValue = oCar.PermitLevelID;

						numTonnage.Value = oCar.Tonnage;
						numWeight.Value = oCar.Weight;
						numVolume.Value = oCar.Volume;
						numMaxPalletsQnt.Value = oCar.MaxPalletsQnt;
						numMaxPointsQnt.Value = oCar.MaxPointsQnt;

						int nHours = Convert.ToInt32(Math.Floor((decimal)oCar.MaxDurationMinutes / 60));
						int nMinutes = oCar.MaxDurationMinutes - nHours * 60;
						txtMaxDuration.Text = dEmptyDate.AddHours(nHours).AddMinutes(nMinutes).ToString("HH:mm"); 
						txtNote.Text = oCar.Note;
						if (oCar.DriverEmployeeID.HasValue)
						{
							cboDriver.SelectedValue = oCar.DriverEmployeeID;
						}
						else
						{
							cboDriver.SelectedIndex = -1;
						}
						if (oCar.ZoneName != null && oCar.ZoneName.Length > 0)
						{
							lblZoneName.Text = "(" + oCar.ZoneName + ")";
						}

						if (oCar.FuelTypeID.HasValue)
						{
							cboFuelType.SelectedValue = oCar.FuelTypeID;
						}
						else
						{
							cboFuelType.SelectedIndex = -1;
						}
						chkAutoFreezer.Checked = oCar.AutoFreezer;
						numFuelTank.Value = oCar.FuelTank;
						numFuelQuotaSummer.Value = oCar.FuelQuotaSummer;
						numFuelQuotaWinter.Value = oCar.FuelQuotaWinter;
						numFreezerTank.Value = oCar.FreezerTank;
						numFreezerQuotaSummer.Value = oCar.FreezerQuotaSummer;
						numFreezerQuotaWinter.Value = oCar.FreezerQuotaWinter;
					}
				}
				else
				{
					// новая машина
					chkActual.Checked = true;
					cboCarType.SelectedIndex =
					cboCarClass.SelectedIndex =
					cboPermitLevel.SelectedIndex =
					cboDriver.SelectedIndex =
					cboFuelType.SelectedIndex =
						-1;
				}

				// только просмотр
				if (bNoEdit)
				{
					RFMPanelGlass pnlGlass = new RFMPanelGlass();
					pnlGlass.Top = pnlData.Top;
					pnlGlass.Left = pnlData.Left;
					pnlGlass.Width = pnlData.Width;
					pnlGlass.Height = pnlData.Height;
					Controls.Add(pnlGlass);
					pnlGlass.BringToFront();

					IsStopTab = true;

					btnSave.Select();
					btnSave.Enabled = false;
					Text += " - просмотр";
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
			string sCarName = txtCarNаme.Text.Trim();
			string sCarNumber = txtCarNumber.Text.Trim();

			// проверки 
			if (sCarName.Length == 0)
			{
				RFMMessage.MessageBoxError("Не указано наименование машины...");
				txtCarNаme.Select();
				return;
			}
			if (sCarNumber.Length == 0)
			{
				RFMMessage.MessageBoxError("Не указан гос.номер машины...");
				txtCarNumber.Select();
				return;
			}
			if (cboCarType.SelectedValue == null || cboCarType.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указан тип машины...");
				cboCarType.Select();
				return;
			}
			if (cboCarClass.SelectedValue == null || cboCarClass.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указан класс машины...");
				cboCarClass.Select();
				return;
			}
			if (cboPermitLevel.SelectedValue == null || cboPermitLevel.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Не указан уровень разрешения на проезд...");
				cboPermitLevel.Select();
				return;
			}

			// уникальность имени и номера
			Car oCarTemp = new Car();
			oCarTemp.FillData();
			foreach(DataRow dr in oCarTemp.MainTable.Rows)
			{
				if (nCarID == null || nCarID != Convert.ToInt32(dr["ID"]))
				{
					if (sCarName.ToUpper() == dr["Name"].ToString().Trim().ToUpper())
					{
						RFMMessage.MessageBoxError("Машина с таким наименованием уже есть...");
						txtCarNаme.Select();
						return;
					}
					if (sCarNumber.ToUpper() == dr["CarNumber"].ToString().Trim().ToUpper())
					{
						RFMMessage.MessageBoxError("Машина с таким гос.номером уже есть...");
						txtCarNumber.Select();
						return;
					}
				}
			}

			// актуальность
			if (!chkActual.Checked)
			{
				if (RFMMessage.MessageBoxYesNo("Сохранить данные о неактуальной машине?") != DialogResult.Yes)
				{
					chkActual.Select();
					return;
				}
			}

			// собираем данные в свойства объекта oCar
			oCar.Name = txtCarNаme.Text.Trim();
			oCar.CarNumber = txtCarNumber.Text.Trim();
			oCar.TrailerNumber = txtTrailerNumber.Text.Trim();
            oCar.CarModel = txtCarModel.Text.Trim();

			oCar.CarTypeID = (int)cboCarType.SelectedValue;
			oCar.CarClassID = (int)cboCarClass.SelectedValue;

			oCar.Actual = chkActual.Checked;
			oCar.ForGoodsOnly = chkForGoodsOnly.Checked;
			oCar.Operable = chkOperable.Checked; 
			oCar.IsPassengerCar = chkIsPassengerCar.Checked;
			oCar.IsPostern = chkIsPostern.Checked;
			oCar.IsLoadLift = chkIsLoadLift.Checked;

			oCar.PermitLevelID = (int)cboPermitLevel.SelectedValue;
			oCar.Tonnage = Convert.ToInt32(numTonnage.Value);
			oCar.Weight =  Convert.ToInt32(numWeight.Value);
			oCar.Volume = numVolume.Value;
			oCar.MaxPalletsQnt = numMaxPalletsQnt.Value;
			oCar.MaxPointsQnt = Convert.ToInt32(numMaxPointsQnt.Value);
			
            int nHours = Convert.ToInt16(txtMaxDuration.Text.Substring(0, 2));
			int nMinutes = Convert.ToInt16(txtMaxDuration.Text.Substring(3, 2));
			oCar.MaxDurationMinutes = nHours * 60 + nMinutes;
			oCar.Note = txtNote.Text.Trim();

			if (cboDriver.SelectedValue != null && cboDriver.SelectedIndex >= 0)
			{
				oCar.DriverEmployeeID = (int)cboDriver.SelectedValue;
			}
			else
			{
				oCar.DriverEmployeeID = null;
			}
			if (cboFuelType.SelectedValue != null && cboFuelType.SelectedIndex >= 0)
			{
				oCar.FuelTypeID = (int)cboFuelType.SelectedValue;
			}
			else
			{
				oCar.FuelTypeID = null;
			}
			oCar.AutoFreezer = chkAutoFreezer.Checked;
			oCar.FuelTank = numFuelTank.Value;
			oCar.FuelQuotaSummer = numFuelQuotaSummer.Value;
			oCar.FuelQuotaWinter = numFuelQuotaWinter.Value;
			oCar.FreezerTank = numFreezerTank.Value;
			oCar.FreezerQuotaSummer = numFreezerQuotaSummer.Value;
			oCar.FreezerQuotaWinter = numFreezerQuotaWinter.Value;

			// собственно сохранение 
			oCar.SaveOne();
			if (oCar.ErrorNumber == 0)
			{
				// код добавленной записи 
				if ((!nCarID.HasValue || nCarID == 0) && oCar.ID.HasValue && oCar.ID != null)
				{
					nCarID = (int)oCar.ID;
				}

				if (nCarID.HasValue)
				{
					MotherForm.GotParam = new object[] { (int)nCarID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		#region Restore

		private bool cboCarType_Restore()
		{
			cboCarType.DataSource = null;
			oCar.ClearError();
			if (oCar.FillTableCarsTypes())
			{
				cboCarType.DataSource = new DataView(oCar.TableCarsTypes);
				cboCarType.ValueMember = oCar.TableCarsTypes.Columns[0].ColumnName;
				cboCarType.DisplayMember = oCar.TableCarsTypes.Columns[1].ColumnName;
				cboCarType.Restore();
			}
			return (oCar.ErrorNumber == 0);
		}

		private bool cboCarClass_Restore()
		{
			cboCarClass.DataSource = null;
			oCar.ClearError();
			if (oCar.FillTableCarsClasses())
			{
				cboCarClass.DataSource = new DataView(oCar.TableCarsClasses);
				cboCarClass.ValueMember = oCar.TableCarsClasses.Columns[0].ColumnName;
				cboCarClass.DisplayMember = oCar.TableCarsClasses.Columns[1].ColumnName;
				cboCarClass.Restore();
			}
			return (oCar.ErrorNumber == 0);
		}

		private bool cboDriver_Restore()
		{
			cboDriver.DataSource = null;
			oDriver.ClearError();
			if (oDriver.FillData())
			{
				cboDriver.DataSource = new DataView(oDriver.MainTable);
				cboDriver.ValueMember = oDriver.ColumnID;
				cboDriver.DisplayMember = oDriver.ColumnName;
				cboDriver.Restore();
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

		private bool cboFuelType_Restore()
		{
			cboFuelType.DataSource = null;
			oFilling.ClearError();
			if (oFilling.FillTableFuelTypes())
			{
				cboFuelType.DataSource = new DataView(oFilling.TableFuelTypes);
				cboFuelType.ValueMember = oFilling.TableFuelTypes.Columns[0].ColumnName;
				cboFuelType.DisplayMember = oFilling.TableFuelTypes.Columns[1].ColumnName;
				cboFuelType.Restore();
			}
			return (oFilling.ErrorNumber == 0);
		}

		#endregion Restore

		private void txtMaxDuration_Validated(object sender, EventArgs e)
		{
			if (txtMaxDuration.Text.Trim().Length == 0 || txtMaxDuration.Text.Trim() == ":")
				txtMaxDuration.Text = "00:00";
		}

	}
}
