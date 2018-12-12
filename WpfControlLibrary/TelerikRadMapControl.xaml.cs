using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.Map;

namespace WpfControlLibrary
{
    /// <summary>
    /// Логика взаимодействия для TelerikRadMapControl.xaml
    /// </summary>
    public partial class TelerikRadMapControl : UserControl
    {
        public string Mode { get; set; }

        DraggablePushpin partnerPushpin;
        public double? nPartnerLatutude = null, nPartnerLongitude = null;
        public int nPartnerDistance = 0;

        public TelerikRadMapControl()
        {
            InitializeComponent();

            this.Mode = "";
        }

        ~TelerikRadMapControl()
        {
            if (partnerPushpin != null)
                partnerPushpin.PushpinLocationChanged -= partnerPushpin_PushpinLocationChanged;
        }

        /// <summary>
        /// Set map center
        /// </summary>
        /// <param name="Latitude"></param>
        /// <param name="Longitude"></param>
        public void SetMapCenter(double Latitude, double Longitude)
        {
            if (Latitude > 90 || Latitude < -90)
                throw new ArgumentException("TelerikRadMapControl.SetMapCenter(): wrong parameter <Latitude>");

            if (Longitude > 180 || Longitude < -180)
                throw new ArgumentException("TelerikRadMapControl.SetMapCenter(): wrong parameter <Longitude>");

            this.map.Center = new Location(Latitude, Longitude);
        }

        /// <summary>
        /// Set map ZoomLevel
        /// </summary>
        /// <param name="Zoom"></param>
        public void SetZoomLevel(int Zoom)
        {
            if (Zoom < 1 || Zoom > 25)
                throw new ArgumentException("TelerikRadMapControl.SetZoomLevel(): wrong parameter <Zoom>");

            this.map.ZoomLevel = Zoom;
        }

        /// <summary>
        /// Set Base coordinates
        /// </summary>
        /// <param name="Latitude"></param>
        /// <param name="Longitude"></param>
        public void SetBaseLocation(double Latitude, double Longitude)
        {
            if (Latitude > 90 || Latitude < -90)
                throw new ArgumentException("TelerikRadMapControl.SetBaseLocation(): wrong parameter <Latitude>");

            if (Longitude > 180 || Longitude < -180)
                throw new ArgumentException("TelerikRadMapControl.SetBaseLocation(): wrong parameter <Longitude>");

            MapLayer.SetLocation(this.basePoint, new Location(Latitude, Longitude));
        }

        /// <summary>
        /// Set best map view (all points are visible)
        /// </summary>
        public void SetBestView()
        {
            LocationRect bestView = infoLayer.GetBestView(infoLayer.Items.Cast<object>());
            bestView.MapControl = map;      // без этого не устанавливаются центр карты и уровень масштабирования

            map.Center = bestView.Center;
            map.ZoomLevel = bestView.ZoomLevel;

            if (this.map.Visibility != System.Windows.Visibility.Visible) 
                this.map.Visibility = System.Windows.Visibility.Visible;
        }

        /// <summary>
        /// Create static partner pushpin
        /// </summary>
        /// <param name="Latitude"></param>
        /// <param name="Longitude"></param>
        /// <param name="ToolTip"></param>
        /// <param name="ColorBrush"></param>
        public void CreateStaticPartner(double Latitude, double Longitude, string ToolTip, Brush ColorBrush)
        {
            if (Latitude > 90 || Latitude < -90)
                throw new ArgumentException("CreateStaticPartner: Wrong parameter Latitude");
            if (Longitude > 180 || Longitude < -180)
                throw new ArgumentException("CreateStaticPartner: Wrong parameter Longitude");

            StaticPushpin pin = new StaticPushpin(this.map);
            pin.Location = new Location(Latitude, Longitude);
            pin.ToolTip = ToolTip;
            pin.Background = ColorBrush;
            pin.Tag = "StaticPushpin";

            this.infoLayer.Items.Add(pin);
        }

        /// <summary>
        /// Create druggable partner pushpin
        /// </summary>
        /// <param name="PartnerLatitude"></param>
        /// <param name="PartnerLongitude"></param>
        /// <param name="PartnerAddress"></param>
        /// <param name="PartnerToolTip"></param>
        public void CreateDruggablePartner(decimal? PartnerLatitude, decimal? PartnerLongitude, string PartnerAddress, string PartnerToolTip)
        {
            Brush background = new SolidColorBrush(Colors.Red);
            string sErrorText = "";

            // Проверка координат партнера
            if (PartnerLatitude.HasValue && PartnerLongitude.HasValue && 
                PartnerLongitude >= -180 && PartnerLongitude <= 180 && 
                PartnerLatitude >= -90 && PartnerLatitude <= 90)
            {
                nPartnerLatutude = (double)PartnerLatitude;
                nPartnerLongitude = (double)PartnerLongitude;
                background = new SolidColorBrush(Colors.DarkBlue);
            }
            // Поиск координат по адресу
            else if (GoogleService.GeocodeAddress(PartnerAddress, out nPartnerLatutude, out nPartnerLongitude, out sErrorText))
            {
                background = new SolidColorBrush(Colors.DarkGreen);
                tbInfo.Text = "Координаты партнера получены путем геокодирования (Google)";
            }
            else
            {
                // Не нашли адрес (или он пустой) - показываем клиента в центре карты
                tbInfo.Text = sErrorText;
                nPartnerLatutude = this.map.Center.Latitude;
                nPartnerLongitude = this.map.Center.Longitude;
            }

            // Формирование координат и отрисовка партнера
            Location partnerLoc = new Location((double)nPartnerLatutude, (double)nPartnerLongitude);
            partnerPushpin = new DraggablePushpin(this.map)
            {
                Location = partnerLoc,
                Background = background,
                ToolTip = PartnerToolTip,
                Tag = "DraggablePushpin"
            };
            this.infoLayer.Items.Add(partnerPushpin);

            // Переустановка центра карты
            this.SetMapCenter((double)nPartnerLatutude, (double)nPartnerLongitude);
            this.SetZoomLevel(14);

            if (this.map.Visibility != System.Windows.Visibility.Visible) 
                this.map.Visibility = System.Windows.Visibility.Visible;

            // Установка обработчика перемещений
            partnerPushpin.PushpinLocationChanged += partnerPushpin_PushpinLocationChanged;
        }

        /// <summary>
        /// EventHandler DraggablePushpin.PushpinLocationChanged
        /// </summary>
        /// <returns></returns>
        void partnerPushpin_PushpinLocationChanged(object sender, EventArgs e)
        {
            if (partnerPushpin.Location != null)
            {
                nPartnerLatutude = partnerPushpin.Location.Latitude;
                nPartnerLongitude = partnerPushpin.Location.Longitude;
            }
        }

        /// <summary>
        /// Check - is partner exists
        /// </summary>
        /// <returns></returns>
        public bool IsPartnerExists()
        {
            return (this.Mode == "P" && partnerPushpin != null && nPartnerLatutude.HasValue && nPartnerLongitude.HasValue);
        }

        /// <summary>
        /// Get partner coordinates and distance (Partner Mode)
        /// </summary>
        /// <param name="PartnerLatutude"></param>
        /// <param name="PartnerLongitude"></param>
        /// <param name="PartnerDistance"></param>
        public void GetPartnerCoordinatesAndDistance(out double PartnerLatutude, out double PartnerLongitude, out int PartnerDistance)
        {
            PartnerLatutude = (double)nPartnerLatutude;
            PartnerLongitude = (double)nPartnerLongitude;
            PartnerDistance = nPartnerDistance;
        }

        /// <summary>
        /// Get route (Trip Mode) or partner distance (Partner Mode)
        /// </summary>
        private void CalcRoute()
        {
            // Clear all routes
            ClearRoutes();

            if (this.Mode != "T" && this.Mode != "P")
                return;

            /*
            if (this.Mode == "T" && infoLayer.Items.Count > 20)
            {
                tbInfo.Text = "Слишком большое количество точек! Построение маршрута невозможно!";
                return;
            }
            */

            // Create input parameters
            Location locOrigin = MapLayer.GetLocation(basePoint), locDestination;
            List<Location> listWayPoints = new List<Location>();

            // Create output parameters
            int nDuration = 0, nDistance = 0;
            string sDuration = "", sDistance = "", sErrorText = "";
            List<Location> polyline;

            // Set destination
            if (this.Mode == "T")
            {
                locDestination = locOrigin;
                foreach(Control ctrl in infoLayer.Items)
                {
                    if (ctrl.Tag.ToString() == "StaticPushpin")
                        listWayPoints.Add(((StaticPushpin)ctrl).Location);
                }
            }
            else
            {
                locDestination = partnerPushpin.Location;
            }

            // Calc Google route
            bool bResult = GoogleService.CalcRoute(locOrigin, locDestination, listWayPoints,
                out nDistance, out sDistance,
                out nDuration, out sDuration,
                out polyline,
                out sErrorText);
            if (!bResult)
            {
                tbInfo.Text = sErrorText;
                return;
            }

            tbInfo.Text = "Пробег: " + sDistance + ", время в пути: " + sDuration;

            // Set distance to partner
            if (this.Mode == "P")
                nPartnerDistance = (int)Math.Round((decimal)nDistance / (decimal)1000);

            // Draw polyline
            if (polyline.Count > 0)
            {
                MapPolyline pl = new MapPolyline();
                pl.Points = new LocationCollection();
                pl.Stroke = new SolidColorBrush(Colors.Magenta);
                //pl.Stroke = new LinearGradientBrush(Colors.DarkBlue, Colors.LightBlue, 0);    Линейный градиент не подходит
                pl.StrokeThickness = 3;
                pl.Visibility = System.Windows.Visibility.Visible;
                pl.Tag = "Route";

                foreach (Location loc in polyline) 
                    pl.Points.Add(loc);

                infoLayer.Items.Add(pl);
            }

            this.SetBestView();
        }

        /// <summary>
        /// Clear all routes (polyline)
        /// </summary>
        private void ClearRoutes()
        {
            //foreach(Control ctrl in infoLayer.Items)      Runtime Error!!!
            for (int i = infoLayer.Items.Count - 1; i >= 0; i--)
            {
                Control ctrl = infoLayer.Items[i] as Control;
                if (ctrl != null && ctrl.Tag.ToString() == "Route")
                    infoLayer.Items.Remove(ctrl);
            }
        }

        private void btnCalcRoute_Click(object sender, RoutedEventArgs e)
        {
            CalcRoute();
        }
    }

    /// <summary>
    /// Class StaticPushpin
    /// </summary>
    public class StaticPushpin : Pushpin
    {
        // RadMap object reference
        internal RadMap map;

        // Location
        private Location location;
        public Location Location
        {
            get { return location; }
            set
            {
                if (value != null)
                {
                    location = value;
                    if (map != null) MapLayer.SetLocation(this, location);
                }
            }
        }

        public StaticPushpin()
        {
            throw new Exception("StaticPushpin: abstract constructor is executed!");
        }

        public StaticPushpin(RadMap Map)
        {
            if (Map == null) throw new ArgumentException("StaticPushpin: Wrong parameter Map");

            map = Map;
        }
    }

    /// <summary>
    /// Class DraggablePushpin
    /// </summary>
    public class DraggablePushpin : StaticPushpin
    {
        private FrameworkElement draggedElement;

        public DraggablePushpin(RadMap Map) : base(Map)
        {
            // Add event handlers
            this.MouseLeftButtonDown += DraggablePushpin_MouseLeftButtonDown;
            this.MouseLeftButtonUp += DraggablePushpin_MouseLeftButtonUp;
        }

        public event EventHandler PushpinLocationChanged;
        protected void OnPushpinLocationChanged()
        {
            EventHandler handler = PushpinLocationChanged;
            if (handler != null)
                handler(this, new EventArgs());
        }

        void DraggablePushpin_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            if (element != null && element == this)
            {
                // Left Mouse Button pushed, start dragging the Pushpin
                this.draggedElement = element;
                this.draggedElement.CaptureMouse();
                this.MouseMove += DraggablePushpin_MouseMove;

                e.Handled = true;
            }
        }

        void DraggablePushpin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (this.draggedElement != null)
            {
                // Left Mouse Button released, stop dragging the Pushpin
                this.MouseMove -= DraggablePushpin_MouseMove;
                this.draggedElement.ReleaseMouseCapture();
                this.draggedElement = null;
            }
        }

        void DraggablePushpin_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (this.draggedElement != null)
            {
                this.Location = Location.GetCoordinates(this.map, e.GetPosition(this.map));
                MapLayer.SetLocation(this.draggedElement, this.Location);
                OnPushpinLocationChanged();
            }
        }
    }
}
