using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ �������-��������� (��������) ������ (Owner)
/// </summary>

namespace LogBizObjects
{
	public class Owner : BizObject
	{
		protected int? _OwnerID;
		/// <summary>
		/// ��� ID ������ ������� (Partners.ID)
		/// </summary>
		[Description("ID ������ ������� (Partners.ID)")]
		public int? OwnerID { get { return ID; } set { ID = value; } }

		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ���������� (Partners.ID)
		/// </summary>
		[Description("������ ID ���������� (Partners.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _Name;
		/// <summary>
		/// ������������ (Partners.Name)
		/// </summary>
		[Description("������������ (Partners.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected bool _SeparatePicking;
		/// <summary>
		/// ���������� �������� ������ (Partners.SeparatePicking)?
		/// </summary>
		[Description("���������� �������� ������ (Partners.SeparatePicking)?")]
		public bool SeparatePicking { get { return _SeparatePicking; } set { _SeparatePicking = value; } }

		protected bool _Actual;
		/// <summary>
		/// ��������� (Partners.Actual)?
		/// </summary>
		[Description("��������� (Partners.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� � host-������� (Partners.ERPCode)
		/// </summary>
		[Description("��� � host-������� (Partners.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected bool? _FilterActual;
		/// <summary>
		/// ������-����: ���������� ��������� ������ (Partners.Actual)?
		/// </summary>
		[Description("������-����: ���������� ��������� ������ (Partners.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; } }

		protected bool? _FilterSeparatePicking;
		/// <summary>
		/// ������-����: ���������� �������� ������ (Partners.SeparatePicking)?
		/// </summary>
		[Description("������-����: ���������� �������� ������ (Partners.SeparatePicking)?")]
		public bool? FilterSeparatePicking { get { return _FilterSeparatePicking; } set { _FilterSeparatePicking = value; } }

		#endregion �������

		// -------------------

		public Owner()
			: base()
		{
			_MainTableName = "Owners";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}

		#region FillData

		//��������� ������� ��������� ��� 
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "select Cl.ID, Cl.Name, " +
					"Cl.SeparatePicking, " + 
					"Cl.Actual " +
				"from Partners Cl with (nolock) " +
				"where Cl.IsOwner = 1 ";
			StringBuilder sb = new StringBuilder(sqlSelect);
			if (_ID != null)
				sb.Append(" and Cl.ID = " + _ID.ToString());
			if (_IDList != null)
				sb.Append(" and charindex(',' + ltrim(str(Cl.ID)) + ',', ',' + '" + _IDList + "' + ',') > 0");
			if (_FilterActual != null)
				sb.Append(" and Cl.Actual = " + ((bool)_FilterActual ? "1" : "0"));
			if (_FilterSeparatePicking != null)
				sb.Append(" and Cl.SeparatePicking = " + ((bool)_FilterSeparatePicking ? "1" : "0"));
			sb.Append(" order by Cl.Name, Cl.ID");
			SqlCommand _oCommand = new SqlCommand(sb.ToString(), _Connect);
			try
			{
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_MainTable.PrimaryKey = new DataColumn[] { _MainTable.Columns[_ColumnID] };
				_NeedRequery = false;
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ������ ���������� ������..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������� ������-�����
		/// </summary>
		public void ClearFilters()
		{
			_FilterActual = null;
			_FilterSeparatePicking = null;
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
					_SeparatePicking = Convert.ToBoolean(r["SeparatePicking"]);
					_Actual = Convert.ToBoolean(r["Actual"]);
					_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ���������� ������...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "������ ��� ��������� ������ � ��������� ������ (��� ������)...";
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
			_SeparatePicking  = false;
			_Actual = false;

			_ERPCode = null;
		}

		#endregion FillOne

	}
}
