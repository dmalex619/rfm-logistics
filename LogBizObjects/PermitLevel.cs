using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Уровень разрешеняи на въезд (в терииториальную зону) (PermitLevel)
/// </summary>

namespace LogBizObjects
{
	public class PermitLevel : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID зон (PermitsLevels.ID)
		/// </summary>
		[Description("Список кодов ID зон (PermitsLevels.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		/// <summary>
		/// Наименование зоны (PermitsLevels.Name)
		/// </summary>
		[Description("Наименование зоны (PermitsLevels.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected int _PermitLevelValue;
		/// <summary>
		/// Уровень, не ниже (PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Уровень, не ниже (PermitsLevels.PermitLevelValue)?")]
		public int PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания (PermitsLevels.Note)
		/// </summary>
		[Description("Примечания (PermitsLevels.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected bool _Actual;
		/// <summary>
		/// Актуально (PermitsLevels.Actual)?
		/// </summary>
		[Description("Актуально (PermitsLevels.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код зоны в host-системе (PermitsLevels.ERPCode)
		/// </summary>
		[Description("Код зоны в host-системе (PermitsLevels.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterNameContext;
		/// <summary>
		/// Фильтр-поле: название зоны, контекст (PermitsLevels.Name)
		/// </summary>
		[Description("Фильтр-поле: название зоны, контекст (PermitsLevels.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		protected bool? _FilterActual;
		/// <summary>
		/// Фильтр-поле: актуальные разрешения (PermitsLevels.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуальные клиенты (PermitsLevels.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

		protected int? _FilterValueMin;
		/// <summary>
		/// Фильтр-поле: уровень, не ниже (PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Фильтр-поле: уровень, не ниже (PermitsLevels.PermitLevelValue)")]
		public int? FilterValueMin { get { return _FilterValueMin; } set { _FilterValueMin = value; _NeedRequery = true; } }

		#endregion Фильтры

		// -------------------
		
		public PermitLevel() : base()
		{
			_MainTableName = "PermitsLevels";
			_ColumnID = "ID";
			_ColumnName = "Name"; 
		}

		#region FillData

		/// <summary>
		/// получение полного списка зон (с полными именами по иерархии) в MainTable
		/// </summary>
		public override bool FillData()
		{
			ClearData();

			string sqlSelect = "execute up_PermitsLevelsFill @nID, @nIDList, " +
									"@bActual, " +
									"@cNameContext, " +
									"@nValueMin";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_PermitsLevelsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nID", SqlDbType.Int);
			if (_ID != null)
				_oParameter.Value = ID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nIDList", SqlDbType.Int);
			if (_IDList != null)
				_oParameter.Value = IDList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
			if (_FilterActual != null)
				_oParameter.Value = _FilterActual;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNameContext", SqlDbType.VarChar);
			if (_FilterNameContext != null)
				_oParameter.Value = _FilterNameContext;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nValueMin", SqlDbType.Int);
			if (_FilterValueMin != null)
				_oParameter.Value = _FilterValueMin;
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
				_ErrorStr = "Ошибка при получении общего списка разрешений на проезд..." + Convert.ToChar(13) + ex.Message;
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

			_FilterActual = null;
			_FilterNameContext = null;
			_FilterValueMin = null;
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
					_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);

					_Note = r["Note"].ToString();
					_Actual = Convert.ToBoolean(r["Actual"]);

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о разрешении на проезд...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о разрешении на проезд (нет данных)...";
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
			_PermitLevelValue = 0;

			_Actual = false;
			_Note = null;

			_ERPCode = null;
		}

		#endregion FillOne

	}
}
