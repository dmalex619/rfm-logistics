namespace Logistics
{
	partial class frmCarsTasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarsTasks));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcList = new RFMBaseClasses.RFMTabControl();
            this.tabTerms = new RFMBaseClasses.RFMTabPage();
            this.cntTerms = new RFMBaseClasses.RFMPanel();
            this.btnClearTerms = new RFMBaseClasses.RFMButton();
            this.ucSelectRecordID_Owners = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.lblTripExists = new RFMBaseClasses.RFMLabel();
            this.rfmPanel1 = new RFMBaseClasses.RFMPanel();
            this.optTripExistsAll = new RFMBaseClasses.RFMRadioButton();
            this.optTripExistsNot = new RFMBaseClasses.RFMRadioButton();
            this.optTripExists = new RFMBaseClasses.RFMRadioButton();
            this.lblIsConfirmed = new RFMBaseClasses.RFMLabel();
            this.pnlIsConfirmed = new RFMBaseClasses.RFMPanel();
            this.optIsConfirmedNot = new RFMBaseClasses.RFMRadioButton();
            this.optIsConfirmed = new RFMBaseClasses.RFMRadioButton();
            this.optIsConfirmedAll = new RFMBaseClasses.RFMRadioButton();
            this.lblOwners = new RFMBaseClasses.RFMLabel();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.lblDateCarTask = new RFMBaseClasses.RFMLabel();
            this.tabData = new RFMBaseClasses.RFMTabPage();
            this.dgvCarsTasks = new RFMBaseClasses.RFMDataGridView();
            this.btnConfirm = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.btnCancel = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.tmrRestore = new RFMBaseClasses.RFMTimer();
            this.btnCopy = new RFMBaseClasses.RFMButton();
            this.dgvcConfirmedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.dgvcDateAct = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcOwnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTripAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcInputID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcOutputID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcPalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcNote = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTaskInnerCost = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTaskOuterCost = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcCarTaskUnitName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcUnitsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcPrice = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTaskAmount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcReadyForWMS = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.dgvcGoodStateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcDateConfirm = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcUserConfirmName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcUserCreateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tcList.SuspendLayout();
            this.tabTerms.SuspendLayout();
            this.cntTerms.SuspendLayout();
            this.ucSelectRecordID_Owners.SuspendLayout();
            this.rfmPanel1.SuspendLayout();
            this.pnlIsConfirmed.SuspendLayout();
            this.dtrDates.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // tcList
            // 
            this.tcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcList.Controls.Add(this.tabTerms);
            this.tcList.Controls.Add(this.tabData);
            this.tcList.Location = new System.Drawing.Point(1, 1);
            this.tcList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tcList.Name = "tcList";
            this.tcList.SelectedIndex = 0;
            this.tcList.Size = new System.Drawing.Size(847, 553);
            this.tcList.TabIndex = 0;
            this.tcList.SelectedIndexChanged += new System.EventHandler(this.tcList_SelectedIndexChanged);
            // 
            // tabTerms
            // 
            this.tabTerms.Controls.Add(this.cntTerms);
            this.tabTerms.IsFilterPage = true;
            this.tabTerms.Location = new System.Drawing.Point(4, 27);
            this.tabTerms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTerms.Name = "tabTerms";
            this.tabTerms.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabTerms.Size = new System.Drawing.Size(839, 522);
            this.tabTerms.TabIndex = 0;
            this.tabTerms.Text = "Условия";
            this.tabTerms.UseVisualStyleBackColor = true;
            // 
            // cntTerms
            // 
            this.cntTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntTerms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cntTerms.Controls.Add(this.btnClearTerms);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_Owners);
            this.cntTerms.Controls.Add(this.lblTripExists);
            this.cntTerms.Controls.Add(this.rfmPanel1);
            this.cntTerms.Controls.Add(this.lblIsConfirmed);
            this.cntTerms.Controls.Add(this.pnlIsConfirmed);
            this.cntTerms.Controls.Add(this.lblOwners);
            this.cntTerms.Controls.Add(this.dtrDates);
            this.cntTerms.Controls.Add(this.lblDateCarTask);
            this.cntTerms.Location = new System.Drawing.Point(0, 3);
            this.cntTerms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cntTerms.Name = "cntTerms";
            this.cntTerms.Size = new System.Drawing.Size(836, 513);
            this.cntTerms.TabIndex = 0;
            // 
            // btnClearTerms
            // 
            this.btnClearTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTerms.FlatAppearance.BorderSize = 0;
            this.btnClearTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTerms.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClearTerms.Location = new System.Drawing.Point(799, 477);
            this.btnClearTerms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearTerms.Name = "btnClearTerms";
            this.btnClearTerms.Size = new System.Drawing.Size(25, 28);
            this.btnClearTerms.TabIndex = 19;
            this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
            this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
            // 
            // ucSelectRecordID_Owners
            // 
            // 
            // ucSelectRecordID_Owners.btnClear
            // 
            this.ucSelectRecordID_Owners.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Owners.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Owners.btnClear.Image")));
            this.ucSelectRecordID_Owners.BtnClear.Location = new System.Drawing.Point(248, 4);
            this.ucSelectRecordID_Owners.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_Owners.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Owners.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Owners.BtnClear, "Очистка выбора владельца");
            this.ucSelectRecordID_Owners.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_Owners.btnSelect
            // 
            this.ucSelectRecordID_Owners.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Owners.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Owners.btnSelect.Image")));
            this.ucSelectRecordID_Owners.BtnSelect.Location = new System.Drawing.Point(222, 4);
            this.ucSelectRecordID_Owners.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_Owners.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Owners.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Owners.BtnSelect, "Выбор владельца");
            this.ucSelectRecordID_Owners.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_Owners.ExpSort = "Name";
            this.ucSelectRecordID_Owners.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_Owners.IsActualOnly = true;
            this.ucSelectRecordID_Owners.IsSaveMark = true;
            this.ucSelectRecordID_Owners.IsUseMark = true;
            this.ucSelectRecordID_Owners.Location = new System.Drawing.Point(206, 139);
            this.ucSelectRecordID_Owners.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucSelectRecordID_Owners.MarkedCount = 0;
            this.ucSelectRecordID_Owners.Name = "ucSelectRecordID_Owners";
            this.ucSelectRecordID_Owners.Size = new System.Drawing.Size(314, 41);
            this.ucSelectRecordID_Owners.TabIndex = 12;
            this.ucSelectRecordID_Owners.TableColumnName = "Name";
            // 
            // ucSelectRecordID_Owners.txtData
            // 
            this.ucSelectRecordID_Owners.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Owners.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_Owners.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_Owners.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_Owners.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_Owners.TxtData.Location = new System.Drawing.Point(0, 5);
            this.ucSelectRecordID_Owners.TxtData.MaxLength = 128;
            this.ucSelectRecordID_Owners.TxtData.Name = "txtData";
            this.ucSelectRecordID_Owners.TxtData.ReadOnly = true;
            this.ucSelectRecordID_Owners.TxtData.Size = new System.Drawing.Size(220, 26);
            this.ucSelectRecordID_Owners.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Owners.СolumnsData.AddRange(new string[] {
            "Name, Владелец",
            "Actual, Акт."});
            // 
            // lblTripExists
            // 
            this.lblTripExists.AutoSize = true;
            this.lblTripExists.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTripExists.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTripExists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTripExists.Location = new System.Drawing.Point(8, 102);
            this.lblTripExists.Name = "lblTripExists";
            this.lblTripExists.Size = new System.Drawing.Size(203, 18);
            this.lblTripExists.TabIndex = 7;
            this.lblTripExists.Text = "Задание привязано к рейсу?";
            this.ttToolTip.SetToolTip(this.lblTripExists, "Есть рейс, к которому присоединено задание?");
            // 
            // rfmPanel1
            // 
            this.rfmPanel1.Controls.Add(this.optTripExistsAll);
            this.rfmPanel1.Controls.Add(this.optTripExistsNot);
            this.rfmPanel1.Controls.Add(this.optTripExists);
            this.rfmPanel1.Location = new System.Drawing.Point(206, 96);
            this.rfmPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rfmPanel1.Name = "rfmPanel1";
            this.rfmPanel1.Size = new System.Drawing.Size(250, 30);
            this.rfmPanel1.TabIndex = 8;
            // 
            // optTripExistsAll
            // 
            this.optTripExistsAll.AutoSize = true;
            this.optTripExistsAll.Checked = true;
            this.optTripExistsAll.IsChanged = true;
            this.optTripExistsAll.Location = new System.Drawing.Point(3, 3);
            this.optTripExistsAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optTripExistsAll.Name = "optTripExistsAll";
            this.optTripExistsAll.Size = new System.Drawing.Size(94, 22);
            this.optTripExistsAll.TabIndex = 0;
            this.optTripExistsAll.TabStop = true;
            this.optTripExistsAll.Text = "не важно";
            this.optTripExistsAll.UseVisualStyleBackColor = true;
            // 
            // optTripExistsNot
            // 
            this.optTripExistsNot.AutoSize = true;
            this.optTripExistsNot.Location = new System.Drawing.Point(190, 3);
            this.optTripExistsNot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optTripExistsNot.Name = "optTripExistsNot";
            this.optTripExistsNot.Size = new System.Drawing.Size(53, 22);
            this.optTripExistsNot.TabIndex = 2;
            this.optTripExistsNot.Text = "нет";
            this.optTripExistsNot.UseVisualStyleBackColor = true;
            // 
            // optTripExists
            // 
            this.optTripExists.AutoSize = true;
            this.optTripExists.IsChanged = true;
            this.optTripExists.Location = new System.Drawing.Point(120, 3);
            this.optTripExists.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optTripExists.Name = "optTripExists";
            this.optTripExists.Size = new System.Drawing.Size(45, 22);
            this.optTripExists.TabIndex = 1;
            this.optTripExists.Text = "да";
            this.optTripExists.UseVisualStyleBackColor = true;
            // 
            // lblIsConfirmed
            // 
            this.lblIsConfirmed.AutoSize = true;
            this.lblIsConfirmed.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblIsConfirmed.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIsConfirmed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIsConfirmed.Location = new System.Drawing.Point(8, 54);
            this.lblIsConfirmed.Name = "lblIsConfirmed";
            this.lblIsConfirmed.Size = new System.Drawing.Size(176, 18);
            this.lblIsConfirmed.TabIndex = 2;
            this.lblIsConfirmed.Text = "Задание подтверждено?";
            // 
            // pnlIsConfirmed
            // 
            this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedNot);
            this.pnlIsConfirmed.Controls.Add(this.optIsConfirmed);
            this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedAll);
            this.pnlIsConfirmed.Location = new System.Drawing.Point(206, 49);
            this.pnlIsConfirmed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlIsConfirmed.Name = "pnlIsConfirmed";
            this.pnlIsConfirmed.Size = new System.Drawing.Size(250, 30);
            this.pnlIsConfirmed.TabIndex = 3;
            // 
            // optIsConfirmedNot
            // 
            this.optIsConfirmedNot.AutoSize = true;
            this.optIsConfirmedNot.Location = new System.Drawing.Point(190, 3);
            this.optIsConfirmedNot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optIsConfirmedNot.Name = "optIsConfirmedNot";
            this.optIsConfirmedNot.Size = new System.Drawing.Size(53, 22);
            this.optIsConfirmedNot.TabIndex = 1;
            this.optIsConfirmedNot.Text = "нет";
            this.optIsConfirmedNot.UseVisualStyleBackColor = true;
            // 
            // optIsConfirmed
            // 
            this.optIsConfirmed.AutoSize = true;
            this.optIsConfirmed.Location = new System.Drawing.Point(120, 3);
            this.optIsConfirmed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optIsConfirmed.Name = "optIsConfirmed";
            this.optIsConfirmed.Size = new System.Drawing.Size(45, 22);
            this.optIsConfirmed.TabIndex = 3;
            this.optIsConfirmed.Text = "да";
            this.optIsConfirmed.UseVisualStyleBackColor = true;
            // 
            // optIsConfirmedAll
            // 
            this.optIsConfirmedAll.AutoSize = true;
            this.optIsConfirmedAll.Checked = true;
            this.optIsConfirmedAll.IsChanged = true;
            this.optIsConfirmedAll.Location = new System.Drawing.Point(3, 3);
            this.optIsConfirmedAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optIsConfirmedAll.Name = "optIsConfirmedAll";
            this.optIsConfirmedAll.Size = new System.Drawing.Size(94, 22);
            this.optIsConfirmedAll.TabIndex = 0;
            this.optIsConfirmedAll.TabStop = true;
            this.optIsConfirmedAll.Text = "не важно";
            this.optIsConfirmedAll.UseVisualStyleBackColor = true;
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOwners.Location = new System.Drawing.Point(8, 152);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(74, 18);
            this.lblOwners.TabIndex = 11;
            this.lblOwners.Text = "Владелец";
            // 
            // dtrDates
            // 
            this.dtrDates.BegValue = new System.DateTime(2007, 7, 31, 0, 0, 0, 0);
            // 
            // dtrDates.btnClear
            // 
            this.dtrDates.BtnСlear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dtrDates.BtnСlear.Image = ((System.Drawing.Image)(resources.GetObject("dtrDates.btnClear.Image")));
            this.dtrDates.BtnСlear.Location = new System.Drawing.Point(195, 4);
            this.dtrDates.BtnСlear.Name = "btnClear";
            this.dtrDates.BtnСlear.Size = new System.Drawing.Size(24, 22);
            this.dtrDates.BtnСlear.TabIndex = 3;
            this.dtrDates.BtnСlear.UseVisualStyleBackColor = true;
            // 
            // dtrDates.dtpBegDate
            // 
            this.dtrDates.DtpBegDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtrDates.DtpBegDate.CustomFormat = "dd.MM.yyyy";
            this.dtrDates.DtpBegDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtrDates.DtpBegDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtrDates.DtpBegDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtrDates.DtpBegDate.Location = new System.Drawing.Point(0, 4);
            this.dtrDates.DtpBegDate.Name = "dtpBegDate";
            this.dtrDates.DtpBegDate.Size = new System.Drawing.Size(91, 26);
            this.dtrDates.DtpBegDate.TabIndex = 0;
            // 
            // dtrDates.dtpEndDate
            // 
            this.dtrDates.DtpEndDate.CalendarFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtrDates.DtpEndDate.CustomFormat = "dd.MM.yyyy";
            this.dtrDates.DtpEndDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtrDates.DtpEndDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtrDates.DtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtrDates.DtpEndDate.Location = new System.Drawing.Point(101, 4);
            this.dtrDates.DtpEndDate.Name = "dtpEndDate";
            this.dtrDates.DtpEndDate.Size = new System.Drawing.Size(91, 26);
            this.dtrDates.DtpEndDate.TabIndex = 2;
            this.dtrDates.EndValue = new System.DateTime(2007, 7, 31, 0, 0, 0, 0);
            this.dtrDates.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // dtrDates.lblDelimiter
            // 
            this.dtrDates.LblDelimiter.AutoSize = true;
            this.dtrDates.LblDelimiter.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtrDates.LblDelimiter.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtrDates.LblDelimiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtrDates.LblDelimiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dtrDates.LblDelimiter.Location = new System.Drawing.Point(90, 7);
            this.dtrDates.LblDelimiter.Name = "lblDelimiter";
            this.dtrDates.LblDelimiter.Size = new System.Drawing.Size(16, 21);
            this.dtrDates.LblDelimiter.TabIndex = 1;
            this.dtrDates.LblDelimiter.Text = ":";
            this.dtrDates.Location = new System.Drawing.Point(206, 4);
            this.dtrDates.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(254, 37);
            this.dtrDates.TabIndex = 1;
            // 
            // lblDateCarTask
            // 
            this.lblDateCarTask.AutoSize = true;
            this.lblDateCarTask.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateCarTask.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateCarTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateCarTask.Location = new System.Drawing.Point(8, 14);
            this.lblDateCarTask.Name = "lblDateCarTask";
            this.lblDateCarTask.Size = new System.Drawing.Size(102, 18);
            this.lblDateCarTask.TabIndex = 0;
            this.lblDateCarTask.Text = "Дата задания";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dgvCarsTasks);
            this.tabData.Location = new System.Drawing.Point(4, 27);
            this.tabData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabData.Size = new System.Drawing.Size(839, 522);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Задания";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // dgvCarsTasks
            // 
            this.dgvCarsTasks.AllowUserToAddRows = false;
            this.dgvCarsTasks.AllowUserToDeleteRows = false;
            this.dgvCarsTasks.AllowUserToOrderColumns = true;
            this.dgvCarsTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarsTasks.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvCarsTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCarsTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCarsTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCarsTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarsTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcConfirmedImage,
            this.dgvcDateAct,
            this.dgvcOwnerName,
            this.dgvcTripAlias,
            this.dgvcInputID,
            this.dgvcOutputID,
            this.dgvcNetto,
            this.dgvcBrutto,
            this.dgvcPalletsQnt,
            this.dgvcNote,
            this.dgvcTaskInnerCost,
            this.dgvcTaskOuterCost,
            this.dgvcCarTaskUnitName,
            this.dgvcUnitsQnt,
            this.dgvcPrice,
            this.dgvcTaskAmount,
            this.dgvcReadyForWMS,
            this.dgvcGoodStateName,
            this.dgvcERPCode,
            this.dgvcDateConfirm,
            this.dgvcUserConfirmName,
            this.dgvcDateCreate,
            this.dgvcUserCreateName,
            this.dgvcID});
            this.dgvCarsTasks.IsConfigInclude = true;
            this.dgvCarsTasks.IsMarkedAll = false;
            this.dgvCarsTasks.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvCarsTasks.Location = new System.Drawing.Point(0, 3);
            this.dgvCarsTasks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCarsTasks.MultiSelect = false;
            this.dgvCarsTasks.Name = "dgvCarsTasks";
            this.dgvCarsTasks.RangedWay = ' ';
            this.dgvCarsTasks.ReadOnly = true;
            this.dgvCarsTasks.RowHeadersWidth = 24;
            this.dgvCarsTasks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCarsTasks.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.dgvCarsTasks.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.dgvCarsTasks.Size = new System.Drawing.Size(837, 514);
            this.dgvCarsTasks.TabIndex = 12;
            this.dgvCarsTasks.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.dgvCarsTasks_CurrentRowChanged);
            this.dgvCarsTasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCarsTasks_CellFormatting);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Image = global::Logistics.Properties.Resources.Go;
            this.btnConfirm.Location = new System.Drawing.Point(693, 564);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(34, 39);
            this.btnConfirm.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnConfirm, "Подтверждение/сброс подтверждения задания");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(6, 564);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(34, 39);
            this.btnHelp.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnHelp, "Помощь");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(635, 564);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(34, 39);
            this.btnDelete.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удаление задания");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(464, 564);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 39);
            this.btnAdd.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавление задания");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::Logistics.Properties.Resources.Exit;
            this.btnCancel.Location = new System.Drawing.Point(807, 564);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 39);
            this.btnCancel.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnCancel, "Выход");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(578, 564);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 39);
            this.btnEdit.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование задания");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(750, 564);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(34, 39);
            this.btnPrint.TabIndex = 8;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tmrRestore
            // 
            this.tmrRestore.Tick += new System.EventHandler(this.tmrRestore_Tick);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Image = global::Logistics.Properties.Resources.Copy;
            this.btnCopy.Location = new System.Drawing.Point(521, 564);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(34, 39);
            this.btnCopy.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnCopy, "Копирование задания с текущего");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // dgvcConfirmedImage
            // 
            this.dgvcConfirmedImage.DataPropertyName = "IsConfirmed";
            this.dgvcConfirmedImage.HeaderText = "Подтв.";
            this.dgvcConfirmedImage.Name = "dgvcConfirmedImage";
            this.dgvcConfirmedImage.ReadOnly = true;
            this.dgvcConfirmedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcConfirmedImage.ToolTipText = "Задание подтверждено?";
            this.dgvcConfirmedImage.Width = 52;
            // 
            // dgvcDateAct
            // 
            this.dgvcDateAct.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDateAct.DataPropertyName = "DateTask";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.dgvcDateAct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcDateAct.HeaderText = "Дата";
            this.dgvcDateAct.Name = "dgvcDateAct";
            this.dgvcDateAct.ReadOnly = true;
            this.dgvcDateAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDateAct.ToolTipText = "Дата задания";
            this.dgvcDateAct.Width = 80;
            // 
            // dgvcOwnerName
            // 
            this.dgvcOwnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcOwnerName.DataPropertyName = "PartnerName";
            this.dgvcOwnerName.HeaderText = "Владелец";
            this.dgvcOwnerName.Name = "dgvcOwnerName";
            this.dgvcOwnerName.ReadOnly = true;
            this.dgvcOwnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcOwnerName.Width = 150;
            // 
            // dgvcTripAlias
            // 
            this.dgvcTripAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTripAlias.DataPropertyName = "TripNote";
            this.dgvcTripAlias.HeaderText = "Рейс";
            this.dgvcTripAlias.Name = "dgvcTripAlias";
            this.dgvcTripAlias.ReadOnly = true;
            this.dgvcTripAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTripAlias.Width = 200;
            // 
            // dgvcInputID
            // 
            this.dgvcInputID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcInputID.DataPropertyName = "DeliveryAddress";
            this.dgvcInputID.HeaderText = "Адрес";
            this.dgvcInputID.Name = "dgvcInputID";
            this.dgvcInputID.ReadOnly = true;
            this.dgvcInputID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcInputID.ToolTipText = "Адрес доставки";
            this.dgvcInputID.Width = 150;
            // 
            // dgvcOutputID
            // 
            this.dgvcOutputID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcOutputID.DataPropertyName = "ZoneName";
            this.dgvcOutputID.HeaderText = "Зона";
            this.dgvcOutputID.Name = "dgvcOutputID";
            this.dgvcOutputID.ReadOnly = true;
            this.dgvcOutputID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcOutputID.ToolTipText = "Зона доставки";
            this.dgvcOutputID.Width = 60;
            // 
            // dgvcNetto
            // 
            this.dgvcNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcNetto.DataPropertyName = "Netto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.dgvcNetto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcNetto.HeaderText = "Нетто";
            this.dgvcNetto.Name = "dgvcNetto";
            this.dgvcNetto.ReadOnly = true;
            this.dgvcNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcNetto.Width = 60;
            // 
            // dgvcBrutto
            // 
            this.dgvcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcBrutto.DataPropertyName = "Brutto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.dgvcBrutto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcBrutto.HeaderText = "Брутто";
            this.dgvcBrutto.Name = "dgvcBrutto";
            this.dgvcBrutto.ReadOnly = true;
            this.dgvcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcBrutto.Width = 60;
            // 
            // dgvcPalletsQnt
            // 
            this.dgvcPalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPalletsQnt.DataPropertyName = "PalletsQnt";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.dgvcPalletsQnt.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcPalletsQnt.HeaderText = "Пал.";
            this.dgvcPalletsQnt.Name = "dgvcPalletsQnt";
            this.dgvcPalletsQnt.ReadOnly = true;
            this.dgvcPalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPalletsQnt.ToolTipText = "Количество паллет";
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
            this.dgvcNote.Width = 150;
            // 
            // dgvcTaskInnerCost
            // 
            this.dgvcTaskInnerCost.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTaskInnerCost.DataPropertyName = "TaskInnerCost";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.dgvcTaskInnerCost.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcTaskInnerCost.HeaderText = "Ст-ть наша";
            this.dgvcTaskInnerCost.Name = "dgvcTaskInnerCost";
            this.dgvcTaskInnerCost.ReadOnly = true;
            this.dgvcTaskInnerCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTaskInnerCost.ToolTipText = "Стоимость доставки нашив транспортом";
            // 
            // dgvcTaskOuterCost
            // 
            this.dgvcTaskOuterCost.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTaskOuterCost.DataPropertyName = "TaskOuterCost";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.dgvcTaskOuterCost.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcTaskOuterCost.HeaderText = "Ст-ть пер.";
            this.dgvcTaskOuterCost.Name = "dgvcTaskOuterCost";
            this.dgvcTaskOuterCost.ReadOnly = true;
            this.dgvcTaskOuterCost.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTaskOuterCost.ToolTipText = "Стоимость доставки транспортом перевозчика";
            // 
            // dgvcCarTaskUnitName
            // 
            this.dgvcCarTaskUnitName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcCarTaskUnitName.DataPropertyName = "CarTaskUnitName";
            this.dgvcCarTaskUnitName.HeaderText = "Е.и.";
            this.dgvcCarTaskUnitName.Name = "dgvcCarTaskUnitName";
            this.dgvcCarTaskUnitName.ReadOnly = true;
            this.dgvcCarTaskUnitName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcCarTaskUnitName.ToolTipText = "Единица измерения работ/услуг";
            this.dgvcCarTaskUnitName.Width = 50;
            // 
            // dgvcUnitsQnt
            // 
            this.dgvcUnitsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcUnitsQnt.DataPropertyName = "UnitsQnt";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N2";
            this.dgvcUnitsQnt.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvcUnitsQnt.HeaderText = "Кол-во е.и.";
            this.dgvcUnitsQnt.Name = "dgvcUnitsQnt";
            this.dgvcUnitsQnt.ReadOnly = true;
            this.dgvcUnitsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcUnitsQnt.ToolTipText = "Количество единиц измерения";
            this.dgvcUnitsQnt.Width = 50;
            // 
            // dgvcPrice
            // 
            this.dgvcPrice.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPrice.DataPropertyName = "Price";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N2";
            this.dgvcPrice.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvcPrice.HeaderText = "Цена";
            this.dgvcPrice.Name = "dgvcPrice";
            this.dgvcPrice.ReadOnly = true;
            this.dgvcPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPrice.Width = 80;
            // 
            // dgvcTaskAmount
            // 
            this.dgvcTaskAmount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTaskAmount.DataPropertyName = "TaskAmount";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N2";
            this.dgvcTaskAmount.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvcTaskAmount.HeaderText = "Сумма";
            this.dgvcTaskAmount.Name = "dgvcTaskAmount";
            this.dgvcTaskAmount.ReadOnly = true;
            this.dgvcTaskAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcReadyForWMS
            // 
            this.dgvcReadyForWMS.DataPropertyName = "IsCash";
            this.dgvcReadyForWMS.HeaderText = "Нал.";
            this.dgvcReadyForWMS.Name = "dgvcReadyForWMS";
            this.dgvcReadyForWMS.ReadOnly = true;
            this.dgvcReadyForWMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcReadyForWMS.ToolTipText = "Признак оплаты наличными";
            this.dgvcReadyForWMS.Width = 50;
            // 
            // dgvcGoodStateName
            // 
            this.dgvcGoodStateName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcGoodStateName.DataPropertyName = "Latitude";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N6";
            dataGridViewCellStyle11.NullValue = null;
            this.dgvcGoodStateName.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcGoodStateName.HeaderText = "Шир.";
            this.dgvcGoodStateName.Name = "dgvcGoodStateName";
            this.dgvcGoodStateName.ReadOnly = true;
            this.dgvcGoodStateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcGoodStateName.ToolTipText = "Широта";
            // 
            // dgvcERPCode
            // 
            this.dgvcERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcERPCode.DataPropertyName = "Longitude";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N6";
            dataGridViewCellStyle12.NullValue = null;
            this.dgvcERPCode.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcERPCode.HeaderText = "Дол.";
            this.dgvcERPCode.Name = "dgvcERPCode";
            this.dgvcERPCode.ReadOnly = true;
            this.dgvcERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcERPCode.ToolTipText = "Долгота";
            // 
            // dgvcDateConfirm
            // 
            this.dgvcDateConfirm.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDateConfirm.DataPropertyName = "DateConfirm";
            dataGridViewCellStyle13.Format = "dd.MM.yyyy HH:mm";
            this.dgvcDateConfirm.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcDateConfirm.HeaderText = "Дата подтв.";
            this.dgvcDateConfirm.Name = "dgvcDateConfirm";
            this.dgvcDateConfirm.ReadOnly = true;
            this.dgvcDateConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDateConfirm.ToolTipText = "Дата-время подтверждения";
            this.dgvcDateConfirm.Width = 110;
            // 
            // dgvcUserConfirmName
            // 
            this.dgvcUserConfirmName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcUserConfirmName.DataPropertyName = "UserConfirmName";
            this.dgvcUserConfirmName.HeaderText = "Кем подтверждено";
            this.dgvcUserConfirmName.Name = "dgvcUserConfirmName";
            this.dgvcUserConfirmName.ReadOnly = true;
            this.dgvcUserConfirmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcDateCreate
            // 
            this.dgvcDateCreate.DataPropertyName = "DateIndent";
            dataGridViewCellStyle14.Format = "dd.MM.yyyy HH:mm";
            this.dgvcDateCreate.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvcDateCreate.HeaderText = "Дата созд.";
            this.dgvcDateCreate.Name = "dgvcDateCreate";
            this.dgvcDateCreate.ReadOnly = true;
            this.dgvcDateCreate.ToolTipText = "Дата-время создания";
            this.dgvcDateCreate.Width = 110;
            // 
            // dgvcUserCreateName
            // 
            this.dgvcUserCreateName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcUserCreateName.DataPropertyName = "UserIndentName";
            this.dgvcUserCreateName.HeaderText = "Кем создано";
            this.dgvcUserCreateName.Name = "dgvcUserCreateName";
            this.dgvcUserCreateName.ReadOnly = true;
            this.dgvcUserCreateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcUserCreateName.ToolTipText = "Пользователь, создавший акт";
            // 
            // dgvcID
            // 
            this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcID.DataPropertyName = "ID";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcID.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvcID.HeaderText = "ID";
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.ToolTipText = "Код акта";
            this.dgvcID.Width = 50;
            // 
            // frmCarsTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 609);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tcList);
            this.hpHelp.SetHelpKeyword(this, "102");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.hpHelp.SetHelpString(this, "");
            this.IsWaitLoading = true;
            this.LastGrid = this.dgvCarsTasks;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(855, 631);
            this.Name = "frmCarsTasks";
            this.hpHelp.SetShowHelp(this, true);
            this.Text = "Транспортные задания";
            this.Load += new System.EventHandler(this.frmCarsTasks_Load);
            this.tcList.ResumeLayout(false);
            this.tabTerms.ResumeLayout(false);
            this.cntTerms.ResumeLayout(false);
            this.cntTerms.PerformLayout();
            this.ucSelectRecordID_Owners.ResumeLayout(false);
            this.ucSelectRecordID_Owners.PerformLayout();
            this.rfmPanel1.ResumeLayout(false);
            this.rfmPanel1.PerformLayout();
            this.pnlIsConfirmed.ResumeLayout(false);
            this.pnlIsConfirmed.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarsTasks)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnCancel;
        private RFMBaseClasses.RFMTabPage tabData;
        private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMButton btnDelete;
        private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMButton btnConfirm;
        private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblDateCarTask;
        private RFMBaseClasses.RFMDateRange dtrDates;
        private RFMBaseClasses.RFMLabel lblOwners;
        private RFMBaseClasses.RFMLabel lblIsConfirmed;
        private RFMBaseClasses.RFMPanel pnlIsConfirmed;
        private RFMBaseClasses.RFMRadioButton optIsConfirmedNot;
        private RFMBaseClasses.RFMRadioButton optIsConfirmed;
        private RFMBaseClasses.RFMRadioButton optIsConfirmedAll;
        private RFMBaseClasses.RFMLabel lblTripExists;
        private RFMBaseClasses.RFMPanel rfmPanel1;
        private RFMBaseClasses.RFMRadioButton optTripExistsAll;
        private RFMBaseClasses.RFMRadioButton optTripExistsNot;
        private RFMBaseClasses.RFMRadioButton optTripExists;
        private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Owners;
        private RFMBaseClasses.RFMButton btnClearTerms;
        private RFMBaseClasses.RFMDataGridView dgvCarsTasks;
        private RFMBaseClasses.RFMButton btnPrint;
        private RFMBaseClasses.RFMTimer tmrRestore;
        private RFMBaseClasses.RFMButton btnCopy;
        private RFMBaseClasses.RFMDataGridViewImageColumn dgvcConfirmedImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateAct;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcOwnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcTripAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcInputID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcOutputID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcNetto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcBrutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPalletsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcNote;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcTaskInnerCost;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcTaskOuterCost;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcCarTaskUnitName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcUnitsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPrice;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcTaskAmount;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcReadyForWMS;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodStateName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateConfirm;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcUserConfirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateCreate;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcUserCreateName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
    }
}