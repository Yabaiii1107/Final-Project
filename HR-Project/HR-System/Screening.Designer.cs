namespace HR_Project.HR_System
{
    partial class Screening
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
            this.dgvScreeningList = new System.Windows.Forms.DataGridView();
            this.grpVerification = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblVerificationStatus = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.txtScreeningNotes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbExpFit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTechFit = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEduFit = new System.Windows.Forms.ComboBox();
            this.grpDecision = new System.Windows.Forms.GroupBox();
            this.btnRejectEmailNotice = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHiringDecision = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnScreening = new System.Windows.Forms.Button();
            this.btnApplicants = new System.Windows.Forms.Button();
            this.btnJobVacanciesManagement = new System.Windows.Forms.Button();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningList)).BeginInit();
            this.grpVerification.SuspendLayout();
            this.grpEvaluation.SuspendLayout();
            this.grpDecision.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvScreeningList
            // 
            this.dgvScreeningList.AllowUserToAddRows = false;
            this.dgvScreeningList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScreeningList.Location = new System.Drawing.Point(27, 410);
            this.dgvScreeningList.Name = "dgvScreeningList";
            this.dgvScreeningList.ReadOnly = true;
            this.dgvScreeningList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScreeningList.Size = new System.Drawing.Size(752, 120);
            this.dgvScreeningList.TabIndex = 18;
            this.dgvScreeningList.SelectionChanged += new System.EventHandler(this.dgvScreeningList_SelectionChanged);
            // 
            // grpVerification
            // 
            this.grpVerification.BackColor = System.Drawing.Color.Transparent;
            this.grpVerification.Controls.Add(this.checkedListBox1);
            this.grpVerification.Controls.Add(this.lblVerificationStatus);
            this.grpVerification.Controls.Add(this.txtPosition);
            this.grpVerification.Controls.Add(this.lblPosition);
            this.grpVerification.Controls.Add(this.lblApplicantName);
            this.grpVerification.Controls.Add(this.txtApplicantName);
            this.grpVerification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerification.Location = new System.Drawing.Point(27, 113);
            this.grpVerification.Margin = new System.Windows.Forms.Padding(2);
            this.grpVerification.Name = "grpVerification";
            this.grpVerification.Padding = new System.Windows.Forms.Padding(2);
            this.grpVerification.Size = new System.Drawing.Size(347, 279);
            this.grpVerification.TabIndex = 0;
            this.grpVerification.TabStop = false;
            this.grpVerification.Text = "👤 Profile and Document Verification";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Profile Completeness",
            "Valid Government ID",
            "Resume / CV",
            "Academic Transcript"});
            this.checkedListBox1.Location = new System.Drawing.Point(37, 166);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.checkedListBox1.Size = new System.Drawing.Size(197, 94);
            this.checkedListBox1.TabIndex = 5;
            // 
            // lblVerificationStatus
            // 
            this.lblVerificationStatus.AutoSize = true;
            this.lblVerificationStatus.Location = new System.Drawing.Point(14, 137);
            this.lblVerificationStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVerificationStatus.Name = "lblVerificationStatus";
            this.lblVerificationStatus.Size = new System.Drawing.Size(211, 15);
            this.lblVerificationStatus.TabIndex = 4;
            this.lblVerificationStatus.Text = "📑 System Requirement Verification:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(75, 77);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(177, 23);
            this.txtPosition.TabIndex = 3;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(14, 77);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 15);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(14, 47);
            this.lblApplicantName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(98, 15);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "Applicant Name:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(121, 45);
            this.txtApplicantName.Margin = new System.Windows.Forms.Padding(2);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(177, 23);
            this.txtApplicantName.TabIndex = 0;
            // 
            // grpEvaluation
            // 
            this.grpEvaluation.BackColor = System.Drawing.Color.Transparent;
            this.grpEvaluation.Controls.Add(this.txtScreeningNotes);
            this.grpEvaluation.Controls.Add(this.label4);
            this.grpEvaluation.Controls.Add(this.cmbExpFit);
            this.grpEvaluation.Controls.Add(this.label3);
            this.grpEvaluation.Controls.Add(this.cmbTechFit);
            this.grpEvaluation.Controls.Add(this.label2);
            this.grpEvaluation.Controls.Add(this.label1);
            this.grpEvaluation.Controls.Add(this.cmbEduFit);
            this.grpEvaluation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEvaluation.Location = new System.Drawing.Point(425, 114);
            this.grpEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Padding = new System.Windows.Forms.Padding(2);
            this.grpEvaluation.Size = new System.Drawing.Size(354, 279);
            this.grpEvaluation.TabIndex = 1;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "📊 Evaluation & Scoring Engine";
            // 
            // txtScreeningNotes
            // 
            this.txtScreeningNotes.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtScreeningNotes.Location = new System.Drawing.Point(21, 183);
            this.txtScreeningNotes.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreeningNotes.Multiline = true;
            this.txtScreeningNotes.Name = "txtScreeningNotes";
            this.txtScreeningNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtScreeningNotes.Size = new System.Drawing.Size(313, 93);
            this.txtScreeningNotes.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "✍️ HR Evaluator Screening Notes:";
            // 
            // cmbExpFit
            // 
            this.cmbExpFit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpFit.FormattingEnabled = true;
            this.cmbExpFit.Items.AddRange(new object[] {
            "Exceeds Standards",
            "",
            "",
            "Meets Expectations",
            "",
            "",
            "Below Standards"});
            this.cmbExpFit.Location = new System.Drawing.Point(113, 112);
            this.cmbExpFit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbExpFit.Name = "cmbExpFit";
            this.cmbExpFit.Size = new System.Drawing.Size(214, 23);
            this.cmbExpFit.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Experience FIt:";
            // 
            // cmbTechFit
            // 
            this.cmbTechFit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTechFit.FormattingEnabled = true;
            this.cmbTechFit.Items.AddRange(new object[] {
            "Exceeds Standards",
            "",
            "",
            "Meets Expectations",
            "",
            "",
            "Below Standards"});
            this.cmbTechFit.Location = new System.Drawing.Point(100, 77);
            this.cmbTechFit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTechFit.Name = "cmbTechFit";
            this.cmbTechFit.Size = new System.Drawing.Size(214, 23);
            this.cmbTechFit.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Technical Fit:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eduction Fit:";
            // 
            // cmbEduFit
            // 
            this.cmbEduFit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEduFit.FormattingEnabled = true;
            this.cmbEduFit.Items.AddRange(new object[] {
            "Exceeds Standards",
            "",
            "",
            "Meets Expectations",
            "",
            "",
            "Below Standards"});
            this.cmbEduFit.Location = new System.Drawing.Point(100, 42);
            this.cmbEduFit.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEduFit.Name = "cmbEduFit";
            this.cmbEduFit.Size = new System.Drawing.Size(214, 23);
            this.cmbEduFit.TabIndex = 0;
            // 
            // grpDecision
            // 
            this.grpDecision.BackColor = System.Drawing.Color.Transparent;
            this.grpDecision.Controls.Add(this.btnRejectEmailNotice);
            this.grpDecision.Controls.Add(this.btnApprove);
            this.grpDecision.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDecision.Location = new System.Drawing.Point(44, 535);
            this.grpDecision.Margin = new System.Windows.Forms.Padding(2);
            this.grpDecision.Name = "grpDecision";
            this.grpDecision.Padding = new System.Windows.Forms.Padding(2);
            this.grpDecision.Size = new System.Drawing.Size(751, 97);
            this.grpDecision.TabIndex = 2;
            this.grpDecision.TabStop = false;
            this.grpDecision.Text = "⚡ Sourcing Action Decision Traps";
            // 
            // btnRejectEmailNotice
            // 
            this.btnRejectEmailNotice.BackColor = System.Drawing.Color.Firebrick;
            this.btnRejectEmailNotice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRejectEmailNotice.Location = new System.Drawing.Point(418, 49);
            this.btnRejectEmailNotice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRejectEmailNotice.Name = "btnRejectEmailNotice";
            this.btnRejectEmailNotice.Size = new System.Drawing.Size(215, 21);
            this.btnRejectEmailNotice.TabIndex = 1;
            this.btnRejectEmailNotice.Text = "❌ Reject and Send Email Notice";
            this.btnRejectEmailNotice.UseVisualStyleBackColor = false;
            this.btnRejectEmailNotice.Click += new System.EventHandler(this.btnRejectEmailNotice_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.DarkGreen;
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnApprove.Location = new System.Drawing.Point(53, 49);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(215, 21);
            this.btnApprove.TabIndex = 0;
            this.btnApprove.Text = "✔ Approve for Interview Loop";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
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
            this.panelNavigation.Size = new System.Drawing.Size(806, 43);
            this.panelNavigation.TabIndex = 18;
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
            this.btnScreening.Enabled = false;
            this.btnScreening.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnScreening.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnScreening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnScreening.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnApplicants.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnApplicants.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnApplicants.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplicants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panelHeader.Size = new System.Drawing.Size(806, 55);
            this.panelHeader.TabIndex = 17;
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
            // 
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(684, 23);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsLogout.TabIndex = 3;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTitle.Location = new System.Drawing.Point(3, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(97, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Screening";
            // 
            // Screening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(806, 642);
            this.Controls.Add(this.dgvScreeningList);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.grpDecision);
            this.Controls.Add(this.grpEvaluation);
            this.Controls.Add(this.grpVerification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Screening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screening";
            this.Load += new System.EventHandler(this.Screening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScreeningList)).EndInit();
            this.grpVerification.ResumeLayout(false);
            this.grpVerification.PerformLayout();
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            this.grpDecision.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVerification;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblVerificationStatus;
        private System.Windows.Forms.ComboBox cmbEduFit;
        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTechFit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbExpFit;
        private System.Windows.Forms.TextBox txtScreeningNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpDecision;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnRejectEmailNotice;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHiringDecision;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.Button btnJobVacanciesManagement;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvScreeningList;
    }
}

