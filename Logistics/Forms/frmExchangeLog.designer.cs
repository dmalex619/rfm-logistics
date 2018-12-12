namespace Logistics 
{
	partial class frmExchangeLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcList = new RFMBaseClasses.RFMTabControl();
            this.tabTerms = new RFMBaseClasses.RFMTabPage();
            this.cntTerms = new RFMBaseClasses.RFMPanel();
            this.lblMode = new RFMBaseClasses.RFMLabel();
            this.pnlMode = new RFMBaseClasses.RFMPanel();
            this.optModeAll = new RFMBaseClasses.RFMRadioButton();
            this.optModeD = new RFMBaseClasses.RFMRadioButton();
            this.optModeC = new RFMBaseClasses.RFMRadioButton();
            this.chkErrorOnly = new RFMBaseClasses.RFMCheckBox();
            this.lblHoursEnd = new RFMBaseClasses.RFMLabel();
            this.spnHours = new RFMBaseClasses.RFMNumericUpDown();
            this.btnClearTerms = new RFMBaseClasses.RFMButton();
            this.lblHours = new RFMBaseClasses.RFMLabel();
            this.tabData = new RFMBaseClasses.RFMTabPage();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcErrorHappened = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcDateExchange = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcHostName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcModeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTableDescription = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcRecCount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcErrorSource = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcErrorNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcErrorText = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnService = new RFMBaseClasses.RFMButton();
            this.mnuExchangeLogService = new RFMBaseClasses.RFMContextMenuStrip();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnCancel = new RFMBaseClasses.RFMButton();
            this.lblHosts = new RFMBaseClasses.RFMLabel();
            this.ucSelectRecordID_Hosts = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.tcList.SuspendLayout();
            this.tabTerms.SuspendLayout();
            this.cntTerms.SuspendLayout();
            this.pnlMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnHours)).BeginInit();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.ucSelectRecordID_Hosts.SuspendLayout();
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
            this.cntTerms.Controls.Add(this.lblHosts);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_Hosts);
            this.cntTerms.Controls.Add(this.lblMode);
            this.cntTerms.Controls.Add(this.pnlMode);
            this.cntTerms.Controls.Add(this.chkErrorOnly);
            this.cntTerms.Controls.Add(this.lblHoursEnd);
            this.cntTerms.Controls.Add(this.spnHours);
            this.cntTerms.Controls.Add(this.btnClearTerms);
            this.cntTerms.Controls.Add(this.lblHours);
            this.cntTerms.Location = new System.Drawing.Point(0, 2);
            this.cntTerms.Name = "cntTerms";
            this.cntTerms.Size = new System.Drawing.Size(732, 400);
            this.cntTerms.TabIndex = 0;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblMode.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMode.Location = new System.Drawing.Point(5, 85);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(96, 14);
            this.lblMode.TabIndex = 18;
            this.lblMode.Text = "Режим обмена:";
            this.ttToolTip.SetToolTip(this.lblMode, "Поставка/отгрузка товара");
            // 
            // pnlMode
            // 
            this.pnlMode.Controls.Add(this.optModeAll);
            this.pnlMode.Controls.Add(this.optModeD);
            this.pnlMode.Controls.Add(this.optModeC);
            this.pnlMode.Location = new System.Drawing.Point(8, 100);
            this.pnlMode.Name = "pnlMode";
            this.pnlMode.Size = new System.Drawing.Size(280, 25);
            this.pnlMode.TabIndex = 19;
            // 
            // optModeAll
            // 
            this.optModeAll.AutoSize = true;
            this.optModeAll.IsChanged = true;
            this.optModeAll.Location = new System.Drawing.Point(4, 4);
            this.optModeAll.Name = "optModeAll";
            this.optModeAll.Size = new System.Drawing.Size(44, 18);
            this.optModeAll.TabIndex = 0;
            this.optModeAll.Text = "все";
            this.optModeAll.UseVisualStyleBackColor = true;
            // 
            // optModeD
            // 
            this.optModeD.AutoSize = true;
            this.optModeD.Checked = true;
            this.optModeD.IsChanged = true;
            this.optModeD.Location = new System.Drawing.Point(184, 4);
            this.optModeD.Name = "optModeD";
            this.optModeD.Size = new System.Drawing.Size(87, 18);
            this.optModeD.TabIndex = 2;
            this.optModeD.TabStop = true;
            this.optModeD.Text = "документы";
            this.optModeD.UseVisualStyleBackColor = true;
            // 
            // optModeC
            // 
            this.optModeC.AutoSize = true;
            this.optModeC.IsChanged = true;
            this.optModeC.Location = new System.Drawing.Point(74, 4);
            this.optModeC.Name = "optModeC";
            this.optModeC.Size = new System.Drawing.Size(98, 18);
            this.optModeC.TabIndex = 1;
            this.optModeC.Text = "справочники";
            this.optModeC.UseVisualStyleBackColor = true;
            // 
            // chkErrorOnly
            // 
            this.chkErrorOnly.AutoSize = true;
            this.chkErrorOnly.Location = new System.Drawing.Point(8, 45);
            this.chkErrorOnly.Name = "chkErrorOnly";
            this.chkErrorOnly.Size = new System.Drawing.Size(237, 18);
            this.chkErrorOnly.TabIndex = 17;
            this.chkErrorOnly.Text = "Показать только обмены с ошибками";
            this.chkErrorOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkErrorOnly.UseVisualStyleBackColor = false;
            // 
            // lblHoursEnd
            // 
            this.lblHoursEnd.AutoSize = true;
            this.lblHoursEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblHoursEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHoursEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHoursEnd.Location = new System.Drawing.Point(250, 10);
            this.lblHoursEnd.Name = "lblHoursEnd";
            this.lblHoursEnd.Size = new System.Drawing.Size(30, 14);
            this.lblHoursEnd.TabIndex = 16;
            this.lblHoursEnd.Text = "час.";
            // 
            // spnHours
            // 
            this.spnHours.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.spnHours.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.spnHours.IsNull = false;
            this.spnHours.Location = new System.Drawing.Point(195, 8);
            this.spnHours.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.spnHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spnHours.Name = "spnHours";
            this.spnHours.Size = new System.Drawing.Size(50, 22);
            this.spnHours.TabIndex = 15;
            this.spnHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.spnHours.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
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
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblHours.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHours.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHours.Location = new System.Drawing.Point(5, 10);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(185, 14);
            this.lblHours.TabIndex = 0;
            this.lblHours.Text = "Показать журнал за последние";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.grdData);
            this.tabData.Location = new System.Drawing.Point(4, 23);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(733, 403);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Журнал";
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
            this.grcErrorHappened,
            this.grcDateExchange,
            this.grcHostName,
            this.grcModeName,
            this.grcTableDescription,
            this.grcRecCount,
            this.grcErrorSource,
            this.grcErrorNumber,
            this.grcErrorText,
            this.grcID});
            this.grdData.IsConfigInclude = true;
            this.grdData.IsMarkedAll = false;
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
            this.grdData.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdData.Size = new System.Drawing.Size(732, 400);
            this.grdData.TabIndex = 12;
            this.grdData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdData_CurrentRowChanged);
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
            // 
            // grcErrorHappened
            // 
            this.grcErrorHappened.DataPropertyName = "ErrorHappened";
            this.grcErrorHappened.HeaderText = "Ош.";
            this.grcErrorHappened.Name = "grcErrorHappened";
            this.grcErrorHappened.ReadOnly = true;
            this.grcErrorHappened.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcErrorHappened.Width = 40;
            // 
            // grcDateExchange
            // 
            this.grcDateExchange.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateExchange.DataPropertyName = "DateExchange";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            this.grcDateExchange.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcDateExchange.HeaderText = "Дата-время";
            this.grcDateExchange.Name = "grcDateExchange";
            this.grcDateExchange.ReadOnly = true;
            this.grcDateExchange.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateExchange.ToolTipText = "Дата-время обмена";
            this.grcDateExchange.Width = 130;
            // 
            // grcHostName
            // 
            this.grcHostName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcHostName.DataPropertyName = "HostName";
            this.grcHostName.HeaderText = "Хост";
            this.grcHostName.Name = "grcHostName";
            this.grcHostName.ReadOnly = true;
            this.grcHostName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcHostName.Width = 120;
            // 
            // grcModeName
            // 
            this.grcModeName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcModeName.DataPropertyName = "ModeName";
            this.grcModeName.HeaderText = "Режим";
            this.grcModeName.Name = "grcModeName";
            this.grcModeName.ReadOnly = true;
            this.grcModeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcTableDescription
            // 
            this.grcTableDescription.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTableDescription.DataPropertyName = "TableDescription";
            dataGridViewCellStyle3.Format = "N0";
            this.grcTableDescription.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcTableDescription.HeaderText = "Таблица";
            this.grcTableDescription.Name = "grcTableDescription";
            this.grcTableDescription.ReadOnly = true;
            this.grcTableDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTableDescription.ToolTipText = "Таблица (описание)";
            this.grcTableDescription.Width = 250;
            // 
            // grcRecCount
            // 
            this.grcRecCount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcRecCount.DataPropertyName = "RecCount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcRecCount.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcRecCount.HeaderText = "№ зап.";
            this.grcRecCount.Name = "grcRecCount";
            this.grcRecCount.ReadOnly = true;
            this.grcRecCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcRecCount.ToolTipText = "Количество обработанных записей";
            this.grcRecCount.Width = 60;
            // 
            // grcErrorSource
            // 
            this.grcErrorSource.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcErrorSource.DataPropertyName = "ErrorSource";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcErrorSource.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcErrorSource.HeaderText = "Ист.";
            this.grcErrorSource.Name = "grcErrorSource";
            this.grcErrorSource.ReadOnly = true;
            this.grcErrorSource.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcErrorSource.ToolTipText = "Источник ошибки";
            this.grcErrorSource.Width = 60;
            // 
            // grcErrorNumber
            // 
            this.grcErrorNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcErrorNumber.DataPropertyName = "ErrorNumber";
            this.grcErrorNumber.HeaderText = "№ ош.";
            this.grcErrorNumber.Name = "grcErrorNumber";
            this.grcErrorNumber.ReadOnly = true;
            this.grcErrorNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcErrorNumber.ToolTipText = "№ ошибки";
            this.grcErrorNumber.Visible = false;
            this.grcErrorNumber.Width = 60;
            // 
            // grcErrorText
            // 
            this.grcErrorText.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcErrorText.DataPropertyName = "ErrorText";
            this.grcErrorText.HeaderText = "Описание ошибки";
            this.grcErrorText.Name = "grcErrorText";
            this.grcErrorText.ReadOnly = true;
            this.grcErrorText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcErrorText.Width = 250;
            // 
            // grcID
            // 
            this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcID.DataPropertyName = "ID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcID.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.btnService.ContextMenuStrip = this.mnuExchangeLogService;
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
            // mnuExchangeLogService
            // 
            this.mnuExchangeLogService.Name = "mnuFacturesService";
            this.mnuExchangeLogService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuExchangeLogService.Size = new System.Drawing.Size(61, 4);
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
            // lblHosts
            // 
            this.lblHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHosts.AutoSize = true;
            this.lblHosts.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblHosts.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHosts.Location = new System.Drawing.Point(470, 352);
            this.lblHosts.Name = "lblHosts";
            this.lblHosts.Size = new System.Drawing.Size(41, 14);
            this.lblHosts.TabIndex = 20;
            this.lblHosts.Text = "Хосты";
            // 
            // ucSelectRecordID_Hosts
            // 
            this.ucSelectRecordID_Hosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // ucSelectRecordID_Hosts.btnClear
            // 
            this.ucSelectRecordID_Hosts.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Hosts.BtnClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.ucSelectRecordID_Hosts.BtnClear.Location = new System.Drawing.Point(202, 0);
            this.ucSelectRecordID_Hosts.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_Hosts.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Hosts.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Hosts.BtnClear, "Очистка выбора хостов");
            this.ucSelectRecordID_Hosts.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_Hosts.btnSelect
            // 
            this.ucSelectRecordID_Hosts.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Hosts.BtnSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.ucSelectRecordID_Hosts.BtnSelect.Location = new System.Drawing.Point(176, 0);
            this.ucSelectRecordID_Hosts.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_Hosts.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Hosts.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Hosts.BtnSelect, "Выбор хостов");
            this.ucSelectRecordID_Hosts.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_Hosts.ExpSort = "Name";
            this.ucSelectRecordID_Hosts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_Hosts.IsActualOnly = true;
            this.ucSelectRecordID_Hosts.IsSaveMark = true;
            this.ucSelectRecordID_Hosts.IsUseMark = true;
            this.ucSelectRecordID_Hosts.Location = new System.Drawing.Point(470, 367);
            this.ucSelectRecordID_Hosts.MarkedCount = 0;
            this.ucSelectRecordID_Hosts.Name = "ucSelectRecordID_Hosts";
            this.ucSelectRecordID_Hosts.Size = new System.Drawing.Size(229, 24);
            this.ucSelectRecordID_Hosts.TabIndex = 21;
            this.ucSelectRecordID_Hosts.TableColumnName = "Name";
            // 
            // ucSelectRecordID_Hosts.txtData
            // 
            this.ucSelectRecordID_Hosts.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Hosts.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_Hosts.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_Hosts.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_Hosts.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_Hosts.TxtData.Location = new System.Drawing.Point(0, 1);
            this.ucSelectRecordID_Hosts.TxtData.MaxLength = 128;
            this.ucSelectRecordID_Hosts.TxtData.Name = "txtData";
            this.ucSelectRecordID_Hosts.TxtData.ReadOnly = true;
            this.ucSelectRecordID_Hosts.TxtData.Size = new System.Drawing.Size(174, 22);
            this.ucSelectRecordID_Hosts.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Hosts.СolumnsData.AddRange(new string[] {
            "Name, Хост"});
            // 
            // frmExchangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 474);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tcList);
            this.hpHelp.SetHelpKeyword(this, "102");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.hpHelp.SetHelpString(this, "");
            this.IsAccessOn = true;
            this.IsWaitLoading = true;
            this.LastGrid = this.grdData;
            this.MinimumSize = new System.Drawing.Size(750, 501);
            this.Name = "frmExchangeLog";
            this.hpHelp.SetShowHelp(this, true);
            this.Text = "Журнал обмена";
            this.Load += new System.EventHandler(this.frmExchangeLog_Load);
            this.tcList.ResumeLayout(false);
            this.tabTerms.ResumeLayout(false);
            this.cntTerms.ResumeLayout(false);
            this.cntTerms.PerformLayout();
            this.pnlMode.ResumeLayout(false);
            this.pnlMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnHours)).EndInit();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ucSelectRecordID_Hosts.ResumeLayout(false);
            this.ucSelectRecordID_Hosts.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnCancel;
        private RFMBaseClasses.RFMTabPage tabData;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMButton btnPrint;
        private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
        private RFMBaseClasses.RFMLabel lblHours;
        private RFMBaseClasses.RFMDataGridView grdData;
        public RFMBaseClasses.RFMContextMenuStrip mnuExchangeLogService;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcErrorHappened;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateExchange;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcHostName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcModeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTableDescription;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcRecCount;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcErrorSource;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcErrorNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcErrorText;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
        private RFMBaseClasses.RFMNumericUpDown spnHours;
        private RFMBaseClasses.RFMCheckBox chkErrorOnly;
        private RFMBaseClasses.RFMLabel lblHoursEnd;
        private RFMBaseClasses.RFMLabel lblMode;
        private RFMBaseClasses.RFMPanel pnlMode;
        private RFMBaseClasses.RFMRadioButton optModeAll;
        private RFMBaseClasses.RFMRadioButton optModeD;
        private RFMBaseClasses.RFMRadioButton optModeC;
        private RFMBaseClasses.RFMLabel lblHosts;
        private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Hosts;
	}
}