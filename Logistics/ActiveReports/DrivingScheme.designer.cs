namespace Logistics 
{	partial class DrivingScheme
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

		// init report components
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DrivingScheme));
            this.PageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.GroupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.lblPageHeader01 = new DataDynamics.ActiveReports.Label();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.Detail = new DataDynamics.ActiveReports.Detail();
            this.picDrivingScheme = new DataDynamics.ActiveReports.Picture();
            this.GroupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.PageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrivingScheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // PageHeader
            // 
            this.PageHeader.Height = 0F;
            this.PageHeader.Name = "PageHeader";
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblPageHeader01,
            this.textBox2});
            this.GroupHeader1.DataField = "PartnerID";
            this.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.FirstDetail;
            this.GroupHeader1.Height = 0.2559055F;
            this.GroupHeader1.KeepTogether = true;
            this.GroupHeader1.Name = "GroupHeader1";
            this.GroupHeader1.Tag = "PartnerID";
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
            this.lblPageHeader01.Height = 0.2362205F;
            this.lblPageHeader01.HyperLink = null;
            this.lblPageHeader01.Left = 9.251969F;
            this.lblPageHeader01.MultiLine = false;
            this.lblPageHeader01.Name = "lblPageHeader01";
            this.lblPageHeader01.Style = "color: Black; ddo-char-set: 204; text-align: right; font-weight: bold; font-size:" +
    " 14.25pt; font-family: Tahoma; white-space: nowrap; ";
            this.lblPageHeader01.Text = "Ñץולא ןנמוחהא";
            this.lblPageHeader01.Top = 0F;
            this.lblPageHeader01.Width = 1.771654F;
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
            this.textBox2.DataField = "Name";
            this.textBox2.Height = 0.2362205F;
            this.textBox2.HyperLink = null;
            this.textBox2.Left = 0.3937008F;
            this.textBox2.MultiLine = false;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "color: Black; ddo-char-set: 204; text-align: left; font-weight: bold; font-size: " +
    "14.25pt; font-family: Tahoma; ";
            this.textBox2.Text = "PartnerName";
            this.textBox2.Top = 0F;
            this.textBox2.Width = 7.519685F;
            // 
            // Detail
            // 
            this.Detail.CanShrink = true;
            this.Detail.ColumnSpacing = 0F;
            this.Detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.picDrivingScheme});
            this.Detail.Height = 7.086614F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // picDrivingScheme
            // 
            this.picDrivingScheme.Border.BottomColor = System.Drawing.Color.Black;
            this.picDrivingScheme.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.picDrivingScheme.Border.LeftColor = System.Drawing.Color.Black;
            this.picDrivingScheme.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.picDrivingScheme.Border.RightColor = System.Drawing.Color.Black;
            this.picDrivingScheme.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.picDrivingScheme.Border.TopColor = System.Drawing.Color.Black;
            this.picDrivingScheme.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.picDrivingScheme.DataField = "DrivingScheme";
            this.picDrivingScheme.Height = 7.007874F;
            this.picDrivingScheme.Image = null;
            this.picDrivingScheme.ImageData = null;
            this.picDrivingScheme.Left = 0.3937008F;
            this.picDrivingScheme.LineWeight = 0F;
            this.picDrivingScheme.Name = "picDrivingScheme";
            this.picDrivingScheme.Top = 0.03937008F;
            this.picDrivingScheme.Width = 10.62992F;
            // 
            // GroupFooter1
            // 
            this.GroupFooter1.Height = 0.02083333F;
            this.GroupFooter1.Name = "GroupFooter1";
            // 
            // PageFooter
            // 
            this.PageFooter.Height = 0F;
            this.PageFooter.Name = "PageFooter";
            // 
            // DrivingScheme
            // 
            this.PageSettings.Margins.Bottom = 0.1968504F;
            this.PageSettings.Margins.Left = 0.1968504F;
            this.PageSettings.Margins.Right = 0F;
            this.PageSettings.Margins.Top = 0.3937008F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape;
            this.PageSettings.PaperHeight = 11.69F;
            this.PageSettings.PaperWidth = 8.27F;
            this.PrintWidth = 11.40174F;
            this.Sections.Add(this.PageHeader);
            this.Sections.Add(this.GroupHeader1);
            this.Sections.Add(this.Detail);
            this.Sections.Add(this.GroupFooter1);
            this.Sections.Add(this.PageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.lblPageHeader01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrivingScheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
	private DataDynamics.ActiveReports.Label lblPageHeader01;
    private DataDynamics.ActiveReports.TextBox textBox2;
    private DataDynamics.ActiveReports.Picture picDrivingScheme;
	}
}