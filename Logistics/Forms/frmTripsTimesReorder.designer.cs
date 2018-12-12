namespace Logistics 
{
	partial class frmTripsTimesReorder
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
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnMax = new RFMBaseClasses.RFMButton();
			this.btnMin = new RFMBaseClasses.RFMButton();
			this.btnPlus = new RFMBaseClasses.RFMButton();
			this.btnMinus = new RFMBaseClasses.RFMButton();
			this.btnPgDown = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.grdTrips = new RFMBaseClasses.RFMDataGridView();
			this.grcReadyForTripBegImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcTripReadyImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcIsPrintedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcByOrder = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.grcAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTimeBeg = new RFMBaseClasses.RFMDataGridViewTextBoxTimeColumn();
			this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dtpDateTrip = new RFMBaseClasses.RFMDateTimePicker();
			this.btnGo = new RFMBaseClasses.RFMButton();
			this.btnByTime = new RFMBaseClasses.RFMButton();
			this.btnPgUp = new RFMBaseClasses.RFMButton();
			this.lblDelta = new RFMBaseClasses.RFMLabel();
			this.nudDelta = new RFMBaseClasses.RFMNumericUpDown();
			this.btnSort = new RFMBaseClasses.RFMButton();
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDelta)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(9, 435);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(32, 30);
			this.btnHelp.TabIndex = 0;
			this.ttToolTip.SetToolTip(this.btnHelp, "Помощь");
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
			this.btnExit.Location = new System.Drawing.Point(702, 435);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 30);
			this.btnExit.TabIndex = 12;
			this.ttToolTip.SetToolTip(this.btnExit, "Выйти без сохранения");
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnMax
			// 
			this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMax.Image = global::Logistics.Properties.Resources.Bottom_B;
			this.btnMax.Location = new System.Drawing.Point(486, 435);
			this.btnMax.Name = "btnMax";
			this.btnMax.Size = new System.Drawing.Size(32, 30);
			this.btnMax.TabIndex = 7;
			this.ttToolTip.SetToolTip(this.btnMax, "В конец списка");
			this.btnMax.UseVisualStyleBackColor = true;
			this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
			// 
			// btnMin
			// 
			this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMin.Image = global::Logistics.Properties.Resources.Bottom_T;
			this.btnMin.Location = new System.Drawing.Point(524, 435);
			this.btnMin.Name = "btnMin";
			this.btnMin.Size = new System.Drawing.Size(32, 30);
			this.btnMin.TabIndex = 8;
			this.ttToolTip.SetToolTip(this.btnMin, "В начало списка");
			this.btnMin.UseVisualStyleBackColor = true;
			this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
			// 
			// btnPlus
			// 
			this.btnPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPlus.Image = global::Logistics.Properties.Resources.Down;
			this.btnPlus.Location = new System.Drawing.Point(270, 435);
			this.btnPlus.Name = "btnPlus";
			this.btnPlus.Size = new System.Drawing.Size(32, 30);
			this.btnPlus.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.btnPlus, "Вниз на 1");
			this.btnPlus.UseVisualStyleBackColor = true;
			this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
			// 
			// btnMinus
			// 
			this.btnMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnMinus.Image = global::Logistics.Properties.Resources.Up;
			this.btnMinus.Location = new System.Drawing.Point(308, 435);
			this.btnMinus.Name = "btnMinus";
			this.btnMinus.Size = new System.Drawing.Size(32, 30);
			this.btnMinus.TabIndex = 4;
			this.ttToolTip.SetToolTip(this.btnMinus, "Вверх на 1");
			this.btnMinus.UseVisualStyleBackColor = true;
			this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
			// 
			// btnPgDown
			// 
			this.btnPgDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPgDown.Image = global::Logistics.Properties.Resources.PgDn;
			this.btnPgDown.Location = new System.Drawing.Point(378, 435);
			this.btnPgDown.Name = "btnPgDown";
			this.btnPgDown.Size = new System.Drawing.Size(32, 30);
			this.btnPgDown.TabIndex = 5;
			this.ttToolTip.SetToolTip(this.btnPgDown, "На 1 страницу вниз");
			this.btnPgDown.UseVisualStyleBackColor = true;
			this.btnPgDown.Click += new System.EventHandler(this.btnPgDown_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Image = global::Logistics.Properties.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(664, 435);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 30);
			this.btnSave.TabIndex = 11;
			this.ttToolTip.SetToolTip(this.btnSave, "Сохранить изменения");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
			this.grdTrips.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcReadyForTripBegImage,
            this.grcTripReadyImage,
            this.grcIsPrintedImage,
            this.grcByOrder,
            this.grcAlias,
            this.grcTimeBeg,
            this.grcID});
			this.grdTrips.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.grdTrips.IsConfigInclude = true;
			this.grdTrips.IsMarkedAll = false;
			this.grdTrips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdTrips.Location = new System.Drawing.Point(7, 40);
			this.grdTrips.MultiSelect = false;
			this.grdTrips.Name = "grdTrips";
			this.grdTrips.RangedWay = ' ';
			this.grdTrips.RowHeadersWidth = 24;
			this.grdTrips.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdTrips.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
			this.grdTrips.SelectedRowForeColor = System.Drawing.Color.Black;
			this.grdTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.grdTrips.Size = new System.Drawing.Size(729, 388);
			this.grdTrips.TabIndex = 2;
			this.grdTrips.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdTrips_CurrentRowChanged);
			this.grdTrips.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTrips_CellValidated);
			this.grdTrips.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdTrips_CellFormatting);
			// 
			// grcReadyForTripBegImage
			// 
			this.grcReadyForTripBegImage.DataPropertyName = "ReadyForTripBegImage";
			this.grcReadyForTripBegImage.HeaderText = "Нач.";
			this.grcReadyForTripBegImage.Name = "grcReadyForTripBegImage";
			this.grcReadyForTripBegImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcReadyForTripBegImage.ToolTipText = "Рейс готов к началу (все задания подтверждены)?";
			this.grcReadyForTripBegImage.Width = 40;
			// 
			// grcTripReadyImage
			// 
			this.grcTripReadyImage.HeaderText = "Готов";
			this.grcTripReadyImage.Name = "grcTripReadyImage";
			this.grcTripReadyImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTripReadyImage.ToolTipText = "Красный - рейс не готов, синий - готов к обработке на складе, желтый - готов к пе" +
				"чати, зеленый - готов к выходу";
			this.grcTripReadyImage.Width = 45;
			// 
			// grcIsPrintedImage
			// 
			this.grcIsPrintedImage.DataPropertyName = "IsPrinted";
			this.grcIsPrintedImage.HeaderText = "Печ.";
			this.grcIsPrintedImage.Name = "grcIsPrintedImage";
			this.grcIsPrintedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsPrintedImage.ToolTipText = "Документы напечатаны?";
			this.grcIsPrintedImage.Width = 40;
			// 
			// grcByOrder
			// 
			this.grcByOrder.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcByOrder.DataPropertyName = "ByOrder";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
			this.grcByOrder.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcByOrder.HeaderText = "№ п/п";
			this.grcByOrder.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.grcByOrder.Name = "grcByOrder";
			this.grcByOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcByOrder.Width = 45;
			// 
			// grcAlias
			// 
			this.grcAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcAlias.DataPropertyName = "Alias";
			this.grcAlias.HeaderText = "Рейс";
			this.grcAlias.Name = "grcAlias";
			this.grcAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcAlias.Width = 430;
			// 
			// grcTimeBeg
			// 
			this.grcTimeBeg.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTimeBeg.DataPropertyName = "TimeBeg";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.Format = "t";
			dataGridViewCellStyle3.NullValue = ":";
			this.grcTimeBeg.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcTimeBeg.HeaderText = "Время вых.";
			this.grcTimeBeg.MaxInputLength = 5;
			this.grcTimeBeg.Name = "grcTimeBeg";
			this.grcTimeBeg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcTimeBeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTimeBeg.ToolTipText = "Планируемое время выхода машины, час:мин";
			this.grcTimeBeg.Width = 80;
			// 
			// grcID
			// 
			this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcID.DataPropertyName = "ID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcID.DefaultCellStyle = dataGridViewCellStyle4;
			this.grcID.HeaderText = "ID";
			this.grcID.Name = "grcID";
			this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcID.ToolTipText = "Код записи";
			this.grcID.Visible = false;
			this.grcID.Width = 50;
			// 
			// dtpDateTrip
			// 
			this.dtpDateTrip.CustomFormat = "dd.MM.yyyy";
			this.dtpDateTrip.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateTrip.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateTrip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTrip.Location = new System.Drawing.Point(7, 8);
			this.dtpDateTrip.Name = "dtpDateTrip";
			this.dtpDateTrip.OldValue = new System.DateTime(2009, 3, 12, 12, 55, 54, 296);
			this.dtpDateTrip.Size = new System.Drawing.Size(92, 22);
			this.dtpDateTrip.TabIndex = 0;
			// 
			// btnGo
			// 
			this.btnGo.Image = global::Logistics.Properties.Resources.Go;
			this.btnGo.Location = new System.Drawing.Point(107, 4);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(32, 30);
			this.btnGo.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.btnGo, "Вывести список рейсов");
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnByTime
			// 
			this.btnByTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnByTime.Image = global::Logistics.Properties.Resources.Wizard;
			this.btnByTime.Location = new System.Drawing.Point(594, 435);
			this.btnByTime.Name = "btnByTime";
			this.btnByTime.Size = new System.Drawing.Size(32, 30);
			this.btnByTime.TabIndex = 9;
			this.ttToolTip.SetToolTip(this.btnByTime, "Упорядочить по времени выхода");
			this.btnByTime.UseVisualStyleBackColor = true;
			this.btnByTime.Click += new System.EventHandler(this.btnByTime_Click);
			// 
			// btnPgUp
			// 
			this.btnPgUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPgUp.Image = global::Logistics.Properties.Resources.PgUp;
			this.btnPgUp.Location = new System.Drawing.Point(416, 435);
			this.btnPgUp.Name = "btnPgUp";
			this.btnPgUp.Size = new System.Drawing.Size(32, 30);
			this.btnPgUp.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnPgUp, "На 1 страницу вверх");
			this.btnPgUp.UseVisualStyleBackColor = true;
			this.btnPgUp.Click += new System.EventHandler(this.btnPgUp_Click);
			// 
			// lblDelta
			// 
			this.lblDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDelta.AutoSize = true;
			this.lblDelta.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDelta.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDelta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDelta.Location = new System.Drawing.Point(60, 443);
			this.lblDelta.Name = "lblDelta";
			this.lblDelta.Size = new System.Drawing.Size(76, 14);
			this.lblDelta.TabIndex = 13;
			this.lblDelta.Text = "Размер шага";
			this.lblDelta.Visible = false;
			// 
			// nudDelta
			// 
			this.nudDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.nudDelta.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.nudDelta.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.nudDelta.IsNull = false;
			this.nudDelta.Location = new System.Drawing.Point(139, 439);
			this.nudDelta.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.nudDelta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudDelta.Name = "nudDelta";
			this.nudDelta.Size = new System.Drawing.Size(45, 22);
			this.nudDelta.TabIndex = 14;
			this.nudDelta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.nudDelta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudDelta.Visible = false;
			// 
			// btnSort
			// 
			this.btnSort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSort.Image = global::Logistics.Properties.Resources.Sort;
			this.btnSort.Location = new System.Drawing.Point(200, 435);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(32, 30);
			this.btnSort.TabIndex = 10;
			this.ttToolTip.SetToolTip(this.btnSort, "Упорядочить по текущей сортировке");
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// frmTripsTimesReorder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 472);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.lblDelta);
			this.Controls.Add(this.nudDelta);
			this.Controls.Add(this.btnPgUp);
			this.Controls.Add(this.btnByTime);
			this.Controls.Add(this.btnGo);
			this.Controls.Add(this.dtpDateTrip);
			this.Controls.Add(this.grdTrips);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnPgDown);
			this.Controls.Add(this.btnMinus);
			this.Controls.Add(this.btnPlus);
			this.Controls.Add(this.btnMin);
			this.Controls.Add(this.btnMax);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Name = "frmTripsTimesReorder";
			this.Text = "Порядок выхода машин";
			this.Load += new System.EventHandler(this.frmTripsTimesReorder_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTripsTimesReorder_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDelta)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		#endregion

		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnMax;
		private RFMBaseClasses.RFMButton btnMin;
		private RFMBaseClasses.RFMButton btnPlus;
		private RFMBaseClasses.RFMButton btnMinus;
		private RFMBaseClasses.RFMButton btnPgDown;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMDataGridView grdTrips;
		private RFMBaseClasses.RFMDateTimePicker dtpDateTrip;
		private RFMBaseClasses.RFMButton btnGo;
        private RFMBaseClasses.RFMButton btnByTime;
		private RFMBaseClasses.RFMButton btnPgUp;
		private RFMBaseClasses.RFMLabel lblDelta;
		private RFMBaseClasses.RFMNumericUpDown nudDelta;
		private RFMBaseClasses.RFMButton btnSort;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcReadyForTripBegImage;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcTripReadyImage;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcIsPrintedImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn grcByOrder;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxTimeColumn grcTimeBeg;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
	}
}