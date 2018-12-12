using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;

using RFMPublic; 

namespace LogBizObjects
{

#region CarTask

    public class CarTask : BizObject
    {
        protected string _IDList;
        /// <summary>
        /// Список ID расходов (Outputs.ID)
        /// </summary>
        [Description("Список ID расходов (Outputs.ID)")]
        public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

        #region Поля, свойства

        protected DateTime _DateTask;
        /// <summary>
        /// Дата спецзадания (CarsTasks.DateTask)
        /// </summary>
        [Description("Дата спецзадания (CarsTasks.DateTask)")]
        public DateTime DateTask { get { return _DateTask; } set { _DateTask = value; } }



        protected int? _PartnerID;
        /// <summary>
        /// Получатель работы/услуги - код (CarsTasks.PartnerID -> Partners.ID)
        /// </summary>
        [Description("Получатель работы/услуги - код (CarsTasks.PartnerID -> Partners.ID)")]
        public int? PartnerID { get { return _PartnerID; } set { _PartnerID = value; } }

        protected string _PartnerName;
        /// <summary>
        /// Получатель работы/услуги - наименование (CarsTasks.PartnerID -> Partners.ID -> Partners.Name)
        /// </summary>
        [Description("Получатель работы/услуги - наименование (CarsTasks.PartnerID -> Partners.ID -> Partners.Name)")]
        public string PartnerName { get { return _PartnerName; } set { _PartnerName = value; } }



        protected int? _TripID;
        /// <summary>
        /// Рейс - код (CarsTasks.TripID)
        /// </summary>
        [Description("Рейс - код (CarsTasks.TripID)")]
        public int? TripID { get { return _TripID; } set { _TripID = value; } }

        protected bool _TripExists;
        /// <summary>
        /// Спецзадание присоединено к рейсу (CarsTasks.TripID is not Null)?
        /// </summary>
        [Description("Спецзадание присоединено к рейсу (CarsTasks.TripID is not Null)?")]
        public bool TripExists { get { return _TripExists; } set { _TripExists = value; } }



        protected string _DeliveryAddress;
        /// <summary>
        /// Адрес доставки (CarsTasks.DeliveryAddress)
        /// </summary>
        [Description("Адрес доставки (CarsTasks.DeliveryAddress)")]
        public string DeliveryAddress { get { return _DeliveryAddress; } set { _DeliveryAddress = value; } }

        protected int? _ZoneID;
        /// <summary>
        /// Зона доставки - код (CarsTasks.ZoneID)
        /// </summary>
        [Description("Зона доставки - код (CarsTasks.ZoneID)")]
        public int? ZoneID { get { return _ZoneID; } set { _ZoneID = value; } }

        protected string _ZoneName;
        /// <summary>
        /// Зона доставки - наименование (CarsTasks.ZoneID -> Zones.Name)
        /// </summary>
        [Description("Зона доставки - наименование (CarsTasks.ZoneID -> Zones.Name)")]
        public string ZoneName { get { return _ZoneName; } set { _ZoneName = value; } }

        protected decimal? _Latitude;
        /// <summary>
        /// Географическая широта (CarsTasks.Latitude)
        /// </summary>
        [Description("Географическая широта (CarsTasks.Latitude)")]
        public decimal? Latitude { get { return _Latitude; } set { _Latitude = value; } }

        protected decimal? _Longitude;
        /// <summary>
        /// Географическая долгота (CarsTasks.Longitude)
        /// </summary>
        [Description("Географическая широта (CarsTasks.Longitude)")]
        public decimal? Longitude { get { return _Longitude; } set { _Longitude = value; } }

        protected int _Distance;
        /// <summary>
        /// Расстояние до клиента, км (CarsTasks.Distance)
        /// </summary>
        [Description("Расстояние до клиента, км (CarsTasks.Distance)")]
        public int Distance { get { return _Distance; } set { _Distance = value; } }



        protected decimal _Netto;
        /// <summary>
        /// Вес товара - нетто, кг (CarsTasks.Netto)
        /// </summary>
        [Description("Вес товара - нетто, кг (CarsTasks.Netto)")]
        public decimal Netto { get { return _Netto; } set { _Netto = value; } }

        protected decimal _Brutto;
        /// <summary>
        /// Вес перевозимого товара - брутто, кг (CarsTasks.Brutto)
        /// </summary>
        [Description("Вес товара - брутто, кг (CarsTasks.Brutto)")]
        public decimal Brutto { get { return _Brutto; } set { _Brutto = value; } }

        protected decimal _PalletsQnt;
        /// <summary>
        /// Количество перевозимых паллет с товаром (CarsTasks.PalletsQnt)
        /// </summary>
        [Description("Количество перевозимых паллет с товаром (CarsTasks.PalletsQnt)")]
        public decimal PalletsQnt { get { return _PalletsQnt; } set { _PalletsQnt = value; } }



        protected decimal _TaskInnerCost;
        /// <summary>
        /// Стоимость доставки нашим транспортом, руб. (CarsTasks.TaskInnerCost)
        /// </summary>
        [Description("Стоимость доставки нашим транспортом, руб. (CarsTasks.TaskInnerCost)")]
        public decimal TaskInnerCost { get { return _TaskInnerCost; } set { _TaskInnerCost = value; } }

        protected decimal _TaskOuterCost;
        /// <summary>
        /// Стоимость доставки транспортом перевозчика, руб. (CarsTasks.TaskOuterCost)
        /// </summary>
        [Description("Стоимость доставки транспортом перевозчика, руб. (CarsTasks.TaskOuterCost)")]
        public decimal TaskOuterCost { get { return _TaskOuterCost; } set { _TaskOuterCost = value; } }

        protected int? _CarTaskUnitID;
        /// <summary>
        /// Тип работ/услуг - код (CarsTasks.CarTaskUnitID)
        /// </summary>
        [Description("Тип работ/услуг - код (CarsTasks.CarTaskUnitID)")]
        public int? CarTaskUnitID { get { return _CarTaskUnitID; } set { _CarTaskUnitID = value; } }

        protected string _CarTaskUnitName;
        /// <summary>
        /// Тип работ/услуг - наименование (CarsTasks.CarTaskUnitID -> CarsTasksUnits.Name)
        /// </summary>
        [Description("Тип работ/услуг - наименование (CarsTasks.CarTaskUnitID -> CarsTasksUnits.Name)")]
        public string CarTaskUnitName { get { return _CarTaskUnitName; } set { _CarTaskUnitName = value; } }

        protected string _CarTaskUnitAlias;
        /// <summary>
        /// Тип работ/услуг - краткое наименование (CarsTasks.CarTaskUnitID -> CarsTasksUnits.Alias)
        /// </summary>
        [Description("Тип работ/услуг - краткое наименование (CarsTasks.CarTaskUnitID -> CarsTasksUnits.Alias)")]
        public string CarTaskUnitAlias { get { return _CarTaskUnitAlias; } set { _CarTaskUnitAlias = value; } }

        protected decimal _UnitsQnt;
        /// <summary>
        /// Количество единиц работ/услуг (CarsTasks.UnitsQnt)
        /// </summary>
        [Description("Количество единиц работ/услуг (CarsTasks.UnitsQnt)")]
        public decimal UnitsQnt { get { return _UnitsQnt; } set { _UnitsQnt = value; } }

        protected decimal _Price;
        /// <summary>
        /// Цена единицы работ/услуг (CarsTasks.Price)
        /// </summary>
        [Description("Цена единицы работ/услуг (CarsTasks.Price)")]
        public decimal Price { get { return _Price; } set { _Price = value; } }

        protected decimal _TaskAmount;
        /// <summary>
        /// Сумму, выставляемая клиенту, руб. (CarsTasks.TaskAmount)
        /// </summary>
        [Description("Сумму, выставляемая клиенту, руб. (CarsTasks.TaskAmount)")]
        public decimal TaskAmount { get { return _TaskAmount; } set { _TaskAmount = value; } }

        protected bool _IsCach;
        /// <summary>
        /// Признак оплаты нал. (CarsTasksUnits.IsCach)?
        /// </summary>
        [Description("Признак оплаты нал. (CarsTasksUnits.IsCach)?")]
        public bool IsCach { get { return _IsCach; } set { _IsCach = value; } }



        protected string _DepartmentName;
        /// <summary>
        /// Наименование отдела (всегда транспортный)
        /// </summary>
        [Description("Наименование отдела (всегда транспортный)")]
        public string DepartmentName { get { return _DepartmentName; } set { _DepartmentName = value; } }

        protected string _Note;
        /// <summary>
        /// Примечание к спецзаданию (CarsTasksUnits.Note)
        /// </summary>
        [Description("Примечание к спецзаданию (CarsTasksUnits.Note)")]
        public string Note { get { return _Note; } set { _Note = value; } }

        protected DateTime? _DateIndent;
        /// <summary>
        /// Дата создания спецзадания (CarsTasks.DateIndent)
        /// </summary>
        [Description("Дата создания спецзадания (CarsTasks.DateIndent)")]
        public DateTime? DateIndent { get { return _DateIndent; } set { _DateIndent = value; } }

        protected int? _UserIndentID;
        /// <summary>
        /// Пользователь, создавший спецзадание - код (CarsTasks.UserIndentID)
        /// </summary>
        [Description("Пользователь, создавший спецзадание - код (CarsTasks.UserIndentID)")]
        public int? UserIndentID { get { return _UserIndentID; } set { _UserIndentID = value; } }

        protected string _UserIndentName;
        /// <summary>
        /// Пользователь, создавший спецзадание - ФИО (CarsTasks.UserIndentID -> Employees.Name)
        /// </summary>
        [Description("Пользователь, создавший спецзадание - ФИО (CarsTasks.UserIndentID -> Employees.Name)")]
        public string UserIndentName { get { return _UserIndentName; } set { _UserIndentName = value; } }

        protected DateTime? _DateConfirm;
        /// <summary>
        /// Дата подтверждения спецзадания (CarsTasks.DateConfirm)
        /// </summary>
        [Description("Дата подтверждения спецзадания (CarsTasks.DateConfirm)")]
        public DateTime? DateConfirm { get { return _DateConfirm; } set { _DateConfirm = value; } }

        protected int? _UserConfirmID;
        /// <summary>
        /// Пользователь, подтвердивший спецзадание - код (CarsTasks.UserConfirmID)
        /// </summary>
        [Description("Пользователь, подтвердивший спецзадание - код (CarsTasks.UserConfirmID)")]
        public int? UserConfirmID { get { return _UserConfirmID; } set { _UserConfirmID = value; } }

        protected string _UserConfirmName;
        /// <summary>
        /// Пользователь, подтвердивший спецзадание - ФИО (CarsTasks.UserConfirmID -> Employees.Name)
        /// </summary>
        [Description("Пользователь, подтвердивший спецзадание - ФИО (CarsTasks.UserConfirmID -> Employees.Name)")]
        public string UserConfirmName { get { return _UserConfirmName; } set { _UserConfirmName = value; } }

        protected bool _IsConfirmed;
        /// <summary>
        /// Подтверждено (CarsTasks.IsConfirmed)?
        /// </summary>
        [Description("Подтвердждено (CarsTasks.IsConfirmed)?")]
        public bool IsConfirmed { get { return _IsConfirmed; } set { _IsConfirmed = value; } }

        #endregion Поля, свойства

        #region Фильтры

        protected DateTime? _FilterDateBeg;
        /// <summary>
        /// Фильтр-поле: дата спецзадания - начальная дата периода (CarsTasks.DateOutput)
        /// </summary>
        [Description("Фильтр-поле: дата спецзадания - начальная дата периода (CarsTasks.DateOutput)")]
        public DateTime? FilterDateBeg { get { return _FilterDateBeg; } set { _FilterDateBeg = value; _NeedRequery = true; } }

        protected DateTime? _FilterDateEnd;
        /// <summary>
        /// Фильтр-поле: дата спецзадания - конечная дата периода (CarsTasks.DateOutput)
        /// </summary>
        [Description("Фильтр-поле: дата спецзадания - конечная дата периода (CarsTasks.DateOutput)")]
        public DateTime? FilterDateEnd { get { return _FilterDateEnd; } set { _FilterDateEnd = value; _NeedRequery = true; } }

        protected bool? _FilterIsConfirmed;
        /// <summary>
        /// Фильтр-поле: спецзадание подтверждено (CarsTasks.DateConfirm is not Null)?
        /// </summary>
        [Description("Фильтр-поле: спецзадание подтверждено (CarsTasks.DateConfirm is not Null)?")]
        public bool? FilterIsConfirmed { get { return _FilterIsConfirmed; } set { _FilterIsConfirmed = value; _NeedRequery = true; } }

        protected string _FilterPartnersList;
        /// <summary>
        /// Фильтр-поле: список кодов клиентов, через запятую (CarsTasks.PartnerID)
        /// </summary>
        [Description("Фильтр-поле: список кодов клиентов, через запятую (CarsTasks.PartnerID)")]
        public string FilterPartnersList { get { return _FilterPartnersList; } set { _FilterPartnersList = value; _NeedRequery = true; } }

        protected string _FilterPartnerNameContext;
        /// <summary>
        /// Фильтр-поле: название клиента, контекст (CarsTasks.PartnerID -> Partners.Name)
        /// </summary>
        [Description("Фильтр-поле: название клиента, контекст (CarsTasks.PartnerID -> Partners.Name)")]
        public string FilterPartnerNameContext { get { return _FilterPartnerNameContext; } set { _FilterPartnerNameContext = value; _NeedRequery = true; } }

        protected bool? _FilterTripExists;
        /// <summary>
        /// Фильтр-поле: спецзадание присоединено к рейсу (CarsTasks.TripID is not Null)?
        /// </summary>
        [Description("Фильтр-поле: спецзадание присоединено к рейсу (CarsTasks.TripID is not Null)?")]
        public bool? FilterTripExists { get { return _FilterTripExists; } set { _FilterTripExists = value; _NeedRequery = true; } }

        protected string _FilterTripsList;
        /// <summary>
        /// Фильтр-поле: список кодов рейсов, через запятую (CarsTasks.TripID)
        /// </summary>
        [Description("Фильтр-поле: список кодов рейсов, через запятую (CarsTasks.TripID)")]
        public string FilterTripsList { get { return _FilterTripsList; } set { _FilterTripsList = value; _NeedRequery = true; } }

        #endregion Фильтры

        #region Таблицы

        protected DataTable _TableCarsTasksUnits;
        /// <summary>
        /// Таблица единиц измерения работ/услуг CarsTasksUnits
        /// </summary>
        [Description("Таблица единиц измерения работ/услуг CarsTasksUnits")]
        public DataTable TableCarsTasksUnits { get { return _TableCarsTasksUnits; } }

        #endregion Таблицы

		// -------------------------------------

		public CarTask() : base()
		{
			_MainTableName = "CarsTasks";
			_ColumnID = "ID";
			_ColumnName = "DateTask";
        }

        #region FillData

        /// <summary>
        /// получение полного списка спецзаданий с дополнительными сведениями в MainTable
        /// </summary>
        public override bool FillDataAsync()
        {
            ClearData();

            string sqlSelect = "execute up_CarsTasksFill @nID, @cIDList, " +
                                    "@dDateBeg, @dDateEnd, " +
                                    "@bIsConfirmed, " +
                                    "@cPartnersList, @cPartnerNameContext, " +
                                    "@bTripExists, @cTripsList";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_OutputsFill parameters

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

            _oParameter = _oCommand.Parameters.Add("@bIsConfirmed", SqlDbType.Bit);
            if (_FilterIsConfirmed != null)
                _oParameter.Value = _FilterIsConfirmed;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cPartnersList", SqlDbType.VarChar);
            if (_FilterPartnersList != null)
                _oParameter.Value = _FilterPartnersList;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cPartnerNameContext", SqlDbType.VarChar);
            if (_FilterPartnerNameContext != null)
                _oParameter.Value = _FilterPartnerNameContext;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bTripExists", SqlDbType.Bit);
            if (_FilterTripExists != null)
                _oParameter.Value = _FilterTripExists;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cTripsList", SqlDbType.VarChar);
            if (_FilterTripsList != null)
                _oParameter.Value = _FilterTripsList;
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
                _ErrorStr = "Ошибка при получении списка спецзаданий..." + Convert.ToChar(13) + ex.Message;
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

            _FilterPartnersList = null;
            _FilterPartnerNameContext = null;
            _FilterIsConfirmed = null;

            _FilterTripExists = null;
            _FilterTripsList = null;
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

                    _DateTask = Convert.ToDateTime(r["DateTask"]);

                    if (!Convert.IsDBNull(r["PartnerID"]))
                        _PartnerID = Convert.ToInt32(r["PartnerID"]);
                    _PartnerName = r["PartnerName"].ToString();

                    if (!Convert.IsDBNull(r["TripID"]))
                        _TripID = Convert.ToInt32(r["TripID"]);
                    _TripExists = Convert.ToBoolean(r["TripExists"]);

                    if (!Convert.IsDBNull(r["ZoneID"]))
                        _ZoneID = Convert.ToInt32(r["ZoneID"]);
                    _ZoneName = r["ZoneName"].ToString();
                    _DeliveryAddress = r["DeliveryAddress"].ToString();

                    if (!Convert.IsDBNull(r["Latitude"]))
                        _Latitude = Convert.ToDecimal(r["Latitude"]);
                    if (!Convert.IsDBNull(r["Longitude"]))
                        _Longitude = Convert.ToDecimal(r["Longitude"]);
                    _Distance = Convert.ToInt32(r["Distance"]);

                    _Netto = Convert.ToDecimal(r["Netto"]);
                    _Brutto = Convert.ToDecimal(r["Brutto"]);
                    _PalletsQnt = Convert.ToDecimal(r["PalletsQnt"]);

                    _TaskInnerCost = Convert.ToDecimal(r["TaskInnerCost"]);
                    _TaskOuterCost = Convert.ToDecimal(r["TaskOuterCost"]);
                    if (!Convert.IsDBNull(r["CarTaskUnitID"]))
                        _CarTaskUnitID = Convert.ToInt32(r["CarTaskUnitID"]);
                    if (!Convert.IsDBNull(r["CarTaskUnitName"]))
                        _CarTaskUnitName = (r["CarTaskUnitName"]).ToString();
                    if (!Convert.IsDBNull(r["CarTaskUnitAlias"]))
                        _CarTaskUnitAlias = (r["CarTaskUnitAlias"]).ToString();
                    _UnitsQnt = Convert.ToDecimal(r["UnitsQnt"]);
                    _Price = Convert.ToDecimal(r["Price"]);
                    _TaskAmount = Convert.ToDecimal(r["TaskAmount"]);
                    _IsCach = Convert.ToBoolean(r["IsCash"]);

                    _DepartmentName = r["DepartmentName"].ToString();
                    _Note = (r["Note"]).ToString();

                    if (!Convert.IsDBNull(r["DateIndent"]))
                        _DateIndent = Convert.ToDateTime(r["DateIndent"]);
                    if (!Convert.IsDBNull(r["UserIndentID"]))
                        _UserIndentID = Convert.ToInt32(r["UserIndentID"]);
                    if (!Convert.IsDBNull(r["UserIndentName"]))
                        _UserIndentName = (r["UserIndentName"]).ToString();

                    if (!Convert.IsDBNull(r["DateConfirm"]))
                        _DateConfirm = Convert.ToDateTime(r["DateConfirm"]);
                    if (!Convert.IsDBNull(r["UserConfirmID"]))
                        _UserConfirmID = Convert.ToInt32(r["UserConfirmID"]);
                    if (!Convert.IsDBNull(r["UserConfirmName"]))
                        _UserConfirmName = (r["UserConfirmName"]).ToString();
                    _IsConfirmed = Convert.ToBoolean(r["IsConfirmed"]);
                }
                catch (Exception ex)
                {
                    _ErrorNumber = -100;
                    _ErrorStr = "Ошибка при получении данных о спецзадании...\n" +
                        ex.Message;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            else
            {
                _ErrorNumber = -101;
                _ErrorStr = "Ошибка при получении данных о спецзадании (нет данных)...";
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

            _DateTask = DateTime.Now.Date;

            _PartnerID = null;
            _PartnerName = null;
            _TripID = null;
            _TripExists = false;

            _DeliveryAddress = null;
            _ZoneID = null;
            _ZoneName = null;

            _Latitude = null;
            _Longitude = null;
            _Distance = 0;

            _Netto = 0;
            _Brutto = 0;
            _PalletsQnt = 0;

            _TaskInnerCost = 0;
            _TaskOuterCost = 0;
            _CarTaskUnitID = null;
            _CarTaskUnitName = null;
            _CarTaskUnitAlias = null;
            _UnitsQnt = 0;
            _Price = 0;
            _TaskAmount = 0;
            _IsCach = false;

            _DepartmentName = null;
            _Note = null;

            _DateIndent = null;
            _UserIndentID = null;
            _UserIndentName = null;

            _DateConfirm = null;
            _UserConfirmID = null;
            _UserConfirmName = null;
            _IsConfirmed = false;
        }

        #endregion FillOne

        #region FillTables

        public bool FillTableCarsTasksUnits()
        {
            string sqlSelect = "execute up_CarsTasksUnitsFill";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            try
            {
                _TableCarsTasksUnits = FillReadings(new SqlDataAdapter(_oCommand), _TableCarsTasksUnits, "TableCarsTasksUnits");
                _TableCarsTasksUnits.PrimaryKey = new DataColumn[] { _TableCarsTasksUnits.Columns[0] };
            }
            catch (Exception ex)
            {
                _ErrorNumber = -11;
                _ErrorStr = "Ошибка при получении списка единиц измерения работ/услуг..." + Convert.ToChar(13) + ex.Message;
                RFMMessage.MessageBoxError(_ErrorStr);
            }
            return (_ErrorNumber == 0);
        }

        #endregion FillTables

        #region Save, Delete

        public bool SaveOne()
        {
            string _sqlCommand = "execute up_CarsTasksSave @nCarTaskID output, " +
                                    "@dDateTask, " +
                                    "@nPartnerID, " +
                                    "@cDeliveryAddress, @nZoneID, @nLatitude, @nLongitude, @nDistance, " +
                                    "@nNetto, @nBrutto, @nPalletsQnt, " +
                                    "@nTaskInnerCost, @nTaskOuterCost, " +
                                    "@nCarTaskUnitID, @nUnitsQnt, @nPrice, @bIsCash, " +
                                    "@cNote, " +
                                    "@nUserIndentID, " +
                                    "@nError output, @cErrorText output";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

            #region up_CarsTasksSave parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskID", SqlDbType.Int);
            _oParameter.Direction = ParameterDirection.InputOutput;
            if (_ID.HasValue)
                _oParameter.Value = _ID;
            else
                _oParameter.Value = 0;

            _oParameter = _oCommand.Parameters.Add("@dDateTask", SqlDbType.SmallDateTime);
            _oParameter.Value = _DateTask;

            _oParameter = _oCommand.Parameters.Add("@nPartnerID", SqlDbType.Int);
            _oParameter.Value = _PartnerID;

            _oParameter = _oCommand.Parameters.Add("@cDeliveryAddress", SqlDbType.VarChar);
            if (_DeliveryAddress != null)
                _oParameter.Value = _DeliveryAddress;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nZoneID", SqlDbType.Int);
            if (_ZoneID.HasValue)
                _oParameter.Value = _ZoneID;
            else
                _oParameter.Value = DBNull.Value;
            _oParameter = _oCommand.Parameters.Add("@nLatitude", SqlDbType.Decimal);
            if (_Latitude.HasValue)
                _oParameter.Value = _Latitude;
            else
                _oParameter.Value = DBNull.Value;
            _oParameter = _oCommand.Parameters.Add("@nLongitude", SqlDbType.Decimal);
            if (_Longitude.HasValue)
                _oParameter.Value = _Longitude;
            else
                _oParameter.Value = DBNull.Value;
            _oParameter = _oCommand.Parameters.Add("@nDistance", SqlDbType.Int);
            _oParameter.Value = _Distance;

            _oParameter = _oCommand.Parameters.Add("@nNetto", SqlDbType.Decimal);
            _oParameter.Value = _Netto;
            _oParameter = _oCommand.Parameters.Add("@nBrutto", SqlDbType.Decimal);
            _oParameter.Value = _Brutto;
            _oParameter = _oCommand.Parameters.Add("@nPalletsQnt", SqlDbType.Decimal);
            _oParameter.Value = _PalletsQnt;

            _oParameter = _oCommand.Parameters.Add("@nTaskInnerCost", SqlDbType.Decimal);
            _oParameter.Value = _TaskInnerCost;
            _oParameter = _oCommand.Parameters.Add("@nTaskOuterCost", SqlDbType.Decimal);
            _oParameter.Value = _TaskOuterCost;

            _oParameter = _oCommand.Parameters.Add("@nCarTaskUnitID", SqlDbType.Int);
            if (_CarTaskUnitID.HasValue)
                _oParameter.Value = _CarTaskUnitID;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@nUnitsQnt", SqlDbType.Decimal);
            _oParameter.Value = _UnitsQnt;
            _oParameter = _oCommand.Parameters.Add("@nPrice", SqlDbType.Decimal);
            _oParameter.Value = _Price;
            _oParameter = _oCommand.Parameters.Add("@bIsCash", SqlDbType.Bit);
            _oParameter.Value = _IsCach;

            _oParameter = _oCommand.Parameters.Add("@cNote", SqlDbType.VarChar);
            _oParameter.Value = _Note;

            _oParameter = _oCommand.Parameters.Add("@nUserIndentID", SqlDbType.Int);
            _oParameter.Value = _UserIndentID;

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
                _ErrorStr = "Ошибка при попытке сохранения спецзадания...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при сохранении спецзадания...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
                // при создании нового рейса - получим его код
                if ((!_ID.HasValue || _ID == 0) &&
                    !Convert.IsDBNull(_oCommand.Parameters["@nCarTaskID"].Value))
                {
                    _ID = (int)_oCommand.Parameters["@nCarTaskID"].Value;
                }
            }
            return (_ErrorNumber == 0);
        }

        /// <summary>
        /// удаление рейса
        /// </summary>
        public bool DeleteOne(int nCarTaskID)
        {
            String _sqlCommand = "execute up_CarsTasksDelete @nCarTaskID, " +
                    "@nError output, @cErrorText output";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

            #region up_CarsTasksDelete parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskID", SqlDbType.Int);
            _oParameter.Value = _ID;

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
                _ErrorStr = "Ошибка при попытке удаления спецзадания...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при удалении спецзадания...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            return (_ErrorNumber == 0);
        }

        
        #endregion Delete

        #region Confirm

        public bool Confirm(int nUserConfirmID, bool bDropConfirm)
        {
            string _sqlCommand = "execute up_CarsTasksConfirm " + 
                    "@nCarTaskID, @nUserConfirmID, @bDropConfirm, " +
                    "@nError output, @cErrorText output";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);

            #region up_TripsConfirm parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskID", SqlDbType.Int);
            _oParameter.Value = _ID;

            _oParameter = _oCommand.Parameters.Add("@nUserConfirmID", SqlDbType.Int);
            _oParameter.Value = nUserConfirmID;

            _oParameter = _oCommand.Parameters.Add("@bDropConfirm", SqlDbType.Bit);
            _oParameter.Value = bDropConfirm;

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
                _ErrorStr = "Ошибка при попытке подтверждения спецзадания...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при подтверждении спецзадания...\r\n" + _oCommand.Parameters["@cErrorText"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            return (_ErrorNumber == 0);
        }

        #endregion Confirm

        #region ToTrip

        /// <summary>
        /// привязка спецзадания к рейсу
        /// </summary>
        public bool ToTrip(int nTripID)
        {
            if (!_ID.HasValue)
            {
                _ErrorNumber = -111;
                _ErrorStr = "Ошибка при попытке привязки спецзадания к рейсу:\n" +
                    "не задан код спецзадания...";
                RFMMessage.MessageBoxError(_ErrorStr);
                return (false);
            }
            return (ToTrip((int)_ID, nTripID));
        }

        public bool ToTrip(int nCarTaskID, int nTripID)
        {
            string _sqlCommand = "execute up_CarsTasksToTrip @nCarTaskID, " +
                                    "@nTripID, " +
                                    "@nError output, @cErrorStr output ";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
            _oCommand.CommandTimeout = 0;

            #region up_CarsTasksToTrip parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskID", SqlDbType.Int);
            _oParameter.Value = nCarTaskID;

            _oParameter = _oCommand.Parameters.Add("@nTripID", SqlDbType.Int);
            _oParameter.Value = nTripID;

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
                _ErrorStr = "Ошибка при попытке привязки спецзадания к рейсу...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при привязке спецзадания к рейсу...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
                else
                {
                    if (_ID.HasValue)
                        TripID = nTripID;
                }
            }
            return (_ErrorNumber == 0);
        }

        /// <summary>
        /// снятие привязки спецзадания к рейсу
        /// </summary>
        public bool UnToTrip()
        {
            if (!_ID.HasValue)
            {
                _ErrorNumber = -111;
                _ErrorStr = "Ошибка при попытке снятия привязки спецзадания к рейсу:\n" +
                    "не задан код спецзадания...";
                RFMMessage.MessageBoxError(_ErrorStr);
                return (false);
            }
            return (UnToTrip((int)_ID));
        }

        public bool UnToTrip(int nCarTaskID)
        {
            string _sqlCommand = "execute up_CarsTasksUnToTrip @nCarTaskID, " +
                                    "@nError output, @cErrorStr output ";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
            _oCommand.CommandTimeout = 0;

            #region up_CarsTasksUnToTrip parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskID", SqlDbType.Int);
            _oParameter.Value = nCarTaskID;

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
                _ErrorStr = "Ошибка при попытке снятия привязки спецзадания к рейсу...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при снятии привязки спецзадания к рейсу...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
                else
                {
                    if (_ID.HasValue)
                        TripID = null;
                }
            }
            return (_ErrorNumber == 0);
        }

        /// <summary>
        /// смена даты спецзадания на другой день
        /// </summary>
        public bool ChangeDate(int nCarTaskID, DateTime dNewDate)
        {
            string _sqlCommand = "execute up_CarsTasksChangeDate @nCarTaskID, " +
                    "@dNewDate, " +
                    "@nError output, @cErrorStr output";
            SqlCommand _oCommand = new SqlCommand(_sqlCommand, _Connect);
            _oCommand.CommandTimeout = 0;

            #region up_CarsTasksChangeDate parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskID", SqlDbType.Int);
            _oParameter.Value = nCarTaskID;

            _oParameter = _oCommand.Parameters.Add("@dNewDate", SqlDbType.SmallDateTime);
            _oParameter.Value = dNewDate;

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
                _ErrorStr = "Ошибка при попытке смены даты спецзадания на другую дату...\r\n" + ex.Message;
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
                    _ErrorStr = "Ошибка при смене даты приходного документа на другую дату...\r\n" + _oCommand.Parameters["@cErrorStr"].Value;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            return (_ErrorNumber == 0);
        }

        #endregion ToTrip
    }

#endregion CarTask
}
