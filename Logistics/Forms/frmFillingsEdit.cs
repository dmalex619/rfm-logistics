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
	public partial class frmFillingsEdit : RFMFormChild
	{
		private int? nFillingID;
		private int? nWayBillID;

		private Filling oFilling;
		private WayBill oWayBill;

		// для combobox
		private Car oCar;
		private Driver oDriver;


		public frmFillingsEdit(int? _nFillingID, int? _nWayBillID)
		{
			if (_nFillingID.HasValue)
			{
				nFillingID = (int)_nFillingID;
			}
			if (_nWayBillID.HasValue)
			{
				nWayBillID = (int)_nWayBillID;
			}

			oFilling = new Filling();
			if (oFilling.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				oWayBill = new WayBill();
				if (oWayBill.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				oCar = new Car();
				oDriver = new Driver();
				if (oCar.ErrorNumber != 0 ||
					oDriver.ErrorNumber != 0)
				{
					IsValid = false;
				}
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmFillingsEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true;

			// классификаторы
			if (!cboCar_Restore() ||
				!cboDriverEmployee_Restore() ||
				!cboFillingType_Restore() ||
				!cboFuelType_Restore() )
			{
				bResult = false;
			}

			if (bResult)
			{
				oFilling.ID = nFillingID;

				if (nWayBillID.HasValue)
				{
					oWayBill.ReFillOne((int)nWayBillID);
				}

				cboCar.SelectedIndex =
				cboDriverEmployee.SelectedIndex =
				cboFillingType.SelectedIndex =
				cboFuelType.SelectedIndex =
					-1;

				if (nFillingID.HasValue)
				{
					// существующая заправка
					Text += " (" + nFillingID.ToString() + ")";

					oFilling.FillData();
					if (oFilling.ErrorNumber != 0 || oFilling.MainTable.Rows.Count != 1)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о заправке топлива...");
						bResult = false;
					}

					if (bResult)
					{
						oFilling.FillOne();

						if (nWayBillID.HasValue)
						{
							// сравнить машину в путевом листе и в заправке
							if (oWayBill.CarID != oFilling.CarID)
							{
								if (RFMMessage.MessageBoxYesNo("Внимание!\n\n" +
									"Машина в путевом листе (" + oWayBill.CarName + ")\n" +
									"не совпадает с машиной в данных о заправке (" + oFilling.CarName + ").\n" +
									"Заменить машину в данных о заправке?") == DialogResult.Yes)
								{
									oFilling.CarID = oWayBill.CarID;
								}
							}
							// сравнить водителя в путевом листе и в заправке
							if (oWayBill.DriverEmployeeID != oFilling.DriverEmployeeID)
							{
								if (RFMMessage.MessageBoxYesNo("Внимание!\n\n" +
									"Водитель в путевом листе (" + oWayBill.DriverName + ")\n" +
									"не совпадает с водителем в данных о заправке (" + oFilling.CarName + ").\n" +
									"Заменить водителя в данных о заправке?") == DialogResult.Yes)
								{
									oFilling.DriverEmployeeID = oWayBill.DriverEmployeeID;
								}
							}

							cboCar.Enabled =
							cboDriverEmployee.Enabled =
								false;
						}

						dtpDateFill.Value = oFilling.DateFill;
						cboCar.SelectedValue = (int)oFilling.CarID;
						cboDriverEmployee.SelectedValue = (int)oFilling.DriverEmployeeID;
						cboFillingType.SelectedValue = (int)oFilling.FillingTypeID;
						cboFuelType.SelectedValue = (int)oFilling.FuelTypeID;
						numQntFilled.Value = oFilling.QntFilled;
						numAmount.Value = oFilling.Amount;
						numPrice.Value = (oFilling.QntFilled == 0) ? 0 : oFilling.Amount / oFilling.QntFilled;
						txtNote.Text = oFilling.Note;
					}
				}
				else
				{
					// новая заправка
					dtpDateFill.Value = DateTime.Now.Date;
					// машина-водитель
					if (nWayBillID.HasValue)
					{
						Car oCarTemp = new Car();
						oCarTemp.ID = oWayBill.CarID;
						oCarTemp.FillData();
						if (oCarTemp.ErrorNumber != 0 || oCarTemp.MainTable.Rows.Count != 1)
						{
							RFMMessage.MessageBoxError("Ошибка при получении данных о машине...");
						}
						else
						{
							cboCar.SelectedValue = oWayBill.CarID;
							cboCar.Enabled = false;

                            oCarTemp.FillOneRow(oCarTemp.MainTable.Rows[0]);
							if (oCarTemp.FuelTypeID.HasValue)
							{
								cboFuelType.SelectedValue = oCarTemp.FuelTypeID;
							}
						}
						cboDriverEmployee.SelectedValue = oWayBill.DriverEmployeeID;
						cboDriverEmployee.Enabled = false;
					}

					// подставить min значения 
					/*object oFuelTypeMinID = oFilling.TableFuelTypes.Compute("min(ID)", "");
					if (!Convert.IsDBNull(oFuelTypeMinID) && oFuelTypeMinID != null)
						cboFuelType.SelectedValue = (int)oFuelTypeMinID;*/
					object oFillingTypeMinID = oFilling.TableFillingsTypes.Compute("min(ID)", "");
					if (!Convert.IsDBNull(oFillingTypeMinID) && oFillingTypeMinID != null)
						cboFillingType.SelectedValue = (int)oFillingTypeMinID;
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
			if (dtpDateFill.IsEmpty)
			{
				RFMMessage.MessageBoxError("Укажите дату заправки!");
				dtpDateFill.Select();
				return;
			}
			if (cboCar.SelectedValue == null || cboCar.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Укажите машину!");
				cboCar.Select();
				return;
			}
			if (cboDriverEmployee.SelectedValue == null || cboDriverEmployee.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Укажите водителя!");
				cboDriverEmployee.Select();
				return;
			}
			if (cboFillingType.SelectedValue == null || cboFillingType.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Укажите тип заправки!");
				cboFillingType.Select();
				return;
			}
			if (cboFuelType.SelectedValue == null || cboFuelType.SelectedIndex < 0)
			{
				RFMMessage.MessageBoxError("Укажите тип топлива!");
				cboFuelType.Select();
				return;
			}
			if (numQntFilled.Value == 0)
			{
				RFMMessage.MessageBoxError("Укажите количество заправленного топлива!");
				numQntFilled.Select();
				return;
			}

			oFilling.DateFill = dtpDateFill.Value.Date;
			oFilling.WayBillID = nWayBillID;
			oFilling.CarID = (int)cboCar.SelectedValue;
			oFilling.DriverEmployeeID = (int)cboDriverEmployee.SelectedValue;
			oFilling.FillingTypeID = (int)cboFillingType.SelectedValue;
			oFilling.FuelTypeID = (int)cboFuelType.SelectedValue;
			oFilling.QntFilled = numQntFilled.Value; 
			oFilling.Amount = numAmount.Value;
			oFilling.Note = txtNote.Text.Trim();
			
			oFilling.ClearError();
			oFilling.SaveOne();
			if (oFilling.ErrorNumber == 0)
			{
				// код добавленной заправки
				if (!nFillingID.HasValue && oFilling.ID.HasValue && oFilling.ID != 0)
				{
					nFillingID = (int)oFilling.ID;
				}

				MotherForm.GotParam = new object[] { (int)oFilling.ID };
				DialogResult = DialogResult.Yes;
				Dispose();
			}
		}


		#region Restore ComboBox

		private bool cboCar_Restore()
		{
			cboCar.DataSource = null;
			oCar.ClearError();
			oCar.FilterActual = true;
			if (oCar.FillData())
			{
				cboCar.ValueMember = oCar.ColumnID;
				cboCar.DisplayMember = oCar.ColumnName;
				cboCar.Restore(oCar.MainTable);
			}
			return (oCar.ErrorNumber == 0);
		}

		private bool cboDriverEmployee_Restore()
		{
			cboDriverEmployee.DataSource = null;
			oDriver.ClearError();
			oDriver.FilterActual = true;
			if (oDriver.FillData())
			{
				cboDriverEmployee.ValueMember = oDriver.ColumnID;
				cboDriverEmployee.DisplayMember = oDriver.ColumnName;
				cboDriverEmployee.Restore(oDriver.MainTable);
			}
			return (oDriver.ErrorNumber == 0);
		}

		private bool cboFillingType_Restore()
		{
			cboFillingType.DataSource = null;
			oFilling.ClearError();
			if (oFilling.FillTableFillingsTypes())
			{
				cboFillingType.ValueMember = oFilling.TableFillingsTypes.Columns[0].ColumnName;
				cboFillingType.DisplayMember = oFilling.TableFillingsTypes.Columns[1].ColumnName;
				cboFillingType.Restore(oFilling.TableFillingsTypes);
			}
			return (oFilling.ErrorNumber == 0);
		}

		private bool cboFuelType_Restore()
		{
			cboFuelType.DataSource = null;
			oFilling.ClearError();
			if (oFilling.FillTableFuelTypes())
			{
				cboFuelType.ValueMember = oFilling.TableFuelTypes.Columns[0].ColumnName;
				cboFuelType.DisplayMember = oFilling.TableFuelTypes.Columns[1].ColumnName;
				cboFuelType.Restore(oFilling.TableFuelTypes);
			}
			return (oFilling.ErrorNumber == 0);
		}

		#endregion Restore ComboBox

		#region Пересчет цены-стоимости

		private void numQntFilled_ValueChanged(object sender, EventArgs e)
		{
			decimal nQntFilled = numQntFilled.Value;
			decimal nPrice = numPrice.Value;
			decimal nAmount = numAmount.Value;
			if (nAmount == 0)
			{
				numAmount.Value = nQntFilled * nPrice;
			}
			else
			{
				if (nQntFilled != 0)
				{
					numPrice.Value = nAmount / nQntFilled;
				}
			}
		}

		private void numPrice_ValueChanged(object sender, EventArgs e)
		{
			decimal nQntFilled = numQntFilled.Value;
			decimal nPrice = numPrice.Value;
			decimal nAmount = numAmount.Value;
			numAmount.Value = nQntFilled * nPrice;
		}
	
		private void numAmount_ValueChanged(object sender, EventArgs e)
		{
			decimal nQntFilled = numQntFilled.Value;
			decimal nPrice = numPrice.Value;
			decimal nAmount = numAmount.Value;
			if (nQntFilled != 0)
			{
				numPrice.Value = nAmount / nQntFilled;
			}
			else 
			{
				numQntFilled.Value = nAmount / nPrice;
			}
		}
	
		#endregion Пересчет цены-стоимости

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (StartProgram.ParamStore != null)
            {
                for (int i = 0; i < StartProgram.ParamStore.GetLength(0); i++) 
                    StartProgram.ParamStore.SetValue(null, i);
            }

            if (new frmCounter(false, 0, "Ввод чеков", "").ShowDialog() == DialogResult.Yes)
            {
                if (StartProgram.ParamStore.GetValue(1) == null) 
                    StartProgram.ParamStore.SetValue(0, 1);

                // само значение
                decimal nQnt = 0;
                bool bResult = decimal.TryParse(StartProgram.ParamStore.GetValue(1).ToString(), out nQnt);
                if (bResult) // && nQnt > 0
                    numQntFilled.Value = nQnt;

                if (StartProgram.ParamStore.GetValue(0) == null) 
                    StartProgram.ParamStore.SetValue("", 0);
            }

            if (StartProgram.ParamStore != null)
            {
                for (int i = 0; i < StartProgram.ParamStore.GetLength(0); i++) 
                    StartProgram.ParamStore.SetValue(null, i);
            }
        }

	}
}
