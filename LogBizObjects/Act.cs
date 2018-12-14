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
/// ������-������ ��� (Act)
/// </summary>
/// 
namespace LogBizObjects
{

#region Act

	public class Act : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// ������ ID ����� (Acts.ID)
		/// </summary>
		[Description("������ ID ����� (Acts.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateAct;
		/// <summary>
		/// ���� ���� (Acts.DateAct)
		/// </summary>
		[Description("���� ���� (Acts.DateAct)")]
		public DateTime DateAct { get { return _DateAct; } set { _DateAct = value; } }


		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (Acts.OwnerID)
		/// </summary>
		[Description("�������� ������ - ��� (Acts.OwnerID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// �������� ������ - ������������ (Acts.OwnerID -> GoodsStates.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (Acts.OwnerID -> GoodsStates.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }


		protected int? _GoodStateID;
		/// <summary>
		/// ��������� ������ - ��� (Acts.GoodStateID)
		/// </summary>
		[Description("��������� ������ - ��� (Acts.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// ��������� ������ - ������������ (Acts.GoodStateID -> GoodsStates.Name)
		/// </summary>
		[Description("��������� ������ - ������������ (Acts.GoodStateID -> GoodsStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected bool _PutExists;
		/// <summary>
		/// ��� ����������� � ���������� ������� (Acts.InputID is not Null, Acts.OutputID is not Null)?
		/// </summary>
		[Description("��� ����������� � ���������� ������� (Acts.InputID is not Null, Acts.OutputID is not Null)?")]
		public bool PutExists { get { return _PutExists; } set { _PutExists = value; } }

		protected bool _InputExists;
		/// <summary>
		/// ��� ����������� � ���������� ������� �� ������ (Acts.InputID is not Null)?
		/// </summary>
		[Description("��� ����������� � ���������� ������� �� ������ (Acts.InputID is not Null)?")]
		public bool InputExists { get { return _InputExists; } set { _InputExists = value; } }

		protected int? _InputID;
		/// <summary>
		/// ������� �� ������ - ��� (Acts.InputID)
		/// </summary>
		[Description("������� �� ������ - ��� (Acts.InputID)")]
		public int? InputID { get { return _InputID; } set { _InputID = value; } }

		protected bool _OutputExists;
		/// <summary>
		/// ��� ����������� � ���������� ������� �� ������ (Acts.OutputID is not Null)?
		/// </summary>
		[Description("��� ����������� � ���������� ������� �� ������ (Acts.OutputID is not Null)?")]
		public bool OutputExists { get { return _OutputExists; } set { _OutputExists = value; } }

		protected int? _OutputID;
		/// <summary>
		/// ������� �� ������ - ��� (Acts.OutputID)
		/// </summary>
		[Description("������� �� ������ - ��� (Acts.OutputID)")]
		public int? OutputID { get { return _OutputID; } set { _OutputID = value; } }


		protected bool _TripExists;
		/// <summary>
		/// ��� ����������� � ����� (����� ��������� �������) (Acts.InputID -> Inputs.TripID is not Null, Acts.OutputID -> Outputs.TripID is not Null)?
		/// </summary>
		[Description("��� ����������� � ����� (����� ��������� �������) (Acts.InputID -> Inputs.TripID is not Null, Acts.OutputID -> Outputs.TripID is not Null)?")]
		public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }

		protected int? _TripID;
		/// <summary>
		/// ���� - ��� (Acts.InputID -> Inputs.TripID, Acts.OutputID -> Outputs.TripID)
		/// </summary>
		[Description("���� - ��� (Acts.InputID -> Inputs.TripID, Acts.OutputID -> Outputs.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected string _TripAlias;
		/// <summary>
		/// ���� - �������� (Acts.InputID -> Inputs.TripID -> Trips.Alias, Acts.OutputID -> Outputs.TripID -> Trips.Alias)
		/// </summary>
		[Description("���� - �������� (Acts.InputID -> Inputs.TripID -> Trips.Alias, Acts.OutputID -> Outputs.TripID -> Trips.Alias)")]
		public string TripAlias { get { return _TripAlias; } set { _TripAlias = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� � ���� (Acts.Note)
		/// </summary>
		[Description("���������� � ���� (Acts.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected bool _ReadyForWMS;
		/// <summary>
		/// ������ � �������� � ��������� ������� (Acts.ReadyForWMS)?
		/// </summary>
		[Description("������ � �������� � ��������� ������� (Acts.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }

		protected bool _SentToWMS;
		/// <summary>
		/// �������� � ��������� ������� (Acts.SentToWMS)?
		/// </summary>
		[Description("�������� � ��������� ������� (Acts.SentToWMS)?")]
		public bool SentToWMS { get { return _SentToWMS; } set { _SentToWMS = value; } }


		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� ���� (Acts.DateConfirm)?
		/// </summary>
		[Description("����-����� ������������� ���� (Acts.DateConfirm)?")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// ��� ����������� (Acts.DateConfirm is not Null)?
		/// </summary>
		[Description("��� ����������� (Acts.DateConfirm is not Null)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected DateTime? _DateCreate;
		/// <summary>
		/// ����-����� �������� (Acts.DateCreate)?
		/// </summary>
		[Description("����-����� �������� (Acts.DateCreate)?")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected int? _UserCreateID;
		/// <summary>
		/// ������������, ���������� ��� - ��� (Acts.UserCreateID)
		/// </summary>
		[Description("������������, ���������� ��� - ��� (Acts.UserCreateID)")]
		public int? UserCreateID { get { return _UserCreateID; } set { _UserCreateID = value; } }

		protected string _UserCreateName;
		/// <summary>
		/// ������������, ���������� ��� - ��� (Acts.UserCreateID -> _Users.Name)
		/// </summary>
		[Description("������������, ���������� ��� - ��� (Acts.UserCreateID -> _Users.Name)")]
		public string UserCreateName { get { return _UserCreateName; } set { _UserCreateName = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (Acts.HostID)
		/// </summary>
		[Description("Host - ��� (Acts.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (Acts.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (Acts.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// ��� ���� � host-������� (Acts.ERPCode)
		/// </summary>
		[Description("��� ���� � host-������� (Acts.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (Acts.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (Acts.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ���� - ��������� ���� ������� (Acts.DateAct)
		/// </summary>
		[Description("������-����: ���� ���� - ��������� ���� ������� (Acts.DateAct)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ���� - �������� ���� ������� (Acts.DateAct)
		/// </summary>
		[Description("������-����: ���� ���� - �������� ���� ������� (Acts.DateAct)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }


		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// ������-����: ��� ����� � �������� � ��������� ������� (Acts.ReadyForWMS)?
		/// </summary>
		[Description("������-����: ��� ����� � �������� � ��������� ������� (Acts.ReadyForPrint)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }


		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: ��� ����������� (Acts.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: ��� ����������� (Acts.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }


		protected string _FilterOwnersList;
		/// <summary>
		/// ������-����: ������ ����� ���������� ������, ����� ������� (Acts.OwnerID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� ������, ����� ������� (Acts.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }

		protected string _FilterGoodsStatesList;
		/// <summary>
		/// ������-����: ������ ����� ��������� ������, ����� ������� (Acts.GoodsStateID)
		/// </summary>
		[Description("������-����: ������ ����� ��������� ������, ����� ������� (Acts.GoodsStateID)")]
		public string FilterGoodsStatesList { get { return _FilterGoodsStatesList; } set { _FilterGoodsStatesList = value; _NeedRequery = true; } }


		protected bool? _FilterPutExists;
		/// <summary>
		/// ������-����: ��� ����������� � ���������� ������� (Acts.InputID is not Null, Acts.OutputID is not Null)?
		/// </summary>
		[Description("������-����: ��� ����������� � ���������� ������� (Acts.InputID is not Null, Acts.OutputID is not Null)?")]
		public bool? FilterPutExists { get { return _FilterPutExists; } set { _FilterPutExists = value; _NeedRequery = true; } }

		protected bool? _FilterInputExists;
		/// <summary>
		/// ������-����: ��� ����������� � ���������� ������� �� ������ (Acts.InputID is not Null)?
		/// </summary>
		[Description("������-����: ��� ����������� � ���������� ������� �� ������ (Acts.InputIDis not Null)?")]
		public bool? FilterInputExists { get { return _FilterInputExists; } set { _FilterInputExists = value; _NeedRequery = true; } }

		protected string _FilterInputsList;
		/// <summary>
		/// ������-����: ������ ����� ������� �� ������, ����� ������� (Acts.InputID)
		/// </summary>
		[Description("������-����: ������ ����� ������� �� ������, ����� ������� (Acts.InputID)")]
		public string FilterInputsList { get { return _FilterInputsList; } set { _FilterInputsList = value; _NeedRequery = true; } }

		protected bool? _FilterOutputExists;
		/// <summary>
		/// ������-����: ��� ����������� � ���������� ������� �� ������ (Acts.OutputID is not Null)?
		/// </summary>
		[Description("������-����: ��� ����������� � ���������� ������� �� ������ (Acts.OutputIDis not Null)?")]
		public bool? FilterOutputExists { get { return _FilterOutputExists; } set { _FilterOutputExists = value; _NeedRequery = true; } }

		protected string _FilterOutputsList;
		/// <summary>
		/// ������-����: ������ ����� ������� �� ������, ����� ������� (Acts.OutputID)
		/// </summary>
		[Description("������-����: ������ ����� ������� �� ������, ����� ������� (Acts.OutputID)")]
		public string FilterOutputsList { get { return _FilterOutputsList; } set { _FilterOutputsList = value; _NeedRequery = true; } }


		protected bool? _FilterTripExists;
		/// <summary>
		/// ������-����: ��� ����������� � ����� (����� ��������� �������) (Acts.InputID -> Inputs.TripID is not Null, Acts.OutputID -> Outputs.TripID is not Null)?
		/// </summary>
		[Description("������-����: ��� ����������� � ����� (����� ��������� �������) (Acts.InputID -> Inputs.TripID is not Null, Acts.OutputID -> Outputs.TripID is not Null)?")]
		public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

		protected string _FilterTripsList;
		/// <summary>
		/// ������-����: ������ ����� ������, ����� ������� (Acts.InputID -> Inputs.TripID, Acts.OutputID -> Outputs.TripID)
		/// </summary>
		[Description("������-����: ������ ����� ������, ����� ������� (Acts.InputID -> Inputs.TripID, Acts.OutputID -> Outputs.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterTripAliasContext;
		/// <summary>
		/// ������-����: �������� �����, �������� (Acts.InputID -> Inputs.TripID -> Trips.Alias, Acts.OutputID -> Outputs.TripID -> Trips.Alias)
		/// </summary>
		[Description("������-����: �������� �����, �������� (Acts.InputID -> Inputs.TripID -> Trips.Alias, Acts.OutputID -> Outputs.TripID -> Trips.Alias)")]
		public string FilterTripAliasContext { get { return _FilterTripAliasContext; } set { _FilterTripAliasContext = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (Acts.ID --> ActsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (Acts.ID --> ActsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (Acts.ID --> ActsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (Acts.ID --> ActsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableActsGoods;
		/// <summary>
		/// ������ ������� � ���� ActsGoods
		/// </summary>
		[Description("������ ������� � ���� ActsGoods")]
		public DataTable TableActsGoods { get { return _TableActsGoods; } }

		#endregion �������


		// -------------------------------------

		public Act() : base()
		{
			_MainTableName = "Acts";
			_ColumnID = "ID";
			_ColumnName = "DateAct";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ����� � ��������������� ���������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_ActsFill @nID, @cIDList, " +
									"@cHostsList, " +
									"@dDateBeg, @dDateEnd, " +
									"@bReadyForWMS, " +
									"@bIsConfirmed, " +
									"@cOwnersList, @cGoodsStatesList, " +
									"@bPutExists, @bInputExists, @cInputsList, @bOutputExists, @cOutputsList, " +
									"@bTripExists, @cTripsList, @cTripAliasContext, " +
									"@cPackingsList, @cGoodsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_ActsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (_FilterOwnersList != null)
				_oParameter.Value = _FilterOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsStatesList", SqlDbType.VarChar);
			if (_FilterGoodsStatesList != null)
				_oParameter.Value = _FilterGoodsStatesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bPutExists", SqlDbType.Bit);
			if (_FilterPutExists != null)
				_oParameter.Value = _FilterPutExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bInputExists", SqlDbType.Bit);
			if (_FilterInputExists != null)
				_oParameter.Value = _FilterInputExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsList", SqlDbType.VarChar);
			if (_FilterInputsList != null)
				_oParameter.Value = _FilterInputsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bOutputExists", SqlDbType.Bit);
			if (_FilterOutputExists != null)
				_oParameter.Value = _FilterOutputExists;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsList", SqlDbType.VarChar);
			if (_FilterOutputsList != null)
				_oParameter.Value = _FilterOutputsList;
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

			_oParameter = _oCommand.Parameters.Add("@cTripAliasContext", SqlDbType.VarChar);
			if (_FilterTripAliasContext != null)
				_oParameter.Value = _FilterTripAliasContext;
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
				_ErrorStr = "������ ��� ��������� ������ �����..." + Convert.ToChar(13) + ex.Message;
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
			_FilterOwnersList = null;
			_FilterGoodsStatesList = null;

			_FilterPutExists = null;
			_FilterInputExists = null;
			_FilterInputsList = null;
			_FilterOutputExists = null; 
			_FilterOutputsList = null;

			_FilterTripExists = null;
			_FilterTripsList = null;
			_FilterTripAliasContext = null;

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
					_DateAct = Convert.ToDateTime(r["DateAct"]);

					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					if (!Convert.IsDBNull(r["GoodStateID"]))
						_GoodStateID = Convert.ToInt32(r["GoodStateID"]);
					_GoodStateName = r["GoodStateName"].ToString();

					_PutExists = Convert.ToBoolean(r["PutExists"]);
					_InputExists = Convert.ToBoolean(r["InputExists"]);
					if (!Convert.IsDBNull(r["InputID"]))
						_InputID = Convert.ToInt32(r["InputID"]);
					_OutputExists = Convert.ToBoolean(r["OutputExists"]);
					if (!Convert.IsDBNull(r["OutputID"]))
						_OutputID = Convert.ToInt32(r["OutputID"]);
	
					_TripExists = Convert.ToBoolean(r["TripExists"]);
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
					_ErrorStr = "������ ��� ��������� ������ �� ����...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ �� ���� (��� ������)...";
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
			_DateAct = DateTime.Now.Date;

			_OwnerID = null;
			_OwnerName = null;
			_GoodStateID = null;
			_GoodStateName = null;

			_PutExists = false;
			_InputExists = false;
			_InputID = null;
			_OutputExists = false;
			_OutputID = null;

			_TripExists = false;
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
			string _sqlCommand = "execute up_ActsSave @nActID output, " +
									"@nHostID, " + 
									"@dDateAct, " +
									"@nOwnerID, @nGoodStateID, " +
									"@nInputID, @nOutputID, " +
									"@cNote, " +
									"@nUserCreateID, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_ActsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nActID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nHostID", SqlDbType.Int);
			_oParameter.Value = _HostID;

			_oParameter = _oCommand.Parameters.Add("@dDateAct", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateAct;

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

			_oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			if (_InputID.HasValue)
				_oParameter.Value = _InputID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			if (_OutputID.HasValue)
				_oParameter.Value = _OutputID;
			else
				_oParameter.Value = DBNull.Value;
		
			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = "";

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

            // �������� ������� �����������
            if (TableActsGoods == null)
            {
                _ErrorNumber = -12;
                _ErrorStr = "������ ��� ������� ���������� ����...\r\n" + "������� ������� ����������� ����";
                RFMMessage.MessageBoxError(_ErrorStr);
                return false;
            }
            if (TableActsGoods.Rows.Count == 0)
            {
                _ErrorNumber = -11;
                _ErrorStr = "������ ��� ������� ���������� ����...\r\n" + "������ ������� ����������� ����";
                RFMMessage.MessageBoxError(_ErrorStr);
                return false;
            }

            try
            {
				_Connect.Open();

				// ������� �������
				if (TableActsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableActsGoods, "#ActsGoods", _Connect);
				}

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ ���� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nActID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nActID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ����
		/// </summary>
		public bool Delete(int nActID)
		{
			String _sqlCommand = "execute up_ActsDelete @nActID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_ActsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nActID", SqlDbType.Int);
			_oParameter.Value = nActID;

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
				_ErrorStr = "������ ��� ������� �������� ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� ����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// ������������� ���� 
		/// </summary>
		public bool Confirm()
		{
			string _sqlCommand = "execute up_ActsConfirm @nActID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_ActsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nActID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������������� ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
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
			string _sqlCommand = "execute up_ActsUnConfirm @nActID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnActsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nActID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� ����...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� ����...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Set/Clear 

		#region ReadyForWMS

		/// <summary>
		/// ���������/�������� ������� "��� ����� � �������� � ��������� �������"
		/// nUserID: �� ���.
		/// </summary>
		public bool SetReadyForWMS(int nActID)
		{
			return (SetReadyForWMS(nActID, false, 0));
		}

		public bool SetReadyForWMS(int nActID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "execute up_ActsSetReadyForWMS @nActID, @bClear, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_ActsSetReadyForWMS parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nActID", SqlDbType.Int);
			_oParameter.Value = nActID;

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
				_ErrorStr = "������ ��� ������� " + (bClear ? "������" : "���������") + " �������� \"��� ����� � �������� � ��������� �������\"...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� " + (bClear ? "������" : "���������") + " �������� \"��� ����� � �������� � ��������� �������\"...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ReadyForWMS

		#endregion Set/Clear 


		#region �������

		#region ActsGoods

		/// <summary>
		/// ��������� ������� ������� � ���� TableActsGoods
		/// </summary>
		public bool FillTableActsGoods(int nActID)
		{
			string sqlSelect = "execute up_ActsGoodsFill @nActID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_ActsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nActID", SqlDbType.Int);
			_oParameter.Value = nActID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableActsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableActsGoods, "TableActsGoods");
				_TableActsGoods.PrimaryKey = new DataColumn[] { _TableActsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ������� � ����..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ����...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableActsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableActsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ����...\r\n" +
								"�� ��������� ��� ����...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� �������������� ������� ������� � ���� TableActsGoods �� ������ Input ��� Output
		/// </summary>
		public bool FillTableActsGoodsFromPut(int? nInputID, int? nOutputID)
		{
			string sqlSelect = "execute up_ActsGoodsFillFromPut @nInputID, @nOutputID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_ActsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			if (nInputID.HasValue)
				_oParameter.Value = nInputID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nOutputID", SqlDbType.Int);
			if (nOutputID.HasValue)
				_oParameter.Value = nOutputID;
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
				_TableActsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableActsGoods, "TableActsGoods");
				//_TableActsGoods.PrimaryKey = new DataColumn[] { _TableActsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ��������� ������ ������� � ���� �� ������ ���������� �������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ���� �� ������ ���������� �������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ActsGoods

		#endregion �������

	}

#endregion Act

}
