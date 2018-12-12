namespace Logistics
{
	partial class frmActsEdit
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
			this.dgvActGoods = new RFMBaseClasses.RFMDataGridView();
			this.dgvcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcInBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcBoxConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcQntConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlSelectConditions = new RFMBaseClasses.RFMPanel();
			this.chkReadyForWMS = new RFMBaseClasses.RFMCheckBox();
			this.chkInput = new RFMBaseClasses.RFMCheckBox();
			this.txtInputID = new RFMBaseClasses.RFMTextBox();
			this.chkOutput = new RFMBaseClasses.RFMCheckBox();
			this.lblDateAct = new RFMBaseClasses.RFMLabel();
			this.txtOutputID = new RFMBaseClasses.RFMTextBox();
			this.lblGoodsStates = new RFMBaseClasses.RFMLabel();
			this.lblOwners = new RFMBaseClasses.RFMLabel();
			this.dtpDateAct = new RFMBaseClasses.RFMDateTimePicker();
			this.lblNote = new RFMBaseClasses.RFMLabel();
			this.txtNote = new RFMBaseClasses.RFMTextBox();
			this.cboGoodsState = new RFMBaseClasses.RFMComboBox();
			this.txtGoodStateName = new RFMBaseClasses.RFMTextBox();
			this.cboOwner = new RFMBaseClasses.RFMComboBox();
			this.txtOwnerName = new RFMBaseClasses.RFMTextBox();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblTotal = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblTotalBox_ = new RFMBaseClasses.RFMLabel();
			((System.ComponentModel.ISupportInitialize)(this.dgvActGoods)).BeginInit();
			this.pnlSelectConditions.SuspendLayout();
			this.pnlTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvActGoods
			// 
			this.dgvActGoods.AllowUserToAddRows = false;
			this.dgvActGoods.AllowUserToDeleteRows = false;
			this.dgvActGoods.AllowUserToOrderColumns = true;
			this.dgvActGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvActGoods.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvActGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvActGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvActGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvActGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcGoodAlias,
            this.dgvcInBox,
            this.dgvcBoxConfirmed,
            this.dgvcQntConfirmed,
            this.dgvcWeighting,
            this.dgvcGoodBarCode,
            this.dgvcGoodGroupName,
            this.dgvcGoodBrandName,
            this.dgvcID});
			this.dgvActGoods.IsConfigInclude = true;
			this.dgvActGoods.IsMarkedAll = false;
			this.dgvActGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvActGoods.Location = new System.Drawing.Point(2, 115);
			this.dgvActGoods.MultiSelect = false;
			this.dgvActGoods.Name = "dgvActGoods";
			this.dgvActGoods.RangedWay = ' ';
			this.dgvActGoods.RowHeadersWidth = 24;
			this.dgvActGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvActGoods.Size = new System.Drawing.Size(737, 319);
			this.dgvActGoods.TabIndex = 0;
			this.dgvActGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvActGoods_CellBeginEdit);
			this.dgvActGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActGoods_CellFormatting);
			this.dgvActGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActGoods_CellEndEdit);
			this.dgvActGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvActGoods_CellValueChanged);
			// 
			// dgvcGoodAlias
			// 
			this.dgvcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodAlias.DataPropertyName = "GoodAlias";
			this.dgvcGoodAlias.HeaderText = "�����";
			this.dgvcGoodAlias.Name = "dgvcGoodAlias";
			this.dgvcGoodAlias.ReadOnly = true;
			this.dgvcGoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodAlias.Width = 270;
			// 
			// dgvcInBox
			// 
			this.dgvcInBox.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcInBox.DataPropertyName = "InBox";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "N0";
			this.dgvcInBox.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvcInBox.HeaderText = "� ���.";
			this.dgvcInBox.Name = "dgvcInBox";
			this.dgvcInBox.ReadOnly = true;
			this.dgvcInBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcInBox.ToolTipText = "����/�� � �������";
			this.dgvcInBox.Width = 50;
			// 
			// dgvcBoxConfirmed
			// 
			this.dgvcBoxConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcBoxConfirmed.DataPropertyName = "BoxConfirmed";
			this.dgvcBoxConfirmed.DecimalPlaces = 1;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N1";
			this.dgvcBoxConfirmed.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvcBoxConfirmed.HeaderText = "�������";
			this.dgvcBoxConfirmed.Name = "dgvcBoxConfirmed";
			this.dgvcBoxConfirmed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcBoxConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcBoxConfirmed.ToolTipText = "�������";
			this.dgvcBoxConfirmed.Width = 80;
			// 
			// dgvcQntConfirmed
			// 
			this.dgvcQntConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcQntConfirmed.DataPropertyName = "QntConfirmed";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			this.dgvcQntConfirmed.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvcQntConfirmed.HeaderText = "����";
			this.dgvcQntConfirmed.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.dgvcQntConfirmed.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
			this.dgvcQntConfirmed.Name = "dgvcQntConfirmed";
			this.dgvcQntConfirmed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcQntConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcQntConfirmed.ToolTipText = "����";
			this.dgvcQntConfirmed.Width = 90;
			// 
			// dgvcWeighting
			// 
			this.dgvcWeighting.DataPropertyName = "Weighting";
			this.dgvcWeighting.HeaderText = "���?";
			this.dgvcWeighting.Name = "dgvcWeighting";
			this.dgvcWeighting.ReadOnly = true;
			this.dgvcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcWeighting.ToolTipText = "������� �����?";
			this.dgvcWeighting.Visible = false;
			this.dgvcWeighting.Width = 40;
			// 
			// dgvcGoodBarCode
			// 
			this.dgvcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBarCode.DataPropertyName = "GoodBarCode";
			this.dgvcGoodBarCode.HeaderText = "�� ������";
			this.dgvcGoodBarCode.Name = "dgvcGoodBarCode";
			this.dgvcGoodBarCode.ReadOnly = true;
			this.dgvcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBarCode.ToolTipText = "�����-��� ������";
			this.dgvcGoodBarCode.Visible = false;
			this.dgvcGoodBarCode.Width = 130;
			// 
			// dgvcGoodGroupName
			// 
			this.dgvcGoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodGroupName.DataPropertyName = "GoodGroupName";
			this.dgvcGoodGroupName.HeaderText = "�������� ������";
			this.dgvcGoodGroupName.Name = "dgvcGoodGroupName";
			this.dgvcGoodGroupName.ReadOnly = true;
			this.dgvcGoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodGroupName.Width = 150;
			// 
			// dgvcGoodBrandName
			// 
			this.dgvcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBrandName.DataPropertyName = "GoodBrandName";
			this.dgvcGoodBrandName.HeaderText = "�������� �����";
			this.dgvcGoodBrandName.Name = "dgvcGoodBrandName";
			this.dgvcGoodBrandName.ReadOnly = true;
			this.dgvcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBrandName.Width = 150;
			// 
			// dgvcID
			// 
			this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcID.DataPropertyName = "InputDocumentGoodID";
			this.dgvcID.HeaderText = "ID";
			this.dgvcID.Name = "dgvcID";
			this.dgvcID.ReadOnly = true;
			this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(5, 439);
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
			this.btnExit.Location = new System.Drawing.Point(705, 439);
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
			this.btnSave.Location = new System.Drawing.Point(655, 439);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 30);
			this.btnSave.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.btnSave, "���������");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlSelectConditions
			// 
			this.pnlSelectConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectConditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlSelectConditions.Controls.Add(this.chkReadyForWMS);
			this.pnlSelectConditions.Controls.Add(this.chkInput);
			this.pnlSelectConditions.Controls.Add(this.txtInputID);
			this.pnlSelectConditions.Controls.Add(this.chkOutput);
			this.pnlSelectConditions.Controls.Add(this.lblDateAct);
			this.pnlSelectConditions.Controls.Add(this.txtOutputID);
			this.pnlSelectConditions.Controls.Add(this.lblGoodsStates);
			this.pnlSelectConditions.Controls.Add(this.lblOwners);
			this.pnlSelectConditions.Controls.Add(this.dtpDateAct);
			this.pnlSelectConditions.Controls.Add(this.lblNote);
			this.pnlSelectConditions.Controls.Add(this.txtNote);
			this.pnlSelectConditions.Controls.Add(this.cboGoodsState);
			this.pnlSelectConditions.Controls.Add(this.txtGoodStateName);
			this.pnlSelectConditions.Controls.Add(this.cboOwner);
			this.pnlSelectConditions.Controls.Add(this.txtOwnerName);
			this.pnlSelectConditions.Location = new System.Drawing.Point(2, 4);
			this.pnlSelectConditions.Name = "pnlSelectConditions";
			this.pnlSelectConditions.Size = new System.Drawing.Size(737, 108);
			this.pnlSelectConditions.TabIndex = 1;
			// 
			// chkReadyForWMS
			// 
			this.chkReadyForWMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkReadyForWMS.AutoSize = true;
			this.chkReadyForWMS.Checked = true;
			this.chkReadyForWMS.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkReadyForWMS.Location = new System.Drawing.Point(460, 4);
			this.chkReadyForWMS.Name = "chkReadyForWMS";
			this.chkReadyForWMS.Size = new System.Drawing.Size(273, 18);
			this.chkReadyForWMS.TabIndex = 2;
			this.chkReadyForWMS.Text = "��� ����� � �������� � ��������� �������";
			this.chkReadyForWMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkReadyForWMS.UseVisualStyleBackColor = true;
			// 
			// chkInput
			// 
			this.chkInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkInput.AutoSize = true;
			this.chkInput.Enabled = false;
			this.chkInput.Location = new System.Drawing.Point(566, 32);
			this.chkInput.Name = "chkInput";
			this.chkInput.Size = new System.Drawing.Size(68, 18);
			this.chkInput.TabIndex = 7;
			this.chkInput.Text = "������";
			this.chkInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkInput.UseVisualStyleBackColor = true;
			// 
			// txtInputID
			// 
			this.txtInputID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtInputID.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtInputID.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtInputID.IsUserDraw = true;
			this.txtInputID.Location = new System.Drawing.Point(638, 30);
			this.txtInputID.Name = "txtInputID";
			this.txtInputID.ReadOnly = true;
			this.txtInputID.Size = new System.Drawing.Size(90, 22);
			this.txtInputID.TabIndex = 8;
			// 
			// chkOutput
			// 
			this.chkOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkOutput.AutoSize = true;
			this.chkOutput.Enabled = false;
			this.chkOutput.Location = new System.Drawing.Point(566, 57);
			this.chkOutput.Name = "chkOutput";
			this.chkOutput.Size = new System.Drawing.Size(65, 18);
			this.chkOutput.TabIndex = 9;
			this.chkOutput.Text = "������";
			this.chkOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkOutput.UseVisualStyleBackColor = true;
			// 
			// lblDateAct
			// 
			this.lblDateAct.AutoSize = true;
			this.lblDateAct.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateAct.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateAct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateAct.Location = new System.Drawing.Point(6, 8);
			this.lblDateAct.Name = "lblDateAct";
			this.lblDateAct.Size = new System.Drawing.Size(61, 14);
			this.lblDateAct.TabIndex = 0;
			this.lblDateAct.Text = "���� ����";
			// 
			// txtOutputID
			// 
			this.txtOutputID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutputID.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtOutputID.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOutputID.IsUserDraw = true;
			this.txtOutputID.Location = new System.Drawing.Point(638, 55);
			this.txtOutputID.Name = "txtOutputID";
			this.txtOutputID.ReadOnly = true;
			this.txtOutputID.Size = new System.Drawing.Size(90, 22);
			this.txtOutputID.TabIndex = 10;
			// 
			// lblGoodsStates
			// 
			this.lblGoodsStates.AutoSize = true;
			this.lblGoodsStates.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodsStates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodsStates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodsStates.Location = new System.Drawing.Point(6, 58);
			this.lblGoodsStates.Name = "lblGoodsStates";
			this.lblGoodsStates.Size = new System.Drawing.Size(68, 14);
			this.lblGoodsStates.TabIndex = 5;
			this.lblGoodsStates.Text = "���������";
			// 
			// lblOwners
			// 
			this.lblOwners.AutoSize = true;
			this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwners.Location = new System.Drawing.Point(6, 33);
			this.lblOwners.Name = "lblOwners";
			this.lblOwners.Size = new System.Drawing.Size(62, 14);
			this.lblOwners.TabIndex = 3;
			this.lblOwners.Text = "��������";
			// 
			// dtpDateAct
			// 
			this.dtpDateAct.CustomFormat = "dd.MM.yyyy";
			this.dtpDateAct.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateAct.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateAct.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateAct.Location = new System.Drawing.Point(91, 4);
			this.dtpDateAct.Name = "dtpDateAct";
			this.dtpDateAct.Size = new System.Drawing.Size(92, 22);
			this.dtpDateAct.TabIndex = 1;
			// 
			// lblNote
			// 
			this.lblNote.AutoSize = true;
			this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNote.Location = new System.Drawing.Point(6, 82);
			this.lblNote.Name = "lblNote";
			this.lblNote.Size = new System.Drawing.Size(78, 14);
			this.lblNote.TabIndex = 11;
			this.lblNote.Text = "����������";
			// 
			// txtNote
			// 
			this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNote.Location = new System.Drawing.Point(91, 79);
			this.txtNote.MaxLength = 500;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(637, 22);
			this.txtNote.TabIndex = 12;
			this.ttToolTip.SetToolTip(this.txtNote, "���������� �� ������");
			// 
			// cboGoodsState
			// 
			this.cboGoodsState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboGoodsState.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboGoodsState.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboGoodsState.FormattingEnabled = true;
			this.cboGoodsState.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboGoodsState.Location = new System.Drawing.Point(91, 54);
			this.cboGoodsState.Name = "cboGoodsState";
			this.cboGoodsState.Size = new System.Drawing.Size(243, 22);
			this.cboGoodsState.TabIndex = 6;
			// 
			// txtGoodStateName
			// 
			this.txtGoodStateName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtGoodStateName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtGoodStateName.Location = new System.Drawing.Point(91, 54);
			this.txtGoodStateName.Name = "txtGoodStateName";
			this.txtGoodStateName.ReadOnly = true;
			this.txtGoodStateName.Size = new System.Drawing.Size(242, 22);
			this.txtGoodStateName.TabIndex = 36;
			this.txtGoodStateName.Visible = false;
			// 
			// cboOwner
			// 
			this.cboOwner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cboOwner.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.cboOwner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.cboOwner.FormattingEnabled = true;
			this.cboOwner.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.cboOwner.Location = new System.Drawing.Point(91, 29);
			this.cboOwner.Name = "cboOwner";
			this.cboOwner.Size = new System.Drawing.Size(243, 22);
			this.cboOwner.TabIndex = 4;
			// 
			// txtOwnerName
			// 
			this.txtOwnerName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtOwnerName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtOwnerName.Location = new System.Drawing.Point(91, 29);
			this.txtOwnerName.Name = "txtOwnerName";
			this.txtOwnerName.ReadOnly = true;
			this.txtOwnerName.Size = new System.Drawing.Size(242, 22);
			this.txtOwnerName.TabIndex = 5;
			this.txtOwnerName.Visible = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
			this.btnAdd.Location = new System.Drawing.Point(55, 439);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(32, 30);
			this.btnAdd.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnAdd, "����� �����");
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlTotal
			// 
			this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotal.Controls.Add(this.lblTotal);
			this.pnlTotal.Controls.Add(this.lblTotalQnt);
			this.pnlTotal.Controls.Add(this.lblTotalQnt_);
			this.pnlTotal.Controls.Add(this.lblTotalBox);
			this.pnlTotal.Controls.Add(this.lblTotalBox_);
			this.pnlTotal.Location = new System.Drawing.Point(210, 442);
			this.pnlTotal.Name = "pnlTotal";
			this.pnlTotal.Size = new System.Drawing.Size(311, 26);
			this.pnlTotal.TabIndex = 11;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotal.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotal.Location = new System.Drawing.Point(2, 5);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(44, 14);
			this.lblTotal.TabIndex = 6;
			this.lblTotal.Text = "�����:";
			// 
			// lblTotalQnt
			// 
			this.lblTotalQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalQnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalQnt.Location = new System.Drawing.Point(215, 5);
			this.lblTotalQnt.Name = "lblTotalQnt";
			this.lblTotalQnt.Size = new System.Drawing.Size(89, 14);
			this.lblTotalQnt.TabIndex = 5;
			this.lblTotalQnt.Text = "#TotalQnt#";
			// 
			// lblTotalQnt_
			// 
			this.lblTotalQnt_.AutoSize = true;
			this.lblTotalQnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalQnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalQnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalQnt_.Location = new System.Drawing.Point(177, 5);
			this.lblTotalQnt_.Name = "lblTotalQnt_";
			this.lblTotalQnt_.Size = new System.Drawing.Size(33, 14);
			this.lblTotalQnt_.TabIndex = 4;
			this.lblTotalQnt_.Text = "����";
			// 
			// lblTotalBox
			// 
			this.lblTotalBox.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalBox.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblTotalBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalBox.Location = new System.Drawing.Point(83, 5);
			this.lblTotalBox.Name = "lblTotalBox";
			this.lblTotalBox.Size = new System.Drawing.Size(89, 14);
			this.lblTotalBox.TabIndex = 3;
			this.lblTotalBox.Text = "#TotalBox#";
			// 
			// lblTotalBox_
			// 
			this.lblTotalBox_.AutoSize = true;
			this.lblTotalBox_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalBox_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalBox_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalBox_.Location = new System.Drawing.Point(47, 5);
			this.lblTotalBox_.Name = "lblTotalBox_";
			this.lblTotalBox_.Size = new System.Drawing.Size(31, 14);
			this.lblTotalBox_.TabIndex = 2;
			this.lblTotalBox_.Text = "���.";
			// 
			// frmActsEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 473);
			this.Controls.Add(this.pnlTotal);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.pnlSelectConditions);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.dgvActGoods);
			this.hpHelp.SetHelpKeyword(this, "221");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmActsEdit";
			this.PreFormName = "frmGetHost";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "���";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmActsEdit_KeyDown);
			this.Load += new System.EventHandler(this.frmActsEdit_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvActGoods)).EndInit();
			this.pnlSelectConditions.ResumeLayout(false);
			this.pnlSelectConditions.PerformLayout();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvActGoods;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlSelectConditions;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblTotal;
		private RFMBaseClasses.RFMLabel lblTotalQnt;
		private RFMBaseClasses.RFMLabel lblTotalQnt_;
		private RFMBaseClasses.RFMLabel lblTotalBox;
		private RFMBaseClasses.RFMLabel lblTotalBox_;
        private RFMBaseClasses.RFMDateTimePicker dtpDateAct;
        private RFMBaseClasses.RFMTextBox txtOutputID;
        private RFMBaseClasses.RFMLabel lblGoodsStates;
        private RFMBaseClasses.RFMTextBox txtOwnerName;
        private RFMBaseClasses.RFMLabel lblOwners;
        private RFMBaseClasses.RFMLabel lblDateAct;
		private RFMBaseClasses.RFMCheckBox chkOutput;
        private RFMBaseClasses.RFMCheckBox chkInput;
        private RFMBaseClasses.RFMTextBox txtInputID;
		private RFMBaseClasses.RFMCheckBox chkReadyForWMS;
		private RFMBaseClasses.RFMTextBox txtGoodStateName;
        private RFMBaseClasses.RFMComboBox cboOwner;
		private RFMBaseClasses.RFMComboBox cboGoodsState;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcInBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcBoxConfirmed;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcQntConfirmed;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcWeighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBarCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
	}
}

