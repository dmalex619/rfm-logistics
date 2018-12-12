namespace Logistics
{
	partial class frmWayBillsEdit
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
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.grdFillings = new RFMBaseClasses.RFMDataGridView();
            this.grcFillings_DateFill = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcFillings_FillingType = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcFillings_FuelType = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcFilings_QntFilled = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcFilling_Price = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcFilling_Amount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcFillings_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.txtNote = new RFMBaseClasses.RFMTextBox();
            this.lblNote = new RFMBaseClasses.RFMLabel();
            this.lblWayBillNumber = new RFMBaseClasses.RFMLabel();
            this.lblCarTypeName = new RFMBaseClasses.RFMLabel();
            this.cboCar = new RFMBaseClasses.RFMComboBox();
            this.lblDriverEmployee = new RFMBaseClasses.RFMLabel();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.txtBillNumber = new RFMBaseClasses.RFMTextBox();
            this.lblBillNumber = new RFMBaseClasses.RFMLabel();
            this.btnCarInfo = new RFMBaseClasses.RFMButton();
            this.lblDriverOther = new RFMBaseClasses.RFMLabel();
            this.txtDriverOther = new RFMBaseClasses.RFMTextBox();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.btnReasonSelect = new RFMBaseClasses.RFMButton();
            this.lblReason = new RFMBaseClasses.RFMLabel();
            this.txtReason = new RFMBaseClasses.RFMTextBox();
            this.dtpDateWayEnd = new RFMBaseClasses.RFMDateTimePicker();
            this.lblDateWayEnd = new RFMBaseClasses.RFMLabel();
            this.lblDateWayBeg = new RFMBaseClasses.RFMLabel();
            this.dtpDateWayBeg = new RFMBaseClasses.RFMDateTimePicker();
            this.tcAdd = new RFMBaseClasses.RFMTabControl();
            this.tabFillings = new RFMBaseClasses.RFMTabPage();
            this.tabTrips = new RFMBaseClasses.RFMTabPage();
            this.grdTrips = new RFMBaseClasses.RFMDataGridView();
            this.grcTrips_IsUsed = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcTrips_DateTrip = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrip_Alias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrips_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.lblZoneName = new RFMBaseClasses.RFMLabel();
            this.cboDriverEmployee = new RFMBaseClasses.RFMComboBox();
            this.pnlSpeedometer = new RFMBaseClasses.RFMPanel();
            this.lblSpeedometerDataEnв = new RFMBaseClasses.RFMLabel();
            this.lblSpeedometerDiff = new RFMBaseClasses.RFMLabel();
            this.numSpeedometerDataEnd = new RFMBaseClasses.RFMNumericUpDown();
            this.chkSpeedometerEdit = new RFMBaseClasses.RFMCheckBox();
            this.numSpeedometerDiff = new RFMBaseClasses.RFMNumericUpDown();
            this.lblSpeedometer = new RFMBaseClasses.RFMLabel();
            this.lblSppedometerDataBeg = new RFMBaseClasses.RFMLabel();
            this.numSpeedometerDataBeg = new RFMBaseClasses.RFMNumericUpDown();
            this.pnlFuel = new RFMBaseClasses.RFMPanel();
            this.txtFreezerDuration = new RFMBaseClasses.RFMTextBoxTimeEx();
            this.btnFuelSum = new RFMBaseClasses.RFMButton();
            this.lblFreezerDurationHours = new RFMBaseClasses.RFMLabel();
            this.lblFreezerDuration = new RFMBaseClasses.RFMLabel();
            this.lblFreezerTank = new RFMBaseClasses.RFMLabel();
            this.lblFuelDiffCalc = new RFMBaseClasses.RFMLabel();
            this.lblFuelTank = new RFMBaseClasses.RFMLabel();
            this.lblFuelDiff = new RFMBaseClasses.RFMLabel();
            this.numFuelDiff = new RFMBaseClasses.RFMNumericUpDown();
            this.numFuelFreezerDataEnd = new RFMBaseClasses.RFMNumericUpDown();
            this.numFuelFreezerDataBeg = new RFMBaseClasses.RFMNumericUpDown();
            this.lblFuelFreezer = new RFMBaseClasses.RFMLabel();
            this.lblFuelData = new RFMBaseClasses.RFMLabel();
            this.lblFuelEnd = new RFMBaseClasses.RFMLabel();
            this.lblFuelQntFilled = new RFMBaseClasses.RFMLabel();
            this.numFuelDataEnd = new RFMBaseClasses.RFMNumericUpDown();
            this.numFuelQntFilled = new RFMBaseClasses.RFMNumericUpDown();
            this.lblFuelBeg = new RFMBaseClasses.RFMLabel();
            this.numFuelDataBeg = new RFMBaseClasses.RFMNumericUpDown();
            this.chkFuelEdit = new RFMBaseClasses.RFMCheckBox();
            this.lblFuel = new RFMBaseClasses.RFMLabel();
            this.lblFuelQntFilledText = new RFMBaseClasses.RFMLabel();
            this.lblDelimiter = new RFMBaseClasses.RFMLabel();
            this.nudHours = new RFMBaseClasses.RFMNumericUpDown();
            this.nudMinutes = new RFMBaseClasses.RFMNumericUpDown();
            this.btnClose = new RFMBaseClasses.RFMButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdFillings)).BeginInit();
            this.pnlData.SuspendLayout();
            this.tcAdd.SuspendLayout();
            this.tabFillings.SuspendLayout();
            this.tabTrips.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTrips)).BeginInit();
            this.pnlSpeedometer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedometerDataEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedometerDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedometerDataBeg)).BeginInit();
            this.pnlFuel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelFreezerDataEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelFreezerDataBeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelDataEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelQntFilled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelDataBeg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 420);
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
            this.btnExit.Location = new System.Drawing.Point(530, 420);
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
            this.btnSave.Location = new System.Drawing.Point(480, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grdFillings
            // 
            this.grdFillings.AllowUserToAddRows = false;
            this.grdFillings.AllowUserToDeleteRows = false;
            this.grdFillings.AllowUserToOrderColumns = true;
            this.grdFillings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdFillings.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdFillings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdFillings.ColumnHeadersHeight = 22;
            this.grdFillings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcFillings_DateFill,
            this.grcFillings_FillingType,
            this.grcFillings_FuelType,
            this.grcFilings_QntFilled,
            this.grcFilling_Price,
            this.grcFilling_Amount,
            this.grcFillings_ID});
            this.grdFillings.IsConfigInclude = true;
            this.grdFillings.IsMarkedAll = false;
            this.grdFillings.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdFillings.Location = new System.Drawing.Point(-1, -1);
            this.grdFillings.MultiSelect = false;
            this.grdFillings.Name = "grdFillings";
            this.grdFillings.RangedWay = ' ';
            this.grdFillings.ReadOnly = true;
            this.grdFillings.RowHeadersWidth = 24;
            this.grdFillings.Size = new System.Drawing.Size(508, 75);
            this.grdFillings.TabIndex = 0;
            // 
            // grcFillings_DateFill
            // 
            this.grcFillings_DateFill.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFillings_DateFill.DataPropertyName = "DateFill";
            this.grcFillings_DateFill.HeaderText = "Дата";
            this.grcFillings_DateFill.Name = "grcFillings_DateFill";
            this.grcFillings_DateFill.ReadOnly = true;
            this.grcFillings_DateFill.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcFillings_DateFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFillings_DateFill.Width = 80;
            // 
            // grcFillings_FillingType
            // 
            this.grcFillings_FillingType.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFillings_FillingType.DataPropertyName = "FillingTypeName";
            this.grcFillings_FillingType.HeaderText = "Заправка";
            this.grcFillings_FillingType.Name = "grcFillings_FillingType";
            this.grcFillings_FillingType.ReadOnly = true;
            this.grcFillings_FillingType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFillings_FillingType.ToolTipText = "Тип заправки";
            // 
            // grcFillings_FuelType
            // 
            this.grcFillings_FuelType.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFillings_FuelType.DataPropertyName = "FuelTypeName";
            this.grcFillings_FuelType.HeaderText = "Топливо";
            this.grcFillings_FuelType.Name = "grcFillings_FuelType";
            this.grcFillings_FuelType.ReadOnly = true;
            this.grcFillings_FuelType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFillings_FuelType.ToolTipText = "Тип топлива";
            // 
            // grcFilings_QntFilled
            // 
            this.grcFilings_QntFilled.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFilings_QntFilled.DataPropertyName = "QntFilled";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            this.grcFilings_QntFilled.DefaultCellStyle = dataGridViewCellStyle1;
            this.grcFilings_QntFilled.HeaderText = "Кол-во";
            this.grcFilings_QntFilled.Name = "grcFilings_QntFilled";
            this.grcFilings_QntFilled.ReadOnly = true;
            this.grcFilings_QntFilled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFilings_QntFilled.ToolTipText = "Количество заправленного топлива, л";
            this.grcFilings_QntFilled.Width = 70;
            // 
            // grcFilling_Price
            // 
            this.grcFilling_Price.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFilling_Price.DataPropertyName = "Price";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.grcFilling_Price.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcFilling_Price.HeaderText = "Цена";
            this.grcFilling_Price.Name = "grcFilling_Price";
            this.grcFilling_Price.ReadOnly = true;
            this.grcFilling_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFilling_Price.Width = 60;
            // 
            // grcFilling_Amount
            // 
            this.grcFilling_Amount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFilling_Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.grcFilling_Amount.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcFilling_Amount.HeaderText = "На сумму";
            this.grcFilling_Amount.Name = "grcFilling_Amount";
            this.grcFilling_Amount.ReadOnly = true;
            this.grcFilling_Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFilling_Amount.Width = 70;
            // 
            // grcFillings_ID
            // 
            this.grcFillings_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcFillings_ID.DataPropertyName = "ID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcFillings_ID.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcFillings_ID.HeaderText = "ID";
            this.grcFillings_ID.Name = "grcFillings_ID";
            this.grcFillings_ID.ReadOnly = true;
            this.grcFillings_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcFillings_ID.Visible = false;
            this.grcFillings_ID.Width = 50;
            // 
            // txtNote
            // 
            this.txtNote.AcceptsReturn = true;
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(104, 123);
            this.txtNote.MaxLength = 200;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(450, 22);
            this.txtNote.TabIndex = 18;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNote.Location = new System.Drawing.Point(3, 126);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(78, 14);
            this.lblNote.TabIndex = 16;
            this.lblNote.Text = "Примечание";
            // 
            // lblWayBillNumber
            // 
            this.lblWayBillNumber.AutoSize = true;
            this.lblWayBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblWayBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblWayBillNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWayBillNumber.Location = new System.Drawing.Point(4, 31);
            this.lblWayBillNumber.Name = "lblWayBillNumber";
            this.lblWayBillNumber.Size = new System.Drawing.Size(50, 14);
            this.lblWayBillNumber.TabIndex = 6;
            this.lblWayBillNumber.Text = "Машина";
            // 
            // lblCarTypeName
            // 
            this.lblCarTypeName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCarTypeName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarTypeName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarTypeName.Location = new System.Drawing.Point(335, 30);
            this.lblCarTypeName.Name = "lblCarTypeName";
            this.lblCarTypeName.Size = new System.Drawing.Size(221, 14);
            this.lblCarTypeName.TabIndex = 9;
            this.lblCarTypeName.Text = "#CarNumber#";
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
            this.cboCar.Location = new System.Drawing.Point(104, 27);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(227, 22);
            this.cboCar.TabIndex = 8;
            this.cboCar.Validated += new System.EventHandler(this.cboCar_Validated);
            // 
            // lblDriverEmployee
            // 
            this.lblDriverEmployee.AutoSize = true;
            this.lblDriverEmployee.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverEmployee.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverEmployee.Location = new System.Drawing.Point(4, 55);
            this.lblDriverEmployee.Name = "lblDriverEmployee";
            this.lblDriverEmployee.Size = new System.Drawing.Size(61, 14);
            this.lblDriverEmployee.TabIndex = 10;
            this.lblDriverEmployee.Text = "Водитель";
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.txtBillNumber);
            this.pnlData.Controls.Add(this.lblBillNumber);
            this.pnlData.Controls.Add(this.btnCarInfo);
            this.pnlData.Controls.Add(this.lblDriverOther);
            this.pnlData.Controls.Add(this.txtDriverOther);
            this.pnlData.Controls.Add(this.btnDelete);
            this.pnlData.Controls.Add(this.btnEdit);
            this.pnlData.Controls.Add(this.btnAdd);
            this.pnlData.Controls.Add(this.btnReasonSelect);
            this.pnlData.Controls.Add(this.lblReason);
            this.pnlData.Controls.Add(this.txtReason);
            this.pnlData.Controls.Add(this.dtpDateWayEnd);
            this.pnlData.Controls.Add(this.lblDateWayEnd);
            this.pnlData.Controls.Add(this.lblDateWayBeg);
            this.pnlData.Controls.Add(this.dtpDateWayBeg);
            this.pnlData.Controls.Add(this.tcAdd);
            this.pnlData.Controls.Add(this.lblCarTypeName);
            this.pnlData.Controls.Add(this.lblZoneName);
            this.pnlData.Controls.Add(this.cboDriverEmployee);
            this.pnlData.Controls.Add(this.cboCar);
            this.pnlData.Controls.Add(this.pnlSpeedometer);
            this.pnlData.Controls.Add(this.pnlFuel);
            this.pnlData.Controls.Add(this.lblDriverEmployee);
            this.pnlData.Controls.Add(this.lblWayBillNumber);
            this.pnlData.Controls.Add(this.lblNote);
            this.pnlData.Controls.Add(this.txtNote);
            this.pnlData.Location = new System.Drawing.Point(3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(561, 410);
            this.pnlData.TabIndex = 0;
            // 
            // txtBillNumber
            // 
            this.txtBillNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBillNumber.Location = new System.Drawing.Point(104, 3);
            this.txtBillNumber.MaxLength = 200;
            this.txtBillNumber.Name = "txtBillNumber";
            this.txtBillNumber.Size = new System.Drawing.Size(118, 22);
            this.txtBillNumber.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.txtBillNumber, "Дополнительная информация о водителях (ассистент)");
            // 
            // lblBillNumber
            // 
            this.lblBillNumber.AutoSize = true;
            this.lblBillNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblBillNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBillNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBillNumber.Location = new System.Drawing.Point(4, 7);
            this.lblBillNumber.Name = "lblBillNumber";
            this.lblBillNumber.Size = new System.Drawing.Size(102, 14);
            this.lblBillNumber.TabIndex = 0;
            this.lblBillNumber.Text = "Путевой лист №";
            // 
            // btnCarInfo
            // 
            this.btnCarInfo.FlatAppearance.BorderSize = 0;
            this.btnCarInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarInfo.Image = global::Logistics.Properties.Resources.Truck;
            this.btnCarInfo.Location = new System.Drawing.Point(75, 25);
            this.btnCarInfo.Name = "btnCarInfo";
            this.btnCarInfo.Size = new System.Drawing.Size(25, 25);
            this.btnCarInfo.TabIndex = 7;
            this.btnCarInfo.TabStop = false;
            this.ttToolTip.SetToolTip(this.btnCarInfo, "Показать информацию о машине");
            this.btnCarInfo.UseVisualStyleBackColor = true;
            this.btnCarInfo.Click += new System.EventHandler(this.btnCarInfo_Click);
            // 
            // lblDriverOther
            // 
            this.lblDriverOther.AutoSize = true;
            this.lblDriverOther.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverOther.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverOther.Location = new System.Drawing.Point(3, 78);
            this.lblDriverOther.Name = "lblDriverOther";
            this.lblDriverOther.Size = new System.Drawing.Size(86, 14);
            this.lblDriverOther.TabIndex = 13;
            this.lblDriverOther.Text = "Доп.водитель";
            // 
            // txtDriverOther
            // 
            this.txtDriverOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDriverOther.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriverOther.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriverOther.Enabled = false;
            this.txtDriverOther.Location = new System.Drawing.Point(104, 75);
            this.txtDriverOther.MaxLength = 200;
            this.txtDriverOther.Name = "txtDriverOther";
            this.txtDriverOther.Size = new System.Drawing.Size(450, 22);
            this.txtDriverOther.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.txtDriverOther, "Дополнительная информация о водителях (ассистент)");
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(522, 373);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 30);
            this.btnDelete.TabIndex = 23;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удалить");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(522, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 30);
            this.btnEdit.TabIndex = 22;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактировать");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(522, 301);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 30);
            this.btnAdd.TabIndex = 21;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавить");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReasonSelect
            // 
            this.btnReasonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReasonSelect.FlatAppearance.BorderSize = 0;
            this.btnReasonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReasonSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnReasonSelect.Location = new System.Drawing.Point(528, 97);
            this.btnReasonSelect.Name = "btnReasonSelect";
            this.btnReasonSelect.Size = new System.Drawing.Size(25, 25);
            this.btnReasonSelect.TabIndex = 17;
            this.btnReasonSelect.TabStop = false;
            this.ttToolTip.SetToolTip(this.btnReasonSelect, "Выбрать из ранее введенных значений");
            this.btnReasonSelect.UseVisualStyleBackColor = true;
            this.btnReasonSelect.Click += new System.EventHandler(this.btnReasonSelect_Click);
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblReason.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReason.Location = new System.Drawing.Point(4, 102);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(74, 14);
            this.lblReason.TabIndex = 14;
            this.lblReason.Text = "Назначение";
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReason.Location = new System.Drawing.Point(104, 99);
            this.txtReason.MaxLength = 200;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(422, 22);
            this.txtReason.TabIndex = 15;
            // 
            // dtpDateWayEnd
            // 
            this.dtpDateWayEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateWayEnd.CustomFormat = "dd.MM.yyyy";
            this.dtpDateWayEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDateWayEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDateWayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateWayEnd.Location = new System.Drawing.Point(459, 3);
            this.dtpDateWayEnd.Name = "dtpDateWayEnd";
            this.dtpDateWayEnd.Size = new System.Drawing.Size(96, 22);
            this.dtpDateWayEnd.TabIndex = 5;
            this.dtpDateWayEnd.ValueChanged += new System.EventHandler(this.dtpDateWayEnd_ValueChanged);
            // 
            // lblDateWayEnd
            // 
            this.lblDateWayEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateWayEnd.AutoSize = true;
            this.lblDateWayEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateWayEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateWayEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateWayEnd.Location = new System.Drawing.Point(433, 7);
            this.lblDateWayEnd.Name = "lblDateWayEnd";
            this.lblDateWayEnd.Size = new System.Drawing.Size(21, 14);
            this.lblDateWayEnd.TabIndex = 4;
            this.lblDateWayEnd.Text = "по";
            // 
            // lblDateWayBeg
            // 
            this.lblDateWayBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateWayBeg.AutoSize = true;
            this.lblDateWayBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateWayBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateWayBeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateWayBeg.Location = new System.Drawing.Point(252, 7);
            this.lblDateWayBeg.Name = "lblDateWayBeg";
            this.lblDateWayBeg.Size = new System.Drawing.Size(75, 14);
            this.lblDateWayBeg.TabIndex = 2;
            this.lblDateWayBeg.Text = "действует с";
            // 
            // dtpDateWayBeg
            // 
            this.dtpDateWayBeg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDateWayBeg.CustomFormat = "dd.MM.yyyy";
            this.dtpDateWayBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDateWayBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDateWayBeg.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateWayBeg.Location = new System.Drawing.Point(331, 3);
            this.dtpDateWayBeg.Name = "dtpDateWayBeg";
            this.dtpDateWayBeg.Size = new System.Drawing.Size(96, 22);
            this.dtpDateWayBeg.TabIndex = 3;
            this.dtpDateWayBeg.ValueChanged += new System.EventHandler(this.dtpDateWayBeg_ValueChanged);
            // 
            // tcAdd
            // 
            this.tcAdd.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcAdd.Controls.Add(this.tabFillings);
            this.tcAdd.Controls.Add(this.tabTrips);
            this.tcAdd.Location = new System.Drawing.Point(2, 301);
            this.tcAdd.Multiline = true;
            this.tcAdd.Name = "tcAdd";
            this.tcAdd.SelectedIndex = 0;
            this.tcAdd.Size = new System.Drawing.Size(516, 104);
            this.tcAdd.TabIndex = 20;
            this.tcAdd.SelectedIndexChanged += new System.EventHandler(this.tcAdd_SelectedIndexChanged);
            // 
            // tabFillings
            // 
            this.tabFillings.Controls.Add(this.grdFillings);
            this.tabFillings.Location = new System.Drawing.Point(4, 4);
            this.tabFillings.Name = "tabFillings";
            this.tabFillings.Padding = new System.Windows.Forms.Padding(3);
            this.tabFillings.Size = new System.Drawing.Size(508, 77);
            this.tabFillings.TabIndex = 0;
            this.tabFillings.Text = "Заправки";
            this.tabFillings.UseVisualStyleBackColor = true;
            // 
            // tabTrips
            // 
            this.tabTrips.Controls.Add(this.grdTrips);
            this.tabTrips.Location = new System.Drawing.Point(4, 4);
            this.tabTrips.Name = "tabTrips";
            this.tabTrips.Padding = new System.Windows.Forms.Padding(3);
            this.tabTrips.Size = new System.Drawing.Size(508, 77);
            this.tabTrips.TabIndex = 1;
            this.tabTrips.Text = "Рейсы";
            this.tabTrips.UseVisualStyleBackColor = true;
            // 
            // grdTrips
            // 
            this.grdTrips.AllowUserToAddRows = false;
            this.grdTrips.AllowUserToDeleteRows = false;
            this.grdTrips.AllowUserToOrderColumns = true;
            this.grdTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTrips.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdTrips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcTrips_IsUsed,
            this.grcTrips_DateTrip,
            this.grcTrip_Alias,
            this.grcTrips_ID});
            this.grdTrips.IsConfigInclude = true;
            this.grdTrips.IsMarkedAll = false;
            this.grdTrips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdTrips.Location = new System.Drawing.Point(-1, -1);
            this.grdTrips.MultiSelect = false;
            this.grdTrips.Name = "grdTrips";
            this.grdTrips.RangedWay = ' ';
            this.grdTrips.RowHeadersWidth = 24;
            this.grdTrips.Size = new System.Drawing.Size(508, 75);
            this.grdTrips.TabIndex = 17;
            // 
            // grcTrips_IsUsed
            // 
            this.grcTrips_IsUsed.DataPropertyName = "IsUsed";
            this.grcTrips_IsUsed.HeaderText = "";
            this.grcTrips_IsUsed.Name = "grcTrips_IsUsed";
            this.grcTrips_IsUsed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcTrips_IsUsed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_IsUsed.Width = 30;
            // 
            // grcTrips_DateTrip
            // 
            this.grcTrips_DateTrip.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_DateTrip.DataPropertyName = "DateTrip";
            this.grcTrips_DateTrip.HeaderText = "Дата";
            this.grcTrips_DateTrip.Name = "grcTrips_DateTrip";
            this.grcTrips_DateTrip.ReadOnly = true;
            this.grcTrips_DateTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_DateTrip.Width = 80;
            // 
            // grcTrip_Alias
            // 
            this.grcTrip_Alias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrip_Alias.DataPropertyName = "Alias";
            this.grcTrip_Alias.HeaderText = "Тип рейса";
            this.grcTrip_Alias.Name = "grcTrip_Alias";
            this.grcTrip_Alias.ReadOnly = true;
            this.grcTrip_Alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrip_Alias.Width = 350;
            // 
            // grcTrips_ID
            // 
            this.grcTrips_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrips_ID.DataPropertyName = "ID";
            this.grcTrips_ID.HeaderText = "ID";
            this.grcTrips_ID.Name = "grcTrips_ID";
            this.grcTrips_ID.ReadOnly = true;
            this.grcTrips_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrips_ID.Visible = false;
            this.grcTrips_ID.Width = 50;
            // 
            // lblZoneName
            // 
            this.lblZoneName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblZoneName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblZoneName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZoneName.Location = new System.Drawing.Point(335, 54);
            this.lblZoneName.Name = "lblZoneName";
            this.lblZoneName.Size = new System.Drawing.Size(221, 14);
            this.lblZoneName.TabIndex = 12;
            this.lblZoneName.Text = "#ZoneName#";
            // 
            // cboDriverEmployee
            // 
            this.cboDriverEmployee.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboDriverEmployee.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboDriverEmployee.FormattingEnabled = true;
            this.cboDriverEmployee.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboDriverEmployee.Location = new System.Drawing.Point(104, 51);
            this.cboDriverEmployee.Name = "cboDriverEmployee";
            this.cboDriverEmployee.Size = new System.Drawing.Size(227, 22);
            this.cboDriverEmployee.TabIndex = 11;
            this.cboDriverEmployee.SelectedIndexChanged += new System.EventHandler(this.cboDriverEmployee_SelectedIndexChanged);
            // 
            // pnlSpeedometer
            // 
            this.pnlSpeedometer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSpeedometer.Controls.Add(this.lblSpeedometerDataEnв);
            this.pnlSpeedometer.Controls.Add(this.lblSpeedometerDiff);
            this.pnlSpeedometer.Controls.Add(this.numSpeedometerDataEnd);
            this.pnlSpeedometer.Controls.Add(this.chkSpeedometerEdit);
            this.pnlSpeedometer.Controls.Add(this.numSpeedometerDiff);
            this.pnlSpeedometer.Controls.Add(this.lblSpeedometer);
            this.pnlSpeedometer.Controls.Add(this.lblSppedometerDataBeg);
            this.pnlSpeedometer.Controls.Add(this.numSpeedometerDataBeg);
            this.pnlSpeedometer.Location = new System.Drawing.Point(3, 147);
            this.pnlSpeedometer.Name = "pnlSpeedometer";
            this.pnlSpeedometer.Size = new System.Drawing.Size(169, 100);
            this.pnlSpeedometer.TabIndex = 19;
            // 
            // lblSpeedometerDataEnв
            // 
            this.lblSpeedometerDataEnв.AutoSize = true;
            this.lblSpeedometerDataEnв.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblSpeedometerDataEnв.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSpeedometerDataEnв.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpeedometerDataEnв.Location = new System.Drawing.Point(47, 75);
            this.lblSpeedometerDataEnв.Name = "lblSpeedometerDataEnв";
            this.lblSpeedometerDataEnв.Size = new System.Drawing.Size(31, 14);
            this.lblSpeedometerDataEnв.TabIndex = 6;
            this.lblSpeedometerDataEnв.Text = "кон.";
            // 
            // lblSpeedometerDiff
            // 
            this.lblSpeedometerDiff.AutoSize = true;
            this.lblSpeedometerDiff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblSpeedometerDiff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSpeedometerDiff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpeedometerDiff.Location = new System.Drawing.Point(31, 50);
            this.lblSpeedometerDiff.Name = "lblSpeedometerDiff";
            this.lblSpeedometerDiff.Size = new System.Drawing.Size(47, 14);
            this.lblSpeedometerDiff.TabIndex = 4;
            this.lblSpeedometerDiff.Text = "пробег";
            // 
            // numSpeedometerDataEnd
            // 
            this.numSpeedometerDataEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numSpeedometerDataEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numSpeedometerDataEnd.IsNull = false;
            this.numSpeedometerDataEnd.Location = new System.Drawing.Point(82, 71);
            this.numSpeedometerDataEnd.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSpeedometerDataEnd.Name = "numSpeedometerDataEnd";
            this.numSpeedometerDataEnd.Size = new System.Drawing.Size(76, 22);
            this.numSpeedometerDataEnd.TabIndex = 7;
            this.numSpeedometerDataEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSpeedometerDataEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numSpeedometerDataEnd.ValueChanged += new System.EventHandler(this.numSpeedometerDataEnd_ValueChanged);
            // 
            // chkSpeedometerEdit
            // 
            this.chkSpeedometerEdit.AutoSize = true;
            this.chkSpeedometerEdit.Location = new System.Drawing.Point(7, 25);
            this.chkSpeedometerEdit.Name = "chkSpeedometerEdit";
            this.chkSpeedometerEdit.Size = new System.Drawing.Size(15, 14);
            this.chkSpeedometerEdit.TabIndex = 1;
            this.chkSpeedometerEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttToolTip.SetToolTip(this.chkSpeedometerEdit, "изменить нач.показания спидометра");
            this.chkSpeedometerEdit.UseVisualStyleBackColor = true;
            this.chkSpeedometerEdit.CheckedChanged += new System.EventHandler(this.chkSpeedometerEdit_CheckedChanged);
            // 
            // numSpeedometerDiff
            // 
            this.numSpeedometerDiff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numSpeedometerDiff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numSpeedometerDiff.IsNull = false;
            this.numSpeedometerDiff.Location = new System.Drawing.Point(82, 46);
            this.numSpeedometerDiff.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSpeedometerDiff.Name = "numSpeedometerDiff";
            this.numSpeedometerDiff.Size = new System.Drawing.Size(76, 22);
            this.numSpeedometerDiff.TabIndex = 5;
            this.numSpeedometerDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSpeedometerDiff.ValueChanged += new System.EventHandler(this.numSpeedometerDiff_ValueChanged);
            // 
            // lblSpeedometer
            // 
            this.lblSpeedometer.AutoSize = true;
            this.lblSpeedometer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblSpeedometer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSpeedometer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpeedometer.Location = new System.Drawing.Point(2, 4);
            this.lblSpeedometer.Name = "lblSpeedometer";
            this.lblSpeedometer.Size = new System.Drawing.Size(164, 14);
            this.lblSpeedometer.TabIndex = 0;
            this.lblSpeedometer.Text = "Показания спидометра, км:";
            // 
            // lblSppedometerDataBeg
            // 
            this.lblSppedometerDataBeg.AutoSize = true;
            this.lblSppedometerDataBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblSppedometerDataBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSppedometerDataBeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSppedometerDataBeg.Location = new System.Drawing.Point(47, 25);
            this.lblSppedometerDataBeg.Name = "lblSppedometerDataBeg";
            this.lblSppedometerDataBeg.Size = new System.Drawing.Size(31, 14);
            this.lblSppedometerDataBeg.TabIndex = 2;
            this.lblSppedometerDataBeg.Text = "нач.";
            // 
            // numSpeedometerDataBeg
            // 
            this.numSpeedometerDataBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numSpeedometerDataBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numSpeedometerDataBeg.IsNull = false;
            this.numSpeedometerDataBeg.Location = new System.Drawing.Point(82, 21);
            this.numSpeedometerDataBeg.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numSpeedometerDataBeg.Name = "numSpeedometerDataBeg";
            this.numSpeedometerDataBeg.Size = new System.Drawing.Size(76, 22);
            this.numSpeedometerDataBeg.TabIndex = 3;
            this.numSpeedometerDataBeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSpeedometerDataBeg.ValueChanged += new System.EventHandler(this.numSpeedometerDataBeg_ValueChanged);
            // 
            // pnlFuel
            // 
            this.pnlFuel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFuel.Controls.Add(this.txtFreezerDuration);
            this.pnlFuel.Controls.Add(this.btnFuelSum);
            this.pnlFuel.Controls.Add(this.lblFreezerDurationHours);
            this.pnlFuel.Controls.Add(this.lblFreezerDuration);
            this.pnlFuel.Controls.Add(this.lblFreezerTank);
            this.pnlFuel.Controls.Add(this.lblFuelDiffCalc);
            this.pnlFuel.Controls.Add(this.lblFuelTank);
            this.pnlFuel.Controls.Add(this.lblFuelDiff);
            this.pnlFuel.Controls.Add(this.numFuelDiff);
            this.pnlFuel.Controls.Add(this.numFuelFreezerDataEnd);
            this.pnlFuel.Controls.Add(this.numFuelFreezerDataBeg);
            this.pnlFuel.Controls.Add(this.lblFuelFreezer);
            this.pnlFuel.Controls.Add(this.lblFuelData);
            this.pnlFuel.Controls.Add(this.lblFuelEnd);
            this.pnlFuel.Controls.Add(this.lblFuelQntFilled);
            this.pnlFuel.Controls.Add(this.numFuelDataEnd);
            this.pnlFuel.Controls.Add(this.numFuelQntFilled);
            this.pnlFuel.Controls.Add(this.lblFuelBeg);
            this.pnlFuel.Controls.Add(this.numFuelDataBeg);
            this.pnlFuel.Controls.Add(this.chkFuelEdit);
            this.pnlFuel.Controls.Add(this.lblFuel);
            this.pnlFuel.Controls.Add(this.lblFuelQntFilledText);
            this.pnlFuel.Location = new System.Drawing.Point(175, 147);
            this.pnlFuel.Name = "pnlFuel";
            this.pnlFuel.Size = new System.Drawing.Size(379, 150);
            this.pnlFuel.TabIndex = 19;
            // 
            // txtFreezerDuration
            // 
            this.txtFreezerDuration.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtFreezerDuration.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtFreezerDuration.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtFreezerDuration.Location = new System.Drawing.Point(232, 121);
            this.txtFreezerDuration.MaxHours = 999;
            this.txtFreezerDuration.MaxLength = 7;
            this.txtFreezerDuration.Name = "txtFreezerDuration";
            this.txtFreezerDuration.Size = new System.Drawing.Size(45, 22);
            this.txtFreezerDuration.TabIndex = 20;
            this.txtFreezerDuration.Validated += new System.EventHandler(this.txtFreezerDuration_Validated);
            // 
            // btnFuelSum
            // 
            this.btnFuelSum.FlatAppearance.BorderSize = 0;
            this.btnFuelSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuelSum.Image = global::Logistics.Properties.Resources.Sum;
            this.btnFuelSum.Location = new System.Drawing.Point(151, 45);
            this.btnFuelSum.Name = "btnFuelSum";
            this.btnFuelSum.Size = new System.Drawing.Size(25, 25);
            this.btnFuelSum.TabIndex = 11;
            this.ttToolTip.SetToolTip(this.btnFuelSum, "Рассчитать количество заправленного топлива по заправкам");
            this.btnFuelSum.UseVisualStyleBackColor = true;
            this.btnFuelSum.Click += new System.EventHandler(this.btnFuelSum_Click);
            // 
            // lblFreezerDurationHours
            // 
            this.lblFreezerDurationHours.AutoSize = true;
            this.lblFreezerDurationHours.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFreezerDurationHours.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFreezerDurationHours.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFreezerDurationHours.Location = new System.Drawing.Point(281, 125);
            this.lblFreezerDurationHours.Name = "lblFreezerDurationHours";
            this.lblFreezerDurationHours.Size = new System.Drawing.Size(52, 14);
            this.lblFreezerDurationHours.TabIndex = 21;
            this.lblFreezerDurationHours.Text = "час:мин";
            // 
            // lblFreezerDuration
            // 
            this.lblFreezerDuration.AutoSize = true;
            this.lblFreezerDuration.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFreezerDuration.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFreezerDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFreezerDuration.Location = new System.Drawing.Point(4, 125);
            this.lblFreezerDuration.Name = "lblFreezerDuration";
            this.lblFreezerDuration.Size = new System.Drawing.Size(228, 14);
            this.lblFreezerDuration.TabIndex = 19;
            this.lblFreezerDuration.Text = "Время работы холодильной установки";
            this.ttToolTip.SetToolTip(this.lblFreezerDuration, "Время работы холодильной установки, час:мин");
            // 
            // lblFreezerTank
            // 
            this.lblFreezerTank.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFreezerTank.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFreezerTank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFreezerTank.Location = new System.Drawing.Point(316, 4);
            this.lblFreezerTank.Name = "lblFreezerTank";
            this.lblFreezerTank.Size = new System.Drawing.Size(59, 14);
            this.lblFreezerTank.TabIndex = 4;
            this.lblFreezerTank.Text = "#FreezerTank#";
            this.ttToolTip.SetToolTip(this.lblFreezerTank, "Емкость топливного бака для холодильной установки");
            // 
            // lblFuelDiffCalc
            // 
            this.lblFuelDiffCalc.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelDiffCalc.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelDiffCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelDiffCalc.Location = new System.Drawing.Point(153, 100);
            this.lblFuelDiffCalc.Name = "lblFuelDiffCalc";
            this.lblFuelDiffCalc.Size = new System.Drawing.Size(200, 14);
            this.lblFuelDiffCalc.TabIndex = 18;
            this.lblFuelDiffCalc.Text = "#полный расчет расхода#";
            this.ttToolTip.SetToolTip(this.lblFuelDiffCalc, "Расчет расхода топлива по нормам");
            // 
            // lblFuelTank
            // 
            this.lblFuelTank.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelTank.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelTank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelTank.Location = new System.Drawing.Point(126, 4);
            this.lblFuelTank.Name = "lblFuelTank";
            this.lblFuelTank.Size = new System.Drawing.Size(80, 14);
            this.lblFuelTank.TabIndex = 2;
            this.lblFuelTank.Text = "#FuelTank#";
            this.ttToolTip.SetToolTip(this.lblFuelTank, "Емкость основного топливного бака");
            // 
            // lblFuelDiff
            // 
            this.lblFuelDiff.AutoSize = true;
            this.lblFuelDiff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelDiff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelDiff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelDiff.Location = new System.Drawing.Point(23, 100);
            this.lblFuelDiff.Name = "lblFuelDiff";
            this.lblFuelDiff.Size = new System.Drawing.Size(46, 14);
            this.lblFuelDiff.TabIndex = 16;
            this.lblFuelDiff.Text = "расход";
            // 
            // numFuelDiff
            // 
            this.numFuelDiff.DecimalPlaces = 1;
            this.numFuelDiff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numFuelDiff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numFuelDiff.Enabled = false;
            this.numFuelDiff.IsNull = false;
            this.numFuelDiff.Location = new System.Drawing.Point(73, 96);
            this.numFuelDiff.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFuelDiff.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numFuelDiff.Name = "numFuelDiff";
            this.numFuelDiff.Size = new System.Drawing.Size(76, 22);
            this.numFuelDiff.TabIndex = 17;
            this.numFuelDiff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numFuelFreezerDataEnd
            // 
            this.numFuelFreezerDataEnd.DecimalPlaces = 1;
            this.numFuelFreezerDataEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numFuelFreezerDataEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numFuelFreezerDataEnd.IsNull = false;
            this.numFuelFreezerDataEnd.Location = new System.Drawing.Point(232, 71);
            this.numFuelFreezerDataEnd.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFuelFreezerDataEnd.Name = "numFuelFreezerDataEnd";
            this.numFuelFreezerDataEnd.Size = new System.Drawing.Size(76, 22);
            this.numFuelFreezerDataEnd.TabIndex = 15;
            this.numFuelFreezerDataEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFuelFreezerDataEnd.ValueChanged += new System.EventHandler(this.numFuelDataEnd_ValueChanged);
            // 
            // numFuelFreezerDataBeg
            // 
            this.numFuelFreezerDataBeg.DecimalPlaces = 1;
            this.numFuelFreezerDataBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numFuelFreezerDataBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numFuelFreezerDataBeg.IsNull = false;
            this.numFuelFreezerDataBeg.Location = new System.Drawing.Point(232, 20);
            this.numFuelFreezerDataBeg.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFuelFreezerDataBeg.Name = "numFuelFreezerDataBeg";
            this.numFuelFreezerDataBeg.Size = new System.Drawing.Size(76, 22);
            this.numFuelFreezerDataBeg.TabIndex = 8;
            this.numFuelFreezerDataBeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFuelFreezerDataBeg.ValueChanged += new System.EventHandler(this.numFuelDataBeg_ValueChanged);
            // 
            // lblFuelFreezer
            // 
            this.lblFuelFreezer.AutoSize = true;
            this.lblFuelFreezer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelFreezer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelFreezer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelFreezer.Location = new System.Drawing.Point(207, 4);
            this.lblFuelFreezer.Name = "lblFuelFreezer";
            this.lblFuelFreezer.Size = new System.Drawing.Size(115, 14);
            this.lblFuelFreezer.TabIndex = 3;
            this.lblFuelFreezer.Text = "бак для холод.уст.";
            this.ttToolTip.SetToolTip(this.lblFuelFreezer, "Топливный бак для холдильной установки");
            // 
            // lblFuelData
            // 
            this.lblFuelData.AutoSize = true;
            this.lblFuelData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelData.Location = new System.Drawing.Point(78, 4);
            this.lblFuelData.Name = "lblFuelData";
            this.lblFuelData.Size = new System.Drawing.Size(50, 14);
            this.lblFuelData.TabIndex = 1;
            this.lblFuelData.Text = "осн.бак";
            this.ttToolTip.SetToolTip(this.lblFuelData, "Основной топливный бак");
            // 
            // lblFuelEnd
            // 
            this.lblFuelEnd.AutoSize = true;
            this.lblFuelEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelEnd.Location = new System.Drawing.Point(38, 75);
            this.lblFuelEnd.Name = "lblFuelEnd";
            this.lblFuelEnd.Size = new System.Drawing.Size(31, 14);
            this.lblFuelEnd.TabIndex = 13;
            this.lblFuelEnd.Text = "кон.";
            // 
            // lblFuelQntFilled
            // 
            this.lblFuelQntFilled.AutoSize = true;
            this.lblFuelQntFilled.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelQntFilled.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelQntFilled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelQntFilled.Location = new System.Drawing.Point(13, 50);
            this.lblFuelQntFilled.Name = "lblFuelQntFilled";
            this.lblFuelQntFilled.Size = new System.Drawing.Size(56, 14);
            this.lblFuelQntFilled.TabIndex = 9;
            this.lblFuelQntFilled.Text = "заправка";
            // 
            // numFuelDataEnd
            // 
            this.numFuelDataEnd.DecimalPlaces = 1;
            this.numFuelDataEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numFuelDataEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numFuelDataEnd.IsNull = false;
            this.numFuelDataEnd.Location = new System.Drawing.Point(73, 71);
            this.numFuelDataEnd.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFuelDataEnd.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numFuelDataEnd.Name = "numFuelDataEnd";
            this.numFuelDataEnd.Size = new System.Drawing.Size(76, 22);
            this.numFuelDataEnd.TabIndex = 14;
            this.numFuelDataEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFuelDataEnd.ValueChanged += new System.EventHandler(this.numFuelDataEnd_ValueChanged);
            // 
            // numFuelQntFilled
            // 
            this.numFuelQntFilled.DecimalPlaces = 1;
            this.numFuelQntFilled.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numFuelQntFilled.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numFuelQntFilled.IsNull = false;
            this.numFuelQntFilled.Location = new System.Drawing.Point(73, 46);
            this.numFuelQntFilled.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFuelQntFilled.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numFuelQntFilled.Name = "numFuelQntFilled";
            this.numFuelQntFilled.Size = new System.Drawing.Size(76, 22);
            this.numFuelQntFilled.TabIndex = 10;
            this.numFuelQntFilled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFuelQntFilled.ValueChanged += new System.EventHandler(this.numFuelDataBeg_ValueChanged);
            // 
            // lblFuelBeg
            // 
            this.lblFuelBeg.AutoSize = true;
            this.lblFuelBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelBeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelBeg.Location = new System.Drawing.Point(38, 25);
            this.lblFuelBeg.Name = "lblFuelBeg";
            this.lblFuelBeg.Size = new System.Drawing.Size(31, 14);
            this.lblFuelBeg.TabIndex = 6;
            this.lblFuelBeg.Text = "нач.";
            // 
            // numFuelDataBeg
            // 
            this.numFuelDataBeg.DecimalPlaces = 1;
            this.numFuelDataBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numFuelDataBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numFuelDataBeg.IsNull = false;
            this.numFuelDataBeg.Location = new System.Drawing.Point(73, 21);
            this.numFuelDataBeg.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numFuelDataBeg.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numFuelDataBeg.Name = "numFuelDataBeg";
            this.numFuelDataBeg.Size = new System.Drawing.Size(76, 22);
            this.numFuelDataBeg.TabIndex = 7;
            this.numFuelDataBeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numFuelDataBeg.ValueChanged += new System.EventHandler(this.numFuelDataBeg_ValueChanged);
            // 
            // chkFuelEdit
            // 
            this.chkFuelEdit.AutoSize = true;
            this.chkFuelEdit.Location = new System.Drawing.Point(7, 25);
            this.chkFuelEdit.Name = "chkFuelEdit";
            this.chkFuelEdit.Size = new System.Drawing.Size(15, 14);
            this.chkFuelEdit.TabIndex = 5;
            this.chkFuelEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttToolTip.SetToolTip(this.chkFuelEdit, "изменить начальный остаток топлива");
            this.chkFuelEdit.UseVisualStyleBackColor = true;
            this.chkFuelEdit.CheckedChanged += new System.EventHandler(this.chkFuelEdit_CheckedChanged);
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuel.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuel.Location = new System.Drawing.Point(4, 4);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(75, 14);
            this.lblFuel.TabIndex = 0;
            this.lblFuel.Text = "Топливо, л:";
            // 
            // lblFuelQntFilledText
            // 
            this.lblFuelQntFilledText.AutoSize = true;
            this.lblFuelQntFilledText.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelQntFilledText.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelQntFilledText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelQntFilledText.Location = new System.Drawing.Point(172, 50);
            this.lblFuelQntFilledText.Name = "lblFuelQntFilledText";
            this.lblFuelQntFilledText.Size = new System.Drawing.Size(48, 14);
            this.lblFuelQntFilledText.TabIndex = 12;
            this.lblFuelQntFilledText.Text = "(всего)";
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDelimiter.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDelimiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDelimiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDelimiter.Location = new System.Drawing.Point(35, 3);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(13, 16);
            this.lblDelimiter.TabIndex = 1;
            // 
            // nudHours
            // 
            this.nudHours.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.nudHours.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.nudHours.IsNull = false;
            this.nudHours.Location = new System.Drawing.Point(0, 0);
            this.nudHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(38, 22);
            this.nudHours.TabIndex = 0;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMinutes
            // 
            this.nudMinutes.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.nudMinutes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.nudMinutes.IsNull = false;
            this.nudMinutes.Location = new System.Drawing.Point(44, 0);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(38, 22);
            this.nudMinutes.TabIndex = 2;
            this.nudMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = global::Logistics.Properties.Resources.Go;
            this.btnClose.Location = new System.Drawing.Point(430, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 30);
            this.btnClose.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnClose, "Сохранить и закрыть");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmWayBillsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 454);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsAccessOn = true;
            this.IsModalMode = true;
            this.LastGrid = this.grdFillings;
            this.Name = "frmWayBillsEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Путевой лист";
            this.Load += new System.EventHandler(this.frmWayBillsEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFillings)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.tcAdd.ResumeLayout(false);
            this.tabFillings.ResumeLayout(false);
            this.tabTrips.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdTrips)).EndInit();
            this.pnlSpeedometer.ResumeLayout(false);
            this.pnlSpeedometer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedometerDataEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedometerDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeedometerDataBeg)).EndInit();
            this.pnlFuel.ResumeLayout(false);
            this.pnlFuel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelFreezerDataEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelFreezerDataBeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelDataEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelQntFilled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFuelDataBeg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMDataGridView grdFillings;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMLabel lblWayBillNumber;
		private RFMBaseClasses.RFMComboBox cboCar;
		private RFMBaseClasses.RFMLabel lblDriverEmployee;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblCarTypeName;
		private RFMBaseClasses.RFMPanel pnlFuel;
		private RFMBaseClasses.RFMPanel pnlSpeedometer;
		private RFMBaseClasses.RFMLabel lblZoneName;
		private RFMBaseClasses.RFMComboBox cboDriverEmployee;
		private RFMBaseClasses.RFMTabControl tcAdd;
		private RFMBaseClasses.RFMTabPage tabFillings;
		private RFMBaseClasses.RFMTabPage tabTrips;
		private RFMBaseClasses.RFMDataGridView grdTrips;
		private RFMBaseClasses.RFMDateTimePicker dtpDateWayEnd;
		private RFMBaseClasses.RFMLabel lblDateWayEnd;
		private RFMBaseClasses.RFMLabel lblDateWayBeg;
		private RFMBaseClasses.RFMDateTimePicker dtpDateWayBeg;
		private RFMBaseClasses.RFMLabel lblReason;
		private RFMBaseClasses.RFMTextBox txtReason;
		private RFMBaseClasses.RFMButton btnReasonSelect;
		private RFMBaseClasses.RFMLabel lblSppedometerDataBeg;
		private RFMBaseClasses.RFMNumericUpDown numSpeedometerDataEnd;
		private RFMBaseClasses.RFMNumericUpDown numSpeedometerDataBeg;
		private RFMBaseClasses.RFMLabel lblSpeedometer;
		private RFMBaseClasses.RFMLabel lblSpeedometerDiff;
		private RFMBaseClasses.RFMNumericUpDown numSpeedometerDiff;
		private RFMBaseClasses.RFMLabel lblSpeedometerDataEnв;
		private RFMBaseClasses.RFMLabel lblFuel;
		private RFMBaseClasses.RFMCheckBox chkSpeedometerEdit;
		private RFMBaseClasses.RFMLabel lblFuelData;
		private RFMBaseClasses.RFMLabel lblFuelEnd;
		private RFMBaseClasses.RFMLabel lblFuelQntFilled;
		private RFMBaseClasses.RFMNumericUpDown numFuelDataEnd;
		private RFMBaseClasses.RFMNumericUpDown numFuelQntFilled;
		private RFMBaseClasses.RFMLabel lblFuelBeg;
		private RFMBaseClasses.RFMNumericUpDown numFuelDataBeg;
		private RFMBaseClasses.RFMCheckBox chkFuelEdit;
		private RFMBaseClasses.RFMNumericUpDown numFuelFreezerDataEnd;
		private RFMBaseClasses.RFMNumericUpDown numFuelFreezerDataBeg;
		private RFMBaseClasses.RFMLabel lblFuelFreezer;
		private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMLabel lblDriverOther;
		private RFMBaseClasses.RFMTextBox txtDriverOther;
		private RFMBaseClasses.RFMButton btnClose;
		private RFMBaseClasses.RFMLabel lblFuelDiff;
		private RFMBaseClasses.RFMNumericUpDown numFuelDiff;
		private RFMBaseClasses.RFMLabel lblFuelDiffCalc;
		private RFMBaseClasses.RFMButton btnCarInfo;
		private RFMBaseClasses.RFMLabel lblFreezerDuration;
		private RFMBaseClasses.RFMLabel lblFreezerTank;
		private RFMBaseClasses.RFMLabel lblFuelTank;
		private RFMBaseClasses.RFMLabel lblFuelQntFilledText;
		private RFMBaseClasses.RFMTextBox txtBillNumber;
		private RFMBaseClasses.RFMLabel lblBillNumber;
		private RFMBaseClasses.RFMLabel lblDelimiter;
		private RFMBaseClasses.RFMNumericUpDown nudHours;
		private RFMBaseClasses.RFMNumericUpDown nudMinutes;
		private RFMBaseClasses.RFMLabel lblFreezerDurationHours;
		private RFMBaseClasses.RFMButton btnFuelSum;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_DateFill;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_FillingType;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_FuelType;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFilings_QntFilled;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFilling_Price;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFilling_Amount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_ID;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcTrips_IsUsed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_DateTrip;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_Alias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrips_ID;
		private RFMBaseClasses.RFMTextBoxTimeEx txtFreezerDuration;

	}
}

