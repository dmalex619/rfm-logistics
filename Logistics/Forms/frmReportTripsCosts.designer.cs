namespace Logistics
{
	partial class frmReportTripsCosts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportTripsCosts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.pnlTerms = new RFMBaseClasses.RFMPanel();
            this.ucSelectRecordID_DepartmentNames = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.rfmLabel2 = new RFMBaseClasses.RFMLabel();
            this.ucSelectRecordID_ManagerNames = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.rfmLabel1 = new RFMBaseClasses.RFMLabel();
            this.lblGroupBy = new RFMBaseClasses.RFMLabel();
            this.pnlGroupBy = new RFMBaseClasses.RFMPanel();
            this.optGroupByD = new RFMBaseClasses.RFMRadioButton();
            this.optGroupByM = new RFMBaseClasses.RFMRadioButton();
            this.optGroupByP = new RFMBaseClasses.RFMRadioButton();
            this.optGroupByO = new RFMBaseClasses.RFMRadioButton();
            this.lblOwners = new RFMBaseClasses.RFMLabel();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.lblDate = new RFMBaseClasses.RFMLabel();
            this.btnGo = new RFMBaseClasses.RFMButton();
            this.ucSelectRecordID_Partners = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.lblPartners = new RFMBaseClasses.RFMLabel();
            this.ucSelectRecordID_Owners = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.tсPages = new RFMBaseClasses.RFMTabControl();
            this.tabDrivers = new RFMBaseClasses.RFMTabPage();
            this.grdTrips = new RFMBaseClasses.RFMDataGridView();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.grcTrips_DateOutput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_PartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_ManagerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_DepartmentName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_Netto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_Distance = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_TripAmount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_BillNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.pnlData.SuspendLayout();
            this.pnlTerms.SuspendLayout();
            this.ucSelectRecordID_DepartmentNames.SuspendLayout();
            this.ucSelectRecordID_ManagerNames.SuspendLayout();
            this.pnlGroupBy.SuspendLayout();
            this.dtrDates.SuspendLayout();
            this.ucSelectRecordID_Partners.SuspendLayout();
            this.ucSelectRecordID_Owners.SuspendLayout();
            this.tсPages.SuspendLayout();
            this.tabDrivers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrips)).BeginInit();
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
            this.pnlTerms.Controls.Add(this.ucSelectRecordID_DepartmentNames);
            this.pnlTerms.Controls.Add(this.rfmLabel2);
            this.pnlTerms.Controls.Add(this.ucSelectRecordID_ManagerNames);
            this.pnlTerms.Controls.Add(this.rfmLabel1);
            this.pnlTerms.Controls.Add(this.lblGroupBy);
            this.pnlTerms.Controls.Add(this.pnlGroupBy);
            this.pnlTerms.Controls.Add(this.lblOwners);
            this.pnlTerms.Controls.Add(this.dtrDates);
            this.pnlTerms.Controls.Add(this.lblDate);
            this.pnlTerms.Controls.Add(this.btnGo);
            this.pnlTerms.Controls.Add(this.ucSelectRecordID_Partners);
            this.pnlTerms.Controls.Add(this.lblPartners);
            this.pnlTerms.Controls.Add(this.ucSelectRecordID_Owners);
            this.pnlTerms.Location = new System.Drawing.Point(1, 1);
            this.pnlTerms.Name = "pnlTerms";
            this.pnlTerms.Size = new System.Drawing.Size(732, 85);
            this.pnlTerms.TabIndex = 15;
            // 
            // ucSelectRecordID_DepartmentNames
            // 
            // 
            // ucSelectRecordID_DepartmentNames.btnClear
            // 
            this.ucSelectRecordID_DepartmentNames.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_DepartmentNames.btnClear.Image")));
            this.ucSelectRecordID_DepartmentNames.BtnClear.Location = new System.Drawing.Point(248, 0);
            this.ucSelectRecordID_DepartmentNames.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_DepartmentNames.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_DepartmentNames.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_DepartmentNames.BtnClear, "Очистка выбора отделов");
            this.ucSelectRecordID_DepartmentNames.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_DepartmentNames.btnSelect
            // 
            this.ucSelectRecordID_DepartmentNames.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_DepartmentNames.btnSelect.Image")));
            this.ucSelectRecordID_DepartmentNames.BtnSelect.Location = new System.Drawing.Point(222, 0);
            this.ucSelectRecordID_DepartmentNames.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_DepartmentNames.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_DepartmentNames.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_DepartmentNames.BtnSelect, "Выбор отделов");
            this.ucSelectRecordID_DepartmentNames.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_DepartmentNames.ExpSort = "DepartmentName";
            this.ucSelectRecordID_DepartmentNames.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_DepartmentNames.IsActualOnly = true;
            this.ucSelectRecordID_DepartmentNames.IsSaveMark = true;
            this.ucSelectRecordID_DepartmentNames.IsUseMark = true;
            this.ucSelectRecordID_DepartmentNames.Location = new System.Drawing.Point(422, 56);
            this.ucSelectRecordID_DepartmentNames.Name = "ucSelectRecordID_DepartmentNames";
            this.ucSelectRecordID_DepartmentNames.Size = new System.Drawing.Size(275, 25);
            this.ucSelectRecordID_DepartmentNames.TabIndex = 33;
            this.ucSelectRecordID_DepartmentNames.TableColumnName = "DepartmentName";
            // 
            // ucSelectRecordID_DepartmentNames.txtData
            // 
            this.ucSelectRecordID_DepartmentNames.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_DepartmentNames.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_DepartmentNames.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_DepartmentNames.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_DepartmentNames.TxtData.Location = new System.Drawing.Point(0, 1);
            this.ucSelectRecordID_DepartmentNames.TxtData.MaxLength = 128;
            this.ucSelectRecordID_DepartmentNames.TxtData.Name = "txtData";
            this.ucSelectRecordID_DepartmentNames.TxtData.ReadOnly = true;
            this.ucSelectRecordID_DepartmentNames.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_DepartmentNames.TxtData.TabIndex = 0;
            this.ucSelectRecordID_DepartmentNames.СolumnsData.AddRange(new string[] {
            "DepartmentName, Отдел"});
            // 
            // rfmLabel2
            // 
            this.rfmLabel2.AutoSize = true;
            this.rfmLabel2.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.rfmLabel2.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.rfmLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rfmLabel2.Location = new System.Drawing.Point(355, 62);
            this.rfmLabel2.Name = "rfmLabel2";
            this.rfmLabel2.Size = new System.Drawing.Size(43, 14);
            this.rfmLabel2.TabIndex = 32;
            this.rfmLabel2.Text = "Отдел";
            // 
            // ucSelectRecordID_ManagerNames
            // 
            // 
            // ucSelectRecordID_ManagerNames.btnClear
            // 
            this.ucSelectRecordID_ManagerNames.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_ManagerNames.btnClear.Image")));
            this.ucSelectRecordID_ManagerNames.BtnClear.Location = new System.Drawing.Point(248, 0);
            this.ucSelectRecordID_ManagerNames.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_ManagerNames.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_ManagerNames.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_ManagerNames.BtnClear, "Очистка выбора менеджеров");
            this.ucSelectRecordID_ManagerNames.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_ManagerNames.btnSelect
            // 
            this.ucSelectRecordID_ManagerNames.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_ManagerNames.btnSelect.Image")));
            this.ucSelectRecordID_ManagerNames.BtnSelect.Location = new System.Drawing.Point(222, 0);
            this.ucSelectRecordID_ManagerNames.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_ManagerNames.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_ManagerNames.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_ManagerNames.BtnSelect, "Выбор менеджеров");
            this.ucSelectRecordID_ManagerNames.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_ManagerNames.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_ManagerNames.IsActualOnly = true;
            this.ucSelectRecordID_ManagerNames.IsSaveMark = true;
            this.ucSelectRecordID_ManagerNames.IsUseMark = true;
            this.ucSelectRecordID_ManagerNames.Location = new System.Drawing.Point(422, 30);
            this.ucSelectRecordID_ManagerNames.Name = "ucSelectRecordID_ManagerNames";
            this.ucSelectRecordID_ManagerNames.Size = new System.Drawing.Size(275, 25);
            this.ucSelectRecordID_ManagerNames.TabIndex = 31;
            this.ucSelectRecordID_ManagerNames.TableColumnName = "ManagerName";
            // 
            // ucSelectRecordID_ManagerNames.txtData
            // 
            this.ucSelectRecordID_ManagerNames.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_ManagerNames.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_ManagerNames.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_ManagerNames.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_ManagerNames.TxtData.Location = new System.Drawing.Point(0, 1);
            this.ucSelectRecordID_ManagerNames.TxtData.MaxLength = 128;
            this.ucSelectRecordID_ManagerNames.TxtData.Name = "txtData";
            this.ucSelectRecordID_ManagerNames.TxtData.ReadOnly = true;
            this.ucSelectRecordID_ManagerNames.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_ManagerNames.TxtData.TabIndex = 0;
            this.ucSelectRecordID_ManagerNames.СolumnsData.AddRange(new string[] {
            "ManagerName, ФИО менеджера"});
            // 
            // rfmLabel1
            // 
            this.rfmLabel1.AutoSize = true;
            this.rfmLabel1.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.rfmLabel1.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.rfmLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rfmLabel1.Location = new System.Drawing.Point(355, 35);
            this.rfmLabel1.Name = "rfmLabel1";
            this.rfmLabel1.Size = new System.Drawing.Size(68, 14);
            this.rfmLabel1.TabIndex = 30;
            this.rfmLabel1.Text = "Менеджер";
            // 
            // lblGroupBy
            // 
            this.lblGroupBy.AutoSize = true;
            this.lblGroupBy.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblGroupBy.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblGroupBy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblGroupBy.Location = new System.Drawing.Point(299, 8);
            this.lblGroupBy.Name = "lblGroupBy";
            this.lblGroupBy.Size = new System.Drawing.Size(83, 14);
            this.lblGroupBy.TabIndex = 28;
            this.lblGroupBy.Text = "Группировка:";
            // 
            // pnlGroupBy
            // 
            this.pnlGroupBy.Controls.Add(this.optGroupByD);
            this.pnlGroupBy.Controls.Add(this.optGroupByM);
            this.pnlGroupBy.Controls.Add(this.optGroupByP);
            this.pnlGroupBy.Controls.Add(this.optGroupByO);
            this.pnlGroupBy.Location = new System.Drawing.Point(382, 2);
            this.pnlGroupBy.Name = "pnlGroupBy";
            this.pnlGroupBy.Size = new System.Drawing.Size(310, 25);
            this.pnlGroupBy.TabIndex = 29;
            // 
            // optGroupByD
            // 
            this.optGroupByD.AutoSize = true;
            this.optGroupByD.IsChanged = true;
            this.optGroupByD.Location = new System.Drawing.Point(249, 4);
            this.optGroupByD.Name = "optGroupByD";
            this.optGroupByD.Size = new System.Drawing.Size(59, 18);
            this.optGroupByD.TabIndex = 4;
            this.optGroupByD.Text = "отдел";
            this.optGroupByD.UseVisualStyleBackColor = true;
            // 
            // optGroupByM
            // 
            this.optGroupByM.AutoSize = true;
            this.optGroupByM.IsChanged = true;
            this.optGroupByM.Location = new System.Drawing.Point(159, 4);
            this.optGroupByM.Name = "optGroupByM";
            this.optGroupByM.Size = new System.Drawing.Size(85, 18);
            this.optGroupByM.TabIndex = 1;
            this.optGroupByM.Text = "менеджер";
            this.optGroupByM.UseVisualStyleBackColor = true;
            // 
            // optGroupByP
            // 
            this.optGroupByP.AutoSize = true;
            this.optGroupByP.Location = new System.Drawing.Point(89, 4);
            this.optGroupByP.Name = "optGroupByP";
            this.optGroupByP.Size = new System.Drawing.Size(65, 18);
            this.optGroupByP.TabIndex = 3;
            this.optGroupByP.Text = "клиент";
            this.optGroupByP.UseVisualStyleBackColor = true;
            // 
            // optGroupByO
            // 
            this.optGroupByO.AutoSize = true;
            this.optGroupByO.Checked = true;
            this.optGroupByO.IsChanged = true;
            this.optGroupByO.Location = new System.Drawing.Point(5, 4);
            this.optGroupByO.Name = "optGroupByO";
            this.optGroupByO.Size = new System.Drawing.Size(79, 18);
            this.optGroupByO.TabIndex = 0;
            this.optGroupByO.TabStop = true;
            this.optGroupByO.Text = "документ";
            this.optGroupByO.UseVisualStyleBackColor = true;
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOwners.Location = new System.Drawing.Point(3, 35);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(62, 14);
            this.lblOwners.TabIndex = 21;
            this.lblOwners.Text = "Владелец";
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
            this.dtrDates.Location = new System.Drawing.Point(66, 0);
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
            this.lblDate.Location = new System.Drawing.Point(3, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(50, 14);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "Период";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Image = global::Logistics.Properties.Resources.Go;
            this.btnGo.Location = new System.Drawing.Point(698, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(28, 28);
            this.btnGo.TabIndex = 18;
            this.ttToolTip.SetToolTip(this.btnGo, "Получить отчет");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // ucSelectRecordID_Partners
            // 
            // 
            // ucSelectRecordID_Partners.btnClear
            // 
            this.ucSelectRecordID_Partners.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Partners.btnClear.Image")));
            this.ucSelectRecordID_Partners.BtnClear.Location = new System.Drawing.Point(248, 0);
            this.ucSelectRecordID_Partners.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_Partners.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Partners.BtnClear.TabIndex = 2;
            this.ucSelectRecordID_Partners.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_Partners.btnSelect
            // 
            this.ucSelectRecordID_Partners.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Partners.btnSelect.Image")));
            this.ucSelectRecordID_Partners.BtnSelect.Location = new System.Drawing.Point(222, 0);
            this.ucSelectRecordID_Partners.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_Partners.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Partners.BtnSelect.TabIndex = 1;
            this.ucSelectRecordID_Partners.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_Partners.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_Partners.IsActualOnly = true;
            this.ucSelectRecordID_Partners.IsSaveMark = true;
            this.ucSelectRecordID_Partners.IsUseMark = true;
            this.ucSelectRecordID_Partners.Location = new System.Drawing.Point(65, 56);
            this.ucSelectRecordID_Partners.Name = "ucSelectRecordID_Partners";
            this.ucSelectRecordID_Partners.Size = new System.Drawing.Size(275, 25);
            this.ucSelectRecordID_Partners.TabIndex = 26;
            this.ucSelectRecordID_Partners.TableColumnName = "Name";
            // 
            // ucSelectRecordID_Partners.txtData
            // 
            this.ucSelectRecordID_Partners.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_Partners.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_Partners.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_Partners.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_Partners.TxtData.Location = new System.Drawing.Point(0, 1);
            this.ucSelectRecordID_Partners.TxtData.MaxLength = 128;
            this.ucSelectRecordID_Partners.TxtData.Name = "txtData";
            this.ucSelectRecordID_Partners.TxtData.ReadOnly = true;
            this.ucSelectRecordID_Partners.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_Partners.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Partners.СolumnsData.AddRange(new string[] {
            "Name, Владелец",
            "Actual, Акт."});
            // 
            // lblPartners
            // 
            this.lblPartners.AutoSize = true;
            this.lblPartners.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartners.Location = new System.Drawing.Point(3, 62);
            this.lblPartners.Name = "lblPartners";
            this.lblPartners.Size = new System.Drawing.Size(48, 14);
            this.lblPartners.TabIndex = 25;
            this.lblPartners.Text = "Клиент";
            // 
            // ucSelectRecordID_Owners
            // 
            // 
            // ucSelectRecordID_Owners.btnClear
            // 
            this.ucSelectRecordID_Owners.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Owners.btnClear.Image")));
            this.ucSelectRecordID_Owners.BtnClear.Location = new System.Drawing.Point(248, 0);
            this.ucSelectRecordID_Owners.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_Owners.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Owners.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Owners.BtnClear, "Очистка выбора владельцев");
            this.ucSelectRecordID_Owners.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_Owners.btnSelect
            // 
            this.ucSelectRecordID_Owners.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Owners.btnSelect.Image")));
            this.ucSelectRecordID_Owners.BtnSelect.Location = new System.Drawing.Point(222, 0);
            this.ucSelectRecordID_Owners.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_Owners.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Owners.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Owners.BtnSelect, "Выбор владельцев");
            this.ucSelectRecordID_Owners.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_Owners.ExpSort = "Name";
            this.ucSelectRecordID_Owners.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_Owners.IsActualOnly = true;
            this.ucSelectRecordID_Owners.IsSaveMark = true;
            this.ucSelectRecordID_Owners.IsUseMark = true;
            this.ucSelectRecordID_Owners.Location = new System.Drawing.Point(65, 30);
            this.ucSelectRecordID_Owners.Name = "ucSelectRecordID_Owners";
            this.ucSelectRecordID_Owners.Size = new System.Drawing.Size(275, 25);
            this.ucSelectRecordID_Owners.TabIndex = 24;
            this.ucSelectRecordID_Owners.TableColumnName = "Name";
            // 
            // ucSelectRecordID_Owners.txtData
            // 
            this.ucSelectRecordID_Owners.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_Owners.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_Owners.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_Owners.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_Owners.TxtData.Location = new System.Drawing.Point(0, 1);
            this.ucSelectRecordID_Owners.TxtData.MaxLength = 128;
            this.ucSelectRecordID_Owners.TxtData.Name = "txtData";
            this.ucSelectRecordID_Owners.TxtData.ReadOnly = true;
            this.ucSelectRecordID_Owners.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_Owners.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Owners.СolumnsData.AddRange(new string[] {
            "Name, Владелец",
            "SeparatePicking, Учет?",
            "Actual, Акт."});
            // 
            // tсPages
            // 
            this.tсPages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tсPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tсPages.Controls.Add(this.tabDrivers);
            this.tсPages.Location = new System.Drawing.Point(2, 89);
            this.tсPages.Name = "tсPages";
            this.tсPages.SelectedIndex = 0;
            this.tсPages.Size = new System.Drawing.Size(732, 335);
            this.tсPages.TabIndex = 18;
            // 
            // tabDrivers
            // 
            this.tabDrivers.Controls.Add(this.grdTrips);
            this.tabDrivers.Location = new System.Drawing.Point(4, 4);
            this.tabDrivers.Name = "tabDrivers";
            this.tabDrivers.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrivers.Size = new System.Drawing.Size(724, 308);
            this.tabDrivers.TabIndex = 0;
            this.tabDrivers.Text = "Данные";
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
            this.grdTrips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.grcTrips_DateOutput,
            this.grcTrips_PartnerName,
            this.grcTrips_ManagerName,
            this.grcTrips_DepartmentName,
            this.grcTrips_Netto,
            this.grcTrips_Distance,
            this.grcTrips_TripAmount,
            this.grcTrips_BillNumber});
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
            this.grdTrips.Location = new System.Drawing.Point(0, 0);
            this.grdTrips.MultiSelect = false;
            this.grdTrips.Name = "grdTrips";
            this.grdTrips.RangedWay = ' ';
            this.grdTrips.ReadOnly = true;
            this.grdTrips.RowHeadersWidth = 24;
            this.grdTrips.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTrips.Size = new System.Drawing.Size(723, 305);
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
            // grcTrips_DateOutput
            // 
            this.grcTrips_DateOutput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_DateOutput.DataPropertyName = "DateOutput";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.grcTrips_DateOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcTrips_DateOutput.HeaderText = "Дата";
            this.grcTrips_DateOutput.Name = "grcTrips_DateOutput";
            this.grcTrips_DateOutput.ReadOnly = true;
            this.grcTrips_DateOutput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_DateOutput.Width = 75;
            // 
            // grcTrips_PartnerName
            // 
            this.grcTrips_PartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_PartnerName.DataPropertyName = "PartnerName";
            this.grcTrips_PartnerName.HeaderText = "Клиент";
            this.grcTrips_PartnerName.Name = "grcTrips_PartnerName";
            this.grcTrips_PartnerName.ReadOnly = true;
            this.grcTrips_PartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_PartnerName.Width = 200;
            // 
            // grcTrips_ManagerName
            // 
            this.grcTrips_ManagerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_ManagerName.DataPropertyName = "ManagerName";
            this.grcTrips_ManagerName.HeaderText = "Менеджер";
            this.grcTrips_ManagerName.Name = "grcTrips_ManagerName";
            this.grcTrips_ManagerName.ReadOnly = true;
            this.grcTrips_ManagerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcTrips_DepartmentName
            // 
            this.grcTrips_DepartmentName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_DepartmentName.DataPropertyName = "DepartmentName";
            this.grcTrips_DepartmentName.HeaderText = "Отдел";
            this.grcTrips_DepartmentName.Name = "grcTrips_DepartmentName";
            this.grcTrips_DepartmentName.ReadOnly = true;
            this.grcTrips_DepartmentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcTrips_Netto
            // 
            this.grcTrips_Netto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_Netto.DataPropertyName = "Netto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.grcTrips_Netto.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcTrips_Netto.HeaderText = "Нетто";
            this.grcTrips_Netto.Name = "grcTrips_Netto";
            this.grcTrips_Netto.ReadOnly = true;
            this.grcTrips_Netto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_Netto.ToolTipText = "Нетто заказов, кг";
            this.grcTrips_Netto.Width = 80;
            // 
            // grcTrips_Distance
            // 
            this.grcTrips_Distance.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_Distance.DataPropertyName = "Distance";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.grcTrips_Distance.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcTrips_Distance.HeaderText = "Расстояние";
            this.grcTrips_Distance.Name = "grcTrips_Distance";
            this.grcTrips_Distance.ReadOnly = true;
            this.grcTrips_Distance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_Distance.ToolTipText = "Расстояние, км";
            this.grcTrips_Distance.Width = 80;
            // 
            // grcTrips_TripAmount
            // 
            this.grcTrips_TripAmount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_TripAmount.DataPropertyName = "TripAmount";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.grcTrips_TripAmount.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcTrips_TripAmount.HeaderText = "Себестоимость";
            this.grcTrips_TripAmount.Name = "grcTrips_TripAmount";
            this.grcTrips_TripAmount.ReadOnly = true;
            this.grcTrips_TripAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_TripAmount.ToolTipText = "Себестоимость рейса, руб.";
            // 
            // grcTrips_BillNumber
            // 
            this.grcTrips_BillNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_BillNumber.DataPropertyName = "BillNumber";
            this.grcTrips_BillNumber.HeaderText = "Накладная";
            this.grcTrips_BillNumber.Name = "grcTrips_BillNumber";
            this.grcTrips_BillNumber.ReadOnly = true;
            this.grcTrips_BillNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_BillNumber.Width = 80;
            // 
            // frmReportTripsCosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.MinimizeBox = false;
            this.Name = "frmReportTripsCosts";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Себестоимость транспорта";
            this.Load += new System.EventHandler(this.frmReportTripsCosts_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlTerms.ResumeLayout(false);
            this.pnlTerms.PerformLayout();
            this.ucSelectRecordID_DepartmentNames.ResumeLayout(false);
            this.ucSelectRecordID_DepartmentNames.PerformLayout();
            this.ucSelectRecordID_ManagerNames.ResumeLayout(false);
            this.ucSelectRecordID_ManagerNames.PerformLayout();
            this.pnlGroupBy.ResumeLayout(false);
            this.pnlGroupBy.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.ucSelectRecordID_Partners.ResumeLayout(false);
            this.ucSelectRecordID_Partners.PerformLayout();
            this.ucSelectRecordID_Owners.ResumeLayout(false);
            this.ucSelectRecordID_Owners.PerformLayout();
            this.tсPages.ResumeLayout(false);
            this.tabDrivers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTrips)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMTabControl tсPages;
		private RFMBaseClasses.RFMTabPage tabDrivers;
		private RFMBaseClasses.RFMPanel pnlTerms;
		private RFMBaseClasses.RFMLabel lblOwners;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMButton btnGo;
		private RFMBaseClasses.RFMDataGridView grdTrips;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Owners;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Partners;
		private RFMBaseClasses.RFMLabel lblPartners;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_ManagerNames;
		private RFMBaseClasses.RFMLabel rfmLabel1;
		private RFMBaseClasses.RFMLabel lblGroupBy;
		private RFMBaseClasses.RFMPanel pnlGroupBy;
		private RFMBaseClasses.RFMRadioButton optGroupByD;
		private RFMBaseClasses.RFMRadioButton optGroupByM;
		private RFMBaseClasses.RFMRadioButton optGroupByP;
		private RFMBaseClasses.RFMRadioButton optGroupByO;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_DepartmentNames;
        private RFMBaseClasses.RFMLabel rfmLabel2;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DateOutput;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_PartnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_ManagerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DepartmentName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_Netto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_Distance;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_TripAmount;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_BillNumber;

	}
}

