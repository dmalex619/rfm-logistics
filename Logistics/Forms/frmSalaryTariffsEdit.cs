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
	public partial class frmSalaryTariffsEdit : RFMFormChild
	{
		private int? nSalaryTariffID;
		private Salary oSalaryTariff;

		public frmSalaryTariffsEdit(int? _nSalaryTariffID)
		{
			if (_nSalaryTariffID.HasValue)
			{
				nSalaryTariffID = (int)_nSalaryTariffID;
			}
			else
			{
				nSalaryTariffID = 0;
			}

			oSalaryTariff = new Salary();
			if (oSalaryTariff.ErrorNumber != 0)
			{
				IsValid = false;
			}

			if (IsValid)
			{
				InitializeComponent();
			}
		}

		private void frmSalaryTariffsEdit_Load (object sender, EventArgs e)
		{
			bool blResult = true;

			if (nSalaryTariffID > 0)
			{
				// редактирование
				oSalaryTariff.FillTableSalaryTariffs(nSalaryTariffID);
			}
			else
			{
				if (nSalaryTariffID < 0)
				{
					// копирование
					oSalaryTariff.FillTableSalaryTariffs(-nSalaryTariffID);
					oSalaryTariff.TableSalaryTariffs.Rows[0]["ID"] = 0;
					nSalaryTariffID = 0;
				}
				else
				{
					// nSalaryTariffID == 0)
					// новая запись
					oSalaryTariff.FillTableSalaryTariffs(0);
					oSalaryTariff.TableSalaryTariffs.Rows.Add();
					oSalaryTariff.TableSalaryTariffs.Rows[0]["ID"] = 0;
				}
			}

			if (oSalaryTariff.ErrorNumber != 0)
			{
				blResult = false;
			}

			if (blResult)
			{
				if (oSalaryTariff.TableSalaryTariffs.Rows.Count != 1)
				{
					RFMMessage.MessageBoxError("Ошибка при получении данных о тарифах...");
					blResult = false;
				}
			}

			if (blResult)
			{
				DataRow r = oSalaryTariff.TableSalaryTariffs.Rows[0];
				dtpDateBeg.Value = Convert.ToDateTime(r["DateBeg"]).Date;
				
                numDaysWorking.Value = Convert.ToDecimal(r["DaysWorking"]);
				numOutNetto.Value = Convert.ToDecimal(r["OutNetto"]);
				numOutPoints.Value = Convert.ToDecimal(r["OutPoints"]);
				numRetPoints.Value = Convert.ToDecimal(r["RetPoints"]);
				numInPoints.Value = Convert.ToDecimal(r["InPoints"]);
				numDistance.Value = Convert.ToDecimal(r["Distance"]);

                numEarlyDepartureTariff.Value = Convert.ToDecimal(r["EarlyDepartureTariff"]);
                numTimeTariff.Value = Convert.ToDecimal(r["TimeTariff"]);
                numNettoTariff.Value = Convert.ToDecimal(r["NettoTariff"]);
			}
			else
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
			// Проверить наличие записи на ту же дату
			DateTime dDate = dtpDateBeg.Value.Date;
			Salary oSalaryTariffTemp = new Salary();
			oSalaryTariffTemp.FillTableSalaryTariffs();
			foreach (DataRow sr in oSalaryTariffTemp.TableSalaryTariffs.Rows)
			{ 
				DateTime dExistDate = Convert.ToDateTime(sr["DateBeg"]);
				if (dDate.CompareTo(dExistDate) == 0 &&
					(int)sr["ID"] != nSalaryTariffID)
				{
					RFMMessage.MessageBoxError("Уже есть тарифы на указанную дату...");
					return;
				}
			}

			DataRow r = oSalaryTariff.TableSalaryTariffs.Rows[0];
			r["DateBeg"] = dDate;

			r["DaysWorking"] = numDaysWorking.Value;
			r["OutNetto"] = numOutNetto.Value;
			r["OutPoints"] = numOutPoints.Value;
			r["RetPoints"] = numRetPoints.Value;
			r["InPoints"] = numInPoints.Value;
			r["Distance"] = numDistance.Value;

            r["EarlyDepartureTariff"] = numEarlyDepartureTariff.Value;
            r["TimeTariff"] = numTimeTariff.Value;
            r["NettoTariff"] = numNettoTariff.Value;

			r["UserID"] = ((RFMFormBase)Application.OpenForms[0]).UserInfo.UserID;

			oSalaryTariff.ClearError();
			oSalaryTariff.SaveSalaryTariffs(ref nSalaryTariffID);
			if (oSalaryTariff.ErrorNumber == 0)
			{
				if (oSalaryTariff.ErrorNumber == 0 &&
					nSalaryTariffID.HasValue && nSalaryTariffID > 0)
				{
					MotherForm.GotParam = new object[] { nSalaryTariffID };
					DialogResult = DialogResult.Yes;
					Dispose();
				}
			}
		}
	}
}
