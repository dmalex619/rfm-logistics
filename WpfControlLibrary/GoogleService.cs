using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Telerik.Windows.Controls.Map;

namespace WpfControlLibrary
{
    public static class GoogleService
    {
        static string googleApiKey = "AIzaSyCuQT5yvjiiPWDqP6-ELoBHdLyA4bBFRyM";

        /// <summary>
        /// Geocode address with Google maps static API
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Latitude"></param>
        /// <param name="Longitude"></param>
        /// <returns></returns>
        public static bool GeocodeAddress(string Address, out double? Latitude, out double? Longitude, out string sErrorText)
        {
            Latitude = Longitude = double.NaN;
            sErrorText = "";

            // Check address
            if (Address.Length == 0)
            {
                sErrorText = "Пустой адрес, геокодирование невозможно!";
                return false;
            }

            HttpWebRequest hRequest;
            try
            {
                string requestUri = String.Format(
                    "https://maps.googleapis.com/maps/api/geocode/xml?address={1}&key={0}&region=ru&sensor=false",
                    googleApiKey, Uri.EscapeDataString(Address));
                hRequest = (HttpWebRequest)WebRequest.Create(requestUri);
            }
            catch (Exception e)
            {
                sErrorText = "Что-то не так с запросом адреса: " + e.Message;
                return false;
            }

            HttpWebResponse hResponse;
            try
            {
                hResponse = (HttpWebResponse)hRequest.GetResponse();
            }
            catch (Exception e)
            {
                sErrorText = "Что-то не так с ответом сервера: " + e.Message;
                return false;
            }

            if (hResponse.StatusCode != HttpStatusCode.OK)
            {
                sErrorText = "Сервер геокодирования не отвечает!";
                hResponse.Close();
                return false;
            }

            Stream dataStream = hResponse.GetResponseStream();
            StreamReader sReader = new StreamReader(dataStream);
            string xmlFromServer = sReader.ReadToEnd();
            sReader.Close();
            dataStream.Close();
            hResponse.Close();

            DataSet dsMapData = new DataSet();
            try
            {
                dsMapData.ReadXml(new StringReader(xmlFromServer), XmlReadMode.Auto);
            }
            catch
            {
                sErrorText = "Невозможно преобразовать ответ сервера геокодирования!"; return false;
            }

            // Получаем количество результатов
            int resCount = 0;
            try { resCount = dsMapData.Tables["location"].Rows.Count; }
            catch { sErrorText = "Невозможно получить координаты партнера!"; return false; }

            if (resCount == 0)
            {
                sErrorText = "Неудачная попытка геокодирования!";
                return false;
            }

            Latitude = Convert.ToDouble(dsMapData.Tables["location"].Rows[0]["lat"]);
            Longitude = Convert.ToDouble(dsMapData.Tables["location"].Rows[0]["lng"]);
            return true;
        }

        /// <summary>
        /// Calc route with Google maps static API
        /// </summary>
        /// <param name="Origin"></param>
        /// <param name="Destination"></param>
        /// <param name="WayPointsList"></param>
        /// <param name="nDistance"></param>
        /// <param name="sDistance"></param>
        /// <param name="nDuration"></param>
        /// <param name="sDuration"></param>
        /// <param name="PolylinePoints"></param>
        /// <param name="sErrorText"></param>
        /// <returns></returns>
        public static bool CalcRoute(Location Origin, Location Destination, List<Location> WayPointsList,
            out int nDistance, out string sDistance,
            out int nDuration, out string sDuration,
            out List<Location> PolylinePoints,
            out string sErrorText)
        {
            // Описание сервиса: https://developers.google.com/maps/documentation/directions/

            // Проверка параметров
            if (Origin == null)
                throw new ArgumentException("GoogleService.CalcRoute: wrong parameter LocOrigin");
            if (Destination == null)
                throw new ArgumentException("GoogleService.CalcRoute: wrong parameter LocDestination");

            // Определение значений по умолчанию для возвратных переменных
            nDistance = nDuration = 0;
            sDistance = sDuration = sErrorText = "";
            PolylinePoints = new List<Location>();

            List<FullRoute> frList = DivideRouteOnPathes(Origin, Destination, WayPointsList);

            foreach (FullRoute fr in frList)
            {

                // Определение временных переменных
                string sOrigin, sDestination, sWayPoints = "";
                sOrigin = fr.Origin.ToString();
                sDestination = fr.Destination.ToString();

                if (fr.WayPointsList != null && fr.WayPointsList.Count > 0)
                {
                    sWayPoints = "";
                    foreach (Location loc in fr.WayPointsList)
                    {
                        sWayPoints += loc.ToString() + "|";
                    }
                    sWayPoints = sWayPoints.Substring(0, sWayPoints.Length - 1);
                }

                // Создание полного текста запроса к статическому API Google
                // Для объезда точек применяем оптимизацию (первый параметр для путевых точек - optimize:true)
                string requestUri = String.Format("https://maps.googleapis.com/maps/api/directions/xml" +
                    "?origin={1}&destination={2}{3}&key={0}&region=ru&hl=ru&units=metric&alternatives=false&sensor=false",
                    googleApiKey, sOrigin, sDestination, sWayPoints.Length > 0 ? "&waypoints=optimize:true|" + sWayPoints : "");

                // Request Google API
                HttpWebRequest hRequest;
                try
                {
                    hRequest = (HttpWebRequest)WebRequest.Create(requestUri);
                }
                catch (Exception e)
                {
                    sErrorText = "Что-то не так с запросом маршрута: " + e.Message;
                    return false;
                }

                HttpWebResponse hResponse;
                try
                {
                    hResponse = (HttpWebResponse)hRequest.GetResponse();
                }
                catch (Exception e)
                {
                    sErrorText = "Что-то не так с ответом сервера: " + e.Message;
                    return false;
                }

                if (hResponse.StatusCode != HttpStatusCode.OK)
                {
                    sErrorText = "Сервер геокодирования не отвечает!";
                    hResponse.Close();
                    return false;
                }

                Stream dataStream = hResponse.GetResponseStream();
                StreamReader sReader = new StreamReader(dataStream);
                string xmlFromServer = sReader.ReadToEnd();
                sReader.Close();
                dataStream.Close();
                hResponse.Close();

                // Create DataSet from HttpWebResponse
                DataSet dsMapData = new DataSet();
                string sStatus = "";
                try
                {
                    dsMapData.ReadXml(new StringReader(xmlFromServer), XmlReadMode.Auto);
                    sStatus = dsMapData.Tables["DirectionsResponse"].Rows[0]["status"].ToString();
                }
                catch { sErrorText = "Невозможно преобразовать ответ сервера геокодирования!"; return false; }

                // Check status
                if (sStatus != "OK")
                {
                    sErrorText = "Ошибка при расчете маршрута: " + sStatus;
                    return false;
                }

                // Get steps quantity
                // Rows quantity in tables duration & distance = stepCount + 1!!!
                int stepCount = 0;
                try { stepCount = dsMapData.Tables["step"].Rows.Count; }
                catch { sErrorText = "Неудачная попытка построения маршрута!"; return false; }

                // Get distance & duration (field <leg_id> is not empty)
                foreach (DataRow r in dsMapData.Tables["duration"].Rows)
                    if (r["leg_id"].ToString().Length > 0) nDuration += Convert.ToInt32(r["value"]);
                foreach (DataRow r in dsMapData.Tables["distance"].Rows)
                    if (r["leg_id"].ToString().Length > 0) nDistance += Convert.ToInt32(r["value"]);

                // Получение списка точек для объекта polyline
                List<Location> line = DecodePolylinePoints(dsMapData.Tables["overview_polyline"].Rows[0]["points"].ToString());
                foreach (Location l in line)
                    PolylinePoints.Add(l);
            }

            // Get string distance & duration
            sDistance = GetStringDistance(nDistance);
            sDuration = GetStringDuration(nDuration);

            return true;
        }

        /// <summary>
        /// Divide route on pathes with 8 or less waypoints (Google restriction)
        /// </summary>
        /// <param name="Origin"></param>
        /// <param name="Destination"></param>
        /// <param name="WayPointsList">List should be sorted on some criteria (distance, coordinates, etc.)</param>
        /// <returns></returns>
        private static List<FullRoute> DivideRouteOnPathes(Location Origin, Location Destination, List<Location> WayPointsList)
        {
            List<FullRoute> frList = new List<FullRoute>();

            // If waypoints count is 8 or less return original parameters
            int wpCount = WayPointsList.Count;
            if (wpCount <= 8)
            {
                FullRoute fr = new FullRoute();
                fr.Origin = Origin;
                fr.Destination = Destination;
                fr.WayPointsList = WayPointsList;
                frList.Add(fr);
            }
            else
            {
                // Count pathes quantity
                int pathesCount = wpCount / 9 + 1;

                // Add origin & destination to waypoints list
                WayPointsList.Insert(0, Origin);
                WayPointsList.Add(Destination);
                wpCount += 2;

                // Loop on waypoints
                for (int i = 0; i < pathesCount; i++)
                {
                    FullRoute fr = new FullRoute();
                    fr.Origin = WayPointsList[i * 9];

                    fr.Destination = WayPointsList[Math.Min(i * 9 + 9, wpCount - 1)];
                    
                    fr.WayPointsList = new List<Location>();
                    for (int j = 1; j <= 8; j++)
                    {
                        int nIndex = Math.Min(i * 9 + j, wpCount - 2);
                        fr.WayPointsList.Add(WayPointsList[nIndex]);
                        if (nIndex == wpCount - 2)
                            break;
                    }

                    frList.Add(fr);
                }
            }

            return frList;
        }

        /// <summary>
        /// Decode Google <points> polyline
        /// Source: http://www.codeproject.com/Tips/312248/Google-Maps-Direction-API-V3-Polyline-Decoder
        /// </summary>
        /// <param name="encodedPoints"></param>
        /// <returns>Location list</returns>
        private static List<Location> DecodePolylinePoints(string encodedPoints)
        {
            if (encodedPoints == null || encodedPoints == "") return null;
            List<Location> poly = new List<Location>();
            char[] polylinechars = encodedPoints.ToCharArray();
            int index = 0;

            int currentLat = 0;
            int currentLng = 0;
            int next5bits;
            int sum;
            int shifter;

            try
            {
                while (index < polylinechars.Length)
                {
                    // calculate next latitude
                    sum = 0;
                    shifter = 0;
                    do
                    {
                        next5bits = (int)polylinechars[index++] - 63;
                        sum |= (next5bits & 31) << shifter;
                        shifter += 5;
                    } while (next5bits >= 32 && index < polylinechars.Length);

                    if (index >= polylinechars.Length)
                        break;

                    currentLat += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);

                    //calculate next longitude
                    sum = 0;
                    shifter = 0;
                    do
                    {
                        next5bits = (int)polylinechars[index++] - 63;
                        sum |= (next5bits & 31) << shifter;
                        shifter += 5;
                    } while (next5bits >= 32 && index < polylinechars.Length);

                    if (index >= polylinechars.Length && next5bits >= 32)
                        break;

                    currentLng += (sum & 1) == 1 ? ~(sum >> 1) : (sum >> 1);
                    Location p = new Location();
                    p.Latitude = Convert.ToDouble(currentLat) / 100000.0;
                    p.Longitude = Convert.ToDouble(currentLng) / 100000.0;
                    poly.Add(p);
                }
            }
            catch
            {
                // logo it
            }
            return poly;
        }
        
        /// <summary>
        /// Get distance in human format (X km Y m)
        /// </summary>
        /// <param name="Distance">Distance in metres</param>
        /// <returns></returns>
        private static string GetStringDistance(int Distance)
        {
            if (Distance <= 0)
                return "";

            string sDistance = "";

            if (Distance > 1000)
            {
                sDistance += (Distance / 1000).ToString() + " км ";
            }
            sDistance += (Distance % 1000) + " м";

            return sDistance;
        }

        /// <summary>
        /// Get duration in human format (X days Y hours Z minutes)
        /// </summary>
        /// <param name="Duration">Duration on seconds</param>
        /// <returns></returns>
        private static string GetStringDuration(int Duration)
        {
            if (Duration <= 0)
                return "";

            string sDuration = "";

            if (Duration > 86400)      // days
            {
                int nDays = Duration / 86400;
                sDuration += nDays.ToString() + " дн. ";
                Duration -= nDays * 86400;
            }
            if (Duration > 3600)       // hours
            {
                int nHours = Duration / 3600;
                sDuration += nHours.ToString() + " ч. ";
                Duration -= nHours * 3600;
            }
            if (Duration > 60)         // minutes
            {
                int nMinutes = Duration / 60;
                sDuration += nMinutes.ToString() + " мин.";
            }

            return sDuration;
        }
    }

    public class FullRoute
    {
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public List<Location> WayPointsList { get; set; }
    }
}
