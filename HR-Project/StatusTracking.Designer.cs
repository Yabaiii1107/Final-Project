namespace HR_Project
{
    partial class StatusTracking
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
            this.lblStatusTracking = new System.Windows.Forms.Label();
            this.panelProfilePageNavigation = new System.Windows.Forms.Panel();
            this.btnProfilePageStatusTracking = new System.Windows.Forms.Button();
            this.btnProfilePageDocuments = new System.Windows.Forms.Button();
            this.btnProfilePageMyApplication = new System.Windows.Forms.Button();
            this.btnProfilePageJobVacancies = new System.Windows.Forms.Button();
            this.btnProfilePageMyProfile = new System.Windows.Forms.Button();
            this.btnProfilePageDashboard = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblApplicantID = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCurrentStatusTitle = new System.Windows.Forms.Label();
            this.lblSubmitted = new System.Windows.Forms.Label();
            this.lblHrScreening = new System.Windows.Forms.Label();
            this.lblInitialInterview = new System.Windows.Forms.Label();
            this.lblFinalInterview = new System.Windows.Forms.Label();
            this.lblJobOffer = new System.Windows.Forms.Label();
            this.lblHired = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.grbApplicationProgress = new System.Windows.Forms.GroupBox();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.dgvStatusHistory = new System.Windows.Forms.DataGridView();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.panelProfilePageHeader.SuspendLayout();
            this.panelProfilePageNavigation.SuspendLayout();
            this.grbApplicationProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelProfilePageHeader
            // 
            this.panelProfilePageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.panelProfilePageHeader.Controls.Add(this.btnProfilePageClose);
            this.panelProfilePageHeader.Controls.Add(this.btnProfilePageLogout);
            this.panelProfilePageHeader.Controls.Add(this.lblStatusTracking);
            this.panelProfilePageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProfilePageHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProfilePageHeader.Name = "panelProfilePageHeader";
            this.panelProfilePageHeader.Size = new System.Drawing.Size(1016, 60);
            this.panelProfilePageHeader.TabIndex = 10;
            // 
            // btnProfilePageClose
            // 
            this.btnProfilePageClose.BackColor = System.Drawing.Color.Transparent;
            this.btnProfilePageClose.FlatAppearance.BorderSize = 0;
            this.btnProfilePageClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfilePageClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageClose.ForeColor = System.Drawing.Color.Red;
            this.btnProfilePageClose.Location = new System.Drawing.Point(972, 0);
            this.btnProfilePageClose.Name = "btnProfilePageClose";
            this.btnProfilePageClose.Size = new System.Drawing.Size(42, 29);
            this.btnProfilePageClose.TabIndex = 4;
            this.btnProfilePageClose.Text = "X";
            this.btnProfilePageClose.UseVisualStyleBackColor = false;
            // 
            // btnProfilePageLogout
            // 
            this.btnProfilePageLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageLogout.Location = new System.Drawing.Point(877, 28);
            this.btnProfilePageLogout.Name = "btnProfilePageLogout";
            this.btnProfilePageLogout.Size = new System.Drawing.Size(87, 23);
            this.btnProfilePageLogout.TabIndex = 3;
            this.btnProfilePageLogout.Text = "Logout";
            this.btnProfilePageLogout.UseVisualStyleBackColor = true;
            this.btnProfilePageLogout.Click += new System.EventHandler(this.btnProfilePageLogout_Click);
            // 
            // lblStatusTracking
            // 
            this.lblStatusTracking.AutoSize = true;
            this.lblStatusTracking.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTracking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblStatusTracking.Location = new System.Drawing.Point(3, 23);
            this.lblStatusTracking.Name = "lblStatusTracking";
            this.lblStatusTracking.Size = new System.Drawing.Size(151, 20);
            this.lblStatusTracking.TabIndex = 0;
            this.lblStatusTracking.Text = "Status Tracking";
            // 
            // panelProfilePageNavigation
            // 
            this.panelProfilePageNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panelProfilePageNavigation.Controls.Add(this.btnProfilePageStatusTracking);
            this.panelProfilePageNavigation.Controls.Add(this.btnProfilePageDocuments);
            this.panelProfilePageNavigation.Controls.Add(this.btnProfilePageMyApplication);
            this.panelProfilePageNavigation.Controls.Add(this.btnProfilePageJobVacancies);
            this.panelProfilePageNavigation.Controls.Add(this.btnProfilePageMyProfile);
            this.panelProfilePageNavigation.Controls.Add(this.btnProfilePageDashboard);
            this.panelProfilePageNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelProfilePageNavigation.Name = "panelProfilePageNavigation";
            this.panelProfilePageNavigation.Size = new System.Drawing.Size(1016, 42);
            this.panelProfilePageNavigation.TabIndex = 11;
            // 
            // btnProfilePageStatusTracking
            // 
            this.btnProfilePageStatusTracking.BackColor = System.Drawing.Color.Blue;
            this.btnProfilePageStatusTracking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageStatusTracking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageStatusTracking.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfilePageStatusTracking.ForeColor = System.Drawing.Color.White;
            this.btnProfilePageStatusTracking.Location = new System.Drawing.Point(780, 9);
            this.btnProfilePageStatusTracking.Name = "btnProfilePageStatusTracking";
            this.btnProfilePageStatusTracking.Size = new System.Drawing.Size(112, 23);
            this.btnProfilePageStatusTracking.TabIndex = 3;
            this.btnProfilePageStatusTracking.Text = "Status Tracking";
            this.btnProfilePageStatusTracking.UseVisualStyleBackColor = false;
            // 
            // btnProfilePageDocuments
            // 
            this.btnProfilePageDocuments.BackColor = System.Drawing.Color.Blue;
            this.btnProfilePageDocuments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageDocuments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageDocuments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfilePageDocuments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageDocuments.ForeColor = System.Drawing.Color.White;
            this.btnProfilePageDocuments.Location = new System.Drawing.Point(629, 9);
            this.btnProfilePageDocuments.Name = "btnProfilePageDocuments";
            this.btnProfilePageDocuments.Size = new System.Drawing.Size(87, 23);
            this.btnProfilePageDocuments.TabIndex = 2;
            this.btnProfilePageDocuments.Text = "Documents";
            this.btnProfilePageDocuments.UseVisualStyleBackColor = false;
            // 
            // btnProfilePageMyApplication
            // 
            this.btnProfilePageMyApplication.BackColor = System.Drawing.Color.Blue;
            this.btnProfilePageMyApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageMyApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageMyApplication.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfilePageMyApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageMyApplication.ForeColor = System.Drawing.Color.White;
            this.btnProfilePageMyApplication.Location = new System.Drawing.Point(469, 9);
            this.btnProfilePageMyApplication.Name = "btnProfilePageMyApplication";
            this.btnProfilePageMyApplication.Size = new System.Drawing.Size(104, 23);
            this.btnProfilePageMyApplication.TabIndex = 2;
            this.btnProfilePageMyApplication.Text = "My Application";
            this.btnProfilePageMyApplication.UseVisualStyleBackColor = false;
            // 
            // btnProfilePageJobVacancies
            // 
            this.btnProfilePageJobVacancies.BackColor = System.Drawing.Color.Blue;
            this.btnProfilePageJobVacancies.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageJobVacancies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageJobVacancies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfilePageJobVacancies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageJobVacancies.ForeColor = System.Drawing.Color.White;
            this.btnProfilePageJobVacancies.Location = new System.Drawing.Point(309, 9);
            this.btnProfilePageJobVacancies.Name = "btnProfilePageJobVacancies";
            this.btnProfilePageJobVacancies.Size = new System.Drawing.Size(104, 23);
            this.btnProfilePageJobVacancies.TabIndex = 2;
            this.btnProfilePageJobVacancies.Text = "Job Vacancies";
            this.btnProfilePageJobVacancies.UseVisualStyleBackColor = false;
            // 
            // btnProfilePageMyProfile
            // 
            this.btnProfilePageMyProfile.BackColor = System.Drawing.Color.Blue;
            this.btnProfilePageMyProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageMyProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfilePageMyProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageMyProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfilePageMyProfile.Location = new System.Drawing.Point(174, 9);
            this.btnProfilePageMyProfile.Name = "btnProfilePageMyProfile";
            this.btnProfilePageMyProfile.Size = new System.Drawing.Size(87, 23);
            this.btnProfilePageMyProfile.TabIndex = 1;
            this.btnProfilePageMyProfile.Text = "My Profile";
            this.btnProfilePageMyProfile.UseVisualStyleBackColor = false;
            // 
            // btnProfilePageDashboard
            // 
            this.btnProfilePageDashboard.BackColor = System.Drawing.Color.Blue;
            this.btnProfilePageDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProfilePageDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProfilePageDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfilePageDashboard.ForeColor = System.Drawing.Color.White;
            this.btnProfilePageDashboard.Location = new System.Drawing.Point(36, 9);
            this.btnProfilePageDashboard.Name = "btnProfilePageDashboard";
            this.btnProfilePageDashboard.Size = new System.Drawing.Size(87, 23);
            this.btnProfilePageDashboard.TabIndex = 0;
            this.btnProfilePageDashboard.Text = "Dashboard";
            this.btnProfilePageDashboard.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitle.Location = new System.Drawing.Point(33, 115);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(245, 25);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Application Status Tracker";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantName.Location = new System.Drawing.Point(33, 160);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(104, 13);
            this.lblApplicantName.TabIndex = 13;
            this.lblApplicantName.Text = "Applicant Name :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(139, 160);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 13);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Applicant Name";
            // 
            // lblApplicantID
            // 
            this.lblApplicantID.AutoSize = true;
            this.lblApplicantID.BackColor = System.Drawing.Color.Transparent;
            this.lblApplicantID.Location = new System.Drawing.Point(33, 188);
            this.lblApplicantID.Name = "lblApplicantID";
            this.lblApplicantID.Size = new System.Drawing.Size(85, 13);
            this.lblApplicantID.TabIndex = 15;
            this.lblApplicantID.Text = "Applicant ID :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Location = new System.Drawing.Point(124, 188);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 13);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "Applicant ID";
            // 
            // lblCurrentStatusTitle
            // 
            this.lblCurrentStatusTitle.AutoSize = true;
            this.lblCurrentStatusTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStatusTitle.Location = new System.Drawing.Point(33, 221);
            this.lblCurrentStatusTitle.Name = "lblCurrentStatusTitle";
            this.lblCurrentStatusTitle.Size = new System.Drawing.Size(96, 13);
            this.lblCurrentStatusTitle.TabIndex = 17;
            this.lblCurrentStatusTitle.Text = "Current Status :";
            // 
            // lblSubmitted
            // 
            this.lblSubmitted.AutoSize = true;
            this.lblSubmitted.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmitted.Location = new System.Drawing.Point(6, 16);
            this.lblSubmitted.Name = "lblSubmitted";
            this.lblSubmitted.Size = new System.Drawing.Size(84, 13);
            this.lblSubmitted.TabIndex = 18;
            this.lblSubmitted.Text = " ✓ Submitted ";
            // 
            // lblHrScreening
            // 
            this.lblHrScreening.AutoSize = true;
            this.lblHrScreening.BackColor = System.Drawing.Color.Transparent;
            this.lblHrScreening.Location = new System.Drawing.Point(6, 44);
            this.lblHrScreening.Name = "lblHrScreening";
            this.lblHrScreening.Size = new System.Drawing.Size(107, 13);
            this.lblHrScreening.TabIndex = 19;
            this.lblHrScreening.Text = " ✓ HR Screening ";
            // 
            // lblInitialInterview
            // 
            this.lblInitialInterview.AutoSize = true;
            this.lblInitialInterview.BackColor = System.Drawing.Color.Transparent;
            this.lblInitialInterview.Location = new System.Drawing.Point(6, 68);
            this.lblInitialInterview.Name = "lblInitialInterview";
            this.lblInitialInterview.Size = new System.Drawing.Size(115, 13);
            this.lblInitialInterview.TabIndex = 20;
            this.lblInitialInterview.Text = " ✓ Initial Interview ";
            // 
            // lblFinalInterview
            // 
            this.lblFinalInterview.AutoSize = true;
            this.lblFinalInterview.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalInterview.Location = new System.Drawing.Point(6, 96);
            this.lblFinalInterview.Name = "lblFinalInterview";
            this.lblFinalInterview.Size = new System.Drawing.Size(104, 13);
            this.lblFinalInterview.TabIndex = 21;
            this.lblFinalInterview.Text = "Final Interview ⏳";
            // 
            // lblJobOffer
            // 
            this.lblJobOffer.AutoSize = true;
            this.lblJobOffer.BackColor = System.Drawing.Color.Transparent;
            this.lblJobOffer.Location = new System.Drawing.Point(6, 127);
            this.lblJobOffer.Name = "lblJobOffer";
            this.lblJobOffer.Size = new System.Drawing.Size(73, 13);
            this.lblJobOffer.TabIndex = 22;
            this.lblJobOffer.Text = "Job Offer ⏳";
            this.lblJobOffer.Click += new System.EventHandler(this.lblJobOffer_Click);
            // 
            // lblHired
            // 
            this.lblHired.AutoSize = true;
            this.lblHired.BackColor = System.Drawing.Color.Transparent;
            this.lblHired.Location = new System.Drawing.Point(6, 150);
            this.lblHired.Name = "lblHired";
            this.lblHired.Size = new System.Drawing.Size(51, 13);
            this.lblHired.TabIndex = 23;
            this.lblHired.Text = "Hired ⏳";
            this.lblHired.Click += new System.EventHandler(this.lblAccepted_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Location = new System.Drawing.Point(345, 172);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(64, 13);
            this.lblProgress.TabIndex = 25;
            this.lblProgress.Text = "Progress :";
            // 
            // grbApplicationProgress
            // 
            this.grbApplicationProgress.BackColor = System.Drawing.Color.Transparent;
            this.grbApplicationProgress.Controls.Add(this.lblSubmitted);
            this.grbApplicationProgress.Controls.Add(this.lblHrScreening);
            this.grbApplicationProgress.Controls.Add(this.lblInitialInterview);
            this.grbApplicationProgress.Controls.Add(this.lblHired);
            this.grbApplicationProgress.Controls.Add(this.lblFinalInterview);
            this.grbApplicationProgress.Controls.Add(this.lblJobOffer);
            this.grbApplicationProgress.Location = new System.Drawing.Point(339, 188);
            this.grbApplicationProgress.Name = "grbApplicationProgress";
            this.grbApplicationProgress.Size = new System.Drawing.Size(166, 180);
            this.grbApplicationProgress.TabIndex = 26;
            this.grbApplicationProgress.TabStop = false;
            this.grbApplicationProgress.Text = "Application Progress";
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(613, 328);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(125, 28);
            this.progressBarStatus.TabIndex = 27;
            this.progressBarStatus.Click += new System.EventHandler(this.progressBarStatus_Click);
            // 
            // dgvStatusHistory
            // 
            this.dgvStatusHistory.AllowUserToAddRows = false;
            this.dgvStatusHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStatusHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatusHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColDate,
            this.ColStatus,
            this.ColRemarks});
            this.dgvStatusHistory.Location = new System.Drawing.Point(526, 172);
            this.dgvStatusHistory.Name = "dgvStatusHistory";
            this.dgvStatusHistory.ReadOnly = true;
            this.dgvStatusHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatusHistory.Size = new System.Drawing.Size(302, 150);
            this.dgvStatusHistory.TabIndex = 28;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // ColRemarks
            // 
            this.ColRemarks.HeaderText = "Remarks";
            this.ColRemarks.Name = "ColRemarks";
            this.ColRemarks.ReadOnly = true;
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentStatus.Location = new System.Drawing.Point(35, 243);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(89, 15);
            this.lblCurrentStatus.TabIndex = 29;
            this.lblCurrentStatus.Text = "Under Review";
            // 
            // StatusTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.lblCurrentStatus);
            this.Controls.Add(this.dgvStatusHistory);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this.grbApplicationProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblCurrentStatusTitle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblApplicantID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblApplicantName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelProfilePageNavigation);
            this.Controls.Add(this.panelProfilePageHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusTracking";
            this.Text = "StatusTracking";
            this.Load += new System.EventHandler(this.StatusTracking_Load);
            this.panelProfilePageHeader.ResumeLayout(false);
            this.panelProfilePageHeader.PerformLayout();
            this.panelProfilePageNavigation.ResumeLayout(false);
            this.grbApplicationProgress.ResumeLayout(false);
            this.grbApplicationProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatusHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelProfilePageHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnProfilePageLogout;
        private System.Windows.Forms.Label lblStatusTracking;
        private System.Windows.Forms.Panel panelProfilePageNavigation;
        private System.Windows.Forms.Button btnProfilePageStatusTracking;
        private System.Windows.Forms.Button btnProfilePageDocuments;
        private System.Windows.Forms.Button btnProfilePageMyApplication;
        private System.Windows.Forms.Button btnProfilePageJobVacancies;
        private System.Windows.Forms.Button btnProfilePageMyProfile;
        private System.Windows.Forms.Button btnProfilePageDashboard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblApplicantID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCurrentStatusTitle;
        private System.Windows.Forms.Label lblSubmitted;
        private System.Windows.Forms.Label lblHrScreening;
        private System.Windows.Forms.Label lblInitialInterview;
        private System.Windows.Forms.Label lblFinalInterview;
        private System.Windows.Forms.Label lblJobOffer;
        private System.Windows.Forms.Label lblHired;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox grbApplicationProgress;
        private System.Windows.Forms.ProgressBar progressBarStatus;
        private System.Windows.Forms.DataGridView dgvStatusHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRemarks;
        private System.Windows.Forms.Label lblCurrentStatus;
    }
}
