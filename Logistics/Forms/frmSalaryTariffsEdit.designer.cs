namespace Logistics
{
	partial class frmSalaryTariffsEdit
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
            this.gbPenalty = new RFMBaseClasses.RFMGroupBox();
            this.numNettoTariff = new RFMBaseClasses.RFMNumericUpDown();
            this.numTimeTariff = new RFMBaseClasses.RFMNumericUpDown();
            this.numEarlyDepartureTariff = new RFMBaseClasses.RFMNumericUpDown();
            this.lblEarlyDepartureTariff = new RFMBaseClasses.RFMLabel();
            this.lblNettoTariff = new RFMBaseClasses.RFMLabel();
            this.lblTimeTariff = new RFMBaseClasses.RFMLabel();
            this.gbDirect = new RFMBaseClasses.RFMGroupBox();
            this.lblDistance = new RFMBaseClasses.RFMLabel();
            this.numDistance = new RFMBaseClasses.RFMNumericUpDown();
            this.numInPoints = new RFMBaseClasses.RFMNumericUpDown();
            this.lblInPoints = new RFMBaseClasses.RFMLabel();
            this.numRetPoints = new RFMBaseClasses.RFMNumericUpDown();
            this.numOutPoints = new RFMBaseClasses.RFMNumericUpDown();
            this.numOutNetto = new RFMBaseClasses.RFMNumericUpDown();
            this.numDaysWorking = new RFMBaseClasses.RFMNumericUpDown();
            this.lblDaysWorking = new RFMBaseClasses.RFMLabel();
            this.lblOutPoints = new RFMBaseClasses.RFMLabel();
            this.lblRetPoints = new RFMBaseClasses.RFMLabel();
            this.lblOutNetto = new RFMBaseClasses.RFMLabel();
            this.dtpDateBeg = new RFMBaseClasses.RFMDateTimePicker();
            this.lblDateBeg = new RFMBaseClasses.RFMLabel();
            this.pnlData.SuspendLayout();
            this.gbPenalty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNettoTariff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTariff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEarlyDepartureTariff)).BeginInit();
            this.gbDirect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutNetto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysWorking)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 355);
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
            this.btnExit.Location = new System.Drawing.Point(345, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(295, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 1;
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
            this.pnlData.Controls.Add(this.gbPenalty);
            this.pnlData.Controls.Add(this.gbDirect);
            this.pnlData.Controls.Add(this.dtpDateBeg);
            this.pnlData.Controls.Add(this.lblDateBeg);
            this.pnlData.Location = new System.Drawing.Point(3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(378, 343);
            this.pnlData.TabIndex = 0;
            // 
            // gbPenalty
            // 
            this.gbPenalty.Controls.Add(this.numNettoTariff);
            this.gbPenalty.Controls.Add(this.numTimeTariff);
            this.gbPenalty.Controls.Add(this.numEarlyDepartureTariff);
            this.gbPenalty.Controls.Add(this.lblEarlyDepartureTariff);
            this.gbPenalty.Controls.Add(this.lblNettoTariff);
            this.gbPenalty.Controls.Add(this.lblTimeTariff);
            this.gbPenalty.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPenalty.Location = new System.Drawing.Point(5, 230);
            this.gbPenalty.Name = "gbPenalty";
            this.gbPenalty.Size = new System.Drawing.Size(364, 100);
            this.gbPenalty.TabIndex = 16;
            this.gbPenalty.TabStop = false;
            this.gbPenalty.Text = "Тарифы для расчета по системе штрафов";
            // 
            // numNettoTariff
            // 
            this.numNettoTariff.DecimalPlaces = 2;
            this.numNettoTariff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numNettoTariff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numNettoTariff.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numNettoTariff.InputMask = "#####0.00";
            this.numNettoTariff.IsNull = false;
            this.numNettoTariff.Location = new System.Drawing.Point(261, 70);
            this.numNettoTariff.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numNettoTariff.Name = "numNettoTariff";
            this.numNettoTariff.RealPlaces = 6;
            this.numNettoTariff.Size = new System.Drawing.Size(90, 22);
            this.numNettoTariff.TabIndex = 21;
            this.numNettoTariff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numTimeTariff
            // 
            this.numTimeTariff.DecimalPlaces = 2;
            this.numTimeTariff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numTimeTariff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numTimeTariff.InputMask = "#####0.00";
            this.numTimeTariff.IsNull = false;
            this.numTimeTariff.Location = new System.Drawing.Point(261, 45);
            this.numTimeTariff.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numTimeTariff.Name = "numTimeTariff";
            this.numTimeTariff.RealPlaces = 6;
            this.numTimeTariff.Size = new System.Drawing.Size(90, 22);
            this.numTimeTariff.TabIndex = 19;
            this.numTimeTariff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numEarlyDepartureTariff
            // 
            this.numEarlyDepartureTariff.DecimalPlaces = 2;
            this.numEarlyDepartureTariff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numEarlyDepartureTariff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numEarlyDepartureTariff.InputMask = "#####0.00";
            this.numEarlyDepartureTariff.IsNull = false;
            this.numEarlyDepartureTariff.Location = new System.Drawing.Point(261, 20);
            this.numEarlyDepartureTariff.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numEarlyDepartureTariff.Name = "numEarlyDepartureTariff";
            this.numEarlyDepartureTariff.RealPlaces = 6;
            this.numEarlyDepartureTariff.Size = new System.Drawing.Size(90, 22);
            this.numEarlyDepartureTariff.TabIndex = 17;
            this.numEarlyDepartureTariff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEarlyDepartureTariff
            // 
            this.lblEarlyDepartureTariff.AutoSize = true;
            this.lblEarlyDepartureTariff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblEarlyDepartureTariff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblEarlyDepartureTariff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEarlyDepartureTariff.Location = new System.Drawing.Point(10, 23);
            this.lblEarlyDepartureTariff.Name = "lblEarlyDepartureTariff";
            this.lblEarlyDepartureTariff.Size = new System.Drawing.Size(101, 14);
            this.lblEarlyDepartureTariff.TabIndex = 16;
            this.lblEarlyDepartureTariff.Text = "За ранний выезд";
            // 
            // lblNettoTariff
            // 
            this.lblNettoTariff.AutoSize = true;
            this.lblNettoTariff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNettoTariff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNettoTariff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNettoTariff.Location = new System.Drawing.Point(10, 73);
            this.lblNettoTariff.Name = "lblNettoTariff";
            this.lblNettoTariff.Size = new System.Drawing.Size(136, 14);
            this.lblNettoTariff.TabIndex = 20;
            this.lblNettoTariff.Text = "За переработку грузов";
            // 
            // lblTimeTariff
            // 
            this.lblTimeTariff.AutoSize = true;
            this.lblTimeTariff.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTimeTariff.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTimeTariff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeTariff.Location = new System.Drawing.Point(10, 48);
            this.lblTimeTariff.Name = "lblTimeTariff";
            this.lblTimeTariff.Size = new System.Drawing.Size(234, 14);
            this.lblTimeTariff.TabIndex = 18;
            this.lblTimeTariff.Text = "За время (дорога + простой у клиента)";
            // 
            // gbDirect
            // 
            this.gbDirect.Controls.Add(this.lblDistance);
            this.gbDirect.Controls.Add(this.numDistance);
            this.gbDirect.Controls.Add(this.numInPoints);
            this.gbDirect.Controls.Add(this.lblInPoints);
            this.gbDirect.Controls.Add(this.numRetPoints);
            this.gbDirect.Controls.Add(this.numOutPoints);
            this.gbDirect.Controls.Add(this.numOutNetto);
            this.gbDirect.Controls.Add(this.numDaysWorking);
            this.gbDirect.Controls.Add(this.lblDaysWorking);
            this.gbDirect.Controls.Add(this.lblOutPoints);
            this.gbDirect.Controls.Add(this.lblRetPoints);
            this.gbDirect.Controls.Add(this.lblOutNetto);
            this.gbDirect.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDirect.Location = new System.Drawing.Point(5, 35);
            this.gbDirect.Name = "gbDirect";
            this.gbDirect.Size = new System.Drawing.Size(364, 180);
            this.gbDirect.TabIndex = 15;
            this.gbDirect.TabStop = false;
            this.gbDirect.Text = "Тарифы для прямого расчета";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistance.Location = new System.Drawing.Point(10, 148);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(98, 14);
            this.lblDistance.TabIndex = 20;
            this.lblDistance.Text = "За 1 км пробега";
            // 
            // numDistance
            // 
            this.numDistance.DecimalPlaces = 2;
            this.numDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numDistance.InputMask = "#####0.00";
            this.numDistance.IsNull = false;
            this.numDistance.Location = new System.Drawing.Point(261, 145);
            this.numDistance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.RealPlaces = 6;
            this.numDistance.Size = new System.Drawing.Size(90, 22);
            this.numDistance.TabIndex = 21;
            this.numDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numInPoints
            // 
            this.numInPoints.DecimalPlaces = 2;
            this.numInPoints.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numInPoints.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numInPoints.InputMask = "#####0.00";
            this.numInPoints.IsNull = false;
            this.numInPoints.Location = new System.Drawing.Point(261, 120);
            this.numInPoints.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numInPoints.Name = "numInPoints";
            this.numInPoints.RealPlaces = 6;
            this.numInPoints.Size = new System.Drawing.Size(90, 22);
            this.numInPoints.TabIndex = 19;
            this.numInPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblInPoints
            // 
            this.lblInPoints.AutoSize = true;
            this.lblInPoints.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblInPoints.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInPoints.Location = new System.Drawing.Point(10, 123);
            this.lblInPoints.Name = "lblInPoints";
            this.lblInPoints.Size = new System.Drawing.Size(246, 14);
            this.lblInPoints.TabIndex = 18;
            this.lblInPoints.Text = "За доставку товара от одного поставщика";
            // 
            // numRetPoints
            // 
            this.numRetPoints.DecimalPlaces = 2;
            this.numRetPoints.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numRetPoints.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numRetPoints.InputMask = "#####0.00";
            this.numRetPoints.IsNull = false;
            this.numRetPoints.Location = new System.Drawing.Point(261, 95);
            this.numRetPoints.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numRetPoints.Name = "numRetPoints";
            this.numRetPoints.RealPlaces = 6;
            this.numRetPoints.Size = new System.Drawing.Size(90, 22);
            this.numRetPoints.TabIndex = 17;
            this.numRetPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numOutPoints
            // 
            this.numOutPoints.DecimalPlaces = 2;
            this.numOutPoints.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numOutPoints.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numOutPoints.InputMask = "#####0.00";
            this.numOutPoints.IsNull = false;
            this.numOutPoints.Location = new System.Drawing.Point(261, 70);
            this.numOutPoints.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numOutPoints.Name = "numOutPoints";
            this.numOutPoints.RealPlaces = 6;
            this.numOutPoints.Size = new System.Drawing.Size(90, 22);
            this.numOutPoints.TabIndex = 15;
            this.numOutPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numOutNetto
            // 
            this.numOutNetto.DecimalPlaces = 2;
            this.numOutNetto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numOutNetto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numOutNetto.InputMask = "#####0.00";
            this.numOutNetto.IsNull = false;
            this.numOutNetto.Location = new System.Drawing.Point(261, 45);
            this.numOutNetto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numOutNetto.Name = "numOutNetto";
            this.numOutNetto.RealPlaces = 6;
            this.numOutNetto.Size = new System.Drawing.Size(90, 22);
            this.numOutNetto.TabIndex = 13;
            this.numOutNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numDaysWorking
            // 
            this.numDaysWorking.DecimalPlaces = 2;
            this.numDaysWorking.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numDaysWorking.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numDaysWorking.InputMask = "#####0.00";
            this.numDaysWorking.IsNull = false;
            this.numDaysWorking.Location = new System.Drawing.Point(261, 20);
            this.numDaysWorking.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDaysWorking.Name = "numDaysWorking";
            this.numDaysWorking.RealPlaces = 6;
            this.numDaysWorking.Size = new System.Drawing.Size(90, 22);
            this.numDaysWorking.TabIndex = 11;
            this.numDaysWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDaysWorking
            // 
            this.lblDaysWorking.AutoSize = true;
            this.lblDaysWorking.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDaysWorking.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDaysWorking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDaysWorking.Location = new System.Drawing.Point(10, 23);
            this.lblDaysWorking.Name = "lblDaysWorking";
            this.lblDaysWorking.Size = new System.Drawing.Size(146, 14);
            this.lblDaysWorking.TabIndex = 10;
            this.lblDaysWorking.Text = "За 1 отработанный день";
            // 
            // lblOutPoints
            // 
            this.lblOutPoints.AutoSize = true;
            this.lblOutPoints.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutPoints.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutPoints.Location = new System.Drawing.Point(10, 73);
            this.lblOutPoints.Name = "lblOutPoints";
            this.lblOutPoints.Size = new System.Drawing.Size(192, 14);
            this.lblOutPoints.TabIndex = 14;
            this.lblOutPoints.Text = "За доставку товара в одну точку";
            // 
            // lblRetPoints
            // 
            this.lblRetPoints.AutoSize = true;
            this.lblRetPoints.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblRetPoints.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblRetPoints.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRetPoints.Location = new System.Drawing.Point(10, 98);
            this.lblRetPoints.Name = "lblRetPoints";
            this.lblRetPoints.Size = new System.Drawing.Size(200, 14);
            this.lblRetPoints.TabIndex = 16;
            this.lblRetPoints.Text = "За возврат товара из одной точки";
            // 
            // lblOutNetto
            // 
            this.lblOutNetto.AutoSize = true;
            this.lblOutNetto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutNetto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutNetto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutNetto.Location = new System.Drawing.Point(10, 48);
            this.lblOutNetto.Name = "lblOutNetto";
            this.lblOutNetto.Size = new System.Drawing.Size(196, 14);
            this.lblOutNetto.TabIndex = 12;
            this.lblOutNetto.Text = "За 1 доставленный кг веса нетто";
            // 
            // dtpDateBeg
            // 
            this.dtpDateBeg.CustomFormat = "dd.MM.yyyy";
            this.dtpDateBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDateBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDateBeg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateBeg.Location = new System.Drawing.Point(265, 4);
            this.dtpDateBeg.Name = "dtpDateBeg";
            this.dtpDateBeg.Size = new System.Drawing.Size(89, 22);
            this.dtpDateBeg.TabIndex = 1;
            // 
            // lblDateBeg
            // 
            this.lblDateBeg.AutoSize = true;
            this.lblDateBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateBeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateBeg.Location = new System.Drawing.Point(13, 7);
            this.lblDateBeg.Name = "lblDateBeg";
            this.lblDateBeg.Size = new System.Drawing.Size(133, 14);
            this.lblDateBeg.TabIndex = 0;
            this.lblDateBeg.Text = "Дата начала действия";
            // 
            // frmSalaryTariffsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 391);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmSalaryTariffsEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы по видам работ";
            this.Load += new System.EventHandler(this.frmSalaryTariffsEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.gbPenalty.ResumeLayout(false);
            this.gbPenalty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNettoTariff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeTariff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEarlyDepartureTariff)).EndInit();
            this.gbDirect.ResumeLayout(false);
            this.gbDirect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRetPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOutNetto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysWorking)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMPanel pnlData;
        private RFMBaseClasses.RFMLabel lblDateBeg;
        private RFMBaseClasses.RFMDateTimePicker dtpDateBeg;
        private RFMBaseClasses.RFMGroupBox gbDirect;
        private RFMBaseClasses.RFMLabel lblDistance;
        private RFMBaseClasses.RFMNumericUpDown numDistance;
        private RFMBaseClasses.RFMNumericUpDown numInPoints;
        private RFMBaseClasses.RFMLabel lblInPoints;
        private RFMBaseClasses.RFMNumericUpDown numRetPoints;
        private RFMBaseClasses.RFMNumericUpDown numOutPoints;
        private RFMBaseClasses.RFMNumericUpDown numOutNetto;
        private RFMBaseClasses.RFMNumericUpDown numDaysWorking;
        private RFMBaseClasses.RFMLabel lblDaysWorking;
        private RFMBaseClasses.RFMLabel lblOutPoints;
        private RFMBaseClasses.RFMLabel lblRetPoints;
        private RFMBaseClasses.RFMLabel lblOutNetto;
        private RFMBaseClasses.RFMGroupBox gbPenalty;
        private RFMBaseClasses.RFMNumericUpDown numNettoTariff;
        private RFMBaseClasses.RFMNumericUpDown numTimeTariff;
        private RFMBaseClasses.RFMNumericUpDown numEarlyDepartureTariff;
        private RFMBaseClasses.RFMLabel lblEarlyDepartureTariff;
        private RFMBaseClasses.RFMLabel lblNettoTariff;
        private RFMBaseClasses.RFMLabel lblTimeTariff;

	}
}

