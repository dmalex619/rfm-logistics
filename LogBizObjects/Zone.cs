using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

/// <summary>
/// Бизнес-объект Зона (Zone)
/// </summary>

namespace LogBizObjects
{

#region Zone

	public class Zone : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// Список кодов ID зон (Zones.ID)
		/// </summary>
		[Description("Список кодов ID зон (Zones.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected int? _ParentID;
		/// <summary>
		/// Код ID родительской зоны (Zones.ParentID)
		/// </summary>
		[Description("Код ID родительской зоны (Zones.ParentID)")]
		public int? ParentID { get { return _ParentID; } set { _ParentID = value; } }

		protected string _Name;
		/// <summary>
		/// Наименование зоны (Zones.Name)
		/// </summary>
		[Description("Наименование зоны (Zones.Name)")]
		public string Name { get { return _Name; } set { _Name = value; } }

		protected string _FullNamePath;
		/// <summary>
		/// Полное наименование зоны, по иерархии (Zones.Name...)
		/// </summary>
		[Description("Полное наименование зоны, по иерархии (Zones.Name...)")]
		public string FullNamePath { get { return _FullNamePath; } set { _FullNamePath = value; } }

		protected string _Alias;
		/// <summary>
		/// Краткое наименование зоны (Zones.Alias)
		/// </summary>
		[Description("Краткое наименование зоны (Zones.Alias)")]
		public string Alias { get { return _Alias; } set { _Alias = value; } }

		protected int _PermitLevelID;
		/// <summary>
		/// Разрешение проезда - код (Zones.PermitLevelID)
		/// </summary>
		[Description("Разрешение проезда - код (Zones.PermitLevelID)")]
		public int PermitLevelID { get { return _PermitLevelID; } set { _PermitLevelID = value; } }

		protected string _PermitLevelName;
		/// <summary>
		/// Разрешение проезда - наименование (Zones.PermitLevelID -> PermitsLevels.Name)
		/// </summary>
		[Description("Разрешение проезда - наименование (Zones.PermitLevelID -> PermitsLevels.Name)?")]
		public string PermitLevelName { get { return _PermitLevelName; } set { _PermitLevelName = value; } }

		protected int _PermitLevelValue;
		/// <summary>
		/// Разрешение проезда - уровень, не менее (Zones.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Разрешение проезда - уровень, не менее (Zones.PermitLevelID -> PermitsLevels.PermitLevelValue)?")]
		public int PermitLevelValue { get { return _PermitLevelValue; } set { _PermitLevelValue = value; } }

		protected int? _MaxWeight;
		/// <summary>
		/// Максимальный вес, кг (Zones.WaxWeight)
		/// </summary>
		[Description("Максимальный вес, кг (Zones.WaxWeight)")]
		public int? MaxWeight { get { return _MaxWeight; } set { _MaxWeight = value; } }

		protected int? _CoordinatesX;
		/// <summary>
		/// Географическая координата X (Zones.CoordinatesX)
		/// </summary>
		[Description("Географическая координата X (Zones.CoordinatesX)")]
		public int? CoordinatesX { get { return _CoordinatesX; } set { _CoordinatesX = value; } }

		protected int? _CoordinatesY;
		/// <summary>
		/// Географическая координата Y (Zones.CoordinatesY)
		/// </summary>
		[Description("Географическая координата Y (Zones.CoordinatesY)")]
		public int? CoordinatesY { get { return _CoordinatesY; } set { _CoordinatesY = value; } }

		protected string _Note;
		/// <summary>
		/// Примечания (Zones.Note)
		/// </summary>
		[Description("Примечания (Zones.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected bool _Special;
		/// <summary>
		/// Специальный маршрут (Zones.Special)?
		/// </summary>
		[Description("Специальный маршрут (Zones.Special)?")]
		public bool Special { get { return _Special; } set { _Special = value; } }

		protected string _ERPCode;
		/// <summary>
		/// Код зоны в host-системе (Zones.ERPCode)
		/// </summary>
		[Description("Код зоны в host-системе (Zones.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterNameContext;
		/// <summary>
		/// Фильтр-поле: название зоны, контекст (Zones.Name)
		/// </summary>
		[Description("Фильтр-поле: название зоны, контекст (Zones.Name)")]
		public string FilterNameContext { get { return _FilterNameContext; } set { _FilterNameContext = value; _NeedRequery = true; } }

		protected int? _FilterPermitLevelValueMin;
		/// <summary>
		/// Фильтр-поле: разрешение проезда - уровень, не менее (Zones.PermitLevelID -> PermitsLevels.PermitLevelValue)
		/// </summary>
		[Description("Фильтр-поле: разрешение проезда - уровень, не менее (Zones.PermitLevelID -> PermitsLevels.PermitLevelValue)")]
		public int? FilterPermitLevelValueMin { get { return _FilterPermitLevelValueMin; } set { _FilterPermitLevelValueMin = value; _NeedRequery = true; } }

		#endregion Фильтры

		// -------------------
		
		public Zone() : base()
		{
			_MainTableName = "Zones";
			_ColumnID = "ID";
			_ColumnName = "Name"; 
		}

		#region FillData

		/// <summary>
		/// получение полного списка зон в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			return (FillDataFull(false)); 
		}

		/// <summary>
		/// получение полного списка зон (с полными именами по иерархии) в MainTable
		/// </summary>
		public bool FillDataFull(bool? bFullNameInclude)
		{
			ClearData();

			string sqlSelect = "execute up_ZonesFill @nID, @cIDList, " +
									"@cNameContext, " +
									"@nPermitLevelValueMin, " + 
									"@bFullNameInclude";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_ZonesFill Parameters

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

			_oParameter = _oCommand.Parameters.Add("@nPermitLevelValueMin", SqlDbType.Int);
			if (_FilterPermitLevelValueMin != null)
				_oParameter.Value = _FilterPermitLevelValueMin;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bFullNameInclude", SqlDbType.Bit);
			if (bFullNameInclude != null)
				_oParameter.Value = bFullNameInclude;
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
				_ErrorStr = "Ошибка при получении общего списка зон..." + Convert.ToChar(13) + ex.Message;
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
			_FilterPermitLevelValueMin = null;
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

					if (!Convert.IsDBNull(r["ParentID"]))
						_ParentID = Convert.ToInt32(r["ParentID"]);

					_Name = r["Name"].ToString();
					_Alias = r["Alias"].ToString();
					_FullNamePath = r["FullNamePath"].ToString();

					_PermitLevelID = Convert.ToInt32(r["PermitLevelID"]);
					_PermitLevelName = r["PermitLevelName"].ToString();
					_PermitLevelValue = Convert.ToInt32(r["PermitLevelValue"]);

					if (!Convert.IsDBNull(r["CoordinatesX"]))
						_CoordinatesX = Convert.ToInt32(r["CoordinatesX"]);
					if (!Convert.IsDBNull(r["CoordinatesY"]))
						_CoordinatesY = Convert.ToInt32(r["CoordinatesY"]);

					if (!Convert.IsDBNull(r["MaxWeight"]))
						_MaxWeight = Convert.ToInt32(r["MaxWeight"]);
					_Note = r["Note"].ToString();

					_Special = Convert.ToBoolean(r["Special"]);

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных о зоне...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных о зоне (нет данных)...";
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
			_FullNamePath = null;

			_PermitLevelID = 0;
			_PermitLevelName = null;
			_PermitLevelValue = 0;

			_CoordinatesX = null;
			_CoordinatesY = null;

			_MaxWeight = 0;
			_Note = null;

			_Special = false;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Дерево

		/// <summary>
		/// получение данных о зонах для дерева (TableDataTree)
		/// </summary>
		public bool FillDataTree(bool bActual)
		{
			if (_DS.Tables["TableDataTree"] != null)
				_DS.Tables.Remove("TableDataTree");

			string sqlSelect = "select * from .dbo.ZonesTree(" + ((bActual)? "1" : "0") + ") " + 
				"order by ParentID, Name";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "TableDataTree");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -21;
				_ErrorStr = "Ошибка при получении иерархического списка (дерева) зон..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion Дерево

		#region Logistics

		/// <summary>
		/// получение списка рейсов по зонам на дату
		/// </summary>
		public bool CalcZonesLogisticInfoByDate(DateTime dDateLogistic)
		{
			string sqlSelect = "exec up_ZonesLogisticInfoByDate @dDateLogistic";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);
			
			SqlParameter _oParameter = _oCommand.Parameters.Add("@dDateLogistic", SqlDbType.DateTime);
			_oParameter.Value = dDateLogistic;

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "ZonesLogisticInfo");
				_NeedRequery = false;
			}
			catch (Exception ex)
			{
				_ErrorNumber = -1;
				_ErrorStr = "Ошибка при получении общего списка логистики по зонам..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// получение списка рейсов в зоне на дату
		/// </summary>
		public bool ZonesTripsInfoByDate(DateTime dDateLogistic, int ZoneID)
		{
			string sqlSelect = "select C.Name, T.TripNumber, T.Tonnage, O.Brutto, O.Amount, " +
					"T.Alias as CarName , 'O' as TripType  " +
				"from OutputsDocuments O " +
                "inner join PartnersDetails CD on O.PartnerDetailBayerID = CD.ID " +
                "inner join Partners C on CD.PartnerID = C.ID " +
                "inner join Trips T on T.ID = O.TripID " +
				"left  join Cars Cr on T.CarID = Cr.ID " +
				"where datediff(day, O.DateOutput, '" + dDateLogistic.Date.ToString("yyyyMMdd") + "') = 0 and " +
					" C.ZoneID = " + ZoneID.ToString().Trim() +
				"union all " +
				"select C.Name, T.TripNumber, T.Tonnage, S.Brutto, S.Amount, " +
				"T.Alias as CarName, 'S' as TripType  " +
				" from InputsDocuments S " +
				" inner join Partners C on C.ID = S.PartnerSourceID " +
				" inner join Trips T on T.ID = S.TripID " +
				" left  join Cars Cr on T.CarID = Cr.ID " +
				"where datediff(day, DateInput, '" + dDateLogistic.Date.ToString("yyyyMMdd") + "') = 0 and " +
					" C.ZoneID = " + ZoneID.ToString().Trim();

			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			try
			{
				FillReadings(new SqlDataAdapter(_oCommand), null, "ZonesTripsInfo");
			}
			catch (Exception ex)
			{
				_ErrorNumber = -31;
				_ErrorStr = "Ошибка получения списка рейсов...\r\n" + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			finally
			{
				_Connect.Close();
			}
			return (_ErrorNumber == 0);
		}

		#endregion Logistics

	}

#endregion Zone

}
