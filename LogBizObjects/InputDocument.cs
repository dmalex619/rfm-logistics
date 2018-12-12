using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ��������� �������� (����� �� �������� ������) (InputDocument)
/// </summary>
/// 
namespace LogBizObjects
{

#region InputDocument 

	public class InputDocument : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ��������� ���������� (InputsDocuments.ID)
		/// </summary>
		[Description("������ ����� ID ��������� ���������� (InputsDocuments.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateInput;
		/// <summary>
		/// ���� ������� (InputsDocuments.DateInput)
		/// </summary>
		[Description("���� ������� (InputsDocuments.DateInput)")]
		public DateTime DateInput { get { return _DateInput; } set { _DateInput = value; } }

		protected bool _DeliveryNeed;
		/// <summary>
		/// ��������� ���� �������� (����� ��� ������ �������) (InputsDocuments.DeliveryNeed)?
		/// </summary>
		[Description("��������� ���� �������� (����� ��� ������ �������) (InputsDocuments.DeliveryNeed)?")]
		public bool DeliveryNeed { get { return _DeliveryNeed; } set { _DeliveryNeed = value; } }

		protected int _InputDocumentTypeID;
		/// <summary>
		/// ��� ���������� ��������� - ��� (InputsDocuments.InputDocumentTypeID)
		/// </summary>
		[Description("��� ���������� ��������� - ��� (InputsDocuments.InputDocumentTypeID)")]
		public int InputDocumentTypeID { get { return _InputDocumentTypeID; } set { _InputDocumentTypeID = value; } }

		protected string _InputDocumentTypeName;
		/// <summary>
		/// ��� ���������� ��������� - ������������ (InputsDocuments.InputDocumentTypeID -> InputsDocumentsTypes.Name)
		/// </summary>
		[Description("��� ���������� ��������� - ������������ (InputsDocuments.InputDocumentTypeID -> InputsDocumentsTypes.Name)")]
		public string InputDocumentTypeName { get { return _InputDocumentTypeName; } set { _InputDocumentTypeName = value; } }

		protected bool _IsRefund;
		/// <summary>
		/// ��� ���������� ��������� - ������� (InputsDocuments.InputDocumentTypeID -> InputsDocumentsTypes.IsRefund)
		/// </summary>
		[Description("��� ���������� ��������� - ������� (InputsDocuments.InputDocumentTypeID -> InputsDocumentsTypes.IsRefund)")]
		public bool IsRefund { get { return _IsRefund; } set { _IsRefund = value; } }


		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (InputsDocuments.PartnerID -> Partners.OwnerID)
		/// </summary>
		[Description("�������� ������ - ��� (InputsDocuments.PartnerID -> Partners.OwnerID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// �������� ������ - ������������ (InputsDocuments.PartnerID -> Partners.OwnerID -> Owners.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (InputsDocuments.PartnerID -> Partners.OwnerID -> Owners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

		protected int? _GoodStateID;
		/// <summary>
		/// ��������� ������ - ��� (InputsDocuments.PartnerID -> Partners.GoodStateID)
		/// </summary>
		[Description("��������� ������ - ��� (InputsDocuments.PartnerID -> Partners.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// ��������� ������ - ������������ (InputsDocuments.PartnerID -> Partners.GoodStateID -> GoodStates.Name)
		/// </summary>
		[Description("��������� ������ - ������������ (InputsDocuments.PartnerID -> Partners.GoodStateID -> GoodStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int _PartnerSourceID;
		/// <summary>
		/// ������-��������� - ��� (InputsDocuments.PartnerSourceID)
		/// </summary>
		[Description("������-��������� - ��� (InputsDocuments.PartnerSourceID)")]
		public int PartnerSourceID { get { return _PartnerSourceID; } set { _PartnerSourceID = value; } }

		protected string _PartnerSourceName;
		/// <summary>
		/// ������-��������� - ������������ (InputsDocuments.PartnerSourceID -> InputsDocumentsTypes.Name)
		/// </summary>
		[Description("������-��������� - ������������ (InputsDocuments.PartnerSourceID -> InputsDocumentsTypes.Name)")]
		public string PartnerSourceName { get { return _PartnerSourceName; } set { _PartnerSourceName = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// ���� �������-���������� - ��� (InputsDocuments.PartnerID -> Partners.ZoneID)
		/// </summary>
		[Description("���� �������-���������� - ��� (InputsDocuments.PartnerID -> Partners.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// ���� �������-���������� - ������������ (InputsDocuments.PartnerID -> Partners.ZoneID -> Zones.Name)
		/// </summary>
		[Description("���� �������-���������� - ������������ (InputsDocuments.PartnerID -> Partners.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _ZoneAlias;
		/// <summary>
		/// ���� �������-���������� - ������� ������������ (InputsDocuments.PartnerAliasID -> Partners.ZoneID -> Zones.Alias)
		/// </summary>
		[Description("���� �������-���������� - ������� ������������ (InputsDocuments.PartnerAliasID -> Partners.ZoneID -> Zones.Alias)")]
		public string ZoneAlias { get { return _ZoneAlias; } set { _ZoneAlias = value; } }

		protected int _PartnerTargetID;
		/// <summary>
		/// ������-���������� (��) - ��� (InputsDocuments.PartnerTargetID)
		/// </summary>
		[Description("������-���������� (��) - ��� (InputsDocuments.PartnerTargetID)")]
		public int PartnerTargetID { get { return _PartnerTargetID; } set { _PartnerTargetID = value; } }

		protected string _PartnerTargetName;
		/// <summary>
		/// ������-���������� (��) - ������������ (InputsDocuments.PartnerTargetID -> Partners.Name)
		/// </summary>
		[Description("������-���������� (��) - ������������ (InputsDocuments.PartnerTargetID -> Partners.Name)")]
		public string PartnerTargetName { get { return _PartnerTargetName; } set { _PartnerTargetName = value; } }

		protected string _DeliveryAddress;
		/// <summary>
		/// ����� �������� �������-���������� (InputsDocuments.PartnerID -> Partners.DeliveryAddress)
		/// </summary>
		[Description("����� �������� �������-���������� (InputsDocuments.PartnerID -> Partners.DeliveryAddress)")]
		public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

		protected string _DeliveryPassage;
		/// <summary>
		/// ������ ��� �������-���������� (InputsDocuments.PartnerID -> Partners.DeliveryPassage)
		/// </summary>
		[Description("������ ��� �������-���������� (InputsDocuments.PartnerID -> Partners.DeliveryPassage)")]
		public string DeliveryPassage { get { return _DeliveryPassage; } set { _DeliveryPassage = value; } }

		protected bool _PassengerCarOnly;
		/// <summary>
		/// �������� ������ �������� ������� (InputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("�������� ������ �������� ������� (InputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool PassengerCarOnly { get { return _PassengerCarOnly; } set { _PassengerCarOnly = value; } }

		protected bool _PosternOnly;
		/// <summary>
		/// �������� ������ ������� � ������ ������ (InputsDocuments.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ������ ������ (InputsDocuments.PartnerTargetID -> Partners.PosternOnly)?")]
		public bool PosternOnly { get { return _PosternOnly; } set { _PosternOnly = value; } }

		protected bool _LoadLiftOnly;
		/// <summary>
		/// �������� ������ ������� � ����������� (�������) (InputsDocuments.PartnerTargetID -> Partners.LoadLiftOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ����������� (�������) (InputsDocuments.PartnerTargetID -> Partners.LoadLiftOnly)?")]
		public bool LoadLiftOnly { get { return _LoadLiftOnly; } set { _LoadLiftOnly = value; } }

		protected int _PermitLevelID;
		/// <summary>
		/// ���������� ������� (���������) - ��� (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID)
		/// </summary>
		[Description("���������� ������� (���������) - ��� (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID)")]
		public int PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// ���������� ������� (���������) - ������������ (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("���������� ������� (���������) - ������������ (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int _PermitLevelValue;
		/// <summary>
		/// ���������� ������� (���������) - �������, �� ����� (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("���������� ������� (���������) - �������, �� ����� (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected int _Priority;
		/// <summary>
		/// ��������� (InputsDocuments.Priority)
		/// </summary>
		[Description("��������� (InputsDocuments.Priority)")]
		public int Priority { get { return _Priority; } set { _Priority = value; } }

		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (InputsDocuments.TripID)
		/// </summary>
		[Description("���� - ��� (InputsDocuments.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected bool _TripExists;
		/// <summary>
		/// ��������� �������� ����������� � ����� (InputsDocuments.TripID is not Null)?
		/// </summary>
		[Description("��������� �������� ����������� � ����� (InputsDocuments.TripID is not Null)?")]
		public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }

		protected int? _CarID;
		/// <summary>
		/// ������ - ��� (InputsDocuments.TripID -> Trips.CarID)
		/// </summary>
		[Description("������ - ��� (InputsDocuments.TripID -> Trips.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// ������ - ������������ (InputsDocuments.TripID -> Trips.CarID -> Cars.Name)
		/// </summary>
		[Description("������ - ������������ (InputsDocuments.TripID -> Trips.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// ���������-�������� - ��� (InputsDocuments.TripID -> Trips.DriverEmployeeID)
		/// </summary>
		[Description("���������-�������� - ��� (InputsDocuments.TripID -> Trips.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// ���������-�������� - ������������ (InputsDocuments.TripID -> Trips.DriverEmployeeID -> Employees.Name)
		/// </summary>
		[Description("���������-�������� - ������������ (InputsDocuments.TripID -> Trips.DriverEmployeeID -> Employees.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected DateTime? _DateBegPlan;
		/// <summary>
		/// ����-����� ������ ���������� - ���� (InputsDocuments.DateBegPlan)
		/// </summary>
		[Description("����-����� ������ ���������� - ���� (InputsDocuments.DateBegPlan)")]
		public DateTime? DateBegPlan { get { return _DateBegPlan; } set { _DateBegPlan = value; } }

		protected DateTime? _DateEndPlan;
		/// <summary>
		/// ����-����� ��������� ���������� - ���� (InputsDocuments.DateEndPlan)
		/// </summary>
		[Description("����-����� ��������� ���������� - ���� (InputsDocuments.DateEndPlan)")]
		public DateTime? DateEndPlan { get { return _DateEndPlan; } set { _DateEndPlan = value; } }

		protected int? _DurationMinutesPlan;
		/// <summary>
		/// ������������ ����������, ���. - ���� (InputsDocuments.DurationMinutesPlan())
		/// </summary>
		[Description("������������ ����������, ���. - ���� (InputsDocuments.DurationMinutesPlan())")]
		public int? DurationMinutesPlan { get { return _DurationMinutesPlan; } set { _DurationMinutesPlan = value; } }

		protected DateTime? _DateBegFact;
		/// <summary>
		/// ����-����� ������ ���������� - ���� (InputsDocuments.DateBegFact)
		/// </summary>
		[Description("����-����� ������ ���������� - ���� (InputsDocuments.DateBegFact)")]
		public DateTime? DateBegFact { get { return _DateBegFact; } set { _DateBegFact = value; } }

		protected DateTime? _DateEndFact;
		/// <summary>
		/// ����-����� ��������� ���������� - ���� (InputsDocuments.DateEndFact)
		/// </summary>
		[Description("����-����� ��������� ���������� - ���� (InputsDocuments.DateEndFact)")]
		public DateTime? DateEndFact { get { return _DateEndFact; } set { _DateEndFact = value; } }

		protected int? _DurationMinutesFact;
		/// <summary>
		/// ������������ ����������, ���. - ���� (InputsDocuments.DurationMinutesFact())
		/// </summary>
		[Description("������������ ����������, ���. - ���� (InputsDocuments.DurationMinutesFact())")]
		public int? DurationMinutesFact { get { return _DurationMinutesFact; } set { _DurationMinutesFact = value; } }

		protected decimal _Amount;
		/// <summary>
		/// ��������� � ��������� ��������� - ��������� ����� (InputsDocuments.Amount)
		/// </summary>
		[Description("��������� � ��������� ��������� - ��������� ����� (InputsDocuments.Amount)")]
		public decimal Amount { get { return _Amount; } set { _Amount = value; } }

		protected int _CurrencyID;
		/// <summary>
		/// ������ ��� � ��������� ��������� - ��� (InputsDocuments.CurrencyID)
		/// </summary>
		[Description("������ ��� � ��������� ��������� - ��� (InputsDocuments.CurrencyID)")]
		public int CurrencyID { get { return _CurrencyID; } set { _CurrencyID = value; } }

		protected string _CurrencyName;
		/// <summary>
		/// ������ ��� � ��������� ��������� - ������������ (InputsDocuments.CurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ ��� � ��������� ��������� - ������������ (InputsDocuments.CurrencyID -> Currencies.Name)")]
		public string CurrencyName { get { return _CurrencyName; } set { _CurrencyName = value; } }

		protected decimal _Netto;
		/// <summary>
		/// ��� ������������ ������ - �����, �� (InputsDocuments.Netto)
		/// </summary>
		[Description("��� ������������ ������ - �����, �� (InputsDocuments.Netto)")]
		public decimal Netto { get { return _Netto; } set { _Netto = value; } }

		protected decimal _Brutto;
		/// <summary>
		/// ��� ������������ ������ - ������, �� (InputsDocuments.Brutto)
		/// </summary>
		[Description("��� ������������ ������ - ������, �� (InputsDocuments.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected decimal _PalletsQnt;
		/// <summary>
		/// ���������� ����������� ������ � ������� (InputsDocuments.PalletsQnt)
		/// </summary>
		[Description("���������� ����������� ������ � ������� (InputsDocuments.PalletsQnt)")]
		public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }

		protected decimal _Volume;
		/// <summary>
		/// �����, �3 (InputsDocuments.Volume)
		/// </summary>
		[Description("�����, �3 (InputsDocuments.Volume)")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }


		protected DateTime? _DateBill;
		/// <summary>
		/// ���� ���������� ���������� (InputsDocuments.DateBill)
		/// </summary>
		[Description("���� ���������� ���������� (InputsDocuments.DateBill)")]
		public DateTime? DateBill { get { return _DateBill; } set { _DateBill = value; } }

		protected string _BillNumber;
		/// <summary>
		/// � ��������� ���������� (InputsDocuments.BillNumber)
		/// </summary>
		[Description("� ��������� ���������� (InputsDocuments.BillNumber)")]
		public string BillNumber { get { return _BillNumber; } set { _BillNumber = value; } }

		protected string _FactureNumber;
		/// <summary>
		/// � �����-������� ���������� (InputsDocuments.FactureNumber)
		/// </summary>
		[Description("� �����-������� ���������� (InputsDocuments.FactureNumber)")]
		public string FactureNumber { get { return _FactureNumber; } set { _FactureNumber = value; } }

		protected decimal _AmountBill;
		/// <summary>
		/// ��������� � ��������� ��������� - �� ���������� ���������� (InputsDocuments.AmountBill)
		/// </summary>
		[Description("��������� � ��������� ��������� - �� ���������� ���������� (InputsDocuments.AmountBill)")]
		public decimal AmountBill { get { return _AmountBill; } set { _AmountBill = value; } }

		protected decimal _VatAmountBill;
		/// <summary>
		/// ����� ��� � ��������� ��������� - �� ���������� ���������� (InputsDocuments.VatAmountBill)
		/// </summary>
		[Description("����� ��� � ��������� ��������� - �� ���������� ���������� (InputsDocuments.VatAmountBill)")]
		public decimal VatAmountBill { get { return _VatAmountBill; } set { _VatAmountBill = value; } }

		protected bool _PF_WarrantNeed;
		/// <summary>
		/// ����� ������������ (InputsDocuments.PF_WarrantNeed)?
		/// </summary>
		[Description("����� ������������ (InputsDocuments.PF_WarrantNeed)?")]
		public bool PF_WarrantNeed { get { return _PF_WarrantNeed; } set { _PF_WarrantNeed = value; } }

		protected string _WarrantNumber;
		/// <summary>
		/// ����� ������������ (InputsDocuments.WarrantNumber)?
		/// </summary>
		[Description("����� ������������ (InputsDocuments.WarrantNumber)?")]
		public string WarrantNumber { get { return _WarrantNumber; } set { _WarrantNumber = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � ���������� ���������(InputsDocuments.Note)
		/// </summary>
		[Description("���������� � ���������� ���������(InputsDocuments.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _NoteExecute;
		/// <summary>
		/// ���������� � ���������� (InputsDocuments.NoteExecute)
		/// </summary>
		[Description("���������� � ���������� (InputsDocuments.NoteExecute)")]
		public string NoteExecute { get { return _NoteExecute; } set { _NoteExecute = value; } }

		protected string _ManagerName;
		/// <summary>
		/// �������� - ��� (InputsDocuments.ManagerName)
		/// </summary>
		[Description("�������� - ��� (InputsDocuments.ManagerName)")]
		public string ManagerName { get { return _ManagerName; } set { _ManagerName = value; } }

		protected string _ManagerPhone;
		/// <summary>
		/// �������� - ������� (InputsDocuments.ManagerPhone)
		/// </summary>
		[Description("�������� - ������� (InputsDocuments.ManagerPhone)")]
		public string ManagerPhone { get { return _ManagerPhone; } set { _ManagerPhone = value; } }
		
		protected int? _ByOrder;
		/// <summary>
		/// ����� �/� ��� �������� (InputsDocuments.ByOrder)
		/// </summary>
		[Description("����� �/� ��� �������� (InputsDocuments.ByOrder)")]
		public int? ByOrder { get { return _ByOrder; } set { _ByOrder = value; } }

		
		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������ �� ������ (InputsDocuments.DateConfirm)
		/// </summary>
		[Description("����-����� ������ �� ������ (InputsDocuments.DateConfirm)")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// ����� �� ������ ����������� (InputsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("����� �� ������ ����������� (InputsDocuments.Confirmed)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }

		protected int? _UserConfirmID;
		/// <summary>
		/// ������������, ������������� ����� �� ������ - ��� (InputsDocuments.UserConfirmID)
		/// </summary>
		[Description("������������, ������������� ����� �� ������ - ��� (InputsDocuments.UserConfirmID)")]
		public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

		protected string _UserConfirmName;
		/// <summary>
		/// ������������, ������������� ����� �� ������ - ��� (InputsDocuments.UserConfirmID -> _Users.Name)
		/// </summary>
		[Description("������������, ������������� ����� �� ������ - ��� (InputsDocuments.UserConfirmID -> _Users.Name)")]
		public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }


		protected DateTime? _DateBring;
		/// <summary>
		/// ����-����� ����� ������ �� ���������� ���������� (InputsDocuments.DateBring)
		/// </summary>
		[Description("����-����� ����� ������ �� ���������� ���������� (InputsDocuments.DateBring)")]
		public DateTime? DateBring { get { return _DateBring; } set { _DateBring = value; } }

		protected int? _UserBringID;
		/// <summary>
		/// ������������, ������� ���� ������ �� ���������� ���������� - ��� (InputsDocuments.UserBringID)
		/// </summary>
		[Description("������������, ������� ���� ������ �� ���������� ���������� - ��� (InputsDocuments.UserBringID)")]
		public int? UserBringID { get { return _UserBringID; } set { _UserBringID = value; } }

		protected string _UserBringName;
		/// <summary>
		/// ������������, ������� ���� ������ �� ���������� ���������� - ��� (InputsDocuments.UserBringID -> _Users.Name)
		/// </summary>
		[Description("������������, ������� ���� ������ �� ���������� ���������� - ��� (InputsDocuments.UserBringID -> _Users.Name)")]
		public string UserBringName { get { return _UserBringName; } set { _UserBringName = value; } }


		protected decimal _DeliveryPrice;
		/// <summary>
		/// ��������� �������� (InputsDocuments.DeliveryPrice)
		/// </summary>
		[Description("��������� �������� (InputsDocuments.DeliveryPrice)")]
		public decimal DeliveryPrice { get { return _DeliveryPrice; } set { _DeliveryPrice = value; } }

		protected int? _DeliveryCurrencyID;
		/// <summary>
		/// ������ �������� - ��� (InputsDocuments.DeliveryCurrencyID)
		/// </summary>
		[Description("������ �������� - ��� (InputsDocuments.DeliveryCurrencyID)")]
		public int? DeliveryCurrencyID { get { return _DeliveryCurrencyID; } set { _DeliveryCurrencyID = value; } }

		protected string _DeliveryCurrencyName;
		/// <summary>
		/// ������ �������� - ������������ (InputsDocuments.DeliveryCurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ �������� - ������������ (InputsDocuments.DeliveryCurrencyID -> Currencies.Name)")]
		public string DeliveryCurrencyName { get { return _DeliveryCurrencyName; } set { _DeliveryCurrencyName = value; } }


		protected int? _InputID;
		/// <summary>
		/// ������� �� ������ - ��� (InputsDocuments.InputID)
		/// </summary>
		[Description("������� �� ������ - ��� (InputsDocuments.InputID)")]
		public int? InputID { get { return _InputID; } set { _InputID = value; } }

		protected bool _IsInputExists;
		/// <summary>
		/// ���������� ������� �� ������ (InputsDocuments.InputID is not Null)?
		/// </summary>
		[Description("���������� ������� �� ������ (InputsDocuments.InputID is not Null)?")]
		public bool IsInputExists { get { return _IsInputExists; } set { _IsInputExists = value; } }

		protected DateTime? _InputDateConfirm;
		/// <summary>
		/// ����-����� ������������� ������� �� ������ (InputsDocuments.InputID -> Inputs.DateConfirm)
		/// </summary>
		[Description("����-����� ������������� ������� �� ������ (InputsDocuments.InputID -> Inputs.DateConfirm)")]
		public DateTime? InputDateConfirm { get { return _InputDateConfirm; } set { _InputDateConfirm = value; } }

		protected bool _IsInputConfirmed;
		/// <summary>
		/// ������� �� ������ ������������ (InputsDocuments.InputID -> Inputs.DateConfirm is not Null)?
		/// </summary>
		[Description("������� �� ������ ������������ (InputsDocuments.InputID -> Inputs.DateConfirm is not Null)?")]
		public bool IsInputConfirmed { get { return _IsInputConfirmed; } set { _IsInputConfirmed = value; } }


		protected bool _IsCarried;
		/// <summary>
		/// ��������� �������� ��������� �� ������ ���� (InputsDocuments.IsCarried)?
		/// </summary>
		[Description("��������� �������� ��������� �� ������ ���� (InputsDocuments.IsCarried)?")]
		public bool IsCarried { get { return _IsCarried; } set { _IsCarried = value; } }

		protected bool _IsCopied;
		/// <summary>
		/// ��������� �������� ��������� �� ������ ���� � ���������� (.dbo.InputDocumentIsCopied(ID))?
		/// </summary>
		[Description("��������� �������� ��������� �� ������ ���� � ���������� (.dbo.InputDocumentIsCopied(ID))?")]
		public bool IsCopied { get { return _IsCopied; } set { _IsCopied = value; } }

		protected int? _CopiedFromInputDocumentID;
		/// <summary>
		/// ��������� �������� ��� ������ �� ������� ��������� - ��� (.dbo.InputDocumentCopiedFrom(ID))?
		/// </summary>
		[Description("��������� �������� ��� ������ �� ������� ��������� - ��� (.dbo.InputDocumentCopiedFrom(ID))?")]
		public int? CopiedFromInputDocumentID { get { return _CopiedFromInputDocumentID; } set { _CopiedFromInputDocumentID = value; } }


		protected string _UnionCode;
		/// <summary>
		/// ��� ����������� (������ ��������) (InputsDocuments.UnionCode)
		/// </summary>
		[Description("��� ����������� (������ ��������) (InputsDocuments.UnionCode)")]
		public string UnionCode { get { return _UnionCode; } set { _UnionCode = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (InputsDocuments.HostID)
		/// </summary>
		[Description("Host  - ��� (InputsDocuments.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (InputsDocuments.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (InputsDocuments.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// ��� ���������� ��������� � host-������� (InputsDocuments.ERPCode)
		/// </summary>
		[Description("��� ���������� ��������� � host-������� (InputsDocuments.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �����

		protected bool? _UseByOrderSort;
		/// <summary>
		/// ��������� MainTable � ����������� �� ByOrder?
		/// </summary>
		[Description("��������� MainTable � ����������� �� ByOrder?")]
		public bool? UseByOrderSort { get { return _UseByOrderSort; } set { _UseByOrderSort = value; } }

		#endregion �����

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ �������� ����� host-��, ����� ������� (InputsDocuments.HostID)
		/// </summary>
		[Description("������-����: ������ �������� ����� host-��, ����� ������� (InputsDocuments.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateInput;
		/// <summary>
		/// ������-����: ���� ���������� ��������� - ����� (InputsDocuments.DateInput)
		/// </summary>
		[Description("������-����: ���� ���������� ��������� - ����� (InputsDocuments.DateInput)")]
		public DateTime? FilterDateInput { get { return _FilterDateInput; } set { _FilterDateInput = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ���������� ��������� - ��������� ���� ������� (InputsDocuments.DateInput)
		/// </summary>
		[Description("������-����: ���� ���������� ��������� - ��������� ���� ������� (InputsDocuments.DateInput)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ���������� ��������� - �������� ���� ������� (InputsDocuments.DateInput)
		/// </summary>
		[Description("������-����: ���� ���������� ��������� - �������� ���� ������� (InputsDocuments.DateInput)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }
		
		protected string _FilterInputsDocumentsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� ��������� ����������, ����� ������� (InputsDocuments.InputDocumentTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� ��������� ����������, ����� ������� (InputsDocuments.InputDocumentTypeID)")]
		public string FilterInputsDocumentsTypesList { get { return _FilterInputsDocumentsTypesList; } set { _FilterInputsDocumentsTypesList = value; _NeedRequery = true; } }

		protected bool? _FilterDeliveryNeed;
		/// <summary>
		/// ������-����: ��������� ���� �������� (����� ��� ������ �������) (InputsDocuments.DeliveryNeed)?
		/// </summary>
		[Description("������-����: ��������� ���� �������� (����� ��� ������ �������) (InputsDocuments.DeliveryNeed)?")]
		public bool? FilterDeliveryNeed { get { return _FilterDeliveryNeed; } set { _FilterDeliveryNeed = value; _NeedRequery = true; } }

		protected string _FilterPartnersSourceList;
		/// <summary>
		/// ������-����: ������ ����� ��������-�����������, ����� ������� (InputsDocuments.PartnerSourceID)
		/// </summary>
		[Description("������-����: ������ ����� ��������-�����������, ����� ������� (InputsDocuments.PartnerSourceID)")]
		public string FilterPartnersSourceList { get { return _FilterPartnersSourceList; } set { _FilterPartnersSourceList = value; _NeedRequery = true; } }

		protected string _FilterPartnersTargetList;
		/// <summary>
		/// ������-����: ������ ����� ��������-����������� (��), ����� ������� (InputsDocuments.PartnerTargetID)
		/// </summary>
		[Description("������-����: ������ ����� ��������-����������� (��), ����� ������� (InputsDocuments.PartnerTargetID)")]
		public string FilterPartnersTargetList { get { return _FilterPartnersTargetList; } set { _FilterPartnersTargetList = value; _NeedRequery = true; } }

		protected bool? _FilterTripExists;
		/// <summary>
		/// ������-����: ��������� �������� ����������� � ����� (InputsDocuments.TripID is not Null)?
		/// </summary>
		[Description("������-����: ��������� �������� ����������� � ����� (InputsDocuments.TripID is not Null)?")]
		public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (InputsDocuments.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (InputsDocuments.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// ������-����: ������ ����� ����������, ����� ������� (InputsDocuments.OwnerID)
		/// </summary>
		[Description("������-����: ������ ����� ����������, ����� ������� (InputsDocuments.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }


		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: ����� �� ������ ����������� (InputsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: ����� �� ������ ����������� (InputsDocuments.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterIsCarried;
		/// <summary>
		/// ������-����: ��������� �������� ��������� �� ������ ���� (InputsDocuments.IsCarried)?
		/// </summary>
		[Description("������-����: ��������� �������� ��������� �� ������ ���� (InputsDocuments.IsCarried)?")]
		public bool? FilterIsCarried { get { return _FilterIsCarried; } set { _FilterIsCarried = value; _NeedRequery = true; } }


		protected string _FilterBillNumberContext;
		/// <summary>
		/// ������-����: �������� ������ ��������� (InputsDocuments.BillNumber)
		/// </summary>
		[Description("������-����: �������� �������� (InputsDocuments.BillNumber)")]
		public string FilterBillNumberContext { get { return _FilterBillNumberContext; } set { _FilterBillNumberContext = value; _NeedRequery = true; } }


		protected string _FilterUnionCode;
		/// <summary>
		/// ������-����: ������������ ��� - ��������� (InputsDocuments.UnionCode)?
		/// </summary>
		[Description("������-����: ������������ ��� - ��������� (InputsDocuments.UnionCode)?")]
		public string FilterUnionCode { get { return _FilterUnionCode; } set { _FilterUnionCode = value; _NeedRequery = true; } }


		protected bool? _FilterPassengerCarOnly;
		/// <summary>
		/// ������-����: �������� �������� ������� (InputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("������-����: �������� �������� ������� (InputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? FilterPassengerCarOnly { get { return _FilterPassengerCarOnly; } set { _FilterPassengerCarOnly = value; _NeedRequery = true; } }

		protected bool? _FilterPosternOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ������ (InputsDocuments.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ������ (InputsDocuments.PartnerTargetID -> Partners.Postern)?")]
		public bool? FilterPosternOnly { get { return _FilterPosternOnly; } set { _FilterPosternOnly = value; _NeedRequery = true; } }

		protected bool? _FilterLoadLiftOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ����������� (�������) (InputsDocuments.PartnerTargetID -> Partners.LoadLift)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ����������� (�������) (InputsDocuments.PartnerTargetID -> Partners.LoadLift)?")]
		public bool? FilterLoadLiftOnly { get { return _FilterLoadLiftOnly; } set { _FilterLoadLiftOnly = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// ������-����: ���������� ������� - �������, �� ����� (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("������-����: ���������� ������� - �������, �� ����� (InputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }


		protected bool? _FilterIsInputExists;
		/// <summary>
		/// ������-����: ���������� ������� �� ������ (InputsDocuments.InputID is not Null)?
		/// </summary>
		[Description("������-����: ���������� ������� �� ������ (InputsDocuments.InputID is not Null)?")]
		public bool? FilterIsInputExists { get { return _FilterIsInputExists; } set { _FilterIsInputExists = value; _NeedRequery = true; } }

		protected string _FilterInputsList;
		/// <summary>
		/// ������-����: ������ ����� ������� �� ������, ����� ������� (InputsDocuments.InputID)
		/// </summary>
		[Description("������-����: ������ ����� ������� �� ������, ����� ������� (InputsDocuments.InputID)")]
		public string FilterInputsList { get { return _FilterInputsList; } set { _FilterInputsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsInputConfirmed;
		/// <summary>
		/// ������� �� ������ ������������ (InputsDocuments.InputID -> Inputs.DateConfirm FilterIs not Null)?
		/// </summary>
		[Description("������� �� ������ ������������ (InputsDocuments.InputID -> Inputs.DateConfirm FilterIs not Null)?")]
		public bool? FilterIsInputConfirmed { get { return _FilterIsInputConfirmed; } set { _FilterIsInputConfirmed = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (InputsDocuments.ID --> InputsDocumentsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (InputsDocuments.ID --> InputsDocumentsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (InputsDocuments.ID --> InputsDocumentsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (InputsDocuments.ID --> InputsDocumentsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableInputsDocumentsGoods;
		/// <summary>
		/// ������� ������� � ��������� ��������� InputsDocumentsGoods
		/// </summary>
		[Description("������� ������� � ��������� ��������� InputsDocumentsGoods")]
		public DataTable TableInputsDocumentsGoods { get { return _TableInputsDocumentsGoods; } }

		protected DataTable _TableInputsDocumentsTypes;
		/// <summary>
		/// ������� ����� ��������� ���������� InputsDocumentsTypes
		/// </summary>
		[Description("������� ����� ��������� ���������� InputsDocumentsTypes")]
		public DataTable TableInputsDocumentsTypes { get { return _TableInputsDocumentsTypes; } }

		protected DataTable _TableInputsDocumentsFailsReasons;
		/// <summary>
		/// ������� ������ ������������ (����������) InputsDocumentsFailsReasons
		/// </summary>
		[Description("������� ������������ (����������) InputsDocumentsFailsReasons")]
		public DataTable TableInputsDocumentsFailsReasons { get { return _TableInputsDocumentsFailsReasons; } }

		protected DataTable _TableReturnsReasons;
		/// <summary>
		/// ������� ������ �������� ������� ReturnsReasons
		/// </summary>
		[Description("������� �������� ������� ReturnsReasons")]
		public DataTable TableReturnsReasons { get { return _TableReturnsReasons; } }

		#endregion �������

		// ----------------------------

		public InputDocument()
			: base()
		{
			_MainTableName = "InputsDocuments";
			_ColumnID = "ID";
			_ColumnName = "DateInput";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ��������� ���������� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_InputsDocumentsFill @nID, @cIDList, " +
									"@cHostsList, " +
									"@bUseByOrderSort, " +
									"@dDateInput, " + 
									"@dDateBeg, " +
									"@dDateEnd, " +
									"@cInputsDocumentsTypesList, " +
									"@bDeliveryNeed, " +
									"@cPartnersSourceList, @cPartnersTargetList, " + 
									"@bTripExists, @cTripsList, " +
									"@cOwnersList, " + 
									"@bIsConfirmed, " +
									"@bIsCarried, " +
									"@cBillNumberContext, " + 
									"@cUnionCode, " + 
									"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
									"@nPermitLevelValueMin, " + 
									"@bIsInputExists, @cInputsList, @bIsInputConfirmed, " + 
									"@cPackingsList, @cGoodsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@bUseByOrderSort", SqlDbType.Bit);
			if (_UseByOrderSort.HasValue && (bool)_UseByOrderSort)
				_oParameter.Value = _UseByOrderSort;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateInput", SqlDbType.SmallDateTime);
			if (_FilterDateInput.HasValue)
				_oParameter.Value = _FilterDateInput;
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

			_oParameter = _oCommand.Parameters.Add("@cInputsDocumentsTypesList", SqlDbType.VarChar);
			if (_FilterInputsDocumentsTypesList != null)
				_oParameter.Value = _FilterInputsDocumentsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDeliveryNeed", SqlDbType.Bit);
			if (_FilterDeliveryNeed != null)
				_oParameter.Value = _FilterDeliveryNeed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersSourceList", SqlDbType.VarChar);
			if (_FilterPartnersSourceList != null)
				_oParameter.Value = _FilterPartnersSourceList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersTargetList", SqlDbType.VarChar);
			if (_FilterPartnersTargetList != null)
				_oParameter.Value = _FilterPartnersTargetList;
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

			_oParameter = _oCommand.Parameters.Add("@cBillNumberContext", SqlDbType.VarChar);
			if (_FilterBillNumberContext != null)
				_oParameter.Value = _FilterBillNumberContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cUnionCode", SqlDbType.VarChar);
			if (_FilterUnionCode != null)
				_oParameter.Value = _FilterUnionCode;
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

			_oParameter = _oCommand.Parameters.Add("@bIsInputExists", SqlDbType.Bit);
			if (_FilterIsInputExists != null)
				_oParameter.Value = _FilterIsInputExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsList", SqlDbType.VarChar);
			if (_FilterInputsList != null)
				_oParameter.Value = _FilterInputsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsInputConfirmed", SqlDbType.Bit);
			if (_FilterIsInputConfirmed != null)
				_oParameter.Value = _FilterIsInputConfirmed;
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
				_ErrorStr = "������ ��� ��������� ������ ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillDataByOrder()
		{
			ClearData();

			_UseByOrderSort = true;
			bool bResult = FillData();
			_UseByOrderSort = null;

			return (bResult);
		}

		/// <summary>
		/// ������� ������-�����
		/// </summary>
		public void ClearFilters()
		{
			_IDList = null;

			_FilterHostsList = null;

			_FilterDateInput = null; 
			_FilterDateBeg = null; 
			_FilterDateEnd = null;
			_FilterInputsDocumentsTypesList = null;
			_FilterDeliveryNeed = null;
			_FilterIsConfirmed = null;
			_FilterIsCarried = null;

			_FilterPassengerCarOnly = null;
			_FilterPosternOnly = null;
			_FilterLoadLiftOnly = null;
			_FilterPermitLevelValueMin = null;

			_FilterPartnersSourceList = null;
			_FilterPartnersTargetList = null;

			_FilterTripExists = null;
			_FilterTripsList = null;

			_FilterOwnersList = null;

			_FilterBillNumberContext = null;

			_FilterUnionCode = null;
			_FilterIsInputExists = null;
			_FilterInputsList = null;
			_FilterIsInputConfirmed = null; 
			_FilterPackingsList = null;
			_FilterGoodsList = null;
			//_NeedRequery = true;
		}

		#endregion FillData

		#region FillOne

		// ���������� ���������� ������� ���������� ������� ������� ������ 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();

			if (r != null)
			{
				try
				{
					_ID = Convert.ToInt32(r["ID"]);

					_DateInput = Convert.ToDateTime(r["DateInput"]);
					_DeliveryNeed = Convert.ToBoolean(r["DeliveryNeed"]);

					_InputDocumentTypeID = Convert.ToInt32(r["InputDocumentTypeID"]);
					_InputDocumentTypeName = r["InputDocumentTypeName"].ToString();
					_IsRefund = Convert.ToBoolean(r["IsRefund"]);

					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					if (!Convert.IsDBNull(r["GoodStateID"]))
						_GoodStateID = Convert.ToInt32(r["GoodStateID"]);
					_GoodStateName = r["GoodStateName"].ToString();

					_PartnerSourceID = Convert.ToInt32(r["PartnerSourceID"]);
					_PartnerSourceName = r["PartnerSourceName"].ToString();
					if (!Convert.IsDBNull(r["ZoneID"]))
						_ZoneID = Convert.ToInt32(r["ZoneID"]);
					_ZoneName = r["ZoneName"].ToString();
					_ZoneAlias = r["ZoneAlias"].ToString();
					_DeliveryAddress = r["DeliveryAddress"].ToString();
					_DeliveryPassage = r["DeliveryPassage"].ToString();
					_PartnerTargetID = Convert.ToInt32(r["PartnerTargetID"]);
					_PartnerTargetName = r["PartnerTargetName"].ToString();

					_PassengerCarOnly = Convert.ToBoolean(r["PassengerCarOnly"]);
					_PosternOnly = Convert.ToBoolean(r["PosternOnly"]);
					_LoadLiftOnly = Convert.ToBoolean(r["LoadLiftOnly"]);
					_PermitLevelID = Convert.ToInt32(r["PermitLevelID"]);
					_PermitLevelName = r["PermitLevelName"].ToString();
					_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);

					_TripExists = Convert.ToBoolean(r["TripExists"]);
					if (!Convert.IsDBNull(r["TripID"]))
					{
						_TripID = Convert.ToInt32(r["TripID"]);
						if (!Convert.IsDBNull(r["CarID"]))
						{
							_CarID = Convert.ToInt32(r["CarID"]);
							_CarName = r["CarName"].ToString();
						}
						if (!Convert.IsDBNull(r["DriverEmployeeID"]))
						{
							_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
							_DriverName = r["DriverName"].ToString();
						}
					}

					_Priority = Convert.ToInt32(r["Priority"]);

					if (!Convert.IsDBNull(r["DateBegPlan"]))
						_DateBegPlan = Convert.ToDateTime(r["DateBegPlan"]);
					if (!Convert.IsDBNull(r["DateEndPlan"]))
						_DateEndPlan = Convert.ToDateTime(r["DateEndPlan"]);
					if (!Convert.IsDBNull(r["DurationMinutesPlan"]))
						_DurationMinutesPlan = Convert.ToInt32(r["DurationMinutesPlan"]);
					if (!Convert.IsDBNull(r["DateBegFact"]))
						_DateBegFact = Convert.ToDateTime(r["DateBegFact"]);
					if (!Convert.IsDBNull(r["DateEndFact"]))
						_DateEndFact = Convert.ToDateTime(r["DateEndFact"]);
					if (!Convert.IsDBNull(r["DurationMinutesFact"]))
						_DurationMinutesFact = Convert.ToInt32(r["DurationMinutesFact"]);

					_Amount = Convert.ToDecimal(r["Amount"]);
					_CurrencyID = Convert.ToInt32(r["CurrencyID"]);
					_CurrencyName = r["CurrencyName"].ToString();

					_Netto = Convert.ToDecimal(r["Netto"]);
					_Brutto = Convert.ToDecimal(r["Brutto"]);

					_PalletsQnt = Convert.ToDecimal(r["PalletsQnt"]);
					_Volume = Convert.ToDecimal(r["Volume"]);

					_ManagerName = r["ManagerName"].ToString();
					_ManagerPhone = r["ManagerPhone"].ToString();

					if (!Convert.IsDBNull(r["DateBill"]))
						_DateBill = Convert.ToDateTime(r["DateBill"]);
					_BillNumber = r["BillNumber"].ToString();
					_FactureNumber = r["FactureNumber"].ToString();
					_AmountBill = Convert.ToDecimal(r["AmountBill"]);
					_VatAmountBill = Convert.ToDecimal(r["VatAmountBill"]);

					_PF_WarrantNeed = Convert.ToBoolean(r["PF_WarrantNeed"]);
					_WarrantNumber = r["WarrantNumber"].ToString();

					_Note = r["Note"].ToString();
					_NoteExecute = r["NoteExecute"].ToString();

					if (!Convert.IsDBNull(r["ByOrder"]))
						_ByOrder = Convert.ToInt32(r["ByOrder"]);
					
					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);
					if (!Convert.IsDBNull(r["UserConfirmID"]))
						_UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
					_UserConfirmName = r["UserConfirmName"].ToString();

					if (!Convert.IsDBNull(r["DateBring"]))
						_DateBring = Convert.ToDateTime(r["DateBring"]);
					if (!Convert.IsDBNull(r["UserBringID"]))
						_UserBringID = Convert.ToInt32(r["UserBringID"]);
					_UserBringName = r["UserBringName"].ToString();

					_DeliveryPrice = Convert.ToDecimal(r["DeliveryPrice"]);
					if (!Convert.IsDBNull(r["DeliveryCurrencyID"]))
					{
						_DeliveryCurrencyID = Convert.ToInt32(r["DeliveryCurrencyID"]);
						_DeliveryCurrencyName = r["DeliveryCurrencyName"].ToString();
					}

					_IsInputExists = Convert.ToBoolean(r["IsInputExists"]);
					if (!Convert.IsDBNull(r["InputID"]))
					{
						_InputID = Convert.ToInt32(r["InputID"]);
						if (!Convert.IsDBNull(r["InputDateConfirm"]))
							_InputDateConfirm = Convert.ToDateTime(r["InputDateConfirm"]);
					}
					_IsInputConfirmed = Convert.ToBoolean(r["IsInputConfirmed"]);

					if (!Convert.IsDBNull(r["UnionCode"]))
						_UnionCode = r["UnionCode"].ToString();

					_IsCarried = Convert.ToBoolean(r["IsCarried"]);
					if (!Convert.IsDBNull(r["CopiedFromInputDocumentID"]))
						_CopiedFromInputDocumentID = Convert.ToInt32(r["CopiedFromInputDocumentID"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ��������� ���������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ��������� ��������� (��� ������)...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������� ����������
		/// </summary>
		public void ClearOne()
		{
			_ID = null;

			_DateInput = DateTime.Now.Date;
			_DeliveryNeed = false;

			_InputDocumentTypeID = 0;
			_InputDocumentTypeName = null;
			_IsRefund = false;

			_OwnerID = null;
			_OwnerName = null;
			_GoodStateID = null;
			_GoodStateName = null;

			_PartnerSourceID = 0;
			_PartnerSourceName = null;
			_ZoneID = null;
			_ZoneName = null;
			_ZoneAlias = null;
			_DeliveryAddress = null;
			_DeliveryPassage = null;
			_PartnerTargetID = 0;
			_PartnerTargetName = null;

			_PassengerCarOnly = false;
			_PosternOnly = false;
			_LoadLiftOnly = false;
			_PermitLevelID = 0;
			_PermitLevelName = null;
			_PermitLevelValue = 0;

			_TripExists = false;
			_TripID = null;
			_CarID = null;
			_CarName = null;
			_DriverEmployeeID = null;
			_DriverName = null;

			_Priority = 0;

			_DateBegPlan = null;
			_DateEndPlan = null;
			_DurationMinutesPlan = null;
			_DateBegFact = null;
			_DateEndFact = null;
			_DurationMinutesFact = null;

			_Amount = 0;
			_CurrencyID = 0;
			_CurrencyName = null;

			_Netto = 0;
			_Brutto = 0;

			_PalletsQnt = 0;
			_Volume = 0;

			_ManagerName = null;
			_ManagerPhone = null;

			_DateBill = null;
			_BillNumber = null;
			_FactureNumber = null;
			_AmountBill = 0;
			_VatAmountBill = 0;

			_PF_WarrantNeed = false;
			_WarrantNumber = null;

			_Note = null;
			_NoteExecute = null;

			_ByOrder = 0;
			
			_DateConfirm = null;
			_IsConfirmed = false;
			_UserConfirmID = null;
			_UserConfirmName = null;

			_DateBring = null;
			_UserBringID = null;
			_UserBringName = null;

			_DeliveryPrice = 0;
			_DeliveryCurrencyID = null;
			_DeliveryCurrencyName = null;

			_IsInputExists = false;
			_InputID = null;
			_IsInputConfirmed = false;
			_InputDateConfirm = null;

			_UnionCode = null;

			_IsCarried = false;
			_CopiedFromInputDocumentID = null;

			_HostID = null;
			_HostName = null;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Confirm

		/// <summary>
		/// ������������� (������ ���������)
		/// </summary>
		public bool Confirm(int nUserConfirmID)
		{
			string _sqlCommand = "execute up_InputsDocumentsConfirm @nInputDocumentID, " +
									"@nUserConfirmID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nUserConfirmID", SqlDbType.Int);
			_oParameter.Value = nUserConfirmID;

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
				if (TableInputsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableInputsDocumentsGoods, "#InputsDocumentsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������������� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������������� (������ ������� ���������)
		/// </summary>
		public bool UnConfirm(int nUserConfirmID)
		{
			string _sqlCommand = "execute up_InputsDocumentsUnConfirm @nInputDocumentID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsUnConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Save

		/// <summary>
		/// ���������� ������ �� ���������� ����������
		/// </summary>
		public bool Save()
		{
			return (Save(null));
		}

		public bool Save(int? nUserID)
		{
			string _sqlCommand = "execute up_InputsDocumentsSave @nInputDocumentID, " +
									"@nInputID, " + 
									"@nCurrencyID, " +  
									"@dDateBill, @cBillNumber, @cFactureNumber, " +
									"@nAmountBill, @nVatAmountBill, " +
									"@cNote, " +
									"@nUserID, " + 
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			if (_InputID != null)
				_oParameter.Value = _InputID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCurrencyID", SqlDbType.Money);
			_oParameter.Value = _CurrencyID;

			_oParameter = _oCommand.Parameters.Add("@dDateBill", SqlDbType.SmallDateTime);
			if (_DateBill != null)
				_oParameter.Value = _DateBill;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cBillNumber", SqlDbType.VarChar);
			if (_BillNumber != null)
				_oParameter.Value = _BillNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cFactureNumber", SqlDbType.VarChar);
			if (_FactureNumber != null)
				_oParameter.Value = _FactureNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nAmountBill", SqlDbType.Money);
			_oParameter.Value = _AmountBill;

			_oParameter = _oCommand.Parameters.Add("@nVatAmountBill", SqlDbType.Money);
			_oParameter.Value = _VatAmountBill;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			_oParameter.Value = _Note;

			_oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			if (nUserID.HasValue)
				_oParameter.Value = nUserID;
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
				if (TableInputsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableInputsDocumentsGoods, "#InputsDocumentsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ���������� ������ �� ���������� ����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ �� ���������� ����������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save

		#region Delete

		/// <summary>
		/// �������� ���������� ���������
		/// </summary>
		public bool Delete(int nInputDocumentID)
		{
			String _sqlCommand = "execute up_InputsDocumentsDelete @nInputDocumentID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_InputsDocumentsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = nInputDocumentID;

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
				_ErrorStr = "������ ��� ������� �������� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete

		#region Copy

		/// <summary>
		/// ����������� ���������� ���������
		/// </summary>
		public bool Copy(int nUserBringID, ref int nNewInputDocumentID, bool bCopyGoods)
		{
			string _sqlCommand = "execute up_InputsDocumentsCopy @nInputDocumentID, " +
									"@nNewInputDocumentID output, " +
									"@bCopyGoods, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsCopy parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nNewInputDocumentID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bCopyGoods", SqlDbType.Bit);
			_oParameter.Value = bCopyGoods;

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
				_ErrorStr = "������ ��� ������� ����������� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����������� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					// ��� ������ ���������
					if (!Convert.IsDBNull(_oCommand.Parameters["@nNewInputDocumentID"].Value))
					{
						nNewInputDocumentID = Convert.ToInt32(_oCommand.Parameters["@nNewInputDocumentID"].Value);
					}
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Copy

		#region ToTrip

		/// <summary>
		/// �������� � �����. ������������ ������ ������ � �������� �� ������!
		/// </summary>
		public bool ToTrip(int nTripID)
		{ 
			if (!_ID.HasValue)
			{
				return (false);
			}
			return (ToTrip((int)_ID, nTripID));
		}

		public bool ToTrip(int nInputDocumentID, int nTripID)
		{
			string _sqlCommand = "update InputsDocuments set TripID = " + nTripID.ToString() + " " +
									" where ID = " + nInputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� �������� ���������� ��������� � �����...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ �������� ���������� ��������� � �����
		/// </summary>
		public bool UnToTrip()
		{
			if (!_ID.HasValue)
			{
				return (false);
			}
			return (UnToTrip((int)_ID));
		}

		public bool UnToTrip(int nInputDocumentID)
		{
			string _sqlCommand = "update InputsDocuments set TripID = Null " +
									" where ID = " + nInputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������ �������� ���������� ��������� � �����...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ToTrip


		#region Calc

		/// <summary>
		/// ��������� ��������� ������������� ��� ������ ��������� ����������
		/// </summary>
		public bool CalcSum(string sInputsDocumentsList,
			ref int nInputsDocumentsQnt, ref int nPartnersQnt, ref int nPointsQnt,
			ref decimal nNetto, ref decimal nBrutto, ref decimal nVolume, ref decimal nPalletsQnt)
		{
			string sqlSelect = "execute up_InputsDocumentsCalcSum @cInputsDocumentsList, " +
									"@nInputsDocumentsQnt output, " +
									"@nPartnersQnt output, " +
									"@nPointsQnt output, " +
									"@nNetto output, " +
									"@nBrutto output, " +
									"@nVolume output, " +
									"@nPalletsQnt output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cInputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sInputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@nInputsDocumentsQnt", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nPartnersQnt", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nPointsQnt", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nNetto", SqlDbType.Decimal);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nBrutto", SqlDbType.Decimal);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nVolume", SqlDbType.Decimal);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nPalletsQnt", SqlDbType.Decimal);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Precision = 9;
			_oParameter.Scale = 1;
			_oParameter.Value = 0;

			#endregion

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ��������� ������ �� ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (ErrorNumber == 0)
			{
				nInputsDocumentsQnt = Convert.ToInt32(_oCommand.Parameters["@nInputsDocumentsQnt"].Value);
				nPartnersQnt = Convert.ToInt32(_oCommand.Parameters["@nPartnersQnt"].Value);
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

		public bool SaveByOrder(int nInputDocumentID, int nByOrder)
		{
			string _sqlCommand = "update InputsDocuments set ByOrder = " + nByOrder.ToString().Trim() +
				" where ID =" + nInputDocumentID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "������ ���������� ������� ��������...\r\n" + ex.Message;
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
		/// ������� ���������� ��������� �� ������ ����
		/// </summary>
		public bool Carry(int nInputDocumentID, DateTime dNewDate, int? @nInputDocumentFailReasonID, 
			int? nUserID, ref int? nNewInputDocumentID)
		{
			string _sqlCommand = "execute up_InputsDocumentsCarry @nInputDocumentID, " +
					"@dNewDate, " +
					"@nInputDocumentFailReasonID, " +
					"@nUserCarryID, " +
					"@nNewInputDocumentID output, " +
					"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsCarry parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = nInputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@dNewDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dNewDate;

			_oParameter = _oCommand.Parameters.Add("@nInputDocumentFailReasonID", SqlDbType.Int);
			if (nInputDocumentFailReasonID.HasValue)
				_oParameter.Value = nInputDocumentFailReasonID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserCarryID", SqlDbType.Int);
			if (nUserID.HasValue)
				_oParameter.Value = nUserID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nNewInputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� �������� ���������� ��������� �� ������ ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ���������� ��������� �� ������ ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (!Convert.IsDBNull(_oCommand.Parameters["@nNewInputDocumentID"].Value))
						nNewInputDocumentID = (int)_oCommand.Parameters["@nNewInputDocumentID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ����� ���� ���������� ��������� �� ������ ����
		/// </summary>
		public bool ChangeDate(int nInputDocumentID, DateTime dNewDate)
		{
			string _sqlCommand = "execute up_InputsDocumentsChangeDate @nInputDocumentID, " +
					"@dNewDate, " +
					"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsChangeDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = nInputDocumentID;

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
				_ErrorStr = "������ ��� ������� ����� ���� ���������� ��������� �� ������ ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����� ���� ���������� ��������� �� ������ ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carry


		#region �������

		#region InputsDocumentsGoods

		/// <summary>
		/// ��������� ������� ������� � ��������� ��������� (TableInputsDocumentsGoods)
		/// </summary>
		public bool FillTableInputsDocumentsGoods(int nInputDocumentID)
		{
			string sqlSelect = "execute up_InputsDocumentsGoodsFill @nInputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = nInputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableInputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsGoods, "TableInputsDocumentsGoods");
				_TableInputsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableInputsDocumentsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableInputsDocumentsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableInputsDocumentsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������...\r\n" +
								"�� ��������� ��� ���������� ���������...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ������� � ��������� ���������(TableInputsDocumentsGoods) - � ������� ��� ������ ����������� ����������
		/// </summary>
		public bool FillBillTableInputsDocumentsGoods(int nInputDocumentID)
		{
			string sqlSelect = "execute up_InputsDocumentsGoodsFillBill @nInputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsGoodsFillBill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = nInputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableInputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsGoods, "TableInputsDocumentsGoods");
				_TableInputsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableInputsDocumentsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ������� � ��������� ���������(TableInputsDocumentsGoods) - � ������� ��� ������ ����������� ���������� �� ����������
		/// </summary>
		public bool FillReverseBillTableInputsDocumentsGoods(int nInputDocumentID)
		{
			string sqlSelect = "execute up_InputsDocumentsGoodsFillReverseBill @nInputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsGoodsFillReverseBill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = nInputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableInputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsGoods, "TableInputsDocumentsGoods");
				_TableInputsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableInputsDocumentsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� � ������� ��� ������������ �� ������� (TableWarrant)
		/// ���������� � ������� _DS.Tables["TableWarrant"]
		/// � ������� ��� ��������� 1 ������, ���� ����� ������������, 0 - ���� �� ����� 
		/// </summary>
		public bool FillWarrantTableInputsDocuments(string sInputsDocumentsList)
		{
			string sqlSelect = "execute up_InputsDocumentsFillWarrant @cInputsDocumentsList, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsFillWarrant parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cInputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sInputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableWarrantInputsDocuments");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ��� ������������ �� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ��� ������������ �� �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#region ��� ������ ���������

		/// <summary>
		/// ��������� ������� ������� � ����� ��������� ��������� (TableInputsDocumentsGoods)
		/// </summary>
		public bool FillTableInputsDocumentsGoodsFromInput(int nInputID)
		{
			string sqlSelect = "execute up_InputsDocumentsGoodsFillFromInput @nInputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsDocumentsGoodsFillFromInput parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableInputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsGoods, "TableInputsDocumentsGoods");
				_TableInputsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableInputsDocumentsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ��� ������ ���������

		#endregion InputsDocumentsGoods

		#region Carries

		/// <summary>
		/// ��������� ������ ��������� ��� ���������� ��������� (TableInputsDocumentsCarries)
		/// </summary>
		public bool FillTableInputsDocumentsCarries(int nInputDocumentID)
		{
			string sqlSelect = "execute up_InputsDocumentsCarriesFill " +
									"@nInputDocumentID = " + nInputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableInputsDocumentsCarries");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� ��������� ������ ��������� ��� ���������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carries

		#region InputsDocumentsTypes

		/// <summary>
		/// ��������� ������� ����� ��������� ����������(TableInputsDocumentsTypes)
		/// </summary>
		public bool FillTableInputsDocumentsTypes()
		{
			string sqlSelect = 
				"select ID, Name, "  +
						"DeliveryNeed, " + 
						"ERPCode " +
					"from InputsDocumentsTypes with (nolock) " +
					"where 1 = 1 ";
			if (_FilterInputsDocumentsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterInputsDocumentsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableInputsDocumentsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsTypes, "_TableInputsDocumentsTypes");
				_TableInputsDocumentsTypes.PrimaryKey = new DataColumn[] { _TableInputsDocumentsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "������ ��� ��������� ������ ����� ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion InputsDocumentsTypes

		#region InputsDocumentsFailsReasons

		/// <summary>
		/// ��������� ������� ������ ������������ (����������) (TableInputsDocumentsFailsReasons)
		/// (��� ��������� �������)
		/// </summary>
		public bool FillTableInputsDocumentsFailsReasons()
		{
			string sqlSelect =
				"select SFR.ID, SFR.Name, " +
						"SFR.GuiltyID, Gu.Name as GuiltyName, " +
						"SFR.ERPCode " +
					"from InputsDocumentsFailsReasons SFR with (nolock) " +
					"left join Guilties Gu with (nolock) on SFR.GuiltyID = Gu.ID " +
					"where 1 = 1 ";
			//if (_FilterInputsDocumentsFailsReasonsList != null)
			//{
			//	sqlSelect += " and charindex(',' + ltrim(str(SFR.ID)) + ',', ',' + '" + FilterInputsDocumentsFailsReasonsList + "' + ',') > 0";
			//}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableInputsDocumentsFailsReasons = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsDocumentsFailsReasons, "TableInputsDocumentsFailsReasons");
				_TableInputsDocumentsFailsReasons.PrimaryKey = new DataColumn[] { _TableInputsDocumentsFailsReasons.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -31;
				_ErrorStr = "������ ��� ��������� ������ ������ ������������ (����������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion InputsDocumentsFailsReasons

		#endregion �������

		#region Additional 
		
		/// <summary>
		/// ���������� ������ � ��� � GoodsCustoms
		/// </summary>
		/// 
		public bool GoodsCustomsSave(int nInputDocumentID)
		{
			return (GoodsCustomsSave(nInputDocumentID, null));
		}

		public bool GoodsCustomsSave(DataTable tableInputsDocumentsGoods)
		{ 
			return(GoodsCustomsSave(null, tableInputsDocumentsGoods));
		}

		public bool GoodsCustomsSave(int? nInputDocumentID, DataTable tableInputsDocumentsGoods)
		{
			string sqlSelect = "execute up_GoodsCustomsSaveFromInputsDocumentsGoods @nInputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_GoodsCustomsSaveFromInputsDocumentsGoods parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			if (nInputDocumentID.HasValue) 
				_oParameter.Value = nInputDocumentID;
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
				if (tableInputsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(tableInputsDocumentsGoods, "#InputsDocumentsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "������ ��� ������� ���������� ������� ��� ��� ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������� ��� ��� ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Additional

		#region Documents

		#region Warrant

		/// <summary>
		/// ���������� ������ ������������ � ������ � ������
		/// </summary>
		public bool WarrantSet(int nInputDocumentID, string cNumber)
		{
			string _sqlCommand = "execute up_InputsDocumentsWarrantCreate @nInputDocumentID, " +
									"@cNumber, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsWarrantCreate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@cNumber", SqlDbType.VarChar);
			if (cNumber != null)
				_oParameter.Value = cNumber;
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
				_ErrorStr = "������ ��� ������� ����������� ������������ �� �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����������� ������������ �� �������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������ ������������ � �������� ������ �� �������
		/// </summary>
		public bool WarrantClear(int nInputDocumentID)
		{
			string _sqlCommand = "execute up_InputsDocumentsWarrantClear @nInputDocumentID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsWarrantClear parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������� ������������ �� �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������� ������������ �� �������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Warrant

		#endregion Documents
	
	}

#endregion InputDocument

}
