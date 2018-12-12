namespace Logistics
{
	partial class frmGetHost
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
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(8, 38);
            this.ttToolTip.SetToolTip(this.btnHelp, "Помощь");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 38);
            // 
            // btnResume
            // 
            this.btnResume.Location = new System.Drawing.Point(203, 38);
            // 
            // cboData
            // 
            this.cboData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboData.Location = new System.Drawing.Point(8, 8);
            this.cboData.Size = new System.Drawing.Size(277, 22);
            // 
            // frmGetHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(294, 75);
            this.Name = "frmGetHost";
            this.Text = "Выбор хоста";
            this.ResumeLayout(false);

		}

		#endregion

	}
}