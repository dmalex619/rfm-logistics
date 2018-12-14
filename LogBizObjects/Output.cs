using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMPublic; 

/// <summary>
/// Бизнес-объект Задание на расход (Output), Товар в расходе (OutputGood)
/// </summary>
/// 
namespace LogBizObjects
{

#region Output

	public class Output : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// Список ID расходов (Outputs.ID)
		/// </summary>
		[Description("Список ID расходов (Outputs.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected DateTime _DateOutput;
		/// <summary>
		/// Дата расхода (Outputs.DateOutput)
		/// </summary>
		[Description("Дата расхода (Outputs.DateOutput)")]
		public DateTime DateOutput { get { return _DateOutput; } set { _DateOutput = value; } }

		protected bool _DeliveryNeed;
		/// <summary>
		/// Требуется наша доставка (своей или арендованной машиной) (Outputs.DeliveryNeed)?
		/// </summary>
		[Description("Требуется наша доставка (своей или арендованной машиной) (Outputs.DeliveryNeed)?")]
		public bool DeliveryNeed { get { return _DeliveryNeed; } set { _DeliveryNeed = value; } }

		protected int _OutputTypeID;
		/// <summary>
		/// Тип расхода - код (Outputs.OutputTypeID)
		/// </summary>
		[Description("Тип расхода - код (Outputs.OutputTypeID)")]
		public int OutputTypeID { get { return _OutputTypeID; } set { _OutputTypeID = value; } }

		protected string _OutputTypeName;
		/// <summary>
		/// Тип расхода - наименование (Outputs.OutputTypeID -> OutputsTypes.Name)
		/// </summary>
		[Description("Тип расхода - наименование (Outputs.OutputTypeID -> OutputsTypes.Name)")]
		public string OutputTypeName { get { return _OutputTypeName; } set { _OutputTypeName = value; } }

		protected bool _IsRefund;
		/// <summary>
		/// Тип расхода - возврат (Outputs.OutputTypeID -> OutputsTypes.IsRefund)
		/// </summary>
		[Description("Тип расхода - возврат (Outputs.OutputTypeID -> OutputsTypes.IsRefund)")]
		public bool IsRefund { get { return _IsRefund; } set { _IsRefund = value; } }


		protected int? _OwnerID;
		/// <summary>
		/// Владелец товара - код (Outputs.PartnerID -> Partners.ID)
		/// </summary>
		[Description("Владелец товара - код (Outputs.PartnerID -> Partners.ID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// Владелец товара - наименование (Outputs.PartnerID -> Partners.ID -> Partners.Name)
		/// </summary>
		[Description("Владелец товара - наименование (Outputs.PartnerID -> Partners.ID -> Partners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

		protected int? _GoodStateID;
		/// <summary>
		/// Состояние товара - код (Outputs.PartnerID -> Partners.GoodStateID)
		/// </summary>
		[Description("Состояние товара - код (Outputs.PartnerID -> Partners.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// Состояние товара - наименование (Outputs.PartnerID -> Partners.GoodStateID -> GoodStates.Name)
		/// </summary>
		[Description("Состояние товара - наименование (Outputs.PartnerID -> Partners.GoodStateID -> GoodStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int? _PartnerID;
		/// <summary>
		/// Клиент-получатель - код (Outputs.PartnerID)
		/// </summary>
		[Description("Клиент-получатель - код (Outputs.PartnerID)")]
		public int? PartnerID { get { return _PartnerID; } set { _PartnerID = value; } }

		protected string _PartnerName;
		/// <summary>
		/// Клиент-получатель - наименование (Outputs.PartnerID -> Partners.Name)
		/// </summary>
		[Description("Клиент-получатель - наименование (Outputs.PartnerID -> Partners.Name)")]
		public string PartnerName { get { return _PartnerName; } set { _PartnerName = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// Зона клиента-получателя - код (Outputs.PartnerID -> Partners.ZoneID)
		/// </summary>
		[Description("Зона клиента-получателя - код (Outputs.PartnerID -> Partners.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// Зона клиента-получателя - наименование (Outputs.PartnerID -> Partners.ZoneID -> Zones.Name)
		/// </summary>
		[Description("Зона клиента-получателя - наименование (Outputs.ZoneID -> Partners.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _ZoneAlias;
		/// <summary>
		/// Зона клиента-получателя - краткое наименование (Outputs.PartnerID -> Partners.ZoneID -> Zones.Alias)
		/// </summary>
		[Description("Зона клиента-получателя - краткое наименование (Outputs.ZoneID -> Partners.ZoneID -> Zones.Alias)")]
		public string ZoneAlias { get { return _ZoneAlias; } set { _ZoneAlias = value; } }

		protected string _DeliveryAddress;
		/// <summary>
		/// Адрес доставки клиента-получателя (Outputs.PartnerID -> Partners.DeliveryAddress)
		/// </summary>
		[Description("Адрес доставки клиента-получателя (Outputs.PartnerID -> Partners.DeliveryAddress)")]
		public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

		protected string _DeliveryPassage;
		/// <summary>
		/// Проезд для клиента-получателя (Outputs.PartnerID -> Partners.DeliveryPassage)
		/// </summary>
		[Description("Проезд для клиента-получателя (Outputs.PartnerID -> Partners.DeliveryPassage)")]
		public string DeliveryPassage { get { return _DeliveryPassage; } set { _DeliveryPassage = value; } }

		protected bool? _PassengerCarOnly;
		/// <summary>
		/// Доставка только легковой машиной (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("Доставка только легковой машиной (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? PassengerCarOnly { get { return _PassengerCarOnly; } set { _PassengerCarOnly = value; } }

		protected bool? _PosternOnly;
		/// <summary>
		/// Доставка только машиной с задней дверью (Outputs.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("Доставка только машиной с задней дверью (Outputs.PartnerTargetID -> Partners.PosternOnly)?")]
		public bool? PosternOnly { get { return _PosternOnly; } set { _PosternOnly = value; } }

		protected bool? _LoadLiftOnly;
		/// <summary>
		/// Доставка только машиной с подъемником (лопатой) (Outputs.PartnerTargetID -> Partners.LoadLiftOnly)?
		/// </summary>
		[Description("Доставка только машиной с подъемником (лопатой) (Outputs.PartnerTargetID -> Partners.LoadLiftOnly)?")]
		public bool? LoadLiftOnly { get { return _LoadLiftOnly; } set { _LoadLiftOnly = value; } }

		protected int? _PermitLevelID;
		/// <summary>
		/// Разрешение проезда (получатель) - код (Outputs.PartnerTargetID -> Partners.PermitLevelID)
		/// </summary>
		[Description("Разрешение проезда (получатель) - код (Outputs.PartnerTargetID -> Partners.PermitLevelID)")]
		public int? PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// Разрешение проезда (получатель) - наименование (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("Разрешение проезда (получатель) - наименование (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int? _PermitLevelValue;
		/// <summary>
		/// Разрешение проезда (получатель) - уровень, не менее (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Разрешение проезда (получатель) - уровень, не менее (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int? PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }


		protected int? _TripID;
		/// <summary>
		/// Рейс - код (Outputs.TripID)
		/// </summary>
		[Description("Рейс - код (Outputs.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected bool _TripExists;
		/// <summary>
		/// Задание присоединено к рейсу (Outputs.TripID is not Null)?
		/// </summary>
		[Description("Задание присоединено к рейсу (Outputs.TripID is not Null)?")]
		public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }

		protected bool _ActsExists;
		/// <summary>
		/// Задание имеет акты (Outputs.ID - Acts.OutputID)?
		/// </summary>
		[Description("Задание имеет акты (Outputs.ID - Acts.OutputID)?")]
		public bool ActsExists { get { return _ActsExists; } set { _ActsExists = value; } }


		protected decimal _Netto;
		/// <summary>
		/// Вес товара - нетто, кг (Outputs.Netto)
		/// </summary>
		[Description("Вес товара - нетто, кг (Outputs.Netto)")]
		public decimal Netto { get { return _Netto; } set { _Netto = value; } }

		protected decimal _Brutto;
		/// <summary>
		/// Вес перевозимого товара - брутто, кг (Outputs.Brutto)
		/// </summary>
		[Description("Вес товара - брутто, кг (Outputs.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected decimal _Volume;
		/// <summary>
		/// Объем, м3 (Outputs.Volume())
		/// </summary>
		[Description("Объем, м3 (Outputs.Volume())")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }

		protected decimal _PalletsQnt;
		/// <summary>
		/// Количество перевозимых паллет с товаром (Outputs.PalletsQnt)
		/// </summary>
        [Description("Количество перевозимых паллет с товаром (Outputs.PalletsQnt)")]
		public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }

		protected int _PointsQnt;
		/// <summary>
		/// Количество торговых точек (Outputs.PointsQnt)
		/// </summary>
		[Description("Количество торговых точек (Outputs.PointsQnt)")]
		public int PointsQnt { get { return _PointsQnt; } set { _PointsQnt = value; } }

		protected int _OutputsDocumentsQnt;
		/// <summary>
		/// Количество расходных документов, входящих в задание (Outputs.OutputsDocumentsQnt)
		/// </summary>
		[Description("Количество расходных документов, входящих в задание (Outputs.OutputsDocumentsQnt)")]
		public int OutputsDocumentsQnt { get { return _OutputsDocumentsQnt; } set { _OutputsDocumentsQnt = value; } }

		protected string _DepartmentName;
		/// <summary>
		/// Отдел - наименование (Outputs.DepartmentName - dbo)
		/// </summary>
		[Description("Отдел - наименование (Outputs.DepartmentName - dbo)")]
		public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания к расходу (Outputs.Note)
		/// </summary>
		[Description("Примечания к расходу (Outputs.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _PartnersNames;
		/// <summary>
		/// Названия партнеров-получателей - объединенние (Outputs.PartnersNames)
		/// </summary>
		[Description("Названия партнеров-получателей - объединенние (Outputs.PartnersNames)")]
		public string PartnersNames { get { return _PartnersNames; } set { _PartnersNames = value; } }

		protected string _OutputsDocumentsNotes;
		/// <summary>
		/// Примечания к расходным документам - объединение (Outputs.OutputsDocumentsNotes)
		/// </summary>
		[Description("Примечания к расходным документам - объединение (Outputs.OutputsDocumentsNotes)")]
		public string OutputsDocumentsNotes { get { return _OutputsDocumentsNotes; } set { _OutputsDocumentsNotes = value; } }


		protected bool _TPL;
		/// <summary>
		/// 3PL (Outputs.TPL)?
		/// </summary>
		[Description("3PL (Outputs.TPL)?")]
		public bool TPL { get { return _TPL; } set { _TPL = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// Дата-время создания задания (Outputs.DateCreate)?
		/// </summary>
		[Description("Дата-время создания задания (Outputs.DateCreate)?")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected bool _NotForJoin;
		/// <summary>
		/// Задание нельзя объединять с другими заданиями (Outputs.NotForJoin)?
		/// </summary>
		[Description("Задание нельзя объединять с другими заданиями (Outputs.NotForJoin)?")]
		public bool NotForJoin { get { return _NotForJoin; } set { _NotForJoin = value; } }

		protected DateTime? _DateAttachToTrip;
		/// <summary>
		/// Дата-время присоединения к рейсу (Outputs.DateAttachToTrip)?
		/// </summary>
		[Description("Дата-время присоединения к рейсу (Outputs.DateAttachToTrip)?")]
		public DateTime? DateAttachToTrip { get { return _DateAttachToTrip; } set { _DateAttachToTrip = value; } }

		protected bool _ReadyForWMS;
		/// <summary>
		/// Готово к передаче в складскую систему (Outputs.ReadyForWMS)?
		/// </summary>
		[Description("Готово к передаче в складскую систему (Outputs.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }

		protected bool _SentToWMS;
		/// <summary>
		/// Передано в складскую систему (Outputs.SentToWMS)?
		/// </summary>
		[Description("Передано в складскую систему (Outputs.SentToWMS)?")]
		public bool SentToWMS { get { return _SentToWMS; } set { _SentToWMS = value; } }

		protected DateTime? _DateConfirm;
		/// <summary>
		/// Дата-время подтверждения задания (Outputs.DateConfirm)?
		/// </summary>
		[Description("Дата-время подтверждения задания (Outputs.DateConfirm)?")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// Подтверждено (Outputs.IsConfirmed)?
		/// </summary>
		[Description("Подтвердждено (Outputs.IsConfirmed)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }

		protected DateTime? _DatePick;
		/// <summary>
		/// Дата-время сбора задания (Outputs.DatePick)?
		/// </summary>
		[Description("Дата-время сбора задания (Outputs.DatePick)?")]
		public DateTime? DatePick { get { return _DatePick; } set { _DatePick = value; } }

		protected bool _IsPicked;
		/// <summary>
		/// Собрано (Outputs.IsPicked)?
		/// </summary>
		[Description("Собрано (Outputs.IsPicked)?")]
		public bool IsPicked { get { return _IsPicked; } set { _IsPicked = value; } }


		protected bool _IsCarried;
		/// <summary>
		/// Задание перенесено (.dbo.OutputIsCarried(ID))?
		/// </summary>
		[Description("Задание перенесено (.dbo.OutputIsCarried(ID))?")]
		public bool IsCarried { get { return _IsCarried; } set { _IsCarried = value; } }

		protected bool _IsCopied;
		/// <summary>
		/// Задание перенесено и скопировано (.dbo.OutputIsCopied(ID))?
		/// </summary>
		[Description("Задание перенесено и скопировано (.dbo.OutputIsCopied(ID))?")]
		public bool IsCopied { get { return _IsCopied; } set { _IsCopied = value; } }

		protected int? _CopiedFromOutputID;
		/// <summary>
		/// Задание было создано из другого задания - код (.dbo.OutputCopiedFrom(ID))?
		/// </summary>
		[Description("Задание было создано из другого задания - код (.dbo.OutputCopiedFrom(ID))?")]
		public int? CopiedFromOutputID { get { return _CopiedFromOutputID; } set { _CopiedFromOutputID = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - код (Outputs.HostID)
		/// </summary>
		[Description("Host - код (Outputs.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - наименование (OutputsDocuments.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - наименование (OutputsDocuments.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// Код расхода в host-системе (Outputs.ERPCode)
		/// </summary>
		[Description("Код расхода в host-системе (Outputs.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterHostsList;
		/// <summary>
		/// Фильтр-поле: список кодов host-ов, через запятую (Outputs.HostID)
		/// </summary>
		[Description("Фильтр-поле: список кодов товарных групп, через запятую (Outputs.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }
		
		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата задания на расход - начальная дата периода (Outputs.DateOutput)
		/// </summary>
		[Description("Фильтр-поле: дата задания на расход - начальная дата периода (Outputs.DateOutput)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата задания на расход - конечная дата периода (Outputs.DateOutput)
		/// </summary>
		[Description("Фильтр-поле: дата задания на расход - конечная дата периода (Outputs.DateOutput)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterOutputsTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов заданий на расход, через запятую (Outputs.OutputTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов заданий на расход, через запятую (Outputs.OutputTypeID)")]
		public string FilterOutputsTypesList { get { return _FilterOutputsTypesList; } set { _FilterOutputsTypesList = value; _NeedRequery = true; } }

		protected bool? _FilterDeliveryNeed;
		/// <summary>
		/// Фильтр-поле: требуется наша доставка (своей или арендованной машиной) (Outputs.DeliveryNeed)?
		/// </summary>
		[Description("Фильтр-поле: требуется наша доставка (своей или арендованной машиной) (Outputs.DeliveryNeed)?")]
		public bool? FilterDeliveryNeed { get { return _FilterDeliveryNeed; } set { _FilterDeliveryNeed = value; _NeedRequery = true; } }

		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// Фильтр-поле: задание на расход готово к передаче в складскую систему (Outputs.ReadyForWMS)?
		/// </summary>
		[Description("Фильтр-поле: задание на расход готово к передаче в складскую систему (Outputs.ReadyForWMS)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }

		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// Фильтр-поле: задание на расход подтверждено (Outputs.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: задание на расход подтверждено (Outputs.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterIsCarried;
		/// <summary>
		/// Фильтр-поле: задание на расход перенесено (Outputs.IsCarried())?
		/// </summary>
		[Description("Фильтр-поле: задание на расход перенесено (Outputs.IsCarried())?")]
		public bool? FilterIsCarried { get { return _FilterIsCarried; } set { _FilterIsCarried = value; _NeedRequery = true; } }


		protected string _FilterPartnersList;
		/// <summary>
		/// Фильтр-поле: список кодов клиентов-получателей, через запятую (Outputs.PartnerID)
		/// </summary>
		[Description("Фильтр-поле: список кодов клиентов-получателей, через запятую (Outputs.PartnerID)")]
		public string FilterPartnersList { get { return _FilterPartnersList; } set { _FilterPartnersList = value; _NeedRequery = true; } }

		protected string _FilterPartnerNameContext;
		/// <summary>
		/// Фильтр-поле: название клиента-получателя, контекст (Outputs.PartnerID -> Partners.Name)
		/// </summary>
		[Description("Фильтр-поле: название клиента-получателя, контекст (Outputs.PartnerID -> Partners.Name)")]
		public string FilterPartnerNameContext { get { return _FilterPartnerNameContext; } set { _FilterPartnerNameContext = value; _NeedRequery = true; } }

		protected bool? _FilterPassengerCarOnly;
		/// <summary>
		/// Фильтр-поле: доставка легковой машиной (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("Фильтр-поле: доставка легковой машиной (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? FilterPassengerCarOnly { get { return _FilterPassengerCarOnly; } set { _FilterPassengerCarOnly = value; _NeedRequery = true; } }

		protected bool? _FilterPosternOnly;
		/// <summary>
		/// Фильтр-поле: доставка машиной с задней дверью (Outputs.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("Фильтр-поле: доставка машиной с задней дверью (Outputs.PartnerTargetID -> Partners.Postern)?")]
		public bool? FilterPosternOnly { get { return _FilterPosternOnly; } set { _FilterPosternOnly = value; _NeedRequery = true; } }

		protected bool? _FilterLoadLiftOnly;
		/// <summary>
		/// Фильтр-поле: доставка машиной с задним подъемником (лопатой) (Outputs.PartnerTargetID -> Partners.LoadLift)?
		/// </summary>
		[Description("Фильтр-поле: доставка машиной с задним подъемником (лопатой) (Outputs.PartnerTargetID -> Partners.LoadLift)?")]
		public bool? FilterLoadLiftOnly { get { return _FilterLoadLiftOnly; } set { _FilterLoadLiftOnly = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// Фильтр-поле: разрешение проезда - уровень, не менее (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Фильтр-поле: разрешение проезда - уровень, не менее (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		protected string _FilterZonesList;
		/// <summary>
		/// Фильтр-поле: список кодов зон клиентов-получателей, через запятую (Outputs.PartnerTargetID -> Partners.ZoneID)
		/// </summary>
		[Description("Фильтр-поле: список кодов зон клиентов-получателей, через запятую (Outputs.PartnerTargetID -> Partners.ZoneID)")]
		public string FilterZonesList { get { return _FilterZonesList; } set { _FilterZonesList = value; _NeedRequery = true; } }


		protected string _FilterOutputsDocumentsList;
		/// <summary>
		/// Фильтр-поле: список кодов расходных документов, через запятую (OutputsDocuments.OutputID)
		/// </summary>
		[Description("Фильтр-поле: список кодов расходных документов, через запятую (OutputsDocuments.OutputID)")]
		public string FilterOutputsDocumentsList { get { return _FilterOutputsDocumentsList; } set { _FilterOutputsDocumentsList = value; _NeedRequery = true; } }


		protected bool? _FilterTripExists;
		/// <summary>
		/// Фильтр-поле: задание присоединено к рейсу (Outputs.TripID is not Null)?
		/// </summary>
		[Description("Фильтр-поле: задание присоединено к рейсу (Outputs.TripID is not Null)?")]
		public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// Фильтр-поле: список кодов рейсов, через запятую (Outputs.TripID)
		/// </summary>
		[Description("Фильтр-поле: список кодов рейсов, через запятую (Outputs.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// Фильтр-поле: список кодов владельцев, через запятую (Outputs.OwnerID)
		/// </summary>
		[Description("Фильтр-поле: список кодов владельцев, через запятую (Outputs.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }

		// для поиска по товарам 

		protected string _FilterPackingsList;
		/// <summary>
		/// Фильтр-поле: список кодов упаковок, через запятую (Outputs.ID --> OutputsGoods.PackingID)
		/// </summary>
		[Description("Фильтр-поле: список кодов упаковок, через запятую (Outputs.ID --> OutputsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// Фильтр-поле: список кодов упаковок, через запятую (Outputs.ID --> OutputsGoods.GoodID)
		/// </summary>
		[Description("Фильтр-поле: список кодов упаковок, через запятую (Outputs.ID --> OutputsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableOutputsGoods;
		/// <summary>
		/// Список товаров в расходе OutputsGoods
		/// </summary>
		[Description("Список товаров в расходе OutputsGoods")]
		public DataTable TableOutputsGoods { get { return _TableOutputsGoods; } }

		protected DataTable _TableOutputsTypes;
		/// <summary>
		/// Таблица типов расходов OutputsTypes
		/// </summary>
		[Description("Таблица типов расходов OutputsTypes")]
		public DataTable TableOutputsTypes { get { return _TableOutputsTypes; } }

		#endregion Таблицы


		// -------------------------------------

		public Output() : base()
		{
			_MainTableName = "Outputs";
			_ColumnID = "ID";
			_ColumnName = "DateOutput";
		}


		#region FillData

		/// <summary>
		/// получение полного списка заданий на расход с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_OutputsFill @nID, @cIDList, " +
									"@cHostsList, " + 
									"@dDateBeg, @dDateEnd, " +
									"@cOutputsTypesList, " +
									"@bDeliveryNeed, " +
									"@bReadyForWMS, " +
									"@bIsConfirmed, " +
									"@bIsCarried, " +
									"@cPartnersList, @cPartnerNameContext, " +
									"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
									"@nPermitLevelValueMin, " +
									"@cZonesList, " +
									"@cOutputsDocumentsList, " +
									"@bTripExists, @cTripsList, " +
									"@cOwnersList, " + 	
									"@cPackingsList, @cGoodsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_ID != null)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cHostsList", SqlDbType.VarChar);
			if (_FilterHostsList != null)
				_oParameter.Value = _FilterHostsList;
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

			_oParameter = _oCommand.Parameters.Add("@cOutputsTypesList", SqlDbType.VarChar);
			if (_FilterOutputsTypesList != null)
				_oParameter.Value = _FilterOutputsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDeliveryNeed", SqlDbType.Bit);
			if (_FilterDeliveryNeed != null)
				_oParameter.Value = _FilterDeliveryNeed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bReadyForWMS", SqlDbType.Bit);
			if (_FilterReadyForWMS != null)
				_oParameter.Value = _FilterReadyForWMS;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (_FilterIsConfirmed != null)
				_oParameter.Value = _FilterIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsCarried", SqlDbType.Bit);
			if (_FilterIsCarried != null)
				_oParameter.Value = _FilterIsCarried;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
			if (_FilterPartnersList != null)
				_oParameter.Value = _FilterPartnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnerNameContext", SqlDbType.VarChar);
			if (_FilterPartnerNameContext != null)
				_oParameter.Value = _FilterPartnerNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPassengerCarOnly", SqlDbType.Bit);
			if (_FilterPassengerCarOnly != null)
				_oParameter.Value = _FilterPassengerCarOnly;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPosternOnly", SqlDbType.Bit);
			if (_FilterPosternOnly != null)
				_oParameter.Value = _FilterPosternOnly;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bLoadLiftOnly", SqlDbType.Bit);
			if (_FilterLoadLiftOnly != null)
				_oParameter.Value = _FilterLoadLiftOnly;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPermitLevelValueMin", SqlDbType.Int);
			if (_FilterPermitLevelValueMin != null)
				_oParameter.Value = _FilterPermitLevelValueMin;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cZonesList", SqlDbType.VarChar);
			if (_FilterZonesList != null)
				_oParameter.Value = _FilterZonesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			if (_FilterOutputsDocumentsList != null)
				_oParameter.Value = _FilterOutputsDocumentsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bTripExists", SqlDbType.Bit);
			if (_FilterTripExists != null)
				_oParameter.Value = _FilterTripExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
			if (_FilterTripsList != null)
				_oParameter.Value = _FilterTripsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (_FilterOwnersList != null)
				_oParameter.Value = _FilterOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPackingsList", SqlDbType.VarChar);
			if (_FilterPackingsList != null)
				_oParameter.Value = _FilterPackingsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsList", SqlDbType.VarChar);
			if (_FilterGoodsList != null)
				_oParameter.Value = _FilterGoodsList;
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
				_ErrorStr = "Ошибка при получении списка заданий на расход..." + Convert.ToChar(13) + ex.Message;
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

			_FilterHostsList = null;

			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterOutputsTypesList = null;
			_FilterDeliveryNeed = null;

			_FilterReadyForWMS = null;
			_FilterIsConfirmed = null;
			_FilterIsCarried = null;

			_FilterPartnersList = null;
			_FilterPartnerNameContext = null;
			_FilterPassengerCarOnly = null;
			_FilterPosternOnly = null;
			_FilterLoadLiftOnly = null;
			_FilterPermitLevelValueMin = null;
			_FilterZonesList = null;

			_FilterOutputsDocumentsList = null;
			_FilterTripExists = null;
			_FilterTripsList = null;
			_FilterOwnersList = null;
			_FilterPackingsList = null;
			_FilterGoodsList = null;
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

					_DateOutput = Convert.ToDateTime(r["DateOutput"]);
					_DeliveryNeed = Convert.ToBoolean(r["DeliveryNeed"]);

					_OutputTypeID = Convert.ToInt32(r["OutputTypeID"]);
					_OutputTypeName = r["OutputTypeName"].ToString();
					_IsRefund = Convert.ToBoolean(r["IsRefund"]);

					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					if (!Convert.IsDBNull(r["GoodStateID"]))
						_GoodStateID = Convert.ToInt32(r["GoodStateID"]);
					_GoodStateName = r["GoodStateName"].ToString();

					if (!Convert.IsDBNull(r["PartnerID"]))
						_PartnerID = Convert.ToInt32(r["PartnerID"]);
					_PartnerName = r["PartnerName"].ToString();
					if (!Convert.IsDBNull(r["ZoneID"]))
						_ZoneID = Convert.ToInt32(r["ZoneID"]);
					_ZoneName = r["ZoneName"].ToString();
					_ZoneAlias = r["ZoneAlias"].ToString();
					_DeliveryAddress = r["DeliveryAddress"].ToString();
					_DeliveryPassage = r["DeliveryPassage"].ToString();

					if (!Convert.IsDBNull(r["PassengerCarOnly"]))
						_PassengerCarOnly = Convert.ToBoolean(r["PassengerCarOnly"]);
					if (!Convert.IsDBNull(r["PosternOnly"]))
						_PosternOnly = Convert.ToBoolean(r["PosternOnly"]);
					if (!Convert.IsDBNull(r["LoadLiftOnly"]))
						_LoadLiftOnly = Convert.ToBoolean(r["LoadLiftOnly"]);
					if (!Convert.IsDBNull(r["PermitLevelID"]))
						_PermitLevelID = Convert.ToInt32(r["PermitLevelID"]);
					_PermitLevelName = r["PermitLevelName"].ToString();
					if (!Convert.IsDBNull(r["PermitLevelValue"]))
						_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);

					_TripExists = Convert.ToBoolean(r["TripExists"]);
					if (!Convert.IsDBNull(r["TripID"]))
						_TripID = Convert.ToInt32(r["TripID"]);

					_ActsExists = Convert.ToBoolean(r["ActsExists"]);

					_NotForJoin = Convert.ToBoolean(r["NotForJoin"]);

					if (!Convert.IsDBNull(r["DateCreate"]))
						_DateCreate = Convert.ToDateTime(r["DateCreate"]);
					if (!Convert.IsDBNull(r["DateAttachToTrip"]))
						_DateAttachToTrip = Convert.ToDateTime(r["DateAttachToTrip"]);
					_ReadyForWMS = Convert.ToBoolean(r["ReadyForWMS"]);
					_SentToWMS = Convert.ToBoolean(r["SentToWMS"]);

					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);

					if (!Convert.IsDBNull(r["DatePick"]))
						_DatePick = Convert.ToDateTime(r["DatePick"]);
					_IsPicked = Convert.ToBoolean(r["IsPicked"]);

					_TPL = Convert.ToBoolean(r["TPL"]);

					_Netto = Convert.ToDecimal(r["Netto"]);
					_Brutto = Convert.ToDecimal(r["Brutto"]);
					_Volume = Convert.ToDecimal(r["Volume"]);
					_PalletsQnt = Convert.ToDecimal(r["PalletsQnt"]);
					_PointsQnt = Convert.ToInt32(r["PointsQnt"]);
					_OutputsDocumentsQnt = Convert.ToInt32(r["OutputsDocumentsQnt"]);

					_DepartmentName = r["DepartmentName"].ToString();

					_Note = r["Note"].ToString();
					_PartnersNames = r["PartnersNames"].ToString();
					_OutputsDocumentsNotes = r["OutputsDocumentsNotes"].ToString();

					_IsCarried = Convert.ToBoolean(r["IsCarried"]);
					_IsCopied = Convert.ToBoolean(r["IsCopied"]);
					if (!Convert.IsDBNull(r["CopiedFromOutputID"]))
						_CopiedFromOutputID = Convert.ToInt32(r["CopiedFromOutputID"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о задании на расход...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о задании на расход (нет данных)...";
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

			_DateOutput = DateTime.Now.Date;
			_DeliveryNeed = false;

			_OutputTypeID = 0;
			_OutputTypeName = null;
			_IsRefund = false;

			_OwnerID = null;
			_OwnerName = null;
			_GoodStateID = null;
			_GoodStateName = null;
			
			_PartnerID = null;
			_PartnerName = null;
			_ZoneID = null;
			_ZoneName = null;
			_ZoneAlias = null;
			_DeliveryAddress = null;
			_DeliveryPassage = null;

			_PassengerCarOnly = null;
			_PosternOnly = null;
			_LoadLiftOnly = null;
			_PermitLevelID = null;
			_PermitLevelName = null;
			_PermitLevelValue = null;

			_TPL = false;

			_TripExists = false;
			_TripID = null;

			_ActsExists = false;

			_NotForJoin = false;

			_DateCreate = null;
			_DateAttachToTrip = null;
			_ReadyForWMS = false;
			_SentToWMS = false;
			
			_DateConfirm = null;
			_IsConfirmed = false;

			_DatePick = null;
			_IsPicked = false;

			_Netto = 0;
			_Brutto = 0;
			_Volume = 0;
			_PalletsQnt = 0;
			_PointsQnt = 0;
			_OutputsDocumentsQnt = 0;

			_DepartmentName = null;

			_Note = "";
			_PartnersNames = "";
			_OutputsDocumentsNotes = "";

			_IsCarried = false;
			_IsCopied = false;
			_CopiedFromOutputID = null;

			_HostID = null;
			_HostName = null;
			
			_ERPCode = null;
		}

		#endregion FillOne


		#region Confirm

		/// <summary>
		/// подтверждение выполнения задания на расход 
		/// </summary>
		public bool Confirm()
		{
			string _sqlCommand = "execute up_OutputsConfirm @nOutputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = _ID;

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
				if (_TableOutputsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(_TableOutputsGoods, "#OutputsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке подтверждения выполнения расхода...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при подтверждении выполнения расхода...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// снятие подтверждения 
		/// </summary>
		public bool UnConfirm()
		{
			string _sqlCommand = "execute up_OutputsUnConfirm @nOutputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnOutputsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = _ID;

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке снятия подтверждения выполнения расхода...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при снятии подтверждении выполнения расхода...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Delete

		/// <summary>
		/// удаление расхода
		/// </summary>
		public bool Delete(int nOutputID)
		{
			String _sqlCommand = "execute up_OutputsDelete @nOutputID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_OutputsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

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
				_ErrorStr = "Ошибка при удалении данных о расходе...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении данных о расходе...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete

		#region Set/Clear dates-times

		#region ReadyForWMS

		/// <summary>
		/// поставить/очистить признак "Задание готово к передаче в складскую систему"
		/// nUserID: не исп.
		/// </summary>
		public bool SetReadyForWMS(int nOutputID)
		{
			return (SetReadyForWMS(nOutputID, false, null));
		}

		public bool SetReadyForWMS(int nOutputID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "execute up_OutputsSetReadyForWMS @nOutputID, @bClear, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_OutputsSetReadyForWMS parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@bClear", SqlDbType.Bit);
			_oParameter.Value = bClear;

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
				_ErrorNumber = -102;
				_ErrorStr = "Ошибка при " + (bClear ? "снятии" : "установке") + " признака \"Готово к передаче в складскую систему\"...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ReadyForWMS

		#region DeliveryNeed

		/// <summary>
		/// поставить/очистить признак "Требуется наша доставка"
		/// nUserID: не исп.
		/// </summary>
		public bool SetDeliveryNeed(int nOutputID)
		{
			return (SetDeliveryNeed(nOutputID, false, null));
		}

		public bool SetDeliveryNeed(int nOutputID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "update Outputs set DeliveryNeed = " +
									(bClear ? "0" : "1") + " " +
									"where ID = " + nOutputID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при " + (bClear ? "снятии" : "установке") + " признака \"Требуется наша доставка\"...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion DeliveryNeed

		#endregion Set/Clear dates-times

		#region ToTrip

		/// <summary>
		/// привязка задания на расход к рейсу
		/// </summary>
		public bool ToTrip(int nTripID)
		{
			if (!_ID.HasValue)
			{
				_ErrorNumber = -111;
				_ErrorStr = "Ошибка при попытке привязки задания на расход к рейсу:\n" +
					"не задан код задания на расход...";
				RFMMessage.MessageBoxError(_ErrorStr);
				return (false);
			}
			return (ToTrip((int)_ID, nTripID));
		}

		public bool ToTrip(int nOutputID, int nTripID)
		{
			string _sqlCommand = "execute up_OutputsToTrip @nOutputID, " +
									"@nTripID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsToTrip parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке привязки задания на расход к рейсу...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при привязке задания на расход к рейсу...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (_ID.HasValue)
						TripID = nTripID;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// снятие привязки задания на расход к рейсу
		/// </summary>
		public bool UnToTrip()
		{
			if (!_ID.HasValue)
			{
				_ErrorNumber = -111;
				_ErrorStr = "Ошибка при попытке снятия привязки задания на расход к рейсу:\n" +
					"не задан код задания на расход...";
				RFMMessage.MessageBoxError(_ErrorStr);
				return (false);
			}
			return (UnToTrip((int)_ID));
		}

		public bool UnToTrip(int nOutputID)
		{
			string _sqlCommand = "execute up_OutputsUnToTrip @nOutputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsUnToTrip parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке снятия привязки задания на расход к рейсу...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при снятии привязки задания на расход к рейсу...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (_ID.HasValue)
						TripID = null;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ToTrip

		#region Calc

		/// <summary>
		/// получение суммарных характеристик для списка заданий 
		/// </summary>
		public bool CalcSum(string sOutputsList,
			ref int nOutputsQnt, ref int nOutputsDocumentsQnt, ref int nPointsQnt,
			ref decimal nNetto, ref decimal nBrutto, ref decimal nVolume, ref decimal nPalletsQnt)
		{
			string sqlSelect = "execute up_OutputsCalcSum @cOutputsList, " +
									"@nOutputsQnt output, " +
									"@nOutputsDocumentsQnt output, " +
									"@nPointsQnt output, " +
									"@nNetto output, " +
									"@nBrutto output, " +
									"@nVolume output, " +
									"@nPalletsQnt output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsList;

			_oParameter = _oCommand.Parameters.Add("@nOutputsQnt", SqlDbType.Int);
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nOutputsDocumentsQnt", SqlDbType.Int);
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nPointsQnt", SqlDbType.Int);
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nNetto", SqlDbType.Decimal);
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nBrutto", SqlDbType.Decimal);
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nVolume", SqlDbType.Decimal);
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nPalletsQnt", SqlDbType.Decimal);
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении суммарных данных по заданиям на расход..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (ErrorNumber == 0)
			{
				nOutputsQnt = Convert.ToInt32(_oCommand.Parameters["@nOutputsQnt"].Value);
				nOutputsDocumentsQnt = Convert.ToInt32(_oCommand.Parameters["@nOutputsDocumentsQnt"].Value);
				nPointsQnt = Convert.ToInt32(_oCommand.Parameters["@nPointsQnt"].Value);
				nNetto = Convert.ToDecimal(_oCommand.Parameters["@nNetto"].Value);
				nBrutto = Convert.ToDecimal(_oCommand.Parameters["@nBrutto"].Value);
				nVolume = Convert.ToDecimal(_oCommand.Parameters["@nVolume"].Value);
				nPalletsQnt = Convert.ToDecimal(_oCommand.Parameters["@nPalletsQnt"].Value);
			}

			return (_ErrorNumber == 0);
		}

		#endregion Calc

		#region ByOrder

		public bool SaveByOrder(int nOutputID, int nByOrder)
		{
			string _sqlCommand = 
				"update Outputs set ByOrder = " + nByOrder.ToString().Trim() + " " + 
					"where ID = " + nOutputID.ToString().Trim() +
				"update OutputsDocuments set ByOrder = " + nByOrder.ToString().Trim() + " " + 
					"where OutputID = " + nOutputID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "Ошибка сохранения порядка загрузки заданий на расход...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ByOrder


		#region Carry

		/// <summary>
		/// перенос задания на расход и всех входящих в него расходных документов на другой день
		/// </summary>
		public bool Carry(int nOutputID, DateTime dNewDate, int? @nOutputDocumentFailReasonID, 
			int? nUserCarryID)
		{
			string _sqlCommand = "execute up_OutputsCarry @nOutputID, " +
					"@dNewDate, " +
					"@nOutputDocumentFailReasonID, " +
					"@nUserCarryID, " +
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsCarry parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@dNewDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dNewDate;

			_oParameter = _oCommand.Parameters.Add("@nOutputDocumentFailReasonID", SqlDbType.Int);
			if (nOutputDocumentFailReasonID.HasValue)
				_oParameter.Value = nOutputDocumentFailReasonID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserCarryID", SqlDbType.Int);
			if (nUserCarryID.HasValue)
				_oParameter.Value = nUserCarryID;
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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке переноса задания на расход на другую дату...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при переносе задания на расход на другую дату...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// копирование (перенос) задания на расход и всех входящих в него расходных документов на другой день
		/// </summary>
		public bool CarryCopy(int nOutputID, DateTime dNewDate, int? @nOutputDocumentFailReasonID,
			int? nUserCarryID, ref int? nNewOutputID)
		{
			string _sqlCommand = "execute up_OutputsCarryCopy @nOutputID, " +
					"@dNewDate, " +
					"@nOutputDocumentFailReasonID, " +
					"@nUserCarryID, " +
					"@nNewOutputID output, " +
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsCarryCopy parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@dNewDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dNewDate;

			_oParameter = _oCommand.Parameters.Add("@nOutputDocumentFailReasonID", SqlDbType.Int);
			if (nOutputDocumentFailReasonID.HasValue)
				_oParameter.Value = nOutputDocumentFailReasonID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserCarryID", SqlDbType.Int);
			if (nUserCarryID.HasValue)
				_oParameter.Value = nUserCarryID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nNewOutputID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке копирования (переноса) задания на расход на другую дату...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при копировании (переносе) задания на расход на другую дату...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (!Convert.IsDBNull(_oCommand.Parameters["@nNewOutputID"].Value))
						nNewOutputID = (int)_oCommand.Parameters["@nNewOutputID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}


		/// <summary>
		/// смена даты задания и всех входящих в него расходных документов на другой день
		/// </summary>
		public bool ChangeDate(int nOutputID, DateTime dNewDate)
		{
			string _sqlCommand = "execute up_OutputsChangeDate @nOutputID, " +
					"@dNewDate, " +
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsChangeDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@dNewDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dNewDate;

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке смены даты задания на расход на другую дату...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при смене даты задания на расход на другую дату...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// отмена переноса задания и всех входящих в него расходных документов и привязка их обратно к рейсу
		/// </summary>
		public bool CarryUnDo(int nOutputID, int nTripID,
			int? nUserUnCarryID)
		{
			string _sqlCommand = "execute up_OutputsCarryUnDo @nOutputID, " +
					"@nTripID, " +
					"@nUserUnCarryID, " +
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsCarryUnDo parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			_oParameter = _oCommand.Parameters.Add("@nUserUnCarryID", SqlDbType.Int);
			if (nUserUnCarryID.HasValue)
				_oParameter.Value = nUserUnCarryID;
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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -13;
				_ErrorStr = "Ошибка при попытке отмены переноса задания на расход...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при отмене переноса задания на расход...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// отмена копирования задания и всех входящих в него расходных документов 
		/// (удаление созданных заданий и документов, возвращение реквизитов в исходные документы)
		/// </summary>
		public bool CarryCopyUnDo(int nOutputID, int nTripID,
			int? nUserUnCarryCopyID)
		{
			string _sqlCommand = "execute up_OutputsCarryCopyUnDo @nOutputID, " +
					"@nTripID, " +
					"@nUserUnCarryCopyID, " +
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsCarryCopyUnDo parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			_oParameter = _oCommand.Parameters.Add("@nUserUnCarryCopyID", SqlDbType.Int);
			if (nUserUnCarryCopyID.HasValue)
				_oParameter.Value = nUserUnCarryCopyID;
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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -14;
				_ErrorStr = "Ошибка при попытке отмены копирования задания на расход...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при отмене копирования задания на расход...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carry

		#region ChangeOutputType

		/// <summary>
		/// перенос задания на расход и всех входящих в него расходных документов на другой день
		/// </summary>
		public bool ChangeOutputType(int nOutputID, int @nOutputTypeID)
		{
			string _sqlCommand = "update Outputs set OutputTypeID = " + nOutputTypeID.ToString().Trim() + " " +
				"where ID = " + @nOutputID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -111;
				_ErrorStr = "Ошибка при попытке изменения типа задания на расход...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ChangeOutputType


		#region Таблицы

		#region OutputsGoods

		/// <summary>
		/// получение таблицы товаров в задании на расход TableOutputsGoods
		/// </summary>
		public bool FillTableOutputsGoods(int nOutputID)
		{
			string sqlSelect = "execute up_OutputsGoodsFill @nOutputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableOutputsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsGoods, "TableOutputsGoods");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке получения списка товаров в задании на расход..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при получении списка товаров в задании на расход...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableOutputsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableOutputsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка товаров в задании на расход...\r\n" +
								"Не определен код задания на расход...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#region с учетом актов

		/// <summary>
		/// получение таблицы товаров в задании на расход TableOutputsGoods - с учетом актов
		/// </summary>
		public bool FillTableOutputsGoodsWithActs(int nOutputID)
		{
			string sqlSelect = "execute up_OutputsGoodsFillWithActs @nOutputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsGoodsFillWithActs parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Value = nOutputID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableOutputsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsGoods, "TableOutputsGoods");
				_TableOutputsGoods.PrimaryKey = new DataColumn[] { _TableOutputsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке получения списка товаров в задании на расход с учетом актов..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при получении списка товаров в задании на расход с учетом актов...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableOutputsGoodsWithActs()
		{
			if (_ID.HasValue)
			{
				FillTableOutputsGoodsWithActs((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка товаров в задании на расход с учетом актов...\r\n" +
								"Не определен код задания на расход...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion с учетом актов

		#endregion OutputsGoods

		#region TTN

		/// <summary>
		/// получение таблицы товаров в расходе (TableOutputsGoods) - в формате для печати документов
		/// </summary>
		public bool FillTTNTableOutputs(string sOutputsList)
		{
			if (sOutputsList == null || sOutputsList.Length == 0)
				return (false);

			string sqlSelect = "execute up_OutputsFillTTN @cOutputsList, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsFillTTN parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsList;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsTTN");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке получения списка расходов для ТТН..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при получении списка расходов для ТТН...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion TTN 

		#region Carries

		/// <summary>
		/// получение списка переносов и копирований для задания (TableOutputsCarries)
		/// </summary>
		public bool FillTableOutputsCarries(int nOutputID)
		{
			string sqlSelect = "execute up_OutputsDocumentsCarriesFill " +
									"@nOutputID = " + nOutputID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsCarries");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "Ошибка при получении списка переносов и копий для расхода..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carries

		#region OutputsTypes

		/// <summary>
		/// получение таблицы типов расходов TableOutputsTypes
		/// </summary>
		public bool FillTableOutputsTypes()
		{
			string sqlSelect =
				"select ID, Name, " +
						"/*OwnerID, GoodStateID,*/ " +
						"ERPCode " +
					"from OutputsTypes " +
					"where 1 = 1 ";
			if (_FilterOutputsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterOutputsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableOutputsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsTypes, "TableOutputsTypes");
				_TableOutputsTypes.PrimaryKey = new DataColumn[] { _TableOutputsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении списка типов расходов..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsTypes

		#endregion Таблицы

	}

#endregion Output

}
