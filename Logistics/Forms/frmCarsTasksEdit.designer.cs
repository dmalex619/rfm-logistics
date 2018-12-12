namespace Logistics
{
	partial class frmCarsTasksEdit
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
            this.txtLatitude = new RFMBaseClasses.RFMTextBox();
            this.lblPrice = new RFMBaseClasses.RFMLabel();
            this.numPrice = new RFMBaseClasses.RFMNumericUpDown();
            this.lblUnitsQnt = new RFMBaseClasses.RFMLabel();
            this.numUnitsQnt = new RFMBaseClasses.RFMNumericUpDown();
            this.lblTaskAmount = new RFMBaseClasses.RFMLabel();
            this.numTaskAmount = new RFMBaseClasses.RFMNumericUpDown();
            this.lblTaskOuterCost = new RFMBaseClasses.RFMLabel();
            this.numTaskOuterCost = new RFMBaseClasses.RFMNumericUpDown();
            this.btnLocate = new RFMBaseClasses.RFMButton();
            this.lblBrutto = new RFMBaseClasses.RFMLabel();
            this.numBrutto = new RFMBaseClasses.RFMNumericUpDown();
            this.dtpDateTask = new RFMBaseClasses.RFMDateTimePicker();
            this.lblTaskInnerCost = new RFMBaseClasses.RFMLabel();
            this.numTaskInnerCost = new RFMBaseClasses.RFMNumericUpDown();
            this.cboZone = new RFMBaseClasses.RFMComboBox();
            this.lblZone = new RFMBaseClasses.RFMLabel();
            this.lblNote = new RFMBaseClasses.RFMLabel();
            this.txtNote = new RFMBaseClasses.RFMTextBox();
            this.cboUnit = new RFMBaseClasses.RFMComboBox();
            this.lblUnit = new RFMBaseClasses.RFMLabel();
            this.numDistance = new RFMBaseClasses.RFMNumericUpDown();
            this.lblPalletsQnt = new RFMBaseClasses.RFMLabel();
            this.numPalletsQnt = new RFMBaseClasses.RFMNumericUpDown();
            this.lblNetto = new RFMBaseClasses.RFMLabel();
            this.numNetto = new RFMBaseClasses.RFMNumericUpDown();
            this.cboPartner = new RFMBaseClasses.RFMComboBox();
            this.lblPartner = new RFMBaseClasses.RFMLabel();
            this.lblDeliveryAddress = new RFMBaseClasses.RFMLabel();
            this.txtDeliveryAddress = new RFMBaseClasses.RFMTextBox();
            this.lblDateTask = new RFMBaseClasses.RFMLabel();
            this.chkIsCash = new RFMBaseClasses.RFMCheckBox();
            this.lblCoordinates = new RFMBaseClasses.RFMLabel();
            this.txtLongitude = new RFMBaseClasses.RFMTextBox();
            this.lblDistance = new RFMBaseClasses.RFMLabel();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskOuterCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskInnerCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPalletsQnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNetto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(8, 489);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(37, 39);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(627, 489);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 39);
            this.btnExit.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(570, 489);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(37, 39);
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
            this.pnlData.Controls.Add(this.txtLatitude);
            this.pnlData.Controls.Add(this.lblPrice);
            this.pnlData.Controls.Add(this.numPrice);
            this.pnlData.Controls.Add(this.lblUnitsQnt);
            this.pnlData.Controls.Add(this.numUnitsQnt);
            this.pnlData.Controls.Add(this.lblTaskAmount);
            this.pnlData.Controls.Add(this.numTaskAmount);
            this.pnlData.Controls.Add(this.lblTaskOuterCost);
            this.pnlData.Controls.Add(this.numTaskOuterCost);
            this.pnlData.Controls.Add(this.btnLocate);
            this.pnlData.Controls.Add(this.lblBrutto);
            this.pnlData.Controls.Add(this.numBrutto);
            this.pnlData.Controls.Add(this.dtpDateTask);
            this.pnlData.Controls.Add(this.lblTaskInnerCost);
            this.pnlData.Controls.Add(this.numTaskInnerCost);
            this.pnlData.Controls.Add(this.cboZone);
            this.pnlData.Controls.Add(this.lblZone);
            this.pnlData.Controls.Add(this.lblNote);
            this.pnlData.Controls.Add(this.txtNote);
            this.pnlData.Controls.Add(this.cboUnit);
            this.pnlData.Controls.Add(this.lblUnit);
            this.pnlData.Controls.Add(this.numDistance);
            this.pnlData.Controls.Add(this.lblPalletsQnt);
            this.pnlData.Controls.Add(this.numPalletsQnt);
            this.pnlData.Controls.Add(this.lblNetto);
            this.pnlData.Controls.Add(this.numNetto);
            this.pnlData.Controls.Add(this.cboPartner);
            this.pnlData.Controls.Add(this.lblPartner);
            this.pnlData.Controls.Add(this.lblDeliveryAddress);
            this.pnlData.Controls.Add(this.txtDeliveryAddress);
            this.pnlData.Controls.Add(this.lblDateTask);
            this.pnlData.Controls.Add(this.chkIsCash);
            this.pnlData.Controls.Add(this.lblCoordinates);
            this.pnlData.Controls.Add(this.txtLongitude);
            this.pnlData.Controls.Add(this.lblDistance);
            this.pnlData.Location = new System.Drawing.Point(5, 6);
            this.pnlData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(662, 473);
            this.pnlData.TabIndex = 0;
            // 
            // txtLatitude
            // 
            this.txtLatitude.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtLatitude.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLatitude.Enabled = false;
            this.txtLatitude.Location = new System.Drawing.Point(366, 135);
            this.txtLatitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLatitude.MaxLength = 50;
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(159, 26);
            this.txtLatitude.TabIndex = 47;
            this.ttToolTip.SetToolTip(this.txtLatitude, "Широта");
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPrice.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrice.Location = new System.Drawing.Point(374, 361);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 18);
            this.lblPrice.TabIndex = 46;
            this.lblPrice.Text = "Цена за ед., руб.";
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numPrice.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numPrice.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numPrice.InputMask = "#########";
            this.numPrice.IsNull = false;
            this.numPrice.Location = new System.Drawing.Point(514, 360);
            this.numPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.RealPlaces = 9;
            this.numPrice.Size = new System.Drawing.Size(137, 26);
            this.numPrice.TabIndex = 14;
            this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPrice.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.numPrice.Validated += new System.EventHandler(this.RecalcTaskAmount);
            // 
            // lblUnitsQnt
            // 
            this.lblUnitsQnt.AutoSize = true;
            this.lblUnitsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblUnitsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUnitsQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnitsQnt.Location = new System.Drawing.Point(374, 330);
            this.lblUnitsQnt.Name = "lblUnitsQnt";
            this.lblUnitsQnt.Size = new System.Drawing.Size(114, 18);
            this.lblUnitsQnt.TabIndex = 44;
            this.lblUnitsQnt.Text = "Количество ед.";
            // 
            // numUnitsQnt
            // 
            this.numUnitsQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numUnitsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numUnitsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numUnitsQnt.InputMask = "#########";
            this.numUnitsQnt.IsNull = false;
            this.numUnitsQnt.Location = new System.Drawing.Point(514, 328);
            this.numUnitsQnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numUnitsQnt.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUnitsQnt.Name = "numUnitsQnt";
            this.numUnitsQnt.RealPlaces = 9;
            this.numUnitsQnt.Size = new System.Drawing.Size(137, 26);
            this.numUnitsQnt.TabIndex = 13;
            this.numUnitsQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUnitsQnt.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            this.numUnitsQnt.Validated += new System.EventHandler(this.RecalcTaskAmount);
            // 
            // lblTaskAmount
            // 
            this.lblTaskAmount.AutoSize = true;
            this.lblTaskAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTaskAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTaskAmount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskAmount.Location = new System.Drawing.Point(374, 395);
            this.lblTaskAmount.Name = "lblTaskAmount";
            this.lblTaskAmount.Size = new System.Drawing.Size(136, 18);
            this.lblTaskAmount.TabIndex = 42;
            this.lblTaskAmount.Text = "Сумма счета, руб.";
            // 
            // numTaskAmount
            // 
            this.numTaskAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.numTaskAmount.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numTaskAmount.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numTaskAmount.Enabled = false;
            this.numTaskAmount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTaskAmount.InputMask = "#########";
            this.numTaskAmount.IsNull = false;
            this.numTaskAmount.Location = new System.Drawing.Point(514, 392);
            this.numTaskAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTaskAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTaskAmount.Name = "numTaskAmount";
            this.numTaskAmount.ReadOnly = true;
            this.numTaskAmount.RealPlaces = 9;
            this.numTaskAmount.Size = new System.Drawing.Size(137, 26);
            this.numTaskAmount.TabIndex = 15;
            this.numTaskAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTaskOuterCost
            // 
            this.lblTaskOuterCost.AutoSize = true;
            this.lblTaskOuterCost.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTaskOuterCost.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTaskOuterCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskOuterCost.Location = new System.Drawing.Point(6, 330);
            this.lblTaskOuterCost.Name = "lblTaskOuterCost";
            this.lblTaskOuterCost.Size = new System.Drawing.Size(180, 18);
            this.lblTaskOuterCost.TabIndex = 40;
            this.lblTaskOuterCost.Text = "Доставка тр. комп., руб.";
            // 
            // numTaskOuterCost
            // 
            this.numTaskOuterCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numTaskOuterCost.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numTaskOuterCost.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numTaskOuterCost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTaskOuterCost.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTaskOuterCost.InputMask = "#########";
            this.numTaskOuterCost.IsNull = false;
            this.numTaskOuterCost.Location = new System.Drawing.Point(183, 328);
            this.numTaskOuterCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTaskOuterCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTaskOuterCost.Name = "numTaskOuterCost";
            this.numTaskOuterCost.RealPlaces = 9;
            this.numTaskOuterCost.Size = new System.Drawing.Size(137, 26);
            this.numTaskOuterCost.TabIndex = 10;
            this.numTaskOuterCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTaskOuterCost.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // btnLocate
            // 
            this.btnLocate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLocate.Image = global::Logistics.Properties.Resources.Locate;
            this.btnLocate.Location = new System.Drawing.Point(610, 109);
            this.btnLocate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(37, 39);
            this.btnLocate.TabIndex = 0;
            this.btnLocate.TabStop = false;
            this.ttToolTip.SetToolTip(this.btnLocate, "Сохранить");
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblBrutto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBrutto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBrutto.Location = new System.Drawing.Point(374, 212);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(80, 18);
            this.lblBrutto.TabIndex = 37;
            this.lblBrutto.Text = "Брутто, кг";
            // 
            // numBrutto
            // 
            this.numBrutto.DecimalPlaces = 1;
            this.numBrutto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numBrutto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numBrutto.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numBrutto.InputMask = "########0.0";
            this.numBrutto.IsNull = false;
            this.numBrutto.Location = new System.Drawing.Point(377, 235);
            this.numBrutto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numBrutto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numBrutto.Name = "numBrutto";
            this.numBrutto.RealPlaces = 9;
            this.numBrutto.Size = new System.Drawing.Size(103, 26);
            this.numBrutto.TabIndex = 7;
            this.numBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numBrutto.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // dtpDateTask
            // 
            this.dtpDateTask.CustomFormat = "dd.MM.yyyy";
            this.dtpDateTask.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDateTask.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDateTask.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTask.Location = new System.Drawing.Point(183, 6);
            this.dtpDateTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDateTask.Name = "dtpDateTask";
            this.dtpDateTask.OldValue = new System.DateTime(2009, 3, 12, 12, 55, 54, 296);
            this.dtpDateTask.Size = new System.Drawing.Size(105, 26);
            this.dtpDateTask.TabIndex = 1;
            // 
            // lblTaskInnerCost
            // 
            this.lblTaskInnerCost.AutoSize = true;
            this.lblTaskInnerCost.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTaskInnerCost.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTaskInnerCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskInnerCost.Location = new System.Drawing.Point(6, 298);
            this.lblTaskInnerCost.Name = "lblTaskInnerCost";
            this.lblTaskInnerCost.Size = new System.Drawing.Size(152, 18);
            this.lblTaskInnerCost.TabIndex = 18;
            this.lblTaskInnerCost.Text = "Наша доставка, руб.";
            // 
            // numTaskInnerCost
            // 
            this.numTaskInnerCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numTaskInnerCost.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numTaskInnerCost.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numTaskInnerCost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numTaskInnerCost.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTaskInnerCost.InputMask = "#########";
            this.numTaskInnerCost.IsNull = false;
            this.numTaskInnerCost.Location = new System.Drawing.Point(183, 296);
            this.numTaskInnerCost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numTaskInnerCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numTaskInnerCost.Name = "numTaskInnerCost";
            this.numTaskInnerCost.RealPlaces = 9;
            this.numTaskInnerCost.Size = new System.Drawing.Size(137, 26);
            this.numTaskInnerCost.TabIndex = 9;
            this.numTaskInnerCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTaskInnerCost.Enter += new System.EventHandler(this.NumericUpDown_Enter);
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
            this.cboZone.Location = new System.Drawing.Point(183, 103);
            this.cboZone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboZone.Name = "cboZone";
            this.cboZone.Size = new System.Drawing.Size(342, 26);
            this.cboZone.TabIndex = 4;
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblZone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblZone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZone.Location = new System.Drawing.Point(6, 107);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(107, 18);
            this.lblZone.TabIndex = 11;
            this.lblZone.Text = "Зона доставки";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNote.Location = new System.Drawing.Point(6, 441);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(92, 18);
            this.lblNote.TabIndex = 33;
            this.lblNote.Text = "Примечание";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(184, 437);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(469, 26);
            this.txtNote.TabIndex = 16;
            // 
            // cboUnit
            // 
            this.cboUnit.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboUnit.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboUnit.Location = new System.Drawing.Point(514, 296);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(137, 26);
            this.cboUnit.TabIndex = 12;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblUnit.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnit.Location = new System.Drawing.Point(374, 298);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(143, 18);
            this.lblUnit.TabIndex = 28;
            this.lblUnit.Text = "Единица измерения";
            // 
            // numDistance
            // 
            this.numDistance.DecimalPlaces = 1;
            this.numDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numDistance.InputMask = "#####0.0";
            this.numDistance.IsNull = false;
            this.numDistance.Location = new System.Drawing.Point(183, 167);
            this.numDistance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDistance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.RealPlaces = 6;
            this.numDistance.Size = new System.Drawing.Size(103, 26);
            this.numDistance.TabIndex = 5;
            this.numDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPalletsQnt
            // 
            this.lblPalletsQnt.AutoSize = true;
            this.lblPalletsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPalletsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPalletsQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPalletsQnt.Location = new System.Drawing.Point(545, 212);
            this.lblPalletsQnt.Name = "lblPalletsQnt";
            this.lblPalletsQnt.Size = new System.Drawing.Size(58, 18);
            this.lblPalletsQnt.TabIndex = 20;
            this.lblPalletsQnt.Text = "Паллет";
            // 
            // numPalletsQnt
            // 
            this.numPalletsQnt.DecimalPlaces = 1;
            this.numPalletsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numPalletsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numPalletsQnt.InputMask = "#####0.0";
            this.numPalletsQnt.IsNull = false;
            this.numPalletsQnt.Location = new System.Drawing.Point(549, 235);
            this.numPalletsQnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numPalletsQnt.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPalletsQnt.Name = "numPalletsQnt";
            this.numPalletsQnt.RealPlaces = 6;
            this.numPalletsQnt.Size = new System.Drawing.Size(103, 26);
            this.numPalletsQnt.TabIndex = 8;
            this.numPalletsQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numPalletsQnt.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNetto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNetto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNetto.Location = new System.Drawing.Point(181, 212);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(73, 18);
            this.lblNetto.TabIndex = 16;
            this.lblNetto.Text = "Нетто, кг";
            // 
            // numNetto
            // 
            this.numNetto.DecimalPlaces = 1;
            this.numNetto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numNetto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numNetto.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numNetto.InputMask = "########0.0";
            this.numNetto.IsNull = false;
            this.numNetto.Location = new System.Drawing.Point(183, 235);
            this.numNetto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numNetto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numNetto.Name = "numNetto";
            this.numNetto.RealPlaces = 9;
            this.numNetto.Size = new System.Drawing.Size(103, 26);
            this.numNetto.TabIndex = 6;
            this.numNetto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNetto.Enter += new System.EventHandler(this.NumericUpDown_Enter);
            // 
            // cboPartner
            // 
            this.cboPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPartner.FormattingEnabled = true;
            this.cboPartner.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboPartner.Location = new System.Drawing.Point(183, 39);
            this.cboPartner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPartner.Name = "cboPartner";
            this.cboPartner.Size = new System.Drawing.Size(468, 26);
            this.cboPartner.TabIndex = 2;
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartner.Location = new System.Drawing.Point(6, 44);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(74, 18);
            this.lblPartner.TabIndex = 6;
            this.lblPartner.Text = "Владелец";
            // 
            // lblDeliveryAddress
            // 
            this.lblDeliveryAddress.AutoSize = true;
            this.lblDeliveryAddress.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDeliveryAddress.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDeliveryAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeliveryAddress.Location = new System.Drawing.Point(6, 76);
            this.lblDeliveryAddress.Name = "lblDeliveryAddress";
            this.lblDeliveryAddress.Size = new System.Drawing.Size(115, 18);
            this.lblDeliveryAddress.TabIndex = 4;
            this.lblDeliveryAddress.Text = "Адрес доставки";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDeliveryAddress.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeliveryAddress.Location = new System.Drawing.Point(183, 71);
            this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeliveryAddress.MaxLength = 250;
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(468, 26);
            this.txtDeliveryAddress.TabIndex = 3;
            // 
            // lblDateTask
            // 
            this.lblDateTask.AutoSize = true;
            this.lblDateTask.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateTask.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateTask.Location = new System.Drawing.Point(6, 9);
            this.lblDateTask.Name = "lblDateTask";
            this.lblDateTask.Size = new System.Drawing.Size(42, 18);
            this.lblDateTask.TabIndex = 0;
            this.lblDateTask.Text = "Дата";
            // 
            // chkIsCash
            // 
            this.chkIsCash.AutoSize = true;
            this.chkIsCash.Location = new System.Drawing.Point(183, 364);
            this.chkIsCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIsCash.Name = "chkIsCash";
            this.chkIsCash.Size = new System.Drawing.Size(59, 22);
            this.chkIsCash.TabIndex = 11;
            this.chkIsCash.Text = "нал.";
            this.chkIsCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ttToolTip.SetToolTip(this.chkIsCash, "Признак оплаты наличными");
            this.chkIsCash.UseVisualStyleBackColor = true;
            // 
            // lblCoordinates
            // 
            this.lblCoordinates.AutoSize = true;
            this.lblCoordinates.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCoordinates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCoordinates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCoordinates.Location = new System.Drawing.Point(6, 139);
            this.lblCoordinates.Name = "lblCoordinates";
            this.lblCoordinates.Size = new System.Drawing.Size(91, 18);
            this.lblCoordinates.TabIndex = 2;
            this.lblCoordinates.Text = "Координаты";
            // 
            // txtLongitude
            // 
            this.txtLongitude.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtLongitude.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLongitude.Enabled = false;
            this.txtLongitude.Location = new System.Drawing.Point(183, 135);
            this.txtLongitude.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLongitude.MaxLength = 50;
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(159, 26);
            this.txtLongitude.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.txtLongitude, "Долгота");
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistance.Location = new System.Drawing.Point(6, 170);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(113, 18);
            this.lblDistance.TabIndex = 22;
            this.lblDistance.Text = "Расстояние, км";
            // 
            // frmCarsTasksEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 535);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimizeBox = false;
            this.Name = "frmCarsTasksEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание";
            this.Load += new System.EventHandler(this.frmCarsTasksEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUnitsQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskOuterCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaskInnerCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPalletsQnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNetto)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblCoordinates;
		private RFMBaseClasses.RFMTextBox txtLongitude;
		private RFMBaseClasses.RFMCheckBox chkIsCash;
        private RFMBaseClasses.RFMLabel lblDateTask;
		private RFMBaseClasses.RFMLabel lblDeliveryAddress;
		private RFMBaseClasses.RFMTextBox txtDeliveryAddress;
		private RFMBaseClasses.RFMComboBox cboPartner;
        private RFMBaseClasses.RFMLabel lblPartner;
		private RFMBaseClasses.RFMLabel lblNetto;
		private RFMBaseClasses.RFMNumericUpDown numNetto;
		private RFMBaseClasses.RFMLabel lblPalletsQnt;
		private RFMBaseClasses.RFMNumericUpDown numPalletsQnt;
		private RFMBaseClasses.RFMLabel lblDistance;
		private RFMBaseClasses.RFMNumericUpDown numDistance;
		private RFMBaseClasses.RFMLabel lblUnit;
		private RFMBaseClasses.RFMComboBox cboUnit;
		private RFMBaseClasses.RFMLabel lblNote;
        private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMComboBox cboZone;
        private RFMBaseClasses.RFMLabel lblZone;
		private RFMBaseClasses.RFMLabel lblTaskInnerCost;
        private RFMBaseClasses.RFMNumericUpDown numTaskInnerCost;
        private RFMBaseClasses.RFMDateTimePicker dtpDateTask;
        private RFMBaseClasses.RFMLabel lblBrutto;
        private RFMBaseClasses.RFMNumericUpDown numBrutto;
        private RFMBaseClasses.RFMButton btnLocate;
        private RFMBaseClasses.RFMLabel lblTaskAmount;
        private RFMBaseClasses.RFMNumericUpDown numTaskAmount;
        private RFMBaseClasses.RFMLabel lblTaskOuterCost;
        private RFMBaseClasses.RFMNumericUpDown numTaskOuterCost;
        private RFMBaseClasses.RFMLabel lblPrice;
        private RFMBaseClasses.RFMNumericUpDown numPrice;
        private RFMBaseClasses.RFMLabel lblUnitsQnt;
        private RFMBaseClasses.RFMNumericUpDown numUnitsQnt;
        private RFMBaseClasses.RFMTextBox txtLatitude;

	}
}

