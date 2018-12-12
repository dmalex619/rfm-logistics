namespace Logistics
{
	partial class frmTripsReturnsActsCreate
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
			this.dgvGoods = new RFMBaseClasses.RFMDataGridView();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.pnlSelectConditions = new RFMBaseClasses.RFMPanel();
			this.lblAct = new RFMBaseClasses.RFMLabel();
			this.chkActReadyForWMS = new RFMBaseClasses.RFMCheckBox();
			this.txtActNote = new RFMBaseClasses.RFMTextBox();
			this.lblReturn = new RFMBaseClasses.RFMLabel();
			this.cboGoodsState = new RFMBaseClasses.RFMComboBox();
			this.cboOwner = new RFMBaseClasses.RFMComboBox();
			this.chkReturnReadyForWMS = new RFMBaseClasses.RFMCheckBox();
			this.lblDate = new RFMBaseClasses.RFMLabel();
			this.lblGoodsStates = new RFMBaseClasses.RFMLabel();
			this.lblOwners = new RFMBaseClasses.RFMLabel();
			this.dtpDate = new RFMBaseClasses.RFMDateTimePicker();
			this.txtReturnNote = new RFMBaseClasses.RFMTextBox();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.pnlTotal = new RFMBaseClasses.RFMPanel();
			this.lblActTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblActTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblActTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblActTotalBox_ = new RFMBaseClasses.RFMLabel();
			this.lblTotalAct = new RFMBaseClasses.RFMLabel();
			this.lblTotal = new RFMBaseClasses.RFMLabel();
			this.lblReturnTotalQnt = new RFMBaseClasses.RFMLabel();
			this.lblReturnTotalQnt_ = new RFMBaseClasses.RFMLabel();
			this.lblReturnTotalBox = new RFMBaseClasses.RFMLabel();
			this.lblReturnTotalBox_ = new RFMBaseClasses.RFMLabel();
			this.lblReturnTotal = new RFMBaseClasses.RFMLabel();
			this.dgvcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcInBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcReturnBox = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcReturnQnt = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcActBox = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcActQnt = new RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn();
			this.dgvcOutputID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcOutputPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
			this.pnlSelectConditions.SuspendLayout();
			this.pnlTotal.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvGoods
			// 
			this.dgvGoods.AllowUserToAddRows = false;
			this.dgvGoods.AllowUserToDeleteRows = false;
			this.dgvGoods.AllowUserToOrderColumns = true;
			this.dgvGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGoods.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcGoodAlias,
            this.dgvcInBox,
            this.dgvcReturnBox,
            this.dgvcReturnQnt,
            this.dgvcActBox,
            this.dgvcActQnt,
            this.dgvcOutputID,
            this.dgvcOutputPartnerName,
            this.dgvcWeighting,
            this.dgvcGoodBarCode,
            this.dgvcGoodGroupName,
            this.dgvcGoodBrandName,
            this.dgvcID});
			this.dgvGoods.IsConfigInclude = true;
			this.dgvGoods.IsMarkedAll = false;
			this.dgvGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvGoods.Location = new System.Drawing.Point(3, 85);
			this.dgvGoods.MultiSelect = false;
			this.dgvGoods.Name = "dgvGoods";
			this.dgvGoods.RangedWay = ' ';
			this.dgvGoods.RowHeadersWidth = 24;
			this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgvGoods.Size = new System.Drawing.Size(736, 349);
			this.dgvGoods.TabIndex = 0;
			this.dgvGoods.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvGoods_CellBeginEdit);
			this.dgvGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGoods_CellFormatting);
			this.dgvGoods.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellEndEdit);
			this.dgvGoods.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellValueChanged);
			this.dgvGoods.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoods_CellEnter);
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
			this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// pnlSelectConditions
			// 
			this.pnlSelectConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlSelectConditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlSelectConditions.Controls.Add(this.lblAct);
			this.pnlSelectConditions.Controls.Add(this.chkActReadyForWMS);
			this.pnlSelectConditions.Controls.Add(this.txtActNote);
			this.pnlSelectConditions.Controls.Add(this.lblReturn);
			this.pnlSelectConditions.Controls.Add(this.cboGoodsState);
			this.pnlSelectConditions.Controls.Add(this.cboOwner);
			this.pnlSelectConditions.Controls.Add(this.chkReturnReadyForWMS);
			this.pnlSelectConditions.Controls.Add(this.lblDate);
			this.pnlSelectConditions.Controls.Add(this.lblGoodsStates);
			this.pnlSelectConditions.Controls.Add(this.lblOwners);
			this.pnlSelectConditions.Controls.Add(this.dtpDate);
			this.pnlSelectConditions.Controls.Add(this.txtReturnNote);
			this.pnlSelectConditions.Location = new System.Drawing.Point(3, 3);
			this.pnlSelectConditions.Name = "pnlSelectConditions";
			this.pnlSelectConditions.Size = new System.Drawing.Size(736, 79);
			this.pnlSelectConditions.TabIndex = 1;
			// 
			// lblAct
			// 
			this.lblAct.AutoSize = true;
			this.lblAct.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblAct.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblAct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblAct.Location = new System.Drawing.Point(4, 54);
			this.lblAct.Name = "lblAct";
			this.lblAct.Size = new System.Drawing.Size(31, 14);
			this.lblAct.TabIndex = 43;
			this.lblAct.Text = "Акт:";
			// 
			// chkActReadyForWMS
			// 
			this.chkActReadyForWMS.AutoSize = true;
			this.chkActReadyForWMS.Location = new System.Drawing.Point(63, 53);
			this.chkActReadyForWMS.Name = "chkActReadyForWMS";
			this.chkActReadyForWMS.Size = new System.Drawing.Size(249, 18);
			this.chkActReadyForWMS.TabIndex = 42;
			this.chkActReadyForWMS.Text = "готов к передаче в складскую систему";
			this.chkActReadyForWMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkActReadyForWMS.UseVisualStyleBackColor = true;
			// 
			// txtActNote
			// 
			this.txtActNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtActNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtActNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtActNote.Location = new System.Drawing.Point(314, 51);
			this.txtActNote.MaxLength = 500;
			this.txtActNote.Name = "txtActNote";
			this.txtActNote.Size = new System.Drawing.Size(415, 22);
			this.txtActNote.TabIndex = 41;
			this.ttToolTip.SetToolTip(this.txtActNote, "Примечание для акта");
			// 
			// lblReturn
			// 
			this.lblReturn.AutoSize = true;
			this.lblReturn.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReturn.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReturn.Location = new System.Drawing.Point(4, 30);
			this.lblReturn.Name = "lblReturn";
			this.lblReturn.Size = new System.Drawing.Size(55, 14);
			this.lblReturn.TabIndex = 40;
			this.lblReturn.Text = "Возврат:";
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
			this.cboGoodsState.Location = new System.Drawing.Point(530, 3);
			this.cboGoodsState.Name = "cboGoodsState";
			this.cboGoodsState.Size = new System.Drawing.Size(200, 22);
			this.cboGoodsState.TabIndex = 38;
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
			this.cboOwner.Location = new System.Drawing.Point(208, 3);
			this.cboOwner.Name = "cboOwner";
			this.cboOwner.Size = new System.Drawing.Size(200, 22);
			this.cboOwner.TabIndex = 37;
			// 
			// chkReturnReadyForWMS
			// 
			this.chkReturnReadyForWMS.AutoSize = true;
			this.chkReturnReadyForWMS.Location = new System.Drawing.Point(63, 29);
			this.chkReturnReadyForWMS.Name = "chkReturnReadyForWMS";
			this.chkReturnReadyForWMS.Size = new System.Drawing.Size(249, 18);
			this.chkReturnReadyForWMS.TabIndex = 35;
			this.chkReturnReadyForWMS.Text = "готов к передаче в складскую систему";
			this.chkReturnReadyForWMS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkReturnReadyForWMS.UseVisualStyleBackColor = true;
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDate.Location = new System.Drawing.Point(4, 7);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(33, 14);
			this.lblDate.TabIndex = 29;
			this.lblDate.Text = "Дата";
			// 
			// lblGoodsStates
			// 
			this.lblGoodsStates.AutoSize = true;
			this.lblGoodsStates.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblGoodsStates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblGoodsStates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblGoodsStates.Location = new System.Drawing.Point(417, 7);
			this.lblGoodsStates.Name = "lblGoodsStates";
			this.lblGoodsStates.Size = new System.Drawing.Size(110, 14);
			this.lblGoodsStates.TabIndex = 26;
			this.lblGoodsStates.Text = "Состояние товара";
			// 
			// lblOwners
			// 
			this.lblOwners.AutoSize = true;
			this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblOwners.Location = new System.Drawing.Point(143, 7);
			this.lblOwners.Name = "lblOwners";
			this.lblOwners.Size = new System.Drawing.Size(62, 14);
			this.lblOwners.TabIndex = 25;
			this.lblOwners.Text = "Владелец";
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "dd.MM.yyyy";
			this.dtpDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(40, 3);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(92, 22);
			this.dtpDate.TabIndex = 4;
			// 
			// txtReturnNote
			// 
			this.txtReturnNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtReturnNote.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtReturnNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtReturnNote.Location = new System.Drawing.Point(314, 27);
			this.txtReturnNote.MaxLength = 500;
			this.txtReturnNote.Name = "txtReturnNote";
			this.txtReturnNote.Size = new System.Drawing.Size(415, 22);
			this.txtReturnNote.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.txtReturnNote, "Примечание для возврата");
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
			this.btnAdd.Location = new System.Drawing.Point(55, 439);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(32, 30);
			this.btnAdd.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnAdd, "Новый товар");
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// pnlTotal
			// 
			this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotal.Controls.Add(this.lblActTotalQnt);
			this.pnlTotal.Controls.Add(this.lblActTotalQnt_);
			this.pnlTotal.Controls.Add(this.lblActTotalBox);
			this.pnlTotal.Controls.Add(this.lblActTotalBox_);
			this.pnlTotal.Controls.Add(this.lblTotalAct);
			this.pnlTotal.Controls.Add(this.lblTotal);
			this.pnlTotal.Controls.Add(this.lblReturnTotalQnt);
			this.pnlTotal.Controls.Add(this.lblReturnTotalQnt_);
			this.pnlTotal.Controls.Add(this.lblReturnTotalBox);
			this.pnlTotal.Controls.Add(this.lblReturnTotalBox_);
			this.pnlTotal.Controls.Add(this.lblReturnTotal);
			this.pnlTotal.Location = new System.Drawing.Point(95, 441);
			this.pnlTotal.Name = "pnlTotal";
			this.pnlTotal.Size = new System.Drawing.Size(551, 26);
			this.pnlTotal.TabIndex = 11;
			// 
			// lblActTotalQnt
			// 
			this.lblActTotalQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblActTotalQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblActTotalQnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblActTotalQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblActTotalQnt.Location = new System.Drawing.Point(487, 4);
			this.lblActTotalQnt.Name = "lblActTotalQnt";
			this.lblActTotalQnt.Size = new System.Drawing.Size(60, 14);
			this.lblActTotalQnt.TabIndex = 12;
			this.lblActTotalQnt.Text = "#TotalQnt#";
			// 
			// lblActTotalQnt_
			// 
			this.lblActTotalQnt_.AutoSize = true;
			this.lblActTotalQnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblActTotalQnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblActTotalQnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblActTotalQnt_.Location = new System.Drawing.Point(452, 4);
			this.lblActTotalQnt_.Name = "lblActTotalQnt_";
			this.lblActTotalQnt_.Size = new System.Drawing.Size(33, 14);
			this.lblActTotalQnt_.TabIndex = 11;
			this.lblActTotalQnt_.Text = "штук";
			// 
			// lblActTotalBox
			// 
			this.lblActTotalBox.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblActTotalBox.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblActTotalBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblActTotalBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblActTotalBox.Location = new System.Drawing.Point(390, 4);
			this.lblActTotalBox.Name = "lblActTotalBox";
			this.lblActTotalBox.Size = new System.Drawing.Size(60, 14);
			this.lblActTotalBox.TabIndex = 10;
			this.lblActTotalBox.Text = "#TotalBox#";
			// 
			// lblActTotalBox_
			// 
			this.lblActTotalBox_.AutoSize = true;
			this.lblActTotalBox_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblActTotalBox_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblActTotalBox_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblActTotalBox_.Location = new System.Drawing.Point(358, 4);
			this.lblActTotalBox_.Name = "lblActTotalBox_";
			this.lblActTotalBox_.Size = new System.Drawing.Size(31, 14);
			this.lblActTotalBox_.TabIndex = 9;
			this.lblActTotalBox_.Text = "кор.";
			// 
			// lblTotalAct
			// 
			this.lblTotalAct.AutoSize = true;
			this.lblTotalAct.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTotalAct.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTotalAct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTotalAct.Location = new System.Drawing.Point(322, 4);
			this.lblTotalAct.Name = "lblTotalAct";
			this.lblTotalAct.Size = new System.Drawing.Size(34, 14);
			this.lblTotalAct.TabIndex = 8;
			this.lblTotalAct.Text = "АКТ:";
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
			this.lblTotal.Text = "Итого:";
			// 
			// lblReturnTotalQnt
			// 
			this.lblReturnTotalQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReturnTotalQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReturnTotalQnt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblReturnTotalQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReturnTotalQnt.Location = new System.Drawing.Point(244, 5);
			this.lblReturnTotalQnt.Name = "lblReturnTotalQnt";
			this.lblReturnTotalQnt.Size = new System.Drawing.Size(60, 14);
			this.lblReturnTotalQnt.TabIndex = 5;
			this.lblReturnTotalQnt.Text = "#TotalQnt#";
			// 
			// lblReturnTotalQnt_
			// 
			this.lblReturnTotalQnt_.AutoSize = true;
			this.lblReturnTotalQnt_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReturnTotalQnt_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReturnTotalQnt_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReturnTotalQnt_.Location = new System.Drawing.Point(209, 5);
			this.lblReturnTotalQnt_.Name = "lblReturnTotalQnt_";
			this.lblReturnTotalQnt_.Size = new System.Drawing.Size(33, 14);
			this.lblReturnTotalQnt_.TabIndex = 4;
			this.lblReturnTotalQnt_.Text = "штук";
			// 
			// lblReturnTotalBox
			// 
			this.lblReturnTotalBox.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReturnTotalBox.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReturnTotalBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblReturnTotalBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReturnTotalBox.Location = new System.Drawing.Point(147, 5);
			this.lblReturnTotalBox.Name = "lblReturnTotalBox";
			this.lblReturnTotalBox.Size = new System.Drawing.Size(60, 14);
			this.lblReturnTotalBox.TabIndex = 3;
			this.lblReturnTotalBox.Text = "#TotalBox#";
			// 
			// lblReturnTotalBox_
			// 
			this.lblReturnTotalBox_.AutoSize = true;
			this.lblReturnTotalBox_.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReturnTotalBox_.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReturnTotalBox_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReturnTotalBox_.Location = new System.Drawing.Point(115, 5);
			this.lblReturnTotalBox_.Name = "lblReturnTotalBox_";
			this.lblReturnTotalBox_.Size = new System.Drawing.Size(31, 14);
			this.lblReturnTotalBox_.TabIndex = 2;
			this.lblReturnTotalBox_.Text = "кор.";
			// 
			// lblReturnTotal
			// 
			this.lblReturnTotal.AutoSize = true;
			this.lblReturnTotal.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReturnTotal.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReturnTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReturnTotal.Location = new System.Drawing.Point(61, 5);
			this.lblReturnTotal.Name = "lblReturnTotal";
			this.lblReturnTotal.Size = new System.Drawing.Size(51, 14);
			this.lblReturnTotal.TabIndex = 7;
			this.lblReturnTotal.Text = "ВОЗВР.:";
			// 
			// dgvcGoodAlias
			// 
			this.dgvcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodAlias.DataPropertyName = "GoodAlias";
			this.dgvcGoodAlias.HeaderText = "Товар";
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
			this.dgvcInBox.HeaderText = "В кор.";
			this.dgvcInBox.Name = "dgvcInBox";
			this.dgvcInBox.ReadOnly = true;
			this.dgvcInBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcInBox.ToolTipText = "Штук/кг в коробке";
			this.dgvcInBox.Width = 60;
			// 
			// dgvcReturnBox
			// 
			this.dgvcReturnBox.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcReturnBox.DataPropertyName = "ReturnBox";
			this.dgvcReturnBox.DecimalPlaces = 1;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.Format = "N1";
			this.dgvcReturnBox.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvcReturnBox.HeaderText = "ВОЗВР.кор.";
			this.dgvcReturnBox.Name = "dgvcReturnBox";
			this.dgvcReturnBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcReturnBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcReturnBox.ToolTipText = "Коробок к возврату";
			this.dgvcReturnBox.Width = 80;
			// 
			// dgvcReturnQnt
			// 
			this.dgvcReturnQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcReturnQnt.DataPropertyName = "ReturnQnt";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle4.Format = "N0";
			this.dgvcReturnQnt.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvcReturnQnt.HeaderText = "ВОЗВР.шт.";
			this.dgvcReturnQnt.Name = "dgvcReturnQnt";
			this.dgvcReturnQnt.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcReturnQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcReturnQnt.ToolTipText = "Штук к возврату";
			this.dgvcReturnQnt.Width = 80;
			// 
			// dgvcActBox
			// 
			this.dgvcActBox.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcActBox.DataPropertyName = "ActBox";
			this.dgvcActBox.DecimalPlaces = 1;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle5.Format = "N1";
			this.dgvcActBox.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvcActBox.HeaderText = "АКТ кор.";
			this.dgvcActBox.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
			this.dgvcActBox.Name = "dgvcActBox";
			this.dgvcActBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcActBox.ToolTipText = "Коробок для акта";
			this.dgvcActBox.Width = 80;
			// 
			// dgvcActQnt
			// 
			this.dgvcActQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcActQnt.DataPropertyName = "ActQnt";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle6.Format = "N0";
			this.dgvcActQnt.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvcActQnt.HeaderText = "АКТ шт.";
			this.dgvcActQnt.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
			this.dgvcActQnt.Name = "dgvcActQnt";
			this.dgvcActQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcActQnt.ToolTipText = "Штук для акта";
			this.dgvcActQnt.Width = 80;
			// 
			// dgvcOutputID
			// 
			this.dgvcOutputID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcOutputID.DataPropertyName = "OutputID";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcOutputID.DefaultCellStyle = dataGridViewCellStyle7;
			this.dgvcOutputID.HeaderText = "Расход";
			this.dgvcOutputID.Name = "dgvcOutputID";
			this.dgvcOutputID.ReadOnly = true;
			this.dgvcOutputID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcOutputID.ToolTipText = "Код задания на расход";
			this.dgvcOutputID.Width = 60;
			// 
			// dgvcOutputPartnerName
			// 
			this.dgvcOutputPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcOutputPartnerName.DataPropertyName = "OutputPartnerName";
			this.dgvcOutputPartnerName.HeaderText = "Получатель";
			this.dgvcOutputPartnerName.Name = "dgvcOutputPartnerName";
			this.dgvcOutputPartnerName.ReadOnly = true;
			this.dgvcOutputPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcOutputPartnerName.ToolTipText = "Получатель товара по заданию на расход";
			this.dgvcOutputPartnerName.Width = 200;
			// 
			// dgvcWeighting
			// 
			this.dgvcWeighting.DataPropertyName = "Weighting";
			this.dgvcWeighting.HeaderText = "Вес?";
			this.dgvcWeighting.Name = "dgvcWeighting";
			this.dgvcWeighting.ReadOnly = true;
			this.dgvcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcWeighting.ToolTipText = "Весовой товар?";
			this.dgvcWeighting.Visible = false;
			this.dgvcWeighting.Width = 40;
			// 
			// dgvcGoodBarCode
			// 
			this.dgvcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBarCode.DataPropertyName = "GoodBarCode";
			this.dgvcGoodBarCode.HeaderText = "ШК товара";
			this.dgvcGoodBarCode.Name = "dgvcGoodBarCode";
			this.dgvcGoodBarCode.ReadOnly = true;
			this.dgvcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBarCode.ToolTipText = "Штрих-код товара";
			this.dgvcGoodBarCode.Visible = false;
			this.dgvcGoodBarCode.Width = 130;
			// 
			// dgvcGoodGroupName
			// 
			this.dgvcGoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodGroupName.DataPropertyName = "GoodGroupName";
			this.dgvcGoodGroupName.HeaderText = "Товарная группа";
			this.dgvcGoodGroupName.Name = "dgvcGoodGroupName";
			this.dgvcGoodGroupName.ReadOnly = true;
			this.dgvcGoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodGroupName.Width = 200;
			// 
			// dgvcGoodBrandName
			// 
			this.dgvcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGoodBrandName.DataPropertyName = "GoodBrandName";
			this.dgvcGoodBrandName.HeaderText = "Товарный бренд";
			this.dgvcGoodBrandName.Name = "dgvcGoodBrandName";
			this.dgvcGoodBrandName.ReadOnly = true;
			this.dgvcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGoodBrandName.Width = 200;
			// 
			// dgvcID
			// 
			this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcID.DataPropertyName = "ID";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcID.DefaultCellStyle = dataGridViewCellStyle8;
			this.dgvcID.HeaderText = "ID";
			this.dgvcID.Name = "dgvcID";
			this.dgvcID.ReadOnly = true;
			this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcID.Visible = false;
			this.dgvcID.Width = 60;
			// 
			// frmTripsReturnsActsCreate
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
			this.Controls.Add(this.dgvGoods);
			this.hpHelp.SetHelpKeyword(this, "221");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmTripsReturnsActsCreate";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Возврат / Акт";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTripsReturnsActsCreate_KeyDown);
			this.Load += new System.EventHandler(this.frmTripsReturnsActsCreate_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
			this.pnlSelectConditions.ResumeLayout(false);
			this.pnlSelectConditions.PerformLayout();
			this.pnlTotal.ResumeLayout(false);
			this.pnlTotal.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvGoods;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlSelectConditions;
		private RFMBaseClasses.RFMTextBox txtReturnNote;
		private RFMBaseClasses.RFMButton btnAdd;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblTotal;
		private RFMBaseClasses.RFMLabel lblReturnTotalQnt;
		private RFMBaseClasses.RFMLabel lblReturnTotalQnt_;
		private RFMBaseClasses.RFMLabel lblReturnTotalBox;
		private RFMBaseClasses.RFMLabel lblReturnTotalBox_;
        private RFMBaseClasses.RFMDateTimePicker dtpDate;
        private RFMBaseClasses.RFMLabel lblGoodsStates;
        private RFMBaseClasses.RFMLabel lblOwners;
        private RFMBaseClasses.RFMLabel lblDate;
        private RFMBaseClasses.RFMCheckBox chkReturnReadyForWMS;
        private RFMBaseClasses.RFMComboBox cboOwner;
		private RFMBaseClasses.RFMComboBox cboGoodsState;
		private RFMBaseClasses.RFMLabel lblAct;
		private RFMBaseClasses.RFMCheckBox chkActReadyForWMS;
		private RFMBaseClasses.RFMTextBox txtActNote;
		private RFMBaseClasses.RFMLabel lblReturn;
		private RFMBaseClasses.RFMLabel lblActTotalQnt;
		private RFMBaseClasses.RFMLabel lblActTotalQnt_;
		private RFMBaseClasses.RFMLabel lblActTotalBox;
		private RFMBaseClasses.RFMLabel lblActTotalBox_;
		private RFMBaseClasses.RFMLabel lblTotalAct;
		private RFMBaseClasses.RFMLabel lblReturnTotal;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcInBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcReturnBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcReturnQnt;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcActBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxNumericColumn dgvcActQnt;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcOutputID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcOutputPartnerName;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcWeighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBarCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
	}
}

