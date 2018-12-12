using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Отчет (Report)
/// </summary>
/// 
namespace LogBizObjects
{
	public class Report: BizObject 
	{
		protected DataTable _TableReport;
		/// <summary>
		/// Таблица данных - результат отчета, дополнительно к MainTable
		/// </summary>
		[Description("Таблица данных - результат отчета, дополнительно к MainTable")]
		public DataTable TableReport { get { return _TableReport; } }

		// ----------------------------

		public Report() : base()
		{
			_MainTableName = "Report";
		}

		public override bool FillDataAsync()
		{
			ClearData();
			return (_ErrorNumber == 0);
		}

		public override bool FillOneRow(DataRow r)
		{
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// Баланс по рейсу
		/// </summary>
		public bool Report_TripBalance(string sTripsList)
		{
			ClearData();

			string sqlSelect = "execute up_TripsBalanceCalc @cTripsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
			if (sTripsList != null)
				_oParameter.Value = sTripsList;
			else
				_oParameter.Value = DBNull.Value;
			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally 
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

        /// <summary>
        /// Отчет о недоставленных товарах в заданных рейсах
        /// </summary>
        public bool Report_TripsListUnDelivery(string sTripsList, string sOwnersList)
        {
            ClearData();

            string sqlSelect = "execute up_TripsListUnDelivery @cTripsList, @cOwnersList";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
            if (sTripsList != null)
                _oParameter.Value = sTripsList;
            else
                _oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (sOwnersList != null)
				_oParameter.Value = sOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

            try
            {
                _Connect.Open();
                _MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
            }
            catch (Exception ex)
            {
                _ErrorNumber = -1;
                _ErrorStr = "Ошибка при получении данных...\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return (_ErrorNumber == 0);
        }

        /// <summary>
        /// Отчет о всех типах возвратов (полный и частичный недовоз, а также перенесенные заказы)
        /// </summary>
        public bool Report_TripsListAllReturns(string sTripsList, string sOwnersList)
        {
            ClearData();

			string sqlSelect = "execute up_TripsListAllReturns @cTripsList, @cOwnersList";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
            if (sTripsList != null)
                _oParameter.Value = sTripsList;
            else
                _oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (sOwnersList != null)
				_oParameter.Value = sOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

            try
            {
                _Connect.Open();
                _MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
            }
            catch (Exception ex)
            {
                _ErrorNumber = -1;
                _ErrorStr = "Ошибка при получении данных...\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return (_ErrorNumber == 0);
        }

		/// <summary>
		/// Отчет о всех типов возвратов (полный и частичный недовоз, а также перенесенные заказы)
		/// </summary>
		public bool Report_TripsCarries(string sTripsList, int nMode, 
			string sOwnersList, string sPartnersList, string sPackingsList, bool? bIsConfirmed)
		{
			ClearData();

			string sqlSelect = "execute up_TripsCarriesFill @cTripsList, @nMode, " +
				"@cOwnersList, @cPartnersList, " + 
				"@cPackingsList, " + 
				"@bIsConfirmed";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
			if (sTripsList != null)
				_oParameter.Value = sTripsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nMode", SqlDbType.Int);
			_oParameter.Value = nMode; 

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (sOwnersList != null)
				_oParameter.Value = sOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
			if (sPartnersList != null)
				_oParameter.Value = sPartnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPackingsList", SqlDbType.VarChar);
			if (sPackingsList != null)
				_oParameter.Value = sPackingsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (bIsConfirmed != null)
				_oParameter.Value = bIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// Отчет для построения MX3 (возврат с хранения) за дату или для документа
		/// </summary>
        public bool Report_OutputsDocumentsMX3(string sOutputsDocumentsList, bool bGroupByBillNumber) 
		{
			ClearData();

            string sqlSelect = "execute up_OutputsDocumentsMX3Report @cOutputsDocumentsList, @bGroupByBillNumber, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			if (sOutputsDocumentsList != null)
				_oParameter.Value = sOutputsDocumentsList;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bGroupByBillNumber", SqlDbType.Bit);
            _oParameter.Value = bGroupByBillNumber;

            _oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorStr", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных (товары в расходных документах)...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при получении данных (товары в расходных документах)...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#region за дату / единичный документ
		public bool Report_OutputsDocumentsMX3(DateTime dDate, string sOwnersList)
		{
			return (Report_OutputsDocumentsMX3(dDate, sOwnersList, null));
		}

		public bool Report_OutputsDocumentsMX3(int nOutputDocumentID)
		{
			return (Report_OutputsDocumentsMX3(null, null, nOutputDocumentID));
		}

		public bool Report_OutputsDocumentsMX3(DateTime? dDate, string sOwnersList, int? nOutputDocumentID)
		{
			ClearData();

			string sqlSelect = "execute up_OutputsDocumentsMX3Report @dDate, @cOwnersList, @nOutputDocumentID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			if (dDate != null)
				_oParameter.Value = dDate;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (sOwnersList != null)
				_oParameter.Value = sOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			if (nOutputDocumentID != null)
				_oParameter.Value = nOutputDocumentID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorStr", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при получении данных по расходным документам...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}
		#endregion за дату / единичный документ

		/// <summary>
		/// Отчет "водители - точки"
		/// </summary>
		public bool Report_TripsPointsCalc(DateTime? dDateBeg, DateTime? dDateEnd, 
			string sDriversEmployeesList, string sOwnersList, int nMode)
		{
			ClearData();

			string sqlSelect = "execute up_TripsPointsCalc @dDateBeg, @dDateEnd, @cDriversEmployeesList, @cOwnersList, @nMode";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg != null)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd != null)
				_oParameter.Value = dDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
			if (sDriversEmployeesList != null)
				_oParameter.Value = sDriversEmployeesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (sOwnersList != null)
				_oParameter.Value = sOwnersList;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nMode", SqlDbType.Int);
            _oParameter.Value = nMode;

            #endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// Отчет "время работы водителей"
		/// </summary>
		public bool Report_DriversWorksTimes(DateTime? dDateBeg, DateTime? dDateEnd,
			string sDriversEmployeesList,  
			int nMode)
		{
			ClearData();

			string sqlSelect = "execute up_ReportDriversWorksTimes @dDateBeg, @dDateEnd, @cDriversEmployeesList, @nMode";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg != null)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd != null)
				_oParameter.Value = dDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
			if (sDriversEmployeesList != null)
				_oParameter.Value = sDriversEmployeesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nMode", SqlDbType.Int);
			_oParameter.Value = nMode;

			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных (время работы водителей)...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// Отчет "себестоимость рейса"
		/// </summary>
		public bool Report_TripsCosts(DateTime? dDateBeg, DateTime? dDateEnd, 
				string sOwnersList, string sPartnersTargetList, 
				string sDepartmentNamesList, string sManagerNamesList, 
				string sGroupBy)
		{
			ClearData();

			string sqlSelect = "execute up_ReportTripsCosts @dDateBeg, @dDateEnd, " +
					"@cOwnersList, @cPartnersTargetList, " + 
					"@cDepartmentNamesList, @cManagerNamesList, " + 
					"@cGroupBy";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg != null)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd != null)
				_oParameter.Value = dDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (sOwnersList != null)
				_oParameter.Value = sOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersTargetList", SqlDbType.VarChar);
			if (sPartnersTargetList != null)
				_oParameter.Value = sPartnersTargetList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDepartmentNamesList", SqlDbType.VarChar);
			if (sDepartmentNamesList != null)
				_oParameter.Value = sDepartmentNamesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cManagerNamesList", SqlDbType.VarChar);
			if (sManagerNamesList != null)
				_oParameter.Value = sManagerNamesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGroupBy", SqlDbType.VarChar);
			if (sGroupBy != null)
				_oParameter.Value = sGroupBy;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных (себестоимость рейсов)...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// Отчет "по топливу"
		/// </summary>
		public bool Report_WayBillsFuelData(DateTime? dDateBeg, DateTime? dDateEnd,
				string sCarsList, 
				bool? @bIsConfirmed)
		{
			ClearData();

			string sqlSelect = "execute up_ReportWayBillsFuelData @dDateBeg, @dDateEnd, " +
					"@cCarsList, " + 
					"@bIsConfirmed";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg != null)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd != null)
				_oParameter.Value = dDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarsList", SqlDbType.VarChar);
			if (sCarsList != null)
				_oParameter.Value = sCarsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (bIsConfirmed != null)
				_oParameter.Value = bIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных (себестоимость рейсов)...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

        /// <summary>
        /// Отчет "по топливу"
        /// </summary>
        public bool Report_GetExchangeLog(int nHours, string cHostsList, string cMode, bool bErrorOnly)
        {
            ClearData();

            string sqlSelect = "execute up__ExchangeLogFill @nHours, @cHostsList, @cMode, @bErrorOnly";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nHours", SqlDbType.Int);
            _oParameter.Value = nHours;

            _oParameter = _oCommand.Parameters.Add("@cHostsList", SqlDbType.VarChar);
            _oParameter.Value = cHostsList;

            _oParameter = _oCommand.Parameters.Add("@cMode", SqlDbType.VarChar);
            _oParameter.Value = cMode;

            _oParameter = _oCommand.Parameters.Add("@bErrorOnly", SqlDbType.Bit);
            _oParameter.Value = bErrorOnly;

            #endregion

            try
            {
                _Connect.Open();
                _MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
            }
            catch (Exception ex)
            {
                _ErrorNumber = -1;
                _ErrorStr = "Ошибка при получении данных (журнал обмена)...\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return (_ErrorNumber == 0);
        }

        /// <summary>
        /// Функция возвращает строку с юр. названием компании и адресом склада из таблицы _Settings
        /// </summary>
        /// <returns></returns>
        public string Report_GetWeNameStorageAddress()
        {
            string sResult = "";

            string sqlSelect = "select dbo.GetWeNameStorageAddress()";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            try
            {
                _Connect.Open();
                object oResult = _oCommand.ExecuteScalar();
                if (oResult != null) sResult = oResult.ToString();
            }
            catch (Exception ex)
            {
                _ErrorNumber = -1;
                _ErrorStr = "Ошибка при получении данных (название компании)...\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return sResult;
        }
    }
}
