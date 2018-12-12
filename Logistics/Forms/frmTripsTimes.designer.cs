namespace Logistics
{
	partial class frmTripsTimes
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
			this.btnHelp = new RFMBaseClasses.RFMButton();
			this.btnExit = new RFMBaseClasses.RFMButton();
			this.btnSave = new RFMBaseClasses.RFMButton();
			this.dtpDateTrip = new RFMBaseClasses.RFMDateTimePicker();
			this.pnlData = new RFMBaseClasses.RFMPanel();
			this.chkIsRentCar = new RFMBaseClasses.RFMCheckBox();
			this.pnlPlan = new RFMBaseClasses.RFMPanel();
			this.lblPlan = new RFMBaseClasses.RFMLabel();
			this.btnEndPlanClear = new RFMBaseClasses.RFMButton();
			this.btnBegPlanClear = new RFMBaseClasses.RFMButton();
			this.txtTimeEndPlan = new RFMBaseClasses.RFMTextBoxTime();
			this.lblEndPlan = new RFMBaseClasses.RFMLabel();
			this.txtDurationPlan = new RFMBaseClasses.RFMTextBoxTime();
			this.lbldurationDaysPlan = new RFMBaseClasses.RFMLabel();
			this.txtTimeBegPlan = new RFMBaseClasses.RFMTextBoxTime();
			this.numDurationDaysPlan = new RFMBaseClasses.RFMNumericUpDown();
			this.lblDurationPlan = new RFMBaseClasses.RFMLabel();
			this.lblBegPlan = new RFMBaseClasses.RFMLabel();
			this.txtAlias = new RFMBaseClasses.RFMTextBox();
			this.pnlFact = new RFMBaseClasses.RFMPanel();
			this.btnEndSet = new RFMBaseClasses.RFMButton();
			this.btnBegSet = new RFMBaseClasses.RFMButton();
			this.lblFact = new RFMBaseClasses.RFMLabel();
			this.btnEndClear = new RFMBaseClasses.RFMButton();
			this.btnBegClear = new RFMBaseClasses.RFMButton();
			this.txtTimeEnd = new RFMBaseClasses.RFMTextBoxTime();
			this.lblEnd = new RFMBaseClasses.RFMLabel();
			this.txtDuration = new RFMBaseClasses.RFMTextBoxTime();
			this.lblDurationDays = new RFMBaseClasses.RFMLabel();
			this.txtTimeBeg = new RFMBaseClasses.RFMTextBoxTime();
			this.numDurationDays = new RFMBaseClasses.RFMNumericUpDown();
			this.lblDuration = new RFMBaseClasses.RFMLabel();
			this.lblBeg = new RFMBaseClasses.RFMLabel();
			this.pnlData.SuspendLayout();
			this.pnlPlan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDurationDaysPlan)).BeginInit();
			this.pnlFact.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDurationDays)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHelp
			// 
			this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
			this.btnHelp.Location = new System.Drawing.Point(7, 153);
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
			this.btnExit.Location = new System.Drawing.Point(389, 153);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(32, 30);
			this.btnExit.TabIndex = 1;
			this.ttToolTip.SetToolTip(this.btnExit, "ќтказ");
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.Image = global::Logistics.Properties.Resources.Save;
			this.btnSave.Location = new System.Drawing.Point(339, 153);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(32, 30);
			this.btnSave.TabIndex = 0;
			this.ttToolTip.SetToolTip(this.btnSave, "—охранить");
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// dtpDateTrip
			// 
			this.dtpDateTrip.CustomFormat = "dd.MM.yyyy";
			this.dtpDateTrip.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.dtpDateTrip.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.dtpDateTrip.Enabled = false;
			this.dtpDateTrip.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTrip.Location = new System.Drawing.Point(3, 3);
			this.dtpDateTrip.Name = "dtpDateTrip";
			this.dtpDateTrip.Size = new System.Drawing.Size(93, 22);
			this.dtpDateTrip.TabIndex = 0;
			// 
			// pnlData
			// 
			this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlData.Controls.Add(this.chkIsRentCar);
			this.pnlData.Controls.Add(this.pnlPlan);
			this.pnlData.Controls.Add(this.txtAlias);
			this.pnlData.Controls.Add(this.pnlFact);
			this.pnlData.Controls.Add(this.dtpDateTrip);
			this.pnlData.Location = new System.Drawing.Point(4, 5);
			this.pnlData.Name = "pnlData";
			this.pnlData.Size = new System.Drawing.Size(419, 140);
			this.pnlData.TabIndex = 0;
			// 
			// chkIsRentCar
			// 
			this.chkIsRentCar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chkIsRentCar.AutoSize = true;
			this.chkIsRentCar.Enabled = false;
			this.chkIsRentCar.Location = new System.Drawing.Point(295, 4);
			this.chkIsRentCar.Name = "chkIsRentCar";
			this.chkIsRentCar.Size = new System.Drawing.Size(117, 18);
			this.chkIsRentCar.TabIndex = 1;
			this.chkIsRentCar.Text = "не наша машина";
			this.chkIsRentCar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.chkIsRentCar.UseVisualStyleBackColor = true;
			// 
			// pnlPlan
			// 
			this.pnlPlan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPlan.Controls.Add(this.lblPlan);
			this.pnlPlan.Controls.Add(this.btnEndPlanClear);
			this.pnlPlan.Controls.Add(this.btnBegPlanClear);
			this.pnlPlan.Controls.Add(this.txtTimeEndPlan);
			this.pnlPlan.Controls.Add(this.lblEndPlan);
			this.pnlPlan.Controls.Add(this.txtDurationPlan);
			this.pnlPlan.Controls.Add(this.lbldurationDaysPlan);
			this.pnlPlan.Controls.Add(this.txtTimeBegPlan);
			this.pnlPlan.Controls.Add(this.numDurationDaysPlan);
			this.pnlPlan.Controls.Add(this.lblDurationPlan);
			this.pnlPlan.Controls.Add(this.lblBegPlan);
			this.pnlPlan.Location = new System.Drawing.Point(3, 53);
			this.pnlPlan.Name = "pnlPlan";
			this.pnlPlan.Size = new System.Drawing.Size(202, 81);
			this.pnlPlan.TabIndex = 3;
			// 
			// lblPlan
			// 
			this.lblPlan.AutoSize = true;
			this.lblPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblPlan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.lblPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblPlan.Location = new System.Drawing.Point(3, 5);
			this.lblPlan.Name = "lblPlan";
			this.lblPlan.Size = new System.Drawing.Size(43, 14);
			this.lblPlan.TabIndex = 0;
			this.lblPlan.Text = "ѕлан:";
			// 
			// btnEndPlanClear
			// 
			this.btnEndPlanClear.FlatAppearance.BorderSize = 0;
			this.btnEndPlanClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEndPlanClear.Image = global::Logistics.Properties.Resources.DeleteAll;
			this.btnEndPlanClear.Location = new System.Drawing.Point(173, 52);
			this.btnEndPlanClear.Name = "btnEndPlanClear";
			this.btnEndPlanClear.Size = new System.Drawing.Size(24, 24);
			this.btnEndPlanClear.TabIndex = 13;
			this.ttToolTip.SetToolTip(this.btnEndPlanClear, "очистить");
			this.btnEndPlanClear.UseVisualStyleBackColor = true;
			this.btnEndPlanClear.Click += new System.EventHandler(this.btnEndClear_Click);
			// 
			// btnBegPlanClear
			// 
			this.btnBegPlanClear.FlatAppearance.BorderSize = 0;
			this.btnBegPlanClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBegPlanClear.Image = global::Logistics.Properties.Resources.DeleteAll;
			this.btnBegPlanClear.Location = new System.Drawing.Point(173, 2);
			this.btnBegPlanClear.Name = "btnBegPlanClear";
			this.btnBegPlanClear.Size = new System.Drawing.Size(24, 24);
			this.btnBegPlanClear.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnBegPlanClear, "очистить");
			this.btnBegPlanClear.UseVisualStyleBackColor = true;
			this.btnBegPlanClear.Click += new System.EventHandler(this.btnBegClear_Click);
			// 
			// txtTimeEndPlan
			// 
			this.txtTimeEndPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtTimeEndPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTimeEndPlan.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtTimeEndPlan.Location = new System.Drawing.Point(131, 53);
			this.txtTimeEndPlan.Name = "txtTimeEndPlan";
			this.txtTimeEndPlan.Size = new System.Drawing.Size(40, 22);
			this.txtTimeEndPlan.TabIndex = 12;
			this.txtTimeEndPlan.Text = "00:00";
			this.txtTimeEndPlan.Validated += new System.EventHandler(this.txtTimeEnd_Validated);
			// 
			// lblEndPlan
			// 
			this.lblEndPlan.AutoSize = true;
			this.lblEndPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblEndPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblEndPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblEndPlan.Location = new System.Drawing.Point(59, 55);
			this.lblEndPlan.Name = "lblEndPlan";
			this.lblEndPlan.Size = new System.Drawing.Size(68, 14);
			this.lblEndPlan.TabIndex = 11;
			this.lblEndPlan.Text = "окончание";
			// 
			// txtDurationPlan
			// 
			this.txtDurationPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtDurationPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDurationPlan.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtDurationPlan.Location = new System.Drawing.Point(131, 28);
			this.txtDurationPlan.Name = "txtDurationPlan";
			this.txtDurationPlan.Size = new System.Drawing.Size(40, 22);
			this.txtDurationPlan.TabIndex = 10;
			this.txtDurationPlan.Text = "00:00";
			this.txtDurationPlan.Validated += new System.EventHandler(this.txtDuration_Validated);
			// 
			// lbldurationDaysPlan
			// 
			this.lbldurationDaysPlan.AutoSize = true;
			this.lbldurationDaysPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lbldurationDaysPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lbldurationDaysPlan.Font = new System.Drawing.Font("Tahoma", 9F);
			this.lbldurationDaysPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbldurationDaysPlan.Location = new System.Drawing.Point(82, 31);
			this.lbldurationDaysPlan.Name = "lbldurationDaysPlan";
			this.lbldurationDaysPlan.Size = new System.Drawing.Size(54, 14);
			this.lbldurationDaysPlan.TabIndex = 9;
			this.lbldurationDaysPlan.Text = "суток + ";
			// 
			// txtTimeBegPlan
			// 
			this.txtTimeBegPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtTimeBegPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTimeBegPlan.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtTimeBegPlan.Location = new System.Drawing.Point(131, 3);
			this.txtTimeBegPlan.Name = "txtTimeBegPlan";
			this.txtTimeBegPlan.Size = new System.Drawing.Size(40, 22);
			this.txtTimeBegPlan.TabIndex = 5;
			this.txtTimeBegPlan.Text = "00:00";
			this.txtTimeBegPlan.Validated += new System.EventHandler(this.txtTimeBeg_Validated);
			// 
			// numDurationDaysPlan
			// 
			this.numDurationDaysPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numDurationDaysPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numDurationDaysPlan.IsNull = false;
			this.numDurationDaysPlan.Location = new System.Drawing.Point(47, 28);
			this.numDurationDaysPlan.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numDurationDaysPlan.Name = "numDurationDaysPlan";
			this.numDurationDaysPlan.Size = new System.Drawing.Size(34, 22);
			this.numDurationDaysPlan.TabIndex = 8;
			this.numDurationDaysPlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ttToolTip.SetToolTip(this.numDurationDaysPlan, "суток");
			// 
			// lblDurationPlan
			// 
			this.lblDurationPlan.AutoSize = true;
			this.lblDurationPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDurationPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDurationPlan.Font = new System.Drawing.Font("Tahoma", 9F);
			this.lblDurationPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDurationPlan.Location = new System.Drawing.Point(3, 31);
			this.lblDurationPlan.Name = "lblDurationPlan";
			this.lblDurationPlan.Size = new System.Drawing.Size(43, 14);
			this.lblDurationPlan.TabIndex = 7;
			this.lblDurationPlan.Text = "в пути";
			// 
			// lblBegPlan
			// 
			this.lblBegPlan.AutoSize = true;
			this.lblBegPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblBegPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblBegPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblBegPlan.Location = new System.Drawing.Point(80, 5);
			this.lblBegPlan.Name = "lblBegPlan";
			this.lblBegPlan.Size = new System.Drawing.Size(47, 14);
			this.lblBegPlan.TabIndex = 4;
			this.lblBegPlan.Text = "начало";
			// 
			// txtAlias
			// 
			this.txtAlias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtAlias.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtAlias.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtAlias.Enabled = false;
			this.txtAlias.Location = new System.Drawing.Point(3, 28);
			this.txtAlias.MaxLength = 100;
			this.txtAlias.Name = "txtAlias";
			this.txtAlias.Size = new System.Drawing.Size(410, 22);
			this.txtAlias.TabIndex = 2;
			// 
			// pnlFact
			// 
			this.pnlFact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlFact.Controls.Add(this.btnEndSet);
			this.pnlFact.Controls.Add(this.btnBegSet);
			this.pnlFact.Controls.Add(this.lblFact);
			this.pnlFact.Controls.Add(this.btnEndClear);
			this.pnlFact.Controls.Add(this.btnBegClear);
			this.pnlFact.Controls.Add(this.txtTimeEnd);
			this.pnlFact.Controls.Add(this.lblEnd);
			this.pnlFact.Controls.Add(this.txtDuration);
			this.pnlFact.Controls.Add(this.lblDurationDays);
			this.pnlFact.Controls.Add(this.txtTimeBeg);
			this.pnlFact.Controls.Add(this.numDurationDays);
			this.pnlFact.Controls.Add(this.lblDuration);
			this.pnlFact.Controls.Add(this.lblBeg);
			this.pnlFact.Location = new System.Drawing.Point(209, 53);
			this.pnlFact.Name = "pnlFact";
			this.pnlFact.Size = new System.Drawing.Size(204, 81);
			this.pnlFact.TabIndex = 4;
			// 
			// btnEndSet
			// 
			this.btnEndSet.FlatAppearance.BorderSize = 0;
			this.btnEndSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEndSet.Image = global::Logistics.Properties.Resources.Check;
			this.btnEndSet.Location = new System.Drawing.Point(109, 50);
			this.btnEndSet.Name = "btnEndSet";
			this.btnEndSet.Size = new System.Drawing.Size(24, 24);
			this.btnEndSet.TabIndex = 16;
			this.ttToolTip.SetToolTip(this.btnEndSet, "текущее");
			this.btnEndSet.UseVisualStyleBackColor = true;
			this.btnEndSet.Click += new System.EventHandler(this.btnEndSet_Click);
			// 
			// btnBegSet
			// 
			this.btnBegSet.FlatAppearance.BorderSize = 0;
			this.btnBegSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBegSet.Image = global::Logistics.Properties.Resources.Check;
			this.btnBegSet.Location = new System.Drawing.Point(109, 0);
			this.btnBegSet.Name = "btnBegSet";
			this.btnBegSet.Size = new System.Drawing.Size(24, 24);
			this.btnBegSet.TabIndex = 15;
			this.ttToolTip.SetToolTip(this.btnBegSet, "текущее");
			this.btnBegSet.UseVisualStyleBackColor = true;
			this.btnBegSet.Click += new System.EventHandler(this.btnBegSet_Click);
			// 
			// lblFact
			// 
			this.lblFact.AutoSize = true;
			this.lblFact.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblFact.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblFact.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
			this.lblFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblFact.Location = new System.Drawing.Point(3, 5);
			this.lblFact.Name = "lblFact";
			this.lblFact.Size = new System.Drawing.Size(43, 14);
			this.lblFact.TabIndex = 0;
			this.lblFact.Text = "‘акт:";
			// 
			// btnEndClear
			// 
			this.btnEndClear.FlatAppearance.BorderSize = 0;
			this.btnEndClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEndClear.Image = global::Logistics.Properties.Resources.DeleteAll;
			this.btnEndClear.Location = new System.Drawing.Point(175, 52);
			this.btnEndClear.Name = "btnEndClear";
			this.btnEndClear.Size = new System.Drawing.Size(24, 24);
			this.btnEndClear.TabIndex = 13;
			this.ttToolTip.SetToolTip(this.btnEndClear, "очистить");
			this.btnEndClear.UseVisualStyleBackColor = true;
			this.btnEndClear.Click += new System.EventHandler(this.btnEndClear_Click);
			// 
			// btnBegClear
			// 
			this.btnBegClear.FlatAppearance.BorderSize = 0;
			this.btnBegClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBegClear.Image = global::Logistics.Properties.Resources.DeleteAll;
			this.btnBegClear.Location = new System.Drawing.Point(175, 2);
			this.btnBegClear.Name = "btnBegClear";
			this.btnBegClear.Size = new System.Drawing.Size(24, 24);
			this.btnBegClear.TabIndex = 6;
			this.ttToolTip.SetToolTip(this.btnBegClear, "очистить");
			this.btnBegClear.UseVisualStyleBackColor = true;
			this.btnBegClear.Click += new System.EventHandler(this.btnBegClear_Click);
			// 
			// txtTimeEnd
			// 
			this.txtTimeEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtTimeEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTimeEnd.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtTimeEnd.Location = new System.Drawing.Point(133, 53);
			this.txtTimeEnd.Name = "txtTimeEnd";
			this.txtTimeEnd.Size = new System.Drawing.Size(40, 22);
			this.txtTimeEnd.TabIndex = 12;
			this.txtTimeEnd.Text = "00:00";
			this.txtTimeEnd.Validated += new System.EventHandler(this.txtTimeEnd_Validated);
			// 
			// lblEnd
			// 
			this.lblEnd.AutoSize = true;
			this.lblEnd.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblEnd.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblEnd.Location = new System.Drawing.Point(42, 55);
			this.lblEnd.Name = "lblEnd";
			this.lblEnd.Size = new System.Drawing.Size(68, 14);
			this.lblEnd.TabIndex = 11;
			this.lblEnd.Text = "окончание";
			// 
			// txtDuration
			// 
			this.txtDuration.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtDuration.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtDuration.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtDuration.Location = new System.Drawing.Point(133, 28);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(40, 22);
			this.txtDuration.TabIndex = 10;
			this.txtDuration.Text = "00:00";
			this.txtDuration.Validated += new System.EventHandler(this.txtDuration_Validated);
			// 
			// lblDurationDays
			// 
			this.lblDurationDays.AutoSize = true;
			this.lblDurationDays.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDurationDays.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDurationDays.Font = new System.Drawing.Font("Tahoma", 9F);
			this.lblDurationDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDurationDays.Location = new System.Drawing.Point(82, 31);
			this.lblDurationDays.Name = "lblDurationDays";
			this.lblDurationDays.Size = new System.Drawing.Size(54, 14);
			this.lblDurationDays.TabIndex = 9;
			this.lblDurationDays.Text = "суток + ";
			// 
			// txtTimeBeg
			// 
			this.txtTimeBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.txtTimeBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.txtTimeBeg.Font = new System.Drawing.Font("Tahoma", 9F);
			this.txtTimeBeg.Location = new System.Drawing.Point(133, 3);
			this.txtTimeBeg.Name = "txtTimeBeg";
			this.txtTimeBeg.Size = new System.Drawing.Size(40, 22);
			this.txtTimeBeg.TabIndex = 5;
			this.txtTimeBeg.Text = "00:00";
			this.txtTimeBeg.Validated += new System.EventHandler(this.txtTimeBeg_Validated);
			// 
			// numDurationDays
			// 
			this.numDurationDays.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.numDurationDays.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.numDurationDays.IsNull = false;
			this.numDurationDays.Location = new System.Drawing.Point(47, 28);
			this.numDurationDays.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
			this.numDurationDays.Name = "numDurationDays";
			this.numDurationDays.Size = new System.Drawing.Size(34, 22);
			this.numDurationDays.TabIndex = 8;
			this.numDurationDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ttToolTip.SetToolTip(this.numDurationDays, "суток");
			// 
			// lblDuration
			// 
			this.lblDuration.AutoSize = true;
			this.lblDuration.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblDuration.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblDuration.Font = new System.Drawing.Font("Tahoma", 9F);
			this.lblDuration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblDuration.Location = new System.Drawing.Point(3, 31);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Size = new System.Drawing.Size(43, 14);
			this.lblDuration.TabIndex = 7;
			this.lblDuration.Text = "в пути";
			// 
			// lblBeg
			// 
			this.lblBeg.AutoSize = true;
			this.lblBeg.DisabledBackColor = System.Drawing.SystemColors.Control;
			this.lblBeg.DisabledForeColor = System.Drawing.SystemColors.WindowText;
			this.lblBeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblBeg.Location = new System.Drawing.Point(63, 5);
			this.lblBeg.Name = "lblBeg";
			this.lblBeg.Size = new System.Drawing.Size(47, 14);
			this.lblBeg.TabIndex = 4;
			this.lblBeg.Text = "начало";
			// 
			// frmTripsTimes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 189);
			this.Controls.Add(this.pnlData);
			this.Controls.Add(this.btnHelp);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnSave);
			this.hpHelp.SetHelpKeyword(this, "");
			this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
			this.IsModalMode = true;
			this.MinimizeBox = false;
			this.Name = "frmTripsTimes";
			this.hpHelp.SetShowHelp(this, true);
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ƒата-врем€ начала/окончани€ рейса";
			this.Load += new System.EventHandler(this.frmTripsTimes_Load);
			this.pnlData.ResumeLayout(false);
			this.pnlData.PerformLayout();
			this.pnlPlan.ResumeLayout(false);
			this.pnlPlan.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDurationDaysPlan)).EndInit();
			this.pnlFact.ResumeLayout(false);
			this.pnlFact.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numDurationDays)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMDateTimePicker dtpDateTrip;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMPanel pnlFact;
		private RFMBaseClasses.RFMTextBox txtAlias;
		private RFMBaseClasses.RFMTextBoxTime txtDuration;
		private RFMBaseClasses.RFMLabel lblDurationDays;
		private RFMBaseClasses.RFMTextBoxTime txtTimeBeg;
		private RFMBaseClasses.RFMNumericUpDown numDurationDays;
		private RFMBaseClasses.RFMLabel lblDuration;
		private RFMBaseClasses.RFMLabel lblBeg;
		private RFMBaseClasses.RFMTextBoxTime txtTimeEnd;
		private RFMBaseClasses.RFMLabel lblEnd;
		private RFMBaseClasses.RFMButton btnEndClear;
		private RFMBaseClasses.RFMButton btnBegClear;
		private RFMBaseClasses.RFMPanel pnlPlan;
		private RFMBaseClasses.RFMButton btnEndPlanClear;
		private RFMBaseClasses.RFMButton btnBegPlanClear;
		private RFMBaseClasses.RFMTextBoxTime txtTimeEndPlan;
		private RFMBaseClasses.RFMLabel lblEndPlan;
		private RFMBaseClasses.RFMTextBoxTime txtDurationPlan;
		private RFMBaseClasses.RFMLabel lbldurationDaysPlan;
		private RFMBaseClasses.RFMTextBoxTime txtTimeBegPlan;
		private RFMBaseClasses.RFMNumericUpDown numDurationDaysPlan;
		private RFMBaseClasses.RFMLabel lblDurationPlan;
		private RFMBaseClasses.RFMLabel lblBegPlan;
		private RFMBaseClasses.RFMCheckBox chkIsRentCar;
		private RFMBaseClasses.RFMLabel lblPlan;
		private RFMBaseClasses.RFMLabel lblFact;
		private RFMBaseClasses.RFMButton btnEndSet;
		private RFMBaseClasses.RFMButton btnBegSet;

	}
}

