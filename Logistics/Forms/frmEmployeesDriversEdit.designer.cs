namespace Logistics
{
	partial class frmEmployeesDriversEdit
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
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.chkPassConfirmAllowed = new RFMBaseClasses.RFMCheckBox();
            this.lblMobPhone = new RFMBaseClasses.RFMLabel();
            this.txtMobPhone = new RFMBaseClasses.RFMTextBox();
            this.pnlDriver = new RFMBaseClasses.RFMPanel();
            this.lblZone = new RFMBaseClasses.RFMLabel();
            this.cboZone = new RFMBaseClasses.RFMComboBox();
            this.lblCar = new RFMBaseClasses.RFMLabel();
            this.chkForGoodsOnly = new RFMBaseClasses.RFMCheckBox();
            this.cboCar = new RFMBaseClasses.RFMComboBox();
            this.txtDriverLicenceNumber = new RFMBaseClasses.RFMTextBox();
            this.lblDriverLicenceNumber = new RFMBaseClasses.RFMLabel();
            this.chkOperable = new RFMBaseClasses.RFMCheckBox();
            this.txtDriverCategory = new RFMBaseClasses.RFMTextBox();
            this.lblDriverCategory = new RFMBaseClasses.RFMLabel();
            this.lblJobTitle = new RFMBaseClasses.RFMLabel();
            this.cboJobTitle = new RFMBaseClasses.RFMComboBox();
            this.lblPassportGranted = new RFMBaseClasses.RFMLabel();
            this.dtpPassportDate = new RFMBaseClasses.RFMDateTimePicker();
            this.lblPassportDate = new RFMBaseClasses.RFMLabel();
            this.lblPassportNumber = new RFMBaseClasses.RFMLabel();
            this.txtPassportNumber = new RFMBaseClasses.RFMTextBox();
            this.lblAlias = new RFMBaseClasses.RFMLabel();
            this.txtAlias = new RFMBaseClasses.RFMTextBox();
            this.txtNаme = new RFMBaseClasses.RFMTextBox();
            this.lblName = new RFMBaseClasses.RFMLabel();
            this.lblPassportSeries = new RFMBaseClasses.RFMLabel();
            this.lblPassport = new RFMBaseClasses.RFMLabel();
            this.txtPassportGranted = new RFMBaseClasses.RFMTextBox();
            this.txtPassportSeries = new RFMBaseClasses.RFMTextBox();
            this.chkIsDriver = new RFMBaseClasses.RFMCheckBox();
            this.chkActual = new RFMBaseClasses.RFMCheckBox();
            this.lblPhoto = new RFMBaseClasses.RFMLabel();
            this.picPhoto = new RFMBaseClasses.RFMPictureBox();
            this.btnLoadPhoto = new RFMBaseClasses.RFMButton();
            this.btnClearPhoto = new RFMBaseClasses.RFMButton();
            this.pnlData.SuspendLayout();
            this.pnlDriver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 337);
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
            this.btnExit.Location = new System.Drawing.Point(653, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(603, 337);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 6;
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
            this.pnlData.Controls.Add(this.chkPassConfirmAllowed);
            this.pnlData.Controls.Add(this.lblMobPhone);
            this.pnlData.Controls.Add(this.txtMobPhone);
            this.pnlData.Controls.Add(this.pnlDriver);
            this.pnlData.Controls.Add(this.lblJobTitle);
            this.pnlData.Controls.Add(this.cboJobTitle);
            this.pnlData.Controls.Add(this.lblPassportGranted);
            this.pnlData.Controls.Add(this.dtpPassportDate);
            this.pnlData.Controls.Add(this.lblPassportDate);
            this.pnlData.Controls.Add(this.lblPassportNumber);
            this.pnlData.Controls.Add(this.txtPassportNumber);
            this.pnlData.Controls.Add(this.lblAlias);
            this.pnlData.Controls.Add(this.txtAlias);
            this.pnlData.Controls.Add(this.txtNаme);
            this.pnlData.Controls.Add(this.lblName);
            this.pnlData.Controls.Add(this.lblPassportSeries);
            this.pnlData.Controls.Add(this.lblPassport);
            this.pnlData.Controls.Add(this.txtPassportGranted);
            this.pnlData.Controls.Add(this.txtPassportSeries);
            this.pnlData.Controls.Add(this.chkIsDriver);
            this.pnlData.Controls.Add(this.chkActual);
            this.pnlData.Controls.Add(this.lblPhoto);
            this.pnlData.Controls.Add(this.picPhoto);
            this.pnlData.Location = new System.Drawing.Point(6, 6);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(680, 324);
            this.pnlData.TabIndex = 0;
            // 
            // chkPassConfirmAllowed
            // 
            this.chkPassConfirmAllowed.AutoSize = true;
            this.chkPassConfirmAllowed.Location = new System.Drawing.Point(158, 184);
            this.chkPassConfirmAllowed.Name = "chkPassConfirmAllowed";
            this.chkPassConfirmAllowed.Size = new System.Drawing.Size(284, 18);
            this.chkPassConfirmAllowed.TabIndex = 19;
            this.chkPassConfirmAllowed.Text = "Утверждает пропуск на въезд/выезд машины";
            this.chkPassConfirmAllowed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkPassConfirmAllowed.UseVisualStyleBackColor = true;
            // 
            // lblMobPhone
            // 
            this.lblMobPhone.AutoSize = true;
            this.lblMobPhone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblMobPhone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMobPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMobPhone.Location = new System.Drawing.Point(149, 159);
            this.lblMobPhone.Name = "lblMobPhone";
            this.lblMobPhone.Size = new System.Drawing.Size(85, 14);
            this.lblMobPhone.TabIndex = 17;
            this.lblMobPhone.Text = "Моб.телефон";
            // 
            // txtMobPhone
            // 
            this.txtMobPhone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtMobPhone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMobPhone.Location = new System.Drawing.Point(252, 156);
            this.txtMobPhone.MaxLength = 50;
            this.txtMobPhone.Name = "txtMobPhone";
            this.txtMobPhone.Size = new System.Drawing.Size(420, 22);
            this.txtMobPhone.TabIndex = 18;
            // 
            // pnlDriver
            // 
            this.pnlDriver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDriver.Controls.Add(this.lblZone);
            this.pnlDriver.Controls.Add(this.cboZone);
            this.pnlDriver.Controls.Add(this.lblCar);
            this.pnlDriver.Controls.Add(this.chkForGoodsOnly);
            this.pnlDriver.Controls.Add(this.cboCar);
            this.pnlDriver.Controls.Add(this.txtDriverLicenceNumber);
            this.pnlDriver.Controls.Add(this.lblDriverLicenceNumber);
            this.pnlDriver.Controls.Add(this.chkOperable);
            this.pnlDriver.Controls.Add(this.txtDriverCategory);
            this.pnlDriver.Controls.Add(this.lblDriverCategory);
            this.pnlDriver.Location = new System.Drawing.Point(149, 232);
            this.pnlDriver.Name = "pnlDriver";
            this.pnlDriver.Size = new System.Drawing.Size(523, 84);
            this.pnlDriver.TabIndex = 21;
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblZone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblZone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZone.Location = new System.Drawing.Point(288, 57);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(33, 14);
            this.lblZone.TabIndex = 8;
            this.lblZone.Text = "Зона";
            // 
            // cboZone
            // 
            this.cboZone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboZone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboZone.FormattingEnabled = true;
            this.cboZone.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboZone.Location = new System.Drawing.Point(324, 53);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(190, 22);
            this.cboZone.TabIndex = 9;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCar.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCar.Location = new System.Drawing.Point(271, 31);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(50, 14);
            this.lblCar.TabIndex = 4;
            this.lblCar.Text = "Машина";
            // 
            // chkForGoodsOnly
            // 
            this.chkForGoodsOnly.AutoSize = true;
            this.chkForGoodsOnly.Location = new System.Drawing.Point(101, 4);
            this.chkForGoodsOnly.Name = "chkForGoodsOnly";
            this.chkForGoodsOnly.Size = new System.Drawing.Size(134, 18);
            this.chkForGoodsOnly.TabIndex = 1;
            this.chkForGoodsOnly.Text = "Доставляет товар?";
            this.chkForGoodsOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkForGoodsOnly.UseVisualStyleBackColor = true;
            // 
            // cboCar
            // 
            this.cboCar.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboCar.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCar.FormattingEnabled = true;
            this.cboCar.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboCar.Location = new System.Drawing.Point(324, 27);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(190, 22);
            this.cboCar.TabIndex = 5;
            // 
            // txtDriverLicenceNumber
            // 
            this.txtDriverLicenceNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriverLicenceNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriverLicenceNumber.Location = new System.Drawing.Point(101, 53);
            this.txtDriverLicenceNumber.MaxLength = 20;
            this.txtDriverLicenceNumber.Name = "txtDriverLicenceNumber";
            this.txtDriverLicenceNumber.Size = new System.Drawing.Size(150, 22);
            this.txtDriverLicenceNumber.TabIndex = 7;
            // 
            // lblDriverLicenceNumber
            // 
            this.lblDriverLicenceNumber.AutoSize = true;
            this.lblDriverLicenceNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverLicenceNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverLicenceNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverLicenceNumber.Location = new System.Drawing.Point(4, 57);
            this.lblDriverLicenceNumber.Name = "lblDriverLicenceNumber";
            this.lblDriverLicenceNumber.Size = new System.Drawing.Size(95, 14);
            this.lblDriverLicenceNumber.TabIndex = 6;
            this.lblDriverLicenceNumber.Text = "Удостоверение";
            // 
            // chkOperable
            // 
            this.chkOperable.AutoSize = true;
            this.chkOperable.Location = new System.Drawing.Point(7, 4);
            this.chkOperable.Name = "chkOperable";
            this.chkOperable.Size = new System.Drawing.Size(84, 18);
            this.chkOperable.TabIndex = 0;
            this.chkOperable.Text = "Работает?";
            this.chkOperable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkOperable.UseVisualStyleBackColor = true;
            // 
            // txtDriverCategory
            // 
            this.txtDriverCategory.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriverCategory.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriverCategory.Location = new System.Drawing.Point(101, 27);
            this.txtDriverCategory.MaxLength = 10;
            this.txtDriverCategory.Name = "txtDriverCategory";
            this.txtDriverCategory.Size = new System.Drawing.Size(150, 22);
            this.txtDriverCategory.TabIndex = 3;
            // 
            // lblDriverCategory
            // 
            this.lblDriverCategory.AutoSize = true;
            this.lblDriverCategory.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverCategory.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverCategory.Location = new System.Drawing.Point(4, 31);
            this.lblDriverCategory.Name = "lblDriverCategory";
            this.lblDriverCategory.Size = new System.Drawing.Size(66, 14);
            this.lblDriverCategory.TabIndex = 2;
            this.lblDriverCategory.Text = "Категория";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblJobTitle.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblJobTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJobTitle.Location = new System.Drawing.Point(149, 131);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(71, 14);
            this.lblJobTitle.TabIndex = 15;
            this.lblJobTitle.Text = "Должность";
            // 
            // cboJobTitle
            // 
            this.cboJobTitle.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboJobTitle.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboJobTitle.FormattingEnabled = true;
            this.cboJobTitle.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboJobTitle.Location = new System.Drawing.Point(252, 128);
            this.cboJobTitle.Name = "cboJobTitle";
            this.cboJobTitle.Size = new System.Drawing.Size(233, 22);
            this.cboJobTitle.TabIndex = 16;
            // 
            // lblPassportGranted
            // 
            this.lblPassportGranted.AutoSize = true;
            this.lblPassportGranted.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPassportGranted.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPassportGranted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassportGranted.Location = new System.Drawing.Point(162, 102);
            this.lblPassportGranted.Name = "lblPassportGranted";
            this.lblPassportGranted.Size = new System.Drawing.Size(86, 14);
            this.lblPassportGranted.TabIndex = 13;
            this.lblPassportGranted.Text = "место выдачи";
            // 
            // dtpPassportDate
            // 
            this.dtpPassportDate.CustomFormat = "dd.MM.yyyy";
            this.dtpPassportDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpPassportDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpPassportDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPassportDate.Location = new System.Drawing.Point(572, 73);
            this.dtpPassportDate.Name = "dtpPassportDate";
            this.dtpPassportDate.Size = new System.Drawing.Size(100, 22);
            this.dtpPassportDate.TabIndex = 12;
            // 
            // lblPassportDate
            // 
            this.lblPassportDate.AutoSize = true;
            this.lblPassportDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPassportDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPassportDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassportDate.Location = new System.Drawing.Point(494, 77);
            this.lblPassportDate.Name = "lblPassportDate";
            this.lblPassportDate.Size = new System.Drawing.Size(77, 14);
            this.lblPassportDate.TabIndex = 11;
            this.lblPassportDate.Text = "дата выдачи";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPassportNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPassportNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassportNumber.Location = new System.Drawing.Point(361, 77);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(21, 14);
            this.lblPassportNumber.TabIndex = 9;
            this.lblPassportNumber.Text = "№";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPassportNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassportNumber.Location = new System.Drawing.Point(385, 74);
            this.txtPassportNumber.MaxLength = 50;
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPassportNumber.TabIndex = 10;
            // 
            // lblAlias
            // 
            this.lblAlias.AutoSize = true;
            this.lblAlias.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblAlias.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAlias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlias.Location = new System.Drawing.Point(148, 32);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(104, 14);
            this.lblAlias.TabIndex = 3;
            this.lblAlias.Text = "ФИО (инициалы)";
            // 
            // txtAlias
            // 
            this.txtAlias.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtAlias.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlias.Location = new System.Drawing.Point(252, 29);
            this.txtAlias.MaxLength = 50;
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(233, 22);
            this.txtAlias.TabIndex = 4;
            // 
            // txtNаme
            // 
            this.txtNаme.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNаme.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNаme.Location = new System.Drawing.Point(252, 4);
            this.txtNаme.MaxLength = 100;
            this.txtNаme.Name = "txtNаme";
            this.txtNаme.Size = new System.Drawing.Size(420, 22);
            this.txtNаme.TabIndex = 2;
            this.txtNаme.Validated += new System.EventHandler(this.txtNаme_Validated);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(149, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 14);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "ФИО полностью";
            // 
            // lblPassportSeries
            // 
            this.lblPassportSeries.AutoSize = true;
            this.lblPassportSeries.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPassportSeries.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPassportSeries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassportSeries.Location = new System.Drawing.Point(207, 77);
            this.lblPassportSeries.Name = "lblPassportSeries";
            this.lblPassportSeries.Size = new System.Drawing.Size(41, 14);
            this.lblPassportSeries.TabIndex = 7;
            this.lblPassportSeries.Text = "серия";
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPassport.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPassport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassport.Location = new System.Drawing.Point(149, 55);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(126, 14);
            this.lblPassport.TabIndex = 6;
            this.lblPassport.Text = "Паспортные данные:";
            // 
            // txtPassportGranted
            // 
            this.txtPassportGranted.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPassportGranted.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassportGranted.Location = new System.Drawing.Point(252, 99);
            this.txtPassportGranted.MaxLength = 200;
            this.txtPassportGranted.Name = "txtPassportGranted";
            this.txtPassportGranted.Size = new System.Drawing.Size(420, 22);
            this.txtPassportGranted.TabIndex = 14;
            // 
            // txtPassportSeries
            // 
            this.txtPassportSeries.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPassportSeries.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPassportSeries.Location = new System.Drawing.Point(252, 74);
            this.txtPassportSeries.MaxLength = 20;
            this.txtPassportSeries.Name = "txtPassportSeries";
            this.txtPassportSeries.Size = new System.Drawing.Size(100, 22);
            this.txtPassportSeries.TabIndex = 8;
            // 
            // chkIsDriver
            // 
            this.chkIsDriver.AutoSize = true;
            this.chkIsDriver.Enabled = false;
            this.chkIsDriver.Location = new System.Drawing.Point(158, 207);
            this.chkIsDriver.Name = "chkIsDriver";
            this.chkIsDriver.Size = new System.Drawing.Size(80, 18);
            this.chkIsDriver.TabIndex = 20;
            this.chkIsDriver.Text = "Водитель";
            this.chkIsDriver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkIsDriver.UseVisualStyleBackColor = true;
            this.chkIsDriver.CheckedChanged += new System.EventHandler(this.chkIsDriver_CheckedChanged);
            // 
            // chkActual
            // 
            this.chkActual.AutoSize = true;
            this.chkActual.Location = new System.Drawing.Point(569, 33);
            this.chkActual.Name = "chkActual";
            this.chkActual.Size = new System.Drawing.Size(103, 18);
            this.chkActual.TabIndex = 5;
            this.chkActual.Text = "Актуальность";
            this.chkActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkActual.UseVisualStyleBackColor = true;
            // 
            // lblPhoto
            // 
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPhoto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPhoto.Location = new System.Drawing.Point(4, 7);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(37, 14);
            this.lblPhoto.TabIndex = 0;
            this.lblPhoto.Text = "Фото";
            // 
            // picPhoto
            // 
            this.picPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picPhoto.Location = new System.Drawing.Point(5, 24);
            this.picPhoto.Name = "picPhoto";
            this.picPhoto.Size = new System.Drawing.Size(135, 174);
            this.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPhoto.TabIndex = 10;
            this.picPhoto.TabStop = false;
            // 
            // btnLoadPhoto
            // 
            this.btnLoadPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPhoto.Image = global::Logistics.Properties.Resources.Locate;
            this.btnLoadPhoto.Location = new System.Drawing.Point(78, 337);
            this.btnLoadPhoto.Name = "btnLoadPhoto";
            this.btnLoadPhoto.Size = new System.Drawing.Size(32, 30);
            this.btnLoadPhoto.TabIndex = 13;
            this.ttToolTip.SetToolTip(this.btnLoadPhoto, "Выбрать изображение для фото");
            this.btnLoadPhoto.UseVisualStyleBackColor = true;
            this.btnLoadPhoto.Click += new System.EventHandler(this.btnLoadPhoto_Click);
            // 
            // btnClearPhoto
            // 
            this.btnClearPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearPhoto.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClearPhoto.Location = new System.Drawing.Point(116, 337);
            this.btnClearPhoto.Name = "btnClearPhoto";
            this.btnClearPhoto.Size = new System.Drawing.Size(32, 30);
            this.btnClearPhoto.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.btnClearPhoto, "Очистить фото");
            this.btnClearPhoto.UseVisualStyleBackColor = true;
            this.btnClearPhoto.Click += new System.EventHandler(this.btnClearPhoto_Click);
            // 
            // frmEmployeesDriversEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.btnClearPhoto);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnLoadPhoto);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmEmployeesDriversEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сотрудник, водитель";
            this.Load += new System.EventHandler(this.frmEmployeesDriversEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlDriver.ResumeLayout(false);
            this.pnlDriver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhoto)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblPhoto;
		private RFMBaseClasses.RFMPictureBox picPhoto;
		private RFMBaseClasses.RFMLabel lblDriverCategory;
		private RFMBaseClasses.RFMTextBox txtDriverCategory;
		private RFMBaseClasses.RFMCheckBox chkIsDriver;
		private RFMBaseClasses.RFMCheckBox chkActual;
		private RFMBaseClasses.RFMTextBox txtPassportGranted;
		private RFMBaseClasses.RFMTextBox txtPassportSeries;
		private RFMBaseClasses.RFMLabel lblName;
		private RFMBaseClasses.RFMLabel lblPassportSeries;
		private RFMBaseClasses.RFMLabel lblPassport;
		private RFMBaseClasses.RFMButton btnLoadPhoto;
		private RFMBaseClasses.RFMTextBox txtNаme;
		private RFMBaseClasses.RFMButton btnClearPhoto;
		private RFMBaseClasses.RFMLabel lblAlias;
		private RFMBaseClasses.RFMTextBox txtAlias;
		private RFMBaseClasses.RFMDateTimePicker dtpPassportDate;
		private RFMBaseClasses.RFMLabel lblPassportDate;
		private RFMBaseClasses.RFMLabel lblPassportNumber;
		private RFMBaseClasses.RFMTextBox txtPassportNumber;
		private RFMBaseClasses.RFMLabel lblPassportGranted;
		private RFMBaseClasses.RFMLabel lblJobTitle;
		private RFMBaseClasses.RFMComboBox cboJobTitle;
		private RFMBaseClasses.RFMPanel pnlDriver;
		private RFMBaseClasses.RFMCheckBox chkOperable;
		private RFMBaseClasses.RFMTextBox txtDriverLicenceNumber;
		private RFMBaseClasses.RFMLabel lblDriverLicenceNumber;
		private RFMBaseClasses.RFMCheckBox chkForGoodsOnly;
		private RFMBaseClasses.RFMLabel lblZone;
		private RFMBaseClasses.RFMComboBox cboZone;
		private RFMBaseClasses.RFMLabel lblCar;
		private RFMBaseClasses.RFMComboBox cboCar;
		private RFMBaseClasses.RFMLabel lblMobPhone;
		private RFMBaseClasses.RFMTextBox txtMobPhone;
		private RFMBaseClasses.RFMCheckBox chkPassConfirmAllowed;

	}
}

