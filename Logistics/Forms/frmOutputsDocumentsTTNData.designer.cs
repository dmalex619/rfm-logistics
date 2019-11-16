namespace Logistics
{
	partial class frmOutputsDocumentsTTNData
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcConsigneeInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPayerGoodsInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPayerTransportInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcOrganizationInfo = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPointDischarge = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcReAddressing = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcStampNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcTrailerNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcDateOutput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcWeightText = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcBoxName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSBoxes = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSAmount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSVat = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcBillNumbersList = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grсIDList = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnPrint = new RFMBaseClasses.RFMButton();
            this.numCopies = new RFMBaseClasses.RFMNumericUpDown();
            this.lblCopies = new RFMBaseClasses.RFMLabel();
            this.pnlSelectConditions = new RFMBaseClasses.RFMPanel();
            this.pnlDeliveryNeed = new RFMBaseClasses.RFMPanel();
            this.optTransportBill_Plus1 = new RFMBaseClasses.RFMRadioButton();
            this.optPrintTTNOnly = new RFMBaseClasses.RFMRadioButton();
            this.optPrintTTNandTransportBill = new RFMBaseClasses.RFMRadioButton();
            this.optPrintTransportBillOnly = new RFMBaseClasses.RFMRadioButton();
            this.lblPrintForm = new RFMBaseClasses.RFMLabel();
            this.txtShipperInfo = new RFMBaseClasses.RFMTextBox();
            this.lblShipperInfo = new RFMBaseClasses.RFMLabel();
            this.lblPointCharge = new RFMBaseClasses.RFMLabel();
            this.txtPointCharge = new RFMBaseClasses.RFMTextBox();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            this.pnlSelectConditions.SuspendLayout();
            this.pnlDeliveryNeed.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 355);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(645, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.grdData);
            this.pnlData.Location = new System.Drawing.Point(4, 90);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(676, 260);
            this.pnlData.TabIndex = 1;
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
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcConsigneeInfo,
            this.grcPayerGoodsInfo,
            this.grcPayerTransportInfo,
            this.grcOrganizationInfo,
            this.grcPointDischarge,
            this.grcReAddressing,
            this.grcStampNumber,
            this.grcCarTypeName,
            this.grcCarName,
            this.grcCarNumber,
            this.grcTrailerNumber,
            this.grcDriverName,
            this.grcDateOutput,
            this.grcGoodName,
            this.grcWeightText,
            this.grcBoxName,
            this.grcSBoxes,
            this.grcSBrutto,
            this.grcSNetto,
            this.grcSAmount,
            this.grcSVat,
            this.grcBillNumbersList,
            this.grсIDList});
            this.grdData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grdData.IsCheckerInclude = true;
            this.grdData.IsConfigInclude = true;
            this.grdData.IsMarkedAll = false;
            this.grdData.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.grdData.Location = new System.Drawing.Point(1, 1);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdData.Size = new System.Drawing.Size(670, 254);
            this.grdData.TabIndex = 0;
            // 
            // grcConsigneeInfo
            // 
            this.grcConsigneeInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcConsigneeInfo.DataPropertyName = "ConsigneeInfo";
            this.grcConsigneeInfo.HeaderText = "I. Грузополучатель (название, адрес)";
            this.grcConsigneeInfo.Name = "grcConsigneeInfo";
            this.grcConsigneeInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcConsigneeInfo.ToolTipText = "(товарный раздел)";
            this.grcConsigneeInfo.Width = 350;
            // 
            // grcPayerGoodsInfo
            // 
            this.grcPayerGoodsInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPayerGoodsInfo.DataPropertyName = "PayerGoodsInfo";
            this.grcPayerGoodsInfo.HeaderText = "I. Плательщик - товар (название, адрес)";
            this.grcPayerGoodsInfo.Name = "grcPayerGoodsInfo";
            this.grcPayerGoodsInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPayerGoodsInfo.ToolTipText = "(товарный раздел)";
            this.grcPayerGoodsInfo.Width = 350;
            // 
            // grcPayerTransportInfo
            // 
            this.grcPayerTransportInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPayerTransportInfo.DataPropertyName = "PayerTransportInfo";
            this.grcPayerTransportInfo.HeaderText = "II. Плательщик - транспорт (название, адрес)";
            this.grcPayerTransportInfo.Name = "grcPayerTransportInfo";
            this.grcPayerTransportInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPayerTransportInfo.ToolTipText = "(транспортный раздел)";
            this.grcPayerTransportInfo.Width = 350;
            // 
            // grcOrganizationInfo
            // 
            this.grcOrganizationInfo.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcOrganizationInfo.DataPropertyName = "OrganizationInfo";
            this.grcOrganizationInfo.HeaderText = "II. Организация";
            this.grcOrganizationInfo.Name = "grcOrganizationInfo";
            this.grcOrganizationInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcOrganizationInfo.ToolTipText = "(транспортный раздел)";
            this.grcOrganizationInfo.Width = 300;
            // 
            // grcPointDischarge
            // 
            this.grcPointDischarge.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPointDischarge.DataPropertyName = "PointDischarge";
            this.grcPointDischarge.HeaderText = "Пункт разгрузки";
            this.grcPointDischarge.Name = "grcPointDischarge";
            this.grcPointDischarge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPointDischarge.Width = 200;
            // 
            // grcReAddressing
            // 
            this.grcReAddressing.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcReAddressing.DataPropertyName = "ReAddressing";
            this.grcReAddressing.HeaderText = "Переадресовка";
            this.grcReAddressing.Name = "grcReAddressing";
            this.grcReAddressing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grcReAddressing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcReAddressing.ToolTipText = "(транспортный раздел)";
            this.grcReAddressing.Width = 350;
            // 
            // grcStampNumber
            // 
            this.grcStampNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcStampNumber.DataPropertyName = "StampNumber";
            this.grcStampNumber.HeaderText = "№ пломбы";
            this.grcStampNumber.Name = "grcStampNumber";
            this.grcStampNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcCarTypeName
            // 
            this.grcCarTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCarTypeName.DataPropertyName = "CarTypeName";
            this.grcCarTypeName.HeaderText = "Машина (марка)";
            this.grcCarTypeName.Name = "grcCarTypeName";
            this.grcCarTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCarTypeName.Width = 120;
            // 
            // grcCarName
            // 
            this.grcCarName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCarName.DataPropertyName = "CarName";
            this.grcCarName.HeaderText = "Машина (внутр.название)";
            this.grcCarName.Name = "grcCarName";
            this.grcCarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCarName.Visible = false;
            // 
            // grcCarNumber
            // 
            this.grcCarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCarNumber.DataPropertyName = "CarNumber";
            this.grcCarNumber.HeaderText = "Машина (номер)";
            this.grcCarNumber.Name = "grcCarNumber";
            this.grcCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcCarNumber.Width = 120;
            // 
            // grcTrailerNumber
            // 
            this.grcTrailerNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcTrailerNumber.DataPropertyName = "TrailerNumber";
            this.grcTrailerNumber.HeaderText = "Прицеп (номер)";
            this.grcTrailerNumber.Name = "grcTrailerNumber";
            this.grcTrailerNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcTrailerNumber.Width = 120;
            // 
            // grcDriverName
            // 
            this.grcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDriverName.DataPropertyName = "DriverName";
            this.grcDriverName.HeaderText = "Водитель";
            this.grcDriverName.Name = "grcDriverName";
            this.grcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDriverName.Width = 120;
            // 
            // grcDateOutput
            // 
            this.grcDateOutput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcDateOutput.DataPropertyName = "DateOutput";
            dataGridViewCellStyle9.Format = "dd.MM.yyyy";
            this.grcDateOutput.DefaultCellStyle = dataGridViewCellStyle9;
            this.grcDateOutput.HeaderText = "Дата доставки";
            this.grcDateOutput.Name = "grcDateOutput";
            this.grcDateOutput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcDateOutput.Width = 72;
            // 
            // grcGoodName
            // 
            this.grcGoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodName.DataPropertyName = "GoodName";
            this.grcGoodName.HeaderText = "Груз, товар";
            this.grcGoodName.Name = "grcGoodName";
            this.grcGoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodName.ToolTipText = "Краткое наименование груза, товара";
            this.grcGoodName.Width = 200;
            // 
            // grcWeightText
            // 
            this.grcWeightText.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcWeightText.DataPropertyName = "WeightText";
            this.grcWeightText.HeaderText = "Шт./кг";
            this.grcWeightText.Name = "grcWeightText";
            this.grcWeightText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcWeightText.ToolTipText = "Единица измерения (штук/кг)";
            this.grcWeightText.Width = 50;
            // 
            // grcBoxName
            // 
            this.grcBoxName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcBoxName.DataPropertyName = "BoxName";
            this.grcBoxName.HeaderText = "Упак.";
            this.grcBoxName.Name = "grcBoxName";
            this.grcBoxName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcBoxName.ToolTipText = "Вид упаковки";
            this.grcBoxName.Width = 50;
            // 
            // grcSBoxes
            // 
            this.grcSBoxes.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSBoxes.DataPropertyName = "SBoxes";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "#####0";
            this.grcSBoxes.DefaultCellStyle = dataGridViewCellStyle10;
            this.grcSBoxes.HeaderText = "Мест";
            this.grcSBoxes.Name = "grcSBoxes";
            this.grcSBoxes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSBoxes.Width = 60;
            // 
            // grcSBrutto
            // 
            this.grcSBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSBrutto.DataPropertyName = "SBrutto";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "#####0.000";
            this.grcSBrutto.DefaultCellStyle = dataGridViewCellStyle11;
            this.grcSBrutto.HeaderText = "Брутто";
            this.grcSBrutto.Name = "grcSBrutto";
            this.grcSBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSBrutto.Width = 80;
            // 
            // grcSNetto
            // 
            this.grcSNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSNetto.DataPropertyName = "SNetto";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "#####0.000";
            this.grcSNetto.DefaultCellStyle = dataGridViewCellStyle12;
            this.grcSNetto.HeaderText = "Нетто";
            this.grcSNetto.Name = "grcSNetto";
            this.grcSNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSNetto.Width = 80;
            // 
            // grcSAmount
            // 
            this.grcSAmount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSAmount.DataPropertyName = "SAmount";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "########0.00";
            this.grcSAmount.DefaultCellStyle = dataGridViewCellStyle13;
            this.grcSAmount.HeaderText = "Сумма";
            this.grcSAmount.Name = "grcSAmount";
            this.grcSAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSAmount.Width = 70;
            // 
            // grcSVat
            // 
            this.grcSVat.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSVat.DataPropertyName = "SVat";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "#######0.00";
            this.grcSVat.DefaultCellStyle = dataGridViewCellStyle14;
            this.grcSVat.HeaderText = "НДС";
            this.grcSVat.Name = "grcSVat";
            this.grcSVat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSVat.Width = 70;
            // 
            // grcBillNumbersList
            // 
            this.grcBillNumbersList.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcBillNumbersList.DataPropertyName = "BillNumbersList";
            this.grcBillNumbersList.HeaderText = "Накладные";
            this.grcBillNumbersList.Name = "grcBillNumbersList";
            this.grcBillNumbersList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcBillNumbersList.ToolTipText = "Список накладных (номер, дата)";
            this.grcBillNumbersList.Width = 120;
            // 
            // grсIDList
            // 
            this.grсIDList.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grсIDList.DataPropertyName = "IDList";
            this.grсIDList.HeaderText = "Коды";
            this.grсIDList.Name = "grсIDList";
            this.grсIDList.ReadOnly = true;
            this.grсIDList.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grсIDList.ToolTipText = "Список кодов заказов (расходных документов)";
            this.grсIDList.Width = 70;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
            this.btnPrint.Location = new System.Drawing.Point(589, 354);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 30);
            this.btnPrint.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnPrint, "Печатать");
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // numCopies
            // 
            this.numCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numCopies.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numCopies.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numCopies.InputMask = "#########";
            this.numCopies.IsNull = false;
            this.numCopies.Location = new System.Drawing.Point(519, 359);
            this.numCopies.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numCopies.Name = "numCopies";
            this.numCopies.RealPlaces = 9;
            this.numCopies.Size = new System.Drawing.Size(47, 22);
            this.numCopies.TabIndex = 1;
            this.numCopies.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCopies.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblCopies
            // 
            this.lblCopies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopies.AutoSize = true;
            this.lblCopies.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCopies.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCopies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCopies.Location = new System.Drawing.Point(471, 363);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(42, 14);
            this.lblCopies.TabIndex = 0;
            this.lblCopies.Text = "Копий";
            // 
            // pnlSelectConditions
            // 
            this.pnlSelectConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSelectConditions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSelectConditions.Controls.Add(this.pnlDeliveryNeed);
            this.pnlSelectConditions.Controls.Add(this.lblPrintForm);
            this.pnlSelectConditions.Controls.Add(this.txtShipperInfo);
            this.pnlSelectConditions.Controls.Add(this.lblShipperInfo);
            this.pnlSelectConditions.Controls.Add(this.lblPointCharge);
            this.pnlSelectConditions.Controls.Add(this.txtPointCharge);
            this.pnlSelectConditions.Location = new System.Drawing.Point(5, 4);
            this.pnlSelectConditions.Name = "pnlSelectConditions";
            this.pnlSelectConditions.Size = new System.Drawing.Size(675, 80);
            this.pnlSelectConditions.TabIndex = 5;
            // 
            // pnlDeliveryNeed
            // 
            this.pnlDeliveryNeed.Controls.Add(this.optTransportBill_Plus1);
            this.pnlDeliveryNeed.Controls.Add(this.optPrintTTNOnly);
            this.pnlDeliveryNeed.Controls.Add(this.optPrintTTNandTransportBill);
            this.pnlDeliveryNeed.Controls.Add(this.optPrintTransportBillOnly);
            this.pnlDeliveryNeed.Location = new System.Drawing.Point(112, 47);
            this.pnlDeliveryNeed.Name = "pnlDeliveryNeed";
            this.pnlDeliveryNeed.Size = new System.Drawing.Size(556, 25);
            this.pnlDeliveryNeed.TabIndex = 5;
            // 
            // optTransportBill_Plus1
            // 
            this.optTransportBill_Plus1.AutoSize = true;
            this.optTransportBill_Plus1.Location = new System.Drawing.Point(395, 4);
            this.optTransportBill_Plus1.Name = "optTransportBill_Plus1";
            this.optTransportBill_Plus1.Size = new System.Drawing.Size(71, 18);
            this.optTransportBill_Plus1.TabIndex = 3;
            this.optTransportBill_Plus1.Text = "ТрН + 1";
            this.ttToolTip.SetToolTip(this.optTransportBill_Plus1, "Транспортные накладные + 1 общая (через перевозчика)");
            this.optTransportBill_Plus1.UseVisualStyleBackColor = true;
            // 
            // optPrintTTNOnly
            // 
            this.optPrintTTNOnly.AutoSize = true;
            this.optPrintTTNOnly.Checked = true;
            this.optPrintTTNOnly.IsChanged = true;
            this.optPrintTTNOnly.Location = new System.Drawing.Point(4, 4);
            this.optPrintTTNOnly.Name = "optPrintTTNOnly";
            this.optPrintTTNOnly.Size = new System.Drawing.Size(92, 18);
            this.optPrintTTNOnly.TabIndex = 0;
            this.optPrintTTNOnly.TabStop = true;
            this.optPrintTTNOnly.Text = "только ТТН";
            this.ttToolTip.SetToolTip(this.optPrintTTNOnly, "Только товарно-транспортные накладные (форма № 1-Т)");
            this.optPrintTTNOnly.UseVisualStyleBackColor = true;
            // 
            // optPrintTTNandTransportBill
            // 
            this.optPrintTTNandTransportBill.AutoSize = true;
            this.optPrintTTNandTransportBill.Location = new System.Drawing.Point(267, 4);
            this.optPrintTTNandTransportBill.Name = "optPrintTTNandTransportBill";
            this.optPrintTTNandTransportBill.Size = new System.Drawing.Size(88, 18);
            this.optPrintTTNandTransportBill.TabIndex = 2;
            this.optPrintTTNandTransportBill.Text = "ТТН + ТрН";
            this.ttToolTip.SetToolTip(this.optPrintTTNandTransportBill, "Товарно-транспортные и транспортные накладные");
            this.optPrintTTNandTransportBill.UseVisualStyleBackColor = true;
            // 
            // optPrintTransportBillOnly
            // 
            this.optPrintTransportBillOnly.AutoSize = true;
            this.optPrintTransportBillOnly.IsChanged = true;
            this.optPrintTransportBillOnly.Location = new System.Drawing.Point(136, 4);
            this.optPrintTransportBillOnly.Name = "optPrintTransportBillOnly";
            this.optPrintTransportBillOnly.Size = new System.Drawing.Size(91, 18);
            this.optPrintTransportBillOnly.TabIndex = 1;
            this.optPrintTransportBillOnly.Text = "только ТрН";
            this.ttToolTip.SetToolTip(this.optPrintTransportBillOnly, "Только транспортные накладные (приложение № 4)");
            this.optPrintTransportBillOnly.UseVisualStyleBackColor = true;
            // 
            // lblPrintForm
            // 
            this.lblPrintForm.AutoSize = true;
            this.lblPrintForm.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPrintForm.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPrintForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrintForm.Location = new System.Drawing.Point(2, 52);
            this.lblPrintForm.Name = "lblPrintForm";
            this.lblPrintForm.Size = new System.Drawing.Size(59, 14);
            this.lblPrintForm.TabIndex = 4;
            this.lblPrintForm.Text = "Печатать";
            // 
            // txtShipperInfo
            // 
            this.txtShipperInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShipperInfo.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtShipperInfo.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtShipperInfo.Location = new System.Drawing.Point(112, 1);
            this.txtShipperInfo.MaxLength = 500;
            this.txtShipperInfo.Name = "txtShipperInfo";
            this.txtShipperInfo.Size = new System.Drawing.Size(557, 22);
            this.txtShipperInfo.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.txtShipperInfo, "I. Грузоотправитель (название, адрес)");
            this.txtShipperInfo.Visible = false;
            // 
            // lblShipperInfo
            // 
            this.lblShipperInfo.AutoSize = true;
            this.lblShipperInfo.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblShipperInfo.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblShipperInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShipperInfo.Location = new System.Drawing.Point(2, 4);
            this.lblShipperInfo.Name = "lblShipperInfo";
            this.lblShipperInfo.Size = new System.Drawing.Size(110, 14);
            this.lblShipperInfo.TabIndex = 0;
            this.lblShipperInfo.Text = "Грузоотправитель";
            // 
            // lblPointCharge
            // 
            this.lblPointCharge.AutoSize = true;
            this.lblPointCharge.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPointCharge.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPointCharge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPointCharge.Location = new System.Drawing.Point(2, 27);
            this.lblPointCharge.Name = "lblPointCharge";
            this.lblPointCharge.Size = new System.Drawing.Size(94, 14);
            this.lblPointCharge.TabIndex = 2;
            this.lblPointCharge.Text = "Пункт погрузки";
            // 
            // txtPointCharge
            // 
            this.txtPointCharge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPointCharge.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPointCharge.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPointCharge.Location = new System.Drawing.Point(112, 24);
            this.txtPointCharge.MaxLength = 500;
            this.txtPointCharge.Name = "txtPointCharge";
            this.txtPointCharge.Size = new System.Drawing.Size(557, 22);
            this.txtPointCharge.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.txtPointCharge, "Примечание по заказу");
            // 
            // frmOutputsDocumentsTTNData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 391);
            this.Controls.Add(this.pnlSelectConditions);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.numCopies);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmOutputsDocumentsTTNData";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расходные документы - бланки ТТН";
            this.Load += new System.EventHandler(this.frmOutputsDocumentsTTNData_Load);
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            this.pnlSelectConditions.ResumeLayout(false);
            this.pnlSelectConditions.PerformLayout();
            this.pnlDeliveryNeed.ResumeLayout(false);
            this.pnlDeliveryNeed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMNumericUpDown numCopies;
		private RFMBaseClasses.RFMLabel lblCopies;
		private RFMBaseClasses.RFMPanel pnlSelectConditions;
		private RFMBaseClasses.RFMTextBox txtShipperInfo;
		private RFMBaseClasses.RFMLabel lblShipperInfo;
		private RFMBaseClasses.RFMLabel lblPointCharge;
		private RFMBaseClasses.RFMTextBox txtPointCharge;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcConsigneeInfo;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPayerGoodsInfo;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPayerTransportInfo;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcOrganizationInfo;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPointDischarge;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcReAddressing;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcStampNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarTypeName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTrailerNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateOutput;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWeightText;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcBoxName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSBoxes;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSBrutto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSNetto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSAmount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSVat;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcBillNumbersList;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grсIDList;
        private RFMBaseClasses.RFMLabel lblPrintForm;
        private RFMBaseClasses.RFMPanel pnlDeliveryNeed;
        private RFMBaseClasses.RFMRadioButton optPrintTTNOnly;
        private RFMBaseClasses.RFMRadioButton optPrintTTNandTransportBill;
        private RFMBaseClasses.RFMRadioButton optPrintTransportBillOnly;
        private RFMBaseClasses.RFMRadioButton optTransportBill_Plus1;
    }
}

