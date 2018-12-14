using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Заправка (заливка) топлива (Filling), 
/// связанные таблицы: Тип заправки (FillingType), Тип топлива (FuelType)
/// </summary>
/// 
namespace LogBizObjects
{

#region Filling 

	public class Filling: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID заправок (Fillings.ID)
		/// </summary>
		[Description("Список кодов ID заправок (Fillings.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected DateTime _DateFill;
		/// <summary>
		/// Дата заправки (Fillings.DateFill)
		/// </summary>
		[Description("Дата заправки (Fillings.DateFill)")]
		public DateTime DateFill { get { return _DateFill; } set { _DateFill = value; } }
		
		protected int _FillingTypeID;
		/// <summary>
		/// Тип заправки - код (Fillings.FillingTypeID)
		/// </summary>
		[Description("Тип заправки - код (Fillings.FillingTypeID)")]
		public int FillingTypeID { get { return _FillingTypeID; } set { _FillingTypeID = value; } }

		protected string _FillingTypeName;
		/// <summary>
		/// Тип заправки - наименование (Fillings.FillingTypeID -> FillingsTypes.Name)
		/// </summary>
		[Description("Тип заправки - наименование (Fillings.FillingTypeID -> FillingsTypes.Name)")]
		public string FillingTypeName { get { return _FillingTypeName; } set { _FillingTypeName = value; } }

		protected bool _IsOwn;
		/// <summary>
		/// Собственное топливо (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?
		/// </summary>
		[Description("Собственное топливо (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?")]
		public bool IsOwn { get { return _IsOwn; } set { _IsOwn = value; } }

		protected int? _FuelTypeID;
		/// <summary>
		/// Тип топлива - код (Fillings.FuelTypeID)
		/// </summary>
		[Description("Тип топлива - код (Fillings.FuelTypeID)")]
		public int? FuelTypeID { get { return _FuelTypeID; } set { _FuelTypeID = value; } }

		protected string _FuelTypeName;
		/// <summary>
		/// Тип топлива - наименование (Fillings.FuelTypeID -> FuelTypes.Name)
		/// </summary>
		[Description("Тип топлива - наименование (Fillings.FuelTypeID -> FuelTypes.Name)")]
		public string FuelTypeName { get { return _FuelTypeName; } set { _FuelTypeName = value; } }

		protected int? _CarID;
		/// <summary>
		/// Машина - код (Fillings.CarID)
		/// </summary>
		[Description("Машина - код (Fillings.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// Машина - наименование (Fillings.CarID -> Cars.Name)
		/// </summary>
		[Description("Машина - наименование (Fillings.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// Машина - гос.номер (Fillings.CarID -> Cars.Number)
		/// </summary>
		[Description("Машина - гос.номер (Fillings.CarID -> Cars.Number)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// Тип машины - код (Fillings.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("Тип машины - код (Fillings.CarID -> Cars.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// Тип машины - наименование (Fillings.CarID -> Cars.CarTypeID -> CarsTypes.Name)
		/// </summary>
		[Description("Тип машины - наименование (Fillings.CarID -> Cars.CarTypeID-> CarsTypes.Name)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// Сотрудник-водитель - код (Fillings.DriverEmployeeID)
		/// </summary>
		[Description("Сотрудник-водитель - код (Fillings.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// Сотрудник-водитель - наименование (Fillings.DriverEmployeeID -> Employees.ID --> Drivers.Name)
		/// </summary>
		[Description("Сотрудник-водитель - наименование (Fillings.DriverEmployeeID -> Employees.ID --> Drivers.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected decimal _QntFilled;
		/// <summary>
		/// Количество заправленного топлива, л (Fillings.QntFilled)
		/// </summary>
		[Description("Количество заправленного топлива, л (Fillings.QntFilled)")]
		public decimal QntFilled { get { return _QntFilled; } set { _QntFilled = value; } }

		protected decimal _Amount;
		/// <summary>
		/// Стоимость заправленного топлива, руб. (Fillings.Amount)
		/// </summary>
		[Description("Стоимость заправленного топлива, руб. (Fillings.Amount)")]
		public decimal Amount { get { return _Amount; } set { _Amount = value; } }

		protected decimal _Price;
		/// <summary>
		/// Цена заправленного топлива, руб./л (Fillings.Amount / Qnt)
		/// </summary>
		[Description("Цена заправленного топлива, руб./л (Fillings.Amount / Qnt)")]
		public decimal Price { get { return _Price; } set { _Price = value; } }

		protected int? _WayBillID;
		/// <summary>
		/// Путевой лист - код (Fillings.WayBillID)
		/// </summary>
		[Description("Путевой лист - код (Fillings.WayBillID)")]
		public int? WayBillID { get { return _WayBillID; } set { _WayBillID = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания к заправке (Fillings.Note)
		/// </summary>
		[Description("Примечания к заправке (Fillings.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }
		
		protected string _ERPCode;
		/// <summary>
		/// Код заправки в host-системе (Fillings.ERPCode)
		/// </summary>
		[Description("Код заправки в host-системе (Fillings.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата заправки - начальная дата периода (Fillings.DateFill)
		/// </summary>
		[Description("Фильтр-поле: дата заправки - начальная дата периода (Fillings.DateFill)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата заправки - конечная дата периода (Fillings.DateFill)
		/// </summary>
		[Description("Фильтр-поле: дата заправки - конечная дата периода (Fillings.DateFill)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }
		
		protected string _FilterFillingsTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов заправок, через запятую (Fillings.FillingTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов заправок, через запятую (Fillings.FillingTypeID)")]
		public string FilterFillingsTypesList { get { return _FilterFillingsTypesList; } set { _FilterFillingsTypesList = value; _NeedRequery = true; } }

		protected string _FilterFuelTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов топлива, через запятую (Fillings.FuelTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов топлива, через запятую (Fillings.FuelTypeID)")]
		public string FilterFuelTypesList { get { return _FilterFuelTypesList; } set { _FilterFuelTypesList = value; _NeedRequery = true; } }

		protected bool? _FilterIsOwn;
		/// <summary>
		/// Фильтр-поле: собственное топливо (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?
		/// </summary>
		[Description("Фильтр-поле: собственное топливо (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?")]
		public bool? FilterIsOwn { get { return _FilterIsOwn; } set { _FilterIsOwn = value; _NeedRequery = true; } }

		protected string _FilterCarsList;
		/// <summary>
		/// Фильтр-поле: список кодов машин, через запятую (Fillings.CarID)
		/// </summary>
		[Description("Фильтр-поле: список кодов машин, через запятую (Fillings.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов машин, через запятую (Fillings.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов машин, через запятую (Fillings.CarID -> Cars.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// Фильтр-поле: список кодов сотрудников-водителей, через запятую (Fillings.DriversEmployeeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов сотрудников-водителей, через запятую (Fillings.DriversEmployeeID)")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterWayBillsList;
		/// <summary>
		/// Фильтр-поле: список кодов путевых листов, через запятую (Fillings.WayBillID)
		/// </summary>
		[Description("Фильтр-поле: список кодов путевых листов, через запятую (Fillings.WayBillID)")]
		public string FilterWayBillsList { get { return _FilterWayBillsList; } set { _FilterWayBillsList = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableFillingsTypes;
		/// <summary>
		/// Таблица типов заправок FillingsTypes
		/// </summary>
		[Description("Таблица типов заправок FillingsTypes")]
		public DataTable TableFillingsTypes { get { return _TableFillingsTypes; } }

		protected DataTable _TableFuelTypes;
		/// <summary>
		/// Таблица типов заправок FuelTypes
		/// </summary>
		[Description("Таблица типов заправок FuelTypes")]
		public DataTable TableFuelTypes { get { return _TableFuelTypes; } }

		#endregion Таблицы

		// ----------------------------

		public Filling()
			: base()
		{
			_MainTableName = "Fillings";
			_ColumnID = "ID";
			_ColumnName = "DateFill";
		}


		#region FillData

		/// <summary>
		/// получение полного списка заправок с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_FillingsFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@cFillingsTypesList, " +
									"@cFuelTypesList, " +
									"@bIsOwn, " +
									"@cCarsList, " +
									"@cCarsTypesList, " +
									"@cDriversEmployeesList, " +
									"@cWayBillsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_FillingsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_ID != null)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cIDList", SqlDbType.VarChar);
			if (_IDList != null)
				_oParameter.Value = _IDList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (_FilterDateBeg.HasValue)
				_oParameter.Value = _FilterDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (_FilterDateEnd.HasValue)
				_oParameter.Value = _FilterDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cFillingsTypesList", SqlDbType.VarChar);
			if (_FilterFillingsTypesList != null)
				_oParameter.Value = _FilterFillingsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cFuelTypesList", SqlDbType.VarChar);
			if (_FilterFuelTypesList != null)
				_oParameter.Value = _FilterFuelTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOwn", SqlDbType.Bit);
			if (_FilterIsOwn != null)
				_oParameter.Value = _FilterIsOwn;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarsList", SqlDbType.VarChar);
			if (_FilterCarsList != null)
				_oParameter.Value = _FilterCarsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarsTypesList", SqlDbType.VarChar);
			if (_FilterCarsTypesList != null)
				_oParameter.Value = _FilterCarsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
			if (_FilterDriversEmployeesList != null)
				_oParameter.Value = _FilterDriversEmployeesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cWayBillsList", SqlDbType.VarChar);
			if (_FilterWayBillsList != null)
				_oParameter.Value = _FilterWayBillsList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_MainTable.PrimaryKey = new DataColumn[] { _MainTable.Columns[_ColumnID] };
				_NeedRequery = false;
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка заправок..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка фильтр-полей
		/// </summary>
		public void ClearFilters()
		{
			_IDList = null;

			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterFillingsTypesList = null;
			_FilterFuelTypesList = null;
			_FilterIsOwn = null;
			_FilterCarsList = null;
			_FilterCarsTypesList = null;
			_FilterDriversEmployeesList = null;
			_FilterWayBillsList = null;
			//_NeedRequery = true;
		}

		#endregion FillData

		#region FillOne

		// собственно заполнение свойств экземпляра объекта данными строки 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();

			if (r != null)
			{
				try
				{
					_ID = Convert.ToInt32(r["ID"]);
					_DateFill = Convert.ToDateTime(r["DateFill"]);

					_FillingTypeID = Convert.ToInt32(r["FillingTypeID"]);
					_FillingTypeName = r["FillingTypeName"].ToString();
					_FuelTypeID = Convert.ToInt32(r["FuelTypeID"]);
					_FuelTypeName = r["FuelTypeName"].ToString();
					_IsOwn = Convert.ToBoolean(r["IsOwn"]);

					_CarID = Convert.ToInt32(r["CarID"]);
					_CarName = r["CarName"].ToString();
					_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
					_CarTypeName = r["CarTypeName"].ToString();
					_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
					_DriverName = r["DriverName"].ToString();

					_QntFilled = Convert.ToDecimal(r["QntFilled"]);
					_Amount = Convert.ToDecimal(r["Amount"]);
					_Price = Convert.ToDecimal(r["Price"]);

					if (!Convert.IsDBNull(r["WayBillID"]))
						_WayBillID = Convert.ToInt32(r["WayBillID"]);

					_Note = r["Note"].ToString();
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о заправке...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о заправке (нет данных)...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка свойств экземпляра
		/// </summary>
		public void ClearOne()
		{
			_ID = null;

			_DateFill = DateTime.Now.Date;

			_FillingTypeID = 0;
			_FillingTypeName = "";
			_FuelTypeID = 0;
			_FuelTypeName = "";
			_IsOwn = false;

			_CarID = null;
			_CarName = null;
			_CarNumber = null;
			_CarTypeID = null;
			_CarTypeName = null;
			_DriverEmployeeID = null;
			_DriverName = null;

			_WayBillID = null;

			_Note = "";
			_ERPCode = null; 

		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// сохранение данных заправки
		/// </summary>

		public bool SaveOne()
		{
			string _sqlCommand = "execute up_FillingsSave @nFillingID output, " +
					"@dDateFill, @nWayBillID, @nCarID, @nDriverEmployeeID, " + 
					"@nFillingTypeID, @nFuelTypeID, " + 
					"@nQntFilled, @nAmount, " +
					"@cNote, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_FillingsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nFillingID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDateFill", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateFill;

			_oParameter = _oCommand.Parameters.Add("@nWayBillID", SqlDbType.Int);
			if (_WayBillID.HasValue)
				_oParameter.Value = _WayBillID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			_oParameter.Value = _CarID;

			_oParameter = _oCommand.Parameters.Add("@nDriverEmployeeID", SqlDbType.Int);
			_oParameter.Value = _DriverEmployeeID;

			_oParameter = _oCommand.Parameters.Add("@nFillingTypeID", SqlDbType.Int);
			_oParameter.Value = _FillingTypeID;

			_oParameter = _oCommand.Parameters.Add("@nFuelTypeID", SqlDbType.Int);
			_oParameter.Value = _FuelTypeID;

			_oParameter = _oCommand.Parameters.Add("@nQntFilled", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			_oParameter.Value = _QntFilled;

			_oParameter = _oCommand.Parameters.Add("@nAmount", SqlDbType.Money);
			_oParameter.Value = _Amount;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			_oParameter.Value = _Note;

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
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при сохранении данных о заправке топлива...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении данных о заправке топлива...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании новой заправки - получим ее код
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nFillingID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nFillingID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// удаление данных о заправке топлива
		/// </summary>
		public bool DeleteOne(int nFillingID)
		{
			String _sqlCommand = "execute up_FillingsDelete @nFillingID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_FillingsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nFillingID", SqlDbType.Int);
			_oParameter.Value = nFillingID;

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
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при удалении данных о заправке топлива...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении данных о заправке топлива...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete


		#region Таблицы

		#region TableFillingsTypes

		/// <summary>
		/// получение таблицы типов заправок (TableFillingsTypes)
		/// </summary>
		public bool FillTableFillingsTypes()
		{
			string sqlSelect = 
				"select ID, Name, "  + 
						"IsOwn, " +
						"ERPCode " + 
					"from FillingsTypes " +
					"where 1 = 1 ";
			if (_FilterFillingsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterFillingsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableFillingsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableFillingsTypes, "TableFillingsTypes ");
				_TableFillingsTypes.PrimaryKey = new DataColumn[] { _TableFillingsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка типов заправок..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TableFillingsTypes

		#region TableFuelTypes

		/// <summary>
		/// получение таблицы типов топлива (TableFuelTypes)
		/// </summary>
		public bool FillTableFuelTypes()
		{
			string sqlSelect =
				"select ID, Name, " +
						"ERPCode " +
					"from FuelTypes " +
					"where 1 = 1 ";
			if (_FilterFuelTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterFuelTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_TableFuelTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableFuelTypes, "TableFuelTypes");
				_TableFuelTypes.PrimaryKey = new DataColumn[] { _TableFuelTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка типов топлива..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TableFuelTypes

		#endregion Таблицы

	}

#endregion Filling

}
