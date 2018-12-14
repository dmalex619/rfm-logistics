using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ��������� �������� (����� �� �������� ������) (OutputDocument)
/// </summary>
/// 
namespace LogBizObjects
{

#region OutputDocument 

	public class OutputDocument : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ��������� ���������� (OutputsDocuments.ID)
		/// </summary>
		[Description("������ ����� ID ��������� ���������� (OutputsDocuments.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateOutput;
		/// <summary>
		/// ���� ��������� (OutputsDocuments.DateOutput)
		/// </summary>
		[Description("���� ��������� (OutputsDocuments.DateOutput)")]
		public DateTime DateOutput { get { return _DateOutput; } set { _DateOutput = value; } }

		protected bool _DeliveryNeed;
		/// <summary>
		/// ��������� ���� �������� (����� ��� ������������ �������) (OutputsDocuments.DeliveryNeed)?
		/// </summary>
		[Description("��������� ���� �������� (����� ��� ������������ �������) (OutputsDocuments.DeliveryNeed)?")]
		public bool DeliveryNeed { get { return _DeliveryNeed; } set { _DeliveryNeed = value; } }

		protected int _OutputDocumentTypeID;
		/// <summary>
		/// ��� ���������� ��������� - ��� (OutputsDocuments.OutputDocumentTypeID)
		/// </summary>
		[Description("��� ���������� ��������� - ��� (OutputsDocuments.OutputDocumentTypeID)")]
		public int OutputDocumentTypeID { get { return _OutputDocumentTypeID; } set { _OutputDocumentTypeID = value; } }

		protected string _OutputDocumentTypeName;
		/// <summary>
		/// ��� ���������� ��������� - ������������ (OutputsDocuments.OutputDocumentTypeID -> OutputsDocumentsTypes.Name)
		/// </summary>
		[Description("��� ���������� ��������� - ������������ (OutputsDocuments.OutputDocumentTypeID -> OutputsDocumentsTypes.Name)")]
		public string OutputDocumentTypeName { get { return _OutputDocumentTypeName; } set { _OutputDocumentTypeName = value; } }

		protected bool _IsRefund;
		/// <summary>
		/// ��� ���������� ��������� - ������� (OutputsDocuments.OutputDocumentTypeID -> OutputsDocumentsTypes.IsRefund)
		/// </summary>
		[Description("��� ���������� ��������� - ������� (OutputsDocuments.OutputDocumentTypeID -> OutputsDocumentsTypes.IsRefund)")]
		public bool IsRefund { get { return _IsRefund; } set { _IsRefund = value; } }

		protected bool _IsReturn;
		/// <summary>
		/// ������� (OutputsDocuments.IsReturn)?
		/// </summary>
		[Description("������� (OutputsDocuments.IsReturn)")]
		public bool IsReturn { get { return _IsReturn; } set { _IsReturn = value; } }


		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (OutputsDocuments.PartnerID -> Partners.OwnerID)
		/// </summary>
		[Description("�������� ������ - ��� (OutputsDocuments.PartnerID -> Partners.OwnerID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// �������� ������ - ������������ (OutputsDocuments.PartnerID -> Partners.OwnerID -> Owners.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (OutputsDocuments.PartnerID -> Partners.OwnerID -> Owners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

		protected int? _GoodStateID;
		/// <summary>
		/// ��������� ������ - ��� (OutputsDocuments.PartnerID -> Partners.GoodStateID)
		/// </summary>
		[Description("��������� ������ - ��� (OutputsDocuments.PartnerID -> Partners.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// ��������� ������ - ������������ (OutputsDocuments.PartnerID -> Partners.GoodStateID -> GoodStates.Name)
		/// </summary>
		[Description("��������� ������ - ������������ (OutputsDocuments.PartnerID -> Partners.GoodStateID -> GoodStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int _PartnerDetailSalerID;
		/// <summary>
		/// ��������-���������, ��������� (��) - ��� ���������� (OutputsDocuments.PartnerDetailSalerID)
		/// </summary>
		[Description("��������-���������, ��������� (��) - ��� ���������� (OutputsDocuments.PartnerDetailSalerID)")]
		public int PartnerDetailSalerID { get { return _PartnerDetailSalerID; } set { _PartnerDetailSalerID = value; } }

		protected string _PartnerSalerFactName;
		/// <summary>
		/// ��������-���������, ��������� (��) - ������ ������������ �� ���������� (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.FactName)
		/// </summary>
		[Description("��������-���������, ��������� (��) - ������ ������������ �� ���������� (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.FactName)")]
		public string PartnerSalerFactName { get { return _PartnerSalerFactName; } set { _PartnerSalerFactName = value; } }

		protected int _PartnerSourceID;
		/// <summary>
		/// ��������-��������� (��) - ��� (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.PartnerID)
		/// </summary>
		[Description("��������-��������� (��) - ��� (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.PartnerID)")]
		public int PartnerSourceID { get { return _PartnerSourceID; } set { _PartnerSourceID = value; } }

		protected string _PartnerSourceName;
		/// <summary>
		/// ��������-��������� (��) - ������������ (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.PartnerID -> Partners.Name)
		/// </summary>
		[Description("��������-��������� (��) - ������������ (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.PartnerID -> Partners.Name)")]
		public string PartnerSourceName { get { return _PartnerSourceName; } set { _PartnerSourceName = value; } }


		protected int _PartnerDetailShipperID;
		/// <summary>
		/// ����������������, ��������� - ��� ���������� (OutputsDocuments.PartnerDetailShipperID)
		/// </summary>
		[Description("����������������, ��������� - ��� ���������� (OutputsDocuments.PartnerDetailShipperID)")]
		public int PartnerDetailShipperID { get { return _PartnerDetailShipperID; } set { _PartnerDetailShipperID = value; } }

		protected string _PartnerShipperFactName;
		/// <summary>
		/// ����������������, ��������� - ������ ������������ �� ���������� (OutputsDocuments.PartnerDetailShipperID -> PartnersDetails.FactName)
		/// </summary>
		[Description("����������������, ��������� - ������ ������������ �� ���������� (OutputsDocuments.PartnerDetailShipperID -> PartnersDetails.FactName)")]
		public string PartnerShipperFactName { get { return _PartnerShipperFactName; } set { _PartnerShipperFactName = value; } }

		protected int _PartnerShipperID;
		/// <summary>
		/// ���������������� - ��� (OutputsDocuments.PartnerDetailShipperID -> PartnersDetails.PartnerID)
		/// </summary>
		[Description("���������������� - ��� (OutputsDocuments.PartnerDetailShipperID -> PartnersDetails.PartnerID)")]
		public int PartnerShipperID { get { return _PartnerShipperID; } set { _PartnerShipperID = value; } }

		protected string _PartnerShipperName;
		/// <summary>
		/// ���������������� - ������������ (OutputsDocuments.PartnerDetailShipperID -> PartnersDetails.PartnerID -> Partners.Name)
		/// </summary>
		[Description("���������������� - ������������ (OutputsDocuments.PartnerDetailShipperID -> PartnersDetails.PartnerID -> Partners.Name)")]
		public string PartnerShipperName { get { return _PartnerShipperName; } set { _PartnerShipperName = value; } }


		protected int _PartnerDetailBayerID;
		/// <summary>
		/// ����������-����������, ��������� - ��� (OutputsDocuments.PartnerDetailBayerID)
		/// </summary>
		[Description("����������-����������, ��������� - ��� (OutputsDocuments.PartnerDetailBayerID)")]
		public int PartnerDetailBayerID { get { return _PartnerDetailBayerID; } set { _PartnerDetailBayerID = value; } }

		protected string _PartnerBayerFactName;
		/// <summary>
		/// ����������-����������, ��������� - ������ ������������ �� ���������� (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.FactName)
		/// </summary>
		[Description("����������-����������, ��������� - ������ ������������ �� ���������� (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.FactName)")]
		public string PartnerBayerFactName { get { return _PartnerBayerFactName; } set { _PartnerBayerFactName = value; } }

		protected int _PartnerTargetID;
		/// <summary>
		/// ����������-���������� - ��� (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.PartnerID)
		/// </summary>
		[Description("����������-���������� - ��� (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.PartnerID)")]
		public int PartnerTargetID { get { return _PartnerTargetID; } set { _PartnerTargetID = value; } }

		protected string _PartnerTargetName;
		/// <summary>
		/// ����������-���������� - ������������ (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.PartnerID -> Partners.Name)
		/// </summary>
		[Description("����������-���������� - ������������ (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.PartnerID-> Partners.Name)")]
		public string PartnerTargetName { get { return _PartnerTargetName; } set { _PartnerTargetName = value; } }


		protected int? _ZoneID;
		/// <summary>
		/// ���� �������-���������� - ��� (OutputsDocuments.PartnerID -> Partners.ZoneID)
		/// </summary>
		[Description("���� �������-���������� - ��� (OutputsDocuments.PartnerID -> Partners.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// ���� �������-���������� - ������������ (OutputsDocuments.PartnerID -> Partners.ZoneID -> Zones.Name)
		/// </summary>
		[Description("���� �������-���������� - ������������ (OutputsDocuments.ZoneID -> Partners.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _ZoneAlias;
		/// <summary>
		/// ���� �������-���������� - ������� ������������ (OutputsDocuments.PartnerID -> Partners.ZoneID -> Zones.Alias)
		/// </summary>
		[Description("���� �������-���������� - ������� ������������ (OutputsDocuments.ZoneID -> Partners.ZoneID -> Zones.Alias)")]
		public string ZoneAlias { get { return _ZoneAlias; } set { _ZoneAlias = value; } }

		protected string _DeliveryAddress;
		/// <summary>
		/// ����� �������� �������-���������� (OutputsDocuments.PartnerID -> Partners.DeliveryAddress)
		/// </summary>
		[Description("����� �������� �������-���������� (OutputsDocuments.PartnerID -> Partners.DeliveryAddress)")]
		public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

		protected string _DeliveryPassage;
		/// <summary>
		/// ������ ��� �������-���������� (OutputsDocuments.PartnerID -> Partners.DeliveryPassage)
		/// </summary>
		[Description("������ ��� �������-���������� (OutputsDocuments.PartnerID -> Partners.DeliveryPassage)")]
		public string DeliveryPassage { get { return _DeliveryPassage; } set { _DeliveryPassage = value; } }

		protected bool _PassengerCarOnly;
		/// <summary>
		/// �������� ������ �������� ������� (OutputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("�������� ������ �������� ������� (OutputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool PassengerCarOnly { get { return _PassengerCarOnly; } set { _PassengerCarOnly = value; } }

		protected bool _PosternOnly;
		/// <summary>
		/// �������� ������ ������� � ������ ������ (OutputsDocuments.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ������ ������ (OutputsDocuments.PartnerTargetID -> Partners.PosternOnly)?")]
		public bool PosternOnly { get { return _PosternOnly; } set { _PosternOnly = value; } }

		protected bool _LoadLiftOnly;
		/// <summary>
		/// �������� ������ ������� � ����������� (�������) (OutputsDocuments.PartnerTargetID -> Partners.LoadLiftOnly)?
		/// </summary>
		[Description("�������� ������ ������� � ����������� (�������) (OutputsDocuments.PartnerTargetID -> Partners.LoadLiftOnly)?")]
		public bool LoadLiftOnly { get { return _LoadLiftOnly; } set { _LoadLiftOnly = value; } }

		protected int _PermitLevelID;
		/// <summary>
		/// ���������� ������� (����������) - ��� (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID)
		/// </summary>
		[Description("���������� ������� (����������) - ��� (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID)")]
		public int PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// ���������� ������� (����������) - ������������ (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("���������� ������� (����������) - ������������ (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int _PermitLevelValue;
		/// <summary>
		/// ���������� ������� (����������) - �������, �� ����� (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("���������� ������� (����������) - �������, �� ����� (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected int _Priority;
		/// <summary>
		/// ��������� (OutputsDocuments.Priority)
		/// </summary>
		[Description("��������� (OutputsDocuments.Priority)")]
		public int Priority { get { return _Priority; } set { _Priority = value; } }

		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (OutputsDocuments.TripID)
		/// </summary>
		[Description("���� - ��� (OutputsDocuments.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected bool _TripExists;
		/// <summary>
		/// �������� ����������� � ����� (OutputsDocuments.TripID is not Null)?
		/// </summary>
		[Description("�������� ����������� � ����� (OutputsDocuments.TripID is not Null)?")]
		public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }

		protected int? _CarID;
		/// <summary>
		/// ������ - ��� (OutputsDocuments.TripID -> Trips.CarID)
		/// </summary>
		[Description("������ - ��� (OutputsDocuments.TripID -> Trips.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// ������ - ������������ (OutputsDocuments.TripID -> Trips.CarID -> Cars.Name)
		/// </summary>
		[Description("������ - ������������ (OutputsDocuments.TripID -> Trips.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// ���������-�������� - ��� (OutputsDocuments.TripID -> Trips.DriverEmployeeID)
		/// </summary>
		[Description("���������-�������� - ��� (OutputsDocuments.TripID -> Trips.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// ���������-�������� - ��� (OutputsDocuments.TripID -> Trips.DriverEmployeeID -> Employees.Name)
		/// </summary>
		[Description("���������-�������� - ��� (OutputsDocuments.TripID -> Trips.DriverEmployeeID -> Employees.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected string _TimeDelivery;
		/// <summary>
		/// ����� �������� ����������� (OutputsDocuments.TimeDelivery)
		/// </summary>
		[Description("����� �������� ����������� (OutputsDocuments.TimeDelivery)")]
		public string TimeDelivery { get { return _TimeDelivery; } set { _TimeDelivery = value; } }

		protected DateTime? _DateBegPlan;
		/// <summary>
		/// ����-����� ������ ���������� - ���� (OutputsDocuments.DateBegPlan)
		/// </summary>
		[Description("����-����� ������ ���������� - ���� (OutputsDocuments.DateBegPlan)")]
		public DateTime? DateBegPlan { get { return _DateBegPlan; } set { _DateBegPlan = value; } }

		protected DateTime? _DateEndPlan;
		/// <summary>
		/// ����-����� ��������� ���������� - ���� (OutputsDocuments.DateEndPlan)
		/// </summary>
		[Description("����-����� ��������� ���������� - ���� (OutputsDocuments.DateEndPlan)")]
		public DateTime? DateEndPlan { get { return _DateEndPlan; } set { _DateEndPlan = value; } }

		protected int? _DurationMinutesPlan;
		/// <summary>
		/// ������������ ����������, ���. - ���� (OutputsDocuments.DurationMinutesPlan())
		/// </summary>
		[Description("������������ ����������, ���. - ���� (OutputsDocuments.DurationMinutesPlan())")]
		public int? DurationMinutesPlan { get { return _DurationMinutesPlan; } set { _DurationMinutesPlan = value; } }

		protected DateTime? _DateBegFact;
		/// <summary>
		/// ����-����� ������ ���������� - ���� (OutputsDocuments.DateBegFact)
		/// </summary>
		[Description("����-����� ������ ���������� - ���� (OutputsDocuments.DateBegFact)")]
		public DateTime? DateBegFact { get { return _DateBegFact; } set { _DateBegFact = value; } }

		protected DateTime? _DateEndFact;
		/// <summary>
		/// ����-����� ��������� ���������� - ���� (OutputsDocuments.DateEndFact)
		/// </summary>
		[Description("����-����� ��������� ���������� - ���� (OutputsDocuments.DateEndFact)")]
		public DateTime? DateEndFact { get { return _DateEndFact; } set { _DateEndFact = value; } }

		protected int? _DurationMinutesFact;
		/// <summary>
		/// ������������ ����������, ���. - ���� (OutputsDocuments.DurationMinutesFact())
		/// </summary>
		[Description("������������ ����������, ���. - ���� (OutputsDocuments.DurationMinutesFact())")]
		public int? DurationMinutesFact { get { return _DurationMinutesFact; } set { _DurationMinutesFact = value; } }

		protected decimal _Amount;
		/// <summary>
		/// ��������� ������ � ��������� (OutputsDocuments.Amount)
		/// </summary>
		[Description("��������� ������ � ��������� (OutputsDocuments.Amount)")]
		public decimal Amount { get { return _Amount; } set { _Amount = value; } }

		protected int _CurrencyID;
		/// <summary>
		/// ������ ��� � ��������� - ��� (OutputsDocuments.CurrencyID)
		/// </summary>
		[Description("������ ��� � ��������� - ��� (OutputsDocuments.CurrencyID)")]
		public int CurrencyID { get { return _CurrencyID; } set { _CurrencyID = value; } }

		protected string _CurrencyName;
		/// <summary>
		/// ������ ��� � ��������� - ������������ (OutputsDocuments.CurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ ��� � ��������� - ������������ (OutputsDocuments.CurrencyID -> Currencies.Name)")]
		public string CurrencyName { get { return _CurrencyName; } set { _CurrencyName = value; } }

		protected decimal _Netto;
		/// <summary>
		/// ��� ������������ ������ - �����, �� (OutputsDocuments.Netto)
		/// </summary>
		[Description("��� ������������ ������ - �����, �� (OutputsDocuments.Netto)")]
		public decimal Netto { get { return _Netto; } set { _Netto = value; } }

		protected decimal _Brutto;
		/// <summary>
		/// ��� ������������ ������ - ������, �� (OutputsDocuments.Brutto)
		/// </summary>
		[Description("��� ������������ ������ - ������, �� (OutputsDocuments.Brutto)")]
		public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

		protected decimal _Volume;
		/// <summary>
		/// �����, �3 (OutputsDocuments.Volume())
		/// </summary>
		[Description("�����, �3 (OutputsDocuments.Volume())")]
		public decimal Volume { get { return _Volume; } set { _Volume = value; } }

		protected decimal _PalletsQnt;
		/// <summary>
		/// ���������� ����������� ������ � ������� (OutputsDocuments.PalletsQnt)
		/// </summary>
		[Description("���������� ����������� ������ � ������� (OutputsDocuments.PalletsQnt)")]
		public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � ���������� ��������� (OutputsDocuments.Note)
		/// </summary>
		[Description("���������� � ���������� ��������� (OutputsDocuments.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _NoteExecute;
		/// <summary>
		/// ���������� � ���������� (��������) (OutputsDocuments.NoteExecute)
		/// </summary>
		[Description("���������� � ���������� (��������) (OutputsDocuments.NoteExecute)")]
		public string NoteExecute { get { return _NoteExecute; } set { _NoteExecute = value; } }


		protected int? _OutputDocumentFailReasonID;
		/// <summary>
		/// ������� ������������ - ��� (OutputsDocuments.OutputDocumentFailReasonID)
		/// </summary>
		[Description("������� ������������ - ��� (OutputsDocuments.OutputDocumentFailReasonID)")]
		public int? OutputDocumentFailReasonID { get { return _OutputDocumentFailReasonID; } set { _OutputDocumentFailReasonID = value; } }

		protected string _OutputDocumentFailReasonName;
		/// <summary>
		/// ������� ������������ - ������������ (OutputsDocuments.OutputDocumentFailReasonID -> OutputsDocumentsFailsReasons.Name)
		/// </summary>
		[Description("������� ������������ - ������������ (OutputsDocuments.OutputDocumentFailReasonID -> OutputsDocumentsFailsReasons.Name)")]
		public string OutputDocumentFailReasonName { get { return _OutputDocumentFailReasonName; } set { _OutputDocumentFailReasonName = value; } }

		protected int? _GuiltyID;
		/// <summary>
		/// �������� ������������ - ��� (OutputsDocuments.OutputsDocumentsFailReasonID -> OutputsDocumentsFailsReasons.GuiltyID)
		/// </summary>
		[Description("�������� ������������ - ��� (OutputsDocuments.OutputsDocumentsFailReasonID -> OutputsDocumentsFailsReasons.GuiltyID)")]
		public int? GuiltyID { get { return _GuiltyID; } set { _GuiltyID = value; } }

		protected string _GuiltyName;
		/// <summary>
		/// �������� ������������ - ������������ (OutputsDocuments.OutputsDocumentsFailReasonID -> OutputsDocumentsFailsReasons.GuiltyID -> Guilties.Name)
		/// </summary>
		[Description("�������� ������������ - ������������ (OutputsDocuments.OutputsDocumentsFailReasonID -> OutputsDocumentsFailsReasons.GuiltyID -> Guilties.Name)")]
		public string GuiltyName { get { return _GuiltyName; } set { _GuiltyName = value; } }

		protected string _GuiltyEmployees;
		/// <summary>
		/// �������� �������� - ����� (OutputsDocuments.GuiltyEmployees)
		/// </summary>
		[Description("�������� �������� - ����� (OutputsDocuments.GuiltyEmployees)")]
		public string GuiltyEmployees { get { return _GuiltyEmployees; } set { _GuiltyEmployees = value; } }

        protected bool _IsDriverFoul;
        /// <summary>
        /// ������� ���� �������� (OutputsDocuments.IsDriverFoul)
        /// </summary>
        [Description("������� ���� �������� (OutputsDocuments.IsDriverFoul)")]
        public bool IsDriverFoul { get { return _IsDriverFoul; } set { _IsDriverFoul = value; } }

		protected bool _PF_BillNeed;
		/// <summary>
		/// ����� ��������� (OutputsDocuments.PF_BillNeed)?
		/// </summary>
		[Description("����� ��������� (OutputsDocuments.PF_BillNeed)?")]
		public bool PF_BillNeed { get { return _PF_BillNeed; } set { _PF_BillNeed = value; } }

		protected bool _PF_FactureNeed;
		/// <summary>
		/// ����� ����-������� (OutputsDocuments.PF_FactureNeed)?
		/// </summary>
		[Description("����� ����-������� (OutputsDocuments.PF_FactureNeed)?")]
		public bool PF_FactureNeed { get { return _PF_FactureNeed; } set { _PF_FactureNeed = value; } }

		protected bool _PF_PayBillNeed;
		/// <summary>
		/// ����� ���� �� ������ (OutputsDocuments.PF_PayBillNeed)?
		/// </summary>
		[Description("����� ���� �� ������ (OutputsDocuments.PF_PayBillNeed)?")]
		public bool PF_PayBillNeed { get { return _PF_PayBillNeed; } set { _PF_PayBillNeed = value; } }

		protected bool _PF_WarrantNeed;
		/// <summary>
		/// ����� ������������ (OutputsDocuments.PF_WarrantNeed)?
		/// </summary>
		[Description("����� ������������ (OutputsDocuments.PF_WarrantNeed)?")]
		public bool PF_WarrantNeed { get { return _PF_WarrantNeed; } set { _PF_WarrantNeed = value; } }


		protected string _BillNumber;
		/// <summary>
		/// ����� ��������� (OutputsDocuments.BillNumber)?
		/// </summary>
		[Description("����� ��������� (OutputsDocuments.BillNumber)?")]
		public string BillNumber { get { return _BillNumber; } set { _BillNumber = value; } }

		protected string _FactureNumber;
		/// <summary>
		/// ����� �����-������� (OutputsDocuments.FactureNumber)?
		/// </summary>
		[Description("����� �����-������� (OutputsDocuments.FactureNumber)?")]
		public string FactureNumber { get { return _FactureNumber; } set { _FactureNumber = value; } }

		protected string _WarrantNumber;
		/// <summary>
		/// ����� ������������ (OutputsDocuments.WarrantNumber)?
		/// </summary>
		[Description("����� ������������ (OutputsDocuments.WarrantNumber)?")]
		public string WarrantNumber { get { return _WarrantNumber; } set { _WarrantNumber = value; } }


		protected bool _PaymentOrderNeed;
		/// <summary>
		/// ����� ��������� ����� (OutputsDocuments.PaymentOrderNeed)?
		/// </summary>
		[Description("����� ��������� ����� (OutputsDocuments.PaymentOrderNeed)?")]
		public bool PaymentOrderNeed { get { return _PaymentOrderNeed; } set { _PaymentOrderNeed = value; } }

		protected bool _OtherDocumentsNeed;
		/// <summary>
		/// ����� ������ ��������� (OutputsDocuments.OtherDocumentsNeed)?
		/// </summary>
		[Description("����� ������ ��������� (OutputsDocuments.OtherDocumentsNeed)?")]
		public bool OtherDocumentsNeed { get { return _OtherDocumentsNeed; } set { _OtherDocumentsNeed = value; } }

		protected bool _CertificatesNeed;
		/// <summary>
		/// ����� ����������� (OutputsDocuments.CertificatesNeed)?
		/// </summary>
		[Description("����� ����������� (OutputsDocuments.CertificatesNeed)?")]
		public bool CertificatesNeed { get { return _CertificatesNeed; } set { _CertificatesNeed = value; } }

		protected bool _QualityLicenceNeed;
		/// <summary>
		/// ����� ������������� �������� (OutputsDocuments.QualityLicenceNeed)?
		/// </summary>
		[Description("����� ������������� �������� (OutputsDocuments.QualityLicenceNeed)?")]
		public bool QualityLicenceNeed { get { return _QualityLicenceNeed; } set { _QualityLicenceNeed = value; } }

		protected bool _VeterinaryLicenceNeed;
		/// <summary>
		/// ����� ������������ ������������� (OutputsDocuments.VeterinaryLicenceNeed)?
		/// </summary>
		[Description("����� ������������ ������������� (OutputsDocuments.VeterinaryLicenceNeed)?")]
		public bool VeterinaryLicenceNeed { get { return _VeterinaryLicenceNeed; } set { _VeterinaryLicenceNeed = value; } }

		protected string _PartnerOrderNumber;
		/// <summary>
		/// ����� ������ �� �������� � ������� (OutputsDocuments.PartnerOrderNumber)
		/// </summary>
		[Description("����� ������ �� �������� � ������� (OutputsDocuments.PartnerOrderNumber)")]
		public string PartnerOrderNumber { get { return _PartnerOrderNumber; } set { _PartnerOrderNumber = value; } }

		protected decimal _GetMoneyWished;
		/// <summary>
		/// �������� �� ������� ����� (OutputsDocuments.GetMoneyWished)
		/// </summary>
		[Description("�������� �� ������� ����� (OutputsDocuments.GetMoneyWished)")]
		public decimal GetMoneyWished { get { return _GetMoneyWished; } set { _GetMoneyWished = value; } }

		protected decimal _GetMoneyConfirmed;
		/// <summary>
		/// �������� �� ������� ����� - ���� (OutputsDocuments.GetMoneyConfirmed)
		/// </summary>
		[Description("�������� �� ������� ����� - ���� (OutputsDocuments.GetMoneyConfirmed)")]
		public decimal GetMoneyConfirmed { get { return _GetMoneyConfirmed; } set { _GetMoneyConfirmed = value; } }

		protected int? _GetCurrencyID;
		/// <summary>
		/// ������ ��������� ����� �� ������� - ��� (OutputsDocuments.GetCurrencyID)
		/// </summary>
		[Description("������ ��������� ����� �� ������� - ��� (OutputsDocuments.GetCurrencyID)")]
		public int? GetCurrencyID { get { return _GetCurrencyID; } set { _GetCurrencyID = value; } }

		protected string _GetCurrencyName;
		/// <summary>
		/// ������ ��������� ����� �� ������� - ������������ (OutputsDocuments.GetCurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ ��������� ����� �� ������� - ������������ (OutputsDocuments.GetCurrencyID -> Currencies.Name)")]
		public string GetCurrencyName { get { return _GetCurrencyName; } set { _GetCurrencyName = value; } }

		protected bool _IsWarrantReturned;
		/// <summary>
		/// ������������ ���������� (OutputsDocuments.IsWarrantReturned)?
		/// </summary>
		[Description("������������ ���������� (OutputsDocuments.IsWarrantReturned)?")]
		public bool IsWarrantReturned { get { return _IsWarrantReturned; } set { _IsWarrantReturned = value; } }

		protected int _GetPalletsQntWished;
		/// <summary>
		/// �������� �� ������� ������ ������ (OutputsDocuments.GetPalletsQntWished)
		/// </summary>
		[Description("�������� �� ������� ������ ������ (OutputsDocuments.GetPalletsQntWished)")]
		public int GetPalletsQntWished { get { return _GetPalletsQntWished; } set { _GetPalletsQntWished = value; } }

		protected int _GetPalletsQntConfirmed;
		/// <summary>
		/// �������� �� ������� ������ ������ - ���� (OutputsDocuments.GetPalletsQntConfirmed)
		/// </summary>
		[Description("�������� �� ������� ������ ������ - ���� (OutputsDocuments.GetPalletsQntConfirmed)")]
		public int GetPalletsQntConfirmed { get { return _GetPalletsQntConfirmed; } set { _GetPalletsQntConfirmed = value; } }

		protected string _ManagerName;
		/// <summary>
		/// �������� - ��� (OutputsDocuments.ManagerName)
		/// </summary>
		[Description("�������� - ��� (OutputsDocuments.ManagerName)")]
		public string ManagerName { get { return _ManagerName; } set { _ManagerName = value; } }

		protected string _ManagerPhone;
		/// <summary>
		/// �������� - ������� (OutputsDocuments.ManagerPhone)
		/// </summary>
		[Description("�������� - ������� (OutputsDocuments.ManagerPhone)")]
		public string ManagerPhone { get { return _ManagerPhone; } set { _ManagerPhone = value; } }
		
		protected string _DepartmentName;
		/// <summary>
		/// ����� - ������������ (OutputsDocuments.DepartmentName)
		/// </summary>
		[Description("����� - ������������ (OutputsDocuments.DepartmentName)")]
		public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }
		
		protected bool _TPL;
		/// <summary>
		/// 3PL (OutputsDocuments.TPL)?
		/// </summary>
		[Description("3PL (OutputsDocuments.TPL)?")]
		public bool TPL { get { return _TPL; } set { _TPL = value; } }
		
		protected int? _ByOrder;
		/// <summary>
		/// ����� �/� ��� �������� (OutputsDocuments.ByOrder)
		/// </summary>
		[Description("����� �/� ��� �������� (OutputsDocuments.ByOrder)")]
		public int? ByOrder { get { return _ByOrder; } set { _ByOrder = value; } }


		protected DateTime? _DatePrint;
		/// <summary>
		/// ����-����� ������ ���������� (OutputsDocuments.DatePrint)
		/// </summary>
		[Description("����-����� ������ ���������� (OutputsDocuments.DatePrint)")]
		public DateTime? DatePrint { get { return _DatePrint; } set { _DatePrint = value; } }

		protected bool _IsPrinted;
		/// <summary>
		/// ��������� ����������� (OutputsDocuments.DatePrint is not Null)?
		/// </summary>
		[Description("��������� ����������� (OutputsDocuments.DatePrint is not Null)?")]
		public bool IsPrinted { get { return _IsPrinted; } set { _IsPrinted = value; } }


		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� �������� �� ������ (OutputsDocuments.DateConfirm)
		/// </summary>
		[Description("����-����� ������������� �������� �� ������ (OutputsDocuments.DateConfirm)")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected int? _UserConfirmID;
		/// <summary>
		/// ������������, ������������� �������� �� ������ - ��� (OutputsDocuments.UserConfirmID)
		/// </summary>
		[Description("������������, ������������� �������� �� ������ - ��� (OutputsDocuments.UserConfirmID)")]
		public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

		protected string _UserConfirmName;
		/// <summary>
		/// ������������, ������������� �������� �� ������ - ��� (OutputsDocuments.UserConfirmID -> _Users.Name)
		/// </summary>
		[Description("������������, ������������� �������� �� ������ - ��� (OutputsDocuments.UserConfirmID -> _Users.Name)")]
		public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// �������� �� ������ ������������ (OutputsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("�������� �� ������ ������������ (OutputsDocuments.Confirmed)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected DateTime? _DateBring;
		/// <summary>
		/// ����-����� ������������� �������� ������� (OutputsDocuments.DateBring)
		/// </summary>
		[Description("����-����� ������������� �������� ������� (OutputsDocuments.DateBring)")]
		public DateTime? DateBring { get { return _DateBring; } set { _DateBring = value; } }

		protected int? _UserBringID;
		/// <summary>
		/// ������������, ������������� �������� ������� - ��� (OutputsDocuments.UserBringID)
		/// </summary>
		[Description("������������, ������������� �������� ������� - ��� (OutputsDocuments.UserBringID)")]
		public int? UserBringID { get { return _UserBringID; } set { _UserBringID = value; } }

		protected string _UserBringName;
		/// <summary>
		/// ������������, ������������� �������� ������� - ��� (OutputsDocuments.UserBringID -> _Users.Name)
		/// </summary>
		[Description("������������, ������������� �������� ������� - ��� (OutputsDocuments.UserBringID -> _Users.Name)")]
		public string UserBringName { get { return _UserBringName; } set { _UserBringName = value; } }

		protected bool _IsBrought;
		/// <summary>
		/// �������� ������� ������������ (OutputsDocuments.DateBring is not Null)?
		/// </summary>
		[Description("�������� ������� ������������ (OutputsDocuments.Bring is not Null)?")]
		public bool IsBrought { get { return _IsBrought; } set { _IsBrought = value; } }

		protected bool _DocumentsOK;
		/// <summary>
		/// ��������� � ������� (OutputsDocuments.DocumentsOK)?
		/// </summary>
		[Description("��������� � ������� (OutputsDocuments.DocumentsOK)?")]
		public bool DocumentsOK { get { return _DocumentsOK; } set { _DocumentsOK = value; } }

		protected decimal _DeliveryPrice;
		/// <summary>
		/// ��������� �������� (OutputsDocuments.DeliveryPrice)
		/// </summary>
		[Description("��������� �������� (OutputsDocuments.DeliveryPrice)")]
		public decimal DeliveryPrice { get { return _DeliveryPrice; } set { _DeliveryPrice = value; } }

		protected int? _DeliveryCurrencyID;
		/// <summary>
		/// ������ �������� - ��� (OutputsDocuments.DeliveryCurrencyID)
		/// </summary>
		[Description("������ �������� - ��� (OutputsDocuments.DeliveryCurrencyID)")]
		public int? DeliveryCurrencyID { get { return _DeliveryCurrencyID; } set { _DeliveryCurrencyID = value; } }

		protected string _DeliveryCurrencyName;
		/// <summary>
		/// ������ �������� - ������������ (OutputsDocuments.DeliveryCurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ �������� - ������������ (OutputsDocuments.DeliveryCurrencyID -> Currencies.Name)")]
		public string DeliveryCurrencyName { get { return _DeliveryCurrencyName; } set { _DeliveryCurrencyName = value; } }

		protected decimal _VeterinaryPrice;
		/// <summary>
		/// ��������� ���������� ������������ ������������ (OutputsDocuments.VeterinaryPrice)
		/// </summary>
		[Description("��������� ���������� ������������ ������������ (OutputsDocuments.VeterinaryPrice)")]
		public decimal VeterinaryPrice { get { return _VeterinaryPrice; } set { _VeterinaryPrice = value; } }

		protected int? _VeterinaryCurrencyID;
		/// <summary>
		/// ������ ���������� ������������ ������������ - ��� (OutputsDocuments.VeterinaryCurrencyID)
		/// </summary>
		[Description("������ ���������� ������������ ������������ - ��� (OutputsDocuments.VeterinaryCurrencyID)")]
		public int? VeterinaryCurrencyID { get { return _VeterinaryCurrencyID; } set { _VeterinaryCurrencyID = value; } }

		protected string _VeterinaryCurrencyName;
		/// <summary>
		/// ������ ���������� ������������ ������������ - ������������ (OutputsDocuments.VeterinaryCurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ ���������� ������������ ������������ - ������������ (OutputsDocuments.VeterinaryCurrencyID -> Currencies.Name)")]
		public string VeterinaryCurrencyName { get { return _VeterinaryCurrencyName; } set { _VeterinaryCurrencyName = value; } }
		

		protected int? _OutputID;
		/// <summary>
		/// ������� �� ������ - ��� (OutputsDocuments.OutputID)
		/// </summary>
		[Description("������� �� ������ - ��� (OutputsDocuments.OutputID)")]
		public int? OutputID { get { return _OutputID; } set { _OutputID = value; } }

		protected bool _IsOutputExists;
		/// <summary>
		/// ���� ������� �� ������ (OutputsDocuments.OutputID is not Null)?
		/// </summary>
		[Description("���� ������� �� ������ (OutputsDocuments.OutputID is not Null)?")]
		public bool IsOutputExists { get { return _IsOutputExists; } set { _IsOutputExists = value; } }

		protected DateTime? _OutputDateConfirm;
		/// <summary>
		/// ����-����� ������������� ������� �� ������ (OutputsDocuments.OutputID -> Outputs.DateConfirm)
		/// </summary>
		[Description("����-����� ������������� ������� �� ������ (OutputsDocuments.OutputID -> Outputs.DateConfirm)")]
		public DateTime? OutputDateConfirm { get { return _OutputDateConfirm; } set { _OutputDateConfirm = value; } }

		protected bool _IsOutputConfirmed;
		/// <summary>
		/// ������� �� ������ ������������ (OutputsDocuments.OutputID -> Outputs.DateConfirm is not Null)?
		/// </summary>
		[Description("������� �� ������ ������������ (OutputsDocuments.OutputID -> Outputs.DateConfirm is not Null)?")]
		public bool IsOutputConfirmed { get { return _IsOutputConfirmed; } set { _IsOutputConfirmed = value; } }

		protected bool _NotForJoin;
		/// <summary>
		/// �������� ������ ���������� � ������� ����������� ��� ������������ ������� �� ������ (OutputsDocuments.NotForJoin)?
		/// </summary>
		[Description("�������� ������ ���������� � ������� ����������� ��� ������������ ������� �� ������ (OutputsDocuments.NotForJoin)?")]
		public bool NotForJoin { get { return _NotForJoin; } set { _NotForJoin = value; } }

		protected string _UnionCode;
		/// <summary>
		/// ��� ����������� (������ ��������) (OutputsDocuments.UnionCode)
		/// </summary>
		[Description("��� ����������� (������ ��������) (OutputsDocuments.UnionCode)")]
		public string UnionCode { get { return _UnionCode; } set { _UnionCode = value; } }


		protected bool _IsCarried;
		/// <summary>
		/// ��������� �������� ��������� �� ������ ���� (.dbo.OutputDocumentIsCarried(ID))?
		/// </summary>
		[Description("��������� �������� ��������� �� ������ ���� (.dbo.OutputDocumentIsCarried(ID))?")]
		public bool IsCarried { get { return _IsCarried; } set { _IsCarried = value; } }

		protected bool _IsCopied;
		/// <summary>
		/// ��������� �������� ��������� �� ������ ���� � ���������� (.dbo.OutputDocumentIsCopied(ID))?
		/// </summary>
		[Description("��������� �������� ��������� �� ������ ���� � ���������� (.dbo.OutputDocumentIsCopied(ID))?")]
		public bool IsCopied { get { return _IsCopied; } set { _IsCopied = value; } }

		protected int? _CopiedFromOutputDocumentID;
		/// <summary>
		/// ��������� �������� ��� ������ �� ������� ��������� - ��� (.dbo.OutputDocumentCopiedFrom(ID))?
		/// </summary>
		[Description("��������� �������� ��� ������ �� ������� ��������� - ��� (.dbo.OutputDocumentCopiedFrom(ID))?")]
		public int? CopiedFromOutputDocumentID { get { return _CopiedFromOutputDocumentID; } set { _CopiedFromOutputDocumentID = value; } }


		protected string _PrintMode;
		/// <summary>
		/// ����� ������ ���������� (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.PrintMode)
		///   ����� - ��������� ������� (��������), 
		///   L - ��������� ������
		/// </summary>
		[Description("����� ������ ���������� (OutputsDocuments.PartnerDetailSalerID -> PartnersDetails.PrintMode)")]
		public string PrintMode { get { return _PrintMode; } set { _PrintMode = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (OutputsDocuments.HostID)
		/// </summary>
		[Description("Host - ��� (OutputsDocuments.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (OutputsDocuments.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (OutputsDocuments.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }

		protected bool _IsFree;
		/// <summary>
		/// ��������� �������� ������ ����� (�� �� host)? (OutputsDocuments.ERPCode is Null)
		/// </summary>
		[Description("��������� �������� ������ ����� (�� �� host)? (OutputsDocuments.ERPCode is Null)")]
		public bool IsFree { get { return _IsFree; } set { _IsFree = value; } }


		protected string _ERPCode;
		/// <summary>
		/// ��� ���������� ��������� � host-������� (OutputsDocuments.ERPCode)
		/// </summary>
		[Description("��� ���������� ��������� � host-������� (OutputsDocuments.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �����

		protected bool? _UseByOutputsDocumentSort;
		/// <summary>
		/// ��������� MainTable � ����������� �� ByOrder?
		/// </summary>
		[Description("��������� MainTable � ����������� �� ByOrder?")]
		public bool? UseByOutputsDocumentSort { get { return _UseByOutputsDocumentSort; } set { _UseByOutputsDocumentSort = value; } }

		#endregion �����

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (OutputsDocuments.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (OutputsDocuments.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsFree;
		/// <summary>
		/// ������-����: ��������� ������� ����� (�� �� host) (OutputsDocuments.ERPCode is Null)?
		/// </summary>
		[Description("������-����: ��������� ������� ����� (�� �� host) (OutputsDocuments.ERPCode is Null)?")]
		public bool? FilterIsFree { get { return _FilterIsFree; } set { _FilterIsFree = value; _NeedRequery = true; } }

		
		protected DateTime? _FilterDateOutput;
		/// <summary>
		/// ������-����: ���� ���������� ��������� - ����� (OutputsDocuments.DateOutput)
		/// </summary>
		[Description("������-����: ���� ���������� ��������� - ����� (OutputsDocuments.DateOutput)")]
		public DateTime? FilterDateOutput { get { return _FilterDateOutput; } set { _FilterDateOutput = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ���������� ��������� - ��������� ���� ������� (OutputsDocuments.DateOutput)
		/// </summary>
		[Description("������-����: ���� ���������� ��������� - ��������� ���� ������� (OutputsDocuments.DateOutput)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ���������� ��������� - �������� ���� ������� (OutputsDocuments.DateOutput)
		/// </summary>
		[Description("������-����: ���� ���������� ��������� - �������� ���� ������� (OutputsDocuments.DateOutput)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }
		
		protected string _FilterOutputsDocumentsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� ���������� ���������, ����� ������� (OutputsDocuments.OutputDocumentTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� ���������� ���������, ����� ������� (OutputsDocuments.OutputDocumentTypeID)")]
		public string FilterOutputsDocumentsTypesList { get { return _FilterOutputsDocumentsTypesList; } set { _FilterOutputsDocumentsTypesList = value; _NeedRequery = true; } }


		protected string _FilterPartnersSourceList;
		/// <summary>
		/// ������-����: ������ ����� ���������-�����������, ����� ������� (OutputsDocuments.PartnerDetailSalerID, PartnerDetailShipperID -> PartnersDetails.PartnerID)
		/// </summary>
		[Description("������-����: ������ ����� ���������-�����������, ����� ������� (OutputsDocuments.PartnerDetailSalerID, PartnerDetailShipperID -> PartnersDetails.PartnerID)")]
		public string FilterPartnersSourceList { get { return _FilterPartnersSourceList; } set { _FilterPartnersSourceList = value; _NeedRequery = true; } }

		protected string _FilterPartnersDetailsSalersList;
		/// <summary>
		/// ������-����: ������ ����� ���������� ���������-�����������, ����� ������� (OutputsDocuments.PartnerDetailSalerID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� ���������-�����������, ����� ������� (OutputsDocuments.PartnerDetailSalerID)")]
		public string FilterPartnersDetailsSalersList { get { return _FilterPartnersDetailsSalersList; } set { _FilterPartnersDetailsSalersList = value; _NeedRequery = true; } }

		protected string _FilterPartnersDetailsShippersList;
		/// <summary>
		/// ������-����: ������ ����� ���������� �����������������, ����� ������� (OutputsDocuments.PartnerDetailShipperID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� �����������������, ����� ������� (OutputsDocuments.PartnerDetailShipperID)")]
		public string FilterPartnersDetailsShippersList { get { return _FilterPartnersDetailsShippersList; } set { _FilterPartnersDetailsShippersList = value; _NeedRequery = true; } }

		protected string _FilterPartnersTargetList;
		/// <summary>
		/// ������-����: ������ ����� �����������-������������, ����� ������� (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.PartnerID)
		/// </summary>
		[Description("������-����: ������ ����� �����������-������������, ����� ������� (OutputsDocuments.PartnerDetailBayerID -> PartnersDetails.PartnerID)")]
		public string FilterPartnersTargetList { get { return _FilterPartnersTargetList; } set { _FilterPartnersTargetList = value; _NeedRequery = true; } }

		protected string _FilterPartnersDetailsBayersList;
		/// <summary>
		/// ������-����: ������ ����� ���������� �����������-������������, ����� ������� (OutputsDocuments.PartnerDetailBayerID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� �����������-������������, ����� ������� (OutputsDocuments.PartnerDetailBayerID)")]
		public string FilterPartnersDetailsBayersList { get { return _FilterPartnersDetailsBayersList; } set { _FilterPartnersDetailsBayersList = value; _NeedRequery = true; } }


		protected bool? _FilterDeliveryNeed;
		/// <summary>
		/// ������-����: ��������� ���� �������� (����� ��� ������������ �������) (OutputsDocuments.DeliveryNeed)?
		/// </summary>
		[Description("������-����: ��������� ���� �������� (����� ��� ������������ �������) (OutputsDocuments.DeliveryNeed)?")]
		public bool? FilterDeliveryNeed { get { return _FilterDeliveryNeed; } set { _FilterDeliveryNeed = value; _NeedRequery = true; } }

		protected bool? _FilterTripExists;
		/// <summary>
		/// ������-����: �������� ����������� � ����� (OutputsDocuments.TripID is not Null)?
		/// </summary>
		[Description("������-����: �������� ����������� � ����� (OutputsDocuments.TripID is not Null)?")]
		public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (OutputsDocuments.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (OutputsDocuments.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// ������-����: ������ ����� ����������, ����� ������� (OutputsDocuments.OwnerID)
		/// </summary>
		[Description("������-����: ������ ����� ����������, ����� ������� (OutputsDocuments.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }


		protected bool? _FilterIsPrinted;
		/// <summary>
		/// ������-����: ��������� ����������� (OutputsDocuments.DatePrint is not Null)?
		/// </summary>
		[Description("������-����: ��������� ����������� (OutputsDocuments.DatePrint is not Null)?")]
		public bool? FilterIsPrinted { get { return _FilterIsPrinted; } set { _FilterIsPrinted = value; _NeedRequery = true; } }

		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: �������� �� ������ ������������ (OutputsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: �������� �� ������ ������������ (OutputsDocuments.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected bool? _FilterIsBrought;
		/// <summary>
		/// ������-����: �������� ������� ������������ (OutputsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: �������� ������� ������������ (OutputsDocuments.DateConfirm is not Null)?")]
		public bool? FilterIsBrought { get { return _FilterIsBrought; } set { _FilterIsBrought = value; _NeedRequery = true; } }

        protected bool? _FilterIsBroughtFull;
        /// <summary>
        /// ������-����: ����� ��������� ��������� (OutputsDocumentsGoods.QntConfirmed = OutputsDocumentsGoods.QntBrought)?
        /// </summary>
        [Description("������-����: ����� ��������� ��������� (OutputsDocumentsGoods.QntConfirmed = OutputsDocumentsGoods.QntBrought)?")]
        public bool? FilterIsBroughtFull { get { return _FilterIsBroughtFull; } set { _FilterIsBroughtFull = value; _NeedRequery = true; } }

        protected bool? _FilterSuccess;
		/// <summary>
		/// ������-����: �������� ��������� ������� ������� (.dbo.OutputsDocumentSuccess(ID))?
		/// </summary>
		[Description("������-����: �������� ��������� ������� ������� (.dbo.OutputsDocumentSuccess(ID))?")]
		public bool? FilterSuccess { get { return _FilterSuccess; } set { _FilterSuccess = value; _NeedRequery = true; } }

		protected bool? _FilterIsCarried;
		/// <summary>
		/// ������-����: �������� ��������� �� ������ ���� (OutputsDocuments.IsCarried)?
		/// </summary>
		[Description("������-����: �������� ��������� �� ������ ���� (OutputsDocuments.IsCarried)?")]
		public bool? FilterIsCarried { get { return _FilterIsCarried; } set { _FilterIsCarried = value; _NeedRequery = true; } }


		protected string _FilterBillNumberContext;
		/// <summary>
		/// ������-����: �������� ������ ��������� (OutputsDocuments.BillNumber)
		/// </summary>
		[Description("������-����: �������� ������ ��������� (OutputsDocuments.BillNumber)")]
		public string FilterBillNumberContext { get { return _FilterBillNumberContext; } set { _FilterBillNumberContext = value; _NeedRequery = true; } }

		protected string _FilterDepartmentNameContext;
		/// <summary>
		/// ������-����: �������� �������� ������ (OutputsDocuments.DepartmentName)
		/// </summary>
		[Description("������-����: �������� �������� ������ (OutputsDocuments.DepartmentName)")]
		public string FilterDepartmentNameContext { get { return _FilterDepartmentNameContext; } set { _FilterDepartmentNameContext = value; _NeedRequery = true; } }


		protected bool? _FilterPassengerCarOnly;
		/// <summary>
		/// ������-����: �������� �������� ������� (OutputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?
		/// </summary>
		[Description("������-����: �������� �������� ������� (OutputsDocuments.PartnerTargetID -> Partners.PassengerCarOnly)?")]
		public bool? FilterPassengerCarOnly { get { return _FilterPassengerCarOnly; } set { _FilterPassengerCarOnly = value; _NeedRequery = true; } }

		protected bool? _FilterPosternOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ������ (OutputsDocuments.PartnerTargetID -> Partners.PosternOnly)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ������ (OutputsDocuments.PartnerTargetID -> Partners.Postern)?")]
		public bool? FilterPosternOnly { get { return _FilterPosternOnly; } set { _FilterPosternOnly = value; _NeedRequery = true; } }

		protected bool? _FilterLoadLiftOnly;
		/// <summary>
		/// ������-����: �������� ������� � ������ ����������� (�������) (OutputsDocuments.PartnerTargetID -> Partners.LoadLift)?
		/// </summary>
		[Description("������-����: �������� ������� � ������ ����������� (�������) (OutputsDocuments.PartnerTargetID -> Partners.LoadLift)?")]
		public bool? FilterLoadLiftOnly { get { return _FilterLoadLiftOnly; } set { _FilterLoadLiftOnly = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// ������-����: ���������� ������� - �������, �� ����� (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("������-����: ���������� ������� - �������, �� ����� (OutputsDocuments.PartnerTargetID -> Partners.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		protected string _FilterZonesList;
		/// <summary>
		/// ������-����: ������ ����� ��� ��������-�����������, ����� ������� (OutputsDocuments.PartnerTargetID -> Partners.ZoneID)
		/// </summary>
		[Description("������-����: ������ ����� ��� ��������-�����������, ����� ������� (OutputsDocuments.PartnerTargetID -> Partners.ZoneID)")]
		public string FilterZonesList { get { return _FilterZonesList; } set { _FilterZonesList = value; _NeedRequery = true; } }


		protected bool? _FilterIsOutputExists;
		/// <summary>
		/// ������-����: ���������� ������� �� ������ (OutputsDocuments.OutputID is not Null)?
		/// </summary>
		[Description("������-����: ���������� ������� �� ������ (OutputsDocuments.OutputID is not Null)?")]
		public bool? FilterIsOutputExists { get { return _FilterIsOutputExists; } set { _FilterIsOutputExists = value; _NeedRequery = true; } }

		protected string _FilterOutputsList;
		/// <summary>
		/// ������-����: ������ ����� ������� �� ������, ����� ������� (OutputsDocuments.OutputID)
		/// </summary>
		[Description("������-����: ������ ����� ������� �� ������, ����� ������� (OutputsDocuments.OutputID)")]
		public string FilterOutputsList { get { return _FilterOutputsList; } set { _FilterOutputsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsOutputConfirmed;
		/// <summary>
		/// ������� �� ������ ������������ (OutputsDocuments.OutputID -> Outputs.DateConfirm FilterIs not Null)?
		/// </summary>
		[Description("������� �� ������ ������������ (OutputsDocuments.OutputID -> Outputs.DateConfirm FilterIs not Null)?")]
		public bool? FilterIsOutputConfirmed { get { return _FilterIsOutputConfirmed; } set { _FilterIsOutputConfirmed = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (OutputsDocuments.ID --> OutputsDocumentsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (OutputsDocuments.ID --> OutputsDocumentsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (OutputsDocuments.ID --> OutputsDocumentsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (OutputsDocuments.ID --> OutputsDocumentsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableOutputsDocumentsGoods;
		/// <summary>
		/// ������� ������� � ��������� ��������� OutputsDocumentsGoods
		/// </summary>
		[Description("������� ������� � ��������� ��������� OutputsDocumentsGoods")]
		public DataTable TableOutputsDocumentsGoods { get { return _TableOutputsDocumentsGoods; } }

		protected DataTable _TableOutputsDocumentsTypes;
		/// <summary>
		/// ������� ����� ��������� ���������� OutputsDocumentsTypes
		/// </summary>
		[Description("������� ����� ��������� ���������� OutputsDocumentsTypes")]
		public DataTable TableOutputsDocumentsTypes { get { return _TableOutputsDocumentsTypes; } }

		protected DataTable _TableOutputsDocumentsFailsReasons;
		/// <summary>
		/// ������� ������ ������������ OutputsDocumentsFailsReasons
		/// (��� ��������� �������)
		/// </summary>
		[Description("������� ������ ������������ OutputsDocumentsFailsReasons")]
		public DataTable TableOutputsDocumentsFailsReasons { get { return _TableOutputsDocumentsFailsReasons; } }

		protected DataTable _TableReturnsReasons;
		/// <summary>
		/// ������� ������ �������� ������� ReturnsReasons
		/// (��� ������� � ���������)
		/// </summary>
		[Description("������� ������ �������� ������� ReturnsReasons")]
		public DataTable TableReturnsReasons { get { return _TableReturnsReasons; } }

		protected DataTable _TableDepartmentNames;
		/// <summary>
		/// ������� �������� ������� 
		/// </summary>
		[Description("������� �������� ������� TableDepartmentNames")]
		public DataTable TableDepartmentNames { get { return _TableDepartmentNames; } }

		protected DataTable _TableManagerNames;
		/// <summary>
		/// ������� �������� ���������� 
		/// </summary>
		[Description("������� �������� ���������� TableManagerNames")]
		public DataTable TableManagerNames { get { return _TableManagerNames; } }

		#endregion �������

		// ----------------------------

		public OutputDocument()
			: base()
		{
			_MainTableName = "OutputsDocuments";
			_ColumnID = "ID";
			_ColumnName = "DateOutput";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ��������� ���������� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_OutputsDocumentsFill @nID, @cIDList, " +
									"@cHostsList, " + 
									"@bUseByOutputsDocumentSort, " + 
									"@dDateOutput, " + 
									"@dDateBeg, " +
									"@dDateEnd, " +
									"@cOutputsDocumentsTypesList, " +
									"@bDeliveryNeed, " +
									"@cPartnersSourceList, " +
									"@cPartnersDetailsSalersList, @cPartnersDetailsShippersList, " + 
									"@cPartnersTargetList, " + 
									"@cPartnersDetailsBayersList, " + 
									"@bTripExists, @cTripsList, " +
									"@cOwnersList, " + 
									"@bIsPrinted, " +
									"@bIsConfirmed, " +
                                    "@bIsBrought, " +
                                    "@bIsBroughtFull, " +
                                    "@bSuccess, " + 
									"@bIsCarried, " + 
									"@cBillNumberContext, " + 
									"@cDepartmentNameContext, " +
									"@bPassengerCarOnly, @bPosternOnly, @bLoadLiftOnly, " +
									"@nPermitLevelValueMin, " + 
									"@cZonesList, " + 
									"@bIsOutputExists, @cOutputsList, @bIsOutputConfirmed, " + 
									"@cPackingsList, @cGoodsList, " + 
									"@bIsFree";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@bUseByOutputsDocumentSort", SqlDbType.Bit);
			if (_UseByOutputsDocumentSort.HasValue && (bool)_UseByOutputsDocumentSort)
				_oParameter.Value = _UseByOutputsDocumentSort;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateOutput", SqlDbType.SmallDateTime);
			if (_FilterDateOutput.HasValue)
				_oParameter.Value = _FilterDateOutput;
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

			_oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsTypesList", SqlDbType.VarChar);
			if (_FilterOutputsDocumentsTypesList != null)
				_oParameter.Value = _FilterOutputsDocumentsTypesList;
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

			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsSalersList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsSalersList != null)
				_oParameter.Value = _FilterPartnersDetailsSalersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsShippersList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsShippersList != null)
				_oParameter.Value = _FilterPartnersDetailsShippersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersTargetList", SqlDbType.VarChar);
			if (_FilterPartnersTargetList != null)
				_oParameter.Value = _FilterPartnersTargetList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsBayersList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsBayersList != null)
				_oParameter.Value = _FilterPartnersDetailsBayersList;
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

			_oParameter = _oCommand.Parameters.Add("@bIsPrinted", SqlDbType.Bit);
			if (_FilterIsPrinted != null)
				_oParameter.Value = _FilterIsPrinted;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (_FilterIsConfirmed != null)
				_oParameter.Value = _FilterIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsBrought", SqlDbType.Bit);
			if (_FilterIsBrought != null)
				_oParameter.Value = _FilterIsBrought;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bIsBroughtFull", SqlDbType.Bit);
            if (_FilterIsBroughtFull != null)
                _oParameter.Value = _FilterIsBroughtFull;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bSuccess", SqlDbType.Bit);
			if (_FilterSuccess != null)
				_oParameter.Value = _FilterSuccess;
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

			_oParameter = _oCommand.Parameters.Add("@cDepartmentNameContext", SqlDbType.VarChar);
			if (_FilterDepartmentNameContext != null)
				_oParameter.Value = _FilterDepartmentNameContext;
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

			_oParameter = _oCommand.Parameters.Add("@bIsOutputExists", SqlDbType.Bit);
			if (_FilterIsOutputExists != null)
				_oParameter.Value = _FilterIsOutputExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsList", SqlDbType.VarChar);
			if (_FilterOutputsList != null)
				_oParameter.Value = _FilterOutputsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOutputConfirmed", SqlDbType.Bit);
			if (_FilterIsOutputConfirmed != null)
				_oParameter.Value = _FilterIsOutputConfirmed;
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
				_ErrorStr = "������ ��� ��������� ������ ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillDataByOrder()
		{
			ClearData();

			_UseByOutputsDocumentSort = true;
			bool bResult = FillData();
			_UseByOutputsDocumentSort = null;

			return (bResult);
		}

		/// <summary>
		/// ������� ������-�����
		/// </summary>
		public void ClearFilters()
		{
			_IDList = null;

			_FilterHostsList = null;
			_FilterIsFree = null;

			_FilterDateOutput = null;
			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterOutputsDocumentsTypesList = null;
			_FilterDeliveryNeed = null;

			_FilterIsPrinted = null;
			_FilterIsConfirmed = null;
            _FilterIsBrought = null;
            _FilterIsBroughtFull = null;
            _FilterSuccess = null;
			_FilterIsCarried = null;

			_FilterPassengerCarOnly = null;
			_FilterPosternOnly = null;
			_FilterLoadLiftOnly = null;
			_FilterPermitLevelValueMin = null;
			_FilterZonesList = null;

			_FilterPartnersSourceList = null;
			_FilterPartnersDetailsSalersList = null;
			_FilterPartnersDetailsShippersList = null;
			_FilterPartnersTargetList = null;
			_FilterPartnersDetailsBayersList = null;

			_FilterTripExists = null;
			_FilterTripsList = null;

			_FilterOwnersList = null;

			_FilterBillNumberContext = null;
			_FilterDepartmentNameContext = null;

			_FilterIsOutputExists = null;
			_FilterOutputsList = null;
			_FilterIsOutputConfirmed = null; 
			
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

					_OutputDocumentTypeID = Convert.ToInt32(r["OutputDocumentTypeID"]);
					_OutputDocumentTypeName = r["OutputDocumentTypeName"].ToString();
					_IsRefund = Convert.ToBoolean(r["IsRefund"]);
					_IsReturn = Convert.ToBoolean(r["IsReturn"]);

					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					if (!Convert.IsDBNull(r["GoodStateID"]))
						_GoodStateID = Convert.ToInt32(r["GoodStateID"]);
					_GoodStateName = r["GoodStateName"].ToString();

					_PartnerDetailSalerID = Convert.ToInt32(r["PartnerDetailSalerID"]);
					_PartnerSalerFactName = r["PartnerSalerFactName"].ToString();
					_PartnerSourceID = Convert.ToInt32(r["PartnerSourceID"]);
					_PartnerSourceName = r["PartnerSourceName"].ToString();

					_PartnerDetailShipperID = Convert.ToInt32(r["PartnerDetailShipperID"]);
					_PartnerShipperFactName = r["PartnerShipperFactName"].ToString();
					_PartnerShipperID = Convert.ToInt32(r["PartnerShipperID"]);
					_PartnerShipperName = r["PartnerShipperName"].ToString();

					_PartnerDetailBayerID = Convert.ToInt32(r["PartnerDetailBayerID"]);
					_PartnerBayerFactName = r["PartnerBayerFactName"].ToString();
					_PartnerTargetID = Convert.ToInt32(r["PartnerTargetID"]);
					_PartnerTargetName = r["PartnerTargetName"].ToString();
					
					if (!Convert.IsDBNull(r["ZoneID"]))
						_ZoneID = Convert.ToInt32(r["ZoneID"]);
					_ZoneName = r["ZoneName"].ToString();
					_ZoneAlias = r["ZoneAlias"].ToString();
					_DeliveryAddress = r["DeliveryAddress"].ToString();
					_DeliveryPassage = r["DeliveryPassage"].ToString();

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
					_TimeDelivery = r["TimeDelivery"].ToString();
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
					_Volume = Convert.ToDecimal(r["Volume"]);
					_PalletsQnt = Convert.ToDecimal(r["PalletsQnt"]);

					_Note = r["Note"].ToString();
					_NoteExecute = r["NoteExecute"].ToString();

					if (!Convert.IsDBNull(r["OutputDocumentFailReasonID"]))
					{
						_OutputDocumentFailReasonID = Convert.ToInt32(r["OutputDocumentFailReasonID"]);
						_OutputDocumentFailReasonName = r["OutputDocumentFailReasonName"].ToString();
						if (!Convert.IsDBNull(r["GuiltyID"]))
						{
							_GuiltyID = Convert.ToInt32(r["GuiltyID"]);
							_GuiltyName = r["GuiltyName"].ToString();
						}
						_GuiltyEmployees = r["GuiltyEmployees"].ToString();
                        _IsDriverFoul = Convert.ToBoolean(r["IsDriverFoul"]);
					}

					_PF_BillNeed = Convert.ToBoolean(r["PF_BillNeed"]);
					_PF_FactureNeed = Convert.ToBoolean(r["PF_FactureNeed"]);
					_PF_PayBillNeed = Convert.ToBoolean(r["PF_PayBillNeed"]);
					_PF_WarrantNeed = Convert.ToBoolean(r["PF_WarrantNeed"]);

					_BillNumber = r["BillNumber"].ToString();
					_FactureNumber = r["FactureNumber"].ToString();
					_WarrantNumber = r["WarrantNumber"].ToString();

					_PaymentOrderNeed = Convert.ToBoolean(r["PaymentOrderNeed"]);
					_OtherDocumentsNeed = Convert.ToBoolean(r["OtherDocumentsNeed"]);
					_CertificatesNeed = Convert.ToBoolean(r["CertificatesNeed"]);
					_QualityLicenceNeed = Convert.ToBoolean(r["QualityLicenceNeed"]);
					_VeterinaryLicenceNeed = Convert.ToBoolean(r["VeterinaryLicenceNeed"]);
					_PartnerOrderNumber = r["PartnerOrderNumber"].ToString();

					_GetMoneyWished = Convert.ToDecimal(r["GetMoneyWished"]);
					_GetMoneyConfirmed = Convert.ToDecimal(r["GetMoneyConfirmed"]);
					if (!Convert.IsDBNull(r["GetCurrencyID"]))
					{
						_GetCurrencyID = Convert.ToInt32(r["GetCurrencyID"]);
						_GetCurrencyName = r["GetCurrencyName"].ToString();
					}
					_IsWarrantReturned = Convert.ToBoolean(r["IsWarrantReturned"]);
					_GetPalletsQntWished = Convert.ToInt32(r["GetPalletsQntWished"]);
					_GetPalletsQntConfirmed = Convert.ToInt32(r["GetPalletsQntConfirmed"]);

					_ManagerName = r["ManagerName"].ToString();
					_ManagerPhone = r["ManagerPhone"].ToString();
					_DepartmentName = r["DepartmentName"].ToString();

					_TPL = Convert.ToBoolean(r["TPL"]);

					if (!Convert.IsDBNull(r["ByOrder"]))
						_ByOrder = Convert.ToInt32(r["ByOrder"]);
					
					if (!Convert.IsDBNull(r["DatePrint"]))
						_DatePrint = Convert.ToDateTime(r["DatePrint"]);
					_IsPrinted = Convert.ToBoolean(r["IsPrinted"]);
					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);
					if (!Convert.IsDBNull(r["UserConfirmID"]))
						_UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
					_UserConfirmName = r["UserConfirmName"].ToString();

					if (!Convert.IsDBNull(r["DateBring"]))
						_DateBring = Convert.ToDateTime(r["DateBring"]);
					_IsBrought = Convert.ToBoolean(r["IsBrought"]);
					if (!Convert.IsDBNull(r["UserBringID"]))
						_UserBringID = Convert.ToInt32(r["UserBringID"]);
					_UserBringName = r["UserBringName"].ToString();

					_DocumentsOK = Convert.ToBoolean(r["DocumentsOK"]);

					_DeliveryPrice = Convert.ToDecimal(r["DeliveryPrice"]);
					if (!Convert.IsDBNull(r["DeliveryCurrencyID"]))
					{
						_DeliveryCurrencyID = Convert.ToInt32(r["DeliveryCurrencyID"]);
						_DeliveryCurrencyName = r["DeliveryCurrencyName"].ToString();
					}

					_VeterinaryPrice = Convert.ToDecimal(r["VeterinaryPrice"]);
					if (!Convert.IsDBNull(r["VeterinaryCurrencyID"]))
					{
						_VeterinaryCurrencyID = Convert.ToInt32(r["VeterinaryCurrencyID"]);
						_VeterinaryCurrencyName = r["VeterinaryCurrencyName"].ToString();
					}

					_IsOutputExists = Convert.ToBoolean(r["IsOutputExists"]);
					if (!Convert.IsDBNull(r["OutputID"]))
					{
						_OutputID = Convert.ToInt32(r["OutputID"]);
						if (!Convert.IsDBNull(r["OutputDateConfirm"]))
							_OutputDateConfirm = Convert.ToDateTime(r["OutputDateConfirm"]);
					}
					_IsOutputConfirmed = Convert.ToBoolean(r["IsOutputConfirmed"]);

					_NotForJoin = Convert.ToBoolean(r["NotForJoin"]);
					if (!Convert.IsDBNull(r["UnionCode"]))
						_UnionCode = r["UnionCode"].ToString();

					_IsCarried = Convert.ToBoolean(r["IsCarried"]);
					_IsCopied = Convert.ToBoolean(r["IsCopied"]);
					if (!Convert.IsDBNull(r["CopiedFromOutputDocumentID"]))
						_CopiedFromOutputDocumentID = Convert.ToInt32(r["CopiedFromOutputDocumentID"]);

					if (!Convert.IsDBNull(r["PrintMode"]))
						_PrintMode = r["PrintMode"].ToString();

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

			_DateOutput = DateTime.Now.Date;
			_DeliveryNeed = false;

			_OutputDocumentTypeID = 0;
			_OutputDocumentTypeName = null;
			_IsRefund = false;
			_IsReturn = false;

			_OwnerID = null;
			_OwnerName = null;
			_GoodStateID = null;
			_GoodStateName = null;

			_PartnerDetailSalerID = 0;
			_PartnerSalerFactName = null;
			_PartnerSourceID = 0;
			_PartnerSourceName = null;

			_PartnerDetailShipperID = 0; 
			_PartnerShipperFactName = null;
			_PartnerShipperID = 0; 
			_PartnerShipperName = null;

			_PartnerDetailBayerID = 0;
			_PartnerBayerFactName = null;
			_PartnerTargetID = 0;
			_PartnerTargetName = null;

			_ZoneID = null;
			_ZoneName = null;
			_ZoneAlias = null;
			_DeliveryAddress = null;
			_DeliveryPassage = null; 

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

			_TimeDelivery = null;
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
			_Volume = 0;
			_PalletsQnt = 0;

			_Note = null;
			_NoteExecute = null;

			_OutputDocumentFailReasonID = null;
			_OutputDocumentFailReasonName = null;
			_GuiltyID = null;
			_GuiltyName = null;
			_GuiltyEmployees = null;
            _IsDriverFoul = false;

			_PF_BillNeed = false;
			_PF_FactureNeed = false;
			_PF_PayBillNeed = false;
			_PF_WarrantNeed = false;

			_BillNumber = null;
			_FactureNumber = null;
			_WarrantNumber = null;
			
			_PaymentOrderNeed = false;
			_OtherDocumentsNeed = false;
			_CertificatesNeed = false;
			_QualityLicenceNeed = false;
			_VeterinaryLicenceNeed = false;
			_PartnerOrderNumber = null;

			_GetMoneyWished = 0;
			_GetMoneyConfirmed = 0;
			_GetCurrencyID = null;
			_GetCurrencyName = null;
			_IsWarrantReturned = false;
			_GetPalletsQntWished = 0;
			_GetPalletsQntConfirmed = 0;

			_ManagerName = null;
			_ManagerPhone = null;
			_DepartmentName = null;

			_TPL = false;
			_ByOrder = null;
			
			_DatePrint = null;
			_IsPrinted = false;
			_DateConfirm = null;
			_IsConfirmed = false;
			_UserConfirmID = null;
			_UserConfirmName = null;

			_DateBring = null;
			_IsBrought = false;
			_UserBringID = null;
			_UserBringName = null;

			_DocumentsOK = false;

			_DeliveryPrice = 0;
			_DeliveryCurrencyID = null;
			_DeliveryCurrencyName = null;

			_VeterinaryPrice = 0;
			_VeterinaryCurrencyID = null;
			_VeterinaryCurrencyName = null;

			_IsOutputExists = false;
			_OutputID = null;
			_IsOutputConfirmed = false;
			_OutputDateConfirm = null;

			_NotForJoin = false; 
			_UnionCode = null;
			
			_IsCarried = false;
			_IsCopied = false;
			_CopiedFromOutputDocumentID = null;

			_PrintMode = null;

			_HostID = null;
			_HostName = null;

			_IsFree = false;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Confirm

		/// <summary>
		/// ������������� �������� �� ������
		/// </summary>
		public bool Confirm(int nUserConfirmID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsConfirm @nOutputDocumentID, " +
									"@nUserConfirmID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
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
				if (_TableOutputsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(_TableOutputsDocumentsGoods, "#OutputsDocumentsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������������� �������� �� ������ ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� �������� �� ������ ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������������� �������� ���������� ���������
		/// </summary>
		public bool UnConfirm(int nUserConfirmID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsUnConfirm @nOutputDocumentID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnOutputsDocumentsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� �������� �� ������ ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� �������� �� ������ ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ����������� ������ �� ��������� �� ������ � �������� �������
		/// </summary>
		public bool ConfirmZero(int nUserConfirmID, int nOutputDocumentFailReasonID, string sNoteExecute)
		{
			string _sqlCommand = "execute up_OutputsDocumentsConfirmZero @nOutputDocumentID, " +
									"@nOutputDocumentFailReasonID, " +
									"@cNoteExecute, " + 
									"@nUserConfirmID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsConfirmZero parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nOutputDocumentFailReasonID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentFailReasonID;

			_oParameter = _oCommand.Parameters.Add("@cNoteExecute", SqlDbType.VarChar);
			if (sNoteExecute != null)
				_oParameter.Value = sNoteExecute;
			else 
				sNoteExecute = "";

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� ������� ������ �� ��������� �� ������ � �������� ������ ���������� ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ �� ��������� �� ������ � �������� ������ ���������� ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Bring

		/// <summary>
		/// ������������� �������� �������
		/// </summary>
		public bool Bring(int nUserBringID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsBring @nOutputDocumentID, " +
									"@cNoteExecute, " + 
									"@bDocumentsOK, " + 
									"@nGetMoneyConfirmed, " +
									"@bIsWarrantReturned, " + 
									"@nGetPalletsQntConfirmed, " + 
									"@dDateBegFact, " +
									"@dDateEndFact, " + 
									"@nUserBringID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsBring parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@cNoteExecute", SqlDbType.VarChar);
			_oParameter.Value = _NoteExecute;

			_oParameter = _oCommand.Parameters.Add("@bDocumentsOK", SqlDbType.Bit);
			_oParameter.Value = _DocumentsOK;

			_oParameter = _oCommand.Parameters.Add("@nGetMoneyConfirmed", SqlDbType.Money);
			_oParameter.Value = _GetMoneyConfirmed;

			_oParameter = _oCommand.Parameters.Add("@bIsWarrantReturned", SqlDbType.Money);
			_oParameter.Value = _IsWarrantReturned;

			_oParameter = _oCommand.Parameters.Add("@nGetPalletsQntConfirmed", SqlDbType.Int);
			_oParameter.Value = _GetPalletsQntConfirmed;

			_oParameter = _oCommand.Parameters.Add("@dDateBegFact", SqlDbType.SmallDateTime);
			if (_DateBegFact.HasValue)
				_oParameter.Value = _DateBegFact;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@dDateEndFact", SqlDbType.SmallDateTime);
			if (_DateEndFact.HasValue)
				_oParameter.Value = _DateEndFact;
			else
				_oParameter.Value = DBNull.Value;
 
			_oParameter = _oCommand.Parameters.Add("@nUserBringID", SqlDbType.Int);
			_oParameter.Value = nUserBringID;

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
				if (TableOutputsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableOutputsDocumentsGoods, "#OutputsDocumentsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������������� �������� ������� ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� �������� ������� ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������������� ������ ���������� �������
		/// </summary>
		public bool BringZero(int nUserBringID, int nOutputDocumentFailReasonID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsBringZero @nOutputDocumentID, " +
									"@nOutputDocumentFailReasonID, " +
									"@nUserBringID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsBringZero parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nOutputDocumentFailReasonID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentFailReasonID;

			_oParameter = _oCommand.Parameters.Add("@nUserBringID", SqlDbType.Int);
			_oParameter.Value = nUserBringID;

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
				_ErrorStr = "������ ��� ������� ������������� ������ ���������� ������ ������� �� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� ������ ���������� ������ ������� �� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������������� �������� �������
		/// </summary>
		public bool UnBring(int nUserBringID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsUnBring @nOutputDocumentID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnOutputsDocumentsBring parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� �������� ������� ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� �������� ������� ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Bring

		#region Set/Clear date

		#region DatePrint 

		/// <summary>
		/// ���������/����� ���� ������
		/// bClear: true - �����, false - ���������
		/// nUserID: �� ���.
		/// </summary>
		public bool SetDatePrint(int nOutputDocumentID)
		{ 
			return (SetDatePrint(nOutputDocumentID, false, null));
		}

		public bool SetDatePrint(int nOutputDocumentID, bool bClear, int? nUserID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsSetDatePrint @nOutputDocumentID, " +
									"@bClear, @nUserID, " + 
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsSetDatePrint parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@bClear", SqlDbType.Bit);
			_oParameter.Value = bClear;

			_oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			_oParameter.Value = nUserID;

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
				_ErrorStr = "������ ��� ������� " + ((bClear) ? "������" : "���������") + " ����-������� ������ ��������� ����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� " + ((bClear) ? "������" : "���������") + " ����-������� ������ ��������� ����������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion DatePrint

		#region DateFact

		/// <summary>
		/// ��������� ����-����� ������ � ��������� ���������� � �����
		/// </summary>
		public bool SetDateFact(int nOutputDocumentID, DateTime? dDateBeg, DateTime? dDateEnd)
		{
			string _sqlCommand = "execute up_OutputsDocumentsSetDateFact @nOutputDocumentID, " +
									"@dDateBeg, @dDateEnd, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsSetDateFact parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

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
				_ErrorStr = "������ ��� ������� ������� ������� ���������� � �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������� ������� ���������� � �����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion DateFact

		#endregion Set/Clear date

		#region ToTrip

		/// <summary>
		/// �������� � �����
		/// </summary>
		public bool ToTrip(int nTripID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsToTrip @nOutputDocumentID, " +
									"@nTripID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsToTrip parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

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
				_ErrorStr = "������ ��� ������� �������� ���������� ��������� � �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ���������� ��������� � �����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					TripID = nTripID;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ �������� � �����
		/// </summary>
		public bool UnToTrip()
		{
			string _sqlCommand = "execute up_OutputsDocumentsUnToTrip @nOutputDocumentID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsUnToTrip parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ �������� ���������� ��������� � �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ �������� ���������� ��������� � �����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					TripID = null;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ToTrip

		#region Calc

		/// <summary>
		/// ��������� ��������� ������������� ��� ������ ����������
		/// </summary>
		public bool CalcSum(string sOutputsDocumentsList,
			ref int nOutputsDocumentsQnt, ref int nPartnersQnt, ref int nPointsQnt,
			ref decimal nNetto, ref decimal nBrutto, ref decimal nVolume, ref decimal nPalletsQnt)
		{
			string sqlSelect = "execute up_OutputsDocumentsCalcSum @cOutputsDocumentsList, " +
									"@nOutputsDocumentsQnt output, " +
									"@nPartnersQnt output, " +
									"@nPointsQnt output, " +
									"@nNetto output, " +
									"@nBrutto output, " +
									"@nVolume output, " +
									"@nPalletsQnt output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsCalcSum parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@nOutputsDocumentsQnt", SqlDbType.Int);
			_oParameter.Value = 0;
			_oParameter.Direction = ParameterDirection.InputOutput;

			_oParameter = _oCommand.Parameters.Add("@nPartnersQnt", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ��������� ��������� ������ �� ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (ErrorNumber == 0)
			{
				nOutputsDocumentsQnt = Convert.ToInt32(_oCommand.Parameters["@nOutputsDocumentsQnt"].Value);
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

		public bool SaveByOrder(int nOutputDocumentID, int nByOrder)
		{
			string _sqlCommand = "update OutputsDocuments set ByOrder = " + nByOrder.ToString().Trim() +
				" where ID =" + nOutputDocumentID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "������ ���������� ������� �������� � ������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ByOrder

		#region GoodPriceEdit

		public bool GoodPriceEdit(int nOutputDocumentID, decimal nPrice)
		{
			string _sqlCommand = "update OutputsDocumentsGoods set Price = " + nPrice.ToString().Trim() +
				" where ID =" + nOutputDocumentID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "������ ���������� ���� ������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion GoodPriceEdit

		#region Save, Delete

		#region Save

		/// <summary>
		/// ���������� ������ ���������
		/// </summary>
		public bool Save()
		{
			string _sqlCommand = "execute up_OutputsDocumentsSave @nOutputDocumentID output, " +
					"@nHostID, " +
					"@dDateOutput, " +
					"@nOutputDocumentTypeID, " +
					"@bDeliveryNeed, " +
					"@nGoodStateID, " +
					"@nOwnerID, " +
					"@nPartnerDetailSalerID, " +
					"@nPartnerDetailShipperID, " +
					"@nPartnerDetailBayerID, " +
					"@nCurrencyID, " + 
					"@bBillNeed, " +
					"@cBillNumber, " +
					"@bFactureNeed, " +
					"@cFactureNumber, " +
					"@bPayBillNeed, " +
					"@bWarrantNeed, " +
					"@bTPL, " +
                    "@nDeliveryPrice, " +
                    "@nDeliveryCurrencyID, " +
                    "@nVeterinaryPrice, " +
                    "@nVeterinaryCurrencyID, " + 
					"@bNotForJoin, " +
					"@cNote, " +
					"@nError output, @cErrorText output";

			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_OutputsDocumentSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nHostID", SqlDbType.Int);
			_oParameter.Value = _HostID;


			_oParameter = _oCommand.Parameters.Add("@dDateOutput", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateOutput;

			_oParameter = _oCommand.Parameters.Add("@nOutputDocumentTypeID", SqlDbType.Int);
			_oParameter.Value = _OutputDocumentTypeID;

			_oParameter = _oCommand.Parameters.Add("@bDeliveryNeed", SqlDbType.Bit);
			_oParameter.Value = _DeliveryNeed;

			_oParameter = _oCommand.Parameters.Add("@nGoodStateID", SqlDbType.Int);
			if (_GoodStateID.HasValue)
				_oParameter.Value = _GoodStateID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nOwnerID", SqlDbType.Int);
			if (_OwnerID.HasValue)
				_oParameter.Value = _OwnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nPartnerDetailSalerID", SqlDbType.Int);
			_oParameter.Value = _PartnerDetailSalerID;

			_oParameter = _oCommand.Parameters.Add("@nPartnerDetailShipperID", SqlDbType.Int);
			_oParameter.Value = _PartnerDetailShipperID;

			_oParameter = _oCommand.Parameters.Add("@nPartnerDetailBayerID", SqlDbType.Int);
			_oParameter.Value = _PartnerDetailBayerID;

			_oParameter = _oCommand.Parameters.Add("@nCurrencyID", SqlDbType.Int);
			_oParameter.Value = _CurrencyID;

			_oParameter = _oCommand.Parameters.Add("@bBillNeed", SqlDbType.Bit);
			_oParameter.Value = _PF_BillNeed;

			_oParameter = _oCommand.Parameters.Add("@cBillNumber", SqlDbType.VarChar);
			_oParameter.Value = _BillNumber;


			_oParameter = _oCommand.Parameters.Add("@bFactureNeed", SqlDbType.Bit);
			_oParameter.Value = _PF_FactureNeed;

			_oParameter = _oCommand.Parameters.Add("@cFactureNumber", SqlDbType.VarChar);
			_oParameter.Value = _FactureNumber;


			_oParameter = _oCommand.Parameters.Add("@bPayBillNeed", SqlDbType.Bit);
			_oParameter.Value = _PF_PayBillNeed;


			_oParameter = _oCommand.Parameters.Add("@bWarrantNeed", SqlDbType.Bit);
			_oParameter.Value = _PF_WarrantNeed;

			_oParameter = _oCommand.Parameters.Add("@bTPL", SqlDbType.Bit);
			_oParameter.Value = _TPL;

            _oParameter = _oCommand.Parameters.Add("@nDeliveryPrice", SqlDbType.Money);
            _oParameter.Value = _DeliveryPrice;
            _oParameter = _oCommand.Parameters.Add("@nDeliveryCurrencyID", SqlDbType.Int);
            _oParameter.Value = _DeliveryCurrencyID;

            _oParameter = _oCommand.Parameters.Add("@nVeterinaryPrice", SqlDbType.Money);
            _oParameter.Value = _VeterinaryPrice;
            _oParameter = _oCommand.Parameters.Add("@nVeterinaryCurrencyID", SqlDbType.Int);
            _oParameter.Value = _VeterinaryCurrencyID;

            _oParameter = _oCommand.Parameters.Add("@bNotForJoin", SqlDbType.Bit);
			_oParameter.Value = _NotForJoin;

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
				if (TableOutputsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableOutputsDocumentsGoods, "#OutputsDocumentsGoods", _Connect);
				}

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ���������� ��������� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nOutputDocumentID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nOutputDocumentID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save

		#region Delete

		/// <summary>
		/// �������� ���������� ���������
		/// </summary>
		public bool Delete(int nOutputDocumentID)
		{
			String _sqlCommand = "execute up_OutputsDocumentsDelete @nOutputDocumentID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_OutputsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

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

		#endregion Save, Delete

		#region Carry

		/// <summary>
		/// ����������� (�������) ���������� ��������� �� ������ ���� � �������� ������ ���������� ������� �� ������ 
		/// </summary>
		public bool CarryCopy(int nOutputDocumentID, DateTime dNewDate, int? @nOutputDocumentFailReasonID, 
			int? nUserCarryID, ref int? nNewOutputDocumentID, bool bJoin)
		{
			string _sqlCommand = "execute up_OutputsDocumentsCarryCopy @nOutputDocumentID, " + 
					"@dNewDate, " +
					"@nOutputDocumentFailReasonID, " + 
					"@nUserCarryID, " +
					"@nNewOutputDocumentID output, " +
					"@bJoin, " + 
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsCarryCopy parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

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

			_oParameter = _oCommand.Parameters.Add("@nNewOutputDocumentID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bJoin", SqlDbType.Bit);
			_oParameter.Value = bJoin;

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
				_ErrorStr = "������ ��� ������� ����������� (��������) ���������� ��������� �� ������ ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����������� (��������) ���������� ��������� �� ������ ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (!Convert.IsDBNull(_oCommand.Parameters["@nNewOutputDocumentID"].Value))
						nNewOutputDocumentID = (int)_oCommand.Parameters["@nNewOutputDocumentID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ����������� ���������� ��������� � ����� ���������� �������
		/// (�������� ���������� ���������, ����������� ���������� � �������� ��������,
		/// ���� � ������� ���� ��������� �������� - �������� ���������� �������, ����� - ���������� �������)
		/// </summary>
		public bool CarryCopyUnDo(int nOutputDocumentID, int nTripID,
			int? nUserUnCarryCopyID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsCarryCopyUnDo @nOutputDocumentID, " +
					"@nTripID, " +
					"@nUserUnCarryCopyID, " +
					"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsCarryCopyUnDo parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

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
				_ErrorStr = "������ ��� ������� ������ ����������� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ����������� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}


		/// <summary>
		/// ����� ���� ���������� ��������� �� ������ ����
		/// </summary>
		public bool ChangeDate(int nOutputDocumentID, DateTime dNewDate)
		{
			string _sqlCommand = "execute up_OutputsDocumentsChangeDate @nOutputDocumentID, " +
					"@dNewDate, " +
					"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsChangeDate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

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


		#region OutputsCreateFromOutputsDocuments

		/// <summary>
		/// �������� ������� �� ������ �� ������ ���������� ���������
		/// ������ ������� ������� ��� ���������� ���������, �� ���������
		/// </summary>
		public bool OutputsCreateFromOutputsDocuments(int nOutputDocumentID, ref int? nOutputID)
		{
			string _sqlCommand = "execute up_OutputsCreateFromOutputsDocuments @nOutputDocumentID, @nOutputID output, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsCreateFromOutputsDocuments parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� �������� ������� �� ������ �� ������ ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������� �� ������ �� ������ ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (!Convert.IsDBNull(_oCommand.Parameters["@nOutputID"].Value))
						nOutputID = (int)_oCommand.Parameters["@nOutputID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ������� �� ������ �� ������ ���������� ���������
		/// ���� ���� ���������� ������� - ��������� �������� ���������� ����
		/// </summary>
		public bool OutputsCreateJoinFromOutputsDocuments(int nOutputDocumentID, ref int? nOutputID, ref bool bIsOutputJoined)
		{
			string _sqlCommand = "execute up_OutputsCreateJoinFromOutputsDocuments @nOutputDocumentID, " + 
									"@nOutputID output, @bIsOutputJoined output, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsCreateJoinFromOutputsDocuments parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOutputJoined", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� �������� ������� �� ������ ��� ���������� ��������� (� ������������)...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������� �� ������ ��� ���������� ��������� (� ������������)...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					if (!Convert.IsDBNull(_oCommand.Parameters["@nOutputID"].Value))
						nOutputID = (int)_oCommand.Parameters["@nOutputID"].Value;
					if (!Convert.IsDBNull(_oCommand.Parameters["@bIsOutputJoined"].Value))
						bIsOutputJoined = (bool)_oCommand.Parameters["@bIsOutputJoined"].Value;
					else
						bIsOutputJoined = false; 
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsCreateFromOutputsDocuments


		#region ChangeOutputDocumentFailReason

		/// <summary>
		/// ��������� ������� ���������� ������ �������
		/// </summary>
		public bool ChangeOutputDocumentFailReason(int nOutputDocumentID, int nOutputDocumentFailReasonID)
		{
			string _sqlCommand = "update OutputsDocuments set OutputDocumentFailReasonID = " + nOutputDocumentFailReasonID.ToString().Trim() +
				" where ID = " + nOutputDocumentID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -61;
				_ErrorStr = "������ ��������� ������� ���������� ������ ����������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ChangeOutputDocumentFailReason

		#region ChangeOutputDocumentGoodReturnReason

		/// <summary>
		/// ��������� ������� �������� (����������) ������ � ������ 
		/// </summary>
		public bool ChangeOutputDocumentGoodReturnReason(int nOutputDocumentGoodID, int nOutputDocumentGoodReturnReasonID)
		{
			string _sqlCommand = "update OutputsDocumentsGoods set ReturnReasonID = " + nOutputDocumentGoodReturnReasonID.ToString().Trim() +
				" where ID =" + nOutputDocumentGoodID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -62;
				_ErrorStr = "������ ��������� ������� �������� (����������) ������ � ������ ...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ChangeOutputDocumentGoodReturnReason

		#region ChangeOutputDocumentCarry FailReason, GuiltyEmployees

		/// <summary>
		/// ��������� ������� ���������� ������ ������� - ��� ��������/�����
		/// </summary>
		public bool ChangeOutputDocumentCarryFailReasonGuiltyEmployees(int nCarryID, int? nOutputDocumentFailReasonID, string sGuiltyEmployees, bool bIsDriverFoul)
		{
			string _sqlCommand = "update OutputsDocumentsCarries set ";
			if (nOutputDocumentFailReasonID.HasValue)
				_sqlCommand += " OutputDocumentFailReasonID = " + nOutputDocumentFailReasonID.ToString().Trim() + ", ";
			_sqlCommand += " GuiltyEmployees = '" + (sGuiltyEmployees == null ? " " : sGuiltyEmployees) + "', ";
            _sqlCommand += " IsDriverFoul = " + (bIsDriverFoul ? "1" : "0");
			_sqlCommand += " where ID = " + nCarryID.ToString().Trim();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -61;
				_ErrorStr = "������ ��������� ��������� / ������� ������� � ��������� ������ ����������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion ChangeOutputDocumentCarry FailReason, GuiltyEmployees


		#region �������

		#region OutputsDocumentsGoods

		/// <summary>
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods)
		/// </summary>
		public bool FillTableOutputsDocumentsGoods(int nOutputDocumentID)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFill @nOutputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableOutputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsGoods, "TableOutputsDocumentsGoods");
				_TableOutputsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableOutputsDocumentsGoods.Columns[0] };
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

		public bool FillTableOutputsDocumentsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableOutputsDocumentsGoods((int)_ID);
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
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods) - � ������� ��� ������ ����������
		/// </summary>
		public bool FillBillTableOutputsDocumentsGoods(int nOutputDocumentID)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFillBill @nOutputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFillBill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableOutputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsGoods, "TableOutputsDocumentsGoods");
				_TableOutputsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableOutputsDocumentsGoods.Columns[0] };
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

		public bool FillBillTableOutputsDocumentsGoods()
		{
			if (_ID.HasValue)
			{
				FillBillTableOutputsDocumentsGoods((int)_ID);
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
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods) - � ������� � ������������� ��������������
		/// </summary>
		public bool FillVeterinaryTableOutputsDocumentsGoods(string sOutputsDocumentsList, bool bGroupByPartner)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFillVeterinary @cOutputsDocumentsList, @bGroupByPartner, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFillVeterinary parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@bGroupByPartner", SqlDbType.Bit);
			_oParameter.Value = bGroupByPartner ;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			#endregion

			try
			{
				_TableOutputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsGoods, "TableOutputsDocumentsGoods");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (������������ �������������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (������������ �������������)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods) - � ������� � ������������� ��������������
		/// </summary>
		public bool FillVeterinaryAddTableOutputsDocumentsGoods(string sOutputsDocumentsList, bool bGroupByPartner)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFillVeterinaryAdd @cOutputsDocumentsList, @bGroupByPartner, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFillVeterinary parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@bGroupByPartner", SqlDbType.Bit);
			_oParameter.Value = bGroupByPartner;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			#endregion

			try
			{
				_TableOutputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsGoods, "TableOutputsDocumentsGoods");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (���������� � ������������ ��������������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (���������� � ������������ ��������������)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods) - � ������� � ������������� �������������� 
		/// ��� �������������� ������� ���.��-�
		/// </summary>
		public bool FillVeterinaryBlankTableOutputsDocumentsGoods(string sOutputsDocumentsList, bool bGroupByPartner)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFillVeterinaryBlank @cOutputsDocumentsList, @bGroupByPartner, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFillVeterinaryBlank parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@bGroupByPartner", SqlDbType.Bit);
			_oParameter.Value = bGroupByPartner;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			
			#endregion

			try
			{
				_TableOutputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsGoods, "TableOutputsDocumentsGoods");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (������ ������������ ������������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (������ ������������ ������������)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
        /// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods) - � ������� � ����������� ������������
		/// </summary>
		public bool FillQualityTableOutputsDocumentsGoods(int @nOutputDocumentID)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFillQuality @nOutputDocumentID, /*@cOutputsDocumentsList, */ " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFillQuality parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;
			/*
			_oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;
			*/

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableOutputsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsGoods, "TableOutputsDocumentsGoods");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
                _ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (���������� ������������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
                    _ErrorStr = "������ ��� ��������� ������ ������� � ��������� ��������� (���������� ������������)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� � ������� ��� ������������ ��� ��������� ��������� (TableWarrant)
		/// ���������� � ������� _DS.Tables["TableWarrant"]
		/// � ������� ��� ��������� 1 ������, ���� ����� ������������, 0 - ���� �� ����� 
		/// </summary>
		public bool FillWarrantTableOutputsDocuments(string sOutputsDocumentsList)
		{
			string sqlSelect = "execute up_OutputsDocumentsFillWarrant @cOutputsDocumentsList, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsFillWarrant parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableWarrantOutputsDocuments");
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

		/// <summary>
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoodsGRoupsList) - � ������� � ������� � ������� -
		/// ��� ������ ������������� ��������
		/// </summary>
		public bool FillGoodsGroupsListTable(int @nOutputDocumentID)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsFillGoodsGroupsList @nOutputDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsFillGoodsGroupsList parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableGoodsGroupsList");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ����� ������� � ��������� ��������� (����������� ��������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ����� ������� � ��������� ��������� (������������� ��������)...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#region Transport

		/// <summary>
		/// ��������� ������� � ������� � ������������ �������, ���������� � ����� (TableTransport)
		/// ���������� � ������� _DS.Tables["TableTransport"]
		/// � ������� ��� ��������� 1 ������
		/// </summary>
		public bool FillTransportTableOutputsDocuments(int nOutputDocumentID, decimal nVat)
		{
			string sqlSelect = "execute up_OutputsDocumentsFillTransport @nOutputDocumentID, @nVat, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsFillTransport parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nVat", SqlDbType.Decimal);
			_oParameter.Value = nVat;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";
			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableTransport");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ � ������������ �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ � ������������ �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Transport

		#endregion OutputsDocumentsGoods

		#region Carries

		/// <summary>
		/// ��������� ������ ��������� � ����� ��� ���������� ��������� (TableOutputsDocumentsCarries)
		/// </summary>
		public bool FillTableOutputsDocumentsCarries(int nOutputDocumentID)
		{
			string sqlSelect = "execute up_OutputsDocumentsCarriesFill " +
									"@nOutputDocumentID = " + nOutputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsDocumentsCarries");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� ��������� ������ ��������� � ����� ��� ���������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������ � ��������/����� ��� ���������� ��������� �� ID ������ (TableOutputsDocumentsCarries)
		/// </summary>
		public bool FillTableOutputsDocumentsCarries(int? nOutputDocumentID, int nCarryID)
		{
			string sqlSelect = "execute up_OutputsDocumentsCarriesFill ";
			if (nOutputDocumentID.HasValue)
				sqlSelect += "@nOutputDocumentID = " + nOutputDocumentID.ToString() + ", ";
			sqlSelect += "@nCarryID = " + nCarryID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsDocumentsCarries");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� ��������� ������ � ��������/����� ��� ���������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Carries

		#region TTN

		/// <summary>
		/// ��������� ������� ������� � ��������� ��������� (TableOutputsDocumentsGoods) - � ������� ��� ������ ����������
		/// </summary>
		public bool FillTTNTableOutputsDocuments(string sOutputsDocumentsList)
		{
			if (sOutputsDocumentsList == null || sOutputsDocumentsList.Length == 0)
				return (false);

			string sqlSelect = "execute up_OutputsDocumentsFillTTN @cOutputsDocumentsList, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsFillTTN parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sOutputsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableOutputsDocumentsTTN");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ��������� ���������� ��� ���..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ��������� ���������� ��� ���...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion TTN 

		#region OutputsDocumentsTypes

		/// <summary>
		/// ��������� ������� ����� ��������� ���������� (TableOutputsDocumentsTypes)
		/// </summary>
		public bool FillTableOutputsDocumentsTypes()
		{
			string sqlSelect = "select ID, Name, "  +
						"DeliveryNeed, " + 
						"ERPCode " +
					"from OutputsDocumentsTypes with (nolock) " +
					"where 1 = 1 ";
			if (_FilterOutputsDocumentsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterOutputsDocumentsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableOutputsDocumentsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsTypes, "TableOutputsDocumentsTypes");
				_TableOutputsDocumentsTypes.PrimaryKey = new DataColumn[] { _TableOutputsDocumentsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "������ ��� ��������� ������ ����� ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsDocumentsTypes

		#region OutputsDocumentsFailsReasons

		/// <summary>
		/// ��������� ������� ������ ������������ (����������) (TableOutputsDocumentsFailsReasons)
		/// (��� ��������� �������)
		/// </summary>
		public bool FillTableOutputsDocumentsFailsReasons()
		{
			string sqlSelect =
				"select OFR.ID, OFR.Name, " +
						"OFR.GuiltyID, Gu.Name as GuiltyName, " +
						"OFR.ERPCode " +
					"from OutputsDocumentsFailsReasons OFR with (nolock) " +
					"left join Guilties Gu with (nolock) on OFR.GuiltyID = Gu.ID " + 
					"where 1 = 1 ";
			//if (_FilterOutputsDocumentsFailsReasonsList != null)
			//{
			//	sqlSelect += " and charindex(',' + ltrim(str(OFR.ID)) + ',', ',' + '" + FilterOutputsDocumentsFailsReasonsList + "' + ',') > 0";
			//}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_TableOutputsDocumentsFailsReasons = FillReadings(new SqlDataAdapter(_oCommand), _TableOutputsDocumentsFailsReasons, "TableOutputsDocumentsFailsReasons");
				_TableOutputsDocumentsFailsReasons.PrimaryKey = new DataColumn[] { _TableOutputsDocumentsFailsReasons.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -31;
				_ErrorStr = "������ ��� ��������� ������ ������ ������������ (����������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion OutputsDocumentsFailsReasons

		#region ReturnsReasons

		/// <summary>
		/// ��������� ������� ������ ������� ������ (TableReturnsReasons)
		/// (��� ������ � ���������)
		/// </summary>
		public bool FillTableReturnsReasons()
		{
			string sqlSelect = "select RR.ID, RR.Name, " +
						"RR.GuiltyID, Gu.Name as GuiltyName, " +
						"RR.ERPCode " +
					"from ReturnsReasons RR " +
					"left join Guilties Gu on RR.GuiltyID = Gu.ID " + 
					"where 1 = 1 ";
			//if (_FilterReturnsReasonsList != null)
			//{
			//	sqlSelect += " and charindex(',' + ltrim(str(RR.ID)) + ',', ',' + '" + FilterReturnsReasonsList + "' + ',') > 0";
			//}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableReturnsReasons = FillReadings(new SqlDataAdapter(_oCommand), _TableReturnsReasons, "TableReturnsReasons");
				_TableReturnsReasons.PrimaryKey = new DataColumn[] { _TableReturnsReasons.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -41;
				_ErrorStr = "������ ��� ��������� ������ ������ ������� ������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion ReturnsReasons

		#region DepartmentNames

		/// <summary>
		/// ��������� ������� �������� ������� (TableDepartmentNames)
		/// </summary>
		public bool FillTableDepartmentNames(DateTime? dDateBeg, DateTime? dDateEnd)
		{
			string sqlSelect = "select distinct DepartmentName from OutputsDocuments " +
					"where len(DepartmentName) > 0  ";
			if (dDateBeg.HasValue)
			{
				sqlSelect += " and datediff(day, DateOutput, '" + ((DateTime)dDateBeg).ToString("yyyyMMdd") + "') <= 0 ";
			}
			if (dDateEnd.HasValue)
			{
				sqlSelect += " and datediff(day, DateOutput, '" + ((DateTime)dDateEnd).ToString("yyyyMMdd") + "') >= 0 ";
			}
 			sqlSelect += " order by 1";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableDepartmentNames = FillReadings(new SqlDataAdapter(_oCommand), _TableDepartmentNames, "TableDepartmentNames");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -51;
				_ErrorStr = "������ ��� ��������� ������ �������� ������� � ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion DepartmentNames

		#region ManagerNames

		/// <summary>
		/// ��������� ������� ��� ���������� (TableManagerNames)
		/// </summary>
		public bool FillTableManagerNames(DateTime? dDateBeg, DateTime? dDateEnd)
		{
			string sqlSelect = "select distinct ManagerName from OutputsDocuments " +
					"where len(ManagerName) > 0  ";
			if (dDateBeg.HasValue)
			{
				sqlSelect += " and datediff(day, DateOutput, '" + ((DateTime)dDateBeg).ToString("yyyyMMdd") + "') <= 0 ";
			}
			if (dDateEnd.HasValue)
			{
				sqlSelect += " and datediff(day, DateOutput, '" + ((DateTime)dDateEnd).ToString("yyyyMMdd") + "') >= 0 ";
			}
			sqlSelect += " order by 1";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableManagerNames = FillReadings(new SqlDataAdapter(_oCommand), _TableManagerNames, "TableManagerNames");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -52;
				_ErrorStr = "������ ��� ��������� ������ ���������� � ��������� ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion ManagerNames

		#endregion �������

        #region Additional ID - ���������� ������ (���������� ������������, ���.��-��, ...)

        /// <summary>
		/// ���������� ������ �� GoodsQualities
		/// </summary>
		public bool SetGoodQualityID(int nOutputDocumentID, bool bUpdate)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsSetQuality @nOutputDocumentID, " +
									"@bUpdate, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsSetQuality parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@bUpdate", SqlDbType.Bit);
			_oParameter.Value = bUpdate;

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
                _ErrorStr = "������ ��� ������� ��������� �������� ���������� ������������ ��� ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
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
                    _ErrorStr = "������ ��� ��������� �������� ���������� ������������ ��� ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ���������� ������ �� GoodsVeterinaries
		/// </summary>
		public bool SetGoodVeterinaryID(int nOutputDocumentID, bool bUpdate)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsSetVeterinary @nOutputDocumentID, " +
									"@bUpdate, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsSetVeterinary parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@bUpdate", SqlDbType.Bit);
			_oParameter.Value = bUpdate;

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
				_ErrorStr = "������ ��� ������� ��������� �������� ������������ ������������ ��� ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
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
					_ErrorStr = "������ ��� ��������� �������� ������������ ������������ ��� ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ���������� ������ �� GoodsCustomsNumbers
		/// </summary>
		public bool SetGoodCustomNumber(int nOutputDocumentID, bool bUpdate)
		{
			string sqlSelect = "execute up_OutputsDocumentsGoodsSetCustomNumber @nOutputDocumentID, " +
									"@bUpdate, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsGoodsSetCustomNumber parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@bUpdate", SqlDbType.Bit);
			_oParameter.Value = bUpdate;

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
				_ErrorStr = "������ ��� ������� ��������� ������� ��� ��� ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
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
					_ErrorStr = "������ ��� ��������� ������� ��� ��� ������� � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������ �� GoodsQualities
		/// </summary>
		public bool ClearGoodQualityID(int nOutputDocumentID)
		{
			string sqlSelect = "update OutputsDocumentsGoods set GoodQualityID = Null " +
									"where OutputDocumentID = " + nOutputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
                _ErrorStr = "������ ��� ������� �������� ���������� ������������ � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������ �� GoodsVeterinaries
		/// </summary>
		public bool ClearGoodVeterinaryID(int nOutputDocumentID)
		{
			string sqlSelect = "update OutputsDocumentsGoods set GoodVeterinaryID = Null " +
									"where OutputDocumentID = " + nOutputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� �������� ������������ ������������ � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������� ��� CustomNumber
		/// </summary>
		public bool ClearGoodCustomNumber(int nOutputDocumentID)
		{
			string sqlSelect = "update OutputsDocumentsGoods set CustomNumber = '' " +
									"where OutputDocumentID = " + nOutputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������� ��� ��� ������� � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ���������� ����� � ������ ������ ���.��-��
		/// </summary>
		public bool SaveVeterinaryBlankData(int nOutputDocumentID,
            string sVeterinaryBlankSeries, string sVeterinaryBlankNumber, string sVeterinaryBlankType, int nVeterinaryUserID)
		{
			string sqlSelect = "execute up_OutputsDocumentsVeterinaryBlankDataSave @nOutputDocumentID, " +
									"@cVeterinaryBlankSeries, @cVeterinaryBlankNumber, " +
                                    "@cVeterinaryBlankType, @nVeterinaryUserID, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_OutputsDocumentsVeterinaryBlankDataSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = nOutputDocumentID;

			_oParameter = _oCommand.Parameters.Add("@cVeterinaryBlankSeries", SqlDbType.VarChar);
			if (sVeterinaryBlankSeries != null)
				_oParameter.Value = sVeterinaryBlankSeries;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cVeterinaryBlankNumber", SqlDbType.VarChar);
			if (sVeterinaryBlankNumber != null)
				_oParameter.Value = sVeterinaryBlankNumber;
			else
				_oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cVeterinaryBlankType", SqlDbType.VarChar);
            if (sVeterinaryBlankType != null)
                _oParameter.Value = sVeterinaryBlankType;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nVeterinaryUserID", SqlDbType.Int);
            _oParameter.Value = nVeterinaryUserID;

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
				_ErrorStr = "������ ��� ������� ���������� �����/������ ������ ������������ ������������ � ��������� ���������..." + Convert.ToChar(13) + ex.Message;
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
					_ErrorStr = "������ ��� ���������� �����/������ ������ ������������ � ��������� ���������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ����� ������ ���.��-��
		/// </summary>
		public string GetVeterinaryBlankSeries()
		{
			string sVeterinaryBlankSeries = ""; 

			string sqlSelect = "select top 1 [Value] " +
                    "from _Settings with (nolock) " +
                    "where Variable = 'VeterinaryRegion'";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_Connect.Open();
				DataTable tableVeterinaryBlankTemp = FillReadings(new SqlDataAdapter(_oCommand), null, "tableVeterinaryBlankTemp");
				if (tableVeterinaryBlankTemp != null && 
					tableVeterinaryBlankTemp.Rows.Count > 0)
				{
					sVeterinaryBlankSeries = tableVeterinaryBlankTemp.Rows[0][0].ToString();
				}
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������� ����� ������ ������������ ������������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (sVeterinaryBlankSeries);
		}

		/// <summary>
		/// ���������/������ �������� VeterinaryLicenceNeed
		/// </summary>
		public bool VeterinaryLicenceNeedSet(int nOutputDocumentID, bool bSet)
		{
			string sqlSelect = "update OutputsDocuments set VeterinaryLicenceNeed = " +
				((bSet) ? "1" : "0") +
				" where ID = " + nOutputDocumentID.ToString();
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -15;
				_ErrorStr = "������ ��� ������� ��������� �������� \"��������� ������������ �������������\" ��� ���������� ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Additional ID 

		#region Documents

		#region Warrant

		/// <summary>
		/// ���������� ������ ������������ � ������ � ������
		/// </summary>
		public bool WarrantSet(int nOutputDocumentID, string cNumber)
		{
			string _sqlCommand = "execute up_OutputsDocumentsWarrantCreate @nOutputDocumentID, " +
									"@cNumber output, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsWarrantCreate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@cNumber", SqlDbType.VarChar, 20);
			_oParameter.Direction = ParameterDirection.InputOutput;
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
				else
				{
					_WarrantNumber = _oCommand.Parameters["@cNumber"].Value.ToString();
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������ ������������ � �������� ������ �� �������
		/// </summary>
		public bool WarrantClear(int nOutputDocumentID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsWarrantClear @nOutputDocumentID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsWarrantClear parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
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

		#region Facture

		/// <summary>
		/// ���������� ������ �����-������� � ������ � ������
		/// </summary>
		public bool FactureSet(int nOutputDocumentID, string cNumber)
		{
			string _sqlCommand = "execute up_OutputsDocumentsFactureCreate @nOutputDocumentID, " +
									"@cNumber output, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsFactureNumber parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@cNumber", SqlDbType.VarChar, 20);
			_oParameter.Direction = ParameterDirection.InputOutput;
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
				_ErrorStr = "������ ��� ������� ����������� �����-������� ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ����������� �����-������� ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else
				{
					_FactureNumber = _oCommand.Parameters["@cNumber"].Value.ToString();
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������ �����-������� � �������� ������ �� �������
		/// </summary>
		public bool FactureClear(int nOutputDocumentID)
		{
			string _sqlCommand = "execute up_OutputsDocumentsFactureClear @nOutputDocumentID, " +
									"@nError output, @cErrorStr output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_OutputsDocumentsFactureNumber parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������� �����-������� ��� ���������� ���������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������� �����-������� ��� ���������� ���������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Facture

		#endregion Documents

		#region GuiltyEmployees

		public bool SetGuiltyEmployees(int? nOutputDocumentID, int? nOutputDocumentGoodID, string sGuiltyEmployeesText, bool bIsDriverFoul)
		{
			if (sGuiltyEmployeesText == null)
				sGuiltyEmployeesText = "";

			string _sqlCommand = "";
			if (nOutputDocumentID.HasValue)
			{
				_sqlCommand = "update OutputsDocuments set " + 
                    " GuiltyEmployees = '" + sGuiltyEmployeesText + "', " + 
                    " IsDriverFoul = " + (bIsDriverFoul ? "1" : "0") + 
				    " where ID =" + nOutputDocumentID.ToString().Trim();
			}
			if (nOutputDocumentGoodID.HasValue)
			{
				_sqlCommand += "update OutputsDocumentsGoods set GuiltyEmployees = '" + sGuiltyEmployeesText + "' " +
				 " where ID =" + nOutputDocumentGoodID.ToString().Trim();
			}

			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -71;
				_ErrorStr = "������ ���������� ������ � ���������� ������� � ��������� ���������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion GuiltyEmployees 


	}

#endregion OutputDocument

}
