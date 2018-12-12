namespace Logistics
{
	partial class frmTripsPrintDocuments
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
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.chkUsePerversionCopiesCnt = new RFMBaseClasses.RFMCheckBox();
            this.chkInputWarrant = new RFMBaseClasses.RFMCheckBox();
            this.lblInputs = new RFMBaseClasses.RFMLabel();
            this.chkInputBillReturn = new RFMBaseClasses.RFMCheckBox();
            this.lblOutputs = new RFMBaseClasses.RFMLabel();
            this.pnlH3 = new RFMBaseClasses.RFMPanel();
            this.chkPayBill = new RFMBaseClasses.RFMCheckBox();
            this.chkWarrant = new RFMBaseClasses.RFMCheckBox();
            this.lblTripAlias = new RFMBaseClasses.RFMLabel();
            this.chkRepeat = new RFMBaseClasses.RFMCheckBox();
            this.pnlH1 = new RFMBaseClasses.RFMPanel();
            this.chkTripBillShort = new RFMBaseClasses.RFMCheckBox();
            this.chkTripBill = new RFMBaseClasses.RFMCheckBox();
            this.lblTotalSort = new RFMBaseClasses.RFMLabel();
            this.pnlTotalSort = new RFMBaseClasses.RFMPanel();
            this.optTotalSortByOrders = new RFMBaseClasses.RFMRadioButton();
            this.optTotalSortByTypes = new RFMBaseClasses.RFMRadioButton();
            this.chkDirectToPrinter = new RFMBaseClasses.RFMCheckBox();
            this.numBillCopies = new RFMBaseClasses.RFMNumericUpDown();
            this.chkQuality = new RFMBaseClasses.RFMCheckBox();
            this.chkVeterinary = new RFMBaseClasses.RFMCheckBox();
            this.chkFacture = new RFMBaseClasses.RFMCheckBox();
            this.chkBill = new RFMBaseClasses.RFMCheckBox();
            this.pnlH2 = new RFMBaseClasses.RFMPanel();
            this.lblDelimiter = new RFMBaseClasses.RFMLabel();
            this.nudHours = new RFMBaseClasses.RFMNumericUpDown();
            this.nudMinutes = new RFMBaseClasses.RFMNumericUpDown();
            this.btnClearAll = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.chkDrivingScheme = new RFMBaseClasses.RFMCheckBox();
            this.pnlData.SuspendLayout();
            this.pnlTotalSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBillCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.chkDrivingScheme);
            this.pnlData.Controls.Add(this.chkUsePerversionCopiesCnt);
            this.pnlData.Controls.Add(this.chkInputWarrant);
            this.pnlData.Controls.Add(this.lblInputs);
            this.pnlData.Controls.Add(this.chkInputBillReturn);
            this.pnlData.Controls.Add(this.lblOutputs);
            this.pnlData.Controls.Add(this.pnlH3);
            this.pnlData.Controls.Add(this.chkPayBill);
            this.pnlData.Controls.Add(this.chkWarrant);
            this.pnlData.Controls.Add(this.lblTripAlias);
            this.pnlData.Controls.Add(this.chkRepeat);
            this.pnlData.Controls.Add(this.pnlH1);
            this.pnlData.Controls.Add(this.chkTripBillShort);
            this.pnlData.Controls.Add(this.chkTripBill);
            this.pnlData.Controls.Add(this.lblTotalSort);
            this.pnlData.Controls.Add(this.pnlTotalSort);
            this.pnlData.Controls.Add(this.chkDirectToPrinter);
            this.pnlData.Controls.Add(this.numBillCopies);
            this.pnlData.Controls.Add(this.chkQuality);
            this.pnlData.Controls.Add(this.chkVeterinary);
            this.pnlData.Controls.Add(this.chkFacture);
            this.pnlData.Controls.Add(this.chkBill);
            this.pnlData.Controls.Add(this.pnlH2);
            this.pnlData.Location = new System.Drawing.Point(3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(436, 343);
            this.pnlData.TabIndex = 0;
            // 
            // chkUsePerversionCopiesCnt
            // 
            this.chkUsePerversionCopiesCnt.AutoSize = true;
            this.chkUsePerversionCopiesCnt.Checked = true;
            this.chkUsePerversionCopiesCnt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUsePerversionCopiesCnt.Location = new System.Drawing.Point(8, 288);
            this.chkUsePerversionCopiesCnt.Name = "chkUsePerversionCopiesCnt";
            this.chkUsePerversionCopiesCnt.Size = new System.Drawing.Size(363, 18);
            this.chkUsePerversionCopiesCnt.TabIndex = 19;
            this.chkUsePerversionCopiesCnt.Text = "количество копий - по специальным настройкам клиентов";
            this.chkUsePerversionCopiesCnt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkUsePerversionCopiesCnt.UseVisualStyleBackColor = true;
            // 
            // chkInputWarrant
            // 
            this.chkInputWarrant.AutoSize = true;
            this.chkInputWarrant.Location = new System.Drawing.Point(190, 205);
            this.chkInputWarrant.Name = "chkInputWarrant";
            this.chkInputWarrant.Size = new System.Drawing.Size(208, 18);
            this.chkInputWarrant.TabIndex = 15;
            this.chkInputWarrant.Text = "Доверенность на получ. товара";
            this.chkInputWarrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkInputWarrant.UseVisualStyleBackColor = true;
            // 
            // lblInputs
            // 
            this.lblInputs.AutoSize = true;
            this.lblInputs.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblInputs.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInputs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInputs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInputs.Location = new System.Drawing.Point(7, 184);
            this.lblInputs.Name = "lblInputs";
            this.lblInputs.Size = new System.Drawing.Size(69, 14);
            this.lblInputs.TabIndex = 13;
            this.lblInputs.Text = "Приходы:";
            // 
            // chkInputBillReturn
            // 
            this.chkInputBillReturn.AutoSize = true;
            this.chkInputBillReturn.Location = new System.Drawing.Point(9, 204);
            this.chkInputBillReturn.Name = "chkInputBillReturn";
            this.chkInputBillReturn.Size = new System.Drawing.Size(153, 18);
            this.chkInputBillReturn.TabIndex = 14;
            this.chkInputBillReturn.Text = "Возвратная накладная";
            this.chkInputBillReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkInputBillReturn.UseVisualStyleBackColor = true;
            // 
            // lblOutputs
            // 
            this.lblOutputs.AutoSize = true;
            this.lblOutputs.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutputs.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutputs.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutputs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutputs.Location = new System.Drawing.Point(6, 81);
            this.lblOutputs.Name = "lblOutputs";
            this.lblOutputs.Size = new System.Drawing.Size(66, 14);
            this.lblOutputs.TabIndex = 4;
            this.lblOutputs.Text = "Расходы:";
            // 
            // pnlH3
            // 
            this.pnlH3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlH3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlH3.Location = new System.Drawing.Point(8, 228);
            this.pnlH3.Name = "pnlH3";
            this.pnlH3.Size = new System.Drawing.Size(416, 4);
            this.pnlH3.TabIndex = 16;
            // 
            // chkPayBill
            // 
            this.chkPayBill.AutoSize = true;
            this.chkPayBill.Location = new System.Drawing.Point(9, 152);
            this.chkPayBill.Name = "chkPayBill";
            this.chkPayBill.Size = new System.Drawing.Size(53, 18);
            this.chkPayBill.TabIndex = 8;
            this.chkPayBill.Text = "Счет";
            this.chkPayBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkPayBill.UseVisualStyleBackColor = true;
            // 
            // chkWarrant
            // 
            this.chkWarrant.AutoSize = true;
            this.chkWarrant.Location = new System.Drawing.Point(190, 152);
            this.chkWarrant.Name = "chkWarrant";
            this.chkWarrant.Size = new System.Drawing.Size(203, 18);
            this.chkWarrant.TabIndex = 11;
            this.chkWarrant.Text = "Доверенность на получ. денег";
            this.chkWarrant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkWarrant.UseVisualStyleBackColor = true;
            // 
            // lblTripAlias
            // 
            this.lblTripAlias.AutoSize = true;
            this.lblTripAlias.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTripAlias.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTripAlias.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTripAlias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTripAlias.Location = new System.Drawing.Point(7, 6);
            this.lblTripAlias.Name = "lblTripAlias";
            this.lblTripAlias.Size = new System.Drawing.Size(39, 14);
            this.lblTripAlias.TabIndex = 0;
            this.lblTripAlias.Text = "Рейс:";
            // 
            // chkRepeat
            // 
            this.chkRepeat.AutoSize = true;
            this.chkRepeat.Checked = true;
            this.chkRepeat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRepeat.Enabled = false;
            this.chkRepeat.Location = new System.Drawing.Point(9, 263);
            this.chkRepeat.Name = "chkRepeat";
            this.chkRepeat.Size = new System.Drawing.Size(136, 18);
            this.chkRepeat.TabIndex = 18;
            this.chkRepeat.Text = "Печатать повторно";
            this.chkRepeat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkRepeat.UseVisualStyleBackColor = true;
            // 
            // pnlH1
            // 
            this.pnlH1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlH1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlH1.Location = new System.Drawing.Point(8, 74);
            this.pnlH1.Name = "pnlH1";
            this.pnlH1.Size = new System.Drawing.Size(416, 4);
            this.pnlH1.TabIndex = 22;
            // 
            // chkTripBillShort
            // 
            this.chkTripBillShort.AutoSize = true;
            this.chkTripBillShort.Location = new System.Drawing.Point(9, 50);
            this.chkTripBillShort.Name = "chkTripBillShort";
            this.chkTripBillShort.Size = new System.Drawing.Size(169, 18);
            this.chkTripBillShort.TabIndex = 2;
            this.chkTripBillShort.Text = "Машрутный лист краткий";
            this.chkTripBillShort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkTripBillShort.UseVisualStyleBackColor = true;
            // 
            // chkTripBill
            // 
            this.chkTripBill.AutoSize = true;
            this.chkTripBill.Location = new System.Drawing.Point(9, 26);
            this.chkTripBill.Name = "chkTripBill";
            this.chkTripBill.Size = new System.Drawing.Size(120, 18);
            this.chkTripBill.TabIndex = 1;
            this.chkTripBill.Text = "Машрутный лист";
            this.chkTripBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkTripBill.UseVisualStyleBackColor = true;
            // 
            // lblTotalSort
            // 
            this.lblTotalSort.AutoSize = true;
            this.lblTotalSort.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTotalSort.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTotalSort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalSort.Location = new System.Drawing.Point(7, 315);
            this.lblTotalSort.Name = "lblTotalSort";
            this.lblTotalSort.Size = new System.Drawing.Size(149, 14);
            this.lblTotalSort.TabIndex = 20;
            this.lblTotalSort.Text = "Сортировать документы:";
            // 
            // pnlTotalSort
            // 
            this.pnlTotalSort.Controls.Add(this.optTotalSortByOrders);
            this.pnlTotalSort.Controls.Add(this.optTotalSortByTypes);
            this.pnlTotalSort.Location = new System.Drawing.Point(160, 309);
            this.pnlTotalSort.Name = "pnlTotalSort";
            this.pnlTotalSort.Size = new System.Drawing.Size(180, 25);
            this.pnlTotalSort.TabIndex = 21;
            // 
            // optTotalSortByOrders
            // 
            this.optTotalSortByOrders.AutoSize = true;
            this.optTotalSortByOrders.Checked = true;
            this.optTotalSortByOrders.IsChanged = true;
            this.optTotalSortByOrders.Location = new System.Drawing.Point(4, 4);
            this.optTotalSortByOrders.Name = "optTotalSortByOrders";
            this.optTotalSortByOrders.Size = new System.Drawing.Size(85, 18);
            this.optTotalSortByOrders.TabIndex = 0;
            this.optTotalSortByOrders.TabStop = true;
            this.optTotalSortByOrders.Text = "по заказам";
            this.optTotalSortByOrders.UseVisualStyleBackColor = true;
            // 
            // optTotalSortByTypes
            // 
            this.optTotalSortByTypes.AutoSize = true;
            this.optTotalSortByTypes.IsChanged = true;
            this.optTotalSortByTypes.Location = new System.Drawing.Point(98, 4);
            this.optTotalSortByTypes.Name = "optTotalSortByTypes";
            this.optTotalSortByTypes.Size = new System.Drawing.Size(77, 18);
            this.optTotalSortByTypes.TabIndex = 1;
            this.optTotalSortByTypes.Text = "по типам";
            this.optTotalSortByTypes.UseVisualStyleBackColor = true;
            // 
            // chkDirectToPrinter
            // 
            this.chkDirectToPrinter.AutoSize = true;
            this.chkDirectToPrinter.Location = new System.Drawing.Point(9, 238);
            this.chkDirectToPrinter.Name = "chkDirectToPrinter";
            this.chkDirectToPrinter.Size = new System.Drawing.Size(126, 18);
            this.chkDirectToPrinter.TabIndex = 17;
            this.chkDirectToPrinter.Text = "Сразу на принтер";
            this.chkDirectToPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDirectToPrinter.UseVisualStyleBackColor = true;
            // 
            // numBillCopies
            // 
            this.numBillCopies.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numBillCopies.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numBillCopies.InputMask = "#########";
            this.numBillCopies.IsNull = false;
            this.numBillCopies.Location = new System.Drawing.Point(97, 100);
            this.numBillCopies.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numBillCopies.Name = "numBillCopies";
            this.numBillCopies.RealPlaces = 9;
            this.numBillCopies.Size = new System.Drawing.Size(54, 22);
            this.numBillCopies.TabIndex = 6;
            this.numBillCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chkQuality
            // 
            this.chkQuality.AutoSize = true;
            this.chkQuality.Location = new System.Drawing.Point(190, 127);
            this.chkQuality.Name = "chkQuality";
            this.chkQuality.Size = new System.Drawing.Size(218, 18);
            this.chkQuality.TabIndex = 10;
            this.chkQuality.Text = "Список деклараций соответствия";
            this.chkQuality.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkQuality.UseVisualStyleBackColor = true;
            // 
            // chkVeterinary
            // 
            this.chkVeterinary.AutoSize = true;
            this.chkVeterinary.Enabled = false;
            this.chkVeterinary.Location = new System.Drawing.Point(190, 102);
            this.chkVeterinary.Name = "chkVeterinary";
            this.chkVeterinary.Size = new System.Drawing.Size(232, 18);
            this.chkVeterinary.TabIndex = 9;
            this.chkVeterinary.Text = "Список ветеринарных свидетельств";
            this.chkVeterinary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkVeterinary.UseVisualStyleBackColor = true;
            // 
            // chkFacture
            // 
            this.chkFacture.AutoSize = true;
            this.chkFacture.Location = new System.Drawing.Point(9, 127);
            this.chkFacture.Name = "chkFacture";
            this.chkFacture.Size = new System.Drawing.Size(104, 18);
            this.chkFacture.TabIndex = 7;
            this.chkFacture.Text = "Счет-фактура";
            this.chkFacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkFacture.UseVisualStyleBackColor = true;
            // 
            // chkBill
            // 
            this.chkBill.AutoSize = true;
            this.chkBill.Location = new System.Drawing.Point(9, 102);
            this.chkBill.Name = "chkBill";
            this.chkBill.Size = new System.Drawing.Size(86, 18);
            this.chkBill.TabIndex = 5;
            this.chkBill.Text = "Накладная";
            this.chkBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkBill.UseVisualStyleBackColor = true;
            this.chkBill.CheckedChanged += new System.EventHandler(this.chkBill_CheckedChanged);
            // 
            // pnlH2
            // 
            this.pnlH2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlH2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlH2.Location = new System.Drawing.Point(8, 176);
            this.pnlH2.Name = "pnlH2";
            this.pnlH2.Size = new System.Drawing.Size(416, 4);
            this.pnlH2.TabIndex = 12;
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
            this.nudHours.InputMask = "###";
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
            this.nudHours.RealPlaces = 3;
            this.nudHours.Size = new System.Drawing.Size(38, 22);
            this.nudHours.TabIndex = 0;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudMinutes
            // 
            this.nudMinutes.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.nudMinutes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.nudMinutes.InputMask = "###";
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
            this.nudMinutes.RealPlaces = 3;
            this.nudMinutes.Size = new System.Drawing.Size(38, 22);
            this.nudMinutes.TabIndex = 2;
            this.nudMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearAll.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClearAll.Location = new System.Drawing.Point(305, 353);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(32, 30);
            this.btnClearAll.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnClearAll, "Очистить");
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 353);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(405, 353);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(355, 353);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // chkDrivingScheme
            // 
            this.chkDrivingScheme.AutoSize = true;
            this.chkDrivingScheme.Location = new System.Drawing.Point(190, 26);
            this.chkDrivingScheme.Name = "chkDrivingScheme";
            this.chkDrivingScheme.Size = new System.Drawing.Size(112, 18);
            this.chkDrivingScheme.TabIndex = 23;
            this.chkDrivingScheme.Text = "Схемы проезда";
            this.chkDrivingScheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDrivingScheme.UseVisualStyleBackColor = true;
            // 
            // frmTripsPrintDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 387);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlData);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsAccessOn = true;
            this.IsModalMode = true;
            this.Name = "frmTripsPrintDocuments";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать документов";
            this.Load += new System.EventHandler(this.frmTripsPrintDocuments_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlTotalSort.ResumeLayout(false);
            this.pnlTotalSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBillCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMButton btnClearAll;
		private RFMBaseClasses.RFMLabel lblDelimiter;
		private RFMBaseClasses.RFMNumericUpDown nudHours;
		private RFMBaseClasses.RFMNumericUpDown nudMinutes;
		private RFMBaseClasses.RFMCheckBox chkFacture;
		private RFMBaseClasses.RFMCheckBox chkBill;
		private RFMBaseClasses.RFMCheckBox chkQuality;
		private RFMBaseClasses.RFMCheckBox chkVeterinary;
		private RFMBaseClasses.RFMCheckBox chkDirectToPrinter;
		private RFMBaseClasses.RFMNumericUpDown numBillCopies;
		private RFMBaseClasses.RFMLabel lblTotalSort;
		private RFMBaseClasses.RFMPanel pnlTotalSort;
		private RFMBaseClasses.RFMRadioButton optTotalSortByTypes;
		private RFMBaseClasses.RFMPanel pnlH2;
		private RFMBaseClasses.RFMCheckBox chkTripBill;
		private RFMBaseClasses.RFMCheckBox chkTripBillShort;
		private RFMBaseClasses.RFMPanel pnlH1;
		private RFMBaseClasses.RFMCheckBox chkRepeat;
		private RFMBaseClasses.RFMLabel lblTripAlias;
		private RFMBaseClasses.RFMCheckBox chkWarrant;
		private RFMBaseClasses.RFMRadioButton optTotalSortByOrders;
		private RFMBaseClasses.RFMCheckBox chkPayBill;
		private RFMBaseClasses.RFMLabel lblInputs;
		private RFMBaseClasses.RFMCheckBox chkInputBillReturn;
		private RFMBaseClasses.RFMLabel lblOutputs;
		private RFMBaseClasses.RFMPanel pnlH3;
		private RFMBaseClasses.RFMCheckBox chkInputWarrant;
		private RFMBaseClasses.RFMCheckBox chkUsePerversionCopiesCnt;
        private RFMBaseClasses.RFMCheckBox chkDrivingScheme;

	}
}

