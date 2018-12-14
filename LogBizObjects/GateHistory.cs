using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ����������� ����� (�����-�����)(GateHistory)
/// </summary>
/// 
namespace LogBizObjects
{
	
#region GateHistory

	public class GateHistory: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ����������� ����� (GatesHistory.ID)
		/// </summary>
		[Description("������ ����� ID ����������� ����� (GatesHistory.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateCross;
		/// <summary>
		/// ���� ����������� ����� (GatesHistory.DateCross)
		/// </summary>
		[Description("���� ����������� ����� (GatesHistory.DateCross)")]
		public DateTime DateCross { get { return _DateCross; } set { _DateCross = value; } }

		protected bool _IsDeparture;
		/// <summary>
		/// ����� (GatesHistory.IsDeparture)?
		/// </summary>
		[Description("����� (GatesHistory.IsDeparture)?")]
		public bool IsDeparture { get { return _IsDeparture; } set { _IsDeparture = value; } }

		protected string _TypeCross;
		/// <summary>
		/// ����������� �����������: �����/����� (GatesHistory.IsDeparture -> �����/�����)
		/// </summary>
		[Description("����������� �����������: �����/����� (GatesHistory.IsDeparture -> �����/�����)")]
		public string TypeCross { get { return _TypeCross; } set { _TypeCross = value; } }

		protected int? _CarID;
		/// <summary>
		/// ������ ����������� - ��� (GatesHistory.CarID)
		/// </summary>
		[Description("������ ����������� - ��� (GatesHistory.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// ������ - ������������ (GatesHistory.CarName)
		/// </summary>
		[Description("������ - ������������ (GatesHistory.CarName)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// ���.����� ������* (GatesHistory.CarNumber)
		/// </summary>
		[Description("���.����� ������* (GatesHistory.CarNumber)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected string _TrailerNumber;
		/// <summary>
		/// ���.����� �������* (GatesHistory.TrailerNumber)
		/// </summary>
		[Description("���.����� �������* (GatesHistory.TrailerNumber)")]
		public string TrailerNumber { get { return _TrailerNumber; } set { _TrailerNumber = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// ��� ������ - ��� (GatesHistory.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("��� ������ - ��� (GatesHistory.CarID -> Cars.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// ��� ������ - ������������ (GatesHistory.CarTypeName)
		/// </summary>
		[Description("��� ������ - ������������ (GatesHistory.CarTypeName)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// ���������-�������� - ��� (GatesHistory.DriverEmployeeID)
		/// </summary>
		[Description("���������-�������� - ��� (GatesHistory.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// �������� - ���* (GatesHistory.DriverName)
		/// </summary>
		[Description("�������� - ���* (GatesHistory.DriverName)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected int? _CarWeight;
		/// <summary>
		/// ��� ������ ��� ����������� �����, �� (GatesHistory.CarWeight)
		/// </summary>
		[Description("��� ������ ��� ����������� �����, �� (GatesHistory.CarWeight)")]
		public int? CarWeight { get { return _CarWeight; } set { _CarWeight = value; } }

		protected bool _IsOtherCar;
		/// <summary>
		/// �� ���� ������ (���������� ��� ������������) (GatesHistory.CarID is Null)?
		/// </summary>
		[Description("�� ���� ������ (���������� ��� ������������) (GatesHistory.CarID is Null)?")]
		public bool IsOtherCar { get { return _IsOtherCar; } set { _IsOtherCar = value; } }


		protected int? _TransportPermissionID;
		/// <summary>
		/// ���������� �� ����������� ����� - ��� (GateHistory.TransportPermissionID -> TransportPermissions.ID)
		/// </summary>
		[Description("���������� �� ����������� ����� - ��� (GateHistory.TransportPermissionID -> TransportPermissions.ID)")]
		public int? TransportPermissionID { get { return _TransportPermissionID; } set { _TransportPermissionID = value; } }

		protected int? _WayBillID;
		/// <summary>
		/// ������� ���� - ��� (��� ����������� �����) (GatesHistory.WayBillID)
		/// </summary>
		[Description("������� ���� - ��� (��� ����������� �����) (GatesHistory.WayBillID)")]
		public int? WayBillID { get { return _WayBillID; } set { _WayBillID = value; } }

		protected int? _PassID;
		/// <summary>
		/// ������� - ��� (��� ������ �����) (GatesHistory.PassID)
		/// </summary>
		[Description("������� - ��� (��� ������ �����) (GatesHistory.PassID)")]
		public int? PassID { get { return _PassID; } set { _PassID = value; } }

		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (GatesHistory.TripID)
		/// </summary>
		[Description("���� - ��� (GatesHistory.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected string _OtherReason;
		/// <summary>
		/// ������ ���� ������� (GatesHistory.OtherReason)
		/// </summary>
		[Description("������ ���� ������� (GatesHistory.OtherReason)")]
		public string OtherReason { get { return _OtherReason; } set { _OtherReason = value; } }

		protected string _Reason;
		/// <summary>
		/// ���� ������� (GatesHistory.WayBillID, PassID, TripID, OtherReason)
		/// </summary>
		[Description("���� ������� (GatesHistory.WayBillID, PassID, TripID, OtherReason)")]
		public string Reason { get { return _Reason; } set { _Reason = value; } }

		protected DateTime? _DateArrivalFact;
		/// <summary>
		/// ����-����� �������� ������ - ���� (GatesHistory -> Trips.DateArrivalFact, Passes.DateArrivalFact)
		/// </summary>
		[Description("����-����� �������� ������ - ���� (GatesHistory -> Trips.DateArrivalFact, Passes.DateArrivalFact)")]
		public DateTime? DateArrivalFact { get { return _DateArrivalFact; } set { _DateArrivalFact = value; } }

		protected DateTime? _DateDepartureFact;
		/// <summary>
		/// ����-����� ������ ������ - ���� (GatesHistory -> Trips.DateDepartureFact, Passes.DateDepartureFact)
		/// </summary>
		[Description("����-����� ������ ������ - ���� (GatesHistory -> Trips.DateDepartureFact, Passes.DateDepartureFact)")]
		public DateTime? DateDepartureFact { get { return _DateDepartureFact; } set { _DateDepartureFact = value; } }

		protected int? _DurationMinutesFact;
		/// <summary>
		/// ������������ ���������� �� ����������, ���. - ���� (GatesHistory.DurationMinutesFact()*)
		/// </summary>
		[Description("������������ ���������� �� ����������, ���. - ���� (GatesHistory.DurationMinutesFact()*)")]
		public int? DurationMinutesFact { get { return _DurationMinutesFact; } set { _DurationMinutesFact = value; } }

		protected string _DurationHoursMinutesFact;
		/// <summary>
		/// ������������ ���������� �� ����������, ���:��� - ���� (GatesHistory.DurationHoursMinutesFact())
		/// </summary>
		[Description("������������ ���������� �� ����������, ���:��� - ���� (GatesHistory.DurationHoursMinutesFact())")]
		public string DurationHoursMinutesFact { get { return _DurationHoursMinutesFact; } set { _DurationHoursMinutesFact = value; } }

		protected int? _UserID;
		/// <summary>
		/// ������������ - ��� (Passes.UserID)
		/// </summary>
		[Description("������������ - ��� (Passes.UserID)")]
		public int? UserID { get { return _UserID; } set { _UserID = value; } }

		protected string _UserName;
		/// <summary>
		/// ������������ - ��� (Passes.UserID -> _Users.Name)
		/// </summary>
		[Description("������������ - ��� (Passes.UserID -> _Users.Name)")]
		public string UserName { get { return _UserName; } set { _UserName = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � ����������� ����� (GatesHistory.Note)
		/// </summary>
		[Description("���������� � ����������� ����� (GatesHistory.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� ����������� ����� � host-������� (GatesHistory.ERPCode)
		/// </summary>
		[Description("��� ����������� ����� � host-������� (GatesHistory.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ����������� ����� - ��������� ���� ������� (GatesHistory.DateCross)
		/// </summary>
		[Description("������-����: ���� ����������� ����� - ��������� ���� ������� (GatesHistory.DateCross)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ����������� ����� - �������� ���� ������� (GatesHistory.DateCross)
		/// </summary>
		[Description("������-����: ���� ����������� ����� - �������� ���� ������� (GatesHistory.DateCross)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterTimeBeg;
		/// <summary>
		/// ������-����: ����� ����������� ����� - ��������� ����� ������� (GatesHistory.DateCross)
		/// </summary>
		[Description("������-����: ����� ����������� ����� - ��������� ����� ������� (GatesHistory.DateCross)")]
		public string FilterTimeBeg { get { return _FilterTimeBeg; } set { _FilterTimeBeg = value; _NeedRequery = true; } }

		protected string _FilterTimeEnd;
		/// <summary>
		/// ������-����: ����� ����������� ����� - �������� ����� ������� (GatesHistory.DateCross)
		/// </summary>
		[Description("������-����: ����� ����������� ����� - �������� ����� ������� (GatesHistory.DateCross)")]
		public string FilterTimeEnd { get { return _FilterTimeEnd; } set { _FilterTimeEnd = value; _NeedRequery = true; } }

		protected bool? _FilterIsDeparture;
		/// <summary>
		/// ����� (GatesHistory.IsDeparture)?
		/// </summary>
		[Description("����� (GatesHistory.IsDeparture)?")]
		public bool? FilterIsDeparture { get { return _FilterIsDeparture; } set { _FilterIsDeparture = value; _NeedRequery = true; } }

		protected bool? _FilterIsOtherCar;
		/// <summary>
		/// �� ���� ������ (����������/������������) (GatesHistory.CarID is Null)?
		/// </summary>
		[Description("�� ���� ������ (����������/������������) (GatesHistory.CarID is Null)?")]
		public bool? FilterIsOtherCar { get { return _FilterIsOtherCar; } set { _FilterIsOtherCar = value; _NeedRequery = true; } }

		protected string _FilterCarsList;
		/// <summary>
		/// ������-����: ������ ����� �����, ����� ������� (GatesHistory.CarID)
		/// </summary>
		[Description("������-����: ������ ����� �����, ����� ������� (GatesHistory.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� �����, ����� ������� (GatesHistory.CarTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� �����, ����� ������� (GatesHistory.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterCarNameContext;
		/// <summary>
		/// ������-����: �������� ������������ ������ (GatesHistory.CarName)
		/// </summary>
		[Description("������-����: �������� ������������ ������ (GatesHistory.CarName)")]
		public string FilterCarNameContext { get { return _FilterCarNameContext; } set { _FilterCarNameContext = value; _NeedRequery = true; } }

		protected string _FilterCarNumberContext;
		/// <summary>
		/// ������-����: �������� ���.������ ������ (GatesHistory.CarNumber)
		/// </summary>
		[Description("������-����: �������� ���.������ ������ (GatesHistory.CarNumber)")]
		public string FilterCarNumberContext { get { return _FilterCarNumberContext; } set { _FilterCarNumberContext = value; _NeedRequery = true; } }

		protected string _FilterCarTypeNameContext;
		/// <summary>
		/// ������-����: �������� ������������ ���� ������ (GatesHistory.CarTypeName)
		/// </summary>
		[Description("������-����: �������� ������������ ���� ������ (GatesHistory.CarTypeName)")]
		public string FilterCarTypeNameContext { get { return _FilterCarTypeNameContext; } set { _FilterCarTypeNameContext = value; _NeedRequery = true; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// ������-����: ������ ����� �����������-���������, ����� ������� (GatesHistory.DriverEmployeeID)
		/// </summary>
		[Description("������-����: ������ ����� �����������-���������, ����� ������� (GatesHistory.DriverEmployeeID)")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterDriverNameContext;
		/// <summary>
		/// ������-����: �������� ��� �������� (GatesHistory.DriverName)
		/// </summary>
		[Description("������-����: �������� ��� �������� (GatesHistory.DriverName)")]
		public string FilterDriverNameContext { get { return _FilterDriverNameContext; } set { _FilterDriverNameContext = value; _NeedRequery = true; } }

		protected string _FilterReasonContext;
		/// <summary>
		/// ������-����: �������� ���� ������� (GatesHistory.Reason*)
		/// </summary>
		[Description("������-����: �������� ���� ������� (GatesHistory.Reason*)")]
		public string FilterReasonContext { get { return _FilterReasonContext; } set { _FilterReasonContext = value; _NeedRequery = true; } }

		protected bool? _FilterDateArrivalFactFull;
		/// <summary>
		/// ������-����: ��������� ����-����� �������� (GatesHistory.DateArrivalFact* is not Null)?
		/// </summary>
		[Description("������-����: ��������� ����-����� �������� (GatesHistory.DateArrivalFact* is not Null)?")]
		public bool? FilterDateArrivalFactFull { get { return _FilterDateArrivalFactFull; } set { _FilterDateArrivalFactFull = value; _NeedRequery = true; } }

		protected bool? _FilterDateDepartureFactFull;
		/// <summary>
		/// ������-����: ��������� ����-����� ������ (GatesHistory.DateDepartureFact)?
		/// </summary>
		[Description("������-����: ��������� ����-����� ������ (GatesHistory.DateDepartureFact)?")]
		public bool? FilterDateDepartureFactFull { get { return _FilterDateDepartureFactFull; } set { _FilterDateDepartureFactFull = value; _NeedRequery = true; } }

		protected string _FilterTransportPermissionsList;
		/// <summary>
		/// ������-����: ������ ����� ���������� �� ����������� �����, ����� ������� (GateHistory.TransportPermissionID -> TransportPermissions.ID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� �� ����������� �����, ����� ������� (GateHistory.TransportPermissionID -> TransportPermissions.ID)")]
		public string FilterTransportPermissionsList { get { return _FilterTransportPermissionsList; } set { _FilterTransportPermissionsList = value; _NeedRequery = true; } }

		protected string _FilterWayBillsList;
		/// <summary>
		/// ������-����: ������ ����� ������� ������, ����� ������� (GatesHistory.WayBillID)
		/// </summary>
		[Description("������-����: ������ ����� ������� ������, ����� ������� (GatesHistory.WayBillID)")]
		public string FilterWayBillsList { get { return _FilterWayBillsList; } set { _FilterWayBillsList = value; _NeedRequery = true; } }

		protected string _FilterPassesList;
		/// <summary>
		/// ������-����: ������ ����� ���������, ����� ������� (GatesHistory.PassID)
		/// </summary>
		[Description("������-����: ������ ����� ���������, ����� ������� (GatesHistory.PassID)")]
		public string FilterPassesList { get { return _FilterPassesList; } set { _FilterPassesList = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (GatesHistory.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (GatesHistory.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableSourceData;
		/// <summary>
		/// ������� �������� ������ ��� ����������� �����: ������� ����� (��� ����� �����) + �������� (��� ������� �����)
		/// </summary>
		[Description("������� �������� ������ ��� ����������� �����: ������� ����� + �������� ")]
		public DataTable TableSourceData { get { return _TableSourceData; } }

		#endregion �������

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
		/// ��������� ������� ������ ����������� ����� � ��������������� ���������� � MainTable
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
				_ErrorStr = "������ ��� ��������� ������ ����������� �����..." + Convert.ToChar(13) + ex.Message;
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

		// ���������� ���������� ������� ���������� ������� ������� ������ 
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
					_ErrorStr = "������ ��� ��������� ������ � ����������� �����...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ����������� ����� (��� ������)...";
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

		#region SourceDataFill (������� ����� + ��������)

		/// <summary>
		/// ��������� ������� ������ ����������� ����� � ��������������� ���������� � MainTable
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
				_ErrorStr = "������ ��� ��������� ������ ������ � ����������� ����������� ����� (������� ����� � ��������)..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion SourceDataFill (������� ����� + ��������)

		#region Save, Delete

		/// <summary>
		/// ���������� ����� ����������� �����
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
				_ErrorStr = "������ ��� ������� ���������� ����� ����������� �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ����� ����������� �����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ ����� ����������� ����� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nGateHistoryID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nGateHistoryID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ����� ����������� �����
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
				_ErrorStr = "������ ��� ������� �������� ����� ����������� �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ����� ����������� �����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

	}

#endregion GateHistory

}
