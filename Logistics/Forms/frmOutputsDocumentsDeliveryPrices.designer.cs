namespace Logistics
{
	partial class frmOutputsDocumentsDeliveryPrices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOutputsDocumentsDeliveryPrices));
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnPrintFacture = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.grdOutputsDocuments = new RFMBaseClasses.RFMDataGridView();
            this.grcOutputsDocuments_IsConfirmedImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.grcOutputsDocuments_IsBroughtImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.grcOutputsDocuments_DateOutput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_PartnerSourceName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_PartnerTargetName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DeliveryPrice = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DeliveryCurrencyName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_ZoneName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_TripAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_Amount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_Brutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_PalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_ManagerName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_ManagerPhone = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DepartmentName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_WarrantNeed = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcOutputsDocuments_FactureNeed = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcOutputsDocuments_FactureNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_BillNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_GetMoneyWished = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_GetPalletsQntWished = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DeliveryAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DeliveryPassage = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_NotForJoin = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcOutputsDocuments_NoteExecute = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_OutputDocumentFailReasonName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DateConfirm = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_DateBring = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_OutputDocumentTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOutputsDocuments_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dtrDates = new RFMBaseClasses.RFMDateRange();
            this.lblDate = new RFMBaseClasses.RFMLabel();
            this.btnGo = new RFMBaseClasses.RFMButton();
            this.chkFactureNeedOnly = new RFMBaseClasses.RFMCheckBox();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.pnlTotal = new RFMBaseClasses.RFMPanel();
            this.lblSumDeliveryPrice = new RFMBaseClasses.RFMLabel();
            this.lblSumDeliveryPriceLabel = new RFMBaseClasses.RFMLabel();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutputsDocuments)).BeginInit();
            this.dtrDates.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(6, 388);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(704, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrintFacture
            // 
            this.btnPrintFacture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintFacture.Image = global::Logistics.Properties.Resources.Printer_iz;
            this.btnPrintFacture.Location = new System.Drawing.Point(604, 388);
            this.btnPrintFacture.Name = "btnPrintFacture";
            this.btnPrintFacture.Size = new System.Drawing.Size(32, 30);
            this.btnPrintFacture.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnPrintFacture, "Печатать счета-фактуры");
            this.btnPrintFacture.UseVisualStyleBackColor = true;
            this.btnPrintFacture.Visible = false;
            this.btnPrintFacture.Click += new System.EventHandler(this.btnPrintFacture_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.grdOutputsDocuments);
            this.pnlData.Controls.Add(this.dtrDates);
            this.pnlData.Controls.Add(this.lblDate);
            this.pnlData.Controls.Add(this.btnGo);
            this.pnlData.Controls.Add(this.chkFactureNeedOnly);
            this.pnlData.Location = new System.Drawing.Point(5, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(732, 377);
            this.pnlData.TabIndex = 0;
            // 
            // grdOutputsDocuments
            // 
            this.grdOutputsDocuments.AllowUserToAddRows = false;
            this.grdOutputsDocuments.AllowUserToDeleteRows = false;
            this.grdOutputsDocuments.AllowUserToOrderColumns = true;
            this.grdOutputsDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOutputsDocuments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdOutputsDocuments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOutputsDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOutputsDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOutputsDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcOutputsDocuments_IsConfirmedImage,
            this.grcOutputsDocuments_IsBroughtImage,
            this.grcOutputsDocuments_DateOutput,
            this.grcOutputsDocuments_PartnerSourceName,
            this.grcOutputsDocuments_PartnerTargetName,
            this.grcOutputsDocuments_DeliveryPrice,
            this.grcOutputsDocuments_DeliveryCurrencyName,
            this.grcOutputsDocuments_ZoneName,
            this.grcOutputsDocuments_TripAlias,
            this.grcOutputsDocuments_Amount,
            this.grcOutputsDocuments_Brutto,
            this.grcOutputsDocuments_PalletsQnt,
            this.grcOutputsDocuments_ManagerName,
            this.grcOutputsDocuments_ManagerPhone,
            this.grcOutputsDocuments_DepartmentName,
            this.grcOutputsDocuments_WarrantNeed,
            this.grcOutputsDocuments_FactureNeed,
            this.grcOutputsDocuments_FactureNumber,
            this.grcOutputsDocuments_BillNumber,
            this.grcOutputsDocuments_GetMoneyWished,
            this.grcOutputsDocuments_GetPalletsQntWished,
            this.grcOutputsDocuments_Note,
            this.grcOutputsDocuments_DeliveryAddress,
            this.grcOutputsDocuments_DeliveryPassage,
            this.grcOutputsDocuments_NotForJoin,
            this.grcOutputsDocuments_NoteExecute,
            this.grcOutputsDocuments_OutputDocumentFailReasonName,
            this.grcOutputsDocuments_DateConfirm,
            this.grcOutputsDocuments_DateBring,
            this.grcOutputsDocuments_OutputDocumentTypeName,
            this.grcOutputsDocuments_ERPCode,
            this.grcOutputsDocuments_ID});
            this.grdOutputsDocuments.IsCheckerInclude = true;
            this.grdOutputsDocuments.IsConfigInclude = true;
            this.grdOutputsDocuments.IsMarkedAll = false;
            this.grdOutputsDocuments.IsStatusInclude = true;
            this.grdOutputsDocuments.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdOutputsDocuments.Location = new System.Drawing.Point(2, 33);
            this.grdOutputsDocuments.MultiSelect = false;
            this.grdOutputsDocuments.Name = "grdOutputsDocuments";
            this.grdOutputsDocuments.RangedWay = ' ';
            this.grdOutputsDocuments.ReadOnly = true;
            this.grdOutputsDocuments.RowHeadersWidth = 24;
            this.grdOutputsDocuments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOutputsDocuments.Size = new System.Drawing.Size(724, 338);
            this.grdOutputsDocuments.TabIndex = 13;
            this.grdOutputsDocuments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdOutputsDocuments_CellFormatting);
            // 
            // grcOutputsDocuments_IsConfirmedImage
            // 
            this.grcOutputsDocuments_IsConfirmedImage.DataPropertyName = "IsConfirmed";
            this.grcOutputsDocuments_IsConfirmedImage.HeaderText = "Отгр.";
            this.grcOutputsDocuments_IsConfirmedImage.Name = "grcOutputsDocuments_IsConfirmedImage";
            this.grcOutputsDocuments_IsConfirmedImage.ReadOnly = true;
            this.grcOutputsDocuments_IsConfirmedImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_IsConfirmedImage.ToolTipText = "Зарегистрирована отгрузка со склада?";
            this.grcOutputsDocuments_IsConfirmedImage.Width = 45;
            // 
            // grcOutputsDocuments_IsBroughtImage
            // 
            this.grcOutputsDocuments_IsBroughtImage.DataPropertyName = "IsBrought";
            this.grcOutputsDocuments_IsBroughtImage.HeaderText = "Дост.";
            this.grcOutputsDocuments_IsBroughtImage.Name = "grcOutputsDocuments_IsBroughtImage";
            this.grcOutputsDocuments_IsBroughtImage.ReadOnly = true;
            this.grcOutputsDocuments_IsBroughtImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_IsBroughtImage.ToolTipText = "Зарегистрирована доставка товара клиенту?";
            this.grcOutputsDocuments_IsBroughtImage.Width = 45;
            // 
            // grcOutputsDocuments_DateOutput
            // 
            this.grcOutputsDocuments_DateOutput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DateOutput.DataPropertyName = "DateOutput";
            dataGridViewCellStyle2.Format = "dd.MM.yyyy";
            this.grcOutputsDocuments_DateOutput.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcOutputsDocuments_DateOutput.HeaderText = "Дата";
            this.grcOutputsDocuments_DateOutput.Name = "grcOutputsDocuments_DateOutput";
            this.grcOutputsDocuments_DateOutput.ReadOnly = true;
            this.grcOutputsDocuments_DateOutput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DateOutput.ToolTipText = "Дата документа";
            this.grcOutputsDocuments_DateOutput.Width = 80;
            // 
            // grcOutputsDocuments_PartnerSourceName
            // 
            this.grcOutputsDocuments_PartnerSourceName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_PartnerSourceName.DataPropertyName = "PartnerSourceName";
            this.grcOutputsDocuments_PartnerSourceName.HeaderText = "Поставщик";
            this.grcOutputsDocuments_PartnerSourceName.Name = "grcOutputsDocuments_PartnerSourceName";
            this.grcOutputsDocuments_PartnerSourceName.ReadOnly = true;
            this.grcOutputsDocuments_PartnerSourceName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_PartnerSourceName.ToolTipText = "Клиент-поставщик";
            this.grcOutputsDocuments_PartnerSourceName.Width = 150;
            // 
            // grcOutputsDocuments_PartnerTargetName
            // 
            this.grcOutputsDocuments_PartnerTargetName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_PartnerTargetName.DataPropertyName = "PartnerTargetName";
            this.grcOutputsDocuments_PartnerTargetName.HeaderText = "Получатель";
            this.grcOutputsDocuments_PartnerTargetName.Name = "grcOutputsDocuments_PartnerTargetName";
            this.grcOutputsDocuments_PartnerTargetName.ReadOnly = true;
            this.grcOutputsDocuments_PartnerTargetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_PartnerTargetName.ToolTipText = "Клиент-получатель";
            this.grcOutputsDocuments_PartnerTargetName.Width = 250;
            // 
            // grcOutputsDocuments_DeliveryPrice
            // 
            this.grcOutputsDocuments_DeliveryPrice.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DeliveryPrice.DataPropertyName = "DeliveryPrice";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.grcOutputsDocuments_DeliveryPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcOutputsDocuments_DeliveryPrice.HeaderText = "Трансп.усл.";
            this.grcOutputsDocuments_DeliveryPrice.Name = "grcOutputsDocuments_DeliveryPrice";
            this.grcOutputsDocuments_DeliveryPrice.ReadOnly = true;
            this.grcOutputsDocuments_DeliveryPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DeliveryPrice.ToolTipText = "Стоимость транспортных услуг";
            this.grcOutputsDocuments_DeliveryPrice.Width = 70;
            // 
            // grcOutputsDocuments_DeliveryCurrencyName
            // 
            this.grcOutputsDocuments_DeliveryCurrencyName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DeliveryCurrencyName.DataPropertyName = "DeliveryCurrencyName";
            this.grcOutputsDocuments_DeliveryCurrencyName.HeaderText = "Вал.";
            this.grcOutputsDocuments_DeliveryCurrencyName.Name = "grcOutputsDocuments_DeliveryCurrencyName";
            this.grcOutputsDocuments_DeliveryCurrencyName.ReadOnly = true;
            this.grcOutputsDocuments_DeliveryCurrencyName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DeliveryCurrencyName.ToolTipText = "Валюта транспортных услуг";
            this.grcOutputsDocuments_DeliveryCurrencyName.Width = 40;
            // 
            // grcOutputsDocuments_ZoneName
            // 
            this.grcOutputsDocuments_ZoneName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_ZoneName.DataPropertyName = "ZoneName";
            this.grcOutputsDocuments_ZoneName.HeaderText = "Зона дост.";
            this.grcOutputsDocuments_ZoneName.Name = "grcOutputsDocuments_ZoneName";
            this.grcOutputsDocuments_ZoneName.ReadOnly = true;
            this.grcOutputsDocuments_ZoneName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_ZoneName.ToolTipText = "Зона доставки, в которой расположен клиент-получатель";
            this.grcOutputsDocuments_ZoneName.Width = 150;
            // 
            // grcOutputsDocuments_TripAlias
            // 
            this.grcOutputsDocuments_TripAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_TripAlias.DataPropertyName = "TripAlias";
            this.grcOutputsDocuments_TripAlias.HeaderText = "Описание рейса";
            this.grcOutputsDocuments_TripAlias.Name = "grcOutputsDocuments_TripAlias";
            this.grcOutputsDocuments_TripAlias.ReadOnly = true;
            this.grcOutputsDocuments_TripAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_TripAlias.Width = 250;
            // 
            // grcOutputsDocuments_Amount
            // 
            this.grcOutputsDocuments_Amount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_Amount.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            this.grcOutputsDocuments_Amount.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcOutputsDocuments_Amount.HeaderText = "Стоимость";
            this.grcOutputsDocuments_Amount.Name = "grcOutputsDocuments_Amount";
            this.grcOutputsDocuments_Amount.ReadOnly = true;
            this.grcOutputsDocuments_Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_Amount.Width = 80;
            // 
            // grcOutputsDocuments_Brutto
            // 
            this.grcOutputsDocuments_Brutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_Brutto.DataPropertyName = "Brutto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            this.grcOutputsDocuments_Brutto.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcOutputsDocuments_Brutto.HeaderText = "Брутто";
            this.grcOutputsDocuments_Brutto.Name = "grcOutputsDocuments_Brutto";
            this.grcOutputsDocuments_Brutto.ReadOnly = true;
            this.grcOutputsDocuments_Brutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_Brutto.ToolTipText = "Вес брутто заказанного товара, кг";
            this.grcOutputsDocuments_Brutto.Width = 70;
            // 
            // grcOutputsDocuments_PalletsQnt
            // 
            this.grcOutputsDocuments_PalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_PalletsQnt.DataPropertyName = "PalletsQnt";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = null;
            this.grcOutputsDocuments_PalletsQnt.DefaultCellStyle = dataGridViewCellStyle6;
            this.grcOutputsDocuments_PalletsQnt.HeaderText = "Паллет";
            this.grcOutputsDocuments_PalletsQnt.Name = "grcOutputsDocuments_PalletsQnt";
            this.grcOutputsDocuments_PalletsQnt.ReadOnly = true;
            this.grcOutputsDocuments_PalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_PalletsQnt.ToolTipText = "Количество паллет";
            this.grcOutputsDocuments_PalletsQnt.Width = 60;
            // 
            // grcOutputsDocuments_ManagerName
            // 
            this.grcOutputsDocuments_ManagerName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_ManagerName.DataPropertyName = "ManagerName";
            this.grcOutputsDocuments_ManagerName.HeaderText = "Менеджер";
            this.grcOutputsDocuments_ManagerName.Name = "grcOutputsDocuments_ManagerName";
            this.grcOutputsDocuments_ManagerName.ReadOnly = true;
            this.grcOutputsDocuments_ManagerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_ManagerName.Width = 150;
            // 
            // grcOutputsDocuments_ManagerPhone
            // 
            this.grcOutputsDocuments_ManagerPhone.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_ManagerPhone.DataPropertyName = "ManagerPhone";
            this.grcOutputsDocuments_ManagerPhone.HeaderText = "Тел.менеджера";
            this.grcOutputsDocuments_ManagerPhone.Name = "grcOutputsDocuments_ManagerPhone";
            this.grcOutputsDocuments_ManagerPhone.ReadOnly = true;
            this.grcOutputsDocuments_ManagerPhone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_ManagerPhone.ToolTipText = "Телефон менеджера";
            this.grcOutputsDocuments_ManagerPhone.Width = 150;
            // 
            // grcOutputsDocuments_DepartmentName
            // 
            this.grcOutputsDocuments_DepartmentName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DepartmentName.DataPropertyName = "DepartmentName";
            this.grcOutputsDocuments_DepartmentName.HeaderText = "Отдел";
            this.grcOutputsDocuments_DepartmentName.Name = "grcOutputsDocuments_DepartmentName";
            this.grcOutputsDocuments_DepartmentName.ReadOnly = true;
            this.grcOutputsDocuments_DepartmentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcOutputsDocuments_WarrantNeed
            // 
            this.grcOutputsDocuments_WarrantNeed.DataPropertyName = "PF_WarrantNeed";
            this.grcOutputsDocuments_WarrantNeed.HeaderText = "Дов.";
            this.grcOutputsDocuments_WarrantNeed.Name = "grcOutputsDocuments_WarrantNeed";
            this.grcOutputsDocuments_WarrantNeed.ReadOnly = true;
            this.grcOutputsDocuments_WarrantNeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_WarrantNeed.ToolTipText = "Требуется доверенность?";
            this.grcOutputsDocuments_WarrantNeed.Width = 40;
            // 
            // grcOutputsDocuments_FactureNeed
            // 
            this.grcOutputsDocuments_FactureNeed.DataPropertyName = "PF_FactureNeed";
            this.grcOutputsDocuments_FactureNeed.HeaderText = "СФ";
            this.grcOutputsDocuments_FactureNeed.Name = "grcOutputsDocuments_FactureNeed";
            this.grcOutputsDocuments_FactureNeed.ReadOnly = true;
            this.grcOutputsDocuments_FactureNeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_FactureNeed.ToolTipText = "Признак счета-фактуры";
            this.grcOutputsDocuments_FactureNeed.Width = 40;
            // 
            // grcOutputsDocuments_FactureNumber
            // 
            this.grcOutputsDocuments_FactureNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_FactureNumber.DataPropertyName = "FactureNumber";
            this.grcOutputsDocuments_FactureNumber.HeaderText = "№ СФ";
            this.grcOutputsDocuments_FactureNumber.Name = "grcOutputsDocuments_FactureNumber";
            this.grcOutputsDocuments_FactureNumber.ReadOnly = true;
            this.grcOutputsDocuments_FactureNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_FactureNumber.ToolTipText = "№ счета-фактуры";
            this.grcOutputsDocuments_FactureNumber.Width = 80;
            // 
            // grcOutputsDocuments_BillNumber
            // 
            this.grcOutputsDocuments_BillNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_BillNumber.DataPropertyName = "BillNumber";
            this.grcOutputsDocuments_BillNumber.HeaderText = "№ накл.";
            this.grcOutputsDocuments_BillNumber.Name = "grcOutputsDocuments_BillNumber";
            this.grcOutputsDocuments_BillNumber.ReadOnly = true;
            this.grcOutputsDocuments_BillNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_BillNumber.Width = 80;
            // 
            // grcOutputsDocuments_GetMoneyWished
            // 
            this.grcOutputsDocuments_GetMoneyWished.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_GetMoneyWished.DataPropertyName = "GetMoneyWished";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.grcOutputsDocuments_GetMoneyWished.DefaultCellStyle = dataGridViewCellStyle7;
            this.grcOutputsDocuments_GetMoneyWished.HeaderText = "Пол.денег";
            this.grcOutputsDocuments_GetMoneyWished.Name = "grcOutputsDocuments_GetMoneyWished";
            this.grcOutputsDocuments_GetMoneyWished.ReadOnly = true;
            this.grcOutputsDocuments_GetMoneyWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_GetMoneyWished.ToolTipText = "Получить денег";
            this.grcOutputsDocuments_GetMoneyWished.Width = 80;
            // 
            // grcOutputsDocuments_GetPalletsQntWished
            // 
            this.grcOutputsDocuments_GetPalletsQntWished.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_GetPalletsQntWished.DataPropertyName = "GetPalletsQntWished";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "N0";
            this.grcOutputsDocuments_GetPalletsQntWished.DefaultCellStyle = dataGridViewCellStyle8;
            this.grcOutputsDocuments_GetPalletsQntWished.HeaderText = "Пол.пал.";
            this.grcOutputsDocuments_GetPalletsQntWished.Name = "grcOutputsDocuments_GetPalletsQntWished";
            this.grcOutputsDocuments_GetPalletsQntWished.ReadOnly = true;
            this.grcOutputsDocuments_GetPalletsQntWished.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_GetPalletsQntWished.ToolTipText = "Получить паллет";
            this.grcOutputsDocuments_GetPalletsQntWished.Width = 60;
            // 
            // grcOutputsDocuments_Note
            // 
            this.grcOutputsDocuments_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_Note.DataPropertyName = "Note";
            this.grcOutputsDocuments_Note.HeaderText = "Примечание";
            this.grcOutputsDocuments_Note.Name = "grcOutputsDocuments_Note";
            this.grcOutputsDocuments_Note.ReadOnly = true;
            this.grcOutputsDocuments_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_Note.Width = 150;
            // 
            // grcOutputsDocuments_DeliveryAddress
            // 
            this.grcOutputsDocuments_DeliveryAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DeliveryAddress.DataPropertyName = "DeliveryAddress";
            this.grcOutputsDocuments_DeliveryAddress.HeaderText = "Адрес доставки";
            this.grcOutputsDocuments_DeliveryAddress.Name = "grcOutputsDocuments_DeliveryAddress";
            this.grcOutputsDocuments_DeliveryAddress.ReadOnly = true;
            this.grcOutputsDocuments_DeliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DeliveryAddress.Width = 300;
            // 
            // grcOutputsDocuments_DeliveryPassage
            // 
            this.grcOutputsDocuments_DeliveryPassage.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DeliveryPassage.DataPropertyName = "DeliveryPassage";
            this.grcOutputsDocuments_DeliveryPassage.HeaderText = "Проезд";
            this.grcOutputsDocuments_DeliveryPassage.Name = "grcOutputsDocuments_DeliveryPassage";
            this.grcOutputsDocuments_DeliveryPassage.ReadOnly = true;
            this.grcOutputsDocuments_DeliveryPassage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DeliveryPassage.Width = 300;
            // 
            // grcOutputsDocuments_NotForJoin
            // 
            this.grcOutputsDocuments_NotForJoin.DataPropertyName = "NotForJoin";
            this.grcOutputsDocuments_NotForJoin.HeaderText = "Не об.";
            this.grcOutputsDocuments_NotForJoin.Name = "grcOutputsDocuments_NotForJoin";
            this.grcOutputsDocuments_NotForJoin.ReadOnly = true;
            this.grcOutputsDocuments_NotForJoin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_NotForJoin.ToolTipText = "Не объединять с другими документами?";
            this.grcOutputsDocuments_NotForJoin.Width = 50;
            // 
            // grcOutputsDocuments_NoteExecute
            // 
            this.grcOutputsDocuments_NoteExecute.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_NoteExecute.DataPropertyName = "NoteExecute";
            this.grcOutputsDocuments_NoteExecute.HeaderText = "Примечание к вып.";
            this.grcOutputsDocuments_NoteExecute.Name = "grcOutputsDocuments_NoteExecute";
            this.grcOutputsDocuments_NoteExecute.ReadOnly = true;
            this.grcOutputsDocuments_NoteExecute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_NoteExecute.Width = 150;
            // 
            // grcOutputsDocuments_OutputDocumentFailReasonName
            // 
            this.grcOutputsDocuments_OutputDocumentFailReasonName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_OutputDocumentFailReasonName.DataPropertyName = "OutputDocumentFailReasonName";
            this.grcOutputsDocuments_OutputDocumentFailReasonName.HeaderText = "Не вып. по причине";
            this.grcOutputsDocuments_OutputDocumentFailReasonName.Name = "grcOutputsDocuments_OutputDocumentFailReasonName";
            this.grcOutputsDocuments_OutputDocumentFailReasonName.ReadOnly = true;
            this.grcOutputsDocuments_OutputDocumentFailReasonName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_OutputDocumentFailReasonName.ToolTipText = "Причина невыполнения";
            // 
            // grcOutputsDocuments_DateConfirm
            // 
            this.grcOutputsDocuments_DateConfirm.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DateConfirm.DataPropertyName = "DateConfirm";
            this.grcOutputsDocuments_DateConfirm.HeaderText = "Дата-время отгр.";
            this.grcOutputsDocuments_DateConfirm.Name = "grcOutputsDocuments_DateConfirm";
            this.grcOutputsDocuments_DateConfirm.ReadOnly = true;
            this.grcOutputsDocuments_DateConfirm.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DateConfirm.ToolTipText = "Дата-время регистрации отгрузки со склада";
            this.grcOutputsDocuments_DateConfirm.Width = 110;
            // 
            // grcOutputsDocuments_DateBring
            // 
            this.grcOutputsDocuments_DateBring.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_DateBring.DataPropertyName = "DateBring";
            this.grcOutputsDocuments_DateBring.HeaderText = "Дата-время дост.";
            this.grcOutputsDocuments_DateBring.Name = "grcOutputsDocuments_DateBring";
            this.grcOutputsDocuments_DateBring.ReadOnly = true;
            this.grcOutputsDocuments_DateBring.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_DateBring.ToolTipText = "Дата-время регистрации доставки товара";
            this.grcOutputsDocuments_DateBring.Width = 110;
            // 
            // grcOutputsDocuments_OutputDocumentTypeName
            // 
            this.grcOutputsDocuments_OutputDocumentTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_OutputDocumentTypeName.DataPropertyName = "OutputDocumentTypeName";
            this.grcOutputsDocuments_OutputDocumentTypeName.HeaderText = "Тип расх.документа";
            this.grcOutputsDocuments_OutputDocumentTypeName.Name = "grcOutputsDocuments_OutputDocumentTypeName";
            this.grcOutputsDocuments_OutputDocumentTypeName.ReadOnly = true;
            this.grcOutputsDocuments_OutputDocumentTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_OutputDocumentTypeName.ToolTipText = "Тип расходного документа";
            this.grcOutputsDocuments_OutputDocumentTypeName.Width = 150;
            // 
            // grcOutputsDocuments_ERPCode
            // 
            this.grcOutputsDocuments_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_ERPCode.DataPropertyName = "ERPCode";
            this.grcOutputsDocuments_ERPCode.HeaderText = "ERPCode";
            this.grcOutputsDocuments_ERPCode.Name = "grcOutputsDocuments_ERPCode";
            this.grcOutputsDocuments_ERPCode.ReadOnly = true;
            this.grcOutputsDocuments_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_ERPCode.ToolTipText = "Код в host-системе";
            // 
            // grcOutputsDocuments_ID
            // 
            this.grcOutputsDocuments_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOutputsDocuments_ID.DataPropertyName = "ID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcOutputsDocuments_ID.DefaultCellStyle = dataGridViewCellStyle9;
            this.grcOutputsDocuments_ID.HeaderText = "ID";
            this.grcOutputsDocuments_ID.Name = "grcOutputsDocuments_ID";
            this.grcOutputsDocuments_ID.ReadOnly = true;
            this.grcOutputsDocuments_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOutputsDocuments_ID.ToolTipText = "Код документа";
            this.grcOutputsDocuments_ID.Width = 90;
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
            this.dtrDates.Location = new System.Drawing.Point(62, 1);
            this.dtrDates.Name = "dtrDates";
            this.dtrDates.Size = new System.Drawing.Size(222, 29);
            this.dtrDates.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDate.Location = new System.Drawing.Point(5, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(54, 14);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Период:";
            // 
            // btnGo
            // 
            this.btnGo.Image = global::Logistics.Properties.Resources.Go;
            this.btnGo.Location = new System.Drawing.Point(697, 3);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(28, 28);
            this.btnGo.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnGo, "Получить список расходных документов");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // chkFactureNeedOnly
            // 
            this.chkFactureNeedOnly.AutoSize = true;
            this.chkFactureNeedOnly.Checked = true;
            this.chkFactureNeedOnly.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFactureNeedOnly.Location = new System.Drawing.Point(346, 8);
            this.chkFactureNeedOnly.Name = "chkFactureNeedOnly";
            this.chkFactureNeedOnly.Size = new System.Drawing.Size(154, 18);
            this.chkFactureNeedOnly.TabIndex = 4;
            this.chkFactureNeedOnly.Text = "только счета-фактуры";
            this.chkFactureNeedOnly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkFactureNeedOnly.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(654, 388);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печатать отчет (Excel)");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlTotal
            // 
            this.pnlTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTotal.Controls.Add(this.lblSumDeliveryPrice);
            this.pnlTotal.Controls.Add(this.lblSumDeliveryPriceLabel);
            this.pnlTotal.Location = new System.Drawing.Point(49, 388);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(299, 30);
            this.pnlTotal.TabIndex = 10;
            // 
            // lblSumDeliveryPrice
            // 
            this.lblSumDeliveryPrice.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblSumDeliveryPrice.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSumDeliveryPrice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSumDeliveryPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSumDeliveryPrice.Location = new System.Drawing.Point(186, 7);
            this.lblSumDeliveryPrice.Name = "lblSumDeliveryPrice";
            this.lblSumDeliveryPrice.Size = new System.Drawing.Size(107, 14);
            this.lblSumDeliveryPrice.TabIndex = 1;
            this.lblSumDeliveryPrice.Text = "#Sum#";
            // 
            // lblSumDeliveryPriceLabel
            // 
            this.lblSumDeliveryPriceLabel.AutoSize = true;
            this.lblSumDeliveryPriceLabel.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblSumDeliveryPriceLabel.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSumDeliveryPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSumDeliveryPriceLabel.Location = new System.Drawing.Point(4, 7);
            this.lblSumDeliveryPriceLabel.Name = "lblSumDeliveryPriceLabel";
            this.lblSumDeliveryPriceLabel.Size = new System.Drawing.Size(186, 14);
            this.lblSumDeliveryPriceLabel.TabIndex = 0;
            this.lblSumDeliveryPriceLabel.Text = "Сумма (транспортные услуги): ";
            // 
            // frmOutputsDocumentsDeliveryPrices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPrintFacture);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmOutputsDocumentsDeliveryPrices";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Транспортные услуги";
            this.Load += new System.EventHandler(this.frmOutputsDocumentsDeliveryPrices_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdOutputsDocuments)).EndInit();
            this.dtrDates.ResumeLayout(false);
            this.dtrDates.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnPrintFacture;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMCheckBox chkFactureNeedOnly;
		private RFMBaseClasses.RFMButton btnGo;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMPanel pnlTotal;
		private RFMBaseClasses.RFMLabel lblSumDeliveryPrice;
		private RFMBaseClasses.RFMLabel lblSumDeliveryPriceLabel;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMDataGridView grdOutputsDocuments;
		private RFMBaseClasses.RFMDataGridViewImageColumn grcOutputsDocuments_IsConfirmedImage;
		private RFMBaseClasses.RFMDataGridViewImageColumn grcOutputsDocuments_IsBroughtImage;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DateOutput;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_PartnerSourceName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_PartnerTargetName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DeliveryPrice;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DeliveryCurrencyName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_ZoneName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_TripAlias;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_Amount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_Brutto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_PalletsQnt;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_ManagerName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_ManagerPhone;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DepartmentName;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcOutputsDocuments_WarrantNeed;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcOutputsDocuments_FactureNeed;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_FactureNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_BillNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_GetMoneyWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_GetPalletsQntWished;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_Note;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DeliveryAddress;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DeliveryPassage;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcOutputsDocuments_NotForJoin;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_NoteExecute;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_OutputDocumentFailReasonName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DateConfirm;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_DateBring;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_OutputDocumentTypeName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_ERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOutputsDocuments_ID;

	}
}

