namespace Logistics
{
	partial class frmTripsReturnsEdit
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvTripReturnGoods = new RFMBaseClasses.RFMDataGridView();
			this.dgvcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcInBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcBoxWished = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcQntWished = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlSelectConditions = new RFMBaseClasses.RFMPanel();
			this.chkAutocreate = new RFMBaseClasses.RFMCheckBox();
			this.cboGoodsState = new RFMBaseClasses.RFMComboBox();
			this.cboOwner = new RFMBaseClasses.RFMComboBox();
			this.chkReadyForWMS = new RFMBaseClasses.RFMCheckBox();
			this.lblDateTripReturn = new RFMBaseClasses.RFMLabel();
			this.lblGoodsStates = new RFMBaseClasses.RFMLabel();
			this.lblOwners = new RFMBaseClasses.RFMLabel();
			this.dtpDateTripReturn = new RFMBaseClasses.RFMDateTimePicker();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblTotal = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox_ = new RFMBaseClasses.RFMLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvTripReturnGoods)).BeginInit();
			this.pnlSelectConditions.SuspendLayout();
			this.pnlTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTripReturnGoods
			// 
			this.dgvTripReturnGoods.AllowUserToAddRows = false;
			this.dgvTripReturnGoods.AllowUserToDeleteRows = false;
			this.dgvTripReturnGoods.AllowUserToOrderColumns = true;
			this.dgvTripReturnGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTripReturnGoods.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvTripReturnGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvTripReturnGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvTripReturnGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTripReturnGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcGoodAlias,
            this.dgvcInBox,
            this.dgvcBoxWished,
            this.dgvcQntWished,
            this.dgvcWeighting,
            this.dgvcGoodBarCode,
            this.dgvcGoodGroupName,
            this.dgvcGoodBrandName,
            this.dgvcID});
			this.dgvTripReturnGoods.IsConfigInclude = true;
			this.dgvTripReturnGoods.IsMarkedAll = false;
			this.dgvTripReturnGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvTripReturnGoods.Location = new System.Drawing.Point(3, 110);
			this.dgvTripReturnGoods.MultiSelect = false;
			this.dgvTripReturnGoods.Name = "dgvTripReturnGoods";
			this.dgvTripReturnGoods.RangedWay = ' ';
			this.dgvTripReturnGoods.RowHeadersWidth = 24;
			this.dgvTripReturnGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvTripReturnGoods.Size = new System.Drawing.Size(736, 324);
			this.dgvTripReturnGoods.TabIndex = 0;
			this.dgvTripReturnGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTripRetunGoods_CellBeginEdit);
			this.dgvTripReturnGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTripRetunGoods_CellFormatting);
			this.dgvTripReturnGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTripRetunGoods_CellEndEdit);
			this.dgvTripReturnGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTripRetunGoods_CellValueChanged);
			this.dgvTripReturnGoods.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTripReturnGoods_CellEnter);
			// 
			// dgvcGoodAlias
			// 
			this.dgvcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodAlias.DataPropertyName = "GoodAlias";
			this.dgvcGoodAlias.HeaderText = "Товар";
			this.dgvcGoodAlias.Name = "dgvcGoodAlias";
			this.dgvcGoodAlias.ReadOnly = true;
			this.dgvcGoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodAlias.Width = 270;
			// 
			// dgvcInBox
			// 
			this.dgvcInBox.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcInBox.DataPropertyName = "InBox";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			this.dgvcInBox.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvcInBox.HeaderText = "В кор.";
			this.dgvcInBox.Name = "dgvcInBox";
			this.dgvcInBox.ReadOnly = true;
			this.dgvcInBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcInBox.ToolTipText = "Штук/кг в коробке";
			this.dgvcInBox.Width = 60;
			// 
			// dgvcBoxWished
			// 
			this.dgvcBoxWished.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcBoxWished.DataPropertyName = "BoxWished";
			this.dgvcBoxWished.DecimalPlaces = 1;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N1";
			this.dgvcBoxWished.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvcBoxWished.HeaderText = "Коробок";
			this.dgvcBoxWished.Name = "dgvcBoxWished";
			this.dgvcBoxWished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcBoxWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcBoxWished.ToolTipText = "Коробок";
			this.dgvcBoxWished.Width = 80;
			// 
			// dgvcQntWished
			// 
			this.dgvcQntWished.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcQntWished.DataPropertyName = "QntWished";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			this.dgvcQntWished.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvcQntWished.HeaderText = "Штук";
			this.dgvcQntWished.Name = "dgvcQntWished";
			this.dgvcQntWished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcQntWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcQntWished.ToolTipText = "Штук";
			this.dgvcQntWished.Width = 90;
			// 
			// dgvcWeighting
			// 
			this.dgvcWeighting.DataPropertyName = "Weighting";
			this.dgvcWeighting.HeaderText = "Вес?";
			this.dgvcWeighting.Name = "dgvcWeighting";
			this.dgvcWeighting.ReadOnly = true;
			this.dgvcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcWeighting.ToolTipText = "Весовой товар?";
			this.dgvcWeighting.Visible = false;
			this.dgvcWeighting.Width = 40;
			// 
			// dgvcGoodBarCode
			// 
			this.dgvcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBarCode.DataPropertyName = "GoodBarCode";
			this.dgvcGoodBarCode.HeaderText = "ШК товара";
			this.dgvcGoodBarCode.Name = "dgvcGoodBarCode";
			this.dgvcGoodBarCode.ReadOnly = true;
			this.dgvcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBarCode.ToolTipText = "Штрих-код товара";
			this.dgvcGoodBarCode.Visible = false;
			this.dgvcGoodBarCode.Width = 130;
			// 
			// dgvcGoodGroupName
			// 
			this.dgvcGoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodGroupName.DataPropertyName = "GoodGroupName";
			this.dgvcGoodGroupName.HeaderText = "Товарная группа";
			this.dgvcGoodGroupName.Name = "dgvcGoodGroupName";
			this.dgvcGoodGroupName.ReadOnly = true;
			this.dgvcGoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodGroupName.Width = 200;
			// 
			// dgvcGoodBrandName
			// 
			this.dgvcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBrandName.DataPropertyName = "GoodBrandName";
			this.dgvcGoodBrandName.HeaderText = "Товарный бренд";
			this.dgvcGoodBrandName.Name = "dgvcGoodBrandName";
			this.dgvcGoodBrandName.ReadOnly = true;
			this.dgvcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBrandName.Width = 200;
			// 
			// dgvcID
			// 
			this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcID.DataPropertyName = "ID";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcID.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvcID.HeaderText = "ID";
			this.dgvcID.Name = "dgvcID";
			this.dgvcID.ReadOnly = true;
			this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcID.Width = 60;
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(5, 439);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(32, 30);
			this.btnHelp.TabIndex = 5;
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
			this.btnExit.Location = new System.Drawing.Point(705, 439);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 30);
			this.btnExit.TabIndex = 4;
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Image = global::Logistics.Properties.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(655, 439);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 30);
			this.btnSave.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlSelectConditions
			// 
			this.pnlSelectConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectConditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlSelectConditions.Controls.Add(this.chkAutocreate);
			this.pnlSelectConditions.Controls.Add(this.cboGoodsState);
			this.pnlSelectConditions.Controls.Add(this.cboOwner);
			this.pnlSelectConditions.Controls.Add(this.chkReadyForWMS);
			this.pnlSelectConditions.Controls.Add(this.lblDateTripReturn);
			this.pnlSelectConditions.Controls.Add(this.lblGoodsStates);
			this.pnlSelectConditions.Controls.Add(this.lblOwners);
			this.pnlSelectConditions.Controls.Add(this.dtpDateTripReturn);
			this.pnlSelectConditions.Controls.Add(this.lblNote);
			this.pnlSelectConditions.Controls.Add(this.txtNote);
			this.pnlSelectConditions.Location = new System.Drawing.Point(3, 3);
			this.pnlSelectConditions.Name = "pnlSelectConditions";
			this.pnlSelectConditions.Size = new System.Drawing.Size(736, 104);
			this.pnlSelectConditions.TabIndex = 1;
			// 
			// chkAutocreate
			// 
			this.chkAutocreate.AutoSize = true;
			this.chkAutocreate.Enabled = false;
			this.chkAutocreate.Location = new System.Drawing.Point(431, 29);
			this.chkAutocreate.Name = "chkAutocreate";
			this.chkAutocreate.Size = new System.Drawing.Size(201, 18);
			this.chkAutocreate.TabIndex = 39;
			this.chkAutocreate.Text = "Возврат создан автоматически";
			this.chkAutocreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkAutocreate.UseVisualStyleBackColor = true;
			// 
			// cboGoodsState
			// 
			this.cboGoodsState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboGoodsState.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboGoodsState.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboGoodsState.FormattingEnabled = true;
			this.cboGoodsState.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboGoodsState.Location = new System.Drawing.Point(113, 51);
			this.cboGoodsState.Name = "cboGoodsState";
			this.cboGoodsState.Size = new System.Drawing.Size(242, 22);
			this.cboGoodsState.TabIndex = 38;
			// 
			// cboOwner
			// 
			this.cboOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboOwner.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboOwner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboOwner.FormattingEnabled = true;
			this.cboOwner.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboOwner.Location = new System.Drawing.Point(113, 27);
			this.cboOwner.Name = "cboOwner";
			this.cboOwner.Size = new System.Drawing.Size(242, 22);
			this.cboOwner.TabIndex = 37;
			// 
			// chkReadyForWMS
			// 
			this.chkReadyForWMS.AutoSize = true;
			this.chkReadyForWMS.Location = new System.Drawing.Point(431, 53);
			this.chkReadyForWMS.Name = "chkReadyForWMS";
			this.chkReadyForWMS.Size = new System.Drawing.Size(297, 18);
			this.chkReadyForWMS.TabIndex = 35;
			this.chkReadyForWMS.Text = "Возврат готов к передаче в складскую систему";
			this.chkReadyForWMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkReadyForWMS.UseVisualStyleBackColor = true;
			// 
			// lblDateTripReturn
			// 
			this.lblDateTripReturn.AutoSize = true;
			this.lblDateTripReturn.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateTripReturn.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateTripReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateTripReturn.Location = new System.Drawing.Point(4, 7);
			this.lblDateTripReturn.Name = "lblDateTripReturn";
			this.lblDateTripReturn.Size = new System.Drawing.Size(86, 14);
			this.lblDateTripReturn.TabIndex = 29;
			this.lblDateTripReturn.Text = "Дата возврата";
			// 
			// lblGoodsStates
			// 
			this.lblGoodsStates.AutoSize = true;
			this.lblGoodsStates.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodsStates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodsStates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodsStates.Location = new System.Drawing.Point(4, 55);
			this.lblGoodsStates.Name = "lblGoodsStates";
			this.lblGoodsStates.Size = new System.Drawing.Size(110, 14);
			this.lblGoodsStates.TabIndex = 26;
			this.lblGoodsStates.Text = "Состояние товара";
			// 
			// lblOwners
			// 
			this.lblOwners.AutoSize = true;
			this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwners.Location = new System.Drawing.Point(4, 31);
			this.lblOwners.Name = "lblOwners";
			this.lblOwners.Size = new System.Drawing.Size(62, 14);
			this.lblOwners.TabIndex = 25;
			this.lblOwners.Text = "Владелец";
			// 
			// dtpDateTripReturn
			// 
			this.dtpDateTripReturn.CustomFormat = "dd.MM.yyyy";
			this.dtpDateTripReturn.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateTripReturn.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateTripReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTripReturn.Location = new System.Drawing.Point(113, 3);
			this.dtpDateTripReturn.Name = "dtpDateTripReturn";
			this.dtpDateTripReturn.Size = new System.Drawing.Size(92, 22);
			this.dtpDateTripReturn.TabIndex = 4;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(4, 79);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 2;
			this.lblNote.Text = "Примечание";
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(113, 75);
			this.txtNote.MaxLength = 500;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(615, 22);
			this.txtNote.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.txtNote, "Примечание по заказу");
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
			this.btnAdd.Location = new System.Drawing.Point(55, 439);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(32, 30);
			this.btnAdd.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnAdd, "Новый товар");
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlTotal
			// 
			this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotal.Controls.Add(this.lblTotal);
			this.pnlTotal.Controls.Add(this.lblTotalQnt);
			this.pnlTotal.Controls.Add(this.lblTotalQnt_);
			this.pnlTotal.Controls.Add(this.lblTotalBox);
			this.pnlTotal.Controls.Add(this.lblTotalBox_);
			this.pnlTotal.Location = new System.Drawing.Point(211, 442);
			this.pnlTotal.Name = "pnlTotal";
			this.pnlTotal.Size = new System.Drawing.Size(311, 26);
			this.pnlTotal.TabIndex = 11;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotal.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotal.Location = new System.Drawing.Point(2, 5);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(44, 14);
			this.lblTotal.TabIndex = 6;
			this.lblTotal.Text = "Итого:";
			// 
			// lblTotalQnt
			// 
			this.lblTotalQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalQnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalQnt.Location = new System.Drawing.Point(215, 5);
			this.lblTotalQnt.Name = "lblTotalQnt";
			this.lblTotalQnt.Size = new System.Drawing.Size(89, 14);
			this.lblTotalQnt.TabIndex = 5;
			this.lblTotalQnt.Text = "#TotalQnt#";
			// 
			// lblTotalQnt_
			// 
			this.lblTotalQnt_.AutoSize = true;
			this.lblTotalQnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalQnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalQnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalQnt_.Location = new System.Drawing.Point(177, 5);
			this.lblTotalQnt_.Name = "lblTotalQnt_";
			this.lblTotalQnt_.Size = new System.Drawing.Size(33, 14);
			this.lblTotalQnt_.TabIndex = 4;
			this.lblTotalQnt_.Text = "штук";
			// 
			// lblTotalBox
			// 
			this.lblTotalBox.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalBox.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalBox.Location = new System.Drawing.Point(83, 5);
			this.lblTotalBox.Name = "lblTotalBox";
			this.lblTotalBox.Size = new System.Drawing.Size(89, 14);
			this.lblTotalBox.TabIndex = 3;
			this.lblTotalBox.Text = "#TotalBox#";
			// 
			// lblTotalBox_
			// 
			this.lblTotalBox_.AutoSize = true;
			this.lblTotalBox_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalBox_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalBox_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalBox_.Location = new System.Drawing.Point(47, 5);
			this.lblTotalBox_.Name = "lblTotalBox_";
			this.lblTotalBox_.Size = new System.Drawing.Size(31, 14);
			this.lblTotalBox_.TabIndex = 2;
			this.lblTotalBox_.Text = "кор.";
			// 
			// frmTripsReturnsEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 473);
			this.Controls.Add(this.pnlTotal);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlSelectConditions);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dgvTripReturnGoods);
			this.hpHelp.SetHelpKeyword(this, "221");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmTripsReturnsEdit";
			this.PreFormName = "frmGetHost";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Возврат";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTripsReturmsEdit_KeyDown);
			this.Load += new System.EventHandler(this.frmTripsReturnsEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTripReturnGoods)).EndInit();
			this.pnlSelectConditions.ResumeLayout(false);
			this.pnlSelectConditions.PerformLayout();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvTripReturnGoods;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlSelectConditions;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblTotal;
		private RFMBaseClasses.RFMLabel lblTotalQnt;
		private RFMBaseClasses.RFMLabel lblTotalQnt_;
		private RFMBaseClasses.RFMLabel lblTotalBox;
		private RFMBaseClasses.RFMLabel lblTotalBox_;
        private RFMBaseClasses.RFMDateTimePicker dtpDateTripReturn;
        private RFMBaseClasses.RFMLabel lblGoodsStates;
        private RFMBaseClasses.RFMLabel lblOwners;
        private RFMBaseClasses.RFMLabel lblDateTripReturn;
        private RFMBaseClasses.RFMCheckBox chkReadyForWMS;
        private RFMBaseClasses.RFMComboBox cboOwner;
		private RFMBaseClasses.RFMComboBox cboGoodsState;
		private RFMBaseClasses.RFMCheckBox chkAutocreate;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcInBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcBoxWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcQntWished;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcWeighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBarCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
	}
}

