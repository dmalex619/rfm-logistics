namespace Logistics
{
	/// <summary>
	/// Summary description for TripBalance.
	/// </summary>
	partial class TripBalance
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TripBalance));
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.reportInfo1 = new DataDynamics.ActiveReports.ReportInfo();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.txtQntReturned = new DataDynamics.ActiveReports.TextBox();
            this.txtPackingName1 = new DataDynamics.ActiveReports.TextBox();
            this.txtQntTripBalance = new DataDynamics.ActiveReports.TextBox();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.txtInBox = new DataDynamics.ActiveReports.TextBox();
            this.txtQntActed = new DataDynamics.ActiveReports.TextBox();
            this.txtQntDelivered = new DataDynamics.ActiveReports.TextBox();
            this.txtQntShipped = new DataDynamics.ActiveReports.TextBox();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.reportInfo2 = new DataDynamics.ActiveReports.ReportInfo();
            this.groupTripID = new DataDynamics.ActiveReports.GroupHeader();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.label15 = new DataDynamics.ActiveReports.Label();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.txtTripAlias = new DataDynamics.ActiveReports.TextBox();
            this.textBox10 = new DataDynamics.ActiveReports.TextBox();
            this.line2 = new DataDynamics.ActiveReports.Line();
            this.line5 = new DataDynamics.ActiveReports.Line();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.txtDateBeg = new DataDynamics.ActiveReports.TextBox();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.txtDateEnd = new DataDynamics.ActiveReports.TextBox();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.txtDateConfirm = new DataDynamics.ActiveReports.TextBox();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.groupTripIDFooter = new DataDynamics.ActiveReports.GroupFooter();
            this.line4 = new DataDynamics.ActiveReports.Line();
            this.line3 = new DataDynamics.ActiveReports.Line();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntReturned)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackingName1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntTripBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntActed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntDelivered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntShipped)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTripAlias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateBeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateConfirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
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
            this.label7.Text = "Баланс товаров по рейсам";
            this.label7.Top = 0F;
            this.label7.Width = 5.787402F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtQntReturned,
            this.txtPackingName1,
            this.txtQntTripBalance,
            this.line1,
            this.txtInBox,
            this.txtQntActed,
            this.txtQntDelivered,
            this.txtQntShipped});
            this.detail.Height = 0.2234799F;
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
            // 
            // txtQntReturned
            // 
            this.txtQntReturned.Border.BottomColor = System.Drawing.Color.Black;
            this.txtQntReturned.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntReturned.Border.LeftColor = System.Drawing.Color.Black;
            this.txtQntReturned.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntReturned.Border.RightColor = System.Drawing.Color.Black;
            this.txtQntReturned.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntReturned.Border.TopColor = System.Drawing.Color.Black;
            this.txtQntReturned.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntReturned.DataField = "QntReturned";
            this.txtQntReturned.Height = 0.1968504F;
            this.txtQntReturned.Left = 5.944882F;
            this.txtQntReturned.Name = "txtQntReturned";
            this.txtQntReturned.OutputFormat = resources.GetString("txtQntReturned.OutputFormat");
            this.txtQntReturned.Style = "text-align: right; ";
            this.txtQntReturned.Text = "txtQntReturned";
            this.txtQntReturned.Top = 0F;
            this.txtQntReturned.Width = 0.7480318F;
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
            // txtQntTripBalance
            // 
            this.txtQntTripBalance.Border.BottomColor = System.Drawing.Color.Black;
            this.txtQntTripBalance.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntTripBalance.Border.LeftColor = System.Drawing.Color.Black;
            this.txtQntTripBalance.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntTripBalance.Border.RightColor = System.Drawing.Color.Black;
            this.txtQntTripBalance.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntTripBalance.Border.TopColor = System.Drawing.Color.Black;
            this.txtQntTripBalance.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtQntTripBalance.DataField = "QntTripBalance";
            this.txtQntTripBalance.Height = 0.1968504F;
            this.txtQntTripBalance.Left = 6.692914F;
            this.txtQntTripBalance.Name = "txtQntTripBalance";
            this.txtQntTripBalance.OutputFormat = resources.GetString("txtQntTripBalance.OutputFormat");
            this.txtQntTripBalance.Style = "text-align: right; ";
            this.txtQntTripBalance.Text = "txtQntTripBalance";
            this.txtQntTripBalance.Top = 0F;
            this.txtQntTripBalance.Width = 0.7480316F;
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
            this.line1.Top = 0.2165354F;
            this.line1.Width = 7.401575F;
            this.line1.X1 = 0.03937008F;
            this.line1.X2 = 7.440945F;
            this.line1.Y1 = 0.2165354F;
            this.line1.Y2 = 0.2165354F;
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
            this.txtQntActed.DataField = "QntActed";
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
            this.txtQntDelivered.DataField = "QntDelivered";
            this.txtQntDelivered.Height = 0.1968504F;
            this.txtQntDelivered.Left = 5.19685F;
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
            this.txtQntShipped.DataField = "QntShipped";
            this.txtQntShipped.Height = 0.1968504F;
            this.txtQntShipped.Left = 3.700788F;
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
            this.label8,
            this.label5,
            this.label15,
            this.label4,
            this.txtTripAlias,
            this.textBox10,
            this.line2,
            this.line5,
            this.label1,
            this.label2,
            this.label3,
            this.txtDateBeg,
            this.label6,
            this.txtDateEnd,
            this.label9,
            this.txtDateConfirm,
            this.label10});
            this.groupTripID.DataField = "TripID";
            this.groupTripID.Height = 0.6875F;
            this.groupTripID.KeepTogether = true;
            this.groupTripID.Name = "groupTripID";
            this.groupTripID.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail;
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
            this.label8.Text = "Сактировано";
            this.label8.Top = 0.5F;
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
            this.label5.Left = 3.822917F;
            this.label5.Name = "label5";
            this.label5.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
            this.label5.Text = "Отгружено";
            this.label5.Top = 0.5F;
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
            this.label15.Top = 0.5F;
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
            this.label4.Top = 0.5F;
            this.label4.Width = 0.5511811F;
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
            this.txtTripAlias.Left = 0.07874016F;
            this.txtTripAlias.MultiLine = false;
            this.txtTripAlias.Name = "txtTripAlias";
            this.txtTripAlias.OutputFormat = resources.GetString("txtTripAlias.OutputFormat");
            this.txtTripAlias.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10pt; white-spac" +
                "e: nowrap; ";
            this.txtTripAlias.Text = "TripAlias";
            this.txtTripAlias.Top = 0.03937008F;
            this.txtTripAlias.Width = 7.362205F;
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
            this.textBox10.Left = 0.08333334F;
            this.textBox10.Name = "textBox10";
            this.textBox10.OutputFormat = resources.GetString("textBox10.OutputFormat");
            this.textBox10.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; ";
            this.textBox10.Text = "DateTrip";
            this.textBox10.Top = 0.2604167F;
            this.textBox10.Width = 1.141732F;
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
            this.line2.Top = 0.6588747F;
            this.line2.Width = 7.401575F;
            this.line2.X1 = 0.03937008F;
            this.line2.X2 = 7.440945F;
            this.line2.Y1 = 0.6588747F;
            this.line2.Y2 = 0.6588747F;
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
            this.line5.Top = 0.5013943F;
            this.line5.Width = 7.401575F;
            this.line5.X1 = 0.03937008F;
            this.line5.X2 = 7.440945F;
            this.line5.Y1 = 0.5013943F;
            this.line5.Y2 = 0.5013943F;
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
            this.label1.Height = 0.1574803F;
            this.label1.HyperLink = null;
            this.label1.Left = 6.927083F;
            this.label1.Name = "label1";
            this.label1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
            this.label1.Text = "Баланс";
            this.label1.Top = 0.5F;
            this.label1.Width = 0.5118107F;
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
            this.label2.Height = 0.1574803F;
            this.label2.HyperLink = null;
            this.label2.Left = 5.90625F;
            this.label2.Name = "label2";
            this.label2.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
            this.label2.Text = "Возвращено";
            this.label2.Top = 0.5F;
            this.label2.Width = 0.7874017F;
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
            this.label3.Left = 5.15625F;
            this.label3.Name = "label3";
            this.label3.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
            this.label3.Text = "Доставлено";
            this.label3.Top = 0.5F;
            this.label3.Width = 0.7874015F;
            // 
            // txtDateBeg
            // 
            this.txtDateBeg.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDateBeg.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateBeg.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDateBeg.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateBeg.Border.RightColor = System.Drawing.Color.Black;
            this.txtDateBeg.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateBeg.Border.TopColor = System.Drawing.Color.Black;
            this.txtDateBeg.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateBeg.DataField = "DateBeg";
            this.txtDateBeg.Height = 0.1968504F;
            this.txtDateBeg.Left = 1.8125F;
            this.txtDateBeg.Name = "txtDateBeg";
            this.txtDateBeg.OutputFormat = resources.GetString("txtDateBeg.OutputFormat");
            this.txtDateBeg.Style = "ddo-char-set: 1; font-weight: normal; font-size: 9pt; ";
            this.txtDateBeg.Text = "DateBeg";
            this.txtDateBeg.Top = 0.2604167F;
            this.txtDateBeg.Width = 1.377953F;
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
            this.label6.Height = 0.1968504F;
            this.label6.HyperLink = null;
            this.label6.Left = 1.458333F;
            this.label6.Name = "label6";
            this.label6.Style = "ddo-char-set: 204; font-weight: normal; font-size: 9pt; font-family: Tahoma; ";
            this.label6.Text = "Нач.";
            this.label6.Top = 0.2604167F;
            this.label6.Width = 0.3543307F;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDateEnd.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateEnd.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDateEnd.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateEnd.Border.RightColor = System.Drawing.Color.Black;
            this.txtDateEnd.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateEnd.Border.TopColor = System.Drawing.Color.Black;
            this.txtDateEnd.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateEnd.DataField = "DateEnd";
            this.txtDateEnd.Height = 0.1968504F;
            this.txtDateEnd.Left = 3.583333F;
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.OutputFormat = resources.GetString("txtDateEnd.OutputFormat");
            this.txtDateEnd.Style = "ddo-char-set: 1; font-weight: normal; font-size: 9pt; ";
            this.txtDateEnd.Text = "DateEnd";
            this.txtDateEnd.Top = 0.2604167F;
            this.txtDateEnd.Width = 1.377953F;
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
            this.label9.Height = 0.1968504F;
            this.label9.HyperLink = null;
            this.label9.Left = 3.229167F;
            this.label9.Name = "label9";
            this.label9.Style = "ddo-char-set: 204; font-weight: normal; font-size: 9pt; font-family: Tahoma; ";
            this.label9.Text = "Кон.";
            this.label9.Top = 0.2604167F;
            this.label9.Width = 0.3543308F;
            // 
            // txtDateConfirm
            // 
            this.txtDateConfirm.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDateConfirm.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateConfirm.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDateConfirm.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateConfirm.Border.RightColor = System.Drawing.Color.Black;
            this.txtDateConfirm.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateConfirm.Border.TopColor = System.Drawing.Color.Black;
            this.txtDateConfirm.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDateConfirm.DataField = "DateConfirm";
            this.txtDateConfirm.Height = 0.1968504F;
            this.txtDateConfirm.Left = 6.020833F;
            this.txtDateConfirm.Name = "txtDateConfirm";
            this.txtDateConfirm.OutputFormat = resources.GetString("txtDateConfirm.OutputFormat");
            this.txtDateConfirm.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9pt; ";
            this.txtDateConfirm.Text = "DateConfirm";
            this.txtDateConfirm.Top = 0.2604167F;
            this.txtDateConfirm.Width = 1.417323F;
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
            this.label10.Height = 0.1968504F;
            this.label10.HyperLink = null;
            this.label10.Left = 5.552083F;
            this.label10.Name = "label10";
            this.label10.Style = "ddo-char-set: 204; font-weight: normal; font-size: 9pt; font-family: Tahoma; ";
            this.label10.Text = "Подтв.";
            this.label10.Top = 0.2604167F;
            this.label10.Width = 0.472441F;
            // 
            // groupTripIDFooter
            // 
            this.groupTripIDFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.line4,
            this.line3});
            this.groupTripIDFooter.Height = 0.1875F;
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
            this.line4.LineWeight = 1F;
            this.line4.Name = "line4";
            this.line4.Top = 0.01968504F;
            this.line4.Width = 7.401575F;
            this.line4.X1 = 0.03937008F;
            this.line4.X2 = 7.440945F;
            this.line4.Y1 = 0.01968504F;
            this.line4.Y2 = 0.01968504F;
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
            this.line3.Top = 0.03937008F;
            this.line3.Width = 7.401575F;
            this.line3.X1 = 0.03937008F;
            this.line3.X2 = 7.440945F;
            this.line3.Y1 = 0.03937008F;
            this.line3.Y2 = 0.03937008F;
            // 
            // TripBalance
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
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupTripIDFooter);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
                        "color: Black; font-family: \"Tahoma\"; ddo-char-set: 204; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 12pt; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            this.FetchData += new DataDynamics.ActiveReports.ActiveReport3.FetchEventHandler(this.TripBalance_FetchData);
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntReturned)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPackingName1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntTripBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntActed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntDelivered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQntShipped)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTripAlias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateBeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateConfirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private DataDynamics.ActiveReports.GroupHeader groupTripID;
		private DataDynamics.ActiveReports.GroupFooter groupTripIDFooter;
		private DataDynamics.ActiveReports.ReportInfo reportInfo1;
		private DataDynamics.ActiveReports.TextBox txtPackingName1;
		private DataDynamics.ActiveReports.TextBox txtQntTripBalance;
		private DataDynamics.ActiveReports.TextBox txtQntReturned;
		private DataDynamics.ActiveReports.ReportInfo reportInfo2;
		private DataDynamics.ActiveReports.Line line4;
		private DataDynamics.ActiveReports.Line line1;
		private DataDynamics.ActiveReports.TextBox txtInBox;
		private DataDynamics.ActiveReports.TextBox txtTripAlias;
		private DataDynamics.ActiveReports.TextBox textBox10;
		private DataDynamics.ActiveReports.Label label5;
		private DataDynamics.ActiveReports.Label label4;
		private DataDynamics.ActiveReports.Label label8;
		private DataDynamics.ActiveReports.Line line2;
		private DataDynamics.ActiveReports.Line line5;
		private DataDynamics.ActiveReports.Label label15;
		private DataDynamics.ActiveReports.Label label7;
		private DataDynamics.ActiveReports.Label label1;
		private DataDynamics.ActiveReports.Label label2;
		private DataDynamics.ActiveReports.Label label3;
		private DataDynamics.ActiveReports.TextBox txtDateBeg;
		private DataDynamics.ActiveReports.Label label6;
		private DataDynamics.ActiveReports.TextBox txtDateEnd;
		private DataDynamics.ActiveReports.Label label9;
		private DataDynamics.ActiveReports.TextBox txtDateConfirm;
		private DataDynamics.ActiveReports.Label label10;
		private DataDynamics.ActiveReports.TextBox txtQntActed;
		private DataDynamics.ActiveReports.TextBox txtQntDelivered;
		private DataDynamics.ActiveReports.TextBox txtQntShipped;
		private DataDynamics.ActiveReports.Line line3;
	}
}
