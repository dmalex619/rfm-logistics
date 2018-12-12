using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Cчет-фактура - запись в журнале счетов-фактур (FactureNumber)
/// </summary>
/// 
namespace LogBizObjects
{

#region FactureNumber

	public class FactureNumber : BizObject
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID счетов-фактур (FacturesNumbers.ID)
		/// </summary>
		[Description("Список кодов ID счетов-фактур (FacturesNumbers.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Number;
		/// <summary>
		/// Номер счета-фактуры (FacturesNumbers.Number)
		/// </summary>
		[Description("Номер счета-фактуры (FacturesNumbers.Number)")]
		public string Number { get { return _Number; } set { _Number = value; } }

		protected int _NumberInt;
		/// <summary>
		/// Номер счета-фактуры - число (FacturesNumbers.NumberInt)
		/// </summary>
		[Description("Номер счета-фактуры - число (FacturesNumbers.NumberInt)")]
		public int NumberInt { get { return _NumberInt; } set { _NumberInt = value; } }

		protected DateTime? _DateIssue;
		/// <summary>
		/// Дата выдачи (FacturesNumbers.DateIssue)
		/// </summary>
		[Description("Дата выдачи (FacturesNumbers.DateIssue)")]
		public DateTime? DateIssue { get { return _DateIssue; } set { _DateIssue = value; } }

		protected int _PartnerSourceID;
		/// <summary>
		/// Партнер, выписавший счет-фактуру (мы) - код (FacturesNumbers.PartnerSourceID)
		/// </summary>
		[Description("Партнер, выписавший счет-фактуру (мы) - код (FacturesNumbers.PartnerSourceID)")]
		public int PartnerSourceID { get { return _PartnerSourceID; } set { _PartnerSourceID = value; } }

		protected string _PartnerSourceName;
		/// <summary>
		/// Партнер, выписавший счет-фактуру (мы) - наименование (FacturesNumbers.PartnerSourceID -> FacturesNumbersTypes.Name)
		/// </summary>
		[Description("Партнер, выписавший счет-фактуру (мы) - наименование (FacturesNumbers.PartnerSourceID -> FacturesNumbersTypes.Name)")]
		public string PartnerSourceName { get { return _PartnerSourceName; } set { _PartnerSourceName = value; } }

		protected int _PartnerTargetID;
		/// <summary>
		/// Клиент-плательщик - код (FacturesNumbers.PartnerTargetID)
		/// </summary>
		[Description("Клиент-плательщик - код (FacturesNumbers.PartnerTargetID)")]
		public int PartnerTargetID { get { return _PartnerTargetID; } set { _PartnerTargetID = value; } }

		protected string _PartnerTargetName;
		/// <summary>
		/// Клиент-плательщик- наименование (FacturesNumbers.PartnerTargetID -> Partners.Name)
		/// </summary>
		[Description("Клиент-плательщик - наименование (FacturesNumbers.PartnerTargetID -> Partners.Name)")]
		public string PartnerTargetName { get { return _PartnerTargetName; } set { _PartnerTargetName = value; } }

		protected int? _OutputDocumentID;
		/// <summary>
		/// Расходный документ - код (FacturesNumbers.OutputDocumentID)
		/// </summary>
		[Description("Расходный документ - код (FacturesNumbers.OutputDocumentID)")]
		public int? OutputDocumentID { get { return _OutputDocumentID; } set { _OutputDocumentID = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код записи о счета-фактуры в host-системе (FacturesNumbers.ERPCode)
		/// </summary>
		[Description("Код записи о счета-фактуры в host-системе (FacturesNumbers.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата выдачи счета-фактуры - начальная дата периода (FacturesNumbers.DateIssue)
		/// </summary>
		[Description("Фильтр-поле: дата выдачи счета-фактуры - начальная дата периода (FacturesNumbers.DateIssue)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата выдачи счета-фактуры - конечная дата периода (FacturesNumbers.DateIssue)
		/// </summary>
		[Description("Фильтр-поле: дата выдачи счета-фактуры - конечная дата периода (FacturesNumbers.DateIssue)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

		protected string _FilterNumberContext;
		/// <summary>
		/// Фильтр-поле: контекст номера счета-фактуры (FacturesNumbers.Number)
		/// </summary>
		[Description("Фильтр-поле: контекст номера счета-фактуры (FacturesNumbers.Number)")]
		public string FilterNumberContext { get { return _FilterNumberContext; } set { _FilterNumberContext = value; _NeedRequery = true; } }

		protected string _FilterPartnersSourceList;
		/// <summary>
		/// Фильтр-поле: список кодов партнеров, выписавших счета-фактуры, через запятую (FacturesNumbers.PartnerSourceID)
		/// </summary>
		[Description("Фильтр-поле: список кодов партнеров, выписавших счета-фактуры, через запятую (FacturesNumbers.PartnerSourceID)")]
		public string FilterPartnersSourceList { get { return _FilterPartnersSourceList; } set { _FilterPartnersSourceList = value; _NeedRequery = true; } }

		protected string _FilterPartnersTargetList;
		/// <summary>
		/// Фильтр-поле: список кодов клиентов-плательщиков, через запятую (FacturesNumbers.PartnerTargetID)
		/// </summary>
		[Description("Фильтр-поле: список кодов клиентов-плательщиков, через запятую (FacturesNumbers.PartnerTargetID)")]
		public string FilterPartnersTargetList { get { return _FilterPartnersTargetList; } set { _FilterPartnersTargetList = value; _NeedRequery = true; } }

		protected string _FilterOutputsDocumentsList;
		/// <summary>
		/// Фильтр-поле: список кодов расходных документов, через запятую (FacturesNumbers.OutputDocumentID)
		/// </summary>
		[Description("Фильтр-поле: список кодов расходных документов, через запятую (FacturesNumbers.OutputDocumentID)")]
		public string FilterOutputsDocumentsList { get { return _FilterOutputsDocumentsList; } set { _FilterOutputsDocumentsList = value; _NeedRequery = true; } }

		#endregion Фильтры

		// ----------------------------

		public FactureNumber()
			: base()
		{
			_MainTableName = "FacturesNumbers";
			_ColumnID = "ID";
			_ColumnName = "Number";
		}


		#region FillData

		/// <summary>
		/// получение полного списка выданных счетов-фактур в MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_FacturesNumbersFill @nID, @cIDList, " +
									"@dDateBeg, @dDateEnd, " +
									"@cNumberContext, " +
									"@cPartnersSourceList, @cPartnersTargetList, " +
									"@cOutputsDocumentsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_FacturesNumbersFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cPartnersSourceList", SqlDbType.VarChar);
			if (_FilterPartnersSourceList != null)
				_oParameter.Value = _FilterPartnersSourceList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPartnersTargetList", SqlDbType.VarChar);
			if (_FilterPartnersTargetList != null)
				_oParameter.Value = _FilterPartnersTargetList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOutputsDocumentsList", SqlDbType.VarChar);
			if (_FilterOutputsDocumentsList != null)
				_oParameter.Value = _FilterOutputsDocumentsList;
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
				_ErrorStr = "Ошибка при получении списка счетов-фактур..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка фильтр-полей
		/// </summary>
		public void ClearFilters()
		{
			_IDList = null;
			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterNumberContext = null;
			_FilterPartnersSourceList = null;
			_FilterPartnersTargetList = null;
			_FilterOutputsDocumentsList = null;
			//_NeedRequery = true;
		}

		#endregion FillData

		#region FillOne

		// собственно заполнение свойств экземпляра объекта данными строки 
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

					_PartnerSourceID = Convert.ToInt32(r["PartnerSourceID"]);
					_PartnerSourceName = r["PartnerSourceName"].ToString();
					_PartnerTargetID = Convert.ToInt32(r["PartnerTargetID"]);
					_PartnerTargetName = r["PartnerTargetName"].ToString();

					if (!Convert.IsDBNull(r["OutputDocumentID"]))
						_OutputDocumentID = Convert.ToInt32(r["OutputDocumentID"]);

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о счете-фактуре...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о счете-фактуре (нет данных)...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка свойств экземпляра
		/// </summary>
		public void ClearOne()
		{
			_ID = null;

			_Number = "";
			_NumberInt = 0;
			_DateIssue = null;

			_PartnerSourceID = 0;
			_PartnerSourceName = null;
			_PartnerTargetID = 0;
			_PartnerTargetName = null;

			_OutputDocumentID = null;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Delete

		/// <summary>
		/// удаление счета-фактуры
		/// </summary>
		public bool Delete(int nFactureID)
		{
			String _sqlCommand = "execute up_FacturesNumbersDelete @nFactureID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_FactureNumbersDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nFactureID", SqlDbType.Int);
			_oParameter.Value = nFactureID;

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
				_ErrorStr = "Ошибка при попытке удаления данных о счете-фактуре...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении данных о счете-фактуре...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Delete
	}

#endregion FactureNumber

}
