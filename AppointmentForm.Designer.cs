namespace SchedulingApp
{
    partial class AppointmentForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(398, 404);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(550, 404);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 60);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(76, 58);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(104, 25);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(76, 123);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 25);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(76, 188);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 25);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(76, 254);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(110, 25);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "Start Time";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(76, 319);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(103, 25);
            this.lblEndTime.TabIndex = 6;
            this.lblEndTime.Text = "End Time";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(260, 42);
            this.cmbCustomer.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(238, 33);
            this.cmbCustomer.TabIndex = 7;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(260, 110);
            this.cmbType.Margin = new System.Windows.Forms.Padding(6);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(238, 33);
            this.cmbType.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(260, 177);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(6);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(396, 31);
            this.dtpDate.TabIndex = 9;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStart.Location = new System.Drawing.Point(260, 242);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(6);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(396, 31);
            this.dtpStart.TabIndex = 10;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEnd.Location = new System.Drawing.Point(260, 308);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(6);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(396, 31);
            this.dtpEnd.TabIndex = 11;
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 527);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppointmentForm";
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
    }
}