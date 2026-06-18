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
            this.lblWelcomeHeader = new System.Windows.Forms.Label();
            this.grpPositionInfo = new System.Windows.Forms.GroupBox();
            this.lblJobTitle = new System.Windows.Forms.Label();
            this.dtpDataFiled = new System.Windows.Forms.DateTimePicker();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.lblDataFiled = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.grpSteps = new System.Windows.Forms.GroupBox();
            this.clbApplicationSteps = new System.Windows.Forms.CheckedListBox();
            this.pnlStatusBanner = new System.Windows.Forms.Panel();
            this.txtScreeningNotes = new System.Windows.Forms.TextBox();
            this.lblStatusDescription = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyApplicationNavigation.SuspendLayout();
            this.grpPositionInfo.SuspendLayout();
            this.grpSteps.SuspendLayout();
            this.pnlStatusBanner.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMyDocumentsHeader
            // 
            this.panelMyDocumentsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panelMyDocumentsHeader.Controls.Add(this.btnProfilePageClose);
            this.panelMyDocumentsHeader.Controls.Add(this.btnMyDocumentsLogout);
            this.panelMyDocumentsHeader.Controls.Add(this.lblMyDocumentsTitle);
            this.panelMyDocumentsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyDocumentsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMyDocumentsHeader.Name = "panelMyDocumentsHeader";
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(1100, 60);
            this.panelMyDocumentsHeader.TabIndex = 13;
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.Red;
            this.btnProfilePageClose.Location = new System.Drawing.Point(1064, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(36, 29);
            this.btnProfilePageClose.TabIndex = 4;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
            this.btnProfilePageClose.Click += new System.EventHandler(this.btnProfilePageClose_Click);
            // 
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(975, 16);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(85, 28);
            this.btnMyDocumentsLogout.TabIndex = 3;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = true;
            this.btnMyDocumentsLogout.Click += new System.EventHandler(this.btnMyDocumentsLogout_Click);
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(12, 18);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(150, 25);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "Applicant Portal";
            // 
            // panelMyApplicationNavigation
            // 
            this.panelMyApplicationNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsStatusTracking);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsDocuments);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsMyApplication);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyApplicationsJobVacancies);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyApplicationMyProfile);
            this.panelMyApplicationNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyApplicationNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelMyApplicationNavigation.Name = "panelMyApplicationNavigation";
            this.panelMyApplicationNavigation.Size = new System.Drawing.Size(1100, 42);
            this.panelMyApplicationNavigation.TabIndex = 14;
            // 
            // btnMyDocumentsStatusTracking
            // 
            this.btnMyDocumentsStatusTracking.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsStatusTracking.Location = new System.Drawing.Point(570, 0);
            this.btnMyDocumentsStatusTracking.Name = "btnMyDocumentsStatusTracking";
            this.btnMyDocumentsStatusTracking.Size = new System.Drawing.Size(130, 42);
            this.btnMyDocumentsStatusTracking.TabIndex = 5;
            this.btnMyDocumentsStatusTracking.Text = "Status Tracking";
            this.btnMyDocumentsStatusTracking.UseVisualStyleBackColor = false;
            this.btnMyDocumentsStatusTracking.Click += new System.EventHandler(this.btnMyDocumentsStatusTracking_Click);
            // 
            // btnMyDocumentsDocuments
            // 
            this.btnMyDocumentsDocuments.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDocuments.Location = new System.Drawing.Point(460, 0);
            this.btnMyDocumentsDocuments.Name = "btnMyDocumentsDocuments";
            this.btnMyDocumentsDocuments.Size = new System.Drawing.Size(110, 42);
            this.btnMyDocumentsDocuments.TabIndex = 4;
            this.btnMyDocumentsDocuments.Text = "Documents";
            this.btnMyDocumentsDocuments.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDocuments.Click += new System.EventHandler(this.btnMyDocumentsDocuments_Click);
            // 
            // btnMyDocumentsMyApplication
            // 
            this.btnMyDocumentsMyApplication.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsMyApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsMyApplication.Location = new System.Drawing.Point(340, 0);
            this.btnMyDocumentsMyApplication.Name = "btnMyDocumentsMyApplication";
            this.btnMyDocumentsMyApplication.Size = new System.Drawing.Size(120, 42);
            this.btnMyDocumentsMyApplication.TabIndex = 3;
            this.btnMyDocumentsMyApplication.Text = "My Application";
            this.btnMyDocumentsMyApplication.UseVisualStyleBackColor = false;
            this.btnMyDocumentsMyApplication.Click += new System.EventHandler(this.btnMyDocumentsMyApplication_Click);
            // 
            // btnMyApplicationsJobVacancies
            // 
            this.btnMyApplicationsJobVacancies.FlatAppearance.BorderSize = 0;
            this.btnMyApplicationsJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApplicationsJobVacancies.Location = new System.Drawing.Point(220, 0);
            this.btnMyApplicationsJobVacancies.Name = "btnMyApplicationsJobVacancies";
            this.btnMyApplicationsJobVacancies.Size = new System.Drawing.Size(120, 42);
            this.btnMyApplicationsJobVacancies.TabIndex = 2;
            this.btnMyApplicationsJobVacancies.Text = "Job Vacancies";
            this.btnMyApplicationsJobVacancies.UseVisualStyleBackColor = false;
            this.btnMyApplicationsJobVacancies.Click += new System.EventHandler(this.btnMyDocumentsJobVacancies_Click);
            // 
            // btnMyApplicationMyProfile
            // 
            this.btnMyApplicationMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyApplicationMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyApplicationMyProfile.Location = new System.Drawing.Point(110, 0);
            this.btnMyApplicationMyProfile.Name = "btnMyApplicationMyProfile";
            this.btnMyApplicationMyProfile.Size = new System.Drawing.Size(110, 42);
            this.btnMyApplicationMyProfile.TabIndex = 1;
            this.btnMyApplicationMyProfile.Text = "My Profile";
            this.btnMyApplicationMyProfile.UseVisualStyleBackColor = false;
            this.btnMyApplicationMyProfile.Click += new System.EventHandler(this.btnMyDocumentsMyProfile_Click);
            // 
            // btnMyDocumentsDashboard
            // 
            this.btnMyDocumentsDashboard.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(110, 42);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click_1);
            // 
            // lblWelcomeHeader
            // 
            this.lblWelcomeHeader.AutoSize = true;
            this.lblWelcomeHeader.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblWelcomeHeader.Location = new System.Drawing.Point(20, 112);
            this.lblWelcomeHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcomeHeader.Name = "lblWelcomeHeader";
            this.lblWelcomeHeader.Size = new System.Drawing.Size(147, 25);
            this.lblWelcomeHeader.TabIndex = 1;
            this.lblWelcomeHeader.Text = "My Application";
            // 
            // grpPositionInfo
            // 
            this.grpPositionInfo.BackColor = System.Drawing.Color.White;
            this.grpPositionInfo.Controls.Add(this.lblJobTitle);
            this.grpPositionInfo.Controls.Add(this.dtpDataFiled);
            this.grpPositionInfo.Controls.Add(this.txtDept);
            this.grpPositionInfo.Controls.Add(this.txtJobTitle);
            this.grpPositionInfo.Controls.Add(this.lblDataFiled);
            this.grpPositionInfo.Controls.Add(this.lblDept);
            this.grpPositionInfo.Location = new System.Drawing.Point(20, 160);
            this.grpPositionInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpPositionInfo.Name = "grpPositionInfo";
            this.grpPositionInfo.Padding = new System.Windows.Forms.Padding(10);
            this.grpPositionInfo.Size = new System.Drawing.Size(380, 110);
            this.grpPositionInfo.TabIndex = 4;
            this.grpPositionInfo.TabStop = false;
            this.grpPositionInfo.Text = "Position Information";
            this.grpPositionInfo.Enter += new System.EventHandler(this.grpPositionInfo_Enter);
            // 
            // lblJobTitle
            // 
            this.lblJobTitle.AutoSize = true;
            this.lblJobTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobTitle.Location = new System.Drawing.Point(12, 29);
            this.lblJobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJobTitle.Name = "lblJobTitle";
            this.lblJobTitle.Size = new System.Drawing.Size(54, 13);
            this.lblJobTitle.TabIndex = 0;
            this.lblJobTitle.Text = "Job Title:";
            // 
            // dtpDataFiled
            // 
            this.dtpDataFiled.Location = new System.Drawing.Point(120, 80);
            this.dtpDataFiled.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDataFiled.Name = "dtpDataFiled";
            this.dtpDataFiled.Size = new System.Drawing.Size(180, 20);
            this.dtpDataFiled.TabIndex = 8;
            // 
            // txtDept
            // 
            this.txtDept.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDept.Location = new System.Drawing.Point(120, 52);
            this.txtDept.Margin = new System.Windows.Forms.Padding(2);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(240, 23);
            this.txtDept.TabIndex = 7;
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJobTitle.Location = new System.Drawing.Point(120, 25);
            this.txtJobTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(240, 23);
            this.txtJobTitle.TabIndex = 6;
            this.txtJobTitle.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblDataFiled
            // 
            this.lblDataFiled.AutoSize = true;
            this.lblDataFiled.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFiled.Location = new System.Drawing.Point(12, 83);
            this.lblDataFiled.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataFiled.Name = "lblDataFiled";
            this.lblDataFiled.Size = new System.Drawing.Size(62, 13);
            this.lblDataFiled.TabIndex = 2;
            this.lblDataFiled.Text = "Date Filed:";
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept.Location = new System.Drawing.Point(12, 56);
            this.lblDept.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(72, 13);
            this.lblDept.TabIndex = 1;
            this.lblDept.Text = "Department:";
            // 
            // grpSteps
            // 
            this.grpSteps.BackColor = System.Drawing.Color.White;
            this.grpSteps.Controls.Add(this.clbApplicationSteps);
            this.grpSteps.Location = new System.Drawing.Point(420, 155);
            this.grpSteps.Margin = new System.Windows.Forms.Padding(2);
            this.grpSteps.Name = "grpSteps";
            this.grpSteps.Padding = new System.Windows.Forms.Padding(10);
            this.grpSteps.Size = new System.Drawing.Size(655, 110);
            this.grpSteps.TabIndex = 5;
            this.grpSteps.TabStop = false;
            this.grpSteps.Text = "Application Steps";
            // 
            // clbApplicationSteps
            // 
            this.clbApplicationSteps.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbApplicationSteps.FormattingEnabled = true;
            this.clbApplicationSteps.Items.AddRange(new object[] {
            "Profile Completed",
            "Mandatory Documents Uploaded",
            "HR Preliminary Review",
            "Technical Panel Interview"});
            this.clbApplicationSteps.Location = new System.Drawing.Point(12, 20);
            this.clbApplicationSteps.Margin = new System.Windows.Forms.Padding(2);
            this.clbApplicationSteps.Name = "clbApplicationSteps";
            this.clbApplicationSteps.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.clbApplicationSteps.Size = new System.Drawing.Size(626, 72);
            this.clbApplicationSteps.TabIndex = 0;
            // 
            // pnlStatusBanner
            // 
            this.pnlStatusBanner.BackColor = System.Drawing.Color.White;
            this.pnlStatusBanner.Controls.Add(this.txtScreeningNotes);
            this.pnlStatusBanner.Controls.Add(this.lblStatusDescription);
            this.pnlStatusBanner.Controls.Add(this.lblCurrentStatus);
            this.pnlStatusBanner.Location = new System.Drawing.Point(20, 285);
            this.pnlStatusBanner.Margin = new System.Windows.Forms.Padding(2);
            this.pnlStatusBanner.Name = "pnlStatusBanner";
            this.pnlStatusBanner.Padding = new System.Windows.Forms.Padding(12);
            this.pnlStatusBanner.Size = new System.Drawing.Size(1055, 195);
            this.pnlStatusBanner.TabIndex = 7;
            // 
            // txtScreeningNotes
            // 
            this.txtScreeningNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScreeningNotes.Location = new System.Drawing.Point(12, 66);
            this.txtScreeningNotes.Multiline = true;
            this.txtScreeningNotes.Name = "txtScreeningNotes";
            this.txtScreeningNotes.ReadOnly = true;
            this.txtScreeningNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScreeningNotes.Size = new System.Drawing.Size(1031, 110);
            this.txtScreeningNotes.TabIndex = 8;
            // 
            // lblStatusDescription
            // 
            this.lblStatusDescription.AutoSize = true;
            this.lblStatusDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusDescription.Location = new System.Drawing.Point(12, 36);
            this.lblStatusDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusDescription.Name = "lblStatusDescription";
            this.lblStatusDescription.Size = new System.Drawing.Size(105, 15);
            this.lblStatusDescription.TabIndex = 7;
            this.lblStatusDescription.Text = "Status Description:";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(12, 12);
            this.lblCurrentStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(107, 19);
            this.lblCurrentStatus.TabIndex = 6;
            this.lblCurrentStatus.Text = "Current Status:";
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(1100, 510);
            this.Controls.Add(this.pnlStatusBanner);
            this.Controls.Add(this.grpSteps);
            this.Controls.Add(this.grpPositionInfo);
            this.Controls.Add(this.lblWelcomeHeader);
            this.Controls.Add(this.panelMyApplicationNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ApplicantPage1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Application";
            this.Load += new System.EventHandler(this.ApplicantPage1_Load);
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyApplicationNavigation.ResumeLayout(false);
            this.grpPositionInfo.ResumeLayout(false);
            this.grpPositionInfo.PerformLayout();
            this.grpSteps.ResumeLayout(false);
            this.pnlStatusBanner.ResumeLayout(false);
            this.pnlStatusBanner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblWelcomeHeader;
        private System.Windows.Forms.GroupBox grpPositionInfo;
        private System.Windows.Forms.Label lblDataFiled;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.GroupBox grpSteps;
        private System.Windows.Forms.CheckedListBox clbApplicationSteps;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.DateTimePicker dtpDataFiled;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Panel pnlStatusBanner;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblStatusDescription;
        private System.Windows.Forms.TextBox txtScreeningNotes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblJobTitle;
    }
}
