namespace Logistics 
{
	/// <summary>
	/// Summary description for NewActiveReport1.
	/// </summary>
	partial class repUsersBadges
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(repUsersBadges));
			this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
			this.detail = new DataDynamics.ActiveReports.Detail();
			this.shape1 = new DataDynamics.ActiveReports.Shape();
			this.barcode1 = new DataDynamics.ActiveReports.Barcode();
			this.txtName = new DataDynamics.ActiveReports.TextBox();
			this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
			this.picture1 = new DataDynamics.ActiveReports.Picture();
			this.textBox1 = new DataDynamics.ActiveReports.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// pageHeader
			// 
			this.pageHeader.Height = 0.25F;
			this.pageHeader.Name = "pageHeader";
			// 
			// detail
			// 
			this.detail.ColumnCount = 2;
			this.detail.ColumnSpacing = 0F;
			this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.shape1,
            this.barcode1,
            this.txtName,
            this.picture1,
            this.textBox1});
			this.detail.Height = 1.802083F;
			this.detail.KeepTogether = true;
			this.detail.Name = "detail";
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
			this.shape1.Height = 1.625F;
			this.shape1.Left = 0.0625F;
			this.shape1.LineStyle = DataDynamics.ActiveReports.LineStyle.Dot;
			this.shape1.Name = "shape1";
			this.shape1.RoundingRadius = 9.999999F;
			this.shape1.Top = 0.0625F;
			this.shape1.Width = 3.5625F;
			// 
			// barcode1
			// 
			this.barcode1.Border.BottomColor = System.Drawing.Color.Black;
			this.barcode1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.barcode1.Border.LeftColor = System.Drawing.Color.Black;
			this.barcode1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.barcode1.Border.RightColor = System.Drawing.Color.Black;
			this.barcode1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.barcode1.Border.TopColor = System.Drawing.Color.Black;
			this.barcode1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.barcode1.CaptionPosition = DataDynamics.ActiveReports.BarCodeCaptionPosition.Below;
			this.barcode1.DataField = "BarCode";
			this.barcode1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.barcode1.Height = 0.511811F;
			this.barcode1.Left = 1.259843F;
			this.barcode1.Name = "barcode1";
			this.barcode1.Style = DataDynamics.ActiveReports.BarCodeStyle.EAN128FNC1;
			this.barcode1.Text = "barcode1";
			this.barcode1.Top = 0.1968504F;
			this.barcode1.Width = 2.283465F;
			// 
			// txtName
			// 
			this.txtName.Border.BottomColor = System.Drawing.Color.Black;
			this.txtName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtName.Border.LeftColor = System.Drawing.Color.Black;
			this.txtName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtName.Border.RightColor = System.Drawing.Color.Black;
			this.txtName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtName.Border.TopColor = System.Drawing.Color.Black;
			this.txtName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.txtName.DataField = "Name";
			this.txtName.Height = 0.3149606F;
			this.txtName.Left = 1.338583F;
			this.txtName.Name = "txtName";
			this.txtName.Style = "ddo-char-set: 204; text-align: center; font-weight: bold; font-size: 14.25pt; fon" +
				"t-family: Tahoma; ";
			this.txtName.Text = "Name";
			this.txtName.Top = 0.984252F;
			this.txtName.Width = 2.165354F;
			// 
			// pageFooter
			// 
			this.pageFooter.Height = 0.25F;
			this.pageFooter.Name = "pageFooter";
			// 
			// picture1
			// 
			this.picture1.Border.BottomColor = System.Drawing.Color.Black;
			this.picture1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.picture1.Border.LeftColor = System.Drawing.Color.Black;
			this.picture1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.picture1.Border.RightColor = System.Drawing.Color.Black;
			this.picture1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.picture1.Border.TopColor = System.Drawing.Color.Black;
			this.picture1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.picture1.DataField = "Photo";
			this.picture1.Height = 1.417323F;
			this.picture1.Image = null;
			this.picture1.ImageData = null;
			this.picture1.Left = 0.1574803F;
			this.picture1.LineWeight = 0F;
			this.picture1.Name = "picture1";
			this.picture1.SizeMode = DataDynamics.ActiveReports.SizeModes.Zoom;
			this.picture1.Title = "Photo";
			this.picture1.Top = 0.1574803F;
			this.picture1.Width = 1.102362F;
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
			this.textBox1.DataField = "ID";
			this.textBox1.Height = 0.1968504F;
			this.textBox1.Left = 2.440945F;
			this.textBox1.Name = "textBox1";
			this.textBox1.Style = "ddo-char-set: 204; text-align: right; font-weight: normal; font-size: 8.25pt; fon" +
				"t-family: Tahoma; ";
			this.textBox1.Text = "ID";
			this.textBox1.Top = 1.456693F;
			this.textBox1.Width = 1.102362F;
			// 
			// repUsersBadges
			// 
			this.PageSettings.Margins.Bottom = 0.3937008F;
			this.PageSettings.Margins.Left = 0.3937008F;
			this.PageSettings.Margins.Right = 0.3937008F;
			this.PageSettings.Margins.Top = 0.3937008F;
			this.PageSettings.PaperHeight = 11.69F;
			this.PageSettings.PaperWidth = 8.27F;
			this.PrintWidth = 7.283465F;
			this.Sections.Add(this.pageHeader);
			this.Sections.Add(this.detail);
			this.Sections.Add(this.pageFooter);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private DataDynamics.ActiveReports.Shape shape1;
		private DataDynamics.ActiveReports.Barcode barcode1;
		private DataDynamics.ActiveReports.TextBox txtName;
		private DataDynamics.ActiveReports.Picture picture1;
		private DataDynamics.ActiveReports.TextBox textBox1;
	}
}
