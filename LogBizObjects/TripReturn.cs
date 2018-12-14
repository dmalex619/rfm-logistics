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
/// ������-������ ������� � ����� (�������) (TripReturn)
/// </summary>
/// 
namespace LogBizObjects
{

#region TripReturn

	public class TripReturn : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// ������ ID ��������� (TripsReturns.ID)
		/// </summary>
		[Description("������ ID ��������� (TripsReturns.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateReturn;
		/// <summary>
		/// ���� �������� (TripsReturns.DateReturn)
		/// </summary>
		[Description("���� �������� (TripsReturns.DateReturn)")]
		public DateTime DateReturn { get { return _DateReturn; } set { _DateReturn = value; } }


		protected bool _AutoCreated;
		/// <summary>
		/// ������ ������������� (��� ��������� �����) (TripsReturns.AutoCreated)?
		/// </summary>
		[Description("������ ������������� (��� ��������� �����) (TripsReturns.AutoCreated)?")]
		public bool AutoCreated { get { return _AutoCreated; } set { _AutoCreated = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// ����-����� �������� (TripsReturns.DateCreate)?
		/// </summary>
		[Description("����-����� �������� (TripsReturns.DateCreate)?")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected int? _UserCreateID;
		/// <summary>
		/// ������������, ���������� ������� - ��� (TripsReturns.UserCreateID)
		/// </summary>
		[Description("������������, ���������� ������� - ��� (TripsReturns.UserCreateID)")]
		public int? UserCreateID { get { return _UserCreateID; } set { _UserCreateID = value; } }

		protected string _UserCreateName;
		/// <summary>
		/// ������������, ���������� ������� - ��� (TripsReturns.UserCreateID -> _Users.Name)
		/// </summary>
		[Description("������������, ���������� ������� - ��� (TripsReturns.UserCreateID -> _Users.Name)")]
		public string UserCreateName { get { return _UserCreateName; } set { _UserCreateName = value; } }



		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (TripsReturns.OwnerID)
		/// </summary>
		[Description("�������� ������ - ��� (TripsReturns.OwnerID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// �������� ������ - ������������ (TripsReturns.OwnerID -> GoodsStates.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (TripsReturns.OwnerID -> GoodsStates.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }


		protected int? _GoodStateID;
		/// <summary>
		/// ��������� ������ - ��� (TripsReturns.GoodStateID)
		/// </summary>
		[Description("��������� ������ - ��� (TripsReturns.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// ��������� ������ - ������������ (TripsReturns.GoodStateID -> GoodsStates.Name)
		/// </summary>
		[Description("��������� ������ - ������������ (TripsReturns.GoodStateID -> GoodsStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (TripsReturns.TripID)
		/// </summary>
		[Description("���� - ��� (TripsReturns.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected string _TripAlias;
		/// <summary>
		/// ���� - �������� (TripsReturns.TripID -> Trips.Alias)
		/// </summary>
		[Description("���� - �������� (TripsReturns.TripID -> Trips.Alias)")]
		public string TripAlias { get { return _TripAlias; } set { _TripAlias = value; } }

        protected string _Note;
		/// <summary>
		/// ���������� � �������� (TripsReturns.Note)
		/// </summary>
		[Description("���������� � �������� (TripsReturns.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected bool _ReadyForWMS;
		/// <summary>
		/// ������ � �������� � ��������� ������� (TripsReturns.ReadyForWMS)?
		/// </summary>
		[Description("������ � �������� � ��������� ������� (TripsReturns.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }

		protected bool _SentToWMS;
		/// <summary>
		/// �������� � ��������� ������� (TripsReturns.SentToWMS)?
		/// </summary>
		[Description("�������� � ��������� ������� (TripsReturns.SentToWMS)?")]
		public bool SentToWMS { get { return _SentToWMS; } set { _SentToWMS = value; } }


		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� �������� (TripsReturns.DateConfirm)?
		/// </summary>
		[Description("����-����� ������������� �������� (TripsReturns.DateConfirm)?")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// ������� ����������� (TripsReturns.DateConfirm is not Null)?
		/// </summary>
		[Description("������� ����������� (TripsReturns.DateConfirm is not Null)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (TripsReturns.HostID)
		/// </summary>
		[Description("Host - ��� (TripsReturns.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (TripsReturns.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (TripsReturns.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// ��� �������� � host-������� (TripsReturns.ERPCode)
		/// </summary>
		[Description("��� �������� � host-������� (TripsReturns.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (TripsReturns.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (TripsReturns.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }
		

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� �������� - ��������� ���� ������� (TripsReturns.DateTripReturn)
		/// </summary>
		[Description("������-����: ���� �������� - ��������� ���� ������� (TripsReturns.DateTripReturn)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� �������� - �������� ���� ������� (TripsReturns.DateTripReturn)
		/// </summary>
		[Description("������-����: ���� �������� - �������� ���� ������� (TripsReturns.DateTripReturn)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }


		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// ������-����: ������� ����� � �������� � ��������� ������� (TripsReturns.ReadyForWMS)?
		/// </summary>
		[Description("������-����: ������� ����� � �������� � ��������� ������� (TripsReturns.ReadyForPrint)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }


		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: ������� ����������� (TripsReturns.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: ������� ����������� (TripsReturns.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }


		protected bool? _FilterAutoCreated;
		/// <summary>
		/// ������-����: ������� ������������� (TripsReturns.AutoCreated)?
		/// </summary>
		[Description("������-����: ������� �������������  (TripsReturns.AutoCreated)?")]
		public bool? FilterAutoCreated { get { return _FilterAutoCreated; } set { _FilterAutoCreated = value; _NeedRequery = true; } }

		/*
		protected string _FilterGoodsStatesList;
		/// <summary>
		/// ������-����: ������ ����� ��������� ������, ����� ������� (TripsReturns.GoodsStateID)
		/// </summary>
		[Description("������-����: ������ ����� ��������� ������, ����� ������� (TripsReturns.GoodsStateID)")]
		public string FilterGoodsStatesList { get { return _FilterGoodsStatesList; } set { _FilterGoodsStatesList = value; _NeedRequery = true; } }
		*/
		
		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (TripsReturns.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (TripsReturns.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// ������-����: ������ ����� ����������, ����� ������� (TripsReturns.OwnerID)
		/// </summary>
		[Description("������-����: ������ ����� ����������, ����� ������� (TripsReturns.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (TripsReturns.ID --> TripsReturnsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (TripsReturns.ID --> TripsReturnsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (TripsReturns.ID --> TripsReturnsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (TripsReturns.ID --> TripsReturnsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableTripsReturnsGoods;
		/// <summary>
		/// ������ ������� � �������� TripsReturnsGoods
		/// </summary>
		[Description("������ ������� � �������� TripsReturnsGoods")]
		public DataTable TableTripsReturnsGoods { get { return _TableTripsReturnsGoods; } }

		#endregion �������


		// -------------------------------------

		public TripReturn() : base()
		{
			_MainTableName = "TripsReturns";
			_ColumnID = "ID";
			_ColumnName = "DateReturn";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ��������� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_TripsReturnsFill @nID, @cIDList, " +
									"@cHostsList, " +
									"@dDateBeg, @dDateEnd, " +
									"@bReadyForWMS, " +
									"@bIsConfirmed, " +
									"@bAutoCreated, " +
									"@cTripsList, " +
									"@cOwnersList, " +
									"@cPackingsList, @cGoodsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsReturnsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@bAutoCreated", SqlDbType.Bit);
			if (_FilterAutoCreated != null)
				_oParameter.Value = _FilterAutoCreated;
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
				_ErrorStr = "������ ��� ��������� ������ ���������..." + Convert.ToChar(13) + ex.Message;
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
			_FilterReadyForWMS = null;
			_FilterIsConfirmed = null;
			_FilterAutoCreated = null;
			/*
			_FilterOwnersList = null;
			_FilterGoodsStatesList = null;
			*/
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
					_DateReturn = Convert.ToDateTime(r["DateReturn"]);
					_DateCreate = Convert.ToDateTime(r["DateCreate"]);
					_AutoCreated = Convert.ToBoolean(r["AutoCreated"]);

					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					if (!Convert.IsDBNull(r["GoodStateID"]))
						_GoodStateID = Convert.ToInt32(r["GoodStateID"]);
					_GoodStateName = r["GoodStateName"].ToString();

					if (!Convert.IsDBNull(r["TripID"]))
						_TripID = Convert.ToInt32(r["TripID"]);
					_TripAlias = r["TripAlias"].ToString();

					_Note = r["Note"].ToString();

					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);

					_ReadyForWMS = Convert.ToBoolean(r["ReadyForWMS"]);
					_SentToWMS = Convert.ToBoolean(r["SentToWMS"]);

					if (!Convert.IsDBNull(r["UserCreateID"]))
						_UserCreateID = Convert.ToInt32(r["UserCreateID"]);
					_UserCreateName = r["UserCreateName"].ToString();
					if (!Convert.IsDBNull(r["DateCreate"]))
						_DateCreate = Convert.ToDateTime(r["DateCreate"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ �� ��������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ �� �������� (��� ������)...";
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
			_DateReturn = DateTime.Now.Date;
			_DateCreate = DateTime.Now.Date;
			_AutoCreated = false; 

			_OwnerID = null;
			_OwnerName = null;
			_GoodStateID = null;
			_GoodStateName = null;

			_TripID = null;
			_TripAlias = null;

			_Note = "";

			_DateConfirm = null;
			_IsConfirmed = false;

			_ReadyForWMS = false;
			_SentToWMS = false;

			_DateCreate = null;
			_UserCreateID = null;
			_UserCreateName = null;

			_HostID = null;
			_HostName = null;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// ���������� ������ ��������
		/// </summary>
		public bool Save()
		{
			return (Save(null));
		}

		public bool Save(int? nUserCreateID)
		{
			string _sqlCommand = "execute up_TripsReturnsSave @nTripReturnID output, " +
									"@dDateReturn, " +
									"@bAutoCreated, " + 
									"@nOwnerID, @nGoodStateID, " +
									"@cNote, " +
									"@nTripID, " +
									"@nUserCreateID, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDateReturn", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateReturn;

			_oParameter = _oCommand.Parameters.Add("@bAutoCreated", SqlDbType.Bit);
			_oParameter.Value = _AutoCreated;
			
			_oParameter = _oCommand.Parameters.Add("@nOwnerID", SqlDbType.Int);
			if (_OwnerID.HasValue)
				_oParameter.Value = _OwnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nGoodStateID", SqlDbType.Int);
			if (_GoodStateID.HasValue)
				_oParameter.Value = _GoodStateID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = "";

			_oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			if (_TripID.HasValue)
				_oParameter.Value = _TripID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserCreateID", SqlDbType.Int);
			if (nUserCreateID.HasValue)
				_oParameter.Value = nUserCreateID;
			else
				_oParameter.Value = 0; // DBNull.Value;

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
				if (TableTripsReturnsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableTripsReturnsGoods, "#TripsReturnsGoods", _Connect);
				}

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� ��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ��������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ �������� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nTripReturnID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nTripReturnID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ��������
		/// </summary>
		public bool Delete(int nTripReturnID)
		{
			String _sqlCommand = "execute up_TripsReturnsDelete @nTripReturnID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = nTripReturnID;

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
				_ErrorStr = "������ ��� ������� �������� ��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ��������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������������� ������ ��������
		/// </summary>
		public bool AutoCreate(int nTripID)
		{
			string _sqlCommand = "execute up_TripsReturnsAutoCreate @nTripID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsAutoCreate parameters

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
				_ErrorStr = "������ ��� ������� ��������������� ������� ��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������������� ������� ��������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// ������������� �������� 
		/// </summary>
		public bool Confirm()
		{
			string _sqlCommand = "execute up_TripsReturnsConfirm @nTripReturnID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_TripsReturnsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
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
				if (_TableTripsReturnsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(_TableTripsReturnsGoods, "#TripsReturnsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������������� ��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� ��������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
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
			string _sqlCommand = "execute up_TripsReturnsUnConfirm @nTripReturnID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnTripsReturnsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� ��������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� ��������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Set/Clear 

		#region ReadyForWMS

		/// <summary>
		/// ���������/�������� ������� "������� ����� � �������� � ��������� �������"
		/// nUserID: �� ���.
		/// </summary>
		public bool SetReadyForWMS(int nTripReturnID)
		{
			return (SetReadyForWMS(nTripReturnID, false, 0));
		}

		public bool SetReadyForWMS(int nTripReturnID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "execute up_TripsReturnsSetReadyForWMS @nTripReturnID, @bClear, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsSetReadyForWMS parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = nTripReturnID;

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

		#endregion Set/Clear 


		#region �������

		#region TripsReturnsGoods

		/// <summary>
		/// ��������� ������� ������� � �������� TableTripsReturnsGoods
		/// </summary>
		public bool FillTableTripsReturnsGoods(int nTripReturnID)
		{
			string sqlSelect = "execute up_TripsReturnsGoodsFill @nTripReturnID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsReturnsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = nTripReturnID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableTripsReturnsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableTripsReturnsGoods, "TableTripsReturnsGoods");
				_TableTripsReturnsGoods.PrimaryKey = new DataColumn[] { _TableTripsReturnsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ������� � ��������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ��������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableTripsReturnsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableTripsReturnsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ��������...\r\n" +
								"�� ��������� ��� ��������...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TripsReturnsGoods

		#endregion �������

	}

#endregion TripReturn

}
