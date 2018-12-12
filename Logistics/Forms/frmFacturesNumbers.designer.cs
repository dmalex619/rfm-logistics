namespace Logistics 
{
	partial class frmFacturesNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturesNumbers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcList = new RFMBaseClasses.RFMTabControl();
            this.tabTerms = new RFMBaseClasses.RFMTabPage();
            this.cntTerms = new RFMBaseClasses.RFMPanel();
            this.lblFactureNumberContext = new RFMBaseClasses.RFMLabel();
            this.txtFactureNumberContext = new RFMBaseClasses.RFMTextBox();
            this.pnlPartnersSource = new RFMBaseClasses.RFMPanel();
            this.txtPartnersSourceChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnPartnersSourceClear = new RFMBaseClasses.RFMButton();
            this.btnPartnersSourceChoose = new RFMBaseClasses.RFMButton();
            this.lblPartnersSource = new RFMBaseClasses.RFMLabel();
            this.pnlPartnersTarget = new RFMBaseClasses.RFMPanel();
            this.txtPartnersTargetChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnPartnersTargetClear = new RFMBaseClasses.RFMButton();
            this.btnPartnersTargetChoose = new RFMBaseClasses.RFMButton();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.btnClearTerms = new RFMBaseClasses.RFMButton();
            this.lblDates = new RFMBaseClasses.RFMLabel();
            this.lblPartnersTarget = new RFMBaseClasses.RFMLabel();
            this.tabData = new RFMBaseClasses.RFMTabPage();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateIssue = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerSourceName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerTargetName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOrderID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateInput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNumberInt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnService = new RFMBaseClasses.RFMButton();
            this.mnuFacturesService = new RFMBaseClasses.RFMContextMenuStrip();
            this.mniFacturesAnalysis = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.btnCancel = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnConfirm = new RFMBaseClasses.RFMButton();
            this.tcList.SuspendLayout();
            this.tabTerms.SuspendLayout();
            this.cntTerms.SuspendLayout();
            this.pnlPartnersSource.SuspendLayout();
            this.pnlPartnersTarget.SuspendLayout();
            this.dtrDates.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.mnuFacturesService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcList
            // 
            this.tcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcList.Controls.Add(this.tabTerms);
            this.tcList.Controls.Add(this.tabData);
            this.tcList.Location = new System.Drawing.Point(1, 1);
            this.tcList.Name = "tcList";
            this.tcList.SelectedIndex = 0;
            this.tcList.Size = new System.Drawing.Size(741, 430);
            this.tcList.TabIndex = 0;
            this.tcList.SelectedIndexChanged += new System.EventHandler(this.tcList_SelectedIndexChanged);
            // 
            // tabTerms
            // 
            this.tabTerms.Controls.Add(this.cntTerms);
            this.tabTerms.IsFilterPage = true;
            this.tabTerms.Location = new System.Drawing.Point(4, 23);
            this.tabTerms.Name = "tabTerms";
            this.tabTerms.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerms.Size = new System.Drawing.Size(733, 403);
            this.tabTerms.TabIndex = 0;
            this.tabTerms.Text = "Условия";
            this.tabTerms.UseVisualStyleBackColor = true;
            // 
            // cntTerms
            // 
            this.cntTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cntTerms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cntTerms.Controls.Add(this.lblFactureNumberContext);
            this.cntTerms.Controls.Add(this.txtFactureNumberContext);
            this.cntTerms.Controls.Add(this.pnlPartnersSource);
            this.cntTerms.Controls.Add(this.lblPartnersSource);
            this.cntTerms.Controls.Add(this.pnlPartnersTarget);
            this.cntTerms.Controls.Add(this.dtrDates);
            this.cntTerms.Controls.Add(this.btnClearTerms);
            this.cntTerms.Controls.Add(this.lblDates);
            this.cntTerms.Controls.Add(this.lblPartnersTarget);
            this.cntTerms.Location = new System.Drawing.Point(0, 2);
            this.cntTerms.Name = "cntTerms";
            this.cntTerms.Size = new System.Drawing.Size(732, 400);
            this.cntTerms.TabIndex = 0;
            // 
            // lblFactureNumberContext
            // 
            this.lblFactureNumberContext.AutoSize = true;
            this.lblFactureNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFactureNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFactureNumberContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFactureNumberContext.Location = new System.Drawing.Point(7, 43);
            this.lblFactureNumberContext.Name = "lblFactureNumberContext";
            this.lblFactureNumberContext.Size = new System.Drawing.Size(175, 14);
            this.lblFactureNumberContext.TabIndex = 1;
            this.lblFactureNumberContext.Text = "№ счета-фактуры (контекст)";
            // 
            // txtFactureNumberContext
            // 
            this.txtFactureNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtFactureNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFactureNumberContext.Location = new System.Drawing.Point(191, 39);
            this.txtFactureNumberContext.Name = "txtFactureNumberContext";
            this.txtFactureNumberContext.OldValue = "";
            this.txtFactureNumberContext.Size = new System.Drawing.Size(218, 22);
            this.txtFactureNumberContext.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.txtFactureNumberContext, "Контекст названия клиента-поставщика");
            // 
            // pnlPartnersSource
            // 
            this.pnlPartnersSource.Controls.Add(this.txtPartnersSourceChoosen);
            this.pnlPartnersSource.Controls.Add(this.btnPartnersSourceClear);
            this.pnlPartnersSource.Controls.Add(this.btnPartnersSourceChoose);
            this.pnlPartnersSource.Location = new System.Drawing.Point(190, 68);
            this.pnlPartnersSource.Name = "pnlPartnersSource";
            this.pnlPartnersSource.Size = new System.Drawing.Size(278, 30);
            this.pnlPartnersSource.TabIndex = 6;
            // 
            // txtPartnersSourceChoosen
            // 
            this.txtPartnersSourceChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPartnersSourceChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartnersSourceChoosen.Enabled = false;
            this.txtPartnersSourceChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtPartnersSourceChoosen.Name = "txtPartnersSourceChoosen";
            this.txtPartnersSourceChoosen.OldValue = "";
            this.txtPartnersSourceChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtPartnersSourceChoosen.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.txtPartnersSourceChoosen, "Организации, выдавшие счет-фактура");
            // 
            // btnPartnersSourceClear
            // 
            this.btnPartnersSourceClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnPartnersSourceClear.Location = new System.Drawing.Point(249, 3);
            this.btnPartnersSourceClear.Name = "btnPartnersSourceClear";
            this.btnPartnersSourceClear.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersSourceClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnPartnersSourceClear, "Очистить выбор организации");
            this.btnPartnersSourceClear.UseVisualStyleBackColor = true;
            this.btnPartnersSourceClear.Click += new System.EventHandler(this.btnPartnersSourceClear_Click);
            // 
            // btnPartnersSourceChoose
            // 
            this.btnPartnersSourceChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnPartnersSourceChoose.Location = new System.Drawing.Point(221, 3);
            this.btnPartnersSourceChoose.Name = "btnPartnersSourceChoose";
            this.btnPartnersSourceChoose.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersSourceChoose.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnPartnersSourceChoose, "Выбор организации");
            this.btnPartnersSourceChoose.UseVisualStyleBackColor = true;
            this.btnPartnersSourceChoose.Click += new System.EventHandler(this.btnPartnersSourceChoose_Click);
            // 
            // lblPartnersSource
            // 
            this.lblPartnersSource.AutoSize = true;
            this.lblPartnersSource.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartnersSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartnersSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartnersSource.Location = new System.Drawing.Point(7, 76);
            this.lblPartnersSource.Name = "lblPartnersSource";
            this.lblPartnersSource.Size = new System.Drawing.Size(67, 14);
            this.lblPartnersSource.TabIndex = 5;
            this.lblPartnersSource.Text = "Кем выдан";
            // 
            // pnlPartnersTarget
            // 
            this.pnlPartnersTarget.Controls.Add(this.txtPartnersTargetChoosen);
            this.pnlPartnersTarget.Controls.Add(this.btnPartnersTargetClear);
            this.pnlPartnersTarget.Controls.Add(this.btnPartnersTargetChoose);
            this.pnlPartnersTarget.Location = new System.Drawing.Point(190, 101);
            this.pnlPartnersTarget.Name = "pnlPartnersTarget";
            this.pnlPartnersTarget.Size = new System.Drawing.Size(278, 30);
            this.pnlPartnersTarget.TabIndex = 8;
            // 
            // txtPartnersTargetChoosen
            // 
            this.txtPartnersTargetChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPartnersTargetChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartnersTargetChoosen.Enabled = false;
            this.txtPartnersTargetChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtPartnersTargetChoosen.Name = "txtPartnersTargetChoosen";
            this.txtPartnersTargetChoosen.OldValue = "";
            this.txtPartnersTargetChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtPartnersTargetChoosen.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.txtPartnersTargetChoosen, "Плательщики/поставщики");
            // 
            // btnPartnersTargetClear
            // 
            this.btnPartnersTargetClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnPartnersTargetClear.Location = new System.Drawing.Point(249, 3);
            this.btnPartnersTargetClear.Name = "btnPartnersTargetClear";
            this.btnPartnersTargetClear.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersTargetClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnPartnersTargetClear, "Очистить выбор плательщиков/поставщиков");
            this.btnPartnersTargetClear.UseVisualStyleBackColor = true;
            this.btnPartnersTargetClear.Click += new System.EventHandler(this.btnPartnersTargetClear_Click);
            // 
            // btnPartnersTargetChoose
            // 
            this.btnPartnersTargetChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnPartnersTargetChoose.Location = new System.Drawing.Point(221, 3);
            this.btnPartnersTargetChoose.Name = "btnPartnersTargetChoose";
            this.btnPartnersTargetChoose.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersTargetChoose.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnPartnersTargetChoose, "Выбор плательщиков/поставщиков");
            this.btnPartnersTargetChoose.UseVisualStyleBackColor = true;
            this.btnPartnersTargetChoose.Click += new System.EventHandler(this.btnPartnersTargetChoose_Click);
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
            this.dtrDates.Location = new System.Drawing.Point(191, 4);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(222, 29);
            this.dtrDates.TabIndex = 0;
            // 
            // btnClearTerms
            // 
            this.btnClearTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTerms.FlatAppearance.BorderSize = 0;
            this.btnClearTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTerms.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClearTerms.Location = new System.Drawing.Point(704, 372);
            this.btnClearTerms.Name = "btnClearTerms";
            this.btnClearTerms.Size = new System.Drawing.Size(22, 22);
            this.btnClearTerms.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
            this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDates.Location = new System.Drawing.Point(7, 11);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(78, 14);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Дата выдачи";
            // 
            // lblPartnersTarget
            // 
            this.lblPartnersTarget.AutoSize = true;
            this.lblPartnersTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartnersTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartnersTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartnersTarget.Location = new System.Drawing.Point(7, 109);
            this.lblPartnersTarget.Name = "lblPartnersTarget";
            this.lblPartnersTarget.Size = new System.Drawing.Size(135, 14);
            this.lblPartnersTarget.TabIndex = 7;
            this.lblPartnersTarget.Text = "Клиенты-плательщики";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.grdData);
            this.tabData.Location = new System.Drawing.Point(4, 23);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(733, 403);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Счета-фактуры";
            this.tabData.UseVisualStyleBackColor = true;
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
            this.grcNumber,
            this.grcDateIssue,
            this.grcPartnerSourceName,
            this.grcPartnerTargetName,
            this.grcOrderID,
            this.grcDateInput,
            this.grcNumberInt,
            this.grcERPCode,
            this.grcID});
            this.grdData.IsCheckerInclude = true;
            this.grdData.IsConfigInclude = true;
            this.grdData.IsMarkedAll = false;
            this.grdData.IsStatusInclude = true;
            this.grdData.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdData.Location = new System.Drawing.Point(0, 2);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.Size = new System.Drawing.Size(732, 400);
            this.grdData.TabIndex = 12;
            this.grdData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdData_CurrentRowChanged);
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
            // 
            // grcNumber
            // 
            this.grcNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNumber.DataPropertyName = "Number";
            this.grcNumber.HeaderText = "№";
            this.grcNumber.Name = "grcNumber";
            this.grcNumber.ReadOnly = true;
            this.grcNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNumber.ToolTipText = "Номер счета-фактуры";
            this.grcNumber.Width = 80;
            // 
            // grcDateIssue
            // 
            this.grcDateIssue.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateIssue.DataPropertyName = "DateIssue";
            this.grcDateIssue.HeaderText = "Дата";
            this.grcDateIssue.Name = "grcDateIssue";
            this.grcDateIssue.ReadOnly = true;
            this.grcDateIssue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateIssue.ToolTipText = "Дата выдачи счета-фактуры";
            this.grcDateIssue.Width = 80;
            // 
            // grcPartnerSourceName
            // 
            this.grcPartnerSourceName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerSourceName.DataPropertyName = "PartnerSourceName";
            this.grcPartnerSourceName.HeaderText = "Кем выдан";
            this.grcPartnerSourceName.Name = "grcPartnerSourceName";
            this.grcPartnerSourceName.ReadOnly = true;
            this.grcPartnerSourceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerSourceName.ToolTipText = "Партнер, выдавший счет-фактуру";
            this.grcPartnerSourceName.Width = 120;
            // 
            // grcPartnerTargetName
            // 
            this.grcPartnerTargetName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerTargetName.DataPropertyName = "PartnerTargetName";
            this.grcPartnerTargetName.HeaderText = "Клиент-плательщик";
            this.grcPartnerTargetName.Name = "grcPartnerTargetName";
            this.grcPartnerTargetName.ReadOnly = true;
            this.grcPartnerTargetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerTargetName.Width = 200;
            // 
            // grcOrderID
            // 
            this.grcOrderID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOrderID.DataPropertyName = "OrderID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.grcOrderID.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcOrderID.HeaderText = "Заказ отгр.";
            this.grcOrderID.Name = "grcOrderID";
            this.grcOrderID.ReadOnly = true;
            this.grcOrderID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOrderID.ToolTipText = "Код заказа на отгрузку товара";
            this.grcOrderID.Width = 80;
            // 
            // grcDateInput
            // 
            this.grcDateInput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateInput.DataPropertyName = "DateInput";
            this.grcDateInput.HeaderText = "Создано";
            this.grcDateInput.Name = "grcDateInput";
            this.grcDateInput.ReadOnly = true;
            this.grcDateInput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateInput.ToolTipText = "Дата-время оформления счета-фактуры ";
            this.grcDateInput.Width = 110;
            // 
            // grcNumberInt
            // 
            this.grcNumberInt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNumberInt.DataPropertyName = "NumberInt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcNumberInt.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcNumberInt.HeaderText = "№-цифр.";
            this.grcNumberInt.Name = "grcNumberInt";
            this.grcNumberInt.ReadOnly = true;
            this.grcNumberInt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNumberInt.ToolTipText = "Цифровая часть номера";
            this.grcNumberInt.Width = 60;
            // 
            // grcERPCode
            // 
            this.grcERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcERPCode.DataPropertyName = "ERPCode";
            this.grcERPCode.HeaderText = "ERPCode";
            this.grcERPCode.Name = "grcERPCode";
            this.grcERPCode.ReadOnly = true;
            this.grcERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcERPCode.ToolTipText = "Код в host-системе";
            this.grcERPCode.Visible = false;
            // 
            // grcID
            // 
            this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcID.DataPropertyName = "ID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcID.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcID.HeaderText = "ID";
            this.grcID.Name = "grcID";
            this.grcID.ReadOnly = true;
            this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcID.ToolTipText = "Код записи счета-фактуры";
            this.grcID.Width = 50;
            // 
            // btnService
            // 
            this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnService.ContextMenuStrip = this.mnuFacturesService;
            this.btnService.Enabled = false;
            this.btnService.Image = global::Logistics.Properties.Resources.Service;
            this.btnService.IsAccessOn = true;
            this.btnService.Location = new System.Drawing.Point(655, 439);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(30, 30);
            this.btnService.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnService, "Сервис");
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // mnuFacturesService
            // 
            this.mnuFacturesService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFacturesAnalysis});
            this.mnuFacturesService.Name = "mnuFacturesService";
            this.mnuFacturesService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuFacturesService.Size = new System.Drawing.Size(159, 26);
            // 
            // mniFacturesAnalysis
            // 
            this.mniFacturesAnalysis.Name = "mniFacturesAnalysis";
            this.mniFacturesAnalysis.Size = new System.Drawing.Size(158, 22);
            this.mniFacturesAnalysis.Text = "Анализ списка";
            this.mniFacturesAnalysis.Click += new System.EventHandler(this.mniFacturesAnalysis_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(605, 439);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 30);
            this.btnPrint.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 439);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 30);
            this.btnHelp.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnHelp, "Помощь");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.IsAccessOn = true;
            this.btnDelete.Location = new System.Drawing.Point(555, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удаление");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.IsAccessOn = true;
            this.btnAdd.Location = new System.Drawing.Point(405, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавление");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::Logistics.Properties.Resources.Exit;
            this.btnCancel.Location = new System.Drawing.Point(705, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnCancel, "Выход");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.IsAccessOn = true;
            this.btnEdit.Location = new System.Drawing.Point(455, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Image = global::Logistics.Properties.Resources.Go;
            this.btnConfirm.IsAccessOn = true;
            this.btnConfirm.Location = new System.Drawing.Point(505, 439);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(30, 30);
            this.btnConfirm.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnConfirm, "Подтверждение");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmFacturesNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 474);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tcList);
            this.hpHelp.SetHelpKeyword(this, "102");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.hpHelp.SetHelpString(this, "");
            this.IsAccessOn = true;
            this.IsWaitLoading = true;
            this.LastGrid = this.grdData;
            this.MinimumSize = new System.Drawing.Size(750, 501);
            this.Name = "frmFacturesNumbers";
            this.hpHelp.SetShowHelp(this, true);
            this.Text = "Журнал выдачи счетов-фактур";
            this.Load += new System.EventHandler(this.frmFacturesNumbers_Load);
            this.tcList.ResumeLayout(false);
            this.tabTerms.ResumeLayout(false);
            this.cntTerms.ResumeLayout(false);
            this.cntTerms.PerformLayout();
            this.pnlPartnersSource.ResumeLayout(false);
            this.pnlPartnersSource.PerformLayout();
            this.pnlPartnersTarget.ResumeLayout(false);
            this.pnlPartnersTarget.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.mnuFacturesService.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnCancel;
		private RFMBaseClasses.RFMTabPage tabData;
        private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMButton btnConfirm;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblDates;
		private RFMBaseClasses.RFMLabel lblPartnersTarget;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMPanel pnlPartnersTarget;
		private RFMBaseClasses.RFMButton btnPartnersTargetClear;
		private RFMBaseClasses.RFMButton btnPartnersTargetChoose;
		private RFMBaseClasses.RFMTextBox txtPartnersTargetChoosen;
		private RFMBaseClasses.RFMPanel pnlPartnersSource;
		private RFMBaseClasses.RFMTextBox txtPartnersSourceChoosen;
		private RFMBaseClasses.RFMButton btnPartnersSourceClear;
		private RFMBaseClasses.RFMButton btnPartnersSourceChoose;
		private RFMBaseClasses.RFMLabel lblPartnersSource;
		private RFMBaseClasses.RFMLabel lblFactureNumberContext;
		private RFMBaseClasses.RFMTextBox txtFactureNumberContext;
        private RFMBaseClasses.RFMDataGridView grdData;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateIssue;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerSourceName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerTargetName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOrderID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateInput;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNumberInt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniFacturesAnalysis;
		public RFMBaseClasses.RFMContextMenuStrip mnuFacturesService;
	}
}