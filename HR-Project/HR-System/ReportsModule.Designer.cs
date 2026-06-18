namespace HR_Project.HR_System
{
    partial class ReportsModule
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpReportTypes = new System.Windows.Forms.GroupBox();
            this.pnlRadioGroup = new System.Windows.Forms.Panel();
            this.rbMissingDocs = new System.Windows.Forms.RadioButton();
            this.rbOutcome = new System.Windows.Forms.RadioButton();
            this.rbInterviews = new System.Windows.Forms.RadioButton();
            this.rbPending = new System.Windows.Forms.RadioButton();
            this.rbAllApplicants = new System.Windows.Forms.RadioButton();
            this.grpFilters = new System.Windows.Forms.GroupBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpDataTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.dgvReportView = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCandidateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosApplied = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReportStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.grpReportTypes.SuspendLayout();
            this.pnlRadioGroup.SuspendLayout();
            this.grpFilters.SuspendLayout();
            this.grpOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).BeginInit();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyDocumentsNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReportTypes
            // 
            this.grpReportTypes.BackColor = System.Drawing.Color.White;
            this.grpReportTypes.Controls.Add(this.pnlRadioGroup);
            this.grpReportTypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpReportTypes.Location = new System.Drawing.Point(44, 114);
            this.grpReportTypes.Name = "grpReportTypes";
            this.grpReportTypes.Size = new System.Drawing.Size(285, 203);
            this.grpReportTypes.TabIndex = 0;
            this.grpReportTypes.TabStop = false;
            this.grpReportTypes.Text = "📑 Select HR Report Type";
            // 
            // pnlRadioGroup
            // 
            this.pnlRadioGroup.Controls.Add(this.rbMissingDocs);
            this.pnlRadioGroup.Controls.Add(this.rbOutcome);
            this.pnlRadioGroup.Controls.Add(this.rbInterviews);
            this.pnlRadioGroup.Controls.Add(this.rbPending);
            this.pnlRadioGroup.Controls.Add(this.rbAllApplicants);
            this.pnlRadioGroup.Location = new System.Drawing.Point(4, 25);
            this.pnlRadioGroup.Name = "pnlRadioGroup";
            this.pnlRadioGroup.Size = new System.Drawing.Size(277, 174);
            this.pnlRadioGroup.TabIndex = 0;
            // 
            // rbMissingDocs
            // 
            this.rbMissingDocs.AutoSize = true;
            this.rbMissingDocs.Location = new System.Drawing.Point(16, 137);
            this.rbMissingDocs.Name = "rbMissingDocs";
            this.rbMissingDocs.Size = new System.Drawing.Size(148, 19);
            this.rbMissingDocs.TabIndex = 4;
            this.rbMissingDocs.TabStop = true;
            this.rbMissingDocs.Text = "Missing Requirements";
            this.rbMissingDocs.UseVisualStyleBackColor = true;
            // 
            // rbOutcome
            // 
            this.rbOutcome.AutoSize = true;
            this.rbOutcome.Location = new System.Drawing.Point(16, 109);
            this.rbOutcome.Name = "rbOutcome";
            this.rbOutcome.Size = new System.Drawing.Size(139, 19);
            this.rbOutcome.TabIndex = 3;
            this.rbOutcome.TabStop = true;
            this.rbOutcome.Text = "Accepted / Rejected";
            this.rbOutcome.UseVisualStyleBackColor = true;
            // 
            // rbInterviews
            // 
            this.rbInterviews.AutoSize = true;
            this.rbInterviews.Location = new System.Drawing.Point(16, 75);
            this.rbInterviews.Name = "rbInterviews";
            this.rbInterviews.Size = new System.Drawing.Size(139, 19);
            this.rbInterviews.TabIndex = 2;
            this.rbInterviews.TabStop = true;
            this.rbInterviews.Text = "Interview Schedules";
            this.rbInterviews.UseVisualStyleBackColor = true;
            this.rbInterviews.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbPending
            // 
            this.rbPending.AutoSize = true;
            this.rbPending.Location = new System.Drawing.Point(16, 47);
            this.rbPending.Name = "rbPending";
            this.rbPending.Size = new System.Drawing.Size(140, 19);
            this.rbPending.TabIndex = 1;
            this.rbPending.TabStop = true;
            this.rbPending.Text = "Pending Applications";
            this.rbPending.UseVisualStyleBackColor = true;
            // 
            // rbAllApplicants
            // 
            this.rbAllApplicants.AutoSize = true;
            this.rbAllApplicants.Location = new System.Drawing.Point(16, 16);
            this.rbAllApplicants.Name = "rbAllApplicants";
            this.rbAllApplicants.Size = new System.Drawing.Size(109, 19);
            this.rbAllApplicants.TabIndex = 0;
            this.rbAllApplicants.TabStop = true;
            this.rbAllApplicants.Text = "All Applications";
            this.rbAllApplicants.UseVisualStyleBackColor = true;
            // 
            // grpFilters
            // 
            this.grpFilters.BackColor = System.Drawing.Color.White;
            this.grpFilters.Controls.Add(this.btnGenerate);
            this.grpFilters.Controls.Add(this.dtpDataTo);
            this.grpFilters.Controls.Add(this.dtpDataFrom);
            this.grpFilters.Controls.Add(this.lblDateTo);
            this.grpFilters.Controls.Add(this.lblDateFrom);
            this.grpFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFilters.Location = new System.Drawing.Point(44, 325);
            this.grpFilters.Name = "grpFilters";
            this.grpFilters.Size = new System.Drawing.Size(285, 155);
            this.grpFilters.TabIndex = 1;
            this.grpFilters.TabStop = false;
            this.grpFilters.Text = "🔍 Report Filters";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(10, 118);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(260, 30);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "▶ Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // dtpDataTo
            // 
            this.dtpDataTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataTo.Location = new System.Drawing.Point(10, 96);
            this.dtpDataTo.Name = "dtpDataTo";
            this.dtpDataTo.Size = new System.Drawing.Size(260, 23);
            this.dtpDataTo.TabIndex = 3;
            // 
            // dtpDataFrom
            // 
            this.dtpDataFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFrom.Location = new System.Drawing.Point(10, 48);
            this.dtpDataFrom.Name = "dtpDataFrom";
            this.dtpDataFrom.Size = new System.Drawing.Size(260, 23);
            this.dtpDataFrom.TabIndex = 1;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(10, 78);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(53, 15);
            this.lblDateTo.TabIndex = 2;
            this.lblDateTo.Text = "Date To:";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(10, 30);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(69, 15);
            this.lblDateFrom.TabIndex = 0;
            this.lblDateFrom.Text = "Date From:";
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.White;
            this.grpOutput.Controls.Add(this.dgvReportView);
            this.grpOutput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.Location = new System.Drawing.Point(345, 114);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(505, 366);
            this.grpOutput.TabIndex = 2;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "📋 Live Generated Report Output Viewer";
            // 
            // dgvReportView
            // 
            this.dgvReportView.AllowUserToAddRows = false;
            this.dgvReportView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colCandidateName,
            this.colPosApplied,
            this.colDataTarget,
            this.colReportStatus});
            this.dgvReportView.Location = new System.Drawing.Point(6, 22);
            this.dgvReportView.Name = "dgvReportView";
            this.dgvReportView.ReadOnly = true;
            this.dgvReportView.RowHeadersVisible = false;
            this.dgvReportView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReportView.Size = new System.Drawing.Size(493, 295);
            this.dgvReportView.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colCandidateName
            // 
            this.colCandidateName.HeaderText = "Candidate Name";
            this.colCandidateName.Name = "colCandidateName";
            this.colCandidateName.ReadOnly = true;
            // 
            // colPosApplied
            // 
            this.colPosApplied.HeaderText = "Position Applied";
            this.colPosApplied.Name = "colPosApplied";
            this.colPosApplied.ReadOnly = true;
            // 
            // colDataTarget
            // 
            this.colDataTarget.HeaderText = "Data";
            this.colDataTarget.Name = "colDataTarget";
            this.colDataTarget.ReadOnly = true;
            // 
            // colReportStatus
            // 
            this.colReportStatus.HeaderText = "Status";
            this.colReportStatus.Name = "colReportStatus";
            this.colReportStatus.ReadOnly = true;
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
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(870, 57);
            this.panelMyDocumentsHeader.TabIndex = 3;
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.Red;
            this.btnProfilePageClose.Location = new System.Drawing.Point(833, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(36, 29);
            this.btnProfilePageClose.TabIndex = 4;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
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
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(3, 18);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(79, 20);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "Reports";
            // 
            // panelMyDocumentsNavigation
            // 
            this.panelMyDocumentsNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelMyDocumentsNavigation.Controls.Add(this.btnReports);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnHiringDecision);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnInterviews);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnScreening);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnApplicants);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnJobVacanciesManagement);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyDocumentsNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelMyDocumentsNavigation.Name = "panelMyDocumentsNavigation";
            this.panelMyDocumentsNavigation.Size = new System.Drawing.Size(870, 42);
            this.panelMyDocumentsNavigation.TabIndex = 4;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(731, 9);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(96, 23);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnHiringDecision
            // 
            this.btnHiringDecision.BackColor = System.Drawing.Color.Transparent;
            this.btnHiringDecision.FlatAppearance.BorderSize = 0;
            this.btnHiringDecision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnInterviews.FlatAppearance.BorderSize = 0;
            this.btnInterviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnScreening.FlatAppearance.BorderSize = 0;
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnApplicants.FlatAppearance.BorderSize = 0;
            this.btnApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicants.ForeColor = System.Drawing.Color.White;
            this.btnApplicants.Location = new System.Drawing.Point(271, 9);
            this.btnApplicants.Name = "btnApplicants";
            this.btnApplicants.Size = new System.Drawing.Size(89, 23);
            this.btnApplicants.TabIndex = 2;
            this.btnApplicants.Text = "Applicants";
            this.btnApplicants.UseVisualStyleBackColor = false;
            // 
            // btnJobVacanciesManagement
            // 
            this.btnJobVacanciesManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnJobVacanciesManagement.FlatAppearance.BorderSize = 0;
            this.btnJobVacanciesManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.btnMyDocumentsDashboard.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(85, 23);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click);
            // 
            // ReportsModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 512);
            this.Controls.Add(this.panelMyDocumentsNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpFilters);
            this.Controls.Add(this.grpReportTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.grpReportTypes.ResumeLayout(false);
            this.pnlRadioGroup.ResumeLayout(false);
            this.pnlRadioGroup.PerformLayout();
            this.grpFilters.ResumeLayout(false);
            this.grpFilters.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportView)).EndInit();
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyDocumentsNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpReportTypes;
        private System.Windows.Forms.Panel pnlRadioGroup;
        private System.Windows.Forms.RadioButton rbOutcome;
        private System.Windows.Forms.RadioButton rbInterviews;
        private System.Windows.Forms.RadioButton rbPending;
        private System.Windows.Forms.RadioButton rbAllApplicants;
        private System.Windows.Forms.RadioButton rbMissingDocs;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtpDataTo;
        private System.Windows.Forms.DateTimePicker dtpDataFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.DataGridView dgvReportView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCandidateName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosApplied;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataTarget;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReportStatus;
        private System.Windows.Forms.Panel panelMyDocumentsHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblMyDocumentsTitle;
        private System.Windows.Forms.Panel panelMyDocumentsNavigation;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHiringDecision;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.Button btnJobVacanciesManagement;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
    }
}
