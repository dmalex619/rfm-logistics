namespace Logistics
{
	/// <summary>
	/// Summary description for repPackingsSimple.
	/// </summary>
	partial class repPackingsSimple 
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repPackingsSimple));
			this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
			this.reportInfo1 = new DataDynamics.ActiveReports.ReportInfo();
			this.textBox2 = new DataDynamics.ActiveReports.TextBox();
			this.detail = new DataDynamics.ActiveReports.Detail();
			this.txtInBox = new DataDynamics.ActiveReports.TextBox();
			this.line1 = new DataDynamics.ActiveReports.Line();
			this.txtPackingName1 = new DataDynamics.ActiveReports.TextBox();
			this.textBox1 = new DataDynamics.ActiveReports.TextBox();
			this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
			this.reportInfo2 = new DataDynamics.ActiveReports.ReportInfo();
			this.groupInputID = new DataDynamics.ActiveReports.GroupHeader();
			this.label4 = new DataDynamics.ActiveReports.Label();
			this.line5 = new DataDynamics.ActiveReports.Line();
			this.label8 = new DataDynamics.ActiveReports.Label();
			this.label15 = new DataDynamics.ActiveReports.Label();
			this.line2 = new DataDynamics.ActiveReports.Line();
			this.groupInputIDFooter = new DataDynamics.ActiveReports.GroupFooter();
			this.line3 = new DataDynamics.ActiveReports.Line();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPackingName1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// pageHeader
			// 
			this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo1,
            this.textBox2});
			this.pageHeader.Height = 0.28125F;
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
			this.reportInfo1.SummaryGroup = "groupInputID";
			this.reportInfo1.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
			this.reportInfo1.Top = 0F;
			this.reportInfo1.Width = 1.181103F;
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
			this.textBox2.Height = 0.1968504F;
			this.textBox2.Left = 0.1181102F;
			this.textBox2.Name = "textBox2";
			this.textBox2.Style = "font-weight: bold; font-size: 9.75pt; ";
			this.textBox2.Text = "Список товаров и упаковок";
			this.textBox2.Top = 0.03937008F;
			this.textBox2.Width = 4.291338F;
			// 
			// detail
			// 
			this.detail.ColumnSpacing = 0F;
			this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.txtInBox,
            this.line1,
            this.txtPackingName1,
            this.textBox1});
			this.detail.Height = 0.3020833F;
			this.detail.KeepTogether = true;
			this.detail.Name = "detail";
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
			this.txtInBox.Height = 0.1968504F;
			this.txtInBox.Left = 5.236221F;
			this.txtInBox.Name = "txtInBox";
			this.txtInBox.OutputFormat = resources.GetString("txtInBox.OutputFormat");
			this.txtInBox.Style = "ddo-char-set: 1; text-align: right; font-size: 10pt; ";
			this.txtInBox.Text = "txtInBox";
			this.txtInBox.Top = 0.03937008F;
			this.txtInBox.Width = 0.7086614F;
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
			this.line1.Top = 0.2755906F;
			this.line1.Width = 7.401575F;
			this.line1.X1 = 0.03937008F;
			this.line1.X2 = 7.440945F;
			this.line1.Y1 = 0.2755906F;
			this.line1.Y2 = 0.2755906F;
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
			this.txtPackingName1.Height = 0.1968504F;
			this.txtPackingName1.Left = 0.03937008F;
			this.txtPackingName1.Name = "txtPackingName1";
			this.txtPackingName1.Style = "";
			this.txtPackingName1.Text = "txtGoodAlias";
			this.txtPackingName1.Top = 0.03937008F;
			this.txtPackingName1.Width = 5.19685F;
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
			this.textBox1.DataField = "GoodBarCode";
			this.textBox1.Height = 0.1968504F;
			this.textBox1.Left = 6.023623F;
			this.textBox1.Name = "textBox1";
			this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
			this.textBox1.Style = "text-align: left; ";
			this.textBox1.Text = "txtGoodBarCode";
			this.textBox1.Top = 0.03937008F;
			this.textBox1.Width = 1.181103F;
			// 
			// pageFooter
			// 
			this.pageFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.reportInfo2});
			this.pageFooter.Height = 0.1456693F;
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
			this.reportInfo2.Left = 5.787402F;
			this.reportInfo2.Name = "reportInfo2";
			this.reportInfo2.Style = "ddo-char-set: 1; text-align: right; font-size: 6pt; ";
			this.reportInfo2.Top = 0F;
			this.reportInfo2.Width = 1.65625F;
			// 
			// groupInputID
			// 
			this.groupInputID.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label4,
            this.line5,
            this.label8,
            this.label15,
            this.line2});
			this.groupInputID.DataField = "InputID";
			this.groupInputID.Height = 0.2604167F;
			this.groupInputID.Name = "groupInputID";
			this.groupInputID.NewPage = DataDynamics.ActiveReports.NewPage.BeforeAfter;
			this.groupInputID.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail;
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
			this.label4.Left = 0.1181102F;
			this.label4.Name = "label4";
			this.label4.Style = "ddo-char-set: 1; font-size: 8pt; ";
			this.label4.Text = "Товар";
			this.label4.Top = 0.07874016F;
			this.label4.Width = 2.874016F;
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
			this.line5.Top = 0.03937008F;
			this.line5.Width = 7.401575F;
			this.line5.X1 = 0.03937008F;
			this.line5.X2 = 7.440945F;
			this.line5.Y1 = 0.03937008F;
			this.line5.Y2 = 0.03937008F;
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
			this.label8.Left = 6.023623F;
			this.label8.Name = "label8";
			this.label8.Style = "ddo-char-set: 1; font-size: 8pt; ";
			this.label8.Text = "Штрих-код товара";
			this.label8.Top = 0.07874016F;
			this.label8.Width = 0.984252F;
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
			this.label15.Left = 5.511811F;
			this.label15.Name = "label15";
			this.label15.Style = "ddo-char-set: 1; text-align: right; font-size: 8pt; ";
			this.label15.Text = "В кор.";
			this.label15.Top = 0.07874016F;
			this.label15.Width = 0.4330709F;
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
			this.line2.Top = 0.2362205F;
			this.line2.Width = 7.401575F;
			this.line2.X1 = 0.03937008F;
			this.line2.X2 = 7.440945F;
			this.line2.Y1 = 0.2362205F;
			this.line2.Y2 = 0.2362205F;
			// 
			// groupInputIDFooter
			// 
			this.groupInputIDFooter.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.line3});
			this.groupInputIDFooter.Height = 0.03125F;
			this.groupInputIDFooter.KeepTogether = true;
			this.groupInputIDFooter.Name = "groupInputIDFooter";
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
			this.line3.Top = 0.01968504F;
			this.line3.Width = 7.401575F;
			this.line3.X1 = 0.03937008F;
			this.line3.X2 = 7.440945F;
			this.line3.Y1 = 0.01968504F;
			this.line3.Y2 = 0.01968504F;
			// 
			// repPackingsSimple
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
			this.Script = resources.GetString("$this.Script");
			this.Sections.Add(this.pageHeader);
			this.Sections.Add(this.groupInputID);
			this.Sections.Add(this.detail);
			this.Sections.Add(this.groupInputIDFooter);
			this.Sections.Add(this.pageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " +
						"color: Black; font-family: \"Tahoma\"; ddo-char-set: 204; ", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-weight: bold; ddo-char-set: 204; font-size: 12pt; ", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.reportInfo1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtInBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPackingName1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.reportInfo2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.label15)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private DataDynamics.ActiveReports.GroupHeader groupInputID;
		private DataDynamics.ActiveReports.GroupFooter groupInputIDFooter;
		private DataDynamics.ActiveReports.ReportInfo reportInfo1;
		private DataDynamics.ActiveReports.ReportInfo reportInfo2;
		private DataDynamics.ActiveReports.Line line3;
		private DataDynamics.ActiveReports.Line line1;
		private DataDynamics.ActiveReports.TextBox txtPackingName1;
		private DataDynamics.ActiveReports.Label label4;
		private DataDynamics.ActiveReports.Line line5;
		private DataDynamics.ActiveReports.Label label8;
		private DataDynamics.ActiveReports.Label label15;
		private DataDynamics.ActiveReports.TextBox textBox2;
		private DataDynamics.ActiveReports.TextBox txtInBox;
		private DataDynamics.ActiveReports.Line line2;
		private DataDynamics.ActiveReports.TextBox textBox1;
	}
}
