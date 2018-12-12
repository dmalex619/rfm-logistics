using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using RFMPublic;

namespace LogBizObjects
{

#region CarTaskUnit

    public class CarTaskUnit : BizObject
    {
        protected string _IDList;
        /// <summary>
        /// Список кодов ID единиц измерения (CarsTasksUnits.ID)
        /// </summary>
        [Description("Список кодов ID единиц измерения (CarsTasksUnits.ID)")]
        public string IDList { get { return _IDList; } set { _IDList = value; _NeedRequery = true; } }

        #region Поля, свойства

        protected string _Name;
        /// <summary>
        /// Наименование единицы измерения (CarsTasksUnits.Name)
        /// </summary>
        [Description("Наименование единицы измерения (CarsTasksUnits.Name)")]
        public string Name { get { return _Name; } set { _Name = value; } }

        protected string _Alias;
        /// <summary>
        /// Краткое наименование единицы измерения (CarsTasksUnits.Alias)
        /// </summary>
        [Description("Краткое наименование единицы измерения (CarsTasksUnits.Alias)")]
        public string Alias { get { return _Alias; } set { _Alias = value; } }

        protected bool _Actual;
        /// <summary>
        /// Актуально (CarsTasksUnits.Actual)?
        /// </summary>
        [Description("Актуально (CarsTasksUnits.Actual)?")]
        public bool Actual { get { return _Actual; } set { _Actual = value; } }

        #endregion Поля, свойства

        #region Фильтры

        protected bool? _FilterActual;
        /// <summary>
        /// Фильтр-поле: актуальные единицы измерения (CarsTasksUnits.Actual)?
        /// </summary>
        [Description("Фильтр-поле: актуальные единицы измерения (CarsTasksUnits.Actual)?")]
        public bool? FilterActual { get { return _FilterActual; } set { _FilterActual = value; _NeedRequery = true; } }

        #endregion Фильтры

        // -------------------

        public CarTaskUnit() : base()
		{
            _MainTableName = "CarsTasksUnits";
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

            string sqlSelect = "execute up_CarsTasksUnitsFill @nCarTaskUnitID, @cIDList, @bActual";
            SqlCommand _oCommand = new SqlCommand(sqlSelect, _Connect);

            #region up_CarsTasksUnitsFill parameters

            SqlParameter _oParameter = _oCommand.Parameters.Add("@nCarTaskUnitID", SqlDbType.Int);
            if (_ID != null)
                _oParameter.Value = _ID;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@cIDList", SqlDbType.VarChar);
            if (_IDList != null)
                _oParameter.Value = _IDList;
            else
                _oParameter.Value = DBNull.Value;

            _oParameter = _oCommand.Parameters.Add("@bActual", SqlDbType.Bit);
            if (_FilterActual != null)
                _oParameter.Value = _FilterActual;
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
                _ErrorStr = "Ошибка при получении общего списка единиц измерения..." + Convert.ToChar(13) + ex.Message;
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
                    _Actual = Convert.ToBoolean(r["Actual"]);
                }
                catch (Exception ex)
                {
                    _ErrorNumber = -100;
                    _ErrorStr = "Ошибка при получении данных о единице измерения...\n" +
                        ex.Message;
                    RFMMessage.MessageBoxError(_ErrorStr);
                }
            }
            else
            {
                _ErrorNumber = -101;
                _ErrorStr = "Ошибка при получении данных о единице измерения (нет данных)...";
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
            _Actual = false;
        }

        #endregion FillOne

    }

#endregion
}
