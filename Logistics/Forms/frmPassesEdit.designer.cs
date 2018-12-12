namespace Logistics
{
	partial class frmPassesEdit
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
            this.pnlCarData = new RFMBaseClasses.RFMPanel();
            this.btnCarSelect = new RFMBaseClasses.RFMButton();
            this.lblCarTypeName = new RFMBaseClasses.RFMLabel();
            this.txtCarTypeName = new RFMBaseClasses.RFMTextBox();
            this.lblDriverPhone = new RFMBaseClasses.RFMLabel();
            this.txtDriverPhone = new RFMBaseClasses.RFMTextBox();
            this.lblDriverDocument = new RFMBaseClasses.RFMLabel();
            this.txtDriverDocument = new RFMBaseClasses.RFMTextBox();
            this.lblDriverName = new RFMBaseClasses.RFMLabel();
            this.txtDriverName = new RFMBaseClasses.RFMTextBox();
            this.txtCarNàme = new RFMBaseClasses.RFMTextBox();
            this.lblTrailerNumber = new RFMBaseClasses.RFMLabel();
            this.txtCarNumber = new RFMBaseClasses.RFMTextBox();
            this.txtTrailerNumber = new RFMBaseClasses.RFMTextBox();
            this.lblCarNumber = new RFMBaseClasses.RFMLabel();
            this.lblCarName = new RFMBaseClasses.RFMLabel();
            this.txtNote = new RFMBaseClasses.RFMTextBox();
            this.txtReason = new RFMBaseClasses.RFMTextBox();
            this.dtpDatePass = new RFMBaseClasses.RFMDateTimePicker();
            this.lblBrutto = new RFMBaseClasses.RFMLabel();
            this.numBrutto = new RFMBaseClasses.RFMNumericUpDown();
            this.lblPalletsQnt = new RFMBaseClasses.RFMLabel();
            this.numPalletsQnt = new RFMBaseClasses.RFMNumericUpDown();
            this.pnlPartnerData = new RFMBaseClasses.RFMPanel();
            this.txtCarrierPartnerName = new RFMBaseClasses.RFMTextBox();
            this.cboCarrierPartner = new RFMBaseClasses.RFMComboBox();
            this.lblCarrierPartner = new RFMBaseClasses.RFMLabel();
            this.txtPartnerName = new RFMBaseClasses.RFMTextBox();
            this.cboPartner = new RFMBaseClasses.RFMComboBox();
            this.lblPartner = new RFMBaseClasses.RFMLabel();
            this.btnReasonSelect = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.pnlArrivalDepartureData = new RFMBaseClasses.RFMPanel();
            this.chkDeparturePlan = new RFMBaseClasses.RFMCheckBox();
            this.chkArrivalPlan = new RFMBaseClasses.RFMCheckBox();
            this.chkDepartureFact = new RFMBaseClasses.RFMCheckBox();
            this.chkArrivalFact = new RFMBaseClasses.RFMCheckBox();
            this.dtpDepartureFact = new RFMBaseClasses.RFMDateTimePicker();
            this.dtpDeparturePlan = new RFMBaseClasses.RFMDateTimePicker();
            this.dtpArrivalFact = new RFMBaseClasses.RFMDateTimePicker();
            this.dtpArrivalPlan = new RFMBaseClasses.RFMDateTimePicker();
            this.lblDepartureFact = new RFMBaseClasses.RFMLabel();
            this.lblDeparturePlan = new RFMBaseClasses.RFMLabel();
            this.lblArrivalFact = new RFMBaseClasses.RFMLabel();
            this.lblArrival = new RFMBaseClasses.RFMLabel();
            this.lblArrivalPlan = new RFMBaseClasses.RFMLabel();
            this.lblDeparture = new RFMBaseClasses.RFMLabel();
            this.pnlCarData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPalletsQnt)).BeginInit();
            this.pnlPartnerData.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.pnlArrivalDepartureData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(7, 381);
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
            this.btnExit.Location = new System.Drawing.Point(473, 381);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 7;
            this.ttToolTip.SetToolTip(this.btnExit, "Îòêàç");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(423, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnSave, "Ñîõðàíèòü");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlCarData
            // 
            this.pnlCarData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCarData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCarData.Controls.Add(this.btnCarSelect);
            this.pnlCarData.Controls.Add(this.lblCarTypeName);
            this.pnlCarData.Controls.Add(this.txtCarTypeName);
            this.pnlCarData.Controls.Add(this.lblDriverPhone);
            this.pnlCarData.Controls.Add(this.txtDriverPhone);
            this.pnlCarData.Controls.Add(this.lblDriverDocument);
            this.pnlCarData.Controls.Add(this.txtDriverDocument);
            this.pnlCarData.Controls.Add(this.lblDriverName);
            this.pnlCarData.Controls.Add(this.txtDriverName);
            this.pnlCarData.Controls.Add(this.txtCarNàme);
            this.pnlCarData.Controls.Add(this.lblTrailerNumber);
            this.pnlCarData.Controls.Add(this.txtCarNumber);
            this.pnlCarData.Controls.Add(this.txtTrailerNumber);
            this.pnlCarData.Controls.Add(this.lblCarNumber);
            this.pnlCarData.Controls.Add(this.lblCarName);
            this.pnlCarData.Location = new System.Drawing.Point(5, 29);
            this.pnlCarData.Name = "pnlCarData";
            this.pnlCarData.Size = new System.Drawing.Size(487, 105);
            this.pnlCarData.TabIndex = 3;
            // 
            // btnCarSelect
            // 
            this.btnCarSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCarSelect.FlatAppearance.BorderSize = 0;
            this.btnCarSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarSelect.Image = global::Logistics.Properties.Resources.Copy;
            this.btnCarSelect.Location = new System.Drawing.Point(2, 2);
            this.btnCarSelect.Name = "btnCarSelect";
            this.btnCarSelect.Size = new System.Drawing.Size(25, 25);
            this.btnCarSelect.TabIndex = 14;
            this.ttToolTip.SetToolTip(this.btnCarSelect, "Âûáðàòü èç ðàíåå ââåäåííûõ çíà÷åíèé");
            this.btnCarSelect.UseVisualStyleBackColor = true;
            this.btnCarSelect.Click += new System.EventHandler(this.btnCarSelect_Click);
            // 
            // lblCarTypeName
            // 
            this.lblCarTypeName.AutoSize = true;
            this.lblCarTypeName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCarTypeName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarTypeName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarTypeName.Location = new System.Drawing.Point(301, 7);
            this.lblCarTypeName.Name = "lblCarTypeName";
            this.lblCarTypeName.Size = new System.Drawing.Size(27, 14);
            this.lblCarTypeName.TabIndex = 2;
            this.lblCarTypeName.Text = "òèï";
            // 
            // txtCarTypeName
            // 
            this.txtCarTypeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarTypeName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtCarTypeName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCarTypeName.Location = new System.Drawing.Point(329, 3);
            this.txtCarTypeName.MaxLength = 100;
            this.txtCarTypeName.Name = "txtCarTypeName";
            this.txtCarTypeName.Size = new System.Drawing.Size(150, 22);
            this.txtCarTypeName.TabIndex = 3;
            // 
            // lblDriverPhone
            // 
            this.lblDriverPhone.AutoSize = true;
            this.lblDriverPhone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverPhone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverPhone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverPhone.Location = new System.Drawing.Point(270, 80);
            this.lblDriverPhone.Name = "lblDriverPhone";
            this.lblDriverPhone.Size = new System.Drawing.Size(58, 14);
            this.lblDriverPhone.TabIndex = 12;
            this.lblDriverPhone.Text = "òåëåôîí";
            // 
            // txtDriverPhone
            // 
            this.txtDriverPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDriverPhone.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriverPhone.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriverPhone.Location = new System.Drawing.Point(329, 76);
            this.txtDriverPhone.MaxLength = 200;
            this.txtDriverPhone.Name = "txtDriverPhone";
            this.txtDriverPhone.Size = new System.Drawing.Size(150, 22);
            this.txtDriverPhone.TabIndex = 13;
            // 
            // lblDriverDocument
            // 
            this.lblDriverDocument.AutoSize = true;
            this.lblDriverDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverDocument.Location = new System.Drawing.Point(3, 80);
            this.lblDriverDocument.Name = "lblDriverDocument";
            this.lblDriverDocument.Size = new System.Drawing.Size(62, 14);
            this.lblDriverDocument.TabIndex = 10;
            this.lblDriverDocument.Text = "Äîêóìåíò";
            // 
            // txtDriverDocument
            // 
            this.txtDriverDocument.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriverDocument.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriverDocument.Location = new System.Drawing.Point(119, 76);
            this.txtDriverDocument.MaxLength = 200;
            this.txtDriverDocument.Name = "txtDriverDocument";
            this.txtDriverDocument.Size = new System.Drawing.Size(150, 22);
            this.txtDriverDocument.TabIndex = 11;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDriverName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDriverName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDriverName.Location = new System.Drawing.Point(3, 55);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(61, 14);
            this.lblDriverName.TabIndex = 8;
            this.lblDriverName.Text = "Âîäèòåëü";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDriverName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtDriverName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDriverName.Location = new System.Drawing.Point(119, 52);
            this.txtDriverName.MaxLength = 200;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(360, 22);
            this.txtDriverName.TabIndex = 9;
            // 
            // txtCarNàme
            // 
            this.txtCarNàme.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtCarNàme.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCarNàme.Location = new System.Drawing.Point(119, 4);
            this.txtCarNàme.MaxLength = 100;
            this.txtCarNàme.Name = "txtCarNàme";
            this.txtCarNàme.Size = new System.Drawing.Size(150, 22);
            this.txtCarNàme.TabIndex = 1;
            // 
            // lblTrailerNumber
            // 
            this.lblTrailerNumber.AutoSize = true;
            this.lblTrailerNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblTrailerNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblTrailerNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTrailerNumber.Location = new System.Drawing.Point(273, 31);
            this.lblTrailerNumber.Name = "lblTrailerNumber";
            this.lblTrailerNumber.Size = new System.Drawing.Size(55, 14);
            this.lblTrailerNumber.TabIndex = 6;
            this.lblTrailerNumber.Text = "ïðèöåïà";
            // 
            // txtCarNumber
            // 
            this.txtCarNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtCarNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCarNumber.Location = new System.Drawing.Point(119, 28);
            this.txtCarNumber.MaxLength = 50;
            this.txtCarNumber.Name = "txtCarNumber";
            this.txtCarNumber.Size = new System.Drawing.Size(150, 22);
            this.txtCarNumber.TabIndex = 5;
            // 
            // txtTrailerNumber
            // 
            this.txtTrailerNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTrailerNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtTrailerNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTrailerNumber.Location = new System.Drawing.Point(329, 28);
            this.txtTrailerNumber.MaxLength = 50;
            this.txtTrailerNumber.Name = "txtTrailerNumber";
            this.txtTrailerNumber.Size = new System.Drawing.Size(150, 22);
            this.txtTrailerNumber.TabIndex = 7;
            // 
            // lblCarNumber
            // 
            this.lblCarNumber.AutoSize = true;
            this.lblCarNumber.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCarNumber.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarNumber.Location = new System.Drawing.Point(3, 31);
            this.lblCarNumber.Name = "lblCarNumber";
            this.lblCarNumber.Size = new System.Drawing.Size(114, 14);
            this.lblCarNumber.TabIndex = 4;
            this.lblCarNumber.Text = "Ãîñ.íîìåð ìàøèíû";
            // 
            // lblCarName
            // 
            this.lblCarName.AutoSize = true;
            this.lblCarName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCarName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCarName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarName.Location = new System.Drawing.Point(59, 7);
            this.lblCarName.Name = "lblCarName";
            this.lblCarName.Size = new System.Drawing.Size(58, 14);
            this.lblCarName.TabIndex = 0;
            this.lblCarName.Text = "Ìàøèíà";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(5, 337);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(487, 22);
            this.txtNote.TabIndex = 13;
            this.ttToolTip.SetToolTip(this.txtNote, "Ïðèìå÷àíèÿ");
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtReason.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtReason.Location = new System.Drawing.Point(100, 3);
            this.txtReason.MaxLength = 200;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(366, 22);
            this.txtReason.TabIndex = 1;
            // 
            // dtpDatePass
            // 
            this.dtpDatePass.CustomFormat = "dd.MM.yyyy";
            this.dtpDatePass.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDatePass.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDatePass.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatePass.Location = new System.Drawing.Point(3, 3);
            this.dtpDatePass.Name = "dtpDatePass";
            this.dtpDatePass.Size = new System.Drawing.Size(93, 22);
            this.dtpDatePass.TabIndex = 0;
            // 
            // lblBrutto
            // 
            this.lblBrutto.AutoSize = true;
            this.lblBrutto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblBrutto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblBrutto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBrutto.Location = new System.Drawing.Point(59, 142);
            this.lblBrutto.Name = "lblBrutto";
            this.lblBrutto.Size = new System.Drawing.Size(65, 14);
            this.lblBrutto.TabIndex = 7;
            this.lblBrutto.Text = "Áðóòòî, êã";
            // 
            // numBrutto
            // 
            this.numBrutto.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numBrutto.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numBrutto.IsNull = false;
            this.numBrutto.Location = new System.Drawing.Point(126, 138);
            this.numBrutto.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numBrutto.Name = "numBrutto";
            this.numBrutto.Size = new System.Drawing.Size(90, 22);
            this.numBrutto.TabIndex = 8;
            this.numBrutto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPalletsQnt
            // 
            this.lblPalletsQnt.AutoSize = true;
            this.lblPalletsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPalletsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPalletsQnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPalletsQnt.Location = new System.Drawing.Point(287, 142);
            this.lblPalletsQnt.Name = "lblPalletsQnt";
            this.lblPalletsQnt.Size = new System.Drawing.Size(48, 14);
            this.lblPalletsQnt.TabIndex = 9;
            this.lblPalletsQnt.Text = "Ïàëëåò";
            // 
            // numPalletsQnt
            // 
            this.numPalletsQnt.DecimalPlaces = 1;
            this.numPalletsQnt.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numPalletsQnt.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numPalletsQnt.IsNull = false;
            this.numPalletsQnt.Location = new System.Drawing.Point(336, 137);
            this.numPalletsQnt.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numPalletsQnt.Name = "numPalletsQnt";
            this.numPalletsQnt.Size = new System.Drawing.Size(90, 22);
            this.numPalletsQnt.TabIndex = 10;
            this.numPalletsQnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pnlPartnerData
            // 
            this.pnlPartnerData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPartnerData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlPartnerData.Controls.Add(this.txtCarrierPartnerName);
            this.pnlPartnerData.Controls.Add(this.cboCarrierPartner);
            this.pnlPartnerData.Controls.Add(this.lblCarrierPartner);
            this.pnlPartnerData.Controls.Add(this.txtPartnerName);
            this.pnlPartnerData.Controls.Add(this.cboPartner);
            this.pnlPartnerData.Controls.Add(this.lblPartner);
            this.pnlPartnerData.Location = new System.Drawing.Point(5, 165);
            this.pnlPartnerData.Name = "pnlPartnerData";
            this.pnlPartnerData.Size = new System.Drawing.Size(487, 107);
            this.pnlPartnerData.TabIndex = 11;
            // 
            // txtCarrierPartnerName
            // 
            this.txtCarrierPartnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarrierPartnerName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtCarrierPartnerName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCarrierPartnerName.Location = new System.Drawing.Point(119, 78);
            this.txtCarrierPartnerName.MaxLength = 200;
            this.txtCarrierPartnerName.Name = "txtCarrierPartnerName";
            this.txtCarrierPartnerName.Size = new System.Drawing.Size(360, 22);
            this.txtCarrierPartnerName.TabIndex = 5;
            // 
            // cboCarrierPartner
            // 
            this.cboCarrierPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboCarrierPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboCarrierPartner.FormattingEnabled = true;
            this.cboCarrierPartner.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboCarrierPartner.Location = new System.Drawing.Point(119, 54);
            this.cboCarrierPartner.Name = "cboCarrierPartner";
            this.cboCarrierPartner.Size = new System.Drawing.Size(172, 22);
            this.cboCarrierPartner.TabIndex = 4;
            this.cboCarrierPartner.SelectedIndexChanged += new System.EventHandler(this.cboCarrierPartner_SelectedIndexChanged);
            // 
            // lblCarrierPartner
            // 
            this.lblCarrierPartner.AutoSize = true;
            this.lblCarrierPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCarrierPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarrierPartner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarrierPartner.Location = new System.Drawing.Point(3, 58);
            this.lblCarrierPartner.Name = "lblCarrierPartner";
            this.lblCarrierPartner.Size = new System.Drawing.Size(74, 14);
            this.lblCarrierPartner.TabIndex = 3;
            this.lblCarrierPartner.Text = "Ïåðåâîç÷èê";
            // 
            // txtPartnerName
            // 
            this.txtPartnerName.AcceptsReturn = true;
            this.txtPartnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartnerName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPartnerName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPartnerName.Location = new System.Drawing.Point(119, 28);
            this.txtPartnerName.MaxLength = 200;
            this.txtPartnerName.Name = "txtPartnerName";
            this.txtPartnerName.Size = new System.Drawing.Size(360, 22);
            this.txtPartnerName.TabIndex = 2;
            // 
            // cboPartner
            // 
            this.cboPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPartner.FormattingEnabled = true;
            this.cboPartner.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboPartner.Location = new System.Drawing.Point(119, 4);
            this.cboPartner.Name = "cboPartner";
            this.cboPartner.Size = new System.Drawing.Size(172, 22);
            this.cboPartner.TabIndex = 1;
            this.cboPartner.SelectedIndexChanged += new System.EventHandler(this.cboPartner_SelectedIndexChanged);
            // 
            // lblPartner
            // 
            this.lblPartner.AutoSize = true;
            this.lblPartner.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPartner.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPartner.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPartner.Location = new System.Drawing.Point(3, 8);
            this.lblPartner.Name = "lblPartner";
            this.lblPartner.Size = new System.Drawing.Size(110, 14);
            this.lblPartner.TabIndex = 0;
            this.lblPartner.Text = "Âëàäåëåö ìàøèíû";
            // 
            // btnReasonSelect
            // 
            this.btnReasonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReasonSelect.FlatAppearance.BorderSize = 0;
            this.btnReasonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReasonSelect.Image = global::Logistics.Properties.Resources.Detail;
            this.btnReasonSelect.Location = new System.Drawing.Point(469, 1);
            this.btnReasonSelect.Name = "btnReasonSelect";
            this.btnReasonSelect.Size = new System.Drawing.Size(25, 25);
            this.btnReasonSelect.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnReasonSelect, "Âûáðàòü èç ðàíåå ââåäåííûõ çíà÷åíèé");
            this.btnReasonSelect.UseVisualStyleBackColor = true;
            this.btnReasonSelect.Click += new System.EventHandler(this.btnReasonSelect_Click);
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.pnlArrivalDepartureData);
            this.pnlData.Controls.Add(this.btnReasonSelect);
            this.pnlData.Controls.Add(this.pnlPartnerData);
            this.pnlData.Controls.Add(this.numPalletsQnt);
            this.pnlData.Controls.Add(this.lblPalletsQnt);
            this.pnlData.Controls.Add(this.numBrutto);
            this.pnlData.Controls.Add(this.lblBrutto);
            this.pnlData.Controls.Add(this.dtpDatePass);
            this.pnlData.Controls.Add(this.txtReason);
            this.pnlData.Controls.Add(this.txtNote);
            this.pnlData.Controls.Add(this.pnlCarData);
            this.pnlData.Location = new System.Drawing.Point(5, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(501, 368);
            this.pnlData.TabIndex = 0;
            // 
            // pnlArrivalDepartureData
            // 
            this.pnlArrivalDepartureData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlArrivalDepartureData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArrivalDepartureData.Controls.Add(this.chkDeparturePlan);
            this.pnlArrivalDepartureData.Controls.Add(this.chkArrivalPlan);
            this.pnlArrivalDepartureData.Controls.Add(this.chkDepartureFact);
            this.pnlArrivalDepartureData.Controls.Add(this.chkArrivalFact);
            this.pnlArrivalDepartureData.Controls.Add(this.dtpDepartureFact);
            this.pnlArrivalDepartureData.Controls.Add(this.dtpDeparturePlan);
            this.pnlArrivalDepartureData.Controls.Add(this.dtpArrivalFact);
            this.pnlArrivalDepartureData.Controls.Add(this.dtpArrivalPlan);
            this.pnlArrivalDepartureData.Controls.Add(this.lblDepartureFact);
            this.pnlArrivalDepartureData.Controls.Add(this.lblDeparturePlan);
            this.pnlArrivalDepartureData.Controls.Add(this.lblArrivalFact);
            this.pnlArrivalDepartureData.Controls.Add(this.lblArrival);
            this.pnlArrivalDepartureData.Controls.Add(this.lblArrivalPlan);
            this.pnlArrivalDepartureData.Controls.Add(this.lblDeparture);
            this.pnlArrivalDepartureData.Location = new System.Drawing.Point(5, 276);
            this.pnlArrivalDepartureData.Name = "pnlArrivalDepartureData";
            this.pnlArrivalDepartureData.Size = new System.Drawing.Size(487, 57);
            this.pnlArrivalDepartureData.TabIndex = 12;
            // 
            // chkDeparturePlan
            // 
            this.chkDeparturePlan.AutoSize = true;
            this.chkDeparturePlan.Location = new System.Drawing.Point(64, 33);
            this.chkDeparturePlan.Name = "chkDeparturePlan";
            this.chkDeparturePlan.Size = new System.Drawing.Size(15, 14);
            this.chkDeparturePlan.TabIndex = 13;
            this.chkDeparturePlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDeparturePlan.UseVisualStyleBackColor = true;
            this.chkDeparturePlan.CheckedChanged += new System.EventHandler(this.chkDeparturePlan_CheckedChanged);
            // 
            // chkArrivalPlan
            // 
            this.chkArrivalPlan.AutoSize = true;
            this.chkArrivalPlan.Location = new System.Drawing.Point(64, 8);
            this.chkArrivalPlan.Name = "chkArrivalPlan";
            this.chkArrivalPlan.Size = new System.Drawing.Size(15, 14);
            this.chkArrivalPlan.TabIndex = 12;
            this.chkArrivalPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkArrivalPlan.UseVisualStyleBackColor = true;
            this.chkArrivalPlan.CheckedChanged += new System.EventHandler(this.chkArrivalPlan_CheckedChanged);
            // 
            // chkDepartureFact
            // 
            this.chkDepartureFact.AutoSize = true;
            this.chkDepartureFact.Location = new System.Drawing.Point(284, 32);
            this.chkDepartureFact.Name = "chkDepartureFact";
            this.chkDepartureFact.Size = new System.Drawing.Size(15, 14);
            this.chkDepartureFact.TabIndex = 11;
            this.chkDepartureFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkDepartureFact.UseVisualStyleBackColor = true;
            this.chkDepartureFact.CheckedChanged += new System.EventHandler(this.chkDepartureFact_CheckedChanged);
            // 
            // chkArrivalFact
            // 
            this.chkArrivalFact.AutoSize = true;
            this.chkArrivalFact.Location = new System.Drawing.Point(284, 8);
            this.chkArrivalFact.Name = "chkArrivalFact";
            this.chkArrivalFact.Size = new System.Drawing.Size(15, 14);
            this.chkArrivalFact.TabIndex = 10;
            this.chkArrivalFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkArrivalFact.UseVisualStyleBackColor = true;
            this.chkArrivalFact.CheckedChanged += new System.EventHandler(this.chkArrivalFact_CheckedChanged);
            // 
            // dtpDepartureFact
            // 
            this.dtpDepartureFact.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDepartureFact.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDepartureFact.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDepartureFact.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDepartureFact.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureFact.Location = new System.Drawing.Point(339, 28);
            this.dtpDepartureFact.Name = "dtpDepartureFact";
            this.dtpDepartureFact.Size = new System.Drawing.Size(140, 22);
            this.dtpDepartureFact.TabIndex = 9;
            // 
            // dtpDeparturePlan
            // 
            this.dtpDeparturePlan.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDeparturePlan.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpDeparturePlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpDeparturePlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeparturePlan.Location = new System.Drawing.Point(119, 28);
            this.dtpDeparturePlan.Name = "dtpDeparturePlan";
            this.dtpDeparturePlan.Size = new System.Drawing.Size(140, 22);
            this.dtpDeparturePlan.TabIndex = 7;
            // 
            // dtpArrivalFact
            // 
            this.dtpArrivalFact.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpArrivalFact.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpArrivalFact.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpArrivalFact.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpArrivalFact.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalFact.Location = new System.Drawing.Point(339, 4);
            this.dtpArrivalFact.Name = "dtpArrivalFact";
            this.dtpArrivalFact.Size = new System.Drawing.Size(140, 22);
            this.dtpArrivalFact.TabIndex = 4;
            // 
            // dtpArrivalPlan
            // 
            this.dtpArrivalPlan.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpArrivalPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dtpArrivalPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.dtpArrivalPlan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalPlan.Location = new System.Drawing.Point(119, 4);
            this.dtpArrivalPlan.Name = "dtpArrivalPlan";
            this.dtpArrivalPlan.Size = new System.Drawing.Size(140, 22);
            this.dtpArrivalPlan.TabIndex = 2;
            // 
            // lblDepartureFact
            // 
            this.lblDepartureFact.AutoSize = true;
            this.lblDepartureFact.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDepartureFact.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDepartureFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDepartureFact.Location = new System.Drawing.Point(301, 32);
            this.lblDepartureFact.Name = "lblDepartureFact";
            this.lblDepartureFact.Size = new System.Drawing.Size(35, 14);
            this.lblDepartureFact.TabIndex = 8;
            this.lblDepartureFact.Text = "ôàêò";
            // 
            // lblDeparturePlan
            // 
            this.lblDeparturePlan.AutoSize = true;
            this.lblDeparturePlan.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDeparturePlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDeparturePlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeparturePlan.Location = new System.Drawing.Point(82, 32);
            this.lblDeparturePlan.Name = "lblDeparturePlan";
            this.lblDeparturePlan.Size = new System.Drawing.Size(34, 14);
            this.lblDeparturePlan.TabIndex = 6;
            this.lblDeparturePlan.Text = "ïëàí";
            // 
            // lblArrivalFact
            // 
            this.lblArrivalFact.AutoSize = true;
            this.lblArrivalFact.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblArrivalFact.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblArrivalFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArrivalFact.Location = new System.Drawing.Point(301, 8);
            this.lblArrivalFact.Name = "lblArrivalFact";
            this.lblArrivalFact.Size = new System.Drawing.Size(35, 14);
            this.lblArrivalFact.TabIndex = 3;
            this.lblArrivalFact.Text = "ôàêò";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblArrival.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblArrival.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArrival.Location = new System.Drawing.Point(3, 8);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(44, 14);
            this.lblArrival.TabIndex = 0;
            this.lblArrival.Text = "Âúåçä:";
            // 
            // lblArrivalPlan
            // 
            this.lblArrivalPlan.AutoSize = true;
            this.lblArrivalPlan.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblArrivalPlan.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblArrivalPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArrivalPlan.Location = new System.Drawing.Point(82, 8);
            this.lblArrivalPlan.Name = "lblArrivalPlan";
            this.lblArrivalPlan.Size = new System.Drawing.Size(34, 14);
            this.lblArrivalPlan.TabIndex = 1;
            this.lblArrivalPlan.Text = "ïëàí";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDeparture.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDeparture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDeparture.Location = new System.Drawing.Point(3, 32);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(45, 14);
            this.lblDeparture.TabIndex = 5;
            this.lblDeparture.Text = "Âûåçä:";
            // 
            // frmPassesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 417);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmPassesEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ïðîïóñê";
            this.Load += new System.EventHandler(this.frmPassesEdit_Load);
            this.pnlCarData.ResumeLayout(false);
            this.pnlCarData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBrutto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPalletsQnt)).EndInit();
            this.pnlPartnerData.ResumeLayout(false);
            this.pnlPartnerData.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.pnlArrivalDepartureData.ResumeLayout(false);
            this.pnlArrivalDepartureData.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlCarData;
		private RFMBaseClasses.RFMLabel lblDriverPhone;
		private RFMBaseClasses.RFMTextBox txtDriverPhone;
		private RFMBaseClasses.RFMLabel lblDriverDocument;
		private RFMBaseClasses.RFMTextBox txtDriverDocument;
		private RFMBaseClasses.RFMLabel lblDriverName;
		private RFMBaseClasses.RFMTextBox txtDriverName;
		private RFMBaseClasses.RFMTextBox txtCarNàme;
		private RFMBaseClasses.RFMLabel lblTrailerNumber;
		private RFMBaseClasses.RFMTextBox txtCarNumber;
		private RFMBaseClasses.RFMTextBox txtTrailerNumber;
		private RFMBaseClasses.RFMLabel lblCarNumber;
		private RFMBaseClasses.RFMLabel lblCarName;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMTextBox txtReason;
		private RFMBaseClasses.RFMDateTimePicker dtpDatePass;
		private RFMBaseClasses.RFMLabel lblBrutto;
		private RFMBaseClasses.RFMNumericUpDown numBrutto;
		private RFMBaseClasses.RFMLabel lblPalletsQnt;
		private RFMBaseClasses.RFMNumericUpDown numPalletsQnt;
		private RFMBaseClasses.RFMPanel pnlPartnerData;
		private RFMBaseClasses.RFMTextBox txtCarrierPartnerName;
		private RFMBaseClasses.RFMComboBox cboCarrierPartner;
		private RFMBaseClasses.RFMLabel lblCarrierPartner;
		private RFMBaseClasses.RFMTextBox txtPartnerName;
		private RFMBaseClasses.RFMComboBox cboPartner;
		private RFMBaseClasses.RFMLabel lblPartner;
		private RFMBaseClasses.RFMButton btnReasonSelect;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMPanel pnlArrivalDepartureData;
		private RFMBaseClasses.RFMDateTimePicker dtpDepartureFact;
		private RFMBaseClasses.RFMDateTimePicker dtpDeparturePlan;
		private RFMBaseClasses.RFMDateTimePicker dtpArrivalFact;
		private RFMBaseClasses.RFMDateTimePicker dtpArrivalPlan;
		private RFMBaseClasses.RFMLabel lblDepartureFact;
		private RFMBaseClasses.RFMLabel lblDeparturePlan;
		private RFMBaseClasses.RFMLabel lblArrivalFact;
		private RFMBaseClasses.RFMLabel lblArrival;
		private RFMBaseClasses.RFMLabel lblArrivalPlan;
		private RFMBaseClasses.RFMLabel lblDeparture;
		private RFMBaseClasses.RFMCheckBox chkDepartureFact;
		private RFMBaseClasses.RFMCheckBox chkArrivalFact;
		private RFMBaseClasses.RFMLabel lblCarTypeName;
		private RFMBaseClasses.RFMTextBox txtCarTypeName;
		private RFMBaseClasses.RFMCheckBox chkDeparturePlan;
		private RFMBaseClasses.RFMCheckBox chkArrivalPlan;
		private RFMBaseClasses.RFMButton btnCarSelect;

	}
}

