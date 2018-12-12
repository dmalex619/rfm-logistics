namespace Logistics
{
    partial class frmGetMXNames
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
            this.lblPayer = new RFMBaseClasses.RFMLabel();
            this.lblPayee = new RFMBaseClasses.RFMLabel();
            this.cboPayer = new RFMBaseClasses.RFMComboBox();
            this.cboPayee = new RFMBaseClasses.RFMComboBox();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.SuspendLayout();
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPayer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPayer.Location = new System.Drawing.Point(12, 23);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(67, 14);
            this.lblPayer.TabIndex = 0;
            this.lblPayer.Text = "Хранитель";
            // 
            // lblPayee
            // 
            this.lblPayee.AutoSize = true;
            this.lblPayee.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblPayee.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPayee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPayee.Location = new System.Drawing.Point(12, 63);
            this.lblPayee.Name = "lblPayee";
            this.lblPayee.Size = new System.Drawing.Size(97, 14);
            this.lblPayee.TabIndex = 1;
            this.lblPayee.Text = "Поклажедатель";
            // 
            // cboPayer
            // 
            this.cboPayer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboPayer.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayer.FormattingEnabled = true;
            this.cboPayer.IsMenuInclude = false;
            this.cboPayer.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboPayer.Location = new System.Drawing.Point(125, 20);
            this.cboPayer.Name = "cboPayer";
            this.cboPayer.Size = new System.Drawing.Size(450, 22);
            this.cboPayer.TabIndex = 2;
            // 
            // cboPayee
            // 
            this.cboPayee.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cboPayee.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.cboPayee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayee.FormattingEnabled = true;
            this.cboPayee.IsMenuInclude = false;
            this.cboPayee.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.cboPayee.Location = new System.Drawing.Point(125, 60);
            this.cboPayee.Name = "cboPayee";
            this.cboPayee.Size = new System.Drawing.Size(450, 22);
            this.cboPayee.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(543, 99);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 9;
            this.ttToolTip.SetToolTip(this.btnExit, "Отказ");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(493, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 8;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGetMXNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(594, 141);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboPayee);
            this.Controls.Add(this.cboPayer);
            this.Controls.Add(this.lblPayee);
            this.Controls.Add(this.lblPayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsModalMode = true;
            this.IsUseConfig = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetMXNames";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор хранителя и поклажедателя";
            this.Load += new System.EventHandler(this.frmGetMXNames_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RFMBaseClasses.RFMLabel lblPayer;
        private RFMBaseClasses.RFMLabel lblPayee;
        private RFMBaseClasses.RFMComboBox cboPayer;
        private RFMBaseClasses.RFMComboBox cboPayee;
        private RFMBaseClasses.RFMButton btnExit;
        private RFMBaseClasses.RFMButton btnSave;
    }
}
