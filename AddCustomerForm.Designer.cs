namespace SchedulingApp
{
    partial class AddCustomerForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblPostal = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(43, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(189, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(534, 31);
            this.txtName.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(43, 122);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 25);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(189, 122);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(534, 31);
            this.txtAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(43, 312);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(74, 25);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(189, 312);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(534, 31);
            this.txtPhone.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(459, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 60);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(613, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 60);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(43, 184);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(49, 25);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(189, 184);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(534, 33);
            this.cmbCity.TabIndex = 9;
            // 
            // lblPostal
            // 
            this.lblPostal.AutoSize = true;
            this.lblPostal.Location = new System.Drawing.Point(43, 248);
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Size = new System.Drawing.Size(129, 25);
            this.lblPostal.TabIndex = 10;
            this.lblPostal.Text = "Postal Code";
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(189, 248);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(534, 31);
            this.txtPostal.TabIndex = 11;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 682);
            this.Controls.Add(this.txtPostal);
            this.Controls.Add(this.lblPostal);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblPostal;
        private System.Windows.Forms.TextBox txtPostal;
    }
}