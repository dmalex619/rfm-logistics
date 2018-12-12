namespace Logistics
{
	partial class frmMovingsDocumentsEdit
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvMovingDocumentGoods = new RFMBaseClasses.RFMDataGridView();
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
			this.radOwners = new RFMBaseClasses.RFMRadioButton();
			this.radGoodStates = new RFMBaseClasses.RFMRadioButton();
			this.pnlOwners = new RFMBaseClasses.RFMPanel();
			this.rfmPanelGlass1 = new RFMBaseClasses.RFMPanelGlass();
			this.lblOwnerSource = new RFMBaseClasses.RFMLabel();
			this.cboPartnerDetailTarget = new RFMBaseClasses.RFMComboBox();
			this.cboOwnerTarget = new RFMBaseClasses.RFMComboBox();
			this.lblPartnerDetailTarget = new RFMBaseClasses.RFMLabel();
			this.cboPartnerDetailSource = new RFMBaseClasses.RFMComboBox();
			this.cboOwnerSource = new RFMBaseClasses.RFMComboBox();
			this.lblPartnerDetailSource = new RFMBaseClasses.RFMLabel();
			this.lblOwnerTarget = new RFMBaseClasses.RFMLabel();
			this.pnlGoodState = new RFMBaseClasses.RFMPanel();
			this.rfmPanelGlass2 = new RFMBaseClasses.RFMPanelGlass();
			this.lblGoodStateSource = new RFMBaseClasses.RFMLabel();
			this.cboGoodStateTarget = new RFMBaseClasses.RFMComboBox();
			this.lblGoodStateTarget = new RFMBaseClasses.RFMLabel();
			this.cboGoodStateSource = new RFMBaseClasses.RFMComboBox();
			this.lblDocNumber = new RFMBaseClasses.RFMLabel();
			this.txtBillNumber = new RFMBaseClasses.RFMTextBox();
			this.lblDateOutput = new RFMBaseClasses.RFMLabel();
			this.dtpDateMovingDocument = new RFMBaseClasses.RFMDateTimePicker();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblTotal = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox_ = new RFMBaseClasses.RFMLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvMovingDocumentGoods)).BeginInit();
			this.pnlSelectConditions.SuspendLayout();
			this.pnlOwners.SuspendLayout();
			this.pnlGoodState.SuspendLayout();
			this.pnlTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMovingDocumentGoods
			// 
			this.dgvMovingDocumentGoods.AllowUserToAddRows = false;
			this.dgvMovingDocumentGoods.AllowUserToDeleteRows = false;
			this.dgvMovingDocumentGoods.AllowUserToOrderColumns = true;
			this.dgvMovingDocumentGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvMovingDocumentGoods.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvMovingDocumentGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvMovingDocumentGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvMovingDocumentGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvMovingDocumentGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.dgvMovingDocumentGoods.IsConfigInclude = true;
			this.dgvMovingDocumentGoods.IsMarkedAll = false;
			this.dgvMovingDocumentGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvMovingDocumentGoods.Location = new System.Drawing.Point(3, 182);
			this.dgvMovingDocumentGoods.MultiSelect = false;
			this.dgvMovingDocumentGoods.Name = "dgvMovingDocumentGoods";
			this.dgvMovingDocumentGoods.RangedWay = ' ';
			this.dgvMovingDocumentGoods.ReadOnly = true;
			this.dgvMovingDocumentGoods.RowHeadersWidth = 24;
			this.dgvMovingDocumentGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvMovingDocumentGoods.Size = new System.Drawing.Size(736, 252);
			this.dgvMovingDocumentGoods.TabIndex = 0;
			this.dgvMovingDocumentGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvMovingDocumentGoods_CellBeginEdit);
			this.dgvMovingDocumentGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMovingDocumentGoods_CellFormatting);
			this.dgvMovingDocumentGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovingDocumentGoods_CellEndEdit);
			this.dgvMovingDocumentGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovingDocumentGoods_CellValueChanged);
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
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "N0";
			this.dgvcInBox.DefaultCellStyle = dataGridViewCellStyle7;
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
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle8.Format = "N1";
			this.dgvcBoxWished.DefaultCellStyle = dataGridViewCellStyle8;
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
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "N0";
			this.dgvcQntWished.DefaultCellStyle = dataGridViewCellStyle9;
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
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "N2";
			dataGridViewCellStyle10.NullValue = null;
			this.dgvcGoodPrice.DefaultCellStyle = dataGridViewCellStyle10;
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
			this.dgvcID.DataPropertyName = "OutputDocumentGoodID";
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
			this.btnSave.Location = new System.Drawing.Point(663, 439);
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
			this.pnlSelectConditions.Controls.Add(this.radOwners);
			this.pnlSelectConditions.Controls.Add(this.radGoodStates);
			this.pnlSelectConditions.Controls.Add(this.pnlOwners);
			this.pnlSelectConditions.Controls.Add(this.pnlGoodState);
			this.pnlSelectConditions.Controls.Add(this.lblDocNumber);
			this.pnlSelectConditions.Controls.Add(this.txtBillNumber);
			this.pnlSelectConditions.Controls.Add(this.lblDateOutput);
			this.pnlSelectConditions.Controls.Add(this.dtpDateMovingDocument);
			this.pnlSelectConditions.Controls.Add(this.lblNote);
			this.pnlSelectConditions.Controls.Add(this.txtNote);
			this.pnlSelectConditions.Location = new System.Drawing.Point(3, 3);
			this.pnlSelectConditions.Name = "pnlSelectConditions";
			this.pnlSelectConditions.Size = new System.Drawing.Size(736, 177);
			this.pnlSelectConditions.TabIndex = 0;
			// 
			// lblCurrency
			// 
			this.lblCurrency.AutoSize = true;
			this.lblCurrency.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCurrency.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurrency.Location = new System.Drawing.Point(433, 8);
			this.lblCurrency.Name = "lblCurrency";
			this.lblCurrency.Size = new System.Drawing.Size(48, 14);
			this.lblCurrency.TabIndex = 4;
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
			this.cboCurrency.Location = new System.Drawing.Point(488, 4);
			this.cboCurrency.Name = "cboCurrency";
			this.cboCurrency.Size = new System.Drawing.Size(234, 22);
			this.cboCurrency.TabIndex = 5;
			// 
			// radOwners
			// 
			this.radOwners.AutoSize = true;
			this.radOwners.Location = new System.Drawing.Point(4, 24);
			this.radOwners.Name = "radOwners";
			this.radOwners.Size = new System.Drawing.Size(80, 18);
			this.radOwners.TabIndex = 6;
			this.radOwners.TabStop = true;
			this.radOwners.Text = "Владелец";
			this.radOwners.UseVisualStyleBackColor = true;
			this.radOwners.CheckedChanged += new System.EventHandler(this.radOwners_CheckedChanged);
			// 
			// radGoodStates
			// 
			this.radGoodStates.AutoSize = true;
			this.radGoodStates.Location = new System.Drawing.Point(4, 99);
			this.radGoodStates.Name = "radGoodStates";
			this.radGoodStates.Size = new System.Drawing.Size(128, 18);
			this.radGoodStates.TabIndex = 8;
			this.radGoodStates.TabStop = true;
			this.radGoodStates.Text = "Состояние товара";
			this.radGoodStates.UseVisualStyleBackColor = true;
			this.radGoodStates.CheckedChanged += new System.EventHandler(this.radGoodStates_CheckedChanged);
			// 
			// pnlOwners
			// 
			this.pnlOwners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlOwners.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlOwners.Controls.Add(this.rfmPanelGlass1);
			this.pnlOwners.Controls.Add(this.lblOwnerSource);
			this.pnlOwners.Controls.Add(this.cboPartnerDetailTarget);
			this.pnlOwners.Controls.Add(this.cboOwnerTarget);
			this.pnlOwners.Controls.Add(this.lblPartnerDetailTarget);
			this.pnlOwners.Controls.Add(this.cboPartnerDetailSource);
			this.pnlOwners.Controls.Add(this.cboOwnerSource);
			this.pnlOwners.Controls.Add(this.lblPartnerDetailSource);
			this.pnlOwners.Controls.Add(this.lblOwnerTarget);
			this.pnlOwners.Location = new System.Drawing.Point(4, 35);
			this.pnlOwners.Name = "pnlOwners";
			this.pnlOwners.Size = new System.Drawing.Size(725, 60);
			this.pnlOwners.TabIndex = 7;
			// 
			// rfmPanelGlass1
			// 
			this.rfmPanelGlass1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.rfmPanelGlass1.Location = new System.Drawing.Point(360, -1);
			this.rfmPanelGlass1.Name = "rfmPanelGlass1";
			this.rfmPanelGlass1.Size = new System.Drawing.Size(5, 58);
			this.rfmPanelGlass1.TabIndex = 4;
			// 
			// lblOwnerSource
			// 
			this.lblOwnerSource.AutoSize = true;
			this.lblOwnerSource.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwnerSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwnerSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwnerSource.Location = new System.Drawing.Point(5, 9);
			this.lblOwnerSource.Name = "lblOwnerSource";
			this.lblOwnerSource.Size = new System.Drawing.Size(63, 14);
			this.lblOwnerSource.TabIndex = 0;
			this.lblOwnerSource.Text = "Исходный";
			// 
			// cboPartnerDetailTarget
			// 
			this.cboPartnerDetailTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboPartnerDetailTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboPartnerDetailTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboPartnerDetailTarget.FormattingEnabled = true;
			this.cboPartnerDetailTarget.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboPartnerDetailTarget.Location = new System.Drawing.Point(437, 31);
			this.cboPartnerDetailTarget.Name = "cboPartnerDetailTarget";
			this.cboPartnerDetailTarget.Size = new System.Drawing.Size(280, 22);
			this.cboPartnerDetailTarget.TabIndex = 8;
			// 
			// cboOwnerTarget
			// 
			this.cboOwnerTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboOwnerTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboOwnerTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboOwnerTarget.FormattingEnabled = true;
			this.cboOwnerTarget.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboOwnerTarget.Location = new System.Drawing.Point(437, 5);
			this.cboOwnerTarget.Name = "cboOwnerTarget";
			this.cboOwnerTarget.Size = new System.Drawing.Size(280, 22);
			this.cboOwnerTarget.TabIndex = 6;
			this.cboOwnerTarget.SelectedIndexChanged += new System.EventHandler(this.cboOwnerTarget_SelectedIndexChanged);
			// 
			// lblPartnerDetailTarget
			// 
			this.lblPartnerDetailTarget.AutoSize = true;
			this.lblPartnerDetailTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPartnerDetailTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPartnerDetailTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPartnerDetailTarget.Location = new System.Drawing.Point(370, 35);
			this.lblPartnerDetailTarget.Name = "lblPartnerDetailTarget";
			this.lblPartnerDetailTarget.Size = new System.Drawing.Size(66, 14);
			this.lblPartnerDetailTarget.TabIndex = 7;
			this.lblPartnerDetailTarget.Text = "Реквизиты";
			// 
			// cboPartnerDetailSource
			// 
			this.cboPartnerDetailSource.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboPartnerDetailSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboPartnerDetailSource.FormattingEnabled = true;
			this.cboPartnerDetailSource.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboPartnerDetailSource.Location = new System.Drawing.Point(77, 31);
			this.cboPartnerDetailSource.Name = "cboPartnerDetailSource";
			this.cboPartnerDetailSource.Size = new System.Drawing.Size(280, 22);
			this.cboPartnerDetailSource.TabIndex = 3;
			// 
			// cboOwnerSource
			// 
			this.cboOwnerSource.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboOwnerSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboOwnerSource.FormattingEnabled = true;
			this.cboOwnerSource.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboOwnerSource.Location = new System.Drawing.Point(77, 5);
			this.cboOwnerSource.Name = "cboOwnerSource";
			this.cboOwnerSource.Size = new System.Drawing.Size(280, 22);
			this.cboOwnerSource.TabIndex = 1;
			this.cboOwnerSource.SelectedIndexChanged += new System.EventHandler(this.cboOwnerSource_SelectedIndexChanged);
			// 
			// lblPartnerDetailSource
			// 
			this.lblPartnerDetailSource.AutoSize = true;
			this.lblPartnerDetailSource.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPartnerDetailSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPartnerDetailSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPartnerDetailSource.Location = new System.Drawing.Point(5, 35);
			this.lblPartnerDetailSource.Name = "lblPartnerDetailSource";
			this.lblPartnerDetailSource.Size = new System.Drawing.Size(66, 14);
			this.lblPartnerDetailSource.TabIndex = 2;
			this.lblPartnerDetailSource.Text = "Реквизиты";
			// 
			// lblOwnerTarget
			// 
			this.lblOwnerTarget.AutoSize = true;
			this.lblOwnerTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwnerTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwnerTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwnerTarget.Location = new System.Drawing.Point(370, 9);
			this.lblOwnerTarget.Name = "lblOwnerTarget";
			this.lblOwnerTarget.Size = new System.Drawing.Size(64, 14);
			this.lblOwnerTarget.TabIndex = 5;
			this.lblOwnerTarget.Text = "Конечный";
			// 
			// pnlGoodState
			// 
			this.pnlGoodState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlGoodState.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlGoodState.Controls.Add(this.rfmPanelGlass2);
			this.pnlGoodState.Controls.Add(this.lblGoodStateSource);
			this.pnlGoodState.Controls.Add(this.cboGoodStateTarget);
			this.pnlGoodState.Controls.Add(this.lblGoodStateTarget);
			this.pnlGoodState.Controls.Add(this.cboGoodStateSource);
			this.pnlGoodState.Location = new System.Drawing.Point(4, 110);
			this.pnlGoodState.Name = "pnlGoodState";
			this.pnlGoodState.Size = new System.Drawing.Size(725, 34);
			this.pnlGoodState.TabIndex = 9;
			// 
			// rfmPanelGlass2
			// 
			this.rfmPanelGlass2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.rfmPanelGlass2.Location = new System.Drawing.Point(359, 0);
			this.rfmPanelGlass2.Name = "rfmPanelGlass2";
			this.rfmPanelGlass2.Size = new System.Drawing.Size(5, 32);
			this.rfmPanelGlass2.TabIndex = 2;
			// 
			// lblGoodStateSource
			// 
			this.lblGoodStateSource.AutoSize = true;
			this.lblGoodStateSource.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodStateSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodStateSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodStateSource.Location = new System.Drawing.Point(5, 9);
			this.lblGoodStateSource.Name = "lblGoodStateSource";
			this.lblGoodStateSource.Size = new System.Drawing.Size(62, 14);
			this.lblGoodStateSource.TabIndex = 0;
			this.lblGoodStateSource.Text = "Исходное";
			// 
			// cboGoodStateTarget
			// 
			this.cboGoodStateTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboGoodStateTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboGoodStateTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboGoodStateTarget.FormattingEnabled = true;
			this.cboGoodStateTarget.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboGoodStateTarget.Location = new System.Drawing.Point(437, 5);
			this.cboGoodStateTarget.Name = "cboGoodStateTarget";
			this.cboGoodStateTarget.Size = new System.Drawing.Size(280, 22);
			this.cboGoodStateTarget.TabIndex = 4;
			// 
			// lblGoodStateTarget
			// 
			this.lblGoodStateTarget.AutoSize = true;
			this.lblGoodStateTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodStateTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodStateTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodStateTarget.Location = new System.Drawing.Point(370, 9);
			this.lblGoodStateTarget.Name = "lblGoodStateTarget";
			this.lblGoodStateTarget.Size = new System.Drawing.Size(63, 14);
			this.lblGoodStateTarget.TabIndex = 3;
			this.lblGoodStateTarget.Text = "Конечное";
			// 
			// cboGoodStateSource
			// 
			this.cboGoodStateSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboGoodStateSource.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboGoodStateSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboGoodStateSource.FormattingEnabled = true;
			this.cboGoodStateSource.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboGoodStateSource.Location = new System.Drawing.Point(77, 5);
			this.cboGoodStateSource.Name = "cboGoodStateSource";
			this.cboGoodStateSource.Size = new System.Drawing.Size(278, 22);
			this.cboGoodStateSource.TabIndex = 1;
			// 
			// lblDocNumber
			// 
			this.lblDocNumber.AutoSize = true;
			this.lblDocNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDocNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDocNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDocNumber.Location = new System.Drawing.Point(213, 8);
			this.lblDocNumber.Name = "lblDocNumber";
			this.lblDocNumber.Size = new System.Drawing.Size(108, 14);
			this.lblDocNumber.TabIndex = 2;
			this.lblDocNumber.Text = "Номер документа";
			// 
			// txtBillNumber
			// 
			this.txtBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBillNumber.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtBillNumber.Location = new System.Drawing.Point(327, 4);
			this.txtBillNumber.Name = "txtBillNumber";
			this.txtBillNumber.Size = new System.Drawing.Size(90, 22);
			this.txtBillNumber.TabIndex = 3;
			// 
			// lblDateOutput
			// 
			this.lblDateOutput.AutoSize = true;
			this.lblDateOutput.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateOutput.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateOutput.Location = new System.Drawing.Point(3, 8);
			this.lblDateOutput.Name = "lblDateOutput";
			this.lblDateOutput.Size = new System.Drawing.Size(92, 14);
			this.lblDateOutput.TabIndex = 0;
			this.lblDateOutput.Text = "Дата операции";
			// 
			// dtpDateMovingDocument
			// 
			this.dtpDateMovingDocument.CustomFormat = "dd.MM.yyyy";
			this.dtpDateMovingDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateMovingDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateMovingDocument.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateMovingDocument.Location = new System.Drawing.Point(101, 4);
			this.dtpDateMovingDocument.Name = "dtpDateMovingDocument";
			this.dtpDateMovingDocument.Size = new System.Drawing.Size(90, 22);
			this.dtpDateMovingDocument.TabIndex = 1;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(4, 151);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 10;
			this.lblNote.Text = "Примечание";
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(83, 148);
			this.txtNote.MaxLength = 500;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(646, 22);
			this.txtNote.TabIndex = 11;
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
			// frmMovingsDocumentsEdit
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
			this.Controls.Add(this.dgvMovingDocumentGoods);
			this.hpHelp.SetHelpKeyword(this, "221");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmMovingsDocumentsEdit";
			this.PreFormName = "frmGetHost";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Документарное перемещение";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMovingsDocumentsEdit_KeyDown);
			this.Load += new System.EventHandler(this.frmMovingsDocumentsEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMovingDocumentGoods)).EndInit();
			this.pnlSelectConditions.ResumeLayout(false);
			this.pnlSelectConditions.PerformLayout();
			this.pnlOwners.ResumeLayout(false);
			this.pnlOwners.PerformLayout();
			this.pnlGoodState.ResumeLayout(false);
			this.pnlGoodState.PerformLayout();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvMovingDocumentGoods;
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
		private RFMBaseClasses.RFMDateTimePicker dtpDateMovingDocument;
		private RFMBaseClasses.RFMLabel lblDateOutput;
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
		private RFMBaseClasses.RFMTextBox txtBillNumber;
		private RFMBaseClasses.RFMLabel lblDocNumber;
		private RFMBaseClasses.RFMPanel pnlGoodState;
		private RFMBaseClasses.RFMLabel lblGoodStateSource;
		private RFMBaseClasses.RFMComboBox cboGoodStateTarget;
		private RFMBaseClasses.RFMLabel lblGoodStateTarget;
		private RFMBaseClasses.RFMComboBox cboGoodStateSource;
		private RFMBaseClasses.RFMPanel pnlOwners;
		private RFMBaseClasses.RFMComboBox cboPartnerDetailTarget;
		private RFMBaseClasses.RFMComboBox cboOwnerTarget;
		private RFMBaseClasses.RFMLabel lblPartnerDetailTarget;
		private RFMBaseClasses.RFMComboBox cboPartnerDetailSource;
		private RFMBaseClasses.RFMComboBox cboOwnerSource;
		private RFMBaseClasses.RFMLabel lblPartnerDetailSource;
		private RFMBaseClasses.RFMLabel lblOwnerTarget;
		private RFMBaseClasses.RFMLabel lblOwnerSource;
		private RFMBaseClasses.RFMRadioButton radGoodStates;
		private RFMBaseClasses.RFMPanelGlass rfmPanelGlass1;
		private RFMBaseClasses.RFMPanelGlass rfmPanelGlass2;
		private RFMBaseClasses.RFMRadioButton radOwners;
		private RFMBaseClasses.RFMLabel lblCurrency;
		private RFMBaseClasses.RFMComboBox cboCurrency;
	}
}

