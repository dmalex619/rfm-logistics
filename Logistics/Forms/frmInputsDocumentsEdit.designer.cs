namespace Logistics
{
	partial class frmInputsDocumentsEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInputDocumentGoods = new RFMBaseClasses.RFMDataGridView();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlSelectConditions = new RFMBaseClasses.RFMPanel();
            this.txtOwnerName = new RFMBaseClasses.RFMTextBox();
            this.pnlDocuments = new RFMBaseClasses.RFMPanel();
            this.btnBillAmount = new RFMBaseClasses.RFMButton();
            this.chkSaveCustomsNumbers = new RFMBaseClasses.RFMCheckBox();
            this.lblVatAmountBill = new RFMBaseClasses.RFMLabel();
            this.numVatAmountBill = new RFMBaseClasses.RFMNumericUpDown();
            this.cboCurrency = new RFMBaseClasses.RFMComboBox();
            this.lblFactureNumber = new RFMBaseClasses.RFMLabel();
            this.txtFactureNumber = new RFMBaseClasses.RFMTextBox();
            this.lblBillNumber = new RFMBaseClasses.RFMLabel();
            this.lblAmountBill = new RFMBaseClasses.RFMLabel();
            this.dtpDateBill = new RFMBaseClasses.RFMDateTimePicker();
            this.lblDocuments = new RFMBaseClasses.RFMLabel();
            this.numAmountBill = new RFMBaseClasses.RFMNumericUpDown();
            this.txtBillNumber = new RFMBaseClasses.RFMTextBox();
            this.txtManagerName = new RFMBaseClasses.RFMTextBox();
            this.lblNote = new RFMBaseClasses.RFMLabel();
            this.txtNote = new RFMBaseClasses.RFMTextBox();
            this.txtPartnerSourceName = new RFMBaseClasses.RFMTextBox();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.pnlTotal = new RFMBaseClasses.RFMPanel();
            this.lblTotal = new RFMBaseClasses.RFMLabel();
            this.lblTotalQnt = new RFMBaseClasses.RFMLabel();
            this.lblTotalQnt_ = new RFMBaseClasses.RFMLabel();
            this.lblTotalBox = new RFMBaseClasses.RFMLabel();
            this.lblTotalBox_ = new RFMBaseClasses.RFMLabel();
            this.lblTotalAmount = new RFMBaseClasses.RFMLabel();
            this.lblTotalAmount_ = new RFMBaseClasses.RFMLabel();
            this.chkRegister = new RFMBaseClasses.RFMCheckBox();
            this.dgrcByOrder = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcInBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcArticul = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcBoxWished = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcBoxBrought = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgrcQntWished = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcQntBrought = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgrcPrice = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgrcPriceSum = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgrcVat = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgrcCustomNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.dgrcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgrcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputDocumentGoods)).BeginInit();
            this.pnlSelectConditions.SuspendLayout();
            this.pnlDocuments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVatAmountBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountBill)).BeginInit();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInputDocumentGoods
            // 
            this.dgvInputDocumentGoods.AllowUserToAddRows = false;
            this.dgvInputDocumentGoods.AllowUserToDeleteRows = false;
            this.dgvInputDocumentGoods.AllowUserToOrderColumns = true;
            this.dgvInputDocumentGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInputDocumentGoods.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvInputDocumentGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInputDocumentGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInputDocumentGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInputDocumentGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgrcByOrder,
            this.dgrcGoodAlias,
            this.dgrcInBox,
            this.dgrcArticul,
            this.dgrcBoxWished,
            this.dgrcBoxBrought,
            this.dgrcQntWished,
            this.dgrcQntBrought,
            this.dgrcPrice,
            this.dgrcPriceSum,
            this.dgrcVat,
            this.dgrcCustomNumber,
            this.dgrcWeighting,
            this.dgrcGoodBarCode,
            this.dgrcGoodGroupName,
            this.dgrcGoodBrandName,
            this.dgrcID});
            this.dgvInputDocumentGoods.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInputDocumentGoods.IsConfigInclude = true;
            this.dgvInputDocumentGoods.IsMarkedAll = false;
            this.dgvInputDocumentGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvInputDocumentGoods.Location = new System.Drawing.Point(4, 117);
            this.dgvInputDocumentGoods.MultiSelect = false;
            this.dgvInputDocumentGoods.Name = "dgvInputDocumentGoods";
            this.dgvInputDocumentGoods.RangedWay = ' ';
            this.dgvInputDocumentGoods.ReadOnly = true;
            this.dgvInputDocumentGoods.RowHeadersWidth = 24;
            this.dgvInputDocumentGoods.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.dgvInputDocumentGoods.SelectedRowForeColor = System.Drawing.Color.Black;
            this.dgvInputDocumentGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInputDocumentGoods.Size = new System.Drawing.Size(734, 314);
            this.dgvInputDocumentGoods.TabIndex = 0;
            this.dgvInputDocumentGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputDocumentGoods_CellValueChanged);
            this.dgvInputDocumentGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInputDocumentGoods_CellBeginEdit);
            this.dgvInputDocumentGoods.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputDocumentGoods_CellValidated);
            this.dgvInputDocumentGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInputDocumentGoods_CellFormatting);
            this.dgvInputDocumentGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputDocumentGoods_CellEndEdit);
            this.dgvInputDocumentGoods.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInputDocumentGoods_CellEnter);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(6, 438);
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
            this.btnExit.Location = new System.Drawing.Point(704, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Go_Blue;
            this.btnSave.Location = new System.Drawing.Point(654, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить и подтвердить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSelectConditions
            // 
            this.pnlSelectConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectConditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelectConditions.Controls.Add(this.txtOwnerName);
            this.pnlSelectConditions.Controls.Add(this.pnlDocuments);
            this.pnlSelectConditions.Controls.Add(this.txtManagerName);
            this.pnlSelectConditions.Controls.Add(this.lblNote);
            this.pnlSelectConditions.Controls.Add(this.txtNote);
            this.pnlSelectConditions.Controls.Add(this.txtPartnerSourceName);
            this.pnlSelectConditions.Location = new System.Drawing.Point(4, 4);
            this.pnlSelectConditions.Name = "pnlSelectConditions";
            this.pnlSelectConditions.Size = new System.Drawing.Size(734, 110);
            this.pnlSelectConditions.TabIndex = 1;
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtOwnerName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtOwnerName.Enabled = false;
            this.txtOwnerName.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtOwnerName.Location = new System.Drawing.Point(607, 4);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(120, 22);
            this.txtOwnerName.TabIndex = 2;
            // 
            // pnlDocuments
            // 
            this.pnlDocuments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDocuments.Controls.Add(this.btnBillAmount);
            this.pnlDocuments.Controls.Add(this.chkSaveCustomsNumbers);
            this.pnlDocuments.Controls.Add(this.lblVatAmountBill);
            this.pnlDocuments.Controls.Add(this.numVatAmountBill);
            this.pnlDocuments.Controls.Add(this.cboCurrency);
            this.pnlDocuments.Controls.Add(this.lblFactureNumber);
            this.pnlDocuments.Controls.Add(this.txtFactureNumber);
            this.pnlDocuments.Controls.Add(this.lblBillNumber);
            this.pnlDocuments.Controls.Add(this.lblAmountBill);
            this.pnlDocuments.Controls.Add(this.dtpDateBill);
            this.pnlDocuments.Controls.Add(this.lblDocuments);
            this.pnlDocuments.Controls.Add(this.numAmountBill);
            this.pnlDocuments.Controls.Add(this.txtBillNumber);
            this.pnlDocuments.Location = new System.Drawing.Point(4, 50);
            this.pnlDocuments.Name = "pnlDocuments";
            this.pnlDocuments.Size = new System.Drawing.Size(723, 54);
            this.pnlDocuments.TabIndex = 5;
            // 
            // btnBillAmount
            // 
            this.btnBillAmount.FlatAppearance.BorderSize = 0;
            this.btnBillAmount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillAmount.Image = global::Logistics.Properties.Resources.Check;
            this.btnBillAmount.Location = new System.Drawing.Point(78, 25);
            this.btnBillAmount.Name = "btnBillAmount";
            this.btnBillAmount.Size = new System.Drawing.Size(26, 24);
            this.btnBillAmount.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnBillAmount, "Заполнить сумму");
            this.btnBillAmount.UseVisualStyleBackColor = true;
            this.btnBillAmount.Click += new System.EventHandler(this.btnBillAmount_Click);
            // 
            // chkSaveCustomsNumbers
            // 
            this.chkSaveCustomsNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSaveCustomsNumbers.AutoSize = true;
            this.chkSaveCustomsNumbers.Location = new System.Drawing.Point(491, 30);
            this.chkSaveCustomsNumbers.Name = "chkSaveCustomsNumbers";
            this.chkSaveCustomsNumbers.Size = new System.Drawing.Size(157, 18);
            this.chkSaveCustomsNumbers.TabIndex = 12;
            this.chkSaveCustomsNumbers.Text = "Сохранить номера ГТД";
            this.chkSaveCustomsNumbers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttToolTip.SetToolTip(this.chkSaveCustomsNumbers, "Сохранить введенные номера ГТД в справочник");
            this.chkSaveCustomsNumbers.UseVisualStyleBackColor = true;
            // 
            // lblVatAmountBill
            // 
            this.lblVatAmountBill.AutoSize = true;
            this.lblVatAmountBill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVatAmountBill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVatAmountBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVatAmountBill.Location = new System.Drawing.Point(311, 30);
            this.lblVatAmountBill.Name = "lblVatAmountBill";
            this.lblVatAmountBill.Size = new System.Drawing.Size(65, 14);
            this.lblVatAmountBill.TabIndex = 10;
            this.lblVatAmountBill.Text = "в т.ч. НДС";
            // 
            // numVatAmountBill
            // 
            this.numVatAmountBill.DecimalPlaces = 2;
            this.numVatAmountBill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numVatAmountBill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numVatAmountBill.IsNull = false;
            this.numVatAmountBill.Location = new System.Drawing.Point(378, 26);
            this.numVatAmountBill.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numVatAmountBill.Name = "numVatAmountBill";
            this.numVatAmountBill.Size = new System.Drawing.Size(90, 22);
            this.numVatAmountBill.TabIndex = 11;
            this.numVatAmountBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboCurrency.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboCurrency.Location = new System.Drawing.Point(241, 26);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(61, 22);
            this.cboCurrency.TabIndex = 9;
            // 
            // lblFactureNumber
            // 
            this.lblFactureNumber.AutoSize = true;
            this.lblFactureNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFactureNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFactureNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFactureNumber.Location = new System.Drawing.Point(491, 7);
            this.lblFactureNumber.Name = "lblFactureNumber";
            this.lblFactureNumber.Size = new System.Drawing.Size(103, 14);
            this.lblFactureNumber.TabIndex = 4;
            this.lblFactureNumber.Text = "Счет-фактура №";
            // 
            // txtFactureNumber
            // 
            this.txtFactureNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFactureNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtFactureNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFactureNumber.Location = new System.Drawing.Point(597, 3);
            this.txtFactureNumber.MaxLength = 50;
            this.txtFactureNumber.Name = "txtFactureNumber";
            this.txtFactureNumber.Size = new System.Drawing.Size(120, 22);
            this.txtFactureNumber.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.txtFactureNumber, "Примечание по выполнению заказа");
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBillNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBillNumber.Location = new System.Drawing.Point(260, 7);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(85, 14);
            this.lblBillNumber.TabIndex = 2;
            this.lblBillNumber.Text = "Накладная №";
            // 
            // lblAmountBill
            // 
            this.lblAmountBill.AutoSize = true;
            this.lblAmountBill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblAmountBill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAmountBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmountBill.Location = new System.Drawing.Point(105, 30);
            this.lblAmountBill.Name = "lblAmountBill";
            this.lblAmountBill.Size = new System.Drawing.Size(42, 14);
            this.lblAmountBill.TabIndex = 7;
            this.lblAmountBill.Text = "Сумма";
            // 
            // dtpDateBill
            // 
            this.dtpDateBill.CustomFormat = "dd.MM.yyyy";
            this.dtpDateBill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDateBill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDateBill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateBill.Location = new System.Drawing.Point(148, 3);
            this.dtpDateBill.Name = "dtpDateBill";
            this.dtpDateBill.Size = new System.Drawing.Size(90, 22);
            this.dtpDateBill.TabIndex = 1;
            // 
            // lblDocuments
            // 
            this.lblDocuments.AutoSize = true;
            this.lblDocuments.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDocuments.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDocuments.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDocuments.Location = new System.Drawing.Point(3, 7);
            this.lblDocuments.Name = "lblDocuments";
            this.lblDocuments.Size = new System.Drawing.Size(144, 14);
            this.lblDocuments.TabIndex = 0;
            this.lblDocuments.Text = "Документы поставщика:";
            // 
            // numAmountBill
            // 
            this.numAmountBill.DecimalPlaces = 2;
            this.numAmountBill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numAmountBill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numAmountBill.IsNull = false;
            this.numAmountBill.Location = new System.Drawing.Point(148, 26);
            this.numAmountBill.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAmountBill.Name = "numAmountBill";
            this.numAmountBill.Size = new System.Drawing.Size(90, 22);
            this.numAmountBill.TabIndex = 8;
            this.numAmountBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBillNumber.Location = new System.Drawing.Point(348, 3);
            this.txtBillNumber.MaxLength = 50;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(120, 22);
            this.txtBillNumber.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.txtBillNumber, "Примечание по выполнению заказа");
            // 
            // txtManagerName
            // 
            this.txtManagerName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtManagerName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtManagerName.Enabled = false;
            this.txtManagerName.Location = new System.Drawing.Point(245, 4);
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.Size = new System.Drawing.Size(360, 22);
            this.txtManagerName.TabIndex = 1;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNote.Location = new System.Drawing.Point(3, 30);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(78, 14);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Примечание";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(82, 27);
            this.txtNote.MaxLength = 500;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(645, 22);
            this.txtNote.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.txtNote, "Примечание по заказу");
            // 
            // txtPartnerSourceName
            // 
            this.txtPartnerSourceName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPartnerSourceName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartnerSourceName.Enabled = false;
            this.txtPartnerSourceName.Location = new System.Drawing.Point(4, 4);
            this.txtPartnerSourceName.Name = "txtPartnerSourceName";
            this.txtPartnerSourceName.Size = new System.Drawing.Size(240, 22);
            this.txtPartnerSourceName.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(56, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 30);
            this.btnAdd.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnAdd, "Новые товары");
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
            this.pnlTotal.Controls.Add(this.lblTotalAmount);
            this.pnlTotal.Controls.Add(this.lblTotalAmount_);
            this.pnlTotal.Location = new System.Drawing.Point(101, 438);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(473, 30);
            this.pnlTotal.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotal.Location = new System.Drawing.Point(2, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 14);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Итого (док.):";
            // 
            // lblTotalQnt
            // 
            this.lblTotalQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotalQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalQnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalQnt.Location = new System.Drawing.Point(235, 6);
            this.lblTotalQnt.Name = "lblTotalQnt";
            this.lblTotalQnt.Size = new System.Drawing.Size(85, 14);
            this.lblTotalQnt.TabIndex = 5;
            this.lblTotalQnt.Text = "#TotalQnt#";
            // 
            // lblTotalQnt_
            // 
            this.lblTotalQnt_.AutoSize = true;
            this.lblTotalQnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotalQnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalQnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalQnt_.Location = new System.Drawing.Point(199, 6);
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
            this.lblTotalBox.Location = new System.Drawing.Point(120, 6);
            this.lblTotalBox.Name = "lblTotalBox";
            this.lblTotalBox.Size = new System.Drawing.Size(72, 14);
            this.lblTotalBox.TabIndex = 3;
            this.lblTotalBox.Text = "#TotalBox#";
            // 
            // lblTotalBox_
            // 
            this.lblTotalBox_.AutoSize = true;
            this.lblTotalBox_.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotalBox_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalBox_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalBox_.Location = new System.Drawing.Point(88, 6);
            this.lblTotalBox_.Name = "lblTotalBox_";
            this.lblTotalBox_.Size = new System.Drawing.Size(31, 14);
            this.lblTotalBox_.TabIndex = 2;
            this.lblTotalBox_.Text = "кор.";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotalAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalAmount.Location = new System.Drawing.Point(364, 6);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(104, 14);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "#TotalAmount#";
            // 
            // lblTotalAmount_
            // 
            this.lblTotalAmount_.AutoSize = true;
            this.lblTotalAmount_.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotalAmount_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalAmount_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalAmount_.Location = new System.Drawing.Point(321, 6);
            this.lblTotalAmount_.Name = "lblTotalAmount_";
            this.lblTotalAmount_.Size = new System.Drawing.Size(41, 14);
            this.lblTotalAmount_.TabIndex = 0;
            this.lblTotalAmount_.Text = "сумма";
            // 
            // chkRegister
            // 
            this.chkRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRegister.AutoSize = true;
            this.chkRegister.Location = new System.Drawing.Point(586, 445);
            this.chkRegister.Name = "chkRegister";
            this.chkRegister.Size = new System.Drawing.Size(63, 18);
            this.chkRegister.TabIndex = 12;
            this.chkRegister.Text = "подтв.";
            this.chkRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttToolTip.SetToolTip(this.chkRegister, "Регистрировать получение документов");
            this.chkRegister.UseVisualStyleBackColor = true;
            // 
            // dgrcByOrder
            // 
            this.dgrcByOrder.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcByOrder.DataPropertyName = "ByOrder";
            this.dgrcByOrder.HeaderText = "№ п/п";
            this.dgrcByOrder.Name = "dgrcByOrder";
            this.dgrcByOrder.ReadOnly = true;
            this.dgrcByOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcByOrder.Width = 50;
            // 
            // dgrcGoodAlias
            // 
            this.dgrcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcGoodAlias.DataPropertyName = "GoodAlias";
            this.dgrcGoodAlias.HeaderText = "Товар";
            this.dgrcGoodAlias.Name = "dgrcGoodAlias";
            this.dgrcGoodAlias.ReadOnly = true;
            this.dgrcGoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcGoodAlias.Width = 250;
            // 
            // dgrcInBox
            // 
            this.dgrcInBox.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcInBox.DataPropertyName = "InBox";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.dgrcInBox.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrcInBox.HeaderText = "В кор.";
            this.dgrcInBox.Name = "dgrcInBox";
            this.dgrcInBox.ReadOnly = true;
            this.dgrcInBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcInBox.ToolTipText = "Штук/кг в коробке";
            this.dgrcInBox.Width = 50;
            // 
            // dgrcArticul
            // 
            this.dgrcArticul.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcArticul.DataPropertyName = "Articul";
            this.dgrcArticul.HeaderText = "Арт.";
            this.dgrcArticul.Name = "dgrcArticul";
            this.dgrcArticul.ReadOnly = true;
            this.dgrcArticul.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcArticul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcArticul.ToolTipText = "Артикул товара";
            this.dgrcArticul.Width = 50;
            // 
            // dgrcBoxWished
            // 
            this.dgrcBoxWished.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcBoxWished.DataPropertyName = "BoxWished";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N1";
            this.dgrcBoxWished.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrcBoxWished.HeaderText = "Заказ кор.";
            this.dgrcBoxWished.Name = "dgrcBoxWished";
            this.dgrcBoxWished.ReadOnly = true;
            this.dgrcBoxWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcBoxWished.ToolTipText = "Заказано коробок";
            this.dgrcBoxWished.Visible = false;
            this.dgrcBoxWished.Width = 80;
            // 
            // dgrcBoxBrought
            // 
            this.dgrcBoxBrought.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcBoxBrought.DataPropertyName = "BoxBrought";
            this.dgrcBoxBrought.DecimalPlaces = 1;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N1";
            this.dgrcBoxBrought.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgrcBoxBrought.HeaderText = "Док. кор.";
            this.dgrcBoxBrought.Name = "dgrcBoxBrought";
            this.dgrcBoxBrought.ReadOnly = true;
            this.dgrcBoxBrought.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcBoxBrought.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcBoxBrought.ToolTipText = "Коробок по документам поставщика";
            this.dgrcBoxBrought.Width = 80;
            // 
            // dgrcQntWished
            // 
            this.dgrcQntWished.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcQntWished.DataPropertyName = "QntWished";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.dgrcQntWished.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgrcQntWished.HeaderText = "Заказ шт.";
            this.dgrcQntWished.Name = "dgrcQntWished";
            this.dgrcQntWished.ReadOnly = true;
            this.dgrcQntWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcQntWished.ToolTipText = "Заказано штук";
            this.dgrcQntWished.Visible = false;
            this.dgrcQntWished.Width = 90;
            // 
            // dgrcQntBrought
            // 
            this.dgrcQntBrought.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcQntBrought.DataPropertyName = "QntBrought";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.dgrcQntBrought.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrcQntBrought.HeaderText = "Док. шт.";
            this.dgrcQntBrought.Name = "dgrcQntBrought";
            this.dgrcQntBrought.ReadOnly = true;
            this.dgrcQntBrought.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcQntBrought.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcQntBrought.ToolTipText = "Штук  по документам поставщика";
            this.dgrcQntBrought.Width = 90;
            // 
            // dgrcPrice
            // 
            this.dgrcPrice.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcPrice.DataPropertyName = "Price";
            this.dgrcPrice.DecimalPlaces = 4;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N4";
            this.dgrcPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgrcPrice.HeaderText = "Цена";
            this.dgrcPrice.Name = "dgrcPrice";
            this.dgrcPrice.ReadOnly = true;
            this.dgrcPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcPrice.Width = 65;
            // 
            // dgrcPriceSum
            // 
            this.dgrcPriceSum.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcPriceSum.DataPropertyName = "PriceSum";
            this.dgrcPriceSum.DecimalPlaces = 2;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dgrcPriceSum.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgrcPriceSum.HeaderText = "Сумма";
            this.dgrcPriceSum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgrcPriceSum.Name = "dgrcPriceSum";
            this.dgrcPriceSum.ReadOnly = true;
            this.dgrcPriceSum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcPriceSum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcPriceSum.Width = 80;
            // 
            // dgrcVat
            // 
            this.dgrcVat.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcVat.DataPropertyName = "VAT";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "##";
            this.dgrcVat.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgrcVat.HeaderText = "НДС %";
            this.dgrcVat.Name = "dgrcVat";
            this.dgrcVat.ReadOnly = true;
            this.dgrcVat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrcVat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcVat.ToolTipText = "Ставка НДС (0..100), %";
            this.dgrcVat.Width = 52;
            // 
            // dgrcCustomNumber
            // 
            this.dgrcCustomNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcCustomNumber.DataPropertyName = "CustomNumber";
            this.dgrcCustomNumber.HeaderText = "ГТД";
            this.dgrcCustomNumber.Name = "dgrcCustomNumber";
            this.dgrcCustomNumber.ReadOnly = true;
            this.dgrcCustomNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgrcWeighting
            // 
            this.dgrcWeighting.DataPropertyName = "Weighting";
            this.dgrcWeighting.HeaderText = "Вес?";
            this.dgrcWeighting.Name = "dgrcWeighting";
            this.dgrcWeighting.ReadOnly = true;
            this.dgrcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcWeighting.ToolTipText = "Весовой товар?";
            this.dgrcWeighting.Width = 40;
            // 
            // dgrcGoodBarCode
            // 
            this.dgrcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcGoodBarCode.DataPropertyName = "GoodBarCode";
            this.dgrcGoodBarCode.HeaderText = "ШК товара";
            this.dgrcGoodBarCode.Name = "dgrcGoodBarCode";
            this.dgrcGoodBarCode.ReadOnly = true;
            this.dgrcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcGoodBarCode.ToolTipText = "Штрих-код товара";
            this.dgrcGoodBarCode.Width = 130;
            // 
            // dgrcGoodGroupName
            // 
            this.dgrcGoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcGoodGroupName.DataPropertyName = "GoodGroupName";
            this.dgrcGoodGroupName.HeaderText = "Товарная группа";
            this.dgrcGoodGroupName.Name = "dgrcGoodGroupName";
            this.dgrcGoodGroupName.ReadOnly = true;
            this.dgrcGoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcGoodGroupName.Width = 150;
            // 
            // dgrcGoodBrandName
            // 
            this.dgrcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcGoodBrandName.DataPropertyName = "GoodBrandName";
            this.dgrcGoodBrandName.HeaderText = "Товарный бренд";
            this.dgrcGoodBrandName.Name = "dgrcGoodBrandName";
            this.dgrcGoodBrandName.ReadOnly = true;
            this.dgrcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgrcGoodBrandName.Width = 150;
            // 
            // dgrcID
            // 
            this.dgrcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgrcID.DataPropertyName = "InputDocumentGoodID";
            this.dgrcID.HeaderText = "ID";
            this.dgrcID.Name = "dgrcID";
            this.dgrcID.ReadOnly = true;
            this.dgrcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmInputsDocumentsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.chkRegister);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlSelectConditions);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvInputDocumentGoods);
            this.hpHelp.SetHelpKeyword(this, "221");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmInputsDocumentsEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приходный документ (документ поставщика)";
            this.Load += new System.EventHandler(this.frmInputsDocumentsEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmInputsDocumentsEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInputDocumentGoods)).EndInit();
            this.pnlSelectConditions.ResumeLayout(false);
            this.pnlSelectConditions.PerformLayout();
            this.pnlDocuments.ResumeLayout(false);
            this.pnlDocuments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numVatAmountBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmountBill)).EndInit();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvInputDocumentGoods;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlSelectConditions;
		private RFMBaseClasses.RFMTextBox txtPartnerSourceName;
		private RFMBaseClasses.RFMLabel lblDocuments;
		private RFMBaseClasses.RFMTextBox txtBillNumber;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMTextBox txtManagerName;
		private RFMBaseClasses.RFMLabel lblAmountBill;
		private RFMBaseClasses.RFMNumericUpDown numAmountBill;
		private RFMBaseClasses.RFMPanel pnlDocuments;
		private RFMBaseClasses.RFMLabel lblBillNumber;
		private RFMBaseClasses.RFMDateTimePicker dtpDateBill;
		private RFMBaseClasses.RFMLabel lblFactureNumber;
		private RFMBaseClasses.RFMTextBox txtFactureNumber;
		private RFMBaseClasses.RFMComboBox cboCurrency;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMLabel lblVatAmountBill;
		private RFMBaseClasses.RFMNumericUpDown numVatAmountBill;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblTotal;
		private RFMBaseClasses.RFMLabel lblTotalQnt;
		private RFMBaseClasses.RFMLabel lblTotalQnt_;
		private RFMBaseClasses.RFMLabel lblTotalBox;
		private RFMBaseClasses.RFMLabel lblTotalBox_;
		private RFMBaseClasses.RFMLabel lblTotalAmount;
		private RFMBaseClasses.RFMLabel lblTotalAmount_;
        private RFMBaseClasses.RFMCheckBox chkRegister;
        private RFMBaseClasses.RFMCheckBox chkSaveCustomsNumbers;
        private RFMBaseClasses.RFMButton btnBillAmount;
		private RFMBaseClasses.RFMTextBox txtOwnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcByOrder;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcGoodAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcInBox;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcArticul;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcBoxWished;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgrcBoxBrought;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcQntWished;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgrcQntBrought;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgrcPrice;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgrcPriceSum;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgrcVat;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcCustomNumber;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgrcWeighting;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcGoodBarCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcGoodGroupName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcGoodBrandName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgrcID;
	}
}

