namespace Logistics
{
	partial class frmSalaryExtraWorks
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryExtraWorks));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tcList = new RFMBaseClasses.RFMTabControl();
			this.tabTerms = new RFMBaseClasses.RFMTabPage();
			this.cntTerms = new RFMBaseClasses.RFMPanel();
			this.ucSelectRecordID_DriversEmployees = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.btnWorkSelect = new RFMBaseClasses.RFMButton();
			this.lblWorkName = new RFMBaseClasses.RFMLabel();
			this.txtWorkName = new RFMBaseClasses.RFMTextBox();
			this.lblDriversEmployees = new RFMBaseClasses.RFMLabel();
			this.dtrDates = new RFMBaseClasses.RFMDateRange();
			this.btnClearTerms = new RFMBaseClasses.RFMButton();
			this.lblDate = new RFMBaseClasses.RFMLabel();
			this.tabSalaryExtraWorks = new RFMBaseClasses.RFMTabPage();
			this.dgvExtraWorks = new RFMBaseClasses.RFMDataGridView();
			this.btnEdit = new RFMBaseClasses.RFMButton();
			this.btnService = new RFMBaseClasses.RFMButton();
			this.btnPrint = new RFMBaseClasses.RFMButton();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnDelete = new RFMBaseClasses.RFMButton();
			this.btnCancel = new RFMBaseClasses.RFMButton();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.dgvcDateWork = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcWorkName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcPrice = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcAmount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcNote = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.tcList.SuspendLayout();
			this.tabTerms.SuspendLayout();
			this.cntTerms.SuspendLayout();
			this.ucSelectRecordID_DriversEmployees.SuspendLayout();
			this.dtrDates.SuspendLayout();
			this.tabSalaryExtraWorks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvExtraWorks)).BeginInit();
			this.SuspendLayout();
			// 
			// tcList
			// 
			this.tcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcList.Controls.Add(this.tabTerms);
			this.tcList.Controls.Add(this.tabSalaryExtraWorks);
			this.tcList.Location = new System.Drawing.Point(1, 1);
			this.tcList.Name = "tcList";
			this.tcList.SelectedIndex = 0;
			this.tcList.Size = new System.Drawing.Size(741, 432);
			this.tcList.TabIndex = 0;
			// 
			// tabTerms
			// 
			this.tabTerms.Controls.Add(this.cntTerms);
			this.tabTerms.IsFilterPage = true;
			this.tabTerms.Location = new System.Drawing.Point(4, 23);
			this.tabTerms.Name = "tabTerms";
			this.tabTerms.Padding = new System.Windows.Forms.Padding(3);
			this.tabTerms.Size = new System.Drawing.Size(733, 405);
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
			this.cntTerms.Controls.Add(this.ucSelectRecordID_DriversEmployees);
			this.cntTerms.Controls.Add(this.btnWorkSelect);
			this.cntTerms.Controls.Add(this.lblWorkName);
			this.cntTerms.Controls.Add(this.txtWorkName);
			this.cntTerms.Controls.Add(this.lblDriversEmployees);
			this.cntTerms.Controls.Add(this.dtrDates);
			this.cntTerms.Controls.Add(this.btnClearTerms);
			this.cntTerms.Controls.Add(this.lblDate);
			this.cntTerms.Location = new System.Drawing.Point(0, 2);
			this.cntTerms.Name = "cntTerms";
			this.cntTerms.Size = new System.Drawing.Size(732, 402);
			this.cntTerms.TabIndex = 0;
			// 
			// ucSelectRecordID_DriversEmployees
			// 
			// 
			// ucSelectRecordID_DriversEmployees.btnClear
			// 
			this.ucSelectRecordID_DriversEmployees.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_DriversEmployees.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_DriversEmployees.btnClear.Image")));
			this.ucSelectRecordID_DriversEmployees.BtnClear.Location = new System.Drawing.Point(247, 4);
			this.ucSelectRecordID_DriversEmployees.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_DriversEmployees.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_DriversEmployees.BtnClear.TabIndex = 2;
			this.ucSelectRecordID_DriversEmployees.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_DriversEmployees.btnSelect
			// 
			this.ucSelectRecordID_DriversEmployees.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_DriversEmployees.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_DriversEmployees.btnSelect.Image")));
			this.ucSelectRecordID_DriversEmployees.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_DriversEmployees.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_DriversEmployees.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_DriversEmployees.BtnSelect.TabIndex = 1;
			this.ucSelectRecordID_DriversEmployees.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_DriversEmployees.ExpSort = "Name";
			this.ucSelectRecordID_DriversEmployees.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_DriversEmployees.IsActualOnly = true;
			this.ucSelectRecordID_DriversEmployees.IsSaveMark = true;
			this.ucSelectRecordID_DriversEmployees.IsUseMark = true;
			this.ucSelectRecordID_DriversEmployees.Location = new System.Drawing.Point(172, 40);
			this.ucSelectRecordID_DriversEmployees.MarkedCount = 0;
			this.ucSelectRecordID_DriversEmployees.Name = "ucSelectRecordID_DriversEmployees";
			this.ucSelectRecordID_DriversEmployees.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_DriversEmployees.TabIndex = 3;
			this.ucSelectRecordID_DriversEmployees.TableColumnName = "Name";
			// 
			// ucSelectRecordID_DriversEmployees.txtData
			// 
			this.ucSelectRecordID_DriversEmployees.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_DriversEmployees.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_DriversEmployees.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_DriversEmployees.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_DriversEmployees.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_DriversEmployees.TxtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_DriversEmployees.TxtData.MaxLength = 128;
			this.ucSelectRecordID_DriversEmployees.TxtData.Name = "txtData";
			this.ucSelectRecordID_DriversEmployees.TxtData.ReadOnly = true;
			this.ucSelectRecordID_DriversEmployees.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_DriversEmployees.TxtData.TabIndex = 0;
			this.ucSelectRecordID_DriversEmployees.СolumnsData.AddRange(new string[] {
            "Name, Водитель",
            "Actual, Акт."});
			// 
			// btnWorkSelect
			// 
			this.btnWorkSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnWorkSelect.FlatAppearance.BorderSize = 0;
			this.btnWorkSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnWorkSelect.Image = global::Logistics.Properties.Resources.Detail;
			this.btnWorkSelect.Location = new System.Drawing.Point(396, 82);
			this.btnWorkSelect.Name = "btnWorkSelect";
			this.btnWorkSelect.Size = new System.Drawing.Size(25, 25);
			this.btnWorkSelect.TabIndex = 7;
			this.ttToolTip.SetToolTip(this.btnWorkSelect, "Выбор из ранее введенных значений");
			this.btnWorkSelect.UseVisualStyleBackColor = true;
			this.btnWorkSelect.Click += new System.EventHandler(this.btnWorkSelect_Click);
			// 
			// lblWorkName
			// 
			this.lblWorkName.AutoSize = true;
			this.lblWorkName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblWorkName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblWorkName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblWorkName.Location = new System.Drawing.Point(9, 87);
			this.lblWorkName.Name = "lblWorkName";
			this.lblWorkName.Size = new System.Drawing.Size(161, 14);
			this.lblWorkName.TabIndex = 5;
			this.lblWorkName.Text = "Название работ (контекст)";
			// 
			// txtWorkName
			// 
			this.txtWorkName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtWorkName.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtWorkName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtWorkName.Location = new System.Drawing.Point(173, 84);
			this.txtWorkName.MaxLength = 200;
			this.txtWorkName.Name = "txtWorkName";
			this.txtWorkName.Size = new System.Drawing.Size(220, 22);
			this.txtWorkName.TabIndex = 6;
			// 
			// lblDriversEmployees
			// 
			this.lblDriversEmployees.AutoSize = true;
			this.lblDriversEmployees.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDriversEmployees.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDriversEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDriversEmployees.Location = new System.Drawing.Point(9, 48);
			this.lblDriversEmployees.Name = "lblDriversEmployees";
			this.lblDriversEmployees.Size = new System.Drawing.Size(62, 14);
			this.lblDriversEmployees.TabIndex = 2;
			this.lblDriversEmployees.Text = "Водители";
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
			this.dtrDates.Location = new System.Drawing.Point(173, 3);
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
			this.btnClearTerms.Location = new System.Drawing.Point(704, 374);
			this.btnClearTerms.Name = "btnClearTerms";
			this.btnClearTerms.Size = new System.Drawing.Size(22, 22);
			this.btnClearTerms.TabIndex = 8;
			this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
			this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDate.Location = new System.Drawing.Point(9, 11);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(107, 14);
			this.lblDate.TabIndex = 0;
			this.lblDate.Text = "Дата выполнения";
			// 
			// tabSalaryExtraWorks
			// 
			this.tabSalaryExtraWorks.Controls.Add(this.dgvExtraWorks);
			this.tabSalaryExtraWorks.Location = new System.Drawing.Point(4, 23);
			this.tabSalaryExtraWorks.Name = "tabSalaryExtraWorks";
			this.tabSalaryExtraWorks.Size = new System.Drawing.Size(733, 405);
			this.tabSalaryExtraWorks.TabIndex = 1;
			this.tabSalaryExtraWorks.Text = "Дополнительные работы";
			this.tabSalaryExtraWorks.UseVisualStyleBackColor = true;
			// 
			// dgvExtraWorks
			// 
			this.dgvExtraWorks.AllowUserToAddRows = false;
			this.dgvExtraWorks.AllowUserToDeleteRows = false;
			this.dgvExtraWorks.AllowUserToOrderColumns = true;
			this.dgvExtraWorks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dgvExtraWorks.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgvExtraWorks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dgvExtraWorks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvExtraWorks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvExtraWorks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvExtraWorks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcDateWork,
            this.dgvcDriverName,
            this.dgvcWorkName,
            this.dgvcQnt,
            this.dgvcPrice,
            this.dgvcAmount,
            this.dgvcNote,
            this.dgvcERPCode,
            this.dgvcID});
			this.dgvExtraWorks.IsCheckerInclude = true;
			this.dgvExtraWorks.IsConfigInclude = true;
			this.dgvExtraWorks.IsMarkedAll = false;
			this.dgvExtraWorks.IsStatusInclude = true;
			this.dgvExtraWorks.IsStatusShow = true;
			this.dgvExtraWorks.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.dgvExtraWorks.Location = new System.Drawing.Point(2, 3);
			this.dgvExtraWorks.MultiSelect = false;
			this.dgvExtraWorks.Name = "dgvExtraWorks";
			this.dgvExtraWorks.RangedWay = ' ';
			this.dgvExtraWorks.ReadOnly = true;
			this.dgvExtraWorks.RowHeadersWidth = 24;
			this.dgvExtraWorks.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvExtraWorks.Size = new System.Drawing.Size(729, 400);
			this.dgvExtraWorks.StatusRowState = ((byte)(2));
			this.dgvExtraWorks.TabIndex = 16;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
			this.btnEdit.Location = new System.Drawing.Point(506, 439);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(30, 30);
			this.btnEdit.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.btnEdit, "Редактирование");
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnService
			// 
			this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnService.Image = global::Logistics.Properties.Resources.Service;
			this.btnService.Location = new System.Drawing.Point(656, 439);
			this.btnService.Name = "btnService";
			this.btnService.Size = new System.Drawing.Size(30, 30);
			this.btnService.TabIndex = 5;
			this.ttToolTip.SetToolTip(this.btnService, "Дополнительно");
			this.btnService.UseVisualStyleBackColor = true;
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(606, 439);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(30, 30);
			this.btnPrint.TabIndex = 4;
			this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
			this.btnPrint.UseVisualStyleBackColor = true;
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
			this.btnDelete.TabIndex = 3;
			this.ttToolTip.SetToolTip(this.btnDelete, "Удаление");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Image = global::Logistics.Properties.Resources.Exit;
			this.btnCancel.Location = new System.Drawing.Point(706, 439);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(30, 30);
			this.btnCancel.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnCancel, "Выход");
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
			this.btnAdd.Location = new System.Drawing.Point(456, 439);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(30, 30);
			this.btnAdd.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.btnAdd, "Добавление");
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// dgvcDateWork
			// 
			this.dgvcDateWork.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcDateWork.DataPropertyName = "DateWork";
			dataGridViewCellStyle2.Format = "dd.MM.yyyy";
			this.dgvcDateWork.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvcDateWork.HeaderText = "Дата";
			this.dgvcDateWork.Name = "dgvcDateWork";
			this.dgvcDateWork.ReadOnly = true;
			this.dgvcDateWork.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcDateWork.ToolTipText = "Дата выполнения работ";
			this.dgvcDateWork.Width = 80;
			// 
			// dgvcDriverName
			// 
			this.dgvcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcDriverName.DataPropertyName = "DriverName";
			this.dgvcDriverName.HeaderText = "Исполнитель (водитель)";
			this.dgvcDriverName.Name = "dgvcDriverName";
			this.dgvcDriverName.ReadOnly = true;
			this.dgvcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcDriverName.Width = 200;
			// 
			// dgvcWorkName
			// 
			this.dgvcWorkName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcWorkName.DataPropertyName = "WorkName";
			this.dgvcWorkName.HeaderText = "Работа";
			this.dgvcWorkName.Name = "dgvcWorkName";
			this.dgvcWorkName.ReadOnly = true;
			this.dgvcWorkName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcWorkName.ToolTipText = "Название работы";
			this.dgvcWorkName.Width = 200;
			// 
			// dgvcQnt
			// 
			this.dgvcQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcQnt.DataPropertyName = "Qnt";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "N1";
			dataGridViewCellStyle3.NullValue = null;
			this.dgvcQnt.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvcQnt.HeaderText = "Кол-во";
			this.dgvcQnt.Name = "dgvcQnt";
			this.dgvcQnt.ReadOnly = true;
			this.dgvcQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcQnt.ToolTipText = "Количество";
			this.dgvcQnt.Width = 60;
			// 
			// dgvcPrice
			// 
			this.dgvcPrice.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcPrice.DataPropertyName = "Price";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N2";
			dataGridViewCellStyle4.NullValue = null;
			this.dgvcPrice.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgvcPrice.HeaderText = "Тариф";
			this.dgvcPrice.Name = "dgvcPrice";
			this.dgvcPrice.ReadOnly = true;
			this.dgvcPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvcPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcPrice.ToolTipText = "Тариф (стоимость за единицу работ)";
			this.dgvcPrice.Width = 60;
			// 
			// dgvcAmount
			// 
			this.dgvcAmount.AgrType = RFMBaseClasses.EnumAgregate.Sum;
			this.dgvcAmount.DataPropertyName = "Amount";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N2";
			dataGridViewCellStyle5.NullValue = null;
			this.dgvcAmount.DefaultCellStyle = dataGridViewCellStyle5;
			this.dgvcAmount.HeaderText = "Стоимость";
			this.dgvcAmount.Name = "dgvcAmount";
			this.dgvcAmount.ReadOnly = true;
			this.dgvcAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcAmount.Width = 80;
			// 
			// dgvcNote
			// 
			this.dgvcNote.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.dgvcNote.DataPropertyName = "Note";
			this.dgvcNote.HeaderText = "Примечание";
			this.dgvcNote.Name = "dgvcNote";
			this.dgvcNote.ReadOnly = true;
			this.dgvcNote.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcNote.Width = 200;
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
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dgvcID.DefaultCellStyle = dataGridViewCellStyle6;
			this.dgvcID.HeaderText = "ID";
			this.dgvcID.Name = "dgvcID";
			this.dgvcID.ReadOnly = true;
			this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.dgvcID.ToolTipText = "Код записи";
			this.dgvcID.Width = 50;
			// 
			// frmSalaryExtraWorks
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
			this.LastGrid = this.dgvExtraWorks;
			this.MinimumSize = new System.Drawing.Size(750, 501);
			this.Name = "frmSalaryExtraWorks";
			this.hpHelp.SetShowHelp(this, true);
			this.Text = "Дополнительные выполненные работы";
			this.Load += new System.EventHandler(this.frmSalaryExtraWorks_Load);
			this.tcList.ResumeLayout(false);
			this.tabTerms.ResumeLayout(false);
			this.cntTerms.ResumeLayout(false);
			this.cntTerms.PerformLayout();
			this.ucSelectRecordID_DriversEmployees.ResumeLayout(false);
			this.ucSelectRecordID_DriversEmployees.PerformLayout();
			this.dtrDates.ResumeLayout(false);
			this.dtrDates.PerformLayout();
			this.tabSalaryExtraWorks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvExtraWorks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnCancel;
        private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblDriversEmployees;
		private RFMBaseClasses.RFMTabPage tabSalaryExtraWorks;
		private RFMBaseClasses.RFMDataGridView dgvExtraWorks;
		private RFMBaseClasses.RFMButton btnWorkSelect;
		private RFMBaseClasses.RFMLabel lblWorkName;
		private RFMBaseClasses.RFMTextBox txtWorkName;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_DriversEmployees;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateWork;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDriverName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcWorkName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcQnt;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPrice;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcAmount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcNote;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
	}
}