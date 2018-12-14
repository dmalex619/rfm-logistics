using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace LogBizObjects
{
	/// <summary>
	/// Базовый класс бизнес-объекта.
	/// </summary>
	public abstract class BizObject
	{
		// Внутренние объекты
		protected SqlConnection _Connect;

		protected DataSet _DS = new DataSet();
		/// <summary>
		/// Возвращаемый объект с данными.
		/// </summary>
		[Category("Logistics")]
		[Description("Возвращает набор данных, сформированный бизнес-объектом")]
		public DataSet DS
		{
			get { return _DS; }
		}

		protected int? _ID = null;
		/// <summary>
		/// ID объекта 
		/// </summary>
		[Category("Logistics")]
		[Description("ID объекта")]
		public int? ID
		{
			get { return _ID; }
			set { _ID = value; }
		}
		/// <summary>
		/// Признак единичного объекта.
		/// </summary>
		[Category("Logistics")]
		[Description("Возвращает <true> для единичного объекта и <false> для списка")]
		public bool IsSingleObject
		{
			get { return (_ID.HasValue); }
		}

		protected string _MainTableName = "MainTable";
		/// <summary>
		/// Имя главной таблицы бизнес-объекта.
		/// </summary>
		[Category("Logistics")]
		[Description("Имя главной таблицы бизнес-объекта")]
		public string MainTableName
		{
			get { return _MainTableName; }
			set { _MainTableName = value; }
		}

		protected DataTable _MainTable;
		/// <summary>
		/// Таблица MainTable в ds - источник данных бизнес-объекта.
		/// </summary>
		[Category("Logistics")]
		[Description("Таблица MainTable в ds - источник данных бизнес-объекта")]
		public DataTable MainTable
		{
			get { return _MainTable; }
			set { _MainTable = value; }
		}

		protected bool _NeedRequery;
		/// <summary>
		/// Требуется обновление главной таблицы бизнес-объекта?
		/// </summary>
		[Category("Logistics")]
		[Description("Требуется обновление главной таблицы бизнес-объекта?")]
		public bool NeedRequery
		{
			get { return _NeedRequery; }
			set { _NeedRequery = value; }
		}

		protected string _ColumnID = "ID";
		/// <summary>
		/// Название ID-поля
		/// </summary>
		[Category("Logistics")]
		[Description("Название ID-поля")]
		public string ColumnID
		{
			get { return _ColumnID; }
			set { _ColumnID = value; }
		}

		protected string _ColumnName = "Name";
		/// <summary>
		/// Название поля наименования
		/// </summary>
		[Category("Logistics")]
		[Description("Название поля наименования")]
		public string ColumnName
		{ 
			get { return _ColumnName; }
			set { _ColumnName = value; }
		}

		protected string _SelectOrderBy = "";
		/// <summary>
		/// Условие сортировки для select в FillData
		/// </summary>
		[Category("Logistics")]
		[Description("Дополнительные условия для select в FillData")]
		public string SelectOrderBy
		{
			get { return _SelectOrderBy; }
			set { _SelectOrderBy = value; }
		}

		protected int _ErrorNumber = 0;
		/// <summary>
		/// код ошибки 
		/// </summary>
		[Category("Logistics")]
		[Description("Код ошибки")]
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
			set { _ErrorNumber = value; }
		}

		protected string _ErrorStr = "";
		/// <summary>
		/// текст ошибки 
		/// </summary>
		[Category("Logistics")]
		[Description("Текст ошибки")]
		public string ErrorStr
		{
			get { return _ErrorStr; }
			set { _ErrorStr = value; }
		}

		// --------------------------------------------------------------------------------

		/// <summary>
		/// Базовый конструктор бизнес-объекта.
		/// Устанавливает строку соединения и создает объект соединения с БД.
		/// </summary>
		public BizObject()
		{
			SqlLink sqlLink = new SqlLink();
			if (sqlLink.ConnStr == null)
			{
				_ErrorNumber = 1;
				MessageBox.Show(sqlLink.ErrorStr, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			_Connect = new SqlConnection(sqlLink.ConnStr);

			// таблица _MainTable (_ds.Tables[MainTable]) - для записей
			_DS.Tables.Add(_MainTableName);
			_MainTable = _DS.Tables[_MainTableName];

			_ID = null;
		}

		public BizObject(int SingleObjectID) : this()
		{
			_ID = SingleObjectID;
		}

		/// <summary>
		/// Получение основного источника данных для бизнес-объекта _ds._MainTable
		/// с использованием select из соответствующей таблицы БД_ServerTable.
		/// </summary>
		public abstract bool FillData();

		/// <summary>
		/// Заполнение свойств экземпляра бизнес-объекта по данным _MainTable
		/// </summary>
		public abstract bool FillOneRow(DataRow r);

		/// <summary>
		/// Очистка основного источника данных для бизнес-объекта из таблицы БД.
		/// Очистка таблицы с именем MainTable в источнике ds
		/// </summary>
		public bool ClearData()
		{
			if ((_MainTable != null) && (_MainTable.Rows.Count > 0))
				_MainTable.Clear();
			return true;
		}

		/// <summary>
		/// Очистка всех таблиц в источнике ds
		/// </summary>
		public bool ClearData(bool Full)
		{
			foreach (DataTable _Table in _DS.Tables)
				_Table.Clear();
			return true;
		}

		/// <summary>
		/// очистка ошибки
		/// </summary>
		public void ClearError()
		{
			_ErrorNumber = 0;
			_ErrorStr = "";
		}

		#region FillOne 

		/// <summary>
		/// заполнение свойств экземпляра данными строки в MainTable
		/// с поиском по ID
		/// </summary>
		public bool FillOne(int nID)
		{
			ClearError();

			DataRow r = null;
			if (_MainTable.PrimaryKey == null)
			{
				foreach (DataRow dr in _MainTable.Rows)
				{ 
					if (!Convert.IsDBNull(dr[_ColumnID]) && Convert.ToInt32(dr[_ColumnID]) == nID)
					{
						r = dr;
					}
				}

			}
			else
			{
				r = _MainTable.Rows.Find(nID);
			}
			if (r == null)
			{
				return (false);
			}

			return (FillOneRow(r));
		}

		/// <summary>
		/// заполнение свойств экземпляра данными конкретной строки
		/// </summary>
		public bool FillOne(DataRow r)
		{
			ClearError();

			return (FillOneRow(r));
		}

		/// <summary>
		/// заполнение свойств экземпляра данными первой строки _MainTable
		/// </summary>
		public bool FillOne()
		{
			ClearError();

			if (_MainTable == null || _MainTable.Rows.Count == 0)
			{
				return (false);
			}

			return (FillOneRow(_MainTable.Rows[0]));
		}


		/// <summary>
		/// получение данных для заднного ID и 
		/// заполнение свойств экземпляра данными строки в MainTable
		/// </summary>
		public bool ReFillOne(int nID)
		{
			ClearError();

			_ID = nID;
			FillData();
			if (_MainTable.Rows.Count != 1)
			{
				return (false);
			}

			return (FillOne());
		}

		#endregion FillOne

		#region FillReadings

		public DataTable FillReadings(SqlDataAdapter da, DataTable dt, string dtName)
		{
			if (DS.Tables.Contains(dtName))
			{
				DS.Tables.Remove(dtName);
				dt = null;
			}
			dt = new DataTable(dtName);
			da.Fill(dt);
			DS.Tables.Add(dt);
			return (dt);
		}


		public void FillReadings(SqlDataAdapter da)
		{
			DS.Tables.Clear();
			da.Fill(DS);
		}


		#endregion FillReadings

	}
}