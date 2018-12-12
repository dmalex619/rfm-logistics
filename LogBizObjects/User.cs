using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ������������ (User)
/// </summary>
/// 
namespace LogBizObjects
{
	public class User : BizObject
	{
		protected int? _UserID;
		/// <summary>
		/// ��� ID ������ ������������ (_Users.ID)
		/// </summary>
		[Description("ID ������ ������������ (_Users.ID)")]
		public int? UserID { get { return ID; } set { ID = value; } }

		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ������������� (_Users.ID)
		/// </summary>
		[Description("������ ID ������������� (_Users.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _Name;
		/// <summary>
		/// ��� ������������ (_Users.Name)
		/// </summary>
		[Description("��� ������������ (_Users.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _BarCode;
		/// <summary>
		/// �����-��� ������������ (_Users.BarCode)
		/// </summary>
		[Description("�����-��� ������������ (_Users.BarCode)")]
		public string BarCode { get { return _BarCode; } set { _BarCode = value; } }

		protected string _Password;
		/// <summary>
		/// ������ ������������ (_Users.Password)
		/// </summary>
		[Description("������ ������������ (_Users.Password)")]
		public string Password { get { return _Password; } set { _Password = value; } }

		protected string _Alias;
		/// <summary>
		/// ������� ��� ������������ (_Users.Alias)
		/// </summary>
		[Description("������� ��� ������������ (_Users.Alias)")]
		public string Alias { get { return _Alias; } set { _Alias = value; } }

		protected string _LocPath;
		/// <summary>
		/// ��������� ������� ������������ (_Users.LocPath)
		/// </summary>
		[Description("��������� ������� ������������ (_Users.LocPath)")]
		public string LocPath { get { return _LocPath; } set { _LocPath = value; } }

		protected string _NetPath;
		/// <summary>
		/// ������� ������� ������������ (_Users.NetPath)
		/// </summary>
		[Description("������� ������� ������������ (_Users.NetPath)")]
		public string NetPath { get { return _NetPath; } set { _NetPath = value; } }

		protected byte[] _Photo;
		/// <summary>
		/// ���� ������������ (_Users.Photo)
		/// </summary>
		[Description("���� ������������ (_Users.Photo)")]
		public byte[] Photo { get { return _Photo; } set { _Photo = value; } }

		protected bool _IsAdmin;
		/// <summary>
		/// ������������� (_Users.IsAdmin)?
		/// </summary>
		[Description("������������� (_Users.IsAdmin)?")]
		public bool IsAdmin { get { return _IsAdmin; } set { _IsAdmin = value; } }

		protected int? _EmployeeID;
		/// <summary>
		/// ��� ���������� (_Users.EmployeeID)
		/// </summary>
		[Description("��� ���������� (_Users.EmployeeID)")]
		public int? EmployeeID { get { return _EmployeeID; } set { _EmployeeID = value; } }

		protected string _EmployeeName;
		/// <summary>
		/// ��� ���������� (_Users.EmployeeID -> Employees.Name)
		/// </summary>
		[Description("��� ���������� (_Users.EmployeeID -> Employees.Name)")]
		public string EmployeeName { get { return _EmployeeName; } set { _EmployeeName = value; } }

		protected string _EmployeeAlias;
		/// <summary>
		/// ���-�������� ���������� (_Users.EmployeeID -> Employees.Alias)
		/// </summary>
		[Description("���-�������� ���������� (_Users.EmployeeID -> Employees.Alias)")]
		public string EmployeeAlias { get { return _EmployeeAlias; } set { _EmployeeAlias = value; } }

		protected bool _Actual;
		/// <summary>
		/// ��������� (_Users.Actual)?
		/// </summary>
		[Description("��������� (_Users.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected int? _HostID;
		/// <summary>
		/// Host - ��� (_Users.HostID)
		/// </summary>
		[Description("Host - ��� (_Users.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (_Users.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (_Users.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� ������������ � host-������� (_Users.ERPCode)
		/// </summary>
		[Description("��� ������������ � host-������� (_Users.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		protected int? _RoleID; // ��� ��������� ������ ������������� � ������ ���� 
		/// <summary>
		/// ID ������ ���� (_Roles.ID)
		/// </summary>
		[Description("ID ������ ���� (_Roles.ID)")]
		public int? RoleID { get { return _RoleID; } set { _RoleID = value; } }

		#endregion ����, ��������

		#region �������

		protected bool? _FilterActual;
		/// <summary>
		/// ������-����: ������������
		/// </summary>
		[Description("������-����: A����������� (Users.Actual)")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; } }

		protected bool? _FilterRoleActual;
		/// <summary>
		/// ������-����: ���������� ����?
		/// </summary>
		[Description("������-����: ���������� ����?")]
		public bool? FilterRoleActual { get { return _FilterRoleActual; } set { _FilterRoleActual = value; } }

		#endregion �������

		#region ������� 

		protected DataTable _TableRoles;
		/// <summary>
		/// ������� ���������������� ����� _Roles
		/// </summary>
		[Description("������� ���������������� ����� _Roles")]
		public DataTable TableRoles { get { return _TableRoles; } }

		protected DataTable _TableUsersRoles;
		/// <summary>
		/// ������� ���������� �����-������������� _UsersRoles
		/// </summary>
		[Description("������� ���������� �����-������������� _UsersRoles")]
		public DataTable TableUsersRoles { get { return _TableUsersRoles; } }

		protected DataTable _TableRolesForUser;
		/// <summary>
		/// ������� ����� ��� ������ ������������ (� ����� IsUsed)
		/// </summary>
		[Description("������� ����� ��� ������ ������������ (� ����� IsUsed)")]
		public DataTable TableRolesForUser { get { return _TableRolesForUser; } }

		#endregion �������

		// ----------------------------

		public User()
			: base()
		{
			_MainTableName = "User";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}

		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_UsersFill @nID, @cIDList, " +
											"@cBarCode, @bActual";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_UsersFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cBarCode", SqlDbType.VarChar);
			if (BarCode != null)
				_oParameter.Value = BarCode;
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
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_MainTable.PrimaryKey = new DataColumn[] { _MainTable.Columns[_ColumnID] };
				_NeedRequery = false;
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ������ �������������..." + Convert.ToChar(13) + ex.Message;
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
			_FilterActual = null;
			_FilterRoleActual = null;
			UserID = null;
			RoleID = null;
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
					_Password = r["Password"].ToString();
					_LocPath = r["LocPath"].ToString();
					_NetPath = r["NetPath"].ToString();
					_Photo = r["Photo"] as byte[];
					_IsAdmin = Convert.ToBoolean(r["IsAdmin"]);
					_Actual = Convert.ToBoolean(r["Actual"]);
					if (!Convert.IsDBNull(r["EmployeeID"]))
					{
						_EmployeeID = Convert.ToInt32(r["EmployeeID"]);
						_EmployeeName = r["EmployeeName"].ToString();
						_EmployeeAlias = r["EmployeeAlias"].ToString();
					}
					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ������������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ������������ (��� ������)...";
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
			_Password = null;
			_LocPath = null;
			_NetPath = null;
			_Photo = null;
			_IsAdmin = false;
			_EmployeeID = null;
			_EmployeeName = null;
			_EmployeeAlias = null;
			_Actual = false;
			_HostID = null;
			_HostName = null;
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// ���������� ������ ������������
		/// </summary>
		public bool SaveOne()
		{
			if (_ID == null)
			{
				_ErrorNumber = -20;
				_ErrorStr = "�� ������ ��������� ������������...";
				RFMMessage.MessageBoxError(_ErrorStr);
				return (false);
			}

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

			RFMUtilities.DataTableToTempTable(TableRolesForUser, "#RolesForUser", _Connect);

			string _sqlCommand = "execute up_UsersSave @nUserID output, " + 
					"@cUserName, " +
					"@cPassword, " + 
					"@cAlias, " +
					"@cLocPath, @cNetPath, " + 
					"@bIsAdmin, " + 
					"@nEmployeeID, " +
					"@bActual, " +
					"@nHostID, " + 
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_UsersSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@cUserName", SqlDbType.VarChar);
			_oParameter.Value = _Name;

			_oParameter = _oCommand.Parameters.Add("@cPassword", SqlDbType.VarChar);
			_oParameter.Value = _Password; 

			_oParameter = _oCommand.Parameters.Add("@cAlias", SqlDbType.VarChar);
			if (_Alias != null)
				_oParameter.Value = _Alias;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cLocPath", SqlDbType.VarChar);
			_oParameter.Value = _LocPath;

			_oParameter = _oCommand.Parameters.Add("@cNetPath", SqlDbType.VarChar);
			_oParameter.Value = _NetPath;

			_oParameter = _oCommand.Parameters.Add("@bIsAdmin", SqlDbType.Bit);
			_oParameter.Value = _IsAdmin;

			_oParameter = _oCommand.Parameters.Add("@nEmployeeID", SqlDbType.Int);
			if (_EmployeeID.HasValue) 
				_oParameter.Value = _EmployeeID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			_oParameter.Value = _Actual;

			_oParameter = _oCommand.Parameters.Add("@nHostID", SqlDbType.Int);
			if (_HostID.HasValue)
				_oParameter.Value = _HostID;
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
				_ErrorStr = "������ ��� ���������� ������ ������������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ ������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ ������������ - ������� ��� ���
				if (_ID == 0 && 
					!Convert.IsDBNull(_oCommand.Parameters["@nUserID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nUserID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ���������� ���� ������������
		/// </summary>
		public bool SaveOnePhoto()
		{
			string _sqlCommand = "execute up_UsersPhotoSave @nUserID, " +
					"@bPhoto, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_UsersPhotoSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ���������� ���� ������������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ���� ������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ������������
		/// </summary>
		public bool DeleteData(int nUserID)
		{
			String _sqlCommand = "execute up_UsersDelete @nUserID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_UsersDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			_oParameter.Value = nUserID;
			
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
				_ErrorStr = "������ ��� �������� ������ � ������������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � ������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region �������

		/// <summary>
		/// ��������� ������� ����� (TableRoles)
		/// </summary>
		public bool FillTableRoles()
		{
			string sqlSelect = "execute up_RolesFill @nID, @bActual";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_RolesFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_ID != null)
				_oParameter.Value = ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterRoleActual != null)
				_oParameter.Value = _FilterRoleActual;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableRoles = FillReadings(new SqlDataAdapter(_oCommand), _TableRoles, "TableRoles");
				_TableRoles.PrimaryKey = new DataColumn[] { _TableRoles.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ���������������� �����..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ���������� �����-������������� (TableUsersRoles), ������ ���������� 
		/// </summary>
		public bool FillTableUsersRoles()
		{
			string sqlSelect = "execute up_UsersRolesFill @nUserID, @nRoleID";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_UsersRolesFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			if (UserID != null)
				_oParameter.Value = UserID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nRoleID", SqlDbType.Int);
			if (RoleID != null)
				_oParameter.Value = RoleID;
			else
				_oParameter.Value = DBNull.Value;

			#endregion

			try
			{
				_TableUsersRoles = FillReadings(new SqlDataAdapter(_oCommand), _TableUsersRoles, "TableUsersRoles");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� ��������� ������ ���������� �����/�������������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ����� ��� ������ ������������ (TableRolesForUser), ��� ���������� ����
		/// </summary>
		public bool FillTableRolesForUser(int nUserID)
		{
			string sqlSelect = "execute up_RolesForUserFill @nUserID";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_RolesForUserFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nUserID", SqlDbType.Int);
			_oParameter.Value = UserID;

			#endregion

			try
			{
				_TableRolesForUser = FillReadings(new SqlDataAdapter(_oCommand), _TableRolesForUser, "TableRolesForUser");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -13;
				_ErrorStr = "������ ��� ��������� ������ ����� ��� ������������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������ ��� ������ (�� ��������)
		/// </summary>
		public bool FillDataTree(bool bActual)
		{
			string sqlSelect = "select * from .dbo.UsersTree(" + ((bActual) ? "1" : "0") + ") " +
				"order by ParentID, Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableDataTree");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "������ ��� ��������� �������������� ������ (������) �������������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion �������

	}
}
