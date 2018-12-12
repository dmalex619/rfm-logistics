namespace Logistics
{
    partial class frmShowMap
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
            this.wpfElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.wfpRadMapControl = new WpfControlLibrary.TelerikRadMapControl();
            this.SuspendLayout();
            // 
            // wpfElementHost
            // 
            this.wpfElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpfElementHost.Location = new System.Drawing.Point(0, 0);
            this.wpfElementHost.Name = "wpfElementHost";
            this.wpfElementHost.Size = new System.Drawing.Size(734, 461);
            this.wpfElementHost.TabIndex = 0;
            this.wpfElementHost.Child = this.wfpRadMapControl;
            // 
            // frmShowMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.wpfElementHost);
            this.IsModalMode = true;
            this.IsOneInstance = true;
            this.IsWaitLoading = true;
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "frmShowMap";
            this.ShowInTaskbar = false;
            this.Text = "Партнеры на карте";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmShowMap_FormClosed);
            this.Load += new System.EventHandler(this.frmShowMap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost wpfElementHost;
        private WpfControlLibrary.TelerikRadMapControl wfpRadMapControl;

    }
}
