using System.Windows.Forms;

namespace Logistics
{
    partial class frmVeterinaryExportXmlEdit
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
            RFMBaseClasses.RFMDataGridViewTextBoxColumn dtcLaboratory;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.dtcNumber = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dtcDate = new RFMBaseClasses.RFMDataGridViewCalendarColumn();
            this.dtcResult = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dtcText = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            dtcLaboratory = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dtcLaboratory
            // 
            dtcLaboratory.AgrType = RFMBaseClasses.EnumAgregate.None;
            dtcLaboratory.DataPropertyName = "Laboratory";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dtcLaboratory.DefaultCellStyle = dataGridViewCellStyle1;
            dtcLaboratory.HeaderText = "Лаборатория";
            dtcLaboratory.Name = "dtcLaboratory";
            dtcLaboratory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            dtcLaboratory.Width = 120;
            // 
            // dgvData
            // 
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtcNumber,
            this.dtcDate,
            this.dtcResult,
            this.dtcText,
            dtcLaboratory});
            this.dgvData.Location = new System.Drawing.Point(10, 10);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 24;
            this.dgvData.Size = new System.Drawing.Size(578, 200);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            this.dgvData.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvData_DefaultValuesNeeded);
            // 
            // dtcNumber
            // 
            this.dtcNumber.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dtcNumber.DataPropertyName = "number";
            this.dtcNumber.HeaderText = "№";
            this.dtcNumber.Name = "dtcNumber";
            this.dtcNumber.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dtcNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dtcNumber.ToolTipText = "№ исследования";
            this.dtcNumber.Width = 80;
            // 
            // dtcDate
            // 
            this.dtcDate.DataPropertyName = "date";
            this.dtcDate.HeaderText = "Дата";
            this.dtcDate.Name = "dtcDate";
            this.dtcDate.ToolTipText = "Дата исследования";
            // 
            // dtcResult
            // 
            this.dtcResult.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dtcResult.DataPropertyName = "result";
            this.dtcResult.HeaderText = "Рез.";
            this.dtcResult.Name = "dtcResult";
            this.dtcResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dtcResult.ToolTipText = "Результат";
            this.dtcResult.Width = 50;
            // 
            // dtcText
            // 
            this.dtcText.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dtcText.DataPropertyName = "text";
            this.dtcText.HeaderText = "Текст";
            this.dtcText.Name = "dtcText";
            this.dtcText.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dtcText.ToolTipText = "Примечание";
            this.dtcText.Width = 200;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(514, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(554, 220);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmVeterinaryExportXmlEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(598, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsModalMode = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVeterinaryExportXmlEdit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные для экспорта";
            this.Load += new System.EventHandler(this.frmVeterinaryExportXmlEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvData;
        private RFMBaseClasses.RFMButton btnSave;
        private RFMBaseClasses.RFMButton btnExit;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dtcNumber;
        private RFMBaseClasses.RFMDataGridViewCalendarColumn dtcDate;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dtcResult;
        private RFMBaseClasses.RFMDataGridViewTextBoxColumn dtcText;
    }
}