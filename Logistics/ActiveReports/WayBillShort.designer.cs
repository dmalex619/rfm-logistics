namespace Logistics
{	partial class WayBillShort 
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}

		// declare bands
		private DataDynamics.ActiveReports.PageHeader PageHeader;
		private DataDynamics.ActiveReports.Detail Detail;
		private DataDynamics.ActiveReports.PageFooter PageFooter;

        // declare elements
		private DataDynamics.ActiveReports.Label lblPageHeader02;
		private DataDynamics.ActiveReports.Label tbWeName;
		private DataDynamics.ActiveReports.Label lblDetail01;
    private DataDynamics.ActiveReports.Label lblDetail02;
    private DataDynamics.ActiveReports.Label lblDetail04;
		private DataDynamics.ActiveReports.Label lblDetail06;
		private DataDynamics.ActiveReports.Label lblDetail07;
    private DataDynamics.ActiveReports.Label lblDetail08;
    private DataDynamics.ActiveReports.Line linDetail04;
		private DataDynamics.ActiveReports.TextBox tbBillNumber;
		private DataDynamics.ActiveReports.TextBox tbDate;
		private DataDynamics.ActiveReports.TextBox tbCarModel;
    private DataDynamics.ActiveReports.TextBox tbCarNumber;
		private DataDynamics.ActiveReports.TextBox tbDriverName;
    private DataDynamics.ActiveReports.TextBox txtDetail07;

		// init report components
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(WayBillShort));
            this.PageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.lblDetail01 = new DataDynamics.ActiveReports.Label();
            this.tbBillNumber = new DataDynamics.ActiveReports.TextBox();
            this.tbDate = new DataDynamics.ActiveReports.TextBox();
            this.lblPageHeader02 = new DataDynamics.ActiveReports.Label();
            this.tbWeName = new DataDynamics.ActiveReports.Label();
            this.tbWeAddress = new DataDynamics.ActiveReports.Label();
            this.label40 = new DataDynamics.ActiveReports.Label();
            this.label42 = new DataDynamics.ActiveReports.Label();
            this.label59 = new DataDynamics.ActiveReports.Label();
            this.tbWePhone = new DataDynamics.ActiveReports.Label();
            this.Detail = new DataDynamics.ActiveReports.Detail();
            this.label57 = new DataDynamics.ActiveReports.Label();
            this.label47 = new DataDynamics.ActiveReports.Label();
            this.label46 = new DataDynamics.ActiveReports.Label();
            this.shape1 = new DataDynamics.ActiveReports.Shape();
            this.lblDetail02 = new DataDynamics.ActiveReports.Label();
            this.lblDetail04 = new DataDynamics.ActiveReports.Label();
            this.lblDetail06 = new DataDynamics.ActiveReports.Label();
            this.lblDetail07 = new DataDynamics.ActiveReports.Label();
            this.lblDetail08 = new DataDynamics.ActiveReports.Label();
            this.linDetail04 = new DataDynamics.ActiveReports.Line();
            this.tbCarModel = new DataDynamics.ActiveReports.TextBox();
            this.tbCarNumber = new DataDynamics.ActiveReports.TextBox();
            this.tbDriverName = new DataDynamics.ActiveReports.TextBox();
            this.txtDetail07 = new DataDynamics.ActiveReports.TextBox();
            this.tbSpeedometerDataBeg = new DataDynamics.ActiveReports.TextBox();
            this.tbFuelDataBeg = new DataDynamics.ActiveReports.TextBox();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.tbDriverLicenceNumber = new DataDynamics.ActiveReports.TextBox();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.line2 = new DataDynamics.ActiveReports.Line();
            this.line3 = new DataDynamics.ActiveReports.Line();
            this.line4 = new DataDynamics.ActiveReports.Line();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.line5 = new DataDynamics.ActiveReports.Line();
            this.line7 = new DataDynamics.ActiveReports.Line();
            this.line9 = new DataDynamics.ActiveReports.Line();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.line10 = new DataDynamics.ActiveReports.Line();
            this.line11 = new DataDynamics.ActiveReports.Line();
            this.label11 = new DataDynamics.ActiveReports.Label();
            this.label12 = new DataDynamics.ActiveReports.Label();
            this.label13 = new DataDynamics.ActiveReports.Label();
            this.tbFuelTypeName = new DataDynamics.ActiveReports.TextBox();
            this.label14 = new DataDynamics.ActiveReports.Label();
            this.label15 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.label16 = new DataDynamics.ActiveReports.Label();
            this.label17 = new DataDynamics.ActiveReports.Label();
            this.tbAddressForStart = new DataDynamics.ActiveReports.TextBox();
            this.tbReason = new DataDynamics.ActiveReports.TextBox();
            this.line12 = new DataDynamics.ActiveReports.Line();
            this.shape2 = new DataDynamics.ActiveReports.Shape();
            this.line13 = new DataDynamics.ActiveReports.Line();
            this.line14 = new DataDynamics.ActiveReports.Line();
            this.line15 = new DataDynamics.ActiveReports.Line();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label18 = new DataDynamics.ActiveReports.Label();
            this.label19 = new DataDynamics.ActiveReports.Label();
            this.line16 = new DataDynamics.ActiveReports.Line();
            this.line18 = new DataDynamics.ActiveReports.Line();
            this.line19 = new DataDynamics.ActiveReports.Line();
            this.line20 = new DataDynamics.ActiveReports.Line();
            this.label22 = new DataDynamics.ActiveReports.Label();
            this.label23 = new DataDynamics.ActiveReports.Label();
            this.label24 = new DataDynamics.ActiveReports.Label();
            this.line21 = new DataDynamics.ActiveReports.Line();
            this.line22 = new DataDynamics.ActiveReports.Line();
            this.label25 = new DataDynamics.ActiveReports.Label();
            this.label26 = new DataDynamics.ActiveReports.Label();
            this.label27 = new DataDynamics.ActiveReports.Label();
            this.line23 = new DataDynamics.ActiveReports.Line();
            this.label29 = new DataDynamics.ActiveReports.Label();
            this.label30 = new DataDynamics.ActiveReports.Label();
            this.label31 = new DataDynamics.ActiveReports.Label();
            this.label32 = new DataDynamics.ActiveReports.Label();
            this.line26 = new DataDynamics.ActiveReports.Line();
            this.label33 = new DataDynamics.ActiveReports.Label();
            this.line27 = new DataDynamics.ActiveReports.Line();
            this.label34 = new DataDynamics.ActiveReports.Label();
            this.label35 = new DataDynamics.ActiveReports.Label();
            this.label36 = new DataDynamics.ActiveReports.Label();
            this.label37 = new DataDynamics.ActiveReports.Label();
            this.label38 = new DataDynamics.ActiveReports.Label();
            this.line30 = new DataDynamics.ActiveReports.Line();
            this.label39 = new DataDynamics.ActiveReports.Label();
            this.line33 = new DataDynamics.ActiveReports.Line();
            this.label44 = new DataDynamics.ActiveReports.Label();
            this.label45 = new DataDynamics.ActiveReports.Label();
            this.line35 = new DataDynamics.ActiveReports.Line();
            this.line31 = new DataDynamics.ActiveReports.Line();
            this.label48 = new DataDynamics.ActiveReports.Label();
            this.line25 = new DataDynamics.ActiveReports.Line();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.label20 = new DataDynamics.ActiveReports.Label();
            this.line6 = new DataDynamics.ActiveReports.Line();
            this.label21 = new DataDynamics.ActiveReports.Label();
            this.line17 = new DataDynamics.ActiveReports.Line();
            this.label49 = new DataDynamics.ActiveReports.Label();
            this.label50 = new DataDynamics.ActiveReports.Label();
            this.label51 = new DataDynamics.ActiveReports.Label();
            this.label43 = new DataDynamics.ActiveReports.Label();
            this.line32 = new DataDynamics.ActiveReports.Line();
            this.label52 = new DataDynamics.ActiveReports.Label();
            this.line36 = new DataDynamics.ActiveReports.Line();
            this.label28 = new DataDynamics.ActiveReports.Label();
            this.line24 = new DataDynamics.ActiveReports.Line();
            this.label53 = new DataDynamics.ActiveReports.Label();
            this.line37 = new DataDynamics.ActiveReports.Line();
            this.label54 = new DataDynamics.ActiveReports.Label();
            this.line38 = new DataDynamics.ActiveReports.Line();
            this.label55 = new DataDynamics.ActiveReports.Label();
            this.line28 = new DataDynamics.ActiveReports.Line();
            this.label56 = new DataDynamics.ActiveReports.Label();
            this.line29 = new DataDynamics.ActiveReports.Line();
            this.line39 = new DataDynamics.ActiveReports.Line();
            this.label58 = new DataDynamics.ActiveReports.Label();
            this.line40 = new DataDynamics.ActiveReports.Line();
            this.line41 = new DataDynamics.ActiveReports.Line();
            this.line42 = new DataDynamics.ActiveReports.Line();
            this.line43 = new DataDynamics.ActiveReports.Line();
            this.PageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.line8 = new DataDynamics.ActiveReports.Line();
            this.label41 = new DataDynamics.ActiveReports.Label();
            this.line44 = new DataDynamics.ActiveReports.Line();
            this.label60 = new DataDynamics.ActiveReports.Label();
            this.line45 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWePhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail06)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCarModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCarNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDriverName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedometerDataBeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuelDataBeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDriverLicenceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuelTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddressForStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblDetail01,
            this.tbBillNumber,
            this.tbDate,
            this.lblPageHeader02,
            this.tbWeName,
            this.tbWeAddress,
            this.label40,
            this.label42,
            this.label59,
            this.tbWePhone});
            this.PageHeader.Height = 1.102362F;
            this.PageHeader.Name = "PageHeader";
            // 
            // lblDetail01
            // 
            this.lblDetail01.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDetail01.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail01.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDetail01.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail01.Border.RightColor = System.Drawing.Color.Black;
            this.lblDetail01.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail01.Border.TopColor = System.Drawing.Color.Black;
            this.lblDetail01.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail01.Height = 0.2362205F;
            this.lblDetail01.HyperLink = null;
            this.lblDetail01.Left = 1.692913F;
            this.lblDetail01.MultiLine = false;
            this.lblDetail01.Name = "lblDetail01";
            this.lblDetail01.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "12pt; font-family: Tahoma; white-space: nowrap; ";
            this.lblDetail01.Text = "ПУТЕВОЙ ЛИСТ АВТОМОБИЛЯ №";
            this.lblDetail01.Top = 0.03937008F;
            this.lblDetail01.Width = 2.952756F;
            // 
            // tbBillNumber
            // 
            this.tbBillNumber.Border.BottomColor = System.Drawing.Color.Black;
            this.tbBillNumber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbBillNumber.Border.LeftColor = System.Drawing.Color.Black;
            this.tbBillNumber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbBillNumber.Border.RightColor = System.Drawing.Color.Black;
            this.tbBillNumber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbBillNumber.Border.TopColor = System.Drawing.Color.Black;
            this.tbBillNumber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbBillNumber.DataField = "BillNumber";
            this.tbBillNumber.Height = 0.2362205F;
            this.tbBillNumber.HyperLink = null;
            this.tbBillNumber.Left = 4.72441F;
            this.tbBillNumber.MultiLine = false;
            this.tbBillNumber.Name = "tbBillNumber";
            this.tbBillNumber.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "12pt; font-family: Tahoma; ";
            this.tbBillNumber.Text = "BillNumber";
            this.tbBillNumber.Top = 0.03937008F;
            this.tbBillNumber.Width = 1.181102F;
            // 
            // tbDate
            // 
            this.tbDate.Border.BottomColor = System.Drawing.Color.Black;
            this.tbDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDate.Border.LeftColor = System.Drawing.Color.Black;
            this.tbDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDate.Border.RightColor = System.Drawing.Color.Black;
            this.tbDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDate.Border.TopColor = System.Drawing.Color.Black;
            this.tbDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDate.DataField = "=";
            this.tbDate.Height = 0.1666667F;
            this.tbDate.HyperLink = null;
            this.tbDate.Left = 2.44439F;
            this.tbDate.MultiLine = false;
            this.tbDate.Name = "tbDate";
            this.tbDate.Style = "color: Black; ddo-char-set: 204; text-align: center; font-weight: bold; font-size" +
                ": 9.75pt; font-family: Tahoma; ";
            this.tbDate.Text = "dtoRusWords(TripDate)";
            this.tbDate.Top = 0.3543307F;
            this.tbDate.Width = 2.46875F;
            // 
            // lblPageHeader02
            // 
            this.lblPageHeader02.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPageHeader02.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader02.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPageHeader02.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader02.Border.RightColor = System.Drawing.Color.Black;
            this.lblPageHeader02.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader02.Border.TopColor = System.Drawing.Color.Black;
            this.lblPageHeader02.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader02.Height = 0.1968504F;
            this.lblPageHeader02.HyperLink = null;
            this.lblPageHeader02.Left = 0.07874016F;
            this.lblPageHeader02.MultiLine = false;
            this.lblPageHeader02.Name = "lblPageHeader02";
            this.lblPageHeader02.Style = "color: Black; ddo-char-set: 204; font-weight: normal; font-size: 9.75pt; font-fam" +
                "ily: Tahoma; white-space: nowrap; ";
            this.lblPageHeader02.Text = "Организация:";
            this.lblPageHeader02.Top = 0.5905512F;
            this.lblPageHeader02.Width = 0.9448819F;
            // 
            // tbWeName
            // 
            this.tbWeName.Border.BottomColor = System.Drawing.Color.Black;
            this.tbWeName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeName.Border.LeftColor = System.Drawing.Color.Black;
            this.tbWeName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeName.Border.RightColor = System.Drawing.Color.Black;
            this.tbWeName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeName.Border.TopColor = System.Drawing.Color.Black;
            this.tbWeName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeName.DataField = "WeName";
            this.tbWeName.Height = 0.1968504F;
            this.tbWeName.HyperLink = null;
            this.tbWeName.Left = 1.102362F;
            this.tbWeName.MultiLine = false;
            this.tbWeName.Name = "tbWeName";
            this.tbWeName.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 10pt; font-family:" +
                " Tahoma; white-space: nowrap; ";
            this.tbWeName.Text = "WeName";
            this.tbWeName.Top = 0.5905512F;
            this.tbWeName.Width = 3.937008F;
            // 
            // tbWeAddress
            // 
            this.tbWeAddress.Border.BottomColor = System.Drawing.Color.Black;
            this.tbWeAddress.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeAddress.Border.LeftColor = System.Drawing.Color.Black;
            this.tbWeAddress.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeAddress.Border.RightColor = System.Drawing.Color.Black;
            this.tbWeAddress.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeAddress.Border.TopColor = System.Drawing.Color.Black;
            this.tbWeAddress.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWeAddress.DataField = "WeAddress";
            this.tbWeAddress.Height = 0.1968504F;
            this.tbWeAddress.HyperLink = null;
            this.tbWeAddress.Left = 1.102362F;
            this.tbWeAddress.MultiLine = false;
            this.tbWeAddress.Name = "tbWeAddress";
            this.tbWeAddress.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.tbWeAddress.Text = "WeAddress";
            this.tbWeAddress.Top = 0.8661418F;
            this.tbWeAddress.Width = 6.141733F;
            // 
            // label40
            // 
            this.label40.Border.BottomColor = System.Drawing.Color.Black;
            this.label40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label40.Border.LeftColor = System.Drawing.Color.Black;
            this.label40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label40.Border.RightColor = System.Drawing.Color.Black;
            this.label40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label40.Border.TopColor = System.Drawing.Color.Black;
            this.label40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label40.Height = 0.1968504F;
            this.label40.HyperLink = null;
            this.label40.Left = 0.07874016F;
            this.label40.MultiLine = false;
            this.label40.Name = "label40";
            this.label40.Style = "color: Black; ddo-char-set: 204; font-weight: normal; font-size: 9.75pt; font-fam" +
                "ily: Tahoma; white-space: nowrap; ";
            this.label40.Text = "Адрес:";
            this.label40.Top = 0.8661418F;
            this.label40.Width = 0.9448819F;
            // 
            // label42
            // 
            this.label42.Border.BottomColor = System.Drawing.Color.Black;
            this.label42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label42.Border.LeftColor = System.Drawing.Color.Black;
            this.label42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label42.Border.RightColor = System.Drawing.Color.Black;
            this.label42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label42.Border.TopColor = System.Drawing.Color.Black;
            this.label42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label42.Height = 0.1968504F;
            this.label42.HyperLink = null;
            this.label42.Left = 0.3937008F;
            this.label42.MultiLine = false;
            this.label42.Name = "label42";
            this.label42.Style = "color: Black; ddo-char-set: 204; font-weight: normal; font-size: 9.75pt; font-fam" +
                "ily: Tahoma; white-space: nowrap; ";
            this.label42.Text = "М. П.";
            this.label42.Top = 0.1968504F;
            this.label42.Width = 0.3149606F;
            // 
            // label59
            // 
            this.label59.Border.BottomColor = System.Drawing.Color.Black;
            this.label59.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label59.Border.LeftColor = System.Drawing.Color.Black;
            this.label59.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label59.Border.RightColor = System.Drawing.Color.Black;
            this.label59.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label59.Border.TopColor = System.Drawing.Color.Black;
            this.label59.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label59.Height = 0.1968504F;
            this.label59.HyperLink = null;
            this.label59.Left = 5.905512F;
            this.label59.MultiLine = false;
            this.label59.Name = "label59";
            this.label59.Style = "color: Black; ddo-char-set: 204; font-weight: normal; font-size: 9.75pt; font-fam" +
                "ily: Tahoma; white-space: nowrap; ";
            this.label59.Text = "Тел:";
            this.label59.Top = 0.5905512F;
            this.label59.Width = 0.3149608F;
            // 
            // tbWePhone
            // 
            this.tbWePhone.Border.BottomColor = System.Drawing.Color.Black;
            this.tbWePhone.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWePhone.Border.LeftColor = System.Drawing.Color.Black;
            this.tbWePhone.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWePhone.Border.RightColor = System.Drawing.Color.Black;
            this.tbWePhone.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWePhone.Border.TopColor = System.Drawing.Color.Black;
            this.tbWePhone.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbWePhone.DataField = "WePhone";
            this.tbWePhone.Height = 0.1968504F;
            this.tbWePhone.HyperLink = null;
            this.tbWePhone.Left = 6.299213F;
            this.tbWePhone.MultiLine = false;
            this.tbWePhone.Name = "tbWePhone";
            this.tbWePhone.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 10pt; font-family:" +
                " Tahoma; white-space: nowrap; ";
            this.tbWePhone.Text = "WePhone";
            this.tbWePhone.Top = 0.5905512F;
            this.tbWePhone.Width = 0.9448819F;
            // 
            // Detail
            // 
            this.Detail.ColumnSpacing = 0F;
            this.Detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label57,
            this.label47,
            this.label46,
            this.shape1,
            this.lblDetail02,
            this.lblDetail04,
            this.lblDetail06,
            this.lblDetail07,
            this.lblDetail08,
            this.linDetail04,
            this.tbCarModel,
            this.tbCarNumber,
            this.tbDriverName,
            this.txtDetail07,
            this.tbSpeedometerDataBeg,
            this.tbFuelDataBeg,
            this.label2,
            this.tbDriverLicenceNumber,
            this.line1,
            this.line2,
            this.line3,
            this.line4,
            this.label4,
            this.label5,
            this.line5,
            this.line7,
            this.line9,
            this.label6,
            this.label8,
            this.label10,
            this.line10,
            this.line11,
            this.label11,
            this.label12,
            this.label13,
            this.tbFuelTypeName,
            this.label14,
            this.label15,
            this.label3,
            this.label16,
            this.label17,
            this.tbAddressForStart,
            this.tbReason,
            this.line12,
            this.shape2,
            this.line13,
            this.line14,
            this.line15,
            this.label1,
            this.label18,
            this.label19,
            this.line16,
            this.line18,
            this.line19,
            this.line20,
            this.label22,
            this.label23,
            this.label24,
            this.line21,
            this.line22,
            this.label25,
            this.label26,
            this.label27,
            this.line23,
            this.label29,
            this.label30,
            this.label31,
            this.label32,
            this.line26,
            this.label33,
            this.line27,
            this.label34,
            this.label35,
            this.label36,
            this.label37,
            this.label38,
            this.line30,
            this.label39,
            this.line33,
            this.label44,
            this.label45,
            this.line35,
            this.line31,
            this.label48,
            this.line25,
            this.label7,
            this.label20,
            this.line6,
            this.label21,
            this.line17,
            this.label49,
            this.label50,
            this.label51,
            this.label43,
            this.line32,
            this.label52,
            this.line36,
            this.label28,
            this.line24,
            this.label53,
            this.line37,
            this.label54,
            this.line38,
            this.label55,
            this.line28,
            this.label56,
            this.line29,
            this.line39,
            this.label58,
            this.line40,
            this.line41,
            this.line42,
            this.line43,
            this.label9,
            this.line8,
            this.label41,
            this.line44,
            this.label60,
            this.line45});
            this.Detail.Height = 9.645669F;
            this.Detail.Name = "Detail";
            this.Detail.Format += new System.EventHandler(this.Detail_Format);
            // 
            // label57
            // 
            this.label57.Border.BottomColor = System.Drawing.Color.Black;
            this.label57.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label57.Border.LeftColor = System.Drawing.Color.Black;
            this.label57.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label57.Border.RightColor = System.Drawing.Color.Black;
            this.label57.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label57.Border.TopColor = System.Drawing.Color.Black;
            this.label57.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label57.Height = 0.1181102F;
            this.label57.HyperLink = null;
            this.label57.Left = 6.220472F;
            this.label57.Name = "label57";
            this.label57.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label57.Text = "расшифровка подписи";
            this.label57.Top = 7.952756F;
            this.label57.Width = 0.9448819F;
            // 
            // label47
            // 
            this.label47.Border.BottomColor = System.Drawing.Color.Black;
            this.label47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label47.Border.LeftColor = System.Drawing.Color.Black;
            this.label47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label47.Border.RightColor = System.Drawing.Color.Black;
            this.label47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label47.Border.TopColor = System.Drawing.Color.Black;
            this.label47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label47.Height = 0.1181102F;
            this.label47.HyperLink = null;
            this.label47.Left = 6.220472F;
            this.label47.Name = "label47";
            this.label47.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label47.Text = "расшифровка подписи";
            this.label47.Top = 6.771654F;
            this.label47.Width = 0.9448819F;
            // 
            // label46
            // 
            this.label46.Border.BottomColor = System.Drawing.Color.Black;
            this.label46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label46.Border.LeftColor = System.Drawing.Color.Black;
            this.label46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label46.Border.RightColor = System.Drawing.Color.Black;
            this.label46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label46.Border.TopColor = System.Drawing.Color.Black;
            this.label46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label46.Height = 0.1181102F;
            this.label46.HyperLink = null;
            this.label46.Left = 0.3937008F;
            this.label46.Name = "label46";
            this.label46.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label46.Text = "должность";
            this.label46.Top = 7.165354F;
            this.label46.Width = 0.472441F;
            // 
            // shape1
            // 
            this.shape1.Border.BottomColor = System.Drawing.Color.Black;
            this.shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape1.Border.LeftColor = System.Drawing.Color.Black;
            this.shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape1.Border.RightColor = System.Drawing.Color.Black;
            this.shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape1.Border.TopColor = System.Drawing.Color.Black;
            this.shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape1.Height = 1.023622F;
            this.shape1.Left = 0.03937008F;
            this.shape1.Name = "shape1";
            this.shape1.RoundingRadius = 9.999999F;
            this.shape1.Top = 2.440945F;
            this.shape1.Width = 7.244095F;
            // 
            // lblDetail02
            // 
            this.lblDetail02.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDetail02.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail02.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDetail02.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail02.Border.RightColor = System.Drawing.Color.Black;
            this.lblDetail02.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail02.Border.TopColor = System.Drawing.Color.Black;
            this.lblDetail02.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail02.Height = 0.1968504F;
            this.lblDetail02.HyperLink = null;
            this.lblDetail02.Left = 0.07874016F;
            this.lblDetail02.MultiLine = false;
            this.lblDetail02.Name = "lblDetail02";
            this.lblDetail02.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.lblDetail02.Text = "Марка автомобиля:";
            this.lblDetail02.Top = 0.3543307F;
            this.lblDetail02.Width = 1.259843F;
            // 
            // lblDetail04
            // 
            this.lblDetail04.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDetail04.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail04.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDetail04.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail04.Border.RightColor = System.Drawing.Color.Black;
            this.lblDetail04.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail04.Border.TopColor = System.Drawing.Color.Black;
            this.lblDetail04.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail04.Height = 0.1968504F;
            this.lblDetail04.HyperLink = null;
            this.lblDetail04.Left = 4.88189F;
            this.lblDetail04.MultiLine = false;
            this.lblDetail04.Name = "lblDetail04";
            this.lblDetail04.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.lblDetail04.Text = "Гос. номерной знак:";
            this.lblDetail04.Top = 0.3543307F;
            this.lblDetail04.Width = 1.299212F;
            // 
            // lblDetail06
            // 
            this.lblDetail06.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDetail06.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail06.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDetail06.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail06.Border.RightColor = System.Drawing.Color.Black;
            this.lblDetail06.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail06.Border.TopColor = System.Drawing.Color.Black;
            this.lblDetail06.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail06.Height = 0.1968504F;
            this.lblDetail06.HyperLink = null;
            this.lblDetail06.Left = 0.03937008F;
            this.lblDetail06.MultiLine = false;
            this.lblDetail06.Name = "lblDetail06";
            this.lblDetail06.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-style: italic; font-size" +
                ": 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.lblDetail06.Text = "Данные о спидометре и остатках топлива в баке";
            this.lblDetail06.Top = 2.204725F;
            this.lblDetail06.Width = 3.897638F;
            // 
            // lblDetail07
            // 
            this.lblDetail07.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDetail07.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail07.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDetail07.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail07.Border.RightColor = System.Drawing.Color.Black;
            this.lblDetail07.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail07.Border.TopColor = System.Drawing.Color.Black;
            this.lblDetail07.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail07.Height = 0.1968504F;
            this.lblDetail07.HyperLink = null;
            this.lblDetail07.Left = 0.07874016F;
            this.lblDetail07.MultiLine = false;
            this.lblDetail07.Name = "lblDetail07";
            this.lblDetail07.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.lblDetail07.Text = "Водитель:";
            this.lblDetail07.Top = 0.9055119F;
            this.lblDetail07.Width = 0.6692913F;
            // 
            // lblDetail08
            // 
            this.lblDetail08.Border.BottomColor = System.Drawing.Color.Black;
            this.lblDetail08.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail08.Border.LeftColor = System.Drawing.Color.Black;
            this.lblDetail08.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail08.Border.RightColor = System.Drawing.Color.Black;
            this.lblDetail08.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail08.Border.TopColor = System.Drawing.Color.Black;
            this.lblDetail08.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblDetail08.Height = 0.1968504F;
            this.lblDetail08.HyperLink = null;
            this.lblDetail08.Left = 0.07874016F;
            this.lblDetail08.MultiLine = false;
            this.lblDetail08.Name = "lblDetail08";
            this.lblDetail08.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.lblDetail08.Text = "Сопровождающий:";
            this.lblDetail08.Top = 1.141732F;
            this.lblDetail08.Width = 1.220472F;
            // 
            // linDetail04
            // 
            this.linDetail04.Border.BottomColor = System.Drawing.Color.Black;
            this.linDetail04.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail04.Border.LeftColor = System.Drawing.Color.Black;
            this.linDetail04.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail04.Border.RightColor = System.Drawing.Color.Black;
            this.linDetail04.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail04.Border.TopColor = System.Drawing.Color.Black;
            this.linDetail04.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail04.Height = 0F;
            this.linDetail04.Left = 0.03937008F;
            this.linDetail04.LineWeight = 5F;
            this.linDetail04.Name = "linDetail04";
            this.linDetail04.Top = 0.03937008F;
            this.linDetail04.Width = 7.244095F;
            this.linDetail04.X1 = 7.283465F;
            this.linDetail04.X2 = 0.03937008F;
            this.linDetail04.Y1 = 0.03937008F;
            this.linDetail04.Y2 = 0.03937008F;
            // 
            // tbCarModel
            // 
            this.tbCarModel.Border.BottomColor = System.Drawing.Color.Black;
            this.tbCarModel.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarModel.Border.LeftColor = System.Drawing.Color.Black;
            this.tbCarModel.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarModel.Border.RightColor = System.Drawing.Color.Black;
            this.tbCarModel.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarModel.Border.TopColor = System.Drawing.Color.Black;
            this.tbCarModel.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarModel.DataField = "CarModel";
            this.tbCarModel.Height = 0.1968504F;
            this.tbCarModel.HyperLink = null;
            this.tbCarModel.Left = 1.614173F;
            this.tbCarModel.MultiLine = false;
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.tbCarModel.Text = "CarModel";
            this.tbCarModel.Top = 0.3543307F;
            this.tbCarModel.Width = 1.574803F;
            // 
            // tbCarNumber
            // 
            this.tbCarNumber.Border.BottomColor = System.Drawing.Color.Black;
            this.tbCarNumber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarNumber.Border.LeftColor = System.Drawing.Color.Black;
            this.tbCarNumber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarNumber.Border.RightColor = System.Drawing.Color.Black;
            this.tbCarNumber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarNumber.Border.TopColor = System.Drawing.Color.Black;
            this.tbCarNumber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbCarNumber.DataField = "CarNumber";
            this.tbCarNumber.Height = 0.1968504F;
            this.tbCarNumber.HyperLink = null;
            this.tbCarNumber.Left = 6.259842F;
            this.tbCarNumber.MultiLine = false;
            this.tbCarNumber.Name = "tbCarNumber";
            this.tbCarNumber.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.tbCarNumber.Text = "CarNumber";
            this.tbCarNumber.Top = 0.3543307F;
            this.tbCarNumber.Width = 0.984252F;
            // 
            // tbDriverName
            // 
            this.tbDriverName.Border.BottomColor = System.Drawing.Color.Black;
            this.tbDriverName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverName.Border.LeftColor = System.Drawing.Color.Black;
            this.tbDriverName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverName.Border.RightColor = System.Drawing.Color.Black;
            this.tbDriverName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverName.Border.TopColor = System.Drawing.Color.Black;
            this.tbDriverName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverName.DataField = "DriverName";
            this.tbDriverName.Height = 0.1968504F;
            this.tbDriverName.HyperLink = null;
            this.tbDriverName.Left = 1.574803F;
            this.tbDriverName.MultiLine = false;
            this.tbDriverName.Name = "tbDriverName";
            this.tbDriverName.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.tbDriverName.Text = "DriverName";
            this.tbDriverName.Top = 0.9055119F;
            this.tbDriverName.Width = 3.149606F;
            // 
            // txtDetail07
            // 
            this.txtDetail07.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDetail07.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail07.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDetail07.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail07.Border.RightColor = System.Drawing.Color.Black;
            this.txtDetail07.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail07.Border.TopColor = System.Drawing.Color.Black;
            this.txtDetail07.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail07.DataField = "DriverOther";
            this.txtDetail07.Height = 0.1968504F;
            this.txtDetail07.HyperLink = null;
            this.txtDetail07.Left = 1.574803F;
            this.txtDetail07.MultiLine = false;
            this.txtDetail07.Name = "txtDetail07";
            this.txtDetail07.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.txtDetail07.Text = "AssistantName";
            this.txtDetail07.Top = 1.141732F;
            this.txtDetail07.Width = 3.149606F;
            // 
            // tbSpeedometerDataBeg
            // 
            this.tbSpeedometerDataBeg.Border.BottomColor = System.Drawing.Color.Black;
            this.tbSpeedometerDataBeg.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbSpeedometerDataBeg.Border.LeftColor = System.Drawing.Color.Black;
            this.tbSpeedometerDataBeg.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbSpeedometerDataBeg.Border.RightColor = System.Drawing.Color.Black;
            this.tbSpeedometerDataBeg.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbSpeedometerDataBeg.Border.TopColor = System.Drawing.Color.Black;
            this.tbSpeedometerDataBeg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbSpeedometerDataBeg.DataField = "SpeedometerDataBeg";
            this.tbSpeedometerDataBeg.Height = 0.1574803F;
            this.tbSpeedometerDataBeg.HyperLink = null;
            this.tbSpeedometerDataBeg.Left = 4.606299F;
            this.tbSpeedometerDataBeg.MultiLine = false;
            this.tbSpeedometerDataBeg.Name = "tbSpeedometerDataBeg";
            this.tbSpeedometerDataBeg.Style = "color: Black; ddo-char-set: 204; text-align: center; font-weight: bold; font-size" +
                ": 9pt; font-family: Tahoma; ";
            this.tbSpeedometerDataBeg.Text = "SpeedometerDataBeg";
            this.tbSpeedometerDataBeg.Top = 2.913386F;
            this.tbSpeedometerDataBeg.Width = 0.826772F;
            // 
            // tbFuelDataBeg
            // 
            this.tbFuelDataBeg.Border.BottomColor = System.Drawing.Color.Black;
            this.tbFuelDataBeg.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelDataBeg.Border.LeftColor = System.Drawing.Color.Black;
            this.tbFuelDataBeg.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelDataBeg.Border.RightColor = System.Drawing.Color.Black;
            this.tbFuelDataBeg.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelDataBeg.Border.TopColor = System.Drawing.Color.Black;
            this.tbFuelDataBeg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelDataBeg.DataField = "FuelDataBeg";
            this.tbFuelDataBeg.Height = 0.1574803F;
            this.tbFuelDataBeg.HyperLink = null;
            this.tbFuelDataBeg.Left = 6.181103F;
            this.tbFuelDataBeg.MultiLine = false;
            this.tbFuelDataBeg.Name = "tbFuelDataBeg";
            this.tbFuelDataBeg.Style = "color: Black; ddo-char-set: 204; text-align: center; font-weight: bold; font-size" +
                ": 9pt; font-family: Tahoma; ";
            this.tbFuelDataBeg.Text = "FuelDataBeg";
            this.tbFuelDataBeg.Top = 2.913386F;
            this.tbFuelDataBeg.Width = 0.826772F;
            // 
            // label2
            // 
            this.label2.Border.BottomColor = System.Drawing.Color.Black;
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.LeftColor = System.Drawing.Color.Black;
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.RightColor = System.Drawing.Color.Black;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.TopColor = System.Drawing.Color.Black;
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Height = 0.1968504F;
            this.label2.HyperLink = null;
            this.label2.Left = 4.88189F;
            this.label2.MultiLine = false;
            this.label2.Name = "label2";
            this.label2.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label2.Text = "Вод. удостоверение:";
            this.label2.Top = 0.9055119F;
            this.label2.Width = 1.299212F;
            // 
            // tbDriverLicenceNumber
            // 
            this.tbDriverLicenceNumber.Border.BottomColor = System.Drawing.Color.Black;
            this.tbDriverLicenceNumber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverLicenceNumber.Border.LeftColor = System.Drawing.Color.Black;
            this.tbDriverLicenceNumber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverLicenceNumber.Border.RightColor = System.Drawing.Color.Black;
            this.tbDriverLicenceNumber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverLicenceNumber.Border.TopColor = System.Drawing.Color.Black;
            this.tbDriverLicenceNumber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbDriverLicenceNumber.DataField = "DriverLicenceNumber";
            this.tbDriverLicenceNumber.Height = 0.1968504F;
            this.tbDriverLicenceNumber.HyperLink = null;
            this.tbDriverLicenceNumber.Left = 6.259842F;
            this.tbDriverLicenceNumber.MultiLine = false;
            this.tbDriverLicenceNumber.Name = "tbDriverLicenceNumber";
            this.tbDriverLicenceNumber.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.tbDriverLicenceNumber.Text = "DriverLicenceNumber";
            this.tbDriverLicenceNumber.Top = 0.9055119F;
            this.tbDriverLicenceNumber.Width = 0.984252F;
            // 
            // line1
            // 
            this.line1.Border.BottomColor = System.Drawing.Color.Black;
            this.line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.LeftColor = System.Drawing.Color.Black;
            this.line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.RightColor = System.Drawing.Color.Black;
            this.line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.TopColor = System.Drawing.Color.Black;
            this.line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Height = 0F;
            this.line1.Left = 0.03937008F;
            this.line1.LineWeight = 3F;
            this.line1.Name = "line1";
            this.line1.Top = 0.5905512F;
            this.line1.Width = 7.244095F;
            this.line1.X1 = 7.283465F;
            this.line1.X2 = 0.03937008F;
            this.line1.Y1 = 0.5905512F;
            this.line1.Y2 = 0.5905512F;
            // 
            // line2
            // 
            this.line2.Border.BottomColor = System.Drawing.Color.Black;
            this.line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Border.LeftColor = System.Drawing.Color.Black;
            this.line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Border.RightColor = System.Drawing.Color.Black;
            this.line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Border.TopColor = System.Drawing.Color.Black;
            this.line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line2.Height = 0F;
            this.line2.Left = 0.03937008F;
            this.line2.LineWeight = 3F;
            this.line2.Name = "line2";
            this.line2.Top = 1.377953F;
            this.line2.Width = 7.244095F;
            this.line2.X1 = 7.283465F;
            this.line2.X2 = 0.03937008F;
            this.line2.Y1 = 1.377953F;
            this.line2.Y2 = 1.377953F;
            // 
            // line3
            // 
            this.line3.Border.BottomColor = System.Drawing.Color.Black;
            this.line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Border.LeftColor = System.Drawing.Color.Black;
            this.line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Border.RightColor = System.Drawing.Color.Black;
            this.line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Border.TopColor = System.Drawing.Color.Black;
            this.line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line3.Height = 0F;
            this.line3.Left = 0.03937008F;
            this.line3.LineWeight = 1F;
            this.line3.Name = "line3";
            this.line3.Top = 2.834646F;
            this.line3.Width = 7.244095F;
            this.line3.X1 = 0.03937008F;
            this.line3.X2 = 7.283465F;
            this.line3.Y1 = 2.834646F;
            this.line3.Y2 = 2.834646F;
            // 
            // line4
            // 
            this.line4.Border.BottomColor = System.Drawing.Color.Black;
            this.line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line4.Border.LeftColor = System.Drawing.Color.Black;
            this.line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line4.Border.RightColor = System.Drawing.Color.Black;
            this.line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line4.Border.TopColor = System.Drawing.Color.Black;
            this.line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line4.Height = 0F;
            this.line4.Left = 0.03937008F;
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 3.149606F;
            this.line4.Width = 7.244095F;
            this.line4.X1 = 0.03937008F;
            this.line4.X2 = 7.283465F;
            this.line4.Y1 = 3.149606F;
            this.line4.Y2 = 3.149606F;
            // 
            // label4
            // 
            this.label4.Border.BottomColor = System.Drawing.Color.Black;
            this.label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.LeftColor = System.Drawing.Color.Black;
            this.label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.RightColor = System.Drawing.Color.Black;
            this.label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.TopColor = System.Drawing.Color.Black;
            this.label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Height = 0.1968505F;
            this.label4.HyperLink = null;
            this.label4.Left = 0.1181102F;
            this.label4.MultiLine = false;
            this.label4.Name = "label4";
            this.label4.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label4.Text = "Выезд из гаража";
            this.label4.Top = 2.913386F;
            this.label4.Width = 1.102362F;
            // 
            // label5
            // 
            this.label5.Border.BottomColor = System.Drawing.Color.Black;
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.LeftColor = System.Drawing.Color.Black;
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.RightColor = System.Drawing.Color.Black;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.TopColor = System.Drawing.Color.Black;
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Height = 0.1968503F;
            this.label5.HyperLink = null;
            this.label5.Left = 0.1181102F;
            this.label5.MultiLine = false;
            this.label5.Name = "label5";
            this.label5.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label5.Text = "Возвращение в гараж";
            this.label5.Top = 3.228347F;
            this.label5.Width = 1.417323F;
            // 
            // line5
            // 
            this.line5.Border.BottomColor = System.Drawing.Color.Black;
            this.line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line5.Border.LeftColor = System.Drawing.Color.Black;
            this.line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line5.Border.RightColor = System.Drawing.Color.Black;
            this.line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line5.Border.TopColor = System.Drawing.Color.Black;
            this.line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line5.Height = 1.023622F;
            this.line5.Left = 1.574803F;
            this.line5.LineWeight = 1F;
            this.line5.Name = "line5";
            this.line5.Top = 2.440945F;
            this.line5.Width = 0F;
            this.line5.X1 = 1.574803F;
            this.line5.X2 = 1.574803F;
            this.line5.Y1 = 2.440945F;
            this.line5.Y2 = 3.464567F;
            // 
            // line7
            // 
            this.line7.Border.BottomColor = System.Drawing.Color.Black;
            this.line7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line7.Border.LeftColor = System.Drawing.Color.Black;
            this.line7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line7.Border.RightColor = System.Drawing.Color.Black;
            this.line7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line7.Border.TopColor = System.Drawing.Color.Black;
            this.line7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line7.Height = 1.023622F;
            this.line7.Left = 3.070866F;
            this.line7.LineWeight = 1F;
            this.line7.Name = "line7";
            this.line7.Top = 2.440945F;
            this.line7.Width = 0F;
            this.line7.X1 = 3.070866F;
            this.line7.X2 = 3.070866F;
            this.line7.Y1 = 2.440945F;
            this.line7.Y2 = 3.464567F;
            // 
            // line9
            // 
            this.line9.Border.BottomColor = System.Drawing.Color.Black;
            this.line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line9.Border.LeftColor = System.Drawing.Color.Black;
            this.line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line9.Border.RightColor = System.Drawing.Color.Black;
            this.line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line9.Border.TopColor = System.Drawing.Color.Black;
            this.line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line9.Height = 1.023622F;
            this.line9.Left = 4.330709F;
            this.line9.LineWeight = 1F;
            this.line9.Name = "line9";
            this.line9.Top = 2.440945F;
            this.line9.Width = 0F;
            this.line9.X1 = 4.330709F;
            this.line9.X2 = 4.330709F;
            this.line9.Y1 = 2.440945F;
            this.line9.Y2 = 3.464567F;
            // 
            // label6
            // 
            this.label6.Border.BottomColor = System.Drawing.Color.Black;
            this.label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.LeftColor = System.Drawing.Color.Black;
            this.label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.RightColor = System.Drawing.Color.Black;
            this.label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.TopColor = System.Drawing.Color.Black;
            this.label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Height = 0.1574803F;
            this.label6.HyperLink = null;
            this.label6.Left = 1.653543F;
            this.label6.MultiLine = false;
            this.label6.Name = "label6";
            this.label6.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: nowrap; ";
            this.label6.Text = "Дата (число, месяц, год)";
            this.label6.Top = 2.559055F;
            this.label6.Width = 1.338583F;
            // 
            // label8
            // 
            this.label8.Border.BottomColor = System.Drawing.Color.Black;
            this.label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.LeftColor = System.Drawing.Color.Black;
            this.label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.RightColor = System.Drawing.Color.Black;
            this.label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.TopColor = System.Drawing.Color.Black;
            this.label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Height = 0.1574803F;
            this.label8.HyperLink = null;
            this.label8.Left = 3.188977F;
            this.label8.MultiLine = false;
            this.label8.Name = "label8";
            this.label8.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: nowrap; ";
            this.label8.Text = "Время (ч., мин.)";
            this.label8.Top = 2.559055F;
            this.label8.Width = 1.062992F;
            // 
            // label10
            // 
            this.label10.Border.BottomColor = System.Drawing.Color.Black;
            this.label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.LeftColor = System.Drawing.Color.Black;
            this.label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.RightColor = System.Drawing.Color.Black;
            this.label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.TopColor = System.Drawing.Color.Black;
            this.label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Height = 0.3149606F;
            this.label10.HyperLink = null;
            this.label10.Left = 4.448819F;
            this.label10.Name = "label10";
            this.label10.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label10.Text = "показания спидометра, км";
            this.label10.Top = 2.480315F;
            this.label10.Width = 1.181102F;
            // 
            // line10
            // 
            this.line10.Border.BottomColor = System.Drawing.Color.Black;
            this.line10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line10.Border.LeftColor = System.Drawing.Color.Black;
            this.line10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line10.Border.RightColor = System.Drawing.Color.Black;
            this.line10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line10.Border.TopColor = System.Drawing.Color.Black;
            this.line10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line10.Height = 0F;
            this.line10.Left = 0.03937008F;
            this.line10.LineWeight = 3F;
            this.line10.Name = "line10";
            this.line10.Top = 3.937008F;
            this.line10.Width = 7.244095F;
            this.line10.X1 = 7.283465F;
            this.line10.X2 = 0.03937008F;
            this.line10.Y1 = 3.937008F;
            this.line10.Y2 = 3.937008F;
            // 
            // line11
            // 
            this.line11.Border.BottomColor = System.Drawing.Color.Black;
            this.line11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line11.Border.LeftColor = System.Drawing.Color.Black;
            this.line11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line11.Border.RightColor = System.Drawing.Color.Black;
            this.line11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line11.Border.TopColor = System.Drawing.Color.Black;
            this.line11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line11.Height = 1.023622F;
            this.line11.Left = 5.748032F;
            this.line11.LineWeight = 1F;
            this.line11.Name = "line11";
            this.line11.Top = 2.440945F;
            this.line11.Width = 0F;
            this.line11.X1 = 5.748032F;
            this.line11.X2 = 5.748032F;
            this.line11.Y1 = 2.440945F;
            this.line11.Y2 = 3.464567F;
            // 
            // label11
            // 
            this.label11.Border.BottomColor = System.Drawing.Color.Black;
            this.label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label11.Border.LeftColor = System.Drawing.Color.Black;
            this.label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label11.Border.RightColor = System.Drawing.Color.Black;
            this.label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label11.Border.TopColor = System.Drawing.Color.Black;
            this.label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label11.Height = 0.3149606F;
            this.label11.HyperLink = null;
            this.label11.Left = 6.062992F;
            this.label11.Name = "label11";
            this.label11.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label11.Text = "остаток топлива в баке, л";
            this.label11.Top = 2.480315F;
            this.label11.Width = 0.9055117F;
            // 
            // label12
            // 
            this.label12.Border.BottomColor = System.Drawing.Color.Black;
            this.label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label12.Border.LeftColor = System.Drawing.Color.Black;
            this.label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label12.Border.RightColor = System.Drawing.Color.Black;
            this.label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label12.Border.TopColor = System.Drawing.Color.Black;
            this.label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label12.Height = 0.1968504F;
            this.label12.HyperLink = null;
            this.label12.Left = 0.03937008F;
            this.label12.MultiLine = false;
            this.label12.Name = "label12";
            this.label12.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-style: italic; font-size" +
                ": 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label12.Text = "Данные о заправках топливом";
            this.label12.Top = 4.015748F;
            this.label12.Width = 2.322835F;
            // 
            // label13
            // 
            this.label13.Border.BottomColor = System.Drawing.Color.Black;
            this.label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.LeftColor = System.Drawing.Color.Black;
            this.label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.RightColor = System.Drawing.Color.Black;
            this.label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.TopColor = System.Drawing.Color.Black;
            this.label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Height = 0.1968504F;
            this.label13.HyperLink = null;
            this.label13.Left = 5.157481F;
            this.label13.MultiLine = false;
            this.label13.Name = "label13";
            this.label13.Style = "color: Black; ddo-char-set: 204; font-size: 10pt; font-family: Tahoma; white-spac" +
                "e: nowrap; ";
            this.label13.Text = "Тип топлива:";
            this.label13.Top = 4.015748F;
            this.label13.Width = 0.8661416F;
            // 
            // tbFuelTypeName
            // 
            this.tbFuelTypeName.Border.BottomColor = System.Drawing.Color.Black;
            this.tbFuelTypeName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelTypeName.Border.LeftColor = System.Drawing.Color.Black;
            this.tbFuelTypeName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelTypeName.Border.RightColor = System.Drawing.Color.Black;
            this.tbFuelTypeName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelTypeName.Border.TopColor = System.Drawing.Color.Black;
            this.tbFuelTypeName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbFuelTypeName.DataField = "FuelTypeName";
            this.tbFuelTypeName.Height = 0.1968504F;
            this.tbFuelTypeName.HyperLink = null;
            this.tbFuelTypeName.Left = 6.102362F;
            this.tbFuelTypeName.MultiLine = false;
            this.tbFuelTypeName.Name = "tbFuelTypeName";
            this.tbFuelTypeName.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9.75pt; font-family: Tahoma; ";
            this.tbFuelTypeName.Text = "FuelTypeName";
            this.tbFuelTypeName.Top = 4.015748F;
            this.tbFuelTypeName.Width = 1.181102F;
            // 
            // label14
            // 
            this.label14.Border.BottomColor = System.Drawing.Color.Black;
            this.label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label14.Border.LeftColor = System.Drawing.Color.Black;
            this.label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label14.Border.RightColor = System.Drawing.Color.Black;
            this.label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label14.Border.TopColor = System.Drawing.Color.Black;
            this.label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label14.Height = 0.1968504F;
            this.label14.HyperLink = null;
            this.label14.Left = 0.07874016F;
            this.label14.MultiLine = false;
            this.label14.Name = "label14";
            this.label14.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-style: italic; font-size" +
                ": 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label14.Text = "Данные о транспортном средстве";
            this.label14.Top = 0.1181102F;
            this.label14.Width = 2.716536F;
            // 
            // label15
            // 
            this.label15.Border.BottomColor = System.Drawing.Color.Black;
            this.label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label15.Border.LeftColor = System.Drawing.Color.Black;
            this.label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label15.Border.RightColor = System.Drawing.Color.Black;
            this.label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label15.Border.TopColor = System.Drawing.Color.Black;
            this.label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label15.Height = 0.1968504F;
            this.label15.HyperLink = null;
            this.label15.Left = 0.07874016F;
            this.label15.MultiLine = false;
            this.label15.Name = "label15";
            this.label15.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-style: italic; font-size" +
                ": 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label15.Text = "Данные о водителе и сопровождающем";
            this.label15.Top = 0.6692913F;
            this.label15.Width = 3.070866F;
            // 
            // label3
            // 
            this.label3.Border.BottomColor = System.Drawing.Color.Black;
            this.label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.LeftColor = System.Drawing.Color.Black;
            this.label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.RightColor = System.Drawing.Color.Black;
            this.label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.TopColor = System.Drawing.Color.Black;
            this.label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Height = 0.1968503F;
            this.label3.HyperLink = null;
            this.label3.Left = 0.07874016F;
            this.label3.MultiLine = false;
            this.label3.Name = "label3";
            this.label3.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-style: italic; font-size" +
                ": 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label3.Text = "Задание водителю";
            this.label3.Top = 1.456693F;
            this.label3.Width = 1.417323F;
            // 
            // label16
            // 
            this.label16.Border.BottomColor = System.Drawing.Color.Black;
            this.label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label16.Border.LeftColor = System.Drawing.Color.Black;
            this.label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label16.Border.RightColor = System.Drawing.Color.Black;
            this.label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label16.Border.TopColor = System.Drawing.Color.Black;
            this.label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label16.Height = 0.1968504F;
            this.label16.HyperLink = null;
            this.label16.Left = 0.07874016F;
            this.label16.MultiLine = false;
            this.label16.Name = "label16";
            this.label16.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label16.Text = "Адрес подачи:";
            this.label16.Top = 1.653543F;
            this.label16.Width = 1.417323F;
            // 
            // label17
            // 
            this.label17.Border.BottomColor = System.Drawing.Color.Black;
            this.label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label17.Border.LeftColor = System.Drawing.Color.Black;
            this.label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label17.Border.RightColor = System.Drawing.Color.Black;
            this.label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label17.Border.TopColor = System.Drawing.Color.Black;
            this.label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label17.Height = 0.1968504F;
            this.label17.HyperLink = null;
            this.label17.Left = 0.07874016F;
            this.label17.MultiLine = false;
            this.label17.Name = "label17";
            this.label17.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label17.Text = "Маршрут следования:";
            this.label17.Top = 1.889764F;
            this.label17.Width = 1.417323F;
            // 
            // tbAddressForStart
            // 
            this.tbAddressForStart.Border.BottomColor = System.Drawing.Color.Black;
            this.tbAddressForStart.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbAddressForStart.Border.LeftColor = System.Drawing.Color.Black;
            this.tbAddressForStart.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbAddressForStart.Border.RightColor = System.Drawing.Color.Black;
            this.tbAddressForStart.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbAddressForStart.Border.TopColor = System.Drawing.Color.Black;
            this.tbAddressForStart.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbAddressForStart.DataField = "WeAddress";
            this.tbAddressForStart.Height = 0.1968504F;
            this.tbAddressForStart.HyperLink = null;
            this.tbAddressForStart.Left = 1.574803F;
            this.tbAddressForStart.MultiLine = false;
            this.tbAddressForStart.Name = "tbAddressForStart";
            this.tbAddressForStart.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.tbAddressForStart.Text = "WeAddress";
            this.tbAddressForStart.Top = 1.653543F;
            this.tbAddressForStart.Width = 5.708662F;
            // 
            // tbReason
            // 
            this.tbReason.Border.BottomColor = System.Drawing.Color.Black;
            this.tbReason.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbReason.Border.LeftColor = System.Drawing.Color.Black;
            this.tbReason.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbReason.Border.RightColor = System.Drawing.Color.Black;
            this.tbReason.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbReason.Border.TopColor = System.Drawing.Color.Black;
            this.tbReason.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.tbReason.DataField = "Reason";
            this.tbReason.Height = 0.1968504F;
            this.tbReason.HyperLink = null;
            this.tbReason.Left = 1.574803F;
            this.tbReason.MultiLine = false;
            this.tbReason.Name = "tbReason";
            this.tbReason.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
                "9pt; font-family: Tahoma; ";
            this.tbReason.Text = "Reason";
            this.tbReason.Top = 1.889764F;
            this.tbReason.Width = 5.708662F;
            // 
            // line12
            // 
            this.line12.Border.BottomColor = System.Drawing.Color.Black;
            this.line12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line12.Border.LeftColor = System.Drawing.Color.Black;
            this.line12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line12.Border.RightColor = System.Drawing.Color.Black;
            this.line12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line12.Border.TopColor = System.Drawing.Color.Black;
            this.line12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line12.Height = 0F;
            this.line12.Left = 0.03937008F;
            this.line12.LineWeight = 3F;
            this.line12.Name = "line12";
            this.line12.Top = 2.125984F;
            this.line12.Width = 7.244095F;
            this.line12.X1 = 7.283465F;
            this.line12.X2 = 0.03937008F;
            this.line12.Y1 = 2.125984F;
            this.line12.Y2 = 2.125984F;
            // 
            // shape2
            // 
            this.shape2.Border.BottomColor = System.Drawing.Color.Black;
            this.shape2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape2.Border.LeftColor = System.Drawing.Color.Black;
            this.shape2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape2.Border.RightColor = System.Drawing.Color.Black;
            this.shape2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape2.Border.TopColor = System.Drawing.Color.Black;
            this.shape2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.shape2.Height = 1.338583F;
            this.shape2.Left = 0.03937008F;
            this.shape2.Name = "shape2";
            this.shape2.RoundingRadius = 9.999999F;
            this.shape2.Top = 4.251969F;
            this.shape2.Width = 7.244095F;
            // 
            // line13
            // 
            this.line13.Border.BottomColor = System.Drawing.Color.Black;
            this.line13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line13.Border.LeftColor = System.Drawing.Color.Black;
            this.line13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line13.Border.RightColor = System.Drawing.Color.Black;
            this.line13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line13.Border.TopColor = System.Drawing.Color.Black;
            this.line13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line13.Height = 0F;
            this.line13.Left = 0.03937008F;
            this.line13.LineWeight = 1F;
            this.line13.Name = "line13";
            this.line13.Top = 4.645669F;
            this.line13.Width = 7.244095F;
            this.line13.X1 = 0.03937008F;
            this.line13.X2 = 7.283465F;
            this.line13.Y1 = 4.645669F;
            this.line13.Y2 = 4.645669F;
            // 
            // line14
            // 
            this.line14.Border.BottomColor = System.Drawing.Color.Black;
            this.line14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line14.Border.LeftColor = System.Drawing.Color.Black;
            this.line14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line14.Border.RightColor = System.Drawing.Color.Black;
            this.line14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line14.Border.TopColor = System.Drawing.Color.Black;
            this.line14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line14.Height = 0F;
            this.line14.Left = 0.03937008F;
            this.line14.LineWeight = 1F;
            this.line14.Name = "line14";
            this.line14.Top = 4.96063F;
            this.line14.Width = 7.244095F;
            this.line14.X1 = 0.03937008F;
            this.line14.X2 = 7.283465F;
            this.line14.Y1 = 4.96063F;
            this.line14.Y2 = 4.96063F;
            // 
            // line15
            // 
            this.line15.Border.BottomColor = System.Drawing.Color.Black;
            this.line15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line15.Border.LeftColor = System.Drawing.Color.Black;
            this.line15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line15.Border.RightColor = System.Drawing.Color.Black;
            this.line15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line15.Border.TopColor = System.Drawing.Color.Black;
            this.line15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line15.Height = 0F;
            this.line15.Left = 0.03937008F;
            this.line15.LineWeight = 1F;
            this.line15.Name = "line15";
            this.line15.Top = 5.27559F;
            this.line15.Width = 7.244095F;
            this.line15.X1 = 0.03937008F;
            this.line15.X2 = 7.283465F;
            this.line15.Y1 = 5.27559F;
            this.line15.Y2 = 5.27559F;
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.Black;
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.LeftColor = System.Drawing.Color.Black;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.TopColor = System.Drawing.Color.Black;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Height = 0.1968505F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.1181102F;
            this.label1.MultiLine = false;
            this.label1.Name = "label1";
            this.label1.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label1.Text = "Заправка 1";
            this.label1.Top = 4.72441F;
            this.label1.Width = 1.181102F;
            // 
            // label18
            // 
            this.label18.Border.BottomColor = System.Drawing.Color.Black;
            this.label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label18.Border.LeftColor = System.Drawing.Color.Black;
            this.label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label18.Border.RightColor = System.Drawing.Color.Black;
            this.label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label18.Border.TopColor = System.Drawing.Color.Black;
            this.label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label18.Height = 0.1968504F;
            this.label18.HyperLink = null;
            this.label18.Left = 0.1181102F;
            this.label18.MultiLine = false;
            this.label18.Name = "label18";
            this.label18.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label18.Text = "Заправка 2";
            this.label18.Top = 5.03937F;
            this.label18.Width = 1.181102F;
            // 
            // label19
            // 
            this.label19.Border.BottomColor = System.Drawing.Color.Black;
            this.label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label19.Border.LeftColor = System.Drawing.Color.Black;
            this.label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label19.Border.RightColor = System.Drawing.Color.Black;
            this.label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label19.Border.TopColor = System.Drawing.Color.Black;
            this.label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label19.Height = 0.1968506F;
            this.label19.HyperLink = null;
            this.label19.Left = 0.1181102F;
            this.label19.MultiLine = false;
            this.label19.Name = "label19";
            this.label19.Style = "color: Black; ddo-char-set: 204; font-size: 9pt; font-family: Tahoma; white-space" +
                ": nowrap; ";
            this.label19.Text = "Заправка 3";
            this.label19.Top = 5.354331F;
            this.label19.Width = 1.181102F;
            // 
            // line16
            // 
            this.line16.Border.BottomColor = System.Drawing.Color.Black;
            this.line16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line16.Border.LeftColor = System.Drawing.Color.Black;
            this.line16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line16.Border.RightColor = System.Drawing.Color.Black;
            this.line16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line16.Border.TopColor = System.Drawing.Color.Black;
            this.line16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line16.Height = 1.338583F;
            this.line16.Left = 1.574803F;
            this.line16.LineWeight = 1F;
            this.line16.Name = "line16";
            this.line16.Top = 4.251969F;
            this.line16.Width = 0F;
            this.line16.X1 = 1.574803F;
            this.line16.X2 = 1.574803F;
            this.line16.Y1 = 4.251969F;
            this.line16.Y2 = 5.590551F;
            // 
            // line18
            // 
            this.line18.Border.BottomColor = System.Drawing.Color.Black;
            this.line18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line18.Border.LeftColor = System.Drawing.Color.Black;
            this.line18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line18.Border.RightColor = System.Drawing.Color.Black;
            this.line18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line18.Border.TopColor = System.Drawing.Color.Black;
            this.line18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line18.Height = 1.338583F;
            this.line18.Left = 3.070866F;
            this.line18.LineWeight = 1F;
            this.line18.Name = "line18";
            this.line18.Top = 4.251969F;
            this.line18.Width = 0F;
            this.line18.X1 = 3.070866F;
            this.line18.X2 = 3.070866F;
            this.line18.Y1 = 4.251969F;
            this.line18.Y2 = 5.590551F;
            // 
            // line19
            // 
            this.line19.Border.BottomColor = System.Drawing.Color.Black;
            this.line19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line19.Border.LeftColor = System.Drawing.Color.Black;
            this.line19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line19.Border.RightColor = System.Drawing.Color.Black;
            this.line19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line19.Border.TopColor = System.Drawing.Color.Black;
            this.line19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line19.Height = 1.338583F;
            this.line19.Left = 4.330709F;
            this.line19.LineWeight = 1F;
            this.line19.Name = "line19";
            this.line19.Top = 4.251969F;
            this.line19.Width = 0F;
            this.line19.X1 = 4.330709F;
            this.line19.X2 = 4.330709F;
            this.line19.Y1 = 4.251969F;
            this.line19.Y2 = 5.590551F;
            // 
            // line20
            // 
            this.line20.Border.BottomColor = System.Drawing.Color.Black;
            this.line20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line20.Border.LeftColor = System.Drawing.Color.Black;
            this.line20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line20.Border.RightColor = System.Drawing.Color.Black;
            this.line20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line20.Border.TopColor = System.Drawing.Color.Black;
            this.line20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line20.Height = 1.338583F;
            this.line20.Left = 5.748032F;
            this.line20.LineWeight = 1F;
            this.line20.Name = "line20";
            this.line20.Top = 4.251969F;
            this.line20.Width = 0F;
            this.line20.X1 = 5.748032F;
            this.line20.X2 = 5.748032F;
            this.line20.Y1 = 4.251969F;
            this.line20.Y2 = 5.590551F;
            // 
            // label22
            // 
            this.label22.Border.BottomColor = System.Drawing.Color.Black;
            this.label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label22.Border.LeftColor = System.Drawing.Color.Black;
            this.label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label22.Border.RightColor = System.Drawing.Color.Black;
            this.label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label22.Border.TopColor = System.Drawing.Color.Black;
            this.label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label22.Height = 0.3149608F;
            this.label22.HyperLink = null;
            this.label22.Left = 3.149606F;
            this.label22.Name = "label22";
            this.label22.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label22.Text = "кол-во залитого топлива, л";
            this.label22.Top = 4.291338F;
            this.label22.Width = 1.102362F;
            // 
            // label23
            // 
            this.label23.Border.BottomColor = System.Drawing.Color.Black;
            this.label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label23.Border.LeftColor = System.Drawing.Color.Black;
            this.label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label23.Border.RightColor = System.Drawing.Color.Black;
            this.label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label23.Border.TopColor = System.Drawing.Color.Black;
            this.label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label23.Height = 0.3149608F;
            this.label23.HyperLink = null;
            this.label23.Left = 4.527559F;
            this.label23.Name = "label23";
            this.label23.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label23.Text = "подпись заправщика";
            this.label23.Top = 4.291338F;
            this.label23.Width = 1.023622F;
            // 
            // label24
            // 
            this.label24.Border.BottomColor = System.Drawing.Color.Black;
            this.label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label24.Border.LeftColor = System.Drawing.Color.Black;
            this.label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label24.Border.RightColor = System.Drawing.Color.Black;
            this.label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label24.Border.TopColor = System.Drawing.Color.Black;
            this.label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label24.Height = 0.3149608F;
            this.label24.HyperLink = null;
            this.label24.Left = 6.062992F;
            this.label24.Name = "label24";
            this.label24.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label24.Text = "подпись водителя";
            this.label24.Top = 4.291338F;
            this.label24.Width = 0.9055117F;
            // 
            // line21
            // 
            this.line21.Border.BottomColor = System.Drawing.Color.Black;
            this.line21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line21.Border.LeftColor = System.Drawing.Color.Black;
            this.line21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line21.Border.RightColor = System.Drawing.Color.Black;
            this.line21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line21.Border.TopColor = System.Drawing.Color.Black;
            this.line21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line21.Height = 0F;
            this.line21.Left = 0.03937008F;
            this.line21.LineWeight = 3F;
            this.line21.Name = "line21";
            this.line21.Top = 5.669291F;
            this.line21.Width = 7.244095F;
            this.line21.X1 = 0.03937008F;
            this.line21.X2 = 7.283465F;
            this.line21.Y1 = 5.669291F;
            this.line21.Y2 = 5.669291F;
            // 
            // line22
            // 
            this.line22.Border.BottomColor = System.Drawing.Color.Black;
            this.line22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line22.Border.LeftColor = System.Drawing.Color.Black;
            this.line22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line22.Border.RightColor = System.Drawing.Color.Black;
            this.line22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line22.Border.TopColor = System.Drawing.Color.Black;
            this.line22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line22.Height = 2.362205F;
            this.line22.Left = 3.543307F;
            this.line22.LineWeight = 3F;
            this.line22.Name = "line22";
            this.line22.Top = 6.141733F;
            this.line22.Width = 0F;
            this.line22.X1 = 3.543307F;
            this.line22.X2 = 3.543307F;
            this.line22.Y1 = 6.141733F;
            this.line22.Y2 = 8.503938F;
            // 
            // label25
            // 
            this.label25.Border.BottomColor = System.Drawing.Color.Black;
            this.label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label25.Border.LeftColor = System.Drawing.Color.Black;
            this.label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label25.Border.RightColor = System.Drawing.Color.Black;
            this.label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label25.Border.TopColor = System.Drawing.Color.Black;
            this.label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label25.Height = 0.1968504F;
            this.label25.HyperLink = null;
            this.label25.Left = 0.03937008F;
            this.label25.Name = "label25";
            this.label25.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label25.Text = "Водительское удостоверение проверил, задание выдал";
            this.label25.Top = 5.826772F;
            this.label25.Width = 3.425197F;
            // 
            // label26
            // 
            this.label26.Border.BottomColor = System.Drawing.Color.Black;
            this.label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label26.Border.LeftColor = System.Drawing.Color.Black;
            this.label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label26.Border.RightColor = System.Drawing.Color.Black;
            this.label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label26.Border.TopColor = System.Drawing.Color.Black;
            this.label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label26.Height = 0.1968504F;
            this.label26.HyperLink = null;
            this.label26.Left = 0.07874016F;
            this.label26.Name = "label26";
            this.label26.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label26.Text = "Водитель по состоянию здоровья к управлению допущен";
            this.label26.Top = 7.598425F;
            this.label26.Width = 3.425197F;
            // 
            // label27
            // 
            this.label27.Border.BottomColor = System.Drawing.Color.Black;
            this.label27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label27.Border.LeftColor = System.Drawing.Color.Black;
            this.label27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label27.Border.RightColor = System.Drawing.Color.Black;
            this.label27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label27.Border.TopColor = System.Drawing.Color.Black;
            this.label27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label27.Height = 0.1968505F;
            this.label27.HyperLink = null;
            this.label27.Left = 3.661417F;
            this.label27.MultiLine = false;
            this.label27.Name = "label27";
            this.label27.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label27.Text = "Механик";
            this.label27.Top = 6.614173F;
            this.label27.Width = 0.7086616F;
            // 
            // line23
            // 
            this.line23.Border.BottomColor = System.Drawing.Color.Black;
            this.line23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line23.Border.LeftColor = System.Drawing.Color.Black;
            this.line23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line23.Border.RightColor = System.Drawing.Color.Black;
            this.line23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line23.Border.TopColor = System.Drawing.Color.Black;
            this.line23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line23.Height = 0F;
            this.line23.Left = 6.102362F;
            this.line23.LineWeight = 1F;
            this.line23.Name = "line23";
            this.line23.Top = 6.771654F;
            this.line23.Width = 1.181103F;
            this.line23.X1 = 6.102362F;
            this.line23.X2 = 7.283465F;
            this.line23.Y1 = 6.771654F;
            this.line23.Y2 = 6.771654F;
            // 
            // label29
            // 
            this.label29.Border.BottomColor = System.Drawing.Color.Black;
            this.label29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label29.Border.LeftColor = System.Drawing.Color.Black;
            this.label29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label29.Border.RightColor = System.Drawing.Color.Black;
            this.label29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label29.Border.TopColor = System.Drawing.Color.Black;
            this.label29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label29.Height = 0.1968502F;
            this.label29.HyperLink = null;
            this.label29.Left = 3.661417F;
            this.label29.Name = "label29";
            this.label29.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label29.Text = "Автомобиль технически исправен";
            this.label29.Top = 6.220472F;
            this.label29.Width = 3.425197F;
            // 
            // label30
            // 
            this.label30.Border.BottomColor = System.Drawing.Color.Black;
            this.label30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label30.Border.LeftColor = System.Drawing.Color.Black;
            this.label30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label30.Border.RightColor = System.Drawing.Color.Black;
            this.label30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label30.Border.TopColor = System.Drawing.Color.Black;
            this.label30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label30.Height = 0.1968505F;
            this.label30.HyperLink = null;
            this.label30.Left = 3.661417F;
            this.label30.Name = "label30";
            this.label30.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label30.Text = "Выезд разрешен";
            this.label30.Top = 6.417323F;
            this.label30.Width = 1.299213F;
            // 
            // label31
            // 
            this.label31.Border.BottomColor = System.Drawing.Color.Black;
            this.label31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label31.Border.LeftColor = System.Drawing.Color.Black;
            this.label31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label31.Border.RightColor = System.Drawing.Color.Black;
            this.label31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label31.Border.TopColor = System.Drawing.Color.Black;
            this.label31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label31.Height = 0.1968506F;
            this.label31.HyperLink = null;
            this.label31.Left = 3.661417F;
            this.label31.Name = "label31";
            this.label31.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label31.Text = "Автомобиль принял";
            this.label31.Top = 6.811024F;
            this.label31.Width = 1.299213F;
            // 
            // label32
            // 
            this.label32.Border.BottomColor = System.Drawing.Color.Black;
            this.label32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label32.Border.LeftColor = System.Drawing.Color.Black;
            this.label32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label32.Border.RightColor = System.Drawing.Color.Black;
            this.label32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label32.Border.TopColor = System.Drawing.Color.Black;
            this.label32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label32.Height = 0.1968506F;
            this.label32.HyperLink = null;
            this.label32.Left = 3.661417F;
            this.label32.MultiLine = false;
            this.label32.Name = "label32";
            this.label32.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label32.Text = "Водитель";
            this.label32.Top = 7.007874F;
            this.label32.Width = 0.7086616F;
            // 
            // line26
            // 
            this.line26.Border.BottomColor = System.Drawing.Color.Black;
            this.line26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line26.Border.LeftColor = System.Drawing.Color.Black;
            this.line26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line26.Border.RightColor = System.Drawing.Color.Black;
            this.line26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line26.Border.TopColor = System.Drawing.Color.Black;
            this.line26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line26.Height = 0F;
            this.line26.Left = 0.07874016F;
            this.line26.LineWeight = 1F;
            this.line26.Name = "line26";
            this.line26.Top = 7.165354F;
            this.line26.Width = 1.102362F;
            this.line26.X1 = 0.07874016F;
            this.line26.X2 = 1.181102F;
            this.line26.Y1 = 7.165354F;
            this.line26.Y2 = 7.165354F;
            // 
            // label33
            // 
            this.label33.Border.BottomColor = System.Drawing.Color.Black;
            this.label33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label33.Border.LeftColor = System.Drawing.Color.Black;
            this.label33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label33.Border.RightColor = System.Drawing.Color.Black;
            this.label33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label33.Border.TopColor = System.Drawing.Color.Black;
            this.label33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label33.Height = 0.1968506F;
            this.label33.HyperLink = null;
            this.label33.Left = 3.661417F;
            this.label33.MultiLine = false;
            this.label33.Name = "label33";
            this.label33.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label33.Text = "Диспетчер";
            this.label33.Top = 5.826772F;
            this.label33.Width = 0.7874016F;
            // 
            // line27
            // 
            this.line27.Border.BottomColor = System.Drawing.Color.Black;
            this.line27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line27.Border.LeftColor = System.Drawing.Color.Black;
            this.line27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line27.Border.RightColor = System.Drawing.Color.Black;
            this.line27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line27.Border.TopColor = System.Drawing.Color.Black;
            this.line27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line27.Height = 0F;
            this.line27.Left = 0.03937008F;
            this.line27.LineWeight = 3F;
            this.line27.Name = "line27";
            this.line27.Top = 7.322834F;
            this.line27.Width = 7.244095F;
            this.line27.X1 = 0.03937008F;
            this.line27.X2 = 7.283465F;
            this.line27.Y1 = 7.322834F;
            this.line27.Y2 = 7.322834F;
            // 
            // label34
            // 
            this.label34.Border.BottomColor = System.Drawing.Color.Black;
            this.label34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label34.Border.LeftColor = System.Drawing.Color.Black;
            this.label34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label34.Border.RightColor = System.Drawing.Color.Black;
            this.label34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label34.Border.TopColor = System.Drawing.Color.Black;
            this.label34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label34.Height = 0.1968501F;
            this.label34.HyperLink = null;
            this.label34.Left = 3.661417F;
            this.label34.Name = "label34";
            this.label34.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label34.Text = "При возвращении автомобиль: исправен / неисправен";
            this.label34.Top = 7.401575F;
            this.label34.Width = 3.622047F;
            // 
            // label35
            // 
            this.label35.Border.BottomColor = System.Drawing.Color.Black;
            this.label35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label35.Border.LeftColor = System.Drawing.Color.Black;
            this.label35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label35.Border.RightColor = System.Drawing.Color.Black;
            this.label35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label35.Border.TopColor = System.Drawing.Color.Black;
            this.label35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label35.Height = 0.1968503F;
            this.label35.HyperLink = null;
            this.label35.Left = 3.661417F;
            this.label35.Name = "label35";
            this.label35.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label35.Text = "Автомобиль сдал";
            this.label35.Top = 7.598425F;
            this.label35.Width = 1.299213F;
            // 
            // label36
            // 
            this.label36.Border.BottomColor = System.Drawing.Color.Black;
            this.label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label36.Border.LeftColor = System.Drawing.Color.Black;
            this.label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label36.Border.RightColor = System.Drawing.Color.Black;
            this.label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label36.Border.TopColor = System.Drawing.Color.Black;
            this.label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label36.Height = 0.1968505F;
            this.label36.HyperLink = null;
            this.label36.Left = 3.661417F;
            this.label36.MultiLine = false;
            this.label36.Name = "label36";
            this.label36.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label36.Text = "Механик";
            this.label36.Top = 8.188976F;
            this.label36.Width = 0.7086616F;
            // 
            // label37
            // 
            this.label37.Border.BottomColor = System.Drawing.Color.Black;
            this.label37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label37.Border.LeftColor = System.Drawing.Color.Black;
            this.label37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label37.Border.RightColor = System.Drawing.Color.Black;
            this.label37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label37.Border.TopColor = System.Drawing.Color.Black;
            this.label37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label37.Height = 0.1968505F;
            this.label37.HyperLink = null;
            this.label37.Left = 3.661417F;
            this.label37.Name = "label37";
            this.label37.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label37.Text = "Автомобиль принял";
            this.label37.Top = 7.992126F;
            this.label37.Width = 1.299213F;
            // 
            // label38
            // 
            this.label38.Border.BottomColor = System.Drawing.Color.Black;
            this.label38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label38.Border.LeftColor = System.Drawing.Color.Black;
            this.label38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label38.Border.RightColor = System.Drawing.Color.Black;
            this.label38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label38.Border.TopColor = System.Drawing.Color.Black;
            this.label38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label38.Height = 0.1968503F;
            this.label38.HyperLink = null;
            this.label38.Left = 3.661417F;
            this.label38.MultiLine = false;
            this.label38.Name = "label38";
            this.label38.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label38.Text = "Водитель";
            this.label38.Top = 7.795276F;
            this.label38.Width = 0.7086616F;
            // 
            // line30
            // 
            this.line30.Border.BottomColor = System.Drawing.Color.Black;
            this.line30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Border.LeftColor = System.Drawing.Color.Black;
            this.line30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Border.RightColor = System.Drawing.Color.Black;
            this.line30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Border.TopColor = System.Drawing.Color.Black;
            this.line30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line30.Height = 0F;
            this.line30.Left = 0.03937008F;
            this.line30.LineWeight = 3F;
            this.line30.Name = "line30";
            this.line30.Top = 8.503938F;
            this.line30.Width = 7.244095F;
            this.line30.X1 = 0.03937008F;
            this.line30.X2 = 7.283465F;
            this.line30.Y1 = 8.503938F;
            this.line30.Y2 = 8.503938F;
            // 
            // label39
            // 
            this.label39.Border.BottomColor = System.Drawing.Color.Black;
            this.label39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label39.Border.LeftColor = System.Drawing.Color.Black;
            this.label39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label39.Border.RightColor = System.Drawing.Color.Black;
            this.label39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label39.Border.TopColor = System.Drawing.Color.Black;
            this.label39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label39.Height = 0.1968506F;
            this.label39.HyperLink = null;
            this.label39.Left = 0.03937008F;
            this.label39.MultiLine = false;
            this.label39.Name = "label39";
            this.label39.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-style: italic; font-size" +
                ": 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label39.Text = "Особые отметки";
            this.label39.Top = 8.661418F;
            this.label39.Width = 1.259843F;
            // 
            // line33
            // 
            this.line33.Border.BottomColor = System.Drawing.Color.Black;
            this.line33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Border.LeftColor = System.Drawing.Color.Black;
            this.line33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Border.RightColor = System.Drawing.Color.Black;
            this.line33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Border.TopColor = System.Drawing.Color.Black;
            this.line33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line33.Height = 0F;
            this.line33.Left = 0.03937008F;
            this.line33.LineWeight = 1F;
            this.line33.Name = "line33";
            this.line33.Top = 9.133859F;
            this.line33.Width = 7.244095F;
            this.line33.X1 = 0.03937008F;
            this.line33.X2 = 7.283465F;
            this.line33.Y1 = 9.133859F;
            this.line33.Y2 = 9.133859F;
            // 
            // label44
            // 
            this.label44.Border.BottomColor = System.Drawing.Color.Black;
            this.label44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label44.Border.LeftColor = System.Drawing.Color.Black;
            this.label44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label44.Border.RightColor = System.Drawing.Color.Black;
            this.label44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label44.Border.TopColor = System.Drawing.Color.Black;
            this.label44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label44.Height = 0.1181102F;
            this.label44.HyperLink = null;
            this.label44.Left = 5.314961F;
            this.label44.Name = "label44";
            this.label44.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label44.Text = "подпись";
            this.label44.Top = 6.771654F;
            this.label44.Width = 0.3937008F;
            // 
            // label45
            // 
            this.label45.Border.BottomColor = System.Drawing.Color.Black;
            this.label45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label45.Border.LeftColor = System.Drawing.Color.Black;
            this.label45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label45.Border.RightColor = System.Drawing.Color.Black;
            this.label45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label45.Border.TopColor = System.Drawing.Color.Black;
            this.label45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label45.Height = 0.1181102F;
            this.label45.HyperLink = null;
            this.label45.Left = 5.314961F;
            this.label45.Name = "label45";
            this.label45.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label45.Text = "подпись";
            this.label45.Top = 7.165354F;
            this.label45.Width = 0.3937008F;
            // 
            // line35
            // 
            this.line35.Border.BottomColor = System.Drawing.Color.Black;
            this.line35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line35.Border.LeftColor = System.Drawing.Color.Black;
            this.line35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line35.Border.RightColor = System.Drawing.Color.Black;
            this.line35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line35.Border.TopColor = System.Drawing.Color.Black;
            this.line35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line35.Height = 0F;
            this.line35.Left = 5.11811F;
            this.line35.LineWeight = 1F;
            this.line35.Name = "line35";
            this.line35.Top = 7.165354F;
            this.line35.Width = 0.7874017F;
            this.line35.X1 = 5.11811F;
            this.line35.X2 = 5.905512F;
            this.line35.Y1 = 7.165354F;
            this.line35.Y2 = 7.165354F;
            // 
            // line31
            // 
            this.line31.Border.BottomColor = System.Drawing.Color.Black;
            this.line31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line31.Border.LeftColor = System.Drawing.Color.Black;
            this.line31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line31.Border.RightColor = System.Drawing.Color.Black;
            this.line31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line31.Border.TopColor = System.Drawing.Color.Black;
            this.line31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line31.Height = 0F;
            this.line31.Left = 5.11811F;
            this.line31.LineWeight = 1F;
            this.line31.Name = "line31";
            this.line31.Top = 6.771654F;
            this.line31.Width = 0.7874017F;
            this.line31.X1 = 5.11811F;
            this.line31.X2 = 5.905512F;
            this.line31.Y1 = 6.771654F;
            this.line31.Y2 = 6.771654F;
            // 
            // label48
            // 
            this.label48.Border.BottomColor = System.Drawing.Color.Black;
            this.label48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label48.Border.LeftColor = System.Drawing.Color.Black;
            this.label48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label48.Border.RightColor = System.Drawing.Color.Black;
            this.label48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label48.Border.TopColor = System.Drawing.Color.Black;
            this.label48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label48.Height = 0.1181102F;
            this.label48.HyperLink = null;
            this.label48.Left = 6.220472F;
            this.label48.Name = "label48";
            this.label48.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label48.Text = "расшифровка подписи";
            this.label48.Top = 7.165354F;
            this.label48.Width = 0.9448819F;
            // 
            // line25
            // 
            this.line25.Border.BottomColor = System.Drawing.Color.Black;
            this.line25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line25.Border.LeftColor = System.Drawing.Color.Black;
            this.line25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line25.Border.RightColor = System.Drawing.Color.Black;
            this.line25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line25.Border.TopColor = System.Drawing.Color.Black;
            this.line25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line25.Height = 0F;
            this.line25.Left = 6.102362F;
            this.line25.LineWeight = 1F;
            this.line25.Name = "line25";
            this.line25.Top = 7.165354F;
            this.line25.Width = 1.181103F;
            this.line25.X1 = 6.102362F;
            this.line25.X2 = 7.283465F;
            this.line25.Y1 = 7.165354F;
            this.line25.Y2 = 7.165354F;
            // 
            // label7
            // 
            this.label7.Border.BottomColor = System.Drawing.Color.Black;
            this.label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.LeftColor = System.Drawing.Color.Black;
            this.label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.RightColor = System.Drawing.Color.Black;
            this.label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.TopColor = System.Drawing.Color.Black;
            this.label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Height = 0.1574803F;
            this.label7.HyperLink = null;
            this.label7.Left = 1.653543F;
            this.label7.MultiLine = false;
            this.label7.Name = "label7";
            this.label7.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 8pt; font-family:" +
                " Tahoma; white-space: nowrap; ";
            this.label7.Text = "Дата (число, месяц, год)";
            this.label7.Top = 4.370079F;
            this.label7.Width = 1.338583F;
            // 
            // label20
            // 
            this.label20.Border.BottomColor = System.Drawing.Color.Black;
            this.label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label20.Border.LeftColor = System.Drawing.Color.Black;
            this.label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label20.Border.RightColor = System.Drawing.Color.Black;
            this.label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label20.Border.TopColor = System.Drawing.Color.Black;
            this.label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label20.Height = 0.1181102F;
            this.label20.HyperLink = null;
            this.label20.Left = 6.220472F;
            this.label20.Name = "label20";
            this.label20.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label20.Text = "расшифровка подписи";
            this.label20.Top = 5.984252F;
            this.label20.Width = 0.9448819F;
            // 
            // line6
            // 
            this.line6.Border.BottomColor = System.Drawing.Color.Black;
            this.line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line6.Border.LeftColor = System.Drawing.Color.Black;
            this.line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line6.Border.RightColor = System.Drawing.Color.Black;
            this.line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line6.Border.TopColor = System.Drawing.Color.Black;
            this.line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line6.Height = 0F;
            this.line6.Left = 6.102362F;
            this.line6.LineWeight = 1F;
            this.line6.Name = "line6";
            this.line6.Top = 5.984252F;
            this.line6.Width = 1.181103F;
            this.line6.X1 = 6.102362F;
            this.line6.X2 = 7.283465F;
            this.line6.Y1 = 5.984252F;
            this.line6.Y2 = 5.984252F;
            // 
            // label21
            // 
            this.label21.Border.BottomColor = System.Drawing.Color.Black;
            this.label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label21.Border.LeftColor = System.Drawing.Color.Black;
            this.label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label21.Border.RightColor = System.Drawing.Color.Black;
            this.label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label21.Border.TopColor = System.Drawing.Color.Black;
            this.label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label21.Height = 0.1181102F;
            this.label21.HyperLink = null;
            this.label21.Left = 5.314961F;
            this.label21.Name = "label21";
            this.label21.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label21.Text = "подпись";
            this.label21.Top = 5.984252F;
            this.label21.Width = 0.3937008F;
            // 
            // line17
            // 
            this.line17.Border.BottomColor = System.Drawing.Color.Black;
            this.line17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line17.Border.LeftColor = System.Drawing.Color.Black;
            this.line17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line17.Border.RightColor = System.Drawing.Color.Black;
            this.line17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line17.Border.TopColor = System.Drawing.Color.Black;
            this.line17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line17.Height = 0F;
            this.line17.Left = 5.11811F;
            this.line17.LineWeight = 1F;
            this.line17.Name = "line17";
            this.line17.Top = 5.984252F;
            this.line17.Width = 0.7874017F;
            this.line17.X1 = 5.11811F;
            this.line17.X2 = 5.905512F;
            this.line17.Y1 = 5.984252F;
            this.line17.Y2 = 5.984252F;
            // 
            // label49
            // 
            this.label49.Border.BottomColor = System.Drawing.Color.Black;
            this.label49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label49.Border.LeftColor = System.Drawing.Color.Black;
            this.label49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label49.Border.RightColor = System.Drawing.Color.Black;
            this.label49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label49.Border.TopColor = System.Drawing.Color.Black;
            this.label49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label49.Height = 0.1968504F;
            this.label49.HyperLink = null;
            this.label49.Left = 0.07874016F;
            this.label49.Name = "label49";
            this.label49.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label49.Text = "Водитель по состоянию здоровья к управлению допущен";
            this.label49.Top = 6.417323F;
            this.label49.Width = 3.425197F;
            // 
            // label50
            // 
            this.label50.Border.BottomColor = System.Drawing.Color.Black;
            this.label50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label50.Border.LeftColor = System.Drawing.Color.Black;
            this.label50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label50.Border.RightColor = System.Drawing.Color.Black;
            this.label50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label50.Border.TopColor = System.Drawing.Color.Black;
            this.label50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label50.Height = 0.1968504F;
            this.label50.HyperLink = null;
            this.label50.Left = 0.07874016F;
            this.label50.Name = "label50";
            this.label50.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label50.Text = "Предрейсовый медицинский осмотр произведен";
            this.label50.Top = 6.220472F;
            this.label50.Width = 3.425197F;
            // 
            // label51
            // 
            this.label51.Border.BottomColor = System.Drawing.Color.Black;
            this.label51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label51.Border.LeftColor = System.Drawing.Color.Black;
            this.label51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label51.Border.RightColor = System.Drawing.Color.Black;
            this.label51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label51.Border.TopColor = System.Drawing.Color.Black;
            this.label51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label51.Height = 0.1968504F;
            this.label51.HyperLink = null;
            this.label51.Left = 0.07874016F;
            this.label51.Name = "label51";
            this.label51.Style = "color: Black; ddo-char-set: 204; font-size: 8pt; font-family: Tahoma; white-space" +
                ": inherit; ";
            this.label51.Text = "Послерейсовый медицинский осмотр произведен";
            this.label51.Top = 7.401575F;
            this.label51.Width = 3.425197F;
            // 
            // label43
            // 
            this.label43.Border.BottomColor = System.Drawing.Color.Black;
            this.label43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label43.Border.LeftColor = System.Drawing.Color.Black;
            this.label43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label43.Border.RightColor = System.Drawing.Color.Black;
            this.label43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label43.Border.TopColor = System.Drawing.Color.Black;
            this.label43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label43.Height = 0.1181102F;
            this.label43.HyperLink = null;
            this.label43.Left = 2.401575F;
            this.label43.Name = "label43";
            this.label43.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label43.Text = "расшифровка подписи";
            this.label43.Top = 7.165354F;
            this.label43.Width = 0.9448819F;
            // 
            // line32
            // 
            this.line32.Border.BottomColor = System.Drawing.Color.Black;
            this.line32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Border.LeftColor = System.Drawing.Color.Black;
            this.line32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Border.RightColor = System.Drawing.Color.Black;
            this.line32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Border.TopColor = System.Drawing.Color.Black;
            this.line32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line32.Height = 0F;
            this.line32.Left = 2.283465F;
            this.line32.LineWeight = 1F;
            this.line32.Name = "line32";
            this.line32.Top = 7.165354F;
            this.line32.Width = 1.181103F;
            this.line32.X1 = 2.283465F;
            this.line32.X2 = 3.464567F;
            this.line32.Y1 = 7.165354F;
            this.line32.Y2 = 7.165354F;
            // 
            // label52
            // 
            this.label52.Border.BottomColor = System.Drawing.Color.Black;
            this.label52.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label52.Border.LeftColor = System.Drawing.Color.Black;
            this.label52.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label52.Border.RightColor = System.Drawing.Color.Black;
            this.label52.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label52.Border.TopColor = System.Drawing.Color.Black;
            this.label52.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label52.Height = 0.1181102F;
            this.label52.HyperLink = null;
            this.label52.Left = 1.496063F;
            this.label52.Name = "label52";
            this.label52.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label52.Text = "подпись";
            this.label52.Top = 7.165354F;
            this.label52.Width = 0.3937008F;
            // 
            // line36
            // 
            this.line36.Border.BottomColor = System.Drawing.Color.Black;
            this.line36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line36.Border.LeftColor = System.Drawing.Color.Black;
            this.line36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line36.Border.RightColor = System.Drawing.Color.Black;
            this.line36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line36.Border.TopColor = System.Drawing.Color.Black;
            this.line36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line36.Height = 0F;
            this.line36.Left = 1.299213F;
            this.line36.LineWeight = 1F;
            this.line36.Name = "line36";
            this.line36.Top = 7.165354F;
            this.line36.Width = 0.7874018F;
            this.line36.X1 = 1.299213F;
            this.line36.X2 = 2.086614F;
            this.line36.Y1 = 7.165354F;
            this.line36.Y2 = 7.165354F;
            // 
            // label28
            // 
            this.label28.Border.BottomColor = System.Drawing.Color.Black;
            this.label28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label28.Border.LeftColor = System.Drawing.Color.Black;
            this.label28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label28.Border.RightColor = System.Drawing.Color.Black;
            this.label28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label28.Border.TopColor = System.Drawing.Color.Black;
            this.label28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label28.Height = 0.1181102F;
            this.label28.HyperLink = null;
            this.label28.Left = 0.3937008F;
            this.label28.Name = "label28";
            this.label28.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label28.Text = "должность";
            this.label28.Top = 8.346457F;
            this.label28.Width = 0.472441F;
            // 
            // line24
            // 
            this.line24.Border.BottomColor = System.Drawing.Color.Black;
            this.line24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line24.Border.LeftColor = System.Drawing.Color.Black;
            this.line24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line24.Border.RightColor = System.Drawing.Color.Black;
            this.line24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line24.Border.TopColor = System.Drawing.Color.Black;
            this.line24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line24.Height = 0F;
            this.line24.Left = 0.07874016F;
            this.line24.LineWeight = 1F;
            this.line24.Name = "line24";
            this.line24.Top = 8.346457F;
            this.line24.Width = 1.102362F;
            this.line24.X1 = 0.07874016F;
            this.line24.X2 = 1.181102F;
            this.line24.Y1 = 8.346457F;
            this.line24.Y2 = 8.346457F;
            // 
            // label53
            // 
            this.label53.Border.BottomColor = System.Drawing.Color.Black;
            this.label53.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label53.Border.LeftColor = System.Drawing.Color.Black;
            this.label53.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label53.Border.RightColor = System.Drawing.Color.Black;
            this.label53.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label53.Border.TopColor = System.Drawing.Color.Black;
            this.label53.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label53.Height = 0.1181102F;
            this.label53.HyperLink = null;
            this.label53.Left = 2.401575F;
            this.label53.Name = "label53";
            this.label53.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label53.Text = "расшифровка подписи";
            this.label53.Top = 8.346457F;
            this.label53.Width = 0.9448819F;
            // 
            // line37
            // 
            this.line37.Border.BottomColor = System.Drawing.Color.Black;
            this.line37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line37.Border.LeftColor = System.Drawing.Color.Black;
            this.line37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line37.Border.RightColor = System.Drawing.Color.Black;
            this.line37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line37.Border.TopColor = System.Drawing.Color.Black;
            this.line37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line37.Height = 0F;
            this.line37.Left = 2.283465F;
            this.line37.LineWeight = 1F;
            this.line37.Name = "line37";
            this.line37.Top = 8.346457F;
            this.line37.Width = 1.181103F;
            this.line37.X1 = 2.283465F;
            this.line37.X2 = 3.464567F;
            this.line37.Y1 = 8.346457F;
            this.line37.Y2 = 8.346457F;
            // 
            // label54
            // 
            this.label54.Border.BottomColor = System.Drawing.Color.Black;
            this.label54.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label54.Border.LeftColor = System.Drawing.Color.Black;
            this.label54.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label54.Border.RightColor = System.Drawing.Color.Black;
            this.label54.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label54.Border.TopColor = System.Drawing.Color.Black;
            this.label54.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label54.Height = 0.1181102F;
            this.label54.HyperLink = null;
            this.label54.Left = 1.496063F;
            this.label54.Name = "label54";
            this.label54.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label54.Text = "подпись";
            this.label54.Top = 8.346457F;
            this.label54.Width = 0.3937008F;
            // 
            // line38
            // 
            this.line38.Border.BottomColor = System.Drawing.Color.Black;
            this.line38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line38.Border.LeftColor = System.Drawing.Color.Black;
            this.line38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line38.Border.RightColor = System.Drawing.Color.Black;
            this.line38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line38.Border.TopColor = System.Drawing.Color.Black;
            this.line38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line38.Height = 0F;
            this.line38.Left = 1.299213F;
            this.line38.LineWeight = 1F;
            this.line38.Name = "line38";
            this.line38.Top = 8.346457F;
            this.line38.Width = 0.7874018F;
            this.line38.X1 = 1.299213F;
            this.line38.X2 = 2.086614F;
            this.line38.Y1 = 8.346457F;
            this.line38.Y2 = 8.346457F;
            // 
            // label55
            // 
            this.label55.Border.BottomColor = System.Drawing.Color.Black;
            this.label55.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label55.Border.LeftColor = System.Drawing.Color.Black;
            this.label55.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label55.Border.RightColor = System.Drawing.Color.Black;
            this.label55.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label55.Border.TopColor = System.Drawing.Color.Black;
            this.label55.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label55.Height = 0.1181102F;
            this.label55.HyperLink = null;
            this.label55.Left = 5.314961F;
            this.label55.Name = "label55";
            this.label55.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label55.Text = "подпись";
            this.label55.Top = 8.346457F;
            this.label55.Width = 0.3937008F;
            // 
            // line28
            // 
            this.line28.Border.BottomColor = System.Drawing.Color.Black;
            this.line28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Border.LeftColor = System.Drawing.Color.Black;
            this.line28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Border.RightColor = System.Drawing.Color.Black;
            this.line28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Border.TopColor = System.Drawing.Color.Black;
            this.line28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line28.Height = 0F;
            this.line28.Left = 6.102362F;
            this.line28.LineWeight = 1F;
            this.line28.Name = "line28";
            this.line28.Top = 7.952756F;
            this.line28.Width = 1.181103F;
            this.line28.X1 = 6.102362F;
            this.line28.X2 = 7.283465F;
            this.line28.Y1 = 7.952756F;
            this.line28.Y2 = 7.952756F;
            // 
            // label56
            // 
            this.label56.Border.BottomColor = System.Drawing.Color.Black;
            this.label56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label56.Border.LeftColor = System.Drawing.Color.Black;
            this.label56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label56.Border.RightColor = System.Drawing.Color.Black;
            this.label56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label56.Border.TopColor = System.Drawing.Color.Black;
            this.label56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label56.Height = 0.1181102F;
            this.label56.HyperLink = null;
            this.label56.Left = 6.220472F;
            this.label56.Name = "label56";
            this.label56.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label56.Text = "расшифровка подписи";
            this.label56.Top = 8.346457F;
            this.label56.Width = 0.9448819F;
            // 
            // line29
            // 
            this.line29.Border.BottomColor = System.Drawing.Color.Black;
            this.line29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line29.Border.LeftColor = System.Drawing.Color.Black;
            this.line29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line29.Border.RightColor = System.Drawing.Color.Black;
            this.line29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line29.Border.TopColor = System.Drawing.Color.Black;
            this.line29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line29.Height = 0F;
            this.line29.Left = 6.102362F;
            this.line29.LineWeight = 1F;
            this.line29.Name = "line29";
            this.line29.Top = 8.346457F;
            this.line29.Width = 1.181103F;
            this.line29.X1 = 6.102362F;
            this.line29.X2 = 7.283465F;
            this.line29.Y1 = 8.346457F;
            this.line29.Y2 = 8.346457F;
            // 
            // line39
            // 
            this.line39.Border.BottomColor = System.Drawing.Color.Black;
            this.line39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line39.Border.LeftColor = System.Drawing.Color.Black;
            this.line39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line39.Border.RightColor = System.Drawing.Color.Black;
            this.line39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line39.Border.TopColor = System.Drawing.Color.Black;
            this.line39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line39.Height = 0F;
            this.line39.Left = 5.11811F;
            this.line39.LineWeight = 1F;
            this.line39.Name = "line39";
            this.line39.Top = 8.346457F;
            this.line39.Width = 0.7874017F;
            this.line39.X1 = 5.11811F;
            this.line39.X2 = 5.905512F;
            this.line39.Y1 = 8.346457F;
            this.line39.Y2 = 8.346457F;
            // 
            // label58
            // 
            this.label58.Border.BottomColor = System.Drawing.Color.Black;
            this.label58.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label58.Border.LeftColor = System.Drawing.Color.Black;
            this.label58.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label58.Border.RightColor = System.Drawing.Color.Black;
            this.label58.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label58.Border.TopColor = System.Drawing.Color.Black;
            this.label58.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label58.Height = 0.1181102F;
            this.label58.HyperLink = null;
            this.label58.Left = 5.314961F;
            this.label58.Name = "label58";
            this.label58.Style = "color: Black; ddo-char-set: 204; text-align: center; font-size: 6pt; font-family:" +
                " Tahoma; white-space: inherit; ";
            this.label58.Text = "подпись";
            this.label58.Top = 7.952756F;
            this.label58.Width = 0.3937008F;
            // 
            // line40
            // 
            this.line40.Border.BottomColor = System.Drawing.Color.Black;
            this.line40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line40.Border.LeftColor = System.Drawing.Color.Black;
            this.line40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line40.Border.RightColor = System.Drawing.Color.Black;
            this.line40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line40.Border.TopColor = System.Drawing.Color.Black;
            this.line40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line40.Height = 0F;
            this.line40.Left = 5.11811F;
            this.line40.LineWeight = 1F;
            this.line40.Name = "line40";
            this.line40.Top = 7.952756F;
            this.line40.Width = 0.7874017F;
            this.line40.X1 = 5.11811F;
            this.line40.X2 = 5.905512F;
            this.line40.Y1 = 7.952756F;
            this.line40.Y2 = 7.952756F;
            // 
            // line41
            // 
            this.line41.Border.BottomColor = System.Drawing.Color.Black;
            this.line41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line41.Border.LeftColor = System.Drawing.Color.Black;
            this.line41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line41.Border.RightColor = System.Drawing.Color.Black;
            this.line41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line41.Border.TopColor = System.Drawing.Color.Black;
            this.line41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line41.Height = 0F;
            this.line41.Left = 0.03937008F;
            this.line41.LineWeight = 3F;
            this.line41.Name = "line41";
            this.line41.Top = 6.141733F;
            this.line41.Width = 7.244095F;
            this.line41.X1 = 0.03937008F;
            this.line41.X2 = 7.283465F;
            this.line41.Y1 = 6.141733F;
            this.line41.Y2 = 6.141733F;
            // 
            // line42
            // 
            this.line42.Border.BottomColor = System.Drawing.Color.Black;
            this.line42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line42.Border.LeftColor = System.Drawing.Color.Black;
            this.line42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line42.Border.RightColor = System.Drawing.Color.Black;
            this.line42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line42.Border.TopColor = System.Drawing.Color.Black;
            this.line42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line42.Height = 0F;
            this.line42.Left = 0.03937008F;
            this.line42.LineWeight = 1F;
            this.line42.Name = "line42";
            this.line42.Top = 9.448819F;
            this.line42.Width = 7.244095F;
            this.line42.X1 = 0.03937008F;
            this.line42.X2 = 7.283465F;
            this.line42.Y1 = 9.448819F;
            this.line42.Y2 = 9.448819F;
            // 
            // line43
            // 
            this.line43.Border.BottomColor = System.Drawing.Color.Black;
            this.line43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line43.Border.LeftColor = System.Drawing.Color.Black;
            this.line43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line43.Border.RightColor = System.Drawing.Color.Black;
            this.line43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line43.Border.TopColor = System.Drawing.Color.Black;
            this.line43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line43.Height = 0F;
            this.line43.Left = 1.377953F;
            this.line43.LineWeight = 1F;
            this.line43.Name = "line43";
            this.line43.Top = 8.818898F;
            this.line43.Width = 5.905512F;
            this.line43.X1 = 1.377953F;
            this.line43.X2 = 7.283465F;
            this.line43.Y1 = 8.818898F;
            this.line43.Y2 = 8.818898F;
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0F;
            this.PageFooter.Name = "PageFooter";
            // 
            // label9
            // 
            this.label9.Border.BottomColor = System.Drawing.Color.Black;
            this.label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.LeftColor = System.Drawing.Color.Black;
            this.label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.RightColor = System.Drawing.Color.Black;
            this.label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.TopColor = System.Drawing.Color.Black;
            this.label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Height = 0.1968503F;
            this.label9.HyperLink = null;
            this.label9.Left = 0.03937008F;
            this.label9.MultiLine = false;
            this.label9.Name = "label9";
            this.label9.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label9.Text = "Пробег";
            this.label9.Top = 3.622047F;
            this.label9.Width = 0.511811F;
            // 
            // line8
            // 
            this.line8.Border.BottomColor = System.Drawing.Color.Black;
            this.line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line8.Border.LeftColor = System.Drawing.Color.Black;
            this.line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line8.Border.RightColor = System.Drawing.Color.Black;
            this.line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line8.Border.TopColor = System.Drawing.Color.Black;
            this.line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line8.Height = 0F;
            this.line8.Left = 0.6299213F;
            this.line8.LineWeight = 1F;
            this.line8.Name = "line8";
            this.line8.Top = 3.779528F;
            this.line8.Width = 0.7874015F;
            this.line8.X1 = 0.6299213F;
            this.line8.X2 = 1.417323F;
            this.line8.Y1 = 3.779528F;
            this.line8.Y2 = 3.779528F;
            // 
            // label41
            // 
            this.label41.Border.BottomColor = System.Drawing.Color.Black;
            this.label41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label41.Border.LeftColor = System.Drawing.Color.Black;
            this.label41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label41.Border.RightColor = System.Drawing.Color.Black;
            this.label41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label41.Border.TopColor = System.Drawing.Color.Black;
            this.label41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label41.Height = 0.1968503F;
            this.label41.HyperLink = null;
            this.label41.Left = 1.968504F;
            this.label41.MultiLine = false;
            this.label41.Name = "label41";
            this.label41.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label41.Text = "Расход топлива";
            this.label41.Top = 3.622047F;
            this.label41.Width = 1.102362F;
            // 
            // line44
            // 
            this.line44.Border.BottomColor = System.Drawing.Color.Black;
            this.line44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line44.Border.LeftColor = System.Drawing.Color.Black;
            this.line44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line44.Border.RightColor = System.Drawing.Color.Black;
            this.line44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line44.Border.TopColor = System.Drawing.Color.Black;
            this.line44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line44.Height = 0F;
            this.line44.Left = 3.149606F;
            this.line44.LineWeight = 1F;
            this.line44.Name = "line44";
            this.line44.Top = 3.779528F;
            this.line44.Width = 0.7874014F;
            this.line44.X1 = 3.149606F;
            this.line44.X2 = 3.937008F;
            this.line44.Y1 = 3.779528F;
            this.line44.Y2 = 3.779528F;
            // 
            // label60
            // 
            this.label60.Border.BottomColor = System.Drawing.Color.Black;
            this.label60.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label60.Border.LeftColor = System.Drawing.Color.Black;
            this.label60.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label60.Border.RightColor = System.Drawing.Color.Black;
            this.label60.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label60.Border.TopColor = System.Drawing.Color.Black;
            this.label60.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label60.Height = 0.1968503F;
            this.label60.HyperLink = null;
            this.label60.Left = 4.448819F;
            this.label60.MultiLine = false;
            this.label60.Name = "label60";
            this.label60.Style = "color: Black; ddo-char-set: 204; font-weight: bold; font-size: 9pt; font-family: " +
                "Tahoma; white-space: nowrap; ";
            this.label60.Text = "Время работы хол. уст-ки, ч";
            this.label60.Top = 3.622047F;
            this.label60.Width = 1.968504F;
            // 
            // line45
            // 
            this.line45.Border.BottomColor = System.Drawing.Color.Black;
            this.line45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line45.Border.LeftColor = System.Drawing.Color.Black;
            this.line45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line45.Border.RightColor = System.Drawing.Color.Black;
            this.line45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line45.Border.TopColor = System.Drawing.Color.Black;
            this.line45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line45.Height = 0F;
            this.line45.Left = 6.496063F;
            this.line45.LineWeight = 1F;
            this.line45.Name = "line45";
            this.line45.Top = 3.779528F;
            this.line45.Width = 0.7874017F;
            this.line45.X1 = 6.496063F;
            this.line45.X2 = 7.283465F;
            this.line45.Y1 = 3.779528F;
            this.line45.Y2 = 3.779528F;
            // 
            // WayBillShort
            // 
            this.PageSettings.Margins.Bottom = 0.3937008F;
            this.PageSettings.Margins.Left = 0.3937008F;
            this.PageSettings.Margins.Right = 0.3937008F;
            this.PageSettings.Margins.Top = 0.3937008F;
            this.PageSettings.PaperHeight = 11.69F;
            this.PageSettings.PaperWidth = 8.27F;
            this.PrintWidth = 7.357529F;
            this.Sections.Add(this.PageHeader);
            this.Sections.Add(this.Detail);
            this.Sections.Add(this.PageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBillNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWeAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbWePhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail06)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDetail08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCarModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCarNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDriverName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeedometerDataBeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuelDataBeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDriverLicenceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFuelTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbAddressForStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
	private DataDynamics.ActiveReports.TextBox tbSpeedometerDataBeg;
    private DataDynamics.ActiveReports.TextBox tbFuelDataBeg;
    private DataDynamics.ActiveReports.Label label2;
    private DataDynamics.ActiveReports.TextBox tbDriverLicenceNumber;
    private DataDynamics.ActiveReports.Line line1;
    private DataDynamics.ActiveReports.Line line2;
    private DataDynamics.ActiveReports.Shape shape1;
    private DataDynamics.ActiveReports.Line line3;
    private DataDynamics.ActiveReports.Line line4;
    private DataDynamics.ActiveReports.Label label4;
    private DataDynamics.ActiveReports.Label label5;
    private DataDynamics.ActiveReports.Line line5;
    private DataDynamics.ActiveReports.Line line7;
    private DataDynamics.ActiveReports.Line line9;
    private DataDynamics.ActiveReports.Label label6;
    private DataDynamics.ActiveReports.Label label8;
    private DataDynamics.ActiveReports.Label label10;
    private DataDynamics.ActiveReports.Line line10;
    private DataDynamics.ActiveReports.Line line11;
    private DataDynamics.ActiveReports.Label label11;
    private DataDynamics.ActiveReports.Label label12;
    private DataDynamics.ActiveReports.Label label13;
    private DataDynamics.ActiveReports.TextBox tbFuelTypeName;
    private DataDynamics.ActiveReports.Label label14;
    private DataDynamics.ActiveReports.Label label15;
    private DataDynamics.ActiveReports.Label label3;
    private DataDynamics.ActiveReports.Label label16;
    private DataDynamics.ActiveReports.Label label17;
    private DataDynamics.ActiveReports.TextBox tbAddressForStart;
    private DataDynamics.ActiveReports.TextBox tbReason;
    private DataDynamics.ActiveReports.Line line12;
    private DataDynamics.ActiveReports.Shape shape2;
    private DataDynamics.ActiveReports.Line line13;
    private DataDynamics.ActiveReports.Line line14;
    private DataDynamics.ActiveReports.Line line15;
    private DataDynamics.ActiveReports.Label label1;
    private DataDynamics.ActiveReports.Label label18;
    private DataDynamics.ActiveReports.Label label19;
    private DataDynamics.ActiveReports.Line line16;
    private DataDynamics.ActiveReports.Line line18;
    private DataDynamics.ActiveReports.Line line19;
    private DataDynamics.ActiveReports.Line line20;
    private DataDynamics.ActiveReports.Label label22;
    private DataDynamics.ActiveReports.Label label23;
    private DataDynamics.ActiveReports.Label label24;
    private DataDynamics.ActiveReports.Line line21;
    private DataDynamics.ActiveReports.Line line22;
    private DataDynamics.ActiveReports.Label label25;
    private DataDynamics.ActiveReports.Label label26;
    private DataDynamics.ActiveReports.Label label27;
    private DataDynamics.ActiveReports.Label label29;
    private DataDynamics.ActiveReports.Label label30;
    private DataDynamics.ActiveReports.Label label31;
    private DataDynamics.ActiveReports.Label label32;
    private DataDynamics.ActiveReports.Line line26;
    private DataDynamics.ActiveReports.Label label33;
    private DataDynamics.ActiveReports.Line line27;
    private DataDynamics.ActiveReports.Label label34;
    private DataDynamics.ActiveReports.Label label35;
    private DataDynamics.ActiveReports.Label label36;
    private DataDynamics.ActiveReports.Label label37;
    private DataDynamics.ActiveReports.Label label38;
    private DataDynamics.ActiveReports.Line line30;
    private DataDynamics.ActiveReports.Label label39;
    private DataDynamics.ActiveReports.Line line33;
    private DataDynamics.ActiveReports.Label tbWeAddress;
    private DataDynamics.ActiveReports.Label label40;
    private DataDynamics.ActiveReports.Label label42;
    private DataDynamics.ActiveReports.Label label46;
    private DataDynamics.ActiveReports.Label label7;
    private DataDynamics.ActiveReports.Label label20;
    private DataDynamics.ActiveReports.Line line6;
    private DataDynamics.ActiveReports.Label label21;
    private DataDynamics.ActiveReports.Line line17;
    private DataDynamics.ActiveReports.Label label49;
    private DataDynamics.ActiveReports.Label label50;
    private DataDynamics.ActiveReports.Label label51;
    private DataDynamics.ActiveReports.Label label43;
    private DataDynamics.ActiveReports.Line line32;
    private DataDynamics.ActiveReports.Label label52;
    private DataDynamics.ActiveReports.Line line36;
    private DataDynamics.ActiveReports.Label label47;
    private DataDynamics.ActiveReports.Line line23;
    private DataDynamics.ActiveReports.Label label44;
    private DataDynamics.ActiveReports.Label label45;
    private DataDynamics.ActiveReports.Line line35;
    private DataDynamics.ActiveReports.Line line31;
    private DataDynamics.ActiveReports.Label label48;
    private DataDynamics.ActiveReports.Line line25;
    private DataDynamics.ActiveReports.Label label28;
    private DataDynamics.ActiveReports.Line line24;
    private DataDynamics.ActiveReports.Label label53;
    private DataDynamics.ActiveReports.Line line37;
    private DataDynamics.ActiveReports.Label label54;
    private DataDynamics.ActiveReports.Line line38;
    private DataDynamics.ActiveReports.Label label55;
    private DataDynamics.ActiveReports.Line line28;
    private DataDynamics.ActiveReports.Label label56;
    private DataDynamics.ActiveReports.Line line29;
    private DataDynamics.ActiveReports.Line line39;
    private DataDynamics.ActiveReports.Label label57;
    private DataDynamics.ActiveReports.Label label58;
    private DataDynamics.ActiveReports.Line line40;
    private DataDynamics.ActiveReports.Line line41;
    private DataDynamics.ActiveReports.Line line42;
    private DataDynamics.ActiveReports.Label label59;
    private DataDynamics.ActiveReports.Label tbWePhone;
    private DataDynamics.ActiveReports.Line line43;
    private DataDynamics.ActiveReports.Label label9;
    private DataDynamics.ActiveReports.Line line8;
    private DataDynamics.ActiveReports.Label label41;
    private DataDynamics.ActiveReports.Line line44;
    private DataDynamics.ActiveReports.Label label60;
    private DataDynamics.ActiveReports.Line line45;
	}
}