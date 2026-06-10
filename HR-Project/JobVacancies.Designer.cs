namespace HR_Project
{
    partial class JobVacancies
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
            this.panelProfilePageHeader = new System.Windows.Forms.Panel();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnProfilePageLogout = new System.Windows.Forms.Button();
            this.JobVacancieslblTitle = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnStatusTracking = new System.Windows.Forms.Button();
            this.btnDocuments = new System.Windows.Forms.Button();
            this.btnMyApplication = new System.Windows.Forms.Button();
            this.btnJobVacancies = new System.Windows.Forms.Button();
            this.btnsMyProfile = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.lblJobVacancies = new System.Windows.Forms.Label();
            this.lblSearchJob = new System.Windows.Forms.Label();
            this.txtSearchJob = new System.Windows.Forms.TextBox();
            this.btnSearchButton = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.dgvJobVacancies = new System.Windows.Forms.DataGridView();
            this.ColJobTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmploymentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpJobDetails = new System.Windows.Forms.GroupBox();
            this.rtbRequirements = new System.Windows.Forms.RichTextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.rtbQualification = new System.Windows.Forms.RichTextBox();
            this.lblEmploymentType = new System.Windows.Forms.Label();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnCancelApplication = new System.Windows.Forms.Button();
            this.panelProfilePageHeader.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobVacancies)).BeginInit();
            this.grpJobDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelProfilePageHeader
            // 
            this.panelProfilePageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelProfilePageHeader.Controls.Add(this.btnProfilePageClose);
            this.panelProfilePageHeader.Controls.Add(this.btnProfilePageLogout);
            this.panelProfilePageHeader.Controls.Add(this.JobVacancieslblTitle);
            this.panelProfilePageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfilePageHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProfilePageHeader.Name = "panelProfilePageHeader";
            this.panelProfilePageHeader.Size = new System.Drawing.Size(868, 60);
            this.panelProfilePageHeader.TabIndex = 10;
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.Red;
            this.btnProfilePageClose.Location = new System.Drawing.Point(833, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(36, 29);
            this.btnProfilePageClose.TabIndex = 4;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
            this.btnProfilePageClose.Click += new System.EventHandler(this.btnProfilePageClose_Click);
            // 
            // btnProfilePageLogout
            // 
            this.btnProfilePageLogout.Location = new System.Drawing.Point(752, 28);
            this.btnProfilePageLogout.Name = "btnProfilePageLogout";
            this.btnProfilePageLogout.Size = new System.Drawing.Size(75, 23);
            this.btnProfilePageLogout.TabIndex = 3;
            this.btnProfilePageLogout.Text = "Logout";
            this.btnProfilePageLogout.UseVisualStyleBackColor = true;
            this.btnProfilePageLogout.Click += new System.EventHandler(this.btnProfilePageLogout_Click);
            // 
            // JobVacancieslblTitle
            // 
            this.JobVacancieslblTitle.AutoSize = true;
            this.JobVacancieslblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobVacancieslblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.JobVacancieslblTitle.Location = new System.Drawing.Point(3, 23);
            this.JobVacancieslblTitle.Name = "JobVacancieslblTitle";
            this.JobVacancieslblTitle.Size = new System.Drawing.Size(136, 20);
            this.JobVacancieslblTitle.TabIndex = 0;
            this.JobVacancieslblTitle.Text = "Job Vacancies";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panelNavigation.Controls.Add(this.btnStatusTracking);
            this.panelNavigation.Controls.Add(this.btnDocuments);
            this.panelNavigation.Controls.Add(this.btnMyApplication);
            this.panelNavigation.Controls.Add(this.btnJobVacancies);
            this.panelNavigation.Controls.Add(this.btnsMyProfile);
            this.panelNavigation.Controls.Add(this.btnDashboard);
            this.panelNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(869, 42);
            this.panelNavigation.TabIndex = 11;
            // 
            // btnStatusTracking
            // 
            this.btnStatusTracking.BackColor = System.Drawing.Color.Blue;
            this.btnStatusTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnStatusTracking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStatusTracking.ForeColor = System.Drawing.Color.White;
            this.btnStatusTracking.Location = new System.Drawing.Point(669, 9);
            this.btnStatusTracking.Name = "btnStatusTracking";
            this.btnStatusTracking.Size = new System.Drawing.Size(96, 23);
            this.btnStatusTracking.TabIndex = 3;
            this.btnStatusTracking.Text = "Status Tracking";
            this.btnStatusTracking.UseVisualStyleBackColor = false;
            this.btnStatusTracking.Click += new System.EventHandler(this.btnStatusTracking_Click);
            // 
            // btnDocuments
            // 
            this.btnDocuments.BackColor = System.Drawing.Color.Blue;
            this.btnDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDocuments.ForeColor = System.Drawing.Color.White;
            this.btnDocuments.Location = new System.Drawing.Point(539, 9);
            this.btnDocuments.Name = "btnDocuments";
            this.btnDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnDocuments.TabIndex = 2;
            this.btnDocuments.Text = "Documents";
            this.btnDocuments.UseVisualStyleBackColor = false;
            this.btnDocuments.Click += new System.EventHandler(this.btnDocuments_Click);
            // 
            // btnMyApplication
            // 
            this.btnMyApplication.BackColor = System.Drawing.Color.Blue;
            this.btnMyApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyApplication.ForeColor = System.Drawing.Color.White;
            this.btnMyApplication.Location = new System.Drawing.Point(402, 9);
            this.btnMyApplication.Name = "btnMyApplication";
            this.btnMyApplication.Size = new System.Drawing.Size(89, 23);
            this.btnMyApplication.TabIndex = 2;
            this.btnMyApplication.Text = "My Application";
            this.btnMyApplication.UseVisualStyleBackColor = false;
            this.btnMyApplication.Click += new System.EventHandler(this.btnMyApplication_Click);
            // 
            // btnJobVacancies
            // 
            this.btnJobVacancies.BackColor = System.Drawing.Color.Blue;
            this.btnJobVacancies.Enabled = false;
            this.btnJobVacancies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnJobVacancies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobVacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobVacancies.ForeColor = System.Drawing.Color.White;
            this.btnJobVacancies.Location = new System.Drawing.Point(265, 9);
            this.btnJobVacancies.Name = "btnJobVacancies";
            this.btnJobVacancies.Size = new System.Drawing.Size(99, 23);
            this.btnJobVacancies.TabIndex = 2;
            this.btnJobVacancies.Text = "Job Vacancies";
            this.btnJobVacancies.UseVisualStyleBackColor = false;
            // 
            // btnsMyProfile
            // 
            this.btnsMyProfile.BackColor = System.Drawing.Color.Blue;
            this.btnsMyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnsMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnsMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsMyProfile.ForeColor = System.Drawing.Color.White;
            this.btnsMyProfile.Location = new System.Drawing.Point(149, 9);
            this.btnsMyProfile.Name = "btnsMyProfile";
            this.btnsMyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnsMyProfile.TabIndex = 1;
            this.btnsMyProfile.Text = "My Profile";
            this.btnsMyProfile.UseVisualStyleBackColor = false;
            this.btnsMyProfile.Click += new System.EventHandler(this.btnProfilePageMyProfile_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Blue;
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnProfilePageDashboard_Click);
            // 
            // lblJobVacancies
            // 
            this.lblJobVacancies.AutoSize = true;
            this.lblJobVacancies.BackColor = System.Drawing.Color.Transparent;
            this.lblJobVacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobVacancies.Location = new System.Drawing.Point(41, 119);
            this.lblJobVacancies.Name = "lblJobVacancies";
            this.lblJobVacancies.Size = new System.Drawing.Size(153, 25);
            this.lblJobVacancies.TabIndex = 12;
            this.lblJobVacancies.Text = "Job Vacancies";
            // 
            // lblSearchJob
            // 
            this.lblSearchJob.AutoSize = true;
            this.lblSearchJob.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchJob.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchJob.Location = new System.Drawing.Point(43, 160);
            this.lblSearchJob.Name = "lblSearchJob";
            this.lblSearchJob.Size = new System.Drawing.Size(63, 13);
            this.lblSearchJob.TabIndex = 13;
            this.lblSearchJob.Text = "Search Job";
            // 
            // txtSearchJob
            // 
            this.txtSearchJob.Location = new System.Drawing.Point(46, 176);
            this.txtSearchJob.Name = "txtSearchJob";
            this.txtSearchJob.Size = new System.Drawing.Size(58, 20);
            this.txtSearchJob.TabIndex = 14;
            // 
            // btnSearchButton
            // 
            this.btnSearchButton.Location = new System.Drawing.Point(110, 176);
            this.btnSearchButton.Name = "btnSearchButton";
            this.btnSearchButton.Size = new System.Drawing.Size(52, 20);
            this.btnSearchButton.TabIndex = 15;
            this.btnSearchButton.Text = "Search";
            this.btnSearchButton.UseVisualStyleBackColor = true;
            this.btnSearchButton.Click += new System.EventHandler(this.btnSearchButton_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.BackColor = System.Drawing.Color.Transparent;
            this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(42, 199);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(69, 13);
            this.lblDepartment.TabIndex = 16;
            this.lblDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(46, 215);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartment.TabIndex = 17;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // dgvJobVacancies
            // 
            this.dgvJobVacancies.AllowUserToAddRows = false;
            this.dgvJobVacancies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJobVacancies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobVacancies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColJobTitle,
            this.ColDepartment,
            this.ColEmploymentType,
            this.ColStatus});
            this.dgvJobVacancies.Location = new System.Drawing.Point(238, 119);
            this.dgvJobVacancies.Name = "dgvJobVacancies";
            this.dgvJobVacancies.ReadOnly = true;
            this.dgvJobVacancies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJobVacancies.Size = new System.Drawing.Size(500, 100);
            this.dgvJobVacancies.TabIndex = 18;
            this.dgvJobVacancies.SelectionChanged += new System.EventHandler(this.dgvJobVacancies_SelectionChanged);
            // 
            // ColJobTitle
            // 
            this.ColJobTitle.HeaderText = "Position";
            this.ColJobTitle.Name = "ColJobTitle";
            this.ColJobTitle.ReadOnly = true;
            // 
            // ColDepartment
            // 
            this.ColDepartment.HeaderText = "Department";
            this.ColDepartment.Name = "ColDepartment";
            this.ColDepartment.ReadOnly = true;
            // 
            // ColEmploymentType
            // 
            this.ColEmploymentType.HeaderText = "Employment Type";
            this.ColEmploymentType.Name = "ColEmploymentType";
            this.ColEmploymentType.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // grpJobDetails
            // 
            this.grpJobDetails.Controls.Add(this.rtbRequirements);
            this.grpJobDetails.Controls.Add(this.btnApply);
            this.grpJobDetails.Controls.Add(this.rtbQualification);
            this.grpJobDetails.Controls.Add(this.lblEmploymentType);
            this.grpJobDetails.Controls.Add(this.lblDepartments);
            this.grpJobDetails.Controls.Add(this.lblPosition);
            this.grpJobDetails.Location = new System.Drawing.Point(238, 225);
            this.grpJobDetails.Name = "grpJobDetails";
            this.grpJobDetails.Size = new System.Drawing.Size(500, 100);
            this.grpJobDetails.TabIndex = 19;
            this.grpJobDetails.TabStop = false;
            this.grpJobDetails.Text = "Job Details";
            // 
            // rtbRequirements
            // 
            this.rtbRequirements.Location = new System.Drawing.Point(301, 13);
            this.rtbRequirements.Name = "rtbRequirements";
            this.rtbRequirements.ReadOnly = true;
            this.rtbRequirements.Size = new System.Drawing.Size(124, 80);
            this.rtbRequirements.TabIndex = 20;
            this.rtbRequirements.Text = "";
            // 
            // btnApply
            // 
            this.btnApply.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnApply.Location = new System.Drawing.Point(431, 73);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(59, 21);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "Apply Now";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rtbQualification
            // 
            this.rtbQualification.Location = new System.Drawing.Point(146, 13);
            this.rtbQualification.Name = "rtbQualification";
            this.rtbQualification.ReadOnly = true;
            this.rtbQualification.Size = new System.Drawing.Size(120, 80);
            this.rtbQualification.TabIndex = 3;
            this.rtbQualification.Text = "";
            // 
            // lblEmploymentType
            // 
            this.lblEmploymentType.AutoSize = true;
            this.lblEmploymentType.Location = new System.Drawing.Point(6, 42);
            this.lblEmploymentType.Name = "lblEmploymentType";
            this.lblEmploymentType.Size = new System.Drawing.Size(91, 13);
            this.lblEmploymentType.TabIndex = 2;
            this.lblEmploymentType.Text = "Employment Type";
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Location = new System.Drawing.Point(6, 29);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(62, 13);
            this.lblDepartments.TabIndex = 1;
            this.lblDepartments.Text = "Department";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(6, 16);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(105, 13);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "IT Support Specialist";
            // 
            // btnCancelApplication
            // 
            this.btnCancelApplication.Location = new System.Drawing.Point(744, 295);
            this.btnCancelApplication.Name = "btnCancelApplication";
            this.btnCancelApplication.Size = new System.Drawing.Size(108, 23);
            this.btnCancelApplication.TabIndex = 20;
            this.btnCancelApplication.Text = "Cancel Application";
            this.btnCancelApplication.UseVisualStyleBackColor = true;
            this.btnCancelApplication.Click += new System.EventHandler(this.btnCancelApplication_Click);
            // 
            // JobVacancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(868, 353);
            this.Controls.Add(this.btnCancelApplication);
            this.Controls.Add(this.grpJobDetails);
            this.Controls.Add(this.dgvJobVacancies);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.btnSearchButton);
            this.Controls.Add(this.txtSearchJob);
            this.Controls.Add(this.lblSearchJob);
            this.Controls.Add(this.lblJobVacancies);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelProfilePageHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(30, 200);
            this.Name = "JobVacancies";
            this.Text = "JobVacancies";
            this.Load += new System.EventHandler(this.JobVacancies_Load);
            this.panelProfilePageHeader.ResumeLayout(false);
            this.panelProfilePageHeader.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobVacancies)).EndInit();
            this.grpJobDetails.ResumeLayout(false);
            this.grpJobDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProfilePageHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnProfilePageLogout;
        private System.Windows.Forms.Label JobVacancieslblTitle;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnStatusTracking;
        private System.Windows.Forms.Button btnDocuments;
        private System.Windows.Forms.Button btnMyApplication;
        private System.Windows.Forms.Button btnJobVacancies;
        private System.Windows.Forms.Button btnsMyProfile;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label lblJobVacancies;
        private System.Windows.Forms.Label lblSearchJob;
        private System.Windows.Forms.TextBox txtSearchJob;
        private System.Windows.Forms.Button btnSearchButton;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DataGridView dgvJobVacancies;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColJobTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmploymentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.GroupBox grpJobDetails;
        private System.Windows.Forms.RichTextBox rtbRequirements;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RichTextBox rtbQualification;
        private System.Windows.Forms.Label lblEmploymentType;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnCancelApplication;
    }
}
