namespace Logistics
{
	partial class frmTripsOthersByDate
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
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlData = new RFMBaseClasses.RFMPanel();
			this.numCnt = new RFMBaseClasses.RFMNumericUpDown();
			this.lblCnt = new RFMBaseClasses.RFMLabel();
			this.pnlOtherSelfDelivery = new RFMBaseClasses.RFMPanel();
			this.optSelfDelivery = new RFMBaseClasses.RFMRadioButton();
			this.optIsRentCar = new RFMBaseClasses.RFMRadioButton();
			this.grdTrips = new RFMBaseClasses.RFMDataGridView();
			this.btnCreateTrips = new RFMBaseClasses.RFMButton();
			this.lblDate = new RFMBaseClasses.RFMLabel();
			this.dtpDate = new RFMBaseClasses.RFMDateTimePicker();
			this.btnPrint = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblTotalPalletsQnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalPalletsQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalVolume = new RFMBaseClasses.RFMLabel();
			this.lblTotalVolume_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalTonnage = new RFMBaseClasses.RFMLabel();
			this.lblTotalTonnage_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalCnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalCnt_ = new RFMBaseClasses.RFMLabel();
			this.grcAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTonnage = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcIsPassengerCar = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcIsPostern = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcIsLoadLift = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcVolume = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPermitLevelName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.pnlData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCnt)).BeginInit();
			this.pnlOtherSelfDelivery.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).BeginInit();
			this.pnlTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(7, 387);
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
			this.btnExit.Location = new System.Drawing.Point(703, 387);
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
			this.btnSave.Location = new System.Drawing.Point(653, 387);
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
			this.pnlData.Controls.Add(this.numCnt);
			this.pnlData.Controls.Add(this.lblCnt);
			this.pnlData.Controls.Add(this.pnlOtherSelfDelivery);
			this.pnlData.Controls.Add(this.grdTrips);
			this.pnlData.Controls.Add(this.btnCreateTrips);
			this.pnlData.Controls.Add(this.lblDate);
			this.pnlData.Controls.Add(this.dtpDate);
			this.pnlData.Location = new System.Drawing.Point(5, 5);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(732, 374);
			this.pnlData.TabIndex = 0;
			// 
			// numCnt
			// 
			this.numCnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numCnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numCnt.IsNull = false;
			this.numCnt.Location = new System.Drawing.Point(230, 7);
			this.numCnt.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numCnt.Name = "numCnt";
			this.numCnt.Size = new System.Drawing.Size(51, 22);
			this.numCnt.TabIndex = 35;
			this.numCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblCnt
			// 
			this.lblCnt.AutoSize = true;
			this.lblCnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCnt.Location = new System.Drawing.Point(177, 11);
			this.lblCnt.Name = "lblCnt";
			this.lblCnt.Size = new System.Drawing.Size(47, 14);
			this.lblCnt.TabIndex = 34;
			this.lblCnt.Text = "Рейсов";
			// 
			// pnlOtherSelfDelivery
			// 
			this.pnlOtherSelfDelivery.Controls.Add(this.optSelfDelivery);
			this.pnlOtherSelfDelivery.Controls.Add(this.optIsRentCar);
			this.pnlOtherSelfDelivery.Location = new System.Drawing.Point(319, 6);
			this.pnlOtherSelfDelivery.Name = "pnlOtherSelfDelivery";
			this.pnlOtherSelfDelivery.Size = new System.Drawing.Size(314, 25);
			this.pnlOtherSelfDelivery.TabIndex = 33;
			// 
			// optSelfDelivery
			// 
			this.optSelfDelivery.AutoSize = true;
			this.optSelfDelivery.Location = new System.Drawing.Point(179, 3);
			this.optSelfDelivery.Name = "optSelfDelivery";
			this.optSelfDelivery.Size = new System.Drawing.Size(126, 18);
			this.optSelfDelivery.TabIndex = 2;
			this.optSelfDelivery.Text = "машины клиентов";
			this.optSelfDelivery.UseVisualStyleBackColor = true;
			// 
			// optIsRentCar
			// 
			this.optIsRentCar.AutoSize = true;
			this.optIsRentCar.Checked = true;
			this.optIsRentCar.IsChanged = true;
			this.optIsRentCar.Location = new System.Drawing.Point(6, 3);
			this.optIsRentCar.Name = "optIsRentCar";
			this.optIsRentCar.Size = new System.Drawing.Size(155, 18);
			this.optIsRentCar.TabIndex = 1;
			this.optIsRentCar.TabStop = true;
			this.optIsRentCar.Text = "арендованные машины";
			this.optIsRentCar.UseVisualStyleBackColor = true;
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
			this.grdTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcAlias,
            this.grcCarNumber,
            this.grcDriverName,
            this.grcTonnage,
            this.grcIsPassengerCar,
            this.grcIsPostern,
            this.grcIsLoadLift,
            this.grcVolume,
            this.grcPalletsQnt,
            this.grcPermitLevelName,
            this.grcCarName,
            this.grcCarTypeName});
			this.grdTrips.IsCheckerInclude = true;
			this.grdTrips.IsConfigInclude = true;
			this.grdTrips.IsMarkedAll = false;
			this.grdTrips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdTrips.Location = new System.Drawing.Point(3, 36);
			this.grdTrips.MultiSelect = false;
			this.grdTrips.Name = "grdTrips";
			this.grdTrips.RangedWay = ' ';
			this.grdTrips.RowHeadersWidth = 24;
			this.grdTrips.Size = new System.Drawing.Size(723, 332);
			this.grdTrips.TabIndex = 10;
			this.grdTrips.MarkedOneEvent += new RFMBaseClasses.RFMDataGridView.MarkedOneEventHandler(this.grdTrips_MarkedOneEvent);
			this.grdTrips.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTrips_CellValidated);
			this.grdTrips.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grdTrips_CellPainting);
			this.grdTrips.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdTrips_CellFormatting);
			this.grdTrips.MarkedAllEvent += new RFMBaseClasses.RFMDataGridView.MarkedAllEventHandler(this.grdTrips_MarkedAllEvent);
			// 
			// btnCreateTrips
			// 
			this.btnCreateTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateTrips.Image = global::Logistics.Properties.Resources.Go;
			this.btnCreateTrips.Location = new System.Drawing.Point(697, 3);
			this.btnCreateTrips.Name = "btnCreateTrips";
			this.btnCreateTrips.Size = new System.Drawing.Size(28, 28);
			this.btnCreateTrips.TabIndex = 9;
			this.ttToolTip.SetToolTip(this.btnCreateTrips, "Получить список рейсов");
			this.btnCreateTrips.UseVisualStyleBackColor = true;
			this.btnCreateTrips.Click += new System.EventHandler(this.btnCreateTrips_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDate.Location = new System.Drawing.Point(5, 11);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(33, 14);
			this.lblDate.TabIndex = 6;
			this.lblDate.Text = "Дата";
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "dd.MM.yyyy";
			this.dtpDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(42, 7);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(96, 22);
			this.dtpDate.TabIndex = 5;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(603, 387);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(32, 30);
			this.btnPrint.TabIndex = 9;
			this.ttToolTip.SetToolTip(this.btnPrint, "Печатать");
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// pnlTotal
			// 
			this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotal.Controls.Add(this.lblTotalPalletsQnt);
			this.pnlTotal.Controls.Add(this.lblTotalPalletsQnt_);
			this.pnlTotal.Controls.Add(this.lblTotalVolume);
			this.pnlTotal.Controls.Add(this.lblTotalVolume_);
			this.pnlTotal.Controls.Add(this.lblTotalTonnage);
			this.pnlTotal.Controls.Add(this.lblTotalTonnage_);
			this.pnlTotal.Controls.Add(this.lblTotalCnt);
			this.pnlTotal.Controls.Add(this.lblTotalCnt_);
			this.pnlTotal.Location = new System.Drawing.Point(49, 387);
			this.pnlTotal.Name = "pnlTotal";
			this.pnlTotal.Size = new System.Drawing.Size(540, 30);
			this.pnlTotal.TabIndex = 10;
			// 
			// lblTotalPalletsQnt
			// 
			this.lblTotalPalletsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalPalletsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalPalletsQnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalPalletsQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalPalletsQnt.Location = new System.Drawing.Point(456, 7);
			this.lblTotalPalletsQnt.Name = "lblTotalPalletsQnt";
			this.lblTotalPalletsQnt.Size = new System.Drawing.Size(79, 14);
			this.lblTotalPalletsQnt.TabIndex = 9;
			this.lblTotalPalletsQnt.Text = "#TotalPalletsQnt#";
			// 
			// lblTotalPalletsQnt_
			// 
			this.lblTotalPalletsQnt_.AutoSize = true;
			this.lblTotalPalletsQnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalPalletsQnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalPalletsQnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalPalletsQnt_.Location = new System.Drawing.Point(408, 7);
			this.lblTotalPalletsQnt_.Name = "lblTotalPalletsQnt_";
			this.lblTotalPalletsQnt_.Size = new System.Drawing.Size(48, 14);
			this.lblTotalPalletsQnt_.TabIndex = 8;
			this.lblTotalPalletsQnt_.Text = "Паллет";
			// 
			// lblTotalVolume
			// 
			this.lblTotalVolume.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalVolume.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalVolume.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalVolume.Location = new System.Drawing.Point(309, 7);
			this.lblTotalVolume.Name = "lblTotalVolume";
			this.lblTotalVolume.Size = new System.Drawing.Size(98, 14);
			this.lblTotalVolume.TabIndex = 5;
			this.lblTotalVolume.Text = "#TotalVolume#";
			// 
			// lblTotalVolume_
			// 
			this.lblTotalVolume_.AutoSize = true;
			this.lblTotalVolume_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalVolume_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalVolume_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalVolume_.Location = new System.Drawing.Point(264, 7);
			this.lblTotalVolume_.Name = "lblTotalVolume_";
			this.lblTotalVolume_.Size = new System.Drawing.Size(45, 14);
			this.lblTotalVolume_.TabIndex = 4;
			this.lblTotalVolume_.Text = "Объем";
			// 
			// lblTotalTonnage
			// 
			this.lblTotalTonnage.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalTonnage.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalTonnage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalTonnage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalTonnage.Location = new System.Drawing.Point(162, 7);
			this.lblTotalTonnage.Name = "lblTotalTonnage";
			this.lblTotalTonnage.Size = new System.Drawing.Size(101, 14);
			this.lblTotalTonnage.TabIndex = 3;
			this.lblTotalTonnage.Text = "#TotalTonnage#";
			// 
			// lblTotalTonnage_
			// 
			this.lblTotalTonnage_.AutoSize = true;
			this.lblTotalTonnage_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalTonnage_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalTonnage_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalTonnage_.Location = new System.Drawing.Point(111, 7);
			this.lblTotalTonnage_.Name = "lblTotalTonnage_";
			this.lblTotalTonnage_.Size = new System.Drawing.Size(52, 14);
			this.lblTotalTonnage_.TabIndex = 2;
			this.lblTotalTonnage_.Text = "Тоннаж";
			// 
			// lblTotalCnt
			// 
			this.lblTotalCnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalCnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalCnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalCnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalCnt.Location = new System.Drawing.Point(50, 7);
			this.lblTotalCnt.Name = "lblTotalCnt";
			this.lblTotalCnt.Size = new System.Drawing.Size(61, 14);
			this.lblTotalCnt.TabIndex = 1;
			this.lblTotalCnt.Text = "#TotalCnt#";
			// 
			// lblTotalCnt_
			// 
			this.lblTotalCnt_.AutoSize = true;
			this.lblTotalCnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalCnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalCnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalCnt_.Location = new System.Drawing.Point(4, 7);
			this.lblTotalCnt_.Name = "lblTotalCnt_";
			this.lblTotalCnt_.Size = new System.Drawing.Size(47, 14);
			this.lblTotalCnt_.TabIndex = 0;
			this.lblTotalCnt_.Text = "Рейсов";
			// 
			// grcAlias
			// 
			this.grcAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcAlias.DataPropertyName = "Alias";
			this.grcAlias.HeaderText = "Описание рейса";
			this.grcAlias.Name = "grcAlias";
			this.grcAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcAlias.Width = 300;
			// 
			// grcCarNumber
			// 
			this.grcCarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarNumber.DataPropertyName = "CarNumber";
			this.grcCarNumber.HeaderText = "Гос.номер";
			this.grcCarNumber.Name = "grcCarNumber";
			this.grcCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcDriverName
			// 
			this.grcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverName.DataPropertyName = "DriverName";
			this.grcDriverName.HeaderText = "Водитель";
			this.grcDriverName.Name = "grcDriverName";
			this.grcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcTonnage
			// 
			this.grcTonnage.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTonnage.DataPropertyName = "Tonnage";
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "N0";
			this.grcTonnage.DefaultCellStyle = dataGridViewCellStyle1;
			this.grcTonnage.HeaderText = "Тоннаж";
			this.grcTonnage.Name = "grcTonnage";
			this.grcTonnage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTonnage.ToolTipText = "Грузоподъемность, кг";
			this.grcTonnage.Width = 70;
			// 
			// grcIsPassengerCar
			// 
			this.grcIsPassengerCar.DataPropertyName = "IsPassengerCar";
			this.grcIsPassengerCar.HeaderText = "Легк.";
			this.grcIsPassengerCar.Name = "grcIsPassengerCar";
			this.grcIsPassengerCar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcIsPassengerCar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsPassengerCar.Width = 40;
			// 
			// grcIsPostern
			// 
			this.grcIsPostern.DataPropertyName = "IsPostern";
			this.grcIsPostern.HeaderText = "Зад.";
			this.grcIsPostern.Name = "grcIsPostern";
			this.grcIsPostern.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcIsPostern.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsPostern.Width = 40;
			// 
			// grcIsLoadLift
			// 
			this.grcIsLoadLift.DataPropertyName = "IsLoadLift";
			this.grcIsLoadLift.HeaderText = "Под.";
			this.grcIsLoadLift.Name = "grcIsLoadLift";
			this.grcIsLoadLift.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcIsLoadLift.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsLoadLift.Width = 40;
			// 
			// grcVolume
			// 
			this.grcVolume.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcVolume.DataPropertyName = "Volume";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N1";
			this.grcVolume.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcVolume.HeaderText = "Объем";
			this.grcVolume.Name = "grcVolume";
			this.grcVolume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcVolume.ToolTipText = "Объем, м3";
			this.grcVolume.Width = 60;
			// 
			// grcPalletsQnt
			// 
			this.grcPalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPalletsQnt.DataPropertyName = "MaxPalletsQnt";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N1";
			this.grcPalletsQnt.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcPalletsQnt.HeaderText = "Пал.";
			this.grcPalletsQnt.Name = "grcPalletsQnt";
			this.grcPalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPalletsQnt.Width = 60;
			// 
			// grcPermitLevelName
			// 
			this.grcPermitLevelName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPermitLevelName.DataPropertyName = "PermitLevelName";
			this.grcPermitLevelName.HeaderText = "Разрешение";
			this.grcPermitLevelName.Name = "grcPermitLevelName";
			this.grcPermitLevelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcCarName
			// 
			this.grcCarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarName.DataPropertyName = "CarName";
			this.grcCarName.HeaderText = "Название машины";
			this.grcCarName.Name = "grcCarName";
			this.grcCarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcCarName.Width = 120;
			// 
			// grcCarTypeName
			// 
			this.grcCarTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarTypeName.DataPropertyName = "CarTypeName";
			this.grcCarTypeName.HeaderText = "Тип машины";
			this.grcCarTypeName.Name = "grcCarTypeName";
			this.grcCarTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// frmTripsOthersByDate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 423);
			this.Controls.Add(this.pnlTotal);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.hpHelp.SetHelpKeyword(this, "");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmTripsOthersByDate";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание рейсов [другие машины] на дату";
			this.Load += new System.EventHandler(this.frmTripsOthersByDate_Load);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCnt)).EndInit();
			this.pnlOtherSelfDelivery.ResumeLayout(false);
			this.pnlOtherSelfDelivery.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).EndInit();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMDateTimePicker dtpDate;
		private RFMBaseClasses.RFMButton btnCreateTrips;
		private RFMBaseClasses.RFMDataGridView grdTrips;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblTotalTonnage;
		private RFMBaseClasses.RFMLabel lblTotalTonnage_;
		private RFMBaseClasses.RFMLabel lblTotalCnt;
		private RFMBaseClasses.RFMLabel lblTotalCnt_;
		private RFMBaseClasses.RFMLabel lblTotalVolume;
		private RFMBaseClasses.RFMLabel lblTotalVolume_;
		private RFMBaseClasses.RFMLabel lblTotalPalletsQnt;
		private RFMBaseClasses.RFMLabel lblTotalPalletsQnt_;
		private RFMBaseClasses.RFMPanel pnlOtherSelfDelivery;
		private RFMBaseClasses.RFMRadioButton optSelfDelivery;
		private RFMBaseClasses.RFMRadioButton optIsRentCar;
		private RFMBaseClasses.RFMNumericUpDown numCnt;
		private RFMBaseClasses.RFMLabel lblCnt;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTonnage;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsPassengerCar;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsPostern;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsLoadLift;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcVolume;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPalletsQnt;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPermitLevelName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarTypeName;

	}
}

