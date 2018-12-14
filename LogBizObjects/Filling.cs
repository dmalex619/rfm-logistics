using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ �������� (�������) ������� (Filling), 
/// ��������� �������: ��� �������� (FillingType), ��� ������� (FuelType)
/// </summary>
/// 
namespace LogBizObjects
{

#region Filling 

	public class Filling: BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID �������� (Fillings.ID)
		/// </summary>
		[Description("������ ����� ID �������� (Fillings.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateFill;
		/// <summary>
		/// ���� �������� (Fillings.DateFill)
		/// </summary>
		[Description("���� �������� (Fillings.DateFill)")]
		public DateTime DateFill { get { return _DateFill; } set { _DateFill = value; } }
		
		protected int _FillingTypeID;
		/// <summary>
		/// ��� �������� - ��� (Fillings.FillingTypeID)
		/// </summary>
		[Description("��� �������� - ��� (Fillings.FillingTypeID)")]
		public int FillingTypeID { get { return _FillingTypeID; } set { _FillingTypeID = value; } }

		protected string _FillingTypeName;
		/// <summary>
		/// ��� �������� - ������������ (Fillings.FillingTypeID -> FillingsTypes.Name)
		/// </summary>
		[Description("��� �������� - ������������ (Fillings.FillingTypeID -> FillingsTypes.Name)")]
		public string FillingTypeName { get { return _FillingTypeName; } set { _FillingTypeName = value; } }

		protected bool _IsOwn;
		/// <summary>
		/// ����������� ������� (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?
		/// </summary>
		[Description("����������� ������� (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?")]
		public bool IsOwn { get { return _IsOwn; } set { _IsOwn = value; } }

		protected int? _FuelTypeID;
		/// <summary>
		/// ��� ������� - ��� (Fillings.FuelTypeID)
		/// </summary>
		[Description("��� ������� - ��� (Fillings.FuelTypeID)")]
		public int? FuelTypeID { get { return _FuelTypeID; } set { _FuelTypeID = value; } }

		protected string _FuelTypeName;
		/// <summary>
		/// ��� ������� - ������������ (Fillings.FuelTypeID -> FuelTypes.Name)
		/// </summary>
		[Description("��� ������� - ������������ (Fillings.FuelTypeID -> FuelTypes.Name)")]
		public string FuelTypeName { get { return _FuelTypeName; } set { _FuelTypeName = value; } }

		protected int? _CarID;
		/// <summary>
		/// ������ - ��� (Fillings.CarID)
		/// </summary>
		[Description("������ - ��� (Fillings.CarID)")]
		public int? CarID { get { return _CarID; } set { _CarID = value; } }

		protected string _CarName;
		/// <summary>
		/// ������ - ������������ (Fillings.CarID -> Cars.Name)
		/// </summary>
		[Description("������ - ������������ (Fillings.CarID -> Cars.Name)")]
		public string CarName { get { return _CarName; } set { _CarName = value; } }

		protected string _CarNumber;
		/// <summary>
		/// ������ - ���.����� (Fillings.CarID -> Cars.Number)
		/// </summary>
		[Description("������ - ���.����� (Fillings.CarID -> Cars.Number)")]
		public string CarNumber { get { return _CarNumber; } set { _CarNumber = value; } }

		protected int? _CarTypeID;
		/// <summary>
		/// ��� ������ - ��� (Fillings.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("��� ������ - ��� (Fillings.CarID -> Cars.CarTypeID)")]
		public int? CarTypeID { get { return _CarTypeID; } set { _CarTypeID = value; } }

		protected string _CarTypeName;
		/// <summary>
		/// ��� ������ - ������������ (Fillings.CarID -> Cars.CarTypeID -> CarsTypes.Name)
		/// </summary>
		[Description("��� ������ - ������������ (Fillings.CarID -> Cars.CarTypeID-> CarsTypes.Name)")]
		public string CarTypeName { get { return _CarTypeName; } set { _CarTypeName = value; } }

		protected int? _DriverEmployeeID;
		/// <summary>
		/// ���������-�������� - ��� (Fillings.DriverEmployeeID)
		/// </summary>
		[Description("���������-�������� - ��� (Fillings.DriverEmployeeID)")]
		public int? DriverEmployeeID { get { return _DriverEmployeeID; } set { _DriverEmployeeID = value; } }

		protected string _DriverName;
		/// <summary>
		/// ���������-�������� - ������������ (Fillings.DriverEmployeeID -> Employees.ID --> Drivers.Name)
		/// </summary>
		[Description("���������-�������� - ������������ (Fillings.DriverEmployeeID -> Employees.ID --> Drivers.Name)")]
		public string DriverName { get { return _DriverName; } set { _DriverName = value; } }

		protected decimal _QntFilled;
		/// <summary>
		/// ���������� ������������� �������, � (Fillings.QntFilled)
		/// </summary>
		[Description("���������� ������������� �������, � (Fillings.QntFilled)")]
		public decimal QntFilled { get { return _QntFilled; } set { _QntFilled = value; } }

		protected decimal _Amount;
		/// <summary>
		/// ��������� ������������� �������, ���. (Fillings.Amount)
		/// </summary>
		[Description("��������� ������������� �������, ���. (Fillings.Amount)")]
		public decimal Amount { get { return _Amount; } set { _Amount = value; } }

		protected decimal _Price;
		/// <summary>
		/// ���� ������������� �������, ���./� (Fillings.Amount / Qnt)
		/// </summary>
		[Description("���� ������������� �������, ���./� (Fillings.Amount / Qnt)")]
		public decimal Price { get { return _Price; } set { _Price = value; } }

		protected int? _WayBillID;
		/// <summary>
		/// ������� ���� - ��� (Fillings.WayBillID)
		/// </summary>
		[Description("������� ���� - ��� (Fillings.WayBillID)")]
		public int? WayBillID { get { return _WayBillID; } set { _WayBillID = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � �������� (Fillings.Note)
		/// </summary>
		[Description("���������� � �������� (Fillings.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }
		
		protected string _ERPCode;
		/// <summary>
		/// ��� �������� � host-������� (Fillings.ERPCode)
		/// </summary>
		[Description("��� �������� � host-������� (Fillings.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� �������� - ��������� ���� ������� (Fillings.DateFill)
		/// </summary>
		[Description("������-����: ���� �������� - ��������� ���� ������� (Fillings.DateFill)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� �������� - �������� ���� ������� (Fillings.DateFill)
		/// </summary>
		[Description("������-����: ���� �������� - �������� ���� ������� (Fillings.DateFill)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }
		
		protected string _FilterFillingsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� ��������, ����� ������� (Fillings.FillingTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� ��������, ����� ������� (Fillings.FillingTypeID)")]
		public string FilterFillingsTypesList { get { return _FilterFillingsTypesList; } set { _FilterFillingsTypesList = value; _NeedRequery = true; } }

		protected string _FilterFuelTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� �������, ����� ������� (Fillings.FuelTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� �������, ����� ������� (Fillings.FuelTypeID)")]
		public string FilterFuelTypesList { get { return _FilterFuelTypesList; } set { _FilterFuelTypesList = value; _NeedRequery = true; } }

		protected bool? _FilterIsOwn;
		/// <summary>
		/// ������-����: ����������� ������� (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?
		/// </summary>
		[Description("������-����: ����������� ������� (Fillings.FillingTypeID -> FillingsTypes.IsOwn)?")]
		public bool? FilterIsOwn { get { return _FilterIsOwn; } set { _FilterIsOwn = value; _NeedRequery = true; } }

		protected string _FilterCarsList;
		/// <summary>
		/// ������-����: ������ ����� �����, ����� ������� (Fillings.CarID)
		/// </summary>
		[Description("������-����: ������ ����� �����, ����� ������� (Fillings.CarID)")]
		public string FilterCarsList { get { return _FilterCarsList; } set { _FilterCarsList = value; _NeedRequery = true; } }

		protected string _FilterCarsTypesList;
		/// <summary>
		/// ������-����: ������ ����� ����� �����, ����� ������� (Fillings.CarID -> Cars.CarTypeID)
		/// </summary>
		[Description("������-����: ������ ����� ����� �����, ����� ������� (Fillings.CarID -> Cars.CarTypeID)")]
		public string FilterCarsTypesList { get { return _FilterCarsTypesList; } set { _FilterCarsTypesList = value; _NeedRequery = true; } }

		protected string _FilterDriversEmployeesList;
		/// <summary>
		/// ������-����: ������ ����� �����������-���������, ����� ������� (Fillings.DriversEmployeeID)
		/// </summary>
		[Description("������-����: ������ ����� �����������-���������, ����� ������� (Fillings.DriversEmployeeID)")]
		public string FilterDriversEmployeesList { get { return _FilterDriversEmployeesList; } set { _FilterDriversEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterWayBillsList;
		/// <summary>
		/// ������-����: ������ ����� ������� ������, ����� ������� (Fillings.WayBillID)
		/// </summary>
		[Description("������-����: ������ ����� ������� ������, ����� ������� (Fillings.WayBillID)")]
		public string FilterWayBillsList { get { return _FilterWayBillsList; } set { _FilterWayBillsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableFillingsTypes;
		/// <summary>
		/// ������� ����� �������� FillingsTypes
		/// </summary>
		[Description("������� ����� �������� FillingsTypes")]
		public DataTable TableFillingsTypes { get { return _TableFillingsTypes; } }

		protected DataTable _TableFuelTypes;
		/// <summary>
		/// ������� ����� �������� FuelTypes
		/// </summary>
		[Description("������� ����� �������� FuelTypes")]
		public DataTable TableFuelTypes { get { return _TableFuelTypes; } }

		#endregion �������

		// ----------------------------

		public Filling()
			: base()
		{
			_MainTableName = "Fillings";
			_ColumnID = "ID";
			_ColumnName = "DateFill";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ �������� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_FillingsFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@cFillingsTypesList, " +
									"@cFuelTypesList, " +
									"@bIsOwn, " +
									"@cCarsList, " +
									"@cCarsTypesList, " +
									"@cDriversEmployeesList, " +
									"@cWayBillsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_FillingsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cFillingsTypesList", SqlDbType.VarChar);
			if (_FilterFillingsTypesList != null)
				_oParameter.Value = _FilterFillingsTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cFuelTypesList", SqlDbType.VarChar);
			if (_FilterFuelTypesList != null)
				_oParameter.Value = _FilterFuelTypesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsOwn", SqlDbType.Bit);
			if (_FilterIsOwn != null)
				_oParameter.Value = _FilterIsOwn;
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

			_oParameter = _oCommand.Parameters.Add("@cWayBillsList", SqlDbType.VarChar);
			if (_FilterWayBillsList != null)
				_oParameter.Value = _FilterWayBillsList;
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
				_ErrorStr = "������ ��� ��������� ������ ��������..." + Convert.ToChar(13) + ex.Message;
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
			_FilterFillingsTypesList = null;
			_FilterFuelTypesList = null;
			_FilterIsOwn = null;
			_FilterCarsList = null;
			_FilterCarsTypesList = null;
			_FilterDriversEmployeesList = null;
			_FilterWayBillsList = null;
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
					_DateFill = Convert.ToDateTime(r["DateFill"]);

					_FillingTypeID = Convert.ToInt32(r["FillingTypeID"]);
					_FillingTypeName = r["FillingTypeName"].ToString();
					_FuelTypeID = Convert.ToInt32(r["FuelTypeID"]);
					_FuelTypeName = r["FuelTypeName"].ToString();
					_IsOwn = Convert.ToBoolean(r["IsOwn"]);

					_CarID = Convert.ToInt32(r["CarID"]);
					_CarName = r["CarName"].ToString();
					_CarTypeID = Convert.ToInt32(r["CarTypeID"]);
					_CarTypeName = r["CarTypeName"].ToString();
					_DriverEmployeeID = Convert.ToInt32(r["DriverEmployeeID"]);
					_DriverName = r["DriverName"].ToString();

					_QntFilled = Convert.ToDecimal(r["QntFilled"]);
					_Amount = Convert.ToDecimal(r["Amount"]);
					_Price = Convert.ToDecimal(r["Price"]);

					if (!Convert.IsDBNull(r["WayBillID"]))
						_WayBillID = Convert.ToInt32(r["WayBillID"]);

					_Note = r["Note"].ToString();
					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ��������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � �������� (��� ������)...";
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

			_DateFill = DateTime.Now.Date;

			_FillingTypeID = 0;
			_FillingTypeName = "";
			_FuelTypeID = 0;
			_FuelTypeName = "";
			_IsOwn = false;

			_CarID = null;
			_CarName = null;
			_CarNumber = null;
			_CarTypeID = null;
			_CarTypeName = null;
			_DriverEmployeeID = null;
			_DriverName = null;

			_WayBillID = null;

			_Note = "";
			_ERPCode = null; 

		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// ���������� ������ ��������
		/// </summary>

		public bool SaveOne()
		{
			string _sqlCommand = "execute up_FillingsSave @nFillingID output, " +
					"@dDateFill, @nWayBillID, @nCarID, @nDriverEmployeeID, " + 
					"@nFillingTypeID, @nFuelTypeID, " + 
					"@nQntFilled, @nAmount, " +
					"@cNote, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_FillingsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nFillingID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDateFill", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateFill;

			_oParameter = _oCommand.Parameters.Add("@nWayBillID", SqlDbType.Int);
			if (_WayBillID.HasValue)
				_oParameter.Value = _WayBillID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nCarID", SqlDbType.Int);
			_oParameter.Value = _CarID;

			_oParameter = _oCommand.Parameters.Add("@nDriverEmployeeID", SqlDbType.Int);
			_oParameter.Value = _DriverEmployeeID;

			_oParameter = _oCommand.Parameters.Add("@nFillingTypeID", SqlDbType.Int);
			_oParameter.Value = _FillingTypeID;

			_oParameter = _oCommand.Parameters.Add("@nFuelTypeID", SqlDbType.Int);
			_oParameter.Value = _FuelTypeID;

			_oParameter = _oCommand.Parameters.Add("@nQntFilled", SqlDbType.Decimal);
			_oParameter.Precision = 6;
			_oParameter.Scale = 1;
			_oParameter.Value = _QntFilled;

			_oParameter = _oCommand.Parameters.Add("@nAmount", SqlDbType.Money);
			_oParameter.Value = _Amount;

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
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ���������� ������ � �������� �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ � �������� �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ����� �������� - ������� �� ���
				if ((!_ID.HasValue || _ID == 0) && 
					!Convert.IsDBNull(_oCommand.Parameters["@nFillingID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nFillingID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ������ � �������� �������
		/// </summary>
		public bool DeleteOne(int nFillingID)
		{
			String _sqlCommand = "execute up_FillingsDelete @nFillingID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_FillingsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nFillingID", SqlDbType.Int);
			_oParameter.Value = nFillingID;

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
				_ErrorStr = "������ ��� �������� ������ � �������� �������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ������ � �������� �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete


		#region �������

		#region TableFillingsTypes

		/// <summary>
		/// ��������� ������� ����� �������� (TableFillingsTypes)
		/// </summary>
		public bool FillTableFillingsTypes()
		{
			string sqlSelect = 
				"select ID, Name, "  + 
						"IsOwn, " +
						"ERPCode " + 
					"from FillingsTypes " +
					"where 1 = 1 ";
			if (_FilterFillingsTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterFillingsTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_TableFillingsTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableFillingsTypes, "TableFillingsTypes ");
				_TableFillingsTypes.PrimaryKey = new DataColumn[] { _TableFillingsTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ����� ��������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TableFillingsTypes

		#region TableFuelTypes

		/// <summary>
		/// ��������� ������� ����� ������� (TableFuelTypes)
		/// </summary>
		public bool FillTableFuelTypes()
		{
			string sqlSelect =
				"select ID, Name, " +
						"ERPCode " +
					"from FuelTypes " +
					"where 1 = 1 ";
			if (_FilterFuelTypesList != null)
			{
				sqlSelect += " and charindex(',' + ltrim(str(ID)) + ',', ',' + '" + FilterFuelTypesList + "' + ',') > 0";
			}
			sqlSelect += " order by Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			try
			{
				_TableFuelTypes = FillReadings(new SqlDataAdapter(_oCommand), _TableFuelTypes, "TableFuelTypes");
				_TableFuelTypes.PrimaryKey = new DataColumn[] { _TableFuelTypes.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ����� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TableFuelTypes

		#endregion �������

	}

#endregion Filling

}
