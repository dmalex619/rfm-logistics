namespace Logistics
{
	partial class frmInputsEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInputsEdit));
			this.dgvInputGoods = new RFMBaseClasses.RFMDataGridView();
			this.dgvcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcInBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcBoxWished = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcQntWished = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcGoodPrice = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlSelectConditions = new RFMBaseClasses.RFMPanel();
			this.lblCurrency = new RFMBaseClasses.RFMLabel();
			this.cboCurrency = new RFMBaseClasses.RFMComboBox();
			this.ucSelectRecordIDForm_Partners = new RFMBaseClasses.RFMSelectRecordIDForm();
			this.lblPartner = new RFMBaseClasses.RFMLabel();
			this.lblInputType = new RFMBaseClasses.RFMLabel();
			this.lblDateInput = new RFMBaseClasses.RFMLabel();
			this.chkDeliveryNeed = new RFMBaseClasses.RFMCheckBox();
			this.cboInputType = new RFMBaseClasses.RFMComboBox();
			this.dtpDateInput = new RFMBaseClasses.RFMDateTimePicker();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.cboOwner = new RFMBaseClasses.RFMComboBox();
			this.lblOwner = new RFMBaseClasses.RFMLabel();
			this.cboGoodState = new RFMBaseClasses.RFMComboBox();
			this.lblGoodState = new RFMBaseClasses.RFMLabel();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblTotal = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox_ = new RFMBaseClasses.RFMLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvInputGoods)).BeginInit();
			this.pnlSelectConditions.SuspendLayout();
			this.ucSelectRecordIDForm_Partners.SuspendLayout();
			this.pnlTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvInputGoods
			// 
			this.dgvInputGoods.AllowUserToAddRows = false;
			this.dgvInputGoods.AllowUserToDeleteRows = false;
			this.dgvInputGoods.AllowUserToOrderColumns = true;
			this.dgvInputGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvInputGoods.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvInputGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvInputGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvInputGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvInputGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcGoodAlias,
            this.dgvcInBox,
            this.dgvcBoxWished,
            this.dgvcQntWished,
            this.dgvcGoodPrice,
            this.dgvcWeighting,
            this.dgvcGoodBarCode,
            this.dgvcGoodGroupName,
            this.dgvcGoodBrandName,
            this.dgvcID});
			this.dgvInputGoods.IsConfigInclude = true;
			this.dgvInputGoods.IsMarkedAll = false;
			this.dgvInputGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvInputGoods.Location = new System.Drawing.Point(3, 112);
			this.dgvInputGoods.MultiSelect = false;
			this.dgvInputGoods.Name = "dgvInputGoods";
			this.dgvInputGoods.RangedWay = ' ';
			this.dgvInputGoods.ReadOnly = true;
			this.dgvInputGoods.RowHeadersWidth = 24;
			this.dgvInputGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvInputGoods.Size = new System.Drawing.Size(736, 322);
			this.dgvInputGoods.TabIndex = 0;
			this.dgvInputGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInputGoods_CellBeginEdit);
			this.dgvInputGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInputGoods_CellFormatting);
			this.dgvInputGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputGoods_CellEndEdit);
			this.dgvInputGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputGoods_CellValueChanged);
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
			this.dgvcInBox.Width = 50;
			// 
			// dgvcBoxWished
			// 
			this.dgvcBoxWished.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcBoxWished.DataPropertyName = "BoxWished";
			this.dgvcBoxWished.DecimalPlaces = 1;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N1";
			this.dgvcBoxWished.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvcBoxWished.HeaderText = "Заказ кор.";
			this.dgvcBoxWished.Name = "dgvcBoxWished";
			this.dgvcBoxWished.ReadOnly = true;
			this.dgvcBoxWished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcBoxWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcBoxWished.ToolTipText = "Заказано коробок";
			this.dgvcBoxWished.Width = 80;
			// 
			// dgvcQntWished
			// 
			this.dgvcQntWished.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcQntWished.DataPropertyName = "QntWished";
			this.dgvcQntWished.DecimalPlaces = 3;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			this.dgvcQntWished.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvcQntWished.HeaderText = "Заказ шт.";
			this.dgvcQntWished.Name = "dgvcQntWished";
			this.dgvcQntWished.ReadOnly = true;
			this.dgvcQntWished.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcQntWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcQntWished.ToolTipText = "Заказано штук";
			this.dgvcQntWished.Width = 90;
			// 
			// dgvcGoodPrice
			// 
			this.dgvcGoodPrice.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodPrice.DataPropertyName = "Price";
			this.dgvcGoodPrice.DecimalPlaces = 2;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = null;
			this.dgvcGoodPrice.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvcGoodPrice.HeaderText = "Цена ";
			this.dgvcGoodPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.dgvcGoodPrice.Name = "dgvcGoodPrice";
			this.dgvcGoodPrice.ReadOnly = true;
			this.dgvcGoodPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcGoodPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodPrice.Width = 90;
			// 
			// dgvcWeighting
			// 
			this.dgvcWeighting.DataPropertyName = "Weighting";
			this.dgvcWeighting.HeaderText = "Вес?";
			this.dgvcWeighting.Name = "dgvcWeighting";
			this.dgvcWeighting.ReadOnly = true;
			this.dgvcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcWeighting.ToolTipText = "Весовой товар?";
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
			this.dgvcGoodGroupName.Width = 150;
			// 
			// dgvcGoodBrandName
			// 
			this.dgvcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBrandName.DataPropertyName = "GoodBrandName";
			this.dgvcGoodBrandName.HeaderText = "Товарный бренд";
			this.dgvcGoodBrandName.Name = "dgvcGoodBrandName";
			this.dgvcGoodBrandName.ReadOnly = true;
			this.dgvcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBrandName.Width = 150;
			// 
			// dgvcID
			// 
			this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcID.DataPropertyName = "InputGoodID";
			this.dgvcID.HeaderText = "ID";
			this.dgvcID.Name = "dgvcID";
			this.dgvcID.ReadOnly = true;
			this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			this.pnlSelectConditions.Controls.Add(this.lblCurrency);
			this.pnlSelectConditions.Controls.Add(this.cboCurrency);
			this.pnlSelectConditions.Controls.Add(this.ucSelectRecordIDForm_Partners);
			this.pnlSelectConditions.Controls.Add(this.lblPartner);
			this.pnlSelectConditions.Controls.Add(this.lblInputType);
			this.pnlSelectConditions.Controls.Add(this.lblDateInput);
			this.pnlSelectConditions.Controls.Add(this.chkDeliveryNeed);
			this.pnlSelectConditions.Controls.Add(this.cboInputType);
			this.pnlSelectConditions.Controls.Add(this.dtpDateInput);
			this.pnlSelectConditions.Controls.Add(this.lblNote);
			this.pnlSelectConditions.Controls.Add(this.txtNote);
			this.pnlSelectConditions.Controls.Add(this.cboOwner);
			this.pnlSelectConditions.Controls.Add(this.lblOwner);
			this.pnlSelectConditions.Controls.Add(this.cboGoodState);
			this.pnlSelectConditions.Controls.Add(this.lblGoodState);
			this.pnlSelectConditions.Location = new System.Drawing.Point(3, 3);
			this.pnlSelectConditions.Name = "pnlSelectConditions";
			this.pnlSelectConditions.Size = new System.Drawing.Size(736, 106);
			this.pnlSelectConditions.TabIndex = 0;
			// 
			// lblCurrency
			// 
			this.lblCurrency.AutoSize = true;
			this.lblCurrency.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCurrency.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurrency.Location = new System.Drawing.Point(371, 7);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(48, 14);
			this.lblCurrency.TabIndex = 3;
			this.lblCurrency.Text = "Валюта";
			// 
			// cboCurrency
			// 
			this.cboCurrency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboCurrency.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboCurrency.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboCurrency.FormattingEnabled = true;
			this.cboCurrency.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboCurrency.Location = new System.Drawing.Point(482, 3);
			this.cboCurrency.Name = "cboCurrency";
			this.cboCurrency.Size = new System.Drawing.Size(247, 22);
			this.cboCurrency.TabIndex = 4;
			// 
			// ucSelectRecordIDForm_Partners
			// 
			// 
			// ucSelectRecordIDForm_Partners.btnClear
			// 
			this.ucSelectRecordIDForm_Partners.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Partners.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Partners.btnClear.Image")));
			this.ucSelectRecordIDForm_Partners.BtnClear.Location = new System.Drawing.Point(248, 1);
			this.ucSelectRecordIDForm_Partners.BtnClear.Name = "btnClear";
			this.ucSelectRecordIDForm_Partners.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Partners.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Partners.BtnClear, "Очистка поставщика");
			this.ucSelectRecordIDForm_Partners.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordIDForm_Partners.btnSelect
			// 
			this.ucSelectRecordIDForm_Partners.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Partners.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Partners.btnSelect.Image")));
			this.ucSelectRecordIDForm_Partners.BtnSelect.Location = new System.Drawing.Point(222, 1);
			this.ucSelectRecordIDForm_Partners.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordIDForm_Partners.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Partners.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Partners.BtnSelect, "Выбор поставщика");
			this.ucSelectRecordIDForm_Partners.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordIDForm_Partners.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordIDForm_Partners.FormName = "frmSelectOnePartner";
			this.ucSelectRecordIDForm_Partners.IsSaveMark = true;
			this.ucSelectRecordIDForm_Partners.Location = new System.Drawing.Point(87, 51);
			this.ucSelectRecordIDForm_Partners.MarkedCount = 0;
			this.ucSelectRecordIDForm_Partners.Name = "ucSelectRecordIDForm_Partners";
			this.ucSelectRecordIDForm_Partners.Size = new System.Drawing.Size(276, 26);
			this.ucSelectRecordIDForm_Partners.TabIndex = 10;
			// 
			// ucSelectRecordIDForm_Partners.txtData
			// 
			this.ucSelectRecordIDForm_Partners.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Partners.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordIDForm_Partners.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordIDForm_Partners.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordIDForm_Partners.TxtData.IsUserDraw = true;
			this.ucSelectRecordIDForm_Partners.TxtData.Location = new System.Drawing.Point(0, 2);
			this.ucSelectRecordIDForm_Partners.TxtData.Name = "txtData";
			this.ucSelectRecordIDForm_Partners.TxtData.ReadOnly = true;
			this.ucSelectRecordIDForm_Partners.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordIDForm_Partners.TxtData.TabIndex = 3;
			// 
			// lblPartner
			// 
			this.lblPartner.AutoSize = true;
			this.lblPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPartner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPartner.Location = new System.Drawing.Point(2, 57);
			this.lblPartner.Name = "lblPartner";
			this.lblPartner.Size = new System.Drawing.Size(68, 14);
			this.lblPartner.TabIndex = 9;
			this.lblPartner.Text = "Поставщик";
			// 
			// lblInputType
			// 
			this.lblInputType.AutoSize = true;
			this.lblInputType.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblInputType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblInputType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInputType.Location = new System.Drawing.Point(371, 57);
			this.lblInputType.Name = "lblInputType";
			this.lblInputType.Size = new System.Drawing.Size(80, 14);
			this.lblInputType.TabIndex = 11;
			this.lblInputType.Text = "Тип прихода";
			// 
			// lblDateInput
			// 
			this.lblDateInput.AutoSize = true;
			this.lblDateInput.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateInput.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateInput.Location = new System.Drawing.Point(2, 7);
			this.lblDateInput.Name = "lblDateInput";
			this.lblDateInput.Size = new System.Drawing.Size(84, 14);
			this.lblDateInput.TabIndex = 0;
			this.lblDateInput.Text = "Дата прихода";
			// 
			// chkDeliveryNeed
			// 
			this.chkDeliveryNeed.Location = new System.Drawing.Point(226, 5);
			this.chkDeliveryNeed.Name = "chkDeliveryNeed";
			this.chkDeliveryNeed.Size = new System.Drawing.Size(113, 18);
			this.chkDeliveryNeed.TabIndex = 2;
			this.chkDeliveryNeed.Text = "наша доставка?";
			this.chkDeliveryNeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkDeliveryNeed.UseVisualStyleBackColor = true;
			// 
			// cboInputType
			// 
			this.cboInputType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboInputType.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboInputType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboInputType.FormattingEnabled = true;
			this.cboInputType.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboInputType.Location = new System.Drawing.Point(482, 53);
			this.cboInputType.Name = "cboInputType";
			this.cboInputType.Size = new System.Drawing.Size(247, 22);
			this.cboInputType.TabIndex = 12;
			// 
			// dtpDateInput
			// 
			this.dtpDateInput.CustomFormat = "dd.MM.yyyy";
			this.dtpDateInput.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateInput.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateInput.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateInput.Location = new System.Drawing.Point(87, 3);
			this.dtpDateInput.Name = "dtpDateInput";
			this.dtpDateInput.Size = new System.Drawing.Size(92, 22);
			this.dtpDateInput.TabIndex = 1;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(2, 82);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 13;
			this.lblNote.Text = "Примечание";
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(87, 78);
			this.txtNote.MaxLength = 500;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(642, 22);
			this.txtNote.TabIndex = 14;
			this.ttToolTip.SetToolTip(this.txtNote, "Примечание по заказу");
			// 
			// cboOwner
			// 
			this.cboOwner.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboOwner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboOwner.FormattingEnabled = true;
			this.cboOwner.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboOwner.Location = new System.Drawing.Point(87, 28);
			this.cboOwner.Name = "cboOwner";
			this.cboOwner.Size = new System.Drawing.Size(247, 22);
			this.cboOwner.TabIndex = 6;
			// 
			// lblOwner
			// 
			this.lblOwner.AutoSize = true;
			this.lblOwner.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwner.Location = new System.Drawing.Point(2, 32);
			this.lblOwner.Name = "lblOwner";
			this.lblOwner.Size = new System.Drawing.Size(62, 14);
			this.lblOwner.TabIndex = 5;
			this.lblOwner.Text = "Владелец";
			// 
			// cboGoodState
			// 
			this.cboGoodState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboGoodState.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboGoodState.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboGoodState.FormattingEnabled = true;
			this.cboGoodState.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboGoodState.Location = new System.Drawing.Point(482, 28);
			this.cboGoodState.Name = "cboGoodState";
			this.cboGoodState.Size = new System.Drawing.Size(247, 22);
			this.cboGoodState.TabIndex = 8;
			// 
			// lblGoodState
			// 
			this.lblGoodState.AutoSize = true;
			this.lblGoodState.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodState.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodState.Location = new System.Drawing.Point(371, 32);
			this.lblGoodState.Name = "lblGoodState";
			this.lblGoodState.Size = new System.Drawing.Size(110, 14);
			this.lblGoodState.TabIndex = 7;
			this.lblGoodState.Text = "Состояние товара";
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
			this.pnlTotal.Location = new System.Drawing.Point(210, 441);
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
			// frmInputsEdit
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
			this.Controls.Add(this.dgvInputGoods);
			this.hpHelp.SetHelpKeyword(this, "221");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmInputsEdit";
			this.PreFormName = "frmGetHost";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Задание на приход";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInputsEdit_KeyDown);
			this.Load += new System.EventHandler(this.frmInputsEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvInputGoods)).EndInit();
			this.pnlSelectConditions.ResumeLayout(false);
			this.pnlSelectConditions.PerformLayout();
			this.ucSelectRecordIDForm_Partners.ResumeLayout(false);
			this.ucSelectRecordIDForm_Partners.PerformLayout();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvInputGoods;
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
		private RFMBaseClasses.RFMDateTimePicker dtpDateInput;
		private RFMBaseClasses.RFMComboBox cboInputType;
		private RFMBaseClasses.RFMCheckBox chkDeliveryNeed;
		private RFMBaseClasses.RFMLabel lblDateInput;
		private RFMBaseClasses.RFMLabel lblInputType;
		private RFMBaseClasses.RFMComboBox cboGoodState;
		private RFMBaseClasses.RFMLabel lblGoodState;
		private RFMBaseClasses.RFMSelectRecordIDForm ucSelectRecordIDForm_Partners;
		private RFMBaseClasses.RFMLabel lblPartner;
		private RFMBaseClasses.RFMLabel lblOwner;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcInBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcBoxWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcQntWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcGoodPrice;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcWeighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBarCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
		private RFMBaseClasses.RFMComboBox cboOwner;
		private RFMBaseClasses.RFMLabel lblCurrency;
		private RFMBaseClasses.RFMComboBox cboCurrency;
	}
}

