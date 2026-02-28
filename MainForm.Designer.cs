namespace SchedulingApp
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabCustomers = new System.Windows.Forms.TabPage();
            this.splitCustomers = new System.Windows.Forms.SplitContainer();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnModifyCustomer = new System.Windows.Forms.Button();
            this.tabAppointments = new System.Windows.Forms.TabPage();
            this.splitAppointment = new System.Windows.Forms.SplitContainer();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.btnExitAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnModifyAppointment = new System.Windows.Forms.Button();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.tabCalendar = new System.Windows.Forms.TabPage();
            this.dgvCalendar = new System.Windows.Forms.DataGridView();
            this.calAppointments = new System.Windows.Forms.MonthCalendar();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.splitReports = new System.Windows.Forms.SplitContainer();
            this.btnReportCustom = new System.Windows.Forms.Button();
            this.btnReportScheduleByUser = new System.Windows.Forms.Button();
            this.btnReportTypesByMonth = new System.Windows.Forms.Button();
            this.pnlReportRight = new System.Windows.Forms.Panel();
            this.lblReportTitle = new System.Windows.Forms.Label();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.tabMain.SuspendLayout();
            this.tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCustomers)).BeginInit();
            this.splitCustomers.Panel1.SuspendLayout();
            this.splitCustomers.Panel2.SuspendLayout();
            this.splitCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.tabAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitAppointment)).BeginInit();
            this.splitAppointment.Panel1.SuspendLayout();
            this.splitAppointment.Panel2.SuspendLayout();
            this.splitAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.tabCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).BeginInit();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitReports)).BeginInit();
            this.splitReports.Panel1.SuspendLayout();
            this.splitReports.Panel2.SuspendLayout();
            this.splitReports.SuspendLayout();
            this.pnlReportRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabCustomers);
            this.tabMain.Controls.Add(this.tabAppointments);
            this.tabMain.Controls.Add(this.tabCalendar);
            this.tabMain.Controls.Add(this.tabReports);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(866, 552);
            this.tabMain.TabIndex = 5;
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.splitCustomers);
            this.tabCustomers.Location = new System.Drawing.Point(4, 22);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.Padding = new System.Windows.Forms.Padding(2);
            this.tabCustomers.Size = new System.Drawing.Size(858, 526);
            this.tabCustomers.TabIndex = 0;
            this.tabCustomers.Text = "Customers";
            this.tabCustomers.UseVisualStyleBackColor = true;
            // 
            // splitCustomers
            // 
            this.splitCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCustomers.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitCustomers.IsSplitterFixed = true;
            this.splitCustomers.Location = new System.Drawing.Point(2, 2);
            this.splitCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.splitCustomers.Name = "splitCustomers";
            this.splitCustomers.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCustomers.Panel1
            // 
            this.splitCustomers.Panel1.Controls.Add(this.dgvCustomers);
            // 
            // splitCustomers.Panel2
            // 
            this.splitCustomers.Panel2.Controls.Add(this.btnExit);
            this.splitCustomers.Panel2.Controls.Add(this.btnAddCustomer);
            this.splitCustomers.Panel2.Controls.Add(this.btnDeleteCustomer);
            this.splitCustomers.Panel2.Controls.Add(this.btnModifyCustomer);
            this.splitCustomers.Panel2MinSize = 140;
            this.splitCustomers.Size = new System.Drawing.Size(854, 522);
            this.splitCustomers.SplitterDistance = 380;
            this.splitCustomers.SplitterWidth = 2;
            this.splitCustomers.TabIndex = 5;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.EnableHeadersVisualStyles = false;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 82;
            this.dgvCustomers.RowTemplate.Height = 33;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(854, 380);
            this.dgvCustomers.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(728, 63);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddCustomer.Location = new System.Drawing.Point(57, 63);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 39);
            this.btnAddCustomer.TabIndex = 5;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(257, 63);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteCustomer.TabIndex = 7;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnModifyCustomer
            // 
            this.btnModifyCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyCustomer.Location = new System.Drawing.Point(157, 63);
            this.btnModifyCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyCustomer.Name = "btnModifyCustomer";
            this.btnModifyCustomer.Size = new System.Drawing.Size(75, 39);
            this.btnModifyCustomer.TabIndex = 6;
            this.btnModifyCustomer.Text = "Modify";
            this.btnModifyCustomer.UseVisualStyleBackColor = true;
            this.btnModifyCustomer.Click += new System.EventHandler(this.btnModifyCustomer_Click);
            // 
            // tabAppointments
            // 
            this.tabAppointments.Controls.Add(this.splitAppointment);
            this.tabAppointments.Location = new System.Drawing.Point(4, 22);
            this.tabAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.tabAppointments.Name = "tabAppointments";
            this.tabAppointments.Padding = new System.Windows.Forms.Padding(2);
            this.tabAppointments.Size = new System.Drawing.Size(858, 526);
            this.tabAppointments.TabIndex = 1;
            this.tabAppointments.Text = "Appointments";
            this.tabAppointments.UseVisualStyleBackColor = true;
            // 
            // splitAppointment
            // 
            this.splitAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitAppointment.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitAppointment.IsSplitterFixed = true;
            this.splitAppointment.Location = new System.Drawing.Point(2, 2);
            this.splitAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.splitAppointment.Name = "splitAppointment";
            this.splitAppointment.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitAppointment.Panel1
            // 
            this.splitAppointment.Panel1.Controls.Add(this.dgvAppointments);
            // 
            // splitAppointment.Panel2
            // 
            this.splitAppointment.Panel2.Controls.Add(this.btnExitAppointment);
            this.splitAppointment.Panel2.Controls.Add(this.btnDeleteAppointment);
            this.splitAppointment.Panel2.Controls.Add(this.btnModifyAppointment);
            this.splitAppointment.Panel2.Controls.Add(this.btnAddAppointment);
            this.splitAppointment.Panel2MinSize = 140;
            this.splitAppointment.Size = new System.Drawing.Size(854, 522);
            this.splitAppointment.SplitterDistance = 380;
            this.splitAppointment.SplitterWidth = 2;
            this.splitAppointment.TabIndex = 5;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.EnableHeadersVisualStyles = false;
            this.dgvAppointments.Location = new System.Drawing.Point(0, 0);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidth = 82;
            this.dgvAppointments.RowTemplate.Height = 33;
            this.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointments.Size = new System.Drawing.Size(854, 380);
            this.dgvAppointments.TabIndex = 1;
            // 
            // btnExitAppointment
            // 
            this.btnExitAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExitAppointment.Location = new System.Drawing.Point(728, 63);
            this.btnExitAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitAppointment.Name = "btnExitAppointment";
            this.btnExitAppointment.Size = new System.Drawing.Size(75, 39);
            this.btnExitAppointment.TabIndex = 8;
            this.btnExitAppointment.Text = "Exit";
            this.btnExitAppointment.UseVisualStyleBackColor = true;
            this.btnExitAppointment.Click += new System.EventHandler(this.btnExitAppointment_Click);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAppointment.Location = new System.Drawing.Point(257, 63);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(75, 39);
            this.btnDeleteAppointment.TabIndex = 7;
            this.btnDeleteAppointment.Text = "Delete";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
            // 
            // btnModifyAppointment
            // 
            this.btnModifyAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifyAppointment.Location = new System.Drawing.Point(157, 63);
            this.btnModifyAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyAppointment.Name = "btnModifyAppointment";
            this.btnModifyAppointment.Size = new System.Drawing.Size(75, 39);
            this.btnModifyAppointment.TabIndex = 6;
            this.btnModifyAppointment.Text = "Modify";
            this.btnModifyAppointment.UseVisualStyleBackColor = true;
            this.btnModifyAppointment.Click += new System.EventHandler(this.btnModifyAppointment_Click);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAppointment.Location = new System.Drawing.Point(57, 63);
            this.btnAddAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(75, 39);
            this.btnAddAppointment.TabIndex = 5;
            this.btnAddAppointment.Text = "Add";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // tabCalendar
            // 
            this.tabCalendar.Controls.Add(this.dgvCalendar);
            this.tabCalendar.Controls.Add(this.calAppointments);
            this.tabCalendar.Location = new System.Drawing.Point(4, 22);
            this.tabCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.tabCalendar.Name = "tabCalendar";
            this.tabCalendar.Padding = new System.Windows.Forms.Padding(2);
            this.tabCalendar.Size = new System.Drawing.Size(858, 526);
            this.tabCalendar.TabIndex = 2;
            this.tabCalendar.Text = "Calendar";
            this.tabCalendar.UseVisualStyleBackColor = true;
            // 
            // dgvCalendar
            // 
            this.dgvCalendar.AllowUserToAddRows = false;
            this.dgvCalendar.AllowUserToDeleteRows = false;
            this.dgvCalendar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCalendar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCalendar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCalendar.EnableHeadersVisualStyles = false;
            this.dgvCalendar.Location = new System.Drawing.Point(229, 2);
            this.dgvCalendar.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCalendar.Name = "dgvCalendar";
            this.dgvCalendar.ReadOnly = true;
            this.dgvCalendar.RowHeadersVisible = false;
            this.dgvCalendar.RowHeadersWidth = 82;
            this.dgvCalendar.RowTemplate.Height = 33;
            this.dgvCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCalendar.Size = new System.Drawing.Size(627, 522);
            this.dgvCalendar.TabIndex = 1;
            // 
            // calAppointments
            // 
            this.calAppointments.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.calAppointments.Dock = System.Windows.Forms.DockStyle.Left;
            this.calAppointments.Location = new System.Drawing.Point(2, 2);
            this.calAppointments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.calAppointments.MaxSelectionCount = 1;
            this.calAppointments.Name = "calAppointments";
            this.calAppointments.TabIndex = 0;
            this.calAppointments.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calAppointments_DateSelected);
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.splitReports);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(858, 526);
            this.tabReports.TabIndex = 3;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // splitReports
            // 
            this.splitReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitReports.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitReports.Location = new System.Drawing.Point(3, 3);
            this.splitReports.Margin = new System.Windows.Forms.Padding(2);
            this.splitReports.Name = "splitReports";
            // 
            // splitReports.Panel1
            // 
            this.splitReports.Panel1.Controls.Add(this.btnReportCustom);
            this.splitReports.Panel1.Controls.Add(this.btnReportScheduleByUser);
            this.splitReports.Panel1.Controls.Add(this.btnReportTypesByMonth);
            this.splitReports.Panel1.Padding = new System.Windows.Forms.Padding(10);
            // 
            // splitReports.Panel2
            // 
            this.splitReports.Panel2.Controls.Add(this.pnlReportRight);
            this.splitReports.Size = new System.Drawing.Size(852, 520);
            this.splitReports.SplitterDistance = 200;
            this.splitReports.SplitterWidth = 2;
            this.splitReports.TabIndex = 0;
            // 
            // btnReportCustom
            // 
            this.btnReportCustom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportCustom.Location = new System.Drawing.Point(39, 235);
            this.btnReportCustom.Name = "btnReportCustom";
            this.btnReportCustom.Padding = new System.Windows.Forms.Padding(10);
            this.btnReportCustom.Size = new System.Drawing.Size(120, 60);
            this.btnReportCustom.TabIndex = 2;
            this.btnReportCustom.Text = "Appointments by Customers";
            this.btnReportCustom.UseVisualStyleBackColor = true;
            this.btnReportCustom.Click += new System.EventHandler(this.btnReportCustom_Click);
            // 
            // btnReportScheduleByUser
            // 
            this.btnReportScheduleByUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportScheduleByUser.Location = new System.Drawing.Point(39, 149);
            this.btnReportScheduleByUser.Name = "btnReportScheduleByUser";
            this.btnReportScheduleByUser.Padding = new System.Windows.Forms.Padding(10);
            this.btnReportScheduleByUser.Size = new System.Drawing.Size(120, 60);
            this.btnReportScheduleByUser.TabIndex = 1;
            this.btnReportScheduleByUser.Text = "Schedule by User";
            this.btnReportScheduleByUser.UseVisualStyleBackColor = true;
            this.btnReportScheduleByUser.Click += new System.EventHandler(this.btnReportScheduleByUser_Click);
            // 
            // btnReportTypesByMonth
            // 
            this.btnReportTypesByMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportTypesByMonth.Location = new System.Drawing.Point(39, 63);
            this.btnReportTypesByMonth.Name = "btnReportTypesByMonth";
            this.btnReportTypesByMonth.Padding = new System.Windows.Forms.Padding(10);
            this.btnReportTypesByMonth.Size = new System.Drawing.Size(120, 60);
            this.btnReportTypesByMonth.TabIndex = 0;
            this.btnReportTypesByMonth.Text = "Types by Month";
            this.btnReportTypesByMonth.UseVisualStyleBackColor = true;
            this.btnReportTypesByMonth.Click += new System.EventHandler(this.btnReportTypesByMonth_Click);
            // 
            // pnlReportRight
            // 
            this.pnlReportRight.Controls.Add(this.dgvReports);
            this.pnlReportRight.Controls.Add(this.lblReportTitle);
            this.pnlReportRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportRight.Location = new System.Drawing.Point(0, 0);
            this.pnlReportRight.Name = "pnlReportRight";
            this.pnlReportRight.Size = new System.Drawing.Size(650, 520);
            this.pnlReportRight.TabIndex = 2;
            // 
            // lblReportTitle
            // 
            this.lblReportTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReportTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportTitle.Location = new System.Drawing.Point(0, 0);
            this.lblReportTitle.Name = "lblReportTitle";
            this.lblReportTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblReportTitle.Size = new System.Drawing.Size(650, 30);
            this.lblReportTitle.TabIndex = 2;
            this.lblReportTitle.Text = "label1";
            this.lblReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AllowUserToDeleteRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvReports.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.EnableHeadersVisualStyles = false;
            this.dgvReports.Location = new System.Drawing.Point(0, 30);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(2);
            this.dgvReports.MultiSelect = false;
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersVisible = false;
            this.dgvReports.RowHeadersWidth = 82;
            this.dgvReports.RowTemplate.Height = 33;
            this.dgvReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReports.Size = new System.Drawing.Size(650, 490);
            this.dgvReports.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 552);
            this.Controls.Add(this.tabMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabMain.ResumeLayout(false);
            this.tabCustomers.ResumeLayout(false);
            this.splitCustomers.Panel1.ResumeLayout(false);
            this.splitCustomers.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCustomers)).EndInit();
            this.splitCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.tabAppointments.ResumeLayout(false);
            this.splitAppointment.Panel1.ResumeLayout(false);
            this.splitAppointment.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitAppointment)).EndInit();
            this.splitAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.tabCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalendar)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.splitReports.Panel1.ResumeLayout(false);
            this.splitReports.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitReports)).EndInit();
            this.splitReports.ResumeLayout(false);
            this.pnlReportRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabCustomers;
        private System.Windows.Forms.TabPage tabAppointments;
        private System.Windows.Forms.SplitContainer splitCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnModifyCustomer;
        private System.Windows.Forms.SplitContainer splitAppointment;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnExitAppointment;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnModifyAppointment;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.TabPage tabCalendar;
        private System.Windows.Forms.DataGridView dgvCalendar;
        private System.Windows.Forms.MonthCalendar calAppointments;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.SplitContainer splitReports;
        private System.Windows.Forms.Button btnReportCustom;
        private System.Windows.Forms.Button btnReportScheduleByUser;
        private System.Windows.Forms.Button btnReportTypesByMonth;
        private System.Windows.Forms.Panel pnlReportRight;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.Label lblReportTitle;
    }
}