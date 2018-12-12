namespace Logistics
{
	partial class frmPrintFormsEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintFormsEdit));
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.pnlData = new RFMBaseClasses.RFMPanel();
            this.lblPF_Type = new RFMBaseClasses.RFMLabel();
            this.txtPF_Type = new RFMBaseClasses.RFMTextBox();
            this.btnTemplateGet = new RFMBaseClasses.RFMButton();
            this.txtNote = new RFMBaseClasses.RFMTextBox();
            this.lblNote = new RFMBaseClasses.RFMLabel();
            this.lblPF_Name = new RFMBaseClasses.RFMLabel();
            this.lblLinesInPage = new RFMBaseClasses.RFMLabel();
            this.numLinesInPage = new RFMBaseClasses.RFMNumericUpDown();
            this.btnTemplateClear = new RFMBaseClasses.RFMButton();
            this.btnTemplateSet = new RFMBaseClasses.RFMButton();
            this.txtPF_Name = new RFMBaseClasses.RFMTextBox();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLinesInPage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(6, 140);
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
            this.btnExit.Location = new System.Drawing.Point(355, 140);
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
            this.btnSave.Location = new System.Drawing.Point(305, 140);
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
            this.pnlData.Controls.Add(this.lblPF_Type);
            this.pnlData.Controls.Add(this.txtPF_Type);
            this.pnlData.Controls.Add(this.btnTemplateGet);
            this.pnlData.Controls.Add(this.txtNote);
            this.pnlData.Controls.Add(this.lblNote);
            this.pnlData.Controls.Add(this.lblPF_Name);
            this.pnlData.Controls.Add(this.lblLinesInPage);
            this.pnlData.Controls.Add(this.numLinesInPage);
            this.pnlData.Controls.Add(this.btnTemplateClear);
            this.pnlData.Controls.Add(this.btnTemplateSet);
            this.pnlData.Controls.Add(this.txtPF_Name);
            this.pnlData.Location = new System.Drawing.Point(3, 4);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(386, 129);
            this.pnlData.TabIndex = 1;
            // 
            // lblPF_Type
            // 
            this.lblPF_Type.AutoSize = true;
            this.lblPF_Type.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPF_Type.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPF_Type.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPF_Type.Location = new System.Drawing.Point(2, 11);
            this.lblPF_Type.Name = "lblPF_Type";
            this.lblPF_Type.Size = new System.Drawing.Size(81, 14);
            this.lblPF_Type.TabIndex = 0;
            this.lblPF_Type.Text = "Тип шаблона";
            // 
            // txtPF_Type
            // 
            this.txtPF_Type.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPF_Type.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPF_Type.Location = new System.Drawing.Point(116, 7);
            this.txtPF_Type.MaxLength = 50;
            this.txtPF_Type.Name = "txtPF_Type";
            this.txtPF_Type.Size = new System.Drawing.Size(175, 22);
            this.txtPF_Type.TabIndex = 1;
            // 
            // btnTemplateGet
            // 
            this.btnTemplateGet.Enabled = false;
            this.btnTemplateGet.FlatAppearance.BorderSize = 0;
            this.btnTemplateGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateGet.Image = global::Logistics.Properties.Resources.FolderOut;
            this.btnTemplateGet.Location = new System.Drawing.Point(353, 36);
            this.btnTemplateGet.Name = "btnTemplateGet";
            this.btnTemplateGet.Size = new System.Drawing.Size(24, 24);
            this.btnTemplateGet.TabIndex = 6;
            this.ttToolTip.SetToolTip(this.btnTemplateGet, "Сохранить шаблон");
            this.btnTemplateGet.UseVisualStyleBackColor = true;
            this.btnTemplateGet.Click += new System.EventHandler(this.btnTemplateGet_Click);
            // 
            // txtNote
            // 
            this.txtNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNote.Location = new System.Drawing.Point(116, 97);
            this.txtNote.MaxLength = 200;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(260, 22);
            this.txtNote.TabIndex = 10;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblNote.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNote.Location = new System.Drawing.Point(2, 101);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(78, 14);
            this.lblNote.TabIndex = 9;
            this.lblNote.Text = "Примечание";
            // 
            // lblPF_Name
            // 
            this.lblPF_Name.AutoSize = true;
            this.lblPF_Name.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPF_Name.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPF_Name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPF_Name.Location = new System.Drawing.Point(2, 41);
            this.lblPF_Name.Name = "lblPF_Name";
            this.lblPF_Name.Size = new System.Drawing.Size(111, 14);
            this.lblPF_Name.TabIndex = 2;
            this.lblPF_Name.Text = "Название шаблона";
            // 
            // lblLinesInPage
            // 
            this.lblLinesInPage.AutoSize = true;
            this.lblLinesInPage.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblLinesInPage.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblLinesInPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLinesInPage.Location = new System.Drawing.Point(2, 71);
            this.lblLinesInPage.Name = "lblLinesInPage";
            this.lblLinesInPage.Size = new System.Drawing.Size(114, 14);
            this.lblLinesInPage.TabIndex = 7;
            this.lblLinesInPage.Text = "Строк на странице";
            // 
            // numLinesInPage
            // 
            this.numLinesInPage.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numLinesInPage.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numLinesInPage.IsNull = false;
            this.numLinesInPage.Location = new System.Drawing.Point(116, 67);
            this.numLinesInPage.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numLinesInPage.Name = "numLinesInPage";
            this.numLinesInPage.Size = new System.Drawing.Size(52, 22);
            this.numLinesInPage.TabIndex = 8;
            this.numLinesInPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTemplateClear
            // 
            this.btnTemplateClear.Enabled = false;
            this.btnTemplateClear.FlatAppearance.BorderSize = 0;
            this.btnTemplateClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateClear.Image = ((System.Drawing.Image)(resources.GetObject("btnTemplateClear.Image")));
            this.btnTemplateClear.Location = new System.Drawing.Point(323, 36);
            this.btnTemplateClear.Name = "btnTemplateClear";
            this.btnTemplateClear.Size = new System.Drawing.Size(24, 24);
            this.btnTemplateClear.TabIndex = 5;
            this.ttToolTip.SetToolTip(this.btnTemplateClear, "Очистить шаблон");
            this.btnTemplateClear.UseVisualStyleBackColor = true;
            this.btnTemplateClear.Click += new System.EventHandler(this.btnTemplateClear_Click);
            // 
            // btnTemplateSet
            // 
            this.btnTemplateSet.FlatAppearance.BorderSize = 0;
            this.btnTemplateSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemplateSet.Image = global::Logistics.Properties.Resources.FolderIn;
            this.btnTemplateSet.Location = new System.Drawing.Point(294, 36);
            this.btnTemplateSet.Name = "btnTemplateSet";
            this.btnTemplateSet.Size = new System.Drawing.Size(24, 24);
            this.btnTemplateSet.TabIndex = 4;
            this.ttToolTip.SetToolTip(this.btnTemplateSet, "Выбрать шаблон");
            this.btnTemplateSet.UseVisualStyleBackColor = true;
            this.btnTemplateSet.Click += new System.EventHandler(this.btnTemplateSet_Click);
            // 
            // txtPF_Name
            // 
            this.txtPF_Name.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.txtPF_Name.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPF_Name.Location = new System.Drawing.Point(116, 37);
            this.txtPF_Name.MaxLength = 50;
            this.txtPF_Name.Name = "txtPF_Name";
            this.txtPF_Name.Size = new System.Drawing.Size(175, 22);
            this.txtPF_Name.TabIndex = 3;
            // 
            // frmPrintFormsEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 175);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmPrintFormsEdit";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Шаблон";
            this.Load += new System.EventHandler(this.frmPrintFormsEdit_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLinesInPage)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMPanel pnlData;
		private RFMBaseClasses.RFMTextBox txtPF_Name;
		private RFMBaseClasses.RFMButton btnTemplateClear;
		private RFMBaseClasses.RFMButton btnTemplateSet;
		private RFMBaseClasses.RFMLabel lblLinesInPage;
		private RFMBaseClasses.RFMNumericUpDown numLinesInPage;
		private RFMBaseClasses.RFMTextBox txtNote;
		private RFMBaseClasses.RFMLabel lblNote;
		private RFMBaseClasses.RFMLabel lblPF_Name;
		private RFMBaseClasses.RFMButton btnTemplateGet;
		private RFMBaseClasses.RFMLabel lblPF_Type;
		private RFMBaseClasses.RFMTextBox txtPF_Type;

	}
}

