using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Валюта (Currency)
/// </summary>

namespace LogBizObjects
{

#region Currency 

	public class Currency : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID валют (Currencies.ID)
		/// </summary>
		[Description("Список кодов ID валют (Currencies.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		/// <summary>
		/// Наименование валюты (Currencies.Name)
		/// </summary>
		[Description("Наименование валюты (Currencies.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _Alias;
		/// <summary>
		/// Краткое наименование валюты (Currencies.Alias)
		/// </summary>
		[Description("Краткое наименование валюты (Currencies.Alias)")]
		public string Alias { get { return _Alias; } set { _Alias = value; } }

		protected string _Code;
		/// <summary>
		/// Код валюты (Currencies.Code)
		/// </summary>
		[Description("Код валюты (Currencies.Code)")]
		public string Code { get { return _Code; } set { _Code = value; } }

		protected string _ISOSymbolCode;
		/// <summary>
		/// Символьный код валюты (Currencies.ISOSymbolCode)
		/// </summary>
		[Description("Символьный код валюты (Currencies.ISOSymbolCode)")]
		public string ISOSymbolCode { get { return _ISOSymbolCode; } set { _ISOSymbolCode = value; } }

		protected string _ISODigitalCode;
		/// <summary>
		/// Цифровой код валюты (Currencies.ISODigitalCode)
		/// </summary>
		[Description("Цифровой код валюты (Currencies.ISODigitalCode)")]
		public string ISODigitalCode { get { return _ISODigitalCode; } set { _ISODigitalCode = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код валюты в host-системе (Currencies.ERPCode)
		/// </summary>
		[Description("Код валюты в host-системе (Currencies.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterNameContext;
		/// <summary>
		/// Фильтр-поле: название валюты, контекст (Currencies.Name)
		/// </summary>
		[Description("Фильтр-поле: название валюты, контекст (Currencies.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		#endregion Фильтры

		// -------------------
		
		public Currency() : base()
		{
			_MainTableName = "Currencies";
			_ColumnID = "ID";
			_ColumnName = "Name"; 
		}

		#region FillData

		/// <summary>
		/// получение полного списка валют в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_CurrenciesFill @nCurrencyID, @cIDList, " +
									"@cNameContext"; 
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_CurrenciesFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nCurrencyID", SqlDbType.Int);
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
				_ErrorStr = "Ошибка при получении общего списка валют..." + Convert.ToChar(13) + ex.Message;
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

			_FilterNameContext = null;
		}

		#endregion FillData

		#region FillOne

		// заполнение свойств экземпляра объекта данными строки 
		public override bool FillOneRow(DataRow r)
		{
			ClearOne();

			if (r != null)
			{
				try
				{
					_ID = Convert.ToInt32(r["ID"]);

					_Name = r["Name"].ToString();
					_Alias = r["Alias"].ToString();

					_Code = r["Code"].ToString();
					_ISOSymbolCode = r["ISOSymbolCode"].ToString();
					_ISODigitalCode = r["ISODigitalCode"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о валюте...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о валюте (нет данных)...";
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

			_IDList = null;

			_Name = null;
			_Alias = null;

			_Code = null;
			_ISOSymbolCode = null;
			_ISODigitalCode = null;

			_ERPCode = null;
		}

		#endregion FillOne

	}

#endregion Currency
}
