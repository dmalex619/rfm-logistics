using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;


/// <summary>
/// Бизнес-объект Рейс (Trip)
/// </summary>

namespace LogBizObjects
{

#region Trip 

	public class Trip: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID рейсов (Trips.ID)
		/// </summary>
		[Description("Список кодов ID рейсов (Trips.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected DateTime _DateTrip;
		/// <summary>
		/// Дата рейса (Trips.DateTrip)
		/// </summary>
		[Description("Дата рейса (Trips.DateTrip)")]
		public DateTime DateTrip { get { return _DateTrip; } set { _DateTrip = value; } }

		protected string _Alias;
		/// <summary>
		/// Описание рейса (машина, водитель, ID) (Trips.Alias)
		/// </summary>
		[Description("Описание рейса (машина, водитель, ID) (Trips.Alias)")]
		public string Alias { get { return _Alias; } set { _Alias = value; } }

		protected bool _SelfDelivery;
		/// <summary>
		/// Клиентская машина (самовывоз/самопривоз) (Trips.SelfDelivery)?
		/// </summary>
		[Description("Клиентская машина (самовывоз/самопривоз) (Trips.SelfDelivery)?")]
		public bool SelfDelivery { get { return _SelfDelivery; } set { _SelfDelivery = value; } }

		protected bool _IsRentCar;
		/// <summary>
		/// Арендованная машина (наш рейс) (Trips.SelfDelivery = 0, Trips.CarID is Null)?
		/// </summary>
		[Description("Арендованная машина (наш рейс) (Trips.SelfDelivery = 0, Trips.CarID is Null)?")]
		public bool IsRentCar { get { return _IsRentCar; } set { _IsRentCar = value; } }

		protected int _TripNumber;
		/// <summary>
		/// Номер рейса (Trips.TripNumber)
		/// </summary>
		[Description("Номер рейса (Trips.TripNumber)")]
		public int TripNumber { get { return _TripNumber; } set { _TripNumber = value; } }


		protected int? _CarID;
		/// <summary>
		/// Машина - код (Trips.CarID)
		/// </summary>
		[Description("Машина - код (Trips.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// Машина - наименование (Trips.CarID -> Cars.Name)
		/// </summary>
		[Description("Машина - наименование (Trips.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// Машина - гос.номер (Trips.CarID ->. Cars.CarNumber)
		/// </summary>
		[Description("Машина - гос.номер (Trips.CarID ->. Cars.CarNumber)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected string _TrailerNumber;
		/// <summary>
		/// Прицеп - гос.номер (Trips.CarID ->. Cars.TrailerNumber)
		/// </summary>
		[Description("Прицеп - гос.номер (Trips.CarID ->. Cars.TrailerNumber)")]
		public string TrailerNumber { get { return _TrailerNumber; } set { _TrailerNumber = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// Тип машины - код (Trips.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("Тип машины - код (Trips.CarID -> Cars.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// Тип машины - наименование (Trips.CarID -> Cars.CarTypeID ->. CarsTypes.Name)
		/// </summary>
		[Description("Тип машины - наименование (Trips.CarID -> Cars.CarTypeID ->. CarsTypes.Name)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// Сотрудник-водитель - код (Trips.DriverEmployeeID)
		/// </summary>
		[Description("Сотрудник-водитель - код (Trips.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// Сотрудник-водитель - наименование (Trips.DriverName; Trips.DriverEmployeeID -> Employees.Name)
		/// </summary>
		[Description("Сотрудник-водитель - наименование (Trips.DriverName; Trips.DriverEmployeeID -> Employees.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected string _DriverPhone;
		/// <summary>
		/// Сотрудник-водитель - телефон (Trips.DriverPhone; Trips.DriverEmployeeID -> Employees.Phone)
		/// </summary>
		[Description("Сотрудник-водитель - телефон (Trips.DriverPhone; Trips.DriverEmployeeID -> Employees.Phone)")]
		public string DriverPhone { get { return _DriverPhone; } set { _DriverPhone = value; } }

		protected int? _PartnerCarrierID;
		/// <summary>
		/// Фирма-грузоперевозчик - код (Trips.PartnerCarrierID)
		/// </summary>
		[Description("Фирма-грузоперевозчик - код (Trips.PartnerCarrierID)")]
		public int? PartnerCarrierID { get { return _PartnerCarrierID; } set { _PartnerCarrierID = value; } }

		protected string _PartnerCarrierName;
		/// <summary>
		/// Фирма-грузоперевозчик - наименование (Trips.PartnerCarrierID -> Partners.Name)
		/// </summary>
		[Description("Фирма-грузоперевозчик - наименование (Trips.PartnerCarrierID -> Partners.Name)")]
		public string PartnerCarrierName { get { return _PartnerCarrierName; } set { _PartnerCarrierName = value; } }


		protected int _Tonnage;
		/// <summary>
		/// Грузоподъемность*, кг (Trips.Tonnage)
		/// </summary>
		[Description("Грузоподъемность*, кг (Trips.Tonnage)")]
		public int Tonnage { get { return _Tonnage; } set { _Tonnage = value; } }

		protected bool _IsPassengerCar;
		/// <summary>
		/// Легковая машина* (Trips.IsPassengerCar)?
		/// </summary>
		[Description("Легковая машина* (Trips.IsPassengerCar)?")]
		public bool IsPassengerCar { get { return _IsPassengerCar; } set { _IsPassengerCar = value; } }

		protected bool _IsPostern;
		/// <summary>
		/// Машина с задней дверью* (Trips.IsPostern)?
		/// </summary>
		[Description("Машина с задней дверью* (Trips.IsPostern)?")]
		public bool IsPostern { get { return _IsPostern; } set { _IsPostern = value; } }

		protected bool _IsLoadLift;
		/// <summary>
		/// Машина с задним подъемником (лопатой)* (Trips.IsLoadLift)?
		/// </summary>
		[Description("Машина с задним подъемником (лопатой)* (Trips.IsLoadLift)?")]
		public bool IsLoadLift { get { return _IsLoadLift; } set { _IsLoadLift = value; } }

		protected int _PermitLevelID;
		/// <summary>
		/// Разрешение проезда - код (Trips.PermitLevelID)
		/// </summary>
		[Description("Разрешение проезда - код (Trips.PermitLevelID)")]
		public int PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// Разрешение проезда - наименование (Trips.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("Разрешение проезда - наименование (Trips.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int _PermitLevelValue;
		/// <summary>
		/// Разрешение проезда - уровень, не менее (Trips.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Разрешение проезда - уровень, не менее (Trips.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected decimal _Volume;
		/// <summary>
		/// Объем, м3 - по машине (Trips.CarID -> Cars.Volume)
		/// </summary>
		[Description("Объем, м3 - по машине (Trips.CarID -> Cars.Volume)")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }

		protected decimal _MaxPalletsQnt;
		/// <summary>
		/// Максимальное количество паллет - по машине (Trips.CarID -> Cars.MaxPalletsQnt)
		/// </summary>
		[Description("Максимальное количество паллет - по машине (Trips.CarID -> Cars.MaxPalletsQnt)")]
		public decimal MaxPalletsQnt { get { return _MaxPalletsQnt; } set { _MaxPalletsQnt = value; } }

		protected decimal _MaxPointsQnt;
		/// <summary>
		/// Максимальное количество точек доставки за рейс - по машине (Trips.CarID -> Cars.MaxPointsQnt)
		/// </summary>
		[Description("Максимальное количество точек доставки за рейс - по машине (Trips.CarID -> Cars.MaxPointsQnt)")]
		public decimal MaxPointsQnt { get { return _MaxPointsQnt; } set { _MaxPointsQnt = value; } }

		protected int _MaxDurationMinutes;
		/// <summary>
		/// Максимальная продолжительность рейса, минут - по машине (Trips.CarID -> Cars.MaxDurationMinutes)
		/// </summary>
		[Description("Максимальная продолжительность рейса, минут - по машине (Trips.CarID -> Cars.MaxDurationMinutes)")]
		public int MaxDurationMinutes { get { return _MaxDurationMinutes; } set { _MaxDurationMinutes = value; } }

		
		protected DateTime? _DateBegPlan;
		/// <summary>
		/// Дата-время выхода машины в рейс - план (Trips.DateBegPlan)
		/// </summary>
		[Description("Дата-время выхода машины в рейс - план (Trips.DateBegPlan)")]
		public DateTime? DateBegPlan { get { return _DateBegPlan; } set { _DateBegPlan = value; } }

		protected DateTime? _DateEndPlan;
		/// <summary>
		/// Дата-время возвращения машины из рейса - план (Trips.DateEndPlan)
		/// </summary>
		[Description("Дата-время возвращения машины из рейса - план (Trips.DateEndPlan)")]
		public DateTime? DateEndPlan { get { return _DateEndPlan; } set { _DateEndPlan = value; } }

		protected int? _DurationMinutesPlan;
		/// <summary>
		/// Длительность рейса, мин. - план (Trips.DurationMinutesPlan())
		/// </summary>
		[Description("Длительность рейса, мин. - план (Trips.DurationMinutesPlan())")]
		public int? DurationMinutesPlan { get { return _DurationMinutesPlan; } set { _DurationMinutesPlan = value; } }

		protected string _DurationHoursMinutesPlan;
		/// <summary>
		/// Длительность рейса, час:мин - план (Trips.DurationHoursMinutesPlan())
		/// </summary>
		[Description("Длительность рейса, час:мин. - план (Trips.DurationHoursMinutesPlan())")]
		public string DurationHoursMinutesPlan { get { return _DurationHoursMinutesPlan; } set { _DurationHoursMinutesPlan = value; } }

		protected DateTime? _DateBeg;
		/// <summary>
		/// Дата-время выхода машины в рейс - факт (Trips.DateBeg)
		/// </summary>
		[Description("Дата-время выхода машины в рейс - факт (Trips.DateBeg)")]
		public DateTime? DateBeg { get { return _DateBeg; } set { _DateBeg = value; } }

		protected DateTime? _DateEnd;
		/// <summary>
		/// Дата-время возвращения машины из рейса - факт (Trips.DateEnd)
		/// </summary>
		[Description("Дата-время возвращения машины из рейса - факт (Trips.DateEnd)")]
		public DateTime? DateEnd { get { return _DateEnd; } set { _DateEnd = value; } }

		protected int? _DurationMinutes;
		/// <summary>
		/// Длительность рейса, мин. - факт (Trips.DurationMinutes())
		/// </summary>
		[Description("Длительность рейса, мин. - факт (Trips.DurationMinutes())")]
		public int? DurationMinutes { get { return _DurationMinutes; } set { _DurationMinutes = value; } }

		protected string _DurationHoursMinutes;
		/// <summary>
		/// Длительность рейса, час:мин - факт (Trips.DurationHoursMinutes())
		/// </summary>
		[Description("Длительность рейса, час:мин. - факт (Trips.DurationHoursMinutes())")]
		public string DurationHoursMinutes { get { return _DurationHoursMinutes; } set { _DurationHoursMinutes = value; } }


		protected DateTime? _DepartureTime;
		/// <summary>
		/// Дата-время выхода машины с базы (проезд через ворота) - факт (Trips.DepartureTime)
		/// </summary>
		[Description("Дата-время выхода машины с базы (проезд через ворота) - факт (Trips.DepartureTime)")]
		public DateTime? DepartureTime { get { return _DepartureTime; } set { _DepartureTime = value; } }

		protected DateTime? _ArrivalTime;
		/// <summary>
		/// Дата-время возвращения машины на базу (проезд через ворота) - факт (Trips.ArrivalTime)
		/// </summary>
		[Description("Дата-время возвращения машины на базу (проезд через ворота) - факт (Trips.ArrivalTime)")]
		public DateTime? ArrivalTime { get { return _ArrivalTime; } set { _ArrivalTime = value; } }


		protected int? _Race;
		/// <summary>
		/// Пробег, км (Trips.Race)
		/// </summary>
		[Description("Пробег, км (Trips.Race)")]
		public int? Race { get { return _Race; } set { _Race = value; } }


		// сумма по Outputs / OutputsDocuments

		protected decimal _OutputsPalletsQnt;
		/// <summary>
		/// Количество паллет - по расходам (Trips.OutputsPalletsQnt)
		/// </summary>
		[Description("Количество паллет - по расходам (Trips.OutputsPalletsQnt)")]
		public decimal OutputsPalletsQnt { get { return _OutputsPalletsQnt; } set { _OutputsPalletsQnt = value; } }

 		protected decimal _OutputsNetto;
		/// <summary>
		/// Вес перевозимого товара - нетто, кг - по расходам (Trips.OutputsNetto)
		/// </summary>
		[Description("Вес перевозимого товара - нетто, кг - по расходам (Trips.OutputsNetto)")]
		public decimal OutputsNetto { get { return _OutputsNetto; } set { _OutputsNetto = value; } }

		protected decimal _OutputsBrutto;
		/// <summary>
		/// Вес перевозимого товара - брутто, кг - по расходам (Trips.OutputsBrutto)
		/// </summary>
		[Description("Вес перевозимого товара - брутто, кг - по расходам (Trips.OutputsBrutto)")]
		public decimal OutputsBrutto { get { return _OutputsBrutto; } set { _OutputsBrutto = value; } }
		
		protected decimal _OutputsVolume;
		/// <summary>
		/// Объем перевозимого товара, м3 - по расходам (Trips.OutputsVolume)
		/// </summary>
		[Description("Объем перевозимого товара, м3 - по расходам (Trips.OutputsVolume)")]
		public decimal OutputsVolume { get { return _OutputsVolume; } set { _OutputsVolume = value; } }

		protected decimal _OutputsChargePercent;
		/// <summary>
		/// % загрузки по весу брутто - по расходам (Trips.OutputsChargePercent)
		/// </summary>
		[Description("% загрузки по весу брутто - по расходам (Trips.OutputsChargePercent)")]
		public decimal OutputsChargePercent { get { return _OutputsChargePercent; } set { _OutputsChargePercent = value; } }


		protected decimal _OutputsDocumentsPalletsQnt;
		/// <summary>
		/// Количество паллет - по расходным документам (Trips.OutputsDocumentsPalletsQnt)
		/// </summary>
		[Description("Количество паллет - по расходным документам (Trips.OutputsDocumentsPalletsQnt)")]
		public decimal OutputsDocumentsPalletsQnt { get { return _OutputsDocumentsPalletsQnt; } set { _OutputsDocumentsPalletsQnt = value; } }

		protected decimal _OutputsDocumentsNetto;
		/// <summary>
		/// Вес перевозимого товара - нетто, кг - по расходным документам (Trips.OutputsDocumentsNetto)
		/// </summary>
		[Description("Вес перевозимого товара - нетто, кг - по расходным документам (Trips.OutputsDocumentsNetto)")]
		public decimal OutputsDocumentsNetto { get { return _OutputsDocumentsNetto; } set { _OutputsDocumentsNetto = value; } }

		protected decimal _OutputsDocumentsBrutto;
		/// <summary>
		/// Вес перевозимого товара - брутто, кг - по расходным документам (Trips.OutputsDocumentsBrutto)
		/// </summary>
		[Description("Вес перевозимого товара - брутто, кг - по расходным документам (Trips.OutputsDocumentsBrutto)")]
		public decimal OutputsDocumentsBrutto { get { return _OutputsDocumentsBrutto; } set { _OutputsDocumentsBrutto = value; } }

		protected decimal _OutputsDocumentsVolume;
		/// <summary>
		/// Объем перевозимого товара, м3 - по расходным документам (Trips.OutputsDocumentsVolume)
		/// </summary>
		[Description("Объем перевозимого товара, м3 - по расходным документам (Trips.OutputsDocumentsVolume)")]
		public decimal OutputsDocumentsVolume { get { return _OutputsDocumentsVolume; } set { _OutputsDocumentsVolume = value; } }

		protected decimal _OutputsDocumentsChargePercent;
		/// <summary>
		/// % загрузки по весу брутто - по расходным документам (Trips.OutputsDocumentsChargePercent)
		/// </summary>
		[Description("% загрузки по весу брутто - по расходным документам (Trips.OutputsDocumentsChargePercent)")]
		public decimal OutputsDocumentsChargePercent { get { return _OutputsDocumentsChargePercent; } set { _OutputsDocumentsChargePercent = value; } }

		protected int _OutputsDocumentsPointsQnt;
		/// <summary>
		/// Количество адресов доставки - по расходным документам (Trips.OutputsDocumentsPointsQnt)
		/// </summary>
		[Description("Количество адресов доставки - по расходным документам (Trips.OutputsDocumentsPointsQnt)")]
		public int OutputsDocumentsPointsQnt { get { return _OutputsDocumentsPointsQnt; } set { _OutputsDocumentsPointsQnt = value; } }


		// сумма по Inputs / InputsDocuments

		protected decimal _InputsPalletsQnt;
		/// <summary>
		/// Количество паллет - по приходам (Trips.InputsPalletsQnt)
		/// </summary>
		[Description("Количество паллет - по приходам (Trips.InputsPalletsQnt)")]
		public decimal InputsPalletsQnt { get { return _InputsPalletsQnt; } set { _InputsPalletsQnt = value; } }

		protected decimal _InputsNetto;
		/// <summary>
		/// Вес перевозимого товара - нетто, кг - по приходам (Trips.InputsNetto)
		/// </summary>
		[Description("Вес перевозимого товара - нетто, кг - по приходам (Trips.InputsNetto)")]
		public decimal InputsNetto { get { return _InputsNetto; } set { _InputsNetto = value; } }

		protected decimal _InputsBrutto;
		/// <summary>
		/// Вес перевозимого товара - брутто, кг - по приходам (Trips.InputsBrutto)
		/// </summary>
		[Description("Вес перевозимого товара - брутто, кг - по приходам (Trips.InputsBrutto)")]
		public decimal InputsBrutto { get { return _InputsBrutto; } set { _InputsBrutto = value; } }

		protected decimal _InputsVolume;
		/// <summary>
		/// Объем перевозимого товара, м3 - по приходам (Trips.InputsVolume)
		/// </summary>
		[Description("Объем перевозимого товара, м3 - по приходам (Trips.InputsVolume)")]
		public decimal InputsVolume { get { return _InputsVolume; } set { _InputsVolume = value; } }

		protected decimal _InputsChargePercent;
		/// <summary>
		/// % загрузки по весу брутто - по приходам (Trips.InputsChargePercent)
		/// </summary>
		[Description("% загрузки по весу брутто - по приходам (Trips.InputsChargePercent)")]
		public decimal InputsChargePercent { get { return _InputsChargePercent; } set { _InputsChargePercent = value; } }


		protected decimal _InputsDocumentsPalletsQnt;
		/// <summary>
		/// Количество паллет - по приходным документам (Trips.InputsDocumentsPalletsQnt)
		/// </summary>
		[Description("Количество паллет - по приходным документам (Trips.InputsDocumentsPalletsQnt)")]
		public decimal InputsDocumentsPalletsQnt { get { return _InputsDocumentsPalletsQnt; } set { _InputsDocumentsPalletsQnt = value; } }

		protected decimal _InputsDocumentsNetto;
		/// <summary>
		/// Вес перевозимого товара - нетто, кг - по приходным документам (Trips.InputsDocumentsNetto)
		/// </summary>
		[Description("Вес перевозимого товара - нетто, кг - по приходным документам (Trips.InputsDocumentsNetto)")]
		public decimal InputsDocumentsNetto { get { return _InputsDocumentsNetto; } set { _InputsDocumentsNetto = value; } }

		protected decimal _InputsDocumentsBrutto;
		/// <summary>
		/// Вес перевозимого товара - брутто, кг - по приходным документам (Trips.InputsDocumentsBrutto)
		/// </summary>
		[Description("Вес перевозимого товара - брутто, кг - по приходным документам (Trips.InputsDocumentsBrutto)")]
		public decimal InputsDocumentsBrutto { get { return _InputsDocumentsBrutto; } set { _InputsDocumentsBrutto = value; } }

		protected decimal _InputsDocumentsVolume;
		/// <summary>
		/// Объем перевозимого товара, м3 - по приходным документам (Trips.InputsDocumentsVolume)
		/// </summary>
		[Description("Объем перевозимого товара, м3 - по приходным документам (Trips.InputsDocumentsVolume)")]
		public decimal InputsDocumentsVolume { get { return _InputsDocumentsVolume; } set { _InputsDocumentsVolume = value; } }

		protected decimal _InputsDocumentsChargePercent;
		/// <summary>
		/// % загрузки по весу брутто - по приходным документам (Trips.InputsDocumentsChargePercent)
		/// </summary>
		[Description("% загрузки по весу брутто - по приходным документам (Trips.InputsDocumentsChargePercent)")]
		public decimal InputsDocumentsChargePercent { get { return _InputsDocumentsChargePercent; } set { _InputsDocumentsChargePercent = value; } }

		protected int _InputsDocumentsPointsQnt;
		/// <summary>
		/// Количество адресов доставки - по приходным документам (Trips.InputsDocumentsPointsQnt)
		/// </summary>
		[Description("Количество адресов доставки - по приходным документам (Trips.InputsDocumentsPointsQnt)")]
		public int InputsDocumentsPointsQnt { get { return _InputsDocumentsPointsQnt; } set { _InputsDocumentsPointsQnt = value; } }

		// 

		protected int? _CostNormID;
		/// <summary>
		/// Норматив стоимости рейса - код (Trips.CostNormID)
		/// </summary>
		[Description("Норматив стоимости рейса - код (Trips.CostNormID)")]
		public int? CostNormID { get { return _CostNormID; } set { _CostNormID = value; } }

		protected string _CostNormName;
		/// <summary>
		/// Норматив стоимости рейса - наименование (Trips.CostNormID -> CostsNorms.Name)
		/// </summary>
		[Description("Норматив стоимости рейса - наименование (Trips.CostNormID -> CostsNorms.Name)")]
		public string CostNormName { get { return _CostNormName; } set { _CostNormName = value; } }

		protected decimal _CostPlan;
		/// <summary>
		/// Плановая стоимость рейса - по нормативу (Trips.CostPlan)
		/// </summary>
		[Description("Плановая стоимость рейса - по нормативу (Trips.CostPlan)")]
		public decimal CostPlan { get { return _CostPlan; } set { _CostPlan = value; } }

		protected decimal _Cost;
		/// <summary>
		/// Фактическая стоимость рейса - по нормативу (Trips.Cost)
		/// </summary>
		[Description("Фактическая стоимость рейса - по нормативу (Trips.Cost)")]
		public decimal Cost { get { return _Cost; } set { _Cost = value; } }

		protected int _Distance;
		/// <summary>
		/// Пробег по рейсу, км (Trips.Distance)
		/// </summary>
		[Description("Пробег по рейсу, км (Trips.Distance)")]
		public int Distance { get { return _Distance; } set { _Distance = value; } }

		protected string _DepartmentName;
		/// <summary>
		/// Отдел - наименование (Trips.DepartmentName - dbo)
		/// </summary>
		[Description("Отдел - наименование (Trips.DepartmentName - dbo)")]
		public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания к рейсу (Trips.Note)
		/// </summary>
		[Description("Примечания к рейсу (Trips.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _NoteExecute;
		/// <summary>
		/// Примечания к выполнению рейса (Trips.NoteExecute)
		/// </summary>
		[Description("Примечания к выполнению рейса (Trips.NoteExecute)")]
		public string NoteExecute { get { return _NoteExecute; } set { _NoteExecute = value; } }

		protected int? _ByOrder;
		/// <summary>
		/// № п/п загрузки машины (Trips.ByOrder)
		/// </summary>
		[Description("№ п/п загрузки машины (Trips.ByOrder)")]
		public int? ByOrder { get { return _ByOrder; } set { _ByOrder = value; } }


		protected bool _ReadyForWMS;
		/// <summary>
		/// Рейс готов к обработке на складе (Trips.ReadyForWMS)?
		/// </summary>
		[Description("Рейс готов к обработке на складе (Trips.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }


		protected bool _ReadyForPrint;
		/// <summary>
		/// Рейс готов к печати расходных документов (Trips.ReadyForPrint)?
		/// </summary>
		[Description("Рейс готов к печати расходных документов (Trips.ReadyForPrint)?")]
		public bool ReadyForPrint { get { return _ReadyForPrint; } set { _ReadyForPrint = value; } }

		protected DateTime? _DatePrint;
		/// <summary>
		/// Дата-время печати документов на рейс (Trips.DatePrint)
		/// </summary>
		[Description("Дата-время печати документов на рейс (Trips.DatePrint)")]
		public DateTime? DatePrint { get { return _DatePrint; } set { _DatePrint = value; } }

		protected bool _IsPrinted;
		/// <summary>
		/// Документы на рейс распечатаны (Trips.DatePrint is not Null)?
		/// </summary>
		[Description("Документы на рейс распечатаны (Trips.Printed is not Null)?")]
		public bool IsPrinted { get { return _IsPrinted; } set { _IsPrinted = value; } }


		protected bool? _ReadyForTripBeg;
		/// <summary>
		/// Рейс готов к началу (Trips.ReadyForTripBeg(ID))?
		/// </summary>
		[Description("Рейс готов к началу (Trips.ReadyForTripBeg(ID))?")]
		public bool? ReadyForTripBeg { get { return _ReadyForTripBeg; } set { _ReadyForTripBeg = value; } }

		protected bool? _ReadyForTripEnd;
		/// <summary>
		/// Рейс готов к началу (Trips.ReadyForTripEnd(ID))?
		/// </summary>
		[Description("Рейс готов к началу (Trips.ReadyForTripEnd(ID))?")]
		public bool? ReadyForTripEnd { get { return _ReadyForTripEnd; } set { _ReadyForTripEnd = value; } }


		protected DateTime? _DateConfirm;
		/// <summary>
		/// Дата-время подтверждения рейса (Trips.DateConfirm)
		/// </summary>
		[Description("Дата-время подтверждения рейса (Trips.DateConfirm)")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// Рейс подтвержден (Trips.DateConfirm is not Null)?
		/// </summary>
		[Description("Рейс подтвержден (Trips.Confirmed is not Null)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }

		protected int? _UserConfirmID;
		/// <summary>
		/// Пользователь, подтвердивший выполнение рейса - код (Trips.UserConfirmID)
		/// </summary>
		[Description("Пользователь, подтвердивший выполнение рейса - код (Trips.UserConfirmID)")]
		public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

		protected string _UserConfirmName;
		/// <summary>
		/// Пользователь, подтвердивший выполнение рейса - фИО (Trips.UserConfirmID -> _Users.Name)
		/// </summary>
		[Description("Пользователь, подтвердивший выполнение рейса - ФИО (Trips.UserConfirmID -> _Users.Name)")]
		public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }


		protected int? _WayBillID;
		/// <summary>
		/// Путевой лист - код, для собственных машин (Trips.WayBillID)
		/// </summary>
		[Description("Путевой лист - код, для собственных машин (Trips.WayBillID)")]
		public int? WayBillID { get { return _WayBillID; } set { _WayBillID = value; } }

		protected int? _PassID;
		/// <summary>
		/// Пропуск - код, для прочих машин (Trips.PassID)
		/// </summary>
		[Description("Путевой лист - код, для прочих машин (Trips.PassID)")]
		public int? PassID { get { return _PassID; } set { _PassID = value; } }

		protected int _TripStatus;
		/// <summary>
		/// Статус рейса (0 - машина не вышла, 1 - вышла, 2 - пришла)
		/// </summary>
		[Description("Статус рейса (0 - машина не вышла, 1 - вышла, 2 - пришла)")]
		public int TripStatus { get { return _TripStatus; } set { _TripStatus = value; } }

		
		protected bool _IsOutputsDocumentsAttached;
		/// <summary>
		/// К рейсу присоединены расходные документы (Trips.ID --> OutputsDocuments.TripID)?
		/// </summary>
		[Description("К рейсу присоединены расходные документы (Trips.ID --> OutputsDocuments.TripID)?")]
		public bool IsOutputsDocumentsAttached { get { return _IsOutputsDocumentsAttached; } set { _IsOutputsDocumentsAttached = value; } }

		protected bool _IsOutputsDocumentsBrought;
		/// <summary>
		/// Все расходные документы доставлены (Trips.ID --> OutputsDocuments.DateBring is not Null)?
		/// </summary>
		[Description("Все расходные доставлены (Trips.ID --> OutputsDocuments.DateBring is not Null)?")]
		public bool IsOutputsDocumentsBrought { get { return _IsOutputsDocumentsBrought; } set { _IsOutputsDocumentsBrought = value; } }


		protected bool _IsOutputsAttached;
		/// <summary>
		/// К рейсу присоединены задания на расход (Trips.ID --> Outputs.TripsID)?
		/// </summary>
		[Description("К рейсу присоединены задания на расход (Trips.ID --> Outputs.TripsID)?")]
		public bool IsOutputsAttached { get { return _IsOutputsAttached; } set { _IsOutputsAttached = value; } }

		protected bool _IsOutputsConfirmed;
		/// <summary>
		/// Все задания на расход подтверждены (Trips.ID --> Outputs.DateConfirm is not Null)?
		/// </summary>
		[Description("Все задания на расход подтверждены (TripsID.ID --> Outputs.DateConfirm is not Null)?")]
		public bool IsOutputsConfirmed { get { return _IsOutputsConfirmed; } set { _IsOutputsConfirmed = value; } }


		protected bool _IsInputsDocumentsAttached;
		/// <summary>
		/// К рейсу присоединены приходные документы (Trips.ID --> InputsDocuments.TripID)?
		/// </summary>
		[Description("К рейсу присоединены приходные документы (Trips.ID --> InputsDocuments.TripID)?")]
		public bool IsInputsDocumentsAttached { get { return _IsInputsDocumentsAttached; } set { _IsInputsDocumentsAttached = value; } }


		protected bool _IsInputsAttached;
		/// <summary>
		/// К рейсу присоединены задания на приход (Trips.ID --> Inputs.TripsID)?
		/// </summary>
		[Description("К рейсу присоединены задания на приход (Trips.ID --> Inputs.TripsID)?")]
		public bool IsInputsAttached { get { return _IsInputsAttached; } set { _IsInputsAttached = value; } }

		protected bool _IsInputsConfirmed;
		/// <summary>
		/// Все задания на приход подтверждены (Trips.ID --> Inputs.DateConfirm is not Null)?
		/// </summary>
		[Description("Все задания на приход подтверждены (Trips.ID --> Inputs.DateConfirm is not Null)?")]
		public bool IsInputsConfirmed { get { return _IsInputsConfirmed; } set { _IsInputsConfirmed = value; } }


		protected bool _IsActsAttached;
		/// <summary>
		/// К рейсу присоединены акты (посредством заданий на приход/на расход) (Trips.ID --> Inputs.TripID, Outputs.TripID --> Acts.InputID, Acts.OutputsID)?
		/// </summary>
		[Description("К рейсу присоединены акты (посредством заданий на приход/на расход) (Trips.ID --> Inputs.TripID, Outputs.TripID --> Acts.InputID, Acts.OutputsID)?")]
		public bool IsActsAttached { get { return _IsActsAttached; } set { _IsActsAttached = value; } }

		protected bool _IsActsConfirmed;
		/// <summary>
		/// Все задания на акты подтверждены (Trips.ID --> Inputs, Outputs --> Acts.DateConfirm is not Null)?
		/// </summary>
		[Description("Все задания на акты подтверждены (Trips.ID --> Inputs, Outputs -->  Acts.DateConfirm is not Null)?")]
		public bool IsActsConfirmed { get { return _IsActsConfirmed; } set { _IsActsConfirmed = value; } }


		protected bool _IsTripsReturnsAttached;
		/// <summary>
		/// К рейсу присоединены возвраты (Trips.ID --> TripsReturns.TripsID)?
		/// </summary>
		[Description("К рейсу присоединены возвраты (Trips.ID --> TripsReturns.TripsID)?")]
		public bool IsTripsReturnsAttached { get { return _IsTripsReturnsAttached; } set { _IsTripsReturnsAttached = value; } }

		protected bool _IsTripsReturnsConfirmed;
		/// <summary>
		/// Все возвраты подтверждены (Trips.ID --> TripsReturns.DateConfirm is not Null)?
		/// </summary>
		[Description("Все возвраты подтверждены (Trips.ID --> TripsReturns.DateConfirm is not Null)?")]
		public bool IsTripsReturnsConfirmed { get { return _IsTripsReturnsConfirmed; } set { _IsTripsReturnsConfirmed = value; } }


		protected bool _IsTripReturnAutoAttached;
		/// <summary>
		/// Для рейса автоматически построен возврат-недовоз (Trips.ID --> TripsReturns.TripsID)?
		/// </summary>
		[Description("Для рейса автоматически построен возврат-недовоз (Trips.ID --> TripsReturns.TripsID)?")]
		public bool IsTripReturnAutoAttached { get { return _IsTripReturnAutoAttached; } set { _IsTripsReturnsAttached = value; } }


		protected string _ERPCode;
		/// <summary>
		/// Код рейса в host-системе (Trips.ERPCode)
		/// </summary>
		[Description("Код рейса в host-системе (Trips.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterHostsList;
		/// <summary>
		/// Фильтр-поле: список кодов host-ов, через запятую (Outputs.HostID)
		/// </summary>
		[Description("Фильтр-поле: список кодов host-ов, через запятую (Outputs.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата рейса - начальная дата периода (Trips.DateTrip)
		/// </summary>
		[Description("Фильтр-поле: дата рейса - начальная дата периода (Trips.DateTrip)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата рейса - конечная дата периода (Trips.DateTrip)
		/// </summary>
		[Description("Фильтр-поле: дата рейса - конечная дата периода (Trips.DateTrip)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }


		protected bool? _FilterSelfDelivery;
		/// <summary>
		/// Фильтр-поле: машина клиента (самовывоз/самопривоз) (Trips.SelfDelivery)?
		/// </summary>
		[Description("Фильтр-поле: машина клиента (самовывоз/самопривоз) (Trips.SelfDelivery)?")]
		public bool? FilterSelfDelivery { get { return _FilterSelfDelivery; } set { _FilterSelfDelivery = value; _NeedRequery = true; } }
		
		protected bool? _FilterIsRentCar;
		/// <summary>
		/// Фильтр-поле: арендованная машина (наш рейс) (Trips.SelfDelivery = 0, Trips.CarID is Null)?
		/// </summary>
		[Description("Фильтр-поле: арендованная машина (наш рейс) (Trips.SelfDelivery = 0, Trips.CarID is Null)?")]
		public bool? FilterIsRentCar { get { return _FilterIsRentCar; } set { _FilterIsRentCar = value; _NeedRequery = true; } }


		protected string _FilterCarsList;
		/// <summary>
		/// Фильтр-поле: список кодов машин собственных, через запятую (Trips.CarID)
		/// </summary>
		[Description("Фильтр-поле: список кодов машин собственных, через запятую (Trips.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// Фильтр-поле: список кодов типов машин, через запятую (Trips.CarTypeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов типов машин, через запятую (Trips.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// Фильтр-поле: список кодов сотрудников-водителей, через запятую (Trips.DriversEmployeeID)
		/// </summary>
		[Description("Фильтр-поле: список кодов сотрудников-водителей, через запятую (Trips.DriversEmployeeID)")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterAliasContext;
		/// <summary>
		/// Фильтр-поле: рейс - описание (контекст) (Trips.Alias)
		/// </summary>
		[Description("Фильтр-поле: рейс - описание (контекст) (Trips.Alias)")]
		public string FilterAliasContext { get { return _FilterAliasContext; } set { _FilterAliasContext = value; _NeedRequery = true; } }


		protected int? _FilterTonnageBeg;
		/// <summary>
		/// Фильтр-поле: грузоподъемность - диапазон от... (Trips.Tonnage)
		/// </summary>
		[Description("Фильтр-поле: грузоподъемность - диапазон от... (Trips.Tonnage)")]
		public int? FilterTonnageBeg { get { return _FilterTonnageBeg; } set { _FilterTonnageBeg = value; _NeedRequery = true; } }

		protected int? _FilterTonnageEnd;
		/// <summary>
		/// Фильтр-поле: грузоподъемность - диапазон до... (Trips.Tonnage)
		/// </summary>
		[Description("Фильтр-поле: грузоподъемность - диапазон от... (Trips.Tonnage)")]
		public int? FilterTonnageEnd { get { return _FilterTonnageEnd; } set { _FilterTonnageEnd = value; _NeedRequery = true; } }

		protected bool? _FilterIsPassengerCar;
		/// <summary>
		/// Фильтр-поле: легковая машина (Trips.IsPassengerCar)?
		/// </summary>
		[Description("Фильтр-поле: легковая машина (Trips.IsPassengerCar)?")]
		public bool? FilterIsPassengerCar { get { return _FilterIsPassengerCar; } set { _FilterIsPassengerCar = value; _NeedRequery = true; } }

		protected bool? _FilterIsPostern;
		/// <summary>
		/// Фильтр-поле: машина с задней дверью (Trips.IsPostern)?
		/// </summary>
		[Description("Фильтр-поле: машина с задней дверью (Trips.Postern)?")]
		public bool? FilterIsPostern { get { return _FilterIsPostern; } set { _FilterIsPostern = value; _NeedRequery = true; } }

		protected bool? _FilterIsLoadLift;
		/// <summary>
		/// Фильтр-поле: машина с задним подъемником (лопатой) (Trips.LoadLift)?
		/// </summary>
		[Description("Фильтр-поле: машина с задним подъемником (лопатой) (Trips.LoadLift)?")]
		public bool? FilterIsLoadLift { get { return _FilterIsLoadLift; } set { _FilterIsLoadLift = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// Фильтр-поле: разрешение проезда - уровень, не менее (Trips.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Фильтр-поле: разрешение проезда - уровень, не менее (Trips.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }


		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// Фильтр-поле: рейс (и его задания) готов к передаче в складскую систему (Trips.ReadyForWMS)?
		/// </summary>
		[Description("Фильтр-поле: рейс (и его задания) готов к передаче в складскую систему (Trips.ReadyForWMS)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }


		protected bool? _FilterReadyForPrint;
		/// <summary>
		/// Фильтр-поле: рейс готов к печати (Trips.ReadyForPrint)?
		/// </summary>
		[Description("Фильтр-поле: рейс готов к печати (Trips.ReadyForPrint)?")]
		public bool? FilterReadyForPrint { get { return _FilterReadyForPrint; } set { _FilterReadyForPrint = value; _NeedRequery = true; } }

		protected bool? _FilterIsPrinted;
		/// <summary>
		/// Фильтр-поле: документы на рейс распечатаны (Trips.DatePrint is not Null)?
		/// </summary>
		[Description("Фильтр-поле: документы на рейс распечатаны (Trips.DatePrint is not Null)?")]
		public bool? FilterIsPrinted { get { return _FilterIsPrinted; } set { _FilterIsPrinted = value; _NeedRequery = true; } }


		protected bool? _FilterReadyForTripBeg;
		/// <summary>
		/// Фильтр-поле: рейс готов к началу (Trips.ReadyForTripBeg)?
		/// </summary>
		[Description("Фильтр-поле: рейс готов к началу (Trips.ReadyForTripBeg)?")]
		public bool? FilterReadyForTripBeg { get { return _FilterReadyForTripBeg; } set { _FilterReadyForTripBeg = value; _NeedRequery = true; } }

		protected bool? _FilterReadyForTripEnd;
		/// <summary>
		/// Фильтр-поле: рейс готов к окончанию (Trips.ReadyForTripEnd(ID))?
		/// </summary>
		[Description("Фильтр-поле: рейс готов к окончанию (Trips.ReadyForTripEnd(ID))?")]
		public bool? FilterReadyForTripEnd { get { return _FilterReadyForTripEnd; } set { _FilterReadyForTripEnd = value; _NeedRequery = true; } }


		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// Фильтр-поле: рейс подтвержден (Trips.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: рейс подтвержден (Trips.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }


		protected int? _FilterTripStatus;
		/// <summary>
		/// Фильтр-поле: статус рейса по месту нахождения машины (0 машина не вышла; 1 вышла, пока не вернулась, 2 вернулась)
		/// </summary>
		[Description("Фильтр-поле: статус рейса по месту нахождения машины (0 машина не вышла; 1 вышла, пока не вернулась, 2 вернулась)")]
		public int? FilterTripStatus { get { return _FilterTripStatus; } set { _FilterTripStatus = value; _NeedRequery = true; } }


		protected string _FilterWayBillsList;
		/// <summary>
		/// Фильтр-поле: список кодов путевых листов, через запятую (Trips.WayBillID)
		/// </summary>
		[Description("Фильтр-поле: список кодов путевых листов, через запятую (Trips.WayBillID)")]
		public string FilterWayBillsList { get { return _FilterWayBillsList; } set { _FilterWayBillsList = value; _NeedRequery = true; } }

		protected string _FilterPassesList;
		/// <summary>
		/// Фильтр-поле: список кодов пропусков, через запятую (Trips.PassID)
		/// </summary>
		[Description("Фильтр-поле: список кодов пропусков, через запятую (Trips.PassID)")]
		public string FilterPassesList { get { return _FilterPassesList; } set { _FilterPassesList = value; _NeedRequery = true; } }


		protected bool? _FilterIsOutputsDocumentsAttached;
		/// <summary>
		/// Фильтр-поле: есть присоединенные расходные документы (Trips.ID --> OutputsDocuments.TripID)?
		/// </summary>
		[Description("Фильтр-поле: есть присоединенные расходные документы (Trips.ID --> OutputsDocuments.TripID)?")]
		public bool? FilterIsOutputsDocumentsAttached { get { return _FilterIsOutputsDocumentsAttached; } set { _FilterIsOutputsDocumentsAttached = value; _NeedRequery = true; } }
		
		protected string _FilterOutputsDocumentsList;
		/// <summary>
		/// Фильтр-поле: список кодов присоединенных расходных документов, через запятую (Trips.ID --> OutputsDocuments.TripID)
		/// </summary>
		[Description("Фильтр-поле: список кодов присоединенных расходных документов, через запятую (Trips.ID --> OutputsDocuments.TripID)")]
		public string FilterOutputsDocumentsList { get { return _FilterOutputsDocumentsList; } set { _FilterOutputsDocumentsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsOutputsDocumentsBrought;
		/// <summary>
		/// Фильтр-поле: все расходные документы доставлены (Trips.ID --> OutputsDocuments.DateBring is not Null)?
		/// </summary>
		[Description("Фильтр-поле: все расходные документы доставлены (Trips.ID --> OutputsDocuments.DateBring is not Null)?")]
		public bool? FilterIsOutputsDocumentsBrought { get { return _FilterIsOutputsDocumentsBrought; } set { _FilterIsOutputsDocumentsBrought = value; _NeedRequery = true; } }


		protected bool? _FilterIsInputsDocumentsAttached;
		/// <summary>
		/// Фильтр-поле: есть присоединенные приходные документы (Trips.ID --> InputsDocuments.TripID)?
		/// </summary>
		[Description("Фильтр-поле: есть присоединенные приходные документы (Trips.ID --> InputsDocuments.TripID)?")]
		public bool? FilterIsInputsDocumentsAttached { get { return _FilterIsInputsDocumentsAttached; } set { _FilterIsInputsDocumentsAttached = value; _NeedRequery = true; } }

		protected string _FilterInputsDocumentsList;
		/// <summary>
		/// Фильтр-поле: список кодов присоединенных приходных документов, через запятую (Trips.ID --> InputsDocuments.TripID)
		/// </summary>
		[Description("Фильтр-поле: список кодов присоединенных приходных документов, через запятую (Trips.ID --> InputsDocuments.TripID)")]
		public string FilterInputsDocumentsList { get { return _FilterInputsDocumentsList; } set { _FilterInputsDocumentsList = value; _NeedRequery = true; } }
	

		protected bool? _FilterIsInputsAttached;
		/// <summary>
		/// Фильтр-поле: есть присоединенные задания на приход (Trips.ID --> Inputs.TripID)?
		/// </summary>
		[Description("Фильтр-поле: есть присоединенные задания на приход (Trips.ID --> Inputs.TripID)?")]
		public bool? FilterIsInputsAttached { get { return _FilterIsInputsAttached; } set { _FilterIsInputsAttached = value; _NeedRequery = true; } }

		protected string _FilterInputsList;
		/// <summary>
		/// Фильтр-поле: список кодов заданий на приход, через запятую (Trips.ID --> Inputs.ID)
		/// </summary>
		[Description("Фильтр-поле: список кодов заданий на приход, через запятую (Trips.ID --> Inputs.ID)")]
		public string FilterInputsList { get { return _FilterInputsList; } set { _FilterInputsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsInputsConfirmed;
		/// <summary>
		/// Фильтр-поле: все задания на приход подтверждены (Trips.ID --> Inputs.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: все задания на приход подтверждены (Trips.ID --> Inputs.DateConfirm is not Null)?")]
		public bool? FilterIsInputsConfirmed { get { return _FilterIsInputsConfirmed; } set { _FilterIsInputsConfirmed = value; _NeedRequery = true; } }


		protected bool? _FilterIsOutputsAttached;
		/// <summary>
		/// Фильтр-поле: есть присоединенные задания на расход (Trips.ID --> Outputs.TripID)?
		/// </summary>
		[Description("Фильтр-поле: есть присоединенные задания на расход (Trips..ID --> Outputs.TripID)?")]
		public bool? FilterIsOutputsAttached { get { return _FilterIsOutputsAttached; } set { _FilterIsOutputsAttached = value; _NeedRequery = true; } }

		protected string _FilterOutputsList;
		/// <summary>
		/// Фильтр-поле: список кодов заданий на расход, через запятую (Trips.ID --> Outputs.ID)
		/// </summary>
		[Description("Фильтр-поле: список кодов заданий на расход, через запятую (Trips.ID --> Outputs.ID)")]
		public string FilterOutputsList { get { return _FilterOutputsList; } set { _FilterOutputsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsOutputsConfirmed;
		/// <summary>
		/// Фильтр-поле: все задания на расход подтверждены (Trips.ID --> Outputs.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: все задания на расход подтверждены (Trips.ID --> Outputs.DateConfirm is not Null)?")]
		public bool? FilterIsOutputsConfirmed { get { return _FilterIsOutputsConfirmed; } set { _FilterIsOutputsConfirmed = value; _NeedRequery = true; } }


		protected bool? _FilterIsActsAttached;
		/// <summary>
		/// Фильтр-поле: есть присоединенные акты (посредством заданий на приход/расход) (Trips.ID --> Inputs, Outputs --> Acts.InputID, Acts.OutputID)?
		/// </summary>
		[Description("Фильтр-поле: есть присоединенные акты (посредством заданий на приход/расход) (Trips.ID --> Inputs, Outputs --> Acts.InputID, Acts.OutputID)?")]
		public bool? FilterIsActsAttached { get { return _FilterIsActsAttached; } set { _FilterIsActsAttached = value; _NeedRequery = true; } }

		protected bool? _FilterIsActsConfirmed;
		/// <summary>
		/// Фильтр-поле: все акты подтверждены (Trips.ID --> Inputs, Outputs --> Acts.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: все акты подтверждены (Trips.ID --> Inputs, Outputs --> Acts.DateConfirm is not Null)?")]
		public bool? FilterIsActsConfirmed { get { return _FilterIsActsConfirmed; } set { _FilterIsActsConfirmed = value; _NeedRequery = true; } }


		protected bool? _FilterIsTripsReturnsAttached;
		/// <summary>
		/// Фильтр-поле: есть присоединенные возвраты (Trips.ID --> TripsReturns.TripID)?
		/// </summary>
		[Description("Фильтр-поле: есть присоединенные возвраты (Trips..ID --> TripsReturns.TripID)?")]
		public bool? FilterIsTripsReturnsAttached { get { return _FilterIsTripsReturnsAttached; } set { _FilterIsTripsReturnsAttached = value; _NeedRequery = true; } }

		protected string _FilterTripsReturnsList;
		/// <summary>
		/// Фильтр-поле: список кодов возвратов, через запятую (Trips.ID --> TripsReturns.ID)
		/// </summary>
		[Description("Фильтр-поле: список кодов возвратов, через запятую (Trips.ID --> TripsReturns.ID)")]
		public string FilterTripsReturnsList { get { return _FilterTripsReturnsList; } set { _FilterTripsReturnsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsTripsReturnsConfirmed;
		/// <summary>
		/// Фильтр-поле: все возвраты подтверждены (Trips.ID --> Inputs.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: все возвраты подтверждены (Trips.ID --> Inputs.DateConfirm is not Null)?")]
		public bool? FilterIsTripsReturnsConfirmed { get { return _FilterIsTripsReturnsConfirmed; } set { _FilterIsTripsReturnsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterIsTripReturnAutoAttached;
		/// <summary>
		/// Фильтр-поле: есть автоматически построенный возврат-недовоз (Trips.ID --> TripsReturns.TripID)?
		/// </summary>
		[Description("Фильтр-поле: есть автоматически построенный возврат-недовоз (Trips..ID --> TripsReturns.TripID)?")]
		public bool? FilterIsTripReturnAutoAttached { get { return _FilterIsTripReturnAutoAttached; } set { _FilterIsTripReturnAutoAttached = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableTripsTypes;
		/// <summary>
		/// Таблица типов рейсов TripsTypes
		/// </summary>
		[Description("Таблица типов рейсов TripsTypes")]
		public DataTable TableTripsTypes { get { return _TableTripsTypes; } }

		protected DataTable _TableCostsNorms;
		/// <summary>
		/// Таблица нормативов стоимостей CostsNorms
		/// </summary>
		[Description("Таблица нормативов стоимостей CostsNorms")]
		public DataTable TableCostsNorms { get { return _TableCostsNorms; } }

		// фильтр для таблицы нормативов стоимостей
		protected bool? _FilterCostsNormsActual;
		/// <summary>
		/// Фильтр-поле: актуально? (CostsNorms.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуально? (CostsNorms.Actual)?")]
		public bool? FilterCostsNormsActual { get { return _FilterCostsNormsActual; } set { _FilterCostsNormsActual = value; /*_NeedRequery = true; */} }

		protected DataTable _TablePutsInTrip;
		/// <summary>
		/// Таблица складских заданий (Inputs, Outputs), привязанных к рейсу PutsInTrip
		/// </summary>
		[Description("Таблица складских заданий (Inputs, Outputs), привязанных к рейсу PutsInTrip")]
		public DataTable TablePutsInTrip { get { return _TablePutsInTrip; } }

		protected DataTable _TableOutputsInTrip;
		/// <summary>
		/// Таблица заданий на расход, привязанных к рейсу OutputsInTrip
		/// </summary>
		[Description("Таблица заданий на расход, привязанных к рейсу OutputsInTrip")]
		public DataTable TableOutputsInTrip { get { return _TableOutputsInTrip; } }

		protected DataTable _TableInputsInTrip;
		/// <summary>
		/// Таблица заданий на приход, привязанных к рейсу InputsInTrip
		/// </summary>
		[Description("Таблица заданий на приход, привязанных к рейсу InputsInTrip")]
		public DataTable TableInputsInTrip { get { return _TableInputsInTrip; } }

		protected DataTable _TableTripsReturnsInTrip;
		/// <summary>
		/// Таблица возвратов, привязанных к рейсу TripsReturnsInTrip
		/// </summary>
		[Description("Таблица возвратов, привязанных к рейсу TripsReturnsInTrip")]
		public DataTable TableTripsReturnsInTrip { get { return _TableTripsReturnsInTrip; } }

		protected DataTable _TableOutputsDocumentsInTrip;
		/// <summary>
		/// Таблица расходных документов, привязанных к рейсу OutputsDocumentsInTrip
		/// </summary>
		[Description("Таблица расходных документов, привязанных к рейсу OutputsDocumentsInTrip")]
		public DataTable TableOutputsDocumentsInTrip { get { return _TableOutputsDocumentsInTrip; } }

		protected DataTable _TableInputsDocumentsInTrip;
		/// <summary>
		/// Таблица приходных документов, привязанных к рейсу InputsDocumentsInTrip
		/// </summary>
		[Description("Таблица приходных документов, привязанных к рейсу InputsDocumentsInTrip")]
		public DataTable TableInputsDocumentsInTrip { get { return _TableInputsDocumentsInTrip; } }

		protected DataTable _TableOutputsDocumentsCarriesInTrip;
		/// <summary>
		/// Таблица перенесенных расходных документов и заданий на расход, прикрепленных к рейсу (OutputsDocumentsCarries)
		/// </summary>
		[Description("Таблица перенесенных расходных документов и заданий на расход, прикрепленных к рейсу (OutputsDocumentsCarries)")]
		public DataTable TableOutputsDocumentsCarriesInTrip { get { return _TableOutputsDocumentsCarriesInTrip; } }

		protected DataTable _TableInputsDocumentsCarriesInTrip;
		/// <summary>
		/// Таблица перенесенных приходных документов и заданий на приход, прикрепленных к рейсу (InputsDocumentsCarries)
		/// </summary>
		[Description("Таблица перенесенных приходных документов и заданий на приход, прикрепленных к рейсу (InputsDocumentsCarries)")]
		public DataTable TableInputsDocumentsCarriesInTrip { get { return _TableInputsDocumentsCarriesInTrip; } }

        protected DataTable _TableCarsTasksInTrip;
        /// <summary>
        /// Таблица спецзаданий, прикрепленных к рейсу (CarsTasks)
        /// </summary>
        [Description("Таблица спецзаданий, прикрепленных к рейсу (CarsTasks)")]
        public DataTable TableCarsTasksInTrip { get { return _TableCarsTasksInTrip; } }

        protected DataTable _TableGeoData;
        /// <summary>
        /// Таблица географических данных о партнерах в заданном списке рейсов
        /// </summary>
        [Description("Таблица географических данных о партнерах в заданном списке рейсов (TableGeoData)")]
        public DataTable TableGeoData { get { return _TableGeoData; } }

        protected DataTable _TableDrivingSchemes;
        /// <summary>
        /// Таблица географических данных о партнерах в заданном списке рейсов
        /// </summary>
        [Description("Таблица схем проезда в заданном списке рейсов (TableDrivingSchemes)")]
        public DataTable TableDrivingSchemes { get { return _TableDrivingSchemes; } }

        protected DataTable _TableEfficiency;
        /// <summary>
        /// Таблица данных для расчета экономической эффективности рейса (TableEfficiency)
        /// </summary>
        [Description("Таблица данных для расчета экономической эффективности рейса (TableEfficiency)")]
        public DataTable TableEfficiency { get { return _TableEfficiency; } }

        protected DataTable _TableTripsAllCosts;
        /// <summary>
        /// Таблица стоимостных данных по всем заданиям в рейсах (TableTripsAllCosts)
        /// </summary>
        [Description("Таблица стоимостных данных по всем заданиям в рейсах (TableTripsAllCosts)")]
        public DataTable TableTripsAllCosts { get { return _TableTripsAllCosts; } }

        #endregion Таблицы

        // ----------------------------

        public Trip()
			: base()
		{
			_MainTableName = "Trips";
			_ColumnID = "ID";
			_ColumnName = "DateTrip";
		}


		#region FillData

		/// <summary>
		/// получение полного списка рейсов с дополнительными сведениями в MainTable
		/// </summary>
		public override async System.Threading.Tasks.Task<bool> FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_TripsFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@bSelfDelivery, " +
									"@bIsRentCar, " +
									"@cCarsList, " +
									"@cCarsTypesList, " +
									"@cDriversEmployeesList, " +
									"@cAliasContext, " + 
									"@nTonnageBeg, @nTonnageEnd, " +
									"@bIsPassengerCar, @bIsPostern, @bIsLoadLift, " +
									"@nPermitLevelValueMin, " +
									"@bReadyForWMS, " +
									"@bReadyForPrint, @bIsPrinted, " +
									"@bReadyForTripBeg, @bReadyForTripEnd, " +
									"@bIsConfirmed, " +
									"@nTripStatus, " +
									"@bIsOutputsDocumentsAttached, @cOutputsDocumentsList, @bIsOutputsDocumentsBrought, " +
									"@bIsInputsDocumentsAttached, @cInputsDocumentsList, " +
									"@bIsOutputsAttached, @cOutputsList, @bIsOutputsConfirmed, " +
									"@bIsInputsAttached, @cInputsList, @bIsInputsConfirmed, " +
									"@bIsActsAttached, @bIsActsConfirmed, " +
									"@bIsTripsReturnsAttached, @cTripsReturnsList, @bIsTripsReturnsConfirmed, " +
									"@cWayBillsList, @cPassesList, " + 
									"@cHostsList"; 
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@bSelfDelivery", SqlDbType.Bit);
			if (_FilterSelfDelivery != null)
				_oParameter.Value = _FilterSelfDelivery;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsRentCar", SqlDbType.Bit);
			if (_FilterIsRentCar != null)
				_oParameter.Value = _FilterIsRentCar;
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

			_oParameter = _oCommand.Parameters.Add("@cAliasContext", SqlDbType.VarChar);
			if (_FilterAliasContext != null)
				_oParameter.Value = _FilterAliasContext;
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


			_oParameter = _oCommand.Parameters.Add("@bReadyForWMS", SqlDbType.Bit);
			if (_FilterReadyForWMS != null)
				_oParameter.Value = _FilterReadyForWMS;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bReadyForPrint", SqlDbType.Bit);
			if (_FilterReadyForPrint != null)
				_oParameter.Value = _FilterReadyForPrint;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsPrinted", SqlDbType.Bit);
			if (_FilterIsPrinted != null)
				_oParameter.Value = _FilterIsPrinted;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bReadyForTripBeg", SqlDbType.Bit);
			if (_FilterReadyForTripBeg != null)
				_oParameter.Value = _FilterReadyForTripBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bReadyForTripEnd", SqlDbType.Bit);
			if (_FilterReadyForTripEnd != null)
				_oParameter.Value = _FilterReadyForTripEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (_FilterIsConfirmed != null)
				_oParameter.Value = _FilterIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nTripStatus", SqlDbType.Int);
			if (_FilterTripStatus != null)
				_oParameter.Value = _FilterTripStatus;
			else
				_oParameter.Value = DBNull.Value;


			_oParameter = _oCommand.Parameters.Add("@bIsOutputsDocumentsAttached", SqlDbType.Bit);
			if (_FilterIsOutputsDocumentsAttached != null)
				_oParameter.Value = _FilterIsOutputsDocumentsAttached;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			if (_FilterOutputsDocumentsList != null)
				_oParameter.Value = _FilterOutputsDocumentsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOutputsDocumentsBrought", SqlDbType.Bit);
			if (_FilterIsOutputsDocumentsBrought != null)
				_oParameter.Value = _FilterIsOutputsDocumentsBrought;
			else
				_oParameter.Value = DBNull.Value;


			_oParameter = _oCommand.Parameters.Add("@bIsInputsDocumentsAttached", SqlDbType.Bit);
			if (_FilterIsInputsDocumentsAttached != null)
				_oParameter.Value = _FilterIsInputsDocumentsAttached;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsDocumentsList", SqlDbType.VarChar);
			if (_FilterInputsDocumentsList != null)
				_oParameter.Value = _FilterInputsDocumentsList;
			else
				_oParameter.Value = DBNull.Value;


			_oParameter = _oCommand.Parameters.Add("@bIsOutputsAttached", SqlDbType.Bit);
			if (_FilterIsOutputsAttached != null)
				_oParameter.Value = _FilterIsOutputsAttached;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsList", SqlDbType.VarChar);
			if (_FilterOutputsList != null)
				_oParameter.Value = _FilterOutputsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOutputsConfirmed", SqlDbType.Bit);
			if (_FilterIsOutputsConfirmed != null)
				_oParameter.Value = _FilterIsOutputsConfirmed;
			else
				_oParameter.Value = DBNull.Value;


			_oParameter = _oCommand.Parameters.Add("@bIsInputsAttached", SqlDbType.Bit);
			if (_FilterIsInputsAttached != null)
				_oParameter.Value = _FilterIsInputsAttached;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsList", SqlDbType.VarChar);
			if (_FilterInputsList != null)
				_oParameter.Value = _FilterInputsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsInputsConfirmed", SqlDbType.Bit);
			if (_FilterIsInputsConfirmed != null)
				_oParameter.Value = _FilterIsInputsConfirmed;
			else
				_oParameter.Value = DBNull.Value;


			_oParameter = _oCommand.Parameters.Add("@bIsActsAttached", SqlDbType.Bit);
			if (_FilterIsActsAttached != null)
				_oParameter.Value = _FilterIsActsAttached;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsActsConfirmed", SqlDbType.Bit);
			if (_FilterIsActsConfirmed != null)
				_oParameter.Value = _FilterIsActsConfirmed;
			else
				_oParameter.Value = DBNull.Value;


			_oParameter = _oCommand.Parameters.Add("@bIsTripsReturnsAttached", SqlDbType.Bit);
			if (_FilterIsTripsReturnsAttached != null)
				_oParameter.Value = _FilterIsTripsReturnsAttached;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTripsReturnsList", SqlDbType.VarChar);
			if (_FilterTripsReturnsList != null)
				_oParameter.Value = _FilterTripsReturnsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsTripsReturnsConfirmed", SqlDbType.Bit);
			if (_FilterIsTripsReturnsConfirmed != null)
				_oParameter.Value = _FilterIsTripsReturnsConfirmed;
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

			_oParameter = _oCommand.Parameters.Add("@cHostsList", SqlDbType.VarChar);
			if (_FilterHostsList != null)
				_oParameter.Value = _FilterHostsList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_MainTable.PrimaryKey = new DataColumn[] { _MainTable.Columns[_ColumnID] };
				_NeedRequery = false;
                await System.Threading.Tasks.Task.Run(() => Thread.Sleep(500));
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении списка рейсов..." + Convert.ToChar(13) + ex.Message;
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

			_FilterSelfDelivery = null;	
			_FilterIsRentCar = null;
			_FilterCarsList = null;
			_FilterCarsTypesList = null; 
			_FilterDriversEmployeesList = null;
			_FilterAliasContext = null;

			_FilterTonnageBeg = null;
			_FilterTonnageEnd = null;
			_FilterIsPassengerCar = null;
			_FilterIsPostern = null;
			_FilterIsLoadLift = null;
			_FilterPermitLevelValueMin = null;

			_FilterReadyForWMS = null;
			_FilterReadyForPrint = null;
			_FilterIsPrinted = null;
			_FilterReadyForTripBeg = null; 
			_FilterReadyForTripEnd = null;
			_FilterIsConfirmed = null;

			_FilterTripStatus = null;

			_FilterIsOutputsDocumentsAttached = null;
			_FilterOutputsDocumentsList = null;
			_FilterIsOutputsDocumentsBrought = null;
			_FilterIsInputsDocumentsAttached = null;
			_FilterInputsDocumentsList = null;

			_FilterIsOutputsAttached = null;
			_FilterOutputsList = null;
			_FilterIsOutputsConfirmed = null;
			_FilterIsInputsAttached = null;
			_FilterInputsList = null;
			_FilterIsInputsConfirmed = null;
			_FilterIsActsAttached = null;
			_FilterIsActsConfirmed = null;

			_FilterIsTripsReturnsAttached = null;
			_FilterTripsReturnsList = null;
			_FilterIsTripsReturnsConfirmed = null;
			_FilterIsTripReturnAutoAttached = null;
			
			_FilterWayBillsList = null;
			_FilterPassesList = null;

			_FilterCostsNormsActual = null;

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
					_DateTrip = Convert.ToDateTime(r["DateTrip"]);
					_TripNumber = Convert.ToInt32(r["TripNumber"]);
					_Alias = r["Alias"].ToString();

					_IsRentCar = Convert.ToBoolean(r["IsRentCar"]);
					_SelfDelivery = Convert.ToBoolean(r["SelfDelivery"]);

					if (!Convert.IsDBNull(r["CarID"]))
					{
						_CarID = Convert.ToInt32(r["CarID"]);
					}
					_CarName = r["CarName"].ToString();
					_CarNumber = r["CarNumber"].ToString();
					_TrailerNumber = r["TrailerNumber"].ToString();

					if (!Convert.IsDBNull(r["CarTypeID"]))
					{
						_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
					}
					_CarTypeName = r["CarTypeName"].ToString();

					if (!Convert.IsDBNull(r["DriverEmployeeID"]))
					{
						_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
					}
					_DriverName = r["DriverName"].ToString();
					_DriverPhone = r["DriverPhone"].ToString();

					if (!Convert.IsDBNull(r["PartnerCarrierID"]))
					{
						_PartnerCarrierID = Convert.ToInt32(r["PartnerCarrierID"]);
					}
					_PartnerCarrierName = r["PartnerCarrierName"].ToString();

					_Tonnage = Convert.ToInt32(r["Tonnage"]);

					_IsPassengerCar = Convert.ToBoolean(r["IsPassengerCar"]);
					_IsPostern = Convert.ToBoolean(r["IsPostern"]);
					_IsLoadLift = Convert.ToBoolean(r["IsLoadLift"]);

					_PermitLevelID = Convert.ToInt32(r["PermitLevelID"]);
					_PermitLevelName = r["PermitLevelName"].ToString();
					_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);

					_Volume = Convert.ToDecimal(r["Volume"]);
					_MaxPalletsQnt = Convert.ToDecimal(r["MaxPalletsQnt"]);
					_MaxPointsQnt = Convert.ToInt32(r["MaxPointsQnt"]);
					_MaxDurationMinutes = Convert.ToInt32(r["MaxDurationMinutes"]);

					_Race = Convert.ToInt32(r["Race"]);

					_OutputsNetto = Convert.ToDecimal(r["OutputsNetto"]);
					_OutputsNetto = Convert.ToDecimal(r["OutputsNetto"]);
					_OutputsVolume = Convert.ToDecimal(r["OutputsVolume"]);
					_OutputsPalletsQnt = Convert.ToDecimal(r["OutputsPalletsQnt"]);
					_OutputsChargePercent = Convert.ToDecimal(r["OutputsChargePercent"]);
					
					_OutputsDocumentsNetto = Convert.ToDecimal(r["OutputsDocumentsNetto"]);
					_OutputsDocumentsNetto = Convert.ToDecimal(r["OutputsDocumentsNetto"]);
					_OutputsDocumentsVolume = Convert.ToDecimal(r["OutputsDocumentsVolume"]);
					_OutputsDocumentsPalletsQnt = Convert.ToDecimal(r["OutputsDocumentsPalletsQnt"]);
					_OutputsDocumentsChargePercent = Convert.ToDecimal(r["OutputsDocumentsChargePercent"]);
					_OutputsDocumentsPointsQnt = Convert.ToInt32(r["OutputsDocumentsPointsQnt"]);

					_InputsNetto = Convert.ToDecimal(r["InputsNetto"]);
					_InputsBrutto = Convert.ToDecimal(r["InputsBrutto"]);
					_InputsVolume = Convert.ToDecimal(r["InputsVolume"]);
					_InputsPalletsQnt = Convert.ToDecimal(r["InputsPalletsQnt"]);
					_InputsChargePercent = Convert.ToDecimal(r["InputsChargePercent"]);

					_InputsDocumentsNetto = Convert.ToDecimal(r["InputsDocumentsNetto"]);
					_InputsDocumentsBrutto = Convert.ToDecimal(r["InputsDocumentsBrutto"]);
					_InputsDocumentsVolume = Convert.ToDecimal(r["InputsDocumentsVolume"]);
					_InputsDocumentsPalletsQnt = Convert.ToDecimal(r["InputsDocumentsPalletsQnt"]);
					_InputsDocumentsChargePercent = Convert.ToDecimal(r["InputsDocumentsChargePercent"]);
					_InputsDocumentsPointsQnt = Convert.ToInt32(r["InputsDocumentsPointsQnt"]);

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

					if (!Convert.IsDBNull(r["DepartureTime"]))
						_DepartureTime = Convert.ToDateTime(r["DepartureTime"]);
					if (!Convert.IsDBNull(r["ArrivalTime"]))
						_ArrivalTime = Convert.ToDateTime(r["ArrivalTime"]);

					if (!Convert.IsDBNull(r["ByOrder"]))
						_ByOrder = Convert.ToInt32(r["ByOrder"]);

					_ReadyForWMS = Convert.ToBoolean(r["ReadyForWMS"]);

					_ReadyForPrint = Convert.ToBoolean(r["ReadyForPrint"]);
					if (!Convert.IsDBNull(r["DatePrint"]))
						_DatePrint = Convert.ToDateTime(r["DatePrint"]);
					_IsPrinted = Convert.ToBoolean(r["IsPrinted"]);

					if (!Convert.IsDBNull(r["ReadyForTripBeg"]))
						_ReadyForTripBeg = Convert.ToBoolean(r["ReadyForTripBeg"]);
					if (!Convert.IsDBNull(r["ReadyForTripEnd"]))
						_ReadyForTripEnd = Convert.ToBoolean(r["ReadyForTripEnd"]);

					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);
					if (!Convert.IsDBNull(r["UserConfirmID"]))
						_UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
					_UserConfirmName = r["UserConfirmName"].ToString();

					if (!Convert.IsDBNull(r["CostNormID"]))
					{
						_CostNormID = Convert.ToInt32(r["CostNormID"]);
						_CostNormName = r["CostNormName"].ToString();
					}
					_CostPlan = Convert.ToDecimal(r["CostPlan"]);
					_Cost = Convert.ToDecimal(r["Cost"]);
					_Distance = Convert.ToInt32(r["Distance"]);

					_IsOutputsDocumentsAttached = Convert.ToBoolean(r["IsOutputsDocumentsAttached"]);
					_IsOutputsDocumentsBrought = Convert.ToBoolean(r["IsOutputsDocumentsBrought"]);
					_IsInputsDocumentsAttached = Convert.ToBoolean(r["IsInputsDocumentsAttached"]);
					_IsOutputsAttached = Convert.ToBoolean(r["IsOutputsAttached"]);
					_IsOutputsConfirmed = Convert.ToBoolean(r["IsOutputsConfirmed"]);
					_IsInputsAttached = Convert.ToBoolean(r["IsInputsAttached"]);
					_IsInputsConfirmed = Convert.ToBoolean(r["IsInputsConfirmed"]);
					_IsActsAttached = Convert.ToBoolean(r["IsActsAttached"]);
					_IsActsConfirmed = Convert.ToBoolean(r["IsActsConfirmed"]);
					_IsTripsReturnsAttached = Convert.ToBoolean(r["IsTripsReturnsAttached"]);
					_IsTripsReturnsConfirmed = Convert.ToBoolean(r["IsTripsReturnsConfirmed"]);
					_IsTripReturnAutoAttached = Convert.ToBoolean(r["IsTripReturnAutoAttached"]);

					if (!Convert.IsDBNull(r["WayBillID"]))
						_WayBillID = Convert.ToInt32(r["WayBillID"]);
					if (!Convert.IsDBNull(r["PassID"]))
						_PassID = Convert.ToInt32(r["PassID"]);

					_DepartmentName = r["DepartmentName"].ToString();

					_TripStatus = Convert.ToInt32(r["TripStatus"]);
					_Note = r["Note"].ToString();
					_NoteExecute = r["NoteExecute"].ToString();
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о рейсе...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о рейсе (нет данных)...";
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

			_DateTrip = DateTime.Now.Date;
			_TripNumber = 0;
			_Alias = null;

			_SelfDelivery = false;
			_IsRentCar = false;

			_CarID = null;
			_CarName = null;
			_CarNumber = null;
			_TrailerNumber = null;

			_CarTypeID = null;
			_CarTypeName = null;
			
			_DriverEmployeeID = null;
			_DriverName = null;
			_DriverPhone = null;
			_PartnerCarrierID = null;
			_PartnerCarrierName = null;

			_Tonnage = 0;
			_IsPassengerCar = false;
			_IsPostern = false;
			_IsLoadLift = false;

			_PermitLevelID = 0;
			_PermitLevelName = null;
			_PermitLevelValue = 0;

			_Volume = 0;
			_MaxPalletsQnt = 0;
			_MaxPointsQnt = 0;
			_MaxDurationMinutes = 0;

			_Race = 0;

			_OutputsNetto = 0;
			_OutputsNetto = 0;
			_OutputsVolume = 0;
			_OutputsPalletsQnt = 0;
			_OutputsChargePercent = 0;

			_OutputsDocumentsNetto = 0;
			_OutputsDocumentsNetto = 0;
			_OutputsDocumentsVolume = 0;
			_OutputsDocumentsPalletsQnt = 0;
			_OutputsDocumentsChargePercent = 0;
			_OutputsDocumentsPointsQnt = 0;

			_InputsNetto = 0;
			_InputsBrutto = 0;
			_InputsVolume = 0;
			_InputsPalletsQnt = 0;
			_InputsChargePercent = 0;

			_InputsDocumentsNetto = 0;
			_InputsDocumentsBrutto = 0;
			_InputsDocumentsVolume = 0;
			_InputsDocumentsPalletsQnt = 0;
			_InputsDocumentsChargePercent = 0;
			_InputsDocumentsPointsQnt = 0;

			_DateBegPlan = null;
			_DateEndPlan = null;
			_DurationMinutesPlan = null;
			_DurationHoursMinutesPlan = null;
			_DateBeg = null;
			_DateEnd = null;
			_DurationMinutes = null;
			_DurationHoursMinutes = null;
			_DepartureTime = null;
			_ArrivalTime = null;

			_ByOrder = null;

			_ReadyForPrint = false;
			_IsPrinted = false;
			_DatePrint = null;

			_ReadyForTripBeg = null;
			_ReadyForTripEnd = null;

			_DateConfirm = null;
			_IsConfirmed = false;
			_UserConfirmID = null;
			_UserConfirmName = null;

			_CostNormID = null;
			_CostNormName = null;
			_CostPlan = 0;
			_Cost = 0;
			_Distance = 0;

			_IsOutputsDocumentsAttached = false;
			_IsOutputsDocumentsBrought = false;
			
			_IsInputsDocumentsAttached = false;

			_IsOutputsAttached = false;
			_IsOutputsConfirmed = false;

			_IsInputsAttached = false;
			_IsInputsConfirmed = false;
			
			_IsActsAttached = false;
			_IsActsConfirmed = false;
			
			_IsTripsReturnsAttached = false;
			_IsTripsReturnsConfirmed = false;
			_IsTripReturnAutoAttached = false;

			_WayBillID = null;
			_PassID = null;

			_DepartmentName = null;

			_TripStatus = 0;
			_Note = null;
			_NoteExecute = null;
			_ERPCode = null; 

		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// сохранение данных рейса
		/// </summary>
		public bool SaveOne()
		{
			string _sqlCommand = "execute up_TripsSave @nTripID output, " +
									"@dDateTrip, " +
									"@nTripNumber, " +
									"@bSelfDelivery, " +
									"@cAlias, " + 
									"@nCarID, @nDriverEmployeeID, " +
									"@cCarName, @cCarTypeName, " +
									"@cCarNumber, @cTrailerNumber, " + 
									"@cDriverName, @cDriverPhone, " + 
									"@nPartnerCarrierID, " + 
									"@nTonnage, @bIsPassengerCar, @bIsPostern, @bIsLoadLift, @nPermitLevelID, " + 
									"@cNote, " +
									"@nCost, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDateTrip", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateTrip;

			_oParameter = _oCommand.Parameters.Add("@nTripNumber", SqlDbType.Int);
			_oParameter.Value = _TripNumber;

			_oParameter = _oCommand.Parameters.Add("@bSelfDelivery", SqlDbType.Bit);
			_oParameter.Value = _SelfDelivery;

			_oParameter = _oCommand.Parameters.Add("@cAlias", SqlDbType.VarChar);
			if (_Alias != null)
				_oParameter.Value = _Alias;
			else
				_oParameter.Value = DBNull.Value;

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
			if (CarNumber != null)
				_oParameter.Value = CarNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTrailerNumber", SqlDbType.VarChar);
			if (TrailerNumber != null)
				_oParameter.Value = TrailerNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverName", SqlDbType.VarChar);
			if (_DriverName != null)
				_oParameter.Value = _DriverName;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDriverPhone", SqlDbType.VarChar);
			if (_DriverPhone != null)
				_oParameter.Value = _DriverPhone;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPartnerCarrierID", SqlDbType.Int);
			if (_PartnerCarrierID != null)
				_oParameter.Value = _PartnerCarrierID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nTonnage", SqlDbType.Int);
			_oParameter.Value = _Tonnage;

			_oParameter = _oCommand.Parameters.Add("@bIsPassengerCar", SqlDbType.Bit);
			_oParameter.Value = _IsPassengerCar;

			_oParameter = _oCommand.Parameters.Add("@bIsPostern", SqlDbType.Bit);
			_oParameter.Value = _IsPostern;
			
			_oParameter = _oCommand.Parameters.Add("@bIsLoadLift", SqlDbType.Bit);
			_oParameter.Value = _IsLoadLift;

			_oParameter = _oCommand.Parameters.Add("@nPermitLevelID", SqlDbType.Int);
			_oParameter.Value = _PermitLevelID;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			_oParameter.Value = _Note;

			_oParameter = _oCommand.Parameters.Add("@nCost", SqlDbType.Decimal);
			_oParameter.Precision = 15;
			_oParameter.Scale = 3;
			_oParameter.Value = _Cost; 

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
				_ErrorStr = "Ошибка при попытке сохранения рейса...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении рейса...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании нового рейса - получим его код
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nTripID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nTripID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// удаление рейса
		/// </summary>
		public bool DeleteOne(int nTripID)
		{
			String _sqlCommand = "execute up_TripsDelete @nTripID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

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
				_ErrorStr = "Ошибка при попытке удаления данных о рейсе...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении данных о рейсе...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool LogisticSave(DataTable dtPuts, DataTable dtTrips, int? nTripID)
		{
			
			string _sqlCommand = "execute up_LogisticDailySave @nTrip, @nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTrip", SqlDbType.Int);
			if (nTripID != null)
				_oParameter.Value = nTripID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			try
			{
				_Connect.Open();
				RFMUtilities.DataTableToTempTable(dtPuts, "#_Puts", _Connect);
				RFMUtilities.DataTableToTempTable(dtTrips, "#_Trips", _Connect);

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при попытке сохранения рейсов...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении рейсов...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// сохранение данных перед подтверждением рейса
		/// </summary>
		public bool PreConfirm()
		{
			string _sqlCommand = "execute up_TripsPreConfirm @nTripID, " +
					"@cNoteExecute, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsPreConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@cNoteExecute", SqlDbType.VarChar);
			_oParameter.Value = _NoteExecute;

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
				_ErrorStr = "Ошибка при попытке сохранения данных о рейсе (обработка расходных документов)...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении данных о рейсе (обработка документов)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// получение ID задания на недовоз для рейса
		/// </summary>
		public int? TripReturnAutoID(int nTripID)
		{
			int? nTripReturnAutoID = null;

			string _sqlCommand = "select .dbo.TripTripReturnAutoID(" + nTripID.ToString() + ") as TripReturnAutoID ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				DataTable dt = FillReadings(new SqlDataAdapter(_oCommand), null, "dt");
				if (dt != null && dt.Rows.Count == 1 &&
						!Convert.IsDBNull(dt.Rows[0]["TripReturnAutoID"]))
					nTripReturnAutoID = (int)dt.Rows[0]["TripReturnAutoID"];
			}
			catch (Exception ex)
			{
				_ErrorNumber = -111;
				_ErrorStr = "Ошибка при получении кода возврата-недовоз для рейса...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (nTripReturnAutoID);
		}

		/// <summary>
		/// подтверждение рейса
		/// </summary>
		public bool Confirm(int nUserConfirmID)
		{
			return (Confirm(false, nUserConfirmID));
		}

		public bool Confirm(bool? bZero, int nUserConfirmID)
		{
			string _sqlCommand = "execute up_TripsConfirm @nTripID, " +
					"@bZero, " +
					"@nUserConfirmID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@bZero", SqlDbType.Bit);
			if (bZero.HasValue)
				_oParameter.Value = bZero;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserConfirmID", SqlDbType.Int);
			_oParameter.Value = nUserConfirmID;

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
				_ErrorStr = "Ошибка при попытке подтверждения рейса...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при подтверждении рейса...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// снятие подтверждения рейса
		/// </summary>
		public bool UnConfirmOne(int? nUserConfirmID)
		{
			string _sqlCommand = "execute up_TripsUnConfirm @nTripID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsUnConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = _ID;

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
				_ErrorStr = "Ошибка при попытке снятии подтверждения рейса...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при снятии подтверждения рейса...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Trip Alias

		/// <summary>
		/// получение алиаса (описания) рейса
		/// </summary>
		public string GetAlias(int? nTripID, bool bSelfDelivery, bool bIsRentCar, 
			string sCarName, string sCarNumber, string sTrailerNumber, 
			int nTonnage, 
			bool bIsPassengerCar, bool bIsPostern, bool bIsLoadLift, 
			string sDriverName,  
			string sPermitLevelName)
		{
			string sAlias = "";

			string _sqlCommand = "select .dbo.TripAlias(";
			if (nTripID.HasValue)
				_sqlCommand += nTripID.ToString() + ", ";
			else
				_sqlCommand += "Null, ";
			_sqlCommand += (bSelfDelivery ? "1" : "0") + ", ";
			_sqlCommand += (bIsRentCar ? "1" : "0") + ", ";
			if (sCarName != null)
				_sqlCommand += "''" + sCarName + "'', ";
			else
				_sqlCommand += "Null, ";
			if (sCarNumber != null)
				_sqlCommand += "''" + sCarNumber + "'', ";
			else
				_sqlCommand += "Null, ";
			if (sTrailerNumber != null)
				_sqlCommand += "''" + sTrailerNumber + "'', ";
			else
				_sqlCommand += "Null, ";
			_sqlCommand += nTonnage.ToString() + ", ";
			_sqlCommand += (bIsPassengerCar ? "1" : "0") + ", ";
			_sqlCommand += (bIsPostern ? "1" : "0") + ", ";
			_sqlCommand += (bIsLoadLift ? "1" : "0") + ", ";
			if (sDriverName != null)
				_sqlCommand += "''" + sDriverName + "'', ";
			else
				_sqlCommand += "Null, ";
			if (sPermitLevelName != null)
				_sqlCommand += "''" + sPermitLevelName + "'' ";
			else
				_sqlCommand += "Null ";
			_sqlCommand += " as Alias";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableTripAlias");

				if (_DS.Tables["TableTripAlias"].Rows.Count > 0)
					sAlias = _DS.Tables["TableTripAlias"].Rows[0]["Alias"].ToString();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при получении описания рейса...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (sAlias);
		}

		#endregion Trip Alias

		#region Таблицы

		#region Нормативы стоимостей

		/// <summary>
		/// получение таблицы нормативов стоимостей (TableCostsNorms)
		/// </summary>
		public bool FillTableCostsNorms()
		{
			string sqlSelect =
				"select ID, Name, " +
						"Cost, Note, " +
						"Actual, " + 
						"ERPCode " +
					"from CostsNorms " +
					"where 1 = 1 ";
			if (_FilterCostsNormsActual.HasValue)
			{
				sqlSelect += " and Actual = " + (((bool)_FilterCostsNormsActual)?"1":"0");
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableCostsNorms = FillReadings(new SqlDataAdapter(_oCommand), _TableCostsNorms, "TableCostsNorms ");
				_TableCostsNorms.PrimaryKey = new DataColumn[] { _TableCostsNorms.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка нормативов стоимостей рейсов..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Нормативы стоимостей

		#region складские задания Puts 

		/// <summary>
		/// получение таблицы складских заданий в рейсе (TablePutsInTrip)
		/// </summary>
		public bool FillTablePutsInTrip(int nTripID)
		{
			return(FillTablePutsInTrip(nTripID, false)); 
		}

		public bool FillTablePutsInTrip(int nTripID, bool bAddCarriedPuts)
		{
			return (FillTablePutsInTrip(nTripID, 
				null, 
				null,
				null,
				bAddCarriedPuts, 
				null,
				null, null,
				null, null,
				null, null, null,
				null,
				null, null, null,
				null,
				null));
		}

		public bool FillTablePutsInTrip(int? nTripID, 
			bool? bIsInTrip,
			bool? bDeliveryNeed, 
			bool? bInputs, 
			bool? bAddCarriedPuts, 
			DateTime? dDate, 
			DateTime? dDateBeg, DateTime? @dDateEnd, 
			string sOutputsTypesList, string sInputsTypesList,
			bool? bReadyForWMS, bool? bIsConfirmed, bool? bIsCarried, 
			string sPartnersList, 
			bool? bPassengerCarOnly, bool? bPosternOnly, bool? bLoadLiftOnly, 
			int? nPermitLevelValueMin, 
			string sZonesList)
		{
			string sqlSelect = "execute up_TripsPutsFill @nTripID, " + 
									"@bIsInTrip, " + 
									"@bDeliveryNeed, " + 
									"@bInputs, " +
									"@bAddCarriedPuts, " +
									"@dDate, " +
									"@dDateBeg, @dDateEnd, " +
									"@cOutputsTypesList, @cInputsTypesList, " +
									"@bReadyForWMS, " +
									"@bIsConfirmed, " +
									"@bIsCarried, " +
                                    "@cPartnersList, " +
									"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
									"@nPermitLevelValueMin, " +
									"@cZonesList "; 
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsPutsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			if (nTripID != null)
				_oParameter.Value = nTripID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsInTrip", SqlDbType.Bit);
			if (bIsInTrip != null)
				_oParameter.Value = bIsInTrip;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDeliveryNeed", SqlDbType.Bit);
			if (bDeliveryNeed != null)
				_oParameter.Value = bDeliveryNeed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bInputs", SqlDbType.Bit);
			if (bInputs != null)
				_oParameter.Value = bInputs;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bAddCarriedPuts", SqlDbType.Bit);
			if (bAddCarriedPuts != null)
				_oParameter.Value = bAddCarriedPuts;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			if (dDate.HasValue)
				_oParameter.Value = dDate;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.SmallDateTime);
			if (dDateBeg.HasValue)
				_oParameter.Value = dDateBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.SmallDateTime);
			if (dDateEnd.HasValue)
				_oParameter.Value = dDateEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsTypesList", SqlDbType.VarChar);
			if (sOutputsTypesList != null)
				_oParameter.Value = sOutputsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsTypesList", SqlDbType.VarChar);
			if (sInputsTypesList != null)
				_oParameter.Value = sInputsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bReadyForWMS", SqlDbType.Bit);
			if (bReadyForWMS != null)
				_oParameter.Value = bReadyForWMS;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (bIsConfirmed != null)
				_oParameter.Value = bIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsCarried", SqlDbType.Bit);
			if (bIsCarried != null)
				_oParameter.Value = bIsCarried;
			else
				_oParameter.Value = DBNull.Value;


            _oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
			if (sPartnersList != null)
				_oParameter.Value = sPartnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPassengerCarOnly", SqlDbType.Bit);
			if (bPassengerCarOnly != null)
				_oParameter.Value = bPassengerCarOnly;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPosternOnly", SqlDbType.Bit);
			if (bPosternOnly != null)
				_oParameter.Value = bPosternOnly;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bLoadLiftOnly", SqlDbType.Bit);
			if (bLoadLiftOnly != null)
				_oParameter.Value = bLoadLiftOnly;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPermitLevelValueMin", SqlDbType.Int);
			if (nPermitLevelValueMin != null)
				_oParameter.Value = nPermitLevelValueMin;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cZonesList", SqlDbType.VarChar);
			if (sZonesList != null)
				_oParameter.Value = sZonesList;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TablePutsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TablePutsInTrip, "TablePutsInTrip");
				//_TablePutsInTrip.PrimaryKey = new DataColumn[] { _TablePutsInTrip.Columns[_ColumnID] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении списка заданий на приход/расход в рейсе..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		// для отображения "всех заданий" в списке рейсов
		public bool FillTablePutsInTripAll(int nTripID)
		{
			return (FillTablePutsInTripAll(nTripID, null));
		}

		public bool FillTablePutsInTripAll(int nTripID, bool? bAddCarriedPuts)
		{
			string sqlSelect = "execute up_TripsPutsAllFill @nTripID, " +
					"@bAddCarriedPuts";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsPutsAllFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			_oParameter = _oCommand.Parameters.Add("@bAddCarriedPuts", SqlDbType.Bit);
			if (bAddCarriedPuts != null)
				_oParameter.Value = bAddCarriedPuts;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TablePutsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TablePutsInTrip, "TablePutsInTrip");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении списка заданий, актов и возвратов в рейсе..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

        public bool FillTableGeoData(string sTripsList)
        {
            string sqlSelect = "execute up_TripsGeoDataFill @cTripsList";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_TripsGeoDataFill parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
            _oParameter.Value = sTripsList;

            #endregion

            try
            {
                _TableGeoData = FillReadings(new SqlDataAdapter(_oCommand), _TableGeoData, "TableGeoData");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -21;
                _ErrorStr = "Ошибка при получении географических данных о партнерах в рейсе..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        public bool FillTableDrivingSchemes(string sTripsList)
        {
            string sqlSelect = "execute up_TripsDrivingSchemesFill @cTripsList";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_TripsGeoDataFill parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
            _oParameter.Value = sTripsList;

            #endregion

            try
            {
                _TableDrivingSchemes = FillReadings(new SqlDataAdapter(_oCommand), _TableDrivingSchemes, "TableDrivingSchemes");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -21;
                _ErrorStr = "Ошибка при получении схем проезда в рейсе..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        public bool FillTableEfficiency(int nTripID)
        {
            string sqlSelect = "execute up_TripsEfficiencyFill @nTripID";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_TripsEfficiencyFill parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
            _oParameter.Value = nTripID;

            #endregion

            try
            {
                _TableEfficiency = FillReadings(new SqlDataAdapter(_oCommand), _TableEfficiency, "TableEfficiency");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -21;
                _ErrorStr = "Ошибка при получении данных для расчета экономической эффективности рейса..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        #region Outputs

		/// <summary>
		/// получение таблицы заданий на расход в рейсе (TableOutputsInTrip)
		/// </summary>
		public bool FillTableOutputsInTrip()
		{
			string sqlSelect = "execute up_OutputsFill " +
									"@cTripsList = " +
									((_ID.HasValue) ? _ID.ToString() : "-1");
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableOutputsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsInTrip, "TableOutputsInTrip");
				_TableOutputsInTrip.PrimaryKey = new DataColumn[] { _TableOutputsInTrip.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении списка заданий на расход в рейсе..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableOutputsInTrip(bool bMergeCarriedOutputs)
		{
			FillTableOutputsInTrip();

			if (bMergeCarriedOutputs && _ID.HasValue)
			{
				FillTableOutputsDocumentsCarriesInTrip((int)_ID);
				if (_TableOutputsDocumentsCarriesInTrip.Rows.Count > 0)
				{
					string sOutputsCarriedList = "";
					foreach (DataRow oc in _TableOutputsDocumentsCarriesInTrip.Rows)
					{
						if (!Convert.IsDBNull(oc["OutputID"]))
							sOutputsCarriedList += oc["OutputID"] + ",";
					}

					Output oOutputCarried = new Output();
					oOutputCarried.IDList = sOutputsCarriedList;
					oOutputCarried.FillDataAsync();
					if (oOutputCarried.MainTable.Rows.Count > 0)
					{
						_TableOutputsInTrip.Merge(oOutputCarried.MainTable);
					}
				}
			}
			return (true);
		}

        public bool FillTableTripsAllCosts(DateTime dDateBeg, DateTime dDateEnd)
        {
            string sqlSelect = "execute up_ReportTripsAllCosts @dDateBeg, @dDateEnd";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_ReportTripsAllCosts parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateBeg", SqlDbType.DateTime);
            _oParameter.Value = dDateBeg;
            _oParameter = _oCommand.Parameters.Add("@dDateEnd", SqlDbType.DateTime);
            _oParameter.Value = dDateEnd;

            #endregion

            try
            {
                _TableTripsAllCosts = FillReadings(new SqlDataAdapter(_oCommand), _TableTripsAllCosts, "TableTripsAllCosts");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -21;
                _ErrorStr = "Ошибка при получении стоимостных данных по всем заданиям в рейсах..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        #endregion Outputs

        #region Inputs

        /// <summary>
        /// получение таблицы заданий на приход в рейсе (TableInputsInTrip)
        /// </summary>
        public bool FillTableInputsInTrip()
		{
			string sqlSelect = "execute up_InputsFill " +
									"@cTripsList = " +
									((_ID.HasValue) ? _ID.ToString() : "-1");
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableInputsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsInTrip, "TableInputsInTrip");
				_TableInputsInTrip.PrimaryKey = new DataColumn[] { _TableInputsInTrip.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении списка заданий на приход в рейсе..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableInputsInTrip(bool bMergeCarriedOutputs)
		{
			FillTableInputsInTrip();

			if (bMergeCarriedOutputs && _ID.HasValue)
			{
				FillTableInputsDocumentsCarriesInTrip((int)_ID);
				if (_TableInputsDocumentsCarriesInTrip.Rows.Count > 0)
				{
					string sInputsCarriedList = "";
					foreach (DataRow ic in _TableInputsDocumentsCarriesInTrip.Rows)
					{
						if (!Convert.IsDBNull(ic["InputID"]))
							sInputsCarriedList += ic["InputID"] + ",";
					}

					Input oInputCarried = new Input();
					oInputCarried.IDList = sInputsCarriedList;
					oInputCarried.FillDataAsync();
					if (oInputCarried.MainTable.Rows.Count > 0)
					{
						_TableInputsInTrip.Merge(oInputCarried.MainTable);
					}
				}
			}
			return (true);
		}

		#endregion Inputs

		#region TripsReturns

		/// <summary>
		/// получение таблицы возвратов в рейсе (TableTripsReturnsInTrip)
		/// </summary>
		public bool FillTableTripsReturnsInTrip()
		{
			string sqlSelect = "execute up_TripsReturnsFill " +
									"@cTripsList = " +
									((_ID.HasValue) ? _ID.ToString() : "-1");
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableTripsReturnsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableTripsReturnsInTrip, "TableTripsReturnsInTrip");
				_TableTripsReturnsInTrip.PrimaryKey = new DataColumn[] { _TableTripsReturnsInTrip.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении списка заданий на приход в рейсе..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TripsReturns

        #region CarsTasks

        /// <summary>
        /// получение таблицы спецзаданий в рейсе (TableCarsTasksInTrip)
        /// </summary>
        public bool FillTableCarsTasksInTrip()
        {
            string sqlSelect = "execute up_CarsTasksFill " +
                                    "@cTripsList = " +
                                    ((_ID.HasValue) ? _ID.ToString() : "-1");
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            try
            {
                _TableCarsTasksInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsInTrip, "TableCarsTasksInTrip");
                _TableCarsTasksInTrip.PrimaryKey = new DataColumn[] { _TableCarsTasksInTrip.Columns[0] };
            }
            catch (Exception ex)
            {
                _ErrorNumber = -21;
                _ErrorStr = "Ошибка при получении списка спецзаданий в рейсе..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        #endregion CarsTasks

        #endregion Puts

        #region Документы

        #region OutputsDocuments

        /// <summary>
		/// получение таблицы расходных документов в рейсе (TableOutputsDocumentsInTrip)
		/// </summary>
		public bool FillTableOutputsDocumentsInTrip()
		{
			return (FillTableOutputsDocumentsInTrip(null));
		}

		public bool FillTableOutputsDocumentsInTrip(int? nOutputID)
		{
			string sqlSelect = "execute up_OutputsDocumentsFill " +
						"@bUseByOrderSort = 1, " +
						((nOutputID.HasValue) ? ("@cOutputsList = " + nOutputID.ToString() + ", ") : "") +
						"@cTripsList = " + 
						((_ID.HasValue) ? _ID.ToString() : "-1");
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableOutputsDocumentsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsInTrip, "TableOutputsDocumentsInTrip");
				_TableOutputsDocumentsInTrip.PrimaryKey = new DataColumn[] { _TableOutputsDocumentsInTrip.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка расходных документов, присоединенных к рейсу..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableOutputsDocumentsInTrip(bool bMergeCarriedOutputsDocuments)
		{
			return (FillTableOutputsDocumentsInTrip(null, bMergeCarriedOutputsDocuments));
		}

		public bool FillTableOutputsDocumentsInTrip(int? nOutputID, bool bMergeCarriedOutputsDocuments)
		{
			FillTableOutputsDocumentsInTrip(nOutputID);

			if (bMergeCarriedOutputsDocuments && _ID.HasValue)
			{
				FillTableOutputsDocumentsCarriesInTrip((int)_ID);
				if (_TableOutputsDocumentsCarriesInTrip.Rows.Count > 0)
				{
					string sOutputsDocumentsCarriedList = "";
					foreach (DataRow oc in _TableOutputsDocumentsCarriesInTrip.Rows)
					{
						if (!Convert.IsDBNull(oc["OutputDocumentID"]))
						{
							if (nOutputID.HasValue)
							{
								if (!Convert.IsDBNull(oc["OutputID"]) && Convert.ToInt32(oc["OutputID"]) == (int)nOutputID)
								{
									sOutputsDocumentsCarriedList += oc["OutputDocumentID"] + ",";
								}
							}
							else
							{
								sOutputsDocumentsCarriedList += oc["OutputDocumentID"] + ",";
							}
						}
					}

					if (sOutputsDocumentsCarriedList.Length > 0)
					{
						OutputDocument oOutputDocumentCarried = new OutputDocument();
						oOutputDocumentCarried.IDList = sOutputsDocumentsCarriedList;
						oOutputDocumentCarried.FillDataAsync();
						if (oOutputDocumentCarried.MainTable.Rows.Count > 0)
						{
                            // копирование части полей из таблицы перенесенных накладных
                            foreach (DataRow oc in _TableOutputsDocumentsCarriesInTrip.Rows)
                            {
                                if (oc["OutputDocumentID"].ToString().Length == 0)
                                    continue;

                                // Получение значений полей из журнала переносов
                                int nOutputDocumentID = Convert.ToInt32(oc["OutputDocumentID"]);
                                DateTime dOldDate = Convert.ToDateTime(oc["OldDate"]);

                                int nOutputDocumentFailReasonID = Convert.ToInt32(oc["OutputDocumentFailReasonID"]);
                                string sOutputDocumentFailReasonName = oc["OutputDocumentFailReasonName"].ToString();

                                int nGuiltyID = Convert.ToInt32(oc["GuiltyID"]);
                                string sGuiltyName = oc["GuiltyName"].ToString();
                                string sGuiltyEmployees = oc["GuiltyEmployees"].ToString();
                                bool bIsDriverFoul = Convert.ToBoolean(oc["IsDriverFoul"]);

                                // Поиск и замена значений в добавляемой таблице
                                foreach (DataRow r in oOutputDocumentCarried.MainTable.Rows)
                                {
                                    if (Convert.ToInt32(r["OutputDocumentID"]) == nOutputDocumentID)
                                    {
                                        r["DateOutput"] = dOldDate;

                                        r["OutputDocumentFailReasonID"] = nOutputDocumentFailReasonID;
                                        r["OutputDocumentFailReasonName"] = sOutputDocumentFailReasonName;

                                        r["GuiltyID"] = nGuiltyID;
                                        r["GuiltyName"] = sGuiltyName;
                                        r["GuiltyEmployees"] = sGuiltyEmployees;
                                        r["IsDriverFoul"] = bIsDriverFoul;

                                        break;
                                    }
                                }
                            }

                            // слияние таблиц
							_TableOutputsDocumentsInTrip.Merge(oOutputDocumentCarried.MainTable);
						}
					}
				}
			}
			return (true);
		}

		/// <summary>
		/// получение таблицы расходных документов в рейсе (TableOutputsDocumentsInTrip) - для маршрутного листа
		/// </summary>
		public bool FillBillTableOutputsDocumentsInTrip(int nTripID)
		{
			string sqlSelect = "execute up_TripsOutputsDocumentsFillBill @nTripID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsOutputsDocumentsFillBill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableOutputsDocumentsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsInTrip, "TableOutputsDocumentsInTrip");
				_TableOutputsDocumentsInTrip.PrimaryKey = new DataColumn[] { _TableOutputsDocumentsInTrip.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка расходных документов, прикрепленных к рейсу..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsDocuments 

		#region InputsDocuments 

		/// <summary>
		/// получение таблицы приходных документов в рейсе (TableInputsDocumentsInTrip)
		/// </summary>
		public bool FillTableInputsDocumentsInTrip()
		{
			return (FillTableInputsDocumentsInTrip(null));
		}

		public bool FillTableInputsDocumentsInTrip(int? nInputID)
		{
			string sqlSelect = "execute up_InputsDocumentsFill " +
						"@bUseByOrderSort = 1, " +
						((nInputID.HasValue) ? ("@cInputsList = " + nInputID.ToString() + ", ") : "") +  
						"@cTripsList = " + 
						((_ID.HasValue) ? _ID.ToString() : "-1");
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableInputsDocumentsInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsInTrip, "TableInputsDocumentsInTrip");
				_TableInputsDocumentsInTrip.PrimaryKey = new DataColumn[] { _TableInputsDocumentsInTrip.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка приходных документов, прикрепленных к рейсу..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableInputsDocumentsInTrip(bool bMergeCarriedInputsDocuments)
		{
			return (FillTableInputsDocumentsInTrip(null, bMergeCarriedInputsDocuments));
		}

		public bool FillTableInputsDocumentsInTrip(int? nInputID, bool bMergeCarriedInputsDocuments)
		{
			FillTableInputsDocumentsInTrip(nInputID);

			if (bMergeCarriedInputsDocuments && _ID.HasValue)
			{
				FillTableInputsDocumentsCarriesInTrip((int)_ID);
				if (_TableInputsDocumentsCarriesInTrip.Rows.Count > 0)
				{
					string sInputsDocumentsCarriedList = "";
					foreach (DataRow sc in _TableInputsDocumentsCarriesInTrip.Rows)
					{
						if (!Convert.IsDBNull(sc["InputDocumentID"]))
						{
							if (nInputID.HasValue)
							{
								if (!Convert.IsDBNull(sc["InputID"]) && Convert.ToInt32(sc["InputID"]) == (int)nInputID)
								{
									sInputsDocumentsCarriedList += sc["InputDocumentID"] + ",";
								}
							}
							else
							{
								sInputsDocumentsCarriedList += sc["InputDocumentID"] + ",";
							}
						}
					}

					if (sInputsDocumentsCarriedList.Length > 0)
					{
						InputDocument oInputDocumentCarried = new InputDocument();
						oInputDocumentCarried.IDList = sInputsDocumentsCarriedList;
						oInputDocumentCarried.FillDataAsync();
						if (oInputDocumentCarried.MainTable.Rows.Count > 0)
						{
							_TableInputsDocumentsInTrip.Merge(oInputDocumentCarried.MainTable);
						}
					}
				}
			}
			return (true);
		}

		#endregion InputsDocuments 

		#region Inputs a la OutputsDocuments (Bill)

		/// <summary>
		/// получение таблицы заданий на приход в рейсе в виде таблицы расходных документов в рейсе (DS.Tables["TableInputsInTripBill"]) - для маршрутного листа
		/// </summary>
		public bool FillBillTableInputsInTrip(int nTripID)
		{
			string sqlSelect = "execute up_TripsInputsFillBill @nTripID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsInputsFillBill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableInputsInTripBill");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка заданий на приход (накладные), прикрепленных к рейсу..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

        /// <summary>
        /// получение таблицы заданий на расход в рейсе в виде таблицы расходных документов в рейсе (DS.Tables["TableOutputsInTripBill"]) - для маршрутного листа
        /// </summary>
        public bool FillBillTableOutputsInTrip(int nTripID)
        {
            string sqlSelect = "execute up_TripsOutputsFillBill @nTripID, " +
                                    "@nError output, @cErrorText output";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_TripsInputsFillBill parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
            _oParameter.Value = nTripID;

            _oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
            _oParameter.Direction = ParameterDirection.InputOutput;
            _oParameter.Value = 0;

            _oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
            _oParameter.Direction = ParameterDirection.InputOutput;
            _oParameter.Value = "";

            #endregion

            try
            {
                FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsInTripBill");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -11;
                _ErrorStr = "Ошибка при получении списка заданий на расход, прикрепленных к рейсу..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        #endregion Inputs a la OutputsDocuments (Bill)

		#endregion Документы

		#region Перемещенные

		#region OutputsDocumentsOutputs

		/// <summary>
		/// получение списка перенесенных расходных документов и заданий на расход в рейсе (TableOutputsDocumentsOutputsCarriesInTrip)
		/// </summary>
		public bool FillTableOutputsDocumentsCarriesInTrip(int nTripID)
		{

			string sqlSelect = "execute up_OutputsDocumentsCarriesFill " +
									"@nTripID = " + nTripID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableOutputsDocumentsCarriesInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsInTrip, "TableOutputsDocumentsInTrip");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "Ошибка при получении списка перенесенных и скопированных расходных документов и заданий на расход, прикрепленных к рейсу..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsDocumentsOutputs

		#region InputsDocumentsInputs

		/// <summary>
		/// получение списка перенесенных приходных документов и заданий на приход в рейсе (TableInputsDocumentsInputsCarriesInTrip)
		/// </summary>
		public bool FillTableInputsDocumentsCarriesInTrip(int nTripID)
		{

			string sqlSelect = "execute up_InputsDocumentsCarriesFill " +
									"@nTripID = " + nTripID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableInputsDocumentsCarriesInTrip = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsInTrip, "TableInputsDocumentsInTrip");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "Ошибка при получении списка перенесенных приходных документов, прикрепленных к рейсу..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion InputsDocumentsInputs

		#endregion Перемещенные

		#endregion Таблицы


		#region CreateByDate

		/// <summary>
		/// создание списка рейсов на дату
		/// </summary>
		public bool CreateByDate(DateTime dDate)
		{
			string _sqlCommand = "execute up_TripsCreateByDate @dDate";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsCreateByDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dDate;

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "CarsByDate");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при создании списка рейсов на дату...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// сохранение списка рейсов на дату
		/// </summary>
		public bool SaveByDate(DataTable tCars, DateTime dDate)
		{
			string _sqlCommand = "execute up_TripsSaveByDate @dDate, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsSaveByDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dDate;

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
				if (tCars != null)
				{
					RFMUtilities.DataTableToTempTable(tCars, "#CarsByDate", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при сохранении списка рейсов на дату...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении списка рейсов на дату...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#region CreateByDate Other

		/// <summary>
		/// создание списка рейсов на дату - с другими машинами
		/// </summary>
		public bool CreateOthersByDate(DateTime dDate, int nCnt)
		{
			string _sqlCommand = "execute up_TripsOthersCreateByDate @dDate, @nCnt";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsCreateByDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dDate;

			_oParameter = _oCommand.Parameters.Add("@nCnt", SqlDbType.Int);
			_oParameter.Value = nCnt;

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "CarsByDate");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при создании списка рейсов на дату (другие машины)...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// сохранение списка рейсов на дату - для других машин
		/// </summary>
		public bool SaveOthersByDate(DataTable tCars, DateTime dDate, bool bSelfDelivery)
		{
			string _sqlCommand = "execute up_TripsOthersSaveByDate @dDate, @bSelfDelivery, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsSaveByDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dDate;

			_oParameter = _oCommand.Parameters.Add("@bSelfDelivery", SqlDbType.Bit);
			_oParameter.Value = bSelfDelivery;

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
				if (tCars != null)
				{
					RFMUtilities.DataTableToTempTable(tCars, "#CarsByDate", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при сохранении списка рейсов на дату (другие машины)...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении списка рейсов на дату (другие машины)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion CreateByDate Other

		#endregion CreateByDate

		#region Set/Clear (Date, Cost, Distance, ByOrder, Ready...)

		#region DateBeg, DateEnd

		/// <summary>
		/// поставить дату-время начала/окончания рейса
		/// nUserID: не исп.
		/// </summary>
		public bool SetDateTime(int nTripID, string sMode, string sPlanFact, DateTime? dDateTime, int? nUserID)
		{
			sMode = sMode.ToUpper();
			sPlanFact = sPlanFact.ToUpper();
			if (sPlanFact.Length == 0)
				sPlanFact = "FACT"; 

			if (!sMode.Contains("BEG") && !sMode.Contains("END"))
				return (false);
			if (!sPlanFact.Contains("PLAN") && !sPlanFact.Contains("FACT"))
				return (false);

			string sText = "";
			string _sqlCommand = "set dateformat dmy " +
								 "update Trips set ";
			if (sMode.Contains("BEG"))
			{
				_sqlCommand += "DateBeg";
				sText = "начала";
			}
			if (sMode.Contains("END"))
			{
				_sqlCommand += "DateEnd";
				sText = "окончания";
			}

			if (sPlanFact.Contains("PLAN"))
				_sqlCommand += "Plan ";
			if (sPlanFact.Contains("FACT"))
				_sqlCommand += " ";

			if (dDateTime.HasValue)
				_sqlCommand += " = '" + ((DateTime)dDateTime).ToString("dd.MM.yyyy HH:mm") + "' ";
			else
				_sqlCommand += " = Null ";

            _sqlCommand += " where ID = " + nTripID.ToString();

            // Проставляем время только если оно пустое
            if (dDateTime.HasValue)
            {
                _sqlCommand += " and ";
                if (sMode.Contains("BEG")) _sqlCommand += "DateBeg";
                if (sMode.Contains("END")) _sqlCommand += "DateEnd";
                if (sPlanFact.Contains("PLAN")) _sqlCommand += "Plan ";
                if (sPlanFact.Contains("FACT")) _sqlCommand += " ";
                _sqlCommand += "is Null";
            }

			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -201;
				_ErrorStr = "Ошибка при установкe " + (sPlanFact.Contains("PLAN") ? "планового" : "") + sText + " рейса...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion DateBeg, DateEnd

		#region DatePrint

		/// <summary>
		/// поставить/снять дату печати документов
		/// bClear: true - снять, false - поставить
		/// nUserID: не исп.
		/// </summary>
		public bool SetDatePrint(int nTripID)
		{
			return (SetDatePrint(nTripID, false, null));
		}

		public bool SetDatePrint(int nTripID, bool bClear, int? nUserID)
		{
			string _sqlCommand = "update Trips set DatePrint = " + ((bClear) ? "Null" : "GetDate()") +
				" where ID = " + nTripID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -203;
				_ErrorStr = "Ошибка при попытке " + ((bClear) ? "снятия" : "установки") + " даты-времени печати документов...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion DatePrint

		#region ReadyForWMS

		/// <summary>
		/// поставить/снять признак готовности к обработке на складе
		/// bClear: true - снять, false - поставить
		/// nUserID: не исп.
		/// </summary>

		public bool SetReadyForWMS(int nTripID)
		{
			return (SetReadyForWMS(nTripID, false, null));
		}

		public bool SetReadyForWMS(int nTripID, bool bClear, int? nUserID)
		{
			string _sqlCommand = "execute up_TripsSetReadyForWMS @nTripID, @bClear, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsSetReadyForWMS parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

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
				_ErrorStr = "Ошибка при попытке " + ((bClear) ? "снятия" : "установки") + " признака \"Готов к передаче в складскую систему\"...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при " + ((bClear) ? "снятии" : "установке") + " признака \"Готов к передаче в складскую систему\"...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ReadyForWMS

		#region Cost

		public bool TripCostSave(int nTripID, decimal nCost)
		{
			string _sqlCommand = "update Trips set Cost = " + nCost.ToString().Trim() +
				" where ID = " + nTripID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -71;
				_ErrorStr = "Ошибка сохранения себестоимости рейса...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Cost

		#region Distance

		public bool TripDistanceSave(int nTripID, int nDistance)
		{
			string _sqlCommand = "update Trips set Distance = " + nDistance.ToString().Trim() +
				" where ID = " + nTripID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -72;
				_ErrorStr = "Ошибка сохранения пробега по рейсу...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Distance

        #region Time in charge

        /// <summary>
        /// Расчет приблизительного времени пербывания у клиентов для заданного рейса.
        /// Если данные по клиенту не рассчитаны, берем время по умолчанию (15 мин).
        /// </summary>
        /// <param name="nTripID">Код рейса</param>
        /// <returns></returns>
        public int CalcTripDuration(int? nTripID)
        {
            if (!nTripID.HasValue)
                return 0;

            int nTripDuration = 0;

			string _sqlCommand = 
                "declare @nMinutes int; " + 
                "set @nMinutes = 0; " + 
                "select @nMinutes = sum(case when P.StayMinutes = 0 then 15 else P.StayMinutes end) " + 
	                "from Partners P with (nolock) " + 
	                "inner join ( " + 
		                "select distinct PD.PartnerID " + 
			                "from OutputsDocuments OD with (nolock) " + 
			                "inner join PartnersDetails PD with (nolock) on OD.PartnerDetailBayerID = PD.ID " + 
			                "where OD.TripID = " + nTripID.ToString() + 
		                "union " + 
		                "select distinct I.PartnerID " + 
			                "from Inputs I " +
                            "where I.TripID = " + nTripID.ToString() + 
		                ") X on P.ID = X.PartnerID; " +
                "select IsNull(@nMinutes, 0)";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
                nTripDuration = Convert.ToInt32(_oCommand.ExecuteScalar());
			}
			catch (Exception ex)
			{
				_ErrorNumber = -72;
				_ErrorStr = "Ошибка сохранения пробега по рейсу...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
                nTripDuration = 0;
			}
			finally
			{
				_Connect.Close();
			}
            return (nTripDuration);
        }

        #endregion

        #endregion Set/Clear (Date, Cost, Distance, ByOrder, Ready...)

        #region ToPass

        /// <summary>
		/// привязка к пропуску
		/// </summary>
		public bool ToPass(int nPassID)
		{
			string _sqlCommand = "execute up_TripsToPass @nTripID, " +
									"@nPassID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_TripsToPass parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nPassID", SqlDbType.Int);
			_oParameter.Value = nPassID;

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
				_ErrorStr = "Ошибка при попытке оформления пропуска для рейса...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при оформлении пропуска для рейса...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					PassID = nPassID;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ToPass

		#region Logistics

		#region AttachTrip

		public bool AttachTrip(bool bMode, int nID, int? nTripID)
		{
			string sID = nID.ToString().Trim();
			string sTripID = "Null";
			if (nTripID.HasValue)
				sTripID = nTripID.ToString().Trim();

			string _sqlCommand;
			//  bMode = true - Outputs, false - Inputs
			if (bMode)
			{
				_sqlCommand = 
					"update Outputs set TripID = " + sTripID + " where ID = " + sID + " " + 
					"update OutputsDocuments set TripID = " + sTripID + " where OutputID = " + sID;
			}
			else
			{
				_sqlCommand =
					"update Inputs set TripID = " + sTripID + " where ID = " + sID + " " +
					"update InputsDocuments set TripID = " + sTripID + " where InputID = " + sID;
			}

			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -31;
				_ErrorStr = "Ошибка привязки заданий к рейсу...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion AttachTrip

		#region CalcTripsInfoByDate

		public bool CalcTripsInfoByDate(DateTime dDateLogistic)
		{
			string sqlCommand = "select Alias as CarName, " +
				"IsNull(D.OCount, 0)  as OCount, " +
				"IsNull(D.Brutto, 0)  as OBrutto, " +
				"IsNull(D.VolumeR, 0) as OVolume, " +
				"IsNull(D.PalletsR,0) as OPallets, " +
				"T.IsPassengerCar, T.IsPostern, T.Tonnage, C.Volume, " + 
				"C.MaxPalletsQnt, C.MaxPointsQnt, C.MaxDurationMinutes, " +
				"T.Note, T.TripNumber, T.ID as TripID, T.DateBeg, T.DateEnd " +
				"from Trips T " +
				"left join Cars C on T.CarID = C.ID " +
				"inner join (select TripID, count(ID) as OCount, sum(Volume) as VolumeR, " +
								"sum(PalletsQnt) as PalletsR, sum(Brutto) as Brutto " +
								"from OutputsDocuments " +
								"where TripID is not Null and " +
									"datediff(day, DateOutput, '" + @dDateLogistic.Date.ToString("yyyyMMdd") + "'" + ") = 0 " +
								"group by TripID) D on D.TripID = T.ID " +
				"order by 1 ";
			SqlCommand _oCommand = new SqlCommand(sqlCommand, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TripsInfoByDate");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -31;
				_ErrorStr = "Ошибка получения списка рейсов...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion CalcTripsInfoByDate

		#region Put in Trip

		public bool IsPutInTrip(int? nOutputID, int? nInputID, int? nCarTaskID)
		{
            if (!nOutputID.HasValue && !nInputID.HasValue && !nCarTaskID.HasValue)
				return (false);

			string sqlCommand = "";
            if (nCarTaskID.HasValue)
            {
                sqlCommand = "select TripID " +
                    "from CarsTasks with (nolock) " +
                    "where ID = " + nCarTaskID.ToString();
            }
            else if (nOutputID.HasValue)
			{
				sqlCommand = "select TripID " +
					"from Outputs with (nolock) " +
					"where ID = " + nOutputID.ToString();
			}
			else
			{
				sqlCommand = "select TripID " +
						"from Inputs with (nolock) " +
						"where ID = " + nInputID.ToString();
			}
			SqlCommand _oCommand = new SqlCommand(sqlCommand, _Connect);
			bool bIsPutInTrip = false;
			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "Temp_PutInTrip");
				if (_DS.Tables.Contains("Temp_PutInTrip") &&
					_DS.Tables["Temp_PutInTrip"] != null &&
					_DS.Tables["Temp_PutInTrip"].Rows.Count > 0 &&
					!Convert.IsDBNull(_DS.Tables["Temp_PutInTrip"].Rows[0]["TripID"]))
				{
					bIsPutInTrip = true;
				}
			}
			catch (Exception ex)
			{
				_ErrorNumber = -118;
				_ErrorStr = "Ошибка получения данных о текущем состоянии задания...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (bIsPutInTrip);
		}

		#endregion Put in Trip

		#endregion Logistics

		#region ByOrder

		public bool SaveByOrder(int nTripID, int nByOrder)
		{
			string _sqlCommand = "update Trips set ByOrder = " + nByOrder.ToString().Trim() +
				" where ID =" + nTripID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "Ошибка сохранения порядка отправления машин...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ByOrder

		#region Balance

		public bool Report_TripOutputsBalance(int nTripID)
		{
			string sqlSelect = "execute up_TripsOutputsBalanceCalc @nTripID";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			#endregion

			try
			{
				_Connect.Open();
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsBalance");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных о балансе рейса (расходы)...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		public bool Report_TripInputsBalance(int nTripID)
		{
			string sqlSelect = "execute up_TripsInputsBalanceCalc @nTripID";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

			#endregion

			try
			{
				_Connect.Open();
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableInputsBalance");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении данных о балансе рейса (приходы)...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Balance

		#region CreateReturnAct

		/// <summary>
		/// получение таблицы расхождений в расходных документах для одновременного формирования возврата по рейсу и акта 
		/// oTrip.DS.Tables["TripReturnActGoods"]
		/// </summary>
		public bool CreateReturnAct(int nTripID)
		{
			string _sqlCommand = "execute up_TripsReturnActsCreate @nTripID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnActsCreate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

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
				FillReadings(new SqlDataAdapter(_oCommand), null, "TripReturnActGoods");
				//_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -102;
				_ErrorStr = "Ошибка при попытке получения данных о расхождениях в рейсе для формирования возврата/акта...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при получении данных о расхождениях в рейсе для формирования возврата/акта...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion CreateReturnAct

        #region ItemsByOrder

        public bool ChangeItemsByOrder(int TripID, int? InputID, int? OutputID, int? CarTaskID, bool MoveUp, bool KeepTogether)
        {
            string _sqlCommand = "execute up_TripsChangeItemsByOrder " + TripID.ToString() +
                ", " + (InputID.HasValue ? InputID.ToString() : "Null") +
                ", " + (OutputID.HasValue ? OutputID.ToString() : "Null") + 
                ", " + (CarTaskID.HasValue ? CarTaskID.ToString() : "Null") +
                ", " + (MoveUp ? "1" : "0") + 
                ", " + (KeepTogether ? "1" : "0");
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
            try
            {
                _Connect.Open();
                _oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _ErrorNumber = -55;
                _ErrorStr = "Ошибка установки порядка загрузки машины...\r\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return (_ErrorNumber == 0);
        }

        #endregion

        #region Set Farthest Zone

        public bool SetFarthestZone(int TripID, int ZoneID)
        {
            string _sqlCommand = "update Trips set FarthestZoneID = " + ZoneID.ToString() + 
                " where ID = " + TripID.ToString();
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
            try
            {
                _Connect.Open();
                _oCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                _ErrorNumber = -55;
                _ErrorStr = "Ошибка установки самой дальней зоны в рейсе...\r\n" + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            finally
            {
                _Connect.Close();
            }
            return (_ErrorNumber == 0);
        }

        #endregion
    }

#endregion Trip

}
