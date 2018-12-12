namespace Logistics
{
	partial class frmPartners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartners));
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcList = new RFMBaseClasses.RFMTabControl();
            this.tabTerms = new RFMBaseClasses.RFMTabPage();
            this.cntTerms = new RFMBaseClasses.RFMPanel();
            this.lblHosts = new RFMBaseClasses.RFMLabel();
            this.ucSelectRecordID_Hosts = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.ucSelectRecordID_Zones = new RFMBaseClasses.RFMSelectRecordIDTree();
            this.ucSelectRecordID_PartnersRoots = new RFMBaseClasses.RFMSelectRecordIDGrid();
            this.chkIsOwner = new RFMBaseClasses.RFMCheckBox();
            this.lblPartnersGoodsExists = new RFMBaseClasses.RFMLabel();
            this.pnlPartnersGoodsExists = new RFMBaseClasses.RFMPanel();
            this.optPartnersGoodsExistsNot = new RFMBaseClasses.RFMRadioButton();
            this.optPartnersGoodsExists = new RFMBaseClasses.RFMRadioButton();
            this.optPartnersGoodsExistsAll = new RFMBaseClasses.RFMRadioButton();
            this.chkIsTransport = new RFMBaseClasses.RFMCheckBox();
            this.chkIsSupplier = new RFMBaseClasses.RFMCheckBox();
            this.chkIsCustomer = new RFMBaseClasses.RFMCheckBox();
            this.lblZones = new RFMBaseClasses.RFMLabel();
            this.lblPartnersRoots = new RFMBaseClasses.RFMLabel();
            this.lblActual = new RFMBaseClasses.RFMLabel();
            this.pnlActual = new RFMBaseClasses.RFMPanel();
            this.optActualNot = new RFMBaseClasses.RFMRadioButton();
            this.optActual = new RFMBaseClasses.RFMRadioButton();
            this.optActualAll = new RFMBaseClasses.RFMRadioButton();
            this.lblInnContext = new RFMBaseClasses.RFMLabel();
            this.txtInnContext = new RFMBaseClasses.RFMTextBox();
            this.lblNameContext = new RFMBaseClasses.RFMLabel();
            this.txtNameContext = new RFMBaseClasses.RFMTextBox();
            this.btnClearTerms = new RFMBaseClasses.RFMButton();
            this.tabData = new RFMBaseClasses.RFMTabPage();
            this.cntGrids = new RFMBaseClasses.RFMSplitContainer();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grсName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoodsExists = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcLegalName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcZoneName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcRegionAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcLongitude = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcLatitude = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDistance = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcStayMinutes = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDeliveryAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDeliveryPassage = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDeliveryRestriction = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGravity = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPermitLevelName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcContactInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcActual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcIsCustomer = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcIsSupplier = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcIsOwner = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcSeparatePicking = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPF_BillName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPF_BillCopiesCount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPF_FactureName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPF_FactureCopiesCount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPF_PayBillName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPF_PayBillCopiesCount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcShopCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTimeWork = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTimeReceipt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcInn = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerRootName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tcPartners = new RFMBaseClasses.RFMTabControl();
            this.tabPartners_Details = new RFMBaseClasses.RFMTabPage();
            this.grdPartnersDetails = new RFMBaseClasses.RFMDataGridView();
            this.grcPartnersDetails_LegalName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersDetails_FactName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersDetails_Inn = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersDetails_LegalAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersDetails_BankName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersDetails_PAccount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersDetails_AutoSelected = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPartnersDetails_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tabPartners_PartnersGoods = new RFMBaseClasses.RFMTabPage();
            this.grdPartnersGoods = new RFMBaseClasses.RFMDataGridView();
            this.grcPartnersGoods_GoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_InBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_SP_GoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_SP_GoodCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_SP_Articul = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_SP_Vat = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_SP_ByOrder = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersGoods_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tabPartnersRoots = new RFMBaseClasses.RFMTabPage();
            this.cntPartnersRoots = new RFMBaseClasses.RFMSplitContainer();
            this.grdPartnersRoots = new RFMBaseClasses.RFMDataGridView();
            this.grcPartnersRoots_Name = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Alias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_INN = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Gravity = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tcPartnersRoots = new RFMBaseClasses.RFMTabControl();
            this.tabPartnersRoots_Partners = new RFMBaseClasses.RFMTabPage();
            this.grdPartnersRoots_Partners = new RFMBaseClasses.RFMDataGridView();
            this.grcPartnersRoots_Partners_Name = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_PartnersGoodsExists = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPartnersRoots_Partners_LegalName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_Inn = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_ZoneName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_PermitLevelName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_PartnerRootName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_DeliveryAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_DeliveryPassage = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_DeliveryRestriction = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_ContactsInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_Gravity = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_Actual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPartnersRoots_Partners_IsCustomer = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPartnersRoots_Partners_IsSupplier = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPartnersRoots_Partners_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnersRoots_Partners_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tabPrintForms = new RFMBaseClasses.RFMTabPage();
            this.cntPrintForms = new RFMBaseClasses.RFMSplitContainer();
            this.grdPrintForms = new RFMBaseClasses.RFMDataGridView();
            this.grcPrintForms_PF_Type = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPrintForms_PF_Name = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPrintForms_TemplateHasText = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcPrintForms_LinesInPage = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPrintForms_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPrintForms_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPrintForms_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.tcPrintForms = new RFMBaseClasses.RFMTabControl();
            this.tabPrintForms_Partners = new RFMBaseClasses.RFMTabPage();
            this.grdPrintForms_Partners = new RFMBaseClasses.RFMDataGridView();
            this.grcPrintForms_Partners_Name = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnService = new RFMBaseClasses.RFMButton();
            this.mnuPartnersService = new RFMBaseClasses.RFMContextMenuStrip();
            this.mniPartnersGoodsEdit = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniPartnersGoodsCopy = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.mniPartnersPFCopy = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.btnCancel = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.tmrRestore = new RFMBaseClasses.RFMTimer();
            this.mnuPartnersRootsService = new RFMBaseClasses.RFMContextMenuStrip();
            this.tcList.SuspendLayout();
            this.tabTerms.SuspendLayout();
            this.cntTerms.SuspendLayout();
            this.ucSelectRecordID_Hosts.SuspendLayout();
            this.ucSelectRecordID_Zones.SuspendLayout();
            this.ucSelectRecordID_PartnersRoots.SuspendLayout();
            this.pnlPartnersGoodsExists.SuspendLayout();
            this.pnlActual.SuspendLayout();
            this.tabData.SuspendLayout();
            this.cntGrids.Panel1.SuspendLayout();
            this.cntGrids.Panel2.SuspendLayout();
            this.cntGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.tcPartners.SuspendLayout();
            this.tabPartners_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersDetails)).BeginInit();
            this.tabPartners_PartnersGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersGoods)).BeginInit();
            this.tabPartnersRoots.SuspendLayout();
            this.cntPartnersRoots.Panel1.SuspendLayout();
            this.cntPartnersRoots.Panel2.SuspendLayout();
            this.cntPartnersRoots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersRoots)).BeginInit();
            this.tcPartnersRoots.SuspendLayout();
            this.tabPartnersRoots_Partners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersRoots_Partners)).BeginInit();
            this.tabPrintForms.SuspendLayout();
            this.cntPrintForms.Panel1.SuspendLayout();
            this.cntPrintForms.Panel2.SuspendLayout();
            this.cntPrintForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrintForms)).BeginInit();
            this.tcPrintForms.SuspendLayout();
            this.tabPrintForms_Partners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrintForms_Partners)).BeginInit();
            this.mnuPartnersService.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcList
            // 
            this.tcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcList.Controls.Add(this.tabTerms);
            this.tcList.Controls.Add(this.tabData);
            this.tcList.Controls.Add(this.tabPartnersRoots);
            this.tcList.Controls.Add(this.tabPrintForms);
            this.tcList.Location = new System.Drawing.Point(1, 1);
            this.tcList.Name = "tcList";
            this.tcList.SelectedIndex = 0;
            this.tcList.Size = new System.Drawing.Size(741, 429);
            this.tcList.TabIndex = 0;
            this.tcList.SelectedIndexChanged += new System.EventHandler(this.tcList_SelectedIndexChanged);
            // 
            // tabTerms
            // 
            this.tabTerms.Controls.Add(this.cntTerms);
            this.tabTerms.IsFilterPage = true;
            this.tabTerms.Location = new System.Drawing.Point(4, 23);
            this.tabTerms.Name = "tabTerms";
            this.tabTerms.Padding = new System.Windows.Forms.Padding(3);
            this.tabTerms.Size = new System.Drawing.Size(733, 402);
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
            this.cntTerms.Controls.Add(this.lblHosts);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_Hosts);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_Zones);
            this.cntTerms.Controls.Add(this.ucSelectRecordID_PartnersRoots);
            this.cntTerms.Controls.Add(this.chkIsOwner);
            this.cntTerms.Controls.Add(this.lblPartnersGoodsExists);
            this.cntTerms.Controls.Add(this.pnlPartnersGoodsExists);
            this.cntTerms.Controls.Add(this.chkIsTransport);
            this.cntTerms.Controls.Add(this.chkIsSupplier);
            this.cntTerms.Controls.Add(this.chkIsCustomer);
            this.cntTerms.Controls.Add(this.lblZones);
            this.cntTerms.Controls.Add(this.lblPartnersRoots);
            this.cntTerms.Controls.Add(this.lblActual);
            this.cntTerms.Controls.Add(this.pnlActual);
            this.cntTerms.Controls.Add(this.lblInnContext);
            this.cntTerms.Controls.Add(this.txtInnContext);
            this.cntTerms.Controls.Add(this.lblNameContext);
            this.cntTerms.Controls.Add(this.txtNameContext);
            this.cntTerms.Controls.Add(this.btnClearTerms);
            this.cntTerms.Location = new System.Drawing.Point(0, 2);
            this.cntTerms.Name = "cntTerms";
            this.cntTerms.Size = new System.Drawing.Size(732, 399);
            this.cntTerms.TabIndex = 0;
            // 
            // lblHosts
            // 
            this.lblHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHosts.AutoSize = true;
            this.lblHosts.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblHosts.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHosts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHosts.Location = new System.Drawing.Point(449, 355);
            this.lblHosts.Name = "lblHosts";
            this.lblHosts.Size = new System.Drawing.Size(41, 14);
            this.lblHosts.TabIndex = 103;
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
            this.ucSelectRecordID_Hosts.BtnClear.Location = new System.Drawing.Point(205, 0);
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
            this.ucSelectRecordID_Hosts.BtnSelect.Location = new System.Drawing.Point(179, 0);
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
            this.ucSelectRecordID_Hosts.Location = new System.Drawing.Point(449, 370);
            this.ucSelectRecordID_Hosts.MarkedCount = 0;
            this.ucSelectRecordID_Hosts.Name = "ucSelectRecordID_Hosts";
            this.ucSelectRecordID_Hosts.Size = new System.Drawing.Size(232, 24);
            this.ucSelectRecordID_Hosts.TabIndex = 102;
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
            this.ucSelectRecordID_Hosts.TxtData.Size = new System.Drawing.Size(177, 22);
            this.ucSelectRecordID_Hosts.TxtData.TabIndex = 0;
            this.ucSelectRecordID_Hosts.СolumnsData.AddRange(new string[] {
            "Name, Хост"});
            // 
            // ucSelectRecordID_Zones
            // 
            // 
            // ucSelectRecordID_Zones.btnClear
            // 
            this.ucSelectRecordID_Zones.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Zones.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Zones.btnClear.Image")));
            this.ucSelectRecordID_Zones.BtnClear.Location = new System.Drawing.Point(248, 3);
            this.ucSelectRecordID_Zones.BtnClear.Name = "btnClear";
            this.ucSelectRecordID_Zones.BtnClear.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Zones.BtnClear.TabIndex = 2;
            this.ucSelectRecordID_Zones.BtnClear.UseVisualStyleBackColor = true;
            // 
            // ucSelectRecordID_Zones.btnSelect
            // 
            this.ucSelectRecordID_Zones.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_Zones.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Zones.btnSelect.Image")));
            this.ucSelectRecordID_Zones.BtnSelect.Location = new System.Drawing.Point(222, 3);
            this.ucSelectRecordID_Zones.BtnSelect.Name = "btnSelect";
            this.ucSelectRecordID_Zones.BtnSelect.Size = new System.Drawing.Size(24, 24);
            this.ucSelectRecordID_Zones.BtnSelect.TabIndex = 1;
            this.ucSelectRecordID_Zones.BtnSelect.UseVisualStyleBackColor = true;
            this.ucSelectRecordID_Zones.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucSelectRecordID_Zones.IsSaveMark = true;
            this.ucSelectRecordID_Zones.IsUseMark = true;
            this.ucSelectRecordID_Zones.Location = new System.Drawing.Point(107, 107);
            this.ucSelectRecordID_Zones.MarkedCount = 0;
            this.ucSelectRecordID_Zones.Name = "ucSelectRecordID_Zones";
            this.ucSelectRecordID_Zones.Size = new System.Drawing.Size(275, 30);
            this.ucSelectRecordID_Zones.TabIndex = 7;
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
            this.ucSelectRecordID_Zones.TxtData.Location = new System.Drawing.Point(0, 4);
            this.ucSelectRecordID_Zones.TxtData.Name = "txtData";
            this.ucSelectRecordID_Zones.TxtData.ReadOnly = true;
            this.ucSelectRecordID_Zones.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_Zones.TxtData.TabIndex = 3;
            // 
            // ucSelectRecordID_PartnersRoots
            // 
            // 
            // ucSelectRecordID_PartnersRoots.btnClear
            // 
            this.ucSelectRecordID_PartnersRoots.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSelectRecordID_PartnersRoots.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_PartnersRoots.btnClear.Image")));
            this.ucSelectRecordID_PartnersRoots.BtnClear.Location = new System.Drawing.Point(248, 4);
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
            this.ucSelectRecordID_PartnersRoots.BtnSelect.Location = new System.Drawing.Point(222, 4);
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
            this.ucSelectRecordID_PartnersRoots.Location = new System.Drawing.Point(107, 71);
            this.ucSelectRecordID_PartnersRoots.MarkedCount = 0;
            this.ucSelectRecordID_PartnersRoots.Name = "ucSelectRecordID_PartnersRoots";
            this.ucSelectRecordID_PartnersRoots.Size = new System.Drawing.Size(275, 32);
            this.ucSelectRecordID_PartnersRoots.TabIndex = 5;
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
            this.ucSelectRecordID_PartnersRoots.TxtData.Location = new System.Drawing.Point(0, 5);
            this.ucSelectRecordID_PartnersRoots.TxtData.MaxLength = 128;
            this.ucSelectRecordID_PartnersRoots.TxtData.Name = "txtData";
            this.ucSelectRecordID_PartnersRoots.TxtData.ReadOnly = true;
            this.ucSelectRecordID_PartnersRoots.TxtData.Size = new System.Drawing.Size(220, 22);
            this.ucSelectRecordID_PartnersRoots.TxtData.TabIndex = 0;
            this.ucSelectRecordID_PartnersRoots.СolumnsData.AddRange(new string[] {
            "Name, Владелец",
            "Actual, Акт."});
            // 
            // chkIsOwner
            // 
            this.chkIsOwner.AutoSize = true;
            this.chkIsOwner.Location = new System.Drawing.Point(107, 290);
            this.chkIsOwner.Name = "chkIsOwner";
            this.chkIsOwner.Size = new System.Drawing.Size(85, 18);
            this.chkIsOwner.TabIndex = 15;
            this.chkIsOwner.Text = "хранитель";
            this.chkIsOwner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkIsOwner.UseVisualStyleBackColor = true;
            // 
            // lblPartnersGoodsExists
            // 
            this.lblPartnersGoodsExists.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartnersGoodsExists.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartnersGoodsExists.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartnersGoodsExists.Location = new System.Drawing.Point(5, 175);
            this.lblPartnersGoodsExists.Name = "lblPartnersGoodsExists";
            this.lblPartnersGoodsExists.Size = new System.Drawing.Size(90, 29);
            this.lblPartnersGoodsExists.TabIndex = 10;
            this.lblPartnersGoodsExists.Text = "Спец.данные о товарах?";
            // 
            // pnlPartnersGoodsExists
            // 
            this.pnlPartnersGoodsExists.Controls.Add(this.optPartnersGoodsExistsNot);
            this.pnlPartnersGoodsExists.Controls.Add(this.optPartnersGoodsExists);
            this.pnlPartnersGoodsExists.Controls.Add(this.optPartnersGoodsExistsAll);
            this.pnlPartnersGoodsExists.Location = new System.Drawing.Point(106, 177);
            this.pnlPartnersGoodsExists.Name = "pnlPartnersGoodsExists";
            this.pnlPartnersGoodsExists.Size = new System.Drawing.Size(227, 23);
            this.pnlPartnersGoodsExists.TabIndex = 11;
            // 
            // optPartnersGoodsExistsNot
            // 
            this.optPartnersGoodsExistsNot.AutoSize = true;
            this.optPartnersGoodsExistsNot.Location = new System.Drawing.Point(166, 4);
            this.optPartnersGoodsExistsNot.Name = "optPartnersGoodsExistsNot";
            this.optPartnersGoodsExistsNot.Size = new System.Drawing.Size(45, 18);
            this.optPartnersGoodsExistsNot.TabIndex = 1;
            this.optPartnersGoodsExistsNot.Text = "нет";
            this.optPartnersGoodsExistsNot.UseVisualStyleBackColor = true;
            // 
            // optPartnersGoodsExists
            // 
            this.optPartnersGoodsExists.AutoSize = true;
            this.optPartnersGoodsExists.Location = new System.Drawing.Point(103, 4);
            this.optPartnersGoodsExists.Name = "optPartnersGoodsExists";
            this.optPartnersGoodsExists.Size = new System.Drawing.Size(50, 18);
            this.optPartnersGoodsExists.TabIndex = 2;
            this.optPartnersGoodsExists.Text = "есть";
            this.optPartnersGoodsExists.UseVisualStyleBackColor = true;
            // 
            // optPartnersGoodsExistsAll
            // 
            this.optPartnersGoodsExistsAll.AutoSize = true;
            this.optPartnersGoodsExistsAll.Checked = true;
            this.optPartnersGoodsExistsAll.IsChanged = true;
            this.optPartnersGoodsExistsAll.Location = new System.Drawing.Point(4, 4);
            this.optPartnersGoodsExistsAll.Name = "optPartnersGoodsExistsAll";
            this.optPartnersGoodsExistsAll.Size = new System.Drawing.Size(79, 18);
            this.optPartnersGoodsExistsAll.TabIndex = 0;
            this.optPartnersGoodsExistsAll.TabStop = true;
            this.optPartnersGoodsExistsAll.Text = "не важно";
            this.optPartnersGoodsExistsAll.UseVisualStyleBackColor = true;
            // 
            // chkIsTransport
            // 
            this.chkIsTransport.AutoSize = true;
            this.chkIsTransport.Location = new System.Drawing.Point(107, 265);
            this.chkIsTransport.Name = "chkIsTransport";
            this.chkIsTransport.Size = new System.Drawing.Size(164, 18);
            this.chkIsTransport.TabIndex = 14;
            this.chkIsTransport.Text = "транспортная компания";
            this.chkIsTransport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkIsTransport.UseVisualStyleBackColor = true;
            // 
            // chkIsSupplier
            // 
            this.chkIsSupplier.AutoSize = true;
            this.chkIsSupplier.Location = new System.Drawing.Point(107, 240);
            this.chkIsSupplier.Name = "chkIsSupplier";
            this.chkIsSupplier.Size = new System.Drawing.Size(86, 18);
            this.chkIsSupplier.TabIndex = 13;
            this.chkIsSupplier.Text = "поставщик";
            this.chkIsSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkIsSupplier.UseVisualStyleBackColor = true;
            // 
            // chkIsCustomer
            // 
            this.chkIsCustomer.AutoSize = true;
            this.chkIsCustomer.Location = new System.Drawing.Point(107, 215);
            this.chkIsCustomer.Name = "chkIsCustomer";
            this.chkIsCustomer.Size = new System.Drawing.Size(91, 18);
            this.chkIsCustomer.TabIndex = 12;
            this.chkIsCustomer.Text = "покупатель";
            this.chkIsCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkIsCustomer.UseVisualStyleBackColor = true;
            // 
            // lblZones
            // 
            this.lblZones.AutoSize = true;
            this.lblZones.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblZones.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblZones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblZones.Location = new System.Drawing.Point(5, 114);
            this.lblZones.Name = "lblZones";
            this.lblZones.Size = new System.Drawing.Size(33, 14);
            this.lblZones.TabIndex = 6;
            this.lblZones.Text = "Зона";
            // 
            // lblPartnersRoots
            // 
            this.lblPartnersRoots.AutoSize = true;
            this.lblPartnersRoots.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartnersRoots.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartnersRoots.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartnersRoots.Location = new System.Drawing.Point(5, 80);
            this.lblPartnersRoots.Name = "lblPartnersRoots";
            this.lblPartnersRoots.Size = new System.Drawing.Size(86, 14);
            this.lblPartnersRoots.TabIndex = 4;
            this.lblPartnersRoots.Text = "Объединение";
            // 
            // lblActual
            // 
            this.lblActual.AutoSize = true;
            this.lblActual.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblActual.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblActual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblActual.Location = new System.Drawing.Point(5, 151);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(72, 14);
            this.lblActual.TabIndex = 8;
            this.lblActual.Text = "Актуально?";
            // 
            // pnlActual
            // 
            this.pnlActual.Controls.Add(this.optActualNot);
            this.pnlActual.Controls.Add(this.optActual);
            this.pnlActual.Controls.Add(this.optActualAll);
            this.pnlActual.Location = new System.Drawing.Point(106, 145);
            this.pnlActual.Name = "pnlActual";
            this.pnlActual.Size = new System.Drawing.Size(227, 23);
            this.pnlActual.TabIndex = 9;
            // 
            // optActualNot
            // 
            this.optActualNot.AutoSize = true;
            this.optActualNot.Location = new System.Drawing.Point(166, 4);
            this.optActualNot.Name = "optActualNot";
            this.optActualNot.Size = new System.Drawing.Size(45, 18);
            this.optActualNot.TabIndex = 1;
            this.optActualNot.Text = "нет";
            this.optActualNot.UseVisualStyleBackColor = true;
            // 
            // optActual
            // 
            this.optActual.AutoSize = true;
            this.optActual.Location = new System.Drawing.Point(103, 4);
            this.optActual.Name = "optActual";
            this.optActual.Size = new System.Drawing.Size(38, 18);
            this.optActual.TabIndex = 2;
            this.optActual.Text = "да";
            this.optActual.UseVisualStyleBackColor = true;
            // 
            // optActualAll
            // 
            this.optActualAll.AutoSize = true;
            this.optActualAll.Checked = true;
            this.optActualAll.IsChanged = true;
            this.optActualAll.Location = new System.Drawing.Point(4, 4);
            this.optActualAll.Name = "optActualAll";
            this.optActualAll.Size = new System.Drawing.Size(79, 18);
            this.optActualAll.TabIndex = 0;
            this.optActualAll.TabStop = true;
            this.optActualAll.Text = "не важно";
            this.optActualAll.UseVisualStyleBackColor = true;
            // 
            // lblInnContext
            // 
            this.lblInnContext.AutoSize = true;
            this.lblInnContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblInnContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInnContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInnContext.Location = new System.Drawing.Point(5, 45);
            this.lblInnContext.Name = "lblInnContext";
            this.lblInnContext.Size = new System.Drawing.Size(96, 14);
            this.lblInnContext.TabIndex = 2;
            this.lblInnContext.Text = "ИНН (контекст)";
            // 
            // txtInnContext
            // 
            this.txtInnContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtInnContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtInnContext.Location = new System.Drawing.Point(107, 42);
            this.txtInnContext.Name = "txtInnContext";
            this.txtInnContext.Size = new System.Drawing.Size(217, 22);
            this.txtInnContext.TabIndex = 3;
            // 
            // lblNameContext
            // 
            this.lblNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNameContext.Location = new System.Drawing.Point(5, 5);
            this.lblNameContext.Name = "lblNameContext";
            this.lblNameContext.Size = new System.Drawing.Size(94, 28);
            this.lblNameContext.TabIndex = 0;
            this.lblNameContext.Text = "Наименование (контекст) ";
            // 
            // txtNameContext
            // 
            this.txtNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNameContext.Location = new System.Drawing.Point(107, 9);
            this.txtNameContext.Name = "txtNameContext";
            this.txtNameContext.Size = new System.Drawing.Size(217, 22);
            this.txtNameContext.TabIndex = 1;
            // 
            // btnClearTerms
            // 
            this.btnClearTerms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearTerms.FlatAppearance.BorderSize = 0;
            this.btnClearTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTerms.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnClearTerms.Location = new System.Drawing.Point(704, 371);
            this.btnClearTerms.Name = "btnClearTerms";
            this.btnClearTerms.Size = new System.Drawing.Size(22, 22);
            this.btnClearTerms.TabIndex = 16;
            this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
            this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.cntGrids);
            this.tabData.Location = new System.Drawing.Point(4, 23);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(733, 402);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Партнеры";
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
            this.cntGrids.Panel1.Controls.Add(this.grdData);
            // 
            // cntGrids.Panel2
            // 
            this.cntGrids.Panel2.Controls.Add(this.tcPartners);
            this.cntGrids.Size = new System.Drawing.Size(732, 400);
            this.cntGrids.SplitterDistance = 267;
            this.cntGrids.SplitterWidth = 2;
            this.cntGrids.TabIndex = 0;
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
            this.grсName,
            this.grcPartnersGoodsExists,
            this.grcLegalName,
            this.grcZoneName,
            this.grcRegionAlias,
            this.grcLongitude,
            this.grcLatitude,
            this.grcDistance,
            this.grcStayMinutes,
            this.grcDeliveryAddress,
            this.grcDeliveryPassage,
            this.grcDeliveryRestriction,
            this.grcGravity,
            this.grcPermitLevelName,
            this.grcContactInfo,
            this.grcActual,
            this.grcIsCustomer,
            this.grcIsSupplier,
            this.grcIsOwner,
            this.grcSeparatePicking,
            this.grcPF_BillName,
            this.grcPF_BillCopiesCount,
            this.grcPF_FactureName,
            this.grcPF_FactureCopiesCount,
            this.grcPF_PayBillName,
            this.grcPF_PayBillCopiesCount,
            this.grcShopCode,
            this.grcTimeWork,
            this.grcTimeReceipt,
            this.grcInn,
            this.grcPartnerRootName,
            this.grcERPCode,
            this.grcID});
            this.grdData.IsActualOnly = false;
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
            this.grdData.Location = new System.Drawing.Point(0, 0);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdData.Size = new System.Drawing.Size(729, 263);
            this.grdData.TabIndex = 11;
            this.grdData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdData_CurrentRowChanged);
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
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
            // grcPartnersGoodsExists
            // 
            this.grcPartnersGoodsExists.DataPropertyName = "PartnersGoodsExists";
            this.grcPartnersGoodsExists.HeaderText = "Спец.";
            this.grcPartnersGoodsExists.Name = "grcPartnersGoodsExists";
            this.grcPartnersGoodsExists.ReadOnly = true;
            this.grcPartnersGoodsExists.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcPartnersGoodsExists.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoodsExists.ToolTipText = "Есть специальные данные по товарам?";
            this.grcPartnersGoodsExists.Width = 45;
            // 
            // grcLegalName
            // 
            this.grcLegalName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcLegalName.DataPropertyName = "LegalName";
            this.grcLegalName.HeaderText = "Юридическое название";
            this.grcLegalName.Name = "grcLegalName";
            this.grcLegalName.ReadOnly = true;
            this.grcLegalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcLegalName.Width = 200;
            // 
            // grcZoneName
            // 
            this.grcZoneName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcZoneName.DataPropertyName = "ZoneName";
            this.grcZoneName.HeaderText = "Зона";
            this.grcZoneName.Name = "grcZoneName";
            this.grcZoneName.ReadOnly = true;
            this.grcZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcRegionAlias
            // 
            this.grcRegionAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcRegionAlias.DataPropertyName = "RegionAlias";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = ":";
            this.grcRegionAlias.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcRegionAlias.HeaderText = "Регион";
            this.grcRegionAlias.Name = "grcRegionAlias";
            this.grcRegionAlias.ReadOnly = true;
            this.grcRegionAlias.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcRegionAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcLongitude
            // 
            this.grcLongitude.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcLongitude.DataPropertyName = "Longitude";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N6";
            this.grcLongitude.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcLongitude.HeaderText = "Долгота";
            this.grcLongitude.Name = "grcLongitude";
            this.grcLongitude.ReadOnly = true;
            this.grcLongitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcLongitude.ToolTipText = "Географическая долгота";
            // 
            // grcLatitude
            // 
            this.grcLatitude.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcLatitude.DataPropertyName = "Latitude";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N6";
            this.grcLatitude.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcLatitude.HeaderText = "Широта";
            this.grcLatitude.Name = "grcLatitude";
            this.grcLatitude.ReadOnly = true;
            this.grcLatitude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcLatitude.ToolTipText = "Географическая широта";
            // 
            // grcDistance
            // 
            this.grcDistance.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDistance.DataPropertyName = "Distance";
            this.grcDistance.HeaderText = "Расст.";
            this.grcDistance.Name = "grcDistance";
            this.grcDistance.ReadOnly = true;
            this.grcDistance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDistance.ToolTipText = "Расстояние до клиента, км";
            this.grcDistance.Width = 75;
            // 
            // grcStayMinutes
            // 
            this.grcStayMinutes.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcStayMinutes.DataPropertyName = "StayMinutes";
            this.grcStayMinutes.HeaderText = "Простой";
            this.grcStayMinutes.Name = "grcStayMinutes";
            this.grcStayMinutes.ReadOnly = true;
            this.grcStayMinutes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcStayMinutes.ToolTipText = "Среднее время простоя в точке, мин.";
            this.grcStayMinutes.Width = 75;
            // 
            // grcDeliveryAddress
            // 
            this.grcDeliveryAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDeliveryAddress.DataPropertyName = "DeliveryAddress";
            this.grcDeliveryAddress.HeaderText = "Адрес доставки";
            this.grcDeliveryAddress.Name = "grcDeliveryAddress";
            this.grcDeliveryAddress.ReadOnly = true;
            this.grcDeliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDeliveryAddress.Width = 200;
            // 
            // grcDeliveryPassage
            // 
            this.grcDeliveryPassage.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDeliveryPassage.DataPropertyName = "DeliveryPassage";
            this.grcDeliveryPassage.HeaderText = "Проезд";
            this.grcDeliveryPassage.Name = "grcDeliveryPassage";
            this.grcDeliveryPassage.ReadOnly = true;
            this.grcDeliveryPassage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDeliveryPassage.Width = 200;
            // 
            // grcDeliveryRestriction
            // 
            this.grcDeliveryRestriction.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDeliveryRestriction.DataPropertyName = "DeliveryRestriction";
            this.grcDeliveryRestriction.HeaderText = "Ограничения по доставке";
            this.grcDeliveryRestriction.Name = "grcDeliveryRestriction";
            this.grcDeliveryRestriction.ReadOnly = true;
            this.grcDeliveryRestriction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDeliveryRestriction.Width = 200;
            // 
            // grcGravity
            // 
            this.grcGravity.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGravity.DataPropertyName = "Gravity";
            this.grcGravity.HeaderText = "Важность";
            this.grcGravity.Name = "grcGravity";
            this.grcGravity.ReadOnly = true;
            this.grcGravity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGravity.Width = 70;
            // 
            // grcPermitLevelName
            // 
            this.grcPermitLevelName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPermitLevelName.DataPropertyName = "PermitLevelName";
            this.grcPermitLevelName.HeaderText = "Разрешение";
            this.grcPermitLevelName.Name = "grcPermitLevelName";
            this.grcPermitLevelName.ReadOnly = true;
            this.grcPermitLevelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPermitLevelName.ToolTipText = "Разрешение на проезд";
            // 
            // grcContactInfo
            // 
            this.grcContactInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcContactInfo.DataPropertyName = "ContactInfo";
            this.grcContactInfo.HeaderText = "Контакты";
            this.grcContactInfo.Name = "grcContactInfo";
            this.grcContactInfo.ReadOnly = true;
            this.grcContactInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcContactInfo.Width = 200;
            // 
            // grcActual
            // 
            this.grcActual.DataPropertyName = "Actual";
            this.grcActual.HeaderText = "Акт.";
            this.grcActual.Name = "grcActual";
            this.grcActual.ReadOnly = true;
            this.grcActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcActual.Width = 40;
            // 
            // grcIsCustomer
            // 
            this.grcIsCustomer.DataPropertyName = "IsCustomer";
            this.grcIsCustomer.HeaderText = "Покупатель";
            this.grcIsCustomer.Name = "grcIsCustomer";
            this.grcIsCustomer.ReadOnly = true;
            this.grcIsCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsCustomer.Width = 50;
            // 
            // grcIsSupplier
            // 
            this.grcIsSupplier.DataPropertyName = "IsSupplier";
            this.grcIsSupplier.HeaderText = "Поставщик";
            this.grcIsSupplier.Name = "grcIsSupplier";
            this.grcIsSupplier.ReadOnly = true;
            this.grcIsSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcIsSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsSupplier.Width = 50;
            // 
            // grcIsOwner
            // 
            this.grcIsOwner.DataPropertyName = "IsOwner";
            this.grcIsOwner.HeaderText = "Хранитель?";
            this.grcIsOwner.Name = "grcIsOwner";
            this.grcIsOwner.ReadOnly = true;
            this.grcIsOwner.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsOwner.ToolTipText = "Хранитель (владелец) товара?";
            this.grcIsOwner.Width = 80;
            // 
            // grcSeparatePicking
            // 
            this.grcSeparatePicking.DataPropertyName = "SeparatePicking";
            this.grcSeparatePicking.HeaderText = "Разд.хран.?";
            this.grcSeparatePicking.Name = "grcSeparatePicking";
            this.grcSeparatePicking.ReadOnly = true;
            this.grcSeparatePicking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSeparatePicking.ToolTipText = "Раздельное хранение товара?";
            this.grcSeparatePicking.Width = 80;
            // 
            // grcPF_BillName
            // 
            this.grcPF_BillName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPF_BillName.DataPropertyName = "PF_BillName";
            this.grcPF_BillName.HeaderText = "ПФ Накл.";
            this.grcPF_BillName.Name = "grcPF_BillName";
            this.grcPF_BillName.ReadOnly = true;
            this.grcPF_BillName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPF_BillName.ToolTipText = "Имя шаблона Накладной";
            // 
            // grcPF_BillCopiesCount
            // 
            this.grcPF_BillCopiesCount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPF_BillCopiesCount.DataPropertyName = "PF_BillCopiesCount";
            this.grcPF_BillCopiesCount.HeaderText = "ПФ Накл. копий";
            this.grcPF_BillCopiesCount.Name = "grcPF_BillCopiesCount";
            this.grcPF_BillCopiesCount.ReadOnly = true;
            this.grcPF_BillCopiesCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPF_BillCopiesCount.ToolTipText = "Количество копий Накладной";
            this.grcPF_BillCopiesCount.Width = 40;
            // 
            // grcPF_FactureName
            // 
            this.grcPF_FactureName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPF_FactureName.DataPropertyName = "PF_FactureName";
            this.grcPF_FactureName.HeaderText = "ПФ Счет-фактура";
            this.grcPF_FactureName.Name = "grcPF_FactureName";
            this.grcPF_FactureName.ReadOnly = true;
            this.grcPF_FactureName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPF_FactureName.ToolTipText = "Имя шаблона Счета-фактуры";
            // 
            // grcPF_FactureCopiesCount
            // 
            this.grcPF_FactureCopiesCount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPF_FactureCopiesCount.DataPropertyName = "PF_FactureCopiesCount";
            this.grcPF_FactureCopiesCount.HeaderText = "ПФ Cчет-факт. копий";
            this.grcPF_FactureCopiesCount.Name = "grcPF_FactureCopiesCount";
            this.grcPF_FactureCopiesCount.ReadOnly = true;
            this.grcPF_FactureCopiesCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPF_FactureCopiesCount.ToolTipText = "Количество копий Счета-фактуры";
            this.grcPF_FactureCopiesCount.Width = 40;
            // 
            // grcPF_PayBillName
            // 
            this.grcPF_PayBillName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPF_PayBillName.DataPropertyName = "PF_PayBillName";
            this.grcPF_PayBillName.HeaderText = "ПФ Счет на оплату";
            this.grcPF_PayBillName.Name = "grcPF_PayBillName";
            this.grcPF_PayBillName.ReadOnly = true;
            this.grcPF_PayBillName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPF_PayBillName.ToolTipText = "Имя шаблона Счета на оплату";
            // 
            // grcPF_PayBillCopiesCount
            // 
            this.grcPF_PayBillCopiesCount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPF_PayBillCopiesCount.DataPropertyName = "PF_PayBillCopiesCount";
            this.grcPF_PayBillCopiesCount.HeaderText = "ПФ Счет опл. копий";
            this.grcPF_PayBillCopiesCount.Name = "grcPF_PayBillCopiesCount";
            this.grcPF_PayBillCopiesCount.ReadOnly = true;
            this.grcPF_PayBillCopiesCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPF_PayBillCopiesCount.ToolTipText = "Количество копий Счета на оплату";
            this.grcPF_PayBillCopiesCount.Width = 40;
            // 
            // grcShopCode
            // 
            this.grcShopCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcShopCode.DataPropertyName = "ShopCode";
            this.grcShopCode.HeaderText = "Код(№) магазина";
            this.grcShopCode.Name = "grcShopCode";
            this.grcShopCode.ReadOnly = true;
            this.grcShopCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcShopCode.ToolTipText = "Код(№) магазина в сети";
            // 
            // grcTimeWork
            // 
            this.grcTimeWork.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTimeWork.DataPropertyName = "TimeWork";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grcTimeWork.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcTimeWork.HeaderText = "ЧР";
            this.grcTimeWork.Name = "grcTimeWork";
            this.grcTimeWork.ReadOnly = true;
            this.grcTimeWork.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTimeWork.ToolTipText = "Часы работы";
            this.grcTimeWork.Width = 60;
            // 
            // grcTimeReceipt
            // 
            this.grcTimeReceipt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTimeReceipt.DataPropertyName = "TimeReceipt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grcTimeReceipt.DefaultCellStyle = dataGridViewCellStyle6;
            this.grcTimeReceipt.HeaderText = "ЧП";
            this.grcTimeReceipt.Name = "grcTimeReceipt";
            this.grcTimeReceipt.ReadOnly = true;
            this.grcTimeReceipt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTimeReceipt.ToolTipText = "Часы приема товара";
            this.grcTimeReceipt.Width = 60;
            // 
            // grcInn
            // 
            this.grcInn.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcInn.DataPropertyName = "INN";
            this.grcInn.HeaderText = "ИНН";
            this.grcInn.Name = "grcInn";
            this.grcInn.ReadOnly = true;
            this.grcInn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnerRootName
            // 
            this.grcPartnerRootName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerRootName.DataPropertyName = "PartnerRootName";
            this.grcPartnerRootName.HeaderText = "Объединение";
            this.grcPartnerRootName.Name = "grcPartnerRootName";
            this.grcPartnerRootName.ReadOnly = true;
            this.grcPartnerRootName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcERPCode
            // 
            this.grcERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcERPCode.DataPropertyName = "ERPCode";
            this.grcERPCode.HeaderText = "ERPCode";
            this.grcERPCode.Name = "grcERPCode";
            this.grcERPCode.ReadOnly = true;
            this.grcERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcERPCode.ToolTipText = "Код в host-системе";
            this.grcERPCode.Width = 80;
            // 
            // grcID
            // 
            this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcID.DataPropertyName = "ID";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcID.DefaultCellStyle = dataGridViewCellStyle7;
            this.grcID.HeaderText = "ID";
            this.grcID.Name = "grcID";
            this.grcID.ReadOnly = true;
            this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcID.ToolTipText = "Код партнера";
            this.grcID.Width = 50;
            // 
            // tcPartners
            // 
            this.tcPartners.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcPartners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPartners.Controls.Add(this.tabPartners_Details);
            this.tcPartners.Controls.Add(this.tabPartners_PartnersGoods);
            this.tcPartners.ItemSize = new System.Drawing.Size(120, 18);
            this.tcPartners.Location = new System.Drawing.Point(1, 1);
            this.tcPartners.Multiline = true;
            this.tcPartners.Name = "tcPartners";
            this.tcPartners.SelectedIndex = 0;
            this.tcPartners.Size = new System.Drawing.Size(727, 125);
            this.tcPartners.TabIndex = 0;
            // 
            // tabPartners_Details
            // 
            this.tabPartners_Details.Controls.Add(this.grdPartnersDetails);
            this.tabPartners_Details.Location = new System.Drawing.Point(4, 4);
            this.tabPartners_Details.Name = "tabPartners_Details";
            this.tabPartners_Details.Size = new System.Drawing.Size(719, 99);
            this.tabPartners_Details.TabIndex = 2;
            this.tabPartners_Details.Text = "Реквизиты";
            this.tabPartners_Details.UseVisualStyleBackColor = true;
            // 
            // grdPartnersDetails
            // 
            this.grdPartnersDetails.AllowUserToAddRows = false;
            this.grdPartnersDetails.AllowUserToDeleteRows = false;
            this.grdPartnersDetails.AllowUserToOrderColumns = true;
            this.grdPartnersDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPartnersDetails.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPartnersDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPartnersDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPartnersDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdPartnersDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartnersDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcPartnersDetails_LegalName,
            this.grcPartnersDetails_FactName,
            this.grcPartnersDetails_Inn,
            this.grcPartnersDetails_LegalAddress,
            this.grcPartnersDetails_BankName,
            this.grcPartnersDetails_PAccount,
            this.grcPartnersDetails_AutoSelected,
            this.grcPartnersDetails_ID});
            this.grdPartnersDetails.IsCheckerInclude = true;
            this.grdPartnersDetails.IsConfigInclude = true;
            this.grdPartnersDetails.IsMarkedAll = false;
            this.grdPartnersDetails.IsStatusInclude = true;
            this.grdPartnersDetails.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdPartnersDetails.Location = new System.Drawing.Point(-1, -1);
            this.grdPartnersDetails.MultiSelect = false;
            this.grdPartnersDetails.Name = "grdPartnersDetails";
            this.grdPartnersDetails.RangedWay = ' ';
            this.grdPartnersDetails.ReadOnly = true;
            this.grdPartnersDetails.RowHeadersWidth = 24;
            this.grdPartnersDetails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartnersDetails.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdPartnersDetails.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdPartnersDetails.Size = new System.Drawing.Size(719, 97);
            this.grdPartnersDetails.TabIndex = 12;
            // 
            // grcPartnersDetails_LegalName
            // 
            this.grcPartnersDetails_LegalName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_LegalName.DataPropertyName = "LegalName";
            this.grcPartnersDetails_LegalName.HeaderText = "Юр.название";
            this.grcPartnersDetails_LegalName.Name = "grcPartnersDetails_LegalName";
            this.grcPartnersDetails_LegalName.ReadOnly = true;
            this.grcPartnersDetails_LegalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_LegalName.Width = 200;
            // 
            // grcPartnersDetails_FactName
            // 
            this.grcPartnersDetails_FactName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_FactName.DataPropertyName = "FactName";
            this.grcPartnersDetails_FactName.HeaderText = "Факт.название (грузоотправитель)";
            this.grcPartnersDetails_FactName.Name = "grcPartnersDetails_FactName";
            this.grcPartnersDetails_FactName.ReadOnly = true;
            this.grcPartnersDetails_FactName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_FactName.Width = 200;
            // 
            // grcPartnersDetails_Inn
            // 
            this.grcPartnersDetails_Inn.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_Inn.DataPropertyName = "INN";
            this.grcPartnersDetails_Inn.HeaderText = "ИНН";
            this.grcPartnersDetails_Inn.Name = "grcPartnersDetails_Inn";
            this.grcPartnersDetails_Inn.ReadOnly = true;
            this.grcPartnersDetails_Inn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersDetails_LegalAddress
            // 
            this.grcPartnersDetails_LegalAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_LegalAddress.DataPropertyName = "LegalAddress";
            this.grcPartnersDetails_LegalAddress.HeaderText = "Юр.адрес";
            this.grcPartnersDetails_LegalAddress.Name = "grcPartnersDetails_LegalAddress";
            this.grcPartnersDetails_LegalAddress.ReadOnly = true;
            this.grcPartnersDetails_LegalAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_LegalAddress.Width = 200;
            // 
            // grcPartnersDetails_BankName
            // 
            this.grcPartnersDetails_BankName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_BankName.DataPropertyName = "BankName";
            this.grcPartnersDetails_BankName.HeaderText = "Банк";
            this.grcPartnersDetails_BankName.Name = "grcPartnersDetails_BankName";
            this.grcPartnersDetails_BankName.ReadOnly = true;
            this.grcPartnersDetails_BankName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_BankName.Width = 200;
            // 
            // grcPartnersDetails_PAccount
            // 
            this.grcPartnersDetails_PAccount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_PAccount.DataPropertyName = "PAccount";
            this.grcPartnersDetails_PAccount.HeaderText = "Р/счет";
            this.grcPartnersDetails_PAccount.Name = "grcPartnersDetails_PAccount";
            this.grcPartnersDetails_PAccount.ReadOnly = true;
            this.grcPartnersDetails_PAccount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_PAccount.Width = 120;
            // 
            // grcPartnersDetails_AutoSelected
            // 
            this.grcPartnersDetails_AutoSelected.DataPropertyName = "AutoSelected";
            this.grcPartnersDetails_AutoSelected.HeaderText = "Осн.";
            this.grcPartnersDetails_AutoSelected.Name = "grcPartnersDetails_AutoSelected";
            this.grcPartnersDetails_AutoSelected.ReadOnly = true;
            this.grcPartnersDetails_AutoSelected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_AutoSelected.ToolTipText = "Основной реквизит?";
            this.grcPartnersDetails_AutoSelected.Width = 40;
            // 
            // grcPartnersDetails_ID
            // 
            this.grcPartnersDetails_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersDetails_ID.DataPropertyName = "ID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcPartnersDetails_ID.DefaultCellStyle = dataGridViewCellStyle9;
            this.grcPartnersDetails_ID.HeaderText = "ID";
            this.grcPartnersDetails_ID.Name = "grcPartnersDetails_ID";
            this.grcPartnersDetails_ID.ReadOnly = true;
            this.grcPartnersDetails_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersDetails_ID.ToolTipText = "Код реквизитов";
            this.grcPartnersDetails_ID.Width = 50;
            // 
            // tabPartners_PartnersGoods
            // 
            this.tabPartners_PartnersGoods.Controls.Add(this.grdPartnersGoods);
            this.tabPartners_PartnersGoods.Location = new System.Drawing.Point(4, 4);
            this.tabPartners_PartnersGoods.Name = "tabPartners_PartnersGoods";
            this.tabPartners_PartnersGoods.Padding = new System.Windows.Forms.Padding(3);
            this.tabPartners_PartnersGoods.Size = new System.Drawing.Size(719, 99);
            this.tabPartners_PartnersGoods.TabIndex = 0;
            this.tabPartners_PartnersGoods.Text = "Товары (спец.)";
            this.tabPartners_PartnersGoods.UseVisualStyleBackColor = true;
            // 
            // grdPartnersGoods
            // 
            this.grdPartnersGoods.AllowUserToAddRows = false;
            this.grdPartnersGoods.AllowUserToDeleteRows = false;
            this.grdPartnersGoods.AllowUserToOrderColumns = true;
            this.grdPartnersGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPartnersGoods.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPartnersGoods.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPartnersGoods.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPartnersGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grdPartnersGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartnersGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcPartnersGoods_GoodName,
            this.grcPartnersGoods_InBox,
            this.grcPartnersGoods_SP_GoodName,
            this.grcPartnersGoods_SP_GoodCode,
            this.grcPartnersGoods_SP_Articul,
            this.grcPartnersGoods_SP_Vat,
            this.grcPartnersGoods_SP_ByOrder,
            this.grcPartnersGoods_ERPCode,
            this.grcPartnersGoods_ID});
            this.grdPartnersGoods.IsCheckerInclude = true;
            this.grdPartnersGoods.IsConfigInclude = true;
            this.grdPartnersGoods.IsMarkedAll = false;
            this.grdPartnersGoods.IsStatusInclude = true;
            this.grdPartnersGoods.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdPartnersGoods.Location = new System.Drawing.Point(-1, -1);
            this.grdPartnersGoods.MultiSelect = false;
            this.grdPartnersGoods.Name = "grdPartnersGoods";
            this.grdPartnersGoods.RangedWay = ' ';
            this.grdPartnersGoods.ReadOnly = true;
            this.grdPartnersGoods.RowHeadersWidth = 24;
            this.grdPartnersGoods.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartnersGoods.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdPartnersGoods.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdPartnersGoods.Size = new System.Drawing.Size(719, 97);
            this.grdPartnersGoods.TabIndex = 13;
            this.grdPartnersGoods.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPartnersGoods_CellFormatting);
            // 
            // grcPartnersGoods_GoodName
            // 
            this.grcPartnersGoods_GoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_GoodName.DataPropertyName = "GoodName";
            this.grcPartnersGoods_GoodName.HeaderText = "Название товара наше";
            this.grcPartnersGoods_GoodName.Name = "grcPartnersGoods_GoodName";
            this.grcPartnersGoods_GoodName.ReadOnly = true;
            this.grcPartnersGoods_GoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_GoodName.Width = 250;
            // 
            // grcPartnersGoods_InBox
            // 
            this.grcPartnersGoods_InBox.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_InBox.DataPropertyName = "InBox";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            this.grcPartnersGoods_InBox.DefaultCellStyle = dataGridViewCellStyle11;
            this.grcPartnersGoods_InBox.HeaderText = "В кор.";
            this.grcPartnersGoods_InBox.Name = "grcPartnersGoods_InBox";
            this.grcPartnersGoods_InBox.ReadOnly = true;
            this.grcPartnersGoods_InBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_InBox.ToolTipText = "Штук в коробке";
            this.grcPartnersGoods_InBox.Width = 60;
            // 
            // grcPartnersGoods_SP_GoodName
            // 
            this.grcPartnersGoods_SP_GoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_SP_GoodName.DataPropertyName = "SP_GoodName";
            this.grcPartnersGoods_SP_GoodName.HeaderText = "Название товара для партнера";
            this.grcPartnersGoods_SP_GoodName.Name = "grcPartnersGoods_SP_GoodName";
            this.grcPartnersGoods_SP_GoodName.ReadOnly = true;
            this.grcPartnersGoods_SP_GoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_SP_GoodName.Width = 250;
            // 
            // grcPartnersGoods_SP_GoodCode
            // 
            this.grcPartnersGoods_SP_GoodCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_SP_GoodCode.DataPropertyName = "SP_GoodCode";
            this.grcPartnersGoods_SP_GoodCode.HeaderText = "Код для партнера";
            this.grcPartnersGoods_SP_GoodCode.Name = "grcPartnersGoods_SP_GoodCode";
            this.grcPartnersGoods_SP_GoodCode.ReadOnly = true;
            this.grcPartnersGoods_SP_GoodCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersGoods_SP_Articul
            // 
            this.grcPartnersGoods_SP_Articul.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_SP_Articul.DataPropertyName = "SP_Articul";
            this.grcPartnersGoods_SP_Articul.HeaderText = "Артикул для партнера";
            this.grcPartnersGoods_SP_Articul.Name = "grcPartnersGoods_SP_Articul";
            this.grcPartnersGoods_SP_Articul.ReadOnly = true;
            this.grcPartnersGoods_SP_Articul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersGoods_SP_Vat
            // 
            this.grcPartnersGoods_SP_Vat.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_SP_Vat.DataPropertyName = "SP_Vat";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "###";
            this.grcPartnersGoods_SP_Vat.DefaultCellStyle = dataGridViewCellStyle12;
            this.grcPartnersGoods_SP_Vat.HeaderText = "НДС %";
            this.grcPartnersGoods_SP_Vat.Name = "grcPartnersGoods_SP_Vat";
            this.grcPartnersGoods_SP_Vat.ReadOnly = true;
            this.grcPartnersGoods_SP_Vat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_SP_Vat.ToolTipText = "Специальная ставка НДС, %";
            this.grcPartnersGoods_SP_Vat.Width = 52;
            // 
            // grcPartnersGoods_SP_ByOrder
            // 
            this.grcPartnersGoods_SP_ByOrder.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_SP_ByOrder.DataPropertyName = "SP_ByOrder";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "######";
            this.grcPartnersGoods_SP_ByOrder.DefaultCellStyle = dataGridViewCellStyle13;
            this.grcPartnersGoods_SP_ByOrder.HeaderText = "№ п/п";
            this.grcPartnersGoods_SP_ByOrder.Name = "grcPartnersGoods_SP_ByOrder";
            this.grcPartnersGoods_SP_ByOrder.ReadOnly = true;
            this.grcPartnersGoods_SP_ByOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_SP_ByOrder.ToolTipText = "Специальный № по порядку";
            this.grcPartnersGoods_SP_ByOrder.Width = 50;
            // 
            // grcPartnersGoods_ERPCode
            // 
            this.grcPartnersGoods_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_ERPCode.DataPropertyName = "ERPCode";
            this.grcPartnersGoods_ERPCode.HeaderText = "ERPCode";
            this.grcPartnersGoods_ERPCode.Name = "grcPartnersGoods_ERPCode";
            this.grcPartnersGoods_ERPCode.ReadOnly = true;
            this.grcPartnersGoods_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_ERPCode.ToolTipText = "Код в host-системе";
            this.grcPartnersGoods_ERPCode.Width = 80;
            // 
            // grcPartnersGoods_ID
            // 
            this.grcPartnersGoods_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersGoods_ID.DataPropertyName = "ID";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcPartnersGoods_ID.DefaultCellStyle = dataGridViewCellStyle14;
            this.grcPartnersGoods_ID.HeaderText = "ID";
            this.grcPartnersGoods_ID.Name = "grcPartnersGoods_ID";
            this.grcPartnersGoods_ID.ReadOnly = true;
            this.grcPartnersGoods_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersGoods_ID.ToolTipText = "Код записи";
            this.grcPartnersGoods_ID.Width = 50;
            // 
            // tabPartnersRoots
            // 
            this.tabPartnersRoots.Controls.Add(this.cntPartnersRoots);
            this.tabPartnersRoots.Location = new System.Drawing.Point(4, 23);
            this.tabPartnersRoots.Name = "tabPartnersRoots";
            this.tabPartnersRoots.Size = new System.Drawing.Size(733, 402);
            this.tabPartnersRoots.TabIndex = 2;
            this.tabPartnersRoots.Text = "Объединения";
            this.tabPartnersRoots.UseVisualStyleBackColor = true;
            // 
            // cntPartnersRoots
            // 
            this.cntPartnersRoots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cntPartnersRoots.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cntPartnersRoots.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cntPartnersRoots.Location = new System.Drawing.Point(0, 2);
            this.cntPartnersRoots.Name = "cntPartnersRoots";
            this.cntPartnersRoots.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntPartnersRoots.Panel1
            // 
            this.cntPartnersRoots.Panel1.Controls.Add(this.grdPartnersRoots);
            // 
            // cntPartnersRoots.Panel2
            // 
            this.cntPartnersRoots.Panel2.Controls.Add(this.tcPartnersRoots);
            this.cntPartnersRoots.Size = new System.Drawing.Size(732, 400);
            this.cntPartnersRoots.SplitterDistance = 267;
            this.cntPartnersRoots.SplitterWidth = 2;
            this.cntPartnersRoots.TabIndex = 1;
            // 
            // grdPartnersRoots
            // 
            this.grdPartnersRoots.AllowUserToAddRows = false;
            this.grdPartnersRoots.AllowUserToDeleteRows = false;
            this.grdPartnersRoots.AllowUserToOrderColumns = true;
            this.grdPartnersRoots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPartnersRoots.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPartnersRoots.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPartnersRoots.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.grdPartnersRoots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartnersRoots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcPartnersRoots_Name,
            this.grcPartnersRoots_Alias,
            this.grcPartnersRoots_INN,
            this.grcPartnersRoots_Gravity,
            this.grcPartnersRoots_ERPCode,
            this.grcPartnersRoots_ID});
            this.grdPartnersRoots.IsCheckerInclude = true;
            this.grdPartnersRoots.IsConfigInclude = true;
            this.grdPartnersRoots.IsMarkedAll = false;
            this.grdPartnersRoots.IsStatusInclude = true;
            this.grdPartnersRoots.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdPartnersRoots.Location = new System.Drawing.Point(0, 0);
            this.grdPartnersRoots.MultiSelect = false;
            this.grdPartnersRoots.Name = "grdPartnersRoots";
            this.grdPartnersRoots.RangedWay = ' ';
            this.grdPartnersRoots.ReadOnly = true;
            this.grdPartnersRoots.RowHeadersWidth = 24;
            this.grdPartnersRoots.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartnersRoots.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdPartnersRoots.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdPartnersRoots.Size = new System.Drawing.Size(730, 264);
            this.grdPartnersRoots.TabIndex = 11;
            this.grdPartnersRoots.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdPartnersRoots_CurrentRowChanged);
            this.grdPartnersRoots.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPartnersRoots_CellFormatting);
            // 
            // grcPartnersRoots_Name
            // 
            this.grcPartnersRoots_Name.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Name.DataPropertyName = "Name";
            this.grcPartnersRoots_Name.HeaderText = "Наименование";
            this.grcPartnersRoots_Name.Name = "grcPartnersRoots_Name";
            this.grcPartnersRoots_Name.ReadOnly = true;
            this.grcPartnersRoots_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Name.Width = 200;
            // 
            // grcPartnersRoots_Alias
            // 
            this.grcPartnersRoots_Alias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Alias.DataPropertyName = "Alias";
            this.grcPartnersRoots_Alias.HeaderText = "Кратко";
            this.grcPartnersRoots_Alias.Name = "grcPartnersRoots_Alias";
            this.grcPartnersRoots_Alias.ReadOnly = true;
            this.grcPartnersRoots_Alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersRoots_INN
            // 
            this.grcPartnersRoots_INN.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_INN.DataPropertyName = "INN";
            this.grcPartnersRoots_INN.HeaderText = "ИНН";
            this.grcPartnersRoots_INN.Name = "grcPartnersRoots_INN";
            this.grcPartnersRoots_INN.ReadOnly = true;
            this.grcPartnersRoots_INN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersRoots_Gravity
            // 
            this.grcPartnersRoots_Gravity.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Gravity.DataPropertyName = "Gravity";
            this.grcPartnersRoots_Gravity.HeaderText = "Важность";
            this.grcPartnersRoots_Gravity.Name = "grcPartnersRoots_Gravity";
            this.grcPartnersRoots_Gravity.ReadOnly = true;
            this.grcPartnersRoots_Gravity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Gravity.Width = 70;
            // 
            // grcPartnersRoots_ERPCode
            // 
            this.grcPartnersRoots_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_ERPCode.DataPropertyName = "ERPCode";
            this.grcPartnersRoots_ERPCode.HeaderText = "ERPCode";
            this.grcPartnersRoots_ERPCode.Name = "grcPartnersRoots_ERPCode";
            this.grcPartnersRoots_ERPCode.ReadOnly = true;
            this.grcPartnersRoots_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_ERPCode.ToolTipText = "Код в host-системе";
            this.grcPartnersRoots_ERPCode.Width = 80;
            // 
            // grcPartnersRoots_ID
            // 
            this.grcPartnersRoots_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_ID.DataPropertyName = "ID";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcPartnersRoots_ID.DefaultCellStyle = dataGridViewCellStyle16;
            this.grcPartnersRoots_ID.HeaderText = "ID";
            this.grcPartnersRoots_ID.Name = "grcPartnersRoots_ID";
            this.grcPartnersRoots_ID.ReadOnly = true;
            this.grcPartnersRoots_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_ID.ToolTipText = "Код партнера";
            this.grcPartnersRoots_ID.Width = 50;
            // 
            // tcPartnersRoots
            // 
            this.tcPartnersRoots.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcPartnersRoots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPartnersRoots.Controls.Add(this.tabPartnersRoots_Partners);
            this.tcPartnersRoots.ItemSize = new System.Drawing.Size(120, 18);
            this.tcPartnersRoots.Location = new System.Drawing.Point(1, 1);
            this.tcPartnersRoots.Multiline = true;
            this.tcPartnersRoots.Name = "tcPartnersRoots";
            this.tcPartnersRoots.SelectedIndex = 0;
            this.tcPartnersRoots.Size = new System.Drawing.Size(728, 126);
            this.tcPartnersRoots.TabIndex = 0;
            // 
            // tabPartnersRoots_Partners
            // 
            this.tabPartnersRoots_Partners.Controls.Add(this.grdPartnersRoots_Partners);
            this.tabPartnersRoots_Partners.Location = new System.Drawing.Point(4, 4);
            this.tabPartnersRoots_Partners.Name = "tabPartnersRoots_Partners";
            this.tabPartnersRoots_Partners.Size = new System.Drawing.Size(720, 100);
            this.tabPartnersRoots_Partners.TabIndex = 1;
            this.tabPartnersRoots_Partners.Text = "Клиенты";
            this.tabPartnersRoots_Partners.UseVisualStyleBackColor = true;
            // 
            // grdPartnersRoots_Partners
            // 
            this.grdPartnersRoots_Partners.AllowUserToAddRows = false;
            this.grdPartnersRoots_Partners.AllowUserToDeleteRows = false;
            this.grdPartnersRoots_Partners.AllowUserToOrderColumns = true;
            this.grdPartnersRoots_Partners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPartnersRoots_Partners.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPartnersRoots_Partners.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPartnersRoots_Partners.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPartnersRoots_Partners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.grdPartnersRoots_Partners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPartnersRoots_Partners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcPartnersRoots_Partners_Name,
            this.grcPartnersRoots_Partners_PartnersGoodsExists,
            this.grcPartnersRoots_Partners_LegalName,
            this.grcPartnersRoots_Partners_Inn,
            this.grcPartnersRoots_Partners_ZoneName,
            this.grcPartnersRoots_Partners_PermitLevelName,
            this.grcPartnersRoots_Partners_PartnerRootName,
            this.grcPartnersRoots_Partners_DeliveryAddress,
            this.grcPartnersRoots_Partners_DeliveryPassage,
            this.grcPartnersRoots_Partners_DeliveryRestriction,
            this.grcPartnersRoots_Partners_ContactsInfo,
            this.grcPartnersRoots_Partners_Gravity,
            this.grcPartnersRoots_Partners_Actual,
            this.grcPartnersRoots_Partners_IsCustomer,
            this.grcPartnersRoots_Partners_IsSupplier,
            this.grcPartnersRoots_Partners_ERPCode,
            this.grcPartnersRoots_Partners_ID});
            this.grdPartnersRoots_Partners.IsCheckerInclude = true;
            this.grdPartnersRoots_Partners.IsConfigInclude = true;
            this.grdPartnersRoots_Partners.IsMarkedAll = false;
            this.grdPartnersRoots_Partners.IsStatusInclude = true;
            this.grdPartnersRoots_Partners.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdPartnersRoots_Partners.Location = new System.Drawing.Point(-1, -1);
            this.grdPartnersRoots_Partners.MultiSelect = false;
            this.grdPartnersRoots_Partners.Name = "grdPartnersRoots_Partners";
            this.grdPartnersRoots_Partners.RangedWay = ' ';
            this.grdPartnersRoots_Partners.ReadOnly = true;
            this.grdPartnersRoots_Partners.RowHeadersWidth = 24;
            this.grdPartnersRoots_Partners.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPartnersRoots_Partners.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdPartnersRoots_Partners.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdPartnersRoots_Partners.Size = new System.Drawing.Size(720, 98);
            this.grdPartnersRoots_Partners.TabIndex = 12;
            this.grdPartnersRoots_Partners.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdPartnersRoots_Partners_CellFormatting);
            // 
            // grcPartnersRoots_Partners_Name
            // 
            this.grcPartnersRoots_Partners_Name.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_Name.DataPropertyName = "Name";
            this.grcPartnersRoots_Partners_Name.HeaderText = "Наименование";
            this.grcPartnersRoots_Partners_Name.Name = "grcPartnersRoots_Partners_Name";
            this.grcPartnersRoots_Partners_Name.ReadOnly = true;
            this.grcPartnersRoots_Partners_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_Name.Width = 200;
            // 
            // grcPartnersRoots_Partners_PartnersGoodsExists
            // 
            this.grcPartnersRoots_Partners_PartnersGoodsExists.DataPropertyName = "PartnersGoodsExists";
            this.grcPartnersRoots_Partners_PartnersGoodsExists.HeaderText = "Спец.";
            this.grcPartnersRoots_Partners_PartnersGoodsExists.Name = "grcPartnersRoots_Partners_PartnersGoodsExists";
            this.grcPartnersRoots_Partners_PartnersGoodsExists.ReadOnly = true;
            this.grcPartnersRoots_Partners_PartnersGoodsExists.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcPartnersRoots_Partners_PartnersGoodsExists.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_PartnersGoodsExists.ToolTipText = "Есть спецальные данные о товарах для клиента?";
            this.grcPartnersRoots_Partners_PartnersGoodsExists.Width = 45;
            // 
            // grcPartnersRoots_Partners_LegalName
            // 
            this.grcPartnersRoots_Partners_LegalName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_LegalName.DataPropertyName = "LegalName";
            this.grcPartnersRoots_Partners_LegalName.HeaderText = "Юридическое название";
            this.grcPartnersRoots_Partners_LegalName.Name = "grcPartnersRoots_Partners_LegalName";
            this.grcPartnersRoots_Partners_LegalName.ReadOnly = true;
            this.grcPartnersRoots_Partners_LegalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_LegalName.Width = 200;
            // 
            // grcPartnersRoots_Partners_Inn
            // 
            this.grcPartnersRoots_Partners_Inn.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_Inn.DataPropertyName = "INN";
            this.grcPartnersRoots_Partners_Inn.HeaderText = "ИНН";
            this.grcPartnersRoots_Partners_Inn.Name = "grcPartnersRoots_Partners_Inn";
            this.grcPartnersRoots_Partners_Inn.ReadOnly = true;
            this.grcPartnersRoots_Partners_Inn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersRoots_Partners_ZoneName
            // 
            this.grcPartnersRoots_Partners_ZoneName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_ZoneName.DataPropertyName = "ZoneName";
            this.grcPartnersRoots_Partners_ZoneName.HeaderText = "Зона";
            this.grcPartnersRoots_Partners_ZoneName.Name = "grcPartnersRoots_Partners_ZoneName";
            this.grcPartnersRoots_Partners_ZoneName.ReadOnly = true;
            this.grcPartnersRoots_Partners_ZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersRoots_Partners_PermitLevelName
            // 
            this.grcPartnersRoots_Partners_PermitLevelName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_PermitLevelName.DataPropertyName = "PermitLevelName";
            this.grcPartnersRoots_Partners_PermitLevelName.HeaderText = "Разрешение";
            this.grcPartnersRoots_Partners_PermitLevelName.Name = "grcPartnersRoots_Partners_PermitLevelName";
            this.grcPartnersRoots_Partners_PermitLevelName.ReadOnly = true;
            this.grcPartnersRoots_Partners_PermitLevelName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_PermitLevelName.ToolTipText = "Разрешение на проезд";
            // 
            // grcPartnersRoots_Partners_PartnerRootName
            // 
            this.grcPartnersRoots_Partners_PartnerRootName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_PartnerRootName.DataPropertyName = "PartnerRootName";
            this.grcPartnersRoots_Partners_PartnerRootName.HeaderText = "Объединение";
            this.grcPartnersRoots_Partners_PartnerRootName.Name = "grcPartnersRoots_Partners_PartnerRootName";
            this.grcPartnersRoots_Partners_PartnerRootName.ReadOnly = true;
            this.grcPartnersRoots_Partners_PartnerRootName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcPartnersRoots_Partners_DeliveryAddress
            // 
            this.grcPartnersRoots_Partners_DeliveryAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_DeliveryAddress.DataPropertyName = "DeliveryAddress";
            this.grcPartnersRoots_Partners_DeliveryAddress.HeaderText = "Адрес доставки";
            this.grcPartnersRoots_Partners_DeliveryAddress.Name = "grcPartnersRoots_Partners_DeliveryAddress";
            this.grcPartnersRoots_Partners_DeliveryAddress.ReadOnly = true;
            this.grcPartnersRoots_Partners_DeliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_DeliveryAddress.Width = 200;
            // 
            // grcPartnersRoots_Partners_DeliveryPassage
            // 
            this.grcPartnersRoots_Partners_DeliveryPassage.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_DeliveryPassage.DataPropertyName = "DeliveryPassage";
            this.grcPartnersRoots_Partners_DeliveryPassage.HeaderText = "Проезд";
            this.grcPartnersRoots_Partners_DeliveryPassage.Name = "grcPartnersRoots_Partners_DeliveryPassage";
            this.grcPartnersRoots_Partners_DeliveryPassage.ReadOnly = true;
            this.grcPartnersRoots_Partners_DeliveryPassage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_DeliveryPassage.Width = 200;
            // 
            // grcPartnersRoots_Partners_DeliveryRestriction
            // 
            this.grcPartnersRoots_Partners_DeliveryRestriction.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_DeliveryRestriction.DataPropertyName = "DeliveryRestriction";
            this.grcPartnersRoots_Partners_DeliveryRestriction.HeaderText = "Ограничения по доставке";
            this.grcPartnersRoots_Partners_DeliveryRestriction.Name = "grcPartnersRoots_Partners_DeliveryRestriction";
            this.grcPartnersRoots_Partners_DeliveryRestriction.ReadOnly = true;
            this.grcPartnersRoots_Partners_DeliveryRestriction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_DeliveryRestriction.Width = 200;
            // 
            // grcPartnersRoots_Partners_ContactsInfo
            // 
            this.grcPartnersRoots_Partners_ContactsInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_ContactsInfo.DataPropertyName = "ContactsInfo";
            this.grcPartnersRoots_Partners_ContactsInfo.HeaderText = "Контакты";
            this.grcPartnersRoots_Partners_ContactsInfo.Name = "grcPartnersRoots_Partners_ContactsInfo";
            this.grcPartnersRoots_Partners_ContactsInfo.ReadOnly = true;
            this.grcPartnersRoots_Partners_ContactsInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_ContactsInfo.Width = 200;
            // 
            // grcPartnersRoots_Partners_Gravity
            // 
            this.grcPartnersRoots_Partners_Gravity.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_Gravity.DataPropertyName = "Gravity";
            this.grcPartnersRoots_Partners_Gravity.HeaderText = "Важность";
            this.grcPartnersRoots_Partners_Gravity.Name = "grcPartnersRoots_Partners_Gravity";
            this.grcPartnersRoots_Partners_Gravity.ReadOnly = true;
            this.grcPartnersRoots_Partners_Gravity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_Gravity.Width = 60;
            // 
            // grcPartnersRoots_Partners_Actual
            // 
            this.grcPartnersRoots_Partners_Actual.DataPropertyName = "Actual";
            this.grcPartnersRoots_Partners_Actual.HeaderText = "Акт.";
            this.grcPartnersRoots_Partners_Actual.Name = "grcPartnersRoots_Partners_Actual";
            this.grcPartnersRoots_Partners_Actual.ReadOnly = true;
            this.grcPartnersRoots_Partners_Actual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_Actual.Width = 40;
            // 
            // grcPartnersRoots_Partners_IsCustomer
            // 
            this.grcPartnersRoots_Partners_IsCustomer.DataPropertyName = "IsCustomer";
            this.grcPartnersRoots_Partners_IsCustomer.HeaderText = "Покупатель";
            this.grcPartnersRoots_Partners_IsCustomer.Name = "grcPartnersRoots_Partners_IsCustomer";
            this.grcPartnersRoots_Partners_IsCustomer.ReadOnly = true;
            this.grcPartnersRoots_Partners_IsCustomer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_IsCustomer.Width = 50;
            // 
            // grcPartnersRoots_Partners_IsSupplier
            // 
            this.grcPartnersRoots_Partners_IsSupplier.DataPropertyName = "IsSupplier";
            this.grcPartnersRoots_Partners_IsSupplier.HeaderText = "Поставщик";
            this.grcPartnersRoots_Partners_IsSupplier.Name = "grcPartnersRoots_Partners_IsSupplier";
            this.grcPartnersRoots_Partners_IsSupplier.ReadOnly = true;
            this.grcPartnersRoots_Partners_IsSupplier.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcPartnersRoots_Partners_IsSupplier.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_IsSupplier.Width = 50;
            // 
            // grcPartnersRoots_Partners_ERPCode
            // 
            this.grcPartnersRoots_Partners_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_ERPCode.DataPropertyName = "ERPCode";
            this.grcPartnersRoots_Partners_ERPCode.HeaderText = "ERPCode";
            this.grcPartnersRoots_Partners_ERPCode.Name = "grcPartnersRoots_Partners_ERPCode";
            this.grcPartnersRoots_Partners_ERPCode.ReadOnly = true;
            this.grcPartnersRoots_Partners_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_ERPCode.ToolTipText = "Код в host-системе";
            this.grcPartnersRoots_Partners_ERPCode.Width = 80;
            // 
            // grcPartnersRoots_Partners_ID
            // 
            this.grcPartnersRoots_Partners_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnersRoots_Partners_ID.DataPropertyName = "ID";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcPartnersRoots_Partners_ID.DefaultCellStyle = dataGridViewCellStyle18;
            this.grcPartnersRoots_Partners_ID.HeaderText = "ID";
            this.grcPartnersRoots_Partners_ID.Name = "grcPartnersRoots_Partners_ID";
            this.grcPartnersRoots_Partners_ID.ReadOnly = true;
            this.grcPartnersRoots_Partners_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnersRoots_Partners_ID.ToolTipText = "Код партнера";
            this.grcPartnersRoots_Partners_ID.Width = 50;
            // 
            // tabPrintForms
            // 
            this.tabPrintForms.Controls.Add(this.cntPrintForms);
            this.tabPrintForms.Location = new System.Drawing.Point(4, 23);
            this.tabPrintForms.Name = "tabPrintForms";
            this.tabPrintForms.Size = new System.Drawing.Size(733, 402);
            this.tabPrintForms.TabIndex = 3;
            this.tabPrintForms.Text = "Шаблоны печатных форм";
            this.tabPrintForms.UseVisualStyleBackColor = true;
            // 
            // cntPrintForms
            // 
            this.cntPrintForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cntPrintForms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cntPrintForms.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cntPrintForms.Location = new System.Drawing.Point(0, 2);
            this.cntPrintForms.Name = "cntPrintForms";
            this.cntPrintForms.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cntPrintForms.Panel1
            // 
            this.cntPrintForms.Panel1.Controls.Add(this.grdPrintForms);
            // 
            // cntPrintForms.Panel2
            // 
            this.cntPrintForms.Panel2.Controls.Add(this.tcPrintForms);
            this.cntPrintForms.Size = new System.Drawing.Size(732, 400);
            this.cntPrintForms.SplitterDistance = 267;
            this.cntPrintForms.SplitterWidth = 2;
            this.cntPrintForms.TabIndex = 2;
            // 
            // grdPrintForms
            // 
            this.grdPrintForms.AllowUserToAddRows = false;
            this.grdPrintForms.AllowUserToDeleteRows = false;
            this.grdPrintForms.AllowUserToOrderColumns = true;
            this.grdPrintForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPrintForms.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPrintForms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrintForms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.grdPrintForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrintForms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcPrintForms_PF_Type,
            this.grcPrintForms_PF_Name,
            this.grcPrintForms_TemplateHasText,
            this.grcPrintForms_LinesInPage,
            this.grcPrintForms_Note,
            this.grcPrintForms_ERPCode,
            this.grcPrintForms_ID});
            this.grdPrintForms.IsCheckerInclude = true;
            this.grdPrintForms.IsConfigInclude = true;
            this.grdPrintForms.IsMarkedAll = false;
            this.grdPrintForms.IsStatusInclude = true;
            this.grdPrintForms.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdPrintForms.Location = new System.Drawing.Point(0, 0);
            this.grdPrintForms.MultiSelect = false;
            this.grdPrintForms.Name = "grdPrintForms";
            this.grdPrintForms.RangedWay = ' ';
            this.grdPrintForms.ReadOnly = true;
            this.grdPrintForms.RowHeadersWidth = 24;
            this.grdPrintForms.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrintForms.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdPrintForms.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdPrintForms.Size = new System.Drawing.Size(729, 264);
            this.grdPrintForms.TabIndex = 11;
            this.grdPrintForms.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdPrintForms_CurrentRowChanged);
            // 
            // grcPrintForms_PF_Type
            // 
            this.grcPrintForms_PF_Type.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_PF_Type.DataPropertyName = "PF_Type";
            this.grcPrintForms_PF_Type.HeaderText = "Тип ПФ";
            this.grcPrintForms_PF_Type.Name = "grcPrintForms_PF_Type";
            this.grcPrintForms_PF_Type.ReadOnly = true;
            this.grcPrintForms_PF_Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_PF_Type.ToolTipText = "Тип печатной формы";
            // 
            // grcPrintForms_PF_Name
            // 
            this.grcPrintForms_PF_Name.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_PF_Name.DataPropertyName = "PF_Name";
            this.grcPrintForms_PF_Name.HeaderText = "Наименование ПФ";
            this.grcPrintForms_PF_Name.Name = "grcPrintForms_PF_Name";
            this.grcPrintForms_PF_Name.ReadOnly = true;
            this.grcPrintForms_PF_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_PF_Name.ToolTipText = "Наименование печатной формы";
            this.grcPrintForms_PF_Name.Width = 150;
            // 
            // grcPrintForms_TemplateHasText
            // 
            this.grcPrintForms_TemplateHasText.DataPropertyName = "TemplateHasText";
            this.grcPrintForms_TemplateHasText.HeaderText = "XML?";
            this.grcPrintForms_TemplateHasText.Name = "grcPrintForms_TemplateHasText";
            this.grcPrintForms_TemplateHasText.ReadOnly = true;
            this.grcPrintForms_TemplateHasText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_TemplateHasText.ToolTipText = "XML-шаблон загружен?";
            this.grcPrintForms_TemplateHasText.Width = 60;
            // 
            // grcPrintForms_LinesInPage
            // 
            this.grcPrintForms_LinesInPage.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_LinesInPage.DataPropertyName = "LinesInPage";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "###";
            this.grcPrintForms_LinesInPage.DefaultCellStyle = dataGridViewCellStyle20;
            this.grcPrintForms_LinesInPage.HeaderText = "Строк";
            this.grcPrintForms_LinesInPage.Name = "grcPrintForms_LinesInPage";
            this.grcPrintForms_LinesInPage.ReadOnly = true;
            this.grcPrintForms_LinesInPage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_LinesInPage.ToolTipText = "Строк на странице (0 - не фиксировано)";
            this.grcPrintForms_LinesInPage.Width = 60;
            // 
            // grcPrintForms_Note
            // 
            this.grcPrintForms_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_Note.DataPropertyName = "Note";
            this.grcPrintForms_Note.HeaderText = "Примечание";
            this.grcPrintForms_Note.Name = "grcPrintForms_Note";
            this.grcPrintForms_Note.ReadOnly = true;
            this.grcPrintForms_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_Note.Width = 200;
            // 
            // grcPrintForms_ERPCode
            // 
            this.grcPrintForms_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_ERPCode.DataPropertyName = "ERPCode";
            this.grcPrintForms_ERPCode.HeaderText = "ERPCode";
            this.grcPrintForms_ERPCode.Name = "grcPrintForms_ERPCode";
            this.grcPrintForms_ERPCode.ReadOnly = true;
            this.grcPrintForms_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_ERPCode.ToolTipText = "Код в host-системе";
            this.grcPrintForms_ERPCode.Width = 80;
            // 
            // grcPrintForms_ID
            // 
            this.grcPrintForms_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_ID.DataPropertyName = "ID";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcPrintForms_ID.DefaultCellStyle = dataGridViewCellStyle21;
            this.grcPrintForms_ID.HeaderText = "ID";
            this.grcPrintForms_ID.Name = "grcPrintForms_ID";
            this.grcPrintForms_ID.ReadOnly = true;
            this.grcPrintForms_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_ID.ToolTipText = "Код печатной формы";
            this.grcPrintForms_ID.Width = 50;
            // 
            // tcPrintForms
            // 
            this.tcPrintForms.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcPrintForms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPrintForms.Controls.Add(this.tabPrintForms_Partners);
            this.tcPrintForms.ItemSize = new System.Drawing.Size(120, 18);
            this.tcPrintForms.Location = new System.Drawing.Point(1, 1);
            this.tcPrintForms.Multiline = true;
            this.tcPrintForms.Name = "tcPrintForms";
            this.tcPrintForms.SelectedIndex = 0;
            this.tcPrintForms.Size = new System.Drawing.Size(728, 126);
            this.tcPrintForms.TabIndex = 0;
            // 
            // tabPrintForms_Partners
            // 
            this.tabPrintForms_Partners.Controls.Add(this.grdPrintForms_Partners);
            this.tabPrintForms_Partners.Location = new System.Drawing.Point(4, 4);
            this.tabPrintForms_Partners.Name = "tabPrintForms_Partners";
            this.tabPrintForms_Partners.Size = new System.Drawing.Size(720, 100);
            this.tabPrintForms_Partners.TabIndex = 1;
            this.tabPrintForms_Partners.Text = "Клиенты";
            this.tabPrintForms_Partners.UseVisualStyleBackColor = true;
            // 
            // grdPrintForms_Partners
            // 
            this.grdPrintForms_Partners.AllowUserToAddRows = false;
            this.grdPrintForms_Partners.AllowUserToDeleteRows = false;
            this.grdPrintForms_Partners.AllowUserToOrderColumns = true;
            this.grdPrintForms_Partners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdPrintForms_Partners.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdPrintForms_Partners.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grdPrintForms_Partners.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPrintForms_Partners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.grdPrintForms_Partners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrintForms_Partners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcPrintForms_Partners_Name});
            this.grdPrintForms_Partners.IdTableColumnName = "PartnerID";
            this.grdPrintForms_Partners.IsCheckerInclude = true;
            this.grdPrintForms_Partners.IsConfigInclude = true;
            this.grdPrintForms_Partners.IsMarkedAll = false;
            this.grdPrintForms_Partners.IsStatusInclude = true;
            this.grdPrintForms_Partners.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdPrintForms_Partners.Location = new System.Drawing.Point(-1, -1);
            this.grdPrintForms_Partners.MultiSelect = false;
            this.grdPrintForms_Partners.Name = "grdPrintForms_Partners";
            this.grdPrintForms_Partners.RangedWay = ' ';
            this.grdPrintForms_Partners.ReadOnly = true;
            this.grdPrintForms_Partners.RowHeadersWidth = 24;
            this.grdPrintForms_Partners.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPrintForms_Partners.SelectedRowBorderColor = System.Drawing.SystemColors.Control;
            this.grdPrintForms_Partners.SelectedRowForeColor = System.Drawing.Color.Black;
            this.grdPrintForms_Partners.Size = new System.Drawing.Size(720, 98);
            this.grdPrintForms_Partners.TabIndex = 12;
            // 
            // grcPrintForms_Partners_Name
            // 
            this.grcPrintForms_Partners_Name.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPrintForms_Partners_Name.DataPropertyName = "Name";
            this.grcPrintForms_Partners_Name.HeaderText = "Наименование";
            this.grcPrintForms_Partners_Name.Name = "grcPrintForms_Partners_Name";
            this.grcPrintForms_Partners_Name.ReadOnly = true;
            this.grcPrintForms_Partners_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPrintForms_Partners_Name.Width = 300;
            // 
            // btnService
            // 
            this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnService.ContextMenuStrip = this.mnuPartnersService;
            this.btnService.Image = global::Logistics.Properties.Resources.Service;
            this.btnService.Location = new System.Drawing.Point(656, 438);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(30, 30);
            this.btnService.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnService, "Дополнительно");
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // mnuPartnersService
            // 
            this.mnuPartnersService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPartnersGoodsEdit,
            this.toolStripSeparator1,
            this.mniPartnersGoodsCopy,
            this.mniPartnersPFCopy});
            this.mnuPartnersService.Name = "mnuPartnersService";
            this.mnuPartnersService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuPartnersService.Size = new System.Drawing.Size(690, 76);
            // 
            // mniPartnersGoodsEdit
            // 
            this.mniPartnersGoodsEdit.Name = "mniPartnersGoodsEdit";
            this.mniPartnersGoodsEdit.Size = new System.Drawing.Size(689, 22);
            this.mniPartnersGoodsEdit.Text = "Спец.данные о товарах для клиента";
            this.mniPartnersGoodsEdit.Click += new System.EventHandler(this.mniPartnersGoodsEdit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(686, 6);
            // 
            // mniPartnersGoodsCopy
            // 
            this.mniPartnersGoodsCopy.Name = "mniPartnersGoodsCopy";
            this.mniPartnersGoodsCopy.Size = new System.Drawing.Size(689, 22);
            this.mniPartnersGoodsCopy.Text = "Копировать спец.данные о товарах текущего партнера для отмеченных партнеров";
            this.mniPartnersGoodsCopy.Click += new System.EventHandler(this.mniPartnersGoodsCopy_Click);
            // 
            // mniPartnersPFCopy
            // 
            this.mniPartnersPFCopy.Name = "mniPartnersPFCopy";
            this.mniPartnersPFCopy.Size = new System.Drawing.Size(689, 22);
            this.mniPartnersPFCopy.Text = "Копировать данные о шаблонах печатных форм текущего партнера для отмеченных партн" +
                "еров";
            this.mniPartnersPFCopy.Click += new System.EventHandler(this.mniPartnersPFCopy_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(606, 438);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(30, 30);
            this.btnPrint.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 438);
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
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDelete.IsAccessOn = true;
            this.btnDelete.Location = new System.Drawing.Point(556, 438);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.btnDelete, "Удаление");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
            this.btnAdd.IsAccessOn = true;
            this.btnAdd.Location = new System.Drawing.Point(456, 437);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 30);
            this.btnAdd.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnAdd, "Добавление");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::Logistics.Properties.Resources.Exit;
            this.btnCancel.Location = new System.Drawing.Point(706, 438);
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
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.IsAccessOn = true;
            this.btnEdit.Location = new System.Drawing.Point(506, 438);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tmrRestore
            // 
            this.tmrRestore.Tick += new System.EventHandler(this.tmrRestore_Tick);
            // 
            // mnuPartnersRootsService
            // 
            this.mnuPartnersRootsService.Name = "mnuPartnersRootsService";
            this.mnuPartnersRootsService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuPartnersRootsService.Size = new System.Drawing.Size(61, 4);
            // 
            // frmPartners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tcList);
            this.hpHelp.SetHelpKeyword(this, "102");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.hpHelp.SetHelpString(this, "");
            this.IsAccessOn = true;
            this.IsWaitLoading = true;
            this.LastGrid = this.grdData;
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmPartners";
            this.hpHelp.SetShowHelp(this, true);
            this.Text = "Партнеры";
            this.Load += new System.EventHandler(this.frmPartners_Load);
            this.tcList.ResumeLayout(false);
            this.tabTerms.ResumeLayout(false);
            this.cntTerms.ResumeLayout(false);
            this.cntTerms.PerformLayout();
            this.ucSelectRecordID_Hosts.ResumeLayout(false);
            this.ucSelectRecordID_Hosts.PerformLayout();
            this.ucSelectRecordID_Zones.ResumeLayout(false);
            this.ucSelectRecordID_Zones.PerformLayout();
            this.ucSelectRecordID_PartnersRoots.ResumeLayout(false);
            this.ucSelectRecordID_PartnersRoots.PerformLayout();
            this.pnlPartnersGoodsExists.ResumeLayout(false);
            this.pnlPartnersGoodsExists.PerformLayout();
            this.pnlActual.ResumeLayout(false);
            this.pnlActual.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.cntGrids.Panel1.ResumeLayout(false);
            this.cntGrids.Panel2.ResumeLayout(false);
            this.cntGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.tcPartners.ResumeLayout(false);
            this.tabPartners_Details.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersDetails)).EndInit();
            this.tabPartners_PartnersGoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersGoods)).EndInit();
            this.tabPartnersRoots.ResumeLayout(false);
            this.cntPartnersRoots.Panel1.ResumeLayout(false);
            this.cntPartnersRoots.Panel2.ResumeLayout(false);
            this.cntPartnersRoots.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersRoots)).EndInit();
            this.tcPartnersRoots.ResumeLayout(false);
            this.tabPartnersRoots_Partners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPartnersRoots_Partners)).EndInit();
            this.tabPrintForms.ResumeLayout(false);
            this.cntPrintForms.Panel1.ResumeLayout(false);
            this.cntPrintForms.Panel2.ResumeLayout(false);
            this.cntPrintForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrintForms)).EndInit();
            this.tcPrintForms.ResumeLayout(false);
            this.tabPrintForms_Partners.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPrintForms_Partners)).EndInit();
            this.mnuPartnersService.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnCancel;
		private RFMBaseClasses.RFMTabPage tabData;
		private RFMBaseClasses.RFMSplitContainer cntGrids;
        private RFMBaseClasses.RFMDataGridView grdData;
        private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMTabControl tcPartners;
		private RFMBaseClasses.RFMTabPage tabPartners_PartnersGoods;
		private RFMBaseClasses.RFMDataGridView grdPartnersGoods;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblActual;
		private RFMBaseClasses.RFMPanel pnlActual;
		private RFMBaseClasses.RFMRadioButton optActualNot;
		private RFMBaseClasses.RFMRadioButton optActual;
		private RFMBaseClasses.RFMRadioButton optActualAll;
		private RFMBaseClasses.RFMLabel lblInnContext;
		private RFMBaseClasses.RFMTextBox txtInnContext;
		private RFMBaseClasses.RFMLabel lblNameContext;
		private RFMBaseClasses.RFMTextBox txtNameContext;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMLabel lblPartnersRoots;
		private RFMBaseClasses.RFMLabel lblZones;
		private RFMBaseClasses.RFMCheckBox chkIsTransport;
		private RFMBaseClasses.RFMCheckBox chkIsSupplier;
        private RFMBaseClasses.RFMCheckBox chkIsCustomer;
		private RFMBaseClasses.RFMTimer tmrRestore;
		private RFMBaseClasses.RFMLabel lblPartnersGoodsExists;
		private RFMBaseClasses.RFMPanel pnlPartnersGoodsExists;
		private RFMBaseClasses.RFMRadioButton optPartnersGoodsExistsNot;
		private RFMBaseClasses.RFMRadioButton optPartnersGoodsExists;
		private RFMBaseClasses.RFMRadioButton optPartnersGoodsExistsAll;
		private RFMBaseClasses.RFMTabPage tabPartnersRoots;
		private RFMBaseClasses.RFMSplitContainer cntPartnersRoots;
		private RFMBaseClasses.RFMDataGridView grdPartnersRoots;
		private RFMBaseClasses.RFMTabControl tcPartnersRoots;
		private RFMBaseClasses.RFMTabPage tabPartnersRoots_Partners;
		private RFMBaseClasses.RFMDataGridView grdPartnersRoots_Partners;
		private RFMBaseClasses.RFMCheckBox chkIsOwner;
		private RFMBaseClasses.RFMTabPage tabPartners_Details;
        private RFMBaseClasses.RFMDataGridView grdPartnersDetails;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPartnersGoodsEdit;
		public RFMBaseClasses.RFMContextMenuStrip mnuPartnersService;
		public RFMBaseClasses.RFMContextMenuStrip mnuPartnersRootsService;
		private RFMBaseClasses.RFMTabPage tabPrintForms;
		private RFMBaseClasses.RFMSplitContainer cntPrintForms;
		private RFMBaseClasses.RFMDataGridView grdPrintForms;
		private RFMBaseClasses.RFMTabControl tcPrintForms;
		private RFMBaseClasses.RFMTabPage tabPrintForms_Partners;
		private RFMBaseClasses.RFMDataGridView grdPrintForms_Partners;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_PartnersRoots;
		private RFMBaseClasses.RFMSelectRecordIDTree ucSelectRecordID_Zones;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Name;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Alias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_INN;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Gravity;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_ERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_ID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_PF_Type;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_PF_Name;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPrintForms_TemplateHasText;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_LinesInPage;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_Note;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_ERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_ID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPrintForms_Partners_Name;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_Name;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPartnersRoots_Partners_PartnersGoodsExists;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_LegalName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_Inn;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_ZoneName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_PermitLevelName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_PartnerRootName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_DeliveryAddress;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_DeliveryPassage;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_DeliveryRestriction;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_ContactsInfo;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_Gravity;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPartnersRoots_Partners_Actual;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPartnersRoots_Partners_IsCustomer;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPartnersRoots_Partners_IsSupplier;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_ERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersRoots_Partners_ID;
		private RFMBaseClasses.RFMLabel lblHosts;
        private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Hosts;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPartnersGoodsCopy;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private RFMBaseClasses.RFMContextToolStripMenuItem mniPartnersPFCopy;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_GoodName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_InBox;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_SP_GoodName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_SP_GoodCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_SP_Articul;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_SP_Vat;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_SP_ByOrder;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_ERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersGoods_ID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grсName;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPartnersGoodsExists;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcLegalName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcZoneName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcRegionAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcLongitude;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcLatitude;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDistance;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcStayMinutes;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDeliveryAddress;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDeliveryPassage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDeliveryRestriction;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGravity;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPermitLevelName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcContactInfo;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcActual;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsCustomer;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsSupplier;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsOwner;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcSeparatePicking;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPF_BillName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPF_BillCopiesCount;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPF_FactureName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPF_FactureCopiesCount;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPF_PayBillName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPF_PayBillCopiesCount;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcShopCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTimeWork;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTimeReceipt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcInn;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerRootName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_LegalName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_FactName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_Inn;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_LegalAddress;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_BankName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_PAccount;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcPartnersDetails_AutoSelected;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnersDetails_ID;
	}
}