namespace Logistics 
{
	partial class frmWarrantsNumbers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarrantsNumbers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcList = new RFMBaseClasses.RFMTabControl();
            this.tabTerms = new RFMBaseClasses.RFMTabPage();
            this.cntTerms = new RFMBaseClasses.RFMPanel();
            this.txtDeputyName = new RFMBaseClasses.RFMTextBox();
            this.pnlEmployees = new RFMBaseClasses.RFMPanel();
            this.txtEmployeesChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnEmployeesClear = new RFMBaseClasses.RFMButton();
            this.btnEmployeesChoose = new RFMBaseClasses.RFMButton();
            this.lblDeputyName = new RFMBaseClasses.RFMLabel();
            this.lblWarrantObject = new RFMBaseClasses.RFMLabel();
            this.rfmPanel1 = new RFMBaseClasses.RFMPanel();
            this.optIsMoneyNot = new RFMBaseClasses.RFMRadioButton();
            this.optIsMoney = new RFMBaseClasses.RFMRadioButton();
            this.optIsMoneyAny = new RFMBaseClasses.RFMRadioButton();
            this.lblWarrantNumberContext = new RFMBaseClasses.RFMLabel();
            this.txtWarrantNumberContext = new RFMBaseClasses.RFMTextBox();
            this.pnlPartnersSource = new RFMBaseClasses.RFMPanel();
            this.txtPartnersSourceChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnPartnersSourceClear = new RFMBaseClasses.RFMButton();
            this.btnPartnersSourceChoose = new RFMBaseClasses.RFMButton();
            this.lblPartnersSource = new RFMBaseClasses.RFMLabel();
            this.pnlPartnersTarget = new RFMBaseClasses.RFMPanel();
            this.txtPartnersTargetChoosen = new RFMBaseClasses.RFMTextBox();
            this.btnPartnersTargetClear = new RFMBaseClasses.RFMButton();
            this.btnPartnersTargetChoose = new RFMBaseClasses.RFMButton();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.btnClearTerms = new RFMBaseClasses.RFMButton();
            this.lblIsReturned = new RFMBaseClasses.RFMLabel();
            this.pnlOpgIsReturned = new RFMBaseClasses.RFMPanel();
            this.optIsReturnedNot = new RFMBaseClasses.RFMRadioButton();
            this.optIsReturned = new RFMBaseClasses.RFMRadioButton();
            this.optIsReturnedAny = new RFMBaseClasses.RFMRadioButton();
            this.lblDates = new RFMBaseClasses.RFMLabel();
            this.lblPartnersTarget = new RFMBaseClasses.RFMLabel();
            this.tabData = new RFMBaseClasses.RFMTabPage();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcIsMoneyImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.grcIsReturned = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateIssue = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerSourceName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerDetailSourceFactName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerDetailSourceBankName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPartnerTargetName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDeputyName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcAmount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCurrencyName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputDocumentID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcInputDocumentID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcInputID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateReturn = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateInput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateTill = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnService = new RFMBaseClasses.RFMButton();
            this.mnuWarrantsService = new RFMBaseClasses.RFMContextMenuStrip();
            this.mniWarrantsAnalysis = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.mniWarrantsReturn = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.mniWarrantsUnReturn = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnDelete = new RFMBaseClasses.RFMButton();
            this.btnAdd = new RFMBaseClasses.RFMButton();
            this.btnCancel = new RFMBaseClasses.RFMButton();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnConfirm = new RFMBaseClasses.RFMButton();
            this.tcList.SuspendLayout();
            this.tabTerms.SuspendLayout();
            this.cntTerms.SuspendLayout();
            this.pnlEmployees.SuspendLayout();
            this.rfmPanel1.SuspendLayout();
            this.pnlPartnersSource.SuspendLayout();
            this.pnlPartnersTarget.SuspendLayout();
            this.dtrDates.SuspendLayout();
            this.pnlOpgIsReturned.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.mnuWarrantsService.SuspendLayout();
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
            this.tcList.SelectedIndexChanged += new System.EventHandler(this.tcList_SelectedIndexChanged);
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
            this.cntTerms.Controls.Add(this.txtDeputyName);
            this.cntTerms.Controls.Add(this.pnlEmployees);
            this.cntTerms.Controls.Add(this.lblDeputyName);
            this.cntTerms.Controls.Add(this.lblWarrantObject);
            this.cntTerms.Controls.Add(this.rfmPanel1);
            this.cntTerms.Controls.Add(this.lblWarrantNumberContext);
            this.cntTerms.Controls.Add(this.txtWarrantNumberContext);
            this.cntTerms.Controls.Add(this.pnlPartnersSource);
            this.cntTerms.Controls.Add(this.lblPartnersSource);
            this.cntTerms.Controls.Add(this.pnlPartnersTarget);
            this.cntTerms.Controls.Add(this.dtrDates);
            this.cntTerms.Controls.Add(this.btnClearTerms);
            this.cntTerms.Controls.Add(this.lblIsReturned);
            this.cntTerms.Controls.Add(this.pnlOpgIsReturned);
            this.cntTerms.Controls.Add(this.lblDates);
            this.cntTerms.Controls.Add(this.lblPartnersTarget);
            this.cntTerms.Location = new System.Drawing.Point(0, 2);
            this.cntTerms.Name = "cntTerms";
            this.cntTerms.Size = new System.Drawing.Size(732, 400);
            this.cntTerms.TabIndex = 0;
            // 
            // txtDeputyName
            // 
            this.txtDeputyName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDeputyName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDeputyName.Location = new System.Drawing.Point(191, 176);
            this.txtDeputyName.Name = "txtDeputyName";
            this.txtDeputyName.OldValue = "";
            this.txtDeputyName.Size = new System.Drawing.Size(218, 22);
            this.txtDeputyName.TabIndex = 10;
            this.ttToolTip.SetToolTip(this.txtDeputyName, "Контекст ФИО получателя денег/товара");
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.txtEmployeesChoosen);
            this.pnlEmployees.Controls.Add(this.btnEmployeesClear);
            this.pnlEmployees.Controls.Add(this.btnEmployeesChoose);
            this.pnlEmployees.Location = new System.Drawing.Point(190, 195);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(278, 30);
            this.pnlEmployees.TabIndex = 11;
            // 
            // txtEmployeesChoosen
            // 
            this.txtEmployeesChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtEmployeesChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmployeesChoosen.Enabled = false;
            this.txtEmployeesChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtEmployeesChoosen.Name = "txtEmployeesChoosen";
            this.txtEmployeesChoosen.OldValue = "";
            this.txtEmployeesChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtEmployeesChoosen.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.txtEmployeesChoosen, "Список выбранных сотрудников");
            // 
            // btnEmployeesClear
            // 
            this.btnEmployeesClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnEmployeesClear.Location = new System.Drawing.Point(249, 3);
            this.btnEmployeesClear.Name = "btnEmployeesClear";
            this.btnEmployeesClear.Size = new System.Drawing.Size(26, 24);
            this.btnEmployeesClear.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.btnEmployeesClear, "Очистить выбор сотрудников");
            this.btnEmployeesClear.UseVisualStyleBackColor = true;
            this.btnEmployeesClear.Click += new System.EventHandler(this.btnEmployeesClear_Click);
            // 
            // btnEmployeesChoose
            // 
            this.btnEmployeesChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnEmployeesChoose.Location = new System.Drawing.Point(221, 3);
            this.btnEmployeesChoose.Name = "btnEmployeesChoose";
            this.btnEmployeesChoose.Size = new System.Drawing.Size(26, 24);
            this.btnEmployeesChoose.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnEmployeesChoose, "Выбор сотрудников");
            this.btnEmployeesChoose.UseVisualStyleBackColor = true;
            this.btnEmployeesChoose.Click += new System.EventHandler(this.btnEmployeesChoose_Click);
            // 
            // lblDeputyName
            // 
            this.lblDeputyName.AutoSize = true;
            this.lblDeputyName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDeputyName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDeputyName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeputyName.Location = new System.Drawing.Point(7, 180);
            this.lblDeputyName.Name = "lblDeputyName";
            this.lblDeputyName.Size = new System.Drawing.Size(185, 14);
            this.lblDeputyName.TabIndex = 9;
            this.lblDeputyName.Text = "ФИО получателя денег/товара";
            // 
            // lblWarrantObject
            // 
            this.lblWarrantObject.AutoSize = true;
            this.lblWarrantObject.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblWarrantObject.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblWarrantObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWarrantObject.Location = new System.Drawing.Point(7, 76);
            this.lblWarrantObject.Name = "lblWarrantObject";
            this.lblWarrantObject.Size = new System.Drawing.Size(171, 14);
            this.lblWarrantObject.TabIndex = 3;
            this.lblWarrantObject.Text = "Доверенность на получение";
            // 
            // rfmPanel1
            // 
            this.rfmPanel1.Controls.Add(this.optIsMoneyNot);
            this.rfmPanel1.Controls.Add(this.optIsMoney);
            this.rfmPanel1.Controls.Add(this.optIsMoneyAny);
            this.rfmPanel1.Location = new System.Drawing.Point(189, 72);
            this.rfmPanel1.Name = "rfmPanel1";
            this.rfmPanel1.Size = new System.Drawing.Size(275, 23);
            this.rfmPanel1.TabIndex = 4;
            // 
            // optIsMoneyNot
            // 
            this.optIsMoneyNot.AutoSize = true;
            this.optIsMoneyNot.Location = new System.Drawing.Point(173, 2);
            this.optIsMoneyNot.Name = "optIsMoneyNot";
            this.optIsMoneyNot.Size = new System.Drawing.Size(63, 18);
            this.optIsMoneyNot.TabIndex = 1;
            this.optIsMoneyNot.Text = "товара";
            this.optIsMoneyNot.UseVisualStyleBackColor = true;
            // 
            // optIsMoney
            // 
            this.optIsMoney.AutoSize = true;
            this.optIsMoney.Location = new System.Drawing.Point(98, 2);
            this.optIsMoney.Name = "optIsMoney";
            this.optIsMoney.Size = new System.Drawing.Size(58, 18);
            this.optIsMoney.TabIndex = 3;
            this.optIsMoney.Text = "денег";
            this.optIsMoney.UseVisualStyleBackColor = true;
            // 
            // optIsMoneyAny
            // 
            this.optIsMoneyAny.AutoSize = true;
            this.optIsMoneyAny.Checked = true;
            this.optIsMoneyAny.IsChanged = true;
            this.optIsMoneyAny.Location = new System.Drawing.Point(3, 2);
            this.optIsMoneyAny.Name = "optIsMoneyAny";
            this.optIsMoneyAny.Size = new System.Drawing.Size(79, 18);
            this.optIsMoneyAny.TabIndex = 0;
            this.optIsMoneyAny.TabStop = true;
            this.optIsMoneyAny.Text = "не важно";
            this.optIsMoneyAny.UseVisualStyleBackColor = true;
            // 
            // lblWarrantNumberContext
            // 
            this.lblWarrantNumberContext.AutoSize = true;
            this.lblWarrantNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblWarrantNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblWarrantNumberContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWarrantNumberContext.Location = new System.Drawing.Point(7, 43);
            this.lblWarrantNumberContext.Name = "lblWarrantNumberContext";
            this.lblWarrantNumberContext.Size = new System.Drawing.Size(171, 14);
            this.lblWarrantNumberContext.TabIndex = 1;
            this.lblWarrantNumberContext.Text = "№ доверенности (контекст)";
            // 
            // txtWarrantNumberContext
            // 
            this.txtWarrantNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtWarrantNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWarrantNumberContext.Location = new System.Drawing.Point(191, 39);
            this.txtWarrantNumberContext.Name = "txtWarrantNumberContext";
            this.txtWarrantNumberContext.OldValue = "";
            this.txtWarrantNumberContext.Size = new System.Drawing.Size(218, 22);
            this.txtWarrantNumberContext.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.txtWarrantNumberContext, "Контекст номера доверенности");
            // 
            // pnlPartnersSource
            // 
            this.pnlPartnersSource.Controls.Add(this.txtPartnersSourceChoosen);
            this.pnlPartnersSource.Controls.Add(this.btnPartnersSourceClear);
            this.pnlPartnersSource.Controls.Add(this.btnPartnersSourceChoose);
            this.pnlPartnersSource.Location = new System.Drawing.Point(190, 104);
            this.pnlPartnersSource.Name = "pnlPartnersSource";
            this.pnlPartnersSource.Size = new System.Drawing.Size(278, 30);
            this.pnlPartnersSource.TabIndex = 6;
            // 
            // txtPartnersSourceChoosen
            // 
            this.txtPartnersSourceChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPartnersSourceChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartnersSourceChoosen.Enabled = false;
            this.txtPartnersSourceChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtPartnersSourceChoosen.Name = "txtPartnersSourceChoosen";
            this.txtPartnersSourceChoosen.OldValue = "";
            this.txtPartnersSourceChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtPartnersSourceChoosen.TabIndex = 0;
            this.ttToolTip.SetToolTip(this.txtPartnersSourceChoosen, "Организации, выдавшие доверенность");
            // 
            // btnPartnersSourceClear
            // 
            this.btnPartnersSourceClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnPartnersSourceClear.Location = new System.Drawing.Point(249, 3);
            this.btnPartnersSourceClear.Name = "btnPartnersSourceClear";
            this.btnPartnersSourceClear.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersSourceClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnPartnersSourceClear, "Очистить выбор организации");
            this.btnPartnersSourceClear.UseVisualStyleBackColor = true;
            this.btnPartnersSourceClear.Click += new System.EventHandler(this.btnPartnersSourceClear_Click);
            // 
            // btnPartnersSourceChoose
            // 
            this.btnPartnersSourceChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnPartnersSourceChoose.Location = new System.Drawing.Point(221, 3);
            this.btnPartnersSourceChoose.Name = "btnPartnersSourceChoose";
            this.btnPartnersSourceChoose.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersSourceChoose.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnPartnersSourceChoose, "Выбор организации");
            this.btnPartnersSourceChoose.UseVisualStyleBackColor = true;
            this.btnPartnersSourceChoose.Click += new System.EventHandler(this.btnPartnersSourceChoose_Click);
            // 
            // lblPartnersSource
            // 
            this.lblPartnersSource.AutoSize = true;
            this.lblPartnersSource.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartnersSource.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartnersSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartnersSource.Location = new System.Drawing.Point(7, 112);
            this.lblPartnersSource.Name = "lblPartnersSource";
            this.lblPartnersSource.Size = new System.Drawing.Size(157, 14);
            this.lblPartnersSource.TabIndex = 5;
            this.lblPartnersSource.Text = "Кем выдана доверенность";
            // 
            // pnlPartnersTarget
            // 
            this.pnlPartnersTarget.Controls.Add(this.txtPartnersTargetChoosen);
            this.pnlPartnersTarget.Controls.Add(this.btnPartnersTargetClear);
            this.pnlPartnersTarget.Controls.Add(this.btnPartnersTargetChoose);
            this.pnlPartnersTarget.Location = new System.Drawing.Point(190, 137);
            this.pnlPartnersTarget.Name = "pnlPartnersTarget";
            this.pnlPartnersTarget.Size = new System.Drawing.Size(278, 30);
            this.pnlPartnersTarget.TabIndex = 8;
            // 
            // txtPartnersTargetChoosen
            // 
            this.txtPartnersTargetChoosen.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPartnersTargetChoosen.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartnersTargetChoosen.Enabled = false;
            this.txtPartnersTargetChoosen.Location = new System.Drawing.Point(1, 4);
            this.txtPartnersTargetChoosen.Name = "txtPartnersTargetChoosen";
            this.txtPartnersTargetChoosen.OldValue = "";
            this.txtPartnersTargetChoosen.Size = new System.Drawing.Size(218, 22);
            this.txtPartnersTargetChoosen.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.txtPartnersTargetChoosen, "Плательщики/поставщики");
            // 
            // btnPartnersTargetClear
            // 
            this.btnPartnersTargetClear.Image = global::Logistics.Properties.Resources.DeleteAll;
            this.btnPartnersTargetClear.Location = new System.Drawing.Point(249, 3);
            this.btnPartnersTargetClear.Name = "btnPartnersTargetClear";
            this.btnPartnersTargetClear.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersTargetClear.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnPartnersTargetClear, "Очистить выбор плательщиков/поставщиков");
            this.btnPartnersTargetClear.UseVisualStyleBackColor = true;
            this.btnPartnersTargetClear.Click += new System.EventHandler(this.btnPartnersTargetClear_Click);
            // 
            // btnPartnersTargetChoose
            // 
            this.btnPartnersTargetChoose.Image = global::Logistics.Properties.Resources.Detail;
            this.btnPartnersTargetChoose.Location = new System.Drawing.Point(221, 3);
            this.btnPartnersTargetChoose.Name = "btnPartnersTargetChoose";
            this.btnPartnersTargetChoose.Size = new System.Drawing.Size(26, 24);
            this.btnPartnersTargetChoose.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnPartnersTargetChoose, "Выбор плательщиков/поставщиков");
            this.btnPartnersTargetChoose.UseVisualStyleBackColor = true;
            this.btnPartnersTargetChoose.Click += new System.EventHandler(this.btnPartnersTargetChoose_Click);
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
            this.dtrDates.Location = new System.Drawing.Point(191, 4);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(222, 29);
            this.dtrDates.TabIndex = 0;
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
            this.btnClearTerms.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
            this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
            // 
            // lblIsReturned
            // 
            this.lblIsReturned.AutoSize = true;
            this.lblIsReturned.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblIsReturned.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIsReturned.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIsReturned.Location = new System.Drawing.Point(7, 240);
            this.lblIsReturned.Name = "lblIsReturned";
            this.lblIsReturned.Size = new System.Drawing.Size(164, 14);
            this.lblIsReturned.TabIndex = 12;
            this.lblIsReturned.Text = "Доверенность возвращена?";
            // 
            // pnlOpgIsReturned
            // 
            this.pnlOpgIsReturned.Controls.Add(this.optIsReturnedNot);
            this.pnlOpgIsReturned.Controls.Add(this.optIsReturned);
            this.pnlOpgIsReturned.Controls.Add(this.optIsReturnedAny);
            this.pnlOpgIsReturned.Location = new System.Drawing.Point(189, 236);
            this.pnlOpgIsReturned.Name = "pnlOpgIsReturned";
            this.pnlOpgIsReturned.Size = new System.Drawing.Size(275, 23);
            this.pnlOpgIsReturned.TabIndex = 13;
            // 
            // optIsReturnedNot
            // 
            this.optIsReturnedNot.AutoSize = true;
            this.optIsReturnedNot.Location = new System.Drawing.Point(173, 2);
            this.optIsReturnedNot.Name = "optIsReturnedNot";
            this.optIsReturnedNot.Size = new System.Drawing.Size(45, 18);
            this.optIsReturnedNot.TabIndex = 1;
            this.optIsReturnedNot.Text = "нет";
            this.optIsReturnedNot.UseVisualStyleBackColor = true;
            // 
            // optIsReturned
            // 
            this.optIsReturned.AutoSize = true;
            this.optIsReturned.Location = new System.Drawing.Point(106, 2);
            this.optIsReturned.Name = "optIsReturned";
            this.optIsReturned.Size = new System.Drawing.Size(38, 18);
            this.optIsReturned.TabIndex = 3;
            this.optIsReturned.Text = "да";
            this.optIsReturned.UseVisualStyleBackColor = true;
            // 
            // optIsReturnedAny
            // 
            this.optIsReturnedAny.AutoSize = true;
            this.optIsReturnedAny.Checked = true;
            this.optIsReturnedAny.IsChanged = true;
            this.optIsReturnedAny.Location = new System.Drawing.Point(3, 2);
            this.optIsReturnedAny.Name = "optIsReturnedAny";
            this.optIsReturnedAny.Size = new System.Drawing.Size(79, 18);
            this.optIsReturnedAny.TabIndex = 0;
            this.optIsReturnedAny.TabStop = true;
            this.optIsReturnedAny.Text = "не важно";
            this.optIsReturnedAny.UseVisualStyleBackColor = true;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDates.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDates.Location = new System.Drawing.Point(7, 11);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(78, 14);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Дата выдачи";
            // 
            // lblPartnersTarget
            // 
            this.lblPartnersTarget.AutoSize = true;
            this.lblPartnersTarget.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartnersTarget.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartnersTarget.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartnersTarget.Location = new System.Drawing.Point(7, 145);
            this.lblPartnersTarget.Name = "lblPartnersTarget";
            this.lblPartnersTarget.Size = new System.Drawing.Size(160, 14);
            this.lblPartnersTarget.TabIndex = 7;
            this.lblPartnersTarget.Text = "Плательщики/ Поставщики";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.grdData);
            this.tabData.Location = new System.Drawing.Point(4, 23);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(733, 403);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "Доверенности";
            this.tabData.UseVisualStyleBackColor = true;
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
            this.grcIsMoneyImage,
            this.grcIsReturned,
            this.grcNumber,
            this.grcDateIssue,
            this.grcPartnerSourceName,
            this.grcPartnerDetailSourceFactName,
            this.grcPartnerDetailSourceBankName,
            this.grcPartnerTargetName,
            this.grcDeputyName,
            this.grcAmount,
            this.grcCurrencyName,
            this.grcOutputDocumentID,
            this.grcInputDocumentID,
            this.grcInputID,
            this.grcDateReturn,
            this.grcDateInput,
            this.grcDateTill,
            this.grcERPCode,
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
            this.grdData.Location = new System.Drawing.Point(0, 2);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.Size = new System.Drawing.Size(732, 400);
            this.grdData.TabIndex = 12;
            this.grdData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdData_CurrentRowChanged);
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
            // 
            // grcIsMoneyImage
            // 
            this.grcIsMoneyImage.DataPropertyName = "IsMoney";
            this.grcIsMoneyImage.HeaderText = "Д/Т";
            this.grcIsMoneyImage.Name = "grcIsMoneyImage";
            this.grcIsMoneyImage.ReadOnly = true;
            this.grcIsMoneyImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsMoneyImage.ToolTipText = "Деньги/товар ";
            this.grcIsMoneyImage.Width = 50;
            // 
            // grcIsReturned
            // 
            this.grcIsReturned.DataPropertyName = "IsReturned";
            this.grcIsReturned.HeaderText = "Возвр.";
            this.grcIsReturned.Name = "grcIsReturned";
            this.grcIsReturned.ReadOnly = true;
            this.grcIsReturned.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsReturned.ToolTipText = "Доверенность возвращена?";
            this.grcIsReturned.Width = 50;
            // 
            // grcNumber
            // 
            this.grcNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNumber.DataPropertyName = "Number";
            this.grcNumber.HeaderText = "№";
            this.grcNumber.Name = "grcNumber";
            this.grcNumber.ReadOnly = true;
            this.grcNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNumber.ToolTipText = "Номер доверенности";
            this.grcNumber.Width = 80;
            // 
            // grcDateIssue
            // 
            this.grcDateIssue.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateIssue.DataPropertyName = "DateIssue";
            this.grcDateIssue.HeaderText = "Дата";
            this.grcDateIssue.Name = "grcDateIssue";
            this.grcDateIssue.ReadOnly = true;
            this.grcDateIssue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateIssue.ToolTipText = "Дата выдачи доверенности";
            this.grcDateIssue.Width = 80;
            // 
            // grcPartnerSourceName
            // 
            this.grcPartnerSourceName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerSourceName.DataPropertyName = "PartnerSourceName";
            this.grcPartnerSourceName.HeaderText = "Кем выдана";
            this.grcPartnerSourceName.Name = "grcPartnerSourceName";
            this.grcPartnerSourceName.ReadOnly = true;
            this.grcPartnerSourceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerSourceName.ToolTipText = "Партнер, выдавший доверенность";
            this.grcPartnerSourceName.Width = 120;
            // 
            // grcPartnerDetailSourceFactName
            // 
            this.grcPartnerDetailSourceFactName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerDetailSourceFactName.DataPropertyName = "PartnerDetailSourceFactName";
            this.grcPartnerDetailSourceFactName.HeaderText = "Факт.название";
            this.grcPartnerDetailSourceFactName.Name = "grcPartnerDetailSourceFactName";
            this.grcPartnerDetailSourceFactName.ReadOnly = true;
            this.grcPartnerDetailSourceFactName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerDetailSourceFactName.Visible = false;
            this.grcPartnerDetailSourceFactName.Width = 150;
            // 
            // grcPartnerDetailSourceBankName
            // 
            this.grcPartnerDetailSourceBankName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerDetailSourceBankName.DataPropertyName = "PartnerDetailSourceBankName";
            this.grcPartnerDetailSourceBankName.HeaderText = "Банк";
            this.grcPartnerDetailSourceBankName.Name = "grcPartnerDetailSourceBankName";
            this.grcPartnerDetailSourceBankName.ReadOnly = true;
            this.grcPartnerDetailSourceBankName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerDetailSourceBankName.Visible = false;
            this.grcPartnerDetailSourceBankName.Width = 150;
            // 
            // grcPartnerTargetName
            // 
            this.grcPartnerTargetName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPartnerTargetName.DataPropertyName = "PartnerTargetName";
            this.grcPartnerTargetName.HeaderText = "Плательщик";
            this.grcPartnerTargetName.Name = "grcPartnerTargetName";
            this.grcPartnerTargetName.ReadOnly = true;
            this.grcPartnerTargetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPartnerTargetName.Width = 200;
            // 
            // grcDeputyName
            // 
            this.grcDeputyName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDeputyName.DataPropertyName = "DeputyName";
            this.grcDeputyName.HeaderText = "ФИО";
            this.grcDeputyName.Name = "grcDeputyName";
            this.grcDeputyName.ReadOnly = true;
            this.grcDeputyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDeputyName.ToolTipText = "Получатель денег/товара";
            this.grcDeputyName.Width = 120;
            // 
            // grcAmount
            // 
            this.grcAmount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.grcAmount.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcAmount.HeaderText = "Сумма";
            this.grcAmount.Name = "grcAmount";
            this.grcAmount.ReadOnly = true;
            this.grcAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcAmount.Width = 60;
            // 
            // grcCurrencyName
            // 
            this.grcCurrencyName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCurrencyName.DataPropertyName = "CurrencyName";
            this.grcCurrencyName.HeaderText = "Вал.";
            this.grcCurrencyName.Name = "grcCurrencyName";
            this.grcCurrencyName.ReadOnly = true;
            this.grcCurrencyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCurrencyName.Width = 40;
            // 
            // grcOutputDocumentID
            // 
            this.grcOutputDocumentID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputDocumentID.DataPropertyName = "OutputDocumentID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.grcOutputDocumentID.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcOutputDocumentID.HeaderText = "Расх.док-т";
            this.grcOutputDocumentID.Name = "grcOutputDocumentID";
            this.grcOutputDocumentID.ReadOnly = true;
            this.grcOutputDocumentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputDocumentID.ToolTipText = "Код расходного документа";
            this.grcOutputDocumentID.Width = 80;
            // 
            // grcInputDocumentID
            // 
            this.grcInputDocumentID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcInputDocumentID.DataPropertyName = "InputDocumentID";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.grcInputDocumentID.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcInputDocumentID.HeaderText = "Прих.док-т";
            this.grcInputDocumentID.Name = "grcInputDocumentID";
            this.grcInputDocumentID.ReadOnly = true;
            this.grcInputDocumentID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcInputDocumentID.ToolTipText = "Код приходного документа";
            this.grcInputDocumentID.Width = 80;
            // 
            // grcInputID
            // 
            this.grcInputID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcInputID.DataPropertyName = "InputID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.grcInputID.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcInputID.HeaderText = "Приход";
            this.grcInputID.Name = "grcInputID";
            this.grcInputID.ReadOnly = true;
            this.grcInputID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcInputID.ToolTipText = "Код задания на приход";
            this.grcInputID.Width = 80;
            // 
            // grcDateReturn
            // 
            this.grcDateReturn.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateReturn.DataPropertyName = "DateReturn";
            this.grcDateReturn.HeaderText = "Возвр.";
            this.grcDateReturn.Name = "grcDateReturn";
            this.grcDateReturn.ReadOnly = true;
            this.grcDateReturn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateReturn.ToolTipText = "Доверенность возвращена";
            this.grcDateReturn.Width = 80;
            // 
            // grcDateInput
            // 
            this.grcDateInput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateInput.DataPropertyName = "DateInput";
            this.grcDateInput.HeaderText = "Создано";
            this.grcDateInput.Name = "grcDateInput";
            this.grcDateInput.ReadOnly = true;
            this.grcDateInput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateInput.ToolTipText = "Дата-время оформления доверенности ";
            this.grcDateInput.Width = 110;
            // 
            // grcDateTill
            // 
            this.grcDateTill.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateTill.DataPropertyName = "DateTill";
            this.grcDateTill.HeaderText = "Действ. до";
            this.grcDateTill.Name = "grcDateTill";
            this.grcDateTill.ReadOnly = true;
            this.grcDateTill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateTill.ToolTipText = "Доверенность действительна до даты";
            this.grcDateTill.Width = 80;
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
            this.grcERPCode.Visible = false;
            // 
            // grcID
            // 
            this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcID.DataPropertyName = "ID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcID.DefaultCellStyle = dataGridViewCellStyle6;
            this.grcID.HeaderText = "ID";
            this.grcID.Name = "grcID";
            this.grcID.ReadOnly = true;
            this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcID.ToolTipText = "Код записи о доверенности";
            this.grcID.Width = 50;
            // 
            // btnService
            // 
            this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnService.ContextMenuStrip = this.mnuWarrantsService;
            this.btnService.Enabled = false;
            this.btnService.Image = global::Logistics.Properties.Resources.Service;
            this.btnService.IsAccessOn = true;
            this.btnService.Location = new System.Drawing.Point(655, 439);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(30, 30);
            this.btnService.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnService, "Сервис");
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // mnuWarrantsService
            // 
            this.mnuWarrantsService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniWarrantsAnalysis,
            this.mniWarrantsReturn,
            this.mniWarrantsUnReturn});
            this.mnuWarrantsService.Name = "mnuWarrantsService";
            this.mnuWarrantsService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuWarrantsService.Size = new System.Drawing.Size(174, 70);
            // 
            // mniWarrantsAnalysis
            // 
            this.mniWarrantsAnalysis.Name = "mniWarrantsAnalysis";
            this.mniWarrantsAnalysis.Size = new System.Drawing.Size(173, 22);
            this.mniWarrantsAnalysis.Text = "Анализ списка";
            this.mniWarrantsAnalysis.Click += new System.EventHandler(this.mniWarrantsAnalysis_Click);
            // 
            // mniWarrantsReturn
            // 
            this.mniWarrantsReturn.Name = "mniWarrantsReturn";
            this.mniWarrantsReturn.Size = new System.Drawing.Size(173, 22);
            this.mniWarrantsReturn.Text = "Возврат";
            this.mniWarrantsReturn.Click += new System.EventHandler(this.mniWarrantsReturn_Click);
            // 
            // mniWarrantsUnReturn
            // 
            this.mniWarrantsUnReturn.Name = "mniWarrantsUnReturn";
            this.mniWarrantsUnReturn.Size = new System.Drawing.Size(173, 22);
            this.mniWarrantsUnReturn.Text = "Отмена возврата";
            this.mniWarrantsUnReturn.Click += new System.EventHandler(this.mniWarrantsUnReturn_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Enabled = false;
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(605, 439);
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
            this.btnDelete.IsAccessOn = true;
            this.btnDelete.Location = new System.Drawing.Point(555, 439);
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
            this.btnAdd.Location = new System.Drawing.Point(405, 439);
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
            this.btnCancel.Location = new System.Drawing.Point(705, 439);
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
            this.btnEdit.Location = new System.Drawing.Point(455, 439);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.Enabled = false;
            this.btnConfirm.Image = global::Logistics.Properties.Resources.Go;
            this.btnConfirm.IsAccessOn = true;
            this.btnConfirm.Location = new System.Drawing.Point(505, 439);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(30, 30);
            this.btnConfirm.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnConfirm, "Подтверждение");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // frmWarrantsNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 474);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnConfirm);
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
            this.MinimumSize = new System.Drawing.Size(750, 501);
            this.Name = "frmWarrantsNumbers";
            this.hpHelp.SetShowHelp(this, true);
            this.Text = "Журнал выдачи доверенностей";
            this.Load += new System.EventHandler(this.frmWarrantsNumbers_Load);
            this.tcList.ResumeLayout(false);
            this.tabTerms.ResumeLayout(false);
            this.cntTerms.ResumeLayout(false);
            this.cntTerms.PerformLayout();
            this.pnlEmployees.ResumeLayout(false);
            this.pnlEmployees.PerformLayout();
            this.rfmPanel1.ResumeLayout(false);
            this.rfmPanel1.PerformLayout();
            this.pnlPartnersSource.ResumeLayout(false);
            this.pnlPartnersSource.PerformLayout();
            this.pnlPartnersTarget.ResumeLayout(false);
            this.pnlPartnersTarget.PerformLayout();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.pnlOpgIsReturned.ResumeLayout(false);
            this.pnlOpgIsReturned.PerformLayout();
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.mnuWarrantsService.ResumeLayout(false);
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
        private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMButton btnConfirm;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblIsReturned;
		private RFMBaseClasses.RFMPanel pnlOpgIsReturned;
		private RFMBaseClasses.RFMRadioButton optIsReturnedNot;
		private RFMBaseClasses.RFMRadioButton optIsReturned;
		private RFMBaseClasses.RFMRadioButton optIsReturnedAny;
		private RFMBaseClasses.RFMLabel lblDates;
		private RFMBaseClasses.RFMLabel lblPartnersTarget;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMPanel pnlPartnersTarget;
		private RFMBaseClasses.RFMButton btnPartnersTargetClear;
		private RFMBaseClasses.RFMButton btnPartnersTargetChoose;
		private RFMBaseClasses.RFMTextBox txtPartnersTargetChoosen;
		private RFMBaseClasses.RFMPanel pnlPartnersSource;
		private RFMBaseClasses.RFMTextBox txtPartnersSourceChoosen;
		private RFMBaseClasses.RFMButton btnPartnersSourceClear;
		private RFMBaseClasses.RFMButton btnPartnersSourceChoose;
		private RFMBaseClasses.RFMLabel lblPartnersSource;
		private RFMBaseClasses.RFMLabel lblWarrantNumberContext;
		private RFMBaseClasses.RFMTextBox txtWarrantNumberContext;
		private RFMBaseClasses.RFMLabel lblWarrantObject;
		private RFMBaseClasses.RFMPanel rfmPanel1;
		private RFMBaseClasses.RFMRadioButton optIsMoneyNot;
		private RFMBaseClasses.RFMRadioButton optIsMoney;
		private RFMBaseClasses.RFMRadioButton optIsMoneyAny;
		private RFMBaseClasses.RFMLabel lblDeputyName;
		private RFMBaseClasses.RFMTextBox txtDeputyName;
		private RFMBaseClasses.RFMPanel pnlEmployees;
		private RFMBaseClasses.RFMTextBox txtEmployeesChoosen;
		private RFMBaseClasses.RFMButton btnEmployeesClear;
		private RFMBaseClasses.RFMButton btnEmployeesChoose;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniWarrantsAnalysis;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniWarrantsReturn;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniWarrantsUnReturn;
		private RFMBaseClasses.RFMDataGridViewImageColumn grcIsMoneyImage;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsReturned;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateIssue;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerSourceName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerDetailSourceFactName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerDetailSourceBankName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerTargetName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDeputyName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcAmount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCurrencyName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputDocumentID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcInputDocumentID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcInputID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateReturn;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateInput;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateTill;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
		public RFMBaseClasses.RFMContextMenuStrip mnuWarrantsService;
	}
}