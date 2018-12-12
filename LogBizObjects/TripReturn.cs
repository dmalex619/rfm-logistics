using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMPublic; 

/// <summary>
/// Бизнес-объект Возврат с рейса (недовоз) (TripReturn)
/// </summary>
/// 
namespace LogBizObjects
{

#region TripReturn

	public class TripReturn : BizObject 
	{
		protected string _IDList;
		/// <summary>
		/// Список ID возвратов (TripsReturns.ID)
		/// </summary>
		[Description("Список ID возвратов (TripsReturns.ID)")]
		public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

		#region Поля, свойства

		protected DateTime _DateReturn;
		/// <summary>
		/// Дата возврата (TripsReturns.DateReturn)
		/// </summary>
		[Description("Дата возврата (TripsReturns.DateReturn)")]
		public DateTime DateReturn { get { return _DateReturn; } set { _DateReturn = value; } }


		protected bool _AutoCreated;
		/// <summary>
		/// Создан автоматически (при обработке рейса) (TripsReturns.AutoCreated)?
		/// </summary>
		[Description("Создан автоматически (при обработке рейса) (TripsReturns.AutoCreated)?")]
		public bool AutoCreated { get { return _AutoCreated; } set { _AutoCreated = value; } }

		protected DateTime? _DateCreate;
		/// <summary>
		/// Дата-время создания (TripsReturns.DateCreate)?
		/// </summary>
		[Description("Дата-время создания (TripsReturns.DateCreate)?")]
		public DateTime? DateCreate { get { return _DateCreate; } set { _DateCreate = value; } }

		protected int? _UserCreateID;
		/// <summary>
		/// Пользователь, оформивший возврат - код (TripsReturns.UserCreateID)
		/// </summary>
		[Description("Пользователь, оформивший возврат - код (TripsReturns.UserCreateID)")]
		public int? UserCreateID { get { return _UserCreateID; } set { _UserCreateID = value; } }

		protected string _UserCreateName;
		/// <summary>
		/// Пользователь, оформивший возврат - ФИО (TripsReturns.UserCreateID -> _Users.Name)
		/// </summary>
		[Description("Пользователь, оформивший возврат - ФИО (TripsReturns.UserCreateID -> _Users.Name)")]
		public string UserCreateName { get { return _UserCreateName; } set { _UserCreateName = value; } }



		protected int? _OwnerID;
		/// <summary>
		/// Владелец товара - код (TripsReturns.OwnerID)
		/// </summary>
		[Description("Владелец товара - код (TripsReturns.OwnerID)")]
		public int? OwnerID { get { return _OwnerID; } set { _OwnerID = value; } }

		protected string _OwnerName;
		/// <summary>
		/// Владелец товара - наименование (TripsReturns.OwnerID -> GoodsStates.Name)
		/// </summary>
		[Description("Владелец товара - наименование (TripsReturns.OwnerID -> GoodsStates.Name)")]
		public string OwnerName { get { return _OwnerName; } set { _OwnerName = value; } }


		protected int? _GoodStateID;
		/// <summary>
		/// Состояние товара - код (TripsReturns.GoodStateID)
		/// </summary>
		[Description("Состояние товара - код (TripsReturns.GoodStateID)")]
		public int? GoodStateID { get { return _GoodStateID; } set { _GoodStateID = value; } }

		protected string _GoodStateName;
		/// <summary>
		/// Состояние товара - наименование (TripsReturns.GoodStateID -> GoodsStates.Name)
		/// </summary>
		[Description("Состояние товара - наименование (TripsReturns.GoodStateID -> GoodsStates.Name)")]
		public string GoodStateName { get { return _GoodStateName; } set { _GoodStateName = value; } }


		protected int? _TripID;
		/// <summary>
		/// Рейс - код (TripsReturns.TripID)
		/// </summary>
		[Description("Рейс - код (TripsReturns.TripID)")]
		public int? TripID { get { return _TripID; } set { _TripID = value; } }

		protected string _TripAlias;
		/// <summary>
		/// Рейс - описание (TripsReturns.TripID -> Trips.Alias)
		/// </summary>
		[Description("Рейс - описание (TripsReturns.TripID -> Trips.Alias)")]
		public string TripAlias { get { return _TripAlias; } set { _TripAlias = value; } }

        protected string _Note;
		/// <summary>
		/// Примечания к возврату (TripsReturns.Note)
		/// </summary>
		[Description("Примечания к возврату (TripsReturns.Note)")]
		public string Note { get { return _Note; } set { _Note = value; } }

		protected bool _ReadyForWMS;
		/// <summary>
		/// Готово к передаче в складскую систему (TripsReturns.ReadyForWMS)?
		/// </summary>
		[Description("Готово к передаче в складскую систему (TripsReturns.ReadyForWMS)?")]
		public bool ReadyForWMS { get { return _ReadyForWMS; } set { _ReadyForWMS = value; } }

		protected bool _SentToWMS;
		/// <summary>
		/// Передано в складскую систему (TripsReturns.SentToWMS)?
		/// </summary>
		[Description("Передано в складскую систему (TripsReturns.SentToWMS)?")]
		public bool SentToWMS { get { return _SentToWMS; } set { _SentToWMS = value; } }


		protected DateTime? _DateConfirm;
		/// <summary>
		/// Дата-время подтверждения возврата (TripsReturns.DateConfirm)?
		/// </summary>
		[Description("Дата-время подтверждения возврата (TripsReturns.DateConfirm)?")]
		public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

		protected bool _IsConfirmed;
		/// <summary>
		/// возврат подтвержден (TripsReturns.DateConfirm is not Null)?
		/// </summary>
		[Description("возврат подтвержден (TripsReturns.DateConfirm is not Null)?")]
		public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }


		protected int? _HostID;
		/// <summary>
		/// Host - код (TripsReturns.HostID)
		/// </summary>
		[Description("Host - код (TripsReturns.HostID)")]
		public int? HostID { get { return _HostID; } set { _HostID = value; } }

		protected string _HostName;
		/// <summary>
		/// Host - наименование (TripsReturns.HostID -> Hosts.Name)
		/// </summary>
		[Description("Host - наименование (TripsReturns.HostID -> Hosts.Name)")]
		public string HostName { get { return _HostName; } set { _HostName = value; } }


		protected string _ERPCode;
		/// <summary>
		/// Код возврата в host-системе (TripsReturns.ERPCode)
		/// </summary>
		[Description("Код возврата в host-системе (TripsReturns.ERPCode)")]
		public string ERPCode { get { return _ERPCode; } set { _ERPCode = value; } }

		#endregion Поля, свойства

		#region Фильтры

		protected string _FilterHostsList;
		/// <summary>
		/// Фильтр-поле: список кодов host-ов, через запятую (TripsReturns.HostID)
		/// </summary>
		[Description("Фильтр-поле: список кодов товарных групп, через запятую (TripsReturns.HostID)")]
		public string FilterHostsList { get { return _FilterHostsList; } set { _FilterHostsList = value; _NeedRequery = true; } }
		

		protected DateTime? _FilterDateBeg;
		/// <summary>
		/// Фильтр-поле: дата возврата - начальная дата периода (TripsReturns.DateTripReturn)
		/// </summary>
		[Description("Фильтр-поле: дата возврата - начальная дата периода (TripsReturns.DateTripReturn)")]
		public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; } }

		protected DateTime? _FilterDateEnd;
		/// <summary>
		/// Фильтр-поле: дата возврата - конечная дата периода (TripsReturns.DateTripReturn)
		/// </summary>
		[Description("Фильтр-поле: дата возврата - конечная дата периода (TripsReturns.DateTripReturn)")]
		public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }


		protected bool? _FilterReadyForWMS;
		/// <summary>
		/// Фильтр-поле: возврат готов к передаче в складскую систему (TripsReturns.ReadyForWMS)?
		/// </summary>
		[Description("Фильтр-поле: возврат готов к передаче в складскую систему (TripsReturns.ReadyForPrint)?")]
		public bool? FilterReadyForWMS { get { return _FilterReadyForWMS; } set { _FilterReadyForWMS = value; _NeedRequery = true; } }


		protected bool? _FilterIsConfirmed;
		/// <summary>
		/// Фильтр-поле: возврат подтвержден (TripsReturns.DateConfirm is not Null)?
		/// </summary>
		[Description("Фильтр-поле: возврат подтвержден (TripsReturns.DateConfirm is not Null)?")]
		public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }


		protected bool? _FilterAutoCreated;
		/// <summary>
		/// Фильтр-поле: создано автоматически (TripsReturns.AutoCreated)?
		/// </summary>
		[Description("Фильтр-поле: создано автоматически  (TripsReturns.AutoCreated)?")]
		public bool? FilterAutoCreated { get { return _FilterAutoCreated; } set { _FilterAutoCreated = value; _NeedRequery = true; } }

		/*
		protected string _FilterGoodsStatesList;
		/// <summary>
		/// Фильтр-поле: список кодов состояний товара, через запятую (TripsReturns.GoodsStateID)
		/// </summary>
		[Description("Фильтр-поле: список кодов состояний товара, через запятую (TripsReturns.GoodsStateID)")]
		public string FilterGoodsStatesList { get { return _FilterGoodsStatesList; } set { _FilterGoodsStatesList = value; _NeedRequery = true; } }
		*/
		
		protected string _FilterTripsList;
		/// <summary>
		/// Фильтр-поле: список кодов рейсов, через запятую (TripsReturns.TripID)
		/// </summary>
		[Description("Фильтр-поле: список кодов рейсов, через запятую (TripsReturns.TripID)")]
		public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

		protected string _FilterOwnersList;
		/// <summary>
		/// Фильтр-поле: список кодов владельцев, через запятую (TripsReturns.OwnerID)
		/// </summary>
		[Description("Фильтр-поле: список кодов владельцев, через запятую (TripsReturns.OwnerID)")]
		public string FilterOwnersList { get { return _FilterOwnersList; } set { _FilterOwnersList = value; _NeedRequery = true; } }

		// для поиска по товарам 

		protected string _FilterPackingsList;
		/// <summary>
		/// Фильтр-поле: список кодов упаковок, через запятую (TripsReturns.ID --> TripsReturnsGoods.PackingID)
		/// </summary>
		[Description("Фильтр-поле: список кодов упаковок, через запятую (TripsReturns.ID --> TripsReturnsGoods.PackingID)")]
		public string FilterPackingsList { get { return _FilterPackingsList; } set { _FilterPackingsList = value; _NeedRequery = true; } }

		protected string _FilterGoodsList;
		/// <summary>
		/// Фильтр-поле: список кодов упаковок, через запятую (TripsReturns.ID --> TripsReturnsGoods.GoodID)
		/// </summary>
		[Description("Фильтр-поле: список кодов упаковок, через запятую (TripsReturns.ID --> TripsReturnsGoods.GoodID)")]
		public string FilterGoodsList { get { return _FilterGoodsList; } set { _FilterGoodsList = value; _NeedRequery = true; } }

		#endregion Фильтры

		#region Таблицы

		protected DataTable _TableTripsReturnsGoods;
		/// <summary>
		/// Список товаров в возврате TripsReturnsGoods
		/// </summary>
		[Description("Список товаров в возврате TripsReturnsGoods")]
		public DataTable TableTripsReturnsGoods { get { return _TableTripsReturnsGoods; } }

		#endregion Таблицы


		// -------------------------------------

		public TripReturn() : base()
		{
			_MainTableName = "TripsReturns";
			_ColumnID = "ID";
			_ColumnName = "DateReturn";
		}


		#region FillData

		/// <summary>
		/// получение полного списка возвратов с дополнительными сведениями в MainTable
		/// </summary>
		public override bool FillDataAsync()
		{
			ClearData();

			string sqlSelect = "execute up_TripsReturnsFill @nID, @cIDList, " +
									"@cHostsList, " +
									"@dDateBeg, @dDateEnd, " +
									"@bReadyForWMS, " +
									"@bIsConfirmed, " +
									"@bAutoCreated, " +
									"@cTripsList, " +
									"@cOwnersList, " +
									"@cPackingsList, @cGoodsList";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsReturnsFill parameters

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

			_oParameter = _oCommand.Parameters.Add("@cHostsList", SqlDbType.VarChar);
			if (_FilterHostsList != null)
				_oParameter.Value = _FilterHostsList;
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

			_oParameter = _oCommand.Parameters.Add("@bReadyForWMS", SqlDbType.Bit);
			if (_FilterReadyForWMS != null)
				_oParameter.Value = _FilterReadyForWMS;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
			if (_FilterIsConfirmed != null)
				_oParameter.Value = _FilterIsConfirmed;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@bAutoCreated", SqlDbType.Bit);
			if (_FilterAutoCreated != null)
				_oParameter.Value = _FilterAutoCreated;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
			if (_FilterTripsList != null)
				_oParameter.Value = _FilterTripsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cOwnersList", SqlDbType.VarChar);
			if (_FilterOwnersList != null)
				_oParameter.Value = _FilterOwnersList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cPackingsList", SqlDbType.VarChar);
			if (_FilterPackingsList != null)
				_oParameter.Value = _FilterPackingsList;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cGoodsList", SqlDbType.VarChar);
			if (_FilterGoodsList != null)
				_oParameter.Value = _FilterGoodsList;
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
				_ErrorStr = "Ошибка при получении списка возвратов..." + Convert.ToChar(13) + ex.Message;
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

			_FilterHostsList = null; 

			_FilterDateBeg = null;
			_FilterDateEnd = null;
			_FilterReadyForWMS = null;
			_FilterIsConfirmed = null;
			_FilterAutoCreated = null;
			/*
			_FilterOwnersList = null;
			_FilterGoodsStatesList = null;
			*/
			_FilterTripsList = null;
			_FilterOwnersList = null;
			_FilterPackingsList = null;
			_FilterGoodsList = null;
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
					_DateReturn = Convert.ToDateTime(r["DateReturn"]);
					_DateCreate = Convert.ToDateTime(r["DateCreate"]);
					_AutoCreated = Convert.ToBoolean(r["AutoCreated"]);

					if (!Convert.IsDBNull(r["OwnerID"]))
						_OwnerID = Convert.ToInt32(r["OwnerID"]);
					_OwnerName = r["OwnerName"].ToString();
					if (!Convert.IsDBNull(r["GoodStateID"]))
						_GoodStateID = Convert.ToInt32(r["GoodStateID"]);
					_GoodStateName = r["GoodStateName"].ToString();

					if (!Convert.IsDBNull(r["TripID"]))
						_TripID = Convert.ToInt32(r["TripID"]);
					_TripAlias = r["TripAlias"].ToString();

					_Note = r["Note"].ToString();

					if (!Convert.IsDBNull(r["DateConfirm"]))
						_DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
					_IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);

					_ReadyForWMS = Convert.ToBoolean(r["ReadyForWMS"]);
					_SentToWMS = Convert.ToBoolean(r["SentToWMS"]);

					if (!Convert.IsDBNull(r["UserCreateID"]))
						_UserCreateID = Convert.ToInt32(r["UserCreateID"]);
					_UserCreateName = r["UserCreateName"].ToString();
					if (!Convert.IsDBNull(r["DateCreate"]))
						_DateCreate = Convert.ToDateTime(r["DateCreate"]);

					if (!Convert.IsDBNull(r["HostID"]))
						_HostID = Convert.ToInt32(r["HostID"]);
					_HostName = r["HostName"].ToString();

					if (!Convert.IsDBNull(r["ERPCode"]))
						_ERPCode = r["ERPCode"].ToString();
				}
				catch (Exception ex)
				{
					_ErrorNumber = -100;
					_ErrorStr = "Ошибка при получении данных об возврате...\n" +
						ex.Message;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			else
			{
				_ErrorNumber = -101;
				_ErrorStr = "Ошибка при получении данных об возврате (нет данных)...";
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
			_DateReturn = DateTime.Now.Date;
			_DateCreate = DateTime.Now.Date;
			_AutoCreated = false; 

			_OwnerID = null;
			_OwnerName = null;
			_GoodStateID = null;
			_GoodStateName = null;

			_TripID = null;
			_TripAlias = null;

			_Note = "";

			_DateConfirm = null;
			_IsConfirmed = false;

			_ReadyForWMS = false;
			_SentToWMS = false;

			_DateCreate = null;
			_UserCreateID = null;
			_UserCreateName = null;

			_HostID = null;
			_HostName = null;

			_ERPCode = null;
		}

		#endregion FillOne

		#region Save, Delete

		/// <summary>
		/// сохранение данных возврата
		/// </summary>
		public bool Save()
		{
			return (Save(null));
		}

		public bool Save(int? nUserCreateID)
		{
			string _sqlCommand = "execute up_TripsReturnsSave @nTripReturnID output, " +
									"@dDateReturn, " +
									"@bAutoCreated, " + 
									"@nOwnerID, @nGoodStateID, " +
									"@cNote, " +
									"@nTripID, " +
									"@nUserCreateID, " + 
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsSave parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			if (_ID.HasValue)
				_oParameter.Value = _ID;
			else
				_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@dDateReturn", SqlDbType.SmallDateTime);
			_oParameter.Value = _DateReturn;

			_oParameter = _oCommand.Parameters.Add("@bAutoCreated", SqlDbType.Bit);
			_oParameter.Value = _AutoCreated;
			
			_oParameter = _oCommand.Parameters.Add("@nOwnerID", SqlDbType.Int);
			if (_OwnerID.HasValue)
				_oParameter.Value = _OwnerID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nGoodStateID", SqlDbType.Int);
			if (_GoodStateID.HasValue)
				_oParameter.Value = _GoodStateID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
			if (_Note != null)
				_oParameter.Value = _Note;
			else
				_oParameter.Value = "";

			_oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			if (_TripID.HasValue)
				_oParameter.Value = _TripID;
			else
				_oParameter.Value = DBNull.Value;

			_oParameter = _oCommand.Parameters.Add("@nUserCreateID", SqlDbType.Int);
			if (nUserCreateID.HasValue)
				_oParameter.Value = nUserCreateID;
			else
				_oParameter.Value = 0; // DBNull.Value;

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

				// таблица товаров
				if (TableTripsReturnsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(TableTripsReturnsGoods, "#TripsReturnsGoods", _Connect);
				}

				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -10;
				_ErrorStr = "Ошибка при попытке сохранения возврата...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при сохранении возврата...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
				// при создании нового возврата - получим его код
				if ((!_ID.HasValue || _ID == 0) &&
					!Convert.IsDBNull(_oCommand.Parameters["@nTripReturnID"].Value))
				{
					_ID = (int)_oCommand.Parameters["@nTripReturnID"].Value;
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// удаление возврата
		/// </summary>
		public bool Delete(int nTripReturnID)
		{
			String _sqlCommand = "execute up_TripsReturnsDelete @nTripReturnID, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsDelete parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = nTripReturnID;

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
				_ErrorStr = "Ошибка при попытке удаления возврата...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при удалении возврата...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// автоматический расчет возврата
		/// </summary>
		public bool AutoCreate(int nTripID)
		{
			string _sqlCommand = "execute up_TripsReturnsAutoCreate @nTripID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsAutoCreate parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
			_oParameter.Value = nTripID;

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
				_ErrorStr = "Ошибка при попытке автоматического расчета возврата...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при автоматическом расчете возврата...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Save, Delete

		#region Confirm

		/// <summary>
		/// подтверждение возврата 
		/// </summary>
		public bool Confirm()
		{
			string _sqlCommand = "execute up_TripsReturnsConfirm @nTripReturnID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_TripsReturnsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorStr", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_Connect.Open();
				if (_TableTripsReturnsGoods != null)
				{
					RFMUtilities.DataTableToTempTable(_TableTripsReturnsGoods, "#TripsReturnsGoods", _Connect);
				}
				_oCommand.ExecuteScalar();
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке подтверждения возврата...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при подтверждении возврата...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		/// <summary>
		/// снятие подтверждения 
		/// </summary>
		public bool UnConfirm()
		{
			string _sqlCommand = "execute up_TripsReturnsUnConfirm @nTripReturnID, " +
									"@nError output, @cErrorStr output ";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
			_oCommand.CommandTimeout = 0;

			#region up_UnTripsReturnsConfirm parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = _ID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorStr", SqlDbType.VarChar, 200);
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
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке снятия подтверждения возврата...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при снятии подтверждении возврата...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion Confirm

		#region Set/Clear 

		#region ReadyForWMS

		/// <summary>
		/// поставить/очистить признак "возврат готов к передаче в складскую систему"
		/// nUserID: не исп.
		/// </summary>
		public bool SetReadyForWMS(int nTripReturnID)
		{
			return (SetReadyForWMS(nTripReturnID, false, 0));
		}

		public bool SetReadyForWMS(int nTripReturnID, bool bClear,
			int? nUserID)
		{
			string _sqlCommand = "execute up_TripsReturnsSetReadyForWMS @nTripReturnID, @bClear, " +
					"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

			#region up_TripsReturnsSetReadyForWMS parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = nTripReturnID;

			_oParameter = _oCommand.Parameters.Add("@bClear", SqlDbType.Bit);
			_oParameter.Value = bClear;

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
				_ErrorNumber = -102;
				_ErrorStr = "Ошибка при попытке " + (bClear ? "снятия" : "установки") + " признака \"Готово к передече в складскую систему\"...\r\n" + ex.Message;
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
					_ErrorStr = "Ошибка при " + (bClear ? "снятии" : "установке") + " признака \"Готово к передаче в складскую систему\"...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		#endregion ReadyForWMS

		#endregion Set/Clear 


		#region Таблицы

		#region TripsReturnsGoods

		/// <summary>
		/// получение таблицы товаров в возврате TableTripsReturnsGoods
		/// </summary>
		public bool FillTableTripsReturnsGoods(int nTripReturnID)
		{
			string sqlSelect = "execute up_TripsReturnsGoodsFill @nTripReturnID, " +
									"@nError output, @cErrorText output";
			SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

			#region up_TripsReturnsGoodsFill parameters

			SqlParameter _oParameter = _oCommand.Parameters.Add("@nTripReturnID", SqlDbType.Int);
			_oParameter.Value = nTripReturnID;

			_oParameter = _oCommand.Parameters.Add("@nError", SqlDbType.Int);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = 0;

			_oParameter = _oCommand.Parameters.Add("@cErrorText", SqlDbType.VarChar, 200);
			_oParameter.Direction = ParameterDirection.InputOutput;
			_oParameter.Value = "";

			#endregion

			try
			{
				_TableTripsReturnsGoods = FillReadings(new SqlDataAdapter(_oCommand), _TableTripsReturnsGoods, "TableTripsReturnsGoods");
				_TableTripsReturnsGoods.PrimaryKey = new DataColumn[] { _TableTripsReturnsGoods.Columns[0] };
			}
			catch (Exception ex)
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при попытке получения списка товаров в возврате..." + Convert.ToChar(13) + ex.Message;
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			if (_ErrorNumber == 0)
			{
				_ErrorNumber = (int)_oCommand.Parameters["@nError"].Value;
				if (_ErrorNumber != 0)
				{
					_ErrorStr = "Ошибка при получении списка товаров в возврате...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
					RFMMessage.MessageBoxError(_ErrorStr);
				}
			}
			return (_ErrorNumber == 0);
		}

		public bool FillTableTripsReturnsGoods()
		{
			if (_ID.HasValue)
			{
				FillTableTripsReturnsGoods((int)_ID);
			}
			else
			{
				_ErrorNumber = -11;
				_ErrorStr = "Ошибка при получении списка товаров в возврате...\r\n" +
								"Не определен код возврата...";
				RFMMessage.MessageBoxError(_ErrorStr);
			}
			return (_ErrorNumber == 0);
		}

		#endregion TripsReturnsGoods

		#endregion Таблицы

	}

#endregion TripReturn

}
