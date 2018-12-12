using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Машина (Car), Тип машины (CarType)
/// </summary>
/// 
namespace LogBizObjects
{

#region Car 

	public class Car: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID машин (Cars.ID)
		/// </summary>
		[Description("Список кодов ID машин (Cars.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		protected string _CarName;
		/// <summary>
		/// Наименование машины (Cars.Name)
		/// </summary>
		[Description("Наименование машины (Cars.Name)")]
		public string Name { get { return _Name; } set { _CarName = _Name = value; } }
		public string CarName { get { return _CarName; } set { _CarName = _Name = value; } }

		protected string _CarNumber;
		/// <summary>
		/// Гос.номер машины (Cars.CarNumber)
		/// </summary>
		[Description("Гос.номер машины (Cars.CarNumber)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected string _TrailerNumber;
		/// <summary>
		/// Гос.номер прицепа (Cars.TrailerNumber)
		/// </summary>
		[Description("Гос.номер машины (Cars.TrailerNumber)")]
		public string TrailerNumber { get { return _TrailerNumber; } set { _TrailerNumber = value; } }

        protected string _CarModel;
        /// <summary>
        /// Марка и модель машины (Cars.CarModel)
        /// </summary>
        [Description("Марка и модель машины (Cars.CarModel)")]
        public string CarModel { get { return _CarModel; } set { _CarModel = value; } }

		protected int _CarTypeID;
		/// <summary>
		/// Тип машины - код (Cars.CarTypeID)
		/// </summary>
		[Description("Тип машины - код (Cars.CarTypeID)")]
		public int CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// Тип машины - наименование (Cars.CarTypeID -> CarsTypes.Name)
		/// </summary>
		[Description("Тип машины - наименование (Cars.CarTypeID -> CarsTypes.Name)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int _CarClassID;
		/// <summary>
		/// Класс машины - код (Cars.CarClassID)
		/// </summary>
		[Description("Класс машины - код (Cars.CarClassID)")]
		public int CarClassID { get { return _CarClassID; } set { _CarClassID = value; } }

		protected string _CarClassName;
		/// <summary>
		/// Класс машины - наименование (Cars.CarClassID -> CarsClasses.Name)
		/// </summary>
		[Description("Класс машины - наименование (Cars.CarClassID -> CarsClasses.Name)")]
		public string CarClassName { get { return _CarClassName; } set { _CarClassName = value; } }

		protected bool _Operable;
		/// <summary>
		/// Машина используется (Cars.Operable)?
		/// </summary>
		[Description("Машина используется (Cars.Operable)?")]
		public bool Operable { get { return _Operable; } set { _Operable = value; } }

		protected bool _ForGoodsOnly;
		/// <summary>
		/// Машина - для доставки товара (Cars.ForGoodsOnly)?
		/// </summary>
		[Description("Машина - для доставки товара (Cars.ForGoodsOnly)?")]
		public bool ForGoodsOnly { get { return _ForGoodsOnly; } set { _ForGoodsOnly = value; } }

		protected bool _IsPassengerCar;
		/// <summary>
		/// Легковая машина (Cars.PassengerCar)?
		/// </summary>
		[Description("Легковая машина (Cars.PassengerCar)?")]
		public bool IsPassengerCar { get { return _IsPassengerCar; } set { _IsPassengerCar = value; } }

		protected bool _IsPostern;
		/// <summary>
		/// Машина с задней дверью (Cars.IsPostern)?
		/// </summary>
		[Description("Машина с задней дверью (Cars.IsPostern)?")]
		public bool IsPostern { get { return _IsPostern; } set { _IsPostern = value; } }

		protected bool _IsLoadLift;
		/// <summary>
		/// Машина с подъемником (лопатой) (Cars.IsLoadLift)?
		/// </summary>
		[Description("Машина с подъемником (лопатой) (Cars.IsLoadLift)?")]
		public bool IsLoadLift { get { return _IsLoadLift; } set { _IsLoadLift = value; } }

		protected int _Tonnage;
		/// <summary>
		/// Грузоподъемность факт., кг (Cars.Tonnage)
		/// </summary>
		[Description("Грузоподъемность факт., кг (Cars.Tonnage)")]
		public int Tonnage { get { return _Tonnage; } set { _Tonnage = value; } }

		protected int _Weight;
		/// <summary>
		/// Вес машины без груза, кг (Cars.Weight)
		/// </summary>
		[Description("Вес машины без груза, кг (Cars.Weight)")]
		public int Weight { get { return _Weight; } set { _Weight = value; } }

		protected decimal _Volume;
		/// <summary>
		/// Объем, м3 (Cars.Volume)
		/// </summary>
		[Description("Объем, м3 (Cars.Volume)")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }

		protected decimal _MaxPalletsQnt;
		/// <summary>
		/// Максимальное количество паллет (Cars.MaxPalletsQnt)
		/// </summary>
		[Description("Максимальное количество паллет (Cars.MaxPalletsQnt)")]
		public decimal MaxPalletsQnt { get { return _MaxPalletsQnt; } set { _MaxPalletsQnt = value; } }

		protected int _MaxPointsQnt;
		/// <summary>
		/// Максимальное количество адресов доставки за рейс (Cars.MaxPointsQnt)
		/// </summary>
		[Description("Максимальное количество адресов доставки за рейс (Cars.MaxPointsQnt)")]
		public int MaxPointsQnt { get { return _MaxPointsQnt; } set { _MaxPointsQnt = value; } }

		protected int _MaxDurationMinutes;
		/// <summary>
		/// Максимальная продолжительность рейса, минут (Cars.MaxDurationMinutes)
		/// </summary>
		[Description("Максимальная продолжительность рейса, минут (Cars.MaxDurationMinutes)")]
		public int MaxDurationMinutes { get { return _MaxDurationMinutes; } set { _MaxDurationMinutes = value; } }

		protected string _MaxDurationHoursMinutes;
		/// <summary>
		/// Максимальная продолжительность рейса, час:мин (Cars.MaxDurationMinutes -> dbo.DurationHoursMinutesFromMinutes())
		/// </summary>
		[Description("Максимальная продолжительность рейса, час:мин (Cars.MaxDurationMinutes -> dbo.DurationHoursMinutesFromMinutes()")]
		public string MaxDurationHoursMinutes { get { return _MaxDurationHoursMinutes; } set { _MaxDurationHoursMinutes = value; } }

		protected int _PermitLevelID;
		/// <summary>
		/// Разрешение проезда - код (Cars.PermitLevelID)
		/// </summary>
		[Description("Разрешение проезда - код (Cars.PermitLevelID)")]
		public int PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// Разрешение проезда - наименование (Cars.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("Разрешение проезда - наименование (Cars.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int _PermitLevelValue;
		/// <summary>
		/// Разрешение проезда - уровень, не менее (Cars.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Разрешение проезда - уровень, не менее (Cars.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected bool _AutoFreezer;
		/// <summary>
		/// Питание холодильной установки от двигателя (Cars.AutoFreezer)?
		/// </summary>
		[Description("Питание холодильной установки от двигателя (Cars.AutoFreezer)?")]
		public bool AutoFreezer { get { return _AutoFreezer; } set { _AutoFreezer = value; } }

		protected int? _FuelTypeID;
		/// <summary>
		/// Тип топлива - код (Fuels.FuelTypeID)
		/// </summary>
		[Description("Тип топлива - код (Fuels.FuelTypeID)")]
		public int? FuelTypeID { get { return _FuelTypeID; } set { _FuelTypeID = value; } }

		protected string _FuelTypeName;
		/// <summary>
		/// Тип топлива - наименование (Fuels.FuelTypeID -> FuelsTypes.Name)
		/// </summary>
		[Description("Тип топлива - наименование (Fuels.FuelTypeID -> FuelsTypes.Name)")]
		public string FuelTypeName { get { return _FuelTypeName; } set { _FuelTypeName = value; } }

		protected decimal _FuelTank;
		/// <summary>
		/// Емкость топливного бака, л (Cars.FuelTank)
		/// </summary>
		[Description("Емкость топливного бака, л (Cars.FuelTank)")]
		public decimal FuelTank { get { return _FuelTank; } set { _FuelTank = value; } }
		
		protected decimal _FreezerTank;
		/// <summary>
		/// Емкость бака для холодильной установки, л (Cars.FreezerTank)
		/// </summary>
		[Description("Емкость бака для холодильной установки, л (Cars.FreezerTank)")]
		public decimal FreezerTank { get { return _FreezerTank; } set { _FreezerTank = value; } }

		protected decimal _FuelQuotaSummer;
		/// <summary>
		/// Средний расход топлива (лето), л/100км (Cars.FuelQuotaSummer)
		/// </summary>
		[Description("Средний расход топлива (лето), л/100км (Cars.FuelQuotaSummer)")]
		public decimal FuelQuotaSummer { get { return _FuelQuotaSummer; } set { _FuelQuotaSummer = value; } }
		
		protected decimal _FuelQuotaWinter;
		/// <summary>
		/// Средний расход топлива (зима), л/100км (Cars.FuelQuotaWinter)
		/// </summary>
		[Description("Средний расход топлива (зима), л/100км (Cars.FuelQuotaWinter)")]
		public decimal FuelQuotaWinter { get { return _FuelQuotaWinter; } set { _FuelQuotaWinter = value; } }
		
		protected decimal _FreezerQuotaSummer;
		/// <summary>
		/// Средний расход топлива для холод.установки (лето), л/100км (Cars.FreezerQuotaSummer)
		/// </summary>
		[Description("Средний расход топлива для холод.установки (лето), л/100км (Cars.FreezerQuotaSummer)")]
		public decimal FreezerQuotaSummer { get { return _FreezerQuotaSummer; } set { _FreezerQuotaSummer = value; } }
		
		protected decimal _FreezerQuotaWinter;
		/// <summary>
		/// Средний расход топлива для холод.установки (зима), л/100км (Cars.FreezerQuotaWinter)
		/// </summary>
		[Description("Средний расход топлива для холод.установки (зима), л/100км (Cars.FreezerQuotaWinter)")]
		public decimal FreezerQuotaWinter { get { return _FreezerQuotaWinter; } set { _FreezerQuotaWinter = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// Сотрудник-водитель - код (Cars.DriverEmployeeID)
		/// </summary>
		[Description("Сотрудник-водитель - код (Cars.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// Сотрудник-водитель - ФИО (Cars.DriverEmployeeID -> Employees.Name)
		/// </summary>
		[Description("Сотрудник-водитель - ФИО (Cars.DriverEmployeeID -> Employees.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected bool? _DriverOperable;
		/// <summary>
		/// Водитель работает (Cars.DriverEmployeeID -> Employees.ID --> Drivers.Operable)?
		/// </summary>
		[Description("Водитель работает (Cars.DriverEmployeeID -> Employees.ID --> Drivers.Operable)?")]
		public bool? DriverOperable { get { return _DriverOperable; } set { _DriverOperable = value; } }

		protected bool? _DriverForGoodsOnly;
		/// <summary>
		/// Водитель - для доставки товара (Cars.DriverEmployeeID -> Employees.ID --> Drivers.ForGoodsOnly)?
		/// </summary>
		[Description("Водитель - для доставки товара (Cars.DriverEmployeeID -> Employees.ID --> Drivers.ForGoodsOnly)?")]
		public bool? DriverForGoodsOnly { get { return _DriverForGoodsOnly; } set { _DriverForGoodsOnly = value; } }

		protected string _DriverCategory;
		/// <summary>
		/// Категория водителя (Cars.DriverEmployeeID -> Employees.ID --> Drivers.DriverCategory)
		/// </summary>
		[Description("Категория водителя (Cars.DriverEmployeeID -> Employees.ID --> Drivers.DriverCategory)")]
		public string DriverCategory { get { return _DriverCategory; } set { _DriverCategory = value; } }

		protected string _DriverLicenceNumber;
		/// <summary>
		/// № водит.удостоверения (Cars.DriverEmployeeID -> Employees.ID --> Drivers.DriverLicenceNumber)
		/// </summary>
		[Description("№ водит.удостоверения (Cars.DriverEmployeeID -> Employees.ID --> Drivers.DriverLicenceNumber)")]
		public string DriverLicenceNumber { get { return _DriverLicenceNumber; } set { _DriverLicenceNumber = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// Зона [умолч.] для сотрудника-водителя - код (Cars.DriverEmployeeID -> Employees.ID --> Drivers.ZoneID)
		/// </summary>
		[Description("Зона [умолч.] для сотрудника-водителя - код (Cars.DriverEmployeeID -> Employees.ID --> Drivers.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// Зона [умолч.] для сотрудника-водителя - наименование (Cars.DriverEmployeeID -> Employees.ID --> Drivers.ZoneID -> Zones.Name)
		/// </summary>
		[Description("Зона [умолч.] для сотрудника-водителя - наименование (Cars.DriverEmployeeID -> Employees.ID --> Drivers.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания к машине (Cars.Note)
		/// </summary>
		[Description("Примечания к машине (Cars.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected bool _Actual;
		/// <summary>
		/// Актуально (Cars.Actual)?
		/// </summary>
		[Description("Актуально (Cars.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код машины в host-системе (Cars.ERPCode)
		/// </summary>
		[Description("Код машины в host-системе (Cars.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterCarNameContext;
		/// <summary>
		/// Фильтр-поле: контекст названия (Cars.Name)
		/// </summary>
		[Description("Фильтр-поле: контекст названия (Cars.Name)")]
		public string FilterCarNameContext { get { return _FilterCarNameContext; } set { _FilterCarNameContext = value; _NeedRequery = true; } }

		protected string _FilterCarNumberContext;
		/// <summary>
		/// Фильтр-поле: контекст гос.номера (Cars.CarNumber)
		/// </summary>
		[Description("Фильтр-поле: контекст гос.номера (Cars.CarNumber)")]
		public string FilterCarNumberContext { get { return _FilterCarNumberContext; } set { _FilterCarNumberContext = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов машин, через запятую (Cars.CarTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов машин, через запятую (Cars.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterCarsClassesList;
		/// <summary>
		/// Фильтр-поле: список кодов классов машин, через запятую (Cars.CarTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов классов машин, через запятую (Cars.CarTypeID)")]
		public string FilterCarsClassesList { get { return _FilterCarsClassesList; } set { _FilterCarsClassesList = value; _NeedRequery = true; } }

		protected bool? _FilterActual;
		/// <summary>
		/// Фильтр-поле: актуальные машины (Cars.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуальные машины (Cars.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

		protected bool? _FilterOperable;
		/// <summary>
		/// Фильтр-поле: машина используется (Cars.Operable)?
		/// </summary>
		[Description("Фильтр-поле: машина используется (Cars.Operable)?")]
		public bool? FilterOperable { get { return _FilterOperable; } set { _FilterOperable = value; _NeedRequery = true; } }

		protected bool? _FilterForGoodsOnly;
		/// <summary>
		/// Фильтр-поле: машина - для доставки товара (Cars.ForGoodsOnly)?
		/// </summary>
		[Description("Фильтр-поле: машина - для доставки товара (Cars.ForGoodsOnly)?")]
		public bool? FilterForGoodsOnly { get { return _FilterForGoodsOnly; } set { _FilterForGoodsOnly = value; _NeedRequery = true; } }

		protected int? _FilterTonnageBeg;
		/// <summary>
		/// Фильтр-поле: грузоподъемность - диапазон от... (Cars.Tonnage)
		/// </summary>
		[Description("Фильтр-поле: грузоподъемность - диапазон от... (Cars.Tonnage)")]
		public int? FilterTonnageBeg { get { return _FilterTonnageBeg; } set { _FilterTonnageBeg = value; _NeedRequery = true; } }

		protected int? _FilterTonnageEnd;
		/// <summary>
		/// Фильтр-поле: грузоподъемность - диапазон до... (Cars.Tonnage)
		/// </summary>
		[Description("Фильтр-поле: грузоподъемность - диапазон от... (Cars.Tonnage)")]
		public int? FilterTonnageEnd { get { return _FilterTonnageEnd; } set { _FilterTonnageEnd = value; _NeedRequery = true; } }
		
		protected bool? _FilterIsPassengerCar;
		/// <summary>
		/// Фильтр-поле: легковая машина (Cars.IsPassengerCar)?
		/// </summary>
		[Description("Фильтр-поле: легковая машина (Cars.IsPassengerCar)?")]
		public bool? FilterIsPassengerCar { get { return _FilterIsPassengerCar; } set { _FilterIsPassengerCar = value; _NeedRequery = true; } }

		protected bool? _FilterIsPostern;
		/// <summary>
		/// Фильтр-поле: машина с задней дверью (Cars.IsPostern)?
		/// </summary>
		[Description("Фильтр-поле: машина с задней дверью (Cars.Postern)?")]
		public bool? FilterIsPostern { get { return _FilterIsPostern; } set { _FilterIsPostern = value; _NeedRequery = true; } }

		protected bool? _FilterIsLoadLift;
		/// <summary>
		/// Фильтр-поле: машина с подъемником (лопатой) (Cars.LoadLift)?
		/// </summary>
		[Description("Фильтр-поле: машина с подъемником (лопатой) (Cars.LoadLift)?")]
		public bool? FilterIsLoadLift { get { return _FilterIsLoadLift; } set { _FilterIsLoadLift = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// Фильтр-поле: разрешение проезда - уровень, не менее (Cars.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Фильтр-поле: разрешение проезда - уровень, не менее (Cars.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableCarsTypes;
		/// <summary>
		/// Таблица типов машин CarsTypes
		/// </summary>
		[Description("Таблица типов машин CarsTypes")]
		public DataTable TableCarsTypes { get { return _TableCarsTypes; } }

		protected DataTable _TableCarsClasses;
		/// <summary>
		/// Таблица классов машин CarsClasses
		/// </summary>
		[Description("Таблица классов машин CarsClasses")]
		public DataTable TableCarsClasses { get { return _TableCarsClasses; } }

		#endregion Таблицы

		// ----------------------------

		public Car()
			: base()
		{
			_MainTableName = "Cars";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}


		#region FillData

		/// <summary>
		/// получение полного списка машин с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_CarsFill @nID, @cIDList, " +
									"@cCarNameContext, " +
									"@cCarNumberContext, " +
									"@cCarsTypesList, " +
									"@cCarsClassesList, " +
									"@bActual, " +
									"@bOperable, @bForGoodsOnly, " +
									"@nTonnageBeg, @nTonnageEnd, " + 
									"@bIsPassengerCar, @bIsPostern, @bIsLoadLift, " +
									"@nPermitLevelValueMin";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_CarsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cCarNameContext", SqlDbType.VarChar);
			if (_FilterCarNameContext != null)
				_oParameter.Value = _FilterCarNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarNumberContext", SqlDbType.VarChar);
			if (_FilterCarNumberContext != null)
				_oParameter.Value = _FilterCarNumberContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarsTypesList", SqlDbType.VarChar);
			if (_FilterCarsTypesList != null)
				_oParameter.Value = _FilterCarsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarsClassesList", SqlDbType.VarChar);
			if (_FilterCarsClassesList != null)
				_oParameter.Value = _FilterCarsClassesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterActual != null)
				_oParameter.Value = _FilterActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bOperable", SqlDbType.Bit);
			if (_FilterOperable != null)
				_oParameter.Value = _FilterOperable;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bForGoodsOnly", SqlDbType.Bit);
			if (_FilterForGoodsOnly != null)
				_oParameter.Value = _FilterForGoodsOnly;
			else
				_oParameter.Value = DBNull.Value;
			
			_oParameter = _oCommand.Parameters.Add("@nTonnageBeg", SqlDbType.Int);
			if (_FilterTonnageBeg != null)
				_oParameter.Value = _FilterTonnageBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nTonnageEnd", SqlDbType.Int);
			if (_FilterTonnageEnd != null)
				_oParameter.Value = _FilterTonnageEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsPassengerCar", SqlDbType.Bit);
			if (_FilterIsPassengerCar != null)
				_oParameter.Value = _FilterIsPassengerCar;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsPostern", SqlDbType.Bit);
			if (_FilterIsPostern != null)
				_oParameter.Value = _FilterIsPostern;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsLoadLift", SqlDbType.Bit);
			if (_FilterIsLoadLift != null)
				_oParameter.Value = _FilterIsLoadLift;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPermitLevelValueMin", SqlDbType.Int);
			if (_FilterPermitLevelValueMin != null)
				_oParameter.Value = _FilterPermitLevelValueMin;
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
				_ErrorStr = "Ошибка при получении списка машин..." + Convert.ToChar(13) + ex.Message;
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

			_FilterCarNameContext = null;
			_FilterCarNumberContext = null;
			_FilterCarsTypesList = null;
			_FilterCarsClassesList = null;
			_FilterActual = null;
			_FilterOperable = null;
			_FilterForGoodsOnly = null;
			_FilterTonnageBeg = null;
			_FilterTonnageEnd = null;
			_FilterIsPassengerCar = null;
			_FilterIsPostern = null;
			_FilterIsLoadLift = null;
			_FilterPermitLevelValueMin = null;
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
					_CarName = _Name = r["Name"].ToString();
					_CarNumber = r["CarNumber"].ToString();
					_TrailerNumber = r["TrailerNumber"].ToString();
                    _CarModel = r["CarModel"].ToString();

					_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
					_CarTypeName = r["CarTypeName"].ToString();
					_CarClassID = Convert.ToInt32(r["CarClassID"]);
					_CarClassName = r["CarClassName"].ToString();

					_ForGoodsOnly = Convert.ToBoolean(r["ForGoodsOnly"]);
					_Operable = Convert.ToBoolean(r["Operable"]);

					_IsPassengerCar = Convert.ToBoolean(r["IsPassengerCar"]);
					_IsPostern = Convert.ToBoolean(r["IsPostern"]);
					_IsLoadLift = Convert.ToBoolean(r["IsLoadLift"]);

					_Tonnage = Convert.ToInt32(r["Tonnage"]);
					_Weight = Convert.ToInt32(r["Weight"]);
					_Volume = Convert.ToDecimal(r["Volume"]);
					_MaxPalletsQnt = Convert.ToDecimal(r["MaxPalletsQnt"]);
					_MaxPointsQnt = Convert.ToInt32(r["MaxPointsQnt"]);
					_MaxDurationMinutes = Convert.ToInt32(r["MaxDurationMinutes"]);
					_MaxDurationHoursMinutes = r["MaxDurationHoursMinutes"].ToString();

					_PermitLevelID = Convert.ToInt32(r["PermitLevelID"]);
					_PermitLevelName = r["PermitLevelName"].ToString();
					_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);

					_AutoFreezer = Convert.ToBoolean(r["AutoFreezer"]);

					if (!Convert.IsDBNull(r["FuelTypeID"]))
						_FuelTypeID = Convert.ToInt32(r["FuelTypeID"]);
					_FuelTypeName = r["FuelTypeName"].ToString();
					_FuelTank = Convert.ToDecimal(r["FuelTank"]);
					_FreezerTank = Convert.ToDecimal(r["FreezerTank"]);
					_FuelQuotaSummer = Convert.ToDecimal(r["FuelQuotaSummer"]);
					_FuelQuotaWinter = Convert.ToDecimal(r["FuelQuotaWinter"]);
					_FreezerQuotaSummer = Convert.ToDecimal(r["FreezerQuotaSummer"]);
					_FreezerQuotaWinter = Convert.ToDecimal(r["FreezerQuotaWinter"]);

					if (!Convert.IsDBNull(r["DriverEmployeeID"]))
						_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
					if (!Convert.IsDBNull(r["DriverID"]))
					{
						// есть запись про водителя 
						_DriverOperable = Convert.ToBoolean(r["DriverOperable"]);
						_DriverForGoodsOnly = Convert.ToBoolean(r["DriverForGoodsOnly"]);
						_DriverCategory = r["DriverCategory"].ToString();
						_DriverLicenceNumber = r["DriverLicenceNumber"].ToString();
						if (!Convert.IsDBNull(r["ZoneID"]))
						{
							_ZoneID = Convert.ToInt32(r["ZoneID"]);
							_ZoneName = r["ZoneName"].ToString();
						}
					}
					if (!Convert.IsDBNull(r["DriverName"]))
						_DriverName = r["DriverName"].ToString();

					_Note = r["Note"].ToString();
					_Actual = Convert.ToBoolean(r["Actual"]);
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о машине...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о машине (нет данных)...";
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

			_CarName = _Name = null;
			_CarNumber = null;
			_TrailerNumber = null;
            _CarModel = null;

			_CarTypeID = 0;
			_CarTypeName = null;
			_CarClassID = 0;
			_CarClassName = null;

			_ForGoodsOnly = false;
			_Operable = false;

			_IsPassengerCar = false;
			_IsPostern = false;
			_IsLoadLift = false;

			_PermitLevelID = 0;
			_PermitLevelName = null;
			_PermitLevelValue = 0;

			_Tonnage = 0;
			_Weight = 0;
			_Volume = 0;
			_MaxPalletsQnt = 0;
			_MaxPointsQnt = 0;
			_MaxDurationMinutes = 0;
			_MaxDurationHoursMinutes = null;

			_AutoFreezer = false;
			_FuelTypeID = null;
			_FuelTypeName = null;
			_FuelTank = 0;
			_FreezerTank = 0;
			_FuelQuotaSummer = 0;
			_FuelQuotaWinter = 0;
			_FreezerQuotaSummer = 0;
			_FreezerQuotaWinter = 0;

			_DriverEmployeeID = null;
			_DriverName = null;
			_DriverOperable = null;
			_DriverForGoodsOnly = null;
			_DriverCategory = null;
			_DriverLicenceNumber = null;
			_ZoneID = null;
			_ZoneName = null;

			_Note = null;
			_Actual = false;
			_ERPCode = null;
		}

		#endregion FillOne

		#region Таблицы

		/// <summary>
		/// получение таблицы типов машин (TableCarsTypes)
		/// </summary>
		public bool FillTableCarsTypes()
		{
			string sqlSelect = 
				"select ID, Name, Actual, ERPCode " + 
					"from CarsTypes " +
					"where 1 = 1 ";
			if (_FilterCarsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterCarsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableCarsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableCarsTypes, "TableCarsTypes");
				_TableCarsTypes.PrimaryKey = new DataColumn[] { _TableCarsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка типов машин..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}


		/// <summary>
		/// получение таблицы классов машин (TableCarsClasses)
		/// </summary>
		public bool FillTableCarsClasses()
		{
			string sqlSelect =
				"select ID, Name, Actual, ERPCode " +
					"from CarsClasses " +
					"where 1 = 1 ";
			if (_FilterCarsClassesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterCarsClassesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_TableCarsClasses = FillReadings(new SqlDataAdapter(_oCommand), _TableCarsClasses, "TableCarsClasses");
				_TableCarsClasses.PrimaryKey = new DataColumn[] { _TableCarsClasses.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка классов машин..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Таблицы

		#region Дерево

		/// <summary>
		/// получение данных о машинах для дерева (TableDataTree)
		/// по типам
		/// </summary>
		public bool FillDataTree(bool bActual)
		{
			string sqlSelect = "select * from .dbo.CarsTree(" + ((bActual) ? "1" : "0") + ") " +
				"order by ParentID, Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableDataTree");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении иерархического списка (дерева) машин..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Дерево

		#region Save

		/// <summary>
		/// сохранение машины (собственной/прочей)
		/// </summary>
		public bool SaveOne()
		{
			string _sqlCommand = "execute up_CarsSave @nCarID output, " +
									"@cCarName, " +
                                    "@cCarNumber, @cTrailerNumber, @cCarModel, " +
									"@nCarTypeID, @nCarClassID, " +
									"@bForGoodsOnly, @bOperable, " +
									"@nTonnage, @nWeight, @nVolume, " +
									"@nMaxPalletsQnt, @nMaxPointsQnt, @nMaxDurationMinutes, " + 
									"@bIsPassengerCar, @bIsPostern, @bIsLoadLift, @nPermitLevelID, " +
									"@bAutoFreezer, " +
									"@nFuelTypeID, " +
									"@nFuelTank, @nFuelQuotaSummer, @nFuelQuotaWinter, " +
									"@nFreezerTank, @nFreezerQuotaSummer, @nFreezerQuotaWinter, " +
									"@nDriverEmployeeID, " +
									"@cDriverName, " +
									"@cNote, " +
									"@bActual, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_CarsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarName", SqlDbType.VarChar);
			_oParameter.Value = _CarName;

			_oParameter = _oCommand.Parameters.Add("@cCarNumber", SqlDbType.VarChar);
			_oParameter.Value = _CarNumber;

            _oParameter = _oCommand.Parameters.Add("@cCarModel", SqlDbType.VarChar);
            _oParameter.Value = _CarModel;

            _oParameter = _oCommand.Parameters.Add("@cTrailerNumber", SqlDbType.VarChar);
			_oParameter.Value = _TrailerNumber;

			_oParameter = _oCommand.Parameters.Add("@nCarTypeID", SqlDbType.Int);
			_oParameter.Value = _CarTypeID;

			_oParameter = _oCommand.Parameters.Add("@nCarClassID", SqlDbType.Int);
			_oParameter.Value = _CarClassID;

			_oParameter = _oCommand.Parameters.Add("@bForGoodsOnly", SqlDbType.Bit);
			_oParameter.Value = _ForGoodsOnly;

			_oParameter = _oCommand.Parameters.Add("@bOperable", SqlDbType.Bit);
			_oParameter.Value = _Operable;
			
			_oParameter = _oCommand.Parameters.Add("@nTonnage", SqlDbType.Int);
			_oParameter.Value = _Tonnage;

			_oParameter = _oCommand.Parameters.Add("@nWeight", SqlDbType.Int);
			_oParameter.Value = _Weight;

			_oParameter = _oCommand.Parameters.Add("@nVolume", SqlDbType.Decimal);
			_oParameter.Precision = 9;
			_oParameter.Scale = 3;
			_oParameter.Value = _Volume;

			_oParameter = _oCommand.Parameters.Add("@nMaxPalletsQnt", SqlDbType.Decimal);
			_oParameter.Precision = 9;
			_oParameter.Scale = 3;
			_oParameter.Value = _MaxPalletsQnt;

			_oParameter = _oCommand.Parameters.Add("@nMaxPointsQnt", SqlDbType.Int);
			_oParameter.Value = _MaxPointsQnt;

			_oParameter = _oCommand.Parameters.Add("@nMaxDurationMinutes", SqlDbType.Int);
			_oParameter.Value = _MaxDurationMinutes;

			_oParameter = _oCommand.Parameters.Add("@bIsPassengerCar", SqlDbType.Bit);
			_oParameter.Value = _IsPassengerCar;

			_oParameter = _oCommand.Parameters.Add("@bIsPostern", SqlDbType.Bit);
			_oParameter.Value = _IsPostern;

			_oParameter = _oCommand.Parameters.Add("@bIsLoadLift", SqlDbType.Bit);
			_oParameter.Value = _IsLoadLift;
			
			_oParameter = _oCommand.Parameters.Add("@nPermitLevelID", SqlDbType.Int);
			_oParameter.Value = _PermitLevelID;

			_oParameter = _oCommand.Parameters.Add("@bAutoFreezer", SqlDbType.Bit);
			_oParameter.Value = _AutoFreezer;

			_oParameter = _oCommand.Parameters.Add("@nFuelTypeID", SqlDbType.Int);
			if (_FuelTypeID.HasValue)
				_oParameter.Value = _FuelTypeID; 
			else
				_oParameter.Value = DBNull.Value; 

			_oParameter = _oCommand.Parameters.Add("@nFuelTank", SqlDbType.Decimal);
			_oParameter.Precision = 4;
			_oParameter.Scale = 1;
			_oParameter.Value = _FuelTank;

			_oParameter = _oCommand.Parameters.Add("@nFuelQuotaSummer", SqlDbType.Decimal);
			_oParameter.Precision = 4;
			_oParameter.Scale = 1;
			_oParameter.Value = _FuelQuotaSummer;

			_oParameter = _oCommand.Parameters.Add("@nFuelQuotaWinter", SqlDbType.Decimal);
			_oParameter.Precision = 4;
			_oParameter.Scale = 1;
			_oParameter.Value = _FuelQuotaWinter;

			_oParameter = _oCommand.Parameters.Add("@nFreezerTank", SqlDbType.Decimal);
			_oParameter.Precision = 4;
			_oParameter.Scale = 1;
			_oParameter.Value = _FreezerTank;

			_oParameter = _oCommand.Parameters.Add("@nFreezerQuotaSummer", SqlDbType.Decimal);
			_oParameter.Precision = 4;
			_oParameter.Scale = 1;
			_oParameter.Value = _FreezerQuotaSummer;

			_oParameter = _oCommand.Parameters.Add("@nFreezerQuotaWinter", SqlDbType.Decimal);
			_oParameter.Precision = 4;
			_oParameter.Scale = 1;
			_oParameter.Value = _FreezerQuotaWinter;

			_oParameter = _oCommand.Parameters.Add("@nDriverEmployeeID", SqlDbType.Int);
			if (_DriverEmployeeID.HasValue)
				_oParameter.Value = _DriverEmployeeID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverName", SqlDbType.VarChar);
			if (_DriverName != null)
				_oParameter.Value = _DriverName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = DBNull.Value;
			
			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			_oParameter.Value = Actual;

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
				_ErrorStr = "Ошибка при сохранении данных о машине...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении данных о машине...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}

				// при создании новой машины - получим код новой записи
				if ((!_ID.HasValue || (int)_ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nCarID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nCarID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save

		#region Delete

		/// <summary>
		/// удаление машины
		/// </summary>
		public bool DeleteOne(int nCarID)
		{
			string _sqlCommand = "execute up_CarsDelete @nCarID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_CarsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			_oParameter.Value = nCarID;

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
				_ErrorStr = "Ошибка при удалении данных о машине...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении данных о машине...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete

	}

#endregion Car

	// -----------------------------------------------------------------------

#region CarType

	public class CarType : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID типов машин (CarsTypes.ID)
		/// </summary>
		[Description("Список кодов ID типов машин (CarsTypes.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		/// <summary>
		/// Наименование типа машины (CarsTypes.Name)
		/// </summary>
		[Description("Наименование типа машины (CarsTypes.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected bool _Actual;
		/// <summary>
		/// Актуально (CarsTypes.Actual)?
		/// </summary>
		[Description("Актуально (CarsTypes.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код типа машины в host-системе (Cars.ERPCode)
		/// </summary>
		[Description("Код машины в host-системе (Cars.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterNameContext;
		/// <summary>
		/// Фильтр-поле: контекст названия (CarsTypes.Name)
		/// </summary>
		[Description("Фильтр-поле: контекст названия (CarsTypes.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		protected bool? _FilterActual;
		/// <summary>
		/// Фильтр-поле: актуальные машины (Cars.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуальные машины (Cars.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

		protected int? _FilterTonnageBeg;
		/// <summary>
		/// Фильтр-поле: грузоподъемность - диапазон от... (CarsTypes.Tonnage)
		/// </summary>
		[Description("Фильтр-поле: грузоподъемность - диапазон от... (CarsTypes.Tonnage)")]
		public int? FilterTonnageBeg { get { return _FilterTonnageBeg; } set { _FilterTonnageBeg = value; _NeedRequery = true; } }

		protected int? _FilterTonnageEnd;
		/// <summary>
		/// Фильтр-поле: грузоподъемность - диапазон до... (CarsTypes.Tonnage)
		/// </summary>
		[Description("Фильтр-поле: грузоподъемность - диапазон от... (CarsTypes.Tonnage)")]
		public int? FilterTonnageEnd { get { return _FilterTonnageEnd; } set { _FilterTonnageEnd = value; _NeedRequery = true; } }

		#endregion Фильтры


		#region FillData

		/// <summary>
		/// получение полного списка типов машин с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_CarsTypesFill @nID, @cIDList, " +
									"@cNameContext, " +
									"@bActual ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_CarsTypesFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterActual != null)
				_oParameter.Value = _FilterActual;
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
				_ErrorStr = "Ошибка при получении списка типов машин..." + Convert.ToChar(13) + ex.Message;
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

			_FilterNameContext = null;
			_FilterActual = null;
			_FilterTonnageBeg = null;
			_FilterTonnageEnd = null;
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
					_Name = r["Name"].ToString();

					_Actual = Convert.ToBoolean(r["Actual"]);
					_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о типе машины...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о типе машины (нет данных)...";
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

			_Name = "";
			_Actual = false;
			_ERPCode = null;
		}

		#endregion FillOne

		#region Save, Delete 

		#region Save

		/// <summary>
		/// сохранение типа машины
		/// </summary>
		public bool SaveOne()
		{
			string _sqlCommand = "execute up_CarsTypesSave @nCarTypeID output, " +
									"@cName, " +
									"@bActual, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_CarsTypesSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTypeID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cName", SqlDbType.VarChar);
			_oParameter.Value = _Name;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			_oParameter.Value = _Actual;

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
				_ErrorStr = "Ошибка при сохранении данных о типе машины...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении данных о типе машины...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}

				// при создании нового типа машины - получим код новой записи
				if ((!_ID.HasValue || (int)_ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nCarTypeID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nCarTypeID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save

		#region Delete

		/// <summary>
		/// удаление типа машины
		/// </summary>
		public bool DeleteOne(int nCarTypeID)
		{
			string _sqlCommand = "execute up_CarsTypesDelete @nCarTypeID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_CarsTypesDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTypeID", SqlDbType.Int);
			_oParameter.Value = nCarTypeID;

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
				_ErrorStr = "Ошибка при удалении типа машины...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении типа машины...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete

		#endregion Save, Delete

	}

#endregion CarType

}
