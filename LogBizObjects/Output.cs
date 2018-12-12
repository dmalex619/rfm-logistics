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
/// ������-������ ������� �� ������ (Output), ����� � ������� (OutputGood)
/// </summary>
/// 
namespace LogBizObjects
{

#region Output

	public class Output : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// ������ ID �������� (Outputs.ID)
		/// </summary>
		[Description("������ ID �������� (Outputs.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateOutput;
		/// <summary>
		/// ���� ������� (Outputs.DateOutput)
		/// </summary>
		[Description("���� ������� (Outputs.DateOutput)")]
		public DateTime DateOutput { get { return _DateOutput; } set { _DateOutput = value; } }

		protected bool _DeliveryNeed;
		/// <summary>
		/// ��������� ���� �������� (����� ��� ������������ �������) (Outputs.DeliveryNeed)?
		/// </summary>
		[Description("��������� ���� �������� (����� ��� ������������ �������) (Outputs.DeliveryNeed)?")]
		public bool DeliveryNeed { get { return _DeliveryNeed; } set { _DeliveryNeed = value; } }

		protected int _OutputTypeID;
		/// <summary>
		/// ��� ������� - ��� (Outputs.OutputTypeID)
		/// </summary>
		[Description("��� ������� - ��� (Outputs.OutputTypeID)")]
		public int OutputTypeID { get { return _OutputTypeID; } set { _OutputTypeID = value; } }

		protected string _OutputTypeName;
		/// <summary>
		/// ��� ������� - ������������ (Outputs.OutputTypeID -> OutputsTypes.Name)
		/// </summary>
		[Description("��� ������� - ������������ (Outputs.OutputTypeID -> OutputsTypes.Name)")]
		public string OutputTypeName { get { return _OutputTypeName; } set { _OutputTypeName = value; } }

		protected bool _IsRefund;
		/// <summary>
		/// ��� ������� - ������� (Outputs.OutputTypeID -> OutputsTypes.IsRefund)
		/// </summary>
		[Description("��� ������� - ������� (Outputs.OutputTypeID -> OutputsTypes.IsRefund)")]
		public bool IsRefund { get { return _IsRefund; } set { _IsRefund = value; } }


		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (Outputs.PartnerID -> Partners.ID)
		/// </summary>
		[Description("�������� ������ - ��� (Outputs.PartnerID -> Partners.ID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// �������� ������ - ������������ (Outputs.PartnerID -> Partners.ID -> Partners.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (Outputs.PartnerID -> Partners.ID -> Partners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

		protected int? _GoodStateID;
		/// <summary>
		/// ��������� ������ - ��� (Outputs.PartnerID -> Partners.GoodStateID)
		/// </summary>
		[Description("��������� ������ - ��� (Outputs.PartnerID -> Partners.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// ��������� ������ - ������������ (Outputs.PartnerID -> Partners.GoodStateID -> GoodStates.Name)
		/// </summary>
		[Description("��������� ������ - ������������ (Outputs.PartnerID -> Partners.GoodStateID -> GoodStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int? _PartnerID;
		/// <summary>
		/// ������-���������� - ��� (Outputs.PartnerID)
		/// </summary>
		[Description("������-���������� - ��� (Outputs.PartnerID)")]
		public int? PartnerID { get { return _PartnerID; } set { _PartnerID = value; } }

		protected string _PartnerName;
		/// <summary>
		/// ������-���������� - ������������ (Outputs.PartnerID -> Partners.Name)
		/// </summary>
		[Description("������-���������� - ������������ (Outputs.PartnerID -> Partners.Name)")]
		public string PartnerName { get { return _PartnerName; } set { _PartnerName = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// ���� �������-���������� - ��� (Outputs.PartnerID -> Partners.ZoneID)
		/// </summary>
		[Description("���� �������-���������� - ��� (Outputs.PartnerID -> Partners.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// ���� �������-���������� - ������������ (Outputs.PartnerID -> Partners.ZoneID -> Zones.Name)
		/// </summary>
		[Description("���� �������-���������� - ������������ (Outputs.ZoneID -> Partners.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _ZoneAlias;
		/// <summary>
		/// ���� �������-���������� - ������� ������������ (Outputs.PartnerID -> Partners.ZoneID -> Zones.Alias)
		/// </summary>
		[Description("���� �������-���������� - ������� ������������ (Outputs.ZoneID -> Partners.ZoneID -> Zones.Alias)")]
		public string ZoneAlias { get { return _ZoneAlias; } set { _ZoneAlias = value; } }

		protected string _DeliveryAddress;
		/// <summary>
		/// ����� �������� �������-���������� (Outputs.PartnerID -> Partners.DeliveryAddress)
		/// </summary>
		[Description("����� �������� �������-���������� (Outputs.PartnerID -> Partners.DeliveryAddress)")]
		public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

		protected string _DeliveryPassage;
		/// <summary>
		/// ������ ��� �������-���������� (Outputs.PartnerID -> Partners.DeliveryPassage)
		/// </summary>
		[Description("������ ��� �������-���������� (Outputs.PartnerID -> Partners.DeliveryPassage)")]
		public string DeliveryPassage { get { return _DeliveryPassage; } set { _DeliveryPassage = value; } }

		protected bool? _PassengerCarOnly;
		/// <summary>
		/// �������� ������ �������� ������� (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("�������� ������ �������� ������� (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? PassengerCarOnly { get { return _PassengerCarOnly; } set { _PassengerCarOnly = value; } }

		protected bool? _PosternOnly;
		/// <summary>
		/// �������� ������ ������� � ������ ������ (Outputs.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ������ ������ (Outputs.PartnerTargetID -> Partners.PosternOnly)?")]
		public bool? PosternOnly { get { return _PosternOnly; } set { _PosternOnly = value; } }

		protected bool? _LoadLiftOnly;
		/// <summary>
		/// �������� ������ ������� � ����������� (�������) (Outputs.PartnerTargetID -> Partners.LoadLiftOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ����������� (�������) (Outputs.PartnerTargetID -> Partners.LoadLiftOnly)?")]
		public bool? LoadLiftOnly { get { return _LoadLiftOnly; } set { _LoadLiftOnly = value; } }

		protected int? _PermitLevelID;
		/// <summary>
		/// ���������� ������� (����������) - ��� (Outputs.PartnerTargetID -> Partners.PermitLevelID)
		/// </summary>
		[Description("���������� ������� (����������) - ��� (Outputs.PartnerTargetID -> Partners.PermitLevelID)")]
		public int? PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// ���������� ������� (����������) - ������������ (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("���������� ������� (����������) - ������������ (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int? _PermitLevelValue;
		/// <summary>
		/// ���������� ������� (����������) - �������, �� ����� (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("���������� ������� (����������) - �������, �� ����� (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int? PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }


		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (Outputs.TripID)
		/// </summary>
		[Description("���� - ��� (Outputs.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected bool _TripExists;
		/// <summary>
		/// ������� ������������ � ����� (Outputs.TripID is not Null)?
		/// </summary>
		[Description("������� ������������ � ����� (Outputs.TripID is not Null)?")]
		public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }

		protected bool _ActsExists;
		/// <summary>
		/// ������� ����� ���� (Outputs.ID - Acts.OutputID)?
		/// </summary>
		[Description("������� ����� ���� (Outputs.ID - Acts.OutputID)?")]
		public bool ActsExists { get { return _ActsExists; } set { _ActsExists = value; } }


		protected decimal _Netto;
		/// <summary>
		/// ��� ������ - �����, �� (Outputs.Netto)
		/// </summary>
		[Description("��� ������ - �����, �� (Outputs.Netto)")]
		public decimal Netto { get { return _Netto; } set { _Netto = value; } }

		protected decimal _Brutto;
		/// <summary>
		/// ��� ������������ ������ - ������, �� (Outputs.Brutto)
		/// </summary>
		[Description("��� ������ - ������, �� (Outputs.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected decimal _Volume;
		/// <summary>
		/// �����, �3 (Outputs.Volume())
		/// </summary>
		[Description("�����, �3 (Outputs.Volume())")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }

		protected decimal _PalletsQnt;
		/// <summary>
		/// ���������� ����������� ������ � ������� (Outputs.PalletsQnt)
		/// </summary>
        [Description("���������� ����������� ������ � ������� (Outputs.PalletsQnt)")]
		public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }

		protected int _PointsQnt;
		/// <summary>
		/// ���������� �������� ����� (Outputs.PointsQnt)
		/// </summary>
		[Description("���������� �������� ����� (Outputs.PointsQnt)")]
		public int PointsQnt { get { return _PointsQnt; } set { _PointsQnt = value; } }

		protected int _OutputsDocumentsQnt;
		/// <summary>
		/// ���������� ��������� ����������, �������� � ������� (Outputs.OutputsDocumentsQnt)
		/// </summary>
		[Description("���������� ��������� ����������, �������� � ������� (Outputs.OutputsDocumentsQnt)")]
		public int OutputsDocumentsQnt { get { return _OutputsDocumentsQnt; } set { _OutputsDocumentsQnt = value; } }

		protected string _DepartmentName;
		/// <summary>
		/// ����� - ������������ (Outputs.DepartmentName - dbo)
		/// </summary>
		[Description("����� - ������������ (Outputs.DepartmentName - dbo)")]
		public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � ������� (Outputs.Note)
		/// </summary>
		[Description("���������� � ������� (Outputs.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _PartnersNames;
		/// <summary>
		/// �������� ���������-����������� - ������������ (Outputs.PartnersNames)
		/// </summary>
		[Description("�������� ���������-����������� - ������������ (Outputs.PartnersNames)")]
		public string PartnersNames { get { return _PartnersNames; } set { _PartnersNames = value; } }

		protected string _OutputsDocumentsNotes;
		/// <summary>
		/// ���������� � ��������� ���������� - ����������� (Outputs.OutputsDocumentsNotes)
		/// </summary>
		[Description("���������� � ��������� ���������� - ����������� (Outputs.OutputsDocumentsNotes)")]
		public string OutputsDocumentsNotes { get { return _OutputsDocumentsNotes; } set { _OutputsDocumentsNotes = value; } }


		protected bool _TPL;
		/// <summary>
		/// 3PL (Outputs.TPL)?
		/// </summary>
		[Description("3PL (Outputs.TPL)?")]
		public bool TPL { get { return _TPL; } set { _TPL = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// ����-����� �������� ������� (Outputs.DateCreate)?
		/// </summary>
		[Description("����-����� �������� ������� (Outputs.DateCreate)?")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected bool _NotForJoin;
		/// <summary>
		/// ������� ������ ���������� � ������� ��������� (Outputs.NotForJoin)?
		/// </summary>
		[Description("������� ������ ���������� � ������� ��������� (Outputs.NotForJoin)?")]
		public bool NotForJoin { get { return _NotForJoin; } set { _NotForJoin = value; } }

		protected DateTime? _DateAttachToTrip;
		/// <summary>
		/// ����-����� ������������� � ����� (Outputs.DateAttachToTrip)?
		/// </summary>
		[Description("����-����� ������������� � ����� (Outputs.DateAttachToTrip)?")]
		public DateTime? DateAttachToTrip { get { return _DateAttachToTrip; } set { _DateAttachToTrip = value; } }

		protected bool _ReadyForWMS;
		/// <summary>
		/// ������ � �������� � ��������� ������� (Outputs.ReadyForWMS)?
		/// </summary>
		[Description("������ � �������� � ��������� ������� (Outputs.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }

		protected bool _SentToWMS;
		/// <summary>
		/// �������� � ��������� ������� (Outputs.SentToWMS)?
		/// </summary>
		[Description("�������� � ��������� ������� (Outputs.SentToWMS)?")]
		public bool SentToWMS { get { return _SentToWMS; } set { _SentToWMS = value; } }

		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� ������� (Outputs.DateConfirm)?
		/// </summary>
		[Description("����-����� ������������� ������� (Outputs.DateConfirm)?")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// ������������ (Outputs.IsConfirmed)?
		/// </summary>
		[Description("������������� (Outputs.IsConfirmed)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }

		protected DateTime? _DatePick;
		/// <summary>
		/// ����-����� ����� ������� (Outputs.DatePick)?
		/// </summary>
		[Description("����-����� ����� ������� (Outputs.DatePick)?")]
		public DateTime? DatePick { get { return _DatePick; } set { _DatePick = value; } }

		protected bool _IsPicked;
		/// <summary>
		/// ������� (Outputs.IsPicked)?
		/// </summary>
		[Description("������� (Outputs.IsPicked)?")]
		public bool IsPicked { get { return _IsPicked; } set { _IsPicked = value; } }


		protected bool _IsCarried;
		/// <summary>
		/// ������� ���������� (.dbo.OutputIsCarried(ID))?
		/// </summary>
		[Description("������� ���������� (.dbo.OutputIsCarried(ID))?")]
		public bool IsCarried { get { return _IsCarried; } set { _IsCarried = value; } }

		protected bool _IsCopied;
		/// <summary>
		/// ������� ���������� � ����������� (.dbo.OutputIsCopied(ID))?
		/// </summary>
		[Description("������� ���������� � ����������� (.dbo.OutputIsCopied(ID))?")]
		public bool IsCopied { get { return _IsCopied; } set { _IsCopied = value; } }

		protected int? _CopiedFromOutputID;
		/// <summary>
		/// ������� ���� ������� �� ������� ������� - ��� (.dbo.OutputCopiedFrom(ID))?
		/// </summary>
		[Description("������� ���� ������� �� ������� ������� - ��� (.dbo.OutputCopiedFrom(ID))?")]
		public int? CopiedFromOutputID { get { return _CopiedFromOutputID; } set { _CopiedFromOutputID = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (Outputs.HostID)
		/// </summary>
		[Description("Host - ��� (Outputs.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (OutputsDocuments.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (OutputsDocuments.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// ��� ������� � host-������� (Outputs.ERPCode)
		/// </summary>
		[Description("��� ������� � host-������� (Outputs.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (Outputs.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (Outputs.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }
		
		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ������� �� ������ - ��������� ���� ������� (Outputs.DateOutput)
		/// </summary>
		[Description("������-����: ���� ������� �� ������ - ��������� ���� ������� (Outputs.DateOutput)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ������� �� ������ - �������� ���� ������� (Outputs.DateOutput)
		/// </summary>
		[Description("������-����: ���� ������� �� ������ - �������� ���� ������� (Outputs.DateOutput)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterOutputsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� ������� �� ������, ����� ������� (Outputs.OutputTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� ������� �� ������, ����� ������� (Outputs.OutputTypeID)")]
		public string FilterOutputsTypesList { get { return _FilterOutputsTypesList; } set { _FilterOutputsTypesList = value; _NeedRequery = true; } }

		protected bool? _FilterDeliveryNeed;
		/// <summary>
		/// ������-����: ��������� ���� �������� (����� ��� ������������ �������) (Outputs.DeliveryNeed)?
		/// </summary>
		[Description("������-����: ��������� ���� �������� (����� ��� ������������ �������) (Outputs.DeliveryNeed)?")]
		public bool? FilterDeliveryNeed { get { return _FilterDeliveryNeed; } set { _FilterDeliveryNeed = value; _NeedRequery = true; } }

		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// ������-����: ������� �� ������ ������ � �������� � ��������� ������� (Outputs.ReadyForWMS)?
		/// </summary>
		[Description("������-����: ������� �� ������ ������ � �������� � ��������� ������� (Outputs.ReadyForWMS)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }

		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: ������� �� ������ ������������ (Outputs.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: ������� �� ������ ������������ (Outputs.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterIsCarried;
		/// <summary>
		/// ������-����: ������� �� ������ ���������� (Outputs.IsCarried())?
		/// </summary>
		[Description("������-����: ������� �� ������ ���������� (Outputs.IsCarried())?")]
		public bool? FilterIsCarried { get { return _FilterIsCarried; } set { _FilterIsCarried = value; _NeedRequery = true; } }


		protected string _FilterPartnersList;
		/// <summary>
		/// ������-����: ������ ����� ��������-�����������, ����� ������� (Outputs.PartnerID)
		/// </summary>
		[Description("������-����: ������ ����� ��������-�����������, ����� ������� (Outputs.PartnerID)")]
		public string FilterPartnersList { get { return _FilterPartnersList; } set { _FilterPartnersList = value; _NeedRequery = true; } }

		protected string _FilterPartnerNameContext;
		/// <summary>
		/// ������-����: �������� �������-����������, �������� (Outputs.PartnerID -> Partners.Name)
		/// </summary>
		[Description("������-����: �������� �������-����������, �������� (Outputs.PartnerID -> Partners.Name)")]
		public string FilterPartnerNameContext { get { return _FilterPartnerNameContext; } set { _FilterPartnerNameContext = value; _NeedRequery = true; } }

		protected bool? _FilterPassengerCarOnly;
		/// <summary>
		/// ������-����: �������� �������� ������� (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("������-����: �������� �������� ������� (Outputs.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? FilterPassengerCarOnly { get { return _FilterPassengerCarOnly; } set { _FilterPassengerCarOnly = value; _NeedRequery = true; } }

		protected bool? _FilterPosternOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ������ (Outputs.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ������ (Outputs.PartnerTargetID -> Partners.Postern)?")]
		public bool? FilterPosternOnly { get { return _FilterPosternOnly; } set { _FilterPosternOnly = value; _NeedRequery = true; } }

		protected bool? _FilterLoadLiftOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ����������� (�������) (Outputs.PartnerTargetID -> Partners.LoadLift)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ����������� (�������) (Outputs.PartnerTargetID -> Partners.LoadLift)?")]
		public bool? FilterLoadLiftOnly { get { return _FilterLoadLiftOnly; } set { _FilterLoadLiftOnly = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// ������-����: ���������� ������� - �������, �� ����� (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("������-����: ���������� ������� - �������, �� ����� (Outputs.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		protected string _FilterZonesList;
		/// <summary>
		/// ������-����: ������ ����� ��� ��������-�����������, ����� ������� (Outputs.PartnerTargetID -> Partners.ZoneID)
		/// </summary>
		[Description("������-����: ������ ����� ��� ��������-�����������, ����� ������� (Outputs.PartnerTargetID -> Partners.ZoneID)")]
		public string FilterZonesList { get { return _FilterZonesList; } set { _FilterZonesList = value; _NeedRequery = true; } }


		protected string _FilterOutputsDocumentsList;
		/// <summary>
		/// ������-����: ������ ����� ��������� ����������, ����� ������� (OutputsDocuments.OutputID)
		/// </summary>
		[Description("������-����: ������ ����� ��������� ����������, ����� ������� (OutputsDocuments.OutputID)")]
		public string FilterOutputsDocumentsList { get { return _FilterOutputsDocumentsList; } set { _FilterOutputsDocumentsList = value; _NeedRequery = true; } }


		protected bool? _FilterTripExists;
		/// <summary>
		/// ������-����: ������� ������������ � ����� (Outputs.TripID is not Null)?
		/// </summary>
		[Description("������-����: ������� ������������ � ����� (Outputs.TripID is not Null)?")]
		public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (Outputs.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (Outputs.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// ������-����: ������ ����� ����������, ����� ������� (Outputs.OwnerID)
		/// </summary>
		[Description("������-����: ������ ����� ����������, ����� ������� (Outputs.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (Outputs.ID --> OutputsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (Outputs.ID --> OutputsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (Outputs.ID --> OutputsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (Outputs.ID --> OutputsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableOutputsGoods;
		/// <summary>
		/// ������ ������� � ������� OutputsGoods
		/// </summary>
		[Description("������ ������� � ������� OutputsGoods")]
		public DataTable TableOutputsGoods { get { return _TableOutputsGoods; } }

		protected DataTable _TableOutputsTypes;
		/// <summary>
		/// ������� ����� �������� OutputsTypes
		/// </summary>
		[Description("������� ����� �������� OutputsTypes")]
		public DataTable TableOutputsTypes { get { return _TableOutputsTypes; } }

		#endregion �������


		// -------------------------------------

		public Output() : base()
		{
			_MainTableName = "Outputs";
			_ColumnID = "ID";
			_ColumnName = "DateOutput";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������� �� ������ � ��������������� ���������� � MainTable
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

		// ���������� ���������� ������� ���������� ������� ������� ������ 
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
		/// ������������� ���������� ������� �� ������ 
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

		#region Delete

		/// <summary>
		/// �������� �������
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
				_ErrorStr = "������ ��� �������� ������ � �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete

		#region Set/Clear dates-times

		#region ReadyForWMS

		/// <summary>
		/// ���������/�������� ������� "������� ������ � �������� � ��������� �������"
		/// nUserID: �� ���.
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
				_ErrorStr = "������ ��� " + (bClear ? "������" : "���������") + " �������� \"������ � �������� � ��������� �������\"...\r\n" + ex.Message;
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
		/// ���������/�������� ������� "��������� ���� ��������"
		/// nUserID: �� ���.
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
				_ErrorStr = "������ ��� ��������� ��������� ������ �� �������� �� ������..." + Convert.ToChar(13) + ex.Message;
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
		/// ������� ������� �� ������ � ���� �������� � ���� ��������� ���������� �� ������ ����
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
		/// ����������� (�������) ������� �� ������ � ���� �������� � ���� ��������� ���������� �� ������ ����
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
				_ErrorStr = "������ ��� ������� ����������� (��������) ������� �� ������ �� ������ ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����������� (��������) ������� �� ������ �� ������ ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
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
		/// ����� ���� ������� � ���� �������� � ���� ��������� ���������� �� ������ ����
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

		/// <summary>
		/// ������ �������� ������� � ���� �������� � ���� ��������� ���������� � �������� �� ������� � �����
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
				_ErrorStr = "������ ��� ������� ������ �������� ������� �� ������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ �������� ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ����������� ������� � ���� �������� � ���� ��������� ���������� 
		/// (�������� ��������� ������� � ����������, ����������� ���������� � �������� ���������)
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
				_ErrorStr = "������ ��� ������� ������ ����������� ������� �� ������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ����������� ������� �� ������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carry

		#region ChangeOutputType

		/// <summary>
		/// ������� ������� �� ������ � ���� �������� � ���� ��������� ���������� �� ������ ����
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
				_ErrorStr = "������ ��� ������� ��������� ���� ������� �� ������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ChangeOutputType


		#region �������

		#region OutputsGoods

		/// <summary>
		/// ��������� ������� ������� � ������� �� ������ TableOutputsGoods
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

		public bool FillTableOutputsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableOutputsGoods((int)_ID);
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
		/// ��������� ������� ������� � ������� �� ������ TableOutputsGoods - � ������ �����
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

		public bool FillTableOutputsGoodsWithActs()
		{
			if (_ID.HasValue)
			{
				FillTableOutputsGoodsWithActs((int)_ID);
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

		#endregion OutputsGoods

		#region TTN

		/// <summary>
		/// ��������� ������� ������� � ������� (TableOutputsGoods) - � ������� ��� ������ ����������
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
				_ErrorStr = "������ ��� ������� ��������� ������ �������� ��� ���..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ �������� ��� ���...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion TTN 

		#region Carries

		/// <summary>
		/// ��������� ������ ��������� � ����������� ��� ������� (TableOutputsCarries)
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
				_ErrorStr = "������ ��� ��������� ������ ��������� � ����� ��� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carries

		#region OutputsTypes

		/// <summary>
		/// ��������� ������� ����� �������� TableOutputsTypes
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
				_ErrorStr = "������ ��� ��������� ������ ����� ��������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsTypes

		#endregion �������

	}

#endregion Output

}
