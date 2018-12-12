namespace Logistics
{
	partial class frmOutputsDocumentsVeterinaryBlankData
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
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.chkSecondPage = new RFMBaseClasses.RFMCheckBox();
            this.chkVeterinaryListAdd = new RFMBaseClasses.RFMCheckBox();
            this.txtVeterinarFio = new RFMBaseClasses.RFMTextBox();
            this.lblVeterinar = new RFMBaseClasses.RFMLabel();
            this.btnGo = new RFMBaseClasses.RFMButton();
            this.pnlPartner = new RFMBaseClasses.RFMPanel();
            this.optPartnerGroup = new RFMBaseClasses.RFMRadioButton();
            this.optPartnerSeparate = new RFMBaseClasses.RFMRadioButton();
            this.pnlBlank = new RFMBaseClasses.RFMPanel();
            this.optLocalBlank = new RFMBaseClasses.RFMRadioButton();
            this.optNotLocalBlank = new RFMBaseClasses.RFMRadioButton();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcIsPrintedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.grcIsPrinted = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grсVeterinaryPartnerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grсBayerLegalName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcLocalBlank = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcVeterinaryBlankSeries = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcVeterinaryBlankNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcVeterinaryPermission = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcVeterinaryDateOfProducing = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTransportText = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcVeterinaryPacking = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCOutputsDocumentsText = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnCopy = new RFMBaseClasses.RFMButton();
            this.btnVeterinaryBlankSeriesBlankLast = new RFMBaseClasses.RFMButton();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.pnlData.SuspendLayout();
            this.pnlPartner.SuspendLayout();
            this.pnlBlank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 307);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 0;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(653, 307);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(603, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.chkSecondPage);
            this.pnlData.Controls.Add(this.chkVeterinaryListAdd);
            this.pnlData.Controls.Add(this.txtVeterinarFio);
            this.pnlData.Controls.Add(this.lblVeterinar);
            this.pnlData.Controls.Add(this.btnGo);
            this.pnlData.Controls.Add(this.pnlPartner);
            this.pnlData.Controls.Add(this.pnlBlank);
            this.pnlData.Controls.Add(this.grdData);
            this.pnlData.Location = new System.Drawing.Point(4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(684, 295);
            this.pnlData.TabIndex = 1;
            // 
            // chkSecondPage
            // 
            this.chkSecondPage.AutoSize = true;
            this.chkSecondPage.Location = new System.Drawing.Point(225, 28);
            this.chkSecondPage.Name = "chkSecondPage";
            this.chkSecondPage.Size = new System.Drawing.Size(121, 18);
            this.chkSecondPage.TabIndex = 42;
            this.chkSecondPage.Text = "печать 2-ой стр.";
            this.chkSecondPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkSecondPage.UseVisualStyleBackColor = true;
            // 
            // chkVeterinaryListAdd
            // 
            this.chkVeterinaryListAdd.AutoSize = true;
            this.chkVeterinaryListAdd.Location = new System.Drawing.Point(225, 8);
            this.chkVeterinaryListAdd.Name = "chkVeterinaryListAdd";
            this.chkVeterinaryListAdd.Size = new System.Drawing.Size(99, 18);
            this.chkVeterinaryListAdd.TabIndex = 41;
            this.chkVeterinaryListAdd.Text = "приложение";
            this.chkVeterinaryListAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkVeterinaryListAdd.UseVisualStyleBackColor = true;
            // 
            // txtVeterinarFio
            // 
            this.txtVeterinarFio.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtVeterinarFio.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtVeterinarFio.Location = new System.Drawing.Point(79, 55);
            this.txtVeterinarFio.Name = "txtVeterinarFio";
            this.txtVeterinarFio.Size = new System.Drawing.Size(500, 22);
            this.txtVeterinarFio.TabIndex = 40;
            // 
            // lblVeterinar
            // 
            this.lblVeterinar.AutoSize = true;
            this.lblVeterinar.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblVeterinar.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblVeterinar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVeterinar.Location = new System.Drawing.Point(5, 58);
            this.lblVeterinar.Name = "lblVeterinar";
            this.lblVeterinar.Size = new System.Drawing.Size(68, 14);
            this.lblVeterinar.TabIndex = 39;
            this.lblVeterinar.Text = "Ветеринар";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Image = global::Logistics.Properties.Resources.Go;
            this.btnGo.Location = new System.Drawing.Point(645, 5);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(32, 30);
            this.btnGo.TabIndex = 38;
            this.ttToolTip.SetToolTip(this.btnGo, "Получить список");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // pnlPartner
            // 
            this.pnlPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPartner.Controls.Add(this.optPartnerGroup);
            this.pnlPartner.Controls.Add(this.optPartnerSeparate);
            this.pnlPartner.Location = new System.Drawing.Point(372, 3);
            this.pnlPartner.Name = "pnlPartner";
            this.pnlPartner.Size = new System.Drawing.Size(266, 48);
            this.pnlPartner.TabIndex = 37;
            // 
            // optPartnerGroup
            // 
            this.optPartnerGroup.AutoSize = true;
            this.optPartnerGroup.Checked = true;
            this.optPartnerGroup.IsChanged = true;
            this.optPartnerGroup.Location = new System.Drawing.Point(5, 5);
            this.optPartnerGroup.Name = "optPartnerGroup";
            this.optPartnerGroup.Size = new System.Drawing.Size(253, 18);
            this.optPartnerGroup.TabIndex = 0;
            this.optPartnerGroup.TabStop = true;
            this.optPartnerGroup.Text = "объединять документы одного клиента";
            this.optPartnerGroup.UseVisualStyleBackColor = true;
            // 
            // optPartnerSeparate
            // 
            this.optPartnerSeparate.AutoSize = true;
            this.optPartnerSeparate.IsChanged = true;
            this.optPartnerSeparate.Location = new System.Drawing.Point(5, 25);
            this.optPartnerSeparate.Name = "optPartnerSeparate";
            this.optPartnerSeparate.Size = new System.Drawing.Size(185, 18);
            this.optPartnerSeparate.TabIndex = 1;
            this.optPartnerSeparate.Text = "каждый документ отдельно";
            this.optPartnerSeparate.UseVisualStyleBackColor = true;
            // 
            // pnlBlank
            // 
            this.pnlBlank.Controls.Add(this.optLocalBlank);
            this.pnlBlank.Controls.Add(this.optNotLocalBlank);
            this.pnlBlank.Location = new System.Drawing.Point(3, 3);
            this.pnlBlank.Name = "pnlBlank";
            this.pnlBlank.Size = new System.Drawing.Size(200, 48);
            this.pnlBlank.TabIndex = 36;
            // 
            // optLocalBlank
            // 
            this.optLocalBlank.AutoSize = true;
            this.optLocalBlank.IsChanged = true;
            this.optLocalBlank.Location = new System.Drawing.Point(5, 25);
            this.optLocalBlank.Name = "optLocalBlank";
            this.optLocalBlank.Size = new System.Drawing.Size(188, 18);
            this.optLocalBlank.TabIndex = 0;
            this.optLocalBlank.Text = "форма Ф-4 (местный бланк)";
            this.optLocalBlank.UseVisualStyleBackColor = true;
            // 
            // optNotLocalBlank
            // 
            this.optNotLocalBlank.AutoSize = true;
            this.optNotLocalBlank.Checked = true;
            this.optNotLocalBlank.IsChanged = true;
            this.optNotLocalBlank.Location = new System.Drawing.Point(5, 5);
            this.optNotLocalBlank.Name = "optNotLocalBlank";
            this.optNotLocalBlank.Size = new System.Drawing.Size(176, 18);
            this.optNotLocalBlank.TabIndex = 1;
            this.optNotLocalBlank.TabStop = true;
            this.optNotLocalBlank.Text = "форма Ф-2 (общий бланк)";
            this.optNotLocalBlank.UseVisualStyleBackColor = true;
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
            this.grcIsPrintedImage,
            this.grcIsPrinted,
            this.grсVeterinaryPartnerName,
            this.grсBayerLegalName,
            this.grcLocalBlank,
            this.grcVeterinaryBlankSeries,
            this.grcVeterinaryBlankNumber,
            this.grcVeterinaryPermission,
            this.grcVeterinaryDateOfProducing,
            this.grcTransportText,
            this.grcVeterinaryPacking,
            this.grcCOutputsDocumentsText});
            this.grdData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdData.IsCheckerInclude = true;
            this.grdData.IsCheckerShow = true;
            this.grdData.IsConfigInclude = true;
            this.grdData.IsMarkedAll = false;
            this.grdData.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdData.Location = new System.Drawing.Point(2, 80);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdData.Size = new System.Drawing.Size(677, 210);
            this.grdData.TabIndex = 35;
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
            // 
            // grcIsPrintedImage
            // 
            this.grcIsPrintedImage.HeaderText = "Печ.";
            this.grcIsPrintedImage.Name = "grcIsPrintedImage";
            this.grcIsPrintedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsPrintedImage.ToolTipText = "Напечатано?";
            this.grcIsPrintedImage.Width = 40;
            // 
            // grcIsPrinted
            // 
            this.grcIsPrinted.DataPropertyName = "IsPrinted";
            this.grcIsPrinted.HeaderText = "Печ.";
            this.grcIsPrinted.Name = "grcIsPrinted";
            this.grcIsPrinted.ReadOnly = true;
            this.grcIsPrinted.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcIsPrinted.ToolTipText = "Напечатано?";
            this.grcIsPrinted.Visible = false;
            this.grcIsPrinted.Width = 40;
            // 
            // grсVeterinaryPartnerName
            // 
            this.grсVeterinaryPartnerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grсVeterinaryPartnerName.DataPropertyName = "VeterinaryPartnerName";
            this.grсVeterinaryPartnerName.HeaderText = "Кем выдан";
            this.grсVeterinaryPartnerName.Name = "grсVeterinaryPartnerName";
            this.grсVeterinaryPartnerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grсVeterinaryPartnerName.Width = 150;
            // 
            // grсBayerLegalName
            // 
            this.grсBayerLegalName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grсBayerLegalName.DataPropertyName = "BayerLegalName";
            this.grсBayerLegalName.HeaderText = "Получатель";
            this.grсBayerLegalName.Name = "grсBayerLegalName";
            this.grсBayerLegalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grсBayerLegalName.Width = 200;
            // 
            // grcLocalBlank
            // 
            this.grcLocalBlank.DataPropertyName = "LocalBlank";
            this.grcLocalBlank.HeaderText = "Ф-4";
            this.grcLocalBlank.Name = "grcLocalBlank";
            this.grcLocalBlank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcLocalBlank.ToolTipText = "\"Местный\" бланк?";
            this.grcLocalBlank.Width = 40;
            // 
            // grcVeterinaryBlankSeries
            // 
            this.grcVeterinaryBlankSeries.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcVeterinaryBlankSeries.DataPropertyName = "VeterinaryBlankSeries";
            this.grcVeterinaryBlankSeries.HeaderText = "Сер. ВС";
            this.grcVeterinaryBlankSeries.MaxInputLength = 3;
            this.grcVeterinaryBlankSeries.Name = "grcVeterinaryBlankSeries";
            this.grcVeterinaryBlankSeries.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcVeterinaryBlankSeries.ToolTipText = "Серия бланка вет. свидетельства";
            this.grcVeterinaryBlankSeries.Width = 60;
            // 
            // grcVeterinaryBlankNumber
            // 
            this.grcVeterinaryBlankNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcVeterinaryBlankNumber.DataPropertyName = "VeterinaryBlankNumber";
            this.grcVeterinaryBlankNumber.HeaderText = "№ ВС";
            this.grcVeterinaryBlankNumber.MaxInputLength = 8;
            this.grcVeterinaryBlankNumber.Name = "grcVeterinaryBlankNumber";
            this.grcVeterinaryBlankNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcVeterinaryBlankNumber.ToolTipText = "Номер бланка вет. свидетельства";
            this.grcVeterinaryBlankNumber.Width = 80;
            // 
            // grcVeterinaryPermission
            // 
            this.grcVeterinaryPermission.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcVeterinaryPermission.DataPropertyName = "VeterinaryPermission";
            this.grcVeterinaryPermission.HeaderText = "Разрешение";
            this.grcVeterinaryPermission.Name = "grcVeterinaryPermission";
            this.grcVeterinaryPermission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcVeterinaryPermission.Width = 150;
            // 
            // grcVeterinaryDateOfProducing
            // 
            this.grcVeterinaryDateOfProducing.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcVeterinaryDateOfProducing.DataPropertyName = "VeterinaryDateOfProducing";
            this.grcVeterinaryDateOfProducing.HeaderText = "Даты выработки";
            this.grcVeterinaryDateOfProducing.Name = "grcVeterinaryDateOfProducing";
            this.grcVeterinaryDateOfProducing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcVeterinaryDateOfProducing.Width = 150;
            // 
            // grcTransportText
            // 
            this.grcTransportText.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTransportText.DataPropertyName = "TransportText";
            this.grcTransportText.HeaderText = "Маршрут";
            this.grcTransportText.Name = "grcTransportText";
            this.grcTransportText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTransportText.Width = 150;
            // 
            // grcVeterinaryPacking
            // 
            this.grcVeterinaryPacking.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcVeterinaryPacking.DataPropertyName = "VeterinaryPacking";
            this.grcVeterinaryPacking.HeaderText = "Упаковка";
            this.grcVeterinaryPacking.Name = "grcVeterinaryPacking";
            this.grcVeterinaryPacking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcCOutputsDocumentsText
            // 
            this.grcCOutputsDocumentsText.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCOutputsDocumentsText.DataPropertyName = "COutputsDocumentsText";
            this.grcCOutputsDocumentsText.HeaderText = "Документы";
            this.grcCOutputsDocumentsText.Name = "grcCOutputsDocumentsText";
            this.grcCOutputsDocumentsText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCOutputsDocumentsText.Width = 150;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Image = global::Logistics.Properties.Resources.Copy;
            this.btnCopy.Location = new System.Drawing.Point(107, 307);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(32, 30);
            this.btnCopy.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.btnCopy, "Скопировать для для всех документов получателя");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnVeterinaryBlankSeriesBlankLast
            // 
            this.btnVeterinaryBlankSeriesBlankLast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVeterinaryBlankSeriesBlankLast.Image = global::Logistics.Properties.Resources.Go;
            this.btnVeterinaryBlankSeriesBlankLast.Location = new System.Drawing.Point(57, 307);
            this.btnVeterinaryBlankSeriesBlankLast.Name = "btnVeterinaryBlankSeriesBlankLast";
            this.btnVeterinaryBlankSeriesBlankLast.Size = new System.Drawing.Size(32, 30);
            this.btnVeterinaryBlankSeriesBlankLast.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.btnVeterinaryBlankSeriesBlankLast, "Получить текущую серию бланков ветеринарных свидетельств");
            this.btnVeterinaryBlankSeriesBlankLast.UseVisualStyleBackColor = true;
            this.btnVeterinaryBlankSeriesBlankLast.Click += new System.EventHandler(this.btnVeterinaryBlankSeriesBlankLast_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(503, 307);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печатать");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmOutputsDocumentsVeterinaryBlankData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 343);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnVeterinaryBlankSeriesBlankLast);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmOutputsDocumentsVeterinaryBlankData";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходные документы - бланки ветеринарных свидетельств";
            this.Load += new System.EventHandler(this.frmOutputsDocumentsVeterinaryBlankData_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlPartner.ResumeLayout(false);
            this.pnlPartner.PerformLayout();
            this.pnlBlank.ResumeLayout(false);
            this.pnlBlank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMButton btnCopy;
		private RFMBaseClasses.RFMButton btnVeterinaryBlankSeriesBlankLast;
		private RFMBaseClasses.RFMPanel pnlPartner;
		private RFMBaseClasses.RFMRadioButton optPartnerGroup;
		private RFMBaseClasses.RFMRadioButton optPartnerSeparate;
		private RFMBaseClasses.RFMPanel pnlBlank;
		private RFMBaseClasses.RFMRadioButton optLocalBlank;
		private RFMBaseClasses.RFMRadioButton optNotLocalBlank;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnGo;
		private RFMBaseClasses.RFMLabel lblVeterinar;
        private RFMBaseClasses.RFMTextBox txtVeterinarFio;
        private RFMBaseClasses.RFMCheckBox chkVeterinaryListAdd;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcIsPrintedImage;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsPrinted;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grсVeterinaryPartnerName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grсBayerLegalName;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcLocalBlank;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcVeterinaryBlankSeries;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcVeterinaryBlankNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcVeterinaryPermission;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcVeterinaryDateOfProducing;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTransportText;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcVeterinaryPacking;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCOutputsDocumentsText;
        private RFMBaseClasses.RFMCheckBox chkSecondPage;

	}
}

