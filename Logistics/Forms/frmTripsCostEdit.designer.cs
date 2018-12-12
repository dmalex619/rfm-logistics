namespace Logistics
{
	partial class frmTripsCostEdit
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
            this.dgvTrips = new RFMBaseClasses.RFMDataGridView();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.dgvcIsConfirmedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.dgvcDateTrip = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcPartnerCarrierName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcCost = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
            this.dgvcAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcCarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrips
            // 
            this.dgvTrips.AllowUserToAddRows = false;
            this.dgvTrips.AllowUserToDeleteRows = false;
            this.dgvTrips.AllowUserToOrderColumns = true;
            this.dgvTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrips.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTrips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIsConfirmedImage,
            this.dgvcDateTrip,
            this.dgvcPartnerCarrierName,
            this.dgvcCost,
            this.dgvcAlias,
            this.dgvcCarNumber,
            this.dgvcDriverName,
            this.dgvcID});
            this.dgvTrips.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvTrips.IsConfigInclude = true;
            this.dgvTrips.IsMarkedAll = false;
            this.dgvTrips.IsStatusInclude = true;
            this.dgvTrips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvTrips.Location = new System.Drawing.Point(4, 6);
            this.dgvTrips.MultiSelect = false;
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.RangedWay = ' ';
            this.dgvTrips.RowHeadersWidth = 24;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTrips.Size = new System.Drawing.Size(733, 376);
            this.dgvTrips.TabIndex = 0;
            this.dgvTrips.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTrips_CellFormatting);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 389);
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
            this.btnExit.Location = new System.Drawing.Point(705, 389);
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
            this.btnSave.Location = new System.Drawing.Point(655, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvcIsConfirmedImage
            // 
            this.dgvcIsConfirmedImage.HeaderText = "Пдт.";
            this.dgvcIsConfirmedImage.Name = "dgvcIsConfirmedImage";
            this.dgvcIsConfirmedImage.ReadOnly = true;
            this.dgvcIsConfirmedImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcIsConfirmedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcIsConfirmedImage.ToolTipText = "Рейс подтвержден?";
            this.dgvcIsConfirmedImage.Width = 40;
            // 
            // dgvcDateTrip
            // 
            this.dgvcDateTrip.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDateTrip.DataPropertyName = "DateTrip";
            dataGridViewCellStyle2.Format = "d";
            this.dgvcDateTrip.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcDateTrip.HeaderText = "Дата ";
            this.dgvcDateTrip.Name = "dgvcDateTrip";
            this.dgvcDateTrip.ReadOnly = true;
            this.dgvcDateTrip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcDateTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDateTrip.Width = 75;
            // 
            // dgvcPartnerCarrierName
            // 
            this.dgvcPartnerCarrierName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPartnerCarrierName.DataPropertyName = "PartnerCarrierName";
            this.dgvcPartnerCarrierName.HeaderText = "Грузоперевозчик";
            this.dgvcPartnerCarrierName.Name = "dgvcPartnerCarrierName";
            this.dgvcPartnerCarrierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPartnerCarrierName.Width = 250;
            // 
            // dgvcCost
            // 
            this.dgvcCost.AgrType = RFMBaseClasses.EnumAgregate.Sum;
            this.dgvcCost.DataPropertyName = "Cost";
            this.dgvcCost.DecimalPlaces = 2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvcCost.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcCost.HeaderText = "Себест-сть";
            this.dgvcCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dgvcCost.Name = "dgvcCost";
            this.dgvcCost.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcCost.ToolTipText = "Себестоимость рейса";
            this.dgvcCost.Width = 80;
            // 
            // dgvcAlias
            // 
            this.dgvcAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcAlias.DataPropertyName = "Alias";
            this.dgvcAlias.HeaderText = "Описание";
            this.dgvcAlias.Name = "dgvcAlias";
            this.dgvcAlias.ReadOnly = true;
            this.dgvcAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcAlias.Width = 250;
            // 
            // dgvcCarNumber
            // 
            this.dgvcCarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcCarNumber.DataPropertyName = "CarNumber";
            this.dgvcCarNumber.HeaderText = "Машина";
            this.dgvcCarNumber.Name = "dgvcCarNumber";
            this.dgvcCarNumber.ReadOnly = true;
            this.dgvcCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcCarNumber.Width = 120;
            // 
            // dgvcDriverName
            // 
            this.dgvcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDriverName.DataPropertyName = "DriverName";
            this.dgvcDriverName.HeaderText = "Водитель";
            this.dgvcDriverName.Name = "dgvcDriverName";
            this.dgvcDriverName.ReadOnly = true;
            this.dgvcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDriverName.Width = 120;
            // 
            // dgvcID
            // 
            this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcID.DataPropertyName = "ID";
            this.dgvcID.HeaderText = "ID";
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.Visible = false;
            this.dgvcID.Width = 50;
            // 
            // frmTripsCostEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.dgvTrips);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "221");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmTripsCostEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Себестоимость рейсов";
            this.Load += new System.EventHandler(this.frmTripsCostEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvTrips;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
        private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMDataGridViewImageColumn dgvcIsConfirmedImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateTrip;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnerCarrierName;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcCost;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcCarNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDriverName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
	}
}

