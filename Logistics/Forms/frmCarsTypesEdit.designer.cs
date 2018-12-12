namespace Logistics
{
	partial class frmCarsTypesEdit
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
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.txtCarTypeN‡me = new RFMBaseClasses.RFMTextBox();
            this.lblCarTypeName = new RFMBaseClasses.RFMLabel();
            this.chkActual = new RFMBaseClasses.RFMCheckBox();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(10, 80);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(400, 80);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 2;
            this.ttToolTip.SetToolTip(this.btnExit, "ŒÚÍ‡Á");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(350, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 1;
            this.ttToolTip.SetToolTip(this.btnSave, "—Óı‡ÌËÚ¸");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlData.Controls.Add(this.txtCarTypeN‡me);
            this.pnlData.Controls.Add(this.lblCarTypeName);
            this.pnlData.Controls.Add(this.chkActual);
            this.pnlData.Location = new System.Drawing.Point(5, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(430, 65);
            this.pnlData.TabIndex = 0;
            // 
            // txtCarTypeN‡me
            // 
            this.txtCarTypeN‡me.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtCarTypeN‡me.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCarTypeN‡me.Location = new System.Drawing.Point(177, 5);
            this.txtCarTypeN‡me.MaxLength = 100;
            this.txtCarTypeN‡me.Name = "txtCarTypeN‡me";
            this.txtCarTypeN‡me.Size = new System.Drawing.Size(244, 22);
            this.txtCarTypeN‡me.TabIndex = 1;
            // 
            // lblCarTypeName
            // 
            this.lblCarTypeName.AutoSize = true;
            this.lblCarTypeName.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblCarTypeName.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCarTypeName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCarTypeName.Location = new System.Drawing.Point(6, 8);
            this.lblCarTypeName.Name = "lblCarTypeName";
            this.lblCarTypeName.Size = new System.Drawing.Size(168, 14);
            this.lblCarTypeName.TabIndex = 0;
            this.lblCarTypeName.Text = "Õ‡ËÏÂÌÓ‚‡ÌËÂ ÚËÔ‡ Ï‡¯ËÌ˚";
            // 
            // chkActual
            // 
            this.chkActual.AutoSize = true;
            this.chkActual.Location = new System.Drawing.Point(177, 35);
            this.chkActual.Name = "chkActual";
            this.chkActual.Size = new System.Drawing.Size(103, 18);
            this.chkActual.TabIndex = 4;
            this.chkActual.Text = "¿ÍÚÛ‡Î¸ÌÓÒÚ¸";
            this.chkActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.chkActual.UseVisualStyleBackColor = true;
            // 
            // frmCarsTypesEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 116);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmCarsTypesEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "“ËÔ Ï‡¯ËÌ˚";
            this.Load += new System.EventHandler(this.frmCarsTypesEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMCheckBox chkActual;
        private RFMBaseClasses.RFMLabel lblCarTypeName;
        private RFMBaseClasses.RFMTextBox txtCarTypeN‡me;

	}
}

