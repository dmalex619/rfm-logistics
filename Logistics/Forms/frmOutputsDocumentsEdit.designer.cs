namespace Logistics
{
	partial class frmOutputsDocumentsEdit
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutputsDocumentsEdit));
			this.dgvOutputDocumentGoods = new RFMBaseClasses.RFMDataGridView();
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
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblTotal = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox_ = new RFMBaseClasses.RFMLabel();
			this.tcOutputDocument = new RFMBaseClasses.RFMTabControl();
			this.tabMain = new RFMBaseClasses.RFMTabPage();
			this.pnlMain = new RFMBaseClasses.RFMPanel();
			this.cboOwner = new RFMBaseClasses.RFMComboBox();
			this.lblBuyer = new RFMBaseClasses.RFMLabel();
			this.lblShipper = new RFMBaseClasses.RFMLabel();
			this.ucSelectRecordIDForm_Buyers = new RFMBaseClasses.RFMSelectRecordIDForm();
			this.ucSelectRecordIDForm_Shippers = new RFMBaseClasses.RFMSelectRecordIDForm();
			this.lblOwner = new RFMBaseClasses.RFMLabel();
			this.ucSelectRecordIDForm_Salers = new RFMBaseClasses.RFMSelectRecordIDForm();
			this.lblSaler = new RFMBaseClasses.RFMLabel();
			this.cboGoodState = new RFMBaseClasses.RFMComboBox();
			this.lblGoodState = new RFMBaseClasses.RFMLabel();
			this.lblOutputType = new RFMBaseClasses.RFMLabel();
			this.lblDateOutput = new RFMBaseClasses.RFMLabel();
			this.cboOutputDocumentType = new RFMBaseClasses.RFMComboBox();
			this.dtpDateOutputDocument = new RFMBaseClasses.RFMDateTimePicker();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.lblCurrency = new RFMBaseClasses.RFMLabel();
			this.cboCurrency = new RFMBaseClasses.RFMComboBox();
			this.chkDeliveryNeed = new RFMBaseClasses.RFMCheckBox();
			this.tabOther = new RFMBaseClasses.RFMTabPage();
			this.pnlOther = new RFMBaseClasses.RFMPanel();
			this.chkNotForJoin = new RFMBaseClasses.RFMCheckBox();
			this.lblFactureNumber = new RFMBaseClasses.RFMLabel();
			this.txtFactureNumber = new RFMBaseClasses.RFMTextBox();
			this.lblBillNumber = new RFMBaseClasses.RFMLabel();
			this.txtBillNumber = new RFMBaseClasses.RFMTextBox();
			this.chkWarrantNeed = new RFMBaseClasses.RFMCheckBox();
			this.chkPayBillNeed = new RFMBaseClasses.RFMCheckBox();
			this.chkBillNeed = new RFMBaseClasses.RFMCheckBox();
			this.chkFactureNeed = new RFMBaseClasses.RFMCheckBox();
			this.chkTPL = new RFMBaseClasses.RFMCheckBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvOutputDocumentGoods)).BeginInit();
			this.pnlTotal.SuspendLayout();
			this.tcOutputDocument.SuspendLayout();
			this.tabMain.SuspendLayout();
			this.pnlMain.SuspendLayout();
			this.ucSelectRecordIDForm_Buyers.SuspendLayout();
			this.ucSelectRecordIDForm_Shippers.SuspendLayout();
			this.ucSelectRecordIDForm_Salers.SuspendLayout();
			this.tabOther.SuspendLayout();
			this.pnlOther.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvOutputDocumentGoods
			// 
			this.dgvOutputDocumentGoods.AllowUserToAddRows = false;
			this.dgvOutputDocumentGoods.AllowUserToDeleteRows = false;
			this.dgvOutputDocumentGoods.AllowUserToOrderColumns = true;
			this.dgvOutputDocumentGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvOutputDocumentGoods.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvOutputDocumentGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvOutputDocumentGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvOutputDocumentGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOutputDocumentGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.dgvOutputDocumentGoods.IsConfigInclude = true;
			this.dgvOutputDocumentGoods.IsMarkedAll = false;
			this.dgvOutputDocumentGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvOutputDocumentGoods.Location = new System.Drawing.Point(1, 159);
			this.dgvOutputDocumentGoods.MultiSelect = false;
			this.dgvOutputDocumentGoods.Name = "dgvOutputDocumentGoods";
			this.dgvOutputDocumentGoods.RangedWay = ' ';
			this.dgvOutputDocumentGoods.ReadOnly = true;
			this.dgvOutputDocumentGoods.RowHeadersWidth = 24;
			this.dgvOutputDocumentGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvOutputDocumentGoods.Size = new System.Drawing.Size(740, 275);
			this.dgvOutputDocumentGoods.TabIndex = 0;
			this.dgvOutputDocumentGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOutputDocumentGoods_CellBeginEdit);
			this.dgvOutputDocumentGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOutputDocumentGoods_CellFormatting);
			this.dgvOutputDocumentGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutputDocumentGoods_CellEndEdit);
			this.dgvOutputDocumentGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutputDocumentGoods_CellValueChanged);
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
			// tcOutputDocument
			// 
			this.tcOutputDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcOutputDocument.Controls.Add(this.tabMain);
			this.tcOutputDocument.Controls.Add(this.tabOther);
			this.tcOutputDocument.Location = new System.Drawing.Point(1, 2);
			this.tcOutputDocument.Name = "tcOutputDocument";
			this.tcOutputDocument.SelectedIndex = 0;
			this.tcOutputDocument.Size = new System.Drawing.Size(740, 158);
			this.tcOutputDocument.TabIndex = 0;
			// 
			// tabMain
			// 
			this.tabMain.Controls.Add(this.pnlMain);
			this.tabMain.Location = new System.Drawing.Point(4, 23);
			this.tabMain.Name = "tabMain";
			this.tabMain.Padding = new System.Windows.Forms.Padding(3);
			this.tabMain.Size = new System.Drawing.Size(732, 131);
			this.tabMain.TabIndex = 0;
			this.tabMain.Text = "Реквизиты";
			this.tabMain.UseVisualStyleBackColor = true;
			// 
			// pnlMain
			// 
			this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlMain.Controls.Add(this.cboOwner);
			this.pnlMain.Controls.Add(this.lblBuyer);
			this.pnlMain.Controls.Add(this.lblShipper);
			this.pnlMain.Controls.Add(this.ucSelectRecordIDForm_Buyers);
			this.pnlMain.Controls.Add(this.ucSelectRecordIDForm_Shippers);
			this.pnlMain.Controls.Add(this.lblOwner);
			this.pnlMain.Controls.Add(this.ucSelectRecordIDForm_Salers);
			this.pnlMain.Controls.Add(this.lblSaler);
			this.pnlMain.Controls.Add(this.cboGoodState);
			this.pnlMain.Controls.Add(this.lblGoodState);
			this.pnlMain.Controls.Add(this.lblOutputType);
			this.pnlMain.Controls.Add(this.lblDateOutput);
			this.pnlMain.Controls.Add(this.cboOutputDocumentType);
			this.pnlMain.Controls.Add(this.dtpDateOutputDocument);
			this.pnlMain.Controls.Add(this.lblNote);
			this.pnlMain.Controls.Add(this.txtNote);
			this.pnlMain.Controls.Add(this.lblCurrency);
			this.pnlMain.Controls.Add(this.cboCurrency);
			this.pnlMain.Controls.Add(this.chkDeliveryNeed);
			this.pnlMain.Location = new System.Drawing.Point(0, 1);
			this.pnlMain.Name = "pnlMain";
			this.pnlMain.Size = new System.Drawing.Size(731, 130);
			this.pnlMain.TabIndex = 4;
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
			this.cboOwner.Location = new System.Drawing.Point(83, 28);
			this.cboOwner.Name = "cboOwner";
			this.cboOwner.Size = new System.Drawing.Size(250, 22);
			this.cboOwner.TabIndex = 6;
			// 
			// lblBuyer
			// 
			this.lblBuyer.AutoSize = true;
			this.lblBuyer.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblBuyer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblBuyer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblBuyer.Location = new System.Drawing.Point(4, 82);
			this.lblBuyer.Name = "lblBuyer";
			this.lblBuyer.Size = new System.Drawing.Size(73, 14);
			this.lblBuyer.TabIndex = 13;
			this.lblBuyer.Text = "Покупатель";
			// 
			// lblShipper
			// 
			this.lblShipper.AutoSize = true;
			this.lblShipper.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblShipper.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblShipper.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblShipper.Location = new System.Drawing.Point(368, 57);
			this.lblShipper.Name = "lblShipper";
			this.lblShipper.Size = new System.Drawing.Size(103, 14);
			this.lblShipper.TabIndex = 11;
			this.lblShipper.Text = "Грузотправитель";
			// 
			// ucSelectRecordIDForm_Buyers
			// 
			// 
			// ucSelectRecordIDForm_Buyers.btnClear
			// 
			this.ucSelectRecordIDForm_Buyers.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Buyers.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Buyers.btnClear.Image")));
			this.ucSelectRecordIDForm_Buyers.BtnClear.Location = new System.Drawing.Point(251, 1);
			this.ucSelectRecordIDForm_Buyers.BtnClear.Name = "btnClear";
			this.ucSelectRecordIDForm_Buyers.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Buyers.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Buyers.BtnClear, "Очистка реквизитов покупателя");
			this.ucSelectRecordIDForm_Buyers.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordIDForm_Buyers.btnSelect
			// 
			this.ucSelectRecordIDForm_Buyers.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Buyers.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Buyers.btnSelect.Image")));
			this.ucSelectRecordIDForm_Buyers.BtnSelect.Location = new System.Drawing.Point(225, 1);
			this.ucSelectRecordIDForm_Buyers.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordIDForm_Buyers.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Buyers.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Buyers.BtnSelect, "Выбор реквизитов покупателя");
			this.ucSelectRecordIDForm_Buyers.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordIDForm_Buyers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordIDForm_Buyers.FormName = "frmSelectOnePartner";
			this.ucSelectRecordIDForm_Buyers.IsSaveMark = true;
			this.ucSelectRecordIDForm_Buyers.Location = new System.Drawing.Point(83, 76);
			this.ucSelectRecordIDForm_Buyers.MarkedCount = 0;
			this.ucSelectRecordIDForm_Buyers.Name = "ucSelectRecordIDForm_Buyers";
			this.ucSelectRecordIDForm_Buyers.Size = new System.Drawing.Size(279, 26);
			this.ucSelectRecordIDForm_Buyers.TabIndex = 14;
			// 
			// ucSelectRecordIDForm_Buyers.txtData
			// 
			this.ucSelectRecordIDForm_Buyers.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Buyers.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordIDForm_Buyers.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordIDForm_Buyers.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordIDForm_Buyers.TxtData.IsUserDraw = true;
			this.ucSelectRecordIDForm_Buyers.TxtData.Location = new System.Drawing.Point(0, 2);
			this.ucSelectRecordIDForm_Buyers.TxtData.Name = "txtData";
			this.ucSelectRecordIDForm_Buyers.TxtData.ReadOnly = true;
			this.ucSelectRecordIDForm_Buyers.TxtData.Size = new System.Drawing.Size(223, 22);
			this.ucSelectRecordIDForm_Buyers.TxtData.TabIndex = 3;
			// 
			// ucSelectRecordIDForm_Shippers
			// 
			this.ucSelectRecordIDForm_Shippers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// ucSelectRecordIDForm_Shippers.btnClear
			// 
			this.ucSelectRecordIDForm_Shippers.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Shippers.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Shippers.btnClear.Image")));
			this.ucSelectRecordIDForm_Shippers.BtnClear.Location = new System.Drawing.Point(220, 1);
			this.ucSelectRecordIDForm_Shippers.BtnClear.Name = "btnClear";
			this.ucSelectRecordIDForm_Shippers.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Shippers.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Shippers.BtnClear, "Очистка реквизитов грузоотправителя");
			this.ucSelectRecordIDForm_Shippers.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordIDForm_Shippers.btnSelect
			// 
			this.ucSelectRecordIDForm_Shippers.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Shippers.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Shippers.btnSelect.Image")));
			this.ucSelectRecordIDForm_Shippers.BtnSelect.Location = new System.Drawing.Point(194, 1);
			this.ucSelectRecordIDForm_Shippers.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordIDForm_Shippers.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Shippers.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Shippers.BtnSelect, "Выбор реквизитов грузоотправителя");
			this.ucSelectRecordIDForm_Shippers.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordIDForm_Shippers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordIDForm_Shippers.FormName = "frmSelectOnePartner";
			this.ucSelectRecordIDForm_Shippers.IsSaveMark = true;
			this.ucSelectRecordIDForm_Shippers.Location = new System.Drawing.Point(481, 51);
			this.ucSelectRecordIDForm_Shippers.MarkedCount = 0;
			this.ucSelectRecordIDForm_Shippers.Name = "ucSelectRecordIDForm_Shippers";
			this.ucSelectRecordIDForm_Shippers.Size = new System.Drawing.Size(244, 26);
			this.ucSelectRecordIDForm_Shippers.TabIndex = 12;
			// 
			// ucSelectRecordIDForm_Shippers.txtData
			// 
			this.ucSelectRecordIDForm_Shippers.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Shippers.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordIDForm_Shippers.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordIDForm_Shippers.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordIDForm_Shippers.TxtData.IsUserDraw = true;
			this.ucSelectRecordIDForm_Shippers.TxtData.Location = new System.Drawing.Point(0, 2);
			this.ucSelectRecordIDForm_Shippers.TxtData.Name = "txtData";
			this.ucSelectRecordIDForm_Shippers.TxtData.ReadOnly = true;
			this.ucSelectRecordIDForm_Shippers.TxtData.Size = new System.Drawing.Size(192, 22);
			this.ucSelectRecordIDForm_Shippers.TxtData.TabIndex = 3;
			this.ucSelectRecordIDForm_Shippers.TxtData.TextChanged += new System.EventHandler(this.ucSelectRecordIDForm_Shippers_TxtData_TextChanged);
			// 
			// lblOwner
			// 
			this.lblOwner.AutoSize = true;
			this.lblOwner.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwner.Location = new System.Drawing.Point(4, 32);
			this.lblOwner.Name = "lblOwner";
			this.lblOwner.Size = new System.Drawing.Size(62, 14);
			this.lblOwner.TabIndex = 5;
			this.lblOwner.Text = "Владелец";
			// 
			// ucSelectRecordIDForm_Salers
			// 
			// 
			// ucSelectRecordIDForm_Salers.btnClear
			// 
			this.ucSelectRecordIDForm_Salers.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Salers.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Salers.btnClear.Image")));
			this.ucSelectRecordIDForm_Salers.BtnClear.Location = new System.Drawing.Point(251, 1);
			this.ucSelectRecordIDForm_Salers.BtnClear.Name = "btnClear";
			this.ucSelectRecordIDForm_Salers.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Salers.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Salers.BtnClear, "Очистка реквизитов продавца");
			this.ucSelectRecordIDForm_Salers.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordIDForm_Salers.btnSelect
			// 
			this.ucSelectRecordIDForm_Salers.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Salers.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Salers.btnSelect.Image")));
			this.ucSelectRecordIDForm_Salers.BtnSelect.Location = new System.Drawing.Point(225, 1);
			this.ucSelectRecordIDForm_Salers.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordIDForm_Salers.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordIDForm_Salers.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Salers.BtnSelect, "Выбор реквизитов продавца");
			this.ucSelectRecordIDForm_Salers.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordIDForm_Salers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordIDForm_Salers.FormName = "frmSelectOnePartner";
			this.ucSelectRecordIDForm_Salers.IsSaveMark = true;
			this.ucSelectRecordIDForm_Salers.Location = new System.Drawing.Point(83, 51);
			this.ucSelectRecordIDForm_Salers.MarkedCount = 0;
			this.ucSelectRecordIDForm_Salers.Name = "ucSelectRecordIDForm_Salers";
			this.ucSelectRecordIDForm_Salers.Size = new System.Drawing.Size(279, 26);
			this.ucSelectRecordIDForm_Salers.TabIndex = 10;
			// 
			// ucSelectRecordIDForm_Salers.txtData
			// 
			this.ucSelectRecordIDForm_Salers.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordIDForm_Salers.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordIDForm_Salers.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordIDForm_Salers.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordIDForm_Salers.TxtData.IsUserDraw = true;
			this.ucSelectRecordIDForm_Salers.TxtData.Location = new System.Drawing.Point(0, 2);
			this.ucSelectRecordIDForm_Salers.TxtData.Name = "txtData";
			this.ucSelectRecordIDForm_Salers.TxtData.ReadOnly = true;
			this.ucSelectRecordIDForm_Salers.TxtData.Size = new System.Drawing.Size(223, 22);
			this.ucSelectRecordIDForm_Salers.TxtData.TabIndex = 3;
			this.ucSelectRecordIDForm_Salers.TxtData.TextChanged += new System.EventHandler(this.ucSelectRecordIDForm_Salers_TxtData_TextChanged);
			// 
			// lblSaler
			// 
			this.lblSaler.AutoSize = true;
			this.lblSaler.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblSaler.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblSaler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSaler.Location = new System.Drawing.Point(4, 57);
			this.lblSaler.Name = "lblSaler";
			this.lblSaler.Size = new System.Drawing.Size(62, 14);
			this.lblSaler.TabIndex = 9;
			this.lblSaler.Text = "Продавец";
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
			this.cboGoodState.Location = new System.Drawing.Point(481, 28);
			this.cboGoodState.Name = "cboGoodState";
			this.cboGoodState.Size = new System.Drawing.Size(244, 22);
			this.cboGoodState.TabIndex = 8;
			// 
			// lblGoodState
			// 
			this.lblGoodState.AutoSize = true;
			this.lblGoodState.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodState.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodState.Location = new System.Drawing.Point(368, 32);
			this.lblGoodState.Name = "lblGoodState";
			this.lblGoodState.Size = new System.Drawing.Size(110, 14);
			this.lblGoodState.TabIndex = 7;
			this.lblGoodState.Text = "Состояние товара";
			// 
			// lblOutputType
			// 
			this.lblOutputType.AutoSize = true;
			this.lblOutputType.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOutputType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOutputType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOutputType.Location = new System.Drawing.Point(368, 82);
			this.lblOutputType.Name = "lblOutputType";
			this.lblOutputType.Size = new System.Drawing.Size(93, 14);
			this.lblOutputType.TabIndex = 15;
			this.lblOutputType.Text = "Тип документа";
			// 
			// lblDateOutput
			// 
			this.lblDateOutput.AutoSize = true;
			this.lblDateOutput.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateOutput.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateOutput.Location = new System.Drawing.Point(6, 7);
			this.lblDateOutput.Name = "lblDateOutput";
			this.lblDateOutput.Size = new System.Drawing.Size(71, 14);
			this.lblDateOutput.TabIndex = 0;
			this.lblDateOutput.Text = "Дата заказа";
			// 
			// cboOutputDocumentType
			// 
			this.cboOutputDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboOutputDocumentType.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboOutputDocumentType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboOutputDocumentType.FormattingEnabled = true;
			this.cboOutputDocumentType.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboOutputDocumentType.Location = new System.Drawing.Point(481, 78);
			this.cboOutputDocumentType.Name = "cboOutputDocumentType";
			this.cboOutputDocumentType.Size = new System.Drawing.Size(244, 22);
			this.cboOutputDocumentType.TabIndex = 16;
			// 
			// dtpDateOutputDocument
			// 
			this.dtpDateOutputDocument.CustomFormat = "dd.MM.yyyy";
			this.dtpDateOutputDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateOutputDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateOutputDocument.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateOutputDocument.Location = new System.Drawing.Point(83, 3);
			this.dtpDateOutputDocument.Name = "dtpDateOutputDocument";
			this.dtpDateOutputDocument.Size = new System.Drawing.Size(92, 22);
			this.dtpDateOutputDocument.TabIndex = 1;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(4, 107);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 17;
			this.lblNote.Text = "Примечание";
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(83, 103);
			this.txtNote.MaxLength = 500;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(643, 22);
			this.txtNote.TabIndex = 18;
			this.ttToolTip.SetToolTip(this.txtNote, "Примечание по заказу");
			// 
			// lblCurrency
			// 
			this.lblCurrency.AutoSize = true;
			this.lblCurrency.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCurrency.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCurrency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurrency.Location = new System.Drawing.Point(368, 7);
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
			this.cboCurrency.Location = new System.Drawing.Point(481, 4);
			this.cboCurrency.Name = "cboCurrency";
			this.cboCurrency.Size = new System.Drawing.Size(244, 22);
			this.cboCurrency.TabIndex = 4;
			// 
			// chkDeliveryNeed
			// 
			this.chkDeliveryNeed.Location = new System.Drawing.Point(224, 4);
			this.chkDeliveryNeed.Name = "chkDeliveryNeed";
			this.chkDeliveryNeed.Size = new System.Drawing.Size(113, 18);
			this.chkDeliveryNeed.TabIndex = 2;
			this.chkDeliveryNeed.Text = "наша доставка?";
			this.chkDeliveryNeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkDeliveryNeed.UseVisualStyleBackColor = true;
			// 
			// tabOther
			// 
			this.tabOther.Controls.Add(this.pnlOther);
			this.tabOther.Location = new System.Drawing.Point(4, 23);
			this.tabOther.Name = "tabOther";
			this.tabOther.Padding = new System.Windows.Forms.Padding(3);
			this.tabOther.Size = new System.Drawing.Size(732, 131);
			this.tabOther.TabIndex = 1;
			this.tabOther.Text = "Дополнительно";
			this.tabOther.UseVisualStyleBackColor = true;
			// 
			// pnlOther
			// 
			this.pnlOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlOther.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlOther.Controls.Add(this.chkNotForJoin);
			this.pnlOther.Controls.Add(this.lblFactureNumber);
			this.pnlOther.Controls.Add(this.txtFactureNumber);
			this.pnlOther.Controls.Add(this.lblBillNumber);
			this.pnlOther.Controls.Add(this.txtBillNumber);
			this.pnlOther.Controls.Add(this.chkWarrantNeed);
			this.pnlOther.Controls.Add(this.chkPayBillNeed);
			this.pnlOther.Controls.Add(this.chkBillNeed);
			this.pnlOther.Controls.Add(this.chkFactureNeed);
			this.pnlOther.Controls.Add(this.chkTPL);
			this.pnlOther.Location = new System.Drawing.Point(0, 1);
			this.pnlOther.Name = "pnlOther";
			this.pnlOther.Size = new System.Drawing.Size(731, 130);
			this.pnlOther.TabIndex = 6;
			// 
			// chkNotForJoin
			// 
			this.chkNotForJoin.AutoSize = true;
			this.chkNotForJoin.Checked = true;
			this.chkNotForJoin.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkNotForJoin.Enabled = false;
			this.chkNotForJoin.Location = new System.Drawing.Point(191, 99);
			this.chkNotForJoin.Name = "chkNotForJoin";
			this.chkNotForJoin.Size = new System.Drawing.Size(233, 18);
			this.chkNotForJoin.TabIndex = 9;
			this.chkNotForJoin.Text = "Не объединять с другими заказами?";
			this.chkNotForJoin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkNotForJoin.UseVisualStyleBackColor = true;
			// 
			// lblFactureNumber
			// 
			this.lblFactureNumber.AutoSize = true;
			this.lblFactureNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblFactureNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblFactureNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFactureNumber.Location = new System.Drawing.Point(191, 32);
			this.lblFactureNumber.Name = "lblFactureNumber";
			this.lblFactureNumber.Size = new System.Drawing.Size(133, 14);
			this.lblFactureNumber.TabIndex = 4;
			this.lblFactureNumber.Text = "Номер счета-фактуры";
			// 
			// txtFactureNumber
			// 
			this.txtFactureNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtFactureNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtFactureNumber.Enabled = false;
			this.txtFactureNumber.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtFactureNumber.Location = new System.Drawing.Point(329, 28);
			this.txtFactureNumber.Name = "txtFactureNumber";
			this.txtFactureNumber.Size = new System.Drawing.Size(92, 22);
			this.txtFactureNumber.TabIndex = 5;
			// 
			// lblBillNumber
			// 
			this.lblBillNumber.AutoSize = true;
			this.lblBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblBillNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblBillNumber.Location = new System.Drawing.Point(191, 9);
			this.lblBillNumber.Name = "lblBillNumber";
			this.lblBillNumber.Size = new System.Drawing.Size(108, 14);
			this.lblBillNumber.TabIndex = 1;
			this.lblBillNumber.Text = "Номер накладной";
			// 
			// txtBillNumber
			// 
			this.txtBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtBillNumber.Enabled = false;
			this.txtBillNumber.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtBillNumber.Location = new System.Drawing.Point(329, 5);
			this.txtBillNumber.Name = "txtBillNumber";
			this.txtBillNumber.Size = new System.Drawing.Size(92, 22);
			this.txtBillNumber.TabIndex = 2;
			// 
			// chkWarrantNeed
			// 
			this.chkWarrantNeed.AutoSize = true;
			this.chkWarrantNeed.Location = new System.Drawing.Point(10, 76);
			this.chkWarrantNeed.Name = "chkWarrantNeed";
			this.chkWarrantNeed.Size = new System.Drawing.Size(153, 18);
			this.chkWarrantNeed.TabIndex = 7;
			this.chkWarrantNeed.Text = "Нужна доверенность?";
			this.chkWarrantNeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkWarrantNeed.UseVisualStyleBackColor = true;
			// 
			// chkPayBillNeed
			// 
			this.chkPayBillNeed.AutoSize = true;
			this.chkPayBillNeed.Location = new System.Drawing.Point(10, 53);
			this.chkPayBillNeed.Name = "chkPayBillNeed";
			this.chkPayBillNeed.Size = new System.Drawing.Size(160, 18);
			this.chkPayBillNeed.TabIndex = 6;
			this.chkPayBillNeed.Text = "Нужен счет на оплату?";
			this.chkPayBillNeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkPayBillNeed.UseVisualStyleBackColor = true;
			// 
			// chkBillNeed
			// 
			this.chkBillNeed.AutoSize = true;
			this.chkBillNeed.Location = new System.Drawing.Point(10, 7);
			this.chkBillNeed.Name = "chkBillNeed";
			this.chkBillNeed.Size = new System.Drawing.Size(132, 18);
			this.chkBillNeed.TabIndex = 0;
			this.chkBillNeed.Text = "Нужна накладная?";
			this.chkBillNeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkBillNeed.UseVisualStyleBackColor = true;
			this.chkBillNeed.CheckedChanged += new System.EventHandler(this.chkBillNeed_CheckedChanged);
			// 
			// chkFactureNeed
			// 
			this.chkFactureNeed.AutoSize = true;
			this.chkFactureNeed.Location = new System.Drawing.Point(10, 30);
			this.chkFactureNeed.Name = "chkFactureNeed";
			this.chkFactureNeed.Size = new System.Drawing.Size(151, 18);
			this.chkFactureNeed.TabIndex = 3;
			this.chkFactureNeed.Text = "Нужен счет-фактура?";
			this.chkFactureNeed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkFactureNeed.UseVisualStyleBackColor = true;
			this.chkFactureNeed.CheckedChanged += new System.EventHandler(this.chkFactureNeed_CheckedChanged);
			// 
			// chkTPL
			// 
			this.chkTPL.AutoSize = true;
			this.chkTPL.Location = new System.Drawing.Point(10, 99);
			this.chkTPL.Name = "chkTPL";
			this.chkTPL.Size = new System.Drawing.Size(52, 18);
			this.chkTPL.TabIndex = 8;
			this.chkTPL.Text = "3PL?";
			this.chkTPL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkTPL.UseVisualStyleBackColor = true;
			// 
			// frmOutputsDocumentsEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 473);
			this.Controls.Add(this.tcOutputDocument);
			this.Controls.Add(this.pnlTotal);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dgvOutputDocumentGoods);
			this.hpHelp.SetHelpKeyword(this, "221");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmOutputsDocumentsEdit";
			this.PreFormName = "frmGetHost";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Расходный документ (заказ на отгрузку товара)";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmOutputDocumentsEdit_KeyDown);
			this.Load += new System.EventHandler(this.frmOutputsDocumentsEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOutputDocumentGoods)).EndInit();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.tcOutputDocument.ResumeLayout(false);
			this.tabMain.ResumeLayout(false);
			this.pnlMain.ResumeLayout(false);
			this.pnlMain.PerformLayout();
			this.ucSelectRecordIDForm_Buyers.ResumeLayout(false);
			this.ucSelectRecordIDForm_Buyers.PerformLayout();
			this.ucSelectRecordIDForm_Shippers.ResumeLayout(false);
			this.ucSelectRecordIDForm_Shippers.PerformLayout();
			this.ucSelectRecordIDForm_Salers.ResumeLayout(false);
			this.ucSelectRecordIDForm_Salers.PerformLayout();
			this.tabOther.ResumeLayout(false);
			this.pnlOther.ResumeLayout(false);
			this.pnlOther.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvOutputDocumentGoods;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblTotal;
		private RFMBaseClasses.RFMLabel lblTotalQnt;
		private RFMBaseClasses.RFMLabel lblTotalQnt_;
		private RFMBaseClasses.RFMLabel lblTotalBox;
		private RFMBaseClasses.RFMLabel lblTotalBox_;
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
		private RFMBaseClasses.RFMTabControl tcOutputDocument;
		private RFMBaseClasses.RFMTabPage tabMain;
		private RFMBaseClasses.RFMPanel pnlMain;
		private RFMBaseClasses.RFMComboBox cboOwner;
		private RFMBaseClasses.RFMLabel lblBuyer;
		private RFMBaseClasses.RFMLabel lblShipper;
		private RFMBaseClasses.RFMSelectRecordIDForm ucSelectRecordIDForm_Buyers;
		private RFMBaseClasses.RFMSelectRecordIDForm ucSelectRecordIDForm_Shippers;
		private RFMBaseClasses.RFMLabel lblOwner;
		private RFMBaseClasses.RFMSelectRecordIDForm ucSelectRecordIDForm_Salers;
		private RFMBaseClasses.RFMLabel lblSaler;
		private RFMBaseClasses.RFMComboBox cboGoodState;
		private RFMBaseClasses.RFMLabel lblGoodState;
		private RFMBaseClasses.RFMLabel lblOutputType;
		private RFMBaseClasses.RFMLabel lblDateOutput;
		private RFMBaseClasses.RFMComboBox cboOutputDocumentType;
		private RFMBaseClasses.RFMDateTimePicker dtpDateOutputDocument;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMLabel lblCurrency;
		private RFMBaseClasses.RFMComboBox cboCurrency;
		private RFMBaseClasses.RFMCheckBox chkDeliveryNeed;
		private RFMBaseClasses.RFMTabPage tabOther;
		private RFMBaseClasses.RFMPanel pnlOther;
		private RFMBaseClasses.RFMCheckBox chkWarrantNeed;
		private RFMBaseClasses.RFMCheckBox chkPayBillNeed;
		private RFMBaseClasses.RFMCheckBox chkBillNeed;
		private RFMBaseClasses.RFMCheckBox chkFactureNeed;
		private RFMBaseClasses.RFMCheckBox chkTPL;
		private RFMBaseClasses.RFMLabel lblFactureNumber;
		private RFMBaseClasses.RFMTextBox txtFactureNumber;
		private RFMBaseClasses.RFMLabel lblBillNumber;
		private RFMBaseClasses.RFMTextBox txtBillNumber;
		private RFMBaseClasses.RFMCheckBox chkNotForJoin;
	}
}

