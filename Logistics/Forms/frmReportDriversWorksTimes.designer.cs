namespace Logistics
{
	partial class frmReportDriversWorksTimes
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportDriversWorksTimes));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnPrintFacture = new RFMBaseClasses.RFMButton();
			this.pnlData = new RFMBaseClasses.RFMPanel();
			this.pnlTerms = new RFMBaseClasses.RFMPanel();
			this.chkTotal = new RFMBaseClasses.RFMCheckBox();
			this.lblDrivers = new RFMBaseClasses.RFMLabel();
			this.dtrDates = new RFMBaseClasses.RFMDateRange();
			this.lblDate = new RFMBaseClasses.RFMLabel();
			this.btnGo = new RFMBaseClasses.RFMButton();
			this.tсPages = new RFMBaseClasses.RFMTabControl();
			this.tabDrivers = new RFMBaseClasses.RFMTabPage();
			this.grdTrips = new RFMBaseClasses.RFMDataGridView();
			this.btnPrint = new RFMBaseClasses.RFMButton();
			this.ucSelectRecordID_Drivers = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.grcTrips_DriverName_ = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_DateTrip = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_CarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_DepartureTime = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_ArrivalTime = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_DurationHoursMinutesWay_ = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_DurationPartsWay_ = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_Alias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrips_TripNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.pnlData.SuspendLayout();
			this.pnlTerms.SuspendLayout();
			this.dtrDates.SuspendLayout();
			this.tсPages.SuspendLayout();
			this.tabDrivers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).BeginInit();
			this.ucSelectRecordID_Drivers.SuspendLayout();
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
			this.pnlTerms.Controls.Add(this.ucSelectRecordID_Drivers);
			this.pnlTerms.Controls.Add(this.chkTotal);
			this.pnlTerms.Controls.Add(this.lblDrivers);
			this.pnlTerms.Controls.Add(this.dtrDates);
			this.pnlTerms.Controls.Add(this.lblDate);
			this.pnlTerms.Controls.Add(this.btnGo);
			this.pnlTerms.Location = new System.Drawing.Point(1, 1);
			this.pnlTerms.Name = "pnlTerms";
			this.pnlTerms.Size = new System.Drawing.Size(732, 37);
			this.pnlTerms.TabIndex = 15;
			// 
			// chkTotal
			// 
			this.chkTotal.AutoSize = true;
			this.chkTotal.Location = new System.Drawing.Point(639, 8);
			this.chkTotal.Name = "chkTotal";
			this.chkTotal.Size = new System.Drawing.Size(52, 18);
			this.chkTotal.TabIndex = 23;
			this.chkTotal.Text = "свод";
			this.chkTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkTotal.UseVisualStyleBackColor = true;
			// 
			// lblDrivers
			// 
			this.lblDrivers.AutoSize = true;
			this.lblDrivers.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDrivers.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDrivers.Location = new System.Drawing.Point(285, 10);
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
			this.dtrDates.Location = new System.Drawing.Point(54, 2);
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
			this.lblDate.Location = new System.Drawing.Point(2, 10);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(50, 14);
			this.lblDate.TabIndex = 19;
			this.lblDate.Text = "Период";
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
			this.tсPages.Controls.Add(this.tabDrivers);
			this.tсPages.Location = new System.Drawing.Point(2, 40);
			this.tсPages.Name = "tсPages";
			this.tсPages.SelectedIndex = 0;
			this.tсPages.Size = new System.Drawing.Size(732, 383);
			this.tсPages.TabIndex = 18;
			// 
			// tabDrivers
			// 
			this.tabDrivers.Controls.Add(this.grdTrips);
			this.tabDrivers.Location = new System.Drawing.Point(4, 4);
			this.tabDrivers.Name = "tabDrivers";
			this.tabDrivers.Padding = new System.Windows.Forms.Padding(3);
			this.tabDrivers.Size = new System.Drawing.Size(724, 356);
			this.tabDrivers.TabIndex = 0;
			this.tabDrivers.Text = "Водители";
			this.tabDrivers.UseVisualStyleBackColor = true;
			// 
			// grdTrips
			// 
			this.grdTrips.AllowUserToAddRows = false;
			this.grdTrips.AllowUserToDeleteRows = false;
			this.grdTrips.AllowUserToOrderColumns = true;
			this.grdTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdTrips.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdTrips.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcTrips_DriverName_,
            this.grcTrips_DateTrip,
            this.grcTrips_CarName,
            this.grcTrips_DepartureTime,
            this.grcTrips_ArrivalTime,
            this.grcTrips_DurationHoursMinutesWay_,
            this.grcTrips_DurationPartsWay_,
            this.grcTrips_Alias,
            this.grcTrips_TripNumber});
			this.grdTrips.IsCheckerInclude = true;
			this.grdTrips.IsConfigInclude = true;
			this.grdTrips.IsMarkedAll = false;
			this.grdTrips.IsStatusInclude = true;
			this.grdTrips.IsStatusShow = true;
			this.grdTrips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdTrips.Location = new System.Drawing.Point(2, 0);
			this.grdTrips.MultiSelect = false;
			this.grdTrips.Name = "grdTrips";
			this.grdTrips.RangedWay = ' ';
			this.grdTrips.ReadOnly = true;
			this.grdTrips.RowHeadersWidth = 24;
			this.grdTrips.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdTrips.Size = new System.Drawing.Size(721, 352);
			this.grdTrips.StatusRowState = ((byte)(2));
			this.grdTrips.TabIndex = 13;
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
			// ucSelectRecordID_Drivers
			// 
			// 
			// ucSelectRecordID_Drivers.btnClear
			// 
			this.ucSelectRecordID_Drivers.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Drivers.btnClear.Image")));
			this.ucSelectRecordID_Drivers.BtnClear.Location = new System.Drawing.Point(248, 4);
			this.ucSelectRecordID_Drivers.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_Drivers.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Drivers.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Drivers.BtnClear, "Очистка выбора водителей");
			this.ucSelectRecordID_Drivers.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_Drivers.btnSelect
			// 
			this.ucSelectRecordID_Drivers.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Drivers.btnSelect.Image")));
			this.ucSelectRecordID_Drivers.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_Drivers.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_Drivers.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Drivers.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Drivers.BtnSelect, "Выбор водителей");
			this.ucSelectRecordID_Drivers.BtnSelect.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_Drivers.txtData
			// 
			this.ucSelectRecordID_Drivers.txtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_Drivers.txtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_Drivers.txtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_Drivers.txtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_Drivers.txtData.MaxLength = 128;
			this.ucSelectRecordID_Drivers.txtData.Name = "txtData";
			this.ucSelectRecordID_Drivers.txtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_Drivers.txtData.TabIndex = 0;
			this.ucSelectRecordID_Drivers.ExpSort = "Name";
			this.ucSelectRecordID_Drivers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_Drivers.IsActualOnly = true;
			this.ucSelectRecordID_Drivers.IsSaveMark = true;
			this.ucSelectRecordID_Drivers.IsUseMark = true;
			this.ucSelectRecordID_Drivers.Location = new System.Drawing.Point(346, 1);
			this.ucSelectRecordID_Drivers.Name = "ucSelectRecordID_Drivers";
			this.ucSelectRecordID_Drivers.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_Drivers.TabIndex = 24;
			this.ucSelectRecordID_Drivers.TableColumnName = "Name";
			this.ucSelectRecordID_Drivers.СolumnsData.AddRange(new string[] {
            "ID, ID",
            "Name, Владелец",
            "SeparatePicking, Учет?",
            "Actual, Акт."});
			// 
			// grcTrips_DriverName_
			// 
			this.grcTrips_DriverName_.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_DriverName_.DataPropertyName = "DriverName";
			this.grcTrips_DriverName_.HeaderText = "Водитель";
			this.grcTrips_DriverName_.Name = "grcTrips_DriverName_";
			this.grcTrips_DriverName_.ReadOnly = true;
			this.grcTrips_DriverName_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_DriverName_.Width = 150;
			// 
			// grcTrips_DateTrip
			// 
			this.grcTrips_DateTrip.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_DateTrip.DataPropertyName = "DateTrip";
			dataGridViewCellStyle2.Format = "dd.MM.yyyy";
			this.grcTrips_DateTrip.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcTrips_DateTrip.HeaderText = "Дата рейса";
			this.grcTrips_DateTrip.Name = "grcTrips_DateTrip";
			this.grcTrips_DateTrip.ReadOnly = true;
			this.grcTrips_DateTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_DateTrip.Width = 75;
			// 
			// grcTrips_CarName
			// 
			this.grcTrips_CarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_CarName.DataPropertyName = "CarNumber";
			this.grcTrips_CarName.HeaderText = "Машина";
			this.grcTrips_CarName.Name = "grcTrips_CarName";
			this.grcTrips_CarName.ReadOnly = true;
			this.grcTrips_CarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_CarName.ToolTipText = "Машина собственная";
			// 
			// grcTrips_DepartureTime
			// 
			this.grcTrips_DepartureTime.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_DepartureTime.DataPropertyName = "DepartureTime";
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm";
			this.grcTrips_DepartureTime.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcTrips_DepartureTime.HeaderText = "Выезд";
			this.grcTrips_DepartureTime.Name = "grcTrips_DepartureTime";
			this.grcTrips_DepartureTime.ReadOnly = true;
			this.grcTrips_DepartureTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_DepartureTime.ToolTipText = "Дата-время выезда с базы";
			this.grcTrips_DepartureTime.Width = 110;
			// 
			// grcTrips_ArrivalTime
			// 
			this.grcTrips_ArrivalTime.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_ArrivalTime.DataPropertyName = "ArrivalTime";
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.Format = "dd.MM.yyyy HH:mm";
			this.grcTrips_ArrivalTime.DefaultCellStyle = dataGridViewCellStyle4;
			this.grcTrips_ArrivalTime.HeaderText = "Возвр.";
			this.grcTrips_ArrivalTime.Name = "grcTrips_ArrivalTime";
			this.grcTrips_ArrivalTime.ReadOnly = true;
			this.grcTrips_ArrivalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_ArrivalTime.ToolTipText = "Дата-время возвращения на базу";
			this.grcTrips_ArrivalTime.Width = 110;
			// 
			// grcTrips_DurationHoursMinutesWay_
			// 
			this.grcTrips_DurationHoursMinutesWay_.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_DurationHoursMinutesWay_.DataPropertyName = "DurationHoursMinutesWay";
			this.grcTrips_DurationHoursMinutesWay_.HeaderText = "Длит.(чч:мм)";
			this.grcTrips_DurationHoursMinutesWay_.Name = "grcTrips_DurationHoursMinutesWay_";
			this.grcTrips_DurationHoursMinutesWay_.ReadOnly = true;
			this.grcTrips_DurationHoursMinutesWay_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_DurationHoursMinutesWay_.ToolTipText = "Длительность, часов:минут";
			this.grcTrips_DurationHoursMinutesWay_.Width = 70;
			// 
			// grcTrips_DurationPartsWay_
			// 
			this.grcTrips_DurationPartsWay_.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_DurationPartsWay_.DataPropertyName = "DurationPartsWay";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N1";
			this.grcTrips_DurationPartsWay_.DefaultCellStyle = dataGridViewCellStyle5;
			this.grcTrips_DurationPartsWay_.HeaderText = "Длит.(доли)";
			this.grcTrips_DurationPartsWay_.Name = "grcTrips_DurationPartsWay_";
			this.grcTrips_DurationPartsWay_.ReadOnly = true;
			this.grcTrips_DurationPartsWay_.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_DurationPartsWay_.ToolTipText = "Длительность (часы,доли часов)";
			this.grcTrips_DurationPartsWay_.Width = 70;
			// 
			// grcTrips_Alias
			// 
			this.grcTrips_Alias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_Alias.DataPropertyName = "Alias";
			this.grcTrips_Alias.HeaderText = "Описание";
			this.grcTrips_Alias.Name = "grcTrips_Alias";
			this.grcTrips_Alias.ReadOnly = true;
			this.grcTrips_Alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_Alias.Width = 200;
			// 
			// grcTrips_TripNumber
			// 
			this.grcTrips_TripNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrips_TripNumber.DataPropertyName = "TripNumber";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcTrips_TripNumber.DefaultCellStyle = dataGridViewCellStyle6;
			this.grcTrips_TripNumber.HeaderText = "Езд.";
			this.grcTrips_TripNumber.Name = "grcTrips_TripNumber";
			this.grcTrips_TripNumber.ReadOnly = true;
			this.grcTrips_TripNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrips_TripNumber.ToolTipText = "№ поездки";
			this.grcTrips_TripNumber.Width = 45;
			// 
			// frmReportDriversWorksTimes
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
			this.Name = "frmReportDriversWorksTimes";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Водители";
			this.Load += new System.EventHandler(this.frmReportDriversWorksTimes_Load);
			this.pnlData.ResumeLayout(false);
			this.pnlTerms.ResumeLayout(false);
			this.pnlTerms.PerformLayout();
			this.dtrDates.ResumeLayout(false);
			this.dtrDates.PerformLayout();
			this.tсPages.ResumeLayout(false);
			this.tabDrivers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).EndInit();
			this.ucSelectRecordID_Drivers.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnPrintFacture;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMTabControl tсPages;
		private RFMBaseClasses.RFMTabPage tabDrivers;
		private RFMBaseClasses.RFMPanel pnlTerms;
		private RFMBaseClasses.RFMLabel lblDrivers;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMButton btnGo;
		private RFMBaseClasses.RFMDataGridView grdTrips;
		private RFMBaseClasses.RFMCheckBox chkTotal;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Drivers;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DriverName_;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DateTrip;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_CarName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DepartureTime;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_ArrivalTime;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DurationHoursMinutesWay_;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DurationPartsWay_;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_Alias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_TripNumber;

	}
}

