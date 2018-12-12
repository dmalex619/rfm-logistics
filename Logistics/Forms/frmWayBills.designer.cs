namespace Logistics
{
	partial class frmWayBills
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWayBills));
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tcList = new RFMBaseClasses.RFMTabControl();
			this.tabTerms = new RFMBaseClasses.RFMTabPage();
			this.cntTerms = new RFMBaseClasses.RFMPanel();
			this.ucSelectRecordID_FuelTypes = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.ucSelectRecordID_FillingsTypes = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.ucSelectRecordID_Drivers = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.ucSelectRecordID_CarsTypes = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.ucSelectRecordID_Cars = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.lblFuelTypes = new RFMBaseClasses.RFMLabel();
			this.lblIsConfirmed = new RFMBaseClasses.RFMLabel();
			this.pnlIsConfirmed = new RFMBaseClasses.RFMPanel();
			this.optIsConfirmedAll = new RFMBaseClasses.RFMRadioButton();
			this.optIsConfirmedNot = new RFMBaseClasses.RFMRadioButton();
			this.optIsConfirmed = new RFMBaseClasses.RFMRadioButton();
			this.lblDrivers = new RFMBaseClasses.RFMLabel();
			this.lblFillingsTypes = new RFMBaseClasses.RFMLabel();
			this.lblCars = new RFMBaseClasses.RFMLabel();
			this.lblCarsTypes = new RFMBaseClasses.RFMLabel();
			this.dtrDates = new RFMBaseClasses.RFMDateRange();
			this.btnClearTerms = new RFMBaseClasses.RFMButton();
			this.lblDate = new RFMBaseClasses.RFMLabel();
			this.tabWayBills = new RFMBaseClasses.RFMTabPage();
			this.cntWayBills = new RFMBaseClasses.RFMSplitContainer();
			this.grdWayBills = new RFMBaseClasses.RFMDataGridView();
			this.grcWayBills_Image = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcWayBills_BillNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_DateWayBeg = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_DateWayEnd = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_CarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_DriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_SpeedometerDataDiff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_FuelDataDiff = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_SpeedometerDataEnd = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_FuelDataEnd = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_Reason = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_CarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_CarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBills_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.tcWayBills = new RFMBaseClasses.RFMTabControl();
			this.tabWayBills_Trips = new RFMBaseClasses.RFMTabPage();
			this.grdWayBills_Trips = new RFMBaseClasses.RFMDataGridView();
			this.grcWayBill_Trip_TripConfirmImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
			this.grcWayBill_Trip_Alias = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_DateTrip = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_TripNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_Brutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_PalletsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_PointsQnt = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_DurationFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_ForGoodsOnly = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcWayBill_Trip_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Trip_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.tabWayBills_Fillings = new RFMBaseClasses.RFMTabPage();
			this.grdWayBills_Fillings = new RFMBaseClasses.RFMDataGridView();
			this.grcWayBill_Filling_DateFill = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Filling_FillingTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Filling_FuelTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Filling_QntFilled = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Filling_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBill_Filling_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.tabFillings = new RFMBaseClasses.RFMTabPage();
			this.cntFillings = new RFMBaseClasses.RFMPanel();
			this.grdFillings = new RFMBaseClasses.RFMDataGridView();
			this.grcFillings_DateFill = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_FillingTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_FuelTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_BillNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_CarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_DriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_QntFilled = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_CarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_Amount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_Price = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_CarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_ID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.btnService = new RFMBaseClasses.RFMButton();
			this.mnuWayBillsService = new RFMBaseClasses.RFMContextMenuStrip();
			this.mniWayBillConfirm = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.mniWayBillUnConfirm = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.btnPrint = new RFMBaseClasses.RFMButton();
			this.mnuWayBillsPrint = new RFMBaseClasses.RFMContextMenuStrip();
			this.mniWayBillPrint = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.tsWayBillPrintSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mniWayBillPrint_ReportFuel = new RFMBaseClasses.RFMContextToolStripMenuItem();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnDelete = new RFMBaseClasses.RFMButton();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.btnCancel = new RFMBaseClasses.RFMButton();
			this.btnEdit = new RFMBaseClasses.RFMButton();
			this.tmrRestore = new RFMBaseClasses.RFMTimer();
			this.dveReportFuelData = new RFMBaseClasses.RFMDataViewerEx();
			this.tcList.SuspendLayout();
			this.tabTerms.SuspendLayout();
			this.cntTerms.SuspendLayout();
			this.ucSelectRecordID_FuelTypes.SuspendLayout();
			this.ucSelectRecordID_FillingsTypes.SuspendLayout();
			this.ucSelectRecordID_Drivers.SuspendLayout();
			this.ucSelectRecordID_CarsTypes.SuspendLayout();
			this.ucSelectRecordID_Cars.SuspendLayout();
			this.pnlIsConfirmed.SuspendLayout();
			this.dtrDates.SuspendLayout();
			this.tabWayBills.SuspendLayout();
			this.cntWayBills.Panel1.SuspendLayout();
			this.cntWayBills.Panel2.SuspendLayout();
			this.cntWayBills.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWayBills)).BeginInit();
			this.tcWayBills.SuspendLayout();
			this.tabWayBills_Trips.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWayBills_Trips)).BeginInit();
			this.tabWayBills_Fillings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdWayBills_Fillings)).BeginInit();
			this.tabFillings.SuspendLayout();
			this.cntFillings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdFillings)).BeginInit();
			this.mnuWayBillsService.SuspendLayout();
			this.mnuWayBillsPrint.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcList
			// 
			this.tcList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcList.Controls.Add(this.tabTerms);
			this.tcList.Controls.Add(this.tabWayBills);
			this.tcList.Controls.Add(this.tabFillings);
			this.tcList.Location = new System.Drawing.Point(1, 1);
			this.tcList.Name = "tcList";
			this.tcList.SelectedIndex = 0;
			this.tcList.Size = new System.Drawing.Size(741, 431);
			this.tcList.TabIndex = 0;
			// 
			// tabTerms
			// 
			this.tabTerms.Controls.Add(this.cntTerms);
			this.tabTerms.IsFilterPage = true;
			this.tabTerms.Location = new System.Drawing.Point(4, 23);
			this.tabTerms.Name = "tabTerms";
			this.tabTerms.Padding = new System.Windows.Forms.Padding(3);
			this.tabTerms.Size = new System.Drawing.Size(733, 404);
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
			this.cntTerms.Controls.Add(this.ucSelectRecordID_FuelTypes);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_FillingsTypes);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_Drivers);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_CarsTypes);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_Cars);
			this.cntTerms.Controls.Add(this.lblFuelTypes);
			this.cntTerms.Controls.Add(this.lblIsConfirmed);
			this.cntTerms.Controls.Add(this.pnlIsConfirmed);
			this.cntTerms.Controls.Add(this.lblDrivers);
			this.cntTerms.Controls.Add(this.lblFillingsTypes);
			this.cntTerms.Controls.Add(this.lblCars);
			this.cntTerms.Controls.Add(this.lblCarsTypes);
			this.cntTerms.Controls.Add(this.dtrDates);
			this.cntTerms.Controls.Add(this.btnClearTerms);
			this.cntTerms.Controls.Add(this.lblDate);
			this.cntTerms.Location = new System.Drawing.Point(0, 2);
			this.cntTerms.Name = "cntTerms";
			this.cntTerms.Size = new System.Drawing.Size(732, 401);
			this.cntTerms.TabIndex = 0;
			// 
			// ucSelectRecordID_FuelTypes
			// 
			// 
			// ucSelectRecordID_FuelTypes.btnClear
			// 
			this.ucSelectRecordID_FuelTypes.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_FuelTypes.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_FuelTypes.btnClear.Image")));
			this.ucSelectRecordID_FuelTypes.BtnClear.Location = new System.Drawing.Point(247, 4);
			this.ucSelectRecordID_FuelTypes.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_FuelTypes.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_FuelTypes.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_FuelTypes.BtnClear, "Очистка выбора типов топлива");
			this.ucSelectRecordID_FuelTypes.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_FuelTypes.btnSelect
			// 
			this.ucSelectRecordID_FuelTypes.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_FuelTypes.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_FuelTypes.btnSelect.Image")));
			this.ucSelectRecordID_FuelTypes.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_FuelTypes.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_FuelTypes.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_FuelTypes.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_FuelTypes.BtnSelect, "Выбор типов топлива");
			this.ucSelectRecordID_FuelTypes.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_FuelTypes.ExpSort = "Name";
			this.ucSelectRecordID_FuelTypes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_FuelTypes.IsActualOnly = true;
			this.ucSelectRecordID_FuelTypes.IsSaveMark = true;
			this.ucSelectRecordID_FuelTypes.IsUseMark = true;
			this.ucSelectRecordID_FuelTypes.Location = new System.Drawing.Point(150, 255);
			this.ucSelectRecordID_FuelTypes.MarkedCount = 0;
			this.ucSelectRecordID_FuelTypes.Name = "ucSelectRecordID_FuelTypes";
			this.ucSelectRecordID_FuelTypes.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_FuelTypes.TabIndex = 13;
			this.ucSelectRecordID_FuelTypes.TableColumnName = "Name";
			// 
			// ucSelectRecordID_FuelTypes.txtData
			// 
			this.ucSelectRecordID_FuelTypes.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_FuelTypes.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_FuelTypes.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_FuelTypes.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_FuelTypes.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_FuelTypes.TxtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_FuelTypes.TxtData.MaxLength = 128;
			this.ucSelectRecordID_FuelTypes.TxtData.Name = "txtData";
			this.ucSelectRecordID_FuelTypes.TxtData.ReadOnly = true;
			this.ucSelectRecordID_FuelTypes.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_FuelTypes.TxtData.TabIndex = 0;
			this.ucSelectRecordID_FuelTypes.СolumnsData.AddRange(new string[] {
            "Name, Тип топлива",
            "Actual, Акт."});
			// 
			// ucSelectRecordID_FillingsTypes
			// 
			// 
			// ucSelectRecordID_FillingsTypes.btnClear
			// 
			this.ucSelectRecordID_FillingsTypes.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_FillingsTypes.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_FillingsTypes.btnClear.Image")));
			this.ucSelectRecordID_FillingsTypes.BtnClear.Location = new System.Drawing.Point(247, 4);
			this.ucSelectRecordID_FillingsTypes.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_FillingsTypes.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_FillingsTypes.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_FillingsTypes.BtnClear, "Очистка выбора типов заправки");
			this.ucSelectRecordID_FillingsTypes.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_FillingsTypes.btnSelect
			// 
			this.ucSelectRecordID_FillingsTypes.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_FillingsTypes.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_FillingsTypes.btnSelect.Image")));
			this.ucSelectRecordID_FillingsTypes.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_FillingsTypes.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_FillingsTypes.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_FillingsTypes.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_FillingsTypes.BtnSelect, "Выбор типов заправки");
			this.ucSelectRecordID_FillingsTypes.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_FillingsTypes.ExpSort = "Name";
			this.ucSelectRecordID_FillingsTypes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_FillingsTypes.IsActualOnly = true;
			this.ucSelectRecordID_FillingsTypes.IsSaveMark = true;
			this.ucSelectRecordID_FillingsTypes.IsUseMark = true;
			this.ucSelectRecordID_FillingsTypes.Location = new System.Drawing.Point(150, 220);
			this.ucSelectRecordID_FillingsTypes.MarkedCount = 0;
			this.ucSelectRecordID_FillingsTypes.Name = "ucSelectRecordID_FillingsTypes";
			this.ucSelectRecordID_FillingsTypes.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_FillingsTypes.TabIndex = 11;
			this.ucSelectRecordID_FillingsTypes.TableColumnName = "Name";
			// 
			// ucSelectRecordID_FillingsTypes.txtData
			// 
			this.ucSelectRecordID_FillingsTypes.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_FillingsTypes.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_FillingsTypes.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_FillingsTypes.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_FillingsTypes.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_FillingsTypes.TxtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_FillingsTypes.TxtData.MaxLength = 128;
			this.ucSelectRecordID_FillingsTypes.TxtData.Name = "txtData";
			this.ucSelectRecordID_FillingsTypes.TxtData.ReadOnly = true;
			this.ucSelectRecordID_FillingsTypes.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_FillingsTypes.TxtData.TabIndex = 0;
			this.ucSelectRecordID_FillingsTypes.СolumnsData.AddRange(new string[] {
            "Name, Тип заправки",
            "Actual, Акт."});
			// 
			// ucSelectRecordID_Drivers
			// 
			// 
			// ucSelectRecordID_Drivers.btnClear
			// 
			this.ucSelectRecordID_Drivers.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Drivers.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Drivers.btnClear.Image")));
			this.ucSelectRecordID_Drivers.BtnClear.Location = new System.Drawing.Point(247, 4);
			this.ucSelectRecordID_Drivers.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_Drivers.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Drivers.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Drivers.BtnClear, "Очистка выбора водителей");
			this.ucSelectRecordID_Drivers.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_Drivers.btnSelect
			// 
			this.ucSelectRecordID_Drivers.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Drivers.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Drivers.btnSelect.Image")));
			this.ucSelectRecordID_Drivers.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_Drivers.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_Drivers.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Drivers.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Drivers.BtnSelect, "Выбор водителей");
			this.ucSelectRecordID_Drivers.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_Drivers.ExpSort = "Name";
			this.ucSelectRecordID_Drivers.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_Drivers.IsActualOnly = true;
			this.ucSelectRecordID_Drivers.IsSaveMark = true;
			this.ucSelectRecordID_Drivers.IsUseMark = true;
			this.ucSelectRecordID_Drivers.Location = new System.Drawing.Point(150, 110);
			this.ucSelectRecordID_Drivers.MarkedCount = 0;
			this.ucSelectRecordID_Drivers.Name = "ucSelectRecordID_Drivers";
			this.ucSelectRecordID_Drivers.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_Drivers.TabIndex = 7;
			this.ucSelectRecordID_Drivers.TableColumnName = "Name";
			// 
			// ucSelectRecordID_Drivers.txtData
			// 
			this.ucSelectRecordID_Drivers.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Drivers.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_Drivers.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_Drivers.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_Drivers.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_Drivers.TxtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_Drivers.TxtData.MaxLength = 128;
			this.ucSelectRecordID_Drivers.TxtData.Name = "txtData";
			this.ucSelectRecordID_Drivers.TxtData.ReadOnly = true;
			this.ucSelectRecordID_Drivers.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_Drivers.TxtData.TabIndex = 0;
			this.ucSelectRecordID_Drivers.СolumnsData.AddRange(new string[] {
            "Name, Водитель",
            "Actual, Акт."});
			// 
			// ucSelectRecordID_CarsTypes
			// 
			// 
			// ucSelectRecordID_CarsTypes.btnClear
			// 
			this.ucSelectRecordID_CarsTypes.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_CarsTypes.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_CarsTypes.btnClear.Image")));
			this.ucSelectRecordID_CarsTypes.BtnClear.Location = new System.Drawing.Point(247, 4);
			this.ucSelectRecordID_CarsTypes.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_CarsTypes.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_CarsTypes.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_CarsTypes.BtnClear, "Очистка выбора типов машин");
			this.ucSelectRecordID_CarsTypes.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_CarsTypes.btnSelect
			// 
			this.ucSelectRecordID_CarsTypes.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_CarsTypes.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_CarsTypes.btnSelect.Image")));
			this.ucSelectRecordID_CarsTypes.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_CarsTypes.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_CarsTypes.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_CarsTypes.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_CarsTypes.BtnSelect, "Выбор типов машин");
			this.ucSelectRecordID_CarsTypes.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_CarsTypes.ExpSort = "Name";
			this.ucSelectRecordID_CarsTypes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_CarsTypes.IsActualOnly = true;
			this.ucSelectRecordID_CarsTypes.IsSaveMark = true;
			this.ucSelectRecordID_CarsTypes.IsUseMark = true;
			this.ucSelectRecordID_CarsTypes.Location = new System.Drawing.Point(150, 40);
			this.ucSelectRecordID_CarsTypes.MarkedCount = 0;
			this.ucSelectRecordID_CarsTypes.Name = "ucSelectRecordID_CarsTypes";
			this.ucSelectRecordID_CarsTypes.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_CarsTypes.TabIndex = 3;
			this.ucSelectRecordID_CarsTypes.TableColumnName = "Name";
			// 
			// ucSelectRecordID_CarsTypes.txtData
			// 
			this.ucSelectRecordID_CarsTypes.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_CarsTypes.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_CarsTypes.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_CarsTypes.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_CarsTypes.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_CarsTypes.TxtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_CarsTypes.TxtData.MaxLength = 128;
			this.ucSelectRecordID_CarsTypes.TxtData.Name = "txtData";
			this.ucSelectRecordID_CarsTypes.TxtData.ReadOnly = true;
			this.ucSelectRecordID_CarsTypes.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_CarsTypes.TxtData.TabIndex = 0;
			this.ucSelectRecordID_CarsTypes.СolumnsData.AddRange(new string[] {
            "Name, Тип машины",
            "Actual, Акт."});
			// 
			// ucSelectRecordID_Cars
			// 
			// 
			// ucSelectRecordID_Cars.btnClear
			// 
			this.ucSelectRecordID_Cars.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Cars.BtnClear.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Cars.btnClear.Image")));
			this.ucSelectRecordID_Cars.BtnClear.Location = new System.Drawing.Point(247, 4);
			this.ucSelectRecordID_Cars.BtnClear.Name = "btnClear";
			this.ucSelectRecordID_Cars.BtnClear.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Cars.BtnClear.TabIndex = 2;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Cars.BtnClear, "Очистка выбора машин");
			this.ucSelectRecordID_Cars.BtnClear.UseVisualStyleBackColor = true;
			// 
			// ucSelectRecordID_Cars.btnSelect
			// 
			this.ucSelectRecordID_Cars.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Cars.BtnSelect.Image = ((System.Drawing.Image)(resources.GetObject("ucSelectRecordID_Cars.btnSelect.Image")));
			this.ucSelectRecordID_Cars.BtnSelect.Location = new System.Drawing.Point(222, 4);
			this.ucSelectRecordID_Cars.BtnSelect.Name = "btnSelect";
			this.ucSelectRecordID_Cars.BtnSelect.Size = new System.Drawing.Size(24, 24);
			this.ucSelectRecordID_Cars.BtnSelect.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.ucSelectRecordID_Cars.BtnSelect, "Выбор машин");
			this.ucSelectRecordID_Cars.BtnSelect.UseVisualStyleBackColor = true;
			this.ucSelectRecordID_Cars.ExpSort = "Name";
			this.ucSelectRecordID_Cars.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ucSelectRecordID_Cars.IsActualOnly = true;
			this.ucSelectRecordID_Cars.IsSaveMark = true;
			this.ucSelectRecordID_Cars.IsUseMark = true;
			this.ucSelectRecordID_Cars.Location = new System.Drawing.Point(150, 75);
			this.ucSelectRecordID_Cars.MarkedCount = 0;
			this.ucSelectRecordID_Cars.Name = "ucSelectRecordID_Cars";
			this.ucSelectRecordID_Cars.Size = new System.Drawing.Size(275, 32);
			this.ucSelectRecordID_Cars.TabIndex = 5;
			this.ucSelectRecordID_Cars.TableColumnName = "Name";
			// 
			// ucSelectRecordID_Cars.txtData
			// 
			this.ucSelectRecordID_Cars.TxtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.ucSelectRecordID_Cars.TxtData.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.ucSelectRecordID_Cars.TxtData.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.ucSelectRecordID_Cars.TxtData.Font = new System.Drawing.Font("Tahoma", 9F);
			this.ucSelectRecordID_Cars.TxtData.IsUserDraw = true;
			this.ucSelectRecordID_Cars.TxtData.Location = new System.Drawing.Point(0, 5);
			this.ucSelectRecordID_Cars.TxtData.MaxLength = 128;
			this.ucSelectRecordID_Cars.TxtData.Name = "txtData";
			this.ucSelectRecordID_Cars.TxtData.ReadOnly = true;
			this.ucSelectRecordID_Cars.TxtData.Size = new System.Drawing.Size(220, 22);
			this.ucSelectRecordID_Cars.TxtData.TabIndex = 0;
			this.ucSelectRecordID_Cars.СolumnsData.AddRange(new string[] {
            "Name, Машина",
            "Tonnage, Тоннаж",
            "Actual, Акт."});
			// 
			// lblFuelTypes
			// 
			this.lblFuelTypes.AutoSize = true;
			this.lblFuelTypes.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblFuelTypes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblFuelTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFuelTypes.Location = new System.Drawing.Point(5, 264);
			this.lblFuelTypes.Name = "lblFuelTypes";
			this.lblFuelTypes.Size = new System.Drawing.Size(79, 14);
			this.lblFuelTypes.TabIndex = 12;
			this.lblFuelTypes.Text = "Тип топлива";
			// 
			// lblIsConfirmed
			// 
			this.lblIsConfirmed.AutoSize = true;
			this.lblIsConfirmed.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblIsConfirmed.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblIsConfirmed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblIsConfirmed.Location = new System.Drawing.Point(5, 156);
			this.lblIsConfirmed.Name = "lblIsConfirmed";
			this.lblIsConfirmed.Size = new System.Drawing.Size(99, 14);
			this.lblIsConfirmed.TabIndex = 8;
			this.lblIsConfirmed.Text = "Подтверждено?";
			// 
			// pnlIsConfirmed
			// 
			this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedAll);
			this.pnlIsConfirmed.Controls.Add(this.optIsConfirmedNot);
			this.pnlIsConfirmed.Controls.Add(this.optIsConfirmed);
			this.pnlIsConfirmed.Location = new System.Drawing.Point(150, 150);
			this.pnlIsConfirmed.Name = "pnlIsConfirmed";
			this.pnlIsConfirmed.Size = new System.Drawing.Size(226, 25);
			this.pnlIsConfirmed.TabIndex = 9;
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
			// optIsConfirmedNot
			// 
			this.optIsConfirmedNot.AutoSize = true;
			this.optIsConfirmedNot.Location = new System.Drawing.Point(163, 4);
			this.optIsConfirmedNot.Name = "optIsConfirmedNot";
			this.optIsConfirmedNot.Size = new System.Drawing.Size(45, 18);
			this.optIsConfirmedNot.TabIndex = 2;
			this.optIsConfirmedNot.Text = "нет";
			this.optIsConfirmedNot.UseVisualStyleBackColor = true;
			// 
			// optIsConfirmed
			// 
			this.optIsConfirmed.AutoSize = true;
			this.optIsConfirmed.IsChanged = true;
			this.optIsConfirmed.Location = new System.Drawing.Point(104, 4);
			this.optIsConfirmed.Name = "optIsConfirmed";
			this.optIsConfirmed.Size = new System.Drawing.Size(38, 18);
			this.optIsConfirmed.TabIndex = 1;
			this.optIsConfirmed.Text = "да";
			this.optIsConfirmed.UseVisualStyleBackColor = true;
			// 
			// lblDrivers
			// 
			this.lblDrivers.AutoSize = true;
			this.lblDrivers.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDrivers.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDrivers.Location = new System.Drawing.Point(5, 119);
			this.lblDrivers.Name = "lblDrivers";
			this.lblDrivers.Size = new System.Drawing.Size(61, 14);
			this.lblDrivers.TabIndex = 6;
			this.lblDrivers.Text = "Водитель";
			// 
			// lblFillingsTypes
			// 
			this.lblFillingsTypes.AutoSize = true;
			this.lblFillingsTypes.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblFillingsTypes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblFillingsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFillingsTypes.Location = new System.Drawing.Point(5, 228);
			this.lblFillingsTypes.Name = "lblFillingsTypes";
			this.lblFillingsTypes.Size = new System.Drawing.Size(133, 14);
			this.lblFillingsTypes.TabIndex = 10;
			this.lblFillingsTypes.Text = "Тип заправки топлива";
			// 
			// lblCars
			// 
			this.lblCars.AutoSize = true;
			this.lblCars.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCars.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCars.Location = new System.Drawing.Point(5, 84);
			this.lblCars.Name = "lblCars";
			this.lblCars.Size = new System.Drawing.Size(50, 14);
			this.lblCars.TabIndex = 4;
			this.lblCars.Text = "Машина";
			// 
			// lblCarsTypes
			// 
			this.lblCarsTypes.AutoSize = true;
			this.lblCarsTypes.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarsTypes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarsTypes.Location = new System.Drawing.Point(5, 49);
			this.lblCarsTypes.Name = "lblCarsTypes";
			this.lblCarsTypes.Size = new System.Drawing.Size(77, 14);
			this.lblCarsTypes.TabIndex = 2;
			this.lblCarsTypes.Text = "Тип машины";
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
			this.dtrDates.Location = new System.Drawing.Point(150, 5);
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
			this.btnClearTerms.Location = new System.Drawing.Point(704, 373);
			this.btnClearTerms.Name = "btnClearTerms";
			this.btnClearTerms.Size = new System.Drawing.Size(22, 22);
			this.btnClearTerms.TabIndex = 14;
			this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
			this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDate.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDate.Location = new System.Drawing.Point(5, 13);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(90, 14);
			this.lblDate.TabIndex = 0;
			this.lblDate.Text = "Дата действия";
			// 
			// tabWayBills
			// 
			this.tabWayBills.Controls.Add(this.cntWayBills);
			this.tabWayBills.Location = new System.Drawing.Point(4, 23);
			this.tabWayBills.Name = "tabWayBills";
			this.tabWayBills.Padding = new System.Windows.Forms.Padding(3);
			this.tabWayBills.Size = new System.Drawing.Size(733, 404);
			this.tabWayBills.TabIndex = 1;
			this.tabWayBills.Text = "Путевые листы";
			this.tabWayBills.UseVisualStyleBackColor = true;
			// 
			// cntWayBills
			// 
			this.cntWayBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cntWayBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.cntWayBills.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cntWayBills.Location = new System.Drawing.Point(0, 2);
			this.cntWayBills.Name = "cntWayBills";
			this.cntWayBills.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// cntWayBills.Panel1
			// 
			this.cntWayBills.Panel1.Controls.Add(this.grdWayBills);
			// 
			// cntWayBills.Panel2
			// 
			this.cntWayBills.Panel2.Controls.Add(this.tcWayBills);
			this.cntWayBills.Size = new System.Drawing.Size(732, 401);
			this.cntWayBills.SplitterDistance = 267;
			this.cntWayBills.SplitterWidth = 2;
			this.cntWayBills.TabIndex = 0;
			// 
			// grdWayBills
			// 
			this.grdWayBills.AllowUserToAddRows = false;
			this.grdWayBills.AllowUserToDeleteRows = false;
			this.grdWayBills.AllowUserToOrderColumns = true;
			this.grdWayBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdWayBills.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdWayBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdWayBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grdWayBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWayBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcWayBills_Image,
            this.grcWayBills_BillNumber,
            this.grcWayBills_DateWayBeg,
            this.grcWayBills_DateWayEnd,
            this.grcWayBills_CarName,
            this.grcWayBills_DriverName,
            this.grcWayBills_SpeedometerDataDiff,
            this.grcWayBills_FuelDataDiff,
            this.grcWayBills_SpeedometerDataEnd,
            this.grcWayBills_FuelDataEnd,
            this.grcWayBills_Reason,
            this.grcWayBills_Note,
            this.grcWayBills_CarNumber,
            this.grcWayBills_CarTypeName,
            this.grcWayBills_ERPCode,
            this.grcWayBills_ID});
			this.grdWayBills.IsCheckerInclude = true;
			this.grdWayBills.IsConfigInclude = true;
			this.grdWayBills.IsMarkedAll = false;
			this.grdWayBills.IsStatusInclude = true;
			this.grdWayBills.IsStatusShow = true;
			this.grdWayBills.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdWayBills.Location = new System.Drawing.Point(-1, -1);
			this.grdWayBills.MultiSelect = false;
			this.grdWayBills.Name = "grdWayBills";
			this.grdWayBills.RangedWay = ' ';
			this.grdWayBills.ReadOnly = true;
			this.grdWayBills.RowHeadersWidth = 24;
			this.grdWayBills.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdWayBills.SelectedRowBorderColor = System.Drawing.Color.Empty;
			this.grdWayBills.SelectedRowForeColor = System.Drawing.Color.Empty;
			this.grdWayBills.Size = new System.Drawing.Size(729, 264);
			this.grdWayBills.StatusRowState = ((byte)(2));
			this.grdWayBills.TabIndex = 11;
			this.grdWayBills.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdWayBills_CurrentRowChanged);
			this.grdWayBills.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdWayBills_CellFormatting);
			// 
			// grcWayBills_Image
			// 
			this.grcWayBills_Image.HeaderText = "";
			this.grcWayBills_Image.Name = "grcWayBills_Image";
			this.grcWayBills_Image.ReadOnly = true;
			this.grcWayBills_Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_Image.ToolTipText = "Действие прекращено?";
			this.grcWayBills_Image.Width = 30;
			// 
			// grcWayBills_BillNumber
			// 
			this.grcWayBills_BillNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_BillNumber.DataPropertyName = "BillNumber";
			this.grcWayBills_BillNumber.HeaderText = "№ п.л.";
			this.grcWayBills_BillNumber.Name = "grcWayBills_BillNumber";
			this.grcWayBills_BillNumber.ReadOnly = true;
			this.grcWayBills_BillNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_BillNumber.ToolTipText = "№ путевого листа в журнале учета";
			this.grcWayBills_BillNumber.Width = 60;
			// 
			// grcWayBills_DateWayBeg
			// 
			this.grcWayBills_DateWayBeg.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_DateWayBeg.DataPropertyName = "DateWayBeg";
			dataGridViewCellStyle2.Format = "dd.MM.yyyy";
			this.grcWayBills_DateWayBeg.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcWayBills_DateWayBeg.HeaderText = "Дата нач.";
			this.grcWayBills_DateWayBeg.Name = "grcWayBills_DateWayBeg";
			this.grcWayBills_DateWayBeg.ReadOnly = true;
			this.grcWayBills_DateWayBeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_DateWayBeg.ToolTipText = "Дата начала действия путевого листа";
			this.grcWayBills_DateWayBeg.Width = 80;
			// 
			// grcWayBills_DateWayEnd
			// 
			this.grcWayBills_DateWayEnd.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_DateWayEnd.DataPropertyName = "DateWayEnd";
			dataGridViewCellStyle3.Format = "dd.MM.yyyy";
			this.grcWayBills_DateWayEnd.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcWayBills_DateWayEnd.HeaderText = "Дата кон.";
			this.grcWayBills_DateWayEnd.Name = "grcWayBills_DateWayEnd";
			this.grcWayBills_DateWayEnd.ReadOnly = true;
			this.grcWayBills_DateWayEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_DateWayEnd.ToolTipText = "Дата окончания действия путевого листа";
			this.grcWayBills_DateWayEnd.Width = 80;
			// 
			// grcWayBills_CarName
			// 
			this.grcWayBills_CarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_CarName.DataPropertyName = "CarName";
			this.grcWayBills_CarName.HeaderText = "Машина";
			this.grcWayBills_CarName.Name = "grcWayBills_CarName";
			this.grcWayBills_CarName.ReadOnly = true;
			this.grcWayBills_CarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_CarName.ToolTipText = "Машина собственная";
			// 
			// grcWayBills_DriverName
			// 
			this.grcWayBills_DriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_DriverName.DataPropertyName = "DriverName";
			this.grcWayBills_DriverName.HeaderText = "Водитель";
			this.grcWayBills_DriverName.Name = "grcWayBills_DriverName";
			this.grcWayBills_DriverName.ReadOnly = true;
			this.grcWayBills_DriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_DriverName.Width = 200;
			// 
			// grcWayBills_SpeedometerDataDiff
			// 
			this.grcWayBills_SpeedometerDataDiff.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_SpeedometerDataDiff.DataPropertyName = "SpeedometerDataDiff";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "N0";
			this.grcWayBills_SpeedometerDataDiff.DefaultCellStyle = dataGridViewCellStyle4;
			this.grcWayBills_SpeedometerDataDiff.HeaderText = "Пробег";
			this.grcWayBills_SpeedometerDataDiff.Name = "grcWayBills_SpeedometerDataDiff";
			this.grcWayBills_SpeedometerDataDiff.ReadOnly = true;
			this.grcWayBills_SpeedometerDataDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_SpeedometerDataDiff.Width = 80;
			// 
			// grcWayBills_FuelDataDiff
			// 
			this.grcWayBills_FuelDataDiff.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_FuelDataDiff.DataPropertyName = "FuelDataDiff";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "N1";
			this.grcWayBills_FuelDataDiff.DefaultCellStyle = dataGridViewCellStyle5;
			this.grcWayBills_FuelDataDiff.HeaderText = "Топливо";
			this.grcWayBills_FuelDataDiff.Name = "grcWayBills_FuelDataDiff";
			this.grcWayBills_FuelDataDiff.ReadOnly = true;
			this.grcWayBills_FuelDataDiff.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_FuelDataDiff.ToolTipText = "Расход топлива";
			this.grcWayBills_FuelDataDiff.Width = 80;
			// 
			// grcWayBills_SpeedometerDataEnd
			// 
			this.grcWayBills_SpeedometerDataEnd.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_SpeedometerDataEnd.DataPropertyName = "SpeedometerDataEnd";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle6.Format = "N0";
			this.grcWayBills_SpeedometerDataEnd.DefaultCellStyle = dataGridViewCellStyle6;
			this.grcWayBills_SpeedometerDataEnd.HeaderText = "Кон. спид.";
			this.grcWayBills_SpeedometerDataEnd.Name = "grcWayBills_SpeedometerDataEnd";
			this.grcWayBills_SpeedometerDataEnd.ReadOnly = true;
			this.grcWayBills_SpeedometerDataEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_SpeedometerDataEnd.ToolTipText = "Конечный спидометр";
			// 
			// grcWayBills_FuelDataEnd
			// 
			this.grcWayBills_FuelDataEnd.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_FuelDataEnd.DataPropertyName = "FuelDataEnd";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "N1";
			this.grcWayBills_FuelDataEnd.DefaultCellStyle = dataGridViewCellStyle7;
			this.grcWayBills_FuelDataEnd.HeaderText = "Кон. ост.";
			this.grcWayBills_FuelDataEnd.Name = "grcWayBills_FuelDataEnd";
			this.grcWayBills_FuelDataEnd.ReadOnly = true;
			this.grcWayBills_FuelDataEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_FuelDataEnd.ToolTipText = "Конечный остаток топлива в баке";
			// 
			// grcWayBills_Reason
			// 
			this.grcWayBills_Reason.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_Reason.DataPropertyName = "Reason";
			this.grcWayBills_Reason.HeaderText = "Назначение";
			this.grcWayBills_Reason.Name = "grcWayBills_Reason";
			this.grcWayBills_Reason.ReadOnly = true;
			this.grcWayBills_Reason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_Reason.Width = 150;
			// 
			// grcWayBills_Note
			// 
			this.grcWayBills_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_Note.DataPropertyName = "Note";
			this.grcWayBills_Note.HeaderText = "Примечание";
			this.grcWayBills_Note.Name = "grcWayBills_Note";
			this.grcWayBills_Note.ReadOnly = true;
			this.grcWayBills_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_Note.Width = 150;
			// 
			// grcWayBills_CarNumber
			// 
			this.grcWayBills_CarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_CarNumber.DataPropertyName = "CarNumber";
			this.grcWayBills_CarNumber.HeaderText = "Гос.номер";
			this.grcWayBills_CarNumber.Name = "grcWayBills_CarNumber";
			this.grcWayBills_CarNumber.ReadOnly = true;
			this.grcWayBills_CarNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcWayBills_CarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcWayBills_CarTypeName
			// 
			this.grcWayBills_CarTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_CarTypeName.DataPropertyName = "CarTypeName";
			this.grcWayBills_CarTypeName.HeaderText = "Тип машины";
			this.grcWayBills_CarTypeName.Name = "grcWayBills_CarTypeName";
			this.grcWayBills_CarTypeName.ReadOnly = true;
			this.grcWayBills_CarTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcWayBills_ERPCode
			// 
			this.grcWayBills_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_ERPCode.DataPropertyName = "ERPCode";
			this.grcWayBills_ERPCode.HeaderText = "ERPCode";
			this.grcWayBills_ERPCode.Name = "grcWayBills_ERPCode";
			this.grcWayBills_ERPCode.ReadOnly = true;
			this.grcWayBills_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_ERPCode.ToolTipText = "Код в host-системе";
			this.grcWayBills_ERPCode.Width = 80;
			// 
			// grcWayBills_ID
			// 
			this.grcWayBills_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBills_ID.DataPropertyName = "ID";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcWayBills_ID.DefaultCellStyle = dataGridViewCellStyle8;
			this.grcWayBills_ID.HeaderText = "ID";
			this.grcWayBills_ID.Name = "grcWayBills_ID";
			this.grcWayBills_ID.ReadOnly = true;
			this.grcWayBills_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBills_ID.ToolTipText = "Код путевого листа";
			this.grcWayBills_ID.Width = 50;
			// 
			// tcWayBills
			// 
			this.tcWayBills.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tcWayBills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tcWayBills.Controls.Add(this.tabWayBills_Trips);
			this.tcWayBills.Controls.Add(this.tabWayBills_Fillings);
			this.tcWayBills.ItemSize = new System.Drawing.Size(120, 18);
			this.tcWayBills.Location = new System.Drawing.Point(1, 1);
			this.tcWayBills.Multiline = true;
			this.tcWayBills.Name = "tcWayBills";
			this.tcWayBills.SelectedIndex = 0;
			this.tcWayBills.Size = new System.Drawing.Size(727, 127);
			this.tcWayBills.TabIndex = 0;
			// 
			// tabWayBills_Trips
			// 
			this.tabWayBills_Trips.Controls.Add(this.grdWayBills_Trips);
			this.tabWayBills_Trips.Location = new System.Drawing.Point(4, 4);
			this.tabWayBills_Trips.Name = "tabWayBills_Trips";
			this.tabWayBills_Trips.Padding = new System.Windows.Forms.Padding(3);
			this.tabWayBills_Trips.Size = new System.Drawing.Size(719, 101);
			this.tabWayBills_Trips.TabIndex = 0;
			this.tabWayBills_Trips.Text = "Рейсы";
			this.tabWayBills_Trips.UseVisualStyleBackColor = true;
			// 
			// grdWayBills_Trips
			// 
			this.grdWayBills_Trips.AllowUserToAddRows = false;
			this.grdWayBills_Trips.AllowUserToDeleteRows = false;
			this.grdWayBills_Trips.AllowUserToOrderColumns = true;
			this.grdWayBills_Trips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdWayBills_Trips.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdWayBills_Trips.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdWayBills_Trips.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdWayBills_Trips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.grdWayBills_Trips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWayBills_Trips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcWayBill_Trip_TripConfirmImage,
            this.grcWayBill_Trip_Alias,
            this.grcWayBill_Trip_DateTrip,
            this.grcWayBill_Trip_TripNumber,
            this.grcWayBill_Trip_Brutto,
            this.grcWayBill_Trip_PalletsQnt,
            this.grcWayBill_Trip_PointsQnt,
            this.grcWayBill_Trip_DurationFact,
            this.grcWayBill_Trip_Note,
            this.grcWayBill_Trip_ForGoodsOnly,
            this.grcWayBill_Trip_ERPCode,
            this.grcWayBill_Trip_ID});
			this.grdWayBills_Trips.IsCheckerInclude = true;
			this.grdWayBills_Trips.IsConfigInclude = true;
			this.grdWayBills_Trips.IsMarkedAll = false;
			this.grdWayBills_Trips.IsStatusInclude = true;
			this.grdWayBills_Trips.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdWayBills_Trips.Location = new System.Drawing.Point(0, 0);
			this.grdWayBills_Trips.MultiSelect = false;
			this.grdWayBills_Trips.Name = "grdWayBills_Trips";
			this.grdWayBills_Trips.RangedWay = ' ';
			this.grdWayBills_Trips.ReadOnly = true;
			this.grdWayBills_Trips.RowHeadersWidth = 24;
			this.grdWayBills_Trips.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdWayBills_Trips.SelectedRowBorderColor = System.Drawing.Color.Empty;
			this.grdWayBills_Trips.SelectedRowForeColor = System.Drawing.Color.Empty;
			this.grdWayBills_Trips.Size = new System.Drawing.Size(717, 98);
			this.grdWayBills_Trips.TabIndex = 12;
			this.grdWayBills_Trips.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdWayBills_Trips_CellFormatting);
			// 
			// grcWayBill_Trip_TripConfirmImage
			// 
			this.grcWayBill_Trip_TripConfirmImage.HeaderText = "Пдт.";
			this.grcWayBill_Trip_TripConfirmImage.Name = "grcWayBill_Trip_TripConfirmImage";
			this.grcWayBill_Trip_TripConfirmImage.ReadOnly = true;
			this.grcWayBill_Trip_TripConfirmImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_TripConfirmImage.ToolTipText = "Рейс подтвержден?";
			this.grcWayBill_Trip_TripConfirmImage.Width = 45;
			// 
			// grcWayBill_Trip_Alias
			// 
			this.grcWayBill_Trip_Alias.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_Alias.DataPropertyName = "Alias";
			this.grcWayBill_Trip_Alias.HeaderText = "Описание";
			this.grcWayBill_Trip_Alias.Name = "grcWayBill_Trip_Alias";
			this.grcWayBill_Trip_Alias.ReadOnly = true;
			this.grcWayBill_Trip_Alias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_Alias.Width = 200;
			// 
			// grcWayBill_Trip_DateTrip
			// 
			this.grcWayBill_Trip_DateTrip.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_DateTrip.DataPropertyName = "DateTrip";
			this.grcWayBill_Trip_DateTrip.HeaderText = "Дата";
			this.grcWayBill_Trip_DateTrip.Name = "grcWayBill_Trip_DateTrip";
			this.grcWayBill_Trip_DateTrip.ReadOnly = true;
			this.grcWayBill_Trip_DateTrip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_DateTrip.ToolTipText = "Дата рейса";
			this.grcWayBill_Trip_DateTrip.Width = 80;
			// 
			// grcWayBill_Trip_TripNumber
			// 
			this.grcWayBill_Trip_TripNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_TripNumber.DataPropertyName = "TripNumber";
			this.grcWayBill_Trip_TripNumber.HeaderText = "Ездка";
			this.grcWayBill_Trip_TripNumber.Name = "grcWayBill_Trip_TripNumber";
			this.grcWayBill_Trip_TripNumber.ReadOnly = true;
			this.grcWayBill_Trip_TripNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_TripNumber.ToolTipText = "№ ездки";
			this.grcWayBill_Trip_TripNumber.Width = 50;
			// 
			// grcWayBill_Trip_Brutto
			// 
			this.grcWayBill_Trip_Brutto.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_Brutto.DataPropertyName = "OutputsBrutto";
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle10.Format = "N1";
			this.grcWayBill_Trip_Brutto.DefaultCellStyle = dataGridViewCellStyle10;
			this.grcWayBill_Trip_Brutto.HeaderText = "Брутто";
			this.grcWayBill_Trip_Brutto.Name = "grcWayBill_Trip_Brutto";
			this.grcWayBill_Trip_Brutto.ReadOnly = true;
			this.grcWayBill_Trip_Brutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_Brutto.ToolTipText = "Вес брутто товара, кг";
			this.grcWayBill_Trip_Brutto.Width = 70;
			// 
			// grcWayBill_Trip_PalletsQnt
			// 
			this.grcWayBill_Trip_PalletsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_PalletsQnt.DataPropertyName = "OutputsPalletsQnt";
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle11.Format = "N1";
			dataGridViewCellStyle11.NullValue = null;
			this.grcWayBill_Trip_PalletsQnt.DefaultCellStyle = dataGridViewCellStyle11;
			this.grcWayBill_Trip_PalletsQnt.HeaderText = "Пал.";
			this.grcWayBill_Trip_PalletsQnt.Name = "grcWayBill_Trip_PalletsQnt";
			this.grcWayBill_Trip_PalletsQnt.ReadOnly = true;
			this.grcWayBill_Trip_PalletsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_PalletsQnt.ToolTipText = "Количество паллет";
			this.grcWayBill_Trip_PalletsQnt.Width = 60;
			// 
			// grcWayBill_Trip_PointsQnt
			// 
			this.grcWayBill_Trip_PointsQnt.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_PointsQnt.DataPropertyName = "OutputsDocumentsPointsQnt";
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle12.Format = "N0";
			this.grcWayBill_Trip_PointsQnt.DefaultCellStyle = dataGridViewCellStyle12;
			this.grcWayBill_Trip_PointsQnt.HeaderText = "Точек";
			this.grcWayBill_Trip_PointsQnt.Name = "grcWayBill_Trip_PointsQnt";
			this.grcWayBill_Trip_PointsQnt.ReadOnly = true;
			this.grcWayBill_Trip_PointsQnt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_PointsQnt.ToolTipText = "Количество клиентов";
			this.grcWayBill_Trip_PointsQnt.Width = 80;
			// 
			// grcWayBill_Trip_DurationFact
			// 
			this.grcWayBill_Trip_DurationFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_DurationFact.DataPropertyName = "DurationHoursMinutesFact";
			this.grcWayBill_Trip_DurationFact.HeaderText = "Длит.";
			this.grcWayBill_Trip_DurationFact.Name = "grcWayBill_Trip_DurationFact";
			this.grcWayBill_Trip_DurationFact.ReadOnly = true;
			this.grcWayBill_Trip_DurationFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_DurationFact.ToolTipText = "Длительность рейса, часов:минут";
			this.grcWayBill_Trip_DurationFact.Width = 70;
			// 
			// grcWayBill_Trip_Note
			// 
			this.grcWayBill_Trip_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_Note.DataPropertyName = "Note";
			this.grcWayBill_Trip_Note.HeaderText = "Примечание";
			this.grcWayBill_Trip_Note.Name = "grcWayBill_Trip_Note";
			this.grcWayBill_Trip_Note.ReadOnly = true;
			this.grcWayBill_Trip_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_Note.Width = 150;
			// 
			// grcWayBill_Trip_ForGoodsOnly
			// 
			this.grcWayBill_Trip_ForGoodsOnly.DataPropertyName = "ForGoodsOnly";
			this.grcWayBill_Trip_ForGoodsOnly.HeaderText = "Товар";
			this.grcWayBill_Trip_ForGoodsOnly.Name = "grcWayBill_Trip_ForGoodsOnly";
			this.grcWayBill_Trip_ForGoodsOnly.ReadOnly = true;
			this.grcWayBill_Trip_ForGoodsOnly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcWayBill_Trip_ForGoodsOnly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_ForGoodsOnly.ToolTipText = "Поставка/отгрузка товара?";
			this.grcWayBill_Trip_ForGoodsOnly.Width = 50;
			// 
			// grcWayBill_Trip_ERPCode
			// 
			this.grcWayBill_Trip_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_ERPCode.DataPropertyName = "ERPCode";
			this.grcWayBill_Trip_ERPCode.HeaderText = "ERPCode";
			this.grcWayBill_Trip_ERPCode.Name = "grcWayBill_Trip_ERPCode";
			this.grcWayBill_Trip_ERPCode.ReadOnly = true;
			this.grcWayBill_Trip_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_ERPCode.ToolTipText = "Код в host-системе";
			this.grcWayBill_Trip_ERPCode.Width = 80;
			// 
			// grcWayBill_Trip_ID
			// 
			this.grcWayBill_Trip_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Trip_ID.DataPropertyName = "ID";
			dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcWayBill_Trip_ID.DefaultCellStyle = dataGridViewCellStyle13;
			this.grcWayBill_Trip_ID.HeaderText = "ID";
			this.grcWayBill_Trip_ID.Name = "grcWayBill_Trip_ID";
			this.grcWayBill_Trip_ID.ReadOnly = true;
			this.grcWayBill_Trip_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Trip_ID.ToolTipText = "Код рейса";
			this.grcWayBill_Trip_ID.Width = 50;
			// 
			// tabWayBills_Fillings
			// 
			this.tabWayBills_Fillings.Controls.Add(this.grdWayBills_Fillings);
			this.tabWayBills_Fillings.Location = new System.Drawing.Point(4, 4);
			this.tabWayBills_Fillings.Name = "tabWayBills_Fillings";
			this.tabWayBills_Fillings.Size = new System.Drawing.Size(719, 101);
			this.tabWayBills_Fillings.TabIndex = 1;
			this.tabWayBills_Fillings.Text = "Заправки";
			this.tabWayBills_Fillings.UseVisualStyleBackColor = true;
			// 
			// grdWayBills_Fillings
			// 
			this.grdWayBills_Fillings.AllowUserToAddRows = false;
			this.grdWayBills_Fillings.AllowUserToDeleteRows = false;
			this.grdWayBills_Fillings.AllowUserToOrderColumns = true;
			this.grdWayBills_Fillings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdWayBills_Fillings.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdWayBills_Fillings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.grdWayBills_Fillings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdWayBills_Fillings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.grdWayBills_Fillings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdWayBills_Fillings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcWayBill_Filling_DateFill,
            this.grcWayBill_Filling_FillingTypeName,
            this.grcWayBill_Filling_FuelTypeName,
            this.grcWayBill_Filling_QntFilled,
            this.grcWayBill_Filling_Note,
            this.grcWayBill_Filling_ID});
			this.grdWayBills_Fillings.IsCheckerInclude = true;
			this.grdWayBills_Fillings.IsConfigInclude = true;
			this.grdWayBills_Fillings.IsMarkedAll = false;
			this.grdWayBills_Fillings.IsStatusInclude = true;
			this.grdWayBills_Fillings.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdWayBills_Fillings.Location = new System.Drawing.Point(0, 0);
			this.grdWayBills_Fillings.MultiSelect = false;
			this.grdWayBills_Fillings.Name = "grdWayBills_Fillings";
			this.grdWayBills_Fillings.RangedWay = ' ';
			this.grdWayBills_Fillings.ReadOnly = true;
			this.grdWayBills_Fillings.RowHeadersWidth = 24;
			this.grdWayBills_Fillings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdWayBills_Fillings.SelectedRowBorderColor = System.Drawing.Color.Empty;
			this.grdWayBills_Fillings.SelectedRowForeColor = System.Drawing.Color.Empty;
			this.grdWayBills_Fillings.Size = new System.Drawing.Size(717, 98);
			this.grdWayBills_Fillings.TabIndex = 13;
			this.grdWayBills_Fillings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdWayBills_Fillings_CellFormatting);
			// 
			// grcWayBill_Filling_DateFill
			// 
			this.grcWayBill_Filling_DateFill.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Filling_DateFill.DataPropertyName = "DateFill";
			dataGridViewCellStyle15.Format = "dd.MM.yyyy";
			this.grcWayBill_Filling_DateFill.DefaultCellStyle = dataGridViewCellStyle15;
			this.grcWayBill_Filling_DateFill.HeaderText = "Дата";
			this.grcWayBill_Filling_DateFill.Name = "grcWayBill_Filling_DateFill";
			this.grcWayBill_Filling_DateFill.ReadOnly = true;
			this.grcWayBill_Filling_DateFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Filling_DateFill.ToolTipText = "Дата заправки топлива";
			this.grcWayBill_Filling_DateFill.Width = 80;
			// 
			// grcWayBill_Filling_FillingTypeName
			// 
			this.grcWayBill_Filling_FillingTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Filling_FillingTypeName.DataPropertyName = "FillingTypeName";
			this.grcWayBill_Filling_FillingTypeName.HeaderText = "Тип заправки";
			this.grcWayBill_Filling_FillingTypeName.Name = "grcWayBill_Filling_FillingTypeName";
			this.grcWayBill_Filling_FillingTypeName.ReadOnly = true;
			this.grcWayBill_Filling_FillingTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcWayBill_Filling_FuelTypeName
			// 
			this.grcWayBill_Filling_FuelTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Filling_FuelTypeName.DataPropertyName = "FuelTypeName";
			this.grcWayBill_Filling_FuelTypeName.HeaderText = "Тип топлива";
			this.grcWayBill_Filling_FuelTypeName.Name = "grcWayBill_Filling_FuelTypeName";
			this.grcWayBill_Filling_FuelTypeName.ReadOnly = true;
			this.grcWayBill_Filling_FuelTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcWayBill_Filling_QntFilled
			// 
			this.grcWayBill_Filling_QntFilled.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Filling_QntFilled.DataPropertyName = "QntFilled";
			dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle16.Format = "N0";
			this.grcWayBill_Filling_QntFilled.DefaultCellStyle = dataGridViewCellStyle16;
			this.grcWayBill_Filling_QntFilled.HeaderText = "Кол-во";
			this.grcWayBill_Filling_QntFilled.Name = "grcWayBill_Filling_QntFilled";
			this.grcWayBill_Filling_QntFilled.ReadOnly = true;
			this.grcWayBill_Filling_QntFilled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Filling_QntFilled.ToolTipText = "Количество заправленного топлива, л";
			this.grcWayBill_Filling_QntFilled.Width = 70;
			// 
			// grcWayBill_Filling_Note
			// 
			this.grcWayBill_Filling_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Filling_Note.DataPropertyName = "Note";
			this.grcWayBill_Filling_Note.HeaderText = "Примечание";
			this.grcWayBill_Filling_Note.Name = "grcWayBill_Filling_Note";
			this.grcWayBill_Filling_Note.ReadOnly = true;
			this.grcWayBill_Filling_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Filling_Note.Width = 150;
			// 
			// grcWayBill_Filling_ID
			// 
			this.grcWayBill_Filling_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBill_Filling_ID.DataPropertyName = "ID";
			dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcWayBill_Filling_ID.DefaultCellStyle = dataGridViewCellStyle17;
			this.grcWayBill_Filling_ID.HeaderText = "ID";
			this.grcWayBill_Filling_ID.Name = "grcWayBill_Filling_ID";
			this.grcWayBill_Filling_ID.ReadOnly = true;
			this.grcWayBill_Filling_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBill_Filling_ID.ToolTipText = "Код заправки";
			this.grcWayBill_Filling_ID.Width = 50;
			// 
			// tabFillings
			// 
			this.tabFillings.Controls.Add(this.cntFillings);
			this.tabFillings.Location = new System.Drawing.Point(4, 23);
			this.tabFillings.Name = "tabFillings";
			this.tabFillings.Size = new System.Drawing.Size(733, 404);
			this.tabFillings.TabIndex = 2;
			this.tabFillings.Text = "Заправки топлива";
			this.tabFillings.UseVisualStyleBackColor = true;
			// 
			// cntFillings
			// 
			this.cntFillings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cntFillings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.cntFillings.Controls.Add(this.grdFillings);
			this.cntFillings.Location = new System.Drawing.Point(0, 2);
			this.cntFillings.Name = "cntFillings";
			this.cntFillings.Size = new System.Drawing.Size(732, 401);
			this.cntFillings.TabIndex = 0;
			// 
			// grdFillings
			// 
			this.grdFillings.AllowUserToAddRows = false;
			this.grdFillings.AllowUserToDeleteRows = false;
			this.grdFillings.AllowUserToOrderColumns = true;
			this.grdFillings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.grdFillings.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grdFillings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grdFillings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
			this.grdFillings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdFillings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grcFillings_DateFill,
            this.grcFillings_FillingTypeName,
            this.grcFillings_FuelTypeName,
            this.grcFillings_BillNumber,
            this.grcFillings_CarName,
            this.grcFillings_DriverName,
            this.grcFillings_QntFilled,
            this.grcFillings_CarNumber,
            this.grcFillings_Amount,
            this.grcFillings_Price,
            this.grcFillings_Note,
            this.grcFillings_CarTypeName,
            this.grcFillings_ERPCode,
            this.grcFillings_ID});
			this.grdFillings.IsCheckerInclude = true;
			this.grdFillings.IsConfigInclude = true;
			this.grdFillings.IsMarkedAll = false;
			this.grdFillings.IsStatusInclude = true;
			this.grdFillings.IsStatusShow = true;
			this.grdFillings.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
			this.grdFillings.Location = new System.Drawing.Point(-1, -1);
			this.grdFillings.MultiSelect = false;
			this.grdFillings.Name = "grdFillings";
			this.grdFillings.RangedWay = ' ';
			this.grdFillings.ReadOnly = true;
			this.grdFillings.RowHeadersWidth = 24;
			this.grdFillings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grdFillings.SelectedRowBorderColor = System.Drawing.Color.Empty;
			this.grdFillings.SelectedRowForeColor = System.Drawing.Color.Empty;
			this.grdFillings.Size = new System.Drawing.Size(730, 398);
			this.grdFillings.StatusRowState = ((byte)(2));
			this.grdFillings.TabIndex = 14;
			// 
			// grcFillings_DateFill
			// 
			this.grcFillings_DateFill.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_DateFill.DataPropertyName = "DateFill";
			dataGridViewCellStyle19.Format = "dd.MM.yyyy";
			this.grcFillings_DateFill.DefaultCellStyle = dataGridViewCellStyle19;
			this.grcFillings_DateFill.HeaderText = "Дата";
			this.grcFillings_DateFill.Name = "grcFillings_DateFill";
			this.grcFillings_DateFill.ReadOnly = true;
			this.grcFillings_DateFill.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_DateFill.ToolTipText = "Дата заправки топлива";
			this.grcFillings_DateFill.Width = 80;
			// 
			// grcFillings_FillingTypeName
			// 
			this.grcFillings_FillingTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_FillingTypeName.DataPropertyName = "FillingTypeName";
			this.grcFillings_FillingTypeName.HeaderText = "Тип заправки";
			this.grcFillings_FillingTypeName.Name = "grcFillings_FillingTypeName";
			this.grcFillings_FillingTypeName.ReadOnly = true;
			this.grcFillings_FillingTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcFillings_FuelTypeName
			// 
			this.grcFillings_FuelTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_FuelTypeName.DataPropertyName = "FuelTypeName";
			this.grcFillings_FuelTypeName.HeaderText = "Тип топлива";
			this.grcFillings_FuelTypeName.Name = "grcFillings_FuelTypeName";
			this.grcFillings_FuelTypeName.ReadOnly = true;
			this.grcFillings_FuelTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcFillings_BillNumber
			// 
			this.grcFillings_BillNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_BillNumber.DataPropertyName = "BillNumber";
			this.grcFillings_BillNumber.HeaderText = "№ ПЛ";
			this.grcFillings_BillNumber.Name = "grcFillings_BillNumber";
			this.grcFillings_BillNumber.ReadOnly = true;
			this.grcFillings_BillNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_BillNumber.ToolTipText = "№ путевого листа";
			this.grcFillings_BillNumber.Width = 80;
			// 
			// grcFillings_CarName
			// 
			this.grcFillings_CarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_CarName.DataPropertyName = "CarName";
			this.grcFillings_CarName.HeaderText = "Машина";
			this.grcFillings_CarName.Name = "grcFillings_CarName";
			this.grcFillings_CarName.ReadOnly = true;
			this.grcFillings_CarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcFillings_DriverName
			// 
			this.grcFillings_DriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_DriverName.DataPropertyName = "DriverName";
			this.grcFillings_DriverName.HeaderText = "Водитель";
			this.grcFillings_DriverName.Name = "grcFillings_DriverName";
			this.grcFillings_DriverName.ReadOnly = true;
			this.grcFillings_DriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_DriverName.Width = 200;
			// 
			// grcFillings_QntFilled
			// 
			this.grcFillings_QntFilled.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_QntFilled.DataPropertyName = "QntFilled";
			dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle20.Format = "N1";
			this.grcFillings_QntFilled.DefaultCellStyle = dataGridViewCellStyle20;
			this.grcFillings_QntFilled.HeaderText = "Кол-во";
			this.grcFillings_QntFilled.Name = "grcFillings_QntFilled";
			this.grcFillings_QntFilled.ReadOnly = true;
			this.grcFillings_QntFilled.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_QntFilled.ToolTipText = "Количество заправленного топлива, л";
			this.grcFillings_QntFilled.Width = 70;
			// 
			// grcFillings_CarNumber
			// 
			this.grcFillings_CarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_CarNumber.DataPropertyName = "CarNumber";
			this.grcFillings_CarNumber.HeaderText = "Гос.номер";
			this.grcFillings_CarNumber.Name = "grcFillings_CarNumber";
			this.grcFillings_CarNumber.ReadOnly = true;
			this.grcFillings_CarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcFillings_Amount
			// 
			this.grcFillings_Amount.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_Amount.DataPropertyName = "Amount";
			dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle21.Format = "N2";
			this.grcFillings_Amount.DefaultCellStyle = dataGridViewCellStyle21;
			this.grcFillings_Amount.HeaderText = "Стоимость";
			this.grcFillings_Amount.Name = "grcFillings_Amount";
			this.grcFillings_Amount.ReadOnly = true;
			this.grcFillings_Amount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_Amount.ToolTipText = "Стоимость заправленного топлива, руб.";
			this.grcFillings_Amount.Width = 80;
			// 
			// grcFillings_Price
			// 
			this.grcFillings_Price.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_Price.DataPropertyName = "Price";
			dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle22.Format = "N2";
			dataGridViewCellStyle22.NullValue = null;
			this.grcFillings_Price.DefaultCellStyle = dataGridViewCellStyle22;
			this.grcFillings_Price.HeaderText = "Цена";
			this.grcFillings_Price.Name = "grcFillings_Price";
			this.grcFillings_Price.ReadOnly = true;
			this.grcFillings_Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_Price.ToolTipText = "Цена 1 л топлива, руб.";
			this.grcFillings_Price.Width = 60;
			// 
			// grcFillings_Note
			// 
			this.grcFillings_Note.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_Note.DataPropertyName = "Note";
			this.grcFillings_Note.HeaderText = "Примечание";
			this.grcFillings_Note.Name = "grcFillings_Note";
			this.grcFillings_Note.ReadOnly = true;
			this.grcFillings_Note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_Note.Width = 150;
			// 
			// grcFillings_CarTypeName
			// 
			this.grcFillings_CarTypeName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_CarTypeName.DataPropertyName = "CarTypeName";
			this.grcFillings_CarTypeName.HeaderText = "Тип машины";
			this.grcFillings_CarTypeName.Name = "grcFillings_CarTypeName";
			this.grcFillings_CarTypeName.ReadOnly = true;
			this.grcFillings_CarTypeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcFillings_ERPCode
			// 
			this.grcFillings_ERPCode.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_ERPCode.DataPropertyName = "ERPCode";
			this.grcFillings_ERPCode.HeaderText = "ERPCode";
			this.grcFillings_ERPCode.Name = "grcFillings_ERPCode";
			this.grcFillings_ERPCode.ReadOnly = true;
			this.grcFillings_ERPCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_ERPCode.ToolTipText = "Код в host-системе";
			// 
			// grcFillings_ID
			// 
			this.grcFillings_ID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcFillings_ID.DataPropertyName = "ID";
			dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcFillings_ID.DefaultCellStyle = dataGridViewCellStyle23;
			this.grcFillings_ID.HeaderText = "ID";
			this.grcFillings_ID.Name = "grcFillings_ID";
			this.grcFillings_ID.ReadOnly = true;
			this.grcFillings_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcFillings_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcFillings_ID.ToolTipText = "Код заправки";
			this.grcFillings_ID.Width = 50;
			// 
			// btnService
			// 
			this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnService.ContextMenuStrip = this.mnuWayBillsService;
			this.btnService.Image = global::Logistics.Properties.Resources.Service;
			this.btnService.Location = new System.Drawing.Point(656, 438);
			this.btnService.Name = "btnService";
			this.btnService.Size = new System.Drawing.Size(30, 30);
			this.btnService.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnService, "Дополнительно");
			this.btnService.UseVisualStyleBackColor = true;
			this.btnService.Click += new System.EventHandler(this.btnService_Click);
			// 
			// mnuWayBillsService
			// 
			this.mnuWayBillsService.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniWayBillConfirm,
            this.mniWayBillUnConfirm});
			this.mnuWayBillsService.Name = "mnuWayBillsService";
			this.mnuWayBillsService.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuWayBillsService.Size = new System.Drawing.Size(212, 48);
			// 
			// mniWayBillConfirm
			// 
			this.mniWayBillConfirm.Name = "mniWayBillConfirm";
			this.mniWayBillConfirm.Size = new System.Drawing.Size(211, 22);
			this.mniWayBillConfirm.Text = "Закрыть путевой лист";
			this.mniWayBillConfirm.Click += new System.EventHandler(this.mniWayBillConfirm_Click);
			// 
			// mniWayBillUnConfirm
			// 
			this.mniWayBillUnConfirm.Name = "mniWayBillUnConfirm";
			this.mniWayBillUnConfirm.Size = new System.Drawing.Size(211, 22);
			this.mniWayBillUnConfirm.Text = "Снять отметку о закрытии";
			this.mniWayBillUnConfirm.Click += new System.EventHandler(this.mniWayBillUnConfirm_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.ContextMenuStrip = this.mnuWayBillsPrint;
			this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(606, 438);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(30, 30);
			this.btnPrint.TabIndex = 5;
			this.ttToolTip.SetToolTip(this.btnPrint, "Печать");
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// mnuWayBillsPrint
			// 
			this.mnuWayBillsPrint.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniWayBillPrint,
            this.tsWayBillPrintSeparator1,
            this.mniWayBillPrint_ReportFuel});
			this.mnuWayBillsPrint.Name = "mnuWayBillsPrint";
			this.mnuWayBillsPrint.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.mnuWayBillsPrint.Size = new System.Drawing.Size(167, 54);
			// 
			// mniWayBillPrint
			// 
			this.mniWayBillPrint.Name = "mniWayBillPrint";
			this.mniWayBillPrint.Size = new System.Drawing.Size(166, 22);
			this.mniWayBillPrint.Text = "Путевой лист";
			this.mniWayBillPrint.Click += new System.EventHandler(this.mniWayBillPrint_Click);
			// 
			// tsWayBillPrintSeparator1
			// 
			this.tsWayBillPrintSeparator1.Name = "tsWayBillPrintSeparator1";
			this.tsWayBillPrintSeparator1.Size = new System.Drawing.Size(163, 6);
			// 
			// mniWayBillPrint_ReportFuel
			// 
			this.mniWayBillPrint_ReportFuel.Name = "mniWayBillPrint_ReportFuel";
			this.mniWayBillPrint_ReportFuel.Size = new System.Drawing.Size(166, 22);
			this.mniWayBillPrint_ReportFuel.Text = "Отчет по топливу";
			this.mniWayBillPrint_ReportFuel.Click += new System.EventHandler(this.mniWayBillPrint_ReportFuel_Click);
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
			this.btnDelete.Image = global::Logistics.Properties.Resources.Delete;
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
			this.btnAdd.Image = global::Logistics.Properties.Resources.Add;
			this.btnAdd.Location = new System.Drawing.Point(456, 438);
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
			this.btnEdit.Image = global::Logistics.Properties.Resources.Edit;
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
			// frmWayBills
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
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
			this.LastGrid = this.grdWayBills;
			this.MinimumSize = new System.Drawing.Size(750, 500);
			this.Name = "frmWayBills";
			this.hpHelp.SetShowHelp(this, true);
			this.Text = "Путевые листы, топливо";
			this.Load += new System.EventHandler(this.frmWayBills_Load);
			this.tcList.ResumeLayout(false);
			this.tabTerms.ResumeLayout(false);
			this.cntTerms.ResumeLayout(false);
			this.cntTerms.PerformLayout();
			this.ucSelectRecordID_FuelTypes.ResumeLayout(false);
			this.ucSelectRecordID_FuelTypes.PerformLayout();
			this.ucSelectRecordID_FillingsTypes.ResumeLayout(false);
			this.ucSelectRecordID_FillingsTypes.PerformLayout();
			this.ucSelectRecordID_Drivers.ResumeLayout(false);
			this.ucSelectRecordID_Drivers.PerformLayout();
			this.ucSelectRecordID_CarsTypes.ResumeLayout(false);
			this.ucSelectRecordID_CarsTypes.PerformLayout();
			this.ucSelectRecordID_Cars.ResumeLayout(false);
			this.ucSelectRecordID_Cars.PerformLayout();
			this.pnlIsConfirmed.ResumeLayout(false);
			this.pnlIsConfirmed.PerformLayout();
			this.dtrDates.ResumeLayout(false);
			this.dtrDates.PerformLayout();
			this.tabWayBills.ResumeLayout(false);
			this.cntWayBills.Panel1.ResumeLayout(false);
			this.cntWayBills.Panel2.ResumeLayout(false);
			this.cntWayBills.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdWayBills)).EndInit();
			this.tcWayBills.ResumeLayout(false);
			this.tabWayBills_Trips.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdWayBills_Trips)).EndInit();
			this.tabWayBills_Fillings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdWayBills_Fillings)).EndInit();
			this.tabFillings.ResumeLayout(false);
			this.cntFillings.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdFillings)).EndInit();
			this.mnuWayBillsService.ResumeLayout(false);
			this.mnuWayBillsPrint.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMTabControl tcList;
        private RFMBaseClasses.RFMTabPage tabTerms;
		private RFMBaseClasses.RFMButton btnEdit;
		private RFMBaseClasses.RFMButton btnCancel;
		private RFMBaseClasses.RFMTabPage tabWayBills;
		private RFMBaseClasses.RFMSplitContainer cntWayBills;
        private RFMBaseClasses.RFMDataGridView grdWayBills;
        private RFMBaseClasses.RFMButton btnAdd;
        private RFMBaseClasses.RFMButton btnDelete;
		private RFMBaseClasses.RFMButton btnHelp;
        private RFMBaseClasses.RFMButton btnPrint;
		private RFMBaseClasses.RFMButton btnService;
		private RFMBaseClasses.RFMTabControl tcWayBills;
		private RFMBaseClasses.RFMTabPage tabWayBills_Trips;
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblDate;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblCarsTypes;
		private RFMBaseClasses.RFMLabel lblCars;
		private RFMBaseClasses.RFMLabel lblFillingsTypes;
		private RFMBaseClasses.RFMLabel lblDrivers;
		private RFMBaseClasses.RFMLabel lblIsConfirmed;
		private RFMBaseClasses.RFMPanel pnlIsConfirmed;
		private RFMBaseClasses.RFMRadioButton optIsConfirmedAll;
		private RFMBaseClasses.RFMRadioButton optIsConfirmedNot;
		private RFMBaseClasses.RFMRadioButton optIsConfirmed;
		private RFMBaseClasses.RFMTabPage tabWayBills_Fillings;
		private RFMBaseClasses.RFMDataGridView grdWayBills_Fillings;
		private RFMBaseClasses.RFMTabPage tabFillings;
		private RFMBaseClasses.RFMLabel lblFuelTypes;
		private RFMBaseClasses.RFMDataGridView grdWayBills_Trips;
		private RFMBaseClasses.RFMPanel cntFillings;
        private RFMBaseClasses.RFMDataGridView grdFillings;
        private RFMBaseClasses.RFMTimer tmrRestore;
        private RFMBaseClasses.RFMContextToolStripMenuItem mniWayBillPrint;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniWayBillConfirm;
		private RFMBaseClasses.RFMContextToolStripMenuItem mniWayBillUnConfirm;
		public RFMBaseClasses.RFMContextMenuStrip mnuWayBillsPrint;
        public RFMBaseClasses.RFMContextMenuStrip mnuWayBillsService;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcWayBill_Trip_TripConfirmImage;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_Alias;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_DateTrip;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_TripNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_Brutto;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_PalletsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_PointsQnt;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_DurationFact;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_Note;
        private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcWayBill_Trip_ForGoodsOnly;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_ERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Trip_ID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Filling_DateFill;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Filling_FillingTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Filling_FuelTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Filling_QntFilled;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Filling_Note;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBill_Filling_ID;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Cars;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_CarsTypes;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Drivers;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_FillingsTypes;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_FuelTypes;
		private System.Windows.Forms.ToolStripSeparator tsWayBillPrintSeparator1;
        private RFMBaseClasses.RFMContextToolStripMenuItem mniWayBillPrint_ReportFuel;
        private RFMBaseClasses.RFMDataViewerEx dveReportFuelData;
        private RFMBaseClasses.RFMDataGridViewImageColumn grcWayBills_Image;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_BillNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_DateWayBeg;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_DateWayEnd;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_CarName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_DriverName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_SpeedometerDataDiff;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_FuelDataDiff;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_SpeedometerDataEnd;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_FuelDataEnd;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_Reason;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_Note;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_CarNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_CarTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_ERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBills_ID;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_DateFill;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_FillingTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_FuelTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_BillNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_CarName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_DriverName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_QntFilled;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_CarNumber;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_Amount;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_Price;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_Note;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_CarTypeName;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_ERPCode;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_ID;
	}
}