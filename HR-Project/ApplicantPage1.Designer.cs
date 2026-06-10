namespace HR_Project
{
    partial class ApplicantPage1
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
            this.components = new System.ComponentModel.Container();
            this.lblWelcomeHeader = new System.Windows.Forms.Label();
            this.grpPositionInfo = new System.Windows.Forms.GroupBox();
            this.dtpDataFiled = new System.Windows.Forms.DateTimePicker();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblDataFiled = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.clbApplicationSteps = new System.Windows.Forms.CheckedListBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.pnlStatusBanner = new System.Windows.Forms.Panel();
            this.lblStatusDescription = new System.Windows.Forms.Label();
            this.panelMyDocumentsHeader = new System.Windows.Forms.Panel();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.lblMyDocumentsTitle = new System.Windows.Forms.Label();
            this.panelMyApplicationNavigation = new System.Windows.Forms.Panel();
            this.btnMyDocumentsStatusTracking = new System.Windows.Forms.Button();
            this.btnMyDocumentsDocuments = new System.Windows.Forms.Button();
            this.btnMyDocumentsMyApplication = new System.Windows.Forms.Button();
            this.btnMyApplicationsJobVacancies = new System.Windows.Forms.Button();
            this.btnMyApplicationMyProfile = new System.Windows.Forms.Button();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpPositionInfo.SuspendLayout();
            this.grpSteps.SuspendLayout();
            this.pnlStatusBanner.SuspendLayout();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyApplicationNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeHeader
            // 
            this.lblWelcomeHeader.AutoSize = true;
            this.lblWelcomeHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHeader.Location = new System.Drawing.Point(2, 103);
            this.lblWelcomeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeHeader.Name = "lblWelcomeHeader";
            this.lblWelcomeHeader.Size = new System.Drawing.Size(155, 25);
            this.lblWelcomeHeader.TabIndex = 1;
            this.lblWelcomeHeader.Text = "My Applications";
            // 
            // grpPositionInfo
            // 
            this.grpPositionInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpPositionInfo.Controls.Add(this.dtpDataFiled);
            this.grpPositionInfo.Controls.Add(this.txtDept);
            this.grpPositionInfo.Controls.Add(this.txtJobTitle);
            this.grpPositionInfo.Controls.Add(this.lblDataFiled);
            this.grpPositionInfo.Controls.Add(this.lblDept);
            this.grpPositionInfo.Controls.Add(this.lblJobTitle);
            this.grpPositionInfo.Location = new System.Drawing.Point(24, 139);
            this.grpPositionInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpPositionInfo.Name = "grpPositionInfo";
            this.grpPositionInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpPositionInfo.Size = new System.Drawing.Size(295, 89);
            this.grpPositionInfo.TabIndex = 4;
            this.grpPositionInfo.TabStop = false;
            this.grpPositionInfo.Text = "Position Information";
            this.grpPositionInfo.Enter += new System.EventHandler(this.grpPositionInfo_Enter);
            // 
            // dtpDataFiled
            // 
            this.dtpDataFiled.Location = new System.Drawing.Point(71, 64);
            this.dtpDataFiled.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFiled.Name = "dtpDataFiled";
            this.dtpDataFiled.Size = new System.Drawing.Size(135, 20);
            this.dtpDataFiled.TabIndex = 6;
            // 
            // txtDept
            // 
            this.txtDept.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDept.Location = new System.Drawing.Point(79, 39);
            this.txtDept.Margin = new System.Windows.Forms.Padding(2);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(114, 22);
            this.txtDept.TabIndex = 7;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(62, 16);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(114, 22);
            this.txtJobTitle.TabIndex = 6;
            this.txtJobTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDataFiled
            // 
            this.lblDataFiled.AutoSize = true;
            this.lblDataFiled.Location = new System.Drawing.Point(10, 68);
            this.lblDataFiled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFiled.Name = "lblDataFiled";
            this.lblDataFiled.Size = new System.Drawing.Size(58, 13);
            this.lblDataFiled.TabIndex = 2;
            this.lblDataFiled.Text = "Data Filed:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(10, 41);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(65, 13);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Department:";
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Location = new System.Drawing.Point(10, 20);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(50, 13);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // grpSteps
            // 
            this.grpSteps.BackColor = System.Drawing.Color.Transparent;
            this.grpSteps.Controls.Add(this.clbApplicationSteps);
            this.grpSteps.Location = new System.Drawing.Point(353, 139);
            this.grpSteps.Margin = new System.Windows.Forms.Padding(2);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Padding = new System.Windows.Forms.Padding(2);
            this.grpSteps.Size = new System.Drawing.Size(321, 89);
            this.grpSteps.TabIndex = 5;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Steps";
            // 
            // clbApplicationSteps
            // 
            this.clbApplicationSteps.BackColor = System.Drawing.Color.GhostWhite;
            this.clbApplicationSteps.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbApplicationSteps.FormattingEnabled = true;
            this.clbApplicationSteps.Items.AddRange(new object[] {
            "Prolife Completed",
            "Mandatory Documents Uploaded",
            "HR Preliminary Review",
            "Technical Panel Interview"});
            this.clbApplicationSteps.Location = new System.Drawing.Point(4, 17);
            this.clbApplicationSteps.Margin = new System.Windows.Forms.Padding(2);
            this.clbApplicationSteps.Name = "clbApplicationSteps";
            this.clbApplicationSteps.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbApplicationSteps.Size = new System.Drawing.Size(218, 56);
            this.clbApplicationSteps.TabIndex = 0;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Location = new System.Drawing.Point(33, 14);
            this.lblCurrentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(77, 13);
            this.lblCurrentStatus.TabIndex = 6;
            this.lblCurrentStatus.Text = "Current Status:";
            // 
            // pnlStatusBanner
            // 
            this.pnlStatusBanner.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatusBanner.BackgroundImage = global::HR_Project.Properties.Resources.download__70_;
            this.pnlStatusBanner.Controls.Add(this.lblStatusDescription);
            this.pnlStatusBanner.Controls.Add(this.lblCurrentStatus);
            this.pnlStatusBanner.Location = new System.Drawing.Point(24, 249);
            this.pnlStatusBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStatusBanner.Name = "pnlStatusBanner";
            this.pnlStatusBanner.Size = new System.Drawing.Size(642, 105);
            this.pnlStatusBanner.TabIndex = 7;
            // 
            // lblStatusDescription
            // 
            this.lblStatusDescription.AutoSize = true;
            this.lblStatusDescription.Location = new System.Drawing.Point(33, 44);
            this.lblStatusDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusDescription.Name = "lblStatusDescription";
            this.lblStatusDescription.Size = new System.Drawing.Size(96, 13);
            this.lblStatusDescription.TabIndex = 7;
            this.lblStatusDescription.Text = "Status Description:";
            // 
            // panelMyDocumentsHeader
            // 
            this.panelMyDocumentsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelMyDocumentsHeader.Controls.Add(this.btnProfilePageClose);
            this.panelMyDocumentsHeader.Controls.Add(this.btnMyDocumentsLogout);
            this.panelMyDocumentsHeader.Controls.Add(this.lblMyDocumentsTitle);
            this.panelMyDocumentsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyDocumentsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMyDocumentsHeader.Name = "panelMyDocumentsHeader";
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(674, 60);
            this.panelMyDocumentsHeader.TabIndex = 13;
            this.panelMyDocumentsHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMyDocumentsHeader_Paint);
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.Red;
            this.btnProfilePageClose.Location = new System.Drawing.Point(639, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(36, 29);
            this.btnProfilePageClose.TabIndex = 4;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
            this.btnProfilePageClose.Click += new System.EventHandler(this.btnProfilePageClose_Click);
            // 
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(558, 23);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsLogout.TabIndex = 3;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = true;
            this.btnMyDocumentsLogout.Click += new System.EventHandler(this.btnMyDocumentsLogout_Click);
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(3, 23);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(142, 20);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "My Application";
            // 
            // panelMyApplicationNavigation
            // 
            this.panelMyApplicationNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsStatusTracking);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsDocuments);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsMyApplication);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyApplicationsJobVacancies);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyApplicationMyProfile);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyApplicationNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelMyApplicationNavigation.Name = "panelMyApplicationNavigation";
            this.panelMyApplicationNavigation.Size = new System.Drawing.Size(675, 43);
            this.panelMyApplicationNavigation.TabIndex = 14;
            // 
            // btnMyDocumentsStatusTracking
            // 
            this.btnMyDocumentsStatusTracking.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsStatusTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsStatusTracking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsStatusTracking.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsStatusTracking.Location = new System.Drawing.Point(549, 9);
            this.btnMyDocumentsStatusTracking.Name = "btnMyDocumentsStatusTracking";
            this.btnMyDocumentsStatusTracking.Size = new System.Drawing.Size(96, 23);
            this.btnMyDocumentsStatusTracking.TabIndex = 3;
            this.btnMyDocumentsStatusTracking.Text = "Status Tracking";
            this.btnMyDocumentsStatusTracking.UseVisualStyleBackColor = false;
            this.btnMyDocumentsStatusTracking.Click += new System.EventHandler(this.btnMyDocumentsStatusTracking_Click);
            // 
            // btnMyDocumentsDocuments
            // 
            this.btnMyDocumentsDocuments.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsDocuments.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDocuments.Location = new System.Drawing.Point(456, 9);
            this.btnMyDocumentsDocuments.Name = "btnMyDocumentsDocuments";
            this.btnMyDocumentsDocuments.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsDocuments.TabIndex = 2;
            this.btnMyDocumentsDocuments.Text = "Documents";
            this.btnMyDocumentsDocuments.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDocuments.Click += new System.EventHandler(this.btnMyDocumentsDocuments_Click);
            // 
            // btnMyDocumentsMyApplication
            // 
            this.btnMyDocumentsMyApplication.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyApplication.Enabled = false;
            this.btnMyDocumentsMyApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsMyApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsMyApplication.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsMyApplication.Location = new System.Drawing.Point(329, 9);
            this.btnMyDocumentsMyApplication.Name = "btnMyDocumentsMyApplication";
            this.btnMyDocumentsMyApplication.Size = new System.Drawing.Size(103, 23);
            this.btnMyDocumentsMyApplication.TabIndex = 2;
            this.btnMyDocumentsMyApplication.Text = "My Application";
            this.btnMyDocumentsMyApplication.UseVisualStyleBackColor = false;
            this.btnMyDocumentsMyApplication.Click += new System.EventHandler(this.btnMyDocumentsMyApplication_Click);
            // 
            // btnMyApplicationsJobVacancies
            // 
            this.btnMyApplicationsJobVacancies.BackColor = System.Drawing.Color.Blue;
            this.btnMyApplicationsJobVacancies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyApplicationsJobVacancies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyApplicationsJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyApplicationsJobVacancies.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyApplicationsJobVacancies.Location = new System.Drawing.Point(219, 9);
            this.btnMyApplicationsJobVacancies.Name = "btnMyApplicationsJobVacancies";
            this.btnMyApplicationsJobVacancies.Size = new System.Drawing.Size(89, 23);
            this.btnMyApplicationsJobVacancies.TabIndex = 2;
            this.btnMyApplicationsJobVacancies.Text = "Job Vacancies";
            this.btnMyApplicationsJobVacancies.UseVisualStyleBackColor = false;
            this.btnMyApplicationsJobVacancies.Click += new System.EventHandler(this.btnMyDocumentsJobVacancies_Click);
            // 
            // btnMyApplicationMyProfile
            // 
            this.btnMyApplicationMyProfile.BackColor = System.Drawing.Color.Blue;
            this.btnMyApplicationMyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyApplicationMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyApplicationMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyApplicationMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyApplicationMyProfile.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyApplicationMyProfile.Location = new System.Drawing.Point(125, 9);
            this.btnMyApplicationMyProfile.Name = "btnMyApplicationMyProfile";
            this.btnMyApplicationMyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnMyApplicationMyProfile.TabIndex = 1;
            this.btnMyApplicationMyProfile.Text = "My Profile";
            this.btnMyApplicationMyProfile.UseVisualStyleBackColor = false;
            this.btnMyApplicationMyProfile.Click += new System.EventHandler(this.btnMyDocumentsMyProfile_Click);
            // 
            // btnMyDocumentsDashboard
            // 
            this.btnMyDocumentsDashboard.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ApplicantPage1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(674, 389);
            this.Controls.Add(this.panelMyApplicationNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.Controls.Add(this.pnlStatusBanner);
            this.Controls.Add(this.grpSteps);
            this.Controls.Add(this.grpPositionInfo);
            this.Controls.Add(this.lblWelcomeHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApplicantPage1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ApplicantPage1_Load);
            this.grpPositionInfo.ResumeLayout(false);
            this.grpPositionInfo.PerformLayout();
            this.grpSteps.ResumeLayout(false);
            this.pnlStatusBanner.ResumeLayout(false);
            this.pnlStatusBanner.PerformLayout();
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyApplicationNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWelcomeHeader;
        private System.Windows.Forms.GroupBox grpPositionInfo;
        private System.Windows.Forms.Label lblDataFiled;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label lblJobTitle;
        private System.Windows.Forms.GroupBox grpSteps;
        private System.Windows.Forms.CheckedListBox clbApplicationSteps;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.DateTimePicker dtpDataFiled;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Panel pnlStatusBanner;
        private System.Windows.Forms.Label lblStatusDescription;
        private System.Windows.Forms.Panel panelMyDocumentsHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblMyDocumentsTitle;
        private System.Windows.Forms.Panel panelMyApplicationNavigation;
        private System.Windows.Forms.Button btnMyDocumentsStatusTracking;
        private System.Windows.Forms.Button btnMyDocumentsDocuments;
        private System.Windows.Forms.Button btnMyDocumentsMyApplication;
        private System.Windows.Forms.Button btnMyApplicationsJobVacancies;
        private System.Windows.Forms.Button btnMyApplicationMyProfile;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

