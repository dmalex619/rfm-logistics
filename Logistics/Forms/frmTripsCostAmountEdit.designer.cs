namespace Logistics
{
	partial class frmTripsCostAmountEdit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvJobs = new RFMBaseClasses.RFMDataGridView();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.dgvcTypeImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.dgvcPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcZoneName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcDeliveryAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcPalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcNote = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTaskInnerCost = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcTaskOuterCost = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcCarTskUnitID = new RFMBaseClasses.RFMDataGridViewComboBoxColumn();
            this.dgvcUnitsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcPrice = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcTaskAmount = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvJobs
            // 
            this.dgvJobs.AllowUserToAddRows = false;
            this.dgvJobs.AllowUserToDeleteRows = false;
            this.dgvJobs.AllowUserToOrderColumns = true;
            this.dgvJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJobs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvJobs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcTypeImage,
            this.dgvcPartnerName,
            this.dgvcZoneName,
            this.dgvcDeliveryAddress,
            this.dgvcBrutto,
            this.dgvcPalletsQnt,
            this.dgvcNote,
            this.dgvcTaskInnerCost,
            this.dgvcTaskOuterCost,
            this.dgvcCarTskUnitID,
            this.dgvcUnitsQnt,
            this.dgvcPrice,
            this.dgvcTaskAmount});
            this.dgvJobs.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvJobs.IsConfigInclude = true;
            this.dgvJobs.IsMarkedAll = false;
            this.dgvJobs.IsStatusInclude = true;
            this.dgvJobs.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvJobs.Location = new System.Drawing.Point(4, 6);
            this.dgvJobs.MultiSelect = false;
            this.dgvJobs.Name = "dgvJobs";
            this.dgvJobs.RangedWay = ' ';
            this.dgvJobs.RowHeadersWidth = 24;
            this.dgvJobs.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.dgvJobs.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.dgvJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvJobs.Size = new System.Drawing.Size(775, 414);
            this.dgvJobs.TabIndex = 0;
            this.dgvJobs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJobs_CellEndEdit);
            this.dgvJobs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTrips_CellFormatting);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 427);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(747, 427);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(697, 427);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvcTypeImage
            // 
            this.dgvcTypeImage.HeaderText = "Тип";
            this.dgvcTypeImage.Name = "dgvcTypeImage";
            this.dgvcTypeImage.ReadOnly = true;
            this.dgvcTypeImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcTypeImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcTypeImage.ToolTipText = "Тип задания";
            this.dgvcTypeImage.Width = 40;
            // 
            // dgvcPartnerName
            // 
            this.dgvcPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPartnerName.DataPropertyName = "PartnerName";
            this.dgvcPartnerName.HeaderText = "Партнер";
            this.dgvcPartnerName.Name = "dgvcPartnerName";
            this.dgvcPartnerName.ReadOnly = true;
            this.dgvcPartnerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcZoneName
            // 
            this.dgvcZoneName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcZoneName.DataPropertyName = "ZoneName";
            this.dgvcZoneName.HeaderText = "Зона";
            this.dgvcZoneName.Name = "dgvcZoneName";
            this.dgvcZoneName.ReadOnly = true;
            this.dgvcZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcZoneName.Width = 50;
            // 
            // dgvcDeliveryAddress
            // 
            this.dgvcDeliveryAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDeliveryAddress.DataPropertyName = "DeliveryAddress";
            this.dgvcDeliveryAddress.HeaderText = "Адрес";
            this.dgvcDeliveryAddress.Name = "dgvcDeliveryAddress";
            this.dgvcDeliveryAddress.ReadOnly = true;
            this.dgvcDeliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcBrutto
            // 
            this.dgvcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcBrutto.DataPropertyName = "Brutto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.dgvcBrutto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcBrutto.HeaderText = "Брутто";
            this.dgvcBrutto.Name = "dgvcBrutto";
            this.dgvcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcBrutto.Width = 60;
            // 
            // dgvcPalletsQnt
            // 
            this.dgvcPalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPalletsQnt.DataPropertyName = "PalletsQnt";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N1";
            this.dgvcPalletsQnt.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcPalletsQnt.HeaderText = "Пал.";
            this.dgvcPalletsQnt.Name = "dgvcPalletsQnt";
            this.dgvcPalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPalletsQnt.Width = 50;
            // 
            // dgvcNote
            // 
            this.dgvcNote.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcNote.DataPropertyName = "Note";
            this.dgvcNote.HeaderText = "Примечание";
            this.dgvcNote.Name = "dgvcNote";
            this.dgvcNote.ReadOnly = true;
            this.dgvcNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcTaskInnerCost
            // 
            this.dgvcTaskInnerCost.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTaskInnerCost.DataPropertyName = "TaskInnerCost";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvcTaskInnerCost.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcTaskInnerCost.HeaderText = "Ст-сть наша";
            this.dgvcTaskInnerCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgvcTaskInnerCost.Name = "dgvcTaskInnerCost";
            this.dgvcTaskInnerCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcTaskInnerCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTaskInnerCost.ToolTipText = "Стоимость доставки нашим транспортом, руб.";
            this.dgvcTaskInnerCost.Width = 80;
            // 
            // dgvcTaskOuterCost
            // 
            this.dgvcTaskOuterCost.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTaskOuterCost.DataPropertyName = "TaskOuterCost";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.dgvcTaskOuterCost.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcTaskOuterCost.HeaderText = "Ст-сть перев.";
            this.dgvcTaskOuterCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgvcTaskOuterCost.Name = "dgvcTaskOuterCost";
            this.dgvcTaskOuterCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcTaskOuterCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTaskOuterCost.ToolTipText = "Стоимость доставки транспортом перевозчика, руб.";
            this.dgvcTaskOuterCost.Width = 80;
            // 
            // dgvcCarTskUnitID
            // 
            this.dgvcCarTskUnitID.HeaderText = "Е.и.";
            this.dgvcCarTskUnitID.Name = "dgvcCarTskUnitID";
            this.dgvcCarTskUnitID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcCarTskUnitID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcCarTskUnitID.ToolTipText = "Единица измерения работ/услуг";
            // 
            // dgvcUnitsQnt
            // 
            this.dgvcUnitsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcUnitsQnt.DataPropertyName = "UnitsQnt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            this.dgvcUnitsQnt.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcUnitsQnt.HeaderText = "Кол-во е.и.";
            this.dgvcUnitsQnt.Name = "dgvcUnitsQnt";
            this.dgvcUnitsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcUnitsQnt.ToolTipText = "Количество единиц работ/услуг";
            this.dgvcUnitsQnt.Width = 60;
            // 
            // dgvcPrice
            // 
            this.dgvcPrice.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPrice.DataPropertyName = "Price";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            this.dgvcPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcPrice.HeaderText = "Цена";
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPrice.Width = 60;
            // 
            // dgvcTaskAmount
            // 
            this.dgvcTaskAmount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTaskAmount.DataPropertyName = "TaskAmount";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.dgvcTaskAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvcTaskAmount.HeaderText = "Сумма";
            this.dgvcTaskAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgvcTaskAmount.Name = "dgvcTaskAmount";
            this.dgvcTaskAmount.ReadOnly = true;
            this.dgvcTaskAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // frmTripsCostAmountEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvJobs);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "221");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmTripsCostAmountEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоимость заданий в рейсе";
            this.Load += new System.EventHandler(this.frmTripsCostAmountEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobs)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvJobs;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
        private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMDataGridViewImageColumn dgvcTypeImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcZoneName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDeliveryAddress;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcBrutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcPalletsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcNote;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcTaskInnerCost;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcTaskOuterCost;
        private RFMBaseClasses.RFMDataGridViewComboBoxColumn dgvcCarTskUnitID;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcUnitsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcPrice;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcTaskAmount;
	}
}

