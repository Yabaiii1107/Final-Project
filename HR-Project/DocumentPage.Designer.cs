namespace HR_Project
{
    partial class DocumentPage
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
            this.panelMyDocumentsHeader = new System.Windows.Forms.Panel();
            this.lblMyDocumentsTitle = new System.Windows.Forms.Label();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.panelMyDocumentsNavigation = new System.Windows.Forms.Panel();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.btnMyDocumentsMyProfile = new System.Windows.Forms.Button();
            this.btnMyDocumentsJobVacancies = new System.Windows.Forms.Button();
            this.btnMyDocumentsMyApplication = new System.Windows.Forms.Button();
            this.btnMyDocumentsDocuments = new System.Windows.Forms.Button();
            this.btnMyDocumentsStatusTracking = new System.Windows.Forms.Button();
            this.lblReqAppDoc = new System.Windows.Forms.Label();
            this.grpMyDocumentsSummary = new System.Windows.Forms.GroupBox();
            this.lblMyDocumentsSubmittedDocuments = new System.Windows.Forms.Label();
            this.lblMyDocumentsSubmittedCount = new System.Windows.Forms.Label();
            this.lbMyDocumentslMissingRequirements = new System.Windows.Forms.Label();
            this.lblMyDocumentsMissingCount = new System.Windows.Forms.Label();
            this.chkMyDocumentsResume = new System.Windows.Forms.CheckBox();
            this.chkMyDocumentsGovernmentID = new System.Windows.Forms.CheckBox();
            this.chkMyDocumentsTranscript = new System.Windows.Forms.CheckBox();
            this.chkMyDocumentsCertificates = new System.Windows.Forms.CheckBox();
            this.grpMyDocumentsSubmissionPanel = new System.Windows.Forms.GroupBox();
            this.lblUploadLockNotice = new System.Windows.Forms.Label();
            this.lblMyDocumentsSelectDocuType = new System.Windows.Forms.Label();
            this.cmbMyDocumentsDocuType = new System.Windows.Forms.ComboBox();
            this.lblMyDocumentsFilePath = new System.Windows.Forms.Label();
            this.txtMyDocumentsFilePath = new System.Windows.Forms.TextBox();
            this.btnMyDocumentsBrowse = new System.Windows.Forms.Button();
            this.btnMyDocumentsUploadFile = new System.Windows.Forms.Button();
            this.dgvMyDocumentsStatusTrap = new System.Windows.Forms.DataGridView();
            this.colDocType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyDocumentsNavigation.SuspendLayout();
            this.grpMyDocumentsSummary.SuspendLayout();
            this.grpMyDocumentsSubmissionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDocumentsStatusTrap)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMyDocumentsHeader
            // 
            this.panelMyDocumentsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.panelMyDocumentsHeader.Controls.Add(this.lblMyDocumentsTitle);
            this.panelMyDocumentsHeader.Controls.Add(this.btnMyDocumentsLogout);
            this.panelMyDocumentsHeader.Controls.Add(this.btnProfilePageClose);
            this.panelMyDocumentsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyDocumentsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMyDocumentsHeader.Name = "panelMyDocumentsHeader";
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(1240, 60);
            this.panelMyDocumentsHeader.TabIndex = 0;
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(20, 18);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(150, 25);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "Applicant Portal";
            // 
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMyDocumentsLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMyDocumentsLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsLogout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(1110, 17);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(87, 26);
            this.btnMyDocumentsLogout.TabIndex = 1;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = false;
            this.btnMyDocumentsLogout.Click += new System.EventHandler(this.btnMyDocumentsLogout_Click);
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnProfilePageClose.Location = new System.Drawing.Point(1205, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(42, 32);
            this.btnProfilePageClose.TabIndex = 2;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
            this.btnProfilePageClose.Click += new System.EventHandler(this.btnProfilePageClose_Click);
            // 
            // panelMyDocumentsNavigation
            // 
            this.panelMyDocumentsNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsMyProfile);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsJobVacancies);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsMyApplication);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDocuments);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsStatusTracking);
            this.panelMyDocumentsNavigation.Location = new System.Drawing.Point(0, 60);
            this.panelMyDocumentsNavigation.Name = "panelMyDocumentsNavigation";
            this.panelMyDocumentsNavigation.Size = new System.Drawing.Size(1240, 42);
            this.panelMyDocumentsNavigation.TabIndex = 1;
            // 
            // btnMyDocumentsDashboard
            // 
            this.btnMyDocumentsDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsDashboard.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDashboard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(20, 0);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(90, 39);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            // 
            // btnMyDocumentsMyProfile
            // 
            this.btnMyDocumentsMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsMyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsMyProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsMyProfile.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsMyProfile.Location = new System.Drawing.Point(120, 0);
            this.btnMyDocumentsMyProfile.Name = "btnMyDocumentsMyProfile";
            this.btnMyDocumentsMyProfile.Size = new System.Drawing.Size(87, 42);
            this.btnMyDocumentsMyProfile.TabIndex = 1;
            this.btnMyDocumentsMyProfile.Text = "My Profile";
            this.btnMyDocumentsMyProfile.UseVisualStyleBackColor = false;
            this.btnMyDocumentsMyProfile.Click += new System.EventHandler(this.btnMyDocumentsMyProfile_Click);
            // 
            // btnMyDocumentsJobVacancies
            // 
            this.btnMyDocumentsJobVacancies.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsJobVacancies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsJobVacancies.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsJobVacancies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsJobVacancies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsJobVacancies.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsJobVacancies.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsJobVacancies.Location = new System.Drawing.Point(217, 0);
            this.btnMyDocumentsJobVacancies.Name = "btnMyDocumentsJobVacancies";
            this.btnMyDocumentsJobVacancies.Size = new System.Drawing.Size(104, 42);
            this.btnMyDocumentsJobVacancies.TabIndex = 2;
            this.btnMyDocumentsJobVacancies.Text = "Job Vacancies";
            this.btnMyDocumentsJobVacancies.UseVisualStyleBackColor = false;
            // 
            // btnMyDocumentsMyApplication
            // 
            this.btnMyDocumentsMyApplication.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsMyApplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsMyApplication.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsMyApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsMyApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsMyApplication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsMyApplication.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsMyApplication.Location = new System.Drawing.Point(331, 0);
            this.btnMyDocumentsMyApplication.Name = "btnMyDocumentsMyApplication";
            this.btnMyDocumentsMyApplication.Size = new System.Drawing.Size(104, 42);
            this.btnMyDocumentsMyApplication.TabIndex = 3;
            this.btnMyDocumentsMyApplication.Text = "My Application";
            this.btnMyDocumentsMyApplication.UseVisualStyleBackColor = false;
            // 
            // btnMyDocumentsDocuments
            // 
            this.btnMyDocumentsDocuments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsDocuments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsDocuments.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(100)))));
            this.btnMyDocumentsDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(90)))));
            this.btnMyDocumentsDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDocuments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnMyDocumentsDocuments.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsDocuments.Location = new System.Drawing.Point(445, 0);
            this.btnMyDocumentsDocuments.Name = "btnMyDocumentsDocuments";
            this.btnMyDocumentsDocuments.Size = new System.Drawing.Size(95, 42);
            this.btnMyDocumentsDocuments.TabIndex = 4;
            this.btnMyDocumentsDocuments.Text = "Documents";
            this.btnMyDocumentsDocuments.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDocuments.Click += new System.EventHandler(this.btnMyDocumentsDocuments_Click);
            // 
            // btnMyDocumentsStatusTracking
            // 
            this.btnMyDocumentsStatusTracking.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsStatusTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsStatusTracking.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsStatusTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsStatusTracking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMyDocumentsStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsStatusTracking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsStatusTracking.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsStatusTracking.Location = new System.Drawing.Point(550, 0);
            this.btnMyDocumentsStatusTracking.Name = "btnMyDocumentsStatusTracking";
            this.btnMyDocumentsStatusTracking.Size = new System.Drawing.Size(112, 42);
            this.btnMyDocumentsStatusTracking.TabIndex = 5;
            this.btnMyDocumentsStatusTracking.Text = "Status Tracking";
            this.btnMyDocumentsStatusTracking.UseVisualStyleBackColor = false;
            // 
            // lblReqAppDoc
            // 
            this.lblReqAppDoc.AutoSize = true;
            this.lblReqAppDoc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblReqAppDoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblReqAppDoc.Location = new System.Drawing.Point(20, 120);
            this.lblReqAppDoc.Name = "lblReqAppDoc";
            this.lblReqAppDoc.Size = new System.Drawing.Size(140, 25);
            this.lblReqAppDoc.TabIndex = 2;
            this.lblReqAppDoc.Text = "My Documents";
            // 
            // grpMyDocumentsSummary
            // 
            this.grpMyDocumentsSummary.BackColor = System.Drawing.Color.White;
            this.grpMyDocumentsSummary.Controls.Add(this.lblMyDocumentsSubmittedDocuments);
            this.grpMyDocumentsSummary.Controls.Add(this.lblMyDocumentsSubmittedCount);
            this.grpMyDocumentsSummary.Controls.Add(this.lbMyDocumentslMissingRequirements);
            this.grpMyDocumentsSummary.Controls.Add(this.lblMyDocumentsMissingCount);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsResume);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsGovernmentID);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsTranscript);
            this.grpMyDocumentsSummary.Controls.Add(this.chkMyDocumentsCertificates);
            this.grpMyDocumentsSummary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMyDocumentsSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grpMyDocumentsSummary.Location = new System.Drawing.Point(20, 155);
            this.grpMyDocumentsSummary.Name = "grpMyDocumentsSummary";
            this.grpMyDocumentsSummary.Padding = new System.Windows.Forms.Padding(10);
            this.grpMyDocumentsSummary.Size = new System.Drawing.Size(440, 148);
            this.grpMyDocumentsSummary.TabIndex = 3;
            this.grpMyDocumentsSummary.TabStop = false;
            this.grpMyDocumentsSummary.Text = "Document Compliance Summary";
            // 
            // lblMyDocumentsSubmittedDocuments
            // 
            this.lblMyDocumentsSubmittedDocuments.AutoSize = true;
            this.lblMyDocumentsSubmittedDocuments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyDocumentsSubmittedDocuments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblMyDocumentsSubmittedDocuments.Location = new System.Drawing.Point(12, 28);
            this.lblMyDocumentsSubmittedDocuments.Name = "lblMyDocumentsSubmittedDocuments";
            this.lblMyDocumentsSubmittedDocuments.Size = new System.Drawing.Size(129, 15);
            this.lblMyDocumentsSubmittedDocuments.TabIndex = 0;
            this.lblMyDocumentsSubmittedDocuments.Text = "Submitted Documents:";
            // 
            // lblMyDocumentsSubmittedCount
            // 
            this.lblMyDocumentsSubmittedCount.AutoSize = true;
            this.lblMyDocumentsSubmittedCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMyDocumentsSubmittedCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(199)))), ((int)(((byte)(89)))));
            this.lblMyDocumentsSubmittedCount.Location = new System.Drawing.Point(165, 26);
            this.lblMyDocumentsSubmittedCount.Name = "lblMyDocumentsSubmittedCount";
            this.lblMyDocumentsSubmittedCount.Size = new System.Drawing.Size(18, 20);
            this.lblMyDocumentsSubmittedCount.TabIndex = 1;
            this.lblMyDocumentsSubmittedCount.Text = "0";
            // 
            // lbMyDocumentslMissingRequirements
            // 
            this.lbMyDocumentslMissingRequirements.AutoSize = true;
            this.lbMyDocumentslMissingRequirements.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbMyDocumentslMissingRequirements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lbMyDocumentslMissingRequirements.Location = new System.Drawing.Point(12, 58);
            this.lbMyDocumentslMissingRequirements.Name = "lbMyDocumentslMissingRequirements";
            this.lbMyDocumentslMissingRequirements.Size = new System.Drawing.Size(127, 15);
            this.lbMyDocumentslMissingRequirements.TabIndex = 2;
            this.lbMyDocumentslMissingRequirements.Text = "Missing Requirements:";
            // 
            // lblMyDocumentsMissingCount
            // 
            this.lblMyDocumentsMissingCount.AutoSize = true;
            this.lblMyDocumentsMissingCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMyDocumentsMissingCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.lblMyDocumentsMissingCount.Location = new System.Drawing.Point(165, 56);
            this.lblMyDocumentsMissingCount.Name = "lblMyDocumentsMissingCount";
            this.lblMyDocumentsMissingCount.Size = new System.Drawing.Size(18, 20);
            this.lblMyDocumentsMissingCount.TabIndex = 3;
            this.lblMyDocumentsMissingCount.Text = "0";
            // 
            // chkMyDocumentsResume
            // 
            this.chkMyDocumentsResume.AutoSize = true;
            this.chkMyDocumentsResume.Enabled = false;
            this.chkMyDocumentsResume.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMyDocumentsResume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkMyDocumentsResume.Location = new System.Drawing.Point(230, 26);
            this.chkMyDocumentsResume.Name = "chkMyDocumentsResume";
            this.chkMyDocumentsResume.Size = new System.Drawing.Size(94, 19);
            this.chkMyDocumentsResume.TabIndex = 4;
            this.chkMyDocumentsResume.Text = "Resume / CV";
            // 
            // chkMyDocumentsGovernmentID
            // 
            this.chkMyDocumentsGovernmentID.AutoSize = true;
            this.chkMyDocumentsGovernmentID.Enabled = false;
            this.chkMyDocumentsGovernmentID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMyDocumentsGovernmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkMyDocumentsGovernmentID.Location = new System.Drawing.Point(230, 52);
            this.chkMyDocumentsGovernmentID.Name = "chkMyDocumentsGovernmentID";
            this.chkMyDocumentsGovernmentID.Size = new System.Drawing.Size(106, 19);
            this.chkMyDocumentsGovernmentID.TabIndex = 5;
            this.chkMyDocumentsGovernmentID.Text = "Government ID";
            // 
            // chkMyDocumentsTranscript
            // 
            this.chkMyDocumentsTranscript.AutoSize = true;
            this.chkMyDocumentsTranscript.Enabled = false;
            this.chkMyDocumentsTranscript.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMyDocumentsTranscript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkMyDocumentsTranscript.Location = new System.Drawing.Point(230, 78);
            this.chkMyDocumentsTranscript.Name = "chkMyDocumentsTranscript";
            this.chkMyDocumentsTranscript.Size = new System.Drawing.Size(77, 19);
            this.chkMyDocumentsTranscript.TabIndex = 6;
            this.chkMyDocumentsTranscript.Text = "Transcript";
            // 
            // chkMyDocumentsCertificates
            // 
            this.chkMyDocumentsCertificates.AutoSize = true;
            this.chkMyDocumentsCertificates.Enabled = false;
            this.chkMyDocumentsCertificates.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkMyDocumentsCertificates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.chkMyDocumentsCertificates.Location = new System.Drawing.Point(230, 104);
            this.chkMyDocumentsCertificates.Name = "chkMyDocumentsCertificates";
            this.chkMyDocumentsCertificates.Size = new System.Drawing.Size(85, 19);
            this.chkMyDocumentsCertificates.TabIndex = 7;
            this.chkMyDocumentsCertificates.Text = "Certificates";
            // 
            // grpMyDocumentsSubmissionPanel
            // 
            this.grpMyDocumentsSubmissionPanel.BackColor = System.Drawing.Color.White;
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.lblUploadLockNotice);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.lblMyDocumentsSelectDocuType);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.cmbMyDocumentsDocuType);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.lblMyDocumentsFilePath);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.txtMyDocumentsFilePath);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.btnMyDocumentsBrowse);
            this.grpMyDocumentsSubmissionPanel.Controls.Add(this.btnMyDocumentsUploadFile);
            this.grpMyDocumentsSubmissionPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpMyDocumentsSubmissionPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.grpMyDocumentsSubmissionPanel.Location = new System.Drawing.Point(20, 318);
            this.grpMyDocumentsSubmissionPanel.Name = "grpMyDocumentsSubmissionPanel";
            this.grpMyDocumentsSubmissionPanel.Padding = new System.Windows.Forms.Padding(10);
            this.grpMyDocumentsSubmissionPanel.Size = new System.Drawing.Size(440, 110);
            this.grpMyDocumentsSubmissionPanel.TabIndex = 4;
            this.grpMyDocumentsSubmissionPanel.TabStop = false;
            this.grpMyDocumentsSubmissionPanel.Text = "Upload Document";
            // 
            // lblUploadLockNotice
            // 
            this.lblUploadLockNotice.AutoSize = true;
            this.lblUploadLockNotice.Location = new System.Drawing.Point(2, 85);
            this.lblUploadLockNotice.Name = "lblUploadLockNotice";
            this.lblUploadLockNotice.Size = new System.Drawing.Size(40, 15);
            this.lblUploadLockNotice.TabIndex = 6;
            this.lblUploadLockNotice.Text = "label1";
            this.lblUploadLockNotice.Visible = false;
            // 
            // lblMyDocumentsSelectDocuType
            // 
            this.lblMyDocumentsSelectDocuType.AutoSize = true;
            this.lblMyDocumentsSelectDocuType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyDocumentsSelectDocuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblMyDocumentsSelectDocuType.Location = new System.Drawing.Point(12, 30);
            this.lblMyDocumentsSelectDocuType.Name = "lblMyDocumentsSelectDocuType";
            this.lblMyDocumentsSelectDocuType.Size = new System.Drawing.Size(93, 15);
            this.lblMyDocumentsSelectDocuType.TabIndex = 0;
            this.lblMyDocumentsSelectDocuType.Text = "Document Type:";
            // 
            // cmbMyDocumentsDocuType
            // 
            this.cmbMyDocumentsDocuType.BackColor = System.Drawing.Color.White;
            this.cmbMyDocumentsDocuType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMyDocumentsDocuType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMyDocumentsDocuType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMyDocumentsDocuType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbMyDocumentsDocuType.FormattingEnabled = true;
            this.cmbMyDocumentsDocuType.Items.AddRange(new object[] {
            "Resume/CV",
            "Government ID",
            "Transcript",
            "Certificates"});
            this.cmbMyDocumentsDocuType.Location = new System.Drawing.Point(130, 27);
            this.cmbMyDocumentsDocuType.Name = "cmbMyDocumentsDocuType";
            this.cmbMyDocumentsDocuType.Size = new System.Drawing.Size(150, 23);
            this.cmbMyDocumentsDocuType.TabIndex = 1;
            this.cmbMyDocumentsDocuType.SelectedIndexChanged += new System.EventHandler(this.cmbMyDocumentsDocuType_SelectedIndexChanged);
            // 
            // lblMyDocumentsFilePath
            // 
            this.lblMyDocumentsFilePath.AutoSize = true;
            this.lblMyDocumentsFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMyDocumentsFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(150)))));
            this.lblMyDocumentsFilePath.Location = new System.Drawing.Point(12, 62);
            this.lblMyDocumentsFilePath.Name = "lblMyDocumentsFilePath";
            this.lblMyDocumentsFilePath.Size = new System.Drawing.Size(28, 15);
            this.lblMyDocumentsFilePath.TabIndex = 2;
            this.lblMyDocumentsFilePath.Text = "File:";
            // 
            // txtMyDocumentsFilePath
            // 
            this.txtMyDocumentsFilePath.BackColor = System.Drawing.Color.White;
            this.txtMyDocumentsFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMyDocumentsFilePath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMyDocumentsFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtMyDocumentsFilePath.Location = new System.Drawing.Point(40, 59);
            this.txtMyDocumentsFilePath.Name = "txtMyDocumentsFilePath";
            this.txtMyDocumentsFilePath.ReadOnly = true;
            this.txtMyDocumentsFilePath.Size = new System.Drawing.Size(240, 23);
            this.txtMyDocumentsFilePath.TabIndex = 3;
            // 
            // btnMyDocumentsBrowse
            // 
            this.btnMyDocumentsBrowse.BackColor = System.Drawing.Color.White;
            this.btnMyDocumentsBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.btnMyDocumentsBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnMyDocumentsBrowse.Location = new System.Drawing.Point(288, 58);
            this.btnMyDocumentsBrowse.Name = "btnMyDocumentsBrowse";
            this.btnMyDocumentsBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnMyDocumentsBrowse.TabIndex = 4;
            this.btnMyDocumentsBrowse.Text = "Browse...";
            this.btnMyDocumentsBrowse.UseVisualStyleBackColor = false;
            this.btnMyDocumentsBrowse.Click += new System.EventHandler(this.btnMyDocumentsBrowse_Click);
            // 
            // btnMyDocumentsUploadFile
            // 
            this.btnMyDocumentsUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnMyDocumentsUploadFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyDocumentsUploadFile.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsUploadFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMyDocumentsUploadFile.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsUploadFile.Location = new System.Drawing.Point(371, 58);
            this.btnMyDocumentsUploadFile.Name = "btnMyDocumentsUploadFile";
            this.btnMyDocumentsUploadFile.Size = new System.Drawing.Size(55, 25);
            this.btnMyDocumentsUploadFile.TabIndex = 5;
            this.btnMyDocumentsUploadFile.Text = "Upload";
            this.btnMyDocumentsUploadFile.UseVisualStyleBackColor = false;
            this.btnMyDocumentsUploadFile.Click += new System.EventHandler(this.btnMyDocumentsUploadFile_Click);
            // 
            // dgvMyDocumentsStatusTrap
            // 
            this.dgvMyDocumentsStatusTrap.AllowUserToAddRows = false;
            this.dgvMyDocumentsStatusTrap.AllowUserToResizeRows = false;
            this.dgvMyDocumentsStatusTrap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyDocumentsStatusTrap.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyDocumentsStatusTrap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMyDocumentsStatusTrap.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMyDocumentsStatusTrap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMyDocumentsStatusTrap.ColumnHeadersHeight = 36;
            this.dgvMyDocumentsStatusTrap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMyDocumentsStatusTrap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDocType,
            this.colStatus,
            this.colRemarks,
            this.colFileName});
            this.dgvMyDocumentsStatusTrap.EnableHeadersVisualStyles = false;
            this.dgvMyDocumentsStatusTrap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(230)))));
            this.dgvMyDocumentsStatusTrap.Location = new System.Drawing.Point(480, 155);
            this.dgvMyDocumentsStatusTrap.Name = "dgvMyDocumentsStatusTrap";
            this.dgvMyDocumentsStatusTrap.ReadOnly = true;
            this.dgvMyDocumentsStatusTrap.RowHeadersVisible = false;
            this.dgvMyDocumentsStatusTrap.RowTemplate.Height = 36;
            this.dgvMyDocumentsStatusTrap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyDocumentsStatusTrap.Size = new System.Drawing.Size(730, 273);
            this.dgvMyDocumentsStatusTrap.TabIndex = 5;
            // 
            // colDocType
            // 
            this.colDocType.DataPropertyName = "document_type";
            this.colDocType.HeaderText = "Document Type";
            this.colDocType.Name = "colDocType";
            this.colDocType.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // colRemarks
            // 
            this.colRemarks.DataPropertyName = "hr_remarks";
            this.colRemarks.HeaderText = "HR Remarks";
            this.colRemarks.Name = "colRemarks";
            this.colRemarks.ReadOnly = true;
            // 
            // colFileName
            // 
            this.colFileName.DataPropertyName = "file_name";
            this.colFileName.HeaderText = "File Name";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // DocumentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.Controls.Add(this.panelMyDocumentsNavigation);
            this.Controls.Add(this.lblReqAppDoc);
            this.Controls.Add(this.grpMyDocumentsSummary);
            this.Controls.Add(this.grpMyDocumentsSubmissionPanel);
            this.Controls.Add(this.dgvMyDocumentsStatusTrap);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocumentPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DocumentPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyDocumentsNavigation.ResumeLayout(false);
            this.grpMyDocumentsSummary.ResumeLayout(false);
            this.grpMyDocumentsSummary.PerformLayout();
            this.grpMyDocumentsSubmissionPanel.ResumeLayout(false);
            this.grpMyDocumentsSubmissionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDocumentsStatusTrap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMyDocumentsHeader;
        private System.Windows.Forms.Label lblMyDocumentsTitle;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Panel panelMyDocumentsNavigation;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private System.Windows.Forms.Button btnMyDocumentsMyProfile;
        private System.Windows.Forms.Button btnMyDocumentsJobVacancies;
        private System.Windows.Forms.Button btnMyDocumentsMyApplication;
        private System.Windows.Forms.Button btnMyDocumentsDocuments;
        private System.Windows.Forms.Button btnMyDocumentsStatusTracking;
        private System.Windows.Forms.Label lblReqAppDoc;
        private System.Windows.Forms.GroupBox grpMyDocumentsSummary;
        private System.Windows.Forms.Label lblMyDocumentsSubmittedDocuments;
        private System.Windows.Forms.Label lblMyDocumentsSubmittedCount;
        private System.Windows.Forms.Label lbMyDocumentslMissingRequirements;
        private System.Windows.Forms.Label lblMyDocumentsMissingCount;
        private System.Windows.Forms.CheckBox chkMyDocumentsResume;
        private System.Windows.Forms.CheckBox chkMyDocumentsGovernmentID;
        private System.Windows.Forms.CheckBox chkMyDocumentsTranscript;
        private System.Windows.Forms.CheckBox chkMyDocumentsCertificates;
        private System.Windows.Forms.GroupBox grpMyDocumentsSubmissionPanel;
        private System.Windows.Forms.Label lblMyDocumentsSelectDocuType;
        private System.Windows.Forms.ComboBox cmbMyDocumentsDocuType;
        private System.Windows.Forms.Label lblMyDocumentsFilePath;
        private System.Windows.Forms.TextBox txtMyDocumentsFilePath;
        private System.Windows.Forms.Button btnMyDocumentsBrowse;
        private System.Windows.Forms.Button btnMyDocumentsUploadFile;
        private System.Windows.Forms.DataGridView dgvMyDocumentsStatusTrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblUploadLockNotice;
    }
}

