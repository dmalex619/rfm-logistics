namespace Logistics 
{	partial class GoodsGroupsList
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
	private DataDynamics.ActiveReports.Label lblPageHeader08;
	private DataDynamics.ActiveReports.Line linPageHeader01;
	private DataDynamics.ActiveReports.TextBox txtPageHeader02;
	private DataDynamics.ActiveReports.TextBox txtDetail10;
	private DataDynamics.ActiveReports.Line linGroupFooter101;

		// init report components
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GoodsGroupsList));
            this.PageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.reportInfo1 = new DataDynamics.ActiveReports.ReportInfo();
            this.lblPageHeader07 = new DataDynamics.ActiveReports.Label();
            this.lblPageHeader08 = new DataDynamics.ActiveReports.Label();
            this.linPageHeader01 = new DataDynamics.ActiveReports.Line();
            this.txtPageHeader02 = new DataDynamics.ActiveReports.TextBox();
            this.line2 = new DataDynamics.ActiveReports.Line();
            this.GroupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.lblPageHeader01 = new DataDynamics.ActiveReports.Label();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.Detail = new DataDynamics.ActiveReports.Detail();
            this.txtDetail10 = new DataDynamics.ActiveReports.TextBox();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.GroupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.linGroupFooter101 = new DataDynamics.ActiveReports.Line();
            this.linDetail10 = new DataDynamics.ActiveReports.Line();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.PageFooter = new DataDynamics.ActiveReports.PageFooter();
            this.reportInfo2 = new DataDynamics.ActiveReports.ReportInfo();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader07)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader08)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageHeader02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo1});
            this.PageHeader.Height = 0.1458333F;
            this.PageHeader.Name = "PageHeader";
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
            this.reportInfo1.Height = 0.1574803F;
            this.reportInfo1.Left = 6.417323F;
            this.reportInfo1.Name = "reportInfo1";
            this.reportInfo1.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; font-family: Tahoma; ";
            this.reportInfo1.SummaryGroup = "GroupHeader1";
            this.reportInfo1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.reportInfo1.Top = 0F;
            this.reportInfo1.Width = 1.181102F;
            // 
            // lblPageHeader07
            // 
            this.lblPageHeader07.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPageHeader07.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader07.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPageHeader07.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader07.Border.RightColor = System.Drawing.Color.Black;
            this.lblPageHeader07.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader07.Border.TopColor = System.Drawing.Color.Black;
            this.lblPageHeader07.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader07.Height = 0.1574803F;
            this.lblPageHeader07.HyperLink = null;
            this.lblPageHeader07.Left = 5.748032F;
            this.lblPageHeader07.MultiLine = false;
            this.lblPageHeader07.Name = "lblPageHeader07";
            this.lblPageHeader07.Style = "color: Black; ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; white-space: " +
                "nowrap; ";
            this.lblPageHeader07.Text = "Страна";
            this.lblPageHeader07.Top = 0.3937008F;
            this.lblPageHeader07.Width = 1.811024F;
            // 
            // lblPageHeader08
            // 
            this.lblPageHeader08.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPageHeader08.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader08.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPageHeader08.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader08.Border.RightColor = System.Drawing.Color.Black;
            this.lblPageHeader08.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader08.Border.TopColor = System.Drawing.Color.Black;
            this.lblPageHeader08.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader08.Height = 0.1574803F;
            this.lblPageHeader08.HyperLink = null;
            this.lblPageHeader08.Left = 0.07874016F;
            this.lblPageHeader08.MultiLine = false;
            this.lblPageHeader08.Name = "lblPageHeader08";
            this.lblPageHeader08.Style = "color: Black; ddo-char-set: 1; font-size: 8pt; font-family: Tahoma; white-space: " +
                "nowrap; ";
            this.lblPageHeader08.Text = "Товарная группа";
            this.lblPageHeader08.Top = 0.3937008F;
            this.lblPageHeader08.Width = 0.984252F;
            // 
            // linPageHeader01
            // 
            this.linPageHeader01.Border.BottomColor = System.Drawing.Color.Black;
            this.linPageHeader01.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linPageHeader01.Border.LeftColor = System.Drawing.Color.Black;
            this.linPageHeader01.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linPageHeader01.Border.RightColor = System.Drawing.Color.Black;
            this.linPageHeader01.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linPageHeader01.Border.TopColor = System.Drawing.Color.Black;
            this.linPageHeader01.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linPageHeader01.Height = 0F;
            this.linPageHeader01.Left = 0.03937008F;
            this.linPageHeader01.LineWeight = 2F;
            this.linPageHeader01.Name = "linPageHeader01";
            this.linPageHeader01.Top = 0.3937008F;
            this.linPageHeader01.Width = 7.716536F;
            this.linPageHeader01.X1 = 7.755906F;
            this.linPageHeader01.X2 = 0.03937008F;
            this.linPageHeader01.Y1 = 0.3937008F;
            this.linPageHeader01.Y2 = 0.3937008F;
            // 
            // txtPageHeader02
            // 
            this.txtPageHeader02.Border.BottomColor = System.Drawing.Color.Black;
            this.txtPageHeader02.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPageHeader02.Border.LeftColor = System.Drawing.Color.Black;
            this.txtPageHeader02.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPageHeader02.Border.RightColor = System.Drawing.Color.Black;
            this.txtPageHeader02.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPageHeader02.Border.TopColor = System.Drawing.Color.Black;
            this.txtPageHeader02.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtPageHeader02.DataField = "BillNumber";
            this.txtPageHeader02.Height = 0.1574803F;
            this.txtPageHeader02.HyperLink = null;
            this.txtPageHeader02.Left = 1.653543F;
            this.txtPageHeader02.MultiLine = false;
            this.txtPageHeader02.Name = "txtPageHeader02";
            this.txtPageHeader02.OutputFormat = resources.GetString("txtPageHeader02.OutputFormat");
            this.txtPageHeader02.Style = "color: Black; ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10" +
                "pt; font-family: Tahoma; ";
            this.txtPageHeader02.Text = "BillNumber";
            this.txtPageHeader02.Top = 0.03937008F;
            this.txtPageHeader02.Width = 2.086614F;
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
            this.line2.LineWeight = 2F;
            this.line2.Name = "line2";
            this.line2.Top = 0.5511811F;
            this.line2.Width = 7.716536F;
            this.line2.X1 = 7.755906F;
            this.line2.X2 = 0.03937008F;
            this.line2.Y1 = 0.5511811F;
            this.line2.Y2 = 0.5511811F;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtPageHeader02,
            this.lblPageHeader01,
            this.lblPageHeader07,
            this.lblPageHeader08,
            this.linPageHeader01,
            this.line2,
            this.textBox2});
            this.GroupHeader1.DataField = "OutputDocumentID";
            this.GroupHeader1.Height = 0.5729167F;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Tag = "OutputDocumentID";
            // 
            // lblPageHeader01
            // 
            this.lblPageHeader01.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPageHeader01.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader01.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPageHeader01.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader01.Border.RightColor = System.Drawing.Color.Black;
            this.lblPageHeader01.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader01.Border.TopColor = System.Drawing.Color.Black;
            this.lblPageHeader01.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPageHeader01.Height = 0.1574803F;
            this.lblPageHeader01.HyperLink = null;
            this.lblPageHeader01.Left = 0.07874016F;
            this.lblPageHeader01.MultiLine = false;
            this.lblPageHeader01.Name = "lblPageHeader01";
            this.lblPageHeader01.Style = "color: Black; ddo-char-set: 1; font-weight: bold; font-size: 10pt; font-family: T" +
                "ahoma; white-space: nowrap; ";
            this.lblPageHeader01.Text = "Расходный документ";
            this.lblPageHeader01.Top = 0.03937008F;
            this.lblPageHeader01.Width = 1.574803F;
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
            this.textBox2.DataField = "PartnerName";
            this.textBox2.Height = 0.1574803F;
            this.textBox2.HyperLink = null;
            this.textBox2.Left = 0.07874016F;
            this.textBox2.MultiLine = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "color: Black; ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 10" +
                "pt; font-family: Tahoma; ";
            this.textBox2.Text = "PartnerName";
            this.textBox2.Top = 0.1968504F;
            this.textBox2.Width = 7.519685F;
            // 
            // Detail
            // 
            this.Detail.CanShrink = true;
            this.Detail.ColumnSpacing = 0F;
            this.Detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtDetail10,
            this.textBox1});
            this.Detail.Height = 0.2083333F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // txtDetail10
            // 
            this.txtDetail10.Border.BottomColor = System.Drawing.Color.Black;
            this.txtDetail10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail10.Border.LeftColor = System.Drawing.Color.Black;
            this.txtDetail10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail10.Border.RightColor = System.Drawing.Color.Black;
            this.txtDetail10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail10.Border.TopColor = System.Drawing.Color.Black;
            this.txtDetail10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.txtDetail10.CanShrink = true;
            this.txtDetail10.DataField = "CountryName";
            this.txtDetail10.Height = 0.1574803F;
            this.txtDetail10.HyperLink = null;
            this.txtDetail10.Left = 5.748032F;
            this.txtDetail10.MultiLine = false;
            this.txtDetail10.Name = "txtDetail10";
            this.txtDetail10.Style = "color: Black; ddo-char-set: 204; text-align: left; font-size: 9pt; font-family: T" +
                "ahoma; ";
            this.txtDetail10.Text = "CountryName";
            this.txtDetail10.Top = 0F;
            this.txtDetail10.Width = 1.850394F;
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
            this.textBox1.CanShrink = true;
            this.textBox1.DataField = "GoodGroupName";
            this.textBox1.Height = 0.1574803F;
            this.textBox1.HyperLink = null;
            this.textBox1.Left = 0.07874016F;
            this.textBox1.MultiLine = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "color: Black; ddo-char-set: 204; text-align: left; font-size: 9pt; font-family: T" +
                "ahoma; ";
            this.textBox1.Text = "GoodGroupName";
            this.textBox1.Top = 0F;
            this.textBox1.Width = 5.629921F;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.linGroupFooter101,
            this.linDetail10,
            this.line1});
            this.GroupFooter1.Height = 0.08333334F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // linGroupFooter101
            // 
            this.linGroupFooter101.Border.BottomColor = System.Drawing.Color.Black;
            this.linGroupFooter101.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linGroupFooter101.Border.LeftColor = System.Drawing.Color.Black;
            this.linGroupFooter101.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linGroupFooter101.Border.RightColor = System.Drawing.Color.Black;
            this.linGroupFooter101.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linGroupFooter101.Border.TopColor = System.Drawing.Color.Black;
            this.linGroupFooter101.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linGroupFooter101.Height = 0F;
            this.linGroupFooter101.Left = 0.0625F;
            this.linGroupFooter101.LineWeight = 1F;
            this.linGroupFooter101.Name = "linGroupFooter101";
            this.linGroupFooter101.Top = 0.0102835F;
            this.linGroupFooter101.Width = 0F;
            this.linGroupFooter101.X1 = 0.0625F;
            this.linGroupFooter101.X2 = 0.0625F;
            this.linGroupFooter101.Y1 = 0.0102835F;
            this.linGroupFooter101.Y2 = 0.0102835F;
            // 
            // linDetail10
            // 
            this.linDetail10.Border.BottomColor = System.Drawing.Color.Black;
            this.linDetail10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail10.Border.LeftColor = System.Drawing.Color.Black;
            this.linDetail10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail10.Border.RightColor = System.Drawing.Color.Black;
            this.linDetail10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail10.Border.TopColor = System.Drawing.Color.Black;
            this.linDetail10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.linDetail10.Height = 0F;
            this.linDetail10.Left = 0.03937008F;
            this.linDetail10.LineWeight = 1F;
            this.linDetail10.Name = "linDetail10";
            this.linDetail10.Top = 0F;
            this.linDetail10.Width = 7.716536F;
            this.linDetail10.X1 = 7.755906F;
            this.linDetail10.X2 = 0.03937008F;
            this.linDetail10.Y1 = 0F;
            this.linDetail10.Y2 = 0F;
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
            this.line1.LineWeight = 2F;
            this.line1.Name = "line1";
            this.line1.Top = 0.03937008F;
            this.line1.Width = 7.716536F;
            this.line1.X1 = 7.755906F;
            this.line1.X2 = 0.03937008F;
            this.line1.Y1 = 0.03937008F;
            this.line1.Y2 = 0.03937008F;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo2});
            this.PageFooter.Height = 0.1574803F;
            this.PageFooter.Name = "PageFooter";
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
            this.reportInfo2.Height = 0.1181102F;
            this.reportInfo2.Left = 0.07874016F;
            this.reportInfo2.Name = "reportInfo2";
            this.reportInfo2.Style = "font-size: 6pt; font-family: Tahoma; ";
            this.reportInfo2.Top = 0.03937008F;
            this.reportInfo2.Width = 1.259843F;
            // 
            // GoodsGroupsList
            // 
            this.PageSettings.Margins.Bottom = 0.1968504F;
            this.PageSettings.Margins.Left = 0.1968504F;
            this.PageSettings.Margins.Right = 0F;
            this.PageSettings.Margins.Top = 0.3937008F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait;
            this.PageSettings.PaperHeight = 11.69F;
            this.PageSettings.PaperWidth = 8.27F;
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
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader07)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader08)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPageHeader02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDetail10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
	private DataDynamics.ActiveReports.ReportInfo reportInfo1;
	private DataDynamics.ActiveReports.ReportInfo reportInfo2;
	private DataDynamics.ActiveReports.TextBox textBox1;
	private DataDynamics.ActiveReports.Line linDetail10;
	private DataDynamics.ActiveReports.Line line2;
	private DataDynamics.ActiveReports.Label lblPageHeader07;
	private DataDynamics.ActiveReports.Label lblPageHeader01;
	private DataDynamics.ActiveReports.TextBox textBox2;
	private DataDynamics.ActiveReports.Line line1;
	}
}