namespace Logistics.ActiveReports
{
	/// <summary>
	/// Summary description for NewActiveReport1.
	/// </summary>
	partial class repTestReport
	{
		private DataDynamics.ActiveReports.PageHeader pageHeader_;
		private DataDynamics.ActiveReports.Detail detail;
		private DataDynamics.ActiveReports.PageFooter pageFooter_;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(repTestReport));
			this.pageHeader_ = new DataDynamics.ActiveReports.PageHeader();
			this.detail = new DataDynamics.ActiveReports.Detail();
			this.pageFooter_ = new DataDynamics.ActiveReports.PageFooter();
			this.reportHeader_ = new DataDynamics.ActiveReports.ReportHeader();
			this.reportFooter_ = new DataDynamics.ActiveReports.ReportFooter();
			this.lineInHeader = new DataDynamics.ActiveReports.Line();
			this.labelInHeader = new DataDynamics.ActiveReports.Label();
			this.textBoxInHeader = new DataDynamics.ActiveReports.TextBox();
			this.lineInPageHeader = new DataDynamics.ActiveReports.Line();
			this.labelInPageHeader = new DataDynamics.ActiveReports.Label();
			this.textBoxInPageHeader = new DataDynamics.ActiveReports.TextBox();
			this.lineInDetail = new DataDynamics.ActiveReports.Line();
			this.labelInDetail = new DataDynamics.ActiveReports.Label();
			this.textBoxInDetail_string = new DataDynamics.ActiveReports.TextBox();
			this.shapeInDetail = new DataDynamics.ActiveReports.Shape();
			this.lineInPageFooter = new DataDynamics.ActiveReports.Line();
			this.labelInPageFooter = new DataDynamics.ActiveReports.Label();
			this.textBoxInPageFooter = new DataDynamics.ActiveReports.TextBox();
			this.lineInFooter = new DataDynamics.ActiveReports.Line();
			this.labelInFooter = new DataDynamics.ActiveReports.Label();
			this.textBoxInFooter = new DataDynamics.ActiveReports.TextBox();
			this.groupHeader_ = new DataDynamics.ActiveReports.GroupHeader();
			this.groupFooter_ = new DataDynamics.ActiveReports.GroupFooter();
			this.lineInGroupHeader = new DataDynamics.ActiveReports.Line();
			this.labelInGroupHeader = new DataDynamics.ActiveReports.Label();
			this.textBoxInGroupHeader = new DataDynamics.ActiveReports.TextBox();
			this.lineInGroupFooter = new DataDynamics.ActiveReports.Line();
			this.labelInGroupFooter = new DataDynamics.ActiveReports.Label();
			this.textBoxInGroupFooter = new DataDynamics.ActiveReports.TextBox();
			this.textBoxInDetail_numeric = new DataDynamics.ActiveReports.TextBox();
			this.textBoxInGroupFooter_Sum = new DataDynamics.ActiveReports.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.labelInHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInPageHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInPageHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInDetail_string)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInPageFooter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInPageFooter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInFooter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInFooter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInGroupHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInGroupHeader)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInGroupFooter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInGroupFooter)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInDetail_numeric)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInGroupFooter_Sum)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// pageHeader_
			// 
			this.pageHeader_.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lineInPageHeader,
            this.labelInPageHeader,
            this.textBoxInPageHeader});
			this.pageHeader_.Height = 0.5905512F;
			this.pageHeader_.Name = "pageHeader_";
			// 
			// detail
			// 
			this.detail.ColumnSpacing = 0F;
			this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lineInDetail,
            this.labelInDetail,
            this.textBoxInDetail_string,
            this.shapeInDetail,
            this.textBoxInDetail_numeric});
			this.detail.Height = 1.574803F;
			this.detail.Name = "detail";
			// 
			// pageFooter_
			// 
			this.pageFooter_.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lineInPageFooter,
            this.labelInPageFooter,
            this.textBoxInPageFooter});
			this.pageFooter_.Height = 0.6299213F;
			this.pageFooter_.Name = "pageFooter_";
			// 
			// reportHeader_
			// 
			this.reportHeader_.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lineInHeader,
            this.labelInHeader,
            this.textBoxInHeader});
			this.reportHeader_.Height = 0.7874016F;
			this.reportHeader_.Name = "reportHeader_";
			// 
			// reportFooter_
			// 
			this.reportFooter_.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lineInFooter,
            this.labelInFooter,
            this.textBoxInFooter});
			this.reportFooter_.Height = 0.472441F;
			this.reportFooter_.Name = "reportFooter_";
			// 
			// lineInHeader
			// 
			this.lineInHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInHeader.Border.RightColor = System.Drawing.Color.Black;
			this.lineInHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInHeader.Border.TopColor = System.Drawing.Color.Black;
			this.lineInHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInHeader.Height = 0F;
			this.lineInHeader.Left = 0.3937008F;
			this.lineInHeader.LineWeight = 1F;
			this.lineInHeader.Name = "lineInHeader";
			this.lineInHeader.Top = 0.3937008F;
			this.lineInHeader.Width = 0.3937008F;
			this.lineInHeader.X1 = 0.3937008F;
			this.lineInHeader.X2 = 0.7874016F;
			this.lineInHeader.Y1 = 0.3937008F;
			this.lineInHeader.Y2 = 0.3937008F;
			// 
			// labelInHeader
			// 
			this.labelInHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInHeader.Border.RightColor = System.Drawing.Color.Black;
			this.labelInHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInHeader.Border.TopColor = System.Drawing.Color.Black;
			this.labelInHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInHeader.Height = 0.1968504F;
			this.labelInHeader.HyperLink = null;
			this.labelInHeader.Left = 1.181102F;
			this.labelInHeader.Name = "labelInHeader";
			this.labelInHeader.Style = "";
			this.labelInHeader.Text = "LabelInHeader";
			this.labelInHeader.Top = 0.1968504F;
			this.labelInHeader.Width = 1.968504F;
			// 
			// textBoxInHeader
			// 
			this.textBoxInHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInHeader.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInHeader.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInHeader.Height = 0.1574803F;
			this.textBoxInHeader.Left = 3.543307F;
			this.textBoxInHeader.Name = "textBoxInHeader";
			this.textBoxInHeader.Style = "";
			this.textBoxInHeader.Text = "textBoxInHeader";
			this.textBoxInHeader.Top = 0.1968504F;
			this.textBoxInHeader.Width = 1.771654F;
			// 
			// lineInPageHeader
			// 
			this.lineInPageHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInPageHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInPageHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageHeader.Border.RightColor = System.Drawing.Color.Black;
			this.lineInPageHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageHeader.Border.TopColor = System.Drawing.Color.Black;
			this.lineInPageHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageHeader.Height = 0F;
			this.lineInPageHeader.Left = 0.7874016F;
			this.lineInPageHeader.LineWeight = 4F;
			this.lineInPageHeader.Name = "lineInPageHeader";
			this.lineInPageHeader.Top = 0.3937008F;
			this.lineInPageHeader.Width = 0.3937008F;
			this.lineInPageHeader.X1 = 0.7874016F;
			this.lineInPageHeader.X2 = 1.181102F;
			this.lineInPageHeader.Y1 = 0.3937008F;
			this.lineInPageHeader.Y2 = 0.3937008F;
			// 
			// labelInPageHeader
			// 
			this.labelInPageHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInPageHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInPageHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageHeader.Border.RightColor = System.Drawing.Color.Black;
			this.labelInPageHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageHeader.Border.TopColor = System.Drawing.Color.Black;
			this.labelInPageHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageHeader.Height = 0.1968504F;
			this.labelInPageHeader.HyperLink = null;
			this.labelInPageHeader.Left = 1.574803F;
			this.labelInPageHeader.Name = "labelInPageHeader";
			this.labelInPageHeader.Style = "ddo-char-set: 204; font-weight: bold; font-size: 9.75pt; ";
			this.labelInPageHeader.Text = "LabelInPageHeader";
			this.labelInPageHeader.Top = 0.1968504F;
			this.labelInPageHeader.Width = 1.574803F;
			// 
			// textBoxInPageHeader
			// 
			this.textBoxInPageHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInPageHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInPageHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageHeader.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInPageHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageHeader.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInPageHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageHeader.Height = 0.1574803F;
			this.textBoxInPageHeader.Left = 3.937008F;
			this.textBoxInPageHeader.Name = "textBoxInPageHeader";
			this.textBoxInPageHeader.Style = "ddo-char-set: 204; font-size: 9.75pt; font-family: Courier New; ";
			this.textBoxInPageHeader.Text = "textBoxInPageHeader";
			this.textBoxInPageHeader.Top = 0.1968504F;
			this.textBoxInPageHeader.Width = 2.362205F;
			// 
			// lineInDetail
			// 
			this.lineInDetail.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInDetail.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInDetail.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInDetail.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInDetail.Border.RightColor = System.Drawing.Color.Black;
			this.lineInDetail.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInDetail.Border.TopColor = System.Drawing.Color.Black;
			this.lineInDetail.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInDetail.Height = 0F;
			this.lineInDetail.Left = 1.181102F;
			this.lineInDetail.LineWeight = 1F;
			this.lineInDetail.Name = "lineInDetail";
			this.lineInDetail.Top = 0.3937008F;
			this.lineInDetail.Width = 0.3937008F;
			this.lineInDetail.X1 = 1.181102F;
			this.lineInDetail.X2 = 1.574803F;
			this.lineInDetail.Y1 = 0.3937008F;
			this.lineInDetail.Y2 = 0.3937008F;
			// 
			// labelInDetail
			// 
			this.labelInDetail.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInDetail.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInDetail.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInDetail.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInDetail.Border.RightColor = System.Drawing.Color.Black;
			this.labelInDetail.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInDetail.Border.TopColor = System.Drawing.Color.Black;
			this.labelInDetail.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInDetail.Height = 0.1968504F;
			this.labelInDetail.HyperLink = null;
			this.labelInDetail.Left = 1.968504F;
			this.labelInDetail.Name = "labelInDetail";
			this.labelInDetail.Style = "";
			this.labelInDetail.Text = "LabelInDetail";
			this.labelInDetail.Top = 0.1968504F;
			this.labelInDetail.Width = 1.968504F;
			// 
			// textBoxInDetail_string
			// 
			this.textBoxInDetail_string.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInDetail_string.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_string.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInDetail_string.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_string.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInDetail_string.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_string.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInDetail_string.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_string.DataField = "TextField";
			this.textBoxInDetail_string.Height = 0.1574803F;
			this.textBoxInDetail_string.Left = 4.330709F;
			this.textBoxInDetail_string.Name = "textBoxInDetail_string";
			this.textBoxInDetail_string.Style = "";
			this.textBoxInDetail_string.Text = "textBoxInDetail_string";
			this.textBoxInDetail_string.Top = 0.1968504F;
			this.textBoxInDetail_string.Width = 1.771654F;
			// 
			// shapeInDetail
			// 
			this.shapeInDetail.Border.BottomColor = System.Drawing.Color.Black;
			this.shapeInDetail.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.shapeInDetail.Border.LeftColor = System.Drawing.Color.Black;
			this.shapeInDetail.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.shapeInDetail.Border.RightColor = System.Drawing.Color.Black;
			this.shapeInDetail.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.shapeInDetail.Border.TopColor = System.Drawing.Color.Black;
			this.shapeInDetail.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.shapeInDetail.Height = 0.3937008F;
			this.shapeInDetail.Left = 0.3937008F;
			this.shapeInDetail.Name = "shapeInDetail";
			this.shapeInDetail.RoundingRadius = 10F;
			this.shapeInDetail.Top = 0.7874016F;
			this.shapeInDetail.Width = 0.7874016F;
			// 
			// lineInPageFooter
			// 
			this.lineInPageFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInPageFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInPageFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageFooter.Border.RightColor = System.Drawing.Color.Black;
			this.lineInPageFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageFooter.Border.TopColor = System.Drawing.Color.Black;
			this.lineInPageFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInPageFooter.Height = 0F;
			this.lineInPageFooter.Left = 0.7874016F;
			this.lineInPageFooter.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash;
			this.lineInPageFooter.LineWeight = 1F;
			this.lineInPageFooter.Name = "lineInPageFooter";
			this.lineInPageFooter.Top = 0.3937008F;
			this.lineInPageFooter.Width = 0.3937008F;
			this.lineInPageFooter.X1 = 0.7874016F;
			this.lineInPageFooter.X2 = 1.181102F;
			this.lineInPageFooter.Y1 = 0.3937008F;
			this.lineInPageFooter.Y2 = 0.3937008F;
			// 
			// labelInPageFooter
			// 
			this.labelInPageFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInPageFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInPageFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageFooter.Border.RightColor = System.Drawing.Color.Black;
			this.labelInPageFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageFooter.Border.TopColor = System.Drawing.Color.Black;
			this.labelInPageFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInPageFooter.Height = 0.1968504F;
			this.labelInPageFooter.HyperLink = null;
			this.labelInPageFooter.Left = 1.574803F;
			this.labelInPageFooter.Name = "labelInPageFooter";
			this.labelInPageFooter.Style = "";
			this.labelInPageFooter.Text = "LabelInPageFooter";
			this.labelInPageFooter.Top = 0.1968504F;
			this.labelInPageFooter.Width = 1.968504F;
			// 
			// textBoxInPageFooter
			// 
			this.textBoxInPageFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInPageFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInPageFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageFooter.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInPageFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageFooter.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInPageFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInPageFooter.Height = 0.1574803F;
			this.textBoxInPageFooter.Left = 3.937008F;
			this.textBoxInPageFooter.Name = "textBoxInPageFooter";
			this.textBoxInPageFooter.Style = "";
			this.textBoxInPageFooter.Text = "textBoxInPageFooter";
			this.textBoxInPageFooter.Top = 0.1968504F;
			this.textBoxInPageFooter.Width = 1.771654F;
			// 
			// lineInFooter
			// 
			this.lineInFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInFooter.Border.RightColor = System.Drawing.Color.Black;
			this.lineInFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInFooter.Border.TopColor = System.Drawing.Color.Black;
			this.lineInFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInFooter.Height = 0F;
			this.lineInFooter.Left = 0.3937008F;
			this.lineInFooter.LineWeight = 1F;
			this.lineInFooter.Name = "lineInFooter";
			this.lineInFooter.Top = 0.3937008F;
			this.lineInFooter.Width = 0.3937008F;
			this.lineInFooter.X1 = 0.3937008F;
			this.lineInFooter.X2 = 0.7874016F;
			this.lineInFooter.Y1 = 0.3937008F;
			this.lineInFooter.Y2 = 0.3937008F;
			// 
			// labelInFooter
			// 
			this.labelInFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInFooter.Border.RightColor = System.Drawing.Color.Black;
			this.labelInFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInFooter.Border.TopColor = System.Drawing.Color.Black;
			this.labelInFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInFooter.Height = 0.1968504F;
			this.labelInFooter.HyperLink = null;
			this.labelInFooter.Left = 1.181102F;
			this.labelInFooter.Name = "labelInFooter";
			this.labelInFooter.Style = "";
			this.labelInFooter.Text = "LabelInFooter";
			this.labelInFooter.Top = 0.1968504F;
			this.labelInFooter.Width = 1.968504F;
			// 
			// textBoxInFooter
			// 
			this.textBoxInFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInFooter.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInFooter.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInFooter.Height = 0.1574803F;
			this.textBoxInFooter.Left = 3.582677F;
			this.textBoxInFooter.Name = "textBoxInFooter";
			this.textBoxInFooter.Style = "";
			this.textBoxInFooter.Text = "textBoxInFooter";
			this.textBoxInFooter.Top = 0.1968504F;
			this.textBoxInFooter.Width = 1.771654F;
			// 
			// groupHeader_
			// 
			this.groupHeader_.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lineInGroupHeader,
            this.labelInGroupHeader,
            this.textBoxInGroupHeader});
			this.groupHeader_.DataField = "GroupID";
			this.groupHeader_.Height = 0.8229167F;
			this.groupHeader_.Name = "groupHeader_";
			// 
			// groupFooter_
			// 
			this.groupFooter_.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.labelInGroupFooter,
            this.lineInGroupFooter,
            this.textBoxInGroupFooter,
            this.textBoxInGroupFooter_Sum});
			this.groupFooter_.Height = 0.625F;
			this.groupFooter_.Name = "groupFooter_";
			// 
			// lineInGroupHeader
			// 
			this.lineInGroupHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInGroupHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInGroupHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupHeader.Border.RightColor = System.Drawing.Color.Black;
			this.lineInGroupHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupHeader.Border.TopColor = System.Drawing.Color.Black;
			this.lineInGroupHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupHeader.Height = 0F;
			this.lineInGroupHeader.Left = 1.023622F;
			this.lineInGroupHeader.LineWeight = 1F;
			this.lineInGroupHeader.Name = "lineInGroupHeader";
			this.lineInGroupHeader.Top = 0.3937008F;
			this.lineInGroupHeader.Width = 0.3937007F;
			this.lineInGroupHeader.X1 = 1.023622F;
			this.lineInGroupHeader.X2 = 1.417323F;
			this.lineInGroupHeader.Y1 = 0.3937008F;
			this.lineInGroupHeader.Y2 = 0.3937008F;
			// 
			// labelInGroupHeader
			// 
			this.labelInGroupHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInGroupHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInGroupHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupHeader.Border.RightColor = System.Drawing.Color.Black;
			this.labelInGroupHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupHeader.Border.TopColor = System.Drawing.Color.Black;
			this.labelInGroupHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupHeader.Height = 0.1968504F;
			this.labelInGroupHeader.HyperLink = null;
			this.labelInGroupHeader.Left = 1.811024F;
			this.labelInGroupHeader.Name = "labelInGroupHeader";
			this.labelInGroupHeader.Style = "";
			this.labelInGroupHeader.Text = "LabelInGroupHeader";
			this.labelInGroupHeader.Top = 0.1968504F;
			this.labelInGroupHeader.Width = 1.968504F;
			// 
			// textBoxInGroupHeader
			// 
			this.textBoxInGroupHeader.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInGroupHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupHeader.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInGroupHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupHeader.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInGroupHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupHeader.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInGroupHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupHeader.Height = 0.1574803F;
			this.textBoxInGroupHeader.Left = 4.173229F;
			this.textBoxInGroupHeader.Name = "textBoxInGroupHeader";
			this.textBoxInGroupHeader.Style = "";
			this.textBoxInGroupHeader.Text = "textBoxInGroupHeader";
			this.textBoxInGroupHeader.Top = 0.1968504F;
			this.textBoxInGroupHeader.Width = 1.771654F;
			// 
			// lineInGroupFooter
			// 
			this.lineInGroupFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.lineInGroupFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.lineInGroupFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupFooter.Border.RightColor = System.Drawing.Color.Black;
			this.lineInGroupFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupFooter.Border.TopColor = System.Drawing.Color.Black;
			this.lineInGroupFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.lineInGroupFooter.Height = 0F;
			this.lineInGroupFooter.Left = 1.023622F;
			this.lineInGroupFooter.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash;
			this.lineInGroupFooter.LineWeight = 1F;
			this.lineInGroupFooter.Name = "lineInGroupFooter";
			this.lineInGroupFooter.Top = 0.3937008F;
			this.lineInGroupFooter.Width = 0.3937007F;
			this.lineInGroupFooter.X1 = 1.023622F;
			this.lineInGroupFooter.X2 = 1.417323F;
			this.lineInGroupFooter.Y1 = 0.3937008F;
			this.lineInGroupFooter.Y2 = 0.3937008F;
			// 
			// labelInGroupFooter
			// 
			this.labelInGroupFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.labelInGroupFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.labelInGroupFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupFooter.Border.RightColor = System.Drawing.Color.Black;
			this.labelInGroupFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupFooter.Border.TopColor = System.Drawing.Color.Black;
			this.labelInGroupFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.labelInGroupFooter.Height = 0.1574803F;
			this.labelInGroupFooter.HyperLink = null;
			this.labelInGroupFooter.Left = 1.771654F;
			this.labelInGroupFooter.Name = "labelInGroupFooter";
			this.labelInGroupFooter.Style = "";
			this.labelInGroupFooter.Text = "LabelInPageFooter";
			this.labelInGroupFooter.Top = 0.2362205F;
			this.labelInGroupFooter.Width = 1.968504F;
			// 
			// textBoxInGroupFooter
			// 
			this.textBoxInGroupFooter.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter.Height = 0.1574803F;
			this.textBoxInGroupFooter.Left = 4.173229F;
			this.textBoxInGroupFooter.Name = "textBoxInGroupFooter";
			this.textBoxInGroupFooter.Style = "";
			this.textBoxInGroupFooter.Text = "textBoxInPageFooter";
			this.textBoxInGroupFooter.Top = 0.2362205F;
			this.textBoxInGroupFooter.Width = 1.771654F;
			// 
			// textBoxInDetail_numeric
			// 
			this.textBoxInDetail_numeric.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInDetail_numeric.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_numeric.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInDetail_numeric.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_numeric.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInDetail_numeric.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_numeric.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInDetail_numeric.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInDetail_numeric.DataField = "NumField";
			this.textBoxInDetail_numeric.Height = 0.1574803F;
			this.textBoxInDetail_numeric.Left = 4.330709F;
			this.textBoxInDetail_numeric.Name = "textBoxInDetail_numeric";
			this.textBoxInDetail_numeric.OutputFormat = resources.GetString("textBoxInDetail_numeric.OutputFormat");
			this.textBoxInDetail_numeric.Style = "";
			this.textBoxInDetail_numeric.Text = "textBoxInDetail_numeric";
			this.textBoxInDetail_numeric.Top = 0.472441F;
			this.textBoxInDetail_numeric.Width = 1.771654F;
			// 
			// textBoxInGroupFooter_Sum
			// 
			this.textBoxInGroupFooter_Sum.Border.BottomColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter_Sum.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter_Sum.Border.LeftColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter_Sum.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter_Sum.Border.RightColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter_Sum.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter_Sum.Border.TopColor = System.Drawing.Color.Black;
			this.textBoxInGroupFooter_Sum.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
			this.textBoxInGroupFooter_Sum.DataField = "TextField";
			this.textBoxInGroupFooter_Sum.Height = 0.1574803F;
			this.textBoxInGroupFooter_Sum.Left = 4.173229F;
			this.textBoxInGroupFooter_Sum.Name = "textBoxInGroupFooter_Sum";
			this.textBoxInGroupFooter_Sum.Style = "";
			this.textBoxInGroupFooter_Sum.SummaryGroup = "GroupID";
			this.textBoxInGroupFooter_Sum.Text = "textBoxInGroupFooter_Sum";
			this.textBoxInGroupFooter_Sum.Top = 0.4330709F;
			this.textBoxInGroupFooter_Sum.Width = 1.771654F;
			// 
			// repTestReport
			// 
			this.PageSettings.PaperHeight = 11.69F;
			this.PageSettings.PaperWidth = 8.27F;
			this.PrintWidth = 7.086614F;
			this.Sections.Add(this.reportHeader_);
			this.Sections.Add(this.pageHeader_);
			this.Sections.Add(this.groupHeader_);
			this.Sections.Add(this.detail);
			this.Sections.Add(this.groupFooter_);
			this.Sections.Add(this.pageFooter_);
			this.Sections.Add(this.reportFooter_);
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
						"l; font-size: 10pt; color: Black; ", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
						"lic; ", "Heading2", "Normal"));
			this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
			((System.ComponentModel.ISupportInitialize)(this.labelInHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInPageHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInPageHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInDetail_string)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInPageFooter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInPageFooter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInFooter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInFooter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInGroupHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInGroupHeader)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.labelInGroupFooter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInGroupFooter)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInDetail_numeric)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.textBoxInGroupFooter_Sum)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}
		#endregion

		private DataDynamics.ActiveReports.ReportHeader reportHeader_;
		private DataDynamics.ActiveReports.ReportFooter reportFooter_;
		private DataDynamics.ActiveReports.Line lineInHeader;
		private DataDynamics.ActiveReports.Label labelInHeader;
		private DataDynamics.ActiveReports.TextBox textBoxInHeader;
		private DataDynamics.ActiveReports.Line lineInPageHeader;
		private DataDynamics.ActiveReports.Label labelInPageHeader;
		private DataDynamics.ActiveReports.TextBox textBoxInPageHeader;
		private DataDynamics.ActiveReports.Line lineInDetail;
		private DataDynamics.ActiveReports.Label labelInDetail;
		private DataDynamics.ActiveReports.TextBox textBoxInDetail_string;
		private DataDynamics.ActiveReports.Shape shapeInDetail;
		private DataDynamics.ActiveReports.Line lineInPageFooter;
		private DataDynamics.ActiveReports.Label labelInPageFooter;
		private DataDynamics.ActiveReports.TextBox textBoxInPageFooter;
		private DataDynamics.ActiveReports.Line lineInFooter;
		private DataDynamics.ActiveReports.Label labelInFooter;
		private DataDynamics.ActiveReports.TextBox textBoxInFooter;
		private DataDynamics.ActiveReports.GroupHeader groupHeader_;
		private DataDynamics.ActiveReports.Line lineInGroupHeader;
		private DataDynamics.ActiveReports.Label labelInGroupHeader;
		private DataDynamics.ActiveReports.TextBox textBoxInGroupHeader;
		private DataDynamics.ActiveReports.GroupFooter groupFooter_;
		private DataDynamics.ActiveReports.Label labelInGroupFooter;
		private DataDynamics.ActiveReports.Line lineInGroupFooter;
		private DataDynamics.ActiveReports.TextBox textBoxInGroupFooter;
		private DataDynamics.ActiveReports.TextBox textBoxInDetail_numeric;
		private DataDynamics.ActiveReports.TextBox textBoxInGroupFooter_Sum;
	}
}
