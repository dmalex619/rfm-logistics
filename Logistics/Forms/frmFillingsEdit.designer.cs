namespace Logistics
{
	partial class frmFillingsEdit
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
            this.txtNote = new RFMBaseClasses.RFMTextBox();
            this.numAmount = new RFMBaseClasses.RFMNumericUpDown();
            this.lblAmount = new RFMBaseClasses.RFMLabel();
            this.numPrice = new RFMBaseClasses.RFMNumericUpDown();
            this.lblPrice = new RFMBaseClasses.RFMLabel();
            this.numQntFilled = new RFMBaseClasses.RFMNumericUpDown();
            this.lblQntFilled = new RFMBaseClasses.RFMLabel();
            this.cboFuelType = new RFMBaseClasses.RFMComboBox();
            this.lblFuelType = new RFMBaseClasses.RFMLabel();
            this.cboFillingType = new RFMBaseClasses.RFMComboBox();
            this.lblFillingType = new RFMBaseClasses.RFMLabel();
            this.cboDriverEmployee = new RFMBaseClasses.RFMComboBox();
            this.lblDriver = new RFMBaseClasses.RFMLabel();
            this.cboCar = new RFMBaseClasses.RFMComboBox();
            this.lblCar = new RFMBaseClasses.RFMLabel();
            this.dtpDateFill = new RFMBaseClasses.RFMDateTimePicker();
            this.lblDateFill = new RFMBaseClasses.RFMLabel();
            this.btnCalc = new RFMBaseClasses.RFMButton();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntFilled)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 300);
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
            this.btnExit.Location = new System.Drawing.Point(278, 300);
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
            this.btnSave.Location = new System.Drawing.Point(228, 300);
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
            this.pnlData.Controls.Add(this.btnCalc);
            this.pnlData.Controls.Add(this.txtNote);
            this.pnlData.Controls.Add(this.numAmount);
            this.pnlData.Controls.Add(this.lblAmount);
            this.pnlData.Controls.Add(this.numPrice);
            this.pnlData.Controls.Add(this.lblPrice);
            this.pnlData.Controls.Add(this.numQntFilled);
            this.pnlData.Controls.Add(this.lblQntFilled);
            this.pnlData.Controls.Add(this.cboFuelType);
            this.pnlData.Controls.Add(this.lblFuelType);
            this.pnlData.Controls.Add(this.cboFillingType);
            this.pnlData.Controls.Add(this.lblFillingType);
            this.pnlData.Controls.Add(this.cboDriverEmployee);
            this.pnlData.Controls.Add(this.lblDriver);
            this.pnlData.Controls.Add(this.cboCar);
            this.pnlData.Controls.Add(this.lblCar);
            this.pnlData.Controls.Add(this.dtpDateFill);
            this.pnlData.Controls.Add(this.lblDateFill);
            this.pnlData.Location = new System.Drawing.Point(5, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(306, 287);
            this.pnlData.TabIndex = 0;
            // 
            // txtNote
            // 
            this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(7, 250);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(290, 22);
            this.txtNote.TabIndex = 16;
            // 
            // numAmount
            // 
            this.numAmount.DecimalPlaces = 2;
            this.numAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numAmount.IsNull = false;
            this.numAmount.Location = new System.Drawing.Point(96, 220);
            this.numAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(90, 22);
            this.numAmount.TabIndex = 15;
            this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numAmount.ValueChanged += new System.EventHandler(this.numAmount_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAmount.Location = new System.Drawing.Point(35, 223);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(58, 14);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "на сумму";
            // 
            // numPrice
            // 
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numPrice.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numPrice.IsNull = false;
            this.numPrice.Location = new System.Drawing.Point(96, 190);
            this.numPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPrice.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(90, 22);
            this.numPrice.TabIndex = 13;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrice.ValueChanged += new System.EventHandler(this.numPrice_ValueChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Location = new System.Drawing.Point(40, 193);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 14);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "по цене";
            // 
            // numQntFilled
            // 
            this.numQntFilled.DecimalPlaces = 1;
            this.numQntFilled.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numQntFilled.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numQntFilled.IsNull = false;
            this.numQntFilled.Location = new System.Drawing.Point(96, 160);
            this.numQntFilled.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numQntFilled.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
            this.numQntFilled.Name = "numQntFilled";
            this.numQntFilled.Size = new System.Drawing.Size(90, 22);
            this.numQntFilled.TabIndex = 11;
            this.numQntFilled.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numQntFilled.ValueChanged += new System.EventHandler(this.numQntFilled_ValueChanged);
            // 
            // lblQntFilled
            // 
            this.lblQntFilled.AutoSize = true;
            this.lblQntFilled.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblQntFilled.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblQntFilled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQntFilled.Location = new System.Drawing.Point(5, 163);
            this.lblQntFilled.Name = "lblQntFilled";
            this.lblQntFilled.Size = new System.Drawing.Size(88, 14);
            this.lblQntFilled.TabIndex = 10;
            this.lblQntFilled.Text = "Заправлено, л";
            // 
            // cboFuelType
            // 
            this.cboFuelType.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboFuelType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboFuelType.FormattingEnabled = true;
            this.cboFuelType.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboFuelType.Location = new System.Drawing.Point(96, 125);
            this.cboFuelType.Name = "cboFuelType";
            this.cboFuelType.Size = new System.Drawing.Size(200, 22);
            this.cboFuelType.TabIndex = 9;
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFuelType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFuelType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFuelType.Location = new System.Drawing.Point(5, 128);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(56, 14);
            this.lblFuelType.TabIndex = 8;
            this.lblFuelType.Text = "Топливо";
            // 
            // cboFillingType
            // 
            this.cboFillingType.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboFillingType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboFillingType.FormattingEnabled = true;
            this.cboFillingType.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboFillingType.Location = new System.Drawing.Point(96, 95);
            this.cboFillingType.Name = "cboFillingType";
            this.cboFillingType.Size = new System.Drawing.Size(200, 22);
            this.cboFillingType.TabIndex = 7;
            // 
            // lblFillingType
            // 
            this.lblFillingType.AutoSize = true;
            this.lblFillingType.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblFillingType.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblFillingType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFillingType.Location = new System.Drawing.Point(5, 98);
            this.lblFillingType.Name = "lblFillingType";
            this.lblFillingType.Size = new System.Drawing.Size(83, 14);
            this.lblFillingType.TabIndex = 6;
            this.lblFillingType.Text = "Тип заправки";
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
            this.cboDriverEmployee.Location = new System.Drawing.Point(96, 65);
            this.cboDriverEmployee.Name = "cboDriverEmployee";
            this.cboDriverEmployee.Size = new System.Drawing.Size(200, 22);
            this.cboDriverEmployee.TabIndex = 5;
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriver.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriver.Location = new System.Drawing.Point(5, 68);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(61, 14);
            this.lblDriver.TabIndex = 4;
            this.lblDriver.Text = "Водитель";
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
            this.cboCar.Location = new System.Drawing.Point(96, 35);
            this.cboCar.Name = "cboCar";
            this.cboCar.Size = new System.Drawing.Size(200, 22);
            this.cboCar.TabIndex = 3;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCar.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCar.Location = new System.Drawing.Point(5, 38);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(50, 14);
            this.lblCar.TabIndex = 2;
            this.lblCar.Text = "Машина";
            // 
            // dtpDateFill
            // 
            this.dtpDateFill.CustomFormat = "dd.MM.yyyy";
            this.dtpDateFill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDateFill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDateFill.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFill.Location = new System.Drawing.Point(96, 5);
            this.dtpDateFill.Name = "dtpDateFill";
            this.dtpDateFill.Size = new System.Drawing.Size(100, 22);
            this.dtpDateFill.TabIndex = 1;
            // 
            // lblDateFill
            // 
            this.lblDateFill.AutoSize = true;
            this.lblDateFill.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateFill.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateFill.Location = new System.Drawing.Point(5, 9);
            this.lblDateFill.Name = "lblDateFill";
            this.lblDateFill.Size = new System.Drawing.Size(87, 14);
            this.lblDateFill.TabIndex = 0;
            this.lblDateFill.Text = "Дата заправки";
            // 
            // btnCalc
            // 
            this.btnCalc.Image = global::Logistics.Properties.Resources.Calc;
            this.btnCalc.Location = new System.Drawing.Point(221, 158);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(32, 30);
            this.btnCalc.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnCalc, "Ввод нескольких чеков");
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmFillingsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 336);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmFillingsEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заправка топлива";
            this.Load += new System.EventHandler(this.frmFillingsEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQntFilled)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblDateFill;
		private RFMBaseClasses.RFMLabel lblCar;
		private RFMBaseClasses.RFMDateTimePicker dtpDateFill;
		private RFMBaseClasses.RFMComboBox cboFuelType;
		private RFMBaseClasses.RFMLabel lblFuelType;
		private RFMBaseClasses.RFMComboBox cboFillingType;
		private RFMBaseClasses.RFMLabel lblFillingType;
		private RFMBaseClasses.RFMComboBox cboDriverEmployee;
		private RFMBaseClasses.RFMLabel lblDriver;
		private RFMBaseClasses.RFMComboBox cboCar;
		private RFMBaseClasses.RFMLabel lblQntFilled;
		private RFMBaseClasses.RFMNumericUpDown numAmount;
		private RFMBaseClasses.RFMLabel lblAmount;
		private RFMBaseClasses.RFMNumericUpDown numPrice;
		private RFMBaseClasses.RFMLabel lblPrice;
		private RFMBaseClasses.RFMNumericUpDown numQntFilled;
		private RFMBaseClasses.RFMTextBox txtNote;
        private RFMBaseClasses.RFMButton btnCalc;

	}
}

