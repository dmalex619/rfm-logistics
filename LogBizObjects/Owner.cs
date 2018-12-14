using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Партнер-хранитель (владелец) товара (Owner)
/// </summary>

namespace LogBizObjects
{
	public class Owner : BizObject
	{
		protected int? _OwnerID;
		/// <summary>
		/// Код ID записи Партнер (Partners.ID)
		/// </summary>
		[Description("ID записи Партнер (Partners.ID)")]
		public int? OwnerID { get { return ID; } set { ID = value; } }

		protected string _IDList;
		/// <summary>
		/// Список кодов ID хранителей (Partners.ID)
		/// </summary>
		[Description("Список ID хранителей (Partners.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		/// <summary>
		/// Наименование (Partners.Name)
		/// </summary>
		[Description("Наименование (Partners.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected bool _SeparatePicking;
		/// <summary>
		/// Раздельное хранение товара (Partners.SeparatePicking)?
		/// </summary>
		[Description("Раздельное хранение товара (Partners.SeparatePicking)?")]
		public bool SeparatePicking { get { return _SeparatePicking; } set { _SeparatePicking = value; } }

		protected bool _Actual;
		/// <summary>
		/// Актуально (Partners.Actual)?
		/// </summary>
		[Description("Актуально (Partners.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код в host-системе (Partners.ERPCode)
		/// </summary>
		[Description("Код в host-системе (Partners.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected bool? _FilterActual;
		/// <summary>
		/// Фильтр-поле: актуальные состояния товара (Partners.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуальные состояния товара (Partners.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; } }

		protected bool? _FilterSeparatePicking;
		/// <summary>
		/// Фильтр-поле: раздельное хранение товара (Partners.SeparatePicking)?
		/// </summary>
		[Description("Фильтр-поле: раздельное хранение товара (Partners.SeparatePicking)?")]
		public bool? FilterSeparatePicking { get { return _FilterSeparatePicking; } set { _FilterSeparatePicking = value; } }

		#endregion Фильтры

		// -------------------

		public Owner()
			: base()
		{
			_MainTableName = "Owners";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}

		#region FillData

		//получение таблицы складских зон 
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
				_ErrorStr = "Ошибка при получении списка хранителей товара..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// очистка фильтр-полей
		/// </summary>
		public void ClearFilters()
		{
			_FilterActual = null;
			_FilterSeparatePicking = null;
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
					_Name = r["Name"].ToString();
					_SeparatePicking = Convert.ToBoolean(r["SeparatePicking"]);
					_Actual = Convert.ToBoolean(r["Actual"]);
					_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о хранителях товара...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о хранителе товара (нет данных)...";
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

			_Name = null;
			_SeparatePicking  = false;
			_Actual = false;

			_ERPCode = null;
		}

		#endregion FillOne

	}
}
