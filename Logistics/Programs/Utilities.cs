using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

using RFMBaseClasses;
using RFMPublic;

using LogBizObjects;

namespace Logistics
{
	public static class Utilities
	{

		#region gridColumn_AgrTypeSet

		public static void ctrl_AgrTypeSet(Control ctrl)
		{
			if (ctrl.GetType().ToString().ToUpper().Contains("RFMDataGridView".ToUpper()))
			{
				foreach (DataGridViewColumn c in ((DataGridView)ctrl).Columns)
				{
					if (c.GetType().ToString().ToUpper().Contains("RFMDataGridViewTextBoxColumn".ToUpper()))
					{
						if ((c.DefaultCellStyle.Format.Contains("N") || c.DefaultCellStyle.Format.Contains("#")) &&
							(!c.DataPropertyName.ToUpper().Contains("ID") &&
							 !c.DataPropertyName.ToUpper().Contains("Price".ToUpper()) &&
							 !c.DataPropertyName.ToUpper().Contains("Percent".ToUpper()) &&
							 !c.DataPropertyName.ToUpper().Contains("InBox".ToUpper()) &&
							 !c.DataPropertyName.ToUpper().Contains("InPal".ToUpper()) && 
							 !c.Name.ToUpper().Contains("Percent".ToUpper()) 
							)
						   )
						{
							// суммирование 
							((RFMDataGridViewTextBoxColumn)c).AgrType = EnumAgregate.Sum;
						}

						if (c.DataPropertyName.ToUpper() == "ID")
						{
							// жирный шрифт для ID
							c.DefaultCellStyle.Font =
							c.HeaderCell.Style.Font =
								new System.Drawing.Font(((Form)ctrl.FindForm()).Font, System.Drawing.FontStyle.Bold);
						}	
					}
				}
			}
			else
			{
				if (ctrl.Controls != null && ctrl.Controls.Count > 0)
				{
					foreach (Control ctrlX in ctrl.Controls)
					{
						ctrl_AgrTypeSet(ctrlX);
					}
				}
			}
		}

		#endregion

		#region ByOrder
		// для разбора списка, возвращаемого их формы frmSysByOrder

		public static string ByOrderList_Next(ref string strInput, string sDelimiter)
		{
			if (strInput == null || strInput.Length == 0)
				return ("");

			string sNumberNext = "";

			if (sDelimiter == null || sDelimiter.Length == 0) sDelimiter = ";";

			if (strInput.Substring(strInput.Length - sDelimiter.Length) != sDelimiter)
				strInput += sDelimiter;
			if (strInput.Substring(0, sDelimiter.Length) == sDelimiter)
				strInput += strInput.Substring(sDelimiter.Length);

			int nAtDelimiter = strInput.IndexOf(sDelimiter);
			if (nAtDelimiter > 0)
			{
				sNumberNext = strInput.Substring(0, nAtDelimiter);
				strInput = strInput.Substring(nAtDelimiter + 1);
			}

			return (sNumberNext); 
		}

		// пример использования 
        /*
            DataTable dtTempTable = dvOrdersInTrip.ToTable();
            gotParam = null;
            if (StartForm(new frmByOrder(dtTempTable, "ByOrder, PartnerTargetName, Brutto#3", "ПЗ, Клиент, Брутто", "ID")) != DialogResult.Yes)
                return;
            string strInput = GotParam[0].ToString();
            if (strInput != null && strInput.Length > 0)
            {
                // разбираем строку
                int nOrderTempID = 0; 
                int nByOrder = 0;
                string sNumber = "-", sMiddleNumber = "-";
                string sDelimiter = ";", sMiddleDelimiter = ","; 
                sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
                while (sNumber.Length > 0)
                {
                    nByOrder++;
                    if (sNumber.Contains(","))
                    {
                        sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
                        while (sMiddleNumber.Length > 0)
                        {
                            try 
                            { 
                                nOrderTempID = Convert.ToInt32(sMiddleNumber); 
                            }
                            catch 
                            { 
                                nOrderTempID = 0; 
                            }
                            if (nOrderTempID > 0)
                            {
                                oOrders.SaveByOrder(nOrderTempID, nByOrder);
                            }
                            sMiddleNumber = Utilities.ByOrderList_Next(ref sNumber, sMiddleDelimiter);
                        }
                    }
                    else
                    {
                        try
                        {
                            nOrderTempID = Convert.ToInt32(sNumber);
                        }
                        catch
                        {
                            nOrderTempID = 0;
                        }
                        if (nOrderTempID > 0)
                        {
                            oOrders.SaveByOrder(nOrderTempID, nByOrder);
                        }
                    }
                    sNumber = Utilities.ByOrderList_Next(ref strInput, sDelimiter);
                }
            }
        */

        #endregion ByOrder

		#region BarCode

		public static string GetCRCBarCode_128A(string sSourceBarCode)
		{
			int nSumA = 0;
			int nSumB = 0;
			for (int i = 0; i < sSourceBarCode.Length; i = i + 2)
			{
				if (!"0123456789".Contains(sSourceBarCode.Substring(i, 1)))
					return ("".PadRight(36, '0'));

				if (i < sSourceBarCode.Length)
					nSumB += Convert.ToInt16(sSourceBarCode.Substring(i, 1));
				if (i + 1 < sSourceBarCode.Length)
					nSumA += Convert.ToInt16(sSourceBarCode.Substring(i + 1, 1));
		}

			int nCRC = 10 - 
				(((nSumA * 3 + nSumB) % 10 == 0) ? 10 : ((nSumA * 3 + nSumB) % 10));
			
			return (sSourceBarCode + nCRC.ToString("0"));
		}

		public static string GetAlfaBankBarCode_128A42(string sPayeeINN, string sPayerINN, decimal nSum, DateTime dDate)
		{
			string sBarCode = "";
			int nLen = 12;
			if (sPayeeINN.Trim().Length > nLen)
				sBarCode += sPayeeINN.Trim().Substring(sPayeeINN.Trim().Length - nLen, nLen);
			else 
				sBarCode += sPayeeINN.Trim().PadLeft(nLen, '0');
			if (sPayerINN.Trim().Length > nLen)
				sBarCode += sPayerINN.Trim().Substring(sPayerINN.Trim().Length - nLen, nLen);
			else 
				sBarCode += sPayerINN.Trim().PadLeft(nLen, '0');
			sBarCode += nSum.ToString("#######0.00").Replace(".", "").Trim().PadLeft(nLen - 1, '0');
			sBarCode += dDate.Day.ToString("00") + dDate.Month.ToString("00") + dDate.Year.ToString("0000").Substring(2, 2);
			return(sBarCode);
		}

		public static string GetAlfaBankBarCode_128A40(string sDocNumber, string sIsoCode)
		{
			string sSourceBarCode = "";
			if (sDocNumber.Trim().Length > 10)
				sSourceBarCode += sDocNumber.Trim().Substring(sDocNumber.Trim().Length - 10, 10);
			else 
				sSourceBarCode += sDocNumber.Trim().PadLeft(10, ' ');
			if (sIsoCode.Trim().Length > 3)
				sSourceBarCode += sIsoCode.Trim().Substring(sIsoCode.Trim().Length - 3, 3);
			else 
				sSourceBarCode += sIsoCode.Trim().PadLeft(3, ' ');

			string sBarCode = "";
			byte[] bs = Encoding.ASCII.GetBytes(sSourceBarCode);
			foreach (byte b in bs)
			{
				sBarCode += b.ToString().Trim().PadLeft(3, '0');
			}
			return (sBarCode);
		}

		#endregion BarCode

		#region FillData for Filters 

		#region FillData Partners, PartnersRoots, Zones

		#region FillData Partners

		public static bool FillData_Partners(Partner oPartner)
		{ 
			return (FillData_Partners(oPartner, false, false, false));
		}

		public static bool FillData_Owners(Partner oPartner)
		{
			return (FillData_Partners(oPartner, true, false, false));
		}

		public static bool FillData_Partners(Partner oPartner, bool bIsOwner, bool bIsSupplier, bool bIsCustomer)
		{
			if (oPartner == null)
				return (false);

			RFMCursorWait.Set(true);
			string sText = "партнеры";
			//oPartner.FilterActual = true;
			if (bIsOwner)
			{
				oPartner.FilterIsOwner = true;
				sText = "владельцы";
			}
			if (bIsSupplier)
			{
				oPartner.FilterIsSupplier = true;
				sText = "поставщики";
			}
			if (bIsCustomer)
			{
				oPartner.FilterIsCustomer = true;
				sText = "получатели";
			}
			if (!oPartner.FillDataAsync() ||
				oPartner.ErrorNumber != 0 || 
				oPartner.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (" + sText + ")...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oPartner.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (" + sText + ")...");
				return (false);
			}
			return (true);
		}

		#endregion FillData Partners

		#region FillData PartnersRoots

		public static bool FillData_PartnersRoots(Partner oPartner)
		{
			if (oPartner == null)
				return (false);

			RFMCursorWait.Set(true);
			//oPartner.FilterActual = true;
			if (!oPartner.FillTablePartnersRoots() ||
				oPartner.ErrorNumber != 0 || 
				oPartner.TablePartnersRoots == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (объединения партнеров)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oPartner.TablePartnersRoots.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (объединения партнеров)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData PartnersRoots

		#region FillData PartnersDetails

		public static bool FillData_PartnersDetails(Partner oPartner)
		{
			return (FillData_PartnersDetails(oPartner, null));
		}

		public static bool FillData_PartnersDetails(Partner oPartner, int? nPartnerID)
		{
			if (oPartner == null)
				return (false);

			RFMCursorWait.Set(true);
			//oPartner.FilterActual = true;
			bool bResult = false;
			if (nPartnerID.HasValue)
				bResult = oPartner.FillTablePartnersDetails((int)nPartnerID);
			else
				bResult = oPartner.FillTablePartnersDetails();
			if (!bResult ||
				oPartner.ErrorNumber != 0 ||
				oPartner.TablePartnersDetails == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (реквизиты партнеров)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oPartner.TablePartnersDetails.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (реквизиты партнеров)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData PartnersDetails

		#region FillData Zones

		public static bool FillData_Zones(Zone oZone)
		{
			if (oZone == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oZone.FillDataAsync() ||
				oZone.ErrorNumber != 0 || 
				oZone.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (зоны)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oZone.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (зоны)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData Zones

		#endregion FillData Partners, PartnersRoots, Zones

		#region FillData OutputsTypes

		public static bool FillData_OutputsTypes(Output oOutput)
		{
			if (oOutput == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oOutput.FillTableOutputsTypes() ||
				oOutput.ErrorNumber != 0 || 
				oOutput.TableOutputsTypes == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (типы расходов)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oOutput.TableOutputsTypes.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (типы расходов)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData OutputsTypes

		#region FillData OutputsDocuments

		#region FillData DepartmentNames

		public static bool FillData_DepartmentNames(OutputDocument oOutputDocument, DateTime? dDateBeg, DateTime? dDateEnd)
		{
			if (oOutputDocument == null)
				return (false);

			if (!dDateBeg.HasValue) dDateBeg = DateTime.Now;
			if (!dDateEnd.HasValue) dDateEnd = DateTime.Now;

			RFMCursorWait.Set(true);
			if (!oOutputDocument.FillTableDepartmentNames(dDateBeg, dDateEnd) ||
				oOutputDocument.ErrorNumber != 0 || 
				oOutputDocument.TableDepartmentNames == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (отделы)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oOutputDocument.TableDepartmentNames.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (отделы)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData DepartmentNames

		#region FillData ManagerNames

		public static bool FillData_ManagerNames(OutputDocument oOutputDocument, DateTime? dDateBeg, DateTime? dDateEnd)
		{
			if (oOutputDocument == null)
				return (false);

			if (!dDateBeg.HasValue) dDateBeg = DateTime.Now;
			if (!dDateEnd.HasValue) dDateEnd = DateTime.Now;

			RFMCursorWait.Set(true);
			if (!oOutputDocument.FillTableManagerNames(dDateBeg, dDateEnd) || 
				oOutputDocument.ErrorNumber != 0 || 
				oOutputDocument.TableManagerNames == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (менеджеры)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oOutputDocument.TableManagerNames.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (менеджеры)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData Managers

		#endregion FillData OutputsDocuments

		#region FillData InputsTypes

		public static bool FillData_InputsTypes(Input oInput)
		{
			if (oInput == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oInput.FillTableInputsTypes() ||
				oInput.ErrorNumber != 0 || 
				oInput.TableInputsTypes == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (типы приходов)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oInput.TableInputsTypes.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (типы приходов)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData InputsTypes

		#region FillData Cars, CarsTypes, CarsClasses

		public static bool FillData_Cars(Car oCar)
		{
			if (oCar == null)
				return (false);

			RFMCursorWait.Set(true);
			//oCar.FilterActual = true;
			if (!oCar.FillDataAsync() ||
				oCar.ErrorNumber != 0 || 
				oCar.MainTable == null)
			{
				RFMCursorWait.Set(false); 
				RFMMessage.MessageBoxError("Ошибка при получении данных (машины)...");
				return (false);
			}
			if (oCar.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false); 
				RFMMessage.MessageBoxError("Нет данных (машины)...");
				return (false);
			}
			return (true);
		}

		public static bool FillData_CarsTypes(CarType oCarType)
		{
			if (oCarType == null)
				return (false);

			RFMCursorWait.Set(true);
			//oCarType.FilterActual = true;
			if (!oCarType.FillDataAsync() ||
				oCarType.ErrorNumber != 0 || 
				oCarType.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (типы машин)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oCarType.MainTable.Rows.Count == 0)
			{
				RFMCursorWait.Set(false); 
				RFMMessage.MessageBoxError("Нет данных (типы машин)...");
				return (false);
			}
			return (true);
		}

		public static bool FillData_CarsClasses(Car oCar)
		{
			if (oCar == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oCar.FillTableCarsClasses() ||
				oCar.ErrorNumber != 0 || 
				oCar.TableCarsClasses == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (классы машин)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oCar.TableCarsClasses.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (классы машин)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData Cars, CarsTypes, CarsClasses

		#region FillData Employees

		public static bool FillData_Employees(Employee oEmployee)
		{
			if (oEmployee == null)
				return (false);

			RFMCursorWait.Set(true);
			//oEmployee.FilterActual = true;
			if (!oEmployee.FillDataAsync() ||
				oEmployee.ErrorNumber != 0 ||
				oEmployee.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (сотрудники)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oEmployee.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (сотрудники)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData Employees

		#region FillData Drivers

		public static bool FillData_Drivers(Driver oDriver)
		{
			if (oDriver == null)
				return (false);

			RFMCursorWait.Set(true);
			//oDriver.FilterActual = true;
			if (!oDriver.FillDataAsync() ||
				oDriver.ErrorNumber != 0 || 
				oDriver.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (водители)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oDriver.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (водители)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData Drivers

		#region FillData FillingsTypes, FuelTypes

		public static bool FillData_FillingsTypes(Filling oFilling)
		{
			if (oFilling == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oFilling.FillTableFillingsTypes() ||
				oFilling.ErrorNumber != 0 || 
				oFilling.TableFillingsTypes == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (типы заправок топлива)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oFilling.TableFillingsTypes.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (типы заправок топлива)...");
				return (false);
			}
			return (true);
		}

		public static bool FillData_FuelTypes(Filling oFilling)
		{
			if (oFilling == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oFilling.FillTableFuelTypes() ||
				oFilling.ErrorNumber != 0 || 
				oFilling.TableFuelTypes == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (типы топлива)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oFilling.TableFuelTypes.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (типы топлива)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData FillingsTypes, FuelTypes

		#region FillData GoodsGroups, GoodsBrands, Countries

		public static bool FillData_GoodsGroups(Good oGood)
		{
			if (oGood == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oGood.FillTableGoodsGroups() ||
				oGood.ErrorNumber != 0 || 
				oGood.TableGoodsGroups == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (товарные группы)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oGood.TableGoodsGroups.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (товарные группы)...");
				return (false);
			}
			return (true);
		}

		public static bool FillData_GoodsBrands(Good oGood)
		{
			if (oGood == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oGood.FillTableGoodsBrands() ||
				oGood.ErrorNumber != 0 || 
				oGood.TableGoodsBrands == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (товарные бренды)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oGood.TableGoodsBrands.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (товарные бренды)...");
				return (false);
			}
			return (true);
		}

		public static bool FillData_GoodsCountries(Good oGood)
		{
			if (oGood == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oGood.FillTableCountries() || 
				oGood.ErrorNumber != 0 || 
				oGood.TableCountries == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (страны)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oGood.TableCountries.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (страны)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData GoodsGroups, GoodsBrands, Countries

		#region FillData GoodsStates

		public static bool FillData_GoodsStates(GoodState oGoodState)
		{
			if (oGoodState == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oGoodState.FillDataAsync() ||
				oGoodState.ErrorNumber != 0 ||
				oGoodState.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (состояния товаров)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oGoodState.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (состояния товаров)...");
				return (false);
			}
			return (true);
		}

		#endregion FillData GoodsStates

		#region FillData Hosts

		public static bool FillData_Hosts(Host oHost)
		{
			if (oHost == null)
				return (false);

			RFMCursorWait.Set(true);
			if (!oHost.FillDataAsync() ||
				oHost.ErrorNumber != 0 || 
				oHost.MainTable == null)
			{
				RFMCursorWait.Set(false);
				RFMMessage.MessageBoxError("Ошибка при получении данных (хосты)...");
				return (false);
			}
			RFMCursorWait.Set(false);
			if (oHost.MainTable.Rows.Count == 0)
			{
				RFMMessage.MessageBoxError("Нет данных (хосты)...");
				return (false);
			}
			return (true);
		}
	
		#endregion FillData Hosts

		#endregion FillData for Filters

	}
}
