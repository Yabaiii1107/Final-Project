namespace HR_Project.HR_System
{
    partial class HRApplicants
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHiringDecision = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnScreening = new System.Windows.Forms.Button();
            this.btnApplicants = new System.Windows.Forms.Button();
            this.btnJobVacanciesManagement = new System.Windows.Forms.Button();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.lblSearchApplicant = new System.Windows.Forms.Label();
            this.txtBoxSearchApplicant = new System.Windows.Forms.TextBox();
            this.btnSearchApplicant = new System.Windows.Forms.Button();
            this.lbFilterStatus = new System.Windows.Forms.Label();
            this.cmbBoxFilterStatus = new System.Windows.Forms.ComboBox();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.grpBoxApplicantDetails = new System.Windows.Forms.GroupBox();
            this.btnViewFullProfile = new System.Windows.Forms.Button();
            this.cmbCurrentStatus = new System.Windows.Forms.ComboBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblApplicationDate1 = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblPositionApplied1 = new System.Windows.Forms.Label();
            this.lblPositionApplied = new System.Windows.Forms.Label();
            this.lblContactNumber1 = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblEmail1 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFullName1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblApplicantID1 = new System.Windows.Forms.Label();
            this.lblApplicantID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCertificatesView = new System.Windows.Forms.Button();
            this.btnTranscriptView = new System.Windows.Forms.Button();
            this.btnGovernmentIDView = new System.Windows.Forms.Button();
            this.btnResumeView = new System.Windows.Forms.Button();
            this.lblCertificates = new System.Windows.Forms.Label();
            this.lblTranscript = new System.Windows.Forms.Label();
            this.lblGovernmentID = new System.Windows.Forms.Label();
            this.lblResume = new System.Windows.Forms.Label();
            this.grpBoxActions = new System.Windows.Forms.GroupBox();
            this.btnScheduleInterview = new System.Windows.Forms.Button();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.grpBoxApplicantDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpBoxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelHeader.Controls.Add(this.btnProfilePageClose);
            this.panelHeader.Controls.Add(this.btnMyDocumentsLogout);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 60);
            this.panelHeader.TabIndex = 15;
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.Red;
            this.btnProfilePageClose.Location = new System.Drawing.Point(764, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(36, 29);
            this.btnProfilePageClose.TabIndex = 4;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
            this.btnProfilePageClose.Click += new System.EventHandler(this.btnProfilePageClose_Click_1);
            // 
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(684, 23);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsLogout.TabIndex = 3;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = true;
            this.btnMyDocumentsLogout.Click += new System.EventHandler(this.btnMyDocumentsLogout_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(226, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Applicants Management";
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panelNavigation.Controls.Add(this.btnReports);
            this.panelNavigation.Controls.Add(this.btnHiringDecision);
            this.panelNavigation.Controls.Add(this.btnInterviews);
            this.panelNavigation.Controls.Add(this.btnScreening);
            this.panelNavigation.Controls.Add(this.btnApplicants);
            this.panelNavigation.Controls.Add(this.btnJobVacanciesManagement);
            this.panelNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelNavigation.Location = new System.Drawing.Point(0, 52);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(800, 43);
            this.panelNavigation.TabIndex = 16;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Blue;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(674, 9);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(96, 23);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnHiringDecision
            // 
            this.btnHiringDecision.BackColor = System.Drawing.Color.Blue;
            this.btnHiringDecision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnHiringDecision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnHiringDecision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHiringDecision.ForeColor = System.Drawing.Color.White;
            this.btnHiringDecision.Location = new System.Drawing.Point(559, 9);
            this.btnHiringDecision.Name = "btnHiringDecision";
            this.btnHiringDecision.Size = new System.Drawing.Size(96, 23);
            this.btnHiringDecision.TabIndex = 3;
            this.btnHiringDecision.Text = "Hiring Decision";
            this.btnHiringDecision.UseVisualStyleBackColor = false;
            // 
            // btnInterviews
            // 
            this.btnInterviews.BackColor = System.Drawing.Color.Blue;
            this.btnInterviews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnInterviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnInterviews.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInterviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterviews.ForeColor = System.Drawing.Color.Transparent;
            this.btnInterviews.Location = new System.Drawing.Point(464, 9);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Size = new System.Drawing.Size(75, 23);
            this.btnInterviews.TabIndex = 2;
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.UseVisualStyleBackColor = false;
            // 
            // btnScreening
            // 
            this.btnScreening.BackColor = System.Drawing.Color.Blue;
            this.btnScreening.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnScreening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScreening.ForeColor = System.Drawing.Color.Transparent;
            this.btnScreening.Location = new System.Drawing.Point(355, 9);
            this.btnScreening.Name = "btnScreening";
            this.btnScreening.Size = new System.Drawing.Size(89, 23);
            this.btnScreening.TabIndex = 2;
            this.btnScreening.Text = "Screening";
            this.btnScreening.UseVisualStyleBackColor = false;
            // 
            // btnApplicants
            // 
            this.btnApplicants.BackColor = System.Drawing.Color.Blue;
            this.btnApplicants.Enabled = false;
            this.btnApplicants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnApplicants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplicants.ForeColor = System.Drawing.Color.Transparent;
            this.btnApplicants.Location = new System.Drawing.Point(244, 9);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(89, 23);
            this.btnApplicants.TabIndex = 2;
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.UseVisualStyleBackColor = false;
            // 
            // btnJobVacanciesManagement
            // 
            this.btnJobVacanciesManagement.BackColor = System.Drawing.Color.Blue;
            this.btnJobVacanciesManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnJobVacanciesManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnJobVacanciesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJobVacanciesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobVacanciesManagement.ForeColor = System.Drawing.Color.Transparent;
            this.btnJobVacanciesManagement.Location = new System.Drawing.Point(138, 9);
            this.btnJobVacanciesManagement.Name = "btnJobVacanciesManagement";
            this.btnJobVacanciesManagement.Size = new System.Drawing.Size(86, 23);
            this.btnJobVacanciesManagement.TabIndex = 1;
            this.btnJobVacanciesManagement.Text = "Job Vacancies";
            this.btnJobVacanciesManagement.UseVisualStyleBackColor = false;
            this.btnJobVacanciesManagement.Click += new System.EventHandler(this.btnJobVacanciesManagement_Click);
            // 
            // btnMyDocumentsDashboard
            // 
            this.btnMyDocumentsDashboard.BackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMyDocumentsDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(85, 23);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click);
            // 
            // lblSearchApplicant
            // 
            this.lblSearchApplicant.AutoSize = true;
            this.lblSearchApplicant.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchApplicant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchApplicant.Location = new System.Drawing.Point(28, 169);
            this.lblSearchApplicant.Name = "lblSearchApplicant";
            this.lblSearchApplicant.Size = new System.Drawing.Size(108, 13);
            this.lblSearchApplicant.TabIndex = 17;
            this.lblSearchApplicant.Text = "Search Applicant:";
            // 
            // txtBoxSearchApplicant
            // 
            this.txtBoxSearchApplicant.Location = new System.Drawing.Point(142, 166);
            this.txtBoxSearchApplicant.Name = "txtBoxSearchApplicant";
            this.txtBoxSearchApplicant.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSearchApplicant.TabIndex = 18;
            // 
            // btnSearchApplicant
            // 
            this.btnSearchApplicant.Location = new System.Drawing.Point(248, 164);
            this.btnSearchApplicant.Name = "btnSearchApplicant";
            this.btnSearchApplicant.Size = new System.Drawing.Size(75, 23);
            this.btnSearchApplicant.TabIndex = 19;
            this.btnSearchApplicant.Text = "Search";
            this.btnSearchApplicant.UseVisualStyleBackColor = true;
            this.btnSearchApplicant.TextChanged += new System.EventHandler(this.btnSearchApplicant_TextChanged);
            this.btnSearchApplicant.Click += new System.EventHandler(this.btnSearchApplicant_Click);
            // 
            // lbFilterStatus
            // 
            this.lbFilterStatus.AutoSize = true;
            this.lbFilterStatus.BackColor = System.Drawing.Color.Transparent;
            this.lbFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFilterStatus.Location = new System.Drawing.Point(28, 220);
            this.lbFilterStatus.Name = "lbFilterStatus";
            this.lbFilterStatus.Size = new System.Drawing.Size(79, 13);
            this.lbFilterStatus.TabIndex = 20;
            this.lbFilterStatus.Text = "Filter Status:";
            // 
            // cmbBoxFilterStatus
            // 
            this.cmbBoxFilterStatus.FormattingEnabled = true;
            this.cmbBoxFilterStatus.Location = new System.Drawing.Point(114, 220);
            this.cmbBoxFilterStatus.Name = "cmbBoxFilterStatus";
            this.cmbBoxFilterStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxFilterStatus.TabIndex = 21;
            this.cmbBoxFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cmbBoxFilterStatus_SelectedIndexChanged);
            // 
            // dgvApplicants
            // 
            this.dgvApplicants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicants.Location = new System.Drawing.Point(22, 265);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.Size = new System.Drawing.Size(439, 150);
            this.dgvApplicants.TabIndex = 22;
            this.dgvApplicants.SelectionChanged += new System.EventHandler(this.dgvApplicants_SelectionChanged);
            // 
            // grpBoxApplicantDetails
            // 
            this.grpBoxApplicantDetails.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxApplicantDetails.Controls.Add(this.btnViewFullProfile);
            this.grpBoxApplicantDetails.Controls.Add(this.cmbCurrentStatus);
            this.grpBoxApplicantDetails.Controls.Add(this.lblCurrentStatus);
            this.grpBoxApplicantDetails.Controls.Add(this.lblApplicationDate1);
            this.grpBoxApplicantDetails.Controls.Add(this.lblApplicationDate);
            this.grpBoxApplicantDetails.Controls.Add(this.lblPositionApplied1);
            this.grpBoxApplicantDetails.Controls.Add(this.lblPositionApplied);
            this.grpBoxApplicantDetails.Controls.Add(this.lblContactNumber1);
            this.grpBoxApplicantDetails.Controls.Add(this.lblContactNumber);
            this.grpBoxApplicantDetails.Controls.Add(this.lblEmail1);
            this.grpBoxApplicantDetails.Controls.Add(this.lblEmail);
            this.grpBoxApplicantDetails.Controls.Add(this.lblFullName1);
            this.grpBoxApplicantDetails.Controls.Add(this.lblFullName);
            this.grpBoxApplicantDetails.Controls.Add(this.lblApplicantID1);
            this.grpBoxApplicantDetails.Controls.Add(this.lblApplicantID);
            this.grpBoxApplicantDetails.Location = new System.Drawing.Point(479, 169);
            this.grpBoxApplicantDetails.Name = "grpBoxApplicantDetails";
            this.grpBoxApplicantDetails.Size = new System.Drawing.Size(269, 246);
            this.grpBoxApplicantDetails.TabIndex = 23;
            this.grpBoxApplicantDetails.TabStop = false;
            this.grpBoxApplicantDetails.Text = "Applicant Details";
            // 
            // btnViewFullProfile
            // 
            this.btnViewFullProfile.Location = new System.Drawing.Point(152, 198);
            this.btnViewFullProfile.Name = "btnViewFullProfile";
            this.btnViewFullProfile.Size = new System.Drawing.Size(96, 23);
            this.btnViewFullProfile.TabIndex = 32;
            this.btnViewFullProfile.Text = "Applicant Profile";
            this.btnViewFullProfile.UseVisualStyleBackColor = true;
            this.btnViewFullProfile.Click += new System.EventHandler(this.btnViewFullProfile_Click);
            // 
            // cmbCurrentStatus
            // 
            this.cmbCurrentStatus.FormattingEnabled = true;
            this.cmbCurrentStatus.Location = new System.Drawing.Point(6, 198);
            this.cmbCurrentStatus.Name = "cmbCurrentStatus";
            this.cmbCurrentStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbCurrentStatus.TabIndex = 31;
            this.cmbCurrentStatus.SelectedIndexChanged += new System.EventHandler(this.cmbCurrentStatus_SelectedIndexChanged);
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentStatus.Location = new System.Drawing.Point(6, 182);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(92, 13);
            this.lblCurrentStatus.TabIndex = 30;
            this.lblCurrentStatus.Text = "Current Status:";
            // 
            // lblApplicationDate1
            // 
            this.lblApplicationDate1.AutoSize = true;
            this.lblApplicationDate1.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate1.Location = new System.Drawing.Point(116, 153);
            this.lblApplicationDate1.Name = "lblApplicationDate1";
            this.lblApplicationDate1.Size = new System.Drawing.Size(85, 13);
            this.lblApplicationDate1.TabIndex = 29;
            this.lblApplicationDate1.Text = "Application Date";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.Location = new System.Drawing.Point(6, 153);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(105, 13);
            this.lblApplicationDate.TabIndex = 28;
            this.lblApplicationDate.Text = "Application Date:";
            // 
            // lblPositionApplied1
            // 
            this.lblPositionApplied1.AutoSize = true;
            this.lblPositionApplied1.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionApplied1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionApplied1.Location = new System.Drawing.Point(116, 128);
            this.lblPositionApplied1.Name = "lblPositionApplied1";
            this.lblPositionApplied1.Size = new System.Drawing.Size(82, 13);
            this.lblPositionApplied1.TabIndex = 27;
            this.lblPositionApplied1.Text = "Position Applied";
            // 
            // lblPositionApplied
            // 
            this.lblPositionApplied.AutoSize = true;
            this.lblPositionApplied.BackColor = System.Drawing.Color.Transparent;
            this.lblPositionApplied.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositionApplied.Location = new System.Drawing.Point(6, 128);
            this.lblPositionApplied.Name = "lblPositionApplied";
            this.lblPositionApplied.Size = new System.Drawing.Size(102, 13);
            this.lblPositionApplied.TabIndex = 26;
            this.lblPositionApplied.Text = "Position Applied:";
            // 
            // lblContactNumber1
            // 
            this.lblContactNumber1.AutoSize = true;
            this.lblContactNumber1.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber1.Location = new System.Drawing.Point(114, 106);
            this.lblContactNumber1.Name = "lblContactNumber1";
            this.lblContactNumber1.Size = new System.Drawing.Size(84, 13);
            this.lblContactNumber1.TabIndex = 25;
            this.lblContactNumber1.Text = "Contact Number";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(6, 106);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(102, 13);
            this.lblContactNumber.TabIndex = 24;
            this.lblContactNumber.Text = "Contact Number:";
            // 
            // lblEmail1
            // 
            this.lblEmail1.AutoSize = true;
            this.lblEmail1.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail1.Location = new System.Drawing.Point(79, 77);
            this.lblEmail1.Name = "lblEmail1";
            this.lblEmail1.Size = new System.Drawing.Size(32, 13);
            this.lblEmail1.TabIndex = 23;
            this.lblEmail1.Text = "Email";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(6, 77);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email:";
            // 
            // lblFullName1
            // 
            this.lblFullName1.AutoSize = true;
            this.lblFullName1.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName1.Location = new System.Drawing.Point(79, 54);
            this.lblFullName1.Name = "lblFullName1";
            this.lblFullName1.Size = new System.Drawing.Size(54, 13);
            this.lblFullName1.TabIndex = 21;
            this.lblFullName1.Text = "Full Name";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(6, 54);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(67, 13);
            this.lblFullName.TabIndex = 20;
            this.lblFullName.Text = "Full Name:";
            // 
            // lblApplicantID1
            // 
            this.lblApplicantID1.AutoSize = true;
            this.lblApplicantID1.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantID1.Location = new System.Drawing.Point(93, 29);
            this.lblApplicantID1.Name = "lblApplicantID1";
            this.lblApplicantID1.Size = new System.Drawing.Size(18, 13);
            this.lblApplicantID1.TabIndex = 19;
            this.lblApplicantID1.Text = "ID";
            // 
            // lblApplicantID
            // 
            this.lblApplicantID.AutoSize = true;
            this.lblApplicantID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantID.Location = new System.Drawing.Point(6, 29);
            this.lblApplicantID.Name = "lblApplicantID";
            this.lblApplicantID.Size = new System.Drawing.Size(81, 13);
            this.lblApplicantID.TabIndex = 18;
            this.lblApplicantID.Text = "Applicant ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCertificatesView);
            this.groupBox1.Controls.Add(this.btnTranscriptView);
            this.groupBox1.Controls.Add(this.btnGovernmentIDView);
            this.groupBox1.Controls.Add(this.btnResumeView);
            this.groupBox1.Controls.Add(this.lblCertificates);
            this.groupBox1.Controls.Add(this.lblTranscript);
            this.groupBox1.Controls.Add(this.lblGovernmentID);
            this.groupBox1.Controls.Add(this.lblResume);
            this.groupBox1.Location = new System.Drawing.Point(22, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 151);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Documents";
            // 
            // btnCertificatesView
            // 
            this.btnCertificatesView.Location = new System.Drawing.Point(120, 118);
            this.btnCertificatesView.Name = "btnCertificatesView";
            this.btnCertificatesView.Size = new System.Drawing.Size(82, 19);
            this.btnCertificatesView.TabIndex = 32;
            this.btnCertificatesView.Text = "View";
            this.btnCertificatesView.UseVisualStyleBackColor = true;
            this.btnCertificatesView.Click += new System.EventHandler(this.btnCertificatesView_Click);
            // 
            // btnTranscriptView
            // 
            this.btnTranscriptView.Location = new System.Drawing.Point(120, 93);
            this.btnTranscriptView.Name = "btnTranscriptView";
            this.btnTranscriptView.Size = new System.Drawing.Size(82, 19);
            this.btnTranscriptView.TabIndex = 31;
            this.btnTranscriptView.Text = "View";
            this.btnTranscriptView.UseVisualStyleBackColor = true;
            this.btnTranscriptView.Click += new System.EventHandler(this.btnTranscriptView_Click);
            // 
            // btnGovernmentIDView
            // 
            this.btnGovernmentIDView.Location = new System.Drawing.Point(120, 63);
            this.btnGovernmentIDView.Name = "btnGovernmentIDView";
            this.btnGovernmentIDView.Size = new System.Drawing.Size(82, 19);
            this.btnGovernmentIDView.TabIndex = 30;
            this.btnGovernmentIDView.Text = "View";
            this.btnGovernmentIDView.UseVisualStyleBackColor = true;
            this.btnGovernmentIDView.Click += new System.EventHandler(this.btnGovernmentIDView_Click);
            // 
            // btnResumeView
            // 
            this.btnResumeView.Location = new System.Drawing.Point(120, 39);
            this.btnResumeView.Name = "btnResumeView";
            this.btnResumeView.Size = new System.Drawing.Size(82, 19);
            this.btnResumeView.TabIndex = 29;
            this.btnResumeView.Text = "View";
            this.btnResumeView.UseVisualStyleBackColor = true;
            this.btnResumeView.Click += new System.EventHandler(this.btnResumeView_Click_1);
            // 
            // lblCertificates
            // 
            this.lblCertificates.AutoSize = true;
            this.lblCertificates.BackColor = System.Drawing.Color.Transparent;
            this.lblCertificates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCertificates.Location = new System.Drawing.Point(6, 122);
            this.lblCertificates.Name = "lblCertificates";
            this.lblCertificates.Size = new System.Drawing.Size(75, 13);
            this.lblCertificates.TabIndex = 24;
            this.lblCertificates.Text = "Certificates:";
            // 
            // lblTranscript
            // 
            this.lblTranscript.AutoSize = true;
            this.lblTranscript.BackColor = System.Drawing.Color.Transparent;
            this.lblTranscript.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTranscript.Location = new System.Drawing.Point(6, 96);
            this.lblTranscript.Name = "lblTranscript";
            this.lblTranscript.Size = new System.Drawing.Size(68, 13);
            this.lblTranscript.TabIndex = 22;
            this.lblTranscript.Text = "Transcript:";
            // 
            // lblGovernmentID
            // 
            this.lblGovernmentID.AutoSize = true;
            this.lblGovernmentID.BackColor = System.Drawing.Color.Transparent;
            this.lblGovernmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGovernmentID.Location = new System.Drawing.Point(6, 66);
            this.lblGovernmentID.Name = "lblGovernmentID";
            this.lblGovernmentID.Size = new System.Drawing.Size(96, 13);
            this.lblGovernmentID.TabIndex = 20;
            this.lblGovernmentID.Text = "Government ID:";
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.BackColor = System.Drawing.Color.Transparent;
            this.lblResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResume.Location = new System.Drawing.Point(6, 39);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(56, 13);
            this.lblResume.TabIndex = 18;
            this.lblResume.Text = "Resume:";
            // 
            // grpBoxActions
            // 
            this.grpBoxActions.BackColor = System.Drawing.Color.Transparent;
            this.grpBoxActions.Controls.Add(this.btnScheduleInterview);
            this.grpBoxActions.Controls.Add(this.btnUpdateStatus);
            this.grpBoxActions.Location = new System.Drawing.Point(631, 434);
            this.grpBoxActions.Name = "grpBoxActions";
            this.grpBoxActions.Size = new System.Drawing.Size(139, 95);
            this.grpBoxActions.TabIndex = 33;
            this.grpBoxActions.TabStop = false;
            this.grpBoxActions.Text = "Actions";
            // 
            // btnScheduleInterview
            // 
            this.btnScheduleInterview.Location = new System.Drawing.Point(11, 55);
            this.btnScheduleInterview.Name = "btnScheduleInterview";
            this.btnScheduleInterview.Size = new System.Drawing.Size(106, 19);
            this.btnScheduleInterview.TabIndex = 30;
            this.btnScheduleInterview.Text = "Schedule Interview";
            this.btnScheduleInterview.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Location = new System.Drawing.Point(12, 28);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(105, 19);
            this.btnUpdateStatus.TabIndex = 29;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // HRApplicants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.grpBoxActions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxApplicantDetails);
            this.Controls.Add(this.dgvApplicants);
            this.Controls.Add(this.cmbBoxFilterStatus);
            this.Controls.Add(this.lbFilterStatus);
            this.Controls.Add(this.btnSearchApplicant);
            this.Controls.Add(this.txtBoxSearchApplicant);
            this.Controls.Add(this.lblSearchApplicant);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRApplicants";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRApplicants";
            this.Load += new System.EventHandler(this.HRApplicants_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.grpBoxApplicantDetails.ResumeLayout(false);
            this.grpBoxApplicantDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBoxActions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHiringDecision;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.Button btnJobVacanciesManagement;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private System.Windows.Forms.Label lblSearchApplicant;
        private System.Windows.Forms.TextBox txtBoxSearchApplicant;
        private System.Windows.Forms.Button btnSearchApplicant;
        private System.Windows.Forms.Label lbFilterStatus;
        private System.Windows.Forms.ComboBox cmbBoxFilterStatus;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.GroupBox grpBoxApplicantDetails;
        private System.Windows.Forms.ComboBox cmbCurrentStatus;
        private System.Windows.Forms.Label lblCurrentStatus;
        private System.Windows.Forms.Label lblApplicationDate1;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Label lblPositionApplied1;
        private System.Windows.Forms.Label lblPositionApplied;
        private System.Windows.Forms.Label lblContactNumber1;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblEmail1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblApplicantID1;
        private System.Windows.Forms.Label lblApplicantID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnResumeView;
        private System.Windows.Forms.Label lblCertificates;
        private System.Windows.Forms.Label lblTranscript;
        private System.Windows.Forms.Label lblGovernmentID;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Button btnCertificatesView;
        private System.Windows.Forms.Button btnTranscriptView;
        private System.Windows.Forms.Button btnGovernmentIDView;
        private System.Windows.Forms.GroupBox grpBoxActions;
        private System.Windows.Forms.Button btnScheduleInterview;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnViewFullProfile;
    }
}
