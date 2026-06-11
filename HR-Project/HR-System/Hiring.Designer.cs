namespace HR_Project.HR_System
{
    partial class Form1
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
            this.grpDossier = new System.Windows.Forms.GroupBox();
            this.txtPanelRec = new System.Windows.Forms.TextBox();
            this.txtInterviewScore = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtScreenStatus = new System.Windows.Forms.TextBox();
            this.lblScreenLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosLabel = new System.Windows.Forms.Label();
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.txtApplicantName = new System.Windows.Forms.TextBox();
            this.grpResolution = new System.Windows.Forms.GroupBox();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarksHeading = new System.Windows.Forms.Label();
            this.pnlActionRadioGroup = new System.Windows.Forms.Panel();
            this.rbReject = new System.Windows.Forms.RadioButton();
            this.rbHold = new System.Windows.Forms.RadioButton();
            this.rbAccept = new System.Windows.Forms.RadioButton();
            this.lblDecisionHeading = new System.Windows.Forms.Label();
            this.btnCommitResolution = new System.Windows.Forms.Button();
            this.dgvApplicantList = new System.Windows.Forms.DataGridView();
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
            this.grpDossier.SuspendLayout();
            this.grpResolution.SuspendLayout();
            this.pnlActionRadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicantList)).BeginInit();
            this.panelMyDocumentsHeader.SuspendLayout();
            this.panelMyDocumentsNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDossier
            // 
            this.grpDossier.BackColor = System.Drawing.Color.Transparent;
            this.grpDossier.Controls.Add(this.txtPanelRec);
            this.grpDossier.Controls.Add(this.txtInterviewScore);
            this.grpDossier.Controls.Add(this.label3);
            this.grpDossier.Controls.Add(this.label2);
            this.grpDossier.Controls.Add(this.txtScreenStatus);
            this.grpDossier.Controls.Add(this.lblScreenLabel);
            this.grpDossier.Controls.Add(this.label1);
            this.grpDossier.Controls.Add(this.txtPosition);
            this.grpDossier.Controls.Add(this.lblPosLabel);
            this.grpDossier.Controls.Add(this.lblApplicantName);
            this.grpDossier.Controls.Add(this.txtApplicantName);
            this.grpDossier.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDossier.Location = new System.Drawing.Point(32, 119);
            this.grpDossier.Margin = new System.Windows.Forms.Padding(2);
            this.grpDossier.Name = "grpDossier";
            this.grpDossier.Padding = new System.Windows.Forms.Padding(2);
            this.grpDossier.Size = new System.Drawing.Size(328, 271);
            this.grpDossier.TabIndex = 0;
            this.grpDossier.TabStop = false;
            this.grpDossier.Text = "📂 Candidate History Summary Dossier";
            // 
            // txtPanelRec
            // 
            this.txtPanelRec.Location = new System.Drawing.Point(84, 237);
            this.txtPanelRec.Margin = new System.Windows.Forms.Padding(2);
            this.txtPanelRec.Name = "txtPanelRec";
            this.txtPanelRec.ReadOnly = true;
            this.txtPanelRec.Size = new System.Drawing.Size(195, 23);
            this.txtPanelRec.TabIndex = 10;
            // 
            // txtInterviewScore
            // 
            this.txtInterviewScore.Location = new System.Drawing.Point(84, 205);
            this.txtInterviewScore.Margin = new System.Windows.Forms.Padding(2);
            this.txtInterviewScore.Name = "txtInterviewScore";
            this.txtInterviewScore.ReadOnly = true;
            this.txtInterviewScore.Size = new System.Drawing.Size(195, 23);
            this.txtInterviewScore.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interview:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Panel Rec:";
            // 
            // txtScreenStatus
            // 
            this.txtScreenStatus.Location = new System.Drawing.Point(84, 168);
            this.txtScreenStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtScreenStatus.Name = "txtScreenStatus";
            this.txtScreenStatus.ReadOnly = true;
            this.txtScreenStatus.Size = new System.Drawing.Size(195, 23);
            this.txtScreenStatus.TabIndex = 6;
            // 
            // lblScreenLabel
            // 
            this.lblScreenLabel.AutoSize = true;
            this.lblScreenLabel.Location = new System.Drawing.Point(13, 168);
            this.lblScreenLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScreenLabel.Name = "lblScreenLabel";
            this.lblScreenLabel.Size = new System.Drawing.Size(66, 15);
            this.lblScreenLabel.TabIndex = 5;
            this.lblScreenLabel.Text = "Screening:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "📊 Pipeline Performance:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(73, 73);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(195, 23);
            this.txtPosition.TabIndex = 3;
            // 
            // lblPosLabel
            // 
            this.lblPosLabel.AutoSize = true;
            this.lblPosLabel.Location = new System.Drawing.Point(13, 73);
            this.lblPosLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPosLabel.Name = "lblPosLabel";
            this.lblPosLabel.Size = new System.Drawing.Size(54, 15);
            this.lblPosLabel.TabIndex = 2;
            this.lblPosLabel.Text = "Position:";
            // 
            // lblApplicantName
            // 
            this.lblApplicantName.AutoSize = true;
            this.lblApplicantName.Location = new System.Drawing.Point(13, 37);
            this.lblApplicantName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApplicantName.Name = "lblApplicantName";
            this.lblApplicantName.Size = new System.Drawing.Size(98, 15);
            this.lblApplicantName.TabIndex = 1;
            this.lblApplicantName.Text = "Applicant Name:";
            // 
            // txtApplicantName
            // 
            this.txtApplicantName.Location = new System.Drawing.Point(119, 37);
            this.txtApplicantName.Margin = new System.Windows.Forms.Padding(2);
            this.txtApplicantName.Name = "txtApplicantName";
            this.txtApplicantName.ReadOnly = true;
            this.txtApplicantName.Size = new System.Drawing.Size(195, 23);
            this.txtApplicantName.TabIndex = 0;
            // 
            // grpResolution
            // 
            this.grpResolution.BackColor = System.Drawing.Color.Transparent;
            this.grpResolution.Controls.Add(this.txtRemarks);
            this.grpResolution.Controls.Add(this.lblRemarksHeading);
            this.grpResolution.Controls.Add(this.pnlActionRadioGroup);
            this.grpResolution.Controls.Add(this.lblDecisionHeading);
            this.grpResolution.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpResolution.Location = new System.Drawing.Point(396, 119);
            this.grpResolution.Margin = new System.Windows.Forms.Padding(2);
            this.grpResolution.Name = "grpResolution";
            this.grpResolution.Padding = new System.Windows.Forms.Padding(2);
            this.grpResolution.Size = new System.Drawing.Size(372, 271);
            this.grpResolution.TabIndex = 1;
            this.grpResolution.TabStop = false;
            this.grpResolution.Text = "⚖️ Executive Status and Resolution Engine";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(16, 190);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(2);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(339, 79);
            this.txtRemarks.TabIndex = 3;
            // 
            // lblRemarksHeading
            // 
            this.lblRemarksHeading.AutoSize = true;
            this.lblRemarksHeading.Location = new System.Drawing.Point(13, 172);
            this.lblRemarksHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemarksHeading.Name = "lblRemarksHeading";
            this.lblRemarksHeading.Size = new System.Drawing.Size(197, 15);
            this.lblRemarksHeading.TabIndex = 2;
            this.lblRemarksHeading.Text = "✍️ Executive Board Final Remarks:";
            // 
            // pnlActionRadioGroup
            // 
            this.pnlActionRadioGroup.Controls.Add(this.rbReject);
            this.pnlActionRadioGroup.Controls.Add(this.rbHold);
            this.pnlActionRadioGroup.Controls.Add(this.rbAccept);
            this.pnlActionRadioGroup.Location = new System.Drawing.Point(16, 62);
            this.pnlActionRadioGroup.Margin = new System.Windows.Forms.Padding(2);
            this.pnlActionRadioGroup.Name = "pnlActionRadioGroup";
            this.pnlActionRadioGroup.Size = new System.Drawing.Size(337, 87);
            this.pnlActionRadioGroup.TabIndex = 1;
            // 
            // rbReject
            // 
            this.rbReject.AutoSize = true;
            this.rbReject.Location = new System.Drawing.Point(21, 55);
            this.rbReject.Margin = new System.Windows.Forms.Padding(2);
            this.rbReject.Name = "rbReject";
            this.rbReject.Size = new System.Drawing.Size(180, 19);
            this.rbReject.TabIndex = 2;
            this.rbReject.TabStop = true;
            this.rbReject.Text = "Reject Application / Archive";
            this.rbReject.UseVisualStyleBackColor = true;
            // 
            // rbHold
            // 
            this.rbHold.AutoSize = true;
            this.rbHold.Location = new System.Drawing.Point(21, 32);
            this.rbHold.Margin = new System.Windows.Forms.Padding(2);
            this.rbHold.Name = "rbHold";
            this.rbHold.Size = new System.Drawing.Size(147, 19);
            this.rbHold.TabIndex = 1;
            this.rbHold.TabStop = true;
            this.rbHold.Text = "Put Applicant On Hold";
            this.rbHold.UseVisualStyleBackColor = true;
            // 
            // rbAccept
            // 
            this.rbAccept.AutoSize = true;
            this.rbAccept.Location = new System.Drawing.Point(21, 10);
            this.rbAccept.Margin = new System.Windows.Forms.Padding(2);
            this.rbAccept.Name = "rbAccept";
            this.rbAccept.Size = new System.Drawing.Size(177, 19);
            this.rbAccept.TabIndex = 0;
            this.rbAccept.TabStop = true;
            this.rbAccept.Text = "Accept and Generate Offer";
            this.rbAccept.UseVisualStyleBackColor = true;
            // 
            // lblDecisionHeading
            // 
            this.lblDecisionHeading.AutoSize = true;
            this.lblDecisionHeading.Location = new System.Drawing.Point(13, 37);
            this.lblDecisionHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDecisionHeading.Name = "lblDecisionHeading";
            this.lblDecisionHeading.Size = new System.Drawing.Size(162, 15);
            this.lblDecisionHeading.TabIndex = 0;
            this.lblDecisionHeading.Text = "Select Final Action Decision:";
            // 
            // btnCommitResolution
            // 
            this.btnCommitResolution.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCommitResolution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommitResolution.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommitResolution.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCommitResolution.Location = new System.Drawing.Point(565, 394);
            this.btnCommitResolution.Margin = new System.Windows.Forms.Padding(2);
            this.btnCommitResolution.Name = "btnCommitResolution";
            this.btnCommitResolution.Size = new System.Drawing.Size(185, 29);
            this.btnCommitResolution.TabIndex = 2;
            this.btnCommitResolution.Text = "🔒 Commit Resolution";
            this.btnCommitResolution.UseVisualStyleBackColor = false;
            // 
            // dgvApplicantList
            // 
            this.dgvApplicantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvApplicantList.Location = new System.Drawing.Point(20, 455);
            this.dgvApplicantList.Name = "dgvApplicantList";
            this.dgvApplicantList.Size = new System.Drawing.Size(730, 150);
            this.dgvApplicantList.TabIndex = 3;
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
            this.panelMyDocumentsHeader.Size = new System.Drawing.Size(871, 60);
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
            this.btnMyDocumentsLogout.UseVisualStyleBackColor = true;
            // 
            // lblMyDocumentsTitle
            // 
            this.lblMyDocumentsTitle.AutoSize = true;
            this.lblMyDocumentsTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDocumentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblMyDocumentsTitle.Location = new System.Drawing.Point(3, 23);
            this.lblMyDocumentsTitle.Name = "lblMyDocumentsTitle";
            this.lblMyDocumentsTitle.Size = new System.Drawing.Size(147, 20);
            this.lblMyDocumentsTitle.TabIndex = 0;
            this.lblMyDocumentsTitle.Text = "Hiring Decision";
            // 
            // panelMyDocumentsNavigation
            // 
            this.panelMyDocumentsNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
            this.panelMyDocumentsNavigation.Controls.Add(this.btnReports);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnHiringDecision);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnInterviews);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnScreening);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnApplicants);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnJobVacanciesManagement);
            this.panelMyDocumentsNavigation.Controls.Add(this.btnMyDocumentsDashboard);
            this.panelMyDocumentsNavigation.Location = new System.Drawing.Point(0, 57);
            this.panelMyDocumentsNavigation.Name = "panelMyDocumentsNavigation";
            this.panelMyDocumentsNavigation.Size = new System.Drawing.Size(876, 42);
            this.panelMyDocumentsNavigation.TabIndex = 16;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.Blue;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.btnHiringDecision.BackColor = System.Drawing.Color.Blue;
            this.btnHiringDecision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnHiringDecision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnHiringDecision.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHiringDecision.ForeColor = System.Drawing.Color.White;
            this.btnHiringDecision.Location = new System.Drawing.Point(609, 9);
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
            this.btnInterviews.Location = new System.Drawing.Point(505, 9);
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
            this.btnScreening.Location = new System.Drawing.Point(387, 9);
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
            this.btnApplicants.ForeColor = System.Drawing.Color.Transparent;
            this.btnApplicants.Location = new System.Drawing.Point(271, 9);
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
            this.btnJobVacanciesManagement.Location = new System.Drawing.Point(157, 9);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HR_Project.Properties.Resources.green;
            this.ClientSize = new System.Drawing.Size(871, 617);
            this.Controls.Add(this.panelMyDocumentsNavigation);
            this.Controls.Add(this.panelMyDocumentsHeader);
            this.Controls.Add(this.dgvApplicantList);
            this.Controls.Add(this.btnCommitResolution);
            this.Controls.Add(this.grpResolution);
            this.Controls.Add(this.grpDossier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDossier.ResumeLayout(false);
            this.grpDossier.PerformLayout();
            this.grpResolution.ResumeLayout(false);
            this.grpResolution.PerformLayout();
            this.pnlActionRadioGroup.ResumeLayout(false);
            this.pnlActionRadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicantList)).EndInit();
            this.panelMyDocumentsHeader.ResumeLayout(false);
            this.panelMyDocumentsHeader.PerformLayout();
            this.panelMyDocumentsNavigation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDossier;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.TextBox txtApplicantName;
        private System.Windows.Forms.Label lblPosLabel;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblScreenLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtScreenStatus;
        private System.Windows.Forms.TextBox txtPanelRec;
        private System.Windows.Forms.TextBox txtInterviewScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpResolution;
        private System.Windows.Forms.Panel pnlActionRadioGroup;
        private System.Windows.Forms.RadioButton rbHold;
        private System.Windows.Forms.RadioButton rbAccept;
        private System.Windows.Forms.Label lblDecisionHeading;
        private System.Windows.Forms.RadioButton rbReject;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarksHeading;
        private System.Windows.Forms.Button btnCommitResolution;
        private System.Windows.Forms.DataGridView dgvApplicantList;
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

