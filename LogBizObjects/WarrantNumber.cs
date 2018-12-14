using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������������ - ������ � ������� ������������� (WarrantNumber)
/// </summary>
/// 
namespace LogBizObjects
{

#region WarrantNumber

	public class WarrantNumber : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ������������� (WarrantsNumbers.ID)
		/// </summary>
		[Description("������ ����� ID ������������� (WarrantsNumbers.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _Number;
		/// <summary>
		/// ����� ������������ (WarrantsNumbers.Number)
		/// </summary>
		[Description("����� ������������ (WarrantsNumbers.Number)")]
		public string Number { get { return _Number; } set { _Number = value; } }

		protected int _NumberInt;
		/// <summary>
		/// ����� ������������ - ����� (WarrantsNumbers.NumberInt)
		/// </summary>
		[Description("����� ������������ - ����� (WarrantsNumbers.NumberInt)")]
		public int NumberInt { get { return _NumberInt; } set { _NumberInt = value; } }

		protected DateTime? _DateIssue;
		/// <summary>
		/// ���� ������ (WarrantsNumbers.DateIssue)
		/// </summary>
		[Description("���� ������ (WarrantsNumbers.DateIssue)")]
		public DateTime? DateIssue { get { return _DateIssue; } set { _DateIssue = value; } }

		protected DateTime? _DateTill;
		/// <summary>
		/// ������������ ������������� �� ���� (WarrantsNumbers.DateTill)
		/// </summary>
		[Description("������������ ������������� �� ���� (WarrantsNumbers.DateTill)")]
		public DateTime? DateTill { get { return _DateTill; } set { _DateTill = value; } }

		protected bool _IsMoney;
		/// <summary>
		/// ������������ �� ��������� ����� (�� ������) �� ������� (WarrantsNumbers.OutputDocumentID is not Null)?
		/// </summary>
		[Description("������������ �� ��������� ����� (�� ������) �� ������� (WarrantsNumbers.OutputDocumentID is not Null)?")]
		public bool IsMoney { get { return _IsMoney; } set { _IsMoney = value; } }


		protected int _PartnerSourceID;
		/// <summary>
		/// �������, ���������� ������������ (��) - ��� (WarrantsNumbers.PartnerSourceID)
		/// </summary>
		[Description("�������, ���������� ������������ (��) - ��� (WarrantsNumbers.PartnerSourceID)")]
		public int PartnerSourceID { get { return _PartnerSourceID; } set { _PartnerSourceID = value; } }

		protected string _PartnerSourceName;
		/// <summary>
		/// �������, ���������� ������������ (��) - ������������ (WarrantsNumbers.PartnerSourceID -> Partners.Name)
		/// </summary>
		[Description("�������, ���������� ������������ (��) - ������������ (WarrantsNumbers.PartnerSourceID -> Partners.Name)")]
		public string PartnerSourceName { get { return _PartnerSourceName; } set { _PartnerSourceName = value; } }

		/*
		protected int? _PartnerDetailSourceID;
		/// <summary>
		/// ��������� ��������, ����������� ������������ (��) - ��� (WarrantsNumbers.PartnerDetailSourceID)
		/// </summary>
		[Description("��������� ��������, ����������� ������������ (��) - ��� (WarrantsNumbers.PartnerDetailSourceID)")]
		public int? PartnerDetailSourceID { get { return _PartnerDetailSourceID; } set { _PartnerDetailSourceID = value; } }

		protected string _PartnerDetailSourceFactName;
		/// <summary>
		/// ����.�������� - �� ���������� ��������, ����������� ������������ (��) (WarrantsNumbers.PartnerDetailSourceID -> PartnersDetails.FactName)
		/// </summary>
		[Description("����.�������� - �� ���������� ��������, ����������� ������������ (��) (WarrantsNumbers.PartnerDetailSourceID -> PartnersDetails.FactName)")]
		public string PartnerDetailSourceFactName { get { return _PartnerDetailSourceFactName; } set { _PartnerDetailSourceFactName = value; } }

		protected string _PartnerDetailSourceBankName;
		/// <summary>
		/// ���� - �� ���������� ��������, ����������� ������������ (��) (WarrantsNumbers.PartnerDetailSourceID -> PartnersDetails.BankName)
		/// </summary>
		[Description("���� - �� ���������� ��������, ����������� ������������ (��) (WarrantsNumbers.PartnerDetailSourceID -> PartnersDetails.BankName)")]
		public string PartnerDetailSourceBankName { get { return _PartnerDetailSourceBankName; } set { _PartnerDetailSourceBankName = value; } }
		*/

		protected int _PartnerTargetID;
		/// <summary>
		/// �������-���������� - ��� (WarrantsNumbers.PartnerTargetID)
		/// </summary>
		[Description("�������-���������� - ��� (WarrantsNumbers.PartnerTargetID)")]
		public int PartnerTargetID { get { return _PartnerTargetID; } set { _PartnerTargetID = value; } }

		protected string _PartnerTargetName;
		/// <summary>
		/// �������-���������� - ������������ (WarrantsNumbers.PartnerTargetID -> Partners.Name)
		/// </summary>
		[Description("�������-���������� - ������������ (WarrantsNumbers.PartnerTargetID -> Partners.Name)")]
		public string PartnerTargetName { get { return _PartnerTargetName; } set { _PartnerTargetName = value; } }

		/*
		protected int _PartnerDetailTargetID;
		/// <summary>
		/// ��������� ��������-����������� - ��� (WarrantsNumbers.PartnerDetailTargetID)
		/// </summary>
		[Description("��������� ��������-����������� - ��� (WarrantsNumbers.PartnerDetailTargetID)")]
		public int PartnerDetailTargetID { get { return _PartnerDetailTargetID; } set { _PartnerDetailTargetID = value; } }

		protected string _PartnerDetailTargetFactName;
		/// <summary>
		/// ����.�������� - �� ���������� ��������-����������� (WarrantsNumbers.PartnerDetailTargetID -> PartnersDetails.FactName)
		/// </summary>
		[Description("����.�������� - �� ���������� ��������-����������� (WarrantsNumbers.PartnerDetailTargetID -> PartnersDetails.FactName)")]
		public string PartnerDetailTargetFactName { get { return _PartnerDetailTargetFactName; } set { _PartnerDetailTargetFactName = value; } }

		protected string _PartnerDetailTargetBankName;
		/// <summary>
		/// ���� - �� ���������� ��������-����������� (WarrantsNumbers.PartnerDetailTargetID -> PartnersDetails.BankName)
		/// </summary>
		[Description("���� - �� ���������� ��������-����������� (WarrantsNumbers.PartnerDetailTargetID -> PartnersDetails.BankName)")]
		public string PartnerDetailTargetBankName { get { return _PartnerDetailTargetBankName; } set { _PartnerDetailTargetBankName = value; } }
		*/

		protected decimal? _Amount;
		/// <summary>
		/// ����� (WarrantsNumbers.Amount)
		/// </summary>
		[Description("����� (WarrantsNumbers.Amount)")]
		public decimal? Amount { get { return _Amount; } set { _Amount = value; } }

		protected int? _CurrencyID;
		/// <summary>
		/// ������ - ��� (WarrantsNumbers.CurrencyID)
		/// </summary>
		[Description("������ - ��� (WarrantsNumbers.CurrencyID)")]
		public int? CurrencyID { get { return _CurrencyID; } set { _CurrencyID = value; } }

		protected string _CurrencyName;
		/// <summary>
		/// ������ - ������������ (WarrantsNumbers.CurrencyID -> Currencies.Name)
		/// </summary>
		[Description("������ - ������������ (WarrantsNumbers.CurrencyID -> Currencies.Name)")]
		public string CurrencyName { get { return _CurrencyName; } set { _CurrencyName = value; } }

		protected int? _OutputDocumentID;
		/// <summary>
		/// ��������� �������� - ��� (WarrantsNumbers.OutputDocumentID)
		/// </summary>
		[Description("��������� �������� - ��� (WarrantsNumbers.OutputDocumentID)")]
		public int? OutputDocumentID { get { return _OutputDocumentID; } set { _OutputDocumentID = value; } }

		protected int? _InputDocumentID;
		/// <summary>
		/// ��������� �������� - ��� (WarrantsNumbers.InputDocumentID)
		/// </summary>
		[Description("��������� �������� - ��� (WarrantsNumbers.InputDocumentID)")]
		public int? InputDocumentID { get { return _InputDocumentID; } set { _InputDocumentID = value; } }

		protected int? _InputID;
		/// <summary>
		/// ������ - ��� (WarrantsNumbers.InputID)
		/// </summary>
		[Description("������ - ��� (WarrantsNumbers.InputID)")]
		public int? InputID { get { return _InputID; } set { _InputID = value; } }

		protected int? _EmployeeID;
		/// <summary>
		/// ���������-���������� �����/������ - ��� (WarrantsNumbers.EmployeeID)
		/// </summary>
		[Description("���������-���������� �����/������ - ��� (WarrantsNumbers.EmployeeID)")]
		public int? EmployeeID { get { return _EmployeeID; } set { _EmployeeID = value; } }

		protected string _DeputyName;
		/// <summary>
		/// ���������� �����/������ - ��� (WarrantsNumbers.DeputyName)
		/// </summary>
		[Description("���������� �����/������ - ��� (WarrantsNumbers.DeputyName)")]
		public string DeputyName { get { return _DeputyName; } set { _DeputyName = value; } }

		protected string _WarrantObject;
		/// <summary>
		/// ���������� - ������/����� (WarrantsNumbers.WarrantObject)
		/// </summary>
		[Description("���������� - ������/����� (WarrantsNumbers.WarrantObject)")]
		public string WarrantObject { get { return _WarrantObject; } set { _WarrantObject = value; } }

		protected DateTime? _DateReturn;
		/// <summary>
		/// ���� �������� ������������ (WarrantsNumbers.DateReturn)
		/// </summary>
		[Description("���� �������� ������������ (WarrantsNumbers.DateReturn)")]
		public DateTime? DateReturn { get { return _DateReturn; } set { _DateReturn = value; } }

		protected bool _IsReturned;
		/// <summary>
		/// ������������ ����������, ������/����� �� �������� (WarrantsNumbers.DateReturn is not Null)?
		/// </summary>
		[Description("������������ ����������, ������/����� �� �������� (WarrantsNumbers.DateReturn is not Null)?")]
		public bool IsReturned { get { return _IsReturned; } set { _IsReturned = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� ������ � ������������ � host-������� (WarrantsNumbers.ERPCode)
		/// </summary>
		[Description("��� ������ � ������������ � host-������� (WarrantsNumbers.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// ������-����: ���� ������ ������������ - ��������� ���� ������� (WarrantsNumbers.DateIssue)
		/// </summary>
		[Description("������-����: ���� ������ ������������ - ��������� ���� ������� (WarrantsNumbers.DateIssue)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// ������-����: ���� ������ ������������ - �������� ���� ������� (WarrantsNumbers.DateIssue)
		/// </summary>
		[Description("������-����: ���� ������ ������������ - �������� ���� ������� (WarrantsNumbers.DateIssue)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterNumberContext;
		/// <summary>
		/// ������-����: �������� ������ ������������ (WarrantsNumbers.Number)
		/// </summary>
		[Description("������-����: �������� ������ ������������ (WarrantsNumbers.Number)")]
		public string FilterNumberContext { get { return _FilterNumberContext; } set { _FilterNumberContext = value; _NeedRequery = true; } }

		protected bool? _FilterIsMoney;
		/// <summary>
		/// ������-����: ������������ �� ��������� ����� (�� ������) �� ������� (WarrantsNumbers.OutputDocumentID -> OutputsDocuments)?
		/// </summary>
		[Description("������-����: ������������ �� ��������� ����� (�� ������) �� ������� (WarrantsNumbers.OutputDocumentID -> OutputsDocuments)?")]
		public bool? FilterIsMoney { get { return _FilterIsMoney; } set { _FilterIsMoney = value; _NeedRequery = true; } }

		protected string _FilterPartnersSourceList;
		/// <summary>
		/// ������-����: ������ ����� ���������, ���������� ������������, ����� ������� (WarrantsNumbers.PartnerSourceID)
		/// </summary>
		[Description("������-����: ������ ����� ���������, ���������� ������������, ����� ������� (WarrantsNumbers.PartnerSourceID)")]
		public string FilterPartnersSourceList { get { return _FilterPartnersSourceList; } set { _FilterPartnersSourceList = value; _NeedRequery = true; } }

		/*
		protected string _FilterPartnersDetailsSourceList;
		/// <summary>
		/// ������-����: ������ ����� ���������� ���������, ���������� ������������, ����� ������� (WarrantsNumbers.PartnerDetailSourceID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� ���������, ���������� ������������, ����� ������� (WarrantsNumbers.PartnerDetailSourceID)")]
		public string FilterPartnersDetailsSourceList { get { return _FilterPartnersDetailsSourceList; } set { _FilterPartnersSourceList = value; _NeedRequery = true; } }
		*/

		protected string _FilterPartnersTargetList;
		/// <summary>
		/// ������-����: ������ ����� ���������-������������, ����� ������� (WarrantsNumbers.PartnerTargetID)
		/// </summary>
		[Description("������-����: ������ ����� ���������-������������, ����� ������� (WarrantsNumbers.PartnerTargetID)")]
		public string FilterPartnersTargetList { get { return _FilterPartnersTargetList; } set { _FilterPartnersTargetList = value; _NeedRequery = true; } }

		/*
		protected string _FilterPartnersDetailsTargetList;
		/// <summary>
		/// ������-����: ������ ����� ���������� ���������-������������, ����� ������� (WarrantsNumbers.PartnerDetailTargetID)
		/// </summary>
		[Description("������-����: ������ ����� ���������� ���������-������������, ����� ������� (WarrantsNumbers.PartnerDetailTargetID)")]
		public string FilterPartnersDetailsTargetList { get { return _FilterPartnersDetailsTargetList; } set { _FilterPartnersTargetList = value; _NeedRequery = true; } }
		*/

		protected string _FilterEmployeesList;
		/// <summary>
		/// ������-����: ������ ����� �����������-����������� �����/������, ����� ������� (WarrantsNumbers.EmployeeID)
		/// </summary>
		[Description("������-����: ������ ����� �����������-����������� �����/������, ����� ������� (WarrantsNumbers.EmployeeID)")]
		public string FilterEmployeesList { get { return _FilterEmployeesList; } set { _FilterEmployeesList = value; _NeedRequery = true; } }

		protected string _FilterDeputyNameContext;
		/// <summary>
		/// ������-����: �������� ��� ���������� �����/������ (WarrantsDeputyNames.DeputyName)
		/// </summary>
		[Description("������-����: �������� ��� ���������� �����/������ (WarrantsDeputyNames.DeputyName)")]
		public string FilterDeputyNameContext { get { return _FilterDeputyNameContext; } set { _FilterDeputyNameContext = value; _NeedRequery = true; } }

		protected string _FilterOutputsDocumentsList;
		/// <summary>
		/// ������-����: ������ ����� ��������� ����������, ����� ������� (WarrantsNumbers.OutputDocumentID)
		/// </summary>
		[Description("������-����: ������ ����� ��������� ����������, ����� ������� (WarrantsNumbers.OutputDocumentID)")]
		public string FilterOutputsDocumentsList { get { return _FilterOutputsDocumentsList; } set { _FilterOutputsDocumentsList = value; _NeedRequery = true; } }

		protected string _FilterInputsDocumentsList;
		/// <summary>
		/// ������-����: ������ ����� ��������� ����������, ����� ������� (WarrantsNumbers.InputDocumentID)
		/// </summary>
		[Description("������-����: ������ ����� ��������� ����������, ����� ������� (WarrantsNumbers.InputDocumentID)")]
		public string FilterInputsDocumentsList { get { return _FilterInputsDocumentsList; } set { _FilterInputsDocumentsList = value; _NeedRequery = true; } }

		protected string _FilterInputsList;
		/// <summary>
		/// ������-����: ������ ����� ��������, ����� ������� (WarrantsNumbers.InputID)
		/// </summary>
		[Description("������-����: ������ ����� ��������, ����� ������� (WarrantsNumbers.InputID)")]
		public string FilterInputsList { get { return _FilterInputsList; } set { _FilterInputsList = value; _NeedRequery = true; } }

		protected bool? _FilterIsReturned;
		/// <summary>
		/// ������-����: ������������ ���������� (WarrantsNumbers.IsReturned)?
		/// </summary>
		[Description("������-����: ������������ ���������� (WarrantsNumbers.IsReturned)?")]
		public bool? FilterIsReturned { get { return _FilterIsReturned; } set { _FilterIsReturned = value; _NeedRequery = true; } }

		#endregion �������

		// ----------------------------

		public WarrantNumber()
			: base()
		{
			_MainTableName = "WarrantsNumbers";
			_ColumnID = "ID";
			_ColumnName = "Number";
		}


		#region FillData

		/// <summary>
		/// ��������� ������� ������ �������� ������������� � MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_WarrantsNumbersFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@cNumberContext, " +
									"@bIsMoney, " +
									"@cPartnersSourceList, /*@cPartnersDetailsSourceList, */" +
									"@cPartnersTargetList, /*@cPartnersDetailsTargetList, */" +
									"@cEmployeesList, " +
									"@cDeputyNameContext, " +
									"@cOutputsDocumentsList, @cInputsDocumentsList, @cInputsList, " +
									"@bIsReturned";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_WarrantsNumbersFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cNumberContext", SqlDbType.VarChar);
			if (_FilterNumberContext != null)
				_oParameter.Value = _FilterNumberContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsMoney", SqlDbType.Bit);
			if (_FilterIsMoney != null)
				_oParameter.Value = _FilterIsMoney;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersSourceList", SqlDbType.VarChar);
			if (_FilterPartnersSourceList != null)
				_oParameter.Value = _FilterPartnersSourceList;
			else
				_oParameter.Value = DBNull.Value;

			/*
			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsSourceList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsSourceList != null)
				_oParameter.Value = _FilterPartnersDetailsSourceList;
			else
				_oParameter.Value = DBNull.Value;
			*/

			_oParameter = _oCommand.Parameters.Add("@cPartnersTargetList", SqlDbType.VarChar);
			if (_FilterPartnersTargetList != null)
				_oParameter.Value = _FilterPartnersTargetList;
			else
				_oParameter.Value = DBNull.Value;

			/*
			_oParameter = _oCommand.Parameters.Add("@cPartnersDetailsTargetList", SqlDbType.VarChar);
			if (_FilterPartnersDetailsTargetList != null)
				_oParameter.Value = _FilterPartnersDetailsTargetList;
			else
				_oParameter.Value = DBNull.Value;
			*/

			_oParameter = _oCommand.Parameters.Add("@cEmployeesList", SqlDbType.VarChar);
			if (_FilterEmployeesList != null)
				_oParameter.Value = _FilterEmployeesList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cDeputyNameContext", SqlDbType.VarChar);
			if (_FilterDeputyNameContext != null)
				_oParameter.Value = _FilterDeputyNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			if (_FilterOutputsDocumentsList != null)
				_oParameter.Value = _FilterOutputsDocumentsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsDocumentsList", SqlDbType.VarChar);
			if (_FilterInputsDocumentsList != null)
				_oParameter.Value = _FilterInputsDocumentsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cInputsList", SqlDbType.VarChar);
			if (_FilterInputsList != null)
				_oParameter.Value = _FilterInputsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsReturned", SqlDbType.Bit);
			if (_FilterIsReturned != null)
				_oParameter.Value = _FilterIsReturned;
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
			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterNumberContext = null;
			_FilterIsMoney = null;
			_FilterPartnersSourceList = null;
			//_FilterPartnersDetailsSourceList = null;
			_FilterPartnersTargetList = null;
			//_FilterPartnersDetailsTargetList = null;
			_FilterEmployeesList = null;
			_FilterDeputyNameContext = null;
			_FilterOutputsDocumentsList = null;
			_FilterInputsDocumentsList = null;
			_FilterInputsList = null;
			_FilterIsReturned = null;
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

					_Number = r["Number"].ToString();
					_NumberInt = Convert.ToInt32(r["NumberInt"]);
					if (!Convert.IsDBNull(r["DateIssue"]))
						_DateIssue = Convert.ToDateTime(r["DateIssue"]);
					if (!Convert.IsDBNull(r["DateTill"]))
						_DateTill = Convert.ToDateTime(r["DateTill"]);

					_PartnerSourceID = Convert.ToInt32(r["PartnerSourceID"]);
					_PartnerSourceName = r["PartnerSourceName"].ToString();
					/*
					if (!Convert.IsDBNull(r["PartnerDetailSourceID"]))
						_PartnerDetailSourceID = Convert.ToInt32(r["PartnerDetailSourceID"]);
					_PartnerDetailSourceFactName = r["PartnerDetailSourceFactName"].ToString();
					_PartnerDetailSourceBankName = r["PartnerDetailSourceBankName"].ToString();
					*/
					_PartnerTargetID = Convert.ToInt32(r["PartnerTargetID"]);
					_PartnerTargetName = r["PartnerTargetName"].ToString();
					/*
					_PartnerDetailTargetID = Convert.ToInt32(r["PartnerDetailTargetID"]);
					_PartnerDetailTargetFactName = r["PartnerDetailTargetFactName"].ToString();
					_PartnerDetailTargetBankName = r["PartnerDetailTargetBankName"].ToString();
					*/ 

					if (!Convert.IsDBNull(r["Amount"]))
						_Amount = Convert.ToDecimal(r["Amount"]);
					if (!Convert.IsDBNull(r["CurrencyID"]))
					{
						_CurrencyID = Convert.ToInt32(r["CurrencyID"]);
						_CurrencyName = r["CurrencyName"].ToString();
					}

					if (!Convert.IsDBNull(r["OutputDocumentID"]))
						_OutputDocumentID = Convert.ToInt32(r["OutputDocumentID"]);
					if (!Convert.IsDBNull(r["InputDocumentID"]))
						_InputDocumentID = Convert.ToInt32(r["InputDocumentID"]);
					if (!Convert.IsDBNull(r["InputID"]))
						_InputID = Convert.ToInt32(r["InputID"]);

					if (!Convert.IsDBNull(r["EmployeeID"]))
						_EmployeeID = Convert.ToInt32(r["EmployeeID"]);
					_DeputyName = r["DeputyName"].ToString();

					_IsMoney = Convert.ToBoolean(r["IsMoney"]);
					_WarrantObject = r["WarrantObject"].ToString();

					if (!Convert.IsDBNull(r["DateReturn"]))
						_DateReturn = Convert.ToDateTime(r["DateReturn"]);
					_IsReturned = Convert.ToBoolean(r["IsReturned"]);

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
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

			_Number = "";
			_NumberInt = 0;
			_DateIssue = null;
			_DateTill = null;

			_PartnerSourceID = 0;
			_PartnerSourceName = null;
			/*
			_PartnerDetailSourceID = null;
			_PartnerDetailSourceFactName = null;
			_PartnerDetailSourceBankName = null;
			*/ 
			_PartnerTargetID = 0;
			_PartnerTargetName = null;
			/*
			_PartnerDetailTargetID = 0;
			_PartnerDetailTargetFactName = null;
			_PartnerDetailTargetBankName = null;
			*/

			_Amount = null;
			_CurrencyID = null;
			_CurrencyName = null;

			_OutputDocumentID = null;
			_InputDocumentID = null;
			_InputID = null;

			_EmployeeID = null;
			_DeputyName = null;

			_IsMoney = true;
			_WarrantObject = null;

			_DateReturn = null;
			_IsReturned = false;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Update 

		/// <summary>
		/// �������� ������������
		/// </summary>
		public bool Update(int? nOutputDocumentID, int? nInputDocumentID, int? nInputID)
		{
			String _sqlCommand = "execute up_WarrantsNumbersUpdate @nOutputDocumentID, @nInputDocumentID, @nInputID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_WarrantNumbersDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nOutputDocumentID", SqlDbType.Int);
			if (nOutputDocumentID.HasValue)
				_oParameter.Value = nOutputDocumentID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nInputDocumentID", SqlDbType.Int);
			if (nInputDocumentID.HasValue)
				_oParameter.Value = nInputDocumentID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nInputID", SqlDbType.Int);
			if (nInputID.HasValue)
				_oParameter.Value = nInputID;
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
				_ErrorNumber = -20;
				_ErrorStr = "������ ��� ������� ���������� ������ � ������������...\r\n" + ex.Message;
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
					_ErrorStr = "������ ��� ���������� ������ � ������������...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Update 

		#region Return

		/// <summary>
		/// ����������� ����������� ������������
		/// </summary>
		public bool Return(int nWarrantID)
		{
			string _sqlCommand = "update WarrantsNumbers " +
					"set DateReturn = GetDate() " + 
					"where ID = " + nWarrantID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ����������� �������� ������������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������� �������� ������������ 
		/// </summary>
		public bool UnReturn(int nWarrantID)
		{
			string _sqlCommand = "update WarrantsNumbers " +
					"set DateReturn = Null " +
					"where ID = " + nWarrantID.ToString();
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			try
			{
				_Connect.Open();
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "������ ��� ������ ������� �������� ������������...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Return

		#region Delete

		/// <summary>
		/// �������� ������������
		/// </summary>
		public bool Delete(int nWarrantID)
		{
			String _sqlCommand = "execute up_WarrantsNumbersDelete @nWarrantID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_WarrantNumbersDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nWarrantID", SqlDbType.Int);
			_oParameter.Value = nWarrantID;

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
				_ErrorStr = "������ ��� ������� �������� ������ � ������������...\r\n" + ex.Message;
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

		#endregion Delete

	}

#endregion WarrantNumber

}
