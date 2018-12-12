namespace Logistics
{
	partial class frmSalaryExtraWorksEdit
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
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.lblDateWork = new RFMBaseClasses.RFMLabel();
			this.lblEmployee = new RFMBaseClasses.RFMLabel();
			this.pnlData = new RFMBaseClasses.RFMPanel();
			this.lblAmount = new RFMBaseClasses.RFMLabel();
			this.lblTarif = new RFMBaseClasses.RFMLabel();
			this.lblQnt = new RFMBaseClasses.RFMLabel();
			this.numAmount = new RFMBaseClasses.RFMNumericUpDown();
			this.numTarif = new RFMBaseClasses.RFMNumericUpDown();
			this.numQnt = new RFMBaseClasses.RFMNumericUpDown();
			this.txtTabNumber = new RFMBaseClasses.RFMTextBox();
			this.btnWorkNameSelect = new RFMBaseClasses.RFMButton();
			this.lblExtraWork = new RFMBaseClasses.RFMLabel();
			this.txtWorkName = new RFMBaseClasses.RFMTextBox();
			this.dtpDateWork = new RFMBaseClasses.RFMDateTimePicker();
			this.cboEmployees = new RFMBaseClasses.RFMComboBox();
			this.lblDelimiter = new RFMBaseClasses.RFMLabel();
			this.nudHours = new RFMBaseClasses.RFMNumericUpDown();
			this.nudMinutes = new RFMBaseClasses.RFMNumericUpDown();
			this.pnlData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numTarif)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numQnt)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(5, 131);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(32, 30);
			this.btnHelp.TabIndex = 1;
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
			this.btnExit.Location = new System.Drawing.Point(555, 131);
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
			this.btnSave.Location = new System.Drawing.Point(513, 131);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 30);
			this.btnSave.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtNote
			// 
			this.txtNote.AcceptsReturn = true;
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(114, 91);
			this.txtNote.MaxLength = 200;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(464, 22);
			this.txtNote.TabIndex = 15;
			// 
			// lblNote
			// 
			this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(5, 94);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 14;
			this.lblNote.Text = "Примечание";
			// 
			// lblDateWork
			// 
			this.lblDateWork.AutoSize = true;
			this.lblDateWork.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateWork.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateWork.Location = new System.Drawing.Point(5, 9);
			this.lblDateWork.Name = "lblDateWork";
			this.lblDateWork.Size = new System.Drawing.Size(107, 14);
			this.lblDateWork.TabIndex = 0;
			this.lblDateWork.Text = "Дата выполнения";
			// 
			// lblEmployee
			// 
			this.lblEmployee.AutoSize = true;
			this.lblEmployee.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblEmployee.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblEmployee.Location = new System.Drawing.Point(244, 9);
			this.lblEmployee.Name = "lblEmployee";
			this.lblEmployee.Size = new System.Drawing.Size(82, 14);
			this.lblEmployee.TabIndex = 2;
			this.lblEmployee.Text = "Исполнитель";
			// 
			// pnlData
			// 
			this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlData.Controls.Add(this.lblAmount);
			this.pnlData.Controls.Add(this.lblTarif);
			this.pnlData.Controls.Add(this.lblQnt);
			this.pnlData.Controls.Add(this.numAmount);
			this.pnlData.Controls.Add(this.numTarif);
			this.pnlData.Controls.Add(this.numQnt);
			this.pnlData.Controls.Add(this.txtTabNumber);
			this.pnlData.Controls.Add(this.btnWorkNameSelect);
			this.pnlData.Controls.Add(this.lblExtraWork);
			this.pnlData.Controls.Add(this.txtWorkName);
			this.pnlData.Controls.Add(this.dtpDateWork);
			this.pnlData.Controls.Add(this.cboEmployees);
			this.pnlData.Controls.Add(this.lblDateWork);
			this.pnlData.Controls.Add(this.lblNote);
			this.pnlData.Controls.Add(this.txtNote);
			this.pnlData.Controls.Add(this.lblEmployee);
			this.pnlData.Location = new System.Drawing.Point(3, 5);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(586, 120);
			this.pnlData.TabIndex = 0;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAmount.Location = new System.Drawing.Point(408, 66);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(67, 14);
			this.lblAmount.TabIndex = 12;
			this.lblAmount.Text = "Стоимость";
			// 
			// lblTarif
			// 
			this.lblTarif.AutoSize = true;
			this.lblTarif.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTarif.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTarif.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTarif.Location = new System.Drawing.Point(242, 66);
			this.lblTarif.Name = "lblTarif";
			this.lblTarif.Size = new System.Drawing.Size(45, 14);
			this.lblTarif.TabIndex = 10;
			this.lblTarif.Text = "Тариф";
			// 
			// lblQnt
			// 
			this.lblQnt.AutoSize = true;
			this.lblQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblQnt.Location = new System.Drawing.Point(5, 66);
			this.lblQnt.Name = "lblQnt";
			this.lblQnt.Size = new System.Drawing.Size(74, 14);
			this.lblQnt.TabIndex = 8;
			this.lblQnt.Text = "Количество";
			// 
			// numAmount
			// 
			this.numAmount.DecimalPlaces = 2;
			this.numAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numAmount.Enabled = false;
			this.numAmount.IsNull = false;
			this.numAmount.IsUserDraw = true;
			this.numAmount.Location = new System.Drawing.Point(478, 62);
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
			this.numAmount.Size = new System.Drawing.Size(100, 22);
			this.numAmount.TabIndex = 13;
			this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// numTarif
			// 
			this.numTarif.DecimalPlaces = 2;
			this.numTarif.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numTarif.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numTarif.IsNull = false;
			this.numTarif.Location = new System.Drawing.Point(290, 62);
			this.numTarif.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numTarif.Name = "numTarif";
			this.numTarif.Size = new System.Drawing.Size(100, 22);
			this.numTarif.TabIndex = 11;
			this.numTarif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numTarif.Validated += new System.EventHandler(this.numQnt_Validated);
			// 
			// numQnt
			// 
			this.numQnt.DecimalPlaces = 1;
			this.numQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numQnt.IsNull = false;
			this.numQnt.Location = new System.Drawing.Point(114, 62);
			this.numQnt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
			this.numQnt.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
			this.numQnt.Name = "numQnt";
			this.numQnt.Size = new System.Drawing.Size(100, 22);
			this.numQnt.TabIndex = 9;
			this.numQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numQnt.Validated += new System.EventHandler(this.numQnt_Validated);
			// 
			// txtTabNumber
			// 
			this.txtTabNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtTabNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTabNumber.Enabled = false;
			this.txtTabNumber.Location = new System.Drawing.Point(324, 5);
			this.txtTabNumber.MaxLength = 3;
			this.txtTabNumber.Name = "txtTabNumber";
			this.txtTabNumber.Size = new System.Drawing.Size(10, 22);
			this.txtTabNumber.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.txtTabNumber, "Табельный номер");
			this.txtTabNumber.Visible = false;
			this.txtTabNumber.TextChanged += new System.EventHandler(this.txtTabNumber_TextChanged);
			// 
			// btnWorkNameSelect
			// 
			this.btnWorkNameSelect.FlatAppearance.BorderSize = 0;
			this.btnWorkNameSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWorkNameSelect.Image = global::Logistics.Properties.Resources.Detail;
			this.btnWorkNameSelect.Location = new System.Drawing.Point(551, 31);
			this.btnWorkNameSelect.Name = "btnWorkNameSelect";
			this.btnWorkNameSelect.Size = new System.Drawing.Size(25, 25);
			this.btnWorkNameSelect.TabIndex = 7;
			this.ttToolTip.SetToolTip(this.btnWorkNameSelect, "Выбрать из ранее введенных значений");
			this.btnWorkNameSelect.UseVisualStyleBackColor = true;
			this.btnWorkNameSelect.Click += new System.EventHandler(this.btnWorkNameSelect_Click);
			// 
			// lblExtraWork
			// 
			this.lblExtraWork.AutoSize = true;
			this.lblExtraWork.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblExtraWork.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblExtraWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblExtraWork.Location = new System.Drawing.Point(5, 37);
			this.lblExtraWork.Name = "lblExtraWork";
			this.lblExtraWork.Size = new System.Drawing.Size(76, 14);
			this.lblExtraWork.TabIndex = 5;
			this.lblExtraWork.Text = "Доп. работа";
			// 
			// txtWorkName
			// 
			this.txtWorkName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtWorkName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtWorkName.Location = new System.Drawing.Point(114, 33);
			this.txtWorkName.MaxLength = 200;
			this.txtWorkName.Name = "txtWorkName";
			this.txtWorkName.Size = new System.Drawing.Size(433, 22);
			this.txtWorkName.TabIndex = 6;
			// 
			// dtpDateWork
			// 
			this.dtpDateWork.CustomFormat = "dd.MM.yyyy";
			this.dtpDateWork.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateWork.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateWork.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateWork.Location = new System.Drawing.Point(114, 5);
			this.dtpDateWork.Name = "dtpDateWork";
			this.dtpDateWork.Size = new System.Drawing.Size(96, 22);
			this.dtpDateWork.TabIndex = 1;
			// 
			// cboEmployees
			// 
			this.cboEmployees.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboEmployees.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboEmployees.FormattingEnabled = true;
			this.cboEmployees.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboEmployees.Location = new System.Drawing.Point(330, 5);
			this.cboEmployees.Name = "cboEmployees";
			this.cboEmployees.Size = new System.Drawing.Size(248, 22);
			this.cboEmployees.TabIndex = 4;
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
			// frmSalaryExtraWorksEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 166);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.hpHelp.SetHelpKeyword(this, "");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsAccessOn = true;
			this.IsModalMode = true;
			this.Name = "frmSalaryExtraWorksEdit";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Дополнительная работа";
			this.Load += new System.EventHandler(this.frmSalaryExtraWorksEdit_Load);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numTarif)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numQnt)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMLabel lblDateWork;
		private RFMBaseClasses.RFMLabel lblEmployee;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMComboBox cboEmployees;
		private RFMBaseClasses.RFMDateTimePicker dtpDateWork;
		private RFMBaseClasses.RFMLabel lblExtraWork;
		private RFMBaseClasses.RFMTextBox txtWorkName;
		private RFMBaseClasses.RFMButton btnWorkNameSelect;
		private RFMBaseClasses.RFMLabel lblDelimiter;
		private RFMBaseClasses.RFMNumericUpDown nudHours;
		private RFMBaseClasses.RFMNumericUpDown nudMinutes;
		private RFMBaseClasses.RFMTextBox txtTabNumber;
		private RFMBaseClasses.RFMLabel lblQnt;
		private RFMBaseClasses.RFMNumericUpDown numAmount;
		private RFMBaseClasses.RFMNumericUpDown numTarif;
		private RFMBaseClasses.RFMNumericUpDown numQnt;
		private RFMBaseClasses.RFMLabel lblAmount;
		private RFMBaseClasses.RFMLabel lblTarif;

	}
}

