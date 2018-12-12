using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ���� (Host)
/// </summary>

namespace LogBizObjects
{

#region Host

	public class Host : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ������ (Hosts.ID)
		/// </summary>
		[Description("������ ����� ID ������ (Hosts.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _Name;
		/// <summary>
		/// ������������ ����� (Hosts.Name)
		/// </summary>
		[Description("������������ ����� (Hosts.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _ShortCode;
		/// <summary>
		/// ���������� ��� (Hosts.ShortCode)
		/// </summary>
		[Description("���������� ��� (Hosts.ShortCode)")]
		public string ShortCode { get { return _ShortCode; } set { _ShortCode = value; } }

		protected bool _Actual;
		/// <summary>
		/// ��������� (Hosts.Actual)?
		/// </summary>
		[Description("��������� (Hosts.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _Password;
		/// <summary>
		/// ������* (Hosts.Password)
		/// </summary>
		[Description("������* (Hosts.Password)")]
		public string Password { get { return _Password; } set { _Password = value; } }

		#endregion ����, ��������

		#region �������

		protected string _FilterNameContext;
		/// <summary>
		/// ������-����: �������� �����, �������� (Hosts.Name)
		/// </summary>
		[Description("������-����: �������� �����, �������� (Hosts.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		protected string _FilterShortCode;
		/// <summary>
		/// ������-����: ���������� ��� �����, �������� (Hosts.ShortCode)
		/// </summary>
		[Description("������-����: ���������� ��� �����, �������� (Hosts.ShortCode)")]
		public string FilterShortCode { get { return _FilterShortCode; } set { _FilterShortCode = value; _NeedRequery = true; } }

		protected bool? _FilterActual;
		/// <summary>
		/// ������-����: ���������� ������� (Partners.Actual)?
		/// </summary>
		[Description("������-����: ���������� ������� (Partners.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

		#endregion �������

		// -------------------
		
		public Host() : base()
		{
			_MainTableName = "Hosts";
			_ColumnID = "ID";
			_ColumnName = "Name"; 
		}

		#region FillData

		/// <summary>
		/// ��������� ������� ������ ������ � MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_HostsFill @nID, @cIDList, " +
									"@cNameContext, " +
									"@cShortCode, " + 
									"@bActual ";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_HostsFill Parameters

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

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar, 200);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cShortCode", SqlDbType.VarChar, 200);
			if (_FilterShortCode != null)
				_oParameter.Value = _FilterShortCode;
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
				_ErrorStr = "������ ��� ��������� ������ ������ ������..." + Convert.ToChar(13) + ex.Message;
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
			_FilterShortCode = null;
			_FilterActual = null;
		}

		#endregion FillData

		#region FillOne

		// ���������� ������� ���������� ������� ������� ������ 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();

			if (r != null)
			{
				try
				{
					_ID = Convert.ToInt32(r["ID"]);
					_Name = r["Name"].ToString();
					_ShortCode = r["ShortCode"].ToString();
					_Actual = Convert.ToBoolean(r["Actual"]);
					_Password = r["Password"].ToString(); // !!!
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � �����...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ����� (��� ������)...";
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
			_IDList = null;
			_Name = null;
			_ShortCode = null;
			_Actual = false;
			_Password = null;
		}

		#endregion FillOne

		#region Count

		public int Count()
		{
			_FilterActual = true;
			FillDataAsync();
			return (MainTable.Rows.Count);
		}

		#endregion Count
	}

#endregion Host

}
