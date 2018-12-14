using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ��������� (Employee), �������� (Driver)
/// </summary>
/// 
namespace LogBizObjects
{

#region Employee

	public class Employee: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ����������� (Employees.ID)
		/// </summary>
		[Description("������ ����� ID ����������� (Employees.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _Name;
		/// <summary>
		/// ��� ���������� (Employees.Name)
		/// </summary>
		[Description("��� ���������� (Employees.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _Alias;
		/// <summary>
		/// ���-�������� ���������� (Employees.Alias)
		/// </summary>
		[Description("���-�������� ���������� (Employees.Alias)")]
		public string Alias { get { return _Alias; } set { _Alias = value; } }

		protected string _PassportSeries;
		/// <summary>
		/// ����� �������� (Employees.PassportSeries)
		/// </summary>
		[Description("����� �������� (Employees.PassportSeries)")]
		public string PassportSeries { get { return _PassportSeries; } set { _PassportSeries = value; } }

		protected string _PassportNumber;
		/// <summary>
		/// ����� �������� (Employees.PassportNumber)
		/// </summary>
		[Description("����� �������� (Employees.PassportNumber)")]
		public string PassportNumber { get { return _PassportNumber; } set { _PassportNumber = value; } }

		protected DateTime? _PassportDate;
		/// <summary>
		/// ���� ������ �������� (Employees.PassportDate)
		/// </summary>
		[Description("���� ������ �������� (Employees.PassportDate)")]
		public DateTime? PassportDate { get { return _PassportDate; } set { _PassportDate = value; } }

		protected string _PassportGranted;
		/// <summary>
		/// ��� ����� ������� (Employees.PassportGranted)
		/// </summary>
		[Description("��� ����� ������� (Employees.PassportGranted)")]
		public string PassportGranted { get { return _PassportGranted; } set { _PassportGranted = value; } }
		
		protected int? _JobTitleID;
		/// <summary>
		/// ��������� - ��� (Employees.JobTitleID)
		/// </summary>
		[Description("��������� - ��� (Employees.JobTitleID)")]
		public int? JobTitleID { get { return _JobTitleID; } set { _JobTitleID = value; } }

		protected string _JobTitleName;
		/// <summary>
		/// ��������� - ������������ (Employees.JobTitleID -> JobTitles.Name)
		/// </summary>
		[Description("��������� - ������������ (Employees.JobTitleID -> JobTitles.Name)")]
		public string JobTitleName { get { return _JobTitleName; } set { _JobTitleName = value; } }

		protected string _MobPhone;
		/// <summary>
		/// ��������� ������� (Employees.MobPhone)
		/// </summary>
		[Description("��������� ������� (Employees.MobPhone)")]
		public string MobPhone { get { return _MobPhone; } set { _MobPhone = value; } }

		protected byte[] _Photo;
		/// <summary>
		/// ���� ���������� (Employees.Photo)
		/// </summary>
		[Description("���� ���������� (Employees.Photo)")]
		public byte[] Photo { get { return _Photo; } set { _Photo = value; } }

		protected bool _PassConfirmAllowed;
		/// <summary>
		/// ��������� ���������� ������� �� ������ (Employees.PassConfirmAllowed)?
		/// </summary>
		[Description("��������� ���������� ������� �� ������ (Employees.PassConfirmAllowed)?")]
		public bool PassConfirmAllowed { get { return _PassConfirmAllowed; } set { _PassConfirmAllowed = value; } }

		protected bool _Actual;
		/// <summary>
		/// ��������� (Employees.Actual)?
		/// </summary>
		[Description("��������� (Employees.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected bool _IsDriver;
		/// <summary>
		/// ���������-�������� (Employees -> Drivers)?
		/// </summary>
		[Description("���������-�������� (Employees -> Drivers)?")]
		public bool IsDriver { get { return _IsDriver; } set { _IsDriver = value; } }

		protected int? _DriverID;
		/// <summary>
		/// ��� �������� (Employees -> Drivers.ID)
		/// </summary>
		[Description("��� �������� (Employees -> Drivers.ID)")]
		public int? DriverID { get { return DriverID; } set { _DriverID = value; } }

		protected bool _DriverInfo;
		/// <summary>
		/// �������� ���������� �� ��������� � MainTable?
		/// </summary>
		[Description("�������� ���������� �� ��������� � MainTable?")]
		public bool DriverInfo { get { return _DriverInfo; } set { _DriverInfo = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� ���������� � host-������� (Employees.ERPCode)
		/// </summary>
		[Description("��� ���������� � host-������� (Employees.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterNameContext;
		/// <summary>
		/// ������-����: �������� ��� (Employees.Name)
		/// </summary>
		[Description("������-����: �������� ��� (Employees.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		protected bool? _FilterIsDriver;
		/// <summary>
		/// ������-����: �������� (Employees - Drivers)?
		/// </summary>
		[Description("������-����: �������� (Employees - Drivers)?")]
		public bool? FilterIsDriver { get { return _FilterIsDriver; } set { _FilterIsDriver = value; _NeedRequery = true; } }

		protected string _FilterJobTitleContext;
		/// <summary>
		/// ������-����: �������� ��������� (Employees.JobTitleID -> JobTitles.Name)
		/// </summary>
		[Description("������-����: �������� ��������� (Employees.JobTitleID -> JobTitles.Name)")]
		public string FilterJobTitleContext { get { return _FilterJobTitleContext; } set { _FilterJobTitleContext = value; _NeedRequery = true; } }

		protected bool? _FilterActual;
		/// <summary>
		/// ������-����: ���������� ���������� (Employees.Actual)?
		/// </summary>
		[Description("������-����: ���������� ���������� (Employees.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableJobTitles;
		/// <summary>
		/// ������� ���������� JobTitles
		/// </summary>
		[Description("������� ���������� JobTitles")]
		public DataTable TableJobTitles { get { return _TableJobTitles; } }

		#endregion �������

		// ----------------------------

		public Employee()
			: base()
		{
			_MainTableName = "Employees";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ����������� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_EmployeesFill @nID, @cIDList, " +
									"@cNameContext, " +
									"@bIsDriver, " + 
									"@cJobTitleContext, " + 
									"@bActual, " + 
									"@bDriverInfo";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_EmployeesFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsDriver", SqlDbType.Bit);
			if (_FilterIsDriver != null)
				_oParameter.Value = _FilterIsDriver;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cJobTitleContext", SqlDbType.VarChar);
			if (_FilterJobTitleContext != null)
				_oParameter.Value = _FilterJobTitleContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterActual != null)
				_oParameter.Value = _FilterActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bDriverInfo", SqlDbType.Bit);
			_oParameter.Value = _DriverInfo;
			
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
				_ErrorStr = "������ ��� ��������� ������ �����������..." + Convert.ToChar(13) + ex.Message;
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
			
			_FilterNameContext = null;
			_FilterIsDriver = null;
			_FilterJobTitleContext = null;
			_FilterActual = null;
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
					_Name = r["Name"].ToString();
					_Alias = r["Alias"].ToString();

					_PassportSeries = r["PassportSeries"].ToString();
					_PassportNumber = r["PassportNumber"].ToString();
					if (!Convert.IsDBNull(r["PassportDate"]))
						_PassportDate = Convert.ToDateTime(r["PassportDate"]);
					_PassportGranted = r["PassportGranted"].ToString();

					if (!Convert.IsDBNull(r["JobTitleID"]))
						_JobTitleID = Convert.ToInt32(r["JobTitleID"]);
					_JobTitleName = r["JobTitleName"].ToString();

					_MobPhone = r["MobPhone"].ToString();

					_Photo = r["Photo"] as byte[];

					_IsDriver = Convert.ToBoolean(r["IsDriver"]);
					if (!Convert.IsDBNull(r["DriverID"]))
						_DriverID = Convert.ToInt32(r["DriverID"]);

					_PassConfirmAllowed = Convert.ToBoolean(r["PassConfirmAllowed"]);

					_Actual = Convert.ToBoolean(r["Actual"]);
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ����������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ���������� (��� ������)...";
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

			_Name = null;
			_Alias = null;

			_PassportSeries = null;
			_PassportNumber = null;
			_PassportDate = null;
			_PassportGranted = null;

			_JobTitleID = null;
			_JobTitleName = null;

			_MobPhone = null;
			
			_Photo = null;

			_IsDriver = false;
			_DriverID = null;

			_PassConfirmAllowed = false;

			_Actual = false;
			_ERPCode = null;
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// ���������� ������ ���������� 
		/// </summary>
		public bool SaveOne()
		{
			string _sqlCommand = "execute up_EmployeesSave @nEmployeeID output, " +
							"@cName, " +
							"@cAlias, " +
							"@cPassportSeries, @cPassportNumber, @dPassportDate, @cPassportGranted, " +
							"@nJobTitleID, " +
							"@cMobPhone, " +
							"@bPassConfirmAllowed, " + 
							"@bActual, " +
							"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_EmployeesSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nEmployeeID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue) 
				_oParameter.Value = _ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cName", SqlDbType.VarChar);
			_oParameter.Value = _Name;

			_oParameter = _oCommand.Parameters.Add("@cAlias", SqlDbType.VarChar);
			_oParameter.Value = _Alias;

			_oParameter = _oCommand.Parameters.Add("@cPassportSeries", SqlDbType.VarChar);
			_oParameter.Value = _PassportSeries;

			_oParameter = _oCommand.Parameters.Add("@cPassportNumber", SqlDbType.VarChar);
			_oParameter.Value = _PassportNumber;

			_oParameter = _oCommand.Parameters.Add("@dPassportDate", SqlDbType.DateTime);
			if (_PassportDate != null)
				_oParameter.Value = _PassportDate;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPassportGranted", SqlDbType.VarChar);
			_oParameter.Value = _PassportGranted;

			_oParameter = _oCommand.Parameters.Add("@nJobTitleID", SqlDbType.Int);
			if (_JobTitleID.HasValue) 
				_oParameter.Value = _JobTitleID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cMobPhone", SqlDbType.VarChar);
			_oParameter.Value = _MobPhone;

			_oParameter = _oCommand.Parameters.Add("@bPassConfirmAllowed", SqlDbType.Bit);
			_oParameter.Value = _PassConfirmAllowed;

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ���������� ������ � ����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ � ����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}

				// ��� �������� ������ ���������� - ������� ��� ���
				if ((!_ID.HasValue || (int)_ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nEmployeeID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nEmployeeID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ���������� ���� ���������� 
		/// </summary>
		public bool SaveOnePhoto()
		{
			string _sqlCommand = "execute up_EmployeesPhotoSave @nEmployeeID, " +
					"@bPhoto, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_EmployeesPhotoSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nEmployeeID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@bPhoto", SqlDbType.Image);
			if (_Photo != null)
			{
				_oParameter.Size = _Photo.Length;
				_oParameter.Value = _Photo;
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
				_ErrorStr = "������ ��� ���������� ���� ����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ���� ����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ����������
		/// </summary>
		public bool DeleteData(int nEmployeeID)
		{
			String _sqlCommand = "execute up_EmployeesDelete @nEmployeeID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_EmployeesDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nEmployeeID", SqlDbType.Int);
			_oParameter.Value = nEmployeeID;

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
				_ErrorStr = "������ ��� �������� ������ � ����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � ����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region �������

		/// <summary>
		/// ��������� ������� ���������� (TableJobTitles)
		/// </summary>
		public bool FillTableJobTitles()
		{
			string sqlSelect = 
				"select ID, Name, "  + 
						"ERPCode " + 
					"from JobTitles " +
					"where 1 = 1 ";
			//if (_FilterJobTitlesList != null)
			//{
			//	sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterJobTitlesList + "' + ',') > 0";
			//}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableJobTitles = FillReadings(new SqlDataAdapter(_oCommand), _TableJobTitles, "TableJobTitles");
				_TableJobTitles.PrimaryKey = new DataColumn[] { _TableJobTitles.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion �������

	}

#endregion Employees

	// -----------------------------------------------------------------------

#region Driver

	public class Driver : Employee 
	{
		#region ����, ��������

		protected bool _Operable;
		/// <summary>
		/// �������� (Drivers.Operable)?
		/// </summary>
		[Description("�������� (Drivers.Operable)?")]
		public bool Operable { get { return _Operable; } set { _Operable = value; } }

		protected bool _ForGoodsOnly;
		/// <summary>
		/// ���������� ����� (Drivers.ForGoodsOnly)?
		/// </summary>
		[Description("���������� ����� (Drivers.ForGoodsOnly)?")]
		public bool ForGoodsOnly { get { return _ForGoodsOnly; } set { _ForGoodsOnly = value; } }

		protected string _DriverCategory;
		/// <summary>
		/// ������������ ��������� (Drivers.DriverCategory)
		/// </summary>
		[Description("������������ ��������� (Drivers.DriverCategory)")]
		public string DriverCategory { get { return _DriverCategory; } set { _DriverCategory = value; } }

		protected string _DriverLicenceNumber;
		/// <summary>
		/// ����� ������������ ���� (Drivers.DriverLicenceNumber)
		/// </summary>
		[Description("����� ������������ ���� (Drivers.DriverLicenceNumber)")]
		public string DriverLicenceNumber { get { return _DriverLicenceNumber; } set { _DriverLicenceNumber = value; } }

		protected int? _CarID;
		/// <summary>
		/// ������ [�����.] - ��� (Drivers.CarID)
		/// </summary>
		[Description("������ [�����.] - ��� (Drivers.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// ������ [�����.] - ������������ (Drivers.CarID -> Cars.Name)
		/// </summary>
		[Description("������ [�����.] - ������������ (Drivers.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// ��� ������ [�����.] - ��� (Drivers.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("��� ������ [�����.] - ��� (Drivers.CarID -> Cars.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// ��� ������ [�����.] - ������������ (Drivers.CarID -> Cars.CarTypeID -> CarsTypes.Name)
		/// </summary>
		[Description("��� ������ [�����.] - ������������ (Drivers.CarID -> Cars.CarTypeID -> CarsTypes.Name)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _ZoneID;
		/// <summary>
		/// ���� [�����.] - ��� (Drivers.ZoneID)
		/// </summary>
		[Description("���� [�����.] - ��� (Drivers.ZoneID)")]
		public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

		protected string _ZoneName;
		/// <summary>
		/// ���� [�����.] - ������������ (Drivers.ZoneID -> Zones.Name)
		/// </summary>
		[Description("���� [�����.] - ������������ (Drivers.ZoneID -> Zones.Name)")]
		public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

		protected string _ZoneAlias;
		/// <summary>
		/// ���� [�����.] - ������� ������������ (Drivers.ZoneID -> Zones.Alias)
		/// </summary>
		[Description("���� [�����.] - ������� ������������ (Drivers.ZoneID -> Zones.Alias)")]
		public string ZoneAlias { get { return _ZoneAlias; } set { _ZoneAlias = value; } }

		#endregion ����, ��������

		#region �������

		protected bool? _FilterOperable;
		/// <summary>
		/// ������-����: �������� �������� (Drivers.Operable)?
		/// </summary>
		[Description("������-����: �������� �������� (Drivers.Operable)?")]
		public bool? FilterOperable { get { return _FilterOperable; } set { _FilterOperable = value; _NeedRequery = true; } }

		protected bool? _FilterForGoodsOnly;
		/// <summary>
		/// ������-����: �������� ���������� ����� (Drivers.ForGoodsOnly)?
		/// </summary>
		[Description("������-����: �������� ���������� ����� (Drivers.ForGoodsOnly)?")]
		public bool? FilterForGoodsOnly { get { return _FilterForGoodsOnly; } set { _FilterForGoodsOnly = value; _NeedRequery = true; } }

		protected string _FilterCarsList;
		/// <summary>
		/// ������-����: ������ ����� �����, ����� ������� (Drivers.CarID)
		/// </summary>
		[Description("������-����: ������ ����� �����, ����� ������� (Drivers.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� �����, ����� ������� (Drivers.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� �����, ����� ������� (Drivers.CarID -> Cars.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterZonesList;
		/// <summary>
		/// ������-����: ������ ����� ���, ����� ������� (Drivers.ZoneID)
		/// </summary>
		[Description("������-����: ������ ����� ���, ����� ������� (Drivers.ZoneID)")]
		public string FilterZonesList { get { return _FilterZonesList; } set { _FilterZonesList = value; _NeedRequery = true; } }

		#endregion �������

		// ----------------------------

		public Driver()
			: base()
		{
			_MainTableName = "Drivers";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ �����������-��������� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_DriversFill @nID, @cIDList, " +
									"@cNameContext, " +
									"@bActual, " + 
									"@bOperable, " +
									"@bForGoodsOnly, " +
									"@cCarsList, @cCarsTypesList, " +
									"@cZonesList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_DriversFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterActual != null)
				_oParameter.Value = _FilterActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bOperable", SqlDbType.Bit);
			if (_FilterOperable != null)
				_oParameter.Value = _FilterOperable;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bForGoodsOnly", SqlDbType.Bit);
			if (_FilterForGoodsOnly != null)
				_oParameter.Value = _FilterForGoodsOnly;
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

			_oParameter = _oCommand.Parameters.Add("@cZonesList", SqlDbType.VarChar);
			if (_FilterZonesList != null)
				_oParameter.Value = _FilterZonesList;
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
				_ErrorStr = "������ ��� ��������� ������ ���������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������-�����
		/// </summary>
		public new void ClearFilters() 
		{
			_IDList = null;
			
			_FilterNameContext = null;
			_FilterActual = null;
			_FilterOperable = null;
			_FilterForGoodsOnly = null;
			_FilterCarsList = null;
			_FilterCarsTypesList = null;
			_FilterZonesList = null;
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

					_Name = r["Name"].ToString();
					_Alias = r["Alias"].ToString();

					_PassportSeries = r["PassportSeries"].ToString();
					_PassportNumber = r["PassportNumber"].ToString();
					if (!Convert.IsDBNull(r["PassportDate"]))
						_PassportDate = Convert.ToDateTime(r["PassportDate"]);
					_PassportGranted = r["PassportGranted"].ToString();

					if (!Convert.IsDBNull(r["JobTitleID"]))
						_JobTitleID = Convert.ToInt32(r["JobTitleID"]);
					_JobTitleName = r["JobTitleName"].ToString();

					_MobPhone = r["MobPhone"].ToString();

					_Photo = r["Photo"] as byte[];

					_IsDriver = true;
					_DriverID = Convert.ToInt32(r["DriverID"]);

					_DriverCategory = r["DriverCategory"].ToString();
					_DriverLicenceNumber = r["DriverLicenceNumber"].ToString();

					_Operable = Convert.ToBoolean(r["Operable"]);
					_ForGoodsOnly = Convert.ToBoolean(r["ForGoodsOnly"]);

					if (!Convert.IsDBNull(r["CarID"]))
						_CarID = Convert.ToInt32(r["CarID"]);
					_CarName = r["CarName"].ToString();

					if (!Convert.IsDBNull(r["CarTypeID"]))
						_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
					_CarTypeName = r["CarTypeName"].ToString();

					if (!Convert.IsDBNull(r["ZoneID"]))
						_ZoneID = Convert.ToInt32(r["ZoneID"]);
					_ZoneName = r["ZoneName"].ToString();
					_ZoneAlias = r["ZoneAlias"].ToString();
					
					_Actual = Convert.ToBoolean(r["Actual"]);
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ����������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ���������� (��� ������)...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������� ����������
		/// </summary>
		public new void ClearOne()
		{
			_ID = null;

			_Name = null;
			_Alias = null;

			_PassportSeries = null;
			_PassportNumber = null;
			_PassportDate = null;
			_PassportGranted = null;

			_JobTitleID = 0;
			_JobTitleName = null;

			_MobPhone = null;

			_Photo = null;

			_IsDriver = false;
			_DriverID = null;

			_DriverCategory = null;
			_DriverLicenceNumber = null;

			_IsDriver = false;
			_DriverID = null;

			_Operable = false;
			_ForGoodsOnly = false;

			_CarID = null;
			_CarName = null;
			_CarTypeID = null;
			_CarTypeName = null;
			_ZoneID = null;
			_ZoneName = null;
			_ZoneAlias = null;

			_Actual = false;
			_ERPCode = null;
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// ���������� ������ ��������
		/// </summary>
		public bool SaveOneDriver()
		{
			string _sqlCommand = "execute up_DriversSave @nEmployeeID, @nDriverID output, " +
							"@bOperable, " +
							"@bForGoodsOnly, " +
							"@cDriverCategory, @cDriverLicenceNumber, " +
							"@nCarID, @nZoneID, " +
							"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_DriversSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nEmployeeID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nDriverID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_DriverID.HasValue) 
				_oParameter.Value = _DriverID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bOperable", SqlDbType.Bit);
			_oParameter.Value = _Operable;

			_oParameter = _oCommand.Parameters.Add("@bForGoodsOnly", SqlDbType.Bit);
			_oParameter.Value = _ForGoodsOnly;

			_oParameter = _oCommand.Parameters.Add("@cDriverCategory", SqlDbType.VarChar);
			_oParameter.Value = _DriverCategory;

			_oParameter = _oCommand.Parameters.Add("@cDriverLicenceNumber", SqlDbType.VarChar);
			_oParameter.Value = _DriverLicenceNumber;

			_oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			if (_CarID.HasValue)
				_oParameter.Value = _CarID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nZoneID", SqlDbType.Int);
			if (_ZoneID.HasValue)
				_oParameter.Value = _ZoneID;
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
				_ErrorStr = "������ ��� ���������� ������ � ����������-��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ � ����������-��������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ �������� - ������� ��� ���
				if (!Convert.IsDBNull(_oCommand.Parameters["@nDriverID"].Value))
				{
					_DriverID = (int)_oCommand.Parameters["@nDriverID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ��������
		/// </summary>
		public bool DeleteOneDriver(int nEmployeeID)
		{
			String _sqlCommand = "execute up_DriversDelete @nEmployeeID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_EmployeesDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nEmployeeID", SqlDbType.Int);
			_oParameter.Value = nEmployeeID;

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
				_ErrorStr = "������ ��� �������� ������ � ����������-��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � ����������-��������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete 

        #region Get info

        public string GetDriverZonesStatistics(int DriverID)
        {
            string sResult = "";

            try
            {
                string sqlSelect = "select dbo.GetDriverZonesStatistics(" + DriverID.ToString() + ")";
                SqlCommand cmd = new SqlCommand(sqlSelect, _Connect);

                ConnectionState conState = _Connect.State;
                if (conState != ConnectionState.Open)
                    _Connect.Open();

                object reader = cmd.ExecuteScalar();
                sResult = reader.ToString();

                if (conState != ConnectionState.Open)
                    _Connect.Close();
            }
            catch (Exception ex)
            {
                _ErrorNumber = -1;
                _ErrorStr = "������ ��� ��������� ������ � ��������..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return sResult;
        }

        #endregion
    }

#endregion Driver

}
