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
	public partial class frmWayBillsEdit : RFMFormChild
    {
        #region Внутренние переменные
        private int? nWayBillID;
		private WayBill oWayBill;

		// для grid
		private Trip oTrip;
		private Filling oFilling;

		// для combobox
		private Car oCar, oCarSelected;
		private Driver oDriver, oDriverSelected;

		decimal nFuelDiff = 0;

		public int? _SelectedID = null;
		public string _SelectedText = "";

		bool bDispose = true;
		bool bNoAsk = false;
		bool bLoaded = false;

        string sTimeDelimiter = ":";
        #endregion

        public frmWayBillsEdit(int? _nWayBillID)
		{
			if (_nWayBillID.HasValue)
			{
				nWayBillID = (int)_nWayBillID;
			}

			oWayBill = new WayBill();
			if (oWayBill.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oCar = new Car();
			oCarSelected = new Car();
			oDriver = new Driver();
			oDriverSelected = new Driver();
			if (oCar.ErrorNumber != 0 ||
				oCarSelected.ErrorNumber != 0 ||
				oDriver.ErrorNumber != 0 ||
				oDriverSelected.ErrorNumber != 0)
			{
				IsValid = false;
			}

			oTrip = new Trip();
			oFilling = new Filling();
			if (oTrip.ErrorNumber != 0 ||
				oFilling.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmWayBillsEdit_Load (object sender, EventArgs e)
		{
			bool bResult = true; 

			// классификаторы
			if (!cboCar_Restore() || !cboDriverEmployee_Restore())
			{
				bResult = false;
			}

			if (bResult)
			{
				oWayBill.ID = nWayBillID;

				cboCar.SelectedIndex = 
				    cboDriverEmployee.SelectedIndex =  -1;
				lblCarTypeName.Text = 
				    lblZoneName.Text =  "";
				lblFuelTank.Text =
				    lblFreezerTank.Text = "";
				lblFuelDiffCalc.Text = "";

				//txtFreezerDuration.Text = "0" + sTimeDelimiter + "00";
				txtFreezerDuration.SetValue(0);

				if (nWayBillID.HasValue)
				{
					// существующий путевой лист
					Text += " (" + nWayBillID.ToString() + ")";

					oWayBill.FillData();
					if (oWayBill.ErrorNumber != 0 || oWayBill.MainTable.Rows.Count != 1)
					{
						RFMMessage.MessageBoxError("Ошибка при получении данных о путевом листе...");
						bResult = false;
					}

					if (bResult)
					{
						oWayBill.FillOne();

                        oCarSelected.ReFillOne((int)oWayBill.CarID);

                        txtBillNumber.Text = oWayBill.BillNumber;
						dtpDateWayBeg.Value = oWayBill.DateWayBeg;
						dtpDateWayEnd.Value = oWayBill.DateWayEnd;
						cboCar.SelectedValue = (int)oWayBill.CarID;
						cboDriverEmployee.SelectedValue = oWayBill.DriverEmployeeID;
						txtDriverOther.Text = oWayBill.DriverOther;
						txtReason.Text = oWayBill.Reason;  
						txtNote.Text = oWayBill.Note;

						// спидометр
						if (oWayBill.SpeedometerDataBeg.HasValue)
						{
							numSpeedometerDataBeg.Value = (decimal)oWayBill.SpeedometerDataBeg;
						}
						if (oWayBill.SpeedometerDataEnd.HasValue)
						{
							numSpeedometerDataEnd.Value = (decimal)oWayBill.SpeedometerDataEnd;
						}
						if (numSpeedometerDataEnd.Value == 0)
						{
							numSpeedometerDiff.Value = 0;
						}
						else
						{
							if (numSpeedometerDataEnd.Value - numSpeedometerDataBeg.Value >= 0)
							{
								numSpeedometerDiff.Value = (decimal)(numSpeedometerDataEnd.Value - numSpeedometerDataBeg.Value);
							}
							else
							{
								// обнуление - т.е. переход через 100000
								numSpeedometerDiff.Value = (decimal)((double)numSpeedometerDataEnd.Value +
											Math.Pow(10, oWayBill.SpeedometerDataBeg.ToString().Length) -
											(double)numSpeedometerDataBeg.Value);
							}
						}

						// топливо
						if (oWayBill.FuelTank > 0)
						{
							lblFuelTank.Text = "[" + oWayBill.FuelTank.ToString("#####0.0").Trim() + "]";
						}
						if (oWayBill.FuelDataBeg.HasValue)
						{
							numFuelDataBeg.Value = (decimal)oWayBill.FuelDataBeg;
						}
						if (oWayBill.FreezerTank > 0)
						{
							lblFreezerTank.Text = "[" + oWayBill.FreezerTank.ToString("#####0.0").Trim() + "]";
							numFuelFreezerDataEnd.Enabled = true;
							if (oWayBill.FuelFreezerDataBeg.HasValue)
							{
								numFuelFreezerDataBeg.Value = (decimal)oWayBill.FuelFreezerDataBeg;
							}
							if (oWayBill.FuelFreezerDataEnd.HasValue)
							{
								numFuelFreezerDataEnd.Value = (decimal)oWayBill.FuelFreezerDataEnd;
							}
						}
						if (oWayBill.FreezerDurationMinutes.HasValue)
						{
							int nFreezerDurationMinutes = (oWayBill.FreezerDurationMinutes.HasValue) ? (int)oWayBill.FreezerDurationMinutes : 0;
							txtFreezerDuration.SetValue(nFreezerDurationMinutes);
							/*
 							int nHours = Convert.ToInt32(Math.Floor((decimal)nFreezerDurationMinutes / 60));
							int nMinutes = nFreezerDurationMinutes - nHours * 60;
							txtFreezerDuration.Text = nHours.ToString().Trim() + sTimeDelimiter + nMinutes.ToString("00");
							*/ 
						}
						if (oWayBill.FuelQntFilled.HasValue)
						{
							numFuelQntFilled.Value = (decimal)oWayBill.FuelQntFilled;
						}
						if (oWayBill.FuelDataEnd.HasValue)
						{
							numFuelDataEnd.Value = (decimal)oWayBill.FuelDataEnd;
						}

						if (numFuelDataEnd.Value == 0 && numFuelFreezerDataEnd.Value == 0)
						{
							nFuelDiff = numFuelDiff.Value = 0;
						}
						else
						{
                            nFuelDiff = numFuelDiff.Value = 
                                numFuelDataBeg.Value + numFuelFreezerDataBeg.Value +
								numFuelQntFilled.Value -
								(numFuelDataEnd.Value + numFuelFreezerDataEnd.Value);
						}

						FuelCalc();
					}
				}
				else
				{
					// новый путевой лист
				}
			}
			chkSpeedometerEdit.Checked = false;
			chkSpeedometerEdit_CheckedChanged(null, null);
			chkFuelEdit.Checked = false;
			chkFuelEdit_CheckedChanged(null, null);

			// списки связанные
			if (bResult)
			{
				if (!grdFillings_Restore())
				{
					bResult = false;
				}
				if (!grdTrips_Restore())
				{
					bResult = false;
				}
			}

			if (!bResult)
			{
				Dispose();
				return;
			}

			tcAdd.Init();

			bLoaded = true;
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
			if (dtpDateWayBeg.IsEmpty || dtpDateWayEnd.IsEmpty)
			{
				RFMMessage.MessageBoxError("Укажите даты действия путевого листа!");
				dtpDateWayBeg.Select();
				return;
			}
			DateTime dDateWayBeg = dtpDateWayBeg.Value.Date;
			DateTime dDateWayEnd = dtpDateWayEnd.Value.Date;
			if (DateTime.Compare(dDateWayBeg, dDateWayEnd) > 0)
			{
				RFMMessage.MessageBoxError("Неверные даты действия путевого листа!");
				dtpDateWayEnd.Select();
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
            if (txtReason.Text.Trim().Length == 0)
            {
                RFMMessage.MessageBoxError("Укажите назначение путевого листа!");
                txtReason.Select();
                return;
            }

			if (!bNoAsk)
			{
				if (txtBillNumber.Text.Trim().Length == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не указан номер путевого листа...\nВсе-таки сохранить?") != DialogResult.Yes)
					{
						txtBillNumber.Select();
						return;
					}
				}

                // Заблокировано 16.11.2009, т.к. многие машины приезжают утром из командировки,
                // и через несколько часов уходят в новую
                /*if (!CarCheck((int)cboCar.SelectedValue))
					return;*/

				if (!SpinnersCheck(false))
					return;
			}

			oWayBill.BillNumber = txtBillNumber.Text.Trim();			
			oWayBill.DateWayBeg = dDateWayBeg;
			oWayBill.DateWayEnd = dDateWayEnd;
			oWayBill.CarID = (int)cboCar.SelectedValue;
			oWayBill.DriverEmployeeID = (int)cboDriverEmployee.SelectedValue;
			oWayBill.DriverOther = txtDriverOther.Text.Trim();
			oWayBill.Reason = txtReason.Text;
			oWayBill.Note = txtNote.Text.Trim();

			// спидометр, топливо
			oWayBill.SpeedometerDataBeg = (int)numSpeedometerDataBeg.Value;
			oWayBill.SpeedometerDataEnd = (int)numSpeedometerDataEnd.Value;
			oWayBill.FuelDataBeg = numFuelDataBeg.Value;
			oWayBill.FuelDataEnd = numFuelDataEnd.Value;
			if (lblFreezerTank.Text.Length > 0)
			{
				oWayBill.FuelFreezerDataBeg = numFuelFreezerDataBeg.Value;
				oWayBill.FuelFreezerDataEnd = numFuelFreezerDataEnd.Value;
			}

			/*
			int nHours = 0;
			int nMinutes = 0;
			if (txtFreezerDuration.Text.Trim().Length > 0 &&
				txtFreezerDuration.Text.Contains(sTimeDelimiter))
			{
				try 
				{ 
					nHours = Convert.ToInt32(txtFreezerDuration.Text.Substring(0, txtFreezerDuration.Text.IndexOf(sTimeDelimiter)));
					nMinutes = Convert.ToInt32(txtFreezerDuration.Text.Substring(txtFreezerDuration.Text.IndexOf(sTimeDelimiter) + 1, 2)); 
				}
				catch { }
			}
			oWayBill.FreezerDurationMinutes = nHours * 60 + nMinutes;
			*/
			oWayBill.FreezerDurationMinutes = txtFreezerDuration.GetInMinutes();
			
			oWayBill.FuelQntFilled = numFuelQntFilled.Value;

			oWayBill.UserCreateID = ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID;

			// таблицы: заправки и рейсы
			DataTable tableFillingsInWayBill = CopyTable(oFilling.MainTable, "tableFillingsInWayBill", "", "");
			DataTable tableTripsInWayBill = CopyTable(oTrip.MainTable, "tableTripsInWayBill", "IsUsed = true", "");
			// 

			oWayBill.ClearError();
			oWayBill.Save(tableFillingsInWayBill, tableTripsInWayBill);
			if (oWayBill.ErrorNumber == 0)
			{
				// код добавленного путевого листа
				if (!nWayBillID.HasValue && oWayBill.ID.HasValue && oWayBill.ID != 0)
				{
					nWayBillID = (int)oWayBill.ID;
				}

				if (bDispose)
				{
					MotherForm.GotParam = new object[] { (int)oWayBill.ID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			if (!SpinnersCheck(true))
				return;

			if (RFMMessage.MessageBoxYesNo("Внимание!\n\n" + 
					"После закрытия путевого листа изменения будут невозможны!\n\n" + 
					"Все-таки закрыть путевой лист?") != DialogResult.Yes)
				return;

			bDispose = false;
			btnSave_Click(null, null);
			if (nWayBillID.HasValue)
			{
				oWayBill.Confirm((int)nWayBillID, true, ((RFMFormMain)Application.OpenForms[0]).UserInfo.UserID);
				if (oWayBill.ErrorNumber == 0)
				{
					MotherForm.GotParam = new object[] { (int)oWayBill.ID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}

		#region Comboboxes

		private void cboCar_Validated(object sender, EventArgs e)
		{
            int? nOldCarSelectedID = oCarSelected.ID;
            if (cboCar.SelectedValue != null && cboCar.SelectedIndex >= 0 && cboCar.ValueMember != "")
            {
                // меняем машину
                int nCarSelectedID = (int)cboCar.SelectedValue;
                if (nOldCarSelectedID.HasValue && nOldCarSelectedID == nCarSelectedID)
                    return;

                lblCarTypeName.Text =
                lblFuelTank.Text =
                lblFreezerTank.Text =
                    "";
                numSpeedometerDataBeg.Value =
                numSpeedometerDataEnd.Value =
                numSpeedometerDiff.Value =
                numFuelDataBeg.Value =
                numFuelDataEnd.Value =
                numFuelDiff.Value =
                numFuelFreezerDataBeg.Value =
                numFuelFreezerDataEnd.Value =
                numFuelQntFilled.Value =
                    0;

                // Проверим, что нет другого пут.листа на то же время на эту же машину
                // Заблокировано 16.11.2009, т.к. многие машины приезжают утром из командировки,
                // и через несколько часов уходят в новую
                /*if (bLoaded)
                {
                    if (!CarCheck(nCarSelectedID))
                    {
                        // пока запишем, что выбрали, а сохранить не дадим
                    }
                }*/

                oCarSelected.ReFillOne(nCarSelectedID);
                if (bLoaded)
                {
                    if (!nWayBillID.HasValue || nWayBillID > 0) // не только для нового - для любого путевого листа
                    {
                        // ищем последний пут.лист для этой машины
                        WayBill oWayBillTemp = new WayBill();
                        oWayBillTemp.FilterCarsList = nCarSelectedID.ToString();
                        oWayBillTemp.FillData();
                        if (oWayBillTemp.ErrorNumber == 0)
                        {
                            if (oWayBillTemp.MainTable.Rows.Count > 0)
                            {
                                DataTable dw = CopyTable(oWayBillTemp.MainTable, "dw", "", "DateWayEnd desc, DateWayBeg desc, ID desc");
                                if (!Convert.ToBoolean(dw.Rows[0]["IsConfirmed"]))
                                {
                                    RFMMessage.MessageBoxError("Последний путевой лист для выбранной машины не закрыт...\n" +
                                        "Оформление нового путевого листа возможно только после закрытия предыдущего.");
                                    cboCar.SelectedIndex = -1;
                                    cboCar.Select();
                                    return;
                                }
                                else
                                {
                                    // взять последние значения
                                    oWayBillTemp.FillOne(dw.Rows[0]);
                                    if (oWayBillTemp.SpeedometerDataEnd.HasValue)
                                    {
                                        numSpeedometerDataBeg.Value = (decimal)oWayBillTemp.SpeedometerDataEnd;
                                    }
                                    if (oWayBillTemp.FuelDataEnd.HasValue)
                                    {
                                        numFuelDataBeg.Value = (decimal)oWayBillTemp.FuelDataEnd;
                                    }
                                    if (oWayBillTemp.FreezerTank > 0 && oWayBillTemp.FuelFreezerDataEnd.HasValue)
                                    {
                                        numFuelFreezerDataBeg.Value = (decimal)oWayBillTemp.FuelFreezerDataEnd;
                                    }

                                    numSpeedometerDataEnd.Value =
                                    numSpeedometerDiff.Value =
                                        0;
                                    numFuelDataEnd.Value =
                                    numFuelFreezerDataEnd.Value =
                                    numFuelDiff.Value =
                                        0;

                                    FuelCalc();
                                }
                            }
                        }
                    }
                }

                lblCarTypeName.Text = oCarSelected.CarNumber; // + " (" + oCarSelected.CarTypeName + " (" + oCarSelected.Tonnage.ToString() + ")";
                if (oCarSelected.FuelTank > 0)
                {
                    lblFuelTank.Text = "[" + oCarSelected.FuelTank.ToString("#####0.0").Trim() + "]";
                }
                if (oCarSelected.FreezerTank > 0)
                {
                    lblFreezerTank.Text = "[" + oCarSelected.FreezerTank.ToString("#####0.0").Trim() + "]";
                    numFuelFreezerDataBeg.Enabled = chkFuelEdit.Checked;
                    numFuelFreezerDataEnd.Enabled = true;
                }
                else
                {
                    numFuelFreezerDataBeg.Value =
                    numFuelFreezerDataEnd.Value =
                        0;
                    numFuelFreezerDataBeg.Enabled =
                    numFuelFreezerDataEnd.Enabled =
                        false;
                }

                // ищем водителя
                int nDriverEmployeeID = 0;
                if (oCarSelected.DriverEmployeeID.HasValue)
                {
                    nDriverEmployeeID = (int)oCarSelected.DriverEmployeeID;
                }

                Trip oTripTemp = new Trip();
                oTripTemp.FilterCarsList = nCarSelectedID.ToString();
                oTripTemp.FilterDateBeg = dtpDateWayBeg.Value;
                oTripTemp.FilterDateEnd = dtpDateWayEnd.Value;
                oTripTemp.FillData();
                if (oTripTemp.ErrorNumber == 0 && oTripTemp.MainTable != null && oTripTemp.MainTable.Rows.Count > 0)
                {
                    foreach (DataRow r in oTripTemp.MainTable.Rows)
                    {
                        if (!Convert.IsDBNull(r["DriverEmployeeID"]))
                        {
                            nDriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
                        }
                    }
                }

                if (nDriverEmployeeID > 0)
                {
                    cboDriverEmployee.SelectedValue = nDriverEmployeeID;
                }
                else
                {
                    cboDriverEmployee.SelectedIndex = -1; ;
                }
            }
            else
            {
                oCarSelected.ID = null;
            }
            return;
        }

		private bool CarCheck(int nCarSelectedID)
		{
			WayBill oWayBillTemp = new WayBill();
			oWayBillTemp.FilterDateBeg = dtpDateWayBeg.Value;
			oWayBillTemp.FilterDateEnd = dtpDateWayEnd.Value;
			oWayBillTemp.FilterCarsList = nCarSelectedID.ToString();
			oWayBillTemp.FillData();
			if (oWayBillTemp.ErrorNumber != 0 || oWayBillTemp.MainTable == null)
				return (false);

			if (oWayBillTemp.MainTable.Rows.Count > 0)
			{
				foreach (DataRow dr in oWayBillTemp.MainTable.Rows)
				{
					if (nWayBillID == null ||
						nWayBillID.HasValue && Convert.ToInt32(dr["ID"]) != (int)nWayBillID)
					{
						RFMMessage.MessageBoxError("На данную машину уже оформлен путевой лист на период " +
							dtpDateWayBeg.Value.ToString("dd.MM.yyyy") + " - " + dtpDateWayBeg.Value.ToString("dd.MM.yyyy"));
						return (false);
					}
				}
			}
			return (true);
		}

		private void cboDriverEmployee_SelectedIndexChanged(object sender, EventArgs e)
		{
			lblZoneName.Text = "";
			if (cboDriverEmployee.SelectedValue != null && cboDriverEmployee.SelectedIndex >= 0 &&
				cboDriverEmployee.ValueMember != "")
			{
				oDriverSelected.ReFillOne((int)cboDriverEmployee.SelectedValue);
				lblZoneName.Text = oDriverSelected.ZoneAlias;
			}
			else
			{
				oDriverSelected.ID = null;
			}
		}

		#endregion Comboboxes

		#region Restore

		#region ComboBox

		private bool cboCar_Restore()
		{
			cboCar.DataSource = null;
			oCar.ClearError();
			oCar.FilterActual = true;
			if (oCar.FillData())
			{
                DataView dv = new DataView(oCar.MainTable);
                //dv.Sort = "CarNumber";
                cboCar.DataSource = dv;
                cboCar.ValueMember = oCar.ColumnID;
                cboCar.DisplayMember = oCar.ColumnName;
                //cboCar.DisplayMember = "CarNumber";
                cboCar.Restore();
			}
			return (oCar.ErrorNumber == 0);
		}

		private bool cboDriverEmployee_Restore()
		{
			cboDriverEmployee.DataSource = null;
			oDriver.ClearError();
			if (oDriver.FillData())
			{
				cboDriverEmployee.DataSource = new DataView(oDriver.MainTable);
				cboDriverEmployee.ValueMember = oDriver.ColumnID;
				cboDriverEmployee.DisplayMember = oDriver.ColumnName;
				cboDriverEmployee.Restore();
			}
			return (oDriver.ErrorNumber == 0);
		}

		#endregion ComboBox

		#region Grid

		private bool grdFillings_Restore()
		{
			grdFillings.DataSource = null;
			oFilling.ID = null;
			oFilling.ClearFilters();
			oFilling.ClearError();
			if (nWayBillID.HasValue && nWayBillID != 0)
			{
				oFilling.FilterWayBillsList = nWayBillID.ToString();
			}
			else
			{
				oFilling.FilterWayBillsList = "-2";
			}
			oFilling.FillData();
			grdFillings.Restore(oFilling.MainTable);
			return (oFilling.ErrorNumber == 0);
		}

		private bool grdTrips_Restore()
		{
			grdTrips.DataSource = null;

			oTrip.ClearFilters();
			oTrip.ClearError();
			if (nWayBillID.HasValue && nWayBillID != 0)
			{
				oTrip.FilterWayBillsList = nWayBillID.ToString();
			}
			else
			{
				oTrip.FilterWayBillsList = "-2";
			}
			oTrip.FillData();
			if (oTrip.MainTable.Columns["IsUsed"] == null)
			{
				oTrip.MainTable.Columns.Add("IsUsed", System.Type.GetType("System.Boolean"));
			}
			foreach (DataRow dr in oTrip.MainTable.Rows)
			{
				dr["IsUsed"] = true;
			}
			grdTrips.Restore(oTrip.MainTable);
			return (oTrip.ErrorNumber == 0);
		}

		#endregion Grid

		#endregion Restore


		private void grd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			RFMDataGridView grd = (RFMDataGridView)sender;
			string sGridName = grd.Name.ToUpper();

			if (grd.DataSource == null)
				return;

			// статусная строка
			if (grd.IsStatusRow(e.RowIndex))
			{
				if (grd.Columns[e.ColumnIndex].Name.ToUpper().Contains("IMAGE"))
				{
					e.Value = Properties.Resources.Empty;
				}
				return;
			}

			// строка данных
			DataRow r = ((DataRowView)((DataGridViewRow)grd.Rows[e.RowIndex]).DataBoundItem).Row;
			DataGridViewColumn c = grd.Columns[e.ColumnIndex];
			string sColumnName = c.Name.ToUpper();

			if (sColumnName.Contains("TTO") &&
				c.DefaultCellStyle.Format.Contains("N"))
			{
				if (Convert.IsDBNull(e.Value) || Convert.ToDecimal(e.Value) == 0)
				{
					e.Value = "";
				}
			}
		}

		private void btnReasonSelect_Click(object sender, EventArgs e)
		{
			// ранее введеные значения 
			WayBill oWayBillTemp = new WayBill();
			oWayBillTemp.FilterDateBeg = DateTime.Now.Date.AddMonths(-1);
			oWayBillTemp.FilterDateEnd = DateTime.Now.Date;
			oWayBillTemp.FillData();
			if (oWayBillTemp.ErrorNumber != 0 || oWayBillTemp.MainTable == null)
				return;
			if (oWayBillTemp.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных...");
				return;
			}

			DataTable dtReasonDistinct = new DataTable();
			dtReasonDistinct.Columns.Add("Reason");
			System.Collections.Hashtable hash = new System.Collections.Hashtable();
			foreach(DataRow row in oWayBillTemp.MainTable.Rows)
				hash[row["Reason"]] = row["Reason"];
			foreach(object name in hash.Values)
				dtReasonDistinct.Rows.Add(name);
			DataTable tdReason = CopyTable(dtReasonDistinct, "tdReason", "Reason > ''", "Reason");
			if (StartForm(new frmSelectID(this, tdReason, "Reason", "Назначение", false)) == DialogResult.Yes)
			{
				if (_SelectedID == null)
				{
					return;
				}
				txtReason.Text = _SelectedText;
			}
			_SelectedID = null;
			_SelectedText = "";

			return;
		}

		#region localButtons

		private void btnAdd_Click(object sender, EventArgs e)
		{
			bDispose = false;
			switch (tcAdd.CurrentPage.Name)
			{
				case "tabFillings":
					// если это новый пут.лист - сохранить его
					if (!nWayBillID.HasValue)
					{
						bNoAsk = true;
						btnSave_Click(null, null);
						bNoAsk = false;
						if (!nWayBillID.HasValue)
							return;
					}

					if (StartForm(new frmFillingsEdit(null, (int)nWayBillID)) == DialogResult.Yes)
					{
						int nFillingID = (int)GotParam.GetValue(0);
						grdFillings_Restore();
						if (nFillingID > 0)
						{
							grdFillings.GridSource.Position = grdFillings.GridSource.Find(oFilling.ColumnID, nFillingID);
						}
					}
					break;
				case "tabTrips":
					// выбрать из подходящих рейсов
					if (cboCar.SelectedValue == null || cboCar.SelectedIndex < 0)
					{
						RFMMessage.MessageBoxError("Укажите машину!");
						cboCar.Select();
						return;
					}

					Trip oTripTemp = new Trip();
					oTripTemp.FilterDateBeg = dtpDateWayBeg.Value.Date;
					oTripTemp.FilterDateEnd = dtpDateWayEnd.Value.Date;
					oTripTemp.FilterCarsList = cboCar.SelectedValue.ToString();
					oTripTemp.FillData();
					if (oTripTemp.MainTable.Rows.Count > 0)
					{
						DataTable dtTrips = oTripTemp.MainTable.Clone();
						foreach (DataRow dr in oTripTemp.MainTable.Rows)
						{ 
							if (Convert.IsDBNull(dr["WayBillID"]))
							{
								if (grdTrips.GridSource.Find(oTrip.ColumnID, Convert.ToInt32(dr["ID"])) < 0)
								{
									dtTrips.ImportRow(dr);
								}
							}
						}
						if (dtTrips.Rows.Count > 0)
						{
							if (StartForm(new frmSelectID(this, dtTrips, "DateTrip,Alias,IsConfirmed", "Дата,Описание,Подтв.", false)) == DialogResult.Yes)
							{
								if (_SelectedID == null)
								{
									return;
								}
								int nTripNewID = (int)_SelectedID;
								Trip oTripNew = new Trip();
								oTripNew.ID = nTripNewID;
								oTripNew.FillData();
								if (oTripNew.MainTable.Rows.Count == 1)
								{
									oTrip.MainTable.ImportRow(oTripNew.MainTable.Rows[0]);
									oTrip.MainTable.Rows[oTrip.MainTable.Rows.Count - 1]["IsUsed"] = true;
								}
								_SelectedID = null;
							}
						}
						else
						{
							RFMMessage.MessageBoxError("Нет подходящих рейсов...");
						}
					}
					else
					{
						RFMMessage.MessageBoxError("Нет подходящих рейсов...");
					}
					break;
			}

			bDispose = true;

		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (tcAdd.CurrentPage.Name)
			{
				case "tabFillings":
					if (grdFillings.CurrentRow == null)
						return;
					if (grdFillings.CurrentRow.Cells["grcFillings_ID"].Value == null)
						return;

					int nFillingID = Convert.ToInt32(grdFillings.CurrentRow.Cells["grcFillings_ID"].Value);

					// перечитать, после этого выполнить проверки 
					if (oFilling.ReFillOne(nFillingID))
					{
						if (StartForm(new frmFillingsEdit(nFillingID, (int)nWayBillID)) == DialogResult.Yes)
						{
							grdFillings_Restore();
						}
					}
					break;
				case "tabTrips":
					// .......
					break;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			switch (tcAdd.CurrentPage.Name)
			{
				case "tabFillings":
					if (grdFillings.CurrentRow == null)
						return;
					if (grdFillings.CurrentRow.Cells["grcFillings_ID"].Value == null)
						return;

					int nFillingID = Convert.ToInt32(grdFillings.CurrentRow.Cells["grcFillings_ID"].Value);

					if (oFilling.ReFillOne(nFillingID))
					{
						if (RFMMessage.MessageBoxYesNo("Удалить данные о заправке топлива?") == DialogResult.Yes)
						{
							Refresh();
							WaitOn(this);
							if (oFilling.DeleteOne(nFillingID))
							{
								WaitOff(this);
								if (oFilling.ErrorNumber == 0)
								{
									RFMMessage.MessageBoxInfo("Данные о заправке топлива удалены.");
									grdFillings_Restore();
								}
								else
								{
									RFMMessage.MessageBoxError("Ошибка при удалении данных о заправке топлива...");
								}
							}
							WaitOff(this);
						}
					}
					break;
				case "tabTrips":
					// не исп.
					break;
			}
		}

		#endregion localButtons

		#region localButtonsEnabled

		private void tcAdd_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tcAdd.CurrentPage.Name)
			{
				case ("tabFillings"):
					grdFillings.Select();
					grdFillings_Select(); 
					break;
				case ("tabTrips"):
					grdTrips.Select();
					btnAdd.Enabled = true;
					btnEdit.Enabled =
					btnDelete.Enabled =
						false;
					break;
			}
		}

		#endregion localButtonsEnabled

		#region gridSelect -> localButtons

		private void grdFillings_Select()
		{
			btnAdd.Enabled = true;
			if (grdFillings.Rows.Count == 0)
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					false;
			}
			else
			{
				btnEdit.Enabled =
				btnDelete.Enabled =
					true;
			}
		}

		#endregion gridSelect -> localButtons

		#region Spinners

		#region spinnersSpeedometer

		private void numSpeedometerDataBeg_ValueChanged(object sender, EventArgs e)
		{
			// вводим/меняем начальное показание
			int nSpeedometerDataBeg = Convert.ToInt32(numSpeedometerDataBeg.Value);
			int nSpeedometerDiff = Convert.ToInt32(numSpeedometerDiff.Value);
			int nSpeedometerDataEnd = Convert.ToInt32(numSpeedometerDataEnd.Value);
			if (nSpeedometerDataEnd == 0)
			{
				// конечное показание не заполнено - меняем его 
				if (nSpeedometerDiff > 0)
				{
					numSpeedometerDataEnd.Value = nSpeedometerDataBeg + nSpeedometerDiff;
				}
				else
				{
					numSpeedometerDataEnd.Value = 0;
				}
			}
			else
			{
				// конечное показание заполнено - меняем пробег
				if (nSpeedometerDataEnd - nSpeedometerDataBeg >= 0)
				{
					numSpeedometerDiff.Value = nSpeedometerDataEnd - nSpeedometerDataBeg;
				}
				else
				{
					// обнуление спидометра - переход через 100000
					numSpeedometerDiff.Value = (decimal)
								((double)nSpeedometerDataEnd +
								Math.Pow(10, nSpeedometerDataBeg.ToString().Length) -
								(double)nSpeedometerDataBeg);
				}
			}
			return; 
		}

		private void numSpeedometerDataEnd_ValueChanged(object sender, EventArgs e)
		{
			// вводим/меняем конечное показание 
			int nSpeedometerDataBeg = Convert.ToInt32(numSpeedometerDataBeg.Value);
			int nSpeedometerDiff = Convert.ToInt32(numSpeedometerDiff.Value);
			int nSpeedometerDataEnd = Convert.ToInt32(numSpeedometerDataEnd.Value);
			if (nSpeedometerDataEnd == 0)
			{
				// не указано конечное значение
				numSpeedometerDiff.Value = 0;
			}
			else
			{
				// указано конечное значение
				if (nSpeedometerDataBeg == 0)
				{
					// начальное показание не заполнено - меняем его 
					numSpeedometerDataBeg.Value = nSpeedometerDataEnd - nSpeedometerDiff;
				}
				else
				{
					// начальное показание заполнено - меняем пробег
					if (nSpeedometerDataEnd - nSpeedometerDataBeg >= 0)
					{
						numSpeedometerDiff.Value = nSpeedometerDataEnd - nSpeedometerDataBeg;
					}
					else
					{
						// обнуление спидометра - переход через 100000
						numSpeedometerDiff.Value = (decimal)
									((double)nSpeedometerDataEnd +
									Math.Pow(10, nSpeedometerDataBeg.ToString().Length) -
									(double)nSpeedometerDataBeg);
					}
				}
			}
			return;
		}

		private void numSpeedometerDiff_ValueChanged(object sender, EventArgs e)
		{
			// вводим/меняем пробег - меняем конечное показание
			numSpeedometerDataEnd.Value = numSpeedometerDataBeg.Value + numSpeedometerDiff.Value;
			FuelCalc();
		}

		#endregion spinnersSpeedometer

		#region spinnersFuel

		private void numFuelDataBeg_ValueChanged(object sender, EventArgs e)
		{
			// вводим/меняем начальный остаток
			decimal nFuelDataBeg = numFuelDataBeg.Value;
			decimal nFuelDataEnd = numFuelDataEnd.Value;
			decimal nFuelFreezerDataBeg = numFuelFreezerDataBeg.Value;
			decimal nFuelFreezerDataEnd = numFuelFreezerDataEnd.Value;
			decimal nFuelQntFilled = numFuelQntFilled.Value;
			if (nFuelDataEnd == 0)
			{
				// конечное показание не заполнено - меняем его 
				/*numFuelDataEnd.Value = (nFuelDataBeg + nFuelFreezerDataBeg) +
										nFuelQntFilled -
										(nFuelFreezerDataEnd);*/
				//numFuelDiff.Value = nFuelDiff = 0;
			}
			else
			{
				// конечное показание заполнено - меняем расход
				numFuelDiff.Value = (nFuelDataBeg + nFuelFreezerDataBeg) +
									nFuelQntFilled -
									(nFuelDataEnd + nFuelFreezerDataEnd);
				nFuelDiff = numFuelDiff.Value;
			}
            
            FuelCalc();
			return;
		}

		private void numFuelDataEnd_ValueChanged(object sender, EventArgs e)
		{
			// вводим/меняем конечный остаток
			decimal nFuelDataBeg = numFuelDataBeg.Value;
			decimal nFuelDataEnd = numFuelDataEnd.Value;
			decimal nFuelFreezerDataBeg = numFuelFreezerDataBeg.Value;
			decimal nFuelFreezerDataEnd = numFuelFreezerDataEnd.Value;
			decimal nFuelQntFilled = numFuelQntFilled.Value;
			if (nFuelDataEnd == 0 && nFuelFreezerDataEnd == 0)
			{
				// не указано кон.значение
				nFuelQntFilled = 0;
				nFuelDiff = 0;
			}
			else
			{
				// указано кон.значение - меняем расход 
				numFuelDiff.Value = (nFuelDataBeg + nFuelFreezerDataBeg) +
									nFuelQntFilled -
									(nFuelDataEnd + nFuelFreezerDataEnd);
				nFuelDiff = numFuelDiff.Value;
			}
            
			return;
		}

		private void txtFreezerDuration_Validated(object sender, EventArgs e)
		{
			FuelCalc();
		}

		#endregion spinnersFuel

		private void FuelCalc()
		{
			// пересчет расхода топлива
			string sText = "";
			decimal nQuota = 0, nFreezerQuota = 0;
			if (oCarSelected.ID.HasValue)
			{
				DateTime dt = dtpDateWayBeg.Value.Date;
				if (dt.Month >= 4 && dt.Month <= 10)
				{
                    nQuota = oCarSelected.FuelQuotaSummer;
                    nFreezerQuota = oCarSelected.FreezerQuotaSummer;
                }
				else
				{
                    nQuota = oCarSelected.FuelQuotaWinter;
                    nFreezerQuota = oCarSelected.FreezerQuotaWinter;
				}
				nFuelDiff = numSpeedometerDiff.Value / 100 * nQuota;
				sText = ((decimal)(numSpeedometerDiff.Value / 100)).ToString("#####0.0").Trim() + "х" + nQuota.ToString("#####0.0").ToString().Trim();
				int nHours = 0;
				int nMinutes = 0;
				/*
				if (txtFreezerDuration.Text.Trim().Length > 0 &&
					txtFreezerDuration.Text.Contains(sTimeDelimiter))
				{
					try
					{
						nHours = Convert.ToInt32(txtFreezerDuration.Text.Substring(0, txtFreezerDuration.Text.IndexOf(sTimeDelimiter)));
						nMinutes = Convert.ToInt32(txtFreezerDuration.Text.Substring(txtFreezerDuration.Text.IndexOf(sTimeDelimiter) + 1, 2));
					}
					catch { }
				}
				*/
				nHours = txtFreezerDuration.GetHours();
				nMinutes = txtFreezerDuration.GetMinutes();
				if (nFreezerQuota != 0 && 
					(nHours != 0 || nMinutes != 0))
				{
					nFuelDiff += (nHours * 60 + nMinutes) * nFreezerQuota / 60;
					sText += " + " + 
						nHours.ToString().Trim() + sTimeDelimiter + nMinutes.ToString("00") + "х" + 
						nFreezerQuota.ToString("#####0.0").ToString().Trim();
				}

				sText = nFuelDiff.ToString("#####0.0").Trim() + " = " + sText;
			}
			lblFuelDiffCalc.Text = "Норматив: " + sText;

            //numFuelDiff.Value = nFuelDiff;
            //numFuelDataEnd.Value = numFuelDataBeg.Value + numFuelQntFilled.Value - numFuelDiff.Value;
			return; 
		}

		private bool SpinnersCheck(bool bForClose)
		{
			// начальные значения
			if (numSpeedometerDataBeg.Value == 0)
			{
				if (!chkSpeedometerEdit.Checked)
				{
					RFMMessage.MessageBoxError("Не указаны начальные показания спидометра...");
					numSpeedometerDataBeg.Select();
					return (false);
				}
				else
				{
					if (RFMMessage.MessageBoxYesNo("Не указаны начальные показания спидометра...\n\n" +
						"Все-таки сохранить (с нулевыми начальными показаниями)?") != DialogResult.Yes)
					{
						numSpeedometerDataBeg.Select();
						return (false);
					}
				}
			}

			if (numFuelDataBeg.Value == 0)
			{
				if (RFMMessage.MessageBoxYesNo("Не указан начальный остаток топлива...\n\n" +
					"Все-таки сохранить (с нулевым остатком)?") != DialogResult.Yes)
				{
					numFuelDataBeg.Select();
					return (false);
				}
			}

            /*
			if (oCarSelected.FuelTank > 0 && numFuelDataBeg.Value > oCarSelected.FuelTank)
			{
				RFMMessage.MessageBoxError("Начальный остаток топлива больше емкости бака...");
				return (false);
			}
			if (oCarSelected.FuelTank > 0 && numFuelDataEnd.Value > oCarSelected.FuelTank)
			{
				RFMMessage.MessageBoxError("Конечный остаток топлива больше емкости бака...");
				return (false);
			}
            */

			if (oCarSelected.FreezerTank != 0)
			{
				if (numFuelFreezerDataBeg.Value == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не указан начальный остаток топлива в баке для холодильной установки...\n\n" +
						"Все-таки сохранить (с нулевым остатком)?") != DialogResult.Yes)
					{
						numFuelDataBeg.Select();
						return (false);
					}
				}

                /*
				if (oCarSelected.FreezerTank > 0 && numFuelFreezerDataBeg.Value > oCarSelected.FreezerTank)
				{
					RFMMessage.MessageBoxError("Начальный остаток топлива в баке для холодильной установки больше емкости этого бака...");
					return (false);
				}
				if (oCarSelected.FreezerTank > 0 && numFuelFreezerDataEnd.Value > oCarSelected.FreezerTank)
				{
					RFMMessage.MessageBoxError("Конечный остаток топлива в баке для холодильной установки больше емкости этого бака...");
					return (false);
				}
                */
			}

			// закрываем лист  
			if (bForClose)
			{
				if (numSpeedometerDataEnd.Value == 0)
				{
					/*
					RFMMessage.MessageBoxError("Не указаны конечные показания спидометра...");
					numSpeedometerDataEnd.Select();
					return (false);
					*/

					if (!chkSpeedometerEdit.Checked)
					{
						RFMMessage.MessageBoxError("Не указаны конечные показания спидометра...");
						numSpeedometerDataEnd.Select();
						return (false);
					}
					else
					{
						if (RFMMessage.MessageBoxYesNo("Не указаны конечные показания спидометра...\n\n" +
							"Все-таки сохранить (с нулевыми конечными показаниями)?") != DialogResult.Yes)
						{
							numSpeedometerDataEnd.Select();
							return (false);
						}
					}

				
				}

				if (numFuelDataEnd.Value == 0)
				{
					if (RFMMessage.MessageBoxYesNo("Не указан конечный остаток топлива...\n\n" +
						"Все-таки сохранить (с нулевым остатком)?") != DialogResult.Yes)
					{
						numSpeedometerDataEnd.Select();
						return (false);
					}
				}

				if (oCarSelected.FreezerTank != 0)
				{
					if (numFuelFreezerDataEnd.Value == 0)
					{
						if (RFMMessage.MessageBoxYesNo("Не указан конечный остаток топлива в баке для холодильной установки...\n\n" +
							"Все-таки сохранить (с нулевым остатком)?") != DialogResult.Yes)
						{
							numFuelFreezerDataEnd.Select();
							return (false);
						}
					}
				}
			} // forClose

			// разница
			if (numSpeedometerDataEnd.Value != 0)
			{
				if (numSpeedometerDataEnd.Value - numSpeedometerDataBeg.Value != numSpeedometerDiff.Value)
				{
					if (RFMMessage.MessageBoxYesNo("Начальные/конечные показания спидометра не сооответствуют пробегу...\n\n" +
						"Все-таки сохранить?") != DialogResult.Yes)
					{
						numSpeedometerDiff.Select();
						return (false);
					}
				}
			}

			if (numFuelDataEnd.Value != 0)
			{
				if (numFuelDataBeg.Value + numFuelFreezerDataBeg.Value +
					numFuelQntFilled.Value - 
					(numFuelDataEnd.Value + numFuelFreezerDataEnd.Value) != numFuelDiff.Value)
				{
					if (RFMMessage.MessageBoxYesNo("Начальные/конечные остатки топлива и заправленное количество топлива не сооответствует расходу топлива...\n\n" +
						"Все-таки сохранить?") != DialogResult.Yes)
					{
						numFuelQntFilled.Select();
						return (false);
					}
				}
				/*if (nFuelDiff != numFuelDiff.Value)
				{
					if (RFMMessage.MessageBoxYesNo("Рассчитанный расход топлива не соответствует расходу топлива по нормам...\n\n" +
						"Все-таки сохранить?") != DialogResult.Yes)
					{
						numFuelQntFilled.Select();
						return (false);
					}
				}*/
			}

			// сумма по заправкам
			if (numFuelQntFilled.Value != 0 || oFilling.MainTable.Rows.Count > 0)
			{
				if (numFuelQntFilled.Value != FuelQntFilledByFillings())
				{
					if (RFMMessage.MessageBoxYesNo("Общее заправленное количество топлива не соответствует данным по заправкам...\n\n" +
						"Все-таки сохранить?") != DialogResult.Yes)
					{
						numFuelQntFilled.Select();
						return (false);
					}
				}
			}

			// добрались, и все сошлось
			return (true);
		}

		private void btnFuelSum_Click(object sender, EventArgs e)
		{
			numFuelQntFilled.Value = FuelQntFilledByFillings();
		}

		private decimal FuelQntFilledByFillings()
		{
			decimal nFuelQntFilledByFillings = 0;
			if (oFilling.MainTable != null && oFilling.MainTable.Rows.Count > 0)
			{
				object oFuelQntFilledByFillings = oFilling.MainTable.Compute("sum(QntFilled)", "");
				if (!Convert.IsDBNull(oFuelQntFilledByFillings) && oFuelQntFilledByFillings != null)
				{
					nFuelQntFilledByFillings = Convert.ToDecimal(oFuelQntFilledByFillings);
				}
			}
			return (nFuelQntFilledByFillings);
		}

		#endregion Spinners

		#region checkersEdit

		private void chkSpeedometerEdit_CheckedChanged(object sender, EventArgs e)
		{
			numSpeedometerDataBeg.Enabled = chkSpeedometerEdit.Checked;
		}

		private void chkFuelEdit_CheckedChanged(object sender, EventArgs e)
		{
			numFuelDataBeg.Enabled = chkFuelEdit.Checked;
			numFuelFreezerDataBeg.Enabled = chkFuelEdit.Checked && (lblFreezerTank.Text.Length > 0);
		}

		#endregion checkersEdit

		private void dtpDateWayBeg_ValueChanged(object sender, EventArgs e)
		{
			if (dtpDateWayBeg.Value.Date > dtpDateWayEnd.Value.Date)
			{
				dtpDateWayEnd.Value = dtpDateWayBeg.Value.Date;
			}
		}

        private void dtpDateWayEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateWayEnd.Value.Date < dtpDateWayBeg.Value.Date)
            {
                dtpDateWayBeg.Value = dtpDateWayEnd.Value.Date;
            }
        }

		private void btnCarInfo_Click(object sender, EventArgs e)
		{
			if (cboCar.SelectedIndex >= 0)
			{
				StartForm(new frmCarsEdit((int)cboCar.SelectedValue, true));
			}
		}
	}
}
