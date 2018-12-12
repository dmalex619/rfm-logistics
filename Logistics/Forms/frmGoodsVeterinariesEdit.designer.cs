namespace Logistics
{
	partial class frmGoodsVeterinariesEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.btnForExport = new RFMBaseClasses.RFMButton();
            this.txtVeterinaryDateOfProducing = new RFMBaseClasses.RFMTextBox();
            this.lblVeterinaryDateOfProducing = new RFMBaseClasses.RFMLabel();
            this.chkInList = new RFMBaseClasses.RFMCheckBox();
            this.pnlFilter = new RFMBaseClasses.RFMPanel();
            this.lblInput = new RFMBaseClasses.RFMLabel();
            this.txtInput = new RFMBaseClasses.RFMTextBox();
            this.btnInputClear = new RFMBaseClasses.RFMButton();
            this.btnInputSelect = new RFMBaseClasses.RFMButton();
            this.lblInputDocument = new RFMBaseClasses.RFMLabel();
            this.txtInputDocument = new RFMBaseClasses.RFMTextBox();
            this.btnInputDocumentClear = new RFMBaseClasses.RFMButton();
            this.btnInputDocumentSelect = new RFMBaseClasses.RFMButton();
            this.dtpVeterinaryDateBeg = new RFMBaseClasses.RFMDateTimePicker();
            this.lblVeterinaryLaboratory = new RFMBaseClasses.RFMLabel();
            this.txtVeterinaryLaboratory = new RFMBaseClasses.RFMTextBox();
            this.lblVeterinaryMark = new RFMBaseClasses.RFMLabel();
            this.txtVeterinaryMark = new RFMBaseClasses.RFMTextBox();
            this.lblVeterinaryNote = new RFMBaseClasses.RFMLabel();
            this.txtVeterinaryNote = new RFMBaseClasses.RFMTextBox();
            this.lblVeterinaryName = new RFMBaseClasses.RFMLabel();
            this.txtVeterinaryName = new RFMBaseClasses.RFMTextBox();
            this.btnVeterinaryLicenceSelect = new RFMBaseClasses.RFMButton();
            this.lblVeterinaryDateBeg = new RFMBaseClasses.RFMLabel();
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
            this.txtVeterinaryLicence = new RFMBaseClasses.RFMTextBox();
            this.lblVeterinaryLicence = new RFMBaseClasses.RFMLabel();
            this.lblVeterinaryProducer = new RFMBaseClasses.RFMLabel();
            this.txtVeterinaryProducer = new RFMBaseClasses.RFMTextBox();
            this.pnlData.SuspendLayout();
            this.pnlFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 425);
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
            this.btnExit.Location = new System.Drawing.Point(494, 425);
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
            this.btnSave.Location = new System.Drawing.Point(444, 425);
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
            this.pnlData.Controls.Add(this.btnForExport);
            this.pnlData.Controls.Add(this.txtVeterinaryDateOfProducing);
            this.pnlData.Controls.Add(this.lblVeterinaryDateOfProducing);
            this.pnlData.Controls.Add(this.chkInList);
            this.pnlData.Controls.Add(this.pnlFilter);
            this.pnlData.Controls.Add(this.dtpVeterinaryDateBeg);
            this.pnlData.Controls.Add(this.lblVeterinaryLaboratory);
            this.pnlData.Controls.Add(this.txtVeterinaryLaboratory);
            this.pnlData.Controls.Add(this.lblVeterinaryMark);
            this.pnlData.Controls.Add(this.txtVeterinaryMark);
            this.pnlData.Controls.Add(this.lblVeterinaryNote);
            this.pnlData.Controls.Add(this.txtVeterinaryNote);
            this.pnlData.Controls.Add(this.lblVeterinaryName);
            this.pnlData.Controls.Add(this.txtVeterinaryName);
            this.pnlData.Controls.Add(this.btnVeterinaryLicenceSelect);
            this.pnlData.Controls.Add(this.lblVeterinaryDateBeg);
            this.pnlData.Controls.Add(this.btnDeleteGood);
            this.pnlData.Controls.Add(this.btnAddGood);
            this.pnlData.Controls.Add(this.grdData);
            this.pnlData.Controls.Add(this.txtVeterinaryLicence);
            this.pnlData.Controls.Add(this.lblVeterinaryLicence);
            this.pnlData.Controls.Add(this.lblVeterinaryProducer);
            this.pnlData.Controls.Add(this.txtVeterinaryProducer);
            this.pnlData.Location = new System.Drawing.Point(4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(526, 412);
            this.pnlData.TabIndex = 1;
            // 
            // btnForExport
            // 
            this.btnForExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnForExport.Image = global::Logistics.Properties.Resources.Certificate;
            this.btnForExport.Location = new System.Drawing.Point(486, 208);
            this.btnForExport.Name = "btnForExport";
            this.btnForExport.Size = new System.Drawing.Size(32, 30);
            this.btnForExport.TabIndex = 45;
            this.ttToolTip.SetToolTip(this.btnForExport, "Заполнить данные для экспорта");
            this.btnForExport.UseVisualStyleBackColor = true;
            this.btnForExport.Click += new System.EventHandler(this.btnForExport_Click);
            // 
            // txtVeterinaryDateOfProducing
            // 
            this.txtVeterinaryDateOfProducing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryDateOfProducing.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryDateOfProducing.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryDateOfProducing.Location = new System.Drawing.Point(114, 384);
            this.txtVeterinaryDateOfProducing.MaxLength = 50;
            this.txtVeterinaryDateOfProducing.Name = "txtVeterinaryDateOfProducing";
            this.txtVeterinaryDateOfProducing.Size = new System.Drawing.Size(200, 22);
            this.txtVeterinaryDateOfProducing.TabIndex = 17;
            // 
            // lblVeterinaryDateOfProducing
            // 
            this.lblVeterinaryDateOfProducing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryDateOfProducing.AutoSize = true;
            this.lblVeterinaryDateOfProducing.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryDateOfProducing.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryDateOfProducing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryDateOfProducing.Location = new System.Drawing.Point(5, 388);
            this.lblVeterinaryDateOfProducing.Name = "lblVeterinaryDateOfProducing";
            this.lblVeterinaryDateOfProducing.Size = new System.Drawing.Size(97, 14);
            this.lblVeterinaryDateOfProducing.TabIndex = 44;
            this.lblVeterinaryDateOfProducing.Text = "Дата выработки";
            // 
            // chkInList
            // 
            this.chkInList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkInList.AutoSize = true;
            this.chkInList.Location = new System.Drawing.Point(41, 223);
            this.chkInList.Name = "chkInList";
            this.chkInList.Size = new System.Drawing.Size(197, 18);
            this.chkInList.TabIndex = 43;
            this.chkInList.Text = "только для товаров из списка";
            this.chkInList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkInList.UseVisualStyleBackColor = true;
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
            this.pnlFilter.Location = new System.Drawing.Point(4, 155);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(420, 60);
            this.pnlFilter.TabIndex = 42;
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
            this.txtInput.Size = new System.Drawing.Size(290, 22);
            this.txtInput.TabIndex = 47;
            // 
            // btnInputClear
            // 
            this.btnInputClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputClear.FlatAppearance.BorderSize = 0;
            this.btnInputClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnInputClear.Location = new System.Drawing.Point(388, 30);
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
            this.btnInputSelect.Location = new System.Drawing.Point(361, 30);
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
            this.txtInputDocument.Size = new System.Drawing.Size(290, 22);
            this.txtInputDocument.TabIndex = 43;
            // 
            // btnInputDocumentClear
            // 
            this.btnInputDocumentClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInputDocumentClear.FlatAppearance.BorderSize = 0;
            this.btnInputDocumentClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInputDocumentClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnInputDocumentClear.Location = new System.Drawing.Point(388, 3);
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
            this.btnInputDocumentSelect.Location = new System.Drawing.Point(361, 3);
            this.btnInputDocumentSelect.Name = "btnInputDocumentSelect";
            this.btnInputDocumentSelect.Size = new System.Drawing.Size(25, 25);
            this.btnInputDocumentSelect.TabIndex = 41;
            this.ttToolTip.SetToolTip(this.btnInputDocumentSelect, "Выбор приходного документа для последующего выбора товаров");
            this.btnInputDocumentSelect.UseVisualStyleBackColor = true;
            this.btnInputDocumentSelect.Click += new System.EventHandler(this.btnInputDocumentSelect_Click);
            // 
            // dtpVeterinaryDateBeg
            // 
            this.dtpVeterinaryDateBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpVeterinaryDateBeg.CustomFormat = "dd.MM.yyyy";
            this.dtpVeterinaryDateBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpVeterinaryDateBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpVeterinaryDateBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVeterinaryDateBeg.Location = new System.Drawing.Point(418, 384);
            this.dtpVeterinaryDateBeg.Name = "dtpVeterinaryDateBeg";
            this.dtpVeterinaryDateBeg.Size = new System.Drawing.Size(100, 22);
            this.dtpVeterinaryDateBeg.TabIndex = 19;
            // 
            // lblVeterinaryLaboratory
            // 
            this.lblVeterinaryLaboratory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryLaboratory.AutoSize = true;
            this.lblVeterinaryLaboratory.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryLaboratory.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryLaboratory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryLaboratory.Location = new System.Drawing.Point(5, 364);
            this.lblVeterinaryLaboratory.Name = "lblVeterinaryLaboratory";
            this.lblVeterinaryLaboratory.Size = new System.Drawing.Size(82, 14);
            this.lblVeterinaryLaboratory.TabIndex = 14;
            this.lblVeterinaryLaboratory.Text = "Лаборатория";
            // 
            // txtVeterinaryLaboratory
            // 
            this.txtVeterinaryLaboratory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryLaboratory.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryLaboratory.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryLaboratory.Location = new System.Drawing.Point(114, 361);
            this.txtVeterinaryLaboratory.MaxLength = 200;
            this.txtVeterinaryLaboratory.Name = "txtVeterinaryLaboratory";
            this.txtVeterinaryLaboratory.Size = new System.Drawing.Size(404, 22);
            this.txtVeterinaryLaboratory.TabIndex = 15;
            // 
            // lblVeterinaryMark
            // 
            this.lblVeterinaryMark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryMark.AutoSize = true;
            this.lblVeterinaryMark.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryMark.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryMark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryMark.Location = new System.Drawing.Point(5, 341);
            this.lblVeterinaryMark.Name = "lblVeterinaryMark";
            this.lblVeterinaryMark.Size = new System.Drawing.Size(74, 14);
            this.lblVeterinaryMark.TabIndex = 12;
            this.lblVeterinaryMark.Text = "Маркировка";
            // 
            // txtVeterinaryMark
            // 
            this.txtVeterinaryMark.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryMark.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryMark.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryMark.Location = new System.Drawing.Point(114, 338);
            this.txtVeterinaryMark.MaxLength = 50;
            this.txtVeterinaryMark.Name = "txtVeterinaryMark";
            this.txtVeterinaryMark.Size = new System.Drawing.Size(404, 22);
            this.txtVeterinaryMark.TabIndex = 13;
            // 
            // lblVeterinaryNote
            // 
            this.lblVeterinaryNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryNote.AutoSize = true;
            this.lblVeterinaryNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryNote.Location = new System.Drawing.Point(4, 318);
            this.lblVeterinaryNote.Name = "lblVeterinaryNote";
            this.lblVeterinaryNote.Size = new System.Drawing.Size(75, 14);
            this.lblVeterinaryNote.TabIndex = 10;
            this.lblVeterinaryNote.Text = "Разрешение";
            // 
            // txtVeterinaryNote
            // 
            this.txtVeterinaryNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryNote.Location = new System.Drawing.Point(114, 315);
            this.txtVeterinaryNote.MaxLength = 200;
            this.txtVeterinaryNote.Name = "txtVeterinaryNote";
            this.txtVeterinaryNote.Size = new System.Drawing.Size(404, 22);
            this.txtVeterinaryNote.TabIndex = 11;
            // 
            // lblVeterinaryName
            // 
            this.lblVeterinaryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryName.AutoSize = true;
            this.lblVeterinaryName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryName.Location = new System.Drawing.Point(4, 295);
            this.lblVeterinaryName.Name = "lblVeterinaryName";
            this.lblVeterinaryName.Size = new System.Drawing.Size(90, 14);
            this.lblVeterinaryName.TabIndex = 8;
            this.lblVeterinaryName.Text = "Наименование";
            // 
            // txtVeterinaryName
            // 
            this.txtVeterinaryName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryName.Location = new System.Drawing.Point(114, 292);
            this.txtVeterinaryName.MaxLength = 100;
            this.txtVeterinaryName.Name = "txtVeterinaryName";
            this.txtVeterinaryName.Size = new System.Drawing.Size(404, 22);
            this.txtVeterinaryName.TabIndex = 9;
            // 
            // btnVeterinaryLicenceSelect
            // 
            this.btnVeterinaryLicenceSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVeterinaryLicenceSelect.FlatAppearance.BorderSize = 0;
            this.btnVeterinaryLicenceSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeterinaryLicenceSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnVeterinaryLicenceSelect.Location = new System.Drawing.Point(4, 218);
            this.btnVeterinaryLicenceSelect.Name = "btnVeterinaryLicenceSelect";
            this.btnVeterinaryLicenceSelect.Size = new System.Drawing.Size(25, 25);
            this.btnVeterinaryLicenceSelect.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnVeterinaryLicenceSelect, "Выбрать из ранее введенных значений");
            this.btnVeterinaryLicenceSelect.UseVisualStyleBackColor = true;
            this.btnVeterinaryLicenceSelect.Click += new System.EventHandler(this.btnVeterinaryLicenceSelect_Click);
            // 
            // lblVeterinaryDateBeg
            // 
            this.lblVeterinaryDateBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVeterinaryDateBeg.AutoSize = true;
            this.lblVeterinaryDateBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryDateBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryDateBeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryDateBeg.Location = new System.Drawing.Point(340, 388);
            this.lblVeterinaryDateBeg.Name = "lblVeterinaryDateBeg";
            this.lblVeterinaryDateBeg.Size = new System.Drawing.Size(76, 14);
            this.lblVeterinaryDateBeg.TabIndex = 16;
            this.lblVeterinaryDateBeg.Text = "Дата начала";
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteGood.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDeleteGood.Location = new System.Drawing.Point(486, 157);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteGood.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnDeleteGood, "Удалить товар из списка");
            this.btnDeleteGood.UseVisualStyleBackColor = true;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGood.Image = global::Logistics.Properties.Resources.Add;
            this.btnAddGood.Location = new System.Drawing.Point(438, 157);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(32, 30);
            this.btnAddGood.TabIndex = 1;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            this.grdData.Size = new System.Drawing.Size(518, 150);
            this.grdData.TabIndex = 0;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            this.grcRetention.DefaultCellStyle = dataGridViewCellStyle6;
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N3";
            this.grcNetto.DefaultCellStyle = dataGridViewCellStyle7;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcGoodID.DefaultCellStyle = dataGridViewCellStyle8;
            this.grcGoodID.HeaderText = "ID Товар";
            this.grcGoodID.Name = "grcGoodID";
            this.grcGoodID.ReadOnly = true;
            this.grcGoodID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodID.ToolTipText = "Код товара";
            this.grcGoodID.Width = 60;
            // 
            // txtVeterinaryLicence
            // 
            this.txtVeterinaryLicence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryLicence.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryLicence.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryLicence.Location = new System.Drawing.Point(114, 246);
            this.txtVeterinaryLicence.MaxLength = 50;
            this.txtVeterinaryLicence.Name = "txtVeterinaryLicence";
            this.txtVeterinaryLicence.Size = new System.Drawing.Size(404, 22);
            this.txtVeterinaryLicence.TabIndex = 5;
            // 
            // lblVeterinaryLicence
            // 
            this.lblVeterinaryLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryLicence.AutoSize = true;
            this.lblVeterinaryLicence.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryLicence.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryLicence.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryLicence.Location = new System.Drawing.Point(5, 249);
            this.lblVeterinaryLicence.Name = "lblVeterinaryLicence";
            this.lblVeterinaryLicence.Size = new System.Drawing.Size(110, 14);
            this.lblVeterinaryLicence.TabIndex = 4;
            this.lblVeterinaryLicence.Text = "Свидетельство №";
            // 
            // lblVeterinaryProducer
            // 
            this.lblVeterinaryProducer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVeterinaryProducer.AutoSize = true;
            this.lblVeterinaryProducer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinaryProducer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinaryProducer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinaryProducer.Location = new System.Drawing.Point(4, 272);
            this.lblVeterinaryProducer.Name = "lblVeterinaryProducer";
            this.lblVeterinaryProducer.Size = new System.Drawing.Size(94, 14);
            this.lblVeterinaryProducer.TabIndex = 6;
            this.lblVeterinaryProducer.Text = "Производитель";
            // 
            // txtVeterinaryProducer
            // 
            this.txtVeterinaryProducer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtVeterinaryProducer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinaryProducer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinaryProducer.Location = new System.Drawing.Point(114, 269);
            this.txtVeterinaryProducer.MaxLength = 100;
            this.txtVeterinaryProducer.Name = "txtVeterinaryProducer";
            this.txtVeterinaryProducer.Size = new System.Drawing.Size(404, 22);
            this.txtVeterinaryProducer.TabIndex = 7;
            // 
            // frmGoodsVeterinariesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 461);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmGoodsVeterinariesEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ветеринарное свидетельство";
            this.Load += new System.EventHandler(this.frmGoodsVeterinariesEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblVeterinaryProducer;
		private RFMBaseClasses.RFMTextBox txtVeterinaryProducer;
		private RFMBaseClasses.RFMLabel lblVeterinaryLicence;
		private RFMBaseClasses.RFMTextBox txtVeterinaryLicence;
		private RFMBaseClasses.RFMDataGridView grdData;
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
		private RFMBaseClasses.RFMButton btnDeleteGood;
		private RFMBaseClasses.RFMButton btnAddGood;
		private RFMBaseClasses.RFMLabel lblVeterinaryDateBeg;
		private RFMBaseClasses.RFMButton btnVeterinaryLicenceSelect;
		private RFMBaseClasses.RFMLabel lblVeterinaryLaboratory;
		private RFMBaseClasses.RFMTextBox txtVeterinaryLaboratory;
		private RFMBaseClasses.RFMLabel lblVeterinaryMark;
		private RFMBaseClasses.RFMTextBox txtVeterinaryMark;
		private RFMBaseClasses.RFMLabel lblVeterinaryNote;
		private RFMBaseClasses.RFMTextBox txtVeterinaryNote;
		private RFMBaseClasses.RFMLabel lblVeterinaryName;
		private RFMBaseClasses.RFMTextBox txtVeterinaryName;
		private RFMBaseClasses.RFMDateTimePicker dtpVeterinaryDateBeg;
		private RFMBaseClasses.RFMPanel pnlFilter;
		private RFMBaseClasses.RFMLabel lblInput;
		private RFMBaseClasses.RFMTextBox txtInput;
		private RFMBaseClasses.RFMButton btnInputClear;
		private RFMBaseClasses.RFMButton btnInputSelect;
		private RFMBaseClasses.RFMLabel lblInputDocument;
		private RFMBaseClasses.RFMTextBox txtInputDocument;
		private RFMBaseClasses.RFMButton btnInputDocumentClear;
		private RFMBaseClasses.RFMButton btnInputDocumentSelect;
		private RFMBaseClasses.RFMCheckBox chkInList;
        private RFMBaseClasses.RFMTextBox txtVeterinaryDateOfProducing;
        private RFMBaseClasses.RFMLabel lblVeterinaryDateOfProducing;
        private RFMBaseClasses.RFMButton btnForExport;

	}
}

