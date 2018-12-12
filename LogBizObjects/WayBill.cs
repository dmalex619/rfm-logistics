using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ������� ���� (WayBill)
/// </summary>
/// 
namespace LogBizObjects
{

#region WayBill 

	public class WayBill: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ������� ������ (WayBills.ID)
		/// </summary>
		[Description("������ ����� ID ������� ������ (WayBills.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateWayBeg;
		/// <summary>
		/// ���� ������ �������� (WayBills.DateWayBeg)
		/// </summary>
		[Description("���� ������ �������� (WayBills.DateWayBeg)")]
		public DateTime DateWayBeg { get { return _DateWayBeg; } set { _DateWayBeg = value; } }

		protected DateTime _DateWayEnd;
		/// <summary>
		/// ���� ��������� �������� (WayBills.DateWayEnd)
		/// </summary>
		[Description("���� ��������� �������� (WayBills.DateWayEnd)")]
		public DateTime DateWayEnd { get { return _DateWayEnd; } set { _DateWayEnd = value; } }

		protected string _BillNumber;
		/// <summary>
		/// � �������� ����� (WayBills.BillNumber)
		/// </summary>
		[Description("� �������� ����� (WayBills.BillNumber)")]
		public string BillNumber { get { return _BillNumber; } set { _BillNumber = value; } }

		protected int? _CarID;
		/// <summary>
		/// ������ - ��� (WayBills.CarID)
		/// </summary>
		[Description("������ - ��� (WayBills.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// ������ - ������������ (WayBills.CarID -> Cars.Name)
		/// </summary>
		[Description("������ - ������������ (WayBills.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// ������ - ���.����� (WayBills.CarID -> Cars.Number)
		/// </summary>
		[Description("������ - ���.����� (WayBills.CarID -> Cars.Number)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected string _TrailerNumber;
		/// <summary>
		/// ������ - ���.����� (WayBills.CarID -> Cars.Number)
		/// </summary>
		[Description("������ - ���.����� (WayBills.CarID -> Cars.Number)")]
		public string TrailerNumber { get { return _TrailerNumber; } set { _TrailerNumber = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// ��� ������ - ��� (WayBills.CarTypeID)
		/// </summary>
		[Description("��� ������ - ��� (WayBills.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// ��� ������ - ������������ (WayBills.CarTypeID -> CarsTypes.Name)
		/// </summary>
		[Description("��� ������ - ������������ (WayBills.CarTypeID -> CarsTypes.Name)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// ���������-�������� - ��� (WayBills.DriverEmployeeID)
		/// </summary>
		[Description("���������-�������� - ��� (WayBills.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// ���������-�������� - ������������ (WayBills.DriverEmployeeID -> Employees.ID --> Drivers.Name)
		/// </summary>
		[Description("���������-�������� - ������������ (WayBills.DriverEmployeeID -> Employees.ID --> Drivers.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected string _DriverOther;
		/// <summary>
		/// �������������� ���������� � �������� (WayBills.DriverOther)
		/// </summary>
		[Description("�������������� ���������� � �������� (WayBills.DriverOther)")]
		public string DriverOther { get { return _DriverOther; } set { _DriverOther = value; } }

		protected string _Reason;
		/// <summary>
		/// ���������� (WayBills.Reason)
		/// </summary>
		[Description("���������� (WayBills.Reason)")]
		public string Reason { get { return _Reason; } set { _Reason = value; } }

		protected decimal _FuelTank;
		/// <summary>
		/// ������� ���������� ����, � (WayBills.CarID -> Cars.FuelTank)
		/// </summary>
		[Description("������� ���������� ����, � (WayBills.CarID -> Cars.FuelTank)")]
		public decimal FuelTank { get { return _FuelTank; } set { _FuelTank = value; } }

		protected decimal _FreezerTank;
		/// <summary>
		/// ������� ���� ��� ����������� ���������, � (WayBills.CarID -> Cars.FreezerTank)
		/// </summary>
		[Description("������� ���� ��� ����������� ���������, � (WayBills.CarID -> Cars.FreezerTank)")]
		public decimal FreezerTank { get { return _FreezerTank; } set { _FreezerTank = value; } }

		protected int? _SpeedometerDataBeg;
		/// <summary>
		/// ��������� ��������� ���������� (WayBills.SpeedometerDataBeg)
		/// </summary>
		[Description("��������� ��������� ���������� (WayBills.SpeedometerDataBeg)")]
		public int? SpeedometerDataBeg { get { return _SpeedometerDataBeg; } set { _SpeedometerDataBeg = value; } }

		protected int? _SpeedometerDataEnd;
		/// <summary>
		/// �������� ��������� ���������� (WayBills.SpeedometerDataEnd)
		/// </summary>
		[Description("�������� ��������� ���������� (WayBills.SpeedometerDataEnd)")]
		public int? SpeedometerDataEnd { get { return _SpeedometerDataEnd; } set { _SpeedometerDataEnd = value; } }

		protected bool _IsSpeedometerReset;
		/// <summary>
		/// ��������� ���������� �������� (WayBills.IsSpeedometerReset)
		/// </summary>
		[Description("��������� ���������� �������� (WayBills.IsSpeedometerReset)")]
		public bool IsSpeedometerReset { get { return _IsSpeedometerReset; } set { _IsSpeedometerReset = value; } }

		protected bool _IsSpeedometerEdit;
		/// <summary>
		/// ��������� ���������� �������� (WayBills.IsSpeedometerEdit)
		/// </summary>
		[Description("��������� ���������� �������� (WayBills.IsSpeedometerEdit)")]
		public bool IsSpeedometerEdit { get { return _IsSpeedometerEdit; } set { _IsSpeedometerEdit = value; } }

		protected decimal? _FuelDataBeg;
		/// <summary>
		/// ��������� ������� �������, � (WayBills.FuelDataBeg)
		/// </summary>
		[Description("��������� ������� �������, � (WayBills.FuelDataBeg)")]
		public decimal? FuelDataBeg { get { return _FuelDataBeg; } set { _FuelDataBeg = value; } }

		protected decimal? _FuelDataEnd;
		/// <summary>
		/// �������� ������� �������, � (WayBills.FuelDataEnd)
		/// </summary>
		[Description("�������� ������� �������, � (WayBills.FuelDataEnd)")]
		public decimal? FuelDataEnd { get { return _FuelDataEnd; } set { _FuelDataEnd = value; } }

		protected decimal? _FuelFreezerDataBeg;
		/// <summary>
		/// ��������� ������� ������� ��� �����.���������, � (WayBills.FuelFreezerDataBeg)
		/// </summary>
		[Description("��������� ������� ������� ��� �����.���������, � (WayBills.FuelFreezerDataBeg)")]
		public decimal? FuelFreezerDataBeg { get { return _FuelFreezerDataBeg; } set { _FuelFreezerDataBeg = value; } }

		protected decimal? _FuelFreezerDataEnd;
		/// <summary>
		/// �������� ������� ������� ��� �����.���������, � (WayBills.FuelFreezerDataEnd)
		/// </summary>
		[Description("�������� ������� ������� ��� �����.���������, � (WayBills.FuelFreezerDataEnd)")]
		public decimal? FuelFreezerDataEnd { get { return _FuelFreezerDataEnd; } set { _FuelFreezerDataEnd = value; } }

		protected decimal? _FuelQntFilled;
		/// <summary>
		/// ���������� ������������� �������, � (WayBills.FuelQntFilled)
		/// </summary>
		[Description("���������� ������������� �������, � (WayBills.FuelQntFilled)")]
		public decimal? FuelQntFilled { get { return _FuelQntFilled; } set { _FuelQntFilled = value; } }

		protected int? _FreezerDurationMinutes;
		/// <summary>
		/// ����������������� ������ ����������� ���������, ���. (WayBills.FreezerDurationMinutes)
		/// </summary>
		[Description("����������������� ������ ����������� ���������, ���. (WayBills.FreezerDurationMinutes)")]
		public int? FreezerDurationMinutes { get { return _FreezerDurationMinutes; } set { _FreezerDurationMinutes = value; } }

		protected string _FreezerDurationHoursMinutes;
		/// <summary>
		/// ����������������� ������ ����������� ���������, ���:��� (DurationHoursMinutes(WayBills.FreezerDurationHoursMinutes))
		/// </summary>
		[Description("����������������� ������ ����������� ���������, ���:��� (DurationHoursMinutes(WayBills.FreezerDurationHoursMinutes))")]
		public string FreezerDurationHoursMinutes { get { return _FreezerDurationHoursMinutes; } set { _FreezerDurationHoursMinutes = value; } }

		protected bool _IsFuelEdit;
		/// <summary>
		/// ��������� ���������� �������� (WayBills.IsFuelEdit)
		/// </summary>
		[Description("��������� ���������� �������� (WayBills.IsFuelEdit)")]
		public bool IsFuelEdit { get { return _IsFuelEdit; } set { _IsFuelEdit = value; } }

		protected int? _UserCreateID;
		/// <summary>
		/// ������������, ������� ������� (����) ������� ���� - ��� (WayBills.UserCreateID)
		/// </summary>
		[Description("������������, ������� ������� (����) ������� ���� - ��� (WayBills.UserCreateID)")]
		public int? UserCreateID { get { return _UserCreateID; } set { _UserCreateID = value; } }

		protected string _UserCreateName;
		/// <summary>
		/// ������������, ������� ������� (����) ������� ���� - ��� (WayBills.UserCreateID -> _Users.Name)
		/// </summary>
		[Description("������������, ������� ������� (����) ������� ���� - ��� (WayBills.UserCreateID -> _Users.Name)")]
		public string UserCreateName { get { return _UserCreateName; } set { _UserCreateName = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// ����-����� ����� �������� ����� (WayBills.DateCreate)
		/// </summary>
		[Description("����-����� ����� �������� ����� (WayBills.DateCreate)")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected int? _UserConfirmID;
		/// <summary>
		/// ������������, ������� ���������� ������� ���� - ��� (WayBills.UserConfirmID)
		/// </summary>
		[Description("������������, ������� ���������� ������� ���� - ��� (WayBills.UserConfirmID)")]
		public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

		protected string _UserConfirmName;
		/// <summary>
		/// ������������, ������� ���������� ������� ���� - ������������ (WayBills.UserConfirmID -> _Users.Name)
		/// </summary>
		[Description("������������, ������� ���������� ������� ���� - ������������ (WayBills.UserConfirmID -> _Users.Name)")]
		public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }

		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� �������� ����� (WayBills.DateConfirm)
		/// </summary>
		[Description("����-����� ������������� �������� ����� (WayBills.DateConfirm)")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// �������� �������� ����� ��������� (������������) (WayBills.DateConfirm is not Null)
		/// </summary>
		[Description("�������� �������� ����� ��������� (������������) (WayBills.DateConfirm is not Null)")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � �������� ����� (WayBills.Note)
		/// </summary>
		[Description("���������� � �������� ����� (WayBills.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected int _TransportPermissionID;
		/// <summary>
		/// ���������� �� ����������� ����� - ��� (WayBills.ID -> TransportPermissions.WayBillID)
		/// </summary>
		[Description("���������� �� ����������� ����� - ��� (WayBills.ID -> TransportPermissions.WayBillID)")]
		public int TransportPermissionID { get { return _TransportPermissionID; } set { _TransportPermissionID = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� �������� � host-������� (WayBills.ERPCode)
		/// </summary>
		[Description("��� �������� � host-������� (WayBills.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� �������� ����� - ��������� ���� ������� (WayBills.DateWay)
		/// </summary>
		[Description("������-����: ���� �������� ����� - ��������� ���� ������� (WayBills.DateWay)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� �������� ����� - �������� ���� ������� (WayBills.DateWay)
		/// </summary>
		[Description("������-����: ���� �������� ����� - �������� ���� ������� (WayBills.DateWay)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }
		
		protected string _FilterCarsList;
		/// <summary>
		/// ������-����: ������ ����� �����, ����� ������� (WayBills.CarID)
		/// </summary>
		[Description("������-����: ������ ����� �����, ����� ������� (WayBills.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� �����, ����� ������� (WayBill.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� �����, ����� ������� (WayBill.CarID -> Cars.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// ������-����: ������ ����� �����������-���������, ����� ������� (WayBills.DriversEmployeeID)
		/// </summary>
		[Description("������-����: ������ ����� �����������-���������, ����� ������� (WayBills.DriversEmployeeID)")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterReasonContext;
		/// <summary>
		/// ������-����: �������� ���� ������� (WayBills.Reason)
		/// </summary>
		[Description("������-����: �������� ���� ������� (WayBills.Reason)")]
		public string FilterReasonContext { get { return _FilterReasonContext; } set { _FilterReasonContext = value; _NeedRequery = true; } }

		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: �������� �������� ����� ��������� (������������) (WayBills.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: �������� �������� ����� ��������� (������������) (WayBills.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		protected string _FilterTransportPermissionsList;
		/// <summary>
		/// ������-����: ������ ����� ���������� �� ����������� �����, ����� ������� (WayBills -> TransportPermissions.WayBillID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� �� ����������� �����, ����� ������� (WayBills -> TransportPermissions.WayBillID)")]
		public string FilterTransportPermissionsList { get { return _FilterTransportPermissionsList; } set { _FilterTransportPermissionsList = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (WayBills - Trips.WayBillID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (WayBills - Trips.WayBillID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterFillingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (WayBills - Fillings.WayBillID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (WayBills - Fillings.WayBillID)")]
		public string FilterFillingsList { get { return _FilterFillingsList; } set { _FilterFillingsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableFillings;
		/// <summary>
		/// ������� �������� Fillings
		/// </summary>
		[Description("������� �������� Fillings")]
		public DataTable TableFillings { get { return _TableFillings; } }

		#endregion �������

		// ----------------------------

		public WayBill() : base()
		{
			_MainTableName = "WayBills";
			_ColumnID = "ID";
			_ColumnName = "DateWayBeg";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������� ������ � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_WayBillsFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@cCarsList, " +
									"@cCarsTypesList, " +
									"@cDriversEmployeesList, " + 
									"@cReasonContext, " + 
									"@bIsConfirmed, " + 
									"@cTransportPermissionsList, " +
									"@cTripsList, " + 
									"@cFillingsList";	
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_WayBillsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cFillingsList", SqlDbType.VarChar);
			if (_FilterFillingsList != null)
				_oParameter.Value = _FilterFillingsList;
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
				_ErrorStr = "������ ��� ��������� ������ ������� ������..." + Convert.ToChar(13) + ex.Message;
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
			_FilterCarsList = null;
			_FilterCarsTypesList = null;
			_FilterDriversEmployeesList = null;
			_FilterReasonContext = null;
			_FilterTransportPermissionsList = null;
			_FilterTripsList = null;
			_FilterFillingsList = null;
			_FilterIsConfirmed = null;
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
					_BillNumber = r["BillNumber"].ToString();
					_DateWayBeg = Convert.ToDateTime(r["DateWayBeg"]);
					_DateWayEnd = Convert.ToDateTime(r["DateWayEnd"]);

					if (!Convert.IsDBNull(r["CarID"]))
					{
						_CarID = Convert.ToInt32(r["CarID"]);
						_CarName = r["CarName"].ToString();
						_CarNumber = r["CarNumber"].ToString();
						_TrailerNumber = r["TrailerNumber"].ToString();
					}
					if (!Convert.IsDBNull(r["CarTypeID"]))
					{
						_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
						_CarTypeName = r["CarTypeName"].ToString();
					}

					if (!Convert.IsDBNull(r["DriverEmployeeID"]))
					{
						_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
						_DriverName = r["DriverName"].ToString();
					}
					_DriverOther = r["DriverOther"].ToString();

					_Reason = r["Reason"].ToString();

					_FuelTank = Convert.ToInt32(r["FuelTank"]);
					_FreezerTank = Convert.ToInt32(r["FreezerTank"]);

					if (!Convert.IsDBNull(r["SpeedometerDataBeg"]))
						_SpeedometerDataBeg = Convert.ToInt32(r["SpeedometerDataBeg"]);
					if (!Convert.IsDBNull(r["SpeedometerDataEnd"]))
						_SpeedometerDataEnd = Convert.ToInt32(r["SpeedometerDataEnd"]);
					_IsSpeedometerReset = Convert.ToBoolean(r["IsSpeedometerReset"]);
					_IsSpeedometerEdit = Convert.ToBoolean(r["IsSpeedometerEdit"]);
					
					if (!Convert.IsDBNull(r["FuelDataBeg"]))
						_FuelDataBeg = Convert.ToDecimal(r["FuelDataBeg"]);
					if (!Convert.IsDBNull(r["FuelDataEnd"]))
						_FuelDataEnd = Convert.ToDecimal(r["FuelDataEnd"]);
					if (!Convert.IsDBNull(r["FuelFreezerDataBeg"]))
						_FuelFreezerDataBeg = Convert.ToDecimal(r["FuelFreezerDataBeg"]);
					if (!Convert.IsDBNull(r["FuelFreezerDataEnd"]))
						_FuelFreezerDataEnd = Convert.ToDecimal(r["FuelFreezerDataEnd"]);
					_FuelQntFilled = Convert.ToDecimal(r["FuelQntFilled"]);
					_IsFuelEdit = Convert.ToBoolean(r["IsFuelEdit"]);
					_FreezerDurationMinutes = Convert.ToInt32(r["FreezerDurationMinutes"]);
					_FreezerDurationHoursMinutes = r["FreezerDurationHoursMinutes"].ToString();

					if (!Convert.IsDBNull(r["UserCreateID"]))
					{
						_UserCreateID = Convert.ToInt32(r["UserCreateID"]);
						_UserCreateName = r["UserCreateName"].ToString();
					}
					if (!Convert.IsDBNull(r["DateCreate"]))
					{
						_DateCreate = Convert.ToDateTime(r["DateCreate"]);
					}
					
					if (!Convert.IsDBNull(r["UserConfirmID"]))
					{
						_UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
						_UserConfirmName = r["UserConfirmName"].ToString();
					}
					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);

					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);
					_Note = r["Note"].ToString();

                    if (!Convert.IsDBNull(r["TransportPermissionID"]))
                        _TransportPermissionID = Convert.ToInt32(r["TransportPermissionID"]);
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ������� �����...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ������� ����� (��� ������)...";
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
			_BillNumber = null;
			_DateWayBeg = DateTime.Now;
			_DateWayEnd = DateTime.Now;

			_CarID = null;
			_CarName = null;
			_CarNumber = null;
			_TrailerNumber = null;
			_CarTypeID = null;
			_CarTypeName = null;
			_DriverEmployeeID = null;
			_DriverName = null;
			_DriverOther = null;

			_FuelTank = 0;
			_FreezerTank = 0;

			_SpeedometerDataBeg = null;
			_SpeedometerDataEnd = null;
			_IsSpeedometerReset = false;
			_IsSpeedometerEdit = false;
			_FuelDataBeg = null;
			_FuelDataEnd = null;
			_FuelFreezerDataBeg = null;
			_FuelFreezerDataEnd = null;
			_FuelQntFilled = 0;
			_IsFuelEdit = false;
			_FreezerDurationMinutes = 0;
			_FreezerDurationHoursMinutes = null;

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
		/// ���������� ������ �������� ����� 
		/// </summary>

		public bool Save()
		{
			return (Save(null, null));
		}

		public bool Save(DataTable tableFillingsInWayBill, DataTable tableTripsInWayBill)
		{
			// �������������� �������: �������� � �����
			try
			{
				_Connect.Open();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ���������� � ��������...\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
				return (false);
			}

			if (tableFillingsInWayBill != null)
			{
				RFMUtilities.DataTableToTempTable(tableFillingsInWayBill, "#FillingsInWayBill", _Connect);
			}
			if (tableTripsInWayBill != null)
			{
				RFMUtilities.DataTableToTempTable(tableTripsInWayBill, "#TripsInWayBill", _Connect);
			}

			string _sqlCommand = "execute up_WayBillsSave @nWayBillID output, " +
					"@cBillNumber, " +
					"@dDateWayBeg, @dDateWayEnd, " +
					"@nCarID, @nDriverEmployeeID, " + 
					"@cDriverOther, @cReason, " +
					"@nSpeedometerDataBeg, @nSpeedometerDataEnd, " +
					"@nFuelDataBeg, @nFuelDataEnd, " +
					"@nFuelFreezerDataBeg, @nFuelFreezerDataEnd, " +
					"@nFuelQntFilled, " +
					"@nFreezerDurationMinutes, " + 
					"@cNote, " +
					"@nUserCreateID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_WayBillsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nWayBillID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cBillNumber", SqlDbType.VarChar);
			if (_BillNumber != null)
				_oParameter.Value = _BillNumber;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			_oParameter.Value = _CarID;

			_oParameter = _oCommand.Parameters.Add("@dDateWayBeg", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateWayBeg;

			_oParameter = _oCommand.Parameters.Add("@dDateWayEnd", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateWayEnd;

			_oParameter = _oCommand.Parameters.Add("@nDriverEmployeeID", SqlDbType.Int);
			_oParameter.Value = _DriverEmployeeID;

			_oParameter = _oCommand.Parameters.Add("@cDriverOther", SqlDbType.VarChar);
			_oParameter.Value = _DriverOther;

			_oParameter = _oCommand.Parameters.Add("@cReason", SqlDbType.VarChar);
			_oParameter.Value = _Reason;

			_oParameter = _oCommand.Parameters.Add("@nSpeedometerDataBeg", SqlDbType.Int);
			if (_SpeedometerDataBeg.HasValue)
				_oParameter.Value = _SpeedometerDataBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nSpeedometerDataEnd", SqlDbType.Int);
			if (_SpeedometerDataEnd.HasValue)
				_oParameter.Value = _SpeedometerDataEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nFuelDataBeg", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			if (_FuelDataBeg.HasValue)
				_oParameter.Value = _FuelDataBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nFuelDataEnd", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			if (_FuelDataEnd.HasValue)
				_oParameter.Value = _FuelDataEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nFuelFreezerDataBeg", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			if (_FuelFreezerDataBeg.HasValue)
				_oParameter.Value = _FuelFreezerDataBeg;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nFuelFreezerDataEnd", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			if (_FuelFreezerDataEnd.HasValue)
				_oParameter.Value = _FuelFreezerDataEnd;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nFuelQntFilled", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			if (_FuelQntFilled.HasValue)
				_oParameter.Value = _FuelQntFilled;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nFreezerDurationMinutes", SqlDbType.Int);
			if (_FreezerDurationMinutes.HasValue)
				_oParameter.Value = _FreezerDurationMinutes;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			_oParameter.Value = _Note;

			_oParameter = _oCommand.Parameters.Add("@nUserCreateID", SqlDbType.Int);
			if (_UserCreateID.HasValue)
				_oParameter.Value = _UserCreateID;
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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ���������� �������� �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� �������� �����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ ���.����� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nWayBillID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nWayBillID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� �������� ����� 
		/// </summary>
		public bool DeleteOne(int nWayBillID)
		{
			String _sqlCommand = "execute up_WayBillsDelete @nWayBillID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_WayBillsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nWayBillID", SqlDbType.Int);
			_oParameter.Value = nWayBillID;

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
				_ErrorStr = "������ ��� �������� ������ � ������� �����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � ������� �����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// �������� �������� ����� 
		/// </summary>
		public bool Confirm(int? nWayBillID, bool bConfirm, int nUserID)
		{
			string _sqlCommand = "execute up_WayBillsConfirm @nWayBillID, " +
					"@bConfirm, " +
					"@nUserConfirmID, " + 
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_WayBillsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nWayBillID", SqlDbType.Int);
			_oParameter.Value = nWayBillID;

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

			#endregion up_WayBillsConfirm parameters

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
					_ErrorStr = "������ ��� ������� �������� �������� �����...";
				}
				else
				{
					_ErrorStr = "������ ��� ������� ������ ������� � �������� �������� �����...";
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
						_ErrorStr = "������ ��� �������� �������� �����...";
					}
					else
					{
						_ErrorStr = "������ ��� ��� ������ ������� � �������� �������� �����...";
					}
					_ErrorStr += "\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm


		#region �������

		#region TableFillings

		/// <summary>
		/// ��������� ������� ����� �������� (TableFillings)
		/// </summary>
		public bool FillTableFillings()
		{
			string sqlSelect = "execute up_FillingsFill " +
									"@cWaysBillsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_FillingsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cWaysBillsList", SqlDbType.VarChar);
			if (_ID != null)
				_oParameter.Value = _ID.ToString();
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableFillings = FillReadings(new SqlDataAdapter(_oCommand), _TableFillings, "TableFillings");
				_TableFillings.PrimaryKey = new DataColumn[] { _TableFillings.Columns[0] };
				_NeedRequery = false;
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ������ �������� ��� �������� �����..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TableFillings

		#endregion �������

	}

#endregion WayBill

}
