using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// ������-������ ������� ������ (DBTable)
/// </summary>
/// 
namespace LogBizObjects
{
	public class DBTable : BizObject 
	{
		protected string _RusTableName;
		/// <summary>
		/// ������� �������� (��������) �������
		/// </summary>
		[Description("������� �������� (��������) �������")]
		public string RusTableName { get { return _RusTableName; } set { _RusTableName = value; _NeedRequery = true; } }

		protected string _FullTableName;
		/// <summary>
		/// ������ �������� �������: ��� (���) 
		/// </summary>
		[Description("������ �������� �������: ��� (���)")]
		public string FullTableName { get { return _FullTableName; } set { _FullTableName = value; _NeedRequery = true; } }

		protected int? _recordID;
		/// <summary>
		/// ID ������ ��������� �������
		/// </summary>
		[Description("ID ������ ��������� �������")]
		public int? recordID { get { return _recordID ; } set { _recordID = value; _NeedRequery = true; } }

		protected DataTable _TableStructure;
		/// <summary>
		/// ��������� ��������� ������� ������
		/// </summary>
		[Description("��������� ��������� ������� ������")]
		public DataTable TableStructure { get { return _TableStructure; } }

		protected DataTable _TableRecordToSave;
		/// <summary>
		/// ������ � ������� ��� ����������
		/// </summary>
		[Description("������ � ������� ��� ����������")]
		public DataTable TableRecordToSave { get { return _TableRecordToSave; } }


		public DBTable() : base()
		{
			_MainTableName = "_Tables";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}

		public DBTable(string sMainTableName) : this()
		{
			_MainTableName = sMainTableName;
		}
		

		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "select *, rtrim(TableName) + ' (' + rtrim(Name) + ')' as FullTableName " +
				"from _Tables " + 
				"where ForLook = 1 " + 
				"order by TableName";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_NeedRequery = false;
				ColumnName = "FullTableName";
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ������ ������� " + _MainTableName + "...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public bool FillNames()
		{
			_RusTableName = _FullTableName = "";

			if (_MainTableName == null || _MainTableName.Length == 0)
				return (false);

			string sqlSelect = "select *, rtrim(TableName) + ' (' + rtrim(Name) + ')' as FullTableName " +
				"from _Tables " +
				"where ForLook = 1 and TableName = '" + _MainTableName + "' "+
				"order by TableName";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TempTable");
				if (_DS.Tables["TempTable"].Rows.Count > 0)
				{ 
					DataRow dr = _DS.Tables["TempTable"].Rows[0];
					_FullTableName = dr["FullTableName"].ToString();
					_RusTableName = dr["Name"].ToString();
				}
				_DS.Tables.Remove("TempTable");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ������ � ������� " + _MainTableName + "...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		public override bool FillOneRow(DataRow r)
		{
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// ������ ������� ��������� �������
		/// </summary>
		/// <param name="nID">ID ������ ������, null - ��� ������</param>
		/// <param name="bIsRowNumber">��������� � ������ ��������� ��������</param>
		/// <returns>true ��� OK</returns>
		public bool GetRecordsList(int? nID, bool bIsRowNumber)
		{
			ClearData();

			string sqlSelect = "exec sy_TableDataGet @cTable, 1, @bRowNumber, @nID, '', '', " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region sy_TableDataGet parameters

			SqlParameter _oParameter =  _oCommand.Parameters.Add("@cTable", SqlDbType.VarChar);
			_oParameter.Value = _MainTableName;

			_oParameter = _oCommand.Parameters.Add("@bRowNumber", SqlDbType.Bit);
			_oParameter.Value = bIsRowNumber;

			_oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (nID.HasValue)
				_oParameter.Value = Math.Abs((int)nID);
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
				_MainTable = FillReadings(new SqlDataAdapter(_oCommand), _MainTable, _MainTableName);
				_MainTable.PrimaryKey = new DataColumn[] { _MainTable.Columns[_ColumnID] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -2;
				_ErrorStr = "������ ��� ��������� ������ ������� " + _MainTableName + "...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "������ ��� ��������� ������ ������� " + _MainTableName + "...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}


		/// <summary>
		/// ��������� ��������� �������
		/// </summary>
		/// <param name="bIsRowNumber">��������� � ������ ��������� ��������</param>
		/// <returns>true ��� OK</returns>
		public bool GetStructure(bool bIsRowNumber)
		{
			string sqlSelect = "exec sy_TableStructureGet @cTable, 1, @bRowNumber, 1, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region sy_TableStructureGet parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cTable", SqlDbType.VarChar);
			_oParameter.Value = _MainTableName;

			_oParameter = _oCommand.Parameters.Add("@bRowNumber", SqlDbType.Bit);
			_oParameter.Value = bIsRowNumber;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableStructure = FillReadings(new SqlDataAdapter(_oCommand), _TableStructure, "TableStructure");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -3;
				_ErrorStr = "������ ��� ��������� ��������� ������� " + _MainTableName + "...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorNumber = -3;
					_ErrorStr = "������ ��� ��������� ��������� ������� " + _MainTableName + "...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else 
				{
					if (_TableStructure.Rows.Count == 0)
					{
						_ErrorNumber = -3;
						_ErrorStr = "��� ������ � ��������� ������� " + _MainTableName + "...\r\n";
						RFMMessage.MessageBoxError(_ErrorStr);
					}
				}
			}
			return (_ErrorNumber == 0);
		}


		/// <summary>
		/// ������ ������� �������������� ��� ��������� �������
		/// </summary>
		/// <param name="nID">ID ������ ������, null - ��� ������</param>
		/// <param name="bIsRowNumber">��������� � ������ ��������� ��������</param>
		/// <returns>ture ��� OK</returns>
		public bool GetFKRecordsList(string sFKTableName, string sFKTableNameDS)
		{
			if (sFKTableNameDS.Length == 0) 
				sFKTableNameDS = sFKTableName;

			string sqlSelect = "exec sy_TableDataGetSimple @cTable, @nCustomLen output, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region sy_TableDataGetSimple parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cTable", SqlDbType.VarChar);
			_oParameter.Value = sFKTableName;

			_oParameter = _oCommand.Parameters.Add("@nCustomLen", SqlDbType.Int);
            _oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, sFKTableNameDS);
				_DS.Tables[sFKTableNameDS].PrimaryKey = new DataColumn[] { _DS.Tables[sFKTableNameDS].Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -4;
				_ErrorStr = "������ ��� ��������� ������ �������������� " + sFKTableName + " ��� ������� " + _MainTableName + "...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorNumber = -4;
					_ErrorStr = "������ ��� ��������� ������ �������������� " + sFKTableName + " ��� ������� " + _MainTableName + "...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else 
				{
					_DS.Tables[sFKTableNameDS].Columns[1].MaxLength = Convert.ToInt32(_oCommand.Parameters["@nCustomLen"].Value) + 1;
				}
			}
			return (_ErrorNumber == 0);
		}


		/// <summary>
		/// ����������� �������� -> � ������� TableRecordToSave
		/// </summary>
		/// <returns></returns>
		public void PrepareDataToSave()
		{
			if (_DS.Tables["TableRecordToSave"] != null)
			{
				//_DS.Tables.Remove("TableRecordToSave");
				_TableRecordToSave.Columns.Clear();
				_TableRecordToSave.Clear();
			}
			else
			{
				_DS.Tables.Add("TableRecordToSave");
			}
			_TableRecordToSave = _DS.Tables["TableRecordToSave"];
			_TableRecordToSave.Rows.Add();
		}


		/// <summary>
		/// ���������� ������
		/// </summary>
		/// <returns></returns>
		public bool RecordSave()
		{
			if (_recordID == null)
				return (false);

			int nOldID = (int)_recordID;

			// ������� ds.Tables("RecordToSave"), ���������� �������� ��� ���������� -> XML
			System.IO.StringWriter oStringWriter = new System.IO.StringWriter();
			_TableRecordToSave.WriteXml(oStringWriter);
			string xmlString = oStringWriter.ToString(); 

			string sqlSelect = "exec sy_TableDataSaveXml @cTable, @nID output, @xXml, @cTableRecordToSave, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region sy_TableDataSaveXml parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cTable", SqlDbType.VarChar);
            _oParameter.Value = _MainTableName;

			_oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = _recordID;

			_oParameter = _oCommand.Parameters.Add("@xXml", SqlDbType.Xml);
			_oParameter.Value = xmlString;

			_oParameter = _oCommand.Parameters.Add("@cTableRecordToSave", SqlDbType.VarChar, 100);
			_oParameter.Value = "TableRecordToSave";

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
				_oCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "������ ��� ���������� ������ (xml) ������� " + _MainTableName + "...\r\n" + ex.Message;
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
					_ErrorNumber = -11;
					_ErrorStr = "������ ��� ���������� ������ (xml) ������� " + _MainTableName + "...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else 
				{
					// �������� ��� ����������� ������
					if (nOldID == 0)
					{
						if (!Convert.IsDBNull(_oCommand.Parameters["@nID"].Value))
						{
							_recordID = Convert.ToInt32(_oCommand.Parameters["@nID"].Value);
							RFMMessage.MessageBoxInfo("������ ��������� � ����� " + _recordID.ToString());
						}
						else
						{
							_ErrorNumber = -11;
							_ErrorStr = "������ ��� ��������� ���� ����������� ������ � ������� " + _MainTableName + "...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
							RFMMessage.MessageBoxError(_ErrorStr);
						}
					}
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// �������� ������
		/// </summary>
		public bool RecordDelete()
		{
			if (_recordID == null)
				return (false);

			int nOldID = (int)_recordID;


			string sqlSelect = "exec sy_TableDataDelete @cTable, @nID, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region sy_TableDataDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@cTable", SqlDbType.VarChar);
            _oParameter.Value = _MainTableName;

			_oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			_oParameter.Value = _recordID;

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
				_oCommand.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -12;
				_ErrorStr = "������ ��� �������� ������ �� ������� " + _MainTableName + "...\r\n" + ex.Message;
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
					_ErrorNumber = -11;
					_ErrorStr = "������ ��� �������� ������ �� ������� " + _MainTableName + "...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				else 
				{
					RFMMessage.MessageBoxInfo("������ �������.");
				}
			}
			return (_ErrorNumber == 0);
		}


		public bool IsFieldInExchange(string sTableName, string sColumnName)
		{
			bool bIsFieldInExchange = false;
			string sqlSelect = "select * " +
				"from _ExchangeClassificators with (nolock) " +
				"where upper(TableName) = '" + sTableName.ToUpper() + "' and upper(ColumnName) = '" + sColumnName.ToUpper() + "' "; 
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TempTable");
				if (_DS.Tables["TempTable"].Rows.Count > 0)
				{
					bIsFieldInExchange = true;
				}
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "������ ��� ��������� ������ � ��������� ������ ������� (" + sTableName + "." + sColumnName + ")...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (bIsFieldInExchange);
		}
	}
}
