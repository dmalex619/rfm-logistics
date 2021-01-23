namespace Logistics
{	partial class TransportBill
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
	private DataDynamics.ActiveReports.GroupHeader GroupHeader1;
	private DataDynamics.ActiveReports.Detail Detail;
		private DataDynamics.ActiveReports.GroupFooter GroupFooter1;
		private DataDynamics.ActiveReports.PageFooter PageFooter;

		// declare elements
    private DataDynamics.ActiveReports.Label lblGroupHeader101;

		// init report components
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TransportBill));
            this.PageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.GroupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.lblGroupHeader101 = new DataDynamics.ActiveReports.Label();
            this.label31 = new DataDynamics.ActiveReports.Label();
            this.label87 = new DataDynamics.ActiveReports.Label();
            this.label88 = new DataDynamics.ActiveReports.Label();
            this.txtHeaderOrderNumbersList = new DataDynamics.ActiveReports.TextBox();
            this.txtHeaderFactureNumbersList = new DataDynamics.ActiveReports.TextBox();
            this.txtBillNumber = new DataDynamics.ActiveReports.TextBox();
            this.txtDateOutput = new DataDynamics.ActiveReports.TextBox();
            this.Detail = new DataDynamics.ActiveReports.Detail();
            this.txtCurrentUserName1 = new DataDynamics.ActiveReports.TextBox();
            this.label81 = new DataDynamics.ActiveReports.Label();
            this.label80 = new DataDynamics.ActiveReports.Label();
            this.label24 = new DataDynamics.ActiveReports.Label();
            this.label25 = new DataDynamics.ActiveReports.Label();
            this.line17 = new DataDynamics.ActiveReports.Line();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.Дата = new DataDynamics.ActiveReports.Label();
            this.label32 = new DataDynamics.ActiveReports.Label();
            this.line18 = new DataDynamics.ActiveReports.Line();
            this.txtShipperInfo = new DataDynamics.ActiveReports.TextBox();
            this.txtConsigneeInfo = new DataDynamics.ActiveReports.TextBox();
            this.label33 = new DataDynamics.ActiveReports.Label();
            this.txtGoodName = new DataDynamics.ActiveReports.TextBox();
            this.txtBoxesWords = new DataDynamics.ActiveReports.TextBox();
            this.txtNettoBrutto = new DataDynamics.ActiveReports.TextBox();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.txtDocuments = new DataDynamics.ActiveReports.TextBox();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.txtDirections1 = new DataDynamics.ActiveReports.TextBox();
            this.txtDirections2 = new DataDynamics.ActiveReports.TextBox();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.txtPointCharge = new DataDynamics.ActiveReports.TextBox();
            this.txtChargeData = new DataDynamics.ActiveReports.TextBox();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.txtDischargeData = new DataDynamics.ActiveReports.TextBox();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.txtPointDischarge = new DataDynamics.ActiveReports.TextBox();
            this.txtChargeStamp = new DataDynamics.ActiveReports.TextBox();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.label11 = new DataDynamics.ActiveReports.Label();
            this.label12 = new DataDynamics.ActiveReports.Label();
            this.label13 = new DataDynamics.ActiveReports.Label();
            this.label14 = new DataDynamics.ActiveReports.Label();
            this.label15 = new DataDynamics.ActiveReports.Label();
            this.label16 = new DataDynamics.ActiveReports.Label();
            this.label17 = new DataDynamics.ActiveReports.Label();
            this.label18 = new DataDynamics.ActiveReports.Label();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.label19 = new DataDynamics.ActiveReports.Label();
            this.line2 = new DataDynamics.ActiveReports.Line();
            this.label20 = new DataDynamics.ActiveReports.Label();
            this.line3 = new DataDynamics.ActiveReports.Line();
            this.label21 = new DataDynamics.ActiveReports.Label();
            this.line4 = new DataDynamics.ActiveReports.Line();
            this.label22 = new DataDynamics.ActiveReports.Label();
            this.line5 = new DataDynamics.ActiveReports.Line();
            this.label23 = new DataDynamics.ActiveReports.Label();
            this.line6 = new DataDynamics.ActiveReports.Line();
            this.label26 = new DataDynamics.ActiveReports.Label();
            this.line7 = new DataDynamics.ActiveReports.Line();
            this.label27 = new DataDynamics.ActiveReports.Label();
            this.line8 = new DataDynamics.ActiveReports.Line();
            this.label28 = new DataDynamics.ActiveReports.Label();
            this.label29 = new DataDynamics.ActiveReports.Label();
            this.line10 = new DataDynamics.ActiveReports.Line();
            this.label30 = new DataDynamics.ActiveReports.Label();
            this.label34 = new DataDynamics.ActiveReports.Label();
            this.line11 = new DataDynamics.ActiveReports.Line();
            this.label35 = new DataDynamics.ActiveReports.Label();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.label36 = new DataDynamics.ActiveReports.Label();
            this.label37 = new DataDynamics.ActiveReports.Label();
            this.line12 = new DataDynamics.ActiveReports.Line();
            this.line9 = new DataDynamics.ActiveReports.Line();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.line13 = new DataDynamics.ActiveReports.Line();
            this.label38 = new DataDynamics.ActiveReports.Label();
            this.line14 = new DataDynamics.ActiveReports.Line();
            this.label39 = new DataDynamics.ActiveReports.Label();
            this.line15 = new DataDynamics.ActiveReports.Line();
            this.label40 = new DataDynamics.ActiveReports.Label();
            this.line16 = new DataDynamics.ActiveReports.Line();
            this.label41 = new DataDynamics.ActiveReports.Label();
            this.line19 = new DataDynamics.ActiveReports.Line();
            this.label42 = new DataDynamics.ActiveReports.Label();
            this.line20 = new DataDynamics.ActiveReports.Line();
            this.label43 = new DataDynamics.ActiveReports.Label();
            this.line21 = new DataDynamics.ActiveReports.Line();
            this.label44 = new DataDynamics.ActiveReports.Label();
            this.line22 = new DataDynamics.ActiveReports.Line();
            this.label45 = new DataDynamics.ActiveReports.Label();
            this.label46 = new DataDynamics.ActiveReports.Label();
            this.label47 = new DataDynamics.ActiveReports.Label();
            this.txtOrganizationInfo = new DataDynamics.ActiveReports.TextBox();
            this.label48 = new DataDynamics.ActiveReports.Label();
            this.line23 = new DataDynamics.ActiveReports.Line();
            this.txtDriverName = new DataDynamics.ActiveReports.TextBox();
            this.label49 = new DataDynamics.ActiveReports.Label();
            this.line24 = new DataDynamics.ActiveReports.Line();
            this.label51 = new DataDynamics.ActiveReports.Label();
            this.line25 = new DataDynamics.ActiveReports.Line();
            this.label50 = new DataDynamics.ActiveReports.Label();
            this.txtCarInfo = new DataDynamics.ActiveReports.TextBox();
            this.label52 = new DataDynamics.ActiveReports.Label();
            this.line26 = new DataDynamics.ActiveReports.Line();
            this.label53 = new DataDynamics.ActiveReports.Label();
            this.line27 = new DataDynamics.ActiveReports.Line();
            this.label54 = new DataDynamics.ActiveReports.Label();
            this.label55 = new DataDynamics.ActiveReports.Label();
            this.label56 = new DataDynamics.ActiveReports.Label();
            this.label57 = new DataDynamics.ActiveReports.Label();
            this.line28 = new DataDynamics.ActiveReports.Line();
            this.label58 = new DataDynamics.ActiveReports.Label();
            this.label59 = new DataDynamics.ActiveReports.Label();
            this.label60 = new DataDynamics.ActiveReports.Label();
            this.label61 = new DataDynamics.ActiveReports.Label();
            this.line29 = new DataDynamics.ActiveReports.Line();
            this.label62 = new DataDynamics.ActiveReports.Label();
            this.label63 = new DataDynamics.ActiveReports.Label();
            this.line30 = new DataDynamics.ActiveReports.Line();
            this.label64 = new DataDynamics.ActiveReports.Label();
            this.line31 = new DataDynamics.ActiveReports.Line();
            this.label65 = new DataDynamics.ActiveReports.Label();
            this.txtReAddressing = new DataDynamics.ActiveReports.TextBox();
            this.label66 = new DataDynamics.ActiveReports.Label();
            this.line32 = new DataDynamics.ActiveReports.Line();
            this.label67 = new DataDynamics.ActiveReports.Label();
            this.label68 = new DataDynamics.ActiveReports.Label();
            this.label69 = new DataDynamics.ActiveReports.Label();
            this.line33 = new DataDynamics.ActiveReports.Line();
            this.label70 = new DataDynamics.ActiveReports.Label();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.label71 = new DataDynamics.ActiveReports.Label();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.label72 = new DataDynamics.ActiveReports.Label();
            this.line34 = new DataDynamics.ActiveReports.Line();
            this.line35 = new DataDynamics.ActiveReports.Line();
            this.label73 = new DataDynamics.ActiveReports.Label();
            this.line36 = new DataDynamics.ActiveReports.Line();
            this.line37 = new DataDynamics.ActiveReports.Line();
            this.line38 = new DataDynamics.ActiveReports.Line();
            this.line39 = new DataDynamics.ActiveReports.Line();
            this.line40 = new DataDynamics.ActiveReports.Line();
            this.line41 = new DataDynamics.ActiveReports.Line();
            this.line42 = new DataDynamics.ActiveReports.Line();
            this.label74 = new DataDynamics.ActiveReports.Label();
            this.label75 = new DataDynamics.ActiveReports.Label();
            this.label76 = new DataDynamics.ActiveReports.Label();
            this.label77 = new DataDynamics.ActiveReports.Label();
            this.label78 = new DataDynamics.ActiveReports.Label();
            this.line43 = new DataDynamics.ActiveReports.Line();
            this.line44 = new DataDynamics.ActiveReports.Line();
            this.label79 = new DataDynamics.ActiveReports.Label();
            this.line45 = new DataDynamics.ActiveReports.Line();
            this.line46 = new DataDynamics.ActiveReports.Line();
            this.label82 = new DataDynamics.ActiveReports.Label();
            this.label83 = new DataDynamics.ActiveReports.Label();
            this.label84 = new DataDynamics.ActiveReports.Label();
            this.line47 = new DataDynamics.ActiveReports.Line();
            this.line48 = new DataDynamics.ActiveReports.Line();
            this.label85 = new DataDynamics.ActiveReports.Label();
            this.label86 = new DataDynamics.ActiveReports.Label();
            this.line49 = new DataDynamics.ActiveReports.Line();
            this.txtCurrentUserName2 = new DataDynamics.ActiveReports.TextBox();
            this.GroupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.PageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.lblGroupHeader101)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label87)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label88)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderOrderNumbersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderFactureNumbersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentUserName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label81)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label80)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Дата)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipperInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsigneeInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxesWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNettoBrutto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirections1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirections2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDischargeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointDischarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeStamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrganizationInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDriverName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label49)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label51)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label52)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label53)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label54)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label55)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label56)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label57)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label58)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label59)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label63)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label64)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label65)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReAddressing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label66)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label67)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label68)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label69)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label70)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label72)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label73)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label74)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label75)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label76)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label77)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label78)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label79)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label82)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label83)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label84)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label85)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label86)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentUserName2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.ColumnGroupKeepTogether = true;
            this.GroupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblGroupHeader101,
            this.label31,
            this.label87,
            this.label88,
            this.txtHeaderOrderNumbersList,
            this.txtHeaderFactureNumbersList});
            this.GroupHeader1.DataField = "IDList";
            this.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.FirstDetail;
            this.GroupHeader1.Height = 0.8661417F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.NewPage = DataDynamics.ActiveReports.NewPage.Before;
            this.GroupHeader1.Tag = "";
            // 
            // lblGroupHeader101
            // 
            this.lblGroupHeader101.Border.BottomColor = System.Drawing.Color.Black;
            this.lblGroupHeader101.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblGroupHeader101.Border.LeftColor = System.Drawing.Color.Black;
            this.lblGroupHeader101.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblGroupHeader101.Border.RightColor = System.Drawing.Color.Black;
            this.lblGroupHeader101.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblGroupHeader101.Border.TopColor = System.Drawing.Color.Black;
            this.lblGroupHeader101.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblGroupHeader101.Height = 0.1968504F;
            this.lblGroupHeader101.HyperLink = null;
            this.lblGroupHeader101.Left = 2.283465F;
            this.lblGroupHeader101.MultiLine = false;
            this.lblGroupHeader101.Name = "lblGroupHeader101";
            this.lblGroupHeader101.Style = "color: Black; ddo-char-set: 204; text-align: center; font-weight: bold; font-size" +
    ": 12pt; font-family: Tahoma; white-space: nowrap; ";
            this.lblGroupHeader101.Text = "ТРАНСПОРТНАЯ НАКЛАДНАЯ";
            this.lblGroupHeader101.Top = 0.6299213F;
            this.lblGroupHeader101.Width = 3.149606F;
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
            this.label31.Height = 0.1181102F;
            this.label31.HyperLink = null;
            this.label31.Left = 4.606299F;
            this.label31.MultiLine = false;
            this.label31.Name = "label31";
            this.label31.Style = "color: Black; ddo-char-set: 204; text-align: right; font-style: normal; font-size" +
    ": 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label31.Text = "Приложение № 4 к Правилам перевозок грузов автомобильным транспортом";
            this.label31.Top = 0.03937008F;
            this.label31.Width = 3.031496F;
            // 
            // label87
            // 
            this.label87.Border.BottomColor = System.Drawing.Color.Black;
            this.label87.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label87.Border.LeftColor = System.Drawing.Color.Black;
            this.label87.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label87.Border.RightColor = System.Drawing.Color.Black;
            this.label87.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label87.Border.TopColor = System.Drawing.Color.Black;
            this.label87.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label87.Height = 0.1968504F;
            this.label87.HyperLink = "";
            this.label87.Left = 0.07874016F;
            this.label87.MultiLine = false;
            this.label87.Name = "label87";
            this.label87.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
    "10.2pt; font-family: Tahoma; white-space: nowrap; ";
            this.label87.Text = "НОМЕР ЗАКАЗА";
            this.label87.Top = 0.1574803F;
            this.label87.Width = 1.259843F;
            // 
            // label88
            // 
            this.label88.Border.BottomColor = System.Drawing.Color.Black;
            this.label88.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label88.Border.LeftColor = System.Drawing.Color.Black;
            this.label88.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label88.Border.RightColor = System.Drawing.Color.Black;
            this.label88.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label88.Border.TopColor = System.Drawing.Color.Black;
            this.label88.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label88.Height = 0.1968504F;
            this.label88.HyperLink = "";
            this.label88.Left = 0.07874016F;
            this.label88.MultiLine = false;
            this.label88.Name = "label88";
            this.label88.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
    "10.2pt; font-family: Tahoma; white-space: nowrap; ";
            this.label88.Text = "НОМЕР УПД/С-Ф";
            this.label88.Top = 0.3937008F;
            this.label88.Width = 1.259843F;
            // 
            // txtHeaderOrderNumbersList
            // 
            this.txtHeaderOrderNumbersList.Border.BottomColor = System.Drawing.Color.Black;
            this.txtHeaderOrderNumbersList.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderOrderNumbersList.Border.LeftColor = System.Drawing.Color.Black;
            this.txtHeaderOrderNumbersList.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderOrderNumbersList.Border.RightColor = System.Drawing.Color.Black;
            this.txtHeaderOrderNumbersList.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderOrderNumbersList.Border.TopColor = System.Drawing.Color.Black;
            this.txtHeaderOrderNumbersList.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderOrderNumbersList.DataField = "HeaderOrderNumbersList";
            this.txtHeaderOrderNumbersList.Height = 0.1968504F;
            this.txtHeaderOrderNumbersList.Left = 1.377953F;
            this.txtHeaderOrderNumbersList.MultiLine = false;
            this.txtHeaderOrderNumbersList.Name = "txtHeaderOrderNumbersList";
            this.txtHeaderOrderNumbersList.Style = "ddo-char-set: 204; text-align: left; font-weight: normal; font-size: 10.8pt; font" +
    "-family: Tahoma; ";
            this.txtHeaderOrderNumbersList.Text = "txtHeaderOrderNumbersList";
            this.txtHeaderOrderNumbersList.Top = 0.1574803F;
            this.txtHeaderOrderNumbersList.Width = 6.259842F;
            // 
            // txtHeaderFactureNumbersList
            // 
            this.txtHeaderFactureNumbersList.Border.BottomColor = System.Drawing.Color.Black;
            this.txtHeaderFactureNumbersList.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderFactureNumbersList.Border.LeftColor = System.Drawing.Color.Black;
            this.txtHeaderFactureNumbersList.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderFactureNumbersList.Border.RightColor = System.Drawing.Color.Black;
            this.txtHeaderFactureNumbersList.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderFactureNumbersList.Border.TopColor = System.Drawing.Color.Black;
            this.txtHeaderFactureNumbersList.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtHeaderFactureNumbersList.DataField = "HeaderFactureNumbersList";
            this.txtHeaderFactureNumbersList.Height = 0.1968504F;
            this.txtHeaderFactureNumbersList.Left = 1.377953F;
            this.txtHeaderFactureNumbersList.MultiLine = false;
            this.txtHeaderFactureNumbersList.Name = "txtHeaderFactureNumbersList";
            this.txtHeaderFactureNumbersList.Style = "ddo-char-set: 204; text-align: left; font-weight: normal; font-size: 10.8pt; font" +
    "-family: Tahoma; ";
            this.txtHeaderFactureNumbersList.Text = "txtHeaderFactureNumbersList";
            this.txtHeaderFactureNumbersList.Top = 0.3937008F;
            this.txtHeaderFactureNumbersList.Width = 6.259842F;
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBillNumber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBillNumber.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBillNumber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBillNumber.Border.RightColor = System.Drawing.Color.Black;
            this.txtBillNumber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBillNumber.Border.TopColor = System.Drawing.Color.Black;
            this.txtBillNumber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBillNumber.DataField = "IDList";
            this.txtBillNumber.Height = 0.1574803F;
            this.txtBillNumber.HyperLink = null;
            this.txtBillNumber.Left = 4.92126F;
            this.txtBillNumber.MultiLine = false;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtBillNumber.Text = "IDList";
            this.txtBillNumber.Top = 0.03937008F;
            this.txtBillNumber.Width = 2.716535F;
            // 
            // txtDateOutput
            // 
            this.txtDateOutput.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDateOutput.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateOutput.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDateOutput.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateOutput.Border.RightColor = System.Drawing.Color.Black;
            this.txtDateOutput.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateOutput.Border.TopColor = System.Drawing.Color.Black;
            this.txtDateOutput.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateOutput.DataField = "DateOutput";
            this.txtDateOutput.Height = 0.1574804F;
            this.txtDateOutput.HyperLink = null;
            this.txtDateOutput.Left = 3.031496F;
            this.txtDateOutput.MultiLine = false;
            this.txtDateOutput.Name = "txtDateOutput";
            this.txtDateOutput.OutputFormat = resources.GetString("txtDateOutput.OutputFormat");
            this.txtDateOutput.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtDateOutput.Text = "DateOutput";
            this.txtDateOutput.Top = 0.03937008F;
            this.txtDateOutput.Width = 0.7874016F;
            // 
            // Detail
            // 
            this.Detail.ColumnSpacing = 0F;
            this.Detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtCurrentUserName1,
            this.label81,
            this.label80,
            this.label24,
            this.label25,
            this.txtDateOutput,
            this.txtBillNumber,
            this.line17,
            this.label10,
            this.Дата,
            this.label32,
            this.line18,
            this.txtShipperInfo,
            this.txtConsigneeInfo,
            this.label33,
            this.txtGoodName,
            this.txtBoxesWords,
            this.txtNettoBrutto,
            this.label1,
            this.txtDocuments,
            this.label2,
            this.txtDirections1,
            this.txtDirections2,
            this.label3,
            this.txtPointCharge,
            this.txtChargeData,
            this.label4,
            this.txtDischargeData,
            this.label5,
            this.txtPointDischarge,
            this.txtChargeStamp,
            this.label7,
            this.label8,
            this.label9,
            this.label11,
            this.label12,
            this.label13,
            this.label14,
            this.label15,
            this.label16,
            this.label17,
            this.label18,
            this.line1,
            this.label19,
            this.line2,
            this.label20,
            this.line3,
            this.label21,
            this.line4,
            this.label22,
            this.line5,
            this.label23,
            this.line6,
            this.label26,
            this.line7,
            this.label27,
            this.line8,
            this.label28,
            this.label29,
            this.line10,
            this.label30,
            this.label34,
            this.line11,
            this.label35,
            this.textBox1,
            this.label36,
            this.label37,
            this.line12,
            this.line9,
            this.label6,
            this.line13,
            this.label38,
            this.line14,
            this.label39,
            this.line15,
            this.label40,
            this.line16,
            this.label41,
            this.line19,
            this.label42,
            this.line20,
            this.label43,
            this.line21,
            this.label44,
            this.line22,
            this.label45,
            this.label46,
            this.label47,
            this.txtOrganizationInfo,
            this.label48,
            this.line23,
            this.txtDriverName,
            this.label49,
            this.line24,
            this.label51,
            this.line25,
            this.label50,
            this.txtCarInfo,
            this.label52,
            this.line26,
            this.label53,
            this.line27,
            this.label54,
            this.label55,
            this.label56,
            this.label57,
            this.line28,
            this.label58,
            this.label59,
            this.label60,
            this.label61,
            this.line29,
            this.label62,
            this.label63,
            this.line30,
            this.label64,
            this.line31,
            this.label65,
            this.txtReAddressing,
            this.label66,
            this.line32,
            this.label67,
            this.label68,
            this.label69,
            this.line33,
            this.label70,
            this.textBox2,
            this.label71,
            this.textBox3,
            this.label72,
            this.line34,
            this.line35,
            this.label73,
            this.line36,
            this.line37,
            this.line38,
            this.line39,
            this.line40,
            this.line41,
            this.line42,
            this.label74,
            this.label75,
            this.label76,
            this.label77,
            this.label78,
            this.line43,
            this.line44,
            this.label79,
            this.line45,
            this.line46,
            this.label82,
            this.label83,
            this.label84,
            this.line47,
            this.line48,
            this.label85,
            this.label86,
            this.line49,
            this.txtCurrentUserName2});
            this.Detail.Height = 19.68504F;
            this.Detail.Name = "Detail";
            this.Detail.Format += new System.EventHandler(this.Detail_Format);
            // 
            // txtCurrentUserName1
            // 
            this.txtCurrentUserName1.Border.BottomColor = System.Drawing.Color.Black;
            this.txtCurrentUserName1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName1.Border.LeftColor = System.Drawing.Color.Black;
            this.txtCurrentUserName1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName1.Border.RightColor = System.Drawing.Color.Black;
            this.txtCurrentUserName1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName1.Border.TopColor = System.Drawing.Color.Black;
            this.txtCurrentUserName1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName1.Height = 0.1574804F;
            this.txtCurrentUserName1.HyperLink = null;
            this.txtCurrentUserName1.Left = 2.992126F;
            this.txtCurrentUserName1.MultiLine = false;
            this.txtCurrentUserName1.Name = "txtCurrentUserName1";
            this.txtCurrentUserName1.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtCurrentUserName1.Text = "CurrentUserName";
            this.txtCurrentUserName1.Top = 5.314961F;
            this.txtCurrentUserName1.Width = 1.968504F;
            // 
            // label81
            // 
            this.label81.Border.BottomColor = System.Drawing.Color.Black;
            this.label81.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label81.Border.LeftColor = System.Drawing.Color.Black;
            this.label81.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label81.Border.RightColor = System.Drawing.Color.Black;
            this.label81.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label81.Border.TopColor = System.Drawing.Color.Black;
            this.label81.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label81.Height = 0.1181104F;
            this.label81.HyperLink = "";
            this.label81.Left = 5.354331F;
            this.label81.Name = "label81";
            this.label81.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label81.Text = "подпись водителя, принявшего груз";
            this.label81.Top = 5.472441F;
            this.label81.Width = 1.968504F;
            // 
            // label80
            // 
            this.label80.Border.BottomColor = System.Drawing.Color.Black;
            this.label80.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label80.Border.LeftColor = System.Drawing.Color.Black;
            this.label80.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label80.Border.RightColor = System.Drawing.Color.Black;
            this.label80.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label80.Border.TopColor = System.Drawing.Color.Black;
            this.label80.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label80.Height = 0.1181104F;
            this.label80.HyperLink = "";
            this.label80.Left = 2.992126F;
            this.label80.Name = "label80";
            this.label80.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label80.Text = "грузоотправитель";
            this.label80.Top = 5.472441F;
            this.label80.Width = 1.968504F;
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
            this.label24.Height = 0.1968504F;
            this.label24.HyperLink = null;
            this.label24.Left = 3.897638F;
            this.label24.MultiLine = false;
            this.label24.Name = "label24";
            this.label24.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label24.Text = "2. Грузополучатель";
            this.label24.Top = 0.2755906F;
            this.label24.Width = 3.740157F;
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
            this.label25.Left = 0.07874016F;
            this.label25.MultiLine = false;
            this.label25.Name = "label25";
            this.label25.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label25.Text = "1. Грузоотправитель";
            this.label25.Top = 0.2755906F;
            this.label25.Width = 3.740157F;
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
            this.line17.Height = 1.220473F;
            this.line17.Left = 3.858268F;
            this.line17.LineWeight = 1F;
            this.line17.Name = "line17";
            this.line17.Top = 0.03937008F;
            this.line17.Width = 0F;
            this.line17.X1 = 3.858268F;
            this.line17.X2 = 3.858268F;
            this.line17.Y1 = 0.03937008F;
            this.line17.Y2 = 1.259843F;
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
            this.label10.Height = 0.1574803F;
            this.label10.HyperLink = null;
            this.label10.Left = 0.07874016F;
            this.label10.MultiLine = false;
            this.label10.Name = "label10";
            this.label10.Style = "color: Black; ddo-char-set: 1; font-size: 10pt; font-family: Tahoma; white-space:" +
    " nowrap; vertical-align: top; ";
            this.label10.Text = "Экземпляр № 1,2,3,4";
            this.label10.Top = 0.03937008F;
            this.label10.Width = 1.417323F;
            // 
            // Дата
            // 
            this.Дата.Border.BottomColor = System.Drawing.Color.Black;
            this.Дата.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.Дата.Border.LeftColor = System.Drawing.Color.Black;
            this.Дата.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.Дата.Border.RightColor = System.Drawing.Color.Black;
            this.Дата.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.Дата.Border.TopColor = System.Drawing.Color.Black;
            this.Дата.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.Дата.Height = 0.1574803F;
            this.Дата.HyperLink = null;
            this.Дата.Left = 2.598425F;
            this.Дата.MultiLine = false;
            this.Дата.Name = "Дата";
            this.Дата.Style = "color: Black; ddo-char-set: 1; font-size: 10pt; font-family: Tahoma; white-space:" +
    " nowrap; vertical-align: top; ";
            this.Дата.Text = "Дата";
            this.Дата.Top = 0.03937008F;
            this.Дата.Width = 0.3937008F;
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
            this.label32.Height = 0.1574803F;
            this.label32.HyperLink = null;
            this.label32.Left = 3.897638F;
            this.label32.MultiLine = false;
            this.label32.Name = "label32";
            this.label32.Style = "color: Black; ddo-char-set: 1; font-size: 10pt; font-family: Tahoma; white-space:" +
    " nowrap; vertical-align: top; ";
            this.label32.Text = "Заказ (заявка)";
            this.label32.Top = 0.03937008F;
            this.label32.Width = 0.984252F;
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
            this.line18.Height = 0F;
            this.line18.Left = 0.03937008F;
            this.line18.LineWeight = 1F;
            this.line18.Name = "line18";
            this.line18.Top = 0.2362205F;
            this.line18.Width = 7.637796F;
            this.line18.X1 = 0.03937008F;
            this.line18.X2 = 7.677166F;
            this.line18.Y1 = 0.2362205F;
            this.line18.Y2 = 0.2362205F;
            // 
            // txtShipperInfo
            // 
            this.txtShipperInfo.Border.BottomColor = System.Drawing.Color.Black;
            this.txtShipperInfo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtShipperInfo.Border.LeftColor = System.Drawing.Color.Black;
            this.txtShipperInfo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtShipperInfo.Border.RightColor = System.Drawing.Color.Black;
            this.txtShipperInfo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtShipperInfo.Border.TopColor = System.Drawing.Color.Black;
            this.txtShipperInfo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtShipperInfo.CanGrow = false;
            this.txtShipperInfo.DataField = "ShipperInfo";
            this.txtShipperInfo.Height = 0.7480315F;
            this.txtShipperInfo.HyperLink = null;
            this.txtShipperInfo.Left = 0.07874016F;
            this.txtShipperInfo.Name = "txtShipperInfo";
            this.txtShipperInfo.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 9pt; font-fa" +
    "mily: Tahoma; ";
            this.txtShipperInfo.Text = "ShipperInfo";
            this.txtShipperInfo.Top = 0.472441F;
            this.txtShipperInfo.Width = 3.740157F;
            // 
            // txtConsigneeInfo
            // 
            this.txtConsigneeInfo.Border.BottomColor = System.Drawing.Color.Black;
            this.txtConsigneeInfo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtConsigneeInfo.Border.LeftColor = System.Drawing.Color.Black;
            this.txtConsigneeInfo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtConsigneeInfo.Border.RightColor = System.Drawing.Color.Black;
            this.txtConsigneeInfo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtConsigneeInfo.Border.TopColor = System.Drawing.Color.Black;
            this.txtConsigneeInfo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtConsigneeInfo.CanGrow = false;
            this.txtConsigneeInfo.DataField = "ConsigneeInfo";
            this.txtConsigneeInfo.Height = 0.7480315F;
            this.txtConsigneeInfo.HyperLink = null;
            this.txtConsigneeInfo.Left = 3.897638F;
            this.txtConsigneeInfo.Name = "txtConsigneeInfo";
            this.txtConsigneeInfo.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 9pt; font-fa" +
    "mily: Tahoma; ";
            this.txtConsigneeInfo.Text = "ConsigneeInfo";
            this.txtConsigneeInfo.Top = 0.472441F;
            this.txtConsigneeInfo.Width = 3.740157F;
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
            this.label33.Height = 0.1968505F;
            this.label33.HyperLink = null;
            this.label33.Left = 1.141732F;
            this.label33.MultiLine = false;
            this.label33.Name = "label33";
            this.label33.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label33.Text = "3. Наименование груза";
            this.label33.Top = 1.417323F;
            this.label33.Width = 5.511811F;
            // 
            // txtGoodName
            // 
            this.txtGoodName.Border.BottomColor = System.Drawing.Color.Black;
            this.txtGoodName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtGoodName.Border.LeftColor = System.Drawing.Color.Black;
            this.txtGoodName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtGoodName.Border.RightColor = System.Drawing.Color.Black;
            this.txtGoodName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtGoodName.Border.TopColor = System.Drawing.Color.Black;
            this.txtGoodName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtGoodName.Height = 0.1574803F;
            this.txtGoodName.HyperLink = null;
            this.txtGoodName.Left = 0.07874016F;
            this.txtGoodName.MultiLine = false;
            this.txtGoodName.Name = "txtGoodName";
            this.txtGoodName.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtGoodName.Text = "txtGoodName";
            this.txtGoodName.Top = 1.653543F;
            this.txtGoodName.Width = 7.559055F;
            // 
            // txtBoxesWords
            // 
            this.txtBoxesWords.Border.BottomColor = System.Drawing.Color.Black;
            this.txtBoxesWords.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBoxesWords.Border.LeftColor = System.Drawing.Color.Black;
            this.txtBoxesWords.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBoxesWords.Border.RightColor = System.Drawing.Color.Black;
            this.txtBoxesWords.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBoxesWords.Border.TopColor = System.Drawing.Color.Black;
            this.txtBoxesWords.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtBoxesWords.Height = 0.1574803F;
            this.txtBoxesWords.HyperLink = null;
            this.txtBoxesWords.Left = 0.07874016F;
            this.txtBoxesWords.MultiLine = false;
            this.txtBoxesWords.Name = "txtBoxesWords";
            this.txtBoxesWords.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtBoxesWords.Text = "txtBoxesWords";
            this.txtBoxesWords.Top = 1.968504F;
            this.txtBoxesWords.Width = 7.559055F;
            // 
            // txtNettoBrutto
            // 
            this.txtNettoBrutto.Border.BottomColor = System.Drawing.Color.Black;
            this.txtNettoBrutto.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtNettoBrutto.Border.LeftColor = System.Drawing.Color.Black;
            this.txtNettoBrutto.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtNettoBrutto.Border.RightColor = System.Drawing.Color.Black;
            this.txtNettoBrutto.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtNettoBrutto.Border.TopColor = System.Drawing.Color.Black;
            this.txtNettoBrutto.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtNettoBrutto.Height = 0.1574805F;
            this.txtNettoBrutto.HyperLink = null;
            this.txtNettoBrutto.Left = 0.07874016F;
            this.txtNettoBrutto.MultiLine = false;
            this.txtNettoBrutto.Name = "txtNettoBrutto";
            this.txtNettoBrutto.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtNettoBrutto.Text = "txtNettoBrutto";
            this.txtNettoBrutto.Top = 2.283465F;
            this.txtNettoBrutto.Width = 7.559055F;
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
            this.label1.Left = 1.141732F;
            this.label1.MultiLine = false;
            this.label1.Name = "label1";
            this.label1.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label1.Text = "4. Сопроводительные документы на груз";
            this.label1.Top = 2.637795F;
            this.label1.Width = 5.511811F;
            // 
            // txtDocuments
            // 
            this.txtDocuments.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDocuments.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDocuments.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDocuments.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDocuments.Border.RightColor = System.Drawing.Color.Black;
            this.txtDocuments.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDocuments.Border.TopColor = System.Drawing.Color.Black;
            this.txtDocuments.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDocuments.Height = 0.1574805F;
            this.txtDocuments.HyperLink = null;
            this.txtDocuments.Left = 0.07874016F;
            this.txtDocuments.Name = "txtDocuments";
            this.txtDocuments.Style = "ddo-char-set: 204; text-align: left; font-weight: normal; font-size: 9pt; font-fa" +
    "mily: Tahoma; ";
            this.txtDocuments.Text = "txtDocuments";
            this.txtDocuments.Top = 2.874016F;
            this.txtDocuments.Width = 7.559055F;
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
            this.label2.Height = 0.1968505F;
            this.label2.HyperLink = null;
            this.label2.Left = 1.141732F;
            this.label2.MultiLine = false;
            this.label2.Name = "label2";
            this.label2.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label2.Text = "5. Указания грузоотправителя";
            this.label2.Top = 3.228347F;
            this.label2.Width = 5.511811F;
            // 
            // txtDirections1
            // 
            this.txtDirections1.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDirections1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections1.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDirections1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections1.Border.RightColor = System.Drawing.Color.Black;
            this.txtDirections1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections1.Border.TopColor = System.Drawing.Color.Black;
            this.txtDirections1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections1.Height = 0.1574802F;
            this.txtDirections1.HyperLink = null;
            this.txtDirections1.Left = 0.07874016F;
            this.txtDirections1.MultiLine = false;
            this.txtDirections1.Name = "txtDirections1";
            this.txtDirections1.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtDirections1.Text = "Рефрижератор, наличие санитарного паспорта на ТС, обязателен температурный режим " +
    "-18С, ЗПУ грузоотправителя";
            this.txtDirections1.Top = 3.464567F;
            this.txtDirections1.Width = 7.559055F;
            // 
            // txtDirections2
            // 
            this.txtDirections2.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDirections2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections2.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDirections2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections2.Border.RightColor = System.Drawing.Color.Black;
            this.txtDirections2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections2.Border.TopColor = System.Drawing.Color.Black;
            this.txtDirections2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDirections2.Height = 0.1574804F;
            this.txtDirections2.HyperLink = null;
            this.txtDirections2.Left = 0.07874016F;
            this.txtDirections2.MultiLine = false;
            this.txtDirections2.Name = "txtDirections2";
            this.txtDirections2.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtDirections2.Text = "Стоимость груза в соответствии с товарной накладной";
            this.txtDirections2.Top = 3.779528F;
            this.txtDirections2.Width = 7.559055F;
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
            this.label3.Height = 0.1968505F;
            this.label3.HyperLink = null;
            this.label3.Left = 1.141732F;
            this.label3.MultiLine = false;
            this.label3.Name = "label3";
            this.label3.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label3.Text = "6. Прием груза";
            this.label3.Top = 4.133858F;
            this.label3.Width = 5.511811F;
            // 
            // txtPointCharge
            // 
            this.txtPointCharge.Border.BottomColor = System.Drawing.Color.Black;
            this.txtPointCharge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointCharge.Border.LeftColor = System.Drawing.Color.Black;
            this.txtPointCharge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointCharge.Border.RightColor = System.Drawing.Color.Black;
            this.txtPointCharge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointCharge.Border.TopColor = System.Drawing.Color.Black;
            this.txtPointCharge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointCharge.DataField = "=\"Адрес места погрузки: \" + PointCharge";
            this.txtPointCharge.Height = 0.1574805F;
            this.txtPointCharge.HyperLink = null;
            this.txtPointCharge.Left = 0.07874016F;
            this.txtPointCharge.MultiLine = false;
            this.txtPointCharge.Name = "txtPointCharge";
            this.txtPointCharge.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtPointCharge.Text = "PointCharge";
            this.txtPointCharge.Top = 4.370079F;
            this.txtPointCharge.Width = 7.559055F;
            // 
            // txtChargeData
            // 
            this.txtChargeData.Border.BottomColor = System.Drawing.Color.Black;
            this.txtChargeData.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeData.Border.LeftColor = System.Drawing.Color.Black;
            this.txtChargeData.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeData.Border.RightColor = System.Drawing.Color.Black;
            this.txtChargeData.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeData.Border.TopColor = System.Drawing.Color.Black;
            this.txtChargeData.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeData.Height = 0.1574801F;
            this.txtChargeData.HyperLink = null;
            this.txtChargeData.Left = 0.07874016F;
            this.txtChargeData.MultiLine = false;
            this.txtChargeData.Name = "txtChargeData";
            this.txtChargeData.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtChargeData.Text = "txtChargeData";
            this.txtChargeData.Top = 5F;
            this.txtChargeData.Width = 7.559055F;
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
            this.label4.Height = 0.1574804F;
            this.label4.HyperLink = null;
            this.label4.Left = 0.07874016F;
            this.label4.MultiLine = false;
            this.label4.Name = "label4";
            this.label4.Style = "color: Black; ddo-char-set: 204; text-align: left; font-style: normal; font-size:" +
    " 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label4.Text = "Груз в коробах на паллетах на месте погрузки, ЗПУ отправителя №";
            this.label4.Top = 4.68504F;
            this.label4.Width = 4.330709F;
            // 
            // txtDischargeData
            // 
            this.txtDischargeData.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDischargeData.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDischargeData.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDischargeData.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDischargeData.Border.RightColor = System.Drawing.Color.Black;
            this.txtDischargeData.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDischargeData.Border.TopColor = System.Drawing.Color.Black;
            this.txtDischargeData.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDischargeData.Height = 0.1574801F;
            this.txtDischargeData.HyperLink = null;
            this.txtDischargeData.Left = 0.07874016F;
            this.txtDischargeData.MultiLine = false;
            this.txtDischargeData.Name = "txtDischargeData";
            this.txtDischargeData.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtDischargeData.Text = "txtDischargeData";
            this.txtDischargeData.Top = 6.535433F;
            this.txtDischargeData.Width = 7.559055F;
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
            this.label5.Height = 0.1968505F;
            this.label5.HyperLink = null;
            this.label5.Left = 1.141732F;
            this.label5.MultiLine = false;
            this.label5.Name = "label5";
            this.label5.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label5.Text = "7. Сдача груза";
            this.label5.Top = 5.669291F;
            this.label5.Width = 5.511811F;
            // 
            // txtPointDischarge
            // 
            this.txtPointDischarge.Border.BottomColor = System.Drawing.Color.Black;
            this.txtPointDischarge.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointDischarge.Border.LeftColor = System.Drawing.Color.Black;
            this.txtPointDischarge.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointDischarge.Border.RightColor = System.Drawing.Color.Black;
            this.txtPointDischarge.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointDischarge.Border.TopColor = System.Drawing.Color.Black;
            this.txtPointDischarge.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPointDischarge.DataField = "=\"Адрес места выгрузки: \" + PointDischarge";
            this.txtPointDischarge.Height = 0.1574803F;
            this.txtPointDischarge.HyperLink = null;
            this.txtPointDischarge.Left = 0.07874016F;
            this.txtPointDischarge.MultiLine = false;
            this.txtPointDischarge.Name = "txtPointDischarge";
            this.txtPointDischarge.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtPointDischarge.Text = "PointDischarge";
            this.txtPointDischarge.Top = 5.905512F;
            this.txtPointDischarge.Width = 7.559055F;
            // 
            // txtChargeStamp
            // 
            this.txtChargeStamp.Border.BottomColor = System.Drawing.Color.Black;
            this.txtChargeStamp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeStamp.Border.LeftColor = System.Drawing.Color.Black;
            this.txtChargeStamp.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeStamp.Border.RightColor = System.Drawing.Color.Black;
            this.txtChargeStamp.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeStamp.Border.TopColor = System.Drawing.Color.Black;
            this.txtChargeStamp.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtChargeStamp.DataField = "StampNumber";
            this.txtChargeStamp.Height = 0.1574803F;
            this.txtChargeStamp.HyperLink = null;
            this.txtChargeStamp.Left = 4.448819F;
            this.txtChargeStamp.MultiLine = false;
            this.txtChargeStamp.Name = "txtChargeStamp";
            this.txtChargeStamp.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 10pt; font-f" +
    "amily: Tahoma; ";
            this.txtChargeStamp.Text = "txtChargeStamp";
            this.txtChargeStamp.Top = 4.68504F;
            this.txtChargeStamp.Width = 0.7874016F;
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
            this.label7.Height = 0.1968505F;
            this.label7.HyperLink = null;
            this.label7.Left = 1.141732F;
            this.label7.MultiLine = false;
            this.label7.Name = "label7";
            this.label7.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label7.Text = "8. Условия перевозки";
            this.label7.Top = 7.165354F;
            this.label7.Width = 5.511811F;
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
            this.label8.Height = 0.1574806F;
            this.label8.HyperLink = null;
            this.label8.Left = 0.07874016F;
            this.label8.MultiLine = false;
            this.label8.Name = "label8";
            this.label8.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label8.Text = "в соответствии с УАТ, ГК РФ";
            this.label8.Top = 7.401575F;
            this.label8.Width = 7.559055F;
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
            this.label9.Height = 0.1574804F;
            this.label9.HyperLink = null;
            this.label9.Left = 0.07874016F;
            this.label9.MultiLine = false;
            this.label9.Name = "label9";
            this.label9.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label9.Text = "в соответствии с договором";
            this.label9.Top = 7.716536F;
            this.label9.Width = 7.559055F;
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
            this.label11.Height = 0.1574802F;
            this.label11.HyperLink = null;
            this.label11.Left = 0.07874016F;
            this.label11.MultiLine = false;
            this.label11.Name = "label11";
            this.label11.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label11.Text = "масса груза в соответствии с данными товарных накладных, ЗПУ отправителя";
            this.label11.Top = 8.031496F;
            this.label11.Width = 7.559055F;
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
            this.label12.Height = 0.1574805F;
            this.label12.HyperLink = null;
            this.label12.Left = 0.07874016F;
            this.label12.MultiLine = false;
            this.label12.Name = "label12";
            this.label12.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label12.Text = "погрузочно-разгрузочные работы грузоотправителя/грузополучателя";
            this.label12.Top = 8.346457F;
            this.label12.Width = 7.559055F;
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
            this.label13.Height = 0.1574803F;
            this.label13.HyperLink = null;
            this.label13.Left = 0.07874016F;
            this.label13.MultiLine = false;
            this.label13.Name = "label13";
            this.label13.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label13.Text = "в соответствии с договором";
            this.label13.Top = 8.661418F;
            this.label13.Width = 7.559055F;
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
            this.label14.Height = 0.1574801F;
            this.label14.HyperLink = null;
            this.label14.Left = 0.07874016F;
            this.label14.MultiLine = false;
            this.label14.Name = "label14";
            this.label14.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label14.Text = "в соответствии с договором";
            this.label14.Top = 8.976378F;
            this.label14.Width = 7.559055F;
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
            this.label15.Height = 0.1968505F;
            this.label15.HyperLink = null;
            this.label15.Left = 1.141732F;
            this.label15.MultiLine = false;
            this.label15.Name = "label15";
            this.label15.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label15.Text = "9. Информация о принятии заказа (заявки) к исполнению";
            this.label15.Top = 10.7874F;
            this.label15.Width = 5.511811F;
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
            this.label16.Height = 0.1574802F;
            this.label16.HyperLink = null;
            this.label16.Left = 0.07874016F;
            this.label16.MultiLine = false;
            this.label16.Name = "label16";
            this.label16.Style = "color: Black; ddo-char-set: 204; text-align: left; font-style: normal; font-size:" +
    " 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label16.Text = "Заявка принята в соответствии с установленным порядком приема заявок";
            this.label16.Top = 11.02362F;
            this.label16.Width = 7.559055F;
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
            this.label17.Height = 0.1181102F;
            this.label17.HyperLink = "";
            this.label17.Left = 0.6299213F;
            this.label17.Name = "label17";
            this.label17.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label17.Text = "полное наименование, адрес места нахождения - для юр. лица";
            this.label17.Top = 1.259843F;
            this.label17.Width = 2.598425F;
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
            this.label18.Height = 0.1181102F;
            this.label18.HyperLink = "";
            this.label18.Left = 4.488189F;
            this.label18.Name = "label18";
            this.label18.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label18.Text = "полное наименование, адрес места нахождения - для юр. лица";
            this.label18.Top = 1.259843F;
            this.label18.Width = 2.598425F;
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
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 1.259843F;
            this.line1.Width = 7.637796F;
            this.line1.X1 = 0.03937008F;
            this.line1.X2 = 7.677166F;
            this.line1.Y1 = 1.259843F;
            this.line1.Y2 = 1.259843F;
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
            this.label19.Height = 0.1181102F;
            this.label19.HyperLink = "";
            this.label19.Left = 0.07874016F;
            this.label19.Name = "label19";
            this.label19.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label19.Text = "отгрузочное наименование груза, его состояние и другая необходимая информация";
            this.label19.Top = 1.811024F;
            this.label19.Width = 7.559055F;
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
            this.line2.LineWeight = 1F;
            this.line2.Name = "line2";
            this.line2.Top = 1.811024F;
            this.line2.Width = 7.637796F;
            this.line2.X1 = 0.03937008F;
            this.line2.X2 = 7.677166F;
            this.line2.Y1 = 1.811024F;
            this.line2.Y2 = 1.811024F;
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
            this.label20.HyperLink = "";
            this.label20.Left = 0.07874016F;
            this.label20.Name = "label20";
            this.label20.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label20.Text = "кол-во грузовых мест, маркировка, вид тары и способ упаковки";
            this.label20.Top = 2.125984F;
            this.label20.Width = 7.559056F;
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
            this.line3.Top = 2.125984F;
            this.line3.Width = 7.637796F;
            this.line3.X1 = 0.03937008F;
            this.line3.X2 = 7.677166F;
            this.line3.Y1 = 2.125984F;
            this.line3.Y2 = 2.125984F;
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
            this.label21.HyperLink = "";
            this.label21.Left = 0.07874016F;
            this.label21.Name = "label21";
            this.label21.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label21.Text = "масса нетто (брутто) грузовых мест в килограммах, размеры в метрах, объем грузовы" +
    "х мест в кубических метрах";
            this.label21.Top = 2.440945F;
            this.label21.Width = 7.559056F;
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
            this.line4.Top = 2.440945F;
            this.line4.Width = 7.637796F;
            this.line4.X1 = 0.03937008F;
            this.line4.X2 = 7.677166F;
            this.line4.Y1 = 2.440945F;
            this.line4.Y2 = 2.440945F;
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
            this.label22.Height = 0.1181102F;
            this.label22.HyperLink = "";
            this.label22.Left = 0.07874016F;
            this.label22.Name = "label22";
            this.label22.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label22.Text = "перечень прилагаемых документов, предусмотренных ДОПОГ, санитарными, таможенными," +
    " карантинными, иными правилами в соответствии с законодательством РФ";
            this.label22.Top = 3.031496F;
            this.label22.Width = 7.559056F;
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
            this.line5.Height = 0F;
            this.line5.Left = 0.03937008F;
            this.line5.LineWeight = 1F;
            this.line5.Name = "line5";
            this.line5.Top = 3.031496F;
            this.line5.Width = 7.637796F;
            this.line5.X1 = 0.03937008F;
            this.line5.X2 = 7.677166F;
            this.line5.Y1 = 3.031496F;
            this.line5.Y2 = 3.031496F;
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
            this.label23.Height = 0.1181102F;
            this.label23.HyperLink = "";
            this.label23.Left = 0.07874016F;
            this.label23.Name = "label23";
            this.label23.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label23.Text = "параметры ТС, необходимые для перевозки груза; указания, необходимые для выполнен" +
    "ия санитарных требований; рекомендации о температурном режиме перевозки";
            this.label23.Top = 3.622047F;
            this.label23.Width = 7.559056F;
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
            this.line6.Left = 0.03937008F;
            this.line6.LineWeight = 1F;
            this.line6.Name = "line6";
            this.line6.Top = 3.622047F;
            this.line6.Width = 7.637796F;
            this.line6.X1 = 0.03937008F;
            this.line6.X2 = 7.677166F;
            this.line6.Y1 = 3.622047F;
            this.line6.Y2 = 3.622047F;
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
            this.label26.Height = 0.1181102F;
            this.label26.HyperLink = "";
            this.label26.Left = 0.07874016F;
            this.label26.Name = "label26";
            this.label26.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label26.Text = "объявленная стоимость (ценность) груза";
            this.label26.Top = 3.937008F;
            this.label26.Width = 7.559056F;
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
            this.line7.Height = 0F;
            this.line7.Left = 0.03937008F;
            this.line7.LineWeight = 1F;
            this.line7.Name = "line7";
            this.line7.Top = 3.937008F;
            this.line7.Width = 7.637796F;
            this.line7.X1 = 0.03937008F;
            this.line7.X2 = 7.677166F;
            this.line7.Y1 = 3.937008F;
            this.line7.Y2 = 3.937008F;
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
            this.label27.Height = 0.1181102F;
            this.label27.HyperLink = "";
            this.label27.Left = 0.07874016F;
            this.label27.Name = "label27";
            this.label27.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label27.Text = "адрес места, дата и время подачи ТС под погрузку";
            this.label27.Top = 4.527559F;
            this.label27.Width = 7.559056F;
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
            this.line8.Left = 0.03937008F;
            this.line8.LineWeight = 1F;
            this.line8.Name = "line8";
            this.line8.Top = 4.527559F;
            this.line8.Width = 7.637796F;
            this.line8.X1 = 0.03937008F;
            this.line8.X2 = 7.677166F;
            this.line8.Y1 = 4.527559F;
            this.line8.Y2 = 4.527559F;
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
            this.label28.HyperLink = "";
            this.label28.Left = 0.07874016F;
            this.label28.Name = "label28";
            this.label28.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label28.Text = "фактическое состояние груза, тары, упаковки, маркировки и опломбирования";
            this.label28.Top = 4.84252F;
            this.label28.Width = 7.559056F;
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
            this.label29.Height = 0.1181102F;
            this.label29.HyperLink = "";
            this.label29.Left = 0.07874016F;
            this.label29.Name = "label29";
            this.label29.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label29.Text = "масса груза, кол-во грузовых мест";
            this.label29.Top = 5.157481F;
            this.label29.Width = 7.559056F;
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
            this.line10.LineWeight = 1F;
            this.line10.Name = "line10";
            this.line10.Top = 5.15748F;
            this.line10.Width = 7.637796F;
            this.line10.X1 = 0.03937008F;
            this.line10.X2 = 7.677166F;
            this.line10.Y1 = 5.15748F;
            this.line10.Y2 = 5.15748F;
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
            this.label30.Height = 0.1574803F;
            this.label30.HyperLink = "";
            this.label30.Left = 5.27559F;
            this.label30.MultiLine = false;
            this.label30.Name = "label30";
            this.label30.Style = "color: Black; ddo-char-set: 204; text-align: left; font-style: normal; font-size:" +
    " 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label30.Text = "на месте погрузки";
            this.label30.Top = 4.68504F;
            this.label30.Width = 1.181102F;
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
            this.label34.Height = 0.1181102F;
            this.label34.HyperLink = "";
            this.label34.Left = 0.07874016F;
            this.label34.Name = "label34";
            this.label34.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label34.Text = "адрес места, дата и время подачи ТС под выгрузку";
            this.label34.Top = 6.062992F;
            this.label34.Width = 7.559056F;
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
            this.line11.Height = 0F;
            this.line11.Left = 0.03937008F;
            this.line11.LineWeight = 1F;
            this.line11.Name = "line11";
            this.line11.Top = 6.062992F;
            this.line11.Width = 7.637796F;
            this.line11.X1 = 0.03937008F;
            this.line11.X2 = 7.677166F;
            this.line11.Y1 = 6.062992F;
            this.line11.Y2 = 6.062992F;
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
            this.label35.Height = 0.1574805F;
            this.label35.HyperLink = "";
            this.label35.Left = 0.07874016F;
            this.label35.MultiLine = false;
            this.label35.Name = "label35";
            this.label35.Style = "color: Black; ddo-char-set: 204; text-align: left; font-style: normal; font-size:" +
    " 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label35.Text = "Груз в коробах на паллетах на месте выгрузки, ЗПУ отправителя №";
            this.label35.Top = 6.220472F;
            this.label35.Width = 4.330709F;
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.RightColor = System.Drawing.Color.Black;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.TopColor = System.Drawing.Color.Black;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.DataField = "StampNumber";
            this.textBox1.Height = 0.1574803F;
            this.textBox1.Left = 4.448819F;
            this.textBox1.MultiLine = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 10pt; font-f" +
    "amily: Tahoma; ";
            this.textBox1.Text = "txtChargeStamp";
            this.textBox1.Top = 6.220472F;
            this.textBox1.Width = 0.7874016F;
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
            this.label36.Height = 0.1181102F;
            this.label36.HyperLink = "";
            this.label36.Left = 0.07874016F;
            this.label36.Name = "label36";
            this.label36.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label36.Text = "фактическое состояние груза, тары, упаковки, маркировки и опломбирования";
            this.label36.Top = 6.377953F;
            this.label36.Width = 7.559056F;
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
            this.label37.Height = 0.1574803F;
            this.label37.HyperLink = "";
            this.label37.Left = 5.27559F;
            this.label37.MultiLine = false;
            this.label37.Name = "label37";
            this.label37.Style = "color: Black; ddo-char-set: 204; text-align: left; font-style: normal; font-size:" +
    " 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label37.Text = "на месте выгрузки";
            this.label37.Top = 6.220472F;
            this.label37.Width = 1.181102F;
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
            this.line12.LineWeight = 1F;
            this.line12.Name = "line12";
            this.line12.Top = 6.377953F;
            this.line12.Width = 7.637796F;
            this.line12.X1 = 0.03937008F;
            this.line12.X2 = 7.677166F;
            this.line12.Y1 = 6.377953F;
            this.line12.Y2 = 6.377953F;
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
            this.line9.Height = 0F;
            this.line9.Left = 0.03937008F;
            this.line9.LineWeight = 1F;
            this.line9.Name = "line9";
            this.line9.Top = 4.84252F;
            this.line9.Width = 7.637796F;
            this.line9.X1 = 0.03937008F;
            this.line9.X2 = 7.677166F;
            this.line9.Y1 = 4.84252F;
            this.line9.Y2 = 4.84252F;
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
            this.label6.Height = 0.1181102F;
            this.label6.HyperLink = "";
            this.label6.Left = 0.07874016F;
            this.label6.Name = "label6";
            this.label6.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label6.Text = "масса груза, кол-во грузовых мест";
            this.label6.Top = 6.692914F;
            this.label6.Width = 7.559056F;
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
            this.line13.Top = 6.692914F;
            this.line13.Width = 7.637796F;
            this.line13.X1 = 0.03937008F;
            this.line13.X2 = 7.677166F;
            this.line13.Y1 = 6.692914F;
            this.line13.Y2 = 6.692914F;
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
            this.label38.Height = 0.1181102F;
            this.label38.HyperLink = "";
            this.label38.Left = 0.07874016F;
            this.label38.Name = "label38";
            this.label38.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label38.Text = "сроки, по истечении которых груз считается утраченным; форма уведомления о провед" +
    "ении экспертизы для определения размера недостачи (порчи) груза";
            this.label38.Top = 7.559055F;
            this.label38.Width = 7.559056F;
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
            this.line14.Top = 7.559055F;
            this.line14.Width = 7.637796F;
            this.line14.X1 = 0.03937008F;
            this.line14.X2 = 7.677166F;
            this.line14.Y1 = 7.559055F;
            this.line14.Y2 = 7.559055F;
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
            this.label39.Height = 0.1181102F;
            this.label39.HyperLink = "";
            this.label39.Left = 0.07874016F;
            this.label39.Name = "label39";
            this.label39.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label39.Text = "размер платы и предельный срок хранения груза в терминале перевозчика; сроки погр" +
    "узки/выгрузки; необходимые приспособления";
            this.label39.Top = 7.874016F;
            this.label39.Width = 7.559056F;
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
            this.line15.Top = 7.874016F;
            this.line15.Width = 7.637796F;
            this.line15.X1 = 0.03937008F;
            this.line15.X2 = 7.677166F;
            this.line15.Y1 = 7.874016F;
            this.line15.Y2 = 7.874016F;
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
            this.label40.Height = 0.1181102F;
            this.label40.HyperLink = "";
            this.label40.Left = 0.07874016F;
            this.label40.Name = "label40";
            this.label40.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label40.Text = "масса груза и способ ее определения; сведения об опломбировании крытых ТС";
            this.label40.Top = 8.188976F;
            this.label40.Width = 7.559056F;
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
            this.line16.Height = 0F;
            this.line16.Left = 0.03937008F;
            this.line16.LineWeight = 1F;
            this.line16.Name = "line16";
            this.line16.Top = 8.188976F;
            this.line16.Width = 7.637796F;
            this.line16.X1 = 0.03937008F;
            this.line16.X2 = 7.677166F;
            this.line16.Y1 = 8.188976F;
            this.line16.Y2 = 8.188976F;
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
            this.label41.Height = 0.1181102F;
            this.label41.HyperLink = "";
            this.label41.Left = 0.07874016F;
            this.label41.Name = "label41";
            this.label41.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label41.Text = "порядок выполнения погрузочно-разгрузочных работ; работ по промывке и дезинфекции" +
    " ТС";
            this.label41.Top = 8.503938F;
            this.label41.Width = 7.559056F;
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
            this.line19.Height = 0F;
            this.line19.Left = 0.03937008F;
            this.line19.LineWeight = 1F;
            this.line19.Name = "line19";
            this.line19.Top = 8.503938F;
            this.line19.Width = 7.637796F;
            this.line19.X1 = 0.03937008F;
            this.line19.X2 = 7.677166F;
            this.line19.Y1 = 8.503938F;
            this.line19.Y2 = 8.503938F;
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
            this.label42.Height = 0.1181102F;
            this.label42.HyperLink = "";
            this.label42.Left = 0.07874016F;
            this.label42.Name = "label42";
            this.label42.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label42.Text = "размер штрафа за невывоз груза по вине перевозчика; несвоевременное предоставлени" +
    "е ТС; просрочку лоставки груза; порядок исчисления срока просрочки";
            this.label42.Top = 8.818898F;
            this.label42.Width = 7.559056F;
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
            this.line20.Height = 0F;
            this.line20.Left = 0.03937008F;
            this.line20.LineWeight = 1F;
            this.line20.Name = "line20";
            this.line20.Top = 8.818898F;
            this.line20.Width = 7.637796F;
            this.line20.X1 = 0.03937008F;
            this.line20.X2 = 7.677166F;
            this.line20.Y1 = 8.818898F;
            this.line20.Y2 = 8.818898F;
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
            this.label43.HyperLink = "";
            this.label43.Left = 0.07874016F;
            this.label43.Name = "label43";
            this.label43.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label43.Text = "размер штрафа за непредъявление для перевозки груза; за задержку (простой) ТС, по" +
    "данных под погрузку/выгрузку";
            this.label43.Top = 9.133859F;
            this.label43.Width = 7.559056F;
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
            this.line21.LineWeight = 1F;
            this.line21.Name = "line21";
            this.line21.Top = 9.133859F;
            this.line21.Width = 7.637796F;
            this.line21.X1 = 0.03937008F;
            this.line21.X2 = 7.677166F;
            this.line21.Y1 = 9.133859F;
            this.line21.Y2 = 9.133859F;
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
            this.label44.HyperLink = "";
            this.label44.Left = 0.07874016F;
            this.label44.Name = "label44";
            this.label44.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label44.Text = "дата принятия заявки к исполнению; ФИО лица, принявщего заявку к исполнению";
            this.label44.Top = 11.1811F;
            this.label44.Width = 7.559056F;
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
            this.line22.Height = 0F;
            this.line22.Left = 0F;
            this.line22.LineWeight = 1F;
            this.line22.Name = "line22";
            this.line22.Top = 11.1811F;
            this.line22.Width = 7.637796F;
            this.line22.X1 = 0F;
            this.line22.X2 = 7.637796F;
            this.line22.Y1 = 11.1811F;
            this.line22.Y2 = 11.1811F;
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
            this.label45.Height = 0.1968505F;
            this.label45.HyperLink = "";
            this.label45.Left = 1.141732F;
            this.label45.MultiLine = false;
            this.label45.Name = "label45";
            this.label45.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label45.Text = "10. Перевозчик";
            this.label45.Top = 11.69291F;
            this.label45.Width = 5.511811F;
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
            this.label46.Height = 0.1181103F;
            this.label46.HyperLink = "";
            this.label46.Left = 0.07874016F;
            this.label46.MultiLine = false;
            this.label46.Name = "label46";
            this.label46.Style = "color: Black; ddo-char-set: 204; text-align: left; font-style: normal; font-size:" +
    " 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label46.Text = "Продолжение приложения № 4";
            this.label46.Top = 10.62992F;
            this.label46.Width = 1.968504F;
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
            this.label47.Height = 0.1181103F;
            this.label47.HyperLink = "";
            this.label47.Left = 5.669291F;
            this.label47.MultiLine = false;
            this.label47.Name = "label47";
            this.label47.Style = "color: Black; ddo-char-set: 204; text-align: right; font-style: normal; font-size" +
    ": 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label47.Text = "Оборотная сторона";
            this.label47.Top = 10.62992F;
            this.label47.Width = 1.968504F;
            // 
            // txtOrganizationInfo
            // 
            this.txtOrganizationInfo.Border.BottomColor = System.Drawing.Color.Black;
            this.txtOrganizationInfo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtOrganizationInfo.Border.LeftColor = System.Drawing.Color.Black;
            this.txtOrganizationInfo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtOrganizationInfo.Border.RightColor = System.Drawing.Color.Black;
            this.txtOrganizationInfo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtOrganizationInfo.Border.TopColor = System.Drawing.Color.Black;
            this.txtOrganizationInfo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtOrganizationInfo.DataField = "OrganizationInfo";
            this.txtOrganizationInfo.Height = 0.1574801F;
            this.txtOrganizationInfo.Left = 0.07874016F;
            this.txtOrganizationInfo.MultiLine = false;
            this.txtOrganizationInfo.Name = "txtOrganizationInfo";
            this.txtOrganizationInfo.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtOrganizationInfo.Text = "OrganizationInfo";
            this.txtOrganizationInfo.Top = 11.92913F;
            this.txtOrganizationInfo.Width = 7.559056F;
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
            this.label48.HyperLink = "";
            this.label48.Left = 0.07874016F;
            this.label48.Name = "label48";
            this.label48.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label48.Text = "полное наименование, адрес места нахождения - для юр. лица";
            this.label48.Top = 12.08661F;
            this.label48.Width = 7.559056F;
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
            this.line23.Left = 0.03937008F;
            this.line23.LineWeight = 1F;
            this.line23.Name = "line23";
            this.line23.Top = 12.08661F;
            this.line23.Width = 7.637796F;
            this.line23.X1 = 0.03937008F;
            this.line23.X2 = 7.677166F;
            this.line23.Y1 = 12.08661F;
            this.line23.Y2 = 12.08661F;
            // 
            // txtDriverName
            // 
            this.txtDriverName.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDriverName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDriverName.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDriverName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDriverName.Border.RightColor = System.Drawing.Color.Black;
            this.txtDriverName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDriverName.Border.TopColor = System.Drawing.Color.Black;
            this.txtDriverName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDriverName.Height = 0.1574801F;
            this.txtDriverName.Left = 0.07874016F;
            this.txtDriverName.MultiLine = false;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtDriverName.Text = "txtDriverName";
            this.txtDriverName.Top = 12.24409F;
            this.txtDriverName.Width = 7.559056F;
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
            this.label49.Height = 0.1181102F;
            this.label49.HyperLink = "";
            this.label49.Left = 0.07874016F;
            this.label49.Name = "label49";
            this.label49.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label49.Text = "ФИО лица, ответственного за перевозку; данные о средствах связи";
            this.label49.Top = 12.40158F;
            this.label49.Width = 7.559056F;
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
            this.line24.Left = 0.03937008F;
            this.line24.LineWeight = 1F;
            this.line24.Name = "line24";
            this.line24.Top = 12.40157F;
            this.line24.Width = 7.637796F;
            this.line24.X1 = 0.03937008F;
            this.line24.X2 = 7.677166F;
            this.line24.Y1 = 12.40157F;
            this.line24.Y2 = 12.40157F;
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
            this.label51.Height = 0.1181102F;
            this.label51.HyperLink = "";
            this.label51.Left = 0.07874016F;
            this.label51.Name = "label51";
            this.label51.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label51.Text = "сведения о путевом листе (листах)";
            this.label51.Top = 12.71654F;
            this.label51.Width = 7.559056F;
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
            this.line25.Left = 0.03937008F;
            this.line25.LineWeight = 1F;
            this.line25.Name = "line25";
            this.line25.Top = 12.71654F;
            this.line25.Width = 7.637796F;
            this.line25.X1 = 0.03937008F;
            this.line25.X2 = 7.677166F;
            this.line25.Y1 = 12.71654F;
            this.line25.Y2 = 12.71654F;
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
            this.label50.Height = 0.1968505F;
            this.label50.HyperLink = "";
            this.label50.Left = 1.141732F;
            this.label50.MultiLine = false;
            this.label50.Name = "label50";
            this.label50.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label50.Text = "11. Транспортное средство";
            this.label50.Top = 12.91339F;
            this.label50.Width = 5.511811F;
            // 
            // txtCarInfo
            // 
            this.txtCarInfo.Border.BottomColor = System.Drawing.Color.Black;
            this.txtCarInfo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCarInfo.Border.LeftColor = System.Drawing.Color.Black;
            this.txtCarInfo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCarInfo.Border.RightColor = System.Drawing.Color.Black;
            this.txtCarInfo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCarInfo.Border.TopColor = System.Drawing.Color.Black;
            this.txtCarInfo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCarInfo.Height = 0.1574801F;
            this.txtCarInfo.Left = 0.07874016F;
            this.txtCarInfo.MultiLine = false;
            this.txtCarInfo.Name = "txtCarInfo";
            this.txtCarInfo.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtCarInfo.Text = "txtCarInfo";
            this.txtCarInfo.Top = 13.14961F;
            this.txtCarInfo.Width = 7.559056F;
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
            this.label52.HyperLink = "";
            this.label52.Left = 0.07874016F;
            this.label52.Name = "label52";
            this.label52.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label52.Text = "тип, марка, грузоподъемность, вместимость; регистрационные номера";
            this.label52.Top = 13.30709F;
            this.label52.Width = 7.559056F;
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
            this.line26.Left = 0.03937008F;
            this.line26.LineWeight = 1F;
            this.line26.Name = "line26";
            this.line26.Top = 13.30709F;
            this.line26.Width = 7.637796F;
            this.line26.X1 = 0.03937008F;
            this.line26.X2 = 7.677166F;
            this.line26.Y1 = 13.30709F;
            this.line26.Y2 = 13.30709F;
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
            this.label53.Height = 0.1968505F;
            this.label53.HyperLink = "";
            this.label53.Left = 1.141732F;
            this.label53.MultiLine = false;
            this.label53.Name = "label53";
            this.label53.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label53.Text = "12. Оговорки и замечания перевозчика";
            this.label53.Top = 13.50394F;
            this.label53.Width = 5.511811F;
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
            this.line27.Height = 0.7874002F;
            this.line27.Left = 3.858268F;
            this.line27.LineWeight = 1F;
            this.line27.Name = "line27";
            this.line27.Top = 13.74016F;
            this.line27.Width = 0F;
            this.line27.X1 = 3.858268F;
            this.line27.X2 = 3.858268F;
            this.line27.Y1 = 13.74016F;
            this.line27.Y2 = 14.52756F;
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
            this.label54.Height = 0.354331F;
            this.label54.HyperLink = null;
            this.label54.Left = 0.07874016F;
            this.label54.Name = "label54";
            this.label54.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label54.Text = "На паллетах, без возможности просчета коробов, частично с маркировкой, ЗПУ отправ" +
    "ителя";
            this.label54.Top = 13.74016F;
            this.label54.Width = 3.740157F;
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
            this.label55.Height = 0.354331F;
            this.label55.HyperLink = null;
            this.label55.Left = 3.897638F;
            this.label55.Name = "label55";
            this.label55.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label55.Text = "На паллетах, без возможности просчета коробов, частично с маркировкой, ЗПУ отправ" +
    "ителя без нарушен.";
            this.label55.Top = 13.74016F;
            this.label55.Width = 3.740157F;
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
            this.label56.HyperLink = "";
            this.label56.Left = 0.07874016F;
            this.label56.Name = "label56";
            this.label56.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label56.Text = "фактическое состояние груза, тары, маркировки при приеме";
            this.label56.Top = 14.09449F;
            this.label56.Width = 3.740158F;
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
            this.label57.HyperLink = "";
            this.label57.Left = 3.897638F;
            this.label57.Name = "label57";
            this.label57.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label57.Text = "фактическое состояние груза, тары, маркировки при сдаче";
            this.label57.Top = 14.09449F;
            this.label57.Width = 3.740158F;
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
            this.line28.Left = 0.03937008F;
            this.line28.LineWeight = 1F;
            this.line28.Name = "line28";
            this.line28.Top = 14.09449F;
            this.line28.Width = 7.637796F;
            this.line28.X1 = 0.03937008F;
            this.line28.X2 = 7.677166F;
            this.line28.Y1 = 14.09449F;
            this.line28.Y2 = 14.09449F;
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
            this.label58.Height = 0.1574801F;
            this.label58.HyperLink = null;
            this.label58.Left = 0.07874016F;
            this.label58.MultiLine = false;
            this.label58.Name = "label58";
            this.label58.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label58.Text = "Под температурным режимом -18С";
            this.label58.Top = 14.25197F;
            this.label58.Width = 3.740157F;
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
            this.label59.Height = 0.1574801F;
            this.label59.HyperLink = null;
            this.label59.Left = 3.897638F;
            this.label59.MultiLine = false;
            this.label59.Name = "label59";
            this.label59.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label59.Text = "Температура при открытии -18С";
            this.label59.Top = 14.25197F;
            this.label59.Width = 3.740157F;
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
            this.label60.Height = 0.1181102F;
            this.label60.HyperLink = "";
            this.label60.Left = 0.07874016F;
            this.label60.Name = "label60";
            this.label60.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label60.Text = "изменение условий перевозки при движении";
            this.label60.Top = 14.40945F;
            this.label60.Width = 3.740158F;
            // 
            // label61
            // 
            this.label61.Border.BottomColor = System.Drawing.Color.Black;
            this.label61.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label61.Border.LeftColor = System.Drawing.Color.Black;
            this.label61.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label61.Border.RightColor = System.Drawing.Color.Black;
            this.label61.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label61.Border.TopColor = System.Drawing.Color.Black;
            this.label61.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label61.Height = 0.1181102F;
            this.label61.HyperLink = "";
            this.label61.Left = 3.897638F;
            this.label61.Name = "label61";
            this.label61.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label61.Text = "изменение условий перевозки при выгрузке";
            this.label61.Top = 14.40945F;
            this.label61.Width = 3.740158F;
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
            this.line29.Left = 0.03937008F;
            this.line29.LineWeight = 1F;
            this.line29.Name = "line29";
            this.line29.Top = 14.40945F;
            this.line29.Width = 7.637796F;
            this.line29.X1 = 0.03937008F;
            this.line29.X2 = 7.677166F;
            this.line29.Y1 = 14.40945F;
            this.line29.Y2 = 14.40945F;
            // 
            // label62
            // 
            this.label62.Border.BottomColor = System.Drawing.Color.Black;
            this.label62.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label62.Border.LeftColor = System.Drawing.Color.Black;
            this.label62.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label62.Border.RightColor = System.Drawing.Color.Black;
            this.label62.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label62.Border.TopColor = System.Drawing.Color.Black;
            this.label62.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label62.Height = 0.1968505F;
            this.label62.HyperLink = "";
            this.label62.Left = 1.141732F;
            this.label62.MultiLine = false;
            this.label62.Name = "label62";
            this.label62.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label62.Text = "13. Прочие условия";
            this.label62.Top = 14.6063F;
            this.label62.Width = 5.511811F;
            // 
            // label63
            // 
            this.label63.Border.BottomColor = System.Drawing.Color.Black;
            this.label63.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label63.Border.LeftColor = System.Drawing.Color.Black;
            this.label63.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label63.Border.RightColor = System.Drawing.Color.Black;
            this.label63.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label63.Border.TopColor = System.Drawing.Color.Black;
            this.label63.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label63.Height = 0.1181102F;
            this.label63.HyperLink = "";
            this.label63.Left = 0.07874016F;
            this.label63.Name = "label63";
            this.label63.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label63.Text = "номер, дата и срок действия спец. разрешения; установленный маршрут перевозки опа" +
    "сного, тяжеловесного или крупногабаритного груза";
            this.label63.Top = 15F;
            this.label63.Width = 7.559056F;
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
            this.line30.LineWeight = 1F;
            this.line30.Name = "line30";
            this.line30.Top = 15F;
            this.line30.Width = 7.637796F;
            this.line30.X1 = 0.03937008F;
            this.line30.X2 = 7.677166F;
            this.line30.Y1 = 15F;
            this.line30.Y2 = 15F;
            // 
            // label64
            // 
            this.label64.Border.BottomColor = System.Drawing.Color.Black;
            this.label64.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label64.Border.LeftColor = System.Drawing.Color.Black;
            this.label64.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label64.Border.RightColor = System.Drawing.Color.Black;
            this.label64.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label64.Border.TopColor = System.Drawing.Color.Black;
            this.label64.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label64.Height = 0.1181102F;
            this.label64.HyperLink = "";
            this.label64.Left = 0.07874016F;
            this.label64.Name = "label64";
            this.label64.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label64.Text = "режим труда и отдыха водителя в пути следования; сведения о коммерческих и иных а" +
    "ктах";
            this.label64.Top = 15.31496F;
            this.label64.Width = 7.559056F;
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
            this.line31.Left = 0.03937008F;
            this.line31.LineWeight = 1F;
            this.line31.Name = "line31";
            this.line31.Top = 15.31496F;
            this.line31.Width = 7.637796F;
            this.line31.X1 = 0.03937008F;
            this.line31.X2 = 7.677166F;
            this.line31.Y1 = 15.31496F;
            this.line31.Y2 = 15.31496F;
            // 
            // label65
            // 
            this.label65.Border.BottomColor = System.Drawing.Color.Black;
            this.label65.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label65.Border.LeftColor = System.Drawing.Color.Black;
            this.label65.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label65.Border.RightColor = System.Drawing.Color.Black;
            this.label65.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label65.Border.TopColor = System.Drawing.Color.Black;
            this.label65.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label65.Height = 0.1968505F;
            this.label65.HyperLink = "";
            this.label65.Left = 1.141732F;
            this.label65.MultiLine = false;
            this.label65.Name = "label65";
            this.label65.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label65.Text = "14. Переадресовка";
            this.label65.Top = 15.51181F;
            this.label65.Width = 5.511811F;
            // 
            // txtReAddressing
            // 
            this.txtReAddressing.Border.BottomColor = System.Drawing.Color.Black;
            this.txtReAddressing.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtReAddressing.Border.LeftColor = System.Drawing.Color.Black;
            this.txtReAddressing.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtReAddressing.Border.RightColor = System.Drawing.Color.Black;
            this.txtReAddressing.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtReAddressing.Border.TopColor = System.Drawing.Color.Black;
            this.txtReAddressing.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtReAddressing.DataField = "ReAddressing";
            this.txtReAddressing.Height = 0.1574801F;
            this.txtReAddressing.Left = 0.07874016F;
            this.txtReAddressing.MultiLine = false;
            this.txtReAddressing.Name = "txtReAddressing";
            this.txtReAddressing.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtReAddressing.Text = "ReAddressing";
            this.txtReAddressing.Top = 15.74803F;
            this.txtReAddressing.Width = 7.559056F;
            // 
            // label66
            // 
            this.label66.Border.BottomColor = System.Drawing.Color.Black;
            this.label66.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label66.Border.LeftColor = System.Drawing.Color.Black;
            this.label66.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label66.Border.RightColor = System.Drawing.Color.Black;
            this.label66.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label66.Border.TopColor = System.Drawing.Color.Black;
            this.label66.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label66.Height = 0.1181102F;
            this.label66.HyperLink = "";
            this.label66.Left = 0.07874016F;
            this.label66.Name = "label66";
            this.label66.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label66.Text = "дата, форма переадресовки; адрес нового пункта выгрузки; дата и время подачи ТС п" +
    "од выгрузку";
            this.label66.Top = 15.90551F;
            this.label66.Width = 7.559056F;
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
            this.line32.Left = 0F;
            this.line32.LineWeight = 1F;
            this.line32.Name = "line32";
            this.line32.Top = 15.90551F;
            this.line32.Width = 7.637796F;
            this.line32.X1 = 0F;
            this.line32.X2 = 7.637796F;
            this.line32.Y1 = 15.90551F;
            this.line32.Y2 = 15.90551F;
            // 
            // label67
            // 
            this.label67.Border.BottomColor = System.Drawing.Color.Black;
            this.label67.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label67.Border.LeftColor = System.Drawing.Color.Black;
            this.label67.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label67.Border.RightColor = System.Drawing.Color.Black;
            this.label67.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label67.Border.TopColor = System.Drawing.Color.Black;
            this.label67.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label67.Height = 0.1968505F;
            this.label67.HyperLink = "";
            this.label67.Left = 1.141732F;
            this.label67.MultiLine = false;
            this.label67.Name = "label67";
            this.label67.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label67.Text = "15. Стоимость услуг перевозчика и порядок расчета платы";
            this.label67.Top = 16.10236F;
            this.label67.Width = 5.511811F;
            // 
            // label68
            // 
            this.label68.Border.BottomColor = System.Drawing.Color.Black;
            this.label68.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label68.Border.LeftColor = System.Drawing.Color.Black;
            this.label68.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label68.Border.RightColor = System.Drawing.Color.Black;
            this.label68.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label68.Border.TopColor = System.Drawing.Color.Black;
            this.label68.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label68.Height = 0.1574802F;
            this.label68.HyperLink = null;
            this.label68.Left = 0.07874016F;
            this.label68.MultiLine = false;
            this.label68.Name = "label68";
            this.label68.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label68.Text = "В соответствии с договором, заявкой";
            this.label68.Top = 16.33858F;
            this.label68.Width = 7.559055F;
            // 
            // label69
            // 
            this.label69.Border.BottomColor = System.Drawing.Color.Black;
            this.label69.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label69.Border.LeftColor = System.Drawing.Color.Black;
            this.label69.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label69.Border.RightColor = System.Drawing.Color.Black;
            this.label69.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label69.Border.TopColor = System.Drawing.Color.Black;
            this.label69.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label69.Height = 0.1181102F;
            this.label69.HyperLink = "";
            this.label69.Left = 0.07874016F;
            this.label69.Name = "label69";
            this.label69.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label69.Text = "стоимость услуги в рублях; порядок расчета платы; размер провозной платы в рублях" +
    "";
            this.label69.Top = 16.49606F;
            this.label69.Width = 7.559056F;
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
            this.line33.Top = 16.49606F;
            this.line33.Width = 7.637796F;
            this.line33.X1 = 0.03937008F;
            this.line33.X2 = 7.677166F;
            this.line33.Y1 = 16.49606F;
            this.line33.Y2 = 16.49606F;
            // 
            // label70
            // 
            this.label70.Border.BottomColor = System.Drawing.Color.Black;
            this.label70.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label70.Border.LeftColor = System.Drawing.Color.Black;
            this.label70.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label70.Border.RightColor = System.Drawing.Color.Black;
            this.label70.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label70.Border.TopColor = System.Drawing.Color.Black;
            this.label70.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label70.Height = 0.1968505F;
            this.label70.HyperLink = "";
            this.label70.Left = 1.141732F;
            this.label70.MultiLine = false;
            this.label70.Name = "label70";
            this.label70.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label70.Text = "16. Дата составления, подписи сторон";
            this.label70.Top = 16.69291F;
            this.label70.Width = 5.511811F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.RightColor = System.Drawing.Color.Black;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.TopColor = System.Drawing.Color.Black;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.CanGrow = false;
            this.textBox2.DataField = "ShipperInfo";
            this.textBox2.Height = 0.7480315F;
            this.textBox2.HyperLink = null;
            this.textBox2.Left = 0.07874016F;
            this.textBox2.Name = "textBox2";
            this.textBox2.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 10pt; font-f" +
    "amily: Tahoma; ";
            this.textBox2.Text = "ShipperInfo";
            this.textBox2.Top = 16.92913F;
            this.textBox2.Width = 3.740157F;
            // 
            // label71
            // 
            this.label71.Border.BottomColor = System.Drawing.Color.Black;
            this.label71.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label71.Border.LeftColor = System.Drawing.Color.Black;
            this.label71.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label71.Border.RightColor = System.Drawing.Color.Black;
            this.label71.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label71.Border.TopColor = System.Drawing.Color.Black;
            this.label71.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label71.Height = 0.1181102F;
            this.label71.HyperLink = "";
            this.label71.Left = 0.6299213F;
            this.label71.Name = "label71";
            this.label71.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label71.Text = "грузоотправитель, оттиск печати, дата, подпись";
            this.label71.Top = 17.67717F;
            this.label71.Width = 2.598425F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.RightColor = System.Drawing.Color.Black;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.TopColor = System.Drawing.Color.Black;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.CanGrow = false;
            this.textBox3.DataField = "OrganizationInfo";
            this.textBox3.Height = 0.7480315F;
            this.textBox3.HyperLink = null;
            this.textBox3.Left = 3.897638F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 10pt; font-f" +
    "amily: Tahoma; ";
            this.textBox3.Text = "OrganizationInfo";
            this.textBox3.Top = 16.92913F;
            this.textBox3.Width = 3.740157F;
            // 
            // label72
            // 
            this.label72.Border.BottomColor = System.Drawing.Color.Black;
            this.label72.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label72.Border.LeftColor = System.Drawing.Color.Black;
            this.label72.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label72.Border.RightColor = System.Drawing.Color.Black;
            this.label72.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label72.Border.TopColor = System.Drawing.Color.Black;
            this.label72.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label72.Height = 0.1181102F;
            this.label72.HyperLink = "";
            this.label72.Left = 4.448819F;
            this.label72.Name = "label72";
            this.label72.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label72.Text = "грузоперевозчик, оттиск печати, дата, подпись";
            this.label72.Top = 17.67717F;
            this.label72.Width = 2.598425F;
            // 
            // line34
            // 
            this.line34.Border.BottomColor = System.Drawing.Color.Black;
            this.line34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line34.Border.LeftColor = System.Drawing.Color.Black;
            this.line34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line34.Border.RightColor = System.Drawing.Color.Black;
            this.line34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line34.Border.TopColor = System.Drawing.Color.Black;
            this.line34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line34.Height = 0F;
            this.line34.Left = 0.03937008F;
            this.line34.LineWeight = 1F;
            this.line34.Name = "line34";
            this.line34.Top = 17.67717F;
            this.line34.Width = 7.637796F;
            this.line34.X1 = 0.03937008F;
            this.line34.X2 = 7.677166F;
            this.line34.Y1 = 17.67717F;
            this.line34.Y2 = 17.67717F;
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
            this.line35.Height = 0.7874107F;
            this.line35.Left = 3.858268F;
            this.line35.LineWeight = 1F;
            this.line35.Name = "line35";
            this.line35.Top = 16.88976F;
            this.line35.Width = 0F;
            this.line35.X1 = 3.858268F;
            this.line35.X2 = 3.858268F;
            this.line35.Y1 = 16.88976F;
            this.line35.Y2 = 17.67717F;
            // 
            // label73
            // 
            this.label73.Border.BottomColor = System.Drawing.Color.Black;
            this.label73.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label73.Border.LeftColor = System.Drawing.Color.Black;
            this.label73.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label73.Border.RightColor = System.Drawing.Color.Black;
            this.label73.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label73.Border.TopColor = System.Drawing.Color.Black;
            this.label73.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label73.Height = 0.1968505F;
            this.label73.HyperLink = "";
            this.label73.Left = 1.141732F;
            this.label73.MultiLine = false;
            this.label73.Name = "label73";
            this.label73.Style = "color: Black; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: " +
    "10pt; font-family: Tahoma; white-space: nowrap; ";
            this.label73.Text = "17. Отметки грузоотправителей, грузополучателей и перевозчиков";
            this.label73.Top = 18.38583F;
            this.label73.Width = 5.511811F;
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
            this.line36.Left = 0.03937008F;
            this.line36.LineWeight = 1F;
            this.line36.Name = "line36";
            this.line36.Top = 18.62205F;
            this.line36.Width = 7.637796F;
            this.line36.X1 = 0.03937008F;
            this.line36.X2 = 7.677166F;
            this.line36.Y1 = 18.62205F;
            this.line36.Y2 = 18.62205F;
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
            this.line37.Left = 0.03937008F;
            this.line37.LineWeight = 1F;
            this.line37.Name = "line37";
            this.line37.Top = 19.05512F;
            this.line37.Width = 7.637796F;
            this.line37.X1 = 0.03937008F;
            this.line37.X2 = 7.677166F;
            this.line37.Y1 = 19.05512F;
            this.line37.Y2 = 19.05512F;
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
            this.line38.Left = 0.03937008F;
            this.line38.LineWeight = 1F;
            this.line38.Name = "line38";
            this.line38.Top = 19.2126F;
            this.line38.Width = 7.637796F;
            this.line38.X1 = 0.03937008F;
            this.line38.X2 = 7.677166F;
            this.line38.Y1 = 19.2126F;
            this.line38.Y2 = 19.2126F;
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
            this.line39.Left = 0.03937008F;
            this.line39.LineWeight = 1F;
            this.line39.Name = "line39";
            this.line39.Top = 19.37008F;
            this.line39.Width = 7.637796F;
            this.line39.X1 = 0.03937008F;
            this.line39.X2 = 7.677166F;
            this.line39.Y1 = 19.37008F;
            this.line39.Y2 = 19.37008F;
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
            this.line40.Left = 0.03937008F;
            this.line40.LineWeight = 1F;
            this.line40.Name = "line40";
            this.line40.Top = 19.52756F;
            this.line40.Width = 7.637796F;
            this.line40.X1 = 0.03937008F;
            this.line40.X2 = 7.677166F;
            this.line40.Y1 = 19.52756F;
            this.line40.Y2 = 19.52756F;
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
            this.line41.Height = 0.9055099F;
            this.line41.Left = 3.858268F;
            this.line41.LineWeight = 1F;
            this.line41.Name = "line41";
            this.line41.Top = 18.62205F;
            this.line41.Width = 0F;
            this.line41.X1 = 3.858268F;
            this.line41.X2 = 3.858268F;
            this.line41.Y1 = 18.62205F;
            this.line41.Y2 = 19.52756F;
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
            this.line42.Height = 0.9055099F;
            this.line42.Left = 6.299213F;
            this.line42.LineWeight = 1F;
            this.line42.Name = "line42";
            this.line42.Top = 18.62205F;
            this.line42.Width = 0F;
            this.line42.X1 = 6.299213F;
            this.line42.X2 = 6.299213F;
            this.line42.Y1 = 18.62205F;
            this.line42.Y2 = 19.52756F;
            // 
            // label74
            // 
            this.label74.Border.BottomColor = System.Drawing.Color.Black;
            this.label74.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label74.Border.LeftColor = System.Drawing.Color.Black;
            this.label74.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label74.Border.RightColor = System.Drawing.Color.Black;
            this.label74.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label74.Border.TopColor = System.Drawing.Color.Black;
            this.label74.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label74.Height = 0.3543303F;
            this.label74.HyperLink = null;
            this.label74.Left = 0.07874016F;
            this.label74.Name = "label74";
            this.label74.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label74.Text = "Краткое описание обстоятельств, послуживших основанием для отметки";
            this.label74.Top = 18.66142F;
            this.label74.Width = 3.740157F;
            // 
            // label75
            // 
            this.label75.Border.BottomColor = System.Drawing.Color.Black;
            this.label75.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label75.Border.LeftColor = System.Drawing.Color.Black;
            this.label75.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label75.Border.RightColor = System.Drawing.Color.Black;
            this.label75.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label75.Border.TopColor = System.Drawing.Color.Black;
            this.label75.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label75.Height = 0.3543303F;
            this.label75.HyperLink = null;
            this.label75.Left = 3.897638F;
            this.label75.Name = "label75";
            this.label75.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label75.Text = "Расчет и размер штрафа";
            this.label75.Top = 18.66142F;
            this.label75.Width = 2.362205F;
            // 
            // label76
            // 
            this.label76.Border.BottomColor = System.Drawing.Color.Black;
            this.label76.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label76.Border.LeftColor = System.Drawing.Color.Black;
            this.label76.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label76.Border.RightColor = System.Drawing.Color.Black;
            this.label76.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label76.Border.TopColor = System.Drawing.Color.Black;
            this.label76.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label76.Height = 0.3543303F;
            this.label76.HyperLink = null;
            this.label76.Left = 6.338583F;
            this.label76.Name = "label76";
            this.label76.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label76.Text = "Подпись, дата";
            this.label76.Top = 18.66142F;
            this.label76.Width = 1.299212F;
            // 
            // label77
            // 
            this.label77.Border.BottomColor = System.Drawing.Color.Black;
            this.label77.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label77.Border.LeftColor = System.Drawing.Color.Black;
            this.label77.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label77.Border.RightColor = System.Drawing.Color.Black;
            this.label77.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label77.Border.TopColor = System.Drawing.Color.Black;
            this.label77.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label77.Height = 0.1574799F;
            this.label77.HyperLink = "";
            this.label77.Left = 0.6299213F;
            this.label77.Name = "label77";
            this.label77.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label77.Text = "М.П.";
            this.label77.Top = 17.95276F;
            this.label77.Width = 0.3937008F;
            // 
            // label78
            // 
            this.label78.Border.BottomColor = System.Drawing.Color.Black;
            this.label78.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label78.Border.LeftColor = System.Drawing.Color.Black;
            this.label78.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label78.Border.RightColor = System.Drawing.Color.Black;
            this.label78.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label78.Border.TopColor = System.Drawing.Color.Black;
            this.label78.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label78.Height = 0.1574799F;
            this.label78.HyperLink = "";
            this.label78.Left = 4.448819F;
            this.label78.Name = "label78";
            this.label78.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label78.Text = "М.П.";
            this.label78.Top = 17.95276F;
            this.label78.Width = 0.3937008F;
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
            this.line43.Left = 1.220472F;
            this.line43.LineWeight = 1F;
            this.line43.Name = "line43";
            this.line43.Top = 18.11024F;
            this.line43.Width = 1.968505F;
            this.line43.X1 = 1.220472F;
            this.line43.X2 = 3.188977F;
            this.line43.Y1 = 18.11024F;
            this.line43.Y2 = 18.11024F;
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
            this.line44.Left = 5.03937F;
            this.line44.LineWeight = 1F;
            this.line44.Name = "line44";
            this.line44.Top = 18.11024F;
            this.line44.Width = 1.968504F;
            this.line44.X1 = 5.03937F;
            this.line44.X2 = 7.007874F;
            this.line44.Y1 = 18.11024F;
            this.line44.Y2 = 18.11024F;
            // 
            // label79
            // 
            this.label79.Border.BottomColor = System.Drawing.Color.Black;
            this.label79.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label79.Border.LeftColor = System.Drawing.Color.Black;
            this.label79.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label79.Border.RightColor = System.Drawing.Color.Black;
            this.label79.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label79.Border.TopColor = System.Drawing.Color.Black;
            this.label79.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label79.Height = 0.1574799F;
            this.label79.HyperLink = "";
            this.label79.Left = 2.401575F;
            this.label79.Name = "label79";
            this.label79.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label79.Text = "М.П.";
            this.label79.Top = 5.314961F;
            this.label79.Width = 0.3937007F;
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
            this.line45.Left = 2.992126F;
            this.line45.LineWeight = 1F;
            this.line45.Name = "line45";
            this.line45.Top = 5.472441F;
            this.line45.Width = 1.968504F;
            this.line45.X1 = 2.992126F;
            this.line45.X2 = 4.96063F;
            this.line45.Y1 = 5.472441F;
            this.line45.Y2 = 5.472441F;
            // 
            // line46
            // 
            this.line46.Border.BottomColor = System.Drawing.Color.Black;
            this.line46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line46.Border.LeftColor = System.Drawing.Color.Black;
            this.line46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line46.Border.RightColor = System.Drawing.Color.Black;
            this.line46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line46.Border.TopColor = System.Drawing.Color.Black;
            this.line46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line46.Height = 0F;
            this.line46.Left = 5.393701F;
            this.line46.LineWeight = 1F;
            this.line46.Name = "line46";
            this.line46.Top = 5.472441F;
            this.line46.Width = 1.968504F;
            this.line46.X1 = 5.393701F;
            this.line46.X2 = 7.362205F;
            this.line46.Y1 = 5.472441F;
            this.line46.Y2 = 5.472441F;
            // 
            // label82
            // 
            this.label82.Border.BottomColor = System.Drawing.Color.Black;
            this.label82.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label82.Border.LeftColor = System.Drawing.Color.Black;
            this.label82.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label82.Border.RightColor = System.Drawing.Color.Black;
            this.label82.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label82.Border.TopColor = System.Drawing.Color.Black;
            this.label82.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label82.Height = 0.1181104F;
            this.label82.HyperLink = "";
            this.label82.Left = 5.472441F;
            this.label82.Name = "label82";
            this.label82.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label82.Text = "подпись водителя, сдавшего груз";
            this.label82.Top = 7.007874F;
            this.label82.Width = 1.968504F;
            // 
            // label83
            // 
            this.label83.Border.BottomColor = System.Drawing.Color.Black;
            this.label83.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label83.Border.LeftColor = System.Drawing.Color.Black;
            this.label83.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label83.Border.RightColor = System.Drawing.Color.Black;
            this.label83.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label83.Border.TopColor = System.Drawing.Color.Black;
            this.label83.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label83.Height = 0.1181104F;
            this.label83.HyperLink = "";
            this.label83.Left = 2.992126F;
            this.label83.Name = "label83";
            this.label83.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label83.Text = "грузополучатель";
            this.label83.Top = 7.007874F;
            this.label83.Width = 1.968504F;
            // 
            // label84
            // 
            this.label84.Border.BottomColor = System.Drawing.Color.Black;
            this.label84.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label84.Border.LeftColor = System.Drawing.Color.Black;
            this.label84.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label84.Border.RightColor = System.Drawing.Color.Black;
            this.label84.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label84.Border.TopColor = System.Drawing.Color.Black;
            this.label84.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label84.Height = 0.1574799F;
            this.label84.HyperLink = "";
            this.label84.Left = 2.401575F;
            this.label84.Name = "label84";
            this.label84.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label84.Text = "М.П.";
            this.label84.Top = 6.850394F;
            this.label84.Width = 0.3937007F;
            // 
            // line47
            // 
            this.line47.Border.BottomColor = System.Drawing.Color.Black;
            this.line47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line47.Border.LeftColor = System.Drawing.Color.Black;
            this.line47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line47.Border.RightColor = System.Drawing.Color.Black;
            this.line47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line47.Border.TopColor = System.Drawing.Color.Black;
            this.line47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line47.Height = 0F;
            this.line47.Left = 2.992126F;
            this.line47.LineWeight = 1F;
            this.line47.Name = "line47";
            this.line47.Top = 7.007874F;
            this.line47.Width = 1.968504F;
            this.line47.X1 = 2.992126F;
            this.line47.X2 = 4.96063F;
            this.line47.Y1 = 7.007874F;
            this.line47.Y2 = 7.007874F;
            // 
            // line48
            // 
            this.line48.Border.BottomColor = System.Drawing.Color.Black;
            this.line48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line48.Border.LeftColor = System.Drawing.Color.Black;
            this.line48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line48.Border.RightColor = System.Drawing.Color.Black;
            this.line48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line48.Border.TopColor = System.Drawing.Color.Black;
            this.line48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line48.Height = 0F;
            this.line48.Left = 5.511811F;
            this.line48.LineWeight = 1F;
            this.line48.Name = "line48";
            this.line48.Top = 7.007874F;
            this.line48.Width = 1.968504F;
            this.line48.X1 = 5.511811F;
            this.line48.X2 = 7.480315F;
            this.line48.Y1 = 7.007874F;
            this.line48.Y2 = 7.007874F;
            // 
            // label85
            // 
            this.label85.Border.BottomColor = System.Drawing.Color.Black;
            this.label85.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label85.Border.LeftColor = System.Drawing.Color.Black;
            this.label85.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label85.Border.RightColor = System.Drawing.Color.Black;
            this.label85.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label85.Border.TopColor = System.Drawing.Color.Black;
            this.label85.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label85.Height = 0.1181104F;
            this.label85.HyperLink = "";
            this.label85.Left = 5.393701F;
            this.label85.Name = "label85";
            this.label85.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 6pt; font-family: Tahoma; white-space: nowrap; ";
            this.label85.Text = "грузоперевозчик";
            this.label85.Top = 11.53543F;
            this.label85.Width = 1.968504F;
            // 
            // label86
            // 
            this.label86.Border.BottomColor = System.Drawing.Color.Black;
            this.label86.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label86.Border.LeftColor = System.Drawing.Color.Black;
            this.label86.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label86.Border.RightColor = System.Drawing.Color.Black;
            this.label86.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label86.Border.TopColor = System.Drawing.Color.Black;
            this.label86.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label86.Height = 0.1574799F;
            this.label86.HyperLink = "";
            this.label86.Left = 4.84252F;
            this.label86.Name = "label86";
            this.label86.Style = "color: Black; ddo-char-set: 204; text-align: center; font-style: normal; font-siz" +
    "e: 10pt; font-family: Tahoma; white-space: inherit; ";
            this.label86.Text = "М.П.";
            this.label86.Top = 11.37795F;
            this.label86.Width = 0.3937007F;
            // 
            // line49
            // 
            this.line49.Border.BottomColor = System.Drawing.Color.Black;
            this.line49.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line49.Border.LeftColor = System.Drawing.Color.Black;
            this.line49.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line49.Border.RightColor = System.Drawing.Color.Black;
            this.line49.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line49.Border.TopColor = System.Drawing.Color.Black;
            this.line49.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line49.Height = 0F;
            this.line49.Left = 5.393701F;
            this.line49.LineWeight = 1F;
            this.line49.Name = "line49";
            this.line49.Top = 11.53543F;
            this.line49.Width = 1.968504F;
            this.line49.X1 = 5.393701F;
            this.line49.X2 = 7.362205F;
            this.line49.Y1 = 11.53543F;
            this.line49.Y2 = 11.53543F;
            // 
            // txtCurrentUserName2
            // 
            this.txtCurrentUserName2.Border.BottomColor = System.Drawing.Color.Black;
            this.txtCurrentUserName2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName2.Border.LeftColor = System.Drawing.Color.Black;
            this.txtCurrentUserName2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName2.Border.RightColor = System.Drawing.Color.Black;
            this.txtCurrentUserName2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName2.Border.TopColor = System.Drawing.Color.Black;
            this.txtCurrentUserName2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtCurrentUserName2.Height = 0.1574804F;
            this.txtCurrentUserName2.HyperLink = null;
            this.txtCurrentUserName2.Left = 1.220472F;
            this.txtCurrentUserName2.MultiLine = false;
            this.txtCurrentUserName2.Name = "txtCurrentUserName2";
            this.txtCurrentUserName2.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 10pt; font-fam" +
    "ily: Tahoma; ";
            this.txtCurrentUserName2.Text = "CurrentUserName";
            this.txtCurrentUserName2.Top = 17.95276F;
            this.txtCurrentUserName2.Width = 1.968504F;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Height = 0F;
            this.GroupFooter1.KeepTogether = true;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0.02083333F;
            this.PageFooter.Name = "PageFooter";
            // 
            // TransportBill
            // 
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0.1968504F;
            this.PageSettings.Margins.Left = 0.1968504F;
            this.PageSettings.Margins.Right = 0.1968504F;
            this.PageSettings.Margins.Top = 0.1968504F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait;
            this.PageSettings.PaperHeight = 11.69291F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.PageSettings.PaperWidth = 8.267716F;
            this.PrintWidth = 7.755906F;
            this.Sections.Add(this.PageHeader);
            this.Sections.Add(this.GroupHeader1);
            this.Sections.Add(this.Detail);
            this.Sections.Add(this.GroupFooter1);
            this.Sections.Add(this.PageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.lblGroupHeader101)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label87)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label88)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderOrderNumbersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHeaderFactureNumbersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBillNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentUserName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label81)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label80)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Дата)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShipperInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConsigneeInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGoodName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxesWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNettoBrutto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirections1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDirections2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDischargeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPointDischarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargeStamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrganizationInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDriverName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label49)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label51)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCarInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label52)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label53)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label54)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label55)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label56)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label57)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label58)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label59)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label63)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label64)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label65)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReAddressing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label66)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label67)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label68)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label69)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label70)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label72)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label73)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label74)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label75)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label76)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label77)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label78)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label79)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label82)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label83)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label84)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label85)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label86)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentUserName2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    private DataDynamics.ActiveReports.TextBox txtDateOutput;
	private DataDynamics.ActiveReports.Label label24;
    private DataDynamics.ActiveReports.Label label25;
	private DataDynamics.ActiveReports.TextBox txtBillNumber;
	private DataDynamics.ActiveReports.Label label31;
    private DataDynamics.ActiveReports.Line line17;
    private DataDynamics.ActiveReports.Label label10;
    private DataDynamics.ActiveReports.Label Дата;
    private DataDynamics.ActiveReports.Label label32;
    private DataDynamics.ActiveReports.Line line18;
    private DataDynamics.ActiveReports.TextBox txtShipperInfo;
    private DataDynamics.ActiveReports.TextBox txtConsigneeInfo;
    private DataDynamics.ActiveReports.Label label33;
    private DataDynamics.ActiveReports.TextBox txtGoodName;
    private DataDynamics.ActiveReports.TextBox txtBoxesWords;
    private DataDynamics.ActiveReports.TextBox txtNettoBrutto;
    private DataDynamics.ActiveReports.Label label1;
    private DataDynamics.ActiveReports.TextBox txtDocuments;
    private DataDynamics.ActiveReports.Label label2;
    private DataDynamics.ActiveReports.TextBox txtDirections1;
    private DataDynamics.ActiveReports.TextBox txtDirections2;
    private DataDynamics.ActiveReports.Label label3;
    private DataDynamics.ActiveReports.TextBox txtPointCharge;
    private DataDynamics.ActiveReports.TextBox txtChargeData;
    private DataDynamics.ActiveReports.Label label4;
    private DataDynamics.ActiveReports.TextBox txtDischargeData;
    private DataDynamics.ActiveReports.Label label5;
    private DataDynamics.ActiveReports.TextBox txtPointDischarge;
    private DataDynamics.ActiveReports.TextBox txtChargeStamp;
    private DataDynamics.ActiveReports.Label label7;
    private DataDynamics.ActiveReports.Label label8;
    private DataDynamics.ActiveReports.Label label9;
    private DataDynamics.ActiveReports.Label label11;
    private DataDynamics.ActiveReports.Label label12;
    private DataDynamics.ActiveReports.Label label13;
    private DataDynamics.ActiveReports.Label label14;
    private DataDynamics.ActiveReports.Label label15;
    private DataDynamics.ActiveReports.Label label16;
    private DataDynamics.ActiveReports.Line line1;
    private DataDynamics.ActiveReports.Label label17;
    private DataDynamics.ActiveReports.Label label18;
    private DataDynamics.ActiveReports.Label label19;
    private DataDynamics.ActiveReports.Line line2;
    private DataDynamics.ActiveReports.Label label20;
    private DataDynamics.ActiveReports.Line line3;
    private DataDynamics.ActiveReports.Label label21;
    private DataDynamics.ActiveReports.Line line4;
    private DataDynamics.ActiveReports.Label label22;
    private DataDynamics.ActiveReports.Line line5;
    private DataDynamics.ActiveReports.Label label23;
    private DataDynamics.ActiveReports.Line line6;
    private DataDynamics.ActiveReports.Label label26;
    private DataDynamics.ActiveReports.Line line7;
    private DataDynamics.ActiveReports.Label label27;
    private DataDynamics.ActiveReports.Line line8;
    private DataDynamics.ActiveReports.Line line9;
    private DataDynamics.ActiveReports.Label label30;
    private DataDynamics.ActiveReports.Label label34;
    private DataDynamics.ActiveReports.Line line11;
    private DataDynamics.ActiveReports.Label label35;
    private DataDynamics.ActiveReports.TextBox textBox1;
    private DataDynamics.ActiveReports.Label label36;
    private DataDynamics.ActiveReports.Label label37;
    private DataDynamics.ActiveReports.Line line12;
    private DataDynamics.ActiveReports.Label label28;
    private DataDynamics.ActiveReports.Label label29;
    private DataDynamics.ActiveReports.Line line10;
    private DataDynamics.ActiveReports.Label label6;
    private DataDynamics.ActiveReports.Line line13;
    private DataDynamics.ActiveReports.Label label38;
    private DataDynamics.ActiveReports.Line line14;
    private DataDynamics.ActiveReports.Label label39;
    private DataDynamics.ActiveReports.Line line15;
    private DataDynamics.ActiveReports.Label label40;
    private DataDynamics.ActiveReports.Line line16;
    private DataDynamics.ActiveReports.Label label41;
    private DataDynamics.ActiveReports.Line line19;
    private DataDynamics.ActiveReports.Label label42;
    private DataDynamics.ActiveReports.Line line20;
    private DataDynamics.ActiveReports.Label label43;
    private DataDynamics.ActiveReports.Line line21;
    private DataDynamics.ActiveReports.Label label44;
    private DataDynamics.ActiveReports.Line line22;
    private DataDynamics.ActiveReports.Label label45;
    private DataDynamics.ActiveReports.Label label46;
    private DataDynamics.ActiveReports.Label label47;
    private DataDynamics.ActiveReports.TextBox txtOrganizationInfo;
    private DataDynamics.ActiveReports.Label label48;
    private DataDynamics.ActiveReports.Line line23;
    private DataDynamics.ActiveReports.TextBox txtDriverName;
    private DataDynamics.ActiveReports.Label label49;
    private DataDynamics.ActiveReports.Line line24;
    private DataDynamics.ActiveReports.Label label51;
    private DataDynamics.ActiveReports.Line line25;
    private DataDynamics.ActiveReports.Label label50;
    private DataDynamics.ActiveReports.TextBox txtCarInfo;
    private DataDynamics.ActiveReports.Label label52;
    private DataDynamics.ActiveReports.Line line26;
    private DataDynamics.ActiveReports.Label label53;
    private DataDynamics.ActiveReports.Line line27;
    private DataDynamics.ActiveReports.Label label54;
    private DataDynamics.ActiveReports.Label label55;
    private DataDynamics.ActiveReports.Label label56;
    private DataDynamics.ActiveReports.Label label57;
    private DataDynamics.ActiveReports.Line line28;
    private DataDynamics.ActiveReports.Label label58;
    private DataDynamics.ActiveReports.Label label59;
    private DataDynamics.ActiveReports.Label label60;
    private DataDynamics.ActiveReports.Label label61;
    private DataDynamics.ActiveReports.Line line29;
    private DataDynamics.ActiveReports.Label label62;
    private DataDynamics.ActiveReports.Label label63;
    private DataDynamics.ActiveReports.Line line30;
    private DataDynamics.ActiveReports.Label label64;
    private DataDynamics.ActiveReports.Line line31;
    private DataDynamics.ActiveReports.Label label65;
    private DataDynamics.ActiveReports.TextBox txtReAddressing;
    private DataDynamics.ActiveReports.Label label66;
    private DataDynamics.ActiveReports.Line line32;
    private DataDynamics.ActiveReports.Label label67;
    private DataDynamics.ActiveReports.Label label68;
    private DataDynamics.ActiveReports.Label label69;
    private DataDynamics.ActiveReports.Line line33;
    private DataDynamics.ActiveReports.Label label70;
    private DataDynamics.ActiveReports.TextBox textBox2;
    private DataDynamics.ActiveReports.Label label71;
    private DataDynamics.ActiveReports.TextBox textBox3;
    private DataDynamics.ActiveReports.Label label72;
    private DataDynamics.ActiveReports.Line line34;
    private DataDynamics.ActiveReports.Line line35;
    private DataDynamics.ActiveReports.Label label73;
    private DataDynamics.ActiveReports.Line line36;
    private DataDynamics.ActiveReports.Line line37;
    private DataDynamics.ActiveReports.Line line38;
    private DataDynamics.ActiveReports.Line line39;
    private DataDynamics.ActiveReports.Line line40;
    private DataDynamics.ActiveReports.Line line41;
    private DataDynamics.ActiveReports.Line line42;
    private DataDynamics.ActiveReports.Label label74;
    private DataDynamics.ActiveReports.Label label75;
    private DataDynamics.ActiveReports.Label label76;
    private DataDynamics.ActiveReports.Label label77;
    private DataDynamics.ActiveReports.Label label78;
    private DataDynamics.ActiveReports.Line line43;
    private DataDynamics.ActiveReports.Line line44;
    private DataDynamics.ActiveReports.Label label81;
    private DataDynamics.ActiveReports.Label label80;
    private DataDynamics.ActiveReports.Label label79;
    private DataDynamics.ActiveReports.Line line45;
    private DataDynamics.ActiveReports.Line line46;
    private DataDynamics.ActiveReports.Label label82;
    private DataDynamics.ActiveReports.Label label83;
    private DataDynamics.ActiveReports.Label label84;
    private DataDynamics.ActiveReports.Line line47;
    private DataDynamics.ActiveReports.Line line48;
    private DataDynamics.ActiveReports.Label label85;
    private DataDynamics.ActiveReports.Label label86;
    private DataDynamics.ActiveReports.Line line49;
    private DataDynamics.ActiveReports.TextBox txtCurrentUserName1;
    private DataDynamics.ActiveReports.TextBox txtCurrentUserName2;
        private DataDynamics.ActiveReports.Label label87;
        private DataDynamics.ActiveReports.Label label88;
        private DataDynamics.ActiveReports.TextBox txtHeaderOrderNumbersList;
        private DataDynamics.ActiveReports.TextBox txtHeaderFactureNumbersList;
    }
}