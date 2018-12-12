namespace Logistics 
{
	partial class frmEmployeesDrivers 
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
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.cntData = new RFMBaseClasses.RFMSplitContainer();
            this.pnlActual = new RFMBaseClasses.RFMPanel();
            this.optActualAll = new RFMBaseClasses.RFMRadioButton();
            this.optActualNot = new RFMBaseClasses.RFMRadioButton();
            this.optActual = new RFMBaseClasses.RFMRadioButton();
            this.txtJobTitleContext = new RFMBaseClasses.RFMTextBox();
            this.lblJobTitleNameContext = new RFMBaseClasses.RFMLabel();
            this.btnClear = new RFMBaseClasses.RFMButton();
            this.btnFilter = new RFMBaseClasses.RFMButton();
            this.txtNameContext = new RFMBaseClasses.RFMTextBox();
            this.lblNameContext = new RFMBaseClasses.RFMLabel();
            this.chkDriversOnly = new RFMBaseClasses.RFMCheckBox();
            this.tcData = new RFMBaseClasses.RFMTabControl();
            this.tabEmployees = new RFMBaseClasses.RFMTabPage();
            this.grdEmployees = new RFMBaseClasses.RFMDataGridView();
            this.grcName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcJobTitleName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcMobPhone = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcIsDriver = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcForGoodsOnly = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcOperable = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcCarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcZoneName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcActual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tabJobTitles = new RFMBaseClasses.RFMTabPage();
            this.grdJobTitles = new RFMBaseClasses.RFMDataGridView();
            this.grcJobTitles_JobTitleName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcJobTitles_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcJobTitles_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.cntData.Panel1.SuspendLayout();
            this.cntData.Panel2.SuspendLayout();
            this.cntData.SuspendLayout();
            this.pnlActual.SuspendLayout();
            this.tcData.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.tabJobTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobTitles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 437);
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
            this.btnExit.Location = new System.Drawing.Point(705, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(655, 438);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печать беджей");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(555, 438);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 11;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(605, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 12;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удаление");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(505, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 10;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавление");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cntData
            // 
            this.cntData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cntData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cntData.Location = new System.Drawing.Point(5, 5);
            this.cntData.Name = "cntData";
            // 
            // cntData.Panel1
            // 
            this.cntData.Panel1.Controls.Add(this.pnlActual);
            this.cntData.Panel1.Controls.Add(this.txtJobTitleContext);
            this.cntData.Panel1.Controls.Add(this.lblJobTitleNameContext);
            this.cntData.Panel1.Controls.Add(this.btnClear);
            this.cntData.Panel1.Controls.Add(this.btnFilter);
            this.cntData.Panel1.Controls.Add(this.txtNameContext);
            this.cntData.Panel1.Controls.Add(this.lblNameContext);
            this.cntData.Panel1.Controls.Add(this.chkDriversOnly);
            // 
            // cntData.Panel2
            // 
            this.cntData.Panel2.Controls.Add(this.tcData);
            this.cntData.Size = new System.Drawing.Size(734, 424);
            this.cntData.SplitterDistance = 163;
            this.cntData.TabIndex = 0;
            // 
            // pnlActual
            // 
            this.pnlActual.Controls.Add(this.optActualAll);
            this.pnlActual.Controls.Add(this.optActualNot);
            this.pnlActual.Controls.Add(this.optActual);
            this.pnlActual.Location = new System.Drawing.Point(4, 50);
            this.pnlActual.Name = "pnlActual";
            this.pnlActual.Size = new System.Drawing.Size(127, 62);
            this.pnlActual.TabIndex = 2;
            // 
            // optActualAll
            // 
            this.optActualAll.AutoSize = true;
            this.optActualAll.Checked = true;
            this.optActualAll.IsChanged = true;
            this.optActualAll.Location = new System.Drawing.Point(4, 4);
            this.optActualAll.Name = "optActualAll";
            this.optActualAll.Size = new System.Drawing.Size(44, 18);
            this.optActualAll.TabIndex = 0;
            this.optActualAll.TabStop = true;
            this.optActualAll.Text = "все";
            this.optActualAll.UseVisualStyleBackColor = true;
            // 
            // optActualNot
            // 
            this.optActualNot.AutoSize = true;
            this.optActualNot.Location = new System.Drawing.Point(4, 40);
            this.optActualNot.Name = "optActualNot";
            this.optActualNot.Size = new System.Drawing.Size(104, 18);
            this.optActualNot.TabIndex = 2;
            this.optActualNot.Text = "неактуальные";
            this.optActualNot.UseVisualStyleBackColor = true;
            // 
            // optActual
            // 
            this.optActual.AutoSize = true;
            this.optActual.IsChanged = true;
            this.optActual.Location = new System.Drawing.Point(4, 22);
            this.optActual.Name = "optActual";
            this.optActual.Size = new System.Drawing.Size(90, 18);
            this.optActual.TabIndex = 1;
            this.optActual.Text = "актуальные";
            this.optActual.UseVisualStyleBackColor = true;
            // 
            // txtJobTitleContext
            // 
            this.txtJobTitleContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtJobTitleContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtJobTitleContext.Location = new System.Drawing.Point(6, 180);
            this.txtJobTitleContext.Name = "txtJobTitleContext";
            this.txtJobTitleContext.Size = new System.Drawing.Size(149, 22);
            this.txtJobTitleContext.TabIndex = 5;
            // 
            // lblJobTitleNameContext
            // 
            this.lblJobTitleNameContext.AutoSize = true;
            this.lblJobTitleNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblJobTitleNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblJobTitleNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobTitleNameContext.Location = new System.Drawing.Point(6, 162);
            this.lblJobTitleNameContext.Name = "lblJobTitleNameContext";
            this.lblJobTitleNameContext.Size = new System.Drawing.Size(136, 14);
            this.lblJobTitleNameContext.TabIndex = 4;
            this.lblJobTitleNameContext.Text = "Должность (контекст)";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClear.Location = new System.Drawing.Point(125, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(30, 30);
            this.btnClear.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnClear, "Очистить условия");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Image = global::Logistics.Properties.Resources.Go_Blue;
            this.btnFilter.Location = new System.Drawing.Point(75, 385);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(30, 30);
            this.btnFilter.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnFilter, "Показать список в соответствии с условиями");
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtNameContext
            // 
            this.txtNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNameContext.Location = new System.Drawing.Point(4, 22);
            this.txtNameContext.Name = "txtNameContext";
            this.txtNameContext.Size = new System.Drawing.Size(149, 22);
            this.txtNameContext.TabIndex = 1;
            // 
            // lblNameContext
            // 
            this.lblNameContext.AutoSize = true;
            this.lblNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameContext.Location = new System.Drawing.Point(4, 4);
            this.lblNameContext.Name = "lblNameContext";
            this.lblNameContext.Size = new System.Drawing.Size(99, 14);
            this.lblNameContext.TabIndex = 0;
            this.lblNameContext.Text = "ФИО (контекст)";
            // 
            // chkDriversOnly
            // 
            this.chkDriversOnly.AutoSize = true;
            this.chkDriversOnly.Location = new System.Drawing.Point(7, 118);
            this.chkDriversOnly.Name = "chkDriversOnly";
            this.chkDriversOnly.OldValue = false;
            this.chkDriversOnly.Size = new System.Drawing.Size(123, 18);
            this.chkDriversOnly.TabIndex = 3;
            this.chkDriversOnly.Text = "только водители";
            this.chkDriversOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDriversOnly.UseVisualStyleBackColor = true;
            // 
            // tcData
            // 
            this.tcData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcData.Controls.Add(this.tabEmployees);
            this.tcData.Controls.Add(this.tabJobTitles);
            this.tcData.Location = new System.Drawing.Point(1, 1);
            this.tcData.Name = "tcData";
            this.tcData.SelectedIndex = 0;
            this.tcData.Size = new System.Drawing.Size(562, 419);
            this.tcData.TabIndex = 3;
            this.tcData.SelectedIndexChanged += new System.EventHandler(this.tcData_SelectedIndexChanged);
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.grdEmployees);
            this.tabEmployees.Location = new System.Drawing.Point(4, 23);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployees.Size = new System.Drawing.Size(554, 392);
            this.tabEmployees.TabIndex = 0;
            this.tabEmployees.Text = "Сотрудники, водители";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // grdEmployees
            // 
            this.grdEmployees.AllowUserToAddRows = false;
            this.grdEmployees.AllowUserToDeleteRows = false;
            this.grdEmployees.AllowUserToOrderColumns = true;
            this.grdEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEmployees.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdEmployees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcName,
            this.grcAlias,
            this.grcJobTitleName,
            this.grcMobPhone,
            this.grcIsDriver,
            this.grcForGoodsOnly,
            this.grcOperable,
            this.grcCarName,
            this.grcZoneName,
            this.grcActual,
            this.grcERPCode,
            this.grcID});
            this.grdEmployees.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdEmployees.IsCheckerInclude = true;
            this.grdEmployees.IsConfigInclude = true;
            this.grdEmployees.IsMarkedAll = false;
            this.grdEmployees.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdEmployees.Location = new System.Drawing.Point(1, 2);
            this.grdEmployees.MultiSelect = false;
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.RangedWay = ' ';
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.RowHeadersWidth = 24;
            this.grdEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdEmployees.Size = new System.Drawing.Size(551, 389);
            this.grdEmployees.TabIndex = 2;
            // 
            // grcName
            // 
            this.grcName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcName.DataPropertyName = "Name";
            this.grcName.HeaderText = "ФИО";
            this.grcName.Name = "grcName";
            this.grcName.ReadOnly = true;
            this.grcName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcName.Width = 200;
            // 
            // grcAlias
            // 
            this.grcAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcAlias.DataPropertyName = "Alias";
            this.grcAlias.HeaderText = "Кратко";
            this.grcAlias.Name = "grcAlias";
            this.grcAlias.ReadOnly = true;
            this.grcAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcJobTitleName
            // 
            this.grcJobTitleName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcJobTitleName.DataPropertyName = "JobTitleName";
            this.grcJobTitleName.HeaderText = "Должность";
            this.grcJobTitleName.Name = "grcJobTitleName";
            this.grcJobTitleName.ReadOnly = true;
            this.grcJobTitleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcJobTitleName.Width = 150;
            // 
            // grcMobPhone
            // 
            this.grcMobPhone.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcMobPhone.DataPropertyName = "MobPhone";
            this.grcMobPhone.HeaderText = "Моб.телефон";
            this.grcMobPhone.Name = "grcMobPhone";
            this.grcMobPhone.ReadOnly = true;
            this.grcMobPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcIsDriver
            // 
            this.grcIsDriver.DataPropertyName = "IsDriver";
            this.grcIsDriver.HeaderText = "Вод.";
            this.grcIsDriver.Name = "grcIsDriver";
            this.grcIsDriver.ReadOnly = true;
            this.grcIsDriver.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsDriver.ToolTipText = "Водитель?";
            this.grcIsDriver.Width = 50;
            // 
            // grcForGoodsOnly
            // 
            this.grcForGoodsOnly.DataPropertyName = "ForGoodsOnly";
            this.grcForGoodsOnly.HeaderText = "Товар";
            this.grcForGoodsOnly.Name = "grcForGoodsOnly";
            this.grcForGoodsOnly.ReadOnly = true;
            this.grcForGoodsOnly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcForGoodsOnly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.grcForGoodsOnly.ToolTipText = "Доставляет товар?";
            this.grcForGoodsOnly.Width = 50;
            // 
            // grcOperable
            // 
            this.grcOperable.DataPropertyName = "Operable";
            this.grcOperable.HeaderText = "Раб.";
            this.grcOperable.Name = "grcOperable";
            this.grcOperable.ReadOnly = true;
            this.grcOperable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOperable.Width = 50;
            // 
            // grcCarName
            // 
            this.grcCarName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCarName.DataPropertyName = "CarName";
            this.grcCarName.HeaderText = "Машина";
            this.grcCarName.Name = "grcCarName";
            this.grcCarName.ReadOnly = true;
            this.grcCarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcZoneName
            // 
            this.grcZoneName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcZoneName.DataPropertyName = "ZoneName";
            this.grcZoneName.HeaderText = "Зона";
            this.grcZoneName.Name = "grcZoneName";
            this.grcZoneName.ReadOnly = true;
            this.grcZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcActual
            // 
            this.grcActual.DataPropertyName = "Actual";
            this.grcActual.HeaderText = "Акт.";
            this.grcActual.Name = "grcActual";
            this.grcActual.ReadOnly = true;
            this.grcActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcActual.ToolTipText = "Актуально?";
            this.grcActual.Width = 50;
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
            // 
            // grcID
            // 
            this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcID.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcID.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcID.HeaderText = "ID";
            this.grcID.Name = "grcID";
            this.grcID.ReadOnly = true;
            this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcID.Width = 50;
            // 
            // tabJobTitles
            // 
            this.tabJobTitles.Controls.Add(this.grdJobTitles);
            this.tabJobTitles.Location = new System.Drawing.Point(4, 23);
            this.tabJobTitles.Name = "tabJobTitles";
            this.tabJobTitles.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobTitles.Size = new System.Drawing.Size(554, 392);
            this.tabJobTitles.TabIndex = 1;
            this.tabJobTitles.Text = "Должности";
            this.tabJobTitles.UseVisualStyleBackColor = true;
            // 
            // grdJobTitles
            // 
            this.grdJobTitles.AllowUserToAddRows = false;
            this.grdJobTitles.AllowUserToDeleteRows = false;
            this.grdJobTitles.AllowUserToOrderColumns = true;
            this.grdJobTitles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdJobTitles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdJobTitles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdJobTitles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdJobTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJobTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcJobTitles_JobTitleName,
            this.grcJobTitles_ERPCode,
            this.grcJobTitles_ID});
            this.grdJobTitles.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdJobTitles.IsCheckerInclude = true;
            this.grdJobTitles.IsConfigInclude = true;
            this.grdJobTitles.IsMarkedAll = false;
            this.grdJobTitles.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdJobTitles.Location = new System.Drawing.Point(1, 2);
            this.grdJobTitles.MultiSelect = false;
            this.grdJobTitles.Name = "grdJobTitles";
            this.grdJobTitles.RangedWay = ' ';
            this.grdJobTitles.ReadOnly = true;
            this.grdJobTitles.RowHeadersWidth = 24;
            this.grdJobTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdJobTitles.Size = new System.Drawing.Size(554, 389);
            this.grdJobTitles.TabIndex = 3;
            // 
            // grcJobTitles_JobTitleName
            // 
            this.grcJobTitles_JobTitleName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcJobTitles_JobTitleName.DataPropertyName = "Name";
            this.grcJobTitles_JobTitleName.HeaderText = "Должность";
            this.grcJobTitles_JobTitleName.Name = "grcJobTitles_JobTitleName";
            this.grcJobTitles_JobTitleName.ReadOnly = true;
            this.grcJobTitles_JobTitleName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcJobTitles_JobTitleName.Width = 200;
            // 
            // grcJobTitles_ERPCode
            // 
            this.grcJobTitles_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcJobTitles_ERPCode.DataPropertyName = "ERPCode";
            this.grcJobTitles_ERPCode.HeaderText = "ERPCode";
            this.grcJobTitles_ERPCode.Name = "grcJobTitles_ERPCode";
            this.grcJobTitles_ERPCode.ReadOnly = true;
            this.grcJobTitles_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcJobTitles_ERPCode.ToolTipText = "Код в host-системе";
            // 
            // grcJobTitles_ID
            // 
            this.grcJobTitles_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcJobTitles_ID.DataPropertyName = "ID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcJobTitles_ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcJobTitles_ID.HeaderText = "ID";
            this.grcJobTitles_ID.Name = "grcJobTitles_ID";
            this.grcJobTitles_ID.ReadOnly = true;
            this.grcJobTitles_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcJobTitles_ID.Width = 50;
            // 
            // frmEmployeesDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.cntData);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.hpHelp.SetHelpKeyword(this, "802");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.LastGrid = this.grdJobTitles;
            this.Name = "frmEmployeesDrivers";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудники, водители";
            this.Load += new System.EventHandler(this.frmEmployees_Load);
            this.cntData.Panel1.ResumeLayout(false);
            this.cntData.Panel1.PerformLayout();
            this.cntData.Panel2.ResumeLayout(false);
            this.cntData.ResumeLayout(false);
            this.pnlActual.ResumeLayout(false);
            this.pnlActual.PerformLayout();
            this.tcData.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.tabJobTitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdJobTitles)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMSplitContainer cntData;
		private RFMBaseClasses.RFMDataGridView grdEmployees;
		private RFMBaseClasses.RFMTabControl tcData;
		private RFMBaseClasses.RFMTabPage tabEmployees;
		private RFMBaseClasses.RFMTabPage tabJobTitles;
		private RFMBaseClasses.RFMDataGridView grdJobTitles;
		private RFMBaseClasses.RFMTextBox txtJobTitleContext;
		private RFMBaseClasses.RFMLabel lblJobTitleNameContext;
		private RFMBaseClasses.RFMButton btnClear;
		private RFMBaseClasses.RFMButton btnFilter;
		private RFMBaseClasses.RFMTextBox txtNameContext;
		private RFMBaseClasses.RFMLabel lblNameContext;
		private RFMBaseClasses.RFMCheckBox chkDriversOnly;
		private RFMBaseClasses.RFMPanel pnlActual;
		private RFMBaseClasses.RFMRadioButton optActualAll;
		private RFMBaseClasses.RFMRadioButton optActualNot;
		private RFMBaseClasses.RFMRadioButton optActual;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcJobTitles_JobTitleName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcJobTitles_ERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcJobTitles_ID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcJobTitleName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcMobPhone;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsDriver;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcForGoodsOnly;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcOperable;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcZoneName;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcActual;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
	}
}

