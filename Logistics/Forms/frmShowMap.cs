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
        #region ���������
        const string TAB = "\t";
        const string CRLF = "\r\n";
        #endregion

        #region �������
        private DataTable tPartnersTable = null;
        private Partner oPartner = null;
        #endregion

        #region ���������� ����������
        private string sMode = "";

        // ����� ������
        private double nMapCenterLatitude = 55.76, nMapCenterLongitude = 37.64;

        // ���������� ���� � ����������
        private double nBaseLat = 55.555, nBaseLng = 38.111;

        private bool isTripNumberExists, isCarNameExists, isOneRoute;

        // ����������� �����
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
        /// ����������� ��� ����������� ��������
        /// </summary>
        /// <param name="PartnersTable">������� � ������� ��������</param>
        public frmShowMap(DataTable PartnersTable, bool IsOneRoute)
        {
            #region �������� ���������
            tPartnersTable = PartnersTable;
            isOneRoute = IsOneRoute;
            #endregion

            #region �������� �������� �������
            if (IsValid)
            {
                if (tPartnersTable == null || tPartnersTable.Rows.Count == 0 || tPartnersTable.Columns.Count == 0)
                {
                    RFMMessage.MessageBoxError("�������� ������ �������!");
                    IsValid = false;
                }
            }
            if (IsValid)
            {
                if (tPartnersTable.Rows.Count > 1000)
                {
                    RFMMessage.MessageBoxError("������� ����� �����!");
                    IsValid = false;
                }
            }
            #endregion

            #region �������� ������� ����������� �����
            // �������� ������� ������ ��������� ��� ������� ��������� ����:
            // Name - �������� ��������
            // DeliveryAddress - ����� ��������
            // Latitude - �������������� ������
            // Longitude - �������������� �������
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
                    RFMMessage.MessageBoxError("���������� ������� ����� ������������ ���������!");
                    IsValid = false;
                }
            }
            sMode = "T";
            #endregion

            #region �������� ������� �������������� �����
            if (IsValid)
            {
                // � �����
                try
                {
                    string testValue;
                    testValue = tPartnersTable.Rows[0]["TripID"].ToString();
                    isTripNumberExists = true;
                }
                catch { isTripNumberExists = false; }

                // �������� ������
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
        /// ����������� ��� ����������� ��������
        /// </summary>
        /// <param name="Partner">������-������ "�������"</param>
        public frmShowMap(Partner Partner)
        {
            #region �������� ��������
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
            #region �������� ������ ������
            if (sMode != "T" && sMode!= "P")
            {
                Close();
                return;
            }
            #endregion

            #region ��������� ��������� "���������� ������ �����" � "���������� ����"
            Logistics.Properties.Settings set = new Logistics.Properties.Settings();

            #region ��������� ������ �����
            try 
            {
                nMapCenterLatitude = Convert.ToDouble(set.MapCenterLatitude);
                nMapCenterLongitude = Convert.ToDouble(set.MapCenterLongitude);
                wfpRadMapControl.SetMapCenter(nMapCenterLatitude, nMapCenterLongitude);
            }
            catch (Exception ex)
            {
                RFMMessage.MessageBoxError("���������� ������ ����� ������� �������!\r\n" + ex.Message);
                return;
            }
            #endregion

            #region ��������� ��������� ����
            try 
            { 
                nBaseLat = Convert.ToDouble(set.MapBaseLatitude);
                nBaseLng = Convert.ToDouble(set.MapBaseLongitude);
                wfpRadMapControl.SetBaseLocation(nBaseLat, nBaseLng);
            }
            catch (Exception ex)
            {
                RFMMessage.MessageBoxError("���������� ���� ������� �������!\r\n" + ex.Message);
                return;
            }
            #endregion

            #endregion

            #region ����� "�������"
            if (sMode == "T")
            {
                if (!ShowTrip())
                {
                    Close();
                    return;
                }
            }
            #endregion

            #region ����� "�������"
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
            // ������� ������ � ����������� �������� � ��������� �� ����
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

            #region ���������� ��� ���������� ������������ ��������
            int pointsCount = 0, tripsCount = 0, wrongPartners = 0;
            double nLongitude, nLatitude;
            string sName, sDeliveryAddress, sLongitude, sLatitude;
            string sWrongPartners = "";
            string sTripID = "*", sCurTripID = "", sCarName = "";
            #endregion

            #region ������������ ������ � ������������
            foreach (DataRow row in tPartnersTable.Rows)
            {
                // ��������� ������ ��������
                if (isTripNumberExists)
                {
                    sCurTripID = row["TripID"].ToString();
                    if (sTripID == "*") // ��������� ������ �����
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

                #region ��������� �������������� ���������
                sLongitude = row["Longitude"].ToString();
                sLatitude = row["Latitude"].ToString();
                #endregion

                #region ��������� �������� � ������ ��������
                // �������� �������� (� ������������� �������� " � ')
                sName = row["Name"].ToString();
                sName = sName.Replace("\"", "").Replace("'", "");

                // ����� �������� (� ������� ������� " �� ')
                sDeliveryAddress = row["DeliveryAddress"].ToString();
                sDeliveryAddress = sDeliveryAddress.Replace("\"", "").Replace("'", "");
                #endregion

                if (sLongitude.Length > 0 && sLatitude.Length > 0)
                {
                    #region ���������� ��������� ��������
                    try
                    {
                        nLongitude = Convert.ToDouble(sLongitude);
                        nLatitude = Convert.ToDouble(sLatitude);
                    }
                    catch { continue;  }
                    #endregion

                    pointsCount++;

                    #region ���������� ��������
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

            #region �������� ������� �����
            if (pointsCount == 0)
            {
                RFMMessage.MessageBoxError("��� ������ � ����������� ���������!");
                return false;
            }

            // ����������� ����� � ����������
            if (sWrongPartners.Length > 0)
            {
                sWrongPartners = "��������� " + wrongPartners.ToString() + " �������(��) �� ����� ���������:\r\n" + sWrongPartners;
                RFMMessage.MessageBoxInfo(sWrongPartners);
            }
            #endregion

            wfpRadMapControl.SetBestView();

            return true;
        }

        private bool ShowPartner()
        {
            wfpRadMapControl.Mode = "P";
            
            #region ��������� �������� � ������ ��������
            string sPartnerName = "", sPartnerAddress = "";

            // �������� �������� (� ������������� �������� " � ')
            sPartnerName = oPartner.Name;
            sPartnerName = sPartnerName.Replace("\"", "").Replace("'", "");

            // ����� �������� (� ������������� �������� " � ')
            sPartnerAddress = (oPartner.DeliveryAddress.Length != 0 ? oPartner.DeliveryAddress : oPartner.DeliveryPassage);
            sPartnerAddress = sPartnerAddress.Replace("\"", "'").Replace("'", "");
            #endregion

            // ���������� ��������
            wfpRadMapControl.CreateDruggablePartner(
                oPartner.Latitude, oPartner.Longitude, 
                sPartnerAddress, 
                sPartnerName + CRLF + sPartnerAddress);

            return true;
        }
    }
}

