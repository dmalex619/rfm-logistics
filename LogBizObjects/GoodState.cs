using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ��������� ������ (GoodState)
/// </summary>

namespace LogBizObjects
{
	public class GoodState : BizObject
	{
		protected int? _GoodStateID;
		/// <summary>
		/// ��� ID ������ ��������� ������ (GoodsStates.ID)
		/// </summary>
		[Description("ID ������ ��������� ������ (GoodsStates.ID)")]
		public int? GoodStateID { get { return ID; } set { ID = value; } }

		protected string _IDList;
		/// <summary>
		/// ������ ����� ID ��������� ������ (GoodsStates.ID)
		/// </summary>
		[Description("������ ID ��������� ������ (GoodsStates.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region ����, ��������

		protected string _Name;
		/// <summary>
		/// ������������ (GoodsStates.Name)
		/// </summary>
		[Description("������������ (GoodsStates.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _Note;
		/// <summary>
		/// ���������� (GoodsStates.Note)
		/// </summary>
		[Description("���������� (GoodsStates.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected int? _OwnerID;
		/// <summary>
		/// �������� ������ - ��� (GoodsStates.OwnerID -> Partners.ID)
		/// </summary>
		[Description("�������� ������ - ��� (GoodsStates.OwnerID -> Partners.ID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// �������� ������ - ������������ (Outputs.PartnerID -> Partners.ID -> Partners.Name)
		/// </summary>
		[Description("�������� ������ - ������������ (Outputs.PartnerID -> Partners.ID -> Partners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

		protected bool _Basic;
		/// <summary>
		/// �������� (GoodsStates.Basic)?
		/// </summary>
		[Description("�������� (GoodsStates.Basic)?")]
		public bool Basic { get { return _Basic; } set { _Basic = value; } }

		protected bool _Actual;
		/// <summary>
		/// ��������� (GoodsStates.Actual)?
		/// </summary>
		[Description("��������� (GoodsStates.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// ��� � host-������� (GoodsStates.ERPCode)
		/// </summary>
		[Description("��� � host-������� (GoodsStates.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion ����, ��������

		#region �������

		protected bool? _FilterActual;
		/// <summary>
		/// ������-����: ���������� ��������� ������ (GoodsStates.Actual)?
		/// </summary>
		[Description("������-����: ���������� ��������� ������ (GoodsStates.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; } }

		protected bool? _FilterBasic;
		/// <summary>
		/// ������-����: ������� ��������� ������ (GoodsStates.Basic)?
		/// </summary>
		[Description("������-����: ������� ��������� ������ (GoodsStates.Basic)?")]
		public bool? FilterBasic { get { return _FilterBasic; } set { _FilterBasic = value; } }

		#endregion �������

		// -------------------

		public GoodState()
			: base()
		{
			_MainTableName = "GoodState";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}

		#region FillData

		//��������� ������� ��������� ��� 
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "select GS.ID, GS.Name, " +
					"GS.Note, " +
					"GS.OwnerID, Ow.Name as OwnerName, " + 
					"GS.Basic, GS.Actual " +
				"from GoodsStates GS with (nolock) " +
				"left join Partners Ow with (nolock) on GS.OwnerID = Ow.ID " +
				"where 1 = 1 ";
			StringBuilder sb = new StringBuilder(sqlSelect);
			if (_ID != null)
				sb.Append(" and GS.ID = " + _ID.ToString());
			if (_IDList != null)
				sb.Append(" and charindex(',' + ltrim(str(GS.ID)) + ',', ',' + '" + _IDList + "' + ',') > 0");
			if (_FilterActual != null)
				sb.Append(" and GS.Actual = " + ((bool)_FilterActual ? "1" : "0"));
			if (_FilterBasic != null)
				sb.Append(" and GS.Basic = " + ((bool)_FilterBasic ? "1" : "0"));
			sb.Append(" order by GS.Name, GS.ID");
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
				_ErrorStr = "������ ��� ��������� ������ ��������� ������..." + Convert.ToChar(13) + ex.Message;
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
			_FilterBasic = null;
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
					_Note = r["Note"].ToString();
					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					_Basic = Convert.ToBoolean(r["Basic"]);
					_Actual = Convert.ToBoolean(r["Actual"]);
					_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "������ ��� ��������� ������ � ��������� ������...\n" +
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
			_Note = null;
			_OwnerID = null;
			_OwnerName = null;
			_Basic = false;
			_Actual = false;

			_ERPCode = null;
		}

		#endregion FillOne

	}
}
