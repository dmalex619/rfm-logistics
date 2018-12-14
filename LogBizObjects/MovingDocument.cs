using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ������������� ����������� (MovingDocument)
/// </summary>
/// 
namespace LogBizObjects
{

#region MovingDocument 

	public class MovingDocument : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ������������� ����������� (MovingsDocuments.ID)
		/// </summary>
		[Description("������ ����� ID ������������� ����������� (MovingsDocuments.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected DateTime _DateMoving;
		/// <summary>
		/// ���� ��������� (MovingsDocuments.DateMoving)
		/// </summary>
		[Description("���� ��������� (MovingsDocuments.DateMoving)")]
		public DateTime DateMoving { get { return _DateMoving; } set { _DateMoving = value; } }


		protected int _GoodStateSourceID;
		/// <summary>
		/// ��������� ������ - �������� - ��� (MovingsDocuments.GoodStateSourceID)
		/// </summary>
		[Description("��������� ������ - �������� - ��� (MovingsDocuments.GoodStateSourceID)")]
		public int GoodStateSourceID { get { return _GoodStateSourceID; } set { _GoodStateSourceID = value; } }

		protected string _GoodStateSourceName;
		/// <summary>
		/// ��������� ������ - �������� - ������������ (MovingsDocuments.GoodStateSourceID -> GoodsStates.Name)
		/// </summary>
		[Description("��������� ������ - �������� - ������������ (MovingsDocuments.GoodStateSourceID -> GoodsStates.Name)")]
		public string GoodStateSourceName { get { return _GoodStateSourceName; } set { _GoodStateSourceName = value; } }

		protected int _GoodStateTargetID;
		/// <summary>
		/// ��������� ������ - �������� - ��� (MovingsDocuments.GoodStateTargetID)
		/// </summary>
		[Description("��������� ������ - �������� - ��� (MovingsDocuments.GoodStateTargetID)")]
		public int GoodStateTargetID { get { return _GoodStateTargetID; } set { _GoodStateTargetID = value; } }

		protected string _GoodStateTargetName;
		/// <summary>
		/// ��������� ������ - �������� - ������������ (MovingsDocuments.GoodStateTargetID -> GoodsStates.Name)
		/// </summary>
		[Description("��������� ������ - �������� - ������������ (MovingsDocuments.GoodStateTargetID -> GoodsStates.Name)")]
		public string GoodStateTargetName { get { return _GoodStateTargetName; } set { _GoodStateTargetName = value; } }


		protected int _OwnerSourceID;
		/// <summary>
		/// �������� ������ - �������� - ��� (MovingsDocuments.OwnerSourceID)
		/// </summary>
		[Description("�������� ������ - �������� - ��� (MovingsDocuments.OwnerSourceID)")]
		public int OwnerSourceID { get { return _OwnerSourceID; } set { _OwnerSourceID = value; } }

		protected string _OwnerSourceName;
		/// <summary>
		/// �������� ������ - �������� - ������������ (MovingsDocuments.OwnerSourceID -> Partners.Name)
		/// </summary>
		[Description("�������� ������ - �������� - ������������ (MovingsDocuments.OwnerSourceID -> Partners.Name)")]
		public string OwnerSourceName { get { return _OwnerSourceName; } set { _OwnerSourceName = value; } }

		protected int _PartnerDetailSourceID;
		/// <summary>
		/// ��������-��������� (��������), ��������� - ��� ���������� (MovingsDocuments.PartnerDetailSourceID)
		/// </summary>
		[Description("��������-��������� (��������), ��������� - ��� ���������� (MovingsDocuments.PartnerDetailSourceID)")]
		public int PartnerDetailSourceID { get { return _PartnerDetailSourceID; } set { _PartnerDetailSourceID = value; } }

		protected string _PartnerSourceFactName;
		/// <summary>
		/// ��������-��������� (��������), ��������� - ������ ������������ �� ���������� (MovingsDocuments.PartnerDetailSourceID -> PartnersDetails.FactName)
		/// </summary>
		[Description("��������-��������� (��������), ��������� - ������ ������������ �� ���������� (MovingsDocuments.PartnerDetailSourceID -> PartnersDetails.FactName)")]
		public string PartnerSourceFactName { get { return _PartnerSourceFactName; } set { _PartnerSourceFactName = value; } }


		protected int _OwnerTargetID;
		/// <summary>
		/// �������� ������ - �������� - ��� (MovingsDocuments.OwnerTargetID)
		/// </summary>
		[Description("�������� ������ - �������� - ��� (MovingsDocuments.OwnerTargetID)")]
		public int OwnerTargetID { get { return _OwnerTargetID; } set { _OwnerTargetID = value; } }

		protected string _OwnerTargetName;
		/// <summary>
		/// �������� ������ - �������� - ������������ (MovingsDocuments.OwnerTargetID -> Partners.Name)
		/// </summary>
		[Description("�������� ������ - �������� - ������������ (MovingsDocuments.OwnerTargetID -> Partners.Name)")]
		public string OwnerTargetName { get { return _OwnerTargetName; } set { _OwnerTargetName = value; } }

		protected int _PartnerDetailTargetID;
		/// <summary>
		/// ����������-���������� (��������), ��������� - ��� (MovingsDocuments.PartnerDetailTargetID)
		/// </summary>
		[Description("����������-���������� (��������), ��������� - ��� (MovingsDocuments.PartnerDetailTargetID)")]
		public int PartnerDetailTargetID { get { return _PartnerDetailTargetID; } set { _PartnerDetailTargetID = value; } }

		protected string _PartnerTargetFactName;
		/// <summary>
		/// ����������-���������� (��������), ��������� - ������ ������������ �� ���������� (MovingsDocuments.PartnerDetailTargetID -> PartnersDetails.FactName)
		/// </summary>
		[Description("����������-���������� (��������), ��������� - ������ ������������ �� ���������� (MovingsDocuments.PartnerDetailTargetID -> PartnersDetails.FactName)")]
		public string PartnerTargetFactName { get { return _PartnerTargetFactName; } set { _PartnerTargetFactName = value; } }

		
		protected int _CurrencyID;
		/// <summary>
		/// ������ ��� � ������������� ����������� - ��� (MovingsDocuments.CurrencyID)
		/// </summary>
		[Description("������ ��� � ������������� ����������� - ��� (MovingsDocuments.CurrencyID)")]
		public int CurrencyID { get { return _CurrencyID; } set { _CurrencyID = value; } }

		protected string _CurrencyName;
		/// <summary>
		/// ������ ��� � ������������� ����������� - ������������ (MovingsDocuments.CurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ ��� � ������������� ����������� - ������������ (MovingsDocuments.CurrencyID -> Currencies.Name)")]
		public string CurrencyName { get { return _CurrencyName; } set { _CurrencyName = value; } }


		protected string _Note;
		/// <summary>
		/// ���������� (MovingsDocuments.Note)
		/// </summary>
		[Description("���������� (MovingsDocuments.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }


		protected string _BillNumber;
		/// <summary>
		/// ����� ��������� (MovingsDocuments.BillNumber)?
		/// </summary>
		[Description("����� ��������� (MovingsDocuments.BillNumber)?")]
		public string BillNumber { get { return _BillNumber; } set { _BillNumber = value; } }


		protected DateTime? _DateConfirm;
		/// <summary>
		/// ����-����� ������������� (MovingsDocuments.DateConfirm)
		/// </summary>
		[Description("����-����� ������������� (MovingsDocuments.DateConfirm)")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected int? _UserConfirmID;
		/// <summary>
		/// ������������, ����������� ������������� - ��� (MovingsDocuments.UserConfirmID)
		/// </summary>
		[Description("������������, ����������� ������������� - ��� (MovingsDocuments.UserConfirmID)")]
		public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

		protected string _UserConfirmName;
		/// <summary>
		/// ������������, ����������� ������������� - ��� (MovingsDocuments.UserConfirmID -> _Users.Name)
		/// </summary>
		[Description("������������, ����������� ������������� - ��� (MovingsDocuments.UserConfirmID -> _Users.Name)")]
		public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// �����.����������� ������������? (MovingsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("�����.����������� ������������? (MovingsDocuments.Confirmed)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected int? _ActSourceID;
		/// <summary>
		/// ��� ��� ��������� - ��� (MovingsDocuments.ActSourceID)
		/// </summary>
		[Description("��� ��� ��������� - ��� (MovingsDocuments.ActSourceID)")]
		public int? ActSourceID { get { return _ActSourceID; } set { _ActSourceID = value; } }

		protected int? _ActTargetID;
		/// <summary>
		/// ��� ��� ��������� - ��� (MovingsDocuments.ActTargetID)
		/// </summary>
		[Description("��� ��� ��������� - ��� (MovingsDocuments.ActTargetID)")]
		public int? ActTargetID { get { return _ActTargetID; } set { _ActTargetID = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - ��� (MovingsDocuments.HostID)
		/// </summary>
		[Description("Host - ��� (MovingsDocuments.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - ������������ (MovingsDocuments.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - ������������ (MovingsDocuments.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// ��� ��������� � host-������� (MovingsDocuments.ERPCode)
		/// </summary>
		[Description("��� ��������� � host-������� (MovingsDocuments.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������
		
		#region �������

		protected string _FilterHostsList;
		/// <summary>
		/// ������-����: ������ ����� host-��, ����� ������� (MovingsDocuments.HostID)
		/// </summary>
		[Description("������-����: ������ ����� �������� �����, ����� ������� (MovingsDocuments.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateMoving;
		/// <summary>
		/// ������-����: ���� �������������� ����������� - ����� (MovingsDocuments.DateMoving)
		/// </summary>
		[Description("������-����: ���� �������������� ����������� - ����� (MovingsDocuments.DateMoving)")]
		public DateTime? FilterDateMoving { get { return _FilterDateMoving; } set { _FilterDateMoving = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� �������������� ����������� - ��������� ���� ������� (MovingsDocuments.DateMoving)
		/// </summary>
		[Description("������-����: ���� �������������� ����������� - ��������� ���� ������� (MovingsDocuments.DateMoving)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� �������������� ����������� - �������� ���� ������� (MovingsDocuments.DateMoving)
		/// </summary>
		[Description("������-����: ���� �������������� ����������� - �������� ���� ������� (MovingsDocuments.DateMoving)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }
		

		protected string _FilterOwnersSourceList;
		/// <summary>
		/// ������-����: ������ ����� ����������-����������, ����� ������� (MovingsDocuments.OwnerSourceID)
		/// </summary>
		[Description("������-����: ������ ����� ����������-����������, ����� ������� (MovingsDocuments.OwnerSourceID)")]
		public string FilterOwnersSourceList { get { return _FilterOwnersSourceList; } set { _FilterOwnersSourceList = value; _NeedRequery = true; } }

		protected string _FilterPartnersDetailsSourcesList;
		/// <summary>
		/// ������-����: ������ ����� ���������� ���������-�����������, ����� ������� (MovingsDocuments.PartnerDetailSourceID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� ���������-�����������, ����� ������� (MovingsDocuments.PartnerDetailSourceID)")]
		public string FilterPartnersDetailsSourcesList { get { return _FilterPartnersDetailsSourcesList; } set { _FilterPartnersDetailsSourcesList = value; _NeedRequery = true; } }

		protected string _FilterOwnersTargetList;
		/// <summary>
		/// ������-����: ������ ����� ����������-����������, ����� ������� (MovingsDocuments.OwnerTargetID)
		/// </summary>
		[Description("������-����: ������ ����� ����������-����������, ����� ������� (MovingsDocuments.OwnerTargetID)")]
		public string FilterOwnersTargetList { get { return _FilterOwnersTargetList; } set { _FilterOwnersTargetList = value; _NeedRequery = true; } }

		protected string _FilterPartnersDetailsTargetsList;
		/// <summary>
		/// ������-����: ������ ����� ���������� �����������-������������, ����� ������� (MovingsDocuments.PartnerDetailTargetID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� �����������-������������, ����� ������� (MovingsDocuments.PartnerDetailTargetID)")]
		public string FilterPartnersDetailsTargetsList { get { return _FilterPartnersDetailsTargetsList; } set { _FilterPartnersDetailsTargetsList = value; _NeedRequery = true; } }


		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// ������-����: �������� �� ������ ������������ (MovingsDocuments.DateConfirm is not Null)?
		/// </summary>
		[Description("������-����: �������� �� ������ ������������ (MovingsDocuments.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

		// ��� ������ �� ������� 

		protected string _FilterPackingsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (MovingsDocuments.ID --> MovingsDocumentsGoods.PackingID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (MovingsDocuments.ID --> MovingsDocumentsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (MovingsDocuments.ID --> MovingsDocumentsGoods.GoodID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (MovingsDocuments.ID --> MovingsDocumentsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion �������

		#region �������

		protected DataTable _TableMovingsDocumentsGoods;
		/// <summary>
		/// ������� ������� � ������������� ����������� MovingsDocumentsGoods
		/// </summary>
		[Description("������� ������� � ������������� ����������� MovingsDocumentsGoods")]
		public DataTable TableMovingsDocumentsGoods { get { return _TableMovingsDocumentsGoods; } }

		#endregion �������

		// ----------------------------

		public MovingDocument()
			: base()
		{
			_MainTableName = "MovingsDocuments";
			_ColumnID = "ID";
			_ColumnName = "DateMoving";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������������� ����������� � MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_MovingsDocumentsFill @nID, @cIDList, " +
									"@cHostsList, " + 
									"@dDateMoving, " + 
									"@dDateBeg, @dDateEnd, " +
									"@cOwnersSourceList, @cPartnersDetailsSourcesList, " + 
									"@cOwnersTargetList, @cPartnersDetailsTargetsList, " + 
									"@bIsConfirmed, " +
									"@cPackingsList, @cGoodsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_MovingsDocumentsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@dDateMoving", SqlDbType.SmallDateTime);
			if (_FilterDateMoving.HasValue)
				_oParameter.Value = _FilterDateMoving;
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

			_oParameter = _oCommand.Parameters.Add("@cOwnersSourceList", SqlDbType.VarChar);
			if (_FilterOwnersSourceList != null)
				_oParameter.Value = _FilterOwnersSourceList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsSourcesList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsSourcesList != null)
				_oParameter.Value = _FilterPartnersDetailsSourcesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersTargetList", SqlDbType.VarChar);
			if (_FilterOwnersTargetList != null)
				_oParameter.Value = _FilterOwnersTargetList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsTargetsList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsTargetsList != null)
				_oParameter.Value = _FilterPartnersDetailsTargetsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (_FilterIsConfirmed != null)
				_oParameter.Value = _FilterIsConfirmed;
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
				_ErrorStr = "������ ��� ��������� ������ ������������� �����������..." + Convert.ToChar(13) + ex.Message;
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

			_FilterDateMoving = null;
			_FilterDateBeg = null;
			_FilterDateEnd = null;

			_FilterOwnersSourceList = null;
			_FilterPartnersDetailsSourcesList = null;
			_FilterOwnersTargetList = null;
			_FilterPartnersDetailsTargetsList = null;

			_FilterIsConfirmed = null;

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

					_DateMoving = Convert.ToDateTime(r["DateMoving"]);

					_GoodStateSourceID = Convert.ToInt32(r["GoodStateSourceID"]);
					_GoodStateSourceName = r["GoodStateSourceName"].ToString();
					_GoodStateTargetID = Convert.ToInt32(r["GoodStateTargetID"]);
					_GoodStateTargetName = r["GoodStateTargetName"].ToString();

					_OwnerSourceID = Convert.ToInt32(r["OwnerSourceID"]);
					_OwnerSourceName = r["OwnerSourceName"].ToString();
					_PartnerDetailSourceID = Convert.ToInt32(r["PartnerDetailSourceID"]);
					_PartnerSourceFactName = r["PartnerSourceFactName"].ToString();

					_OwnerTargetID = Convert.ToInt32(r["OwnerTargetID"]);
					_OwnerTargetName = r["OwnerTargetName"].ToString();
					_PartnerDetailTargetID = Convert.ToInt32(r["PartnerDetailTargetID"]);
					_PartnerTargetFactName = r["PartnerTargetFactName"].ToString();
					
					_CurrencyID = Convert.ToInt32(r["CurrencyID"]);
					_CurrencyName = r["CurrencyName"].ToString();

					_Note = r["Note"].ToString();

					_BillNumber = r["BillNumber"].ToString();

					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);
					if (!Convert.IsDBNull(r["UserConfirmID"]))
						_UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
					_UserConfirmName = r["UserConfirmName"].ToString();

					if (!Convert.IsDBNull(r["ActSourceID"]))
						_ActSourceID = Convert.ToInt32(r["ActSourceID"]);
					if (!Convert.IsDBNull(r["ActTargetID"]))
						_ActTargetID = Convert.ToInt32(r["ActTargetID"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ������������� �����������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ������������� ����������� (��� ������)...";
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

			_DateMoving = DateTime.Now.Date;

			_GoodStateSourceID = 0;
			_GoodStateSourceName = null;
			_GoodStateTargetID = 0;
			_GoodStateTargetName = null;

			_OwnerSourceID = 0;
			_OwnerSourceName = null;
			_PartnerDetailSourceID = 0;
			_PartnerSourceFactName = null;

			_OwnerTargetID = 0;
			_OwnerTargetName = null;
			_PartnerDetailTargetID = 0;
			_PartnerTargetFactName = null;

			_CurrencyID = 0;
			_CurrencyName = null;

			_Note = null;

			_BillNumber = null;

			_DateConfirm = null;
			_IsConfirmed = false;
			_UserConfirmID = null;
			_UserConfirmName = null;

			_ActSourceID = null;
			_ActTargetID = null;

			_HostID = null;
			_HostName = null;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Confirm

		/// <summary>
		/// ������������� �������� �� ������
		/// </summary>
		public bool Confirm(int nUserConfirmID)
		{
			string _sqlCommand = "execute up_MovingsDocumentsConfirm @nMovingDocumentID, " +
									"@nUserConfirmID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_MovingsDocumentsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nMovingDocumentID", SqlDbType.Int);
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
				if (_TableMovingsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(_TableMovingsDocumentsGoods, "#MovingsDocumentsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ������� ������������� �������������� �����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������������� �������������� �����������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������������� �������������� �����������
		/// </summary>
		public bool UnConfirm(int nUserConfirmID)
		{
			string _sqlCommand = "execute up_MovingsDocumentsUnConfirm @nMovingDocumentID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_MovingsDocumentsUnConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nMovingDocumentID", SqlDbType.Int);
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
				_ErrorStr = "������ ��� ������� ������ ������������� �������������� �����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ������ ������������� �������������� �����������...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Save, Delete

		#region Save

		/// <summary>
		/// ���������� ������ ���������
		/// </summary>
		public bool Save()
		{
			string _sqlCommand = "execute up_MovingsDocumentsSave @nMovingDocumentID output, " +
					"@nHostID, " + 
					"@dDateMoving, " +
					"@nGoodStateSourceID, @nGoodStateTargetID, " +
					"@nOwnerSourceID, @nPartnerDetailSourceID, @nOwnerTargetID, @nPartnerDetailTargetID, " +
					"@cBillNumber, @nCurrencyID, @cNote, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_MovingsDocumentsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nMovingDocumentID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nHostID", SqlDbType.Int);
			_oParameter.Value = _HostID;

			_oParameter = _oCommand.Parameters.Add("@dDateMoving", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateMoving;

			_oParameter = _oCommand.Parameters.Add("@nGoodStateSourceID", SqlDbType.Int);
			_oParameter.Value = _GoodStateSourceID;

			_oParameter = _oCommand.Parameters.Add("@nGoodStateTargetID", SqlDbType.Int);
			_oParameter.Value = _GoodStateTargetID;

			_oParameter = _oCommand.Parameters.Add("@nOwnerSourceID", SqlDbType.Int);
			_oParameter.Value = _OwnerSourceID;

			_oParameter = _oCommand.Parameters.Add("@nPartnerDetailSourceID", SqlDbType.Int);
			_oParameter.Value = _PartnerDetailSourceID;

			_oParameter = _oCommand.Parameters.Add("@nOwnerTargetID", SqlDbType.Int);
			_oParameter.Value = _OwnerTargetID;

			_oParameter = _oCommand.Parameters.Add("@nPartnerDetailTargetID", SqlDbType.Int);
			_oParameter.Value = _PartnerDetailTargetID;

			_oParameter = _oCommand.Parameters.Add("@cBillNumber", SqlDbType.VarChar);
			_oParameter.Value = _BillNumber;

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
				if (TableMovingsDocumentsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableMovingsDocumentsGoods, "#MovingsDocumentsGoods", _Connect);
				}

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������� ���������� �������������� �����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� �������������� �����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// ��� �������� ������ �������������� ����������� - ������� ��� ���
				if ((!_ID.HasValue || _ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nMovingDocumentID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nMovingDocumentID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save

		#region Delete

		/// <summary>
		/// �������� �������������� �����������
		/// </summary>
		public bool Delete(int nMovingDocumentID)
		{
			String _sqlCommand = "execute up_MovingsDocumentsDelete @nMovingDocumentID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_MovingsDocumentsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nMovingDocumentID", SqlDbType.Int);
			_oParameter.Value = nMovingDocumentID;

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
				_ErrorStr = "������ ��� ������� �������� �������������� �����������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� �������� �������������� �����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete

		#endregion Save, Delete

		#region �������

		#region MovingsDocumentsGoods

		/// <summary>
		/// ��������� ������� ������� � ������������� ����������� (TableMovingsDocumentsGoods)
		/// </summary>
		public bool FillTableMovingsDocumentsGoods(int nMovingDocumentID)
		{
			string sqlSelect = "execute up_MovingsDocumentsGoodsFill @nMovingDocumentID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_MovingsDocumentsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nMovingDocumentID", SqlDbType.Int);
			_oParameter.Value = nMovingDocumentID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableMovingsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableMovingsDocumentsGoods, "TableMovingsDocumentsGoods");
				_TableMovingsDocumentsGoods.PrimaryKey = new DataColumn[] { _TableMovingsDocumentsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ������������� �����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ������������� �����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableMovingsDocumentsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableMovingsDocumentsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ������������� �����������...\r\n" +
								"�� ��������� ��� �������������� �����������...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ��������� ������� ������� � ������������� ����������� - ��� ������������ ���������� (TableMovingsDocumentsGoods)
		/// </summary>
		public bool FillBillTableMovingsDocumentsGoods(string sMovingsDocumentsList)
		{
			string sqlSelect = "execute up_MovingsDocumentsGoodsFillBill @cMovingsDocumentsList, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_MovingsDocumentsGoodsFillBill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cMovingsDocumentsList", SqlDbType.VarChar);
			_oParameter.Value = sMovingsDocumentsList;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableMovingsDocumentsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableMovingsDocumentsGoods, "TableMovingsDocumentsGoods");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ��������� ������ ������� � ������������� �����������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� � ������������� �����������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion MovingsDocumentsGoods

		#endregion �������

	}

#endregion MovingDocument

}
