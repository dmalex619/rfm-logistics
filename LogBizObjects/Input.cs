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
/// ������-������ ������� �� ������ (Input)
/// </summary>
/// 
namespace LogBizObjects
{

#region Input

	public class Input : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// ������ ID �������� (Inputs.ID)
		/// </summary>
		[Description("������ ID �������� (Inputs.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateInput;
		/// <summary>
		/// ���� ������� (Inputs.DateInput)
		/// </summary>
		[Description("���� ������� (Inputs.DateInput)")]
		public DateTime DateInput { get { return _DateInput; } set { _DateInput = value; } }

		protected bool _DeliveryNeed;
		/// <summary>
		/// ��������� ���� �������� (����� ��� ������������ �������) (Inputs.DeliveryNeed)?
		/// </summary>
		[Description("��������� ���� �������� (����� ��� ������������ �������) (Inputs.DeliveryNeed)?")]
		public bool DeliveryNeed { get { return _DeliveryNeed; } set { _DeliveryNeed = value; } }

		protected int _InputTypeID;
		/// <summary>
		/// ��� ������� - ��� (Inputs.InputTypeID)
		/// </summary>
		[Description("��� ������� - ��� (Inputs.InputTypeID)")]
		public int InputTypeID { get { return _InputTypeID; } set { _InputTypeID = value; } }

		protected string _InputTypeName;
		/// <summary>
		/// ��� ������� - ������������ (Inputs.InputTypeID -> InputsTypes.Name)
		/// </summary>
		[Description("��� ������� - ������������ (Inputs.InputTypeID -> InputsTypes.Name)")]
		public string InputTypeName { get { return _InputTypeName; } set { _InputTypeName = value; } }

		protected bool _IsRefund;
		/// <summary>
		/// ��� ������� - ������� (Inputs.InputTypeID -> InputsTypes.IsRefund)
		/// </summary>
		[Description("��� ������� - ������� (Inputs.InputTypeID -> InputsTypes.IsRefund)")]
		public bool IsRefund { get { return _IsRefund; } set { _IsRefund = value; } }

		protected bool _IsReturn;
		/// <summary>
		/// ������� (Inputs.IsReturn)?
		/// </summary>
		[Description("������� (Inputs.IsReturn)")]
		public bool IsReturn { get { return _IsReturn; } set { _IsReturn = value; } }

		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (Inputs.OwnerID -> Partners.ID)
		/// </summary>
        [Description("�������� ������ - ��� (Inputs.OwnerID -> Partners.ID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
        /// �������� ������ - ������������ (Inputs.OwnerID -> Partners.ID -> Owners.Name)
		/// </summary>
        [Description("�������� ������ - ������������ (Inputs.OwnerID -> Partners.ID -> Owners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

        protected int? _BuyerID;
        /// <summary>
        /// ���������� ������ - ��� (Inputs.BuyerID -> Partners.ID)
        /// </summary>
        [Description("���������� ������ - ��� (Inputs.BuyerID -> Partners.ID)")]
        public int? BuyerID { get { return _BuyerID; } set { _BuyerID = value; } }

        protected string _BuyerName;
        /// <summary>
        /// ���������� ������ - ������������ (Inputs.BuyerID -> Partners.ID -> Buyers.Name)
        /// </summary>
        [Description("�������� ������ - ������������ (Inputs.BuyerID -> Partners.ID -> Buyers.Name)")]
        public string BuyerName { get { return _BuyerName; } set { _BuyerName = value; } }

        protected int? _GoodStateID;
		/// <summary>
		/// ��������� ������ - ��� (Inputs.PartnerID -> Partners.GoodStateID)
		/// </summary>
		[Description("��������� ������ - ��� (Inputs.PartnerID -> Partners.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// ��������� ������ - ������������ (Inputs.PartnerID -> Partners.GoodStateID -> GoodStates.Name)
		/// </summary>
		[Description("��������� ������ - ������������ (Inputs.PartnerID -> Partners.GoodStateID -> GoodStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int? _PartnerID;
		/// <summary>
		/// ������-��������� - ��� (Inputs.PartnerID)
		/// </summary>
		[Description("������-��������� - ��� (Inputs.PartnerID)")]
		public int? PartnerID { get { return _PartnerID; } set { _PartnerID = value; } }

		protected string _PartnerName;
		/// <summary>
		/// ������-��������� - ������������ (Inputs.PartnerID -> InputsTypes.Name)
		/// </summary>
		[Description("������-��������� - ������������ (Inputs.PartnerID -> InputsTypes.Name)")]
		public string PartnerName { get { return _PartnerName; } set { _PartnerName = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// ���� �������-���������� - ��� (Inputs.PartnerID -> Partners.ZoneID)
		/// </summary>
		[Description("���� �������-���������� - ��� (Inputs.PartnerID -> Partners.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// ���� �������-���������� - ������������ (Inputs.PartnerID -> Partners.ZoneID -> Zones.Name)
		/// </summary>
		[Description("���� �������-���������� - ������������ (Inputs.ZoneID -> Partners.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _ZoneAlias;
		/// <summary>
		/// ���� �������-���������� - ������� ������������ (Inputs.PartnerID -> Partners.ZoneID -> Zones.Alias)
		/// </summary>
		[Description("���� �������-���������� - ������� ������������ (Inputs.ZoneID -> Partners.ZoneID -> Zones.Alias)")]
		public string ZoneAlias { get { return _ZoneAlias; } set { _ZoneAlias = value; } }

		protected string _DeliveryAddress;
		/// <summary>
		/// ����� �������� �������-���������� (Inputs.PartnerID -> Partners.DeliveryAddress)
		/// </summary>
		[Description("����� �������� �������-���������� (Inputs.PartnerID -> Partners.DeliveryAddress)")]
		public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

		protected string _DeliveryPassage;
		/// <summary>
		/// ������ ��� �������-���������� (Inputs.PartnerID -> Partners.DeliveryPassage)
		/// </summary>
		[Description("������ ��� �������-���������� (Inputs.PartnerID -> Partners.DeliveryPassage)")]
		public string DeliveryPassage { get { return _DeliveryPassage; } set { _DeliveryPassage = value; } }

		protected bool? _PassengerCarOnly;
		/// <summary>
		/// �������� ������ �������� ������� (Inputs.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("�������� ������ �������� ������� (Inputs.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? PassengerCarOnly { get { return _PassengerCarOnly; } set { _PassengerCarOnly = value; } }

		protected bool? _PosternOnly;
		/// <summary>
		/// �������� ������ ������� � ������ ������ (Inputs.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ������ ������ (Inputs.PartnerTargetID -> Partners.PosternOnly)?")]
		public bool? PosternOnly { get { return _PosternOnly; } set { _PosternOnly = value; } }

		protected bool? _LoadLiftOnly;
		/// <summary>
		/// �������� ������ ������� � ����������� (�������) (Inputs.PartnerTargetID -> Partners.LoadLiftOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ����������� (�������) (Inputs.PartnerTargetID -> Partners.LoadLiftOnly)?")]
		public bool? LoadLiftOnly { get { return _LoadLiftOnly; } set { _LoadLiftOnly = value; } }

		protected int? _PermitLevelID;
		/// <summary>
		/// ���������� ������� (���������) - ��� (Inputs.PartnerTargetID -> Partners.PermitLevelID)
		/// </summary>
		[Description("���������� ������� (���������) - ��� (Inputs.PartnerTargetID -> Partners.PermitLevelID)")]
		public int? PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// ���������� ������� (���������) - ������������ (Inputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("���������� ������� (���������) - ������������ (Inputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int? _PermitLevelValue;
		/// <summary>
		/// ���������� ������� (���������) - �������, �� ����� (Inputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("���������� ������� (���������) - �������, �� ����� (Inputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int? PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }


		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (Inputs.TripID)
		/// </summary>
		[Description("���� - ��� (Inputs.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected bool _TripExists;
		/// <summary>
		/// ������� ������������ � ����� (Inputs.TripID is not Null)?
		/// </summary>
		[Description("������� ������������ � ����� (Inputs.TripID is not Null)?")]
		public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }

		protected bool _InputsDocumentsExists;
		/// <summary>
		/// ������� ����� ��������� ��������� (Inputs.ID - InputsDocumetns.InputID)?
		/// </summary>
		[Description("������� ����� ��������� ��������� (Inputs.ID - InputsDocumetns.InputID)?")]
		public bool InputsDocumentsExists { get { return _InputsDocumentsExists; } set { _InputsDocumentsExists = value; } }

		protected bool _ActsExists;
		/// <summary>
		/// ������� ����� ���� (Inputs.ID - Acts.InputID)?
		/// </summary>
		[Description("������� ����� ���� (Inputs.ID - Acts.InputID)?")]
		public bool ActsExists { get { return _ActsExists; } set { _ActsExists = value; } }

		// -- ���� �� ��������� ����������: GoodStateID, GoodStateName. ����� ��?

		protected decimal _Netto;
		/// <summary>
		/// ��� ������ - �����, �� (Inputs.Netto)
		/// </summary>
		[Description("��� ������ - �����, �� (Inputs.Netto)")]
		public decimal Netto { get { return _Netto; } set { _Netto = value; } }

		protected decimal _Brutto;
		/// <summary>
		/// ��� ������������ ������ - ������, �� (Inputs.Brutto)
		/// </summary>
		[Description("��� ������ - ������, �� (Inputs.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected decimal _Volume;
		/// <summary>
		/// �����, �3 (Inputs.Volume())
		/// </summary>
		[Description("�����, �3 (Inputs.Volume())")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }

		protected decimal _PalletsQnt;
		/// <summary>
		/// ���������� ����������� ������ � ������� (Inputs.PalletsQnt)
		/// </summary>
		[Description("���������� ������ � ������� (Inputs.PalletsQnt)")]
		public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }

		protected int _PointsQnt;
		/// <summary>
		/// ���������� ����� (Inputs.PointsQnt)
		/// </summary>
		[Description("���������� ����� (Inputs.PointsQnt)")]
		public int PointsQnt { get { return _PointsQnt; } set { _PointsQnt = value; } }

		protected int _InputsDocumentsQnt;
		/// <summary>
		/// ���������� ��������� ����������, �������� � ������� (Inputs.InputsDocumentsQnt)
		/// </summary>
		[Description("���������� ��������� ����������, �������� � ������� (Inputs.InputsDocumentsQnt)")]
		public int InputsDocumentsQnt { get { return _InputsDocumentsQnt; } set { _InputsDocumentsQnt = value; } }


		protected bool _PF_WarrantNeed;
		/// <summary>
		/// ����� ������������ (Inputs.PF_WarrantNeed)?
		/// </summary>
		[Description("����� ������������ (Inputs.PF_WarrantNeed)?")]
		public bool PF_WarrantNeed { get { return _PF_WarrantNeed; } set { _PF_WarrantNeed = value; } }

		protected string _WarrantNumber;
		/// <summary>
		/// ����� ������������ (Inputs.WarrantNumber)?
		/// </summary>
		[Description("����� ������������ (Inputs.WarrantNumber)?")]
		public string WarrantNumber { get { return _WarrantNumber; } set { _WarrantNumber = value; } }


		protected string _Note;
		/// <summary>
		/// ���������� � ������� (Inputs.Note)
		/// </summary>
		[Description("���������� � ������� (Inputs.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _PartnersNames;
		/// <summary>
		/// �������� ���������-����������� - ������������ (Inputs.PartnersNames)
		/// </summary>
		[Description("�������� ���������-����������� - ������������ (Inputs.PartnersNames)")]
		public string PartnersNames { get { return _PartnersNames; } set { _PartnersNames = value; } }

		protected string _InputsDocumentsNotes;
		/// <summary>
		/// ���������� � ��������� ���������� - ����������� (Inputs.InputsDocumentsNotes)
		/// </summary>
		[Description("���������� � ��������� ���������� - ����������� (Inputs.InputsDocumentsNotes)")]
		public string InputsDocumentsNotes { get { return _InputsDocumentsNotes; } set { _InputsDocumentsNotes = value; } }


		protected decimal _Amount;
		/// <summary>
		/// ��������� [��������������] (Inputs.Amount)
		/// </summary>
		[Description("��������� [��������������] (Inputs.Amount)")]
		public decimal Amount { get { return _Amount; } set { _Amount = value; } }

		protected int _CurrencyID;
		/// <summary>
		/// ������ [��������������] - ��� (Inputs.CurrencyID)
		/// </summary>
		[Description("������ [��������������] - ��� (Inputs.CurrencyID)")]
		public int CurrencyID { get { return _CurrencyID; } set { _CurrencyID = value; } }

		protected string _CurrencyName;
		/// <summary>
		/// ������ [��������������] - ������������ (Inputs.CurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ [��������������] - ������������ (Inputs.CurrencyID -> Currencies.Name)")]
		public string CurrencyName { get { return _CurrencyName; } set { _CurrencyName = value; } }


		protected bool _TPL;
		/// <summary>
		/// 3PL (Inputs.TPL)?
		/// </summary>
		[Description("3PL (Inputs.TPL)?")]
		public bool TPL { get { return _TPL; } set { _TPL = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// ����-����� �������� ������� (Inputs.DateCreate)?
		/// </summary>
		[Description("����-����� �������� ������� (Inputs.DateCreate)?")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected DateTime? _DateAttachToTrip;
		/// <summary>
		/// ����-����� ������������� � ����� (Inputs.DateAttachToTrip)?
		/// </summary>
		[Description("����-����� ������������� � ����� (Inputs.DateAttachToTrip)?")]
		public DateTime? DateAttachToTrip { get { return _DateAttachToTrip; } set { _DateAttachToTrip = value; } }

		protected bool _ReadyForWMS;
		/// <summary>
		/// ������ � �������� � ��������� ������� (Inputs.ReadyForWMS)?
		/// </summary>
		[Description("������ � �������� � ��������� �������(Inputs.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }

		protected bool _SentToWMS;
		/// <summary>
		/// �������� � ��������� ������� (Inputs.SentToWMS)?
		/// </summary>
		[Description("�������� � ��������� ������� (Inputs.SentToWMS)?")]
		public bool SentToWMS { get { return _SentToWMS; } set { _SentToWMS = value; } }

		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� ������� (Inputs.DateConfirm)?
		/// </summary>
		[Description("����-����� ������������� ������� (Inputs.DateConfirm)?")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// ������� ������������ (�������� �� ������) (Inputs.IsConfirmed)?
		/// </summary>
		[Description("������� ������������ (�������� �� ������) (Inputs.IsConfirmed)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected bool _IsCarried;
		/// <summary>
		/// ������� ���������� (.dbo.InputIsCarried(ID))?
		/// </summary>
		[Description("������� ���������� (.dbo.InputIsCarried(ID))?")]
		public bool IsCarried { get { return _IsCarried; } set { _IsCarried = value; } }

		protected bool _IsCopied;
		/// <summary>
		/// ������� ���������� � ����������� (.dbo.InputIsCopied(ID))?
		/// </summary>
		[Description("������� ���������� � ����������� (.dbo.InputIsCopied(ID))?")]
		public bool IsCopied { get { return _IsCopied; } set { _IsCopied = value; } }

		protected int? _CopiedFromInputID;
		/// <summary>
		/// ������� ���� ������� �� ������� ������� - ��� (.dbo.InputCopiedFrom(ID))?
		/// </summary>
		[Description("������� ���� ������� �� ������� ������� - ��� (.dbo.InputCopiedFrom(ID))?")]
		public int? CopiedFromInputID { get { return _CopiedFromInputID; } set { _CopiedFromInputID = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (Inputs.HostID)
		/// </summary>
		[Description("Host  - ��� (Inputs.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (Inputs.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (Inputs.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected bool _IsFree;
		/// <summary>
		/// ������� �� ������ ������� ����� (�� �� host)? (Inputs.ERPCode is Null)
		/// </summary>
		[Description("������� �� ������ ������� ����� (�� �� host)? (Inputs.ERPCode is Null)")]
		public bool IsFree { get { return _IsFree; } set { _IsFree = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� ������� � host-������� (Inputs.ERPCode)
		/// </summary>
		[Description("��� ������� � host-������� (Inputs.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (Inputs.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (Inputs.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsFree;
		/// <summary>
		/// ������-����: ������� ������� ����� (�� �� host) (Inputs.ERPCode is Null)?
		/// </summary>
		[Description("������-����: ������� ������� ����� (�� �� host) (Inputs.ERPCode is Null)?")]
		public bool? FilterIsFree { get { return _FilterIsFree; } set { _FilterIsFree = value; _NeedRequery = true; } }


		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ������� �� ������ - ��������� ���� ������� (Inputs.DateInput)
		/// </summary>
		[Description("������-����: ���� ������� �� ������ - ��������� ���� ������� (Inputs.DateInput)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ������� �� ������ - �������� ���� ������� (Inputs.DateInput)
		/// </summary>
		[Description("������-����: ���� ������� �� ������ - �������� ���� ������� (Inputs.DateInput)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterInputsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� ������� �� ������, ����� ������� (Inputs.InputTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� ������� �� ������, ����� ������� (Inputs.InputTypeID)")]
		public string FilterInputsTypesList { get { return _FilterInputsTypesList; } set { _FilterInputsTypesList = value; _NeedRequery = true; } }

		protected bool? _FilterDeliveryNeed;
		/// <summary>
		/// ������-����: ��������� ���� �������� (����� ��� ������������ �������) (Inputs.DeliveryNeed)?
		/// </summary>
		[Description("������-����: ��������� ���� �������� (����� ��� ������������ �������) (Inputs.DeliveryNeed)?")]
		public bool? FilterDeliveryNeed { get { return _FilterDeliveryNeed; } set { _FilterDeliveryNeed = value; _NeedRequery = true; } }

		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// ������-����: ������� �� ������ ������ � �������� � ��������� ������� (Inputs.ReadyForWMS)?
		/// </summary>
		[Description("������-����: ������� �� ������ ������ � �������� � ��������� ������� (Inputs.ReadyForWMS)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }

		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: ������� �� ������ ������������ (Inputs.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: ������� �� ������ ������������ (Inputs.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterIsCarried;
		/// <summary>
		/// ������-����: ������� �� ������ ���������� (Inputs.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: ������� �� ������ ���������� (Inputs.DateConfirm is not Null)?")]
		public bool? FilterIsCarried { get { return _FilterIsCarried; } set { _FilterIsCarried = value; _NeedRequery = true; } }


		protected string _FilterPartnersList;
		/// <summary>
		/// ������-����: ������ ����� ��������-�����������, ����� ������� (Inputs.PartnerID)
		/// </summary>
		[Description("������-����: ������ ����� ��������-�����������, ����� ������� (Inputs.PartnerID)")]
		public string FilterPartnersList { get { return _FilterPartnersList; } set { _FilterPartnersList = value; _NeedRequery = true; } }

		protected bool? _FilterPassengerCarOnly;
		/// <summary>
		/// ������-����: �������� �������� ������� (Inputs.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("������-����: �������� �������� ������� (Inputs.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? FilterPassengerCarOnly { get { return _FilterPassengerCarOnly; } set { _FilterPassengerCarOnly = value; _NeedRequery = true; } }

		protected string _FilterPartnerNameContext;
		/// <summary>
		/// ������-����: �������� �������-����������, �������� (Inputs.PartnerID -> Partners.Name)
		/// </summary>
		[Description("������-����: �������� �������-����������, �������� (Inputs.PartnerID -> Partners.Name)")]
		public string FilterPartnerNameContext { get { return _FilterPartnerNameContext; } set { _FilterPartnerNameContext = value; _NeedRequery = true; } }

		protected bool? _FilterPosternOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ������ (Inputs.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ������ (Inputs.PartnerTargetID -> Partners.Postern)?")]
		public bool? FilterPosternOnly { get { return _FilterPosternOnly; } set { _FilterPosternOnly = value; _NeedRequery = true; } }

		protected bool? _FilterLoadLiftOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ����������� (�������) (Inputs.PartnerTargetID -> Partners.LoadLift)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ����������� (�������) (Inputs.PartnerTargetID -> Partners.LoadLift)?")]
		public bool? FilterLoadLiftOnly { get { return _FilterLoadLiftOnly; } set { _FilterLoadLiftOnly = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// ������-����: ���������� ������� - �������, �� ����� (Inputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("������-����: ���������� ������� - �������, �� ����� (Inputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		protected string _FilterZonesList;
		/// <summary>
		/// ������-����: ������ ����� ��� ��������-�����������, ����� ������� (Inputs.PartnerTargetID -> Partners.ZoneID)
		/// </summary>
		[Description("������-����: ������ ����� ��� ��������-�����������, ����� ������� (Inputs.PartnerTargetID -> Partners.ZoneID)")]
		public string FilterZonesList { get { return _FilterZonesList; } set { _FilterZonesList = value; _NeedRequery = true; } }


		protected string _FilterInputsDocumentsList;
		/// <summary>
		/// ������-����: ������ ����� ��������� ����������, ����� ������� (InputsDocuments.InputID)
		/// </summary>
		[Description("������-����: ������ ����� ��������� ����������, ����� ������� (InputsDocuments.InputID)")]
		public string FilterInputsDocumentsList { get { return _FilterInputsDocumentsList; } set { _FilterInputsDocumentsList = value; _NeedRequery = true; } }

		protected bool? _FilterTripExists;
		/// <summary>
		/// ������-����: ������� ������������ � ����� (Inputs.TripID is not Null)?
		/// </summary>
		[Description("������-����: ������� ������������ � ����� (Inputs.TripID is not Null)?")]
		public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (Inputs.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (Inputs.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// ������-����: ������ ����� ����������, ����� ������� (Inputs.OwnerID)
		/// </summary>
		[Description("������-����: ������ ����� ����������, ����� ������� (Inputs.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (Inputs.ID --> InputsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (Inputs.ID --> InputsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (Inputs.ID --> InputsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (Inputs.ID --> InputsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableInputsGoods;
		/// <summary>
		/// ������ ������� � ������� InputsGoods
		/// </summary>
		[Description("������ ������� � ������� InputsGoods")]
		public DataTable TableInputsGoods { get { return _TableInputsGoods; } }

		protected DataTable _TableInputsTypes;
		/// <summary>
		/// ������� ����� �������� InputsTypes
		/// </summary>
		[Description("������� ����� �������� InputsTypes")]
		public DataTable TableInputsTypes { get { return _TableInputsTypes; } }

		#endregion �������


		// -------------------------------------

		public Input() : base()
		{
			_MainTableName = "Inputs";
			_ColumnID = "ID";
			_ColumnName = "DateInput";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������� �� ������ � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_InputsFill @nID, @cIDList, " +
									"@cHostsList, " + 
									"@dDateBeg, @dDateEnd, " +
									"@cInputsTypesList, " +
									"@bDeliveryNeed, " +
									"@bReadyForWMS, " +
									"@bIsConfirmed, " +
									"@bIsCarried, " +
									"@cPartnersList, @cPartnerNameContext, " +
									"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
									"@nPermitLevelValueMin, " +
									"@cZonesList, " +
									"@cInputsDocumentsList, " + 
									"@bTripExists, @cTripsList, " +
									"@cOwnersList, " + 	
									"@cPackingsList, @cGoodsList, " + 
									"@bIsFree";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cInputsTypesList", SqlDbType.VarChar);
			if (_FilterInputsTypesList != null)
				_oParameter.Value = _FilterInputsTypesList;
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

			_oParameter = _oCommand.Parameters.Add("@cInputsDocumentsList", SqlDbType.VarChar);
			if (_FilterInputsDocumentsList != null)
				_oParameter.Value = _FilterInputsDocumentsList;
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

			_oParameter = _oCommand.Parameters.Add("@bIsFree", SqlDbType.Bit);
			if (_FilterIsFree != null)
				_oParameter.Value = _FilterIsFree;
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
				_ErrorStr = "������ ��� ��������� ������ ������� �� ������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������-�����
		/// </summary>
		public void ClearFilters()
		{
			_IDList = null;

			_FilterHostsList = null;
			_FilterIsFree = null;

			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterInputsTypesList = null;
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

			_FilterInputsDocumentsList = null;
			_FilterTripExists = null;
			_FilterTripsList = null;
			_FilterOwnersList = null;
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

					_InputTypeID = Convert.ToInt32(r["InputTypeID"]);
					_InputTypeName = r["InputTypeName"].ToString();
					_IsRefund = Convert.ToBoolean(r["IsRefund"]);
					_IsReturn = Convert.ToBoolean(r["IsReturn"]);

                    if (!Convert.IsDBNull(r["OwnerID"]))
                        _OwnerID = Convert.ToInt32(r["OwnerID"]);
                    _OwnerName = r["OwnerName"].ToString();
                    if (!Convert.IsDBNull(r["BuyerID"]))
                        _BuyerID = Convert.ToInt32(r["BuyerID"]);
                    _BuyerName = r["BuyerName"].ToString();
                    
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

					_InputsDocumentsExists = Convert.ToBoolean(r["InputsDocumentsExists"]);
					_ActsExists = Convert.ToBoolean(r["ActsExists"]);

					if (!Convert.IsDBNull(r["DateCreate"]))
						_DateCreate = Convert.ToDateTime(r["DateCreate"]);
					if (!Convert.IsDBNull(r["DateAttachToTrip"]))
						_DateAttachToTrip = Convert.ToDateTime(r["DateAttachToTrip"]);
					_ReadyForWMS = Convert.ToBoolean(r["ReadyForWMS"]);
					_SentToWMS = Convert.ToBoolean(r["SentToWMS"]);

					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);

					_Amount = Convert.ToDecimal(r["Amount"]);
					_CurrencyID = Convert.ToInt32(r["CurrencyID"]);
					_CurrencyName = r["CurrencyName"].ToString();

					_TPL = Convert.ToBoolean(r["TPL"]);

					_Netto = Convert.ToDecimal(r["Netto"]);
					_Brutto = Convert.ToDecimal(r["Brutto"]);
					_Volume = Convert.ToDecimal(r["Volume"]);
					_PalletsQnt = Convert.ToDecimal(r["PalletsQnt"]);
					_PointsQnt = Convert.ToInt32(r["PointsQnt"]);
					_InputsDocumentsQnt = Convert.ToInt32(r["InputsDocumentsQnt"]);

					_PF_WarrantNeed = Convert.ToBoolean(r["PF_WarrantNeed"]);
					_WarrantNumber = r["WarrantNumber"].ToString();

					_Note = r["Note"].ToString();
					_PartnersNames = r["PartnersNames"].ToString();
					_InputsDocumentsNotes = r["InputsDocumentsNotes"].ToString();

					_IsCarried = Convert.ToBoolean(r["IsCarried"]);
					_IsCopied = Convert.ToBoolean(r["IsCopied"]);
					if (!Convert.IsDBNull(r["CopiedFromInputID"]))
						_CopiedFromInputID = Convert.ToInt32(r["CopiedFromInputID"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					_IsFree = Convert.ToBoolean(r["IsFree"]);
					
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ������� �� ������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ������� �� ������ (��� ������)...";
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

			_InputTypeID = 0;
			_InputTypeName = null;
			_IsRefund = false;
			_IsReturn = false;

			_OwnerID = null;
            _OwnerName = null;
            _BuyerID = null;
            _BuyerName = null;
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
			_InputsDocumentsExists = false;
			_ActsExists = false;

			_DateCreate = null;
			_DateAttachToTrip = null;
			_ReadyForWMS = false;
			_SentToWMS = false;

			_DateConfirm = null;
			_IsConfirmed = false;

			_Amount = 0;
			_CurrencyID = 0;
			_CurrencyName = null;

			_Netto = 0;
			_Brutto = 0;
			_Volume = 0;
			_PalletsQnt = 0;
			_PointsQnt = 0;
			_InputsDocumentsQnt = 0;

			_PF_WarrantNeed = false;
			_WarrantNumber = null;

			_Note = "";
			_PartnersNames = "";
			_InputsDocumentsNotes = "";

			_IsCarried = false;
			_IsCopied = false;
			_CopiedFromInputID = null;

			_HostID = null;
			_HostName = null;

			_IsFree = false;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// ���������� ������ ������� �� ������
		/// </summary>
		public bool Save()
		{
			string _sqlCommand = "execute up_InputsSave @nInputID output, " +
									"@nHostID, " +
									"@dDateInput, " +
									"@nInputTypeID, " +
									"@bDeliveryNeed, " +
									"@nGoodStateID, " +
                                    "@nOwnerID, " +
                                    "@nBuyerID, " +
                                    "@nPartnerID, " +
                                    "@nCurrencyID, " +
									"@cNote, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_InputsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nHostID", SqlDbType.Int);
			_oParameter.Value = _HostID;

			_oParameter = _oCommand.Parameters.Add("@dDateInput", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateInput;

			_oParameter = _oCommand.Parameters.Add("@nInputTypeID", SqlDbType.Int);
			_oParameter.Value = _InputTypeID;

			_oParameter = _oCommand.Parameters.Add("@bDeliveryNeed", SqlDbType.Bit);
			_oParameter.Value = _DeliveryNeed;

			_oParameter = _oCommand.Parameters.Add("@nGoodStateID", SqlDbType.Bit);
			_oParameter.Value = _GoodStateID;

            _oParameter = _oCommand.Parameters.Add("@nOwnerID", SqlDbType.Int);
            if (_OwnerID.HasValue)
                _oParameter.Value = _OwnerID;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nBuyerID", SqlDbType.Int);
            if (_BuyerID.HasValue)
                _oParameter.Value = _BuyerID;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
			if (_PartnerID.HasValue)
				_oParameter.Value = _PartnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCurrencyID", SqlDbType.Int);
			_oParameter.Value = _CurrencyID;

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

				// ������� �������
				if (TableInputsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableInputsGoods, "#InputsGoods", _Connect);
				}

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� ������� �� ������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ ������� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nInputID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nInputID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ������� �� ������
		/// </summary>
		public bool Delete(int nInputID)
		{
			String _sqlCommand = "execute up_InputsDelete @nInputID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_InputsDelete parameters

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
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� �������� ������� �� ������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// ������������� ���������� ������� �� ������ 
		/// </summary>
		public bool Confirm()
		{
			string _sqlCommand = "execute up_InputsConfirm @nInputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
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
				if (_TableInputsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(_TableInputsGoods, "#InputsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������������� ���������� �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� ���������� �������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������������� 
		/// </summary>
		public bool UnConfirm()
		{
			string _sqlCommand = "execute up_InputsUnConfirm @nInputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnInputsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� ���������� �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� ���������� �������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Set/Clear dates-times

		#region ReadyForWMS

		/// <summary>
		/// ���������/�������� ������� "������� ������ � �������� � ��������� �������"
		/// nUserID: �� ���.
		/// </summary>
		public bool SetReadyForWMS(int nInputID)
		{
			return (SetReadyForWMS(nInputID, false, 0));
		}

		public bool SetReadyForWMS(int nInputID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "execute up_InputsSetReadyForWMS @nInputID, @bClear, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_InputsSetReadyForWMS parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

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
				_ErrorStr = "������ ��� ������� " + (bClear ? "������" : "���������") + " �������� \"������ � �������� � ��������� �������\"...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� " + (bClear ? "������" : "���������") + " �������� \"������ � �������� � ��������� �������\"...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ReadyForWMS

		#region DeliveryNeed

		/// <summary>
		/// ���������/�������� ������� "��������� ���� ��������"
		/// nUserID: �� ���.
		/// </summary>
		public bool SetDeliveryNeed(int nInputID)
		{
			return (SetDeliveryNeed(nInputID, false, null));
		}

		public bool SetDeliveryNeed(int nInputID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "update Inputs set DeliveryNeed = " +
									(bClear ? "0" : "1") + " " +
									"where ID = " + nInputID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� " + (bClear ? "������" : "���������") + " �������� \"��������� ���� ��������\"...\r\n" + ex.Message;
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
		/// �������� ������� �� ������ � �����
		/// </summary>
		public bool ToTrip(int nTripID)
		{
			if (!_ID.HasValue)
			{
				_ErrorNumber = -111;
				_ErrorStr = "������ ��� ������� �������� ������� �� ������ � �����:\n" + 
					"�� ����� ��� ������� �� ������...";
				RFMMessage.MessageBoxError(_ErrorStr);
				return (false); 
			}
			return(ToTrip((int)_ID, nTripID)); 
		}

		public bool ToTrip(int nInputID, int nTripID)
		{
			string _sqlCommand = "execute up_InputsToTrip @nInputID, " +
									"@nTripID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsToTrip parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

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
				_ErrorStr = "������ ��� ������� �������� ������� �� ������ � �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������� �� ������ � �����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
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
		/// ������ �������� ������� �� ������ � �����
		/// </summary>
		public bool UnToTrip()
		{
			if (!_ID.HasValue)
			{
				_ErrorNumber = -111;
				_ErrorStr = "������ ��� ������� ������ �������� ������� �� ������ � �����:\n" +
					"�� ����� ��� ������� �� ������...";
				RFMMessage.MessageBoxError(_ErrorStr);
				return (false);
			}
			return (UnToTrip((int)_ID));
		}

		public bool UnToTrip(int nInputID)
		{
			string _sqlCommand = "execute up_InputsUnToTrip @nInputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsUnToTrip parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

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
				_ErrorStr = "������ ��� ������� ������ �������� ������� �� ������ � �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ �������� ������� �� ������ � �����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
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
		/// ��������� ��������� ������������� ��� ������ ������� 
		/// </summary>
		public bool CalcSum(string sInputsList,
			ref int nInputsQnt, ref int nInputsDocumentsQnt, ref int nPointsQnt,
			ref decimal nNetto, ref decimal nBrutto, ref decimal nVolume, ref decimal nPalletsQnt)
		{
			string sqlSelect = "execute up_InputsCalcSum @cInputsList, " +
									"@nInputsQnt output, " +
									"@nInputsDocumentsQnt output, " +
									"@nPointsQnt output, " +
									"@nNetto output, " +
									"@nBrutto output, " +
									"@nVolume output, " +
									"@nPalletsQnt output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsCalcSum parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cInputsList", SqlDbType.VarChar);
			_oParameter.Value = sInputsList;

			_oParameter = _oCommand.Parameters.Add("@nInputsQnt", SqlDbType.Int);
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nInputsDocumentsQnt", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ��������� ��������� ������ �� �������� �� ������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (ErrorNumber == 0)
			{
				nInputsQnt = Convert.ToInt32(_oCommand.Parameters["@nInputsQnt"].Value);
				nInputsDocumentsQnt = Convert.ToInt32(_oCommand.Parameters["@nInputsDocumentsQnt"].Value);
				nPointsQnt = Convert.ToInt32(_oCommand.Parameters["@nPointsQnt"].Value);
				nNetto = Convert.ToDecimal(_oCommand.Parameters["@nNetto"].Value);
				nBrutto = Convert.ToDecimal(_oCommand.Parameters["@nBrutto"].Value);
				nVolume = Convert.ToDecimal(_oCommand.Parameters["@nVolume"].Value);
				nPalletsQnt = Convert.ToDecimal(_oCommand.Parameters["@nPalletsQnt"].Value);
			}

			return (_ErrorNumber == 0);
		}

		#endregion Calc

		#region UpdateFromInputsDocuments

		/// <summary>
		/// �������� ���������� �� ���������� InputsGoods.QntDocuemtns � ������� �� ������ 
		/// �� ������ �������� � ���� ��������� ����������
		/// </summary>
		public bool UpdateFromInputsDocuments(int nInputID)
		{
			string _sqlCommand = "execute up_InputsUpdateFromInputsDocuments @nInputID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsUpdateFromInputsDocuments parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

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
				_ErrorStr = "������ ��� ������� ��������� ���������� �� ���������� � ������� �� ������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ��������� ���������� �� ���������� � ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion UpdateFromInputsDocuments 

		#region ByOrder

		public bool SaveByOrder(int nInputID, int nByOrder)
		{
			string _sqlCommand = "update Inputs set ByOrder = " + nByOrder.ToString().Trim() +
				" where ID =" + nInputID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "������ ���������� ������� �������� ������� �� ������...\r\n" + ex.Message;
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
		/// ������� ������� � ���� �������� � ���� ���������� �� ������ ����
		/// </summary>
		public bool Carry(int nInputID, DateTime dNewDate, int? @nInputDocumentFailReasonID,
			int? nUserCarryID)
		{
			string _sqlCommand = "execute up_InputsCarry @nInputID, " +
					"@dNewDate, " +
					"@nInputDocumentFailReasonID, " +
					"@nUserCarryID, " +
					"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsCarry parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

			_oParameter = _oCommand.Parameters.Add("@dNewDate", SqlDbType.SmallDateTime);
			_oParameter.Value = dNewDate;

			_oParameter = _oCommand.Parameters.Add("@nInputDocumentFailReasonID", SqlDbType.Int);
			if (nInputDocumentFailReasonID.HasValue)
				_oParameter.Value = nInputDocumentFailReasonID;
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
				_ErrorStr = "������ ��� ������� �������� ������� �� ������ �� ������ ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������� �� ������ �� ������ ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ����� ���� ������� � ���� �������� � ���� ��������� ���������� �� ������ ����
		/// </summary>
		public bool ChangeDate(int nInputID, DateTime dNewDate)
		{
			string _sqlCommand = "execute up_InputsChangeDate @nInputID, " +
					"@dNewDate, " +
					"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsChangeDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

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
				_ErrorStr = "������ ��� ������� ����� ���� ������� �� ������ �� ������ ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����� ���� ������� �� ������ �� ������ ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carry


		#region InputsDocumentsCreateFromInputs

		/// <summary>
		/// �������� ���������� ��������� �� ������ ������� �� ������
		/// </summary>
		public bool InputsDocumentsCreateFromInputs(int nInputID, ref int? nInputDocumentID)
		{
			string _sqlCommand = "execute up_InputsDocumentsCreateFromInputs @nInputID, @nInputDocumentID output, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsDocumentsCreateFromInputs parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			_oParameter.Value = nInputID;

			_oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� �������� ���������� ��������� �� ������ ������� �� ������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ���������� ��������� �� ������ ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (!Convert.IsDBNull(_oCommand.Parameters["@nInputDocumentID"].Value))
						nInputDocumentID = (int)_oCommand.Parameters["@nInputDocumentID"].Value; 
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion InputsDocumentsCreateFromInputs


		#region �������

		#region InputsGoods

		/// <summary>
		/// ��������� ������� ������� � ������� �� ������ TableInputsGoods
		/// </summary>
		public bool FillTableInputsGoods(int nInputID)
		{
			string sqlSelect = "execute up_InputsGoodsFill @nInputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsGoodsFill parameters

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
				_TableInputsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsGoods, "TableInputsGoods");
				_TableInputsGoods.PrimaryKey = new DataColumn[] { _TableInputsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ������� � ������� �� ������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableInputsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableInputsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ������� �� ������...\r\n" +
								"�� ��������� ��� ������� �� ������...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#region � ������ �����

		/// <summary>
		/// ��������� ������� ������� � ������� �� ������ TableInputsGoods - � ������ �����
		/// </summary>
		public bool FillTableInputsGoodsWithActs(int nInputID)
		{
			string sqlSelect = "execute up_InputsGoodsFillWithActs @nInputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsGoodsFillWithActs parameters

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
				_TableInputsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsGoods, "TableInputsGoods");
				_TableInputsGoods.PrimaryKey = new DataColumn[] { _TableInputsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ������� � ������� �� ������ � ������ �����..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ������� �� ������ � ������ �����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableInputsGoodsWithActs()
		{
			if (_ID.HasValue)
			{
				FillTableInputsGoodsWithActs((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ������� �� ������ � ������ �����...\r\n" +
								"�� ��������� ��� ������� �� ������...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion � ������ �����

		#region ��� ���������

		/// <summary>
		/// ��������� ������� ������� � ������� �� ������ TableInputsGoods - � ������� ��� ���������
		/// </summary>
		public bool FillBillTableInputsGoods(int nInputID)
		{
			string sqlSelect = "execute up_InputsGoodsFillBill @nInputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsGoodsFillBill parameters

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
				_TableInputsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsGoods, "TableInputsGoods");
				_TableInputsGoods.PrimaryKey = new DataColumn[] { _TableInputsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ������� � ������� �� ������ (���������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ������� �� ������ (���������)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ��� ���������

		#region warrant

		/// <summary>
		/// ��������� ������� � ������� ��� ������������ �� ������� (TableWarrant)
		/// ���������� � ������� _DS.Tables["TableWarrant"]
		/// � ������� ��� ��������� 1 ������, ���� ����� ������������, 0 - ���� �� ����� 
		/// </summary>
		public bool FillWarrantTableInputs(string sInputsList)
		{
			string sqlSelect = "execute up_InputsFillWarrant @cInputsList, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_InputsFillWarrant parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cInputsList", SqlDbType.VarChar);
			_oParameter.Value = sInputsList;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableWarrantInputs");
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

		#endregion warrant

        #region Distinct Goods in Inputs list

        /// <summary>
        /// �������� ������ �������� ������� � ��������
        /// </summary>
        /// <param name="InputsIDList"></param>
        public bool FillDistinctGoodsInInputs(string InputsIDList, out DataTable Table)
        {
            Table = null;

            // �������� ��������� (������ ����� ��������)
            if (string.IsNullOrEmpty(InputsIDList))
                return false;

            // ���������� ���������
            if (InputsIDList.StartsWith(","))
                InputsIDList = InputsIDList.Substring(1);
            if (InputsIDList.EndsWith(","))
                InputsIDList = InputsIDList.Substring(0, InputsIDList.Length - 1);

            // �������
            string sqlSelect = "select distinct P.GoodID " +
                "from InputsGoods IG with (nolock) " +
                "inner join Packings P with (nolock) on IG.PackingID = P.ID " +
                "where IG.InputID in (" + InputsIDList + ") and IG.QntConfirmed > 0";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            try
            {
                Table = FillReadings(new SqlDataAdapter(_oCommand), Table, "TableDistinctGoods");
            }
            catch (Exception ex)
            {
                _ErrorNumber = -11;
                _ErrorStr = "������ ��� ������� ��������� ������ ������� � �������� �� ������..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        #endregion

        #endregion InputsGoods

        #region InputsTypes

        /// <summary>
		/// ��������� ������� ����� �������� TableInputsTypes
		/// </summary>
		public bool FillTableInputsTypes()
		{
			string sqlSelect = 
				"select ID, Name, ERPCode " +
					"from InputsTypes " +
					"where 1 = 1 ";
			if (_FilterInputsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterInputsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_TableInputsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableInputsTypes, "TableInputsTypes");
				_TableInputsTypes.PrimaryKey = new DataColumn[] { _TableInputsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "������ ��� ��������� ������ ����� ��������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion InputsTypes

		#endregion �������

		#region Warrant

		/// <summary>
		/// ���������� ������ ������������ � ������ � ������
		/// </summary>
		public bool WarrantSet(int nInputID, string cNumber)
		{
			string _sqlCommand = "execute up_InputsWarrantCreate @nInputID, " +
									"@cNumber, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsWarrantCreate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
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
		public bool WarrantClear(int nInputID)
		{
			string _sqlCommand = "execute up_InputsWarrantClear @nInputID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_InputsWarrantClear parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
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

	}

#endregion Input

}
