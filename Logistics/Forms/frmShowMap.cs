using System;
using System.Data;
using System.Windows.Forms;

using RFMPublic;
using LogBizObjects;

using System.Windows.Media;

namespace Logistics
{
    public partial class frmShowMap : RFMBaseClasses.RFMFormChild
    {
        #region Константы
        const string TAB = "\t";
        const string CRLF = "\r\n";
        #endregion

        #region Объекты
        private DataTable tPartnersTable = null;
        private Partner oPartner = null;
        #endregion

        #region Внутренние переменные
        private string sMode = "";

        // центр Москвы
        private double nMapCenterLatitude = 55.76, nMapCenterLongitude = 37.64;

        // координаты базы в Наркомводе
        private double nBaseLat = 55.555, nBaseLng = 38.111;

        private bool isTripNumberExists, isCarNameExists, isOneRoute;

        // Стандартные цвета
        private System.Windows.Media.Color[] aColors = { 
            Colors.Blue, 
            Colors.Bisque,
            Colors.Chartreuse,
            Colors.Chocolate,
            Colors.Coral,
            Colors.Crimson,
            Colors.Fuchsia,
            Colors.Gold,
            Colors.Green, 
            Colors.Khaki,
            Colors.Lime,
            Colors.Magenta,
            Colors.Olive,
            Colors.Orange,
            Colors.Pink,
            Colors.Violet
            };

        #endregion

        /// <summary>
        /// Конструктор для отображения маршрута
        /// </summary>
        /// <param name="PartnersTable">Таблица с точками маршрута</param>
        public frmShowMap(DataTable PartnersTable, bool IsOneRoute)
        {
            #region Входящие параметры
            tPartnersTable = PartnersTable;
            isOneRoute = IsOneRoute;
            #endregion

            #region Проверка входящей таблицы
            if (IsValid)
            {
                if (tPartnersTable == null || tPartnersTable.Rows.Count == 0 || tPartnersTable.Columns.Count == 0)
                {
                    RFMMessage.MessageBoxError("Получена пустая таблица!");
                    IsValid = false;
                }
            }
            if (IsValid)
            {
                if (tPartnersTable.Rows.Count > 1000)
                {
                    RFMMessage.MessageBoxError("Слишком много точек!");
                    IsValid = false;
                }
            }
            #endregion

            #region Проверка наличия необходимых полей
            // Входящая таблица должна содержать как минимум следующие поля:
            // Name - название партнера
            // DeliveryAddress - адрес доставки
            // Latitude - географическая широта
            // Longitude - географическая долгота
            if (IsValid)
            {
                try
                {
                    string testValue;
                    testValue = tPartnersTable.Rows[0]["Name"].ToString();
                    testValue = tPartnersTable.Rows[0]["DeliveryAddress"].ToString();
                    testValue = tPartnersTable.Rows[0]["Latitude"].ToString();
                    testValue = tPartnersTable.Rows[0]["Longitude"].ToString();
                }
                catch
                {
                    RFMMessage.MessageBoxError("Полученная таблица имеет некорректную структуру!");
                    IsValid = false;
                }
            }
            sMode = "T";
            #endregion

            #region Проверка наличия дополнительных полей
            if (IsValid)
            {
                // № рейса
                try
                {
                    string testValue;
                    testValue = tPartnersTable.Rows[0]["TripID"].ToString();
                    isTripNumberExists = true;
                }
                catch { isTripNumberExists = false; }

                // Название машины
                try
                {
                    string testValue;
                    testValue = tPartnersTable.Rows[0]["CarName"].ToString();
                    isCarNameExists = true;
                }
                catch { isCarNameExists = false; }
            }
            #endregion

            if (IsValid)
            {
                InitializeComponent();
            }
        }

        /// <summary>
        /// Конструктор для отображения партнера
        /// </summary>
        /// <param name="Partner">Бизнес-объект "Партнер"</param>
        public frmShowMap(Partner Partner)
        {
            #region Входящий параметр
            oPartner = Partner;

            sMode = "P";
            #endregion

            if (IsValid)
            {
                InitializeComponent();
            }
        }

        private void frmShowMap_Load(object sender, EventArgs e)
        {
            #region Проверка режима работы
            if (sMode != "T" && sMode!= "P")
            {
                Close();
                return;
            }
            #endregion

            #region Получение установок "Координаты центра карты" и "Координаты базы"
            Logistics.Properties.Settings set = new Logistics.Properties.Settings();

            #region Установка центра карты
            try 
            {
                nMapCenterLatitude = Convert.ToDouble(set.MapCenterLatitude);
                nMapCenterLongitude = Convert.ToDouble(set.MapCenterLongitude);
                wfpRadMapControl.SetMapCenter(nMapCenterLatitude, nMapCenterLongitude);
            }
            catch (Exception ex)
            {
                RFMMessage.MessageBoxError("Координаты центра карты указаны неверно!\r\n" + ex.Message);
                return;
            }
            #endregion

            #region Установка координат базы
            try 
            { 
                nBaseLat = Convert.ToDouble(set.MapBaseLatitude);
                nBaseLng = Convert.ToDouble(set.MapBaseLongitude);
                wfpRadMapControl.SetBaseLocation(nBaseLat, nBaseLng);
            }
            catch (Exception ex)
            {
                RFMMessage.MessageBoxError("Координаты базы указаны неверно!\r\n" + ex.Message);
                return;
            }
            #endregion

            #endregion

            #region Режим "Маршрут"
            if (sMode == "T")
            {
                if (!ShowTrip())
                {
                    Close();
                    return;
                }
            }
            #endregion

            #region Режим "Партнер"
            if (sMode == "P")
            {
                if (!ShowPartner())
                {
                    Close();
                    return;
                }
            }
            #endregion
        }

        private void frmShowMap_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Возврат данных о координатах партнера и дистанции до него
            if (sMode == "P" && oPartner != null && wfpRadMapControl.IsPartnerExists())
            {
                double nLatitude = 0, nLongitude = 0;
                int nDistance = 0;
                wfpRadMapControl.GetPartnerCoordinatesAndDistance(out nLatitude, out nLongitude, out nDistance);

                oPartner.Latitude = (decimal?)nLatitude;
                oPartner.Longitude = (decimal?)nLongitude;

                if (nDistance > 0)
                    oPartner.Distance = nDistance;
            }
        }

        private bool ShowTrip()
        {
            wfpRadMapControl.Mode = "T";

            #region Переменные для вычисления составляющих маршрута
            int pointsCount = 0, tripsCount = 0, wrongPartners = 0;
            double nLongitude, nLatitude;
            string sName, sDeliveryAddress, sLongitude, sLatitude;
            string sWrongPartners = "";
            string sTripID = "*", sCurTripID = "", sCarName = "";
            #endregion

            #region Формирование строки с координатами
            foreach (DataRow row in tPartnersTable.Rows)
            {
                // Обработка номера маршрута
                if (isTripNumberExists)
                {
                    sCurTripID = row["TripID"].ToString();
                    if (sTripID == "*") // Обработка первой точки
                    { 
                        sTripID = sCurTripID;
                        tripsCount = 0;
                    }
                    if (sTripID != sCurTripID)
                    {
                        sTripID = sCurTripID;
                        tripsCount++;
                    }
                }
                if (isCarNameExists) sCarName = row["CarName"].ToString();

                #region Получение географических координат
                sLongitude = row["Longitude"].ToString();
                sLatitude = row["Latitude"].ToString();
                #endregion

                #region Получение названия и адреса партнера
                // Название партнера (с отбрасыванием символов " и ')
                sName = row["Name"].ToString();
                sName = sName.Replace("\"", "").Replace("'", "");

                // Адрес доставки (с заменой символа " на ')
                sDeliveryAddress = row["DeliveryAddress"].ToString();
                sDeliveryAddress = sDeliveryAddress.Replace("\"", "").Replace("'", "");
                #endregion

                if (sLongitude.Length > 0 && sLatitude.Length > 0)
                {
                    #region Приведение координат партнера
                    try
                    {
                        nLongitude = Convert.ToDouble(sLongitude);
                        nLatitude = Convert.ToDouble(sLatitude);
                    }
                    catch { continue;  }
                    #endregion

                    pointsCount++;

                    #region Добавление партнера
                    wfpRadMapControl.CreateStaticPartner(
                        nLatitude, nLongitude,
                        sName + CRLF + sDeliveryAddress + CRLF + sCarName,
                        new SolidColorBrush(aColors[tripsCount % aColors.Length])
                        );
                    #endregion
                }
                else
                {
                    wrongPartners++;
                    if (wrongPartners <= 20) sWrongPartners += sName + CRLF;
                    else
                    {
                        if (!sWrongPartners.EndsWith("...")) sWrongPartners += "...";
                    }
                }
            }

            #endregion

            #region Проверка наличия точек
            if (pointsCount == 0)
            {
                RFMMessage.MessageBoxError("Нет данных о координатах партнеров!");
                return false;
            }

            // Отображение точек с проблемами
            if (sWrongPartners.Length > 0)
            {
                sWrongPartners = "Следующие " + wrongPartners.ToString() + " партнер(ов) не имеют координат:\r\n" + sWrongPartners;
                RFMMessage.MessageBoxInfo(sWrongPartners);
            }
            #endregion

            wfpRadMapControl.SetBestView();

            return true;
        }

        private bool ShowPartner()
        {
            wfpRadMapControl.Mode = "P";
            
            #region Получение названия и адреса партнера
            string sPartnerName = "", sPartnerAddress = "";

            // Название партнера (с отбрасыванием символов " и ')
            sPartnerName = oPartner.Name;
            sPartnerName = sPartnerName.Replace("\"", "").Replace("'", "");

            // Адрес доставки (с отбрасыванием символов " и ')
            sPartnerAddress = (oPartner.DeliveryAddress.Length != 0 ? oPartner.DeliveryAddress : oPartner.DeliveryPassage);
            sPartnerAddress = sPartnerAddress.Replace("\"", "'").Replace("'", "");
            #endregion

            // Добавление партнера
            wfpRadMapControl.CreateDruggablePartner(
                oPartner.Latitude, oPartner.Longitude, 
                sPartnerAddress, 
                sPartnerName + CRLF + sPartnerAddress);

            return true;
        }
    }
}

