namespace Logistics
{
	partial class frmPartnersGoodsEdit
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
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.chkSP_Vat = new RFMBaseClasses.RFMCheckBox();
            this.btnEdit = new RFMBaseClasses.RFMButton();
            this.btnByOrder = new RFMBaseClasses.RFMButton();
            this.btnDeleteGood = new RFMBaseClasses.RFMButton();
            this.btnAddGood = new RFMBaseClasses.RFMButton();
            this.grdData = new RFMBaseClasses.RFMDataGridView();
            this.grcSP_GoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSP_GoodCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSP_SupplierCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSP_Articul = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSP_Vat = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodAlias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodBarCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcInBox = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcWeighting = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcArticul = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.gr�GoodName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcRetention = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcNetto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodGroupName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodBrandName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcCountryName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodActual = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
            this.grcGoodERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcGoodID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcPackingID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.grcSP_ByOrder = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.mnuEdit = new RFMBaseClasses.RFMContextMenuStrip();
            this.mniGoodNameFull = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.mniGoodNameClear = new RFMBaseClasses.RFMContextToolStripMenuItem();
            this.mniGoodVatFull = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGoodVatClear = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.mnuEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(6, 388);
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
            this.btnExit.Location = new System.Drawing.Point(705, 388);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnExit, "�����");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(655, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnSave, "���������");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.chkSP_Vat);
            this.pnlData.Controls.Add(this.btnEdit);
            this.pnlData.Controls.Add(this.btnByOrder);
            this.pnlData.Controls.Add(this.btnDeleteGood);
            this.pnlData.Controls.Add(this.btnAddGood);
            this.pnlData.Controls.Add(this.grdData);
            this.pnlData.Location = new System.Drawing.Point(3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(736, 377);
            this.pnlData.TabIndex = 1;
            // 
            // chkSP_Vat
            // 
            this.chkSP_Vat.AutoSize = true;
            this.chkSP_Vat.Location = new System.Drawing.Point(14, 347);
            this.chkSP_Vat.Name = "chkSP_Vat";
            this.chkSP_Vat.Size = new System.Drawing.Size(225, 18);
            this.chkSP_Vat.TabIndex = 21;
            this.chkSP_Vat.Text = "�������� ����������� ������ ���";
            this.chkSP_Vat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkSP_Vat.UseVisualStyleBackColor = true;
            this.chkSP_Vat.Visible = false;
            this.chkSP_Vat.CheckedChanged += new System.EventHandler(this.chkSP_Vat_CheckedChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(647, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(32, 30);
            this.btnEdit.TabIndex = 19;
            this.ttToolTip.SetToolTip(this.btnEdit, "�������� ����������� ������� ���������� �������");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnByOrder
            // 
            this.btnByOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnByOrder.Image = global::Logistics.Properties.Resources.Sort;
            this.btnByOrder.Location = new System.Drawing.Point(697, 340);
            this.btnByOrder.Name = "btnByOrder";
            this.btnByOrder.Size = new System.Drawing.Size(32, 30);
            this.btnByOrder.TabIndex = 20;
            this.ttToolTip.SetToolTip(this.btnByOrder, "�������� ����������� ������� ���������� �������");
            this.btnByOrder.UseVisualStyleBackColor = true;
            this.btnByOrder.Click += new System.EventHandler(this.btnByOrder_Click);
            // 
            // btnDeleteGood
            // 
            this.btnDeleteGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteGood.Image = global::Logistics.Properties.Resources.Delete;
            this.btnDeleteGood.Location = new System.Drawing.Point(597, 340);
            this.btnDeleteGood.Name = "btnDeleteGood";
            this.btnDeleteGood.Size = new System.Drawing.Size(32, 30);
            this.btnDeleteGood.TabIndex = 18;
            this.ttToolTip.SetToolTip(this.btnDeleteGood, "������� ����� �� ������");
            this.btnDeleteGood.UseVisualStyleBackColor = true;
            this.btnDeleteGood.Click += new System.EventHandler(this.btnDeleteGood_Click);
            // 
            // btnAddGood
            // 
            this.btnAddGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddGood.Image = global::Logistics.Properties.Resources.Add;
            this.btnAddGood.Location = new System.Drawing.Point(547, 340);
            this.btnAddGood.Name = "btnAddGood";
            this.btnAddGood.Size = new System.Drawing.Size(32, 30);
            this.btnAddGood.TabIndex = 17;
            this.ttToolTip.SetToolTip(this.btnAddGood, "�������� ����� � ������");
            this.btnAddGood.UseVisualStyleBackColor = true;
            this.btnAddGood.Click += new System.EventHandler(this.btnAddGood_Click);
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
            this.grcSP_GoodName,
            this.grcSP_GoodCode,
            this.grcSP_SupplierCode,
            this.grcSP_Articul,
            this.grcSP_Vat,
            this.grcGoodAlias,
            this.grcGoodBarCode,
            this.grcInBox,
            this.grcWeighting,
            this.grcArticul,
            this.gr�GoodName,
            this.grcRetention,
            this.grcNetto,
            this.grcBrutto,
            this.grcGoodGroupName,
            this.grcGoodBrandName,
            this.grcCountryName,
            this.grcGoodActual,
            this.grcGoodERPCode,
            this.grcGoodID,
            this.grcPackingID,
            this.grcSP_ByOrder});
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
            this.grdData.Location = new System.Drawing.Point(2, 3);
            this.grdData.MultiSelect = false;
            this.grdData.Name = "grdData";
            this.grdData.RangedWay = ' ';
            this.grdData.RowHeadersWidth = 24;
            this.grdData.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.grdData.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.grdData.Size = new System.Drawing.Size(729, 332);
            this.grdData.TabIndex = 20;
            this.grdData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdData_CellFormatting);
            this.grdData.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellValidated);
            // 
            // grcSP_GoodName
            // 
            this.grcSP_GoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSP_GoodName.DataPropertyName = "SP_GoodName";
            this.grcSP_GoodName.HeaderText = "��������";
            this.grcSP_GoodName.Name = "grcSP_GoodName";
            this.grcSP_GoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSP_GoodName.ToolTipText = "����������� �������� ������";
            this.grcSP_GoodName.Width = 250;
            // 
            // grcSP_GoodCode
            // 
            this.grcSP_GoodCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSP_GoodCode.DataPropertyName = "SP_GoodCode";
            this.grcSP_GoodCode.HeaderText = "���";
            this.grcSP_GoodCode.Name = "grcSP_GoodCode";
            this.grcSP_GoodCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSP_GoodCode.ToolTipText = "����������� ��� ������";
            this.grcSP_GoodCode.Width = 60;
            // 
            // grcSP_SupplierCode
            // 
            this.grcSP_SupplierCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSP_SupplierCode.DataPropertyName = "SP_SupplierCode";
            this.grcSP_SupplierCode.HeaderText = "��� �������.";
            this.grcSP_SupplierCode.Name = "grcSP_SupplierCode";
            this.grcSP_SupplierCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSP_SupplierCode.ToolTipText = "����������� ��� ����������";
            this.grcSP_SupplierCode.Width = 90;
            // 
            // grcSP_Articul
            // 
            this.grcSP_Articul.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSP_Articul.DataPropertyName = "SP_Articul";
            this.grcSP_Articul.HeaderText = "�������";
            this.grcSP_Articul.Name = "grcSP_Articul";
            this.grcSP_Articul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcSP_Vat
            // 
            this.grcSP_Vat.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSP_Vat.DataPropertyName = "SP_Vat";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "##";
            this.grcSP_Vat.DefaultCellStyle = dataGridViewCellStyle2;
            this.grcSP_Vat.HeaderText = "��� %";
            this.grcSP_Vat.Name = "grcSP_Vat";
            this.grcSP_Vat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSP_Vat.ToolTipText = "������ ��� (0..100), %";
            this.grcSP_Vat.Width = 52;
            // 
            // grcGoodAlias
            // 
            this.grcGoodAlias.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodAlias.DataPropertyName = "GoodAlias";
            this.grcGoodAlias.HeaderText = "������������ �������";
            this.grcGoodAlias.Name = "grcGoodAlias";
            this.grcGoodAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodAlias.Width = 250;
            // 
            // grcGoodBarCode
            // 
            this.grcGoodBarCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodBarCode.DataPropertyName = "GoodBarCode";
            this.grcGoodBarCode.HeaderText = "�����-��� ������";
            this.grcGoodBarCode.Name = "grcGoodBarCode";
            this.grcGoodBarCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodBarCode.Width = 130;
            // 
            // grcInBox
            // 
            this.grcInBox.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcInBox.DataPropertyName = "InBox";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcInBox.DefaultCellStyle = dataGridViewCellStyle3;
            this.grcInBox.HeaderText = "� ���.";
            this.grcInBox.Name = "grcInBox";
            this.grcInBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcInBox.Width = 60;
            // 
            // grcWeighting
            // 
            this.grcWeighting.DataPropertyName = "Weighting";
            this.grcWeighting.HeaderText = "���";
            this.grcWeighting.Name = "grcWeighting";
            this.grcWeighting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcWeighting.ToolTipText = "������� �����?";
            this.grcWeighting.Width = 40;
            // 
            // grcArticul
            // 
            this.grcArticul.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcArticul.DataPropertyName = "Articul";
            this.grcArticul.HeaderText = "�������";
            this.grcArticul.Name = "grcArticul";
            this.grcArticul.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // gr�GoodName
            // 
            this.gr�GoodName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.gr�GoodName.DataPropertyName = "GoodName";
            this.gr�GoodName.HeaderText = "������������ ������";
            this.gr�GoodName.Name = "gr�GoodName";
            this.gr�GoodName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.gr�GoodName.Width = 250;
            // 
            // grcRetention
            // 
            this.grcRetention.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcRetention.DataPropertyName = "Retention";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            this.grcRetention.DefaultCellStyle = dataGridViewCellStyle4;
            this.grcRetention.HeaderText = "���� ����.";
            this.grcRetention.Name = "grcRetention";
            this.grcRetention.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcRetention.ToolTipText = "���� ��������, ����";
            this.grcRetention.Width = 80;
            // 
            // grcNetto
            // 
            this.grcNetto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcNetto.DataPropertyName = "Netto";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N3";
            this.grcNetto.DefaultCellStyle = dataGridViewCellStyle5;
            this.grcNetto.HeaderText = "�����";
            this.grcNetto.Name = "grcNetto";
            this.grcNetto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcNetto.ToolTipText = "��� ����� ������� ������, ��";
            this.grcNetto.Width = 60;
            // 
            // grcBrutto
            // 
            this.grcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcBrutto.DataPropertyName = "Brutto";
            this.grcBrutto.HeaderText = "������";
            this.grcBrutto.Name = "grcBrutto";
            this.grcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcBrutto.ToolTipText = "��� ������ ������� ������, ��";
            this.grcBrutto.Width = 60;
            // 
            // grcGoodGroupName
            // 
            this.grcGoodGroupName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodGroupName.DataPropertyName = "GoodGroupName";
            this.grcGoodGroupName.HeaderText = "�������� ������";
            this.grcGoodGroupName.Name = "grcGoodGroupName";
            this.grcGoodGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodGroupName.Width = 150;
            // 
            // grcGoodBrandName
            // 
            this.grcGoodBrandName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodBrandName.DataPropertyName = "GoodBrandName";
            this.grcGoodBrandName.HeaderText = "�������� �����";
            this.grcGoodBrandName.Name = "grcGoodBrandName";
            this.grcGoodBrandName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodBrandName.Width = 150;
            // 
            // grcCountryName
            // 
            this.grcCountryName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcCountryName.DataPropertyName = "CountryName";
            this.grcCountryName.HeaderText = "������";
            this.grcCountryName.Name = "grcCountryName";
            this.grcCountryName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // grcGoodActual
            // 
            this.grcGoodActual.DataPropertyName = "GoodActual";
            this.grcGoodActual.HeaderText = "���.�����";
            this.grcGoodActual.Name = "grcGoodActual";
            this.grcGoodActual.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodActual.ToolTipText = "����� ��������?";
            this.grcGoodActual.Width = 45;
            // 
            // grcGoodERPCode
            // 
            this.grcGoodERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodERPCode.DataPropertyName = "GoodERPCode";
            this.grcGoodERPCode.HeaderText = "ERPCode �����";
            this.grcGoodERPCode.Name = "grcGoodERPCode";
            this.grcGoodERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodERPCode.ToolTipText = "��� ������ � host-�������";
            // 
            // grcGoodID
            // 
            this.grcGoodID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcGoodID.DataPropertyName = "GoodID";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.grcGoodID.DefaultCellStyle = dataGridViewCellStyle6;
            this.grcGoodID.HeaderText = "ID �����";
            this.grcGoodID.Name = "grcGoodID";
            this.grcGoodID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcGoodID.ToolTipText = "��� ������";
            this.grcGoodID.Width = 70;
            // 
            // grcPackingID
            // 
            this.grcPackingID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcPackingID.DataPropertyName = "PackingID";
            this.grcPackingID.HeaderText = "ID ����.";
            this.grcPackingID.Name = "grcPackingID";
            this.grcPackingID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcPackingID.ToolTipText = "��� ��������";
            this.grcPackingID.Width = 70;
            // 
            // grcSP_ByOrder
            // 
            this.grcSP_ByOrder.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.grcSP_ByOrder.DataPropertyName = "SP_ByOrder";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "######";
            this.grcSP_ByOrder.DefaultCellStyle = dataGridViewCellStyle7;
            this.grcSP_ByOrder.HeaderText = "� �/�";
            this.grcSP_ByOrder.Name = "grcSP_ByOrder";
            this.grcSP_ByOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.grcSP_ByOrder.ToolTipText = "����������� ������� �������";
            this.grcSP_ByOrder.Width = 50;
            // 
            // mnuEdit
            // 
            this.mnuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniGoodNameFull,
            this.mniGoodNameClear,
            this.mniGoodVatFull,
            this.mniGoodVatClear});
            this.mnuEdit.Name = "mnuPrint";
            this.mnuEdit.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mnuEdit.ShowImageMargin = false;
            this.mnuEdit.Size = new System.Drawing.Size(234, 92);
            // 
            // mniGoodNameFull
            // 
            this.mniGoodNameFull.Name = "mniGoodNameFull";
            this.mniGoodNameFull.Size = new System.Drawing.Size(233, 22);
            this.mniGoodNameFull.Text = "��������� �������� �������";
            this.mniGoodNameFull.Click += new System.EventHandler(this.mniGoodNameFull_Click);
            // 
            // mniGoodNameClear
            // 
            this.mniGoodNameClear.Name = "mniGoodNameClear";
            this.mniGoodNameClear.Size = new System.Drawing.Size(233, 22);
            this.mniGoodNameClear.Text = "�������� �������� �������";
            this.mniGoodNameClear.Click += new System.EventHandler(this.mniGoodNameClear_Click);
            // 
            // mniGoodVatFull
            // 
            this.mniGoodVatFull.Name = "mniGoodVatFull";
            this.mniGoodVatFull.Size = new System.Drawing.Size(233, 22);
            this.mniGoodVatFull.Text = "��������� ���";
            this.mniGoodVatFull.Visible = false;
            this.mniGoodVatFull.Click += new System.EventHandler(this.mniGoodVatFull_Click);
            // 
            // mniGoodVatClear
            // 
            this.mniGoodVatClear.Name = "mniGoodVatClear";
            this.mniGoodVatClear.Size = new System.Drawing.Size(233, 22);
            this.mniGoodVatClear.Text = "�������� ���";
            this.mniGoodVatClear.Visible = false;
            this.mniGoodVatClear.Click += new System.EventHandler(this.mniGoodVatClear_Click);
            // 
            // frmPartnersGoodsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 423);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmPartnersGoodsEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "����������� ������ � ������� ��� �������";
            this.Load += new System.EventHandler(this.frmPartnersGoodsEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.mnuEdit.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMButton btnDeleteGood;
		private RFMBaseClasses.RFMButton btnByOrder;
		private RFMBaseClasses.RFMButton btnAddGood;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMContextMenuStrip mnuEdit;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniGoodNameFull;
		private System.Windows.Forms.ToolStripMenuItem mniGoodVatFull;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniGoodNameClear;
        private System.Windows.Forms.ToolStripMenuItem mniGoodVatClear;
        private RFMBaseClasses.RFMCheckBox chkSP_Vat;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSP_GoodName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSP_GoodCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSP_SupplierCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSP_Articul;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSP_Vat;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodAlias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodBarCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcInBox;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcWeighting;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcArticul;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn gr�GoodName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcRetention;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcNetto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcBrutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodGroupName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodBrandName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCountryName;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcGoodActual;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcGoodID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPackingID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcSP_ByOrder;

	}
}

