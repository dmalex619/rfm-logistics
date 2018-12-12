namespace Logistics 
{
	partial class frmSelectOnePartner 
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectOnePartner));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnGo = new RFMBaseClasses.RFMButton();
			this.btnFilter = new RFMBaseClasses.RFMButton();
			this.btnClear = new RFMBaseClasses.RFMButton();
			this.pnlFilter = new RFMBaseClasses.RFMPanel();
			this.ucSelectRecordID_Hosts = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.lblHosts = new RFMBaseClasses.RFMLabel();
			this.ucSelectRecordID_PartnersRoots = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.lblPartnersRoots = new RFMBaseClasses.RFMLabel();
			this.chkPerversion = new RFMBaseClasses.RFMCheckBox();
			this.chkActual = new RFMBaseClasses.RFMCheckBox();
			this.lblInnContext = new RFMBaseClasses.RFMLabel();
			this.txtInnContext = new RFMBaseClasses.RFMTextBox();
			this.lblNameContext = new RFMBaseClasses.RFMLabel();
			this.txtNameContext = new RFMBaseClasses.RFMTextBox();
			this.chkSeparatePicking = new RFMBaseClasses.RFMCheckBox();
			this.chkOwner = new RFMBaseClasses.RFMCheckBox();
			this.chkTransport = new RFMBaseClasses.RFMCheckBox();
			this.chkSupplier = new RFMBaseClasses.RFMCheckBox();
			this.chkCustomer = new RFMBaseClasses.RFMCheckBox();
			this.ucSelectRecordID_Zones = new RFMBaseClasses.RFMSelectRecordIDTree();
			this.lblZones = new RFMBaseClasses.RFMLabel();
			this.dgvData = new RFMBaseClasses.RFMDataGridView();
			this.grсName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcZoneName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcDeliveryAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcDeliveryPassage = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcDeliveryRestriction = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcDistance = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPermitLevelName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnerRootName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcContactInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcGravity = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcActual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcIsCustomer = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcIsShipper = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcIsSupplier = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcIsOwner = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcSeparatePicking = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcPartnersGoodsExists = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.pnlGrids = new RFMBaseClasses.RFMSplitContainer();
			this.dgvPartnersDetails = new RFMBaseClasses.RFMDataGridView();
			this.tmrRestore = new RFMBaseClasses.RFMTimer();
			this.dgvcPartnersDetails_LegalName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_LegalAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_FactName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_BankName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_PAccount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_Inn = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_AutoSelected = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.dgvcPartnersDetails_VeterinaryPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_VeterinaryPermission = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPartnersDetails_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.pnlFilter.SuspendLayout();
			this.ucSelectRecordID_Hosts.SuspendLayout();
			this.ucSelectRecordID_PartnersRoots.SuspendLayout();
			this.ucSelectRecordID_Zones.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.pnlGrids.Panel1.SuspendLayout();
			this.pnlGrids.Panel2.SuspendLayout();
			this.pnlGrids.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvPartnersDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(4, 470);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(30, 30);
			this.btnHelp.TabIndex = 8;
			this.ttToolTip.SetToolTip(this.btnHelp, "Помощь");
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.No;
			this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
			this.btnExit.Location = new System.Drawing.Point(658, 470);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(30, 30);
			this.btnExit.TabIndex = 7;
			this.ttToolTip.SetToolTip(this.btnExit, "Выход");
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnGo
			// 
			this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnGo.Image = global::Logistics.Properties.Resources.Go;
			this.btnGo.Location = new System.Drawing.Point(615, 470);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(30, 30);
			this.btnGo.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnGo, "Выбор");
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFilter.Image = global::Logistics.Properties.Resources.Go_Blue;
			this.btnFilter.Location = new System.Drawing.Point(615, 115);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(30, 30);
			this.btnFilter.TabIndex = 17;
			this.ttToolTip.SetToolTip(this.btnFilter, "Показать данные о партнерах, соответствующие условиям (<F5>)");
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Image = global::Logistics.Properties.Resources.DeleteAll;
			this.btnClear.Location = new System.Drawing.Point(651, 115);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(30, 30);
			this.btnClear.TabIndex = 18;
			this.ttToolTip.SetToolTip(this.btnClear, "Очистить условия");
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// pnlFilter
			// 
			this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlFilter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlFilter.Controls.Add(this.ucSelectRecordID_Hosts);
			this.pnlFilter.Controls.Add(this.lblHosts);
			this.pnlFilter.Controls.Add(this.ucSelectRecordID_PartnersRoots);
			this.pnlFilter.Controls.Add(this.lblPartnersRoots);
			this.pnlFilter.Controls.Add(this.chkPerversion);
			this.pnlFilter.Controls.Add(this.chkActual);
			this.pnlFilter.Controls.Add(this.lblInnContext);
			this.pnlFilter.Controls.Add(this.txtInnContext);
			this.pnlFilter.Controls.Add(this.lblNameContext);
			this.pnlFilter.Controls.Add(this.txtNameContext);
			this.pnlFilter.Controls.Add(this.chkSeparatePicking);
			this.pnlFilter.Controls.Add(this.chkOwner);
			this.pnlFilter.Controls.Add(this.chkTransport);
			this.pnlFilter.Controls.Add(this.chkSupplier);
			this.pnlFilter.Controls.Add(this.chkCustomer);
			this.pnlFilter.Controls.Add(this.btnClear);
			this.pnlFilter.Controls.Add(this.btnFilter);
			this.pnlFilter.Controls.Add(this.ucSelectRecordID_Zones);
			this.pnlFilter.Controls.Add(this.lblZones);
			this.pnlFilter.Location = new System.Drawing.Point(2, 3);
			this.pnlFilter.Name = "pnlFilter";
			this.pnlFilter.Size = new System.Drawing.Size(688, 151);
			this.pnlFilter.TabIndex = 0;
			// 
			// ucSelectRecordID_Hosts
			// 
			this.ucSelectRecordID_Hosts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// ucSelectRecordID_Hosts.btnClear
			// 
			this.ucSelectRecordID_Hosts.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Hosts.BtnClear.Image = global::Logistics.Properties.Resources.DeleteAll;
			this.ucSelectRecordID_Hosts.BtnClear.Location = new System.Drawing.Point(245, 0);
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
			this.ucSelectRecordID_Hosts.BtnSelect.Location = new System.Drawing.Point(219, 0);
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
			this.ucSelectRecordID_Hosts.Location = new System.Drawing.Point(333, 119);
			this.ucSelectRecordID_Hosts.MarkedCount = 0;
			this.ucSelectRecordID_Hosts.Name = "ucSelectRecordID_Hosts";
			this.ucSelectRecordID_Hosts.Size = new System.Drawing.Size(272, 24);
			this.ucSelectRecordID_Hosts.TabIndex = 16;
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
			this.ucSelectRecordID_Hosts.TxtData.Size = new System.Drawing.Size(217, 22);
			this.ucSelectRecordID_Hosts.TxtData.TabIndex = 0;
			this.ucSelectRecordID_Hosts.СolumnsData.AddRange(new string[] {
            "Name, Хост"});
			// 
			// lblHosts
			// 
			this.lblHosts.AutoSize = true;
			this.lblHosts.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblHosts.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblHosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblHosts.Location = new System.Drawing.Point(297, 124);
			this.lblHosts.Name = "lblHosts";
			this.lblHosts.Size = new System.Drawing.Size(33, 14);
			this.lblHosts.TabIndex = 15;
			this.lblHosts.Text = "Хост";
			// 
			// ucSelectRecordID_PartnersRoots
			// 
			this.ucSelectRecordID_PartnersRoots.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// ucSelectRecordID_PartnersRoots.btnClear
			// 
			this.ucSelectRecordID_PartnersRoots.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_PartnersRoots.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_PartnersRoots.btnClear.Image")));
			this.ucSelectRecordID_PartnersRoots.BtnClear.Location = new System.Drawing.Point(247, 0);
			this.ucSelectRecordID_PartnersRoots.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_PartnersRoots.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_PartnersRoots.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_PartnersRoots.BtnClear, "Очистка выбора объединений");
			this.ucSelectRecordID_PartnersRoots.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_PartnersRoots.btnSelect
			// 
			this.ucSelectRecordID_PartnersRoots.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_PartnersRoots.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_PartnersRoots.btnSelect.Image")));
			this.ucSelectRecordID_PartnersRoots.BtnSelect.Location = new System.Drawing.Point(222, 0);
			this.ucSelectRecordID_PartnersRoots.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_PartnersRoots.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_PartnersRoots.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_PartnersRoots.BtnSelect, "Выбор объединений");
			this.ucSelectRecordID_PartnersRoots.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_PartnersRoots.ExpSort = "Name";
			this.ucSelectRecordID_PartnersRoots.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_PartnersRoots.IsActualOnly = true;
			this.ucSelectRecordID_PartnersRoots.IsSaveMark = true;
			this.ucSelectRecordID_PartnersRoots.IsUseMark = true;
			this.ucSelectRecordID_PartnersRoots.Location = new System.Drawing.Point(411, 2);
			this.ucSelectRecordID_PartnersRoots.MarkedCount = 0;
			this.ucSelectRecordID_PartnersRoots.Name = "ucSelectRecordID_PartnersRoots";
			this.ucSelectRecordID_PartnersRoots.Size = new System.Drawing.Size(275, 24);
			this.ucSelectRecordID_PartnersRoots.TabIndex = 6;
			this.ucSelectRecordID_PartnersRoots.TableColumnName = "Name";
			// 
			// ucSelectRecordID_PartnersRoots.txtData
			// 
			this.ucSelectRecordID_PartnersRoots.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_PartnersRoots.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_PartnersRoots.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_PartnersRoots.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_PartnersRoots.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_PartnersRoots.TxtData.Location = new System.Drawing.Point(0, 1);
			this.ucSelectRecordID_PartnersRoots.TxtData.MaxLength = 128;
			this.ucSelectRecordID_PartnersRoots.TxtData.Name = "txtData";
			this.ucSelectRecordID_PartnersRoots.TxtData.ReadOnly = true;
			this.ucSelectRecordID_PartnersRoots.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_PartnersRoots.TxtData.TabIndex = 0;
			this.ucSelectRecordID_PartnersRoots.СolumnsData.AddRange(new string[] {
            "Name, Владелец",
            "Actual, Акт."});
			// 
			// lblPartnersRoots
			// 
			this.lblPartnersRoots.AutoSize = true;
			this.lblPartnersRoots.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPartnersRoots.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPartnersRoots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPartnersRoots.Location = new System.Drawing.Point(324, 7);
			this.lblPartnersRoots.Name = "lblPartnersRoots";
			this.lblPartnersRoots.Size = new System.Drawing.Size(86, 14);
			this.lblPartnersRoots.TabIndex = 5;
			this.lblPartnersRoots.Text = "Объединение";
			// 
			// chkPerversion
			// 
			this.chkPerversion.AutoSize = true;
			this.chkPerversion.Location = new System.Drawing.Point(7, 95);
			this.chkPerversion.Name = "chkPerversion";
			this.chkPerversion.Size = new System.Drawing.Size(163, 18);
			this.chkPerversion.TabIndex = 11;
			this.chkPerversion.Text = "Спец. данные о товарах";
			this.chkPerversion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkPerversion.UseVisualStyleBackColor = true;
			// 
			// chkActual
			// 
			this.chkActual.AutoSize = true;
			this.chkActual.Checked = true;
			this.chkActual.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkActual.Location = new System.Drawing.Point(7, 122);
			this.chkActual.Name = "chkActual";
			this.chkActual.Size = new System.Drawing.Size(103, 18);
			this.chkActual.TabIndex = 12;
			this.chkActual.Text = "Актуальность";
			this.chkActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkActual.UseVisualStyleBackColor = true;
			// 
			// lblInnContext
			// 
			this.lblInnContext.AutoSize = true;
			this.lblInnContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblInnContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblInnContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblInnContext.Location = new System.Drawing.Point(297, 95);
			this.lblInnContext.Name = "lblInnContext";
			this.lblInnContext.Size = new System.Drawing.Size(96, 14);
			this.lblInnContext.TabIndex = 13;
			this.lblInnContext.Text = "ИНН (контекст)";
			// 
			// txtInnContext
			// 
			this.txtInnContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtInnContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtInnContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtInnContext.Location = new System.Drawing.Point(399, 90);
			this.txtInnContext.Name = "txtInnContext";
			this.txtInnContext.Size = new System.Drawing.Size(282, 22);
			this.txtInnContext.TabIndex = 14;
			// 
			// lblNameContext
			// 
			this.lblNameContext.AutoSize = true;
			this.lblNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblNameContext.Location = new System.Drawing.Point(4, 71);
			this.lblNameContext.Name = "lblNameContext";
			this.lblNameContext.Size = new System.Drawing.Size(155, 14);
			this.lblNameContext.TabIndex = 9;
			this.lblNameContext.Text = "Наименование (контекст)";
			// 
			// txtNameContext
			// 
			this.txtNameContext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtNameContext.Location = new System.Drawing.Point(165, 67);
			this.txtNameContext.Name = "txtNameContext";
			this.txtNameContext.Size = new System.Drawing.Size(516, 22);
			this.txtNameContext.TabIndex = 10;
			// 
			// chkSeparatePicking
			// 
			this.chkSeparatePicking.AutoSize = true;
			this.chkSeparatePicking.Enabled = false;
			this.chkSeparatePicking.Location = new System.Drawing.Point(149, 28);
			this.chkSeparatePicking.Name = "chkSeparatePicking";
			this.chkSeparatePicking.Size = new System.Drawing.Size(154, 18);
			this.chkSeparatePicking.TabIndex = 4;
			this.chkSeparatePicking.Text = "Раздельное хранение ";
			this.chkSeparatePicking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkSeparatePicking.UseVisualStyleBackColor = true;
			// 
			// chkOwner
			// 
			this.chkOwner.AutoSize = true;
			this.chkOwner.Location = new System.Drawing.Point(149, 6);
			this.chkOwner.Name = "chkOwner";
			this.chkOwner.Size = new System.Drawing.Size(123, 18);
			this.chkOwner.TabIndex = 3;
			this.chkOwner.Text = "Владелец товара";
			this.chkOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkOwner.UseVisualStyleBackColor = true;
			this.chkOwner.CheckedChanged += new System.EventHandler(this.chkOwner_CheckedChanged);
			// 
			// chkTransport
			// 
			this.chkTransport.AutoSize = true;
			this.chkTransport.Location = new System.Drawing.Point(7, 50);
			this.chkTransport.Name = "chkTransport";
			this.chkTransport.Size = new System.Drawing.Size(130, 18);
			this.chkTransport.TabIndex = 2;
			this.chkTransport.Text = "Трансп. компания";
			this.chkTransport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkTransport.UseVisualStyleBackColor = true;
			// 
			// chkSupplier
			// 
			this.chkSupplier.AutoSize = true;
			this.chkSupplier.Location = new System.Drawing.Point(7, 28);
			this.chkSupplier.Name = "chkSupplier";
			this.chkSupplier.Size = new System.Drawing.Size(87, 18);
			this.chkSupplier.TabIndex = 1;
			this.chkSupplier.Text = "Поставщик";
			this.chkSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkSupplier.UseVisualStyleBackColor = true;
			// 
			// chkCustomer
			// 
			this.chkCustomer.AutoSize = true;
			this.chkCustomer.Location = new System.Drawing.Point(7, 6);
			this.chkCustomer.Name = "chkCustomer";
			this.chkCustomer.Size = new System.Drawing.Size(92, 18);
			this.chkCustomer.TabIndex = 0;
			this.chkCustomer.Text = "Покупатель";
			this.chkCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkCustomer.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_Zones
			// 
			this.ucSelectRecordID_Zones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			// 
			// ucSelectRecordID_Zones.btnClear
			// 
			this.ucSelectRecordID_Zones.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Zones.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Zones.btnClear.Image")));
			this.ucSelectRecordID_Zones.BtnClear.Location = new System.Drawing.Point(247, 0);
			this.ucSelectRecordID_Zones.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_Zones.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Zones.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Zones.BtnClear, "Очистка выбора зон");
			this.ucSelectRecordID_Zones.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_Zones.btnSelect
			// 
			this.ucSelectRecordID_Zones.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Zones.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Zones.btnSelect.Image")));
			this.ucSelectRecordID_Zones.BtnSelect.Location = new System.Drawing.Point(222, 0);
			this.ucSelectRecordID_Zones.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_Zones.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Zones.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Zones.BtnSelect, "Выбор зон");
			this.ucSelectRecordID_Zones.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_Zones.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_Zones.IsSaveMark = true;
			this.ucSelectRecordID_Zones.IsUseMark = true;
			this.ucSelectRecordID_Zones.Location = new System.Drawing.Point(411, 26);
			this.ucSelectRecordID_Zones.MarkedCount = 0;
			this.ucSelectRecordID_Zones.Name = "ucSelectRecordID_Zones";
			this.ucSelectRecordID_Zones.Size = new System.Drawing.Size(275, 24);
			this.ucSelectRecordID_Zones.TabIndex = 8;
			this.ucSelectRecordID_Zones.TableColumnName = "Name";
			// 
			// ucSelectRecordID_Zones.txtData
			// 
			this.ucSelectRecordID_Zones.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Zones.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_Zones.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_Zones.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_Zones.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_Zones.TxtData.Location = new System.Drawing.Point(0, 1);
			this.ucSelectRecordID_Zones.TxtData.Name = "txtData";
			this.ucSelectRecordID_Zones.TxtData.ReadOnly = true;
			this.ucSelectRecordID_Zones.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_Zones.TxtData.TabIndex = 3;
			// 
			// lblZones
			// 
			this.lblZones.AutoSize = true;
			this.lblZones.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblZones.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblZones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblZones.Location = new System.Drawing.Point(324, 30);
			this.lblZones.Name = "lblZones";
			this.lblZones.Size = new System.Drawing.Size(33, 14);
			this.lblZones.TabIndex = 7;
			this.lblZones.Text = "Зона";
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToOrderColumns = true;
			this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grсName,
            this.dgvcZoneName,
            this.dgvcDeliveryAddress,
            this.dgvcDeliveryPassage,
            this.dgvcDeliveryRestriction,
            this.dgvcDistance,
            this.dgvcPermitLevelName,
            this.dgvcPartnerRootName,
            this.dgvcContactInfo,
            this.dgvcGravity,
            this.dgvcActual,
            this.dgvcIsCustomer,
            this.dgvcIsShipper,
            this.dgvcIsSupplier,
            this.dgvcIsOwner,
            this.dgvcSeparatePicking,
            this.dgvcPartnersGoodsExists,
            this.dgvcERPCode,
            this.dgvcID});
			this.dgvData.IsConfigInclude = true;
			this.dgvData.IsMarkedAll = false;
			this.dgvData.IsUseConfig = false;
			this.dgvData.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvData.Location = new System.Drawing.Point(-1, -1);
			this.dgvData.MultiSelect = false;
			this.dgvData.Name = "dgvData";
			this.dgvData.RangedWay = ' ';
			this.dgvData.ReadOnly = true;
			this.dgvData.RowHeadersWidth = 24;
			this.dgvData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ShowEditingIcon = false;
			this.dgvData.Size = new System.Drawing.Size(687, 228);
			this.dgvData.TabIndex = 1;
			this.dgvData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.dgvData_CurrentRowChanged);
			this.dgvData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvData_CellFormatting);
			// 
			// grсName
			// 
			this.grсName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grсName.DataPropertyName = "Name";
			this.grсName.HeaderText = "Наименование";
			this.grсName.Name = "grсName";
			this.grсName.ReadOnly = true;
			this.grсName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grсName.Width = 200;
			// 
			// dgvcZoneName
			// 
			this.dgvcZoneName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcZoneName.DataPropertyName = "ZoneName";
			this.dgvcZoneName.HeaderText = "Зона";
			this.dgvcZoneName.Name = "dgvcZoneName";
			this.dgvcZoneName.ReadOnly = true;
			this.dgvcZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// dgvcDeliveryAddress
			// 
			this.dgvcDeliveryAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcDeliveryAddress.DataPropertyName = "DeliveryAddress";
			this.dgvcDeliveryAddress.HeaderText = "Адрес доставки";
			this.dgvcDeliveryAddress.Name = "dgvcDeliveryAddress";
			this.dgvcDeliveryAddress.ReadOnly = true;
			this.dgvcDeliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcDeliveryAddress.Width = 200;
			// 
			// dgvcDeliveryPassage
			// 
			this.dgvcDeliveryPassage.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcDeliveryPassage.DataPropertyName = "DeliveryPassage";
			this.dgvcDeliveryPassage.HeaderText = "Проезд";
			this.dgvcDeliveryPassage.Name = "dgvcDeliveryPassage";
			this.dgvcDeliveryPassage.ReadOnly = true;
			this.dgvcDeliveryPassage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcDeliveryPassage.Width = 200;
			// 
			// dgvcDeliveryRestriction
			// 
			this.dgvcDeliveryRestriction.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcDeliveryRestriction.DataPropertyName = "DeliveryRestriction";
			this.dgvcDeliveryRestriction.HeaderText = "Ограничения по доставке";
			this.dgvcDeliveryRestriction.Name = "dgvcDeliveryRestriction";
			this.dgvcDeliveryRestriction.ReadOnly = true;
			this.dgvcDeliveryRestriction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcDeliveryRestriction.Width = 200;
			// 
			// dgvcDistance
			// 
			this.dgvcDistance.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcDistance.DataPropertyName = "Distance";
			this.dgvcDistance.HeaderText = "Расст.";
			this.dgvcDistance.Name = "dgvcDistance";
			this.dgvcDistance.ReadOnly = true;
			this.dgvcDistance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcDistance.ToolTipText = "Расстояние до клиента, км";
			this.dgvcDistance.Width = 80;
			// 
			// dgvcPermitLevelName
			// 
			this.dgvcPermitLevelName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPermitLevelName.DataPropertyName = "PermitLevelName";
			this.dgvcPermitLevelName.HeaderText = "Разрешение";
			this.dgvcPermitLevelName.Name = "dgvcPermitLevelName";
			this.dgvcPermitLevelName.ReadOnly = true;
			this.dgvcPermitLevelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPermitLevelName.ToolTipText = "Разрешение на проезд";
			// 
			// dgvcPartnerRootName
			// 
			this.dgvcPartnerRootName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnerRootName.DataPropertyName = "PartnerRootName";
			this.dgvcPartnerRootName.HeaderText = "Объединение";
			this.dgvcPartnerRootName.Name = "dgvcPartnerRootName";
			this.dgvcPartnerRootName.ReadOnly = true;
			this.dgvcPartnerRootName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// dgvcContactInfo
			// 
			this.dgvcContactInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcContactInfo.DataPropertyName = "ContactInfo";
			this.dgvcContactInfo.HeaderText = "Контакты";
			this.dgvcContactInfo.Name = "dgvcContactInfo";
			this.dgvcContactInfo.ReadOnly = true;
			this.dgvcContactInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcContactInfo.Width = 200;
			// 
			// dgvcGravity
			// 
			this.dgvcGravity.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcGravity.DataPropertyName = "Gravity";
			this.dgvcGravity.HeaderText = "Важность";
			this.dgvcGravity.Name = "dgvcGravity";
			this.dgvcGravity.ReadOnly = true;
			this.dgvcGravity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcGravity.Width = 70;
			// 
			// dgvcActual
			// 
			this.dgvcActual.DataPropertyName = "Actual";
			this.dgvcActual.HeaderText = "Акт.";
			this.dgvcActual.Name = "dgvcActual";
			this.dgvcActual.ReadOnly = true;
			this.dgvcActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcActual.Width = 40;
			// 
			// dgvcIsCustomer
			// 
			this.dgvcIsCustomer.DataPropertyName = "IsCustomer";
			this.dgvcIsCustomer.HeaderText = "Покупатель";
			this.dgvcIsCustomer.Name = "dgvcIsCustomer";
			this.dgvcIsCustomer.ReadOnly = true;
			this.dgvcIsCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcIsCustomer.Width = 50;
			// 
			// dgvcIsShipper
			// 
			this.dgvcIsShipper.DataPropertyName = "IsTransport";
			this.dgvcIsShipper.HeaderText = "Транспорт";
			this.dgvcIsShipper.Name = "dgvcIsShipper";
			this.dgvcIsShipper.ReadOnly = true;
			this.dgvcIsShipper.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcIsShipper.Width = 50;
			// 
			// dgvcIsSupplier
			// 
			this.dgvcIsSupplier.DataPropertyName = "IsSupplier";
			this.dgvcIsSupplier.HeaderText = "Поставщик";
			this.dgvcIsSupplier.Name = "dgvcIsSupplier";
			this.dgvcIsSupplier.ReadOnly = true;
			this.dgvcIsSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcIsSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcIsSupplier.Width = 50;
			// 
			// dgvcIsOwner
			// 
			this.dgvcIsOwner.DataPropertyName = "IsOwner";
			this.dgvcIsOwner.HeaderText = "Хранитель?";
			this.dgvcIsOwner.Name = "dgvcIsOwner";
			this.dgvcIsOwner.ReadOnly = true;
			this.dgvcIsOwner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcIsOwner.ToolTipText = "Хранитель (владелец) товара?";
			this.dgvcIsOwner.Width = 80;
			// 
			// dgvcSeparatePicking
			// 
			this.dgvcSeparatePicking.DataPropertyName = "SeparatePicking";
			this.dgvcSeparatePicking.HeaderText = "Разд.хран.?";
			this.dgvcSeparatePicking.Name = "dgvcSeparatePicking";
			this.dgvcSeparatePicking.ReadOnly = true;
			this.dgvcSeparatePicking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcSeparatePicking.ToolTipText = "Раздельное хранение товара?";
			this.dgvcSeparatePicking.Width = 80;
			// 
			// dgvcPartnersGoodsExists
			// 
			this.dgvcPartnersGoodsExists.DataPropertyName = "PartnersGoodsExists";
			this.dgvcPartnersGoodsExists.HeaderText = "Спец.";
			this.dgvcPartnersGoodsExists.Name = "dgvcPartnersGoodsExists";
			this.dgvcPartnersGoodsExists.ReadOnly = true;
			this.dgvcPartnersGoodsExists.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcPartnersGoodsExists.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersGoodsExists.ToolTipText = "Есть специальные данные о товарах?";
			this.dgvcPartnersGoodsExists.Width = 45;
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
			this.dgvcERPCode.Width = 80;
			// 
			// dgvcID
			// 
			this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcID.DataPropertyName = "ID";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcID.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvcID.HeaderText = "ID";
			this.dgvcID.Name = "dgvcID";
			this.dgvcID.ReadOnly = true;
			this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcID.ToolTipText = "Код партнера";
			this.dgvcID.Width = 50;
			// 
			// pnlGrids
			// 
			this.pnlGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlGrids.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlGrids.Location = new System.Drawing.Point(1, 156);
			this.pnlGrids.Name = "pnlGrids";
			this.pnlGrids.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// pnlGrids.Panel1
			// 
			this.pnlGrids.Panel1.Controls.Add(this.dgvData);
			// 
			// pnlGrids.Panel2
			// 
			this.pnlGrids.Panel2.Controls.Add(this.dgvPartnersDetails);
			this.pnlGrids.Size = new System.Drawing.Size(689, 309);
			this.pnlGrids.SplitterDistance = 230;
			this.pnlGrids.SplitterWidth = 2;
			this.pnlGrids.TabIndex = 0;
			// 
			// dgvPartnersDetails
			// 
			this.dgvPartnersDetails.AllowUserToAddRows = false;
			this.dgvPartnersDetails.AllowUserToDeleteRows = false;
			this.dgvPartnersDetails.AllowUserToOrderColumns = true;
			this.dgvPartnersDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvPartnersDetails.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvPartnersDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvPartnersDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvPartnersDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgvPartnersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPartnersDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcPartnersDetails_LegalName,
            this.dgvcPartnersDetails_LegalAddress,
            this.dgvcPartnersDetails_FactName,
            this.dgvcPartnersDetails_BankName,
            this.dgvcPartnersDetails_PAccount,
            this.dgvcPartnersDetails_Inn,
            this.dgvcPartnersDetails_AutoSelected,
            this.dgvcPartnersDetails_VeterinaryPartnerName,
            this.dgvcPartnersDetails_VeterinaryPermission,
            this.dgvcPartnersDetails_ID});
			this.dgvPartnersDetails.IsCheckerInclude = true;
			this.dgvPartnersDetails.IsConfigInclude = true;
			this.dgvPartnersDetails.IsMarkedAll = false;
			this.dgvPartnersDetails.IsStatusInclude = true;
			this.dgvPartnersDetails.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvPartnersDetails.Location = new System.Drawing.Point(-1, -1);
			this.dgvPartnersDetails.MultiSelect = false;
			this.dgvPartnersDetails.Name = "dgvPartnersDetails";
			this.dgvPartnersDetails.RangedWay = ' ';
			this.dgvPartnersDetails.ReadOnly = true;
			this.dgvPartnersDetails.RowHeadersWidth = 24;
			this.dgvPartnersDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPartnersDetails.Size = new System.Drawing.Size(687, 75);
			this.dgvPartnersDetails.TabIndex = 0;
			// 
			// tmrRestore
			// 
			this.tmrRestore.Tick += new System.EventHandler(this.tmrRestore_Tick);
			// 
			// dgvcPartnersDetails_LegalName
			// 
			this.dgvcPartnersDetails_LegalName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_LegalName.DataPropertyName = "LegalName";
			this.dgvcPartnersDetails_LegalName.HeaderText = "Юр.название";
			this.dgvcPartnersDetails_LegalName.Name = "dgvcPartnersDetails_LegalName";
			this.dgvcPartnersDetails_LegalName.ReadOnly = true;
			this.dgvcPartnersDetails_LegalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_LegalName.Width = 200;
			// 
			// dgvcPartnersDetails_LegalAddress
			// 
			this.dgvcPartnersDetails_LegalAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_LegalAddress.DataPropertyName = "LegalAddress";
			this.dgvcPartnersDetails_LegalAddress.HeaderText = "Юр.адрес";
			this.dgvcPartnersDetails_LegalAddress.Name = "dgvcPartnersDetails_LegalAddress";
			this.dgvcPartnersDetails_LegalAddress.ReadOnly = true;
			this.dgvcPartnersDetails_LegalAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_LegalAddress.Width = 200;
			// 
			// dgvcPartnersDetails_FactName
			// 
			this.dgvcPartnersDetails_FactName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_FactName.DataPropertyName = "FactName";
			this.dgvcPartnersDetails_FactName.HeaderText = "Факт.название (грузоотправитель)";
			this.dgvcPartnersDetails_FactName.Name = "dgvcPartnersDetails_FactName";
			this.dgvcPartnersDetails_FactName.ReadOnly = true;
			this.dgvcPartnersDetails_FactName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_FactName.Width = 200;
			// 
			// dgvcPartnersDetails_BankName
			// 
			this.dgvcPartnersDetails_BankName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_BankName.DataPropertyName = "BankName";
			this.dgvcPartnersDetails_BankName.HeaderText = "Банк";
			this.dgvcPartnersDetails_BankName.Name = "dgvcPartnersDetails_BankName";
			this.dgvcPartnersDetails_BankName.ReadOnly = true;
			this.dgvcPartnersDetails_BankName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_BankName.Width = 200;
			// 
			// dgvcPartnersDetails_PAccount
			// 
			this.dgvcPartnersDetails_PAccount.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_PAccount.DataPropertyName = "PAccount";
			this.dgvcPartnersDetails_PAccount.HeaderText = "Р/счет";
			this.dgvcPartnersDetails_PAccount.Name = "dgvcPartnersDetails_PAccount";
			this.dgvcPartnersDetails_PAccount.ReadOnly = true;
			this.dgvcPartnersDetails_PAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_PAccount.Width = 120;
			// 
			// dgvcPartnersDetails_Inn
			// 
			this.dgvcPartnersDetails_Inn.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_Inn.DataPropertyName = "INN";
			this.dgvcPartnersDetails_Inn.HeaderText = "ИНН";
			this.dgvcPartnersDetails_Inn.Name = "dgvcPartnersDetails_Inn";
			this.dgvcPartnersDetails_Inn.ReadOnly = true;
			this.dgvcPartnersDetails_Inn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// dgvcPartnersDetails_AutoSelected
			// 
			this.dgvcPartnersDetails_AutoSelected.DataPropertyName = "AutoSelected";
			this.dgvcPartnersDetails_AutoSelected.HeaderText = "Осн.";
			this.dgvcPartnersDetails_AutoSelected.Name = "dgvcPartnersDetails_AutoSelected";
			this.dgvcPartnersDetails_AutoSelected.ReadOnly = true;
			this.dgvcPartnersDetails_AutoSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_AutoSelected.ToolTipText = "Основной реквизит?";
			this.dgvcPartnersDetails_AutoSelected.Width = 40;
			// 
			// dgvcPartnersDetails_VeterinaryPartnerName
			// 
			this.dgvcPartnersDetails_VeterinaryPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_VeterinaryPartnerName.DataPropertyName = "VeterinaryPartnerName";
			this.dgvcPartnersDetails_VeterinaryPartnerName.HeaderText = "Название для ВС";
			this.dgvcPartnersDetails_VeterinaryPartnerName.Name = "dgvcPartnersDetails_VeterinaryPartnerName";
			this.dgvcPartnersDetails_VeterinaryPartnerName.ReadOnly = true;
			this.dgvcPartnersDetails_VeterinaryPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_VeterinaryPartnerName.ToolTipText = "Наименование партнера в бланке вет. свидетельства";
			// 
			// dgvcPartnersDetails_VeterinaryPermission
			// 
			this.dgvcPartnersDetails_VeterinaryPermission.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_VeterinaryPermission.DataPropertyName = "VeterinaryPermission";
			this.dgvcPartnersDetails_VeterinaryPermission.HeaderText = "Разрешение в ВС";
			this.dgvcPartnersDetails_VeterinaryPermission.Name = "dgvcPartnersDetails_VeterinaryPermission";
			this.dgvcPartnersDetails_VeterinaryPermission.ReadOnly = true;
			this.dgvcPartnersDetails_VeterinaryPermission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_VeterinaryPermission.ToolTipText = "№ и дата разрешения в бланке вет. свидетельства";
			this.dgvcPartnersDetails_VeterinaryPermission.Width = 150;
			// 
			// dgvcPartnersDetails_ID
			// 
			this.dgvcPartnersDetails_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPartnersDetails_ID.DataPropertyName = "ID";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcPartnersDetails_ID.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvcPartnersDetails_ID.HeaderText = "ID";
			this.dgvcPartnersDetails_ID.Name = "dgvcPartnersDetails_ID";
			this.dgvcPartnersDetails_ID.ReadOnly = true;
			this.dgvcPartnersDetails_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPartnersDetails_ID.ToolTipText = "Код реквизитов";
			this.dgvcPartnersDetails_ID.Width = 50;
			// 
			// frmSelectOnePartner
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(692, 503);
			this.Controls.Add(this.pnlFilter);
			this.Controls.Add(this.pnlGrids);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnGo);
			this.hpHelp.SetHelpKeyword(this, "1001");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimumSize = new System.Drawing.Size(650, 400);
			this.Name = "frmSelectOnePartner";
			this.hpHelp.SetShowHelp(this, true);
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Выбор партнера";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmSelectOnePartner_KeyDown);
			this.Load += new System.EventHandler(this.frmSelectOnePartner_Load);
			this.pnlFilter.ResumeLayout(false);
			this.pnlFilter.PerformLayout();
			this.ucSelectRecordID_Hosts.ResumeLayout(false);
			this.ucSelectRecordID_Hosts.PerformLayout();
			this.ucSelectRecordID_PartnersRoots.ResumeLayout(false);
			this.ucSelectRecordID_PartnersRoots.PerformLayout();
			this.ucSelectRecordID_Zones.ResumeLayout(false);
			this.ucSelectRecordID_Zones.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.pnlGrids.Panel1.ResumeLayout(false);
			this.pnlGrids.Panel2.ResumeLayout(false);
			this.pnlGrids.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvPartnersDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnGo;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMButton btnFilter;
		private RFMBaseClasses.RFMPanel pnlFilter;
		private RFMBaseClasses.RFMCheckBox chkOwner;
		private RFMBaseClasses.RFMCheckBox chkTransport;
		private RFMBaseClasses.RFMCheckBox chkSupplier;
		private RFMBaseClasses.RFMCheckBox chkCustomer;
		private RFMBaseClasses.RFMCheckBox chkSeparatePicking;
		private RFMBaseClasses.RFMButton btnClear;
		private RFMBaseClasses.RFMLabel lblInnContext;
		private RFMBaseClasses.RFMTextBox txtInnContext;
		private RFMBaseClasses.RFMLabel lblNameContext;
		private RFMBaseClasses.RFMTextBox txtNameContext;
		private RFMBaseClasses.RFMCheckBox chkPerversion;
		private RFMBaseClasses.RFMCheckBox chkActual;
		private RFMBaseClasses.RFMSelectRecordIDTree ucSelectRecordID_Zones;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_PartnersRoots;
		private RFMBaseClasses.RFMLabel lblZones;
		private RFMBaseClasses.RFMLabel lblPartnersRoots;
		private RFMBaseClasses.RFMDataGridView dgvData;
		private RFMBaseClasses.RFMSplitContainer pnlGrids;
		private RFMBaseClasses.RFMDataGridView dgvPartnersDetails;
		private RFMBaseClasses.RFMTimer tmrRestore;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Hosts;
		private RFMBaseClasses.RFMLabel lblHosts;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grсName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcZoneName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDeliveryAddress;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDeliveryPassage;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDeliveryRestriction;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDistance;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPermitLevelName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnerRootName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcContactInfo;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcGravity;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcActual;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcIsCustomer;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcIsShipper;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcIsSupplier;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcIsOwner;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcSeparatePicking;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcPartnersGoodsExists;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_LegalName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_LegalAddress;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_FactName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_BankName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_PAccount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_Inn;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn dgvcPartnersDetails_AutoSelected;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_VeterinaryPartnerName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_VeterinaryPermission;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnersDetails_ID;

	}
}