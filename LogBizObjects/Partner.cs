using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Клиент - точка доставки (Partner)
/// </summary>
/// 
namespace LogBizObjects
{

#region Partner

	public class Partner : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID клиентов (Partners.ID)
		/// </summary>
		[Description("Список кодов ID клиентов (Partners.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		/// <summary>
		/// Наименование клиента (Partners.Name)
		/// </summary>
		[Description("Наименование клиента (Partners.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }
		
		#region not used
		/*
		protected string _LegalName;
		/// <summary>
		/// Юридическое наименование (Partners.LegalName)
		/// </summary>
		[Description("Юридическое наименование (Partners.LegalName)")]
		public string LegalName { get { return _LegalName; } set { _LegalName = value; } }

		protected string _LegalAddress;
		/// <summary>
		/// Юридический адрес (Partners.LegalAddress)
		/// </summary>
		[Description("Юридический адрес (Partners.LegalAddress)")]
		public string LegalAddress { get { return _LegalAddress; } set { _LegalAddress = value; } }

		protected string _FactName;
		/// <summary>
		/// Наименование грузоотправителя (Partners.FactName)
		/// </summary>
		[Description("Наименование грузоотправителя (Partners.FactName)")]
		public string FactName { get { return _FactName; } set { _FactName = value; } }

		 * protected string _FactAddress;
		/// <summary>
		/// Фактический адрес (Partners.FactAddress)
		/// </summary>
		[Description("Фактический адрес (Partners.FactAddress)")]
		public string FactAddress { get { return _FactAddress; } set { _FactAddress = value; } }

		protected string _Phone;
		/// <summary>
		/// Телефон (Partners.Phone)
		/// </summary>
		[Description("Телефон (Partners.Phone)")]
		public string Phone { get { return _Phone; } set { _Phone = value; } }

		protected string _Inn;
		/// <summary>
		/// ИНН (Partners.Inn)
		/// </summary>
		[Description("ИНН (Partners.Inn)")]
		public string Inn { get { return _Inn; } set { _Inn = value; } }

		protected string _Kpp;
		/// <summary>
		/// КПП (Partners.Kpp)
		/// </summary>
		[Description("КПП (Partners.Kpp)")]
		public string Kpp { get { return _Kpp; } set { _Kpp = value; } }

		protected string _ContractNumber;
		/// <summary>
		/// № договора (Partners.ContractNumber)
		/// </summary>
		[Description("№ договора (Partners.ContractNumber)")]
		public string ContractNumber { get { return _ContractNumber; } set { _ContractNumber = value; } }

		protected DateTime? _ContractDate;
		/// <summary>
		/// Дата договора (Partners.ContractDate)
		/// </summary>
		[Description("Дата договора (Partners.ContractDate)")]
		public DateTime? ContractDate { get { return _ContractDate; } set { _ContractDate = value; } }

		// Need 
		  
		protected bool _FactureNeed;
		/// <summary>
		/// Требуется счет-фактура (Partners.FactureNeed)?
		/// </summary>
		[Description("Требуется счет-фактура (Partners.FactureNeed)?")]
		public bool FactureNeed { get { return _FactureNeed; } set { _FactureNeed = value; } }

		protected bool _WarrantNeed;
		/// <summary>
		/// Требуется доверенность (Partners.WarrantNeed)?
		/// </summary>
		[Description("Требуется доверенность (Partners.WarrantNeed)?")]
		public bool WarrantNeed { get { return _WarrantNeed; } set { _WarrantNeed = value; } }

		protected bool _PaymentOrderNeed;
		/// <summary>
		/// Требуется платежный ордер (Partners.PaymentOrderNeed)?
		/// </summary>
		[Description("Требуется платежный ордер (Partners.PaymentOrderNeed)?")]
		public bool PaymentOrderNeed { get { return _PaymentOrderNeed; } set { _PaymentOrderNeed = value; } }

		protected bool _OtherDocumentsNeed;
		/// <summary>
		/// Требуется счет-фактура (Partners.OtherDocumentsNeed)?
		/// </summary>
		[Description("Требуется счет-фактура (Partners.OtherDocumentsNeed)?")]
		public bool OtherDocumentsNeed { get { return _OtherDocumentsNeed; } set { _OtherDocumentsNeed = value; } }

		protected bool _QualityLicenceNeed;
		/// <summary>
		/// Требуются удостоверения качества (Partners.QualityLicenceNeed)?
		/// </summary>
		[Description("Требуются удостоверения качества (Partners.QualityLicenceNeed)?")]
		public bool QualityLicenceNeed { get { return _QualityLicenceNeed; } set { _QualityLicenceNeed = value; } }

		protected bool _VeterinaryLicenceNeed;
		/// <summary>
		/// Требуется ветеринарные свидетельства (Partners.VeterinaryLicenceNeed)?
		/// </summary>
		[Description("Требуется ветеринарные свидетельства (Partners.VeterinaryLicenceNeed)?")]
		public bool VeterinaryLicenceNeed { get { return _VeterinaryLicenceNeed; } set { _VeterinaryLicenceNeed = value; } }

		// Bank
		protected string _BankName;
		/// <summary>
		/// Банк (Partners.BankName)
		/// </summary>
		[Description("Банк (Partners.BankName)")]
		public string BankName { get { return _BankName; } set { _BankName = value; } }

		protected string _BankAddress;
		/// <summary>
		/// Банк (Partners.BankAddress)
		/// </summary>
		[Description("Банк (Partners.BankAddress)")]
		public string BankAddress { get { return _BankAddress; } set { _BankAddress = value; } }

		protected string _PAccount;
		/// <summary>
		/// Расчетный счет (Partners.PAccount)
		/// </summary>
		[Description("Расчетный счет (Partners.PAccount)")]
		public string PAccount { get { return _PAccount; } set { _PAccount = value; } }

		protected string _CAccount;
		/// <summary>
		/// Корреспондентский счет (Partners.CAccount)
		/// </summary>
		[Description("Корреспондентский счет (Partners.CAccount)")]
		public string CAccount { get { return _CAccount; } set { _CAccount = value; } }

		protected string _Bik;
		/// <summary>
		/// БИК (Partners.Bik)
		/// </summary>
		[Description("БИК (Partners.Bik)")]
		public string Bik { get { return _Bik; } set { _Bik = value; } }

		protected string _Okonh;
		/// <summary>
		/// ОКОНХ (Partners.Okonh)
		/// </summary>
		[Description("ОКОНХ (Partners.Okonh)")]
		public string Okonh { get { return _Okonh; } set { _Okonh = value; } }

		protected string _Okpo;
		/// <summary>
		/// ОКПО (Partners.Okpo)
		/// </summary>
		[Description("ОКПО (Partners.Okpo)")]
		public string Okpo { get { return _Okpo; } set { _Okpo = value; } }
		
		// job, fio
		protected string _JobTitleDirector;
		/// <summary>
		/// Должность руководителя (Partners.JobTitleDirector)
		/// </summary>
		[Description("Должность руководителя (Partners.JobTitleDirector)")]
		public string JobTitleDirector { get { return _JobTitleDirector; } set { _JobTitleDirector = value; } }

		protected string _FioDirector;
		/// <summary>
		/// ФИО руководителя (Partners.FioDirector)
		/// </summary>
		[Description("ФИО руководителя (Partners.FioDirector)")]
		public string FioDirector { get { return _FioDirector; } set { _FioDirector = value; } }

		protected string _JobTitleAccountant;
		/// <summary>
		/// Должность лица с финансовой подписью (Partners.JobTitleAccountant)
		/// </summary>
		[Description("Должность лица с финансовой подписью (Partners.JobTitleAccountant)")]
		public string JobTitleAccountant { get { return _JobTitleAccountant; } set { _JobTitleAccountant = value; } }

		protected string _FioAccountant;
		/// <summary>
		/// ФИО лица с финансовой подписью (Partners.FioAccountant)
		/// </summary>
		[Description("ФИО лица с финансовой подписью (Partners.FioAccountant)")]
		public string FioAccountant { get { return _FioAccountant; } set { _FioAccountant = value; } }
		*/
		#endregion not used

		protected int? _PartnerRootID;
		/// <summary>
		/// Объединение клиентов - код (Partners.PartnerRootID)
		/// </summary>
		[Description("Объединение клиентов - код (Partners.PartnerRootID)")]
		public int? PartnerRootID { get { return _PartnerRootID; } set { _PartnerRootID = value; } }

		protected string _PartnerRootName;
		/// <summary>
		/// Объединение клиентов - наименование (Partners.PartnerRootID -> PartnersRoots.Name)
		/// </summary>
		[Description("Объединение клиентов - наименование (Partners.PartnerRootID -> PartnersRoots.Name)")]
		public string PartnerRootName { get { return _PartnerRootName; } set { _PartnerRootName = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// Зона доставки - код (Partners.ZoneID)
		/// </summary>
		[Description("Зона доставки - код (Partners.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// Зона доставки - наименование (Partners.ZoneID -> Zones.Name)
		/// </summary>
		[Description("Зона доставки - наименование (Partners.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected int? _PermitLevelID;
		/// <summary>
		/// Разрешение проезда - код (Partners.PermitLevelID)
		/// </summary>
		[Description("Разрешение проезда - код (Partners.PermitLevelID)")]
		public int? PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// Разрешение проезда - наименование (Partners.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("Разрешение проезда - наименование (Partners.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int? _PermitLevelValue;
		/// <summary>
		/// Разрешение проезда - уровень, не менее (Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Разрешение проезда - уровень, не менее (Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int? PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected string _DeliveryAddress;
		/// <summary>
		/// Адрес доставки (Partners.DeliveryAddress)
		/// </summary>
		[Description("Адрес доставки (Partners.DeliveryAddress)")]
		public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

		protected string _DeliveryPassage;
		/// <summary>
		/// Проезд к адресу доставки (Partners.DeliveryPassage)
		/// </summary>
		[Description("Проезд к адресу доставки (Partners.DeliveryPassage)")]
		public string DeliveryPassage { get { return _DeliveryPassage; } set { _DeliveryPassage = value; } }

		protected string _DeliveryRestriction;
		/// <summary>
		/// Ограничения по проезду к адресу доставки (Partners.DeliveryRestriction)
		/// </summary>
		[Description("Ограничения по проезду к адресу доставки (Partners.DeliveryRestriction)")]
		public string DeliveryRestriction { get { return _DeliveryRestriction; } set { _DeliveryRestriction = value; } }

		protected string _Gravity;
		/// <summary>
		/// Важность (Partners.Gravity)
		/// </summary>
		[Description("Важность (Partners.Gravity)")]
		public string Gravity { get { return _Gravity; } set { _Gravity = value; } }

		protected int? _CoordinatesX;
		/// <summary>
		/// Географическая координата X (Zones.CoordinatesX)
		/// </summary>
		[Description("Географическая координата X (Zones.CoordinatesX)")]
		public int? CoordinatesX { get { return _CoordinatesX; } set { _CoordinatesX = value; } }

		protected int? _CoordinatesY;
		/// <summary>
		/// Географическая координата Y (Zones.CoordinatesY)
		/// </summary>
		[Description("Географическая координата Y (Zones.CoordinatesY)")]
		public int? CoordinatesY { get { return _CoordinatesY; } set { _CoordinatesY = value; } }

        protected decimal? _Latitude;
        /// <summary>
        /// Географическая широта (Partners.Latitude)
        /// </summary>
        [Description("Географическая широта (Partners.Latitude)")]
        public decimal? Latitude { get { return _Latitude; } set { _Latitude = value; } }

        protected decimal? _Longitude;
        /// <summary>
        /// Географическая долгота (Partners.Longitude)
        /// </summary>
        [Description("Географическая широта (Partners.Longitude)")]
        public decimal? Longitude { get { return _Longitude; } set { _Longitude = value; } }

        protected byte[] _DrivingScheme;
        /// <summary>
        /// Схема проезда (Partners.DrivingScheme)
        /// </summary>
        [Description("Фото пользователя (_Users.Photo)")]
        public byte[] DrivingScheme { get { return _DrivingScheme; } set { _DrivingScheme = value; } }

        protected string _Okato;
		/// <summary>
		/// Код ОКАТО (Partners.Okato)
		/// </summary>
		[Description("Код ОКАТО (Partners.Okato)")]
		public string Okato { get { return _Okato; } set { _Okato = value; } }

		protected bool _PassengerCarOnly;
		/// <summary>
		/// Доставка только легковой машиной (Partners.PassengerCarOnly)?
		/// </summary>
		[Description("Доставка только легковой машиной (Partners.PassengerCarOnly)?")]
		public bool PassengerCarOnly { get { return _PassengerCarOnly; } set { _PassengerCarOnly = value; } }

		protected bool _PosternOnly;
		/// <summary>
		/// Доставка только машиной с задней дверью (Partners.PosternOnly)?
		/// </summary>
		[Description("Доставка только машиной с задней дверью (Partners.PosternOnly)?")]
		public bool PosternOnly { get { return _PosternOnly; } set { _PosternOnly = value; } }

		protected bool _LoadLiftOnly;
		/// <summary>
		/// Доставка только машиной с подъемником (лопатой) (Partners.LoadLiftOnly)?
		/// </summary>
		[Description("Доставка только машиной с подъемником (лопатой) (Partners.LoadLiftOnly)?")]
		public bool LoadLiftOnly { get { return _LoadLiftOnly; } set { _LoadLiftOnly = value; } }

		protected bool _DateValidControl;
		/// <summary>
		/// Контроль сроков годности при загрузке (Partners.DateValidControl)?
		/// </summary>
		[Description("Контроль сроков годности при загрузке (Partners.DateValidControl)?")]
		public bool DateValidControl { get { return _DateValidControl; } set { _DateValidControl = value; } }

		protected bool _PalletsAgreement;
		/// <summary>
		/// Соглашение на возврат паллет (Partners.PalletsAgreement)?
		/// </summary>
		[Description("Соглашение на возврат паллет (Partners.PalletsAgreement)?")]
		public bool PalletsAgreement { get { return _PalletsAgreement; } set { _PalletsAgreement = value; } }

		protected bool _FactPaymentOnly;
		/// <summary>
		/// Оплата строго по факту (Partners.FactPaymentOnly)?
		/// </summary>
		[Description("Оплата строго по факту (Partners.FactPaymentOnly)?")]
		public bool FactPaymentOnly { get { return _FactPaymentOnly; } set { _FactPaymentOnly = value; } }

		protected string _TimeWork;
		/// <summary>
		/// Время работы (Partners.TimeWork)
		/// </summary>
		[Description("Время работы (Partners.TimeWork)")]
		public string TimeWork { get { return _TimeWork; } set { _TimeWork = value; } }

		protected string _TimeReceipt;
		/// <summary>
		/// Время приема товара (Partners.TimeReceipt)
		/// </summary>
		[Description("Время приема товара (Partners.TimeReceipt)")]
		public string TimeReceipt { get { return _TimeReceipt; } set { _TimeReceipt = value; } }

		protected string _TimePay;
		/// <summary>
		/// Время оплаты (Partners.TimePay)
		/// </summary>
		[Description("Время оплаты (Partners.TimePay)")]
		public string TimePay { get { return _TimePay; } set { _TimePay = value; } }

		protected string _TimeRest;
		/// <summary>
		/// Время перерыва (Partners.TimeRest)
		/// </summary>
		[Description("Время перерыва (Partners.TimeRest)")]
		public string TimeRest { get { return _TimeRest; } set { _TimeRest = value; } }

		protected int _StayMinutes;
		/// <summary>
		/// Среднее время пребывания у клиента (простоя), мин. (Partners.StayMinutes)
		/// </summary>
		[Description("Среднее время пребывания у клиента (простоя), мин. (Partners.StayMinutes)")]
		public int StayMinutes { get { return _StayMinutes; } set { _StayMinutes = value; } }

        protected int _Distance;
        /// <summary>
        /// Расстояние до клиента, км (Partners.Distance)
        /// </summary>
        [Description("Расстояние до клиента, км (Partners.Distance)")]
        public int Distance { get { return _Distance; } set { _Distance = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания (Partners.Note)
		/// </summary>
		[Description("Примечания (Partners.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _ContactsInfo;
		/// <summary>
		/// Контакты (ФИО, должность, тел.) (Partners.ContactsInfo)
		/// </summary>
		[Description("Контакты (ФИО, должность, тел.) (Partners.ContactsInfo)")]
		public string ContactsInfo { get { return _ContactsInfo; } set { _ContactsInfo = value; } }

		protected bool _IsCustomer;
		/// <summary>
		/// Покупатель (Partners.IsCustomer)?
		/// </summary>
		[Description("Покупатель (Partners.IsCustomer)?")]
		public bool IsCustomer { get { return _IsCustomer; } set { _IsCustomer = value; } }

		protected bool _IsSupplier;
		/// <summary>
		/// Поставщик (Partners.IsSupplier)?
		/// </summary>
		[Description("Поставщик (Partners.IsSupplier)?")]
		public bool IsSupplier { get { return _IsSupplier; } set { _IsSupplier = value; } }

		protected bool _IsTransport;
		/// <summary>
		/// Транспортная компания (Partners.IsTransport)?
		/// </summary>
		[Description("Транспортная компания (Partners.IsTransport)?")]
		public bool IsTransport { get { return _IsTransport; } set { _IsTransport = value; } }

		protected bool _IsOwner;
		/// <summary>
		/// Является владельцем (хранителем) товара (Partners.IsOwner)?
		/// </summary>
		[Description("Является владельцем (хранителем) товара (Partners.IsOwner)?")]
		public bool IsOwner { get { return _IsOwner; } set { _IsOwner = value; } }

		protected bool _SeparatePicking;
		/// <summary>
		/// Раздельное хранение товара (владелец-непофигист) (Partners.SeparatePicking)?
		/// </summary>
		[Description("Раздельное хранение товара (владелец-непофигист) (Partners.SeparatePicking)?")]
		public bool SeparatePicking { get { return _SeparatePicking; } set { _SeparatePicking = value; } }

		protected bool _PartnersGoodsExists;
		/// <summary>
		/// Есть спец.данные о товарах (Partners.ID -> PartnersGoods.PartnerID)?
		/// </summary>
		[Description("Есть спец.данные о товарах (Partners.ID -> PartnersGoods.PartnerID)?")]
		public bool PartnersGoodsExists { get { return _PartnersGoodsExists; } set { _PartnersGoodsExists = value; } }

        #region Шаблоны печатных форм: поля, свойства

		protected string _PF_BillName;
		/// <summary>
		/// Собственный шаблон накладной - название (Partners.RF_BillName)
		/// </summary>
		[Description("Собственный шаблон накладной - название (Partners.PF_BillName)")]
		public string PF_BillName { get { return _PF_BillName; } set { _PF_BillName = value; } }

		protected int _PF_BillCopiesCount;
		/// <summary>
		/// Число копий накладной (Partners.PF_BillCopiesCount)
		/// </summary>
		[Description("Число копий накладной (Partners.PF_BillCopiesCount)")]
		public int PF_BillCopiesCount { get { return _PF_BillCopiesCount; } set { _PF_BillCopiesCount = value; } }

		protected string _PF_FactureName;
		/// <summary>
		/// Собственный шаблон счета-фактуры - название (Partners.RF_FactureName)
		/// </summary>
		[Description("Собственный шаблон счета-фактуры - название (Partners.PF_FactureName)")]
		public string PF_FactureName { get { return _PF_FactureName; } set { _PF_FactureName = value; } }

		protected int _PF_FactureCopiesCount;
		/// <summary>
		/// Число копий счета-фактуры (Partners.PF_FactureCopiesCount)
		/// </summary>
		[Description("Число копий счета-фактуры (Partners.PF_FactureCopiesCount)")]
		public int PF_FactureCopiesCount { get { return _PF_FactureCopiesCount; } set { _PF_FactureCopiesCount = value; } }

		protected string _PF_PayBillName;
		/// <summary>
		/// Собственный шаблон счета на оплату - название (Partners.RF_PayBillName)
		/// </summary>
		[Description("Собственный шаблон счета на оплату - название (Partners.PF_PayBillName)")]
		public string PF_PayBillName { get { return _PF_PayBillName; } set { _PF_PayBillName = value; } }

		protected int _PF_PayBillCopiesCount;
		/// <summary>
		/// Число копий счета на оплату (Partners.PF_PayBillCopiesCount)
		/// </summary>
		[Description("Число копий счета на оплату (Partners.PF_PayBillCopiesCount)")]
		public int PF_PayBillCopiesCount { get { return _PF_PayBillCopiesCount; } set { _PF_PayBillCopiesCount = value; } }

		// ...

		#endregion Шаблоны печатных форм: поля, свойства

		protected string _ShopCode;
		/// <summary>
		/// Код(№) магазина в сети (Partners.ShopCode)
		/// </summary>
		[Description("Код(№) магазина в сети (Partners.ShopCode)")]
		public string ShopCode { get { return _ShopCode; } set { _ShopCode = value; } }

        protected string _VeterinaryPartnerName;
        /// <summary>
        /// Наименование партнера в бланке вет. свидетельства
        /// </summary>
        [Description("Наименование партнера в бланке вет. свидетельства (Partners.VeterinaryPartnerName)")]
        public string VeterinaryPartnerName { get { return _VeterinaryPartnerName; } set { _VeterinaryPartnerName = value; } }

        protected string _VeterinaryPermission;
        /// <summary>
        /// № и дата разрешения в бланке вет. свидетельства
        /// </summary>
        [Description("№ и дата разрешения в бланке вет. свидетельства (Partners.VeterinaryPermission)")]
        public string VeterinaryPermission { get { return _VeterinaryPermission; } set { _VeterinaryPermission = value; } }

        protected bool _Actual;
		/// <summary>
		/// Актуально (Partners.Actual)?
		/// </summary>
		[Description("Актуально (Partners.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - код (Partners.HostID)
		/// </summary>
		[Description("Host  - код (Partners.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - наименование (Partners.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - наименование (Partners.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// Код клиента в host-системе (Partners.ERPCode)
		/// </summary>
		[Description("Код клиента в host-системе (Partners.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterHostsList;
		/// <summary>
		/// Фильтр-поле: список кодов host-ов, через запятую (Partners.HostID)
		/// </summary>
		[Description("Фильтр-поле: список хостов, через запятую (Partners.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected string _FilterNameContext;
		/// <summary>
		/// Фильтр-поле: контекст названия (Partners.Name)
		/// </summary>
		[Description("Фильтр-поле: контекст названия (Partners.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		protected string _FilterPartnersRootsList;
		/// <summary>
		/// Фильтр-поле: список кодов объединений клиентов, через запятую (Partners.PartnerRootID)
		/// </summary>
		[Description("Фильтр-поле: список кодов объединений клиентов, через запятую (Partners.PartnerRootID)")]
		public string FilterPartnersRootsList { get { return _FilterPartnersRootsList; } set { _FilterPartnersRootsList = value; _NeedRequery = true; } }

		protected string _FilterZonesList;
		/// <summary>
		/// Фильтр-поле: список кодов зон, через запятую (Partners.ZoneID)
		/// </summary>
		[Description("Фильтр-поле: список кодов зон, через запятую (Partners.ZoneID)")]
		public string FilterZonesList { get { return _FilterZonesList; } set { _FilterZonesList = value; _NeedRequery = true; } }

		protected bool? _FilterActual;
		/// <summary>
		/// Фильтр-поле: актуальные клиенты (Partners.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуальные клиенты (Partners.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

		protected bool? _FilterIsSupplier;
		/// <summary>
		/// Фильтр-поле: поставщик (Partners.IsSupplier)?
		/// </summary>
		[Description("Фильтр-поле: поставщик (Partners.IsSupplier)?")]
		public bool? FilterIsSupplier { get { return _FilterIsSupplier; } set { _FilterIsSupplier = value; _NeedRequery = true; } }

		protected bool? _FilterIsCustomer;
		/// <summary>
		/// Фильтр-поле: покупатель (Partners.IsCustomer)?
		/// </summary>
		[Description("Фильтр-поле: покупатель (Partners.IsCustomer)?")]
		public bool? FilterIsCustomer { get { return _FilterIsCustomer; } set { _FilterIsCustomer = value; _NeedRequery = true; } }

		protected bool? _FilterIsTransport;
		/// <summary>
		/// Фильтр-поле: транспортная компания (Partners.IsTransport)?
		/// </summary>
		[Description("Фильтр-поле: транспортная компания (Partners.IsTransport)?")]
		public bool? FilterIsTransport { get { return _FilterIsTransport; } set { _FilterIsTransport = value; _NeedRequery = true; } }

		protected bool? _FilterIsOwner;
		/// <summary>
		/// Фильтр-поле: является владельцем (хранителем) товара (Partners.IsOwner)?
		/// </summary>
		[Description("Фильтр-поле: мы (Partners.IsOwner)?")]
		public bool? FilterIsOwner { get { return _FilterIsOwner; } set { _FilterIsOwner = value; _NeedRequery = true; } }

		protected bool? _FilterSeparatePicking;
		/// <summary>
		/// Фильтр-поле: раздельное хранение товара (владелец-непофигист) (Partners.SeparatePicking)?
		/// </summary>
		[Description("Фильтр-поле: раздельное хранение товара (владелец-непофигист) (Partners.SeparatePicking)?")]
		public bool? FilterSeparatePicking { get { return _FilterSeparatePicking; } set { _FilterSeparatePicking = value; _NeedRequery = true; } }
		

		protected bool? _FilterPassengerCarOnly;
		/// <summary>
		/// Фильтр-поле: только легковая машина (Partners.PassengerCarOnly)?
		/// </summary>
		[Description("Фильтр-поле: только легковая машина (Partners.PassengerCarOnly)?")]
		public bool? FilterPassengerCarOnly { get { return _FilterPassengerCarOnly; } set { _FilterPassengerCarOnly = value; _NeedRequery = true; } }

		protected bool? _FilterPosternOnly;
		/// <summary>
		/// Фильтр-поле: только машина с задней дверью (Partners.PosternOnly)?
		/// </summary>
		[Description("Фильтр-поле: только машина с задней дверью (Partners.PosternOnly)?")]
		public bool? FilterPosternOnly { get { return _FilterPosternOnly; } set { _FilterPosternOnly = value; _NeedRequery = true; } }

		protected bool? _FilterLoadLiftOnly;
		/// <summary>
		/// Фильтр-поле: только машина с подъемником-лопатой (Partners.LoadLiftOnly)?
		/// </summary>
		[Description("Фильтр-поле: только машина с подъемником-лопатой (Partners.LoadLiftOnly)?")]
		public bool? FilterLoadLiftOnly { get { return _FilterLoadLiftOnly; } set { _FilterLoadLiftOnly = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// Фильтр-поле: разрешение проезда - уровень, не ниже (Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Фильтр-поле: разрешение проезда - уровень, не ниже (Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		protected bool? _FilterPartnersGoodsExists;
		/// <summary>
		/// Фильтр-поле: для клиента есть спец.данные о товарах (Partners.ID -> PartnersGoods.PartnerID)?
		/// </summary>
		[Description("Фильтр-поле: для клиента есть спец.данные о товарах (Partners.ID -> PartnersGoods.PartnerID)?")]
		public bool? FilterPartnersGoodsExists { get { return _FilterPartnersGoodsExists; } set { _FilterPartnersGoodsExists = value; _NeedRequery = true; } }

		protected string _FilterInnContext;
		/// <summary>
		/// Фильтр-поле: контекст ИНН (Partners -> PartnersDetails.Inn)
		/// </summary>
		[Description("Фильтр-поле: контекст ИНН (Partners -> PartnersDetails.Inn)")]
		public string FilterInnContext { get { return _FilterInnContext; } set { _FilterInnContext = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TablePartnersTree;
		/// <summary>
		/// Таблица для отображения клиентов в виде дерева PartnersTree
		/// </summary>
		[Description("Таблица для отображения клиентов в виде дерева PartnersTree")]
		public DataTable TablePartnersTree { get { return _TablePartnersTree; } }

		protected DataTable _TablePartnersDetails;
		/// <summary>
		/// Таблица реквизитов PartnersDetails
		/// </summary>
		[Description("Таблица реквизитов PartnersDetails")]
		public DataTable TablePartnersDetails { get { return _TablePartnersDetails; } }

		protected DataTable _TablePartnersRoots;
		/// <summary>
		/// Таблица объединений клиентов PartnersRoots
		/// </summary>
		[Description("Таблица объединений клиентов PartnersRoots")]
		public DataTable TablePartnersRoots { get { return _TablePartnersRoots; } }

		protected DataTable _TablePartnersGoods;
		/// <summary>
		/// Таблица спец.данных о товарах для клиента PartnersGoods
		/// </summary> 
		[Description("Таблица спец.данных о товарах для клиента PartnersGoods")]
		public DataTable TablePartnersGoods { get { return _TablePartnersGoods; } }

		#endregion Таблицы

		// ----------------------------

		public Partner()
			: base()
		{
			_MainTableName = "Partners";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}


		#region FillData

		/// <summary>
		/// получение полного списка клиентов с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_PartnersFill @nID, @cIDList, " +
									"@cHostsList, " +
									"@cNameContext, " +
									"@cPartnersRootsList, " +
									"@cZonesList, " +
									"@bActual, " +
									"@bIsCustomer, @bIsSupplier, @bIsTransport, @bIsOwner, @bSeparatePicking, " +
									"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
									"@nPermitLevelValueMin, " + 
									"@bPartnersGoodsExists, " +
									"@cInnContext ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PartnersFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cHostsList", SqlDbType.VarChar);
			if (_FilterHostsList != null)
				_oParameter.Value = _FilterHostsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersRootsList", SqlDbType.VarChar);
			if (_FilterPartnersRootsList != null)
				_oParameter.Value = _FilterPartnersRootsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cZonesList", SqlDbType.VarChar);
			if (_FilterZonesList != null)
				_oParameter.Value = _FilterZonesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterActual != null)
				_oParameter.Value = _FilterActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsCustomer", SqlDbType.Bit);
			if (_FilterIsCustomer != null)
				_oParameter.Value = _FilterIsCustomer;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsSupplier", SqlDbType.Bit);
			if (_FilterIsSupplier != null)
				_oParameter.Value = _FilterIsSupplier;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsTransport", SqlDbType.Bit);
			if (_FilterIsTransport != null)
				_oParameter.Value = _FilterIsTransport;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOwner", SqlDbType.Bit);
			if (_FilterIsOwner != null)
				_oParameter.Value = _FilterIsOwner;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bSeparatePicking", SqlDbType.Bit);
			if (_FilterSeparatePicking != null)
				_oParameter.Value = _FilterSeparatePicking;
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

			_oParameter = _oCommand.Parameters.Add("@bPartnersGoodsExists", SqlDbType.Bit);
			if (_FilterPartnersGoodsExists != null)
				_oParameter.Value = _FilterPartnersGoodsExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInnContext", SqlDbType.VarChar);
			if (_FilterInnContext != null)
				_oParameter.Value = _FilterInnContext;
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
				_ErrorStr = "Ошибка при получении списка клиентов..." + Convert.ToChar(13) + ex.Message;
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

			_FilterNameContext = null;
			_FilterInnContext = null;
			_FilterPartnersRootsList = null;
			_FilterZonesList = null;
			_FilterActual = null;
			_FilterIsSupplier = null;
			_FilterIsCustomer = null;
			_FilterIsTransport = null;
			_FilterIsOwner = null;
			_FilterSeparatePicking = null;
			_FilterPassengerCarOnly = null;
			_FilterPosternOnly = null;
			_FilterLoadLiftOnly = null;
			_FilterPermitLevelValueMin = null;
			_FilterPartnersGoodsExists = null;
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

					 if (!Convert.IsDBNull(r["PartnerRootID"]))
						_PartnerRootID = Convert.ToInt32(r["PartnerRootID"]);
					_PartnerRootName = r["PartnerRootName"].ToString();

					if (!Convert.IsDBNull(r["ZoneID"]))
						_ZoneID = Convert.ToInt32(r["ZoneID"]);
					_ZoneName = r["ZoneName"].ToString();

					if (!Convert.IsDBNull(r["PermitLevelID"]))
					{
						_PermitLevelID = Convert.ToInt32(r["PermitLevelID"]);
						_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);
					}
					_PermitLevelName = r["PermitLevelName"].ToString();

					_DeliveryAddress = r["DeliveryAddress"].ToString();
					_DeliveryPassage = r["DeliveryPassage"].ToString();
					_DeliveryRestriction = r["DeliveryRestriction"].ToString();
					
					_Gravity = r["Gravity"].ToString();

					if (!Convert.IsDBNull(r["CoordinatesX"]))
						_CoordinatesX = Convert.ToInt32(r["CoordinatesX"]);
					if (!Convert.IsDBNull(r["CoordinatesY"]))
						_CoordinatesY = Convert.ToInt32(r["CoordinatesY"]);

                    if (!Convert.IsDBNull(r["Latitude"]))
                        _Latitude = Convert.ToDecimal(r["Latitude"]);
                    if (!Convert.IsDBNull(r["Longitude"]))
                        _Longitude = Convert.ToDecimal(r["Longitude"]);

                    _DrivingScheme = r["DrivingScheme"] as byte[];

					_Okato = r["Okato"].ToString();

					_PassengerCarOnly = Convert.ToBoolean(r["PassengerCarOnly"]);
					_PosternOnly = Convert.ToBoolean(r["PosternOnly"]);
					_LoadLiftOnly = Convert.ToBoolean(r["LoadLiftOnly"]);
					_DateValidControl = Convert.ToBoolean(r["DateValidControl"]);
					_PalletsAgreement = Convert.ToBoolean(r["PalletsAgreement"]);
					_FactPaymentOnly = Convert.ToBoolean(r["FactPaymentOnly"]);

					#region not used
					/*
					_LegalName = r["LegalName"].ToString();
					_LegalAddress = r["LegalAddress"].ToString();
					_FactName = r["FactName"].ToString();
					_FactAddress = r["FactAddress"].ToString();
					_Phone = r["Phone"].ToString();
					
					_Inn = r["Inn"].ToString();
					_Kpp = r["Kpp"].ToString();

					_ContractNumber = r["ContractNumber"].ToString();
					if (!Convert.IsDBNull(r["ContractDate"]))
						_ContractDate = Convert.ToDateTime(r["ContractDate"]);
					 
					_FactureNeed = Convert.ToBoolean(r["FactureNeed"]);
					_WarrantNeed = Convert.ToBoolean(r["WarrantNeed"]);
					_PaymentOrderNeed = Convert.ToBoolean(r["PaymentOrderNeed"]);
					_OtherDocumentsNeed = Convert.ToBoolean(r["OtherDocumentsNeed"]);
					_QualityLicenceNeed = Convert.ToBoolean(r["QualityLicenceNeed"]);
					_VeterinaryLicenceNeed = Convert.ToBoolean(r["VeterinaryLicenceNeed"]);

					_BankName = r["BankName"].ToString();
					_BankAddress = r["BankAddress"].ToString();
					_CAccount = r["CAccount"].ToString();
					_PAccount = r["PAccount"].ToString();
					_Bik = r["Bik"].ToString();
					_Okonh = r["Okonh"].ToString();
					_Okpo = r["Okpo"].ToString();

					_JobTitleDirector = r["JobTitleDirector"].ToString();
					_FioDirector = r["FioDirector"].ToString();
					_JobTitleAccountant = r["JobTitleAccountant"].ToString();
					_FioAccountant = r["FioAccountant"].ToString();
					*/
					#endregion not used

					_TimeWork = r["TimeWork"].ToString();
					_TimeReceipt = r["TimeReceipt"].ToString();
					_TimePay = r["TimePay"].ToString();
					_TimeRest = r["TimeRest"].ToString();
					_StayMinutes = Convert.ToInt32(r["StayMinutes"]);
                    _Distance = Convert.ToInt32(r["Distance"]);

					_IsSupplier = Convert.ToBoolean(r["IsSupplier"]);
					_IsCustomer = Convert.ToBoolean(r["IsCustomer"]);
					_IsTransport = Convert.ToBoolean(r["IsTransport"]);
					_IsOwner = Convert.ToBoolean(r["IsOwner"]);
					_SeparatePicking = Convert.ToBoolean(r["SeparatePicking"]);

					_PartnersGoodsExists = Convert.ToBoolean(r["PartnersGoodsExists"]);

					_ContactsInfo = r["ContactsInfo"].ToString();
					_Note = r["Note"].ToString();

					// шаблоны печ.форм
					if (!Convert.IsDBNull(r["PF_BillName"]))
						_PF_BillName = r["PF_BillName"].ToString();
					if (!Convert.IsDBNull(r["PF_BillCopiesCount"]))
						_PF_BillCopiesCount = Convert.ToInt32(r["PF_BillCopiesCount"]);
					if (!Convert.IsDBNull(r["PF_FactureName"]))
						_PF_FactureName = r["PF_FactureName"].ToString();
					if (!Convert.IsDBNull(r["PF_FactureCopiesCount"]))
						_PF_FactureCopiesCount = Convert.ToInt32(r["PF_FactureCopiesCount"]);
					if (!Convert.IsDBNull(r["PF_PayBillName"]))
						_PF_PayBillName = r["PF_PayBillName"].ToString();
					if (!Convert.IsDBNull(r["PF_PayBillCopiesCount"]))
						_PF_PayBillCopiesCount = Convert.ToInt32(r["PF_PayBillCopiesCount"]);

					if (!Convert.IsDBNull(r["ShopCode"]))
						_ShopCode = r["ShopCode"].ToString();

                    _VeterinaryPartnerName = r["VeterinaryPartnerName"].ToString();
                    _VeterinaryPermission = r["VeterinaryPermission"].ToString();

					_Actual = Convert.ToBoolean(r["Actual"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();
					
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о клиенте...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о клиенте (нет данных)...";
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
			_Name = null;

			_PartnerRootID = null;
			_PartnerRootName = null;

			_ZoneID = null;
			_ZoneName = null;

			_PermitLevelID = null;
			_PermitLevelName = null;
			_PermitLevelValue = 0;

			_DeliveryAddress = null;
			_DeliveryPassage = null;
			_DeliveryRestriction = null;

			_Gravity = null;

			_CoordinatesX = null;
			_CoordinatesY = null;

            _Latitude = null;
            _Longitude = null;

            _DrivingScheme = null;

			_Okato = null;
			
			_PassengerCarOnly = false;
			_PosternOnly = false;
			_LoadLiftOnly = false;
			_DateValidControl = false;
			_PalletsAgreement = false;
			_FactPaymentOnly = false;

			_TimeWork = null;
			_TimeReceipt = null;
			_TimePay = null;
			_TimeRest = null;
			_StayMinutes = 0;
            _Distance = 0;

			_IsSupplier = false;
			_IsCustomer = false;
			_IsTransport = false;
			_IsOwner = false;
			_SeparatePicking = false;

			_PartnersGoodsExists = false;

			_ContactsInfo = null;
			_Note = null;

			_PF_BillName = null;
			_PF_BillCopiesCount = 0;
			_PF_FactureName = null;
			_PF_FactureCopiesCount = 0;
			_PF_PayBillName = null;
			_PF_PayBillCopiesCount = 0;

			_ShopCode = null;

            _VeterinaryPartnerName = string.Empty;
            _VeterinaryPermission = string.Empty;

			_Actual = false;

			_HostID = null;
			_HostName = null;

			_ERPCode = null; 
		}

		#endregion FillOne

		#region Таблицы

		/// <summary>
		/// получение таблицы реквизитов
		/// </summary>
		/// 
		public bool FillTablePartnersDetails()
		{
			return (FillTablePartnersDetails(null, null, null));
		}

		public bool FillTablePartnersDetails(int nPartnerID)
		{
			return (FillTablePartnersDetails(null, null, nPartnerID));
		}

		public bool FillTablePartnersDetails(int? nPartnerDetailID, int? nPartnerID)
		{
			return (FillTablePartnersDetails(nPartnerDetailID, null, nPartnerID));
		}

		public bool FillTablePartnersDetails(int? nPartnerDetailID, string sPartnersDetailList, int? nPartnerID)
		{
			if (TablePartnersDetails != null && _DS.Tables.Contains("TablePartnersDetails"))
				_DS.Tables.Remove("TablePartnersDetails"); 

			string sqlSelect = "execute up_PartnersDetailsFill @nID, @cIDList, " +
									"@nPartnerID, @cPartnersList, " +
									"@cInnContext ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PartnersDetailsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (nPartnerDetailID != null)
				_oParameter.Value = nPartnerDetailID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cIDList", SqlDbType.VarChar);
			if (sPartnersDetailList != null)
				_oParameter.Value = sPartnersDetailList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			if (nPartnerID != null)
				_oParameter.Value = nPartnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
			if (_IDList != null)
				_oParameter.Value = _IDList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInnContext", SqlDbType.VarChar);
			if (_FilterInnContext != null)
				_oParameter.Value = _FilterInnContext;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TablePartnersDetails = FillReadings(new SqlDataAdapter(_oCommand), _TablePartnersDetails, "TablePartnersDetails");
				_TablePartnersDetails.PrimaryKey = new DataColumn[] { TablePartnersDetails.Columns["ID"] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка реквизитов..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// получение таблицы объединений клиентов (TablePartnersRoots)
		/// </summary>
		public bool FillTablePartnersRoots()
		{
			string sqlSelect = "execute up_PartnersRootsFill @nID, @cIDList, " +
									"@cNameContext, " +
									"@cInnContext, " +
									"@bActual ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PartnersRootsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_PartnerRootID != null)
				_oParameter.Value = _PartnerRootID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cIDList", SqlDbType.VarChar);
			if (_FilterPartnersRootsList != null)
				_oParameter.Value = _FilterPartnersRootsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInnContext", SqlDbType.VarChar);
			if (_FilterInnContext != null)
				_oParameter.Value = _FilterInnContext;
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
				_TablePartnersRoots = FillReadings(new SqlDataAdapter(_oCommand), _TablePartnersRoots, "TablePartnersRoots");
				_TablePartnersRoots.PrimaryKey = new DataColumn[] { _TablePartnersRoots.Columns[_ColumnID] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка объединений клиентов..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// получение таблицы спец.данных о товарах для клиента (TablePartnersGoods)
		/// </summary>
		public bool FillTablePartnersGoods(int? nPartnerID)
		{
			string sqlSelect = "execute up_PartnersGoodsFill @nPartnerID";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PartnersGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			if (nPartnerID.HasValue)
				_oParameter.Value = nPartnerID;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TablePartnersGoods = FillReadings(new SqlDataAdapter(_oCommand), _TablePartnersGoods, "TablePartnersGoods");
				_TablePartnersGoods.PrimaryKey = new DataColumn[] { _TablePartnersGoods.Columns[_ColumnID] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "Ошибка при получении спец.данных о товарах для клиента..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// копирование таблицы спец.данных о товарах клиента для других клиентов (TablePartnersGoods)
		/// </summary>
		public bool CopyTablePartnersGoods(int nPartnerID, string sPartnersList)
		{
			string sqlSelect = "execute up_PartnersGoodsCopy @nPartnerID, @cPartnersList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PartnersGoodsCopy parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			_oParameter.Value = nPartnerID;

			_oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
			if (sPartnersList != null)
				_oParameter.Value = sPartnersList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -14;
				_ErrorStr = "Ошибка при копировании спец.данных о товарах..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// копирование данных о печатных формах и количестве копий для других клиентов (Partner.PF_*)
		/// </summary>
		/// 
		public bool CopyDataPartnersPF(int nPartnerID, string sPartnersList)
		{
			string sqlSelect = "execute up_PartnersPFCopy @nPartnerID, @cPartnersList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PartnersGoodsCopy parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			_oParameter.Value = nPartnerID;

			_oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
			if (sPartnersList != null)
				_oParameter.Value = sPartnersList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -15;
				_ErrorStr = "Ошибка при копировании данных о специальных печатных формах и количестве копий документов..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Таблицы

		#region Дерево

		/// <summary>
		/// получение данных о клиентах для дерева (TableDataTree)
		/// sMode: "zone" - по зонам, "root" - по объединениям, "type" и другое - по типам
		/// </summary>
		public bool FillDataTree(string sMode, bool? bActual)
		{
			string sqlSelect = "";
			if (_FilterHostsList != null)
				sqlSelect = "select * " +
					"from .dbo.PartnersTreeHost('" + sMode + "', " +
						(bActual.HasValue ? (((bool)bActual) ? "1" : "0") : "Null") + ", " +
						"'" + _FilterHostsList + "') " +
					"order by ParentID, Name";
			else
				sqlSelect = "select * " +
					"from .dbo.PartnersTree('" + sMode + "', " +
						(bActual.HasValue ? ((bool)bActual ? "1" : "0") : "Null") + ") " +
					"order by ParentID, Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), _TablePartnersTree, "TablePartnersTree");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении иерархического списка (дерева) товаров..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Дерево

		#region Save

		/// <summary>
		/// сохранение данных о клиенте
		/// </summary>
		public bool SaveOne()
		{
			string _sqlCommand = "execute up_PartnersSave @nPartnerID output, " +
						"@nHostID, " +
						"@cName, " +
						"@bIsCustomer, @bIsSupplier, @bIsTransport, @bIsOwner, @bSeparatePicking, " +
						"@nPartnerRootID, " +
						"@nZoneID, " +
						"@cDeliveryAddress, @cDeliveryPassage, @cDeliveryRestriction, " +
						"@cGravity, " +
						"@nCoordinatesX, @nCoordinatesY, " +
                        "@nLatitude, @nLongitude, " +
                        "@cOkato, " +
						"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
						"@bDateValidControl, @bPalletsAgreement, @bFactPaymentOnly, " +
						"@cTimeWork, @cTimeReceipt, @cTimePay, " +
						"@cTimeRest, @nStayMinutes, @nDistance, " +
						"@cNote, " +
						"@cContactsInfo, " + 
						"@cPF_BillName, @nPF_BillCopiesCount, " + 
						"@cPF_FactureName, @nPF_FactureCopiesCount, " +
						"@cPF_PayBillName, @nPF_PayBillCopiesCount, " +
						"@cShopCode, " + 
                        "@cVeterinaryPartnerName, @cVeterinaryPermission, " +
						"@bActual, " +
						"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PartnersSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nHostID", SqlDbType.Int);
			_oParameter.Value = _HostID;

			_oParameter = _oCommand.Parameters.Add("@cName", SqlDbType.VarChar);
			_oParameter.Value = _Name;

			_oParameter = _oCommand.Parameters.Add("@bIsCustomer", SqlDbType.Bit);
			_oParameter.Value = _IsCustomer;

			_oParameter = _oCommand.Parameters.Add("@bIsSupplier", SqlDbType.Bit);
			_oParameter.Value = _IsSupplier;

			_oParameter = _oCommand.Parameters.Add("@bIsTransport", SqlDbType.Bit);
			_oParameter.Value = _IsTransport;

			_oParameter = _oCommand.Parameters.Add("@bIsOwner", SqlDbType.Bit);
			_oParameter.Value = _IsOwner;

			_oParameter = _oCommand.Parameters.Add("@bSeparatePicking", SqlDbType.Bit);
			_oParameter.Value = _SeparatePicking;

			_oParameter = _oCommand.Parameters.Add("@nPartnerRootID", SqlDbType.Int);
			if (_PartnerRootID.HasValue)
				_oParameter.Value = _PartnerRootID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nZoneID", SqlDbType.Int);
			if (_ZoneID.HasValue)
				_oParameter.Value = _ZoneID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDeliveryAddress", SqlDbType.VarChar);
			_oParameter.Value = _DeliveryAddress;

			_oParameter = _oCommand.Parameters.Add("@cDeliveryPassage", SqlDbType.VarChar);
			_oParameter.Value = _DeliveryPassage;

			_oParameter = _oCommand.Parameters.Add("@cDeliveryRestriction", SqlDbType.VarChar);
			_oParameter.Value = _DeliveryRestriction;

			_oParameter = _oCommand.Parameters.Add("@cGravity", SqlDbType.VarChar);
			_oParameter.Value = _Gravity;

			_oParameter = _oCommand.Parameters.Add("@nCoordinatesX", SqlDbType.Decimal);
			_oParameter.Precision = 12; 
			_oParameter.Scale = 6;
			if (_CoordinatesX.HasValue)
				_oParameter.Value = _CoordinatesX;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCoordinatesY", SqlDbType.Decimal);
			_oParameter.Precision = 12;
			_oParameter.Scale = 6;
			if (_CoordinatesY.HasValue)
				_oParameter.Value = _CoordinatesY;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nLatitude", SqlDbType.Decimal);
            if (_Latitude.HasValue)
                _oParameter.Value = _Latitude;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nLongitude", SqlDbType.Decimal);
            if (_Longitude.HasValue)
                _oParameter.Value = _Longitude;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cOkato", SqlDbType.VarChar);
			_oParameter.Value = _Okato;

			_oParameter = _oCommand.Parameters.Add("@bPassengerCarOnly", SqlDbType.Bit);
			_oParameter.Value = _PassengerCarOnly;

			_oParameter = _oCommand.Parameters.Add("@bPosternOnly", SqlDbType.Bit);
			_oParameter.Value = _PosternOnly;

			_oParameter = _oCommand.Parameters.Add("@bLoadLiftOnly", SqlDbType.Bit);
			_oParameter.Value = _LoadLiftOnly;

			_oParameter = _oCommand.Parameters.Add("@bDateValidControl", SqlDbType.Bit);
			_oParameter.Value = _DateValidControl;

			_oParameter = _oCommand.Parameters.Add("@bPalletsAgreement", SqlDbType.Bit);
			_oParameter.Value = _PalletsAgreement;

			_oParameter = _oCommand.Parameters.Add("@bFactPaymentOnly", SqlDbType.Bit);
			_oParameter.Value = _FactPaymentOnly;

			_oParameter = _oCommand.Parameters.Add("@cTimeWork", SqlDbType.VarChar);
			_oParameter.Value = _TimeWork;

			_oParameter = _oCommand.Parameters.Add("@cTimeReceipt", SqlDbType.VarChar);
			_oParameter.Value = _TimeReceipt;

			_oParameter = _oCommand.Parameters.Add("@cTimePay", SqlDbType.VarChar);
			_oParameter.Value = _TimePay;

			_oParameter = _oCommand.Parameters.Add("@cTimeRest", SqlDbType.VarChar);
			_oParameter.Value = _TimeRest;

			_oParameter = _oCommand.Parameters.Add("@nStayMinutes", SqlDbType.Int);
			_oParameter.Value = _StayMinutes;

            _oParameter = _oCommand.Parameters.Add("@nDistance", SqlDbType.Int);
            _oParameter.Value = _Distance;

            _oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			_oParameter.Value = _Note;

			_oParameter = _oCommand.Parameters.Add("@cContactsInfo", SqlDbType.VarChar);
			_oParameter.Value = _ContactsInfo;

			_oParameter = _oCommand.Parameters.Add("@cPF_BillName", SqlDbType.VarChar);
			if (_PF_BillName != null)
				_oParameter.Value = _PF_BillName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPF_BillCopiesCount", SqlDbType.Int);
			_oParameter.Value = _PF_BillCopiesCount;

			_oParameter = _oCommand.Parameters.Add("@cPF_FactureName", SqlDbType.VarChar);
			if (_PF_FactureName != null)
				_oParameter.Value = _PF_FactureName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPF_FactureCopiesCount", SqlDbType.Int);
			_oParameter.Value = _PF_FactureCopiesCount;

			_oParameter = _oCommand.Parameters.Add("@cPF_PayBillName", SqlDbType.VarChar);
			if (_PF_PayBillName != null)
				_oParameter.Value = _PF_PayBillName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPF_PayBillCopiesCount", SqlDbType.Int);
			_oParameter.Value = _PF_PayBillCopiesCount;

			_oParameter = _oCommand.Parameters.Add("@cShopCode", SqlDbType.VarChar);
			if (_ShopCode != null)
				_oParameter.Value = _ShopCode;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cVeterinaryPartnerName", SqlDbType.VarChar);
            _oParameter.Value = _VeterinaryPartnerName;

            _oParameter = _oCommand.Parameters.Add("@cVeterinaryPermission", SqlDbType.VarChar);
            _oParameter.Value = _VeterinaryPermission;

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
				if (_TablePartnersDetails != null)
				{
					RFMUtilities.DataTableToTempTable(TablePartnersDetails, "#PartnersDetails", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при попытке сохранения данных о партнере...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении данных о партнере...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}

				// при создании нового клиента - получим код новой записи
				if ((!_ID.HasValue || (int)_ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nPartnerID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nPartnerID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

        /// <summary>
        /// сохранение фото пользователя
        /// </summary>
        public bool SaveOneDrivingScheme()
        {
            string _sqlCommand = "execute up_PartnersDrivingSchemeSave @nPartnerID, " +
                    "@bDrivingScheme, " +
                    "@nError output, @cErrorText output";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

            #region up_UsersPhotoSave parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
            _oParameter.Value = _ID;

            _oParameter = _oCommand.Parameters.Add("@bDrivingScheme", SqlDbType.Image);
            if (_DrivingScheme != null)
            {
                _oParameter.Size = _DrivingScheme.Length;
                _oParameter.Value = _DrivingScheme;
            }
            else
            {
                _oParameter.Value = DBNull.Value;
            }

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
                _ErrorNumber = -12;
                _ErrorStr = "Ошибка при сохранении схемы проезда...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при сохранении схемы проезда...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            return (_ErrorNumber == 0);
        }

        #region PartnersGoods Save, Clear

		/// <summary>
		/// сохранение спец.данных о товарах для клиента
		/// </summary>
		public bool SavePartnersGoods(int nPartnerID, DataTable tGoods)
		{
			string _sqlCommand = "execute up_PartnersGoodsSave @nPartnerID, " + 
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PartnersGoodsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			_oParameter.Value = nPartnerID;
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
				if (tGoods != null)
				{
					RFMUtilities.DataTableToTempTable(tGoods, "#PartnersGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при попытке сохранения спец.данных о товарах для клиента...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении спец.данных о товарах для клиента...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка спец.данных о товарах для клиента
		/// </summary>
		public bool ClearPartnersGoods(int nPartnerID)
		{
			string _sqlCommand = "execute up_PartnersGoodsClear @nPartnerID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PartnersGoodsClear parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			_oParameter.Value = nPartnerID;

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
				_ErrorStr = "Ошибка при попытке очистки спец.данных о товарах для клиента...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при очистке спец.данных о товарах для клиента...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion PartnersGoods Save, Clear

		#endregion Save

		#region Address

		public string GetDeliveryStreet(int nPartnerID)
		{
			string sStreet = "";
			string sqlCommand = "select .dbo.PartnerDeliveryStreet(" + nPartnerID.ToString().Trim() + ") as DeliveryStreet";
			SqlCommand _oCommand = new SqlCommand(sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				DataTable dt = FillReadings(new SqlDataAdapter(_oCommand), null, "dt");
				if (dt != null && dt.Rows.Count == 1 &&
					!Convert.IsDBNull(dt.Rows[0]["DeliveryStreet"]))
					sStreet = dt.Rows[0]["DeliveryStreet"].ToString();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении улицы из адреса доставки...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (sStreet);
		}

		#endregion Address

		#region CalcDischargeDuration

		public int CalcDischargeDuration(int? nPartnerID)
		{
			int nDuration = -1;
			if (nPartnerID == null)
				return (0);

			string sqlCommand = "select IsNull(avg(.dbo.DurationMinutes(O.DateBegFact, O.DateEndFact)), 30) as Minutes " +
									"from OutputsDocuments O with (nolock) " +
									"inner join PartnersDetails ClD with (nolock) on O.PartnerDetailBayerID = ClD.ID " + 
									"where O.DateOutput > DateAdd(Month, -6, GetDate()) and " +
										"ClD.PartnerID = " + nPartnerID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				nDuration = Convert.ToInt32(_oCommand.ExecuteScalar());
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка получения среднего времени разгрузки у клиента...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (nDuration);
		}

		#endregion CalcDischargeDuration

		#region XML Templates (PF_*)
		/// шаблоны печатных форм

		/// <summary>
		/// получение текста шаблона
		/// </summary>
		public string XMLTemplateTextGet(int nPartnerID, string sPF_Type, ref string sPF_Name, ref int? nLinesInPage)
		{
			string sXMLTemplateText = null;

			string _sqlCommand = "execute up_PartnersPrintFormsFill @nPartnerID, " + 
									"@cPF_Type, @cPF_Name output, " + 
									"@cXMLTemplateText output, @nLinesInPage output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_PartnersPrintFormsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			_oParameter.Value = nPartnerID;

			_oParameter = _oCommand.Parameters.Add("@cPF_Type", SqlDbType.VarChar);
			if (sPF_Type != null)
				_oParameter.Value = sPF_Type;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPF_Name", SqlDbType.VarChar);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (sPF_Name != null)
				_oParameter.Value = sPF_Name;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cXMLTemplateText", SqlDbType.VarChar);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Size = int.MaxValue;
			_oParameter.Value = "";

			_oParameter = _oCommand.Parameters.Add("@nLinesInPage", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (nLinesInPage.HasValue)
				_oParameter.Value = nLinesInPage;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении XML-текста шаблона...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			if (_ErrorNumber == 0)
			{
				if (!Convert.IsDBNull(_oCommand.Parameters["@cPF_Name"].Value))
				{
					sPF_Name = _oCommand.Parameters["@cPF_Name"].Value.ToString();
				}
				if (!Convert.IsDBNull(_oCommand.Parameters["@cXMLTemplateText"].Value)) 
				{
					sXMLTemplateText = _oCommand.Parameters["@cXMLTemplateText"].Value.ToString();
				}
				if (!Convert.IsDBNull(_oCommand.Parameters["@nLinesInPage"].Value))
				{
					nLinesInPage = Convert.ToInt32(_oCommand.Parameters["@nLinesInPage"].Value);
				}
			}
			if (sXMLTemplateText != null && sXMLTemplateText.Length == 0)
			{
				sXMLTemplateText = null;
			}
			return (sXMLTemplateText);
		}

		#endregion XML Tempaltes (PF_*)
	}

#endregion Partner

}
