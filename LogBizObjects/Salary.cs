using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic; 

/// <summary>
/// Бизнес-объект Зарплата (Salary)
/// </summary>

namespace LogBizObjects
{
	public class Salary : BizObject 
	{
		protected int? _nSalaryTariffID;
		/// <summary>
		/// Код ID тарифа (SalaryTariffs.ID)
		/// </summary>
		[Description("Код ID тарифа (SalaryTariffs.ID)")]
		public int? nSalaryTariffID { get { return _nSalaryTariffID; } set { _nSalaryTariffID = value; _NeedRequery = true; } }

		protected int? _nSalaryExtraWorkID;
		/// <summary>
		/// Код ID выполненной дополнительной работы (SalaryExtraWorks.ID)
		/// </summary>
		[Description("Код ID выполненной дополнительной работы (SalaryExtraWorks.ID)")]
		public int? nSalaryExtraWorkID { get { return _nSalaryExtraWorkID; } set { _nSalaryExtraWorkID = value; _NeedRequery = true; } }

		// Фильтры
		#region Filters

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: Начальная дата периода (DateBeg)
		/// </summary>
		[Description("Фильтр-поле: Начальная дата периода (DateBeg)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; } }
		
		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: Конечная дата периода (DateEnd)
		/// </summary>
		[Description("Фильтр-поле: Конечная дата периода (DateEnd)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// Фильтр-поле: список сотрудников-водителей (DriverEmployeeID), через запятую
		/// </summary>
		[Description("Фильтр-поле: список сотрудников-водителей (DriverEmployeeID), через запятую")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; } }

		protected string _FilterWorkNameContext;
		/// <summary>
		/// Фильтр-поле: контекст названия работ (WorkName)
		/// </summary>
		[Description("Фильтр-поле: контекст названия работ (WorkName)?")]
		public string FilterWorkNameContext { get { return _FilterWorkNameContext; } set { _FilterWorkNameContext = value; _NeedRequery = true; } }

		#endregion Filters

		// Таблицы
		
		protected DataTable _TableSalaryTariffs;
		/// <summary>
		/// Тарифы по видам работ (TableSalaryTariffs)
		/// </summary>
		[Description("Тарифы по видам работ (TableSalaryTariffs)")]
		public DataTable TableSalaryTariffs { get { return _TableSalaryTariffs; } }

		protected DataTable _TableSalaryExtraWorks;
		/// <summary>
		/// Дополнительные работы (TableSalaryExtraWorks)
		/// </summary>
		[Description("Дополнительные работы (TableSalaryExtraWorks)")]
		public DataTable TableSalaryExtraWorks { get { return _TableSalaryExtraWorks; } }
		
		// -------------------------------------

		public Salary() : base()
		{
			_MainTableName = "SalaryExtraWorks";
		}

		#region FillData

		/// <summary>
		/// получение списка внутр.перемещений (MainTable)
		/// </summary>
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
		/// очистка фильтр-полей
		/// </summary>
		public void ClearFilters()
		{
			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterDriversEmployeesList = null;
			_FilterWorkNameContext = null;
			//_NeedRequery = false;
		}

		#endregion FillData

		#region SalaryExtraWorks

		#region FillData SalaryExtraWorks

		public bool FillTableSalaryExtraWorks()
		{
			ClearData();

			string sqlSelect = "execute up_SalaryExtraWorksFill " +
				"@nID, " +
				"@dDateBeg, @dDateEnd, " +
				"@cDriversEmployeesList, " +
				"@cWorkNameContext";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_SalaryExtraWorksFill parameters

			SqlParameter oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_nSalaryExtraWorkID != null)
				oParameter.Value = _nSalaryExtraWorkID;
			else
				oParameter.Value = DBNull.Value;

			oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (_FilterDateBeg != null)
				oParameter.Value = _FilterDateBeg;
			else
				oParameter.Value = DBNull.Value;

			oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (_FilterDateEnd != null)
				oParameter.Value = _FilterDateEnd;
			else
				oParameter.Value = DBNull.Value;

			oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
			if (_FilterDriversEmployeesList != null)
				oParameter.Value = _FilterDriversEmployeesList;
			else
				oParameter.Value = DBNull.Value;

			oParameter = _oCommand.Parameters.Add("@cWorkNameContext", SqlDbType.VarChar);
			if (_FilterWorkNameContext != null)
				oParameter.Value = _FilterWorkNameContext;
			else
				oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableSalaryExtraWorks = FillReadings(new SqlDataAdapter(_oCommand), _TableSalaryExtraWorks, "TableSalaryExtraWorks");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка выполненных дополнительных работ..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion FillData SalaryExtraWorks

		#region Save SalaryExtraWorks

		public bool SaveSalaryExtraWorks(ref int? nSalaryExtraWorkID,
			DateTime dDateWork,
			string sWorkName,
			int nDriverEmployeeID,
			decimal nQnt,
			decimal nPrice,
			string sNote)
		{
			String _sqlCommand = "execute up_SalaryExtraWorksSave @nID output, " +
					"@dDateWork, " +
					"@cWorkName, " +
					"@nDriverEmployeeID, " +
					"@nQnt, " +
					"@nPrice, " +
					"@cNote, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_SalaryExtraWorksSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_nSalaryExtraWorkID.HasValue)
				_oParameter.Value = _nSalaryExtraWorkID;
			else
				_oParameter.Value = DBNull.Value;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@dDateWork", SqlDbType.DateTime);
			_oParameter.Value = dDateWork;

			_oParameter = _oCommand.Parameters.Add("@cWorkName", SqlDbType.VarChar);
			if (sWorkName != null)
				_oParameter.Value = sWorkName;
			else
				_oParameter.Value = "";

			_oParameter = _oCommand.Parameters.Add("@nDriverEmployeeID", SqlDbType.Int);
			_oParameter.Value = nDriverEmployeeID;

			_oParameter = _oCommand.Parameters.Add("@nQnt", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			_oParameter.Value = nQnt;

			_oParameter = _oCommand.Parameters.Add("@nPrice", SqlDbType.Money);
			_oParameter.Value = nPrice;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (sNote != null)
				_oParameter.Value = sNote;
			else
				_oParameter.Value = "";

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -2;
				_ErrorStr = "Ошибка при попытке сохранения факта выполненной дополнительной работы...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении факта выполненной дополнительной работы...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании новой операции - получим ее код
				if (!Convert.IsDBNull(_oCommand.Parameters["@nID"].Value) && 
					(!nSalaryExtraWorkID.HasValue || nSalaryExtraWorkID == 0))
				{
					nSalaryExtraWorkID = (int)_oCommand.Parameters["@nID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save SalaryExtraWorks

		#region Delete SalaryExtraWorks

		public bool DeleteSalaryExtraWorks(int nSalaryExtraWorkID)
		{
			String _sqlCommand = "execute up_SalaryExtraWorksDelete @nID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_SalaryExtraWorksDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			_oParameter.Value = nSalaryExtraWorkID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -3;
				_ErrorStr = "Ошибка при попытке удаления факта выполненной дополнительной работы...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении факта выполненной дополнительной работы...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete SalaryExtraWorks

		#endregion SalaryExtraWorks


		#region SalaryTariffs

		#region FillData SalaryTariffs

		public bool FillTableSalaryTariffs()
		{
			return (FillTableSalaryTariffs(null, null));
		}

		public bool FillTableSalaryTariffs(int? nSalaryTariffID)
		{
			return (FillTableSalaryTariffs(nSalaryTariffID, null));
		}

		public bool FillTableSalaryTariffs(DateTime? dDate)
		{
			return (FillTableSalaryTariffs(null, dDate));
		}

		public bool FillTableSalaryTariffs(int? nSalaryTariffID, DateTime? dDate)
		{
			string sqlSelect = "execute up_SalaryTariffsFill @nID, @dDate";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (nSalaryTariffID.HasValue)
				_oParameter.Value = nSalaryTariffID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			if (dDate.HasValue)
				_oParameter.Value = dDate;
			else
				_oParameter.Value = DBNull.Value;

			try
			{
				_TableSalaryTariffs = FillReadings(new SqlDataAdapter(_oCommand), _TableSalaryTariffs, "TableSalaryTariffs");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка тарифов на работы для расчета зарплаты..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion FillData SalaryTariffs

		#region Save SalaryTariffs

		public bool SaveSalaryTariffs(ref int? nSalaryTariffID)
		{
			String _sqlCommand = "execute up_SalaryTariffsSave @nID output, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_SalaryTariffsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (nSalaryTariffID.HasValue)
				_oParameter.Value = nSalaryTariffID;
			else
				_oParameter.Value = DBNull.Value;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				RFMUtilities.DataTableToTempTable(TableSalaryTariffs, "#SalaryTariffs", _Connect);
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "Ошибка при сохранении тарифов...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении тарифов...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании новой записи - получим ее код
				if (!Convert.IsDBNull(_oCommand.Parameters["@nID"].Value) && 
					(!nSalaryTariffID.HasValue || nSalaryTariffID == 0))
				{
					nSalaryTariffID = (int)_oCommand.Parameters["@nID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save SalaryTariffs

		#region Delete SalaryTariffs

		public bool DeleteSalaryTariffs(int nSalaryTariffID)
		{
			String _sqlCommand = "execute up_SalaryTariffsDelete @nID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_SalaryTariffsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			_oParameter.Value = nSalaryTariffID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -13;
				_ErrorStr = "Ошибка при удалении тарифов...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении тарифов...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete SalaryTariffs

		#endregion SalaryTariffs

		#region SalaryReports

		/// Отчет по зарплате
		public bool ReportForSalary
			(DateTime? dDateBeg, DateTime? dDateEnd,
			string sDetailMode,
			string sDriversEmployeesList)
		{
			ClearData();
			ClearError();

			string sqlSelect;
			SqlCommand _oCommand;

			sqlSelect = "execute up_ReportForSalaryTotal " +
									"@dDateBeg, @dDateEnd, " +
									"@cDetailMode, " +
									"@cDriversEmployeesList";
			_oCommand = new SqlCommand(sqlSelect, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_ReportForSalary paramaters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg.HasValue)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd.HasValue)
				_oParameter.Value = dDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDetailMode", SqlDbType.VarChar);
			if (sDetailMode != null)
				_oParameter.Value = sDetailMode;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
			if (sDriversEmployeesList != null)
				_oParameter.Value = sDriversEmployeesList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				FillReadings(new SqlDataAdapter(_oCommand), null, "ReportForSalary");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении отчета по зарплате...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

        /// Отчет по зарплате по системе квадратичных штрафов
        public bool ReportForSalaryWithPenalty
            (DateTime? dDateBeg, DateTime? dDateEnd,
            string sDetailMode,
            string sDriversEmployeesList,
            bool bPartner)
        {
            ClearData();
            ClearError();

            string sqlSelect;
            SqlCommand _oCommand;

            sqlSelect = "execute up_ReportForSalaryTotalWithPenalty " +
                                    "@dDateBeg, @dDateEnd, " +
                                    "@cDetailMode, " +
                                    "@cDriversEmployeesList, " +
                                    "@bPartner";
            _oCommand = new SqlCommand(sqlSelect, _Connect);
            _oCommand.CommandTimeout = 0;

            #region up_ReportForSalary paramaters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
            if (dDateBeg.HasValue)
                _oParameter.Value = dDateBeg;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
            if (dDateEnd.HasValue)
                _oParameter.Value = dDateEnd;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cDetailMode", SqlDbType.VarChar);
            if (sDetailMode != null)
                _oParameter.Value = sDetailMode;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
            if (sDriversEmployeesList != null)
                _oParameter.Value = sDriversEmployeesList;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bPartner", SqlDbType.Bit);
            _oParameter.Value = bPartner;

            #endregion

            try
            {
                _Connect.Open();
                FillReadings(new SqlDataAdapter(_oCommand), null, "ReportForSalary");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -21;
                _ErrorStr = "Ошибка при получении отчета по зарплате...\r\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return (_ErrorNumber == 0);
        }

        #endregion SalaryReports
	}
}
