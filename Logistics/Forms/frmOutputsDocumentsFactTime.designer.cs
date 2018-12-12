namespace Logistics
{
	partial class frmOutputsDocumentsFactTime
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvOutputsDocuments = new RFMBaseClasses.RFMDataGridView();
            this.dgvcIsBroughtImage = new RFMBaseClasses.RFMDataGridViewImageColumn();
            this.dgvcDateOutput = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcPartnerTargetName = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcTimeBeg = new RFMBaseClasses.RFMDataGridViewTextBoxTimeColumn();
            this.dgvcTimeEnd = new RFMBaseClasses.RFMDataGridViewTextBoxTimeColumn();
            this.dgvcDurationMinutesFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcDeliveryAddress = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcAmount = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcBrutto = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.dgvcID = new RFMBaseClasses.RFMDataGridViewTextBoxColumn();
            this.btnHelp = new RFMBaseClasses.RFMButton();
            this.btnExit = new RFMBaseClasses.RFMButton();
            this.btnSave = new RFMBaseClasses.RFMButton();
            this.lblDistance = new RFMBaseClasses.RFMLabel();
            this.numDistance = new RFMBaseClasses.RFMNumericUpDown();
            this.lblDistance1 = new RFMBaseClasses.RFMLabel();
            this.lblOutInTime = new RFMBaseClasses.RFMLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputsDocuments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOutputsDocuments
            // 
            this.dgvOutputsDocuments.AllowUserToAddRows = false;
            this.dgvOutputsDocuments.AllowUserToDeleteRows = false;
            this.dgvOutputsDocuments.AllowUserToOrderColumns = true;
            this.dgvOutputsDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOutputsDocuments.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOutputsDocuments.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOutputsDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOutputsDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutputsDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvcIsBroughtImage,
            this.dgvcDateOutput,
            this.dgvcPartnerTargetName,
            this.dgvcTimeBeg,
            this.dgvcTimeEnd,
            this.dgvcDurationMinutesFact,
            this.dgvcDeliveryAddress,
            this.dgvcAmount,
            this.dgvcBrutto,
            this.dgvcID});
            this.dgvOutputsDocuments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvOutputsDocuments.IsConfigInclude = true;
            this.dgvOutputsDocuments.IsMarkedAll = false;
            this.dgvOutputsDocuments.LocateParameters = new object[] {
        ((object)("")),
        ((object)(false)),
        ((object)(false)),
        ((object)(true)),
        ((object)(-1))};
            this.dgvOutputsDocuments.Location = new System.Drawing.Point(4, 30);
            this.dgvOutputsDocuments.MultiSelect = false;
            this.dgvOutputsDocuments.Name = "dgvOutputsDocuments";
            this.dgvOutputsDocuments.RangedWay = ' ';
            this.dgvOutputsDocuments.ReadOnly = true;
            this.dgvOutputsDocuments.RowHeadersWidth = 24;
            this.dgvOutputsDocuments.SelectedRowBorderColor = System.Drawing.Color.Empty;
            this.dgvOutputsDocuments.SelectedRowForeColor = System.Drawing.Color.Empty;
            this.dgvOutputsDocuments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOutputsDocuments.Size = new System.Drawing.Size(696, 370);
            this.dgvOutputsDocuments.TabIndex = 0;
            this.dgvOutputsDocuments.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutputsDocuments_CellValidated);
            this.dgvOutputsDocuments.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvOutputsDocuments_CellFormatting);
            // 
            // dgvcIsBroughtImage
            // 
            this.dgvcIsBroughtImage.DataPropertyName = "IsBrought";
            this.dgvcIsBroughtImage.HeaderText = "Дост.";
            this.dgvcIsBroughtImage.Name = "dgvcIsBroughtImage";
            this.dgvcIsBroughtImage.ReadOnly = true;
            this.dgvcIsBroughtImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcIsBroughtImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcIsBroughtImage.ToolTipText = "Зарегистрирована доставка товара получателю?";
            this.dgvcIsBroughtImage.Width = 45;
            // 
            // dgvcDateOutput
            // 
            this.dgvcDateOutput.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDateOutput.DataPropertyName = "DateOutput";
            dataGridViewCellStyle9.Format = "d";
            this.dgvcDateOutput.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvcDateOutput.HeaderText = "Дата ";
            this.dgvcDateOutput.Name = "dgvcDateOutput";
            this.dgvcDateOutput.ReadOnly = true;
            this.dgvcDateOutput.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcDateOutput.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDateOutput.Width = 78;
            // 
            // dgvcPartnerTargetName
            // 
            this.dgvcPartnerTargetName.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcPartnerTargetName.DataPropertyName = "PartnerTargetName";
            this.dgvcPartnerTargetName.HeaderText = "Получатель";
            this.dgvcPartnerTargetName.Name = "dgvcPartnerTargetName";
            this.dgvcPartnerTargetName.ReadOnly = true;
            this.dgvcPartnerTargetName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcPartnerTargetName.Width = 200;
            // 
            // dgvcTimeBeg
            // 
            this.dgvcTimeBeg.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTimeBeg.DataPropertyName = "TimeBeg";
            dataGridViewCellStyle10.Format = "t";
            dataGridViewCellStyle10.NullValue = ":";
            this.dgvcTimeBeg.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvcTimeBeg.HeaderText = "Приезд";
            this.dgvcTimeBeg.MaxInputLength = 5;
            this.dgvcTimeBeg.Name = "dgvcTimeBeg";
            this.dgvcTimeBeg.ReadOnly = true;
            this.dgvcTimeBeg.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcTimeBeg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTimeBeg.ToolTipText = "Время приезда, час:мин";
            this.dgvcTimeBeg.Width = 64;
            // 
            // dgvcTimeEnd
            // 
            this.dgvcTimeEnd.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcTimeEnd.DataPropertyName = "TimeEnd";
            dataGridViewCellStyle11.Format = "t";
            dataGridViewCellStyle11.NullValue = ":";
            this.dgvcTimeEnd.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvcTimeEnd.HeaderText = "Отъезд";
            this.dgvcTimeEnd.MaxInputLength = 5;
            this.dgvcTimeEnd.Name = "dgvcTimeEnd";
            this.dgvcTimeEnd.ReadOnly = true;
            this.dgvcTimeEnd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcTimeEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcTimeEnd.ToolTipText = "Время отъезда, час:мин";
            this.dgvcTimeEnd.Width = 64;
            // 
            // dgvcDurationMinutesFact
            // 
            this.dgvcDurationMinutesFact.DataPropertyName = "DurationMinutesFact";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "######";
            this.dgvcDurationMinutesFact.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvcDurationMinutesFact.HeaderText = "Ож.мин.";
            this.dgvcDurationMinutesFact.Name = "dgvcDurationMinutesFact";
            this.dgvcDurationMinutesFact.ReadOnly = true;
            this.dgvcDurationMinutesFact.ToolTipText = "Время ожидания, мин.";
            this.dgvcDurationMinutesFact.Width = 62;
            // 
            // dgvcDeliveryAddress
            // 
            this.dgvcDeliveryAddress.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcDeliveryAddress.DataPropertyName = "DeliveryAddress";
            this.dgvcDeliveryAddress.HeaderText = "Адрес доставки";
            this.dgvcDeliveryAddress.Name = "dgvcDeliveryAddress";
            this.dgvcDeliveryAddress.ReadOnly = true;
            this.dgvcDeliveryAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcDeliveryAddress.Width = 200;
            // 
            // dgvcAmount
            // 
            this.dgvcAmount.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N2";
            dataGridViewCellStyle13.NullValue = null;
            this.dgvcAmount.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvcAmount.HeaderText = "Стоимость";
            this.dgvcAmount.Name = "dgvcAmount";
            this.dgvcAmount.ReadOnly = true;
            this.dgvcAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcAmount.Width = 80;
            // 
            // dgvcBrutto
            // 
            this.dgvcBrutto.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcBrutto.DataPropertyName = "Brutto";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.Format = "N0";
            dataGridViewCellStyle14.NullValue = null;
            this.dgvcBrutto.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvcBrutto.HeaderText = "Брутто";
            this.dgvcBrutto.Name = "dgvcBrutto";
            this.dgvcBrutto.ReadOnly = true;
            this.dgvcBrutto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcBrutto.Width = 70;
            // 
            // dgvcID
            // 
            this.dgvcID.AgrType = RFMBaseClasses.EnumAgregate.None;
            this.dgvcID.DataPropertyName = "ID";
            this.dgvcID.HeaderText = "ID";
            this.dgvcID.Name = "dgvcID";
            this.dgvcID.ReadOnly = true;
            this.dgvcID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dgvcID.Width = 50;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHelp.Image = global::Logistics.Properties.Resources.Help;
            this.btnHelp.Location = new System.Drawing.Point(5, 407);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 30);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Image = global::Logistics.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(667, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Image = global::Logistics.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(617, 407);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(32, 30);
            this.btnSave.TabIndex = 3;
            this.ttToolTip.SetToolTip(this.btnSave, "Сохранить");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDistance.AutoSize = true;
            this.lblDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDistance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistance.Location = new System.Drawing.Point(110, 416);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(48, 14);
            this.lblDistance.TabIndex = 12;
            this.lblDistance.Text = "Пробег";
            // 
            // numDistance
            // 
            this.numDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numDistance.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.numDistance.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.numDistance.InputMask = "######";
            this.numDistance.IsNull = false;
            this.numDistance.Location = new System.Drawing.Point(158, 412);
            this.numDistance.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.RealPlaces = 6;
            this.numDistance.Size = new System.Drawing.Size(76, 22);
            this.numDistance.TabIndex = 13;
            this.numDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDistance1
            // 
            this.lblDistance1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDistance1.AutoSize = true;
            this.lblDistance1.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblDistance1.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDistance1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDistance1.Location = new System.Drawing.Point(238, 416);
            this.lblDistance1.Name = "lblDistance1";
            this.lblDistance1.Size = new System.Drawing.Size(21, 14);
            this.lblDistance1.TabIndex = 14;
            this.lblDistance1.Text = "км";
            // 
            // lblOutInTime
            // 
            this.lblOutInTime.AutoSize = true;
            this.lblOutInTime.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.lblOutInTime.DisabledForeColor = System.Drawing.SystemColors.WindowText;
            this.lblOutInTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutInTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblOutInTime.Location = new System.Drawing.Point(2, 8);
            this.lblOutInTime.Name = "lblOutInTime";
            this.lblOutInTime.Size = new System.Drawing.Size(201, 14);
            this.lblOutInTime.TabIndex = 15;
            this.lblOutInTime.Text = "Время выезда - возвращения: ";
            // 
            // frmOutputsDocumentsFactTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 441);
            this.Controls.Add(this.lblOutInTime);
            this.Controls.Add(this.lblDistance1);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.numDistance);
            this.Controls.Add(this.dgvOutputsDocuments);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.hpHelp.SetHelpKeyword(this, "221");
            this.hpHelp.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.IsModalMode = true;
            this.MinimizeBox = false;
            this.Name = "frmOutputsDocumentsFactTime";
            this.hpHelp.SetShowHelp(this, true);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Время пребывания у клиентов";
            this.Load += new System.EventHandler(this.frmOutputsDocumentsFactTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutputsDocuments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private RFMBaseClasses.RFMDataGridView dgvOutputsDocuments;
		private RFMBaseClasses.RFMButton btnSave;
		private RFMBaseClasses.RFMButton btnExit;
		private RFMBaseClasses.RFMButton btnHelp;
		private RFMBaseClasses.RFMDataGridViewImageColumn dgvcIsBroughtImage;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDateOutput;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcPartnerTargetName;
		private RFMBaseClasses.RFMDataGridViewTextBoxTimeColumn dgvcTimeBeg;
		private RFMBaseClasses.RFMDataGridViewTextBoxTimeColumn dgvcTimeEnd;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgvcDurationMinutesFact;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcDeliveryAddress;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcAmount;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcBrutto;
		private RFMBaseClasses.RFMDataGridViewTextBoxColumn dgvcID;
		private RFMBaseClasses.RFMLabel lblDistance;
		private RFMBaseClasses.RFMNumericUpDown numDistance;
		private RFMBaseClasses.RFMLabel lblDistance1;
        private RFMBaseClasses.RFMLabel lblOutInTime;
	}
}

