using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Пропуск (Pass)
/// </summary>
/// 
namespace LogBizObjects
{

#region Pass

	public class Pass: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID пропусков (Passes.ID)
		/// </summary>
		[Description("Список кодов ID пропусков (Passes.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected DateTime _DatePass;
		/// <summary>
		/// Дата пропуска (Passes.DatePass)
		/// </summary>
		[Description("Дата пропуска (Passes.DatePass)")]
		public DateTime DatePass { get { return _DatePass; } set { _DatePass = value; } }

		protected bool _IsPermitted;
		/// <summary>
		/// Разрешено очередное пересечение ворот (Passes.IsPermitted)?
		/// </summary>
		[Description("Разрешено очередное пересечение ворот (Passes.IsPermitted)?")]
		public bool IsPermitted { get { return _IsPermitted; } set { _IsPermitted = value; } }

		protected bool _IsClosed;
		/// <summary>
		/// Пропуск закрыт (Passes.IsClosed)?
		/// </summary>
		[Description("Пропуск закрыт (Passes.IsClosed)?")]
		public bool IsClosed { get { return _IsClosed; } set { _IsClosed = value; } }

		protected string _CarName;
		/// <summary>
		/// Машина прочая* - наименование (Passes.CarName)
		/// </summary>
		[Description("Машина прочая* - наименование (Passes.CarName)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// Гос.номер машины (Passes.CarNumber)
		/// </summary>
		[Description("Гос.номер машины (Passes.CarNumber)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected string _TrailerNumber;
		/// <summary>
		/// Гос.номер прицепа (Passes.TrailerNumber)
		/// </summary>
		[Description("Гос.номер прицепа (Passes.TrailerNumber)")]
		public string TrailerNumber { get { return _TrailerNumber; } set { _TrailerNumber = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// Тип машины - наименование (Passes.CarTypeName)
		/// </summary>
		[Description("Тип машины - наименование (Passes.CarTypeName)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected string _DriverName;
		/// <summary>
		/// Водитель - ФИО (Passes.DriverName)
		/// </summary>
		[Description("Водитель - ФИО (Passes.DriverName)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected string _DriverDocument;
		/// <summary>
		/// Водитель - документ (Passes.DriverDocument)
		/// </summary>
		[Description("Водитель - документ (Passes.DriverDocument)")]
		public string DriverDocument { get { return _DriverDocument; } set { _DriverDocument = value; } }

		protected string _DriverPhone;
		/// <summary>
		/// Водитель - телефон (Passes.DriverPhone)
		/// </summary>
		[Description("Водитель - телефон (Passes.DriverPhone)")]
		public string DriverPhone { get { return _DriverPhone; } set { _DriverPhone = value; } }

		protected string _Reason;
		/// <summary>
		/// Цель поездки (Passes.Reason)
		/// </summary>
		[Description("Цель поездки (Passes.Reason)")]
		public string Reason { get { return _Reason; } set { _Reason = value; } }

		protected DateTime? _DateBegPlan;
		/// <summary>
		/// Дата-время прибытия машины - план (Passes.DateBegPlan)
		/// </summary>
		[Description("Дата-время прибытия машины - план (Passes.DateBegPlan)")]
		public DateTime? DateBegPlan { get { return _DateBegPlan; } set { _DateBegPlan = value; } }

		protected DateTime? _DateEndPlan;
		/// <summary>
		/// Дата-время выхода машины - план (Passes.DateEndPlan)
		/// </summary>
		[Description("Дата-время выхода машины - план (Passes.DateEndPlan)")]
		public DateTime? DateEndPlan { get { return _DateEndPlan; } set { _DateEndPlan = value; } }

		protected int? _DurationMinutesPlan;
		/// <summary>
		/// Длительность действия пропуска, мин. - план (Passes.DurationMinutesPlan())
		/// </summary>
		[Description("Длительность действия пропуска, мин. - план (Passes.DurationMinutesPlan())")]
		public int? DurationMinutesPlan { get { return _DurationMinutesPlan; } set { _DurationMinutesPlan = value; } }

		protected string _DurationHoursMinutesPlan;
		/// <summary>
		/// Длительность действия пропуска, час:мин - план (Passes.DurationHoursMinutesPlan())
		/// </summary>
		[Description("Длительность действия пропуска, час:мин - план (Passes.DurationHoursMinutesPlan())")]
		public string DurationHoursMinutesPlan { get { return _DurationHoursMinutesPlan; } set { _DurationHoursMinutesPlan = value; } }

		protected DateTime? _DateBeg;
		/// <summary>
		/// Дата-время прибытия машины - факт (Passes.DateBeg)
		/// </summary>
		[Description("Дата-время прибытия машины - факт (Passes.DateBeg)")]
		public DateTime? DateBeg { get { return _DateBeg; } set { _DateBeg = value; } }

		protected DateTime? _DateEnd;
		/// <summary>
		/// Дата-время выхода машины - факт (Passes.DateEnd)
		/// </summary>
		[Description("Дата-время выхода машины - факт (Passes.DateEnd)")]
		public DateTime? DateEnd { get { return _DateEnd; } set { _DateEnd = value; } }

		protected int? _DurationMinutes;
		/// <summary>
		/// Длительность действия пропуска, мин. - факт (Passes.DurationMinutes())
		/// </summary>
		[Description("Длительность действия пропуска, мин. - факт (Passes.DurationMinutes())")]
		public int? DurationMinutes { get { return _DurationMinutes; } set { _DurationMinutes = value; } }

		protected string _DurationHoursMinutes;
		/// <summary>
		/// Длительность действия пропуска, час:мин - факт (Passes.DurationHoursMinutes())
		/// </summary>
		[Description("Длительность действия пропуска, час:мин - факт (Passes.DurationHoursMinutes())")]
		public string DurationHoursMinutes { get { return _DurationHoursMinutes; } set { _DurationHoursMinutes = value; } }


		protected decimal _Brutto;
		/// <summary>
		/// Вес перевозимого товара - брутто, кг (Passes.Brutto)
		/// </summary>
		[Description("Вес перевозимого товара - брутто, кг (Passes.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected decimal _PalletsQnt;
		/// <summary>
		/// Количество паллет (Passes.PalletsQnt)
		/// </summary>
		[Description("Количество паллет (Passes.PalletsQnt)")]
		public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }


		protected int? _PartnerID;
		/// <summary>
		/// Клиент - код (Passes.PartnerID)
		/// </summary>
		[Description("Клиент - код (Passes.PartnerID)")]
		public int? PartnerID { get { return _PartnerID; } set { _PartnerID = value; } }

		protected string _PartnerName;
		/// <summary>
		/// Клиент - наименование (Passes.PartnerID -> Partners.Name)
		/// </summary>
		[Description("Клиент - наименование (Passes.PartnerID -> Partners.Name)")]
		public string PartnerName { get { return _PartnerName; } set { _PartnerName = value; } }

		protected int? _CarrierPartnerID;
		/// <summary>
		/// Перевозчик - код (Passes.CarrierPartnerID)
		/// </summary>
		[Description("Перевозчик - код (Passes.CarrierPartnerID)")]
		public int? CarrierPartnerID { get { return _CarrierPartnerID; } set { _CarrierPartnerID = value; } }

		protected string _CarrierPartnerName;
		/// <summary>
		/// Перевозчик - наименование (Passes.CarrierPartnerID -> Partners.Name)
		/// </summary>
		[Description("Перевозчик - наименование (Passes.CarrierPartnerID -> Partners.Name)")]
		public string CarrierPartnerName { get { return _CarrierPartnerName; } set { _CarrierPartnerName = value; } }

		protected int? _UserCreateID;
		/// <summary>
		/// Пользователь, оформивший пропуск - код (Passes.UserCreateID)
		/// </summary>
		[Description("Пользователь, оформивший пропуск - код (Passes.UserCreateID)")]
		public int? UserCreateID { get { return _UserCreateID; } set { _UserCreateID = value; } }

		protected string _UserCreateName;
		/// <summary>
		/// Пользователь, оформивший пропуск - ФИО (Passes.UserCreateID -> _Users.Name)
		/// </summary>
		[Description("Пользователь, оформивший пропуск - ФИО (Passes.UserCreateID -> _Users.Name)")]
		public string UserCreateName { get { return _UserCreateName; } set { _UserCreateName = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// Дата-время оформления пропуска (Createes.DateCreate)
		/// </summary>
		[Description("Дата оформления пропуска (Createes.DateCreate)")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }
		

		protected int? _UserConfirmID;
		/// <summary>
		/// Пользователь, утвердивший пропуск - код (Passes.UserConfirmID)
		/// </summary>
		[Description("Пользователь, утвердивший пропуск - код (Passes.UserConfirmID)")]
		public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

		protected string _UserConfirmName;
		/// <summary>
		/// Пользователь, утвердивший пропуск - ФИО (Passes.UserConfirmID -> _Users.Name)
		/// </summary>
		[Description("Пользователь, утвердивший пропуск - ФИО (Passes.UserConfirmID -> _Users.Name)")]
		public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }

		protected DateTime? _DateConfirm;
		/// <summary>
		/// Дата-время утверждения пропуска (Passes.DateConfirm)
		/// </summary>
		[Description("Дата утверждения пропуска (Passes.DateConfirm)")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// Пропуск утвержден (Passes.DateConfirm is not Null)?
		/// </summary>
		[Description("Пропуск утвержден (Passes.DateConfirm is not Null)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected string _Note;
		/// <summary>
		/// Примечания к пропуску (Passes.Note)
		/// </summary>
		[Description("Примечания к пропуску (Passes.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected int _TransportPermissionID;
		/// <summary>
		/// Разрешение на пересечение ворот - код (Passes.ID -> TransportPermissions.PassID)
		/// </summary>
		[Description("Разрешение на пересечение ворот - код (Passes.ID -> TransportPermissions.PassID)")]
		public int TransportPermissionID { get { return _TransportPermissionID; } set { _TransportPermissionID = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код пропуска в host-системе (Passes.ERPCode)
		/// </summary>
		[Description("Код пропуска в host-системе (Passes.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата пропуска - начальная дата периода (Passes.DatePass)
		/// </summary>
		[Description("Фильтр-поле: дата пропуска - начальная дата периода (Passes.DatePass)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата пропуска - конечная дата периода (Passes.DatePass)
		/// </summary>
		[Description("Фильтр-поле: дата пропуска - конечная дата периода (Passes.DatePass)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected bool? _FilterIsPermitted;
		/// <summary>
		/// Фильтр-поле: разрешено очередное пересечение ворот (Passes.IsPermitted)?
		/// </summary>
		[Description("Фильтр-поле: разрешено очередное пересечение ворот (Passes.IsPermitted?")]
		public bool? FilterIsPermitted { get { return _FilterIsPermitted; } set { _FilterIsPermitted = value; _NeedRequery = true; } }

		protected string _FilterCarTypeNameContext;
		/// <summary>
		/// Фильтр-поле: контекст наименования типа машины (Passes.CarTypeName)
		/// </summary>
		[Description("Фильтр-поле: контекст наименования типа машины (Passes.CarTypeName)")]
		public string FilterCarTypeNameContext { get { return _FilterCarTypeNameContext; } set { _FilterCarTypeNameContext = value; _NeedRequery = true; } }

		protected string _FilterCarNameContext;
		/// <summary>
		/// Фильтр-поле: контекст наименования машины (Passes.CarName)
		/// </summary>
		[Description("Фильтр-поле: контекст наименования машины (Passes.CarName)")]
		public string FilterCarNameContext { get { return _FilterCarNameContext; } set { _FilterCarNameContext = value; _NeedRequery = true; } }

		protected string _FilterCarNumberContext;
		/// <summary>
		/// Фильтр-поле: контекст гос.номера машины (Passes.CarNumber)
		/// </summary>
		[Description("Фильтр-поле: контекст гос.номера машины (Passes.CarNumber)")]
		public string FilterCarNumberContext { get { return _FilterCarNumberContext; } set { _FilterCarNumberContext = value; _NeedRequery = true; } }

		protected string _FilterDriverNameContext;
		/// <summary>
		/// Фильтр-поле: контекст ФИО водителя (Passes.DriverName)
		/// </summary>
		[Description("Фильтр-поле: контекст ФИО водителя (Passes.DriverName)")]
		public string FilterDriverNameContext { get { return _FilterDriverNameContext; } set { _FilterDriverNameContext = value; _NeedRequery = true; } }

		protected string _FilterReasonContext;
		/// <summary>
		/// Фильтр-поле: контекст цели поездки (Passes.Reason)
		/// </summary>
		[Description("Фильтр-поле: контекст цели поездки (Passes.Reason)")]
		public string FilterReasonContext { get { return _FilterReasonContext; } set { _FilterReasonContext = value; _NeedRequery = true; } }

		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// Фильтр-поле: пропуск утвержден (Passes.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: пропуск утвержден (Passes.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterDateBegFull;
		/// <summary>
		/// Фильтр-поле: заполнена дата-время прибытия (Passes.DateBeg)?
		/// </summary>
		[Description("Фильтр-поле: заполнена дата-время прибытия (Passes.DateBeg)?")]
		public bool? FilterDateBegFull { get { return _FilterDateBegFull; } set { _FilterDateBegFull = value; _NeedRequery = true; } }

		protected bool? _FilterDateEndFull;
		/// <summary>
		/// Фильтр-поле: заполнена дата-время выхода (Passes.DateEnd)?
		/// </summary>
		[Description("Фильтр-поле: заполнена дата-время выхода (Passes.DateEnd)?")]
		public bool? FilterDateEndFull { get { return _FilterDateEndFull; } set { _FilterDateEndFull = value; _NeedRequery = true; } }

		protected bool? _FilterIsClosed;
		/// <summary>
		/// Фильтр-поле: пропуск закрыт (въехал-выехал) (Passes.DateBeg is not Null and Passes.DateEnd is not Null)?
		/// </summary>
		[Description("Фильтр-поле: пропуск закрыт (въехал-выехал) (Passes.DateBeg is not Null and Passes.DateEnd is not Null)?")]
		public bool? FilterIsClosed { get { return _FilterIsClosed; } set { _FilterIsClosed = value; _NeedRequery = true; } }

		protected string _FilterTransportPermissionsList;
		/// <summary>
		/// Фильтр-поле: список кодов разрешений на пересечение ворот, через запятую (Passes -> TransportPermissions.WayBillID)
		/// </summary>
		[Description("Фильтр-поле: список кодов разрешений на пересечение ворот, через запятую (Passes -> TransportPermissions.WayBillID)")]
		public string FilterTransportPermissionsList { get { return _FilterTransportPermissionsList; } set { _FilterTransportPermissionsList = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// Фильтр-поле: список кодов рейсов, через запятую (Trips.PassID)
		/// </summary>
		[Description("Фильтр-поле: список кодов рейсов, через запятую (Trips.PassID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterGatesHistoryList;
		/// <summary>
		/// Фильтр-поле: список кодов пересечений ворот, через запятую (GatesHistory.PassID)
		/// </summary>
		[Description("Фильтр-поле: список кодов пересечений ворот, через запятую (GatesHistory.PassID)")]
		public string FilterGatesHistoryList { get { return _FilterGatesHistoryList; } set { _FilterGatesHistoryList = value; _NeedRequery = true; } }

		#endregion Фильтры

		// ----------------------------

		public Pass()
			: base()
		{
			_MainTableName = "Passes";
			_ColumnID = "ID";
			_ColumnName = "DatePass";
		}


		#region FillData

		/// <summary>
		/// получение полного списка пропусков с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_PassesFill @nID, @cIDList, " +
									"@dDateBeg, " +
									"@dDateEnd, " +
									"@bIsPermitted, " + 
									"@cCarNameContext, @cCarNumberContext, " +
									"@cCarTypeNameContext, " +
									"@cDriverNameContext, " + 
									"@cReasonContext, " +
									"@bIsConfirmed, " +
									"@bDateBegFull, @bDateEndFull, " +
									"@bIsClosed, " + 
									"@cTransportPermissionsList, " + 
									"@cTripsList, " +
									"@cGatesHistoryList";	
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PassesFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@bIsPermitted", SqlDbType.Bit);
			if (_FilterIsPermitted != null)
				_oParameter.Value = _FilterIsPermitted;
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

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (_FilterIsConfirmed != null)
				_oParameter.Value = _FilterIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDateBegFull", SqlDbType.Bit);
			if (_FilterDateBegFull != null)
				_oParameter.Value = _FilterDateBegFull;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDateEndFull", SqlDbType.Bit);
			if (_FilterDateEndFull != null)
				_oParameter.Value = _FilterDateEndFull;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsClosed", SqlDbType.Bit);
			if (_FilterIsClosed != null)
				_oParameter.Value = _FilterIsClosed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTransportPermissionsList", SqlDbType.VarChar);
			if (_FilterTransportPermissionsList != null)
				_oParameter.Value = _FilterTransportPermissionsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
			if (_FilterTripsList != null)
				_oParameter.Value = _FilterTripsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGatesHistoryList", SqlDbType.VarChar);
			if (_FilterGatesHistoryList != null)
				_oParameter.Value = _FilterGatesHistoryList;
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
				_ErrorStr = "Ошибка при получении списка пропусков..." + Convert.ToChar(13) + ex.Message;
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
			_FilterIsPermitted = null;
			_FilterCarTypeNameContext = null;
			_FilterCarNameContext = null;
			_FilterCarNumberContext = null;
			_FilterDriverNameContext = null;
			_FilterReasonContext = null;
			_FilterIsConfirmed = null;
			_FilterDateBegFull = null;
			_FilterDateEndFull = null;
			_FilterIsClosed = null;
			_FilterTransportPermissionsList = null;
			_FilterTripsList = null;
			_FilterGatesHistoryList = null;
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
					_DatePass = Convert.ToDateTime(r["DatePass"]);

					_IsPermitted = Convert.ToBoolean(r["IsPermitted"]);
					_IsClosed = Convert.ToBoolean(r["IsClosed"]); 

					_CarName = r["CarName"].ToString();
					_CarNumber = r["CarNumber"].ToString();
					_TrailerNumber = r["TrailerNumber"].ToString();
					_CarTypeName = r["CarTypeName"].ToString();

					_DriverName = r["DriverName"].ToString();
					_DriverPhone = r["DriverPhone"].ToString();
					_DriverDocument = r["DriverDocument"].ToString();

					_Reason = r["Reason"].ToString();

					if (!Convert.IsDBNull(r["DateBegPlan"]))
						_DateBegPlan = Convert.ToDateTime(r["DateBegPlan"]);
					if (!Convert.IsDBNull(r["DateEndPlan"]))
						_DateEndPlan = Convert.ToDateTime(r["DateEndPlan"]);
					if (!Convert.IsDBNull(r["DurationMinutesPlan"]))
						_DurationMinutesPlan = Convert.ToInt32(r["DurationMinutesPlan"]);
					_DurationHoursMinutesPlan = r["DurationHoursMinutesPlan"].ToString();
					if (!Convert.IsDBNull(r["DateBeg"]))
						_DateBeg = Convert.ToDateTime(r["DateBeg"]);
					if (!Convert.IsDBNull(r["DateEnd"]))
						_DateEnd = Convert.ToDateTime(r["DateEnd"]);
					if (!Convert.IsDBNull(r["DurationMinutes"]))
						_DurationMinutes = Convert.ToInt32(r["DurationMinutes"]);
					_DurationHoursMinutes = r["DurationHoursMinutes"].ToString();

					_Brutto = Convert.ToDecimal(r["Brutto"]);
					_PalletsQnt = Convert.ToDecimal(r["PalletsQnt"]);

					if (!Convert.IsDBNull(r["PartnerID"]))
						_PartnerID = Convert.ToInt32(r["PartnerID"]);
					_PartnerName = r["PartnerName"].ToString();

					if (!Convert.IsDBNull(r["CarrierPartnerID"]))
						_CarrierPartnerID = Convert.ToInt32(r["CarrierPartnerID"]);
					_CarrierPartnerName = r["CarrierPartnerName"].ToString();

					if (!Convert.IsDBNull(r["UserCreateID"]))
						_UserCreateID = Convert.ToInt32(r["UserCreateID"]);
					_UserCreateName = r["UserCreateName"].ToString();
					if (!Convert.IsDBNull(r["DateCreate"]))
						_DateCreate = Convert.ToDateTime(r["DateCreate"]);

					if (!Convert.IsDBNull(r["UserConfirmID"]))
						_UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
					_UserConfirmName = r["UserConfirmName"].ToString();
					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);

					_Note = r["Note"].ToString();
					_TransportPermissionID = Convert.ToInt32(r["TransportPermissionID"]);
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о пропуске...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о пропуске (нет данных)...";
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

			_DatePass = DateTime.Now.Date;

			_IsPermitted = false;
			_IsClosed = false;

			_CarName = null;
			_CarNumber = null;
			_TrailerNumber = null;
			_CarTypeName = null;

			_DriverName = null;
			_DriverPhone = null;
			_DriverDocument = null;

			_Reason = null;

			_DateBegPlan = null;
			_DateEndPlan = null;
			_DurationMinutesPlan = null;
			_DurationHoursMinutesPlan = null;
			_DateBeg = null;
			_DateEnd = null;
			_DurationMinutes = null;
			_DurationHoursMinutes = null;

			_Brutto = 0;
			_PalletsQnt = 0;

			_PartnerID = null;
			_PartnerName = null;

			_CarrierPartnerID = null;
			_CarrierPartnerName = null;

			_UserCreateID = null;
			_UserCreateName = null;
			_DateCreate = null;

			_UserConfirmID = null;
			_UserConfirmName = null;
			_DateConfirm = null;
			_IsConfirmed = false;

			_Note = null;
			_TransportPermissionID = 0; 
			_ERPCode = null; 
		}

		#endregion FillOne


		#region Save, Delete

		/// <summary>
		/// сохранение пропуска
		/// </summary>
		public bool SaveOne(int? nUserID)
		{
			string _sqlCommand = "execute up_PassesSave @nPassID output, " +
					"@dDatePass, " +
					"@cCarName, @cCarNumber, @cTrailerNumber, " + 
					"@cCarTypeName, " +
					"@cDriverName, @cDriverDocument, @cDriverPhone, " +
					"@cReason, " +
					"@dDateBegPlan, @dDateEndPlan, " +
					"@dDateBeg, @dDateEnd, " + 
					"@nBrutto, @nPalletsQnt, " + 
					"@nPartnerID, @cPartnerName, " + 
					"@nCarrierPartnerID, @cCarrierPartnerName, " + 
					"@cNote, " +
					"@nUserCreateID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PassesSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDatePass", SqlDbType.SmallDateTime);
			_oParameter.Value = _DatePass;

			_oParameter = _oCommand.Parameters.Add("@cCarName", SqlDbType.VarChar);
			if (_CarName != null)
				_oParameter.Value = _CarName;
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

			_oParameter = _oCommand.Parameters.Add("@cCarTypeName", SqlDbType.VarChar);
			if (_CarTypeName != null)
				_oParameter.Value = _CarTypeName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverName", SqlDbType.VarChar);
			if (_DriverName != null)
				_oParameter.Value = _DriverName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverDocument", SqlDbType.VarChar);
			if (_DriverDocument != null)
				_oParameter.Value = _DriverDocument;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverPhone", SqlDbType.VarChar);
			if (_DriverPhone != null)
				_oParameter.Value = _DriverPhone;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cReason", SqlDbType.VarChar);
			if (_Reason != null)
				_oParameter.Value = _Reason;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateBegPlan", SqlDbType.SmallDateTime);
			if (_DateBegPlan.HasValue)
				_oParameter.Value = _DateBegPlan;
			else 
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEndPlan", SqlDbType.SmallDateTime);
			if (_DateEndPlan.HasValue)
				_oParameter.Value = _DateEndPlan;
			else 
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (_DateBeg.HasValue)
				_oParameter.Value = _DateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (_DateEnd.HasValue)
				_oParameter.Value = _DateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nBrutto", SqlDbType.Decimal);
			_oParameter.Precision = 12;
			_oParameter.Scale = 1;
			_oParameter.Value = _Brutto;

			_oParameter = _oCommand.Parameters.Add("@nPalletsQnt", SqlDbType.Decimal);
			_oParameter.Precision = 12;
			_oParameter.Scale = 2;
			_oParameter.Value = _PalletsQnt;

			_oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			if (_PartnerID.HasValue)
				_oParameter.Value = _PartnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnerName", SqlDbType.VarChar);
			if (_PartnerName != null)
				_oParameter.Value = _PartnerName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCarrierPartnerID", SqlDbType.Int);
			if (_CarrierPartnerID.HasValue)
				_oParameter.Value = _CarrierPartnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cCarrierPartnerName", SqlDbType.VarChar);
			if (_CarrierPartnerName != null)
				_oParameter.Value = _CarrierPartnerName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserCreateID", SqlDbType.Int);
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
				_ErrorStr = "Ошибка при сохранении пропуска...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении пропуска...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании нового пропуска - получим его код
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nPassID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nPassID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// удаление пропуска 
		/// </summary>
		public bool DeleteOne(int nPassID)
		{
			String _sqlCommand = "execute up_PassesDelete @nPassID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PassesDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			_oParameter.Value = nPassID;

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
				_ErrorStr = "Ошибка при попытке удаления пропуска...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении пропуска...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// утверждение пропуска
		/// </summary>
		public bool Confirm(int? nPassID, bool bConfirm, int nUserID)
		{
			string _sqlCommand = "execute up_PassesConfirm @nPassID, " +
					"@bConfirm, " +
					"@nUserConfirmID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PassesConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			_oParameter.Value = nPassID;

			_oParameter = _oCommand.Parameters.Add("@bConfirm", SqlDbType.Bit);
			_oParameter.Value = bConfirm;

			_oParameter = _oCommand.Parameters.Add("@nUserConfirmID", SqlDbType.Int);
			_oParameter.Value = nUserID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion up_PassesConfirm parameters

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				if (bConfirm)
				{
					_ErrorStr = "Ошибка при попытке утверждения пропуска...";
				}
				else
				{
					_ErrorStr = "Ошибка при попытке снятия отметки об утверждении пропуска...";
				}
				_ErrorStr += "\r\n" + ex.Message;
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
					if (bConfirm)
					{
						_ErrorStr = "Ошибка при утверждении пропуска...";
					}
					else
					{
						_ErrorStr = "Ошибка при снятии отметки об утверждении пропуска...";
					}
					_ErrorStr += "\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}

			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Permit

		/// <summary>
		/// разрешение очередного пересечения ворот 
		/// </summary>
		public bool Permit(int? nPassID, bool bPermit, int nUserID)
		{
			string _sqlCommand = "execute up_PassesPermit @nPassID, " +
					"@bPermit, " +
					"@nUserPermitID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PassesPermit parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			_oParameter.Value = nPassID;

			_oParameter = _oCommand.Parameters.Add("@bPermit", SqlDbType.Bit);
			_oParameter.Value = bPermit;

			_oParameter = _oCommand.Parameters.Add("@nUserPermitID", SqlDbType.Int);
			_oParameter.Value = nUserID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion up_PassesPermit parameters

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -22;
				_ErrorStr = "Ошибка при попытке " + ((bPermit) ? "разрешения" : "запрещения") + " очередного пересечения ворот для пропуска...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при " + ((bPermit) ? "разрешении" : "запрещении") + " очередного пересечения ворот для пропуска...";
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}

			return (_ErrorNumber == 0);
		}

		#endregion Permit


		#region SetDate

		/// <summary>
		/// проставить/снять дату въезда-выезда
		/// </summary>
		public bool SetDateFact(int? nPassID, bool bClear, bool bEnd, int nUserID)
		{
			string _sqlCommand = "execute up_PassesSetDateFact @nPassID, " +
					"@bClear, " +
					"@bEnd, " + 
					"@nUserID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PassesSetDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			_oParameter.Value = nPassID;

			_oParameter = _oCommand.Parameters.Add("@bClear", SqlDbType.Bit);
			_oParameter.Value = bClear;

			_oParameter = _oCommand.Parameters.Add("@bEnd", SqlDbType.Bit);
			_oParameter.Value = bEnd;

			_oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			_oParameter.Value = nUserID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion up_PassesSetDate parameters

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -22;
				if (bClear)
				{
					if (bEnd)
					{
						_ErrorStr = "Ошибка при попытке очистки времени выезда машины...";
					}
					else
					{
						_ErrorStr = "Ошибка при попытке очистки времени въезда машины...";
					}
				}
				else
				{
					if (bEnd)
					{
						_ErrorStr = "Ошибка при попытке отметки времени выезда машины...";
					}
					else
					{
						_ErrorStr = "Ошибка при попытке отметки времени въезда машины...";
					}
				}
				_ErrorStr += "\r\n" + ex.Message;
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
					if (bClear)
					{
						if (bEnd)
						{
							_ErrorStr = "Ошибка при очистке времени выезда машины...";
						}
						else
						{
							_ErrorStr = "Ошибка при очистке времени въезда машины...";
						}
					}
					else
					{
						if (bEnd)
						{
							_ErrorStr = "Ошибка при отметке времени выезда машины...";
						}
						else
						{
							_ErrorStr = "Ошибка при отметке времени въезда машины...";
						}
					}
					_ErrorStr += "\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}

			return (_ErrorNumber == 0);
		}

		#endregion SetDate

	}

#endregion Pass

}
