using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Состояние товара (GoodState)
/// </summary>

namespace LogBizObjects
{
	public class GoodState : BizObject
	{
		protected int? _GoodStateID;
		/// <summary>
		/// Код ID записи Состояние товара (GoodsStates.ID)
		/// </summary>
		[Description("ID записи Состояние товара (GoodsStates.ID)")]
		public int? GoodStateID { get { return ID; } set { ID = value; } }

		protected string _IDList;
		/// <summary>
		/// Список кодов ID состояний товара (GoodsStates.ID)
		/// </summary>
		[Description("Список ID состояний товара (GoodsStates.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected string _Name;
		/// <summary>
		/// Наименование (GoodsStates.Name)
		/// </summary>
		[Description("Наименование (GoodsStates.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания (GoodsStates.Note)
		/// </summary>
		[Description("Примечания (GoodsStates.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected int? _OwnerID;
		/// <summary>
		/// Владелец товара - код (GoodsStates.OwnerID -> Partners.ID)
		/// </summary>
		[Description("Владелец товара - код (GoodsStates.OwnerID -> Partners.ID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// Владелец товара - наименование (Outputs.PartnerID -> Partners.ID -> Partners.Name)
		/// </summary>
		[Description("Владелец товара - наименование (Outputs.PartnerID -> Partners.ID -> Partners.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }

		protected bool _Basic;
		/// <summary>
		/// Основной (GoodsStates.Basic)?
		/// </summary>
		[Description("Основной (GoodsStates.Basic)?")]
		public bool Basic { get { return _Basic; } set { _Basic = value; } }

		protected bool _Actual;
		/// <summary>
		/// Актуально (GoodsStates.Actual)?
		/// </summary>
		[Description("Актуально (GoodsStates.Actual)?")]
		public bool Actual { get { return _Actual; } set { _Actual = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код в host-системе (GoodsStates.ERPCode)
		/// </summary>
		[Description("Код в host-системе (GoodsStates.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected bool? _FilterActual;
		/// <summary>
		/// Фильтр-поле: актуальные состояния товара (GoodsStates.Actual)?
		/// </summary>
		[Description("Фильтр-поле: актуальные состояния товара (GoodsStates.Actual)?")]
		public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; } }

		protected bool? _FilterBasic;
		/// <summary>
		/// Фильтр-поле: базовые состояния товара (GoodsStates.Basic)?
		/// </summary>
		[Description("Фильтр-поле: базовые состояния товара (GoodsStates.Basic)?")]
		public bool? FilterBasic { get { return _FilterBasic; } set { _FilterBasic = value; } }

		#endregion Фильтры

		// -------------------

		public GoodState()
			: base()
		{
			_MainTableName = "GoodState";
			_ColumnID = "ID";
			_ColumnName = "Name";
		}

		#region FillData

		//получение таблицы складских зон 
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
				_ErrorStr = "Ошибка при получении списка состояний товара..." + Convert.ToChar(13) + ex.Message;
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
			_FilterBasic = null;
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
					_ErrorStr = "Ошибка при получении данных о состоянии товара...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о состоянии товара (нет данных)...";
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
