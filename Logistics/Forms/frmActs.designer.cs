namespace Logistics
{
	partial class frmActs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcList = new RFMBaseClasses.RFMTabControl();
            this.tabTerms = new RFMBaseClasses.RFMTabPage();
            this.cntTerms = new RFMBaseClasses.RFMPanel();
            this.ucSelectRecordIDForm_Packings = new RFMBaseClasses.RFMSelectRecordIDForm();
            this.lblHosts = new RFMBaseClasses.RFMLabel();
            this.ucSelectRecordID_Hosts = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.ucSelectRecordID_Owners = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.chkShowSelectedGoodsOnly = new RFMBaseClasses.RFMCheckBox();
            this.lblTripExists = new RFMBaseClasses.RFMLabel();
            this.rfmPanel1 = new RFMBaseClasses.RFMPanel();
            this.optTripExistsAll = new RFMBaseClasses.RFMRadioButton();
            this.optTripExistsNot = new RFMBaseClasses.RFMRadioButton();
            this.optTripExists = new RFMBaseClasses.RFMRadioButton();
            this.chkInput = new RFMBaseClasses.RFMCheckBox();
            this.chkOutput = new RFMBaseClasses.RFMCheckBox();
            this.lblIsConfirmed = new RFMBaseClasses.RFMLabel();
            this.pnlIsConfirmed = new RFMBaseClasses.RFMPanel();
            this.optIsConfirmedNot = new RFMBaseClasses.RFMRadioButton();
            this.optIsConfirmed = new RFMBaseClasses.RFMRadioButton();
            this.optIsConfirmedAll = new RFMBaseClasses.RFMRadioButton();
            this.lblPackings = new RFMBaseClasses.RFMLabel();
            this.lblPutExists = new RFMBaseClasses.RFMLabel();
            this.pnlTripExists = new RFMBaseClasses.RFMPanel();
            this.optPutExistsAll = new RFMBaseClasses.RFMRadioButton();
            this.optPutExistsNot = new RFMBaseClasses.RFMRadioButton();
            this.optPutExists = new RFMBaseClasses.RFMRadioButton();
            this.lblReadyForWMS = new RFMBaseClasses.RFMLabel();
            this.pnlReadyForWMS = new RFMBaseClasses.RFMPanel();
            this.optReadyForWMSNot = new RFMBaseClasses.RFMRadioButton();
            this.optReadyForWMS = new RFMBaseClasses.RFMRadioButton();
            this.optReadyForWMSAll = new RFMBaseClasses.RFMRadioButton();
            this.lblOwners = new RFMBaseClasses.RFMLabel();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.btnClearTerms = new RFMBaseClasses.RFMButton();
            this.lblDateActs = new RFMBaseClasses.RFMLabel();
            this.tabData = new RFMBaseClasses.RFMTabPage();
            this.cntGrids = new RFMBaseClasses.RFMSplitContainer();
            this.dgvActs = new RFMBaseClasses.RFMDataGridView();
            this.tcActsDetails = new RFMBaseClasses.RFMTabControl();
            this.tabActsGoods = new RFMBaseClasses.RFMTabPage();
            this.dgvActsGoods = new RFMBaseClasses.RFMDataGridView();
            this.dgvcActsGoods_GoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_InBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_QntConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_BoxConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_PalConfirmed = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_BoxInPal = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_Weighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.dgvcActsGoods_GoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_GoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActsGoods_GoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcActtsGoods_PackingID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnService = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.btnCancel = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.tmrRestore = new RFMBaseClasses.RFMTimer();
            this.dgvcConfirmedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.dgvcDateAct = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcDateConfirm = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcInputID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcOutputID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTripAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcOwnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcGoodStateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcUserCreateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcReadyForWMS = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.dgvcNote = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tcList.SuspendLayout();
            this.tabTerms.SuspendLayout();
            this.cntTerms.SuspendLayout();
            this.ucSelectRecordIDForm_Packings.SuspendLayout();
            this.ucSelectRecordID_Hosts.SuspendLayout();
            this.ucSelectRecordID_Owners.SuspendLayout();
            this.rfmPanel1.SuspendLayout();
            this.pnlIsConfirmed.SuspendLayout();
            this.pnlTripExists.SuspendLayout();
            this.pnlReadyForWMS.SuspendLayout();
            this.dtrDates.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cntGrids)).BeginInit();
            this.cntGrids.Panel1.SuspendLayout();
            this.cntGrids.Panel2.SuspendLayout();
            this.cntGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActs)).BeginInit();
            this.tcActsDetails.SuspendLayout();
            this.tabActsGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActsGoods)).BeginInit();
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
            this.tcList.Name = "tcList";
            this.tcList.SelectedIndex = 0;
            this.tcList.Size = new System.Drawing.Size(741, 430);
            this.tcList.TabIndex = 0;
            // 
            // tabTerms
            // 
            this.tabTerms.Controls.Add(this.cntTerms);
            this.tabTerms.IsFilterPage = true;
            this.tabTerms.Location = new System.Drawing.Point(4, 23);
            this.tabTerms.Name = "tabTerms";
            this.tabTerms.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerms.Size = new System.Drawing.Size(733, 403);
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
            this.cntTerms.Controls.Add(this.ucSelectRecordIDForm_Packings);
            this.cntTerms.Controls.Add(this.lblHosts);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_Hosts);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_Owners);
            this.cntTerms.Controls.Add(this.chkShowSelectedGoodsOnly);
            this.cntTerms.Controls.Add(this.lblTripExists);
            this.cntTerms.Controls.Add(this.rfmPanel1);
            this.cntTerms.Controls.Add(this.chkInput);
            this.cntTerms.Controls.Add(this.chkOutput);
            this.cntTerms.Controls.Add(this.lblIsConfirmed);
            this.cntTerms.Controls.Add(this.pnlIsConfirmed);
            this.cntTerms.Controls.Add(this.lblPackings);
            this.cntTerms.Controls.Add(this.lblPutExists);
            this.cntTerms.Controls.Add(this.pnlTripExists);
            this.cntTerms.Controls.Add(this.lblReadyForWMS);
            this.cntTerms.Controls.Add(this.pnlReadyForWMS);
            this.cntTerms.Controls.Add(this.lblOwners);
            this.cntTerms.Controls.Add(this.dtrDates);
            this.cntTerms.Controls.Add(this.btnClearTerms);
            this.cntTerms.Controls.Add(this.lblDateActs);
            this.cntTerms.Location = new System.Drawing.Point(0, 2);
            this.cntTerms.Name = "cntTerms";
            this.cntTerms.Size = new System.Drawing.Size(732, 400);
            this.cntTerms.TabIndex = 0;
            // 
            // ucSelectRecordIDForm_Packings
            // 
            this.ucSelectRecordIDForm_Packings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // ucSelectRecordIDForm_Packings.btnClear
            // 
            this.ucSelectRecordIDForm_Packings.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordIDForm_Packings.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Packings.btnClear.Image")));
            this.ucSelectRecordIDForm_Packings.BtnClear.Location = new System.Drawing.Point(248, 4);
            this.ucSelectRecordIDForm_Packings.BtnClear.Name = "btnClear";
            this.ucSelectRecordIDForm_Packings.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordIDForm_Packings.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Packings.BtnClear, "Очистка выбора товаров");
            this.ucSelectRecordIDForm_Packings.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordIDForm_Packings.btnSelect
            // 
            this.ucSelectRecordIDForm_Packings.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordIDForm_Packings.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordIDForm_Packings.btnSelect.Image")));
            this.ucSelectRecordIDForm_Packings.BtnSelect.Location = new System.Drawing.Point(222, 4);
            this.ucSelectRecordIDForm_Packings.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordIDForm_Packings.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordIDForm_Packings.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordIDForm_Packings.BtnSelect, "Выбор товаров");
            this.ucSelectRecordIDForm_Packings.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordIDForm_Packings.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordIDForm_Packings.FormName = "frmSelectOnePacking";
            this.ucSelectRecordIDForm_Packings.IsSaveMark = true;
            this.ucSelectRecordIDForm_Packings.Location = new System.Drawing.Point(145, 344);
            this.ucSelectRecordIDForm_Packings.MarkedCount = 0;
            this.ucSelectRecordIDForm_Packings.Name = "ucSelectRecordIDForm_Packings";
            this.ucSelectRecordIDForm_Packings.Size = new System.Drawing.Size(276, 30);
            this.ucSelectRecordIDForm_Packings.TabIndex = 14;
            // 
            // ucSelectRecordIDForm_Packings.txtData
            // 
            this.ucSelectRecordIDForm_Packings.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordIDForm_Packings.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordIDForm_Packings.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordIDForm_Packings.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordIDForm_Packings.TxtData.IsUserDraw = true;
            this.ucSelectRecordIDForm_Packings.TxtData.Location = new System.Drawing.Point(0, 5);
            this.ucSelectRecordIDForm_Packings.TxtData.Name = "txtData";
            this.ucSelectRecordIDForm_Packings.TxtData.ReadOnly = true;
            this.ucSelectRecordIDForm_Packings.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordIDForm_Packings.TxtData.TabIndex = 3;
            this.ucSelectRecordIDForm_Packings.TxtData.TextChanged += new System.EventHandler(this.ucSelectRecordIDForm_Packings_TxtData_TextChanged);
            // 
            // lblHosts
            // 
            this.lblHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHosts.AutoSize = true;
            this.lblHosts.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblHosts.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHosts.Location = new System.Drawing.Point(471, 356);
            this.lblHosts.Name = "lblHosts";
            this.lblHosts.Size = new System.Drawing.Size(41, 14);
            this.lblHosts.TabIndex = 16;
            this.lblHosts.Text = "Хосты";
            // 
            // ucSelectRecordID_Hosts
            // 
            this.ucSelectRecordID_Hosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // ucSelectRecordID_Hosts.btnClear
            // 
            this.ucSelectRecordID_Hosts.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Hosts.BtnClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.ucSelectRecordID_Hosts.BtnClear.Location = new System.Drawing.Point(202, 0);
            this.ucSelectRecordID_Hosts.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_Hosts.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Hosts.BtnClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Hosts.BtnClear, "Очистка выбора хостов");
            this.ucSelectRecordID_Hosts.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_Hosts.btnSelect
            // 
            this.ucSelectRecordID_Hosts.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Hosts.BtnSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.ucSelectRecordID_Hosts.BtnSelect.Location = new System.Drawing.Point(176, 0);
            this.ucSelectRecordID_Hosts.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_Hosts.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Hosts.BtnSelect.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.ucSelectRecordID_Hosts.BtnSelect, "Выбор хостов");
            this.ucSelectRecordID_Hosts.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_Hosts.ExpSort = "Name";
            this.ucSelectRecordID_Hosts.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_Hosts.IsActualOnly = true;
            this.ucSelectRecordID_Hosts.IsSaveMark = true;
            this.ucSelectRecordID_Hosts.IsUseMark = true;
            this.ucSelectRecordID_Hosts.Location = new System.Drawing.Point(471, 371);
            this.ucSelectRecordID_Hosts.MarkedCount = 0;
            this.ucSelectRecordID_Hosts.Name = "ucSelectRecordID_Hosts";
            this.ucSelectRecordID_Hosts.Size = new System.Drawing.Size(229, 24);
            this.ucSelectRecordID_Hosts.TabIndex = 17;
            this.ucSelectRecordID_Hosts.TableColumnName = "Name";
            // 
            // ucSelectRecordID_Hosts.txtData
            // 
            this.ucSelectRecordID_Hosts.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Hosts.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.ucSelectRecordID_Hosts.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.ucSelectRecordID_Hosts.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
            this.ucSelectRecordID_Hosts.TxtData.IsUserDraw = true;
            this.ucSelectRecordID_Hosts.TxtData.Location = new System.Drawing.Point(0, 1);
            this.ucSelectRecordID_Hosts.TxtData.MaxLength = 128;
            this.ucSelectRecordID_Hosts.TxtData.Name = "txtData";
            this.ucSelectRecordID_Hosts.TxtData.ReadOnly = true;
            this.ucSelectRecordID_Hosts.TxtData.Size = new System.Drawing.Size(174, 22);
            this.ucSelectRecordID_Hosts.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Hosts.СolumnsData.AddRange(new string[] {
            "Name, Хост"});
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
            this.ucSelectRecordID_Owners.Location = new System.Drawing.Point(145, 252);
            this.ucSelectRecordID_Owners.MarkedCount = 0;
            this.ucSelectRecordID_Owners.Name = "ucSelectRecordID_Owners";
            this.ucSelectRecordID_Owners.Size = new System.Drawing.Size(275, 32);
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
            this.ucSelectRecordID_Owners.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_Owners.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Owners.СolumnsData.AddRange(new string[] {
            "Name, Владелец",
            "Actual, Акт."});
            // 
            // chkShowSelectedGoodsOnly
            // 
            this.chkShowSelectedGoodsOnly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkShowSelectedGoodsOnly.AutoSize = true;
            this.chkShowSelectedGoodsOnly.Location = new System.Drawing.Point(145, 374);
            this.chkShowSelectedGoodsOnly.Name = "chkShowSelectedGoodsOnly";
            this.chkShowSelectedGoodsOnly.Size = new System.Drawing.Size(249, 18);
            this.chkShowSelectedGoodsOnly.TabIndex = 15;
            this.chkShowSelectedGoodsOnly.Text = "показывать только отобранные товары";
            this.chkShowSelectedGoodsOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkShowSelectedGoodsOnly.UseVisualStyleBackColor = true;
            // 
            // lblTripExists
            // 
            this.lblTripExists.AutoSize = true;
            this.lblTripExists.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTripExists.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTripExists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTripExists.Location = new System.Drawing.Point(7, 164);
            this.lblTripExists.Name = "lblTripExists";
            this.lblTripExists.Size = new System.Drawing.Size(136, 14);
            this.lblTripExists.TabIndex = 7;
            this.lblTripExists.Text = "Акт привязан к рейсу?";
            this.ttToolTip.SetToolTip(this.lblTripExists, "Есть рейс, к которому присоединено задание?");
            // 
            // rfmPanel1
            // 
            this.rfmPanel1.Controls.Add(this.optTripExistsAll);
            this.rfmPanel1.Controls.Add(this.optTripExistsNot);
            this.rfmPanel1.Controls.Add(this.optTripExists);
            this.rfmPanel1.Location = new System.Drawing.Point(147, 160);
            this.rfmPanel1.Name = "rfmPanel1";
            this.rfmPanel1.Size = new System.Drawing.Size(219, 23);
            this.rfmPanel1.TabIndex = 8;
            // 
            // optTripExistsAll
            // 
            this.optTripExistsAll.AutoSize = true;
            this.optTripExistsAll.Checked = true;
            this.optTripExistsAll.IsChanged = true;
            this.optTripExistsAll.Location = new System.Drawing.Point(3, 2);
            this.optTripExistsAll.Name = "optTripExistsAll";
            this.optTripExistsAll.Size = new System.Drawing.Size(79, 18);
            this.optTripExistsAll.TabIndex = 0;
            this.optTripExistsAll.TabStop = true;
            this.optTripExistsAll.Text = "не важно";
            this.optTripExistsAll.UseVisualStyleBackColor = true;
            // 
            // optTripExistsNot
            // 
            this.optTripExistsNot.AutoSize = true;
            this.optTripExistsNot.Location = new System.Drawing.Point(166, 2);
            this.optTripExistsNot.Name = "optTripExistsNot";
            this.optTripExistsNot.Size = new System.Drawing.Size(45, 18);
            this.optTripExistsNot.TabIndex = 2;
            this.optTripExistsNot.Text = "нет";
            this.optTripExistsNot.UseVisualStyleBackColor = true;
            // 
            // optTripExists
            // 
            this.optTripExists.AutoSize = true;
            this.optTripExists.IsChanged = true;
            this.optTripExists.Location = new System.Drawing.Point(105, 2);
            this.optTripExists.Name = "optTripExists";
            this.optTripExists.Size = new System.Drawing.Size(38, 18);
            this.optTripExists.TabIndex = 1;
            this.optTripExists.Text = "да";
            this.optTripExists.UseVisualStyleBackColor = true;
            // 
            // chkInput
            // 
            this.chkInput.AutoSize = true;
            this.chkInput.Enabled = false;
            this.chkInput.Location = new System.Drawing.Point(150, 126);
            this.chkInput.Name = "chkInput";
            this.chkInput.Size = new System.Drawing.Size(196, 18);
            this.chkInput.TabIndex = 6;
            this.chkInput.Text = "Cкладское задание на приход";
            this.chkInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkInput.UseVisualStyleBackColor = true;
            // 
            // chkOutput
            // 
            this.chkOutput.AutoSize = true;
            this.chkOutput.Enabled = false;
            this.chkOutput.Location = new System.Drawing.Point(150, 105);
            this.chkOutput.Name = "chkOutput";
            this.chkOutput.Size = new System.Drawing.Size(194, 18);
            this.chkOutput.TabIndex = 5;
            this.chkOutput.Text = "Cкладское задание на расход";
            this.chkOutput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkOutput.UseVisualStyleBackColor = true;
            // 
            // lblIsConfirmed
            // 
            this.lblIsConfirmed.AutoSize = true;
            this.lblIsConfirmed.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblIsConfirmed.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIsConfirmed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIsConfirmed.Location = new System.Drawing.Point(7, 42);
            this.lblIsConfirmed.Name = "lblIsConfirmed";
            this.lblIsConfirmed.Size = new System.Drawing.Size(115, 14);
            this.lblIsConfirmed.TabIndex = 2;
            this.lblIsConfirmed.Text = "Акт подтвержден?";
            // 
            // pnlIsConfirmed
            // 
            this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedNot);
            this.pnlIsConfirmed.Controls.Add(this.optIsConfirmed);
            this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedAll);
            this.pnlIsConfirmed.Location = new System.Drawing.Point(147, 38);
            this.pnlIsConfirmed.Name = "pnlIsConfirmed";
            this.pnlIsConfirmed.Size = new System.Drawing.Size(219, 23);
            this.pnlIsConfirmed.TabIndex = 3;
            // 
            // optIsConfirmedNot
            // 
            this.optIsConfirmedNot.AutoSize = true;
            this.optIsConfirmedNot.Location = new System.Drawing.Point(166, 2);
            this.optIsConfirmedNot.Name = "optIsConfirmedNot";
            this.optIsConfirmedNot.Size = new System.Drawing.Size(45, 18);
            this.optIsConfirmedNot.TabIndex = 1;
            this.optIsConfirmedNot.Text = "нет";
            this.optIsConfirmedNot.UseVisualStyleBackColor = true;
            // 
            // optIsConfirmed
            // 
            this.optIsConfirmed.AutoSize = true;
            this.optIsConfirmed.Location = new System.Drawing.Point(105, 2);
            this.optIsConfirmed.Name = "optIsConfirmed";
            this.optIsConfirmed.Size = new System.Drawing.Size(38, 18);
            this.optIsConfirmed.TabIndex = 3;
            this.optIsConfirmed.Text = "да";
            this.optIsConfirmed.UseVisualStyleBackColor = true;
            // 
            // optIsConfirmedAll
            // 
            this.optIsConfirmedAll.AutoSize = true;
            this.optIsConfirmedAll.Checked = true;
            this.optIsConfirmedAll.IsChanged = true;
            this.optIsConfirmedAll.Location = new System.Drawing.Point(3, 2);
            this.optIsConfirmedAll.Name = "optIsConfirmedAll";
            this.optIsConfirmedAll.Size = new System.Drawing.Size(79, 18);
            this.optIsConfirmedAll.TabIndex = 0;
            this.optIsConfirmedAll.TabStop = true;
            this.optIsConfirmedAll.Text = "не важно";
            this.optIsConfirmedAll.UseVisualStyleBackColor = true;
            // 
            // lblPackings
            // 
            this.lblPackings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPackings.AutoSize = true;
            this.lblPackings.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPackings.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPackings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPackings.Location = new System.Drawing.Point(7, 353);
            this.lblPackings.Name = "lblPackings";
            this.lblPackings.Size = new System.Drawing.Size(49, 14);
            this.lblPackings.TabIndex = 13;
            this.lblPackings.Text = "Товары";
            // 
            // lblPutExists
            // 
            this.lblPutExists.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPutExists.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPutExists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPutExists.Location = new System.Drawing.Point(7, 76);
            this.lblPutExists.Name = "lblPutExists";
            this.lblPutExists.Size = new System.Drawing.Size(117, 30);
            this.lblPutExists.TabIndex = 3;
            this.lblPutExists.Text = "Акт привязан к скл.заданию?";
            // 
            // pnlTripExists
            // 
            this.pnlTripExists.Controls.Add(this.optPutExistsAll);
            this.pnlTripExists.Controls.Add(this.optPutExistsNot);
            this.pnlTripExists.Controls.Add(this.optPutExists);
            this.pnlTripExists.Location = new System.Drawing.Point(147, 80);
            this.pnlTripExists.Name = "pnlTripExists";
            this.pnlTripExists.Size = new System.Drawing.Size(219, 23);
            this.pnlTripExists.TabIndex = 4;
            // 
            // optPutExistsAll
            // 
            this.optPutExistsAll.AutoSize = true;
            this.optPutExistsAll.Checked = true;
            this.optPutExistsAll.IsChanged = true;
            this.optPutExistsAll.Location = new System.Drawing.Point(3, 2);
            this.optPutExistsAll.Name = "optPutExistsAll";
            this.optPutExistsAll.Size = new System.Drawing.Size(79, 18);
            this.optPutExistsAll.TabIndex = 0;
            this.optPutExistsAll.TabStop = true;
            this.optPutExistsAll.Text = "не важно";
            this.optPutExistsAll.UseVisualStyleBackColor = true;
            // 
            // optPutExistsNot
            // 
            this.optPutExistsNot.AutoSize = true;
            this.optPutExistsNot.Location = new System.Drawing.Point(166, 2);
            this.optPutExistsNot.Name = "optPutExistsNot";
            this.optPutExistsNot.Size = new System.Drawing.Size(45, 18);
            this.optPutExistsNot.TabIndex = 2;
            this.optPutExistsNot.Text = "нет";
            this.optPutExistsNot.UseVisualStyleBackColor = true;
            // 
            // optPutExists
            // 
            this.optPutExists.AutoSize = true;
            this.optPutExists.IsChanged = true;
            this.optPutExists.Location = new System.Drawing.Point(105, 2);
            this.optPutExists.Name = "optPutExists";
            this.optPutExists.Size = new System.Drawing.Size(38, 18);
            this.optPutExists.TabIndex = 1;
            this.optPutExists.Text = "да";
            this.optPutExists.UseVisualStyleBackColor = true;
            this.optPutExists.CheckedChanged += new System.EventHandler(this.optPutExists_CheckedChanged);
            // 
            // lblReadyForWMS
            // 
            this.lblReadyForWMS.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblReadyForWMS.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblReadyForWMS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblReadyForWMS.Location = new System.Drawing.Point(7, 196);
            this.lblReadyForWMS.Name = "lblReadyForWMS";
            this.lblReadyForWMS.Size = new System.Drawing.Size(136, 29);
            this.lblReadyForWMS.TabIndex = 9;
            this.lblReadyForWMS.Text = "Акт готов к передаче в скл.систему?";
            // 
            // pnlReadyForWMS
            // 
            this.pnlReadyForWMS.Controls.Add(this.optReadyForWMSNot);
            this.pnlReadyForWMS.Controls.Add(this.optReadyForWMS);
            this.pnlReadyForWMS.Controls.Add(this.optReadyForWMSAll);
            this.pnlReadyForWMS.Location = new System.Drawing.Point(147, 201);
            this.pnlReadyForWMS.Name = "pnlReadyForWMS";
            this.pnlReadyForWMS.Size = new System.Drawing.Size(219, 23);
            this.pnlReadyForWMS.TabIndex = 10;
            // 
            // optReadyForWMSNot
            // 
            this.optReadyForWMSNot.AutoSize = true;
            this.optReadyForWMSNot.Location = new System.Drawing.Point(166, 2);
            this.optReadyForWMSNot.Name = "optReadyForWMSNot";
            this.optReadyForWMSNot.Size = new System.Drawing.Size(45, 18);
            this.optReadyForWMSNot.TabIndex = 1;
            this.optReadyForWMSNot.Text = "нет";
            this.optReadyForWMSNot.UseVisualStyleBackColor = true;
            // 
            // optReadyForWMS
            // 
            this.optReadyForWMS.AutoSize = true;
            this.optReadyForWMS.Location = new System.Drawing.Point(105, 2);
            this.optReadyForWMS.Name = "optReadyForWMS";
            this.optReadyForWMS.Size = new System.Drawing.Size(38, 18);
            this.optReadyForWMS.TabIndex = 3;
            this.optReadyForWMS.Text = "да";
            this.optReadyForWMS.UseVisualStyleBackColor = true;
            // 
            // optReadyForWMSAll
            // 
            this.optReadyForWMSAll.AutoSize = true;
            this.optReadyForWMSAll.Checked = true;
            this.optReadyForWMSAll.IsChanged = true;
            this.optReadyForWMSAll.Location = new System.Drawing.Point(3, 2);
            this.optReadyForWMSAll.Name = "optReadyForWMSAll";
            this.optReadyForWMSAll.Size = new System.Drawing.Size(79, 18);
            this.optReadyForWMSAll.TabIndex = 0;
            this.optReadyForWMSAll.TabStop = true;
            this.optReadyForWMSAll.Text = "не важно";
            this.optReadyForWMSAll.UseVisualStyleBackColor = true;
            // 
            // lblOwners
            // 
            this.lblOwners.AutoSize = true;
            this.lblOwners.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOwners.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOwners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOwners.Location = new System.Drawing.Point(7, 261);
            this.lblOwners.Name = "lblOwners";
            this.lblOwners.Size = new System.Drawing.Size(62, 14);
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
            this.dtrDates.DtpBegDate.Size = new System.Drawing.Size(91, 22);
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
            this.dtrDates.DtpEndDate.Size = new System.Drawing.Size(91, 22);
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
            this.dtrDates.LblDelimiter.Size = new System.Drawing.Size(13, 16);
            this.dtrDates.LblDelimiter.TabIndex = 1;
            this.dtrDates.LblDelimiter.Text = ":";
            this.dtrDates.Location = new System.Drawing.Point(147, 3);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(222, 29);
            this.dtrDates.TabIndex = 1;
            // 
            // btnClearTerms
            // 
            this.btnClearTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTerms.FlatAppearance.BorderSize = 0;
            this.btnClearTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTerms.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClearTerms.Location = new System.Drawing.Point(704, 372);
            this.btnClearTerms.Name = "btnClearTerms";
            this.btnClearTerms.Size = new System.Drawing.Size(22, 22);
            this.btnClearTerms.TabIndex = 18;
            this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
            this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
            // 
            // lblDateActs
            // 
            this.lblDateActs.AutoSize = true;
            this.lblDateActs.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDateActs.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateActs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDateActs.Location = new System.Drawing.Point(7, 11);
            this.lblDateActs.Name = "lblDateActs";
            this.lblDateActs.Size = new System.Drawing.Size(117, 14);
            this.lblDateActs.TabIndex = 0;
            this.lblDateActs.Text = "Дата создания акта";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.cntGrids);
            this.tabData.Location = new System.Drawing.Point(4, 23);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(733, 403);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Акты";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // cntGrids
            // 
            this.cntGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cntGrids.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cntGrids.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cntGrids.Location = new System.Drawing.Point(0, 2);
            this.cntGrids.Name = "cntGrids";
            this.cntGrids.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntGrids.Panel1
            // 
            this.cntGrids.Panel1.Controls.Add(this.dgvActs);
            // 
            // cntGrids.Panel2
            // 
            this.cntGrids.Panel2.Controls.Add(this.tcActsDetails);
            this.cntGrids.Size = new System.Drawing.Size(732, 400);
            this.cntGrids.SplitterDistance = 267;
            this.cntGrids.SplitterWidth = 2;
            this.cntGrids.TabIndex = 0;
            // 
            // dgvActs
            // 
            this.dgvActs.AllowUserToAddRows = false;
            this.dgvActs.AllowUserToDeleteRows = false;
            this.dgvActs.AllowUserToOrderColumns = true;
            this.dgvActs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActs.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvActs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcConfirmedImage,
            this.dgvcDateAct,
            this.dgvcDateConfirm,
            this.dgvcInputID,
            this.dgvcOutputID,
            this.dgvcTripAlias,
            this.dgvcOwnerName,
            this.dgvcGoodStateName,
            this.dgvcUserCreateName,
            this.dgvcDateCreate,
            this.dgvcReadyForWMS,
            this.dgvcNote,
            this.dgvcERPCode,
            this.dgvcID});
            this.dgvActs.IsCheckerInclude = true;
            this.dgvActs.IsConfigInclude = true;
            this.dgvActs.IsMarkedAll = false;
            this.dgvActs.IsStatusInclude = true;
            this.dgvActs.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvActs.Location = new System.Drawing.Point(0, 0);
            this.dgvActs.MultiSelect = false;
            this.dgvActs.Name = "dgvActs";
            this.dgvActs.RangedWay = ' ';
            this.dgvActs.ReadOnly = true;
            this.dgvActs.RowHeadersWidth = 24;
            this.dgvActs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActs.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.dgvActs.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.dgvActs.Size = new System.Drawing.Size(728, 263);
            this.dgvActs.TabIndex = 11;
            this.dgvActs.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.dgvActs_CurrentRowChanged);
            this.dgvActs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActs_CellFormatting);
            // 
            // tcActsDetails
            // 
            this.tcActsDetails.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcActsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcActsDetails.Controls.Add(this.tabActsGoods);
            this.tcActsDetails.ItemSize = new System.Drawing.Size(120, 18);
            this.tcActsDetails.Location = new System.Drawing.Point(1, 1);
            this.tcActsDetails.Multiline = true;
            this.tcActsDetails.Name = "tcActsDetails";
            this.tcActsDetails.SelectedIndex = 0;
            this.tcActsDetails.Size = new System.Drawing.Size(727, 125);
            this.tcActsDetails.TabIndex = 0;
            // 
            // tabActsGoods
            // 
            this.tabActsGoods.Controls.Add(this.dgvActsGoods);
            this.tabActsGoods.Location = new System.Drawing.Point(4, 4);
            this.tabActsGoods.Name = "tabActsGoods";
            this.tabActsGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabActsGoods.Size = new System.Drawing.Size(719, 99);
            this.tabActsGoods.TabIndex = 0;
            this.tabActsGoods.Text = "Товары";
            this.tabActsGoods.UseVisualStyleBackColor = true;
            // 
            // dgvActsGoods
            // 
            this.dgvActsGoods.AllowUserToAddRows = false;
            this.dgvActsGoods.AllowUserToDeleteRows = false;
            this.dgvActsGoods.AllowUserToOrderColumns = true;
            this.dgvActsGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActsGoods.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvActsGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvActsGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActsGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvActsGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActsGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcActsGoods_GoodAlias,
            this.dgvcActsGoods_InBox,
            this.dgvcActsGoods_QntConfirmed,
            this.dgvcActsGoods_BoxConfirmed,
            this.dgvcActsGoods_PalConfirmed,
            this.dgvcActsGoods_BoxInPal,
            this.dgvcActsGoods_Weighting,
            this.dgvcActsGoods_GoodBarCode,
            this.dgvcActsGoods_GoodGroupName,
            this.dgvcActsGoods_GoodBrandName,
            this.dgvcActtsGoods_PackingID});
            this.dgvActsGoods.IsConfigInclude = true;
            this.dgvActsGoods.IsMarkedAll = false;
            this.dgvActsGoods.IsStatusInclude = true;
            this.dgvActsGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvActsGoods.Location = new System.Drawing.Point(0, -3);
            this.dgvActsGoods.MultiSelect = false;
            this.dgvActsGoods.Name = "dgvActsGoods";
            this.dgvActsGoods.RangedWay = ' ';
            this.dgvActsGoods.ReadOnly = true;
            this.dgvActsGoods.RowHeadersWidth = 24;
            this.dgvActsGoods.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.dgvActsGoods.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.dgvActsGoods.Size = new System.Drawing.Size(718, 98);
            this.dgvActsGoods.TabIndex = 14;
            this.dgvActsGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActsGoods_CellFormatting);
            // 
            // dgvcActsGoods_GoodAlias
            // 
            this.dgvcActsGoods_GoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_GoodAlias.DataPropertyName = "GoodAlias";
            this.dgvcActsGoods_GoodAlias.HeaderText = "Товар";
            this.dgvcActsGoods_GoodAlias.Name = "dgvcActsGoods_GoodAlias";
            this.dgvcActsGoods_GoodAlias.ReadOnly = true;
            this.dgvcActsGoods_GoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_GoodAlias.ToolTipText = "Товар";
            this.dgvcActsGoods_GoodAlias.Width = 250;
            // 
            // dgvcActsGoods_InBox
            // 
            this.dgvcActsGoods_InBox.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_InBox.DataPropertyName = "InBox";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.dgvcActsGoods_InBox.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvcActsGoods_InBox.HeaderText = "В кор.";
            this.dgvcActsGoods_InBox.Name = "dgvcActsGoods_InBox";
            this.dgvcActsGoods_InBox.ReadOnly = true;
            this.dgvcActsGoods_InBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_InBox.ToolTipText = "Штук/кг в коробке";
            this.dgvcActsGoods_InBox.Width = 55;
            // 
            // dgvcActsGoods_QntConfirmed
            // 
            this.dgvcActsGoods_QntConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_QntConfirmed.DataPropertyName = "QntConfirmed";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.dgvcActsGoods_QntConfirmed.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvcActsGoods_QntConfirmed.HeaderText = "Штук";
            this.dgvcActsGoods_QntConfirmed.Name = "dgvcActsGoods_QntConfirmed";
            this.dgvcActsGoods_QntConfirmed.ReadOnly = true;
            this.dgvcActsGoods_QntConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_QntConfirmed.ToolTipText = "Штук";
            this.dgvcActsGoods_QntConfirmed.Width = 90;
            // 
            // dgvcActsGoods_BoxConfirmed
            // 
            this.dgvcActsGoods_BoxConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_BoxConfirmed.DataPropertyName = "BoxConfirmed";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N1";
            this.dgvcActsGoods_BoxConfirmed.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcActsGoods_BoxConfirmed.HeaderText = "Коробок";
            this.dgvcActsGoods_BoxConfirmed.Name = "dgvcActsGoods_BoxConfirmed";
            this.dgvcActsGoods_BoxConfirmed.ReadOnly = true;
            this.dgvcActsGoods_BoxConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_BoxConfirmed.ToolTipText = "Коробок";
            this.dgvcActsGoods_BoxConfirmed.Width = 80;
            // 
            // dgvcActsGoods_PalConfirmed
            // 
            this.dgvcActsGoods_PalConfirmed.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_PalConfirmed.DataPropertyName = "PalConfirmed";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.dgvcActsGoods_PalConfirmed.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcActsGoods_PalConfirmed.HeaderText = "Паллет";
            this.dgvcActsGoods_PalConfirmed.Name = "dgvcActsGoods_PalConfirmed";
            this.dgvcActsGoods_PalConfirmed.ReadOnly = true;
            this.dgvcActsGoods_PalConfirmed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_PalConfirmed.ToolTipText = "Паллет";
            this.dgvcActsGoods_PalConfirmed.Width = 60;
            // 
            // dgvcActsGoods_BoxInPal
            // 
            this.dgvcActsGoods_BoxInPal.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_BoxInPal.DataPropertyName = "BoxInPal";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            this.dgvcActsGoods_BoxInPal.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcActsGoods_BoxInPal.HeaderText = "Кор.на пал.";
            this.dgvcActsGoods_BoxInPal.Name = "dgvcActsGoods_BoxInPal";
            this.dgvcActsGoods_BoxInPal.ReadOnly = true;
            this.dgvcActsGoods_BoxInPal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_BoxInPal.ToolTipText = "Коробок на паллете";
            this.dgvcActsGoods_BoxInPal.Width = 70;
            // 
            // dgvcActsGoods_Weighting
            // 
            this.dgvcActsGoods_Weighting.DataPropertyName = "Weighting";
            this.dgvcActsGoods_Weighting.HeaderText = "Вес";
            this.dgvcActsGoods_Weighting.Name = "dgvcActsGoods_Weighting";
            this.dgvcActsGoods_Weighting.ReadOnly = true;
            this.dgvcActsGoods_Weighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_Weighting.ToolTipText = "Весовой товар?";
            this.dgvcActsGoods_Weighting.Visible = false;
            this.dgvcActsGoods_Weighting.Width = 50;
            // 
            // dgvcActsGoods_GoodBarCode
            // 
            this.dgvcActsGoods_GoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_GoodBarCode.DataPropertyName = "GoodBarCode";
            this.dgvcActsGoods_GoodBarCode.HeaderText = "ШК товара";
            this.dgvcActsGoods_GoodBarCode.Name = "dgvcActsGoods_GoodBarCode";
            this.dgvcActsGoods_GoodBarCode.ReadOnly = true;
            this.dgvcActsGoods_GoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_GoodBarCode.Visible = false;
            this.dgvcActsGoods_GoodBarCode.Width = 130;
            // 
            // dgvcActsGoods_GoodGroupName
            // 
            this.dgvcActsGoods_GoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_GoodGroupName.DataPropertyName = "GoodGroupName";
            this.dgvcActsGoods_GoodGroupName.HeaderText = "Товарная группа";
            this.dgvcActsGoods_GoodGroupName.Name = "dgvcActsGoods_GoodGroupName";
            this.dgvcActsGoods_GoodGroupName.ReadOnly = true;
            this.dgvcActsGoods_GoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_GoodGroupName.Width = 150;
            // 
            // dgvcActsGoods_GoodBrandName
            // 
            this.dgvcActsGoods_GoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActsGoods_GoodBrandName.DataPropertyName = "GoodBrandName";
            this.dgvcActsGoods_GoodBrandName.HeaderText = "Товарный бренд";
            this.dgvcActsGoods_GoodBrandName.Name = "dgvcActsGoods_GoodBrandName";
            this.dgvcActsGoods_GoodBrandName.ReadOnly = true;
            this.dgvcActsGoods_GoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActsGoods_GoodBrandName.Width = 150;
            // 
            // dgvcActtsGoods_PackingID
            // 
            this.dgvcActtsGoods_PackingID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcActtsGoods_PackingID.DataPropertyName = "PackingID";
            this.dgvcActtsGoods_PackingID.HeaderText = "PackingID";
            this.dgvcActtsGoods_PackingID.Name = "dgvcActtsGoods_PackingID";
            this.dgvcActtsGoods_PackingID.ReadOnly = true;
            this.dgvcActtsGoods_PackingID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcActtsGoods_PackingID.Visible = false;
            // 
            // btnService
            // 
            this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnService.Image = global::Logistics.Properties.Resources.Service;
            this.btnService.Location = new System.Drawing.Point(656, 439);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(30, 30);
            this.btnService.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnService, "Дополнительно");
            this.btnService.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 439);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(30, 30);
            this.btnHelp.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnHelp, "Помощь");
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.Location = new System.Drawing.Point(606, 439);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удаление акта");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.Location = new System.Drawing.Point(506, 439);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавление акта");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::Logistics.Properties.Resources.Exit;
            this.btnCancel.Location = new System.Drawing.Point(706, 439);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(30, 30);
            this.btnCancel.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnCancel, "Выход");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(556, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование акта");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tmrRestore
            // 
            this.tmrRestore.Tick += new System.EventHandler(this.tmrRestore_Tick);
            // 
            // dgvcConfirmedImage
            // 
            this.dgvcConfirmedImage.DataPropertyName = "IsConfirmed";
            this.dgvcConfirmedImage.HeaderText = "Подтв.";
            this.dgvcConfirmedImage.Name = "dgvcConfirmedImage";
            this.dgvcConfirmedImage.ReadOnly = true;
            this.dgvcConfirmedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcConfirmedImage.ToolTipText = "Акт подтвержден?";
            this.dgvcConfirmedImage.Width = 52;
            // 
            // dgvcDateAct
            // 
            this.dgvcDateAct.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDateAct.DataPropertyName = "DateAct";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.dgvcDateAct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcDateAct.HeaderText = "Дата";
            this.dgvcDateAct.Name = "dgvcDateAct";
            this.dgvcDateAct.ReadOnly = true;
            this.dgvcDateAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDateAct.ToolTipText = "Дата акта";
            this.dgvcDateAct.Width = 80;
            // 
            // dgvcDateConfirm
            // 
            this.dgvcDateConfirm.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDateConfirm.DataPropertyName = "DateConfirm";
            dataGridViewCellStyle3.Format = "dd.MM.yyyy HH:mm";
            this.dgvcDateConfirm.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvcDateConfirm.HeaderText = "Дата подтв.";
            this.dgvcDateConfirm.Name = "dgvcDateConfirm";
            this.dgvcDateConfirm.ReadOnly = true;
            this.dgvcDateConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDateConfirm.ToolTipText = "Дата-время подтверждения";
            this.dgvcDateConfirm.Width = 110;
            // 
            // dgvcInputID
            // 
            this.dgvcInputID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcInputID.DataPropertyName = "InputID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcInputID.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcInputID.HeaderText = "Приход";
            this.dgvcInputID.Name = "dgvcInputID";
            this.dgvcInputID.ReadOnly = true;
            this.dgvcInputID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcInputID.ToolTipText = "Код прихода";
            this.dgvcInputID.Width = 60;
            // 
            // dgvcOutputID
            // 
            this.dgvcOutputID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcOutputID.DataPropertyName = "OutputID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcOutputID.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcOutputID.HeaderText = "Расход";
            this.dgvcOutputID.Name = "dgvcOutputID";
            this.dgvcOutputID.ReadOnly = true;
            this.dgvcOutputID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcOutputID.ToolTipText = "Код расхода";
            this.dgvcOutputID.Width = 60;
            // 
            // dgvcTripAlias
            // 
            this.dgvcTripAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTripAlias.DataPropertyName = "TripAlias";
            this.dgvcTripAlias.HeaderText = "Рейс";
            this.dgvcTripAlias.Name = "dgvcTripAlias";
            this.dgvcTripAlias.ReadOnly = true;
            this.dgvcTripAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTripAlias.Width = 200;
            // 
            // dgvcOwnerName
            // 
            this.dgvcOwnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcOwnerName.DataPropertyName = "OwnerName";
            this.dgvcOwnerName.HeaderText = "Владелец";
            this.dgvcOwnerName.Name = "dgvcOwnerName";
            this.dgvcOwnerName.ReadOnly = true;
            this.dgvcOwnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcOwnerName.Width = 150;
            // 
            // dgvcGoodStateName
            // 
            this.dgvcGoodStateName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcGoodStateName.DataPropertyName = "GoodStateName";
            this.dgvcGoodStateName.HeaderText = "Состояние товара";
            this.dgvcGoodStateName.Name = "dgvcGoodStateName";
            this.dgvcGoodStateName.ReadOnly = true;
            this.dgvcGoodStateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // dgvcUserCreateName
            // 
            this.dgvcUserCreateName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcUserCreateName.DataPropertyName = "UserCreateName";
            this.dgvcUserCreateName.HeaderText = "Кем создано";
            this.dgvcUserCreateName.Name = "dgvcUserCreateName";
            this.dgvcUserCreateName.ReadOnly = true;
            this.dgvcUserCreateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcUserCreateName.ToolTipText = "Пользователь, создавший акт";
            // 
            // dgvcDateCreate
            // 
            this.dgvcDateCreate.DataPropertyName = "DateCreate";
            dataGridViewCellStyle6.Format = "dd.MM.yyyy HH:mm";
            this.dgvcDateCreate.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvcDateCreate.HeaderText = "Дата созд.";
            this.dgvcDateCreate.Name = "dgvcDateCreate";
            this.dgvcDateCreate.ReadOnly = true;
            this.dgvcDateCreate.ToolTipText = "Дата-время создания";
            this.dgvcDateCreate.Width = 110;
            // 
            // dgvcReadyForWMS
            // 
            this.dgvcReadyForWMS.DataPropertyName = "ReadyForWMS";
            this.dgvcReadyForWMS.HeaderText = "Для скл.";
            this.dgvcReadyForWMS.Name = "dgvcReadyForWMS";
            this.dgvcReadyForWMS.ReadOnly = true;
            this.dgvcReadyForWMS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcReadyForWMS.ToolTipText = "Акт готов для передачи в складскую систему?";
            this.dgvcReadyForWMS.Width = 50;
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
            // dgvcERPCode
            // 
            this.dgvcERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcERPCode.DataPropertyName = "ERPCode";
            this.dgvcERPCode.HeaderText = "ERPCode";
            this.dgvcERPCode.Name = "dgvcERPCode";
            this.dgvcERPCode.ReadOnly = true;
            this.dgvcERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcERPCode.ToolTipText = "Код в host-системе";
            // 
            // dgvcID
            // 
            this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcID.DataPropertyName = "ID";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dgvcID.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvcID.HeaderText = "ID";
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.ToolTipText = "Код акта";
            this.dgvcID.Width = 50;
            // 
            // frmActs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 474);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tcList);
            this.hpHelp.SetHelpKeyword(this, "102");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.hpHelp.SetHelpString(this, "");
            this.IsWaitLoading = true;
            this.LastGrid = this.dgvActs;
            this.MinimumSize = new System.Drawing.Size(750, 501);
            this.Name = "frmActs";
            this.hpHelp.SetShowHelp(this, true);
            this.Text = "Акты";
            this.Load += new System.EventHandler(this.frmActs_Load);
            this.tcList.ResumeLayout(false);
            this.tabTerms.ResumeLayout(false);
            this.cntTerms.ResumeLayout(false);
            this.cntTerms.PerformLayout();
            this.ucSelectRecordIDForm_Packings.ResumeLayout(false);
            this.ucSelectRecordIDForm_Packings.PerformLayout();
            this.ucSelectRecordID_Hosts.ResumeLayout(false);
            this.ucSelectRecordID_Hosts.PerformLayout();
            this.ucSelectRecordID_Owners.ResumeLayout(false);
            this.ucSelectRecordID_Owners.PerformLayout();
            this.rfmPanel1.ResumeLayout(false);
            this.rfmPanel1.PerformLayout();
            this.pnlIsConfirmed.ResumeLayout(false);
            this.pnlIsConfirmed.PerformLayout();
            this.pnlTripExists.ResumeLayout(false);
            this.pnlTripExists.PerformLayout();
            this.pnlReadyForWMS.ResumeLayout(false);
            this.pnlReadyForWMS.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.cntGrids.Panel1.ResumeLayout(false);
            this.cntGrids.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cntGrids)).EndInit();
            this.cntGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActs)).EndInit();
            this.tcActsDetails.ResumeLayout(false);
            this.tabActsGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActsGoods)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnCancel;
		private RFMBaseClasses.RFMTabPage tabData;
		private RFMBaseClasses.RFMSplitContainer cntGrids;
        private RFMBaseClasses.RFMDataGridView dgvActs;
        private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMButton btnDelete;
        private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMTabControl tcActsDetails;
		private RFMBaseClasses.RFMTabPage tabActsGoods;
		private RFMBaseClasses.RFMButton btnClearTerms;
        private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblDateActs;
        private RFMBaseClasses.RFMDateRange dtrDates;
        private RFMBaseClasses.RFMTimer tmrRestore;
		private RFMBaseClasses.RFMDataGridView dgvActsGoods;
        private RFMBaseClasses.RFMLabel lblPutExists;
        private RFMBaseClasses.RFMPanel pnlTripExists;
        private RFMBaseClasses.RFMRadioButton optPutExistsAll;
        private RFMBaseClasses.RFMRadioButton optPutExistsNot;
        private RFMBaseClasses.RFMRadioButton optPutExists;
        private RFMBaseClasses.RFMLabel lblReadyForWMS;
        private RFMBaseClasses.RFMPanel pnlReadyForWMS;
        private RFMBaseClasses.RFMRadioButton optReadyForWMSNot;
        private RFMBaseClasses.RFMRadioButton optReadyForWMS;
		private RFMBaseClasses.RFMRadioButton optReadyForWMSAll;
        private RFMBaseClasses.RFMLabel lblOwners;
		private RFMBaseClasses.RFMLabel lblPackings;
        private RFMBaseClasses.RFMLabel lblIsConfirmed;
        private RFMBaseClasses.RFMPanel pnlIsConfirmed;
        private RFMBaseClasses.RFMRadioButton optIsConfirmedNot;
        private RFMBaseClasses.RFMRadioButton optIsConfirmed;
        private RFMBaseClasses.RFMRadioButton optIsConfirmedAll;
        private RFMBaseClasses.RFMCheckBox chkOutput;
        private RFMBaseClasses.RFMCheckBox chkInput;
        private RFMBaseClasses.RFMLabel lblTripExists;
        private RFMBaseClasses.RFMPanel rfmPanel1;
        private RFMBaseClasses.RFMRadioButton optTripExistsAll;
        private RFMBaseClasses.RFMRadioButton optTripExistsNot;
		private RFMBaseClasses.RFMRadioButton optTripExists;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_GoodAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_InBox;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_QntConfirmed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_BoxConfirmed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_PalConfirmed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_BoxInPal;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcActsGoods_Weighting;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_GoodBarCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_GoodGroupName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActsGoods_GoodBrandName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcActtsGoods_PackingID;
		private RFMBaseClasses.RFMCheckBox chkShowSelectedGoodsOnly;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Owners;
		private RFMBaseClasses.RFMLabel lblHosts;
        private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Hosts;
		private RFMBaseClasses.RFMSelectRecordIDForm ucSelectRecordIDForm_Packings;
        private RFMBaseClasses.RFMDataGridViewImageColumn dgvcConfirmedImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateAct;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateConfirm;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcInputID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcOutputID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcTripAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcOwnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGoodStateName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcUserCreateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDateCreate;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcReadyForWMS;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcNote;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
	}
}