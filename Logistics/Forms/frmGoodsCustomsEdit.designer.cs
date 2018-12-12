namespace Logistics
{
	partial class frmGoodCustomsEdit
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlData = new RFMBaseClasses.RFMPanel();
			this.dtpDateBeg = new RFMBaseClasses.RFMDateTimePicker();
			this.btnCustonsSelect = new RFMBaseClasses.RFMButton();
			this.lblDate = new RFMBaseClasses.RFMLabel();
			this.btnDeleteGood = new RFMBaseClasses.RFMButton();
			this.btnAddGood = new RFMBaseClasses.RFMButton();
			this.dgvData = new RFMBaseClasses.RFMDataGridView();
			this.txtCustomNumber = new RFMBaseClasses.RFMTextBox();
			this.lblCustomNumber = new RFMBaseClasses.RFMLabel();
			this.dgvcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvсGoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcArticul = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcRetention = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcCountryName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodActual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcGoodERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.pnlData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(7, 297);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(32, 30);
			this.btnHelp.TabIndex = 0;
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
			this.btnExit.Location = new System.Drawing.Point(453, 297);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 30);
			this.btnExit.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Image = global::Logistics.Properties.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(403, 297);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 30);
			this.btnSave.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlData
			// 
			this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlData.Controls.Add(this.dtpDateBeg);
			this.pnlData.Controls.Add(this.btnCustonsSelect);
			this.pnlData.Controls.Add(this.lblDate);
			this.pnlData.Controls.Add(this.btnDeleteGood);
			this.pnlData.Controls.Add(this.btnAddGood);
			this.pnlData.Controls.Add(this.dgvData);
			this.pnlData.Controls.Add(this.txtCustomNumber);
			this.pnlData.Controls.Add(this.lblCustomNumber);
			this.pnlData.Location = new System.Drawing.Point(4, 5);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(484, 285);
			this.pnlData.TabIndex = 1;
			// 
			// dtpDateBeg
			// 
			this.dtpDateBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.dtpDateBeg.CustomFormat = "dd.MM.yyyy";
			this.dtpDateBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateBeg.Location = new System.Drawing.Point(87, 231);
			this.dtpDateBeg.Name = "dtpDateBeg";
			this.dtpDateBeg.Size = new System.Drawing.Size(96, 22);
			this.dtpDateBeg.TabIndex = 41;
			// 
			// btnCustonsSelect
			// 
			this.btnCustonsSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCustonsSelect.FlatAppearance.BorderSize = 0;
			this.btnCustonsSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCustonsSelect.Image = global::Logistics.Properties.Resources.Detail;
			this.btnCustonsSelect.Location = new System.Drawing.Point(5, 205);
			this.btnCustonsSelect.Name = "btnCustonsSelect";
			this.btnCustonsSelect.Size = new System.Drawing.Size(25, 25);
			this.btnCustonsSelect.TabIndex = 40;
			this.ttToolTip.SetToolTip(this.btnCustonsSelect, "Выбрать из ранее введенных значений");
			this.btnCustonsSelect.UseVisualStyleBackColor = true;
			this.btnCustonsSelect.Click += new System.EventHandler(this.btnCustomNumberSelect_Click);
			// 
			// lblDate
			// 
			this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblDate.AutoSize = true;
			this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDate.Location = new System.Drawing.Point(5, 235);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(76, 14);
			this.lblDate.TabIndex = 38;
			this.lblDate.Text = "Дата начала";
			// 
			// btnDeleteGood
			// 
			this.btnDeleteGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteGood.Image = global::Logistics.Properties.Resources.Delete;
			this.btnDeleteGood.Location = new System.Drawing.Point(445, 204);
			this.btnDeleteGood.Name = "btnDeleteGood";
			this.btnDeleteGood.Size = new System.Drawing.Size(32, 30);
			this.btnDeleteGood.TabIndex = 37;
			this.ttToolTip.SetToolTip(this.btnDeleteGood, "Удалить товар из списка");
			this.btnDeleteGood.UseVisualStyleBackColor = true;
			this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
			// 
			// btnAddGood
			// 
			this.btnAddGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddGood.Image = global::Logistics.Properties.Resources.Add;
			this.btnAddGood.Location = new System.Drawing.Point(397, 204);
			this.btnAddGood.Name = "btnAddGood";
			this.btnAddGood.Size = new System.Drawing.Size(32, 30);
			this.btnAddGood.TabIndex = 36;
			this.ttToolTip.SetToolTip(this.btnAddGood, "Добавить товар в список");
			this.btnAddGood.UseVisualStyleBackColor = true;
			this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToOrderColumns = true;
			this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcGoodAlias,
            this.dgvсGoodName,
            this.dgvcGoodBarCode,
            this.dgvcWeighting,
            this.dgvcArticul,
            this.dgvcRetention,
            this.dgvcNetto,
            this.dgvcBrutto,
            this.dgvcGoodGroupName,
            this.dgvcGoodBrandName,
            this.dgvcCountryName,
            this.dgvcGoodActual,
            this.dgvcGoodERPCode,
            this.dgvcGoodID});
			this.dgvData.IsCheckerInclude = true;
			this.dgvData.IsConfigInclude = true;
			this.dgvData.IsMarkedAll = false;
			this.dgvData.IsStatusInclude = true;
			this.dgvData.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvData.Location = new System.Drawing.Point(2, 2);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.RangedWay = ' ';
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersWidth = 24;
			this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.Size = new System.Drawing.Size(476, 197);
			this.dgvData.TabIndex = 35;
			this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
			// 
			// txtCustomNumber
			// 
			this.txtCustomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCustomNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCustomNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCustomNumber.Location = new System.Drawing.Point(87, 256);
			this.txtCustomNumber.MaxLength = 50;
			this.txtCustomNumber.Name = "txtCustomNumber";
			this.txtCustomNumber.Size = new System.Drawing.Size(390, 22);
			this.txtCustomNumber.TabIndex = 1;
			// 
			// lblCustomNumber
			// 
			this.lblCustomNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCustomNumber.AutoSize = true;
			this.lblCustomNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCustomNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCustomNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCustomNumber.Location = new System.Drawing.Point(5, 260);
			this.lblCustomNumber.Name = "lblCustomNumber";
			this.lblCustomNumber.Size = new System.Drawing.Size(47, 14);
			this.lblCustomNumber.TabIndex = 0;
			this.lblCustomNumber.Text = "ГТД №";
			// 
			// dgvcGoodAlias
			// 
			this.dgvcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodAlias.DataPropertyName = "GoodAlias";
			this.dgvcGoodAlias.HeaderText = "Наименование краткое";
			this.dgvcGoodAlias.Name = "dgvcGoodAlias";
			this.dgvcGoodAlias.ReadOnly = true;
			this.dgvcGoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodAlias.Width = 200;
			// 
			// dgvсGoodName
			// 
			this.dgvсGoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvсGoodName.DataPropertyName = "GoodName";
			this.dgvсGoodName.HeaderText = "Наименование полное";
			this.dgvсGoodName.Name = "dgvсGoodName";
			this.dgvсGoodName.ReadOnly = true;
			this.dgvсGoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvсGoodName.Width = 250;
			// 
			// dgvcGoodBarCode
			// 
			this.dgvcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBarCode.DataPropertyName = "GoodBarCode";
			this.dgvcGoodBarCode.HeaderText = "Штрих-код Товара";
			this.dgvcGoodBarCode.Name = "dgvcGoodBarCode";
			this.dgvcGoodBarCode.ReadOnly = true;
			this.dgvcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBarCode.Visible = false;
			this.dgvcGoodBarCode.Width = 130;
			// 
			// dgvcWeighting
			// 
			this.dgvcWeighting.DataPropertyName = "Weighting";
			this.dgvcWeighting.HeaderText = "Вес";
			this.dgvcWeighting.Name = "dgvcWeighting";
			this.dgvcWeighting.ReadOnly = true;
			this.dgvcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcWeighting.ToolTipText = "Весовой товар?";
			this.dgvcWeighting.Visible = false;
			this.dgvcWeighting.Width = 40;
			// 
			// dgvcArticul
			// 
			this.dgvcArticul.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcArticul.DataPropertyName = "Articul";
			this.dgvcArticul.HeaderText = "Артикул";
			this.dgvcArticul.Name = "dgvcArticul";
			this.dgvcArticul.ReadOnly = true;
			this.dgvcArticul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// dgvcRetention
			// 
			this.dgvcRetention.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcRetention.DataPropertyName = "Retention";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "N0";
			this.dgvcRetention.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvcRetention.HeaderText = "Срок годн.";
			this.dgvcRetention.Name = "dgvcRetention";
			this.dgvcRetention.ReadOnly = true;
			this.dgvcRetention.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcRetention.ToolTipText = "Срок годности, дней";
			this.dgvcRetention.Width = 80;
			// 
			// dgvcNetto
			// 
			this.dgvcNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcNetto.DataPropertyName = "Netto";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "N3";
			this.dgvcNetto.DefaultCellStyle = dataGridViewCellStyle10;
			this.dgvcNetto.HeaderText = "Нетто";
			this.dgvcNetto.Name = "dgvcNetto";
			this.dgvcNetto.ReadOnly = true;
			this.dgvcNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcNetto.ToolTipText = "Вес нетто единицы товара, кг";
			this.dgvcNetto.Width = 60;
			// 
			// dgvcBrutto
			// 
			this.dgvcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcBrutto.DataPropertyName = "Brutto";
			this.dgvcBrutto.HeaderText = "Брутто";
			this.dgvcBrutto.Name = "dgvcBrutto";
			this.dgvcBrutto.ReadOnly = true;
			this.dgvcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcBrutto.ToolTipText = "Вес брутто единицы товара, кг";
			this.dgvcBrutto.Width = 60;
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
			// dgvcCountryName
			// 
			this.dgvcCountryName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcCountryName.DataPropertyName = "CountryName";
			this.dgvcCountryName.HeaderText = "Страна";
			this.dgvcCountryName.Name = "dgvcCountryName";
			this.dgvcCountryName.ReadOnly = true;
			this.dgvcCountryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// dgvcGoodActual
			// 
			this.dgvcGoodActual.DataPropertyName = "GoodActual";
			this.dgvcGoodActual.HeaderText = "Акт.Товар";
			this.dgvcGoodActual.Name = "dgvcGoodActual";
			this.dgvcGoodActual.ReadOnly = true;
			this.dgvcGoodActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodActual.ToolTipText = "Товар актуален?";
			this.dgvcGoodActual.Width = 40;
			// 
			// dgvcGoodERPCode
			// 
			this.dgvcGoodERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodERPCode.DataPropertyName = "GoodERPCode";
			this.dgvcGoodERPCode.HeaderText = "ERPCode Товар";
			this.dgvcGoodERPCode.Name = "dgvcGoodERPCode";
			this.dgvcGoodERPCode.ReadOnly = true;
			this.dgvcGoodERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodERPCode.ToolTipText = "Код товара в host-системе";
			// 
			// dgvcGoodID
			// 
			this.dgvcGoodID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodID.DataPropertyName = "GoodID";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcGoodID.DefaultCellStyle = dataGridViewCellStyle11;
			this.dgvcGoodID.HeaderText = "ID Товар";
			this.dgvcGoodID.Name = "dgvcGoodID";
			this.dgvcGoodID.ReadOnly = true;
			this.dgvcGoodID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodID.ToolTipText = "Код товара";
			this.dgvcGoodID.Width = 60;
			// 
			// frmGoodCustomsEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 333);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.hpHelp.SetHelpKeyword(this, "");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmGoodCustomsEdit";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ГТД";
			this.Load += new System.EventHandler(this.frmGoodsCustomsEdit_Load);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblCustomNumber;
		private RFMBaseClasses.RFMTextBox txtCustomNumber;
        private RFMBaseClasses.RFMDataGridView dgvData;
		private RFMBaseClasses.RFMButton btnDeleteGood;
        private RFMBaseClasses.RFMButton btnAddGood;
		private RFMBaseClasses.RFMLabel lblDate;
        private RFMBaseClasses.RFMButton btnCustonsSelect;
		private RFMBaseClasses.RFMDateTimePicker dtpDateBeg;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvсGoodName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBarCode;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcWeighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcArticul;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcRetention;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcNetto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcBrutto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcCountryName;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcGoodActual;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodID;

	}
}

