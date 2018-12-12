namespace Logistics
{
	partial class frmGoodsQualitiesEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoodsQualitiesEdit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.lblQualityHolder = new RFMBaseClasses.RFMLabel();
            this.txtQualityHolder = new RFMBaseClasses.RFMTextBox();
            this.pnlFilter = new RFMBaseClasses.RFMPanel();
            this.lblInput = new RFMBaseClasses.RFMLabel();
            this.txtInput = new RFMBaseClasses.RFMTextBox();
            this.btnInputClear = new RFMBaseClasses.RFMButton();
            this.btnInputSelect = new RFMBaseClasses.RFMButton();
            this.lblInputDocument = new RFMBaseClasses.RFMLabel();
            this.txtInputDocument = new RFMBaseClasses.RFMTextBox();
            this.btnInputDocumentClear = new RFMBaseClasses.RFMButton();
            this.btnInputDocumentSelect = new RFMBaseClasses.RFMButton();
            this.btnQualityLicenceSelect = new RFMBaseClasses.RFMButton();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.lblDates = new RFMBaseClasses.RFMLabel();
            this.btnDeleteGood = new RFMBaseClasses.RFMButton();
            this.btnAddGood = new RFMBaseClasses.RFMButton();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grсGoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcArticul = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcRetention = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCountryName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodActual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcGoodERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.txtQualityLicence = new RFMBaseClasses.RFMTextBox();
            this.lblQualityLicence = new RFMBaseClasses.RFMLabel();
            this.lblQualityIssuer = new RFMBaseClasses.RFMLabel();
            this.txtQualityIssuer = new RFMBaseClasses.RFMTextBox();
            this.btnQualityLicenceSelectIssuer = new RFMBaseClasses.RFMButton();
            this.btnQualityLicenceSelectHolder = new RFMBaseClasses.RFMButton();
            this.pnlData.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            this.dtrDates.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 395);
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
            this.btnExit.Location = new System.Drawing.Point(545, 395);
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
            this.btnSave.Location = new System.Drawing.Point(495, 395);
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
            this.pnlData.Controls.Add(this.btnQualityLicenceSelectHolder);
            this.pnlData.Controls.Add(this.btnQualityLicenceSelectIssuer);
            this.pnlData.Controls.Add(this.lblQualityHolder);
            this.pnlData.Controls.Add(this.txtQualityHolder);
            this.pnlData.Controls.Add(this.pnlFilter);
            this.pnlData.Controls.Add(this.btnQualityLicenceSelect);
            this.pnlData.Controls.Add(this.dtrDates);
            this.pnlData.Controls.Add(this.lblDates);
            this.pnlData.Controls.Add(this.btnDeleteGood);
            this.pnlData.Controls.Add(this.btnAddGood);
            this.pnlData.Controls.Add(this.grdData);
            this.pnlData.Controls.Add(this.txtQualityLicence);
            this.pnlData.Controls.Add(this.lblQualityLicence);
            this.pnlData.Controls.Add(this.lblQualityIssuer);
            this.pnlData.Controls.Add(this.txtQualityIssuer);
            this.pnlData.Location = new System.Drawing.Point(4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(576, 383);
            this.pnlData.TabIndex = 1;
            // 
            // lblQualityHolder
            // 
            this.lblQualityHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityHolder.AutoSize = true;
            this.lblQualityHolder.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblQualityHolder.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQualityHolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQualityHolder.Location = new System.Drawing.Point(6, 331);
            this.lblQualityHolder.Name = "lblQualityHolder";
            this.lblQualityHolder.Size = new System.Drawing.Size(71, 14);
            this.lblQualityHolder.TabIndex = 42;
            this.lblQualityHolder.Text = "Держатель";
            this.ttToolTip.SetToolTip(this.lblQualityHolder, "Наименование юр. лица, принявшего декларацию");
            // 
            // txtQualityHolder
            // 
            this.txtQualityHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQualityHolder.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtQualityHolder.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQualityHolder.Location = new System.Drawing.Point(102, 328);
            this.txtQualityHolder.MaxLength = 200;
            this.txtQualityHolder.Name = "txtQualityHolder";
            this.txtQualityHolder.Size = new System.Drawing.Size(431, 22);
            this.txtQualityHolder.TabIndex = 3;
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFilter.Controls.Add(this.lblInput);
            this.pnlFilter.Controls.Add(this.txtInput);
            this.pnlFilter.Controls.Add(this.btnInputClear);
            this.pnlFilter.Controls.Add(this.btnInputSelect);
            this.pnlFilter.Controls.Add(this.lblInputDocument);
            this.pnlFilter.Controls.Add(this.txtInputDocument);
            this.pnlFilter.Controls.Add(this.btnInputDocumentClear);
            this.pnlFilter.Controls.Add(this.btnInputDocumentSelect);
            this.pnlFilter.Location = new System.Drawing.Point(102, 209);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(375, 60);
            this.pnlFilter.TabIndex = 41;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblInput.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInput.Location = new System.Drawing.Point(3, 35);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(53, 14);
            this.lblInput.TabIndex = 48;
            this.lblInput.Text = "Задание";
            this.ttToolTip.SetToolTip(this.lblInput, "Задание на приход");
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtInput.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInput.Enabled = false;
            this.txtInput.IsUserDraw = true;
            this.txtInput.Location = new System.Drawing.Point(67, 31);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(245, 22);
            this.txtInput.TabIndex = 47;
            // 
            // btnInputClear
            // 
            this.btnInputClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputClear.FlatAppearance.BorderSize = 0;
            this.btnInputClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnInputClear.Location = new System.Drawing.Point(343, 30);
            this.btnInputClear.Name = "btnInputClear";
            this.btnInputClear.Size = new System.Drawing.Size(25, 25);
            this.btnInputClear.TabIndex = 46;
            this.ttToolTip.SetToolTip(this.btnInputClear, "Отказ от выбора задания на приход");
            this.btnInputClear.UseVisualStyleBackColor = true;
            this.btnInputClear.Click += new System.EventHandler(this.btnInputClear_Click);
            // 
            // btnInputSelect
            // 
            this.btnInputSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputSelect.FlatAppearance.BorderSize = 0;
            this.btnInputSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnInputSelect.Location = new System.Drawing.Point(316, 30);
            this.btnInputSelect.Name = "btnInputSelect";
            this.btnInputSelect.Size = new System.Drawing.Size(25, 25);
            this.btnInputSelect.TabIndex = 45;
            this.ttToolTip.SetToolTip(this.btnInputSelect, "Выбор задания на приход для последующего выбора товаров");
            this.btnInputSelect.UseVisualStyleBackColor = true;
            this.btnInputSelect.Click += new System.EventHandler(this.btnInputSelect_Click);
            // 
            // lblInputDocument
            // 
            this.lblInputDocument.AutoSize = true;
            this.lblInputDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblInputDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInputDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInputDocument.Location = new System.Drawing.Point(3, 8);
            this.lblInputDocument.Name = "lblInputDocument";
            this.lblInputDocument.Size = new System.Drawing.Size(62, 14);
            this.lblInputDocument.TabIndex = 44;
            this.lblInputDocument.Text = "Документ";
            this.ttToolTip.SetToolTip(this.lblInputDocument, "Приходный документ");
            // 
            // txtInputDocument
            // 
            this.txtInputDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInputDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtInputDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInputDocument.Enabled = false;
            this.txtInputDocument.IsUserDraw = true;
            this.txtInputDocument.Location = new System.Drawing.Point(67, 4);
            this.txtInputDocument.Name = "txtInputDocument";
            this.txtInputDocument.Size = new System.Drawing.Size(245, 22);
            this.txtInputDocument.TabIndex = 43;
            // 
            // btnInputDocumentClear
            // 
            this.btnInputDocumentClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputDocumentClear.FlatAppearance.BorderSize = 0;
            this.btnInputDocumentClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputDocumentClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnInputDocumentClear.Location = new System.Drawing.Point(343, 3);
            this.btnInputDocumentClear.Name = "btnInputDocumentClear";
            this.btnInputDocumentClear.Size = new System.Drawing.Size(25, 25);
            this.btnInputDocumentClear.TabIndex = 42;
            this.ttToolTip.SetToolTip(this.btnInputDocumentClear, "Отказ от выбора приходного документа");
            this.btnInputDocumentClear.UseVisualStyleBackColor = true;
            this.btnInputDocumentClear.Click += new System.EventHandler(this.btnInputDocumentClear_Click);
            // 
            // btnInputDocumentSelect
            // 
            this.btnInputDocumentSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputDocumentSelect.FlatAppearance.BorderSize = 0;
            this.btnInputDocumentSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputDocumentSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnInputDocumentSelect.Location = new System.Drawing.Point(316, 3);
            this.btnInputDocumentSelect.Name = "btnInputDocumentSelect";
            this.btnInputDocumentSelect.Size = new System.Drawing.Size(25, 25);
            this.btnInputDocumentSelect.TabIndex = 41;
            this.ttToolTip.SetToolTip(this.btnInputDocumentSelect, "Выбор приходного документа для последующего выбора товаров");
            this.btnInputDocumentSelect.UseVisualStyleBackColor = true;
            this.btnInputDocumentSelect.Click += new System.EventHandler(this.btnInputDocumentSelect_Click);
            // 
            // btnQualityLicenceSelect
            // 
            this.btnQualityLicenceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQualityLicenceSelect.FlatAppearance.BorderSize = 0;
            this.btnQualityLicenceSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityLicenceSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnQualityLicenceSelect.Location = new System.Drawing.Point(539, 276);
            this.btnQualityLicenceSelect.Name = "btnQualityLicenceSelect";
            this.btnQualityLicenceSelect.Size = new System.Drawing.Size(25, 25);
            this.btnQualityLicenceSelect.TabIndex = 40;
            this.ttToolTip.SetToolTip(this.btnQualityLicenceSelect, "Выбрать из ранее введенных значений");
            this.btnQualityLicenceSelect.UseVisualStyleBackColor = true;
            this.btnQualityLicenceSelect.Click += new System.EventHandler(this.btnQualityLicenceSelect_Click);
            // 
            // dtrDates
            // 
            this.dtrDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtrDates.BegValue = new System.DateTime(2007, 7, 31, 0, 0, 0, 0);
            // 
            // dtrDates.btnClear
            // 
            this.dtrDates.BtnСlear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtrDates.BtnСlear.Image = ((System.Drawing.Image)(resources.GetObject("dtrDates.btnClear.Image")));
            this.dtrDates.BtnСlear.Location = new System.Drawing.Point(195, 1);
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
            this.dtrDates.DtpBegDate.Location = new System.Drawing.Point(0, 1);
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
            this.dtrDates.DtpEndDate.Location = new System.Drawing.Point(101, 1);
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
            this.dtrDates.LblDelimiter.Location = new System.Drawing.Point(90, 4);
            this.dtrDates.LblDelimiter.Name = "lblDelimiter";
            this.dtrDates.LblDelimiter.Size = new System.Drawing.Size(13, 16);
            this.dtrDates.LblDelimiter.TabIndex = 1;
            this.dtrDates.LblDelimiter.Text = ":";
            this.dtrDates.Location = new System.Drawing.Point(102, 353);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(222, 24);
            this.dtrDates.TabIndex = 39;
            // 
            // lblDates
            // 
            this.lblDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDates.AutoSize = true;
            this.lblDates.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDates.Location = new System.Drawing.Point(6, 358);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(91, 14);
            this.lblDates.TabIndex = 38;
            this.lblDates.Text = "Срок действия";
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteGood.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDeleteGood.Location = new System.Drawing.Point(537, 209);
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
            this.btnAddGood.Location = new System.Drawing.Point(489, 209);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(32, 30);
            this.btnAddGood.TabIndex = 36;
            this.ttToolTip.SetToolTip(this.btnAddGood, "Добавить товар в список");
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
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
            this.grcGoodAlias,
            this.grсGoodName,
            this.grcGoodBarCode,
            this.grcWeighting,
            this.grcArticul,
            this.grcRetention,
            this.grcNetto,
            this.grcBrutto,
            this.grcGoodGroupName,
            this.grcGoodBrandName,
            this.grcCountryName,
            this.grcGoodActual,
            this.grcGoodERPCode,
            this.grcGoodID});
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
            this.grdData.Location = new System.Drawing.Point(2, 2);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdData.Size = new System.Drawing.Size(568, 200);
            this.grdData.TabIndex = 35;
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
            // 
            // grcGoodAlias
            // 
            this.grcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodAlias.DataPropertyName = "GoodAlias";
            this.grcGoodAlias.HeaderText = "Наименование краткое";
            this.grcGoodAlias.Name = "grcGoodAlias";
            this.grcGoodAlias.ReadOnly = true;
            this.grcGoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodAlias.Width = 200;
            // 
            // grсGoodName
            // 
            this.grсGoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grсGoodName.DataPropertyName = "GoodName";
            this.grсGoodName.HeaderText = "Наименование полное";
            this.grсGoodName.Name = "grсGoodName";
            this.grсGoodName.ReadOnly = true;
            this.grсGoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grсGoodName.Width = 250;
            // 
            // grcGoodBarCode
            // 
            this.grcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodBarCode.DataPropertyName = "GoodBarCode";
            this.grcGoodBarCode.HeaderText = "Штрих-код Товара";
            this.grcGoodBarCode.Name = "grcGoodBarCode";
            this.grcGoodBarCode.ReadOnly = true;
            this.grcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodBarCode.Visible = false;
            this.grcGoodBarCode.Width = 130;
            // 
            // grcWeighting
            // 
            this.grcWeighting.DataPropertyName = "Weighting";
            this.grcWeighting.HeaderText = "Вес";
            this.grcWeighting.Name = "grcWeighting";
            this.grcWeighting.ReadOnly = true;
            this.grcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcWeighting.ToolTipText = "Весовой товар?";
            this.grcWeighting.Visible = false;
            this.grcWeighting.Width = 40;
            // 
            // grcArticul
            // 
            this.grcArticul.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcArticul.DataPropertyName = "Articul";
            this.grcArticul.HeaderText = "Артикул";
            this.grcArticul.Name = "grcArticul";
            this.grcArticul.ReadOnly = true;
            this.grcArticul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcRetention
            // 
            this.grcRetention.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcRetention.DataPropertyName = "Retention";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.grcRetention.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcRetention.HeaderText = "Срок годн.";
            this.grcRetention.Name = "grcRetention";
            this.grcRetention.ReadOnly = true;
            this.grcRetention.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcRetention.ToolTipText = "Срок годности, дней";
            this.grcRetention.Width = 80;
            // 
            // grcNetto
            // 
            this.grcNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNetto.DataPropertyName = "Netto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N3";
            this.grcNetto.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcNetto.HeaderText = "Нетто";
            this.grcNetto.Name = "grcNetto";
            this.grcNetto.ReadOnly = true;
            this.grcNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNetto.ToolTipText = "Вес нетто единицы товара, кг";
            this.grcNetto.Width = 60;
            // 
            // grcBrutto
            // 
            this.grcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcBrutto.DataPropertyName = "Brutto";
            this.grcBrutto.HeaderText = "Брутто";
            this.grcBrutto.Name = "grcBrutto";
            this.grcBrutto.ReadOnly = true;
            this.grcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcBrutto.ToolTipText = "Вес брутто единицы товара, кг";
            this.grcBrutto.Width = 60;
            // 
            // grcGoodGroupName
            // 
            this.grcGoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodGroupName.DataPropertyName = "GoodGroupName";
            this.grcGoodGroupName.HeaderText = "Товарная группа";
            this.grcGoodGroupName.Name = "grcGoodGroupName";
            this.grcGoodGroupName.ReadOnly = true;
            this.grcGoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodGroupName.Width = 150;
            // 
            // grcGoodBrandName
            // 
            this.grcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodBrandName.DataPropertyName = "GoodBrandName";
            this.grcGoodBrandName.HeaderText = "Товарный бренд";
            this.grcGoodBrandName.Name = "grcGoodBrandName";
            this.grcGoodBrandName.ReadOnly = true;
            this.grcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodBrandName.Width = 150;
            // 
            // grcCountryName
            // 
            this.grcCountryName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCountryName.DataPropertyName = "CountryName";
            this.grcCountryName.HeaderText = "Страна";
            this.grcCountryName.Name = "grcCountryName";
            this.grcCountryName.ReadOnly = true;
            this.grcCountryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcGoodActual
            // 
            this.grcGoodActual.DataPropertyName = "GoodActual";
            this.grcGoodActual.HeaderText = "Акт.Товар";
            this.grcGoodActual.Name = "grcGoodActual";
            this.grcGoodActual.ReadOnly = true;
            this.grcGoodActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodActual.ToolTipText = "Товар актуален?";
            this.grcGoodActual.Width = 40;
            // 
            // grcGoodERPCode
            // 
            this.grcGoodERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodERPCode.DataPropertyName = "GoodERPCode";
            this.grcGoodERPCode.HeaderText = "ERPCode Товар";
            this.grcGoodERPCode.Name = "grcGoodERPCode";
            this.grcGoodERPCode.ReadOnly = true;
            this.grcGoodERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodERPCode.ToolTipText = "Код товара в host-системе";
            // 
            // grcGoodID
            // 
            this.grcGoodID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodID.DataPropertyName = "GoodID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcGoodID.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcGoodID.HeaderText = "ID Товар";
            this.grcGoodID.Name = "grcGoodID";
            this.grcGoodID.ReadOnly = true;
            this.grcGoodID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodID.ToolTipText = "Код товара";
            this.grcGoodID.Width = 60;
            // 
            // txtQualityLicence
            // 
            this.txtQualityLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQualityLicence.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtQualityLicence.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQualityLicence.Location = new System.Drawing.Point(102, 276);
            this.txtQualityLicence.MaxLength = 50;
            this.txtQualityLicence.Name = "txtQualityLicence";
            this.txtQualityLicence.Size = new System.Drawing.Size(431, 22);
            this.txtQualityLicence.TabIndex = 1;
            // 
            // lblQualityLicence
            // 
            this.lblQualityLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityLicence.AutoSize = true;
            this.lblQualityLicence.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblQualityLicence.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQualityLicence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQualityLicence.Location = new System.Drawing.Point(6, 279);
            this.lblQualityLicence.Name = "lblQualityLicence";
            this.lblQualityLicence.Size = new System.Drawing.Size(93, 14);
            this.lblQualityLicence.TabIndex = 0;
            this.lblQualityLicence.Text = "Декларация №";
            // 
            // lblQualityIssuer
            // 
            this.lblQualityIssuer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblQualityIssuer.AutoSize = true;
            this.lblQualityIssuer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblQualityIssuer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQualityIssuer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQualityIssuer.Location = new System.Drawing.Point(6, 305);
            this.lblQualityIssuer.Name = "lblQualityIssuer";
            this.lblQualityIssuer.Size = new System.Drawing.Size(67, 14);
            this.lblQualityIssuer.TabIndex = 2;
            this.lblQualityIssuer.Text = "Кем выдан";
            // 
            // txtQualityIssuer
            // 
            this.txtQualityIssuer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQualityIssuer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtQualityIssuer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQualityIssuer.Location = new System.Drawing.Point(102, 302);
            this.txtQualityIssuer.MaxLength = 200;
            this.txtQualityIssuer.Name = "txtQualityIssuer";
            this.txtQualityIssuer.Size = new System.Drawing.Size(431, 22);
            this.txtQualityIssuer.TabIndex = 2;
            // 
            // btnQualityLicenceSelectIssuer
            // 
            this.btnQualityLicenceSelectIssuer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQualityLicenceSelectIssuer.FlatAppearance.BorderSize = 0;
            this.btnQualityLicenceSelectIssuer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityLicenceSelectIssuer.Image = global::Logistics.Properties.Resources.Detail;
            this.btnQualityLicenceSelectIssuer.Location = new System.Drawing.Point(539, 302);
            this.btnQualityLicenceSelectIssuer.Name = "btnQualityLicenceSelectIssuer";
            this.btnQualityLicenceSelectIssuer.Size = new System.Drawing.Size(25, 25);
            this.btnQualityLicenceSelectIssuer.TabIndex = 43;
            this.ttToolTip.SetToolTip(this.btnQualityLicenceSelectIssuer, "Выбрать из ранее введенных значений");
            this.btnQualityLicenceSelectIssuer.UseVisualStyleBackColor = true;
            this.btnQualityLicenceSelectIssuer.Click += new System.EventHandler(this.btnQualityLicenceSelectIssuer_Click);
            // 
            // btnQualityLicenceSelectHolder
            // 
            this.btnQualityLicenceSelectHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQualityLicenceSelectHolder.FlatAppearance.BorderSize = 0;
            this.btnQualityLicenceSelectHolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQualityLicenceSelectHolder.Image = global::Logistics.Properties.Resources.Detail;
            this.btnQualityLicenceSelectHolder.Location = new System.Drawing.Point(539, 328);
            this.btnQualityLicenceSelectHolder.Name = "btnQualityLicenceSelectHolder";
            this.btnQualityLicenceSelectHolder.Size = new System.Drawing.Size(25, 25);
            this.btnQualityLicenceSelectHolder.TabIndex = 44;
            this.ttToolTip.SetToolTip(this.btnQualityLicenceSelectHolder, "Выбрать из ранее введенных значений");
            this.btnQualityLicenceSelectHolder.UseVisualStyleBackColor = true;
            this.btnQualityLicenceSelectHolder.Click += new System.EventHandler(this.btnQualityLicenceSelectHolder_Click);
            // 
            // frmGoodsQualitiesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 431);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmGoodsQualitiesEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Декларация соответствия";
            this.Load += new System.EventHandler(this.frmGoodsQualitiesEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblQualityIssuer;
		private RFMBaseClasses.RFMTextBox txtQualityIssuer;
		private RFMBaseClasses.RFMLabel lblQualityLicence;
		private RFMBaseClasses.RFMTextBox txtQualityLicence;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMButton btnDeleteGood;
		private RFMBaseClasses.RFMButton btnAddGood;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblDates;
		private RFMBaseClasses.RFMButton btnQualityLicenceSelect;
		private RFMBaseClasses.RFMPanel pnlFilter;
		private RFMBaseClasses.RFMButton btnInputDocumentClear;
		private RFMBaseClasses.RFMButton btnInputDocumentSelect;
		private RFMBaseClasses.RFMLabel lblInputDocument;
		private RFMBaseClasses.RFMTextBox txtInputDocument;
		private RFMBaseClasses.RFMLabel lblInput;
		private RFMBaseClasses.RFMTextBox txtInput;
		private RFMBaseClasses.RFMButton btnInputClear;
		private RFMBaseClasses.RFMButton btnInputSelect;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grсGoodName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodBarCode;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcWeighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcArticul;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcRetention;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNetto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcBrutto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCountryName;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcGoodActual;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodID;
        private RFMBaseClasses.RFMLabel lblQualityHolder;
        private RFMBaseClasses.RFMTextBox txtQualityHolder;
        private RFMBaseClasses.RFMButton btnQualityLicenceSelectHolder;
        private RFMBaseClasses.RFMButton btnQualityLicenceSelectIssuer;

	}
}

