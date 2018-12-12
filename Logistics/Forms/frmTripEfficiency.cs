using LogBizObjects;
using RFMPublic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Telerik.Windows.Controls.Map;
using WpfControlLibrary;

namespace Logistics
{
    public partial class frmTripEfficiency : RFMBaseClasses.RFMFormChild
    {
        DataTable tableEfficiency = new DataTable();
        Trip oTrip = new Trip();

        public frmTripEfficiency(DataTable TableEfficiency)
        {
            InitializeComponent();

            tableEfficiency = TableEfficiency;
        }

        private void frmTripEfficiency_Load(object sender, EventArgs e)
        {
            RFMCursorWait.Set(false);

            grcExpences.AgrType = grcCleanMarkup.AgrType = RFMBaseClasses.EnumAgregate.Sum;
            dgvMain.IsStatusShow = true;
            
            dgvMain.Restore(tableEfficiency);
        }

        private void dgvMain_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMain.DataSource == null)
                return;

            DataRow r = ((DataRowView)((DataGridViewRow)dgvMain.Rows[e.RowIndex]).DataBoundItem).Row;
            DataGridViewColumn c = dgvMain.Columns[e.ColumnIndex];
            
            switch (c.Name)
            {
                case "grcOutIn":
                    if (r["OutIn"].ToString() == "$")
                        e.Value = Properties.Resources.Car_Red;
                    else if (r["OutIn"].ToString() == "I")
                        e.Value = Properties.Resources.Plus;
                    else
                        e.Value = Properties.Resources.Minus;
                    break;
                case "grcCleanMarkup":
                    if (Convert.ToDecimal(r["CleanMarkup"].ToString()) < 0)
                        e.CellStyle.ForeColor = Color.Red;
                    else
                        e.CellStyle.ForeColor = Color.Black;
                    break;

            }

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Расчет эффективности
            double nTripCost = (double)numTripCost.Value;
            if (nTripCost == 0)
            {
                RFMMessage.MessageBoxAttention("Не задана стоимость рейса!");
                return;
            }

            double nNormWarehouse = (double)numNormWarehouse.Value;
            double nNetto, nAmount, nMarkup, nTransportCost, nWarehouseCost, nCleanMarkup;
            double nExpencesSum = 0, nCleanMarkupSum = 0;
            foreach (DataRow r in tableEfficiency.Rows)
            {
                // Замена данных в статусной строке
                if (r["PartnerID"].ToString().Length == 0)
                {
                    r["Expences"] = nExpencesSum;
                    r["CleanMarkup"] = nCleanMarkupSum;

                    continue;
                }

                nNetto = Convert.ToDouble(r["Netto"]);
                nAmount = Convert.ToDouble(r["Amount"]);
                nMarkup = Convert.ToDouble(r["Markup"]);
                nTransportCost = nNetto * Convert.ToDouble(r["Kt"]) * nTripCost;
                nWarehouseCost = nNetto * nNormWarehouse;
                nCleanMarkup = (r["OutIn"].ToString() == "O" && nAmount != nMarkup ? nMarkup - (nTransportCost + nWarehouseCost) : 0);

                r["Expences"] = nTransportCost + nWarehouseCost;
                r["CleanMarkup"] = nCleanMarkup;
                r["CleanMarkupPrc"] = (nAmount > 0 ? nCleanMarkup / nAmount * 100 : 0);

                nExpencesSum += (r["OutIn"].ToString() == "O" && nAmount != nMarkup ? nTransportCost + nWarehouseCost : 0);
                nCleanMarkupSum += nCleanMarkup;
            }
        }

        /// <summary>
        /// Расчет длины маршрута
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcRoute_Click(object sender, EventArgs e)
        {
            // Установка координат базы
            Logistics.Properties.Settings set = new Logistics.Properties.Settings();

            double nBaseLat, nBaseLng;
            try
            {
                nBaseLat = Convert.ToDouble(set.MapBaseLatitude);
                nBaseLng = Convert.ToDouble(set.MapBaseLongitude);
            }
            catch (Exception ex)
            {
                RFMMessage.MessageBoxError("Координаты базы указаны неверно!\r\n" + ex.Message);
                return;
            }

            RFMCursorWait.Set(true);

            // Входящие параметры
            Location locOrigin, locDestination;
            locOrigin = locDestination = new Location();
            locOrigin.Latitude = locDestination.Latitude = nBaseLat;
            locOrigin.Longitude = locDestination.Longitude = nBaseLng;

            List<int> listPartners = new List<int>();
            List<Location> listWayPoints = new List<Location>();
            foreach(DataRow r in tableEfficiency.Rows)
            {
                // Пропуск статусной строки
                string sPartnerID = r["PartnerID"].ToString();
                if (sPartnerID.Length == 0)
                    continue;

                int nPartnerID = Convert.ToInt32(sPartnerID);
                string sLat = r["Latitude"].ToString(), sLng = r["Longitude"].ToString();
                if (listPartners.IndexOf(nPartnerID) < 0 && sLat.Length > 0 && sLng.Length > 0) 
                {
                    listPartners.Add(nPartnerID);

                    Location loc = new Location();
                    loc.Latitude = Convert.ToDouble(sLat);
                    loc.Longitude = Convert.ToDouble(sLng);
                    listWayPoints.Add(loc);
                }
            }

            // Исходящие параметры
            int nDistance = 0, nDuration = 0;
            string sDistance = "", sDuration = "", sErrorText = "";
            List<Location> polyline = new List<Location>();

            // Расчет маршрута
            bool bResult = GoogleService.CalcRoute(locOrigin, locDestination, listWayPoints,
                out nDistance, out sDistance,
                out nDuration, out sDuration,
                out polyline,
                out sErrorText);

            RFMCursorWait.Set(false);
            if (!bResult)
            {
                RFMMessage.MessageBoxError(sErrorText);
                return;
            }

            numDistance.Value = (decimal)nDistance / 1000;
            numTripCost.Value = numDistance.Value * numNormDistance.Value;
        }
    }
}
