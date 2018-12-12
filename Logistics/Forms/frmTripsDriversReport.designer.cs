namespace Logistics
{
	partial class frmTripsDriversReport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTripsDriversReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnPrintFacture = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.pnlTerms = new RFMBaseClasses.RFMPanel();
            this.pnlMethod = new RFMBaseClasses.RFMPanel();
            this.radByID = new RFMBaseClasses.RFMRadioButton();
            this.radByAddress = new RFMBaseClasses.RFMRadioButton();
            this.pnlOwners = new RFMBaseClasses.RFMPanel();
            this.txtOwnersChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnOwnersClear = new RFMBaseClasses.RFMButton();
            this.btnOwnersChoose = new RFMBaseClasses.RFMButton();
            this.lblOwners = new RFMBaseClasses.RFMLabel();
            this.pnlDrivers = new RFMBaseClasses.RFMPanel();
            this.txtDriversChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnDriversClear = new RFMBaseClasses.RFMButton();
            this.btnDriversChoose = new RFMBaseClasses.RFMButton();
            this.lblDrivers = new RFMBaseClasses.RFMLabel();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.lblDate = new RFMBaseClasses.RFMLabel();
            this.btnGo = new RFMBaseClasses.RFMButton();
            this.tсPages = new RFMBaseClasses.RFMTabControl();
            this.tabPoints = new RFMBaseClasses.RFMTabPage();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcOwnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcUploadPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDeliveredPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNotSpecialZonePoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSpecialZonePoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNotBroughtPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcInputsPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcReturnsPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.pnlData.SuspendLayout();
            this.pnlTerms.SuspendLayout();
            this.pnlMethod.SuspendLayout();
            this.pnlOwners.SuspendLayout();
            this.pnlDrivers.SuspendLayout();
            this.dtrDates.SuspendLayout();
            this.tсPages.SuspendLayout();
            this.tabPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(6, 438);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(704, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintFacture
            // 
            this.btnPrintFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintFacture.Image = global::Logistics.Properties.Resources.Printer_iz;
            this.btnPrintFacture.Location = new System.Drawing.Point(604, 438);
            this.btnPrintFacture.Name = "btnPrintFacture";
            this.btnPrintFacture.Size = new System.Drawing.Size(32, 30);
            this.btnPrintFacture.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnPrintFacture, "Печатать счета-фактуры");
            this.btnPrintFacture.UseVisualStyleBackColor = true;
            this.btnPrintFacture.Visible = false;
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.pnlTerms);
            this.pnlData.Controls.Add(this.tсPages);
            this.pnlData.Location = new System.Drawing.Point(2, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(738, 429);
            this.pnlData.TabIndex = 0;
            // 
            // pnlTerms
            // 
            this.pnlTerms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTerms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTerms.Controls.Add(this.pnlMethod);
            this.pnlTerms.Controls.Add(this.pnlOwners);
            this.pnlTerms.Controls.Add(this.lblOwners);
            this.pnlTerms.Controls.Add(this.pnlDrivers);
            this.pnlTerms.Controls.Add(this.lblDrivers);
            this.pnlTerms.Controls.Add(this.dtrDates);
            this.pnlTerms.Controls.Add(this.lblDate);
            this.pnlTerms.Controls.Add(this.btnGo);
            this.pnlTerms.Location = new System.Drawing.Point(1, 1);
            this.pnlTerms.Name = "pnlTerms";
            this.pnlTerms.Size = new System.Drawing.Size(732, 66);
            this.pnlTerms.TabIndex = 15;
            // 
            // pnlMethod
            // 
            this.pnlMethod.Controls.Add(this.radByID);
            this.pnlMethod.Controls.Add(this.radByAddress);
            this.pnlMethod.Location = new System.Drawing.Point(55, 31);
            this.pnlMethod.Name = "pnlMethod";
            this.pnlMethod.Size = new System.Drawing.Size(222, 28);
            this.pnlMethod.TabIndex = 25;
            // 
            // radByID
            // 
            this.radByID.AutoSize = true;
            this.radByID.Location = new System.Drawing.Point(109, 5);
            this.radByID.Name = "radByID";
            this.radByID.Size = new System.Drawing.Size(77, 18);
            this.radByID.TabIndex = 1;
            this.radByID.TabStop = true;
            this.radByID.Text = "по кодам";
            this.ttToolTip.SetToolTip(this.radByID, "Суммируются только точки с одинаковым кодом");
            this.radByID.UseVisualStyleBackColor = true;
            // 
            // radByAddress
            // 
            this.radByAddress.AutoSize = true;
            this.radByAddress.Checked = true;
            this.radByAddress.IsChanged = true;
            this.radByAddress.Location = new System.Drawing.Point(8, 5);
            this.radByAddress.Name = "radByAddress";
            this.radByAddress.Size = new System.Drawing.Size(90, 18);
            this.radByAddress.TabIndex = 0;
            this.radByAddress.TabStop = true;
            this.radByAddress.Text = "по адресам";
            this.ttToolTip.SetToolTip(this.radByAddress, "Суммируются точки с одинаковым адресом");
            this.radByAddress.UseVisualStyleBackColor = true;
            // 
            // pnlOwners
            // 
            this.pnlOwners.Controls.Add(this.txtOwnersChoosen);
            this.pnlOwners.Controls.Add(this.btnOwnersClear);
            this.pnlOwners.Controls.Add(this.btnOwnersChoose);
            this.pnlOwners.Location = new System.Drawing.Point(380, 31);
            this.pnlOwners.Name = "pnlOwners";
            this.pnlOwners.Size = new System.Drawing.Size(278, 30);
            this.pnlOwners.TabIndex = 24;
            // 
            // txtOwnersChoosen
            // 
            this.txtOwnersChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtOwnersChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOwnersChoosen.Enabled = false;
            this.txtOwnersChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtOwnersChoosen.Name = "txtOwnersChoosen";
            this.txtOwnersChoosen.OldValue = "";
            this.txtOwnersChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtOwnersChoosen.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.txtOwnersChoosen, "Владельцы");
            // 
            // btnOwnersClear
            // 
            this.btnOwnersClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnOwnersClear.Location = new System.Drawing.Point(249, 3);
            this.btnOwnersClear.Name = "btnOwnersClear";
            this.btnOwnersClear.Size = new System.Drawing.Size(26, 24);
            this.btnOwnersClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnOwnersClear, "Очистить выбор владельцев");
            this.btnOwnersClear.UseVisualStyleBackColor = true;
            this.btnOwnersClear.Click += new System.EventHandler(this.btnOwnersClear_Click);
            // 
            // btnOwnersChoose
            // 
            this.btnOwnersChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnOwnersChoose.Location = new System.Drawing.Point(221, 3);
            this.btnOwnersChoose.Name = "btnOwnersChoose";
            this.btnOwnersChoose.Size = new System.Drawing.Size(26, 24);
            this.btnOwnersChoose.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnOwnersChoose, "Выбор поставщиков");
            this.btnOwnersChoose.UseVisualStyleBackColor = true;
            this.btnOwnersChoose.Click += new System.EventHandler(this.btnOwnersChoose_Click);
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOwners.Location = new System.Drawing.Point(313, 38);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(62, 14);
            this.lblOwners.TabIndex = 23;
            this.lblOwners.Text = "Владелец";
            // 
            // pnlDrivers
            // 
            this.pnlDrivers.Controls.Add(this.txtDriversChoosen);
            this.pnlDrivers.Controls.Add(this.btnDriversClear);
            this.pnlDrivers.Controls.Add(this.btnDriversChoose);
            this.pnlDrivers.Location = new System.Drawing.Point(380, 2);
            this.pnlDrivers.Name = "pnlDrivers";
            this.pnlDrivers.Size = new System.Drawing.Size(278, 30);
            this.pnlDrivers.TabIndex = 22;
            // 
            // txtDriversChoosen
            // 
            this.txtDriversChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriversChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriversChoosen.Enabled = false;
            this.txtDriversChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtDriversChoosen.Name = "txtDriversChoosen";
            this.txtDriversChoosen.OldValue = "";
            this.txtDriversChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtDriversChoosen.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.txtDriversChoosen, "Список выбранных водителей");
            // 
            // btnDriversClear
            // 
            this.btnDriversClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnDriversClear.Location = new System.Drawing.Point(249, 3);
            this.btnDriversClear.Name = "btnDriversClear";
            this.btnDriversClear.Size = new System.Drawing.Size(26, 24);
            this.btnDriversClear.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnDriversClear, "Очистить выбор водителей");
            this.btnDriversClear.UseVisualStyleBackColor = true;
            this.btnDriversClear.Click += new System.EventHandler(this.btnDriversClear_Click);
            // 
            // btnDriversChoose
            // 
            this.btnDriversChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnDriversChoose.Location = new System.Drawing.Point(221, 3);
            this.btnDriversChoose.Name = "btnDriversChoose";
            this.btnDriversChoose.Size = new System.Drawing.Size(26, 24);
            this.btnDriversChoose.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnDriversChoose, "Выбор водителей");
            this.btnDriversChoose.UseVisualStyleBackColor = true;
            this.btnDriversChoose.Click += new System.EventHandler(this.btnDriversChoose_Click);
            // 
            // lblDrivers
            // 
            this.lblDrivers.AutoSize = true;
            this.lblDrivers.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDrivers.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDrivers.Location = new System.Drawing.Point(313, 9);
            this.lblDrivers.Name = "lblDrivers";
            this.lblDrivers.Size = new System.Drawing.Size(61, 14);
            this.lblDrivers.TabIndex = 21;
            this.lblDrivers.Text = "Водитель";
            // 
            // dtrDates
            // 
            this.dtrDates.BegValue = new System.DateTime(2007, 7, 31, 0, 0, 0, 0);
            // 
            // dtrDates.btnClear
            // 
            this.dtrDates.BtnСlear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtrDates.BtnСlear.Image = ((System.Drawing.Image)(resources.GetObject("dtrDates.btnClear.Image")));
            this.dtrDates.BtnСlear.Location = new System.Drawing.Point(195, 4);
            this.dtrDates.BtnСlear.Name = "btnClear";
            this.dtrDates.BtnСlear.Size = new System.Drawing.Size(24, 22);
            this.dtrDates.BtnСlear.TabIndex = 3;
            this.dtrDates.BtnСlear.UseVisualStyleBackColor = true;
            // 
            // dtrDates.dtpBegDate
            // 
            this.dtrDates.DtpBegDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtrDates.DtpBegDate.CustomFormat = "dd.MM.yyyy";
            this.dtrDates.DtpBegDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtrDates.DtpBegDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtrDates.DtpBegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtrDates.DtpBegDate.Location = new System.Drawing.Point(0, 4);
            this.dtrDates.DtpBegDate.Name = "dtpBegDate";
            this.dtrDates.DtpBegDate.Size = new System.Drawing.Size(91, 22);
            this.dtrDates.DtpBegDate.TabIndex = 0;
            // 
            // dtrDates.dtpEndDate
            // 
            this.dtrDates.DtpEndDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtrDates.DtpEndDate.CustomFormat = "dd.MM.yyyy";
            this.dtrDates.DtpEndDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtrDates.DtpEndDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtrDates.DtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtrDates.DtpEndDate.Location = new System.Drawing.Point(101, 4);
            this.dtrDates.DtpEndDate.Name = "dtpEndDate";
            this.dtrDates.DtpEndDate.Size = new System.Drawing.Size(91, 22);
            this.dtrDates.DtpEndDate.TabIndex = 2;
            this.dtrDates.EndValue = new System.DateTime(2007, 7, 31, 0, 0, 0, 0);
            this.dtrDates.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // dtrDates.lblDelimiter
            // 
            this.dtrDates.LblDelimiter.AutoSize = true;
            this.dtrDates.LblDelimiter.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtrDates.LblDelimiter.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtrDates.LblDelimiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtrDates.LblDelimiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtrDates.LblDelimiter.Location = new System.Drawing.Point(90, 7);
            this.dtrDates.LblDelimiter.Name = "lblDelimiter";
            this.dtrDates.LblDelimiter.Size = new System.Drawing.Size(13, 16);
            this.dtrDates.LblDelimiter.TabIndex = 1;
            this.dtrDates.LblDelimiter.Text = ":";
            this.dtrDates.Location = new System.Drawing.Point(60, 1);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(222, 29);
            this.dtrDates.TabIndex = 20;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(3, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 14);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Период:";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Image = global::Logistics.Properties.Resources.Go;
            this.btnGo.Location = new System.Drawing.Point(697, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(28, 28);
            this.btnGo.TabIndex = 18;
            this.ttToolTip.SetToolTip(this.btnGo, "Получить отчет");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tсPages
            // 
            this.tсPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tсPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tсPages.Controls.Add(this.tabPoints);
            this.tсPages.Location = new System.Drawing.Point(1, 69);
            this.tсPages.Name = "tсPages";
            this.tсPages.SelectedIndex = 0;
            this.tсPages.Size = new System.Drawing.Size(732, 355);
            this.tсPages.TabIndex = 18;
            // 
            // tabPoints
            // 
            this.tabPoints.Controls.Add(this.grdData);
            this.tabPoints.Location = new System.Drawing.Point(4, 4);
            this.tabPoints.Name = "tabPoints";
            this.tabPoints.Padding = new System.Windows.Forms.Padding(3);
            this.tabPoints.Size = new System.Drawing.Size(724, 328);
            this.tabPoints.TabIndex = 0;
            this.tabPoints.Text = "Точки";
            this.tabPoints.UseVisualStyleBackColor = true;
            // 
            // grdData
            // 
            this.grdData.AllowUserToAddRows = false;
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AllowUserToOrderColumns = true;
            this.grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcOwnerName,
            this.grcDriverName,
            this.grcUploadPoints,
            this.grcDeliveredPoints,
            this.grcNotSpecialZonePoints,
            this.grcSpecialZonePoints,
            this.grcNotBroughtPoints,
            this.grcInputsPoints,
            this.grcReturnsPoints});
            this.grdData.IsCheckerInclude = true;
            this.grdData.IsConfigInclude = true;
            this.grdData.IsMarkedAll = false;
            this.grdData.IsStatusInclude = true;
            this.grdData.IsStatusShow = true;
            this.grdData.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdData.Location = new System.Drawing.Point(-1, -1);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdData.Size = new System.Drawing.Size(725, 327);
            this.grdData.StatusRowState = ((byte)(2));
            this.grdData.TabIndex = 14;
            // 
            // grcOwnerName
            // 
            this.grcOwnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOwnerName.DataPropertyName = "OwnerName";
            this.grcOwnerName.HeaderText = "Владелец";
            this.grcOwnerName.Name = "grcOwnerName";
            this.grcOwnerName.ReadOnly = true;
            this.grcOwnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOwnerName.Width = 110;
            // 
            // grcDriverName
            // 
            this.grcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDriverName.DataPropertyName = "DriverName";
            this.grcDriverName.HeaderText = "Водитель";
            this.grcDriverName.Name = "grcDriverName";
            this.grcDriverName.ReadOnly = true;
            this.grcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDriverName.Width = 150;
            // 
            // grcUploadPoints
            // 
            this.grcUploadPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcUploadPoints.DataPropertyName = "UploadPoints";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "### ###";
            this.grcUploadPoints.DefaultCellStyle = dataGridViewCellStyle17;
            this.grcUploadPoints.HeaderText = "ТЗ";
            this.grcUploadPoints.Name = "grcUploadPoints";
            this.grcUploadPoints.ReadOnly = true;
            this.grcUploadPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcUploadPoints.ToolTipText = "Точек загружено (расход)";
            this.grcUploadPoints.Width = 65;
            // 
            // grcDeliveredPoints
            // 
            this.grcDeliveredPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDeliveredPoints.DataPropertyName = "DeliveredPoints";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "### ###";
            this.grcDeliveredPoints.DefaultCellStyle = dataGridViewCellStyle18;
            this.grcDeliveredPoints.HeaderText = "ТР";
            this.grcDeliveredPoints.Name = "grcDeliveredPoints";
            this.grcDeliveredPoints.ReadOnly = true;
            this.grcDeliveredPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDeliveredPoints.ToolTipText = "Точек развезено";
            this.grcDeliveredPoints.Width = 65;
            // 
            // grcNotSpecialZonePoints
            // 
            this.grcNotSpecialZonePoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNotSpecialZonePoints.DataPropertyName = "NotSpecialZonePoints";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "### ###";
            this.grcNotSpecialZonePoints.DefaultCellStyle = dataGridViewCellStyle19;
            this.grcNotSpecialZonePoints.HeaderText = "ТРнеСп";
            this.grcNotSpecialZonePoints.Name = "grcNotSpecialZonePoints";
            this.grcNotSpecialZonePoints.ReadOnly = true;
            this.grcNotSpecialZonePoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNotSpecialZonePoints.ToolTipText = "Точек развезено - неСпециальные зоны";
            this.grcNotSpecialZonePoints.Width = 65;
            // 
            // grcSpecialZonePoints
            // 
            this.grcSpecialZonePoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSpecialZonePoints.DataPropertyName = "SpecialZonePoints";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "### ###";
            this.grcSpecialZonePoints.DefaultCellStyle = dataGridViewCellStyle20;
            this.grcSpecialZonePoints.HeaderText = "ТРСп";
            this.grcSpecialZonePoints.Name = "grcSpecialZonePoints";
            this.grcSpecialZonePoints.ReadOnly = true;
            this.grcSpecialZonePoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSpecialZonePoints.ToolTipText = "Точек развезено - Специальные зоны";
            this.grcSpecialZonePoints.Width = 65;
            // 
            // grcNotBroughtPoints
            // 
            this.grcNotBroughtPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNotBroughtPoints.DataPropertyName = "NotBroughtPoints";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle21.Format = "### ###";
            this.grcNotBroughtPoints.DefaultCellStyle = dataGridViewCellStyle21;
            this.grcNotBroughtPoints.HeaderText = "ТнеДост";
            this.grcNotBroughtPoints.Name = "grcNotBroughtPoints";
            this.grcNotBroughtPoints.ReadOnly = true;
            this.grcNotBroughtPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNotBroughtPoints.ToolTipText = "Точек не доставлено полностью (возращено)";
            this.grcNotBroughtPoints.Width = 65;
            // 
            // grcInputsPoints
            // 
            this.grcInputsPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcInputsPoints.DataPropertyName = "InputsPoints";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle22.Format = "### ###";
            this.grcInputsPoints.DefaultCellStyle = dataGridViewCellStyle22;
            this.grcInputsPoints.HeaderText = "ТПр";
            this.grcInputsPoints.Name = "grcInputsPoints";
            this.grcInputsPoints.ReadOnly = true;
            this.grcInputsPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcInputsPoints.ToolTipText = "Точек (приходы основные)";
            this.grcInputsPoints.Width = 65;
            // 
            // grcReturnsPoints
            // 
            this.grcReturnsPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcReturnsPoints.DataPropertyName = "ReturnsPoints";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle23.Format = "### ###";
            dataGridViewCellStyle23.NullValue = null;
            this.grcReturnsPoints.DefaultCellStyle = dataGridViewCellStyle23;
            this.grcReturnsPoints.HeaderText = "ТПрВозвр";
            this.grcReturnsPoints.Name = "grcReturnsPoints";
            this.grcReturnsPoints.ReadOnly = true;
            this.grcReturnsPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcReturnsPoints.ToolTipText = "Точек - приходы-возвраты";
            this.grcReturnsPoints.Width = 65;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(654, 438);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печатать отчет (Excel)");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmTripsDriversReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintFacture);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MinimizeBox = false;
            this.Name = "frmTripsDriversReport";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Водители";
            this.Load += new System.EventHandler(this.frmTripsDriversReport_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlTerms.ResumeLayout(false);
            this.pnlTerms.PerformLayout();
            this.pnlMethod.ResumeLayout(false);
            this.pnlMethod.PerformLayout();
            this.pnlOwners.ResumeLayout(false);
            this.pnlOwners.PerformLayout();
            this.pnlDrivers.ResumeLayout(false);
            this.pnlDrivers.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.tсPages.ResumeLayout(false);
            this.tabPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnPrintFacture;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMTabControl tсPages;
		private RFMBaseClasses.RFMTabPage tabPoints;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOwnerName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcUploadPoints;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDeliveredPoints;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNotSpecialZonePoints;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSpecialZonePoints;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNotBroughtPoints;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcInputsPoints;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcReturnsPoints;
		private RFMBaseClasses.RFMPanel pnlTerms;
		private RFMBaseClasses.RFMPanel pnlOwners;
		private RFMBaseClasses.RFMTextBox txtOwnersChoosen;
		private RFMBaseClasses.RFMButton btnOwnersClear;
		private RFMBaseClasses.RFMButton btnOwnersChoose;
		private RFMBaseClasses.RFMLabel lblOwners;
		private RFMBaseClasses.RFMPanel pnlDrivers;
		private RFMBaseClasses.RFMTextBox txtDriversChoosen;
		private RFMBaseClasses.RFMButton btnDriversClear;
		private RFMBaseClasses.RFMButton btnDriversChoose;
		private RFMBaseClasses.RFMLabel lblDrivers;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMButton btnGo;
        private RFMBaseClasses.RFMPanel pnlMethod;
        private RFMBaseClasses.RFMRadioButton radByAddress;
        private RFMBaseClasses.RFMRadioButton radByID;

	}
}

