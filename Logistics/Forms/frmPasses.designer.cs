namespace Logistics
{
	partial class frmPasses
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPasses));
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
			this.tcList = new RFMBaseClasses.RFMTabControl();
			this.tabTerms = new RFMBaseClasses.RFMTabPage();
			this.cntTerms = new RFMBaseClasses.RFMPanel();
			this.lblIsPermitted = new RFMBaseClasses.RFMLabel();
			this.pnlIsPermitted = new RFMBaseClasses.RFMPanel();
			this.optIsPermittedNot = new RFMBaseClasses.RFMRadioButton();
			this.optIsPermitted = new RFMBaseClasses.RFMRadioButton();
			this.optIsPermittedAll = new RFMBaseClasses.RFMRadioButton();
			this.lblConfirmed = new RFMBaseClasses.RFMLabel();
			this.pnlIsConfirmed = new RFMBaseClasses.RFMPanel();
			this.optIsConfirmedNot = new RFMBaseClasses.RFMRadioButton();
			this.optIsConfirmed = new RFMBaseClasses.RFMRadioButton();
			this.optIsConfirmedAll = new RFMBaseClasses.RFMRadioButton();
			this.txtCarTypeNameContext = new RFMBaseClasses.RFMTextBox();
			this.lblReasonContext = new RFMBaseClasses.RFMLabel();
			this.txtReasonContext = new RFMBaseClasses.RFMTextBox();
			this.lblDriverNameContext = new RFMBaseClasses.RFMLabel();
			this.txtDriverNameContext = new RFMBaseClasses.RFMTextBox();
			this.lblCarNumberContext = new RFMBaseClasses.RFMLabel();
			this.txtCarNumberContext = new RFMBaseClasses.RFMTextBox();
			this.lblCarNameContext = new RFMBaseClasses.RFMLabel();
			this.txtCarNameContext = new RFMBaseClasses.RFMTextBox();
			this.lblCarsTypes = new RFMBaseClasses.RFMLabel();
			this.dtrDates = new RFMBaseClasses.RFMDateRange();
			this.btnClearTerms = new RFMBaseClasses.RFMButton();
			this.lblPassesStatus = new RFMBaseClasses.RFMLabel();
			this.pnlPassesStatus = new RFMBaseClasses.RFMPanel();
			this.lblPassesStatusInNotOut = new RFMBaseClasses.RFMLabel();
			this.optPassesStatusInOut = new RFMBaseClasses.RFMRadioButton();
			this.optPassesStatusNotInNotOut = new RFMBaseClasses.RFMRadioButton();
			this.optPassesStatusInNotOut = new RFMBaseClasses.RFMRadioButton();
			this.optPassesStatusAll = new RFMBaseClasses.RFMRadioButton();
			this.lblDatePass = new RFMBaseClasses.RFMLabel();
			this.tabData = new RFMBaseClasses.RFMTabPage();
			this.cntGrids = new RFMBaseClasses.RFMSplitContainer();
			this.grdData = new RFMBaseClasses.RFMDataGridView();
			this.grcPassStatusImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcConfirmedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcIsPermittedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcIsArrival = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcIsDeparture = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcDatePass = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateBeg = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateEnd = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDurationFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverDocument = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverPhone = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarrierName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcNote = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcUserName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.grcUserCreateName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateConfirm = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcUserConfirmName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.tcPasses = new RFMBaseClasses.RFMTabControl();
			this.tabPasses_Trips = new RFMBaseClasses.RFMTabPage();
			this.grdTrips = new RFMBaseClasses.RFMDataGridView();
			this.grcTrip_TripStatusImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcTrip_DateTrip = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_ForGoodsOnly = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcTrip_TripNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_DriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_Netto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_Brutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_PalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_PointsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_DateEnd = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_DateBeg = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_DurationFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_CostNormName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTrip_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.btnService = new RFMBaseClasses.RFMButton();
			this.mnuPassesService = new RFMBaseClasses.RFMContextMenuStrip();
			this.mniPassConfirm = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.mniPassUnConfirm = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mniPassPermit = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.mniPassUnPermit = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.mniPassSetDateEntry = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.mniPassSetDateExit = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mniPassClearDateEntry = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.mniPassClearDateExit = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.btnPrint = new RFMBaseClasses.RFMButton();
			this.mnuPassesPrint = new RFMBaseClasses.RFMContextMenuStrip();
			this.mniPassPrint = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnDelete = new RFMBaseClasses.RFMButton();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.btnCancel = new RFMBaseClasses.RFMButton();
			this.btnEdit = new RFMBaseClasses.RFMButton();
			this.tmrRestore = new RFMBaseClasses.RFMTimer();
			this.tcList.SuspendLayout();
			this.tabTerms.SuspendLayout();
			this.cntTerms.SuspendLayout();
			this.pnlIsPermitted.SuspendLayout();
			this.pnlIsConfirmed.SuspendLayout();
			this.dtrDates.SuspendLayout();
			this.pnlPassesStatus.SuspendLayout();
			this.tabData.SuspendLayout();
			this.cntGrids.Panel1.SuspendLayout();
			this.cntGrids.Panel2.SuspendLayout();
			this.cntGrids.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
			this.tcPasses.SuspendLayout();
			this.tabPasses_Trips.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).BeginInit();
			this.mnuPassesService.SuspendLayout();
			this.mnuPassesPrint.SuspendLayout();
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
			this.cntTerms.Controls.Add(this.lblIsPermitted);
			this.cntTerms.Controls.Add(this.pnlIsPermitted);
			this.cntTerms.Controls.Add(this.lblConfirmed);
			this.cntTerms.Controls.Add(this.pnlIsConfirmed);
			this.cntTerms.Controls.Add(this.txtCarTypeNameContext);
			this.cntTerms.Controls.Add(this.lblReasonContext);
			this.cntTerms.Controls.Add(this.txtReasonContext);
			this.cntTerms.Controls.Add(this.lblDriverNameContext);
			this.cntTerms.Controls.Add(this.txtDriverNameContext);
			this.cntTerms.Controls.Add(this.lblCarNumberContext);
			this.cntTerms.Controls.Add(this.txtCarNumberContext);
			this.cntTerms.Controls.Add(this.lblCarNameContext);
			this.cntTerms.Controls.Add(this.txtCarNameContext);
			this.cntTerms.Controls.Add(this.lblCarsTypes);
			this.cntTerms.Controls.Add(this.dtrDates);
			this.cntTerms.Controls.Add(this.btnClearTerms);
			this.cntTerms.Controls.Add(this.lblPassesStatus);
			this.cntTerms.Controls.Add(this.pnlPassesStatus);
			this.cntTerms.Controls.Add(this.lblDatePass);
			this.cntTerms.Location = new System.Drawing.Point(0, 2);
			this.cntTerms.Name = "cntTerms";
			this.cntTerms.Size = new System.Drawing.Size(732, 400);
			this.cntTerms.TabIndex = 0;
			// 
			// lblIsPermitted
			// 
			this.lblIsPermitted.AutoSize = true;
			this.lblIsPermitted.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblIsPermitted.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblIsPermitted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblIsPermitted.Location = new System.Drawing.Point(486, 245);
			this.lblIsPermitted.Name = "lblIsPermitted";
			this.lblIsPermitted.Size = new System.Drawing.Size(191, 14);
			this.lblIsPermitted.TabIndex = 16;
			this.lblIsPermitted.Text = "Разрешено пересечение ворот?";
			// 
			// pnlIsPermitted
			// 
			this.pnlIsPermitted.Controls.Add(this.optIsPermittedNot);
			this.pnlIsPermitted.Controls.Add(this.optIsPermitted);
			this.pnlIsPermitted.Controls.Add(this.optIsPermittedAll);
			this.pnlIsPermitted.Location = new System.Drawing.Point(486, 262);
			this.pnlIsPermitted.Name = "pnlIsPermitted";
			this.pnlIsPermitted.Size = new System.Drawing.Size(227, 23);
			this.pnlIsPermitted.TabIndex = 17;
			// 
			// optIsPermittedNot
			// 
			this.optIsPermittedNot.AutoSize = true;
			this.optIsPermittedNot.Location = new System.Drawing.Point(165, 4);
			this.optIsPermittedNot.Name = "optIsPermittedNot";
			this.optIsPermittedNot.Size = new System.Drawing.Size(45, 18);
			this.optIsPermittedNot.TabIndex = 1;
			this.optIsPermittedNot.Text = "нет";
			this.optIsPermittedNot.UseVisualStyleBackColor = true;
			// 
			// optIsPermitted
			// 
			this.optIsPermitted.AutoSize = true;
			this.optIsPermitted.Location = new System.Drawing.Point(105, 4);
			this.optIsPermitted.Name = "optIsPermitted";
			this.optIsPermitted.Size = new System.Drawing.Size(38, 18);
			this.optIsPermitted.TabIndex = 2;
			this.optIsPermitted.Text = "да";
			this.optIsPermitted.UseVisualStyleBackColor = true;
			// 
			// optIsPermittedAll
			// 
			this.optIsPermittedAll.AutoSize = true;
			this.optIsPermittedAll.Checked = true;
			this.optIsPermittedAll.IsChanged = true;
			this.optIsPermittedAll.Location = new System.Drawing.Point(4, 4);
			this.optIsPermittedAll.Name = "optIsPermittedAll";
			this.optIsPermittedAll.Size = new System.Drawing.Size(79, 18);
			this.optIsPermittedAll.TabIndex = 0;
			this.optIsPermittedAll.TabStop = true;
			this.optIsPermittedAll.Text = "не важно";
			this.optIsPermittedAll.UseVisualStyleBackColor = true;
			// 
			// lblConfirmed
			// 
			this.lblConfirmed.AutoSize = true;
			this.lblConfirmed.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblConfirmed.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblConfirmed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblConfirmed.Location = new System.Drawing.Point(486, 176);
			this.lblConfirmed.Name = "lblConfirmed";
			this.lblConfirmed.Size = new System.Drawing.Size(127, 14);
			this.lblConfirmed.TabIndex = 14;
			this.lblConfirmed.Text = "Пропуск утвержден?";
			// 
			// pnlIsConfirmed
			// 
			this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedNot);
			this.pnlIsConfirmed.Controls.Add(this.optIsConfirmed);
			this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedAll);
			this.pnlIsConfirmed.Location = new System.Drawing.Point(486, 193);
			this.pnlIsConfirmed.Name = "pnlIsConfirmed";
			this.pnlIsConfirmed.Size = new System.Drawing.Size(227, 23);
			this.pnlIsConfirmed.TabIndex = 15;
			// 
			// optIsConfirmedNot
			// 
			this.optIsConfirmedNot.AutoSize = true;
			this.optIsConfirmedNot.Location = new System.Drawing.Point(165, 4);
			this.optIsConfirmedNot.Name = "optIsConfirmedNot";
			this.optIsConfirmedNot.Size = new System.Drawing.Size(45, 18);
			this.optIsConfirmedNot.TabIndex = 1;
			this.optIsConfirmedNot.Text = "нет";
			this.optIsConfirmedNot.UseVisualStyleBackColor = true;
			// 
			// optIsConfirmed
			// 
			this.optIsConfirmed.AutoSize = true;
			this.optIsConfirmed.Location = new System.Drawing.Point(105, 4);
			this.optIsConfirmed.Name = "optIsConfirmed";
			this.optIsConfirmed.Size = new System.Drawing.Size(38, 18);
			this.optIsConfirmed.TabIndex = 2;
			this.optIsConfirmed.Text = "да";
			this.optIsConfirmed.UseVisualStyleBackColor = true;
			// 
			// optIsConfirmedAll
			// 
			this.optIsConfirmedAll.AutoSize = true;
			this.optIsConfirmedAll.Checked = true;
			this.optIsConfirmedAll.IsChanged = true;
			this.optIsConfirmedAll.Location = new System.Drawing.Point(4, 4);
			this.optIsConfirmedAll.Name = "optIsConfirmedAll";
			this.optIsConfirmedAll.Size = new System.Drawing.Size(79, 18);
			this.optIsConfirmedAll.TabIndex = 0;
			this.optIsConfirmedAll.TabStop = true;
			this.optIsConfirmedAll.Text = "не важно";
			this.optIsConfirmedAll.UseVisualStyleBackColor = true;
			// 
			// txtCarTypeNameContext
			// 
			this.txtCarTypeNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarTypeNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarTypeNameContext.Location = new System.Drawing.Point(142, 109);
			this.txtCarTypeNameContext.Name = "txtCarTypeNameContext";
			this.txtCarTypeNameContext.Size = new System.Drawing.Size(217, 22);
			this.txtCarTypeNameContext.TabIndex = 7;
			// 
			// lblReasonContext
			// 
			this.lblReasonContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReasonContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReasonContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReasonContext.Location = new System.Drawing.Point(4, 189);
			this.lblReasonContext.Name = "lblReasonContext";
			this.lblReasonContext.Size = new System.Drawing.Size(138, 28);
			this.lblReasonContext.TabIndex = 10;
			this.lblReasonContext.Text = "Цель поездки (контекст)";
			// 
			// txtReasonContext
			// 
			this.txtReasonContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtReasonContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtReasonContext.Location = new System.Drawing.Point(142, 191);
			this.txtReasonContext.Name = "txtReasonContext";
			this.txtReasonContext.Size = new System.Drawing.Size(217, 22);
			this.txtReasonContext.TabIndex = 11;
			// 
			// lblDriverNameContext
			// 
			this.lblDriverNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDriverNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDriverNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDriverNameContext.Location = new System.Drawing.Point(4, 148);
			this.lblDriverNameContext.Name = "lblDriverNameContext";
			this.lblDriverNameContext.Size = new System.Drawing.Size(138, 28);
			this.lblDriverNameContext.TabIndex = 8;
			this.lblDriverNameContext.Text = "ФИО водителя (контекст)";
			// 
			// txtDriverNameContext
			// 
			this.txtDriverNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtDriverNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDriverNameContext.Location = new System.Drawing.Point(142, 150);
			this.txtDriverNameContext.Name = "txtDriverNameContext";
			this.txtDriverNameContext.Size = new System.Drawing.Size(217, 22);
			this.txtDriverNameContext.TabIndex = 9;
			// 
			// lblCarNumberContext
			// 
			this.lblCarNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarNumberContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarNumberContext.Location = new System.Drawing.Point(4, 76);
			this.lblCarNumberContext.Name = "lblCarNumberContext";
			this.lblCarNumberContext.Size = new System.Drawing.Size(138, 28);
			this.lblCarNumberContext.TabIndex = 4;
			this.lblCarNumberContext.Text = "Гос.номер машины (контекст)";
			// 
			// txtCarNumberContext
			// 
			this.txtCarNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNumberContext.Location = new System.Drawing.Point(142, 78);
			this.txtCarNumberContext.Name = "txtCarNumberContext";
			this.txtCarNumberContext.Size = new System.Drawing.Size(217, 22);
			this.txtCarNumberContext.TabIndex = 5;
			// 
			// lblCarNameContext
			// 
			this.lblCarNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarNameContext.Location = new System.Drawing.Point(4, 46);
			this.lblCarNameContext.Name = "lblCarNameContext";
			this.lblCarNameContext.Size = new System.Drawing.Size(138, 28);
			this.lblCarNameContext.TabIndex = 2;
			this.lblCarNameContext.Text = "Наименование машины (контекст) ";
			// 
			// txtCarNameContext
			// 
			this.txtCarNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNameContext.Location = new System.Drawing.Point(142, 47);
			this.txtCarNameContext.Name = "txtCarNameContext";
			this.txtCarNameContext.Size = new System.Drawing.Size(217, 22);
			this.txtCarNameContext.TabIndex = 3;
			// 
			// lblCarsTypes
			// 
			this.lblCarsTypes.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarsTypes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarsTypes.Location = new System.Drawing.Point(4, 112);
			this.lblCarsTypes.Name = "lblCarsTypes";
			this.lblCarsTypes.Size = new System.Drawing.Size(138, 28);
			this.lblCarsTypes.TabIndex = 6;
			this.lblCarsTypes.Text = "Тип машины (контекст)";
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
			this.dtrDates.Location = new System.Drawing.Point(142, 3);
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
			// lblPassesStatus
			// 
			this.lblPassesStatus.AutoSize = true;
			this.lblPassesStatus.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPassesStatus.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPassesStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPassesStatus.Location = new System.Drawing.Point(486, 11);
			this.lblPassesStatus.Name = "lblPassesStatus";
			this.lblPassesStatus.Size = new System.Drawing.Size(116, 14);
			this.lblPassesStatus.TabIndex = 12;
			this.lblPassesStatus.Text = "Состояние машины";
			// 
			// pnlPassesStatus
			// 
			this.pnlPassesStatus.Controls.Add(this.lblPassesStatusInNotOut);
			this.pnlPassesStatus.Controls.Add(this.optPassesStatusInOut);
			this.pnlPassesStatus.Controls.Add(this.optPassesStatusNotInNotOut);
			this.pnlPassesStatus.Controls.Add(this.optPassesStatusInNotOut);
			this.pnlPassesStatus.Controls.Add(this.optPassesStatusAll);
			this.pnlPassesStatus.Location = new System.Drawing.Point(486, 27);
			this.pnlPassesStatus.Name = "pnlPassesStatus";
			this.pnlPassesStatus.Size = new System.Drawing.Size(214, 108);
			this.pnlPassesStatus.TabIndex = 13;
			// 
			// lblPassesStatusInNotOut
			// 
			this.lblPassesStatusInNotOut.AutoSize = true;
			this.lblPassesStatusInNotOut.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPassesStatusInNotOut.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPassesStatusInNotOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPassesStatusInNotOut.Location = new System.Drawing.Point(19, 58);
			this.lblPassesStatusInNotOut.Name = "lblPassesStatusInNotOut";
			this.lblPassesStatusInNotOut.Size = new System.Drawing.Size(165, 14);
			this.lblPassesStatusInNotOut.TabIndex = 17;
			this.lblPassesStatusInNotOut.Text = "(находится на территории)";
			// 
			// optPassesStatusInOut
			// 
			this.optPassesStatusInOut.AutoSize = true;
			this.optPassesStatusInOut.Location = new System.Drawing.Point(4, 75);
			this.optPassesStatusInOut.Name = "optPassesStatusInOut";
			this.optPassesStatusInOut.Size = new System.Drawing.Size(117, 18);
			this.optPassesStatusInOut.TabIndex = 3;
			this.optPassesStatusInOut.Text = "машина выехала";
			this.optPassesStatusInOut.UseVisualStyleBackColor = true;
			// 
			// optPassesStatusNotInNotOut
			// 
			this.optPassesStatusNotInNotOut.AutoSize = true;
			this.optPassesStatusNotInNotOut.Location = new System.Drawing.Point(4, 21);
			this.optPassesStatusNotInNotOut.Name = "optPassesStatusNotInNotOut";
			this.optPassesStatusNotInNotOut.Size = new System.Drawing.Size(143, 18);
			this.optPassesStatusNotInNotOut.TabIndex = 1;
			this.optPassesStatusNotInNotOut.Text = "машина не въезжала";
			this.optPassesStatusNotInNotOut.UseVisualStyleBackColor = true;
			// 
			// optPassesStatusInNotOut
			// 
			this.optPassesStatusInNotOut.AutoSize = true;
			this.optPassesStatusInNotOut.Location = new System.Drawing.Point(4, 40);
			this.optPassesStatusInNotOut.Name = "optPassesStatusInNotOut";
			this.optPassesStatusInNotOut.Size = new System.Drawing.Size(197, 18);
			this.optPassesStatusInNotOut.TabIndex = 2;
			this.optPassesStatusInNotOut.Text = "машина въехала, не выезжала";
			this.optPassesStatusInNotOut.UseVisualStyleBackColor = true;
			// 
			// optPassesStatusAll
			// 
			this.optPassesStatusAll.AutoSize = true;
			this.optPassesStatusAll.Checked = true;
			this.optPassesStatusAll.IsChanged = true;
			this.optPassesStatusAll.Location = new System.Drawing.Point(4, 2);
			this.optPassesStatusAll.Name = "optPassesStatusAll";
			this.optPassesStatusAll.Size = new System.Drawing.Size(79, 18);
			this.optPassesStatusAll.TabIndex = 0;
			this.optPassesStatusAll.TabStop = true;
			this.optPassesStatusAll.Text = "не важно";
			this.optPassesStatusAll.UseVisualStyleBackColor = true;
			// 
			// lblDatePass
			// 
			this.lblDatePass.AutoSize = true;
			this.lblDatePass.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDatePass.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDatePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDatePass.Location = new System.Drawing.Point(4, 11);
			this.lblDatePass.Name = "lblDatePass";
			this.lblDatePass.Size = new System.Drawing.Size(89, 14);
			this.lblDatePass.TabIndex = 0;
			this.lblDatePass.Text = "Дата пропуска";
			// 
			// tabData
			// 
			this.tabData.Controls.Add(this.cntGrids);
			this.tabData.Location = new System.Drawing.Point(4, 23);
			this.tabData.Name = "tabData";
			this.tabData.Padding = new System.Windows.Forms.Padding(3);
			this.tabData.Size = new System.Drawing.Size(733, 403);
			this.tabData.TabIndex = 1;
			this.tabData.Text = "Пропуска";
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
			this.cntGrids.Panel2.Controls.Add(this.tcPasses);
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
            this.grcPassStatusImage,
            this.grcConfirmedImage,
            this.grcIsPermittedImage,
            this.grcIsArrival,
            this.grcIsDeparture,
            this.grcDatePass,
            this.grcCarName,
            this.grcCarNumber,
            this.grcDriverName,
            this.grcDateBeg,
            this.grcDateEnd,
            this.grcDurationFact,
            this.grcCarTypeName,
            this.grcDriverDocument,
            this.grcDriverPhone,
            this.grcBrutto,
            this.grcPalletsQnt,
            this.grcPartnerName,
            this.grcCarrierName,
            this.grcNote,
            this.grcUserName,
            this.grcDateCreate,
            this.grcUserCreateName,
            this.grcDateConfirm,
            this.grcUserConfirmName,
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
			this.grdData.Location = new System.Drawing.Point(0, 0);
			this.grdData.MultiSelect = false;
			this.grdData.Name = "grdData";
			this.grdData.RangedWay = ' ';
			this.grdData.ReadOnly = true;
			this.grdData.RowHeadersWidth = 24;
			this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdData.Size = new System.Drawing.Size(728, 263);
			this.grdData.TabIndex = 11;
			this.grdData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdData_CurrentRowChanged);
			this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
			// 
			// grcPassStatusImage
			// 
			this.grcPassStatusImage.HeaderText = "";
			this.grcPassStatusImage.Name = "grcPassStatusImage";
			this.grcPassStatusImage.ReadOnly = true;
			this.grcPassStatusImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPassStatusImage.ToolTipText = "Зеленый - машина не въезжала, желтый - на территории, красный - выехала";
			this.grcPassStatusImage.Width = 30;
			// 
			// grcConfirmedImage
			// 
			this.grcConfirmedImage.DataPropertyName = "IsConfirmed";
			this.grcConfirmedImage.HeaderText = "Утв.";
			this.grcConfirmedImage.Name = "grcConfirmedImage";
			this.grcConfirmedImage.ReadOnly = true;
			this.grcConfirmedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcConfirmedImage.ToolTipText = "Пропуск утвержден?";
			this.grcConfirmedImage.Width = 40;
			// 
			// grcIsPermittedImage
			// 
			this.grcIsPermittedImage.DataPropertyName = "IsPermitted";
			this.grcIsPermittedImage.HeaderText = "Разр.";
			this.grcIsPermittedImage.Name = "grcIsPermittedImage";
			this.grcIsPermittedImage.ReadOnly = true;
			this.grcIsPermittedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsPermittedImage.ToolTipText = "Разрешено очередное пересечение ворот?";
			this.grcIsPermittedImage.Width = 45;
			// 
			// grcIsArrival
			// 
			this.grcIsArrival.DataPropertyName = "IsArrival";
			this.grcIsArrival.HeaderText = "Въезд";
			this.grcIsArrival.Name = "grcIsArrival";
			this.grcIsArrival.ReadOnly = true;
			this.grcIsArrival.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsArrival.ToolTipText = "Машина въехала?";
			this.grcIsArrival.Width = 55;
			// 
			// grcIsDeparture
			// 
			this.grcIsDeparture.DataPropertyName = "IsDeparture";
			this.grcIsDeparture.HeaderText = "Выезд";
			this.grcIsDeparture.Name = "grcIsDeparture";
			this.grcIsDeparture.ReadOnly = true;
			this.grcIsDeparture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsDeparture.ToolTipText = "Машина выехала?";
			this.grcIsDeparture.Width = 55;
			// 
			// grcDatePass
			// 
			this.grcDatePass.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDatePass.DataPropertyName = "DatePass";
			dataGridViewCellStyle2.Format = "dd.MM.yyyy";
			this.grcDatePass.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcDatePass.HeaderText = "Дата";
			this.grcDatePass.Name = "grcDatePass";
			this.grcDatePass.ReadOnly = true;
			this.grcDatePass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDatePass.ToolTipText = "Дата пропуска";
			this.grcDatePass.Width = 80;
			// 
			// grcCarName
			// 
			this.grcCarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarName.DataPropertyName = "CarName";
			this.grcCarName.HeaderText = "Машина";
			this.grcCarName.Name = "grcCarName";
			this.grcCarName.ReadOnly = true;
			this.grcCarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcCarName.Width = 150;
			// 
			// grcCarNumber
			// 
			this.grcCarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarNumber.DataPropertyName = "CarNumber";
			this.grcCarNumber.HeaderText = "Номер";
			this.grcCarNumber.Name = "grcCarNumber";
			this.grcCarNumber.ReadOnly = true;
			this.grcCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcDriverName
			// 
			this.grcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverName.DataPropertyName = "DriverName";
			this.grcDriverName.HeaderText = "Водитель";
			this.grcDriverName.Name = "grcDriverName";
			this.grcDriverName.ReadOnly = true;
			this.grcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcDateBeg
			// 
			this.grcDateBeg.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateBeg.DataPropertyName = "DateBeg";
			this.grcDateBeg.HeaderText = "Въезд";
			this.grcDateBeg.Name = "grcDateBeg";
			this.grcDateBeg.ReadOnly = true;
			this.grcDateBeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateBeg.ToolTipText = "Дата-время въезда машины";
			this.grcDateBeg.Width = 110;
			// 
			// grcDateEnd
			// 
			this.grcDateEnd.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateEnd.DataPropertyName = "DateEnd";
			this.grcDateEnd.HeaderText = "Выезд";
			this.grcDateEnd.Name = "grcDateEnd";
			this.grcDateEnd.ReadOnly = true;
			this.grcDateEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateEnd.ToolTipText = "Дата-время выезда машины";
			this.grcDateEnd.Width = 110;
			// 
			// grcDurationFact
			// 
			this.grcDurationFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDurationFact.DataPropertyName = "DurationHoursMinutesFact";
			this.grcDurationFact.HeaderText = "Длит.";
			this.grcDurationFact.Name = "grcDurationFact";
			this.grcDurationFact.ReadOnly = true;
			this.grcDurationFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDurationFact.ToolTipText = "Длительность пребывания, часов:минут";
			this.grcDurationFact.Width = 70;
			// 
			// grcCarTypeName
			// 
			this.grcCarTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarTypeName.DataPropertyName = "CarTypeName";
			this.grcCarTypeName.HeaderText = "Тип машины";
			this.grcCarTypeName.Name = "grcCarTypeName";
			this.grcCarTypeName.ReadOnly = true;
			this.grcCarTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcDriverDocument
			// 
			this.grcDriverDocument.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverDocument.DataPropertyName = "DriverDocument";
			this.grcDriverDocument.HeaderText = "Док. водителя";
			this.grcDriverDocument.Name = "grcDriverDocument";
			this.grcDriverDocument.ReadOnly = true;
			this.grcDriverDocument.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDriverDocument.ToolTipText = "Документ водителя";
			// 
			// grcDriverPhone
			// 
			this.grcDriverPhone.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverPhone.DataPropertyName = "DriverPhone";
			this.grcDriverPhone.HeaderText = "Тел. водителя";
			this.grcDriverPhone.Name = "grcDriverPhone";
			this.grcDriverPhone.ReadOnly = true;
			this.grcDriverPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDriverPhone.ToolTipText = "Телефон водителя";
			// 
			// grcBrutto
			// 
			this.grcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcBrutto.DataPropertyName = "Brutto";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N0";
			this.grcBrutto.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcBrutto.HeaderText = "Брутто";
			this.grcBrutto.Name = "grcBrutto";
			this.grcBrutto.ReadOnly = true;
			this.grcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcBrutto.ToolTipText = "Вес брутто товара, кг";
			this.grcBrutto.Width = 70;
			// 
			// grcPalletsQnt
			// 
			this.grcPalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPalletsQnt.DataPropertyName = "PalletsQnt";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N1";
			this.grcPalletsQnt.DefaultCellStyle = dataGridViewCellStyle4;
			this.grcPalletsQnt.HeaderText = "Паллет";
			this.grcPalletsQnt.Name = "grcPalletsQnt";
			this.grcPalletsQnt.ReadOnly = true;
			this.grcPalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPalletsQnt.ToolTipText = "Количество паллет";
			this.grcPalletsQnt.Width = 50;
			// 
			// grcPartnerName
			// 
			this.grcPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPartnerName.DataPropertyName = "PartnerName";
			this.grcPartnerName.HeaderText = "Клиент";
			this.grcPartnerName.Name = "grcPartnerName";
			this.grcPartnerName.ReadOnly = true;
			this.grcPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPartnerName.Width = 150;
			// 
			// grcCarrierName
			// 
			this.grcCarrierName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarrierName.DataPropertyName = "CarrierName";
			this.grcCarrierName.HeaderText = "Перевозчик";
			this.grcCarrierName.Name = "grcCarrierName";
			this.grcCarrierName.ReadOnly = true;
			this.grcCarrierName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcNote
			// 
			this.grcNote.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcNote.DataPropertyName = "Note";
			this.grcNote.HeaderText = "Примечание";
			this.grcNote.Name = "grcNote";
			this.grcNote.ReadOnly = true;
			this.grcNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcNote.Width = 150;
			// 
			// grcUserName
			// 
			this.grcUserName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcUserName.DataPropertyName = "UserName";
			this.grcUserName.HeaderText = "Пользователь";
			this.grcUserName.Name = "grcUserName";
			this.grcUserName.ReadOnly = true;
			this.grcUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcUserName.ToolTipText = "Пользователь, оформивший пропуск";
			// 
			// grcDateCreate
			// 
			this.grcDateCreate.DataPropertyName = "DateCreate";
			this.grcDateCreate.HeaderText = "Оформлено";
			this.grcDateCreate.Name = "grcDateCreate";
			this.grcDateCreate.ReadOnly = true;
			this.grcDateCreate.ToolTipText = "Дата-время оформления";
			this.grcDateCreate.Width = 110;
			// 
			// grcUserCreateName
			// 
			this.grcUserCreateName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcUserCreateName.DataPropertyName = "UserCreateName";
			this.grcUserCreateName.HeaderText = "Оформил";
			this.grcUserCreateName.Name = "grcUserCreateName";
			this.grcUserCreateName.ReadOnly = true;
			this.grcUserCreateName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcUserCreateName.ToolTipText = "Кто оформил пропуск";
			// 
			// grcDateConfirm
			// 
			this.grcDateConfirm.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateConfirm.DataPropertyName = "DateConfirm";
			this.grcDateConfirm.HeaderText = "Утверждено";
			this.grcDateConfirm.Name = "grcDateConfirm";
			this.grcDateConfirm.ReadOnly = true;
			this.grcDateConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateConfirm.ToolTipText = "Дата-время утверждения";
			this.grcDateConfirm.Width = 110;
			// 
			// grcUserConfirmName
			// 
			this.grcUserConfirmName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcUserConfirmName.DataPropertyName = "UserConfirmName";
			this.grcUserConfirmName.HeaderText = "Утвердил";
			this.grcUserConfirmName.Name = "grcUserConfirmName";
			this.grcUserConfirmName.ReadOnly = true;
			this.grcUserConfirmName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcUserConfirmName.ToolTipText = "Кто утвердил пропуск";
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
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcID.DefaultCellStyle = dataGridViewCellStyle5;
			this.grcID.HeaderText = "ID";
			this.grcID.Name = "grcID";
			this.grcID.ReadOnly = true;
			this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcID.ToolTipText = "Код рейса";
			this.grcID.Width = 50;
			// 
			// tcPasses
			// 
			this.tcPasses.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tcPasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcPasses.Controls.Add(this.tabPasses_Trips);
			this.tcPasses.ItemSize = new System.Drawing.Size(120, 18);
			this.tcPasses.Location = new System.Drawing.Point(1, 1);
			this.tcPasses.Multiline = true;
			this.tcPasses.Name = "tcPasses";
			this.tcPasses.SelectedIndex = 0;
			this.tcPasses.Size = new System.Drawing.Size(727, 125);
			this.tcPasses.TabIndex = 0;
			// 
			// tabPasses_Trips
			// 
			this.tabPasses_Trips.Controls.Add(this.grdTrips);
			this.tabPasses_Trips.Location = new System.Drawing.Point(4, 4);
			this.tabPasses_Trips.Name = "tabPasses_Trips";
			this.tabPasses_Trips.Padding = new System.Windows.Forms.Padding(3);
			this.tabPasses_Trips.Size = new System.Drawing.Size(719, 99);
			this.tabPasses_Trips.TabIndex = 0;
			this.tabPasses_Trips.Text = "Рейсы";
			this.tabPasses_Trips.UseVisualStyleBackColor = true;
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
			this.grdTrips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdTrips.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.grdTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdTrips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcTrip_TripStatusImage,
            this.grcTrip_DateTrip,
            this.grcTrip_ForGoodsOnly,
            this.grcTrip_TripNumber,
            this.grcTrip_DriverName,
            this.grcTrip_Netto,
            this.grcTrip_Brutto,
            this.grcTrip_PalletsQnt,
            this.grcTrip_PointsQnt,
            this.grcTrip_DateEnd,
            this.grcTrip_DateBeg,
            this.grcTrip_DurationFact,
            this.grcTrip_CostNormName,
            this.grcTrip_Note,
            this.grcTrip_ERPCode,
            this.grcTrip_ID});
			this.grdTrips.IsCheckerInclude = true;
			this.grdTrips.IsConfigInclude = true;
			this.grdTrips.IsMarkedAll = false;
			this.grdTrips.IsStatusInclude = true;
			this.grdTrips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdTrips.Location = new System.Drawing.Point(0, 0);
			this.grdTrips.MultiSelect = false;
			this.grdTrips.Name = "grdTrips";
			this.grdTrips.RangedWay = ' ';
			this.grdTrips.ReadOnly = true;
			this.grdTrips.RowHeadersWidth = 24;
			this.grdTrips.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdTrips.Size = new System.Drawing.Size(717, 96);
			this.grdTrips.TabIndex = 13;
			this.grdTrips.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdTrips_CellFormatting);
			// 
			// grcTrip_TripStatusImage
			// 
			this.grcTrip_TripStatusImage.HeaderText = "Маш.";
			this.grcTrip_TripStatusImage.Name = "grcTrip_TripStatusImage";
			this.grcTrip_TripStatusImage.ReadOnly = true;
			this.grcTrip_TripStatusImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_TripStatusImage.ToolTipText = "Состояние рейса: машина вышла / пришла";
			this.grcTrip_TripStatusImage.Width = 45;
			// 
			// grcTrip_DateTrip
			// 
			this.grcTrip_DateTrip.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_DateTrip.DataPropertyName = "DateTrip";
			dataGridViewCellStyle7.Format = "dd.MM.yyyy";
			this.grcTrip_DateTrip.DefaultCellStyle = dataGridViewCellStyle7;
			this.grcTrip_DateTrip.HeaderText = "Дата";
			this.grcTrip_DateTrip.Name = "grcTrip_DateTrip";
			this.grcTrip_DateTrip.ReadOnly = true;
			this.grcTrip_DateTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_DateTrip.ToolTipText = "Дата рейса";
			this.grcTrip_DateTrip.Width = 80;
			// 
			// grcTrip_ForGoodsOnly
			// 
			this.grcTrip_ForGoodsOnly.DataPropertyName = "ForGoodsOnly";
			this.grcTrip_ForGoodsOnly.HeaderText = "Товар";
			this.grcTrip_ForGoodsOnly.Name = "grcTrip_ForGoodsOnly";
			this.grcTrip_ForGoodsOnly.ReadOnly = true;
			this.grcTrip_ForGoodsOnly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcTrip_ForGoodsOnly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_ForGoodsOnly.ToolTipText = "Поставка/отгрузка товара?";
			this.grcTrip_ForGoodsOnly.Width = 50;
			// 
			// grcTrip_TripNumber
			// 
			this.grcTrip_TripNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_TripNumber.DataPropertyName = "TripNumber";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcTrip_TripNumber.DefaultCellStyle = dataGridViewCellStyle8;
			this.grcTrip_TripNumber.HeaderText = "Ездка";
			this.grcTrip_TripNumber.Name = "grcTrip_TripNumber";
			this.grcTrip_TripNumber.ReadOnly = true;
			this.grcTrip_TripNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_TripNumber.Width = 50;
			// 
			// grcTrip_DriverName
			// 
			this.grcTrip_DriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_DriverName.DataPropertyName = "DriverName";
			this.grcTrip_DriverName.HeaderText = "Водитель";
			this.grcTrip_DriverName.Name = "grcTrip_DriverName";
			this.grcTrip_DriverName.ReadOnly = true;
			this.grcTrip_DriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcTrip_Netto
			// 
			this.grcTrip_Netto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_Netto.DataPropertyName = "Netto";
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle9.Format = "N0";
			this.grcTrip_Netto.DefaultCellStyle = dataGridViewCellStyle9;
			this.grcTrip_Netto.HeaderText = "Нетто";
			this.grcTrip_Netto.Name = "grcTrip_Netto";
			this.grcTrip_Netto.ReadOnly = true;
			this.grcTrip_Netto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_Netto.ToolTipText = "Вес нетто товара, кг";
			this.grcTrip_Netto.Width = 70;
			// 
			// grcTrip_Brutto
			// 
			this.grcTrip_Brutto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_Brutto.DataPropertyName = "Brutto";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "N0";
			this.grcTrip_Brutto.DefaultCellStyle = dataGridViewCellStyle10;
			this.grcTrip_Brutto.HeaderText = "Брутто";
			this.grcTrip_Brutto.Name = "grcTrip_Brutto";
			this.grcTrip_Brutto.ReadOnly = true;
			this.grcTrip_Brutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_Brutto.ToolTipText = "Вес брутто товара, кг";
			this.grcTrip_Brutto.Width = 70;
			// 
			// grcTrip_PalletsQnt
			// 
			this.grcTrip_PalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_PalletsQnt.DataPropertyName = "PalletsQnt";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle11.Format = "N1";
			this.grcTrip_PalletsQnt.DefaultCellStyle = dataGridViewCellStyle11;
			this.grcTrip_PalletsQnt.HeaderText = "Пал.";
			this.grcTrip_PalletsQnt.Name = "grcTrip_PalletsQnt";
			this.grcTrip_PalletsQnt.ReadOnly = true;
			this.grcTrip_PalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_PalletsQnt.ToolTipText = "Количество паллет";
			this.grcTrip_PalletsQnt.Width = 50;
			// 
			// grcTrip_PointsQnt
			// 
			this.grcTrip_PointsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_PointsQnt.DataPropertyName = "PointsQnt";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle12.Format = "N0";
			this.grcTrip_PointsQnt.DefaultCellStyle = dataGridViewCellStyle12;
			this.grcTrip_PointsQnt.HeaderText = "Точек";
			this.grcTrip_PointsQnt.Name = "grcTrip_PointsQnt";
			this.grcTrip_PointsQnt.ReadOnly = true;
			this.grcTrip_PointsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_PointsQnt.ToolTipText = "Количество клиентов";
			this.grcTrip_PointsQnt.Width = 50;
			// 
			// grcTrip_DateEnd
			// 
			this.grcTrip_DateEnd.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_DateEnd.DataPropertyName = "DateEnd";
			this.grcTrip_DateEnd.HeaderText = "Выход";
			this.grcTrip_DateEnd.Name = "grcTrip_DateEnd";
			this.grcTrip_DateEnd.ReadOnly = true;
			this.grcTrip_DateEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_DateEnd.ToolTipText = "Дата-время выхода машины";
			this.grcTrip_DateEnd.Width = 110;
			// 
			// grcTrip_DateBeg
			// 
			this.grcTrip_DateBeg.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_DateBeg.DataPropertyName = "DateBeg";
			this.grcTrip_DateBeg.HeaderText = "Возвр.";
			this.grcTrip_DateBeg.Name = "grcTrip_DateBeg";
			this.grcTrip_DateBeg.ReadOnly = true;
			this.grcTrip_DateBeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_DateBeg.ToolTipText = "Дата-время возвращения машины";
			this.grcTrip_DateBeg.Width = 110;
			// 
			// grcTrip_DurationFact
			// 
			this.grcTrip_DurationFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_DurationFact.DataPropertyName = "DurationHoursMinutesFact";
			this.grcTrip_DurationFact.HeaderText = "Длит.";
			this.grcTrip_DurationFact.Name = "grcTrip_DurationFact";
			this.grcTrip_DurationFact.ReadOnly = true;
			this.grcTrip_DurationFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_DurationFact.ToolTipText = "Длительность рейса, часов:минут";
			this.grcTrip_DurationFact.Width = 70;
			// 
			// grcTrip_CostNormName
			// 
			this.grcTrip_CostNormName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_CostNormName.DataPropertyName = "CostNormName";
			this.grcTrip_CostNormName.HeaderText = "Норм.стоимости";
			this.grcTrip_CostNormName.Name = "grcTrip_CostNormName";
			this.grcTrip_CostNormName.ReadOnly = true;
			this.grcTrip_CostNormName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_CostNormName.ToolTipText = "Норматив стоимости";
			// 
			// grcTrip_Note
			// 
			this.grcTrip_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_Note.DataPropertyName = "Note";
			this.grcTrip_Note.HeaderText = "Примечание";
			this.grcTrip_Note.Name = "grcTrip_Note";
			this.grcTrip_Note.ReadOnly = true;
			this.grcTrip_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_Note.Width = 150;
			// 
			// grcTrip_ERPCode
			// 
			this.grcTrip_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_ERPCode.DataPropertyName = "ERPCode";
			this.grcTrip_ERPCode.HeaderText = "ERPCode";
			this.grcTrip_ERPCode.Name = "grcTrip_ERPCode";
			this.grcTrip_ERPCode.ReadOnly = true;
			this.grcTrip_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_ERPCode.ToolTipText = "Код в host-системе";
			this.grcTrip_ERPCode.Width = 80;
			// 
			// grcTrip_ID
			// 
			this.grcTrip_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTrip_ID.DataPropertyName = "ID";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcTrip_ID.DefaultCellStyle = dataGridViewCellStyle13;
			this.grcTrip_ID.HeaderText = "ID";
			this.grcTrip_ID.Name = "grcTrip_ID";
			this.grcTrip_ID.ReadOnly = true;
			this.grcTrip_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTrip_ID.ToolTipText = "Код рейса";
			this.grcTrip_ID.Width = 50;
			// 
			// btnService
			// 
			this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnService.ContextMenuStrip = this.mnuPassesService;
			this.btnService.Image = global::Logistics.Properties.Resources.Service;
			this.btnService.Location = new System.Drawing.Point(656, 439);
			this.btnService.Name = "btnService";
			this.btnService.Size = new System.Drawing.Size(30, 30);
			this.btnService.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnService, "Дополнительно");
			this.btnService.UseVisualStyleBackColor = true;
			this.btnService.Click += new System.EventHandler(this.btnService_Click);
			// 
			// mnuPassesService
			// 
			this.mnuPassesService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPassConfirm,
            this.mniPassUnConfirm,
            this.toolStripSeparator1,
            this.mniPassPermit,
            this.mniPassUnPermit,
            this.toolStripSeparator2,
            this.mniPassSetDateEntry,
            this.mniPassSetDateExit,
            this.toolStripSeparator3,
            this.mniPassClearDateEntry,
            this.mniPassClearDateExit});
			this.mnuPassesService.Name = "mnuPassesService";
			this.mnuPassesService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuPassesService.Size = new System.Drawing.Size(300, 198);
			// 
			// mniPassConfirm
			// 
			this.mniPassConfirm.Name = "mniPassConfirm";
			this.mniPassConfirm.Size = new System.Drawing.Size(299, 22);
			this.mniPassConfirm.Text = "Утвердить пропуск";
			this.mniPassConfirm.Click += new System.EventHandler(this.mniPassConfirm_Click);
			// 
			// mniPassUnConfirm
			// 
			this.mniPassUnConfirm.Name = "mniPassUnConfirm";
			this.mniPassUnConfirm.Size = new System.Drawing.Size(299, 22);
			this.mniPassUnConfirm.Text = "Снять отметку об утверждении пропуска";
			this.mniPassUnConfirm.Click += new System.EventHandler(this.mniPassUnConfirm_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(296, 6);
			// 
			// mniPassPermit
			// 
			this.mniPassPermit.Name = "mniPassPermit";
			this.mniPassPermit.Size = new System.Drawing.Size(299, 22);
			this.mniPassPermit.Text = "Разрешить очередное пересечение ворот";
			this.mniPassPermit.Click += new System.EventHandler(this.mniPassPermit_Click);
			// 
			// mniPassUnPermit
			// 
			this.mniPassUnPermit.Name = "mniPassUnPermit";
			this.mniPassUnPermit.Size = new System.Drawing.Size(299, 22);
			this.mniPassUnPermit.Text = "Запретить очередное пересечение ворот";
			this.mniPassUnPermit.Click += new System.EventHandler(this.mniPassUnPermit_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(296, 6);
			// 
			// mniPassSetDateEntry
			// 
			this.mniPassSetDateEntry.Name = "mniPassSetDateEntry";
			this.mniPassSetDateEntry.Size = new System.Drawing.Size(299, 22);
			this.mniPassSetDateEntry.Text = "Отметить въезд машины";
			this.mniPassSetDateEntry.Click += new System.EventHandler(this.mniPassSetDateEntry_Click);
			// 
			// mniPassSetDateExit
			// 
			this.mniPassSetDateExit.Name = "mniPassSetDateExit";
			this.mniPassSetDateExit.Size = new System.Drawing.Size(299, 22);
			this.mniPassSetDateExit.Text = "Отметить выезд машины";
			this.mniPassSetDateExit.Click += new System.EventHandler(this.mniPassSetDateExit_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(296, 6);
			// 
			// mniPassClearDateEntry
			// 
			this.mniPassClearDateEntry.Name = "mniPassClearDateEntry";
			this.mniPassClearDateEntry.Size = new System.Drawing.Size(299, 22);
			this.mniPassClearDateEntry.Text = "Снять отметку о въезде";
			this.mniPassClearDateEntry.Click += new System.EventHandler(this.mniPassClearDateEntry_Click);
			// 
			// mniPassClearDateExit
			// 
			this.mniPassClearDateExit.Name = "mniPassClearDateExit";
			this.mniPassClearDateExit.Size = new System.Drawing.Size(299, 22);
			this.mniPassClearDateExit.Text = "Снять отметку о выезде";
			this.mniPassClearDateExit.Click += new System.EventHandler(this.mniPassClearDateExit_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.ContextMenuStrip = this.mnuPassesPrint;
			this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(606, 439);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(30, 30);
			this.btnPrint.TabIndex = 5;
			this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// mnuPassesPrint
			// 
			this.mnuPassesPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPassPrint});
			this.mnuPassesPrint.Name = "mnuPassesPrint";
			this.mnuPassesPrint.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuPassesPrint.Size = new System.Drawing.Size(153, 48);
			// 
			// mniPassPrint
			// 
			this.mniPassPrint.Name = "mniPassPrint";
			this.mniPassPrint.Size = new System.Drawing.Size(152, 22);
			this.mniPassPrint.Text = "Пропуск";
			this.mniPassPrint.Click += new System.EventHandler(this.mniPassPrint_Click);
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
			this.btnDelete.Location = new System.Drawing.Point(556, 439);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(30, 30);
			this.btnDelete.TabIndex = 4;
			this.ttToolTip.SetToolTip(this.btnDelete, "Удаление заказа");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
			this.btnAdd.Location = new System.Drawing.Point(456, 438);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(30, 30);
			this.btnAdd.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.btnAdd, "Добавление заказа");
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
			this.btnEdit.Location = new System.Drawing.Point(506, 439);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(30, 30);
			this.btnEdit.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование заказа");
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// tmrRestore
			// 
			this.tmrRestore.Tick += new System.EventHandler(this.tmrRestore_Tick);
			// 
			// frmPasses
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 474);
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
			this.MinimumSize = new System.Drawing.Size(750, 501);
			this.Name = "frmPasses";
			this.hpHelp.SetShowHelp(this, true);
			this.Text = "Пропуска";
			this.Load += new System.EventHandler(this.frmPasses_Load);
			this.tcList.ResumeLayout(false);
			this.tabTerms.ResumeLayout(false);
			this.cntTerms.ResumeLayout(false);
			this.cntTerms.PerformLayout();
			this.pnlIsPermitted.ResumeLayout(false);
			this.pnlIsPermitted.PerformLayout();
			this.pnlIsConfirmed.ResumeLayout(false);
			this.pnlIsConfirmed.PerformLayout();
			this.dtrDates.ResumeLayout(false);
			this.dtrDates.PerformLayout();
			this.pnlPassesStatus.ResumeLayout(false);
			this.pnlPassesStatus.PerformLayout();
			this.tabData.ResumeLayout(false);
			this.cntGrids.Panel1.ResumeLayout(false);
			this.cntGrids.Panel2.ResumeLayout(false);
			this.cntGrids.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
			this.tcPasses.ResumeLayout(false);
			this.tabPasses_Trips.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdTrips)).EndInit();
			this.mnuPassesService.ResumeLayout(false);
			this.mnuPassesPrint.ResumeLayout(false);
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
		private RFMBaseClasses.RFMTabControl tcPasses;
		private RFMBaseClasses.RFMTabPage tabPasses_Trips;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblPassesStatus;
		private RFMBaseClasses.RFMPanel pnlPassesStatus;
		private RFMBaseClasses.RFMRadioButton optPassesStatusNotInNotOut;
		private RFMBaseClasses.RFMRadioButton optPassesStatusInNotOut;
		private RFMBaseClasses.RFMRadioButton optPassesStatusAll;
		private RFMBaseClasses.RFMLabel lblDatePass;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMRadioButton optPassesStatusInOut;
		private RFMBaseClasses.RFMLabel lblCarsTypes;
		private RFMBaseClasses.RFMLabel lblDriverNameContext;
		private RFMBaseClasses.RFMTextBox txtDriverNameContext;
		private RFMBaseClasses.RFMLabel lblCarNumberContext;
		private RFMBaseClasses.RFMTextBox txtCarNumberContext;
		private RFMBaseClasses.RFMLabel lblCarNameContext;
		private RFMBaseClasses.RFMTextBox txtCarNameContext;
		private RFMBaseClasses.RFMLabel lblReasonContext;
		private RFMBaseClasses.RFMTextBox txtReasonContext;
		private RFMBaseClasses.RFMDataGridView grdTrips;
		private RFMBaseClasses.RFMLabel lblPassesStatusInNotOut;
		private RFMBaseClasses.RFMTextBox txtCarTypeNameContext;
		private RFMBaseClasses.RFMLabel lblConfirmed;
		private RFMBaseClasses.RFMPanel pnlIsConfirmed;
		private RFMBaseClasses.RFMRadioButton optIsConfirmedNot;
		private RFMBaseClasses.RFMRadioButton optIsConfirmed;
		private RFMBaseClasses.RFMRadioButton optIsConfirmedAll;
		private RFMBaseClasses.RFMTimer tmrRestore;
		private RFMBaseClasses.RFMLabel lblIsPermitted;
		private RFMBaseClasses.RFMPanel pnlIsPermitted;
		private RFMBaseClasses.RFMRadioButton optIsPermittedNot;
		private RFMBaseClasses.RFMRadioButton optIsPermitted;
        private RFMBaseClasses.RFMRadioButton optIsPermittedAll;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcPassStatusImage;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcConfirmedImage;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcIsPermittedImage;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsArrival;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsDeparture;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDatePass;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateBeg;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateEnd;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDurationFact;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverDocument;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverPhone;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcBrutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPalletsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPartnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarrierName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNote;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn grcDateCreate;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcUserCreateName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateConfirm;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcUserConfirmName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcTrip_TripStatusImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_DateTrip;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcTrip_ForGoodsOnly;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_TripNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_DriverName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_Netto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_Brutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_PalletsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_PointsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_DateEnd;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_DateBeg;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_DurationFact;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_CostNormName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_Note;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_ERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrip_ID;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassPrint;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassConfirm;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassUnConfirm;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassPermit;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassUnPermit;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassSetDateEntry;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassSetDateExit;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassClearDateEntry;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniPassClearDateExit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		public RFMBaseClasses.RFMContextMenuStrip mnuPassesPrint;
		public RFMBaseClasses.RFMContextMenuStrip mnuPassesService;
	}
}