namespace HR_Project.HR_System
{
    partial class InterviewEvaluation
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
            this.dgvInterviewList = new System.Windows.Forms.DataGridView();
            this.grpCandidateContext = new System.Windows.Forms.GroupBox();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.lblInterviewer = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblCandidate = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grpVerdict = new System.Windows.Forms.GroupBox();
            this.lblPanelAssessment = new System.Windows.Forms.Label();
            this.cmbRecommendation = new System.Windows.Forms.ComboBox();
            this.grpScoring = new System.Windows.Forms.GroupBox();
            this.pnlPassFailGroup = new System.Windows.Forms.Panel();
            this.rbFail = new System.Windows.Forms.RadioButton();
            this.rbPass = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblEvalRemarks = new System.Windows.Forms.Label();
            this.numProblemScore = new System.Windows.Forms.NumericUpDown();
            this.numCommScore = new System.Windows.Forms.NumericUpDown();
            this.numTechScore = new System.Windows.Forms.NumericUpDown();
            this.lblCommunication = new System.Windows.Forms.Label();
            this.lblProblemSolving = new System.Windows.Forms.Label();
            this.lblTechSkill = new System.Windows.Forms.Label();
            this.btnSubmitEvaluation = new System.Windows.Forms.Button();
            this.panelMyDocumentsNavigation = new System.Windows.Forms.Panel();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHiringDecision = new System.Windows.Forms.Button();
            this.btnInterviews = new System.Windows.Forms.Button();
            this.btnScreening = new System.Windows.Forms.Button();
            this.btnApplicants = new System.Windows.Forms.Button();
            this.btnJobVacanciesManagement = new System.Windows.Forms.Button();
            this.btnMyDocumentsDashboard = new System.Windows.Forms.Button();
            this.panelMyDocumentsHeader = new System.Windows.Forms.Panel();
            this.btnProfilePageClose = new System.Windows.Forms.Button();
            this.btnMyDocumentsLogout = new System.Windows.Forms.Button();
            this.lblMyDocumentsTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviewList)).BeginInit();
            this.grpCandidateContext.SuspendLayout();
            this.grpVerdict.SuspendLayout();
            this.grpScoring.SuspendLayout();
            this.pnlPassFailGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProblemScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTechScore)).BeginInit();
            this.panelMyDocumentsNavigation.SuspendLayout();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInterviewList
            // 
            this.dgvInterviewList.AllowUserToAddRows = false;
            this.dgvInterviewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInterviewList.Location = new System.Drawing.Point(16, 547);
            this.dgvInterviewList.Name = "dgvInterviewList";
            this.dgvInterviewList.ReadOnly = true;
            this.dgvInterviewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterviewList.Size = new System.Drawing.Size(767, 120);
            this.dgvInterviewList.TabIndex = 19;
            this.dgvInterviewList.SelectionChanged += new System.EventHandler(this.dgvInterviewList_SelectionChanged);
            // 
            // grpCandidateContext
            // 
            this.grpCandidateContext.BackColor = System.Drawing.Color.White;
            this.grpCandidateContext.Controls.Add(this.txtInterviewer);
            this.grpCandidateContext.Controls.Add(this.txtPosition);
            this.grpCandidateContext.Controls.Add(this.txtApplicantName);
            this.grpCandidateContext.Controls.Add(this.lblInterviewer);
            this.grpCandidateContext.Controls.Add(this.lblPosition);
            this.grpCandidateContext.Controls.Add(this.lblCandidate);
            this.grpCandidateContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCandidateContext.Location = new System.Drawing.Point(16, 134);
            this.grpCandidateContext.Margin = new System.Windows.Forms.Padding(2);
            this.grpCandidateContext.Name = "grpCandidateContext";
            this.grpCandidateContext.Padding = new System.Windows.Forms.Padding(2);
            this.grpCandidateContext.Size = new System.Drawing.Size(316, 153);
            this.grpCandidateContext.TabIndex = 0;
            this.grpCandidateContext.TabStop = false;
            this.grpCandidateContext.Text = "👤 Candidate Data Context";
            // 
            // txtInterviewer
            // 
            this.txtInterviewer.Location = new System.Drawing.Point(97, 113);
            this.txtInterviewer.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterviewer.Name = "txtInterviewer";
            this.txtInterviewer.ReadOnly = true;
            this.txtInterviewer.Size = new System.Drawing.Size(211, 23);
            this.txtInterviewer.TabIndex = 6;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(77, 75);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(211, 23);
            this.txtPosition.TabIndex = 5;
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(89, 38);
            this.txtApplicantName.Margin = new System.Windows.Forms.Padding(2);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(211, 23);
            this.txtApplicantName.TabIndex = 4;
            // 
            // lblInterviewer
            // 
            this.lblInterviewer.AutoSize = true;
            this.lblInterviewer.Location = new System.Drawing.Point(16, 113);
            this.lblInterviewer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterviewer.Name = "lblInterviewer";
            this.lblInterviewer.Size = new System.Drawing.Size(77, 15);
            this.lblInterviewer.TabIndex = 3;
            this.lblInterviewer.Text = "Interviewer:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(16, 75);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(54, 15);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position:";
            // 
            // lblCandidate
            // 
            this.lblCandidate.AutoSize = true;
            this.lblCandidate.Location = new System.Drawing.Point(16, 38);
            this.lblCandidate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidate.Name = "lblCandidate";
            this.lblCandidate.Size = new System.Drawing.Size(65, 15);
            this.lblCandidate.TabIndex = 1;
            this.lblCandidate.Text = "Candidate:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // grpVerdict
            // 
            this.grpVerdict.BackColor = System.Drawing.Color.White;
            this.grpVerdict.Controls.Add(this.lblPanelAssessment);
            this.grpVerdict.Controls.Add(this.cmbRecommendation);
            this.grpVerdict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpVerdict.Location = new System.Drawing.Point(16, 314);
            this.grpVerdict.Margin = new System.Windows.Forms.Padding(2);
            this.grpVerdict.Name = "grpVerdict";
            this.grpVerdict.Padding = new System.Windows.Forms.Padding(2);
            this.grpVerdict.Size = new System.Drawing.Size(316, 90);
            this.grpVerdict.TabIndex = 2;
            this.grpVerdict.TabStop = false;
            this.grpVerdict.Text = "💼 Sourcing Recommendation";
            // 
            // lblPanelAssessment
            // 
            this.lblPanelAssessment.AutoSize = true;
            this.lblPanelAssessment.Location = new System.Drawing.Point(16, 33);
            this.lblPanelAssessment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPanelAssessment.Name = "lblPanelAssessment";
            this.lblPanelAssessment.Size = new System.Drawing.Size(108, 15);
            this.lblPanelAssessment.TabIndex = 7;
            this.lblPanelAssessment.Text = "Panel Assessment:";
            // 
            // cmbRecommendation
            // 
            this.cmbRecommendation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRecommendation.FormattingEnabled = true;
            this.cmbRecommendation.Items.AddRange(new object[] {
            "HIre",
            "Consider for other role",
            "Hold for future vacancy"});
            this.cmbRecommendation.Location = new System.Drawing.Point(19, 51);
            this.cmbRecommendation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRecommendation.Name = "cmbRecommendation";
            this.cmbRecommendation.Size = new System.Drawing.Size(199, 23);
            this.cmbRecommendation.TabIndex = 0;
            // 
            // grpScoring
            // 
            this.grpScoring.BackColor = System.Drawing.Color.White;
            this.grpScoring.Controls.Add(this.pnlPassFailGroup);
            this.grpScoring.Controls.Add(this.label1);
            this.grpScoring.Controls.Add(this.txtRemarks);
            this.grpScoring.Controls.Add(this.lblEvalRemarks);
            this.grpScoring.Controls.Add(this.numProblemScore);
            this.grpScoring.Controls.Add(this.numCommScore);
            this.grpScoring.Controls.Add(this.numTechScore);
            this.grpScoring.Controls.Add(this.lblCommunication);
            this.grpScoring.Controls.Add(this.lblProblemSolving);
            this.grpScoring.Controls.Add(this.lblTechSkill);
            this.grpScoring.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpScoring.Location = new System.Drawing.Point(405, 104);
            this.grpScoring.Margin = new System.Windows.Forms.Padding(2);
            this.grpScoring.Name = "grpScoring";
            this.grpScoring.Padding = new System.Windows.Forms.Padding(2);
            this.grpScoring.Size = new System.Drawing.Size(378, 402);
            this.grpScoring.TabIndex = 3;
            this.grpScoring.TabStop = false;
            this.grpScoring.Text = "📊 Evaluation Scores Tracker";
            // 
            // pnlPassFailGroup
            // 
            this.pnlPassFailGroup.Controls.Add(this.rbFail);
            this.pnlPassFailGroup.Controls.Add(this.rbPass);
            this.pnlPassFailGroup.Location = new System.Drawing.Point(7, 318);
            this.pnlPassFailGroup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPassFailGroup.Name = "pnlPassFailGroup";
            this.pnlPassFailGroup.Size = new System.Drawing.Size(357, 65);
            this.pnlPassFailGroup.TabIndex = 4;
            // 
            // rbFail
            // 
            this.rbFail.AutoSize = true;
            this.rbFail.ForeColor = System.Drawing.Color.FromArgb(220, 50, 50);
            this.rbFail.Location = new System.Drawing.Point(214, 23);
            this.rbFail.Margin = new System.Windows.Forms.Padding(2);
            this.rbFail.Name = "rbFail";
            this.rbFail.Size = new System.Drawing.Size(121, 17);
            this.rbFail.TabIndex = 1;
            this.rbFail.TabStop = true;
            this.rbFail.Text = "FAIL APPLICATION";
            this.rbFail.UseVisualStyleBackColor = true;
            // 
            // rbPass
            // 
            this.rbPass.AutoSize = true;
            this.rbPass.ForeColor = System.Drawing.Color.FromArgb(52, 199, 89);
            this.rbPass.Location = new System.Drawing.Point(33, 23);
            this.rbPass.Margin = new System.Windows.Forms.Padding(2);
            this.rbPass.Name = "rbPass";
            this.rbPass.Size = new System.Drawing.Size(125, 17);
            this.rbPass.TabIndex = 0;
            this.rbPass.TabStop = true;
            this.rbPass.Text = "PASS APPLICATION";
            this.rbPass.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 285);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "⚡ Pass / Fail Status Trigger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(7, 187);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ReadOnly = true;
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(359, 72);
            this.txtRemarks.TabIndex = 14;
            // 
            // lblEvalRemarks
            // 
            this.lblEvalRemarks.AutoSize = true;
            this.lblEvalRemarks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvalRemarks.Location = new System.Drawing.Point(4, 168);
            this.lblEvalRemarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEvalRemarks.Name = "lblEvalRemarks";
            this.lblEvalRemarks.Size = new System.Drawing.Size(186, 15);
            this.lblEvalRemarks.TabIndex = 13;
            this.lblEvalRemarks.Text = "✍️ Evaluator Notes and Remarks";
            // 
            // numProblemScore
            // 
            this.numProblemScore.Location = new System.Drawing.Point(109, 114);
            this.numProblemScore.Margin = new System.Windows.Forms.Padding(2);
            this.numProblemScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numProblemScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numProblemScore.Name = "numProblemScore";
            this.numProblemScore.Size = new System.Drawing.Size(80, 22);
            this.numProblemScore.TabIndex = 12;
            this.numProblemScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCommScore
            // 
            this.numCommScore.Location = new System.Drawing.Point(109, 75);
            this.numCommScore.Margin = new System.Windows.Forms.Padding(2);
            this.numCommScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numCommScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCommScore.Name = "numCommScore";
            this.numCommScore.Size = new System.Drawing.Size(80, 22);
            this.numCommScore.TabIndex = 11;
            this.numCommScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numTechScore
            // 
            this.numTechScore.Location = new System.Drawing.Point(99, 38);
            this.numTechScore.Margin = new System.Windows.Forms.Padding(2);
            this.numTechScore.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numTechScore.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTechScore.Name = "numTechScore";
            this.numTechScore.Size = new System.Drawing.Size(80, 22);
            this.numTechScore.TabIndex = 10;
            this.numTechScore.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblCommunication
            // 
            this.lblCommunication.AutoSize = true;
            this.lblCommunication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommunication.Location = new System.Drawing.Point(4, 75);
            this.lblCommunication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommunication.Name = "lblCommunication";
            this.lblCommunication.Size = new System.Drawing.Size(97, 15);
            this.lblCommunication.TabIndex = 9;
            this.lblCommunication.Text = "Communication:";
            // 
            // lblProblemSolving
            // 
            this.lblProblemSolving.AutoSize = true;
            this.lblProblemSolving.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProblemSolving.Location = new System.Drawing.Point(4, 113);
            this.lblProblemSolving.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProblemSolving.Name = "lblProblemSolving";
            this.lblProblemSolving.Size = new System.Drawing.Size(101, 15);
            this.lblProblemSolving.TabIndex = 8;
            this.lblProblemSolving.Text = "Problem Solving:";
            // 
            // lblTechSkill
            // 
            this.lblTechSkill.AutoSize = true;
            this.lblTechSkill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechSkill.Location = new System.Drawing.Point(4, 38);
            this.lblTechSkill.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTechSkill.Name = "lblTechSkill";
            this.lblTechSkill.Size = new System.Drawing.Size(87, 15);
            this.lblTechSkill.TabIndex = 7;
            this.lblTechSkill.Text = "Technical Skill:";
            // 
            // btnSubmitEvaluation
            // 
            this.btnSubmitEvaluation.BackColor = System.Drawing.Color.FromArgb(10, 132, 255);
            this.btnSubmitEvaluation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEvaluation.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEvaluation.ForeColor = System.Drawing.Color.White;
            this.btnSubmitEvaluation.Location = new System.Drawing.Point(618, 510);
            this.btnSubmitEvaluation.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitEvaluation.Name = "btnSubmitEvaluation";
            this.btnSubmitEvaluation.Size = new System.Drawing.Size(165, 32);
            this.btnSubmitEvaluation.TabIndex = 5;
            this.btnSubmitEvaluation.Text = "💾 Submit Evaluation";
            this.btnSubmitEvaluation.UseVisualStyleBackColor = false;
            this.btnSubmitEvaluation.Click += new System.EventHandler(this.btnSubmitEvaluation_Click);
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
            this.panelMyDocumentsNavigation.TabIndex = 16;
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
            this.btnInterviews.Enabled = false;
            this.btnInterviews.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnInterviews.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnInterviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInterviews.FlatAppearance.BorderSize = 0;
            this.btnInterviews.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterviews.ForeColor = System.Drawing.Color.White;
            this.btnInterviews.Location = new System.Drawing.Point(505, 9);
            this.btnInterviews.Name = "btnInterviews";
            this.btnInterviews.Size = new System.Drawing.Size(75, 23);
            this.btnInterviews.TabIndex = 2;
            this.btnInterviews.Text = "Interviews";
            this.btnInterviews.UseVisualStyleBackColor = false;
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
            this.btnMyDocumentsDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnMyDocumentsDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(50, 50, 70);
            this.btnMyDocumentsDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyDocumentsDashboard.FlatAppearance.BorderSize = 0;
            this.btnMyDocumentsDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyDocumentsDashboard.ForeColor = System.Drawing.Color.White;
            this.btnMyDocumentsDashboard.Location = new System.Drawing.Point(31, 9);
            this.btnMyDocumentsDashboard.Name = "btnMyDocumentsDashboard";
            this.btnMyDocumentsDashboard.Size = new System.Drawing.Size(85, 23);
            this.btnMyDocumentsDashboard.TabIndex = 0;
            this.btnMyDocumentsDashboard.Text = "Dashboard";
            this.btnMyDocumentsDashboard.UseVisualStyleBackColor = false;
            this.btnMyDocumentsDashboard.Click += new System.EventHandler(this.btnMyDocumentsDashboard_Click);
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
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(870, 60);
            this.panelMyDocumentsHeader.TabIndex = 15;
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
            // 
            // btnMyDocumentsLogout
            // 
            this.btnMyDocumentsLogout.Location = new System.Drawing.Point(752, 28);
            this.btnMyDocumentsLogout.Name = "btnMyDocumentsLogout";
            this.btnMyDocumentsLogout.Size = new System.Drawing.Size(75, 23);
            this.btnMyDocumentsLogout.TabIndex = 3;
            this.btnMyDocumentsLogout.Text = "Logout";
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = false;
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.White;
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(3, 23);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(198, 20);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "Interview Evaluation";
            // 
            // InterviewEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 712);
            this.Controls.Add(this.panelMyDocumentsNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.Controls.Add(this.btnSubmitEvaluation);
            this.Controls.Add(this.grpScoring);
            this.Controls.Add(this.grpVerdict);
            this.Controls.Add(this.grpCandidateContext);
            this.Controls.Add(this.dgvInterviewList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterviewEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InterviewEvalutaion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterviewList)).EndInit();
            this.grpCandidateContext.ResumeLayout(false);
            this.grpCandidateContext.PerformLayout();
            this.grpVerdict.ResumeLayout(false);
            this.grpVerdict.PerformLayout();
            this.grpScoring.ResumeLayout(false);
            this.grpScoring.PerformLayout();
            this.pnlPassFailGroup.ResumeLayout(false);
            this.pnlPassFailGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProblemScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCommScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTechScore)).EndInit();
            this.panelMyDocumentsNavigation.ResumeLayout(false);
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCandidateContext;
        private System.Windows.Forms.Label lblInterviewer;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblCandidate;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox grpVerdict;
        private System.Windows.Forms.ComboBox cmbRecommendation;
        private System.Windows.Forms.Label lblPanelAssessment;
        private System.Windows.Forms.GroupBox grpScoring;
        private System.Windows.Forms.Label lblCommunication;
        private System.Windows.Forms.Label lblProblemSolving;
        private System.Windows.Forms.Label lblTechSkill;
        private System.Windows.Forms.Label lblEvalRemarks;
        private System.Windows.Forms.NumericUpDown numProblemScore;
        private System.Windows.Forms.NumericUpDown numCommScore;
        private System.Windows.Forms.NumericUpDown numTechScore;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Panel pnlPassFailGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFail;
        private System.Windows.Forms.RadioButton rbPass;
        private System.Windows.Forms.Button btnSubmitEvaluation;
        private System.Windows.Forms.Panel panelMyDocumentsNavigation;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnHiringDecision;
        private System.Windows.Forms.Button btnInterviews;
        private System.Windows.Forms.Button btnScreening;
        private System.Windows.Forms.Button btnApplicants;
        private System.Windows.Forms.Button btnJobVacanciesManagement;
        private System.Windows.Forms.Button btnMyDocumentsDashboard;
        private System.Windows.Forms.Panel panelMyDocumentsHeader;
        private System.Windows.Forms.Button btnProfilePageClose;
        private System.Windows.Forms.Button btnMyDocumentsLogout;
        private System.Windows.Forms.Label lblMyDocumentsTitle;
        private System.Windows.Forms.DataGridView dgvInterviewList;
    }
}
