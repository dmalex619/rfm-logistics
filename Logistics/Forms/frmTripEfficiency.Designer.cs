namespace Logistics
{
    partial class frmTripEfficiency : RFMBaseClasses.RFMFormChild
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
            this.lblTripCost = new RFMBaseClasses.RFMLabel();
            this.lblDistance = new RFMBaseClasses.RFMLabel();
            this.lblNormDistance = new RFMBaseClasses.RFMLabel();
            this.lblNormWarehouse = new RFMBaseClasses.RFMLabel();
            this.numTripCost = new RFMBaseClasses.RFMNumericUpDown();
            this.numDistance = new RFMBaseClasses.RFMNumericUpDown();
            this.numNormDistance = new RFMBaseClasses.RFMNumericUpDown();
            this.numNormWarehouse = new RFMBaseClasses.RFMNumericUpDown();
            this.dgvMain = new RFMBaseClasses.RFMDataGridView();
            this.btnCalc = new RFMBaseClasses.RFMButton();
            this.btnCalcRoute = new RFMBaseClasses.RFMButton();
            this.grcOutIn = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.grcPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcHostName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDistance = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcExpences = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCleanMarkup = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCleanMarkupPrc = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numTripCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNormDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNormWarehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTripCost
            // 
            this.lblTripCost.AutoSize = true;
            this.lblTripCost.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTripCost.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTripCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTripCost.Location = new System.Drawing.Point(10, 13);
            this.lblTripCost.Name = "lblTripCost";
            this.lblTripCost.Size = new System.Drawing.Size(104, 14);
            this.lblTripCost.TabIndex = 0;
            this.lblTripCost.Text = "Стоимость рейса";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistance.Location = new System.Drawing.Point(150, 13);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(48, 14);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Пробег";
            // 
            // lblNormDistance
            // 
            this.lblNormDistance.AutoSize = true;
            this.lblNormDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNormDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNormDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNormDistance.Location = new System.Drawing.Point(320, 13);
            this.lblNormDistance.Name = "lblNormDistance";
            this.lblNormDistance.Size = new System.Drawing.Size(165, 14);
            this.lblNormDistance.TabIndex = 2;
            this.lblNormDistance.Text = "Норматив пробега (руб/км)";
            // 
            // lblNormWarehouse
            // 
            this.lblNormWarehouse.AutoSize = true;
            this.lblNormWarehouse.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNormWarehouse.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNormWarehouse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNormWarehouse.Location = new System.Drawing.Point(530, 13);
            this.lblNormWarehouse.Name = "lblNormWarehouse";
            this.lblNormWarehouse.Size = new System.Drawing.Size(154, 14);
            this.lblNormWarehouse.TabIndex = 3;
            this.lblNormWarehouse.Text = "Норматив склада (руб/кг)";
            // 
            // numTripCost
            // 
            this.numTripCost.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numTripCost.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numTripCost.InputMask = "#######";
            this.numTripCost.IsNull = false;
            this.numTripCost.Location = new System.Drawing.Point(13, 39);
            this.numTripCost.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numTripCost.Name = "numTripCost";
            this.numTripCost.RealPlaces = 7;
            this.numTripCost.Size = new System.Drawing.Size(100, 22);
            this.numTripCost.TabIndex = 4;
            this.numTripCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTripCost.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numDistance
            // 
            this.numDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numDistance.InputMask = "####";
            this.numDistance.IsNull = false;
            this.numDistance.Location = new System.Drawing.Point(153, 39);
            this.numDistance.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.RealPlaces = 4;
            this.numDistance.Size = new System.Drawing.Size(60, 22);
            this.numDistance.TabIndex = 5;
            this.numDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numNormDistance
            // 
            this.numNormDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numNormDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numNormDistance.InputMask = "###";
            this.numNormDistance.IsNull = false;
            this.numNormDistance.Location = new System.Drawing.Point(323, 39);
            this.numNormDistance.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numNormDistance.Name = "numNormDistance";
            this.numNormDistance.RealPlaces = 3;
            this.numNormDistance.Size = new System.Drawing.Size(60, 22);
            this.numNormDistance.TabIndex = 6;
            this.numNormDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNormDistance.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // numNormWarehouse
            // 
            this.numNormWarehouse.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numNormWarehouse.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numNormWarehouse.InputMask = "###";
            this.numNormWarehouse.IsNull = false;
            this.numNormWarehouse.Location = new System.Drawing.Point(533, 39);
            this.numNormWarehouse.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numNormWarehouse.Name = "numNormWarehouse";
            this.numNormWarehouse.RealPlaces = 3;
            this.numNormWarehouse.Size = new System.Drawing.Size(60, 22);
            this.numNormWarehouse.TabIndex = 7;
            this.numNormWarehouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNormWarehouse.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToOrderColumns = true;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcOutIn,
            this.grcPartnerName,
            this.grcHostName,
            this.grcNetto,
            this.grcDistance,
            this.grcExpences,
            this.grcCleanMarkup,
            this.grcCleanMarkupPrc});
            this.dgvMain.IsConfigInclude = true;
            this.dgvMain.IsMarkedAll = false;
            this.dgvMain.IsStatusInclude = true;
            this.dgvMain.IsUseConfig = false;
            this.dgvMain.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvMain.Location = new System.Drawing.Point(13, 83);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RangedWay = ' ';
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersWidth = 24;
            this.dgvMain.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.dgvMain.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.dgvMain.ShowEditingIcon = false;
            this.dgvMain.Size = new System.Drawing.Size(709, 330);
            this.dgvMain.TabIndex = 8;
            this.dgvMain.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMain_CellFormatting);
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Image = global::Logistics.Properties.Resources.Calc;
            this.btnCalc.Location = new System.Drawing.Point(690, 419);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(32, 30);
            this.btnCalc.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnCalc, "Расчет эффективности");
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCalcRoute
            // 
            this.btnCalcRoute.Image = global::Logistics.Properties.Resources.Truck;
            this.btnCalcRoute.Location = new System.Drawing.Point(219, 35);
            this.btnCalcRoute.Name = "btnCalcRoute";
            this.btnCalcRoute.Size = new System.Drawing.Size(32, 30);
            this.btnCalcRoute.TabIndex = 10;
            this.ttToolTip.SetToolTip(this.btnCalcRoute, "Расчет пробега и стоимости рейса");
            this.btnCalcRoute.UseVisualStyleBackColor = true;
            this.btnCalcRoute.Click += new System.EventHandler(this.btnCalcRoute_Click);
            // 
            // grcOutIn
            // 
            this.grcOutIn.DataPropertyName = "OutIn";
            this.grcOutIn.HeaderText = "Тип";
            this.grcOutIn.Name = "grcOutIn";
            this.grcOutIn.ReadOnly = true;
            this.grcOutIn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcOutIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutIn.ToolTipText = "Тип задания (прход/расход/спецзадание)";
            this.grcOutIn.Width = 30;
            // 
            // grcPartnerName
            // 
            this.grcPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerName.DataPropertyName = "PartnerName";
            this.grcPartnerName.HeaderText = "Партнер";
            this.grcPartnerName.Name = "grcPartnerName";
            this.grcPartnerName.ReadOnly = true;
            this.grcPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerName.Width = 300;
            // 
            // grcHostName
            // 
            this.grcHostName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcHostName.DataPropertyName = "HostName";
            this.grcHostName.HeaderText = "Хост";
            this.grcHostName.Name = "grcHostName";
            this.grcHostName.ReadOnly = true;
            this.grcHostName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcNetto
            // 
            this.grcNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNetto.DataPropertyName = "Netto";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.grcNetto.DefaultCellStyle = dataGridViewCellStyle1;
            this.grcNetto.HeaderText = "Нетто";
            this.grcNetto.Name = "grcNetto";
            this.grcNetto.ReadOnly = true;
            this.grcNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNetto.Width = 80;
            // 
            // grcDistance
            // 
            this.grcDistance.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDistance.DataPropertyName = "Distance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.grcDistance.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcDistance.HeaderText = "Дист.";
            this.grcDistance.Name = "grcDistance";
            this.grcDistance.ReadOnly = true;
            this.grcDistance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDistance.ToolTipText = "Дистанция до партнера";
            this.grcDistance.Width = 60;
            // 
            // grcExpences
            // 
            this.grcExpences.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcExpences.DataPropertyName = "Expences";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.grcExpences.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcExpences.HeaderText = "Издержки";
            this.grcExpences.Name = "grcExpences";
            this.grcExpences.ReadOnly = true;
            this.grcExpences.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcCleanMarkup
            // 
            this.grcCleanMarkup.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCleanMarkup.DataPropertyName = "CleanMarkup";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.grcCleanMarkup.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcCleanMarkup.HeaderText = "МП";
            this.grcCleanMarkup.Name = "grcCleanMarkup";
            this.grcCleanMarkup.ReadOnly = true;
            this.grcCleanMarkup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCleanMarkup.ToolTipText = "Маржинальная прибыль";
            // 
            // grcCleanMarkupPrc
            // 
            this.grcCleanMarkupPrc.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCleanMarkupPrc.DataPropertyName = "CleanMarkupPrc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N2";
            this.grcCleanMarkupPrc.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcCleanMarkupPrc.HeaderText = "МП %";
            this.grcCleanMarkupPrc.Name = "grcCleanMarkupPrc";
            this.grcCleanMarkupPrc.ReadOnly = true;
            this.grcCleanMarkupPrc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCleanMarkupPrc.ToolTipText = "Маржинальная прибыль, %";
            this.grcCleanMarkupPrc.Width = 75;
            // 
            // frmTripEfficiency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnCalcRoute);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.numNormWarehouse);
            this.Controls.Add(this.numNormDistance);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.numTripCost);
            this.Controls.Add(this.lblNormWarehouse);
            this.Controls.Add(this.lblNormDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblTripCost);
            this.IsModalMode = true;
            this.IsOneInstance = true;
            this.IsWaitLoading = true;
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "frmTripEfficiency";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет экономической эффективности рейса";
            this.Load += new System.EventHandler(this.frmTripEfficiency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTripCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNormDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNormWarehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RFMBaseClasses.RFMLabel lblTripCost;
        private RFMBaseClasses.RFMLabel lblDistance;
        private RFMBaseClasses.RFMLabel lblNormDistance;
        private RFMBaseClasses.RFMLabel lblNormWarehouse;
        private RFMBaseClasses.RFMNumericUpDown numTripCost;
        private RFMBaseClasses.RFMNumericUpDown numDistance;
        private RFMBaseClasses.RFMNumericUpDown numNormDistance;
        private RFMBaseClasses.RFMNumericUpDown numNormWarehouse;
        private RFMBaseClasses.RFMDataGridView dgvMain;
        private RFMBaseClasses.RFMButton btnCalc;
        private RFMBaseClasses.RFMButton btnCalcRoute;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcOutIn;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcHostName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNetto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDistance;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcExpences;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCleanMarkup;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCleanMarkupPrc;
    }
}