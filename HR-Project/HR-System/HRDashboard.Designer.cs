namespace HR_Project.HR_System
{
    partial class HRDashboard
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
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.lblMyDocumentsTitle = new System.Windows.Forms.Label();
            this.panelMyDocumentsNavigation = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHiringDecision = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnScreening = new System.Windows.Forms.Button();
            this.btnApplicants = new System.Windows.Forms.Button();
            this.btnJobVacanciesManagement = new System.Windows.Forms.Button();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.panelApplicants = new System.Windows.Forms.Panel();
            this.lblApplicantCount = new System.Windows.Forms.Label();
            this.lblApplicants = new System.Windows.Forms.Label();
            this.panelJobs = new System.Windows.Forms.Panel();
            this.lblOpenJobsCount = new System.Windows.Forms.Label();
            this.lblJobs = new System.Windows.Forms.Label();
            this.panelInterviews = new System.Windows.Forms.Panel();
            this.lblInterviewsCount = new System.Windows.Forms.Label();
            this.lblInterviews = new System.Windows.Forms.Label();
            this.panelAccepted = new System.Windows.Forms.Panel();
            this.lblAcceptedCount = new System.Windows.Forms.Label();
            this.lblAccepted = new System.Windows.Forms.Label();
            this.lblWelcomeHR = new System.Windows.Forms.Label();
            this.dgvPendingReviews = new System.Windows.Forms.DataGridView();
            this.ApplicantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUpcomingInterviews = new System.Windows.Forms.DataGridView();
            this.Applicant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterviewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InterviewTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecentUpdates = new System.Windows.Forms.DataGridView();
            this.Applicant1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateUpdated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyDocumentsNavigation.SuspendLayout();
            this.panelApplicants.SuspendLayout();
            this.panelJobs.SuspendLayout();
            this.panelInterviews.SuspendLayout();
            this.panelAccepted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingInterviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentUpdates)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMyDocumentsHeader
            // 
            this.panelMyDocumentsHeader.BackColor = System.Drawing.Color.FromArgb(22, 22, 34);
            this.panelMyDocumentsHeader.Controls.Add(this.btnProfilePageClose);
            this.panelMyDocumentsHeader.Controls.Add(this.btnMyDocumentsLogout);
            this.panelMyDocumentsHeader.Controls.Add(this.lblMyDocumentsTitle);
            this.panelMyDocumentsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMyDocumentsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelMyDocumentsHeader.Name = "panelMyDocumentsHeader";
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(869, 60);
            this.panelMyDocumentsHeader.TabIndex = 13;
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
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(752, 28);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsLogout.TabIndex = 3;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = false;
            this.btnMyDocumentsLogout.Click += new System.EventHandler(this.btnMyDocumentsLogout_Click);
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(3, 23);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(137, 20);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "HR Dashboard";
            // 
            // panelMyDocumentsNavigation
            // 
            this.panelMyDocumentsNavigation.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnReports);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnHiringDecision);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnInterviews);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnScreening);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnApplicants);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnJobVacanciesManagement);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyDocumentsNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelMyDocumentsNavigation.Name = "panelMyDocumentsNavigation";
            this.panelMyDocumentsNavigation.Size = new System.Drawing.Size(869, 42);
            this.panelMyDocumentsNavigation.TabIndex = 14;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(731, 9);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(96, 23);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnHiringDecision
            // 
            this.btnHiringDecision.BackColor = System.Drawing.Color.Transparent;
            this.btnHiringDecision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnHiringDecision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnHiringDecision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiringDecision.FlatAppearance.BorderSize = 0;
            this.btnHiringDecision.ForeColor = System.Drawing.Color.White;
            this.btnHiringDecision.Location = new System.Drawing.Point(609, 9);
            this.btnHiringDecision.Name = "btnHiringDecision";
            this.btnHiringDecision.Size = new System.Drawing.Size(96, 23);
            this.btnHiringDecision.TabIndex = 3;
            this.btnHiringDecision.Text = "Hiring Decision";
            this.btnHiringDecision.UseVisualStyleBackColor = false;
            this.btnHiringDecision.Click += new System.EventHandler(this.btnHiringDecision_Click);
            // 
            // btnInterviews
            // 
            this.btnInterviews.BackColor = System.Drawing.Color.Transparent;
            this.btnInterviews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnInterviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnInterviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterviews.FlatAppearance.BorderSize = 0;
            this.btnInterviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterviews.ForeColor = System.Drawing.Color.White;
            this.btnInterviews.Location = new System.Drawing.Point(505, 9);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Size = new System.Drawing.Size(75, 23);
            this.btnInterviews.TabIndex = 2;
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.UseVisualStyleBackColor = false;
            this.btnInterviews.Click += new System.EventHandler(this.btnInterviews_Click);
            // 
            // btnScreening
            // 
            this.btnScreening.BackColor = System.Drawing.Color.Transparent;
            this.btnScreening.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnScreening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreening.FlatAppearance.BorderSize = 0;
            this.btnScreening.ForeColor = System.Drawing.Color.White;
            this.btnScreening.Location = new System.Drawing.Point(387, 9);
            this.btnScreening.Name = "btnScreening";
            this.btnScreening.Size = new System.Drawing.Size(89, 23);
            this.btnScreening.TabIndex = 2;
            this.btnScreening.Text = "Screening";
            this.btnScreening.UseVisualStyleBackColor = false;
            this.btnScreening.Click += new System.EventHandler(this.btnScreening_Click);
            // 
            // btnApplicants
            // 
            this.btnApplicants.BackColor = System.Drawing.Color.Transparent;
            this.btnApplicants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnApplicants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicants.FlatAppearance.BorderSize = 0;
            this.btnApplicants.ForeColor = System.Drawing.Color.White;
            this.btnApplicants.Location = new System.Drawing.Point(271, 9);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(89, 23);
            this.btnApplicants.TabIndex = 2;
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.UseVisualStyleBackColor = false;
            this.btnApplicants.Click += new System.EventHandler(this.btnApplicants_Click);
            // 
            // btnJobVacanciesManagement
            // 
            this.btnJobVacanciesManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnJobVacanciesManagement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnJobVacanciesManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnJobVacanciesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobVacanciesManagement.FlatAppearance.BorderSize = 0;
            this.btnJobVacanciesManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobVacanciesManagement.ForeColor = System.Drawing.Color.White;
            this.btnJobVacanciesManagement.Location = new System.Drawing.Point(157, 9);
            this.btnJobVacanciesManagement.Name = "btnJobVacanciesManagement";
            this.btnJobVacanciesManagement.Size = new System.Drawing.Size(86, 23);
            this.btnJobVacanciesManagement.TabIndex = 1;
            this.btnJobVacanciesManagement.Text = "Job Vacancies";
            this.btnJobVacanciesManagement.UseVisualStyleBackColor = false;
            this.btnJobVacanciesManagement.Click += new System.EventHandler(this.btnJobVacanciesManagement_Click);
            // 
            // btnMyDocumentsDashboard
            // 
            this.btnMyDocumentsDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnMyDocumentsDashboard.Enabled = false;
            this.btnMyDocumentsDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnMyDocumentsDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDashboard.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(85, 23);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click);
            // 
            // panelApplicants
            // 
            this.panelApplicants.Controls.Add(this.lblApplicantCount);
            this.panelApplicants.Controls.Add(this.lblApplicants);
            this.panelApplicants.Location = new System.Drawing.Point(12, 151);
            this.panelApplicants.Name = "panelApplicants";
            this.panelApplicants.Size = new System.Drawing.Size(141, 100);
            this.panelApplicants.TabIndex = 15;
            // 
            // lblApplicantCount
            // 
            this.lblApplicantCount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblApplicantCount.AutoSize = true;
            this.lblApplicantCount.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantCount.ForeColor = System.Drawing.Color.Black;
            this.lblApplicantCount.Location = new System.Drawing.Point(37, 44);
            this.lblApplicantCount.Name = "lblApplicantCount";
            this.lblApplicantCount.Size = new System.Drawing.Size(87, 13);
            this.lblApplicantCount.TabIndex = 1;
            this.lblApplicantCount.Text = "Applicants Count";
            // 
            // lblApplicants
            // 
            this.lblApplicants.AutoSize = true;
            this.lblApplicants.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicants.ForeColor = System.Drawing.Color.Black;
            this.lblApplicants.Location = new System.Drawing.Point(38, 0);
            this.lblApplicants.Name = "lblApplicants";
            this.lblApplicants.Size = new System.Drawing.Size(66, 13);
            this.lblApplicants.TabIndex = 0;
            this.lblApplicants.Text = "Applicants";
            // 
            // panelJobs
            // 
            this.panelJobs.Controls.Add(this.lblOpenJobsCount);
            this.panelJobs.Controls.Add(this.lblJobs);
            this.panelJobs.Location = new System.Drawing.Point(230, 151);
            this.panelJobs.Name = "panelJobs";
            this.panelJobs.Size = new System.Drawing.Size(141, 100);
            this.panelJobs.TabIndex = 16;
            // 
            // lblOpenJobsCount
            // 
            this.lblOpenJobsCount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblOpenJobsCount.AutoSize = true;
            this.lblOpenJobsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenJobsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenJobsCount.ForeColor = System.Drawing.Color.Black;
            this.lblOpenJobsCount.Location = new System.Drawing.Point(27, 44);
            this.lblOpenJobsCount.Name = "lblOpenJobsCount";
            this.lblOpenJobsCount.Size = new System.Drawing.Size(60, 13);
            this.lblOpenJobsCount.TabIndex = 2;
            this.lblOpenJobsCount.Text = "Jobs Count";
            // 
            // lblJobs
            // 
            this.lblJobs.AutoSize = true;
            this.lblJobs.BackColor = System.Drawing.Color.Transparent;
            this.lblJobs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobs.ForeColor = System.Drawing.Color.Black;
            this.lblJobs.Location = new System.Drawing.Point(38, 0);
            this.lblJobs.Name = "lblJobs";
            this.lblJobs.Size = new System.Drawing.Size(67, 13);
            this.lblJobs.TabIndex = 1;
            this.lblJobs.Text = "Open Jobs";
            // 
            // panelInterviews
            // 
            this.panelInterviews.Controls.Add(this.lblInterviewsCount);
            this.panelInterviews.Controls.Add(this.lblInterviews);
            this.panelInterviews.Location = new System.Drawing.Point(468, 151);
            this.panelInterviews.Name = "panelInterviews";
            this.panelInterviews.Size = new System.Drawing.Size(141, 100);
            this.panelInterviews.TabIndex = 16;
            // 
            // lblInterviewsCount
            // 
            this.lblInterviewsCount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblInterviewsCount.AutoSize = true;
            this.lblInterviewsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviewsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviewsCount.ForeColor = System.Drawing.Color.Black;
            this.lblInterviewsCount.Location = new System.Drawing.Point(26, 44);
            this.lblInterviewsCount.Name = "lblInterviewsCount";
            this.lblInterviewsCount.Size = new System.Drawing.Size(86, 13);
            this.lblInterviewsCount.TabIndex = 3;
            this.lblInterviewsCount.Text = "Interviews Count";
            // 
            // lblInterviews
            // 
            this.lblInterviews.AutoSize = true;
            this.lblInterviews.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterviews.ForeColor = System.Drawing.Color.Black;
            this.lblInterviews.Location = new System.Drawing.Point(34, 0);
            this.lblInterviews.Name = "lblInterviews";
            this.lblInterviews.Size = new System.Drawing.Size(65, 13);
            this.lblInterviews.TabIndex = 2;
            this.lblInterviews.Text = "Interviews";
            // 
            // panelAccepted
            // 
            this.panelAccepted.Controls.Add(this.lblAcceptedCount);
            this.panelAccepted.Controls.Add(this.lblAccepted);
            this.panelAccepted.Location = new System.Drawing.Point(716, 151);
            this.panelAccepted.Name = "panelAccepted";
            this.panelAccepted.Size = new System.Drawing.Size(141, 100);
            this.panelAccepted.TabIndex = 16;
            // 
            // lblAcceptedCount
            // 
            this.lblAcceptedCount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.lblAcceptedCount.AutoSize = true;
            this.lblAcceptedCount.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptedCount.ForeColor = System.Drawing.Color.Black;
            this.lblAcceptedCount.Location = new System.Drawing.Point(27, 44);
            this.lblAcceptedCount.Name = "lblAcceptedCount";
            this.lblAcceptedCount.Size = new System.Drawing.Size(84, 13);
            this.lblAcceptedCount.TabIndex = 4;
            this.lblAcceptedCount.Text = "Accepted Count";
            // 
            // lblAccepted
            // 
            this.lblAccepted.AutoSize = true;
            this.lblAccepted.BackColor = System.Drawing.Color.Transparent;
            this.lblAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccepted.ForeColor = System.Drawing.Color.Black;
            this.lblAccepted.Location = new System.Drawing.Point(33, 0);
            this.lblAccepted.Name = "lblAccepted";
            this.lblAccepted.Size = new System.Drawing.Size(61, 13);
            this.lblAccepted.TabIndex = 3;
            this.lblAccepted.Text = "Accepted";
            // 
            // lblWelcomeHR
            // 
            this.lblWelcomeHR.AutoSize = true;
            this.lblWelcomeHR.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcomeHR.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeHR.Location = new System.Drawing.Point(27, 114);
            this.lblWelcomeHR.Name = "lblWelcomeHR";
            this.lblWelcomeHR.Size = new System.Drawing.Size(161, 20);
            this.lblWelcomeHR.TabIndex = 17;
            this.lblWelcomeHR.Text = "Welcome Admin!";
            // 
            // dgvPendingReviews
            // 
            this.dgvPendingReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApplicantName,
            this.Position,
            this.Status});
            this.dgvPendingReviews.Location = new System.Drawing.Point(12, 279);
            this.dgvPendingReviews.Name = "dgvPendingReviews";
            this.dgvPendingReviews.Size = new System.Drawing.Size(337, 150);
            this.dgvPendingReviews.TabIndex = 18;
            // 
            // ApplicantName
            // 
            this.ApplicantName.HeaderText = "Applicant Name";
            this.ApplicantName.Name = "ApplicantName";
            // 
            // Position
            // 
            this.Position.HeaderText = "Position";
            this.Position.Name = "Position";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // dgvUpcomingInterviews
            // 
            this.dgvUpcomingInterviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpcomingInterviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Applicant,
            this.Position1,
            this.InterviewDate,
            this.InterviewTime});
            this.dgvUpcomingInterviews.Location = new System.Drawing.Point(520, 279);
            this.dgvUpcomingInterviews.Name = "dgvUpcomingInterviews";
            this.dgvUpcomingInterviews.Size = new System.Drawing.Size(337, 150);
            this.dgvUpcomingInterviews.TabIndex = 19;
            // 
            // Applicant
            // 
            this.Applicant.HeaderText = "Applicant";
            this.Applicant.Name = "Applicant";
            // 
            // Position1
            // 
            this.Position1.HeaderText = "Position";
            this.Position1.Name = "Position1";
            // 
            // InterviewDate
            // 
            this.InterviewDate.HeaderText = "Interview Date";
            this.InterviewDate.Name = "InterviewDate";
            // 
            // InterviewTime
            // 
            this.InterviewTime.HeaderText = "InterviewTime";
            this.InterviewTime.Name = "InterviewTime";
            // 
            // dgvRecentUpdates
            // 
            this.dgvRecentUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Applicant1,
            this.Position2,
            this.CurrentStatus,
            this.DateUpdated});
            this.dgvRecentUpdates.Location = new System.Drawing.Point(271, 435);
            this.dgvRecentUpdates.Name = "dgvRecentUpdates";
            this.dgvRecentUpdates.Size = new System.Drawing.Size(337, 150);
            this.dgvRecentUpdates.TabIndex = 20;
            // 
            // Applicant1
            // 
            this.Applicant1.HeaderText = "Applicant";
            this.Applicant1.Name = "Applicant1";
            // 
            // Position2
            // 
            this.Position2.HeaderText = "Position";
            this.Position2.Name = "Position2";
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.HeaderText = "Current Status";
            this.CurrentStatus.Name = "CurrentStatus";
            // 
            // DateUpdated
            // 
            this.DateUpdated.HeaderText = "DateUpdated";
            this.DateUpdated.Name = "DateUpdated";
            // 
            // HRDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 600);
            this.Controls.Add(this.dgvRecentUpdates);
            this.Controls.Add(this.dgvUpcomingInterviews);
            this.Controls.Add(this.dgvPendingReviews);
            this.Controls.Add(this.lblWelcomeHR);
            this.Controls.Add(this.panelAccepted);
            this.Controls.Add(this.panelInterviews);
            this.Controls.Add(this.panelJobs);
            this.Controls.Add(this.panelApplicants);
            this.Controls.Add(this.panelMyDocumentsNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HRDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.HRDashboard_Load);
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyDocumentsNavigation.ResumeLayout(false);
            this.panelApplicants.ResumeLayout(false);
            this.panelApplicants.PerformLayout();
            this.panelJobs.ResumeLayout(false);
            this.panelJobs.PerformLayout();
            this.panelInterviews.ResumeLayout(false);
            this.panelInterviews.PerformLayout();
            this.panelAccepted.ResumeLayout(false);
            this.panelAccepted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpcomingInterviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentUpdates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMyDocumentsHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblMyDocumentsTitle;
        private System.Windows.Forms.Panel panelMyDocumentsNavigation;
        private System.Windows.Forms.Button btnHiringDecision;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.Button btnJobVacanciesManagement;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panelApplicants;
        private System.Windows.Forms.Panel panelJobs;
        private System.Windows.Forms.Panel panelInterviews;
        private System.Windows.Forms.Panel panelAccepted;
        private System.Windows.Forms.Label lblApplicantCount;
        private System.Windows.Forms.Label lblApplicants;
        private System.Windows.Forms.Label lblOpenJobsCount;
        private System.Windows.Forms.Label lblJobs;
        private System.Windows.Forms.Label lblInterviewsCount;
        private System.Windows.Forms.Label lblInterviews;
        private System.Windows.Forms.Label lblAcceptedCount;
        private System.Windows.Forms.Label lblAccepted;
        private System.Windows.Forms.Label lblWelcomeHR;
        private System.Windows.Forms.DataGridView dgvPendingReviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApplicantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridView dgvUpcomingInterviews;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applicant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position1;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterviewDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn InterviewTime;
        private System.Windows.Forms.DataGridView dgvRecentUpdates;
        private System.Windows.Forms.DataGridViewTextBoxColumn Applicant1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateUpdated;
    }
}
