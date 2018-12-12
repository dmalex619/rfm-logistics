namespace Logistics
{
	partial class frmGatesHistoryEdit
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
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlData = new RFMBaseClasses.RFMPanel();
			this.lblReason = new RFMBaseClasses.RFMLabel();
			this.txtReason = new RFMBaseClasses.RFMTextBox();
			this.tcCars = new RFMBaseClasses.RFMTabControl();
			this.tabCars = new RFMBaseClasses.RFMTabPage();
			this.pnlCars = new RFMBaseClasses.RFMPanel();
			this.grdData = new RFMBaseClasses.RFMDataGridView();
			this.grcCarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverDocument = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverPhone = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateArrivalFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateDepartureFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcIsOtherCar = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcNote = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcUserCreateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.tabFact = new RFMBaseClasses.RFMTabPage();
			this.pnlOther = new RFMBaseClasses.RFMPanel();
			this.lblCarTypeName = new RFMBaseClasses.RFMLabel();
			this.txtCarTypeName = new RFMBaseClasses.RFMTextBox();
			this.lblDriverName = new RFMBaseClasses.RFMLabel();
			this.txtDriverName = new RFMBaseClasses.RFMTextBox();
			this.txtCarNаme = new RFMBaseClasses.RFMTextBox();
			this.lblTrailerNumber = new RFMBaseClasses.RFMLabel();
			this.txtCarNumber = new RFMBaseClasses.RFMTextBox();
			this.txtTrailerNumber = new RFMBaseClasses.RFMTextBox();
			this.lblCarNumber = new RFMBaseClasses.RFMLabel();
			this.lblCarName = new RFMBaseClasses.RFMLabel();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.lblCarWeight = new RFMBaseClasses.RFMLabel();
			this.numCarWeight = new RFMBaseClasses.RFMNumericUpDown();
			this.pnlIsDeparture = new RFMBaseClasses.RFMPanel();
			this.txtCarNameContext = new RFMBaseClasses.RFMTextBox();
			this.chkFact = new RFMBaseClasses.RFMCheckBox();
			this.dtpDateCross = new RFMBaseClasses.RFMDateTimePicker();
			this.optArrival = new RFMBaseClasses.RFMRadioButton();
			this.optDeparture = new RFMBaseClasses.RFMRadioButton();
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.chkArrivalDeparture = new RFMBaseClasses.RFMCheckBox();
			this.chkRepeat = new RFMBaseClasses.RFMCheckBox();
			this.pnlData.SuspendLayout();
			this.tcCars.SuspendLayout();
			this.tabCars.SuspendLayout();
			this.pnlCars.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			this.tabFact.SuspendLayout();
			this.pnlOther.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCarWeight)).BeginInit();
			this.pnlIsDeparture.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(7, 437);
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
			this.btnExit.Location = new System.Drawing.Point(653, 437);
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
			this.btnSave.Location = new System.Drawing.Point(603, 437);
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
			this.pnlData.Controls.Add(this.lblReason);
			this.pnlData.Controls.Add(this.txtReason);
			this.pnlData.Controls.Add(this.tcCars);
			this.pnlData.Controls.Add(this.lblNote);
			this.pnlData.Controls.Add(this.lblCarWeight);
			this.pnlData.Controls.Add(this.numCarWeight);
			this.pnlData.Controls.Add(this.pnlIsDeparture);
			this.pnlData.Controls.Add(this.txtNote);
			this.pnlData.Location = new System.Drawing.Point(5, 5);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(682, 424);
			this.pnlData.TabIndex = 0;
			// 
			// lblReason
			// 
			this.lblReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblReason.AutoSize = true;
			this.lblReason.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReason.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReason.Location = new System.Drawing.Point(3, 348);
			this.lblReason.Name = "lblReason";
			this.lblReason.Size = new System.Drawing.Size(74, 14);
			this.lblReason.TabIndex = 11;
			this.lblReason.Text = "Назначение";
			// 
			// txtReason
			// 
			this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtReason.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtReason.Location = new System.Drawing.Point(98, 345);
			this.txtReason.Name = "txtReason";
			this.txtReason.Size = new System.Drawing.Size(577, 22);
			this.txtReason.TabIndex = 12;
			this.ttToolTip.SetToolTip(this.txtReason, "Назначение въезда/выезда");
			// 
			// tcCars
			// 
			this.tcCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcCars.Controls.Add(this.tabCars);
			this.tcCars.Controls.Add(this.tabFact);
			this.tcCars.Location = new System.Drawing.Point(2, 38);
			this.tcCars.Name = "tcCars";
			this.tcCars.SelectedIndex = 0;
			this.tcCars.Size = new System.Drawing.Size(675, 303);
			this.tcCars.TabIndex = 10;
			// 
			// tabCars
			// 
			this.tabCars.Controls.Add(this.pnlCars);
			this.tabCars.Location = new System.Drawing.Point(4, 23);
			this.tabCars.Name = "tabCars";
			this.tabCars.Padding = new System.Windows.Forms.Padding(3);
			this.tabCars.Size = new System.Drawing.Size(667, 276);
			this.tabCars.TabIndex = 0;
			this.tabCars.Text = "Машины";
			this.tabCars.UseVisualStyleBackColor = true;
			// 
			// pnlCars
			// 
			this.pnlCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlCars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlCars.Controls.Add(this.grdData);
			this.pnlCars.Location = new System.Drawing.Point(1, 1);
			this.pnlCars.Name = "pnlCars";
			this.pnlCars.Size = new System.Drawing.Size(665, 274);
			this.pnlCars.TabIndex = 6;
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
            this.grcCarName,
            this.grcCarNumber,
            this.grcCarTypeName,
            this.grcDriverName,
            this.grcDriverDocument,
            this.grcDriverPhone,
            this.grcDateArrivalFact,
            this.grcDateDepartureFact,
            this.grcIsOtherCar,
            this.grcBrutto,
            this.grcPalletsQnt,
            this.grcPartnerName,
            this.grcNote,
            this.grcUserCreateName});
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
			this.grdData.Location = new System.Drawing.Point(0, 0);
			this.grdData.MultiSelect = false;
			this.grdData.Name = "grdData";
			this.grdData.RangedWay = ' ';
			this.grdData.ReadOnly = true;
			this.grdData.RowHeadersWidth = 24;
			this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdData.Size = new System.Drawing.Size(661, 270);
			this.grdData.TabIndex = 13;
			this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
			// 
			// grcCarName
			// 
			this.grcCarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarName.DataPropertyName = "CarName";
			this.grcCarName.HeaderText = "Машина";
			this.grcCarName.Name = "grcCarName";
			this.grcCarName.ReadOnly = true;
			this.grcCarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcCarName.Width = 150;
			// 
			// grcCarNumber
			// 
			this.grcCarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarNumber.DataPropertyName = "CarNumber";
			this.grcCarNumber.HeaderText = "Номер";
			this.grcCarNumber.Name = "grcCarNumber";
			this.grcCarNumber.ReadOnly = true;
			this.grcCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcCarTypeName
			// 
			this.grcCarTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarTypeName.DataPropertyName = "CarTypeName";
			this.grcCarTypeName.HeaderText = "Тип машины";
			this.grcCarTypeName.Name = "grcCarTypeName";
			this.grcCarTypeName.ReadOnly = true;
			this.grcCarTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcDriverName
			// 
			this.grcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverName.DataPropertyName = "DriverName";
			this.grcDriverName.HeaderText = "Водитель";
			this.grcDriverName.Name = "grcDriverName";
			this.grcDriverName.ReadOnly = true;
			this.grcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcDriverDocument
			// 
			this.grcDriverDocument.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverDocument.DataPropertyName = "DriverDocument";
			this.grcDriverDocument.HeaderText = "Док. водителя";
			this.grcDriverDocument.Name = "grcDriverDocument";
			this.grcDriverDocument.ReadOnly = true;
			this.grcDriverDocument.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDriverDocument.ToolTipText = "Документ водителя";
			// 
			// grcDriverPhone
			// 
			this.grcDriverPhone.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverPhone.DataPropertyName = "DriverPhone";
			this.grcDriverPhone.HeaderText = "Тел. водителя";
			this.grcDriverPhone.Name = "grcDriverPhone";
			this.grcDriverPhone.ReadOnly = true;
			this.grcDriverPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDriverPhone.ToolTipText = "Телефон водителя";
			// 
			// grcDateArrivalFact
			// 
			this.grcDateArrivalFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateArrivalFact.DataPropertyName = "DateArrivalFact";
			this.grcDateArrivalFact.HeaderText = "Въезд";
			this.grcDateArrivalFact.Name = "grcDateArrivalFact";
			this.grcDateArrivalFact.ReadOnly = true;
			this.grcDateArrivalFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateArrivalFact.ToolTipText = "Дата-время въезда машины";
			this.grcDateArrivalFact.Width = 50;
			// 
			// grcDateDepartureFact
			// 
			this.grcDateDepartureFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateDepartureFact.DataPropertyName = "DateDepartureFact";
			this.grcDateDepartureFact.HeaderText = "Выезд";
			this.grcDateDepartureFact.Name = "grcDateDepartureFact";
			this.grcDateDepartureFact.ReadOnly = true;
			this.grcDateDepartureFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateDepartureFact.ToolTipText = "Дата-время выезда машины";
			this.grcDateDepartureFact.Width = 50;
			// 
			// grcIsOtherCar
			// 
			this.grcIsOtherCar.DataPropertyName = "IsOtherCar";
			this.grcIsOtherCar.HeaderText = "Проч.";
			this.grcIsOtherCar.Name = "grcIsOtherCar";
			this.grcIsOtherCar.ReadOnly = true;
			this.grcIsOtherCar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsOtherCar.ToolTipText = "Прочая машина (не разовый)?";
			this.grcIsOtherCar.Width = 47;
			// 
			// grcBrutto
			// 
			this.grcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcBrutto.DataPropertyName = "Brutto";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			this.grcBrutto.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcBrutto.HeaderText = "Брутто";
			this.grcBrutto.Name = "grcBrutto";
			this.grcBrutto.ReadOnly = true;
			this.grcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcBrutto.ToolTipText = "Вес брутто товара, кг";
			this.grcBrutto.Width = 70;
			// 
			// grcPalletsQnt
			// 
			this.grcPalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPalletsQnt.DataPropertyName = "PalletsQnt";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N1";
			this.grcPalletsQnt.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcPalletsQnt.HeaderText = "Паллет";
			this.grcPalletsQnt.Name = "grcPalletsQnt";
			this.grcPalletsQnt.ReadOnly = true;
			this.grcPalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPalletsQnt.ToolTipText = "Количество паллет";
			this.grcPalletsQnt.Width = 50;
			// 
			// grcPartnerName
			// 
			this.grcPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPartnerName.DataPropertyName = "PartnerName";
			this.grcPartnerName.HeaderText = "Клиент";
			this.grcPartnerName.Name = "grcPartnerName";
			this.grcPartnerName.ReadOnly = true;
			this.grcPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPartnerName.Width = 150;
			// 
			// grcNote
			// 
			this.grcNote.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcNote.DataPropertyName = "Note";
			this.grcNote.HeaderText = "Примечание";
			this.grcNote.Name = "grcNote";
			this.grcNote.ReadOnly = true;
			this.grcNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcNote.Width = 150;
			// 
			// grcUserCreateName
			// 
			this.grcUserCreateName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcUserCreateName.DataPropertyName = "UserCreateName";
			this.grcUserCreateName.HeaderText = "Оформил";
			this.grcUserCreateName.Name = "grcUserCreateName";
			this.grcUserCreateName.ReadOnly = true;
			this.grcUserCreateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcUserCreateName.ToolTipText = "Кто оформил пропуск";
			// 
			// tabFact
			// 
			this.tabFact.Controls.Add(this.pnlOther);
			this.tabFact.Location = new System.Drawing.Point(4, 23);
			this.tabFact.Name = "tabFact";
			this.tabFact.Padding = new System.Windows.Forms.Padding(3);
			this.tabFact.Size = new System.Drawing.Size(667, 276);
			this.tabFact.TabIndex = 1;
			this.tabFact.Text = "По факту";
			this.tabFact.UseVisualStyleBackColor = true;
			// 
			// pnlOther
			// 
			this.pnlOther.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlOther.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlOther.Controls.Add(this.lblCarTypeName);
			this.pnlOther.Controls.Add(this.txtCarTypeName);
			this.pnlOther.Controls.Add(this.lblDriverName);
			this.pnlOther.Controls.Add(this.txtDriverName);
			this.pnlOther.Controls.Add(this.txtCarNаme);
			this.pnlOther.Controls.Add(this.lblTrailerNumber);
			this.pnlOther.Controls.Add(this.txtCarNumber);
			this.pnlOther.Controls.Add(this.txtTrailerNumber);
			this.pnlOther.Controls.Add(this.lblCarNumber);
			this.pnlOther.Controls.Add(this.lblCarName);
			this.pnlOther.Location = new System.Drawing.Point(1, 1);
			this.pnlOther.Name = "pnlOther";
			this.pnlOther.Size = new System.Drawing.Size(665, 86);
			this.pnlOther.TabIndex = 5;
			// 
			// lblCarTypeName
			// 
			this.lblCarTypeName.AutoSize = true;
			this.lblCarTypeName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarTypeName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarTypeName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarTypeName.Location = new System.Drawing.Point(374, 7);
			this.lblCarTypeName.Name = "lblCarTypeName";
			this.lblCarTypeName.Size = new System.Drawing.Size(75, 14);
			this.lblCarTypeName.TabIndex = 2;
			this.lblCarTypeName.Text = "тип машины";
			// 
			// txtCarTypeName
			// 
			this.txtCarTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCarTypeName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarTypeName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarTypeName.Location = new System.Drawing.Point(457, 4);
			this.txtCarTypeName.MaxLength = 50;
			this.txtCarTypeName.Name = "txtCarTypeName";
			this.txtCarTypeName.Size = new System.Drawing.Size(200, 22);
			this.txtCarTypeName.TabIndex = 3;
			// 
			// lblDriverName
			// 
			this.lblDriverName.AutoSize = true;
			this.lblDriverName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDriverName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDriverName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDriverName.Location = new System.Drawing.Point(3, 59);
			this.lblDriverName.Name = "lblDriverName";
			this.lblDriverName.Size = new System.Drawing.Size(61, 14);
			this.lblDriverName.TabIndex = 8;
			this.lblDriverName.Text = "Водитель";
			// 
			// txtDriverName
			// 
			this.txtDriverName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtDriverName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtDriverName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDriverName.Location = new System.Drawing.Point(121, 56);
			this.txtDriverName.MaxLength = 200;
			this.txtDriverName.Name = "txtDriverName";
			this.txtDriverName.Size = new System.Drawing.Size(536, 22);
			this.txtDriverName.TabIndex = 9;
			// 
			// txtCarNаme
			// 
			this.txtCarNаme.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNаme.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNаme.Location = new System.Drawing.Point(121, 4);
			this.txtCarNаme.MaxLength = 100;
			this.txtCarNаme.Name = "txtCarNаme";
			this.txtCarNаme.Size = new System.Drawing.Size(200, 22);
			this.txtCarNаme.TabIndex = 1;
			// 
			// lblTrailerNumber
			// 
			this.lblTrailerNumber.AutoSize = true;
			this.lblTrailerNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTrailerNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTrailerNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTrailerNumber.Location = new System.Drawing.Point(354, 33);
			this.lblTrailerNumber.Name = "lblTrailerNumber";
			this.lblTrailerNumber.Size = new System.Drawing.Size(95, 14);
			this.lblTrailerNumber.TabIndex = 6;
			this.lblTrailerNumber.Text = "номер прицепа";
			// 
			// txtCarNumber
			// 
			this.txtCarNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNumber.Location = new System.Drawing.Point(121, 30);
			this.txtCarNumber.MaxLength = 50;
			this.txtCarNumber.Name = "txtCarNumber";
			this.txtCarNumber.Size = new System.Drawing.Size(200, 22);
			this.txtCarNumber.TabIndex = 5;
			// 
			// txtTrailerNumber
			// 
			this.txtTrailerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTrailerNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtTrailerNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTrailerNumber.Location = new System.Drawing.Point(457, 30);
			this.txtTrailerNumber.MaxLength = 50;
			this.txtTrailerNumber.Name = "txtTrailerNumber";
			this.txtTrailerNumber.Size = new System.Drawing.Size(200, 22);
			this.txtTrailerNumber.TabIndex = 7;
			// 
			// lblCarNumber
			// 
			this.lblCarNumber.AutoSize = true;
			this.lblCarNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarNumber.Location = new System.Drawing.Point(3, 33);
			this.lblCarNumber.Name = "lblCarNumber";
			this.lblCarNumber.Size = new System.Drawing.Size(114, 14);
			this.lblCarNumber.TabIndex = 4;
			this.lblCarNumber.Text = "Гос.номер машины";
			// 
			// lblCarName
			// 
			this.lblCarName.AutoSize = true;
			this.lblCarName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarName.Location = new System.Drawing.Point(4, 7);
			this.lblCarName.Name = "lblCarName";
			this.lblCarName.Size = new System.Drawing.Size(107, 14);
			this.lblCarName.TabIndex = 0;
			this.lblCarName.Text = "Название машины";
			// 
			// lblNote
			// 
			this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(3, 398);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 8;
			this.lblNote.Text = "Примечание";
			// 
			// lblCarWeight
			// 
			this.lblCarWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblCarWeight.AutoSize = true;
			this.lblCarWeight.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarWeight.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarWeight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarWeight.Location = new System.Drawing.Point(3, 373);
			this.lblCarWeight.Name = "lblCarWeight";
			this.lblCarWeight.Size = new System.Drawing.Size(94, 14);
			this.lblCarWeight.TabIndex = 6;
			this.lblCarWeight.Text = "Вес машины, кг";
			// 
			// numCarWeight
			// 
			this.numCarWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.numCarWeight.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numCarWeight.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numCarWeight.IsNull = false;
			this.numCarWeight.Location = new System.Drawing.Point(98, 370);
			this.numCarWeight.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numCarWeight.Name = "numCarWeight";
			this.numCarWeight.Size = new System.Drawing.Size(79, 22);
			this.numCarWeight.TabIndex = 7;
			this.numCarWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// pnlIsDeparture
			// 
			this.pnlIsDeparture.Controls.Add(this.txtCarNameContext);
			this.pnlIsDeparture.Controls.Add(this.chkFact);
			this.pnlIsDeparture.Controls.Add(this.dtpDateCross);
			this.pnlIsDeparture.Controls.Add(this.optArrival);
			this.pnlIsDeparture.Controls.Add(this.optDeparture);
			this.pnlIsDeparture.Location = new System.Drawing.Point(5, 4);
			this.pnlIsDeparture.Name = "pnlIsDeparture";
			this.pnlIsDeparture.Size = new System.Drawing.Size(670, 31);
			this.pnlIsDeparture.TabIndex = 0;
			// 
			// txtCarNameContext
			// 
			this.txtCarNameContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCarNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNameContext.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCarNameContext.Location = new System.Drawing.Point(435, 2);
			this.txtCarNameContext.Name = "txtCarNameContext";
			this.txtCarNameContext.Size = new System.Drawing.Size(110, 27);
			this.txtCarNameContext.TabIndex = 15;
			this.ttToolTip.SetToolTip(this.txtCarNameContext, "Назначение въезда/выезда");
			this.txtCarNameContext.Validating += new System.ComponentModel.CancelEventHandler(this.txtCarNameContext_Validating);
			// 
			// chkFact
			// 
			this.chkFact.AutoSize = true;
			this.chkFact.IsAccessOn = true;
			this.chkFact.Location = new System.Drawing.Point(590, 6);
			this.chkFact.Name = "chkFact";
			this.chkFact.Size = new System.Drawing.Size(78, 18);
			this.chkFact.TabIndex = 14;
			this.chkFact.Text = "по факту";
			this.chkFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkFact.UseVisualStyleBackColor = true;
			this.chkFact.CheckedChanged += new System.EventHandler(this.chkFact_CheckedChanged);
			// 
			// dtpDateCross
			// 
			this.dtpDateCross.CustomFormat = "dd.MM.yyyy HH:mm";
			this.dtpDateCross.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateCross.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateCross.Enabled = false;
			this.dtpDateCross.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateCross.Location = new System.Drawing.Point(0, 3);
			this.dtpDateCross.Name = "dtpDateCross";
			this.dtpDateCross.Size = new System.Drawing.Size(130, 22);
			this.dtpDateCross.TabIndex = 0;
			this.dtpDateCross.ValueChanged += new System.EventHandler(this.dtpDateCross_ValueChanged);
			// 
			// optArrival
			// 
			this.optArrival.AutoSize = true;
			this.optArrival.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.optArrival.IsChanged = true;
			this.optArrival.Location = new System.Drawing.Point(183, 1);
			this.optArrival.Name = "optArrival";
			this.optArrival.Size = new System.Drawing.Size(86, 27);
			this.optArrival.TabIndex = 1;
			this.optArrival.Text = "въезд";
			this.optArrival.UseVisualStyleBackColor = true;
			this.optArrival.CheckedChanged += new System.EventHandler(this.optArrival_CheckedChanged);
			// 
			// optDeparture
			// 
			this.optDeparture.AutoSize = true;
			this.optDeparture.Checked = true;
			this.optDeparture.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.optDeparture.IsChanged = true;
			this.optDeparture.Location = new System.Drawing.Point(309, 1);
			this.optDeparture.Name = "optDeparture";
			this.optDeparture.Size = new System.Drawing.Size(89, 27);
			this.optDeparture.TabIndex = 2;
			this.optDeparture.TabStop = true;
			this.optDeparture.Text = "выезд";
			this.optDeparture.UseVisualStyleBackColor = true;
			this.optDeparture.CheckedChanged += new System.EventHandler(this.optArrival_CheckedChanged);
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(98, 395);
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(577, 22);
			this.txtNote.TabIndex = 9;
			this.ttToolTip.SetToolTip(this.txtNote, "Примечания");
			// 
			// chkArrivalDeparture
			// 
			this.chkArrivalDeparture.AutoSize = true;
			this.chkArrivalDeparture.Location = new System.Drawing.Point(64, 443);
			this.chkArrivalDeparture.Name = "chkArrivalDeparture";
			this.chkArrivalDeparture.Size = new System.Drawing.Size(146, 18);
			this.chkArrivalDeparture.TabIndex = 16;
			this.chkArrivalDeparture.Text = "показать все машины";
			this.chkArrivalDeparture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkArrivalDeparture.UseVisualStyleBackColor = false;
			this.chkArrivalDeparture.CheckedChanged += new System.EventHandler(this.chkArrivalDeparture_CheckedChanged);
			// 
			// chkRepeat
			// 
			this.chkRepeat.AutoSize = true;
			this.chkRepeat.Location = new System.Drawing.Point(255, 444);
			this.chkRepeat.Name = "chkRepeat";
			this.chkRepeat.Size = new System.Drawing.Size(153, 18);
			this.chkRepeat.TabIndex = 17;
			this.chkRepeat.Text = "в том числе повторно";
			this.chkRepeat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkRepeat.UseVisualStyleBackColor = false;
			this.chkRepeat.CheckedChanged += new System.EventHandler(this.chkRepeat_CheckedChanged);
			// 
			// frmGatesHistoryEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 473);
			this.Controls.Add(this.chkRepeat);
			this.Controls.Add(this.chkArrivalDeparture);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.hpHelp.SetHelpKeyword(this, "");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmGatesHistoryEdit";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пересечение ворот";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGatesHistoryEdit_KeyDown);
			this.Load += new System.EventHandler(this.frmGatesHistoryEdit_Load);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			this.tcCars.ResumeLayout(false);
			this.tabCars.ResumeLayout(false);
			this.pnlCars.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			this.tabFact.ResumeLayout(false);
			this.pnlOther.ResumeLayout(false);
			this.pnlOther.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numCarWeight)).EndInit();
			this.pnlIsDeparture.ResumeLayout(false);
			this.pnlIsDeparture.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMLabel lblTrailerNumber;
		private RFMBaseClasses.RFMTextBox txtTrailerNumber;
		private RFMBaseClasses.RFMTextBox txtCarNаme;
		private RFMBaseClasses.RFMLabel lblCarName;
		private RFMBaseClasses.RFMLabel lblCarNumber;
		private RFMBaseClasses.RFMTextBox txtCarNumber;
		private RFMBaseClasses.RFMPanel pnlIsDeparture;
		private RFMBaseClasses.RFMRadioButton optArrival;
		private RFMBaseClasses.RFMRadioButton optDeparture;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMPanel pnlOther;
		private RFMBaseClasses.RFMDateTimePicker dtpDateCross;
		private RFMBaseClasses.RFMLabel lblCarTypeName;
		private RFMBaseClasses.RFMTextBox txtCarTypeName;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMLabel lblCarWeight;
		private RFMBaseClasses.RFMNumericUpDown numCarWeight;
		private RFMBaseClasses.RFMTabControl tcCars;
		private RFMBaseClasses.RFMTabPage tabCars;
		private RFMBaseClasses.RFMTabPage tabFact;
		private RFMBaseClasses.RFMPanel pnlCars;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMLabel lblReason;
		private RFMBaseClasses.RFMTextBox txtReason;
		private RFMBaseClasses.RFMLabel lblDriverName;
		private RFMBaseClasses.RFMTextBox txtDriverName;
        private RFMBaseClasses.RFMCheckBox chkFact;
		private RFMBaseClasses.RFMCheckBox chkArrivalDeparture;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverDocument;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverPhone;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateArrivalFact;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateDepartureFact;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsOtherCar;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcBrutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPalletsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNote;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcUserCreateName;
		private RFMBaseClasses.RFMCheckBox chkRepeat;
		private RFMBaseClasses.RFMTextBox txtCarNameContext;

	}
}

