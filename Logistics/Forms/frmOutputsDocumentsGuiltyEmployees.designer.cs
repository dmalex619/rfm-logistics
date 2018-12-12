namespace Logistics
{
	partial class frmOutputsDocumentsGuiltyEmployees
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
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.txtGuiltyEmployees = new RFMBaseClasses.RFMTextBox();
            this.btnGuiltyEmloyeeSelect = new RFMBaseClasses.RFMButton();
            this.pnlOutputDocument = new RFMBaseClasses.RFMPanel();
            this.lblOutputDocumentGuiltyEmployees = new RFMBaseClasses.RFMLabel();
            this.lblOutputDocumentFailReason = new RFMBaseClasses.RFMLabel();
            this.cboOutputDocumentFailReason = new RFMBaseClasses.RFMComboBox();
            this.lblOutputDocument = new RFMBaseClasses.RFMLabel();
            this.chkOneGuilty = new RFMBaseClasses.RFMCheckBox();
            this.grdOutputsDocumentsGoods = new RFMBaseClasses.RFMDataGridView();
            this.grcOutputsGoods_GoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_QntWished = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_QntConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_QntBrought = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_QntDiff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_ReturnReasonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grcOutputsGoods_GuiltyEmployees = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_BoxWished = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_BoxConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_BoxBrought = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_BoxDiff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_InBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_Weighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcOutputsGoods_GoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_GoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_GoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_GoodStateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsGoods_PackingID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.pnlOutputDocumentGoods = new RFMBaseClasses.RFMPanel();
            this.lblOutputDocumentGoods = new RFMBaseClasses.RFMLabel();
            this.btnReturnReason = new RFMBaseClasses.RFMButton();
            this.btnGoodsGultiesFill = new RFMBaseClasses.RFMButton();
            this.btnGoodsGultiesClear = new RFMBaseClasses.RFMButton();
            this.chkIsDriverFoul = new RFMBaseClasses.RFMCheckBox();
            this.pnlOutputDocument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutputsDocumentsGoods)).BeginInit();
            this.pnlOutputDocumentGoods.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 338);
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
            this.btnExit.Location = new System.Drawing.Point(654, 338);
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
            this.btnSave.Location = new System.Drawing.Point(604, 338);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGuiltyEmployees
            // 
            this.txtGuiltyEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuiltyEmployees.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtGuiltyEmployees.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtGuiltyEmployees.Location = new System.Drawing.Point(182, 27);
            this.txtGuiltyEmployees.MaxLength = 50;
            this.txtGuiltyEmployees.Name = "txtGuiltyEmployees";
            this.txtGuiltyEmployees.Size = new System.Drawing.Size(470, 22);
            this.txtGuiltyEmployees.TabIndex = 1;
            // 
            // btnGuiltyEmloyeeSelect
            // 
            this.btnGuiltyEmloyeeSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuiltyEmloyeeSelect.FlatAppearance.BorderSize = 0;
            this.btnGuiltyEmloyeeSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiltyEmloyeeSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnGuiltyEmloyeeSelect.Location = new System.Drawing.Point(655, 25);
            this.btnGuiltyEmloyeeSelect.Name = "btnGuiltyEmloyeeSelect";
            this.btnGuiltyEmloyeeSelect.Size = new System.Drawing.Size(25, 25);
            this.btnGuiltyEmloyeeSelect.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnGuiltyEmloyeeSelect, "Выбрать из ранее введенных значений (для заказов)");
            this.btnGuiltyEmloyeeSelect.UseVisualStyleBackColor = true;
            this.btnGuiltyEmloyeeSelect.Click += new System.EventHandler(this.btnGuiltyEmloyeeSelect_Click);
            // 
            // pnlOutputDocument
            // 
            this.pnlOutputDocument.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutputDocument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOutputDocument.Controls.Add(this.chkIsDriverFoul);
            this.pnlOutputDocument.Controls.Add(this.lblOutputDocumentGuiltyEmployees);
            this.pnlOutputDocument.Controls.Add(this.lblOutputDocumentFailReason);
            this.pnlOutputDocument.Controls.Add(this.cboOutputDocumentFailReason);
            this.pnlOutputDocument.Controls.Add(this.lblOutputDocument);
            this.pnlOutputDocument.Controls.Add(this.chkOneGuilty);
            this.pnlOutputDocument.Controls.Add(this.btnGuiltyEmloyeeSelect);
            this.pnlOutputDocument.Controls.Add(this.txtGuiltyEmployees);
            this.pnlOutputDocument.Location = new System.Drawing.Point(3, 4);
            this.pnlOutputDocument.Name = "pnlOutputDocument";
            this.pnlOutputDocument.Size = new System.Drawing.Size(686, 76);
            this.pnlOutputDocument.TabIndex = 0;
            // 
            // lblOutputDocumentGuiltyEmployees
            // 
            this.lblOutputDocumentGuiltyEmployees.AutoSize = true;
            this.lblOutputDocumentGuiltyEmployees.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDocumentGuiltyEmployees.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutputDocumentGuiltyEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutputDocumentGuiltyEmployees.Location = new System.Drawing.Point(118, 31);
            this.lblOutputDocumentGuiltyEmployees.Name = "lblOutputDocumentGuiltyEmployees";
            this.lblOutputDocumentGuiltyEmployees.Size = new System.Drawing.Size(64, 14);
            this.lblOutputDocumentGuiltyEmployees.TabIndex = 19;
            this.lblOutputDocumentGuiltyEmployees.Text = "виновник:";
            // 
            // lblOutputDocumentFailReason
            // 
            this.lblOutputDocumentFailReason.AutoSize = true;
            this.lblOutputDocumentFailReason.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDocumentFailReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutputDocumentFailReason.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutputDocumentFailReason.Location = new System.Drawing.Point(118, 6);
            this.lblOutputDocumentFailReason.Name = "lblOutputDocumentFailReason";
            this.lblOutputDocumentFailReason.Size = new System.Drawing.Size(59, 14);
            this.lblOutputDocumentFailReason.TabIndex = 18;
            this.lblOutputDocumentFailReason.Text = "причина:";
            // 
            // cboOutputDocumentFailReason
            // 
            this.cboOutputDocumentFailReason.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboOutputDocumentFailReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboOutputDocumentFailReason.FormattingEnabled = true;
            this.cboOutputDocumentFailReason.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboOutputDocumentFailReason.Location = new System.Drawing.Point(182, 3);
            this.cboOutputDocumentFailReason.Name = "cboOutputDocumentFailReason";
            this.cboOutputDocumentFailReason.Size = new System.Drawing.Size(470, 22);
            this.cboOutputDocumentFailReason.TabIndex = 17;
            // 
            // lblOutputDocument
            // 
            this.lblOutputDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutputDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutputDocument.Location = new System.Drawing.Point(3, 6);
            this.lblOutputDocument.Name = "lblOutputDocument";
            this.lblOutputDocument.Size = new System.Drawing.Size(156, 14);
            this.lblOutputDocument.TabIndex = 16;
            this.lblOutputDocument.Text = "Для всего заказа:";
            // 
            // chkOneGuilty
            // 
            this.chkOneGuilty.AutoSize = true;
            this.chkOneGuilty.Location = new System.Drawing.Point(534, 189);
            this.chkOneGuilty.Name = "chkOneGuilty";
            this.chkOneGuilty.Size = new System.Drawing.Size(126, 18);
            this.chkOneGuilty.TabIndex = 15;
            this.chkOneGuilty.Text = "Для всех товаров";
            this.chkOneGuilty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkOneGuilty.UseVisualStyleBackColor = true;
            // 
            // grdOutputsDocumentsGoods
            // 
            this.grdOutputsDocumentsGoods.AllowUserToAddRows = false;
            this.grdOutputsDocumentsGoods.AllowUserToDeleteRows = false;
            this.grdOutputsDocumentsGoods.AllowUserToOrderColumns = true;
            this.grdOutputsDocumentsGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOutputsDocumentsGoods.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdOutputsDocumentsGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdOutputsDocumentsGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOutputsDocumentsGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOutputsDocumentsGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOutputsDocumentsGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcOutputsGoods_GoodAlias,
            this.grcOutputsGoods_QntWished,
            this.grcOutputsGoods_QntConfirmed,
            this.grcOutputsGoods_QntBrought,
            this.grcOutputsGoods_QntDiff,
            this.grcOutputsGoods_ReturnReasonName,
            this.grcOutputsGoods_GuiltyEmployees,
            this.grcOutputsGoods_BoxWished,
            this.grcOutputsGoods_BoxConfirmed,
            this.grcOutputsGoods_BoxBrought,
            this.grcOutputsGoods_BoxDiff,
            this.grcOutputsGoods_InBox,
            this.grcOutputsGoods_Weighting,
            this.grcOutputsGoods_GoodBarCode,
            this.grcOutputsGoods_GoodGroupName,
            this.grcOutputsGoods_GoodBrandName,
            this.grcOutputsGoods_GoodStateName,
            this.grcOutputsGoods_PackingID});
            this.grdOutputsDocumentsGoods.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdOutputsDocumentsGoods.IsCheckerInclude = true;
            this.grdOutputsDocumentsGoods.IsConfigInclude = true;
            this.grdOutputsDocumentsGoods.IsMarkedAll = false;
            this.grdOutputsDocumentsGoods.IsStatusInclude = true;
            this.grdOutputsDocumentsGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdOutputsDocumentsGoods.Location = new System.Drawing.Point(-1, 21);
            this.grdOutputsDocumentsGoods.MultiSelect = false;
            this.grdOutputsDocumentsGoods.Name = "grdOutputsDocumentsGoods";
            this.grdOutputsDocumentsGoods.RangedWay = ' ';
            this.grdOutputsDocumentsGoods.RowHeadersWidth = 24;
            this.grdOutputsDocumentsGoods.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdOutputsDocumentsGoods.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdOutputsDocumentsGoods.Size = new System.Drawing.Size(683, 191);
            this.grdOutputsDocumentsGoods.TabIndex = 14;
            this.grdOutputsDocumentsGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdOutputsDocumentsGoods_CellFormatting);
            // 
            // grcOutputsGoods_GoodAlias
            // 
            this.grcOutputsGoods_GoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_GoodAlias.DataPropertyName = "GoodAlias";
            this.grcOutputsGoods_GoodAlias.HeaderText = "Товар";
            this.grcOutputsGoods_GoodAlias.Name = "grcOutputsGoods_GoodAlias";
            this.grcOutputsGoods_GoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_GoodAlias.ToolTipText = "Товар";
            this.grcOutputsGoods_GoodAlias.Width = 240;
            // 
            // grcOutputsGoods_QntWished
            // 
            this.grcOutputsGoods_QntWished.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_QntWished.DataPropertyName = "QntWished";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            this.grcOutputsGoods_QntWished.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcOutputsGoods_QntWished.HeaderText = "Заказ шт.";
            this.grcOutputsGoods_QntWished.Name = "grcOutputsGoods_QntWished";
            this.grcOutputsGoods_QntWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_QntWished.ToolTipText = "Заказано штук";
            this.grcOutputsGoods_QntWished.Width = 70;
            // 
            // grcOutputsGoods_QntConfirmed
            // 
            this.grcOutputsGoods_QntConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_QntConfirmed.DataPropertyName = "QntConfirmed";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.grcOutputsGoods_QntConfirmed.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcOutputsGoods_QntConfirmed.HeaderText = "Отгр. шт.";
            this.grcOutputsGoods_QntConfirmed.Name = "grcOutputsGoods_QntConfirmed";
            this.grcOutputsGoods_QntConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_QntConfirmed.ToolTipText = "Отгружено штук";
            this.grcOutputsGoods_QntConfirmed.Width = 70;
            // 
            // grcOutputsGoods_QntBrought
            // 
            this.grcOutputsGoods_QntBrought.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_QntBrought.DataPropertyName = "QntBrought";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.grcOutputsGoods_QntBrought.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcOutputsGoods_QntBrought.HeaderText = "Дост. шт.";
            this.grcOutputsGoods_QntBrought.Name = "grcOutputsGoods_QntBrought";
            this.grcOutputsGoods_QntBrought.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_QntBrought.ToolTipText = "Доставлено штук";
            this.grcOutputsGoods_QntBrought.Width = 70;
            // 
            // grcOutputsGoods_QntDiff
            // 
            this.grcOutputsGoods_QntDiff.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_QntDiff.DataPropertyName = "QntDiff";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Format = "N0";
            this.grcOutputsGoods_QntDiff.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcOutputsGoods_QntDiff.HeaderText = "Разница шт.";
            this.grcOutputsGoods_QntDiff.Name = "grcOutputsGoods_QntDiff";
            this.grcOutputsGoods_QntDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_QntDiff.ToolTipText = "Разница в количестве штук (отгружено - заказано)";
            this.grcOutputsGoods_QntDiff.Visible = false;
            this.grcOutputsGoods_QntDiff.Width = 90;
            // 
            // grcOutputsGoods_ReturnReasonName
            // 
            this.grcOutputsGoods_ReturnReasonName.DataPropertyName = "ReturnReasonName";
            this.grcOutputsGoods_ReturnReasonName.HeaderText = "Причина несоответствия";
            this.grcOutputsGoods_ReturnReasonName.Name = "grcOutputsGoods_ReturnReasonName";
            this.grcOutputsGoods_ReturnReasonName.ToolTipText = "Причина несоответствия отгруженного и доставленного количества";
            this.grcOutputsGoods_ReturnReasonName.Width = 150;
            // 
            // grcOutputsGoods_GuiltyEmployees
            // 
            this.grcOutputsGoods_GuiltyEmployees.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_GuiltyEmployees.DataPropertyName = "GuiltyEmployees";
            this.grcOutputsGoods_GuiltyEmployees.HeaderText = "Виновник";
            this.grcOutputsGoods_GuiltyEmployees.Name = "grcOutputsGoods_GuiltyEmployees";
            this.grcOutputsGoods_GuiltyEmployees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_GuiltyEmployees.Width = 200;
            // 
            // grcOutputsGoods_BoxWished
            // 
            this.grcOutputsGoods_BoxWished.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_BoxWished.DataPropertyName = "BoxWished";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = null;
            this.grcOutputsGoods_BoxWished.DefaultCellStyle = dataGridViewCellStyle6;
            this.grcOutputsGoods_BoxWished.HeaderText = "Заказ кор.";
            this.grcOutputsGoods_BoxWished.Name = "grcOutputsGoods_BoxWished";
            this.grcOutputsGoods_BoxWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_BoxWished.ToolTipText = "Заказано коробок";
            this.grcOutputsGoods_BoxWished.Width = 60;
            // 
            // grcOutputsGoods_BoxConfirmed
            // 
            this.grcOutputsGoods_BoxConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_BoxConfirmed.DataPropertyName = "BoxConfirmed";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N1";
            this.grcOutputsGoods_BoxConfirmed.DefaultCellStyle = dataGridViewCellStyle7;
            this.grcOutputsGoods_BoxConfirmed.HeaderText = "Отгр. кор.";
            this.grcOutputsGoods_BoxConfirmed.Name = "grcOutputsGoods_BoxConfirmed";
            this.grcOutputsGoods_BoxConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_BoxConfirmed.ToolTipText = "Отгружено коробок";
            this.grcOutputsGoods_BoxConfirmed.Width = 60;
            // 
            // grcOutputsGoods_BoxBrought
            // 
            this.grcOutputsGoods_BoxBrought.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_BoxBrought.DataPropertyName = "BoxBrought";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N1";
            this.grcOutputsGoods_BoxBrought.DefaultCellStyle = dataGridViewCellStyle8;
            this.grcOutputsGoods_BoxBrought.HeaderText = "Дост.кор.";
            this.grcOutputsGoods_BoxBrought.Name = "grcOutputsGoods_BoxBrought";
            this.grcOutputsGoods_BoxBrought.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_BoxBrought.ToolTipText = "Доставлено коробок";
            this.grcOutputsGoods_BoxBrought.Width = 60;
            // 
            // grcOutputsGoods_BoxDiff
            // 
            this.grcOutputsGoods_BoxDiff.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_BoxDiff.DataPropertyName = "BoxDiff";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle9.Format = "N1";
            this.grcOutputsGoods_BoxDiff.DefaultCellStyle = dataGridViewCellStyle9;
            this.grcOutputsGoods_BoxDiff.HeaderText = "Разн. кор.";
            this.grcOutputsGoods_BoxDiff.Name = "grcOutputsGoods_BoxDiff";
            this.grcOutputsGoods_BoxDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_BoxDiff.ToolTipText = "Разница в количестве коробок (отгружено - заказано)";
            this.grcOutputsGoods_BoxDiff.Visible = false;
            this.grcOutputsGoods_BoxDiff.Width = 60;
            // 
            // grcOutputsGoods_InBox
            // 
            this.grcOutputsGoods_InBox.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_InBox.DataPropertyName = "InBox";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = null;
            this.grcOutputsGoods_InBox.DefaultCellStyle = dataGridViewCellStyle10;
            this.grcOutputsGoods_InBox.HeaderText = "В кор.";
            this.grcOutputsGoods_InBox.Name = "grcOutputsGoods_InBox";
            this.grcOutputsGoods_InBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_InBox.ToolTipText = "Штук/кг в коробке";
            this.grcOutputsGoods_InBox.Width = 48;
            // 
            // grcOutputsGoods_Weighting
            // 
            this.grcOutputsGoods_Weighting.DataPropertyName = "Weighting";
            this.grcOutputsGoods_Weighting.HeaderText = "Вес";
            this.grcOutputsGoods_Weighting.Name = "grcOutputsGoods_Weighting";
            this.grcOutputsGoods_Weighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_Weighting.ToolTipText = "Весовой товар?";
            this.grcOutputsGoods_Weighting.Visible = false;
            this.grcOutputsGoods_Weighting.Width = 50;
            // 
            // grcOutputsGoods_GoodBarCode
            // 
            this.grcOutputsGoods_GoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_GoodBarCode.DataPropertyName = "GoodBarCode";
            this.grcOutputsGoods_GoodBarCode.HeaderText = "ШК товара";
            this.grcOutputsGoods_GoodBarCode.Name = "grcOutputsGoods_GoodBarCode";
            this.grcOutputsGoods_GoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_GoodBarCode.Visible = false;
            this.grcOutputsGoods_GoodBarCode.Width = 130;
            // 
            // grcOutputsGoods_GoodGroupName
            // 
            this.grcOutputsGoods_GoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_GoodGroupName.DataPropertyName = "GoodGroupName";
            this.grcOutputsGoods_GoodGroupName.HeaderText = "Товарная группа";
            this.grcOutputsGoods_GoodGroupName.Name = "grcOutputsGoods_GoodGroupName";
            this.grcOutputsGoods_GoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_GoodGroupName.Width = 150;
            // 
            // grcOutputsGoods_GoodBrandName
            // 
            this.grcOutputsGoods_GoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_GoodBrandName.DataPropertyName = "GoodBrandName";
            this.grcOutputsGoods_GoodBrandName.HeaderText = "Товарный бренд";
            this.grcOutputsGoods_GoodBrandName.Name = "grcOutputsGoods_GoodBrandName";
            this.grcOutputsGoods_GoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_GoodBrandName.Width = 150;
            // 
            // grcOutputsGoods_GoodStateName
            // 
            this.grcOutputsGoods_GoodStateName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_GoodStateName.DataPropertyName = "GoodStateName";
            this.grcOutputsGoods_GoodStateName.HeaderText = "Состояние";
            this.grcOutputsGoods_GoodStateName.Name = "grcOutputsGoods_GoodStateName";
            this.grcOutputsGoods_GoodStateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_GoodStateName.ToolTipText = "Состояние товара";
            this.grcOutputsGoods_GoodStateName.Width = 150;
            // 
            // grcOutputsGoods_PackingID
            // 
            this.grcOutputsGoods_PackingID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsGoods_PackingID.DataPropertyName = "PackingID";
            this.grcOutputsGoods_PackingID.HeaderText = "PackingID";
            this.grcOutputsGoods_PackingID.Name = "grcOutputsGoods_PackingID";
            this.grcOutputsGoods_PackingID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsGoods_PackingID.Visible = false;
            // 
            // pnlOutputDocumentGoods
            // 
            this.pnlOutputDocumentGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOutputDocumentGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOutputDocumentGoods.Controls.Add(this.lblOutputDocumentGoods);
            this.pnlOutputDocumentGoods.Controls.Add(this.btnReturnReason);
            this.pnlOutputDocumentGoods.Controls.Add(this.btnGoodsGultiesFill);
            this.pnlOutputDocumentGoods.Controls.Add(this.btnGoodsGultiesClear);
            this.pnlOutputDocumentGoods.Controls.Add(this.grdOutputsDocumentsGoods);
            this.pnlOutputDocumentGoods.Location = new System.Drawing.Point(3, 83);
            this.pnlOutputDocumentGoods.Name = "pnlOutputDocumentGoods";
            this.pnlOutputDocumentGoods.Size = new System.Drawing.Size(686, 250);
            this.pnlOutputDocumentGoods.TabIndex = 15;
            // 
            // lblOutputDocumentGoods
            // 
            this.lblOutputDocumentGoods.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutputDocumentGoods.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutputDocumentGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutputDocumentGoods.Location = new System.Drawing.Point(3, 3);
            this.lblOutputDocumentGoods.Name = "lblOutputDocumentGoods";
            this.lblOutputDocumentGoods.Size = new System.Drawing.Size(156, 14);
            this.lblOutputDocumentGoods.TabIndex = 18;
            this.lblOutputDocumentGoods.Text = "Для товаров в заказе:";
            // 
            // btnReturnReason
            // 
            this.btnReturnReason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturnReason.Image = global::Logistics.Properties.Resources.UnDo;
            this.btnReturnReason.Location = new System.Drawing.Point(649, 215);
            this.btnReturnReason.Name = "btnReturnReason";
            this.btnReturnReason.Size = new System.Drawing.Size(32, 30);
            this.btnReturnReason.TabIndex = 17;
            this.ttToolTip.SetToolTip(this.btnReturnReason, "Причина несоответствия отгруженного и доставленного количества");
            this.btnReturnReason.UseVisualStyleBackColor = true;
            this.btnReturnReason.Click += new System.EventHandler(this.btnReturnReason_Click);
            // 
            // btnGoodsGultiesFill
            // 
            this.btnGoodsGultiesFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoodsGultiesFill.FlatAppearance.BorderSize = 0;
            this.btnGoodsGultiesFill.Image = global::Logistics.Properties.Resources.Copy;
            this.btnGoodsGultiesFill.Location = new System.Drawing.Point(2, 215);
            this.btnGoodsGultiesFill.Name = "btnGoodsGultiesFill";
            this.btnGoodsGultiesFill.Size = new System.Drawing.Size(32, 30);
            this.btnGoodsGultiesFill.TabIndex = 16;
            this.ttToolTip.SetToolTip(this.btnGoodsGultiesFill, "Скопировать для всех товаров");
            this.btnGoodsGultiesFill.UseVisualStyleBackColor = true;
            this.btnGoodsGultiesFill.Click += new System.EventHandler(this.btnGoodsGultiesFill_Click);
            // 
            // btnGoodsGultiesClear
            // 
            this.btnGoodsGultiesClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGoodsGultiesClear.FlatAppearance.BorderSize = 0;
            this.btnGoodsGultiesClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnGoodsGultiesClear.Location = new System.Drawing.Point(52, 215);
            this.btnGoodsGultiesClear.Name = "btnGoodsGultiesClear";
            this.btnGoodsGultiesClear.Size = new System.Drawing.Size(32, 30);
            this.btnGoodsGultiesClear.TabIndex = 15;
            this.ttToolTip.SetToolTip(this.btnGoodsGultiesClear, "Очистить для всех товаров");
            this.btnGoodsGultiesClear.UseVisualStyleBackColor = true;
            this.btnGoodsGultiesClear.Click += new System.EventHandler(this.btnGoodsGultiesClear_Click);
            // 
            // chkIsDriverFoul
            // 
            this.chkIsDriverFoul.AutoSize = true;
            this.chkIsDriverFoul.Location = new System.Drawing.Point(182, 52);
            this.chkIsDriverFoul.Name = "chkIsDriverFoul";
            this.chkIsDriverFoul.Size = new System.Drawing.Size(134, 18);
            this.chkIsDriverFoul.TabIndex = 20;
            this.chkIsDriverFoul.Text = "виноват водитель?";
            this.chkIsDriverFoul.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkIsDriverFoul.UseVisualStyleBackColor = true;
            // 
            // frmOutputsDocumentsGuiltyEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 373);
            this.Controls.Add(this.pnlOutputDocumentGoods);
            this.Controls.Add(this.pnlOutputDocument);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 130);
            this.Name = "frmOutputsDocumentsGuiltyEmployees";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Причины и виновники проблем при доставке заказа";
            this.Load += new System.EventHandler(this.frmOutputsDocumentsGuiltyEmployees_Load);
            this.pnlOutputDocument.ResumeLayout(false);
            this.pnlOutputDocument.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutputsDocumentsGoods)).EndInit();
            this.pnlOutputDocumentGoods.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMTextBox txtGuiltyEmployees;
		private RFMBaseClasses.RFMButton btnGuiltyEmloyeeSelect;
		private RFMBaseClasses.RFMPanel pnlOutputDocument;
		private RFMBaseClasses.RFMDataGridView grdOutputsDocumentsGoods;
		private RFMBaseClasses.RFMCheckBox chkOneGuilty;
		private RFMBaseClasses.RFMLabel lblOutputDocument;
		private RFMBaseClasses.RFMPanel pnlOutputDocumentGoods;
		private RFMBaseClasses.RFMButton btnGoodsGultiesClear;
		private RFMBaseClasses.RFMButton btnGoodsGultiesFill;
		private RFMBaseClasses.RFMLabel lblOutputDocumentFailReason;
		private RFMBaseClasses.RFMComboBox cboOutputDocumentFailReason;
		private RFMBaseClasses.RFMLabel lblOutputDocumentGuiltyEmployees;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_GoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_QntWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_QntConfirmed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_QntBrought;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_QntDiff;
		private System.Windows.Forms.DataGridViewTextBoxColumn grcOutputsGoods_ReturnReasonName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_GuiltyEmployees;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_BoxWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_BoxConfirmed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_BoxBrought;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_BoxDiff;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_InBox;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcOutputsGoods_Weighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_GoodBarCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_GoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_GoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_GoodStateName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsGoods_PackingID;
		private RFMBaseClasses.RFMButton btnReturnReason;
		private RFMBaseClasses.RFMLabel lblOutputDocumentGoods;
        private RFMBaseClasses.RFMCheckBox chkIsDriverFoul;

	}
}

