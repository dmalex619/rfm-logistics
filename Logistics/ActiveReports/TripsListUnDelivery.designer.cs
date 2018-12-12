namespace Logistics
{
	/// <summary>
	/// Summary description for TripsListUnDelivery.
	/// </summary>
	partial class TripsListUnDelivery
	{
		private DataDynamics.ActiveReports.PageHeader pageHeader;
		private DataDynamics.ActiveReports.Detail detail;
		private DataDynamics.ActiveReports.PageFooter pageFooter;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
			}
			base.Dispose(disposing);
		}

		#region ActiveReport Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TripsListUnDelivery));
			this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
			this.reportInfo1 = new DataDynamics.ActiveReports.ReportInfo();
			this.label7 = new DataDynamics.ActiveReports.Label();
			this.detail = new DataDynamics.ActiveReports.Detail();
			this.txtPackingName1 = new DataDynamics.ActiveReports.TextBox();
			this.line1 = new DataDynamics.ActiveReports.Line();
			this.txtInBox = new DataDynamics.ActiveReports.TextBox();
			this.txtQntActed = new DataDynamics.ActiveReports.TextBox();
			this.txtQntDelivered = new DataDynamics.ActiveReports.TextBox();
			this.txtQntShipped = new DataDynamics.ActiveReports.TextBox();
			this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
			this.reportInfo2 = new DataDynamics.ActiveReports.ReportInfo();
			this.groupTripID = new DataDynamics.ActiveReports.GroupHeader();
			this.txtTripAlias = new DataDynamics.ActiveReports.TextBox();
			this.textBox10 = new DataDynamics.ActiveReports.TextBox();
			this.groupTripIDFooter = new DataDynamics.ActiveReports.GroupFooter();
			this.line4 = new DataDynamics.ActiveReports.Line();
			this.groupBillNumber = new DataDynamics.ActiveReports.GroupHeader();
			this.label8 = new DataDynamics.ActiveReports.Label();
			this.label5 = new DataDynamics.ActiveReports.Label();
			this.label15 = new DataDynamics.ActiveReports.Label();
			this.label4 = new DataDynamics.ActiveReports.Label();
			this.line2 = new DataDynamics.ActiveReports.Line();
			this.label3 = new DataDynamics.ActiveReports.Label();
			this.txtPartnerName = new DataDynamics.ActiveReports.TextBox();
			this.lblPartnerName = new DataDynamics.ActiveReports.Label();
			this.lblBillNumber = new DataDynamics.ActiveReports.Label();
			this.txtBillNumber = new DataDynamics.ActiveReports.TextBox();
			this.line5 = new DataDynamics.ActiveReports.Line();
			this.line6 = new DataDynamics.ActiveReports.Line();
			this.groupBillNumberFooter = new DataDynamics.ActiveReports.GroupFooter();
			this.textBox1 = new DataDynamics.ActiveReports.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPackingName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQntActed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQntDelivered)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQntShipped)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTripAlias)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox10)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPartnerName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPartnerName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBillNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillNumber)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// pageHeader
			// 
			this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo1,
            this.label7});
			this.pageHeader.Height = 0.1979167F;
			this.pageHeader.Name = "pageHeader";
			// 
			// reportInfo1
			// 
			this.reportInfo1.Border.BottomColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.Border.LeftColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.Border.RightColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.Border.TopColor = System.Drawing.Color.Black;
			this.reportInfo1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo1.FormatString = "Стр. {PageNumber} из {PageCount}";
			this.reportInfo1.Height = 0.1968504F;
			this.reportInfo1.Left = 6.220472F;
			this.reportInfo1.Name = "reportInfo1";
			this.reportInfo1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; ";
			this.reportInfo1.Top = 0F;
			this.reportInfo1.Width = 1.181103F;
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
			this.label7.Height = 0.1968504F;
			this.label7.HyperLink = null;
			this.label7.Left = 0.07874016F;
			this.label7.Name = "label7";
			this.label7.Style = "ddo-char-set: 204; font-weight: bold; font-size: 9.75pt; font-family: Tahoma; ";
			this.label7.Text = "Отчет заказано-доставлено";
			this.label7.Top = 0F;
			this.label7.Width = 5.787402F;
			// 
			// detail
			// 
			this.detail.ColumnSpacing = 0F;
			this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtPackingName1,
            this.line1,
            this.txtInBox,
            this.txtQntActed,
            this.txtQntDelivered,
            this.txtQntShipped});
			this.detail.Height = 0.1770833F;
			this.detail.KeepTogether = true;
			this.detail.Name = "detail";
			this.detail.Format += new System.EventHandler(this.detail_Format);
			this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
			// 
			// txtPackingName1
			// 
			this.txtPackingName1.Border.BottomColor = System.Drawing.Color.Black;
			this.txtPackingName1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPackingName1.Border.LeftColor = System.Drawing.Color.Black;
			this.txtPackingName1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPackingName1.Border.RightColor = System.Drawing.Color.Black;
			this.txtPackingName1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPackingName1.Border.TopColor = System.Drawing.Color.Black;
			this.txtPackingName1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPackingName1.DataField = "GoodAlias";
			this.txtPackingName1.Height = 0.1574803F;
			this.txtPackingName1.Left = 0.07874016F;
			this.txtPackingName1.Name = "txtPackingName1";
			this.txtPackingName1.Style = "";
			this.txtPackingName1.Text = "GoodAlias";
			this.txtPackingName1.Top = 0F;
			this.txtPackingName1.Width = 3.228347F;
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
			this.line1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot;
			this.line1.LineWeight = 1F;
			this.line1.Name = "line1";
			this.line1.Top = 0.1968504F;
			this.line1.Width = 7.401575F;
			this.line1.X1 = 0.03937008F;
			this.line1.X2 = 7.440945F;
			this.line1.Y1 = 0.1968504F;
			this.line1.Y2 = 0.1968504F;
			// 
			// txtInBox
			// 
			this.txtInBox.Border.BottomColor = System.Drawing.Color.Black;
			this.txtInBox.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtInBox.Border.LeftColor = System.Drawing.Color.Black;
			this.txtInBox.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtInBox.Border.RightColor = System.Drawing.Color.Black;
			this.txtInBox.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtInBox.Border.TopColor = System.Drawing.Color.Black;
			this.txtInBox.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtInBox.DataField = "InBox";
			this.txtInBox.Height = 0.1574803F;
			this.txtInBox.Left = 3.1875F;
			this.txtInBox.Name = "txtInBox";
			this.txtInBox.OutputFormat = resources.GetString("txtInBox.OutputFormat");
			this.txtInBox.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
			this.txtInBox.Text = "txtInBox";
			this.txtInBox.Top = 0.02083333F;
			this.txtInBox.Width = 0.551181F;
			// 
			// txtQntActed
			// 
			this.txtQntActed.Border.BottomColor = System.Drawing.Color.Black;
			this.txtQntActed.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntActed.Border.LeftColor = System.Drawing.Color.Black;
			this.txtQntActed.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntActed.Border.RightColor = System.Drawing.Color.Black;
			this.txtQntActed.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntActed.Border.TopColor = System.Drawing.Color.Black;
			this.txtQntActed.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntActed.DataField = "QntWished";
			this.txtQntActed.Height = 0.1968504F;
			this.txtQntActed.Left = 4.448819F;
			this.txtQntActed.Name = "txtQntActed";
			this.txtQntActed.OutputFormat = resources.GetString("txtQntActed.OutputFormat");
			this.txtQntActed.Style = "text-align: right; ";
			this.txtQntActed.Text = "txtQntActed";
			this.txtQntActed.Top = 0F;
			this.txtQntActed.Width = 0.7480316F;
			// 
			// txtQntDelivered
			// 
			this.txtQntDelivered.Border.BottomColor = System.Drawing.Color.Black;
			this.txtQntDelivered.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntDelivered.Border.LeftColor = System.Drawing.Color.Black;
			this.txtQntDelivered.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntDelivered.Border.RightColor = System.Drawing.Color.Black;
			this.txtQntDelivered.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntDelivered.Border.TopColor = System.Drawing.Color.Black;
			this.txtQntDelivered.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntDelivered.DataField = "QntBrought";
			this.txtQntDelivered.Height = 0.1968504F;
			this.txtQntDelivered.Left = 6.614173F;
			this.txtQntDelivered.Name = "txtQntDelivered";
			this.txtQntDelivered.OutputFormat = resources.GetString("txtQntDelivered.OutputFormat");
			this.txtQntDelivered.Style = "text-align: right; ";
			this.txtQntDelivered.Text = "txtQntDelivered";
			this.txtQntDelivered.Top = 0F;
			this.txtQntDelivered.Width = 0.7480314F;
			// 
			// txtQntShipped
			// 
			this.txtQntShipped.Border.BottomColor = System.Drawing.Color.Black;
			this.txtQntShipped.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntShipped.Border.LeftColor = System.Drawing.Color.Black;
			this.txtQntShipped.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntShipped.Border.RightColor = System.Drawing.Color.Black;
			this.txtQntShipped.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntShipped.Border.TopColor = System.Drawing.Color.Black;
			this.txtQntShipped.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtQntShipped.DataField = "QntConfirmed";
			this.txtQntShipped.Height = 0.1968504F;
			this.txtQntShipped.Left = 5.551181F;
			this.txtQntShipped.Name = "txtQntShipped";
			this.txtQntShipped.OutputFormat = resources.GetString("txtQntShipped.OutputFormat");
			this.txtQntShipped.Style = "text-align: right; ";
			this.txtQntShipped.Text = "txtQntShipped";
			this.txtQntShipped.Top = 0F;
			this.txtQntShipped.Width = 0.7480316F;
			// 
			// pageFooter
			// 
			this.pageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo2});
			this.pageFooter.Height = 0.125F;
			this.pageFooter.Name = "pageFooter";
			// 
			// reportInfo2
			// 
			this.reportInfo2.Border.BottomColor = System.Drawing.Color.Black;
			this.reportInfo2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo2.Border.LeftColor = System.Drawing.Color.Black;
			this.reportInfo2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo2.Border.RightColor = System.Drawing.Color.Black;
			this.reportInfo2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo2.Border.TopColor = System.Drawing.Color.Black;
			this.reportInfo2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.reportInfo2.FormatString = "{RunDateTime:dd.MM.yyyy HH:mm}";
			this.reportInfo2.Height = 0.1145833F;
			this.reportInfo2.Left = 5.748032F;
			this.reportInfo2.Name = "reportInfo2";
			this.reportInfo2.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; ";
			this.reportInfo2.Top = 0F;
			this.reportInfo2.Width = 1.65625F;
			// 
			// groupTripID
			// 
			this.groupTripID.CanShrink = true;
			this.groupTripID.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtTripAlias,
            this.textBox10});
			this.groupTripID.DataField = "TripID";
			this.groupTripID.Height = 0.2291667F;
			this.groupTripID.KeepTogether = true;
			this.groupTripID.Name = "groupTripID";
			this.groupTripID.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail;
			// 
			// txtTripAlias
			// 
			this.txtTripAlias.Border.BottomColor = System.Drawing.Color.Black;
			this.txtTripAlias.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtTripAlias.Border.LeftColor = System.Drawing.Color.Black;
			this.txtTripAlias.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtTripAlias.Border.RightColor = System.Drawing.Color.Black;
			this.txtTripAlias.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtTripAlias.Border.TopColor = System.Drawing.Color.Black;
			this.txtTripAlias.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtTripAlias.DataField = "TripAlias";
			this.txtTripAlias.Height = 0.1968504F;
			this.txtTripAlias.Left = 1.181102F;
			this.txtTripAlias.MultiLine = false;
			this.txtTripAlias.Name = "txtTripAlias";
			this.txtTripAlias.OutputFormat = resources.GetString("txtTripAlias.OutputFormat");
			this.txtTripAlias.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10pt; white-spac" +
				"e: nowrap; ";
			this.txtTripAlias.Text = "TripAlias";
			this.txtTripAlias.Top = 0.03937008F;
			this.txtTripAlias.Width = 6.259842F;
			// 
			// textBox10
			// 
			this.textBox10.Border.BottomColor = System.Drawing.Color.Black;
			this.textBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBox10.Border.LeftColor = System.Drawing.Color.Black;
			this.textBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBox10.Border.RightColor = System.Drawing.Color.Black;
			this.textBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBox10.Border.TopColor = System.Drawing.Color.Black;
			this.textBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBox10.DataField = "DateTrip";
			this.textBox10.Height = 0.1968504F;
			this.textBox10.Left = 0.03937008F;
			this.textBox10.Name = "textBox10";
			this.textBox10.OutputFormat = resources.GetString("textBox10.OutputFormat");
			this.textBox10.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; ";
			this.textBox10.Text = "DateTrip";
			this.textBox10.Top = 0.03937008F;
			this.textBox10.Width = 1.023622F;
			// 
			// groupTripIDFooter
			// 
			this.groupTripIDFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.line4});
			this.groupTripIDFooter.Height = 0.08333334F;
			this.groupTripIDFooter.KeepTogether = true;
			this.groupTripIDFooter.Name = "groupTripIDFooter";
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
			this.line4.LineWeight = 6F;
			this.line4.Name = "line4";
			this.line4.Top = 0.03010171F;
			this.line4.Width = 7.401575F;
			this.line4.X1 = 0.03937008F;
			this.line4.X2 = 7.440945F;
			this.line4.Y1 = 0.03010171F;
			this.line4.Y2 = 0.03010171F;
			// 
			// groupBillNumber
			// 
			this.groupBillNumber.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label8,
            this.label5,
            this.label15,
            this.label4,
            this.line2,
            this.label3,
            this.txtPartnerName,
            this.lblPartnerName,
            this.lblBillNumber,
            this.txtBillNumber,
            this.line5,
            this.line6,
            this.textBox1});
			this.groupBillNumber.DataField = "BillNumber";
			this.groupBillNumber.Height = 0.4166667F;
			this.groupBillNumber.Name = "groupBillNumber";
			this.groupBillNumber.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPage;
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
			this.label8.Left = 4.40625F;
			this.label8.Name = "label8";
			this.label8.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
			this.label8.Text = "Заказано";
			this.label8.Top = 0.2395833F;
			this.label8.Width = 0.7874016F;
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
			this.label5.Height = 0.1574803F;
			this.label5.HyperLink = null;
			this.label5.Left = 5.666667F;
			this.label5.Name = "label5";
			this.label5.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
			this.label5.Text = "Отгружено";
			this.label5.Top = 0.2395833F;
			this.label5.Width = 0.6299211F;
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
			this.label15.Height = 0.1574803F;
			this.label15.HyperLink = null;
			this.label15.Left = 3.302083F;
			this.label15.Name = "label15";
			this.label15.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
			this.label15.Text = "В кор.";
			this.label15.Top = 0.2395833F;
			this.label15.Width = 0.433071F;
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
			this.label4.Height = 0.1574803F;
			this.label4.HyperLink = null;
			this.label4.Left = 0.08333334F;
			this.label4.Name = "label4";
			this.label4.Style = "ddo-char-set: 1; font-size: 8pt; ";
			this.label4.Text = "Товар";
			this.label4.Top = 0.2395833F;
			this.label4.Width = 0.5511811F;
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
			this.line2.Top = 0.242044F;
			this.line2.Width = 7.401575F;
			this.line2.X1 = 0.03937008F;
			this.line2.X2 = 7.440945F;
			this.line2.Y1 = 0.242044F;
			this.line2.Y2 = 0.242044F;
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
			this.label3.Height = 0.1574803F;
			this.label3.HyperLink = null;
			this.label3.Left = 6.572917F;
			this.label3.Name = "label3";
			this.label3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
			this.label3.Text = "Доставлено";
			this.label3.Top = 0.2395833F;
			this.label3.Width = 0.7874015F;
			// 
			// txtPartnerName
			// 
			this.txtPartnerName.Border.BottomColor = System.Drawing.Color.Black;
			this.txtPartnerName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPartnerName.Border.LeftColor = System.Drawing.Color.Black;
			this.txtPartnerName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPartnerName.Border.RightColor = System.Drawing.Color.Black;
			this.txtPartnerName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPartnerName.Border.TopColor = System.Drawing.Color.Black;
			this.txtPartnerName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtPartnerName.DataField = "PartnerName";
			this.txtPartnerName.Height = 0.1574803F;
			this.txtPartnerName.Left = 0.8267717F;
			this.txtPartnerName.Name = "txtPartnerName";
			this.txtPartnerName.Style = "font-weight: bold; ";
			this.txtPartnerName.Text = "PartnerName";
			this.txtPartnerName.Top = 0.03937008F;
			this.txtPartnerName.Width = 3.858268F;
			// 
			// lblPartnerName
			// 
			this.lblPartnerName.Border.BottomColor = System.Drawing.Color.Black;
			this.lblPartnerName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblPartnerName.Border.LeftColor = System.Drawing.Color.Black;
			this.lblPartnerName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblPartnerName.Border.RightColor = System.Drawing.Color.Black;
			this.lblPartnerName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblPartnerName.Border.TopColor = System.Drawing.Color.Black;
			this.lblPartnerName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblPartnerName.Height = 0.1574803F;
			this.lblPartnerName.HyperLink = null;
			this.lblPartnerName.Left = 0.07874016F;
			this.lblPartnerName.Name = "lblPartnerName";
			this.lblPartnerName.Style = "ddo-char-set: 1; font-size: 8pt; ";
			this.lblPartnerName.Text = "Контрагент";
			this.lblPartnerName.Top = 0.03937008F;
			this.lblPartnerName.Width = 0.6692913F;
			// 
			// lblBillNumber
			// 
			this.lblBillNumber.Border.BottomColor = System.Drawing.Color.Black;
			this.lblBillNumber.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblBillNumber.Border.LeftColor = System.Drawing.Color.Black;
			this.lblBillNumber.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblBillNumber.Border.RightColor = System.Drawing.Color.Black;
			this.lblBillNumber.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblBillNumber.Border.TopColor = System.Drawing.Color.Black;
			this.lblBillNumber.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lblBillNumber.Height = 0.1574803F;
			this.lblBillNumber.HyperLink = null;
			this.lblBillNumber.Left = 5.708662F;
			this.lblBillNumber.Name = "lblBillNumber";
			this.lblBillNumber.Style = "ddo-char-set: 1; font-size: 8pt; ";
			this.lblBillNumber.Text = "Накл. №";
			this.lblBillNumber.Top = 0.03937008F;
			this.lblBillNumber.Width = 0.511811F;
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
			this.txtBillNumber.DataField = "BillNumber";
			this.txtBillNumber.Height = 0.1574803F;
			this.txtBillNumber.Left = 6.259842F;
			this.txtBillNumber.Name = "txtBillNumber";
			this.txtBillNumber.Style = "font-weight: bold; ";
			this.txtBillNumber.Text = "BillNumber";
			this.txtBillNumber.Top = 0.03937008F;
			this.txtBillNumber.Width = 1.181102F;
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
			this.line5.Top = 0.3995243F;
			this.line5.Width = 7.401575F;
			this.line5.X1 = 0.03937008F;
			this.line5.X2 = 7.440945F;
			this.line5.Y1 = 0.3995243F;
			this.line5.Y2 = 0.3995243F;
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
			this.line6.LineWeight = 3F;
			this.line6.Name = "line6";
			this.line6.Top = 0.01853675F;
			this.line6.Width = 7.401575F;
			this.line6.X1 = 0.03937008F;
			this.line6.X2 = 7.440945F;
			this.line6.Y1 = 0.01853675F;
			this.line6.Y2 = 0.01853675F;
			// 
			// groupBillNumberFooter
			// 
			this.groupBillNumberFooter.Height = 0.03125F;
			this.groupBillNumberFooter.Name = "groupBillNumberFooter";
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
			this.textBox1.DataField = "OwnerName";
			this.textBox1.Height = 0.1574803F;
			this.textBox1.Left = 4.448819F;
			this.textBox1.Name = "textBox1";
			this.textBox1.Style = "text-align: right; font-weight: bold; font-style: italic; ";
			this.textBox1.Text = "OwnerName";
			this.textBox1.Top = 0.03937008F;
			this.textBox1.Width = 1.181102F;
			// 
			// TripsListUnDelivery
			// 
			this.PageSettings.DefaultPaperSize = false;
			this.PageSettings.Margins.Bottom = 0.3937008F;
			this.PageSettings.Margins.Left = 0.3937008F;
			this.PageSettings.Margins.Right = 0.3937008F;
			this.PageSettings.Margins.Top = 0.3937008F;
			this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait;
			this.PageSettings.PaperHeight = 11.69291F;
			this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
			this.PageSettings.PaperWidth = 8.267716F;
			this.PrintWidth = 7.480315F;
			this.Sections.Add(this.pageHeader);
			this.Sections.Add(this.groupTripID);
			this.Sections.Add(this.groupBillNumber);
			this.Sections.Add(this.detail);
			this.Sections.Add(this.groupBillNumberFooter);
			this.Sections.Add(this.groupTripIDFooter);
			this.Sections.Add(this.pageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
						"color: Black; font-family: \"Tahoma\"; ddo-char-set: 204; ", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 12pt; ", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
			this.FetchData += new DataDynamics.ActiveReports.ActiveReport3.FetchEventHandler(this.TripsListUnDelivery_FetchData);
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPackingName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQntActed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQntDelivered)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtQntShipped)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtTripAlias)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox10)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPartnerName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblPartnerName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lblBillNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtBillNumber)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private DataDynamics.ActiveReports.GroupHeader groupTripID;
		private DataDynamics.ActiveReports.GroupFooter groupTripIDFooter;
		private DataDynamics.ActiveReports.ReportInfo reportInfo1;
        private DataDynamics.ActiveReports.TextBox txtPackingName1;
		private DataDynamics.ActiveReports.ReportInfo reportInfo2;
		private DataDynamics.ActiveReports.Line line4;
		private DataDynamics.ActiveReports.Line line1;
		private DataDynamics.ActiveReports.TextBox txtInBox;
        private DataDynamics.ActiveReports.TextBox txtTripAlias;
        private DataDynamics.ActiveReports.Label label7;
		private DataDynamics.ActiveReports.TextBox txtQntActed;
		private DataDynamics.ActiveReports.TextBox txtQntDelivered;
        private DataDynamics.ActiveReports.TextBox txtQntShipped;
        private DataDynamics.ActiveReports.TextBox textBox10;
        private DataDynamics.ActiveReports.GroupHeader groupBillNumber;
        private DataDynamics.ActiveReports.Label label8;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.Label label15;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.Line line2;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.GroupFooter groupBillNumberFooter;
        private DataDynamics.ActiveReports.TextBox txtPartnerName;
        private DataDynamics.ActiveReports.Label lblPartnerName;
        private DataDynamics.ActiveReports.Label lblBillNumber;
        private DataDynamics.ActiveReports.TextBox txtBillNumber;
        private DataDynamics.ActiveReports.Line line5;
        private DataDynamics.ActiveReports.Line line6;
		private DataDynamics.ActiveReports.TextBox textBox1;
	}
}
