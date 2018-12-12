namespace Logistics
{
	partial class frmSalaryTariffs 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcDateBeg = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDaysWorking = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcRetPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcInPoints = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDistance = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcEarlyDepartureTariff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTimeTariff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNettoTariff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcUserName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateInput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 387);
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
            this.btnExit.Location = new System.Drawing.Point(605, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.IsAccessOn = true;
            this.btnEdit.Location = new System.Drawing.Point(505, 388);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 11;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.IsAccessOn = true;
            this.btnDelete.Location = new System.Drawing.Point(555, 388);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 12;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удаление");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.IsAccessOn = true;
            this.btnAdd.Location = new System.Drawing.Point(455, 388);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 10;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавление");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.grdData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.grcDateBeg,
            this.grcDaysWorking,
            this.grcOutNetto,
            this.grcOutPoints,
            this.grcRetPoints,
            this.grcInPoints,
            this.grcDistance,
            this.grcEarlyDepartureTariff,
            this.grcTimeTariff,
            this.grcNettoTariff,
            this.grcUserName,
            this.grcDateInput,
            this.grcID});
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
            this.grdData.Location = new System.Drawing.Point(3, 4);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 24;
            this.grdData.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdData.Size = new System.Drawing.Size(636, 378);
            this.grdData.TabIndex = 13;
            // 
            // grcDateBeg
            // 
            this.grcDateBeg.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateBeg.DataPropertyName = "DateBeg";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.grcDateBeg.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcDateBeg.HeaderText = "Дата нач.";
            this.grcDateBeg.Name = "grcDateBeg";
            this.grcDateBeg.ReadOnly = true;
            this.grcDateBeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateBeg.ToolTipText = "Дата начала действия тарифов";
            this.grcDateBeg.Width = 80;
            // 
            // grcDaysWorking
            // 
            this.grcDaysWorking.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDaysWorking.DataPropertyName = "DaysWorking";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.grcDaysWorking.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcDaysWorking.HeaderText = "За день";
            this.grcDaysWorking.Name = "grcDaysWorking";
            this.grcDaysWorking.ReadOnly = true;
            this.grcDaysWorking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDaysWorking.ToolTipText = "Тариф за 1 отработанный день";
            this.grcDaysWorking.Width = 90;
            // 
            // grcOutNetto
            // 
            this.grcOutNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutNetto.DataPropertyName = "OutNetto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.grcOutNetto.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcOutNetto.HeaderText = "За кг веса";
            this.grcOutNetto.Name = "grcOutNetto";
            this.grcOutNetto.ReadOnly = true;
            this.grcOutNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutNetto.ToolTipText = "Тариф за 1 кг доставленного веса нетто";
            this.grcOutNetto.Width = 90;
            // 
            // grcOutPoints
            // 
            this.grcOutPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutPoints.DataPropertyName = "OutPoints";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.grcOutPoints.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcOutPoints.HeaderText = "Точ.доставки";
            this.grcOutPoints.Name = "grcOutPoints";
            this.grcOutPoints.ReadOnly = true;
            this.grcOutPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutPoints.ToolTipText = "Тариф за 1 точку доставки (клиенту)";
            this.grcOutPoints.Width = 90;
            // 
            // grcRetPoints
            // 
            this.grcRetPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcRetPoints.DataPropertyName = "RetPoints";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            this.grcRetPoints.DefaultCellStyle = dataGridViewCellStyle6;
            this.grcRetPoints.HeaderText = "Точ.возврата";
            this.grcRetPoints.Name = "grcRetPoints";
            this.grcRetPoints.ReadOnly = true;
            this.grcRetPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcRetPoints.ToolTipText = "Тариф за 1 точку возврата (от клиента)";
            this.grcRetPoints.Width = 90;
            // 
            // grcInPoints
            // 
            this.grcInPoints.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcInPoints.DataPropertyName = "InPoints";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.grcInPoints.DefaultCellStyle = dataGridViewCellStyle7;
            this.grcInPoints.HeaderText = "Точ.приемки";
            this.grcInPoints.Name = "grcInPoints";
            this.grcInPoints.ReadOnly = true;
            this.grcInPoints.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcInPoints.ToolTipText = "Тариф за 1 точку приемки (от поставщика)";
            this.grcInPoints.Width = 90;
            // 
            // grcDistance
            // 
            this.grcDistance.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDistance.DataPropertyName = "Distance";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.grcDistance.DefaultCellStyle = dataGridViewCellStyle8;
            this.grcDistance.HeaderText = "За км пробега";
            this.grcDistance.Name = "grcDistance";
            this.grcDistance.ReadOnly = true;
            this.grcDistance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDistance.ToolTipText = "Тариф за 1 км пробега";
            this.grcDistance.Width = 90;
            // 
            // grcEarlyDepartureTariff
            // 
            this.grcEarlyDepartureTariff.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcEarlyDepartureTariff.DataPropertyName = "EarlyDepartureTariff";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Format = "N2";
            this.grcEarlyDepartureTariff.DefaultCellStyle = dataGridViewCellStyle9;
            this.grcEarlyDepartureTariff.HeaderText = "Ранний выезд";
            this.grcEarlyDepartureTariff.Name = "grcEarlyDepartureTariff";
            this.grcEarlyDepartureTariff.ReadOnly = true;
            this.grcEarlyDepartureTariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcEarlyDepartureTariff.ToolTipText = "Стоимость раннего выезда";
            // 
            // grcTimeTariff
            // 
            this.grcTimeTariff.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTimeTariff.DataPropertyName = "TimeTariff";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Format = "N2";
            this.grcTimeTariff.DefaultCellStyle = dataGridViewCellStyle10;
            this.grcTimeTariff.HeaderText = "ТЕ время";
            this.grcTimeTariff.Name = "grcTimeTariff";
            this.grcTimeTariff.ReadOnly = true;
            this.grcTimeTariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTimeTariff.ToolTipText = "Стоимость тарифной единицы (время работы)";
            // 
            // grcNettoTariff
            // 
            this.grcNettoTariff.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNettoTariff.DataPropertyName = "NettoTariff";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.Format = "N2";
            this.grcNettoTariff.DefaultCellStyle = dataGridViewCellStyle11;
            this.grcNettoTariff.HeaderText = "ТЕ нетто";
            this.grcNettoTariff.Name = "grcNettoTariff";
            this.grcNettoTariff.ReadOnly = true;
            this.grcNettoTariff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNettoTariff.ToolTipText = "Стоимость тарифной единицы (нетто)";
            // 
            // grcUserName
            // 
            this.grcUserName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcUserName.DataPropertyName = "UserName";
            this.grcUserName.HeaderText = "Ввел/изм.";
            this.grcUserName.Name = "grcUserName";
            this.grcUserName.ReadOnly = true;
            this.grcUserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcUserName.ToolTipText = "Кто ввел/изменил тарифы";
            this.grcUserName.Width = 120;
            // 
            // grcDateInput
            // 
            this.grcDateInput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateInput.DataPropertyName = "DateInput";
            this.grcDateInput.HeaderText = "Дата-время изм.";
            this.grcDateInput.Name = "grcDateInput";
            this.grcDateInput.ReadOnly = true;
            this.grcDateInput.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcDateInput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateInput.ToolTipText = "Дата время последнего изменения";
            this.grcDateInput.Width = 110;
            // 
            // grcID
            // 
            this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcID.DataPropertyName = "ID";
            this.grcID.HeaderText = "ID";
            this.grcID.Name = "grcID";
            this.grcID.ReadOnly = true;
            this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcID.Visible = false;
            // 
            // frmSalaryTariffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 423);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.hpHelp.SetHelpKeyword(this, "802");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsAccessOn = true;
            this.Name = "frmSalaryTariffs";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы по видам работ";
            this.Load += new System.EventHandler(this.frmSalaryTariffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMDataGridView grdData;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateBeg;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDaysWorking;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutNetto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutPoints;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcRetPoints;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcInPoints;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDistance;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcEarlyDepartureTariff;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTimeTariff;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNettoTariff;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcUserName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateInput;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
	}
}

