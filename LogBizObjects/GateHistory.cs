using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Пересечение ворот (въезд-выезд)(GateHistory)
/// </summary>
/// 
namespace LogBizObjects
{
	
#region GateHistory

	public class GateHistory: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID пересечений ворот (GatesHistory.ID)
		/// </summary>
		[Description("Список кодов ID пересечений ворот (GatesHistory.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected DateTime _DateCross;
		/// <summary>
		/// Дата пересечения ворот (GatesHistory.DateCross)
		/// </summary>
		[Description("Дата пересечения ворот (GatesHistory.DateCross)")]
		public DateTime DateCross { get { return _DateCross; } set { _DateCross = value; } }

		protected bool _IsDeparture;
		/// <summary>
		/// Выезд (GatesHistory.IsDeparture)?
		/// </summary>
		[Description("Выезд (GatesHistory.IsDeparture)?")]
		public bool IsDeparture { get { return _IsDeparture; } set { _IsDeparture = value; } }

		protected string _TypeCross;
		/// <summary>
		/// Направление пересечения: въезд/выезд (GatesHistory.IsDeparture -> въезд/выезд)
		/// </summary>
		[Description("Направление пересечения: въезд/выезд (GatesHistory.IsDeparture -> въезд/выезд)")]
		public string TypeCross { get { return _TypeCross; } set { _TypeCross = value; } }

		protected int? _CarID;
		/// <summary>
		/// Машина собственная - код (GatesHistory.CarID)
		/// </summary>
		[Description("Машина собственная - код (GatesHistory.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// Машина - наименование (GatesHistory.CarName)
		/// </summary>
		[Description("Машина - наименование (GatesHistory.CarName)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// Гос.номер машины* (GatesHistory.CarNumber)
		/// </summary>
		[Description("Гос.номер машины* (GatesHistory.CarNumber)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected string _TrailerNumber;
		/// <summary>
		/// Гос.номер прицепа* (GatesHistory.TrailerNumber)
		/// </summary>
		[Description("Гос.номер прицепа* (GatesHistory.TrailerNumber)")]
		public string TrailerNumber { get { return _TrailerNumber; } set { _TrailerNumber = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// Тип машины - код (GatesHistory.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("Тип машины - код (GatesHistory.CarID -> Cars.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// Тип машины - наименование (GatesHistory.CarTypeName)
		/// </summary>
		[Description("Тип машины - наименование (GatesHistory.CarTypeName)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// Сотрудник-водитель - код (GatesHistory.DriverEmployeeID)
		/// </summary>
		[Description("Сотрудник-водитель - код (GatesHistory.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// Водитель - ФИО* (GatesHistory.DriverName)
		/// </summary>
		[Description("Водитель - ФИО* (GatesHistory.DriverName)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected int? _CarWeight;
		/// <summary>
		/// Вес машины при пересечении ворот, кг (GatesHistory.CarWeight)
		/// </summary>
		[Description("Вес машины при пересечении ворот, кг (GatesHistory.CarWeight)")]
		public int? CarWeight { get { return _CarWeight; } set { _CarWeight = value; } }

		protected bool _IsOtherCar;
		/// <summary>
		/// НЕ наша машина (клиентская или арендованная) (GatesHistory.CarID is Null)?
		/// </summary>
		[Description("НЕ наша машина (клиентская или арендованная) (GatesHistory.CarID is Null)?")]
		public bool IsOtherCar { get { return _IsOtherCar; } set { _IsOtherCar = value; } }


		protected int? _TransportPermissionID;
		/// <summary>
		/// Разрешение на пересечение ворот - код (GateHistory.TransportPermissionID -> TransportPermissions.ID)
		/// </summary>
		[Description("Разрешение на пересечение ворот - код (GateHistory.TransportPermissionID -> TransportPermissions.ID)")]
		public int? TransportPermissionID { get { return _TransportPermissionID; } set { _TransportPermissionID = value; } }

		protected int? _WayBillID;
		/// <summary>
		/// Путевой лист - код (для собственных машин) (GatesHistory.WayBillID)
		/// </summary>
		[Description("Путевой лист - код (для собственных машин) (GatesHistory.WayBillID)")]
		public int? WayBillID { get { return _WayBillID; } set { _WayBillID = value; } }

		protected int? _PassID;
		/// <summary>
		/// Пропуск - код (для прочих машин) (GatesHistory.PassID)
		/// </summary>
		[Description("Пропуск - код (для прочих машин) (GatesHistory.PassID)")]
		public int? PassID { get { return _PassID; } set { _PassID = value; } }

		protected int? _TripID;
		/// <summary>
		/// Рейс - код (GatesHistory.TripID)
		/// </summary>
		[Description("Рейс - код (GatesHistory.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected string _OtherReason;
		/// <summary>
		/// Прочая цель поездки (GatesHistory.OtherReason)
		/// </summary>
		[Description("Прочая цель поездки (GatesHistory.OtherReason)")]
		public string OtherReason { get { return _OtherReason; } set { _OtherReason = value; } }

		protected string _Reason;
		/// <summary>
		/// Цель поездки (GatesHistory.WayBillID, PassID, TripID, OtherReason)
		/// </summary>
		[Description("Цель поездки (GatesHistory.WayBillID, PassID, TripID, OtherReason)")]
		public string Reason { get { return _Reason; } set { _Reason = value; } }

		protected DateTime? _DateArrivalFact;
		/// <summary>
		/// Дата-время прибытия машины - факт (GatesHistory -> Trips.DateArrivalFact, Passes.DateArrivalFact)
		/// </summary>
		[Description("Дата-время прибытия машины - факт (GatesHistory -> Trips.DateArrivalFact, Passes.DateArrivalFact)")]
		public DateTime? DateArrivalFact { get { return _DateArrivalFact; } set { _DateArrivalFact = value; } }

		protected DateTime? _DateDepartureFact;
		/// <summary>
		/// Дата-время выхода машины - факт (GatesHistory -> Trips.DateDepartureFact, Passes.DateDepartureFact)
		/// </summary>
		[Description("Дата-время выхода машины - факт (GatesHistory -> Trips.DateDepartureFact, Passes.DateDepartureFact)")]
		public DateTime? DateDepartureFact { get { return _DateDepartureFact; } set { _DateDepartureFact = value; } }

		protected int? _DurationMinutesFact;
		/// <summary>
		/// Длительность нахождения на территории, мин. - факт (GatesHistory.DurationMinutesFact()*)
		/// </summary>
		[Description("Длительность нахождения на территории, мин. - факт (GatesHistory.DurationMinutesFact()*)")]
		public int? DurationMinutesFact { get { return _DurationMinutesFact; } set { _DurationMinutesFact = value; } }

		protected string _DurationHoursMinutesFact;
		/// <summary>
		/// Длительность нахождения на территории, час:мин - факт (GatesHistory.DurationHoursMinutesFact())
		/// </summary>
		[Description("Длительность нахождения на территории, час:мин - факт (GatesHistory.DurationHoursMinutesFact())")]
		public string DurationHoursMinutesFact { get { return _DurationHoursMinutesFact; } set { _DurationHoursMinutesFact = value; } }

		protected int? _UserID;
		/// <summary>
		/// Пользователь - код (Passes.UserID)
		/// </summary>
		[Description("Пользователь - код (Passes.UserID)")]
		public int? UserID { get { return _UserID; } set { _UserID = value; } }

		protected string _UserName;
		/// <summary>
		/// Пользователь - ФИО (Passes.UserID -> _Users.Name)
		/// </summary>
		[Description("Пользователь - ФИО (Passes.UserID -> _Users.Name)")]
		public string UserName { get { return _UserName; } set { _UserName = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания к пересечению ворот (GatesHistory.Note)
		/// </summary>
		[Description("Примечания к пересечению ворот (GatesHistory.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код пересечения ворот в host-системе (GatesHistory.ERPCode)
		/// </summary>
		[Description("Код пересечения ворот в host-системе (GatesHistory.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата пересечения ворот - начальная дата периода (GatesHistory.DateCross)
		/// </summary>
		[Description("Фильтр-поле: дата пересечения ворот - начальная дата периода (GatesHistory.DateCross)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата пересечения ворот - конечная дата периода (GatesHistory.DateCross)
		/// </summary>
		[Description("Фильтр-поле: дата пересечения ворот - конечная дата периода (GatesHistory.DateCross)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterTimeBeg;
		/// <summary>
		/// Фильтр-поле: время пересечения ворот - начальное время периода (GatesHistory.DateCross)
		/// </summary>
		[Description("Фильтр-поле: время пересечения ворот - начальное время периода (GatesHistory.DateCross)")]
		public string FilterTimeBeg { get { return _FilterTimeBeg; } set { _FilterTimeBeg = value; _NeedRequery = true; } }

		protected string _FilterTimeEnd;
		/// <summary>
		/// Фильтр-поле: время пересечения ворот - конечное время периода (GatesHistory.DateCross)
		/// </summary>
		[Description("Фильтр-поле: время пересечения ворот - конечное время периода (GatesHistory.DateCross)")]
		public string FilterTimeEnd { get { return _FilterTimeEnd; } set { _FilterTimeEnd = value; _NeedRequery = true; } }

		protected bool? _FilterIsDeparture;
		/// <summary>
		/// Выезд (GatesHistory.IsDeparture)?
		/// </summary>
		[Description("Выезд (GatesHistory.IsDeparture)?")]
		public bool? FilterIsDeparture { get { return _FilterIsDeparture; } set { _FilterIsDeparture = value; _NeedRequery = true; } }

		protected bool? _FilterIsOtherCar;
		/// <summary>
		/// Не наша машина (клиентская/арендованная) (GatesHistory.CarID is Null)?
		/// </summary>
		[Description("Не наша машина (клиентская/арендованная) (GatesHistory.CarID is Null)?")]
		public bool? FilterIsOtherCar { get { return _FilterIsOtherCar; } set { _FilterIsOtherCar = value; _NeedRequery = true; } }

		protected string _FilterCarsList;
		/// <summary>
		/// Фильтр-поле: список кодов машин, через запятую (GatesHistory.CarID)
		/// </summary>
		[Description("Фильтр-поле: список кодов машин, через запятую (GatesHistory.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов машин, через запятую (GatesHistory.CarTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов машин, через запятую (GatesHistory.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterCarNameContext;
		/// <summary>
		/// Фильтр-поле: контекст наименования машины (GatesHistory.CarName)
		/// </summary>
		[Description("Фильтр-поле: контекст наименования машины (GatesHistory.CarName)")]
		public string FilterCarNameContext { get { return _FilterCarNameContext; } set { _FilterCarNameContext = value; _NeedRequery = true; } }

		protected string _FilterCarNumberContext;
		/// <summary>
		/// Фильтр-поле: контекст гос.номера машины (GatesHistory.CarNumber)
		/// </summary>
		[Description("Фильтр-поле: контекст гос.номера машины (GatesHistory.CarNumber)")]
		public string FilterCarNumberContext { get { return _FilterCarNumberContext; } set { _FilterCarNumberContext = value; _NeedRequery = true; } }

		protected string _FilterCarTypeNameContext;
		/// <summary>
		/// Фильтр-поле: контекст наименования типа машины (GatesHistory.CarTypeName)
		/// </summary>
		[Description("Фильтр-поле: контекст наименования типа машины (GatesHistory.CarTypeName)")]
		public string FilterCarTypeNameContext { get { return _FilterCarTypeNameContext; } set { _FilterCarTypeNameContext = value; _NeedRequery = true; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// Фильтр-поле: список кодов сотрудников-водителей, через запятую (GatesHistory.DriverEmployeeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов сотрудников-водителей, через запятую (GatesHistory.DriverEmployeeID)")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterDriverNameContext;
		/// <summary>
		/// Фильтр-поле: контекст ФИО водителя (GatesHistory.DriverName)
		/// </summary>
		[Description("Фильтр-поле: контекст ФИО водителя (GatesHistory.DriverName)")]
		public string FilterDriverNameContext { get { return _FilterDriverNameContext; } set { _FilterDriverNameContext = value; _NeedRequery = true; } }

		protected string _FilterReasonContext;
		/// <summary>
		/// Фильтр-поле: контекст цели поездки (GatesHistory.Reason*)
		/// </summary>
		[Description("Фильтр-поле: контекст цели поездки (GatesHistory.Reason*)")]
		public string FilterReasonContext { get { return _FilterReasonContext; } set { _FilterReasonContext = value; _NeedRequery = true; } }

		protected bool? _FilterDateArrivalFactFull;
		/// <summary>
		/// Фильтр-поле: заполнена дата-время прибытия (GatesHistory.DateArrivalFact* is not Null)?
		/// </summary>
		[Description("Фильтр-поле: заполнена дата-время прибытия (GatesHistory.DateArrivalFact* is not Null)?")]
		public bool? FilterDateArrivalFactFull { get { return _FilterDateArrivalFactFull; } set { _FilterDateArrivalFactFull = value; _NeedRequery = true; } }

		protected bool? _FilterDateDepartureFactFull;
		/// <summary>
		/// Фильтр-поле: заполнена дата-время выхода (GatesHistory.DateDepartureFact)?
		/// </summary>
		[Description("Фильтр-поле: заполнена дата-время выхода (GatesHistory.DateDepartureFact)?")]
		public bool? FilterDateDepartureFactFull { get { return _FilterDateDepartureFactFull; } set { _FilterDateDepartureFactFull = value; _NeedRequery = true; } }

		protected string _FilterTransportPermissionsList;
		/// <summary>
		/// Фильтр-поле: список кодов разрешений на пересечение ворот, через запятую (GateHistory.TransportPermissionID -> TransportPermissions.ID)
		/// </summary>
		[Description("Фильтр-поле: список кодов разрешений на пересечение ворот, через запятую (GateHistory.TransportPermissionID -> TransportPermissions.ID)")]
		public string FilterTransportPermissionsList { get { return _FilterTransportPermissionsList; } set { _FilterTransportPermissionsList = value; _NeedRequery = true; } }

		protected string _FilterWayBillsList;
		/// <summary>
		/// Фильтр-поле: список кодов путевых листов, через запятую (GatesHistory.WayBillID)
		/// </summary>
		[Description("Фильтр-поле: список кодов путевых листов, через запятую (GatesHistory.WayBillID)")]
		public string FilterWayBillsList { get { return _FilterWayBillsList; } set { _FilterWayBillsList = value; _NeedRequery = true; } }

		protected string _FilterPassesList;
		/// <summary>
		/// Фильтр-поле: список кодов пропусков, через запятую (GatesHistory.PassID)
		/// </summary>
		[Description("Фильтр-поле: список кодов пропусков, через запятую (GatesHistory.PassID)")]
		public string FilterPassesList { get { return _FilterPassesList; } set { _FilterPassesList = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// Фильтр-поле: список кодов рейсов, через запятую (GatesHistory.TripID)
		/// </summary>
		[Description("Фильтр-поле: список кодов рейсов, через запятую (GatesHistory.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableSourceData;
		/// <summary>
		/// Таблица исходных данных для пересечения ворот: путевые листы (для наших машин) + пропуска (для ненаших машин)
		/// </summary>
		[Description("Таблица исходных данных для пересечения ворот: путевые листы + пропуска ")]
		public DataTable TableSourceData { get { return _TableSourceData; } }

		#endregion Таблицы

		// ----------------------------

		public GateHistory()
			: base()
		{
			_MainTableName = "GatesHistory";
			_ColumnID = "ID";
			_ColumnName = "DateCross";
		}


		#region FillData

		/// <summary>
		/// получение полного списка пересечений ворот с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_GatesHistoryFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@cTimeBeg, @cTimeEnd, " +
									"@bIsDeparture, " +
									"@bIsOtherCar, " +
									"@cCarsList, " +
									"@cCarsTypesList, " +
									"@cCarNameContext, @cCarNumberContext, " +
									"@cCarTypeNameContext, " + 
									"@cDriversEmployeesList, " + 
									"@cDriverNameContext, " + 
									"@cReasonContext, " +
									"@bDateArrivalFactFull, @bDateDepartureFactFull, " +
									"@cTransportPermissionsList, " + 
									"@cWayBillsList, " +
									"@cPassesList, " +
									"@cTripsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GatesHistoryFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cTimeBeg", SqlDbType.VarChar);
			if (_FilterTimeBeg != null)
				_oParameter.Value = _FilterTimeBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTimeEnd", SqlDbType.VarChar);
			if (_FilterTimeEnd != null)
				_oParameter.Value = _FilterTimeEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsDeparture", SqlDbType.Bit);
			if (_FilterIsDeparture.HasValue)
				_oParameter.Value = _FilterIsDeparture;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOtherCar", SqlDbType.Bit);
			if (_FilterIsOtherCar.HasValue)
				_oParameter.Value = _FilterIsOtherCar;
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

			_oParameter = _oCommand.Parameters.Add("@cCarTypeNameContext", SqlDbType.VarChar);
			if (_FilterCarTypeNameContext != null)
				_oParameter.Value = _FilterCarTypeNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriversEmployeesList", SqlDbType.VarChar);
			if (_FilterDriversEmployeesList != null)
				_oParameter.Value = _FilterDriversEmployeesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverNameContext", SqlDbType.VarChar);
			if (_FilterDriverNameContext != null)
				_oParameter.Value = _FilterDriverNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cReasonContext", SqlDbType.VarChar);
			if (_FilterReasonContext != null)
				_oParameter.Value = _FilterReasonContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDateArrivalFactFull", SqlDbType.Bit);
			if (_FilterDateArrivalFactFull != null)
				_oParameter.Value = _FilterDateArrivalFactFull;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDateDepartureFactFull", SqlDbType.Bit);
			if (_FilterDateDepartureFactFull != null)
				_oParameter.Value = _FilterDateDepartureFactFull;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTransportPermissionsList", SqlDbType.VarChar);
			if (_FilterTransportPermissionsList != null)
				_oParameter.Value = _FilterTransportPermissionsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cWayBillsList", SqlDbType.VarChar);
			if (_FilterWayBillsList != null)
				_oParameter.Value = _FilterWayBillsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPassesList", SqlDbType.VarChar);
			if (_FilterPassesList != null)
				_oParameter.Value = _FilterPassesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
			if (_FilterTripsList != null)
				_oParameter.Value = _FilterTripsList;
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
				_ErrorStr = "Ошибка при получении списка пересечений ворот..." + Convert.ToChar(13) + ex.Message;
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
			_FilterTimeBeg = null;
			_FilterTimeEnd = null;
			_FilterCarsList = null;
			_FilterCarsTypesList = null;
			_FilterCarNameContext = null;
			_FilterCarNumberContext = null;
			_FilterCarTypeNameContext = null;
			_FilterDriversEmployeesList = null;
			_FilterDriverNameContext = null; 
			_FilterReasonContext = null;
			_FilterDateArrivalFactFull = null;
			_FilterDateDepartureFactFull = null;
			_FilterTransportPermissionsList = null; 
			_FilterWayBillsList = null;
			_FilterPassesList = null;
			_FilterTripsList = null;
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
					_DateCross = Convert.ToDateTime(r["DateCross"]);

					_IsDeparture = Convert.ToBoolean(r["IsDeparture"]);
					_TypeCross = r["TypeCross"].ToString();

					if (!Convert.IsDBNull(r["CarID"]))
						_CarID = Convert.ToInt32(r["CarID"]);
					_CarName = r["CarName"].ToString();
					_CarNumber = r["CarNumber"].ToString();
					_TrailerNumber = r["TrailerNumber"].ToString();
					if (!Convert.IsDBNull(r["CarTypeID"]))
						_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
					_CarTypeName = r["CarTypeName"].ToString();

					if (!Convert.IsDBNull(r["CarWeight"]))
						_CarWeight = Convert.ToInt32(r["CarWeight"]);

					if (!Convert.IsDBNull(r["IsOtherCar"]))
						_IsOtherCar = Convert.ToBoolean(r["IsOtherCar"]);

					if (!Convert.IsDBNull(r["DriverEmployeeID"]))
						_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
					_DriverName = r["DriverName"].ToString();

					if (!Convert.IsDBNull(r["TransportPermissionID"]))
						_TransportPermissionID = Convert.ToInt32(r["TransportPermissionID"]);
					if (!Convert.IsDBNull(r["WayBillID"]))
						_WayBillID = Convert.ToInt32(r["WayBillID"]);
					if (!Convert.IsDBNull(r["PassID"]))
						_PassID = Convert.ToInt32(r["PassID"]);
					if (!Convert.IsDBNull(r["TripID"]))
						_TripID = Convert.ToInt32(r["TripID"]);
					_OtherReason = r["OtherReason"].ToString();
					_Reason = r["Reason"].ToString();

					if (!Convert.IsDBNull(r["DateArrivalFact"]))
					{
						_DateArrivalFact = Convert.ToDateTime(r["DateArrivalFact"]);
					}
					if (!Convert.IsDBNull(r["DateDepartureFact"]))
					{
						_DateDepartureFact = Convert.ToDateTime(r["DateDepartureFact"]);
					}
					if (!Convert.IsDBNull(r["DurationMinutesFact"]))
					{
						_DurationMinutesFact = Convert.ToInt32(r["DurationMinutesFact"]);
					}
					_DurationHoursMinutesFact = r["DurationHoursMinutesFact"].ToString();

					if (!Convert.IsDBNull(r["UserID"]))
					{
						_UserID = Convert.ToInt32(r["UserID"]);
					}
					_UserName = r["UserName"].ToString();

					_Note = r["Note"].ToString();
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о пересечении ворот...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о пересечении ворот (нет данных)...";
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

			_DateCross = DateTime.Now.Date;
			_IsDeparture = false;
			_TypeCross = null;
			
			_CarID = null;
			_CarName = null;
			_CarNumber = null;
			_TrailerNumber = null;
			_CarTypeID = null;
			_CarTypeName = null;
			_CarWeight = null;

			_IsOtherCar = false;

			_DriverEmployeeID = null;
			_DriverName = null;

			_TransportPermissionID = null;
			_WayBillID = null;
			_PassID = null;
			_TripID = null;
			_OtherReason = null;
			_Reason = null;

			_DateArrivalFact = null;
			_DateDepartureFact = null;
			_DurationMinutesFact = null;
			_DurationHoursMinutesFact = null;

			_UserID = 0;
			_UserName = null;

			_Note = null;
			_ERPCode = null; 
		}

		#endregion FillOne

		#region SourceDataFill (путевые листы + пропуска)

		/// <summary>
		/// получение полного списка пересечений ворот с дополнительными сведениями в MainTable
		/// </summary>
		public bool FillSourceData(DateTime? dDate, bool? bArrival, bool? bFinishedAlso)
		{
			return (FillSourceData(null, null, dDate, bArrival, bFinishedAlso));
		}

		public bool FillSourceData(int? nGateHistoryID, int? nTransportPermissionID,
			DateTime? dDate, bool? bArrival, bool? bFinishedAlso)
		{
			string sqlSelect = "execute up_GatesHistorySourceDataFill @nGateHistoryID, " +
									"@nTransportPermissionID, " +
									"@dDate, " +
									"@bArrival, @bFinishedAlso";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GatesHistorySourceDataFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGateHistoryID", SqlDbType.Int);
			if (nGateHistoryID.HasValue )
				_oParameter.Value = nGateHistoryID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nTransportPermissionID", SqlDbType.Int);
			if (nTransportPermissionID.HasValue)
				_oParameter.Value = nTransportPermissionID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			if (dDate.HasValue)
				_oParameter.Value = dDate;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bArrival", SqlDbType.Bit);
			if (bArrival.HasValue)
				_oParameter.Value = bArrival;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bFinishedAlso", SqlDbType.Bit);
			if (bFinishedAlso.HasValue)
				_oParameter.Value = bFinishedAlso;
			else
				_oParameter.Value = DBNull.Value;
	
			#endregion

			try
			{
				_TableSourceData = FillReadings(new SqlDataAdapter(_oCommand), _TableSourceData, "TableSourceData");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка данных о разрешениях пересечения ворот (путевые листы и пропуска)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion SourceDataFill (путевые листы + пропуска)

		#region Save, Delete

		/// <summary>
		/// сохранение факта пересечения ворот
		/// </summary>
		public bool Save(int? nUserID)
		{
			string _sqlCommand = "execute up_GatesHistorySave @nGateHistoryID output, " +
					"@dDateCross, @bIsDeparture, " + 
					"@nCarID, @nDriverEmployeeID, " +
					"@cCarName, @cCarTypeName, @cCarNumber, @cTrailerNumber, @cDriverName, " +
					"@nCarWeight, " + 
					"@nTransportPermissionID, " + 
					"@nWayBillID, @nPassID, @nTripID, " +
					"@cOtherReason, " +
					"@cNote, " +
					"@nUserID, " + 
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_GatesHistorySave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGateHistoryID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDateCross", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateCross;

			_oParameter = _oCommand.Parameters.Add("@bIsDeparture", SqlDbType.Bit);
			_oParameter.Value = _IsDeparture;

			_oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			if (_CarID.HasValue)
				_oParameter.Value = _CarID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nDriverEmployeeID", SqlDbType.Int);
			if (_DriverEmployeeID.HasValue)
				_oParameter.Value = _DriverEmployeeID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarName", SqlDbType.VarChar);
			if (_CarName != null)
				_oParameter.Value = _CarName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarTypeName", SqlDbType.VarChar);
			if (_CarTypeName != null)
				_oParameter.Value = _CarTypeName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarNumber", SqlDbType.VarChar);
			if (_CarNumber != null)
				_oParameter.Value = _CarNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTrailerNumber", SqlDbType.VarChar);
			if (_TrailerNumber != null)
				_oParameter.Value = _TrailerNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverName", SqlDbType.VarChar);
			if (_DriverName != null)
				_oParameter.Value = _DriverName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCarWeight", SqlDbType.Int);
			if (_CarWeight.HasValue)
				_oParameter.Value = _CarWeight;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nTransportPermissionID", SqlDbType.Int);
			if (_TransportPermissionID.HasValue)
				_oParameter.Value = _TransportPermissionID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nWayBillID", SqlDbType.Int);
			if (_WayBillID.HasValue)
				 _oParameter.Value = _WayBillID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			if (_PassID.HasValue)
				_oParameter.Value = _PassID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			if (_TripID.HasValue)
				_oParameter.Value = _TripID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOtherReason", SqlDbType.VarChar);
			if (_OtherReason != null)
				_oParameter.Value = _OtherReason;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			if (nUserID.HasValue)
				_oParameter.Value = nUserID;
			else
				_oParameter.Value = DBNull.Value;

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
				_ErrorStr = "Ошибка при попытке сохранения факта пересесения ворот...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении факта пересесения ворот...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании нового факта пересечения ворот - получим его код
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nGateHistoryID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nGateHistoryID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// удаление факта пересечения ворот
		/// </summary>
		public bool Delete(int nGateHistoryID)
		{
			string _sqlCommand = "execute up_GatesHistoryDelete @nGateHistoryID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_GatesHistoryDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nGateHistoryID", SqlDbType.Int);
			_oParameter.Value = nGateHistoryID;

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
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке удаления факта пересесения ворот...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении факта пересесения ворот...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

	}

#endregion GateHistory

}
