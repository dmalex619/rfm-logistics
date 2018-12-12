namespace Logistics
{
	partial class frmGatesHistory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGatesHistory));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tcList = new RFMBaseClasses.RFMTabControl();
			this.tabTerms = new RFMBaseClasses.RFMTabPage();
			this.cntTerms = new RFMBaseClasses.RFMPanel();
			this.tmrTimes = new RFMBaseClasses.RFMTimeRange();
			this.ucSelectRecordID_Drivers = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.ucSelectRecordID_CarsTypes = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.ucSelectRecordID_Cars = new RFMBaseClasses.RFMSelectRecordIDGrid();
			this.lblIsOtherCar = new RFMBaseClasses.RFMLabel();
			this.pnlIsOtherCar = new RFMBaseClasses.RFMPanel();
			this.optIsOtherCarAny = new RFMBaseClasses.RFMRadioButton();
			this.optIsOtherCar = new RFMBaseClasses.RFMRadioButton();
			this.optIsOtherCarNot = new RFMBaseClasses.RFMRadioButton();
			this.lblCarsOthersStatus = new RFMBaseClasses.RFMLabel();
			this.pnlCarsOthersStatus = new RFMBaseClasses.RFMPanel();
			this.optCarsOthersStatusArrivalDeparture = new RFMBaseClasses.RFMRadioButton();
			this.optCarsOthersStatusArrival = new RFMBaseClasses.RFMRadioButton();
			this.optCarsOthersStatusAll = new RFMBaseClasses.RFMRadioButton();
			this.txtDriverNameContext = new RFMBaseClasses.RFMTextBox();
			this.lblReasonContext = new RFMBaseClasses.RFMLabel();
			this.txtReasonContext = new RFMBaseClasses.RFMTextBox();
			this.lblCarNumberContext = new RFMBaseClasses.RFMLabel();
			this.txtCarNumberContext = new RFMBaseClasses.RFMTextBox();
			this.lblCarNameContext = new RFMBaseClasses.RFMLabel();
			this.txtCarNameContext = new RFMBaseClasses.RFMTextBox();
			this.lblTimes = new RFMBaseClasses.RFMLabel();
			this.lblDrivers = new RFMBaseClasses.RFMLabel();
			this.lblCars = new RFMBaseClasses.RFMLabel();
			this.lblDirection = new RFMBaseClasses.RFMLabel();
			this.pnlDirection = new RFMBaseClasses.RFMPanel();
			this.optDirectionAll = new RFMBaseClasses.RFMRadioButton();
			this.optDirectionDeparture = new RFMBaseClasses.RFMRadioButton();
			this.optDirectionArrival = new RFMBaseClasses.RFMRadioButton();
			this.lblCarsTypes = new RFMBaseClasses.RFMLabel();
			this.dtrDates = new RFMBaseClasses.RFMDateRange();
			this.btnClearTerms = new RFMBaseClasses.RFMButton();
			this.lblCarsStatus = new RFMBaseClasses.RFMLabel();
			this.pnCarsStatus = new RFMBaseClasses.RFMPanel();
			this.optCarsStatusDepartureArrival = new RFMBaseClasses.RFMRadioButton();
			this.optCarsStatusDeparture = new RFMBaseClasses.RFMRadioButton();
			this.optCarsStatusAll = new RFMBaseClasses.RFMRadioButton();
			this.lblDateGateHistory = new RFMBaseClasses.RFMLabel();
			this.txtCarTypeNameContext = new RFMBaseClasses.RFMTextBox();
			this.tabData = new RFMBaseClasses.RFMTabPage();
			this.cntData = new RFMBaseClasses.RFMPanel();
			this.grdData = new RFMBaseClasses.RFMDataGridView();
			this.grcDateCross = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTypeCross = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcIsOther = new RFMBaseClasses.RFMDataGridViewCheckBoxColumn();
			this.grcCarName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarTypeName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDriverName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcReason = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcCarWeight = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcWayBillID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcTripID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcPassID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateArrivalFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcDateDepartureFact = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_Note = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcFillings_ERPCode = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.grcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
			this.btnService = new RFMBaseClasses.RFMButton();
			this.btnPrint = new RFMBaseClasses.RFMButton();
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnDelete = new RFMBaseClasses.RFMButton();
			this.btnAdd = new RFMBaseClasses.RFMButton();
			this.btnCancel = new RFMBaseClasses.RFMButton();
			this.btnEdit = new RFMBaseClasses.RFMButton();
			this.tcList.SuspendLayout();
			this.tabTerms.SuspendLayout();
			this.cntTerms.SuspendLayout();
			this.tmrTimes.SuspendLayout();
			this.ucSelectRecordID_Drivers.SuspendLayout();
			this.ucSelectRecordID_CarsTypes.SuspendLayout();
			this.ucSelectRecordID_Cars.SuspendLayout();
			this.pnlIsOtherCar.SuspendLayout();
			this.pnlCarsOthersStatus.SuspendLayout();
			this.pnlDirection.SuspendLayout();
			this.dtrDates.SuspendLayout();
			this.pnCarsStatus.SuspendLayout();
			this.tabData.SuspendLayout();
			this.cntData.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
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
			this.cntTerms.Controls.Add(this.tmrTimes);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_Drivers);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_CarsTypes);
			this.cntTerms.Controls.Add(this.ucSelectRecordID_Cars);
			this.cntTerms.Controls.Add(this.lblIsOtherCar);
			this.cntTerms.Controls.Add(this.pnlIsOtherCar);
			this.cntTerms.Controls.Add(this.lblCarsOthersStatus);
			this.cntTerms.Controls.Add(this.pnlCarsOthersStatus);
			this.cntTerms.Controls.Add(this.txtDriverNameContext);
			this.cntTerms.Controls.Add(this.lblReasonContext);
			this.cntTerms.Controls.Add(this.txtReasonContext);
			this.cntTerms.Controls.Add(this.lblCarNumberContext);
			this.cntTerms.Controls.Add(this.txtCarNumberContext);
			this.cntTerms.Controls.Add(this.lblCarNameContext);
			this.cntTerms.Controls.Add(this.txtCarNameContext);
			this.cntTerms.Controls.Add(this.lblTimes);
			this.cntTerms.Controls.Add(this.lblDrivers);
			this.cntTerms.Controls.Add(this.lblCars);
			this.cntTerms.Controls.Add(this.lblDirection);
			this.cntTerms.Controls.Add(this.pnlDirection);
			this.cntTerms.Controls.Add(this.lblCarsTypes);
			this.cntTerms.Controls.Add(this.dtrDates);
			this.cntTerms.Controls.Add(this.btnClearTerms);
			this.cntTerms.Controls.Add(this.lblCarsStatus);
			this.cntTerms.Controls.Add(this.pnCarsStatus);
			this.cntTerms.Controls.Add(this.lblDateGateHistory);
			this.cntTerms.Controls.Add(this.txtCarTypeNameContext);
			this.cntTerms.Location = new System.Drawing.Point(0, 2);
			this.cntTerms.Name = "cntTerms";
			this.cntTerms.Size = new System.Drawing.Size(732, 400);
			this.cntTerms.TabIndex = 0;
			// 
			// tmrTimes
			// 
			this.tmrTimes.BegValue = "0:00";
			// 
			// tmrTimes.btnClear
			// 
			this.tmrTimes.BtnСlear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tmrTimes.BtnСlear.Image = ((System.Drawing.Image)(resources.GetObject("tmrTimes.btnClear.Image")));
			this.tmrTimes.BtnСlear.Location = new System.Drawing.Point(106, 4);
			this.tmrTimes.BtnСlear.Name = "btnClear";
			this.tmrTimes.BtnСlear.Size = new System.Drawing.Size(24, 22);
			this.tmrTimes.BtnСlear.TabIndex = 4;
			this.tmrTimes.BtnСlear.UseVisualStyleBackColor = true;
			this.tmrTimes.EndValue = "0:00";
			this.tmrTimes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			// 
			// tmrTimes.lblDelimiter
			// 
			this.tmrTimes.LblDelimiter.AutoSize = true;
			this.tmrTimes.LblDelimiter.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.tmrTimes.LblDelimiter.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.tmrTimes.LblDelimiter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tmrTimes.LblDelimiter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.tmrTimes.LblDelimiter.Location = new System.Drawing.Point(49, 7);
			this.tmrTimes.LblDelimiter.Name = "lblDelimiter";
			this.tmrTimes.LblDelimiter.Size = new System.Drawing.Size(13, 16);
			this.tmrTimes.LblDelimiter.TabIndex = 2;
			this.tmrTimes.LblDelimiter.Text = "-";
			this.tmrTimes.Location = new System.Drawing.Point(137, 34);
			this.tmrTimes.Name = "tmrTimes";
			this.tmrTimes.Size = new System.Drawing.Size(132, 29);
			this.tmrTimes.TabIndex = 3;
			// 
			// tmrTimes.txtBegTime
			// 
			this.tmrTimes.TxtBegTime.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.tmrTimes.TxtBegTime.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.tmrTimes.TxtBegTime.Font = new System.Drawing.Font("Tahoma", 9F);
			this.tmrTimes.TxtBegTime.Location = new System.Drawing.Point(4, 4);
			this.tmrTimes.TxtBegTime.MaxLength = 5;
			this.tmrTimes.TxtBegTime.Name = "txtBegTime";
			this.tmrTimes.TxtBegTime.Size = new System.Drawing.Size(42, 22);
			this.tmrTimes.TxtBegTime.TabIndex = 0;
			// 
			// tmrTimes.txtEndTime
			// 
			this.tmrTimes.TxtEndTime.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.tmrTimes.TxtEndTime.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.tmrTimes.TxtEndTime.Font = new System.Drawing.Font("Tahoma", 9F);
			this.tmrTimes.TxtEndTime.Location = new System.Drawing.Point(61, 4);
			this.tmrTimes.TxtEndTime.MaxLength = 5;
			this.tmrTimes.TxtEndTime.Name = "txtEndTime";
			this.tmrTimes.TxtEndTime.Size = new System.Drawing.Size(42, 22);
			this.tmrTimes.TxtEndTime.TabIndex = 1;
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
			this.ucSelectRecordID_Drivers.Location = new System.Drawing.Point(142, 297);
			this.ucSelectRecordID_Drivers.MarkedCount = 0;
			this.ucSelectRecordID_Drivers.Name = "ucSelectRecordID_Drivers";
			this.ucSelectRecordID_Drivers.Size = new System.Drawing.Size(275, 28);
			this.ucSelectRecordID_Drivers.TabIndex = 17;
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
			this.ucSelectRecordID_CarsTypes.Location = new System.Drawing.Point(142, 133);
			this.ucSelectRecordID_CarsTypes.MarkedCount = 0;
			this.ucSelectRecordID_CarsTypes.Name = "ucSelectRecordID_CarsTypes";
			this.ucSelectRecordID_CarsTypes.Size = new System.Drawing.Size(275, 28);
			this.ucSelectRecordID_CarsTypes.TabIndex = 9;
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
			this.ucSelectRecordID_Cars.Location = new System.Drawing.Point(142, 195);
			this.ucSelectRecordID_Cars.MarkedCount = 0;
			this.ucSelectRecordID_Cars.Name = "ucSelectRecordID_Cars";
			this.ucSelectRecordID_Cars.Size = new System.Drawing.Size(275, 28);
			this.ucSelectRecordID_Cars.TabIndex = 12;
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
			// lblIsOtherCar
			// 
			this.lblIsOtherCar.AutoSize = true;
			this.lblIsOtherCar.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblIsOtherCar.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblIsOtherCar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblIsOtherCar.Location = new System.Drawing.Point(4, 111);
			this.lblIsOtherCar.Name = "lblIsOtherCar";
			this.lblIsOtherCar.Size = new System.Drawing.Size(50, 14);
			this.lblIsOtherCar.TabIndex = 6;
			this.lblIsOtherCar.Text = "Машина";
			// 
			// pnlIsOtherCar
			// 
			this.pnlIsOtherCar.Controls.Add(this.optIsOtherCarAny);
			this.pnlIsOtherCar.Controls.Add(this.optIsOtherCar);
			this.pnlIsOtherCar.Controls.Add(this.optIsOtherCarNot);
			this.pnlIsOtherCar.Location = new System.Drawing.Point(139, 105);
			this.pnlIsOtherCar.Name = "pnlIsOtherCar";
			this.pnlIsOtherCar.Size = new System.Drawing.Size(249, 25);
			this.pnlIsOtherCar.TabIndex = 7;
			// 
			// optIsOtherCarAny
			// 
			this.optIsOtherCarAny.AutoSize = true;
			this.optIsOtherCarAny.Checked = true;
			this.optIsOtherCarAny.IsChanged = true;
			this.optIsOtherCarAny.Location = new System.Drawing.Point(4, 4);
			this.optIsOtherCarAny.Name = "optIsOtherCarAny";
			this.optIsOtherCarAny.Size = new System.Drawing.Size(79, 18);
			this.optIsOtherCarAny.TabIndex = 0;
			this.optIsOtherCarAny.TabStop = true;
			this.optIsOtherCarAny.Text = "не важно";
			this.optIsOtherCarAny.UseVisualStyleBackColor = true;
			// 
			// optIsOtherCar
			// 
			this.optIsOtherCar.AutoSize = true;
			this.optIsOtherCar.Location = new System.Drawing.Point(170, 4);
			this.optIsOtherCar.Name = "optIsOtherCar";
			this.optIsOtherCar.Size = new System.Drawing.Size(70, 18);
			this.optIsOtherCar.TabIndex = 2;
			this.optIsOtherCar.Text = "не наша";
			this.optIsOtherCar.UseVisualStyleBackColor = true;
			// 
			// optIsOtherCarNot
			// 
			this.optIsOtherCarNot.AutoSize = true;
			this.optIsOtherCarNot.IsChanged = true;
			this.optIsOtherCarNot.Location = new System.Drawing.Point(98, 4);
			this.optIsOtherCarNot.Name = "optIsOtherCarNot";
			this.optIsOtherCarNot.Size = new System.Drawing.Size(52, 18);
			this.optIsOtherCarNot.TabIndex = 1;
			this.optIsOtherCarNot.Text = "наша";
			this.optIsOtherCarNot.UseVisualStyleBackColor = true;
			// 
			// lblCarsOthersStatus
			// 
			this.lblCarsOthersStatus.AutoSize = true;
			this.lblCarsOthersStatus.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarsOthersStatus.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarsOthersStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarsOthersStatus.Location = new System.Drawing.Point(458, 95);
			this.lblCarsOthersStatus.Name = "lblCarsOthersStatus";
			this.lblCarsOthersStatus.Size = new System.Drawing.Size(150, 14);
			this.lblCarsOthersStatus.TabIndex = 23;
			this.lblCarsOthersStatus.Text = "Состояние других машин";
			// 
			// pnlCarsOthersStatus
			// 
			this.pnlCarsOthersStatus.Controls.Add(this.optCarsOthersStatusArrivalDeparture);
			this.pnlCarsOthersStatus.Controls.Add(this.optCarsOthersStatusArrival);
			this.pnlCarsOthersStatus.Controls.Add(this.optCarsOthersStatusAll);
			this.pnlCarsOthersStatus.Location = new System.Drawing.Point(465, 111);
			this.pnlCarsOthersStatus.Name = "pnlCarsOthersStatus";
			this.pnlCarsOthersStatus.Size = new System.Drawing.Size(214, 61);
			this.pnlCarsOthersStatus.TabIndex = 24;
			// 
			// optCarsOthersStatusArrivalDeparture
			// 
			this.optCarsOthersStatusArrivalDeparture.AutoSize = true;
			this.optCarsOthersStatusArrivalDeparture.Location = new System.Drawing.Point(4, 40);
			this.optCarsOthersStatusArrivalDeparture.Name = "optCarsOthersStatusArrivalDeparture";
			this.optCarsOthersStatusArrivalDeparture.Size = new System.Drawing.Size(98, 18);
			this.optCarsOthersStatusArrivalDeparture.TabIndex = 3;
			this.optCarsOthersStatusArrivalDeparture.Text = "машина ушла";
			this.optCarsOthersStatusArrivalDeparture.UseVisualStyleBackColor = true;
			// 
			// optCarsOthersStatusArrival
			// 
			this.optCarsOthersStatusArrival.AutoSize = true;
			this.optCarsOthersStatusArrival.Location = new System.Drawing.Point(4, 21);
			this.optCarsOthersStatusArrival.Name = "optCarsOthersStatusArrival";
			this.optCarsOthersStatusArrival.Size = new System.Drawing.Size(113, 18);
			this.optCarsOthersStatusArrival.TabIndex = 2;
			this.optCarsOthersStatusArrival.Text = "машина на базе";
			this.optCarsOthersStatusArrival.UseVisualStyleBackColor = true;
			// 
			// optCarsOthersStatusAll
			// 
			this.optCarsOthersStatusAll.AutoSize = true;
			this.optCarsOthersStatusAll.Checked = true;
			this.optCarsOthersStatusAll.IsChanged = true;
			this.optCarsOthersStatusAll.Location = new System.Drawing.Point(4, 2);
			this.optCarsOthersStatusAll.Name = "optCarsOthersStatusAll";
			this.optCarsOthersStatusAll.Size = new System.Drawing.Size(79, 18);
			this.optCarsOthersStatusAll.TabIndex = 0;
			this.optCarsOthersStatusAll.TabStop = true;
			this.optCarsOthersStatusAll.Text = "не важно";
			this.optCarsOthersStatusAll.UseVisualStyleBackColor = true;
			// 
			// txtDriverNameContext
			// 
			this.txtDriverNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtDriverNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDriverNameContext.Location = new System.Drawing.Point(142, 326);
			this.txtDriverNameContext.Name = "txtDriverNameContext";
			this.txtDriverNameContext.Size = new System.Drawing.Size(220, 22);
			this.txtDriverNameContext.TabIndex = 18;
			// 
			// lblReasonContext
			// 
			this.lblReasonContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblReasonContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblReasonContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblReasonContext.Location = new System.Drawing.Point(4, 363);
			this.lblReasonContext.Name = "lblReasonContext";
			this.lblReasonContext.Size = new System.Drawing.Size(126, 31);
			this.lblReasonContext.TabIndex = 19;
			this.lblReasonContext.Text = "Цель поездки (контекст)";
			// 
			// txtReasonContext
			// 
			this.txtReasonContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtReasonContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtReasonContext.Location = new System.Drawing.Point(142, 365);
			this.txtReasonContext.Name = "txtReasonContext";
			this.txtReasonContext.Size = new System.Drawing.Size(220, 22);
			this.txtReasonContext.TabIndex = 20;
			// 
			// lblCarNumberContext
			// 
			this.lblCarNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarNumberContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarNumberContext.Location = new System.Drawing.Point(4, 253);
			this.lblCarNumberContext.Name = "lblCarNumberContext";
			this.lblCarNumberContext.Size = new System.Drawing.Size(131, 30);
			this.lblCarNumberContext.TabIndex = 14;
			this.lblCarNumberContext.Text = "Гос.номер машины (контекст)";
			// 
			// txtCarNumberContext
			// 
			this.txtCarNumberContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNumberContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNumberContext.Location = new System.Drawing.Point(142, 255);
			this.txtCarNumberContext.Name = "txtCarNumberContext";
			this.txtCarNumberContext.Size = new System.Drawing.Size(220, 22);
			this.txtCarNumberContext.TabIndex = 15;
			// 
			// lblCarNameContext
			// 
			this.lblCarNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarNameContext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarNameContext.Location = new System.Drawing.Point(4, 226);
			this.lblCarNameContext.Name = "lblCarNameContext";
			this.lblCarNameContext.Size = new System.Drawing.Size(138, 28);
			this.lblCarNameContext.TabIndex = 13;
			this.lblCarNameContext.Text = "Наименование машины (контекст) ";
			// 
			// txtCarNameContext
			// 
			this.txtCarNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarNameContext.Location = new System.Drawing.Point(142, 228);
			this.txtCarNameContext.Name = "txtCarNameContext";
			this.txtCarNameContext.Size = new System.Drawing.Size(220, 22);
			this.txtCarNameContext.TabIndex = 13;
			// 
			// lblTimes
			// 
			this.lblTimes.AutoSize = true;
			this.lblTimes.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblTimes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblTimes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblTimes.Location = new System.Drawing.Point(4, 43);
			this.lblTimes.Name = "lblTimes";
			this.lblTimes.Size = new System.Drawing.Size(43, 14);
			this.lblTimes.TabIndex = 2;
			this.lblTimes.Text = "Время";
			// 
			// lblDrivers
			// 
			this.lblDrivers.AutoSize = true;
			this.lblDrivers.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDrivers.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDrivers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDrivers.Location = new System.Drawing.Point(4, 308);
			this.lblDrivers.Name = "lblDrivers";
			this.lblDrivers.Size = new System.Drawing.Size(61, 14);
			this.lblDrivers.TabIndex = 16;
			this.lblDrivers.Text = "Водитель";
			// 
			// lblCars
			// 
			this.lblCars.AutoSize = true;
			this.lblCars.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCars.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCars.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCars.Location = new System.Drawing.Point(4, 205);
			this.lblCars.Name = "lblCars";
			this.lblCars.Size = new System.Drawing.Size(81, 14);
			this.lblCars.TabIndex = 11;
			this.lblCars.Text = "Машина наша";
			// 
			// lblDirection
			// 
			this.lblDirection.AutoSize = true;
			this.lblDirection.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDirection.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDirection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDirection.Location = new System.Drawing.Point(4, 75);
			this.lblDirection.Name = "lblDirection";
			this.lblDirection.Size = new System.Drawing.Size(82, 14);
			this.lblDirection.TabIndex = 4;
			this.lblDirection.Text = "Направление";
			// 
			// pnlDirection
			// 
			this.pnlDirection.Controls.Add(this.optDirectionAll);
			this.pnlDirection.Controls.Add(this.optDirectionDeparture);
			this.pnlDirection.Controls.Add(this.optDirectionArrival);
			this.pnlDirection.Location = new System.Drawing.Point(139, 69);
			this.pnlDirection.Name = "pnlDirection";
			this.pnlDirection.Size = new System.Drawing.Size(249, 25);
			this.pnlDirection.TabIndex = 5;
			// 
			// optDirectionAll
			// 
			this.optDirectionAll.AutoSize = true;
			this.optDirectionAll.Checked = true;
			this.optDirectionAll.IsChanged = true;
			this.optDirectionAll.Location = new System.Drawing.Point(4, 4);
			this.optDirectionAll.Name = "optDirectionAll";
			this.optDirectionAll.Size = new System.Drawing.Size(79, 18);
			this.optDirectionAll.TabIndex = 0;
			this.optDirectionAll.TabStop = true;
			this.optDirectionAll.Text = "не важно";
			this.optDirectionAll.UseVisualStyleBackColor = true;
			// 
			// optDirectionDeparture
			// 
			this.optDirectionDeparture.AutoSize = true;
			this.optDirectionDeparture.Location = new System.Drawing.Point(170, 4);
			this.optDirectionDeparture.Name = "optDirectionDeparture";
			this.optDirectionDeparture.Size = new System.Drawing.Size(58, 18);
			this.optDirectionDeparture.TabIndex = 2;
			this.optDirectionDeparture.Text = "выезд";
			this.optDirectionDeparture.UseVisualStyleBackColor = true;
			// 
			// optDirectionArrival
			// 
			this.optDirectionArrival.AutoSize = true;
			this.optDirectionArrival.IsChanged = true;
			this.optDirectionArrival.Location = new System.Drawing.Point(98, 4);
			this.optDirectionArrival.Name = "optDirectionArrival";
			this.optDirectionArrival.Size = new System.Drawing.Size(57, 18);
			this.optDirectionArrival.TabIndex = 1;
			this.optDirectionArrival.Text = "въезд";
			this.optDirectionArrival.UseVisualStyleBackColor = true;
			// 
			// lblCarsTypes
			// 
			this.lblCarsTypes.AutoSize = true;
			this.lblCarsTypes.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarsTypes.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarsTypes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarsTypes.Location = new System.Drawing.Point(4, 142);
			this.lblCarsTypes.Name = "lblCarsTypes";
			this.lblCarsTypes.Size = new System.Drawing.Size(77, 14);
			this.lblCarsTypes.TabIndex = 8;
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
			this.btnClearTerms.TabIndex = 19;
			this.ttToolTip.SetToolTip(this.btnClearTerms, "Очистить условия");
			this.btnClearTerms.Click += new System.EventHandler(this.btnClearTerms_Click);
			// 
			// lblCarsStatus
			// 
			this.lblCarsStatus.AutoSize = true;
			this.lblCarsStatus.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblCarsStatus.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblCarsStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblCarsStatus.Location = new System.Drawing.Point(458, 11);
			this.lblCarsStatus.Name = "lblCarsStatus";
			this.lblCarsStatus.Size = new System.Drawing.Size(146, 14);
			this.lblCarsStatus.TabIndex = 21;
			this.lblCarsStatus.Text = "Состояние наших машин";
			// 
			// pnCarsStatus
			// 
			this.pnCarsStatus.Controls.Add(this.optCarsStatusDepartureArrival);
			this.pnCarsStatus.Controls.Add(this.optCarsStatusDeparture);
			this.pnCarsStatus.Controls.Add(this.optCarsStatusAll);
			this.pnCarsStatus.Location = new System.Drawing.Point(465, 27);
			this.pnCarsStatus.Name = "pnCarsStatus";
			this.pnCarsStatus.Size = new System.Drawing.Size(214, 61);
			this.pnCarsStatus.TabIndex = 22;
			// 
			// optCarsStatusDepartureArrival
			// 
			this.optCarsStatusDepartureArrival.AutoSize = true;
			this.optCarsStatusDepartureArrival.Location = new System.Drawing.Point(4, 40);
			this.optCarsStatusDepartureArrival.Name = "optCarsStatusDepartureArrival";
			this.optCarsStatusDepartureArrival.Size = new System.Drawing.Size(113, 18);
			this.optCarsStatusDepartureArrival.TabIndex = 3;
			this.optCarsStatusDepartureArrival.Text = "машина пришла";
			this.optCarsStatusDepartureArrival.UseVisualStyleBackColor = true;
			// 
			// optCarsStatusDeparture
			// 
			this.optCarsStatusDeparture.AutoSize = true;
			this.optCarsStatusDeparture.Location = new System.Drawing.Point(4, 21);
			this.optCarsStatusDeparture.Name = "optCarsStatusDeparture";
			this.optCarsStatusDeparture.Size = new System.Drawing.Size(121, 18);
			this.optCarsStatusDeparture.TabIndex = 2;
			this.optCarsStatusDeparture.Text = "машина вне базы";
			this.optCarsStatusDeparture.UseVisualStyleBackColor = true;
			// 
			// optCarsStatusAll
			// 
			this.optCarsStatusAll.AutoSize = true;
			this.optCarsStatusAll.Checked = true;
			this.optCarsStatusAll.IsChanged = true;
			this.optCarsStatusAll.Location = new System.Drawing.Point(4, 2);
			this.optCarsStatusAll.Name = "optCarsStatusAll";
			this.optCarsStatusAll.Size = new System.Drawing.Size(79, 18);
			this.optCarsStatusAll.TabIndex = 0;
			this.optCarsStatusAll.TabStop = true;
			this.optCarsStatusAll.Text = "не важно";
			this.optCarsStatusAll.UseVisualStyleBackColor = true;
			// 
			// lblDateGateHistory
			// 
			this.lblDateGateHistory.AutoSize = true;
			this.lblDateGateHistory.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDateGateHistory.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDateGateHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDateGateHistory.Location = new System.Drawing.Point(4, 11);
			this.lblDateGateHistory.Name = "lblDateGateHistory";
			this.lblDateGateHistory.Size = new System.Drawing.Size(33, 14);
			this.lblDateGateHistory.TabIndex = 0;
			this.lblDateGateHistory.Text = "Дата";
			// 
			// txtCarTypeNameContext
			// 
			this.txtCarTypeNameContext.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtCarTypeNameContext.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtCarTypeNameContext.Location = new System.Drawing.Point(142, 162);
			this.txtCarTypeNameContext.Name = "txtCarTypeNameContext";
			this.txtCarTypeNameContext.Size = new System.Drawing.Size(220, 22);
			this.txtCarTypeNameContext.TabIndex = 10;
			// 
			// tabData
			// 
			this.tabData.Controls.Add(this.cntData);
			this.tabData.Location = new System.Drawing.Point(4, 23);
			this.tabData.Name = "tabData";
			this.tabData.Padding = new System.Windows.Forms.Padding(3);
			this.tabData.Size = new System.Drawing.Size(733, 403);
			this.tabData.TabIndex = 1;
			this.tabData.Text = "Данные";
			this.tabData.UseVisualStyleBackColor = true;
			// 
			// cntData
			// 
			this.cntData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.cntData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.cntData.Controls.Add(this.grdData);
			this.cntData.Location = new System.Drawing.Point(0, 2);
			this.cntData.Name = "cntData";
			this.cntData.Size = new System.Drawing.Size(732, 400);
			this.cntData.TabIndex = 1;
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
            this.grcDateCross,
            this.grcTypeCross,
            this.grcIsOther,
            this.grcCarName,
            this.grcCarNumber,
            this.grcCarTypeName,
            this.grcDriverName,
            this.grcReason,
            this.grcCarWeight,
            this.grcWayBillID,
            this.grcTripID,
            this.grcPassID,
            this.grcDateArrivalFact,
            this.grcDateDepartureFact,
            this.grcFillings_Note,
            this.grcFillings_ERPCode,
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
			this.grdData.Size = new System.Drawing.Size(728, 396);
			this.grdData.TabIndex = 14;
			this.grdData.CurrentRowChanged += new RFMBaseClasses.RFMDataGridView.CurrentRowChangedEventHandler(this.grdData_CurrentRowChanged);
			// 
			// grcDateCross
			// 
			this.grcDateCross.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateCross.DataPropertyName = "DateCross";
			this.grcDateCross.HeaderText = "Дата-время";
			this.grcDateCross.Name = "grcDateCross";
			this.grcDateCross.ReadOnly = true;
			this.grcDateCross.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateCross.Width = 110;
			// 
			// grcTypeCross
			// 
			this.grcTypeCross.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTypeCross.DataPropertyName = "TypeCross";
			this.grcTypeCross.HeaderText = "Напр.";
			this.grcTypeCross.Name = "grcTypeCross";
			this.grcTypeCross.ReadOnly = true;
			this.grcTypeCross.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTypeCross.ToolTipText = "Направление движения";
			this.grcTypeCross.Width = 60;
			// 
			// grcIsOther
			// 
			this.grcIsOther.DataPropertyName = "IsOtherCar";
			this.grcIsOther.HeaderText = "Проч.";
			this.grcIsOther.Name = "grcIsOther";
			this.grcIsOther.ReadOnly = true;
			this.grcIsOther.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcIsOther.ToolTipText = "Прочая машина (не наша), разовый въезд/выезд";
			this.grcIsOther.Width = 50;
			// 
			// grcCarName
			// 
			this.grcCarName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarName.DataPropertyName = "CarName";
			this.grcCarName.HeaderText = "Машина";
			this.grcCarName.Name = "grcCarName";
			this.grcCarName.ReadOnly = true;
			this.grcCarName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcCarNumber
			// 
			this.grcCarNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarNumber.DataPropertyName = "CarNumber";
			this.grcCarNumber.HeaderText = "Гос.номер";
			this.grcCarNumber.Name = "grcCarNumber";
			this.grcCarNumber.ReadOnly = true;
			this.grcCarNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
			// grcDriverName
			// 
			this.grcDriverName.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDriverName.DataPropertyName = "DriverName";
			this.grcDriverName.HeaderText = "Водитель";
			this.grcDriverName.Name = "grcDriverName";
			this.grcDriverName.ReadOnly = true;
			this.grcDriverName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			// 
			// grcReason
			// 
			this.grcReason.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcReason.DataPropertyName = "Reason";
			this.grcReason.HeaderText = "Причина";
			this.grcReason.Name = "grcReason";
			this.grcReason.ReadOnly = true;
			this.grcReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcReason.Width = 150;
			// 
			// grcCarWeight
			// 
			this.grcCarWeight.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcCarWeight.DataPropertyName = "CarWeight";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "### ###";
			this.grcCarWeight.DefaultCellStyle = dataGridViewCellStyle2;
			this.grcCarWeight.HeaderText = "Вес";
			this.grcCarWeight.Name = "grcCarWeight";
			this.grcCarWeight.ReadOnly = true;
			this.grcCarWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcCarWeight.ToolTipText = "Вес машины при пересечении ворот, кг";
			this.grcCarWeight.Width = 60;
			// 
			// grcWayBillID
			// 
			this.grcWayBillID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcWayBillID.DataPropertyName = "WayBillID";
			this.grcWayBillID.HeaderText = "Пут.лист";
			this.grcWayBillID.Name = "grcWayBillID";
			this.grcWayBillID.ReadOnly = true;
			this.grcWayBillID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcWayBillID.Width = 70;
			// 
			// grcTripID
			// 
			this.grcTripID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcTripID.DataPropertyName = "TripID";
			this.grcTripID.HeaderText = "Рейс";
			this.grcTripID.Name = "grcTripID";
			this.grcTripID.ReadOnly = true;
			this.grcTripID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcTripID.Width = 70;
			// 
			// grcPassID
			// 
			this.grcPassID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcPassID.DataPropertyName = "PassID";
			this.grcPassID.HeaderText = "Пропуск";
			this.grcPassID.Name = "grcPassID";
			this.grcPassID.ReadOnly = true;
			this.grcPassID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcPassID.Width = 70;
			// 
			// grcDateArrivalFact
			// 
			this.grcDateArrivalFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateArrivalFact.DataPropertyName = "DateArrivalFact";
			this.grcDateArrivalFact.HeaderText = "Нач.";
			this.grcDateArrivalFact.Name = "grcDateArrivalFact";
			this.grcDateArrivalFact.ReadOnly = true;
			this.grcDateArrivalFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateArrivalFact.ToolTipText = "Наша машина: дата-время начала рейса; другая машина - дата-время въезда";
			this.grcDateArrivalFact.Width = 110;
			// 
			// grcDateDepartureFact
			// 
			this.grcDateDepartureFact.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcDateDepartureFact.DataPropertyName = "DateDepartureFact";
			this.grcDateDepartureFact.HeaderText = "Кон.";
			this.grcDateDepartureFact.Name = "grcDateDepartureFact";
			this.grcDateDepartureFact.ReadOnly = true;
			this.grcDateDepartureFact.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcDateDepartureFact.ToolTipText = "Наша машина: дата-время окончания рейса; другая машина - дата-время выезда";
			this.grcDateDepartureFact.Width = 110;
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
			// grcID
			// 
			this.grcID.AgrType = RFMBaseClasses.EnumAgregate.None;
			this.grcID.DataPropertyName = "ID";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.grcID.DefaultCellStyle = dataGridViewCellStyle3;
			this.grcID.HeaderText = "ID";
			this.grcID.Name = "grcID";
			this.grcID.ReadOnly = true;
			this.grcID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.grcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
			this.grcID.ToolTipText = "Код заправки";
			this.grcID.Width = 50;
			// 
			// btnService
			// 
			this.btnService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnService.Enabled = false;
			this.btnService.Image = global::Logistics.Properties.Resources.Service;
			this.btnService.Location = new System.Drawing.Point(656, 439);
			this.btnService.Name = "btnService";
			this.btnService.Size = new System.Drawing.Size(30, 30);
			this.btnService.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnService, "Дополнительно");
			this.btnService.UseVisualStyleBackColor = true;
			this.btnService.Click += new System.EventHandler(this.btnService_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.Image = global::Logistics.Properties.Resources.Print;
			this.btnPrint.Location = new System.Drawing.Point(606, 439);
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
			// frmGatesHistory
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
			this.IsWaitLoading = true;
			this.MinimumSize = new System.Drawing.Size(750, 501);
			this.Name = "frmGatesHistory";
			this.hpHelp.SetShowHelp(this, true);
			this.Text = "Пересечения ворот";
			this.Load += new System.EventHandler(this.frmGatesHistory_Load);
			this.tcList.ResumeLayout(false);
			this.tabTerms.ResumeLayout(false);
			this.cntTerms.ResumeLayout(false);
			this.cntTerms.PerformLayout();
			this.tmrTimes.ResumeLayout(false);
			this.tmrTimes.PerformLayout();
			this.ucSelectRecordID_Drivers.ResumeLayout(false);
			this.ucSelectRecordID_Drivers.PerformLayout();
			this.ucSelectRecordID_CarsTypes.ResumeLayout(false);
			this.ucSelectRecordID_CarsTypes.PerformLayout();
			this.ucSelectRecordID_Cars.ResumeLayout(false);
			this.ucSelectRecordID_Cars.PerformLayout();
			this.pnlIsOtherCar.ResumeLayout(false);
			this.pnlIsOtherCar.PerformLayout();
			this.pnlCarsOthersStatus.ResumeLayout(false);
			this.pnlCarsOthersStatus.PerformLayout();
			this.pnlDirection.ResumeLayout(false);
			this.pnlDirection.PerformLayout();
			this.dtrDates.ResumeLayout(false);
			this.dtrDates.PerformLayout();
			this.pnCarsStatus.ResumeLayout(false);
			this.pnCarsStatus.PerformLayout();
			this.tabData.ResumeLayout(false);
			this.cntData.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
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
		private RFMBaseClasses.RFMButton btnClearTerms;
		private RFMBaseClasses.RFMPanel cntTerms;
		private RFMBaseClasses.RFMLabel lblCarsStatus;
		private RFMBaseClasses.RFMPanel pnCarsStatus;
		private RFMBaseClasses.RFMRadioButton optCarsStatusDeparture;
		private RFMBaseClasses.RFMRadioButton optCarsStatusAll;
		private RFMBaseClasses.RFMLabel lblDateGateHistory;
		private RFMBaseClasses.RFMDateRange dtrDates;
		private RFMBaseClasses.RFMLabel lblCarsTypes;
		private RFMBaseClasses.RFMPanel pnlDirection;
		private RFMBaseClasses.RFMRadioButton optDirectionAll;
		private RFMBaseClasses.RFMRadioButton optDirectionDeparture;
		private RFMBaseClasses.RFMRadioButton optDirectionArrival;
		private RFMBaseClasses.RFMLabel lblDirection;
		private RFMBaseClasses.RFMLabel lblCars;
		private RFMBaseClasses.RFMLabel lblDrivers;
		private RFMBaseClasses.RFMRadioButton optCarsStatusDepartureArrival;
		private RFMBaseClasses.RFMLabel lblTimes;
		private RFMBaseClasses.RFMLabel lblCarNumberContext;
		private RFMBaseClasses.RFMTextBox txtCarNumberContext;
		private RFMBaseClasses.RFMLabel lblCarNameContext;
		private RFMBaseClasses.RFMTextBox txtCarNameContext;
		private RFMBaseClasses.RFMLabel lblReasonContext;
		private RFMBaseClasses.RFMTextBox txtReasonContext;
		private RFMBaseClasses.RFMTextBox txtDriverNameContext;
		private RFMBaseClasses.RFMLabel lblCarsOthersStatus;
		private RFMBaseClasses.RFMPanel pnlCarsOthersStatus;
		private RFMBaseClasses.RFMRadioButton optCarsOthersStatusArrivalDeparture;
		private RFMBaseClasses.RFMRadioButton optCarsOthersStatusArrival;
		private RFMBaseClasses.RFMRadioButton optCarsOthersStatusAll;
		private RFMBaseClasses.RFMPanel cntData;
		private RFMBaseClasses.RFMDataGridView grdData;
		private RFMBaseClasses.RFMTextBox txtCarTypeNameContext;
		private RFMBaseClasses.RFMLabel lblIsOtherCar;
		private RFMBaseClasses.RFMPanel pnlIsOtherCar;
		private RFMBaseClasses.RFMRadioButton optIsOtherCarAny;
		private RFMBaseClasses.RFMRadioButton optIsOtherCar;
		private RFMBaseClasses.RFMRadioButton optIsOtherCarNot;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateCross;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTypeCross;
		private RFMBaseClasses.RFMDataGridViewCheckBoxColumn grcIsOther;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarNumber;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarTypeName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDriverName;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcReason;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcCarWeight;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcWayBillID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcTripID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcPassID;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateArrivalFact;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcDateDepartureFact;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_Note;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcFillings_ERPCode;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn grcID;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Drivers;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_CarsTypes;
		private RFMBaseClasses.RFMSelectRecordIDGrid ucSelectRecordID_Cars;
		private RFMBaseClasses.RFMTimeRange tmrTimes;
	}
}